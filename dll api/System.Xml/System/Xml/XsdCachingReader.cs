using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace System.Xml
{
	// Token: 0x02000127 RID: 295
	[DefaultMember("Item")]
	internal class XsdCachingReader : XmlReader, IXmlLineInfo
	{
		// Token: 0x060009B4 RID: 2484 RVA: 0x00042D9F File Offset: 0x00040F9F
		internal XsdCachingReader(XmlReader reader, IXmlLineInfo lineInfo, CachingEventHandler handlerMethod)
		{
			this.coreReader = reader;
			this.lineInfo = lineInfo;
			this.cacheHandler = handlerMethod;
			this.attributeEvents = new ValidatingReaderNodeData[8];
			this.contentEvents = new ValidatingReaderNodeData[4];
			this.Init();
		}

		// Token: 0x060009B5 RID: 2485 RVA: 0x00042DDC File Offset: 0x00040FDC
		private void Init()
		{
			this.coreReaderNameTable = this.coreReader.NameTable;
			this.cacheState = XsdCachingReader.CachingReaderState.Init;
			this.contentIndex = 0;
			this.currentAttrIndex = -1;
			this.currentContentIndex = -1;
			this.attributeCount = 0;
			this.cachedNode = null;
			this.readAhead = false;
			if (this.coreReader.NodeType == XmlNodeType.Element)
			{
				ValidatingReaderNodeData validatingReaderNodeData = this.AddContent(this.coreReader.NodeType);
				validatingReaderNodeData.SetItemData(this.coreReader.LocalName, this.coreReader.Prefix, this.coreReader.NamespaceURI, this.coreReader.Depth);
				validatingReaderNodeData.SetLineInfo(this.lineInfo);
				this.RecordAttributes();
			}
		}

		// Token: 0x060009B6 RID: 2486 RVA: 0x00042E8D File Offset: 0x0004108D
		internal void Reset(XmlReader reader)
		{
			this.coreReader = reader;
			this.Init();
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x060009B7 RID: 2487 RVA: 0x00042E9C File Offset: 0x0004109C
		public override XmlReaderSettings Settings
		{
			get
			{
				return this.coreReader.Settings;
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x060009B8 RID: 2488 RVA: 0x00042EA9 File Offset: 0x000410A9
		public override XmlNodeType NodeType
		{
			get
			{
				return this.cachedNode.NodeType;
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x060009B9 RID: 2489 RVA: 0x00042EB6 File Offset: 0x000410B6
		public override string Name
		{
			get
			{
				return this.cachedNode.GetAtomizedNameWPrefix(this.coreReaderNameTable);
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x060009BA RID: 2490 RVA: 0x00042EC9 File Offset: 0x000410C9
		public override string LocalName
		{
			get
			{
				return this.cachedNode.LocalName;
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x060009BB RID: 2491 RVA: 0x00042ED6 File Offset: 0x000410D6
		public override string NamespaceURI
		{
			get
			{
				return this.cachedNode.Namespace;
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x060009BC RID: 2492 RVA: 0x00042EE3 File Offset: 0x000410E3
		public override string Prefix
		{
			get
			{
				return this.cachedNode.Prefix;
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x060009BD RID: 2493 RVA: 0x00042EF0 File Offset: 0x000410F0
		public override string Value
		{
			get
			{
				if (!this.returnOriginalStringValues)
				{
					return this.cachedNode.RawValue;
				}
				return this.cachedNode.OriginalStringValue;
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x060009BE RID: 2494 RVA: 0x00042F11 File Offset: 0x00041111
		public override int Depth
		{
			get
			{
				return this.cachedNode.Depth;
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x060009BF RID: 2495 RVA: 0x00042F1E File Offset: 0x0004111E
		public override string BaseURI
		{
			get
			{
				return this.coreReader.BaseURI;
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x060009C0 RID: 2496 RVA: 0x0000A216 File Offset: 0x00008416
		public override bool IsEmptyElement
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x060009C1 RID: 2497 RVA: 0x0000A216 File Offset: 0x00008416
		public override bool IsDefault
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x060009C2 RID: 2498 RVA: 0x00042F2B File Offset: 0x0004112B
		public override char QuoteChar
		{
			get
			{
				return this.coreReader.QuoteChar;
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x060009C3 RID: 2499 RVA: 0x00042F38 File Offset: 0x00041138
		public override XmlSpace XmlSpace
		{
			get
			{
				return this.coreReader.XmlSpace;
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x060009C4 RID: 2500 RVA: 0x00042F45 File Offset: 0x00041145
		public override string XmlLang
		{
			get
			{
				return this.coreReader.XmlLang;
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x060009C5 RID: 2501 RVA: 0x00042F52 File Offset: 0x00041152
		public override int AttributeCount
		{
			get
			{
				return this.attributeCount;
			}
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x00042F5C File Offset: 0x0004115C
		public override string GetAttribute(string name)
		{
			int num;
			if (name.IndexOf(':') == -1)
			{
				num = this.GetAttributeIndexWithoutPrefix(name);
			}
			else
			{
				num = this.GetAttributeIndexWithPrefix(name);
			}
			if (num < 0)
			{
				return null;
			}
			return this.attributeEvents[num].RawValue;
		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x00042F9C File Offset: 0x0004119C
		public override string GetAttribute(string name, string namespaceURI)
		{
			namespaceURI = ((namespaceURI == null) ? string.Empty : this.coreReaderNameTable.Get(namespaceURI));
			name = this.coreReaderNameTable.Get(name);
			for (int i = 0; i < this.attributeCount; i++)
			{
				ValidatingReaderNodeData validatingReaderNodeData = this.attributeEvents[i];
				if (Ref.Equal(validatingReaderNodeData.LocalName, name) && Ref.Equal(validatingReaderNodeData.Namespace, namespaceURI))
				{
					return validatingReaderNodeData.RawValue;
				}
			}
			return null;
		}

		// Token: 0x060009C8 RID: 2504 RVA: 0x0004300D File Offset: 0x0004120D
		public override string GetAttribute(int i)
		{
			if (i < 0 || i >= this.attributeCount)
			{
				throw new ArgumentOutOfRangeException("i");
			}
			return this.attributeEvents[i].RawValue;
		}

		// Token: 0x060009C9 RID: 2505 RVA: 0x00043034 File Offset: 0x00041234
		public override bool MoveToAttribute(string name)
		{
			int num;
			if (name.IndexOf(':') == -1)
			{
				num = this.GetAttributeIndexWithoutPrefix(name);
			}
			else
			{
				num = this.GetAttributeIndexWithPrefix(name);
			}
			if (num >= 0)
			{
				this.currentAttrIndex = num;
				this.cachedNode = this.attributeEvents[num];
				return true;
			}
			return false;
		}

		// Token: 0x060009CA RID: 2506 RVA: 0x0004307A File Offset: 0x0004127A
		public override void MoveToAttribute(int i)
		{
			if (i < 0 || i >= this.attributeCount)
			{
				throw new ArgumentOutOfRangeException("i");
			}
			this.currentAttrIndex = i;
			this.cachedNode = this.attributeEvents[i];
		}

		// Token: 0x060009CB RID: 2507 RVA: 0x000430A9 File Offset: 0x000412A9
		public override bool MoveToFirstAttribute()
		{
			if (this.attributeCount == 0)
			{
				return false;
			}
			this.currentAttrIndex = 0;
			this.cachedNode = this.attributeEvents[0];
			return true;
		}

		// Token: 0x060009CC RID: 2508 RVA: 0x000430CC File Offset: 0x000412CC
		public override bool MoveToNextAttribute()
		{
			if (this.currentAttrIndex + 1 < this.attributeCount)
			{
				ValidatingReaderNodeData[] array = this.attributeEvents;
				int num = this.currentAttrIndex + 1;
				this.currentAttrIndex = num;
				this.cachedNode = array[num];
				return true;
			}
			return false;
		}

		// Token: 0x060009CD RID: 2509 RVA: 0x0004310A File Offset: 0x0004130A
		public override bool MoveToElement()
		{
			if (this.cacheState != XsdCachingReader.CachingReaderState.Replay || this.cachedNode.NodeType != XmlNodeType.Attribute)
			{
				return false;
			}
			this.currentContentIndex = 0;
			this.currentAttrIndex = -1;
			this.Read();
			return true;
		}

		// Token: 0x060009CE RID: 2510 RVA: 0x0004313C File Offset: 0x0004133C
		public override bool Read()
		{
			switch (this.cacheState)
			{
			case XsdCachingReader.CachingReaderState.Init:
				this.cacheState = XsdCachingReader.CachingReaderState.Record;
				break;
			case XsdCachingReader.CachingReaderState.Record:
				break;
			case XsdCachingReader.CachingReaderState.Replay:
				if (this.currentContentIndex >= this.contentIndex)
				{
					this.cacheState = XsdCachingReader.CachingReaderState.ReaderClosed;
					this.cacheHandler(this);
					return (this.coreReader.NodeType == XmlNodeType.Element && !this.readAhead) || this.coreReader.Read();
				}
				this.cachedNode = this.contentEvents[this.currentContentIndex];
				if (this.currentContentIndex > 0)
				{
					this.ClearAttributesInfo();
				}
				this.currentContentIndex++;
				return true;
			default:
				return false;
			}
			ValidatingReaderNodeData validatingReaderNodeData = null;
			if (this.coreReader.Read())
			{
				switch (this.coreReader.NodeType)
				{
				case XmlNodeType.Element:
					this.cacheState = XsdCachingReader.CachingReaderState.ReaderClosed;
					return false;
				case XmlNodeType.Text:
				case XmlNodeType.CDATA:
				case XmlNodeType.ProcessingInstruction:
				case XmlNodeType.Comment:
				case XmlNodeType.Whitespace:
				case XmlNodeType.SignificantWhitespace:
					validatingReaderNodeData = this.AddContent(this.coreReader.NodeType);
					validatingReaderNodeData.SetItemData(this.coreReader.Value);
					validatingReaderNodeData.SetLineInfo(this.lineInfo);
					validatingReaderNodeData.Depth = this.coreReader.Depth;
					break;
				case XmlNodeType.EndElement:
					validatingReaderNodeData = this.AddContent(this.coreReader.NodeType);
					validatingReaderNodeData.SetItemData(this.coreReader.LocalName, this.coreReader.Prefix, this.coreReader.NamespaceURI, this.coreReader.Depth);
					validatingReaderNodeData.SetLineInfo(this.lineInfo);
					break;
				}
				this.cachedNode = validatingReaderNodeData;
				return true;
			}
			this.cacheState = XsdCachingReader.CachingReaderState.ReaderClosed;
			return false;
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x000432FC File Offset: 0x000414FC
		internal ValidatingReaderNodeData RecordTextNode(string textValue, string originalStringValue, int depth, int lineNo, int linePos)
		{
			ValidatingReaderNodeData validatingReaderNodeData = this.AddContent(XmlNodeType.Text);
			validatingReaderNodeData.SetItemData(textValue, originalStringValue);
			validatingReaderNodeData.SetLineInfo(lineNo, linePos);
			validatingReaderNodeData.Depth = depth;
			return validatingReaderNodeData;
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x00043320 File Offset: 0x00041520
		internal void SwitchTextNodeAndEndElement(string textValue, string originalStringValue)
		{
			ValidatingReaderNodeData validatingReaderNodeData = this.RecordTextNode(textValue, originalStringValue, this.coreReader.Depth + 1, 0, 0);
			int num = this.contentIndex - 2;
			ValidatingReaderNodeData validatingReaderNodeData2 = this.contentEvents[num];
			this.contentEvents[num] = validatingReaderNodeData;
			this.contentEvents[this.contentIndex - 1] = validatingReaderNodeData2;
		}

		// Token: 0x060009D1 RID: 2513 RVA: 0x00043370 File Offset: 0x00041570
		internal void RecordEndElementNode()
		{
			ValidatingReaderNodeData validatingReaderNodeData = this.AddContent(XmlNodeType.EndElement);
			validatingReaderNodeData.SetItemData(this.coreReader.LocalName, this.coreReader.Prefix, this.coreReader.NamespaceURI, this.coreReader.Depth);
			validatingReaderNodeData.SetLineInfo(this.coreReader as IXmlLineInfo);
			if (this.coreReader.IsEmptyElement)
			{
				this.readAhead = true;
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x060009D2 RID: 2514 RVA: 0x000433DB File Offset: 0x000415DB
		public override bool EOF
		{
			get
			{
				return this.cacheState == XsdCachingReader.CachingReaderState.ReaderClosed && this.coreReader.EOF;
			}
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x000433F3 File Offset: 0x000415F3
		public override void Close()
		{
			this.coreReader.Close();
			this.cacheState = XsdCachingReader.CachingReaderState.ReaderClosed;
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x060009D4 RID: 2516 RVA: 0x00043407 File Offset: 0x00041607
		public override ReadState ReadState
		{
			get
			{
				return this.coreReader.ReadState;
			}
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x00043414 File Offset: 0x00041614
		public override void Skip()
		{
			XmlNodeType nodeType = this.cachedNode.NodeType;
			if (nodeType != XmlNodeType.Element)
			{
				if (nodeType != XmlNodeType.Attribute)
				{
					this.Read();
					return;
				}
				this.MoveToElement();
			}
			if (this.coreReader.NodeType != XmlNodeType.EndElement && !this.readAhead)
			{
				int num = this.coreReader.Depth - 1;
				while (this.coreReader.Read() && this.coreReader.Depth > num)
				{
				}
			}
			this.coreReader.Read();
			this.cacheState = XsdCachingReader.CachingReaderState.ReaderClosed;
			this.cacheHandler(this);
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x060009D6 RID: 2518 RVA: 0x000434A7 File Offset: 0x000416A7
		public override XmlNameTable NameTable
		{
			get
			{
				return this.coreReaderNameTable;
			}
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x000434AF File Offset: 0x000416AF
		public override string LookupNamespace(string prefix)
		{
			return this.coreReader.LookupNamespace(prefix);
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x000434BD File Offset: 0x000416BD
		public override void ResolveEntity()
		{
			throw new InvalidOperationException();
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x000434C4 File Offset: 0x000416C4
		public override bool ReadAttributeValue()
		{
			if (this.cachedNode.NodeType != XmlNodeType.Attribute)
			{
				return false;
			}
			this.cachedNode = this.CreateDummyTextNode(this.cachedNode.RawValue, this.cachedNode.Depth + 1);
			return true;
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x0000C89B File Offset: 0x0000AA9B
		bool IXmlLineInfo.HasLineInfo()
		{
			return true;
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x060009DB RID: 2523 RVA: 0x000434FB File Offset: 0x000416FB
		int IXmlLineInfo.LineNumber
		{
			get
			{
				return this.cachedNode.LineNumber;
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x060009DC RID: 2524 RVA: 0x00043508 File Offset: 0x00041708
		int IXmlLineInfo.LinePosition
		{
			get
			{
				return this.cachedNode.LinePosition;
			}
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x00043515 File Offset: 0x00041715
		internal void SetToReplayMode()
		{
			this.cacheState = XsdCachingReader.CachingReaderState.Replay;
			this.currentContentIndex = 0;
			this.currentAttrIndex = -1;
			this.Read();
		}

		// Token: 0x060009DE RID: 2526 RVA: 0x00043533 File Offset: 0x00041733
		internal XmlReader GetCoreReader()
		{
			return this.coreReader;
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x0004353B File Offset: 0x0004173B
		internal IXmlLineInfo GetLineInfo()
		{
			return this.lineInfo;
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x00043543 File Offset: 0x00041743
		private void ClearAttributesInfo()
		{
			this.attributeCount = 0;
			this.currentAttrIndex = -1;
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x00043554 File Offset: 0x00041754
		private ValidatingReaderNodeData AddAttribute(int attIndex)
		{
			ValidatingReaderNodeData validatingReaderNodeData = this.attributeEvents[attIndex];
			if (validatingReaderNodeData != null)
			{
				validatingReaderNodeData.Clear(XmlNodeType.Attribute);
				return validatingReaderNodeData;
			}
			if (attIndex >= this.attributeEvents.Length - 1)
			{
				ValidatingReaderNodeData[] destinationArray = new ValidatingReaderNodeData[this.attributeEvents.Length * 2];
				Array.Copy(this.attributeEvents, 0, destinationArray, 0, this.attributeEvents.Length);
				this.attributeEvents = destinationArray;
			}
			validatingReaderNodeData = this.attributeEvents[attIndex];
			if (validatingReaderNodeData == null)
			{
				validatingReaderNodeData = new ValidatingReaderNodeData(XmlNodeType.Attribute);
				this.attributeEvents[attIndex] = validatingReaderNodeData;
			}
			return validatingReaderNodeData;
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x000435D0 File Offset: 0x000417D0
		private ValidatingReaderNodeData AddContent(XmlNodeType nodeType)
		{
			ValidatingReaderNodeData validatingReaderNodeData = this.contentEvents[this.contentIndex];
			if (validatingReaderNodeData != null)
			{
				validatingReaderNodeData.Clear(nodeType);
				this.contentIndex++;
				return validatingReaderNodeData;
			}
			if (this.contentIndex >= this.contentEvents.Length - 1)
			{
				ValidatingReaderNodeData[] destinationArray = new ValidatingReaderNodeData[this.contentEvents.Length * 2];
				Array.Copy(this.contentEvents, 0, destinationArray, 0, this.contentEvents.Length);
				this.contentEvents = destinationArray;
			}
			validatingReaderNodeData = this.contentEvents[this.contentIndex];
			if (validatingReaderNodeData == null)
			{
				validatingReaderNodeData = new ValidatingReaderNodeData(nodeType);
				this.contentEvents[this.contentIndex] = validatingReaderNodeData;
			}
			this.contentIndex++;
			return validatingReaderNodeData;
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x0004367C File Offset: 0x0004187C
		private void RecordAttributes()
		{
			this.attributeCount = this.coreReader.AttributeCount;
			if (this.coreReader.MoveToFirstAttribute())
			{
				int num = 0;
				do
				{
					ValidatingReaderNodeData validatingReaderNodeData = this.AddAttribute(num);
					validatingReaderNodeData.SetItemData(this.coreReader.LocalName, this.coreReader.Prefix, this.coreReader.NamespaceURI, this.coreReader.Depth);
					validatingReaderNodeData.SetLineInfo(this.lineInfo);
					validatingReaderNodeData.RawValue = this.coreReader.Value;
					num++;
				}
				while (this.coreReader.MoveToNextAttribute());
				this.coreReader.MoveToElement();
			}
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x0004371C File Offset: 0x0004191C
		private int GetAttributeIndexWithoutPrefix(string name)
		{
			name = this.coreReaderNameTable.Get(name);
			if (name == null)
			{
				return -1;
			}
			for (int i = 0; i < this.attributeCount; i++)
			{
				ValidatingReaderNodeData validatingReaderNodeData = this.attributeEvents[i];
				if (Ref.Equal(validatingReaderNodeData.LocalName, name) && validatingReaderNodeData.Prefix.Length == 0)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x060009E5 RID: 2533 RVA: 0x00043774 File Offset: 0x00041974
		private int GetAttributeIndexWithPrefix(string name)
		{
			name = this.coreReaderNameTable.Get(name);
			if (name == null)
			{
				return -1;
			}
			for (int i = 0; i < this.attributeCount; i++)
			{
				if (Ref.Equal(this.attributeEvents[i].GetAtomizedNameWPrefix(this.coreReaderNameTable), name))
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x060009E6 RID: 2534 RVA: 0x000437C3 File Offset: 0x000419C3
		private ValidatingReaderNodeData CreateDummyTextNode(string attributeValue, int depth)
		{
			if (this.textNode == null)
			{
				this.textNode = new ValidatingReaderNodeData(XmlNodeType.Text);
			}
			this.textNode.Depth = depth;
			this.textNode.RawValue = attributeValue;
			return this.textNode;
		}

		// Token: 0x060009E7 RID: 2535 RVA: 0x000437F7 File Offset: 0x000419F7
		public override Task<string> GetValueAsync()
		{
			if (this.returnOriginalStringValues)
			{
				return Task.FromResult<string>(this.cachedNode.OriginalStringValue);
			}
			return Task.FromResult<string>(this.cachedNode.RawValue);
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x00043824 File Offset: 0x00041A24
		public override Task<bool> ReadAsync()
		{
			XsdCachingReader.<ReadAsync>d__100 <ReadAsync>d__;
			<ReadAsync>d__.<>t__builder = AsyncTaskMethodBuilder<bool>.Create();
			<ReadAsync>d__.<>4__this = this;
			<ReadAsync>d__.<>1__state = -1;
			<ReadAsync>d__.<>t__builder.Start<XsdCachingReader.<ReadAsync>d__100>(ref <ReadAsync>d__);
			return <ReadAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060009E9 RID: 2537 RVA: 0x00043867 File Offset: 0x00041A67
		internal Task SetToReplayModeAsync()
		{
			this.cacheState = XsdCachingReader.CachingReaderState.Replay;
			this.currentContentIndex = 0;
			this.currentAttrIndex = -1;
			return this.ReadAsync();
		}

		// Token: 0x040007F0 RID: 2032
		private XmlReader coreReader;

		// Token: 0x040007F1 RID: 2033
		private XmlNameTable coreReaderNameTable;

		// Token: 0x040007F2 RID: 2034
		private ValidatingReaderNodeData[] contentEvents;

		// Token: 0x040007F3 RID: 2035
		private ValidatingReaderNodeData[] attributeEvents;

		// Token: 0x040007F4 RID: 2036
		private ValidatingReaderNodeData cachedNode;

		// Token: 0x040007F5 RID: 2037
		private XsdCachingReader.CachingReaderState cacheState;

		// Token: 0x040007F6 RID: 2038
		private int contentIndex;

		// Token: 0x040007F7 RID: 2039
		private int attributeCount;

		// Token: 0x040007F8 RID: 2040
		private bool returnOriginalStringValues;

		// Token: 0x040007F9 RID: 2041
		private CachingEventHandler cacheHandler;

		// Token: 0x040007FA RID: 2042
		private int currentAttrIndex;

		// Token: 0x040007FB RID: 2043
		private int currentContentIndex;

		// Token: 0x040007FC RID: 2044
		private bool readAhead;

		// Token: 0x040007FD RID: 2045
		private IXmlLineInfo lineInfo;

		// Token: 0x040007FE RID: 2046
		private ValidatingReaderNodeData textNode;

		// Token: 0x02000128 RID: 296
		private enum CachingReaderState
		{
			// Token: 0x04000800 RID: 2048
			None,
			// Token: 0x04000801 RID: 2049
			Init,
			// Token: 0x04000802 RID: 2050
			Record,
			// Token: 0x04000803 RID: 2051
			Replay,
			// Token: 0x04000804 RID: 2052
			ReaderClosed,
			// Token: 0x04000805 RID: 2053
			Error
		}
	}
}
