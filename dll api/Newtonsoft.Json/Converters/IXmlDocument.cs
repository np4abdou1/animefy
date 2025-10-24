using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001C4 RID: 452
	[NullableContext(1)]
	internal interface IXmlDocument : IXmlNode
	{
		// Token: 0x06000F33 RID: 3891
		IXmlNode CreateComment([Nullable(2)] string text);

		// Token: 0x06000F34 RID: 3892
		IXmlNode CreateTextNode([Nullable(2)] string text);

		// Token: 0x06000F35 RID: 3893
		IXmlNode CreateCDataSection([Nullable(2)] string data);

		// Token: 0x06000F36 RID: 3894
		IXmlNode CreateWhitespace([Nullable(2)] string text);

		// Token: 0x06000F37 RID: 3895
		IXmlNode CreateSignificantWhitespace([Nullable(2)] string text);

		// Token: 0x06000F38 RID: 3896
		IXmlNode CreateXmlDeclaration(string version, [Nullable(2)] string encoding, [Nullable(2)] string standalone);

		// Token: 0x06000F39 RID: 3897
		[NullableContext(2)]
		[return: Nullable(1)]
		IXmlNode CreateXmlDocumentType([Nullable(1)] string name, string publicId, string systemId, string internalSubset);

		// Token: 0x06000F3A RID: 3898
		IXmlNode CreateProcessingInstruction(string target, string data);

		// Token: 0x06000F3B RID: 3899
		IXmlElement CreateElement(string elementName);

		// Token: 0x06000F3C RID: 3900
		IXmlElement CreateElement(string qualifiedName, string namespaceUri);

		// Token: 0x06000F3D RID: 3901
		IXmlNode CreateAttribute(string name, string value);

		// Token: 0x06000F3E RID: 3902
		IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value);

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06000F3F RID: 3903
		[Nullable(2)]
		IXmlElement DocumentElement { [NullableContext(2)] get; }
	}
}
