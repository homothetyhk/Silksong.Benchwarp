using Newtonsoft.Json;

namespace Benchwarp.Benches;

internal sealed class BenchKeyJsonConverter : JsonConverter<BenchKey>
{
    public override void WriteJson(JsonWriter writer, BenchKey value, JsonSerializer serializer)
    {
        writer.WriteStartObject();
        writer.WritePropertyName(nameof(BenchKey.BenchName));
        writer.WriteValue(value.BenchName);
        writer.WritePropertyName(nameof(BenchKey.MenuArea));
        writer.WriteValue(value.MenuArea);
        writer.WriteEndObject();
    }

    public override BenchKey ReadJson(JsonReader reader, Type objectType, BenchKey existingValue, bool hasExistingValue, JsonSerializer serializer)
    {
        if (reader.TokenType == JsonToken.Null)
        {
            return default;
        }

        string? benchName = null;
        string? menuArea = null;

        // Current token is StartObject when this converter is invoked.
        while (reader.Read())
        {
            if (reader.TokenType == JsonToken.EndObject)
            {
                break;
            }

            if (reader.TokenType != JsonToken.PropertyName)
            {
                continue;
            }

            string propertyName = (string)reader.Value!;
            if (!reader.Read())
            {
                continue;
            }

            switch (propertyName)
            {
                case nameof(BenchKey.BenchName):
                    benchName = reader.Value?.ToString();
                    break;
                case nameof(BenchKey.MenuArea):
                    menuArea = reader.Value?.ToString();
                    break;
            }
        }

        if (benchName is null || menuArea is null)
        {
            throw new JsonSerializationException("Bench entries must include both BenchName and MenuArea.");
        }

        return new BenchKey(benchName, menuArea);
    }
}
