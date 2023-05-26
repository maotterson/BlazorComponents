using System.Text.Json.Serialization;

namespace BlazorComponents.WASM.Data.Models;

public class ExerciseDto
{
    [JsonPropertyName("name")]
    public string ExerciseName { get; set; } = default!;
    [JsonPropertyName("muscle-groups")]
    public List<string> MuscleGroupSlugs { get; set; } = default!;
}
