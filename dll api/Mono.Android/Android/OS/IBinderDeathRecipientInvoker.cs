using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.OS
{
	// Token: 0x020001E5 RID: 485
	[Register("android/os/IBinder$DeathRecipient", DoNotGenerateAcw = true)]
	internal class IBinderDeathRecipientInvoker : Java.Lang.Object, IBinderDeathRecipient, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000387 RID: 903
		// (get) Token: 0x060011A4 RID: 4516 RVA: 0x0002EBA8 File Offset: 0x0002CDA8
		private static IntPtr java_class_ref
		{
			get
			{
				return IBinderDeathRecipientInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x060011A5 RID: 4517 RVA: 0x0002EBCC File Offset: 0x0002CDCC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IBinderDeathRecipientInvoker._members;
			}
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x060011A6 RID: 4518 RVA: 0x0002EBD3 File Offset: 0x0002CDD3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x060011A7 RID: 4519 RVA: 0x0002EBDB File Offset: 0x0002CDDB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IBinderDeathRecipientInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060011A8 RID: 4520 RVA: 0x0002EBE7 File Offset: 0x0002CDE7
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IBinderDeathRecipientInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.os.IBinder.DeathRecipient'.");
			}
			return handle;
		}

		// Token: 0x060011A9 RID: 4521 RVA: 0x0002EC12 File Offset: 0x0002CE12
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060011AA RID: 4522 RVA: 0x0002EC44 File Offset: 0x0002CE44
		public IBinderDeathRecipientInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IBinderDeathRecipientInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060011AB RID: 4523 RVA: 0x0002EC7C File Offset: 0x0002CE7C
		private static Delegate GetBinderDiedHandler()
		{
			if (IBinderDeathRecipientInvoker.cb_binderDied == null)
			{
				IBinderDeathRecipientInvoker.cb_binderDied = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IBinderDeathRecipientInvoker.n_BinderDied));
			}
			return IBinderDeathRecipientInvoker.cb_binderDied;
		}

		// Token: 0x060011AC RID: 4524 RVA: 0x0002ECA0 File Offset: 0x0002CEA0
		private static void n_BinderDied(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IBinderDeathRecipient>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).BinderDied();
		}

		// Token: 0x060011AD RID: 4525 RVA: 0x0002ECAF File Offset: 0x0002CEAF
		public void BinderDied()
		{
			if (this.id_binderDied == IntPtr.Zero)
			{
				this.id_binderDied = JNIEnv.GetMethodID(this.class_ref, "binderDied", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_binderDied);
		}

		// Token: 0x040007DE RID: 2014
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/os/IBinder$DeathRecipient", typeof(IBinderDeathRecipientInvoker));

		// Token: 0x040007DF RID: 2015
		private IntPtr class_ref;

		// Token: 0x040007E0 RID: 2016
		private static Delegate cb_binderDied;

		// Token: 0x040007E1 RID: 2017
		private IntPtr id_binderDied;
	}
}
