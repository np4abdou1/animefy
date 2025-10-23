using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001C7 RID: 455
	[NullableContext(1)]
	internal interface IXmlElement : IXmlNode
	{
		// Token: 0x06000F49 RID: 3913
		void SetAttributeNode(IXmlNode attribute);

		// Token: 0x06000F4A RID: 3914
		[return: Nullable(2)]
		string GetPrefixOfNamespace(string namespaceUri);

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06000F4B RID: 3915
		bool IsEmpty { get; }
	}
}
