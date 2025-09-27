public class Customer
{
  private string _name;
  private Address _address;

  public Customer(string name)
  {
    _name = name;
  }

  public Customer(string name, Address address)
  {
    _name = name;
    _address = address;
  }

  public bool isUsa()
  {
    return _address.IsUsa();
  }

  public string GetName()
  {
    return _name;
  }

  public Address GetAddress()
  {
    return _address;
  }

  public void SetAddress(Address address)
  {
    _address = address;
  }
}