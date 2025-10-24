using System;
using System.Xml.Schema;

namespace System.Xml
{
	// Token: 0x02000147 RID: 327
	internal class XmlName : IXmlSchemaInfo
	{
		// Token: 0x06000BBC RID: 3004 RVA: 0x0004AF34 File Offset: 0x00049134
		public static XmlName Create(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next, IXmlSchemaInfo schemaInfo)
		{
			if (schemaInfo == null)
			{
				return new XmlName(prefix, localName, ns, hashCode, ownerDoc, next);
			}
			return new XmlNameEx(prefix, localName, ns, hashCode, ownerDoc, next, schemaInfo);
		}

		// Token: 0x06000BBD RID: 3005 RVA: 0x0004AF57 File Offset: 0x00049157
		internal XmlName(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next)
		{
			this.prefix = prefix;
			this.localName = localName;
			this.ns = ns;
			this.name = null;
			this.hashCode = hashCode;
			this.ownerDoc = ownerDoc;
			this.next = next;
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06000BBE RID: 3006 RVA: 0x0004AF93 File Offset: 0x00049193
		public string LocalName
		{
			get
			{
				return this.localName;
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06000BBF RID: 3007 RVA: 0x0004AF9B File Offset: 0x0004919B
		public string NamespaceURI
		{
			get
			{
				return this.ns;
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06000BC0 RID: 3008 RVA: 0x0004AFA3 File Offset: 0x000491A3
		public string Prefix
		{
			get
			{
				return this.prefix;
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000BC1 RID: 3009 RVA: 0x0004AFAB File Offset: 0x000491AB
		public int HashCode
		{
			get
			{
				return this.hashCode;
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000BC2 RID: 3010 RVA: 0x0004AFB3 File Offset: 0x000491B3
		public XmlDocument OwnerDocument
		{
			get
			{
				return this.ownerDoc;
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000BC3 RID: 3011 RVA: 0x0004AFBC File Offset: 0x000491BC
		public string Name
		{
			get
			{
				if (this.name == null)
				{
					if (this.prefix.Length > 0)
					{
						if (this.localName.Length > 0)
						{
							string array = this.prefix + ":" + this.localName;
							XmlNameTable nameTable = this.ownerDoc.NameTable;
							lock (nameTable)
							{
								if (this.name == null)
								{
									this.name = this.ownerDoc.NameTable.Add(array);
								}
								goto IL_99;
							}
						}
						this.name = this.prefix;
					}
					else
					{
						this.name = this.localName;
					}
				}
				IL_99:
				return this.name;
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06000BC4 RID: 3012 RVA: 0x0000A216 File Offset: 0x00008416
		public virtual XmlSchemaValidity Validity
		{
			get
			{
				return XmlSchemaValidity.NotKnown;
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x06000BC5 RID: 3013 RVA: 0x0000A216 File Offset: 0x00008416
		public virtual bool IsDefault
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06000BC6 RID: 3014 RVA: 0x0000A216 File Offset: 0x00008416
		public virtual bool IsNil
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x06000BC7 RID: 3015 RVA: 0x0001520A File Offset: 0x0001340A
		public virtual XmlSchemaSimpleType MemberType
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06000BC8 RID: 3016 RVA: 0x0001520A File Offset: 0x0001340A
		public virtual XmlSchemaType SchemaType
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06000BC9 RID: 3017 RVA: 0x0001520A File Offset: 0x0001340A
		public virtual XmlSchemaElement SchemaElement
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06000BCA RID: 3018 RVA: 0x0001520A File Offset: 0x0001340A
		public virtual XmlSchemaAttribute SchemaAttribute
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06000BCB RID: 3019 RVA: 0x0004B078 File Offset: 0x00049278
		public virtual bool Equals(IXmlSchemaInfo schemaInfo)
		{
			return schemaInfo == null;
		}

		// Token: 0x06000BCC RID: 3020 RVA: 0x0004B080 File Offset: 0x00049280
		public static int GetHashCode(string name)
		{
			int num = 0;
			if (name != null)
			{
				for (int i = name.Length - 1; i >= 0; i--)
				{
					char c = name[i];
					if (c == ':')
					{
						break;
					}
					num += (num << 7 ^ (int)c);
				}
				num -= num >> 17;
				num -= num >> 11;
				num -= num >> 5;
			}
			return num;
		}

		// Token: 0x040008B7 RID: 2231
		private string prefix;

		// Token: 0x040008B8 RID: 2232
		private string localName;

		// Token: 0x040008B9 RID: 2233
		private string ns;

		// Token: 0x040008BA RID: 2234
		private string name;

		// Token: 0x040008BB RID: 2235
		private int hashCode;

		// Token: 0x040008BC RID: 2236
		internal XmlDocument ownerDoc;

		// Token: 0x040008BD RID: 2237
		internal XmlName next;
	}
}
