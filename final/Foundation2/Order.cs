using System;

public class Order{

    private Customer _customer;
    private List<Product> _products = new List<Product>();

    public void CustomerInformation(string customerName, string street, string city, string state, string country){
        _customer = new Customer(customerName, street, city, state, country);
    }

    public void NewProduct(string name, int id, double price, int quantity){
        Product _product = new Product(name, id, price, quantity);
        _products.Add(_product);

    }

    public double TotalCost(){
        double _totalcost = 0;
        foreach(Product product in _products){
            _totalcost+=product.TotalProPrice();
        }
        int shippingCost = _customer.GetAnswer() == true ? 5 : 35;
        _totalcost += shippingCost;

        return Math.Round(_totalcost, 2);
    }

    public string PackingLabel(){
        string packingLabel = "";
        int counter = 0;
        foreach(Product _product in _products){
            packingLabel += counter == _products.Count - 1 ? $"{_product.GetName()} {_product.GetId()}" : $"{_product.GetName()} {_product.GetId()}\n";
            counter ++;
        }
        return packingLabel;
    }

    public string ShippingLabel(){
        return $"{_customer.GetName()}. {_customer.CustomerAddress()}";
    }
}