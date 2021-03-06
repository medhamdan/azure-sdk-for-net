// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ResourceGraph.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for ColumnDataType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ColumnDataType
    {
        [EnumMember(Value = "string")]
        String,
        [EnumMember(Value = "integer")]
        Integer,
        [EnumMember(Value = "number")]
        Number,
        [EnumMember(Value = "boolean")]
        Boolean,
        [EnumMember(Value = "object")]
        Object
    }
    internal static class ColumnDataTypeEnumExtension
    {
        internal static string ToSerializedValue(this ColumnDataType? value)
        {
            return value == null ? null : ((ColumnDataType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this ColumnDataType value)
        {
            switch( value )
            {
                case ColumnDataType.String:
                    return "string";
                case ColumnDataType.Integer:
                    return "integer";
                case ColumnDataType.Number:
                    return "number";
                case ColumnDataType.Boolean:
                    return "boolean";
                case ColumnDataType.Object:
                    return "object";
            }
            return null;
        }

        internal static ColumnDataType? ParseColumnDataType(this string value)
        {
            switch( value )
            {
                case "string":
                    return ColumnDataType.String;
                case "integer":
                    return ColumnDataType.Integer;
                case "number":
                    return ColumnDataType.Number;
                case "boolean":
                    return ColumnDataType.Boolean;
                case "object":
                    return ColumnDataType.Object;
            }
            return null;
        }
    }
}
