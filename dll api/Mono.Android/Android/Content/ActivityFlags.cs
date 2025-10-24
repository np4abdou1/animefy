using System;

namespace Android.Content
{
	// Token: 0x020002A3 RID: 675
	[Flags]
	public enum ActivityFlags
	{
		// Token: 0x04000AE7 RID: 2791
		BroughtToFront = 4194304,
		// Token: 0x04000AE8 RID: 2792
		ClearTask = 32768,
		// Token: 0x04000AE9 RID: 2793
		ClearTop = 67108864,
		// Token: 0x04000AEA RID: 2794
		ClearWhenTaskReset = 524288,
		// Token: 0x04000AEB RID: 2795
		ExcludeFromRecents = 8388608,
		// Token: 0x04000AEC RID: 2796
		ForwardResult = 33554432,
		// Token: 0x04000AED RID: 2797
		LaunchAdjacent = 4096,
		// Token: 0x04000AEE RID: 2798
		LaunchedFromHistory = 1048576,
		// Token: 0x04000AEF RID: 2799
		MatchExternal = 2048,
		// Token: 0x04000AF0 RID: 2800
		MultipleTask = 134217728,
		// Token: 0x04000AF1 RID: 2801
		NewDocument = 524288,
		// Token: 0x04000AF2 RID: 2802
		NewTask = 268435456,
		// Token: 0x04000AF3 RID: 2803
		NoAnimation = 65536,
		// Token: 0x04000AF4 RID: 2804
		NoHistory = 1073741824,
		// Token: 0x04000AF5 RID: 2805
		NoUserAction = 262144,
		// Token: 0x04000AF6 RID: 2806
		PreviousIsTop = 16777216,
		// Token: 0x04000AF7 RID: 2807
		ReorderToFront = 131072,
		// Token: 0x04000AF8 RID: 2808
		RequireDefault = 512,
		// Token: 0x04000AF9 RID: 2809
		RequireNonBrowser = 1024,
		// Token: 0x04000AFA RID: 2810
		ResetTaskIfNeeded = 2097152,
		// Token: 0x04000AFB RID: 2811
		RetainInRecents = 8192,
		// Token: 0x04000AFC RID: 2812
		SingleTop = 536870912,
		// Token: 0x04000AFD RID: 2813
		TaskOnHome = 16384,
		// Token: 0x04000AFE RID: 2814
		DebugLogResolution = 8,
		// Token: 0x04000AFF RID: 2815
		DirectBootAuto = 256,
		// Token: 0x04000B00 RID: 2816
		ExcludeStoppedPackages = 16,
		// Token: 0x04000B01 RID: 2817
		FromBackground = 4,
		// Token: 0x04000B02 RID: 2818
		GrantPersistableUriPermission = 64,
		// Token: 0x04000B03 RID: 2819
		GrantPrefixUriPermission = 128,
		// Token: 0x04000B04 RID: 2820
		GrantReadUriPermission = 1,
		// Token: 0x04000B05 RID: 2821
		GrantWriteUriPermission = 2,
		// Token: 0x04000B06 RID: 2822
		IncludeStoppedPackages = 32,
		// Token: 0x04000B07 RID: 2823
		ReceiverForeground = 268435456,
		// Token: 0x04000B08 RID: 2824
		ReceiverNoAbort = 134217728,
		// Token: 0x04000B09 RID: 2825
		ReceiverRegisteredOnly = 1073741824,
		// Token: 0x04000B0A RID: 2826
		ReceiverReplacePending = 536870912,
		// Token: 0x04000B0B RID: 2827
		ReceiverVisibleToInstantApps = 2097152
	}
}
