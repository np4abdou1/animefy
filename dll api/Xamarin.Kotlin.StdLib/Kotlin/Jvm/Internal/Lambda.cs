using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;

namespace Kotlin.Jvm.Internal
{
	// Token: 0x020001AE RID: 430
	[Register("kotlin/jvm/internal/Lambda", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"R"
	})]
	public abstract class Lambda : Java.Lang.Object, ISerializable, IJavaObject, IDisposable, IJavaPeerable, IFunctionBase, IFunction
	{
		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x06001534 RID: 5428 RVA: 0x00044884 File Offset: 0x00042A84
		internal static IntPtr class_ref
		{
			get
			{
				return Lambda._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x06001535 RID: 5429 RVA: 0x000448A8 File Offset: 0x00042AA8
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return Lambda._members;
			}
		}

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x06001536 RID: 5430 RVA: 0x000448B0 File Offset: 0x00042AB0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Lambda._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x06001537 RID: 5431 RVA: 0x000448D4 File Offset: 0x00042AD4
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return Lambda._members.ManagedPeerType;
			}
		}

		// Token: 0x06001538 RID: 5432 RVA: 0x000448E0 File Offset: 0x00042AE0
		protected Lambda(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001539 RID: 5433 RVA: 0x000448EC File Offset: 0x00042AEC
		[Register(".ctor", "(I)V", "")]
		public unsafe Lambda(int arity) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(arity);
			base.SetHandle(Lambda._members.InstanceMethods.StartCreateInstance("(I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			Lambda._members.InstanceMethods.FinishCreateInstance("(I)V", this, ptr);
		}

		// Token: 0x0600153A RID: 5434 RVA: 0x00044970 File Offset: 0x00042B70
		[NullableContext(1)]
		private static Delegate GetGetArityHandler()
		{
			if (Lambda.cb_getArity == null)
			{
				Lambda.cb_getArity = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(Lambda.n_GetArity));
			}
			return Lambda.cb_getArity;
		}

		// Token: 0x0600153B RID: 5435 RVA: 0x00044994 File Offset: 0x00042B94
		private static int n_GetArity(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Lambda>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Arity;
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x0600153C RID: 5436 RVA: 0x000449A3 File Offset: 0x00042BA3
		public virtual int Arity
		{
			[Register("getArity", "()I", "GetGetArityHandler")]
			get
			{
				return Lambda._members.InstanceMethods.InvokeVirtualInt32Method("getArity.()I", this, null);
			}
		}

		// Token: 0x040006DF RID: 1759
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/Lambda", typeof(Lambda));

		// Token: 0x040006E0 RID: 1760
		[Nullable(2)]
		private static Delegate cb_getArity;
	}
}
