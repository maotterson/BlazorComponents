using BlazorComponents.WASM.Data.Models;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace BlazorComponents.WASM.Data.Json;

public class MuscleGroupJsonConverter : JsonConverter<MuscleGroup>
{
    public override MuscleGroup Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        string value = reader.GetString();
        value = value.Replace("-","").ToLower();
        return Enum.Parse<MuscleGroup>(value, true);
    }

    public override void Write(Utf8JsonWriter writer, MuscleGroup value, JsonSerializerOptions options)
    {
        string jsonValue = value.ToString().ToLower().Replace("", "-");
        writer.WriteStringValue(jsonValue);
    }
}