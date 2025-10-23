using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.Reflection;
using Java.Interop;
using Java.Lang;
using Org.Json;

namespace Com.Unity3d.Services.Store.Gpbl.Bridges
{
	// Token: 0x02000053 RID: 83
	[Register("com/unity3d/services/store/gpbl/bridges/CommonJsonResponseBridge", DoNotGenerateAcw = true)]
	public abstract class CommonJsonResponseBridge : GenericBridge, IBillingResponse, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000207 RID: 519 RVA: 0x00005A70 File Offset: 0x00003C70
		internal new static IntPtr class_ref
		{
			get
			{
				return CommonJsonResponseBridge._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000208 RID: 520 RVA: 0x00005A94 File Offset: 0x00003C94
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CommonJsonResponseBridge._members;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000209 RID: 521 RVA: 0x00005A9C File Offset: 0x00003C9C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CommonJsonResponseBridge._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x0600020A RID: 522 RVA: 0x00005AC0 File Offset: 0x00003CC0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CommonJsonResponseBridge._members.ManagedPeerType;
			}
		}

		// Token: 0x0600020B RID: 523 RVA: 0x000058C0 File Offset: 0x00003AC0
		protected CommonJsonResponseBridge(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00005ACC File Offset: 0x00003CCC
		[Register(".ctor", "(Ljava/lang/Object;)V", "")]
		protected unsafe CommonJsonResponseBridge(Java.Lang.Object internalBridgeRef) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((internalBridgeRef == null) ? IntPtr.Zero : internalBridgeRef.Handle);
				base.SetHandle(CommonJsonResponseBridge._members.InstanceMethods.StartCreateInstance("(Ljava/lang/Object;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				CommonJsonResponseBridge._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(internalBridgeRef);
			}
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00005B7C File Offset: 0x00003D7C
		[Register(".ctor", "(Ljava/lang/Object;Ljava/util/Map;)V", "")]
		protected unsafe CommonJsonResponseBridge(Java.Lang.Object internalBridgeRef, IDictionary<string, Class[]> functionAndParameters) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JavaDictionary<string, Class[]>.ToLocalJniHandle(functionAndParameters);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((internalBridgeRef == null) ? IntPtr.Zero : internalBridgeRef.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				base.SetHandle(CommonJsonResponseBridge._members.InstanceMethods.StartCreateInstance("(Ljava/lang/Object;Ljava/util/Map;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				CommonJsonResponseBridge._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/Object;Ljava/util/Map;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(internalBridgeRef);
				GC.KeepAlive(functionAndParameters);
			}
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00005C50 File Offset: 0x00003E50
		private static Delegate GetGetOriginalJsonHandler()
		{
			if (CommonJsonResponseBridge.cb_getOriginalJson == null)
			{
				CommonJsonResponseBridge.cb_getOriginalJson = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(CommonJsonResponseBridge.n_GetOriginalJson));
			}
			return CommonJsonResponseBridge.cb_getOriginalJson;
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00005C74 File Offset: 0x00003E74
		private static IntPtr n_GetOriginalJson(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<CommonJsonResponseBridge>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OriginalJson);
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000210 RID: 528 RVA: 0x00005C88 File Offset: 0x00003E88
		public virtual JSONObject OriginalJson
		{
			[Register("getOriginalJson", "()Lorg/json/JSONObject;", "GetGetOriginalJsonHandler")]
			get
			{
				return Java.Lang.Object.GetObject<JSONObject>(CommonJsonResponseBridge._members.InstanceMethods.InvokeVirtualObjectMethod("getOriginalJson.()Lorg/json/JSONObject;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0400004C RID: 76
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/store/gpbl/bridges/CommonJsonResponseBridge", typeof(CommonJsonResponseBridge));

		// Token: 0x0400004D RID: 77
		private static Delegate cb_getOriginalJson;
	}
}
