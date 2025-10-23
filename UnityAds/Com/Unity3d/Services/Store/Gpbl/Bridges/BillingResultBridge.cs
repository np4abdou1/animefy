using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.Reflection;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Store.Gpbl.Bridges
{
	// Token: 0x02000052 RID: 82
	[Register("com/unity3d/services/store/gpbl/bridges/BillingResultBridge", DoNotGenerateAcw = true)]
	public class BillingResultBridge : GenericBridge
	{
		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060001FA RID: 506 RVA: 0x00005864 File Offset: 0x00003A64
		internal new static IntPtr class_ref
		{
			get
			{
				return BillingResultBridge._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060001FB RID: 507 RVA: 0x00005888 File Offset: 0x00003A88
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BillingResultBridge._members;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060001FC RID: 508 RVA: 0x00005890 File Offset: 0x00003A90
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BillingResultBridge._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060001FD RID: 509 RVA: 0x000058B4 File Offset: 0x00003AB4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BillingResultBridge._members.ManagedPeerType;
			}
		}

		// Token: 0x060001FE RID: 510 RVA: 0x000058C0 File Offset: 0x00003AC0
		protected BillingResultBridge(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060001FF RID: 511 RVA: 0x000058CC File Offset: 0x00003ACC
		[Register(".ctor", "(Ljava/lang/Object;)V", "")]
		public unsafe BillingResultBridge(Java.Lang.Object billingResult) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((billingResult == null) ? IntPtr.Zero : billingResult.Handle);
				base.SetHandle(BillingResultBridge._members.InstanceMethods.StartCreateInstance("(Ljava/lang/Object;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				BillingResultBridge._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(billingResult);
			}
		}

		// Token: 0x06000200 RID: 512 RVA: 0x0000597C File Offset: 0x00003B7C
		private static Delegate GetGetClassNameHandler()
		{
			if (BillingResultBridge.cb_getClassName == null)
			{
				BillingResultBridge.cb_getClassName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(BillingResultBridge.n_GetClassName));
			}
			return BillingResultBridge.cb_getClassName;
		}

		// Token: 0x06000201 RID: 513 RVA: 0x000059A0 File Offset: 0x00003BA0
		private static IntPtr n_GetClassName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<BillingResultBridge>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ClassName);
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000202 RID: 514 RVA: 0x000059B4 File Offset: 0x00003BB4
		protected override string ClassName
		{
			[Register("getClassName", "()Ljava/lang/String;", "GetGetClassNameHandler")]
			get
			{
				return JNIEnv.GetString(BillingResultBridge._members.InstanceMethods.InvokeVirtualObjectMethod("getClassName.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000203 RID: 515 RVA: 0x000059E6 File Offset: 0x00003BE6
		private static Delegate GetGetResponseCodeHandler()
		{
			if (BillingResultBridge.cb_getResponseCode == null)
			{
				BillingResultBridge.cb_getResponseCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(BillingResultBridge.n_GetResponseCode));
			}
			return BillingResultBridge.cb_getResponseCode;
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00005A0A File Offset: 0x00003C0A
		private static IntPtr n_GetResponseCode(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<BillingResultBridge>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ResponseCode);
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000205 RID: 517 RVA: 0x00005A20 File Offset: 0x00003C20
		public virtual BillingResultResponseCode ResponseCode
		{
			[Register("getResponseCode", "()Lcom/unity3d/services/store/gpbl/BillingResultResponseCode;", "GetGetResponseCodeHandler")]
			get
			{
				return Java.Lang.Object.GetObject<BillingResultResponseCode>(BillingResultBridge._members.InstanceMethods.InvokeVirtualObjectMethod("getResponseCode.()Lcom/unity3d/services/store/gpbl/BillingResultResponseCode;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x04000049 RID: 73
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/store/gpbl/bridges/BillingResultBridge", typeof(BillingResultBridge));

		// Token: 0x0400004A RID: 74
		private static Delegate cb_getClassName;

		// Token: 0x0400004B RID: 75
		private static Delegate cb_getResponseCode;
	}
}
