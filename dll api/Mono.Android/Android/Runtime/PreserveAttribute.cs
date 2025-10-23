using System;

namespace Android.Runtime
{
	// Token: 0x020002F1 RID: 753
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Delegate)]
	public sealed class PreserveAttribute : Attribute
	{
		// Token: 0x04000C63 RID: 3171
		public bool AllMembers;

		// Token: 0x04000C64 RID: 3172
		public bool Conditional;
	}
}
