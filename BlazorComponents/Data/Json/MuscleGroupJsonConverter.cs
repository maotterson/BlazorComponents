using BlazorComponents.WASM.Data.Models;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Globalization;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorComponents.WASM.Data.Json;

public class MuscleGroupJsonConverter : JsonConverter<List<MuscleGroup>>
{
    
    public override List<MuscleGroup> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        string value = reader.GetString();
        List<MuscleGroup> muscleGroups = ConvertToMuscleGroups(value);
        return muscleGroups;
    }

    public override void Write(Utf8JsonWriter writer, List<MuscleGroup> value, JsonSerializerOptions options)
    {
        string jsonValue = ConvertToLowerCaseHyphenated(value);
        writer.WriteStringValue(jsonValue);
    }

    private List<MuscleGroup> ConvertToMuscleGroups(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            return new List<MuscleGroup>();
        }

        List<string> muscleGroupValues = value.Split('-').ToList();
        List<MuscleGroup> muscleGroups = muscleGroupValues
            .Select(ConvertToPascalCase)
            .Select(Enum.Parse<MuscleGroup>)
            .ToList();

        return muscleGroups;
    }

    private string ConvertToPascalCase(string value)
    {
        value = value.Replace("-", " ");
        value = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value);
        value = value.Replace(" ", "");
        return value;
    }

    private string ConvertToLowerCaseHyphenated(List<MuscleGroup> muscleGroups)
    {
        List<string> convertedValues = muscleGroups
            .Select(muscleGroup => ConvertToLowerCaseHyphenated(muscleGroup.ToString()))
            .ToList();

        return string.Join("-", convertedValues);
    }

    private string ConvertToLowerCaseHyphenated(string value)
    {
        value = string.Concat(value.Select((x, i) => i > 0 && char.IsUpper(x) ? "-" + x.ToString() : x.ToString())).ToLower();
        return value;
    }
}