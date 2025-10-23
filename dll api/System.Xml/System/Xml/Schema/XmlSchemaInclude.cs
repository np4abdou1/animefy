using System;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	/// <summary>Represents the <see langword="include" /> element from XML Schema as specified by the World Wide Web Consortium (W3C). This class is used to include declarations and definitions from an external schema. The included declarations and definitions are then available for processing in the containing schema.</summary>
	// Token: 0x02000305 RID: 773
	public class XmlSchemaInclude : XmlSchemaExternal
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Schema.XmlSchemaInclude" /> class.</summary>
		// Token: 0x06001997 RID: 6551 RVA: 0x000980C8 File Offset: 0x000962C8
		public XmlSchemaInclude()
		{
			base.Compositor = Compositor.Include;
		}

		/// <summary>Gets or sets the <see langword="annotation" /> property.</summary>
		/// <returns>The annotation.</returns>
		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x06001998 RID: 6552 RVA: 0x000980D7 File Offset: 0x000962D7
		// (set) Token: 0x06001999 RID: 6553 RVA: 0x000980DF File Offset: 0x000962DF
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

		// Token: 0x0600199A RID: 6554 RVA: 0x000980DF File Offset: 0x000962DF
		internal override void AddAnnotation(XmlSchemaAnnotation annotation)
		{
			this.annotation = annotation;
		}

		// Token: 0x040010D9 RID: 4313
		private XmlSchemaAnnotation annotation;
	}
}
