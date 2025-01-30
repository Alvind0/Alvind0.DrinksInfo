using System.Text.Json.Serialization;

namespace Alvind0.DrinksInfo.Models;

internal class CategoryList
{
    [JsonPropertyName("drinks")]
    public required List<Category> Categories { get; set; }
}
