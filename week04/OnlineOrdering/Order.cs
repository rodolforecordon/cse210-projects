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

  public void AddProduct(params Product[] products)
  {
    foreach (Product product in products)
    {
      _products.Add(product);
    }
  }

  public double TotalCost()
  {
    double shippingCost = 0;
    double subtotal = 0;

    foreach (Product product in _products)
    {
      if (_customer.isUsa()) shippingCost = 5;
      else shippingCost = 35;

      subtotal += product.GetTotalCost();
    }

    double totalCost = subtotal + shippingCost;

    return totalCost;
  }

  public string GetPackingLabel()
  {
    string packingLabel = "";

    foreach (Product product in _products)
    {
      packingLabel += $"{product.GetName()} - ID# {product.GetId()}\n";
    }

    return packingLabel;
  }

  public string GetShippingLabel()
  {
    string customerName = _customer.GetName();
    string customerAddress = _customer.GetAddress().GetFormatedAddress();

    return $"{customerName}\n{customerAddress}";
  }

  public string DisplayOrder()
  {
    string orderDetails = "Order Details:\n\n";

    foreach (Product product in _products)
    {
      orderDetails += product.DisplayProduct();
    }

    double shipping;

    if (_customer.isUsa()) shipping = 5;
    else shipping = 35;

    orderDetails += $"\nShipping: ${shipping}";
    orderDetails += $"\nTotal: ${TotalCost():F2}";

    return orderDetails;
  }
}