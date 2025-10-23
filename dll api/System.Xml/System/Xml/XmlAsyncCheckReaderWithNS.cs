using System;
using System.Collections.Generic;

namespace System.Xml
{
	// Token: 0x02000049 RID: 73
	internal class XmlAsyncCheckReaderWithNS : XmlAsyncCheckReader, IXmlNamespaceResolver
	{
		// Token: 0x06000257 RID: 599 RVA: 0x0000B507 File Offset: 0x00009707
		public XmlAsyncCheckReaderWithNS(XmlReader reader) : base(reader)
		{
			this.readerAsIXmlNamespaceResolver = (IXmlNamespaceResolver)reader;
		}

		// Token: 0x06000258 RID: 600 RVA: 0x0000B51C File Offset: 0x0000971C
		IDictionary<string, string> IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope)
		{
			return this.readerAsIXmlNamespaceResolver.GetNamespacesInScope(scope);
		}

		// Token: 0x06000259 RID: 601 RVA: 0x0000B52A File Offset: 0x0000972A
		string IXmlNamespaceResolver.LookupNamespace(string prefix)
		{
			return this.readerAsIXmlNamespaceResolver.LookupNamespace(prefix);
		}

		// Token: 0x0600025A RID: 602 RVA: 0x0000B538 File Offset: 0x00009738
		string IXmlNamespaceResolver.LookupPrefix(string namespaceName)
		{
			return this.readerAsIXmlNamespaceResolver.LookupPrefix(namespaceName);
		}

		// Token: 0x04000176 RID: 374
		private readonly IXmlNamespaceResolver readerAsIXmlNamespaceResolver;
	}
}
