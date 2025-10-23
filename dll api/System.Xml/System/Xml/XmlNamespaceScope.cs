using System;

namespace System.Xml
{
	/// <summary>Defines the namespace scope.</summary>
	// Token: 0x020001B5 RID: 437
	public enum XmlNamespaceScope
	{
		/// <summary>All namespaces defined in the scope of the current node. This includes the xmlns:xml namespace which is always declared implicitly. The order of the namespaces returned is not defined.</summary>
		// Token: 0x04000AC4 RID: 2756
		All,
		/// <summary>All namespaces defined in the scope of the current node, excluding the xmlns:xml namespace, which is always declared implicitly. The order of the namespaces returned is not defined.</summary>
		// Token: 0x04000AC5 RID: 2757
		ExcludeXml,
		/// <summary>All namespaces that are defined locally at the current node.</summary>
		// Token: 0x04000AC6 RID: 2758
		Local
	}
}
