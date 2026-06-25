using System;

namespace BehaviouralDesign;

public class Strategy
{
    public static void OnlineStore()
{
    var cart = new ShoppingCart();
    cart.AddItem("Laptop", 999.99m);
    cart.AddItem("Mouse", 29.99m);

    // Customer chooses payment at checkout
    cart.SetPaymentStrategy(new CreditCardPayment("1234567890123456", "123"));
    cart.Checkout();

    // Another customer
    cart.SetPaymentStrategy(new PayPalPayment("user@email.com"));
    cart.Checkout();

    // Crypto user
    cart.SetPaymentStrategy(new CryptoPayment("0xABC123..."));
    cart.Checkout();
}
    static void Main()
    {
        OnlineStore();
    }
}

public interface IPaymentStrategy
{
    bool Pay(decimal amount);
    string GetPaymentMethod();
}

public class CreditCardPayment : IPaymentStrategy
{
    private readonly string _cardNumber;
    private readonly string _cvv;

    public CreditCardPayment(string cardNumber, string cvv)
    {
        _cardNumber = cardNumber;
        _cvv = cvv;
    }

    public bool Pay(decimal amount)
    {
        Console.WriteLine($"💳 Processing ${amount} via Credit Card ending in {_cardNumber[^4..]}");
        // Validate card, call bank API...
        return true;
    }

    public string GetPaymentMethod() => "Credit Card";
}

public class PayPalPayment : IPaymentStrategy
{
    private readonly string _email;

    public PayPalPayment(string email) => _email = email;

    public bool Pay(decimal amount)
    {
        Console.WriteLine($"🅿️ Processing ${amount} via PayPal ({_email})");
        // Redirect to PayPal, confirm...
        return true;
    }

    public string GetPaymentMethod() => "PayPal";
}

public class CryptoPayment : IPaymentStrategy
{
    private readonly string _walletAddress;

    public CryptoPayment(string walletAddress) => _walletAddress = walletAddress;

    public bool Pay(decimal amount)
    {
        var btcAmount = amount / 30000;  // Rough conversion
        Console.WriteLine($"₿ Processing ${amount} ({btcAmount:F6} BTC) via Crypto wallet");
        // Blockchain transaction...
        return true;
    }

    public string GetPaymentMethod() => "Bitcoin";
}

public class ShoppingCart
{
    private readonly List<CartItem> _items = new();
    private IPaymentStrategy _paymentStrategy;

    public void AddItem(string name, decimal price) => _items.Add(new CartItem(name, price));

    public void SetPaymentStrategy(IPaymentStrategy strategy) => _paymentStrategy = strategy;

    public void Checkout()
    {
        var total = _items.Sum(i => i.Price);
        Console.WriteLine($"\n🛒 Cart Total: ${total}");
        Console.WriteLine($"Payment method: {_paymentStrategy.GetPaymentMethod()}");

        var success = _paymentStrategy.Pay(total);
        Console.WriteLine(success ? "✅ Order confirmed!" : "❌ Payment failed");
    }
}

public class CartItem
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public CartItem(string name, decimal price) { Name = name; Price = price; }
}