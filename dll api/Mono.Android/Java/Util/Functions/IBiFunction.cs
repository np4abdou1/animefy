using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Util.Functions
{
	// Token: 0x0200032F RID: 815
	[Register("java/util/function/BiFunction", "", "Java.Util.Functions.IBiFunctionInvoker", ApiSince = 24)]
	[JavaTypeParameters(new string[]
	{
		"T",
		"U",
		"R"
	})]
	public interface IBiFunction : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060022C8 RID: 8904
		Java.Lang.Object Apply(Java.Lang.Object t, Java.Lang.Object u);

		// Token: 0x060022C9 RID: 8905 RVA: 0x00062120 File Offset: 0x00060320
		private static Delegate GetAndThen_Ljava_util_function_Function_Handler()
		{
			if (IBiFunction.cb_andThen_Ljava_util_function_Function_ == null)
			{
				IBiFunction.cb_andThen_Ljava_util_function_Function_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IBiFunction.n_AndThen_Ljava_util_function_Function_));
			}
			return IBiFunction.cb_andThen_Ljava_util_function_Function_;
		}

		// Token: 0x060022CA RID: 8906 RVA: 0x00062144 File Offset: 0x00060344
		private static IntPtr n_AndThen_Ljava_util_function_Function_(IntPtr jnienv, IntPtr native__this, IntPtr native_after)
		{
			IBiFunction @object = Java.Lang.Object.GetObject<IBiFunction>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IFunction object2 = Java.Lang.Object.GetObject<IFunction>(native_after, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.AndThen(object2));
		}

		// Token: 0x060022CB RID: 8907 RVA: 0x0006216C File Offset: 0x0006036C
		[JavaTypeParameters(new string[]
		{
			"V"
		})]
		unsafe IBiFunction AndThen(IFunction after)
		{
			IBiFunction @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((after == null) ? IntPtr.Zero : ((Java.Lang.Object)after).Handle);
				@object = Java.Lang.Object.GetObject<IBiFunction>(IBiFunction._members.InstanceMethods.InvokeVirtualObjectMethod("andThen.(Ljava/util/function/Function;)Ljava/util/function/BiFunction;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(after);
			}
			return @object;
		}

		// Token: 0x04000E5D RID: 3677
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/function/BiFunction", typeof(IBiFunction), true);

		// Token: 0x04000E5E RID: 3678
		private static Delegate cb_andThen_Ljava_util_function_Function_;
	}
}
