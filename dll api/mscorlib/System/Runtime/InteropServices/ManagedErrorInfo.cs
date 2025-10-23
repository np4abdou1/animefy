using System;

namespace System.Runtime.InteropServices
{
	// Token: 0x0200041F RID: 1055
	internal class ManagedErrorInfo
	{
		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06001F83 RID: 8067 RVA: 0x00086CF3 File Offset: 0x00084EF3
		public Exception Exception
		{
			get
			{
				return this.m_Exception;
			}
		}

		// Token: 0x04000F13 RID: 3859
		private Exception m_Exception;
	}
}
