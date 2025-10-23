using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Lifetime
{
	/// <summary>Controls the.NET remoting lifetime services.</summary>
	// Token: 0x0200032B RID: 811
	[ComVisible(true)]
	public sealed class LifetimeServices
	{
		// Token: 0x06001A71 RID: 6769 RVA: 0x00073454 File Offset: 0x00071654
		static LifetimeServices()
		{
			LifetimeServices._leaseManagerPollTime = TimeSpan.FromSeconds(10.0);
			LifetimeServices._leaseTime = TimeSpan.FromMinutes(5.0);
			LifetimeServices._renewOnCallTime = TimeSpan.FromMinutes(2.0);
			LifetimeServices._sponsorshipTimeout = TimeSpan.FromMinutes(2.0);
		}

		/// <summary>Gets or sets the time interval between each activation of the lease manager to clean up expired leases.</summary>
		/// <returns>The default amount of time the lease manager sleeps after checking for expired leases.</returns>
		/// <exception cref="T:System.Security.SecurityException">At least one of the callers higher in the callstack does not have permission to configure remoting types and channels. This exception is thrown only when setting the property value. </exception>
		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06001A72 RID: 6770 RVA: 0x000734B7 File Offset: 0x000716B7
		// (set) Token: 0x06001A73 RID: 6771 RVA: 0x000734BE File Offset: 0x000716BE
		public static TimeSpan LeaseManagerPollTime
		{
			get
			{
				return LifetimeServices._leaseManagerPollTime;
			}
			set
			{
				LifetimeServices._leaseManagerPollTime = value;
				LifetimeServices._leaseManager.SetPollTime(value);
			}
		}

		/// <summary>Gets or sets the initial lease time span for an <see cref="T:System.AppDomain" />.</summary>
		/// <returns>The initial lease <see cref="T:System.TimeSpan" /> for objects that can have leases in the <see cref="T:System.AppDomain" />.</returns>
		/// <exception cref="T:System.Security.SecurityException">At least one of the callers higher in the callstack does not have permission to configure remoting types and channels. This exception is thrown only when setting the property value. </exception>
		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06001A74 RID: 6772 RVA: 0x000734D1 File Offset: 0x000716D1
		// (set) Token: 0x06001A75 RID: 6773 RVA: 0x000734D8 File Offset: 0x000716D8
		public static TimeSpan LeaseTime
		{
			get
			{
				return LifetimeServices._leaseTime;
			}
			set
			{
				LifetimeServices._leaseTime = value;
			}
		}

		/// <summary>Gets or sets the amount of time by which the lease is extended every time a call comes in on the server object.</summary>
		/// <returns>The <see cref="T:System.TimeSpan" /> by which a lifetime lease in the current <see cref="T:System.AppDomain" /> is extended after each call.</returns>
		/// <exception cref="T:System.Security.SecurityException">At least one of the callers higher in the callstack does not have permission to configure remoting types and channels. This exception is thrown only when setting the property value. </exception>
		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06001A76 RID: 6774 RVA: 0x000734E0 File Offset: 0x000716E0
		// (set) Token: 0x06001A77 RID: 6775 RVA: 0x000734E7 File Offset: 0x000716E7
		public static TimeSpan RenewOnCallTime
		{
			get
			{
				return LifetimeServices._renewOnCallTime;
			}
			set
			{
				LifetimeServices._renewOnCallTime = value;
			}
		}

		/// <summary>Gets or sets the amount of time the lease manager waits for a sponsor to return with a lease renewal time.</summary>
		/// <returns>The initial sponsorship time-out.</returns>
		/// <exception cref="T:System.Security.SecurityException">At least one of the callers higher in the callstack does not have permission to configure remoting types and channels. This exception is thrown only when setting the property value. </exception>
		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06001A78 RID: 6776 RVA: 0x000734EF File Offset: 0x000716EF
		// (set) Token: 0x06001A79 RID: 6777 RVA: 0x000734F6 File Offset: 0x000716F6
		public static TimeSpan SponsorshipTimeout
		{
			get
			{
				return LifetimeServices._sponsorshipTimeout;
			}
			set
			{
				LifetimeServices._sponsorshipTimeout = value;
			}
		}

		// Token: 0x06001A7A RID: 6778 RVA: 0x000734FE File Offset: 0x000716FE
		internal static void TrackLifetime(ServerIdentity identity)
		{
			LifetimeServices._leaseManager.TrackLifetime(identity);
		}

		// Token: 0x04000B0F RID: 2831
		private static TimeSpan _leaseManagerPollTime;

		// Token: 0x04000B10 RID: 2832
		private static TimeSpan _leaseTime;

		// Token: 0x04000B11 RID: 2833
		private static TimeSpan _renewOnCallTime;

		// Token: 0x04000B12 RID: 2834
		private static TimeSpan _sponsorshipTimeout;

		// Token: 0x04000B13 RID: 2835
		private static LeaseManager _leaseManager = new LeaseManager();
	}
}
