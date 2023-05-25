using System.Text.Json.Serialization;

namespace BlazorComponents.WASM.Data.Models;

public class Exercise
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = default!;
    [JsonPropertyName("muscle-groups")]
    public List<MuscleGroup> MuscleGroups { get; set; } = default!;

}
