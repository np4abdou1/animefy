using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Ads.Adunit
{
	// Token: 0x02000229 RID: 553
	[Register("com/unity3d/services/ads/adunit/AdUnitError", DoNotGenerateAcw = true)]
	public sealed class AdUnitError : Java.Lang.Enum
	{
		// Token: 0x170008E3 RID: 2275
		// (get) Token: 0x06001A4C RID: 6732 RVA: 0x0004D208 File Offset: 0x0004B408
		[Register("ACTIVITY_ID")]
		public static AdUnitError ActivityId
		{
			get
			{
				return Java.Lang.Object.GetObject<AdUnitError>(AdUnitError._members.StaticFields.GetObjectValue("ACTIVITY_ID.Lcom/unity3d/services/ads/adunit/AdUnitError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170008E4 RID: 2276
		// (get) Token: 0x06001A4D RID: 6733 RVA: 0x0004D238 File Offset: 0x0004B438
		[Register("ADUNIT_NULL")]
		public static AdUnitError AdunitNull
		{
			get
			{
				return Java.Lang.Object.GetObject<AdUnitError>(AdUnitError._members.StaticFields.GetObjectValue("ADUNIT_NULL.Lcom/unity3d/services/ads/adunit/AdUnitError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170008E5 RID: 2277
		// (get) Token: 0x06001A4E RID: 6734 RVA: 0x0004D268 File Offset: 0x0004B468
		[Register("API_LEVEL_ERROR")]
		public static AdUnitError ApiLevelError
		{
			get
			{
				return Java.Lang.Object.GetObject<AdUnitError>(AdUnitError._members.StaticFields.GetObjectValue("API_LEVEL_ERROR.Lcom/unity3d/services/ads/adunit/AdUnitError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170008E6 RID: 2278
		// (get) Token: 0x06001A4F RID: 6735 RVA: 0x0004D298 File Offset: 0x0004B498
		[Register("CORRUPTED_KEYEVENTLIST")]
		public static AdUnitError CorruptedKeyeventlist
		{
			get
			{
				return Java.Lang.Object.GetObject<AdUnitError>(AdUnitError._members.StaticFields.GetObjectValue("CORRUPTED_KEYEVENTLIST.Lcom/unity3d/services/ads/adunit/AdUnitError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170008E7 RID: 2279
		// (get) Token: 0x06001A50 RID: 6736 RVA: 0x0004D2C8 File Offset: 0x0004B4C8
		[Register("CORRUPTED_VIEWLIST")]
		public static AdUnitError CorruptedViewlist
		{
			get
			{
				return Java.Lang.Object.GetObject<AdUnitError>(AdUnitError._members.StaticFields.GetObjectValue("CORRUPTED_VIEWLIST.Lcom/unity3d/services/ads/adunit/AdUnitError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170008E8 RID: 2280
		// (get) Token: 0x06001A51 RID: 6737 RVA: 0x0004D2F8 File Offset: 0x0004B4F8
		[Register("DISPLAY_CUTOUT_INVOKE_FAILED")]
		public static AdUnitError DisplayCutoutInvokeFailed
		{
			get
			{
				return Java.Lang.Object.GetObject<AdUnitError>(AdUnitError._members.StaticFields.GetObjectValue("DISPLAY_CUTOUT_INVOKE_FAILED.Lcom/unity3d/services/ads/adunit/AdUnitError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170008E9 RID: 2281
		// (get) Token: 0x06001A52 RID: 6738 RVA: 0x0004D328 File Offset: 0x0004B528
		[Register("DISPLAY_CUTOUT_JSON_ERROR")]
		public static AdUnitError DisplayCutoutJsonError
		{
			get
			{
				return Java.Lang.Object.GetObject<AdUnitError>(AdUnitError._members.StaticFields.GetObjectValue("DISPLAY_CUTOUT_JSON_ERROR.Lcom/unity3d/services/ads/adunit/AdUnitError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170008EA RID: 2282
		// (get) Token: 0x06001A53 RID: 6739 RVA: 0x0004D358 File Offset: 0x0004B558
		[Register("DISPLAY_CUTOUT_METHOD_NOT_AVAILABLE")]
		public static AdUnitError DisplayCutoutMethodNotAvailable
		{
			get
			{
				return Java.Lang.Object.GetObject<AdUnitError>(AdUnitError._members.StaticFields.GetObjectValue("DISPLAY_CUTOUT_METHOD_NOT_AVAILABLE.Lcom/unity3d/services/ads/adunit/AdUnitError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170008EB RID: 2283
		// (get) Token: 0x06001A54 RID: 6740 RVA: 0x0004D388 File Offset: 0x0004B588
		[Register("GENERIC")]
		public static AdUnitError Generic
		{
			get
			{
				return Java.Lang.Object.GetObject<AdUnitError>(AdUnitError._members.StaticFields.GetObjectValue("GENERIC.Lcom/unity3d/services/ads/adunit/AdUnitError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170008EC RID: 2284
		// (get) Token: 0x06001A55 RID: 6741 RVA: 0x0004D3B8 File Offset: 0x0004B5B8
		[Register("LAYOUT_NULL")]
		public static AdUnitError LayoutNull
		{
			get
			{
				return Java.Lang.Object.GetObject<AdUnitError>(AdUnitError._members.StaticFields.GetObjectValue("LAYOUT_NULL.Lcom/unity3d/services/ads/adunit/AdUnitError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170008ED RID: 2285
		// (get) Token: 0x06001A56 RID: 6742 RVA: 0x0004D3E8 File Offset: 0x0004B5E8
		[Register("MAX_MOTION_EVENT_COUNT_REACHED")]
		public static AdUnitError MaxMotionEventCountReached
		{
			get
			{
				return Java.Lang.Object.GetObject<AdUnitError>(AdUnitError._members.StaticFields.GetObjectValue("MAX_MOTION_EVENT_COUNT_REACHED.Lcom/unity3d/services/ads/adunit/AdUnitError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170008EE RID: 2286
		// (get) Token: 0x06001A57 RID: 6743 RVA: 0x0004D418 File Offset: 0x0004B618
		[Register("NO_DISPLAY_CUTOUT_AVAILABLE")]
		public static AdUnitError NoDisplayCutoutAvailable
		{
			get
			{
				return Java.Lang.Object.GetObject<AdUnitError>(AdUnitError._members.StaticFields.GetObjectValue("NO_DISPLAY_CUTOUT_AVAILABLE.Lcom/unity3d/services/ads/adunit/AdUnitError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170008EF RID: 2287
		// (get) Token: 0x06001A58 RID: 6744 RVA: 0x0004D448 File Offset: 0x0004B648
		[Register("ORIENTATION")]
		public static AdUnitError Orientation
		{
			get
			{
				return Java.Lang.Object.GetObject<AdUnitError>(AdUnitError._members.StaticFields.GetObjectValue("ORIENTATION.Lcom/unity3d/services/ads/adunit/AdUnitError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170008F0 RID: 2288
		// (get) Token: 0x06001A59 RID: 6745 RVA: 0x0004D478 File Offset: 0x0004B678
		[Register("SCREENVISIBILITY")]
		public static AdUnitError Screenvisibility
		{
			get
			{
				return Java.Lang.Object.GetObject<AdUnitError>(AdUnitError._members.StaticFields.GetObjectValue("SCREENVISIBILITY.Lcom/unity3d/services/ads/adunit/AdUnitError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170008F1 RID: 2289
		// (get) Token: 0x06001A5A RID: 6746 RVA: 0x0004D4A8 File Offset: 0x0004B6A8
		[Register("SYSTEM_UI_VISIBILITY")]
		public static AdUnitError SystemUiVisibility
		{
			get
			{
				return Java.Lang.Object.GetObject<AdUnitError>(AdUnitError._members.StaticFields.GetObjectValue("SYSTEM_UI_VISIBILITY.Lcom/unity3d/services/ads/adunit/AdUnitError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170008F2 RID: 2290
		// (get) Token: 0x06001A5B RID: 6747 RVA: 0x0004D4D8 File Offset: 0x0004B6D8
		[Register("UNKNOWN_VIEW")]
		public static AdUnitError UnknownView
		{
			get
			{
				return Java.Lang.Object.GetObject<AdUnitError>(AdUnitError._members.StaticFields.GetObjectValue("UNKNOWN_VIEW.Lcom/unity3d/services/ads/adunit/AdUnitError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170008F3 RID: 2291
		// (get) Token: 0x06001A5C RID: 6748 RVA: 0x0004D508 File Offset: 0x0004B708
		internal static IntPtr class_ref
		{
			get
			{
				return AdUnitError._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170008F4 RID: 2292
		// (get) Token: 0x06001A5D RID: 6749 RVA: 0x0004D52C File Offset: 0x0004B72C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AdUnitError._members;
			}
		}

		// Token: 0x170008F5 RID: 2293
		// (get) Token: 0x06001A5E RID: 6750 RVA: 0x0004D534 File Offset: 0x0004B734
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AdUnitError._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170008F6 RID: 2294
		// (get) Token: 0x06001A5F RID: 6751 RVA: 0x0004D558 File Offset: 0x0004B758
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AdUnitError._members.ManagedPeerType;
			}
		}

		// Token: 0x06001A60 RID: 6752 RVA: 0x0000256C File Offset: 0x0000076C
		internal AdUnitError(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001A61 RID: 6753 RVA: 0x0004D564 File Offset: 0x0004B764
		[Register("valueOf", "(Ljava/lang/String;)Lcom/unity3d/services/ads/adunit/AdUnitError;", "")]
		public unsafe static AdUnitError ValueOf(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			AdUnitError @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<AdUnitError>(AdUnitError._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/unity3d/services/ads/adunit/AdUnitError;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06001A62 RID: 6754 RVA: 0x0004D5D0 File Offset: 0x0004B7D0
		[Register("values", "()[Lcom/unity3d/services/ads/adunit/AdUnitError;", "")]
		public static AdUnitError[] Values()
		{
			return (AdUnitError[])JNIEnv.GetArray(AdUnitError._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/unity3d/services/ads/adunit/AdUnitError;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(AdUnitError));
		}

		// Token: 0x04000674 RID: 1652
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/adunit/AdUnitError", typeof(AdUnitError));
	}
}
