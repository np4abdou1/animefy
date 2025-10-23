using System;
using System.Runtime.InteropServices;

namespace System
{
	/// <summary>Indicates that the value of a static field is unique for a particular context.</summary>
	// Token: 0x02000140 RID: 320
	[AttributeUsage(AttributeTargets.Field, Inherited = false)]
	[ComVisible(true)]
	[Serializable]
	public class ContextStaticAttribute : Attribute
	{
	}
}
