using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200010A RID: 266
	[NullableContext(1)]
	[Nullable(0)]
	public class ErrorEventArgs : EventArgs
	{
		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060007BD RID: 1981 RVA: 0x000270F3 File Offset: 0x000252F3
		[Nullable(2)]
		public object CurrentObject { [NullableContext(2)] get; }

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060007BE RID: 1982 RVA: 0x000270FB File Offset: 0x000252FB
		public ErrorContext ErrorContext { get; }

		// Token: 0x060007BF RID: 1983 RVA: 0x00027103 File Offset: 0x00025303
		public ErrorEventArgs([Nullable(2)] object currentObject, ErrorContext errorContext)
		{
			this.CurrentObject = currentObject;
			this.ErrorContext = errorContext;
		}
	}
}
