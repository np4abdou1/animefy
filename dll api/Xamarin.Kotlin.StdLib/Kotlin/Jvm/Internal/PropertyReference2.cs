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
	// Token: 0x020001C6 RID: 454
	[NullableContext(2)]
	[Nullable(0)]
	[Register("kotlin/jvm/internal/PropertyReference2", DoNotGenerateAcw = true)]
	public abstract class PropertyReference2 : PropertyReference, IKProperty2, IFunction2, IFunction, IJavaObject, IDisposable, IJavaPeerable, IKProperty, IKCallable, IKAnnotatedElement
	{
		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x06001663 RID: 5731 RVA: 0x0004866C File Offset: 0x0004686C
		internal new static IntPtr class_ref
		{
			get
			{
				return PropertyReference2._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x06001664 RID: 5732 RVA: 0x00048690 File Offset: 0x00046890
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return PropertyReference2._members;
			}
		}

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x06001665 RID: 5733 RVA: 0x00048698 File Offset: 0x00046898
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return PropertyReference2._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x06001666 RID: 5734 RVA: 0x000486BC File Offset: 0x000468BC
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return PropertyReference2._members.ManagedPeerType;
			}
		}

		// Token: 0x06001667 RID: 5735 RVA: 0x000486C8 File Offset: 0x000468C8
		protected PropertyReference2(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001668 RID: 5736 RVA: 0x000486D4 File Offset: 0x000468D4
		[Register(".ctor", "()V", "")]
		public PropertyReference2() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(PropertyReference2._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			PropertyReference2._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06001669 RID: 5737 RVA: 0x00048744 File Offset: 0x00046944
		[Register(".ctor", "(Ljava/lang/Class;Ljava/lang/String;Ljava/lang/String;I)V", "")]
		public unsafe PropertyReference2(Class owner, string name, string signature, int flags) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(PropertyReference2._members.InstanceMethods.StartCreateInstance("(Ljava/lang/Class;Ljava/lang/String;Ljava/lang/String;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				PropertyReference2._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/Class;Ljava/lang/String;Ljava/lang/String;I)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(owner);
			}
		}

		// Token: 0x0600166A RID: 5738 RVA: 0x0004884C File Offset: 0x00046A4C
		[NullableContext(1)]
		private static Delegate GetGetGetterHandler()
		{
			if (PropertyReference2.cb_getGetter == null)
			{
				PropertyReference2.cb_getGetter = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(PropertyReference2.n_GetGetter));
			}
			return PropertyReference2.cb_getGetter;
		}

		// Token: 0x0600166B RID: 5739 RVA: 0x00048870 File Offset: 0x00046A70
		private static IntPtr n_GetGetter(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<PropertyReference2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Getter);
		}

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x0600166C RID: 5740 RVA: 0x00048884 File Offset: 0x00046A84
		public override IKPropertyGetter Getter
		{
			[Register("getGetter", "()Lkotlin/reflect/KProperty2$Getter;", "GetGetGetterHandler")]
			get
			{
				return Java.Lang.Object.GetObject<IKPropertyGetter>(PropertyReference2._members.InstanceMethods.InvokeVirtualObjectMethod("getGetter.()Lkotlin/reflect/KProperty2$Getter;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600166D RID: 5741 RVA: 0x000488B6 File Offset: 0x00046AB6
		[NullableContext(1)]
		private static Delegate GetComputeReflectedHandler()
		{
			if (PropertyReference2.cb_computeReflected == null)
			{
				PropertyReference2.cb_computeReflected = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(PropertyReference2.n_ComputeReflected));
			}
			return PropertyReference2.cb_computeReflected;
		}

		// Token: 0x0600166E RID: 5742 RVA: 0x000488DA File Offset: 0x00046ADA
		private static IntPtr n_ComputeReflected(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<PropertyReference2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ComputeReflected());
		}

		// Token: 0x0600166F RID: 5743 RVA: 0x000488F0 File Offset: 0x00046AF0
		[Register("computeReflected", "()Lkotlin/reflect/KCallable;", "GetComputeReflectedHandler")]
		protected override IKCallable ComputeReflected()
		{
			return Java.Lang.Object.GetObject<IKCallable>(PropertyReference2._members.InstanceMethods.InvokeVirtualObjectMethod("computeReflected.()Lkotlin/reflect/KCallable;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001670 RID: 5744 RVA: 0x00048922 File Offset: 0x00046B22
		[NullableContext(1)]
		private static Delegate GetGetDelegate_Ljava_lang_Object_Ljava_lang_Object_Handler()
		{
			if (PropertyReference2.cb_getDelegate_Ljava_lang_Object_Ljava_lang_Object_ == null)
			{
				PropertyReference2.cb_getDelegate_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(PropertyReference2.n_GetDelegate_Ljava_lang_Object_Ljava_lang_Object_));
			}
			return PropertyReference2.cb_getDelegate_Ljava_lang_Object_Ljava_lang_Object_;
		}

		// Token: 0x06001671 RID: 5745 RVA: 0x00048948 File Offset: 0x00046B48
		private static IntPtr n_GetDelegate_Ljava_lang_Object_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_receiver1, IntPtr native_receiver2)
		{
			PropertyReference2 @object = Java.Lang.Object.GetObject<PropertyReference2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_receiver1, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_receiver2, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetDelegate(object2, object3));
		}

		// Token: 0x06001672 RID: 5746 RVA: 0x0004897C File Offset: 0x00046B7C
		[Register("getDelegate", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", "GetGetDelegate_Ljava_lang_Object_Ljava_lang_Object_Handler")]
		public unsafe virtual Java.Lang.Object GetDelegate(Java.Lang.Object receiver1, Java.Lang.Object receiver2)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((receiver1 == null) ? IntPtr.Zero : receiver1.Handle);
				ptr[1] = new JniArgumentValue((receiver2 == null) ? IntPtr.Zero : receiver2.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(PropertyReference2._members.InstanceMethods.InvokeVirtualObjectMethod("getDelegate.(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(receiver1);
				GC.KeepAlive(receiver2);
			}
			return @object;
		}

		// Token: 0x06001673 RID: 5747 RVA: 0x00048A18 File Offset: 0x00046C18
		[NullableContext(1)]
		private static Delegate GetInvoke_Ljava_lang_Object_Ljava_lang_Object_Handler()
		{
			if (PropertyReference2.cb_invoke_Ljava_lang_Object_Ljava_lang_Object_ == null)
			{
				PropertyReference2.cb_invoke_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(PropertyReference2.n_Invoke_Ljava_lang_Object_Ljava_lang_Object_));
			}
			return PropertyReference2.cb_invoke_Ljava_lang_Object_Ljava_lang_Object_;
		}

		// Token: 0x06001674 RID: 5748 RVA: 0x00048A3C File Offset: 0x00046C3C
		private static IntPtr n_Invoke_Ljava_lang_Object_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_receiver1, IntPtr native_receiver2)
		{
			PropertyReference2 @object = Java.Lang.Object.GetObject<PropertyReference2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_receiver1, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_receiver2, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Invoke(object2, object3));
		}

		// Token: 0x06001675 RID: 5749 RVA: 0x00048A70 File Offset: 0x00046C70
		[Register("invoke", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", "GetInvoke_Ljava_lang_Object_Ljava_lang_Object_Handler")]
		public unsafe virtual Java.Lang.Object Invoke(Java.Lang.Object receiver1, Java.Lang.Object receiver2)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((receiver1 == null) ? IntPtr.Zero : receiver1.Handle);
				ptr[1] = new JniArgumentValue((receiver2 == null) ? IntPtr.Zero : receiver2.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(PropertyReference2._members.InstanceMethods.InvokeVirtualObjectMethod("invoke.(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(receiver1);
				GC.KeepAlive(receiver2);
			}
			return @object;
		}

		// Token: 0x06001676 RID: 5750 RVA: 0x00048B0C File Offset: 0x00046D0C
		[NullableContext(1)]
		private static Delegate GetGet_Ljava_lang_Object_Ljava_lang_Object_Handler()
		{
			if (PropertyReference2.cb_get_Ljava_lang_Object_Ljava_lang_Object_ == null)
			{
				PropertyReference2.cb_get_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(PropertyReference2.n_Get_Ljava_lang_Object_Ljava_lang_Object_));
			}
			return PropertyReference2.cb_get_Ljava_lang_Object_Ljava_lang_Object_;
		}

		// Token: 0x06001677 RID: 5751 RVA: 0x00048B30 File Offset: 0x00046D30
		private static IntPtr n_Get_Ljava_lang_Object_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			PropertyReference2 @object = Java.Lang.Object.GetObject<PropertyReference2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p1, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Get(object2, object3));
		}

		// Token: 0x06001678 RID: 5752 RVA: 0x00048B64 File Offset: 0x00046D64
		[Register("get", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", "GetGet_Ljava_lang_Object_Ljava_lang_Object_Handler")]
		public unsafe virtual Java.Lang.Object Get(Java.Lang.Object p0, Java.Lang.Object p1)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(PropertyReference2._members.InstanceMethods.InvokeVirtualObjectMethod("get.(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
			}
			return @object;
		}

		// Token: 0x0400071F RID: 1823
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/PropertyReference2", typeof(PropertyReference2));

		// Token: 0x04000720 RID: 1824
		private static Delegate cb_getGetter;

		// Token: 0x04000721 RID: 1825
		private static Delegate cb_computeReflected;

		// Token: 0x04000722 RID: 1826
		private static Delegate cb_getDelegate_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x04000723 RID: 1827
		private static Delegate cb_invoke_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x04000724 RID: 1828
		private static Delegate cb_get_Ljava_lang_Object_Ljava_lang_Object_;
	}
}
