﻿using System;
using System.Runtime.InteropServices;

namespace System.Security
{
	/// <summary>Marks modules containing unverifiable code. This class cannot be inherited.</summary>
	// Token: 0x0200027B RID: 635
	[AttributeUsage(AttributeTargets.Module, AllowMultiple = true, Inherited = false)]
	[ComVisible(true)]
	public sealed class UnverifiableCodeAttribute : Attribute
	{
	}
}
