namespace CleanCode.CleanCode.CompositionOfNarrowComponents;

public interface IPaymentProcessor
{
    void ProcessPayment(PaymentInfo paymentInfo, decimal amount);
}