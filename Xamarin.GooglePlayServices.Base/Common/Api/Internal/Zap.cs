using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Gms.Common.Apis.Internal;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Common.Api.Internal
{
	// Token: 0x02000044 RID: 68
	[Register("com/google/android/gms/common/api/internal/zap", DoNotGenerateAcw = true)]
	public abstract class Zap : LifecycleCallback, IDialogInterfaceOnCancelListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060002AC RID: 684 RVA: 0x00008E97 File Offset: 0x00007097
		// (set) Token: 0x060002AD RID: 685 RVA: 0x00008EAE File Offset: 0x000070AE
		[Register("zaa")]
		protected bool Zaa
		{
			get
			{
				return Zap._members.InstanceFields.GetBooleanValue("zaa.Z", this);
			}
			set
			{
				Zap._members.InstanceFields.SetValue("zaa.Z", this, value);
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060002AE RID: 686 RVA: 0x00008EC8 File Offset: 0x000070C8
		internal static IntPtr class_ref
		{
			get
			{
				return Zap._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060002AF RID: 687 RVA: 0x00008EEC File Offset: 0x000070EC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Zap._members;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060002B0 RID: 688 RVA: 0x00008EF4 File Offset: 0x000070F4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Zap._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060002B1 RID: 689 RVA: 0x00008F18 File Offset: 0x00007118
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Zap._members.ManagedPeerType;
			}
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00008F24 File Offset: 0x00007124
		protected Zap(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00008F30 File Offset: 0x00007130
		[Register("onActivityResult", "(IILandroid/content/Intent;)V", "")]
		public unsafe sealed override void OnActivityResult(int p0, int p1, Intent p2)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(p0);
				ptr[1] = new JniArgumentValue(p1);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : p2.Handle);
				Zap._members.InstanceMethods.InvokeNonvirtualVoidMethod("onActivityResult.(IILandroid/content/Intent;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p2);
			}
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x00008FBC File Offset: 0x000071BC
		[Register("onCancel", "(Landroid/content/DialogInterface;)V", "")]
		public unsafe void OnCancel(IDialogInterface p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				Zap._members.InstanceMethods.InvokeNonvirtualVoidMethod("onCancel.(Landroid/content/DialogInterface;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x00009024 File Offset: 0x00007224
		[Register("onCreate", "(Landroid/os/Bundle;)V", "")]
		public unsafe sealed override void OnCreate(Bundle p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				Zap._members.InstanceMethods.InvokeNonvirtualVoidMethod("onCreate.(Landroid/os/Bundle;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00009088 File Offset: 0x00007288
		[Register("onSaveInstanceState", "(Landroid/os/Bundle;)V", "")]
		public unsafe sealed override void OnSaveInstanceState(Bundle p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				Zap._members.InstanceMethods.InvokeNonvirtualVoidMethod("onSaveInstanceState.(Landroid/os/Bundle;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x000090EC File Offset: 0x000072EC
		private static Delegate GetZab_Lcom_google_android_gms_common_ConnectionResult_IHandler()
		{
			if (Zap.cb_zab_Lcom_google_android_gms_common_ConnectionResult_I == null)
			{
				Zap.cb_zab_Lcom_google_android_gms_common_ConnectionResult_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(Zap.n_Zab_Lcom_google_android_gms_common_ConnectionResult_I));
			}
			return Zap.cb_zab_Lcom_google_android_gms_common_ConnectionResult_I;
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x00009110 File Offset: 0x00007310
		private static void n_Zab_Lcom_google_android_gms_common_ConnectionResult_I(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			Zap @object = Java.Lang.Object.GetObject<Zap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ConnectionResult object2 = Java.Lang.Object.GetObject<ConnectionResult>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.Zab(object2, p1);
		}

		// Token: 0x060002B9 RID: 697
		[Register("zab", "(Lcom/google/android/gms/common/ConnectionResult;I)V", "GetZab_Lcom_google_android_gms_common_ConnectionResult_IHandler")]
		protected abstract void Zab(ConnectionResult p0, int p1);

		// Token: 0x060002BA RID: 698 RVA: 0x00009134 File Offset: 0x00007334
		private static Delegate GetZacHandler()
		{
			if (Zap.cb_zac == null)
			{
				Zap.cb_zac = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(Zap.n_Zac));
			}
			return Zap.cb_zac;
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00009158 File Offset: 0x00007358
		private static void n_Zac(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<Zap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Zac();
		}

		// Token: 0x060002BC RID: 700
		[Register("zac", "()V", "GetZacHandler")]
		protected abstract void Zac();

		// Token: 0x060002BD RID: 701 RVA: 0x00009168 File Offset: 0x00007368
		[Register("zah", "(Lcom/google/android/gms/common/ConnectionResult;I)V", "")]
		public unsafe void Zah(ConnectionResult p0, int p1)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue(p1);
				Zap._members.InstanceMethods.InvokeNonvirtualVoidMethod("zah.(Lcom/google/android/gms/common/ConnectionResult;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x04000089 RID: 137
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/api/internal/zap", typeof(Zap));

		// Token: 0x0400008A RID: 138
		private static Delegate cb_zab_Lcom_google_android_gms_common_ConnectionResult_I;

		// Token: 0x0400008B RID: 139
		private static Delegate cb_zac;
	}
}
