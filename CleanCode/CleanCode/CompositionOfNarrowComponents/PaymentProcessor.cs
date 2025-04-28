namespace CleanCode.CleanCode.CompositionOfNarrowComponents;

public class PaymentProcessor : IPaymentProcessor
{
    public void ProcessPayment(PaymentInfo paymentInfo, decimal amount)
    {
        // Payment processing logic
    }
}