using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace SQLite
{
	// Token: 0x0200002B RID: 43
	public static class Orm
	{
		// Token: 0x06000117 RID: 279 RVA: 0x00004FD0 File Offset: 0x000031D0
		public static Type GetType(object obj)
		{
			if (obj == null)
			{
				return typeof(object);
			}
			IReflectableType reflectableType = obj as IReflectableType;
			if (reflectableType != null)
			{
				return reflectableType.GetTypeInfo().AsType();
			}
			return obj.GetType();
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00005008 File Offset: 0x00003208
		public static string SqlDecl(TableMapping.Column p, bool storeDateTimeAsTicks, bool storeTimeSpanAsTicks)
		{
			string text = string.Concat(new string[]
			{
				"\"",
				p.Name,
				"\" ",
				Orm.SqlType(p, storeDateTimeAsTicks, storeTimeSpanAsTicks),
				" "
			});
			if (p.IsPK)
			{
				text += "primary key ";
			}
			if (p.IsAutoInc)
			{
				text += "autoincrement ";
			}
			if (!p.IsNullable)
			{
				text += "not null ";
			}
			if (!string.IsNullOrEmpty(p.Collation))
			{
				text = text + "collate " + p.Collation + " ";
			}
			return text;
		}

		// Token: 0x06000119 RID: 281 RVA: 0x000050B0 File Offset: 0x000032B0
		public static string SqlType(TableMapping.Column p, bool storeDateTimeAsTicks, bool storeTimeSpanAsTicks)
		{
			Type columnType = p.ColumnType;
			if (columnType == typeof(bool) || columnType == typeof(byte) || columnType == typeof(ushort) || columnType == typeof(sbyte) || columnType == typeof(short) || columnType == typeof(int) || columnType == typeof(uint) || columnType == typeof(long))
			{
				return "integer";
			}
			if (columnType == typeof(float) || columnType == typeof(double) || columnType == typeof(decimal))
			{
				return "float";
			}
			if (columnType == typeof(string) || columnType == typeof(StringBuilder) || columnType == typeof(Uri) || columnType == typeof(UriBuilder))
			{
				int? maxStringLength = p.MaxStringLength;
				if (maxStringLength != null)
				{
					return "varchar(" + maxStringLength.Value.ToString() + ")";
				}
				return "varchar";
			}
			else if (columnType == typeof(TimeSpan))
			{
				if (!storeTimeSpanAsTicks)
				{
					return "time";
				}
				return "bigint";
			}
			else if (columnType == typeof(DateTime))
			{
				if (!storeDateTimeAsTicks)
				{
					return "datetime";
				}
				return "bigint";
			}
			else
			{
				if (columnType == typeof(DateTimeOffset))
				{
					return "bigint";
				}
				if (columnType.GetTypeInfo().IsEnum)
				{
					if (p.StoreAsText)
					{
						return "varchar";
					}
					return "integer";
				}
				else
				{
					if (columnType == typeof(byte[]))
					{
						return "blob";
					}
					if (columnType == typeof(Guid))
					{
						return "varchar(36)";
					}
					string str = "Don't know about ";
					Type type = columnType;
					throw new NotSupportedException(str + ((type != null) ? type.ToString() : null));
				}
			}
		}

		// Token: 0x0600011A RID: 282 RVA: 0x000052DA File Offset: 0x000034DA
		public static bool IsPK(MemberInfo p)
		{
			return p.CustomAttributes.Any((CustomAttributeData x) => x.AttributeType == typeof(PrimaryKeyAttribute));
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00005308 File Offset: 0x00003508
		public static string Collation(MemberInfo p)
		{
			return (from x in p.CustomAttributes
			where typeof(CollationAttribute) == x.AttributeType
			select x).Select(delegate(CustomAttributeData x)
			{
				IList<CustomAttributeTypedArgument> constructorArguments = x.ConstructorArguments;
				if (constructorArguments.Count <= 0)
				{
					return "";
				}
				return (constructorArguments[0].Value as string) ?? "";
			}).FirstOrDefault<string>() ?? "";
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00005371 File Offset: 0x00003571
		public static bool IsAutoInc(MemberInfo p)
		{
			return p.CustomAttributes.Any((CustomAttributeData x) => x.AttributeType == typeof(AutoIncrementAttribute));
		}

		// Token: 0x0600011D RID: 285 RVA: 0x000053A0 File Offset: 0x000035A0
		public static FieldInfo GetField(TypeInfo t, string name)
		{
			FieldInfo declaredField = t.GetDeclaredField(name);
			if (declaredField != null)
			{
				return declaredField;
			}
			return Orm.GetField(t.BaseType.GetTypeInfo(), name);
		}

		// Token: 0x0600011E RID: 286 RVA: 0x000053D4 File Offset: 0x000035D4
		public static PropertyInfo GetProperty(TypeInfo t, string name)
		{
			PropertyInfo declaredProperty = t.GetDeclaredProperty(name);
			if (declaredProperty != null)
			{
				return declaredProperty;
			}
			return Orm.GetProperty(t.BaseType.GetTypeInfo(), name);
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00005408 File Offset: 0x00003608
		public static object InflateAttribute(CustomAttributeData x)
		{
			TypeInfo typeInfo = x.AttributeType.GetTypeInfo();
			object[] args = (from a in x.ConstructorArguments
			select a.Value).ToArray<object>();
			object obj = Activator.CreateInstance(x.AttributeType, args);
			foreach (CustomAttributeNamedArgument customAttributeNamedArgument in x.NamedArguments)
			{
				if (customAttributeNamedArgument.IsField)
				{
					Orm.GetField(typeInfo, customAttributeNamedArgument.MemberName).SetValue(obj, customAttributeNamedArgument.TypedValue.Value);
				}
				else
				{
					Orm.GetProperty(typeInfo, customAttributeNamedArgument.MemberName).SetValue(obj, customAttributeNamedArgument.TypedValue.Value);
				}
			}
			return obj;
		}

		// Token: 0x06000120 RID: 288 RVA: 0x000054EC File Offset: 0x000036EC
		public static IEnumerable<IndexedAttribute> GetIndices(MemberInfo p)
		{
			TypeInfo indexedInfo = typeof(IndexedAttribute).GetTypeInfo();
			return from x in p.CustomAttributes
			where indexedInfo.IsAssignableFrom(x.AttributeType.GetTypeInfo())
			select (IndexedAttribute)Orm.InflateAttribute(x);
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00005550 File Offset: 0x00003750
		public static int? MaxStringLength(MemberInfo p)
		{
			CustomAttributeData customAttributeData = p.CustomAttributes.FirstOrDefault((CustomAttributeData x) => x.AttributeType == typeof(MaxLengthAttribute));
			if (customAttributeData != null)
			{
				return new int?(((MaxLengthAttribute)Orm.InflateAttribute(customAttributeData)).Value);
			}
			return null;
		}

		// Token: 0x06000122 RID: 290 RVA: 0x000055AA File Offset: 0x000037AA
		public static int? MaxStringLength(PropertyInfo p)
		{
			return Orm.MaxStringLength(p);
		}

		// Token: 0x06000123 RID: 291 RVA: 0x000055B2 File Offset: 0x000037B2
		public static bool IsMarkedNotNull(MemberInfo p)
		{
			return p.CustomAttributes.Any((CustomAttributeData x) => x.AttributeType == typeof(NotNullAttribute));
		}

		// Token: 0x04000094 RID: 148
		public const int DefaultMaxStringLength = 140;

		// Token: 0x04000095 RID: 149
		public const string ImplicitPkName = "Id";

		// Token: 0x04000096 RID: 150
		public const string ImplicitIndexSuffix = "Id";
	}
}
