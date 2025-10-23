using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using AndroidX.Core.Util;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Core.App
{
	// Token: 0x02000065 RID: 101
	[Register("androidx/core/app/ActivityOptionsCompat", DoNotGenerateAcw = true)]
	public class ActivityOptionsCompat : Java.Lang.Object
	{
		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060003D6 RID: 982 RVA: 0x0000B0B8 File Offset: 0x000092B8
		internal static IntPtr class_ref
		{
			get
			{
				return ActivityOptionsCompat._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060003D7 RID: 983 RVA: 0x0000B0DC File Offset: 0x000092DC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ActivityOptionsCompat._members;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060003D8 RID: 984 RVA: 0x0000B0E4 File Offset: 0x000092E4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ActivityOptionsCompat._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060003D9 RID: 985 RVA: 0x0000B108 File Offset: 0x00009308
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ActivityOptionsCompat._members.ManagedPeerType;
			}
		}

		// Token: 0x060003DA RID: 986 RVA: 0x00002384 File Offset: 0x00000584
		protected ActivityOptionsCompat(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060003DB RID: 987 RVA: 0x0000B114 File Offset: 0x00009314
		[Register(".ctor", "()V", "")]
		protected ActivityOptionsCompat() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(ActivityOptionsCompat._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			ActivityOptionsCompat._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060003DC RID: 988 RVA: 0x0000B182 File Offset: 0x00009382
		private static Delegate GetGetLaunchBoundsHandler()
		{
			if (ActivityOptionsCompat.cb_getLaunchBounds == null)
			{
				ActivityOptionsCompat.cb_getLaunchBounds = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ActivityOptionsCompat.n_GetLaunchBounds));
			}
			return ActivityOptionsCompat.cb_getLaunchBounds;
		}

		// Token: 0x060003DD RID: 989 RVA: 0x0000B1A6 File Offset: 0x000093A6
		private static IntPtr n_GetLaunchBounds(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ActivityOptionsCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LaunchBounds);
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060003DE RID: 990 RVA: 0x0000B1BC File Offset: 0x000093BC
		public virtual Rect LaunchBounds
		{
			[Register("getLaunchBounds", "()Landroid/graphics/Rect;", "GetGetLaunchBoundsHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Rect>(ActivityOptionsCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getLaunchBounds.()Landroid/graphics/Rect;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060003DF RID: 991 RVA: 0x0000B1F0 File Offset: 0x000093F0
		[Register("makeBasic", "()Landroidx/core/app/ActivityOptionsCompat;", "")]
		public static ActivityOptionsCompat MakeBasic()
		{
			return Java.Lang.Object.GetObject<ActivityOptionsCompat>(ActivityOptionsCompat._members.StaticMethods.InvokeObjectMethod("makeBasic.()Landroidx/core/app/ActivityOptionsCompat;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x0000B224 File Offset: 0x00009424
		[Register("makeClipRevealAnimation", "(Landroid/view/View;IIII)Landroidx/core/app/ActivityOptionsCompat;", "")]
		public unsafe static ActivityOptionsCompat MakeClipRevealAnimation(View source, int startX, int startY, int width, int height)
		{
			ActivityOptionsCompat @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((source == null) ? IntPtr.Zero : source.Handle);
				ptr[1] = new JniArgumentValue(startX);
				ptr[2] = new JniArgumentValue(startY);
				ptr[3] = new JniArgumentValue(width);
				ptr[4] = new JniArgumentValue(height);
				@object = Java.Lang.Object.GetObject<ActivityOptionsCompat>(ActivityOptionsCompat._members.StaticMethods.InvokeObjectMethod("makeClipRevealAnimation.(Landroid/view/View;IIII)Landroidx/core/app/ActivityOptionsCompat;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(source);
			}
			return @object;
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x0000B2EC File Offset: 0x000094EC
		[Register("makeCustomAnimation", "(Landroid/content/Context;II)Landroidx/core/app/ActivityOptionsCompat;", "")]
		public unsafe static ActivityOptionsCompat MakeCustomAnimation(Context context, int enterResId, int exitResId)
		{
			ActivityOptionsCompat @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue(enterResId);
				ptr[2] = new JniArgumentValue(exitResId);
				@object = Java.Lang.Object.GetObject<ActivityOptionsCompat>(ActivityOptionsCompat._members.StaticMethods.InvokeObjectMethod("makeCustomAnimation.(Landroid/content/Context;II)Landroidx/core/app/ActivityOptionsCompat;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
			}
			return @object;
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x0000B388 File Offset: 0x00009588
		[Register("makeScaleUpAnimation", "(Landroid/view/View;IIII)Landroidx/core/app/ActivityOptionsCompat;", "")]
		public unsafe static ActivityOptionsCompat MakeScaleUpAnimation(View source, int startX, int startY, int startWidth, int startHeight)
		{
			ActivityOptionsCompat @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((source == null) ? IntPtr.Zero : source.Handle);
				ptr[1] = new JniArgumentValue(startX);
				ptr[2] = new JniArgumentValue(startY);
				ptr[3] = new JniArgumentValue(startWidth);
				ptr[4] = new JniArgumentValue(startHeight);
				@object = Java.Lang.Object.GetObject<ActivityOptionsCompat>(ActivityOptionsCompat._members.StaticMethods.InvokeObjectMethod("makeScaleUpAnimation.(Landroid/view/View;IIII)Landroidx/core/app/ActivityOptionsCompat;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(source);
			}
			return @object;
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x0000B450 File Offset: 0x00009650
		[Register("makeSceneTransitionAnimation", "(Landroid/app/Activity;Landroid/view/View;Ljava/lang/String;)Landroidx/core/app/ActivityOptionsCompat;", "")]
		public unsafe static ActivityOptionsCompat MakeSceneTransitionAnimation(Activity activity, View sharedElement, string sharedElementName)
		{
			IntPtr intPtr = JNIEnv.NewString(sharedElementName);
			ActivityOptionsCompat @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				ptr[1] = new JniArgumentValue((sharedElement == null) ? IntPtr.Zero : sharedElement.Handle);
				ptr[2] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<ActivityOptionsCompat>(ActivityOptionsCompat._members.StaticMethods.InvokeObjectMethod("makeSceneTransitionAnimation.(Landroid/app/Activity;Landroid/view/View;Ljava/lang/String;)Landroidx/core/app/ActivityOptionsCompat;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(activity);
				GC.KeepAlive(sharedElement);
			}
			return @object;
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x0000B510 File Offset: 0x00009710
		[Register("makeSceneTransitionAnimation", "(Landroid/app/Activity;[Landroidx/core/util/Pair;)Landroidx/core/app/ActivityOptionsCompat;", "")]
		public unsafe static ActivityOptionsCompat MakeSceneTransitionAnimation(Activity activity, params Pair[] sharedElements)
		{
			IntPtr intPtr = JNIEnv.NewArray<Pair>(sharedElements);
			ActivityOptionsCompat @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<ActivityOptionsCompat>(ActivityOptionsCompat._members.StaticMethods.InvokeObjectMethod("makeSceneTransitionAnimation.(Landroid/app/Activity;[Landroidx/core/util/Pair;)Landroidx/core/app/ActivityOptionsCompat;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (sharedElements != null)
				{
					JNIEnv.CopyArray<Pair>(intPtr, sharedElements);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(activity);
				GC.KeepAlive(sharedElements);
			}
			return @object;
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x0000B5B4 File Offset: 0x000097B4
		[Register("makeTaskLaunchBehind", "()Landroidx/core/app/ActivityOptionsCompat;", "")]
		public static ActivityOptionsCompat MakeTaskLaunchBehind()
		{
			return Java.Lang.Object.GetObject<ActivityOptionsCompat>(ActivityOptionsCompat._members.StaticMethods.InvokeObjectMethod("makeTaskLaunchBehind.()Landroidx/core/app/ActivityOptionsCompat;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x0000B5E8 File Offset: 0x000097E8
		[Register("makeThumbnailScaleUpAnimation", "(Landroid/view/View;Landroid/graphics/Bitmap;II)Landroidx/core/app/ActivityOptionsCompat;", "")]
		public unsafe static ActivityOptionsCompat MakeThumbnailScaleUpAnimation(View source, Bitmap thumbnail, int startX, int startY)
		{
			ActivityOptionsCompat @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((source == null) ? IntPtr.Zero : source.Handle);
				ptr[1] = new JniArgumentValue((thumbnail == null) ? IntPtr.Zero : thumbnail.Handle);
				ptr[2] = new JniArgumentValue(startX);
				ptr[3] = new JniArgumentValue(startY);
				@object = Java.Lang.Object.GetObject<ActivityOptionsCompat>(ActivityOptionsCompat._members.StaticMethods.InvokeObjectMethod("makeThumbnailScaleUpAnimation.(Landroid/view/View;Landroid/graphics/Bitmap;II)Landroidx/core/app/ActivityOptionsCompat;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(source);
				GC.KeepAlive(thumbnail);
			}
			return @object;
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x0000B6B0 File Offset: 0x000098B0
		private static Delegate GetRequestUsageTimeReport_Landroid_app_PendingIntent_Handler()
		{
			if (ActivityOptionsCompat.cb_requestUsageTimeReport_Landroid_app_PendingIntent_ == null)
			{
				ActivityOptionsCompat.cb_requestUsageTimeReport_Landroid_app_PendingIntent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ActivityOptionsCompat.n_RequestUsageTimeReport_Landroid_app_PendingIntent_));
			}
			return ActivityOptionsCompat.cb_requestUsageTimeReport_Landroid_app_PendingIntent_;
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x0000B6D4 File Offset: 0x000098D4
		private static void n_RequestUsageTimeReport_Landroid_app_PendingIntent_(IntPtr jnienv, IntPtr native__this, IntPtr native_receiver)
		{
			ActivityOptionsCompat @object = Java.Lang.Object.GetObject<ActivityOptionsCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			PendingIntent object2 = Java.Lang.Object.GetObject<PendingIntent>(native_receiver, JniHandleOwnership.DoNotTransfer);
			@object.RequestUsageTimeReport(object2);
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x0000B6F8 File Offset: 0x000098F8
		[Register("requestUsageTimeReport", "(Landroid/app/PendingIntent;)V", "GetRequestUsageTimeReport_Landroid_app_PendingIntent_Handler")]
		public unsafe virtual void RequestUsageTimeReport(PendingIntent receiver)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((receiver == null) ? IntPtr.Zero : receiver.Handle);
				ActivityOptionsCompat._members.InstanceMethods.InvokeVirtualVoidMethod("requestUsageTimeReport.(Landroid/app/PendingIntent;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(receiver);
			}
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x0000B75C File Offset: 0x0000995C
		private static Delegate GetSetLaunchBounds_Landroid_graphics_Rect_Handler()
		{
			if (ActivityOptionsCompat.cb_setLaunchBounds_Landroid_graphics_Rect_ == null)
			{
				ActivityOptionsCompat.cb_setLaunchBounds_Landroid_graphics_Rect_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ActivityOptionsCompat.n_SetLaunchBounds_Landroid_graphics_Rect_));
			}
			return ActivityOptionsCompat.cb_setLaunchBounds_Landroid_graphics_Rect_;
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x0000B780 File Offset: 0x00009980
		private static IntPtr n_SetLaunchBounds_Landroid_graphics_Rect_(IntPtr jnienv, IntPtr native__this, IntPtr native_screenSpacePixelRect)
		{
			ActivityOptionsCompat @object = Java.Lang.Object.GetObject<ActivityOptionsCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Rect object2 = Java.Lang.Object.GetObject<Rect>(native_screenSpacePixelRect, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetLaunchBounds(object2));
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x0000B7A8 File Offset: 0x000099A8
		[Register("setLaunchBounds", "(Landroid/graphics/Rect;)Landroidx/core/app/ActivityOptionsCompat;", "GetSetLaunchBounds_Landroid_graphics_Rect_Handler")]
		public unsafe virtual ActivityOptionsCompat SetLaunchBounds(Rect screenSpacePixelRect)
		{
			ActivityOptionsCompat @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((screenSpacePixelRect == null) ? IntPtr.Zero : screenSpacePixelRect.Handle);
				@object = Java.Lang.Object.GetObject<ActivityOptionsCompat>(ActivityOptionsCompat._members.InstanceMethods.InvokeVirtualObjectMethod("setLaunchBounds.(Landroid/graphics/Rect;)Landroidx/core/app/ActivityOptionsCompat;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(screenSpacePixelRect);
			}
			return @object;
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x0000B81C File Offset: 0x00009A1C
		private static Delegate GetToBundleHandler()
		{
			if (ActivityOptionsCompat.cb_toBundle == null)
			{
				ActivityOptionsCompat.cb_toBundle = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ActivityOptionsCompat.n_ToBundle));
			}
			return ActivityOptionsCompat.cb_toBundle;
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x0000B840 File Offset: 0x00009A40
		private static IntPtr n_ToBundle(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ActivityOptionsCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToBundle());
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x0000B854 File Offset: 0x00009A54
		[Register("toBundle", "()Landroid/os/Bundle;", "GetToBundleHandler")]
		public virtual Bundle ToBundle()
		{
			return Java.Lang.Object.GetObject<Bundle>(ActivityOptionsCompat._members.InstanceMethods.InvokeVirtualObjectMethod("toBundle.()Landroid/os/Bundle;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x0000B886 File Offset: 0x00009A86
		private static Delegate GetUpdate_Landroidx_core_app_ActivityOptionsCompat_Handler()
		{
			if (ActivityOptionsCompat.cb_update_Landroidx_core_app_ActivityOptionsCompat_ == null)
			{
				ActivityOptionsCompat.cb_update_Landroidx_core_app_ActivityOptionsCompat_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ActivityOptionsCompat.n_Update_Landroidx_core_app_ActivityOptionsCompat_));
			}
			return ActivityOptionsCompat.cb_update_Landroidx_core_app_ActivityOptionsCompat_;
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x0000B8AC File Offset: 0x00009AAC
		private static void n_Update_Landroidx_core_app_ActivityOptionsCompat_(IntPtr jnienv, IntPtr native__this, IntPtr native_otherOptions)
		{
			ActivityOptionsCompat @object = Java.Lang.Object.GetObject<ActivityOptionsCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ActivityOptionsCompat object2 = Java.Lang.Object.GetObject<ActivityOptionsCompat>(native_otherOptions, JniHandleOwnership.DoNotTransfer);
			@object.Update(object2);
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x0000B8D0 File Offset: 0x00009AD0
		[Register("update", "(Landroidx/core/app/ActivityOptionsCompat;)V", "GetUpdate_Landroidx_core_app_ActivityOptionsCompat_Handler")]
		public unsafe virtual void Update(ActivityOptionsCompat otherOptions)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((otherOptions == null) ? IntPtr.Zero : otherOptions.Handle);
				ActivityOptionsCompat._members.InstanceMethods.InvokeVirtualVoidMethod("update.(Landroidx/core/app/ActivityOptionsCompat;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(otherOptions);
			}
		}

		// Token: 0x04000104 RID: 260
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/app/ActivityOptionsCompat", typeof(ActivityOptionsCompat));

		// Token: 0x04000105 RID: 261
		private static Delegate cb_getLaunchBounds;

		// Token: 0x04000106 RID: 262
		private static Delegate cb_requestUsageTimeReport_Landroid_app_PendingIntent_;

		// Token: 0x04000107 RID: 263
		private static Delegate cb_setLaunchBounds_Landroid_graphics_Rect_;

		// Token: 0x04000108 RID: 264
		private static Delegate cb_toBundle;

		// Token: 0x04000109 RID: 265
		private static Delegate cb_update_Landroidx_core_app_ActivityOptionsCompat_;
	}
}
