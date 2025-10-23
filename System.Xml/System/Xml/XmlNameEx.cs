using System;
using System.Xml.Schema;

namespace System.Xml
{
	// Token: 0x02000148 RID: 328
	internal sealed class XmlNameEx : XmlName
	{
		// Token: 0x06000BCD RID: 3021 RVA: 0x0004B0D0 File Offset: 0x000492D0
		internal XmlNameEx(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next, IXmlSchemaInfo schemaInfo) : base(prefix, localName, ns, hashCode, ownerDoc, next)
		{
			this.SetValidity(schemaInfo.Validity);
			this.SetIsDefault(schemaInfo.IsDefault);
			this.SetIsNil(schemaInfo.IsNil);
			this.memberType = schemaInfo.MemberType;
			this.schemaType = schemaInfo.SchemaType;
			this.decl = ((schemaInfo.SchemaElement != null) ? schemaInfo.SchemaElement : schemaInfo.SchemaAttribute);
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06000BCE RID: 3022 RVA: 0x0004B14C File Offset: 0x0004934C
		public override XmlSchemaValidity Validity
		{
			get
			{
				if (!this.ownerDoc.CanReportValidity)
				{
					return XmlSchemaValidity.NotKnown;
				}
				return (XmlSchemaValidity)(this.flags & 3);
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06000BCF RID: 3023 RVA: 0x0004B165 File Offset: 0x00049365
		public override bool IsDefault
		{
			get
			{
				return (this.flags & 4) > 0;
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06000BD0 RID: 3024 RVA: 0x0004B172 File Offset: 0x00049372
		public override bool IsNil
		{
			get
			{
				return (this.flags & 8) > 0;
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06000BD1 RID: 3025 RVA: 0x0004B17F File Offset: 0x0004937F
		public override XmlSchemaSimpleType MemberType
		{
			get
			{
				return this.memberType;
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06000BD2 RID: 3026 RVA: 0x0004B187 File Offset: 0x00049387
		public override XmlSchemaType SchemaType
		{
			get
			{
				return this.schemaType;
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06000BD3 RID: 3027 RVA: 0x0004B18F File Offset: 0x0004938F
		public override XmlSchemaElement SchemaElement
		{
			get
			{
				return this.decl as XmlSchemaElement;
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06000BD4 RID: 3028 RVA: 0x0004B19C File Offset: 0x0004939C
		public override XmlSchemaAttribute SchemaAttribute
		{
			get
			{
				return this.decl as XmlSchemaAttribute;
			}
		}

		// Token: 0x06000BD5 RID: 3029 RVA: 0x0004B1A9 File Offset: 0x000493A9
		public void SetValidity(XmlSchemaValidity value)
		{
			this.flags = (byte)(((int)this.flags & -4) | (int)((byte)value));
		}

		// Token: 0x06000BD6 RID: 3030 RVA: 0x0004B1BE File Offset: 0x000493BE
		public void SetIsDefault(bool value)
		{
			if (value)
			{
				this.flags |= 4;
				return;
			}
			this.flags = (byte)((int)this.flags & -5);
		}

		// Token: 0x06000BD7 RID: 3031 RVA: 0x0004B1E3 File Offset: 0x000493E3
		public void SetIsNil(bool value)
		{
			if (value)
			{
				this.flags |= 8;
				return;
			}
			this.flags = (byte)((int)this.flags & -9);
		}

		// Token: 0x06000BD8 RID: 3032 RVA: 0x0004B208 File Offset: 0x00049408
		public override bool Equals(IXmlSchemaInfo schemaInfo)
		{
			return schemaInfo != null && schemaInfo.Validity == (XmlSchemaValidity)(this.flags & 3) && schemaInfo.IsDefault == (this.flags & 4) > 0 && schemaInfo.IsNil == (this.flags & 8) > 0 && schemaInfo.MemberType == this.memberType && schemaInfo.SchemaType == this.schemaType && schemaInfo.SchemaElement == this.decl as XmlSchemaElement && schemaInfo.SchemaAttribute == this.decl as XmlSchemaAttribute;
		}

		// Token: 0x040008BE RID: 2238
		private byte flags;

		// Token: 0x040008BF RID: 2239
		private XmlSchemaSimpleType memberType;

		// Token: 0x040008C0 RID: 2240
		private XmlSchemaType schemaType;

		// Token: 0x040008C1 RID: 2241
		private object decl;
	}
}
