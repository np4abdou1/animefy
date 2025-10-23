using System;
using System.Runtime.InteropServices;
using System.Text;

namespace System.Net.NetworkInformation
{
	// Token: 0x020001EE RID: 494
	internal abstract class CommonUnixIPGlobalProperties : IPGlobalProperties
	{
		// Token: 0x06000D5A RID: 3418
		[DllImport("libc")]
		private static extern int getdomainname([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] name, int len);

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06000D5B RID: 3419 RVA: 0x000467BC File Offset: 0x000449BC
		public override string DomainName
		{
			get
			{
				byte[] array = new byte[256];
				if (CommonUnixIPGlobalProperties.getdomainname(array, 256) != 0)
				{
					throw new NetworkInformationException();
				}
				int num = Array.IndexOf<byte>(array, 0);
				return Encoding.ASCII.GetString(array, 0, (num < 0) ? 256 : num);
			}
		}
	}
}
