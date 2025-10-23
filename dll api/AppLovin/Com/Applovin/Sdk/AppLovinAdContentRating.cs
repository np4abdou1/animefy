using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Sdk
{
	// Token: 0x02000050 RID: 80
	[Register("com/applovin/sdk/AppLovinAdContentRating", DoNotGenerateAcw = true)]
	public sealed class AppLovinAdContentRating : Java.Lang.Enum
	{
		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000258 RID: 600 RVA: 0x000064F4 File Offset: 0x000046F4
		[Register("ALL_AUDIENCES")]
		public static AppLovinAdContentRating AllAudiences
		{
			get
			{
				return Java.Lang.Object.GetObject<AppLovinAdContentRating>(AppLovinAdContentRating._members.StaticFields.GetObjectValue("ALL_AUDIENCES.Lcom/applovin/sdk/AppLovinAdContentRating;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000259 RID: 601 RVA: 0x00006524 File Offset: 0x00004724
		[Register("EVERYONE_OVER_TWELVE")]
		public static AppLovinAdContentRating EveryoneOverTwelve
		{
			get
			{
				return Java.Lang.Object.GetObject<AppLovinAdContentRating>(AppLovinAdContentRating._members.StaticFields.GetObjectValue("EVERYONE_OVER_TWELVE.Lcom/applovin/sdk/AppLovinAdContentRating;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x0600025A RID: 602 RVA: 0x00006554 File Offset: 0x00004754
		[Register("MATURE_AUDIENCES")]
		public static AppLovinAdContentRating MatureAudiences
		{
			get
			{
				return Java.Lang.Object.GetObject<AppLovinAdContentRating>(AppLovinAdContentRating._members.StaticFields.GetObjectValue("MATURE_AUDIENCES.Lcom/applovin/sdk/AppLovinAdContentRating;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x0600025B RID: 603 RVA: 0x00006584 File Offset: 0x00004784
		[Register("NONE")]
		public static AppLovinAdContentRating None
		{
			get
			{
				return Java.Lang.Object.GetObject<AppLovinAdContentRating>(AppLovinAdContentRating._members.StaticFields.GetObjectValue("NONE.Lcom/applovin/sdk/AppLovinAdContentRating;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x0600025C RID: 604 RVA: 0x000065B4 File Offset: 0x000047B4
		internal static IntPtr class_ref
		{
			get
			{
				return AppLovinAdContentRating._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x0600025D RID: 605 RVA: 0x000065D8 File Offset: 0x000047D8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AppLovinAdContentRating._members;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x0600025E RID: 606 RVA: 0x000065E0 File Offset: 0x000047E0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AppLovinAdContentRating._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x0600025F RID: 607 RVA: 0x00006604 File Offset: 0x00004804
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AppLovinAdContentRating._members.ManagedPeerType;
			}
		}

		// Token: 0x06000260 RID: 608 RVA: 0x000048B4 File Offset: 0x00002AB4
		internal AppLovinAdContentRating(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00006610 File Offset: 0x00004810
		[Register("valueOf", "(Ljava/lang/String;)Lcom/applovin/sdk/AppLovinAdContentRating;", "")]
		public unsafe static AppLovinAdContentRating ValueOf(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			AppLovinAdContentRating @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<AppLovinAdContentRating>(AppLovinAdContentRating._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/applovin/sdk/AppLovinAdContentRating;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06000262 RID: 610 RVA: 0x0000667C File Offset: 0x0000487C
		[Register("values", "()[Lcom/applovin/sdk/AppLovinAdContentRating;", "")]
		public static AppLovinAdContentRating[] Values()
		{
			return (AppLovinAdContentRating[])JNIEnv.GetArray(AppLovinAdContentRating._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/applovin/sdk/AppLovinAdContentRating;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(AppLovinAdContentRating));
		}

		// Token: 0x0400005C RID: 92
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/sdk/AppLovinAdContentRating", typeof(AppLovinAdContentRating));
	}
}
