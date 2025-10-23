using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Lifetime
{
	/// <summary>Indicates the possible lease states of a lifetime lease.</summary>
	// Token: 0x0200032A RID: 810
	[ComVisible(true)]
	[Serializable]
	public enum LeaseState
	{
		/// <summary>The lease is not initialized.</summary>
		// Token: 0x04000B0A RID: 2826
		Null,
		/// <summary>The lease has been created, but is not yet active.</summary>
		// Token: 0x04000B0B RID: 2827
		Initial,
		/// <summary>The lease is active and has not expired.</summary>
		// Token: 0x04000B0C RID: 2828
		Active,
		/// <summary>The lease has expired and is seeking sponsorship.</summary>
		// Token: 0x04000B0D RID: 2829
		Renewing,
		/// <summary>The lease has expired and cannot be renewed.</summary>
		// Token: 0x04000B0E RID: 2830
		Expired
	}
}
