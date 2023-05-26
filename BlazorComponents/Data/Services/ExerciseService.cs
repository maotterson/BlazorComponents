using BlazorComponents.WASM.Data.Models;
using BlazorComponents.WASM.Data.Utils;
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
        var exerciseDtos = JsonSerializer.Deserialize<List<ExerciseDto>>(jsonContent) ?? throw new Exception();

        // todo: turn exercise dtos into exercises using the preloaded muscle groups
        Exercises = exerciseDtos.Select(edto =>
        {
            var exercise = new Exercise { Name = edto.ExerciseName, MuscleGroups = MuscleGroupCategoryUtils.GetMuscleGroupsFromSlugs(edto.MuscleGroupSlugs) };
            return exercise;
        }).ToList();
    }
}
