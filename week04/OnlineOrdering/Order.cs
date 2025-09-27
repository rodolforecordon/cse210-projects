public class Order
{
  private List<Product> _products;
  private Customer _customer;

  public Order(Customer customer)
  {
    _customer = customer;
    _products = [];
  }

  public Order(Customer customer, params Product[] products)
  {
    _customer = customer;
    _products = [];

    foreach (Product product in products)
    {
      _products.Add(product);
    }
  }

  public void AddProduct(Product product)
  {
    _products.Add(product);
  }
}