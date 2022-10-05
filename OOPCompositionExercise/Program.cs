

using OOPCompositionExercise.Entities;
using OOPCompositionExercise.Entities.Clients;
using OOPCompositionExercise.Entities.Enums;
using OOPCompositionExercise.Entities.Products;
using OOPCompositionExercise.Products;
using System.Globalization;

Console.WriteLine("Enter client data");
Console.Write("Name: ");
string clientName = Console.ReadLine();
Console.Write("Email: ");
string email = Console.ReadLine();
Console.Write("Birth date (DD/MM/YYYY): ");
DateTime birtDate = DateTime.Parse(Console.ReadLine());
Console.WriteLine("Enter order data: ");
Console.Write("Status: ");
OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

//Instanciando os clientes
Client client = new Client(clientName, email, birtDate);
Order order = new Order(DateTime.Now, status, client);

Console.Write("How many items to this order? ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Enter #{i + 1} item data");
    Console.Write("Product name: ");
    string productName = Console.ReadLine();
    Console.Write("Product price: ");
    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    //Instanciando os produtos
    Product product = new Product(productName, price);

    Console.Write("Quantity: ");
    int quantity = int.Parse(Console.ReadLine());


    OrderItem orderItem = new OrderItem(quantity, price, product);

    order.AddItem(orderItem);
}

Console.WriteLine();
Console.WriteLine("ORDER SUMMARY:");
Console.WriteLine(order);