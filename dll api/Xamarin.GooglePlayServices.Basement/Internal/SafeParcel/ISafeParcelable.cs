using System;
using Android.OS;
using Android.Runtime;
using Java.Interop;

namespace Android.Gms.Common.Internal.SafeParcel
{
	// Token: 0x02000018 RID: 24
	[Register("com/google/android/gms/common/internal/safeparcel/SafeParcelable", "", "Android.Gms.Common.Internal.SafeParcel.ISafeParcelableInvoker")]
	public interface ISafeParcelable : IParcelable, IJavaObject, IDisposable, IJavaPeerable
	{
	}
}
