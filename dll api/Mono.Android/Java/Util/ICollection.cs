using System;
using System.Collections;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util.Functions;

namespace Java.Util
{
	// Token: 0x02000306 RID: 774
	[Register("java/util/Collection", "", "Java.Util.ICollectionInvoker")]
	[JavaTypeParameters(new string[]
	{
		"E"
	})]
	public interface ICollection : IIterable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x06001F03 RID: 7939
		bool IsEmpty { get; }

		// Token: 0x06001F04 RID: 7940
		bool Add(Java.Lang.Object e);

		// Token: 0x06001F05 RID: 7941
		bool AddAll(ICollection c);

		// Token: 0x06001F06 RID: 7942
		void Clear();

		// Token: 0x06001F07 RID: 7943
		bool Contains(Java.Lang.Object o);

		// Token: 0x06001F08 RID: 7944
		bool ContainsAll(ICollection c);

		// Token: 0x06001F09 RID: 7945
		bool Equals(Java.Lang.Object o);

		// Token: 0x06001F0A RID: 7946
		int GetHashCode();

		// Token: 0x06001F0B RID: 7947
		IIterator Iterator();

		// Token: 0x06001F0C RID: 7948
		bool Remove(Java.Lang.Object o);

		// Token: 0x06001F0D RID: 7949
		bool RemoveAll(ICollection c);

		// Token: 0x06001F0E RID: 7950
		bool RetainAll(ICollection c);

		// Token: 0x06001F0F RID: 7951
		int Size();

		// Token: 0x06001F10 RID: 7952
		Java.Lang.Object[] ToArray();

		// Token: 0x06001F11 RID: 7953
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		Java.Lang.Object[] ToArray(Java.Lang.Object[] a);

		// Token: 0x06001F12 RID: 7954 RVA: 0x000548E9 File Offset: 0x00052AE9
		private static Delegate GetRemoveIf_Ljava_util_function_Predicate_Handler()
		{
			if (ICollection.cb_removeIf_Ljava_util_function_Predicate_ == null)
			{
				ICollection.cb_removeIf_Ljava_util_function_Predicate_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(ICollection.n_RemoveIf_Ljava_util_function_Predicate_));
			}
			return ICollection.cb_removeIf_Ljava_util_function_Predicate_;
		}

		// Token: 0x06001F13 RID: 7955 RVA: 0x00054910 File Offset: 0x00052B10
		private static bool n_RemoveIf_Ljava_util_function_Predicate_(IntPtr jnienv, IntPtr native__this, IntPtr native_filter)
		{
			ICollection @object = Java.Lang.Object.GetObject<ICollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IPredicate object2 = Java.Lang.Object.GetObject<IPredicate>(native_filter, JniHandleOwnership.DoNotTransfer);
			return @object.RemoveIf(object2);
		}

		// Token: 0x06001F14 RID: 7956 RVA: 0x00054934 File Offset: 0x00052B34
		unsafe bool RemoveIf(IPredicate filter)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((filter == null) ? IntPtr.Zero : ((Java.Lang.Object)filter).Handle);
				result = ICollection._members.InstanceMethods.InvokeVirtualBooleanMethod("removeIf.(Ljava/util/function/Predicate;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(filter);
			}
			return result;
		}

		// Token: 0x06001F15 RID: 7957 RVA: 0x000549A0 File Offset: 0x00052BA0
		private static Delegate GetSpliteratorHandler()
		{
			if (ICollection.cb_spliterator == null)
			{
				ICollection.cb_spliterator = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ICollection.n_Spliterator));
			}
			return ICollection.cb_spliterator;
		}

		// Token: 0x06001F16 RID: 7958 RVA: 0x000549C4 File Offset: 0x00052BC4
		private static IntPtr n_Spliterator(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ICollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Spliterator());
		}

		// Token: 0x06001F17 RID: 7959 RVA: 0x000549D8 File Offset: 0x00052BD8
		ISpliterator Spliterator()
		{
			return Java.Lang.Object.GetObject<ISpliterator>(ICollection._members.InstanceMethods.InvokeVirtualObjectMethod("spliterator.()Ljava/util/Spliterator;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001F18 RID: 7960 RVA: 0x00054A0A File Offset: 0x00052C0A
		private static Delegate GetToArray_Ljava_util_function_IntFunction_Handler()
		{
			if (ICollection.cb_toArray_Ljava_util_function_IntFunction_ == null)
			{
				ICollection.cb_toArray_Ljava_util_function_IntFunction_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ICollection.n_ToArray_Ljava_util_function_IntFunction_));
			}
			return ICollection.cb_toArray_Ljava_util_function_IntFunction_;
		}

		// Token: 0x06001F19 RID: 7961 RVA: 0x00054A30 File Offset: 0x00052C30
		private static IntPtr n_ToArray_Ljava_util_function_IntFunction_(IntPtr jnienv, IntPtr native__this, IntPtr native_generator)
		{
			ICollection @object = Java.Lang.Object.GetObject<ICollection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IIntFunction object2 = Java.Lang.Object.GetObject<IIntFunction>(native_generator, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray<Java.Lang.Object>(@object.ToArray(object2));
		}

		// Token: 0x06001F1A RID: 7962 RVA: 0x00054A58 File Offset: 0x00052C58
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		unsafe Java.Lang.Object[] ToArray(IIntFunction generator)
		{
			Java.Lang.Object[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((generator == null) ? IntPtr.Zero : ((Java.Lang.Object)generator).Handle);
				result = (Java.Lang.Object[])JNIEnv.GetArray(ICollection._members.InstanceMethods.InvokeVirtualObjectMethod("toArray.(Ljava/util/function/IntFunction;)[Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(Java.Lang.Object));
			}
			finally
			{
				GC.KeepAlive(generator);
			}
			return result;
		}

		// Token: 0x04000CB3 RID: 3251
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/Collection", typeof(ICollection), true);

		// Token: 0x04000CB4 RID: 3252
		private static Delegate cb_removeIf_Ljava_util_function_Predicate_;

		// Token: 0x04000CB5 RID: 3253
		private static Delegate cb_spliterator;

		// Token: 0x04000CB6 RID: 3254
		private static Delegate cb_toArray_Ljava_util_function_IntFunction_;
	}
}
