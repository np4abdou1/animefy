using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000107 RID: 263
	[NullableContext(1)]
	[Nullable(0)]
	public class DefaultSerializationBinder : SerializationBinder, ISerializationBinder
	{
		// Token: 0x060007A8 RID: 1960 RVA: 0x00026D38 File Offset: 0x00024F38
		public DefaultSerializationBinder()
		{
			this._typeCache = new ThreadSafeStore<StructMultiKey<string, string>, Type>(new Func<StructMultiKey<string, string>, Type>(this.GetTypeFromTypeNameKey));
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x00026D58 File Offset: 0x00024F58
		private Type GetTypeFromTypeNameKey([Nullable(new byte[]
		{
			0,
			2,
			1
		})] StructMultiKey<string, string> typeNameKey)
		{
			string value = typeNameKey.Value1;
			string value2 = typeNameKey.Value2;
			if (value == null)
			{
				return Type.GetType(value2);
			}
			Assembly assembly = Assembly.LoadWithPartialName(value);
			if (assembly == null)
			{
				foreach (Assembly assembly2 in AppDomain.CurrentDomain.GetAssemblies())
				{
					if (assembly2.FullName == value || assembly2.GetName().Name == value)
					{
						assembly = assembly2;
						break;
					}
				}
			}
			if (assembly == null)
			{
				throw new JsonSerializationException("Could not load assembly '{0}'.".FormatWith(CultureInfo.InvariantCulture, value));
			}
			Type type = assembly.GetType(value2);
			if (type == null)
			{
				if (StringUtils.IndexOf(value2, '`') >= 0)
				{
					try
					{
						type = this.GetGenericTypeFromTypeName(value2, assembly);
					}
					catch (Exception innerException)
					{
						throw new JsonSerializationException("Could not find type '{0}' in assembly '{1}'.".FormatWith(CultureInfo.InvariantCulture, value2, assembly.FullName), innerException);
					}
				}
				if (type == null)
				{
					throw new JsonSerializationException("Could not find type '{0}' in assembly '{1}'.".FormatWith(CultureInfo.InvariantCulture, value2, assembly.FullName));
				}
			}
			return type;
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x00026E7C File Offset: 0x0002507C
		[return: Nullable(2)]
		private Type GetGenericTypeFromTypeName(string typeName, Assembly assembly)
		{
			Type result = null;
			int num = StringUtils.IndexOf(typeName, '[');
			if (num >= 0)
			{
				string name = typeName.Substring(0, num);
				Type type = assembly.GetType(name);
				if (type != null)
				{
					List<Type> list = new List<Type>();
					int num2 = 0;
					int num3 = 0;
					int num4 = typeName.Length - 1;
					for (int i = num + 1; i < num4; i++)
					{
						char c = typeName[i];
						if (c != '[')
						{
							if (c == ']')
							{
								num2--;
								if (num2 == 0)
								{
									StructMultiKey<string, string> typeNameKey = ReflectionUtils.SplitFullyQualifiedTypeName(typeName.Substring(num3, i - num3));
									list.Add(this.GetTypeByName(typeNameKey));
								}
							}
						}
						else
						{
							if (num2 == 0)
							{
								num3 = i + 1;
							}
							num2++;
						}
					}
					result = type.MakeGenericType(list.ToArray());
				}
			}
			return result;
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x00026F48 File Offset: 0x00025148
		private Type GetTypeByName([Nullable(new byte[]
		{
			0,
			2,
			1
		})] StructMultiKey<string, string> typeNameKey)
		{
			return this._typeCache.Get(typeNameKey);
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x00026F56 File Offset: 0x00025156
		public override Type BindToType([Nullable(2)] string assemblyName, string typeName)
		{
			return this.GetTypeByName(new StructMultiKey<string, string>(assemblyName, typeName));
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x00026F65 File Offset: 0x00025165
		[NullableContext(2)]
		public override void BindToName([Nullable(1)] Type serializedType, out string assemblyName, out string typeName)
		{
			assemblyName = serializedType.Assembly.FullName;
			typeName = serializedType.FullName;
		}

		// Token: 0x04000502 RID: 1282
		internal static readonly DefaultSerializationBinder Instance = new DefaultSerializationBinder();

		// Token: 0x04000503 RID: 1283
		[Nullable(new byte[]
		{
			1,
			0,
			2,
			1,
			1
		})]
		private readonly ThreadSafeStore<StructMultiKey<string, string>, Type> _typeCache;
	}
}
