﻿using System;

namespace System.Xml.XPath
{
	/// <summary>Defines the namespace scope.</summary>
	// Token: 0x020001C3 RID: 451
	public enum XPathNamespaceScope
	{
		/// <summary>Returns all namespaces defined in the scope of the current node. This includes the xmlns:xml namespace which is always declared implicitly. The order of the namespaces returned is not defined.</summary>
		// Token: 0x04000B01 RID: 2817
		All,
		/// <summary>Returns all namespaces defined in the scope of the current node, excluding the xmlns:xml namespace. The xmlns:xml namespace is always declared implicitly. The order of the namespaces returned is not defined.</summary>
		// Token: 0x04000B02 RID: 2818
		ExcludeXml,
		/// <summary>Returns all namespaces that are defined locally at the current node. </summary>
		// Token: 0x04000B03 RID: 2819
		Local
	}
}
