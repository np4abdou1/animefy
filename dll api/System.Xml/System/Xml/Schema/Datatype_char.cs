using System;

namespace System.Xml.Schema
{
	// Token: 0x0200028C RID: 652
	internal class Datatype_char : Datatype_anySimpleType
	{
		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x0600149B RID: 5275 RVA: 0x00076EC2 File Offset: 0x000750C2
		public override Type ValueType
		{
			get
			{
				return Datatype_char.atomicValueType;
			}
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x0600149C RID: 5276 RVA: 0x00076EC9 File Offset: 0x000750C9
		internal override Type ListValueType
		{
			get
			{
				return Datatype_char.listValueType;
			}
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x0600149D RID: 5277 RVA: 0x0000A216 File Offset: 0x00008416
		internal override RestrictionFlags ValidRestrictionFlags
		{
			get
			{
				return (RestrictionFlags)0;
			}
		}

		// Token: 0x0600149E RID: 5278 RVA: 0x00076ED0 File Offset: 0x000750D0
		internal override int Compare(object value1, object value2)
		{
			return ((char)value1).CompareTo(value2);
		}

		// Token: 0x0600149F RID: 5279 RVA: 0x00076EEC File Offset: 0x000750EC
		public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr)
		{
			object result;
			try
			{
				result = XmlConvert.ToChar(s);
			}
			catch (XmlSchemaException ex)
			{
				throw ex;
			}
			catch (Exception innerException)
			{
				throw new XmlSchemaException(Res.GetString("The value '{0}' is invalid according to its data type.", new object[]
				{
					s
				}), innerException);
			}
			return result;
		}

		// Token: 0x060014A0 RID: 5280 RVA: 0x00076F44 File Offset: 0x00075144
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			typedValue = null;
			char c;
			Exception ex = XmlConvert.TryToChar(s, out c);
			if (ex == null)
			{
				typedValue = c;
				return null;
			}
			return ex;
		}

		// Token: 0x04000D89 RID: 3465
		private static readonly Type atomicValueType = typeof(char);

		// Token: 0x04000D8A RID: 3466
		private static readonly Type listValueType = typeof(char[]);
	}
}
