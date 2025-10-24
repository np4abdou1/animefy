using System;
using System.Collections;

namespace System.Xml.Schema
{
	// Token: 0x020002B8 RID: 696
	internal class SchemaNamespaceManager : XmlNamespaceManager
	{
		// Token: 0x060016BB RID: 5819 RVA: 0x0008C34F File Offset: 0x0008A54F
		public SchemaNamespaceManager(XmlSchemaObject node)
		{
			this.node = node;
		}

		// Token: 0x060016BC RID: 5820 RVA: 0x0008C360 File Offset: 0x0008A560
		public override string LookupNamespace(string prefix)
		{
			if (prefix == "xml")
			{
				return "http://www.w3.org/XML/1998/namespace";
			}
			for (XmlSchemaObject parent = this.node; parent != null; parent = parent.Parent)
			{
				Hashtable namespaces = parent.Namespaces.Namespaces;
				if (namespaces != null && namespaces.Count > 0)
				{
					object obj = namespaces[prefix];
					if (obj != null)
					{
						return (string)obj;
					}
				}
			}
			if (prefix.Length != 0)
			{
				return null;
			}
			return string.Empty;
		}

		// Token: 0x060016BD RID: 5821 RVA: 0x0008C3CC File Offset: 0x0008A5CC
		public override string LookupPrefix(string ns)
		{
			if (ns == "http://www.w3.org/XML/1998/namespace")
			{
				return "xml";
			}
			for (XmlSchemaObject parent = this.node; parent != null; parent = parent.Parent)
			{
				Hashtable namespaces = parent.Namespaces.Namespaces;
				if (namespaces != null && namespaces.Count > 0)
				{
					foreach (object obj in namespaces)
					{
						DictionaryEntry dictionaryEntry = (DictionaryEntry)obj;
						if (dictionaryEntry.Value.Equals(ns))
						{
							return (string)dictionaryEntry.Key;
						}
					}
				}
			}
			return null;
		}

		// Token: 0x04000F71 RID: 3953
		private XmlSchemaObject node;
	}
}
