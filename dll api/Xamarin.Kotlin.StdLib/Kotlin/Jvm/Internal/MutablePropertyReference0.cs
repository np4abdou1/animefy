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
	// Token: 0x020001B7 RID: 439
	[NullableContext(2)]
	[Nullable(0)]
	[Register("kotlin/jvm/internal/MutablePropertyReference0", DoNotGenerateAcw = true)]
	public abstract class MutablePropertyReference0 : MutablePropertyReference, IKMutableProperty0, IKMutableProperty, IKProperty, IKCallable, IKAnnotatedElement, IJavaObject, IDisposable, IJavaPeerable, IKProperty0, IFunction0, IFunction
	{
		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x06001591 RID: 5521 RVA: 0x00045CA0 File Offset: 0x00043EA0
		internal new static IntPtr class_ref
		{
			get
			{
				return MutablePropertyReference0._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x06001592 RID: 5522 RVA: 0x00045CC4 File Offset: 0x00043EC4
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return MutablePropertyReference0._members;
			}
		}

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x06001593 RID: 5523 RVA: 0x00045CCC File Offset: 0x00043ECC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MutablePropertyReference0._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x06001594 RID: 5524 RVA: 0x00045CF0 File Offset: 0x00043EF0
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return MutablePropertyReference0._members.ManagedPeerType;
			}
		}

		// Token: 0x06001595 RID: 5525 RVA: 0x00045CFC File Offset: 0x00043EFC
		protected MutablePropertyReference0(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001596 RID: 5526 RVA: 0x00045D08 File Offset: 0x00043F08
		[Register(".ctor", "()V", "")]
		public MutablePropertyReference0() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(MutablePropertyReference0._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			MutablePropertyReference0._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06001597 RID: 5527 RVA: 0x00045D78 File Offset: 0x00043F78
		[Register(".ctor", "(Ljava/lang/Object;)V", "")]
		public unsafe MutablePropertyReference0(Java.Lang.Object receiver) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((receiver == null) ? IntPtr.Zero : receiver.Handle);
				base.SetHandle(MutablePropertyReference0._members.InstanceMethods.StartCreateInstance("(Ljava/lang/Object;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				MutablePropertyReference0._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(receiver);
			}
		}

		// Token: 0x06001598 RID: 5528 RVA: 0x00045E28 File Offset: 0x00044028
		[Register(".ctor", "(Ljava/lang/Object;Ljava/lang/Class;Ljava/lang/String;Ljava/lang/String;I)V", "")]
		public unsafe MutablePropertyReference0(Java.Lang.Object receiver, Class owner, string name, string signature, int flags) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(MutablePropertyReference0._members.InstanceMethods.StartCreateInstance("(Ljava/lang/Object;Ljava/lang/Class;Ljava/lang/String;Ljava/lang/String;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				MutablePropertyReference0._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/Object;Ljava/lang/Class;Ljava/lang/String;Ljava/lang/String;I)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(receiver);
				GC.KeepAlive(owner);
			}
		}

		// Token: 0x06001599 RID: 5529 RVA: 0x00045F5C File Offset: 0x0004415C
		[NullableContext(1)]
		private static Delegate GetGetDelegateHandler()
		{
			if (MutablePropertyReference0.cb_getDelegate == null)
			{
				MutablePropertyReference0.cb_getDelegate = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MutablePropertyReference0.n_GetDelegate));
			}
			return MutablePropertyReference0.cb_getDelegate;
		}

		// Token: 0x0600159A RID: 5530 RVA: 0x00045F80 File Offset: 0x00044180
		private static IntPtr n_GetDelegate(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MutablePropertyReference0>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Delegate);
		}

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x0600159B RID: 5531 RVA: 0x00045F94 File Offset: 0x00044194
		public virtual Java.Lang.Object Delegate
		{
			[Register("getDelegate", "()Ljava/lang/Object;", "GetGetDelegateHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Java.Lang.Object>(MutablePropertyReference0._members.InstanceMethods.InvokeVirtualObjectMethod("getDelegate.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600159C RID: 5532 RVA: 0x00045FC6 File Offset: 0x000441C6
		[NullableContext(1)]
		private static Delegate GetGetGetterHandler()
		{
			if (MutablePropertyReference0.cb_getGetter == null)
			{
				MutablePropertyReference0.cb_getGetter = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MutablePropertyReference0.n_GetGetter));
			}
			return MutablePropertyReference0.cb_getGetter;
		}

		// Token: 0x0600159D RID: 5533 RVA: 0x00045FEA File Offset: 0x000441EA
		private static IntPtr n_GetGetter(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MutablePropertyReference0>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Getter);
		}

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x0600159E RID: 5534 RVA: 0x00046000 File Offset: 0x00044200
		public override IKPropertyGetter Getter
		{
			[Register("getGetter", "()Lkotlin/reflect/KProperty0$Getter;", "GetGetGetterHandler")]
			get
			{
				return Java.Lang.Object.GetObject<IKPropertyGetter>(MutablePropertyReference0._members.InstanceMethods.InvokeVirtualObjectMethod("getGetter.()Lkotlin/reflect/KProperty0$Getter;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600159F RID: 5535 RVA: 0x00046032 File Offset: 0x00044232
		[NullableContext(1)]
		private static Delegate GetGetSetterHandler()
		{
			if (MutablePropertyReference0.cb_getSetter == null)
			{
				MutablePropertyReference0.cb_getSetter = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MutablePropertyReference0.n_GetSetter));
			}
			return MutablePropertyReference0.cb_getSetter;
		}

		// Token: 0x060015A0 RID: 5536 RVA: 0x00046056 File Offset: 0x00044256
		private static IntPtr n_GetSetter(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MutablePropertyReference0>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Setter);
		}

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x060015A1 RID: 5537 RVA: 0x0004606C File Offset: 0x0004426C
		public override IKMutablePropertySetter Setter
		{
			[Register("getSetter", "()Lkotlin/reflect/KMutableProperty0$Setter;", "GetGetSetterHandler")]
			get
			{
				return Java.Lang.Object.GetObject<IKMutablePropertySetter>(MutablePropertyReference0._members.InstanceMethods.InvokeVirtualObjectMethod("getSetter.()Lkotlin/reflect/KMutableProperty0$Setter;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060015A2 RID: 5538 RVA: 0x0004609E File Offset: 0x0004429E
		[NullableContext(1)]
		private static Delegate GetComputeReflectedHandler()
		{
			if (MutablePropertyReference0.cb_computeReflected == null)
			{
				MutablePropertyReference0.cb_computeReflected = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MutablePropertyReference0.n_ComputeReflected));
			}
			return MutablePropertyReference0.cb_computeReflected;
		}

		// Token: 0x060015A3 RID: 5539 RVA: 0x000460C2 File Offset: 0x000442C2
		private static IntPtr n_ComputeReflected(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MutablePropertyReference0>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ComputeReflected());
		}

		// Token: 0x060015A4 RID: 5540 RVA: 0x000460D8 File Offset: 0x000442D8
		[Register("computeReflected", "()Lkotlin/reflect/KCallable;", "GetComputeReflectedHandler")]
		protected override IKCallable ComputeReflected()
		{
			return Java.Lang.Object.GetObject<IKCallable>(MutablePropertyReference0._members.InstanceMethods.InvokeVirtualObjectMethod("computeReflected.()Lkotlin/reflect/KCallable;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060015A5 RID: 5541 RVA: 0x0004610A File Offset: 0x0004430A
		[NullableContext(1)]
		private static Delegate GetInvokeHandler()
		{
			if (MutablePropertyReference0.cb_invoke == null)
			{
				MutablePropertyReference0.cb_invoke = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MutablePropertyReference0.n_Invoke));
			}
			return MutablePropertyReference0.cb_invoke;
		}

		// Token: 0x060015A6 RID: 5542 RVA: 0x0004612E File Offset: 0x0004432E
		private static IntPtr n_Invoke(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MutablePropertyReference0>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Invoke());
		}

		// Token: 0x060015A7 RID: 5543 RVA: 0x00046144 File Offset: 0x00044344
		[Register("invoke", "()Ljava/lang/Object;", "GetInvokeHandler")]
		public virtual Java.Lang.Object Invoke()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(MutablePropertyReference0._members.InstanceMethods.InvokeVirtualObjectMethod("invoke.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060015A8 RID: 5544 RVA: 0x00046176 File Offset: 0x00044376
		[NullableContext(1)]
		private static Delegate GetGetHandler()
		{
			if (MutablePropertyReference0.cb_get == null)
			{
				MutablePropertyReference0.cb_get = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MutablePropertyReference0.n_Get));
			}
			return MutablePropertyReference0.cb_get;
		}

		// Token: 0x060015A9 RID: 5545 RVA: 0x0004619A File Offset: 0x0004439A
		private static IntPtr n_Get(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MutablePropertyReference0>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Get());
		}

		// Token: 0x060015AA RID: 5546 RVA: 0x000461B0 File Offset: 0x000443B0
		[Register("get", "()Ljava/lang/Object;", "GetGetHandler")]
		public virtual Java.Lang.Object Get()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(MutablePropertyReference0._members.InstanceMethods.InvokeVirtualObjectMethod("get.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060015AB RID: 5547 RVA: 0x000461E2 File Offset: 0x000443E2
		[NullableContext(1)]
		private static Delegate GetSet_Ljava_lang_Object_Handler()
		{
			if (MutablePropertyReference0.cb_set_Ljava_lang_Object_ == null)
			{
				MutablePropertyReference0.cb_set_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MutablePropertyReference0.n_Set_Ljava_lang_Object_));
			}
			return MutablePropertyReference0.cb_set_Ljava_lang_Object_;
		}

		// Token: 0x060015AC RID: 5548 RVA: 0x00046208 File Offset: 0x00044408
		private static void n_Set_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			MutablePropertyReference0 @object = Java.Lang.Object.GetObject<MutablePropertyReference0>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.Set(object2);
		}

		// Token: 0x060015AD RID: 5549 RVA: 0x0004622C File Offset: 0x0004442C
		[Register("set", "(Ljava/lang/Object;)V", "GetSet_Ljava_lang_Object_Handler")]
		public unsafe virtual void Set(Java.Lang.Object p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				MutablePropertyReference0._members.InstanceMethods.InvokeVirtualVoidMethod("set.(Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x040006ED RID: 1773
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/MutablePropertyReference0", typeof(MutablePropertyReference0));

		// Token: 0x040006EE RID: 1774
		private static Delegate cb_getDelegate;

		// Token: 0x040006EF RID: 1775
		private static Delegate cb_getGetter;

		// Token: 0x040006F0 RID: 1776
		private static Delegate cb_getSetter;

		// Token: 0x040006F1 RID: 1777
		private static Delegate cb_computeReflected;

		// Token: 0x040006F2 RID: 1778
		private static Delegate cb_invoke;

		// Token: 0x040006F3 RID: 1779
		private static Delegate cb_get;

		// Token: 0x040006F4 RID: 1780
		private static Delegate cb_set_Ljava_lang_Object_;
	}
}
