using System;

namespace System.Net
{
	/// <summary>Provides a container class for Internet host address information.</summary>
	// Token: 0x02000152 RID: 338
	public class IPHostEntry
	{
		/// <summary>Gets or sets the DNS name of the host.</summary>
		/// <returns>A string that contains the primary host name for the server.</returns>
		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06000955 RID: 2389 RVA: 0x00033409 File Offset: 0x00031609
		// (set) Token: 0x06000956 RID: 2390 RVA: 0x00033411 File Offset: 0x00031611
		public string HostName
		{
			get
			{
				return this.hostName;
			}
			set
			{
				this.hostName = value;
			}
		}

		/// <summary>Gets or sets a list of aliases that are associated with a host.</summary>
		/// <returns>An array of strings that contain DNS names that resolve to the IP addresses in the <see cref="P:System.Net.IPHostEntry.AddressList" /> property.</returns>
		// Token: 0x170001A6 RID: 422
		// (set) Token: 0x06000957 RID: 2391 RVA: 0x0003341A File Offset: 0x0003161A
		public string[] Aliases
		{
			set
			{
				this.aliases = value;
			}
		}

		/// <summary>Gets or sets a list of IP addresses that are associated with a host.</summary>
		/// <returns>An array of type <see cref="T:System.Net.IPAddress" /> that contains IP addresses that resolve to the host names that are contained in the <see cref="P:System.Net.IPHostEntry.Aliases" /> property.</returns>
		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06000958 RID: 2392 RVA: 0x00033423 File Offset: 0x00031623
		// (set) Token: 0x06000959 RID: 2393 RVA: 0x0003342B File Offset: 0x0003162B
		public IPAddress[] AddressList
		{
			get
			{
				return this.addressList;
			}
			set
			{
				this.addressList = value;
			}
		}

		// Token: 0x040006DA RID: 1754
		private string hostName;

		// Token: 0x040006DB RID: 1755
		private string[] aliases;

		// Token: 0x040006DC RID: 1756
		private IPAddress[] addressList;

		// Token: 0x040006DD RID: 1757
		internal bool isTrustedHost = true;
	}
}
