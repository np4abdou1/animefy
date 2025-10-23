using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.Reflection;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Store.Gpbl.Bridges
{
	// Token: 0x02000057 RID: 87
	[Register("com/unity3d/services/store/gpbl/bridges/PurchasesResultBridge", DoNotGenerateAcw = true)]
	public class PurchasesResultBridge : GenericBridge
	{
		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000231 RID: 561 RVA: 0x00006144 File Offset: 0x00004344
		internal new static IntPtr class_ref
		{
			get
			{
				return PurchasesResultBridge._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000232 RID: 562 RVA: 0x00006168 File Offset: 0x00004368
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return PurchasesResultBridge._members;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000233 RID: 563 RVA: 0x00006170 File Offset: 0x00004370
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return PurchasesResultBridge._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000234 RID: 564 RVA: 0x00006194 File Offset: 0x00004394
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return PurchasesResultBridge._members.ManagedPeerType;
			}
		}

		// Token: 0x06000235 RID: 565 RVA: 0x000058C0 File Offset: 0x00003AC0
		protected PurchasesResultBridge(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000236 RID: 566 RVA: 0x000061A0 File Offset: 0x000043A0
		[Register(".ctor", "(Ljava/lang/Object;)V", "")]
		public unsafe PurchasesResultBridge(Java.Lang.Object purchasesResult) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((purchasesResult == null) ? IntPtr.Zero : purchasesResult.Handle);
				base.SetHandle(PurchasesResultBridge._members.InstanceMethods.StartCreateInstance("(Ljava/lang/Object;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				PurchasesResultBridge._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(purchasesResult);
			}
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00006250 File Offset: 0x00004450
		private static Delegate GetGetBillingResultHandler()
		{
			if (PurchasesResultBridge.cb_getBillingResult == null)
			{
				PurchasesResultBridge.cb_getBillingResult = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(PurchasesResultBridge.n_GetBillingResult));
			}
			return PurchasesResultBridge.cb_getBillingResult;
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00006274 File Offset: 0x00004474
		private static IntPtr n_GetBillingResult(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<PurchasesResultBridge>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).BillingResult);
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000239 RID: 569 RVA: 0x00006288 File Offset: 0x00004488
		public virtual BillingResultBridge BillingResult
		{
			[Register("getBillingResult", "()Lcom/unity3d/services/store/gpbl/bridges/BillingResultBridge;", "GetGetBillingResultHandler")]
			get
			{
				return Java.Lang.Object.GetObject<BillingResultBridge>(PurchasesResultBridge._members.InstanceMethods.InvokeVirtualObjectMethod("getBillingResult.()Lcom/unity3d/services/store/gpbl/bridges/BillingResultBridge;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600023A RID: 570 RVA: 0x000062BA File Offset: 0x000044BA
		private static Delegate GetGetClassNameHandler()
		{
			if (PurchasesResultBridge.cb_getClassName == null)
			{
				PurchasesResultBridge.cb_getClassName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(PurchasesResultBridge.n_GetClassName));
			}
			return PurchasesResultBridge.cb_getClassName;
		}

		// Token: 0x0600023B RID: 571 RVA: 0x000062DE File Offset: 0x000044DE
		private static IntPtr n_GetClassName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<PurchasesResultBridge>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ClassName);
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x0600023C RID: 572 RVA: 0x000062F4 File Offset: 0x000044F4
		protected override string ClassName
		{
			[Register("getClassName", "()Ljava/lang/String;", "GetGetClassNameHandler")]
			get
			{
				return JNIEnv.GetString(PurchasesResultBridge._members.InstanceMethods.InvokeVirtualObjectMethod("getClassName.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00006326 File Offset: 0x00004526
		private static Delegate GetGetPurchasesListHandler()
		{
			if (PurchasesResultBridge.cb_getPurchasesList == null)
			{
				PurchasesResultBridge.cb_getPurchasesList = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(PurchasesResultBridge.n_GetPurchasesList));
			}
			return PurchasesResultBridge.cb_getPurchasesList;
		}

		// Token: 0x0600023E RID: 574 RVA: 0x0000634A File Offset: 0x0000454A
		private static IntPtr n_GetPurchasesList(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<PurchaseBridge>.ToLocalJniHandle(Java.Lang.Object.GetObject<PurchasesResultBridge>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PurchasesList);
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x0600023F RID: 575 RVA: 0x00006360 File Offset: 0x00004560
		public virtual IList<PurchaseBridge> PurchasesList
		{
			[Register("getPurchasesList", "()Ljava/util/List;", "GetGetPurchasesListHandler")]
			get
			{
				return JavaList<PurchaseBridge>.FromJniHandle(PurchasesResultBridge._members.InstanceMethods.InvokeVirtualObjectMethod("getPurchasesList.()Ljava/util/List;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x04000055 RID: 85
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/store/gpbl/bridges/PurchasesResultBridge", typeof(PurchasesResultBridge));

		// Token: 0x04000056 RID: 86
		private static Delegate cb_getBillingResult;

		// Token: 0x04000057 RID: 87
		private static Delegate cb_getClassName;

		// Token: 0x04000058 RID: 88
		private static Delegate cb_getPurchasesList;
	}
}
