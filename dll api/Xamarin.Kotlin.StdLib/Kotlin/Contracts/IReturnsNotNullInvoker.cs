using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Contracts
{
	// Token: 0x0200027D RID: 637
	[Register("kotlin/contracts/ReturnsNotNull", DoNotGenerateAcw = true)]
	internal class IReturnsNotNullInvoker : Java.Lang.Object, IReturnsNotNull, ISimpleEffect, IEffect, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000854 RID: 2132
		// (get) Token: 0x06001CAF RID: 7343 RVA: 0x0005F320 File Offset: 0x0005D520
		private static IntPtr java_class_ref
		{
			get
			{
				return IReturnsNotNullInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000855 RID: 2133
		// (get) Token: 0x06001CB0 RID: 7344 RVA: 0x0005F344 File Offset: 0x0005D544
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return IReturnsNotNullInvoker._members;
			}
		}

		// Token: 0x17000856 RID: 2134
		// (get) Token: 0x06001CB1 RID: 7345 RVA: 0x0005F34B File Offset: 0x0005D54B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000857 RID: 2135
		// (get) Token: 0x06001CB2 RID: 7346 RVA: 0x0005F353 File Offset: 0x0005D553
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return IReturnsNotNullInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001CB3 RID: 7347 RVA: 0x0005F35F File Offset: 0x0005D55F
		[NullableContext(2)]
		public static IReturnsNotNull GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IReturnsNotNull>(handle, transfer);
		}

		// Token: 0x06001CB4 RID: 7348 RVA: 0x0005F368 File Offset: 0x0005D568
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IReturnsNotNullInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.contracts.ReturnsNotNull'.");
			}
			return handle;
		}

		// Token: 0x06001CB5 RID: 7349 RVA: 0x0005F393 File Offset: 0x0005D593
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001CB6 RID: 7350 RVA: 0x0005F3C4 File Offset: 0x0005D5C4
		public IReturnsNotNullInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IReturnsNotNullInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06001CB7 RID: 7351 RVA: 0x0005F3FC File Offset: 0x0005D5FC
		[NullableContext(1)]
		private static Delegate GetImplies_ZHandler()
		{
			if (IReturnsNotNullInvoker.cb_implies_Z == null)
			{
				IReturnsNotNullInvoker.cb_implies_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_L(IReturnsNotNullInvoker.n_Implies_Z));
			}
			return IReturnsNotNullInvoker.cb_implies_Z;
		}

		// Token: 0x06001CB8 RID: 7352 RVA: 0x0005F420 File Offset: 0x0005D620
		private static IntPtr n_Implies_Z(IntPtr jnienv, IntPtr native__this, bool booleanExpression)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IReturnsNotNull>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Implies(booleanExpression));
		}

		// Token: 0x06001CB9 RID: 7353 RVA: 0x0005F438 File Offset: 0x0005D638
		[NullableContext(1)]
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

		// Token: 0x040008D4 RID: 2260
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/contracts/ReturnsNotNull", typeof(IReturnsNotNullInvoker));

		// Token: 0x040008D5 RID: 2261
		private IntPtr class_ref;

		// Token: 0x040008D6 RID: 2262
		[Nullable(2)]
		private static Delegate cb_implies_Z;

		// Token: 0x040008D7 RID: 2263
		private IntPtr id_implies_Z;
	}
}
