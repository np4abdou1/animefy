using System;

namespace Mono.Security.Interface
{
	// Token: 0x0200003B RID: 59
	public class ValidationResult
	{
		// Token: 0x06000142 RID: 322 RVA: 0x00009C97 File Offset: 0x00007E97
		public ValidationResult(bool trusted, bool user_denied, int error_code, MonoSslPolicyErrors? policy_errors)
		{
			this.trusted = trusted;
			this.user_denied = user_denied;
			this.error_code = error_code;
			this.policy_errors = policy_errors;
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000143 RID: 323 RVA: 0x00009CBC File Offset: 0x00007EBC
		public bool Trusted
		{
			get
			{
				return this.trusted;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000144 RID: 324 RVA: 0x00009CC4 File Offset: 0x00007EC4
		public bool UserDenied
		{
			get
			{
				return this.user_denied;
			}
		}

		// Token: 0x040000CF RID: 207
		private bool trusted;

		// Token: 0x040000D0 RID: 208
		private bool user_denied;

		// Token: 0x040000D1 RID: 209
		private int error_code;

		// Token: 0x040000D2 RID: 210
		private MonoSslPolicyErrors? policy_errors;
	}
}
