using System;

namespace System.Xml
{
	/// <summary>Provides an interface to enable a class to return line and position information.</summary>
	// Token: 0x0200015B RID: 347
	public interface IXmlLineInfo
	{
		/// <summary>Gets a value indicating whether the class can return line information.</summary>
		/// <returns>
		///     <see langword="true" /> if <see cref="P:System.Xml.IXmlLineInfo.LineNumber" /> and <see cref="P:System.Xml.IXmlLineInfo.LinePosition" /> can be provided; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000CF1 RID: 3313
		bool HasLineInfo();

		/// <summary>Gets the current line number.</summary>
		/// <returns>The current line number or 0 if no line information is available (for example, <see cref="M:System.Xml.IXmlLineInfo.HasLineInfo" /> returns <see langword="false" />).</returns>
		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06000CF2 RID: 3314
		int LineNumber { get; }

		/// <summary>Gets the current line position.</summary>
		/// <returns>The current line position or 0 if no line information is available (for example, <see cref="M:System.Xml.IXmlLineInfo.HasLineInfo" /> returns <see langword="false" />).</returns>
		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06000CF3 RID: 3315
		int LinePosition { get; }
	}
}
