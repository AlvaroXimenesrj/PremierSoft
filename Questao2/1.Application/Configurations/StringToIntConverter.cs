using System.Buffers;
using System.Buffers.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Questao2._1.Application.Configurations
{
    public class StringToIntConverter : JsonConverter<int>
    {
        public StringToIntConverter() { }

        public override int Read(ref Utf8JsonReader reader, Type type, JsonSerializerOptions options)
        {           
            var span = reader.HasValueSequence ? reader.ValueSequence.ToArray() : reader.ValueSpan;

            if (Utf8Parser.TryParse(span, out int number, out var bytesConsumed) && span.Length == bytesConsumed)
                return number;

            var data = reader.GetString();

            throw new InvalidOperationException($"'{data}' is not a correct expected value!")
            {
                Source = "LongToStringJsonConverter"
            };
        }

        public override void Write(Utf8JsonWriter writer, int value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString());
        }
    }
}
