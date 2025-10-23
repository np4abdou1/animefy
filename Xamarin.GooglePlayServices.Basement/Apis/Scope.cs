using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Gms.Common.Internal.SafeParcel;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Common.Apis
{
	// Token: 0x02000020 RID: 32
	[Register("com/google/android/gms/common/api/Scope", DoNotGenerateAcw = true)]
	public sealed class Scope : AbstractSafeParcelable, IParcelable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000CC RID: 204 RVA: 0x000038AC File Offset: 0x00001AAC
		[Register("CREATOR")]
		public static IParcelableCreator Creator
		{
			get
			{
				return Java.Lang.Object.GetObject<IParcelableCreator>(Scope._members.StaticFields.GetObjectValue("CREATOR.Landroid/os/Parcelable$Creator;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000CD RID: 205 RVA: 0x000038DC File Offset: 0x00001ADC
		internal new static IntPtr class_ref
		{
			get
			{
				return Scope._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000CE RID: 206 RVA: 0x00003900 File Offset: 0x00001B00
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Scope._members;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000CF RID: 207 RVA: 0x00003908 File Offset: 0x00001B08
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Scope._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x0000392C File Offset: 0x00001B2C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Scope._members.ManagedPeerType;
			}
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x0000210C File Offset: 0x0000030C
		internal Scope(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00003938 File Offset: 0x00001B38
		[Register(".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe Scope(string scopeUri) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(scopeUri);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				base.SetHandle(Scope._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				Scope._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x000039DC File Offset: 0x00001BDC
		public string ScopeUri
		{
			[Register("getScopeUri", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(Scope._members.InstanceMethods.InvokeAbstractObjectMethod("getScopeUri.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00003A10 File Offset: 0x00001C10
		[Register("writeToParcel", "(Landroid/os/Parcel;I)V", "")]
		public unsafe override void WriteToParcel(Parcel dest, [GeneratedEnum] ParcelableWriteFlags flags)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((dest == null) ? IntPtr.Zero : dest.Handle);
				ptr[1] = new JniArgumentValue((int)flags);
				Scope._members.InstanceMethods.InvokeAbstractVoidMethod("writeToParcel.(Landroid/os/Parcel;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(dest);
			}
		}

		// Token: 0x04000028 RID: 40
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/api/Scope", typeof(Scope));
	}
}
