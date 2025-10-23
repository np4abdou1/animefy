using System;
using Android.Runtime;
using Java.Interop;

namespace Android.OS
{
	// Token: 0x020001EC RID: 492
	[Register("android/os/Parcelable", "", "Android.OS.IParcelableInvoker")]
	public interface IParcelable : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060011F9 RID: 4601
		int DescribeContents();

		// Token: 0x060011FA RID: 4602
		void WriteToParcel(Parcel dest, [GeneratedEnum] ParcelableWriteFlags flags);
	}
}
