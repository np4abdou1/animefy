using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Gms.Common.Internal.SafeParcel;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Auth.Api.SignIn.Internal
{
	// Token: 0x0200001A RID: 26
	[Register("com/google/android/gms/auth/api/signin/internal/GoogleSignInOptionsExtensionParcelable", DoNotGenerateAcw = true)]
	public class GoogleSignInOptionsExtensionParcelable : AbstractSafeParcelable
	{
		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000DC RID: 220 RVA: 0x00003AD0 File Offset: 0x00001CD0
		[Register("CREATOR")]
		public static IParcelableCreator Creator
		{
			get
			{
				return Java.Lang.Object.GetObject<IParcelableCreator>(GoogleSignInOptionsExtensionParcelable._members.StaticFields.GetObjectValue("CREATOR.Landroid/os/Parcelable$Creator;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000DD RID: 221 RVA: 0x00003B00 File Offset: 0x00001D00
		internal static IntPtr class_ref
		{
			get
			{
				return GoogleSignInOptionsExtensionParcelable._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000DE RID: 222 RVA: 0x00003B24 File Offset: 0x00001D24
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return GoogleSignInOptionsExtensionParcelable._members;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000DF RID: 223 RVA: 0x00003B2C File Offset: 0x00001D2C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return GoogleSignInOptionsExtensionParcelable._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x00003B50 File Offset: 0x00001D50
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return GoogleSignInOptionsExtensionParcelable._members.ManagedPeerType;
			}
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00002118 File Offset: 0x00000318
		protected GoogleSignInOptionsExtensionParcelable(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00003B5C File Offset: 0x00001D5C
		[Register(".ctor", "(Lcom/google/android/gms/auth/api/signin/GoogleSignInOptionsExtension;)V", "")]
		public unsafe GoogleSignInOptionsExtensionParcelable(IGoogleSignInOptionsExtension p0) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				base.SetHandle(GoogleSignInOptionsExtensionParcelable._members.InstanceMethods.StartCreateInstance("(Lcom/google/android/gms/auth/api/signin/GoogleSignInOptionsExtension;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				GoogleSignInOptionsExtensionParcelable._members.InstanceMethods.FinishCreateInstance("(Lcom/google/android/gms/auth/api/signin/GoogleSignInOptionsExtension;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00003C10 File Offset: 0x00001E10
		private static Delegate GetGetTypeHandler()
		{
			if (GoogleSignInOptionsExtensionParcelable.cb_getType == null)
			{
				GoogleSignInOptionsExtensionParcelable.cb_getType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(GoogleSignInOptionsExtensionParcelable.n_GetType));
			}
			return GoogleSignInOptionsExtensionParcelable.cb_getType;
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00003C34 File Offset: 0x00001E34
		private static int n_GetType(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<GoogleSignInOptionsExtensionParcelable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Type;
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x00003C43 File Offset: 0x00001E43
		public virtual int Type
		{
			[Register("getType", "()I", "GetGetTypeHandler")]
			get
			{
				return GoogleSignInOptionsExtensionParcelable._members.InstanceMethods.InvokeVirtualInt32Method("getType.()I", this, null);
			}
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00003C5C File Offset: 0x00001E5C
		[Register("writeToParcel", "(Landroid/os/Parcel;I)V", "")]
		public unsafe sealed override void WriteToParcel(Parcel dest, [GeneratedEnum] ParcelableWriteFlags flags)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((dest == null) ? IntPtr.Zero : dest.Handle);
				ptr[1] = new JniArgumentValue((int)flags);
				GoogleSignInOptionsExtensionParcelable._members.InstanceMethods.InvokeNonvirtualVoidMethod("writeToParcel.(Landroid/os/Parcel;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(dest);
			}
		}

		// Token: 0x04000026 RID: 38
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/auth/api/signin/internal/GoogleSignInOptionsExtensionParcelable", typeof(GoogleSignInOptionsExtensionParcelable));

		// Token: 0x04000027 RID: 39
		private static Delegate cb_getType;
	}
}
