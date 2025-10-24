using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Tasks
{
	// Token: 0x02000018 RID: 24
	[Register("com/google/android/gms/tasks/OnTokenCanceledListener", DoNotGenerateAcw = true)]
	internal class IOnTokenCanceledListenerInvoker : Java.Lang.Object, IOnTokenCanceledListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000DA RID: 218 RVA: 0x00003E90 File Offset: 0x00002090
		private static IntPtr java_class_ref
		{
			get
			{
				return IOnTokenCanceledListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000DB RID: 219 RVA: 0x00003EB4 File Offset: 0x000020B4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IOnTokenCanceledListenerInvoker._members;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000DC RID: 220 RVA: 0x00003EBB File Offset: 0x000020BB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000DD RID: 221 RVA: 0x00003EC3 File Offset: 0x000020C3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IOnTokenCanceledListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00003ECF File Offset: 0x000020CF
		public static IOnTokenCanceledListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IOnTokenCanceledListener>(handle, transfer);
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00003ED8 File Offset: 0x000020D8
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IOnTokenCanceledListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.gms.tasks.OnTokenCanceledListener'.");
			}
			return handle;
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00003F03 File Offset: 0x00002103
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00003F34 File Offset: 0x00002134
		public IOnTokenCanceledListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IOnTokenCanceledListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00003F6C File Offset: 0x0000216C
		private static Delegate GetOnCanceledHandler()
		{
			if (IOnTokenCanceledListenerInvoker.cb_onCanceled == null)
			{
				IOnTokenCanceledListenerInvoker.cb_onCanceled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IOnTokenCanceledListenerInvoker.n_OnCanceled));
			}
			return IOnTokenCanceledListenerInvoker.cb_onCanceled;
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00003F90 File Offset: 0x00002190
		private static void n_OnCanceled(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IOnTokenCanceledListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnCanceled();
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00003F9F File Offset: 0x0000219F
		public void OnCanceled()
		{
			if (this.id_onCanceled == IntPtr.Zero)
			{
				this.id_onCanceled = JNIEnv.GetMethodID(this.class_ref, "onCanceled", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onCanceled);
		}

		// Token: 0x04000038 RID: 56
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/tasks/OnTokenCanceledListener", typeof(IOnTokenCanceledListenerInvoker));

		// Token: 0x04000039 RID: 57
		private IntPtr class_ref;

		// Token: 0x0400003A RID: 58
		private static Delegate cb_onCanceled;

		// Token: 0x0400003B RID: 59
		private IntPtr id_onCanceled;
	}
}
