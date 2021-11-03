using System;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using SportStore.Infrastructure;
using SportStore.Models.ProductModel;

namespace SportStore.Models.Core
{
    public class SessionCart : Cart
    {
        [JsonIgnore] public ISession Session { get; set; } //private?

        public static Cart GetCart(IServiceProvider service)
        {
            ISession session = service.GetRequiredService<IHttpContextAccessor>()?.HttpContext?.Session;

            SessionCart cart = session?.GetJson<SessionCart>("Cart") ?? new SessionCart();
            cart.Session = session;
            return cart;
        }

        public override void Add(Product product, int count)
        {
            base.Add(product, count);
            Session.SetJson("Cart", this);
        }

        public override void RemoveLine(Product product)
        {
            base.RemoveLine(product);
            Session.SetJson("Cart", this);
        }

        public override void Clear()
        {
            base.Clear();
            Session.Remove("Cart");
        }

        public override string ToString()
        {
            return $"{base.ToString()}, {nameof(Session)}: {Session}";
        }
    }
}