using System;

namespace Java.Interop
{
	// Token: 0x02000438 RID: 1080
	internal class JavaLocationException : Exception
	{
		// Token: 0x06002F14 RID: 12052 RVA: 0x00083200 File Offset: 0x00081400
		public JavaLocationException(string stackTrace)
		{
			this.stackTrace = stackTrace;
		}

		// Token: 0x17000980 RID: 2432
		// (get) Token: 0x06002F15 RID: 12053 RVA: 0x0008320F File Offset: 0x0008140F
		public override string StackTrace
		{
			get
			{
				return this.stackTrace;
			}
		}

		// Token: 0x040012C0 RID: 4800
		private string stackTrace;
	}
}
