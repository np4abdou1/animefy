using System;
using System.Net.Sockets;

namespace System.Net.Configuration
{
	// Token: 0x020001F3 RID: 499
	internal sealed class SettingsSectionInternal
	{
		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06000D67 RID: 3431 RVA: 0x000468BC File Offset: 0x00044ABC
		internal static SettingsSectionInternal Section
		{
			get
			{
				return SettingsSectionInternal.instance;
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06000D68 RID: 3432 RVA: 0x00009518 File Offset: 0x00007718
		internal bool Ipv6Enabled
		{
			get
			{
				return true;
			}
		}

		// Token: 0x04000A2B RID: 2603
		private static readonly SettingsSectionInternal instance = new SettingsSectionInternal();

		// Token: 0x04000A2C RID: 2604
		internal readonly bool HttpListenerUnescapeRequestUrl = true;

		// Token: 0x04000A2D RID: 2605
		internal readonly IPProtectionLevel IPProtectionLevel = IPProtectionLevel.Unspecified;
	}
}
