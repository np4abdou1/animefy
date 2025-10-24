using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Jvm.Internal
{
	// Token: 0x020001B0 RID: 432
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/jvm/internal/LocalVariableReference", DoNotGenerateAcw = true)]
	public class LocalVariableReference : PropertyReference0
	{
		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x06001542 RID: 5442 RVA: 0x00044A10 File Offset: 0x00042C10
		internal new static IntPtr class_ref
		{
			get
			{
				return LocalVariableReference._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x06001543 RID: 5443 RVA: 0x00044A34 File Offset: 0x00042C34
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return LocalVariableReference._members;
			}
		}

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x06001544 RID: 5444 RVA: 0x00044A3C File Offset: 0x00042C3C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return LocalVariableReference._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x06001545 RID: 5445 RVA: 0x00044A60 File Offset: 0x00042C60
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return LocalVariableReference._members.ManagedPeerType;
			}
		}

		// Token: 0x06001546 RID: 5446 RVA: 0x00044A6C File Offset: 0x00042C6C
		protected LocalVariableReference(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001547 RID: 5447 RVA: 0x00044A78 File Offset: 0x00042C78
		[Register(".ctor", "()V", "")]
		public LocalVariableReference() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(LocalVariableReference._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			LocalVariableReference._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06001548 RID: 5448 RVA: 0x00044AE6 File Offset: 0x00042CE6
		private static Delegate GetGetHandler()
		{
			if (LocalVariableReference.cb_get == null)
			{
				LocalVariableReference.cb_get = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(LocalVariableReference.n_Get));
			}
			return LocalVariableReference.cb_get;
		}

		// Token: 0x06001549 RID: 5449 RVA: 0x00044B0A File Offset: 0x00042D0A
		private static IntPtr n_Get(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<LocalVariableReference>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Get());
		}

		// Token: 0x0600154A RID: 5450 RVA: 0x00044B20 File Offset: 0x00042D20
		[NullableContext(2)]
		[Register("get", "()Ljava/lang/Object;", "GetGetHandler")]
		public override Java.Lang.Object Get()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(LocalVariableReference._members.InstanceMethods.InvokeVirtualObjectMethod("get.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040006E2 RID: 1762
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/LocalVariableReference", typeof(LocalVariableReference));

		// Token: 0x040006E3 RID: 1763
		[Nullable(2)]
		private static Delegate cb_get;
	}
}
