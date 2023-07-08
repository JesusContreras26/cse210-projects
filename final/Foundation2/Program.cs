using System;

class Program
{
    static void Main(string[] args)
    {
        Order _orderOne = new Order();

        _orderOne.NewProduct("Wallet", 2526, 5.25, 3);
        _orderOne.NewProduct("Shoes", 1423, 2.54, 3);

        _orderOne.CustomerInformation("Jesus", "Avenue 18", "San Cristobal", "Tachira", "Venezuela");

        Order _orderTwo = new Order();

        _orderTwo.NewProduct("Keyboard", 1784, 3.41, 5);
        _orderTwo.NewProduct("Mouse", 7854, 2.5, 3);

        _orderTwo.CustomerInformation("Luis", "Road 4", "Arizona", "Phoenix", "USA");

        Console.WriteLine(_orderOne.PackingLabel());
        Console.WriteLine(_orderOne.ShippingLabel());
        Console.WriteLine($"{_orderOne.TotalCost()}$");

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Packing Label:");
        Console.WriteLine(_orderTwo.PackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(_orderTwo.ShippingLabel());
        Console.WriteLine("Total Cost:");
        Console.WriteLine($"{_orderTwo.TotalCost()}$");
    }
}