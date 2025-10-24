using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Window
{
	// Token: 0x0200009D RID: 157
	[Register("android/window/OnBackInvokedCallback", DoNotGenerateAcw = true, ApiSince = 33)]
	internal class IOnBackInvokedCallbackInvoker : Java.Lang.Object, IOnBackInvokedCallback, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600026A RID: 618 RVA: 0x00002B48 File Offset: 0x00000D48
		private static IntPtr java_class_ref
		{
			get
			{
				return IOnBackInvokedCallbackInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600026B RID: 619 RVA: 0x00002B6C File Offset: 0x00000D6C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IOnBackInvokedCallbackInvoker._members;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600026C RID: 620 RVA: 0x00002B73 File Offset: 0x00000D73
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600026D RID: 621 RVA: 0x00002B7B File Offset: 0x00000D7B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IOnBackInvokedCallbackInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00002B87 File Offset: 0x00000D87
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IOnBackInvokedCallbackInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.window.OnBackInvokedCallback'.");
			}
			return handle;
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00002BB2 File Offset: 0x00000DB2
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00002BE4 File Offset: 0x00000DE4
		public IOnBackInvokedCallbackInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IOnBackInvokedCallbackInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000271 RID: 625 RVA: 0x00002C1C File Offset: 0x00000E1C
		private static Delegate GetOnBackInvokedHandler()
		{
			if (IOnBackInvokedCallbackInvoker.cb_onBackInvoked == null)
			{
				IOnBackInvokedCallbackInvoker.cb_onBackInvoked = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IOnBackInvokedCallbackInvoker.n_OnBackInvoked));
			}
			return IOnBackInvokedCallbackInvoker.cb_onBackInvoked;
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00002C40 File Offset: 0x00000E40
		private static void n_OnBackInvoked(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IOnBackInvokedCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnBackInvoked();
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00002C4F File Offset: 0x00000E4F
		public void OnBackInvoked()
		{
			if (this.id_onBackInvoked == IntPtr.Zero)
			{
				this.id_onBackInvoked = JNIEnv.GetMethodID(this.class_ref, "onBackInvoked", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onBackInvoked);
		}

		// Token: 0x04000032 RID: 50
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/window/OnBackInvokedCallback", typeof(IOnBackInvokedCallbackInvoker));

		// Token: 0x04000033 RID: 51
		private IntPtr class_ref;

		// Token: 0x04000034 RID: 52
		private static Delegate cb_onBackInvoked;

		// Token: 0x04000035 RID: 53
		private IntPtr id_onBackInvoked;
	}
}
