﻿using System;

namespace System.ComponentModel
{
	/// <summary>Specifies the browsable state of a property or method from within an editor.</summary>
	// Token: 0x02000232 RID: 562
	public enum EditorBrowsableState
	{
		/// <summary>The property or method is always browsable from within an editor.</summary>
		// Token: 0x04000BFA RID: 3066
		Always,
		/// <summary>The property or method is never browsable from within an editor.</summary>
		// Token: 0x04000BFB RID: 3067
		Never,
		/// <summary>The property or method is a feature that only advanced users should see. An editor can either show or hide such properties.</summary>
		// Token: 0x04000BFC RID: 3068
		Advanced
	}
}
