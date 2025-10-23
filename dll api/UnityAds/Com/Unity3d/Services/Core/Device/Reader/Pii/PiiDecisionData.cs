using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Device.Reader.Pii
{
	// Token: 0x02000144 RID: 324
	[Register("com/unity3d/services/core/device/reader/pii/PiiDecisionData", DoNotGenerateAcw = true)]
	public class PiiDecisionData : Java.Lang.Object
	{
		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06000CE7 RID: 3303 RVA: 0x00024410 File Offset: 0x00022610
		internal static IntPtr class_ref
		{
			get
			{
				return PiiDecisionData._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06000CE8 RID: 3304 RVA: 0x00024434 File Offset: 0x00022634
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return PiiDecisionData._members;
			}
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06000CE9 RID: 3305 RVA: 0x0002443C File Offset: 0x0002263C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return PiiDecisionData._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06000CEA RID: 3306 RVA: 0x00024460 File Offset: 0x00022660
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return PiiDecisionData._members.ManagedPeerType;
			}
		}

		// Token: 0x06000CEB RID: 3307 RVA: 0x000021E8 File Offset: 0x000003E8
		protected PiiDecisionData(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000CEC RID: 3308 RVA: 0x0002446C File Offset: 0x0002266C
		[Register(".ctor", "(Lcom/unity3d/services/core/device/reader/pii/DataSelectorResult;)V", "")]
		public unsafe PiiDecisionData(DataSelectorResult resultType) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((resultType == null) ? IntPtr.Zero : resultType.Handle);
				base.SetHandle(PiiDecisionData._members.InstanceMethods.StartCreateInstance("(Lcom/unity3d/services/core/device/reader/pii/DataSelectorResult;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				PiiDecisionData._members.InstanceMethods.FinishCreateInstance("(Lcom/unity3d/services/core/device/reader/pii/DataSelectorResult;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(resultType);
			}
		}

		// Token: 0x06000CED RID: 3309 RVA: 0x0002451C File Offset: 0x0002271C
		[Register(".ctor", "(Lcom/unity3d/services/core/device/reader/pii/DataSelectorResult;Ljava/util/Map;)V", "")]
		public unsafe PiiDecisionData(DataSelectorResult resultType, IDictionary<string, Java.Lang.Object> attributes) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JavaDictionary<string, Java.Lang.Object>.ToLocalJniHandle(attributes);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((resultType == null) ? IntPtr.Zero : resultType.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				base.SetHandle(PiiDecisionData._members.InstanceMethods.StartCreateInstance("(Lcom/unity3d/services/core/device/reader/pii/DataSelectorResult;Ljava/util/Map;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				PiiDecisionData._members.InstanceMethods.FinishCreateInstance("(Lcom/unity3d/services/core/device/reader/pii/DataSelectorResult;Ljava/util/Map;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(resultType);
				GC.KeepAlive(attributes);
			}
		}

		// Token: 0x06000CEE RID: 3310 RVA: 0x000245F0 File Offset: 0x000227F0
		private static Delegate GetGetAttributesHandler()
		{
			if (PiiDecisionData.cb_getAttributes == null)
			{
				PiiDecisionData.cb_getAttributes = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(PiiDecisionData.n_GetAttributes));
			}
			return PiiDecisionData.cb_getAttributes;
		}

		// Token: 0x06000CEF RID: 3311 RVA: 0x00024614 File Offset: 0x00022814
		private static IntPtr n_GetAttributes(IntPtr jnienv, IntPtr native__this)
		{
			return JavaDictionary<string, Java.Lang.Object>.ToLocalJniHandle(Java.Lang.Object.GetObject<PiiDecisionData>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Attributes);
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06000CF0 RID: 3312 RVA: 0x00024628 File Offset: 0x00022828
		public virtual IDictionary<string, Java.Lang.Object> Attributes
		{
			[Register("getAttributes", "()Ljava/util/Map;", "GetGetAttributesHandler")]
			get
			{
				return JavaDictionary<string, Java.Lang.Object>.FromJniHandle(PiiDecisionData._members.InstanceMethods.InvokeVirtualObjectMethod("getAttributes.()Ljava/util/Map;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000CF1 RID: 3313 RVA: 0x0002465A File Offset: 0x0002285A
		private static Delegate GetGetResultTypeHandler()
		{
			if (PiiDecisionData.cb_getResultType == null)
			{
				PiiDecisionData.cb_getResultType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(PiiDecisionData.n_GetResultType));
			}
			return PiiDecisionData.cb_getResultType;
		}

		// Token: 0x06000CF2 RID: 3314 RVA: 0x0002467E File Offset: 0x0002287E
		private static IntPtr n_GetResultType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<PiiDecisionData>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ResultType);
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06000CF3 RID: 3315 RVA: 0x00024694 File Offset: 0x00022894
		public virtual DataSelectorResult ResultType
		{
			[Register("getResultType", "()Lcom/unity3d/services/core/device/reader/pii/DataSelectorResult;", "GetGetResultTypeHandler")]
			get
			{
				return Java.Lang.Object.GetObject<DataSelectorResult>(PiiDecisionData._members.InstanceMethods.InvokeVirtualObjectMethod("getResultType.()Lcom/unity3d/services/core/device/reader/pii/DataSelectorResult;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000CF4 RID: 3316 RVA: 0x000246C6 File Offset: 0x000228C6
		private static Delegate GetGetUserNonBehavioralFlagHandler()
		{
			if (PiiDecisionData.cb_getUserNonBehavioralFlag == null)
			{
				PiiDecisionData.cb_getUserNonBehavioralFlag = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(PiiDecisionData.n_GetUserNonBehavioralFlag));
			}
			return PiiDecisionData.cb_getUserNonBehavioralFlag;
		}

		// Token: 0x06000CF5 RID: 3317 RVA: 0x000246EA File Offset: 0x000228EA
		private static IntPtr n_GetUserNonBehavioralFlag(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<PiiDecisionData>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).UserNonBehavioralFlag);
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06000CF6 RID: 3318 RVA: 0x00024700 File Offset: 0x00022900
		public virtual Java.Lang.Boolean UserNonBehavioralFlag
		{
			[Register("getUserNonBehavioralFlag", "()Ljava/lang/Boolean;", "GetGetUserNonBehavioralFlagHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Java.Lang.Boolean>(PiiDecisionData._members.InstanceMethods.InvokeVirtualObjectMethod("getUserNonBehavioralFlag.()Ljava/lang/Boolean;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000CF7 RID: 3319 RVA: 0x00024732 File Offset: 0x00022932
		private static Delegate GetAppendData_Ljava_util_Map_Handler()
		{
			if (PiiDecisionData.cb_appendData_Ljava_util_Map_ == null)
			{
				PiiDecisionData.cb_appendData_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(PiiDecisionData.n_AppendData_Ljava_util_Map_));
			}
			return PiiDecisionData.cb_appendData_Ljava_util_Map_;
		}

		// Token: 0x06000CF8 RID: 3320 RVA: 0x00024758 File Offset: 0x00022958
		private static void n_AppendData_Ljava_util_Map_(IntPtr jnienv, IntPtr native__this, IntPtr native_appendedAttributes)
		{
			PiiDecisionData @object = Java.Lang.Object.GetObject<PiiDecisionData>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IDictionary<string, Java.Lang.Object> appendedAttributes = JavaDictionary<string, Java.Lang.Object>.FromJniHandle(native_appendedAttributes, JniHandleOwnership.DoNotTransfer);
			@object.AppendData(appendedAttributes);
		}

		// Token: 0x06000CF9 RID: 3321 RVA: 0x0002477C File Offset: 0x0002297C
		[Register("appendData", "(Ljava/util/Map;)V", "GetAppendData_Ljava_util_Map_Handler")]
		public unsafe virtual void AppendData(IDictionary<string, Java.Lang.Object> appendedAttributes)
		{
			IntPtr intPtr = JavaDictionary<string, Java.Lang.Object>.ToLocalJniHandle(appendedAttributes);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				PiiDecisionData._members.InstanceMethods.InvokeVirtualVoidMethod("appendData.(Ljava/util/Map;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(appendedAttributes);
			}
		}

		// Token: 0x040002FC RID: 764
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/device/reader/pii/PiiDecisionData", typeof(PiiDecisionData));

		// Token: 0x040002FD RID: 765
		private static Delegate cb_getAttributes;

		// Token: 0x040002FE RID: 766
		private static Delegate cb_getResultType;

		// Token: 0x040002FF RID: 767
		private static Delegate cb_getUserNonBehavioralFlag;

		// Token: 0x04000300 RID: 768
		private static Delegate cb_appendData_Ljava_util_Map_;
	}
}
