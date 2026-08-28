namespace MVC_Bartender_Application.Models;

public class Order
{
    public int Id { get; set; }

    public int CocktailId { get; set; }

    public string CocktailName { get; set; } = "";

    public DateTime OrderDate { get; set; }
}