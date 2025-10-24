using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.Reflection;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Ads.Gmascar.Bridges
{
	// Token: 0x02000210 RID: 528
	[Register("com/unity3d/services/ads/gmascar/bridges/AdapterStatusBridge", DoNotGenerateAcw = true)]
	public class AdapterStatusBridge : GenericBridge
	{
		// Token: 0x17000873 RID: 2163
		// (get) Token: 0x060018AF RID: 6319 RVA: 0x00047354 File Offset: 0x00045554
		internal new static IntPtr class_ref
		{
			get
			{
				return AdapterStatusBridge._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000874 RID: 2164
		// (get) Token: 0x060018B0 RID: 6320 RVA: 0x00047378 File Offset: 0x00045578
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AdapterStatusBridge._members;
			}
		}

		// Token: 0x17000875 RID: 2165
		// (get) Token: 0x060018B1 RID: 6321 RVA: 0x00047380 File Offset: 0x00045580
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AdapterStatusBridge._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000876 RID: 2166
		// (get) Token: 0x060018B2 RID: 6322 RVA: 0x000473A4 File Offset: 0x000455A4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AdapterStatusBridge._members.ManagedPeerType;
			}
		}

		// Token: 0x060018B3 RID: 6323 RVA: 0x000058C0 File Offset: 0x00003AC0
		protected AdapterStatusBridge(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060018B4 RID: 6324 RVA: 0x000473B0 File Offset: 0x000455B0
		[Register(".ctor", "()V", "")]
		public AdapterStatusBridge() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(AdapterStatusBridge._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			AdapterStatusBridge._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060018B5 RID: 6325 RVA: 0x0004741E File Offset: 0x0004561E
		private static Delegate GetGetClassNameHandler()
		{
			if (AdapterStatusBridge.cb_getClassName == null)
			{
				AdapterStatusBridge.cb_getClassName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AdapterStatusBridge.n_GetClassName));
			}
			return AdapterStatusBridge.cb_getClassName;
		}

		// Token: 0x060018B6 RID: 6326 RVA: 0x00047442 File Offset: 0x00045642
		private static IntPtr n_GetClassName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<AdapterStatusBridge>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ClassName);
		}

		// Token: 0x17000877 RID: 2167
		// (get) Token: 0x060018B7 RID: 6327 RVA: 0x00047458 File Offset: 0x00045658
		protected override string ClassName
		{
			[Register("getClassName", "()Ljava/lang/String;", "GetGetClassNameHandler")]
			get
			{
				return JNIEnv.GetString(AdapterStatusBridge._members.InstanceMethods.InvokeVirtualObjectMethod("getClassName.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060018B8 RID: 6328 RVA: 0x0004748A File Offset: 0x0004568A
		private static Delegate GetGetAdapterStatesEnumHandler()
		{
			if (AdapterStatusBridge.cb_getAdapterStatesEnum == null)
			{
				AdapterStatusBridge.cb_getAdapterStatesEnum = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AdapterStatusBridge.n_GetAdapterStatesEnum));
			}
			return AdapterStatusBridge.cb_getAdapterStatesEnum;
		}

		// Token: 0x060018B9 RID: 6329 RVA: 0x000474AE File Offset: 0x000456AE
		private static IntPtr n_GetAdapterStatesEnum(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray<Java.Lang.Object>(Java.Lang.Object.GetObject<AdapterStatusBridge>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetAdapterStatesEnum());
		}

		// Token: 0x060018BA RID: 6330 RVA: 0x000474C4 File Offset: 0x000456C4
		[Register("getAdapterStatesEnum", "()[Ljava/lang/Object;", "GetGetAdapterStatesEnumHandler")]
		public virtual Java.Lang.Object[] GetAdapterStatesEnum()
		{
			return (Java.Lang.Object[])JNIEnv.GetArray(AdapterStatusBridge._members.InstanceMethods.InvokeVirtualObjectMethod("getAdapterStatesEnum.()[Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef, typeof(Java.Lang.Object));
		}

		// Token: 0x060018BB RID: 6331 RVA: 0x00047505 File Offset: 0x00045705
		private static Delegate GetIsGMAInitialized_Ljava_lang_Object_Handler()
		{
			if (AdapterStatusBridge.cb_isGMAInitialized_Ljava_lang_Object_ == null)
			{
				AdapterStatusBridge.cb_isGMAInitialized_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(AdapterStatusBridge.n_IsGMAInitialized_Ljava_lang_Object_));
			}
			return AdapterStatusBridge.cb_isGMAInitialized_Ljava_lang_Object_;
		}

		// Token: 0x060018BC RID: 6332 RVA: 0x0004752C File Offset: 0x0004572C
		private static bool n_IsGMAInitialized_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_adapterState)
		{
			AdapterStatusBridge @object = Java.Lang.Object.GetObject<AdapterStatusBridge>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_adapterState, JniHandleOwnership.DoNotTransfer);
			return @object.IsGMAInitialized(object2);
		}

		// Token: 0x060018BD RID: 6333 RVA: 0x00047550 File Offset: 0x00045750
		[Register("isGMAInitialized", "(Ljava/lang/Object;)Z", "GetIsGMAInitialized_Ljava_lang_Object_Handler")]
		public unsafe virtual bool IsGMAInitialized(Java.Lang.Object adapterState)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((adapterState == null) ? IntPtr.Zero : adapterState.Handle);
				result = AdapterStatusBridge._members.InstanceMethods.InvokeVirtualBooleanMethod("isGMAInitialized.(Ljava/lang/Object;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(adapterState);
			}
			return result;
		}

		// Token: 0x04000601 RID: 1537
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/gmascar/bridges/AdapterStatusBridge", typeof(AdapterStatusBridge));

		// Token: 0x04000602 RID: 1538
		private static Delegate cb_getClassName;

		// Token: 0x04000603 RID: 1539
		private static Delegate cb_getAdapterStatesEnum;

		// Token: 0x04000604 RID: 1540
		private static Delegate cb_isGMAInitialized_Ljava_lang_Object_;
	}
}
