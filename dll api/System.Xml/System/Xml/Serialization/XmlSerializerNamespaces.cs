using System;
using System.Collections;

namespace System.Xml.Serialization
{
	/// <summary>Contains the XML namespaces and prefixes that the <see cref="T:System.Xml.Serialization.XmlSerializer" /> uses to generate qualified names in an XML-document instance.</summary>
	// Token: 0x020001C7 RID: 455
	public class XmlSerializerNamespaces
	{
		/// <summary>Adds a prefix and namespace pair to an <see cref="T:System.Xml.Serialization.XmlSerializerNamespaces" /> object.</summary>
		/// <param name="prefix">The prefix associated with an XML namespace. </param>
		/// <param name="ns">An XML namespace. </param>
		// Token: 0x06000F78 RID: 3960 RVA: 0x00062A9D File Offset: 0x00060C9D
		public void Add(string prefix, string ns)
		{
			if (prefix != null && prefix.Length > 0)
			{
				XmlConvert.VerifyNCName(prefix);
			}
			if (ns != null && ns.Length > 0)
			{
				XmlConvert.ToUri(ns);
			}
			this.AddInternal(prefix, ns);
		}

		// Token: 0x06000F79 RID: 3961 RVA: 0x00062ACD File Offset: 0x00060CCD
		internal void AddInternal(string prefix, string ns)
		{
			this.Namespaces[prefix] = ns;
		}

		/// <summary>Gets the array of prefix and namespace pairs in an <see cref="T:System.Xml.Serialization.XmlSerializerNamespaces" /> object.</summary>
		/// <returns>An array of <see cref="T:System.Xml.XmlQualifiedName" /> objects that are used as qualified names in an XML document.</returns>
		// Token: 0x06000F7A RID: 3962 RVA: 0x00062ADC File Offset: 0x00060CDC
		public XmlQualifiedName[] ToArray()
		{
			if (this.NamespaceList == null)
			{
				return new XmlQualifiedName[0];
			}
			return (XmlQualifiedName[])this.NamespaceList.ToArray(typeof(XmlQualifiedName));
		}

		/// <summary>Gets the number of prefix and namespace pairs in the collection.</summary>
		/// <returns>The number of prefix and namespace pairs in the collection.</returns>
		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06000F7B RID: 3963 RVA: 0x00062B07 File Offset: 0x00060D07
		public int Count
		{
			get
			{
				return this.Namespaces.Count;
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06000F7C RID: 3964 RVA: 0x00062B14 File Offset: 0x00060D14
		internal ArrayList NamespaceList
		{
			get
			{
				if (this.namespaces == null || this.namespaces.Count == 0)
				{
					return null;
				}
				ArrayList arrayList = new ArrayList();
				foreach (object obj in this.Namespaces.Keys)
				{
					string text = (string)obj;
					arrayList.Add(new XmlQualifiedName(text, (string)this.Namespaces[text]));
				}
				return arrayList;
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06000F7D RID: 3965 RVA: 0x00062BA8 File Offset: 0x00060DA8
		// (set) Token: 0x06000F7E RID: 3966 RVA: 0x00062BC3 File Offset: 0x00060DC3
		internal Hashtable Namespaces
		{
			get
			{
				if (this.namespaces == null)
				{
					this.namespaces = new Hashtable();
				}
				return this.namespaces;
			}
			set
			{
				this.namespaces = value;
			}
		}

		// Token: 0x04000B0F RID: 2831
		private Hashtable namespaces;
	}
}
