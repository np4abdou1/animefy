using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Animation;
using Android.Content;
using Android.Content.Res;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Runtime;
using Android.Text;
using Android.Util;
using Android.Views;
using Android.Widget;
using Google.Android.Material.Internal;
using Java.Interop;
using Java.Lang;

namespace Google.Android.Material.AppBar
{
	// Token: 0x0200009A RID: 154
	[Register("com/google/android/material/appbar/CollapsingToolbarLayout", DoNotGenerateAcw = true)]
	public class CollapsingToolbarLayout : FrameLayout
	{
		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06000A73 RID: 2675 RVA: 0x0001B27E File Offset: 0x0001947E
		// (set) Token: 0x06000A74 RID: 2676 RVA: 0x0001B286 File Offset: 0x00019486
		public override ViewStates Visibility
		{
			get
			{
				return base.Visibility;
			}
			set
			{
				base.Visibility = value;
			}
		}

		// Token: 0x06000A75 RID: 2677 RVA: 0x0001C64D File Offset: 0x0001A84D
		public void SetTitle(string title)
		{
			this.Title = title;
		}

		// Token: 0x06000A76 RID: 2678 RVA: 0x0001B28F File Offset: 0x0001948F
		public void SetVisibility(ViewStates visibility)
		{
			this.Visibility = visibility;
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000A77 RID: 2679 RVA: 0x0001C658 File Offset: 0x0001A858
		internal static IntPtr class_ref
		{
			get
			{
				return CollapsingToolbarLayout._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06000A78 RID: 2680 RVA: 0x0001C67C File Offset: 0x0001A87C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CollapsingToolbarLayout._members;
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06000A79 RID: 2681 RVA: 0x0001C684 File Offset: 0x0001A884
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CollapsingToolbarLayout._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06000A7A RID: 2682 RVA: 0x0001C6A8 File Offset: 0x0001A8A8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CollapsingToolbarLayout._members.ManagedPeerType;
			}
		}

		// Token: 0x06000A7B RID: 2683 RVA: 0x0001B814 File Offset: 0x00019A14
		protected CollapsingToolbarLayout(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000A7C RID: 2684 RVA: 0x0001C6B4 File Offset: 0x0001A8B4
		[Register(".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe CollapsingToolbarLayout(Context context) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				base.SetHandle(CollapsingToolbarLayout._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				CollapsingToolbarLayout._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
		}

		// Token: 0x06000A7D RID: 2685 RVA: 0x0001C764 File Offset: 0x0001A964
		[Register(".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe CollapsingToolbarLayout(Context context, IAttributeSet attrs) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(CollapsingToolbarLayout._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				CollapsingToolbarLayout._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x06000A7E RID: 2686 RVA: 0x0001C840 File Offset: 0x0001AA40
		[Register(".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe CollapsingToolbarLayout(Context context, IAttributeSet attrs, int defStyleAttr) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(CollapsingToolbarLayout._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				CollapsingToolbarLayout._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x06000A7F RID: 2687 RVA: 0x0001C930 File Offset: 0x0001AB30
		private static Delegate GetGetCollapsedTitleGravityHandler()
		{
			if (CollapsingToolbarLayout.cb_getCollapsedTitleGravity == null)
			{
				CollapsingToolbarLayout.cb_getCollapsedTitleGravity = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(CollapsingToolbarLayout.n_GetCollapsedTitleGravity));
			}
			return CollapsingToolbarLayout.cb_getCollapsedTitleGravity;
		}

		// Token: 0x06000A80 RID: 2688 RVA: 0x0001C954 File Offset: 0x0001AB54
		private static int n_GetCollapsedTitleGravity(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<CollapsingToolbarLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CollapsedTitleGravity;
		}

		// Token: 0x06000A81 RID: 2689 RVA: 0x0001C963 File Offset: 0x0001AB63
		private static Delegate GetSetCollapsedTitleGravity_IHandler()
		{
			if (CollapsingToolbarLayout.cb_setCollapsedTitleGravity_I == null)
			{
				CollapsingToolbarLayout.cb_setCollapsedTitleGravity_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(CollapsingToolbarLayout.n_SetCollapsedTitleGravity_I));
			}
			return CollapsingToolbarLayout.cb_setCollapsedTitleGravity_I;
		}

		// Token: 0x06000A82 RID: 2690 RVA: 0x0001C987 File Offset: 0x0001AB87
		private static void n_SetCollapsedTitleGravity_I(IntPtr jnienv, IntPtr native__this, int gravity)
		{
			Java.Lang.Object.GetObject<CollapsingToolbarLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CollapsedTitleGravity = gravity;
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000A83 RID: 2691 RVA: 0x0001C997 File Offset: 0x0001AB97
		// (set) Token: 0x06000A84 RID: 2692 RVA: 0x0001C9B0 File Offset: 0x0001ABB0
		public unsafe virtual int CollapsedTitleGravity
		{
			[Register("getCollapsedTitleGravity", "()I", "GetGetCollapsedTitleGravityHandler")]
			get
			{
				return CollapsingToolbarLayout._members.InstanceMethods.InvokeVirtualInt32Method("getCollapsedTitleGravity.()I", this, null);
			}
			[Register("setCollapsedTitleGravity", "(I)V", "GetSetCollapsedTitleGravity_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				CollapsingToolbarLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setCollapsedTitleGravity.(I)V", this, ptr);
			}
		}

		// Token: 0x06000A85 RID: 2693 RVA: 0x0001C9EB File Offset: 0x0001ABEB
		private static Delegate GetGetCollapsedTitleTextSizeHandler()
		{
			if (CollapsingToolbarLayout.cb_getCollapsedTitleTextSize == null)
			{
				CollapsingToolbarLayout.cb_getCollapsedTitleTextSize = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_F(CollapsingToolbarLayout.n_GetCollapsedTitleTextSize));
			}
			return CollapsingToolbarLayout.cb_getCollapsedTitleTextSize;
		}

		// Token: 0x06000A86 RID: 2694 RVA: 0x0001CA0F File Offset: 0x0001AC0F
		private static float n_GetCollapsedTitleTextSize(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<CollapsingToolbarLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CollapsedTitleTextSize;
		}

		// Token: 0x06000A87 RID: 2695 RVA: 0x0001CA1E File Offset: 0x0001AC1E
		private static Delegate GetSetCollapsedTitleTextSize_FHandler()
		{
			if (CollapsingToolbarLayout.cb_setCollapsedTitleTextSize_F == null)
			{
				CollapsingToolbarLayout.cb_setCollapsedTitleTextSize_F = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPF_V(CollapsingToolbarLayout.n_SetCollapsedTitleTextSize_F));
			}
			return CollapsingToolbarLayout.cb_setCollapsedTitleTextSize_F;
		}

		// Token: 0x06000A88 RID: 2696 RVA: 0x0001CA42 File Offset: 0x0001AC42
		private static void n_SetCollapsedTitleTextSize_F(IntPtr jnienv, IntPtr native__this, float textSize)
		{
			Java.Lang.Object.GetObject<CollapsingToolbarLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CollapsedTitleTextSize = textSize;
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000A89 RID: 2697 RVA: 0x0001CA52 File Offset: 0x0001AC52
		// (set) Token: 0x06000A8A RID: 2698 RVA: 0x0001CA6C File Offset: 0x0001AC6C
		public unsafe virtual float CollapsedTitleTextSize
		{
			[Register("getCollapsedTitleTextSize", "()F", "GetGetCollapsedTitleTextSizeHandler")]
			get
			{
				return CollapsingToolbarLayout._members.InstanceMethods.InvokeVirtualSingleMethod("getCollapsedTitleTextSize.()F", this, null);
			}
			[Register("setCollapsedTitleTextSize", "(F)V", "GetSetCollapsedTitleTextSize_FHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				CollapsingToolbarLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setCollapsedTitleTextSize.(F)V", this, ptr);
			}
		}

		// Token: 0x06000A8B RID: 2699 RVA: 0x0001CAA7 File Offset: 0x0001ACA7
		private static Delegate GetGetCollapsedTitleTypefaceHandler()
		{
			if (CollapsingToolbarLayout.cb_getCollapsedTitleTypeface == null)
			{
				CollapsingToolbarLayout.cb_getCollapsedTitleTypeface = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(CollapsingToolbarLayout.n_GetCollapsedTitleTypeface));
			}
			return CollapsingToolbarLayout.cb_getCollapsedTitleTypeface;
		}

		// Token: 0x06000A8C RID: 2700 RVA: 0x0001CACB File Offset: 0x0001ACCB
		private static IntPtr n_GetCollapsedTitleTypeface(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<CollapsingToolbarLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CollapsedTitleTypeface);
		}

		// Token: 0x06000A8D RID: 2701 RVA: 0x0001CADF File Offset: 0x0001ACDF
		private static Delegate GetSetCollapsedTitleTypeface_Landroid_graphics_Typeface_Handler()
		{
			if (CollapsingToolbarLayout.cb_setCollapsedTitleTypeface_Landroid_graphics_Typeface_ == null)
			{
				CollapsingToolbarLayout.cb_setCollapsedTitleTypeface_Landroid_graphics_Typeface_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(CollapsingToolbarLayout.n_SetCollapsedTitleTypeface_Landroid_graphics_Typeface_));
			}
			return CollapsingToolbarLayout.cb_setCollapsedTitleTypeface_Landroid_graphics_Typeface_;
		}

		// Token: 0x06000A8E RID: 2702 RVA: 0x0001CB04 File Offset: 0x0001AD04
		private static void n_SetCollapsedTitleTypeface_Landroid_graphics_Typeface_(IntPtr jnienv, IntPtr native__this, IntPtr native_typeface)
		{
			CollapsingToolbarLayout @object = Java.Lang.Object.GetObject<CollapsingToolbarLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Typeface object2 = Java.Lang.Object.GetObject<Typeface>(native_typeface, JniHandleOwnership.DoNotTransfer);
			@object.CollapsedTitleTypeface = object2;
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06000A8F RID: 2703 RVA: 0x0001CB28 File Offset: 0x0001AD28
		// (set) Token: 0x06000A90 RID: 2704 RVA: 0x0001CB5C File Offset: 0x0001AD5C
		public unsafe virtual Typeface CollapsedTitleTypeface
		{
			[Register("getCollapsedTitleTypeface", "()Landroid/graphics/Typeface;", "GetGetCollapsedTitleTypefaceHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Typeface>(CollapsingToolbarLayout._members.InstanceMethods.InvokeVirtualObjectMethod("getCollapsedTitleTypeface.()Landroid/graphics/Typeface;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setCollapsedTitleTypeface", "(Landroid/graphics/Typeface;)V", "GetSetCollapsedTitleTypeface_Landroid_graphics_Typeface_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					CollapsingToolbarLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setCollapsedTitleTypeface.(Landroid/graphics/Typeface;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x06000A91 RID: 2705 RVA: 0x0001CBC0 File Offset: 0x0001ADC0
		private static Delegate GetGetContentScrimHandler()
		{
			if (CollapsingToolbarLayout.cb_getContentScrim == null)
			{
				CollapsingToolbarLayout.cb_getContentScrim = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(CollapsingToolbarLayout.n_GetContentScrim));
			}
			return CollapsingToolbarLayout.cb_getContentScrim;
		}

		// Token: 0x06000A92 RID: 2706 RVA: 0x0001CBE4 File Offset: 0x0001ADE4
		private static IntPtr n_GetContentScrim(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<CollapsingToolbarLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ContentScrim);
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x0001CBF8 File Offset: 0x0001ADF8
		private static Delegate GetSetContentScrim_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (CollapsingToolbarLayout.cb_setContentScrim_Landroid_graphics_drawable_Drawable_ == null)
			{
				CollapsingToolbarLayout.cb_setContentScrim_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(CollapsingToolbarLayout.n_SetContentScrim_Landroid_graphics_drawable_Drawable_));
			}
			return CollapsingToolbarLayout.cb_setContentScrim_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x06000A94 RID: 2708 RVA: 0x0001CC1C File Offset: 0x0001AE1C
		private static void n_SetContentScrim_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_drawable)
		{
			CollapsingToolbarLayout @object = Java.Lang.Object.GetObject<CollapsingToolbarLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_drawable, JniHandleOwnership.DoNotTransfer);
			@object.ContentScrim = object2;
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06000A95 RID: 2709 RVA: 0x0001CC40 File Offset: 0x0001AE40
		// (set) Token: 0x06000A96 RID: 2710 RVA: 0x0001CC74 File Offset: 0x0001AE74
		public unsafe virtual Drawable ContentScrim
		{
			[Register("getContentScrim", "()Landroid/graphics/drawable/Drawable;", "GetGetContentScrimHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Drawable>(CollapsingToolbarLayout._members.InstanceMethods.InvokeVirtualObjectMethod("getContentScrim.()Landroid/graphics/drawable/Drawable;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setContentScrim", "(Landroid/graphics/drawable/Drawable;)V", "GetSetContentScrim_Landroid_graphics_drawable_Drawable_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					CollapsingToolbarLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setContentScrim.(Landroid/graphics/drawable/Drawable;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x06000A97 RID: 2711 RVA: 0x0001CCD8 File Offset: 0x0001AED8
		private static Delegate GetGetExpandedTitleGravityHandler()
		{
			if (CollapsingToolbarLayout.cb_getExpandedTitleGravity == null)
			{
				CollapsingToolbarLayout.cb_getExpandedTitleGravity = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(CollapsingToolbarLayout.n_GetExpandedTitleGravity));
			}
			return CollapsingToolbarLayout.cb_getExpandedTitleGravity;
		}

		// Token: 0x06000A98 RID: 2712 RVA: 0x0001CCFC File Offset: 0x0001AEFC
		private static int n_GetExpandedTitleGravity(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<CollapsingToolbarLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ExpandedTitleGravity;
		}

		// Token: 0x06000A99 RID: 2713 RVA: 0x0001CD0B File Offset: 0x0001AF0B
		private static Delegate GetSetExpandedTitleGravity_IHandler()
		{
			if (CollapsingToolbarLayout.cb_setExpandedTitleGravity_I == null)
			{
				CollapsingToolbarLayout.cb_setExpandedTitleGravity_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(CollapsingToolbarLayout.n_SetExpandedTitleGravity_I));
			}
			return CollapsingToolbarLayout.cb_setExpandedTitleGravity_I;
		}

		// Token: 0x06000A9A RID: 2714 RVA: 0x0001CD2F File Offset: 0x0001AF2F
		private static void n_SetExpandedTitleGravity_I(IntPtr jnienv, IntPtr native__this, int gravity)
		{
			Java.Lang.Object.GetObject<CollapsingToolbarLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ExpandedTitleGravity = gravity;
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000A9B RID: 2715 RVA: 0x0001CD3F File Offset: 0x0001AF3F
		// (set) Token: 0x06000A9C RID: 2716 RVA: 0x0001CD58 File Offset: 0x0001AF58
		public unsafe virtual int ExpandedTitleGravity
		{
			[Register("getExpandedTitleGravity", "()I", "GetGetExpandedTitleGravityHandler")]
			get
			{
				return CollapsingToolbarLayout._members.InstanceMethods.InvokeVirtualInt32Method("getExpandedTitleGravity.()I", this, null);
			}
			[Register("setExpandedTitleGravity", "(I)V", "GetSetExpandedTitleGravity_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				CollapsingToolbarLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setExpandedTitleGravity.(I)V", this, ptr);
			}
		}

		// Token: 0x06000A9D RID: 2717 RVA: 0x0001CD93 File Offset: 0x0001AF93
		private static Delegate GetGetExpandedTitleMarginBottomHandler()
		{
			if (CollapsingToolbarLayout.cb_getExpandedTitleMarginBottom == null)
			{
				CollapsingToolbarLayout.cb_getExpandedTitleMarginBottom = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(CollapsingToolbarLayout.n_GetExpandedTitleMarginBottom));
			}
			return CollapsingToolbarLayout.cb_getExpandedTitleMarginBottom;
		}

		// Token: 0x06000A9E RID: 2718 RVA: 0x0001CDB7 File Offset: 0x0001AFB7
		private static int n_GetExpandedTitleMarginBottom(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<CollapsingToolbarLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ExpandedTitleMarginBottom;
		}

		// Token: 0x06000A9F RID: 2719 RVA: 0x0001CDC6 File Offset: 0x0001AFC6
		private static Delegate GetSetExpandedTitleMarginBottom_IHandler()
		{
			if (CollapsingToolbarLayout.cb_setExpandedTitleMarginBottom_I == null)
			{
				CollapsingToolbarLayout.cb_setExpandedTitleMarginBottom_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(CollapsingToolbarLayout.n_SetExpandedTitleMarginBottom_I));
			}
			return CollapsingToolbarLayout.cb_setExpandedTitleMarginBottom_I;
		}

		// Token: 0x06000AA0 RID: 2720 RVA: 0x0001CDEA File Offset: 0x0001AFEA
		private static void n_SetExpandedTitleMarginBottom_I(IntPtr jnienv, IntPtr native__this, int margin)
		{
			Java.Lang.Object.GetObject<CollapsingToolbarLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ExpandedTitleMarginBottom = margin;
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000AA1 RID: 2721 RVA: 0x0001CDFA File Offset: 0x0001AFFA
		// (set) Token: 0x06000AA2 RID: 2722 RVA: 0x0001CE14 File Offset: 0x0001B014
		public unsafe virtual int ExpandedTitleMarginBottom
		{
			[Register("getExpandedTitleMarginBottom", "()I", "GetGetExpandedTitleMarginBottomHandler")]
			get
			{
				return CollapsingToolbarLayout._members.InstanceMethods.InvokeVirtualInt32Method("getExpandedTitleMarginBottom.()I", this, null);
			}
			[Register("setExpandedTitleMarginBottom", "(I)V", "GetSetExpandedTitleMarginBottom_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				CollapsingToolbarLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setExpandedTitleMarginBottom.(I)V", this, ptr);
			}
		}

		// Token: 0x06000AA3 RID: 2723 RVA: 0x0001CE4F File Offset: 0x0001B04F
		private static Delegate GetGetExpandedTitleMarginEndHandler()
		{
			if (CollapsingToolbarLayout.cb_getExpandedTitleMarginEnd == null)
			{
				CollapsingToolbarLayout.cb_getExpandedTitleMarginEnd = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(CollapsingToolbarLayout.n_GetExpandedTitleMarginEnd));
			}
			return CollapsingToolbarLayout.cb_getExpandedTitleMarginEnd;
		}

		// Token: 0x06000AA4 RID: 2724 RVA: 0x0001CE73 File Offset: 0x0001B073
		private static int n_GetExpandedTitleMarginEnd(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<CollapsingToolbarLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ExpandedTitleMarginEnd;
		}

		// Token: 0x06000AA5 RID: 2725 RVA: 0x0001CE82 File Offset: 0x0001B082
		private static Delegate GetSetExpandedTitleMarginEnd_IHandler()
		{
			if (CollapsingToolbarLayout.cb_setExpandedTitleMarginEnd_I == null)
			{
				CollapsingToolbarLayout.cb_setExpandedTitleMarginEnd_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(CollapsingToolbarLayout.n_SetExpandedTitleMarginEnd_I));
			}
			return CollapsingToolbarLayout.cb_setExpandedTitleMarginEnd_I;
		}

		// Token: 0x06000AA6 RID: 2726 RVA: 0x0001CEA6 File Offset: 0x0001B0A6
		private static void n_SetExpandedTitleMarginEnd_I(IntPtr jnienv, IntPtr native__this, int margin)
		{
			Java.Lang.Object.GetObject<CollapsingToolbarLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ExpandedTitleMarginEnd = margin;
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06000AA7 RID: 2727 RVA: 0x0001CEB6 File Offset: 0x0001B0B6
		// (set) Token: 0x06000AA8 RID: 2728 RVA: 0x0001CED0 File Offset: 0x0001B0D0
		public unsafe virtual int ExpandedTitleMarginEnd
		{
			[Register("getExpandedTitleMarginEnd", "()I", "GetGetExpandedTitleMarginEndHandler")]
			get
			{
				return CollapsingToolbarLayout._members.InstanceMethods.InvokeVirtualInt32Method("getExpandedTitleMarginEnd.()I", this, null);
			}
			[Register("setExpandedTitleMarginEnd", "(I)V", "GetSetExpandedTitleMarginEnd_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				CollapsingToolbarLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setExpandedTitleMarginEnd.(I)V", this, ptr);
			}
		}

		// Token: 0x06000AA9 RID: 2729 RVA: 0x0001CF0B File Offset: 0x0001B10B
		private static Delegate GetGetExpandedTitleMarginStartHandler()
		{
			if (CollapsingToolbarLayout.cb_getExpandedTitleMarginStart == null)
			{
				CollapsingToolbarLayout.cb_getExpandedTitleMarginStart = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(CollapsingToolbarLayout.n_GetExpandedTitleMarginStart));
			}
			return CollapsingToolbarLayout.cb_getExpandedTitleMarginStart;
		}

		// Token: 0x06000AAA RID: 2730 RVA: 0x0001CF2F File Offset: 0x0001B12F
		private static int n_GetExpandedTitleMarginStart(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<CollapsingToolbarLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ExpandedTitleMarginStart;
		}

		// Token: 0x06000AAB RID: 2731 RVA: 0x0001CF3E File Offset: 0x0001B13E
		private static Delegate GetSetExpandedTitleMarginStart_IHandler()
		{
			if (CollapsingToolbarLayout.cb_setExpandedTitleMarginStart_I == null)
			{
				CollapsingToolbarLayout.cb_setExpandedTitleMarginStart_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(CollapsingToolbarLayout.n_SetExpandedTitleMarginStart_I));
			}
			return CollapsingToolbarLayout.cb_setExpandedTitleMarginStart_I;
		}

		// Token: 0x06000AAC RID: 2732 RVA: 0x0001CF62 File Offset: 0x0001B162
		private static void n_SetExpandedTitleMarginStart_I(IntPtr jnienv, IntPtr native__this, int margin)
		{
			Java.Lang.Object.GetObject<CollapsingToolbarLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ExpandedTitleMarginStart = margin;
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06000AAD RID: 2733 RVA: 0x0001CF72 File Offset: 0x0001B172
		// (set) Token: 0x06000AAE RID: 2734 RVA: 0x0001CF8C File Offset: 0x0001B18C
		public unsafe virtual int ExpandedTitleMarginStart
		{
			[Register("getExpandedTitleMarginStart", "()I", "GetGetExpandedTitleMarginStartHandler")]
			get
			{
				return CollapsingToolbarLayout._members.InstanceMethods.InvokeVirtualInt32Method("getExpandedTitleMarginStart.()I", this, null);
			}
			[Register("setExpandedTitleMarginStart", "(I)V", "GetSetExpandedTitleMarginStart_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				CollapsingToolbarLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setExpandedTitleMarginStart.(I)V", this, ptr);
			}
		}

		// Token: 0x06000AAF RID: 2735 RVA: 0x0001CFC7 File Offset: 0x0001B1C7
		private static Delegate GetGetExpandedTitleMarginTopHandler()
		{
			if (CollapsingToolbarLayout.cb_getExpandedTitleMarginTop == null)
			{
				CollapsingToolbarLayout.cb_getExpandedTitleMarginTop = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(CollapsingToolbarLayout.n_GetExpandedTitleMarginTop));
			}
			return CollapsingToolbarLayout.cb_getExpandedTitleMarginTop;
		}

		// Token: 0x06000AB0 RID: 2736 RVA: 0x0001CFEB File Offset: 0x0001B1EB
		private static int n_GetExpandedTitleMarginTop(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<CollapsingToolbarLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ExpandedTitleMarginTop;
		}

		// Token: 0x06000AB1 RID: 2737 RVA: 0x0001CFFA File Offset: 0x0001B1FA
		private static Delegate GetSetExpandedTitleMarginTop_IHandler()
		{
			if (CollapsingToolbarLayout.cb_setExpandedTitleMarginTop_I == null)
			{
				CollapsingToolbarLayout.cb_setExpandedTitleMarginTop_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(CollapsingToolbarLayout.n_SetExpandedTitleMarginTop_I));
			}
			return CollapsingToolbarLayout.cb_setExpandedTitleMarginTop_I;
		}

		// Token: 0x06000AB2 RID: 2738 RVA: 0x0001D01E File Offset: 0x0001B21E
		private static void n_SetExpandedTitleMarginTop_I(IntPtr jnienv, IntPtr native__this, int margin)
		{
			Java.Lang.Object.GetObject<CollapsingToolbarLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ExpandedTitleMarginTop = margin;
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06000AB3 RID: 2739 RVA: 0x0001D02E File Offset: 0x0001B22E
		// (set) Token: 0x06000AB4 RID: 2740 RVA: 0x0001D048 File Offset: 0x0001B248
		public unsafe virtual int ExpandedTitleMarginTop
		{
			[Register("getExpandedTitleMarginTop", "()I", "GetGetExpandedTitleMarginTopHandler")]
			get
			{
				return CollapsingToolbarLayout._members.InstanceMethods.InvokeVirtualInt32Method("getExpandedTitleMarginTop.()I", this, null);
			}
			[Register("setExpandedTitleMarginTop", "(I)V", "GetSetExpandedTitleMarginTop_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				CollapsingToolbarLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setExpandedTitleMarginTop.(I)V", this, ptr);
			}
		}

		// Token: 0x06000AB5 RID: 2741 RVA: 0x0001D083 File Offset: 0x0001B283
		private static Delegate GetGetExpandedTitleTextSizeHandler()
		{
			if (CollapsingToolbarLayout.cb_getExpandedTitleTextSize == null)
			{
				CollapsingToolbarLayout.cb_getExpandedTitleTextSize = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_F(CollapsingToolbarLayout.n_GetExpandedTitleTextSize));
			}
			return CollapsingToolbarLayout.cb_getExpandedTitleTextSize;
		}

		// Token: 0x06000AB6 RID: 2742 RVA: 0x0001D0A7 File Offset: 0x0001B2A7
		private static float n_GetExpandedTitleTextSize(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<CollapsingToolbarLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ExpandedTitleTextSize;
		}

		// Token: 0x06000AB7 RID: 2743 RVA: 0x0001D0B6 File Offset: 0x0001B2B6
		private static Delegate GetSetExpandedTitleTextSize_FHandler()
		{
			if (CollapsingToolbarLayout.cb_setExpandedTitleTextSize_F == null)
			{
				CollapsingToolbarLayout.cb_setExpandedTitleTextSize_F = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPF_V(CollapsingToolbarLayout.n_SetExpandedTitleTextSize_F));
			}
			return CollapsingToolbarLayout.cb_setExpandedTitleTextSize_F;
		}

		// Token: 0x06000AB8 RID: 2744 RVA: 0x0001D0DA File Offset: 0x0001B2DA
		private static void n_SetExpandedTitleTextSize_F(IntPtr jnienv, IntPtr native__this, float textSize)
		{
			Java.Lang.Object.GetObject<CollapsingToolbarLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ExpandedTitleTextSize = textSize;
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06000AB9 RID: 2745 RVA: 0x0001D0EA File Offset: 0x0001B2EA
		// (set) Token: 0x06000ABA RID: 2746 RVA: 0x0001D104 File Offset: 0x0001B304
		public unsafe virtual float ExpandedTitleTextSize
		{
			[Register("getExpandedTitleTextSize", "()F", "GetGetExpandedTitleTextSizeHandler")]
			get
			{
				return CollapsingToolbarLayout._members.InstanceMethods.InvokeVirtualSingleMethod("getExpandedTitleTextSize.()F", this, null);
			}
			[Register("setExpandedTitleTextSize", "(F)V", "GetSetExpandedTitleTextSize_FHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				CollapsingToolbarLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setExpandedTitleTextSize.(F)V", this, ptr);
			}
		}

		// Token: 0x06000ABB RID: 2747 RVA: 0x0001D13F File Offset: 0x0001B33F
		private static Delegate GetGetExpandedTitleTypefaceHandler()
		{
			if (CollapsingToolbarLayout.cb_getExpandedTitleTypeface == null)
			{
				CollapsingToolbarLayout.cb_getExpandedTitleTypeface = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(CollapsingToolbarLayout.n_GetExpandedTitleTypeface));
			}
			return CollapsingToolbarLayout.cb_getExpandedTitleTypeface;
		}

		// Token: 0x06000ABC RID: 2748 RVA: 0x0001D163 File Offset: 0x0001B363
		private static IntPtr n_GetExpandedTitleTypeface(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<CollapsingToolbarLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ExpandedTitleTypeface);
		}

		// Token: 0x06000ABD RID: 2749 RVA: 0x0001D177 File Offset: 0x0001B377
		private static Delegate GetSetExpandedTitleTypeface_Landroid_graphics_Typeface_Handler()
		{
			if (CollapsingToolbarLayout.cb_setExpandedTitleTypeface_Landroid_graphics_Typeface_ == null)
			{
				CollapsingToolbarLayout.cb_setExpandedTitleTypeface_Landroid_graphics_Typeface_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(CollapsingToolbarLayout.n_SetExpandedTitleTypeface_Landroid_graphics_Typeface_));
			}
			return CollapsingToolbarLayout.cb_setExpandedTitleTypeface_Landroid_graphics_Typeface_;
		}

		// Token: 0x06000ABE RID: 2750 RVA: 0x0001D19C File Offset: 0x0001B39C
		private static void n_SetExpandedTitleTypeface_Landroid_graphics_Typeface_(IntPtr jnienv, IntPtr native__this, IntPtr native_typeface)
		{
			CollapsingToolbarLayout @object = Java.Lang.Object.GetObject<CollapsingToolbarLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Typeface object2 = Java.Lang.Object.GetObject<Typeface>(native_typeface, JniHandleOwnership.DoNotTransfer);
			@object.ExpandedTitleTypeface = object2;
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06000ABF RID: 2751 RVA: 0x0001D1C0 File Offset: 0x0001B3C0
		// (set) Token: 0x06000AC0 RID: 2752 RVA: 0x0001D1F4 File Offset: 0x0001B3F4
		public unsafe virtual Typeface ExpandedTitleTypeface
		{
			[Register("getExpandedTitleTypeface", "()Landroid/graphics/Typeface;", "GetGetExpandedTitleTypefaceHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Typeface>(CollapsingToolbarLayout._members.InstanceMethods.InvokeVirtualObjectMethod("getExpandedTitleTypeface.()Landroid/graphics/Typeface;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setExpandedTitleTypeface", "(Landroid/graphics/Typeface;)V", "GetSetExpandedTitleTypeface_Landroid_graphics_Typeface_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					CollapsingToolbarLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setExpandedTitleTypeface.(Landroid/graphics/Typeface;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x06000AC1 RID: 2753 RVA: 0x0001D258 File Offset: 0x0001B458
		private static Delegate GetIsExtraMultilineHeightEnabledHandler()
		{
			if (CollapsingToolbarLayout.cb_isExtraMultilineHeightEnabled == null)
			{
				CollapsingToolbarLayout.cb_isExtraMultilineHeightEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(CollapsingToolbarLayout.n_IsExtraMultilineHeightEnabled));
			}
			return CollapsingToolbarLayout.cb_isExtraMultilineHeightEnabled;
		}

		// Token: 0x06000AC2 RID: 2754 RVA: 0x0001D27C File Offset: 0x0001B47C
		private static bool n_IsExtraMultilineHeightEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<CollapsingToolbarLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ExtraMultilineHeightEnabled;
		}

		// Token: 0x06000AC3 RID: 2755 RVA: 0x0001D28B File Offset: 0x0001B48B
		private static Delegate GetSetExtraMultilineHeightEnabled_ZHandler()
		{
			if (CollapsingToolbarLayout.cb_setExtraMultilineHeightEnabled_Z == null)
			{
				CollapsingToolbarLayout.cb_setExtraMultilineHeightEnabled_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(CollapsingToolbarLayout.n_SetExtraMultilineHeightEnabled_Z));
			}
			return CollapsingToolbarLayout.cb_setExtraMultilineHeightEnabled_Z;
		}

		// Token: 0x06000AC4 RID: 2756 RVA: 0x0001D2AF File Offset: 0x0001B4AF
		private static void n_SetExtraMultilineHeightEnabled_Z(IntPtr jnienv, IntPtr native__this, bool extraMultilineHeightEnabled)
		{
			Java.Lang.Object.GetObject<CollapsingToolbarLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ExtraMultilineHeightEnabled = extraMultilineHeightEnabled;
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06000AC5 RID: 2757 RVA: 0x0001D2BF File Offset: 0x0001B4BF
		// (set) Token: 0x06000AC6 RID: 2758 RVA: 0x0001D2D8 File Offset: 0x0001B4D8
		public unsafe virtual bool ExtraMultilineHeightEnabled
		{
			[Register("isExtraMultilineHeightEnabled", "()Z", "GetIsExtraMultilineHeightEnabledHandler")]
			get
			{
				return CollapsingToolbarLayout._members.InstanceMethods.InvokeVirtualBooleanMethod("isExtraMultilineHeightEnabled.()Z", this, null);
			}
			[Register("setExtraMultilineHeightEnabled", "(Z)V", "GetSetExtraMultilineHeightEnabled_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				CollapsingToolbarLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setExtraMultilineHeightEnabled.(Z)V", this, ptr);
			}
		}

		// Token: 0x06000AC7 RID: 2759 RVA: 0x0001D313 File Offset: 0x0001B513
		private static Delegate GetIsForceApplySystemWindowInsetTopHandler()
		{
			if (CollapsingToolbarLayout.cb_isForceApplySystemWindowInsetTop == null)
			{
				CollapsingToolbarLayout.cb_isForceApplySystemWindowInsetTop = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(CollapsingToolbarLayout.n_IsForceApplySystemWindowInsetTop));
			}
			return CollapsingToolbarLayout.cb_isForceApplySystemWindowInsetTop;
		}

		// Token: 0x06000AC8 RID: 2760 RVA: 0x0001D337 File Offset: 0x0001B537
		private static bool n_IsForceApplySystemWindowInsetTop(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<CollapsingToolbarLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ForceApplySystemWindowInsetTop;
		}

		// Token: 0x06000AC9 RID: 2761 RVA: 0x0001D346 File Offset: 0x0001B546
		private static Delegate GetSetForceApplySystemWindowInsetTop_ZHandler()
		{
			if (CollapsingToolbarLayout.cb_setForceApplySystemWindowInsetTop_Z == null)
			{
				CollapsingToolbarLayout.cb_setForceApplySystemWindowInsetTop_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(CollapsingToolbarLayout.n_SetForceApplySystemWindowInsetTop_Z));
			}
			return CollapsingToolbarLayout.cb_setForceApplySystemWindowInsetTop_Z;
		}

		// Token: 0x06000ACA RID: 2762 RVA: 0x0001D36A File Offset: 0x0001B56A
		private static void n_SetForceApplySystemWindowInsetTop_Z(IntPtr jnienv, IntPtr native__this, bool forceApplySystemWindowInsetTop)
		{
			Java.Lang.Object.GetObject<CollapsingToolbarLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ForceApplySystemWindowInsetTop = forceApplySystemWindowInsetTop;
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000ACB RID: 2763 RVA: 0x0001D37A File Offset: 0x0001B57A
		// (set) Token: 0x06000ACC RID: 2764 RVA: 0x0001D394 File Offset: 0x0001B594
		public unsafe virtual bool ForceApplySystemWindowInsetTop
		{
			[Register("isForceApplySystemWindowInsetTop", "()Z", "GetIsForceApplySystemWindowInsetTopHandler")]
			get
			{
				return CollapsingToolbarLayout._members.InstanceMethods.InvokeVirtualBooleanMethod("isForceApplySystemWindowInsetTop.()Z", this, null);
			}
			[Register("setForceApplySystemWindowInsetTop", "(Z)V", "GetSetForceApplySystemWindowInsetTop_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				CollapsingToolbarLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setForceApplySystemWindowInsetTop.(Z)V", this, ptr);
			}
		}

		// Token: 0x06000ACD RID: 2765 RVA: 0x0001D3CF File Offset: 0x0001B5CF
		private static Delegate GetGetHyphenationFrequencyHandler()
		{
			if (CollapsingToolbarLayout.cb_getHyphenationFrequency == null)
			{
				CollapsingToolbarLayout.cb_getHyphenationFrequency = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(CollapsingToolbarLayout.n_GetHyphenationFrequency));
			}
			return CollapsingToolbarLayout.cb_getHyphenationFrequency;
		}

		// Token: 0x06000ACE RID: 2766 RVA: 0x0001D3F3 File Offset: 0x0001B5F3
		private static int n_GetHyphenationFrequency(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<CollapsingToolbarLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HyphenationFrequency;
		}

		// Token: 0x06000ACF RID: 2767 RVA: 0x0001D402 File Offset: 0x0001B602
		private static Delegate GetSetHyphenationFrequency_IHandler()
		{
			if (CollapsingToolbarLayout.cb_setHyphenationFrequency_I == null)
			{
				CollapsingToolbarLayout.cb_setHyphenationFrequency_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(CollapsingToolbarLayout.n_SetHyphenationFrequency_I));
			}
			return CollapsingToolbarLayout.cb_setHyphenationFrequency_I;
		}

		// Token: 0x06000AD0 RID: 2768 RVA: 0x0001D426 File Offset: 0x0001B626
		private static void n_SetHyphenationFrequency_I(IntPtr jnienv, IntPtr native__this, int hyphenationFrequency)
		{
			Java.Lang.Object.GetObject<CollapsingToolbarLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HyphenationFrequency = hyphenationFrequency;
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000AD1 RID: 2769 RVA: 0x0001D436 File Offset: 0x0001B636
		// (set) Token: 0x06000AD2 RID: 2770 RVA: 0x0001D450 File Offset: 0x0001B650
		public unsafe virtual int HyphenationFrequency
		{
			[Register("getHyphenationFrequency", "()I", "GetGetHyphenationFrequencyHandler")]
			get
			{
				return CollapsingToolbarLayout._members.InstanceMethods.InvokeVirtualInt32Method("getHyphenationFrequency.()I", this, null);
			}
			[Register("setHyphenationFrequency", "(I)V", "GetSetHyphenationFrequency_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				CollapsingToolbarLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setHyphenationFrequency.(I)V", this, ptr);
			}
		}

		// Token: 0x06000AD3 RID: 2771 RVA: 0x0001D48B File Offset: 0x0001B68B
		private static Delegate GetGetLineCountHandler()
		{
			if (CollapsingToolbarLayout.cb_getLineCount == null)
			{
				CollapsingToolbarLayout.cb_getLineCount = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(CollapsingToolbarLayout.n_GetLineCount));
			}
			return CollapsingToolbarLayout.cb_getLineCount;
		}

		// Token: 0x06000AD4 RID: 2772 RVA: 0x0001D4AF File Offset: 0x0001B6AF
		private static int n_GetLineCount(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<CollapsingToolbarLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LineCount;
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000AD5 RID: 2773 RVA: 0x0001D4BE File Offset: 0x0001B6BE
		public virtual int LineCount
		{
			[Register("getLineCount", "()I", "GetGetLineCountHandler")]
			get
			{
				return CollapsingToolbarLayout._members.InstanceMethods.InvokeVirtualInt32Method("getLineCount.()I", this, null);
			}
		}

		// Token: 0x06000AD6 RID: 2774 RVA: 0x0001D4D7 File Offset: 0x0001B6D7
		private static Delegate GetGetLineSpacingAddHandler()
		{
			if (CollapsingToolbarLayout.cb_getLineSpacingAdd == null)
			{
				CollapsingToolbarLayout.cb_getLineSpacingAdd = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_F(CollapsingToolbarLayout.n_GetLineSpacingAdd));
			}
			return CollapsingToolbarLayout.cb_getLineSpacingAdd;
		}

		// Token: 0x06000AD7 RID: 2775 RVA: 0x0001D4FB File Offset: 0x0001B6FB
		private static float n_GetLineSpacingAdd(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<CollapsingToolbarLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LineSpacingAdd;
		}

		// Token: 0x06000AD8 RID: 2776 RVA: 0x0001D50A File Offset: 0x0001B70A
		private static Delegate GetSetLineSpacingAdd_FHandler()
		{
			if (CollapsingToolbarLayout.cb_setLineSpacingAdd_F == null)
			{
				CollapsingToolbarLayout.cb_setLineSpacingAdd_F = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPF_V(CollapsingToolbarLayout.n_SetLineSpacingAdd_F));
			}
			return CollapsingToolbarLayout.cb_setLineSpacingAdd_F;
		}

		// Token: 0x06000AD9 RID: 2777 RVA: 0x0001D52E File Offset: 0x0001B72E
		private static void n_SetLineSpacingAdd_F(IntPtr jnienv, IntPtr native__this, float spacingAdd)
		{
			Java.Lang.Object.GetObject<CollapsingToolbarLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LineSpacingAdd = spacingAdd;
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000ADA RID: 2778 RVA: 0x0001D53E File Offset: 0x0001B73E
		// (set) Token: 0x06000ADB RID: 2779 RVA: 0x0001D558 File Offset: 0x0001B758
		public unsafe virtual float LineSpacingAdd
		{
			[Register("getLineSpacingAdd", "()F", "GetGetLineSpacingAddHandler")]
			get
			{
				return CollapsingToolbarLayout._members.InstanceMethods.InvokeVirtualSingleMethod("getLineSpacingAdd.()F", this, null);
			}
			[Register("setLineSpacingAdd", "(F)V", "GetSetLineSpacingAdd_FHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				CollapsingToolbarLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setLineSpacingAdd.(F)V", this, ptr);
			}
		}

		// Token: 0x06000ADC RID: 2780 RVA: 0x0001D593 File Offset: 0x0001B793
		private static Delegate GetGetLineSpacingMultiplierHandler()
		{
			if (CollapsingToolbarLayout.cb_getLineSpacingMultiplier == null)
			{
				CollapsingToolbarLayout.cb_getLineSpacingMultiplier = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_F(CollapsingToolbarLayout.n_GetLineSpacingMultiplier));
			}
			return CollapsingToolbarLayout.cb_getLineSpacingMultiplier;
		}

		// Token: 0x06000ADD RID: 2781 RVA: 0x0001D5B7 File Offset: 0x0001B7B7
		private static float n_GetLineSpacingMultiplier(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<CollapsingToolbarLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LineSpacingMultiplier;
		}

		// Token: 0x06000ADE RID: 2782 RVA: 0x0001D5C6 File Offset: 0x0001B7C6
		private static Delegate GetSetLineSpacingMultiplier_FHandler()
		{
			if (CollapsingToolbarLayout.cb_setLineSpacingMultiplier_F == null)
			{
				CollapsingToolbarLayout.cb_setLineSpacingMultiplier_F = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPF_V(CollapsingToolbarLayout.n_SetLineSpacingMultiplier_F));
			}
			return CollapsingToolbarLayout.cb_setLineSpacingMultiplier_F;
		}

		// Token: 0x06000ADF RID: 2783 RVA: 0x0001D5EA File Offset: 0x0001B7EA
		private static void n_SetLineSpacingMultiplier_F(IntPtr jnienv, IntPtr native__this, float spacingMultiplier)
		{
			Java.Lang.Object.GetObject<CollapsingToolbarLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LineSpacingMultiplier = spacingMultiplier;
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06000AE0 RID: 2784 RVA: 0x0001D5FA File Offset: 0x0001B7FA
		// (set) Token: 0x06000AE1 RID: 2785 RVA: 0x0001D614 File Offset: 0x0001B814
		public unsafe virtual float LineSpacingMultiplier
		{
			[Register("getLineSpacingMultiplier", "()F", "GetGetLineSpacingMultiplierHandler")]
			get
			{
				return CollapsingToolbarLayout._members.InstanceMethods.InvokeVirtualSingleMethod("getLineSpacingMultiplier.()F", this, null);
			}
			[Register("setLineSpacingMultiplier", "(F)V", "GetSetLineSpacingMultiplier_FHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				CollapsingToolbarLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setLineSpacingMultiplier.(F)V", this, ptr);
			}
		}

		// Token: 0x06000AE2 RID: 2786 RVA: 0x0001D64F File Offset: 0x0001B84F
		private static Delegate GetGetMaxLinesHandler()
		{
			if (CollapsingToolbarLayout.cb_getMaxLines == null)
			{
				CollapsingToolbarLayout.cb_getMaxLines = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(CollapsingToolbarLayout.n_GetMaxLines));
			}
			return CollapsingToolbarLayout.cb_getMaxLines;
		}

		// Token: 0x06000AE3 RID: 2787 RVA: 0x0001D673 File Offset: 0x0001B873
		private static int n_GetMaxLines(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<CollapsingToolbarLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MaxLines;
		}

		// Token: 0x06000AE4 RID: 2788 RVA: 0x0001D682 File Offset: 0x0001B882
		private static Delegate GetSetMaxLines_IHandler()
		{
			if (CollapsingToolbarLayout.cb_setMaxLines_I == null)
			{
				CollapsingToolbarLayout.cb_setMaxLines_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(CollapsingToolbarLayout.n_SetMaxLines_I));
			}
			return CollapsingToolbarLayout.cb_setMaxLines_I;
		}

		// Token: 0x06000AE5 RID: 2789 RVA: 0x0001D6A6 File Offset: 0x0001B8A6
		private static void n_SetMaxLines_I(IntPtr jnienv, IntPtr native__this, int maxLines)
		{
			Java.Lang.Object.GetObject<CollapsingToolbarLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MaxLines = maxLines;
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06000AE6 RID: 2790 RVA: 0x0001D6B6 File Offset: 0x0001B8B6
		// (set) Token: 0x06000AE7 RID: 2791 RVA: 0x0001D6D0 File Offset: 0x0001B8D0
		public unsafe virtual int MaxLines
		{
			[Register("getMaxLines", "()I", "GetGetMaxLinesHandler")]
			get
			{
				return CollapsingToolbarLayout._members.InstanceMethods.InvokeVirtualInt32Method("getMaxLines.()I", this, null);
			}
			[Register("setMaxLines", "(I)V", "GetSetMaxLines_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				CollapsingToolbarLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setMaxLines.(I)V", this, ptr);
			}
		}

		// Token: 0x06000AE8 RID: 2792 RVA: 0x0001D70B File Offset: 0x0001B90B
		private static Delegate GetIsRtlTextDirectionHeuristicsEnabledHandler()
		{
			if (CollapsingToolbarLayout.cb_isRtlTextDirectionHeuristicsEnabled == null)
			{
				CollapsingToolbarLayout.cb_isRtlTextDirectionHeuristicsEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(CollapsingToolbarLayout.n_IsRtlTextDirectionHeuristicsEnabled));
			}
			return CollapsingToolbarLayout.cb_isRtlTextDirectionHeuristicsEnabled;
		}

		// Token: 0x06000AE9 RID: 2793 RVA: 0x0001D72F File Offset: 0x0001B92F
		private static bool n_IsRtlTextDirectionHeuristicsEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<CollapsingToolbarLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RtlTextDirectionHeuristicsEnabled;
		}

		// Token: 0x06000AEA RID: 2794 RVA: 0x0001D73E File Offset: 0x0001B93E
		private static Delegate GetSetRtlTextDirectionHeuristicsEnabled_ZHandler()
		{
			if (CollapsingToolbarLayout.cb_setRtlTextDirectionHeuristicsEnabled_Z == null)
			{
				CollapsingToolbarLayout.cb_setRtlTextDirectionHeuristicsEnabled_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(CollapsingToolbarLayout.n_SetRtlTextDirectionHeuristicsEnabled_Z));
			}
			return CollapsingToolbarLayout.cb_setRtlTextDirectionHeuristicsEnabled_Z;
		}

		// Token: 0x06000AEB RID: 2795 RVA: 0x0001D762 File Offset: 0x0001B962
		private static void n_SetRtlTextDirectionHeuristicsEnabled_Z(IntPtr jnienv, IntPtr native__this, bool rtlTextDirectionHeuristicsEnabled)
		{
			Java.Lang.Object.GetObject<CollapsingToolbarLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RtlTextDirectionHeuristicsEnabled = rtlTextDirectionHeuristicsEnabled;
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06000AEC RID: 2796 RVA: 0x0001D772 File Offset: 0x0001B972
		// (set) Token: 0x06000AED RID: 2797 RVA: 0x0001D78C File Offset: 0x0001B98C
		public unsafe virtual bool RtlTextDirectionHeuristicsEnabled
		{
			[Register("isRtlTextDirectionHeuristicsEnabled", "()Z", "GetIsRtlTextDirectionHeuristicsEnabledHandler")]
			get
			{
				return CollapsingToolbarLayout._members.InstanceMethods.InvokeVirtualBooleanMethod("isRtlTextDirectionHeuristicsEnabled.()Z", this, null);
			}
			[Register("setRtlTextDirectionHeuristicsEnabled", "(Z)V", "GetSetRtlTextDirectionHeuristicsEnabled_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				CollapsingToolbarLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setRtlTextDirectionHeuristicsEnabled.(Z)V", this, ptr);
			}
		}

		// Token: 0x06000AEE RID: 2798 RVA: 0x0001D7C7 File Offset: 0x0001B9C7
		private static Delegate GetGetScrimAnimationDurationHandler()
		{
			if (CollapsingToolbarLayout.cb_getScrimAnimationDuration == null)
			{
				CollapsingToolbarLayout.cb_getScrimAnimationDuration = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(CollapsingToolbarLayout.n_GetScrimAnimationDuration));
			}
			return CollapsingToolbarLayout.cb_getScrimAnimationDuration;
		}

		// Token: 0x06000AEF RID: 2799 RVA: 0x0001D7EB File Offset: 0x0001B9EB
		private static long n_GetScrimAnimationDuration(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<CollapsingToolbarLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ScrimAnimationDuration;
		}

		// Token: 0x06000AF0 RID: 2800 RVA: 0x0001D7FA File Offset: 0x0001B9FA
		private static Delegate GetSetScrimAnimationDuration_JHandler()
		{
			if (CollapsingToolbarLayout.cb_setScrimAnimationDuration_J == null)
			{
				CollapsingToolbarLayout.cb_setScrimAnimationDuration_J = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPJ_V(CollapsingToolbarLayout.n_SetScrimAnimationDuration_J));
			}
			return CollapsingToolbarLayout.cb_setScrimAnimationDuration_J;
		}

		// Token: 0x06000AF1 RID: 2801 RVA: 0x0001D81E File Offset: 0x0001BA1E
		private static void n_SetScrimAnimationDuration_J(IntPtr jnienv, IntPtr native__this, long duration)
		{
			Java.Lang.Object.GetObject<CollapsingToolbarLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ScrimAnimationDuration = duration;
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06000AF2 RID: 2802 RVA: 0x0001D82E File Offset: 0x0001BA2E
		// (set) Token: 0x06000AF3 RID: 2803 RVA: 0x0001D848 File Offset: 0x0001BA48
		public unsafe virtual long ScrimAnimationDuration
		{
			[Register("getScrimAnimationDuration", "()J", "GetGetScrimAnimationDurationHandler")]
			get
			{
				return CollapsingToolbarLayout._members.InstanceMethods.InvokeVirtualInt64Method("getScrimAnimationDuration.()J", this, null);
			}
			[Register("setScrimAnimationDuration", "(J)V", "GetSetScrimAnimationDuration_JHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				CollapsingToolbarLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setScrimAnimationDuration.(J)V", this, ptr);
			}
		}

		// Token: 0x06000AF4 RID: 2804 RVA: 0x0001D883 File Offset: 0x0001BA83
		private static Delegate GetGetScrimVisibleHeightTriggerHandler()
		{
			if (CollapsingToolbarLayout.cb_getScrimVisibleHeightTrigger == null)
			{
				CollapsingToolbarLayout.cb_getScrimVisibleHeightTrigger = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(CollapsingToolbarLayout.n_GetScrimVisibleHeightTrigger));
			}
			return CollapsingToolbarLayout.cb_getScrimVisibleHeightTrigger;
		}

		// Token: 0x06000AF5 RID: 2805 RVA: 0x0001D8A7 File Offset: 0x0001BAA7
		private static int n_GetScrimVisibleHeightTrigger(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<CollapsingToolbarLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ScrimVisibleHeightTrigger;
		}

		// Token: 0x06000AF6 RID: 2806 RVA: 0x0001D8B6 File Offset: 0x0001BAB6
		private static Delegate GetSetScrimVisibleHeightTrigger_IHandler()
		{
			if (CollapsingToolbarLayout.cb_setScrimVisibleHeightTrigger_I == null)
			{
				CollapsingToolbarLayout.cb_setScrimVisibleHeightTrigger_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(CollapsingToolbarLayout.n_SetScrimVisibleHeightTrigger_I));
			}
			return CollapsingToolbarLayout.cb_setScrimVisibleHeightTrigger_I;
		}

		// Token: 0x06000AF7 RID: 2807 RVA: 0x0001D8DA File Offset: 0x0001BADA
		private static void n_SetScrimVisibleHeightTrigger_I(IntPtr jnienv, IntPtr native__this, int height)
		{
			Java.Lang.Object.GetObject<CollapsingToolbarLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ScrimVisibleHeightTrigger = height;
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06000AF8 RID: 2808 RVA: 0x0001D8EA File Offset: 0x0001BAEA
		// (set) Token: 0x06000AF9 RID: 2809 RVA: 0x0001D904 File Offset: 0x0001BB04
		public unsafe virtual int ScrimVisibleHeightTrigger
		{
			[Register("getScrimVisibleHeightTrigger", "()I", "GetGetScrimVisibleHeightTriggerHandler")]
			get
			{
				return CollapsingToolbarLayout._members.InstanceMethods.InvokeVirtualInt32Method("getScrimVisibleHeightTrigger.()I", this, null);
			}
			[Register("setScrimVisibleHeightTrigger", "(I)V", "GetSetScrimVisibleHeightTrigger_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				CollapsingToolbarLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setScrimVisibleHeightTrigger.(I)V", this, ptr);
			}
		}

		// Token: 0x06000AFA RID: 2810 RVA: 0x0001D93F File Offset: 0x0001BB3F
		private static Delegate GetGetStatusBarScrimHandler()
		{
			if (CollapsingToolbarLayout.cb_getStatusBarScrim == null)
			{
				CollapsingToolbarLayout.cb_getStatusBarScrim = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(CollapsingToolbarLayout.n_GetStatusBarScrim));
			}
			return CollapsingToolbarLayout.cb_getStatusBarScrim;
		}

		// Token: 0x06000AFB RID: 2811 RVA: 0x0001D963 File Offset: 0x0001BB63
		private static IntPtr n_GetStatusBarScrim(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<CollapsingToolbarLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).StatusBarScrim);
		}

		// Token: 0x06000AFC RID: 2812 RVA: 0x0001D977 File Offset: 0x0001BB77
		private static Delegate GetSetStatusBarScrim_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (CollapsingToolbarLayout.cb_setStatusBarScrim_Landroid_graphics_drawable_Drawable_ == null)
			{
				CollapsingToolbarLayout.cb_setStatusBarScrim_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(CollapsingToolbarLayout.n_SetStatusBarScrim_Landroid_graphics_drawable_Drawable_));
			}
			return CollapsingToolbarLayout.cb_setStatusBarScrim_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x06000AFD RID: 2813 RVA: 0x0001D99C File Offset: 0x0001BB9C
		private static void n_SetStatusBarScrim_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_drawable)
		{
			CollapsingToolbarLayout @object = Java.Lang.Object.GetObject<CollapsingToolbarLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_drawable, JniHandleOwnership.DoNotTransfer);
			@object.StatusBarScrim = object2;
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06000AFE RID: 2814 RVA: 0x0001D9C0 File Offset: 0x0001BBC0
		// (set) Token: 0x06000AFF RID: 2815 RVA: 0x0001D9F4 File Offset: 0x0001BBF4
		public unsafe virtual Drawable StatusBarScrim
		{
			[Register("getStatusBarScrim", "()Landroid/graphics/drawable/Drawable;", "GetGetStatusBarScrimHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Drawable>(CollapsingToolbarLayout._members.InstanceMethods.InvokeVirtualObjectMethod("getStatusBarScrim.()Landroid/graphics/drawable/Drawable;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setStatusBarScrim", "(Landroid/graphics/drawable/Drawable;)V", "GetSetStatusBarScrim_Landroid_graphics_drawable_Drawable_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					CollapsingToolbarLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setStatusBarScrim.(Landroid/graphics/drawable/Drawable;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x06000B00 RID: 2816 RVA: 0x0001DA58 File Offset: 0x0001BC58
		private static Delegate GetGetTitleHandler()
		{
			if (CollapsingToolbarLayout.cb_getTitle == null)
			{
				CollapsingToolbarLayout.cb_getTitle = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(CollapsingToolbarLayout.n_GetTitle));
			}
			return CollapsingToolbarLayout.cb_getTitle;
		}

		// Token: 0x06000B01 RID: 2817 RVA: 0x0001DA7C File Offset: 0x0001BC7C
		private static IntPtr n_GetTitle(IntPtr jnienv, IntPtr native__this)
		{
			return CharSequence.ToLocalJniHandle(Java.Lang.Object.GetObject<CollapsingToolbarLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TitleFormatted);
		}

		// Token: 0x06000B02 RID: 2818 RVA: 0x0001DA90 File Offset: 0x0001BC90
		private static Delegate GetSetTitle_Ljava_lang_CharSequence_Handler()
		{
			if (CollapsingToolbarLayout.cb_setTitle_Ljava_lang_CharSequence_ == null)
			{
				CollapsingToolbarLayout.cb_setTitle_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(CollapsingToolbarLayout.n_SetTitle_Ljava_lang_CharSequence_));
			}
			return CollapsingToolbarLayout.cb_setTitle_Ljava_lang_CharSequence_;
		}

		// Token: 0x06000B03 RID: 2819 RVA: 0x0001DAB4 File Offset: 0x0001BCB4
		private static void n_SetTitle_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_title)
		{
			CollapsingToolbarLayout @object = Java.Lang.Object.GetObject<CollapsingToolbarLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_title, JniHandleOwnership.DoNotTransfer);
			@object.TitleFormatted = object2;
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x06000B04 RID: 2820 RVA: 0x0001DAD8 File Offset: 0x0001BCD8
		// (set) Token: 0x06000B05 RID: 2821 RVA: 0x0001DB0C File Offset: 0x0001BD0C
		public unsafe virtual ICharSequence TitleFormatted
		{
			[Register("getTitle", "()Ljava/lang/CharSequence;", "GetGetTitleHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ICharSequence>(CollapsingToolbarLayout._members.InstanceMethods.InvokeVirtualObjectMethod("getTitle.()Ljava/lang/CharSequence;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setTitle", "(Ljava/lang/CharSequence;)V", "GetSetTitle_Ljava_lang_CharSequence_Handler")]
			set
			{
				IntPtr intPtr = CharSequence.ToLocalJniHandle(value);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					CollapsingToolbarLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setTitle.(Ljava/lang/CharSequence;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x06000B06 RID: 2822 RVA: 0x0001DB70 File Offset: 0x0001BD70
		// (set) Token: 0x06000B07 RID: 2823 RVA: 0x0001DB88 File Offset: 0x0001BD88
		public string Title
		{
			get
			{
				if (this.TitleFormatted != null)
				{
					return this.TitleFormatted.ToString();
				}
				return null;
			}
			set
			{
				Java.Lang.String @string = (value == null) ? null : new Java.Lang.String(value);
				this.TitleFormatted = @string;
				if (@string != null)
				{
					@string.Dispose();
				}
			}
		}

		// Token: 0x06000B08 RID: 2824 RVA: 0x0001DBB2 File Offset: 0x0001BDB2
		private static Delegate GetGetTitleCollapseModeHandler()
		{
			if (CollapsingToolbarLayout.cb_getTitleCollapseMode == null)
			{
				CollapsingToolbarLayout.cb_getTitleCollapseMode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(CollapsingToolbarLayout.n_GetTitleCollapseMode));
			}
			return CollapsingToolbarLayout.cb_getTitleCollapseMode;
		}

		// Token: 0x06000B09 RID: 2825 RVA: 0x0001DBD6 File Offset: 0x0001BDD6
		private static int n_GetTitleCollapseMode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<CollapsingToolbarLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TitleCollapseMode;
		}

		// Token: 0x06000B0A RID: 2826 RVA: 0x0001DBE5 File Offset: 0x0001BDE5
		private static Delegate GetSetTitleCollapseMode_IHandler()
		{
			if (CollapsingToolbarLayout.cb_setTitleCollapseMode_I == null)
			{
				CollapsingToolbarLayout.cb_setTitleCollapseMode_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(CollapsingToolbarLayout.n_SetTitleCollapseMode_I));
			}
			return CollapsingToolbarLayout.cb_setTitleCollapseMode_I;
		}

		// Token: 0x06000B0B RID: 2827 RVA: 0x0001DC09 File Offset: 0x0001BE09
		private static void n_SetTitleCollapseMode_I(IntPtr jnienv, IntPtr native__this, int titleCollapseMode)
		{
			Java.Lang.Object.GetObject<CollapsingToolbarLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TitleCollapseMode = titleCollapseMode;
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06000B0C RID: 2828 RVA: 0x0001DC19 File Offset: 0x0001BE19
		// (set) Token: 0x06000B0D RID: 2829 RVA: 0x0001DC34 File Offset: 0x0001BE34
		public unsafe virtual int TitleCollapseMode
		{
			[Register("getTitleCollapseMode", "()I", "GetGetTitleCollapseModeHandler")]
			get
			{
				return CollapsingToolbarLayout._members.InstanceMethods.InvokeVirtualInt32Method("getTitleCollapseMode.()I", this, null);
			}
			[Register("setTitleCollapseMode", "(I)V", "GetSetTitleCollapseMode_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				CollapsingToolbarLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setTitleCollapseMode.(I)V", this, ptr);
			}
		}

		// Token: 0x06000B0E RID: 2830 RVA: 0x0001DC6F File Offset: 0x0001BE6F
		private static Delegate GetIsTitleEnabledHandler()
		{
			if (CollapsingToolbarLayout.cb_isTitleEnabled == null)
			{
				CollapsingToolbarLayout.cb_isTitleEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(CollapsingToolbarLayout.n_IsTitleEnabled));
			}
			return CollapsingToolbarLayout.cb_isTitleEnabled;
		}

		// Token: 0x06000B0F RID: 2831 RVA: 0x0001DC93 File Offset: 0x0001BE93
		private static bool n_IsTitleEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<CollapsingToolbarLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TitleEnabled;
		}

		// Token: 0x06000B10 RID: 2832 RVA: 0x0001DCA2 File Offset: 0x0001BEA2
		private static Delegate GetSetTitleEnabled_ZHandler()
		{
			if (CollapsingToolbarLayout.cb_setTitleEnabled_Z == null)
			{
				CollapsingToolbarLayout.cb_setTitleEnabled_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(CollapsingToolbarLayout.n_SetTitleEnabled_Z));
			}
			return CollapsingToolbarLayout.cb_setTitleEnabled_Z;
		}

		// Token: 0x06000B11 RID: 2833 RVA: 0x0001DCC6 File Offset: 0x0001BEC6
		private static void n_SetTitleEnabled_Z(IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			Java.Lang.Object.GetObject<CollapsingToolbarLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TitleEnabled = enabled;
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06000B12 RID: 2834 RVA: 0x0001DCD6 File Offset: 0x0001BED6
		// (set) Token: 0x06000B13 RID: 2835 RVA: 0x0001DCF0 File Offset: 0x0001BEF0
		public unsafe virtual bool TitleEnabled
		{
			[Register("isTitleEnabled", "()Z", "GetIsTitleEnabledHandler")]
			get
			{
				return CollapsingToolbarLayout._members.InstanceMethods.InvokeVirtualBooleanMethod("isTitleEnabled.()Z", this, null);
			}
			[Register("setTitleEnabled", "(Z)V", "GetSetTitleEnabled_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				CollapsingToolbarLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setTitleEnabled.(Z)V", this, ptr);
			}
		}

		// Token: 0x06000B14 RID: 2836 RVA: 0x0001DD2B File Offset: 0x0001BF2B
		private static Delegate GetGetTitlePositionInterpolatorHandler()
		{
			if (CollapsingToolbarLayout.cb_getTitlePositionInterpolator == null)
			{
				CollapsingToolbarLayout.cb_getTitlePositionInterpolator = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(CollapsingToolbarLayout.n_GetTitlePositionInterpolator));
			}
			return CollapsingToolbarLayout.cb_getTitlePositionInterpolator;
		}

		// Token: 0x06000B15 RID: 2837 RVA: 0x0001DD4F File Offset: 0x0001BF4F
		private static IntPtr n_GetTitlePositionInterpolator(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<CollapsingToolbarLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TitlePositionInterpolator);
		}

		// Token: 0x06000B16 RID: 2838 RVA: 0x0001DD63 File Offset: 0x0001BF63
		private static Delegate GetSetTitlePositionInterpolator_Landroid_animation_TimeInterpolator_Handler()
		{
			if (CollapsingToolbarLayout.cb_setTitlePositionInterpolator_Landroid_animation_TimeInterpolator_ == null)
			{
				CollapsingToolbarLayout.cb_setTitlePositionInterpolator_Landroid_animation_TimeInterpolator_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(CollapsingToolbarLayout.n_SetTitlePositionInterpolator_Landroid_animation_TimeInterpolator_));
			}
			return CollapsingToolbarLayout.cb_setTitlePositionInterpolator_Landroid_animation_TimeInterpolator_;
		}

		// Token: 0x06000B17 RID: 2839 RVA: 0x0001DD88 File Offset: 0x0001BF88
		private static void n_SetTitlePositionInterpolator_Landroid_animation_TimeInterpolator_(IntPtr jnienv, IntPtr native__this, IntPtr native_interpolator)
		{
			CollapsingToolbarLayout @object = Java.Lang.Object.GetObject<CollapsingToolbarLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ITimeInterpolator object2 = Java.Lang.Object.GetObject<ITimeInterpolator>(native_interpolator, JniHandleOwnership.DoNotTransfer);
			@object.TitlePositionInterpolator = object2;
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x06000B18 RID: 2840 RVA: 0x0001DDAC File Offset: 0x0001BFAC
		// (set) Token: 0x06000B19 RID: 2841 RVA: 0x0001DDE0 File Offset: 0x0001BFE0
		public unsafe virtual ITimeInterpolator TitlePositionInterpolator
		{
			[Register("getTitlePositionInterpolator", "()Landroid/animation/TimeInterpolator;", "GetGetTitlePositionInterpolatorHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ITimeInterpolator>(CollapsingToolbarLayout._members.InstanceMethods.InvokeVirtualObjectMethod("getTitlePositionInterpolator.()Landroid/animation/TimeInterpolator;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setTitlePositionInterpolator", "(Landroid/animation/TimeInterpolator;)V", "GetSetTitlePositionInterpolator_Landroid_animation_TimeInterpolator_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : ((Java.Lang.Object)value).Handle);
					CollapsingToolbarLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setTitlePositionInterpolator.(Landroid/animation/TimeInterpolator;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x06000B1A RID: 2842 RVA: 0x0001DE48 File Offset: 0x0001C048
		private static Delegate GetGetTitleTextEllipsizeHandler()
		{
			if (CollapsingToolbarLayout.cb_getTitleTextEllipsize == null)
			{
				CollapsingToolbarLayout.cb_getTitleTextEllipsize = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(CollapsingToolbarLayout.n_GetTitleTextEllipsize));
			}
			return CollapsingToolbarLayout.cb_getTitleTextEllipsize;
		}

		// Token: 0x06000B1B RID: 2843 RVA: 0x0001DE6C File Offset: 0x0001C06C
		private static IntPtr n_GetTitleTextEllipsize(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<CollapsingToolbarLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TitleTextEllipsize);
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x06000B1C RID: 2844 RVA: 0x0001DE80 File Offset: 0x0001C080
		public virtual TextUtils.TruncateAt TitleTextEllipsize
		{
			[Register("getTitleTextEllipsize", "()Landroid/text/TextUtils$TruncateAt;", "GetGetTitleTextEllipsizeHandler")]
			get
			{
				return Java.Lang.Object.GetObject<TextUtils.TruncateAt>(CollapsingToolbarLayout._members.InstanceMethods.InvokeVirtualObjectMethod("getTitleTextEllipsize.()Landroid/text/TextUtils$TruncateAt;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000B1D RID: 2845 RVA: 0x0001DEB2 File Offset: 0x0001C0B2
		private static Delegate GetSetCollapsedTitleTextAppearance_IHandler()
		{
			if (CollapsingToolbarLayout.cb_setCollapsedTitleTextAppearance_I == null)
			{
				CollapsingToolbarLayout.cb_setCollapsedTitleTextAppearance_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(CollapsingToolbarLayout.n_SetCollapsedTitleTextAppearance_I));
			}
			return CollapsingToolbarLayout.cb_setCollapsedTitleTextAppearance_I;
		}

		// Token: 0x06000B1E RID: 2846 RVA: 0x0001DED6 File Offset: 0x0001C0D6
		private static void n_SetCollapsedTitleTextAppearance_I(IntPtr jnienv, IntPtr native__this, int resId)
		{
			Java.Lang.Object.GetObject<CollapsingToolbarLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetCollapsedTitleTextAppearance(resId);
		}

		// Token: 0x06000B1F RID: 2847 RVA: 0x0001DEE8 File Offset: 0x0001C0E8
		[Register("setCollapsedTitleTextAppearance", "(I)V", "GetSetCollapsedTitleTextAppearance_IHandler")]
		public unsafe virtual void SetCollapsedTitleTextAppearance(int resId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(resId);
			CollapsingToolbarLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setCollapsedTitleTextAppearance.(I)V", this, ptr);
		}

		// Token: 0x06000B20 RID: 2848 RVA: 0x0001DF23 File Offset: 0x0001C123
		private static Delegate GetSetCollapsedTitleTextColor_Landroid_content_res_ColorStateList_Handler()
		{
			if (CollapsingToolbarLayout.cb_setCollapsedTitleTextColor_Landroid_content_res_ColorStateList_ == null)
			{
				CollapsingToolbarLayout.cb_setCollapsedTitleTextColor_Landroid_content_res_ColorStateList_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(CollapsingToolbarLayout.n_SetCollapsedTitleTextColor_Landroid_content_res_ColorStateList_));
			}
			return CollapsingToolbarLayout.cb_setCollapsedTitleTextColor_Landroid_content_res_ColorStateList_;
		}

		// Token: 0x06000B21 RID: 2849 RVA: 0x0001DF48 File Offset: 0x0001C148
		private static void n_SetCollapsedTitleTextColor_Landroid_content_res_ColorStateList_(IntPtr jnienv, IntPtr native__this, IntPtr native_colors)
		{
			CollapsingToolbarLayout @object = Java.Lang.Object.GetObject<CollapsingToolbarLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ColorStateList object2 = Java.Lang.Object.GetObject<ColorStateList>(native_colors, JniHandleOwnership.DoNotTransfer);
			@object.SetCollapsedTitleTextColor(object2);
		}

		// Token: 0x06000B22 RID: 2850 RVA: 0x0001DF6C File Offset: 0x0001C16C
		[Register("setCollapsedTitleTextColor", "(Landroid/content/res/ColorStateList;)V", "GetSetCollapsedTitleTextColor_Landroid_content_res_ColorStateList_Handler")]
		public unsafe virtual void SetCollapsedTitleTextColor(ColorStateList colors)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((colors == null) ? IntPtr.Zero : colors.Handle);
				CollapsingToolbarLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setCollapsedTitleTextColor.(Landroid/content/res/ColorStateList;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(colors);
			}
		}

		// Token: 0x06000B23 RID: 2851 RVA: 0x0001DFD0 File Offset: 0x0001C1D0
		private static Delegate GetSetCollapsedTitleTextColor_IHandler()
		{
			if (CollapsingToolbarLayout.cb_setCollapsedTitleTextColor_I == null)
			{
				CollapsingToolbarLayout.cb_setCollapsedTitleTextColor_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(CollapsingToolbarLayout.n_SetCollapsedTitleTextColor_I));
			}
			return CollapsingToolbarLayout.cb_setCollapsedTitleTextColor_I;
		}

		// Token: 0x06000B24 RID: 2852 RVA: 0x0001DFF4 File Offset: 0x0001C1F4
		private static void n_SetCollapsedTitleTextColor_I(IntPtr jnienv, IntPtr native__this, int color)
		{
			Java.Lang.Object.GetObject<CollapsingToolbarLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetCollapsedTitleTextColor(color);
		}

		// Token: 0x06000B25 RID: 2853 RVA: 0x0001E004 File Offset: 0x0001C204
		[Register("setCollapsedTitleTextColor", "(I)V", "GetSetCollapsedTitleTextColor_IHandler")]
		public unsafe virtual void SetCollapsedTitleTextColor(int color)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(color);
			CollapsingToolbarLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setCollapsedTitleTextColor.(I)V", this, ptr);
		}

		// Token: 0x06000B26 RID: 2854 RVA: 0x0001E03F File Offset: 0x0001C23F
		private static Delegate GetSetContentScrimColor_IHandler()
		{
			if (CollapsingToolbarLayout.cb_setContentScrimColor_I == null)
			{
				CollapsingToolbarLayout.cb_setContentScrimColor_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(CollapsingToolbarLayout.n_SetContentScrimColor_I));
			}
			return CollapsingToolbarLayout.cb_setContentScrimColor_I;
		}

		// Token: 0x06000B27 RID: 2855 RVA: 0x0001E063 File Offset: 0x0001C263
		private static void n_SetContentScrimColor_I(IntPtr jnienv, IntPtr native__this, int color)
		{
			Java.Lang.Object.GetObject<CollapsingToolbarLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetContentScrimColor(color);
		}

		// Token: 0x06000B28 RID: 2856 RVA: 0x0001E074 File Offset: 0x0001C274
		[Register("setContentScrimColor", "(I)V", "GetSetContentScrimColor_IHandler")]
		public unsafe virtual void SetContentScrimColor(int color)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(color);
			CollapsingToolbarLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setContentScrimColor.(I)V", this, ptr);
		}

		// Token: 0x06000B29 RID: 2857 RVA: 0x0001E0AF File Offset: 0x0001C2AF
		private static Delegate GetSetContentScrimResource_IHandler()
		{
			if (CollapsingToolbarLayout.cb_setContentScrimResource_I == null)
			{
				CollapsingToolbarLayout.cb_setContentScrimResource_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(CollapsingToolbarLayout.n_SetContentScrimResource_I));
			}
			return CollapsingToolbarLayout.cb_setContentScrimResource_I;
		}

		// Token: 0x06000B2A RID: 2858 RVA: 0x0001E0D3 File Offset: 0x0001C2D3
		private static void n_SetContentScrimResource_I(IntPtr jnienv, IntPtr native__this, int resId)
		{
			Java.Lang.Object.GetObject<CollapsingToolbarLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetContentScrimResource(resId);
		}

		// Token: 0x06000B2B RID: 2859 RVA: 0x0001E0E4 File Offset: 0x0001C2E4
		[Register("setContentScrimResource", "(I)V", "GetSetContentScrimResource_IHandler")]
		public unsafe virtual void SetContentScrimResource(int resId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(resId);
			CollapsingToolbarLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setContentScrimResource.(I)V", this, ptr);
		}

		// Token: 0x06000B2C RID: 2860 RVA: 0x0001E11F File Offset: 0x0001C31F
		private static Delegate GetSetExpandedTitleColor_IHandler()
		{
			if (CollapsingToolbarLayout.cb_setExpandedTitleColor_I == null)
			{
				CollapsingToolbarLayout.cb_setExpandedTitleColor_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(CollapsingToolbarLayout.n_SetExpandedTitleColor_I));
			}
			return CollapsingToolbarLayout.cb_setExpandedTitleColor_I;
		}

		// Token: 0x06000B2D RID: 2861 RVA: 0x0001E143 File Offset: 0x0001C343
		private static void n_SetExpandedTitleColor_I(IntPtr jnienv, IntPtr native__this, int color)
		{
			Java.Lang.Object.GetObject<CollapsingToolbarLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetExpandedTitleColor(color);
		}

		// Token: 0x06000B2E RID: 2862 RVA: 0x0001E154 File Offset: 0x0001C354
		[Register("setExpandedTitleColor", "(I)V", "GetSetExpandedTitleColor_IHandler")]
		public unsafe virtual void SetExpandedTitleColor(int color)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(color);
			CollapsingToolbarLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setExpandedTitleColor.(I)V", this, ptr);
		}

		// Token: 0x06000B2F RID: 2863 RVA: 0x0001E18F File Offset: 0x0001C38F
		private static Delegate GetSetExpandedTitleMargin_IIIIHandler()
		{
			if (CollapsingToolbarLayout.cb_setExpandedTitleMargin_IIII == null)
			{
				CollapsingToolbarLayout.cb_setExpandedTitleMargin_IIII = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIIII_V(CollapsingToolbarLayout.n_SetExpandedTitleMargin_IIII));
			}
			return CollapsingToolbarLayout.cb_setExpandedTitleMargin_IIII;
		}

		// Token: 0x06000B30 RID: 2864 RVA: 0x0001E1B3 File Offset: 0x0001C3B3
		private static void n_SetExpandedTitleMargin_IIII(IntPtr jnienv, IntPtr native__this, int start, int top, int end, int bottom)
		{
			Java.Lang.Object.GetObject<CollapsingToolbarLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetExpandedTitleMargin(start, top, end, bottom);
		}

		// Token: 0x06000B31 RID: 2865 RVA: 0x0001E1C8 File Offset: 0x0001C3C8
		[Register("setExpandedTitleMargin", "(IIII)V", "GetSetExpandedTitleMargin_IIIIHandler")]
		public unsafe virtual void SetExpandedTitleMargin(int start, int top, int end, int bottom)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(start);
			ptr[1] = new JniArgumentValue(top);
			ptr[2] = new JniArgumentValue(end);
			ptr[3] = new JniArgumentValue(bottom);
			CollapsingToolbarLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setExpandedTitleMargin.(IIII)V", this, ptr);
		}

		// Token: 0x06000B32 RID: 2866 RVA: 0x0001E243 File Offset: 0x0001C443
		private static Delegate GetSetExpandedTitleTextAppearance_IHandler()
		{
			if (CollapsingToolbarLayout.cb_setExpandedTitleTextAppearance_I == null)
			{
				CollapsingToolbarLayout.cb_setExpandedTitleTextAppearance_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(CollapsingToolbarLayout.n_SetExpandedTitleTextAppearance_I));
			}
			return CollapsingToolbarLayout.cb_setExpandedTitleTextAppearance_I;
		}

		// Token: 0x06000B33 RID: 2867 RVA: 0x0001E267 File Offset: 0x0001C467
		private static void n_SetExpandedTitleTextAppearance_I(IntPtr jnienv, IntPtr native__this, int resId)
		{
			Java.Lang.Object.GetObject<CollapsingToolbarLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetExpandedTitleTextAppearance(resId);
		}

		// Token: 0x06000B34 RID: 2868 RVA: 0x0001E278 File Offset: 0x0001C478
		[Register("setExpandedTitleTextAppearance", "(I)V", "GetSetExpandedTitleTextAppearance_IHandler")]
		public unsafe virtual void SetExpandedTitleTextAppearance(int resId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(resId);
			CollapsingToolbarLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setExpandedTitleTextAppearance.(I)V", this, ptr);
		}

		// Token: 0x06000B35 RID: 2869 RVA: 0x0001E2B3 File Offset: 0x0001C4B3
		private static Delegate GetSetExpandedTitleTextColor_Landroid_content_res_ColorStateList_Handler()
		{
			if (CollapsingToolbarLayout.cb_setExpandedTitleTextColor_Landroid_content_res_ColorStateList_ == null)
			{
				CollapsingToolbarLayout.cb_setExpandedTitleTextColor_Landroid_content_res_ColorStateList_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(CollapsingToolbarLayout.n_SetExpandedTitleTextColor_Landroid_content_res_ColorStateList_));
			}
			return CollapsingToolbarLayout.cb_setExpandedTitleTextColor_Landroid_content_res_ColorStateList_;
		}

		// Token: 0x06000B36 RID: 2870 RVA: 0x0001E2D8 File Offset: 0x0001C4D8
		private static void n_SetExpandedTitleTextColor_Landroid_content_res_ColorStateList_(IntPtr jnienv, IntPtr native__this, IntPtr native_colors)
		{
			CollapsingToolbarLayout @object = Java.Lang.Object.GetObject<CollapsingToolbarLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ColorStateList object2 = Java.Lang.Object.GetObject<ColorStateList>(native_colors, JniHandleOwnership.DoNotTransfer);
			@object.SetExpandedTitleTextColor(object2);
		}

		// Token: 0x06000B37 RID: 2871 RVA: 0x0001E2FC File Offset: 0x0001C4FC
		[Register("setExpandedTitleTextColor", "(Landroid/content/res/ColorStateList;)V", "GetSetExpandedTitleTextColor_Landroid_content_res_ColorStateList_Handler")]
		public unsafe virtual void SetExpandedTitleTextColor(ColorStateList colors)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((colors == null) ? IntPtr.Zero : colors.Handle);
				CollapsingToolbarLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setExpandedTitleTextColor.(Landroid/content/res/ColorStateList;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(colors);
			}
		}

		// Token: 0x06000B38 RID: 2872 RVA: 0x0001E360 File Offset: 0x0001C560
		private static Delegate GetSetScrimsShown_ZHandler()
		{
			if (CollapsingToolbarLayout.cb_setScrimsShown_Z == null)
			{
				CollapsingToolbarLayout.cb_setScrimsShown_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(CollapsingToolbarLayout.n_SetScrimsShown_Z));
			}
			return CollapsingToolbarLayout.cb_setScrimsShown_Z;
		}

		// Token: 0x06000B39 RID: 2873 RVA: 0x0001E384 File Offset: 0x0001C584
		private static void n_SetScrimsShown_Z(IntPtr jnienv, IntPtr native__this, bool shown)
		{
			Java.Lang.Object.GetObject<CollapsingToolbarLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetScrimsShown(shown);
		}

		// Token: 0x06000B3A RID: 2874 RVA: 0x0001E394 File Offset: 0x0001C594
		[Register("setScrimsShown", "(Z)V", "GetSetScrimsShown_ZHandler")]
		public unsafe virtual void SetScrimsShown(bool shown)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(shown);
			CollapsingToolbarLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setScrimsShown.(Z)V", this, ptr);
		}

		// Token: 0x06000B3B RID: 2875 RVA: 0x0001E3CF File Offset: 0x0001C5CF
		private static Delegate GetSetScrimsShown_ZZHandler()
		{
			if (CollapsingToolbarLayout.cb_setScrimsShown_ZZ == null)
			{
				CollapsingToolbarLayout.cb_setScrimsShown_ZZ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZZ_V(CollapsingToolbarLayout.n_SetScrimsShown_ZZ));
			}
			return CollapsingToolbarLayout.cb_setScrimsShown_ZZ;
		}

		// Token: 0x06000B3C RID: 2876 RVA: 0x0001E3F3 File Offset: 0x0001C5F3
		private static void n_SetScrimsShown_ZZ(IntPtr jnienv, IntPtr native__this, bool shown, bool animate)
		{
			Java.Lang.Object.GetObject<CollapsingToolbarLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetScrimsShown(shown, animate);
		}

		// Token: 0x06000B3D RID: 2877 RVA: 0x0001E404 File Offset: 0x0001C604
		[Register("setScrimsShown", "(ZZ)V", "GetSetScrimsShown_ZZHandler")]
		public unsafe virtual void SetScrimsShown(bool shown, bool animate)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(shown);
			ptr[1] = new JniArgumentValue(animate);
			CollapsingToolbarLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setScrimsShown.(ZZ)V", this, ptr);
		}

		// Token: 0x06000B3E RID: 2878 RVA: 0x0001E452 File Offset: 0x0001C652
		private static Delegate GetSetStaticLayoutBuilderConfigurer_Lcom_google_android_material_appbar_CollapsingToolbarLayout_StaticLayoutBuilderConfigurer_Handler()
		{
			if (CollapsingToolbarLayout.cb_setStaticLayoutBuilderConfigurer_Lcom_google_android_material_appbar_CollapsingToolbarLayout_StaticLayoutBuilderConfigurer_ == null)
			{
				CollapsingToolbarLayout.cb_setStaticLayoutBuilderConfigurer_Lcom_google_android_material_appbar_CollapsingToolbarLayout_StaticLayoutBuilderConfigurer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(CollapsingToolbarLayout.n_SetStaticLayoutBuilderConfigurer_Lcom_google_android_material_appbar_CollapsingToolbarLayout_StaticLayoutBuilderConfigurer_));
			}
			return CollapsingToolbarLayout.cb_setStaticLayoutBuilderConfigurer_Lcom_google_android_material_appbar_CollapsingToolbarLayout_StaticLayoutBuilderConfigurer_;
		}

		// Token: 0x06000B3F RID: 2879 RVA: 0x0001E478 File Offset: 0x0001C678
		private static void n_SetStaticLayoutBuilderConfigurer_Lcom_google_android_material_appbar_CollapsingToolbarLayout_StaticLayoutBuilderConfigurer_(IntPtr jnienv, IntPtr native__this, IntPtr native_staticLayoutBuilderConfigurer)
		{
			CollapsingToolbarLayout @object = Java.Lang.Object.GetObject<CollapsingToolbarLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			CollapsingToolbarLayout.IStaticLayoutBuilderConfigurer object2 = Java.Lang.Object.GetObject<CollapsingToolbarLayout.IStaticLayoutBuilderConfigurer>(native_staticLayoutBuilderConfigurer, JniHandleOwnership.DoNotTransfer);
			@object.SetStaticLayoutBuilderConfigurer(object2);
		}

		// Token: 0x06000B40 RID: 2880 RVA: 0x0001E49C File Offset: 0x0001C69C
		[Register("setStaticLayoutBuilderConfigurer", "(Lcom/google/android/material/appbar/CollapsingToolbarLayout$StaticLayoutBuilderConfigurer;)V", "GetSetStaticLayoutBuilderConfigurer_Lcom_google_android_material_appbar_CollapsingToolbarLayout_StaticLayoutBuilderConfigurer_Handler")]
		public unsafe virtual void SetStaticLayoutBuilderConfigurer(CollapsingToolbarLayout.IStaticLayoutBuilderConfigurer staticLayoutBuilderConfigurer)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((staticLayoutBuilderConfigurer == null) ? IntPtr.Zero : ((Java.Lang.Object)staticLayoutBuilderConfigurer).Handle);
				CollapsingToolbarLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setStaticLayoutBuilderConfigurer.(Lcom/google/android/material/appbar/CollapsingToolbarLayout$StaticLayoutBuilderConfigurer;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(staticLayoutBuilderConfigurer);
			}
		}

		// Token: 0x06000B41 RID: 2881 RVA: 0x0001E504 File Offset: 0x0001C704
		private static Delegate GetSetStatusBarScrimColor_IHandler()
		{
			if (CollapsingToolbarLayout.cb_setStatusBarScrimColor_I == null)
			{
				CollapsingToolbarLayout.cb_setStatusBarScrimColor_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(CollapsingToolbarLayout.n_SetStatusBarScrimColor_I));
			}
			return CollapsingToolbarLayout.cb_setStatusBarScrimColor_I;
		}

		// Token: 0x06000B42 RID: 2882 RVA: 0x0001E528 File Offset: 0x0001C728
		private static void n_SetStatusBarScrimColor_I(IntPtr jnienv, IntPtr native__this, int color)
		{
			Java.Lang.Object.GetObject<CollapsingToolbarLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetStatusBarScrimColor(color);
		}

		// Token: 0x06000B43 RID: 2883 RVA: 0x0001E538 File Offset: 0x0001C738
		[Register("setStatusBarScrimColor", "(I)V", "GetSetStatusBarScrimColor_IHandler")]
		public unsafe virtual void SetStatusBarScrimColor(int color)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(color);
			CollapsingToolbarLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setStatusBarScrimColor.(I)V", this, ptr);
		}

		// Token: 0x06000B44 RID: 2884 RVA: 0x0001E573 File Offset: 0x0001C773
		private static Delegate GetSetStatusBarScrimResource_IHandler()
		{
			if (CollapsingToolbarLayout.cb_setStatusBarScrimResource_I == null)
			{
				CollapsingToolbarLayout.cb_setStatusBarScrimResource_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(CollapsingToolbarLayout.n_SetStatusBarScrimResource_I));
			}
			return CollapsingToolbarLayout.cb_setStatusBarScrimResource_I;
		}

		// Token: 0x06000B45 RID: 2885 RVA: 0x0001E597 File Offset: 0x0001C797
		private static void n_SetStatusBarScrimResource_I(IntPtr jnienv, IntPtr native__this, int resId)
		{
			Java.Lang.Object.GetObject<CollapsingToolbarLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetStatusBarScrimResource(resId);
		}

		// Token: 0x06000B46 RID: 2886 RVA: 0x0001E5A8 File Offset: 0x0001C7A8
		[Register("setStatusBarScrimResource", "(I)V", "GetSetStatusBarScrimResource_IHandler")]
		public unsafe virtual void SetStatusBarScrimResource(int resId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(resId);
			CollapsingToolbarLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setStatusBarScrimResource.(I)V", this, ptr);
		}

		// Token: 0x06000B47 RID: 2887 RVA: 0x0001E5E3 File Offset: 0x0001C7E3
		private static Delegate GetSetTitleEllipsize_Landroid_text_TextUtils_TruncateAt_Handler()
		{
			if (CollapsingToolbarLayout.cb_setTitleEllipsize_Landroid_text_TextUtils_TruncateAt_ == null)
			{
				CollapsingToolbarLayout.cb_setTitleEllipsize_Landroid_text_TextUtils_TruncateAt_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(CollapsingToolbarLayout.n_SetTitleEllipsize_Landroid_text_TextUtils_TruncateAt_));
			}
			return CollapsingToolbarLayout.cb_setTitleEllipsize_Landroid_text_TextUtils_TruncateAt_;
		}

		// Token: 0x06000B48 RID: 2888 RVA: 0x0001E608 File Offset: 0x0001C808
		private static void n_SetTitleEllipsize_Landroid_text_TextUtils_TruncateAt_(IntPtr jnienv, IntPtr native__this, IntPtr native_ellipsize)
		{
			CollapsingToolbarLayout @object = Java.Lang.Object.GetObject<CollapsingToolbarLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TextUtils.TruncateAt object2 = Java.Lang.Object.GetObject<TextUtils.TruncateAt>(native_ellipsize, JniHandleOwnership.DoNotTransfer);
			@object.SetTitleEllipsize(object2);
		}

		// Token: 0x06000B49 RID: 2889 RVA: 0x0001E62C File Offset: 0x0001C82C
		[Register("setTitleEllipsize", "(Landroid/text/TextUtils$TruncateAt;)V", "GetSetTitleEllipsize_Landroid_text_TextUtils_TruncateAt_Handler")]
		public unsafe virtual void SetTitleEllipsize(TextUtils.TruncateAt ellipsize)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((ellipsize == null) ? IntPtr.Zero : ellipsize.Handle);
				CollapsingToolbarLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setTitleEllipsize.(Landroid/text/TextUtils$TruncateAt;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(ellipsize);
			}
		}

		// Token: 0x04000304 RID: 772
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/material/appbar/CollapsingToolbarLayout", typeof(CollapsingToolbarLayout));

		// Token: 0x04000305 RID: 773
		private static Delegate cb_getCollapsedTitleGravity;

		// Token: 0x04000306 RID: 774
		private static Delegate cb_setCollapsedTitleGravity_I;

		// Token: 0x04000307 RID: 775
		private static Delegate cb_getCollapsedTitleTextSize;

		// Token: 0x04000308 RID: 776
		private static Delegate cb_setCollapsedTitleTextSize_F;

		// Token: 0x04000309 RID: 777
		private static Delegate cb_getCollapsedTitleTypeface;

		// Token: 0x0400030A RID: 778
		private static Delegate cb_setCollapsedTitleTypeface_Landroid_graphics_Typeface_;

		// Token: 0x0400030B RID: 779
		private static Delegate cb_getContentScrim;

		// Token: 0x0400030C RID: 780
		private static Delegate cb_setContentScrim_Landroid_graphics_drawable_Drawable_;

		// Token: 0x0400030D RID: 781
		private static Delegate cb_getExpandedTitleGravity;

		// Token: 0x0400030E RID: 782
		private static Delegate cb_setExpandedTitleGravity_I;

		// Token: 0x0400030F RID: 783
		private static Delegate cb_getExpandedTitleMarginBottom;

		// Token: 0x04000310 RID: 784
		private static Delegate cb_setExpandedTitleMarginBottom_I;

		// Token: 0x04000311 RID: 785
		private static Delegate cb_getExpandedTitleMarginEnd;

		// Token: 0x04000312 RID: 786
		private static Delegate cb_setExpandedTitleMarginEnd_I;

		// Token: 0x04000313 RID: 787
		private static Delegate cb_getExpandedTitleMarginStart;

		// Token: 0x04000314 RID: 788
		private static Delegate cb_setExpandedTitleMarginStart_I;

		// Token: 0x04000315 RID: 789
		private static Delegate cb_getExpandedTitleMarginTop;

		// Token: 0x04000316 RID: 790
		private static Delegate cb_setExpandedTitleMarginTop_I;

		// Token: 0x04000317 RID: 791
		private static Delegate cb_getExpandedTitleTextSize;

		// Token: 0x04000318 RID: 792
		private static Delegate cb_setExpandedTitleTextSize_F;

		// Token: 0x04000319 RID: 793
		private static Delegate cb_getExpandedTitleTypeface;

		// Token: 0x0400031A RID: 794
		private static Delegate cb_setExpandedTitleTypeface_Landroid_graphics_Typeface_;

		// Token: 0x0400031B RID: 795
		private static Delegate cb_isExtraMultilineHeightEnabled;

		// Token: 0x0400031C RID: 796
		private static Delegate cb_setExtraMultilineHeightEnabled_Z;

		// Token: 0x0400031D RID: 797
		private static Delegate cb_isForceApplySystemWindowInsetTop;

		// Token: 0x0400031E RID: 798
		private static Delegate cb_setForceApplySystemWindowInsetTop_Z;

		// Token: 0x0400031F RID: 799
		private static Delegate cb_getHyphenationFrequency;

		// Token: 0x04000320 RID: 800
		private static Delegate cb_setHyphenationFrequency_I;

		// Token: 0x04000321 RID: 801
		private static Delegate cb_getLineCount;

		// Token: 0x04000322 RID: 802
		private static Delegate cb_getLineSpacingAdd;

		// Token: 0x04000323 RID: 803
		private static Delegate cb_setLineSpacingAdd_F;

		// Token: 0x04000324 RID: 804
		private static Delegate cb_getLineSpacingMultiplier;

		// Token: 0x04000325 RID: 805
		private static Delegate cb_setLineSpacingMultiplier_F;

		// Token: 0x04000326 RID: 806
		private static Delegate cb_getMaxLines;

		// Token: 0x04000327 RID: 807
		private static Delegate cb_setMaxLines_I;

		// Token: 0x04000328 RID: 808
		private static Delegate cb_isRtlTextDirectionHeuristicsEnabled;

		// Token: 0x04000329 RID: 809
		private static Delegate cb_setRtlTextDirectionHeuristicsEnabled_Z;

		// Token: 0x0400032A RID: 810
		private static Delegate cb_getScrimAnimationDuration;

		// Token: 0x0400032B RID: 811
		private static Delegate cb_setScrimAnimationDuration_J;

		// Token: 0x0400032C RID: 812
		private static Delegate cb_getScrimVisibleHeightTrigger;

		// Token: 0x0400032D RID: 813
		private static Delegate cb_setScrimVisibleHeightTrigger_I;

		// Token: 0x0400032E RID: 814
		private static Delegate cb_getStatusBarScrim;

		// Token: 0x0400032F RID: 815
		private static Delegate cb_setStatusBarScrim_Landroid_graphics_drawable_Drawable_;

		// Token: 0x04000330 RID: 816
		private static Delegate cb_getTitle;

		// Token: 0x04000331 RID: 817
		private static Delegate cb_setTitle_Ljava_lang_CharSequence_;

		// Token: 0x04000332 RID: 818
		private static Delegate cb_getTitleCollapseMode;

		// Token: 0x04000333 RID: 819
		private static Delegate cb_setTitleCollapseMode_I;

		// Token: 0x04000334 RID: 820
		private static Delegate cb_isTitleEnabled;

		// Token: 0x04000335 RID: 821
		private static Delegate cb_setTitleEnabled_Z;

		// Token: 0x04000336 RID: 822
		private static Delegate cb_getTitlePositionInterpolator;

		// Token: 0x04000337 RID: 823
		private static Delegate cb_setTitlePositionInterpolator_Landroid_animation_TimeInterpolator_;

		// Token: 0x04000338 RID: 824
		private static Delegate cb_getTitleTextEllipsize;

		// Token: 0x04000339 RID: 825
		private static Delegate cb_setCollapsedTitleTextAppearance_I;

		// Token: 0x0400033A RID: 826
		private static Delegate cb_setCollapsedTitleTextColor_Landroid_content_res_ColorStateList_;

		// Token: 0x0400033B RID: 827
		private static Delegate cb_setCollapsedTitleTextColor_I;

		// Token: 0x0400033C RID: 828
		private static Delegate cb_setContentScrimColor_I;

		// Token: 0x0400033D RID: 829
		private static Delegate cb_setContentScrimResource_I;

		// Token: 0x0400033E RID: 830
		private static Delegate cb_setExpandedTitleColor_I;

		// Token: 0x0400033F RID: 831
		private static Delegate cb_setExpandedTitleMargin_IIII;

		// Token: 0x04000340 RID: 832
		private static Delegate cb_setExpandedTitleTextAppearance_I;

		// Token: 0x04000341 RID: 833
		private static Delegate cb_setExpandedTitleTextColor_Landroid_content_res_ColorStateList_;

		// Token: 0x04000342 RID: 834
		private static Delegate cb_setScrimsShown_Z;

		// Token: 0x04000343 RID: 835
		private static Delegate cb_setScrimsShown_ZZ;

		// Token: 0x04000344 RID: 836
		private static Delegate cb_setStaticLayoutBuilderConfigurer_Lcom_google_android_material_appbar_CollapsingToolbarLayout_StaticLayoutBuilderConfigurer_;

		// Token: 0x04000345 RID: 837
		private static Delegate cb_setStatusBarScrimColor_I;

		// Token: 0x04000346 RID: 838
		private static Delegate cb_setStatusBarScrimResource_I;

		// Token: 0x04000347 RID: 839
		private static Delegate cb_setTitleEllipsize_Landroid_text_TextUtils_TruncateAt_;

		// Token: 0x0200009B RID: 155
		[Register("com/google/android/material/appbar/CollapsingToolbarLayout$StaticLayoutBuilderConfigurer", "", "Google.Android.Material.AppBar.CollapsingToolbarLayout/IStaticLayoutBuilderConfigurerInvoker")]
		public interface IStaticLayoutBuilderConfigurer : Google.Android.Material.Internal.IStaticLayoutBuilderConfigurer, IJavaObject, IDisposable, IJavaPeerable
		{
		}

		// Token: 0x0200009C RID: 156
		[Register("com/google/android/material/appbar/CollapsingToolbarLayout$StaticLayoutBuilderConfigurer", DoNotGenerateAcw = true)]
		internal class IStaticLayoutBuilderConfigurerInvoker : Java.Lang.Object, CollapsingToolbarLayout.IStaticLayoutBuilderConfigurer, Google.Android.Material.Internal.IStaticLayoutBuilderConfigurer, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x170001D3 RID: 467
			// (get) Token: 0x06000B4B RID: 2891 RVA: 0x0001E6AC File Offset: 0x0001C8AC
			private static IntPtr java_class_ref
			{
				get
				{
					return CollapsingToolbarLayout.IStaticLayoutBuilderConfigurerInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170001D4 RID: 468
			// (get) Token: 0x06000B4C RID: 2892 RVA: 0x0001E6D0 File Offset: 0x0001C8D0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return CollapsingToolbarLayout.IStaticLayoutBuilderConfigurerInvoker._members;
				}
			}

			// Token: 0x170001D5 RID: 469
			// (get) Token: 0x06000B4D RID: 2893 RVA: 0x0001E6D7 File Offset: 0x0001C8D7
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x170001D6 RID: 470
			// (get) Token: 0x06000B4E RID: 2894 RVA: 0x0001E6DF File Offset: 0x0001C8DF
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return CollapsingToolbarLayout.IStaticLayoutBuilderConfigurerInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06000B4F RID: 2895 RVA: 0x0001E6EB File Offset: 0x0001C8EB
			public static CollapsingToolbarLayout.IStaticLayoutBuilderConfigurer GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<CollapsingToolbarLayout.IStaticLayoutBuilderConfigurer>(handle, transfer);
			}

			// Token: 0x06000B50 RID: 2896 RVA: 0x0001E6F4 File Offset: 0x0001C8F4
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, CollapsingToolbarLayout.IStaticLayoutBuilderConfigurerInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.material.appbar.CollapsingToolbarLayout.StaticLayoutBuilderConfigurer'.");
				}
				return handle;
			}

			// Token: 0x06000B51 RID: 2897 RVA: 0x0001E71F File Offset: 0x0001C91F
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06000B52 RID: 2898 RVA: 0x0001E750 File Offset: 0x0001C950
			public IStaticLayoutBuilderConfigurerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(CollapsingToolbarLayout.IStaticLayoutBuilderConfigurerInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x06000B53 RID: 2899 RVA: 0x0001E788 File Offset: 0x0001C988
			private static Delegate GetConfigure_Landroid_text_StaticLayout_Builder_Handler()
			{
				if (CollapsingToolbarLayout.IStaticLayoutBuilderConfigurerInvoker.cb_configure_Landroid_text_StaticLayout_Builder_ == null)
				{
					CollapsingToolbarLayout.IStaticLayoutBuilderConfigurerInvoker.cb_configure_Landroid_text_StaticLayout_Builder_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(CollapsingToolbarLayout.IStaticLayoutBuilderConfigurerInvoker.n_Configure_Landroid_text_StaticLayout_Builder_));
				}
				return CollapsingToolbarLayout.IStaticLayoutBuilderConfigurerInvoker.cb_configure_Landroid_text_StaticLayout_Builder_;
			}

			// Token: 0x06000B54 RID: 2900 RVA: 0x0001E7AC File Offset: 0x0001C9AC
			private static void n_Configure_Landroid_text_StaticLayout_Builder_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				Google.Android.Material.Internal.IStaticLayoutBuilderConfigurer @object = Java.Lang.Object.GetObject<CollapsingToolbarLayout.IStaticLayoutBuilderConfigurer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				StaticLayout.Builder object2 = Java.Lang.Object.GetObject<StaticLayout.Builder>(native_p0, JniHandleOwnership.DoNotTransfer);
				@object.Configure(object2);
			}

			// Token: 0x06000B55 RID: 2901 RVA: 0x0001E7D0 File Offset: 0x0001C9D0
			public unsafe void Configure(StaticLayout.Builder p0)
			{
				if (this.id_configure_Landroid_text_StaticLayout_Builder_ == IntPtr.Zero)
				{
					this.id_configure_Landroid_text_StaticLayout_Builder_ = JNIEnv.GetMethodID(this.class_ref, "configure", "(Landroid/text/StaticLayout$Builder;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_configure_Landroid_text_StaticLayout_Builder_, ptr);
			}

			// Token: 0x04000348 RID: 840
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/material/appbar/CollapsingToolbarLayout$StaticLayoutBuilderConfigurer", typeof(CollapsingToolbarLayout.IStaticLayoutBuilderConfigurerInvoker));

			// Token: 0x04000349 RID: 841
			private IntPtr class_ref;

			// Token: 0x0400034A RID: 842
			private static Delegate cb_configure_Landroid_text_StaticLayout_Builder_;

			// Token: 0x0400034B RID: 843
			private IntPtr id_configure_Landroid_text_StaticLayout_Builder_;
		}
	}
}
