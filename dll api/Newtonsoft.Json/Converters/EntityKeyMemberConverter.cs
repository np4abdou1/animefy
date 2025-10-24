using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001B6 RID: 438
	[NullableContext(1)]
	[Nullable(0)]
	public class EntityKeyMemberConverter : JsonConverter
	{
		// Token: 0x06000EC3 RID: 3779 RVA: 0x00041A00 File Offset: 0x0003FC00
		public override void WriteJson(JsonWriter writer, [Nullable(2)] object value, JsonSerializer serializer)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			EntityKeyMemberConverter.EnsureReflectionObject(value.GetType());
			DefaultContractResolver defaultContractResolver = serializer.ContractResolver as DefaultContractResolver;
			string value2 = (string)EntityKeyMemberConverter._reflectionObject.GetValue(value, "Key");
			object value3 = EntityKeyMemberConverter._reflectionObject.GetValue(value, "Value");
			Type type = (value3 != null) ? value3.GetType() : null;
			writer.WriteStartObject();
			writer.WritePropertyName((defaultContractResolver != null) ? defaultContractResolver.GetResolvedPropertyName("Key") : "Key");
			writer.WriteValue(value2);
			writer.WritePropertyName((defaultContractResolver != null) ? defaultContractResolver.GetResolvedPropertyName("Type") : "Type");
			writer.WriteValue((type != null) ? type.FullName : null);
			writer.WritePropertyName((defaultContractResolver != null) ? defaultContractResolver.GetResolvedPropertyName("Value") : "Value");
			if (type != null)
			{
				string value4;
				if (JsonSerializerInternalWriter.TryConvertToString(value3, type, out value4))
				{
					writer.WriteValue(value4);
				}
				else
				{
					writer.WriteValue(value3);
				}
			}
			else
			{
				writer.WriteNull();
			}
			writer.WriteEndObject();
		}

		// Token: 0x06000EC4 RID: 3780 RVA: 0x00041B08 File Offset: 0x0003FD08
		private static void ReadAndAssertProperty(JsonReader reader, string propertyName)
		{
			reader.ReadAndAssert();
			if (reader.TokenType == JsonToken.PropertyName)
			{
				object value = reader.Value;
				if (string.Equals((value != null) ? value.ToString() : null, propertyName, StringComparison.OrdinalIgnoreCase))
				{
					return;
				}
			}
			throw new JsonSerializationException("Expected JSON property '{0}'.".FormatWith(CultureInfo.InvariantCulture, propertyName));
		}

		// Token: 0x06000EC5 RID: 3781 RVA: 0x00041B58 File Offset: 0x0003FD58
		[return: Nullable(2)]
		public override object ReadJson(JsonReader reader, Type objectType, [Nullable(2)] object existingValue, JsonSerializer serializer)
		{
			EntityKeyMemberConverter.EnsureReflectionObject(objectType);
			object obj = EntityKeyMemberConverter._reflectionObject.Creator(Array.Empty<object>());
			EntityKeyMemberConverter.ReadAndAssertProperty(reader, "Key");
			reader.ReadAndAssert();
			ReflectionObject reflectionObject = EntityKeyMemberConverter._reflectionObject;
			object target = obj;
			string member = "Key";
			object value = reader.Value;
			reflectionObject.SetValue(target, member, (value != null) ? value.ToString() : null);
			EntityKeyMemberConverter.ReadAndAssertProperty(reader, "Type");
			reader.ReadAndAssert();
			object value2 = reader.Value;
			Type type = Type.GetType((value2 != null) ? value2.ToString() : null);
			EntityKeyMemberConverter.ReadAndAssertProperty(reader, "Value");
			reader.ReadAndAssert();
			EntityKeyMemberConverter._reflectionObject.SetValue(obj, "Value", serializer.Deserialize(reader, type));
			reader.ReadAndAssert();
			return obj;
		}

		// Token: 0x06000EC6 RID: 3782 RVA: 0x00041C0D File Offset: 0x0003FE0D
		private static void EnsureReflectionObject(Type objectType)
		{
			if (EntityKeyMemberConverter._reflectionObject == null)
			{
				EntityKeyMemberConverter._reflectionObject = ReflectionObject.Create(objectType, new string[]
				{
					"Key",
					"Value"
				});
			}
		}

		// Token: 0x06000EC7 RID: 3783 RVA: 0x00041C37 File Offset: 0x0003FE37
		public override bool CanConvert(Type objectType)
		{
			return objectType.AssignableToTypeName("System.Data.EntityKeyMember", false);
		}

		// Token: 0x04000801 RID: 2049
		private const string EntityKeyMemberFullTypeName = "System.Data.EntityKeyMember";

		// Token: 0x04000802 RID: 2050
		private const string KeyPropertyName = "Key";

		// Token: 0x04000803 RID: 2051
		private const string TypePropertyName = "Type";

		// Token: 0x04000804 RID: 2052
		private const string ValuePropertyName = "Value";

		// Token: 0x04000805 RID: 2053
		[Nullable(2)]
		private static ReflectionObject _reflectionObject;
	}
}
