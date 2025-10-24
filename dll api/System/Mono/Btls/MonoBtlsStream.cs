using System;
using System.IO;
using System.Net.Security;
using Mono.Net.Security;
using Mono.Security.Interface;

namespace Mono.Btls
{
	// Token: 0x0200004C RID: 76
	internal class MonoBtlsStream : MobileAuthenticatedStream
	{
		// Token: 0x060001EC RID: 492 RVA: 0x00007A39 File Offset: 0x00005C39
		public MonoBtlsStream(Stream innerStream, bool leaveInnerStreamOpen, SslStream owner, MonoTlsSettings settings, MobileTlsProvider provider) : base(innerStream, leaveInnerStreamOpen, owner, settings, provider)
		{
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00007A48 File Offset: 0x00005C48
		protected override MobileTlsContext CreateContext(MonoSslAuthenticationOptions options)
		{
			return new MonoBtlsContext(this, options);
		}
	}
}
