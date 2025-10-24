using System;
using System.Collections;

namespace System.Xml.Serialization
{
	/// <summary>Contains a mapping of one type to another.</summary>
	// Token: 0x02000218 RID: 536
	public class XmlTypeMapping : XmlMapping
	{
		// Token: 0x060011AE RID: 4526 RVA: 0x0006E210 File Offset: 0x0006C410
		internal XmlTypeMapping(string elementName, string ns, TypeData typeData, string xmlType, string xmlTypeNamespace) : base(elementName, ns)
		{
			this.type = typeData;
			this.xmlType = xmlType;
			this.xmlTypeNamespace = xmlTypeNamespace;
		}

		/// <summary>The fully qualified type name that includes the namespace (or namespaces) and type.</summary>
		/// <returns>The fully qualified type name.</returns>
		// Token: 0x17000388 RID: 904
		// (get) Token: 0x060011AF RID: 4527 RVA: 0x0006E243 File Offset: 0x0006C443
		public string TypeFullName
		{
			get
			{
				return this.type.FullTypeName;
			}
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x060011B0 RID: 4528 RVA: 0x0006E250 File Offset: 0x0006C450
		internal TypeData TypeData
		{
			get
			{
				return this.type;
			}
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x060011B1 RID: 4529 RVA: 0x0006E258 File Offset: 0x0006C458
		// (set) Token: 0x060011B2 RID: 4530 RVA: 0x0006E260 File Offset: 0x0006C460
		internal string XmlType
		{
			get
			{
				return this.xmlType;
			}
			set
			{
				this.xmlType = value;
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x060011B3 RID: 4531 RVA: 0x0006E269 File Offset: 0x0006C469
		// (set) Token: 0x060011B4 RID: 4532 RVA: 0x0006E27A File Offset: 0x0006C47A
		internal string XmlTypeNamespace
		{
			get
			{
				return this.xmlTypeNamespace ?? string.Empty;
			}
			set
			{
				this.xmlTypeNamespace = value;
			}
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x060011B5 RID: 4533 RVA: 0x0006E283 File Offset: 0x0006C483
		internal bool HasXmlTypeNamespace
		{
			get
			{
				return this.xmlTypeNamespace != null;
			}
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x060011B6 RID: 4534 RVA: 0x0006E28E File Offset: 0x0006C48E
		internal ArrayList DerivedTypes
		{
			get
			{
				return this._derivedTypes;
			}
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x060011B7 RID: 4535 RVA: 0x0006E296 File Offset: 0x0006C496
		internal bool MultiReferenceType
		{
			get
			{
				return this.multiReferenceType;
			}
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x060011B8 RID: 4536 RVA: 0x0006E29E File Offset: 0x0006C49E
		// (set) Token: 0x060011B9 RID: 4537 RVA: 0x0006E2A6 File Offset: 0x0006C4A6
		internal XmlTypeMapping BaseMap
		{
			get
			{
				return this.baseMap;
			}
			set
			{
				this.baseMap = value;
			}
		}

		// Token: 0x17000390 RID: 912
		// (set) Token: 0x060011BA RID: 4538 RVA: 0x0006E2AF File Offset: 0x0006C4AF
		internal bool IncludeInSchema
		{
			set
			{
				this.includeInSchema = value;
			}
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x060011BB RID: 4539 RVA: 0x0006E2B8 File Offset: 0x0006C4B8
		// (set) Token: 0x060011BC RID: 4540 RVA: 0x0006E2C0 File Offset: 0x0006C4C0
		internal bool IsNullable
		{
			get
			{
				return this.isNullable;
			}
			set
			{
				this.isNullable = value;
			}
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x060011BD RID: 4541 RVA: 0x0006E2C9 File Offset: 0x0006C4C9
		// (set) Token: 0x060011BE RID: 4542 RVA: 0x0006E2D1 File Offset: 0x0006C4D1
		internal bool IsAny
		{
			get
			{
				return this.isAny;
			}
			set
			{
				this.isAny = value;
			}
		}

		// Token: 0x060011BF RID: 4543 RVA: 0x0006E2DC File Offset: 0x0006C4DC
		internal XmlTypeMapping GetRealTypeMap(Type objectType)
		{
			if (this.TypeData.SchemaType == SchemaTypes.Enum)
			{
				return this;
			}
			if (this.TypeData.Type == objectType)
			{
				return this;
			}
			for (int i = 0; i < this._derivedTypes.Count; i++)
			{
				XmlTypeMapping xmlTypeMapping = (XmlTypeMapping)this._derivedTypes[i];
				if (xmlTypeMapping.TypeData.Type == objectType)
				{
					return xmlTypeMapping;
				}
			}
			return null;
		}

		// Token: 0x060011C0 RID: 4544 RVA: 0x0006E34C File Offset: 0x0006C54C
		internal XmlTypeMapping GetRealElementMap(string name, string ens)
		{
			if (this.xmlType == name && this.XmlTypeNamespace == ens)
			{
				return this;
			}
			foreach (object obj in this._derivedTypes)
			{
				XmlTypeMapping xmlTypeMapping = (XmlTypeMapping)obj;
				if (xmlTypeMapping.xmlType == name && xmlTypeMapping.XmlTypeNamespace == ens)
				{
					return xmlTypeMapping;
				}
			}
			return null;
		}

		// Token: 0x060011C1 RID: 4545 RVA: 0x0006E3E0 File Offset: 0x0006C5E0
		internal void UpdateRoot(XmlQualifiedName qname)
		{
			if (qname != null)
			{
				this._elementName = qname.Name;
				this._namespace = qname.Namespace;
			}
		}

		// Token: 0x04000C0C RID: 3084
		private string xmlType;

		// Token: 0x04000C0D RID: 3085
		private string xmlTypeNamespace;

		// Token: 0x04000C0E RID: 3086
		private TypeData type;

		// Token: 0x04000C0F RID: 3087
		private XmlTypeMapping baseMap;

		// Token: 0x04000C10 RID: 3088
		private bool multiReferenceType;

		// Token: 0x04000C11 RID: 3089
		private bool includeInSchema;

		// Token: 0x04000C12 RID: 3090
		private bool isNullable = true;

		// Token: 0x04000C13 RID: 3091
		private bool isAny;

		// Token: 0x04000C14 RID: 3092
		private ArrayList _derivedTypes = new ArrayList();
	}
}
