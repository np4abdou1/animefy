using System;
using System.Threading.Tasks;

namespace System.Xml
{
	// Token: 0x02000074 RID: 116
	internal abstract class XmlRawWriter : XmlWriter
	{
		// Token: 0x060003DD RID: 989 RVA: 0x00008B54 File Offset: 0x00006D54
		public override void WriteStartDocument()
		{
			throw new InvalidOperationException(Res.GetString("Operation is not valid due to the current state of the object."));
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00008B54 File Offset: 0x00006D54
		public override void WriteStartDocument(bool standalone)
		{
			throw new InvalidOperationException(Res.GetString("Operation is not valid due to the current state of the object."));
		}

		// Token: 0x060003DF RID: 991 RVA: 0x00008B54 File Offset: 0x00006D54
		public override void WriteEndDocument()
		{
			throw new InvalidOperationException(Res.GetString("Operation is not valid due to the current state of the object."));
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x00008574 File Offset: 0x00006774
		public override void WriteDocType(string name, string pubid, string sysid, string subset)
		{
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x00008B54 File Offset: 0x00006D54
		public override void WriteEndElement()
		{
			throw new InvalidOperationException(Res.GetString("Operation is not valid due to the current state of the object."));
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x00008B54 File Offset: 0x00006D54
		public override void WriteFullEndElement()
		{
			throw new InvalidOperationException(Res.GetString("Operation is not valid due to the current state of the object."));
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x00015119 File Offset: 0x00013319
		public override void WriteBase64(byte[] buffer, int index, int count)
		{
			if (this.base64Encoder == null)
			{
				this.base64Encoder = new XmlRawWriterBase64Encoder(this);
			}
			this.base64Encoder.Encode(buffer, index, count);
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x00008B54 File Offset: 0x00006D54
		public override string LookupPrefix(string ns)
		{
			throw new InvalidOperationException(Res.GetString("Operation is not valid due to the current state of the object."));
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060003E5 RID: 997 RVA: 0x00008B54 File Offset: 0x00006D54
		public override WriteState WriteState
		{
			get
			{
				throw new InvalidOperationException(Res.GetString("Operation is not valid due to the current state of the object."));
			}
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x00014BE9 File Offset: 0x00012DE9
		public override void WriteCData(string text)
		{
			this.WriteString(text);
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x0001513D File Offset: 0x0001333D
		public override void WriteCharEntity(char ch)
		{
			this.WriteString(new string(new char[]
			{
				ch
			}));
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00015154 File Offset: 0x00013354
		public override void WriteSurrogateCharEntity(char lowChar, char highChar)
		{
			this.WriteString(new string(new char[]
			{
				lowChar,
				highChar
			}));
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x00014BE9 File Offset: 0x00012DE9
		public override void WriteWhitespace(string ws)
		{
			this.WriteString(ws);
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x0000BD85 File Offset: 0x00009F85
		public override void WriteChars(char[] buffer, int index, int count)
		{
			this.WriteString(new string(buffer, index, count));
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x0000BD85 File Offset: 0x00009F85
		public override void WriteRaw(char[] buffer, int index, int count)
		{
			this.WriteString(new string(buffer, index, count));
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x00014BE9 File Offset: 0x00012DE9
		public override void WriteRaw(string data)
		{
			this.WriteString(data);
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x00014BE9 File Offset: 0x00012DE9
		public override void WriteValue(string value)
		{
			this.WriteString(value);
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x00008B54 File Offset: 0x00006D54
		public override void WriteAttributes(XmlReader reader, bool defattr)
		{
			throw new InvalidOperationException(Res.GetString("Operation is not valid due to the current state of the object."));
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x00008B54 File Offset: 0x00006D54
		public override void WriteNode(XmlReader reader, bool defattr)
		{
			throw new InvalidOperationException(Res.GetString("Operation is not valid due to the current state of the object."));
		}

		// Token: 0x1700008B RID: 139
		// (set) Token: 0x060003F0 RID: 1008 RVA: 0x0001516F File Offset: 0x0001336F
		internal virtual IXmlNamespaceResolver NamespaceResolver
		{
			set
			{
				this.resolver = value;
			}
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x00008574 File Offset: 0x00006774
		internal virtual void WriteXmlDeclaration(XmlStandalone standalone)
		{
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x00008574 File Offset: 0x00006774
		internal virtual void WriteXmlDeclaration(string xmldecl)
		{
		}

		// Token: 0x060003F3 RID: 1011
		internal abstract void StartElementContent();

		// Token: 0x060003F4 RID: 1012 RVA: 0x00008574 File Offset: 0x00006774
		internal virtual void OnRootElement(ConformanceLevel conformanceLevel)
		{
		}

		// Token: 0x060003F5 RID: 1013
		internal abstract void WriteEndElement(string prefix, string localName, string ns);

		// Token: 0x060003F6 RID: 1014 RVA: 0x00015178 File Offset: 0x00013378
		internal virtual void WriteFullEndElement(string prefix, string localName, string ns)
		{
			this.WriteEndElement(prefix, localName, ns);
		}

		// Token: 0x060003F7 RID: 1015
		internal abstract void WriteNamespaceDeclaration(string prefix, string ns);

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060003F8 RID: 1016 RVA: 0x0000A216 File Offset: 0x00008416
		internal virtual bool SupportsNamespaceDeclarationInChunks
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x00004836 File Offset: 0x00002A36
		internal virtual void WriteStartNamespaceDeclaration(string prefix)
		{
			throw new NotSupportedException();
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x00004836 File Offset: 0x00002A36
		internal virtual void WriteEndNamespaceDeclaration()
		{
			throw new NotSupportedException();
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x00015183 File Offset: 0x00013383
		internal virtual void WriteEndBase64()
		{
			this.base64Encoder.Flush();
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x00015190 File Offset: 0x00013390
		internal virtual void Close(WriteState currentState)
		{
			this.Close();
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x00008B54 File Offset: 0x00006D54
		public override Task WriteStartDocumentAsync()
		{
			throw new InvalidOperationException(Res.GetString("Operation is not valid due to the current state of the object."));
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x00008B54 File Offset: 0x00006D54
		public override Task WriteStartDocumentAsync(bool standalone)
		{
			throw new InvalidOperationException(Res.GetString("Operation is not valid due to the current state of the object."));
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x00008B54 File Offset: 0x00006D54
		public override Task WriteEndDocumentAsync()
		{
			throw new InvalidOperationException(Res.GetString("Operation is not valid due to the current state of the object."));
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x00015198 File Offset: 0x00013398
		public override Task WriteDocTypeAsync(string name, string pubid, string sysid, string subset)
		{
			return AsyncHelper.DoneTask;
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x00008B54 File Offset: 0x00006D54
		public override Task WriteEndElementAsync()
		{
			throw new InvalidOperationException(Res.GetString("Operation is not valid due to the current state of the object."));
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x00008B54 File Offset: 0x00006D54
		public override Task WriteFullEndElementAsync()
		{
			throw new InvalidOperationException(Res.GetString("Operation is not valid due to the current state of the object."));
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x0001519F File Offset: 0x0001339F
		public override Task WriteCDataAsync(string text)
		{
			return this.WriteStringAsync(text);
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x000151A8 File Offset: 0x000133A8
		public override Task WriteCharEntityAsync(char ch)
		{
			return this.WriteStringAsync(new string(new char[]
			{
				ch
			}));
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x000151BF File Offset: 0x000133BF
		public override Task WriteSurrogateCharEntityAsync(char lowChar, char highChar)
		{
			return this.WriteStringAsync(new string(new char[]
			{
				lowChar,
				highChar
			}));
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x0001519F File Offset: 0x0001339F
		public override Task WriteWhitespaceAsync(string ws)
		{
			return this.WriteStringAsync(ws);
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x000151DA File Offset: 0x000133DA
		public override Task WriteCharsAsync(char[] buffer, int index, int count)
		{
			return this.WriteStringAsync(new string(buffer, index, count));
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x000151DA File Offset: 0x000133DA
		public override Task WriteRawAsync(char[] buffer, int index, int count)
		{
			return this.WriteStringAsync(new string(buffer, index, count));
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x0001519F File Offset: 0x0001339F
		public override Task WriteRawAsync(string data)
		{
			return this.WriteStringAsync(data);
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x00015198 File Offset: 0x00013398
		internal virtual Task WriteXmlDeclarationAsync(XmlStandalone standalone)
		{
			return AsyncHelper.DoneTask;
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x00015198 File Offset: 0x00013398
		internal virtual Task WriteXmlDeclarationAsync(string xmldecl)
		{
			return AsyncHelper.DoneTask;
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x00002B48 File Offset: 0x00000D48
		internal virtual Task WriteEndElementAsync(string prefix, string localName, string ns)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x000151EA File Offset: 0x000133EA
		internal virtual Task WriteFullEndElementAsync(string prefix, string localName, string ns)
		{
			return this.WriteEndElementAsync(prefix, localName, ns);
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x00002B48 File Offset: 0x00000D48
		internal virtual Task WriteNamespaceDeclarationAsync(string prefix, string ns)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x00004836 File Offset: 0x00002A36
		internal virtual Task WriteStartNamespaceDeclarationAsync(string prefix)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x00004836 File Offset: 0x00002A36
		internal virtual Task WriteEndNamespaceDeclarationAsync()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x000151F5 File Offset: 0x000133F5
		internal virtual Task WriteEndBase64Async()
		{
			return this.base64Encoder.FlushAsync();
		}

		// Token: 0x040002B1 RID: 689
		protected XmlRawWriterBase64Encoder base64Encoder;

		// Token: 0x040002B2 RID: 690
		protected IXmlNamespaceResolver resolver;
	}
}
