using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Sdk
{
	// Token: 0x0200008E RID: 142
	[Register("com/applovin/sdk/AppLovinSdkConfiguration$ConsentDialogState", DoNotGenerateAcw = true)]
	public sealed class AppLovinSdkConfigurationConsentDialogState : Java.Lang.Enum
	{
		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000499 RID: 1177 RVA: 0x0000C4D0 File Offset: 0x0000A6D0
		[Register("APPLIES")]
		public static AppLovinSdkConfigurationConsentDialogState Applies
		{
			get
			{
				return Java.Lang.Object.GetObject<AppLovinSdkConfigurationConsentDialogState>(AppLovinSdkConfigurationConsentDialogState._members.StaticFields.GetObjectValue("APPLIES.Lcom/applovin/sdk/AppLovinSdkConfiguration$ConsentDialogState;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x0600049A RID: 1178 RVA: 0x0000C500 File Offset: 0x0000A700
		[Register("DOES_NOT_APPLY")]
		public static AppLovinSdkConfigurationConsentDialogState DoesNotApply
		{
			get
			{
				return Java.Lang.Object.GetObject<AppLovinSdkConfigurationConsentDialogState>(AppLovinSdkConfigurationConsentDialogState._members.StaticFields.GetObjectValue("DOES_NOT_APPLY.Lcom/applovin/sdk/AppLovinSdkConfiguration$ConsentDialogState;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x0600049B RID: 1179 RVA: 0x0000C530 File Offset: 0x0000A730
		[Register("UNKNOWN")]
		public static AppLovinSdkConfigurationConsentDialogState Unknown
		{
			get
			{
				return Java.Lang.Object.GetObject<AppLovinSdkConfigurationConsentDialogState>(AppLovinSdkConfigurationConsentDialogState._members.StaticFields.GetObjectValue("UNKNOWN.Lcom/applovin/sdk/AppLovinSdkConfiguration$ConsentDialogState;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x0600049C RID: 1180 RVA: 0x0000C560 File Offset: 0x0000A760
		internal static IntPtr class_ref
		{
			get
			{
				return AppLovinSdkConfigurationConsentDialogState._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x0600049D RID: 1181 RVA: 0x0000C584 File Offset: 0x0000A784
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AppLovinSdkConfigurationConsentDialogState._members;
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x0600049E RID: 1182 RVA: 0x0000C58C File Offset: 0x0000A78C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AppLovinSdkConfigurationConsentDialogState._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x0600049F RID: 1183 RVA: 0x0000C5B0 File Offset: 0x0000A7B0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AppLovinSdkConfigurationConsentDialogState._members.ManagedPeerType;
			}
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x000048B4 File Offset: 0x00002AB4
		internal AppLovinSdkConfigurationConsentDialogState(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x0000C5BC File Offset: 0x0000A7BC
		[Register("valueOf", "(Ljava/lang/String;)Lcom/applovin/sdk/AppLovinSdkConfiguration$ConsentDialogState;", "")]
		public unsafe static AppLovinSdkConfigurationConsentDialogState ValueOf(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			AppLovinSdkConfigurationConsentDialogState @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<AppLovinSdkConfigurationConsentDialogState>(AppLovinSdkConfigurationConsentDialogState._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/applovin/sdk/AppLovinSdkConfiguration$ConsentDialogState;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x0000C628 File Offset: 0x0000A828
		[Register("values", "()[Lcom/applovin/sdk/AppLovinSdkConfiguration$ConsentDialogState;", "")]
		public static AppLovinSdkConfigurationConsentDialogState[] Values()
		{
			return (AppLovinSdkConfigurationConsentDialogState[])JNIEnv.GetArray(AppLovinSdkConfigurationConsentDialogState._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/applovin/sdk/AppLovinSdkConfiguration$ConsentDialogState;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(AppLovinSdkConfigurationConsentDialogState));
		}

		// Token: 0x04000154 RID: 340
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/sdk/AppLovinSdkConfiguration$ConsentDialogState", typeof(AppLovinSdkConfigurationConsentDialogState));
	}
}
