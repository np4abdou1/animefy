using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Util.Functions
{
	// Token: 0x0200032D RID: 813
	[Register("java/util/function/BiConsumer", "", "Java.Util.Functions.IBiConsumerInvoker", ApiSince = 24)]
	[JavaTypeParameters(new string[]
	{
		"T",
		"U"
	})]
	public interface IBiConsumer : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060022B8 RID: 8888
		void Accept(Java.Lang.Object t, Java.Lang.Object u);

		// Token: 0x060022B9 RID: 8889 RVA: 0x00061E6D File Offset: 0x0006006D
		private static Delegate GetAndThen_Ljava_util_function_BiConsumer_Handler()
		{
			if (IBiConsumer.cb_andThen_Ljava_util_function_BiConsumer_ == null)
			{
				IBiConsumer.cb_andThen_Ljava_util_function_BiConsumer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IBiConsumer.n_AndThen_Ljava_util_function_BiConsumer_));
			}
			return IBiConsumer.cb_andThen_Ljava_util_function_BiConsumer_;
		}

		// Token: 0x060022BA RID: 8890 RVA: 0x00061E94 File Offset: 0x00060094
		private static IntPtr n_AndThen_Ljava_util_function_BiConsumer_(IntPtr jnienv, IntPtr native__this, IntPtr native_after)
		{
			IBiConsumer @object = Java.Lang.Object.GetObject<IBiConsumer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IBiConsumer object2 = Java.Lang.Object.GetObject<IBiConsumer>(native_after, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.AndThen(object2));
		}

		// Token: 0x060022BB RID: 8891 RVA: 0x00061EBC File Offset: 0x000600BC
		unsafe IBiConsumer AndThen(IBiConsumer after)
		{
			IBiConsumer @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((after == null) ? IntPtr.Zero : ((Java.Lang.Object)after).Handle);
				@object = Java.Lang.Object.GetObject<IBiConsumer>(IBiConsumer._members.InstanceMethods.InvokeVirtualObjectMethod("andThen.(Ljava/util/function/BiConsumer;)Ljava/util/function/BiConsumer;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(after);
			}
			return @object;
		}

		// Token: 0x04000E57 RID: 3671
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/function/BiConsumer", typeof(IBiConsumer), true);

		// Token: 0x04000E58 RID: 3672
		private static Delegate cb_andThen_Ljava_util_function_BiConsumer_;
	}
}
