using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001BE RID: 446
	[NullableContext(1)]
	[Nullable(0)]
	public class VersionConverter : JsonConverter
	{
		// Token: 0x06000F03 RID: 3843 RVA: 0x00042BFE File Offset: 0x00040DFE
		public override void WriteJson(JsonWriter writer, [Nullable(2)] object value, JsonSerializer serializer)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			if (value is Version)
			{
				writer.WriteValue(value.ToString());
				return;
			}
			throw new JsonSerializationException("Expected Version object value");
		}

		// Token: 0x06000F04 RID: 3844 RVA: 0x00042C2C File Offset: 0x00040E2C
		[return: Nullable(2)]
		public override object ReadJson(JsonReader reader, Type objectType, [Nullable(2)] object existingValue, JsonSerializer serializer)
		{
			if (reader.TokenType == JsonToken.Null)
			{
				return null;
			}
			if (reader.TokenType == JsonToken.String)
			{
				try
				{
					return new Version((string)reader.Value);
				}
				catch (Exception ex)
				{
					throw JsonSerializationException.Create(reader, "Error parsing version string: {0}".FormatWith(CultureInfo.InvariantCulture, reader.Value), ex);
				}
			}
			throw JsonSerializationException.Create(reader, "Unexpected token or value when parsing version. Token: {0}, Value: {1}".FormatWith(CultureInfo.InvariantCulture, reader.TokenType, reader.Value));
		}

		// Token: 0x06000F05 RID: 3845 RVA: 0x00042CB8 File Offset: 0x00040EB8
		public override bool CanConvert(Type objectType)
		{
			return objectType == typeof(Version);
		}
	}
}
