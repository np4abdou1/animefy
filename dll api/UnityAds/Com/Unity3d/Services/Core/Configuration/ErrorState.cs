using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Configuration
{
	// Token: 0x02000155 RID: 341
	[Register("com/unity3d/services/core/configuration/ErrorState", DoNotGenerateAcw = true)]
	public sealed class ErrorState : Java.Lang.Enum
	{
		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x06000E29 RID: 3625 RVA: 0x00027754 File Offset: 0x00025954
		[Register("CreateWebApp")]
		public static ErrorState CreateWebApp
		{
			get
			{
				return Java.Lang.Object.GetObject<ErrorState>(ErrorState._members.StaticFields.GetObjectValue("CreateWebApp.Lcom/unity3d/services/core/configuration/ErrorState;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x06000E2A RID: 3626 RVA: 0x00027784 File Offset: 0x00025984
		[Register("CreateWebview")]
		public static ErrorState CreateWebview
		{
			get
			{
				return Java.Lang.Object.GetObject<ErrorState>(ErrorState._members.StaticFields.GetObjectValue("CreateWebview.Lcom/unity3d/services/core/configuration/ErrorState;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x06000E2B RID: 3627 RVA: 0x000277B4 File Offset: 0x000259B4
		[Register("CreateWebviewConfigError")]
		public static ErrorState CreateWebviewConfigError
		{
			get
			{
				return Java.Lang.Object.GetObject<ErrorState>(ErrorState._members.StaticFields.GetObjectValue("CreateWebviewConfigError.Lcom/unity3d/services/core/configuration/ErrorState;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x06000E2C RID: 3628 RVA: 0x000277E4 File Offset: 0x000259E4
		[Register("CreateWebviewGameIdDisabled")]
		public static ErrorState CreateWebviewGameIdDisabled
		{
			get
			{
				return Java.Lang.Object.GetObject<ErrorState>(ErrorState._members.StaticFields.GetObjectValue("CreateWebviewGameIdDisabled.Lcom/unity3d/services/core/configuration/ErrorState;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x06000E2D RID: 3629 RVA: 0x00027814 File Offset: 0x00025A14
		[Register("CreateWebviewInvalidArgument")]
		public static ErrorState CreateWebviewInvalidArgument
		{
			get
			{
				return Java.Lang.Object.GetObject<ErrorState>(ErrorState._members.StaticFields.GetObjectValue("CreateWebviewInvalidArgument.Lcom/unity3d/services/core/configuration/ErrorState;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x06000E2E RID: 3630 RVA: 0x00027844 File Offset: 0x00025A44
		[Register("CreateWebviewTimeout")]
		public static ErrorState CreateWebviewTimeout
		{
			get
			{
				return Java.Lang.Object.GetObject<ErrorState>(ErrorState._members.StaticFields.GetObjectValue("CreateWebviewTimeout.Lcom/unity3d/services/core/configuration/ErrorState;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x06000E2F RID: 3631 RVA: 0x00027874 File Offset: 0x00025A74
		[Register("InitModules")]
		public static ErrorState InitModules
		{
			get
			{
				return Java.Lang.Object.GetObject<ErrorState>(ErrorState._members.StaticFields.GetObjectValue("InitModules.Lcom/unity3d/services/core/configuration/ErrorState;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x06000E30 RID: 3632 RVA: 0x000278A4 File Offset: 0x00025AA4
		[Register("InvalidHash")]
		public static ErrorState InvalidHash
		{
			get
			{
				return Java.Lang.Object.GetObject<ErrorState>(ErrorState._members.StaticFields.GetObjectValue("InvalidHash.Lcom/unity3d/services/core/configuration/ErrorState;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06000E31 RID: 3633 RVA: 0x000278D4 File Offset: 0x00025AD4
		[Register("LoadCache")]
		public static ErrorState LoadCache
		{
			get
			{
				return Java.Lang.Object.GetObject<ErrorState>(ErrorState._members.StaticFields.GetObjectValue("LoadCache.Lcom/unity3d/services/core/configuration/ErrorState;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x06000E32 RID: 3634 RVA: 0x00027904 File Offset: 0x00025B04
		[Register("MalformedWebviewRequest")]
		public static ErrorState MalformedWebviewRequest
		{
			get
			{
				return Java.Lang.Object.GetObject<ErrorState>(ErrorState._members.StaticFields.GetObjectValue("MalformedWebviewRequest.Lcom/unity3d/services/core/configuration/ErrorState;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x06000E33 RID: 3635 RVA: 0x00027934 File Offset: 0x00025B34
		[Register("NetworkConfigRequest")]
		public static ErrorState NetworkConfigRequest
		{
			get
			{
				return Java.Lang.Object.GetObject<ErrorState>(ErrorState._members.StaticFields.GetObjectValue("NetworkConfigRequest.Lcom/unity3d/services/core/configuration/ErrorState;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x06000E34 RID: 3636 RVA: 0x00027964 File Offset: 0x00025B64
		[Register("NetworkWebviewRequest")]
		public static ErrorState NetworkWebviewRequest
		{
			get
			{
				return Java.Lang.Object.GetObject<ErrorState>(ErrorState._members.StaticFields.GetObjectValue("NetworkWebviewRequest.Lcom/unity3d/services/core/configuration/ErrorState;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x06000E35 RID: 3637 RVA: 0x00027994 File Offset: 0x00025B94
		[Register("ResetWebApp")]
		public static ErrorState ResetWebApp
		{
			get
			{
				return Java.Lang.Object.GetObject<ErrorState>(ErrorState._members.StaticFields.GetObjectValue("ResetWebApp.Lcom/unity3d/services/core/configuration/ErrorState;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x06000E36 RID: 3638 RVA: 0x000279C4 File Offset: 0x00025BC4
		internal static IntPtr class_ref
		{
			get
			{
				return ErrorState._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x06000E37 RID: 3639 RVA: 0x000279E8 File Offset: 0x00025BE8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ErrorState._members;
			}
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x06000E38 RID: 3640 RVA: 0x000279F0 File Offset: 0x00025BF0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ErrorState._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x06000E39 RID: 3641 RVA: 0x00027A14 File Offset: 0x00025C14
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ErrorState._members.ManagedPeerType;
			}
		}

		// Token: 0x06000E3A RID: 3642 RVA: 0x0000256C File Offset: 0x0000076C
		internal ErrorState(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x06000E3B RID: 3643 RVA: 0x00027A20 File Offset: 0x00025C20
		public string MetricName
		{
			[Register("getMetricName", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(ErrorState._members.InstanceMethods.InvokeAbstractObjectMethod("getMetricName.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000E3C RID: 3644 RVA: 0x00027A54 File Offset: 0x00025C54
		[Register("valueOf", "(Ljava/lang/String;)Lcom/unity3d/services/core/configuration/ErrorState;", "")]
		public unsafe static ErrorState ValueOf(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			ErrorState @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<ErrorState>(ErrorState._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/unity3d/services/core/configuration/ErrorState;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06000E3D RID: 3645 RVA: 0x00027AC0 File Offset: 0x00025CC0
		[Register("values", "()[Lcom/unity3d/services/core/configuration/ErrorState;", "")]
		public static ErrorState[] Values()
		{
			return (ErrorState[])JNIEnv.GetArray(ErrorState._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/unity3d/services/core/configuration/ErrorState;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(ErrorState));
		}

		// Token: 0x0400034B RID: 843
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/configuration/ErrorState", typeof(ErrorState));
	}
}
