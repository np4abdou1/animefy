using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Banners.View
{
	// Token: 0x020001BB RID: 443
	[Register("com/unity3d/services/banners/view/BannerPosition", DoNotGenerateAcw = true)]
	public sealed class BannerPosition : Java.Lang.Enum
	{
		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x060013A7 RID: 5031 RVA: 0x0003783C File Offset: 0x00035A3C
		[Register("BOTTOM_CENTER")]
		public static BannerPosition BottomCenter
		{
			get
			{
				return Java.Lang.Object.GetObject<BannerPosition>(BannerPosition._members.StaticFields.GetObjectValue("BOTTOM_CENTER.Lcom/unity3d/services/banners/view/BannerPosition;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x060013A8 RID: 5032 RVA: 0x0003786C File Offset: 0x00035A6C
		[Register("BOTTOM_LEFT")]
		public static BannerPosition BottomLeft
		{
			get
			{
				return Java.Lang.Object.GetObject<BannerPosition>(BannerPosition._members.StaticFields.GetObjectValue("BOTTOM_LEFT.Lcom/unity3d/services/banners/view/BannerPosition;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x060013A9 RID: 5033 RVA: 0x0003789C File Offset: 0x00035A9C
		[Register("BOTTOM_RIGHT")]
		public static BannerPosition BottomRight
		{
			get
			{
				return Java.Lang.Object.GetObject<BannerPosition>(BannerPosition._members.StaticFields.GetObjectValue("BOTTOM_RIGHT.Lcom/unity3d/services/banners/view/BannerPosition;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x060013AA RID: 5034 RVA: 0x000378CC File Offset: 0x00035ACC
		[Register("CENTER")]
		public static BannerPosition Center
		{
			get
			{
				return Java.Lang.Object.GetObject<BannerPosition>(BannerPosition._members.StaticFields.GetObjectValue("CENTER.Lcom/unity3d/services/banners/view/BannerPosition;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x060013AB RID: 5035 RVA: 0x000378FC File Offset: 0x00035AFC
		[Register("NONE")]
		public static BannerPosition None
		{
			get
			{
				return Java.Lang.Object.GetObject<BannerPosition>(BannerPosition._members.StaticFields.GetObjectValue("NONE.Lcom/unity3d/services/banners/view/BannerPosition;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x060013AC RID: 5036 RVA: 0x0003792C File Offset: 0x00035B2C
		[Register("TOP_CENTER")]
		public static BannerPosition TopCenter
		{
			get
			{
				return Java.Lang.Object.GetObject<BannerPosition>(BannerPosition._members.StaticFields.GetObjectValue("TOP_CENTER.Lcom/unity3d/services/banners/view/BannerPosition;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x060013AD RID: 5037 RVA: 0x0003795C File Offset: 0x00035B5C
		[Register("TOP_LEFT")]
		public static BannerPosition TopLeft
		{
			get
			{
				return Java.Lang.Object.GetObject<BannerPosition>(BannerPosition._members.StaticFields.GetObjectValue("TOP_LEFT.Lcom/unity3d/services/banners/view/BannerPosition;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x060013AE RID: 5038 RVA: 0x0003798C File Offset: 0x00035B8C
		[Register("TOP_RIGHT")]
		public static BannerPosition TopRight
		{
			get
			{
				return Java.Lang.Object.GetObject<BannerPosition>(BannerPosition._members.StaticFields.GetObjectValue("TOP_RIGHT.Lcom/unity3d/services/banners/view/BannerPosition;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x060013AF RID: 5039 RVA: 0x000379BC File Offset: 0x00035BBC
		internal static IntPtr class_ref
		{
			get
			{
				return BannerPosition._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x060013B0 RID: 5040 RVA: 0x000379E0 File Offset: 0x00035BE0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BannerPosition._members;
			}
		}

		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x060013B1 RID: 5041 RVA: 0x000379E8 File Offset: 0x00035BE8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BannerPosition._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x060013B2 RID: 5042 RVA: 0x00037A0C File Offset: 0x00035C0C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BannerPosition._members.ManagedPeerType;
			}
		}

		// Token: 0x060013B3 RID: 5043 RVA: 0x0000256C File Offset: 0x0000076C
		internal BannerPosition(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x060013B4 RID: 5044 RVA: 0x00037A18 File Offset: 0x00035C18
		public int Gravity
		{
			[Register("getGravity", "()I", "")]
			get
			{
				return BannerPosition._members.InstanceMethods.InvokeAbstractInt32Method("getGravity.()I", this, null);
			}
		}

		// Token: 0x060013B5 RID: 5045 RVA: 0x00037A34 File Offset: 0x00035C34
		[Register("addLayoutRules", "(Landroid/widget/RelativeLayout$LayoutParams;)Landroid/view/ViewGroup$LayoutParams;", "")]
		public unsafe ViewGroup.LayoutParams AddLayoutRules(RelativeLayout.LayoutParams @params)
		{
			ViewGroup.LayoutParams @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((@params == null) ? IntPtr.Zero : @params.Handle);
				@object = Java.Lang.Object.GetObject<ViewGroup.LayoutParams>(BannerPosition._members.InstanceMethods.InvokeAbstractObjectMethod("addLayoutRules.(Landroid/widget/RelativeLayout$LayoutParams;)Landroid/view/ViewGroup$LayoutParams;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(@params);
			}
			return @object;
		}

		// Token: 0x060013B6 RID: 5046 RVA: 0x00037AA8 File Offset: 0x00035CA8
		[Register("fromString", "(Ljava/lang/String;)Lcom/unity3d/services/banners/view/BannerPosition;", "")]
		public unsafe static BannerPosition FromString(string @in)
		{
			IntPtr intPtr = JNIEnv.NewString(@in);
			BannerPosition @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<BannerPosition>(BannerPosition._members.StaticMethods.InvokeObjectMethod("fromString.(Ljava/lang/String;)Lcom/unity3d/services/banners/view/BannerPosition;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060013B7 RID: 5047 RVA: 0x00037B14 File Offset: 0x00035D14
		[Register("valueOf", "(Ljava/lang/String;)Lcom/unity3d/services/banners/view/BannerPosition;", "")]
		public unsafe static BannerPosition ValueOf(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			BannerPosition @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<BannerPosition>(BannerPosition._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/unity3d/services/banners/view/BannerPosition;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060013B8 RID: 5048 RVA: 0x00037B80 File Offset: 0x00035D80
		[Register("values", "()[Lcom/unity3d/services/banners/view/BannerPosition;", "")]
		public static BannerPosition[] Values()
		{
			return (BannerPosition[])JNIEnv.GetArray(BannerPosition._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/unity3d/services/banners/view/BannerPosition;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(BannerPosition));
		}

		// Token: 0x040004BF RID: 1215
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/banners/view/BannerPosition", typeof(BannerPosition));
	}
}
