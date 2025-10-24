﻿using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Creates a COM object.</summary>
	/// <param name="aggregator">A pointer to the managed object's <see langword="IUnknown" /> interface. </param>
	/// <returns>An <see cref="T:System.IntPtr" /> object that represents the <see langword="IUnknown" /> interface of the COM object.</returns>
	// Token: 0x0200041A RID: 1050
	// (Invoke) Token: 0x06001F54 RID: 8020
	[ComVisible(true)]
	public delegate IntPtr ObjectCreationDelegate(IntPtr aggregator);
}
