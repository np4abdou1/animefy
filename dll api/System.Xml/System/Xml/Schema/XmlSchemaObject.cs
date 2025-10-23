using System;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	/// <summary>Represents the root class for the Xml schema object model hierarchy and serves as a base class for classes such as the <see cref="T:System.Xml.Schema.XmlSchema" /> class.</summary>
	// Token: 0x02000308 RID: 776
	public abstract class XmlSchemaObject
	{
		/// <summary>Gets or sets the line number in the file to which the <see langword="schema" /> element refers.</summary>
		/// <returns>The line number.</returns>
		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x060019BB RID: 6587 RVA: 0x000982BD File Offset: 0x000964BD
		// (set) Token: 0x060019BC RID: 6588 RVA: 0x000982C5 File Offset: 0x000964C5
		[XmlIgnore]
		public int LineNumber
		{
			get
			{
				return this.lineNum;
			}
			set
			{
				this.lineNum = value;
			}
		}

		/// <summary>Gets or sets the line position in the file to which the <see langword="schema" /> element refers.</summary>
		/// <returns>The line position.</returns>
		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x060019BD RID: 6589 RVA: 0x000982CE File Offset: 0x000964CE
		// (set) Token: 0x060019BE RID: 6590 RVA: 0x000982D6 File Offset: 0x000964D6
		[XmlIgnore]
		public int LinePosition
		{
			get
			{
				return this.linePos;
			}
			set
			{
				this.linePos = value;
			}
		}

		/// <summary>Gets or sets the source location for the file that loaded the schema.</summary>
		/// <returns>The source location (URI) for the file.</returns>
		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x060019BF RID: 6591 RVA: 0x000982DF File Offset: 0x000964DF
		// (set) Token: 0x060019C0 RID: 6592 RVA: 0x000982E7 File Offset: 0x000964E7
		[XmlIgnore]
		public string SourceUri
		{
			get
			{
				return this.sourceUri;
			}
			set
			{
				this.sourceUri = value;
			}
		}

		/// <summary>Gets or sets the parent of this <see cref="T:System.Xml.Schema.XmlSchemaObject" />.</summary>
		/// <returns>The parent <see cref="T:System.Xml.Schema.XmlSchemaObject" /> of this <see cref="T:System.Xml.Schema.XmlSchemaObject" />.</returns>
		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x060019C1 RID: 6593 RVA: 0x000982F0 File Offset: 0x000964F0
		// (set) Token: 0x060019C2 RID: 6594 RVA: 0x000982F8 File Offset: 0x000964F8
		[XmlIgnore]
		public XmlSchemaObject Parent
		{
			get
			{
				return this.parent;
			}
			set
			{
				this.parent = value;
			}
		}

		/// <summary>Gets or sets the <see cref="T:System.Xml.Serialization.XmlSerializerNamespaces" /> to use with this schema object.</summary>
		/// <returns>The <see cref="T:System.Xml.Serialization.XmlSerializerNamespaces" /> property for the schema object.</returns>
		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x060019C3 RID: 6595 RVA: 0x00098301 File Offset: 0x00096501
		// (set) Token: 0x060019C4 RID: 6596 RVA: 0x0009831C File Offset: 0x0009651C
		[XmlNamespaceDeclarations]
		public XmlSerializerNamespaces Namespaces
		{
			get
			{
				if (this.namespaces == null)
				{
					this.namespaces = new XmlSerializerNamespaces();
				}
				return this.namespaces;
			}
			set
			{
				this.namespaces = value;
			}
		}

		// Token: 0x060019C5 RID: 6597 RVA: 0x00008574 File Offset: 0x00006774
		internal virtual void OnAdd(XmlSchemaObjectCollection container, object item)
		{
		}

		// Token: 0x060019C6 RID: 6598 RVA: 0x00008574 File Offset: 0x00006774
		internal virtual void OnRemove(XmlSchemaObjectCollection container, object item)
		{
		}

		// Token: 0x060019C7 RID: 6599 RVA: 0x00008574 File Offset: 0x00006774
		internal virtual void OnClear(XmlSchemaObjectCollection container)
		{
		}

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x060019C8 RID: 6600 RVA: 0x0001520A File Offset: 0x0001340A
		// (set) Token: 0x060019C9 RID: 6601 RVA: 0x00008574 File Offset: 0x00006774
		[XmlIgnore]
		internal virtual string IdAttribute
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x060019CA RID: 6602 RVA: 0x00008574 File Offset: 0x00006774
		internal virtual void SetUnhandledAttributes(XmlAttribute[] moreAttributes)
		{
		}

		// Token: 0x060019CB RID: 6603 RVA: 0x00008574 File Offset: 0x00006774
		internal virtual void AddAnnotation(XmlSchemaAnnotation annotation)
		{
		}

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x060019CC RID: 6604 RVA: 0x0001520A File Offset: 0x0001340A
		// (set) Token: 0x060019CD RID: 6605 RVA: 0x00008574 File Offset: 0x00006774
		[XmlIgnore]
		internal virtual string NameAttribute
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x060019CE RID: 6606 RVA: 0x00098325 File Offset: 0x00096525
		// (set) Token: 0x060019CF RID: 6607 RVA: 0x0009832D File Offset: 0x0009652D
		[XmlIgnore]
		internal bool IsProcessing
		{
			get
			{
				return this.isProcessing;
			}
			set
			{
				this.isProcessing = value;
			}
		}

		// Token: 0x060019D0 RID: 6608 RVA: 0x00098336 File Offset: 0x00096536
		internal virtual XmlSchemaObject Clone()
		{
			return (XmlSchemaObject)base.MemberwiseClone();
		}

		// Token: 0x040010E6 RID: 4326
		private int lineNum;

		// Token: 0x040010E7 RID: 4327
		private int linePos;

		// Token: 0x040010E8 RID: 4328
		private string sourceUri;

		// Token: 0x040010E9 RID: 4329
		private XmlSerializerNamespaces namespaces;

		// Token: 0x040010EA RID: 4330
		private XmlSchemaObject parent;

		// Token: 0x040010EB RID: 4331
		private bool isProcessing;
	}
}
