using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Contracts
{
	// Token: 0x02000274 RID: 628
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/contracts/ContractBuilder", DoNotGenerateAcw = true)]
	internal class IContractBuilderInvoker : Java.Lang.Object, IContractBuilder, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700083B RID: 2107
		// (get) Token: 0x06001C63 RID: 7267 RVA: 0x0005E75C File Offset: 0x0005C95C
		private static IntPtr java_class_ref
		{
			get
			{
				return IContractBuilderInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700083C RID: 2108
		// (get) Token: 0x06001C64 RID: 7268 RVA: 0x0005E780 File Offset: 0x0005C980
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IContractBuilderInvoker._members;
			}
		}

		// Token: 0x1700083D RID: 2109
		// (get) Token: 0x06001C65 RID: 7269 RVA: 0x0005E787 File Offset: 0x0005C987
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700083E RID: 2110
		// (get) Token: 0x06001C66 RID: 7270 RVA: 0x0005E78F File Offset: 0x0005C98F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IContractBuilderInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001C67 RID: 7271 RVA: 0x0005E79B File Offset: 0x0005C99B
		[NullableContext(2)]
		public static IContractBuilder GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IContractBuilder>(handle, transfer);
		}

		// Token: 0x06001C68 RID: 7272 RVA: 0x0005E7A4 File Offset: 0x0005C9A4
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IContractBuilderInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.contracts.ContractBuilder'.");
			}
			return handle;
		}

		// Token: 0x06001C69 RID: 7273 RVA: 0x0005E7CF File Offset: 0x0005C9CF
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001C6A RID: 7274 RVA: 0x0005E800 File Offset: 0x0005CA00
		public IContractBuilderInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IContractBuilderInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06001C6B RID: 7275 RVA: 0x0005E838 File Offset: 0x0005CA38
		private static Delegate GetCallsInPlace_Lkotlin_Function_Lkotlin_contracts_InvocationKind_Handler()
		{
			if (IContractBuilderInvoker.cb_callsInPlace_Lkotlin_Function_Lkotlin_contracts_InvocationKind_ == null)
			{
				IContractBuilderInvoker.cb_callsInPlace_Lkotlin_Function_Lkotlin_contracts_InvocationKind_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(IContractBuilderInvoker.n_CallsInPlace_Lkotlin_Function_Lkotlin_contracts_InvocationKind_));
			}
			return IContractBuilderInvoker.cb_callsInPlace_Lkotlin_Function_Lkotlin_contracts_InvocationKind_;
		}

		// Token: 0x06001C6C RID: 7276 RVA: 0x0005E85C File Offset: 0x0005CA5C
		private static IntPtr n_CallsInPlace_Lkotlin_Function_Lkotlin_contracts_InvocationKind_(IntPtr jnienv, IntPtr native__this, IntPtr native_lambda, IntPtr native_kind)
		{
			IContractBuilder @object = Java.Lang.Object.GetObject<IContractBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IFunction object2 = Java.Lang.Object.GetObject<IFunction>(native_lambda, JniHandleOwnership.DoNotTransfer);
			InvocationKind object3 = Java.Lang.Object.GetObject<InvocationKind>(native_kind, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.CallsInPlace(object2, object3));
		}

		// Token: 0x06001C6D RID: 7277 RVA: 0x0005E890 File Offset: 0x0005CA90
		public unsafe ICallsInPlace CallsInPlace(IFunction lambda, InvocationKind kind)
		{
			if (this.id_callsInPlace_Lkotlin_Function_Lkotlin_contracts_InvocationKind_ == IntPtr.Zero)
			{
				this.id_callsInPlace_Lkotlin_Function_Lkotlin_contracts_InvocationKind_ = JNIEnv.GetMethodID(this.class_ref, "callsInPlace", "(Lkotlin/Function;Lkotlin/contracts/InvocationKind;)Lkotlin/contracts/CallsInPlace;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((lambda == null) ? IntPtr.Zero : ((Java.Lang.Object)lambda).Handle);
			ptr[1] = new JValue((kind == null) ? IntPtr.Zero : kind.Handle);
			return Java.Lang.Object.GetObject<ICallsInPlace>(JNIEnv.CallObjectMethod(base.Handle, this.id_callsInPlace_Lkotlin_Function_Lkotlin_contracts_InvocationKind_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001C6E RID: 7278 RVA: 0x0005E930 File Offset: 0x0005CB30
		private static Delegate GetReturnsHandler()
		{
			if (IContractBuilderInvoker.cb_returns == null)
			{
				IContractBuilderInvoker.cb_returns = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IContractBuilderInvoker.n_Returns));
			}
			return IContractBuilderInvoker.cb_returns;
		}

		// Token: 0x06001C6F RID: 7279 RVA: 0x0005E954 File Offset: 0x0005CB54
		private static IntPtr n_Returns(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IContractBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Returns());
		}

		// Token: 0x06001C70 RID: 7280 RVA: 0x0005E968 File Offset: 0x0005CB68
		public IReturns Returns()
		{
			if (this.id_returns == IntPtr.Zero)
			{
				this.id_returns = JNIEnv.GetMethodID(this.class_ref, "returns", "()Lkotlin/contracts/Returns;");
			}
			return Java.Lang.Object.GetObject<IReturns>(JNIEnv.CallObjectMethod(base.Handle, this.id_returns), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001C71 RID: 7281 RVA: 0x0005E9B9 File Offset: 0x0005CBB9
		private static Delegate GetReturns_Ljava_lang_Object_Handler()
		{
			if (IContractBuilderInvoker.cb_returns_Ljava_lang_Object_ == null)
			{
				IContractBuilderInvoker.cb_returns_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IContractBuilderInvoker.n_Returns_Ljava_lang_Object_));
			}
			return IContractBuilderInvoker.cb_returns_Ljava_lang_Object_;
		}

		// Token: 0x06001C72 RID: 7282 RVA: 0x0005E9E0 File Offset: 0x0005CBE0
		private static IntPtr n_Returns_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			IContractBuilder @object = Java.Lang.Object.GetObject<IContractBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_value, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Returns(object2));
		}

		// Token: 0x06001C73 RID: 7283 RVA: 0x0005EA08 File Offset: 0x0005CC08
		public unsafe IReturns Returns([Nullable(2)] Java.Lang.Object value)
		{
			if (this.id_returns_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_returns_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "returns", "(Ljava/lang/Object;)Lkotlin/contracts/Returns;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((value == null) ? IntPtr.Zero : value.Handle);
			return Java.Lang.Object.GetObject<IReturns>(JNIEnv.CallObjectMethod(base.Handle, this.id_returns_Ljava_lang_Object_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001C74 RID: 7284 RVA: 0x0005EA81 File Offset: 0x0005CC81
		private static Delegate GetReturnsNotNullHandler()
		{
			if (IContractBuilderInvoker.cb_returnsNotNull == null)
			{
				IContractBuilderInvoker.cb_returnsNotNull = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IContractBuilderInvoker.n_ReturnsNotNull));
			}
			return IContractBuilderInvoker.cb_returnsNotNull;
		}

		// Token: 0x06001C75 RID: 7285 RVA: 0x0005EAA5 File Offset: 0x0005CCA5
		private static IntPtr n_ReturnsNotNull(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IContractBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ReturnsNotNull());
		}

		// Token: 0x06001C76 RID: 7286 RVA: 0x0005EABC File Offset: 0x0005CCBC
		public IReturnsNotNull ReturnsNotNull()
		{
			if (this.id_returnsNotNull == IntPtr.Zero)
			{
				this.id_returnsNotNull = JNIEnv.GetMethodID(this.class_ref, "returnsNotNull", "()Lkotlin/contracts/ReturnsNotNull;");
			}
			return Java.Lang.Object.GetObject<IReturnsNotNull>(JNIEnv.CallObjectMethod(base.Handle, this.id_returnsNotNull), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040008B9 RID: 2233
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/contracts/ContractBuilder", typeof(IContractBuilderInvoker));

		// Token: 0x040008BA RID: 2234
		private IntPtr class_ref;

		// Token: 0x040008BB RID: 2235
		[Nullable(2)]
		private static Delegate cb_callsInPlace_Lkotlin_Function_Lkotlin_contracts_InvocationKind_;

		// Token: 0x040008BC RID: 2236
		private IntPtr id_callsInPlace_Lkotlin_Function_Lkotlin_contracts_InvocationKind_;

		// Token: 0x040008BD RID: 2237
		[Nullable(2)]
		private static Delegate cb_returns;

		// Token: 0x040008BE RID: 2238
		private IntPtr id_returns;

		// Token: 0x040008BF RID: 2239
		[Nullable(2)]
		private static Delegate cb_returns_Ljava_lang_Object_;

		// Token: 0x040008C0 RID: 2240
		private IntPtr id_returns_Ljava_lang_Object_;

		// Token: 0x040008C1 RID: 2241
		[Nullable(2)]
		private static Delegate cb_returnsNotNull;

		// Token: 0x040008C2 RID: 2242
		private IntPtr id_returnsNotNull;
	}
}
