using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Nio.FileNio
{
	// Token: 0x0200038A RID: 906
	[Register("java/nio/file/WatchEvent", DoNotGenerateAcw = true, ApiSince = 26)]
	internal class IWatchEventInvoker : Java.Lang.Object, IWatchEvent, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x06002815 RID: 10261 RVA: 0x00071DDC File Offset: 0x0006FFDC
		private static IntPtr java_class_ref
		{
			get
			{
				return IWatchEventInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x06002816 RID: 10262 RVA: 0x00071E00 File Offset: 0x00070000
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IWatchEventInvoker._members;
			}
		}

		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x06002817 RID: 10263 RVA: 0x00071E07 File Offset: 0x00070007
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170007A6 RID: 1958
		// (get) Token: 0x06002818 RID: 10264 RVA: 0x00071E0F File Offset: 0x0007000F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IWatchEventInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06002819 RID: 10265 RVA: 0x00071E1B File Offset: 0x0007001B
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IWatchEventInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.nio.file.WatchEvent'.");
			}
			return handle;
		}

		// Token: 0x0600281A RID: 10266 RVA: 0x00071E46 File Offset: 0x00070046
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600281B RID: 10267 RVA: 0x00071E78 File Offset: 0x00070078
		public IWatchEventInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IWatchEventInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600281C RID: 10268 RVA: 0x00071EB0 File Offset: 0x000700B0
		private static Delegate GetContextHandler()
		{
			if (IWatchEventInvoker.cb_context == null)
			{
				IWatchEventInvoker.cb_context = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IWatchEventInvoker.n_Context));
			}
			return IWatchEventInvoker.cb_context;
		}

		// Token: 0x0600281D RID: 10269 RVA: 0x00071ED4 File Offset: 0x000700D4
		private static IntPtr n_Context(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IWatchEvent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Context());
		}

		// Token: 0x0600281E RID: 10270 RVA: 0x00071EE8 File Offset: 0x000700E8
		public Java.Lang.Object Context()
		{
			if (this.id_context == IntPtr.Zero)
			{
				this.id_context = JNIEnv.GetMethodID(this.class_ref, "context", "()Ljava/lang/Object;");
			}
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_context), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600281F RID: 10271 RVA: 0x00071F39 File Offset: 0x00070139
		private static Delegate GetCountHandler()
		{
			if (IWatchEventInvoker.cb_count == null)
			{
				IWatchEventInvoker.cb_count = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IWatchEventInvoker.n_Count));
			}
			return IWatchEventInvoker.cb_count;
		}

		// Token: 0x06002820 RID: 10272 RVA: 0x00071F5D File Offset: 0x0007015D
		private static int n_Count(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IWatchEvent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Count();
		}

		// Token: 0x06002821 RID: 10273 RVA: 0x00071F6C File Offset: 0x0007016C
		public int Count()
		{
			if (this.id_count == IntPtr.Zero)
			{
				this.id_count = JNIEnv.GetMethodID(this.class_ref, "count", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_count);
		}

		// Token: 0x06002822 RID: 10274 RVA: 0x00071FAC File Offset: 0x000701AC
		private static Delegate GetKindHandler()
		{
			if (IWatchEventInvoker.cb_kind == null)
			{
				IWatchEventInvoker.cb_kind = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IWatchEventInvoker.n_Kind));
			}
			return IWatchEventInvoker.cb_kind;
		}

		// Token: 0x06002823 RID: 10275 RVA: 0x00071FD0 File Offset: 0x000701D0
		private static IntPtr n_Kind(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IWatchEvent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Kind());
		}

		// Token: 0x06002824 RID: 10276 RVA: 0x00071FE4 File Offset: 0x000701E4
		public IWatchEventKind Kind()
		{
			if (this.id_kind == IntPtr.Zero)
			{
				this.id_kind = JNIEnv.GetMethodID(this.class_ref, "kind", "()Ljava/nio/file/WatchEvent$Kind;");
			}
			return Java.Lang.Object.GetObject<IWatchEventKind>(JNIEnv.CallObjectMethod(base.Handle, this.id_kind), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04001079 RID: 4217
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/nio/file/WatchEvent", typeof(IWatchEventInvoker));

		// Token: 0x0400107A RID: 4218
		private IntPtr class_ref;

		// Token: 0x0400107B RID: 4219
		private static Delegate cb_context;

		// Token: 0x0400107C RID: 4220
		private IntPtr id_context;

		// Token: 0x0400107D RID: 4221
		private static Delegate cb_count;

		// Token: 0x0400107E RID: 4222
		private IntPtr id_count;

		// Token: 0x0400107F RID: 4223
		private static Delegate cb_kind;

		// Token: 0x04001080 RID: 4224
		private IntPtr id_kind;
	}
}
