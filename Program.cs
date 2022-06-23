// See https://aka.ms/new-console-template for more information
using ConsoleApp1.Entities;

List<Product> list = new List<Product>();




Console.Write("Enter the number of products: ");
int n = int.Parse(Console.ReadLine());

for(int i = 1; i <= n; i++)
{
    Console.WriteLine($"Product #{i} data");
    Console.Write("Common, used or imported (c/u/i)? ");
    char resp = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Price: ");
    double price = double.Parse(Console.ReadLine());
    if (resp == 'i')
    {
        Console.Write("Custom fee: ");
        double custom = double.Parse(Console.ReadLine());

        list.Add(new ImportedProduct(name, price, custom));
    }

    else if (resp == 'c')
    {
        list.Add(new Product(name, price));
    }
    else if (resp == 'u')
    {
        Console.Write("Manufacture date (DD/MM/YYYY): ");
        DateTime date = DateTime.Parse(Console.ReadLine());

        list.Add(new UsedProduct(name, price, date));
    }


}



Console.WriteLine();

Console.WriteLine("Price tags");


foreach(Product product in list)
{
    Console.WriteLine(product.PriceTag());
}
