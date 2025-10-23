using System;

namespace System.Xml.Schema
{
	// Token: 0x0200028E RID: 654
	internal class Datatype_uuid : Datatype_anySimpleType
	{
		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x060014A6 RID: 5286 RVA: 0x0007704B File Offset: 0x0007524B
		public override Type ValueType
		{
			get
			{
				return Datatype_uuid.atomicValueType;
			}
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x060014A7 RID: 5287 RVA: 0x00077052 File Offset: 0x00075252
		internal override Type ListValueType
		{
			get
			{
				return Datatype_uuid.listValueType;
			}
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x060014A8 RID: 5288 RVA: 0x0000A216 File Offset: 0x00008416
		internal override RestrictionFlags ValidRestrictionFlags
		{
			get
			{
				return (RestrictionFlags)0;
			}
		}

		// Token: 0x060014A9 RID: 5289 RVA: 0x0007705C File Offset: 0x0007525C
		internal override int Compare(object value1, object value2)
		{
			if (!((Guid)value1).Equals(value2))
			{
				return -1;
			}
			return 0;
		}

		// Token: 0x060014AA RID: 5290 RVA: 0x00077084 File Offset: 0x00075284
		public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr)
		{
			object result;
			try
			{
				result = XmlConvert.ToGuid(s);
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

		// Token: 0x060014AB RID: 5291 RVA: 0x000770DC File Offset: 0x000752DC
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			typedValue = null;
			Guid guid;
			Exception ex = XmlConvert.TryToGuid(s, out guid);
			if (ex == null)
			{
				typedValue = guid;
				return null;
			}
			return ex;
		}

		// Token: 0x04000D8B RID: 3467
		private static readonly Type atomicValueType = typeof(Guid);

		// Token: 0x04000D8C RID: 3468
		private static readonly Type listValueType = typeof(Guid[]);
	}
}
