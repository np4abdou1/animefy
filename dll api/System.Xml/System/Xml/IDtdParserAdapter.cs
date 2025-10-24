using System;
using System.Text;
using System.Threading.Tasks;

namespace System.Xml
{
	// Token: 0x0200002F RID: 47
	internal interface IDtdParserAdapter
	{
		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000174 RID: 372
		XmlNameTable NameTable { get; }

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000175 RID: 373
		IXmlNamespaceResolver NamespaceResolver { get; }

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000176 RID: 374
		Uri BaseUri { get; }

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000177 RID: 375
		char[] ParsingBuffer { get; }

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000178 RID: 376
		int ParsingBufferLength { get; }

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000179 RID: 377
		// (set) Token: 0x0600017A RID: 378
		int CurrentPosition { get; set; }

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600017B RID: 379
		int LineNo { get; }

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600017C RID: 380
		int LineStartPosition { get; }

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600017D RID: 381
		bool IsEof { get; }

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600017E RID: 382
		int EntityStackLength { get; }

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x0600017F RID: 383
		bool IsEntityEolNormalized { get; }

		// Token: 0x06000180 RID: 384
		int ReadData();

		// Token: 0x06000181 RID: 385
		void OnNewLine(int pos);

		// Token: 0x06000182 RID: 386
		int ParseNumericCharRef(StringBuilder internalSubsetBuilder);

		// Token: 0x06000183 RID: 387
		int ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder);

		// Token: 0x06000184 RID: 388
		void ParsePI(StringBuilder sb);

		// Token: 0x06000185 RID: 389
		void ParseComment(StringBuilder sb);

		// Token: 0x06000186 RID: 390
		bool PushEntity(IDtdEntityInfo entity, out int entityId);

		// Token: 0x06000187 RID: 391
		bool PopEntity(out IDtdEntityInfo oldEntity, out int newEntityId);

		// Token: 0x06000188 RID: 392
		bool PushExternalSubset(string systemId, string publicId);

		// Token: 0x06000189 RID: 393
		void PushInternalDtd(string baseUri, string internalDtd);

		// Token: 0x0600018A RID: 394
		void OnSystemId(string systemId, LineInfo keywordLineInfo, LineInfo systemLiteralLineInfo);

		// Token: 0x0600018B RID: 395
		void OnPublicId(string publicId, LineInfo keywordLineInfo, LineInfo publicLiteralLineInfo);

		// Token: 0x0600018C RID: 396
		void Throw(Exception e);

		// Token: 0x0600018D RID: 397
		Task<int> ReadDataAsync();

		// Token: 0x0600018E RID: 398
		Task<int> ParseNumericCharRefAsync(StringBuilder internalSubsetBuilder);

		// Token: 0x0600018F RID: 399
		Task<int> ParseNamedCharRefAsync(bool expand, StringBuilder internalSubsetBuilder);

		// Token: 0x06000190 RID: 400
		Task ParsePIAsync(StringBuilder sb);

		// Token: 0x06000191 RID: 401
		Task ParseCommentAsync(StringBuilder sb);

		// Token: 0x06000192 RID: 402
		Task<Tuple<int, bool>> PushEntityAsync(IDtdEntityInfo entity);

		// Token: 0x06000193 RID: 403
		Task<bool> PushExternalSubsetAsync(string systemId, string publicId);
	}
}
