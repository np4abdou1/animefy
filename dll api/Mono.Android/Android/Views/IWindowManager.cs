using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util.Concurrent;
using Java.Util.Functions;

namespace Android.Views
{
	// Token: 0x0200012C RID: 300
	[Register("android/view/WindowManager", "", "Android.Views.IWindowManagerInvoker")]
	public interface IWindowManager : IViewManager, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x060009FD RID: 2557
		Display DefaultDisplay { get; }

		// Token: 0x060009FE RID: 2558 RVA: 0x00018D97 File Offset: 0x00016F97
		private static Delegate GetGetCurrentWindowMetricsHandler()
		{
			if (IWindowManager.cb_getCurrentWindowMetrics == null)
			{
				IWindowManager.cb_getCurrentWindowMetrics = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IWindowManager.n_GetCurrentWindowMetrics));
			}
			return IWindowManager.cb_getCurrentWindowMetrics;
		}

		// Token: 0x060009FF RID: 2559 RVA: 0x00018DBB File Offset: 0x00016FBB
		private static IntPtr n_GetCurrentWindowMetrics(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IWindowManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CurrentWindowMetrics);
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x06000A00 RID: 2560 RVA: 0x00018DD0 File Offset: 0x00016FD0
		WindowMetrics CurrentWindowMetrics
		{
			get
			{
				return Java.Lang.Object.GetObject<WindowMetrics>(IWindowManager._members.InstanceMethods.InvokeVirtualObjectMethod("getCurrentWindowMetrics.()Landroid/view/WindowMetrics;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000A01 RID: 2561 RVA: 0x00018E02 File Offset: 0x00017002
		private static Delegate GetIsCrossWindowBlurEnabledHandler()
		{
			if (IWindowManager.cb_isCrossWindowBlurEnabled == null)
			{
				IWindowManager.cb_isCrossWindowBlurEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IWindowManager.n_IsCrossWindowBlurEnabled));
			}
			return IWindowManager.cb_isCrossWindowBlurEnabled;
		}

		// Token: 0x06000A02 RID: 2562 RVA: 0x00018E26 File Offset: 0x00017026
		private static bool n_IsCrossWindowBlurEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IWindowManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsCrossWindowBlurEnabled;
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x06000A03 RID: 2563 RVA: 0x00018E35 File Offset: 0x00017035
		bool IsCrossWindowBlurEnabled
		{
			get
			{
				return IWindowManager._members.InstanceMethods.InvokeVirtualBooleanMethod("isCrossWindowBlurEnabled.()Z", this, null);
			}
		}

		// Token: 0x06000A04 RID: 2564 RVA: 0x00018E4E File Offset: 0x0001704E
		private static Delegate GetGetMaximumWindowMetricsHandler()
		{
			if (IWindowManager.cb_getMaximumWindowMetrics == null)
			{
				IWindowManager.cb_getMaximumWindowMetrics = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IWindowManager.n_GetMaximumWindowMetrics));
			}
			return IWindowManager.cb_getMaximumWindowMetrics;
		}

		// Token: 0x06000A05 RID: 2565 RVA: 0x00018E72 File Offset: 0x00017072
		private static IntPtr n_GetMaximumWindowMetrics(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IWindowManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MaximumWindowMetrics);
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06000A06 RID: 2566 RVA: 0x00018E88 File Offset: 0x00017088
		WindowMetrics MaximumWindowMetrics
		{
			get
			{
				return Java.Lang.Object.GetObject<WindowMetrics>(IWindowManager._members.InstanceMethods.InvokeVirtualObjectMethod("getMaximumWindowMetrics.()Landroid/view/WindowMetrics;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000A07 RID: 2567
		void RemoveViewImmediate(View view);

		// Token: 0x06000A08 RID: 2568 RVA: 0x00018EBA File Offset: 0x000170BA
		private static Delegate GetAddCrossWindowBlurEnabledListener_Ljava_util_concurrent_Executor_Ljava_util_function_Consumer_Handler()
		{
			if (IWindowManager.cb_addCrossWindowBlurEnabledListener_Ljava_util_concurrent_Executor_Ljava_util_function_Consumer_ == null)
			{
				IWindowManager.cb_addCrossWindowBlurEnabledListener_Ljava_util_concurrent_Executor_Ljava_util_function_Consumer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IWindowManager.n_AddCrossWindowBlurEnabledListener_Ljava_util_concurrent_Executor_Ljava_util_function_Consumer_));
			}
			return IWindowManager.cb_addCrossWindowBlurEnabledListener_Ljava_util_concurrent_Executor_Ljava_util_function_Consumer_;
		}

		// Token: 0x06000A09 RID: 2569 RVA: 0x00018EE0 File Offset: 0x000170E0
		private static void n_AddCrossWindowBlurEnabledListener_Ljava_util_concurrent_Executor_Ljava_util_function_Consumer_(IntPtr jnienv, IntPtr native__this, IntPtr native_executor, IntPtr native_listener)
		{
			IWindowManager @object = Java.Lang.Object.GetObject<IWindowManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IExecutor object2 = Java.Lang.Object.GetObject<IExecutor>(native_executor, JniHandleOwnership.DoNotTransfer);
			IConsumer object3 = Java.Lang.Object.GetObject<IConsumer>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.AddCrossWindowBlurEnabledListener(object2, object3);
		}

		// Token: 0x06000A0A RID: 2570 RVA: 0x00018F0C File Offset: 0x0001710C
		unsafe void AddCrossWindowBlurEnabledListener(IExecutor executor, IConsumer listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((executor == null) ? IntPtr.Zero : ((Java.Lang.Object)executor).Handle);
				ptr[1] = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				IWindowManager._members.InstanceMethods.InvokeVirtualVoidMethod("addCrossWindowBlurEnabledListener.(Ljava/util/concurrent/Executor;Ljava/util/function/Consumer;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(executor);
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x06000A0B RID: 2571 RVA: 0x00018FA4 File Offset: 0x000171A4
		private static Delegate GetAddCrossWindowBlurEnabledListener_Ljava_util_function_Consumer_Handler()
		{
			if (IWindowManager.cb_addCrossWindowBlurEnabledListener_Ljava_util_function_Consumer_ == null)
			{
				IWindowManager.cb_addCrossWindowBlurEnabledListener_Ljava_util_function_Consumer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IWindowManager.n_AddCrossWindowBlurEnabledListener_Ljava_util_function_Consumer_));
			}
			return IWindowManager.cb_addCrossWindowBlurEnabledListener_Ljava_util_function_Consumer_;
		}

		// Token: 0x06000A0C RID: 2572 RVA: 0x00018FC8 File Offset: 0x000171C8
		private static void n_AddCrossWindowBlurEnabledListener_Ljava_util_function_Consumer_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			IWindowManager @object = Java.Lang.Object.GetObject<IWindowManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IConsumer object2 = Java.Lang.Object.GetObject<IConsumer>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.AddCrossWindowBlurEnabledListener(object2);
		}

		// Token: 0x06000A0D RID: 2573 RVA: 0x00018FEC File Offset: 0x000171EC
		unsafe void AddCrossWindowBlurEnabledListener(IConsumer listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				IWindowManager._members.InstanceMethods.InvokeVirtualVoidMethod("addCrossWindowBlurEnabledListener.(Ljava/util/function/Consumer;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x06000A0E RID: 2574 RVA: 0x00019054 File Offset: 0x00017254
		private static Delegate GetRemoveCrossWindowBlurEnabledListener_Ljava_util_function_Consumer_Handler()
		{
			if (IWindowManager.cb_removeCrossWindowBlurEnabledListener_Ljava_util_function_Consumer_ == null)
			{
				IWindowManager.cb_removeCrossWindowBlurEnabledListener_Ljava_util_function_Consumer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IWindowManager.n_RemoveCrossWindowBlurEnabledListener_Ljava_util_function_Consumer_));
			}
			return IWindowManager.cb_removeCrossWindowBlurEnabledListener_Ljava_util_function_Consumer_;
		}

		// Token: 0x06000A0F RID: 2575 RVA: 0x00019078 File Offset: 0x00017278
		private static void n_RemoveCrossWindowBlurEnabledListener_Ljava_util_function_Consumer_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			IWindowManager @object = Java.Lang.Object.GetObject<IWindowManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IConsumer object2 = Java.Lang.Object.GetObject<IConsumer>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.RemoveCrossWindowBlurEnabledListener(object2);
		}

		// Token: 0x06000A10 RID: 2576 RVA: 0x0001909C File Offset: 0x0001729C
		unsafe void RemoveCrossWindowBlurEnabledListener(IConsumer listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				IWindowManager._members.InstanceMethods.InvokeVirtualVoidMethod("removeCrossWindowBlurEnabledListener.(Ljava/util/function/Consumer;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x0400033C RID: 828
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/view/WindowManager", typeof(IWindowManager), true);

		// Token: 0x0400033D RID: 829
		private static Delegate cb_getCurrentWindowMetrics;

		// Token: 0x0400033E RID: 830
		private static Delegate cb_isCrossWindowBlurEnabled;

		// Token: 0x0400033F RID: 831
		private static Delegate cb_getMaximumWindowMetrics;

		// Token: 0x04000340 RID: 832
		private static Delegate cb_addCrossWindowBlurEnabledListener_Ljava_util_concurrent_Executor_Ljava_util_function_Consumer_;

		// Token: 0x04000341 RID: 833
		private static Delegate cb_addCrossWindowBlurEnabledListener_Ljava_util_function_Consumer_;

		// Token: 0x04000342 RID: 834
		private static Delegate cb_removeCrossWindowBlurEnabledListener_Ljava_util_function_Consumer_;
	}
}
