using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Reflect;

namespace Kotlin.Jvm.Internal
{
	// Token: 0x020001C0 RID: 448
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/jvm/internal/PropertyReference", DoNotGenerateAcw = true)]
	public abstract class PropertyReference : CallableReference, IKProperty, IKCallable, IKAnnotatedElement, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x06001613 RID: 5651 RVA: 0x000476D0 File Offset: 0x000458D0
		internal new static IntPtr class_ref
		{
			get
			{
				return PropertyReference._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x06001614 RID: 5652 RVA: 0x000476F4 File Offset: 0x000458F4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return PropertyReference._members;
			}
		}

		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x06001615 RID: 5653 RVA: 0x000476FC File Offset: 0x000458FC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return PropertyReference._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x06001616 RID: 5654 RVA: 0x00047720 File Offset: 0x00045920
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return PropertyReference._members.ManagedPeerType;
			}
		}

		// Token: 0x06001617 RID: 5655 RVA: 0x0004772C File Offset: 0x0004592C
		protected PropertyReference(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001618 RID: 5656 RVA: 0x00047738 File Offset: 0x00045938
		[Register(".ctor", "()V", "")]
		public PropertyReference() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(PropertyReference._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			PropertyReference._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06001619 RID: 5657 RVA: 0x000477A8 File Offset: 0x000459A8
		[NullableContext(2)]
		[Register(".ctor", "(Ljava/lang/Object;)V", "")]
		public unsafe PropertyReference(Java.Lang.Object receiver) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((receiver == null) ? IntPtr.Zero : receiver.Handle);
				base.SetHandle(PropertyReference._members.InstanceMethods.StartCreateInstance("(Ljava/lang/Object;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				PropertyReference._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(receiver);
			}
		}

		// Token: 0x0600161A RID: 5658 RVA: 0x00047858 File Offset: 0x00045A58
		[NullableContext(2)]
		[Register(".ctor", "(Ljava/lang/Object;Ljava/lang/Class;Ljava/lang/String;Ljava/lang/String;I)V", "")]
		public unsafe PropertyReference(Java.Lang.Object receiver, Class owner, string name, string signature, int flags) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(PropertyReference._members.InstanceMethods.StartCreateInstance("(Ljava/lang/Object;Ljava/lang/Class;Ljava/lang/String;Ljava/lang/String;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				PropertyReference._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/Object;Ljava/lang/Class;Ljava/lang/String;Ljava/lang/String;I)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(receiver);
				GC.KeepAlive(owner);
			}
		}

		// Token: 0x0600161B RID: 5659 RVA: 0x0004798C File Offset: 0x00045B8C
		private static Delegate GetGetGetterHandler()
		{
			if (PropertyReference.cb_getGetter == null)
			{
				PropertyReference.cb_getGetter = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(PropertyReference.n_GetGetter));
			}
			return PropertyReference.cb_getGetter;
		}

		// Token: 0x0600161C RID: 5660 RVA: 0x000479B0 File Offset: 0x00045BB0
		private static IntPtr n_GetGetter(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<PropertyReference>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Getter);
		}

		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x0600161D RID: 5661
		[Nullable(2)]
		public abstract IKPropertyGetter Getter { [NullableContext(2)] [Register("getGetter", "()Lkotlin/reflect/KProperty$Getter;", "GetGetGetterHandler")] get; }

		// Token: 0x0600161E RID: 5662 RVA: 0x000479C4 File Offset: 0x00045BC4
		private static Delegate GetIsConstHandler()
		{
			if (PropertyReference.cb_isConst == null)
			{
				PropertyReference.cb_isConst = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(PropertyReference.n_IsConst));
			}
			return PropertyReference.cb_isConst;
		}

		// Token: 0x0600161F RID: 5663 RVA: 0x000479E8 File Offset: 0x00045BE8
		private static bool n_IsConst(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<PropertyReference>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsConst;
		}

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x06001620 RID: 5664 RVA: 0x000479F7 File Offset: 0x00045BF7
		public virtual bool IsConst
		{
			[Register("isConst", "()Z", "GetIsConstHandler")]
			get
			{
				return PropertyReference._members.InstanceMethods.InvokeVirtualBooleanMethod("isConst.()Z", this, null);
			}
		}

		// Token: 0x06001621 RID: 5665 RVA: 0x00047A10 File Offset: 0x00045C10
		private static Delegate GetIsLateinitHandler()
		{
			if (PropertyReference.cb_isLateinit == null)
			{
				PropertyReference.cb_isLateinit = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(PropertyReference.n_IsLateinit));
			}
			return PropertyReference.cb_isLateinit;
		}

		// Token: 0x06001622 RID: 5666 RVA: 0x00047A34 File Offset: 0x00045C34
		private static bool n_IsLateinit(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<PropertyReference>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsLateinit;
		}

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x06001623 RID: 5667 RVA: 0x00047A43 File Offset: 0x00045C43
		public virtual bool IsLateinit
		{
			[Register("isLateinit", "()Z", "GetIsLateinitHandler")]
			get
			{
				return PropertyReference._members.InstanceMethods.InvokeVirtualBooleanMethod("isLateinit.()Z", this, null);
			}
		}

		// Token: 0x0400070C RID: 1804
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/PropertyReference", typeof(PropertyReference));

		// Token: 0x0400070D RID: 1805
		[Nullable(2)]
		private static Delegate cb_getGetter;

		// Token: 0x0400070E RID: 1806
		[Nullable(2)]
		private static Delegate cb_isConst;

		// Token: 0x0400070F RID: 1807
		[Nullable(2)]
		private static Delegate cb_isLateinit;
	}
}
