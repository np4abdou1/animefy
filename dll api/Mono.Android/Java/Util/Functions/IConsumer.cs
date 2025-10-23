using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Util.Functions
{
	// Token: 0x02000331 RID: 817
	[Register("java/util/function/Consumer", "", "Java.Util.Functions.IConsumerInvoker", ApiSince = 24)]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public interface IConsumer : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060022D8 RID: 8920
		void Accept(Java.Lang.Object t);

		// Token: 0x060022D9 RID: 8921 RVA: 0x000623DE File Offset: 0x000605DE
		private static Delegate GetAndThen_Ljava_util_function_Consumer_Handler()
		{
			if (IConsumer.cb_andThen_Ljava_util_function_Consumer_ == null)
			{
				IConsumer.cb_andThen_Ljava_util_function_Consumer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IConsumer.n_AndThen_Ljava_util_function_Consumer_));
			}
			return IConsumer.cb_andThen_Ljava_util_function_Consumer_;
		}

		// Token: 0x060022DA RID: 8922 RVA: 0x00062404 File Offset: 0x00060604
		private static IntPtr n_AndThen_Ljava_util_function_Consumer_(IntPtr jnienv, IntPtr native__this, IntPtr native_after)
		{
			IConsumer @object = Java.Lang.Object.GetObject<IConsumer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IConsumer object2 = Java.Lang.Object.GetObject<IConsumer>(native_after, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.AndThen(object2));
		}

		// Token: 0x060022DB RID: 8923 RVA: 0x0006242C File Offset: 0x0006062C
		unsafe IConsumer AndThen(IConsumer after)
		{
			IConsumer @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((after == null) ? IntPtr.Zero : ((Java.Lang.Object)after).Handle);
				@object = Java.Lang.Object.GetObject<IConsumer>(IConsumer._members.InstanceMethods.InvokeVirtualObjectMethod("andThen.(Ljava/util/function/Consumer;)Ljava/util/function/Consumer;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(after);
			}
			return @object;
		}

		// Token: 0x04000E63 RID: 3683
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/function/Consumer", typeof(IConsumer), true);

		// Token: 0x04000E64 RID: 3684
		private static Delegate cb_andThen_Ljava_util_function_Consumer_;
	}
}
