using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	/// <summary>Represents the World Wide Web Consortium (W3C) <see langword="anyAttribute" /> element.</summary>
	// Token: 0x020002D4 RID: 724
	public class XmlSchemaAnyAttribute : XmlSchemaAnnotated
	{
		/// <summary>Gets or sets the namespaces containing the attributes that can be used.</summary>
		/// <returns>Namespaces for attributes that are available for use. The default is <see langword="##any" />.Optional.</returns>
		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06001824 RID: 6180 RVA: 0x00096047 File Offset: 0x00094247
		// (set) Token: 0x06001825 RID: 6181 RVA: 0x0009604F File Offset: 0x0009424F
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

		/// <summary>Gets or sets information about how an application or XML processor should handle the validation of XML documents for the attributes specified by the <see langword="anyAttribute" /> element.</summary>
		/// <returns>One of the <see cref="T:System.Xml.Schema.XmlSchemaContentProcessing" /> values. If no <see langword="processContents" /> attribute is specified, the default is <see langword="Strict" />.</returns>
		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x06001826 RID: 6182 RVA: 0x00096058 File Offset: 0x00094258
		// (set) Token: 0x06001827 RID: 6183 RVA: 0x00096060 File Offset: 0x00094260
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

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x06001828 RID: 6184 RVA: 0x00096069 File Offset: 0x00094269
		[XmlIgnore]
		internal NamespaceList NamespaceList
		{
			get
			{
				return this.namespaceList;
			}
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x06001829 RID: 6185 RVA: 0x00096071 File Offset: 0x00094271
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

		// Token: 0x0600182A RID: 6186 RVA: 0x00096083 File Offset: 0x00094283
		internal void BuildNamespaceList(string targetNamespace)
		{
			if (this.ns != null)
			{
				this.namespaceList = new NamespaceList(this.ns, targetNamespace);
				return;
			}
			this.namespaceList = new NamespaceList();
		}

		// Token: 0x0600182B RID: 6187 RVA: 0x000960AB File Offset: 0x000942AB
		internal void BuildNamespaceListV1Compat(string targetNamespace)
		{
			if (this.ns != null)
			{
				this.namespaceList = new NamespaceListV1Compat(this.ns, targetNamespace);
				return;
			}
			this.namespaceList = new NamespaceList();
		}

		// Token: 0x0600182C RID: 6188 RVA: 0x000960D3 File Offset: 0x000942D3
		internal bool Allows(XmlQualifiedName qname)
		{
			return this.namespaceList.Allows(qname.Namespace);
		}

		// Token: 0x0600182D RID: 6189 RVA: 0x000960E6 File Offset: 0x000942E6
		internal static bool IsSubset(XmlSchemaAnyAttribute sub, XmlSchemaAnyAttribute super)
		{
			return NamespaceList.IsSubset(sub.NamespaceList, super.NamespaceList);
		}

		// Token: 0x0600182E RID: 6190 RVA: 0x000960FC File Offset: 0x000942FC
		internal static XmlSchemaAnyAttribute Intersection(XmlSchemaAnyAttribute o1, XmlSchemaAnyAttribute o2, bool v1Compat)
		{
			NamespaceList namespaceList = NamespaceList.Intersection(o1.NamespaceList, o2.NamespaceList, v1Compat);
			if (namespaceList != null)
			{
				return new XmlSchemaAnyAttribute
				{
					namespaceList = namespaceList,
					ProcessContents = o1.ProcessContents,
					Annotation = o1.Annotation
				};
			}
			return null;
		}

		// Token: 0x0600182F RID: 6191 RVA: 0x00096148 File Offset: 0x00094348
		internal static XmlSchemaAnyAttribute Union(XmlSchemaAnyAttribute o1, XmlSchemaAnyAttribute o2, bool v1Compat)
		{
			NamespaceList namespaceList = NamespaceList.Union(o1.NamespaceList, o2.NamespaceList, v1Compat);
			if (namespaceList != null)
			{
				return new XmlSchemaAnyAttribute
				{
					namespaceList = namespaceList,
					processContents = o1.processContents,
					Annotation = o1.Annotation
				};
			}
			return null;
		}

		// Token: 0x04001039 RID: 4153
		private string ns;

		// Token: 0x0400103A RID: 4154
		private XmlSchemaContentProcessing processContents;

		// Token: 0x0400103B RID: 4155
		private NamespaceList namespaceList;
	}
}
