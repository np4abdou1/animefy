using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Banners.Properties
{
	// Token: 0x020001BD RID: 445
	[Register("com/unity3d/services/banners/properties/BannerRefreshInfo", DoNotGenerateAcw = true)]
	public class BannerRefreshInfo : Java.Lang.Object
	{
		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x060013D0 RID: 5072 RVA: 0x00038194 File Offset: 0x00036394
		internal static IntPtr class_ref
		{
			get
			{
				return BannerRefreshInfo._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x060013D1 RID: 5073 RVA: 0x000381B8 File Offset: 0x000363B8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BannerRefreshInfo._members;
			}
		}

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x060013D2 RID: 5074 RVA: 0x000381C0 File Offset: 0x000363C0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BannerRefreshInfo._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x060013D3 RID: 5075 RVA: 0x000381E4 File Offset: 0x000363E4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BannerRefreshInfo._members.ManagedPeerType;
			}
		}

		// Token: 0x060013D4 RID: 5076 RVA: 0x000021E8 File Offset: 0x000003E8
		protected BannerRefreshInfo(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060013D5 RID: 5077 RVA: 0x000381F0 File Offset: 0x000363F0
		[Register(".ctor", "()V", "")]
		public BannerRefreshInfo() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(BannerRefreshInfo._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			BannerRefreshInfo._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x060013D6 RID: 5078 RVA: 0x00038260 File Offset: 0x00036460
		public static BannerRefreshInfo Instance
		{
			[Register("getInstance", "()Lcom/unity3d/services/banners/properties/BannerRefreshInfo;", "")]
			get
			{
				return Java.Lang.Object.GetObject<BannerRefreshInfo>(BannerRefreshInfo._members.StaticMethods.InvokeObjectMethod("getInstance.()Lcom/unity3d/services/banners/properties/BannerRefreshInfo;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060013D7 RID: 5079 RVA: 0x00038291 File Offset: 0x00036491
		private static Delegate GetGetRefreshRate_Ljava_lang_String_Handler()
		{
			if (BannerRefreshInfo.cb_getRefreshRate_Ljava_lang_String_ == null)
			{
				BannerRefreshInfo.cb_getRefreshRate_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(BannerRefreshInfo.n_GetRefreshRate_Ljava_lang_String_));
			}
			return BannerRefreshInfo.cb_getRefreshRate_Ljava_lang_String_;
		}

		// Token: 0x060013D8 RID: 5080 RVA: 0x000382B8 File Offset: 0x000364B8
		private static IntPtr n_GetRefreshRate_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_placementId)
		{
			BannerRefreshInfo @object = Java.Lang.Object.GetObject<BannerRefreshInfo>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_placementId, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetRefreshRate(@string));
		}

		// Token: 0x060013D9 RID: 5081 RVA: 0x000382E0 File Offset: 0x000364E0
		[Register("getRefreshRate", "(Ljava/lang/String;)Ljava/lang/Integer;", "GetGetRefreshRate_Ljava_lang_String_Handler")]
		public unsafe virtual Integer GetRefreshRate(string placementId)
		{
			IntPtr intPtr = JNIEnv.NewString(placementId);
			Integer @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Integer>(BannerRefreshInfo._members.InstanceMethods.InvokeVirtualObjectMethod("getRefreshRate.(Ljava/lang/String;)Ljava/lang/Integer;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060013DA RID: 5082 RVA: 0x0003834C File Offset: 0x0003654C
		private static Delegate GetSetRefreshRate_Ljava_lang_String_Ljava_lang_Integer_Handler()
		{
			if (BannerRefreshInfo.cb_setRefreshRate_Ljava_lang_String_Ljava_lang_Integer_ == null)
			{
				BannerRefreshInfo.cb_setRefreshRate_Ljava_lang_String_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(BannerRefreshInfo.n_SetRefreshRate_Ljava_lang_String_Ljava_lang_Integer_));
			}
			return BannerRefreshInfo.cb_setRefreshRate_Ljava_lang_String_Ljava_lang_Integer_;
		}

		// Token: 0x060013DB RID: 5083 RVA: 0x00038370 File Offset: 0x00036570
		private static void n_SetRefreshRate_Ljava_lang_String_Ljava_lang_Integer_(IntPtr jnienv, IntPtr native__this, IntPtr native_placementId, IntPtr native_rate)
		{
			BannerRefreshInfo @object = Java.Lang.Object.GetObject<BannerRefreshInfo>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_placementId, JniHandleOwnership.DoNotTransfer);
			Integer object2 = Java.Lang.Object.GetObject<Integer>(native_rate, JniHandleOwnership.DoNotTransfer);
			@object.SetRefreshRate(@string, object2);
		}

		// Token: 0x060013DC RID: 5084 RVA: 0x0003839C File Offset: 0x0003659C
		[Register("setRefreshRate", "(Ljava/lang/String;Ljava/lang/Integer;)V", "GetSetRefreshRate_Ljava_lang_String_Ljava_lang_Integer_Handler")]
		public unsafe virtual void SetRefreshRate(string placementId, Integer rate)
		{
			IntPtr intPtr = JNIEnv.NewString(placementId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((rate == null) ? IntPtr.Zero : rate.Handle);
				BannerRefreshInfo._members.InstanceMethods.InvokeVirtualVoidMethod("setRefreshRate.(Ljava/lang/String;Ljava/lang/Integer;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(rate);
			}
		}

		// Token: 0x040004C6 RID: 1222
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/banners/properties/BannerRefreshInfo", typeof(BannerRefreshInfo));

		// Token: 0x040004C7 RID: 1223
		private static Delegate cb_getRefreshRate_Ljava_lang_String_;

		// Token: 0x040004C8 RID: 1224
		private static Delegate cb_setRefreshRate_Ljava_lang_String_Ljava_lang_Integer_;
	}
}
