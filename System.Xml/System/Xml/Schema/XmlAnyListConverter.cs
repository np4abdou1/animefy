using System;
using System.Collections;

namespace System.Xml.Schema
{
	// Token: 0x02000336 RID: 822
	internal class XmlAnyListConverter : XmlListConverter
	{
		// Token: 0x06001C43 RID: 7235 RVA: 0x000A3A4F File Offset: 0x000A1C4F
		protected XmlAnyListConverter(XmlBaseConverter atomicConverter) : base(atomicConverter)
		{
		}

		// Token: 0x06001C44 RID: 7236 RVA: 0x000A3A58 File Offset: 0x000A1C58
		public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (destinationType == null)
			{
				throw new ArgumentNullException("destinationType");
			}
			if (!(value is IEnumerable) || value.GetType() == XmlBaseConverter.StringType || value.GetType() == XmlBaseConverter.ByteArrayType)
			{
				value = new object[]
				{
					value
				};
			}
			return this.ChangeListType(value, destinationType, nsResolver);
		}

		// Token: 0x040011EE RID: 4590
		public static readonly XmlValueConverter ItemList = new XmlAnyListConverter((XmlBaseConverter)XmlAnyConverter.Item);

		// Token: 0x040011EF RID: 4591
		public static readonly XmlValueConverter AnyAtomicList = new XmlAnyListConverter((XmlBaseConverter)XmlAnyConverter.AnyAtomic);
	}
}
