using System;

namespace System.Xml
{
	/// <summary>Specifies how to handle line breaks.</summary>
	// Token: 0x02000037 RID: 55
	public enum NewLineHandling
	{
		/// <summary>New line characters are replaced to match the character specified in the <see cref="P:System.Xml.XmlWriterSettings.NewLineChars" />  property.</summary>
		// Token: 0x04000127 RID: 295
		Replace,
		/// <summary>New line characters are entitized. This setting preserves all characters when the output is read by a normalizing <see cref="T:System.Xml.XmlReader" />.</summary>
		// Token: 0x04000128 RID: 296
		Entitize,
		/// <summary>The new line characters are unchanged. The output is the same as the input.</summary>
		// Token: 0x04000129 RID: 297
		None
	}
}
