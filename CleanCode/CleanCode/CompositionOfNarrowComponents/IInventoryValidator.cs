namespace CleanCode.CleanCode.CompositionOfNarrowComponents;

public interface IInventoryValidator
{
    bool HasSufficientInventory(int productId, int requestedQuantity);
}