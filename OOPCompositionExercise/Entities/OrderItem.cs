

using OOPCompositionExercise.Products;

namespace OOPCompositionExercise.Entities
{
    internal class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        Product Product { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public static double SubTotal()
        {
            return 1.1;
        }
    }
}
