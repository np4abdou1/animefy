using System;
using System.Threading;

namespace System.Xml.Linq
{
	/// <summary>Represents an XML namespace. This class cannot be inherited. </summary>
	// Token: 0x02000030 RID: 48
	public sealed class XNamespace
	{
		// Token: 0x06000153 RID: 339 RVA: 0x00008136 File Offset: 0x00006336
		internal XNamespace(string namespaceName)
		{
			this._namespaceName = namespaceName;
			this._hashCode = namespaceName.GetHashCode();
			this._names = new XHashtable<XName>(new XHashtable<XName>.ExtractKeyDelegate(XNamespace.ExtractLocalName), 8);
		}

		/// <summary>Gets the Uniform Resource Identifier (URI) of this namespace.</summary>
		/// <returns>A <see cref="T:System.String" /> that contains the URI of the namespace.</returns>
		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000154 RID: 340 RVA: 0x00008169 File Offset: 0x00006369
		public string NamespaceName
		{
			get
			{
				return this._namespaceName;
			}
		}

		/// <summary>Returns an <see cref="T:System.Xml.Linq.XName" /> object created from this <see cref="T:System.Xml.Linq.XNamespace" /> and the specified local name.</summary>
		/// <param name="localName">A <see cref="T:System.String" /> that contains a local name.</param>
		/// <returns>An <see cref="T:System.Xml.Linq.XName" /> created from this <see cref="T:System.Xml.Linq.XNamespace" /> and the specified local name.</returns>
		// Token: 0x06000155 RID: 341 RVA: 0x00008171 File Offset: 0x00006371
		public XName GetName(string localName)
		{
			if (localName == null)
			{
				throw new ArgumentNullException("localName");
			}
			return this.GetName(localName, 0, localName.Length);
		}

		/// <summary>Returns the URI of this <see cref="T:System.Xml.Linq.XNamespace" />.</summary>
		/// <returns>The URI of this <see cref="T:System.Xml.Linq.XNamespace" />.</returns>
		// Token: 0x06000156 RID: 342 RVA: 0x00008169 File Offset: 0x00006369
		public override string ToString()
		{
			return this._namespaceName;
		}

		/// <summary>Gets the <see cref="T:System.Xml.Linq.XNamespace" /> object that corresponds to no namespace.</summary>
		/// <returns>The <see cref="T:System.Xml.Linq.XNamespace" /> that corresponds to no namespace.</returns>
		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000157 RID: 343 RVA: 0x0000818F File Offset: 0x0000638F
		public static XNamespace None
		{
			get
			{
				return XNamespace.EnsureNamespace(ref XNamespace.s_refNone, string.Empty);
			}
		}

		/// <summary>Gets the <see cref="T:System.Xml.Linq.XNamespace" /> object that corresponds to the XML URI (http://www.w3.org/XML/1998/namespace).</summary>
		/// <returns>The <see cref="T:System.Xml.Linq.XNamespace" /> that corresponds to the XML URI (http://www.w3.org/XML/1998/namespace).</returns>
		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000158 RID: 344 RVA: 0x000081A0 File Offset: 0x000063A0
		public static XNamespace Xml
		{
			get
			{
				return XNamespace.EnsureNamespace(ref XNamespace.s_refXml, "http://www.w3.org/XML/1998/namespace");
			}
		}

		/// <summary>Gets the <see cref="T:System.Xml.Linq.XNamespace" /> object that corresponds to the xmlns URI (http://www.w3.org/2000/xmlns/).</summary>
		/// <returns>The <see cref="T:System.Xml.Linq.XNamespace" /> that corresponds to the xmlns URI (http://www.w3.org/2000/xmlns/).</returns>
		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000159 RID: 345 RVA: 0x000081B1 File Offset: 0x000063B1
		public static XNamespace Xmlns
		{
			get
			{
				return XNamespace.EnsureNamespace(ref XNamespace.s_refXmlns, "http://www.w3.org/2000/xmlns/");
			}
		}

		/// <summary>Gets an <see cref="T:System.Xml.Linq.XNamespace" /> for the specified Uniform Resource Identifier (URI).</summary>
		/// <param name="namespaceName">A <see cref="T:System.String" /> that contains a namespace URI.</param>
		/// <returns>An <see cref="T:System.Xml.Linq.XNamespace" /> created from the specified URI.</returns>
		// Token: 0x0600015A RID: 346 RVA: 0x000081C2 File Offset: 0x000063C2
		public static XNamespace Get(string namespaceName)
		{
			if (namespaceName == null)
			{
				throw new ArgumentNullException("namespaceName");
			}
			return XNamespace.Get(namespaceName, 0, namespaceName.Length);
		}

		/// <summary>Converts a string containing a Uniform Resource Identifier (URI) to an <see cref="T:System.Xml.Linq.XNamespace" />.</summary>
		/// <param name="namespaceName">A <see cref="T:System.String" /> that contains the namespace URI.</param>
		/// <returns>An <see cref="T:System.Xml.Linq.XNamespace" /> constructed from the URI string.</returns>
		// Token: 0x0600015B RID: 347 RVA: 0x000081DF File Offset: 0x000063DF
		[CLSCompliant(false)]
		public static implicit operator XNamespace(string namespaceName)
		{
			if (namespaceName == null)
			{
				return null;
			}
			return XNamespace.Get(namespaceName);
		}

		/// <summary>Determines whether the specified <see cref="T:System.Xml.Linq.XNamespace" /> is equal to the current <see cref="T:System.Xml.Linq.XNamespace" />.</summary>
		/// <param name="obj">The <see cref="T:System.Xml.Linq.XNamespace" /> to compare to the current <see cref="T:System.Xml.Linq.XNamespace" />.</param>
		/// <returns>A <see cref="T:System.Boolean" /> that indicates whether the specified <see cref="T:System.Xml.Linq.XNamespace" /> is equal to the current <see cref="T:System.Xml.Linq.XNamespace" />.</returns>
		// Token: 0x0600015C RID: 348 RVA: 0x00008118 File Offset: 0x00006318
		public override bool Equals(object obj)
		{
			return this == obj;
		}

		/// <summary>Gets a hash code for this <see cref="T:System.Xml.Linq.XNamespace" />.</summary>
		/// <returns>An <see cref="T:System.Int32" /> that contains the hash code for the <see cref="T:System.Xml.Linq.XNamespace" />.</returns>
		// Token: 0x0600015D RID: 349 RVA: 0x000081EC File Offset: 0x000063EC
		public override int GetHashCode()
		{
			return this._hashCode;
		}

		/// <summary>Returns a value indicating whether two instances of <see cref="T:System.Xml.Linq.XNamespace" /> are equal.</summary>
		/// <param name="left">The first <see cref="T:System.Xml.Linq.XNamespace" /> to compare.</param>
		/// <param name="right">The second <see cref="T:System.Xml.Linq.XNamespace" /> to compare.</param>
		/// <returns>A <see cref="T:System.Boolean" /> that indicates whether <paramref name="left" /> and <paramref name="right" /> are equal.</returns>
		// Token: 0x0600015E RID: 350 RVA: 0x00008118 File Offset: 0x00006318
		public static bool operator ==(XNamespace left, XNamespace right)
		{
			return left == right;
		}

		/// <summary>Returns a value indicating whether two instances of <see cref="T:System.Xml.Linq.XNamespace" /> are not equal.</summary>
		/// <param name="left">The first <see cref="T:System.Xml.Linq.XNamespace" /> to compare.</param>
		/// <param name="right">The second <see cref="T:System.Xml.Linq.XNamespace" /> to compare.</param>
		/// <returns>A <see cref="T:System.Boolean" /> that indicates whether <paramref name="left" /> and <paramref name="right" /> are not equal.</returns>
		// Token: 0x0600015F RID: 351 RVA: 0x00008126 File Offset: 0x00006326
		public static bool operator !=(XNamespace left, XNamespace right)
		{
			return left != right;
		}

		// Token: 0x06000160 RID: 352 RVA: 0x000081F4 File Offset: 0x000063F4
		internal XName GetName(string localName, int index, int count)
		{
			XName result;
			if (this._names.TryGetValue(localName, index, count, out result))
			{
				return result;
			}
			return this._names.Add(new XName(this, localName.Substring(index, count)));
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00008230 File Offset: 0x00006430
		internal static XNamespace Get(string namespaceName, int index, int count)
		{
			if (count == 0)
			{
				return XNamespace.None;
			}
			if (XNamespace.s_namespaces == null)
			{
				Interlocked.CompareExchange<XHashtable<WeakReference>>(ref XNamespace.s_namespaces, new XHashtable<WeakReference>(new XHashtable<WeakReference>.ExtractKeyDelegate(XNamespace.ExtractNamespace), 32), null);
			}
			for (;;)
			{
				WeakReference weakReference;
				if (!XNamespace.s_namespaces.TryGetValue(namespaceName, index, count, out weakReference))
				{
					if (count == "http://www.w3.org/XML/1998/namespace".Length && string.CompareOrdinal(namespaceName, index, "http://www.w3.org/XML/1998/namespace", 0, count) == 0)
					{
						break;
					}
					if (count == "http://www.w3.org/2000/xmlns/".Length && string.CompareOrdinal(namespaceName, index, "http://www.w3.org/2000/xmlns/", 0, count) == 0)
					{
						goto Block_7;
					}
					weakReference = XNamespace.s_namespaces.Add(new WeakReference(new XNamespace(namespaceName.Substring(index, count))));
				}
				XNamespace xnamespace = (weakReference != null) ? ((XNamespace)weakReference.Target) : null;
				if (!(xnamespace == null))
				{
					return xnamespace;
				}
			}
			return XNamespace.Xml;
			Block_7:
			return XNamespace.Xmlns;
		}

		// Token: 0x06000162 RID: 354 RVA: 0x000082FF File Offset: 0x000064FF
		private static string ExtractLocalName(XName n)
		{
			return n.LocalName;
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00008308 File Offset: 0x00006508
		private static string ExtractNamespace(WeakReference r)
		{
			XNamespace xnamespace;
			if (r == null || (xnamespace = (XNamespace)r.Target) == null)
			{
				return null;
			}
			return xnamespace.NamespaceName;
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00008338 File Offset: 0x00006538
		private static XNamespace EnsureNamespace(ref WeakReference refNmsp, string namespaceName)
		{
			XNamespace xnamespace;
			for (;;)
			{
				WeakReference weakReference = refNmsp;
				if (weakReference != null)
				{
					xnamespace = (XNamespace)weakReference.Target;
					if (xnamespace != null)
					{
						break;
					}
				}
				Interlocked.CompareExchange<WeakReference>(ref refNmsp, new WeakReference(new XNamespace(namespaceName)), weakReference);
			}
			return xnamespace;
		}

		// Token: 0x040000C8 RID: 200
		private static XHashtable<WeakReference> s_namespaces;

		// Token: 0x040000C9 RID: 201
		private static WeakReference s_refNone;

		// Token: 0x040000CA RID: 202
		private static WeakReference s_refXml;

		// Token: 0x040000CB RID: 203
		private static WeakReference s_refXmlns;

		// Token: 0x040000CC RID: 204
		private string _namespaceName;

		// Token: 0x040000CD RID: 205
		private int _hashCode;

		// Token: 0x040000CE RID: 206
		private XHashtable<XName> _names;
	}
}
