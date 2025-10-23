using System;
using System.Runtime.CompilerServices;
using System.Xml;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001C2 RID: 450
	[NullableContext(2)]
	[Nullable(0)]
	internal class XmlDocumentTypeWrapper : XmlNodeWrapper, IXmlDocumentType, IXmlNode
	{
		// Token: 0x06000F1F RID: 3871 RVA: 0x00042EA1 File Offset: 0x000410A1
		[NullableContext(1)]
		public XmlDocumentTypeWrapper(XmlDocumentType documentType) : base(documentType)
		{
			this._documentType = documentType;
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000F20 RID: 3872 RVA: 0x00042EB1 File Offset: 0x000410B1
		[Nullable(1)]
		public string Name
		{
			[NullableContext(1)]
			get
			{
				return this._documentType.Name;
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06000F21 RID: 3873 RVA: 0x00042EBE File Offset: 0x000410BE
		public string System
		{
			get
			{
				return this._documentType.SystemId;
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000F22 RID: 3874 RVA: 0x00042ECB File Offset: 0x000410CB
		public string Public
		{
			get
			{
				return this._documentType.PublicId;
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000F23 RID: 3875 RVA: 0x00042ED8 File Offset: 0x000410D8
		public string InternalSubset
		{
			get
			{
				return this._documentType.InternalSubset;
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000F24 RID: 3876 RVA: 0x00042EE5 File Offset: 0x000410E5
		public override string LocalName
		{
			get
			{
				return "DOCTYPE";
			}
		}

		// Token: 0x04000816 RID: 2070
		[Nullable(1)]
		private readonly XmlDocumentType _documentType;
	}
}
