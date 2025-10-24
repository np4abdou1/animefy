using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Org.Json;

namespace Com.Applovin.Sdk
{
	// Token: 0x02000060 RID: 96
	[Register("com/applovin/sdk/AppLovinSdkUtils", DoNotGenerateAcw = true)]
	public class AppLovinSdkUtils : Java.Lang.Object
	{
		// Token: 0x1700010A RID: 266
		// (get) Token: 0x0600034B RID: 843 RVA: 0x000090E8 File Offset: 0x000072E8
		internal static IntPtr class_ref
		{
			get
			{
				return AppLovinSdkUtils._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x0600034C RID: 844 RVA: 0x0000910C File Offset: 0x0000730C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AppLovinSdkUtils._members;
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x0600034D RID: 845 RVA: 0x00009114 File Offset: 0x00007314
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AppLovinSdkUtils._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x0600034E RID: 846 RVA: 0x00009138 File Offset: 0x00007338
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AppLovinSdkUtils._members.ManagedPeerType;
			}
		}

		// Token: 0x0600034F RID: 847 RVA: 0x000021F0 File Offset: 0x000003F0
		protected AppLovinSdkUtils(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000350 RID: 848 RVA: 0x00009144 File Offset: 0x00007344
		[Register(".ctor", "()V", "")]
		public AppLovinSdkUtils() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(AppLovinSdkUtils._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			AppLovinSdkUtils._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000351 RID: 849 RVA: 0x000091B4 File Offset: 0x000073B4
		[Register("dpToPx", "(Landroid/content/Context;I)I", "")]
		public unsafe static int DpToPx(Context p0, int p1)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue(p1);
				result = AppLovinSdkUtils._members.StaticMethods.InvokeInt32Method("dpToPx.(Landroid/content/Context;I)I", ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return result;
		}

		// Token: 0x06000352 RID: 850 RVA: 0x0000922C File Offset: 0x0000742C
		[Register("isFireOS", "(Landroid/content/Context;)Z", "")]
		public unsafe static bool IsFireOS(Context p0)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				result = AppLovinSdkUtils._members.StaticMethods.InvokeBooleanMethod("isFireOS.(Landroid/content/Context;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return result;
		}

		// Token: 0x06000353 RID: 851 RVA: 0x00009290 File Offset: 0x00007490
		[Register("isFireTv", "(Landroid/content/Context;)Z", "")]
		public unsafe static bool IsFireTv(Context p0)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				result = AppLovinSdkUtils._members.StaticMethods.InvokeBooleanMethod("isFireTv.(Landroid/content/Context;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return result;
		}

		// Token: 0x06000354 RID: 852 RVA: 0x000092F4 File Offset: 0x000074F4
		[Register("isSdkVersionGreaterThanOrEqualTo", "(Ljava/lang/String;)Z", "")]
		public unsafe static bool IsSdkVersionGreaterThanOrEqualTo(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = AppLovinSdkUtils._members.StaticMethods.InvokeBooleanMethod("isSdkVersionGreaterThanOrEqualTo.(Ljava/lang/String;)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x06000355 RID: 853 RVA: 0x00009350 File Offset: 0x00007550
		[Register("isTablet", "(Landroid/content/Context;)Z", "")]
		public unsafe static bool IsTablet(Context p0)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				result = AppLovinSdkUtils._members.StaticMethods.InvokeBooleanMethod("isTablet.(Landroid/content/Context;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return result;
		}

		// Token: 0x06000356 RID: 854 RVA: 0x000093B4 File Offset: 0x000075B4
		[Register("isTv", "(Landroid/content/Context;)Z", "")]
		public unsafe static bool IsTv(Context p0)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				result = AppLovinSdkUtils._members.StaticMethods.InvokeBooleanMethod("isTv.(Landroid/content/Context;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return result;
		}

		// Token: 0x06000357 RID: 855 RVA: 0x00009418 File Offset: 0x00007618
		[Register("isValidString", "(Ljava/lang/String;)Z", "")]
		public unsafe static bool IsValidString(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = AppLovinSdkUtils._members.StaticMethods.InvokeBooleanMethod("isValidString.(Ljava/lang/String;)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x06000358 RID: 856 RVA: 0x00009474 File Offset: 0x00007674
		[Register("pxToDp", "(Landroid/content/Context;I)I", "")]
		public unsafe static int PxToDp(Context p0, int p1)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue(p1);
				result = AppLovinSdkUtils._members.StaticMethods.InvokeInt32Method("pxToDp.(Landroid/content/Context;I)I", ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return result;
		}

		// Token: 0x06000359 RID: 857 RVA: 0x000094EC File Offset: 0x000076EC
		[Register("runOnUiThread", "(ZLjava/lang/Runnable;)V", "")]
		public unsafe static void RunOnUiThread(bool p0, IRunnable p1)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(p0);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
				AppLovinSdkUtils._members.StaticMethods.InvokeVoidMethod("runOnUiThread.(ZLjava/lang/Runnable;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x0600035A RID: 858 RVA: 0x00009568 File Offset: 0x00007768
		[Register("runOnUiThread", "(Ljava/lang/Runnable;)V", "")]
		public unsafe static void RunOnUiThread(IRunnable p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				AppLovinSdkUtils._members.StaticMethods.InvokeVoidMethod("runOnUiThread.(Ljava/lang/Runnable;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x0600035B RID: 859 RVA: 0x000095D0 File Offset: 0x000077D0
		[Register("runOnUiThreadDelayed", "(Ljava/lang/Runnable;J)V", "")]
		public unsafe static void RunOnUiThreadDelayed(IRunnable p0, long p1)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				ptr[1] = new JniArgumentValue(p1);
				AppLovinSdkUtils._members.StaticMethods.InvokeVoidMethod("runOnUiThreadDelayed.(Ljava/lang/Runnable;J)V", ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x0600035C RID: 860 RVA: 0x0000964C File Offset: 0x0000784C
		[Register("runOnUiThreadDelayed", "(Ljava/lang/Runnable;JLandroid/os/Handler;)V", "")]
		public unsafe static void RunOnUiThreadDelayed(IRunnable p0, long p1, Handler p2)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				ptr[1] = new JniArgumentValue(p1);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : p2.Handle);
				AppLovinSdkUtils._members.StaticMethods.InvokeVoidMethod("runOnUiThreadDelayed.(Ljava/lang/Runnable;JLandroid/os/Handler;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p2);
			}
		}

		// Token: 0x0600035D RID: 861 RVA: 0x000096F4 File Offset: 0x000078F4
		[Register("toMap", "(Lorg/json/JSONObject;)Ljava/util/Map;", "")]
		public unsafe static IDictionary<string, string> ToMap(JSONObject p0)
		{
			IDictionary<string, string> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				result = JavaDictionary<string, string>.FromJniHandle(AppLovinSdkUtils._members.StaticMethods.InvokeObjectMethod("toMap.(Lorg/json/JSONObject;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return result;
		}

		// Token: 0x040000CB RID: 203
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/sdk/AppLovinSdkUtils", typeof(AppLovinSdkUtils));

		// Token: 0x02000061 RID: 97
		[Register("com/applovin/sdk/AppLovinSdkUtils$Size", DoNotGenerateAcw = true)]
		public sealed class Size : Java.Lang.Object
		{
			// Token: 0x1700010E RID: 270
			// (get) Token: 0x0600035F RID: 863 RVA: 0x00009784 File Offset: 0x00007984
			[Register("ZERO")]
			public static AppLovinSdkUtils.Size Zero
			{
				get
				{
					return Java.Lang.Object.GetObject<AppLovinSdkUtils.Size>(AppLovinSdkUtils.Size._members.StaticFields.GetObjectValue("ZERO.Lcom/applovin/sdk/AppLovinSdkUtils$Size;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x1700010F RID: 271
			// (get) Token: 0x06000360 RID: 864 RVA: 0x000097B4 File Offset: 0x000079B4
			internal static IntPtr class_ref
			{
				get
				{
					return AppLovinSdkUtils.Size._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000110 RID: 272
			// (get) Token: 0x06000361 RID: 865 RVA: 0x000097D8 File Offset: 0x000079D8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return AppLovinSdkUtils.Size._members;
				}
			}

			// Token: 0x17000111 RID: 273
			// (get) Token: 0x06000362 RID: 866 RVA: 0x000097E0 File Offset: 0x000079E0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return AppLovinSdkUtils.Size._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000112 RID: 274
			// (get) Token: 0x06000363 RID: 867 RVA: 0x00009804 File Offset: 0x00007A04
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return AppLovinSdkUtils.Size._members.ManagedPeerType;
				}
			}

			// Token: 0x06000364 RID: 868 RVA: 0x000021F0 File Offset: 0x000003F0
			internal Size(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06000365 RID: 869 RVA: 0x00009810 File Offset: 0x00007A10
			[Register(".ctor", "(II)V", "")]
			public unsafe Size(int p0, int p1) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(p0);
				ptr[1] = new JniArgumentValue(p1);
				base.SetHandle(AppLovinSdkUtils.Size._members.InstanceMethods.StartCreateInstance("(II)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				AppLovinSdkUtils.Size._members.InstanceMethods.FinishCreateInstance("(II)V", this, ptr);
			}

			// Token: 0x17000113 RID: 275
			// (get) Token: 0x06000366 RID: 870 RVA: 0x000098A7 File Offset: 0x00007AA7
			public int Height
			{
				[Register("getHeight", "()I", "")]
				get
				{
					return AppLovinSdkUtils.Size._members.InstanceMethods.InvokeAbstractInt32Method("getHeight.()I", this, null);
				}
			}

			// Token: 0x17000114 RID: 276
			// (get) Token: 0x06000367 RID: 871 RVA: 0x000098C0 File Offset: 0x00007AC0
			public int Width
			{
				[Register("getWidth", "()I", "")]
				get
				{
					return AppLovinSdkUtils.Size._members.InstanceMethods.InvokeAbstractInt32Method("getWidth.()I", this, null);
				}
			}

			// Token: 0x040000CC RID: 204
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/sdk/AppLovinSdkUtils$Size", typeof(AppLovinSdkUtils.Size));
		}
	}
}
