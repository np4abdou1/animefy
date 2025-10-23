using System;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	/// <summary>Represents the <see langword="sequence" /> element (compositor) from the XML Schema as specified by the World Wide Web Consortium (W3C). The <see langword="sequence" /> requires the elements in the group to appear in the specified sequence within the containing element.</summary>
	// Token: 0x02000315 RID: 789
	public class XmlSchemaSequence : XmlSchemaGroupBase
	{
		/// <summary>The elements contained within the compositor. Collection of <see cref="T:System.Xml.Schema.XmlSchemaElement" />, <see cref="T:System.Xml.Schema.XmlSchemaGroupRef" />, <see cref="T:System.Xml.Schema.XmlSchemaChoice" />, <see cref="T:System.Xml.Schema.XmlSchemaSequence" />, or <see cref="T:System.Xml.Schema.XmlSchemaAny" />.</summary>
		/// <returns>The elements contained within the compositor.</returns>
		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x06001A15 RID: 6677 RVA: 0x00098CD9 File Offset: 0x00096ED9
		[XmlElement("element", typeof(XmlSchemaElement))]
		[XmlElement("group", typeof(XmlSchemaGroupRef))]
		[XmlElement("choice", typeof(XmlSchemaChoice))]
		[XmlElement("sequence", typeof(XmlSchemaSequence))]
		[XmlElement("any", typeof(XmlSchemaAny))]
		public override XmlSchemaObjectCollection Items
		{
			get
			{
				return this.items;
			}
		}

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x06001A16 RID: 6678 RVA: 0x00098CE1 File Offset: 0x00096EE1
		internal override bool IsEmpty
		{
			get
			{
				return base.IsEmpty || this.items.Count == 0;
			}
		}

		// Token: 0x06001A17 RID: 6679 RVA: 0x00098CFB File Offset: 0x00096EFB
		internal override void SetItems(XmlSchemaObjectCollection newItems)
		{
			this.items = newItems;
		}

		// Token: 0x0400110A RID: 4362
		private XmlSchemaObjectCollection items = new XmlSchemaObjectCollection();
	}
}
