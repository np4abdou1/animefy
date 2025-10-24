using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Sdk
{
	// Token: 0x02000059 RID: 89
	[Register("com/applovin/sdk/AppLovinPrivacySettings", DoNotGenerateAcw = true)]
	public class AppLovinPrivacySettings : Java.Lang.Object
	{
		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060002C9 RID: 713 RVA: 0x000078D0 File Offset: 0x00005AD0
		internal static IntPtr class_ref
		{
			get
			{
				return AppLovinPrivacySettings._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060002CA RID: 714 RVA: 0x000078F4 File Offset: 0x00005AF4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AppLovinPrivacySettings._members;
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060002CB RID: 715 RVA: 0x000078FC File Offset: 0x00005AFC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AppLovinPrivacySettings._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x060002CC RID: 716 RVA: 0x00007920 File Offset: 0x00005B20
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AppLovinPrivacySettings._members.ManagedPeerType;
			}
		}

		// Token: 0x060002CD RID: 717 RVA: 0x000021F0 File Offset: 0x000003F0
		protected AppLovinPrivacySettings(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060002CE RID: 718 RVA: 0x0000792C File Offset: 0x00005B2C
		[Register(".ctor", "()V", "")]
		public AppLovinPrivacySettings() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(AppLovinPrivacySettings._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			AppLovinPrivacySettings._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060002CF RID: 719 RVA: 0x0000799C File Offset: 0x00005B9C
		[Register("hasUserConsent", "(Landroid/content/Context;)Z", "")]
		public unsafe static bool HasUserConsent(Context p0)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				result = AppLovinPrivacySettings._members.StaticMethods.InvokeBooleanMethod("hasUserConsent.(Landroid/content/Context;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return result;
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x00007A00 File Offset: 0x00005C00
		[Register("isAgeRestrictedUser", "(Landroid/content/Context;)Z", "")]
		public unsafe static bool IsAgeRestrictedUser(Context p0)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				result = AppLovinPrivacySettings._members.StaticMethods.InvokeBooleanMethod("isAgeRestrictedUser.(Landroid/content/Context;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return result;
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x00007A64 File Offset: 0x00005C64
		[Register("isAgeRestrictedUserSet", "(Landroid/content/Context;)Z", "")]
		public unsafe static bool IsAgeRestrictedUserSet(Context p0)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				result = AppLovinPrivacySettings._members.StaticMethods.InvokeBooleanMethod("isAgeRestrictedUserSet.(Landroid/content/Context;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return result;
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x00007AC8 File Offset: 0x00005CC8
		[Register("isDoNotSell", "(Landroid/content/Context;)Z", "")]
		public unsafe static bool IsDoNotSell(Context p0)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				result = AppLovinPrivacySettings._members.StaticMethods.InvokeBooleanMethod("isDoNotSell.(Landroid/content/Context;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return result;
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00007B2C File Offset: 0x00005D2C
		[Register("isDoNotSellSet", "(Landroid/content/Context;)Z", "")]
		public unsafe static bool IsDoNotSellSet(Context p0)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				result = AppLovinPrivacySettings._members.StaticMethods.InvokeBooleanMethod("isDoNotSellSet.(Landroid/content/Context;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return result;
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x00007B90 File Offset: 0x00005D90
		[Register("isUserConsentSet", "(Landroid/content/Context;)Z", "")]
		public unsafe static bool IsUserConsentSet(Context p0)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				result = AppLovinPrivacySettings._members.StaticMethods.InvokeBooleanMethod("isUserConsentSet.(Landroid/content/Context;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return result;
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x00007BF4 File Offset: 0x00005DF4
		[Register("setDoNotSell", "(ZLandroid/content/Context;)V", "")]
		public unsafe static void SetDoNotSell(bool p0, Context p1)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(p0);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				AppLovinPrivacySettings._members.StaticMethods.InvokeVoidMethod("setDoNotSell.(ZLandroid/content/Context;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x00007C6C File Offset: 0x00005E6C
		[Register("setHasUserConsent", "(ZLandroid/content/Context;)V", "")]
		public unsafe static void SetHasUserConsent(bool p0, Context p1)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(p0);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				AppLovinPrivacySettings._members.StaticMethods.InvokeVoidMethod("setHasUserConsent.(ZLandroid/content/Context;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x00007CE4 File Offset: 0x00005EE4
		[Register("setIsAgeRestrictedUser", "(ZLandroid/content/Context;)V", "")]
		public unsafe static void SetIsAgeRestrictedUser(bool p0, Context p1)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(p0);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				AppLovinPrivacySettings._members.StaticMethods.InvokeVoidMethod("setIsAgeRestrictedUser.(ZLandroid/content/Context;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x040000AF RID: 175
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/sdk/AppLovinPrivacySettings", typeof(AppLovinPrivacySettings));
	}
}
