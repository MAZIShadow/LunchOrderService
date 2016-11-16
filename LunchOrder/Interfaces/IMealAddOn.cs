namespace LunchOrder.Interfaces
{
    public interface IMealAddOn
    {
        long? Id { get; set; }
        string MealAddOnName { get; set; }
        decimal MealAddOnPrice { get; set; }
    }
}