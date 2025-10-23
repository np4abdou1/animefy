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
	// Token: 0x0200019B RID: 411
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/jvm/internal/FunctionReference", DoNotGenerateAcw = true)]
	public class FunctionReference : CallableReference, IFunctionBase, IFunction, IJavaObject, IDisposable, IJavaPeerable, IKFunction, IKCallable, IKAnnotatedElement
	{
		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x06001443 RID: 5187 RVA: 0x00041A7C File Offset: 0x0003FC7C
		internal new static IntPtr class_ref
		{
			get
			{
				return FunctionReference._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x06001444 RID: 5188 RVA: 0x00041AA0 File Offset: 0x0003FCA0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return FunctionReference._members;
			}
		}

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x06001445 RID: 5189 RVA: 0x00041AA8 File Offset: 0x0003FCA8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return FunctionReference._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x06001446 RID: 5190 RVA: 0x00041ACC File Offset: 0x0003FCCC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return FunctionReference._members.ManagedPeerType;
			}
		}

		// Token: 0x06001447 RID: 5191 RVA: 0x00041AD8 File Offset: 0x0003FCD8
		protected FunctionReference(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001448 RID: 5192 RVA: 0x00041AE4 File Offset: 0x0003FCE4
		[Register(".ctor", "(I)V", "")]
		public unsafe FunctionReference(int arity) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(arity);
			base.SetHandle(FunctionReference._members.InstanceMethods.StartCreateInstance("(I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			FunctionReference._members.InstanceMethods.FinishCreateInstance("(I)V", this, ptr);
		}

		// Token: 0x06001449 RID: 5193 RVA: 0x00041B68 File Offset: 0x0003FD68
		[NullableContext(2)]
		[Register(".ctor", "(ILjava/lang/Object;)V", "")]
		public unsafe FunctionReference(int arity, Java.Lang.Object receiver) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(arity);
				ptr[1] = new JniArgumentValue((receiver == null) ? IntPtr.Zero : receiver.Handle);
				base.SetHandle(FunctionReference._members.InstanceMethods.StartCreateInstance("(ILjava/lang/Object;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				FunctionReference._members.InstanceMethods.FinishCreateInstance("(ILjava/lang/Object;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(receiver);
			}
		}

		// Token: 0x0600144A RID: 5194 RVA: 0x00041C28 File Offset: 0x0003FE28
		[NullableContext(2)]
		[Register(".ctor", "(ILjava/lang/Object;Ljava/lang/Class;Ljava/lang/String;Ljava/lang/String;I)V", "")]
		public unsafe FunctionReference(int arity, Java.Lang.Object receiver, Class owner, string name, string signature, int flags) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(name);
			IntPtr intPtr2 = JNIEnv.NewString(signature);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(arity);
				ptr[1] = new JniArgumentValue((receiver == null) ? IntPtr.Zero : receiver.Handle);
				ptr[2] = new JniArgumentValue((owner == null) ? IntPtr.Zero : owner.Handle);
				ptr[3] = new JniArgumentValue(intPtr);
				ptr[4] = new JniArgumentValue(intPtr2);
				ptr[5] = new JniArgumentValue(flags);
				base.SetHandle(FunctionReference._members.InstanceMethods.StartCreateInstance("(ILjava/lang/Object;Ljava/lang/Class;Ljava/lang/String;Ljava/lang/String;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				FunctionReference._members.InstanceMethods.FinishCreateInstance("(ILjava/lang/Object;Ljava/lang/Class;Ljava/lang/String;Ljava/lang/String;I)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(receiver);
				GC.KeepAlive(owner);
			}
		}

		// Token: 0x0600144B RID: 5195 RVA: 0x00041D74 File Offset: 0x0003FF74
		private static Delegate GetGetArityHandler()
		{
			if (FunctionReference.cb_getArity == null)
			{
				FunctionReference.cb_getArity = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(FunctionReference.n_GetArity));
			}
			return FunctionReference.cb_getArity;
		}

		// Token: 0x0600144C RID: 5196 RVA: 0x00041D98 File Offset: 0x0003FF98
		private static int n_GetArity(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<FunctionReference>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Arity;
		}

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x0600144D RID: 5197 RVA: 0x00041DA7 File Offset: 0x0003FFA7
		public virtual int Arity
		{
			[Register("getArity", "()I", "GetGetArityHandler")]
			get
			{
				return FunctionReference._members.InstanceMethods.InvokeVirtualInt32Method("getArity.()I", this, null);
			}
		}

		// Token: 0x0600144E RID: 5198 RVA: 0x00041DC0 File Offset: 0x0003FFC0
		private static Delegate GetIsExternalHandler()
		{
			if (FunctionReference.cb_isExternal == null)
			{
				FunctionReference.cb_isExternal = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(FunctionReference.n_IsExternal));
			}
			return FunctionReference.cb_isExternal;
		}

		// Token: 0x0600144F RID: 5199 RVA: 0x00041DE4 File Offset: 0x0003FFE4
		private static bool n_IsExternal(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<FunctionReference>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsExternal;
		}

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x06001450 RID: 5200 RVA: 0x00041DF3 File Offset: 0x0003FFF3
		public virtual bool IsExternal
		{
			[Register("isExternal", "()Z", "GetIsExternalHandler")]
			get
			{
				return FunctionReference._members.InstanceMethods.InvokeVirtualBooleanMethod("isExternal.()Z", this, null);
			}
		}

		// Token: 0x06001451 RID: 5201 RVA: 0x00041E0C File Offset: 0x0004000C
		private static Delegate GetIsInfixHandler()
		{
			if (FunctionReference.cb_isInfix == null)
			{
				FunctionReference.cb_isInfix = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(FunctionReference.n_IsInfix));
			}
			return FunctionReference.cb_isInfix;
		}

		// Token: 0x06001452 RID: 5202 RVA: 0x00041E30 File Offset: 0x00040030
		private static bool n_IsInfix(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<FunctionReference>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsInfix;
		}

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x06001453 RID: 5203 RVA: 0x00041E3F File Offset: 0x0004003F
		public virtual bool IsInfix
		{
			[Register("isInfix", "()Z", "GetIsInfixHandler")]
			get
			{
				return FunctionReference._members.InstanceMethods.InvokeVirtualBooleanMethod("isInfix.()Z", this, null);
			}
		}

		// Token: 0x06001454 RID: 5204 RVA: 0x00041E58 File Offset: 0x00040058
		private static Delegate GetIsInlineHandler()
		{
			if (FunctionReference.cb_isInline == null)
			{
				FunctionReference.cb_isInline = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(FunctionReference.n_IsInline));
			}
			return FunctionReference.cb_isInline;
		}

		// Token: 0x06001455 RID: 5205 RVA: 0x00041E7C File Offset: 0x0004007C
		private static bool n_IsInline(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<FunctionReference>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsInline;
		}

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x06001456 RID: 5206 RVA: 0x00041E8B File Offset: 0x0004008B
		public virtual bool IsInline
		{
			[Register("isInline", "()Z", "GetIsInlineHandler")]
			get
			{
				return FunctionReference._members.InstanceMethods.InvokeVirtualBooleanMethod("isInline.()Z", this, null);
			}
		}

		// Token: 0x06001457 RID: 5207 RVA: 0x00041EA4 File Offset: 0x000400A4
		private static Delegate GetIsOperatorHandler()
		{
			if (FunctionReference.cb_isOperator == null)
			{
				FunctionReference.cb_isOperator = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(FunctionReference.n_IsOperator));
			}
			return FunctionReference.cb_isOperator;
		}

		// Token: 0x06001458 RID: 5208 RVA: 0x00041EC8 File Offset: 0x000400C8
		private static bool n_IsOperator(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<FunctionReference>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsOperator;
		}

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x06001459 RID: 5209 RVA: 0x00041ED7 File Offset: 0x000400D7
		public virtual bool IsOperator
		{
			[Register("isOperator", "()Z", "GetIsOperatorHandler")]
			get
			{
				return FunctionReference._members.InstanceMethods.InvokeVirtualBooleanMethod("isOperator.()Z", this, null);
			}
		}

		// Token: 0x0600145A RID: 5210 RVA: 0x00041EF0 File Offset: 0x000400F0
		private static Delegate GetComputeReflectedHandler()
		{
			if (FunctionReference.cb_computeReflected == null)
			{
				FunctionReference.cb_computeReflected = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(FunctionReference.n_ComputeReflected));
			}
			return FunctionReference.cb_computeReflected;
		}

		// Token: 0x0600145B RID: 5211 RVA: 0x00041F14 File Offset: 0x00040114
		private static IntPtr n_ComputeReflected(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<FunctionReference>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ComputeReflected());
		}

		// Token: 0x0600145C RID: 5212 RVA: 0x00041F28 File Offset: 0x00040128
		[NullableContext(2)]
		[Register("computeReflected", "()Lkotlin/reflect/KCallable;", "GetComputeReflectedHandler")]
		protected override IKCallable ComputeReflected()
		{
			return Java.Lang.Object.GetObject<IKCallable>(FunctionReference._members.InstanceMethods.InvokeVirtualObjectMethod("computeReflected.()Lkotlin/reflect/KCallable;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000698 RID: 1688
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/FunctionReference", typeof(FunctionReference));

		// Token: 0x04000699 RID: 1689
		[Nullable(2)]
		private static Delegate cb_getArity;

		// Token: 0x0400069A RID: 1690
		[Nullable(2)]
		private static Delegate cb_isExternal;

		// Token: 0x0400069B RID: 1691
		[Nullable(2)]
		private static Delegate cb_isInfix;

		// Token: 0x0400069C RID: 1692
		[Nullable(2)]
		private static Delegate cb_isInline;

		// Token: 0x0400069D RID: 1693
		[Nullable(2)]
		private static Delegate cb_isOperator;

		// Token: 0x0400069E RID: 1694
		[Nullable(2)]
		private static Delegate cb_computeReflected;
	}
}
