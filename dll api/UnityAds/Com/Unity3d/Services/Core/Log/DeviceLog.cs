using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Log
{
	// Token: 0x020000E7 RID: 231
	[Register("com/unity3d/services/core/log/DeviceLog", DoNotGenerateAcw = true)]
	public class DeviceLog : Java.Lang.Object
	{
		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x0600092D RID: 2349 RVA: 0x0001ACA8 File Offset: 0x00018EA8
		internal static IntPtr class_ref
		{
			get
			{
				return DeviceLog._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x0600092E RID: 2350 RVA: 0x0001ACCC File Offset: 0x00018ECC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DeviceLog._members;
			}
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x0600092F RID: 2351 RVA: 0x0001ACD4 File Offset: 0x00018ED4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DeviceLog._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06000930 RID: 2352 RVA: 0x0001ACF8 File Offset: 0x00018EF8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DeviceLog._members.ManagedPeerType;
			}
		}

		// Token: 0x06000931 RID: 2353 RVA: 0x000021E8 File Offset: 0x000003E8
		protected DeviceLog(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000932 RID: 2354 RVA: 0x0001AD04 File Offset: 0x00018F04
		[Register(".ctor", "()V", "")]
		public DeviceLog() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(DeviceLog._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			DeviceLog._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x0001AD74 File Offset: 0x00018F74
		[Register("debug", "(Ljava/lang/String;)V", "")]
		public unsafe static void Debug(string message)
		{
			IntPtr intPtr = JNIEnv.NewString(message);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				DeviceLog._members.StaticMethods.InvokeVoidMethod("debug.(Ljava/lang/String;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x06000934 RID: 2356 RVA: 0x0001ADD0 File Offset: 0x00018FD0
		[Register("debug", "(Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public unsafe static void Debug(string format, params Java.Lang.Object[] args)
		{
			IntPtr intPtr = JNIEnv.NewString(format);
			IntPtr intPtr2 = JNIEnv.NewArray<Java.Lang.Object>(args);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				DeviceLog._members.StaticMethods.InvokeVoidMethod("debug.(Ljava/lang/String;[Ljava/lang/Object;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				if (args != null)
				{
					JNIEnv.CopyArray<Java.Lang.Object>(intPtr2, args);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(args);
			}
		}

		// Token: 0x06000935 RID: 2357 RVA: 0x0001AE5C File Offset: 0x0001905C
		[Register("entered", "()V", "")]
		public static void Entered()
		{
			DeviceLog._members.StaticMethods.InvokeVoidMethod("entered.()V", null);
		}

		// Token: 0x06000936 RID: 2358 RVA: 0x0001AE74 File Offset: 0x00019074
		[Register("error", "(Ljava/lang/String;)V", "")]
		public unsafe static void Error(string message)
		{
			IntPtr intPtr = JNIEnv.NewString(message);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				DeviceLog._members.StaticMethods.InvokeVoidMethod("error.(Ljava/lang/String;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x06000937 RID: 2359 RVA: 0x0001AED0 File Offset: 0x000190D0
		[Register("error", "(Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public unsafe static void Error(string format, params Java.Lang.Object[] args)
		{
			IntPtr intPtr = JNIEnv.NewString(format);
			IntPtr intPtr2 = JNIEnv.NewArray<Java.Lang.Object>(args);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				DeviceLog._members.StaticMethods.InvokeVoidMethod("error.(Ljava/lang/String;[Ljava/lang/Object;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				if (args != null)
				{
					JNIEnv.CopyArray<Java.Lang.Object>(intPtr2, args);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(args);
			}
		}

		// Token: 0x06000938 RID: 2360 RVA: 0x0001AF5C File Offset: 0x0001915C
		[Register("exception", "(Ljava/lang/String;Ljava/lang/Exception;)V", "")]
		public unsafe static void Exception(string message, Java.Lang.Exception exception)
		{
			IntPtr intPtr = JNIEnv.NewString(message);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((exception == null) ? IntPtr.Zero : exception.Handle);
				DeviceLog._members.StaticMethods.InvokeVoidMethod("exception.(Ljava/lang/String;Ljava/lang/Exception;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(exception);
			}
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x0001AFE0 File Offset: 0x000191E0
		[Register("info", "(Ljava/lang/String;)V", "")]
		public unsafe static void Info(string message)
		{
			IntPtr intPtr = JNIEnv.NewString(message);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				DeviceLog._members.StaticMethods.InvokeVoidMethod("info.(Ljava/lang/String;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x0600093A RID: 2362 RVA: 0x0001B03C File Offset: 0x0001923C
		[Register("info", "(Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public unsafe static void Info(string format, params Java.Lang.Object[] args)
		{
			IntPtr intPtr = JNIEnv.NewString(format);
			IntPtr intPtr2 = JNIEnv.NewArray<Java.Lang.Object>(args);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				DeviceLog._members.StaticMethods.InvokeVoidMethod("info.(Ljava/lang/String;[Ljava/lang/Object;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				if (args != null)
				{
					JNIEnv.CopyArray<Java.Lang.Object>(intPtr2, args);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(args);
			}
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x0001B0C8 File Offset: 0x000192C8
		[Register("setLogLevel", "(I)V", "")]
		public unsafe static void SetLogLevel(int newLevel)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(newLevel);
			DeviceLog._members.StaticMethods.InvokeVoidMethod("setLogLevel.(I)V", ptr);
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x0001B104 File Offset: 0x00019304
		[Register("warning", "(Ljava/lang/String;)V", "")]
		public unsafe static void Warning(string message)
		{
			IntPtr intPtr = JNIEnv.NewString(message);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				DeviceLog._members.StaticMethods.InvokeVoidMethod("warning.(Ljava/lang/String;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x0001B160 File Offset: 0x00019360
		[Register("warning", "(Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public unsafe static void Warning(string format, params Java.Lang.Object[] args)
		{
			IntPtr intPtr = JNIEnv.NewString(format);
			IntPtr intPtr2 = JNIEnv.NewArray<Java.Lang.Object>(args);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				DeviceLog._members.StaticMethods.InvokeVoidMethod("warning.(Ljava/lang/String;[Ljava/lang/Object;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				if (args != null)
				{
					JNIEnv.CopyArray<Java.Lang.Object>(intPtr2, args);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(args);
			}
		}

		// Token: 0x04000229 RID: 553
		[Register("LOGLEVEL_DEBUG")]
		public const int LoglevelDebug = 8;

		// Token: 0x0400022A RID: 554
		[Register("LOGLEVEL_INFO")]
		public const int LoglevelInfo = 4;

		// Token: 0x0400022B RID: 555
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/log/DeviceLog", typeof(DeviceLog));

		// Token: 0x020000E8 RID: 232
		[Register("com/unity3d/services/core/log/DeviceLog$UnityAdsLogLevel", DoNotGenerateAcw = true)]
		public sealed class UnityAdsLogLevel : Java.Lang.Enum
		{
			// Token: 0x170002EB RID: 747
			// (get) Token: 0x0600093F RID: 2367 RVA: 0x0001B208 File Offset: 0x00019408
			[Register("DEBUG")]
			public static DeviceLog.UnityAdsLogLevel Debug
			{
				get
				{
					return Java.Lang.Object.GetObject<DeviceLog.UnityAdsLogLevel>(DeviceLog.UnityAdsLogLevel._members.StaticFields.GetObjectValue("DEBUG.Lcom/unity3d/services/core/log/DeviceLog$UnityAdsLogLevel;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x170002EC RID: 748
			// (get) Token: 0x06000940 RID: 2368 RVA: 0x0001B238 File Offset: 0x00019438
			[Register("ERROR")]
			public static DeviceLog.UnityAdsLogLevel Error
			{
				get
				{
					return Java.Lang.Object.GetObject<DeviceLog.UnityAdsLogLevel>(DeviceLog.UnityAdsLogLevel._members.StaticFields.GetObjectValue("ERROR.Lcom/unity3d/services/core/log/DeviceLog$UnityAdsLogLevel;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x170002ED RID: 749
			// (get) Token: 0x06000941 RID: 2369 RVA: 0x0001B268 File Offset: 0x00019468
			[Register("INFO")]
			public static DeviceLog.UnityAdsLogLevel Info
			{
				get
				{
					return Java.Lang.Object.GetObject<DeviceLog.UnityAdsLogLevel>(DeviceLog.UnityAdsLogLevel._members.StaticFields.GetObjectValue("INFO.Lcom/unity3d/services/core/log/DeviceLog$UnityAdsLogLevel;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x170002EE RID: 750
			// (get) Token: 0x06000942 RID: 2370 RVA: 0x0001B298 File Offset: 0x00019498
			[Register("WARNING")]
			public static DeviceLog.UnityAdsLogLevel Warning
			{
				get
				{
					return Java.Lang.Object.GetObject<DeviceLog.UnityAdsLogLevel>(DeviceLog.UnityAdsLogLevel._members.StaticFields.GetObjectValue("WARNING.Lcom/unity3d/services/core/log/DeviceLog$UnityAdsLogLevel;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x170002EF RID: 751
			// (get) Token: 0x06000943 RID: 2371 RVA: 0x0001B2C8 File Offset: 0x000194C8
			internal static IntPtr class_ref
			{
				get
				{
					return DeviceLog.UnityAdsLogLevel._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170002F0 RID: 752
			// (get) Token: 0x06000944 RID: 2372 RVA: 0x0001B2EC File Offset: 0x000194EC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return DeviceLog.UnityAdsLogLevel._members;
				}
			}

			// Token: 0x170002F1 RID: 753
			// (get) Token: 0x06000945 RID: 2373 RVA: 0x0001B2F4 File Offset: 0x000194F4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return DeviceLog.UnityAdsLogLevel._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170002F2 RID: 754
			// (get) Token: 0x06000946 RID: 2374 RVA: 0x0001B318 File Offset: 0x00019518
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return DeviceLog.UnityAdsLogLevel._members.ManagedPeerType;
				}
			}

			// Token: 0x06000947 RID: 2375 RVA: 0x0000256C File Offset: 0x0000076C
			internal UnityAdsLogLevel(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06000948 RID: 2376 RVA: 0x0001B324 File Offset: 0x00019524
			[Register("valueOf", "(Ljava/lang/String;)Lcom/unity3d/services/core/log/DeviceLog$UnityAdsLogLevel;", "")]
			public unsafe static DeviceLog.UnityAdsLogLevel ValueOf(string name)
			{
				IntPtr intPtr = JNIEnv.NewString(name);
				DeviceLog.UnityAdsLogLevel @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<DeviceLog.UnityAdsLogLevel>(DeviceLog.UnityAdsLogLevel._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/unity3d/services/core/log/DeviceLog$UnityAdsLogLevel;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x06000949 RID: 2377 RVA: 0x0001B390 File Offset: 0x00019590
			[Register("values", "()[Lcom/unity3d/services/core/log/DeviceLog$UnityAdsLogLevel;", "")]
			public static DeviceLog.UnityAdsLogLevel[] Values()
			{
				return (DeviceLog.UnityAdsLogLevel[])JNIEnv.GetArray(DeviceLog.UnityAdsLogLevel._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/unity3d/services/core/log/DeviceLog$UnityAdsLogLevel;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(DeviceLog.UnityAdsLogLevel));
			}

			// Token: 0x0400022C RID: 556
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/log/DeviceLog$UnityAdsLogLevel", typeof(DeviceLog.UnityAdsLogLevel));
		}
	}
}
