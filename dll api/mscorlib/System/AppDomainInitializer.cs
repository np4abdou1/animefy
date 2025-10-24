﻿using System;
using System.Runtime.InteropServices;

namespace System
{
	/// <summary>Represents the callback method to invoke when the application domain is initialized.</summary>
	/// <param name="args">An array of strings to pass as arguments to the callback method.</param>
	// Token: 0x02000168 RID: 360
	// (Invoke) Token: 0x06000E6A RID: 3690
	[ComVisible(true)]
	[Serializable]
	public delegate void AppDomainInitializer(string[] args);
}
