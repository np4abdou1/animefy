using System;
using System.Runtime.CompilerServices;
using System.Xml;
using System.Xml.Linq;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001C9 RID: 457
	[NullableContext(2)]
	[Nullable(0)]
	internal class XDeclarationWrapper : XObjectWrapper, IXmlDeclaration, IXmlNode
	{
		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06000F56 RID: 3926 RVA: 0x000431AE File Offset: 0x000413AE
		[Nullable(1)]
		internal XDeclaration Declaration { [NullableContext(1)] get; }

		// Token: 0x06000F57 RID: 3927 RVA: 0x000431B6 File Offset: 0x000413B6
		[NullableContext(1)]
		public XDeclarationWrapper(XDeclaration declaration) : base(null)
		{
			this.Declaration = declaration;
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06000F58 RID: 3928 RVA: 0x000431C6 File Offset: 0x000413C6
		public override XmlNodeType NodeType
		{
			get
			{
				return XmlNodeType.XmlDeclaration;
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06000F59 RID: 3929 RVA: 0x000431CA File Offset: 0x000413CA
		public string Version
		{
			get
			{
				return this.Declaration.Version;
			}
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06000F5A RID: 3930 RVA: 0x000431D7 File Offset: 0x000413D7
		// (set) Token: 0x06000F5B RID: 3931 RVA: 0x000431E4 File Offset: 0x000413E4
		public string Encoding
		{
			get
			{
				return this.Declaration.Encoding;
			}
			set
			{
				this.Declaration.Encoding = value;
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06000F5C RID: 3932 RVA: 0x000431F2 File Offset: 0x000413F2
		// (set) Token: 0x06000F5D RID: 3933 RVA: 0x000431FF File Offset: 0x000413FF
		public string Standalone
		{
			get
			{
				return this.Declaration.Standalone;
			}
			set
			{
				this.Declaration.Standalone = value;
			}
		}
	}
}
