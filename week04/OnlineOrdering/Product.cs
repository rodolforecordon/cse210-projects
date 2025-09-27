public class Product
{
  private string _name;
  private int _productId;
  private double _price;
  private int _quantity;

  public Product(string name, int id, double price, int quantity)
  {
    _name = name;
    _productId = id;
    _price = price;
    _quantity = quantity;
  }

  public double GetTotalCost()
  {
    return _price * _quantity;
  }

  public string GetName()
  {
    return _name;
  }

  public int GetId()
  {
    return _productId;
  }

  public string DisplayProduct()
  {
    string padding = new string(' ', 20 - _name.Length);
    return $"{_name}{padding}(ID#{_productId})   X   {_quantity}   =   ${GetTotalCost().ToString("F2")}\n";
  }
}