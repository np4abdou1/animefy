using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.UserMesssagingPlatform
{
	// Token: 0x02000014 RID: 20
	[Register("com/google/android/ump/ConsentRequestParameters", DoNotGenerateAcw = true)]
	public class ConsentRequestParameters : Java.Lang.Object
	{
		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000064 RID: 100 RVA: 0x00002810 File Offset: 0x00000A10
		internal static IntPtr class_ref
		{
			get
			{
				return ConsentRequestParameters._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00002834 File Offset: 0x00000A34
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ConsentRequestParameters._members;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000066 RID: 102 RVA: 0x0000283C File Offset: 0x00000A3C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ConsentRequestParameters._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000067 RID: 103 RVA: 0x00002860 File Offset: 0x00000A60
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ConsentRequestParameters._members.ManagedPeerType;
			}
		}

		// Token: 0x06000068 RID: 104 RVA: 0x000020B4 File Offset: 0x000002B4
		protected ConsentRequestParameters(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000069 RID: 105 RVA: 0x0000286C File Offset: 0x00000A6C
		private static Delegate GetGetConsentDebugSettingsHandler()
		{
			if (ConsentRequestParameters.cb_getConsentDebugSettings == null)
			{
				ConsentRequestParameters.cb_getConsentDebugSettings = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ConsentRequestParameters.n_GetConsentDebugSettings));
			}
			return ConsentRequestParameters.cb_getConsentDebugSettings;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002890 File Offset: 0x00000A90
		private static IntPtr n_GetConsentDebugSettings(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ConsentRequestParameters>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ConsentDebugSettings);
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600006B RID: 107 RVA: 0x000028A4 File Offset: 0x00000AA4
		public virtual ConsentDebugSettings ConsentDebugSettings
		{
			[Register("getConsentDebugSettings", "()Lcom/google/android/ump/ConsentDebugSettings;", "GetGetConsentDebugSettingsHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ConsentDebugSettings>(ConsentRequestParameters._members.InstanceMethods.InvokeVirtualObjectMethod("getConsentDebugSettings.()Lcom/google/android/ump/ConsentDebugSettings;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600006C RID: 108 RVA: 0x000028D6 File Offset: 0x00000AD6
		private static Delegate GetIsTagForUnderAgeOfConsentHandler()
		{
			if (ConsentRequestParameters.cb_isTagForUnderAgeOfConsent == null)
			{
				ConsentRequestParameters.cb_isTagForUnderAgeOfConsent = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ConsentRequestParameters.n_IsTagForUnderAgeOfConsent));
			}
			return ConsentRequestParameters.cb_isTagForUnderAgeOfConsent;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x000028FA File Offset: 0x00000AFA
		private static bool n_IsTagForUnderAgeOfConsent(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ConsentRequestParameters>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsTagForUnderAgeOfConsent;
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600006E RID: 110 RVA: 0x00002909 File Offset: 0x00000B09
		public virtual bool IsTagForUnderAgeOfConsent
		{
			[Register("isTagForUnderAgeOfConsent", "()Z", "GetIsTagForUnderAgeOfConsentHandler")]
			get
			{
				return ConsentRequestParameters._members.InstanceMethods.InvokeVirtualBooleanMethod("isTagForUnderAgeOfConsent.()Z", this, null);
			}
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002924 File Offset: 0x00000B24
		[Register("zza", "()Ljava/lang/String;", "")]
		public string Zza()
		{
			return JNIEnv.GetString(ConsentRequestParameters._members.InstanceMethods.InvokeNonvirtualObjectMethod("zza.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000016 RID: 22
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/ump/ConsentRequestParameters", typeof(ConsentRequestParameters));

		// Token: 0x04000017 RID: 23
		private static Delegate cb_getConsentDebugSettings;

		// Token: 0x04000018 RID: 24
		private static Delegate cb_isTagForUnderAgeOfConsent;

		// Token: 0x02000015 RID: 21
		[Register("com/google/android/ump/ConsentRequestParameters$Builder", DoNotGenerateAcw = true)]
		public sealed class Builder : Java.Lang.Object
		{
			// Token: 0x17000014 RID: 20
			// (get) Token: 0x06000071 RID: 113 RVA: 0x00002974 File Offset: 0x00000B74
			internal static IntPtr class_ref
			{
				get
				{
					return ConsentRequestParameters.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000015 RID: 21
			// (get) Token: 0x06000072 RID: 114 RVA: 0x00002998 File Offset: 0x00000B98
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ConsentRequestParameters.Builder._members;
				}
			}

			// Token: 0x17000016 RID: 22
			// (get) Token: 0x06000073 RID: 115 RVA: 0x000029A0 File Offset: 0x00000BA0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return ConsentRequestParameters.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000017 RID: 23
			// (get) Token: 0x06000074 RID: 116 RVA: 0x000029C4 File Offset: 0x00000BC4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ConsentRequestParameters.Builder._members.ManagedPeerType;
				}
			}

			// Token: 0x06000075 RID: 117 RVA: 0x000020B4 File Offset: 0x000002B4
			internal Builder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06000076 RID: 118 RVA: 0x000029D0 File Offset: 0x00000BD0
			[Register(".ctor", "()V", "")]
			public Builder() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(ConsentRequestParameters.Builder._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				ConsentRequestParameters.Builder._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x06000077 RID: 119 RVA: 0x00002A40 File Offset: 0x00000C40
			[Register("build", "()Lcom/google/android/ump/ConsentRequestParameters;", "")]
			public ConsentRequestParameters Build()
			{
				return Java.Lang.Object.GetObject<ConsentRequestParameters>(ConsentRequestParameters.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("build.()Lcom/google/android/ump/ConsentRequestParameters;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000078 RID: 120 RVA: 0x00002A74 File Offset: 0x00000C74
			[Register("setAdMobAppId", "(Ljava/lang/String;)Lcom/google/android/ump/ConsentRequestParameters$Builder;", "")]
			public unsafe ConsentRequestParameters.Builder SetAdMobAppId(string adMobAppId)
			{
				IntPtr intPtr = JNIEnv.NewString(adMobAppId);
				ConsentRequestParameters.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<ConsentRequestParameters.Builder>(ConsentRequestParameters.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("setAdMobAppId.(Ljava/lang/String;)Lcom/google/android/ump/ConsentRequestParameters$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x06000079 RID: 121 RVA: 0x00002AE0 File Offset: 0x00000CE0
			[Register("setConsentDebugSettings", "(Lcom/google/android/ump/ConsentDebugSettings;)Lcom/google/android/ump/ConsentRequestParameters$Builder;", "")]
			public unsafe ConsentRequestParameters.Builder SetConsentDebugSettings(ConsentDebugSettings consentDebugSettings)
			{
				ConsentRequestParameters.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((consentDebugSettings == null) ? IntPtr.Zero : consentDebugSettings.Handle);
					@object = Java.Lang.Object.GetObject<ConsentRequestParameters.Builder>(ConsentRequestParameters.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("setConsentDebugSettings.(Lcom/google/android/ump/ConsentDebugSettings;)Lcom/google/android/ump/ConsentRequestParameters$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(consentDebugSettings);
				}
				return @object;
			}

			// Token: 0x0600007A RID: 122 RVA: 0x00002B54 File Offset: 0x00000D54
			[Register("setTagForUnderAgeOfConsent", "(Z)Lcom/google/android/ump/ConsentRequestParameters$Builder;", "")]
			public unsafe ConsentRequestParameters.Builder SetTagForUnderAgeOfConsent(bool tagForUnderAgeOfConsent)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(tagForUnderAgeOfConsent);
				return Java.Lang.Object.GetObject<ConsentRequestParameters.Builder>(ConsentRequestParameters.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("setTagForUnderAgeOfConsent.(Z)Lcom/google/android/ump/ConsentRequestParameters$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x04000019 RID: 25
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/ump/ConsentRequestParameters$Builder", typeof(ConsentRequestParameters.Builder));
		}
	}
}
