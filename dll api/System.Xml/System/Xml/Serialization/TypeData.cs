using System;
using System.Collections;
using System.Globalization;
using System.Reflection;
using System.Xml.Schema;

namespace System.Xml.Serialization
{
	// Token: 0x020001D8 RID: 472
	internal class TypeData
	{
		// Token: 0x06000FAD RID: 4013 RVA: 0x000630B0 File Offset: 0x000612B0
		public TypeData(Type type, string elementName, bool isPrimitive) : this(type, elementName, isPrimitive, null, null)
		{
		}

		// Token: 0x06000FAE RID: 4014 RVA: 0x000630C0 File Offset: 0x000612C0
		public TypeData(Type type, string elementName, bool isPrimitive, TypeData mappedType, XmlSchemaPatternFacet facet)
		{
			if (type.IsGenericTypeDefinition)
			{
				throw new InvalidOperationException("Generic type definition cannot be used in serialization. Only specific generic types can be used.");
			}
			this.mappedType = mappedType;
			this.facet = facet;
			this.type = type;
			this.typeName = type.Name;
			this.fullTypeName = type.FullName.Replace('+', '.');
			if (isPrimitive)
			{
				this.sType = SchemaTypes.Primitive;
			}
			else if (type.IsEnum)
			{
				this.sType = SchemaTypes.Enum;
			}
			else if (typeof(IXmlSerializable).IsAssignableFrom(type))
			{
				this.sType = SchemaTypes.XmlSerializable;
			}
			else if (typeof(XmlNode).IsAssignableFrom(type))
			{
				this.sType = SchemaTypes.XmlNode;
			}
			else if (type.IsArray || typeof(IEnumerable).IsAssignableFrom(type))
			{
				this.sType = SchemaTypes.Array;
			}
			else
			{
				this.sType = SchemaTypes.Class;
			}
			if (this.IsListType)
			{
				this.elementName = TypeTranslator.GetArrayName(this.ListItemTypeData.XmlType);
			}
			else
			{
				this.elementName = elementName;
			}
			if (this.sType == SchemaTypes.Array || this.sType == SchemaTypes.Class)
			{
				this.hasPublicConstructor = (!type.IsInterface && (type.IsArray || type.GetConstructor(Type.EmptyTypes) != null || type.IsAbstract || type.IsValueType));
			}
			this.LookupTypeConvertor();
		}

		// Token: 0x06000FAF RID: 4015 RVA: 0x00063220 File Offset: 0x00061420
		private void LookupTypeConvertor()
		{
			Type elementType = this.type;
			if (elementType.IsArray)
			{
				elementType = elementType.GetElementType();
			}
			XmlTypeConvertorAttribute customAttribute = elementType.GetCustomAttribute<XmlTypeConvertorAttribute>();
			if (customAttribute != null)
			{
				this.typeConvertor = elementType.GetMethod(customAttribute.Method, BindingFlags.Static | BindingFlags.NonPublic);
			}
		}

		// Token: 0x06000FB0 RID: 4016 RVA: 0x00063261 File Offset: 0x00061461
		internal void ConvertForAssignment(ref object value)
		{
			if (this.typeConvertor != null)
			{
				value = this.typeConvertor.Invoke(null, new object[]
				{
					value
				});
			}
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06000FB1 RID: 4017 RVA: 0x0006328A File Offset: 0x0006148A
		public string TypeName
		{
			get
			{
				return this.typeName;
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000FB2 RID: 4018 RVA: 0x00063292 File Offset: 0x00061492
		public string XmlType
		{
			get
			{
				return this.elementName;
			}
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000FB3 RID: 4019 RVA: 0x0006329A File Offset: 0x0006149A
		public Type Type
		{
			get
			{
				return this.type;
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000FB4 RID: 4020 RVA: 0x000632A2 File Offset: 0x000614A2
		public string FullTypeName
		{
			get
			{
				return this.fullTypeName;
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06000FB5 RID: 4021 RVA: 0x000632AA File Offset: 0x000614AA
		public SchemaTypes SchemaType
		{
			get
			{
				return this.sType;
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000FB6 RID: 4022 RVA: 0x000632B2 File Offset: 0x000614B2
		public bool IsListType
		{
			get
			{
				return this.SchemaType == SchemaTypes.Array;
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000FB7 RID: 4023 RVA: 0x000632BD File Offset: 0x000614BD
		public bool IsComplexType
		{
			get
			{
				return this.SchemaType == SchemaTypes.Class || this.SchemaType == SchemaTypes.Array || this.SchemaType == SchemaTypes.Enum || this.SchemaType == SchemaTypes.XmlNode || this.SchemaType == SchemaTypes.XmlSerializable || !this.IsXsdType;
			}
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000FB8 RID: 4024 RVA: 0x000632F7 File Offset: 0x000614F7
		public bool IsValueType
		{
			get
			{
				if (this.type != null)
				{
					return this.type.IsValueType;
				}
				return this.sType == SchemaTypes.Primitive || this.sType == SchemaTypes.Enum;
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06000FB9 RID: 4025 RVA: 0x00063328 File Offset: 0x00061528
		// (set) Token: 0x06000FBA RID: 4026 RVA: 0x00063380 File Offset: 0x00061580
		public bool IsNullable
		{
			get
			{
				return this.nullableOverride || !this.IsValueType || (this.type != null && this.type.IsGenericType && this.type.GetGenericTypeDefinition() == typeof(Nullable<>));
			}
			set
			{
				this.nullableOverride = value;
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06000FBB RID: 4027 RVA: 0x00063389 File Offset: 0x00061589
		public TypeData ListItemTypeData
		{
			get
			{
				if (this.listItemTypeData == null && this.type != null)
				{
					this.listItemTypeData = TypeTranslator.GetTypeData(this.ListItemType);
				}
				return this.listItemTypeData;
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000FBC RID: 4028 RVA: 0x000633B8 File Offset: 0x000615B8
		public Type ListItemType
		{
			get
			{
				if (this.type == null)
				{
					throw new InvalidOperationException("Property ListItemType is not supported for custom types");
				}
				if (this.listItemType != null)
				{
					return this.listItemType;
				}
				Type left = null;
				if (this.SchemaType != SchemaTypes.Array)
				{
					throw new InvalidOperationException(this.Type.FullName + " is not a collection");
				}
				if (this.type.IsArray)
				{
					this.listItemType = this.type.GetElementType();
				}
				else if (typeof(ICollection).IsAssignableFrom(this.type) || (left = TypeData.GetGenericListItemType(this.type)) != null)
				{
					if (typeof(IDictionary).IsAssignableFrom(this.type))
					{
						throw new NotSupportedException(string.Format(CultureInfo.InvariantCulture, "The type {0} is not supported because it implements IDictionary.", this.type.FullName));
					}
					if (left != null)
					{
						this.listItemType = left;
					}
					else
					{
						PropertyInfo indexerProperty = TypeData.GetIndexerProperty(this.type);
						if (indexerProperty == null)
						{
							throw new InvalidOperationException("You must implement a default accessor on " + this.type.FullName + " because it inherits from ICollection");
						}
						this.listItemType = indexerProperty.PropertyType;
					}
					if (this.type.GetMethod("Add", new Type[]
					{
						this.listItemType
					}) == null)
					{
						throw TypeData.CreateMissingAddMethodException(this.type, "ICollection", this.listItemType);
					}
				}
				else
				{
					MethodInfo method = this.type.GetMethod("GetEnumerator", Type.EmptyTypes);
					if (method == null)
					{
						method = this.type.GetMethod("System.Collections.IEnumerable.GetEnumerator", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Type.EmptyTypes, null);
					}
					PropertyInfo property = method.ReturnType.GetProperty("Current");
					if (property == null)
					{
						this.listItemType = typeof(object);
					}
					else
					{
						this.listItemType = property.PropertyType;
					}
					if (this.type.GetMethod("Add", new Type[]
					{
						this.listItemType
					}) == null)
					{
						throw TypeData.CreateMissingAddMethodException(this.type, "IEnumerable", this.listItemType);
					}
				}
				return this.listItemType;
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000FBD RID: 4029 RVA: 0x000635EB File Offset: 0x000617EB
		public bool IsXsdType
		{
			get
			{
				return this.mappedType == null;
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000FBE RID: 4030 RVA: 0x000635F6 File Offset: 0x000617F6
		public bool HasPublicConstructor
		{
			get
			{
				return this.hasPublicConstructor;
			}
		}

		// Token: 0x06000FBF RID: 4031 RVA: 0x00063600 File Offset: 0x00061800
		public static PropertyInfo GetIndexerProperty(Type collectionType)
		{
			foreach (PropertyInfo propertyInfo in collectionType.GetProperties(BindingFlags.Instance | BindingFlags.Public))
			{
				ParameterInfo[] indexParameters = propertyInfo.GetIndexParameters();
				if (indexParameters != null && indexParameters.Length == 1 && indexParameters[0].ParameterType == typeof(int))
				{
					return propertyInfo;
				}
			}
			return null;
		}

		// Token: 0x06000FC0 RID: 4032 RVA: 0x00063654 File Offset: 0x00061854
		private static InvalidOperationException CreateMissingAddMethodException(Type type, string inheritFrom, Type argumentType)
		{
			return new InvalidOperationException(string.Format(CultureInfo.InvariantCulture, "To be XML serializable, types which inherit from {0} must have an implementation of Add({1}) at all levels of their inheritance hierarchy. {2} does not implement Add({1}).", inheritFrom, argumentType.FullName, type.FullName));
		}

		// Token: 0x06000FC1 RID: 4033 RVA: 0x00063678 File Offset: 0x00061878
		internal static Type GetGenericListItemType(Type type)
		{
			if (type.IsGenericType && typeof(IEnumerable).IsAssignableFrom(type.GetGenericTypeDefinition()))
			{
				Type[] genericArguments = type.GetGenericArguments();
				if (type.GetMethod("Add", genericArguments) != null)
				{
					return genericArguments[0];
				}
			}
			Type[] interfaces = type.GetInterfaces();
			for (int i = 0; i < interfaces.Length; i++)
			{
				Type genericListItemType;
				if ((genericListItemType = TypeData.GetGenericListItemType(interfaces[i])) != null)
				{
					return genericListItemType;
				}
			}
			return null;
		}

		// Token: 0x04000B33 RID: 2867
		private Type type;

		// Token: 0x04000B34 RID: 2868
		private string elementName;

		// Token: 0x04000B35 RID: 2869
		private SchemaTypes sType;

		// Token: 0x04000B36 RID: 2870
		private Type listItemType;

		// Token: 0x04000B37 RID: 2871
		private string typeName;

		// Token: 0x04000B38 RID: 2872
		private string fullTypeName;

		// Token: 0x04000B39 RID: 2873
		private TypeData listItemTypeData;

		// Token: 0x04000B3A RID: 2874
		private TypeData mappedType;

		// Token: 0x04000B3B RID: 2875
		private XmlSchemaPatternFacet facet;

		// Token: 0x04000B3C RID: 2876
		private MethodInfo typeConvertor;

		// Token: 0x04000B3D RID: 2877
		private bool hasPublicConstructor = true;

		// Token: 0x04000B3E RID: 2878
		private bool nullableOverride;

		// Token: 0x04000B3F RID: 2879
		private static string[] keywords = new string[]
		{
			"abstract",
			"event",
			"new",
			"struct",
			"as",
			"explicit",
			"null",
			"switch",
			"base",
			"extern",
			"this",
			"false",
			"operator",
			"throw",
			"break",
			"finally",
			"out",
			"true",
			"fixed",
			"override",
			"try",
			"case",
			"params",
			"typeof",
			"catch",
			"for",
			"private",
			"foreach",
			"protected",
			"checked",
			"goto",
			"public",
			"unchecked",
			"class",
			"if",
			"readonly",
			"unsafe",
			"const",
			"implicit",
			"ref",
			"continue",
			"in",
			"return",
			"using",
			"virtual",
			"default",
			"interface",
			"sealed",
			"volatile",
			"delegate",
			"internal",
			"do",
			"is",
			"sizeof",
			"while",
			"lock",
			"stackalloc",
			"else",
			"static",
			"enum",
			"namespace",
			"object",
			"bool",
			"byte",
			"float",
			"uint",
			"char",
			"ulong",
			"ushort",
			"decimal",
			"int",
			"sbyte",
			"short",
			"double",
			"long",
			"string",
			"void",
			"partial",
			"yield",
			"where"
		};
	}
}
