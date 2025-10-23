using System;

namespace System.Xml
{
	/// <summary>Specifies the state of the reader.</summary>
	// Token: 0x02000040 RID: 64
	public enum ReadState
	{
		/// <summary>The <see langword="Read" /> method has not been called.</summary>
		// Token: 0x04000158 RID: 344
		Initial,
		/// <summary>The <see langword="Read" /> method has been called. Additional methods may be called on the reader.</summary>
		// Token: 0x04000159 RID: 345
		Interactive,
		/// <summary>An error occurred that prevents the read operation from continuing.</summary>
		// Token: 0x0400015A RID: 346
		Error,
		/// <summary>The end of the file has been reached successfully.</summary>
		// Token: 0x0400015B RID: 347
		EndOfFile,
		/// <summary>The <see cref="M:System.Xml.XmlReader.Close" /> method has been called.</summary>
		// Token: 0x0400015C RID: 348
		Closed
	}
}
