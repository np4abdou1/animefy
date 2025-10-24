using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000109 RID: 265
	[NullableContext(1)]
	[Nullable(0)]
	public class ErrorContext
	{
		// Token: 0x060007B4 RID: 1972 RVA: 0x0002708C File Offset: 0x0002528C
		internal ErrorContext([Nullable(2)] object originalObject, [Nullable(2)] object member, string path, Exception error)
		{
			this.OriginalObject = originalObject;
			this.Member = member;
			this.Error = error;
			this.Path = path;
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060007B5 RID: 1973 RVA: 0x000270B1 File Offset: 0x000252B1
		// (set) Token: 0x060007B6 RID: 1974 RVA: 0x000270B9 File Offset: 0x000252B9
		internal bool Traced { get; set; }

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060007B7 RID: 1975 RVA: 0x000270C2 File Offset: 0x000252C2
		public Exception Error { get; }

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060007B8 RID: 1976 RVA: 0x000270CA File Offset: 0x000252CA
		[Nullable(2)]
		public object OriginalObject { [NullableContext(2)] get; }

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060007B9 RID: 1977 RVA: 0x000270D2 File Offset: 0x000252D2
		[Nullable(2)]
		public object Member { [NullableContext(2)] get; }

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060007BA RID: 1978 RVA: 0x000270DA File Offset: 0x000252DA
		public string Path { get; }

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060007BB RID: 1979 RVA: 0x000270E2 File Offset: 0x000252E2
		// (set) Token: 0x060007BC RID: 1980 RVA: 0x000270EA File Offset: 0x000252EA
		public bool Handled { get; set; }
	}
}
