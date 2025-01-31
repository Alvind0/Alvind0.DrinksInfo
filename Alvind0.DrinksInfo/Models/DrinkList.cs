using System.Text.Json.Serialization;
namespace Alvind0.DrinksInfo.Models;

public class DrinkList
{
    [JsonPropertyName("drinks")]
    public List<Drink> Drinks { get; set; }
}
