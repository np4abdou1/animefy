using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace System.Xml
{
	// Token: 0x02000014 RID: 20
	internal sealed class XmlSqlBinaryReader : XmlReader, IXmlNamespaceResolver
	{
		// Token: 0x06000060 RID: 96 RVA: 0x00003DDC File Offset: 0x00001FDC
		public XmlSqlBinaryReader(Stream stream, byte[] data, int len, string baseUri, bool closeInput, XmlReaderSettings settings)
		{
			this.unicode = Encoding.Unicode;
			this.xmlCharType = XmlCharType.Instance;
			this.xnt = settings.NameTable;
			if (this.xnt == null)
			{
				this.xnt = new NameTable();
				this.xntFromSettings = false;
			}
			else
			{
				this.xntFromSettings = true;
			}
			this.xml = this.xnt.Add("xml");
			this.xmlns = this.xnt.Add("xmlns");
			this.nsxmlns = this.xnt.Add("http://www.w3.org/2000/xmlns/");
			this.baseUri = baseUri;
			this.state = XmlSqlBinaryReader.ScanState.Init;
			this.nodetype = XmlNodeType.None;
			this.token = BinXmlToken.Error;
			this.elementStack = new XmlSqlBinaryReader.ElemInfo[16];
			this.attributes = new XmlSqlBinaryReader.AttrInfo[8];
			this.attrHashTbl = new int[8];
			this.symbolTables.Init();
			this.qnameOther.Clear();
			this.qnameElement.Clear();
			this.xmlspacePreserve = false;
			this.hasher = new SecureStringHasher();
			this.namespaces = new Dictionary<string, XmlSqlBinaryReader.NamespaceDecl>(this.hasher);
			this.AddInitNamespace(string.Empty, string.Empty);
			this.AddInitNamespace(this.xml, this.xnt.Add("http://www.w3.org/XML/1998/namespace"));
			this.AddInitNamespace(this.xmlns, this.nsxmlns);
			this.valueType = XmlSqlBinaryReader.TypeOfString;
			this.inStrm = stream;
			if (data != null)
			{
				this.data = data;
				this.end = len;
				this.pos = 2;
				this.sniffed = true;
			}
			else
			{
				this.data = new byte[4096];
				this.end = stream.Read(this.data, 0, 4096);
				this.pos = 0;
				this.sniffed = false;
			}
			this.mark = -1;
			this.eof = (this.end == 0);
			this.offset = 0L;
			this.closeInput = closeInput;
			switch (settings.ConformanceLevel)
			{
			case ConformanceLevel.Auto:
				this.docState = 0;
				break;
			case ConformanceLevel.Fragment:
				this.docState = 9;
				break;
			case ConformanceLevel.Document:
				this.docState = 1;
				break;
			}
			this.checkCharacters = settings.CheckCharacters;
			this.dtdProcessing = settings.DtdProcessing;
			this.ignoreWhitespace = settings.IgnoreWhitespace;
			this.ignorePIs = settings.IgnoreProcessingInstructions;
			this.ignoreComments = settings.IgnoreComments;
			if (XmlSqlBinaryReader.TokenTypeMap == null)
			{
				this.GenerateTokenTypeMap();
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00004050 File Offset: 0x00002250
		public override XmlReaderSettings Settings
		{
			get
			{
				XmlReaderSettings xmlReaderSettings = new XmlReaderSettings();
				if (this.xntFromSettings)
				{
					xmlReaderSettings.NameTable = this.xnt;
				}
				int num = this.docState;
				if (num != 0)
				{
					if (num != 9)
					{
						xmlReaderSettings.ConformanceLevel = ConformanceLevel.Document;
					}
					else
					{
						xmlReaderSettings.ConformanceLevel = ConformanceLevel.Fragment;
					}
				}
				else
				{
					xmlReaderSettings.ConformanceLevel = ConformanceLevel.Auto;
				}
				xmlReaderSettings.CheckCharacters = this.checkCharacters;
				xmlReaderSettings.IgnoreWhitespace = this.ignoreWhitespace;
				xmlReaderSettings.IgnoreProcessingInstructions = this.ignorePIs;
				xmlReaderSettings.IgnoreComments = this.ignoreComments;
				xmlReaderSettings.DtdProcessing = this.dtdProcessing;
				xmlReaderSettings.CloseInput = this.closeInput;
				xmlReaderSettings.ReadOnly = true;
				return xmlReaderSettings;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000062 RID: 98 RVA: 0x000040F1 File Offset: 0x000022F1
		public override XmlNodeType NodeType
		{
			get
			{
				return this.nodetype;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000063 RID: 99 RVA: 0x000040F9 File Offset: 0x000022F9
		public override string LocalName
		{
			get
			{
				return this.qnameOther.localname;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000064 RID: 100 RVA: 0x00004106 File Offset: 0x00002306
		public override string NamespaceURI
		{
			get
			{
				return this.qnameOther.namespaceUri;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00004113 File Offset: 0x00002313
		public override string Prefix
		{
			get
			{
				return this.qnameOther.prefix;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000066 RID: 102 RVA: 0x00004120 File Offset: 0x00002320
		public override string Value
		{
			get
			{
				if (this.stringValue != null)
				{
					return this.stringValue;
				}
				switch (this.state)
				{
				case XmlSqlBinaryReader.ScanState.Doc:
					switch (this.nodetype)
					{
					case XmlNodeType.Text:
					case XmlNodeType.Whitespace:
					case XmlNodeType.SignificantWhitespace:
						return this.stringValue = this.ValueAsString(this.token);
					case XmlNodeType.CDATA:
						return this.stringValue = this.CDATAValue();
					case XmlNodeType.ProcessingInstruction:
					case XmlNodeType.Comment:
					case XmlNodeType.DocumentType:
						return this.stringValue = this.GetString(this.tokDataPos, this.tokLen);
					case XmlNodeType.XmlDeclaration:
						return this.stringValue = this.XmlDeclValue();
					}
					break;
				case XmlSqlBinaryReader.ScanState.XmlText:
					return this.textXmlReader.Value;
				case XmlSqlBinaryReader.ScanState.Attr:
				case XmlSqlBinaryReader.ScanState.AttrValPseudoValue:
					return this.stringValue = this.GetAttributeText(this.attrIndex - 1);
				case XmlSqlBinaryReader.ScanState.AttrVal:
					return this.stringValue = this.ValueAsString(this.token);
				}
				return string.Empty;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000067 RID: 103 RVA: 0x00004244 File Offset: 0x00002444
		public override int Depth
		{
			get
			{
				int num = 0;
				switch (this.state)
				{
				case XmlSqlBinaryReader.ScanState.Doc:
					if (this.nodetype == XmlNodeType.Element || this.nodetype == XmlNodeType.EndElement)
					{
						num = -1;
					}
					break;
				case XmlSqlBinaryReader.ScanState.XmlText:
					num = this.textXmlReader.Depth;
					break;
				case XmlSqlBinaryReader.ScanState.Attr:
					if (this.parentNodeType != XmlNodeType.Element)
					{
						num = 1;
					}
					break;
				case XmlSqlBinaryReader.ScanState.AttrVal:
				case XmlSqlBinaryReader.ScanState.AttrValPseudoValue:
					if (this.parentNodeType != XmlNodeType.Element)
					{
						num = 1;
					}
					num++;
					break;
				default:
					return 0;
				}
				return this.elemDepth + num;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000068 RID: 104 RVA: 0x000042C3 File Offset: 0x000024C3
		public override string BaseURI
		{
			get
			{
				return this.baseUri;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000069 RID: 105 RVA: 0x000042CC File Offset: 0x000024CC
		public override bool IsEmptyElement
		{
			get
			{
				XmlSqlBinaryReader.ScanState scanState = this.state;
				return scanState <= XmlSqlBinaryReader.ScanState.XmlText && this.isEmpty;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600006A RID: 106 RVA: 0x000042EC File Offset: 0x000024EC
		public override XmlSpace XmlSpace
		{
			get
			{
				if (XmlSqlBinaryReader.ScanState.XmlText != this.state)
				{
					for (int i = this.elemDepth; i >= 0; i--)
					{
						XmlSpace xmlSpace = this.elementStack[i].xmlSpace;
						if (xmlSpace != XmlSpace.None)
						{
							return xmlSpace;
						}
					}
					return XmlSpace.None;
				}
				return this.textXmlReader.XmlSpace;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600006B RID: 107 RVA: 0x00004338 File Offset: 0x00002538
		public override string XmlLang
		{
			get
			{
				if (XmlSqlBinaryReader.ScanState.XmlText != this.state)
				{
					for (int i = this.elemDepth; i >= 0; i--)
					{
						string xmlLang = this.elementStack[i].xmlLang;
						if (xmlLang != null)
						{
							return xmlLang;
						}
					}
					return string.Empty;
				}
				return this.textXmlReader.XmlLang;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600006C RID: 108 RVA: 0x00004387 File Offset: 0x00002587
		public override Type ValueType
		{
			get
			{
				return this.valueType;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600006D RID: 109 RVA: 0x00004390 File Offset: 0x00002590
		public override int AttributeCount
		{
			get
			{
				switch (this.state)
				{
				case XmlSqlBinaryReader.ScanState.Doc:
				case XmlSqlBinaryReader.ScanState.Attr:
				case XmlSqlBinaryReader.ScanState.AttrVal:
				case XmlSqlBinaryReader.ScanState.AttrValPseudoValue:
					return this.attrCount;
				case XmlSqlBinaryReader.ScanState.XmlText:
					return this.textXmlReader.AttributeCount;
				default:
					return 0;
				}
			}
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000043D4 File Offset: 0x000025D4
		public override string GetAttribute(string name, string ns)
		{
			if (XmlSqlBinaryReader.ScanState.XmlText == this.state)
			{
				return this.textXmlReader.GetAttribute(name, ns);
			}
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			if (ns == null)
			{
				ns = string.Empty;
			}
			int num = this.LocateAttribute(name, ns);
			if (-1 == num)
			{
				return null;
			}
			return this.GetAttribute(num);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00004428 File Offset: 0x00002628
		public override string GetAttribute(string name)
		{
			if (XmlSqlBinaryReader.ScanState.XmlText == this.state)
			{
				return this.textXmlReader.GetAttribute(name);
			}
			int num = this.LocateAttribute(name);
			if (-1 == num)
			{
				return null;
			}
			return this.GetAttribute(num);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00004460 File Offset: 0x00002660
		public override string GetAttribute(int i)
		{
			if (XmlSqlBinaryReader.ScanState.XmlText == this.state)
			{
				return this.textXmlReader.GetAttribute(i);
			}
			if (i < 0 || i >= this.attrCount)
			{
				throw new ArgumentOutOfRangeException("i");
			}
			return this.GetAttributeText(i);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00004498 File Offset: 0x00002698
		public override bool MoveToAttribute(string name)
		{
			if (XmlSqlBinaryReader.ScanState.XmlText == this.state)
			{
				return this.UpdateFromTextReader(this.textXmlReader.MoveToAttribute(name));
			}
			int num = this.LocateAttribute(name);
			if (-1 != num && this.state < XmlSqlBinaryReader.ScanState.Init)
			{
				this.PositionOnAttribute(num + 1);
				return true;
			}
			return false;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x000044E4 File Offset: 0x000026E4
		public override void MoveToAttribute(int i)
		{
			if (XmlSqlBinaryReader.ScanState.XmlText == this.state)
			{
				this.textXmlReader.MoveToAttribute(i);
				this.UpdateFromTextReader(true);
				return;
			}
			if (i < 0 || i >= this.attrCount)
			{
				throw new ArgumentOutOfRangeException("i");
			}
			this.PositionOnAttribute(i + 1);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00004530 File Offset: 0x00002730
		public override bool MoveToFirstAttribute()
		{
			if (XmlSqlBinaryReader.ScanState.XmlText == this.state)
			{
				return this.UpdateFromTextReader(this.textXmlReader.MoveToFirstAttribute());
			}
			if (this.attrCount == 0)
			{
				return false;
			}
			this.PositionOnAttribute(1);
			return true;
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00004560 File Offset: 0x00002760
		public override bool MoveToNextAttribute()
		{
			switch (this.state)
			{
			case XmlSqlBinaryReader.ScanState.Doc:
			case XmlSqlBinaryReader.ScanState.Attr:
			case XmlSqlBinaryReader.ScanState.AttrVal:
			case XmlSqlBinaryReader.ScanState.AttrValPseudoValue:
			{
				if (this.attrIndex >= this.attrCount)
				{
					return false;
				}
				int i = this.attrIndex + 1;
				this.attrIndex = i;
				this.PositionOnAttribute(i);
				return true;
			}
			case XmlSqlBinaryReader.ScanState.XmlText:
				return this.UpdateFromTextReader(this.textXmlReader.MoveToNextAttribute());
			default:
				return false;
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x000045CC File Offset: 0x000027CC
		public override bool MoveToElement()
		{
			XmlSqlBinaryReader.ScanState scanState = this.state;
			if (scanState == XmlSqlBinaryReader.ScanState.XmlText)
			{
				return this.UpdateFromTextReader(this.textXmlReader.MoveToElement());
			}
			if (scanState - XmlSqlBinaryReader.ScanState.Attr <= 2)
			{
				this.attrIndex = 0;
				this.qnameOther = this.qnameElement;
				if (XmlNodeType.Element == this.parentNodeType)
				{
					this.token = BinXmlToken.Element;
				}
				else if (XmlNodeType.XmlDeclaration == this.parentNodeType)
				{
					this.token = BinXmlToken.XmlDecl;
				}
				else if (XmlNodeType.DocumentType == this.parentNodeType)
				{
					this.token = BinXmlToken.DocType;
				}
				this.nodetype = this.parentNodeType;
				this.state = XmlSqlBinaryReader.ScanState.Doc;
				this.pos = this.posAfterAttrs;
				this.stringValue = null;
				return true;
			}
			return false;
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000076 RID: 118 RVA: 0x00004680 File Offset: 0x00002880
		public override bool EOF
		{
			get
			{
				return this.state == XmlSqlBinaryReader.ScanState.EOF;
			}
		}

		// Token: 0x06000077 RID: 119 RVA: 0x0000468C File Offset: 0x0000288C
		public override bool ReadAttributeValue()
		{
			this.stringValue = null;
			switch (this.state)
			{
			case XmlSqlBinaryReader.ScanState.XmlText:
				return this.UpdateFromTextReader(this.textXmlReader.ReadAttributeValue());
			case XmlSqlBinaryReader.ScanState.Attr:
				if (this.attributes[this.attrIndex - 1].val == null)
				{
					this.pos = this.attributes[this.attrIndex - 1].contentPos;
					BinXmlToken binXmlToken = this.RescanNextToken();
					if (BinXmlToken.Attr == binXmlToken || BinXmlToken.EndAttrs == binXmlToken)
					{
						return false;
					}
					this.token = binXmlToken;
					this.ReScanOverValue(binXmlToken);
					this.valueType = this.GetValueType(binXmlToken);
					this.state = XmlSqlBinaryReader.ScanState.AttrVal;
				}
				else
				{
					this.token = BinXmlToken.Error;
					this.valueType = XmlSqlBinaryReader.TypeOfString;
					this.state = XmlSqlBinaryReader.ScanState.AttrValPseudoValue;
				}
				this.qnameOther.Clear();
				this.nodetype = XmlNodeType.Text;
				return true;
			case XmlSqlBinaryReader.ScanState.AttrVal:
				return false;
			default:
				return false;
			}
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00004778 File Offset: 0x00002978
		public override void Close()
		{
			this.state = XmlSqlBinaryReader.ScanState.Closed;
			this.nodetype = XmlNodeType.None;
			this.token = BinXmlToken.Error;
			this.stringValue = null;
			if (this.textXmlReader != null)
			{
				this.textXmlReader.Close();
				this.textXmlReader = null;
			}
			if (this.inStrm != null && this.closeInput)
			{
				this.inStrm.Close();
			}
			this.inStrm = null;
			this.pos = (this.end = 0);
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000079 RID: 121 RVA: 0x000047ED File Offset: 0x000029ED
		public override XmlNameTable NameTable
		{
			get
			{
				return this.xnt;
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000047F8 File Offset: 0x000029F8
		public override string LookupNamespace(string prefix)
		{
			if (XmlSqlBinaryReader.ScanState.XmlText == this.state)
			{
				return this.textXmlReader.LookupNamespace(prefix);
			}
			XmlSqlBinaryReader.NamespaceDecl namespaceDecl;
			if (prefix != null && this.namespaces.TryGetValue(prefix, out namespaceDecl))
			{
				return namespaceDecl.uri;
			}
			return null;
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00004836 File Offset: 0x00002A36
		public override void ResolveEntity()
		{
			throw new NotSupportedException();
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600007C RID: 124 RVA: 0x0000483D File Offset: 0x00002A3D
		public override ReadState ReadState
		{
			get
			{
				return XmlSqlBinaryReader.ScanState2ReadState[(int)this.state];
			}
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0000484C File Offset: 0x00002A4C
		public override bool Read()
		{
			bool result;
			try
			{
				switch (this.state)
				{
				case XmlSqlBinaryReader.ScanState.Doc:
					break;
				case XmlSqlBinaryReader.ScanState.XmlText:
					if (this.textXmlReader.Read())
					{
						return this.UpdateFromTextReader(true);
					}
					this.state = XmlSqlBinaryReader.ScanState.Doc;
					this.nodetype = XmlNodeType.None;
					this.isEmpty = false;
					break;
				case XmlSqlBinaryReader.ScanState.Attr:
				case XmlSqlBinaryReader.ScanState.AttrVal:
				case XmlSqlBinaryReader.ScanState.AttrValPseudoValue:
					this.MoveToElement();
					break;
				case XmlSqlBinaryReader.ScanState.Init:
					return this.ReadInit(false);
				default:
					return false;
				}
				result = this.ReadDoc();
			}
			catch (OverflowException ex)
			{
				this.state = XmlSqlBinaryReader.ScanState.Error;
				throw new XmlException(ex.Message, ex);
			}
			catch
			{
				this.state = XmlSqlBinaryReader.ScanState.Error;
				throw;
			}
			return result;
		}

		// Token: 0x0600007E RID: 126 RVA: 0x0000490C File Offset: 0x00002B0C
		IDictionary<string, string> IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope)
		{
			if (XmlSqlBinaryReader.ScanState.XmlText == this.state)
			{
				return ((IXmlNamespaceResolver)this.textXmlReader).GetNamespacesInScope(scope);
			}
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			if (XmlNamespaceScope.Local == scope)
			{
				if (this.elemDepth > 0)
				{
					for (XmlSqlBinaryReader.NamespaceDecl namespaceDecl = this.elementStack[this.elemDepth].nsdecls; namespaceDecl != null; namespaceDecl = namespaceDecl.scopeLink)
					{
						dictionary.Add(namespaceDecl.prefix, namespaceDecl.uri);
					}
				}
			}
			else
			{
				foreach (XmlSqlBinaryReader.NamespaceDecl namespaceDecl2 in this.namespaces.Values)
				{
					if ((namespaceDecl2.scope != -1 || (scope == XmlNamespaceScope.All && "xml" == namespaceDecl2.prefix)) && (namespaceDecl2.prefix.Length > 0 || namespaceDecl2.uri.Length > 0))
					{
						dictionary.Add(namespaceDecl2.prefix, namespaceDecl2.uri);
					}
				}
			}
			return dictionary;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00004A18 File Offset: 0x00002C18
		string IXmlNamespaceResolver.LookupPrefix(string namespaceName)
		{
			if (XmlSqlBinaryReader.ScanState.XmlText == this.state)
			{
				return ((IXmlNamespaceResolver)this.textXmlReader).LookupPrefix(namespaceName);
			}
			if (namespaceName == null)
			{
				return null;
			}
			namespaceName = this.xnt.Get(namespaceName);
			if (namespaceName == null)
			{
				return null;
			}
			for (int i = this.elemDepth; i >= 0; i--)
			{
				for (XmlSqlBinaryReader.NamespaceDecl namespaceDecl = this.elementStack[i].nsdecls; namespaceDecl != null; namespaceDecl = namespaceDecl.scopeLink)
				{
					if (namespaceDecl.uri == namespaceName)
					{
						return namespaceDecl.prefix;
					}
				}
			}
			return null;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00004A98 File Offset: 0x00002C98
		private void VerifyVersion(int requiredVersion, BinXmlToken token)
		{
			if ((int)this.version < requiredVersion)
			{
				throw this.ThrowUnexpectedToken(token);
			}
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00004AAC File Offset: 0x00002CAC
		private void AddInitNamespace(string prefix, string uri)
		{
			XmlSqlBinaryReader.NamespaceDecl namespaceDecl = new XmlSqlBinaryReader.NamespaceDecl(prefix, uri, this.elementStack[0].nsdecls, null, -1, true);
			this.elementStack[0].nsdecls = namespaceDecl;
			this.namespaces.Add(prefix, namespaceDecl);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00004AF4 File Offset: 0x00002CF4
		private void AddName()
		{
			string array = this.ParseText();
			int symCount = this.symbolTables.symCount;
			this.symbolTables.symCount = symCount + 1;
			int num = symCount;
			string[] array2 = this.symbolTables.symtable;
			if (num == array2.Length)
			{
				string[] array3 = new string[checked(num * 2)];
				Array.Copy(array2, 0, array3, 0, num);
				array2 = (this.symbolTables.symtable = array3);
			}
			array2[num] = this.xnt.Add(array);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00004B64 File Offset: 0x00002D64
		private void AddQName()
		{
			int num = this.ReadNameRef();
			int num2 = this.ReadNameRef();
			int num3 = this.ReadNameRef();
			int qnameCount = this.symbolTables.qnameCount;
			this.symbolTables.qnameCount = qnameCount + 1;
			int num4 = qnameCount;
			XmlSqlBinaryReader.QName[] array = this.symbolTables.qnametable;
			if (num4 == array.Length)
			{
				XmlSqlBinaryReader.QName[] array2 = new XmlSqlBinaryReader.QName[checked(num4 * 2)];
				Array.Copy(array, 0, array2, 0, num4);
				array = (this.symbolTables.qnametable = array2);
			}
			string[] symtable = this.symbolTables.symtable;
			string text = symtable[num2];
			string lname;
			string nsUri;
			if (num3 == 0)
			{
				if (num2 == 0 && num == 0)
				{
					return;
				}
				if (text.StartsWith("xmlns", StringComparison.Ordinal))
				{
					if (5 < text.Length)
					{
						if (6 == text.Length || ':' != text[5])
						{
							goto IL_106;
						}
						lname = this.xnt.Add(text.Substring(6));
						text = this.xmlns;
					}
					else
					{
						lname = text;
						text = string.Empty;
					}
					nsUri = this.nsxmlns;
					goto IL_F2;
				}
				IL_106:
				throw new XmlException("Invalid namespace declaration.", null);
			}
			else
			{
				lname = symtable[num3];
				nsUri = symtable[num];
			}
			IL_F2:
			array[num4].Set(text, lname, nsUri);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00004C84 File Offset: 0x00002E84
		private void NameFlush()
		{
			this.symbolTables.symCount = (this.symbolTables.qnameCount = 1);
			Array.Clear(this.symbolTables.symtable, 1, this.symbolTables.symtable.Length - 1);
			Array.Clear(this.symbolTables.qnametable, 0, this.symbolTables.qnametable.Length);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00004CEC File Offset: 0x00002EEC
		private void SkipExtn()
		{
			int num = this.ParseMB32();
			checked
			{
				this.pos += num;
				this.Fill(-1);
			}
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00004D18 File Offset: 0x00002F18
		private int ReadQNameRef()
		{
			int num = this.ParseMB32();
			if (num < 0 || num >= this.symbolTables.qnameCount)
			{
				throw new XmlException("Invalid QName ID.", string.Empty);
			}
			return num;
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00004D50 File Offset: 0x00002F50
		private int ReadNameRef()
		{
			int num = this.ParseMB32();
			if (num < 0 || num >= this.symbolTables.symCount)
			{
				throw new XmlException("Invalid QName ID.", string.Empty);
			}
			return num;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00004D88 File Offset: 0x00002F88
		private bool FillAllowEOF()
		{
			if (this.eof)
			{
				return false;
			}
			byte[] array = this.data;
			int num = this.pos;
			int num2 = this.mark;
			int num3 = this.end;
			if (num2 == -1)
			{
				num2 = num;
			}
			if (num2 >= 0 && num2 < num3)
			{
				int num4 = num3 - num2;
				if (num4 > 7 * (array.Length / 8))
				{
					byte[] destinationArray = new byte[checked(array.Length * 2)];
					Array.Copy(array, num2, destinationArray, 0, num4);
					array = (this.data = destinationArray);
				}
				else
				{
					Array.Copy(array, num2, array, 0, num4);
				}
				num -= num2;
				num3 -= num2;
				this.tokDataPos -= num2;
				for (int i = 0; i < this.attrCount; i++)
				{
					this.attributes[i].AdjustPosition(-num2);
				}
				this.pos = num;
				this.mark = 0;
				this.offset += (long)num2;
			}
			else
			{
				this.pos -= num3;
				this.mark -= num3;
				this.offset += (long)num3;
				this.tokDataPos -= num3;
				num3 = 0;
			}
			int count = array.Length - num3;
			int num5 = this.inStrm.Read(array, num3, count);
			this.end = num3 + num5;
			this.eof = (num5 <= 0);
			return num5 > 0;
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00004EDC File Offset: 0x000030DC
		private void Fill_(int require)
		{
			while (this.FillAllowEOF() && this.pos + require >= this.end)
			{
			}
			if (this.pos + require >= this.end)
			{
				throw this.ThrowXmlException("Unexpected end of file has occurred.");
			}
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00004F12 File Offset: 0x00003112
		private void Fill(int require)
		{
			if (this.pos + require >= this.end)
			{
				this.Fill_(require);
			}
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00004F2C File Offset: 0x0000312C
		private byte ReadByte()
		{
			this.Fill(0);
			byte[] array = this.data;
			int num = this.pos;
			this.pos = num + 1;
			return array[num];
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00004F58 File Offset: 0x00003158
		private ushort ReadUShort()
		{
			this.Fill(1);
			int num = this.pos;
			byte[] array = this.data;
			ushort result = (ushort)((int)array[num] + ((int)array[num + 1] << 8));
			this.pos += 2;
			return result;
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00004F94 File Offset: 0x00003194
		private int ParseMB32()
		{
			byte b = this.ReadByte();
			if (b > 127)
			{
				return this.ParseMB32_(b);
			}
			return (int)b;
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00004FB8 File Offset: 0x000031B8
		private int ParseMB32_(byte b)
		{
			uint num = (uint)(b & 127);
			b = this.ReadByte();
			uint num2 = (uint)(b & 127);
			num += num2 << 7;
			if (b > 127)
			{
				b = this.ReadByte();
				num2 = (uint)(b & 127);
				num += num2 << 14;
				if (b > 127)
				{
					b = this.ReadByte();
					num2 = (uint)(b & 127);
					num += num2 << 21;
					if (b > 127)
					{
						b = this.ReadByte();
						num2 = (uint)(b & 7);
						if (b > 7)
						{
							throw this.ThrowXmlException("The value is too big to fit into an Int32. The arithmetic operation resulted in an overflow.");
						}
						num += num2 << 28;
					}
				}
			}
			return (int)num;
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00005038 File Offset: 0x00003238
		private int ParseMB32(int pos)
		{
			byte[] array = this.data;
			byte b = array[pos++];
			uint num = (uint)(b & 127);
			if (b > 127)
			{
				byte b2 = array[pos++];
				uint num2 = (uint)(b2 & 127);
				num += num2 << 7;
				if (b2 > 127)
				{
					byte b3 = array[pos++];
					num2 = (uint)(b3 & 127);
					num += num2 << 14;
					if (b3 > 127)
					{
						byte b4 = array[pos++];
						num2 = (uint)(b4 & 127);
						num += num2 << 21;
						if (b4 > 127)
						{
							byte b5 = array[pos++];
							num2 = (uint)(b5 & 7);
							if (b5 > 7)
							{
								throw this.ThrowXmlException("The value is too big to fit into an Int32. The arithmetic operation resulted in an overflow.");
							}
							num += num2 << 28;
						}
					}
				}
			}
			return (int)num;
		}

		// Token: 0x06000090 RID: 144 RVA: 0x000050C8 File Offset: 0x000032C8
		private int ParseMB64()
		{
			byte b = this.ReadByte();
			if (b > 127)
			{
				return this.ParseMB32_(b);
			}
			return (int)b;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x000050EA File Offset: 0x000032EA
		private BinXmlToken PeekToken()
		{
			while (this.pos >= this.end && this.FillAllowEOF())
			{
			}
			if (this.pos >= this.end)
			{
				return BinXmlToken.EOF;
			}
			return (BinXmlToken)this.data[this.pos];
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00005120 File Offset: 0x00003320
		private BinXmlToken ReadToken()
		{
			while (this.pos >= this.end && this.FillAllowEOF())
			{
			}
			if (this.pos >= this.end)
			{
				return BinXmlToken.EOF;
			}
			byte[] array = this.data;
			int num = this.pos;
			this.pos = num + 1;
			return array[num];
		}

		// Token: 0x06000093 RID: 147 RVA: 0x0000516C File Offset: 0x0000336C
		private BinXmlToken NextToken2(BinXmlToken token)
		{
			for (;;)
			{
				if (token <= BinXmlToken.Extn)
				{
					if (token != BinXmlToken.NmFlush)
					{
						if (token != BinXmlToken.Extn)
						{
							break;
						}
						this.SkipExtn();
					}
					else
					{
						this.NameFlush();
					}
				}
				else if (token != BinXmlToken.QName)
				{
					if (token != BinXmlToken.Name)
					{
						break;
					}
					this.AddName();
				}
				else
				{
					this.AddQName();
				}
				token = this.ReadToken();
			}
			return token;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x000051D0 File Offset: 0x000033D0
		private BinXmlToken NextToken1()
		{
			int num = this.pos;
			BinXmlToken binXmlToken;
			if (num >= this.end)
			{
				binXmlToken = this.ReadToken();
			}
			else
			{
				binXmlToken = (BinXmlToken)this.data[num];
				this.pos = num + 1;
			}
			if (binXmlToken >= BinXmlToken.NmFlush && binXmlToken <= BinXmlToken.Name)
			{
				return this.NextToken2(binXmlToken);
			}
			return binXmlToken;
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00005224 File Offset: 0x00003424
		private BinXmlToken NextToken()
		{
			int num = this.pos;
			if (num < this.end)
			{
				BinXmlToken binXmlToken = (BinXmlToken)this.data[num];
				if (binXmlToken < BinXmlToken.NmFlush || binXmlToken > BinXmlToken.Name)
				{
					this.pos = num + 1;
					return binXmlToken;
				}
			}
			return this.NextToken1();
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0000526C File Offset: 0x0000346C
		private BinXmlToken PeekNextToken()
		{
			BinXmlToken binXmlToken = this.NextToken();
			if (BinXmlToken.EOF != binXmlToken)
			{
				this.pos--;
			}
			return binXmlToken;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00005294 File Offset: 0x00003494
		private BinXmlToken RescanNextToken()
		{
			checked
			{
				BinXmlToken binXmlToken;
				for (;;)
				{
					binXmlToken = this.ReadToken();
					if (binXmlToken <= BinXmlToken.Extn)
					{
						if (binXmlToken != BinXmlToken.NmFlush)
						{
							if (binXmlToken != BinXmlToken.Extn)
							{
								break;
							}
							int num = this.ParseMB32();
							this.pos += num;
						}
					}
					else if (binXmlToken != BinXmlToken.QName)
					{
						if (binXmlToken != BinXmlToken.Name)
						{
							break;
						}
						int num2 = this.ParseMB32();
						this.pos += 2 * num2;
					}
					else
					{
						this.ParseMB32();
						this.ParseMB32();
						this.ParseMB32();
					}
				}
				return binXmlToken;
			}
		}

		// Token: 0x06000098 RID: 152 RVA: 0x0000531C File Offset: 0x0000351C
		private string ParseText()
		{
			int num = this.mark;
			string @string;
			try
			{
				if (num < 0)
				{
					this.mark = this.pos;
				}
				int num2;
				int cch = this.ScanText(out num2);
				@string = this.GetString(num2, cch);
			}
			finally
			{
				if (num < 0)
				{
					this.mark = -1;
				}
			}
			return @string;
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00005374 File Offset: 0x00003574
		private int ScanText(out int start)
		{
			int num = this.ParseMB32();
			int num2 = this.mark;
			int num3 = this.pos;
			checked
			{
				this.pos += num * 2;
				if (this.pos > this.end)
				{
					this.Fill(-1);
				}
			}
			start = num3 - (num2 - this.mark);
			return num;
		}

		// Token: 0x0600009A RID: 154 RVA: 0x000053C8 File Offset: 0x000035C8
		private string GetString(int pos, int cch)
		{
			checked
			{
				if (pos + cch * 2 > this.end)
				{
					throw new XmlException("Unexpected end of file has occurred.", null);
				}
				if (cch == 0)
				{
					return string.Empty;
				}
				if ((pos & 1) == 0)
				{
					return this.GetStringAligned(this.data, pos, cch);
				}
				return this.unicode.GetString(this.data, pos, cch * 2);
			}
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00005420 File Offset: 0x00003620
		private unsafe string GetStringAligned(byte[] data, int offset, int cch)
		{
			byte* ptr;
			if (data == null || data.Length == 0)
			{
				ptr = null;
			}
			else
			{
				ptr = &data[0];
			}
			char* value = (char*)(ptr + offset);
			return new string(value, 0, cch);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00005454 File Offset: 0x00003654
		private string GetAttributeText(int i)
		{
			string val = this.attributes[i].val;
			if (val != null)
			{
				return val;
			}
			int num = this.pos;
			string result;
			try
			{
				this.pos = this.attributes[i].contentPos;
				BinXmlToken binXmlToken = this.RescanNextToken();
				if (BinXmlToken.Attr == binXmlToken || BinXmlToken.EndAttrs == binXmlToken)
				{
					result = "";
				}
				else
				{
					this.token = binXmlToken;
					this.ReScanOverValue(binXmlToken);
					result = this.ValueAsString(binXmlToken);
				}
			}
			finally
			{
				this.pos = num;
			}
			return result;
		}

		// Token: 0x0600009D RID: 157 RVA: 0x000054E8 File Offset: 0x000036E8
		private int LocateAttribute(string name, string ns)
		{
			for (int i = 0; i < this.attrCount; i++)
			{
				if (this.attributes[i].name.MatchNs(name, ns))
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00005524 File Offset: 0x00003724
		private int LocateAttribute(string name)
		{
			string prefix;
			string lname;
			ValidateNames.SplitQName(name, out prefix, out lname);
			for (int i = 0; i < this.attrCount; i++)
			{
				if (this.attributes[i].name.MatchPrefix(prefix, lname))
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x0600009F RID: 159 RVA: 0x0000556C File Offset: 0x0000376C
		private void PositionOnAttribute(int i)
		{
			this.attrIndex = i;
			this.qnameOther = this.attributes[i - 1].name;
			if (this.state == XmlSqlBinaryReader.ScanState.Doc)
			{
				this.parentNodeType = this.nodetype;
			}
			this.token = BinXmlToken.Attr;
			this.nodetype = XmlNodeType.Attribute;
			this.state = XmlSqlBinaryReader.ScanState.Attr;
			this.valueType = XmlSqlBinaryReader.TypeOfObject;
			this.stringValue = null;
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x000055D8 File Offset: 0x000037D8
		private void GrowElements()
		{
			XmlSqlBinaryReader.ElemInfo[] destinationArray = new XmlSqlBinaryReader.ElemInfo[this.elementStack.Length * 2];
			Array.Copy(this.elementStack, 0, destinationArray, 0, this.elementStack.Length);
			this.elementStack = destinationArray;
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00005614 File Offset: 0x00003814
		private void GrowAttributes()
		{
			XmlSqlBinaryReader.AttrInfo[] destinationArray = new XmlSqlBinaryReader.AttrInfo[this.attributes.Length * 2];
			Array.Copy(this.attributes, 0, destinationArray, 0, this.attrCount);
			this.attributes = destinationArray;
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x0000564C File Offset: 0x0000384C
		private void ClearAttributes()
		{
			if (this.attrCount != 0)
			{
				this.attrCount = 0;
			}
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00005660 File Offset: 0x00003860
		private void PushNamespace(string prefix, string ns, bool implied)
		{
			if (prefix == "xml")
			{
				return;
			}
			int num = this.elemDepth;
			XmlSqlBinaryReader.NamespaceDecl namespaceDecl;
			this.namespaces.TryGetValue(prefix, out namespaceDecl);
			if (namespaceDecl != null)
			{
				if (namespaceDecl.uri == ns)
				{
					if (!implied && namespaceDecl.implied && namespaceDecl.scope == num)
					{
						namespaceDecl.implied = false;
					}
					return;
				}
				this.qnameElement.CheckPrefixNS(prefix, ns);
				if (prefix.Length != 0)
				{
					for (int i = 0; i < this.attrCount; i++)
					{
						if (this.attributes[i].name.prefix.Length != 0)
						{
							this.attributes[i].name.CheckPrefixNS(prefix, ns);
						}
					}
				}
			}
			XmlSqlBinaryReader.NamespaceDecl namespaceDecl2 = new XmlSqlBinaryReader.NamespaceDecl(prefix, ns, this.elementStack[num].nsdecls, namespaceDecl, num, implied);
			this.elementStack[num].nsdecls = namespaceDecl2;
			this.namespaces[prefix] = namespaceDecl2;
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00005758 File Offset: 0x00003958
		private void PopNamespaces(XmlSqlBinaryReader.NamespaceDecl firstInScopeChain)
		{
			XmlSqlBinaryReader.NamespaceDecl scopeLink;
			for (XmlSqlBinaryReader.NamespaceDecl namespaceDecl = firstInScopeChain; namespaceDecl != null; namespaceDecl = scopeLink)
			{
				if (namespaceDecl.prevLink == null)
				{
					this.namespaces.Remove(namespaceDecl.prefix);
				}
				else
				{
					this.namespaces[namespaceDecl.prefix] = namespaceDecl.prevLink;
				}
				scopeLink = namespaceDecl.scopeLink;
				namespaceDecl.prevLink = null;
				namespaceDecl.scopeLink = null;
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x000057B4 File Offset: 0x000039B4
		private void GenerateImpliedXmlnsAttrs()
		{
			for (XmlSqlBinaryReader.NamespaceDecl namespaceDecl = this.elementStack[this.elemDepth].nsdecls; namespaceDecl != null; namespaceDecl = namespaceDecl.scopeLink)
			{
				if (namespaceDecl.implied)
				{
					if (this.attrCount == this.attributes.Length)
					{
						this.GrowAttributes();
					}
					XmlSqlBinaryReader.QName n;
					if (namespaceDecl.prefix.Length == 0)
					{
						n = new XmlSqlBinaryReader.QName(string.Empty, this.xmlns, this.nsxmlns);
					}
					else
					{
						n = new XmlSqlBinaryReader.QName(this.xmlns, this.xnt.Add(namespaceDecl.prefix), this.nsxmlns);
					}
					this.attributes[this.attrCount].Set(n, namespaceDecl.uri);
					this.attrCount++;
				}
			}
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00005884 File Offset: 0x00003A84
		private bool ReadInit(bool skipXmlDecl)
		{
			string res;
			if (!this.sniffed && this.ReadUShort() != 65503)
			{
				res = "Invalid BinaryXml signature.";
			}
			else
			{
				this.version = this.ReadByte();
				if (this.version != 1 && this.version != 2)
				{
					res = "Invalid BinaryXml protocol version.";
				}
				else
				{
					if (1200 == this.ReadUShort())
					{
						this.state = XmlSqlBinaryReader.ScanState.Doc;
						if (BinXmlToken.XmlDecl == this.PeekToken())
						{
							this.pos++;
							this.attributes[0].Set(new XmlSqlBinaryReader.QName(string.Empty, this.xnt.Add("version"), string.Empty), this.ParseText());
							this.attrCount = 1;
							if (BinXmlToken.Encoding == this.PeekToken())
							{
								this.pos++;
								this.attributes[1].Set(new XmlSqlBinaryReader.QName(string.Empty, this.xnt.Add("encoding"), string.Empty), this.ParseText());
								this.attrCount++;
							}
							byte b = this.ReadByte();
							if (b != 0)
							{
								if (b - 1 > 1)
								{
									res = "Invalid BinaryXml standalone token.";
									goto IL_1E2;
								}
								this.attributes[this.attrCount].Set(new XmlSqlBinaryReader.QName(string.Empty, this.xnt.Add("standalone"), string.Empty), (b == 1) ? "yes" : "no");
								this.attrCount++;
							}
							if (!skipXmlDecl)
							{
								XmlSqlBinaryReader.QName qname = new XmlSqlBinaryReader.QName(string.Empty, this.xnt.Add("xml"), string.Empty);
								this.qnameOther = (this.qnameElement = qname);
								this.nodetype = XmlNodeType.XmlDeclaration;
								this.posAfterAttrs = this.pos;
								return true;
							}
						}
						return this.ReadDoc();
					}
					res = "Unsupported BinaryXml codepage.";
				}
			}
			IL_1E2:
			this.state = XmlSqlBinaryReader.ScanState.Error;
			throw new XmlException(res, null);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00005A84 File Offset: 0x00003C84
		private void ScanAttributes()
		{
			int num = -1;
			int num2 = -1;
			this.mark = this.pos;
			string text = null;
			bool flag = false;
			BinXmlToken binXmlToken;
			while (BinXmlToken.EndAttrs != (binXmlToken = this.NextToken()))
			{
				if (BinXmlToken.Attr == binXmlToken)
				{
					if (text != null)
					{
						this.PushNamespace(text, string.Empty, false);
						text = null;
					}
					if (this.attrCount == this.attributes.Length)
					{
						this.GrowAttributes();
					}
					XmlSqlBinaryReader.QName qname = this.symbolTables.qnametable[this.ReadQNameRef()];
					this.attributes[this.attrCount].Set(qname, this.pos);
					if (qname.prefix == "xml")
					{
						if (qname.localname == "lang")
						{
							num2 = this.attrCount;
						}
						else if (qname.localname == "space")
						{
							num = this.attrCount;
						}
					}
					else if (Ref.Equal(qname.namespaceUri, this.nsxmlns))
					{
						text = qname.localname;
						if (text == "xmlns")
						{
							text = string.Empty;
						}
					}
					else if (qname.prefix.Length != 0)
					{
						if (qname.namespaceUri.Length == 0)
						{
							throw new XmlException("Cannot use a prefix with an empty namespace.", string.Empty);
						}
						this.PushNamespace(qname.prefix, qname.namespaceUri, true);
					}
					else if (qname.namespaceUri.Length != 0)
					{
						throw this.ThrowXmlException("Attribute '{0}' has namespace '{1}' but no prefix.", qname.localname, qname.namespaceUri);
					}
					this.attrCount++;
					flag = false;
				}
				else
				{
					this.ScanOverValue(binXmlToken, true, true);
					if (flag)
					{
						throw this.ThrowNotSupported("Lists of BinaryXml value tokens not supported.");
					}
					string text2 = this.stringValue;
					if (text2 != null)
					{
						this.attributes[this.attrCount - 1].val = text2;
						this.stringValue = null;
					}
					if (text != null)
					{
						string ns = this.xnt.Add(this.ValueAsString(binXmlToken));
						this.PushNamespace(text, ns, false);
						text = null;
					}
					flag = true;
				}
			}
			if (num != -1)
			{
				string attributeText = this.GetAttributeText(num);
				XmlSpace xmlSpace = XmlSpace.None;
				if (attributeText == "preserve")
				{
					xmlSpace = XmlSpace.Preserve;
				}
				else if (attributeText == "default")
				{
					xmlSpace = XmlSpace.Default;
				}
				this.elementStack[this.elemDepth].xmlSpace = xmlSpace;
				this.xmlspacePreserve = (XmlSpace.Preserve == xmlSpace);
			}
			if (num2 != -1)
			{
				this.elementStack[this.elemDepth].xmlLang = this.GetAttributeText(num2);
			}
			if (this.attrCount < 200)
			{
				this.SimpleCheckForDuplicateAttributes();
				return;
			}
			this.HashCheckForDuplicateAttributes();
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00005D28 File Offset: 0x00003F28
		private void SimpleCheckForDuplicateAttributes()
		{
			for (int i = 0; i < this.attrCount; i++)
			{
				string localname;
				string namespaceUri;
				this.attributes[i].GetLocalnameAndNamespaceUri(out localname, out namespaceUri);
				for (int j = i + 1; j < this.attrCount; j++)
				{
					if (this.attributes[j].MatchNS(localname, namespaceUri))
					{
						throw new XmlException("'{0}' is a duplicate attribute name.", this.attributes[i].name.ToString());
					}
				}
			}
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00005DAC File Offset: 0x00003FAC
		private void HashCheckForDuplicateAttributes()
		{
			int i;
			checked
			{
				for (i = 256; i < this.attrCount; i *= 2)
				{
				}
				if (this.attrHashTbl.Length < i)
				{
					this.attrHashTbl = new int[i];
				}
			}
			for (int j = 0; j < this.attrCount; j++)
			{
				string localname;
				string namespaceUri;
				int localnameAndNamespaceUriAndHash = this.attributes[j].GetLocalnameAndNamespaceUriAndHash(this.hasher, out localname, out namespaceUri);
				int num = localnameAndNamespaceUriAndHash & i - 1;
				int num2 = this.attrHashTbl[num];
				this.attrHashTbl[num] = j + 1;
				this.attributes[j].prevHash = num2;
				while (num2 != 0)
				{
					num2--;
					if (this.attributes[num2].MatchHashNS(localnameAndNamespaceUriAndHash, localname, namespaceUri))
					{
						throw new XmlException("'{0}' is a duplicate attribute name.", this.attributes[j].name.ToString());
					}
					num2 = this.attributes[num2].prevHash;
				}
			}
			Array.Clear(this.attrHashTbl, 0, i);
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00005EB8 File Offset: 0x000040B8
		private string XmlDeclValue()
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < this.attrCount; i++)
			{
				if (i > 0)
				{
					stringBuilder.Append(' ');
				}
				stringBuilder.Append(this.attributes[i].name.localname);
				stringBuilder.Append("=\"");
				stringBuilder.Append(this.attributes[i].val);
				stringBuilder.Append('"');
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00005F3C File Offset: 0x0000413C
		private string CDATAValue()
		{
			string text = this.GetString(this.tokDataPos, this.tokLen);
			StringBuilder stringBuilder = null;
			while (this.PeekToken() == BinXmlToken.CData)
			{
				this.pos++;
				if (stringBuilder == null)
				{
					stringBuilder = new StringBuilder(text.Length + text.Length / 2);
					stringBuilder.Append(text);
				}
				stringBuilder.Append(this.ParseText());
			}
			if (stringBuilder != null)
			{
				text = stringBuilder.ToString();
			}
			this.stringValue = text;
			return text;
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00005FBC File Offset: 0x000041BC
		private void FinishCDATA()
		{
			for (;;)
			{
				BinXmlToken binXmlToken = this.PeekToken();
				if (binXmlToken == BinXmlToken.EndCData)
				{
					break;
				}
				if (binXmlToken != BinXmlToken.CData)
				{
					goto IL_3F;
				}
				this.pos++;
				int num;
				this.ScanText(out num);
			}
			this.pos++;
			return;
			IL_3F:
			throw new XmlException("CDATA end token is missing.");
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00006014 File Offset: 0x00004214
		private void FinishEndElement()
		{
			XmlSqlBinaryReader.NamespaceDecl firstInScopeChain = this.elementStack[this.elemDepth].Clear();
			this.PopNamespaces(firstInScopeChain);
			this.elemDepth--;
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00006050 File Offset: 0x00004250
		private bool ReadDoc()
		{
			XmlNodeType xmlNodeType = this.nodetype;
			if (xmlNodeType != XmlNodeType.Element)
			{
				if (xmlNodeType != XmlNodeType.CDATA)
				{
					if (xmlNodeType == XmlNodeType.EndElement)
					{
						this.FinishEndElement();
					}
				}
				else
				{
					this.FinishCDATA();
				}
			}
			else if (this.isEmpty)
			{
				this.FinishEndElement();
				this.isEmpty = false;
			}
			for (;;)
			{
				this.nodetype = XmlNodeType.None;
				this.mark = -1;
				if (this.qnameOther.localname.Length != 0)
				{
					this.qnameOther.Clear();
				}
				this.ClearAttributes();
				this.attrCount = 0;
				this.valueType = XmlSqlBinaryReader.TypeOfString;
				this.stringValue = null;
				this.hasTypedValue = false;
				this.token = this.NextToken();
				BinXmlToken binXmlToken = this.token;
				if (binXmlToken <= BinXmlToken.XSD_KATMAI_DATE)
				{
					switch (binXmlToken)
					{
					case BinXmlToken.EOF:
						goto IL_191;
					case BinXmlToken.Error:
					case (BinXmlToken)21:
					case (BinXmlToken)25:
					case (BinXmlToken)26:
						goto IL_27C;
					case BinXmlToken.SQL_SMALLINT:
					case BinXmlToken.SQL_INT:
					case BinXmlToken.SQL_REAL:
					case BinXmlToken.SQL_FLOAT:
					case BinXmlToken.SQL_MONEY:
					case BinXmlToken.SQL_BIT:
					case BinXmlToken.SQL_TINYINT:
					case BinXmlToken.SQL_BIGINT:
					case BinXmlToken.SQL_UUID:
					case BinXmlToken.SQL_DECIMAL:
					case BinXmlToken.SQL_NUMERIC:
					case BinXmlToken.SQL_BINARY:
					case BinXmlToken.SQL_CHAR:
					case BinXmlToken.SQL_NCHAR:
					case BinXmlToken.SQL_VARBINARY:
					case BinXmlToken.SQL_VARCHAR:
					case BinXmlToken.SQL_NVARCHAR:
					case BinXmlToken.SQL_DATETIME:
					case BinXmlToken.SQL_SMALLDATETIME:
					case BinXmlToken.SQL_SMALLMONEY:
					case BinXmlToken.SQL_TEXT:
					case BinXmlToken.SQL_IMAGE:
					case BinXmlToken.SQL_NTEXT:
					case BinXmlToken.SQL_UDT:
						break;
					default:
						if (binXmlToken - BinXmlToken.XSD_KATMAI_TIMEOFFSET > 5)
						{
							goto Block_8;
						}
						break;
					}
				}
				else if (binXmlToken - BinXmlToken.XSD_TIME > 11)
				{
					switch (binXmlToken)
					{
					case BinXmlToken.EndNest:
						goto IL_22D;
					case BinXmlToken.Nest:
						goto IL_218;
					case BinXmlToken.XmlText:
						goto IL_242;
					case (BinXmlToken)238:
					case BinXmlToken.QName:
					case BinXmlToken.Name:
					case BinXmlToken.EndCData:
					case BinXmlToken.EndAttrs:
					case BinXmlToken.Attr:
						goto IL_27C;
					case BinXmlToken.CData:
						goto IL_210;
					case BinXmlToken.Comment:
						this.ImplReadComment();
						if (this.ignoreComments)
						{
							continue;
						}
						return true;
					case BinXmlToken.PI:
						this.ImplReadPI();
						if (this.ignorePIs)
						{
							continue;
						}
						return true;
					case BinXmlToken.EndElem:
						goto IL_1BA;
					case BinXmlToken.Element:
						goto IL_1AF;
					default:
						if (binXmlToken != BinXmlToken.DocType)
						{
							goto Block_11;
						}
						this.ImplReadDoctype();
						if (this.dtdProcessing == DtdProcessing.Ignore)
						{
							continue;
						}
						if (this.prevNameInfo != null)
						{
							continue;
						}
						return true;
					}
				}
				this.ImplReadData(this.token);
				if (XmlNodeType.Text == this.nodetype)
				{
					goto Block_18;
				}
				if (!this.ignoreWhitespace || this.xmlspacePreserve)
				{
					return true;
				}
			}
			Block_8:
			Block_11:
			goto IL_27C;
			IL_191:
			if (this.elemDepth > 0)
			{
				throw new XmlException("Unexpected end of file has occurred.", null);
			}
			this.state = XmlSqlBinaryReader.ScanState.EOF;
			return false;
			IL_1AF:
			this.ImplReadElement();
			return true;
			IL_1BA:
			this.ImplReadEndElement();
			return true;
			IL_210:
			this.ImplReadCDATA();
			return true;
			IL_218:
			this.ImplReadNest();
			this.sniffed = false;
			return this.ReadInit(true);
			IL_22D:
			if (this.prevNameInfo != null)
			{
				this.ImplReadEndNest();
				return this.ReadDoc();
			}
			goto IL_27C;
			IL_242:
			this.ImplReadXmlText();
			return true;
			Block_18:
			this.CheckAllowContent();
			return true;
			IL_27C:
			throw this.ThrowUnexpectedToken(this.token);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x000062E8 File Offset: 0x000044E8
		private void ImplReadData(BinXmlToken tokenType)
		{
			this.mark = this.pos;
			if (tokenType <= BinXmlToken.SQL_NVARCHAR)
			{
				if (tokenType - BinXmlToken.SQL_CHAR > 1 && tokenType - BinXmlToken.SQL_VARCHAR > 1)
				{
					goto IL_3F;
				}
			}
			else if (tokenType != BinXmlToken.SQL_TEXT && tokenType != BinXmlToken.SQL_NTEXT)
			{
				goto IL_3F;
			}
			this.valueType = XmlSqlBinaryReader.TypeOfString;
			this.hasTypedValue = false;
			goto IL_58;
			IL_3F:
			this.valueType = this.GetValueType(this.token);
			this.hasTypedValue = true;
			IL_58:
			this.nodetype = this.ScanOverValue(this.token, false, true);
			BinXmlToken binXmlToken = this.PeekNextToken();
			switch (binXmlToken)
			{
			case BinXmlToken.SQL_SMALLINT:
			case BinXmlToken.SQL_INT:
			case BinXmlToken.SQL_REAL:
			case BinXmlToken.SQL_FLOAT:
			case BinXmlToken.SQL_MONEY:
			case BinXmlToken.SQL_BIT:
			case BinXmlToken.SQL_TINYINT:
			case BinXmlToken.SQL_BIGINT:
			case BinXmlToken.SQL_UUID:
			case BinXmlToken.SQL_DECIMAL:
			case BinXmlToken.SQL_NUMERIC:
			case BinXmlToken.SQL_BINARY:
			case BinXmlToken.SQL_CHAR:
			case BinXmlToken.SQL_NCHAR:
			case BinXmlToken.SQL_VARBINARY:
			case BinXmlToken.SQL_VARCHAR:
			case BinXmlToken.SQL_NVARCHAR:
			case BinXmlToken.SQL_DATETIME:
			case BinXmlToken.SQL_SMALLDATETIME:
			case BinXmlToken.SQL_SMALLMONEY:
			case BinXmlToken.SQL_TEXT:
			case BinXmlToken.SQL_IMAGE:
			case BinXmlToken.SQL_NTEXT:
			case BinXmlToken.SQL_UDT:
				break;
			case (BinXmlToken)21:
			case (BinXmlToken)25:
			case (BinXmlToken)26:
				return;
			default:
				if (binXmlToken - BinXmlToken.XSD_KATMAI_TIMEOFFSET > 5 && binXmlToken - BinXmlToken.XSD_TIME > 11)
				{
					return;
				}
				break;
			}
			throw this.ThrowNotSupported("Lists of BinaryXml value tokens not supported.");
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x000063FC File Offset: 0x000045FC
		private void ImplReadElement()
		{
			if (3 != this.docState || 9 != this.docState)
			{
				switch (this.docState)
				{
				case -1:
					throw this.ThrowUnexpectedToken(this.token);
				case 0:
					this.docState = 9;
					break;
				case 1:
				case 2:
					this.docState = 3;
					break;
				}
			}
			this.elemDepth++;
			if (this.elemDepth == this.elementStack.Length)
			{
				this.GrowElements();
			}
			XmlSqlBinaryReader.QName qname = this.symbolTables.qnametable[this.ReadQNameRef()];
			this.qnameOther = (this.qnameElement = qname);
			this.elementStack[this.elemDepth].Set(qname, this.xmlspacePreserve);
			this.PushNamespace(qname.prefix, qname.namespaceUri, true);
			BinXmlToken binXmlToken = this.PeekNextToken();
			if (BinXmlToken.Attr == binXmlToken)
			{
				this.ScanAttributes();
				binXmlToken = this.PeekNextToken();
			}
			this.GenerateImpliedXmlnsAttrs();
			if (BinXmlToken.EndElem == binXmlToken)
			{
				this.NextToken();
				this.isEmpty = true;
			}
			else if (BinXmlToken.SQL_NVARCHAR == binXmlToken)
			{
				if (this.mark < 0)
				{
					this.mark = this.pos;
				}
				this.pos++;
				if (this.ReadByte() == 0)
				{
					if (247 != this.ReadByte())
					{
						this.pos -= 3;
					}
					else
					{
						this.pos--;
					}
				}
				else
				{
					this.pos -= 2;
				}
			}
			this.nodetype = XmlNodeType.Element;
			this.valueType = XmlSqlBinaryReader.TypeOfObject;
			this.posAfterAttrs = this.pos;
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x0000659C File Offset: 0x0000479C
		private void ImplReadEndElement()
		{
			if (this.elemDepth == 0)
			{
				throw this.ThrowXmlException("Unexpected end tag.");
			}
			int num = this.elemDepth;
			if (1 == num && 3 == this.docState)
			{
				this.docState = -1;
			}
			this.qnameOther = this.elementStack[num].name;
			this.xmlspacePreserve = this.elementStack[num].xmlspacePreserve;
			this.nodetype = XmlNodeType.EndElement;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00006610 File Offset: 0x00004810
		private void ImplReadDoctype()
		{
			if (this.dtdProcessing == DtdProcessing.Prohibit)
			{
				throw this.ThrowXmlException("DTD is prohibited in this XML document.");
			}
			int num = this.docState;
			if (num <= 1)
			{
				this.docState = 2;
				this.qnameOther.localname = this.ParseText();
				if (BinXmlToken.System == this.PeekToken())
				{
					this.pos++;
					XmlSqlBinaryReader.AttrInfo[] array = this.attributes;
					num = this.attrCount;
					this.attrCount = num + 1;
					array[num].Set(new XmlSqlBinaryReader.QName(string.Empty, this.xnt.Add("SYSTEM"), string.Empty), this.ParseText());
				}
				if (BinXmlToken.Public == this.PeekToken())
				{
					this.pos++;
					XmlSqlBinaryReader.AttrInfo[] array2 = this.attributes;
					num = this.attrCount;
					this.attrCount = num + 1;
					array2[num].Set(new XmlSqlBinaryReader.QName(string.Empty, this.xnt.Add("PUBLIC"), string.Empty), this.ParseText());
				}
				if (BinXmlToken.Subset == this.PeekToken())
				{
					this.pos++;
					this.mark = this.pos;
					this.tokLen = this.ScanText(out this.tokDataPos);
				}
				else
				{
					this.tokLen = (this.tokDataPos = 0);
				}
				this.nodetype = XmlNodeType.DocumentType;
				this.posAfterAttrs = this.pos;
				return;
			}
			if (num == 9)
			{
				throw this.ThrowXmlException("DTD is not allowed in XML fragments.");
			}
			throw this.ThrowXmlException("Unexpected DTD declaration.");
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00006794 File Offset: 0x00004994
		private void ImplReadPI()
		{
			this.qnameOther.localname = this.symbolTables.symtable[this.ReadNameRef()];
			this.mark = this.pos;
			this.tokLen = this.ScanText(out this.tokDataPos);
			this.nodetype = XmlNodeType.ProcessingInstruction;
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x000067E3 File Offset: 0x000049E3
		private void ImplReadComment()
		{
			this.nodetype = XmlNodeType.Comment;
			this.mark = this.pos;
			this.tokLen = this.ScanText(out this.tokDataPos);
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x0000680A File Offset: 0x00004A0A
		private void ImplReadCDATA()
		{
			this.CheckAllowContent();
			this.nodetype = XmlNodeType.CDATA;
			this.mark = this.pos;
			this.tokLen = this.ScanText(out this.tokDataPos);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00006837 File Offset: 0x00004A37
		private void ImplReadNest()
		{
			this.CheckAllowContent();
			this.prevNameInfo = new XmlSqlBinaryReader.NestedBinXml(this.symbolTables, this.docState, this.prevNameInfo);
			this.symbolTables.Init();
			this.docState = 0;
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00006870 File Offset: 0x00004A70
		private void ImplReadEndNest()
		{
			XmlSqlBinaryReader.NestedBinXml nestedBinXml = this.prevNameInfo;
			this.symbolTables = nestedBinXml.symbolTables;
			this.docState = nestedBinXml.docState;
			this.prevNameInfo = nestedBinXml.next;
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x000068A8 File Offset: 0x00004AA8
		private void ImplReadXmlText()
		{
			this.CheckAllowContent();
			string xmlFragment = this.ParseText();
			XmlNamespaceManager xmlNamespaceManager = new XmlNamespaceManager(this.xnt);
			foreach (XmlSqlBinaryReader.NamespaceDecl namespaceDecl in this.namespaces.Values)
			{
				if (namespaceDecl.scope > 0)
				{
					xmlNamespaceManager.AddNamespace(namespaceDecl.prefix, namespaceDecl.uri);
				}
			}
			XmlReaderSettings settings = this.Settings;
			settings.ReadOnly = false;
			settings.NameTable = this.xnt;
			settings.DtdProcessing = DtdProcessing.Prohibit;
			if (this.elemDepth != 0)
			{
				settings.ConformanceLevel = ConformanceLevel.Fragment;
			}
			settings.ReadOnly = true;
			XmlParserContext context = new XmlParserContext(this.xnt, xmlNamespaceManager, this.XmlLang, this.XmlSpace);
			this.textXmlReader = new XmlTextReaderImpl(xmlFragment, context, settings);
			if (!this.textXmlReader.Read() || (this.textXmlReader.NodeType == XmlNodeType.XmlDeclaration && !this.textXmlReader.Read()))
			{
				this.state = XmlSqlBinaryReader.ScanState.Doc;
				this.ReadDoc();
				return;
			}
			this.state = XmlSqlBinaryReader.ScanState.XmlText;
			this.UpdateFromTextReader();
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x000069D8 File Offset: 0x00004BD8
		private void UpdateFromTextReader()
		{
			XmlReader xmlReader = this.textXmlReader;
			this.nodetype = xmlReader.NodeType;
			this.qnameOther.prefix = xmlReader.Prefix;
			this.qnameOther.localname = xmlReader.LocalName;
			this.qnameOther.namespaceUri = xmlReader.NamespaceURI;
			this.valueType = xmlReader.ValueType;
			this.isEmpty = xmlReader.IsEmptyElement;
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00006A43 File Offset: 0x00004C43
		private bool UpdateFromTextReader(bool needUpdate)
		{
			if (needUpdate)
			{
				this.UpdateFromTextReader();
			}
			return needUpdate;
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00006A50 File Offset: 0x00004C50
		private void CheckAllowContent()
		{
			int num = this.docState;
			if (num == 0)
			{
				this.docState = 9;
				return;
			}
			if (num != 3 && num != 9)
			{
				throw this.ThrowXmlException("Data at the root level is invalid.");
			}
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00006A88 File Offset: 0x00004C88
		private void GenerateTokenTypeMap()
		{
			Type[] array = new Type[256];
			array[134] = typeof(bool);
			array[7] = typeof(byte);
			array[136] = typeof(sbyte);
			array[1] = typeof(short);
			array[137] = typeof(ushort);
			array[138] = typeof(uint);
			array[3] = typeof(float);
			array[4] = typeof(double);
			array[8] = typeof(long);
			array[139] = typeof(ulong);
			array[140] = typeof(XmlQualifiedName);
			Type typeFromHandle = typeof(int);
			array[6] = typeFromHandle;
			array[2] = typeFromHandle;
			Type typeFromHandle2 = typeof(decimal);
			array[20] = typeFromHandle2;
			array[5] = typeFromHandle2;
			array[10] = typeFromHandle2;
			array[11] = typeFromHandle2;
			array[135] = typeFromHandle2;
			Type typeFromHandle3 = typeof(DateTime);
			array[19] = typeFromHandle3;
			array[18] = typeFromHandle3;
			array[129] = typeFromHandle3;
			array[130] = typeFromHandle3;
			array[131] = typeFromHandle3;
			array[127] = typeFromHandle3;
			array[126] = typeFromHandle3;
			array[125] = typeFromHandle3;
			Type typeFromHandle4 = typeof(DateTimeOffset);
			array[124] = typeFromHandle4;
			array[123] = typeFromHandle4;
			array[122] = typeFromHandle4;
			Type typeFromHandle5 = typeof(byte[]);
			array[15] = typeFromHandle5;
			array[12] = typeFromHandle5;
			array[23] = typeFromHandle5;
			array[27] = typeFromHandle5;
			array[132] = typeFromHandle5;
			array[133] = typeFromHandle5;
			array[13] = XmlSqlBinaryReader.TypeOfString;
			array[16] = XmlSqlBinaryReader.TypeOfString;
			array[22] = XmlSqlBinaryReader.TypeOfString;
			array[14] = XmlSqlBinaryReader.TypeOfString;
			array[17] = XmlSqlBinaryReader.TypeOfString;
			array[24] = XmlSqlBinaryReader.TypeOfString;
			array[9] = XmlSqlBinaryReader.TypeOfString;
			if (XmlSqlBinaryReader.TokenTypeMap == null)
			{
				XmlSqlBinaryReader.TokenTypeMap = array;
			}
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00006C60 File Offset: 0x00004E60
		private Type GetValueType(BinXmlToken token)
		{
			Type type = XmlSqlBinaryReader.TokenTypeMap[(int)token];
			if (type == null)
			{
				throw this.ThrowUnexpectedToken(token);
			}
			return type;
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00006C7C File Offset: 0x00004E7C
		private void ReScanOverValue(BinXmlToken token)
		{
			this.ScanOverValue(token, true, false);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00006C88 File Offset: 0x00004E88
		private XmlNodeType ScanOverValue(BinXmlToken token, bool attr, bool checkChars)
		{
			if (token != BinXmlToken.SQL_NVARCHAR)
			{
				return this.ScanOverAnyValue(token, attr, checkChars);
			}
			if (this.mark < 0)
			{
				this.mark = this.pos;
			}
			this.tokLen = this.ParseMB32();
			this.tokDataPos = this.pos;
			checked
			{
				this.pos += this.tokLen * 2;
				this.Fill(-1);
				if (checkChars && this.checkCharacters)
				{
					return this.CheckText(attr);
				}
				if (!attr)
				{
					return this.CheckTextIsWS();
				}
				return XmlNodeType.Text;
			}
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00006D0C File Offset: 0x00004F0C
		private XmlNodeType ScanOverAnyValue(BinXmlToken token, bool attr, bool checkChars)
		{
			if (this.mark < 0)
			{
				this.mark = this.pos;
			}
			checked
			{
				switch (token)
				{
				case BinXmlToken.SQL_SMALLINT:
					goto IL_109;
				case BinXmlToken.SQL_INT:
				case BinXmlToken.SQL_REAL:
				case BinXmlToken.SQL_SMALLDATETIME:
				case BinXmlToken.SQL_SMALLMONEY:
					goto IL_12F;
				case BinXmlToken.SQL_FLOAT:
				case BinXmlToken.SQL_MONEY:
				case BinXmlToken.SQL_BIGINT:
				case BinXmlToken.SQL_DATETIME:
					goto IL_155;
				case BinXmlToken.SQL_BIT:
				case BinXmlToken.SQL_TINYINT:
					break;
				case BinXmlToken.SQL_UUID:
					this.tokDataPos = this.pos;
					this.tokLen = 16;
					this.pos += 16;
					goto IL_2BA;
				case BinXmlToken.SQL_DECIMAL:
				case BinXmlToken.SQL_NUMERIC:
					goto IL_1A3;
				case BinXmlToken.SQL_BINARY:
				case BinXmlToken.SQL_VARBINARY:
				case BinXmlToken.SQL_IMAGE:
				case BinXmlToken.SQL_UDT:
					goto IL_1D3;
				case BinXmlToken.SQL_CHAR:
				case BinXmlToken.SQL_VARCHAR:
				case BinXmlToken.SQL_TEXT:
					this.tokLen = this.ParseMB64();
					this.tokDataPos = this.pos;
					this.pos += this.tokLen;
					if (checkChars && this.checkCharacters)
					{
						this.Fill(-1);
						string text = this.ValueAsString(token);
						XmlConvert.VerifyCharData(text, ExceptionType.ArgumentException, ExceptionType.XmlException);
						this.stringValue = text;
						goto IL_2BA;
					}
					goto IL_2BA;
				case BinXmlToken.SQL_NCHAR:
				case BinXmlToken.SQL_NVARCHAR:
				case BinXmlToken.SQL_NTEXT:
					return this.ScanOverValue(BinXmlToken.SQL_NVARCHAR, attr, checkChars);
				case (BinXmlToken)21:
				case (BinXmlToken)25:
				case (BinXmlToken)26:
					goto IL_2B2;
				default:
					switch (token)
					{
					case BinXmlToken.XSD_KATMAI_TIMEOFFSET:
					case BinXmlToken.XSD_KATMAI_DATETIMEOFFSET:
					case BinXmlToken.XSD_KATMAI_DATEOFFSET:
					case BinXmlToken.XSD_KATMAI_TIME:
					case BinXmlToken.XSD_KATMAI_DATETIME:
					case BinXmlToken.XSD_KATMAI_DATE:
						this.VerifyVersion(2, token);
						this.tokDataPos = this.pos;
						this.tokLen = this.GetXsdKatmaiTokenLength(token);
						this.pos += this.tokLen;
						goto IL_2BA;
					case (BinXmlToken)128:
						goto IL_2B2;
					case BinXmlToken.XSD_TIME:
					case BinXmlToken.XSD_DATETIME:
					case BinXmlToken.XSD_DATE:
					case BinXmlToken.XSD_UNSIGNEDLONG:
						goto IL_155;
					case BinXmlToken.XSD_BINHEX:
					case BinXmlToken.XSD_BASE64:
						goto IL_1D3;
					case BinXmlToken.XSD_BOOLEAN:
					case BinXmlToken.XSD_BYTE:
						break;
					case BinXmlToken.XSD_DECIMAL:
						goto IL_1A3;
					case BinXmlToken.XSD_UNSIGNEDSHORT:
						goto IL_109;
					case BinXmlToken.XSD_UNSIGNEDINT:
						goto IL_12F;
					case BinXmlToken.XSD_QNAME:
						this.tokDataPos = this.pos;
						this.ParseMB32();
						goto IL_2BA;
					default:
						goto IL_2B2;
					}
					break;
				}
				this.tokDataPos = this.pos;
				this.tokLen = 1;
				this.pos++;
				goto IL_2BA;
				IL_109:
				this.tokDataPos = this.pos;
				this.tokLen = 2;
				this.pos += 2;
				goto IL_2BA;
				IL_12F:
				this.tokDataPos = this.pos;
				this.tokLen = 4;
				this.pos += 4;
				goto IL_2BA;
				IL_155:
				this.tokDataPos = this.pos;
				this.tokLen = 8;
				this.pos += 8;
				goto IL_2BA;
				IL_1A3:
				this.tokDataPos = this.pos;
				this.tokLen = this.ParseMB64();
				this.pos += this.tokLen;
				goto IL_2BA;
				IL_1D3:
				this.tokLen = this.ParseMB64();
				this.tokDataPos = this.pos;
				this.pos += this.tokLen;
				goto IL_2BA;
				IL_2B2:
				throw this.ThrowUnexpectedToken(token);
				IL_2BA:
				this.Fill(-1);
				return XmlNodeType.Text;
			}
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00006FDC File Offset: 0x000051DC
		private unsafe XmlNodeType CheckText(bool attr)
		{
			XmlCharType xmlCharType = this.xmlCharType;
			byte[] array;
			byte* ptr;
			if ((array = this.data) == null || array.Length == 0)
			{
				ptr = null;
			}
			else
			{
				ptr = &array[0];
			}
			int num = this.pos;
			int num2 = this.tokDataPos;
			if (!attr)
			{
				for (;;)
				{
					int num3 = num2 + 2;
					if (num3 > num)
					{
						break;
					}
					if (ptr[num2 + 1] != 0 || (xmlCharType.charProperties[(int)ptr[num2]] & 1) == 0)
					{
						goto IL_6E;
					}
					num2 = num3;
				}
				if (!this.xmlspacePreserve)
				{
					return XmlNodeType.Whitespace;
				}
				return XmlNodeType.SignificantWhitespace;
			}
			char c;
			char c2;
			for (;;)
			{
				IL_6E:
				int num4 = num2 + 2;
				if (num4 > num)
				{
					break;
				}
				c = (char)((int)ptr[num2] | (int)ptr[num2 + 1] << 8);
				if ((xmlCharType.charProperties[(int)c] & 16) != 0)
				{
					num2 = num4;
				}
				else
				{
					if (!XmlCharType.IsHighSurrogate((int)c))
					{
						goto Block_8;
					}
					if (num2 + 4 > num)
					{
						goto Block_9;
					}
					c2 = (char)((int)ptr[num2 + 2] | (int)ptr[num2 + 3] << 8);
					if (!XmlCharType.IsLowSurrogate((int)c2))
					{
						goto Block_10;
					}
					num2 += 4;
				}
			}
			return XmlNodeType.Text;
			Block_8:
			throw XmlConvert.CreateInvalidCharException(c, '\0', ExceptionType.XmlException);
			Block_9:
			throw this.ThrowXmlException("The surrogate pair is invalid. Missing a low surrogate character.");
			Block_10:
			throw XmlConvert.CreateInvalidSurrogatePairException(c, c2);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x000070E4 File Offset: 0x000052E4
		private XmlNodeType CheckTextIsWS()
		{
			byte[] array = this.data;
			int i = this.tokDataPos;
			while (i < this.pos)
			{
				if (array[i + 1] == 0)
				{
					byte b = array[i];
					if (b - 9 <= 1 || b == 13 || b == 32)
					{
						i += 2;
						continue;
					}
				}
				return XmlNodeType.Text;
			}
			if (this.xmlspacePreserve)
			{
				return XmlNodeType.SignificantWhitespace;
			}
			return XmlNodeType.Whitespace;
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00007139 File Offset: 0x00005339
		private void CheckValueTokenBounds()
		{
			if (this.end - this.tokDataPos < this.tokLen)
			{
				throw this.ThrowXmlException("Unexpected end of file has occurred.");
			}
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x0000715C File Offset: 0x0000535C
		private int GetXsdKatmaiTokenLength(BinXmlToken token)
		{
			switch (token)
			{
			case BinXmlToken.XSD_KATMAI_TIMEOFFSET:
			case BinXmlToken.XSD_KATMAI_DATETIMEOFFSET:
			case BinXmlToken.XSD_KATMAI_DATEOFFSET:
			{
				this.Fill(0);
				byte scale = this.data[this.pos];
				return 6 + this.XsdKatmaiTimeScaleToValueLength(scale);
			}
			case BinXmlToken.XSD_KATMAI_TIME:
			case BinXmlToken.XSD_KATMAI_DATETIME:
			{
				this.Fill(0);
				byte scale = this.data[this.pos];
				return 4 + this.XsdKatmaiTimeScaleToValueLength(scale);
			}
			case BinXmlToken.XSD_KATMAI_DATE:
				return 3;
			default:
				throw this.ThrowUnexpectedToken(this.token);
			}
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x000071D8 File Offset: 0x000053D8
		private int XsdKatmaiTimeScaleToValueLength(byte scale)
		{
			if (scale > 7)
			{
				throw new XmlException("Arithmetic Overflow.", null);
			}
			return (int)XmlSqlBinaryReader.XsdKatmaiTimeScaleToValueLengthMap[(int)scale];
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x000071F4 File Offset: 0x000053F4
		private long ValueAsLong()
		{
			this.CheckValueTokenBounds();
			BinXmlToken binXmlToken = this.token;
			switch (binXmlToken)
			{
			case BinXmlToken.SQL_SMALLINT:
				return (long)this.GetInt16(this.tokDataPos);
			case BinXmlToken.SQL_INT:
				return (long)this.GetInt32(this.tokDataPos);
			case BinXmlToken.SQL_REAL:
			case BinXmlToken.SQL_FLOAT:
				return (long)this.ValueAsDouble();
			case BinXmlToken.SQL_MONEY:
			case BinXmlToken.SQL_DECIMAL:
			case BinXmlToken.SQL_NUMERIC:
			case BinXmlToken.SQL_SMALLMONEY:
				break;
			case BinXmlToken.SQL_BIT:
			case BinXmlToken.SQL_TINYINT:
				return (long)((ulong)this.data[this.tokDataPos]);
			case BinXmlToken.SQL_BIGINT:
				return this.GetInt64(this.tokDataPos);
			case BinXmlToken.SQL_UUID:
			case BinXmlToken.SQL_BINARY:
			case BinXmlToken.SQL_CHAR:
			case BinXmlToken.SQL_NCHAR:
			case BinXmlToken.SQL_VARBINARY:
			case BinXmlToken.SQL_VARCHAR:
			case BinXmlToken.SQL_NVARCHAR:
			case BinXmlToken.SQL_DATETIME:
			case BinXmlToken.SQL_SMALLDATETIME:
				goto IL_110;
			default:
				switch (binXmlToken)
				{
				case BinXmlToken.XSD_DECIMAL:
					break;
				case BinXmlToken.XSD_BYTE:
					return (long)((sbyte)this.data[this.tokDataPos]);
				case BinXmlToken.XSD_UNSIGNEDSHORT:
					return (long)((ulong)this.GetUInt16(this.tokDataPos));
				case BinXmlToken.XSD_UNSIGNEDINT:
					return (long)((ulong)this.GetUInt32(this.tokDataPos));
				case BinXmlToken.XSD_UNSIGNEDLONG:
					return checked((long)this.GetUInt64(this.tokDataPos));
				default:
					goto IL_110;
				}
				break;
			}
			return (long)this.ValueAsDecimal();
			IL_110:
			throw this.ThrowUnexpectedToken(this.token);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x0000731D File Offset: 0x0000551D
		private ulong ValueAsULong()
		{
			if (BinXmlToken.XSD_UNSIGNEDLONG == this.token)
			{
				this.CheckValueTokenBounds();
				return this.GetUInt64(this.tokDataPos);
			}
			throw this.ThrowUnexpectedToken(this.token);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x0000734C File Offset: 0x0000554C
		private decimal ValueAsDecimal()
		{
			this.CheckValueTokenBounds();
			BinXmlToken binXmlToken = this.token;
			switch (binXmlToken)
			{
			case BinXmlToken.SQL_SMALLINT:
			case BinXmlToken.SQL_INT:
			case BinXmlToken.SQL_BIT:
			case BinXmlToken.SQL_TINYINT:
			case BinXmlToken.SQL_BIGINT:
				break;
			case BinXmlToken.SQL_REAL:
				return new decimal(this.GetSingle(this.tokDataPos));
			case BinXmlToken.SQL_FLOAT:
				return new decimal(this.GetDouble(this.tokDataPos));
			case BinXmlToken.SQL_MONEY:
			{
				BinXmlSqlMoney binXmlSqlMoney = new BinXmlSqlMoney(this.GetInt64(this.tokDataPos));
				return binXmlSqlMoney.ToDecimal();
			}
			case BinXmlToken.SQL_UUID:
			case BinXmlToken.SQL_BINARY:
			case BinXmlToken.SQL_CHAR:
			case BinXmlToken.SQL_NCHAR:
			case BinXmlToken.SQL_VARBINARY:
			case BinXmlToken.SQL_VARCHAR:
			case BinXmlToken.SQL_NVARCHAR:
			case BinXmlToken.SQL_DATETIME:
			case BinXmlToken.SQL_SMALLDATETIME:
				goto IL_124;
			case BinXmlToken.SQL_DECIMAL:
			case BinXmlToken.SQL_NUMERIC:
				goto IL_FC;
			case BinXmlToken.SQL_SMALLMONEY:
			{
				BinXmlSqlMoney binXmlSqlMoney2 = new BinXmlSqlMoney(this.GetInt32(this.tokDataPos));
				return binXmlSqlMoney2.ToDecimal();
			}
			default:
				switch (binXmlToken)
				{
				case BinXmlToken.XSD_DECIMAL:
					goto IL_FC;
				case BinXmlToken.XSD_BYTE:
				case BinXmlToken.XSD_UNSIGNEDSHORT:
				case BinXmlToken.XSD_UNSIGNEDINT:
					break;
				case BinXmlToken.XSD_UNSIGNEDLONG:
					return new decimal(this.ValueAsULong());
				default:
					goto IL_124;
				}
				break;
			}
			return new decimal(this.ValueAsLong());
			IL_FC:
			BinXmlSqlDecimal binXmlSqlDecimal = new BinXmlSqlDecimal(this.data, this.tokDataPos, this.token == BinXmlToken.XSD_DECIMAL);
			return binXmlSqlDecimal.ToDecimal();
			IL_124:
			throw this.ThrowUnexpectedToken(this.token);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0000748C File Offset: 0x0000568C
		private double ValueAsDouble()
		{
			this.CheckValueTokenBounds();
			BinXmlToken binXmlToken = this.token;
			switch (binXmlToken)
			{
			case BinXmlToken.SQL_SMALLINT:
			case BinXmlToken.SQL_INT:
			case BinXmlToken.SQL_BIT:
			case BinXmlToken.SQL_TINYINT:
			case BinXmlToken.SQL_BIGINT:
				break;
			case BinXmlToken.SQL_REAL:
				return (double)this.GetSingle(this.tokDataPos);
			case BinXmlToken.SQL_FLOAT:
				return this.GetDouble(this.tokDataPos);
			case BinXmlToken.SQL_MONEY:
			case BinXmlToken.SQL_DECIMAL:
			case BinXmlToken.SQL_NUMERIC:
			case BinXmlToken.SQL_SMALLMONEY:
				goto IL_B3;
			case BinXmlToken.SQL_UUID:
			case BinXmlToken.SQL_BINARY:
			case BinXmlToken.SQL_CHAR:
			case BinXmlToken.SQL_NCHAR:
			case BinXmlToken.SQL_VARBINARY:
			case BinXmlToken.SQL_VARCHAR:
			case BinXmlToken.SQL_NVARCHAR:
			case BinXmlToken.SQL_DATETIME:
			case BinXmlToken.SQL_SMALLDATETIME:
				goto IL_C0;
			default:
				switch (binXmlToken)
				{
				case BinXmlToken.XSD_DECIMAL:
					goto IL_B3;
				case BinXmlToken.XSD_BYTE:
				case BinXmlToken.XSD_UNSIGNEDSHORT:
				case BinXmlToken.XSD_UNSIGNEDINT:
					break;
				case BinXmlToken.XSD_UNSIGNEDLONG:
					return this.ValueAsULong();
				default:
					goto IL_C0;
				}
				break;
			}
			return (double)this.ValueAsLong();
			IL_B3:
			return (double)this.ValueAsDecimal();
			IL_C0:
			throw this.ThrowUnexpectedToken(this.token);
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00007568 File Offset: 0x00005768
		private string ValueAsDateTimeString()
		{
			this.CheckValueTokenBounds();
			BinXmlToken binXmlToken = this.token;
			if (binXmlToken == BinXmlToken.SQL_DATETIME)
			{
				int num = this.tokDataPos;
				int @int = this.GetInt32(num);
				uint @uint = this.GetUInt32(num + 4);
				return BinXmlDateTime.SqlDateTimeToString(@int, @uint);
			}
			if (binXmlToken != BinXmlToken.SQL_SMALLDATETIME)
			{
				switch (binXmlToken)
				{
				case BinXmlToken.XSD_KATMAI_TIMEOFFSET:
					return BinXmlDateTime.XsdKatmaiTimeOffsetToString(this.data, this.tokDataPos);
				case BinXmlToken.XSD_KATMAI_DATETIMEOFFSET:
					return BinXmlDateTime.XsdKatmaiDateTimeOffsetToString(this.data, this.tokDataPos);
				case BinXmlToken.XSD_KATMAI_DATEOFFSET:
					return BinXmlDateTime.XsdKatmaiDateOffsetToString(this.data, this.tokDataPos);
				case BinXmlToken.XSD_KATMAI_TIME:
					return BinXmlDateTime.XsdKatmaiTimeToString(this.data, this.tokDataPos);
				case BinXmlToken.XSD_KATMAI_DATETIME:
					return BinXmlDateTime.XsdKatmaiDateTimeToString(this.data, this.tokDataPos);
				case BinXmlToken.XSD_KATMAI_DATE:
					return BinXmlDateTime.XsdKatmaiDateToString(this.data, this.tokDataPos);
				case BinXmlToken.XSD_TIME:
					return BinXmlDateTime.XsdTimeToString(this.GetInt64(this.tokDataPos));
				case BinXmlToken.XSD_DATETIME:
					return BinXmlDateTime.XsdDateTimeToString(this.GetInt64(this.tokDataPos));
				case BinXmlToken.XSD_DATE:
					return BinXmlDateTime.XsdDateToString(this.GetInt64(this.tokDataPos));
				}
				throw this.ThrowUnexpectedToken(this.token);
			}
			int num2 = this.tokDataPos;
			short int2 = this.GetInt16(num2);
			ushort uint2 = this.GetUInt16(num2 + 2);
			return BinXmlDateTime.SqlSmallDateTimeToString(int2, uint2);
		}

		// Token: 0x060000CB RID: 203 RVA: 0x000076B0 File Offset: 0x000058B0
		private string ValueAsString(BinXmlToken token)
		{
			try
			{
				this.CheckValueTokenBounds();
				switch (token)
				{
				case BinXmlToken.SQL_SMALLINT:
				case BinXmlToken.SQL_INT:
				case BinXmlToken.SQL_BIT:
				case BinXmlToken.SQL_TINYINT:
				case BinXmlToken.SQL_BIGINT:
					break;
				case BinXmlToken.SQL_REAL:
					return XmlConvert.ToString(this.GetSingle(this.tokDataPos));
				case BinXmlToken.SQL_FLOAT:
					return XmlConvert.ToString(this.GetDouble(this.tokDataPos));
				case BinXmlToken.SQL_MONEY:
				{
					BinXmlSqlMoney binXmlSqlMoney = new BinXmlSqlMoney(this.GetInt64(this.tokDataPos));
					return binXmlSqlMoney.ToString();
				}
				case BinXmlToken.SQL_UUID:
				{
					int num = this.tokDataPos;
					int @int = this.GetInt32(num);
					short int2 = this.GetInt16(num + 4);
					short int3 = this.GetInt16(num + 6);
					Guid guid = new Guid(@int, int2, int3, this.data[num + 8], this.data[num + 9], this.data[num + 10], this.data[num + 11], this.data[num + 12], this.data[num + 13], this.data[num + 14], this.data[num + 15]);
					return guid.ToString();
				}
				case BinXmlToken.SQL_DECIMAL:
				case BinXmlToken.SQL_NUMERIC:
					goto IL_264;
				case BinXmlToken.SQL_BINARY:
				case BinXmlToken.SQL_VARBINARY:
				case BinXmlToken.SQL_IMAGE:
				case BinXmlToken.SQL_UDT:
					goto IL_2C4;
				case BinXmlToken.SQL_CHAR:
				case BinXmlToken.SQL_VARCHAR:
				case BinXmlToken.SQL_TEXT:
				{
					int num2 = this.tokDataPos;
					return Encoding.GetEncoding(this.GetInt32(num2)).GetString(this.data, num2 + 4, this.tokLen - 4);
				}
				case BinXmlToken.SQL_NCHAR:
				case BinXmlToken.SQL_NVARCHAR:
				case BinXmlToken.SQL_NTEXT:
					return this.GetString(this.tokDataPos, this.tokLen);
				case BinXmlToken.SQL_DATETIME:
				case BinXmlToken.SQL_SMALLDATETIME:
					goto IL_2FE;
				case BinXmlToken.SQL_SMALLMONEY:
				{
					BinXmlSqlMoney binXmlSqlMoney2 = new BinXmlSqlMoney(this.GetInt32(this.tokDataPos));
					return binXmlSqlMoney2.ToString();
				}
				case (BinXmlToken)21:
				case (BinXmlToken)25:
				case (BinXmlToken)26:
					goto IL_383;
				default:
					switch (token)
					{
					case BinXmlToken.XSD_KATMAI_TIMEOFFSET:
					case BinXmlToken.XSD_KATMAI_DATETIMEOFFSET:
					case BinXmlToken.XSD_KATMAI_DATEOFFSET:
					case BinXmlToken.XSD_KATMAI_TIME:
					case BinXmlToken.XSD_KATMAI_DATETIME:
					case BinXmlToken.XSD_KATMAI_DATE:
					case BinXmlToken.XSD_TIME:
					case BinXmlToken.XSD_DATETIME:
					case BinXmlToken.XSD_DATE:
						goto IL_2FE;
					case (BinXmlToken)128:
						goto IL_383;
					case BinXmlToken.XSD_BINHEX:
						return BinHexEncoder.Encode(this.data, this.tokDataPos, this.tokLen);
					case BinXmlToken.XSD_BASE64:
						goto IL_2C4;
					case BinXmlToken.XSD_BOOLEAN:
						if (this.data[this.tokDataPos] == 0)
						{
							return "false";
						}
						return "true";
					case BinXmlToken.XSD_DECIMAL:
						goto IL_264;
					case BinXmlToken.XSD_BYTE:
					case BinXmlToken.XSD_UNSIGNEDSHORT:
					case BinXmlToken.XSD_UNSIGNEDINT:
						break;
					case BinXmlToken.XSD_UNSIGNEDLONG:
						return this.ValueAsULong().ToString(CultureInfo.InvariantCulture);
					case BinXmlToken.XSD_QNAME:
					{
						int num3 = this.ParseMB32(this.tokDataPos);
						if (num3 < 0 || num3 >= this.symbolTables.qnameCount)
						{
							throw new XmlException("Invalid QName ID.", string.Empty);
						}
						XmlSqlBinaryReader.QName qname = this.symbolTables.qnametable[num3];
						if (qname.prefix.Length == 0)
						{
							return qname.localname;
						}
						return qname.prefix + ":" + qname.localname;
					}
					default:
						goto IL_383;
					}
					break;
				}
				return this.ValueAsLong().ToString(CultureInfo.InvariantCulture);
				IL_264:
				BinXmlSqlDecimal binXmlSqlDecimal = new BinXmlSqlDecimal(this.data, this.tokDataPos, token == BinXmlToken.XSD_DECIMAL);
				return binXmlSqlDecimal.ToString();
				IL_2C4:
				return Convert.ToBase64String(this.data, this.tokDataPos, this.tokLen);
				IL_2FE:
				return this.ValueAsDateTimeString();
				IL_383:
				throw this.ThrowUnexpectedToken(this.token);
			}
			catch
			{
				this.state = XmlSqlBinaryReader.ScanState.Error;
				throw;
			}
			string result;
			return result;
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00007A74 File Offset: 0x00005C74
		private short GetInt16(int pos)
		{
			byte[] array = this.data;
			return (short)((int)array[pos] | (int)array[pos + 1] << 8);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00007A94 File Offset: 0x00005C94
		private ushort GetUInt16(int pos)
		{
			byte[] array = this.data;
			return (ushort)((int)array[pos] | (int)array[pos + 1] << 8);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00007AB4 File Offset: 0x00005CB4
		private int GetInt32(int pos)
		{
			byte[] array = this.data;
			return (int)array[pos] | (int)array[pos + 1] << 8 | (int)array[pos + 2] << 16 | (int)array[pos + 3] << 24;
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00007AE8 File Offset: 0x00005CE8
		private uint GetUInt32(int pos)
		{
			byte[] array = this.data;
			return (uint)((int)array[pos] | (int)array[pos + 1] << 8 | (int)array[pos + 2] << 16 | (int)array[pos + 3] << 24);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00007B1C File Offset: 0x00005D1C
		private long GetInt64(int pos)
		{
			byte[] array = this.data;
			uint num = (uint)((int)array[pos] | (int)array[pos + 1] << 8 | (int)array[pos + 2] << 16 | (int)array[pos + 3] << 24);
			return (long)((ulong)((int)array[pos + 4] | (int)array[pos + 5] << 8 | (int)array[pos + 6] << 16 | (int)array[pos + 7] << 24) << 32 | (ulong)num);
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00007B74 File Offset: 0x00005D74
		private ulong GetUInt64(int pos)
		{
			byte[] array = this.data;
			uint num = (uint)((int)array[pos] | (int)array[pos + 1] << 8 | (int)array[pos + 2] << 16 | (int)array[pos + 3] << 24);
			return (ulong)((int)array[pos + 4] | (int)array[pos + 5] << 8 | (int)array[pos + 6] << 16 | (int)array[pos + 7] << 24) << 32 | (ulong)num;
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00007BCC File Offset: 0x00005DCC
		private unsafe float GetSingle(int offset)
		{
			byte[] array = this.data;
			uint num = (uint)((int)array[offset] | (int)array[offset + 1] << 8 | (int)array[offset + 2] << 16 | (int)array[offset + 3] << 24);
			return *(float*)(&num);
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00007C04 File Offset: 0x00005E04
		private unsafe double GetDouble(int offset)
		{
			uint num = (uint)((int)this.data[offset] | (int)this.data[offset + 1] << 8 | (int)this.data[offset + 2] << 16 | (int)this.data[offset + 3] << 24);
			ulong num2 = (ulong)((int)this.data[offset + 4] | (int)this.data[offset + 5] << 8 | (int)this.data[offset + 6] << 16 | (int)this.data[offset + 7] << 24) << 32 | (ulong)num;
			return *(double*)(&num2);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00007C82 File Offset: 0x00005E82
		private Exception ThrowUnexpectedToken(BinXmlToken token)
		{
			return this.ThrowXmlException("Unexpected BinaryXml token.");
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00007C8F File Offset: 0x00005E8F
		private Exception ThrowXmlException(string res)
		{
			this.state = XmlSqlBinaryReader.ScanState.Error;
			return new XmlException(res, null);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00007C9F File Offset: 0x00005E9F
		private Exception ThrowXmlException(string res, string arg1, string arg2)
		{
			this.state = XmlSqlBinaryReader.ScanState.Error;
			return new XmlException(res, new string[]
			{
				arg1,
				arg2
			});
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00007CBC File Offset: 0x00005EBC
		private Exception ThrowNotSupported(string res)
		{
			this.state = XmlSqlBinaryReader.ScanState.Error;
			return new NotSupportedException(Res.GetString(res));
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00004836 File Offset: 0x00002A36
		public override Task<string> GetValueAsync()
		{
			throw new NotSupportedException();
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00004836 File Offset: 0x00002A36
		public override Task<bool> ReadAsync()
		{
			throw new NotSupportedException();
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00004836 File Offset: 0x00002A36
		public override Task<XmlNodeType> MoveToContentAsync()
		{
			throw new NotSupportedException();
		}

		// Token: 0x0400008E RID: 142
		internal static readonly Type TypeOfObject = typeof(object);

		// Token: 0x0400008F RID: 143
		internal static readonly Type TypeOfString = typeof(string);

		// Token: 0x04000090 RID: 144
		private static volatile Type[] TokenTypeMap = null;

		// Token: 0x04000091 RID: 145
		private static byte[] XsdKatmaiTimeScaleToValueLengthMap = new byte[]
		{
			3,
			3,
			3,
			4,
			4,
			5,
			5,
			5
		};

		// Token: 0x04000092 RID: 146
		private static ReadState[] ScanState2ReadState = new ReadState[]
		{
			ReadState.Interactive,
			ReadState.Interactive,
			ReadState.Interactive,
			ReadState.Interactive,
			ReadState.Interactive,
			ReadState.Initial,
			ReadState.Error,
			ReadState.EndOfFile,
			ReadState.Closed
		};

		// Token: 0x04000093 RID: 147
		private Stream inStrm;

		// Token: 0x04000094 RID: 148
		private byte[] data;

		// Token: 0x04000095 RID: 149
		private int pos;

		// Token: 0x04000096 RID: 150
		private int mark;

		// Token: 0x04000097 RID: 151
		private int end;

		// Token: 0x04000098 RID: 152
		private long offset;

		// Token: 0x04000099 RID: 153
		private bool eof;

		// Token: 0x0400009A RID: 154
		private bool sniffed;

		// Token: 0x0400009B RID: 155
		private bool isEmpty;

		// Token: 0x0400009C RID: 156
		private int docState;

		// Token: 0x0400009D RID: 157
		private XmlSqlBinaryReader.SymbolTables symbolTables;

		// Token: 0x0400009E RID: 158
		private XmlNameTable xnt;

		// Token: 0x0400009F RID: 159
		private bool xntFromSettings;

		// Token: 0x040000A0 RID: 160
		private string xml;

		// Token: 0x040000A1 RID: 161
		private string xmlns;

		// Token: 0x040000A2 RID: 162
		private string nsxmlns;

		// Token: 0x040000A3 RID: 163
		private string baseUri;

		// Token: 0x040000A4 RID: 164
		private XmlSqlBinaryReader.ScanState state;

		// Token: 0x040000A5 RID: 165
		private XmlNodeType nodetype;

		// Token: 0x040000A6 RID: 166
		private BinXmlToken token;

		// Token: 0x040000A7 RID: 167
		private int attrIndex;

		// Token: 0x040000A8 RID: 168
		private XmlSqlBinaryReader.QName qnameOther;

		// Token: 0x040000A9 RID: 169
		private XmlSqlBinaryReader.QName qnameElement;

		// Token: 0x040000AA RID: 170
		private XmlNodeType parentNodeType;

		// Token: 0x040000AB RID: 171
		private XmlSqlBinaryReader.ElemInfo[] elementStack;

		// Token: 0x040000AC RID: 172
		private int elemDepth;

		// Token: 0x040000AD RID: 173
		private XmlSqlBinaryReader.AttrInfo[] attributes;

		// Token: 0x040000AE RID: 174
		private int[] attrHashTbl;

		// Token: 0x040000AF RID: 175
		private int attrCount;

		// Token: 0x040000B0 RID: 176
		private int posAfterAttrs;

		// Token: 0x040000B1 RID: 177
		private bool xmlspacePreserve;

		// Token: 0x040000B2 RID: 178
		private int tokLen;

		// Token: 0x040000B3 RID: 179
		private int tokDataPos;

		// Token: 0x040000B4 RID: 180
		private bool hasTypedValue;

		// Token: 0x040000B5 RID: 181
		private Type valueType;

		// Token: 0x040000B6 RID: 182
		private string stringValue;

		// Token: 0x040000B7 RID: 183
		private Dictionary<string, XmlSqlBinaryReader.NamespaceDecl> namespaces;

		// Token: 0x040000B8 RID: 184
		private XmlSqlBinaryReader.NestedBinXml prevNameInfo;

		// Token: 0x040000B9 RID: 185
		private XmlReader textXmlReader;

		// Token: 0x040000BA RID: 186
		private bool closeInput;

		// Token: 0x040000BB RID: 187
		private bool checkCharacters;

		// Token: 0x040000BC RID: 188
		private bool ignoreWhitespace;

		// Token: 0x040000BD RID: 189
		private bool ignorePIs;

		// Token: 0x040000BE RID: 190
		private bool ignoreComments;

		// Token: 0x040000BF RID: 191
		private DtdProcessing dtdProcessing;

		// Token: 0x040000C0 RID: 192
		private SecureStringHasher hasher;

		// Token: 0x040000C1 RID: 193
		private XmlCharType xmlCharType;

		// Token: 0x040000C2 RID: 194
		private Encoding unicode;

		// Token: 0x040000C3 RID: 195
		private byte version;

		// Token: 0x02000015 RID: 21
		private enum ScanState
		{
			// Token: 0x040000C5 RID: 197
			Doc,
			// Token: 0x040000C6 RID: 198
			XmlText,
			// Token: 0x040000C7 RID: 199
			Attr,
			// Token: 0x040000C8 RID: 200
			AttrVal,
			// Token: 0x040000C9 RID: 201
			AttrValPseudoValue,
			// Token: 0x040000CA RID: 202
			Init,
			// Token: 0x040000CB RID: 203
			Error,
			// Token: 0x040000CC RID: 204
			EOF,
			// Token: 0x040000CD RID: 205
			Closed
		}

		// Token: 0x02000016 RID: 22
		internal struct QName
		{
			// Token: 0x060000DC RID: 220 RVA: 0x00007D30 File Offset: 0x00005F30
			public QName(string prefix, string lname, string nsUri)
			{
				this.prefix = prefix;
				this.localname = lname;
				this.namespaceUri = nsUri;
			}

			// Token: 0x060000DD RID: 221 RVA: 0x00007D30 File Offset: 0x00005F30
			public void Set(string prefix, string lname, string nsUri)
			{
				this.prefix = prefix;
				this.localname = lname;
				this.namespaceUri = nsUri;
			}

			// Token: 0x060000DE RID: 222 RVA: 0x00007D48 File Offset: 0x00005F48
			public void Clear()
			{
				this.prefix = (this.localname = (this.namespaceUri = string.Empty));
			}

			// Token: 0x060000DF RID: 223 RVA: 0x00007D72 File Offset: 0x00005F72
			public bool MatchNs(string lname, string nsUri)
			{
				return lname == this.localname && nsUri == this.namespaceUri;
			}

			// Token: 0x060000E0 RID: 224 RVA: 0x00007D90 File Offset: 0x00005F90
			public bool MatchPrefix(string prefix, string lname)
			{
				return lname == this.localname && prefix == this.prefix;
			}

			// Token: 0x060000E1 RID: 225 RVA: 0x00007DAE File Offset: 0x00005FAE
			public void CheckPrefixNS(string prefix, string namespaceUri)
			{
				if (this.prefix == prefix && this.namespaceUri != namespaceUri)
				{
					throw new XmlException("Prefix '{0}' is already assigned to namespace '{1}' and cannot be reassigned to '{2}' on this tag.", new string[]
					{
						prefix,
						this.namespaceUri,
						namespaceUri
					});
				}
			}

			// Token: 0x060000E2 RID: 226 RVA: 0x00007DEE File Offset: 0x00005FEE
			public override int GetHashCode()
			{
				return this.prefix.GetHashCode() ^ this.localname.GetHashCode();
			}

			// Token: 0x060000E3 RID: 227 RVA: 0x00007E07 File Offset: 0x00006007
			public int GetNSHashCode(SecureStringHasher hasher)
			{
				return hasher.GetHashCode(this.namespaceUri) ^ hasher.GetHashCode(this.localname);
			}

			// Token: 0x060000E4 RID: 228 RVA: 0x00007E24 File Offset: 0x00006024
			public override bool Equals(object other)
			{
				if (other is XmlSqlBinaryReader.QName)
				{
					XmlSqlBinaryReader.QName b = (XmlSqlBinaryReader.QName)other;
					return this == b;
				}
				return false;
			}

			// Token: 0x060000E5 RID: 229 RVA: 0x00007E4E File Offset: 0x0000604E
			public override string ToString()
			{
				if (this.prefix.Length == 0)
				{
					return this.localname;
				}
				return this.prefix + ":" + this.localname;
			}

			// Token: 0x060000E6 RID: 230 RVA: 0x00007E7A File Offset: 0x0000607A
			public static bool operator ==(XmlSqlBinaryReader.QName a, XmlSqlBinaryReader.QName b)
			{
				return a.prefix == b.prefix && a.localname == b.localname && a.namespaceUri == b.namespaceUri;
			}

			// Token: 0x040000CE RID: 206
			public string prefix;

			// Token: 0x040000CF RID: 207
			public string localname;

			// Token: 0x040000D0 RID: 208
			public string namespaceUri;
		}

		// Token: 0x02000017 RID: 23
		private struct ElemInfo
		{
			// Token: 0x060000E7 RID: 231 RVA: 0x00007EB5 File Offset: 0x000060B5
			public void Set(XmlSqlBinaryReader.QName name, bool xmlspacePreserve)
			{
				this.name = name;
				this.xmlLang = null;
				this.xmlSpace = XmlSpace.None;
				this.xmlspacePreserve = xmlspacePreserve;
			}

			// Token: 0x060000E8 RID: 232 RVA: 0x00007ED3 File Offset: 0x000060D3
			public XmlSqlBinaryReader.NamespaceDecl Clear()
			{
				XmlSqlBinaryReader.NamespaceDecl result = this.nsdecls;
				this.nsdecls = null;
				return result;
			}

			// Token: 0x040000D1 RID: 209
			public XmlSqlBinaryReader.QName name;

			// Token: 0x040000D2 RID: 210
			public string xmlLang;

			// Token: 0x040000D3 RID: 211
			public XmlSpace xmlSpace;

			// Token: 0x040000D4 RID: 212
			public bool xmlspacePreserve;

			// Token: 0x040000D5 RID: 213
			public XmlSqlBinaryReader.NamespaceDecl nsdecls;
		}

		// Token: 0x02000018 RID: 24
		private struct AttrInfo
		{
			// Token: 0x060000E9 RID: 233 RVA: 0x00007EE2 File Offset: 0x000060E2
			public void Set(XmlSqlBinaryReader.QName n, string v)
			{
				this.name = n;
				this.val = v;
				this.contentPos = 0;
				this.hashCode = 0;
				this.prevHash = 0;
			}

			// Token: 0x060000EA RID: 234 RVA: 0x00007F07 File Offset: 0x00006107
			public void Set(XmlSqlBinaryReader.QName n, int pos)
			{
				this.name = n;
				this.val = null;
				this.contentPos = pos;
				this.hashCode = 0;
				this.prevHash = 0;
			}

			// Token: 0x060000EB RID: 235 RVA: 0x00007F2C File Offset: 0x0000612C
			public void GetLocalnameAndNamespaceUri(out string localname, out string namespaceUri)
			{
				localname = this.name.localname;
				namespaceUri = this.name.namespaceUri;
			}

			// Token: 0x060000EC RID: 236 RVA: 0x00007F48 File Offset: 0x00006148
			public int GetLocalnameAndNamespaceUriAndHash(SecureStringHasher hasher, out string localname, out string namespaceUri)
			{
				localname = this.name.localname;
				namespaceUri = this.name.namespaceUri;
				return this.hashCode = this.name.GetNSHashCode(hasher);
			}

			// Token: 0x060000ED RID: 237 RVA: 0x00007F84 File Offset: 0x00006184
			public bool MatchNS(string localname, string namespaceUri)
			{
				return this.name.MatchNs(localname, namespaceUri);
			}

			// Token: 0x060000EE RID: 238 RVA: 0x00007F93 File Offset: 0x00006193
			public bool MatchHashNS(int hash, string localname, string namespaceUri)
			{
				return this.hashCode == hash && this.name.MatchNs(localname, namespaceUri);
			}

			// Token: 0x060000EF RID: 239 RVA: 0x00007FAD File Offset: 0x000061AD
			public void AdjustPosition(int adj)
			{
				if (this.contentPos != 0)
				{
					this.contentPos += adj;
				}
			}

			// Token: 0x040000D6 RID: 214
			public XmlSqlBinaryReader.QName name;

			// Token: 0x040000D7 RID: 215
			public string val;

			// Token: 0x040000D8 RID: 216
			public int contentPos;

			// Token: 0x040000D9 RID: 217
			public int hashCode;

			// Token: 0x040000DA RID: 218
			public int prevHash;
		}

		// Token: 0x02000019 RID: 25
		private class NamespaceDecl
		{
			// Token: 0x060000F0 RID: 240 RVA: 0x00007FC5 File Offset: 0x000061C5
			public NamespaceDecl(string prefix, string nsuri, XmlSqlBinaryReader.NamespaceDecl nextInScope, XmlSqlBinaryReader.NamespaceDecl prevDecl, int scope, bool implied)
			{
				this.prefix = prefix;
				this.uri = nsuri;
				this.scopeLink = nextInScope;
				this.prevLink = prevDecl;
				this.scope = scope;
				this.implied = implied;
			}

			// Token: 0x040000DB RID: 219
			public string prefix;

			// Token: 0x040000DC RID: 220
			public string uri;

			// Token: 0x040000DD RID: 221
			public XmlSqlBinaryReader.NamespaceDecl scopeLink;

			// Token: 0x040000DE RID: 222
			public XmlSqlBinaryReader.NamespaceDecl prevLink;

			// Token: 0x040000DF RID: 223
			public int scope;

			// Token: 0x040000E0 RID: 224
			public bool implied;
		}

		// Token: 0x0200001A RID: 26
		private struct SymbolTables
		{
			// Token: 0x060000F1 RID: 241 RVA: 0x00007FFA File Offset: 0x000061FA
			public void Init()
			{
				this.symtable = new string[64];
				this.qnametable = new XmlSqlBinaryReader.QName[16];
				this.symtable[0] = string.Empty;
				this.symCount = 1;
				this.qnameCount = 1;
			}

			// Token: 0x040000E1 RID: 225
			public string[] symtable;

			// Token: 0x040000E2 RID: 226
			public int symCount;

			// Token: 0x040000E3 RID: 227
			public XmlSqlBinaryReader.QName[] qnametable;

			// Token: 0x040000E4 RID: 228
			public int qnameCount;
		}

		// Token: 0x0200001B RID: 27
		private class NestedBinXml
		{
			// Token: 0x060000F2 RID: 242 RVA: 0x00008031 File Offset: 0x00006231
			public NestedBinXml(XmlSqlBinaryReader.SymbolTables symbolTables, int docState, XmlSqlBinaryReader.NestedBinXml next)
			{
				this.symbolTables = symbolTables;
				this.docState = docState;
				this.next = next;
			}

			// Token: 0x040000E5 RID: 229
			public XmlSqlBinaryReader.SymbolTables symbolTables;

			// Token: 0x040000E6 RID: 230
			public int docState;

			// Token: 0x040000E7 RID: 231
			public XmlSqlBinaryReader.NestedBinXml next;
		}
	}
}
