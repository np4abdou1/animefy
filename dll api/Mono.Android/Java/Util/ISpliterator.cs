using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util.Functions;

namespace Java.Util
{
	// Token: 0x0200031E RID: 798
	[Register("java/util/Spliterator", "", "Java.Util.ISpliteratorInvoker", ApiSince = 24)]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public interface ISpliterator : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060021F7 RID: 8695 RVA: 0x000600F3 File Offset: 0x0005E2F3
		private static Delegate GetGetComparatorHandler()
		{
			if (ISpliterator.cb_getComparator == null)
			{
				ISpliterator.cb_getComparator = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISpliterator.n_GetComparator));
			}
			return ISpliterator.cb_getComparator;
		}

		// Token: 0x060021F8 RID: 8696 RVA: 0x00060117 File Offset: 0x0005E317
		private static IntPtr n_GetComparator(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISpliterator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Comparator);
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x060021F9 RID: 8697 RVA: 0x0006012C File Offset: 0x0005E32C
		IComparator Comparator
		{
			get
			{
				return Java.Lang.Object.GetObject<IComparator>(ISpliterator._members.InstanceMethods.InvokeVirtualObjectMethod("getComparator.()Ljava/util/Comparator;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060021FA RID: 8698 RVA: 0x0006015E File Offset: 0x0005E35E
		private static Delegate GetGetExactSizeIfKnownHandler()
		{
			if (ISpliterator.cb_getExactSizeIfKnown == null)
			{
				ISpliterator.cb_getExactSizeIfKnown = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(ISpliterator.n_GetExactSizeIfKnown));
			}
			return ISpliterator.cb_getExactSizeIfKnown;
		}

		// Token: 0x060021FB RID: 8699 RVA: 0x00060182 File Offset: 0x0005E382
		private static long n_GetExactSizeIfKnown(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ISpliterator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ExactSizeIfKnown;
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x060021FC RID: 8700 RVA: 0x00060191 File Offset: 0x0005E391
		long ExactSizeIfKnown
		{
			get
			{
				return ISpliterator._members.InstanceMethods.InvokeVirtualInt64Method("getExactSizeIfKnown.()J", this, null);
			}
		}

		// Token: 0x060021FD RID: 8701
		[return: GeneratedEnum]
		SpliteratorCharacteristics Characteristics();

		// Token: 0x060021FE RID: 8702
		long EstimateSize();

		// Token: 0x060021FF RID: 8703
		bool TryAdvance(IConsumer action);

		// Token: 0x06002200 RID: 8704
		ISpliterator TrySplit();

		// Token: 0x06002201 RID: 8705 RVA: 0x000601AA File Offset: 0x0005E3AA
		private static Delegate GetForEachRemaining_Ljava_util_function_Consumer_Handler()
		{
			if (ISpliterator.cb_forEachRemaining_Ljava_util_function_Consumer_ == null)
			{
				ISpliterator.cb_forEachRemaining_Ljava_util_function_Consumer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ISpliterator.n_ForEachRemaining_Ljava_util_function_Consumer_));
			}
			return ISpliterator.cb_forEachRemaining_Ljava_util_function_Consumer_;
		}

		// Token: 0x06002202 RID: 8706 RVA: 0x000601D0 File Offset: 0x0005E3D0
		private static void n_ForEachRemaining_Ljava_util_function_Consumer_(IntPtr jnienv, IntPtr native__this, IntPtr native_action)
		{
			ISpliterator @object = Java.Lang.Object.GetObject<ISpliterator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IConsumer object2 = Java.Lang.Object.GetObject<IConsumer>(native_action, JniHandleOwnership.DoNotTransfer);
			@object.ForEachRemaining(object2);
		}

		// Token: 0x06002203 RID: 8707 RVA: 0x000601F4 File Offset: 0x0005E3F4
		unsafe void ForEachRemaining(IConsumer action)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
				ISpliterator._members.InstanceMethods.InvokeVirtualVoidMethod("forEachRemaining.(Ljava/util/function/Consumer;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(action);
			}
		}

		// Token: 0x06002204 RID: 8708 RVA: 0x0006025C File Offset: 0x0005E45C
		private static Delegate GetHasCharacteristics_IHandler()
		{
			if (ISpliterator.cb_hasCharacteristics_I == null)
			{
				ISpliterator.cb_hasCharacteristics_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_Z(ISpliterator.n_HasCharacteristics_I));
			}
			return ISpliterator.cb_hasCharacteristics_I;
		}

		// Token: 0x06002205 RID: 8709 RVA: 0x00060280 File Offset: 0x0005E480
		private static bool n_HasCharacteristics_I(IntPtr jnienv, IntPtr native__this, int characteristics)
		{
			return Java.Lang.Object.GetObject<ISpliterator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HasCharacteristics(characteristics);
		}

		// Token: 0x06002206 RID: 8710 RVA: 0x00060290 File Offset: 0x0005E490
		unsafe bool HasCharacteristics(int characteristics)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(characteristics);
			return ISpliterator._members.InstanceMethods.InvokeVirtualBooleanMethod("hasCharacteristics.(I)Z", this, ptr);
		}

		// Token: 0x04000E08 RID: 3592
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/Spliterator", typeof(ISpliterator), true);

		// Token: 0x04000E09 RID: 3593
		private static Delegate cb_getComparator;

		// Token: 0x04000E0A RID: 3594
		private static Delegate cb_getExactSizeIfKnown;

		// Token: 0x04000E0B RID: 3595
		private static Delegate cb_forEachRemaining_Ljava_util_function_Consumer_;

		// Token: 0x04000E0C RID: 3596
		private static Delegate cb_hasCharacteristics_I;
	}
}
