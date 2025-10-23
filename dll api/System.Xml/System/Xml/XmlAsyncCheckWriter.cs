using System;
using System.Threading.Tasks;

namespace System.Xml
{
	// Token: 0x0200004D RID: 77
	internal class XmlAsyncCheckWriter : XmlWriter
	{
		// Token: 0x0600026B RID: 619 RVA: 0x0000B631 File Offset: 0x00009831
		public XmlAsyncCheckWriter(XmlWriter writer)
		{
			this.coreWriter = writer;
		}

		// Token: 0x0600026C RID: 620 RVA: 0x0000B64B File Offset: 0x0000984B
		private void CheckAsync()
		{
			if (!this.lastTask.IsCompleted)
			{
				throw new InvalidOperationException(Res.GetString("An asynchronous operation is already in progress."));
			}
		}

		// Token: 0x0600026D RID: 621 RVA: 0x0000B66A File Offset: 0x0000986A
		public override void WriteStartDocument()
		{
			this.CheckAsync();
			this.coreWriter.WriteStartDocument();
		}

		// Token: 0x0600026E RID: 622 RVA: 0x0000B67D File Offset: 0x0000987D
		public override void WriteStartDocument(bool standalone)
		{
			this.CheckAsync();
			this.coreWriter.WriteStartDocument(standalone);
		}

		// Token: 0x0600026F RID: 623 RVA: 0x0000B691 File Offset: 0x00009891
		public override void WriteEndDocument()
		{
			this.CheckAsync();
			this.coreWriter.WriteEndDocument();
		}

		// Token: 0x06000270 RID: 624 RVA: 0x0000B6A4 File Offset: 0x000098A4
		public override void WriteDocType(string name, string pubid, string sysid, string subset)
		{
			this.CheckAsync();
			this.coreWriter.WriteDocType(name, pubid, sysid, subset);
		}

		// Token: 0x06000271 RID: 625 RVA: 0x0000B6BC File Offset: 0x000098BC
		public override void WriteStartElement(string prefix, string localName, string ns)
		{
			this.CheckAsync();
			this.coreWriter.WriteStartElement(prefix, localName, ns);
		}

		// Token: 0x06000272 RID: 626 RVA: 0x0000B6D2 File Offset: 0x000098D2
		public override void WriteEndElement()
		{
			this.CheckAsync();
			this.coreWriter.WriteEndElement();
		}

		// Token: 0x06000273 RID: 627 RVA: 0x0000B6E5 File Offset: 0x000098E5
		public override void WriteFullEndElement()
		{
			this.CheckAsync();
			this.coreWriter.WriteFullEndElement();
		}

		// Token: 0x06000274 RID: 628 RVA: 0x0000B6F8 File Offset: 0x000098F8
		public override void WriteStartAttribute(string prefix, string localName, string ns)
		{
			this.CheckAsync();
			this.coreWriter.WriteStartAttribute(prefix, localName, ns);
		}

		// Token: 0x06000275 RID: 629 RVA: 0x0000B70E File Offset: 0x0000990E
		public override void WriteEndAttribute()
		{
			this.CheckAsync();
			this.coreWriter.WriteEndAttribute();
		}

		// Token: 0x06000276 RID: 630 RVA: 0x0000B721 File Offset: 0x00009921
		public override void WriteCData(string text)
		{
			this.CheckAsync();
			this.coreWriter.WriteCData(text);
		}

		// Token: 0x06000277 RID: 631 RVA: 0x0000B735 File Offset: 0x00009935
		public override void WriteComment(string text)
		{
			this.CheckAsync();
			this.coreWriter.WriteComment(text);
		}

		// Token: 0x06000278 RID: 632 RVA: 0x0000B749 File Offset: 0x00009949
		public override void WriteProcessingInstruction(string name, string text)
		{
			this.CheckAsync();
			this.coreWriter.WriteProcessingInstruction(name, text);
		}

		// Token: 0x06000279 RID: 633 RVA: 0x0000B75E File Offset: 0x0000995E
		public override void WriteEntityRef(string name)
		{
			this.CheckAsync();
			this.coreWriter.WriteEntityRef(name);
		}

		// Token: 0x0600027A RID: 634 RVA: 0x0000B772 File Offset: 0x00009972
		public override void WriteCharEntity(char ch)
		{
			this.CheckAsync();
			this.coreWriter.WriteCharEntity(ch);
		}

		// Token: 0x0600027B RID: 635 RVA: 0x0000B786 File Offset: 0x00009986
		public override void WriteWhitespace(string ws)
		{
			this.CheckAsync();
			this.coreWriter.WriteWhitespace(ws);
		}

		// Token: 0x0600027C RID: 636 RVA: 0x0000B79A File Offset: 0x0000999A
		public override void WriteString(string text)
		{
			this.CheckAsync();
			this.coreWriter.WriteString(text);
		}

		// Token: 0x0600027D RID: 637 RVA: 0x0000B7AE File Offset: 0x000099AE
		public override void WriteSurrogateCharEntity(char lowChar, char highChar)
		{
			this.CheckAsync();
			this.coreWriter.WriteSurrogateCharEntity(lowChar, highChar);
		}

		// Token: 0x0600027E RID: 638 RVA: 0x0000B7C3 File Offset: 0x000099C3
		public override void WriteChars(char[] buffer, int index, int count)
		{
			this.CheckAsync();
			this.coreWriter.WriteChars(buffer, index, count);
		}

		// Token: 0x0600027F RID: 639 RVA: 0x0000B7D9 File Offset: 0x000099D9
		public override void WriteRaw(char[] buffer, int index, int count)
		{
			this.CheckAsync();
			this.coreWriter.WriteRaw(buffer, index, count);
		}

		// Token: 0x06000280 RID: 640 RVA: 0x0000B7EF File Offset: 0x000099EF
		public override void WriteRaw(string data)
		{
			this.CheckAsync();
			this.coreWriter.WriteRaw(data);
		}

		// Token: 0x06000281 RID: 641 RVA: 0x0000B803 File Offset: 0x00009A03
		public override void WriteBase64(byte[] buffer, int index, int count)
		{
			this.CheckAsync();
			this.coreWriter.WriteBase64(buffer, index, count);
		}

		// Token: 0x06000282 RID: 642 RVA: 0x0000B819 File Offset: 0x00009A19
		public override void WriteBinHex(byte[] buffer, int index, int count)
		{
			this.CheckAsync();
			this.coreWriter.WriteBinHex(buffer, index, count);
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000283 RID: 643 RVA: 0x0000B82F File Offset: 0x00009A2F
		public override WriteState WriteState
		{
			get
			{
				this.CheckAsync();
				return this.coreWriter.WriteState;
			}
		}

		// Token: 0x06000284 RID: 644 RVA: 0x0000B842 File Offset: 0x00009A42
		public override void Close()
		{
			this.CheckAsync();
			this.coreWriter.Close();
		}

		// Token: 0x06000285 RID: 645 RVA: 0x0000B855 File Offset: 0x00009A55
		public override void Flush()
		{
			this.CheckAsync();
			this.coreWriter.Flush();
		}

		// Token: 0x06000286 RID: 646 RVA: 0x0000B868 File Offset: 0x00009A68
		public override string LookupPrefix(string ns)
		{
			this.CheckAsync();
			return this.coreWriter.LookupPrefix(ns);
		}

		// Token: 0x06000287 RID: 647 RVA: 0x0000B87C File Offset: 0x00009A7C
		public override void WriteValue(string value)
		{
			this.CheckAsync();
			this.coreWriter.WriteValue(value);
		}

		// Token: 0x06000288 RID: 648 RVA: 0x0000B890 File Offset: 0x00009A90
		public override void WriteAttributes(XmlReader reader, bool defattr)
		{
			this.CheckAsync();
			this.coreWriter.WriteAttributes(reader, defattr);
		}

		// Token: 0x06000289 RID: 649 RVA: 0x0000B8A5 File Offset: 0x00009AA5
		public override void WriteNode(XmlReader reader, bool defattr)
		{
			this.CheckAsync();
			this.coreWriter.WriteNode(reader, defattr);
		}

		// Token: 0x0600028A RID: 650 RVA: 0x0000B8BA File Offset: 0x00009ABA
		protected override void Dispose(bool disposing)
		{
			this.CheckAsync();
			this.coreWriter.Dispose();
		}

		// Token: 0x0600028B RID: 651 RVA: 0x0000B8D0 File Offset: 0x00009AD0
		public override Task WriteStartDocumentAsync()
		{
			this.CheckAsync();
			Task result = this.coreWriter.WriteStartDocumentAsync();
			this.lastTask = result;
			return result;
		}

		// Token: 0x0600028C RID: 652 RVA: 0x0000B8F8 File Offset: 0x00009AF8
		public override Task WriteStartDocumentAsync(bool standalone)
		{
			this.CheckAsync();
			Task result = this.coreWriter.WriteStartDocumentAsync(standalone);
			this.lastTask = result;
			return result;
		}

		// Token: 0x0600028D RID: 653 RVA: 0x0000B920 File Offset: 0x00009B20
		public override Task WriteEndDocumentAsync()
		{
			this.CheckAsync();
			Task result = this.coreWriter.WriteEndDocumentAsync();
			this.lastTask = result;
			return result;
		}

		// Token: 0x0600028E RID: 654 RVA: 0x0000B948 File Offset: 0x00009B48
		public override Task WriteDocTypeAsync(string name, string pubid, string sysid, string subset)
		{
			this.CheckAsync();
			Task result = this.coreWriter.WriteDocTypeAsync(name, pubid, sysid, subset);
			this.lastTask = result;
			return result;
		}

		// Token: 0x0600028F RID: 655 RVA: 0x0000B974 File Offset: 0x00009B74
		public override Task WriteStartElementAsync(string prefix, string localName, string ns)
		{
			this.CheckAsync();
			Task result = this.coreWriter.WriteStartElementAsync(prefix, localName, ns);
			this.lastTask = result;
			return result;
		}

		// Token: 0x06000290 RID: 656 RVA: 0x0000B9A0 File Offset: 0x00009BA0
		public override Task WriteEndElementAsync()
		{
			this.CheckAsync();
			Task result = this.coreWriter.WriteEndElementAsync();
			this.lastTask = result;
			return result;
		}

		// Token: 0x06000291 RID: 657 RVA: 0x0000B9C8 File Offset: 0x00009BC8
		public override Task WriteFullEndElementAsync()
		{
			this.CheckAsync();
			Task result = this.coreWriter.WriteFullEndElementAsync();
			this.lastTask = result;
			return result;
		}

		// Token: 0x06000292 RID: 658 RVA: 0x0000B9F0 File Offset: 0x00009BF0
		protected internal override Task WriteStartAttributeAsync(string prefix, string localName, string ns)
		{
			this.CheckAsync();
			Task result = this.coreWriter.WriteStartAttributeAsync(prefix, localName, ns);
			this.lastTask = result;
			return result;
		}

		// Token: 0x06000293 RID: 659 RVA: 0x0000BA1C File Offset: 0x00009C1C
		protected internal override Task WriteEndAttributeAsync()
		{
			this.CheckAsync();
			Task result = this.coreWriter.WriteEndAttributeAsync();
			this.lastTask = result;
			return result;
		}

		// Token: 0x06000294 RID: 660 RVA: 0x0000BA44 File Offset: 0x00009C44
		public override Task WriteCDataAsync(string text)
		{
			this.CheckAsync();
			Task result = this.coreWriter.WriteCDataAsync(text);
			this.lastTask = result;
			return result;
		}

		// Token: 0x06000295 RID: 661 RVA: 0x0000BA6C File Offset: 0x00009C6C
		public override Task WriteCommentAsync(string text)
		{
			this.CheckAsync();
			Task result = this.coreWriter.WriteCommentAsync(text);
			this.lastTask = result;
			return result;
		}

		// Token: 0x06000296 RID: 662 RVA: 0x0000BA94 File Offset: 0x00009C94
		public override Task WriteProcessingInstructionAsync(string name, string text)
		{
			this.CheckAsync();
			Task result = this.coreWriter.WriteProcessingInstructionAsync(name, text);
			this.lastTask = result;
			return result;
		}

		// Token: 0x06000297 RID: 663 RVA: 0x0000BAC0 File Offset: 0x00009CC0
		public override Task WriteEntityRefAsync(string name)
		{
			this.CheckAsync();
			Task result = this.coreWriter.WriteEntityRefAsync(name);
			this.lastTask = result;
			return result;
		}

		// Token: 0x06000298 RID: 664 RVA: 0x0000BAE8 File Offset: 0x00009CE8
		public override Task WriteCharEntityAsync(char ch)
		{
			this.CheckAsync();
			Task result = this.coreWriter.WriteCharEntityAsync(ch);
			this.lastTask = result;
			return result;
		}

		// Token: 0x06000299 RID: 665 RVA: 0x0000BB10 File Offset: 0x00009D10
		public override Task WriteWhitespaceAsync(string ws)
		{
			this.CheckAsync();
			Task result = this.coreWriter.WriteWhitespaceAsync(ws);
			this.lastTask = result;
			return result;
		}

		// Token: 0x0600029A RID: 666 RVA: 0x0000BB38 File Offset: 0x00009D38
		public override Task WriteStringAsync(string text)
		{
			this.CheckAsync();
			Task result = this.coreWriter.WriteStringAsync(text);
			this.lastTask = result;
			return result;
		}

		// Token: 0x0600029B RID: 667 RVA: 0x0000BB60 File Offset: 0x00009D60
		public override Task WriteSurrogateCharEntityAsync(char lowChar, char highChar)
		{
			this.CheckAsync();
			Task result = this.coreWriter.WriteSurrogateCharEntityAsync(lowChar, highChar);
			this.lastTask = result;
			return result;
		}

		// Token: 0x0600029C RID: 668 RVA: 0x0000BB8C File Offset: 0x00009D8C
		public override Task WriteCharsAsync(char[] buffer, int index, int count)
		{
			this.CheckAsync();
			Task result = this.coreWriter.WriteCharsAsync(buffer, index, count);
			this.lastTask = result;
			return result;
		}

		// Token: 0x0600029D RID: 669 RVA: 0x0000BBB8 File Offset: 0x00009DB8
		public override Task WriteRawAsync(char[] buffer, int index, int count)
		{
			this.CheckAsync();
			Task result = this.coreWriter.WriteRawAsync(buffer, index, count);
			this.lastTask = result;
			return result;
		}

		// Token: 0x0600029E RID: 670 RVA: 0x0000BBE4 File Offset: 0x00009DE4
		public override Task WriteRawAsync(string data)
		{
			this.CheckAsync();
			Task result = this.coreWriter.WriteRawAsync(data);
			this.lastTask = result;
			return result;
		}

		// Token: 0x0400017A RID: 378
		private readonly XmlWriter coreWriter;

		// Token: 0x0400017B RID: 379
		private Task lastTask = AsyncHelper.DoneTask;
	}
}
