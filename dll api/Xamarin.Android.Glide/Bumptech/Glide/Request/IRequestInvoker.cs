using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Request
{
	// Token: 0x0200008C RID: 140
	[Register("com/bumptech/glide/request/Request", DoNotGenerateAcw = true)]
	internal class IRequestInvoker : Java.Lang.Object, IRequest, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000169 RID: 361
		// (get) Token: 0x0600071D RID: 1821 RVA: 0x00016664 File Offset: 0x00014864
		private static IntPtr java_class_ref
		{
			get
			{
				return IRequestInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x0600071E RID: 1822 RVA: 0x00016688 File Offset: 0x00014888
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IRequestInvoker._members;
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x0600071F RID: 1823 RVA: 0x0001668F File Offset: 0x0001488F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000720 RID: 1824 RVA: 0x00016697 File Offset: 0x00014897
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IRequestInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x000166A3 File Offset: 0x000148A3
		public static IRequest GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IRequest>(handle, transfer);
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x000166AC File Offset: 0x000148AC
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IRequestInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.bumptech.glide.request.Request'.");
			}
			return handle;
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x000166D7 File Offset: 0x000148D7
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x00016708 File Offset: 0x00014908
		public IRequestInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IRequestInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x00016740 File Offset: 0x00014940
		private static Delegate GetIsAnyResourceSetHandler()
		{
			if (IRequestInvoker.cb_isAnyResourceSet == null)
			{
				IRequestInvoker.cb_isAnyResourceSet = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IRequestInvoker.n_IsAnyResourceSet));
			}
			return IRequestInvoker.cb_isAnyResourceSet;
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x00016764 File Offset: 0x00014964
		private static bool n_IsAnyResourceSet(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsAnyResourceSet;
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000727 RID: 1831 RVA: 0x00016773 File Offset: 0x00014973
		public bool IsAnyResourceSet
		{
			get
			{
				if (this.id_isAnyResourceSet == IntPtr.Zero)
				{
					this.id_isAnyResourceSet = JNIEnv.GetMethodID(this.class_ref, "isAnyResourceSet", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isAnyResourceSet);
			}
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x000167B3 File Offset: 0x000149B3
		private static Delegate GetIsClearedHandler()
		{
			if (IRequestInvoker.cb_isCleared == null)
			{
				IRequestInvoker.cb_isCleared = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IRequestInvoker.n_IsCleared));
			}
			return IRequestInvoker.cb_isCleared;
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x000167D7 File Offset: 0x000149D7
		private static bool n_IsCleared(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsCleared;
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x0600072A RID: 1834 RVA: 0x000167E6 File Offset: 0x000149E6
		public bool IsCleared
		{
			get
			{
				if (this.id_isCleared == IntPtr.Zero)
				{
					this.id_isCleared = JNIEnv.GetMethodID(this.class_ref, "isCleared", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isCleared);
			}
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x00016826 File Offset: 0x00014A26
		private static Delegate GetIsCompleteHandler()
		{
			if (IRequestInvoker.cb_isComplete == null)
			{
				IRequestInvoker.cb_isComplete = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IRequestInvoker.n_IsComplete));
			}
			return IRequestInvoker.cb_isComplete;
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x0001684A File Offset: 0x00014A4A
		private static bool n_IsComplete(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsComplete;
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x0600072D RID: 1837 RVA: 0x00016859 File Offset: 0x00014A59
		public bool IsComplete
		{
			get
			{
				if (this.id_isComplete == IntPtr.Zero)
				{
					this.id_isComplete = JNIEnv.GetMethodID(this.class_ref, "isComplete", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isComplete);
			}
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x00016899 File Offset: 0x00014A99
		private static Delegate GetIsRunningHandler()
		{
			if (IRequestInvoker.cb_isRunning == null)
			{
				IRequestInvoker.cb_isRunning = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IRequestInvoker.n_IsRunning));
			}
			return IRequestInvoker.cb_isRunning;
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x000168BD File Offset: 0x00014ABD
		private static bool n_IsRunning(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsRunning;
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000730 RID: 1840 RVA: 0x000168CC File Offset: 0x00014ACC
		public bool IsRunning
		{
			get
			{
				if (this.id_isRunning == IntPtr.Zero)
				{
					this.id_isRunning = JNIEnv.GetMethodID(this.class_ref, "isRunning", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isRunning);
			}
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x0001690C File Offset: 0x00014B0C
		private static Delegate GetBeginHandler()
		{
			if (IRequestInvoker.cb_begin == null)
			{
				IRequestInvoker.cb_begin = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IRequestInvoker.n_Begin));
			}
			return IRequestInvoker.cb_begin;
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x00016930 File Offset: 0x00014B30
		private static void n_Begin(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Begin();
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x0001693F File Offset: 0x00014B3F
		public void Begin()
		{
			if (this.id_begin == IntPtr.Zero)
			{
				this.id_begin = JNIEnv.GetMethodID(this.class_ref, "begin", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_begin);
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x0001697F File Offset: 0x00014B7F
		private static Delegate GetClearHandler()
		{
			if (IRequestInvoker.cb_clear == null)
			{
				IRequestInvoker.cb_clear = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IRequestInvoker.n_Clear));
			}
			return IRequestInvoker.cb_clear;
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x000169A3 File Offset: 0x00014BA3
		private static void n_Clear(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Clear();
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x000169B2 File Offset: 0x00014BB2
		public void Clear()
		{
			if (this.id_clear == IntPtr.Zero)
			{
				this.id_clear = JNIEnv.GetMethodID(this.class_ref, "clear", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_clear);
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x000169F2 File Offset: 0x00014BF2
		private static Delegate GetIsEquivalentTo_Lcom_bumptech_glide_request_Request_Handler()
		{
			if (IRequestInvoker.cb_isEquivalentTo_Lcom_bumptech_glide_request_Request_ == null)
			{
				IRequestInvoker.cb_isEquivalentTo_Lcom_bumptech_glide_request_Request_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IRequestInvoker.n_IsEquivalentTo_Lcom_bumptech_glide_request_Request_));
			}
			return IRequestInvoker.cb_isEquivalentTo_Lcom_bumptech_glide_request_Request_;
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x00016A18 File Offset: 0x00014C18
		private static bool n_IsEquivalentTo_Lcom_bumptech_glide_request_Request_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IRequest @object = Java.Lang.Object.GetObject<IRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IRequest object2 = Java.Lang.Object.GetObject<IRequest>(native_p0, JniHandleOwnership.DoNotTransfer);
			return @object.IsEquivalentTo(object2);
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x00016A3C File Offset: 0x00014C3C
		public unsafe bool IsEquivalentTo(IRequest p0)
		{
			if (this.id_isEquivalentTo_Lcom_bumptech_glide_request_Request_ == IntPtr.Zero)
			{
				this.id_isEquivalentTo_Lcom_bumptech_glide_request_Request_ = JNIEnv.GetMethodID(this.class_ref, "isEquivalentTo", "(Lcom/bumptech/glide/request/Request;)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_isEquivalentTo_Lcom_bumptech_glide_request_Request_, ptr);
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x00016AB4 File Offset: 0x00014CB4
		private static Delegate GetPauseHandler()
		{
			if (IRequestInvoker.cb_pause == null)
			{
				IRequestInvoker.cb_pause = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IRequestInvoker.n_Pause));
			}
			return IRequestInvoker.cb_pause;
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x00016AD8 File Offset: 0x00014CD8
		private static void n_Pause(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Pause();
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x00016AE7 File Offset: 0x00014CE7
		public void Pause()
		{
			if (this.id_pause == IntPtr.Zero)
			{
				this.id_pause = JNIEnv.GetMethodID(this.class_ref, "pause", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_pause);
		}

		// Token: 0x040001A3 RID: 419
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/request/Request", typeof(IRequestInvoker));

		// Token: 0x040001A4 RID: 420
		private IntPtr class_ref;

		// Token: 0x040001A5 RID: 421
		private static Delegate cb_isAnyResourceSet;

		// Token: 0x040001A6 RID: 422
		private IntPtr id_isAnyResourceSet;

		// Token: 0x040001A7 RID: 423
		private static Delegate cb_isCleared;

		// Token: 0x040001A8 RID: 424
		private IntPtr id_isCleared;

		// Token: 0x040001A9 RID: 425
		private static Delegate cb_isComplete;

		// Token: 0x040001AA RID: 426
		private IntPtr id_isComplete;

		// Token: 0x040001AB RID: 427
		private static Delegate cb_isRunning;

		// Token: 0x040001AC RID: 428
		private IntPtr id_isRunning;

		// Token: 0x040001AD RID: 429
		private static Delegate cb_begin;

		// Token: 0x040001AE RID: 430
		private IntPtr id_begin;

		// Token: 0x040001AF RID: 431
		private static Delegate cb_clear;

		// Token: 0x040001B0 RID: 432
		private IntPtr id_clear;

		// Token: 0x040001B1 RID: 433
		private static Delegate cb_isEquivalentTo_Lcom_bumptech_glide_request_Request_;

		// Token: 0x040001B2 RID: 434
		private IntPtr id_isEquivalentTo_Lcom_bumptech_glide_request_Request_;

		// Token: 0x040001B3 RID: 435
		private static Delegate cb_pause;

		// Token: 0x040001B4 RID: 436
		private IntPtr id_pause;
	}
}
