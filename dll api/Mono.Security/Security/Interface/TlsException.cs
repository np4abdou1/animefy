using System;

namespace Mono.Security.Interface
{
	// Token: 0x02000045 RID: 69
	public sealed class TlsException : Exception
	{
		// Token: 0x06000177 RID: 375 RVA: 0x00009F84 File Offset: 0x00008184
		public TlsException(Alert alert) : this(alert, alert.Description.ToString())
		{
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00009FAC File Offset: 0x000081AC
		public TlsException(Alert alert, string message) : base(message)
		{
			this.alert = alert;
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00009FBC File Offset: 0x000081BC
		public TlsException(AlertDescription description) : this(new Alert(description))
		{
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00009FCA File Offset: 0x000081CA
		public TlsException(AlertDescription description, string message) : this(new Alert(description), message)
		{
		}

		// Token: 0x040001F9 RID: 505
		private Alert alert;
	}
}
