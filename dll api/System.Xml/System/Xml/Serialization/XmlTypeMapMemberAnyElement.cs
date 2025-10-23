using System;
using System.Collections;

namespace System.Xml.Serialization
{
	// Token: 0x02000215 RID: 533
	internal class XmlTypeMapMemberAnyElement : XmlTypeMapMemberExpandable
	{
		// Token: 0x060011A9 RID: 4521 RVA: 0x0006E12C File Offset: 0x0006C32C
		public bool IsElementDefined(string name, string ns)
		{
			foreach (object obj in base.ElementInfo)
			{
				XmlTypeMapElementInfo xmlTypeMapElementInfo = (XmlTypeMapElementInfo)obj;
				if (xmlTypeMapElementInfo.IsUnnamedAnyElement)
				{
					return true;
				}
				if (xmlTypeMapElementInfo.ElementName == name && xmlTypeMapElementInfo.Namespace == ns)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x060011AA RID: 4522 RVA: 0x0006E1B0 File Offset: 0x0006C3B0
		public bool IsDefaultAny
		{
			get
			{
				using (IEnumerator enumerator = base.ElementInfo.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (((XmlTypeMapElementInfo)enumerator.Current).IsUnnamedAnyElement)
						{
							return true;
						}
					}
				}
				return false;
			}
		}
	}
}
