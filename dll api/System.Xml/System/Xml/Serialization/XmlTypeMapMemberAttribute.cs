using System;
using System.Xml.Schema;

namespace System.Xml.Serialization
{
	// Token: 0x02000210 RID: 528
	internal class XmlTypeMapMemberAttribute : XmlTypeMapMember
	{
		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06001190 RID: 4496 RVA: 0x0006DF06 File Offset: 0x0006C106
		// (set) Token: 0x06001191 RID: 4497 RVA: 0x0006DF0E File Offset: 0x0006C10E
		public string AttributeName
		{
			get
			{
				return this._attributeName;
			}
			set
			{
				this._attributeName = value;
			}
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06001192 RID: 4498 RVA: 0x0006DF17 File Offset: 0x0006C117
		// (set) Token: 0x06001193 RID: 4499 RVA: 0x0006DF1F File Offset: 0x0006C11F
		public string Namespace
		{
			get
			{
				return this._namespace;
			}
			set
			{
				this._namespace = value;
			}
		}

		// Token: 0x1700037F RID: 895
		// (set) Token: 0x06001194 RID: 4500 RVA: 0x0006DF28 File Offset: 0x0006C128
		public XmlSchemaForm Form
		{
			set
			{
				this._form = value;
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06001195 RID: 4501 RVA: 0x0006DF31 File Offset: 0x0006C131
		// (set) Token: 0x06001196 RID: 4502 RVA: 0x0006DF39 File Offset: 0x0006C139
		public XmlTypeMapping MappedType
		{
			get
			{
				return this._mappedType;
			}
			set
			{
				this._mappedType = value;
			}
		}

		// Token: 0x04000C02 RID: 3074
		private string _attributeName;

		// Token: 0x04000C03 RID: 3075
		private string _namespace = "";

		// Token: 0x04000C04 RID: 3076
		private XmlSchemaForm _form;

		// Token: 0x04000C05 RID: 3077
		private XmlTypeMapping _mappedType;
	}
}
