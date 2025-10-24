using System;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	/// <summary>Represents the World Wide Web Consortium (W3C) <see langword="all" /> element (compositor).</summary>
	// Token: 0x020002D0 RID: 720
	public class XmlSchemaAll : XmlSchemaGroupBase
	{
		/// <summary>Gets the collection of <see langword="XmlSchemaElement" /> elements contained within the <see langword="all" /> compositor.</summary>
		/// <returns>The collection of elements contained in <see langword="XmlSchemaAll" />.</returns>
		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x06001800 RID: 6144 RVA: 0x00095DD0 File Offset: 0x00093FD0
		[XmlElement("element", typeof(XmlSchemaElement))]
		public override XmlSchemaObjectCollection Items
		{
			get
			{
				return this.items;
			}
		}

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x06001801 RID: 6145 RVA: 0x00095DD8 File Offset: 0x00093FD8
		internal override bool IsEmpty
		{
			get
			{
				return base.IsEmpty || this.items.Count == 0;
			}
		}

		// Token: 0x06001802 RID: 6146 RVA: 0x00095DF2 File Offset: 0x00093FF2
		internal override void SetItems(XmlSchemaObjectCollection newItems)
		{
			this.items = newItems;
		}

		// Token: 0x0400102F RID: 4143
		private XmlSchemaObjectCollection items = new XmlSchemaObjectCollection();
	}
}
