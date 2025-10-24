using System;
using System.Collections;
using System.Reflection;

namespace System.Xml.Serialization
{
	// Token: 0x020001D3 RID: 467
	internal class ReflectionHelper
	{
		// Token: 0x06000F9E RID: 3998 RVA: 0x00062D24 File Offset: 0x00060F24
		public void RegisterSchemaType(XmlTypeMapping map, string xmlType, string ns)
		{
			string key = xmlType + "/" + ns;
			if (!this._schemaTypes.ContainsKey(key))
			{
				this._schemaTypes.Add(key, map);
			}
		}

		// Token: 0x06000F9F RID: 3999 RVA: 0x00062D5C File Offset: 0x00060F5C
		public XmlTypeMapping GetRegisteredSchemaType(string xmlType, string ns)
		{
			string key = xmlType + "/" + ns;
			return this._schemaTypes[key] as XmlTypeMapping;
		}

		// Token: 0x06000FA0 RID: 4000 RVA: 0x00062D88 File Offset: 0x00060F88
		public void RegisterClrType(XmlTypeMapping map, Type type, string ns)
		{
			if (type == typeof(object))
			{
				ns = "";
			}
			string key = type.FullName + "/" + ns;
			if (!this._clrTypes.ContainsKey(key))
			{
				this._clrTypes.Add(key, map);
			}
		}

		// Token: 0x06000FA1 RID: 4001 RVA: 0x00062DDC File Offset: 0x00060FDC
		public XmlTypeMapping GetRegisteredClrType(Type type, string ns)
		{
			if (type == typeof(object))
			{
				ns = "";
			}
			string key = type.FullName + "/" + ns;
			return this._clrTypes[key] as XmlTypeMapping;
		}

		// Token: 0x06000FA2 RID: 4002 RVA: 0x00062E28 File Offset: 0x00061028
		public static void CheckSerializableType(Type type, bool allowPrivateConstructors)
		{
			if (type.IsArray)
			{
				return;
			}
			if (!allowPrivateConstructors && type.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Type.EmptyTypes, ReflectionHelper.empty_modifiers) == null && !type.IsAbstract && !type.IsValueType)
			{
				throw new InvalidOperationException(type.FullName + " cannot be serialized because it does not have a default public constructor");
			}
			if (type.IsInterface && !TypeTranslator.GetTypeData(type).IsListType)
			{
				throw new InvalidOperationException(type.FullName + " cannot be serialized because it is an interface");
			}
			Type type2 = type;
			while (type2.IsPublic || type2.IsNestedPublic)
			{
				Type right = type2;
				type2 = type2.DeclaringType;
				if (!(type2 != null) || !(type2 != right))
				{
					return;
				}
			}
			throw new InvalidOperationException(type.FullName + " is inaccessible due to its protection level. Only public types can be processed");
		}

		// Token: 0x04000B20 RID: 2848
		private Hashtable _clrTypes = new Hashtable();

		// Token: 0x04000B21 RID: 2849
		private Hashtable _schemaTypes = new Hashtable();

		// Token: 0x04000B22 RID: 2850
		private static readonly ParameterModifier[] empty_modifiers = new ParameterModifier[0];
	}
}
