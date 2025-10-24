using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.App;
using Android.Content;
using Android.Net;
using Android.Runtime;
using Android.Views;
using Android.Webkit;
using Com.Applovin.Mediation;
using Com.Applovin.Sdk;
using Java.Interop;
using Java.Lang;
using Java.Lang.Reflect;
using Org.Json;

namespace Com.Applovin.Impl.Sdk.Utils
{
	// Token: 0x0200013C RID: 316
	[Register("com/applovin/impl/sdk/utils/Utils", DoNotGenerateAcw = true)]
	public abstract class Utils : Java.Lang.Object
	{
		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06000EE2 RID: 3810 RVA: 0x0002B50C File Offset: 0x0002970C
		// (set) Token: 0x06000EE3 RID: 3811 RVA: 0x0002B53C File Offset: 0x0002973C
		[Register("isExoPlayerEligible")]
		public static Java.Lang.Boolean IsExoPlayerEligible
		{
			get
			{
				return Java.Lang.Object.GetObject<Java.Lang.Boolean>(Utils._members.StaticFields.GetObjectValue("isExoPlayerEligible.Ljava/lang/Boolean;").Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
				try
				{
					Utils._members.StaticFields.SetValue("isExoPlayerEligible.Ljava/lang/Boolean;", new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06000EE4 RID: 3812 RVA: 0x0002B584 File Offset: 0x00029784
		internal static IntPtr class_ref
		{
			get
			{
				return Utils._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06000EE5 RID: 3813 RVA: 0x0002B5A8 File Offset: 0x000297A8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Utils._members;
			}
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06000EE6 RID: 3814 RVA: 0x0002B5B0 File Offset: 0x000297B0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Utils._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06000EE7 RID: 3815 RVA: 0x0002B5D4 File Offset: 0x000297D4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Utils._members.ManagedPeerType;
			}
		}

		// Token: 0x06000EE8 RID: 3816 RVA: 0x000021F0 File Offset: 0x000003F0
		protected Utils(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000EE9 RID: 3817 RVA: 0x0002B5E0 File Offset: 0x000297E0
		[Register(".ctor", "()V", "")]
		public Utils() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(Utils._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			Utils._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06000EEA RID: 3818 RVA: 0x0002B650 File Offset: 0x00029850
		public static string AndroidOSInfo
		{
			[Register("getAndroidOSInfo", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(Utils._members.StaticMethods.InvokeObjectMethod("getAndroidOSInfo.()Ljava/lang/String;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06000EEB RID: 3819 RVA: 0x0002B684 File Offset: 0x00029884
		public static string AndroidSdkCodename
		{
			[Register("getAndroidSdkCodename", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(Utils._members.StaticMethods.InvokeObjectMethod("getAndroidSdkCodename.()Ljava/lang/String;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06000EEC RID: 3820 RVA: 0x0002B6B5 File Offset: 0x000298B5
		public static bool IsCurrentProcessInForeground
		{
			[Register("isCurrentProcessInForeground", "()Z", "")]
			get
			{
				return Utils._members.StaticMethods.InvokeBooleanMethod("isCurrentProcessInForeground.()Z", null);
			}
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06000EED RID: 3821 RVA: 0x0002B6CD File Offset: 0x000298CD
		public static bool IsMainThread
		{
			[Register("isMainThread", "()Z", "")]
			get
			{
				return Utils._members.StaticMethods.InvokeBooleanMethod("isMainThread.()Z", null);
			}
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06000EEE RID: 3822 RVA: 0x0002B6E5 File Offset: 0x000298E5
		public static bool IsProguardRulesOmitted
		{
			[Register("isProguardRulesOmitted", "()Z", "")]
			get
			{
				return Utils._members.StaticMethods.InvokeBooleanMethod("isProguardRulesOmitted.()Z", null);
			}
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06000EEF RID: 3823 RVA: 0x0002B6FD File Offset: 0x000298FD
		public static bool IsVPNConnected
		{
			[Register("isVPNConnected", "()Z", "")]
			get
			{
				return Utils._members.StaticMethods.InvokeBooleanMethod("isVPNConnected.()Z", null);
			}
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06000EF0 RID: 3824 RVA: 0x0002B715 File Offset: 0x00029915
		public static bool IsVerboseLoggingConfigured
		{
			[Register("isVerboseLoggingConfigured", "()Z", "")]
			get
			{
				return Utils._members.StaticMethods.InvokeBooleanMethod("isVerboseLoggingConfigured.()Z", null);
			}
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06000EF1 RID: 3825 RVA: 0x0002B730 File Offset: 0x00029930
		public static string UserEngagementSdkVersion
		{
			[Register("getUserEngagementSdkVersion", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(Utils._members.StaticMethods.InvokeObjectMethod("getUserEngagementSdkVersion.()Ljava/lang/String;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000EF2 RID: 3826 RVA: 0x0002B764 File Offset: 0x00029964
		[Register("bitMaskContainsFlag", "(JJ)Z", "")]
		public unsafe static bool BitMaskContainsFlag(long p0, long p1)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(p0);
			ptr[1] = new JniArgumentValue(p1);
			return Utils._members.StaticMethods.InvokeBooleanMethod("bitMaskContainsFlag.(JJ)Z", ptr);
		}

		// Token: 0x06000EF3 RID: 3827 RVA: 0x0002B7B4 File Offset: 0x000299B4
		[Register("checkClassExistence", "(Ljava/lang/String;)Z", "")]
		public unsafe static bool CheckClassExistence(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = Utils._members.StaticMethods.InvokeBooleanMethod("checkClassExistence.(Ljava/lang/String;)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x06000EF4 RID: 3828 RVA: 0x0002B810 File Offset: 0x00029A10
		[Register("checkClassesExistence", "(Ljava/util/List;)Z", "")]
		public unsafe static bool CheckClassesExistence(IList<string> p0)
		{
			IntPtr intPtr = JavaList<string>.ToLocalJniHandle(p0);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = Utils._members.StaticMethods.InvokeBooleanMethod("checkClassesExistence.(Ljava/util/List;)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
			}
			return result;
		}

		// Token: 0x06000EF5 RID: 3829 RVA: 0x0002B874 File Offset: 0x00029A74
		[Register("compare", "(Ljava/lang/String;Ljava/lang/String;)I", "")]
		public unsafe static int Compare(string p0, string p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			IntPtr intPtr2 = JNIEnv.NewString(p1);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				result = Utils._members.StaticMethods.InvokeInt32Method("compare.(Ljava/lang/String;Ljava/lang/String;)I", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
			return result;
		}

		// Token: 0x06000EF6 RID: 3830 RVA: 0x0002B8F0 File Offset: 0x00029AF0
		[Register("encodeUrlMap", "(Ljava/util/Map;Z)Ljava/lang/String;", "")]
		public unsafe static string EncodeUrlMap(IDictionary<string, string> p0, bool p1)
		{
			IntPtr intPtr = JavaDictionary<string, string>.ToLocalJniHandle(p0);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(p1);
				@string = JNIEnv.GetString(Utils._members.StaticMethods.InvokeObjectMethod("encodeUrlMap.(Ljava/util/Map;Z)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
			}
			return @string;
		}

		// Token: 0x06000EF7 RID: 3831 RVA: 0x0002B974 File Offset: 0x00029B74
		[Register("formatDoubleValue", "(DI)Ljava/lang/String;", "")]
		public unsafe static string FormatDoubleValue(double p0, int p1)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(p0);
			ptr[1] = new JniArgumentValue(p1);
			return JNIEnv.GetString(Utils._members.StaticMethods.InvokeObjectMethod("formatDoubleValue.(DI)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000EF8 RID: 3832 RVA: 0x0002B9D0 File Offset: 0x00029BD0
		[Register("getAlwaysFinishActivitiesSetting", "(Landroid/content/Context;)I", "")]
		public unsafe static int GetAlwaysFinishActivitiesSetting(Context p0)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				result = Utils._members.StaticMethods.InvokeInt32Method("getAlwaysFinishActivitiesSetting.(Landroid/content/Context;)I", ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return result;
		}

		// Token: 0x06000EF9 RID: 3833 RVA: 0x0002BA34 File Offset: 0x00029C34
		[Register("getBooleanForProbability", "(I)Z", "")]
		public unsafe static bool GetBooleanForProbability(int p0)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(p0);
			return Utils._members.StaticMethods.InvokeBooleanMethod("getBooleanForProbability.(I)Z", ptr);
		}

		// Token: 0x06000EFA RID: 3834 RVA: 0x0002BA70 File Offset: 0x00029C70
		[Register("getCurrentAdServeId", "(Ljava/lang/Object;)Ljava/lang/String;", "")]
		public unsafe static string GetCurrentAdServeId(Java.Lang.Object p0)
		{
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				@string = JNIEnv.GetString(Utils._members.StaticMethods.InvokeObjectMethod("getCurrentAdServeId.(Ljava/lang/Object;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return @string;
		}

		// Token: 0x06000EFB RID: 3835 RVA: 0x0002BAE4 File Offset: 0x00029CE4
		[Register("getField", "(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/reflect/Field;", "")]
		public unsafe static Field GetField(Class p0, string p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p1);
			Field @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Field>(Utils._members.StaticMethods.InvokeObjectMethod("getField.(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/reflect/Field;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
			}
			return @object;
		}

		// Token: 0x06000EFC RID: 3836 RVA: 0x0002BB78 File Offset: 0x00029D78
		[Register("getFileName", "(Landroid/net/Uri;)Ljava/lang/String;", "")]
		public unsafe static string GetFileName(Android.Net.Uri p0)
		{
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				@string = JNIEnv.GetString(Utils._members.StaticMethods.InvokeObjectMethod("getFileName.(Landroid/net/Uri;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return @string;
		}

		// Token: 0x06000EFD RID: 3837 RVA: 0x0002BBEC File Offset: 0x00029DEC
		[Register("getMetaData", "(Lcom/applovin/sdk/AppLovinSdkSettings;)Ljava/util/Map;", "")]
		public unsafe static IDictionary<string, string> GetMetaData(AppLovinSdkSettings p0)
		{
			IDictionary<string, string> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				result = JavaDictionary<string, string>.FromJniHandle(Utils._members.StaticMethods.InvokeObjectMethod("getMetaData.(Lcom/applovin/sdk/AppLovinSdkSettings;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return result;
		}

		// Token: 0x06000EFE RID: 3838 RVA: 0x0002BC60 File Offset: 0x00029E60
		[Register("getOrientation", "(Landroid/content/Context;)I", "")]
		public unsafe static int GetOrientation(Context p0)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				result = Utils._members.StaticMethods.InvokeInt32Method("getOrientation.(Landroid/content/Context;)I", ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return result;
		}

		// Token: 0x06000EFF RID: 3839 RVA: 0x0002BCC4 File Offset: 0x00029EC4
		[Register("getRootView", "(Landroid/view/View;)Landroid/view/View;", "")]
		public unsafe static View GetRootView(View p0)
		{
			View @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				@object = Java.Lang.Object.GetObject<View>(Utils._members.StaticMethods.InvokeObjectMethod("getRootView.(Landroid/view/View;)Landroid/view/View;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return @object;
		}

		// Token: 0x06000F00 RID: 3840 RVA: 0x0002BD38 File Offset: 0x00029F38
		[Register("getRotation", "(Landroid/content/Context;)I", "")]
		public unsafe static int GetRotation(Context p0)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				result = Utils._members.StaticMethods.InvokeInt32Method("getRotation.(Landroid/content/Context;)I", ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return result;
		}

		// Token: 0x06000F01 RID: 3841 RVA: 0x0002BD9C File Offset: 0x00029F9C
		[Register("getString", "(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe static string GetString(Class p0, string p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p1);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				@string = JNIEnv.GetString(Utils._members.StaticMethods.InvokeObjectMethod("getString.(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
			}
			return @string;
		}

		// Token: 0x06000F02 RID: 3842 RVA: 0x0002BE30 File Offset: 0x0002A030
		[Register("getVideoCompletionPercent", "(Lorg/json/JSONObject;)I", "")]
		public unsafe static int GetVideoCompletionPercent(JSONObject p0)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				result = Utils._members.StaticMethods.InvokeInt32Method("getVideoCompletionPercent.(Lorg/json/JSONObject;)I", ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return result;
		}

		// Token: 0x06000F03 RID: 3843 RVA: 0x0002BE94 File Offset: 0x0002A094
		[Register("gzip", "([B)[B", "")]
		public unsafe static byte[] Gzip(byte[] p0)
		{
			IntPtr intPtr = JNIEnv.NewArray(p0);
			byte[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = (byte[])JNIEnv.GetArray(Utils._members.StaticMethods.InvokeObjectMethod("gzip.([B)[B", ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(byte));
			}
			finally
			{
				if (p0 != null)
				{
					JNIEnv.CopyArray(intPtr, p0);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(p0);
			}
			return result;
		}

		// Token: 0x06000F04 RID: 3844 RVA: 0x0002BF20 File Offset: 0x0002A120
		[Register("isAppLovinTestEnvironment", "(Landroid/content/Context;)Z", "")]
		public unsafe static bool IsAppLovinTestEnvironment(Context p0)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				result = Utils._members.StaticMethods.InvokeBooleanMethod("isAppLovinTestEnvironment.(Landroid/content/Context;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return result;
		}

		// Token: 0x06000F05 RID: 3845 RVA: 0x0002BF84 File Offset: 0x0002A184
		[Register("isBML", "(Lcom/applovin/sdk/AppLovinAdSize;)Z", "")]
		public unsafe static bool IsBML(AppLovinAdSize p0)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				result = Utils._members.StaticMethods.InvokeBooleanMethod("isBML.(Lcom/applovin/sdk/AppLovinAdSize;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return result;
		}

		// Token: 0x06000F06 RID: 3846 RVA: 0x0002BFE8 File Offset: 0x0002A1E8
		[Register("isDeepLinkPlusUrl", "(Landroid/net/Uri;)Z", "")]
		public unsafe static bool IsDeepLinkPlusUrl(Android.Net.Uri p0)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				result = Utils._members.StaticMethods.InvokeBooleanMethod("isDeepLinkPlusUrl.(Landroid/net/Uri;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return result;
		}

		// Token: 0x06000F07 RID: 3847 RVA: 0x0002C04C File Offset: 0x0002A24C
		[Register("isDomainWhitelisted", "(Ljava/lang/String;Ljava/util/List;)Z", "")]
		public unsafe static bool IsDomainWhitelisted(string p0, IList<string> p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			IntPtr intPtr2 = JavaList<string>.ToLocalJniHandle(p1);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				result = Utils._members.StaticMethods.InvokeBooleanMethod("isDomainWhitelisted.(Ljava/lang/String;Ljava/util/List;)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(p1);
			}
			return result;
		}

		// Token: 0x06000F08 RID: 3848 RVA: 0x0002C0D0 File Offset: 0x0002A2D0
		[Register("isDspDemoApp", "(Landroid/content/Context;)Z", "")]
		public unsafe static bool IsDspDemoApp(Context p0)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				result = Utils._members.StaticMethods.InvokeBooleanMethod("isDspDemoApp.(Landroid/content/Context;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return result;
		}

		// Token: 0x06000F09 RID: 3849 RVA: 0x0002C134 File Offset: 0x0002A334
		[Register("isTestApp", "(Landroid/content/Context;)Z", "")]
		public unsafe static bool IsTestApp(Context p0)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				result = Utils._members.StaticMethods.InvokeBooleanMethod("isTestApp.(Landroid/content/Context;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return result;
		}

		// Token: 0x06000F0A RID: 3850 RVA: 0x0002C198 File Offset: 0x0002A398
		[Register("isVerboseLoggingEnabled", "(Landroid/content/Context;)Z", "")]
		public unsafe static bool IsVerboseLoggingEnabled(Context p0)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				result = Utils._members.StaticMethods.InvokeBooleanMethod("isVerboseLoggingEnabled.(Landroid/content/Context;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return result;
		}

		// Token: 0x06000F0B RID: 3851 RVA: 0x0002C1FC File Offset: 0x0002A3FC
		[Register("isViewInChildView", "(Landroid/view/View;Landroid/view/View;)Z", "")]
		public unsafe static bool IsViewInChildView(View p0, View p1)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				result = Utils._members.StaticMethods.InvokeBooleanMethod("isViewInChildView.(Landroid/view/View;Landroid/view/View;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
			}
			return result;
		}

		// Token: 0x06000F0C RID: 3852 RVA: 0x0002C288 File Offset: 0x0002A488
		[Register("isViewInTopActivity", "(Landroid/view/View;Landroid/app/Activity;)Z", "")]
		public unsafe static bool IsViewInTopActivity(View p0, Activity p1)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				result = Utils._members.StaticMethods.InvokeBooleanMethod("isViewInTopActivity.(Landroid/view/View;Landroid/app/Activity;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
			}
			return result;
		}

		// Token: 0x06000F0D RID: 3853 RVA: 0x0002C314 File Offset: 0x0002A514
		[Register("kilobytesToByes", "(I)I", "")]
		public unsafe static int KilobytesToByes(int p0)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(p0);
			return Utils._members.StaticMethods.InvokeInt32Method("kilobytesToByes.(I)I", ptr);
		}

		// Token: 0x06000F0E RID: 3854 RVA: 0x0002C350 File Offset: 0x0002A550
		[Register("maybeLogCustomDataSizeLimit", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe static void MaybeLogCustomDataSizeLimit(string p0, string p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			IntPtr intPtr2 = JNIEnv.NewString(p1);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				Utils._members.StaticMethods.InvokeVoidMethod("maybeLogCustomDataSizeLimit.(Ljava/lang/String;Ljava/lang/String;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
		}

		// Token: 0x06000F0F RID: 3855 RVA: 0x0002C3CC File Offset: 0x0002A5CC
		[Register("millisToSeconds", "(J)D", "")]
		public unsafe static double MillisToSeconds(long p0)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(p0);
			return Utils._members.StaticMethods.InvokeDoubleMethod("millisToSeconds.(J)D", ptr);
		}

		// Token: 0x06000F10 RID: 3856 RVA: 0x0002C408 File Offset: 0x0002A608
		[Register("parseColor", "(Ljava/lang/String;)J", "")]
		public unsafe static long ParseColor(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			long result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = Utils._members.StaticMethods.InvokeInt64Method("parseColor.(Ljava/lang/String;)J", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x06000F11 RID: 3857 RVA: 0x0002C464 File Offset: 0x0002A664
		[Register("putObjectForStringIfValid", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V", "")]
		public unsafe static void PutObjectForStringIfValid(string p0, string p1, IDictionary p2)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			IntPtr intPtr2 = JNIEnv.NewString(p1);
			IntPtr intPtr3 = JavaDictionary.ToLocalJniHandle(p2);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				Utils._members.StaticMethods.InvokeVoidMethod("putObjectForStringIfValid.(Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
				GC.KeepAlive(p2);
			}
		}

		// Token: 0x06000F12 RID: 3858 RVA: 0x0002C508 File Offset: 0x0002A708
		[Register("renameKeyInObjectMap", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V", "")]
		public unsafe static void RenameKeyInObjectMap(string p0, string p1, IDictionary<string, Java.Lang.Object> p2)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			IntPtr intPtr2 = JNIEnv.NewString(p1);
			IntPtr intPtr3 = JavaDictionary<string, Java.Lang.Object>.ToLocalJniHandle(p2);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				Utils._members.StaticMethods.InvokeVoidMethod("renameKeyInObjectMap.(Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
				GC.KeepAlive(p2);
			}
		}

		// Token: 0x06000F13 RID: 3859 RVA: 0x0002C5AC File Offset: 0x0002A7AC
		[Register("retrieveLauncherActivityFullyQualifiedName", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public unsafe static string RetrieveLauncherActivityFullyQualifiedName(Context p0)
		{
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				@string = JNIEnv.GetString(Utils._members.StaticMethods.InvokeObjectMethod("retrieveLauncherActivityFullyQualifiedName.(Landroid/content/Context;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return @string;
		}

		// Token: 0x06000F14 RID: 3860 RVA: 0x0002C620 File Offset: 0x0002A820
		[Register("secondsToMillis", "(F)F", "")]
		public unsafe static float SecondsToMillis(float p0)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(p0);
			return Utils._members.StaticMethods.InvokeSingleMethod("secondsToMillis.(F)F", ptr);
		}

		// Token: 0x06000F15 RID: 3861 RVA: 0x0002C65C File Offset: 0x0002A85C
		[Register("secondsToMillisLong", "(F)J", "")]
		public unsafe static long SecondsToMillisLong(float p0)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(p0);
			return Utils._members.StaticMethods.InvokeInt64Method("secondsToMillisLong.(F)J", ptr);
		}

		// Token: 0x06000F16 RID: 3862 RVA: 0x0002C698 File Offset: 0x0002A898
		[Register("shortenKey", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe static string ShortenKey(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@string = JNIEnv.GetString(Utils._members.StaticMethods.InvokeObjectMethod("shortenKey.(Ljava/lang/String;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @string;
		}

		// Token: 0x06000F17 RID: 3863 RVA: 0x0002C704 File Offset: 0x0002A904
		[Register("showAlert", "(Ljava/lang/String;Ljava/lang/String;Landroid/content/Context;)V", "")]
		public unsafe static void ShowAlert(string p0, string p1, Context p2)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			IntPtr intPtr2 = JNIEnv.NewString(p1);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : p2.Handle);
				Utils._members.StaticMethods.InvokeVoidMethod("showAlert.(Ljava/lang/String;Ljava/lang/String;Landroid/content/Context;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(p2);
			}
		}

		// Token: 0x06000F18 RID: 3864 RVA: 0x0002C7AC File Offset: 0x0002A9AC
		[Register("showToast", "(Ljava/lang/String;Landroid/content/Context;)V", "")]
		public unsafe static void ShowToast(string p0, Context p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				Utils._members.StaticMethods.InvokeVoidMethod("showToast.(Ljava/lang/String;Landroid/content/Context;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x06000F19 RID: 3865 RVA: 0x0002C830 File Offset: 0x0002AA30
		[Register("showToast", "(Ljava/lang/String;Lcom/applovin/mediation/MaxAd;Landroid/content/Context;)V", "")]
		public unsafe static void ShowToast(string p0, IMaxAd p1, Context p2)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : p2.Handle);
				Utils._members.StaticMethods.InvokeVoidMethod("showToast.(Ljava/lang/String;Lcom/applovin/mediation/MaxAd;Landroid/content/Context;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p1);
				GC.KeepAlive(p2);
			}
		}

		// Token: 0x06000F1A RID: 3866 RVA: 0x0002C8E4 File Offset: 0x0002AAE4
		[Register("stringifyObjectMap", "(Ljava/util/Map;)Ljava/util/Map;", "")]
		public unsafe static IDictionary<string, string> StringifyObjectMap(IDictionary<string, Java.Lang.Object> p0)
		{
			IntPtr intPtr = JavaDictionary<string, Java.Lang.Object>.ToLocalJniHandle(p0);
			IDictionary<string, string> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = JavaDictionary<string, string>.FromJniHandle(Utils._members.StaticMethods.InvokeObjectMethod("stringifyObjectMap.(Ljava/util/Map;)Ljava/util/Map;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
			}
			return result;
		}

		// Token: 0x06000F1B RID: 3867 RVA: 0x0002C954 File Offset: 0x0002AB54
		[Register("toVersionCode", "(Ljava/lang/String;)I", "")]
		public unsafe static int ToVersionCode(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = Utils._members.StaticMethods.InvokeInt32Method("toVersionCode.(Ljava/lang/String;)I", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x06000F1C RID: 3868 RVA: 0x0002C9B0 File Offset: 0x0002ABB0
		[Register("tryParseDouble", "(Ljava/lang/String;D)D", "")]
		public unsafe static double TryParseDouble(string p0, double p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			double result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(p1);
				result = Utils._members.StaticMethods.InvokeDoubleMethod("tryParseDouble.(Ljava/lang/String;D)D", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x06000F1D RID: 3869 RVA: 0x0002CA20 File Offset: 0x0002AC20
		[Register("tryToCreateWebView", "(Landroid/content/Context;Ljava/lang/String;)Landroid/webkit/WebView;", "")]
		public unsafe static WebView TryToCreateWebView(Context p0, string p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p1);
			WebView @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<WebView>(Utils._members.StaticMethods.InvokeObjectMethod("tryToCreateWebView.(Landroid/content/Context;Ljava/lang/String;)Landroid/webkit/WebView;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
			}
			return @object;
		}

		// Token: 0x06000F1E RID: 3870 RVA: 0x0002CAB4 File Offset: 0x0002ACB4
		[Register("tryToGetExoPlayerVersionCode", "()I", "")]
		public static int TryToGetExoPlayerVersionCode()
		{
			return Utils._members.StaticMethods.InvokeInt32Method("tryToGetExoPlayerVersionCode.()I", null);
		}

		// Token: 0x06000F1F RID: 3871 RVA: 0x0002CACC File Offset: 0x0002ACCC
		[Register("urlStringWithoutQueryParameters", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe static string UrlStringWithoutQueryParameters(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@string = JNIEnv.GetString(Utils._members.StaticMethods.InvokeObjectMethod("urlStringWithoutQueryParameters.(Ljava/lang/String;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @string;
		}

		// Token: 0x040004F1 RID: 1265
		[Register("BYTES_PER_KB")]
		public const int BytesPerKb = 1000;

		// Token: 0x040004F2 RID: 1266
		[Register("KEY_AD_VALUES")]
		public const string KeyAdValues = "ad_values";

		// Token: 0x040004F3 RID: 1267
		[Register("MACRO_CLCODE")]
		public const string MacroClcode = "{CLCODE}";

		// Token: 0x040004F4 RID: 1268
		[Register("MACRO_CLICK_X")]
		public const string MacroClickX = "{CLICK_X}";

		// Token: 0x040004F5 RID: 1269
		[Register("MACRO_CLICK_Y")]
		public const string MacroClickY = "{CLICK_Y}";

		// Token: 0x040004F6 RID: 1270
		[Register("MACRO_IS_VIDEO_CLICK")]
		public const string MacroIsVideoClick = "{IS_VIDEO_CLICK}";

		// Token: 0x040004F7 RID: 1271
		[Register("MACRO_SCREEN_HEIGHT")]
		public const string MacroScreenHeight = "{SCREEN_HEIGHT}";

		// Token: 0x040004F8 RID: 1272
		[Register("MACRO_SCREEN_WIDTH")]
		public const string MacroScreenWidth = "{SCREEN_WIDTH}";

		// Token: 0x040004F9 RID: 1273
		[Register("PLAY_STORE_PACKAGE_NAME")]
		public const string PlayStorePackageName = "com.android.vending";

		// Token: 0x040004FA RID: 1274
		[Register("PLAY_STORE_SCHEME")]
		public const string PlayStoreScheme = "market";

		// Token: 0x040004FB RID: 1275
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/impl/sdk/utils/Utils", typeof(Utils));
	}
}
