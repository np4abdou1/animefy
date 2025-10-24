using System;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	/// <summary>Represents the <see langword="import" /> element from XML Schema as specified by the World Wide Web Consortium (W3C). This class is used to import schema components from other schemas.</summary>
	// Token: 0x02000304 RID: 772
	public class XmlSchemaImport : XmlSchemaExternal
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Schema.XmlSchemaImport" /> class.</summary>
		// Token: 0x06001991 RID: 6545 RVA: 0x00098097 File Offset: 0x00096297
		public XmlSchemaImport()
		{
			base.Compositor = Compositor.Import;
		}

		/// <summary>Gets or sets the target namespace for the imported schema as a Uniform Resource Identifier (URI) reference.</summary>
		/// <returns>The target namespace for the imported schema as a URI reference.Optional.</returns>
		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x06001992 RID: 6546 RVA: 0x000980A6 File Offset: 0x000962A6
		// (set) Token: 0x06001993 RID: 6547 RVA: 0x000980AE File Offset: 0x000962AE
		[XmlAttribute("namespace", DataType = "anyURI")]
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

		/// <summary>Gets or sets the <see langword="annotation" /> property.</summary>
		/// <returns>The annotation.</returns>
		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x06001994 RID: 6548 RVA: 0x000980B7 File Offset: 0x000962B7
		// (set) Token: 0x06001995 RID: 6549 RVA: 0x000980BF File Offset: 0x000962BF
		[XmlElement("annotation", typeof(XmlSchemaAnnotation))]
		public XmlSchemaAnnotation Annotation
		{
			get
			{
				return this.annotation;
			}
			set
			{
				this.annotation = value;
			}
		}

		// Token: 0x06001996 RID: 6550 RVA: 0x000980BF File Offset: 0x000962BF
		internal override void AddAnnotation(XmlSchemaAnnotation annotation)
		{
			this.annotation = annotation;
		}

		// Token: 0x040010D7 RID: 4311
		private string ns;

		// Token: 0x040010D8 RID: 4312
		private XmlSchemaAnnotation annotation;
	}
}
