using System;
using System.Text;

namespace System.Xml.Linq
{
	/// <summary>Represents an XML declaration.</summary>
	// Token: 0x02000011 RID: 17
	public class XDeclaration
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Linq.XDeclaration" /> class with the specified version, encoding, and standalone status.</summary>
		/// <param name="version">The version of the XML, usually "1.0".</param>
		/// <param name="encoding">The encoding for the XML document.</param>
		/// <param name="standalone">A string containing "yes" or "no" that specifies whether the XML is standalone or requires external entities to be resolved.</param>
		// Token: 0x0600006A RID: 106 RVA: 0x00004236 File Offset: 0x00002436
		public XDeclaration(string version, string encoding, string standalone)
		{
			this._version = version;
			this._encoding = encoding;
			this._standalone = standalone;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Linq.XDeclaration" /> class from another <see cref="T:System.Xml.Linq.XDeclaration" /> object. </summary>
		/// <param name="other">The <see cref="T:System.Xml.Linq.XDeclaration" /> used to initialize this <see cref="T:System.Xml.Linq.XDeclaration" /> object.</param>
		// Token: 0x0600006B RID: 107 RVA: 0x00004253 File Offset: 0x00002453
		public XDeclaration(XDeclaration other)
		{
			if (other == null)
			{
				throw new ArgumentNullException("other");
			}
			this._version = other._version;
			this._encoding = other._encoding;
			this._standalone = other._standalone;
		}

		/// <summary>Gets or sets the encoding for this document.</summary>
		/// <returns>A <see cref="T:System.String" /> containing the code page name for this document.</returns>
		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600006C RID: 108 RVA: 0x0000428D File Offset: 0x0000248D
		// (set) Token: 0x0600006D RID: 109 RVA: 0x00004295 File Offset: 0x00002495
		public string Encoding
		{
			get
			{
				return this._encoding;
			}
			set
			{
				this._encoding = value;
			}
		}

		/// <summary>Gets or sets the standalone property for this document.</summary>
		/// <returns>A <see cref="T:System.String" /> containing the standalone property for this document.</returns>
		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600006E RID: 110 RVA: 0x0000429E File Offset: 0x0000249E
		// (set) Token: 0x0600006F RID: 111 RVA: 0x000042A6 File Offset: 0x000024A6
		public string Standalone
		{
			get
			{
				return this._standalone;
			}
			set
			{
				this._standalone = value;
			}
		}

		/// <summary>Gets or sets the version property for this document.</summary>
		/// <returns>A <see cref="T:System.String" /> containing the version property for this document.</returns>
		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000070 RID: 112 RVA: 0x000042AF File Offset: 0x000024AF
		public string Version
		{
			get
			{
				return this._version;
			}
		}

		/// <summary>Provides the declaration as a formatted string.</summary>
		/// <returns>A <see cref="T:System.String" /> that contains the formatted XML string.</returns>
		// Token: 0x06000071 RID: 113 RVA: 0x000042B8 File Offset: 0x000024B8
		public override string ToString()
		{
			StringBuilder stringBuilder = StringBuilderCache.Acquire(16);
			stringBuilder.Append("<?xml");
			if (this._version != null)
			{
				stringBuilder.Append(" version=\"");
				stringBuilder.Append(this._version);
				stringBuilder.Append('"');
			}
			if (this._encoding != null)
			{
				stringBuilder.Append(" encoding=\"");
				stringBuilder.Append(this._encoding);
				stringBuilder.Append('"');
			}
			if (this._standalone != null)
			{
				stringBuilder.Append(" standalone=\"");
				stringBuilder.Append(this._standalone);
				stringBuilder.Append('"');
			}
			stringBuilder.Append("?>");
			return StringBuilderCache.GetStringAndRelease(stringBuilder);
		}

		// Token: 0x0400003B RID: 59
		private string _version;

		// Token: 0x0400003C RID: 60
		private string _encoding;

		// Token: 0x0400003D RID: 61
		private string _standalone;
	}
}
