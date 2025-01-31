using System.Text.Json.Serialization;

namespace Alvind0.DrinksInfo.Models;

public class Drink
{
    [JsonPropertyName("strDrink")]
    public required string DrinkName { get; set; }
    [JsonPropertyName("idDrink")]
    public required string Id { get; set; }
}
