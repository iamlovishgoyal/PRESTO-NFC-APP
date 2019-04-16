using System.Collections.Generic;
using System.Linq;

namespace Assignment4Games.Models
{

    public class Cart
    {
        private List<CartLine> lineCollection = new List<CartLine>();

        public virtual void AddItem(Game product, int quantity)
        {
            CartLine line = lineCollection
                .Where(p => p.Product.GameId == product.GameId)
                .FirstOrDefault();

            if (line == null)
            {
                lineCollection.Add(new CartLine
                {
                    Product = product,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        public virtual void RemoveLine(Game product) =>
            lineCollection.RemoveAll(l => l.Product.GameId == product.GameId);

        //public virtual decimal ComputeTotalValue() =>
        //    lineCollection.Sum(e => e.Product.Price * e.Quantity);

        public virtual void Clear() => lineCollection.Clear();

        public virtual IEnumerable<CartLine> Lines => lineCollection;
    }

    public class CartLine
    {
        public int CartLineID { get; set; }
        public Game Product { get; set; }
        public int Quantity { get; set; }
    }
}
