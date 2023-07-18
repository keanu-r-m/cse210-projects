public class Product {
    private string _name;
    private int _id;
    private float _singlePrice;
    private int _quantity;
    public Product(string name, int id, float singlePrice, int quantity) {
        _name = name;
        _id = id;
        _singlePrice = singlePrice;
        _quantity = quantity;
    }
    public string GetName() {
        return _name;
    }
    public int GetId() {
        return _id;
    }
    public float ComputePrice() {
        return _singlePrice + _quantity;
    }
}