using System;

namespace System.Xml.Linq
{
	// Token: 0x02000024 RID: 36
	internal struct NamespaceCache
	{
		// Token: 0x0600012A RID: 298 RVA: 0x000070E0 File Offset: 0x000052E0
		public XNamespace Get(string namespaceName)
		{
			if (namespaceName == this._namespaceName)
			{
				return this._ns;
			}
			this._namespaceName = namespaceName;
			this._ns = XNamespace.Get(namespaceName);
			return this._ns;
		}

		// Token: 0x04000094 RID: 148
		private XNamespace _ns;

		// Token: 0x04000095 RID: 149
		private string _namespaceName;
	}
}
