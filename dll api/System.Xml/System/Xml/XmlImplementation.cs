using System;

namespace System.Xml
{
	/// <summary>Defines the context for a set of <see cref="T:System.Xml.XmlDocument" /> objects.</summary>
	// Token: 0x02000144 RID: 324
	public class XmlImplementation
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.XmlImplementation" /> class.</summary>
		// Token: 0x06000B9A RID: 2970 RVA: 0x000496D7 File Offset: 0x000478D7
		public XmlImplementation() : this(new NameTable())
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.XmlImplementation" /> class with the <see cref="T:System.Xml.XmlNameTable" /> specified.</summary>
		/// <param name="nt">An <see cref="T:System.Xml.XmlNameTable" /> object.</param>
		// Token: 0x06000B9B RID: 2971 RVA: 0x000496E4 File Offset: 0x000478E4
		public XmlImplementation(XmlNameTable nt)
		{
			this.nameTable = nt;
		}

		/// <summary>Creates a new <see cref="T:System.Xml.XmlDocument" />.</summary>
		/// <returns>The new <see langword="XmlDocument" /> object.</returns>
		// Token: 0x06000B9C RID: 2972 RVA: 0x000496F3 File Offset: 0x000478F3
		public virtual XmlDocument CreateDocument()
		{
			return new XmlDocument(this);
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000B9D RID: 2973 RVA: 0x000496FB File Offset: 0x000478FB
		internal XmlNameTable NameTable
		{
			get
			{
				return this.nameTable;
			}
		}

		// Token: 0x040008B2 RID: 2226
		private XmlNameTable nameTable;
	}
}
