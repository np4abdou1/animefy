using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.OS
{
	// Token: 0x020001EA RID: 490
	[Register("android/os/Parcelable$Creator", "", "Android.OS.IParcelableCreatorInvoker")]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public interface IParcelableCreator : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060011E9 RID: 4585
		Java.Lang.Object CreateFromParcel(Parcel source);

		// Token: 0x060011EA RID: 4586
		Java.Lang.Object[] NewArray(int size);
	}
}
