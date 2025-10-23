using System;
using System.Collections.Generic;

namespace System.Xml
{
	// Token: 0x0200004B RID: 75
	internal class XmlAsyncCheckReaderWithLineInfoNS : XmlAsyncCheckReaderWithLineInfo, IXmlNamespaceResolver
	{
		// Token: 0x0600025F RID: 607 RVA: 0x0000B582 File Offset: 0x00009782
		public XmlAsyncCheckReaderWithLineInfoNS(XmlReader reader) : base(reader)
		{
			this.readerAsIXmlNamespaceResolver = (IXmlNamespaceResolver)reader;
		}

		// Token: 0x06000260 RID: 608 RVA: 0x0000B597 File Offset: 0x00009797
		IDictionary<string, string> IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope)
		{
			return this.readerAsIXmlNamespaceResolver.GetNamespacesInScope(scope);
		}

		// Token: 0x06000261 RID: 609 RVA: 0x0000B5A5 File Offset: 0x000097A5
		string IXmlNamespaceResolver.LookupNamespace(string prefix)
		{
			return this.readerAsIXmlNamespaceResolver.LookupNamespace(prefix);
		}

		// Token: 0x06000262 RID: 610 RVA: 0x0000B5B3 File Offset: 0x000097B3
		string IXmlNamespaceResolver.LookupPrefix(string namespaceName)
		{
			return this.readerAsIXmlNamespaceResolver.LookupPrefix(namespaceName);
		}

		// Token: 0x04000178 RID: 376
		private readonly IXmlNamespaceResolver readerAsIXmlNamespaceResolver;
	}
}
