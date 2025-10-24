using System;
using System.Collections;
using System.Text;

namespace System.Xml.Serialization
{
	/// <summary>Represents a collection of <see cref="T:System.Xml.Serialization.XmlAnyElementAttribute" /> objects.</summary>
	// Token: 0x020001DD RID: 477
	public class XmlAnyElementAttributes : CollectionBase
	{
		/// <summary>Gets or sets the <see cref="T:System.Xml.Serialization.XmlAnyElementAttribute" /> at the specified index.</summary>
		/// <param name="index">The index of the <see cref="T:System.Xml.Serialization.XmlAnyElementAttribute" />. </param>
		/// <returns>An <see cref="T:System.Xml.Serialization.XmlAnyElementAttribute" /> at the specified index.</returns>
		// Token: 0x1700030E RID: 782
		public XmlAnyElementAttribute this[int index]
		{
			get
			{
				return (XmlAnyElementAttribute)base.List[index];
			}
		}

		/// <summary>Adds an <see cref="T:System.Xml.Serialization.XmlAnyElementAttribute" /> to the collection.</summary>
		/// <param name="attribute">The <see cref="T:System.Xml.Serialization.XmlAnyElementAttribute" /> to add. </param>
		/// <returns>The index of the newly added <see cref="T:System.Xml.Serialization.XmlAnyElementAttribute" />.</returns>
		// Token: 0x06000FD7 RID: 4055 RVA: 0x000647F6 File Offset: 0x000629F6
		public int Add(XmlAnyElementAttribute attribute)
		{
			return base.List.Add(attribute);
		}

		// Token: 0x06000FD8 RID: 4056 RVA: 0x00064804 File Offset: 0x00062A04
		internal void AddKeyHash(StringBuilder sb)
		{
			if (base.Count == 0)
			{
				return;
			}
			sb.Append("XAEAS ");
			for (int i = 0; i < base.Count; i++)
			{
				this[i].AddKeyHash(sb);
			}
			sb.Append('|');
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000FD9 RID: 4057 RVA: 0x00064850 File Offset: 0x00062A50
		internal int Order
		{
			get
			{
				foreach (object obj in this)
				{
					XmlAnyElementAttribute xmlAnyElementAttribute = (XmlAnyElementAttribute)obj;
					if (xmlAnyElementAttribute.Order >= 0)
					{
						return xmlAnyElementAttribute.Order;
					}
				}
				return -1;
			}
		}
	}
}
