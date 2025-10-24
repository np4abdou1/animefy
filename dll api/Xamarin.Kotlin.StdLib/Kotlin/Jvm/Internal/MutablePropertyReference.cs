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
	// Token: 0x020001B5 RID: 437
	[Register("kotlin/jvm/internal/MutablePropertyReference", DoNotGenerateAcw = true)]
	public abstract class MutablePropertyReference : PropertyReference, IKMutableProperty, IKProperty, IKCallable, IKAnnotatedElement, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x0600157E RID: 5502 RVA: 0x000458BC File Offset: 0x00043ABC
		internal new static IntPtr class_ref
		{
			get
			{
				return MutablePropertyReference._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x0600157F RID: 5503 RVA: 0x000458E0 File Offset: 0x00043AE0
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return MutablePropertyReference._members;
			}
		}

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x06001580 RID: 5504 RVA: 0x000458E8 File Offset: 0x00043AE8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MutablePropertyReference._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x06001581 RID: 5505 RVA: 0x0004590C File Offset: 0x00043B0C
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return MutablePropertyReference._members.ManagedPeerType;
			}
		}

		// Token: 0x06001582 RID: 5506 RVA: 0x00045918 File Offset: 0x00043B18
		protected MutablePropertyReference(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001583 RID: 5507 RVA: 0x00045924 File Offset: 0x00043B24
		[Register(".ctor", "()V", "")]
		public MutablePropertyReference() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(MutablePropertyReference._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			MutablePropertyReference._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06001584 RID: 5508 RVA: 0x00045994 File Offset: 0x00043B94
		[NullableContext(2)]
		[Register(".ctor", "(Ljava/lang/Object;)V", "")]
		public unsafe MutablePropertyReference(Java.Lang.Object receiver) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((receiver == null) ? IntPtr.Zero : receiver.Handle);
				base.SetHandle(MutablePropertyReference._members.InstanceMethods.StartCreateInstance("(Ljava/lang/Object;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				MutablePropertyReference._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(receiver);
			}
		}

		// Token: 0x06001585 RID: 5509 RVA: 0x00045A44 File Offset: 0x00043C44
		[NullableContext(2)]
		[Register(".ctor", "(Ljava/lang/Object;Ljava/lang/Class;Ljava/lang/String;Ljava/lang/String;I)V", "")]
		public unsafe MutablePropertyReference(Java.Lang.Object receiver, Class owner, string name, string signature, int flags) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(MutablePropertyReference._members.InstanceMethods.StartCreateInstance("(Ljava/lang/Object;Ljava/lang/Class;Ljava/lang/String;Ljava/lang/String;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				MutablePropertyReference._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/Object;Ljava/lang/Class;Ljava/lang/String;Ljava/lang/String;I)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(receiver);
				GC.KeepAlive(owner);
			}
		}

		// Token: 0x06001586 RID: 5510 RVA: 0x00045B78 File Offset: 0x00043D78
		[NullableContext(1)]
		private static Delegate GetGetSetterHandler()
		{
			if (MutablePropertyReference.cb_getSetter == null)
			{
				MutablePropertyReference.cb_getSetter = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MutablePropertyReference.n_GetSetter));
			}
			return MutablePropertyReference.cb_getSetter;
		}

		// Token: 0x06001587 RID: 5511 RVA: 0x00045B9C File Offset: 0x00043D9C
		private static IntPtr n_GetSetter(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MutablePropertyReference>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Setter);
		}

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x06001588 RID: 5512
		[Nullable(2)]
		public abstract IKMutablePropertySetter Setter { [NullableContext(2)] [Register("getSetter", "()Lkotlin/reflect/KMutableProperty$Setter;", "GetGetSetterHandler")] get; }

		// Token: 0x040006EA RID: 1770
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/MutablePropertyReference", typeof(MutablePropertyReference));

		// Token: 0x040006EB RID: 1771
		[Nullable(2)]
		private static Delegate cb_getSetter;
	}
}
