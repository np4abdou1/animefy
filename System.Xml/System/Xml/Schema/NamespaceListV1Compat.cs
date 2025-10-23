using System;

namespace System.Xml.Schema
{
	// Token: 0x020002A4 RID: 676
	internal class NamespaceListV1Compat : NamespaceList
	{
		// Token: 0x06001560 RID: 5472 RVA: 0x0007E774 File Offset: 0x0007C974
		public NamespaceListV1Compat(string namespaces, string targetNamespace) : base(namespaces, targetNamespace)
		{
		}

		// Token: 0x06001561 RID: 5473 RVA: 0x0007E77E File Offset: 0x0007C97E
		public override bool Allows(string ns)
		{
			if (base.Type == NamespaceList.ListType.Other)
			{
				return ns != base.Excluded;
			}
			return base.Allows(ns);
		}
	}
}
