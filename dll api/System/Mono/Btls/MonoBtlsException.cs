using System;

namespace Mono.Btls
{
	// Token: 0x02000037 RID: 55
	internal class MonoBtlsException : Exception
	{
		// Token: 0x0600013F RID: 319 RVA: 0x00006486 File Offset: 0x00004686
		public MonoBtlsException()
		{
		}

		// Token: 0x06000140 RID: 320 RVA: 0x0000648E File Offset: 0x0000468E
		public MonoBtlsException(MonoBtlsSslError error) : base(error.ToString())
		{
		}

		// Token: 0x06000141 RID: 321 RVA: 0x000064A3 File Offset: 0x000046A3
		public MonoBtlsException(string message) : base(message)
		{
		}

		// Token: 0x06000142 RID: 322 RVA: 0x000064AC File Offset: 0x000046AC
		public MonoBtlsException(string format, params object[] args) : base(string.Format(format, args))
		{
		}
	}
}
