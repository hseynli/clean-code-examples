namespace CleanCode.CleanCode.InjectableVsNewableObjects;

public interface IShippingRateCalculator
{
    decimal CalculateRate(Address shippingAddress, decimal totalWeight);
}