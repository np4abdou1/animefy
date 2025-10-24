using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Graphics;
using Android.Runtime;
using Android.Views;
using AndroidX.Core.Graphics;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Core.View
{
	// Token: 0x020000BD RID: 189
	[Register("androidx/core/view/WindowInsetsCompat", DoNotGenerateAcw = true)]
	public class WindowInsetsCompat : Java.Lang.Object
	{
		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06000A9E RID: 2718 RVA: 0x00020CC4 File Offset: 0x0001EEC4
		[Register("CONSUMED")]
		public static WindowInsetsCompat Consumed
		{
			get
			{
				return Java.Lang.Object.GetObject<WindowInsetsCompat>(WindowInsetsCompat._members.StaticFields.GetObjectValue("CONSUMED.Landroidx/core/view/WindowInsetsCompat;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06000A9F RID: 2719 RVA: 0x00020CF4 File Offset: 0x0001EEF4
		internal static IntPtr class_ref
		{
			get
			{
				return WindowInsetsCompat._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06000AA0 RID: 2720 RVA: 0x00020D18 File Offset: 0x0001EF18
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return WindowInsetsCompat._members;
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000AA1 RID: 2721 RVA: 0x00020D20 File Offset: 0x0001EF20
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return WindowInsetsCompat._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000AA2 RID: 2722 RVA: 0x00020D44 File Offset: 0x0001EF44
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return WindowInsetsCompat._members.ManagedPeerType;
			}
		}

		// Token: 0x06000AA3 RID: 2723 RVA: 0x00002384 File Offset: 0x00000584
		protected WindowInsetsCompat(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000AA4 RID: 2724 RVA: 0x00020D50 File Offset: 0x0001EF50
		[Register(".ctor", "(Landroidx/core/view/WindowInsetsCompat;)V", "")]
		public unsafe WindowInsetsCompat(WindowInsetsCompat src) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((src == null) ? IntPtr.Zero : src.Handle);
				base.SetHandle(WindowInsetsCompat._members.InstanceMethods.StartCreateInstance("(Landroidx/core/view/WindowInsetsCompat;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				WindowInsetsCompat._members.InstanceMethods.FinishCreateInstance("(Landroidx/core/view/WindowInsetsCompat;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(src);
			}
		}

		// Token: 0x06000AA5 RID: 2725 RVA: 0x00020E00 File Offset: 0x0001F000
		private static Delegate GetGetDisplayCutoutHandler()
		{
			if (WindowInsetsCompat.cb_getDisplayCutout == null)
			{
				WindowInsetsCompat.cb_getDisplayCutout = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(WindowInsetsCompat.n_GetDisplayCutout));
			}
			return WindowInsetsCompat.cb_getDisplayCutout;
		}

		// Token: 0x06000AA6 RID: 2726 RVA: 0x00020E24 File Offset: 0x0001F024
		private static IntPtr n_GetDisplayCutout(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<WindowInsetsCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DisplayCutout);
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000AA7 RID: 2727 RVA: 0x00020E38 File Offset: 0x0001F038
		public virtual DisplayCutoutCompat DisplayCutout
		{
			[Register("getDisplayCutout", "()Landroidx/core/view/DisplayCutoutCompat;", "GetGetDisplayCutoutHandler")]
			get
			{
				return Java.Lang.Object.GetObject<DisplayCutoutCompat>(WindowInsetsCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getDisplayCutout.()Landroidx/core/view/DisplayCutoutCompat;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000AA8 RID: 2728 RVA: 0x00020E6A File Offset: 0x0001F06A
		private static Delegate GetHasInsetsHandler()
		{
			if (WindowInsetsCompat.cb_hasInsets == null)
			{
				WindowInsetsCompat.cb_hasInsets = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(WindowInsetsCompat.n_HasInsets));
			}
			return WindowInsetsCompat.cb_hasInsets;
		}

		// Token: 0x06000AA9 RID: 2729 RVA: 0x00020E8E File Offset: 0x0001F08E
		private static bool n_HasInsets(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<WindowInsetsCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HasInsets;
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000AAA RID: 2730 RVA: 0x00020E9D File Offset: 0x0001F09D
		public virtual bool HasInsets
		{
			[Register("hasInsets", "()Z", "GetHasInsetsHandler")]
			get
			{
				return WindowInsetsCompat._members.InstanceMethods.InvokeVirtualBooleanMethod("hasInsets.()Z", this, null);
			}
		}

		// Token: 0x06000AAB RID: 2731 RVA: 0x00020EB6 File Offset: 0x0001F0B6
		private static Delegate GetHasStableInsetsHandler()
		{
			if (WindowInsetsCompat.cb_hasStableInsets == null)
			{
				WindowInsetsCompat.cb_hasStableInsets = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(WindowInsetsCompat.n_HasStableInsets));
			}
			return WindowInsetsCompat.cb_hasStableInsets;
		}

		// Token: 0x06000AAC RID: 2732 RVA: 0x00020EDA File Offset: 0x0001F0DA
		private static bool n_HasStableInsets(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<WindowInsetsCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HasStableInsets;
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06000AAD RID: 2733 RVA: 0x00020EE9 File Offset: 0x0001F0E9
		public virtual bool HasStableInsets
		{
			[Register("hasStableInsets", "()Z", "GetHasStableInsetsHandler")]
			get
			{
				return WindowInsetsCompat._members.InstanceMethods.InvokeVirtualBooleanMethod("hasStableInsets.()Z", this, null);
			}
		}

		// Token: 0x06000AAE RID: 2734 RVA: 0x00020F02 File Offset: 0x0001F102
		private static Delegate GetHasSystemWindowInsetsHandler()
		{
			if (WindowInsetsCompat.cb_hasSystemWindowInsets == null)
			{
				WindowInsetsCompat.cb_hasSystemWindowInsets = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(WindowInsetsCompat.n_HasSystemWindowInsets));
			}
			return WindowInsetsCompat.cb_hasSystemWindowInsets;
		}

		// Token: 0x06000AAF RID: 2735 RVA: 0x00020F26 File Offset: 0x0001F126
		private static bool n_HasSystemWindowInsets(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<WindowInsetsCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HasSystemWindowInsets;
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06000AB0 RID: 2736 RVA: 0x00020F35 File Offset: 0x0001F135
		public virtual bool HasSystemWindowInsets
		{
			[Register("hasSystemWindowInsets", "()Z", "GetHasSystemWindowInsetsHandler")]
			get
			{
				return WindowInsetsCompat._members.InstanceMethods.InvokeVirtualBooleanMethod("hasSystemWindowInsets.()Z", this, null);
			}
		}

		// Token: 0x06000AB1 RID: 2737 RVA: 0x00020F4E File Offset: 0x0001F14E
		private static Delegate GetIsConsumedHandler()
		{
			if (WindowInsetsCompat.cb_isConsumed == null)
			{
				WindowInsetsCompat.cb_isConsumed = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(WindowInsetsCompat.n_IsConsumed));
			}
			return WindowInsetsCompat.cb_isConsumed;
		}

		// Token: 0x06000AB2 RID: 2738 RVA: 0x00020F72 File Offset: 0x0001F172
		private static bool n_IsConsumed(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<WindowInsetsCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsConsumed;
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06000AB3 RID: 2739 RVA: 0x00020F81 File Offset: 0x0001F181
		public virtual bool IsConsumed
		{
			[Register("isConsumed", "()Z", "GetIsConsumedHandler")]
			get
			{
				return WindowInsetsCompat._members.InstanceMethods.InvokeVirtualBooleanMethod("isConsumed.()Z", this, null);
			}
		}

		// Token: 0x06000AB4 RID: 2740 RVA: 0x00020F9A File Offset: 0x0001F19A
		private static Delegate GetIsRoundHandler()
		{
			if (WindowInsetsCompat.cb_isRound == null)
			{
				WindowInsetsCompat.cb_isRound = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(WindowInsetsCompat.n_IsRound));
			}
			return WindowInsetsCompat.cb_isRound;
		}

		// Token: 0x06000AB5 RID: 2741 RVA: 0x00020FBE File Offset: 0x0001F1BE
		private static bool n_IsRound(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<WindowInsetsCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsRound;
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06000AB6 RID: 2742 RVA: 0x00020FCD File Offset: 0x0001F1CD
		public virtual bool IsRound
		{
			[Register("isRound", "()Z", "GetIsRoundHandler")]
			get
			{
				return WindowInsetsCompat._members.InstanceMethods.InvokeVirtualBooleanMethod("isRound.()Z", this, null);
			}
		}

		// Token: 0x06000AB7 RID: 2743 RVA: 0x00020FE6 File Offset: 0x0001F1E6
		private static Delegate GetGetMandatorySystemGestureInsetsHandler()
		{
			if (WindowInsetsCompat.cb_getMandatorySystemGestureInsets == null)
			{
				WindowInsetsCompat.cb_getMandatorySystemGestureInsets = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(WindowInsetsCompat.n_GetMandatorySystemGestureInsets));
			}
			return WindowInsetsCompat.cb_getMandatorySystemGestureInsets;
		}

		// Token: 0x06000AB8 RID: 2744 RVA: 0x0002100A File Offset: 0x0001F20A
		private static IntPtr n_GetMandatorySystemGestureInsets(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<WindowInsetsCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MandatorySystemGestureInsets);
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06000AB9 RID: 2745 RVA: 0x00021020 File Offset: 0x0001F220
		public virtual AndroidX.Core.Graphics.Insets MandatorySystemGestureInsets
		{
			[Register("getMandatorySystemGestureInsets", "()Landroidx/core/graphics/Insets;", "GetGetMandatorySystemGestureInsetsHandler")]
			get
			{
				return Java.Lang.Object.GetObject<AndroidX.Core.Graphics.Insets>(WindowInsetsCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getMandatorySystemGestureInsets.()Landroidx/core/graphics/Insets;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000ABA RID: 2746 RVA: 0x00021052 File Offset: 0x0001F252
		private static Delegate GetGetStableInsetBottomHandler()
		{
			if (WindowInsetsCompat.cb_getStableInsetBottom == null)
			{
				WindowInsetsCompat.cb_getStableInsetBottom = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(WindowInsetsCompat.n_GetStableInsetBottom));
			}
			return WindowInsetsCompat.cb_getStableInsetBottom;
		}

		// Token: 0x06000ABB RID: 2747 RVA: 0x00021076 File Offset: 0x0001F276
		private static int n_GetStableInsetBottom(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<WindowInsetsCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).StableInsetBottom;
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06000ABC RID: 2748 RVA: 0x00021085 File Offset: 0x0001F285
		public virtual int StableInsetBottom
		{
			[Register("getStableInsetBottom", "()I", "GetGetStableInsetBottomHandler")]
			get
			{
				return WindowInsetsCompat._members.InstanceMethods.InvokeVirtualInt32Method("getStableInsetBottom.()I", this, null);
			}
		}

		// Token: 0x06000ABD RID: 2749 RVA: 0x0002109E File Offset: 0x0001F29E
		private static Delegate GetGetStableInsetLeftHandler()
		{
			if (WindowInsetsCompat.cb_getStableInsetLeft == null)
			{
				WindowInsetsCompat.cb_getStableInsetLeft = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(WindowInsetsCompat.n_GetStableInsetLeft));
			}
			return WindowInsetsCompat.cb_getStableInsetLeft;
		}

		// Token: 0x06000ABE RID: 2750 RVA: 0x000210C2 File Offset: 0x0001F2C2
		private static int n_GetStableInsetLeft(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<WindowInsetsCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).StableInsetLeft;
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x06000ABF RID: 2751 RVA: 0x000210D1 File Offset: 0x0001F2D1
		public virtual int StableInsetLeft
		{
			[Register("getStableInsetLeft", "()I", "GetGetStableInsetLeftHandler")]
			get
			{
				return WindowInsetsCompat._members.InstanceMethods.InvokeVirtualInt32Method("getStableInsetLeft.()I", this, null);
			}
		}

		// Token: 0x06000AC0 RID: 2752 RVA: 0x000210EA File Offset: 0x0001F2EA
		private static Delegate GetGetStableInsetRightHandler()
		{
			if (WindowInsetsCompat.cb_getStableInsetRight == null)
			{
				WindowInsetsCompat.cb_getStableInsetRight = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(WindowInsetsCompat.n_GetStableInsetRight));
			}
			return WindowInsetsCompat.cb_getStableInsetRight;
		}

		// Token: 0x06000AC1 RID: 2753 RVA: 0x0002110E File Offset: 0x0001F30E
		private static int n_GetStableInsetRight(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<WindowInsetsCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).StableInsetRight;
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06000AC2 RID: 2754 RVA: 0x0002111D File Offset: 0x0001F31D
		public virtual int StableInsetRight
		{
			[Register("getStableInsetRight", "()I", "GetGetStableInsetRightHandler")]
			get
			{
				return WindowInsetsCompat._members.InstanceMethods.InvokeVirtualInt32Method("getStableInsetRight.()I", this, null);
			}
		}

		// Token: 0x06000AC3 RID: 2755 RVA: 0x00021136 File Offset: 0x0001F336
		private static Delegate GetGetStableInsetTopHandler()
		{
			if (WindowInsetsCompat.cb_getStableInsetTop == null)
			{
				WindowInsetsCompat.cb_getStableInsetTop = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(WindowInsetsCompat.n_GetStableInsetTop));
			}
			return WindowInsetsCompat.cb_getStableInsetTop;
		}

		// Token: 0x06000AC4 RID: 2756 RVA: 0x0002115A File Offset: 0x0001F35A
		private static int n_GetStableInsetTop(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<WindowInsetsCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).StableInsetTop;
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06000AC5 RID: 2757 RVA: 0x00021169 File Offset: 0x0001F369
		public virtual int StableInsetTop
		{
			[Register("getStableInsetTop", "()I", "GetGetStableInsetTopHandler")]
			get
			{
				return WindowInsetsCompat._members.InstanceMethods.InvokeVirtualInt32Method("getStableInsetTop.()I", this, null);
			}
		}

		// Token: 0x06000AC6 RID: 2758 RVA: 0x00021182 File Offset: 0x0001F382
		private static Delegate GetGetStableInsetsHandler()
		{
			if (WindowInsetsCompat.cb_getStableInsets == null)
			{
				WindowInsetsCompat.cb_getStableInsets = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(WindowInsetsCompat.n_GetStableInsets));
			}
			return WindowInsetsCompat.cb_getStableInsets;
		}

		// Token: 0x06000AC7 RID: 2759 RVA: 0x000211A6 File Offset: 0x0001F3A6
		private static IntPtr n_GetStableInsets(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<WindowInsetsCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).StableInsets);
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06000AC8 RID: 2760 RVA: 0x000211BC File Offset: 0x0001F3BC
		public virtual AndroidX.Core.Graphics.Insets StableInsets
		{
			[Register("getStableInsets", "()Landroidx/core/graphics/Insets;", "GetGetStableInsetsHandler")]
			get
			{
				return Java.Lang.Object.GetObject<AndroidX.Core.Graphics.Insets>(WindowInsetsCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getStableInsets.()Landroidx/core/graphics/Insets;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000AC9 RID: 2761 RVA: 0x000211EE File Offset: 0x0001F3EE
		private static Delegate GetGetSystemGestureInsetsHandler()
		{
			if (WindowInsetsCompat.cb_getSystemGestureInsets == null)
			{
				WindowInsetsCompat.cb_getSystemGestureInsets = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(WindowInsetsCompat.n_GetSystemGestureInsets));
			}
			return WindowInsetsCompat.cb_getSystemGestureInsets;
		}

		// Token: 0x06000ACA RID: 2762 RVA: 0x00021212 File Offset: 0x0001F412
		private static IntPtr n_GetSystemGestureInsets(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<WindowInsetsCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SystemGestureInsets);
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x06000ACB RID: 2763 RVA: 0x00021228 File Offset: 0x0001F428
		public virtual AndroidX.Core.Graphics.Insets SystemGestureInsets
		{
			[Register("getSystemGestureInsets", "()Landroidx/core/graphics/Insets;", "GetGetSystemGestureInsetsHandler")]
			get
			{
				return Java.Lang.Object.GetObject<AndroidX.Core.Graphics.Insets>(WindowInsetsCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getSystemGestureInsets.()Landroidx/core/graphics/Insets;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000ACC RID: 2764 RVA: 0x0002125A File Offset: 0x0001F45A
		private static Delegate GetGetSystemWindowInsetBottomHandler()
		{
			if (WindowInsetsCompat.cb_getSystemWindowInsetBottom == null)
			{
				WindowInsetsCompat.cb_getSystemWindowInsetBottom = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(WindowInsetsCompat.n_GetSystemWindowInsetBottom));
			}
			return WindowInsetsCompat.cb_getSystemWindowInsetBottom;
		}

		// Token: 0x06000ACD RID: 2765 RVA: 0x0002127E File Offset: 0x0001F47E
		private static int n_GetSystemWindowInsetBottom(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<WindowInsetsCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SystemWindowInsetBottom;
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06000ACE RID: 2766 RVA: 0x0002128D File Offset: 0x0001F48D
		public virtual int SystemWindowInsetBottom
		{
			[Register("getSystemWindowInsetBottom", "()I", "GetGetSystemWindowInsetBottomHandler")]
			get
			{
				return WindowInsetsCompat._members.InstanceMethods.InvokeVirtualInt32Method("getSystemWindowInsetBottom.()I", this, null);
			}
		}

		// Token: 0x06000ACF RID: 2767 RVA: 0x000212A6 File Offset: 0x0001F4A6
		private static Delegate GetGetSystemWindowInsetLeftHandler()
		{
			if (WindowInsetsCompat.cb_getSystemWindowInsetLeft == null)
			{
				WindowInsetsCompat.cb_getSystemWindowInsetLeft = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(WindowInsetsCompat.n_GetSystemWindowInsetLeft));
			}
			return WindowInsetsCompat.cb_getSystemWindowInsetLeft;
		}

		// Token: 0x06000AD0 RID: 2768 RVA: 0x000212CA File Offset: 0x0001F4CA
		private static int n_GetSystemWindowInsetLeft(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<WindowInsetsCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SystemWindowInsetLeft;
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06000AD1 RID: 2769 RVA: 0x000212D9 File Offset: 0x0001F4D9
		public virtual int SystemWindowInsetLeft
		{
			[Register("getSystemWindowInsetLeft", "()I", "GetGetSystemWindowInsetLeftHandler")]
			get
			{
				return WindowInsetsCompat._members.InstanceMethods.InvokeVirtualInt32Method("getSystemWindowInsetLeft.()I", this, null);
			}
		}

		// Token: 0x06000AD2 RID: 2770 RVA: 0x000212F2 File Offset: 0x0001F4F2
		private static Delegate GetGetSystemWindowInsetRightHandler()
		{
			if (WindowInsetsCompat.cb_getSystemWindowInsetRight == null)
			{
				WindowInsetsCompat.cb_getSystemWindowInsetRight = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(WindowInsetsCompat.n_GetSystemWindowInsetRight));
			}
			return WindowInsetsCompat.cb_getSystemWindowInsetRight;
		}

		// Token: 0x06000AD3 RID: 2771 RVA: 0x00021316 File Offset: 0x0001F516
		private static int n_GetSystemWindowInsetRight(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<WindowInsetsCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SystemWindowInsetRight;
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06000AD4 RID: 2772 RVA: 0x00021325 File Offset: 0x0001F525
		public virtual int SystemWindowInsetRight
		{
			[Register("getSystemWindowInsetRight", "()I", "GetGetSystemWindowInsetRightHandler")]
			get
			{
				return WindowInsetsCompat._members.InstanceMethods.InvokeVirtualInt32Method("getSystemWindowInsetRight.()I", this, null);
			}
		}

		// Token: 0x06000AD5 RID: 2773 RVA: 0x0002133E File Offset: 0x0001F53E
		private static Delegate GetGetSystemWindowInsetTopHandler()
		{
			if (WindowInsetsCompat.cb_getSystemWindowInsetTop == null)
			{
				WindowInsetsCompat.cb_getSystemWindowInsetTop = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(WindowInsetsCompat.n_GetSystemWindowInsetTop));
			}
			return WindowInsetsCompat.cb_getSystemWindowInsetTop;
		}

		// Token: 0x06000AD6 RID: 2774 RVA: 0x00021362 File Offset: 0x0001F562
		private static int n_GetSystemWindowInsetTop(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<WindowInsetsCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SystemWindowInsetTop;
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06000AD7 RID: 2775 RVA: 0x00021371 File Offset: 0x0001F571
		public virtual int SystemWindowInsetTop
		{
			[Register("getSystemWindowInsetTop", "()I", "GetGetSystemWindowInsetTopHandler")]
			get
			{
				return WindowInsetsCompat._members.InstanceMethods.InvokeVirtualInt32Method("getSystemWindowInsetTop.()I", this, null);
			}
		}

		// Token: 0x06000AD8 RID: 2776 RVA: 0x0002138A File Offset: 0x0001F58A
		private static Delegate GetGetSystemWindowInsetsHandler()
		{
			if (WindowInsetsCompat.cb_getSystemWindowInsets == null)
			{
				WindowInsetsCompat.cb_getSystemWindowInsets = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(WindowInsetsCompat.n_GetSystemWindowInsets));
			}
			return WindowInsetsCompat.cb_getSystemWindowInsets;
		}

		// Token: 0x06000AD9 RID: 2777 RVA: 0x000213AE File Offset: 0x0001F5AE
		private static IntPtr n_GetSystemWindowInsets(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<WindowInsetsCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SystemWindowInsets);
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06000ADA RID: 2778 RVA: 0x000213C4 File Offset: 0x0001F5C4
		public virtual AndroidX.Core.Graphics.Insets SystemWindowInsets
		{
			[Register("getSystemWindowInsets", "()Landroidx/core/graphics/Insets;", "GetGetSystemWindowInsetsHandler")]
			get
			{
				return Java.Lang.Object.GetObject<AndroidX.Core.Graphics.Insets>(WindowInsetsCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getSystemWindowInsets.()Landroidx/core/graphics/Insets;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000ADB RID: 2779 RVA: 0x000213F6 File Offset: 0x0001F5F6
		private static Delegate GetGetTappableElementInsetsHandler()
		{
			if (WindowInsetsCompat.cb_getTappableElementInsets == null)
			{
				WindowInsetsCompat.cb_getTappableElementInsets = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(WindowInsetsCompat.n_GetTappableElementInsets));
			}
			return WindowInsetsCompat.cb_getTappableElementInsets;
		}

		// Token: 0x06000ADC RID: 2780 RVA: 0x0002141A File Offset: 0x0001F61A
		private static IntPtr n_GetTappableElementInsets(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<WindowInsetsCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TappableElementInsets);
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000ADD RID: 2781 RVA: 0x00021430 File Offset: 0x0001F630
		public virtual AndroidX.Core.Graphics.Insets TappableElementInsets
		{
			[Register("getTappableElementInsets", "()Landroidx/core/graphics/Insets;", "GetGetTappableElementInsetsHandler")]
			get
			{
				return Java.Lang.Object.GetObject<AndroidX.Core.Graphics.Insets>(WindowInsetsCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getTappableElementInsets.()Landroidx/core/graphics/Insets;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000ADE RID: 2782 RVA: 0x00021462 File Offset: 0x0001F662
		private static Delegate GetConsumeDisplayCutoutHandler()
		{
			if (WindowInsetsCompat.cb_consumeDisplayCutout == null)
			{
				WindowInsetsCompat.cb_consumeDisplayCutout = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(WindowInsetsCompat.n_ConsumeDisplayCutout));
			}
			return WindowInsetsCompat.cb_consumeDisplayCutout;
		}

		// Token: 0x06000ADF RID: 2783 RVA: 0x00021486 File Offset: 0x0001F686
		private static IntPtr n_ConsumeDisplayCutout(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<WindowInsetsCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ConsumeDisplayCutout());
		}

		// Token: 0x06000AE0 RID: 2784 RVA: 0x0002149C File Offset: 0x0001F69C
		[Register("consumeDisplayCutout", "()Landroidx/core/view/WindowInsetsCompat;", "GetConsumeDisplayCutoutHandler")]
		public virtual WindowInsetsCompat ConsumeDisplayCutout()
		{
			return Java.Lang.Object.GetObject<WindowInsetsCompat>(WindowInsetsCompat._members.InstanceMethods.InvokeVirtualObjectMethod("consumeDisplayCutout.()Landroidx/core/view/WindowInsetsCompat;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000AE1 RID: 2785 RVA: 0x000214CE File Offset: 0x0001F6CE
		private static Delegate GetConsumeStableInsetsHandler()
		{
			if (WindowInsetsCompat.cb_consumeStableInsets == null)
			{
				WindowInsetsCompat.cb_consumeStableInsets = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(WindowInsetsCompat.n_ConsumeStableInsets));
			}
			return WindowInsetsCompat.cb_consumeStableInsets;
		}

		// Token: 0x06000AE2 RID: 2786 RVA: 0x000214F2 File Offset: 0x0001F6F2
		private static IntPtr n_ConsumeStableInsets(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<WindowInsetsCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ConsumeStableInsets());
		}

		// Token: 0x06000AE3 RID: 2787 RVA: 0x00021508 File Offset: 0x0001F708
		[Register("consumeStableInsets", "()Landroidx/core/view/WindowInsetsCompat;", "GetConsumeStableInsetsHandler")]
		public virtual WindowInsetsCompat ConsumeStableInsets()
		{
			return Java.Lang.Object.GetObject<WindowInsetsCompat>(WindowInsetsCompat._members.InstanceMethods.InvokeVirtualObjectMethod("consumeStableInsets.()Landroidx/core/view/WindowInsetsCompat;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000AE4 RID: 2788 RVA: 0x0002153A File Offset: 0x0001F73A
		private static Delegate GetConsumeSystemWindowInsetsHandler()
		{
			if (WindowInsetsCompat.cb_consumeSystemWindowInsets == null)
			{
				WindowInsetsCompat.cb_consumeSystemWindowInsets = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(WindowInsetsCompat.n_ConsumeSystemWindowInsets));
			}
			return WindowInsetsCompat.cb_consumeSystemWindowInsets;
		}

		// Token: 0x06000AE5 RID: 2789 RVA: 0x0002155E File Offset: 0x0001F75E
		private static IntPtr n_ConsumeSystemWindowInsets(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<WindowInsetsCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ConsumeSystemWindowInsets());
		}

		// Token: 0x06000AE6 RID: 2790 RVA: 0x00021574 File Offset: 0x0001F774
		[Register("consumeSystemWindowInsets", "()Landroidx/core/view/WindowInsetsCompat;", "GetConsumeSystemWindowInsetsHandler")]
		public virtual WindowInsetsCompat ConsumeSystemWindowInsets()
		{
			return Java.Lang.Object.GetObject<WindowInsetsCompat>(WindowInsetsCompat._members.InstanceMethods.InvokeVirtualObjectMethod("consumeSystemWindowInsets.()Landroidx/core/view/WindowInsetsCompat;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000AE7 RID: 2791 RVA: 0x000215A6 File Offset: 0x0001F7A6
		private static Delegate GetGetInsets_IHandler()
		{
			if (WindowInsetsCompat.cb_getInsets_I == null)
			{
				WindowInsetsCompat.cb_getInsets_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(WindowInsetsCompat.n_GetInsets_I));
			}
			return WindowInsetsCompat.cb_getInsets_I;
		}

		// Token: 0x06000AE8 RID: 2792 RVA: 0x000215CA File Offset: 0x0001F7CA
		private static IntPtr n_GetInsets_I(IntPtr jnienv, IntPtr native__this, int typeMask)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<WindowInsetsCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetInsets(typeMask));
		}

		// Token: 0x06000AE9 RID: 2793 RVA: 0x000215E0 File Offset: 0x0001F7E0
		[Register("getInsets", "(I)Landroidx/core/graphics/Insets;", "GetGetInsets_IHandler")]
		public unsafe virtual AndroidX.Core.Graphics.Insets GetInsets(int typeMask)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(typeMask);
			return Java.Lang.Object.GetObject<AndroidX.Core.Graphics.Insets>(WindowInsetsCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getInsets.(I)Landroidx/core/graphics/Insets;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000AEA RID: 2794 RVA: 0x00021629 File Offset: 0x0001F829
		private static Delegate GetGetInsetsIgnoringVisibility_IHandler()
		{
			if (WindowInsetsCompat.cb_getInsetsIgnoringVisibility_I == null)
			{
				WindowInsetsCompat.cb_getInsetsIgnoringVisibility_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(WindowInsetsCompat.n_GetInsetsIgnoringVisibility_I));
			}
			return WindowInsetsCompat.cb_getInsetsIgnoringVisibility_I;
		}

		// Token: 0x06000AEB RID: 2795 RVA: 0x0002164D File Offset: 0x0001F84D
		private static IntPtr n_GetInsetsIgnoringVisibility_I(IntPtr jnienv, IntPtr native__this, int typeMask)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<WindowInsetsCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetInsetsIgnoringVisibility(typeMask));
		}

		// Token: 0x06000AEC RID: 2796 RVA: 0x00021664 File Offset: 0x0001F864
		[Register("getInsetsIgnoringVisibility", "(I)Landroidx/core/graphics/Insets;", "GetGetInsetsIgnoringVisibility_IHandler")]
		public unsafe virtual AndroidX.Core.Graphics.Insets GetInsetsIgnoringVisibility(int typeMask)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(typeMask);
			return Java.Lang.Object.GetObject<AndroidX.Core.Graphics.Insets>(WindowInsetsCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getInsetsIgnoringVisibility.(I)Landroidx/core/graphics/Insets;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000AED RID: 2797 RVA: 0x000216AD File Offset: 0x0001F8AD
		private static Delegate GetInset_Landroidx_core_graphics_Insets_Handler()
		{
			if (WindowInsetsCompat.cb_inset_Landroidx_core_graphics_Insets_ == null)
			{
				WindowInsetsCompat.cb_inset_Landroidx_core_graphics_Insets_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(WindowInsetsCompat.n_Inset_Landroidx_core_graphics_Insets_));
			}
			return WindowInsetsCompat.cb_inset_Landroidx_core_graphics_Insets_;
		}

		// Token: 0x06000AEE RID: 2798 RVA: 0x000216D4 File Offset: 0x0001F8D4
		private static IntPtr n_Inset_Landroidx_core_graphics_Insets_(IntPtr jnienv, IntPtr native__this, IntPtr native_insets)
		{
			WindowInsetsCompat @object = Java.Lang.Object.GetObject<WindowInsetsCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AndroidX.Core.Graphics.Insets object2 = Java.Lang.Object.GetObject<AndroidX.Core.Graphics.Insets>(native_insets, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Inset(object2));
		}

		// Token: 0x06000AEF RID: 2799 RVA: 0x000216FC File Offset: 0x0001F8FC
		[Register("inset", "(Landroidx/core/graphics/Insets;)Landroidx/core/view/WindowInsetsCompat;", "GetInset_Landroidx_core_graphics_Insets_Handler")]
		public unsafe virtual WindowInsetsCompat Inset(AndroidX.Core.Graphics.Insets insets)
		{
			WindowInsetsCompat @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((insets == null) ? IntPtr.Zero : insets.Handle);
				@object = Java.Lang.Object.GetObject<WindowInsetsCompat>(WindowInsetsCompat._members.InstanceMethods.InvokeVirtualObjectMethod("inset.(Landroidx/core/graphics/Insets;)Landroidx/core/view/WindowInsetsCompat;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(insets);
			}
			return @object;
		}

		// Token: 0x06000AF0 RID: 2800 RVA: 0x00021770 File Offset: 0x0001F970
		private static Delegate GetInset_IIIIHandler()
		{
			if (WindowInsetsCompat.cb_inset_IIII == null)
			{
				WindowInsetsCompat.cb_inset_IIII = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIIII_L(WindowInsetsCompat.n_Inset_IIII));
			}
			return WindowInsetsCompat.cb_inset_IIII;
		}

		// Token: 0x06000AF1 RID: 2801 RVA: 0x00021794 File Offset: 0x0001F994
		private static IntPtr n_Inset_IIII(IntPtr jnienv, IntPtr native__this, int left, int top, int right, int bottom)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<WindowInsetsCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Inset(left, top, right, bottom));
		}

		// Token: 0x06000AF2 RID: 2802 RVA: 0x000217B0 File Offset: 0x0001F9B0
		[Register("inset", "(IIII)Landroidx/core/view/WindowInsetsCompat;", "GetInset_IIIIHandler")]
		public unsafe virtual WindowInsetsCompat Inset(int left, int top, int right, int bottom)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(left);
			ptr[1] = new JniArgumentValue(top);
			ptr[2] = new JniArgumentValue(right);
			ptr[3] = new JniArgumentValue(bottom);
			return Java.Lang.Object.GetObject<WindowInsetsCompat>(WindowInsetsCompat._members.InstanceMethods.InvokeVirtualObjectMethod("inset.(IIII)Landroidx/core/view/WindowInsetsCompat;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000AF3 RID: 2803 RVA: 0x00021839 File Offset: 0x0001FA39
		private static Delegate GetIsVisible_IHandler()
		{
			if (WindowInsetsCompat.cb_isVisible_I == null)
			{
				WindowInsetsCompat.cb_isVisible_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_Z(WindowInsetsCompat.n_IsVisible_I));
			}
			return WindowInsetsCompat.cb_isVisible_I;
		}

		// Token: 0x06000AF4 RID: 2804 RVA: 0x0002185D File Offset: 0x0001FA5D
		private static bool n_IsVisible_I(IntPtr jnienv, IntPtr native__this, int typeMask)
		{
			return Java.Lang.Object.GetObject<WindowInsetsCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsVisible(typeMask);
		}

		// Token: 0x06000AF5 RID: 2805 RVA: 0x00021870 File Offset: 0x0001FA70
		[Register("isVisible", "(I)Z", "GetIsVisible_IHandler")]
		public unsafe virtual bool IsVisible(int typeMask)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(typeMask);
			return WindowInsetsCompat._members.InstanceMethods.InvokeVirtualBooleanMethod("isVisible.(I)Z", this, ptr);
		}

		// Token: 0x06000AF6 RID: 2806 RVA: 0x000218AB File Offset: 0x0001FAAB
		private static Delegate GetReplaceSystemWindowInsets_Landroid_graphics_Rect_Handler()
		{
			if (WindowInsetsCompat.cb_replaceSystemWindowInsets_Landroid_graphics_Rect_ == null)
			{
				WindowInsetsCompat.cb_replaceSystemWindowInsets_Landroid_graphics_Rect_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(WindowInsetsCompat.n_ReplaceSystemWindowInsets_Landroid_graphics_Rect_));
			}
			return WindowInsetsCompat.cb_replaceSystemWindowInsets_Landroid_graphics_Rect_;
		}

		// Token: 0x06000AF7 RID: 2807 RVA: 0x000218D0 File Offset: 0x0001FAD0
		private static IntPtr n_ReplaceSystemWindowInsets_Landroid_graphics_Rect_(IntPtr jnienv, IntPtr native__this, IntPtr native_systemWindowInsets)
		{
			WindowInsetsCompat @object = Java.Lang.Object.GetObject<WindowInsetsCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Rect object2 = Java.Lang.Object.GetObject<Rect>(native_systemWindowInsets, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ReplaceSystemWindowInsets(object2));
		}

		// Token: 0x06000AF8 RID: 2808 RVA: 0x000218F8 File Offset: 0x0001FAF8
		[Register("replaceSystemWindowInsets", "(Landroid/graphics/Rect;)Landroidx/core/view/WindowInsetsCompat;", "GetReplaceSystemWindowInsets_Landroid_graphics_Rect_Handler")]
		public unsafe virtual WindowInsetsCompat ReplaceSystemWindowInsets(Rect systemWindowInsets)
		{
			WindowInsetsCompat @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((systemWindowInsets == null) ? IntPtr.Zero : systemWindowInsets.Handle);
				@object = Java.Lang.Object.GetObject<WindowInsetsCompat>(WindowInsetsCompat._members.InstanceMethods.InvokeVirtualObjectMethod("replaceSystemWindowInsets.(Landroid/graphics/Rect;)Landroidx/core/view/WindowInsetsCompat;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(systemWindowInsets);
			}
			return @object;
		}

		// Token: 0x06000AF9 RID: 2809 RVA: 0x0002196C File Offset: 0x0001FB6C
		private static Delegate GetReplaceSystemWindowInsets_IIIIHandler()
		{
			if (WindowInsetsCompat.cb_replaceSystemWindowInsets_IIII == null)
			{
				WindowInsetsCompat.cb_replaceSystemWindowInsets_IIII = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIIII_L(WindowInsetsCompat.n_ReplaceSystemWindowInsets_IIII));
			}
			return WindowInsetsCompat.cb_replaceSystemWindowInsets_IIII;
		}

		// Token: 0x06000AFA RID: 2810 RVA: 0x00021990 File Offset: 0x0001FB90
		private static IntPtr n_ReplaceSystemWindowInsets_IIII(IntPtr jnienv, IntPtr native__this, int left, int top, int right, int bottom)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<WindowInsetsCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ReplaceSystemWindowInsets(left, top, right, bottom));
		}

		// Token: 0x06000AFB RID: 2811 RVA: 0x000219AC File Offset: 0x0001FBAC
		[Register("replaceSystemWindowInsets", "(IIII)Landroidx/core/view/WindowInsetsCompat;", "GetReplaceSystemWindowInsets_IIIIHandler")]
		public unsafe virtual WindowInsetsCompat ReplaceSystemWindowInsets(int left, int top, int right, int bottom)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(left);
			ptr[1] = new JniArgumentValue(top);
			ptr[2] = new JniArgumentValue(right);
			ptr[3] = new JniArgumentValue(bottom);
			return Java.Lang.Object.GetObject<WindowInsetsCompat>(WindowInsetsCompat._members.InstanceMethods.InvokeVirtualObjectMethod("replaceSystemWindowInsets.(IIII)Landroidx/core/view/WindowInsetsCompat;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000AFC RID: 2812 RVA: 0x00021A35 File Offset: 0x0001FC35
		private static Delegate GetToWindowInsetsHandler()
		{
			if (WindowInsetsCompat.cb_toWindowInsets == null)
			{
				WindowInsetsCompat.cb_toWindowInsets = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(WindowInsetsCompat.n_ToWindowInsets));
			}
			return WindowInsetsCompat.cb_toWindowInsets;
		}

		// Token: 0x06000AFD RID: 2813 RVA: 0x00021A59 File Offset: 0x0001FC59
		private static IntPtr n_ToWindowInsets(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<WindowInsetsCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToWindowInsets());
		}

		// Token: 0x06000AFE RID: 2814 RVA: 0x00021A70 File Offset: 0x0001FC70
		[Register("toWindowInsets", "()Landroid/view/WindowInsets;", "GetToWindowInsetsHandler")]
		public virtual WindowInsets ToWindowInsets()
		{
			return Java.Lang.Object.GetObject<WindowInsets>(WindowInsetsCompat._members.InstanceMethods.InvokeVirtualObjectMethod("toWindowInsets.()Landroid/view/WindowInsets;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000AFF RID: 2815 RVA: 0x00021AA4 File Offset: 0x0001FCA4
		[Register("toWindowInsetsCompat", "(Landroid/view/WindowInsets;)Landroidx/core/view/WindowInsetsCompat;", "")]
		public unsafe static WindowInsetsCompat ToWindowInsetsCompat(WindowInsets insets)
		{
			WindowInsetsCompat @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((insets == null) ? IntPtr.Zero : insets.Handle);
				@object = Java.Lang.Object.GetObject<WindowInsetsCompat>(WindowInsetsCompat._members.StaticMethods.InvokeObjectMethod("toWindowInsetsCompat.(Landroid/view/WindowInsets;)Landroidx/core/view/WindowInsetsCompat;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(insets);
			}
			return @object;
		}

		// Token: 0x06000B00 RID: 2816 RVA: 0x00021B18 File Offset: 0x0001FD18
		[Register("toWindowInsetsCompat", "(Landroid/view/WindowInsets;Landroid/view/View;)Landroidx/core/view/WindowInsetsCompat;", "")]
		public unsafe static WindowInsetsCompat ToWindowInsetsCompat(WindowInsets insets, View view)
		{
			WindowInsetsCompat @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((insets == null) ? IntPtr.Zero : insets.Handle);
				ptr[1] = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
				@object = Java.Lang.Object.GetObject<WindowInsetsCompat>(WindowInsetsCompat._members.StaticMethods.InvokeObjectMethod("toWindowInsetsCompat.(Landroid/view/WindowInsets;Landroid/view/View;)Landroidx/core/view/WindowInsetsCompat;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(insets);
				GC.KeepAlive(view);
			}
			return @object;
		}

		// Token: 0x04000329 RID: 809
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/view/WindowInsetsCompat", typeof(WindowInsetsCompat));

		// Token: 0x0400032A RID: 810
		private static Delegate cb_getDisplayCutout;

		// Token: 0x0400032B RID: 811
		private static Delegate cb_hasInsets;

		// Token: 0x0400032C RID: 812
		private static Delegate cb_hasStableInsets;

		// Token: 0x0400032D RID: 813
		private static Delegate cb_hasSystemWindowInsets;

		// Token: 0x0400032E RID: 814
		private static Delegate cb_isConsumed;

		// Token: 0x0400032F RID: 815
		private static Delegate cb_isRound;

		// Token: 0x04000330 RID: 816
		private static Delegate cb_getMandatorySystemGestureInsets;

		// Token: 0x04000331 RID: 817
		private static Delegate cb_getStableInsetBottom;

		// Token: 0x04000332 RID: 818
		private static Delegate cb_getStableInsetLeft;

		// Token: 0x04000333 RID: 819
		private static Delegate cb_getStableInsetRight;

		// Token: 0x04000334 RID: 820
		private static Delegate cb_getStableInsetTop;

		// Token: 0x04000335 RID: 821
		private static Delegate cb_getStableInsets;

		// Token: 0x04000336 RID: 822
		private static Delegate cb_getSystemGestureInsets;

		// Token: 0x04000337 RID: 823
		private static Delegate cb_getSystemWindowInsetBottom;

		// Token: 0x04000338 RID: 824
		private static Delegate cb_getSystemWindowInsetLeft;

		// Token: 0x04000339 RID: 825
		private static Delegate cb_getSystemWindowInsetRight;

		// Token: 0x0400033A RID: 826
		private static Delegate cb_getSystemWindowInsetTop;

		// Token: 0x0400033B RID: 827
		private static Delegate cb_getSystemWindowInsets;

		// Token: 0x0400033C RID: 828
		private static Delegate cb_getTappableElementInsets;

		// Token: 0x0400033D RID: 829
		private static Delegate cb_consumeDisplayCutout;

		// Token: 0x0400033E RID: 830
		private static Delegate cb_consumeStableInsets;

		// Token: 0x0400033F RID: 831
		private static Delegate cb_consumeSystemWindowInsets;

		// Token: 0x04000340 RID: 832
		private static Delegate cb_getInsets_I;

		// Token: 0x04000341 RID: 833
		private static Delegate cb_getInsetsIgnoringVisibility_I;

		// Token: 0x04000342 RID: 834
		private static Delegate cb_inset_Landroidx_core_graphics_Insets_;

		// Token: 0x04000343 RID: 835
		private static Delegate cb_inset_IIII;

		// Token: 0x04000344 RID: 836
		private static Delegate cb_isVisible_I;

		// Token: 0x04000345 RID: 837
		private static Delegate cb_replaceSystemWindowInsets_Landroid_graphics_Rect_;

		// Token: 0x04000346 RID: 838
		private static Delegate cb_replaceSystemWindowInsets_IIII;

		// Token: 0x04000347 RID: 839
		private static Delegate cb_toWindowInsets;
	}
}
