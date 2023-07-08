using System;

public class Customer{
    private string _customerName;
    private Address _address;

    public Customer(string customerName, string street, string city, string state, string country){
        _customerName = customerName;
        _address = new Address(street, city, state,  country);
    } 

    public bool GetAnswer(){
        return _address.IsUsa();
    }

    public string GetName(){
        return _customerName;
    }

    public string CustomerAddress(){
        return _address.GetAddress();
    }
}