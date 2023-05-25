using BlazorComponents.WASM.Data.Models;
using System.Text.Json;

namespace BlazorComponents.WASM.Data.Static;

public class ExerciseSamples
{
    public List<Exercise> Exercises = new List<Exercise>();
    public ExerciseSamples()
    {
        string jsonContent = File.ReadAllText(filePath);
        List<Exercise> exercises = JsonSerializer.Deserialize<List<Exercise>>(jsonContent);
        return exercises;
    }
}
