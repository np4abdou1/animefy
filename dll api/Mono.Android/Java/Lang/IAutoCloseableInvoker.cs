using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Java.Lang
{
	// Token: 0x020003CF RID: 975
	[Register("java/lang/AutoCloseable", DoNotGenerateAcw = true)]
	internal class IAutoCloseableInvoker : Object, IAutoCloseable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000867 RID: 2151
		// (get) Token: 0x06002B05 RID: 11013 RVA: 0x00077E30 File Offset: 0x00076030
		private static IntPtr java_class_ref
		{
			get
			{
				return IAutoCloseableInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000868 RID: 2152
		// (get) Token: 0x06002B06 RID: 11014 RVA: 0x00077E54 File Offset: 0x00076054
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IAutoCloseableInvoker._members;
			}
		}

		// Token: 0x17000869 RID: 2153
		// (get) Token: 0x06002B07 RID: 11015 RVA: 0x00077E5B File Offset: 0x0007605B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700086A RID: 2154
		// (get) Token: 0x06002B08 RID: 11016 RVA: 0x00077E63 File Offset: 0x00076063
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IAutoCloseableInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06002B09 RID: 11017 RVA: 0x00077E6F File Offset: 0x0007606F
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IAutoCloseableInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.lang.AutoCloseable'.");
			}
			return handle;
		}

		// Token: 0x06002B0A RID: 11018 RVA: 0x00077E9A File Offset: 0x0007609A
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06002B0B RID: 11019 RVA: 0x00077ECC File Offset: 0x000760CC
		public IAutoCloseableInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IAutoCloseableInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06002B0C RID: 11020 RVA: 0x00077F04 File Offset: 0x00076104
		private static Delegate GetCloseHandler()
		{
			if (IAutoCloseableInvoker.cb_close == null)
			{
				IAutoCloseableInvoker.cb_close = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IAutoCloseableInvoker.n_Close));
			}
			return IAutoCloseableInvoker.cb_close;
		}

		// Token: 0x06002B0D RID: 11021 RVA: 0x00077F28 File Offset: 0x00076128
		private static void n_Close(IntPtr jnienv, IntPtr native__this)
		{
			Object.GetObject<IAutoCloseable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Close();
		}

		// Token: 0x06002B0E RID: 11022 RVA: 0x00077F37 File Offset: 0x00076137
		public void Close()
		{
			if (this.id_close == IntPtr.Zero)
			{
				this.id_close = JNIEnv.GetMethodID(this.class_ref, "close", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_close);
		}

		// Token: 0x04001146 RID: 4422
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/lang/AutoCloseable", typeof(IAutoCloseableInvoker));

		// Token: 0x04001147 RID: 4423
		private IntPtr class_ref;

		// Token: 0x04001148 RID: 4424
		private static Delegate cb_close;

		// Token: 0x04001149 RID: 4425
		private IntPtr id_close;
	}
}
