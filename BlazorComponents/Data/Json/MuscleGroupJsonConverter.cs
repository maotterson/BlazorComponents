using BlazorComponents.WASM.Data.Models;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Globalization;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorComponents.WASM.Data.Json;

public class MuscleGroupJsonConverter : JsonConverter<MuscleGroup>
{
    public override MuscleGroup Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        string value = reader.GetString()!;
        value = ConvertToPascalCase(value)!;
        return Enum.Parse<MuscleGroup>(value, true);
    }

    public override void Write(Utf8JsonWriter writer, MuscleGroup value, JsonSerializerOptions options)
    {
        string jsonValue = ConvertToLowercaseHyphenated(value.ToString());

        writer.WriteStringValue(jsonValue);
    }
    private string ConvertToPascalCase(string value)
    {
        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
        value = value.Replace("-", " ");
        value = textInfo.ToTitleCase(value).Replace(" ", "");
        return value;
    }

    private string ConvertToLowercaseHyphenated(string value)
    {
        StringBuilder stringBuilder = new StringBuilder();

        for (int i = 0; i < value.Length; i++)
        {
            if (char.IsUpper(value[i]))
            {
                if (i > 0)
                {
                    stringBuilder.Append("-");
                }
                stringBuilder.Append(char.ToLower(value[i]));
            }
            else
            {
                stringBuilder.Append(value[i]);
            }
        }

        return stringBuilder.ToString();
    }
}