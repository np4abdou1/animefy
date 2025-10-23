using System;
using System.Collections.Generic;

namespace System.Xml
{
	/// <summary>Provides read-only access to a set of prefix and namespace mappings.</summary>
	// Token: 0x0200015E RID: 350
	public interface IXmlNamespaceResolver
	{
		/// <summary>Gets a collection of defined prefix-namespace mappings that are currently in scope.</summary>
		/// <param name="scope">An <see cref="T:System.Xml.XmlNamespaceScope" /> value that specifies the type of namespace nodes to return.</param>
		/// <returns>An <see cref="T:System.Collections.IDictionary" /> that contains the current in-scope namespaces.</returns>
		// Token: 0x06000CFD RID: 3325
		IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope);

		/// <summary>Gets the namespace URI mapped to the specified prefix.</summary>
		/// <param name="prefix">The prefix whose namespace URI you wish to find.</param>
		/// <returns>The namespace URI that is mapped to the prefix; <see langword="null" /> if the prefix is not mapped to a namespace URI.</returns>
		// Token: 0x06000CFE RID: 3326
		string LookupNamespace(string prefix);

		/// <summary>Gets the prefix that is mapped to the specified namespace URI.</summary>
		/// <param name="namespaceName">The namespace URI whose prefix you wish to find.</param>
		/// <returns>The prefix that is mapped to the namespace URI; <see langword="null" /> if the namespace URI is not mapped to a prefix.</returns>
		// Token: 0x06000CFF RID: 3327
		string LookupPrefix(string namespaceName);
	}
}
