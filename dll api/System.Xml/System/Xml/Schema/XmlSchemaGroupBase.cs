using System;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	/// <summary>An abstract class for <see cref="T:System.Xml.Schema.XmlSchemaAll" />, <see cref="T:System.Xml.Schema.XmlSchemaChoice" />, or <see cref="T:System.Xml.Schema.XmlSchemaSequence" />.</summary>
	// Token: 0x020002FD RID: 765
	public abstract class XmlSchemaGroupBase : XmlSchemaParticle
	{
		/// <summary>This collection is used to add new elements to the compositor.</summary>
		/// <returns>An <see langword="XmlSchemaObjectCollection" />.</returns>
		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x06001973 RID: 6515
		[XmlIgnore]
		public abstract XmlSchemaObjectCollection Items { get; }

		// Token: 0x06001974 RID: 6516
		internal abstract void SetItems(XmlSchemaObjectCollection newItems);
	}
}
