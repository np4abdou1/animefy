using System;
using System.Runtime.CompilerServices;

namespace Mono.Security.Interface
{
	// Token: 0x0200003E RID: 62
	public class MonoTlsConnectionInfo
	{
		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000145 RID: 325 RVA: 0x00009CCC File Offset: 0x00007ECC
		// (set) Token: 0x06000146 RID: 326 RVA: 0x00009CD4 File Offset: 0x00007ED4
		[CLSCompliant(false)]
		public CipherSuiteCode CipherSuiteCode { get; set; }

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000147 RID: 327 RVA: 0x00009CDD File Offset: 0x00007EDD
		// (set) Token: 0x06000148 RID: 328 RVA: 0x00009CE5 File Offset: 0x00007EE5
		public TlsProtocols ProtocolVersion { get; set; }

		// Token: 0x17000062 RID: 98
		// (set) Token: 0x06000149 RID: 329 RVA: 0x00009CEE File Offset: 0x00007EEE
		public string PeerDomainName
		{
			[CompilerGenerated]
			set
			{
				this.<PeerDomainName>k__BackingField = value;
			}
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00009CF7 File Offset: 0x00007EF7
		public override string ToString()
		{
			return string.Format("[MonoTlsConnectionInfo: {0}:{1}]", this.ProtocolVersion, this.CipherSuiteCode);
		}
	}
}
