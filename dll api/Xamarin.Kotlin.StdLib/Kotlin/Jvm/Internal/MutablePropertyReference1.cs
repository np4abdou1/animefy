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
	// Token: 0x020001B9 RID: 441
	[NullableContext(2)]
	[Nullable(0)]
	[Register("kotlin/jvm/internal/MutablePropertyReference1", DoNotGenerateAcw = true)]
	public abstract class MutablePropertyReference1 : MutablePropertyReference, IKMutableProperty1, IKMutableProperty, IKProperty, IKCallable, IKAnnotatedElement, IJavaObject, IDisposable, IJavaPeerable, IKProperty1, IFunction1, IFunction
	{
		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x060015B3 RID: 5555 RVA: 0x000462E4 File Offset: 0x000444E4
		internal new static IntPtr class_ref
		{
			get
			{
				return MutablePropertyReference1._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x060015B4 RID: 5556 RVA: 0x00046308 File Offset: 0x00044508
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return MutablePropertyReference1._members;
			}
		}

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x060015B5 RID: 5557 RVA: 0x00046310 File Offset: 0x00044510
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MutablePropertyReference1._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x060015B6 RID: 5558 RVA: 0x00046334 File Offset: 0x00044534
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return MutablePropertyReference1._members.ManagedPeerType;
			}
		}

		// Token: 0x060015B7 RID: 5559 RVA: 0x00046340 File Offset: 0x00044540
		protected MutablePropertyReference1(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060015B8 RID: 5560 RVA: 0x0004634C File Offset: 0x0004454C
		[Register(".ctor", "()V", "")]
		public MutablePropertyReference1() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(MutablePropertyReference1._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			MutablePropertyReference1._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060015B9 RID: 5561 RVA: 0x000463BC File Offset: 0x000445BC
		[Register(".ctor", "(Ljava/lang/Object;)V", "")]
		public unsafe MutablePropertyReference1(Java.Lang.Object receiver) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((receiver == null) ? IntPtr.Zero : receiver.Handle);
				base.SetHandle(MutablePropertyReference1._members.InstanceMethods.StartCreateInstance("(Ljava/lang/Object;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				MutablePropertyReference1._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(receiver);
			}
		}

		// Token: 0x060015BA RID: 5562 RVA: 0x0004646C File Offset: 0x0004466C
		[Register(".ctor", "(Ljava/lang/Object;Ljava/lang/Class;Ljava/lang/String;Ljava/lang/String;I)V", "")]
		public unsafe MutablePropertyReference1(Java.Lang.Object receiver, Class owner, string name, string signature, int flags) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(name);
			IntPtr intPtr2 = JNIEnv.NewString(signature);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((receiver == null) ? IntPtr.Zero : receiver.Handle);
				ptr[1] = new JniArgumentValue((owner == null) ? IntPtr.Zero : owner.Handle);
				ptr[2] = new JniArgumentValue(intPtr);
				ptr[3] = new JniArgumentValue(intPtr2);
				ptr[4] = new JniArgumentValue(flags);
				base.SetHandle(MutablePropertyReference1._members.InstanceMethods.StartCreateInstance("(Ljava/lang/Object;Ljava/lang/Class;Ljava/lang/String;Ljava/lang/String;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				MutablePropertyReference1._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/Object;Ljava/lang/Class;Ljava/lang/String;Ljava/lang/String;I)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(receiver);
				GC.KeepAlive(owner);
			}
		}

		// Token: 0x060015BB RID: 5563 RVA: 0x000465A0 File Offset: 0x000447A0
		[NullableContext(1)]
		private static Delegate GetGetGetterHandler()
		{
			if (MutablePropertyReference1.cb_getGetter == null)
			{
				MutablePropertyReference1.cb_getGetter = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MutablePropertyReference1.n_GetGetter));
			}
			return MutablePropertyReference1.cb_getGetter;
		}

		// Token: 0x060015BC RID: 5564 RVA: 0x000465C4 File Offset: 0x000447C4
		private static IntPtr n_GetGetter(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MutablePropertyReference1>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Getter);
		}

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x060015BD RID: 5565 RVA: 0x000465D8 File Offset: 0x000447D8
		public override IKPropertyGetter Getter
		{
			[Register("getGetter", "()Lkotlin/reflect/KProperty1$Getter;", "GetGetGetterHandler")]
			get
			{
				return Java.Lang.Object.GetObject<IKPropertyGetter>(MutablePropertyReference1._members.InstanceMethods.InvokeVirtualObjectMethod("getGetter.()Lkotlin/reflect/KProperty1$Getter;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060015BE RID: 5566 RVA: 0x0004660A File Offset: 0x0004480A
		[NullableContext(1)]
		private static Delegate GetGetSetterHandler()
		{
			if (MutablePropertyReference1.cb_getSetter == null)
			{
				MutablePropertyReference1.cb_getSetter = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MutablePropertyReference1.n_GetSetter));
			}
			return MutablePropertyReference1.cb_getSetter;
		}

		// Token: 0x060015BF RID: 5567 RVA: 0x0004662E File Offset: 0x0004482E
		private static IntPtr n_GetSetter(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MutablePropertyReference1>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Setter);
		}

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x060015C0 RID: 5568 RVA: 0x00046644 File Offset: 0x00044844
		public override IKMutablePropertySetter Setter
		{
			[Register("getSetter", "()Lkotlin/reflect/KMutableProperty1$Setter;", "GetGetSetterHandler")]
			get
			{
				return Java.Lang.Object.GetObject<IKMutablePropertySetter>(MutablePropertyReference1._members.InstanceMethods.InvokeVirtualObjectMethod("getSetter.()Lkotlin/reflect/KMutableProperty1$Setter;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060015C1 RID: 5569 RVA: 0x00046676 File Offset: 0x00044876
		[NullableContext(1)]
		private static Delegate GetComputeReflectedHandler()
		{
			if (MutablePropertyReference1.cb_computeReflected == null)
			{
				MutablePropertyReference1.cb_computeReflected = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MutablePropertyReference1.n_ComputeReflected));
			}
			return MutablePropertyReference1.cb_computeReflected;
		}

		// Token: 0x060015C2 RID: 5570 RVA: 0x0004669A File Offset: 0x0004489A
		private static IntPtr n_ComputeReflected(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MutablePropertyReference1>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ComputeReflected());
		}

		// Token: 0x060015C3 RID: 5571 RVA: 0x000466B0 File Offset: 0x000448B0
		[Register("computeReflected", "()Lkotlin/reflect/KCallable;", "GetComputeReflectedHandler")]
		protected override IKCallable ComputeReflected()
		{
			return Java.Lang.Object.GetObject<IKCallable>(MutablePropertyReference1._members.InstanceMethods.InvokeVirtualObjectMethod("computeReflected.()Lkotlin/reflect/KCallable;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060015C4 RID: 5572 RVA: 0x000466E2 File Offset: 0x000448E2
		[NullableContext(1)]
		private static Delegate GetGetDelegate_Ljava_lang_Object_Handler()
		{
			if (MutablePropertyReference1.cb_getDelegate_Ljava_lang_Object_ == null)
			{
				MutablePropertyReference1.cb_getDelegate_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(MutablePropertyReference1.n_GetDelegate_Ljava_lang_Object_));
			}
			return MutablePropertyReference1.cb_getDelegate_Ljava_lang_Object_;
		}

		// Token: 0x060015C5 RID: 5573 RVA: 0x00046708 File Offset: 0x00044908
		private static IntPtr n_GetDelegate_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_receiver)
		{
			MutablePropertyReference1 @object = Java.Lang.Object.GetObject<MutablePropertyReference1>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_receiver, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetDelegate(object2));
		}

		// Token: 0x060015C6 RID: 5574 RVA: 0x00046730 File Offset: 0x00044930
		[Register("getDelegate", "(Ljava/lang/Object;)Ljava/lang/Object;", "GetGetDelegate_Ljava_lang_Object_Handler")]
		public unsafe virtual Java.Lang.Object GetDelegate(Java.Lang.Object receiver)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((receiver == null) ? IntPtr.Zero : receiver.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(MutablePropertyReference1._members.InstanceMethods.InvokeVirtualObjectMethod("getDelegate.(Ljava/lang/Object;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(receiver);
			}
			return @object;
		}

		// Token: 0x060015C7 RID: 5575 RVA: 0x000467A4 File Offset: 0x000449A4
		[NullableContext(1)]
		private static Delegate GetInvoke_Ljava_lang_Object_Handler()
		{
			if (MutablePropertyReference1.cb_invoke_Ljava_lang_Object_ == null)
			{
				MutablePropertyReference1.cb_invoke_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(MutablePropertyReference1.n_Invoke_Ljava_lang_Object_));
			}
			return MutablePropertyReference1.cb_invoke_Ljava_lang_Object_;
		}

		// Token: 0x060015C8 RID: 5576 RVA: 0x000467C8 File Offset: 0x000449C8
		private static IntPtr n_Invoke_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_receiver)
		{
			MutablePropertyReference1 @object = Java.Lang.Object.GetObject<MutablePropertyReference1>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_receiver, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Invoke(object2));
		}

		// Token: 0x060015C9 RID: 5577 RVA: 0x000467F0 File Offset: 0x000449F0
		[Register("invoke", "(Ljava/lang/Object;)Ljava/lang/Object;", "GetInvoke_Ljava_lang_Object_Handler")]
		public unsafe virtual Java.Lang.Object Invoke(Java.Lang.Object receiver)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((receiver == null) ? IntPtr.Zero : receiver.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(MutablePropertyReference1._members.InstanceMethods.InvokeVirtualObjectMethod("invoke.(Ljava/lang/Object;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(receiver);
			}
			return @object;
		}

		// Token: 0x060015CA RID: 5578 RVA: 0x00046864 File Offset: 0x00044A64
		[NullableContext(1)]
		private static Delegate GetGet_Ljava_lang_Object_Handler()
		{
			if (MutablePropertyReference1.cb_get_Ljava_lang_Object_ == null)
			{
				MutablePropertyReference1.cb_get_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(MutablePropertyReference1.n_Get_Ljava_lang_Object_));
			}
			return MutablePropertyReference1.cb_get_Ljava_lang_Object_;
		}

		// Token: 0x060015CB RID: 5579 RVA: 0x00046888 File Offset: 0x00044A88
		private static IntPtr n_Get_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			MutablePropertyReference1 @object = Java.Lang.Object.GetObject<MutablePropertyReference1>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Get(object2));
		}

		// Token: 0x060015CC RID: 5580 RVA: 0x000468B0 File Offset: 0x00044AB0
		[Register("get", "(Ljava/lang/Object;)Ljava/lang/Object;", "GetGet_Ljava_lang_Object_Handler")]
		public unsafe virtual Java.Lang.Object Get(Java.Lang.Object p0)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(MutablePropertyReference1._members.InstanceMethods.InvokeVirtualObjectMethod("get.(Ljava/lang/Object;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return @object;
		}

		// Token: 0x060015CD RID: 5581 RVA: 0x00046924 File Offset: 0x00044B24
		[NullableContext(1)]
		private static Delegate GetSet_Ljava_lang_Object_Ljava_lang_Object_Handler()
		{
			if (MutablePropertyReference1.cb_set_Ljava_lang_Object_Ljava_lang_Object_ == null)
			{
				MutablePropertyReference1.cb_set_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(MutablePropertyReference1.n_Set_Ljava_lang_Object_Ljava_lang_Object_));
			}
			return MutablePropertyReference1.cb_set_Ljava_lang_Object_Ljava_lang_Object_;
		}

		// Token: 0x060015CE RID: 5582 RVA: 0x00046948 File Offset: 0x00044B48
		private static void n_Set_Ljava_lang_Object_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			MutablePropertyReference1 @object = Java.Lang.Object.GetObject<MutablePropertyReference1>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.Set(object2, object3);
		}

		// Token: 0x060015CF RID: 5583 RVA: 0x00046974 File Offset: 0x00044B74
		[Register("set", "(Ljava/lang/Object;Ljava/lang/Object;)V", "GetSet_Ljava_lang_Object_Ljava_lang_Object_Handler")]
		public unsafe virtual void Set(Java.Lang.Object p0, Java.Lang.Object p1)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				MutablePropertyReference1._members.InstanceMethods.InvokeVirtualVoidMethod("set.(Ljava/lang/Object;Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x040006F6 RID: 1782
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/MutablePropertyReference1", typeof(MutablePropertyReference1));

		// Token: 0x040006F7 RID: 1783
		private static Delegate cb_getGetter;

		// Token: 0x040006F8 RID: 1784
		private static Delegate cb_getSetter;

		// Token: 0x040006F9 RID: 1785
		private static Delegate cb_computeReflected;

		// Token: 0x040006FA RID: 1786
		private static Delegate cb_getDelegate_Ljava_lang_Object_;

		// Token: 0x040006FB RID: 1787
		private static Delegate cb_invoke_Ljava_lang_Object_;

		// Token: 0x040006FC RID: 1788
		private static Delegate cb_get_Ljava_lang_Object_;

		// Token: 0x040006FD RID: 1789
		private static Delegate cb_set_Ljava_lang_Object_Ljava_lang_Object_;
	}
}
