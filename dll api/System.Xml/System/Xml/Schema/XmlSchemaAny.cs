using System;
using System.ComponentModel;
using System.Text;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	/// <summary>Represents the World Wide Web Consortium (W3C) <see langword="any" /> element.</summary>
	// Token: 0x020002D3 RID: 723
	public class XmlSchemaAny : XmlSchemaParticle
	{
		/// <summary>Gets or sets the namespaces containing the elements that can be used.</summary>
		/// <returns>Namespaces for elements that are available for use. The default is <see langword="##any" />.Optional.</returns>
		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x06001818 RID: 6168 RVA: 0x00095EA8 File Offset: 0x000940A8
		// (set) Token: 0x06001819 RID: 6169 RVA: 0x00095EB0 File Offset: 0x000940B0
		[XmlAttribute("namespace")]
		public string Namespace
		{
			get
			{
				return this.ns;
			}
			set
			{
				this.ns = value;
			}
		}

		/// <summary>Gets or sets information about how an application or XML processor should handle the validation of XML documents for the elements specified by the <see langword="any" /> element.</summary>
		/// <returns>One of the <see cref="T:System.Xml.Schema.XmlSchemaContentProcessing" /> values. If no <see langword="processContents" /> attribute is specified, the default is <see langword="Strict" />.</returns>
		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x0600181A RID: 6170 RVA: 0x00095EB9 File Offset: 0x000940B9
		// (set) Token: 0x0600181B RID: 6171 RVA: 0x00095EC1 File Offset: 0x000940C1
		[XmlAttribute("processContents")]
		[DefaultValue(XmlSchemaContentProcessing.None)]
		public XmlSchemaContentProcessing ProcessContents
		{
			get
			{
				return this.processContents;
			}
			set
			{
				this.processContents = value;
			}
		}

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x0600181C RID: 6172 RVA: 0x00095ECA File Offset: 0x000940CA
		[XmlIgnore]
		internal NamespaceList NamespaceList
		{
			get
			{
				return this.namespaceList;
			}
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x0600181D RID: 6173 RVA: 0x00095ED2 File Offset: 0x000940D2
		[XmlIgnore]
		internal string ResolvedNamespace
		{
			get
			{
				if (this.ns == null || this.ns.Length == 0)
				{
					return "##any";
				}
				return this.ns;
			}
		}

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x0600181E RID: 6174 RVA: 0x00095EF5 File Offset: 0x000940F5
		[XmlIgnore]
		internal XmlSchemaContentProcessing ProcessContentsCorrect
		{
			get
			{
				if (this.processContents != XmlSchemaContentProcessing.None)
				{
					return this.processContents;
				}
				return XmlSchemaContentProcessing.Strict;
			}
		}

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x0600181F RID: 6175 RVA: 0x00095F08 File Offset: 0x00094108
		internal override string NameString
		{
			get
			{
				switch (this.namespaceList.Type)
				{
				case NamespaceList.ListType.Any:
					return "##any:*";
				case NamespaceList.ListType.Other:
					return "##other:*";
				case NamespaceList.ListType.Set:
				{
					StringBuilder stringBuilder = new StringBuilder();
					int num = 1;
					foreach (object obj in this.namespaceList.Enumerate)
					{
						string str = (string)obj;
						stringBuilder.Append(str + ":*");
						if (num < this.namespaceList.Enumerate.Count)
						{
							stringBuilder.Append(" ");
						}
						num++;
					}
					return stringBuilder.ToString();
				}
				default:
					return string.Empty;
				}
			}
		}

		// Token: 0x06001820 RID: 6176 RVA: 0x00095FDC File Offset: 0x000941DC
		internal void BuildNamespaceList(string targetNamespace)
		{
			if (this.ns != null)
			{
				this.namespaceList = new NamespaceList(this.ns, targetNamespace);
				return;
			}
			this.namespaceList = new NamespaceList();
		}

		// Token: 0x06001821 RID: 6177 RVA: 0x00096004 File Offset: 0x00094204
		internal void BuildNamespaceListV1Compat(string targetNamespace)
		{
			if (this.ns != null)
			{
				this.namespaceList = new NamespaceListV1Compat(this.ns, targetNamespace);
				return;
			}
			this.namespaceList = new NamespaceList();
		}

		// Token: 0x06001822 RID: 6178 RVA: 0x0009602C File Offset: 0x0009422C
		internal bool Allows(XmlQualifiedName qname)
		{
			return this.namespaceList.Allows(qname.Namespace);
		}

		// Token: 0x04001036 RID: 4150
		private string ns;

		// Token: 0x04001037 RID: 4151
		private XmlSchemaContentProcessing processContents;

		// Token: 0x04001038 RID: 4152
		private NamespaceList namespaceList;
	}
}
