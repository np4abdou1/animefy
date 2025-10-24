using System;
using System.Reflection;
using System.Security;

namespace System.Xml
{
	/// <summary>Represents an XML qualified name.</summary>
	// Token: 0x020001B9 RID: 441
	[Serializable]
	public class XmlQualifiedName
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.XmlQualifiedName" /> class.</summary>
		// Token: 0x06000F1E RID: 3870 RVA: 0x00061ADA File Offset: 0x0005FCDA
		public XmlQualifiedName() : this(string.Empty, string.Empty)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.XmlQualifiedName" /> class with the specified name.</summary>
		/// <param name="name">The local name to use as the name of the <see cref="T:System.Xml.XmlQualifiedName" /> object. </param>
		// Token: 0x06000F1F RID: 3871 RVA: 0x00061AEC File Offset: 0x0005FCEC
		public XmlQualifiedName(string name) : this(name, string.Empty)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.XmlQualifiedName" /> class with the specified name and namespace.</summary>
		/// <param name="name">The local name to use as the name of the <see cref="T:System.Xml.XmlQualifiedName" /> object. </param>
		/// <param name="ns">The namespace for the <see cref="T:System.Xml.XmlQualifiedName" /> object. </param>
		// Token: 0x06000F20 RID: 3872 RVA: 0x00061AFA File Offset: 0x0005FCFA
		public XmlQualifiedName(string name, string ns)
		{
			this.ns = ((ns == null) ? string.Empty : ns);
			this.name = ((name == null) ? string.Empty : name);
		}

		/// <summary>Gets a string representation of the namespace of the <see cref="T:System.Xml.XmlQualifiedName" />.</summary>
		/// <returns>A string representation of the namespace or String.Empty if a namespace is not defined for the object.</returns>
		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06000F21 RID: 3873 RVA: 0x00061B24 File Offset: 0x0005FD24
		public string Namespace
		{
			get
			{
				return this.ns;
			}
		}

		/// <summary>Gets a string representation of the qualified name of the <see cref="T:System.Xml.XmlQualifiedName" />.</summary>
		/// <returns>A string representation of the qualified name or String.Empty if a name is not defined for the object.</returns>
		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06000F22 RID: 3874 RVA: 0x00061B2C File Offset: 0x0005FD2C
		public string Name
		{
			get
			{
				return this.name;
			}
		}

		/// <summary>Returns the hash code for the <see cref="T:System.Xml.XmlQualifiedName" />.</summary>
		/// <returns>A hash code for this object.</returns>
		// Token: 0x06000F23 RID: 3875 RVA: 0x00061B34 File Offset: 0x0005FD34
		public override int GetHashCode()
		{
			if (this.hash == 0)
			{
				if (XmlQualifiedName.hashCodeDelegate == null)
				{
					XmlQualifiedName.hashCodeDelegate = XmlQualifiedName.GetHashCodeDelegate();
				}
				this.hash = XmlQualifiedName.hashCodeDelegate(this.Name, this.Name.Length, 0L);
			}
			return this.hash;
		}

		/// <summary>Gets a value indicating whether the <see cref="T:System.Xml.XmlQualifiedName" /> is empty.</summary>
		/// <returns>
		///     <see langword="true" /> if name and namespace are empty strings; otherwise, <see langword="false" />.</returns>
		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06000F24 RID: 3876 RVA: 0x00061B83 File Offset: 0x0005FD83
		public bool IsEmpty
		{
			get
			{
				return this.Name.Length == 0 && this.Namespace.Length == 0;
			}
		}

		/// <summary>Returns the string value of the <see cref="T:System.Xml.XmlQualifiedName" />.</summary>
		/// <returns>The string value of the <see cref="T:System.Xml.XmlQualifiedName" /> in the format of <see langword="namespace:localname" />. If the object does not have a namespace defined, this method returns just the local name.</returns>
		// Token: 0x06000F25 RID: 3877 RVA: 0x00061BA2 File Offset: 0x0005FDA2
		public override string ToString()
		{
			if (this.Namespace.Length != 0)
			{
				return this.Namespace + ":" + this.Name;
			}
			return this.Name;
		}

		/// <summary>Determines whether the specified <see cref="T:System.Xml.XmlQualifiedName" /> object is equal to the current <see cref="T:System.Xml.XmlQualifiedName" /> object. </summary>
		/// <param name="other">The <see cref="T:System.Xml.XmlQualifiedName" /> to compare. </param>
		/// <returns>
		///     <see langword="true" /> if the two are the same instance object; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000F26 RID: 3878 RVA: 0x00061BD0 File Offset: 0x0005FDD0
		public override bool Equals(object other)
		{
			if (this == other)
			{
				return true;
			}
			XmlQualifiedName xmlQualifiedName = other as XmlQualifiedName;
			return xmlQualifiedName != null && this.Name == xmlQualifiedName.Name && this.Namespace == xmlQualifiedName.Namespace;
		}

		/// <summary>Compares two <see cref="T:System.Xml.XmlQualifiedName" /> objects.</summary>
		/// <param name="a">An <see cref="T:System.Xml.XmlQualifiedName" /> to compare. </param>
		/// <param name="b">An <see cref="T:System.Xml.XmlQualifiedName" /> to compare. </param>
		/// <returns>
		///     <see langword="true" /> if the two objects have the same name and namespace values; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000F27 RID: 3879 RVA: 0x00061C1B File Offset: 0x0005FE1B
		public static bool operator ==(XmlQualifiedName a, XmlQualifiedName b)
		{
			return a == b || (a != null && b != null && a.Name == b.Name && a.Namespace == b.Namespace);
		}

		/// <summary>Compares two <see cref="T:System.Xml.XmlQualifiedName" /> objects.</summary>
		/// <param name="a">An <see cref="T:System.Xml.XmlQualifiedName" /> to compare. </param>
		/// <param name="b">An <see cref="T:System.Xml.XmlQualifiedName" /> to compare. </param>
		/// <returns>
		///     <see langword="true" /> if the name and namespace values for the two objects differ; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000F28 RID: 3880 RVA: 0x00061C51 File Offset: 0x0005FE51
		public static bool operator !=(XmlQualifiedName a, XmlQualifiedName b)
		{
			return !(a == b);
		}

		/// <summary>Returns the string value of the <see cref="T:System.Xml.XmlQualifiedName" />.</summary>
		/// <param name="name">The name of the object. </param>
		/// <param name="ns">The namespace of the object. </param>
		/// <returns>The string value of the <see cref="T:System.Xml.XmlQualifiedName" /> in the format of <see langword="namespace:localname" />. If the object does not have a namespace defined, this method returns just the local name.</returns>
		// Token: 0x06000F29 RID: 3881 RVA: 0x00061C5D File Offset: 0x0005FE5D
		public static string ToString(string name, string ns)
		{
			if (ns != null && ns.Length != 0)
			{
				return ns + ":" + name;
			}
			return name;
		}

		// Token: 0x06000F2A RID: 3882 RVA: 0x00061C78 File Offset: 0x0005FE78
		[SecuritySafeCritical]
		private static XmlQualifiedName.HashCodeOfStringDelegate GetHashCodeDelegate()
		{
			if (!XmlQualifiedName.IsRandomizedHashingDisabled())
			{
				MethodInfo method = typeof(string).GetMethod("InternalMarvin32HashString", BindingFlags.Static | BindingFlags.NonPublic);
				if (method != null)
				{
					return (XmlQualifiedName.HashCodeOfStringDelegate)Delegate.CreateDelegate(typeof(XmlQualifiedName.HashCodeOfStringDelegate), method);
				}
			}
			return new XmlQualifiedName.HashCodeOfStringDelegate(XmlQualifiedName.GetHashCodeOfString);
		}

		// Token: 0x06000F2B RID: 3883 RVA: 0x0000A216 File Offset: 0x00008416
		private static bool IsRandomizedHashingDisabled()
		{
			return false;
		}

		// Token: 0x06000F2C RID: 3884 RVA: 0x00061CCE File Offset: 0x0005FECE
		private static int GetHashCodeOfString(string s, int length, long additionalEntropy)
		{
			return s.GetHashCode();
		}

		// Token: 0x06000F2D RID: 3885 RVA: 0x00061CD6 File Offset: 0x0005FED6
		internal void Init(string name, string ns)
		{
			this.name = name;
			this.ns = ns;
			this.hash = 0;
		}

		// Token: 0x06000F2E RID: 3886 RVA: 0x00061CED File Offset: 0x0005FEED
		internal void SetNamespace(string ns)
		{
			this.ns = ns;
		}

		// Token: 0x06000F2F RID: 3887 RVA: 0x00061CF6 File Offset: 0x0005FEF6
		internal void Verify()
		{
			XmlConvert.VerifyNCName(this.name);
			if (this.ns.Length != 0)
			{
				XmlConvert.ToUri(this.ns);
			}
		}

		// Token: 0x06000F30 RID: 3888 RVA: 0x00061D1D File Offset: 0x0005FF1D
		internal void Atomize(XmlNameTable nameTable)
		{
			this.name = nameTable.Add(this.name);
			this.ns = nameTable.Add(this.ns);
		}

		// Token: 0x06000F31 RID: 3889 RVA: 0x00061D44 File Offset: 0x0005FF44
		internal static XmlQualifiedName Parse(string s, IXmlNamespaceResolver nsmgr, out string prefix)
		{
			string text;
			ValidateNames.ParseQNameThrow(s, out prefix, out text);
			string text2 = nsmgr.LookupNamespace(prefix);
			if (text2 == null)
			{
				if (prefix.Length != 0)
				{
					throw new XmlException("'{0}' is an undeclared prefix.", prefix);
				}
				text2 = string.Empty;
			}
			return new XmlQualifiedName(text, text2);
		}

		// Token: 0x06000F32 RID: 3890 RVA: 0x00061D89 File Offset: 0x0005FF89
		internal XmlQualifiedName Clone()
		{
			return (XmlQualifiedName)base.MemberwiseClone();
		}

		// Token: 0x04000AE6 RID: 2790
		private static XmlQualifiedName.HashCodeOfStringDelegate hashCodeDelegate = null;

		// Token: 0x04000AE7 RID: 2791
		private string name;

		// Token: 0x04000AE8 RID: 2792
		private string ns;

		// Token: 0x04000AE9 RID: 2793
		[NonSerialized]
		private int hash;

		/// <summary>Provides an empty <see cref="T:System.Xml.XmlQualifiedName" />.</summary>
		// Token: 0x04000AEA RID: 2794
		public static readonly XmlQualifiedName Empty = new XmlQualifiedName(string.Empty);

		// Token: 0x020001BA RID: 442
		// (Invoke) Token: 0x06000F35 RID: 3893
		private delegate int HashCodeOfStringDelegate(string s, int sLen, long additionalEntropy);
	}
}
