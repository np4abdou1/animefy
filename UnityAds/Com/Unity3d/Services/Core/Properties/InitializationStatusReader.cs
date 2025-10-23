using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Properties
{
	// Token: 0x020000CB RID: 203
	[Register("com/unity3d/services/core/properties/InitializationStatusReader", DoNotGenerateAcw = true)]
	public class InitializationStatusReader : Java.Lang.Object
	{
		// Token: 0x1700027F RID: 639
		// (get) Token: 0x060007F1 RID: 2033 RVA: 0x00016CF0 File Offset: 0x00014EF0
		internal static IntPtr class_ref
		{
			get
			{
				return InitializationStatusReader._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x060007F2 RID: 2034 RVA: 0x00016D14 File Offset: 0x00014F14
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return InitializationStatusReader._members;
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x060007F3 RID: 2035 RVA: 0x00016D1C File Offset: 0x00014F1C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return InitializationStatusReader._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x060007F4 RID: 2036 RVA: 0x00016D40 File Offset: 0x00014F40
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return InitializationStatusReader._members.ManagedPeerType;
			}
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x000021E8 File Offset: 0x000003E8
		protected InitializationStatusReader(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x00016D4C File Offset: 0x00014F4C
		[Register(".ctor", "()V", "")]
		public InitializationStatusReader() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(InitializationStatusReader._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			InitializationStatusReader._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060007F7 RID: 2039 RVA: 0x00016DBA File Offset: 0x00014FBA
		private static Delegate GetGetInitializationStateString_Lcom_unity3d_services_core_properties_SdkProperties_InitializationState_Handler()
		{
			if (InitializationStatusReader.cb_getInitializationStateString_Lcom_unity3d_services_core_properties_SdkProperties_InitializationState_ == null)
			{
				InitializationStatusReader.cb_getInitializationStateString_Lcom_unity3d_services_core_properties_SdkProperties_InitializationState_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(InitializationStatusReader.n_GetInitializationStateString_Lcom_unity3d_services_core_properties_SdkProperties_InitializationState_));
			}
			return InitializationStatusReader.cb_getInitializationStateString_Lcom_unity3d_services_core_properties_SdkProperties_InitializationState_;
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x00016DE0 File Offset: 0x00014FE0
		private static IntPtr n_GetInitializationStateString_Lcom_unity3d_services_core_properties_SdkProperties_InitializationState_(IntPtr jnienv, IntPtr native__this, IntPtr native_state)
		{
			InitializationStatusReader @object = Java.Lang.Object.GetObject<InitializationStatusReader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			SdkProperties.InitializationState object2 = Java.Lang.Object.GetObject<SdkProperties.InitializationState>(native_state, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString(@object.GetInitializationStateString(object2));
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x00016E08 File Offset: 0x00015008
		[Register("getInitializationStateString", "(Lcom/unity3d/services/core/properties/SdkProperties$InitializationState;)Ljava/lang/String;", "GetGetInitializationStateString_Lcom_unity3d_services_core_properties_SdkProperties_InitializationState_Handler")]
		public unsafe virtual string GetInitializationStateString(SdkProperties.InitializationState state)
		{
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((state == null) ? IntPtr.Zero : state.Handle);
				@string = JNIEnv.GetString(InitializationStatusReader._members.InstanceMethods.InvokeVirtualObjectMethod("getInitializationStateString.(Lcom/unity3d/services/core/properties/SdkProperties$InitializationState;)Ljava/lang/String;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(state);
			}
			return @string;
		}

		// Token: 0x040001E7 RID: 487
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/properties/InitializationStatusReader", typeof(InitializationStatusReader));

		// Token: 0x040001E8 RID: 488
		private static Delegate cb_getInitializationStateString_Lcom_unity3d_services_core_properties_SdkProperties_InitializationState_;
	}
}
