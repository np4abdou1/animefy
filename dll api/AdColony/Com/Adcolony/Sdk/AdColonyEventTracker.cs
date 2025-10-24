using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Adcolony.Sdk
{
	// Token: 0x02000043 RID: 67
	[Register("com/adcolony/sdk/AdColonyEventTracker", DoNotGenerateAcw = true)]
	public class AdColonyEventTracker : Java.Lang.Object
	{
		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000311 RID: 785 RVA: 0x00009D20 File Offset: 0x00007F20
		internal static IntPtr class_ref
		{
			get
			{
				return AdColonyEventTracker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000312 RID: 786 RVA: 0x00009D44 File Offset: 0x00007F44
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AdColonyEventTracker._members;
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000313 RID: 787 RVA: 0x00009D4C File Offset: 0x00007F4C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AdColonyEventTracker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000314 RID: 788 RVA: 0x00009D70 File Offset: 0x00007F70
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AdColonyEventTracker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000315 RID: 789 RVA: 0x00002128 File Offset: 0x00000328
		protected AdColonyEventTracker(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000316 RID: 790 RVA: 0x00009D7C File Offset: 0x00007F7C
		[Register(".ctor", "()V", "")]
		public AdColonyEventTracker() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(AdColonyEventTracker._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			AdColonyEventTracker._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000317 RID: 791 RVA: 0x00009DEC File Offset: 0x00007FEC
		[Register("logAchievementUnlocked", "(Ljava/lang/String;)V", "")]
		public unsafe static void LogAchievementUnlocked(string description)
		{
			IntPtr intPtr = JNIEnv.NewString(description);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				AdColonyEventTracker._members.StaticMethods.InvokeVoidMethod("logAchievementUnlocked.(Ljava/lang/String;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x06000318 RID: 792 RVA: 0x00009E48 File Offset: 0x00008048
		[Register("logActivated", "()V", "")]
		public static void LogActivated()
		{
			AdColonyEventTracker._members.StaticMethods.InvokeVoidMethod("logActivated.()V", null);
		}

		// Token: 0x06000319 RID: 793 RVA: 0x00009E60 File Offset: 0x00008060
		[Register("logAdImpression", "()V", "")]
		public static void LogAdImpression()
		{
			AdColonyEventTracker._members.StaticMethods.InvokeVoidMethod("logAdImpression.()V", null);
		}

		// Token: 0x0600031A RID: 794 RVA: 0x00009E78 File Offset: 0x00008078
		[Register("logAddToCart", "(Ljava/lang/String;)V", "")]
		public unsafe static void LogAddToCart(string itemId)
		{
			IntPtr intPtr = JNIEnv.NewString(itemId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				AdColonyEventTracker._members.StaticMethods.InvokeVoidMethod("logAddToCart.(Ljava/lang/String;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x0600031B RID: 795 RVA: 0x00009ED4 File Offset: 0x000080D4
		[Register("logAddToWishlist", "(Ljava/lang/String;)V", "")]
		public unsafe static void LogAddToWishlist(string itemId)
		{
			IntPtr intPtr = JNIEnv.NewString(itemId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				AdColonyEventTracker._members.StaticMethods.InvokeVoidMethod("logAddToWishlist.(Ljava/lang/String;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x0600031C RID: 796 RVA: 0x00009F30 File Offset: 0x00008130
		[Register("logAppOpen", "()V", "")]
		public static void LogAppOpen()
		{
			AdColonyEventTracker._members.StaticMethods.InvokeVoidMethod("logAppOpen.()V", null);
		}

		// Token: 0x0600031D RID: 797 RVA: 0x00009F48 File Offset: 0x00008148
		[Register("logAppRated", "()V", "")]
		public static void LogAppRated()
		{
			AdColonyEventTracker._members.StaticMethods.InvokeVoidMethod("logAppRated.()V", null);
		}

		// Token: 0x0600031E RID: 798 RVA: 0x00009F60 File Offset: 0x00008160
		[Register("logCheckoutInitiated", "()V", "")]
		public static void LogCheckoutInitiated()
		{
			AdColonyEventTracker._members.StaticMethods.InvokeVoidMethod("logCheckoutInitiated.()V", null);
		}

		// Token: 0x0600031F RID: 799 RVA: 0x00009F78 File Offset: 0x00008178
		[Register("logContentView", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe static void LogContentView(string contentId, string contentType)
		{
			IntPtr intPtr = JNIEnv.NewString(contentId);
			IntPtr intPtr2 = JNIEnv.NewString(contentType);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				AdColonyEventTracker._members.StaticMethods.InvokeVoidMethod("logContentView.(Ljava/lang/String;Ljava/lang/String;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
		}

		// Token: 0x06000320 RID: 800 RVA: 0x00009FF4 File Offset: 0x000081F4
		[Register("logCreditsSpent", "(Ljava/lang/String;Ljava/lang/Integer;Ljava/lang/Double;Ljava/lang/String;)V", "")]
		public unsafe static void LogCreditsSpent(string name, Integer quantity, Java.Lang.Double value, string currencyCode)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			IntPtr intPtr2 = JNIEnv.NewString(currencyCode);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((quantity == null) ? IntPtr.Zero : quantity.Handle);
				ptr[2] = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
				ptr[3] = new JniArgumentValue(intPtr2);
				AdColonyEventTracker._members.StaticMethods.InvokeVoidMethod("logCreditsSpent.(Ljava/lang/String;Ljava/lang/Integer;Ljava/lang/Double;Ljava/lang/String;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(quantity);
				GC.KeepAlive(value);
			}
		}

		// Token: 0x06000321 RID: 801 RVA: 0x0000A0C4 File Offset: 0x000082C4
		[Register("logCustomEvent", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe static void LogCustomEvent(string e, string description)
		{
			IntPtr intPtr = JNIEnv.NewString(e);
			IntPtr intPtr2 = JNIEnv.NewString(description);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				AdColonyEventTracker._members.StaticMethods.InvokeVoidMethod("logCustomEvent.(Ljava/lang/String;Ljava/lang/String;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
		}

		// Token: 0x06000322 RID: 802 RVA: 0x0000A140 File Offset: 0x00008340
		[Register("logEvent", "(Ljava/lang/String;)V", "")]
		public unsafe static void LogEvent(string eventName)
		{
			IntPtr intPtr = JNIEnv.NewString(eventName);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				AdColonyEventTracker._members.StaticMethods.InvokeVoidMethod("logEvent.(Ljava/lang/String;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x06000323 RID: 803 RVA: 0x0000A19C File Offset: 0x0000839C
		[Register("logEvent", "(Ljava/lang/String;Ljava/util/HashMap;)V", "")]
		public unsafe static void LogEvent(string eventName, IDictionary<string, string> payload)
		{
			IntPtr intPtr = JNIEnv.NewString(eventName);
			IntPtr intPtr2 = JavaDictionary<string, string>.ToLocalJniHandle(payload);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				AdColonyEventTracker._members.StaticMethods.InvokeVoidMethod("logEvent.(Ljava/lang/String;Ljava/util/HashMap;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(payload);
			}
		}

		// Token: 0x06000324 RID: 804 RVA: 0x0000A21C File Offset: 0x0000841C
		[Register("logInvite", "()V", "")]
		public static void LogInvite()
		{
			AdColonyEventTracker._members.StaticMethods.InvokeVoidMethod("logInvite.()V", null);
		}

		// Token: 0x06000325 RID: 805 RVA: 0x0000A234 File Offset: 0x00008434
		[Register("logLevelAchieved", "(Ljava/lang/Integer;)V", "")]
		public unsafe static void LogLevelAchieved(Integer levelAchieved)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((levelAchieved == null) ? IntPtr.Zero : levelAchieved.Handle);
				AdColonyEventTracker._members.StaticMethods.InvokeVoidMethod("logLevelAchieved.(Ljava/lang/Integer;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(levelAchieved);
			}
		}

		// Token: 0x06000326 RID: 806 RVA: 0x0000A298 File Offset: 0x00008498
		[Register("logLogin", "(Ljava/lang/String;)V", "")]
		public unsafe static void LogLogin(string method)
		{
			IntPtr intPtr = JNIEnv.NewString(method);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				AdColonyEventTracker._members.StaticMethods.InvokeVoidMethod("logLogin.(Ljava/lang/String;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x06000327 RID: 807 RVA: 0x0000A2F4 File Offset: 0x000084F4
		[Register("logPaymentInfoAdded", "()V", "")]
		public static void LogPaymentInfoAdded()
		{
			AdColonyEventTracker._members.StaticMethods.InvokeVoidMethod("logPaymentInfoAdded.()V", null);
		}

		// Token: 0x06000328 RID: 808 RVA: 0x0000A30C File Offset: 0x0000850C
		[Register("logRegistrationCompleted", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe static void LogRegistrationCompleted(string method, string description)
		{
			IntPtr intPtr = JNIEnv.NewString(method);
			IntPtr intPtr2 = JNIEnv.NewString(description);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				AdColonyEventTracker._members.StaticMethods.InvokeVoidMethod("logRegistrationCompleted.(Ljava/lang/String;Ljava/lang/String;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
		}

		// Token: 0x06000329 RID: 809 RVA: 0x0000A388 File Offset: 0x00008588
		[Register("logReservation", "()V", "")]
		public static void LogReservation()
		{
			AdColonyEventTracker._members.StaticMethods.InvokeVoidMethod("logReservation.()V", null);
		}

		// Token: 0x0600032A RID: 810 RVA: 0x0000A3A0 File Offset: 0x000085A0
		[Register("logSearch", "(Ljava/lang/String;)V", "")]
		public unsafe static void LogSearch(string searchString)
		{
			IntPtr intPtr = JNIEnv.NewString(searchString);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				AdColonyEventTracker._members.StaticMethods.InvokeVoidMethod("logSearch.(Ljava/lang/String;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x0600032B RID: 811 RVA: 0x0000A3FC File Offset: 0x000085FC
		[Register("logSocialSharingEvent", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe static void LogSocialSharingEvent(string network, string description)
		{
			IntPtr intPtr = JNIEnv.NewString(network);
			IntPtr intPtr2 = JNIEnv.NewString(description);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				AdColonyEventTracker._members.StaticMethods.InvokeVoidMethod("logSocialSharingEvent.(Ljava/lang/String;Ljava/lang/String;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
		}

		// Token: 0x0600032C RID: 812 RVA: 0x0000A478 File Offset: 0x00008678
		[Register("logTransaction", "(Ljava/lang/String;Ljava/lang/Integer;Ljava/lang/Double;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe static void LogTransaction(string itemId, Integer quantity, Java.Lang.Double price, string currencyCode, string receipt, string store, string description)
		{
			IntPtr intPtr = JNIEnv.NewString(itemId);
			IntPtr intPtr2 = JNIEnv.NewString(currencyCode);
			IntPtr intPtr3 = JNIEnv.NewString(receipt);
			IntPtr intPtr4 = JNIEnv.NewString(store);
			IntPtr intPtr5 = JNIEnv.NewString(description);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((quantity == null) ? IntPtr.Zero : quantity.Handle);
				ptr[2] = new JniArgumentValue((price == null) ? IntPtr.Zero : price.Handle);
				ptr[3] = new JniArgumentValue(intPtr2);
				ptr[4] = new JniArgumentValue(intPtr3);
				ptr[5] = new JniArgumentValue(intPtr4);
				ptr[6] = new JniArgumentValue(intPtr5);
				AdColonyEventTracker._members.StaticMethods.InvokeVoidMethod("logTransaction.(Ljava/lang/String;Ljava/lang/Integer;Ljava/lang/Double;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
				JNIEnv.DeleteLocalRef(intPtr4);
				JNIEnv.DeleteLocalRef(intPtr5);
				GC.KeepAlive(quantity);
				GC.KeepAlive(price);
			}
		}

		// Token: 0x0600032D RID: 813 RVA: 0x0000A5C0 File Offset: 0x000087C0
		[Register("logTutorialCompleted", "()V", "")]
		public static void LogTutorialCompleted()
		{
			AdColonyEventTracker._members.StaticMethods.InvokeVoidMethod("logTutorialCompleted.()V", null);
		}

		// Token: 0x040000B2 RID: 178
		[Register("CUSTOM_EVENT_1")]
		public const string CustomEvent1 = "ADCT_CUSTOM_EVENT_1";

		// Token: 0x040000B3 RID: 179
		[Register("CUSTOM_EVENT_2")]
		public const string CustomEvent2 = "ADCT_CUSTOM_EVENT_2";

		// Token: 0x040000B4 RID: 180
		[Register("CUSTOM_EVENT_3")]
		public const string CustomEvent3 = "ADCT_CUSTOM_EVENT_3";

		// Token: 0x040000B5 RID: 181
		[Register("CUSTOM_EVENT_4")]
		public const string CustomEvent4 = "ADCT_CUSTOM_EVENT_4";

		// Token: 0x040000B6 RID: 182
		[Register("CUSTOM_EVENT_5")]
		public const string CustomEvent5 = "ADCT_CUSTOM_EVENT_5";

		// Token: 0x040000B7 RID: 183
		[Register("LOGIN_DEFAULT")]
		public const string LoginDefault = "ADCT_DEFAULT_LOGIN";

		// Token: 0x040000B8 RID: 184
		[Register("LOGIN_FACEBOOK")]
		public const string LoginFacebook = "ADCT_FACEBOOK_LOGIN";

		// Token: 0x040000B9 RID: 185
		[Register("LOGIN_GOOGLE")]
		public const string LoginGoogle = "ADCT_GOOGLE_LOGIN";

		// Token: 0x040000BA RID: 186
		[Register("LOGIN_LINKEDIN")]
		public const string LoginLinkedin = "ADCT_LINKEDIN_LOGIN";

		// Token: 0x040000BB RID: 187
		[Register("LOGIN_OPENID")]
		public const string LoginOpenid = "ADCT_OPENID_LOGIN";

		// Token: 0x040000BC RID: 188
		[Register("LOGIN_TWITTER")]
		public const string LoginTwitter = "ADCT_TWITTER_LOGIN";

		// Token: 0x040000BD RID: 189
		[Register("REGISTRATION_CUSTOM")]
		public const string RegistrationCustom = "ADCT_CUSTOM_REGISTRATION";

		// Token: 0x040000BE RID: 190
		[Register("REGISTRATION_DEFAULT")]
		public const string RegistrationDefault = "ADCT_DEFAULT_REGISTRATION";

		// Token: 0x040000BF RID: 191
		[Register("REGISTRATION_FACEBOOK")]
		public const string RegistrationFacebook = "ADCT_FACEBOOK_REGISTRATION";

		// Token: 0x040000C0 RID: 192
		[Register("REGISTRATION_GOOGLE")]
		public const string RegistrationGoogle = "ADCT_GOOGLE_REGISTRATION";

		// Token: 0x040000C1 RID: 193
		[Register("REGISTRATION_LINKEDIN")]
		public const string RegistrationLinkedin = "ADCT_LINKEDIN_REGISTRATION";

		// Token: 0x040000C2 RID: 194
		[Register("REGISTRATION_OPENID")]
		public const string RegistrationOpenid = "ADCT_OPENID_REGISTRATION";

		// Token: 0x040000C3 RID: 195
		[Register("REGISTRATION_TWITTER")]
		public const string RegistrationTwitter = "ADCT_TWITTER_REGISTRATION";

		// Token: 0x040000C4 RID: 196
		[Register("SOCIAL_SHARING_CUSTOM")]
		public const string SocialSharingCustom = "ADCT_CUSTOM_SHARING";

		// Token: 0x040000C5 RID: 197
		[Register("SOCIAL_SHARING_FACEBOOK")]
		public const string SocialSharingFacebook = "ADCT_FACEBOOK_SHARING";

		// Token: 0x040000C6 RID: 198
		[Register("SOCIAL_SHARING_FLICKR")]
		public const string SocialSharingFlickr = "ADCT_FLICKR_SHARING";

		// Token: 0x040000C7 RID: 199
		[Register("SOCIAL_SHARING_FOURSQUARE")]
		public const string SocialSharingFoursquare = "ADCT_FOURSQUARE_SHARING";

		// Token: 0x040000C8 RID: 200
		[Register("SOCIAL_SHARING_GOOGLE")]
		public const string SocialSharingGoogle = "ADCT_GOOGLE_SHARING";

		// Token: 0x040000C9 RID: 201
		[Register("SOCIAL_SHARING_INSTAGRAM")]
		public const string SocialSharingInstagram = "ADCT_INSTAGRAM_SHARING";

		// Token: 0x040000CA RID: 202
		[Register("SOCIAL_SHARING_LINKEDIN")]
		public const string SocialSharingLinkedin = "ADCT_LINKEDIN_SHARING";

		// Token: 0x040000CB RID: 203
		[Register("SOCIAL_SHARING_PINTEREST")]
		public const string SocialSharingPinterest = "ADCT_PINTEREST_SHARING";

		// Token: 0x040000CC RID: 204
		[Register("SOCIAL_SHARING_SNAPCHAT")]
		public const string SocialSharingSnapchat = "ADCT_SNAPCHAT_SHARING";

		// Token: 0x040000CD RID: 205
		[Register("SOCIAL_SHARING_TUMBLR")]
		public const string SocialSharingTumblr = "ADCT_TUMBLR_SHARING";

		// Token: 0x040000CE RID: 206
		[Register("SOCIAL_SHARING_TWITTER")]
		public const string SocialSharingTwitter = "ADCT_TWITTER_SHARING";

		// Token: 0x040000CF RID: 207
		[Register("SOCIAL_SHARING_VIMEO")]
		public const string SocialSharingVimeo = "ADCT_VIMEO_SHARING";

		// Token: 0x040000D0 RID: 208
		[Register("SOCIAL_SHARING_VINE")]
		public const string SocialSharingVine = "ADCT_VINE_SHARING";

		// Token: 0x040000D1 RID: 209
		[Register("SOCIAL_SHARING_YOUTUBE")]
		public const string SocialSharingYoutube = "ADCT_YOUTUBE_SHARING";

		// Token: 0x040000D2 RID: 210
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/adcolony/sdk/AdColonyEventTracker", typeof(AdColonyEventTracker));
	}
}
