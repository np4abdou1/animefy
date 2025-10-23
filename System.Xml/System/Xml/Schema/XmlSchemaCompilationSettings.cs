using System;

namespace System.Xml.Schema
{
	/// <summary>Provides schema compilation options for the <see cref="T:System.Xml.Schema.XmlSchemaSet" /> class This class cannot be inherited.</summary>
	// Token: 0x020002DD RID: 733
	public sealed class XmlSchemaCompilationSettings
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Schema.XmlSchemaCompilationSettings" /> class. </summary>
		// Token: 0x0600188A RID: 6282 RVA: 0x000967FB File Offset: 0x000949FB
		public XmlSchemaCompilationSettings()
		{
			this.enableUpaCheck = true;
		}

		/// <summary>Gets or sets a value indicating whether the <see cref="T:System.Xml.Schema.XmlSchemaSet" /> should check for Unique Particle Attribution (UPA) violations.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Xml.Schema.XmlSchemaSet" /> should check for Unique Particle Attribution (UPA) violations; otherwise, <see langword="false" />. The default is <see langword="true" />.</returns>
		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x0600188B RID: 6283 RVA: 0x0009680A File Offset: 0x00094A0A
		public bool EnableUpaCheck
		{
			get
			{
				return this.enableUpaCheck;
			}
		}

		// Token: 0x0400105F RID: 4191
		private bool enableUpaCheck;
	}
}
