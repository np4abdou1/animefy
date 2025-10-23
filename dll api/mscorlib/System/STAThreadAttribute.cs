using System;

namespace System
{
	/// <summary>Indicates that the COM threading model for an application is single-threaded apartment (STA). </summary>
	// Token: 0x02000103 RID: 259
	[AttributeUsage(AttributeTargets.Method)]
	public sealed class STAThreadAttribute : Attribute
	{
	}
}
