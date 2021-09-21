using System.Collections.Generic;
using System.Linq;

namespace SportStore.Models
{
    public class Cart
    {
        private List<CartLine> CartProductsCollection { get; set; } = new List<CartLine>();

        public virtual void Add(Product product, int count)
        {
            CartLine line = CartProductsCollection.FirstOrDefault(l => l.Product.Id == product.Id);
            if (line == null)
            {
                CartProductsCollection.Add(new CartLine {Product = product, Count = count});
            }
            else
            {
                line.Count += count;
            }
        }

        public virtual void RemoveLine(Product product)
            => CartProductsCollection.RemoveAll(l => l.Product.Id == product.Id);

        public virtual decimal TotalCost()
            => CartProductsCollection.Sum(l => l.Product.Price * l.Count);

        public virtual IEnumerable<CartLine> Lines()
            => CartProductsCollection;

        public virtual void Clear() 
            => CartProductsCollection.Clear();
    }

    public class CartLine
    {
        public Product Product { get; set; }
        public decimal Id { get; set; }
        public int Count { get; set; }
    }
}