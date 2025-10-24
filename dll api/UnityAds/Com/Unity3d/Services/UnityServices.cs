using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Com.Unity3d.Ads;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services
{
	// Token: 0x02000033 RID: 51
	[Register("com/unity3d/services/UnityServices", DoNotGenerateAcw = true)]
	public class UnityServices : Java.Lang.Object
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x00002248 File Offset: 0x00000448
		internal static IntPtr class_ref
		{
			get
			{
				return UnityServices._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x0000226C File Offset: 0x0000046C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return UnityServices._members;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x00002274 File Offset: 0x00000474
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return UnityServices._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x00002298 File Offset: 0x00000498
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return UnityServices._members.ManagedPeerType;
			}
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x000021E8 File Offset: 0x000003E8
		protected UnityServices(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x000022A4 File Offset: 0x000004A4
		[Register(".ctor", "()V", "")]
		public UnityServices() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(UnityServices._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			UnityServices._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x00002312 File Offset: 0x00000512
		// (set) Token: 0x060000C7 RID: 199 RVA: 0x0000232C File Offset: 0x0000052C
		public unsafe static bool DebugMode
		{
			[Register("getDebugMode", "()Z", "")]
			get
			{
				return UnityServices._members.StaticMethods.InvokeBooleanMethod("getDebugMode.()Z", null);
			}
			[Register("setDebugMode", "(Z)V", "")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				UnityServices._members.StaticMethods.InvokeVoidMethod("setDebugMode.(Z)V", ptr);
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x00002366 File Offset: 0x00000566
		public static bool IsInitialized
		{
			[Register("isInitialized", "()Z", "")]
			get
			{
				return UnityServices._members.StaticMethods.InvokeBooleanMethod("isInitialized.()Z", null);
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x0000237E File Offset: 0x0000057E
		public static bool IsSupported
		{
			[Register("isSupported", "()Z", "")]
			get
			{
				return UnityServices._members.StaticMethods.InvokeBooleanMethod("isSupported.()Z", null);
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x060000CA RID: 202 RVA: 0x00002398 File Offset: 0x00000598
		public static string Version
		{
			[Register("getVersion", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(UnityServices._members.StaticMethods.InvokeObjectMethod("getVersion.()Ljava/lang/String;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060000CB RID: 203 RVA: 0x000023CC File Offset: 0x000005CC
		[Register("initialize", "(Landroid/content/Context;Ljava/lang/String;ZLcom/unity3d/ads/IUnityAdsInitializationListener;)V", "")]
		public unsafe static void Initialize(Context context, string gameId, bool testMode, IUnityAdsInitializationListener initializationListener)
		{
			IntPtr intPtr = JNIEnv.NewString(gameId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue(testMode);
				ptr[3] = new JniArgumentValue((initializationListener == null) ? IntPtr.Zero : ((Java.Lang.Object)initializationListener).Handle);
				UnityServices._members.StaticMethods.InvokeVoidMethod("initialize.(Landroid/content/Context;Ljava/lang/String;ZLcom/unity3d/ads/IUnityAdsInitializationListener;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(context);
				GC.KeepAlive(initializationListener);
			}
		}

		// Token: 0x04000006 RID: 6
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/UnityServices", typeof(UnityServices));

		// Token: 0x02000034 RID: 52
		[Register("com/unity3d/services/UnityServices$UnityServicesError", DoNotGenerateAcw = true)]
		public sealed class UnityServicesError : Java.Lang.Enum
		{
			// Token: 0x17000010 RID: 16
			// (get) Token: 0x060000CD RID: 205 RVA: 0x000024B0 File Offset: 0x000006B0
			[Register("INIT_SANITY_CHECK_FAIL")]
			public static UnityServices.UnityServicesError InitSanityCheckFail
			{
				get
				{
					return Java.Lang.Object.GetObject<UnityServices.UnityServicesError>(UnityServices.UnityServicesError._members.StaticFields.GetObjectValue("INIT_SANITY_CHECK_FAIL.Lcom/unity3d/services/UnityServices$UnityServicesError;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000011 RID: 17
			// (get) Token: 0x060000CE RID: 206 RVA: 0x000024E0 File Offset: 0x000006E0
			[Register("INVALID_ARGUMENT")]
			public static UnityServices.UnityServicesError InvalidArgument
			{
				get
				{
					return Java.Lang.Object.GetObject<UnityServices.UnityServicesError>(UnityServices.UnityServicesError._members.StaticFields.GetObjectValue("INVALID_ARGUMENT.Lcom/unity3d/services/UnityServices$UnityServicesError;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000012 RID: 18
			// (get) Token: 0x060000CF RID: 207 RVA: 0x00002510 File Offset: 0x00000710
			internal static IntPtr class_ref
			{
				get
				{
					return UnityServices.UnityServicesError._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000013 RID: 19
			// (get) Token: 0x060000D0 RID: 208 RVA: 0x00002534 File Offset: 0x00000734
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return UnityServices.UnityServicesError._members;
				}
			}

			// Token: 0x17000014 RID: 20
			// (get) Token: 0x060000D1 RID: 209 RVA: 0x0000253C File Offset: 0x0000073C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return UnityServices.UnityServicesError._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000015 RID: 21
			// (get) Token: 0x060000D2 RID: 210 RVA: 0x00002560 File Offset: 0x00000760
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return UnityServices.UnityServicesError._members.ManagedPeerType;
				}
			}

			// Token: 0x060000D3 RID: 211 RVA: 0x0000256C File Offset: 0x0000076C
			internal UnityServicesError(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x060000D4 RID: 212 RVA: 0x00002578 File Offset: 0x00000778
			[Register("valueOf", "(Ljava/lang/String;)Lcom/unity3d/services/UnityServices$UnityServicesError;", "")]
			public unsafe static UnityServices.UnityServicesError ValueOf(string name)
			{
				IntPtr intPtr = JNIEnv.NewString(name);
				UnityServices.UnityServicesError @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<UnityServices.UnityServicesError>(UnityServices.UnityServicesError._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/unity3d/services/UnityServices$UnityServicesError;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x060000D5 RID: 213 RVA: 0x000025E4 File Offset: 0x000007E4
			[Register("values", "()[Lcom/unity3d/services/UnityServices$UnityServicesError;", "")]
			public static UnityServices.UnityServicesError[] Values()
			{
				return (UnityServices.UnityServicesError[])JNIEnv.GetArray(UnityServices.UnityServicesError._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/unity3d/services/UnityServices$UnityServicesError;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(UnityServices.UnityServicesError));
			}

			// Token: 0x04000007 RID: 7
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/UnityServices$UnityServicesError", typeof(UnityServices.UnityServicesError));
		}
	}
}
