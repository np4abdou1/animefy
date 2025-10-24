using System;
using System.Collections;
using System.Text;

namespace System.Xml.Serialization
{
	/// <summary>Represents a collection of <see cref="T:System.Xml.Serialization.XmlArrayItemAttribute" /> objects.</summary>
	// Token: 0x020001E0 RID: 480
	public class XmlArrayItemAttributes : CollectionBase
	{
		/// <summary>Gets or sets the item at the specified index.</summary>
		/// <param name="index">The zero-based index of the collection member to get or set. </param>
		/// <returns>The <see cref="T:System.Xml.Serialization.XmlArrayItemAttribute" /> at the specified index.</returns>
		// Token: 0x1700031D RID: 797
		public XmlArrayItemAttribute this[int index]
		{
			get
			{
				return (XmlArrayItemAttribute)base.List[index];
			}
		}

		/// <summary>Adds an <see cref="T:System.Xml.Serialization.XmlArrayItemAttribute" /> to the collection.</summary>
		/// <param name="attribute">The <see cref="T:System.Xml.Serialization.XmlArrayItemAttribute" /> to add to the collection. </param>
		/// <returns>The index of the added item.</returns>
		// Token: 0x06000FEB RID: 4075 RVA: 0x000647F6 File Offset: 0x000629F6
		public int Add(XmlArrayItemAttribute attribute)
		{
			return base.List.Add(attribute);
		}

		// Token: 0x06000FEC RID: 4076 RVA: 0x00064A6C File Offset: 0x00062C6C
		internal void AddKeyHash(StringBuilder sb)
		{
			if (base.Count == 0)
			{
				return;
			}
			sb.Append("XAIAS ");
			for (int i = 0; i < base.Count; i++)
			{
				this[i].AddKeyHash(sb);
			}
			sb.Append('|');
		}
	}
}
