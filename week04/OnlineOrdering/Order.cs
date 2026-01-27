public class Order
{
  private List<Product> _product = new List<Product>();
  private Customer _customer;

  public Order(Customer customer)
  {
    _customer = customer;
  }

  public void AddProduct(Product product)
  {
    _product.Add(product);
  }

  public float GetTotalCost()
  {
    float sum = _customer.LivesInUSA() ? 5 : 35;

    foreach (Product product in _product)
    {
      sum += product.ComputeTotalCost();
    }

    return sum;
  }

  public string GetPackingLabel()
  {
    string label = "Packing Label:\n";
    
    foreach (Product product in _product)
    {
      label += product.GetPackingInfo() + "\n";
    }
    
    return label;
  }

  public string GetShippingLabel()
  {
    return "Shipping Label:\n" + _customer.GetShippingInfo();
  }
}