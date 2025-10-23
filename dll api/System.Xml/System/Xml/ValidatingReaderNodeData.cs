using System;

namespace System.Xml
{
	// Token: 0x02000045 RID: 69
	internal class ValidatingReaderNodeData
	{
		// Token: 0x06000206 RID: 518 RVA: 0x0000AE5B File Offset: 0x0000905B
		public ValidatingReaderNodeData()
		{
			this.Clear(XmlNodeType.None);
		}

		// Token: 0x06000207 RID: 519 RVA: 0x0000AE6A File Offset: 0x0000906A
		public ValidatingReaderNodeData(XmlNodeType nodeType)
		{
			this.Clear(nodeType);
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000208 RID: 520 RVA: 0x0000AE79 File Offset: 0x00009079
		// (set) Token: 0x06000209 RID: 521 RVA: 0x0000AE81 File Offset: 0x00009081
		public string LocalName
		{
			get
			{
				return this.localName;
			}
			set
			{
				this.localName = value;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600020A RID: 522 RVA: 0x0000AE8A File Offset: 0x0000908A
		// (set) Token: 0x0600020B RID: 523 RVA: 0x0000AE92 File Offset: 0x00009092
		public string Namespace
		{
			get
			{
				return this.namespaceUri;
			}
			set
			{
				this.namespaceUri = value;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600020C RID: 524 RVA: 0x0000AE9B File Offset: 0x0000909B
		// (set) Token: 0x0600020D RID: 525 RVA: 0x0000AEA3 File Offset: 0x000090A3
		public string Prefix
		{
			get
			{
				return this.prefix;
			}
			set
			{
				this.prefix = value;
			}
		}

		// Token: 0x0600020E RID: 526 RVA: 0x0000AEAC File Offset: 0x000090AC
		public string GetAtomizedNameWPrefix(XmlNameTable nameTable)
		{
			if (this.nameWPrefix == null)
			{
				if (this.prefix.Length == 0)
				{
					this.nameWPrefix = this.localName;
				}
				else
				{
					this.nameWPrefix = nameTable.Add(this.prefix + ":" + this.localName);
				}
			}
			return this.nameWPrefix;
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600020F RID: 527 RVA: 0x0000AF04 File Offset: 0x00009104
		// (set) Token: 0x06000210 RID: 528 RVA: 0x0000AF0C File Offset: 0x0000910C
		public int Depth
		{
			get
			{
				return this.depth;
			}
			set
			{
				this.depth = value;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000211 RID: 529 RVA: 0x0000AF15 File Offset: 0x00009115
		// (set) Token: 0x06000212 RID: 530 RVA: 0x0000AF1D File Offset: 0x0000911D
		public string RawValue
		{
			get
			{
				return this.rawValue;
			}
			set
			{
				this.rawValue = value;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000213 RID: 531 RVA: 0x0000AF26 File Offset: 0x00009126
		public string OriginalStringValue
		{
			get
			{
				return this.originalStringValue;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000214 RID: 532 RVA: 0x0000AF2E File Offset: 0x0000912E
		// (set) Token: 0x06000215 RID: 533 RVA: 0x0000AF36 File Offset: 0x00009136
		public XmlNodeType NodeType
		{
			get
			{
				return this.nodeType;
			}
			set
			{
				this.nodeType = value;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000216 RID: 534 RVA: 0x0000AF3F File Offset: 0x0000913F
		// (set) Token: 0x06000217 RID: 535 RVA: 0x0000AF47 File Offset: 0x00009147
		public AttributePSVIInfo AttInfo
		{
			get
			{
				return this.attributePSVIInfo;
			}
			set
			{
				this.attributePSVIInfo = value;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000218 RID: 536 RVA: 0x0000AF50 File Offset: 0x00009150
		public int LineNumber
		{
			get
			{
				return this.lineNo;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000219 RID: 537 RVA: 0x0000AF58 File Offset: 0x00009158
		public int LinePosition
		{
			get
			{
				return this.linePos;
			}
		}

		// Token: 0x0600021A RID: 538 RVA: 0x0000AF60 File Offset: 0x00009160
		internal void Clear(XmlNodeType nodeType)
		{
			this.nodeType = nodeType;
			this.localName = string.Empty;
			this.prefix = string.Empty;
			this.namespaceUri = string.Empty;
			this.rawValue = string.Empty;
			if (this.attributePSVIInfo != null)
			{
				this.attributePSVIInfo.Reset();
			}
			this.nameWPrefix = null;
			this.lineNo = 0;
			this.linePos = 0;
		}

		// Token: 0x0600021B RID: 539 RVA: 0x0000AFC8 File Offset: 0x000091C8
		internal void SetLineInfo(int lineNo, int linePos)
		{
			this.lineNo = lineNo;
			this.linePos = linePos;
		}

		// Token: 0x0600021C RID: 540 RVA: 0x0000AFD8 File Offset: 0x000091D8
		internal void SetLineInfo(IXmlLineInfo lineInfo)
		{
			if (lineInfo != null)
			{
				this.lineNo = lineInfo.LineNumber;
				this.linePos = lineInfo.LinePosition;
			}
		}

		// Token: 0x0600021D RID: 541 RVA: 0x0000AFF5 File Offset: 0x000091F5
		internal void SetItemData(string localName, string prefix, string ns, int depth)
		{
			this.localName = localName;
			this.prefix = prefix;
			this.namespaceUri = ns;
			this.depth = depth;
			this.rawValue = string.Empty;
		}

		// Token: 0x0600021E RID: 542 RVA: 0x0000B01F File Offset: 0x0000921F
		internal void SetItemData(string value)
		{
			this.SetItemData(value, value);
		}

		// Token: 0x0600021F RID: 543 RVA: 0x0000B029 File Offset: 0x00009229
		internal void SetItemData(string value, string originalStringValue)
		{
			this.rawValue = value;
			this.originalStringValue = originalStringValue;
		}

		// Token: 0x0400015F RID: 351
		private string localName;

		// Token: 0x04000160 RID: 352
		private string namespaceUri;

		// Token: 0x04000161 RID: 353
		private string prefix;

		// Token: 0x04000162 RID: 354
		private string nameWPrefix;

		// Token: 0x04000163 RID: 355
		private string rawValue;

		// Token: 0x04000164 RID: 356
		private string originalStringValue;

		// Token: 0x04000165 RID: 357
		private int depth;

		// Token: 0x04000166 RID: 358
		private AttributePSVIInfo attributePSVIInfo;

		// Token: 0x04000167 RID: 359
		private XmlNodeType nodeType;

		// Token: 0x04000168 RID: 360
		private int lineNo;

		// Token: 0x04000169 RID: 361
		private int linePos;
	}
}
