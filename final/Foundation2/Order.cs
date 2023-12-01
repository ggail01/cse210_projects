using System;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalPrice()
    {
        double totalPrice = 0.00;
        foreach (Product product in _products)
        {
            totalPrice += product.GetPrice();
        }

        // Adding shipping cost based on customer location
        if (_customer.IsInUSA())
        {
            totalPrice += 5.00;
        }
        else
        {
            totalPrice += 35.00;
        }

        return totalPrice;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:";
        foreach (Product product in _products)
        {
            label += $"\n{product.GetName()} (ID: {product.GetProductId()})";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        string shippingLabel =
            $"Customer name -- {_customer.GetName()} \nAddress -- {_customer.GetAddress().GetFullAddress()}";
        return shippingLabel;
    }
}