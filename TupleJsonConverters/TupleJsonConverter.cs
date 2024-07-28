﻿using System;
using System.Text.Json;

namespace TupleJsonConverters
{
    internal sealed class TupleJsonConverter<T1> : ExtendedJsonConverter<Tuple<T1>>
    {
        public override Tuple<T1> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartArray) throw new JsonException();
            T1 item1 = GetNextValue<T1>(ref reader, typeToConvert, options);
            _ = reader.Read();
            return new(item1);
        }
        public override void Write(Utf8JsonWriter writer, Tuple<T1> value, JsonSerializerOptions options)
        {
            writer.WriteStartArray();
            WriteValue(writer, value.Item1, options);
            writer.WriteEndArray();
        }
    }
    internal sealed class TupleJsonConverter<T1, T2> : ExtendedJsonConverter<Tuple<T1, T2>>
    {
        public override Tuple<T1, T2> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartArray) throw new JsonException();
            T1 item1 = GetNextValue<T1>(ref reader, typeToConvert, options);
            T2 item2 = GetNextValue<T2>(ref reader, typeToConvert, options);
            _ = reader.Read();
            return new(item1, item2);
        }
        public override void Write(Utf8JsonWriter writer, Tuple<T1, T2> value, JsonSerializerOptions options)
        {
            writer.WriteStartArray();
            WriteValue(writer, value.Item1, options);
            WriteValue(writer, value.Item2, options);
            writer.WriteEndArray();
        }
    }
    internal sealed class TupleJsonConverter<T1, T2, T3> : ExtendedJsonConverter<Tuple<T1, T2, T3>>
    {
        public override Tuple<T1, T2, T3> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartArray) throw new JsonException();
            T1 item1 = GetNextValue<T1>(ref reader, typeToConvert, options);
            T2 item2 = GetNextValue<T2>(ref reader, typeToConvert, options);
            T3 item3 = GetNextValue<T3>(ref reader, typeToConvert, options);
            _ = reader.Read();
            return new(item1, item2, item3);
        }
        public override void Write(Utf8JsonWriter writer, Tuple<T1, T2, T3> value, JsonSerializerOptions options)
        {
            writer.WriteStartArray();
            WriteValue(writer, value.Item1, options);
            WriteValue(writer, value.Item2, options);
            WriteValue(writer, value.Item3, options);
            writer.WriteEndArray();
        }
    }
    internal sealed class TupleJsonConverter<T1, T2, T3, T4> : ExtendedJsonConverter<Tuple<T1, T2, T3, T4>>
    {
        public override Tuple<T1, T2, T3, T4> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartArray) throw new JsonException();
            T1 item1 = GetNextValue<T1>(ref reader, typeToConvert, options);
            T2 item2 = GetNextValue<T2>(ref reader, typeToConvert, options);
            T3 item3 = GetNextValue<T3>(ref reader, typeToConvert, options);
            T4 item4 = GetNextValue<T4>(ref reader, typeToConvert, options);
            _ = reader.Read();
            return new(item1, item2, item3, item4);
        }
        public override void Write(Utf8JsonWriter writer, Tuple<T1, T2, T3, T4> value, JsonSerializerOptions options)
        {
            writer.WriteStartArray();
            WriteValue(writer, value.Item1, options);
            WriteValue(writer, value.Item2, options);
            WriteValue(writer, value.Item3, options);
            WriteValue(writer, value.Item4, options);
            writer.WriteEndArray();
        }
    }
    internal sealed class TupleJsonConverter<T1, T2, T3, T4, T5> : ExtendedJsonConverter<Tuple<T1, T2, T3, T4, T5>>
    {
        public override Tuple<T1, T2, T3, T4, T5> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartArray) throw new JsonException();
            T1 item1 = GetNextValue<T1>(ref reader, typeToConvert, options);
            T2 item2 = GetNextValue<T2>(ref reader, typeToConvert, options);
            T3 item3 = GetNextValue<T3>(ref reader, typeToConvert, options);
            T4 item4 = GetNextValue<T4>(ref reader, typeToConvert, options);
            T5 item5 = GetNextValue<T5>(ref reader, typeToConvert, options);
            _ = reader.Read();
            return new(item1, item2, item3, item4, item5);
        }
        public override void Write(Utf8JsonWriter writer, Tuple<T1, T2, T3, T4, T5> value, JsonSerializerOptions options)
        {
            writer.WriteStartArray();
            WriteValue(writer, value.Item1, options);
            WriteValue(writer, value.Item2, options);
            WriteValue(writer, value.Item3, options);
            WriteValue(writer, value.Item4, options);
            WriteValue(writer, value.Item5, options);
            writer.WriteEndArray();
        }
    }
    internal sealed class TupleJsonConverter<T1, T2, T3, T4, T5, T6> : ExtendedJsonConverter<Tuple<T1, T2, T3, T4, T5, T6>>
    {
        public override Tuple<T1, T2, T3, T4, T5, T6> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartArray) throw new JsonException();
            T1 item1 = GetNextValue<T1>(ref reader, typeToConvert, options);
            T2 item2 = GetNextValue<T2>(ref reader, typeToConvert, options);
            T3 item3 = GetNextValue<T3>(ref reader, typeToConvert, options);
            T4 item4 = GetNextValue<T4>(ref reader, typeToConvert, options);
            T5 item5 = GetNextValue<T5>(ref reader, typeToConvert, options);
            T6 item6 = GetNextValue<T6>(ref reader, typeToConvert, options);
            _ = reader.Read();
            return new(item1, item2, item3, item4, item5, item6);
        }
        public override void Write(Utf8JsonWriter writer, Tuple<T1, T2, T3, T4, T5, T6> value, JsonSerializerOptions options)
        {
            writer.WriteStartArray();
            WriteValue(writer, value.Item1, options);
            WriteValue(writer, value.Item2, options);
            WriteValue(writer, value.Item3, options);
            WriteValue(writer, value.Item4, options);
            WriteValue(writer, value.Item5, options);
            WriteValue(writer, value.Item6, options);
            writer.WriteEndArray();
        }
    }
    internal sealed class TupleJsonConverter<T1, T2, T3, T4, T5, T6, T7> : ExtendedJsonConverter<Tuple<T1, T2, T3, T4, T5, T6, T7>>
    {
        public override Tuple<T1, T2, T3, T4, T5, T6, T7> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartArray) throw new JsonException();
            T1 item1 = GetNextValue<T1>(ref reader, typeToConvert, options);
            T2 item2 = GetNextValue<T2>(ref reader, typeToConvert, options);
            T3 item3 = GetNextValue<T3>(ref reader, typeToConvert, options);
            T4 item4 = GetNextValue<T4>(ref reader, typeToConvert, options);
            T5 item5 = GetNextValue<T5>(ref reader, typeToConvert, options);
            T6 item6 = GetNextValue<T6>(ref reader, typeToConvert, options);
            T7 item7 = GetNextValue<T7>(ref reader, typeToConvert, options);
            _ = reader.Read();
            return new(item1, item2, item3, item4, item5, item6, item7);
        }
        public override void Write(Utf8JsonWriter writer, Tuple<T1, T2, T3, T4, T5, T6, T7> value, JsonSerializerOptions options)
        {
            writer.WriteStartArray();
            WriteValue(writer, value.Item1, options);
            WriteValue(writer, value.Item2, options);
            WriteValue(writer, value.Item3, options);
            WriteValue(writer, value.Item4, options);
            WriteValue(writer, value.Item5, options);
            WriteValue(writer, value.Item6, options);
            WriteValue(writer, value.Item7, options);
            writer.WriteEndArray();
        }
    }
    internal sealed class TupleJsonConverter<T1, T2, T3, T4, T5, T6, T7, TRest> : ExtendedJsonConverter<Tuple<T1, T2, T3, T4, T5, T6, T7, TRest>> where TRest : notnull
    {
        public override Tuple<T1, T2, T3, T4, T5, T6, T7, TRest> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartArray) throw new JsonException();
            T1 item1 = GetNextValue<T1>(ref reader, typeToConvert, options);
            T2 item2 = GetNextValue<T2>(ref reader, typeToConvert, options);
            T3 item3 = GetNextValue<T3>(ref reader, typeToConvert, options);
            T4 item4 = GetNextValue<T4>(ref reader, typeToConvert, options);
            T5 item5 = GetNextValue<T5>(ref reader, typeToConvert, options);
            T6 item6 = GetNextValue<T6>(ref reader, typeToConvert, options);
            T7 item7 = GetNextValue<T7>(ref reader, typeToConvert, options);
            TRest rest = GetNextValue<TRest>(ref reader, typeToConvert, options);
            _ = reader.Read();
            return new(item1, item2, item3, item4, item5, item6, item7, rest);
        }
        public override void Write(Utf8JsonWriter writer, Tuple<T1, T2, T3, T4, T5, T6, T7, TRest> value, JsonSerializerOptions options)
        {
            writer.WriteStartArray();
            WriteValue(writer, value.Item1, options);
            WriteValue(writer, value.Item2, options);
            WriteValue(writer, value.Item3, options);
            WriteValue(writer, value.Item4, options);
            WriteValue(writer, value.Item5, options);
            WriteValue(writer, value.Item6, options);
            WriteValue(writer, value.Item7, options);
            WriteValue(writer, value.Rest, options);
            writer.WriteEndArray();
        }
    }
}