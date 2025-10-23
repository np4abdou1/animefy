using System;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001CA RID: 458
	[NullableContext(2)]
	[Nullable(0)]
	internal class XDocumentTypeWrapper : XObjectWrapper, IXmlDocumentType, IXmlNode
	{
		// Token: 0x06000F5E RID: 3934 RVA: 0x0004320D File Offset: 0x0004140D
		[NullableContext(1)]
		public XDocumentTypeWrapper(XDocumentType documentType) : base(documentType)
		{
			this._documentType = documentType;
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000F5F RID: 3935 RVA: 0x0004321D File Offset: 0x0004141D
		[Nullable(1)]
		public string Name
		{
			[NullableContext(1)]
			get
			{
				return this._documentType.Name;
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06000F60 RID: 3936 RVA: 0x0004322A File Offset: 0x0004142A
		public string System
		{
			get
			{
				return this._documentType.SystemId;
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06000F61 RID: 3937 RVA: 0x00043237 File Offset: 0x00041437
		public string Public
		{
			get
			{
				return this._documentType.PublicId;
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06000F62 RID: 3938 RVA: 0x00043244 File Offset: 0x00041444
		public string InternalSubset
		{
			get
			{
				return this._documentType.InternalSubset;
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06000F63 RID: 3939 RVA: 0x00042EE5 File Offset: 0x000410E5
		public override string LocalName
		{
			get
			{
				return "DOCTYPE";
			}
		}

		// Token: 0x0400081B RID: 2075
		[Nullable(1)]
		private readonly XDocumentType _documentType;
	}
}
