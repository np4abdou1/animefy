using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Util.Functions
{
	// Token: 0x02000333 RID: 819
	[Register("java/util/function/Function", "", "Java.Util.Functions.IFunctionInvoker", ApiSince = 24)]
	[JavaTypeParameters(new string[]
	{
		"T",
		"R"
	})]
	public interface IFunction : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060022E8 RID: 8936
		Java.Lang.Object Apply(Java.Lang.Object t);

		// Token: 0x060022E9 RID: 8937 RVA: 0x00062668 File Offset: 0x00060868
		private static Delegate GetAndThen_Ljava_util_function_Function_Handler()
		{
			if (IFunction.cb_andThen_Ljava_util_function_Function_ == null)
			{
				IFunction.cb_andThen_Ljava_util_function_Function_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IFunction.n_AndThen_Ljava_util_function_Function_));
			}
			return IFunction.cb_andThen_Ljava_util_function_Function_;
		}

		// Token: 0x060022EA RID: 8938 RVA: 0x0006268C File Offset: 0x0006088C
		private static IntPtr n_AndThen_Ljava_util_function_Function_(IntPtr jnienv, IntPtr native__this, IntPtr native_after)
		{
			IFunction @object = Java.Lang.Object.GetObject<IFunction>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IFunction object2 = Java.Lang.Object.GetObject<IFunction>(native_after, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.AndThen(object2));
		}

		// Token: 0x060022EB RID: 8939 RVA: 0x000626B4 File Offset: 0x000608B4
		[JavaTypeParameters(new string[]
		{
			"V"
		})]
		unsafe IFunction AndThen(IFunction after)
		{
			IFunction @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((after == null) ? IntPtr.Zero : ((Java.Lang.Object)after).Handle);
				@object = Java.Lang.Object.GetObject<IFunction>(IFunction._members.InstanceMethods.InvokeVirtualObjectMethod("andThen.(Ljava/util/function/Function;)Ljava/util/function/Function;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(after);
			}
			return @object;
		}

		// Token: 0x060022EC RID: 8940 RVA: 0x0006272C File Offset: 0x0006092C
		private static Delegate GetCompose_Ljava_util_function_Function_Handler()
		{
			if (IFunction.cb_compose_Ljava_util_function_Function_ == null)
			{
				IFunction.cb_compose_Ljava_util_function_Function_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IFunction.n_Compose_Ljava_util_function_Function_));
			}
			return IFunction.cb_compose_Ljava_util_function_Function_;
		}

		// Token: 0x060022ED RID: 8941 RVA: 0x00062750 File Offset: 0x00060950
		private static IntPtr n_Compose_Ljava_util_function_Function_(IntPtr jnienv, IntPtr native__this, IntPtr native_before)
		{
			IFunction @object = Java.Lang.Object.GetObject<IFunction>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IFunction object2 = Java.Lang.Object.GetObject<IFunction>(native_before, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Compose(object2));
		}

		// Token: 0x060022EE RID: 8942 RVA: 0x00062778 File Offset: 0x00060978
		[JavaTypeParameters(new string[]
		{
			"V"
		})]
		unsafe IFunction Compose(IFunction before)
		{
			IFunction @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((before == null) ? IntPtr.Zero : ((Java.Lang.Object)before).Handle);
				@object = Java.Lang.Object.GetObject<IFunction>(IFunction._members.InstanceMethods.InvokeVirtualObjectMethod("compose.(Ljava/util/function/Function;)Ljava/util/function/Function;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(before);
			}
			return @object;
		}

		// Token: 0x060022EF RID: 8943 RVA: 0x000627F0 File Offset: 0x000609F0
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public static IFunction Identity()
		{
			return Java.Lang.Object.GetObject<IFunction>(IFunction._members.StaticMethods.InvokeObjectMethod("identity.()Ljava/util/function/Function;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000E69 RID: 3689
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/function/Function", typeof(IFunction), true);

		// Token: 0x04000E6A RID: 3690
		private static Delegate cb_andThen_Ljava_util_function_Function_;

		// Token: 0x04000E6B RID: 3691
		private static Delegate cb_compose_Ljava_util_function_Function_;
	}
}
