using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Tasks
{
	// Token: 0x02000010 RID: 16
	[Register("com/google/android/gms/tasks/OnCanceledListener", DoNotGenerateAcw = true)]
	internal class IOnCanceledListenerInvoker : Java.Lang.Object, IOnCanceledListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x0000380C File Offset: 0x00001A0C
		private static IntPtr java_class_ref
		{
			get
			{
				return IOnCanceledListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x00003830 File Offset: 0x00001A30
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IOnCanceledListenerInvoker._members;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x00003837 File Offset: 0x00001A37
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x0000383F File Offset: 0x00001A3F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IOnCanceledListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060000AA RID: 170 RVA: 0x0000384B File Offset: 0x00001A4B
		public static IOnCanceledListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IOnCanceledListener>(handle, transfer);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00003854 File Offset: 0x00001A54
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IOnCanceledListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.gms.tasks.OnCanceledListener'.");
			}
			return handle;
		}

		// Token: 0x060000AC RID: 172 RVA: 0x0000387F File Offset: 0x00001A7F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x000038B0 File Offset: 0x00001AB0
		public IOnCanceledListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IOnCanceledListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x000038E8 File Offset: 0x00001AE8
		private static Delegate GetOnCanceledHandler()
		{
			if (IOnCanceledListenerInvoker.cb_onCanceled == null)
			{
				IOnCanceledListenerInvoker.cb_onCanceled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IOnCanceledListenerInvoker.n_OnCanceled));
			}
			return IOnCanceledListenerInvoker.cb_onCanceled;
		}

		// Token: 0x060000AF RID: 175 RVA: 0x0000390C File Offset: 0x00001B0C
		private static void n_OnCanceled(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IOnCanceledListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnCanceled();
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0000391B File Offset: 0x00001B1B
		public void OnCanceled()
		{
			if (this.id_onCanceled == IntPtr.Zero)
			{
				this.id_onCanceled = JNIEnv.GetMethodID(this.class_ref, "onCanceled", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onCanceled);
		}

		// Token: 0x04000028 RID: 40
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/tasks/OnCanceledListener", typeof(IOnCanceledListenerInvoker));

		// Token: 0x04000029 RID: 41
		private IntPtr class_ref;

		// Token: 0x0400002A RID: 42
		private static Delegate cb_onCanceled;

		// Token: 0x0400002B RID: 43
		private IntPtr id_onCanceled;
	}
}
