using System.Text.Json.Serialization;

namespace BlazorComponents.WASM.Data.Models;

public class Exercise
{
    public string Name { get; set; } = default!;
    public List<MuscleGroup> MuscleGroups { get; set; } = default!;

}
