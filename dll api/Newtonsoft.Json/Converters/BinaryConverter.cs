﻿using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001AB RID: 427
	[NullableContext(1)]
	[Nullable(0)]
	public class BinaryConverter : JsonConverter
	{
		// Token: 0x06000E99 RID: 3737 RVA: 0x00040B04 File Offset: 0x0003ED04
		public override void WriteJson(JsonWriter writer, [Nullable(2)] object value, JsonSerializer serializer)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			byte[] byteArray = this.GetByteArray(value);
			writer.WriteValue(byteArray);
		}

		// Token: 0x06000E9A RID: 3738 RVA: 0x00040B2C File Offset: 0x0003ED2C
		private byte[] GetByteArray(object value)
		{
			if (value.GetType().FullName == "System.Data.Linq.Binary")
			{
				BinaryConverter.EnsureReflectionObject(value.GetType());
				return (byte[])BinaryConverter._reflectionObject.GetValue(value, "ToArray");
			}
			if (value is SqlBinary)
			{
				return ((SqlBinary)value).Value;
			}
			throw new JsonSerializationException("Unexpected value type when writing binary: {0}".FormatWith(CultureInfo.InvariantCulture, value.GetType()));
		}

		// Token: 0x06000E9B RID: 3739 RVA: 0x00040BA2 File Offset: 0x0003EDA2
		private static void EnsureReflectionObject(Type t)
		{
			if (BinaryConverter._reflectionObject == null)
			{
				BinaryConverter._reflectionObject = ReflectionObject.Create(t, t.GetConstructor(new Type[]
				{
					typeof(byte[])
				}), new string[]
				{
					"ToArray"
				});
			}
		}

		// Token: 0x06000E9C RID: 3740 RVA: 0x00040BE0 File Offset: 0x0003EDE0
		[return: Nullable(2)]
		public override object ReadJson(JsonReader reader, Type objectType, [Nullable(2)] object existingValue, JsonSerializer serializer)
		{
			if (reader.TokenType == JsonToken.Null)
			{
				if (!ReflectionUtils.IsNullable(objectType))
				{
					throw JsonSerializationException.Create(reader, "Cannot convert null value to {0}.".FormatWith(CultureInfo.InvariantCulture, objectType));
				}
				return null;
			}
			else
			{
				byte[] array;
				if (reader.TokenType == JsonToken.StartArray)
				{
					array = this.ReadByteArray(reader);
				}
				else
				{
					if (reader.TokenType != JsonToken.String)
					{
						throw JsonSerializationException.Create(reader, "Unexpected token parsing binary. Expected String or StartArray, got {0}.".FormatWith(CultureInfo.InvariantCulture, reader.TokenType));
					}
					array = Convert.FromBase64String(reader.Value.ToString());
				}
				Type type = ReflectionUtils.IsNullableType(objectType) ? Nullable.GetUnderlyingType(objectType) : objectType;
				if (type.FullName == "System.Data.Linq.Binary")
				{
					BinaryConverter.EnsureReflectionObject(type);
					return BinaryConverter._reflectionObject.Creator(new object[]
					{
						array
					});
				}
				if (type == typeof(SqlBinary))
				{
					return new SqlBinary(array);
				}
				throw JsonSerializationException.Create(reader, "Unexpected object type when writing binary: {0}".FormatWith(CultureInfo.InvariantCulture, objectType));
			}
		}

		// Token: 0x06000E9D RID: 3741 RVA: 0x00040CE4 File Offset: 0x0003EEE4
		private byte[] ReadByteArray(JsonReader reader)
		{
			List<byte> list = new List<byte>();
			while (reader.Read())
			{
				JsonToken tokenType = reader.TokenType;
				if (tokenType != JsonToken.Comment)
				{
					if (tokenType != JsonToken.Integer)
					{
						if (tokenType != JsonToken.EndArray)
						{
							throw JsonSerializationException.Create(reader, "Unexpected token when reading bytes: {0}".FormatWith(CultureInfo.InvariantCulture, reader.TokenType));
						}
						return list.ToArray();
					}
					else
					{
						list.Add(Convert.ToByte(reader.Value, CultureInfo.InvariantCulture));
					}
				}
			}
			throw JsonSerializationException.Create(reader, "Unexpected end when reading bytes.");
		}

		// Token: 0x06000E9E RID: 3742 RVA: 0x00040D62 File Offset: 0x0003EF62
		public override bool CanConvert(Type objectType)
		{
			return objectType.FullName == "System.Data.Linq.Binary" || (objectType == typeof(SqlBinary) || objectType == typeof(SqlBinary?));
		}

		// Token: 0x040007F0 RID: 2032
		private const string BinaryTypeName = "System.Data.Linq.Binary";

		// Token: 0x040007F1 RID: 2033
		private const string BinaryToArrayName = "ToArray";

		// Token: 0x040007F2 RID: 2034
		[Nullable(2)]
		private static ReflectionObject _reflectionObject;
	}
}
