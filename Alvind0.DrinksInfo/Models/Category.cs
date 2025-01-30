using System.Text.Json.Serialization;
namespace Alvind0.DrinksInfo.Models;

public class Category
{
    [JsonPropertyName("strCategory")]
    public required string CategoryName { get; set; }
}
