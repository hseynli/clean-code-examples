namespace CleanCode.CleanCode.EffectiveInjectionPoints;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime Now => DateTime.Now;
}