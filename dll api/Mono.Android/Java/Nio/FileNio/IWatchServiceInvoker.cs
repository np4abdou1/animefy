using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;
using Java.Util.Concurrent;

namespace Java.Nio.FileNio
{
	// Token: 0x0200038E RID: 910
	[Register("java/nio/file/WatchService", DoNotGenerateAcw = true, ApiSince = 26)]
	internal class IWatchServiceInvoker : Java.Lang.Object, IWatchService, ICloseable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x06002846 RID: 10310 RVA: 0x000723AC File Offset: 0x000705AC
		private static IntPtr java_class_ref
		{
			get
			{
				return IWatchServiceInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x06002847 RID: 10311 RVA: 0x000723D0 File Offset: 0x000705D0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IWatchServiceInvoker._members;
			}
		}

		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x06002848 RID: 10312 RVA: 0x000723D7 File Offset: 0x000705D7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x06002849 RID: 10313 RVA: 0x000723DF File Offset: 0x000705DF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IWatchServiceInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600284A RID: 10314 RVA: 0x000723EB File Offset: 0x000705EB
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IWatchServiceInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.nio.file.WatchService'.");
			}
			return handle;
		}

		// Token: 0x0600284B RID: 10315 RVA: 0x00072416 File Offset: 0x00070616
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600284C RID: 10316 RVA: 0x00072448 File Offset: 0x00070648
		public IWatchServiceInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IWatchServiceInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600284D RID: 10317 RVA: 0x00072480 File Offset: 0x00070680
		private static Delegate GetCloseHandler()
		{
			if (IWatchServiceInvoker.cb_close == null)
			{
				IWatchServiceInvoker.cb_close = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IWatchServiceInvoker.n_Close));
			}
			return IWatchServiceInvoker.cb_close;
		}

		// Token: 0x0600284E RID: 10318 RVA: 0x000724A4 File Offset: 0x000706A4
		private static void n_Close(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IWatchService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Close();
		}

		// Token: 0x0600284F RID: 10319 RVA: 0x000724B3 File Offset: 0x000706B3
		public void Close()
		{
			if (this.id_close == IntPtr.Zero)
			{
				this.id_close = JNIEnv.GetMethodID(this.class_ref, "close", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_close);
		}

		// Token: 0x06002850 RID: 10320 RVA: 0x000724F3 File Offset: 0x000706F3
		private static Delegate GetPollHandler()
		{
			if (IWatchServiceInvoker.cb_poll == null)
			{
				IWatchServiceInvoker.cb_poll = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IWatchServiceInvoker.n_Poll));
			}
			return IWatchServiceInvoker.cb_poll;
		}

		// Token: 0x06002851 RID: 10321 RVA: 0x00072517 File Offset: 0x00070717
		private static IntPtr n_Poll(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IWatchService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Poll());
		}

		// Token: 0x06002852 RID: 10322 RVA: 0x0007252C File Offset: 0x0007072C
		public IWatchKey Poll()
		{
			if (this.id_poll == IntPtr.Zero)
			{
				this.id_poll = JNIEnv.GetMethodID(this.class_ref, "poll", "()Ljava/nio/file/WatchKey;");
			}
			return Java.Lang.Object.GetObject<IWatchKey>(JNIEnv.CallObjectMethod(base.Handle, this.id_poll), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06002853 RID: 10323 RVA: 0x0007257D File Offset: 0x0007077D
		private static Delegate GetPoll_JLjava_util_concurrent_TimeUnit_Handler()
		{
			if (IWatchServiceInvoker.cb_poll_JLjava_util_concurrent_TimeUnit_ == null)
			{
				IWatchServiceInvoker.cb_poll_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPJL_L(IWatchServiceInvoker.n_Poll_JLjava_util_concurrent_TimeUnit_));
			}
			return IWatchServiceInvoker.cb_poll_JLjava_util_concurrent_TimeUnit_;
		}

		// Token: 0x06002854 RID: 10324 RVA: 0x000725A4 File Offset: 0x000707A4
		private static IntPtr n_Poll_JLjava_util_concurrent_TimeUnit_(IntPtr jnienv, IntPtr native__this, long timeout, IntPtr native_unit)
		{
			IWatchService @object = Java.Lang.Object.GetObject<IWatchService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TimeUnit object2 = Java.Lang.Object.GetObject<TimeUnit>(native_unit, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Poll(timeout, object2));
		}

		// Token: 0x06002855 RID: 10325 RVA: 0x000725D0 File Offset: 0x000707D0
		public unsafe IWatchKey Poll(long timeout, TimeUnit unit)
		{
			if (this.id_poll_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
			{
				this.id_poll_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID(this.class_ref, "poll", "(JLjava/util/concurrent/TimeUnit;)Ljava/nio/file/WatchKey;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(timeout);
			ptr[1] = new JValue((unit == null) ? IntPtr.Zero : unit.Handle);
			return Java.Lang.Object.GetObject<IWatchKey>(JNIEnv.CallObjectMethod(base.Handle, this.id_poll_JLjava_util_concurrent_TimeUnit_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06002856 RID: 10326 RVA: 0x0007265C File Offset: 0x0007085C
		private static Delegate GetTakeHandler()
		{
			if (IWatchServiceInvoker.cb_take == null)
			{
				IWatchServiceInvoker.cb_take = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IWatchServiceInvoker.n_Take));
			}
			return IWatchServiceInvoker.cb_take;
		}

		// Token: 0x06002857 RID: 10327 RVA: 0x00072680 File Offset: 0x00070880
		private static IntPtr n_Take(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IWatchService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Take());
		}

		// Token: 0x06002858 RID: 10328 RVA: 0x00072694 File Offset: 0x00070894
		public IWatchKey Take()
		{
			if (this.id_take == IntPtr.Zero)
			{
				this.id_take = JNIEnv.GetMethodID(this.class_ref, "take", "()Ljava/nio/file/WatchKey;");
			}
			return Java.Lang.Object.GetObject<IWatchKey>(JNIEnv.CallObjectMethod(base.Handle, this.id_take), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400108D RID: 4237
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/nio/file/WatchService", typeof(IWatchServiceInvoker));

		// Token: 0x0400108E RID: 4238
		private IntPtr class_ref;

		// Token: 0x0400108F RID: 4239
		private static Delegate cb_close;

		// Token: 0x04001090 RID: 4240
		private IntPtr id_close;

		// Token: 0x04001091 RID: 4241
		private static Delegate cb_poll;

		// Token: 0x04001092 RID: 4242
		private IntPtr id_poll;

		// Token: 0x04001093 RID: 4243
		private static Delegate cb_poll_JLjava_util_concurrent_TimeUnit_;

		// Token: 0x04001094 RID: 4244
		private IntPtr id_poll_JLjava_util_concurrent_TimeUnit_;

		// Token: 0x04001095 RID: 4245
		private static Delegate cb_take;

		// Token: 0x04001096 RID: 4246
		private IntPtr id_take;
	}
}
