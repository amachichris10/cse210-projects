using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public double GetTotalCost()
    {
        double totalCost = 0;
        foreach (Product product in _products)
        {
            totalCost += product.GetPrice() * product.GetQuantity();
        }
        return totalCost + GetShippingCost();
    }

    public int GetShippingCost()
    {
        if (_customer.GetAddress().IsInUSA())
        {
            return 5; // Shipping cost for USA
        }
        else
        {
            return 35; // Shipping cost for international
        }
    }

    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach (Product product in _products)
        {
            packingLabel += $"{product.GetName()} (ID: {product.GetProductId()}) - Quantity: {product.GetQuantity()}\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return _customer.GetAddress().getFullAddress();
    }
}