using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BlazorComponents.WASM.Data.Models;
public class MuscleGroup
{
    public string Name { get; set; } = default!;
    public string Slug { get; set; } = default!;
    public MuscleGroupCategory MuscleGroupCategory { get; set; } = default!;
    
}
