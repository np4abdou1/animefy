using System;
using Android.Runtime;
using Java.Interop;
using Java.Util;
using Java.Util.Functions;

namespace Java.Lang
{
	// Token: 0x020003D7 RID: 983
	[Register("java/lang/Iterable", "", "Java.Lang.IIterableInvoker")]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public interface IIterable : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06002B44 RID: 11076
		IIterator Iterator();

		// Token: 0x06002B45 RID: 11077 RVA: 0x00078620 File Offset: 0x00076820
		private static Delegate GetForEach_Ljava_util_function_Consumer_Handler()
		{
			if (IIterable.cb_forEach_Ljava_util_function_Consumer_ == null)
			{
				IIterable.cb_forEach_Ljava_util_function_Consumer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IIterable.n_ForEach_Ljava_util_function_Consumer_));
			}
			return IIterable.cb_forEach_Ljava_util_function_Consumer_;
		}

		// Token: 0x06002B46 RID: 11078 RVA: 0x00078644 File Offset: 0x00076844
		private static void n_ForEach_Ljava_util_function_Consumer_(IntPtr jnienv, IntPtr native__this, IntPtr native_action)
		{
			IIterable @object = Object.GetObject<IIterable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IConsumer object2 = Object.GetObject<IConsumer>(native_action, JniHandleOwnership.DoNotTransfer);
			@object.ForEach(object2);
		}

		// Token: 0x06002B47 RID: 11079 RVA: 0x00078668 File Offset: 0x00076868
		unsafe void ForEach(IConsumer action)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((action == null) ? IntPtr.Zero : ((Object)action).Handle);
				IIterable._members.InstanceMethods.InvokeVirtualVoidMethod("forEach.(Ljava/util/function/Consumer;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(action);
			}
		}

		// Token: 0x06002B48 RID: 11080 RVA: 0x000786D0 File Offset: 0x000768D0
		private static Delegate GetSpliteratorHandler()
		{
			if (IIterable.cb_spliterator == null)
			{
				IIterable.cb_spliterator = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IIterable.n_Spliterator));
			}
			return IIterable.cb_spliterator;
		}

		// Token: 0x06002B49 RID: 11081 RVA: 0x000786F4 File Offset: 0x000768F4
		private static IntPtr n_Spliterator(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Object.GetObject<IIterable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Spliterator());
		}

		// Token: 0x06002B4A RID: 11082 RVA: 0x00078708 File Offset: 0x00076908
		ISpliterator Spliterator()
		{
			return Object.GetObject<ISpliterator>(IIterable._members.InstanceMethods.InvokeVirtualObjectMethod("spliterator.()Ljava/util/Spliterator;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400115E RID: 4446
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/lang/Iterable", typeof(IIterable), true);

		// Token: 0x0400115F RID: 4447
		private static Delegate cb_forEach_Ljava_util_function_Consumer_;

		// Token: 0x04001160 RID: 4448
		private static Delegate cb_spliterator;
	}
}
