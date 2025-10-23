using System;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	/// <summary>Represents the <see langword="choice" /> element (compositor) from the XML Schema as specified by the World Wide Web Consortium (W3C). The <see langword="choice" /> allows only one of its children to appear in an instance. </summary>
	// Token: 0x020002D9 RID: 729
	public class XmlSchemaChoice : XmlSchemaGroupBase
	{
		/// <summary>Gets the collection of the elements contained with the compositor (<see langword="choice" />): <see langword="XmlSchemaElement" />, <see langword="XmlSchemaGroupRef" />, <see langword="XmlSchemaChoice" />, <see langword="XmlSchemaSequence" />, or <see langword="XmlSchemaAny" />.</summary>
		/// <returns>The collection of elements contained within <see langword="XmlSchemaChoice" />.</returns>
		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x06001867 RID: 6247 RVA: 0x00096455 File Offset: 0x00094655
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

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x06001868 RID: 6248 RVA: 0x0009645D File Offset: 0x0009465D
		internal override bool IsEmpty
		{
			get
			{
				return base.IsEmpty;
			}
		}

		// Token: 0x06001869 RID: 6249 RVA: 0x00096465 File Offset: 0x00094665
		internal override void SetItems(XmlSchemaObjectCollection newItems)
		{
			this.items = newItems;
		}

		// Token: 0x04001052 RID: 4178
		private XmlSchemaObjectCollection items = new XmlSchemaObjectCollection();
	}
}
