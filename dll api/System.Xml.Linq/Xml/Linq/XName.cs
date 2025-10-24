using System;
using System.Runtime.Serialization;

namespace System.Xml.Linq
{
	/// <summary>Represents a name of an XML element or attribute. </summary>
	// Token: 0x0200002F RID: 47
	[Serializable]
	public sealed class XName : IEquatable<XName>, ISerializable
	{
		// Token: 0x06000145 RID: 325 RVA: 0x00007FE5 File Offset: 0x000061E5
		internal XName(XNamespace ns, string localName)
		{
			this._ns = ns;
			this._localName = XmlConvert.VerifyNCName(localName);
			this._hashCode = (ns.GetHashCode() ^ localName.GetHashCode());
		}

		/// <summary>Gets the local (unqualified) part of the name.</summary>
		/// <returns>A <see cref="T:System.String" /> that contains the local (unqualified) part of the name.</returns>
		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000146 RID: 326 RVA: 0x00008013 File Offset: 0x00006213
		public string LocalName
		{
			get
			{
				return this._localName;
			}
		}

		/// <summary>Gets the namespace part of the fully qualified name.</summary>
		/// <returns>An <see cref="T:System.Xml.Linq.XNamespace" /> that contains the namespace part of the name.</returns>
		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000147 RID: 327 RVA: 0x0000801B File Offset: 0x0000621B
		public XNamespace Namespace
		{
			get
			{
				return this._ns;
			}
		}

		/// <summary>Returns the URI of the <see cref="T:System.Xml.Linq.XNamespace" /> for this <see cref="T:System.Xml.Linq.XName" />.</summary>
		/// <returns>The URI of the <see cref="T:System.Xml.Linq.XNamespace" /> for this <see cref="T:System.Xml.Linq.XName" />.</returns>
		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000148 RID: 328 RVA: 0x00008023 File Offset: 0x00006223
		public string NamespaceName
		{
			get
			{
				return this._ns.NamespaceName;
			}
		}

		/// <summary>Returns the expanded XML name in the format {namespace}localname.</summary>
		/// <returns>A <see cref="T:System.String" /> that contains the expanded XML name in the format {namespace}localname.</returns>
		// Token: 0x06000149 RID: 329 RVA: 0x00008030 File Offset: 0x00006230
		public override string ToString()
		{
			if (this._ns.NamespaceName.Length == 0)
			{
				return this._localName;
			}
			return "{" + this._ns.NamespaceName + "}" + this._localName;
		}

		/// <summary>Gets an <see cref="T:System.Xml.Linq.XName" /> object from an expanded name.</summary>
		/// <param name="expandedName">A <see cref="T:System.String" /> that contains an expanded XML name in the format {namespace}localname.</param>
		/// <returns>An <see cref="T:System.Xml.Linq.XName" /> object constructed from the expanded name.</returns>
		// Token: 0x0600014A RID: 330 RVA: 0x0000806C File Offset: 0x0000626C
		public static XName Get(string expandedName)
		{
			if (expandedName == null)
			{
				throw new ArgumentNullException("expandedName");
			}
			if (expandedName.Length == 0)
			{
				throw new ArgumentException(SR.Format("'{0}' is an invalid expanded name.", expandedName));
			}
			if (expandedName[0] != '{')
			{
				return XNamespace.None.GetName(expandedName);
			}
			int num = expandedName.LastIndexOf('}');
			if (num <= 1 || num == expandedName.Length - 1)
			{
				throw new ArgumentException(SR.Format("'{0}' is an invalid expanded name.", expandedName));
			}
			return XNamespace.Get(expandedName, 1, num - 1).GetName(expandedName, num + 1, expandedName.Length - num - 1);
		}

		/// <summary>Gets an <see cref="T:System.Xml.Linq.XName" /> object from a local name and a namespace.</summary>
		/// <param name="localName">A local (unqualified) name.</param>
		/// <param name="namespaceName">An XML namespace.</param>
		/// <returns>An <see cref="T:System.Xml.Linq.XName" /> object created from the specified local name and namespace.</returns>
		// Token: 0x0600014B RID: 331 RVA: 0x000080FD File Offset: 0x000062FD
		public static XName Get(string localName, string namespaceName)
		{
			return XNamespace.Get(namespaceName).GetName(localName);
		}

		/// <summary>Converts a string formatted as an expanded XML name (that is,{namespace}localname) to an <see cref="T:System.Xml.Linq.XName" /> object.</summary>
		/// <param name="expandedName">A string that contains an expanded XML name in the format {namespace}localname.</param>
		/// <returns>An <see cref="T:System.Xml.Linq.XName" /> object constructed from the expanded name.</returns>
		// Token: 0x0600014C RID: 332 RVA: 0x0000810B File Offset: 0x0000630B
		[CLSCompliant(false)]
		public static implicit operator XName(string expandedName)
		{
			if (expandedName == null)
			{
				return null;
			}
			return XName.Get(expandedName);
		}

		/// <summary>Determines whether the specified <see cref="T:System.Xml.Linq.XName" /> is equal to this <see cref="T:System.Xml.Linq.XName" />.</summary>
		/// <param name="obj">The <see cref="T:System.Xml.Linq.XName" /> to compare to the current <see cref="T:System.Xml.Linq.XName" />.</param>
		/// <returns>
		///     <see langword="true" /> if the specified <see cref="T:System.Xml.Linq.XName" /> is equal to the current <see cref="T:System.Xml.Linq.XName" />; otherwise <see langword="false" />.</returns>
		// Token: 0x0600014D RID: 333 RVA: 0x00008118 File Offset: 0x00006318
		public override bool Equals(object obj)
		{
			return this == obj;
		}

		/// <summary>Gets a hash code for this <see cref="T:System.Xml.Linq.XName" />.</summary>
		/// <returns>An <see cref="T:System.Int32" /> that contains the hash code for the <see cref="T:System.Xml.Linq.XName" />.</returns>
		// Token: 0x0600014E RID: 334 RVA: 0x0000811E File Offset: 0x0000631E
		public override int GetHashCode()
		{
			return this._hashCode;
		}

		/// <summary>Returns a value indicating whether two instances of <see cref="T:System.Xml.Linq.XName" /> are equal.</summary>
		/// <param name="left">The first <see cref="T:System.Xml.Linq.XName" /> to compare.</param>
		/// <param name="right">The second <see cref="T:System.Xml.Linq.XName" /> to compare.</param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="left" /> and <paramref name="right" /> are equal; otherwise <see langword="false" />.</returns>
		// Token: 0x0600014F RID: 335 RVA: 0x00008118 File Offset: 0x00006318
		public static bool operator ==(XName left, XName right)
		{
			return left == right;
		}

		/// <summary>Returns a value indicating whether two instances of <see cref="T:System.Xml.Linq.XName" /> are not equal.</summary>
		/// <param name="left">The first <see cref="T:System.Xml.Linq.XName" /> to compare.</param>
		/// <param name="right">The second <see cref="T:System.Xml.Linq.XName" /> to compare.</param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="left" /> and <paramref name="right" /> are not equal; otherwise <see langword="false" />.</returns>
		// Token: 0x06000150 RID: 336 RVA: 0x00008126 File Offset: 0x00006326
		public static bool operator !=(XName left, XName right)
		{
			return left != right;
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00008118 File Offset: 0x00006318
		bool IEquatable<XName>.Equals(XName other)
		{
			return this == other;
		}

		/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with the data required to serialize the target object.</summary>
		/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> to populate with data.</param>
		/// <param name="context">The destination (see <see cref="T:System.Runtime.Serialization.StreamingContext" />) for this serialization.</param>
		// Token: 0x06000152 RID: 338 RVA: 0x0000812F File Offset: 0x0000632F
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x040000C5 RID: 197
		private XNamespace _ns;

		// Token: 0x040000C6 RID: 198
		private string _localName;

		// Token: 0x040000C7 RID: 199
		private int _hashCode;
	}
}
