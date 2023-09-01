// <auto-generated>
/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Defines OuterEnum
    /// </summary>
    public enum OuterEnum
    {
        /// <summary>
        /// Enum Placed for value: placed
        /// </summary>
        Placed = 1,

        /// <summary>
        /// Enum Approved for value: approved
        /// </summary>
        Approved = 2,

        /// <summary>
        /// Enum Delivered for value: delivered
        /// </summary>
        Delivered = 3
    }

    /// <summary>
    /// Converts <see cref="OuterEnum"/> to and from the JSON value
    /// </summary>
    public static class OuterEnumValueConverter
    {
        /// <summary>
        /// Parses a given value to <see cref="OuterEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static OuterEnum FromString(string value)
        {
            if (value.Equals("placed"))
                return OuterEnum.Placed;

            if (value.Equals("approved"))
                return OuterEnum.Approved;

            if (value.Equals("delivered"))
                return OuterEnum.Delivered;

            throw new NotImplementedException($"Could not convert value to type OuterEnum: '{value}'");
        }

        /// <summary>
        /// Parses a given value to <see cref="OuterEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static OuterEnum? FromStringOrDefault(string value)
        {
            if (value.Equals("placed"))
                return OuterEnum.Placed;

            if (value.Equals("approved"))
                return OuterEnum.Approved;

            if (value.Equals("delivered"))
                return OuterEnum.Delivered;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="OuterEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string ToJsonValue(OuterEnum value)
        {
            if (value == OuterEnum.Placed)
                return "placed";

            if (value == OuterEnum.Approved)
                return "approved";

            if (value == OuterEnum.Delivered)
                return "delivered";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="OuterEnum"/>
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>
    public class OuterEnumJsonConverter : JsonConverter<OuterEnum>
    {
        /// <summary>
        /// Returns a  from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override OuterEnum Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? rawValue = reader.GetString();

            OuterEnum? result = rawValue == null
                ? null
                : OuterEnumValueConverter.FromStringOrDefault(rawValue);

            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the OuterEnum to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="outerEnum"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, OuterEnum outerEnum, JsonSerializerOptions options)
        {
            writer.WriteStringValue(outerEnum.ToString());
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="OuterEnum"/>
    /// </summary>
    public class OuterEnumNullableJsonConverter : JsonConverter<OuterEnum?>
    {
        /// <summary>
        /// Returns a OuterEnum from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override OuterEnum? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? rawValue = reader.GetString();

            OuterEnum? result = rawValue == null
                ? null
                : OuterEnumValueConverter.FromStringOrDefault(rawValue);

            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the DateTime to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="outerEnum"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, OuterEnum? outerEnum, JsonSerializerOptions options)
        {
            writer.WriteStringValue(outerEnum?.ToString() ?? "null");
        }
    }

}
