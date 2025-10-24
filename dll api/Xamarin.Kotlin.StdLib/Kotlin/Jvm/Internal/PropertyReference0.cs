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
	// Token: 0x020001C2 RID: 450
	[NullableContext(2)]
	[Nullable(0)]
	[Register("kotlin/jvm/internal/PropertyReference0", DoNotGenerateAcw = true)]
	public abstract class PropertyReference0 : PropertyReference, IKProperty0, IFunction0, IFunction, IJavaObject, IDisposable, IJavaPeerable, IKProperty, IKCallable, IKAnnotatedElement
	{
		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x0600162B RID: 5675 RVA: 0x00047B18 File Offset: 0x00045D18
		internal new static IntPtr class_ref
		{
			get
			{
				return PropertyReference0._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x0600162C RID: 5676 RVA: 0x00047B3C File Offset: 0x00045D3C
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return PropertyReference0._members;
			}
		}

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x0600162D RID: 5677 RVA: 0x00047B44 File Offset: 0x00045D44
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return PropertyReference0._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x0600162E RID: 5678 RVA: 0x00047B68 File Offset: 0x00045D68
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return PropertyReference0._members.ManagedPeerType;
			}
		}

		// Token: 0x0600162F RID: 5679 RVA: 0x00047B74 File Offset: 0x00045D74
		protected PropertyReference0(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001630 RID: 5680 RVA: 0x00047B80 File Offset: 0x00045D80
		[Register(".ctor", "()V", "")]
		public PropertyReference0() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(PropertyReference0._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			PropertyReference0._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06001631 RID: 5681 RVA: 0x00047BF0 File Offset: 0x00045DF0
		[Register(".ctor", "(Ljava/lang/Object;)V", "")]
		public unsafe PropertyReference0(Java.Lang.Object receiver) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((receiver == null) ? IntPtr.Zero : receiver.Handle);
				base.SetHandle(PropertyReference0._members.InstanceMethods.StartCreateInstance("(Ljava/lang/Object;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				PropertyReference0._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(receiver);
			}
		}

		// Token: 0x06001632 RID: 5682 RVA: 0x00047CA0 File Offset: 0x00045EA0
		[Register(".ctor", "(Ljava/lang/Object;Ljava/lang/Class;Ljava/lang/String;Ljava/lang/String;I)V", "")]
		public unsafe PropertyReference0(Java.Lang.Object receiver, Class owner, string name, string signature, int flags) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(PropertyReference0._members.InstanceMethods.StartCreateInstance("(Ljava/lang/Object;Ljava/lang/Class;Ljava/lang/String;Ljava/lang/String;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				PropertyReference0._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/Object;Ljava/lang/Class;Ljava/lang/String;Ljava/lang/String;I)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(receiver);
				GC.KeepAlive(owner);
			}
		}

		// Token: 0x06001633 RID: 5683 RVA: 0x00047DD4 File Offset: 0x00045FD4
		[NullableContext(1)]
		private static Delegate GetGetDelegateHandler()
		{
			if (PropertyReference0.cb_getDelegate == null)
			{
				PropertyReference0.cb_getDelegate = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(PropertyReference0.n_GetDelegate));
			}
			return PropertyReference0.cb_getDelegate;
		}

		// Token: 0x06001634 RID: 5684 RVA: 0x00047DF8 File Offset: 0x00045FF8
		private static IntPtr n_GetDelegate(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<PropertyReference0>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Delegate);
		}

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x06001635 RID: 5685 RVA: 0x00047E0C File Offset: 0x0004600C
		public virtual Java.Lang.Object Delegate
		{
			[Register("getDelegate", "()Ljava/lang/Object;", "GetGetDelegateHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Java.Lang.Object>(PropertyReference0._members.InstanceMethods.InvokeVirtualObjectMethod("getDelegate.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06001636 RID: 5686 RVA: 0x00047E3E File Offset: 0x0004603E
		[NullableContext(1)]
		private static Delegate GetGetGetterHandler()
		{
			if (PropertyReference0.cb_getGetter == null)
			{
				PropertyReference0.cb_getGetter = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(PropertyReference0.n_GetGetter));
			}
			return PropertyReference0.cb_getGetter;
		}

		// Token: 0x06001637 RID: 5687 RVA: 0x00047E62 File Offset: 0x00046062
		private static IntPtr n_GetGetter(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<PropertyReference0>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Getter);
		}

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x06001638 RID: 5688 RVA: 0x00047E78 File Offset: 0x00046078
		public override IKPropertyGetter Getter
		{
			[Register("getGetter", "()Lkotlin/reflect/KProperty0$Getter;", "GetGetGetterHandler")]
			get
			{
				return Java.Lang.Object.GetObject<IKPropertyGetter>(PropertyReference0._members.InstanceMethods.InvokeVirtualObjectMethod("getGetter.()Lkotlin/reflect/KProperty0$Getter;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06001639 RID: 5689 RVA: 0x00047EAA File Offset: 0x000460AA
		[NullableContext(1)]
		private static Delegate GetComputeReflectedHandler()
		{
			if (PropertyReference0.cb_computeReflected == null)
			{
				PropertyReference0.cb_computeReflected = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(PropertyReference0.n_ComputeReflected));
			}
			return PropertyReference0.cb_computeReflected;
		}

		// Token: 0x0600163A RID: 5690 RVA: 0x00047ECE File Offset: 0x000460CE
		private static IntPtr n_ComputeReflected(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<PropertyReference0>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ComputeReflected());
		}

		// Token: 0x0600163B RID: 5691 RVA: 0x00047EE4 File Offset: 0x000460E4
		[Register("computeReflected", "()Lkotlin/reflect/KCallable;", "GetComputeReflectedHandler")]
		protected override IKCallable ComputeReflected()
		{
			return Java.Lang.Object.GetObject<IKCallable>(PropertyReference0._members.InstanceMethods.InvokeVirtualObjectMethod("computeReflected.()Lkotlin/reflect/KCallable;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600163C RID: 5692 RVA: 0x00047F16 File Offset: 0x00046116
		[NullableContext(1)]
		private static Delegate GetInvokeHandler()
		{
			if (PropertyReference0.cb_invoke == null)
			{
				PropertyReference0.cb_invoke = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(PropertyReference0.n_Invoke));
			}
			return PropertyReference0.cb_invoke;
		}

		// Token: 0x0600163D RID: 5693 RVA: 0x00047F3A File Offset: 0x0004613A
		private static IntPtr n_Invoke(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<PropertyReference0>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Invoke());
		}

		// Token: 0x0600163E RID: 5694 RVA: 0x00047F50 File Offset: 0x00046150
		[Register("invoke", "()Ljava/lang/Object;", "GetInvokeHandler")]
		public virtual Java.Lang.Object Invoke()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(PropertyReference0._members.InstanceMethods.InvokeVirtualObjectMethod("invoke.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600163F RID: 5695 RVA: 0x00047F82 File Offset: 0x00046182
		[NullableContext(1)]
		private static Delegate GetGetHandler()
		{
			if (PropertyReference0.cb_get == null)
			{
				PropertyReference0.cb_get = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(PropertyReference0.n_Get));
			}
			return PropertyReference0.cb_get;
		}

		// Token: 0x06001640 RID: 5696 RVA: 0x00047FA6 File Offset: 0x000461A6
		private static IntPtr n_Get(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<PropertyReference0>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Get());
		}

		// Token: 0x06001641 RID: 5697 RVA: 0x00047FBC File Offset: 0x000461BC
		[Register("get", "()Ljava/lang/Object;", "GetGetHandler")]
		public virtual Java.Lang.Object Get()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(PropertyReference0._members.InstanceMethods.InvokeVirtualObjectMethod("get.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000711 RID: 1809
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/PropertyReference0", typeof(PropertyReference0));

		// Token: 0x04000712 RID: 1810
		private static Delegate cb_getDelegate;

		// Token: 0x04000713 RID: 1811
		private static Delegate cb_getGetter;

		// Token: 0x04000714 RID: 1812
		private static Delegate cb_computeReflected;

		// Token: 0x04000715 RID: 1813
		private static Delegate cb_invoke;

		// Token: 0x04000716 RID: 1814
		private static Delegate cb_get;
	}
}
