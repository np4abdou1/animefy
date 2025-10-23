using System;

namespace System.Xml.XPath
{
	/// <summary>Defines the XPath node types that can be returned from the <see cref="T:System.Xml.XPath.XPathNavigator" /> class.</summary>
	// Token: 0x020001C5 RID: 453
	public enum XPathNodeType
	{
		/// <summary>The root node of the XML document or node tree.</summary>
		// Token: 0x04000B05 RID: 2821
		Root,
		/// <summary>An element, such as &lt;element&gt;.</summary>
		// Token: 0x04000B06 RID: 2822
		Element,
		/// <summary>An attribute, such as id='123'.</summary>
		// Token: 0x04000B07 RID: 2823
		Attribute,
		/// <summary>A namespace, such as xmlns="namespace".</summary>
		// Token: 0x04000B08 RID: 2824
		Namespace,
		/// <summary>The text content of a node. Equivalent to the Document Object Model (DOM) Text and CDATA node types. Contains at least one character.</summary>
		// Token: 0x04000B09 RID: 2825
		Text,
		/// <summary>A node with white space characters and xml:space set to preserve.</summary>
		// Token: 0x04000B0A RID: 2826
		SignificantWhitespace,
		/// <summary>A node with only white space characters and no significant white space. White space characters are #x20, #x9, #xD, or #xA.</summary>
		// Token: 0x04000B0B RID: 2827
		Whitespace,
		/// <summary>A processing instruction, such as &lt;?pi test?&gt;. This does not include XML declarations, which are not visible to the <see cref="T:System.Xml.XPath.XPathNavigator" /> class. </summary>
		// Token: 0x04000B0C RID: 2828
		ProcessingInstruction,
		/// <summary>A comment, such as &lt;!-- my comment --&gt;</summary>
		// Token: 0x04000B0D RID: 2829
		Comment,
		/// <summary>Any of the <see cref="T:System.Xml.XPath.XPathNodeType" /> node types.</summary>
		// Token: 0x04000B0E RID: 2830
		All
	}
}
