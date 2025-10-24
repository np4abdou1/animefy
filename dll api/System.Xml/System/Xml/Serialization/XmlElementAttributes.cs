using System;
using System.Collections;
using System.Text;

namespace System.Xml.Serialization
{
	/// <summary>Represents a collection of <see cref="T:System.Xml.Serialization.XmlElementAttribute" /> objects used by the <see cref="T:System.Xml.Serialization.XmlSerializer" /> to override the default way it serializes a class.</summary>
	// Token: 0x020001E7 RID: 487
	public class XmlElementAttributes : CollectionBase
	{
		/// <summary>Gets or sets the element at the specified index.</summary>
		/// <param name="index">The zero-based index of the element to get or set. </param>
		/// <returns>The element at the specified index.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is not a valid index in the <see cref="T:System.Xml.Serialization.XmlElementAttributes" />. </exception>
		/// <exception cref="T:System.NotSupportedException">The property is set and the <see cref="T:System.Xml.Serialization.XmlElementAttributes" /> is read-only. </exception>
		// Token: 0x1700033B RID: 827
		public XmlElementAttribute this[int index]
		{
			get
			{
				return (XmlElementAttribute)base.List[index];
			}
		}

		/// <summary>Adds an <see cref="T:System.Xml.Serialization.XmlElementAttribute" /> to the collection.</summary>
		/// <param name="attribute">The <see cref="T:System.Xml.Serialization.XmlElementAttribute" /> to add. </param>
		/// <returns>The zero-based index of the newly added item.</returns>
		// Token: 0x0600101F RID: 4127 RVA: 0x000647F6 File Offset: 0x000629F6
		public int Add(XmlElementAttribute attribute)
		{
			return base.List.Add(attribute);
		}

		// Token: 0x06001020 RID: 4128 RVA: 0x00065CE0 File Offset: 0x00063EE0
		internal void AddKeyHash(StringBuilder sb)
		{
			if (base.Count == 0)
			{
				return;
			}
			sb.Append("XEAS ");
			for (int i = 0; i < base.Count; i++)
			{
				this[i].AddKeyHash(sb);
			}
			sb.Append('|');
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06001021 RID: 4129 RVA: 0x00065D2C File Offset: 0x00063F2C
		internal int Order
		{
			get
			{
				foreach (object obj in this)
				{
					XmlElementAttribute xmlElementAttribute = (XmlElementAttribute)obj;
					if (xmlElementAttribute.Order >= 0)
					{
						return xmlElementAttribute.Order;
					}
				}
				return -1;
			}
		}
	}
}
