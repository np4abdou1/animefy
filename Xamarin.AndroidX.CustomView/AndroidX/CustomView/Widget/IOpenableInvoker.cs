using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace AndroidX.CustomView.Widget
{
	// Token: 0x02000008 RID: 8
	[Register("androidx/customview/widget/Openable", DoNotGenerateAcw = true)]
	internal class IOpenableInvoker : Java.Lang.Object, IOpenable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000F RID: 15 RVA: 0x00002080 File Offset: 0x00000280
		private static IntPtr java_class_ref
		{
			get
			{
				return IOpenableInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000010 RID: 16 RVA: 0x000020A4 File Offset: 0x000002A4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IOpenableInvoker._members;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000011 RID: 17 RVA: 0x000020AB File Offset: 0x000002AB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000012 RID: 18 RVA: 0x000020B3 File Offset: 0x000002B3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IOpenableInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000020BF File Offset: 0x000002BF
		public static IOpenable GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IOpenable>(handle, transfer);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000020C8 File Offset: 0x000002C8
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IOpenableInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.customview.widget.Openable'.");
			}
			return handle;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000020F3 File Offset: 0x000002F3
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002124 File Offset: 0x00000324
		public IOpenableInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IOpenableInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x0000215C File Offset: 0x0000035C
		private static Delegate GetIsOpenHandler()
		{
			if (IOpenableInvoker.cb_isOpen == null)
			{
				IOpenableInvoker.cb_isOpen = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IOpenableInvoker.n_IsOpen));
			}
			return IOpenableInvoker.cb_isOpen;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002180 File Offset: 0x00000380
		private static bool n_IsOpen(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IOpenable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsOpen;
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000019 RID: 25 RVA: 0x0000218F File Offset: 0x0000038F
		public bool IsOpen
		{
			get
			{
				if (this.id_isOpen == IntPtr.Zero)
				{
					this.id_isOpen = JNIEnv.GetMethodID(this.class_ref, "isOpen", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isOpen);
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000021CF File Offset: 0x000003CF
		private static Delegate GetCloseHandler()
		{
			if (IOpenableInvoker.cb_close == null)
			{
				IOpenableInvoker.cb_close = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IOpenableInvoker.n_Close));
			}
			return IOpenableInvoker.cb_close;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000021F3 File Offset: 0x000003F3
		private static void n_Close(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IOpenable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Close();
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002202 File Offset: 0x00000402
		public void Close()
		{
			if (this.id_close == IntPtr.Zero)
			{
				this.id_close = JNIEnv.GetMethodID(this.class_ref, "close", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_close);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002242 File Offset: 0x00000442
		private static Delegate GetOpenHandler()
		{
			if (IOpenableInvoker.cb_open == null)
			{
				IOpenableInvoker.cb_open = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IOpenableInvoker.n_Open));
			}
			return IOpenableInvoker.cb_open;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002266 File Offset: 0x00000466
		private static void n_Open(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IOpenable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Open();
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002275 File Offset: 0x00000475
		public void Open()
		{
			if (this.id_open == IntPtr.Zero)
			{
				this.id_open = JNIEnv.GetMethodID(this.class_ref, "open", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_open);
		}

		// Token: 0x04000003 RID: 3
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/customview/widget/Openable", typeof(IOpenableInvoker));

		// Token: 0x04000004 RID: 4
		private IntPtr class_ref;

		// Token: 0x04000005 RID: 5
		private static Delegate cb_isOpen;

		// Token: 0x04000006 RID: 6
		private IntPtr id_isOpen;

		// Token: 0x04000007 RID: 7
		private static Delegate cb_close;

		// Token: 0x04000008 RID: 8
		private IntPtr id_close;

		// Token: 0x04000009 RID: 9
		private static Delegate cb_open;

		// Token: 0x0400000A RID: 10
		private IntPtr id_open;
	}
}
