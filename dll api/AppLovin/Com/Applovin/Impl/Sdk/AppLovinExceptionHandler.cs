using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Impl.Sdk
{
	// Token: 0x02000130 RID: 304
	[Register("com/applovin/impl/sdk/AppLovinExceptionHandler", DoNotGenerateAcw = true)]
	public class AppLovinExceptionHandler : Java.Lang.Object, Thread.IUncaughtExceptionHandler, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06000DD8 RID: 3544 RVA: 0x0002583C File Offset: 0x00023A3C
		internal static IntPtr class_ref
		{
			get
			{
				return AppLovinExceptionHandler._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06000DD9 RID: 3545 RVA: 0x00025860 File Offset: 0x00023A60
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AppLovinExceptionHandler._members;
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06000DDA RID: 3546 RVA: 0x00025868 File Offset: 0x00023A68
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AppLovinExceptionHandler._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06000DDB RID: 3547 RVA: 0x0002588C File Offset: 0x00023A8C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AppLovinExceptionHandler._members.ManagedPeerType;
			}
		}

		// Token: 0x06000DDC RID: 3548 RVA: 0x000021F0 File Offset: 0x000003F0
		protected AppLovinExceptionHandler(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000DDD RID: 3549 RVA: 0x00025898 File Offset: 0x00023A98
		[Register(".ctor", "()V", "")]
		public AppLovinExceptionHandler() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(AppLovinExceptionHandler._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			AppLovinExceptionHandler._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000DDE RID: 3550 RVA: 0x00025906 File Offset: 0x00023B06
		private static Delegate GetEnableHandler()
		{
			if (AppLovinExceptionHandler.cb_enable == null)
			{
				AppLovinExceptionHandler.cb_enable = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(AppLovinExceptionHandler.n_Enable));
			}
			return AppLovinExceptionHandler.cb_enable;
		}

		// Token: 0x06000DDF RID: 3551 RVA: 0x0002592A File Offset: 0x00023B2A
		private static void n_Enable(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<AppLovinExceptionHandler>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Enable();
		}

		// Token: 0x06000DE0 RID: 3552 RVA: 0x00025939 File Offset: 0x00023B39
		[Register("enable", "()V", "GetEnableHandler")]
		public virtual void Enable()
		{
			AppLovinExceptionHandler._members.InstanceMethods.InvokeVirtualVoidMethod("enable.()V", this, null);
		}

		// Token: 0x06000DE1 RID: 3553 RVA: 0x00025954 File Offset: 0x00023B54
		[Register("shared", "()Lcom/applovin/impl/sdk/AppLovinExceptionHandler;", "")]
		public static AppLovinExceptionHandler Shared()
		{
			return Java.Lang.Object.GetObject<AppLovinExceptionHandler>(AppLovinExceptionHandler._members.StaticMethods.InvokeObjectMethod("shared.()Lcom/applovin/impl/sdk/AppLovinExceptionHandler;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000DE2 RID: 3554 RVA: 0x00025985 File Offset: 0x00023B85
		private static Delegate GetUncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_Handler()
		{
			if (AppLovinExceptionHandler.cb_uncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_ == null)
			{
				AppLovinExceptionHandler.cb_uncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(AppLovinExceptionHandler.n_UncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_));
			}
			return AppLovinExceptionHandler.cb_uncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_;
		}

		// Token: 0x06000DE3 RID: 3555 RVA: 0x000259AC File Offset: 0x00023BAC
		private static void n_UncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			AppLovinExceptionHandler @object = Java.Lang.Object.GetObject<AppLovinExceptionHandler>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Thread object2 = Java.Lang.Object.GetObject<Thread>(native_p0, JniHandleOwnership.DoNotTransfer);
			Throwable object3 = Java.Lang.Object.GetObject<Throwable>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.UncaughtException(object2, object3);
		}

		// Token: 0x06000DE4 RID: 3556 RVA: 0x000259D8 File Offset: 0x00023BD8
		[Register("uncaughtException", "(Ljava/lang/Thread;Ljava/lang/Throwable;)V", "GetUncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_Handler")]
		public unsafe virtual void UncaughtException(Thread p0, Throwable p1)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				AppLovinExceptionHandler._members.InstanceMethods.InvokeVirtualVoidMethod("uncaughtException.(Ljava/lang/Thread;Ljava/lang/Throwable;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x040004CA RID: 1226
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/impl/sdk/AppLovinExceptionHandler", typeof(AppLovinExceptionHandler));

		// Token: 0x040004CB RID: 1227
		private static Delegate cb_enable;

		// Token: 0x040004CC RID: 1228
		private static Delegate cb_uncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_;
	}
}
