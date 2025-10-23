using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Org.Json;

namespace Com.Unity3d.Services.Store.Gpbl.Bridges
{
	// Token: 0x02000055 RID: 85
	[Register("com/unity3d/services/store/gpbl/bridges/PurchaseBridge", DoNotGenerateAcw = true)]
	public class PurchaseBridge : CommonJsonResponseBridge
	{
		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000217 RID: 535 RVA: 0x00005D44 File Offset: 0x00003F44
		internal new static IntPtr class_ref
		{
			get
			{
				return PurchaseBridge._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000218 RID: 536 RVA: 0x00005D68 File Offset: 0x00003F68
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return PurchaseBridge._members;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000219 RID: 537 RVA: 0x00005D70 File Offset: 0x00003F70
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return PurchaseBridge._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x0600021A RID: 538 RVA: 0x00005D94 File Offset: 0x00003F94
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return PurchaseBridge._members.ManagedPeerType;
			}
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00005CD5 File Offset: 0x00003ED5
		protected PurchaseBridge(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00005DA0 File Offset: 0x00003FA0
		[Register(".ctor", "(Ljava/lang/Object;)V", "")]
		public unsafe PurchaseBridge(Java.Lang.Object purchase) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((purchase == null) ? IntPtr.Zero : purchase.Handle);
				base.SetHandle(PurchaseBridge._members.InstanceMethods.StartCreateInstance("(Ljava/lang/Object;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				PurchaseBridge._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(purchase);
			}
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00005E50 File Offset: 0x00004050
		private static Delegate GetGetClassNameHandler()
		{
			if (PurchaseBridge.cb_getClassName == null)
			{
				PurchaseBridge.cb_getClassName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(PurchaseBridge.n_GetClassName));
			}
			return PurchaseBridge.cb_getClassName;
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00005E74 File Offset: 0x00004074
		private static IntPtr n_GetClassName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<PurchaseBridge>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ClassName);
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x0600021F RID: 543 RVA: 0x00005E88 File Offset: 0x00004088
		protected override string ClassName
		{
			[Register("getClassName", "()Ljava/lang/String;", "GetGetClassNameHandler")]
			get
			{
				return JNIEnv.GetString(PurchaseBridge._members.InstanceMethods.InvokeVirtualObjectMethod("getClassName.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00005EBA File Offset: 0x000040BA
		private static Delegate GetGetSignatureHandler()
		{
			if (PurchaseBridge.cb_getSignature == null)
			{
				PurchaseBridge.cb_getSignature = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(PurchaseBridge.n_GetSignature));
			}
			return PurchaseBridge.cb_getSignature;
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00005EDE File Offset: 0x000040DE
		private static IntPtr n_GetSignature(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<PurchaseBridge>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Signature);
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000222 RID: 546 RVA: 0x00005EF4 File Offset: 0x000040F4
		public virtual string Signature
		{
			[Register("getSignature", "()Ljava/lang/String;", "GetGetSignatureHandler")]
			get
			{
				return JNIEnv.GetString(PurchaseBridge._members.InstanceMethods.InvokeVirtualObjectMethod("getSignature.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00005F26 File Offset: 0x00004126
		private static Delegate GetToJsonHandler()
		{
			if (PurchaseBridge.cb_toJson == null)
			{
				PurchaseBridge.cb_toJson = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(PurchaseBridge.n_ToJson));
			}
			return PurchaseBridge.cb_toJson;
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00005F4A File Offset: 0x0000414A
		private static IntPtr n_ToJson(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<PurchaseBridge>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToJson());
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00005F60 File Offset: 0x00004160
		[Register("toJson", "()Lorg/json/JSONObject;", "GetToJsonHandler")]
		public virtual JSONObject ToJson()
		{
			return Java.Lang.Object.GetObject<JSONObject>(PurchaseBridge._members.InstanceMethods.InvokeVirtualObjectMethod("toJson.()Lorg/json/JSONObject;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400004F RID: 79
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/store/gpbl/bridges/PurchaseBridge", typeof(PurchaseBridge));

		// Token: 0x04000050 RID: 80
		private static Delegate cb_getClassName;

		// Token: 0x04000051 RID: 81
		private static Delegate cb_getSignature;

		// Token: 0x04000052 RID: 82
		private static Delegate cb_toJson;
	}
}
