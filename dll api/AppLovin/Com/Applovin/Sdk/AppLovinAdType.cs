using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Sdk
{
	// Token: 0x02000052 RID: 82
	[Register("com/applovin/sdk/AppLovinAdType", DoNotGenerateAcw = true)]
	public class AppLovinAdType : Java.Lang.Object
	{
		// Token: 0x170000BB RID: 187
		// (get) Token: 0x0600027A RID: 634 RVA: 0x000069E0 File Offset: 0x00004BE0
		[Register("AUTO_INCENTIVIZED")]
		public static AppLovinAdType AutoIncentivized
		{
			get
			{
				return Java.Lang.Object.GetObject<AppLovinAdType>(AppLovinAdType._members.StaticFields.GetObjectValue("AUTO_INCENTIVIZED.Lcom/applovin/sdk/AppLovinAdType;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x0600027B RID: 635 RVA: 0x00006A10 File Offset: 0x00004C10
		[Register("INCENTIVIZED")]
		public static AppLovinAdType Incentivized
		{
			get
			{
				return Java.Lang.Object.GetObject<AppLovinAdType>(AppLovinAdType._members.StaticFields.GetObjectValue("INCENTIVIZED.Lcom/applovin/sdk/AppLovinAdType;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x0600027C RID: 636 RVA: 0x00006A40 File Offset: 0x00004C40
		[Register("NATIVE")]
		public static AppLovinAdType Native
		{
			get
			{
				return Java.Lang.Object.GetObject<AppLovinAdType>(AppLovinAdType._members.StaticFields.GetObjectValue("NATIVE.Lcom/applovin/sdk/AppLovinAdType;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x0600027D RID: 637 RVA: 0x00006A70 File Offset: 0x00004C70
		[Register("REGULAR")]
		public static AppLovinAdType Regular
		{
			get
			{
				return Java.Lang.Object.GetObject<AppLovinAdType>(AppLovinAdType._members.StaticFields.GetObjectValue("REGULAR.Lcom/applovin/sdk/AppLovinAdType;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x0600027E RID: 638 RVA: 0x00006AA0 File Offset: 0x00004CA0
		internal static IntPtr class_ref
		{
			get
			{
				return AppLovinAdType._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x0600027F RID: 639 RVA: 0x00006AC4 File Offset: 0x00004CC4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AppLovinAdType._members;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000280 RID: 640 RVA: 0x00006ACC File Offset: 0x00004CCC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AppLovinAdType._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000281 RID: 641 RVA: 0x00006AF0 File Offset: 0x00004CF0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AppLovinAdType._members.ManagedPeerType;
			}
		}

		// Token: 0x06000282 RID: 642 RVA: 0x000021F0 File Offset: 0x000003F0
		protected AppLovinAdType(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00006AFC File Offset: 0x00004CFC
		private static Delegate GetGetLabelHandler()
		{
			if (AppLovinAdType.cb_getLabel == null)
			{
				AppLovinAdType.cb_getLabel = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AppLovinAdType.n_GetLabel));
			}
			return AppLovinAdType.cb_getLabel;
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00006B20 File Offset: 0x00004D20
		private static IntPtr n_GetLabel(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<AppLovinAdType>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Label);
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000285 RID: 645 RVA: 0x00006B34 File Offset: 0x00004D34
		public virtual string Label
		{
			[Register("getLabel", "()Ljava/lang/String;", "GetGetLabelHandler")]
			get
			{
				return JNIEnv.GetString(AppLovinAdType._members.InstanceMethods.InvokeVirtualObjectMethod("getLabel.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00006B68 File Offset: 0x00004D68
		[Register("fromString", "(Ljava/lang/String;)Lcom/applovin/sdk/AppLovinAdType;", "")]
		public unsafe static AppLovinAdType FromString(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			AppLovinAdType @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<AppLovinAdType>(AppLovinAdType._members.StaticMethods.InvokeObjectMethod("fromString.(Ljava/lang/String;)Lcom/applovin/sdk/AppLovinAdType;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x04000062 RID: 98
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/sdk/AppLovinAdType", typeof(AppLovinAdType));

		// Token: 0x04000063 RID: 99
		private static Delegate cb_getLabel;
	}
}
