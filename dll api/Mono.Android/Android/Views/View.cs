using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Content;
using Android.Content.Res;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views.Accessibility;
using Android.Views.Animations;
using Java.Interop;
using Java.Lang;

namespace Android.Views
{
	// Token: 0x0200013E RID: 318
	[Register("android/view/View", DoNotGenerateAcw = true)]
	public class View : Java.Lang.Object, Drawable.ICallback, IJavaObject, IDisposable, IJavaPeerable, IAccessibilityEventSource, KeyEvent.ICallback
	{
		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000A9B RID: 2715 RVA: 0x0001A963 File Offset: 0x00018B63
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return View._members;
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000A9C RID: 2716 RVA: 0x0001A96C File Offset: 0x00018B6C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return View._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000A9D RID: 2717 RVA: 0x0001A990 File Offset: 0x00018B90
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return View._members.ManagedPeerType;
			}
		}

		// Token: 0x06000A9E RID: 2718 RVA: 0x000021E0 File Offset: 0x000003E0
		protected View(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000A9F RID: 2719 RVA: 0x0001A99C File Offset: 0x00018B9C
		public unsafe View(Context context, IAttributeSet attrs) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((attrs == null) ? IntPtr.Zero : ((Java.Lang.Object)attrs).Handle);
				base.SetHandle(View._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				View._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x06000AA0 RID: 2720 RVA: 0x0001AA78 File Offset: 0x00018C78
		public unsafe View(Context context, IAttributeSet attrs, int defStyleAttr) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((attrs == null) ? IntPtr.Zero : ((Java.Lang.Object)attrs).Handle);
				ptr[2] = new JniArgumentValue(defStyleAttr);
				base.SetHandle(View._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				View._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x06000AA1 RID: 2721 RVA: 0x0001AB68 File Offset: 0x00018D68
		private static Delegate GetSetBackground_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (View.cb_setBackground_Landroid_graphics_drawable_Drawable_ == null)
			{
				View.cb_setBackground_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(View.n_SetBackground_Landroid_graphics_drawable_Drawable_));
			}
			return View.cb_setBackground_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x06000AA2 RID: 2722 RVA: 0x0001AB8C File Offset: 0x00018D8C
		private static void n_SetBackground_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_background)
		{
			View @object = Java.Lang.Object.GetObject<View>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_background, JniHandleOwnership.DoNotTransfer);
			@object.Background = object2;
		}

		// Token: 0x17000215 RID: 533
		// (set) Token: 0x06000AA3 RID: 2723 RVA: 0x0001ABB0 File Offset: 0x00018DB0
		public unsafe virtual Drawable Background
		{
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					View._members.InstanceMethods.InvokeVirtualVoidMethod("setBackground.(Landroid/graphics/drawable/Drawable;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x06000AA4 RID: 2724 RVA: 0x0001AC14 File Offset: 0x00018E14
		private static Delegate GetSetClickable_ZHandler()
		{
			if (View.cb_setClickable_Z == null)
			{
				View.cb_setClickable_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(View.n_SetClickable_Z));
			}
			return View.cb_setClickable_Z;
		}

		// Token: 0x06000AA5 RID: 2725 RVA: 0x0001AC38 File Offset: 0x00018E38
		private static void n_SetClickable_Z(IntPtr jnienv, IntPtr native__this, bool clickable)
		{
			Java.Lang.Object.GetObject<View>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Clickable = clickable;
		}

		// Token: 0x17000216 RID: 534
		// (set) Token: 0x06000AA6 RID: 2726 RVA: 0x0001AC48 File Offset: 0x00018E48
		public unsafe virtual bool Clickable
		{
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				View._members.InstanceMethods.InvokeVirtualVoidMethod("setClickable.(Z)V", this, ptr);
			}
		}

		// Token: 0x17000217 RID: 535
		// (set) Token: 0x06000AA7 RID: 2727 RVA: 0x0001AC84 File Offset: 0x00018E84
		public unsafe bool ClipToOutline
		{
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				View._members.InstanceMethods.InvokeVirtualVoidMethod("setClipToOutline.(Z)V", this, ptr);
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06000AA8 RID: 2728 RVA: 0x0001ACC0 File Offset: 0x00018EC0
		public Context Context
		{
			get
			{
				return Java.Lang.Object.GetObject<Context>(View._members.InstanceMethods.InvokeNonvirtualObjectMethod("getContext.()Landroid/content/Context;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000AA9 RID: 2729 RVA: 0x0001ACF2 File Offset: 0x00018EF2
		private static Delegate GetIsEnabledHandler()
		{
			if (View.cb_isEnabled == null)
			{
				View.cb_isEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(View.n_IsEnabled));
			}
			return View.cb_isEnabled;
		}

		// Token: 0x06000AAA RID: 2730 RVA: 0x0001AD16 File Offset: 0x00018F16
		private static bool n_IsEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<View>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Enabled;
		}

		// Token: 0x06000AAB RID: 2731 RVA: 0x0001AD25 File Offset: 0x00018F25
		private static Delegate GetSetEnabled_ZHandler()
		{
			if (View.cb_setEnabled_Z == null)
			{
				View.cb_setEnabled_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(View.n_SetEnabled_Z));
			}
			return View.cb_setEnabled_Z;
		}

		// Token: 0x06000AAC RID: 2732 RVA: 0x0001AD49 File Offset: 0x00018F49
		private static void n_SetEnabled_Z(IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			Java.Lang.Object.GetObject<View>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Enabled = enabled;
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06000AAD RID: 2733 RVA: 0x0001AD59 File Offset: 0x00018F59
		// (set) Token: 0x06000AAE RID: 2734 RVA: 0x0001AD74 File Offset: 0x00018F74
		public unsafe virtual bool Enabled
		{
			get
			{
				return View._members.InstanceMethods.InvokeVirtualBooleanMethod("isEnabled.()Z", this, null);
			}
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				View._members.InstanceMethods.InvokeVirtualVoidMethod("setEnabled.(Z)V", this, ptr);
			}
		}

		// Token: 0x06000AAF RID: 2735 RVA: 0x0001ADAF File Offset: 0x00018FAF
		private static Delegate GetHasNestedScrollingParentHandler()
		{
			if (View.cb_hasNestedScrollingParent == null)
			{
				View.cb_hasNestedScrollingParent = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(View.n_HasNestedScrollingParent));
			}
			return View.cb_hasNestedScrollingParent;
		}

		// Token: 0x06000AB0 RID: 2736 RVA: 0x0001ADD3 File Offset: 0x00018FD3
		private static bool n_HasNestedScrollingParent(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<View>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HasNestedScrollingParent;
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06000AB1 RID: 2737 RVA: 0x0001ADE2 File Offset: 0x00018FE2
		public virtual bool HasNestedScrollingParent
		{
			get
			{
				return View._members.InstanceMethods.InvokeVirtualBooleanMethod("hasNestedScrollingParent.()Z", this, null);
			}
		}

		// Token: 0x06000AB2 RID: 2738 RVA: 0x0001ADFB File Offset: 0x00018FFB
		private static Delegate GetIsLayoutDirectionResolvedHandler()
		{
			if (View.cb_isLayoutDirectionResolved == null)
			{
				View.cb_isLayoutDirectionResolved = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(View.n_IsLayoutDirectionResolved));
			}
			return View.cb_isLayoutDirectionResolved;
		}

		// Token: 0x06000AB3 RID: 2739 RVA: 0x0001AE1F File Offset: 0x0001901F
		private static bool n_IsLayoutDirectionResolved(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<View>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsLayoutDirectionResolved;
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06000AB4 RID: 2740 RVA: 0x0001AE2E File Offset: 0x0001902E
		public virtual bool IsLayoutDirectionResolved
		{
			get
			{
				return View._members.InstanceMethods.InvokeVirtualBooleanMethod("isLayoutDirectionResolved.()Z", this, null);
			}
		}

		// Token: 0x06000AB5 RID: 2741 RVA: 0x0001AE47 File Offset: 0x00019047
		private static Delegate GetIsLayoutRequestedHandler()
		{
			if (View.cb_isLayoutRequested == null)
			{
				View.cb_isLayoutRequested = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(View.n_IsLayoutRequested));
			}
			return View.cb_isLayoutRequested;
		}

		// Token: 0x06000AB6 RID: 2742 RVA: 0x0001AE6B File Offset: 0x0001906B
		private static bool n_IsLayoutRequested(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<View>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsLayoutRequested;
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x06000AB7 RID: 2743 RVA: 0x0001AE7A File Offset: 0x0001907A
		public virtual bool IsLayoutRequested
		{
			get
			{
				return View._members.InstanceMethods.InvokeVirtualBooleanMethod("isLayoutRequested.()Z", this, null);
			}
		}

		// Token: 0x06000AB8 RID: 2744 RVA: 0x0001AE93 File Offset: 0x00019093
		private static Delegate GetIsTextAlignmentResolvedHandler()
		{
			if (View.cb_isTextAlignmentResolved == null)
			{
				View.cb_isTextAlignmentResolved = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(View.n_IsTextAlignmentResolved));
			}
			return View.cb_isTextAlignmentResolved;
		}

		// Token: 0x06000AB9 RID: 2745 RVA: 0x0001AEB7 File Offset: 0x000190B7
		private static bool n_IsTextAlignmentResolved(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<View>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsTextAlignmentResolved;
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06000ABA RID: 2746 RVA: 0x0001AEC6 File Offset: 0x000190C6
		public virtual bool IsTextAlignmentResolved
		{
			get
			{
				return View._members.InstanceMethods.InvokeVirtualBooleanMethod("isTextAlignmentResolved.()Z", this, null);
			}
		}

		// Token: 0x06000ABB RID: 2747 RVA: 0x0001AEDF File Offset: 0x000190DF
		private static Delegate GetIsTextDirectionResolvedHandler()
		{
			if (View.cb_isTextDirectionResolved == null)
			{
				View.cb_isTextDirectionResolved = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(View.n_IsTextDirectionResolved));
			}
			return View.cb_isTextDirectionResolved;
		}

		// Token: 0x06000ABC RID: 2748 RVA: 0x0001AF03 File Offset: 0x00019103
		private static bool n_IsTextDirectionResolved(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<View>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsTextDirectionResolved;
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06000ABD RID: 2749 RVA: 0x0001AF12 File Offset: 0x00019112
		public virtual bool IsTextDirectionResolved
		{
			get
			{
				return View._members.InstanceMethods.InvokeVirtualBooleanMethod("isTextDirectionResolved.()Z", this, null);
			}
		}

		// Token: 0x06000ABE RID: 2750 RVA: 0x0001AF2B File Offset: 0x0001912B
		private static Delegate GetGetLayoutDirectionHandler()
		{
			if (View.cb_getLayoutDirection == null)
			{
				View.cb_getLayoutDirection = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(View.n_GetLayoutDirection));
			}
			return View.cb_getLayoutDirection;
		}

		// Token: 0x06000ABF RID: 2751 RVA: 0x0001AF4F File Offset: 0x0001914F
		private static int n_GetLayoutDirection(IntPtr jnienv, IntPtr native__this)
		{
			return (int)Java.Lang.Object.GetObject<View>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LayoutDirection;
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06000AC0 RID: 2752 RVA: 0x0001AF5E File Offset: 0x0001915E
		public virtual LayoutDirection LayoutDirection
		{
			get
			{
				return (LayoutDirection)View._members.InstanceMethods.InvokeVirtualInt32Method("getLayoutDirection.()I", this, null);
			}
		}

		// Token: 0x06000AC1 RID: 2753 RVA: 0x0001AF77 File Offset: 0x00019177
		private static Delegate GetGetLayoutParametersHandler()
		{
			if (View.cb_getLayoutParams == null)
			{
				View.cb_getLayoutParams = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(View.n_GetLayoutParameters));
			}
			return View.cb_getLayoutParams;
		}

		// Token: 0x06000AC2 RID: 2754 RVA: 0x0001AF9B File Offset: 0x0001919B
		private static IntPtr n_GetLayoutParameters(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<View>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LayoutParameters);
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06000AC3 RID: 2755 RVA: 0x0001AFB0 File Offset: 0x000191B0
		public virtual ViewGroup.LayoutParams LayoutParameters
		{
			get
			{
				return Java.Lang.Object.GetObject<ViewGroup.LayoutParams>(View._members.InstanceMethods.InvokeVirtualObjectMethod("getLayoutParams.()Landroid/view/ViewGroup$LayoutParams;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06000AC4 RID: 2756 RVA: 0x0001AFE2 File Offset: 0x000191E2
		public int MeasuredHeight
		{
			get
			{
				return View._members.InstanceMethods.InvokeNonvirtualInt32Method("getMeasuredHeight.()I", this, null);
			}
		}

		// Token: 0x06000AC5 RID: 2757 RVA: 0x0001AFFB File Offset: 0x000191FB
		private static Delegate GetIsNestedScrollingEnabledHandler()
		{
			if (View.cb_isNestedScrollingEnabled == null)
			{
				View.cb_isNestedScrollingEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(View.n_IsNestedScrollingEnabled));
			}
			return View.cb_isNestedScrollingEnabled;
		}

		// Token: 0x06000AC6 RID: 2758 RVA: 0x0001B01F File Offset: 0x0001921F
		private static bool n_IsNestedScrollingEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<View>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NestedScrollingEnabled;
		}

		// Token: 0x06000AC7 RID: 2759 RVA: 0x0001B02E File Offset: 0x0001922E
		private static Delegate GetSetNestedScrollingEnabled_ZHandler()
		{
			if (View.cb_setNestedScrollingEnabled_Z == null)
			{
				View.cb_setNestedScrollingEnabled_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(View.n_SetNestedScrollingEnabled_Z));
			}
			return View.cb_setNestedScrollingEnabled_Z;
		}

		// Token: 0x06000AC8 RID: 2760 RVA: 0x0001B052 File Offset: 0x00019252
		private static void n_SetNestedScrollingEnabled_Z(IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			Java.Lang.Object.GetObject<View>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NestedScrollingEnabled = enabled;
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x06000AC9 RID: 2761 RVA: 0x0001B062 File Offset: 0x00019262
		// (set) Token: 0x06000ACA RID: 2762 RVA: 0x0001B07C File Offset: 0x0001927C
		public unsafe virtual bool NestedScrollingEnabled
		{
			get
			{
				return View._members.InstanceMethods.InvokeVirtualBooleanMethod("isNestedScrollingEnabled.()Z", this, null);
			}
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				View._members.InstanceMethods.InvokeVirtualVoidMethod("setNestedScrollingEnabled.(Z)V", this, ptr);
			}
		}

		// Token: 0x06000ACB RID: 2763 RVA: 0x0001B0B7 File Offset: 0x000192B7
		private static Delegate GetSetOverScrollMode_IHandler()
		{
			if (View.cb_setOverScrollMode_I == null)
			{
				View.cb_setOverScrollMode_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(View.n_SetOverScrollMode_I));
			}
			return View.cb_setOverScrollMode_I;
		}

		// Token: 0x06000ACC RID: 2764 RVA: 0x0001B0DC File Offset: 0x000192DC
		private static void n_SetOverScrollMode_I(IntPtr jnienv, IntPtr native__this, int native_overScrollMode)
		{
			Java.Lang.Object.GetObject<View>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OverScrollMode = (OverScrollMode)native_overScrollMode;
		}

		// Token: 0x17000223 RID: 547
		// (set) Token: 0x06000ACD RID: 2765 RVA: 0x0001B0FC File Offset: 0x000192FC
		public unsafe virtual OverScrollMode OverScrollMode
		{
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((int)value);
				View._members.InstanceMethods.InvokeVirtualVoidMethod("setOverScrollMode.(I)V", this, ptr);
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06000ACE RID: 2766 RVA: 0x0001B138 File Offset: 0x00019338
		public IViewParent Parent
		{
			get
			{
				return Java.Lang.Object.GetObject<IViewParent>(View._members.InstanceMethods.InvokeNonvirtualObjectMethod("getParent.()Landroid/view/ViewParent;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000ACF RID: 2767 RVA: 0x0001B16A File Offset: 0x0001936A
		private static Delegate GetGetParentForAccessibilityHandler()
		{
			if (View.cb_getParentForAccessibility == null)
			{
				View.cb_getParentForAccessibility = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(View.n_GetParentForAccessibility));
			}
			return View.cb_getParentForAccessibility;
		}

		// Token: 0x06000AD0 RID: 2768 RVA: 0x0001B18E File Offset: 0x0001938E
		private static IntPtr n_GetParentForAccessibility(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<View>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ParentForAccessibility);
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06000AD1 RID: 2769 RVA: 0x0001B1A4 File Offset: 0x000193A4
		public virtual IViewParent ParentForAccessibility
		{
			get
			{
				return Java.Lang.Object.GetObject<IViewParent>(View._members.InstanceMethods.InvokeVirtualObjectMethod("getParentForAccessibility.()Landroid/view/ViewParent;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000AD2 RID: 2770 RVA: 0x0001B1D6 File Offset: 0x000193D6
		private static Delegate GetGetResourcesHandler()
		{
			if (View.cb_getResources == null)
			{
				View.cb_getResources = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(View.n_GetResources));
			}
			return View.cb_getResources;
		}

		// Token: 0x06000AD3 RID: 2771 RVA: 0x0001B1FA File Offset: 0x000193FA
		private static IntPtr n_GetResources(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<View>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Resources);
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000AD4 RID: 2772 RVA: 0x0001B210 File Offset: 0x00019410
		public virtual Resources Resources
		{
			get
			{
				return Java.Lang.Object.GetObject<Resources>(View._members.InstanceMethods.InvokeVirtualObjectMethod("getResources.()Landroid/content/res/Resources;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000AD5 RID: 2773 RVA: 0x0001B242 File Offset: 0x00019442
		private static Delegate GetSetScaleY_FHandler()
		{
			if (View.cb_setScaleY_F == null)
			{
				View.cb_setScaleY_F = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPF_V(View.n_SetScaleY_F));
			}
			return View.cb_setScaleY_F;
		}

		// Token: 0x06000AD6 RID: 2774 RVA: 0x0001B266 File Offset: 0x00019466
		private static void n_SetScaleY_F(IntPtr jnienv, IntPtr native__this, float scaleY)
		{
			Java.Lang.Object.GetObject<View>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ScaleY = scaleY;
		}

		// Token: 0x17000227 RID: 551
		// (set) Token: 0x06000AD7 RID: 2775 RVA: 0x0001B278 File Offset: 0x00019478
		public unsafe virtual float ScaleY
		{
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				View._members.InstanceMethods.InvokeVirtualVoidMethod("setScaleY.(F)V", this, ptr);
			}
		}

		// Token: 0x06000AD8 RID: 2776 RVA: 0x0001B2B3 File Offset: 0x000194B3
		private static Delegate GetIsSelectedHandler()
		{
			if (View.cb_isSelected == null)
			{
				View.cb_isSelected = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(View.n_IsSelected));
			}
			return View.cb_isSelected;
		}

		// Token: 0x06000AD9 RID: 2777 RVA: 0x0001B2D7 File Offset: 0x000194D7
		private static bool n_IsSelected(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<View>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Selected;
		}

		// Token: 0x06000ADA RID: 2778 RVA: 0x0001B2E6 File Offset: 0x000194E6
		private static Delegate GetSetSelected_ZHandler()
		{
			if (View.cb_setSelected_Z == null)
			{
				View.cb_setSelected_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(View.n_SetSelected_Z));
			}
			return View.cb_setSelected_Z;
		}

		// Token: 0x06000ADB RID: 2779 RVA: 0x0001B30A File Offset: 0x0001950A
		private static void n_SetSelected_Z(IntPtr jnienv, IntPtr native__this, bool selected)
		{
			Java.Lang.Object.GetObject<View>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Selected = selected;
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06000ADC RID: 2780 RVA: 0x0001B31A File Offset: 0x0001951A
		// (set) Token: 0x06000ADD RID: 2781 RVA: 0x0001B334 File Offset: 0x00019534
		public unsafe virtual bool Selected
		{
			get
			{
				return View._members.InstanceMethods.InvokeVirtualBooleanMethod("isSelected.()Z", this, null);
			}
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				View._members.InstanceMethods.InvokeVirtualVoidMethod("setSelected.(Z)V", this, ptr);
			}
		}

		// Token: 0x06000ADE RID: 2782 RVA: 0x0001B36F File Offset: 0x0001956F
		private static Delegate GetGetSystemUiVisibilityHandler()
		{
			if (View.cb_getSystemUiVisibility == null)
			{
				View.cb_getSystemUiVisibility = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(View.n_GetSystemUiVisibility));
			}
			return View.cb_getSystemUiVisibility;
		}

		// Token: 0x06000ADF RID: 2783 RVA: 0x0001B393 File Offset: 0x00019593
		private static int n_GetSystemUiVisibility(IntPtr jnienv, IntPtr native__this)
		{
			return (int)Java.Lang.Object.GetObject<View>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SystemUiVisibility;
		}

		// Token: 0x06000AE0 RID: 2784 RVA: 0x0001B3A2 File Offset: 0x000195A2
		private static Delegate GetSetSystemUiVisibility_IHandler()
		{
			if (View.cb_setSystemUiVisibility_I == null)
			{
				View.cb_setSystemUiVisibility_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(View.n_SetSystemUiVisibility_I));
			}
			return View.cb_setSystemUiVisibility_I;
		}

		// Token: 0x06000AE1 RID: 2785 RVA: 0x0001B3C8 File Offset: 0x000195C8
		private static void n_SetSystemUiVisibility_I(IntPtr jnienv, IntPtr native__this, int native_visibility)
		{
			Java.Lang.Object.GetObject<View>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SystemUiVisibility = (StatusBarVisibility)native_visibility;
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x06000AE2 RID: 2786 RVA: 0x0001B3E5 File Offset: 0x000195E5
		// (set) Token: 0x06000AE3 RID: 2787 RVA: 0x0001B400 File Offset: 0x00019600
		public unsafe virtual StatusBarVisibility SystemUiVisibility
		{
			get
			{
				return (StatusBarVisibility)View._members.InstanceMethods.InvokeVirtualInt32Method("getSystemUiVisibility.()I", this, null);
			}
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((int)value);
				View._members.InstanceMethods.InvokeVirtualVoidMethod("setSystemUiVisibility.(I)V", this, ptr);
			}
		}

		// Token: 0x06000AE4 RID: 2788 RVA: 0x0001B43B File Offset: 0x0001963B
		private static Delegate GetGetTextAlignmentHandler()
		{
			if (View.cb_getTextAlignment == null)
			{
				View.cb_getTextAlignment = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(View.n_GetTextAlignment));
			}
			return View.cb_getTextAlignment;
		}

		// Token: 0x06000AE5 RID: 2789 RVA: 0x0001B45F File Offset: 0x0001965F
		private static int n_GetTextAlignment(IntPtr jnienv, IntPtr native__this)
		{
			return (int)Java.Lang.Object.GetObject<View>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TextAlignment;
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x06000AE6 RID: 2790 RVA: 0x0001B46E File Offset: 0x0001966E
		public virtual TextAlignment TextAlignment
		{
			get
			{
				return (TextAlignment)View._members.InstanceMethods.InvokeVirtualInt32Method("getTextAlignment.()I", this, null);
			}
		}

		// Token: 0x06000AE7 RID: 2791 RVA: 0x0001B487 File Offset: 0x00019687
		private static Delegate GetGetTextDirectionHandler()
		{
			if (View.cb_getTextDirection == null)
			{
				View.cb_getTextDirection = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(View.n_GetTextDirection));
			}
			return View.cb_getTextDirection;
		}

		// Token: 0x06000AE8 RID: 2792 RVA: 0x0001B4AB File Offset: 0x000196AB
		private static int n_GetTextDirection(IntPtr jnienv, IntPtr native__this)
		{
			return (int)Java.Lang.Object.GetObject<View>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TextDirection;
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06000AE9 RID: 2793 RVA: 0x0001B4BA File Offset: 0x000196BA
		public virtual TextDirection TextDirection
		{
			get
			{
				return (TextDirection)View._members.InstanceMethods.InvokeVirtualInt32Method("getTextDirection.()I", this, null);
			}
		}

		// Token: 0x06000AEA RID: 2794 RVA: 0x0001B4D3 File Offset: 0x000196D3
		private static Delegate GetSetTranslationX_FHandler()
		{
			if (View.cb_setTranslationX_F == null)
			{
				View.cb_setTranslationX_F = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPF_V(View.n_SetTranslationX_F));
			}
			return View.cb_setTranslationX_F;
		}

		// Token: 0x06000AEB RID: 2795 RVA: 0x0001B4F7 File Offset: 0x000196F7
		private static void n_SetTranslationX_F(IntPtr jnienv, IntPtr native__this, float translationX)
		{
			Java.Lang.Object.GetObject<View>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TranslationX = translationX;
		}

		// Token: 0x1700022C RID: 556
		// (set) Token: 0x06000AEC RID: 2796 RVA: 0x0001B508 File Offset: 0x00019708
		public unsafe virtual float TranslationX
		{
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				View._members.InstanceMethods.InvokeVirtualVoidMethod("setTranslationX.(F)V", this, ptr);
			}
		}

		// Token: 0x06000AED RID: 2797 RVA: 0x0001B543 File Offset: 0x00019743
		private static Delegate GetGetVisibilityHandler()
		{
			if (View.cb_getVisibility == null)
			{
				View.cb_getVisibility = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(View.n_GetVisibility));
			}
			return View.cb_getVisibility;
		}

		// Token: 0x06000AEE RID: 2798 RVA: 0x0001B567 File Offset: 0x00019767
		private static int n_GetVisibility(IntPtr jnienv, IntPtr native__this)
		{
			return (int)Java.Lang.Object.GetObject<View>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Visibility;
		}

		// Token: 0x06000AEF RID: 2799 RVA: 0x0001B576 File Offset: 0x00019776
		private static Delegate GetSetVisibility_IHandler()
		{
			if (View.cb_setVisibility_I == null)
			{
				View.cb_setVisibility_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(View.n_SetVisibility_I));
			}
			return View.cb_setVisibility_I;
		}

		// Token: 0x06000AF0 RID: 2800 RVA: 0x0001B59C File Offset: 0x0001979C
		private static void n_SetVisibility_I(IntPtr jnienv, IntPtr native__this, int native_visibility)
		{
			Java.Lang.Object.GetObject<View>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Visibility = (ViewStates)native_visibility;
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06000AF1 RID: 2801 RVA: 0x0001B5B9 File Offset: 0x000197B9
		// (set) Token: 0x06000AF2 RID: 2802 RVA: 0x0001B5D4 File Offset: 0x000197D4
		public unsafe virtual ViewStates Visibility
		{
			get
			{
				return (ViewStates)View._members.InstanceMethods.InvokeVirtualInt32Method("getVisibility.()I", this, null);
			}
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((int)value);
				View._members.InstanceMethods.InvokeVirtualVoidMethod("setVisibility.(I)V", this, ptr);
			}
		}

		// Token: 0x06000AF3 RID: 2803 RVA: 0x0001B60F File Offset: 0x0001980F
		private static Delegate GetGetWindowTokenHandler()
		{
			if (View.cb_getWindowToken == null)
			{
				View.cb_getWindowToken = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(View.n_GetWindowToken));
			}
			return View.cb_getWindowToken;
		}

		// Token: 0x06000AF4 RID: 2804 RVA: 0x0001B633 File Offset: 0x00019833
		private static IntPtr n_GetWindowToken(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<View>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).WindowToken);
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06000AF5 RID: 2805 RVA: 0x0001B648 File Offset: 0x00019848
		public virtual IBinder WindowToken
		{
			get
			{
				return Java.Lang.Object.GetObject<IBinder>(View._members.InstanceMethods.InvokeVirtualObjectMethod("getWindowToken.()Landroid/os/IBinder;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000AF6 RID: 2806 RVA: 0x0001B67A File Offset: 0x0001987A
		private static Delegate GetAddTouchables_Ljava_util_ArrayList_Handler()
		{
			if (View.cb_addTouchables_Ljava_util_ArrayList_ == null)
			{
				View.cb_addTouchables_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(View.n_AddTouchables_Ljava_util_ArrayList_));
			}
			return View.cb_addTouchables_Ljava_util_ArrayList_;
		}

		// Token: 0x06000AF7 RID: 2807 RVA: 0x0001B6A0 File Offset: 0x000198A0
		private static void n_AddTouchables_Ljava_util_ArrayList_(IntPtr jnienv, IntPtr native__this, IntPtr native_views)
		{
			View @object = Java.Lang.Object.GetObject<View>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IList<View> views = JavaList<View>.FromJniHandle(native_views, JniHandleOwnership.DoNotTransfer);
			@object.AddTouchables(views);
		}

		// Token: 0x06000AF8 RID: 2808 RVA: 0x0001B6C4 File Offset: 0x000198C4
		public unsafe virtual void AddTouchables(IList<View> views)
		{
			IntPtr intPtr = JavaList<View>.ToLocalJniHandle(views);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				View._members.InstanceMethods.InvokeVirtualVoidMethod("addTouchables.(Ljava/util/ArrayList;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(views);
			}
		}

		// Token: 0x06000AF9 RID: 2809 RVA: 0x0001B728 File Offset: 0x00019928
		private static Delegate GetAnimateHandler()
		{
			if (View.cb_animate == null)
			{
				View.cb_animate = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(View.n_Animate));
			}
			return View.cb_animate;
		}

		// Token: 0x06000AFA RID: 2810 RVA: 0x0001B74C File Offset: 0x0001994C
		private static IntPtr n_Animate(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<View>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Animate());
		}

		// Token: 0x06000AFB RID: 2811 RVA: 0x0001B760 File Offset: 0x00019960
		public virtual ViewPropertyAnimator Animate()
		{
			return Java.Lang.Object.GetObject<ViewPropertyAnimator>(View._members.InstanceMethods.InvokeVirtualObjectMethod("animate.()Landroid/view/ViewPropertyAnimator;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000AFC RID: 2812 RVA: 0x0001B792 File Offset: 0x00019992
		private static Delegate GetCanResolveLayoutDirectionHandler()
		{
			if (View.cb_canResolveLayoutDirection == null)
			{
				View.cb_canResolveLayoutDirection = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(View.n_CanResolveLayoutDirection));
			}
			return View.cb_canResolveLayoutDirection;
		}

		// Token: 0x06000AFD RID: 2813 RVA: 0x0001B7B6 File Offset: 0x000199B6
		private static bool n_CanResolveLayoutDirection(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<View>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CanResolveLayoutDirection();
		}

		// Token: 0x06000AFE RID: 2814 RVA: 0x0001B7C5 File Offset: 0x000199C5
		public virtual bool CanResolveLayoutDirection()
		{
			return View._members.InstanceMethods.InvokeVirtualBooleanMethod("canResolveLayoutDirection.()Z", this, null);
		}

		// Token: 0x06000AFF RID: 2815 RVA: 0x0001B7DE File Offset: 0x000199DE
		private static Delegate GetCanResolveTextAlignmentHandler()
		{
			if (View.cb_canResolveTextAlignment == null)
			{
				View.cb_canResolveTextAlignment = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(View.n_CanResolveTextAlignment));
			}
			return View.cb_canResolveTextAlignment;
		}

		// Token: 0x06000B00 RID: 2816 RVA: 0x0001B802 File Offset: 0x00019A02
		private static bool n_CanResolveTextAlignment(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<View>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CanResolveTextAlignment();
		}

		// Token: 0x06000B01 RID: 2817 RVA: 0x0001B811 File Offset: 0x00019A11
		public virtual bool CanResolveTextAlignment()
		{
			return View._members.InstanceMethods.InvokeVirtualBooleanMethod("canResolveTextAlignment.()Z", this, null);
		}

		// Token: 0x06000B02 RID: 2818 RVA: 0x0001B82A File Offset: 0x00019A2A
		private static Delegate GetCanResolveTextDirectionHandler()
		{
			if (View.cb_canResolveTextDirection == null)
			{
				View.cb_canResolveTextDirection = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(View.n_CanResolveTextDirection));
			}
			return View.cb_canResolveTextDirection;
		}

		// Token: 0x06000B03 RID: 2819 RVA: 0x0001B84E File Offset: 0x00019A4E
		private static bool n_CanResolveTextDirection(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<View>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CanResolveTextDirection();
		}

		// Token: 0x06000B04 RID: 2820 RVA: 0x0001B85D File Offset: 0x00019A5D
		public virtual bool CanResolveTextDirection()
		{
			return View._members.InstanceMethods.InvokeVirtualBooleanMethod("canResolveTextDirection.()Z", this, null);
		}

		// Token: 0x06000B05 RID: 2821 RVA: 0x0001B876 File Offset: 0x00019A76
		private static Delegate GetCanScrollHorizontally_IHandler()
		{
			if (View.cb_canScrollHorizontally_I == null)
			{
				View.cb_canScrollHorizontally_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_Z(View.n_CanScrollHorizontally_I));
			}
			return View.cb_canScrollHorizontally_I;
		}

		// Token: 0x06000B06 RID: 2822 RVA: 0x0001B89A File Offset: 0x00019A9A
		private static bool n_CanScrollHorizontally_I(IntPtr jnienv, IntPtr native__this, int direction)
		{
			return Java.Lang.Object.GetObject<View>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CanScrollHorizontally(direction);
		}

		// Token: 0x06000B07 RID: 2823 RVA: 0x0001B8AC File Offset: 0x00019AAC
		public unsafe virtual bool CanScrollHorizontally(int direction)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(direction);
			return View._members.InstanceMethods.InvokeVirtualBooleanMethod("canScrollHorizontally.(I)Z", this, ptr);
		}

		// Token: 0x06000B08 RID: 2824 RVA: 0x0001B8E7 File Offset: 0x00019AE7
		private static Delegate GetCanScrollVertically_IHandler()
		{
			if (View.cb_canScrollVertically_I == null)
			{
				View.cb_canScrollVertically_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_Z(View.n_CanScrollVertically_I));
			}
			return View.cb_canScrollVertically_I;
		}

		// Token: 0x06000B09 RID: 2825 RVA: 0x0001B90B File Offset: 0x00019B0B
		private static bool n_CanScrollVertically_I(IntPtr jnienv, IntPtr native__this, int direction)
		{
			return Java.Lang.Object.GetObject<View>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CanScrollVertically(direction);
		}

		// Token: 0x06000B0A RID: 2826 RVA: 0x0001B91C File Offset: 0x00019B1C
		public unsafe virtual bool CanScrollVertically(int direction)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(direction);
			return View._members.InstanceMethods.InvokeVirtualBooleanMethod("canScrollVertically.(I)Z", this, ptr);
		}

		// Token: 0x06000B0B RID: 2827 RVA: 0x0001B957 File Offset: 0x00019B57
		private static Delegate GetComputeHorizontalScrollExtentHandler()
		{
			if (View.cb_computeHorizontalScrollExtent == null)
			{
				View.cb_computeHorizontalScrollExtent = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(View.n_ComputeHorizontalScrollExtent));
			}
			return View.cb_computeHorizontalScrollExtent;
		}

		// Token: 0x06000B0C RID: 2828 RVA: 0x0001B97B File Offset: 0x00019B7B
		private static int n_ComputeHorizontalScrollExtent(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<View>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ComputeHorizontalScrollExtent();
		}

		// Token: 0x06000B0D RID: 2829 RVA: 0x0001B98A File Offset: 0x00019B8A
		protected virtual int ComputeHorizontalScrollExtent()
		{
			return View._members.InstanceMethods.InvokeVirtualInt32Method("computeHorizontalScrollExtent.()I", this, null);
		}

		// Token: 0x06000B0E RID: 2830 RVA: 0x0001B9A3 File Offset: 0x00019BA3
		private static Delegate GetComputeHorizontalScrollOffsetHandler()
		{
			if (View.cb_computeHorizontalScrollOffset == null)
			{
				View.cb_computeHorizontalScrollOffset = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(View.n_ComputeHorizontalScrollOffset));
			}
			return View.cb_computeHorizontalScrollOffset;
		}

		// Token: 0x06000B0F RID: 2831 RVA: 0x0001B9C7 File Offset: 0x00019BC7
		private static int n_ComputeHorizontalScrollOffset(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<View>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ComputeHorizontalScrollOffset();
		}

		// Token: 0x06000B10 RID: 2832 RVA: 0x0001B9D6 File Offset: 0x00019BD6
		protected virtual int ComputeHorizontalScrollOffset()
		{
			return View._members.InstanceMethods.InvokeVirtualInt32Method("computeHorizontalScrollOffset.()I", this, null);
		}

		// Token: 0x06000B11 RID: 2833 RVA: 0x0001B9EF File Offset: 0x00019BEF
		private static Delegate GetComputeHorizontalScrollRangeHandler()
		{
			if (View.cb_computeHorizontalScrollRange == null)
			{
				View.cb_computeHorizontalScrollRange = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(View.n_ComputeHorizontalScrollRange));
			}
			return View.cb_computeHorizontalScrollRange;
		}

		// Token: 0x06000B12 RID: 2834 RVA: 0x0001BA13 File Offset: 0x00019C13
		private static int n_ComputeHorizontalScrollRange(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<View>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ComputeHorizontalScrollRange();
		}

		// Token: 0x06000B13 RID: 2835 RVA: 0x0001BA22 File Offset: 0x00019C22
		protected virtual int ComputeHorizontalScrollRange()
		{
			return View._members.InstanceMethods.InvokeVirtualInt32Method("computeHorizontalScrollRange.()I", this, null);
		}

		// Token: 0x06000B14 RID: 2836 RVA: 0x0001BA3B File Offset: 0x00019C3B
		private static Delegate GetComputeVerticalScrollExtentHandler()
		{
			if (View.cb_computeVerticalScrollExtent == null)
			{
				View.cb_computeVerticalScrollExtent = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(View.n_ComputeVerticalScrollExtent));
			}
			return View.cb_computeVerticalScrollExtent;
		}

		// Token: 0x06000B15 RID: 2837 RVA: 0x0001BA5F File Offset: 0x00019C5F
		private static int n_ComputeVerticalScrollExtent(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<View>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ComputeVerticalScrollExtent();
		}

		// Token: 0x06000B16 RID: 2838 RVA: 0x0001BA6E File Offset: 0x00019C6E
		protected virtual int ComputeVerticalScrollExtent()
		{
			return View._members.InstanceMethods.InvokeVirtualInt32Method("computeVerticalScrollExtent.()I", this, null);
		}

		// Token: 0x06000B17 RID: 2839 RVA: 0x0001BA87 File Offset: 0x00019C87
		private static Delegate GetComputeVerticalScrollOffsetHandler()
		{
			if (View.cb_computeVerticalScrollOffset == null)
			{
				View.cb_computeVerticalScrollOffset = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(View.n_ComputeVerticalScrollOffset));
			}
			return View.cb_computeVerticalScrollOffset;
		}

		// Token: 0x06000B18 RID: 2840 RVA: 0x0001BAAB File Offset: 0x00019CAB
		private static int n_ComputeVerticalScrollOffset(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<View>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ComputeVerticalScrollOffset();
		}

		// Token: 0x06000B19 RID: 2841 RVA: 0x0001BABA File Offset: 0x00019CBA
		protected virtual int ComputeVerticalScrollOffset()
		{
			return View._members.InstanceMethods.InvokeVirtualInt32Method("computeVerticalScrollOffset.()I", this, null);
		}

		// Token: 0x06000B1A RID: 2842 RVA: 0x0001BAD3 File Offset: 0x00019CD3
		private static Delegate GetComputeVerticalScrollRangeHandler()
		{
			if (View.cb_computeVerticalScrollRange == null)
			{
				View.cb_computeVerticalScrollRange = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(View.n_ComputeVerticalScrollRange));
			}
			return View.cb_computeVerticalScrollRange;
		}

		// Token: 0x06000B1B RID: 2843 RVA: 0x0001BAF7 File Offset: 0x00019CF7
		private static int n_ComputeVerticalScrollRange(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<View>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ComputeVerticalScrollRange();
		}

		// Token: 0x06000B1C RID: 2844 RVA: 0x0001BB06 File Offset: 0x00019D06
		protected virtual int ComputeVerticalScrollRange()
		{
			return View._members.InstanceMethods.InvokeVirtualInt32Method("computeVerticalScrollRange.()I", this, null);
		}

		// Token: 0x06000B1D RID: 2845 RVA: 0x0001BB1F File Offset: 0x00019D1F
		private static Delegate GetCreateContextMenu_Landroid_view_ContextMenu_Handler()
		{
			if (View.cb_createContextMenu_Landroid_view_ContextMenu_ == null)
			{
				View.cb_createContextMenu_Landroid_view_ContextMenu_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(View.n_CreateContextMenu_Landroid_view_ContextMenu_));
			}
			return View.cb_createContextMenu_Landroid_view_ContextMenu_;
		}

		// Token: 0x06000B1E RID: 2846 RVA: 0x0001BB44 File Offset: 0x00019D44
		private static void n_CreateContextMenu_Landroid_view_ContextMenu_(IntPtr jnienv, IntPtr native__this, IntPtr native_menu)
		{
			View @object = Java.Lang.Object.GetObject<View>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IContextMenu object2 = Java.Lang.Object.GetObject<IContextMenu>(native_menu, JniHandleOwnership.DoNotTransfer);
			@object.CreateContextMenu(object2);
		}

		// Token: 0x06000B1F RID: 2847 RVA: 0x0001BB68 File Offset: 0x00019D68
		public unsafe virtual void CreateContextMenu(IContextMenu menu)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((menu == null) ? IntPtr.Zero : ((Java.Lang.Object)menu).Handle);
				View._members.InstanceMethods.InvokeVirtualVoidMethod("createContextMenu.(Landroid/view/ContextMenu;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(menu);
			}
		}

		// Token: 0x06000B20 RID: 2848 RVA: 0x0001BBD0 File Offset: 0x00019DD0
		private static Delegate GetDispatchKeyEvent_Landroid_view_KeyEvent_Handler()
		{
			if (View.cb_dispatchKeyEvent_Landroid_view_KeyEvent_ == null)
			{
				View.cb_dispatchKeyEvent_Landroid_view_KeyEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(View.n_DispatchKeyEvent_Landroid_view_KeyEvent_));
			}
			return View.cb_dispatchKeyEvent_Landroid_view_KeyEvent_;
		}

		// Token: 0x06000B21 RID: 2849 RVA: 0x0001BBF4 File Offset: 0x00019DF4
		private static bool n_DispatchKeyEvent_Landroid_view_KeyEvent_(IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			View @object = Java.Lang.Object.GetObject<View>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			KeyEvent object2 = Java.Lang.Object.GetObject<KeyEvent>(native_e, JniHandleOwnership.DoNotTransfer);
			return @object.DispatchKeyEvent(object2);
		}

		// Token: 0x06000B22 RID: 2850 RVA: 0x0001BC18 File Offset: 0x00019E18
		public unsafe virtual bool DispatchKeyEvent(KeyEvent e)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((e == null) ? IntPtr.Zero : e.Handle);
				result = View._members.InstanceMethods.InvokeVirtualBooleanMethod("dispatchKeyEvent.(Landroid/view/KeyEvent;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(e);
			}
			return result;
		}

		// Token: 0x06000B23 RID: 2851 RVA: 0x0001BC80 File Offset: 0x00019E80
		private static Delegate GetDispatchNestedFling_FFZHandler()
		{
			if (View.cb_dispatchNestedFling_FFZ == null)
			{
				View.cb_dispatchNestedFling_FFZ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPFFZ_Z(View.n_DispatchNestedFling_FFZ));
			}
			return View.cb_dispatchNestedFling_FFZ;
		}

		// Token: 0x06000B24 RID: 2852 RVA: 0x0001BCA4 File Offset: 0x00019EA4
		private static bool n_DispatchNestedFling_FFZ(IntPtr jnienv, IntPtr native__this, float velocityX, float velocityY, bool consumed)
		{
			return Java.Lang.Object.GetObject<View>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DispatchNestedFling(velocityX, velocityY, consumed);
		}

		// Token: 0x06000B25 RID: 2853 RVA: 0x0001BCB8 File Offset: 0x00019EB8
		public unsafe virtual bool DispatchNestedFling(float velocityX, float velocityY, bool consumed)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(velocityX);
			ptr[1] = new JniArgumentValue(velocityY);
			ptr[2] = new JniArgumentValue(consumed);
			return View._members.InstanceMethods.InvokeVirtualBooleanMethod("dispatchNestedFling.(FFZ)Z", this, ptr);
		}

		// Token: 0x06000B26 RID: 2854 RVA: 0x0001BD1C File Offset: 0x00019F1C
		private static Delegate GetDispatchNestedPreFling_FFHandler()
		{
			if (View.cb_dispatchNestedPreFling_FF == null)
			{
				View.cb_dispatchNestedPreFling_FF = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPFF_Z(View.n_DispatchNestedPreFling_FF));
			}
			return View.cb_dispatchNestedPreFling_FF;
		}

		// Token: 0x06000B27 RID: 2855 RVA: 0x0001BD40 File Offset: 0x00019F40
		private static bool n_DispatchNestedPreFling_FF(IntPtr jnienv, IntPtr native__this, float velocityX, float velocityY)
		{
			return Java.Lang.Object.GetObject<View>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DispatchNestedPreFling(velocityX, velocityY);
		}

		// Token: 0x06000B28 RID: 2856 RVA: 0x0001BD54 File Offset: 0x00019F54
		public unsafe virtual bool DispatchNestedPreFling(float velocityX, float velocityY)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(velocityX);
			ptr[1] = new JniArgumentValue(velocityY);
			return View._members.InstanceMethods.InvokeVirtualBooleanMethod("dispatchNestedPreFling.(FF)Z", this, ptr);
		}

		// Token: 0x06000B29 RID: 2857 RVA: 0x0001BDA2 File Offset: 0x00019FA2
		private static Delegate GetDispatchNestedPreScroll_IIarrayIarrayIHandler()
		{
			if (View.cb_dispatchNestedPreScroll_IIarrayIarrayI == null)
			{
				View.cb_dispatchNestedPreScroll_IIarrayIarrayI = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIILL_Z(View.n_DispatchNestedPreScroll_IIarrayIarrayI));
			}
			return View.cb_dispatchNestedPreScroll_IIarrayIarrayI;
		}

		// Token: 0x06000B2A RID: 2858 RVA: 0x0001BDC8 File Offset: 0x00019FC8
		private static bool n_DispatchNestedPreScroll_IIarrayIarrayI(IntPtr jnienv, IntPtr native__this, int dx, int dy, IntPtr native_consumed, IntPtr native_offsetInWindow)
		{
			View @object = Java.Lang.Object.GetObject<View>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] array = (int[])JNIEnv.GetArray(native_consumed, JniHandleOwnership.DoNotTransfer, typeof(int));
			int[] array2 = (int[])JNIEnv.GetArray(native_offsetInWindow, JniHandleOwnership.DoNotTransfer, typeof(int));
			bool result = @object.DispatchNestedPreScroll(dx, dy, array, array2);
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_consumed);
			}
			if (array2 != null)
			{
				JNIEnv.CopyArray(array2, native_offsetInWindow);
			}
			return result;
		}

		// Token: 0x06000B2B RID: 2859 RVA: 0x0001BE2C File Offset: 0x0001A02C
		public unsafe virtual bool DispatchNestedPreScroll(int dx, int dy, int[] consumed, int[] offsetInWindow)
		{
			IntPtr intPtr = JNIEnv.NewArray(consumed);
			IntPtr intPtr2 = JNIEnv.NewArray(offsetInWindow);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(dx);
				ptr[1] = new JniArgumentValue(dy);
				ptr[2] = new JniArgumentValue(intPtr);
				ptr[3] = new JniArgumentValue(intPtr2);
				result = View._members.InstanceMethods.InvokeVirtualBooleanMethod("dispatchNestedPreScroll.(II[I[I)Z", this, ptr);
			}
			finally
			{
				if (consumed != null)
				{
					JNIEnv.CopyArray(intPtr, consumed);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				if (offsetInWindow != null)
				{
					JNIEnv.CopyArray(intPtr2, offsetInWindow);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(consumed);
				GC.KeepAlive(offsetInWindow);
			}
			return result;
		}

		// Token: 0x06000B2C RID: 2860 RVA: 0x0001BEFC File Offset: 0x0001A0FC
		private static Delegate GetDispatchNestedScroll_IIIIarrayIHandler()
		{
			if (View.cb_dispatchNestedScroll_IIIIarrayI == null)
			{
				View.cb_dispatchNestedScroll_IIIIarrayI = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIIIIL_Z(View.n_DispatchNestedScroll_IIIIarrayI));
			}
			return View.cb_dispatchNestedScroll_IIIIarrayI;
		}

		// Token: 0x06000B2D RID: 2861 RVA: 0x0001BF20 File Offset: 0x0001A120
		private static bool n_DispatchNestedScroll_IIIIarrayI(IntPtr jnienv, IntPtr native__this, int dxConsumed, int dyConsumed, int dxUnconsumed, int dyUnconsumed, IntPtr native_offsetInWindow)
		{
			View @object = Java.Lang.Object.GetObject<View>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] array = (int[])JNIEnv.GetArray(native_offsetInWindow, JniHandleOwnership.DoNotTransfer, typeof(int));
			bool result = @object.DispatchNestedScroll(dxConsumed, dyConsumed, dxUnconsumed, dyUnconsumed, array);
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_offsetInWindow);
			}
			return result;
		}

		// Token: 0x06000B2E RID: 2862 RVA: 0x0001BF64 File Offset: 0x0001A164
		public unsafe virtual bool DispatchNestedScroll(int dxConsumed, int dyConsumed, int dxUnconsumed, int dyUnconsumed, int[] offsetInWindow)
		{
			IntPtr intPtr = JNIEnv.NewArray(offsetInWindow);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(dxConsumed);
				ptr[1] = new JniArgumentValue(dyConsumed);
				ptr[2] = new JniArgumentValue(dxUnconsumed);
				ptr[3] = new JniArgumentValue(dyUnconsumed);
				ptr[4] = new JniArgumentValue(intPtr);
				result = View._members.InstanceMethods.InvokeVirtualBooleanMethod("dispatchNestedScroll.(IIII[I)Z", this, ptr);
			}
			finally
			{
				if (offsetInWindow != null)
				{
					JNIEnv.CopyArray(intPtr, offsetInWindow);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(offsetInWindow);
			}
			return result;
		}

		// Token: 0x06000B2F RID: 2863 RVA: 0x0001C02C File Offset: 0x0001A22C
		private static Delegate GetDispatchRestoreInstanceState_Landroid_util_SparseArray_Handler()
		{
			if (View.cb_dispatchRestoreInstanceState_Landroid_util_SparseArray_ == null)
			{
				View.cb_dispatchRestoreInstanceState_Landroid_util_SparseArray_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(View.n_DispatchRestoreInstanceState_Landroid_util_SparseArray_));
			}
			return View.cb_dispatchRestoreInstanceState_Landroid_util_SparseArray_;
		}

		// Token: 0x06000B30 RID: 2864 RVA: 0x0001C050 File Offset: 0x0001A250
		private static void n_DispatchRestoreInstanceState_Landroid_util_SparseArray_(IntPtr jnienv, IntPtr native__this, IntPtr native_container)
		{
			View @object = Java.Lang.Object.GetObject<View>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			SparseArray object2 = Java.Lang.Object.GetObject<SparseArray>(native_container, JniHandleOwnership.DoNotTransfer);
			@object.DispatchRestoreInstanceState(object2);
		}

		// Token: 0x06000B31 RID: 2865 RVA: 0x0001C074 File Offset: 0x0001A274
		protected unsafe virtual void DispatchRestoreInstanceState(SparseArray container)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((container == null) ? IntPtr.Zero : container.Handle);
				View._members.InstanceMethods.InvokeVirtualVoidMethod("dispatchRestoreInstanceState.(Landroid/util/SparseArray;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(container);
			}
		}

		// Token: 0x06000B32 RID: 2866 RVA: 0x0001C0D8 File Offset: 0x0001A2D8
		private static Delegate GetDispatchSaveInstanceState_Landroid_util_SparseArray_Handler()
		{
			if (View.cb_dispatchSaveInstanceState_Landroid_util_SparseArray_ == null)
			{
				View.cb_dispatchSaveInstanceState_Landroid_util_SparseArray_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(View.n_DispatchSaveInstanceState_Landroid_util_SparseArray_));
			}
			return View.cb_dispatchSaveInstanceState_Landroid_util_SparseArray_;
		}

		// Token: 0x06000B33 RID: 2867 RVA: 0x0001C0FC File Offset: 0x0001A2FC
		private static void n_DispatchSaveInstanceState_Landroid_util_SparseArray_(IntPtr jnienv, IntPtr native__this, IntPtr native_container)
		{
			View @object = Java.Lang.Object.GetObject<View>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			SparseArray object2 = Java.Lang.Object.GetObject<SparseArray>(native_container, JniHandleOwnership.DoNotTransfer);
			@object.DispatchSaveInstanceState(object2);
		}

		// Token: 0x06000B34 RID: 2868 RVA: 0x0001C120 File Offset: 0x0001A320
		protected unsafe virtual void DispatchSaveInstanceState(SparseArray container)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((container == null) ? IntPtr.Zero : container.Handle);
				View._members.InstanceMethods.InvokeVirtualVoidMethod("dispatchSaveInstanceState.(Landroid/util/SparseArray;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(container);
			}
		}

		// Token: 0x06000B35 RID: 2869 RVA: 0x0001C184 File Offset: 0x0001A384
		public unsafe View FindViewById(int id)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(id);
			return Java.Lang.Object.GetObject<View>(View._members.InstanceMethods.InvokeNonvirtualObjectMethod("findViewById.(I)Landroid/view/View;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000B36 RID: 2870 RVA: 0x0001C1CD File Offset: 0x0001A3CD
		private static Delegate GetInvalidateDrawable_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (View.cb_invalidateDrawable_Landroid_graphics_drawable_Drawable_ == null)
			{
				View.cb_invalidateDrawable_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(View.n_InvalidateDrawable_Landroid_graphics_drawable_Drawable_));
			}
			return View.cb_invalidateDrawable_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x06000B37 RID: 2871 RVA: 0x0001C1F4 File Offset: 0x0001A3F4
		private static void n_InvalidateDrawable_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_drawable)
		{
			View @object = Java.Lang.Object.GetObject<View>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_drawable, JniHandleOwnership.DoNotTransfer);
			@object.InvalidateDrawable(object2);
		}

		// Token: 0x06000B38 RID: 2872 RVA: 0x0001C218 File Offset: 0x0001A418
		public unsafe virtual void InvalidateDrawable(Drawable drawable)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((drawable == null) ? IntPtr.Zero : drawable.Handle);
				View._members.InstanceMethods.InvokeVirtualVoidMethod("invalidateDrawable.(Landroid/graphics/drawable/Drawable;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(drawable);
			}
		}

		// Token: 0x06000B39 RID: 2873 RVA: 0x0001C27C File Offset: 0x0001A47C
		private static Delegate GetKeyboardNavigationClusterSearch_Landroid_view_View_IHandler()
		{
			if (View.cb_keyboardNavigationClusterSearch_Landroid_view_View_I == null)
			{
				View.cb_keyboardNavigationClusterSearch_Landroid_view_View_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_L(View.n_KeyboardNavigationClusterSearch_Landroid_view_View_I));
			}
			return View.cb_keyboardNavigationClusterSearch_Landroid_view_View_I;
		}

		// Token: 0x06000B3A RID: 2874 RVA: 0x0001C2A0 File Offset: 0x0001A4A0
		private static IntPtr n_KeyboardNavigationClusterSearch_Landroid_view_View_I(IntPtr jnienv, IntPtr native__this, IntPtr native_currentCluster, int native_direction)
		{
			View @object = Java.Lang.Object.GetObject<View>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_currentCluster, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.KeyboardNavigationClusterSearch(object2, (FocusSearchDirection)native_direction));
		}

		// Token: 0x06000B3B RID: 2875 RVA: 0x0001C2CC File Offset: 0x0001A4CC
		public unsafe virtual View KeyboardNavigationClusterSearch(View currentCluster, [GeneratedEnum] FocusSearchDirection direction)
		{
			View @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((currentCluster == null) ? IntPtr.Zero : currentCluster.Handle);
				ptr[1] = new JniArgumentValue((int)direction);
				@object = Java.Lang.Object.GetObject<View>(View._members.InstanceMethods.InvokeVirtualObjectMethod("keyboardNavigationClusterSearch.(Landroid/view/View;I)Landroid/view/View;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(currentCluster);
			}
			return @object;
		}

		// Token: 0x06000B3C RID: 2876 RVA: 0x0001C354 File Offset: 0x0001A554
		private static Delegate GetOnAttachedToWindowHandler()
		{
			if (View.cb_onAttachedToWindow == null)
			{
				View.cb_onAttachedToWindow = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(View.n_OnAttachedToWindow));
			}
			return View.cb_onAttachedToWindow;
		}

		// Token: 0x06000B3D RID: 2877 RVA: 0x0001C378 File Offset: 0x0001A578
		private static void n_OnAttachedToWindow(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<View>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnAttachedToWindow();
		}

		// Token: 0x06000B3E RID: 2878 RVA: 0x0001C387 File Offset: 0x0001A587
		protected virtual void OnAttachedToWindow()
		{
			View._members.InstanceMethods.InvokeVirtualVoidMethod("onAttachedToWindow.()V", this, null);
		}

		// Token: 0x06000B3F RID: 2879 RVA: 0x0001C3A0 File Offset: 0x0001A5A0
		private static Delegate GetOnDetachedFromWindowHandler()
		{
			if (View.cb_onDetachedFromWindow == null)
			{
				View.cb_onDetachedFromWindow = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(View.n_OnDetachedFromWindow));
			}
			return View.cb_onDetachedFromWindow;
		}

		// Token: 0x06000B40 RID: 2880 RVA: 0x0001C3C4 File Offset: 0x0001A5C4
		private static void n_OnDetachedFromWindow(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<View>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnDetachedFromWindow();
		}

		// Token: 0x06000B41 RID: 2881 RVA: 0x0001C3D3 File Offset: 0x0001A5D3
		protected virtual void OnDetachedFromWindow()
		{
			View._members.InstanceMethods.InvokeVirtualVoidMethod("onDetachedFromWindow.()V", this, null);
		}

		// Token: 0x06000B42 RID: 2882 RVA: 0x0001C3EC File Offset: 0x0001A5EC
		private static Delegate GetOnDraw_Landroid_graphics_Canvas_Handler()
		{
			if (View.cb_onDraw_Landroid_graphics_Canvas_ == null)
			{
				View.cb_onDraw_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(View.n_OnDraw_Landroid_graphics_Canvas_));
			}
			return View.cb_onDraw_Landroid_graphics_Canvas_;
		}

		// Token: 0x06000B43 RID: 2883 RVA: 0x0001C410 File Offset: 0x0001A610
		private static void n_OnDraw_Landroid_graphics_Canvas_(IntPtr jnienv, IntPtr native__this, IntPtr native_canvas)
		{
			View @object = Java.Lang.Object.GetObject<View>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Canvas object2 = Java.Lang.Object.GetObject<Canvas>(native_canvas, JniHandleOwnership.DoNotTransfer);
			@object.OnDraw(object2);
		}

		// Token: 0x06000B44 RID: 2884 RVA: 0x0001C434 File Offset: 0x0001A634
		protected unsafe virtual void OnDraw(Canvas canvas)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((canvas == null) ? IntPtr.Zero : canvas.Handle);
				View._members.InstanceMethods.InvokeVirtualVoidMethod("onDraw.(Landroid/graphics/Canvas;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(canvas);
			}
		}

		// Token: 0x06000B45 RID: 2885 RVA: 0x0001C498 File Offset: 0x0001A698
		private static Delegate GetOnKeyDown_ILandroid_view_KeyEvent_Handler()
		{
			if (View.cb_onKeyDown_ILandroid_view_KeyEvent_ == null)
			{
				View.cb_onKeyDown_ILandroid_view_KeyEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_Z(View.n_OnKeyDown_ILandroid_view_KeyEvent_));
			}
			return View.cb_onKeyDown_ILandroid_view_KeyEvent_;
		}

		// Token: 0x06000B46 RID: 2886 RVA: 0x0001C4BC File Offset: 0x0001A6BC
		private static bool n_OnKeyDown_ILandroid_view_KeyEvent_(IntPtr jnienv, IntPtr native__this, int native_keyCode, IntPtr native_e)
		{
			View @object = Java.Lang.Object.GetObject<View>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			KeyEvent object2 = Java.Lang.Object.GetObject<KeyEvent>(native_e, JniHandleOwnership.DoNotTransfer);
			return @object.OnKeyDown((Keycode)native_keyCode, object2);
		}

		// Token: 0x06000B47 RID: 2887 RVA: 0x0001C4E4 File Offset: 0x0001A6E4
		public unsafe virtual bool OnKeyDown([GeneratedEnum] Keycode keyCode, KeyEvent e)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((int)keyCode);
				ptr[1] = new JniArgumentValue((e == null) ? IntPtr.Zero : e.Handle);
				result = View._members.InstanceMethods.InvokeVirtualBooleanMethod("onKeyDown.(ILandroid/view/KeyEvent;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(e);
			}
			return result;
		}

		// Token: 0x06000B48 RID: 2888 RVA: 0x0001C55C File Offset: 0x0001A75C
		private static Delegate GetOnKeyLongPress_ILandroid_view_KeyEvent_Handler()
		{
			if (View.cb_onKeyLongPress_ILandroid_view_KeyEvent_ == null)
			{
				View.cb_onKeyLongPress_ILandroid_view_KeyEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_Z(View.n_OnKeyLongPress_ILandroid_view_KeyEvent_));
			}
			return View.cb_onKeyLongPress_ILandroid_view_KeyEvent_;
		}

		// Token: 0x06000B49 RID: 2889 RVA: 0x0001C580 File Offset: 0x0001A780
		private static bool n_OnKeyLongPress_ILandroid_view_KeyEvent_(IntPtr jnienv, IntPtr native__this, int native_keyCode, IntPtr native_e)
		{
			View @object = Java.Lang.Object.GetObject<View>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			KeyEvent object2 = Java.Lang.Object.GetObject<KeyEvent>(native_e, JniHandleOwnership.DoNotTransfer);
			return @object.OnKeyLongPress((Keycode)native_keyCode, object2);
		}

		// Token: 0x06000B4A RID: 2890 RVA: 0x0001C5A8 File Offset: 0x0001A7A8
		public unsafe virtual bool OnKeyLongPress([GeneratedEnum] Keycode keyCode, KeyEvent e)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((int)keyCode);
				ptr[1] = new JniArgumentValue((e == null) ? IntPtr.Zero : e.Handle);
				result = View._members.InstanceMethods.InvokeVirtualBooleanMethod("onKeyLongPress.(ILandroid/view/KeyEvent;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(e);
			}
			return result;
		}

		// Token: 0x06000B4B RID: 2891 RVA: 0x0001C620 File Offset: 0x0001A820
		private static Delegate GetOnKeyMultiple_IILandroid_view_KeyEvent_Handler()
		{
			if (View.cb_onKeyMultiple_IILandroid_view_KeyEvent_ == null)
			{
				View.cb_onKeyMultiple_IILandroid_view_KeyEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIIL_Z(View.n_OnKeyMultiple_IILandroid_view_KeyEvent_));
			}
			return View.cb_onKeyMultiple_IILandroid_view_KeyEvent_;
		}

		// Token: 0x06000B4C RID: 2892 RVA: 0x0001C644 File Offset: 0x0001A844
		private static bool n_OnKeyMultiple_IILandroid_view_KeyEvent_(IntPtr jnienv, IntPtr native__this, int native_keyCode, int repeatCount, IntPtr native_e)
		{
			View @object = Java.Lang.Object.GetObject<View>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			KeyEvent object2 = Java.Lang.Object.GetObject<KeyEvent>(native_e, JniHandleOwnership.DoNotTransfer);
			return @object.OnKeyMultiple((Keycode)native_keyCode, repeatCount, object2);
		}

		// Token: 0x06000B4D RID: 2893 RVA: 0x0001C66C File Offset: 0x0001A86C
		public unsafe virtual bool OnKeyMultiple([GeneratedEnum] Keycode keyCode, int repeatCount, KeyEvent e)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((int)keyCode);
				ptr[1] = new JniArgumentValue(repeatCount);
				ptr[2] = new JniArgumentValue((e == null) ? IntPtr.Zero : e.Handle);
				result = View._members.InstanceMethods.InvokeVirtualBooleanMethod("onKeyMultiple.(IILandroid/view/KeyEvent;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(e);
			}
			return result;
		}

		// Token: 0x06000B4E RID: 2894 RVA: 0x0001C6FC File Offset: 0x0001A8FC
		private static Delegate GetOnKeyUp_ILandroid_view_KeyEvent_Handler()
		{
			if (View.cb_onKeyUp_ILandroid_view_KeyEvent_ == null)
			{
				View.cb_onKeyUp_ILandroid_view_KeyEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_Z(View.n_OnKeyUp_ILandroid_view_KeyEvent_));
			}
			return View.cb_onKeyUp_ILandroid_view_KeyEvent_;
		}

		// Token: 0x06000B4F RID: 2895 RVA: 0x0001C720 File Offset: 0x0001A920
		private static bool n_OnKeyUp_ILandroid_view_KeyEvent_(IntPtr jnienv, IntPtr native__this, int native_keyCode, IntPtr native_e)
		{
			View @object = Java.Lang.Object.GetObject<View>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			KeyEvent object2 = Java.Lang.Object.GetObject<KeyEvent>(native_e, JniHandleOwnership.DoNotTransfer);
			return @object.OnKeyUp((Keycode)native_keyCode, object2);
		}

		// Token: 0x06000B50 RID: 2896 RVA: 0x0001C748 File Offset: 0x0001A948
		public unsafe virtual bool OnKeyUp([GeneratedEnum] Keycode keyCode, KeyEvent e)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((int)keyCode);
				ptr[1] = new JniArgumentValue((e == null) ? IntPtr.Zero : e.Handle);
				result = View._members.InstanceMethods.InvokeVirtualBooleanMethod("onKeyUp.(ILandroid/view/KeyEvent;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(e);
			}
			return result;
		}

		// Token: 0x06000B51 RID: 2897 RVA: 0x0001C7C0 File Offset: 0x0001A9C0
		private static Delegate GetOnLayout_ZIIIIHandler()
		{
			if (View.cb_onLayout_ZIIII == null)
			{
				View.cb_onLayout_ZIIII = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZIIII_V(View.n_OnLayout_ZIIII));
			}
			return View.cb_onLayout_ZIIII;
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x0001C7E4 File Offset: 0x0001A9E4
		private static void n_OnLayout_ZIIII(IntPtr jnienv, IntPtr native__this, bool changed, int left, int top, int right, int bottom)
		{
			Java.Lang.Object.GetObject<View>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnLayout(changed, left, top, right, bottom);
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x0001C7FC File Offset: 0x0001A9FC
		protected unsafe virtual void OnLayout(bool changed, int left, int top, int right, int bottom)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(changed);
			ptr[1] = new JniArgumentValue(left);
			ptr[2] = new JniArgumentValue(top);
			ptr[3] = new JniArgumentValue(right);
			ptr[4] = new JniArgumentValue(bottom);
			View._members.InstanceMethods.InvokeVirtualVoidMethod("onLayout.(ZIIII)V", this, ptr);
		}

		// Token: 0x06000B54 RID: 2900 RVA: 0x0001C88E File Offset: 0x0001AA8E
		private static Delegate GetOnMeasure_IIHandler()
		{
			if (View.cb_onMeasure_II == null)
			{
				View.cb_onMeasure_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPII_V(View.n_OnMeasure_II));
			}
			return View.cb_onMeasure_II;
		}

		// Token: 0x06000B55 RID: 2901 RVA: 0x0001C8B2 File Offset: 0x0001AAB2
		private static void n_OnMeasure_II(IntPtr jnienv, IntPtr native__this, int widthMeasureSpec, int heightMeasureSpec)
		{
			Java.Lang.Object.GetObject<View>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnMeasure(widthMeasureSpec, heightMeasureSpec);
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x0001C8C4 File Offset: 0x0001AAC4
		protected unsafe virtual void OnMeasure(int widthMeasureSpec, int heightMeasureSpec)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(widthMeasureSpec);
			ptr[1] = new JniArgumentValue(heightMeasureSpec);
			View._members.InstanceMethods.InvokeVirtualVoidMethod("onMeasure.(II)V", this, ptr);
		}

		// Token: 0x06000B57 RID: 2903 RVA: 0x0001C912 File Offset: 0x0001AB12
		private static Delegate GetOnRestoreInstanceState_Landroid_os_Parcelable_Handler()
		{
			if (View.cb_onRestoreInstanceState_Landroid_os_Parcelable_ == null)
			{
				View.cb_onRestoreInstanceState_Landroid_os_Parcelable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(View.n_OnRestoreInstanceState_Landroid_os_Parcelable_));
			}
			return View.cb_onRestoreInstanceState_Landroid_os_Parcelable_;
		}

		// Token: 0x06000B58 RID: 2904 RVA: 0x0001C938 File Offset: 0x0001AB38
		private static void n_OnRestoreInstanceState_Landroid_os_Parcelable_(IntPtr jnienv, IntPtr native__this, IntPtr native_state)
		{
			View @object = Java.Lang.Object.GetObject<View>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IParcelable object2 = Java.Lang.Object.GetObject<IParcelable>(native_state, JniHandleOwnership.DoNotTransfer);
			@object.OnRestoreInstanceState(object2);
		}

		// Token: 0x06000B59 RID: 2905 RVA: 0x0001C95C File Offset: 0x0001AB5C
		protected unsafe virtual void OnRestoreInstanceState(IParcelable state)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((state == null) ? IntPtr.Zero : ((Java.Lang.Object)state).Handle);
				View._members.InstanceMethods.InvokeVirtualVoidMethod("onRestoreInstanceState.(Landroid/os/Parcelable;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(state);
			}
		}

		// Token: 0x06000B5A RID: 2906 RVA: 0x0001C9C4 File Offset: 0x0001ABC4
		private static Delegate GetOnSaveInstanceStateHandler()
		{
			if (View.cb_onSaveInstanceState == null)
			{
				View.cb_onSaveInstanceState = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(View.n_OnSaveInstanceState));
			}
			return View.cb_onSaveInstanceState;
		}

		// Token: 0x06000B5B RID: 2907 RVA: 0x0001C9E8 File Offset: 0x0001ABE8
		private static IntPtr n_OnSaveInstanceState(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<View>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnSaveInstanceState());
		}

		// Token: 0x06000B5C RID: 2908 RVA: 0x0001C9FC File Offset: 0x0001ABFC
		protected virtual IParcelable OnSaveInstanceState()
		{
			return Java.Lang.Object.GetObject<IParcelable>(View._members.InstanceMethods.InvokeVirtualObjectMethod("onSaveInstanceState.()Landroid/os/Parcelable;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000B5D RID: 2909 RVA: 0x0001CA2E File Offset: 0x0001AC2E
		private static Delegate GetPost_Ljava_lang_Runnable_Handler()
		{
			if (View.cb_post_Ljava_lang_Runnable_ == null)
			{
				View.cb_post_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(View.n_Post_Ljava_lang_Runnable_));
			}
			return View.cb_post_Ljava_lang_Runnable_;
		}

		// Token: 0x06000B5E RID: 2910 RVA: 0x0001CA54 File Offset: 0x0001AC54
		private static bool n_Post_Ljava_lang_Runnable_(IntPtr jnienv, IntPtr native__this, IntPtr native_action)
		{
			View @object = Java.Lang.Object.GetObject<View>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IRunnable object2 = Java.Lang.Object.GetObject<IRunnable>(native_action, JniHandleOwnership.DoNotTransfer);
			return @object.Post(object2);
		}

		// Token: 0x06000B5F RID: 2911 RVA: 0x0001CA78 File Offset: 0x0001AC78
		public unsafe virtual bool Post(IRunnable action)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
				result = View._members.InstanceMethods.InvokeVirtualBooleanMethod("post.(Ljava/lang/Runnable;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(action);
			}
			return result;
		}

		// Token: 0x06000B60 RID: 2912 RVA: 0x0001CAE4 File Offset: 0x0001ACE4
		private static Delegate GetRequestFitSystemWindowsHandler()
		{
			if (View.cb_requestFitSystemWindows == null)
			{
				View.cb_requestFitSystemWindows = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(View.n_RequestFitSystemWindows));
			}
			return View.cb_requestFitSystemWindows;
		}

		// Token: 0x06000B61 RID: 2913 RVA: 0x0001CB08 File Offset: 0x0001AD08
		private static void n_RequestFitSystemWindows(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<View>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RequestFitSystemWindows();
		}

		// Token: 0x06000B62 RID: 2914 RVA: 0x0001CB17 File Offset: 0x0001AD17
		public virtual void RequestFitSystemWindows()
		{
			View._members.InstanceMethods.InvokeVirtualVoidMethod("requestFitSystemWindows.()V", this, null);
		}

		// Token: 0x06000B63 RID: 2915 RVA: 0x0001CB30 File Offset: 0x0001AD30
		public bool RequestFocus()
		{
			return View._members.InstanceMethods.InvokeNonvirtualBooleanMethod("requestFocus.()Z", this, null);
		}

		// Token: 0x06000B64 RID: 2916 RVA: 0x0001CB49 File Offset: 0x0001AD49
		private static Delegate GetRequestLayoutHandler()
		{
			if (View.cb_requestLayout == null)
			{
				View.cb_requestLayout = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(View.n_RequestLayout));
			}
			return View.cb_requestLayout;
		}

		// Token: 0x06000B65 RID: 2917 RVA: 0x0001CB6D File Offset: 0x0001AD6D
		private static void n_RequestLayout(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<View>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RequestLayout();
		}

		// Token: 0x06000B66 RID: 2918 RVA: 0x0001CB7C File Offset: 0x0001AD7C
		public virtual void RequestLayout()
		{
			View._members.InstanceMethods.InvokeVirtualVoidMethod("requestLayout.()V", this, null);
		}

		// Token: 0x06000B67 RID: 2919 RVA: 0x0001CB95 File Offset: 0x0001AD95
		private static Delegate GetScheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_JHandler()
		{
			if (View.cb_scheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_J == null)
			{
				View.cb_scheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_J = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLJ_V(View.n_ScheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_J));
			}
			return View.cb_scheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_J;
		}

		// Token: 0x06000B68 RID: 2920 RVA: 0x0001CBBC File Offset: 0x0001ADBC
		private static void n_ScheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_J(IntPtr jnienv, IntPtr native__this, IntPtr native_who, IntPtr native_what, long when)
		{
			View @object = Java.Lang.Object.GetObject<View>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_who, JniHandleOwnership.DoNotTransfer);
			IRunnable object3 = Java.Lang.Object.GetObject<IRunnable>(native_what, JniHandleOwnership.DoNotTransfer);
			@object.ScheduleDrawable(object2, object3, when);
		}

		// Token: 0x06000B69 RID: 2921 RVA: 0x0001CBEC File Offset: 0x0001ADEC
		public unsafe virtual void ScheduleDrawable(Drawable who, IRunnable what, long when)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((who == null) ? IntPtr.Zero : who.Handle);
				ptr[1] = new JniArgumentValue((what == null) ? IntPtr.Zero : ((Java.Lang.Object)what).Handle);
				ptr[2] = new JniArgumentValue(when);
				View._members.InstanceMethods.InvokeVirtualVoidMethod("scheduleDrawable.(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;J)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(who);
				GC.KeepAlive(what);
			}
		}

		// Token: 0x06000B6A RID: 2922 RVA: 0x0001CC94 File Offset: 0x0001AE94
		private static Delegate GetSendAccessibilityEvent_IHandler()
		{
			if (View.cb_sendAccessibilityEvent_I == null)
			{
				View.cb_sendAccessibilityEvent_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(View.n_SendAccessibilityEvent_I));
			}
			return View.cb_sendAccessibilityEvent_I;
		}

		// Token: 0x06000B6B RID: 2923 RVA: 0x0001CCB8 File Offset: 0x0001AEB8
		private static void n_SendAccessibilityEvent_I(IntPtr jnienv, IntPtr native__this, int native_eventType)
		{
			Java.Lang.Object.GetObject<View>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SendAccessibilityEvent((EventTypes)native_eventType);
		}

		// Token: 0x06000B6C RID: 2924 RVA: 0x0001CCD8 File Offset: 0x0001AED8
		public unsafe virtual void SendAccessibilityEvent([GeneratedEnum] EventTypes eventType)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue((int)eventType);
			View._members.InstanceMethods.InvokeVirtualVoidMethod("sendAccessibilityEvent.(I)V", this, ptr);
		}

		// Token: 0x06000B6D RID: 2925 RVA: 0x0001CD13 File Offset: 0x0001AF13
		private static Delegate GetSendAccessibilityEventUnchecked_Landroid_view_accessibility_AccessibilityEvent_Handler()
		{
			if (View.cb_sendAccessibilityEventUnchecked_Landroid_view_accessibility_AccessibilityEvent_ == null)
			{
				View.cb_sendAccessibilityEventUnchecked_Landroid_view_accessibility_AccessibilityEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(View.n_SendAccessibilityEventUnchecked_Landroid_view_accessibility_AccessibilityEvent_));
			}
			return View.cb_sendAccessibilityEventUnchecked_Landroid_view_accessibility_AccessibilityEvent_;
		}

		// Token: 0x06000B6E RID: 2926 RVA: 0x0001CD38 File Offset: 0x0001AF38
		private static void n_SendAccessibilityEventUnchecked_Landroid_view_accessibility_AccessibilityEvent_(IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			View @object = Java.Lang.Object.GetObject<View>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AccessibilityEvent object2 = Java.Lang.Object.GetObject<AccessibilityEvent>(native_e, JniHandleOwnership.DoNotTransfer);
			@object.SendAccessibilityEventUnchecked(object2);
		}

		// Token: 0x06000B6F RID: 2927 RVA: 0x0001CD5C File Offset: 0x0001AF5C
		public unsafe virtual void SendAccessibilityEventUnchecked(AccessibilityEvent e)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((e == null) ? IntPtr.Zero : e.Handle);
				View._members.InstanceMethods.InvokeVirtualVoidMethod("sendAccessibilityEventUnchecked.(Landroid/view/accessibility/AccessibilityEvent;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(e);
			}
		}

		// Token: 0x06000B70 RID: 2928 RVA: 0x0001CDC0 File Offset: 0x0001AFC0
		private static Delegate GetSetBackgroundResource_IHandler()
		{
			if (View.cb_setBackgroundResource_I == null)
			{
				View.cb_setBackgroundResource_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(View.n_SetBackgroundResource_I));
			}
			return View.cb_setBackgroundResource_I;
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x0001CDE4 File Offset: 0x0001AFE4
		private static void n_SetBackgroundResource_I(IntPtr jnienv, IntPtr native__this, int resid)
		{
			Java.Lang.Object.GetObject<View>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetBackgroundResource(resid);
		}

		// Token: 0x06000B72 RID: 2930 RVA: 0x0001CDF4 File Offset: 0x0001AFF4
		public unsafe virtual void SetBackgroundResource(int resid)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(resid);
			View._members.InstanceMethods.InvokeVirtualVoidMethod("setBackgroundResource.(I)V", this, ptr);
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x0001CE2F File Offset: 0x0001B02F
		private static Delegate GetSetOnClickListener_Landroid_view_View_OnClickListener_Handler()
		{
			if (View.cb_setOnClickListener_Landroid_view_View_OnClickListener_ == null)
			{
				View.cb_setOnClickListener_Landroid_view_View_OnClickListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(View.n_SetOnClickListener_Landroid_view_View_OnClickListener_));
			}
			return View.cb_setOnClickListener_Landroid_view_View_OnClickListener_;
		}

		// Token: 0x06000B74 RID: 2932 RVA: 0x0001CE54 File Offset: 0x0001B054
		private static void n_SetOnClickListener_Landroid_view_View_OnClickListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_l)
		{
			View @object = Java.Lang.Object.GetObject<View>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View.IOnClickListener object2 = Java.Lang.Object.GetObject<View.IOnClickListener>(native_l, JniHandleOwnership.DoNotTransfer);
			@object.SetOnClickListener(object2);
		}

		// Token: 0x06000B75 RID: 2933 RVA: 0x0001CE78 File Offset: 0x0001B078
		public unsafe virtual void SetOnClickListener(View.IOnClickListener l)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((l == null) ? IntPtr.Zero : ((Java.Lang.Object)l).Handle);
				View._members.InstanceMethods.InvokeVirtualVoidMethod("setOnClickListener.(Landroid/view/View$OnClickListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(l);
			}
		}

		// Token: 0x06000B76 RID: 2934 RVA: 0x0001CEE0 File Offset: 0x0001B0E0
		private static Delegate GetSetOnLongClickListener_Landroid_view_View_OnLongClickListener_Handler()
		{
			if (View.cb_setOnLongClickListener_Landroid_view_View_OnLongClickListener_ == null)
			{
				View.cb_setOnLongClickListener_Landroid_view_View_OnLongClickListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(View.n_SetOnLongClickListener_Landroid_view_View_OnLongClickListener_));
			}
			return View.cb_setOnLongClickListener_Landroid_view_View_OnLongClickListener_;
		}

		// Token: 0x06000B77 RID: 2935 RVA: 0x0001CF04 File Offset: 0x0001B104
		private static void n_SetOnLongClickListener_Landroid_view_View_OnLongClickListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_l)
		{
			View @object = Java.Lang.Object.GetObject<View>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View.IOnLongClickListener object2 = Java.Lang.Object.GetObject<View.IOnLongClickListener>(native_l, JniHandleOwnership.DoNotTransfer);
			@object.SetOnLongClickListener(object2);
		}

		// Token: 0x06000B78 RID: 2936 RVA: 0x0001CF28 File Offset: 0x0001B128
		public unsafe virtual void SetOnLongClickListener(View.IOnLongClickListener l)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((l == null) ? IntPtr.Zero : ((Java.Lang.Object)l).Handle);
				View._members.InstanceMethods.InvokeVirtualVoidMethod("setOnLongClickListener.(Landroid/view/View$OnLongClickListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(l);
			}
		}

		// Token: 0x06000B79 RID: 2937 RVA: 0x0001CF90 File Offset: 0x0001B190
		private static Delegate GetSetOnScrollChangeListener_Landroid_view_View_OnScrollChangeListener_Handler()
		{
			if (View.cb_setOnScrollChangeListener_Landroid_view_View_OnScrollChangeListener_ == null)
			{
				View.cb_setOnScrollChangeListener_Landroid_view_View_OnScrollChangeListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(View.n_SetOnScrollChangeListener_Landroid_view_View_OnScrollChangeListener_));
			}
			return View.cb_setOnScrollChangeListener_Landroid_view_View_OnScrollChangeListener_;
		}

		// Token: 0x06000B7A RID: 2938 RVA: 0x0001CFB4 File Offset: 0x0001B1B4
		private static void n_SetOnScrollChangeListener_Landroid_view_View_OnScrollChangeListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_l)
		{
			View @object = Java.Lang.Object.GetObject<View>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View.IOnScrollChangeListener object2 = Java.Lang.Object.GetObject<View.IOnScrollChangeListener>(native_l, JniHandleOwnership.DoNotTransfer);
			@object.SetOnScrollChangeListener(object2);
		}

		// Token: 0x06000B7B RID: 2939 RVA: 0x0001CFD8 File Offset: 0x0001B1D8
		public unsafe virtual void SetOnScrollChangeListener(View.IOnScrollChangeListener l)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((l == null) ? IntPtr.Zero : ((Java.Lang.Object)l).Handle);
				View._members.InstanceMethods.InvokeVirtualVoidMethod("setOnScrollChangeListener.(Landroid/view/View$OnScrollChangeListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(l);
			}
		}

		// Token: 0x06000B7C RID: 2940 RVA: 0x0001D040 File Offset: 0x0001B240
		private static Delegate GetStartAnimation_Landroid_view_animation_Animation_Handler()
		{
			if (View.cb_startAnimation_Landroid_view_animation_Animation_ == null)
			{
				View.cb_startAnimation_Landroid_view_animation_Animation_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(View.n_StartAnimation_Landroid_view_animation_Animation_));
			}
			return View.cb_startAnimation_Landroid_view_animation_Animation_;
		}

		// Token: 0x06000B7D RID: 2941 RVA: 0x0001D064 File Offset: 0x0001B264
		private static void n_StartAnimation_Landroid_view_animation_Animation_(IntPtr jnienv, IntPtr native__this, IntPtr native_animation)
		{
			View @object = Java.Lang.Object.GetObject<View>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Animation object2 = Java.Lang.Object.GetObject<Animation>(native_animation, JniHandleOwnership.DoNotTransfer);
			@object.StartAnimation(object2);
		}

		// Token: 0x06000B7E RID: 2942 RVA: 0x0001D088 File Offset: 0x0001B288
		public unsafe virtual void StartAnimation(Animation animation)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((animation == null) ? IntPtr.Zero : animation.Handle);
				View._members.InstanceMethods.InvokeVirtualVoidMethod("startAnimation.(Landroid/view/animation/Animation;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(animation);
			}
		}

		// Token: 0x06000B7F RID: 2943 RVA: 0x0001D0EC File Offset: 0x0001B2EC
		private static Delegate GetStartNestedScroll_IHandler()
		{
			if (View.cb_startNestedScroll_I == null)
			{
				View.cb_startNestedScroll_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_Z(View.n_StartNestedScroll_I));
			}
			return View.cb_startNestedScroll_I;
		}

		// Token: 0x06000B80 RID: 2944 RVA: 0x0001D110 File Offset: 0x0001B310
		private static bool n_StartNestedScroll_I(IntPtr jnienv, IntPtr native__this, int native_axes)
		{
			return Java.Lang.Object.GetObject<View>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).StartNestedScroll((ScrollAxis)native_axes);
		}

		// Token: 0x06000B81 RID: 2945 RVA: 0x0001D130 File Offset: 0x0001B330
		public unsafe virtual bool StartNestedScroll([GeneratedEnum] ScrollAxis axes)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue((int)axes);
			return View._members.InstanceMethods.InvokeVirtualBooleanMethod("startNestedScroll.(I)Z", this, ptr);
		}

		// Token: 0x06000B82 RID: 2946 RVA: 0x0001D16B File Offset: 0x0001B36B
		private static Delegate GetStopNestedScrollHandler()
		{
			if (View.cb_stopNestedScroll == null)
			{
				View.cb_stopNestedScroll = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(View.n_StopNestedScroll));
			}
			return View.cb_stopNestedScroll;
		}

		// Token: 0x06000B83 RID: 2947 RVA: 0x0001D18F File Offset: 0x0001B38F
		private static void n_StopNestedScroll(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<View>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).StopNestedScroll();
		}

		// Token: 0x06000B84 RID: 2948 RVA: 0x0001D19E File Offset: 0x0001B39E
		public virtual void StopNestedScroll()
		{
			View._members.InstanceMethods.InvokeVirtualVoidMethod("stopNestedScroll.()V", this, null);
		}

		// Token: 0x06000B85 RID: 2949 RVA: 0x0001D1B7 File Offset: 0x0001B3B7
		private static Delegate GetUnscheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_Handler()
		{
			if (View.cb_unscheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_ == null)
			{
				View.cb_unscheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(View.n_UnscheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_));
			}
			return View.cb_unscheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_;
		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x0001D1DC File Offset: 0x0001B3DC
		private static void n_UnscheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_(IntPtr jnienv, IntPtr native__this, IntPtr native_who, IntPtr native_what)
		{
			View @object = Java.Lang.Object.GetObject<View>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_who, JniHandleOwnership.DoNotTransfer);
			IRunnable object3 = Java.Lang.Object.GetObject<IRunnable>(native_what, JniHandleOwnership.DoNotTransfer);
			@object.UnscheduleDrawable(object2, object3);
		}

		// Token: 0x06000B87 RID: 2951 RVA: 0x0001D208 File Offset: 0x0001B408
		public unsafe virtual void UnscheduleDrawable(Drawable who, IRunnable what)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((who == null) ? IntPtr.Zero : who.Handle);
				ptr[1] = new JniArgumentValue((what == null) ? IntPtr.Zero : ((Java.Lang.Object)what).Handle);
				View._members.InstanceMethods.InvokeVirtualVoidMethod("unscheduleDrawable.(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(who);
				GC.KeepAlive(what);
			}
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06000B88 RID: 2952 RVA: 0x0001D298 File Offset: 0x0001B498
		// (remove) Token: 0x06000B89 RID: 2953 RVA: 0x0001D2E4 File Offset: 0x0001B4E4
		public event EventHandler Click
		{
			add
			{
				EventHelper.AddEventHandler<View.IOnClickListener, View.IOnClickListenerImplementor>(ref this.weak_implementor_SetOnClickListener, new Func<View.IOnClickListenerImplementor>(this.__CreateIOnClickListenerImplementor), new Action<View.IOnClickListener>(this.SetOnClickListener), delegate(View.IOnClickListenerImplementor __h)
				{
					__h.Handler = (EventHandler)Delegate.Combine(__h.Handler, value);
				});
			}
			remove
			{
				Func<View.IOnClickListenerImplementor, bool> empty;
				if ((empty = View.<>O.<4>____IsEmpty) == null)
				{
					empty = (View.<>O.<4>____IsEmpty = new Func<View.IOnClickListenerImplementor, bool>(View.IOnClickListenerImplementor.__IsEmpty));
				}
				EventHelper.RemoveEventHandler<View.IOnClickListener, View.IOnClickListenerImplementor>(ref this.weak_implementor_SetOnClickListener, empty, delegate(View.IOnClickListener __v)
				{
					this.SetOnClickListener(null);
				}, delegate(View.IOnClickListenerImplementor __h)
				{
					__h.Handler = (EventHandler)Delegate.Remove(__h.Handler, value);
				});
			}
		}

		// Token: 0x06000B8A RID: 2954 RVA: 0x0001D343 File Offset: 0x0001B543
		private View.IOnClickListenerImplementor __CreateIOnClickListenerImplementor()
		{
			return new View.IOnClickListenerImplementor();
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x06000B8B RID: 2955 RVA: 0x0001D34C File Offset: 0x0001B54C
		// (remove) Token: 0x06000B8C RID: 2956 RVA: 0x0001D398 File Offset: 0x0001B598
		public event EventHandler<View.LongClickEventArgs> LongClick
		{
			add
			{
				EventHelper.AddEventHandler<View.IOnLongClickListener, View.IOnLongClickListenerImplementor>(ref this.weak_implementor_SetOnLongClickListener, new Func<View.IOnLongClickListenerImplementor>(this.__CreateIOnLongClickListenerImplementor), new Action<View.IOnLongClickListener>(this.SetOnLongClickListener), delegate(View.IOnLongClickListenerImplementor __h)
				{
					__h.Handler = (EventHandler<View.LongClickEventArgs>)Delegate.Combine(__h.Handler, value);
				});
			}
			remove
			{
				Func<View.IOnLongClickListenerImplementor, bool> empty;
				if ((empty = View.<>O.<11>____IsEmpty) == null)
				{
					empty = (View.<>O.<11>____IsEmpty = new Func<View.IOnLongClickListenerImplementor, bool>(View.IOnLongClickListenerImplementor.__IsEmpty));
				}
				EventHelper.RemoveEventHandler<View.IOnLongClickListener, View.IOnLongClickListenerImplementor>(ref this.weak_implementor_SetOnLongClickListener, empty, delegate(View.IOnLongClickListener __v)
				{
					this.SetOnLongClickListener(null);
				}, delegate(View.IOnLongClickListenerImplementor __h)
				{
					__h.Handler = (EventHandler<View.LongClickEventArgs>)Delegate.Remove(__h.Handler, value);
				});
			}
		}

		// Token: 0x06000B8D RID: 2957 RVA: 0x0001D3F7 File Offset: 0x0001B5F7
		private View.IOnLongClickListenerImplementor __CreateIOnLongClickListenerImplementor()
		{
			return new View.IOnLongClickListenerImplementor();
		}

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x06000B8E RID: 2958 RVA: 0x0001D400 File Offset: 0x0001B600
		// (remove) Token: 0x06000B8F RID: 2959 RVA: 0x0001D44C File Offset: 0x0001B64C
		public event EventHandler<View.ScrollChangeEventArgs> ScrollChange
		{
			add
			{
				EventHelper.AddEventHandler<View.IOnScrollChangeListener, View.IOnScrollChangeListenerImplementor>(ref this.weak_implementor_SetOnScrollChangeListener, new Func<View.IOnScrollChangeListenerImplementor>(this.__CreateIOnScrollChangeListenerImplementor), new Action<View.IOnScrollChangeListener>(this.SetOnScrollChangeListener), delegate(View.IOnScrollChangeListenerImplementor __h)
				{
					__h.Handler = (EventHandler<View.ScrollChangeEventArgs>)Delegate.Combine(__h.Handler, value);
				});
			}
			remove
			{
				Func<View.IOnScrollChangeListenerImplementor, bool> empty;
				if ((empty = View.<>O.<12>____IsEmpty) == null)
				{
					empty = (View.<>O.<12>____IsEmpty = new Func<View.IOnScrollChangeListenerImplementor, bool>(View.IOnScrollChangeListenerImplementor.__IsEmpty));
				}
				EventHelper.RemoveEventHandler<View.IOnScrollChangeListener, View.IOnScrollChangeListenerImplementor>(ref this.weak_implementor_SetOnScrollChangeListener, empty, delegate(View.IOnScrollChangeListener __v)
				{
					this.SetOnScrollChangeListener(null);
				}, delegate(View.IOnScrollChangeListenerImplementor __h)
				{
					__h.Handler = (EventHandler<View.ScrollChangeEventArgs>)Delegate.Remove(__h.Handler, value);
				});
			}
		}

		// Token: 0x06000B90 RID: 2960 RVA: 0x0001D4AB File Offset: 0x0001B6AB
		private View.IOnScrollChangeListenerImplementor __CreateIOnScrollChangeListenerImplementor()
		{
			return new View.IOnScrollChangeListenerImplementor(this);
		}

		// Token: 0x06000B91 RID: 2961 RVA: 0x0001D4B3 File Offset: 0x0001B6B3
		public T FindViewById<T>(int id) where T : View
		{
			return this.FindViewById(id).JavaCast<T>();
		}

		// Token: 0x0400036F RID: 879
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/view/View", typeof(View));

		// Token: 0x04000370 RID: 880
		private static Delegate cb_setBackground_Landroid_graphics_drawable_Drawable_;

		// Token: 0x04000371 RID: 881
		private static Delegate cb_setClickable_Z;

		// Token: 0x04000372 RID: 882
		private static Delegate cb_isEnabled;

		// Token: 0x04000373 RID: 883
		private static Delegate cb_setEnabled_Z;

		// Token: 0x04000374 RID: 884
		private static Delegate cb_hasNestedScrollingParent;

		// Token: 0x04000375 RID: 885
		private static Delegate cb_isLayoutDirectionResolved;

		// Token: 0x04000376 RID: 886
		private static Delegate cb_isLayoutRequested;

		// Token: 0x04000377 RID: 887
		private static Delegate cb_isTextAlignmentResolved;

		// Token: 0x04000378 RID: 888
		private static Delegate cb_isTextDirectionResolved;

		// Token: 0x04000379 RID: 889
		private static Delegate cb_getLayoutDirection;

		// Token: 0x0400037A RID: 890
		private static Delegate cb_getLayoutParams;

		// Token: 0x0400037B RID: 891
		private static Delegate cb_isNestedScrollingEnabled;

		// Token: 0x0400037C RID: 892
		private static Delegate cb_setNestedScrollingEnabled_Z;

		// Token: 0x0400037D RID: 893
		private static Delegate cb_setOverScrollMode_I;

		// Token: 0x0400037E RID: 894
		private static Delegate cb_getParentForAccessibility;

		// Token: 0x0400037F RID: 895
		private static Delegate cb_getResources;

		// Token: 0x04000380 RID: 896
		private static Delegate cb_setScaleY_F;

		// Token: 0x04000381 RID: 897
		private static Delegate cb_isSelected;

		// Token: 0x04000382 RID: 898
		private static Delegate cb_setSelected_Z;

		// Token: 0x04000383 RID: 899
		private static Delegate cb_getSystemUiVisibility;

		// Token: 0x04000384 RID: 900
		private static Delegate cb_setSystemUiVisibility_I;

		// Token: 0x04000385 RID: 901
		private static Delegate cb_getTextAlignment;

		// Token: 0x04000386 RID: 902
		private static Delegate cb_getTextDirection;

		// Token: 0x04000387 RID: 903
		private static Delegate cb_setTranslationX_F;

		// Token: 0x04000388 RID: 904
		private static Delegate cb_getVisibility;

		// Token: 0x04000389 RID: 905
		private static Delegate cb_setVisibility_I;

		// Token: 0x0400038A RID: 906
		private static Delegate cb_getWindowToken;

		// Token: 0x0400038B RID: 907
		private static Delegate cb_addTouchables_Ljava_util_ArrayList_;

		// Token: 0x0400038C RID: 908
		private static Delegate cb_animate;

		// Token: 0x0400038D RID: 909
		private static Delegate cb_canResolveLayoutDirection;

		// Token: 0x0400038E RID: 910
		private static Delegate cb_canResolveTextAlignment;

		// Token: 0x0400038F RID: 911
		private static Delegate cb_canResolveTextDirection;

		// Token: 0x04000390 RID: 912
		private static Delegate cb_canScrollHorizontally_I;

		// Token: 0x04000391 RID: 913
		private static Delegate cb_canScrollVertically_I;

		// Token: 0x04000392 RID: 914
		private static Delegate cb_computeHorizontalScrollExtent;

		// Token: 0x04000393 RID: 915
		private static Delegate cb_computeHorizontalScrollOffset;

		// Token: 0x04000394 RID: 916
		private static Delegate cb_computeHorizontalScrollRange;

		// Token: 0x04000395 RID: 917
		private static Delegate cb_computeVerticalScrollExtent;

		// Token: 0x04000396 RID: 918
		private static Delegate cb_computeVerticalScrollOffset;

		// Token: 0x04000397 RID: 919
		private static Delegate cb_computeVerticalScrollRange;

		// Token: 0x04000398 RID: 920
		private static Delegate cb_createContextMenu_Landroid_view_ContextMenu_;

		// Token: 0x04000399 RID: 921
		private static Delegate cb_dispatchKeyEvent_Landroid_view_KeyEvent_;

		// Token: 0x0400039A RID: 922
		private static Delegate cb_dispatchNestedFling_FFZ;

		// Token: 0x0400039B RID: 923
		private static Delegate cb_dispatchNestedPreFling_FF;

		// Token: 0x0400039C RID: 924
		private static Delegate cb_dispatchNestedPreScroll_IIarrayIarrayI;

		// Token: 0x0400039D RID: 925
		private static Delegate cb_dispatchNestedScroll_IIIIarrayI;

		// Token: 0x0400039E RID: 926
		private static Delegate cb_dispatchRestoreInstanceState_Landroid_util_SparseArray_;

		// Token: 0x0400039F RID: 927
		private static Delegate cb_dispatchSaveInstanceState_Landroid_util_SparseArray_;

		// Token: 0x040003A0 RID: 928
		private static Delegate cb_invalidateDrawable_Landroid_graphics_drawable_Drawable_;

		// Token: 0x040003A1 RID: 929
		private static Delegate cb_keyboardNavigationClusterSearch_Landroid_view_View_I;

		// Token: 0x040003A2 RID: 930
		private static Delegate cb_onAttachedToWindow;

		// Token: 0x040003A3 RID: 931
		private static Delegate cb_onDetachedFromWindow;

		// Token: 0x040003A4 RID: 932
		private static Delegate cb_onDraw_Landroid_graphics_Canvas_;

		// Token: 0x040003A5 RID: 933
		private static Delegate cb_onKeyDown_ILandroid_view_KeyEvent_;

		// Token: 0x040003A6 RID: 934
		private static Delegate cb_onKeyLongPress_ILandroid_view_KeyEvent_;

		// Token: 0x040003A7 RID: 935
		private static Delegate cb_onKeyMultiple_IILandroid_view_KeyEvent_;

		// Token: 0x040003A8 RID: 936
		private static Delegate cb_onKeyUp_ILandroid_view_KeyEvent_;

		// Token: 0x040003A9 RID: 937
		private static Delegate cb_onLayout_ZIIII;

		// Token: 0x040003AA RID: 938
		private static Delegate cb_onMeasure_II;

		// Token: 0x040003AB RID: 939
		private static Delegate cb_onRestoreInstanceState_Landroid_os_Parcelable_;

		// Token: 0x040003AC RID: 940
		private static Delegate cb_onSaveInstanceState;

		// Token: 0x040003AD RID: 941
		private static Delegate cb_post_Ljava_lang_Runnable_;

		// Token: 0x040003AE RID: 942
		private static Delegate cb_requestFitSystemWindows;

		// Token: 0x040003AF RID: 943
		private static Delegate cb_requestLayout;

		// Token: 0x040003B0 RID: 944
		private static Delegate cb_scheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_J;

		// Token: 0x040003B1 RID: 945
		private static Delegate cb_sendAccessibilityEvent_I;

		// Token: 0x040003B2 RID: 946
		private static Delegate cb_sendAccessibilityEventUnchecked_Landroid_view_accessibility_AccessibilityEvent_;

		// Token: 0x040003B3 RID: 947
		private static Delegate cb_setBackgroundResource_I;

		// Token: 0x040003B4 RID: 948
		private static Delegate cb_setOnClickListener_Landroid_view_View_OnClickListener_;

		// Token: 0x040003B5 RID: 949
		private static Delegate cb_setOnLongClickListener_Landroid_view_View_OnLongClickListener_;

		// Token: 0x040003B6 RID: 950
		private static Delegate cb_setOnScrollChangeListener_Landroid_view_View_OnScrollChangeListener_;

		// Token: 0x040003B7 RID: 951
		private static Delegate cb_startAnimation_Landroid_view_animation_Animation_;

		// Token: 0x040003B8 RID: 952
		private static Delegate cb_startNestedScroll_I;

		// Token: 0x040003B9 RID: 953
		private static Delegate cb_stopNestedScroll;

		// Token: 0x040003BA RID: 954
		private static Delegate cb_unscheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_;

		// Token: 0x040003BB RID: 955
		private WeakReference weak_implementor_SetOnClickListener;

		// Token: 0x040003BC RID: 956
		private WeakReference weak_implementor_SetOnLongClickListener;

		// Token: 0x040003BD RID: 957
		private WeakReference weak_implementor_SetOnScrollChangeListener;

		// Token: 0x0200013F RID: 319
		[Register("android/view/View$AccessibilityDelegate", DoNotGenerateAcw = true)]
		public class AccessibilityDelegate : Java.Lang.Object
		{
			// Token: 0x1700022F RID: 559
			// (get) Token: 0x06000B93 RID: 2963 RVA: 0x0001D4DC File Offset: 0x0001B6DC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return View.AccessibilityDelegate._members;
				}
			}

			// Token: 0x17000230 RID: 560
			// (get) Token: 0x06000B94 RID: 2964 RVA: 0x0001D4E4 File Offset: 0x0001B6E4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return View.AccessibilityDelegate._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000231 RID: 561
			// (get) Token: 0x06000B95 RID: 2965 RVA: 0x0001D508 File Offset: 0x0001B708
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return View.AccessibilityDelegate._members.ManagedPeerType;
				}
			}

			// Token: 0x06000B96 RID: 2966 RVA: 0x000021E0 File Offset: 0x000003E0
			protected AccessibilityDelegate(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x040003BE RID: 958
			private static readonly JniPeerMembers _members = new XAPeerMembers("android/view/View$AccessibilityDelegate", typeof(View.AccessibilityDelegate));
		}

		// Token: 0x02000140 RID: 320
		[Register("android/view/View$OnClickListener", "", "Android.Views.View/IOnClickListenerInvoker")]
		public interface IOnClickListener : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06000B98 RID: 2968
			[Register("onClick", "(Landroid/view/View;)V", "GetOnClick_Landroid_view_View_Handler:Android.Views.View/IOnClickListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			void OnClick(View v);
		}

		// Token: 0x02000141 RID: 321
		[Register("android/view/View$OnClickListener", DoNotGenerateAcw = true)]
		internal class IOnClickListenerInvoker : Java.Lang.Object, View.IOnClickListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000232 RID: 562
			// (get) Token: 0x06000B99 RID: 2969 RVA: 0x0001D530 File Offset: 0x0001B730
			private static IntPtr java_class_ref
			{
				get
				{
					return View.IOnClickListenerInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000233 RID: 563
			// (get) Token: 0x06000B9A RID: 2970 RVA: 0x0001D554 File Offset: 0x0001B754
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return View.IOnClickListenerInvoker._members;
				}
			}

			// Token: 0x17000234 RID: 564
			// (get) Token: 0x06000B9B RID: 2971 RVA: 0x0001D55B File Offset: 0x0001B75B
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x17000235 RID: 565
			// (get) Token: 0x06000B9C RID: 2972 RVA: 0x0001D563 File Offset: 0x0001B763
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return View.IOnClickListenerInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06000B9D RID: 2973 RVA: 0x0001D56F File Offset: 0x0001B76F
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, View.IOnClickListenerInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.view.View.OnClickListener'.");
				}
				return handle;
			}

			// Token: 0x06000B9E RID: 2974 RVA: 0x0001D59A File Offset: 0x0001B79A
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06000B9F RID: 2975 RVA: 0x0001D5CC File Offset: 0x0001B7CC
			public IOnClickListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(View.IOnClickListenerInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x06000BA0 RID: 2976 RVA: 0x0001D604 File Offset: 0x0001B804
			private static Delegate GetOnClick_Landroid_view_View_Handler()
			{
				if (View.IOnClickListenerInvoker.cb_onClick_Landroid_view_View_ == null)
				{
					View.IOnClickListenerInvoker.cb_onClick_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(View.IOnClickListenerInvoker.n_OnClick_Landroid_view_View_));
				}
				return View.IOnClickListenerInvoker.cb_onClick_Landroid_view_View_;
			}

			// Token: 0x06000BA1 RID: 2977 RVA: 0x0001D628 File Offset: 0x0001B828
			private static void n_OnClick_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_v)
			{
				View.IOnClickListener @object = Java.Lang.Object.GetObject<View.IOnClickListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				View object2 = Java.Lang.Object.GetObject<View>(native_v, JniHandleOwnership.DoNotTransfer);
				@object.OnClick(object2);
			}

			// Token: 0x06000BA2 RID: 2978 RVA: 0x0001D64C File Offset: 0x0001B84C
			public unsafe void OnClick(View v)
			{
				if (this.id_onClick_Landroid_view_View_ == IntPtr.Zero)
				{
					this.id_onClick_Landroid_view_View_ = JNIEnv.GetMethodID(this.class_ref, "onClick", "(Landroid/view/View;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((v == null) ? IntPtr.Zero : v.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onClick_Landroid_view_View_, ptr);
			}

			// Token: 0x040003BF RID: 959
			private static readonly JniPeerMembers _members = new XAPeerMembers("android/view/View$OnClickListener", typeof(View.IOnClickListenerInvoker));

			// Token: 0x040003C0 RID: 960
			private IntPtr class_ref;

			// Token: 0x040003C1 RID: 961
			private static Delegate cb_onClick_Landroid_view_View_;

			// Token: 0x040003C2 RID: 962
			private IntPtr id_onClick_Landroid_view_View_;
		}

		// Token: 0x02000142 RID: 322
		[Register("mono/android/view/View_OnClickListenerImplementor")]
		internal sealed class IOnClickListenerImplementor : Java.Lang.Object, View.IOnClickListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06000BA4 RID: 2980 RVA: 0x0001D6DA File Offset: 0x0001B8DA
			public IOnClickListenerImplementor() : base(JNIEnv.StartCreateInstance("mono/android/view/View_OnClickListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
			{
				JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
			}

			// Token: 0x06000BA5 RID: 2981 RVA: 0x0001D70C File Offset: 0x0001B90C
			public void OnClick(View v)
			{
				EventHandler handler = this.Handler;
				if (handler != null)
				{
					handler(v, new EventArgs());
				}
			}

			// Token: 0x06000BA6 RID: 2982 RVA: 0x0001D72F File Offset: 0x0001B92F
			internal static bool __IsEmpty(View.IOnClickListenerImplementor value)
			{
				return value.Handler == null;
			}

			// Token: 0x040003C3 RID: 963
			public EventHandler Handler;
		}

		// Token: 0x02000143 RID: 323
		[Register("android/view/View$OnCreateContextMenuListener", "", "Android.Views.View/IOnCreateContextMenuListenerInvoker")]
		public interface IOnCreateContextMenuListener : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06000BA7 RID: 2983
			[Register("onCreateContextMenu", "(Landroid/view/ContextMenu;Landroid/view/View;Landroid/view/ContextMenu$ContextMenuInfo;)V", "GetOnCreateContextMenu_Landroid_view_ContextMenu_Landroid_view_View_Landroid_view_ContextMenu_ContextMenuInfo_Handler:Android.Views.View/IOnCreateContextMenuListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			void OnCreateContextMenu(IContextMenu menu, View v, IContextMenuContextMenuInfo menuInfo);
		}

		// Token: 0x02000144 RID: 324
		[Register("android/view/View$OnCreateContextMenuListener", DoNotGenerateAcw = true)]
		internal class IOnCreateContextMenuListenerInvoker : Java.Lang.Object, View.IOnCreateContextMenuListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000236 RID: 566
			// (get) Token: 0x06000BA8 RID: 2984 RVA: 0x0001D73C File Offset: 0x0001B93C
			private static IntPtr java_class_ref
			{
				get
				{
					return View.IOnCreateContextMenuListenerInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000237 RID: 567
			// (get) Token: 0x06000BA9 RID: 2985 RVA: 0x0001D760 File Offset: 0x0001B960
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return View.IOnCreateContextMenuListenerInvoker._members;
				}
			}

			// Token: 0x17000238 RID: 568
			// (get) Token: 0x06000BAA RID: 2986 RVA: 0x0001D767 File Offset: 0x0001B967
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x17000239 RID: 569
			// (get) Token: 0x06000BAB RID: 2987 RVA: 0x0001D76F File Offset: 0x0001B96F
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return View.IOnCreateContextMenuListenerInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06000BAC RID: 2988 RVA: 0x0001D77B File Offset: 0x0001B97B
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, View.IOnCreateContextMenuListenerInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.view.View.OnCreateContextMenuListener'.");
				}
				return handle;
			}

			// Token: 0x06000BAD RID: 2989 RVA: 0x0001D7A6 File Offset: 0x0001B9A6
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06000BAE RID: 2990 RVA: 0x0001D7D8 File Offset: 0x0001B9D8
			public IOnCreateContextMenuListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(View.IOnCreateContextMenuListenerInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x06000BAF RID: 2991 RVA: 0x0001D810 File Offset: 0x0001BA10
			private static Delegate GetOnCreateContextMenu_Landroid_view_ContextMenu_Landroid_view_View_Landroid_view_ContextMenu_ContextMenuInfo_Handler()
			{
				if (View.IOnCreateContextMenuListenerInvoker.cb_onCreateContextMenu_Landroid_view_ContextMenu_Landroid_view_View_Landroid_view_ContextMenu_ContextMenuInfo_ == null)
				{
					View.IOnCreateContextMenuListenerInvoker.cb_onCreateContextMenu_Landroid_view_ContextMenu_Landroid_view_View_Landroid_view_ContextMenu_ContextMenuInfo_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(View.IOnCreateContextMenuListenerInvoker.n_OnCreateContextMenu_Landroid_view_ContextMenu_Landroid_view_View_Landroid_view_ContextMenu_ContextMenuInfo_));
				}
				return View.IOnCreateContextMenuListenerInvoker.cb_onCreateContextMenu_Landroid_view_ContextMenu_Landroid_view_View_Landroid_view_ContextMenu_ContextMenuInfo_;
			}

			// Token: 0x06000BB0 RID: 2992 RVA: 0x0001D834 File Offset: 0x0001BA34
			private static void n_OnCreateContextMenu_Landroid_view_ContextMenu_Landroid_view_View_Landroid_view_ContextMenu_ContextMenuInfo_(IntPtr jnienv, IntPtr native__this, IntPtr native_menu, IntPtr native_v, IntPtr native_menuInfo)
			{
				View.IOnCreateContextMenuListener @object = Java.Lang.Object.GetObject<View.IOnCreateContextMenuListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				IContextMenu object2 = Java.Lang.Object.GetObject<IContextMenu>(native_menu, JniHandleOwnership.DoNotTransfer);
				View object3 = Java.Lang.Object.GetObject<View>(native_v, JniHandleOwnership.DoNotTransfer);
				IContextMenuContextMenuInfo object4 = Java.Lang.Object.GetObject<IContextMenuContextMenuInfo>(native_menuInfo, JniHandleOwnership.DoNotTransfer);
				@object.OnCreateContextMenu(object2, object3, object4);
			}

			// Token: 0x06000BB1 RID: 2993 RVA: 0x0001D86C File Offset: 0x0001BA6C
			public unsafe void OnCreateContextMenu(IContextMenu menu, View v, IContextMenuContextMenuInfo menuInfo)
			{
				if (this.id_onCreateContextMenu_Landroid_view_ContextMenu_Landroid_view_View_Landroid_view_ContextMenu_ContextMenuInfo_ == IntPtr.Zero)
				{
					this.id_onCreateContextMenu_Landroid_view_ContextMenu_Landroid_view_View_Landroid_view_ContextMenu_ContextMenuInfo_ = JNIEnv.GetMethodID(this.class_ref, "onCreateContextMenu", "(Landroid/view/ContextMenu;Landroid/view/View;Landroid/view/ContextMenu$ContextMenuInfo;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((menu == null) ? IntPtr.Zero : ((Java.Lang.Object)menu).Handle);
				ptr[1] = new JValue((v == null) ? IntPtr.Zero : v.Handle);
				ptr[2] = new JValue((menuInfo == null) ? IntPtr.Zero : ((Java.Lang.Object)menuInfo).Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onCreateContextMenu_Landroid_view_ContextMenu_Landroid_view_View_Landroid_view_ContextMenu_ContextMenuInfo_, ptr);
			}

			// Token: 0x040003C4 RID: 964
			private static readonly JniPeerMembers _members = new XAPeerMembers("android/view/View$OnCreateContextMenuListener", typeof(View.IOnCreateContextMenuListenerInvoker));

			// Token: 0x040003C5 RID: 965
			private IntPtr class_ref;

			// Token: 0x040003C6 RID: 966
			private static Delegate cb_onCreateContextMenu_Landroid_view_ContextMenu_Landroid_view_View_Landroid_view_ContextMenu_ContextMenuInfo_;

			// Token: 0x040003C7 RID: 967
			private IntPtr id_onCreateContextMenu_Landroid_view_ContextMenu_Landroid_view_View_Landroid_view_ContextMenu_ContextMenuInfo_;
		}

		// Token: 0x02000145 RID: 325
		[Register("android/view/View$OnFocusChangeListener", "", "Android.Views.View/IOnFocusChangeListenerInvoker")]
		public interface IOnFocusChangeListener : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06000BB3 RID: 2995
			[Register("onFocusChange", "(Landroid/view/View;Z)V", "GetOnFocusChange_Landroid_view_View_ZHandler:Android.Views.View/IOnFocusChangeListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			void OnFocusChange(View v, bool hasFocus);
		}

		// Token: 0x02000146 RID: 326
		[Register("android/view/View$OnFocusChangeListener", DoNotGenerateAcw = true)]
		internal class IOnFocusChangeListenerInvoker : Java.Lang.Object, View.IOnFocusChangeListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x1700023A RID: 570
			// (get) Token: 0x06000BB4 RID: 2996 RVA: 0x0001D94C File Offset: 0x0001BB4C
			private static IntPtr java_class_ref
			{
				get
				{
					return View.IOnFocusChangeListenerInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700023B RID: 571
			// (get) Token: 0x06000BB5 RID: 2997 RVA: 0x0001D970 File Offset: 0x0001BB70
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return View.IOnFocusChangeListenerInvoker._members;
				}
			}

			// Token: 0x1700023C RID: 572
			// (get) Token: 0x06000BB6 RID: 2998 RVA: 0x0001D977 File Offset: 0x0001BB77
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x1700023D RID: 573
			// (get) Token: 0x06000BB7 RID: 2999 RVA: 0x0001D97F File Offset: 0x0001BB7F
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return View.IOnFocusChangeListenerInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06000BB8 RID: 3000 RVA: 0x0001D98B File Offset: 0x0001BB8B
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, View.IOnFocusChangeListenerInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.view.View.OnFocusChangeListener'.");
				}
				return handle;
			}

			// Token: 0x06000BB9 RID: 3001 RVA: 0x0001D9B6 File Offset: 0x0001BBB6
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06000BBA RID: 3002 RVA: 0x0001D9E8 File Offset: 0x0001BBE8
			public IOnFocusChangeListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(View.IOnFocusChangeListenerInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x06000BBB RID: 3003 RVA: 0x0001DA20 File Offset: 0x0001BC20
			private static Delegate GetOnFocusChange_Landroid_view_View_ZHandler()
			{
				if (View.IOnFocusChangeListenerInvoker.cb_onFocusChange_Landroid_view_View_Z == null)
				{
					View.IOnFocusChangeListenerInvoker.cb_onFocusChange_Landroid_view_View_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLZ_V(View.IOnFocusChangeListenerInvoker.n_OnFocusChange_Landroid_view_View_Z));
				}
				return View.IOnFocusChangeListenerInvoker.cb_onFocusChange_Landroid_view_View_Z;
			}

			// Token: 0x06000BBC RID: 3004 RVA: 0x0001DA44 File Offset: 0x0001BC44
			private static void n_OnFocusChange_Landroid_view_View_Z(IntPtr jnienv, IntPtr native__this, IntPtr native_v, bool hasFocus)
			{
				View.IOnFocusChangeListener @object = Java.Lang.Object.GetObject<View.IOnFocusChangeListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				View object2 = Java.Lang.Object.GetObject<View>(native_v, JniHandleOwnership.DoNotTransfer);
				@object.OnFocusChange(object2, hasFocus);
			}

			// Token: 0x06000BBD RID: 3005 RVA: 0x0001DA68 File Offset: 0x0001BC68
			public unsafe void OnFocusChange(View v, bool hasFocus)
			{
				if (this.id_onFocusChange_Landroid_view_View_Z == IntPtr.Zero)
				{
					this.id_onFocusChange_Landroid_view_View_Z = JNIEnv.GetMethodID(this.class_ref, "onFocusChange", "(Landroid/view/View;Z)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((v == null) ? IntPtr.Zero : v.Handle);
				ptr[1] = new JValue(hasFocus);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onFocusChange_Landroid_view_View_Z, ptr);
			}

			// Token: 0x040003C8 RID: 968
			private static readonly JniPeerMembers _members = new XAPeerMembers("android/view/View$OnFocusChangeListener", typeof(View.IOnFocusChangeListenerInvoker));

			// Token: 0x040003C9 RID: 969
			private IntPtr class_ref;

			// Token: 0x040003CA RID: 970
			private static Delegate cb_onFocusChange_Landroid_view_View_Z;

			// Token: 0x040003CB RID: 971
			private IntPtr id_onFocusChange_Landroid_view_View_Z;
		}

		// Token: 0x02000147 RID: 327
		[Register("android/view/View$OnLongClickListener", "", "Android.Views.View/IOnLongClickListenerInvoker")]
		public interface IOnLongClickListener : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06000BBF RID: 3007
			[Register("onLongClick", "(Landroid/view/View;)Z", "GetOnLongClick_Landroid_view_View_Handler:Android.Views.View/IOnLongClickListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			bool OnLongClick(View v);
		}

		// Token: 0x02000148 RID: 328
		[Register("android/view/View$OnLongClickListener", DoNotGenerateAcw = true)]
		internal class IOnLongClickListenerInvoker : Java.Lang.Object, View.IOnLongClickListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x1700023E RID: 574
			// (get) Token: 0x06000BC0 RID: 3008 RVA: 0x0001DB0C File Offset: 0x0001BD0C
			private static IntPtr java_class_ref
			{
				get
				{
					return View.IOnLongClickListenerInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700023F RID: 575
			// (get) Token: 0x06000BC1 RID: 3009 RVA: 0x0001DB30 File Offset: 0x0001BD30
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return View.IOnLongClickListenerInvoker._members;
				}
			}

			// Token: 0x17000240 RID: 576
			// (get) Token: 0x06000BC2 RID: 3010 RVA: 0x0001DB37 File Offset: 0x0001BD37
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x17000241 RID: 577
			// (get) Token: 0x06000BC3 RID: 3011 RVA: 0x0001DB3F File Offset: 0x0001BD3F
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return View.IOnLongClickListenerInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06000BC4 RID: 3012 RVA: 0x0001DB4B File Offset: 0x0001BD4B
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, View.IOnLongClickListenerInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.view.View.OnLongClickListener'.");
				}
				return handle;
			}

			// Token: 0x06000BC5 RID: 3013 RVA: 0x0001DB76 File Offset: 0x0001BD76
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06000BC6 RID: 3014 RVA: 0x0001DBA8 File Offset: 0x0001BDA8
			public IOnLongClickListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(View.IOnLongClickListenerInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x06000BC7 RID: 3015 RVA: 0x0001DBE0 File Offset: 0x0001BDE0
			private static Delegate GetOnLongClick_Landroid_view_View_Handler()
			{
				if (View.IOnLongClickListenerInvoker.cb_onLongClick_Landroid_view_View_ == null)
				{
					View.IOnLongClickListenerInvoker.cb_onLongClick_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(View.IOnLongClickListenerInvoker.n_OnLongClick_Landroid_view_View_));
				}
				return View.IOnLongClickListenerInvoker.cb_onLongClick_Landroid_view_View_;
			}

			// Token: 0x06000BC8 RID: 3016 RVA: 0x0001DC04 File Offset: 0x0001BE04
			private static bool n_OnLongClick_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_v)
			{
				View.IOnLongClickListener @object = Java.Lang.Object.GetObject<View.IOnLongClickListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				View object2 = Java.Lang.Object.GetObject<View>(native_v, JniHandleOwnership.DoNotTransfer);
				return @object.OnLongClick(object2);
			}

			// Token: 0x06000BC9 RID: 3017 RVA: 0x0001DC28 File Offset: 0x0001BE28
			public unsafe bool OnLongClick(View v)
			{
				if (this.id_onLongClick_Landroid_view_View_ == IntPtr.Zero)
				{
					this.id_onLongClick_Landroid_view_View_ = JNIEnv.GetMethodID(this.class_ref, "onLongClick", "(Landroid/view/View;)Z");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((v == null) ? IntPtr.Zero : v.Handle);
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_onLongClick_Landroid_view_View_, ptr);
			}

			// Token: 0x040003CC RID: 972
			private static readonly JniPeerMembers _members = new XAPeerMembers("android/view/View$OnLongClickListener", typeof(View.IOnLongClickListenerInvoker));

			// Token: 0x040003CD RID: 973
			private IntPtr class_ref;

			// Token: 0x040003CE RID: 974
			private static Delegate cb_onLongClick_Landroid_view_View_;

			// Token: 0x040003CF RID: 975
			private IntPtr id_onLongClick_Landroid_view_View_;
		}

		// Token: 0x02000149 RID: 329
		public class LongClickEventArgs : EventArgs
		{
			// Token: 0x17000242 RID: 578
			// (get) Token: 0x06000BCB RID: 3019 RVA: 0x0001DCB6 File Offset: 0x0001BEB6
			public bool Handled
			{
				get
				{
					return this.handled;
				}
			}

			// Token: 0x06000BCC RID: 3020 RVA: 0x0001DCBE File Offset: 0x0001BEBE
			public LongClickEventArgs(bool handled)
			{
				this.handled = handled;
			}

			// Token: 0x040003D0 RID: 976
			private bool handled;
		}

		// Token: 0x0200014A RID: 330
		[Register("mono/android/view/View_OnLongClickListenerImplementor")]
		internal sealed class IOnLongClickListenerImplementor : Java.Lang.Object, View.IOnLongClickListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06000BCD RID: 3021 RVA: 0x0001DCCD File Offset: 0x0001BECD
			public IOnLongClickListenerImplementor() : base(JNIEnv.StartCreateInstance("mono/android/view/View_OnLongClickListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
			{
				JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
			}

			// Token: 0x06000BCE RID: 3022 RVA: 0x0001DD00 File Offset: 0x0001BF00
			public bool OnLongClick(View v)
			{
				EventHandler<View.LongClickEventArgs> handler = this.Handler;
				if (handler == null)
				{
					return false;
				}
				View.LongClickEventArgs longClickEventArgs = new View.LongClickEventArgs(true);
				handler(v, longClickEventArgs);
				return longClickEventArgs.Handled;
			}

			// Token: 0x06000BCF RID: 3023 RVA: 0x0001DD2E File Offset: 0x0001BF2E
			internal static bool __IsEmpty(View.IOnLongClickListenerImplementor value)
			{
				return value.Handler == null;
			}

			// Token: 0x040003D1 RID: 977
			public EventHandler<View.LongClickEventArgs> Handler;
		}

		// Token: 0x0200014B RID: 331
		[Register("android/view/View$OnScrollChangeListener", "", "Android.Views.View/IOnScrollChangeListenerInvoker", ApiSince = 23)]
		public interface IOnScrollChangeListener : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06000BD0 RID: 3024
			[Register("onScrollChange", "(Landroid/view/View;IIII)V", "GetOnScrollChange_Landroid_view_View_IIIIHandler:Android.Views.View/IOnScrollChangeListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null", ApiSince = 23)]
			void OnScrollChange(View v, int scrollX, int scrollY, int oldScrollX, int oldScrollY);
		}

		// Token: 0x0200014C RID: 332
		[Register("android/view/View$OnScrollChangeListener", DoNotGenerateAcw = true, ApiSince = 23)]
		internal class IOnScrollChangeListenerInvoker : Java.Lang.Object, View.IOnScrollChangeListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000243 RID: 579
			// (get) Token: 0x06000BD1 RID: 3025 RVA: 0x0001DD3C File Offset: 0x0001BF3C
			private static IntPtr java_class_ref
			{
				get
				{
					return View.IOnScrollChangeListenerInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000244 RID: 580
			// (get) Token: 0x06000BD2 RID: 3026 RVA: 0x0001DD60 File Offset: 0x0001BF60
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return View.IOnScrollChangeListenerInvoker._members;
				}
			}

			// Token: 0x17000245 RID: 581
			// (get) Token: 0x06000BD3 RID: 3027 RVA: 0x0001DD67 File Offset: 0x0001BF67
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x17000246 RID: 582
			// (get) Token: 0x06000BD4 RID: 3028 RVA: 0x0001DD6F File Offset: 0x0001BF6F
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return View.IOnScrollChangeListenerInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06000BD5 RID: 3029 RVA: 0x0001DD7B File Offset: 0x0001BF7B
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, View.IOnScrollChangeListenerInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.view.View.OnScrollChangeListener'.");
				}
				return handle;
			}

			// Token: 0x06000BD6 RID: 3030 RVA: 0x0001DDA6 File Offset: 0x0001BFA6
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06000BD7 RID: 3031 RVA: 0x0001DDD8 File Offset: 0x0001BFD8
			public IOnScrollChangeListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(View.IOnScrollChangeListenerInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x06000BD8 RID: 3032 RVA: 0x0001DE10 File Offset: 0x0001C010
			private static Delegate GetOnScrollChange_Landroid_view_View_IIIIHandler()
			{
				if (View.IOnScrollChangeListenerInvoker.cb_onScrollChange_Landroid_view_View_IIII == null)
				{
					View.IOnScrollChangeListenerInvoker.cb_onScrollChange_Landroid_view_View_IIII = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIIII_V(View.IOnScrollChangeListenerInvoker.n_OnScrollChange_Landroid_view_View_IIII));
				}
				return View.IOnScrollChangeListenerInvoker.cb_onScrollChange_Landroid_view_View_IIII;
			}

			// Token: 0x06000BD9 RID: 3033 RVA: 0x0001DE34 File Offset: 0x0001C034
			private static void n_OnScrollChange_Landroid_view_View_IIII(IntPtr jnienv, IntPtr native__this, IntPtr native_v, int scrollX, int scrollY, int oldScrollX, int oldScrollY)
			{
				View.IOnScrollChangeListener @object = Java.Lang.Object.GetObject<View.IOnScrollChangeListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				View object2 = Java.Lang.Object.GetObject<View>(native_v, JniHandleOwnership.DoNotTransfer);
				@object.OnScrollChange(object2, scrollX, scrollY, oldScrollX, oldScrollY);
			}

			// Token: 0x06000BDA RID: 3034 RVA: 0x0001DE60 File Offset: 0x0001C060
			public unsafe void OnScrollChange(View v, int scrollX, int scrollY, int oldScrollX, int oldScrollY)
			{
				if (this.id_onScrollChange_Landroid_view_View_IIII == IntPtr.Zero)
				{
					this.id_onScrollChange_Landroid_view_View_IIII = JNIEnv.GetMethodID(this.class_ref, "onScrollChange", "(Landroid/view/View;IIII)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((v == null) ? IntPtr.Zero : v.Handle);
				ptr[1] = new JValue(scrollX);
				ptr[2] = new JValue(scrollY);
				ptr[3] = new JValue(oldScrollX);
				ptr[4] = new JValue(oldScrollY);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onScrollChange_Landroid_view_View_IIII, ptr);
			}

			// Token: 0x040003D2 RID: 978
			private static readonly JniPeerMembers _members = new XAPeerMembers("android/view/View$OnScrollChangeListener", typeof(View.IOnScrollChangeListenerInvoker));

			// Token: 0x040003D3 RID: 979
			private IntPtr class_ref;

			// Token: 0x040003D4 RID: 980
			private static Delegate cb_onScrollChange_Landroid_view_View_IIII;

			// Token: 0x040003D5 RID: 981
			private IntPtr id_onScrollChange_Landroid_view_View_IIII;
		}

		// Token: 0x0200014D RID: 333
		public class ScrollChangeEventArgs : EventArgs
		{
			// Token: 0x06000BDC RID: 3036 RVA: 0x0001DF45 File Offset: 0x0001C145
			public ScrollChangeEventArgs(View v, int scrollX, int scrollY, int oldScrollX, int oldScrollY)
			{
				this.v = v;
				this.scrollX = scrollX;
				this.scrollY = scrollY;
				this.oldScrollX = oldScrollX;
				this.oldScrollY = oldScrollY;
			}

			// Token: 0x17000247 RID: 583
			// (get) Token: 0x06000BDD RID: 3037 RVA: 0x0001DF72 File Offset: 0x0001C172
			public int ScrollY
			{
				get
				{
					return this.scrollY;
				}
			}

			// Token: 0x040003D6 RID: 982
			private View v;

			// Token: 0x040003D7 RID: 983
			private int scrollX;

			// Token: 0x040003D8 RID: 984
			private int scrollY;

			// Token: 0x040003D9 RID: 985
			private int oldScrollX;

			// Token: 0x040003DA RID: 986
			private int oldScrollY;
		}

		// Token: 0x0200014E RID: 334
		[Register("mono/android/view/View_OnScrollChangeListenerImplementor", ApiSince = 23)]
		internal sealed class IOnScrollChangeListenerImplementor : Java.Lang.Object, View.IOnScrollChangeListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06000BDE RID: 3038 RVA: 0x0001DF7A File Offset: 0x0001C17A
			public IOnScrollChangeListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/android/view/View_OnScrollChangeListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
			{
				JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
				this.sender = sender;
			}

			// Token: 0x06000BDF RID: 3039 RVA: 0x0001DFB4 File Offset: 0x0001C1B4
			public void OnScrollChange(View v, int scrollX, int scrollY, int oldScrollX, int oldScrollY)
			{
				EventHandler<View.ScrollChangeEventArgs> handler = this.Handler;
				if (handler != null)
				{
					handler(this.sender, new View.ScrollChangeEventArgs(v, scrollX, scrollY, oldScrollX, oldScrollY));
				}
			}

			// Token: 0x06000BE0 RID: 3040 RVA: 0x0001DFE3 File Offset: 0x0001C1E3
			internal static bool __IsEmpty(View.IOnScrollChangeListenerImplementor value)
			{
				return value.Handler == null;
			}

			// Token: 0x040003DB RID: 987
			private object sender;

			// Token: 0x040003DC RID: 988
			public EventHandler<View.ScrollChangeEventArgs> Handler;
		}

		// Token: 0x0200014F RID: 335
		[Register("android/view/View$OnTouchListener", "", "Android.Views.View/IOnTouchListenerInvoker")]
		public interface IOnTouchListener : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06000BE1 RID: 3041
			[Register("onTouch", "(Landroid/view/View;Landroid/view/MotionEvent;)Z", "GetOnTouch_Landroid_view_View_Landroid_view_MotionEvent_Handler:Android.Views.View/IOnTouchListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			bool OnTouch(View v, MotionEvent e);
		}

		// Token: 0x02000150 RID: 336
		[Register("android/view/View$OnTouchListener", DoNotGenerateAcw = true)]
		internal class IOnTouchListenerInvoker : Java.Lang.Object, View.IOnTouchListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000248 RID: 584
			// (get) Token: 0x06000BE2 RID: 3042 RVA: 0x0001DFF0 File Offset: 0x0001C1F0
			private static IntPtr java_class_ref
			{
				get
				{
					return View.IOnTouchListenerInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000249 RID: 585
			// (get) Token: 0x06000BE3 RID: 3043 RVA: 0x0001E014 File Offset: 0x0001C214
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return View.IOnTouchListenerInvoker._members;
				}
			}

			// Token: 0x1700024A RID: 586
			// (get) Token: 0x06000BE4 RID: 3044 RVA: 0x0001E01B File Offset: 0x0001C21B
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x1700024B RID: 587
			// (get) Token: 0x06000BE5 RID: 3045 RVA: 0x0001E023 File Offset: 0x0001C223
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return View.IOnTouchListenerInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06000BE6 RID: 3046 RVA: 0x0001E02F File Offset: 0x0001C22F
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, View.IOnTouchListenerInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.view.View.OnTouchListener'.");
				}
				return handle;
			}

			// Token: 0x06000BE7 RID: 3047 RVA: 0x0001E05A File Offset: 0x0001C25A
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06000BE8 RID: 3048 RVA: 0x0001E08C File Offset: 0x0001C28C
			public IOnTouchListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(View.IOnTouchListenerInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x06000BE9 RID: 3049 RVA: 0x0001E0C4 File Offset: 0x0001C2C4
			private static Delegate GetOnTouch_Landroid_view_View_Landroid_view_MotionEvent_Handler()
			{
				if (View.IOnTouchListenerInvoker.cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_ == null)
				{
					View.IOnTouchListenerInvoker.cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_Z(View.IOnTouchListenerInvoker.n_OnTouch_Landroid_view_View_Landroid_view_MotionEvent_));
				}
				return View.IOnTouchListenerInvoker.cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_;
			}

			// Token: 0x06000BEA RID: 3050 RVA: 0x0001E0E8 File Offset: 0x0001C2E8
			private static bool n_OnTouch_Landroid_view_View_Landroid_view_MotionEvent_(IntPtr jnienv, IntPtr native__this, IntPtr native_v, IntPtr native_e)
			{
				View.IOnTouchListener @object = Java.Lang.Object.GetObject<View.IOnTouchListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				View object2 = Java.Lang.Object.GetObject<View>(native_v, JniHandleOwnership.DoNotTransfer);
				MotionEvent object3 = Java.Lang.Object.GetObject<MotionEvent>(native_e, JniHandleOwnership.DoNotTransfer);
				return @object.OnTouch(object2, object3);
			}

			// Token: 0x06000BEB RID: 3051 RVA: 0x0001E114 File Offset: 0x0001C314
			public unsafe bool OnTouch(View v, MotionEvent e)
			{
				if (this.id_onTouch_Landroid_view_View_Landroid_view_MotionEvent_ == IntPtr.Zero)
				{
					this.id_onTouch_Landroid_view_View_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID(this.class_ref, "onTouch", "(Landroid/view/View;Landroid/view/MotionEvent;)Z");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((v == null) ? IntPtr.Zero : v.Handle);
				ptr[1] = new JValue((e == null) ? IntPtr.Zero : e.Handle);
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_onTouch_Landroid_view_View_Landroid_view_MotionEvent_, ptr);
			}

			// Token: 0x040003DD RID: 989
			private static readonly JniPeerMembers _members = new XAPeerMembers("android/view/View$OnTouchListener", typeof(View.IOnTouchListenerInvoker));

			// Token: 0x040003DE RID: 990
			private IntPtr class_ref;

			// Token: 0x040003DF RID: 991
			private static Delegate cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_;

			// Token: 0x040003E0 RID: 992
			private IntPtr id_onTouch_Landroid_view_View_Landroid_view_MotionEvent_;
		}

		// Token: 0x02000151 RID: 337
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040003E1 RID: 993
			public static Func<View.IOnClickListenerImplementor, bool> <4>____IsEmpty;

			// Token: 0x040003E2 RID: 994
			public static Func<View.IOnLongClickListenerImplementor, bool> <11>____IsEmpty;

			// Token: 0x040003E3 RID: 995
			public static Func<View.IOnScrollChangeListenerImplementor, bool> <12>____IsEmpty;
		}
	}
}
