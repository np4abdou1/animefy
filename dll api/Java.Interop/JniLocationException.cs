using System;

namespace Java.Interop
{
	// Token: 0x02000090 RID: 144
	internal sealed class JniLocationException : Exception
	{
		// Token: 0x060004A7 RID: 1191 RVA: 0x00010F88 File Offset: 0x0000F188
		public JniLocationException(string stackTrace)
		{
			this.stackTrace = stackTrace;
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060004A8 RID: 1192 RVA: 0x00010F97 File Offset: 0x0000F197
		public override string StackTrace
		{
			get
			{
				return this.stackTrace;
			}
		}

		// Token: 0x04000146 RID: 326
		private string stackTrace;
	}
}
