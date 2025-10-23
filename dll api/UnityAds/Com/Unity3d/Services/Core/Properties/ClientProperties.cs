using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.App;
using Android.Content;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Properties
{
	// Token: 0x020000CA RID: 202
	[Register("com/unity3d/services/core/properties/ClientProperties", DoNotGenerateAcw = true)]
	public class ClientProperties : Java.Lang.Object
	{
		// Token: 0x17000274 RID: 628
		// (get) Token: 0x060007DF RID: 2015 RVA: 0x00016930 File Offset: 0x00014B30
		internal static IntPtr class_ref
		{
			get
			{
				return ClientProperties._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x060007E0 RID: 2016 RVA: 0x00016954 File Offset: 0x00014B54
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ClientProperties._members;
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x060007E1 RID: 2017 RVA: 0x0001695C File Offset: 0x00014B5C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ClientProperties._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x060007E2 RID: 2018 RVA: 0x00016980 File Offset: 0x00014B80
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ClientProperties._members.ManagedPeerType;
			}
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x000021E8 File Offset: 0x000003E8
		protected ClientProperties(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x0001698C File Offset: 0x00014B8C
		[Register(".ctor", "()V", "")]
		public ClientProperties() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(ClientProperties._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			ClientProperties._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x060007E5 RID: 2021 RVA: 0x000169FC File Offset: 0x00014BFC
		// (set) Token: 0x060007E6 RID: 2022 RVA: 0x00016A30 File Offset: 0x00014C30
		public unsafe static Activity Activity
		{
			[Register("getActivity", "()Landroid/app/Activity;", "")]
			get
			{
				return Java.Lang.Object.GetObject<Activity>(ClientProperties._members.StaticMethods.InvokeObjectMethod("getActivity.()Landroid/app/Activity;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setActivity", "(Landroid/app/Activity;)V", "")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					ClientProperties._members.StaticMethods.InvokeVoidMethod("setActivity.(Landroid/app/Activity;)V", ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x060007E7 RID: 2023 RVA: 0x00016A94 File Offset: 0x00014C94
		public static string AppName
		{
			[Register("getAppName", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(ClientProperties._members.StaticMethods.InvokeObjectMethod("getAppName.()Ljava/lang/String;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x060007E8 RID: 2024 RVA: 0x00016AC8 File Offset: 0x00014CC8
		public static string AppVersion
		{
			[Register("getAppVersion", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(ClientProperties._members.StaticMethods.InvokeObjectMethod("getAppVersion.()Ljava/lang/String;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x060007E9 RID: 2025 RVA: 0x00016AFC File Offset: 0x00014CFC
		// (set) Token: 0x060007EA RID: 2026 RVA: 0x00016B30 File Offset: 0x00014D30
		public unsafe static Application Application
		{
			[Register("getApplication", "()Landroid/app/Application;", "")]
			get
			{
				return Java.Lang.Object.GetObject<Application>(ClientProperties._members.StaticMethods.InvokeObjectMethod("getApplication.()Landroid/app/Application;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setApplication", "(Landroid/app/Application;)V", "")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					ClientProperties._members.StaticMethods.InvokeVoidMethod("setApplication.(Landroid/app/Application;)V", ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x060007EB RID: 2027 RVA: 0x00016B94 File Offset: 0x00014D94
		// (set) Token: 0x060007EC RID: 2028 RVA: 0x00016BC8 File Offset: 0x00014DC8
		public unsafe static Context ApplicationContext
		{
			[Register("getApplicationContext", "()Landroid/content/Context;", "")]
			get
			{
				return Java.Lang.Object.GetObject<Context>(ClientProperties._members.StaticMethods.InvokeObjectMethod("getApplicationContext.()Landroid/content/Context;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setApplicationContext", "(Landroid/content/Context;)V", "")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					ClientProperties._members.StaticMethods.InvokeVoidMethod("setApplicationContext.(Landroid/content/Context;)V", ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x060007ED RID: 2029 RVA: 0x00016C2C File Offset: 0x00014E2C
		// (set) Token: 0x060007EE RID: 2030 RVA: 0x00016C60 File Offset: 0x00014E60
		public unsafe static string GameId
		{
			[Register("getGameId", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(ClientProperties._members.StaticMethods.InvokeObjectMethod("getGameId.()Ljava/lang/String;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setGameId", "(Ljava/lang/String;)V", "")]
			set
			{
				IntPtr intPtr = JNIEnv.NewString(value);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					ClientProperties._members.StaticMethods.InvokeVoidMethod("setGameId.(Ljava/lang/String;)V", ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x060007EF RID: 2031 RVA: 0x00016CBC File Offset: 0x00014EBC
		public static bool IsAppDebuggable
		{
			[Register("isAppDebuggable", "()Z", "")]
			get
			{
				return ClientProperties._members.StaticMethods.InvokeBooleanMethod("isAppDebuggable.()Z", null);
			}
		}

		// Token: 0x040001E6 RID: 486
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/properties/ClientProperties", typeof(ClientProperties));
	}
}
