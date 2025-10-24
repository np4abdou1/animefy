using System;
using System.Reflection;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace System.Xml
{
	// Token: 0x02000048 RID: 72
	[DefaultMember("Item")]
	internal class XmlAsyncCheckReader : XmlReader
	{
		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000220 RID: 544 RVA: 0x0000B039 File Offset: 0x00009239
		internal XmlReader CoreReader
		{
			get
			{
				return this.coreReader;
			}
		}

		// Token: 0x06000221 RID: 545 RVA: 0x0000B044 File Offset: 0x00009244
		public static XmlAsyncCheckReader CreateAsyncCheckWrapper(XmlReader reader)
		{
			if (reader is IXmlLineInfo)
			{
				if (!(reader is IXmlNamespaceResolver))
				{
					return new XmlAsyncCheckReaderWithLineInfo(reader);
				}
				if (reader is IXmlSchemaInfo)
				{
					return new XmlAsyncCheckReaderWithLineInfoNSSchema(reader);
				}
				return new XmlAsyncCheckReaderWithLineInfoNS(reader);
			}
			else
			{
				if (reader is IXmlNamespaceResolver)
				{
					return new XmlAsyncCheckReaderWithNS(reader);
				}
				return new XmlAsyncCheckReader(reader);
			}
		}

		// Token: 0x06000222 RID: 546 RVA: 0x0000B093 File Offset: 0x00009293
		public XmlAsyncCheckReader(XmlReader reader)
		{
			this.coreReader = reader;
		}

		// Token: 0x06000223 RID: 547 RVA: 0x0000B0AD File Offset: 0x000092AD
		private void CheckAsync()
		{
			if (!this.lastTask.IsCompleted)
			{
				throw new InvalidOperationException(Res.GetString("An asynchronous operation is already in progress."));
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000224 RID: 548 RVA: 0x0000B0CC File Offset: 0x000092CC
		public override XmlReaderSettings Settings
		{
			get
			{
				XmlReaderSettings xmlReaderSettings = this.coreReader.Settings;
				if (xmlReaderSettings != null)
				{
					xmlReaderSettings = xmlReaderSettings.Clone();
				}
				else
				{
					xmlReaderSettings = new XmlReaderSettings();
				}
				xmlReaderSettings.Async = true;
				xmlReaderSettings.ReadOnly = true;
				return xmlReaderSettings;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000225 RID: 549 RVA: 0x0000B106 File Offset: 0x00009306
		public override XmlNodeType NodeType
		{
			get
			{
				this.CheckAsync();
				return this.coreReader.NodeType;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000226 RID: 550 RVA: 0x0000B119 File Offset: 0x00009319
		public override string Name
		{
			get
			{
				this.CheckAsync();
				return this.coreReader.Name;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000227 RID: 551 RVA: 0x0000B12C File Offset: 0x0000932C
		public override string LocalName
		{
			get
			{
				this.CheckAsync();
				return this.coreReader.LocalName;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000228 RID: 552 RVA: 0x0000B13F File Offset: 0x0000933F
		public override string NamespaceURI
		{
			get
			{
				this.CheckAsync();
				return this.coreReader.NamespaceURI;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000229 RID: 553 RVA: 0x0000B152 File Offset: 0x00009352
		public override string Prefix
		{
			get
			{
				this.CheckAsync();
				return this.coreReader.Prefix;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600022A RID: 554 RVA: 0x0000B165 File Offset: 0x00009365
		public override string Value
		{
			get
			{
				this.CheckAsync();
				return this.coreReader.Value;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600022B RID: 555 RVA: 0x0000B178 File Offset: 0x00009378
		public override int Depth
		{
			get
			{
				this.CheckAsync();
				return this.coreReader.Depth;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600022C RID: 556 RVA: 0x0000B18B File Offset: 0x0000938B
		public override string BaseURI
		{
			get
			{
				this.CheckAsync();
				return this.coreReader.BaseURI;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600022D RID: 557 RVA: 0x0000B19E File Offset: 0x0000939E
		public override bool IsEmptyElement
		{
			get
			{
				this.CheckAsync();
				return this.coreReader.IsEmptyElement;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600022E RID: 558 RVA: 0x0000B1B1 File Offset: 0x000093B1
		public override bool IsDefault
		{
			get
			{
				this.CheckAsync();
				return this.coreReader.IsDefault;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x0600022F RID: 559 RVA: 0x0000B1C4 File Offset: 0x000093C4
		public override char QuoteChar
		{
			get
			{
				this.CheckAsync();
				return this.coreReader.QuoteChar;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000230 RID: 560 RVA: 0x0000B1D7 File Offset: 0x000093D7
		public override XmlSpace XmlSpace
		{
			get
			{
				this.CheckAsync();
				return this.coreReader.XmlSpace;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000231 RID: 561 RVA: 0x0000B1EA File Offset: 0x000093EA
		public override string XmlLang
		{
			get
			{
				this.CheckAsync();
				return this.coreReader.XmlLang;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000232 RID: 562 RVA: 0x0000B1FD File Offset: 0x000093FD
		public override IXmlSchemaInfo SchemaInfo
		{
			get
			{
				this.CheckAsync();
				return this.coreReader.SchemaInfo;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000233 RID: 563 RVA: 0x0000B210 File Offset: 0x00009410
		public override Type ValueType
		{
			get
			{
				this.CheckAsync();
				return this.coreReader.ValueType;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000234 RID: 564 RVA: 0x0000B223 File Offset: 0x00009423
		public override int AttributeCount
		{
			get
			{
				this.CheckAsync();
				return this.coreReader.AttributeCount;
			}
		}

		// Token: 0x06000235 RID: 565 RVA: 0x0000B236 File Offset: 0x00009436
		public override string GetAttribute(string name)
		{
			this.CheckAsync();
			return this.coreReader.GetAttribute(name);
		}

		// Token: 0x06000236 RID: 566 RVA: 0x0000B24A File Offset: 0x0000944A
		public override string GetAttribute(string name, string namespaceURI)
		{
			this.CheckAsync();
			return this.coreReader.GetAttribute(name, namespaceURI);
		}

		// Token: 0x06000237 RID: 567 RVA: 0x0000B25F File Offset: 0x0000945F
		public override string GetAttribute(int i)
		{
			this.CheckAsync();
			return this.coreReader.GetAttribute(i);
		}

		// Token: 0x06000238 RID: 568 RVA: 0x0000B273 File Offset: 0x00009473
		public override bool MoveToAttribute(string name)
		{
			this.CheckAsync();
			return this.coreReader.MoveToAttribute(name);
		}

		// Token: 0x06000239 RID: 569 RVA: 0x0000B287 File Offset: 0x00009487
		public override void MoveToAttribute(int i)
		{
			this.CheckAsync();
			this.coreReader.MoveToAttribute(i);
		}

		// Token: 0x0600023A RID: 570 RVA: 0x0000B29B File Offset: 0x0000949B
		public override bool MoveToFirstAttribute()
		{
			this.CheckAsync();
			return this.coreReader.MoveToFirstAttribute();
		}

		// Token: 0x0600023B RID: 571 RVA: 0x0000B2AE File Offset: 0x000094AE
		public override bool MoveToNextAttribute()
		{
			this.CheckAsync();
			return this.coreReader.MoveToNextAttribute();
		}

		// Token: 0x0600023C RID: 572 RVA: 0x0000B2C1 File Offset: 0x000094C1
		public override bool MoveToElement()
		{
			this.CheckAsync();
			return this.coreReader.MoveToElement();
		}

		// Token: 0x0600023D RID: 573 RVA: 0x0000B2D4 File Offset: 0x000094D4
		public override bool ReadAttributeValue()
		{
			this.CheckAsync();
			return this.coreReader.ReadAttributeValue();
		}

		// Token: 0x0600023E RID: 574 RVA: 0x0000B2E7 File Offset: 0x000094E7
		public override bool Read()
		{
			this.CheckAsync();
			return this.coreReader.Read();
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600023F RID: 575 RVA: 0x0000B2FA File Offset: 0x000094FA
		public override bool EOF
		{
			get
			{
				this.CheckAsync();
				return this.coreReader.EOF;
			}
		}

		// Token: 0x06000240 RID: 576 RVA: 0x0000B30D File Offset: 0x0000950D
		public override void Close()
		{
			this.CheckAsync();
			this.coreReader.Close();
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000241 RID: 577 RVA: 0x0000B320 File Offset: 0x00009520
		public override ReadState ReadState
		{
			get
			{
				this.CheckAsync();
				return this.coreReader.ReadState;
			}
		}

		// Token: 0x06000242 RID: 578 RVA: 0x0000B333 File Offset: 0x00009533
		public override void Skip()
		{
			this.CheckAsync();
			this.coreReader.Skip();
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000243 RID: 579 RVA: 0x0000B346 File Offset: 0x00009546
		public override XmlNameTable NameTable
		{
			get
			{
				this.CheckAsync();
				return this.coreReader.NameTable;
			}
		}

		// Token: 0x06000244 RID: 580 RVA: 0x0000B359 File Offset: 0x00009559
		public override string LookupNamespace(string prefix)
		{
			this.CheckAsync();
			return this.coreReader.LookupNamespace(prefix);
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000245 RID: 581 RVA: 0x0000B36D File Offset: 0x0000956D
		public override bool CanResolveEntity
		{
			get
			{
				this.CheckAsync();
				return this.coreReader.CanResolveEntity;
			}
		}

		// Token: 0x06000246 RID: 582 RVA: 0x0000B380 File Offset: 0x00009580
		public override void ResolveEntity()
		{
			this.CheckAsync();
			this.coreReader.ResolveEntity();
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000247 RID: 583 RVA: 0x0000B393 File Offset: 0x00009593
		public override bool CanReadValueChunk
		{
			get
			{
				this.CheckAsync();
				return this.coreReader.CanReadValueChunk;
			}
		}

		// Token: 0x06000248 RID: 584 RVA: 0x0000B3A6 File Offset: 0x000095A6
		public override int ReadValueChunk(char[] buffer, int index, int count)
		{
			this.CheckAsync();
			return this.coreReader.ReadValueChunk(buffer, index, count);
		}

		// Token: 0x06000249 RID: 585 RVA: 0x0000B3BC File Offset: 0x000095BC
		public override string ReadString()
		{
			this.CheckAsync();
			return this.coreReader.ReadString();
		}

		// Token: 0x0600024A RID: 586 RVA: 0x0000B3CF File Offset: 0x000095CF
		public override XmlNodeType MoveToContent()
		{
			this.CheckAsync();
			return this.coreReader.MoveToContent();
		}

		// Token: 0x0600024B RID: 587 RVA: 0x0000B3E2 File Offset: 0x000095E2
		public override void ReadStartElement()
		{
			this.CheckAsync();
			this.coreReader.ReadStartElement();
		}

		// Token: 0x0600024C RID: 588 RVA: 0x0000B3F5 File Offset: 0x000095F5
		public override string ReadElementString()
		{
			this.CheckAsync();
			return this.coreReader.ReadElementString();
		}

		// Token: 0x0600024D RID: 589 RVA: 0x0000B408 File Offset: 0x00009608
		public override void ReadEndElement()
		{
			this.CheckAsync();
			this.coreReader.ReadEndElement();
		}

		// Token: 0x0600024E RID: 590 RVA: 0x0000B41B File Offset: 0x0000961B
		public override bool IsStartElement(string localname, string ns)
		{
			this.CheckAsync();
			return this.coreReader.IsStartElement(localname, ns);
		}

		// Token: 0x0600024F RID: 591 RVA: 0x0000B430 File Offset: 0x00009630
		public override string ReadInnerXml()
		{
			this.CheckAsync();
			return this.coreReader.ReadInnerXml();
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000250 RID: 592 RVA: 0x0000B443 File Offset: 0x00009643
		public override bool HasAttributes
		{
			get
			{
				this.CheckAsync();
				return this.coreReader.HasAttributes;
			}
		}

		// Token: 0x06000251 RID: 593 RVA: 0x0000B456 File Offset: 0x00009656
		protected override void Dispose(bool disposing)
		{
			this.CheckAsync();
			this.coreReader.Dispose();
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000252 RID: 594 RVA: 0x0000B469 File Offset: 0x00009669
		internal override XmlNamespaceManager NamespaceManager
		{
			get
			{
				this.CheckAsync();
				return this.coreReader.NamespaceManager;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000253 RID: 595 RVA: 0x0000B47C File Offset: 0x0000967C
		internal override IDtdInfo DtdInfo
		{
			get
			{
				this.CheckAsync();
				return this.coreReader.DtdInfo;
			}
		}

		// Token: 0x06000254 RID: 596 RVA: 0x0000B490 File Offset: 0x00009690
		public override Task<string> GetValueAsync()
		{
			this.CheckAsync();
			Task<string> valueAsync = this.coreReader.GetValueAsync();
			this.lastTask = valueAsync;
			return valueAsync;
		}

		// Token: 0x06000255 RID: 597 RVA: 0x0000B4B8 File Offset: 0x000096B8
		public override Task<bool> ReadAsync()
		{
			this.CheckAsync();
			Task<bool> result = this.coreReader.ReadAsync();
			this.lastTask = result;
			return result;
		}

		// Token: 0x06000256 RID: 598 RVA: 0x0000B4E0 File Offset: 0x000096E0
		public override Task<XmlNodeType> MoveToContentAsync()
		{
			this.CheckAsync();
			Task<XmlNodeType> result = this.coreReader.MoveToContentAsync();
			this.lastTask = result;
			return result;
		}

		// Token: 0x04000174 RID: 372
		private readonly XmlReader coreReader;

		// Token: 0x04000175 RID: 373
		private Task lastTask = AsyncHelper.DoneTask;
	}
}
