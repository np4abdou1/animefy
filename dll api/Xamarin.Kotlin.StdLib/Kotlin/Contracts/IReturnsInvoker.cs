using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Contracts
{
	// Token: 0x0200027B RID: 635
	[Register("kotlin/contracts/Returns", DoNotGenerateAcw = true)]
	internal class IReturnsInvoker : Java.Lang.Object, IReturns, ISimpleEffect, IEffect, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000850 RID: 2128
		// (get) Token: 0x06001CA3 RID: 7331 RVA: 0x0005F180 File Offset: 0x0005D380
		private static IntPtr java_class_ref
		{
			get
			{
				return IReturnsInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000851 RID: 2129
		// (get) Token: 0x06001CA4 RID: 7332 RVA: 0x0005F1A4 File Offset: 0x0005D3A4
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return IReturnsInvoker._members;
			}
		}

		// Token: 0x17000852 RID: 2130
		// (get) Token: 0x06001CA5 RID: 7333 RVA: 0x0005F1AB File Offset: 0x0005D3AB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000853 RID: 2131
		// (get) Token: 0x06001CA6 RID: 7334 RVA: 0x0005F1B3 File Offset: 0x0005D3B3
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return IReturnsInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001CA7 RID: 7335 RVA: 0x0005F1BF File Offset: 0x0005D3BF
		[NullableContext(2)]
		public static IReturns GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IReturns>(handle, transfer);
		}

		// Token: 0x06001CA8 RID: 7336 RVA: 0x0005F1C8 File Offset: 0x0005D3C8
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IReturnsInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.contracts.Returns'.");
			}
			return handle;
		}

		// Token: 0x06001CA9 RID: 7337 RVA: 0x0005F1F3 File Offset: 0x0005D3F3
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001CAA RID: 7338 RVA: 0x0005F224 File Offset: 0x0005D424
		public IReturnsInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IReturnsInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06001CAB RID: 7339 RVA: 0x0005F25C File Offset: 0x0005D45C
		[NullableContext(1)]
		private static Delegate GetImplies_ZHandler()
		{
			if (IReturnsInvoker.cb_implies_Z == null)
			{
				IReturnsInvoker.cb_implies_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_L(IReturnsInvoker.n_Implies_Z));
			}
			return IReturnsInvoker.cb_implies_Z;
		}

		// Token: 0x06001CAC RID: 7340 RVA: 0x0005F280 File Offset: 0x0005D480
		private static IntPtr n_Implies_Z(IntPtr jnienv, IntPtr native__this, bool booleanExpression)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IReturns>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Implies(booleanExpression));
		}

		// Token: 0x06001CAD RID: 7341 RVA: 0x0005F298 File Offset: 0x0005D498
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

		// Token: 0x040008D0 RID: 2256
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/contracts/Returns", typeof(IReturnsInvoker));

		// Token: 0x040008D1 RID: 2257
		private IntPtr class_ref;

		// Token: 0x040008D2 RID: 2258
		[Nullable(2)]
		private static Delegate cb_implies_Z;

		// Token: 0x040008D3 RID: 2259
		private IntPtr id_implies_Z;
	}
}
