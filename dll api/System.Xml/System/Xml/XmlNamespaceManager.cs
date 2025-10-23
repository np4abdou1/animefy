using System;
using System.Collections;
using System.Collections.Generic;

namespace System.Xml
{
	/// <summary>Resolves, adds, and removes namespaces to a collection and provides scope management for these namespaces. </summary>
	// Token: 0x020001B6 RID: 438
	public class XmlNamespaceManager : IXmlNamespaceResolver, IEnumerable
	{
		// Token: 0x06000F10 RID: 3856 RVA: 0x0000A20E File Offset: 0x0000840E
		internal XmlNamespaceManager()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.XmlNamespaceManager" /> class with the specified <see cref="T:System.Xml.XmlNameTable" />.</summary>
		/// <param name="nameTable">The <see cref="T:System.Xml.XmlNameTable" /> to use. </param>
		/// <exception cref="T:System.NullReferenceException">
		///         <see langword="null" /> is passed to the constructor </exception>
		// Token: 0x06000F11 RID: 3857 RVA: 0x00061470 File Offset: 0x0005F670
		public XmlNamespaceManager(XmlNameTable nameTable)
		{
			this.nameTable = nameTable;
			this.xml = nameTable.Add("xml");
			this.xmlNs = nameTable.Add("xmlns");
			this.nsdecls = new XmlNamespaceManager.NamespaceDeclaration[8];
			string text = nameTable.Add(string.Empty);
			this.nsdecls[0].Set(text, text, -1, -1);
			this.nsdecls[1].Set(this.xmlNs, nameTable.Add("http://www.w3.org/2000/xmlns/"), -1, -1);
			this.nsdecls[2].Set(this.xml, nameTable.Add("http://www.w3.org/XML/1998/namespace"), 0, -1);
			this.lastDecl = 2;
			this.scopeId = 1;
		}

		/// <summary>Gets the <see cref="T:System.Xml.XmlNameTable" /> associated with this object.</summary>
		/// <returns>The <see cref="T:System.Xml.XmlNameTable" /> used by this object.</returns>
		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06000F12 RID: 3858 RVA: 0x0006152F File Offset: 0x0005F72F
		public virtual XmlNameTable NameTable
		{
			get
			{
				return this.nameTable;
			}
		}

		/// <summary>Gets the namespace URI for the default namespace.</summary>
		/// <returns>Returns the namespace URI for the default namespace, or String.Empty if there is no default namespace.</returns>
		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06000F13 RID: 3859 RVA: 0x00061538 File Offset: 0x0005F738
		public virtual string DefaultNamespace
		{
			get
			{
				string text = this.LookupNamespace(string.Empty);
				if (text != null)
				{
					return text;
				}
				return string.Empty;
			}
		}

		/// <summary>Pushes a namespace scope onto the stack.</summary>
		// Token: 0x06000F14 RID: 3860 RVA: 0x0006155B File Offset: 0x0005F75B
		public virtual void PushScope()
		{
			this.scopeId++;
		}

		/// <summary>Pops a namespace scope off the stack.</summary>
		/// <returns>
		///     <see langword="true" /> if there are namespace scopes left on the stack; <see langword="false" /> if there are no more namespaces to pop.</returns>
		// Token: 0x06000F15 RID: 3861 RVA: 0x0006156C File Offset: 0x0005F76C
		public virtual bool PopScope()
		{
			int num = this.lastDecl;
			if (this.scopeId == 1)
			{
				return false;
			}
			while (this.nsdecls[num].scopeId == this.scopeId)
			{
				if (this.useHashtable)
				{
					this.hashTable[this.nsdecls[num].prefix] = this.nsdecls[num].previousNsIndex;
				}
				num--;
			}
			this.lastDecl = num;
			this.scopeId--;
			return true;
		}

		/// <summary>Adds the given namespace to the collection.</summary>
		/// <param name="prefix">The prefix to associate with the namespace being added. Use String.Empty to add a default namespace.
		///       NoteIf the <see cref="T:System.Xml.XmlNamespaceManager" /> will be used for resolving namespaces in an XML Path Language (XPath) expression, a prefix must be specified. If an XPath expression does not include a prefix, it is assumed that the namespace Uniform Resource Identifier (URI) is the empty namespace. For more information about XPath expressions and the <see cref="T:System.Xml.XmlNamespaceManager" />, refer to the <see cref="M:System.Xml.XmlNode.SelectNodes(System.String)" /> and <see cref="M:System.Xml.XPath.XPathExpression.SetContext(System.Xml.XmlNamespaceManager)" /> methods.</param>
		/// <param name="uri">The namespace to add. </param>
		/// <exception cref="T:System.ArgumentException">The value for <paramref name="prefix" /> is "xml" or "xmlns". </exception>
		/// <exception cref="T:System.ArgumentNullException">The value for <paramref name="prefix" /> or <paramref name="uri" /> is <see langword="null" />. </exception>
		// Token: 0x06000F16 RID: 3862 RVA: 0x000615F4 File Offset: 0x0005F7F4
		public virtual void AddNamespace(string prefix, string uri)
		{
			if (uri == null)
			{
				throw new ArgumentNullException("uri");
			}
			if (prefix == null)
			{
				throw new ArgumentNullException("prefix");
			}
			prefix = this.nameTable.Add(prefix);
			uri = this.nameTable.Add(uri);
			if (Ref.Equal(this.xml, prefix) && !uri.Equals("http://www.w3.org/XML/1998/namespace"))
			{
				throw new ArgumentException(Res.GetString("Prefix \"xml\" is reserved for use by XML and can be mapped only to namespace name \"http://www.w3.org/XML/1998/namespace\"."));
			}
			if (Ref.Equal(this.xmlNs, prefix))
			{
				throw new ArgumentException(Res.GetString("Prefix \"xmlns\" is reserved for use by XML."));
			}
			int num = this.LookupNamespaceDecl(prefix);
			int previousNsIndex = -1;
			if (num != -1)
			{
				if (this.nsdecls[num].scopeId == this.scopeId)
				{
					this.nsdecls[num].uri = uri;
					return;
				}
				previousNsIndex = num;
			}
			if (this.lastDecl == this.nsdecls.Length - 1)
			{
				XmlNamespaceManager.NamespaceDeclaration[] destinationArray = new XmlNamespaceManager.NamespaceDeclaration[this.nsdecls.Length * 2];
				Array.Copy(this.nsdecls, 0, destinationArray, 0, this.nsdecls.Length);
				this.nsdecls = destinationArray;
			}
			XmlNamespaceManager.NamespaceDeclaration[] array = this.nsdecls;
			int num2 = this.lastDecl + 1;
			this.lastDecl = num2;
			array[num2].Set(prefix, uri, this.scopeId, previousNsIndex);
			if (this.useHashtable)
			{
				this.hashTable[prefix] = this.lastDecl;
				return;
			}
			if (this.lastDecl >= 16)
			{
				this.hashTable = new Dictionary<string, int>(this.lastDecl);
				for (int i = 0; i <= this.lastDecl; i++)
				{
					this.hashTable[this.nsdecls[i].prefix] = i;
				}
				this.useHashtable = true;
			}
		}

		/// <summary>Removes the given namespace for the given prefix.</summary>
		/// <param name="prefix">The prefix for the namespace </param>
		/// <param name="uri">The namespace to remove for the given prefix. The namespace removed is from the current namespace scope. Namespaces outside the current scope are ignored. </param>
		/// <exception cref="T:System.ArgumentNullException">The value of <paramref name="prefix" /> or <paramref name="uri" /> is <see langword="null" />. </exception>
		// Token: 0x06000F17 RID: 3863 RVA: 0x00061798 File Offset: 0x0005F998
		public virtual void RemoveNamespace(string prefix, string uri)
		{
			if (uri == null)
			{
				throw new ArgumentNullException("uri");
			}
			if (prefix == null)
			{
				throw new ArgumentNullException("prefix");
			}
			for (int num = this.LookupNamespaceDecl(prefix); num != -1; num = this.nsdecls[num].previousNsIndex)
			{
				if (string.Equals(this.nsdecls[num].uri, uri) && this.nsdecls[num].scopeId == this.scopeId)
				{
					this.nsdecls[num].uri = null;
				}
			}
		}

		/// <summary>Returns an enumerator to use to iterate through the namespaces in the <see cref="T:System.Xml.XmlNamespaceManager" />.</summary>
		/// <returns>An <see cref="T:System.Collections.IEnumerator" /> containing the prefixes stored by the <see cref="T:System.Xml.XmlNamespaceManager" />.</returns>
		// Token: 0x06000F18 RID: 3864 RVA: 0x00061828 File Offset: 0x0005FA28
		public virtual IEnumerator GetEnumerator()
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>(this.lastDecl + 1);
			for (int i = 0; i <= this.lastDecl; i++)
			{
				if (this.nsdecls[i].uri != null)
				{
					dictionary[this.nsdecls[i].prefix] = this.nsdecls[i].prefix;
				}
			}
			return dictionary.Keys.GetEnumerator();
		}

		/// <summary>Gets a collection of namespace names keyed by prefix which can be used to enumerate the namespaces currently in scope.</summary>
		/// <param name="scope">An enumeration value that specifies the type of namespace nodes to return.</param>
		/// <returns>A collection of namespace and prefix pairs currently in scope.</returns>
		// Token: 0x06000F19 RID: 3865 RVA: 0x000618A0 File Offset: 0x0005FAA0
		public virtual IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope)
		{
			int i = 0;
			switch (scope)
			{
			case XmlNamespaceScope.All:
				i = 2;
				break;
			case XmlNamespaceScope.ExcludeXml:
				i = 3;
				break;
			case XmlNamespaceScope.Local:
				i = this.lastDecl;
				while (this.nsdecls[i].scopeId == this.scopeId)
				{
					i--;
				}
				i++;
				break;
			}
			Dictionary<string, string> dictionary = new Dictionary<string, string>(this.lastDecl - i + 1);
			while (i <= this.lastDecl)
			{
				string prefix = this.nsdecls[i].prefix;
				string uri = this.nsdecls[i].uri;
				if (uri != null)
				{
					if (uri.Length > 0 || prefix.Length > 0 || scope == XmlNamespaceScope.Local)
					{
						dictionary[prefix] = uri;
					}
					else
					{
						dictionary.Remove(prefix);
					}
				}
				i++;
			}
			return dictionary;
		}

		/// <summary>Gets the namespace URI for the specified prefix.</summary>
		/// <param name="prefix">The prefix whose namespace URI you want to resolve. To match the default namespace, pass String.Empty. </param>
		/// <returns>Returns the namespace URI for <paramref name="prefix" /> or <see langword="null" /> if there is no mapped namespace. The returned string is atomized.For more information on atomized strings, see the <see cref="T:System.Xml.XmlNameTable" /> class.</returns>
		// Token: 0x06000F1A RID: 3866 RVA: 0x00061964 File Offset: 0x0005FB64
		public virtual string LookupNamespace(string prefix)
		{
			int num = this.LookupNamespaceDecl(prefix);
			if (num != -1)
			{
				return this.nsdecls[num].uri;
			}
			return null;
		}

		// Token: 0x06000F1B RID: 3867 RVA: 0x00061990 File Offset: 0x0005FB90
		private int LookupNamespaceDecl(string prefix)
		{
			if (!this.useHashtable)
			{
				for (int i = this.lastDecl; i >= 0; i--)
				{
					if (this.nsdecls[i].prefix == prefix && this.nsdecls[i].uri != null)
					{
						return i;
					}
				}
				for (int j = this.lastDecl; j >= 0; j--)
				{
					if (string.Equals(this.nsdecls[j].prefix, prefix) && this.nsdecls[j].uri != null)
					{
						return j;
					}
				}
				return -1;
			}
			int previousNsIndex;
			if (this.hashTable.TryGetValue(prefix, out previousNsIndex))
			{
				while (previousNsIndex != -1 && this.nsdecls[previousNsIndex].uri == null)
				{
					previousNsIndex = this.nsdecls[previousNsIndex].previousNsIndex;
				}
				return previousNsIndex;
			}
			return -1;
		}

		/// <summary>Finds the prefix declared for the given namespace URI.</summary>
		/// <param name="uri">The namespace to resolve for the prefix. </param>
		/// <returns>The matching prefix. If there is no mapped prefix, the method returns String.Empty. If a null value is supplied, then <see langword="null" /> is returned.</returns>
		// Token: 0x06000F1C RID: 3868 RVA: 0x00061A60 File Offset: 0x0005FC60
		public virtual string LookupPrefix(string uri)
		{
			for (int i = this.lastDecl; i >= 0; i--)
			{
				if (string.Equals(this.nsdecls[i].uri, uri))
				{
					string prefix = this.nsdecls[i].prefix;
					if (string.Equals(this.LookupNamespace(prefix), uri))
					{
						return prefix;
					}
				}
			}
			return null;
		}

		// Token: 0x04000AC7 RID: 2759
		private XmlNamespaceManager.NamespaceDeclaration[] nsdecls;

		// Token: 0x04000AC8 RID: 2760
		private int lastDecl;

		// Token: 0x04000AC9 RID: 2761
		private XmlNameTable nameTable;

		// Token: 0x04000ACA RID: 2762
		private int scopeId;

		// Token: 0x04000ACB RID: 2763
		private Dictionary<string, int> hashTable;

		// Token: 0x04000ACC RID: 2764
		private bool useHashtable;

		// Token: 0x04000ACD RID: 2765
		private string xml;

		// Token: 0x04000ACE RID: 2766
		private string xmlNs;

		// Token: 0x020001B7 RID: 439
		private struct NamespaceDeclaration
		{
			// Token: 0x06000F1D RID: 3869 RVA: 0x00061ABB File Offset: 0x0005FCBB
			public void Set(string prefix, string uri, int scopeId, int previousNsIndex)
			{
				this.prefix = prefix;
				this.uri = uri;
				this.scopeId = scopeId;
				this.previousNsIndex = previousNsIndex;
			}

			// Token: 0x04000ACF RID: 2767
			public string prefix;

			// Token: 0x04000AD0 RID: 2768
			public string uri;

			// Token: 0x04000AD1 RID: 2769
			public int scopeId;

			// Token: 0x04000AD2 RID: 2770
			public int previousNsIndex;
		}
	}
}
