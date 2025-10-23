using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Jvm.Functions;
using Kotlin.Reflect;

namespace Kotlin.Jvm.Internal
{
	// Token: 0x020001BB RID: 443
	[NullableContext(2)]
	[Nullable(0)]
	[Register("kotlin/jvm/internal/MutablePropertyReference2", DoNotGenerateAcw = true)]
	public abstract class MutablePropertyReference2 : MutablePropertyReference, IKMutableProperty2, IKMutableProperty, IKProperty, IKCallable, IKAnnotatedElement, IJavaObject, IDisposable, IJavaPeerable, IKProperty2, IFunction2, IFunction
	{
		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x060015D5 RID: 5589 RVA: 0x00046A54 File Offset: 0x00044C54
		internal new static IntPtr class_ref
		{
			get
			{
				return MutablePropertyReference2._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x060015D6 RID: 5590 RVA: 0x00046A78 File Offset: 0x00044C78
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return MutablePropertyReference2._members;
			}
		}

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x060015D7 RID: 5591 RVA: 0x00046A80 File Offset: 0x00044C80
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MutablePropertyReference2._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x060015D8 RID: 5592 RVA: 0x00046AA4 File Offset: 0x00044CA4
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return MutablePropertyReference2._members.ManagedPeerType;
			}
		}

		// Token: 0x060015D9 RID: 5593 RVA: 0x00046AB0 File Offset: 0x00044CB0
		protected MutablePropertyReference2(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060015DA RID: 5594 RVA: 0x00046ABC File Offset: 0x00044CBC
		[Register(".ctor", "()V", "")]
		public MutablePropertyReference2() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(MutablePropertyReference2._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			MutablePropertyReference2._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060015DB RID: 5595 RVA: 0x00046B2C File Offset: 0x00044D2C
		[Register(".ctor", "(Ljava/lang/Class;Ljava/lang/String;Ljava/lang/String;I)V", "")]
		public unsafe MutablePropertyReference2(Class owner, string name, string signature, int flags) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(name);
			IntPtr intPtr2 = JNIEnv.NewString(signature);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((owner == null) ? IntPtr.Zero : owner.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue(intPtr2);
				ptr[3] = new JniArgumentValue(flags);
				base.SetHandle(MutablePropertyReference2._members.InstanceMethods.StartCreateInstance("(Ljava/lang/Class;Ljava/lang/String;Ljava/lang/String;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				MutablePropertyReference2._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/Class;Ljava/lang/String;Ljava/lang/String;I)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(owner);
			}
		}

		// Token: 0x060015DC RID: 5596 RVA: 0x00046C34 File Offset: 0x00044E34
		[NullableContext(1)]
		private static Delegate GetGetGetterHandler()
		{
			if (MutablePropertyReference2.cb_getGetter == null)
			{
				MutablePropertyReference2.cb_getGetter = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MutablePropertyReference2.n_GetGetter));
			}
			return MutablePropertyReference2.cb_getGetter;
		}

		// Token: 0x060015DD RID: 5597 RVA: 0x00046C58 File Offset: 0x00044E58
		private static IntPtr n_GetGetter(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MutablePropertyReference2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Getter);
		}

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x060015DE RID: 5598 RVA: 0x00046C6C File Offset: 0x00044E6C
		public override IKPropertyGetter Getter
		{
			[Register("getGetter", "()Lkotlin/reflect/KProperty2$Getter;", "GetGetGetterHandler")]
			get
			{
				return Java.Lang.Object.GetObject<IKPropertyGetter>(MutablePropertyReference2._members.InstanceMethods.InvokeVirtualObjectMethod("getGetter.()Lkotlin/reflect/KProperty2$Getter;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060015DF RID: 5599 RVA: 0x00046C9E File Offset: 0x00044E9E
		[NullableContext(1)]
		private static Delegate GetGetSetterHandler()
		{
			if (MutablePropertyReference2.cb_getSetter == null)
			{
				MutablePropertyReference2.cb_getSetter = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MutablePropertyReference2.n_GetSetter));
			}
			return MutablePropertyReference2.cb_getSetter;
		}

		// Token: 0x060015E0 RID: 5600 RVA: 0x00046CC2 File Offset: 0x00044EC2
		private static IntPtr n_GetSetter(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MutablePropertyReference2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Setter);
		}

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x060015E1 RID: 5601 RVA: 0x00046CD8 File Offset: 0x00044ED8
		public override IKMutablePropertySetter Setter
		{
			[Register("getSetter", "()Lkotlin/reflect/KMutableProperty2$Setter;", "GetGetSetterHandler")]
			get
			{
				return Java.Lang.Object.GetObject<IKMutablePropertySetter>(MutablePropertyReference2._members.InstanceMethods.InvokeVirtualObjectMethod("getSetter.()Lkotlin/reflect/KMutableProperty2$Setter;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060015E2 RID: 5602 RVA: 0x00046D0A File Offset: 0x00044F0A
		[NullableContext(1)]
		private static Delegate GetComputeReflectedHandler()
		{
			if (MutablePropertyReference2.cb_computeReflected == null)
			{
				MutablePropertyReference2.cb_computeReflected = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MutablePropertyReference2.n_ComputeReflected));
			}
			return MutablePropertyReference2.cb_computeReflected;
		}

		// Token: 0x060015E3 RID: 5603 RVA: 0x00046D2E File Offset: 0x00044F2E
		private static IntPtr n_ComputeReflected(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MutablePropertyReference2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ComputeReflected());
		}

		// Token: 0x060015E4 RID: 5604 RVA: 0x00046D44 File Offset: 0x00044F44
		[Register("computeReflected", "()Lkotlin/reflect/KCallable;", "GetComputeReflectedHandler")]
		protected override IKCallable ComputeReflected()
		{
			return Java.Lang.Object.GetObject<IKCallable>(MutablePropertyReference2._members.InstanceMethods.InvokeVirtualObjectMethod("computeReflected.()Lkotlin/reflect/KCallable;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060015E5 RID: 5605 RVA: 0x00046D76 File Offset: 0x00044F76
		[NullableContext(1)]
		private static Delegate GetGetDelegate_Ljava_lang_Object_Ljava_lang_Object_Handler()
		{
			if (MutablePropertyReference2.cb_getDelegate_Ljava_lang_Object_Ljava_lang_Object_ == null)
			{
				MutablePropertyReference2.cb_getDelegate_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(MutablePropertyReference2.n_GetDelegate_Ljava_lang_Object_Ljava_lang_Object_));
			}
			return MutablePropertyReference2.cb_getDelegate_Ljava_lang_Object_Ljava_lang_Object_;
		}

		// Token: 0x060015E6 RID: 5606 RVA: 0x00046D9C File Offset: 0x00044F9C
		private static IntPtr n_GetDelegate_Ljava_lang_Object_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_receiver1, IntPtr native_receiver2)
		{
			MutablePropertyReference2 @object = Java.Lang.Object.GetObject<MutablePropertyReference2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_receiver1, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_receiver2, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetDelegate(object2, object3));
		}

		// Token: 0x060015E7 RID: 5607 RVA: 0x00046DD0 File Offset: 0x00044FD0
		[Register("getDelegate", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", "GetGetDelegate_Ljava_lang_Object_Ljava_lang_Object_Handler")]
		public unsafe virtual Java.Lang.Object GetDelegate(Java.Lang.Object receiver1, Java.Lang.Object receiver2)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((receiver1 == null) ? IntPtr.Zero : receiver1.Handle);
				ptr[1] = new JniArgumentValue((receiver2 == null) ? IntPtr.Zero : receiver2.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(MutablePropertyReference2._members.InstanceMethods.InvokeVirtualObjectMethod("getDelegate.(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(receiver1);
				GC.KeepAlive(receiver2);
			}
			return @object;
		}

		// Token: 0x060015E8 RID: 5608 RVA: 0x00046E6C File Offset: 0x0004506C
		[NullableContext(1)]
		private static Delegate GetInvoke_Ljava_lang_Object_Ljava_lang_Object_Handler()
		{
			if (MutablePropertyReference2.cb_invoke_Ljava_lang_Object_Ljava_lang_Object_ == null)
			{
				MutablePropertyReference2.cb_invoke_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(MutablePropertyReference2.n_Invoke_Ljava_lang_Object_Ljava_lang_Object_));
			}
			return MutablePropertyReference2.cb_invoke_Ljava_lang_Object_Ljava_lang_Object_;
		}

		// Token: 0x060015E9 RID: 5609 RVA: 0x00046E90 File Offset: 0x00045090
		private static IntPtr n_Invoke_Ljava_lang_Object_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_receiver1, IntPtr native_receiver2)
		{
			MutablePropertyReference2 @object = Java.Lang.Object.GetObject<MutablePropertyReference2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_receiver1, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_receiver2, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Invoke(object2, object3));
		}

		// Token: 0x060015EA RID: 5610 RVA: 0x00046EC4 File Offset: 0x000450C4
		[Register("invoke", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", "GetInvoke_Ljava_lang_Object_Ljava_lang_Object_Handler")]
		public unsafe virtual Java.Lang.Object Invoke(Java.Lang.Object receiver1, Java.Lang.Object receiver2)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((receiver1 == null) ? IntPtr.Zero : receiver1.Handle);
				ptr[1] = new JniArgumentValue((receiver2 == null) ? IntPtr.Zero : receiver2.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(MutablePropertyReference2._members.InstanceMethods.InvokeVirtualObjectMethod("invoke.(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(receiver1);
				GC.KeepAlive(receiver2);
			}
			return @object;
		}

		// Token: 0x060015EB RID: 5611 RVA: 0x00046F60 File Offset: 0x00045160
		[NullableContext(1)]
		private static Delegate GetGet_Ljava_lang_Object_Ljava_lang_Object_Handler()
		{
			if (MutablePropertyReference2.cb_get_Ljava_lang_Object_Ljava_lang_Object_ == null)
			{
				MutablePropertyReference2.cb_get_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(MutablePropertyReference2.n_Get_Ljava_lang_Object_Ljava_lang_Object_));
			}
			return MutablePropertyReference2.cb_get_Ljava_lang_Object_Ljava_lang_Object_;
		}

		// Token: 0x060015EC RID: 5612 RVA: 0x00046F84 File Offset: 0x00045184
		private static IntPtr n_Get_Ljava_lang_Object_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p01)
		{
			MutablePropertyReference2 @object = Java.Lang.Object.GetObject<MutablePropertyReference2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p01, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Get(object2, object3));
		}

		// Token: 0x060015ED RID: 5613 RVA: 0x00046FB8 File Offset: 0x000451B8
		[Register("get", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", "GetGet_Ljava_lang_Object_Ljava_lang_Object_Handler")]
		public unsafe virtual Java.Lang.Object Get(Java.Lang.Object p0, Java.Lang.Object p01)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue((p01 == null) ? IntPtr.Zero : p01.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(MutablePropertyReference2._members.InstanceMethods.InvokeVirtualObjectMethod("get.(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p01);
			}
			return @object;
		}

		// Token: 0x060015EE RID: 5614 RVA: 0x00047054 File Offset: 0x00045254
		[NullableContext(1)]
		private static Delegate GetSet_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Handler()
		{
			if (MutablePropertyReference2.cb_set_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ == null)
			{
				MutablePropertyReference2.cb_set_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(MutablePropertyReference2.n_Set_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_));
			}
			return MutablePropertyReference2.cb_set_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_;
		}

		// Token: 0x060015EF RID: 5615 RVA: 0x00047078 File Offset: 0x00045278
		private static void n_Set_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			MutablePropertyReference2 @object = Java.Lang.Object.GetObject<MutablePropertyReference2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p1, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object4 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p2, JniHandleOwnership.DoNotTransfer);
			@object.Set(object2, object3, object4);
		}

		// Token: 0x060015F0 RID: 5616 RVA: 0x000470B0 File Offset: 0x000452B0
		[Register("set", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)V", "GetSet_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_Handler")]
		public unsafe virtual void Set(Java.Lang.Object p0, Java.Lang.Object p1, Java.Lang.Object p2)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : p2.Handle);
				MutablePropertyReference2._members.InstanceMethods.InvokeVirtualVoidMethod("set.(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
				GC.KeepAlive(p2);
			}
		}

		// Token: 0x040006FF RID: 1791
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/MutablePropertyReference2", typeof(MutablePropertyReference2));

		// Token: 0x04000700 RID: 1792
		private static Delegate cb_getGetter;

		// Token: 0x04000701 RID: 1793
		private static Delegate cb_getSetter;

		// Token: 0x04000702 RID: 1794
		private static Delegate cb_computeReflected;

		// Token: 0x04000703 RID: 1795
		private static Delegate cb_getDelegate_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x04000704 RID: 1796
		private static Delegate cb_invoke_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x04000705 RID: 1797
		private static Delegate cb_get_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x04000706 RID: 1798
		private static Delegate cb_set_Ljava_lang_Object_Ljava_lang_Object_Ljava_lang_Object_;
	}
}
