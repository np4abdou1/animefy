using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Store.Gpbl.Bridges
{
	// Token: 0x02000056 RID: 86
	[Register("com/unity3d/services/store/gpbl/bridges/PurchaseHistoryRecordBridge", DoNotGenerateAcw = true)]
	public class PurchaseHistoryRecordBridge : CommonJsonResponseBridge
	{
		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000227 RID: 551 RVA: 0x00005FB0 File Offset: 0x000041B0
		internal new static IntPtr class_ref
		{
			get
			{
				return PurchaseHistoryRecordBridge._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000228 RID: 552 RVA: 0x00005FD4 File Offset: 0x000041D4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return PurchaseHistoryRecordBridge._members;
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000229 RID: 553 RVA: 0x00005FDC File Offset: 0x000041DC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return PurchaseHistoryRecordBridge._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x0600022A RID: 554 RVA: 0x00006000 File Offset: 0x00004200
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return PurchaseHistoryRecordBridge._members.ManagedPeerType;
			}
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00005CD5 File Offset: 0x00003ED5
		protected PurchaseHistoryRecordBridge(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600022C RID: 556 RVA: 0x0000600C File Offset: 0x0000420C
		[Register(".ctor", "(Ljava/lang/Object;)V", "")]
		public unsafe PurchaseHistoryRecordBridge(Java.Lang.Object purchaseHistoryRecord) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((purchaseHistoryRecord == null) ? IntPtr.Zero : purchaseHistoryRecord.Handle);
				base.SetHandle(PurchaseHistoryRecordBridge._members.InstanceMethods.StartCreateInstance("(Ljava/lang/Object;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				PurchaseHistoryRecordBridge._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(purchaseHistoryRecord);
			}
		}

		// Token: 0x0600022D RID: 557 RVA: 0x000060BC File Offset: 0x000042BC
		private static Delegate GetGetClassNameHandler()
		{
			if (PurchaseHistoryRecordBridge.cb_getClassName == null)
			{
				PurchaseHistoryRecordBridge.cb_getClassName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(PurchaseHistoryRecordBridge.n_GetClassName));
			}
			return PurchaseHistoryRecordBridge.cb_getClassName;
		}

		// Token: 0x0600022E RID: 558 RVA: 0x000060E0 File Offset: 0x000042E0
		private static IntPtr n_GetClassName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<PurchaseHistoryRecordBridge>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ClassName);
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x0600022F RID: 559 RVA: 0x000060F4 File Offset: 0x000042F4
		protected override string ClassName
		{
			[Register("getClassName", "()Ljava/lang/String;", "GetGetClassNameHandler")]
			get
			{
				return JNIEnv.GetString(PurchaseHistoryRecordBridge._members.InstanceMethods.InvokeVirtualObjectMethod("getClassName.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x04000053 RID: 83
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/store/gpbl/bridges/PurchaseHistoryRecordBridge", typeof(PurchaseHistoryRecordBridge));

		// Token: 0x04000054 RID: 84
		private static Delegate cb_getClassName;
	}
}
