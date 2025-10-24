using System;
using System.Runtime.CompilerServices;
using System.Xml;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001C1 RID: 449
	[NullableContext(2)]
	[Nullable(0)]
	internal class XmlDeclarationWrapper : XmlNodeWrapper, IXmlDeclaration, IXmlNode
	{
		// Token: 0x06000F19 RID: 3865 RVA: 0x00042E4E File Offset: 0x0004104E
		[NullableContext(1)]
		public XmlDeclarationWrapper(XmlDeclaration declaration) : base(declaration)
		{
			this._declaration = declaration;
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000F1A RID: 3866 RVA: 0x00042E5E File Offset: 0x0004105E
		public string Version
		{
			get
			{
				return this._declaration.Version;
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06000F1B RID: 3867 RVA: 0x00042E6B File Offset: 0x0004106B
		// (set) Token: 0x06000F1C RID: 3868 RVA: 0x00042E78 File Offset: 0x00041078
		public string Encoding
		{
			get
			{
				return this._declaration.Encoding;
			}
			set
			{
				this._declaration.Encoding = value;
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06000F1D RID: 3869 RVA: 0x00042E86 File Offset: 0x00041086
		// (set) Token: 0x06000F1E RID: 3870 RVA: 0x00042E93 File Offset: 0x00041093
		public string Standalone
		{
			get
			{
				return this._declaration.Standalone;
			}
			set
			{
				this._declaration.Standalone = value;
			}
		}

		// Token: 0x04000815 RID: 2069
		[Nullable(1)]
		private readonly XmlDeclaration _declaration;
	}
}
