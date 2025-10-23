using System;
using System.Collections;
using System.Globalization;
using System.Xml.Schema;

namespace System.Xml.Serialization
{
	// Token: 0x020001DA RID: 474
	internal class TypeTranslator
	{
		// Token: 0x06000FC8 RID: 4040 RVA: 0x00063A70 File Offset: 0x00061C70
		static TypeTranslator()
		{
			TypeTranslator.nameCache = Hashtable.Synchronized(TypeTranslator.nameCache);
			TypeTranslator.nameCache.Add(typeof(bool), new TypeData(typeof(bool), "boolean", true));
			TypeTranslator.nameCache.Add(typeof(short), new TypeData(typeof(short), "short", true));
			TypeTranslator.nameCache.Add(typeof(ushort), new TypeData(typeof(ushort), "unsignedShort", true));
			TypeTranslator.nameCache.Add(typeof(int), new TypeData(typeof(int), "int", true));
			TypeTranslator.nameCache.Add(typeof(uint), new TypeData(typeof(uint), "unsignedInt", true));
			TypeTranslator.nameCache.Add(typeof(long), new TypeData(typeof(long), "long", true));
			TypeTranslator.nameCache.Add(typeof(ulong), new TypeData(typeof(ulong), "unsignedLong", true));
			TypeTranslator.nameCache.Add(typeof(float), new TypeData(typeof(float), "float", true));
			TypeTranslator.nameCache.Add(typeof(double), new TypeData(typeof(double), "double", true));
			TypeTranslator.nameCache.Add(typeof(DateTime), new TypeData(typeof(DateTime), "dateTime", true));
			TypeTranslator.nameCache.Add(typeof(decimal), new TypeData(typeof(decimal), "decimal", true));
			TypeTranslator.nameCache.Add(typeof(XmlQualifiedName), new TypeData(typeof(XmlQualifiedName), "QName", true));
			TypeTranslator.nameCache.Add(typeof(string), new TypeData(typeof(string), "string", true));
			XmlSchemaPatternFacet xmlSchemaPatternFacet = new XmlSchemaPatternFacet();
			xmlSchemaPatternFacet.Value = "[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12}";
			TypeTranslator.nameCache.Add(typeof(Guid), new TypeData(typeof(Guid), "guid", true, (TypeData)TypeTranslator.nameCache[typeof(string)], xmlSchemaPatternFacet));
			TypeTranslator.nameCache.Add(typeof(byte), new TypeData(typeof(byte), "unsignedByte", true));
			TypeTranslator.nameCache.Add(typeof(sbyte), new TypeData(typeof(sbyte), "byte", true));
			TypeTranslator.nameCache.Add(typeof(char), new TypeData(typeof(char), "char", true, (TypeData)TypeTranslator.nameCache[typeof(ushort)], null));
			TypeTranslator.nameCache.Add(typeof(object), new TypeData(typeof(object), "anyType", false));
			TypeTranslator.nameCache.Add(typeof(byte[]), new TypeData(typeof(byte[]), "base64Binary", true));
			TypeTranslator.nameCache.Add(typeof(XmlNode), new TypeData(typeof(XmlNode), "XmlNode", false));
			TypeTranslator.nameCache.Add(typeof(XmlElement), new TypeData(typeof(XmlElement), "XmlElement", false));
			TypeTranslator.primitiveTypes = new Hashtable();
			foreach (object obj in TypeTranslator.nameCache.Values)
			{
				TypeData typeData = (TypeData)obj;
				TypeTranslator.primitiveTypes.Add(typeData.XmlType, typeData);
			}
			TypeTranslator.primitiveTypes.Add("date", new TypeData(typeof(DateTime), "date", true));
			TypeTranslator.primitiveTypes.Add("time", new TypeData(typeof(DateTime), "time", true));
			TypeTranslator.primitiveTypes.Add("timePeriod", new TypeData(typeof(DateTime), "timePeriod", true));
			TypeTranslator.primitiveTypes.Add("gDay", new TypeData(typeof(string), "gDay", true));
			TypeTranslator.primitiveTypes.Add("gMonthDay", new TypeData(typeof(string), "gMonthDay", true));
			TypeTranslator.primitiveTypes.Add("gYear", new TypeData(typeof(string), "gYear", true));
			TypeTranslator.primitiveTypes.Add("gYearMonth", new TypeData(typeof(string), "gYearMonth", true));
			TypeTranslator.primitiveTypes.Add("month", new TypeData(typeof(DateTime), "month", true));
			TypeTranslator.primitiveTypes.Add("NMTOKEN", new TypeData(typeof(string), "NMTOKEN", true));
			TypeTranslator.primitiveTypes.Add("NMTOKENS", new TypeData(typeof(string), "NMTOKENS", true));
			TypeTranslator.primitiveTypes.Add("Name", new TypeData(typeof(string), "Name", true));
			TypeTranslator.primitiveTypes.Add("NCName", new TypeData(typeof(string), "NCName", true));
			TypeTranslator.primitiveTypes.Add("language", new TypeData(typeof(string), "language", true));
			TypeTranslator.primitiveTypes.Add("integer", new TypeData(typeof(string), "integer", true));
			TypeTranslator.primitiveTypes.Add("positiveInteger", new TypeData(typeof(string), "positiveInteger", true));
			TypeTranslator.primitiveTypes.Add("nonPositiveInteger", new TypeData(typeof(string), "nonPositiveInteger", true));
			TypeTranslator.primitiveTypes.Add("negativeInteger", new TypeData(typeof(string), "negativeInteger", true));
			TypeTranslator.primitiveTypes.Add("nonNegativeInteger", new TypeData(typeof(string), "nonNegativeInteger", true));
			TypeTranslator.primitiveTypes.Add("ENTITIES", new TypeData(typeof(string), "ENTITIES", true));
			TypeTranslator.primitiveTypes.Add("ENTITY", new TypeData(typeof(string), "ENTITY", true));
			TypeTranslator.primitiveTypes.Add("hexBinary", new TypeData(typeof(byte[]), "hexBinary", true));
			TypeTranslator.primitiveTypes.Add("ID", new TypeData(typeof(string), "ID", true));
			TypeTranslator.primitiveTypes.Add("IDREF", new TypeData(typeof(string), "IDREF", true));
			TypeTranslator.primitiveTypes.Add("IDREFS", new TypeData(typeof(string), "IDREFS", true));
			TypeTranslator.primitiveTypes.Add("NOTATION", new TypeData(typeof(string), "NOTATION", true));
			TypeTranslator.primitiveTypes.Add("token", new TypeData(typeof(string), "token", true));
			TypeTranslator.primitiveTypes.Add("normalizedString", new TypeData(typeof(string), "normalizedString", true));
			TypeTranslator.primitiveTypes.Add("anyURI", new TypeData(typeof(string), "anyURI", true));
			TypeTranslator.primitiveTypes.Add("base64", new TypeData(typeof(byte[]), "base64", true));
			TypeTranslator.primitiveTypes.Add("duration", new TypeData(typeof(string), "duration", true));
			TypeTranslator.nullableTypes = Hashtable.Synchronized(new Hashtable());
			foreach (object obj2 in TypeTranslator.primitiveTypes)
			{
				DictionaryEntry dictionaryEntry = (DictionaryEntry)obj2;
				TypeData typeData2 = (TypeData)dictionaryEntry.Value;
				TypeData typeData3 = new TypeData(typeData2.Type, typeData2.XmlType, true);
				typeData3.IsNullable = true;
				TypeTranslator.nullableTypes.Add(dictionaryEntry.Key, typeData3);
			}
		}

		// Token: 0x06000FC9 RID: 4041 RVA: 0x00064378 File Offset: 0x00062578
		public static TypeData GetTypeData(Type type)
		{
			return TypeTranslator.GetTypeData(type, null, false);
		}

		// Token: 0x06000FCA RID: 4042 RVA: 0x00064384 File Offset: 0x00062584
		public static TypeData GetTypeData(Type runtimeType, string xmlDataType, bool underlyingEnumType = false)
		{
			if (underlyingEnumType && runtimeType.IsEnum)
			{
				runtimeType = Enum.GetUnderlyingType(runtimeType);
			}
			Type type = runtimeType;
			bool flag = false;
			if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>))
			{
				flag = true;
				type = type.GetGenericArguments()[0];
			}
			if (xmlDataType != null && xmlDataType.Length != 0)
			{
				TypeData primitiveTypeData = TypeTranslator.GetPrimitiveTypeData(xmlDataType);
				if (type.IsArray && type != primitiveTypeData.Type)
				{
					TypeData typeData = (TypeData)TypeTranslator.primitiveArrayTypes[xmlDataType];
					if (typeData != null)
					{
						return typeData;
					}
					if (primitiveTypeData.Type == type.GetElementType())
					{
						typeData = new TypeData(type, TypeTranslator.GetArrayName(primitiveTypeData.XmlType), false);
						TypeTranslator.primitiveArrayTypes[xmlDataType] = typeData;
						return typeData;
					}
					string[] array = new string[5];
					array[0] = "Cannot convert values of type '";
					int num = 1;
					Type elementType = type.GetElementType();
					array[num] = ((elementType != null) ? elementType.ToString() : null);
					array[2] = "' to '";
					array[3] = xmlDataType;
					array[4] = "'";
					throw new InvalidOperationException(string.Concat(array));
				}
				else
				{
					if (flag)
					{
						TypeData typeData2 = (TypeData)TypeTranslator.nullableTypes[primitiveTypeData.XmlType];
						if (typeData2 == null)
						{
							typeData2 = new TypeData(type, primitiveTypeData.XmlType, false);
							typeData2.IsNullable = true;
							TypeTranslator.nullableTypes[primitiveTypeData.XmlType] = typeData2;
						}
						return typeData2;
					}
					return primitiveTypeData;
				}
			}
			else
			{
				if (flag)
				{
					TypeData typeData3 = TypeTranslator.GetTypeData(type);
					if (typeData3 != null)
					{
						TypeData typeData4 = (TypeData)TypeTranslator.nullableTypes[typeData3.XmlType];
						if (typeData4 == null)
						{
							typeData4 = new TypeData(type, typeData3.XmlType, false);
							typeData4.IsNullable = true;
							TypeTranslator.nullableTypes[typeData3.XmlType] = typeData4;
						}
						return typeData4;
					}
				}
				TypeData typeData5 = TypeTranslator.nameCache[runtimeType] as TypeData;
				if (typeData5 != null)
				{
					return typeData5;
				}
				string text;
				if (type.IsArray)
				{
					text = TypeTranslator.GetArrayName(TypeTranslator.GetTypeData(type.GetElementType()).XmlType);
				}
				else if (type.IsGenericType && !type.IsGenericTypeDefinition)
				{
					text = XmlConvert.EncodeLocalName(type.Name.Substring(0, type.Name.IndexOf('`'))) + "Of";
					foreach (Type type2 in type.GetGenericArguments())
					{
						text += ((type2.IsArray || type2.IsGenericType) ? TypeTranslator.GetTypeData(type2).XmlType : CodeIdentifier.MakePascal(XmlConvert.EncodeLocalName(type2.Name)));
					}
				}
				else
				{
					text = XmlConvert.EncodeLocalName(type.Name);
				}
				typeData5 = new TypeData(type, text, false);
				if (flag)
				{
					typeData5.IsNullable = true;
				}
				TypeTranslator.nameCache[runtimeType] = typeData5;
				return typeData5;
			}
		}

		// Token: 0x06000FCB RID: 4043 RVA: 0x00064645 File Offset: 0x00062845
		public static TypeData GetPrimitiveTypeData(string typeName)
		{
			return TypeTranslator.GetPrimitiveTypeData(typeName, false);
		}

		// Token: 0x06000FCC RID: 4044 RVA: 0x00064650 File Offset: 0x00062850
		public static TypeData GetPrimitiveTypeData(string typeName, bool nullable)
		{
			TypeData typeData = (TypeData)TypeTranslator.primitiveTypes[typeName];
			if (typeData != null && !typeData.Type.IsValueType)
			{
				return typeData;
			}
			typeData = (TypeData)((nullable && TypeTranslator.nullableTypes != null) ? TypeTranslator.nullableTypes : TypeTranslator.primitiveTypes)[typeName];
			if (typeData == null)
			{
				throw new NotSupportedException("Data type '" + typeName + "' not supported");
			}
			return typeData;
		}

		// Token: 0x06000FCD RID: 4045 RVA: 0x000646BC File Offset: 0x000628BC
		public static TypeData FindPrimitiveTypeData(string typeName)
		{
			return (TypeData)TypeTranslator.primitiveTypes[typeName];
		}

		// Token: 0x06000FCE RID: 4046 RVA: 0x000646D0 File Offset: 0x000628D0
		public static string GetArrayName(string elemName)
		{
			return "ArrayOf" + char.ToUpper(elemName[0], CultureInfo.InvariantCulture).ToString() + elemName.Substring(1);
		}

		// Token: 0x06000FCF RID: 4047 RVA: 0x00064708 File Offset: 0x00062908
		public static void ParseArrayType(string arrayType, out string type, out string ns, out string dimensions)
		{
			int num = arrayType.LastIndexOf(":");
			if (num == -1)
			{
				ns = "";
			}
			else
			{
				ns = arrayType.Substring(0, num);
			}
			int num2 = arrayType.IndexOf("[", num + 1);
			if (num2 == -1)
			{
				throw new InvalidOperationException("Cannot parse WSDL array type: " + arrayType);
			}
			type = arrayType.Substring(num + 1, num2 - num - 1);
			dimensions = arrayType.Substring(num2);
		}

		// Token: 0x04000B42 RID: 2882
		private static Hashtable nameCache = new Hashtable();

		// Token: 0x04000B43 RID: 2883
		private static Hashtable primitiveTypes;

		// Token: 0x04000B44 RID: 2884
		private static Hashtable primitiveArrayTypes = Hashtable.Synchronized(new Hashtable());

		// Token: 0x04000B45 RID: 2885
		private static Hashtable nullableTypes;
	}
}
