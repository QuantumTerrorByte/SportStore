using System.Collections.Generic;
using System.Linq;
using SportStore.Models.ProductModel;

namespace SportStore.Models.Core
{
    public class Cart
    {
        private readonly List<CartLine> _сartContent = new List<CartLine>();

        public virtual void Add(Product product, int count)
        {
            CartLine line = _сartContent.FirstOrDefault(l => l.Product.Id == product.Id);
            if (line == null)
            {
                _сartContent.Add(new CartLine {Product = product, Count = count});
            }
            else
            {
                line.Count += count;
            }
        }

        public virtual void RemoveLine(Product product)
            => _сartContent.RemoveAll(l => l.Product.Id == product.Id);

        public virtual decimal TotalCost()
            => _сartContent.Sum(l => l.Product.PriceUsd * l.Count);

        public virtual IEnumerable<CartLine> Lines()
            => _сartContent;

        public virtual void Clear() 
            => _сartContent.Clear();
        
    }
}