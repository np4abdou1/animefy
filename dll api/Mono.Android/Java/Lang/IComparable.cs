using System;
using Android.Runtime;
using Java.Interop;

namespace Java.Lang
{
	// Token: 0x020003D5 RID: 981
	[Register("java/lang/Comparable", "", "Java.Lang.IComparableInvoker")]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public interface IComparable : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06002B38 RID: 11064
		int CompareTo(Object o);
	}
}
