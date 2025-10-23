using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util.Functions;

namespace Java.Util
{
	// Token: 0x0200030C RID: 780
	[Register("java/util/Iterator", "", "Java.Util.IIteratorInvoker")]
	[JavaTypeParameters(new string[]
	{
		"E"
	})]
	public interface IIterator : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x06001F94 RID: 8084
		bool HasNext { get; }

		// Token: 0x06001F95 RID: 8085
		Java.Lang.Object Next();

		// Token: 0x06001F96 RID: 8086
		void Remove();

		// Token: 0x06001F97 RID: 8087 RVA: 0x000563EC File Offset: 0x000545EC
		private static Delegate GetForEachRemaining_Ljava_util_function_Consumer_Handler()
		{
			if (IIterator.cb_forEachRemaining_Ljava_util_function_Consumer_ == null)
			{
				IIterator.cb_forEachRemaining_Ljava_util_function_Consumer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IIterator.n_ForEachRemaining_Ljava_util_function_Consumer_));
			}
			return IIterator.cb_forEachRemaining_Ljava_util_function_Consumer_;
		}

		// Token: 0x06001F98 RID: 8088 RVA: 0x00056410 File Offset: 0x00054610
		private static void n_ForEachRemaining_Ljava_util_function_Consumer_(IntPtr jnienv, IntPtr native__this, IntPtr native_action)
		{
			IIterator @object = Java.Lang.Object.GetObject<IIterator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IConsumer object2 = Java.Lang.Object.GetObject<IConsumer>(native_action, JniHandleOwnership.DoNotTransfer);
			@object.ForEachRemaining(object2);
		}

		// Token: 0x06001F99 RID: 8089 RVA: 0x00056434 File Offset: 0x00054634
		unsafe void ForEachRemaining(IConsumer action)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
				IIterator._members.InstanceMethods.InvokeVirtualVoidMethod("forEachRemaining.(Ljava/util/function/Consumer;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(action);
			}
		}

		// Token: 0x04000CED RID: 3309
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/Iterator", typeof(IIterator), true);

		// Token: 0x04000CEE RID: 3310
		private static Delegate cb_forEachRemaining_Ljava_util_function_Consumer_;
	}
}
