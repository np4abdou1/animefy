using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Banners.Bridge
{
	// Token: 0x020001BF RID: 447
	[Register("com/unity3d/services/banners/bridge/BannerBridge", DoNotGenerateAcw = true)]
	public class BannerBridge : Java.Lang.Object
	{
		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x060013F4 RID: 5108 RVA: 0x000388BC File Offset: 0x00036ABC
		internal static IntPtr class_ref
		{
			get
			{
				return BannerBridge._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x060013F5 RID: 5109 RVA: 0x000388E0 File Offset: 0x00036AE0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BannerBridge._members;
			}
		}

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x060013F6 RID: 5110 RVA: 0x000388E8 File Offset: 0x00036AE8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BannerBridge._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x060013F7 RID: 5111 RVA: 0x0003890C File Offset: 0x00036B0C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BannerBridge._members.ManagedPeerType;
			}
		}

		// Token: 0x060013F8 RID: 5112 RVA: 0x000021E8 File Offset: 0x000003E8
		protected BannerBridge(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060013F9 RID: 5113 RVA: 0x00038918 File Offset: 0x00036B18
		[Register(".ctor", "()V", "")]
		public BannerBridge() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(BannerBridge._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			BannerBridge._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060013FA RID: 5114 RVA: 0x00038988 File Offset: 0x00036B88
		[Register("destroy", "(Ljava/lang/String;)V", "")]
		public unsafe static void Destroy(string bannerAdId)
		{
			IntPtr intPtr = JNIEnv.NewString(bannerAdId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				BannerBridge._members.StaticMethods.InvokeVoidMethod("destroy.(Ljava/lang/String;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x060013FB RID: 5115 RVA: 0x000389E4 File Offset: 0x00036BE4
		[Register("didAttach", "(Ljava/lang/String;)V", "")]
		public unsafe static void DidAttach(string bannerAdId)
		{
			IntPtr intPtr = JNIEnv.NewString(bannerAdId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				BannerBridge._members.StaticMethods.InvokeVoidMethod("didAttach.(Ljava/lang/String;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x060013FC RID: 5116 RVA: 0x00038A40 File Offset: 0x00036C40
		[Register("didDestroy", "(Ljava/lang/String;)V", "")]
		public unsafe static void DidDestroy(string bannerAdId)
		{
			IntPtr intPtr = JNIEnv.NewString(bannerAdId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				BannerBridge._members.StaticMethods.InvokeVoidMethod("didDestroy.(Ljava/lang/String;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x060013FD RID: 5117 RVA: 0x00038A9C File Offset: 0x00036C9C
		[Register("didDetach", "(Ljava/lang/String;)V", "")]
		public unsafe static void DidDetach(string bannerAdId)
		{
			IntPtr intPtr = JNIEnv.NewString(bannerAdId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				BannerBridge._members.StaticMethods.InvokeVoidMethod("didDetach.(Ljava/lang/String;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x060013FE RID: 5118 RVA: 0x00038AF8 File Offset: 0x00036CF8
		[Register("didLoad", "(Ljava/lang/String;)V", "")]
		public unsafe static void DidLoad(string bannerAdId)
		{
			IntPtr intPtr = JNIEnv.NewString(bannerAdId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				BannerBridge._members.StaticMethods.InvokeVoidMethod("didLoad.(Ljava/lang/String;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x060013FF RID: 5119 RVA: 0x00038B54 File Offset: 0x00036D54
		[Register("load", "(Ljava/lang/String;Ljava/lang/String;Lcom/unity3d/services/banners/UnityBannerSize;)V", "")]
		public unsafe static void Load(string placementId, string bannerAdId, UnityBannerSize bannerSize)
		{
			IntPtr intPtr = JNIEnv.NewString(placementId);
			IntPtr intPtr2 = JNIEnv.NewString(bannerAdId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((bannerSize == null) ? IntPtr.Zero : bannerSize.Handle);
				BannerBridge._members.StaticMethods.InvokeVoidMethod("load.(Ljava/lang/String;Ljava/lang/String;Lcom/unity3d/services/banners/UnityBannerSize;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(bannerSize);
			}
		}

		// Token: 0x06001400 RID: 5120 RVA: 0x00038BFC File Offset: 0x00036DFC
		[Register("resize", "(Ljava/lang/String;IIIIF)V", "")]
		public unsafe static void Resize(string bannerAdId, int left, int top, int right, int bottom, float alpha)
		{
			IntPtr intPtr = JNIEnv.NewString(bannerAdId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(left);
				ptr[2] = new JniArgumentValue(top);
				ptr[3] = new JniArgumentValue(right);
				ptr[4] = new JniArgumentValue(bottom);
				ptr[5] = new JniArgumentValue(alpha);
				BannerBridge._members.StaticMethods.InvokeVoidMethod("resize.(Ljava/lang/String;IIIIF)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x06001401 RID: 5121 RVA: 0x00038CC4 File Offset: 0x00036EC4
		[Register("visibilityChanged", "(Ljava/lang/String;I)V", "")]
		public unsafe static void VisibilityChanged(string bannerAdId, int visibility)
		{
			IntPtr intPtr = JNIEnv.NewString(bannerAdId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(visibility);
				BannerBridge._members.StaticMethods.InvokeVoidMethod("visibilityChanged.(Ljava/lang/String;I)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x040004CF RID: 1231
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/banners/bridge/BannerBridge", typeof(BannerBridge));

		// Token: 0x020001C0 RID: 448
		[Register("com/unity3d/services/banners/bridge/BannerBridge$BannerEvent", DoNotGenerateAcw = true)]
		public sealed class BannerEvent : Java.Lang.Enum
		{
			// Token: 0x170006E6 RID: 1766
			// (get) Token: 0x06001403 RID: 5123 RVA: 0x00038D50 File Offset: 0x00036F50
			[Register("BANNER_ATTACHED")]
			public static BannerBridge.BannerEvent BannerAttached
			{
				get
				{
					return Java.Lang.Object.GetObject<BannerBridge.BannerEvent>(BannerBridge.BannerEvent._members.StaticFields.GetObjectValue("BANNER_ATTACHED.Lcom/unity3d/services/banners/bridge/BannerBridge$BannerEvent;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x170006E7 RID: 1767
			// (get) Token: 0x06001404 RID: 5124 RVA: 0x00038D80 File Offset: 0x00036F80
			[Register("BANNER_DESTROYED")]
			public static BannerBridge.BannerEvent BannerDestroyed
			{
				get
				{
					return Java.Lang.Object.GetObject<BannerBridge.BannerEvent>(BannerBridge.BannerEvent._members.StaticFields.GetObjectValue("BANNER_DESTROYED.Lcom/unity3d/services/banners/bridge/BannerBridge$BannerEvent;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x170006E8 RID: 1768
			// (get) Token: 0x06001405 RID: 5125 RVA: 0x00038DB0 File Offset: 0x00036FB0
			[Register("BANNER_DESTROY_BANNER")]
			public static BannerBridge.BannerEvent BannerDestroyBanner
			{
				get
				{
					return Java.Lang.Object.GetObject<BannerBridge.BannerEvent>(BannerBridge.BannerEvent._members.StaticFields.GetObjectValue("BANNER_DESTROY_BANNER.Lcom/unity3d/services/banners/bridge/BannerBridge$BannerEvent;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x170006E9 RID: 1769
			// (get) Token: 0x06001406 RID: 5126 RVA: 0x00038DE0 File Offset: 0x00036FE0
			[Register("BANNER_DETACHED")]
			public static BannerBridge.BannerEvent BannerDetached
			{
				get
				{
					return Java.Lang.Object.GetObject<BannerBridge.BannerEvent>(BannerBridge.BannerEvent._members.StaticFields.GetObjectValue("BANNER_DETACHED.Lcom/unity3d/services/banners/bridge/BannerBridge$BannerEvent;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x170006EA RID: 1770
			// (get) Token: 0x06001407 RID: 5127 RVA: 0x00038E10 File Offset: 0x00037010
			[Register("BANNER_LOADED")]
			public static BannerBridge.BannerEvent BannerLoaded
			{
				get
				{
					return Java.Lang.Object.GetObject<BannerBridge.BannerEvent>(BannerBridge.BannerEvent._members.StaticFields.GetObjectValue("BANNER_LOADED.Lcom/unity3d/services/banners/bridge/BannerBridge$BannerEvent;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x170006EB RID: 1771
			// (get) Token: 0x06001408 RID: 5128 RVA: 0x00038E40 File Offset: 0x00037040
			[Register("BANNER_LOAD_PLACEMENT")]
			public static BannerBridge.BannerEvent BannerLoadPlacement
			{
				get
				{
					return Java.Lang.Object.GetObject<BannerBridge.BannerEvent>(BannerBridge.BannerEvent._members.StaticFields.GetObjectValue("BANNER_LOAD_PLACEMENT.Lcom/unity3d/services/banners/bridge/BannerBridge$BannerEvent;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x170006EC RID: 1772
			// (get) Token: 0x06001409 RID: 5129 RVA: 0x00038E70 File Offset: 0x00037070
			[Register("BANNER_RESIZED")]
			public static BannerBridge.BannerEvent BannerResized
			{
				get
				{
					return Java.Lang.Object.GetObject<BannerBridge.BannerEvent>(BannerBridge.BannerEvent._members.StaticFields.GetObjectValue("BANNER_RESIZED.Lcom/unity3d/services/banners/bridge/BannerBridge$BannerEvent;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x170006ED RID: 1773
			// (get) Token: 0x0600140A RID: 5130 RVA: 0x00038EA0 File Offset: 0x000370A0
			[Register("BANNER_VISIBILITY_CHANGED")]
			public static BannerBridge.BannerEvent BannerVisibilityChanged
			{
				get
				{
					return Java.Lang.Object.GetObject<BannerBridge.BannerEvent>(BannerBridge.BannerEvent._members.StaticFields.GetObjectValue("BANNER_VISIBILITY_CHANGED.Lcom/unity3d/services/banners/bridge/BannerBridge$BannerEvent;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x170006EE RID: 1774
			// (get) Token: 0x0600140B RID: 5131 RVA: 0x00038ED0 File Offset: 0x000370D0
			internal static IntPtr class_ref
			{
				get
				{
					return BannerBridge.BannerEvent._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170006EF RID: 1775
			// (get) Token: 0x0600140C RID: 5132 RVA: 0x00038EF4 File Offset: 0x000370F4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return BannerBridge.BannerEvent._members;
				}
			}

			// Token: 0x170006F0 RID: 1776
			// (get) Token: 0x0600140D RID: 5133 RVA: 0x00038EFC File Offset: 0x000370FC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return BannerBridge.BannerEvent._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170006F1 RID: 1777
			// (get) Token: 0x0600140E RID: 5134 RVA: 0x00038F20 File Offset: 0x00037120
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return BannerBridge.BannerEvent._members.ManagedPeerType;
				}
			}

			// Token: 0x0600140F RID: 5135 RVA: 0x0000256C File Offset: 0x0000076C
			internal BannerEvent(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06001410 RID: 5136 RVA: 0x00038F2C File Offset: 0x0003712C
			[Register("valueOf", "(Ljava/lang/String;)Lcom/unity3d/services/banners/bridge/BannerBridge$BannerEvent;", "")]
			public unsafe static BannerBridge.BannerEvent ValueOf(string name)
			{
				IntPtr intPtr = JNIEnv.NewString(name);
				BannerBridge.BannerEvent @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<BannerBridge.BannerEvent>(BannerBridge.BannerEvent._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/unity3d/services/banners/bridge/BannerBridge$BannerEvent;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x06001411 RID: 5137 RVA: 0x00038F98 File Offset: 0x00037198
			[Register("values", "()[Lcom/unity3d/services/banners/bridge/BannerBridge$BannerEvent;", "")]
			public static BannerBridge.BannerEvent[] Values()
			{
				return (BannerBridge.BannerEvent[])JNIEnv.GetArray(BannerBridge.BannerEvent._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/unity3d/services/banners/bridge/BannerBridge$BannerEvent;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(BannerBridge.BannerEvent));
			}

			// Token: 0x040004D0 RID: 1232
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/banners/bridge/BannerBridge$BannerEvent", typeof(BannerBridge.BannerEvent));
		}
	}
}
