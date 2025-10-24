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
	// Token: 0x020001C4 RID: 452
	[NullableContext(2)]
	[Nullable(0)]
	[Register("kotlin/jvm/internal/PropertyReference1", DoNotGenerateAcw = true)]
	public abstract class PropertyReference1 : PropertyReference, IKProperty1, IFunction1, IFunction, IJavaObject, IDisposable, IJavaPeerable, IKProperty, IKCallable, IKAnnotatedElement
	{
		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x06001647 RID: 5703 RVA: 0x00048044 File Offset: 0x00046244
		internal new static IntPtr class_ref
		{
			get
			{
				return PropertyReference1._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x06001648 RID: 5704 RVA: 0x00048068 File Offset: 0x00046268
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return PropertyReference1._members;
			}
		}

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x06001649 RID: 5705 RVA: 0x00048070 File Offset: 0x00046270
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return PropertyReference1._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x0600164A RID: 5706 RVA: 0x00048094 File Offset: 0x00046294
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return PropertyReference1._members.ManagedPeerType;
			}
		}

		// Token: 0x0600164B RID: 5707 RVA: 0x000480A0 File Offset: 0x000462A0
		protected PropertyReference1(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600164C RID: 5708 RVA: 0x000480AC File Offset: 0x000462AC
		[Register(".ctor", "()V", "")]
		public PropertyReference1() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(PropertyReference1._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			PropertyReference1._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x0600164D RID: 5709 RVA: 0x0004811C File Offset: 0x0004631C
		[Register(".ctor", "(Ljava/lang/Object;)V", "")]
		public unsafe PropertyReference1(Java.Lang.Object receiver) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((receiver == null) ? IntPtr.Zero : receiver.Handle);
				base.SetHandle(PropertyReference1._members.InstanceMethods.StartCreateInstance("(Ljava/lang/Object;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				PropertyReference1._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(receiver);
			}
		}

		// Token: 0x0600164E RID: 5710 RVA: 0x000481CC File Offset: 0x000463CC
		[Register(".ctor", "(Ljava/lang/Object;Ljava/lang/Class;Ljava/lang/String;Ljava/lang/String;I)V", "")]
		public unsafe PropertyReference1(Java.Lang.Object receiver, Class owner, string name, string signature, int flags) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(PropertyReference1._members.InstanceMethods.StartCreateInstance("(Ljava/lang/Object;Ljava/lang/Class;Ljava/lang/String;Ljava/lang/String;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				PropertyReference1._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/Object;Ljava/lang/Class;Ljava/lang/String;Ljava/lang/String;I)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(receiver);
				GC.KeepAlive(owner);
			}
		}

		// Token: 0x0600164F RID: 5711 RVA: 0x00048300 File Offset: 0x00046500
		[NullableContext(1)]
		private static Delegate GetGetGetterHandler()
		{
			if (PropertyReference1.cb_getGetter == null)
			{
				PropertyReference1.cb_getGetter = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(PropertyReference1.n_GetGetter));
			}
			return PropertyReference1.cb_getGetter;
		}

		// Token: 0x06001650 RID: 5712 RVA: 0x00048324 File Offset: 0x00046524
		private static IntPtr n_GetGetter(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<PropertyReference1>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Getter);
		}

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x06001651 RID: 5713 RVA: 0x00048338 File Offset: 0x00046538
		public override IKPropertyGetter Getter
		{
			[Register("getGetter", "()Lkotlin/reflect/KProperty1$Getter;", "GetGetGetterHandler")]
			get
			{
				return Java.Lang.Object.GetObject<IKPropertyGetter>(PropertyReference1._members.InstanceMethods.InvokeVirtualObjectMethod("getGetter.()Lkotlin/reflect/KProperty1$Getter;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06001652 RID: 5714 RVA: 0x0004836A File Offset: 0x0004656A
		[NullableContext(1)]
		private static Delegate GetComputeReflectedHandler()
		{
			if (PropertyReference1.cb_computeReflected == null)
			{
				PropertyReference1.cb_computeReflected = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(PropertyReference1.n_ComputeReflected));
			}
			return PropertyReference1.cb_computeReflected;
		}

		// Token: 0x06001653 RID: 5715 RVA: 0x0004838E File Offset: 0x0004658E
		private static IntPtr n_ComputeReflected(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<PropertyReference1>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ComputeReflected());
		}

		// Token: 0x06001654 RID: 5716 RVA: 0x000483A4 File Offset: 0x000465A4
		[Register("computeReflected", "()Lkotlin/reflect/KCallable;", "GetComputeReflectedHandler")]
		protected override IKCallable ComputeReflected()
		{
			return Java.Lang.Object.GetObject<IKCallable>(PropertyReference1._members.InstanceMethods.InvokeVirtualObjectMethod("computeReflected.()Lkotlin/reflect/KCallable;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001655 RID: 5717 RVA: 0x000483D6 File Offset: 0x000465D6
		[NullableContext(1)]
		private static Delegate GetGetDelegate_Ljava_lang_Object_Handler()
		{
			if (PropertyReference1.cb_getDelegate_Ljava_lang_Object_ == null)
			{
				PropertyReference1.cb_getDelegate_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(PropertyReference1.n_GetDelegate_Ljava_lang_Object_));
			}
			return PropertyReference1.cb_getDelegate_Ljava_lang_Object_;
		}

		// Token: 0x06001656 RID: 5718 RVA: 0x000483FC File Offset: 0x000465FC
		private static IntPtr n_GetDelegate_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_receiver)
		{
			PropertyReference1 @object = Java.Lang.Object.GetObject<PropertyReference1>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_receiver, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetDelegate(object2));
		}

		// Token: 0x06001657 RID: 5719 RVA: 0x00048424 File Offset: 0x00046624
		[Register("getDelegate", "(Ljava/lang/Object;)Ljava/lang/Object;", "GetGetDelegate_Ljava_lang_Object_Handler")]
		public unsafe virtual Java.Lang.Object GetDelegate(Java.Lang.Object receiver)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((receiver == null) ? IntPtr.Zero : receiver.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(PropertyReference1._members.InstanceMethods.InvokeVirtualObjectMethod("getDelegate.(Ljava/lang/Object;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(receiver);
			}
			return @object;
		}

		// Token: 0x06001658 RID: 5720 RVA: 0x00048498 File Offset: 0x00046698
		[NullableContext(1)]
		private static Delegate GetInvoke_Ljava_lang_Object_Handler()
		{
			if (PropertyReference1.cb_invoke_Ljava_lang_Object_ == null)
			{
				PropertyReference1.cb_invoke_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(PropertyReference1.n_Invoke_Ljava_lang_Object_));
			}
			return PropertyReference1.cb_invoke_Ljava_lang_Object_;
		}

		// Token: 0x06001659 RID: 5721 RVA: 0x000484BC File Offset: 0x000466BC
		private static IntPtr n_Invoke_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_receiver)
		{
			PropertyReference1 @object = Java.Lang.Object.GetObject<PropertyReference1>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_receiver, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Invoke(object2));
		}

		// Token: 0x0600165A RID: 5722 RVA: 0x000484E4 File Offset: 0x000466E4
		[Register("invoke", "(Ljava/lang/Object;)Ljava/lang/Object;", "GetInvoke_Ljava_lang_Object_Handler")]
		public unsafe virtual Java.Lang.Object Invoke(Java.Lang.Object receiver)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((receiver == null) ? IntPtr.Zero : receiver.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(PropertyReference1._members.InstanceMethods.InvokeVirtualObjectMethod("invoke.(Ljava/lang/Object;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(receiver);
			}
			return @object;
		}

		// Token: 0x0600165B RID: 5723 RVA: 0x00048558 File Offset: 0x00046758
		[NullableContext(1)]
		private static Delegate GetGet_Ljava_lang_Object_Handler()
		{
			if (PropertyReference1.cb_get_Ljava_lang_Object_ == null)
			{
				PropertyReference1.cb_get_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(PropertyReference1.n_Get_Ljava_lang_Object_));
			}
			return PropertyReference1.cb_get_Ljava_lang_Object_;
		}

		// Token: 0x0600165C RID: 5724 RVA: 0x0004857C File Offset: 0x0004677C
		private static IntPtr n_Get_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			PropertyReference1 @object = Java.Lang.Object.GetObject<PropertyReference1>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Get(object2));
		}

		// Token: 0x0600165D RID: 5725 RVA: 0x000485A4 File Offset: 0x000467A4
		[Register("get", "(Ljava/lang/Object;)Ljava/lang/Object;", "GetGet_Ljava_lang_Object_Handler")]
		public unsafe virtual Java.Lang.Object Get(Java.Lang.Object p0)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(PropertyReference1._members.InstanceMethods.InvokeVirtualObjectMethod("get.(Ljava/lang/Object;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return @object;
		}

		// Token: 0x04000718 RID: 1816
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/PropertyReference1", typeof(PropertyReference1));

		// Token: 0x04000719 RID: 1817
		private static Delegate cb_getGetter;

		// Token: 0x0400071A RID: 1818
		private static Delegate cb_computeReflected;

		// Token: 0x0400071B RID: 1819
		private static Delegate cb_getDelegate_Ljava_lang_Object_;

		// Token: 0x0400071C RID: 1820
		private static Delegate cb_invoke_Ljava_lang_Object_;

		// Token: 0x0400071D RID: 1821
		private static Delegate cb_get_Ljava_lang_Object_;
	}
}
