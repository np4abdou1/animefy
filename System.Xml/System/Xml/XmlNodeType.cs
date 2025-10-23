using System;

namespace System.Xml
{
	/// <summary>Specifies the type of node.</summary>
	// Token: 0x020001B8 RID: 440
	public enum XmlNodeType
	{
		/// <summary>This is returned by the <see cref="T:System.Xml.XmlReader" /> if a <see langword="Read" /> method has not been called.</summary>
		// Token: 0x04000AD4 RID: 2772
		None,
		/// <summary>An element (for example, &lt;item&gt; ).</summary>
		// Token: 0x04000AD5 RID: 2773
		Element,
		/// <summary>An attribute (for example, id='123' ).</summary>
		// Token: 0x04000AD6 RID: 2774
		Attribute,
		/// <summary>The text content of a node.</summary>
		// Token: 0x04000AD7 RID: 2775
		Text,
		/// <summary>A CDATA section (for example, &lt;![CDATA[my escaped text]]&gt; ).</summary>
		// Token: 0x04000AD8 RID: 2776
		CDATA,
		/// <summary>A reference to an entity (for example, &amp;num; ).</summary>
		// Token: 0x04000AD9 RID: 2777
		EntityReference,
		/// <summary>An entity declaration (for example, &lt;!ENTITY...&gt; ).</summary>
		// Token: 0x04000ADA RID: 2778
		Entity,
		/// <summary>A processing instruction (for example, &lt;?pi test?&gt; ).</summary>
		// Token: 0x04000ADB RID: 2779
		ProcessingInstruction,
		/// <summary>A comment (for example, &lt;!-- my comment --&gt; ).</summary>
		// Token: 0x04000ADC RID: 2780
		Comment,
		/// <summary>A document object that, as the root of the document tree, provides access to the entire XML document.</summary>
		// Token: 0x04000ADD RID: 2781
		Document,
		/// <summary>The document type declaration, indicated by the following tag (for example, &lt;!DOCTYPE...&gt; ).</summary>
		// Token: 0x04000ADE RID: 2782
		DocumentType,
		/// <summary>A document fragment.</summary>
		// Token: 0x04000ADF RID: 2783
		DocumentFragment,
		/// <summary>A notation in the document type declaration (for example, &lt;!NOTATION...&gt; ).</summary>
		// Token: 0x04000AE0 RID: 2784
		Notation,
		/// <summary>White space between markup.</summary>
		// Token: 0x04000AE1 RID: 2785
		Whitespace,
		/// <summary>White space between markup in a mixed content model or white space within the xml:space="preserve" scope.</summary>
		// Token: 0x04000AE2 RID: 2786
		SignificantWhitespace,
		/// <summary>An end element tag (for example, &lt;/item&gt; ).</summary>
		// Token: 0x04000AE3 RID: 2787
		EndElement,
		/// <summary>Returned when <see langword="XmlReader" /> gets to the end of the entity replacement as a result of a call to <see cref="M:System.Xml.XmlReader.ResolveEntity" />.</summary>
		// Token: 0x04000AE4 RID: 2788
		EndEntity,
		/// <summary>The XML declaration (for example, &lt;?xml version='1.0'?&gt; ).</summary>
		// Token: 0x04000AE5 RID: 2789
		XmlDeclaration
	}
}
