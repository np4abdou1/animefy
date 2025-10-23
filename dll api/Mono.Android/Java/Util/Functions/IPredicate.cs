using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Util.Functions
{
	// Token: 0x02000337 RID: 823
	[Register("java/util/function/Predicate", "", "Java.Util.Functions.IPredicateInvoker", ApiSince = 24)]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public interface IPredicate : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06002308 RID: 8968
		bool Test(Java.Lang.Object t);

		// Token: 0x06002309 RID: 8969 RVA: 0x00062B89 File Offset: 0x00060D89
		private static Delegate GetAnd_Ljava_util_function_Predicate_Handler()
		{
			if (IPredicate.cb_and_Ljava_util_function_Predicate_ == null)
			{
				IPredicate.cb_and_Ljava_util_function_Predicate_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IPredicate.n_And_Ljava_util_function_Predicate_));
			}
			return IPredicate.cb_and_Ljava_util_function_Predicate_;
		}

		// Token: 0x0600230A RID: 8970 RVA: 0x00062BB0 File Offset: 0x00060DB0
		private static IntPtr n_And_Ljava_util_function_Predicate_(IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			IPredicate @object = Java.Lang.Object.GetObject<IPredicate>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IPredicate object2 = Java.Lang.Object.GetObject<IPredicate>(native_other, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.And(object2));
		}

		// Token: 0x0600230B RID: 8971 RVA: 0x00062BD8 File Offset: 0x00060DD8
		unsafe IPredicate And(IPredicate other)
		{
			IPredicate @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
				@object = Java.Lang.Object.GetObject<IPredicate>(IPredicate._members.InstanceMethods.InvokeVirtualObjectMethod("and.(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(other);
			}
			return @object;
		}

		// Token: 0x0600230C RID: 8972 RVA: 0x00062C50 File Offset: 0x00060E50
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IPredicate IsEqual(Java.Lang.Object targetRef)
		{
			IPredicate @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((targetRef == null) ? IntPtr.Zero : targetRef.Handle);
				@object = Java.Lang.Object.GetObject<IPredicate>(IPredicate._members.StaticMethods.InvokeObjectMethod("isEqual.(Ljava/lang/Object;)Ljava/util/function/Predicate;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(targetRef);
			}
			return @object;
		}

		// Token: 0x0600230D RID: 8973 RVA: 0x00062CC4 File Offset: 0x00060EC4
		private static Delegate GetNegateHandler()
		{
			if (IPredicate.cb_negate == null)
			{
				IPredicate.cb_negate = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IPredicate.n_Negate));
			}
			return IPredicate.cb_negate;
		}

		// Token: 0x0600230E RID: 8974 RVA: 0x00062CE8 File Offset: 0x00060EE8
		private static IntPtr n_Negate(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IPredicate>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Negate());
		}

		// Token: 0x0600230F RID: 8975 RVA: 0x00062CFC File Offset: 0x00060EFC
		IPredicate Negate()
		{
			return Java.Lang.Object.GetObject<IPredicate>(IPredicate._members.InstanceMethods.InvokeVirtualObjectMethod("negate.()Ljava/util/function/Predicate;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06002310 RID: 8976 RVA: 0x00062D30 File Offset: 0x00060F30
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IPredicate Not(IPredicate target)
		{
			IPredicate @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((target == null) ? IntPtr.Zero : ((Java.Lang.Object)target).Handle);
				@object = Java.Lang.Object.GetObject<IPredicate>(IPredicate._members.StaticMethods.InvokeObjectMethod("not.(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(target);
			}
			return @object;
		}

		// Token: 0x06002311 RID: 8977 RVA: 0x00062DA8 File Offset: 0x00060FA8
		private static Delegate GetOr_Ljava_util_function_Predicate_Handler()
		{
			if (IPredicate.cb_or_Ljava_util_function_Predicate_ == null)
			{
				IPredicate.cb_or_Ljava_util_function_Predicate_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IPredicate.n_Or_Ljava_util_function_Predicate_));
			}
			return IPredicate.cb_or_Ljava_util_function_Predicate_;
		}

		// Token: 0x06002312 RID: 8978 RVA: 0x00062DCC File Offset: 0x00060FCC
		private static IntPtr n_Or_Ljava_util_function_Predicate_(IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			IPredicate @object = Java.Lang.Object.GetObject<IPredicate>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IPredicate object2 = Java.Lang.Object.GetObject<IPredicate>(native_other, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Or(object2));
		}

		// Token: 0x06002313 RID: 8979 RVA: 0x00062DF4 File Offset: 0x00060FF4
		unsafe IPredicate Or(IPredicate other)
		{
			IPredicate @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
				@object = Java.Lang.Object.GetObject<IPredicate>(IPredicate._members.InstanceMethods.InvokeVirtualObjectMethod("or.(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(other);
			}
			return @object;
		}

		// Token: 0x04000E74 RID: 3700
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/function/Predicate", typeof(IPredicate), true);

		// Token: 0x04000E75 RID: 3701
		private static Delegate cb_and_Ljava_util_function_Predicate_;

		// Token: 0x04000E76 RID: 3702
		private static Delegate cb_negate;

		// Token: 0x04000E77 RID: 3703
		private static Delegate cb_or_Ljava_util_function_Predicate_;
	}
}
