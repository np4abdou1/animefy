using System;
using System.Xml;

namespace System.Data
{
	// Token: 0x020000AB RID: 171
	internal sealed class DataTextReader : XmlReader
	{
		// Token: 0x060009ED RID: 2541 RVA: 0x0003BA3A File Offset: 0x00039C3A
		internal static XmlReader CreateReader(XmlReader xr)
		{
			return new DataTextReader(xr);
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x0003BA42 File Offset: 0x00039C42
		private DataTextReader(XmlReader input)
		{
			this._xmlreader = input;
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x060009EF RID: 2543 RVA: 0x0003BA51 File Offset: 0x00039C51
		public override XmlReaderSettings Settings
		{
			get
			{
				return this._xmlreader.Settings;
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x060009F0 RID: 2544 RVA: 0x0003BA5E File Offset: 0x00039C5E
		public override XmlNodeType NodeType
		{
			get
			{
				return this._xmlreader.NodeType;
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x060009F1 RID: 2545 RVA: 0x0003BA6B File Offset: 0x00039C6B
		public override string Name
		{
			get
			{
				return this._xmlreader.Name;
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x060009F2 RID: 2546 RVA: 0x0003BA78 File Offset: 0x00039C78
		public override string LocalName
		{
			get
			{
				return this._xmlreader.LocalName;
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x060009F3 RID: 2547 RVA: 0x0003BA85 File Offset: 0x00039C85
		public override string NamespaceURI
		{
			get
			{
				return this._xmlreader.NamespaceURI;
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x060009F4 RID: 2548 RVA: 0x0003BA92 File Offset: 0x00039C92
		public override string Prefix
		{
			get
			{
				return this._xmlreader.Prefix;
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x060009F5 RID: 2549 RVA: 0x0003BA9F File Offset: 0x00039C9F
		public override string Value
		{
			get
			{
				return this._xmlreader.Value;
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x060009F6 RID: 2550 RVA: 0x0003BAAC File Offset: 0x00039CAC
		public override int Depth
		{
			get
			{
				return this._xmlreader.Depth;
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x060009F7 RID: 2551 RVA: 0x0003BAB9 File Offset: 0x00039CB9
		public override string BaseURI
		{
			get
			{
				return this._xmlreader.BaseURI;
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x060009F8 RID: 2552 RVA: 0x0003BAC6 File Offset: 0x00039CC6
		public override bool IsEmptyElement
		{
			get
			{
				return this._xmlreader.IsEmptyElement;
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x060009F9 RID: 2553 RVA: 0x0003BAD3 File Offset: 0x00039CD3
		public override bool IsDefault
		{
			get
			{
				return this._xmlreader.IsDefault;
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x060009FA RID: 2554 RVA: 0x0003BAE0 File Offset: 0x00039CE0
		public override char QuoteChar
		{
			get
			{
				return this._xmlreader.QuoteChar;
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x060009FB RID: 2555 RVA: 0x0003BAED File Offset: 0x00039CED
		public override XmlSpace XmlSpace
		{
			get
			{
				return this._xmlreader.XmlSpace;
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x060009FC RID: 2556 RVA: 0x0003BAFA File Offset: 0x00039CFA
		public override string XmlLang
		{
			get
			{
				return this._xmlreader.XmlLang;
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x060009FD RID: 2557 RVA: 0x0003BB07 File Offset: 0x00039D07
		public override int AttributeCount
		{
			get
			{
				return this._xmlreader.AttributeCount;
			}
		}

		// Token: 0x060009FE RID: 2558 RVA: 0x0003BB14 File Offset: 0x00039D14
		public override string GetAttribute(string name)
		{
			return this._xmlreader.GetAttribute(name);
		}

		// Token: 0x060009FF RID: 2559 RVA: 0x0003BB22 File Offset: 0x00039D22
		public override string GetAttribute(string localName, string namespaceURI)
		{
			return this._xmlreader.GetAttribute(localName, namespaceURI);
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x0003BB31 File Offset: 0x00039D31
		public override string GetAttribute(int i)
		{
			return this._xmlreader.GetAttribute(i);
		}

		// Token: 0x06000A01 RID: 2561 RVA: 0x0003BB3F File Offset: 0x00039D3F
		public override bool MoveToAttribute(string name)
		{
			return this._xmlreader.MoveToAttribute(name);
		}

		// Token: 0x06000A02 RID: 2562 RVA: 0x0003BB4D File Offset: 0x00039D4D
		public override void MoveToAttribute(int i)
		{
			this._xmlreader.MoveToAttribute(i);
		}

		// Token: 0x06000A03 RID: 2563 RVA: 0x0003BB5B File Offset: 0x00039D5B
		public override bool MoveToFirstAttribute()
		{
			return this._xmlreader.MoveToFirstAttribute();
		}

		// Token: 0x06000A04 RID: 2564 RVA: 0x0003BB68 File Offset: 0x00039D68
		public override bool MoveToNextAttribute()
		{
			return this._xmlreader.MoveToNextAttribute();
		}

		// Token: 0x06000A05 RID: 2565 RVA: 0x0003BB75 File Offset: 0x00039D75
		public override bool MoveToElement()
		{
			return this._xmlreader.MoveToElement();
		}

		// Token: 0x06000A06 RID: 2566 RVA: 0x0003BB82 File Offset: 0x00039D82
		public override bool ReadAttributeValue()
		{
			return this._xmlreader.ReadAttributeValue();
		}

		// Token: 0x06000A07 RID: 2567 RVA: 0x0003BB8F File Offset: 0x00039D8F
		public override bool Read()
		{
			return this._xmlreader.Read();
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000A08 RID: 2568 RVA: 0x0003BB9C File Offset: 0x00039D9C
		public override bool EOF
		{
			get
			{
				return this._xmlreader.EOF;
			}
		}

		// Token: 0x06000A09 RID: 2569 RVA: 0x0003BBA9 File Offset: 0x00039DA9
		public override void Close()
		{
			this._xmlreader.Close();
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000A0A RID: 2570 RVA: 0x0003BBB6 File Offset: 0x00039DB6
		public override ReadState ReadState
		{
			get
			{
				return this._xmlreader.ReadState;
			}
		}

		// Token: 0x06000A0B RID: 2571 RVA: 0x0003BBC3 File Offset: 0x00039DC3
		public override void Skip()
		{
			this._xmlreader.Skip();
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000A0C RID: 2572 RVA: 0x0003BBD0 File Offset: 0x00039DD0
		public override XmlNameTable NameTable
		{
			get
			{
				return this._xmlreader.NameTable;
			}
		}

		// Token: 0x06000A0D RID: 2573 RVA: 0x0003BBDD File Offset: 0x00039DDD
		public override string LookupNamespace(string prefix)
		{
			return this._xmlreader.LookupNamespace(prefix);
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000A0E RID: 2574 RVA: 0x0003BBEB File Offset: 0x00039DEB
		public override bool CanResolveEntity
		{
			get
			{
				return this._xmlreader.CanResolveEntity;
			}
		}

		// Token: 0x06000A0F RID: 2575 RVA: 0x0003BBF8 File Offset: 0x00039DF8
		public override void ResolveEntity()
		{
			this._xmlreader.ResolveEntity();
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000A10 RID: 2576 RVA: 0x0003BC05 File Offset: 0x00039E05
		public override bool CanReadValueChunk
		{
			get
			{
				return this._xmlreader.CanReadValueChunk;
			}
		}

		// Token: 0x06000A11 RID: 2577 RVA: 0x0003BC12 File Offset: 0x00039E12
		public override string ReadString()
		{
			return this._xmlreader.ReadString();
		}

		// Token: 0x04000381 RID: 897
		private XmlReader _xmlreader;
	}
}
