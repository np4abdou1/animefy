using System;

namespace Android.Views.Accessibility
{
	// Token: 0x0200018E RID: 398
	[Flags]
	public enum Action
	{
		// Token: 0x04000634 RID: 1588
		AccessibilityFocus = 64,
		// Token: 0x04000635 RID: 1589
		ClearAccessibilityFocus = 128,
		// Token: 0x04000636 RID: 1590
		ClearFocus = 2,
		// Token: 0x04000637 RID: 1591
		ClearSelection = 8,
		// Token: 0x04000638 RID: 1592
		Click = 16,
		// Token: 0x04000639 RID: 1593
		Collapse = 524288,
		// Token: 0x0400063A RID: 1594
		Copy = 16384,
		// Token: 0x0400063B RID: 1595
		Cut = 65536,
		// Token: 0x0400063C RID: 1596
		Dismiss = 1048576,
		// Token: 0x0400063D RID: 1597
		Expand = 262144,
		// Token: 0x0400063E RID: 1598
		Focus = 1,
		// Token: 0x0400063F RID: 1599
		LongClick = 32,
		// Token: 0x04000640 RID: 1600
		NextAtMovementGranularity = 256,
		// Token: 0x04000641 RID: 1601
		NextHtmlElement = 1024,
		// Token: 0x04000642 RID: 1602
		Paste = 32768,
		// Token: 0x04000643 RID: 1603
		PreviousAtMovementGranularity = 512,
		// Token: 0x04000644 RID: 1604
		PreviousHtmlElement = 2048,
		// Token: 0x04000645 RID: 1605
		ScrollBackward = 8192,
		// Token: 0x04000646 RID: 1606
		ScrollForward = 4096,
		// Token: 0x04000647 RID: 1607
		Select = 4,
		// Token: 0x04000648 RID: 1608
		SetSelection = 131072,
		// Token: 0x04000649 RID: 1609
		SetText = 2097152
	}
}
