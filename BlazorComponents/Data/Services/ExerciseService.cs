using BlazorComponents.WASM.Data.Models;
using System.Net.Http;
using System.Text.Json;

namespace BlazorComponents.WASM.Data.Services;

public class ExerciseService
{
    public List<Exercise> Exercises = new List<Exercise>();
    private HttpClient _http;
    public ExerciseService(HttpClient http)
    {
        _http = http;
    }

    public async Task Load()
    {
        var jsonContent = await _http.GetStringAsync("/sample-data/exercises.json");
        var exercises = JsonSerializer.Deserialize<List<Exercise>>(jsonContent) ?? throw new Exception();
        Exercises = exercises;
        Exercises.ForEach(exercise => { 
            Console.WriteLine(exercise.Name);
        });
    }
}
