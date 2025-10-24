using System;
using Android.Runtime;
using Java.Interop;

namespace Firebase.Encoders.Proto
{
	// Token: 0x02000003 RID: 3
	[Register("com/google/firebase/encoders/proto/ProtoEnum", "", "Firebase.Encoders.Proto.IProtoEnumInvoker")]
	public interface IProtoEnum : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000005 RID: 5
		int Number { [Register("getNumber", "()I", "GetGetNumberHandler:Firebase.Encoders.Proto.IProtoEnumInvoker, Xamarin.Firebase.Encoders.Proto")] get; }
	}
}
