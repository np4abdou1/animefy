using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Contracts
{
	// Token: 0x0200027F RID: 639
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/contracts/SimpleEffect", DoNotGenerateAcw = true)]
	internal class ISimpleEffectInvoker : Java.Lang.Object, ISimpleEffect, IEffect, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000858 RID: 2136
		// (get) Token: 0x06001CBC RID: 7356 RVA: 0x0005F4C0 File Offset: 0x0005D6C0
		private static IntPtr java_class_ref
		{
			get
			{
				return ISimpleEffectInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000859 RID: 2137
		// (get) Token: 0x06001CBD RID: 7357 RVA: 0x0005F4E4 File Offset: 0x0005D6E4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ISimpleEffectInvoker._members;
			}
		}

		// Token: 0x1700085A RID: 2138
		// (get) Token: 0x06001CBE RID: 7358 RVA: 0x0005F4EB File Offset: 0x0005D6EB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700085B RID: 2139
		// (get) Token: 0x06001CBF RID: 7359 RVA: 0x0005F4F3 File Offset: 0x0005D6F3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ISimpleEffectInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001CC0 RID: 7360 RVA: 0x0005F4FF File Offset: 0x0005D6FF
		[NullableContext(2)]
		public static ISimpleEffect GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ISimpleEffect>(handle, transfer);
		}

		// Token: 0x06001CC1 RID: 7361 RVA: 0x0005F508 File Offset: 0x0005D708
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ISimpleEffectInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.contracts.SimpleEffect'.");
			}
			return handle;
		}

		// Token: 0x06001CC2 RID: 7362 RVA: 0x0005F533 File Offset: 0x0005D733
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001CC3 RID: 7363 RVA: 0x0005F564 File Offset: 0x0005D764
		public ISimpleEffectInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ISimpleEffectInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06001CC4 RID: 7364 RVA: 0x0005F59C File Offset: 0x0005D79C
		private static Delegate GetImplies_ZHandler()
		{
			if (ISimpleEffectInvoker.cb_implies_Z == null)
			{
				ISimpleEffectInvoker.cb_implies_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_L(ISimpleEffectInvoker.n_Implies_Z));
			}
			return ISimpleEffectInvoker.cb_implies_Z;
		}

		// Token: 0x06001CC5 RID: 7365 RVA: 0x0005F5C0 File Offset: 0x0005D7C0
		private static IntPtr n_Implies_Z(IntPtr jnienv, IntPtr native__this, bool booleanExpression)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISimpleEffect>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Implies(booleanExpression));
		}

		// Token: 0x06001CC6 RID: 7366 RVA: 0x0005F5D8 File Offset: 0x0005D7D8
		public unsafe IConditionalEffect Implies(bool booleanExpression)
		{
			if (this.id_implies_Z == IntPtr.Zero)
			{
				this.id_implies_Z = JNIEnv.GetMethodID(this.class_ref, "implies", "(Z)Lkotlin/contracts/ConditionalEffect;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(booleanExpression);
			return Java.Lang.Object.GetObject<IConditionalEffect>(JNIEnv.CallObjectMethod(base.Handle, this.id_implies_Z, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040008D8 RID: 2264
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/contracts/SimpleEffect", typeof(ISimpleEffectInvoker));

		// Token: 0x040008D9 RID: 2265
		private IntPtr class_ref;

		// Token: 0x040008DA RID: 2266
		[Nullable(2)]
		private static Delegate cb_implies_Z;

		// Token: 0x040008DB RID: 2267
		private IntPtr id_implies_Z;
	}
}
