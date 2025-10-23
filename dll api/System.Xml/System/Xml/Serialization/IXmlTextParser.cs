using System;

namespace System.Xml.Serialization
{
	/// <summary>Establishes a <see cref="P:System.Xml.Serialization.IXmlTextParser.Normalized" /> property for use by the .NET Framework infrastructure.</summary>
	// Token: 0x020001D1 RID: 465
	public interface IXmlTextParser
	{
		/// <summary>Gets or sets whether white space and attribute values are normalized.</summary>
		/// <returns>
		///     <see langword="true" /> if white space attributes values are normalized; otherwise, <see langword="false" />.</returns>
		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06000F96 RID: 3990
		// (set) Token: 0x06000F97 RID: 3991
		bool Normalized { get; set; }
	}
}
