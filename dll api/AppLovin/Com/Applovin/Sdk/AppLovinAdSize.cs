using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Sdk
{
	// Token: 0x02000051 RID: 81
	[Register("com/applovin/sdk/AppLovinAdSize", DoNotGenerateAcw = true)]
	public class AppLovinAdSize : Java.Lang.Object
	{
		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000264 RID: 612 RVA: 0x000066D8 File Offset: 0x000048D8
		[Register("BANNER")]
		public static AppLovinAdSize Banner
		{
			get
			{
				return Java.Lang.Object.GetObject<AppLovinAdSize>(AppLovinAdSize._members.StaticFields.GetObjectValue("BANNER.Lcom/applovin/sdk/AppLovinAdSize;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000265 RID: 613 RVA: 0x00006708 File Offset: 0x00004908
		[Register("CROSS_PROMO")]
		public static AppLovinAdSize CrossPromo
		{
			get
			{
				return Java.Lang.Object.GetObject<AppLovinAdSize>(AppLovinAdSize._members.StaticFields.GetObjectValue("CROSS_PROMO.Lcom/applovin/sdk/AppLovinAdSize;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000266 RID: 614 RVA: 0x00006738 File Offset: 0x00004938
		[Register("INTERSTITIAL")]
		public static AppLovinAdSize Interstitial
		{
			get
			{
				return Java.Lang.Object.GetObject<AppLovinAdSize>(AppLovinAdSize._members.StaticFields.GetObjectValue("INTERSTITIAL.Lcom/applovin/sdk/AppLovinAdSize;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000267 RID: 615 RVA: 0x00006768 File Offset: 0x00004968
		[Register("LEADER")]
		public static AppLovinAdSize Leader
		{
			get
			{
				return Java.Lang.Object.GetObject<AppLovinAdSize>(AppLovinAdSize._members.StaticFields.GetObjectValue("LEADER.Lcom/applovin/sdk/AppLovinAdSize;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000268 RID: 616 RVA: 0x00006798 File Offset: 0x00004998
		[Register("MREC")]
		public static AppLovinAdSize Mrec
		{
			get
			{
				return Java.Lang.Object.GetObject<AppLovinAdSize>(AppLovinAdSize._members.StaticFields.GetObjectValue("MREC.Lcom/applovin/sdk/AppLovinAdSize;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000269 RID: 617 RVA: 0x000067C8 File Offset: 0x000049C8
		[Register("NATIVE")]
		public static AppLovinAdSize Native
		{
			get
			{
				return Java.Lang.Object.GetObject<AppLovinAdSize>(AppLovinAdSize._members.StaticFields.GetObjectValue("NATIVE.Lcom/applovin/sdk/AppLovinAdSize;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x0600026A RID: 618 RVA: 0x000067F8 File Offset: 0x000049F8
		internal static IntPtr class_ref
		{
			get
			{
				return AppLovinAdSize._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x0600026B RID: 619 RVA: 0x0000681C File Offset: 0x00004A1C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AppLovinAdSize._members;
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x0600026C RID: 620 RVA: 0x00006824 File Offset: 0x00004A24
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AppLovinAdSize._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x0600026D RID: 621 RVA: 0x00006848 File Offset: 0x00004A48
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AppLovinAdSize._members.ManagedPeerType;
			}
		}

		// Token: 0x0600026E RID: 622 RVA: 0x000021F0 File Offset: 0x000003F0
		protected AppLovinAdSize(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00006854 File Offset: 0x00004A54
		private static Delegate GetGetHeightHandler()
		{
			if (AppLovinAdSize.cb_getHeight == null)
			{
				AppLovinAdSize.cb_getHeight = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(AppLovinAdSize.n_GetHeight));
			}
			return AppLovinAdSize.cb_getHeight;
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00006878 File Offset: 0x00004A78
		private static int n_GetHeight(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AppLovinAdSize>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Height;
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000271 RID: 625 RVA: 0x00006887 File Offset: 0x00004A87
		public virtual int Height
		{
			[Register("getHeight", "()I", "GetGetHeightHandler")]
			get
			{
				return AppLovinAdSize._members.InstanceMethods.InvokeVirtualInt32Method("getHeight.()I", this, null);
			}
		}

		// Token: 0x06000272 RID: 626 RVA: 0x000068A0 File Offset: 0x00004AA0
		private static Delegate GetGetLabelHandler()
		{
			if (AppLovinAdSize.cb_getLabel == null)
			{
				AppLovinAdSize.cb_getLabel = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AppLovinAdSize.n_GetLabel));
			}
			return AppLovinAdSize.cb_getLabel;
		}

		// Token: 0x06000273 RID: 627 RVA: 0x000068C4 File Offset: 0x00004AC4
		private static IntPtr n_GetLabel(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<AppLovinAdSize>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Label);
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000274 RID: 628 RVA: 0x000068D8 File Offset: 0x00004AD8
		public virtual string Label
		{
			[Register("getLabel", "()Ljava/lang/String;", "GetGetLabelHandler")]
			get
			{
				return JNIEnv.GetString(AppLovinAdSize._members.InstanceMethods.InvokeVirtualObjectMethod("getLabel.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000275 RID: 629 RVA: 0x0000690A File Offset: 0x00004B0A
		private static Delegate GetGetWidthHandler()
		{
			if (AppLovinAdSize.cb_getWidth == null)
			{
				AppLovinAdSize.cb_getWidth = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(AppLovinAdSize.n_GetWidth));
			}
			return AppLovinAdSize.cb_getWidth;
		}

		// Token: 0x06000276 RID: 630 RVA: 0x0000692E File Offset: 0x00004B2E
		private static int n_GetWidth(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AppLovinAdSize>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Width;
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000277 RID: 631 RVA: 0x0000693D File Offset: 0x00004B3D
		public virtual int Width
		{
			[Register("getWidth", "()I", "GetGetWidthHandler")]
			get
			{
				return AppLovinAdSize._members.InstanceMethods.InvokeVirtualInt32Method("getWidth.()I", this, null);
			}
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00006958 File Offset: 0x00004B58
		[Register("fromString", "(Ljava/lang/String;)Lcom/applovin/sdk/AppLovinAdSize;", "")]
		public unsafe static AppLovinAdSize FromString(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			AppLovinAdSize @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<AppLovinAdSize>(AppLovinAdSize._members.StaticMethods.InvokeObjectMethod("fromString.(Ljava/lang/String;)Lcom/applovin/sdk/AppLovinAdSize;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x0400005D RID: 93
		[Register("SPAN")]
		public const int Span = -1;

		// Token: 0x0400005E RID: 94
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/sdk/AppLovinAdSize", typeof(AppLovinAdSize));

		// Token: 0x0400005F RID: 95
		private static Delegate cb_getHeight;

		// Token: 0x04000060 RID: 96
		private static Delegate cb_getLabel;

		// Token: 0x04000061 RID: 97
		private static Delegate cb_getWidth;
	}
}
