using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Lifetime
{
	/// <summary>Defines a lifetime lease object that is used by the remoting lifetime service.</summary>
	// Token: 0x02000324 RID: 804
	[ComVisible(true)]
	public interface ILease
	{
		/// <summary>Gets the amount of time remaining on the lease.</summary>
		/// <returns>The amount of time remaining on the lease.</returns>
		/// <exception cref="T:System.Security.SecurityException">The immediate caller makes the call through a reference to the interface and does not have infrastructure permission. </exception>
		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06001A54 RID: 6740
		TimeSpan CurrentLeaseTime { get; }

		/// <summary>Gets the current <see cref="T:System.Runtime.Remoting.Lifetime.LeaseState" /> of the lease.</summary>
		/// <returns>The current <see cref="T:System.Runtime.Remoting.Lifetime.LeaseState" /> of the lease.</returns>
		/// <exception cref="T:System.Security.SecurityException">The immediate caller makes the call through a reference to the interface and does not have infrastructure permission. </exception>
		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06001A55 RID: 6741
		LeaseState CurrentState { get; }

		/// <summary>Gets or sets the amount of time by which a call to the remote object renews the <see cref="P:System.Runtime.Remoting.Lifetime.ILease.CurrentLeaseTime" />.</summary>
		/// <returns>The amount of time by which a call to the remote object renews the <see cref="P:System.Runtime.Remoting.Lifetime.ILease.CurrentLeaseTime" />.</returns>
		/// <exception cref="T:System.Security.SecurityException">The immediate caller makes the call through a reference to the interface and does not have infrastructure permission. </exception>
		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06001A56 RID: 6742
		TimeSpan RenewOnCallTime { get; }

		/// <summary>Renews a lease for the specified time.</summary>
		/// <param name="renewalTime">The length of time to renew the lease by. </param>
		/// <returns>The new expiration time of the lease.</returns>
		/// <exception cref="T:System.Security.SecurityException">The immediate caller makes the call through a reference to the interface and does not have infrastructure permission. </exception>
		// Token: 0x06001A57 RID: 6743
		TimeSpan Renew(TimeSpan renewalTime);
	}
}
