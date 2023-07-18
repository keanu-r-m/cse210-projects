public class Order {
    private Customer _customer;
    private List<Product> _products = new List<Product>();
    public Order(Customer customer, List<Product> products) {
        _customer = customer;
        _products = products;
    }
    public float ComputeTotalCostOrder() {
        float sumPriceProduct = 0;
        foreach(Product product in _products) {
            sumPriceProduct += product.ComputePrice();
        }
        if (_customer.IsLivingInUsa() == true) {
            return sumPriceProduct + 5;
        }
        else {
            return sumPriceProduct + 35;
        }
    }
    public void MakePackingLabel() {
        foreach(Product product in _products) {
            Console.WriteLine($"- {product.GetName()}\n  {product.GetId()}");
        }
    }
    public string MakeShippingLabel() {
        return $"{_customer.GetName()}\n{_customer.GetAddress().MakeAddress()}";
    }
}