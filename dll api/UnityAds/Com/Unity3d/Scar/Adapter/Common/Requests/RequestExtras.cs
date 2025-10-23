using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Scar.Adapter.Common.Requests
{
	// Token: 0x020002C1 RID: 705
	[Register("com/unity3d/scar/adapter/common/requests/RequestExtras", DoNotGenerateAcw = true)]
	public class RequestExtras : Java.Lang.Object
	{
		// Token: 0x17000F0A RID: 3850
		// (get) Token: 0x060027C5 RID: 10181 RVA: 0x00066BC4 File Offset: 0x00064DC4
		// (set) Token: 0x060027C6 RID: 10182 RVA: 0x00066BF4 File Offset: 0x00064DF4
		[Register("QUERY_INFO_TYPE")]
		public static string QueryInfoType
		{
			get
			{
				return JNIEnv.GetString(RequestExtras._members.StaticFields.GetObjectValue("QUERY_INFO_TYPE.Ljava/lang/String;").Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.NewString(value);
				try
				{
					RequestExtras._members.StaticFields.SetValue("QUERY_INFO_TYPE.Ljava/lang/String;", new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x17000F0B RID: 3851
		// (get) Token: 0x060027C7 RID: 10183 RVA: 0x00066C3C File Offset: 0x00064E3C
		// (set) Token: 0x060027C8 RID: 10184 RVA: 0x00066C6C File Offset: 0x00064E6C
		[Register("REQUESTER_TYPE")]
		public static string RequesterType
		{
			get
			{
				return JNIEnv.GetString(RequestExtras._members.StaticFields.GetObjectValue("REQUESTER_TYPE.Ljava/lang/String;").Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.NewString(value);
				try
				{
					RequestExtras._members.StaticFields.SetValue("REQUESTER_TYPE.Ljava/lang/String;", new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x17000F0C RID: 3852
		// (get) Token: 0x060027C9 RID: 10185 RVA: 0x00066CB4 File Offset: 0x00064EB4
		// (set) Token: 0x060027CA RID: 10186 RVA: 0x00066CE4 File Offset: 0x00064EE4
		[Register("VERSION_PREFIX")]
		public static string VersionPrefix
		{
			get
			{
				return JNIEnv.GetString(RequestExtras._members.StaticFields.GetObjectValue("VERSION_PREFIX.Ljava/lang/String;").Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.NewString(value);
				try
				{
					RequestExtras._members.StaticFields.SetValue("VERSION_PREFIX.Ljava/lang/String;", new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x17000F0D RID: 3853
		// (get) Token: 0x060027CB RID: 10187 RVA: 0x00066D2C File Offset: 0x00064F2C
		internal static IntPtr class_ref
		{
			get
			{
				return RequestExtras._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000F0E RID: 3854
		// (get) Token: 0x060027CC RID: 10188 RVA: 0x00066D50 File Offset: 0x00064F50
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return RequestExtras._members;
			}
		}

		// Token: 0x17000F0F RID: 3855
		// (get) Token: 0x060027CD RID: 10189 RVA: 0x00066D58 File Offset: 0x00064F58
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return RequestExtras._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000F10 RID: 3856
		// (get) Token: 0x060027CE RID: 10190 RVA: 0x00066D7C File Offset: 0x00064F7C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return RequestExtras._members.ManagedPeerType;
			}
		}

		// Token: 0x060027CF RID: 10191 RVA: 0x000021E8 File Offset: 0x000003E8
		protected RequestExtras(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060027D0 RID: 10192 RVA: 0x00066D88 File Offset: 0x00064F88
		[Register(".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe RequestExtras(string unityVersion) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(unityVersion);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				base.SetHandle(RequestExtras._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				RequestExtras._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x060027D1 RID: 10193 RVA: 0x00066E2C File Offset: 0x0006502C
		private static Delegate GetGetExtrasHandler()
		{
			if (RequestExtras.cb_getExtras == null)
			{
				RequestExtras.cb_getExtras = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(RequestExtras.n_GetExtras));
			}
			return RequestExtras.cb_getExtras;
		}

		// Token: 0x060027D2 RID: 10194 RVA: 0x00066E50 File Offset: 0x00065050
		private static IntPtr n_GetExtras(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<RequestExtras>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Extras);
		}

		// Token: 0x17000F11 RID: 3857
		// (get) Token: 0x060027D3 RID: 10195 RVA: 0x00066E64 File Offset: 0x00065064
		public virtual Bundle Extras
		{
			[Register("getExtras", "()Landroid/os/Bundle;", "GetGetExtrasHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Bundle>(RequestExtras._members.InstanceMethods.InvokeVirtualObjectMethod("getExtras.()Landroid/os/Bundle;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060027D4 RID: 10196 RVA: 0x00066E96 File Offset: 0x00065096
		private static Delegate GetGetVersionNameHandler()
		{
			if (RequestExtras.cb_getVersionName == null)
			{
				RequestExtras.cb_getVersionName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(RequestExtras.n_GetVersionName));
			}
			return RequestExtras.cb_getVersionName;
		}

		// Token: 0x060027D5 RID: 10197 RVA: 0x00066EBA File Offset: 0x000650BA
		private static IntPtr n_GetVersionName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<RequestExtras>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).VersionName);
		}

		// Token: 0x17000F12 RID: 3858
		// (get) Token: 0x060027D6 RID: 10198 RVA: 0x00066ED0 File Offset: 0x000650D0
		public virtual string VersionName
		{
			[Register("getVersionName", "()Ljava/lang/String;", "GetGetVersionNameHandler")]
			get
			{
				return JNIEnv.GetString(RequestExtras._members.InstanceMethods.InvokeVirtualObjectMethod("getVersionName.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x040007FB RID: 2043
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/common/requests/RequestExtras", typeof(RequestExtras));

		// Token: 0x040007FC RID: 2044
		private static Delegate cb_getExtras;

		// Token: 0x040007FD RID: 2045
		private static Delegate cb_getVersionName;
	}
}
