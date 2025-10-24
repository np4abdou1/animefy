using System;

namespace System.Xml.Schema
{
	// Token: 0x020002B3 RID: 691
	internal sealed class SchemaEntity : IDtdEntityInfo
	{
		// Token: 0x06001671 RID: 5745 RVA: 0x0008A5C8 File Offset: 0x000887C8
		internal SchemaEntity(XmlQualifiedName qname, bool isParameter)
		{
			this.qname = qname;
			this.isParameter = isParameter;
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x06001672 RID: 5746 RVA: 0x0008A5E9 File Offset: 0x000887E9
		string IDtdEntityInfo.Name
		{
			get
			{
				return this.Name.Name;
			}
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06001673 RID: 5747 RVA: 0x0008A5F6 File Offset: 0x000887F6
		bool IDtdEntityInfo.IsExternal
		{
			get
			{
				return this.IsExternal;
			}
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06001674 RID: 5748 RVA: 0x0008A5FE File Offset: 0x000887FE
		bool IDtdEntityInfo.IsDeclaredInExternal
		{
			get
			{
				return this.DeclaredInExternal;
			}
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06001675 RID: 5749 RVA: 0x0008A606 File Offset: 0x00088806
		bool IDtdEntityInfo.IsUnparsedEntity
		{
			get
			{
				return !this.NData.IsEmpty;
			}
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x06001676 RID: 5750 RVA: 0x0008A616 File Offset: 0x00088816
		bool IDtdEntityInfo.IsParameterEntity
		{
			get
			{
				return this.isParameter;
			}
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x06001677 RID: 5751 RVA: 0x0008A61E File Offset: 0x0008881E
		string IDtdEntityInfo.BaseUriString
		{
			get
			{
				return this.BaseURI;
			}
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x06001678 RID: 5752 RVA: 0x0008A626 File Offset: 0x00088826
		string IDtdEntityInfo.DeclaredUriString
		{
			get
			{
				return this.DeclaredURI;
			}
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x06001679 RID: 5753 RVA: 0x0008A62E File Offset: 0x0008882E
		string IDtdEntityInfo.SystemId
		{
			get
			{
				return this.Url;
			}
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x0600167A RID: 5754 RVA: 0x0008A636 File Offset: 0x00088836
		string IDtdEntityInfo.PublicId
		{
			get
			{
				return this.Pubid;
			}
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x0600167B RID: 5755 RVA: 0x0008A63E File Offset: 0x0008883E
		string IDtdEntityInfo.Text
		{
			get
			{
				return this.Text;
			}
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x0600167C RID: 5756 RVA: 0x0008A646 File Offset: 0x00088846
		int IDtdEntityInfo.LineNumber
		{
			get
			{
				return this.Line;
			}
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x0600167D RID: 5757 RVA: 0x0008A64E File Offset: 0x0008884E
		int IDtdEntityInfo.LinePosition
		{
			get
			{
				return this.Pos;
			}
		}

		// Token: 0x0600167E RID: 5758 RVA: 0x0008A658 File Offset: 0x00088858
		internal static bool IsPredefinedEntity(string n)
		{
			return n == "lt" || n == "gt" || n == "amp" || n == "apos" || n == "quot";
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x0600167F RID: 5759 RVA: 0x0008A6A6 File Offset: 0x000888A6
		internal XmlQualifiedName Name
		{
			get
			{
				return this.qname;
			}
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x06001680 RID: 5760 RVA: 0x0008A6AE File Offset: 0x000888AE
		// (set) Token: 0x06001681 RID: 5761 RVA: 0x0008A6B6 File Offset: 0x000888B6
		internal string Url
		{
			get
			{
				return this.url;
			}
			set
			{
				this.url = value;
				this.isExternal = true;
			}
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x06001682 RID: 5762 RVA: 0x0008A6C6 File Offset: 0x000888C6
		// (set) Token: 0x06001683 RID: 5763 RVA: 0x0008A6CE File Offset: 0x000888CE
		internal string Pubid
		{
			get
			{
				return this.pubid;
			}
			set
			{
				this.pubid = value;
			}
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x06001684 RID: 5764 RVA: 0x0008A6D7 File Offset: 0x000888D7
		// (set) Token: 0x06001685 RID: 5765 RVA: 0x0008A6DF File Offset: 0x000888DF
		internal bool IsExternal
		{
			get
			{
				return this.isExternal;
			}
			set
			{
				this.isExternal = value;
			}
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x06001686 RID: 5766 RVA: 0x0008A6E8 File Offset: 0x000888E8
		// (set) Token: 0x06001687 RID: 5767 RVA: 0x0008A6F0 File Offset: 0x000888F0
		internal bool DeclaredInExternal
		{
			get
			{
				return this.isDeclaredInExternal;
			}
			set
			{
				this.isDeclaredInExternal = value;
			}
		}

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06001688 RID: 5768 RVA: 0x0008A6F9 File Offset: 0x000888F9
		// (set) Token: 0x06001689 RID: 5769 RVA: 0x0008A701 File Offset: 0x00088901
		internal XmlQualifiedName NData
		{
			get
			{
				return this.ndata;
			}
			set
			{
				this.ndata = value;
			}
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x0600168A RID: 5770 RVA: 0x0008A70A File Offset: 0x0008890A
		// (set) Token: 0x0600168B RID: 5771 RVA: 0x0008A712 File Offset: 0x00088912
		internal string Text
		{
			get
			{
				return this.text;
			}
			set
			{
				this.text = value;
				this.isExternal = false;
			}
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x0600168C RID: 5772 RVA: 0x0008A722 File Offset: 0x00088922
		// (set) Token: 0x0600168D RID: 5773 RVA: 0x0008A72A File Offset: 0x0008892A
		internal int Line
		{
			get
			{
				return this.lineNumber;
			}
			set
			{
				this.lineNumber = value;
			}
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x0600168E RID: 5774 RVA: 0x0008A733 File Offset: 0x00088933
		// (set) Token: 0x0600168F RID: 5775 RVA: 0x0008A73B File Offset: 0x0008893B
		internal int Pos
		{
			get
			{
				return this.linePosition;
			}
			set
			{
				this.linePosition = value;
			}
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x06001690 RID: 5776 RVA: 0x0008A744 File Offset: 0x00088944
		// (set) Token: 0x06001691 RID: 5777 RVA: 0x0008A75A File Offset: 0x0008895A
		internal string BaseURI
		{
			get
			{
				if (this.baseURI != null)
				{
					return this.baseURI;
				}
				return string.Empty;
			}
			set
			{
				this.baseURI = value;
			}
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x06001692 RID: 5778 RVA: 0x0008A763 File Offset: 0x00088963
		// (set) Token: 0x06001693 RID: 5779 RVA: 0x0008A76B File Offset: 0x0008896B
		internal bool ParsingInProgress
		{
			get
			{
				return this.parsingInProgress;
			}
			set
			{
				this.parsingInProgress = value;
			}
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x06001694 RID: 5780 RVA: 0x0008A774 File Offset: 0x00088974
		// (set) Token: 0x06001695 RID: 5781 RVA: 0x0008A78A File Offset: 0x0008898A
		internal string DeclaredURI
		{
			get
			{
				if (this.declaredURI != null)
				{
					return this.declaredURI;
				}
				return string.Empty;
			}
			set
			{
				this.declaredURI = value;
			}
		}

		// Token: 0x04000E42 RID: 3650
		private XmlQualifiedName qname;

		// Token: 0x04000E43 RID: 3651
		private string url;

		// Token: 0x04000E44 RID: 3652
		private string pubid;

		// Token: 0x04000E45 RID: 3653
		private string text;

		// Token: 0x04000E46 RID: 3654
		private XmlQualifiedName ndata = XmlQualifiedName.Empty;

		// Token: 0x04000E47 RID: 3655
		private int lineNumber;

		// Token: 0x04000E48 RID: 3656
		private int linePosition;

		// Token: 0x04000E49 RID: 3657
		private bool isParameter;

		// Token: 0x04000E4A RID: 3658
		private bool isExternal;

		// Token: 0x04000E4B RID: 3659
		private bool parsingInProgress;

		// Token: 0x04000E4C RID: 3660
		private bool isDeclaredInExternal;

		// Token: 0x04000E4D RID: 3661
		private string baseURI;

		// Token: 0x04000E4E RID: 3662
		private string declaredURI;
	}
}
