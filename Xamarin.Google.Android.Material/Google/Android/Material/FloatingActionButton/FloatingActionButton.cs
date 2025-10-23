using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Animation;
using Android.Content;
using Android.Content.Res;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Runtime;
using Android.Util;
using AndroidX.CoordinatorLayout.Widget;
using AndroidX.Core.View;
using AndroidX.Core.Widget;
using Google.Android.Material.Animation;
using Google.Android.Material.Expandable;
using Google.Android.Material.Internal;
using Google.Android.Material.Shape;
using Java.Interop;
using Java.Lang;

namespace Google.Android.Material.FloatingActionButton
{
	// Token: 0x02000044 RID: 68
	[Register("com/google/android/material/floatingactionbutton/FloatingActionButton", DoNotGenerateAcw = true)]
	public class FloatingActionButton : VisibilityAwareImageButton, CoordinatorLayout.IAttachedBehavior, IJavaObject, IDisposable, IJavaPeerable, ITintableBackgroundView, ITintableImageSourceView, IExpandableTransformationWidget, IExpandableWidget, IShapeable
	{
		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x00005F78 File Offset: 0x00004178
		internal new static IntPtr class_ref
		{
			get
			{
				return FloatingActionButton._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060001F6 RID: 502 RVA: 0x00005F9C File Offset: 0x0000419C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return FloatingActionButton._members;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x00005FA4 File Offset: 0x000041A4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return FloatingActionButton._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x00005FC8 File Offset: 0x000041C8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return FloatingActionButton._members.ManagedPeerType;
			}
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00005FD4 File Offset: 0x000041D4
		protected FloatingActionButton(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00005FE0 File Offset: 0x000041E0
		[Register(".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe FloatingActionButton(Context context) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				base.SetHandle(FloatingActionButton._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				FloatingActionButton._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00006090 File Offset: 0x00004290
		[Register(".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe FloatingActionButton(Context context, IAttributeSet attrs) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(FloatingActionButton._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				FloatingActionButton._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x060001FC RID: 508 RVA: 0x0000616C File Offset: 0x0000436C
		[Register(".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe FloatingActionButton(Context context, IAttributeSet attrs, int defStyleAttr) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(FloatingActionButton._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				FloatingActionButton._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x060001FD RID: 509 RVA: 0x0000625C File Offset: 0x0000445C
		private static Delegate GetGetCompatElevationHandler()
		{
			if (FloatingActionButton.cb_getCompatElevation == null)
			{
				FloatingActionButton.cb_getCompatElevation = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_F(FloatingActionButton.n_GetCompatElevation));
			}
			return FloatingActionButton.cb_getCompatElevation;
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00006280 File Offset: 0x00004480
		private static float n_GetCompatElevation(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<FloatingActionButton>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CompatElevation;
		}

		// Token: 0x060001FF RID: 511 RVA: 0x0000628F File Offset: 0x0000448F
		private static Delegate GetSetCompatElevation_FHandler()
		{
			if (FloatingActionButton.cb_setCompatElevation_F == null)
			{
				FloatingActionButton.cb_setCompatElevation_F = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPF_V(FloatingActionButton.n_SetCompatElevation_F));
			}
			return FloatingActionButton.cb_setCompatElevation_F;
		}

		// Token: 0x06000200 RID: 512 RVA: 0x000062B3 File Offset: 0x000044B3
		private static void n_SetCompatElevation_F(IntPtr jnienv, IntPtr native__this, float elevation)
		{
			Java.Lang.Object.GetObject<FloatingActionButton>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CompatElevation = elevation;
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000201 RID: 513 RVA: 0x000062C3 File Offset: 0x000044C3
		// (set) Token: 0x06000202 RID: 514 RVA: 0x000062DC File Offset: 0x000044DC
		public unsafe virtual float CompatElevation
		{
			[Register("getCompatElevation", "()F", "GetGetCompatElevationHandler")]
			get
			{
				return FloatingActionButton._members.InstanceMethods.InvokeVirtualSingleMethod("getCompatElevation.()F", this, null);
			}
			[Register("setCompatElevation", "(F)V", "GetSetCompatElevation_FHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				FloatingActionButton._members.InstanceMethods.InvokeVirtualVoidMethod("setCompatElevation.(F)V", this, ptr);
			}
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00006317 File Offset: 0x00004517
		private static Delegate GetGetCompatHoveredFocusedTranslationZHandler()
		{
			if (FloatingActionButton.cb_getCompatHoveredFocusedTranslationZ == null)
			{
				FloatingActionButton.cb_getCompatHoveredFocusedTranslationZ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_F(FloatingActionButton.n_GetCompatHoveredFocusedTranslationZ));
			}
			return FloatingActionButton.cb_getCompatHoveredFocusedTranslationZ;
		}

		// Token: 0x06000204 RID: 516 RVA: 0x0000633B File Offset: 0x0000453B
		private static float n_GetCompatHoveredFocusedTranslationZ(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<FloatingActionButton>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CompatHoveredFocusedTranslationZ;
		}

		// Token: 0x06000205 RID: 517 RVA: 0x0000634A File Offset: 0x0000454A
		private static Delegate GetSetCompatHoveredFocusedTranslationZ_FHandler()
		{
			if (FloatingActionButton.cb_setCompatHoveredFocusedTranslationZ_F == null)
			{
				FloatingActionButton.cb_setCompatHoveredFocusedTranslationZ_F = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPF_V(FloatingActionButton.n_SetCompatHoveredFocusedTranslationZ_F));
			}
			return FloatingActionButton.cb_setCompatHoveredFocusedTranslationZ_F;
		}

		// Token: 0x06000206 RID: 518 RVA: 0x0000636E File Offset: 0x0000456E
		private static void n_SetCompatHoveredFocusedTranslationZ_F(IntPtr jnienv, IntPtr native__this, float translationZ)
		{
			Java.Lang.Object.GetObject<FloatingActionButton>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CompatHoveredFocusedTranslationZ = translationZ;
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000207 RID: 519 RVA: 0x0000637E File Offset: 0x0000457E
		// (set) Token: 0x06000208 RID: 520 RVA: 0x00006398 File Offset: 0x00004598
		public unsafe virtual float CompatHoveredFocusedTranslationZ
		{
			[Register("getCompatHoveredFocusedTranslationZ", "()F", "GetGetCompatHoveredFocusedTranslationZHandler")]
			get
			{
				return FloatingActionButton._members.InstanceMethods.InvokeVirtualSingleMethod("getCompatHoveredFocusedTranslationZ.()F", this, null);
			}
			[Register("setCompatHoveredFocusedTranslationZ", "(F)V", "GetSetCompatHoveredFocusedTranslationZ_FHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				FloatingActionButton._members.InstanceMethods.InvokeVirtualVoidMethod("setCompatHoveredFocusedTranslationZ.(F)V", this, ptr);
			}
		}

		// Token: 0x06000209 RID: 521 RVA: 0x000063D3 File Offset: 0x000045D3
		private static Delegate GetGetCompatPressedTranslationZHandler()
		{
			if (FloatingActionButton.cb_getCompatPressedTranslationZ == null)
			{
				FloatingActionButton.cb_getCompatPressedTranslationZ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_F(FloatingActionButton.n_GetCompatPressedTranslationZ));
			}
			return FloatingActionButton.cb_getCompatPressedTranslationZ;
		}

		// Token: 0x0600020A RID: 522 RVA: 0x000063F7 File Offset: 0x000045F7
		private static float n_GetCompatPressedTranslationZ(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<FloatingActionButton>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CompatPressedTranslationZ;
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00006406 File Offset: 0x00004606
		private static Delegate GetSetCompatPressedTranslationZ_FHandler()
		{
			if (FloatingActionButton.cb_setCompatPressedTranslationZ_F == null)
			{
				FloatingActionButton.cb_setCompatPressedTranslationZ_F = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPF_V(FloatingActionButton.n_SetCompatPressedTranslationZ_F));
			}
			return FloatingActionButton.cb_setCompatPressedTranslationZ_F;
		}

		// Token: 0x0600020C RID: 524 RVA: 0x0000642A File Offset: 0x0000462A
		private static void n_SetCompatPressedTranslationZ_F(IntPtr jnienv, IntPtr native__this, float translationZ)
		{
			Java.Lang.Object.GetObject<FloatingActionButton>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CompatPressedTranslationZ = translationZ;
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600020D RID: 525 RVA: 0x0000643A File Offset: 0x0000463A
		// (set) Token: 0x0600020E RID: 526 RVA: 0x00006454 File Offset: 0x00004654
		public unsafe virtual float CompatPressedTranslationZ
		{
			[Register("getCompatPressedTranslationZ", "()F", "GetGetCompatPressedTranslationZHandler")]
			get
			{
				return FloatingActionButton._members.InstanceMethods.InvokeVirtualSingleMethod("getCompatPressedTranslationZ.()F", this, null);
			}
			[Register("setCompatPressedTranslationZ", "(F)V", "GetSetCompatPressedTranslationZ_FHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				FloatingActionButton._members.InstanceMethods.InvokeVirtualVoidMethod("setCompatPressedTranslationZ.(F)V", this, ptr);
			}
		}

		// Token: 0x0600020F RID: 527 RVA: 0x0000648F File Offset: 0x0000468F
		private static Delegate GetGetContentBackgroundHandler()
		{
			if (FloatingActionButton.cb_getContentBackground == null)
			{
				FloatingActionButton.cb_getContentBackground = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(FloatingActionButton.n_GetContentBackground));
			}
			return FloatingActionButton.cb_getContentBackground;
		}

		// Token: 0x06000210 RID: 528 RVA: 0x000064B3 File Offset: 0x000046B3
		private static IntPtr n_GetContentBackground(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<FloatingActionButton>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ContentBackground);
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000211 RID: 529 RVA: 0x000064C8 File Offset: 0x000046C8
		public virtual Drawable ContentBackground
		{
			[Register("getContentBackground", "()Landroid/graphics/drawable/Drawable;", "GetGetContentBackgroundHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Drawable>(FloatingActionButton._members.InstanceMethods.InvokeVirtualObjectMethod("getContentBackground.()Landroid/graphics/drawable/Drawable;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000212 RID: 530 RVA: 0x000064FA File Offset: 0x000046FA
		private static Delegate GetGetCustomSizeHandler()
		{
			if (FloatingActionButton.cb_getCustomSize == null)
			{
				FloatingActionButton.cb_getCustomSize = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(FloatingActionButton.n_GetCustomSize));
			}
			return FloatingActionButton.cb_getCustomSize;
		}

		// Token: 0x06000213 RID: 531 RVA: 0x0000651E File Offset: 0x0000471E
		private static int n_GetCustomSize(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<FloatingActionButton>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CustomSize;
		}

		// Token: 0x06000214 RID: 532 RVA: 0x0000652D File Offset: 0x0000472D
		private static Delegate GetSetCustomSize_IHandler()
		{
			if (FloatingActionButton.cb_setCustomSize_I == null)
			{
				FloatingActionButton.cb_setCustomSize_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(FloatingActionButton.n_SetCustomSize_I));
			}
			return FloatingActionButton.cb_setCustomSize_I;
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00006551 File Offset: 0x00004751
		private static void n_SetCustomSize_I(IntPtr jnienv, IntPtr native__this, int size)
		{
			Java.Lang.Object.GetObject<FloatingActionButton>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CustomSize = size;
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000216 RID: 534 RVA: 0x00006561 File Offset: 0x00004761
		// (set) Token: 0x06000217 RID: 535 RVA: 0x0000657C File Offset: 0x0000477C
		public unsafe virtual int CustomSize
		{
			[Register("getCustomSize", "()I", "GetGetCustomSizeHandler")]
			get
			{
				return FloatingActionButton._members.InstanceMethods.InvokeVirtualInt32Method("getCustomSize.()I", this, null);
			}
			[Register("setCustomSize", "(I)V", "GetSetCustomSize_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				FloatingActionButton._members.InstanceMethods.InvokeVirtualVoidMethod("setCustomSize.(I)V", this, ptr);
			}
		}

		// Token: 0x06000218 RID: 536 RVA: 0x000065B7 File Offset: 0x000047B7
		private static Delegate GetGetExpandedComponentIdHintHandler()
		{
			if (FloatingActionButton.cb_getExpandedComponentIdHint == null)
			{
				FloatingActionButton.cb_getExpandedComponentIdHint = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(FloatingActionButton.n_GetExpandedComponentIdHint));
			}
			return FloatingActionButton.cb_getExpandedComponentIdHint;
		}

		// Token: 0x06000219 RID: 537 RVA: 0x000065DB File Offset: 0x000047DB
		private static int n_GetExpandedComponentIdHint(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<FloatingActionButton>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ExpandedComponentIdHint;
		}

		// Token: 0x0600021A RID: 538 RVA: 0x000065EA File Offset: 0x000047EA
		private static Delegate GetSetExpandedComponentIdHint_IHandler()
		{
			if (FloatingActionButton.cb_setExpandedComponentIdHint_I == null)
			{
				FloatingActionButton.cb_setExpandedComponentIdHint_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(FloatingActionButton.n_SetExpandedComponentIdHint_I));
			}
			return FloatingActionButton.cb_setExpandedComponentIdHint_I;
		}

		// Token: 0x0600021B RID: 539 RVA: 0x0000660E File Offset: 0x0000480E
		private static void n_SetExpandedComponentIdHint_I(IntPtr jnienv, IntPtr native__this, int expandedComponentIdHint)
		{
			Java.Lang.Object.GetObject<FloatingActionButton>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ExpandedComponentIdHint = expandedComponentIdHint;
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600021C RID: 540 RVA: 0x0000661E File Offset: 0x0000481E
		// (set) Token: 0x0600021D RID: 541 RVA: 0x00006638 File Offset: 0x00004838
		public unsafe virtual int ExpandedComponentIdHint
		{
			[Register("getExpandedComponentIdHint", "()I", "GetGetExpandedComponentIdHintHandler")]
			get
			{
				return FloatingActionButton._members.InstanceMethods.InvokeVirtualInt32Method("getExpandedComponentIdHint.()I", this, null);
			}
			[Register("setExpandedComponentIdHint", "(I)V", "GetSetExpandedComponentIdHint_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				FloatingActionButton._members.InstanceMethods.InvokeVirtualVoidMethod("setExpandedComponentIdHint.(I)V", this, ptr);
			}
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00006673 File Offset: 0x00004873
		private static Delegate GetGetHideMotionSpecHandler()
		{
			if (FloatingActionButton.cb_getHideMotionSpec == null)
			{
				FloatingActionButton.cb_getHideMotionSpec = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(FloatingActionButton.n_GetHideMotionSpec));
			}
			return FloatingActionButton.cb_getHideMotionSpec;
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00006697 File Offset: 0x00004897
		private static IntPtr n_GetHideMotionSpec(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<FloatingActionButton>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HideMotionSpec);
		}

		// Token: 0x06000220 RID: 544 RVA: 0x000066AB File Offset: 0x000048AB
		private static Delegate GetSetHideMotionSpec_Lcom_google_android_material_animation_MotionSpec_Handler()
		{
			if (FloatingActionButton.cb_setHideMotionSpec_Lcom_google_android_material_animation_MotionSpec_ == null)
			{
				FloatingActionButton.cb_setHideMotionSpec_Lcom_google_android_material_animation_MotionSpec_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(FloatingActionButton.n_SetHideMotionSpec_Lcom_google_android_material_animation_MotionSpec_));
			}
			return FloatingActionButton.cb_setHideMotionSpec_Lcom_google_android_material_animation_MotionSpec_;
		}

		// Token: 0x06000221 RID: 545 RVA: 0x000066D0 File Offset: 0x000048D0
		private static void n_SetHideMotionSpec_Lcom_google_android_material_animation_MotionSpec_(IntPtr jnienv, IntPtr native__this, IntPtr native_spec)
		{
			FloatingActionButton @object = Java.Lang.Object.GetObject<FloatingActionButton>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			MotionSpec object2 = Java.Lang.Object.GetObject<MotionSpec>(native_spec, JniHandleOwnership.DoNotTransfer);
			@object.HideMotionSpec = object2;
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000222 RID: 546 RVA: 0x000066F4 File Offset: 0x000048F4
		// (set) Token: 0x06000223 RID: 547 RVA: 0x00006728 File Offset: 0x00004928
		public unsafe virtual MotionSpec HideMotionSpec
		{
			[Register("getHideMotionSpec", "()Lcom/google/android/material/animation/MotionSpec;", "GetGetHideMotionSpecHandler")]
			get
			{
				return Java.Lang.Object.GetObject<MotionSpec>(FloatingActionButton._members.InstanceMethods.InvokeVirtualObjectMethod("getHideMotionSpec.()Lcom/google/android/material/animation/MotionSpec;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setHideMotionSpec", "(Lcom/google/android/material/animation/MotionSpec;)V", "GetSetHideMotionSpec_Lcom_google_android_material_animation_MotionSpec_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					FloatingActionButton._members.InstanceMethods.InvokeVirtualVoidMethod("setHideMotionSpec.(Lcom/google/android/material/animation/MotionSpec;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x06000224 RID: 548 RVA: 0x0000678C File Offset: 0x0000498C
		private static Delegate GetIsExpandedHandler()
		{
			if (FloatingActionButton.cb_isExpanded == null)
			{
				FloatingActionButton.cb_isExpanded = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(FloatingActionButton.n_IsExpanded));
			}
			return FloatingActionButton.cb_isExpanded;
		}

		// Token: 0x06000225 RID: 549 RVA: 0x000067B0 File Offset: 0x000049B0
		private static bool n_IsExpanded(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<FloatingActionButton>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsExpanded;
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000226 RID: 550 RVA: 0x000067BF File Offset: 0x000049BF
		public virtual bool IsExpanded
		{
			[Register("isExpanded", "()Z", "GetIsExpandedHandler")]
			get
			{
				return FloatingActionButton._members.InstanceMethods.InvokeVirtualBooleanMethod("isExpanded.()Z", this, null);
			}
		}

		// Token: 0x06000227 RID: 551 RVA: 0x000067D8 File Offset: 0x000049D8
		private static Delegate GetIsOrWillBeHiddenHandler()
		{
			if (FloatingActionButton.cb_isOrWillBeHidden == null)
			{
				FloatingActionButton.cb_isOrWillBeHidden = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(FloatingActionButton.n_IsOrWillBeHidden));
			}
			return FloatingActionButton.cb_isOrWillBeHidden;
		}

		// Token: 0x06000228 RID: 552 RVA: 0x000067FC File Offset: 0x000049FC
		private static bool n_IsOrWillBeHidden(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<FloatingActionButton>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsOrWillBeHidden;
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000229 RID: 553 RVA: 0x0000680B File Offset: 0x00004A0B
		public virtual bool IsOrWillBeHidden
		{
			[Register("isOrWillBeHidden", "()Z", "GetIsOrWillBeHiddenHandler")]
			get
			{
				return FloatingActionButton._members.InstanceMethods.InvokeVirtualBooleanMethod("isOrWillBeHidden.()Z", this, null);
			}
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00006824 File Offset: 0x00004A24
		private static Delegate GetIsOrWillBeShownHandler()
		{
			if (FloatingActionButton.cb_isOrWillBeShown == null)
			{
				FloatingActionButton.cb_isOrWillBeShown = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(FloatingActionButton.n_IsOrWillBeShown));
			}
			return FloatingActionButton.cb_isOrWillBeShown;
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00006848 File Offset: 0x00004A48
		private static bool n_IsOrWillBeShown(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<FloatingActionButton>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsOrWillBeShown;
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600022C RID: 556 RVA: 0x00006857 File Offset: 0x00004A57
		public virtual bool IsOrWillBeShown
		{
			[Register("isOrWillBeShown", "()Z", "GetIsOrWillBeShownHandler")]
			get
			{
				return FloatingActionButton._members.InstanceMethods.InvokeVirtualBooleanMethod("isOrWillBeShown.()Z", this, null);
			}
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00006870 File Offset: 0x00004A70
		private static Delegate GetGetRippleColorHandler()
		{
			if (FloatingActionButton.cb_getRippleColor == null)
			{
				FloatingActionButton.cb_getRippleColor = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(FloatingActionButton.n_GetRippleColor));
			}
			return FloatingActionButton.cb_getRippleColor;
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00006894 File Offset: 0x00004A94
		private static int n_GetRippleColor(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<FloatingActionButton>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RippleColor;
		}

		// Token: 0x0600022F RID: 559 RVA: 0x000068A3 File Offset: 0x00004AA3
		private static Delegate GetSetRippleColor_IHandler()
		{
			if (FloatingActionButton.cb_setRippleColor_I == null)
			{
				FloatingActionButton.cb_setRippleColor_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(FloatingActionButton.n_SetRippleColor_I));
			}
			return FloatingActionButton.cb_setRippleColor_I;
		}

		// Token: 0x06000230 RID: 560 RVA: 0x000068C7 File Offset: 0x00004AC7
		private static void n_SetRippleColor_I(IntPtr jnienv, IntPtr native__this, int color)
		{
			Java.Lang.Object.GetObject<FloatingActionButton>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RippleColor = color;
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000231 RID: 561 RVA: 0x000068D7 File Offset: 0x00004AD7
		// (set) Token: 0x06000232 RID: 562 RVA: 0x000068F0 File Offset: 0x00004AF0
		public unsafe virtual int RippleColor
		{
			[Register("getRippleColor", "()I", "GetGetRippleColorHandler")]
			get
			{
				return FloatingActionButton._members.InstanceMethods.InvokeVirtualInt32Method("getRippleColor.()I", this, null);
			}
			[Register("setRippleColor", "(I)V", "GetSetRippleColor_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				FloatingActionButton._members.InstanceMethods.InvokeVirtualVoidMethod("setRippleColor.(I)V", this, ptr);
			}
		}

		// Token: 0x06000233 RID: 563 RVA: 0x0000692B File Offset: 0x00004B2B
		private static Delegate GetGetRippleColorStateListHandler()
		{
			if (FloatingActionButton.cb_getRippleColorStateList == null)
			{
				FloatingActionButton.cb_getRippleColorStateList = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(FloatingActionButton.n_GetRippleColorStateList));
			}
			return FloatingActionButton.cb_getRippleColorStateList;
		}

		// Token: 0x06000234 RID: 564 RVA: 0x0000694F File Offset: 0x00004B4F
		private static IntPtr n_GetRippleColorStateList(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<FloatingActionButton>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RippleColorStateList);
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000235 RID: 565 RVA: 0x00006964 File Offset: 0x00004B64
		public virtual ColorStateList RippleColorStateList
		{
			[Register("getRippleColorStateList", "()Landroid/content/res/ColorStateList;", "GetGetRippleColorStateListHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ColorStateList>(FloatingActionButton._members.InstanceMethods.InvokeVirtualObjectMethod("getRippleColorStateList.()Landroid/content/res/ColorStateList;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00006996 File Offset: 0x00004B96
		private static Delegate GetGetShapeAppearanceModelHandler()
		{
			if (FloatingActionButton.cb_getShapeAppearanceModel == null)
			{
				FloatingActionButton.cb_getShapeAppearanceModel = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(FloatingActionButton.n_GetShapeAppearanceModel));
			}
			return FloatingActionButton.cb_getShapeAppearanceModel;
		}

		// Token: 0x06000237 RID: 567 RVA: 0x000069BA File Offset: 0x00004BBA
		private static IntPtr n_GetShapeAppearanceModel(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<FloatingActionButton>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ShapeAppearanceModel);
		}

		// Token: 0x06000238 RID: 568 RVA: 0x000069CE File Offset: 0x00004BCE
		private static Delegate GetSetShapeAppearanceModel_Lcom_google_android_material_shape_ShapeAppearanceModel_Handler()
		{
			if (FloatingActionButton.cb_setShapeAppearanceModel_Lcom_google_android_material_shape_ShapeAppearanceModel_ == null)
			{
				FloatingActionButton.cb_setShapeAppearanceModel_Lcom_google_android_material_shape_ShapeAppearanceModel_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(FloatingActionButton.n_SetShapeAppearanceModel_Lcom_google_android_material_shape_ShapeAppearanceModel_));
			}
			return FloatingActionButton.cb_setShapeAppearanceModel_Lcom_google_android_material_shape_ShapeAppearanceModel_;
		}

		// Token: 0x06000239 RID: 569 RVA: 0x000069F4 File Offset: 0x00004BF4
		private static void n_SetShapeAppearanceModel_Lcom_google_android_material_shape_ShapeAppearanceModel_(IntPtr jnienv, IntPtr native__this, IntPtr native_shapeAppearance)
		{
			FloatingActionButton @object = Java.Lang.Object.GetObject<FloatingActionButton>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ShapeAppearanceModel object2 = Java.Lang.Object.GetObject<ShapeAppearanceModel>(native_shapeAppearance, JniHandleOwnership.DoNotTransfer);
			@object.ShapeAppearanceModel = object2;
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x0600023A RID: 570 RVA: 0x00006A18 File Offset: 0x00004C18
		// (set) Token: 0x0600023B RID: 571 RVA: 0x00006A4C File Offset: 0x00004C4C
		public unsafe virtual ShapeAppearanceModel ShapeAppearanceModel
		{
			[Register("getShapeAppearanceModel", "()Lcom/google/android/material/shape/ShapeAppearanceModel;", "GetGetShapeAppearanceModelHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ShapeAppearanceModel>(FloatingActionButton._members.InstanceMethods.InvokeVirtualObjectMethod("getShapeAppearanceModel.()Lcom/google/android/material/shape/ShapeAppearanceModel;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setShapeAppearanceModel", "(Lcom/google/android/material/shape/ShapeAppearanceModel;)V", "GetSetShapeAppearanceModel_Lcom_google_android_material_shape_ShapeAppearanceModel_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					FloatingActionButton._members.InstanceMethods.InvokeVirtualVoidMethod("setShapeAppearanceModel.(Lcom/google/android/material/shape/ShapeAppearanceModel;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00006AB0 File Offset: 0x00004CB0
		private static Delegate GetGetShowMotionSpecHandler()
		{
			if (FloatingActionButton.cb_getShowMotionSpec == null)
			{
				FloatingActionButton.cb_getShowMotionSpec = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(FloatingActionButton.n_GetShowMotionSpec));
			}
			return FloatingActionButton.cb_getShowMotionSpec;
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00006AD4 File Offset: 0x00004CD4
		private static IntPtr n_GetShowMotionSpec(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<FloatingActionButton>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ShowMotionSpec);
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00006AE8 File Offset: 0x00004CE8
		private static Delegate GetSetShowMotionSpec_Lcom_google_android_material_animation_MotionSpec_Handler()
		{
			if (FloatingActionButton.cb_setShowMotionSpec_Lcom_google_android_material_animation_MotionSpec_ == null)
			{
				FloatingActionButton.cb_setShowMotionSpec_Lcom_google_android_material_animation_MotionSpec_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(FloatingActionButton.n_SetShowMotionSpec_Lcom_google_android_material_animation_MotionSpec_));
			}
			return FloatingActionButton.cb_setShowMotionSpec_Lcom_google_android_material_animation_MotionSpec_;
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00006B0C File Offset: 0x00004D0C
		private static void n_SetShowMotionSpec_Lcom_google_android_material_animation_MotionSpec_(IntPtr jnienv, IntPtr native__this, IntPtr native_spec)
		{
			FloatingActionButton @object = Java.Lang.Object.GetObject<FloatingActionButton>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			MotionSpec object2 = Java.Lang.Object.GetObject<MotionSpec>(native_spec, JniHandleOwnership.DoNotTransfer);
			@object.ShowMotionSpec = object2;
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000240 RID: 576 RVA: 0x00006B30 File Offset: 0x00004D30
		// (set) Token: 0x06000241 RID: 577 RVA: 0x00006B64 File Offset: 0x00004D64
		public unsafe virtual MotionSpec ShowMotionSpec
		{
			[Register("getShowMotionSpec", "()Lcom/google/android/material/animation/MotionSpec;", "GetGetShowMotionSpecHandler")]
			get
			{
				return Java.Lang.Object.GetObject<MotionSpec>(FloatingActionButton._members.InstanceMethods.InvokeVirtualObjectMethod("getShowMotionSpec.()Lcom/google/android/material/animation/MotionSpec;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setShowMotionSpec", "(Lcom/google/android/material/animation/MotionSpec;)V", "GetSetShowMotionSpec_Lcom_google_android_material_animation_MotionSpec_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					FloatingActionButton._members.InstanceMethods.InvokeVirtualVoidMethod("setShowMotionSpec.(Lcom/google/android/material/animation/MotionSpec;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00006BC8 File Offset: 0x00004DC8
		private static Delegate GetGetSizeHandler()
		{
			if (FloatingActionButton.cb_getSize == null)
			{
				FloatingActionButton.cb_getSize = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(FloatingActionButton.n_GetSize));
			}
			return FloatingActionButton.cb_getSize;
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00006BEC File Offset: 0x00004DEC
		private static int n_GetSize(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<FloatingActionButton>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Size;
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00006BFB File Offset: 0x00004DFB
		private static Delegate GetSetSize_IHandler()
		{
			if (FloatingActionButton.cb_setSize_I == null)
			{
				FloatingActionButton.cb_setSize_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(FloatingActionButton.n_SetSize_I));
			}
			return FloatingActionButton.cb_setSize_I;
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00006C1F File Offset: 0x00004E1F
		private static void n_SetSize_I(IntPtr jnienv, IntPtr native__this, int size)
		{
			Java.Lang.Object.GetObject<FloatingActionButton>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Size = size;
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000246 RID: 582 RVA: 0x00006C2F File Offset: 0x00004E2F
		// (set) Token: 0x06000247 RID: 583 RVA: 0x00006C48 File Offset: 0x00004E48
		public unsafe virtual int Size
		{
			[Register("getSize", "()I", "GetGetSizeHandler")]
			get
			{
				return FloatingActionButton._members.InstanceMethods.InvokeVirtualInt32Method("getSize.()I", this, null);
			}
			[Register("setSize", "(I)V", "GetSetSize_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				FloatingActionButton._members.InstanceMethods.InvokeVirtualVoidMethod("setSize.(I)V", this, ptr);
			}
		}

		// Token: 0x06000248 RID: 584 RVA: 0x00006C83 File Offset: 0x00004E83
		private static Delegate GetGetSupportBackgroundTintListHandler()
		{
			if (FloatingActionButton.cb_getSupportBackgroundTintList == null)
			{
				FloatingActionButton.cb_getSupportBackgroundTintList = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(FloatingActionButton.n_GetSupportBackgroundTintList));
			}
			return FloatingActionButton.cb_getSupportBackgroundTintList;
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00006CA7 File Offset: 0x00004EA7
		private static IntPtr n_GetSupportBackgroundTintList(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<FloatingActionButton>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SupportBackgroundTintList);
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00006CBB File Offset: 0x00004EBB
		private static Delegate GetSetSupportBackgroundTintList_Landroid_content_res_ColorStateList_Handler()
		{
			if (FloatingActionButton.cb_setSupportBackgroundTintList_Landroid_content_res_ColorStateList_ == null)
			{
				FloatingActionButton.cb_setSupportBackgroundTintList_Landroid_content_res_ColorStateList_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(FloatingActionButton.n_SetSupportBackgroundTintList_Landroid_content_res_ColorStateList_));
			}
			return FloatingActionButton.cb_setSupportBackgroundTintList_Landroid_content_res_ColorStateList_;
		}

		// Token: 0x0600024B RID: 587 RVA: 0x00006CE0 File Offset: 0x00004EE0
		private static void n_SetSupportBackgroundTintList_Landroid_content_res_ColorStateList_(IntPtr jnienv, IntPtr native__this, IntPtr native_tint)
		{
			FloatingActionButton @object = Java.Lang.Object.GetObject<FloatingActionButton>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ColorStateList object2 = Java.Lang.Object.GetObject<ColorStateList>(native_tint, JniHandleOwnership.DoNotTransfer);
			@object.SupportBackgroundTintList = object2;
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600024C RID: 588 RVA: 0x00006D04 File Offset: 0x00004F04
		// (set) Token: 0x0600024D RID: 589 RVA: 0x00006D38 File Offset: 0x00004F38
		public unsafe virtual ColorStateList SupportBackgroundTintList
		{
			[Register("getSupportBackgroundTintList", "()Landroid/content/res/ColorStateList;", "GetGetSupportBackgroundTintListHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ColorStateList>(FloatingActionButton._members.InstanceMethods.InvokeVirtualObjectMethod("getSupportBackgroundTintList.()Landroid/content/res/ColorStateList;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setSupportBackgroundTintList", "(Landroid/content/res/ColorStateList;)V", "GetSetSupportBackgroundTintList_Landroid_content_res_ColorStateList_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					FloatingActionButton._members.InstanceMethods.InvokeVirtualVoidMethod("setSupportBackgroundTintList.(Landroid/content/res/ColorStateList;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00006D9C File Offset: 0x00004F9C
		private static Delegate GetGetSupportBackgroundTintModeHandler()
		{
			if (FloatingActionButton.cb_getSupportBackgroundTintMode == null)
			{
				FloatingActionButton.cb_getSupportBackgroundTintMode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(FloatingActionButton.n_GetSupportBackgroundTintMode));
			}
			return FloatingActionButton.cb_getSupportBackgroundTintMode;
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00006DC0 File Offset: 0x00004FC0
		private static IntPtr n_GetSupportBackgroundTintMode(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<FloatingActionButton>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SupportBackgroundTintMode);
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00006DD4 File Offset: 0x00004FD4
		private static Delegate GetSetSupportBackgroundTintMode_Landroid_graphics_PorterDuff_Mode_Handler()
		{
			if (FloatingActionButton.cb_setSupportBackgroundTintMode_Landroid_graphics_PorterDuff_Mode_ == null)
			{
				FloatingActionButton.cb_setSupportBackgroundTintMode_Landroid_graphics_PorterDuff_Mode_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(FloatingActionButton.n_SetSupportBackgroundTintMode_Landroid_graphics_PorterDuff_Mode_));
			}
			return FloatingActionButton.cb_setSupportBackgroundTintMode_Landroid_graphics_PorterDuff_Mode_;
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00006DF8 File Offset: 0x00004FF8
		private static void n_SetSupportBackgroundTintMode_Landroid_graphics_PorterDuff_Mode_(IntPtr jnienv, IntPtr native__this, IntPtr native_tintMode)
		{
			FloatingActionButton @object = Java.Lang.Object.GetObject<FloatingActionButton>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			PorterDuff.Mode object2 = Java.Lang.Object.GetObject<PorterDuff.Mode>(native_tintMode, JniHandleOwnership.DoNotTransfer);
			@object.SupportBackgroundTintMode = object2;
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000252 RID: 594 RVA: 0x00006E1C File Offset: 0x0000501C
		// (set) Token: 0x06000253 RID: 595 RVA: 0x00006E50 File Offset: 0x00005050
		public unsafe virtual PorterDuff.Mode SupportBackgroundTintMode
		{
			[Register("getSupportBackgroundTintMode", "()Landroid/graphics/PorterDuff$Mode;", "GetGetSupportBackgroundTintModeHandler")]
			get
			{
				return Java.Lang.Object.GetObject<PorterDuff.Mode>(FloatingActionButton._members.InstanceMethods.InvokeVirtualObjectMethod("getSupportBackgroundTintMode.()Landroid/graphics/PorterDuff$Mode;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setSupportBackgroundTintMode", "(Landroid/graphics/PorterDuff$Mode;)V", "GetSetSupportBackgroundTintMode_Landroid_graphics_PorterDuff_Mode_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					FloatingActionButton._members.InstanceMethods.InvokeVirtualVoidMethod("setSupportBackgroundTintMode.(Landroid/graphics/PorterDuff$Mode;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00006EB4 File Offset: 0x000050B4
		private static Delegate GetGetSupportImageTintListHandler()
		{
			if (FloatingActionButton.cb_getSupportImageTintList == null)
			{
				FloatingActionButton.cb_getSupportImageTintList = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(FloatingActionButton.n_GetSupportImageTintList));
			}
			return FloatingActionButton.cb_getSupportImageTintList;
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00006ED8 File Offset: 0x000050D8
		private static IntPtr n_GetSupportImageTintList(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<FloatingActionButton>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SupportImageTintList);
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00006EEC File Offset: 0x000050EC
		private static Delegate GetSetSupportImageTintList_Landroid_content_res_ColorStateList_Handler()
		{
			if (FloatingActionButton.cb_setSupportImageTintList_Landroid_content_res_ColorStateList_ == null)
			{
				FloatingActionButton.cb_setSupportImageTintList_Landroid_content_res_ColorStateList_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(FloatingActionButton.n_SetSupportImageTintList_Landroid_content_res_ColorStateList_));
			}
			return FloatingActionButton.cb_setSupportImageTintList_Landroid_content_res_ColorStateList_;
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00006F10 File Offset: 0x00005110
		private static void n_SetSupportImageTintList_Landroid_content_res_ColorStateList_(IntPtr jnienv, IntPtr native__this, IntPtr native_tint)
		{
			FloatingActionButton @object = Java.Lang.Object.GetObject<FloatingActionButton>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ColorStateList object2 = Java.Lang.Object.GetObject<ColorStateList>(native_tint, JniHandleOwnership.DoNotTransfer);
			@object.SupportImageTintList = object2;
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000258 RID: 600 RVA: 0x00006F34 File Offset: 0x00005134
		// (set) Token: 0x06000259 RID: 601 RVA: 0x00006F68 File Offset: 0x00005168
		public unsafe virtual ColorStateList SupportImageTintList
		{
			[Register("getSupportImageTintList", "()Landroid/content/res/ColorStateList;", "GetGetSupportImageTintListHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ColorStateList>(FloatingActionButton._members.InstanceMethods.InvokeVirtualObjectMethod("getSupportImageTintList.()Landroid/content/res/ColorStateList;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setSupportImageTintList", "(Landroid/content/res/ColorStateList;)V", "GetSetSupportImageTintList_Landroid_content_res_ColorStateList_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					FloatingActionButton._members.InstanceMethods.InvokeVirtualVoidMethod("setSupportImageTintList.(Landroid/content/res/ColorStateList;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00006FCC File Offset: 0x000051CC
		private static Delegate GetGetSupportImageTintModeHandler()
		{
			if (FloatingActionButton.cb_getSupportImageTintMode == null)
			{
				FloatingActionButton.cb_getSupportImageTintMode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(FloatingActionButton.n_GetSupportImageTintMode));
			}
			return FloatingActionButton.cb_getSupportImageTintMode;
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00006FF0 File Offset: 0x000051F0
		private static IntPtr n_GetSupportImageTintMode(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<FloatingActionButton>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SupportImageTintMode);
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00007004 File Offset: 0x00005204
		private static Delegate GetSetSupportImageTintMode_Landroid_graphics_PorterDuff_Mode_Handler()
		{
			if (FloatingActionButton.cb_setSupportImageTintMode_Landroid_graphics_PorterDuff_Mode_ == null)
			{
				FloatingActionButton.cb_setSupportImageTintMode_Landroid_graphics_PorterDuff_Mode_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(FloatingActionButton.n_SetSupportImageTintMode_Landroid_graphics_PorterDuff_Mode_));
			}
			return FloatingActionButton.cb_setSupportImageTintMode_Landroid_graphics_PorterDuff_Mode_;
		}

		// Token: 0x0600025D RID: 605 RVA: 0x00007028 File Offset: 0x00005228
		private static void n_SetSupportImageTintMode_Landroid_graphics_PorterDuff_Mode_(IntPtr jnienv, IntPtr native__this, IntPtr native_tintMode)
		{
			FloatingActionButton @object = Java.Lang.Object.GetObject<FloatingActionButton>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			PorterDuff.Mode object2 = Java.Lang.Object.GetObject<PorterDuff.Mode>(native_tintMode, JniHandleOwnership.DoNotTransfer);
			@object.SupportImageTintMode = object2;
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600025E RID: 606 RVA: 0x0000704C File Offset: 0x0000524C
		// (set) Token: 0x0600025F RID: 607 RVA: 0x00007080 File Offset: 0x00005280
		public unsafe virtual PorterDuff.Mode SupportImageTintMode
		{
			[Register("getSupportImageTintMode", "()Landroid/graphics/PorterDuff$Mode;", "GetGetSupportImageTintModeHandler")]
			get
			{
				return Java.Lang.Object.GetObject<PorterDuff.Mode>(FloatingActionButton._members.InstanceMethods.InvokeVirtualObjectMethod("getSupportImageTintMode.()Landroid/graphics/PorterDuff$Mode;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setSupportImageTintMode", "(Landroid/graphics/PorterDuff$Mode;)V", "GetSetSupportImageTintMode_Landroid_graphics_PorterDuff_Mode_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					FloatingActionButton._members.InstanceMethods.InvokeVirtualVoidMethod("setSupportImageTintMode.(Landroid/graphics/PorterDuff$Mode;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x06000260 RID: 608 RVA: 0x000070E4 File Offset: 0x000052E4
		private static Delegate GetGetUseCompatPaddingHandler()
		{
			if (FloatingActionButton.cb_getUseCompatPadding == null)
			{
				FloatingActionButton.cb_getUseCompatPadding = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(FloatingActionButton.n_GetUseCompatPadding));
			}
			return FloatingActionButton.cb_getUseCompatPadding;
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00007108 File Offset: 0x00005308
		private static bool n_GetUseCompatPadding(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<FloatingActionButton>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).UseCompatPadding;
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00007117 File Offset: 0x00005317
		private static Delegate GetSetUseCompatPadding_ZHandler()
		{
			if (FloatingActionButton.cb_setUseCompatPadding_Z == null)
			{
				FloatingActionButton.cb_setUseCompatPadding_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(FloatingActionButton.n_SetUseCompatPadding_Z));
			}
			return FloatingActionButton.cb_setUseCompatPadding_Z;
		}

		// Token: 0x06000263 RID: 611 RVA: 0x0000713B File Offset: 0x0000533B
		private static void n_SetUseCompatPadding_Z(IntPtr jnienv, IntPtr native__this, bool useCompatPadding)
		{
			Java.Lang.Object.GetObject<FloatingActionButton>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).UseCompatPadding = useCompatPadding;
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000264 RID: 612 RVA: 0x0000714B File Offset: 0x0000534B
		// (set) Token: 0x06000265 RID: 613 RVA: 0x00007164 File Offset: 0x00005364
		public unsafe virtual bool UseCompatPadding
		{
			[Register("getUseCompatPadding", "()Z", "GetGetUseCompatPaddingHandler")]
			get
			{
				return FloatingActionButton._members.InstanceMethods.InvokeVirtualBooleanMethod("getUseCompatPadding.()Z", this, null);
			}
			[Register("setUseCompatPadding", "(Z)V", "GetSetUseCompatPadding_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				FloatingActionButton._members.InstanceMethods.InvokeVirtualVoidMethod("setUseCompatPadding.(Z)V", this, ptr);
			}
		}

		// Token: 0x06000266 RID: 614 RVA: 0x0000719F File Offset: 0x0000539F
		private static Delegate GetAddOnHideAnimationListener_Landroid_animation_Animator_AnimatorListener_Handler()
		{
			if (FloatingActionButton.cb_addOnHideAnimationListener_Landroid_animation_Animator_AnimatorListener_ == null)
			{
				FloatingActionButton.cb_addOnHideAnimationListener_Landroid_animation_Animator_AnimatorListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(FloatingActionButton.n_AddOnHideAnimationListener_Landroid_animation_Animator_AnimatorListener_));
			}
			return FloatingActionButton.cb_addOnHideAnimationListener_Landroid_animation_Animator_AnimatorListener_;
		}

		// Token: 0x06000267 RID: 615 RVA: 0x000071C4 File Offset: 0x000053C4
		private static void n_AddOnHideAnimationListener_Landroid_animation_Animator_AnimatorListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			FloatingActionButton @object = Java.Lang.Object.GetObject<FloatingActionButton>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Animator.IAnimatorListener object2 = Java.Lang.Object.GetObject<Animator.IAnimatorListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.AddOnHideAnimationListener(object2);
		}

		// Token: 0x06000268 RID: 616 RVA: 0x000071E8 File Offset: 0x000053E8
		[Register("addOnHideAnimationListener", "(Landroid/animation/Animator$AnimatorListener;)V", "GetAddOnHideAnimationListener_Landroid_animation_Animator_AnimatorListener_Handler")]
		public unsafe virtual void AddOnHideAnimationListener(Animator.IAnimatorListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				FloatingActionButton._members.InstanceMethods.InvokeVirtualVoidMethod("addOnHideAnimationListener.(Landroid/animation/Animator$AnimatorListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00007250 File Offset: 0x00005450
		private static Delegate GetAddOnShowAnimationListener_Landroid_animation_Animator_AnimatorListener_Handler()
		{
			if (FloatingActionButton.cb_addOnShowAnimationListener_Landroid_animation_Animator_AnimatorListener_ == null)
			{
				FloatingActionButton.cb_addOnShowAnimationListener_Landroid_animation_Animator_AnimatorListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(FloatingActionButton.n_AddOnShowAnimationListener_Landroid_animation_Animator_AnimatorListener_));
			}
			return FloatingActionButton.cb_addOnShowAnimationListener_Landroid_animation_Animator_AnimatorListener_;
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00007274 File Offset: 0x00005474
		private static void n_AddOnShowAnimationListener_Landroid_animation_Animator_AnimatorListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			FloatingActionButton @object = Java.Lang.Object.GetObject<FloatingActionButton>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Animator.IAnimatorListener object2 = Java.Lang.Object.GetObject<Animator.IAnimatorListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.AddOnShowAnimationListener(object2);
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00007298 File Offset: 0x00005498
		[Register("addOnShowAnimationListener", "(Landroid/animation/Animator$AnimatorListener;)V", "GetAddOnShowAnimationListener_Landroid_animation_Animator_AnimatorListener_Handler")]
		public unsafe virtual void AddOnShowAnimationListener(Animator.IAnimatorListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				FloatingActionButton._members.InstanceMethods.InvokeVirtualVoidMethod("addOnShowAnimationListener.(Landroid/animation/Animator$AnimatorListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00007300 File Offset: 0x00005500
		private static Delegate GetAddTransformationCallback_Lcom_google_android_material_animation_TransformationCallback_Handler()
		{
			if (FloatingActionButton.cb_addTransformationCallback_Lcom_google_android_material_animation_TransformationCallback_ == null)
			{
				FloatingActionButton.cb_addTransformationCallback_Lcom_google_android_material_animation_TransformationCallback_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(FloatingActionButton.n_AddTransformationCallback_Lcom_google_android_material_animation_TransformationCallback_));
			}
			return FloatingActionButton.cb_addTransformationCallback_Lcom_google_android_material_animation_TransformationCallback_;
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00007324 File Offset: 0x00005524
		private static void n_AddTransformationCallback_Lcom_google_android_material_animation_TransformationCallback_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			FloatingActionButton @object = Java.Lang.Object.GetObject<FloatingActionButton>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ITransformationCallback object2 = Java.Lang.Object.GetObject<ITransformationCallback>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.AddTransformationCallback(object2);
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00007348 File Offset: 0x00005548
		[Register("addTransformationCallback", "(Lcom/google/android/material/animation/TransformationCallback;)V", "GetAddTransformationCallback_Lcom_google_android_material_animation_TransformationCallback_Handler")]
		public unsafe virtual void AddTransformationCallback(ITransformationCallback listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				FloatingActionButton._members.InstanceMethods.InvokeVirtualVoidMethod("addTransformationCallback.(Lcom/google/android/material/animation/TransformationCallback;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x0600026F RID: 623 RVA: 0x000073B0 File Offset: 0x000055B0
		private static Delegate GetClearCustomSizeHandler()
		{
			if (FloatingActionButton.cb_clearCustomSize == null)
			{
				FloatingActionButton.cb_clearCustomSize = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(FloatingActionButton.n_ClearCustomSize));
			}
			return FloatingActionButton.cb_clearCustomSize;
		}

		// Token: 0x06000270 RID: 624 RVA: 0x000073D4 File Offset: 0x000055D4
		private static void n_ClearCustomSize(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<FloatingActionButton>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ClearCustomSize();
		}

		// Token: 0x06000271 RID: 625 RVA: 0x000073E3 File Offset: 0x000055E3
		[Register("clearCustomSize", "()V", "GetClearCustomSizeHandler")]
		public virtual void ClearCustomSize()
		{
			FloatingActionButton._members.InstanceMethods.InvokeVirtualVoidMethod("clearCustomSize.()V", this, null);
		}

		// Token: 0x06000272 RID: 626 RVA: 0x000073FC File Offset: 0x000055FC
		private static Delegate GetGetBehaviorHandler()
		{
			if (FloatingActionButton.cb_getBehavior == null)
			{
				FloatingActionButton.cb_getBehavior = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(FloatingActionButton.n_GetBehavior));
			}
			return FloatingActionButton.cb_getBehavior;
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00007420 File Offset: 0x00005620
		private static IntPtr n_GetBehavior(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<FloatingActionButton>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetBehavior());
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00007434 File Offset: 0x00005634
		[Register("getBehavior", "()Landroidx/coordinatorlayout/widget/CoordinatorLayout$Behavior;", "GetGetBehaviorHandler")]
		public virtual CoordinatorLayout.Behavior GetBehavior()
		{
			return Java.Lang.Object.GetObject<CoordinatorLayout.Behavior>(FloatingActionButton._members.InstanceMethods.InvokeVirtualObjectMethod("getBehavior.()Landroidx/coordinatorlayout/widget/CoordinatorLayout$Behavior;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00007466 File Offset: 0x00005666
		private static Delegate GetGetContentRect_Landroid_graphics_Rect_Handler()
		{
			if (FloatingActionButton.cb_getContentRect_Landroid_graphics_Rect_ == null)
			{
				FloatingActionButton.cb_getContentRect_Landroid_graphics_Rect_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(FloatingActionButton.n_GetContentRect_Landroid_graphics_Rect_));
			}
			return FloatingActionButton.cb_getContentRect_Landroid_graphics_Rect_;
		}

		// Token: 0x06000276 RID: 630 RVA: 0x0000748C File Offset: 0x0000568C
		private static bool n_GetContentRect_Landroid_graphics_Rect_(IntPtr jnienv, IntPtr native__this, IntPtr native_rect)
		{
			FloatingActionButton @object = Java.Lang.Object.GetObject<FloatingActionButton>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Rect object2 = Java.Lang.Object.GetObject<Rect>(native_rect, JniHandleOwnership.DoNotTransfer);
			return @object.GetContentRect(object2);
		}

		// Token: 0x06000277 RID: 631 RVA: 0x000074B0 File Offset: 0x000056B0
		[Register("getContentRect", "(Landroid/graphics/Rect;)Z", "GetGetContentRect_Landroid_graphics_Rect_Handler")]
		public unsafe virtual bool GetContentRect(Rect rect)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((rect == null) ? IntPtr.Zero : rect.Handle);
				result = FloatingActionButton._members.InstanceMethods.InvokeVirtualBooleanMethod("getContentRect.(Landroid/graphics/Rect;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(rect);
			}
			return result;
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00007518 File Offset: 0x00005718
		private static Delegate GetGetMeasuredContentRect_Landroid_graphics_Rect_Handler()
		{
			if (FloatingActionButton.cb_getMeasuredContentRect_Landroid_graphics_Rect_ == null)
			{
				FloatingActionButton.cb_getMeasuredContentRect_Landroid_graphics_Rect_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(FloatingActionButton.n_GetMeasuredContentRect_Landroid_graphics_Rect_));
			}
			return FloatingActionButton.cb_getMeasuredContentRect_Landroid_graphics_Rect_;
		}

		// Token: 0x06000279 RID: 633 RVA: 0x0000753C File Offset: 0x0000573C
		private static void n_GetMeasuredContentRect_Landroid_graphics_Rect_(IntPtr jnienv, IntPtr native__this, IntPtr native_rect)
		{
			FloatingActionButton @object = Java.Lang.Object.GetObject<FloatingActionButton>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Rect object2 = Java.Lang.Object.GetObject<Rect>(native_rect, JniHandleOwnership.DoNotTransfer);
			@object.GetMeasuredContentRect(object2);
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00007560 File Offset: 0x00005760
		[Register("getMeasuredContentRect", "(Landroid/graphics/Rect;)V", "GetGetMeasuredContentRect_Landroid_graphics_Rect_Handler")]
		public unsafe virtual void GetMeasuredContentRect(Rect rect)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((rect == null) ? IntPtr.Zero : rect.Handle);
				FloatingActionButton._members.InstanceMethods.InvokeVirtualVoidMethod("getMeasuredContentRect.(Landroid/graphics/Rect;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(rect);
			}
		}

		// Token: 0x0600027B RID: 635 RVA: 0x000075C4 File Offset: 0x000057C4
		private static Delegate GetHideHandler()
		{
			if (FloatingActionButton.cb_hide == null)
			{
				FloatingActionButton.cb_hide = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(FloatingActionButton.n_Hide));
			}
			return FloatingActionButton.cb_hide;
		}

		// Token: 0x0600027C RID: 636 RVA: 0x000075E8 File Offset: 0x000057E8
		private static void n_Hide(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<FloatingActionButton>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Hide();
		}

		// Token: 0x0600027D RID: 637 RVA: 0x000075F7 File Offset: 0x000057F7
		[Register("hide", "()V", "GetHideHandler")]
		public virtual void Hide()
		{
			FloatingActionButton._members.InstanceMethods.InvokeVirtualVoidMethod("hide.()V", this, null);
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00007610 File Offset: 0x00005810
		private static Delegate GetHide_Lcom_google_android_material_floatingactionbutton_FloatingActionButton_OnVisibilityChangedListener_Handler()
		{
			if (FloatingActionButton.cb_hide_Lcom_google_android_material_floatingactionbutton_FloatingActionButton_OnVisibilityChangedListener_ == null)
			{
				FloatingActionButton.cb_hide_Lcom_google_android_material_floatingactionbutton_FloatingActionButton_OnVisibilityChangedListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(FloatingActionButton.n_Hide_Lcom_google_android_material_floatingactionbutton_FloatingActionButton_OnVisibilityChangedListener_));
			}
			return FloatingActionButton.cb_hide_Lcom_google_android_material_floatingactionbutton_FloatingActionButton_OnVisibilityChangedListener_;
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00007634 File Offset: 0x00005834
		private static void n_Hide_Lcom_google_android_material_floatingactionbutton_FloatingActionButton_OnVisibilityChangedListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			FloatingActionButton @object = Java.Lang.Object.GetObject<FloatingActionButton>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			FloatingActionButton.OnVisibilityChangedListener object2 = Java.Lang.Object.GetObject<FloatingActionButton.OnVisibilityChangedListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.Hide(object2);
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00007658 File Offset: 0x00005858
		[Register("hide", "(Lcom/google/android/material/floatingactionbutton/FloatingActionButton$OnVisibilityChangedListener;)V", "GetHide_Lcom_google_android_material_floatingactionbutton_FloatingActionButton_OnVisibilityChangedListener_Handler")]
		public unsafe virtual void Hide(FloatingActionButton.OnVisibilityChangedListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : listener.Handle);
				FloatingActionButton._members.InstanceMethods.InvokeVirtualVoidMethod("hide.(Lcom/google/android/material/floatingactionbutton/FloatingActionButton$OnVisibilityChangedListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x06000281 RID: 641 RVA: 0x000076BC File Offset: 0x000058BC
		private static Delegate GetRemoveOnHideAnimationListener_Landroid_animation_Animator_AnimatorListener_Handler()
		{
			if (FloatingActionButton.cb_removeOnHideAnimationListener_Landroid_animation_Animator_AnimatorListener_ == null)
			{
				FloatingActionButton.cb_removeOnHideAnimationListener_Landroid_animation_Animator_AnimatorListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(FloatingActionButton.n_RemoveOnHideAnimationListener_Landroid_animation_Animator_AnimatorListener_));
			}
			return FloatingActionButton.cb_removeOnHideAnimationListener_Landroid_animation_Animator_AnimatorListener_;
		}

		// Token: 0x06000282 RID: 642 RVA: 0x000076E0 File Offset: 0x000058E0
		private static void n_RemoveOnHideAnimationListener_Landroid_animation_Animator_AnimatorListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			FloatingActionButton @object = Java.Lang.Object.GetObject<FloatingActionButton>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Animator.IAnimatorListener object2 = Java.Lang.Object.GetObject<Animator.IAnimatorListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.RemoveOnHideAnimationListener(object2);
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00007704 File Offset: 0x00005904
		[Register("removeOnHideAnimationListener", "(Landroid/animation/Animator$AnimatorListener;)V", "GetRemoveOnHideAnimationListener_Landroid_animation_Animator_AnimatorListener_Handler")]
		public unsafe virtual void RemoveOnHideAnimationListener(Animator.IAnimatorListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				FloatingActionButton._members.InstanceMethods.InvokeVirtualVoidMethod("removeOnHideAnimationListener.(Landroid/animation/Animator$AnimatorListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x06000284 RID: 644 RVA: 0x0000776C File Offset: 0x0000596C
		private static Delegate GetRemoveOnShowAnimationListener_Landroid_animation_Animator_AnimatorListener_Handler()
		{
			if (FloatingActionButton.cb_removeOnShowAnimationListener_Landroid_animation_Animator_AnimatorListener_ == null)
			{
				FloatingActionButton.cb_removeOnShowAnimationListener_Landroid_animation_Animator_AnimatorListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(FloatingActionButton.n_RemoveOnShowAnimationListener_Landroid_animation_Animator_AnimatorListener_));
			}
			return FloatingActionButton.cb_removeOnShowAnimationListener_Landroid_animation_Animator_AnimatorListener_;
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00007790 File Offset: 0x00005990
		private static void n_RemoveOnShowAnimationListener_Landroid_animation_Animator_AnimatorListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			FloatingActionButton @object = Java.Lang.Object.GetObject<FloatingActionButton>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Animator.IAnimatorListener object2 = Java.Lang.Object.GetObject<Animator.IAnimatorListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.RemoveOnShowAnimationListener(object2);
		}

		// Token: 0x06000286 RID: 646 RVA: 0x000077B4 File Offset: 0x000059B4
		[Register("removeOnShowAnimationListener", "(Landroid/animation/Animator$AnimatorListener;)V", "GetRemoveOnShowAnimationListener_Landroid_animation_Animator_AnimatorListener_Handler")]
		public unsafe virtual void RemoveOnShowAnimationListener(Animator.IAnimatorListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				FloatingActionButton._members.InstanceMethods.InvokeVirtualVoidMethod("removeOnShowAnimationListener.(Landroid/animation/Animator$AnimatorListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x06000287 RID: 647 RVA: 0x0000781C File Offset: 0x00005A1C
		private static Delegate GetRemoveTransformationCallback_Lcom_google_android_material_animation_TransformationCallback_Handler()
		{
			if (FloatingActionButton.cb_removeTransformationCallback_Lcom_google_android_material_animation_TransformationCallback_ == null)
			{
				FloatingActionButton.cb_removeTransformationCallback_Lcom_google_android_material_animation_TransformationCallback_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(FloatingActionButton.n_RemoveTransformationCallback_Lcom_google_android_material_animation_TransformationCallback_));
			}
			return FloatingActionButton.cb_removeTransformationCallback_Lcom_google_android_material_animation_TransformationCallback_;
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00007840 File Offset: 0x00005A40
		private static void n_RemoveTransformationCallback_Lcom_google_android_material_animation_TransformationCallback_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			FloatingActionButton @object = Java.Lang.Object.GetObject<FloatingActionButton>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ITransformationCallback object2 = Java.Lang.Object.GetObject<ITransformationCallback>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.RemoveTransformationCallback(object2);
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00007864 File Offset: 0x00005A64
		[Register("removeTransformationCallback", "(Lcom/google/android/material/animation/TransformationCallback;)V", "GetRemoveTransformationCallback_Lcom_google_android_material_animation_TransformationCallback_Handler")]
		public unsafe virtual void RemoveTransformationCallback(ITransformationCallback listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				FloatingActionButton._members.InstanceMethods.InvokeVirtualVoidMethod("removeTransformationCallback.(Lcom/google/android/material/animation/TransformationCallback;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x0600028A RID: 650 RVA: 0x000078CC File Offset: 0x00005ACC
		private static Delegate GetSetCompatElevationResource_IHandler()
		{
			if (FloatingActionButton.cb_setCompatElevationResource_I == null)
			{
				FloatingActionButton.cb_setCompatElevationResource_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(FloatingActionButton.n_SetCompatElevationResource_I));
			}
			return FloatingActionButton.cb_setCompatElevationResource_I;
		}

		// Token: 0x0600028B RID: 651 RVA: 0x000078F0 File Offset: 0x00005AF0
		private static void n_SetCompatElevationResource_I(IntPtr jnienv, IntPtr native__this, int id)
		{
			Java.Lang.Object.GetObject<FloatingActionButton>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetCompatElevationResource(id);
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00007900 File Offset: 0x00005B00
		[Register("setCompatElevationResource", "(I)V", "GetSetCompatElevationResource_IHandler")]
		public unsafe virtual void SetCompatElevationResource(int id)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(id);
			FloatingActionButton._members.InstanceMethods.InvokeVirtualVoidMethod("setCompatElevationResource.(I)V", this, ptr);
		}

		// Token: 0x0600028D RID: 653 RVA: 0x0000793B File Offset: 0x00005B3B
		private static Delegate GetSetCompatHoveredFocusedTranslationZResource_IHandler()
		{
			if (FloatingActionButton.cb_setCompatHoveredFocusedTranslationZResource_I == null)
			{
				FloatingActionButton.cb_setCompatHoveredFocusedTranslationZResource_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(FloatingActionButton.n_SetCompatHoveredFocusedTranslationZResource_I));
			}
			return FloatingActionButton.cb_setCompatHoveredFocusedTranslationZResource_I;
		}

		// Token: 0x0600028E RID: 654 RVA: 0x0000795F File Offset: 0x00005B5F
		private static void n_SetCompatHoveredFocusedTranslationZResource_I(IntPtr jnienv, IntPtr native__this, int id)
		{
			Java.Lang.Object.GetObject<FloatingActionButton>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetCompatHoveredFocusedTranslationZResource(id);
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00007970 File Offset: 0x00005B70
		[Register("setCompatHoveredFocusedTranslationZResource", "(I)V", "GetSetCompatHoveredFocusedTranslationZResource_IHandler")]
		public unsafe virtual void SetCompatHoveredFocusedTranslationZResource(int id)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(id);
			FloatingActionButton._members.InstanceMethods.InvokeVirtualVoidMethod("setCompatHoveredFocusedTranslationZResource.(I)V", this, ptr);
		}

		// Token: 0x06000290 RID: 656 RVA: 0x000079AB File Offset: 0x00005BAB
		private static Delegate GetSetCompatPressedTranslationZResource_IHandler()
		{
			if (FloatingActionButton.cb_setCompatPressedTranslationZResource_I == null)
			{
				FloatingActionButton.cb_setCompatPressedTranslationZResource_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(FloatingActionButton.n_SetCompatPressedTranslationZResource_I));
			}
			return FloatingActionButton.cb_setCompatPressedTranslationZResource_I;
		}

		// Token: 0x06000291 RID: 657 RVA: 0x000079CF File Offset: 0x00005BCF
		private static void n_SetCompatPressedTranslationZResource_I(IntPtr jnienv, IntPtr native__this, int id)
		{
			Java.Lang.Object.GetObject<FloatingActionButton>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetCompatPressedTranslationZResource(id);
		}

		// Token: 0x06000292 RID: 658 RVA: 0x000079E0 File Offset: 0x00005BE0
		[Register("setCompatPressedTranslationZResource", "(I)V", "GetSetCompatPressedTranslationZResource_IHandler")]
		public unsafe virtual void SetCompatPressedTranslationZResource(int id)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(id);
			FloatingActionButton._members.InstanceMethods.InvokeVirtualVoidMethod("setCompatPressedTranslationZResource.(I)V", this, ptr);
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00007A1B File Offset: 0x00005C1B
		private static Delegate GetSetEnsureMinTouchTargetSize_ZHandler()
		{
			if (FloatingActionButton.cb_setEnsureMinTouchTargetSize_Z == null)
			{
				FloatingActionButton.cb_setEnsureMinTouchTargetSize_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(FloatingActionButton.n_SetEnsureMinTouchTargetSize_Z));
			}
			return FloatingActionButton.cb_setEnsureMinTouchTargetSize_Z;
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00007A3F File Offset: 0x00005C3F
		private static void n_SetEnsureMinTouchTargetSize_Z(IntPtr jnienv, IntPtr native__this, bool flag)
		{
			Java.Lang.Object.GetObject<FloatingActionButton>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetEnsureMinTouchTargetSize(flag);
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00007A50 File Offset: 0x00005C50
		[Register("setEnsureMinTouchTargetSize", "(Z)V", "GetSetEnsureMinTouchTargetSize_ZHandler")]
		public unsafe virtual void SetEnsureMinTouchTargetSize(bool flag)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(flag);
			FloatingActionButton._members.InstanceMethods.InvokeVirtualVoidMethod("setEnsureMinTouchTargetSize.(Z)V", this, ptr);
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00007A8B File Offset: 0x00005C8B
		private static Delegate GetSetExpanded_ZHandler()
		{
			if (FloatingActionButton.cb_setExpanded_Z == null)
			{
				FloatingActionButton.cb_setExpanded_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_Z(FloatingActionButton.n_SetExpanded_Z));
			}
			return FloatingActionButton.cb_setExpanded_Z;
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00007AAF File Offset: 0x00005CAF
		private static bool n_SetExpanded_Z(IntPtr jnienv, IntPtr native__this, bool expanded)
		{
			return Java.Lang.Object.GetObject<FloatingActionButton>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetExpanded(expanded);
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00007AC0 File Offset: 0x00005CC0
		[Register("setExpanded", "(Z)Z", "GetSetExpanded_ZHandler")]
		public unsafe virtual bool SetExpanded(bool expanded)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(expanded);
			return FloatingActionButton._members.InstanceMethods.InvokeVirtualBooleanMethod("setExpanded.(Z)Z", this, ptr);
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00007AFB File Offset: 0x00005CFB
		private static Delegate GetSetHideMotionSpecResource_IHandler()
		{
			if (FloatingActionButton.cb_setHideMotionSpecResource_I == null)
			{
				FloatingActionButton.cb_setHideMotionSpecResource_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(FloatingActionButton.n_SetHideMotionSpecResource_I));
			}
			return FloatingActionButton.cb_setHideMotionSpecResource_I;
		}

		// Token: 0x0600029A RID: 666 RVA: 0x00007B1F File Offset: 0x00005D1F
		private static void n_SetHideMotionSpecResource_I(IntPtr jnienv, IntPtr native__this, int id)
		{
			Java.Lang.Object.GetObject<FloatingActionButton>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetHideMotionSpecResource(id);
		}

		// Token: 0x0600029B RID: 667 RVA: 0x00007B30 File Offset: 0x00005D30
		[Register("setHideMotionSpecResource", "(I)V", "GetSetHideMotionSpecResource_IHandler")]
		public unsafe virtual void SetHideMotionSpecResource(int id)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(id);
			FloatingActionButton._members.InstanceMethods.InvokeVirtualVoidMethod("setHideMotionSpecResource.(I)V", this, ptr);
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00007B6B File Offset: 0x00005D6B
		private static Delegate GetSetMaxImageSize_IHandler()
		{
			if (FloatingActionButton.cb_setMaxImageSize_I == null)
			{
				FloatingActionButton.cb_setMaxImageSize_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(FloatingActionButton.n_SetMaxImageSize_I));
			}
			return FloatingActionButton.cb_setMaxImageSize_I;
		}

		// Token: 0x0600029D RID: 669 RVA: 0x00007B8F File Offset: 0x00005D8F
		private static void n_SetMaxImageSize_I(IntPtr jnienv, IntPtr native__this, int imageSize)
		{
			Java.Lang.Object.GetObject<FloatingActionButton>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetMaxImageSize(imageSize);
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00007BA0 File Offset: 0x00005DA0
		[Register("setMaxImageSize", "(I)V", "GetSetMaxImageSize_IHandler")]
		public unsafe virtual void SetMaxImageSize(int imageSize)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(imageSize);
			FloatingActionButton._members.InstanceMethods.InvokeVirtualVoidMethod("setMaxImageSize.(I)V", this, ptr);
		}

		// Token: 0x0600029F RID: 671 RVA: 0x00007BDB File Offset: 0x00005DDB
		private static Delegate GetSetRippleColor_Landroid_content_res_ColorStateList_Handler()
		{
			if (FloatingActionButton.cb_setRippleColor_Landroid_content_res_ColorStateList_ == null)
			{
				FloatingActionButton.cb_setRippleColor_Landroid_content_res_ColorStateList_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(FloatingActionButton.n_SetRippleColor_Landroid_content_res_ColorStateList_));
			}
			return FloatingActionButton.cb_setRippleColor_Landroid_content_res_ColorStateList_;
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x00007C00 File Offset: 0x00005E00
		private static void n_SetRippleColor_Landroid_content_res_ColorStateList_(IntPtr jnienv, IntPtr native__this, IntPtr native_color)
		{
			FloatingActionButton @object = Java.Lang.Object.GetObject<FloatingActionButton>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ColorStateList object2 = Java.Lang.Object.GetObject<ColorStateList>(native_color, JniHandleOwnership.DoNotTransfer);
			@object.SetRippleColor(object2);
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00007C24 File Offset: 0x00005E24
		[Register("setRippleColor", "(Landroid/content/res/ColorStateList;)V", "GetSetRippleColor_Landroid_content_res_ColorStateList_Handler")]
		public unsafe virtual void SetRippleColor(ColorStateList color)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((color == null) ? IntPtr.Zero : color.Handle);
				FloatingActionButton._members.InstanceMethods.InvokeVirtualVoidMethod("setRippleColor.(Landroid/content/res/ColorStateList;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(color);
			}
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x00007C88 File Offset: 0x00005E88
		private static Delegate GetSetShadowPaddingEnabled_ZHandler()
		{
			if (FloatingActionButton.cb_setShadowPaddingEnabled_Z == null)
			{
				FloatingActionButton.cb_setShadowPaddingEnabled_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(FloatingActionButton.n_SetShadowPaddingEnabled_Z));
			}
			return FloatingActionButton.cb_setShadowPaddingEnabled_Z;
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00007CAC File Offset: 0x00005EAC
		private static void n_SetShadowPaddingEnabled_Z(IntPtr jnienv, IntPtr native__this, bool shadowPaddingEnabled)
		{
			Java.Lang.Object.GetObject<FloatingActionButton>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetShadowPaddingEnabled(shadowPaddingEnabled);
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00007CBC File Offset: 0x00005EBC
		[Register("setShadowPaddingEnabled", "(Z)V", "GetSetShadowPaddingEnabled_ZHandler")]
		public unsafe virtual void SetShadowPaddingEnabled(bool shadowPaddingEnabled)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(shadowPaddingEnabled);
			FloatingActionButton._members.InstanceMethods.InvokeVirtualVoidMethod("setShadowPaddingEnabled.(Z)V", this, ptr);
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00007CF7 File Offset: 0x00005EF7
		private static Delegate GetSetShowMotionSpecResource_IHandler()
		{
			if (FloatingActionButton.cb_setShowMotionSpecResource_I == null)
			{
				FloatingActionButton.cb_setShowMotionSpecResource_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(FloatingActionButton.n_SetShowMotionSpecResource_I));
			}
			return FloatingActionButton.cb_setShowMotionSpecResource_I;
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00007D1B File Offset: 0x00005F1B
		private static void n_SetShowMotionSpecResource_I(IntPtr jnienv, IntPtr native__this, int id)
		{
			Java.Lang.Object.GetObject<FloatingActionButton>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetShowMotionSpecResource(id);
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00007D2C File Offset: 0x00005F2C
		[Register("setShowMotionSpecResource", "(I)V", "GetSetShowMotionSpecResource_IHandler")]
		public unsafe virtual void SetShowMotionSpecResource(int id)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(id);
			FloatingActionButton._members.InstanceMethods.InvokeVirtualVoidMethod("setShowMotionSpecResource.(I)V", this, ptr);
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00007D67 File Offset: 0x00005F67
		private static Delegate GetShouldEnsureMinTouchTargetSizeHandler()
		{
			if (FloatingActionButton.cb_shouldEnsureMinTouchTargetSize == null)
			{
				FloatingActionButton.cb_shouldEnsureMinTouchTargetSize = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(FloatingActionButton.n_ShouldEnsureMinTouchTargetSize));
			}
			return FloatingActionButton.cb_shouldEnsureMinTouchTargetSize;
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00007D8B File Offset: 0x00005F8B
		private static bool n_ShouldEnsureMinTouchTargetSize(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<FloatingActionButton>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ShouldEnsureMinTouchTargetSize();
		}

		// Token: 0x060002AA RID: 682 RVA: 0x00007D9A File Offset: 0x00005F9A
		[Register("shouldEnsureMinTouchTargetSize", "()Z", "GetShouldEnsureMinTouchTargetSizeHandler")]
		public virtual bool ShouldEnsureMinTouchTargetSize()
		{
			return FloatingActionButton._members.InstanceMethods.InvokeVirtualBooleanMethod("shouldEnsureMinTouchTargetSize.()Z", this, null);
		}

		// Token: 0x060002AB RID: 683 RVA: 0x00007DB3 File Offset: 0x00005FB3
		private static Delegate GetShowHandler()
		{
			if (FloatingActionButton.cb_show == null)
			{
				FloatingActionButton.cb_show = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(FloatingActionButton.n_Show));
			}
			return FloatingActionButton.cb_show;
		}

		// Token: 0x060002AC RID: 684 RVA: 0x00007DD7 File Offset: 0x00005FD7
		private static void n_Show(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<FloatingActionButton>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Show();
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00007DE6 File Offset: 0x00005FE6
		[Register("show", "()V", "GetShowHandler")]
		public virtual void Show()
		{
			FloatingActionButton._members.InstanceMethods.InvokeVirtualVoidMethod("show.()V", this, null);
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00007DFF File Offset: 0x00005FFF
		private static Delegate GetShow_Lcom_google_android_material_floatingactionbutton_FloatingActionButton_OnVisibilityChangedListener_Handler()
		{
			if (FloatingActionButton.cb_show_Lcom_google_android_material_floatingactionbutton_FloatingActionButton_OnVisibilityChangedListener_ == null)
			{
				FloatingActionButton.cb_show_Lcom_google_android_material_floatingactionbutton_FloatingActionButton_OnVisibilityChangedListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(FloatingActionButton.n_Show_Lcom_google_android_material_floatingactionbutton_FloatingActionButton_OnVisibilityChangedListener_));
			}
			return FloatingActionButton.cb_show_Lcom_google_android_material_floatingactionbutton_FloatingActionButton_OnVisibilityChangedListener_;
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00007E24 File Offset: 0x00006024
		private static void n_Show_Lcom_google_android_material_floatingactionbutton_FloatingActionButton_OnVisibilityChangedListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			FloatingActionButton @object = Java.Lang.Object.GetObject<FloatingActionButton>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			FloatingActionButton.OnVisibilityChangedListener object2 = Java.Lang.Object.GetObject<FloatingActionButton.OnVisibilityChangedListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.Show(object2);
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x00007E48 File Offset: 0x00006048
		[Register("show", "(Lcom/google/android/material/floatingactionbutton/FloatingActionButton$OnVisibilityChangedListener;)V", "GetShow_Lcom_google_android_material_floatingactionbutton_FloatingActionButton_OnVisibilityChangedListener_Handler")]
		public unsafe virtual void Show(FloatingActionButton.OnVisibilityChangedListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : listener.Handle);
				FloatingActionButton._members.InstanceMethods.InvokeVirtualVoidMethod("show.(Lcom/google/android/material/floatingactionbutton/FloatingActionButton$OnVisibilityChangedListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x04000044 RID: 68
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/material/floatingactionbutton/FloatingActionButton", typeof(FloatingActionButton));

		// Token: 0x04000045 RID: 69
		private static Delegate cb_getCompatElevation;

		// Token: 0x04000046 RID: 70
		private static Delegate cb_setCompatElevation_F;

		// Token: 0x04000047 RID: 71
		private static Delegate cb_getCompatHoveredFocusedTranslationZ;

		// Token: 0x04000048 RID: 72
		private static Delegate cb_setCompatHoveredFocusedTranslationZ_F;

		// Token: 0x04000049 RID: 73
		private static Delegate cb_getCompatPressedTranslationZ;

		// Token: 0x0400004A RID: 74
		private static Delegate cb_setCompatPressedTranslationZ_F;

		// Token: 0x0400004B RID: 75
		private static Delegate cb_getContentBackground;

		// Token: 0x0400004C RID: 76
		private static Delegate cb_getCustomSize;

		// Token: 0x0400004D RID: 77
		private static Delegate cb_setCustomSize_I;

		// Token: 0x0400004E RID: 78
		private static Delegate cb_getExpandedComponentIdHint;

		// Token: 0x0400004F RID: 79
		private static Delegate cb_setExpandedComponentIdHint_I;

		// Token: 0x04000050 RID: 80
		private static Delegate cb_getHideMotionSpec;

		// Token: 0x04000051 RID: 81
		private static Delegate cb_setHideMotionSpec_Lcom_google_android_material_animation_MotionSpec_;

		// Token: 0x04000052 RID: 82
		private static Delegate cb_isExpanded;

		// Token: 0x04000053 RID: 83
		private static Delegate cb_isOrWillBeHidden;

		// Token: 0x04000054 RID: 84
		private static Delegate cb_isOrWillBeShown;

		// Token: 0x04000055 RID: 85
		private static Delegate cb_getRippleColor;

		// Token: 0x04000056 RID: 86
		private static Delegate cb_setRippleColor_I;

		// Token: 0x04000057 RID: 87
		private static Delegate cb_getRippleColorStateList;

		// Token: 0x04000058 RID: 88
		private static Delegate cb_getShapeAppearanceModel;

		// Token: 0x04000059 RID: 89
		private static Delegate cb_setShapeAppearanceModel_Lcom_google_android_material_shape_ShapeAppearanceModel_;

		// Token: 0x0400005A RID: 90
		private static Delegate cb_getShowMotionSpec;

		// Token: 0x0400005B RID: 91
		private static Delegate cb_setShowMotionSpec_Lcom_google_android_material_animation_MotionSpec_;

		// Token: 0x0400005C RID: 92
		private static Delegate cb_getSize;

		// Token: 0x0400005D RID: 93
		private static Delegate cb_setSize_I;

		// Token: 0x0400005E RID: 94
		private static Delegate cb_getSupportBackgroundTintList;

		// Token: 0x0400005F RID: 95
		private static Delegate cb_setSupportBackgroundTintList_Landroid_content_res_ColorStateList_;

		// Token: 0x04000060 RID: 96
		private static Delegate cb_getSupportBackgroundTintMode;

		// Token: 0x04000061 RID: 97
		private static Delegate cb_setSupportBackgroundTintMode_Landroid_graphics_PorterDuff_Mode_;

		// Token: 0x04000062 RID: 98
		private static Delegate cb_getSupportImageTintList;

		// Token: 0x04000063 RID: 99
		private static Delegate cb_setSupportImageTintList_Landroid_content_res_ColorStateList_;

		// Token: 0x04000064 RID: 100
		private static Delegate cb_getSupportImageTintMode;

		// Token: 0x04000065 RID: 101
		private static Delegate cb_setSupportImageTintMode_Landroid_graphics_PorterDuff_Mode_;

		// Token: 0x04000066 RID: 102
		private static Delegate cb_getUseCompatPadding;

		// Token: 0x04000067 RID: 103
		private static Delegate cb_setUseCompatPadding_Z;

		// Token: 0x04000068 RID: 104
		private static Delegate cb_addOnHideAnimationListener_Landroid_animation_Animator_AnimatorListener_;

		// Token: 0x04000069 RID: 105
		private static Delegate cb_addOnShowAnimationListener_Landroid_animation_Animator_AnimatorListener_;

		// Token: 0x0400006A RID: 106
		private static Delegate cb_addTransformationCallback_Lcom_google_android_material_animation_TransformationCallback_;

		// Token: 0x0400006B RID: 107
		private static Delegate cb_clearCustomSize;

		// Token: 0x0400006C RID: 108
		private static Delegate cb_getBehavior;

		// Token: 0x0400006D RID: 109
		private static Delegate cb_getContentRect_Landroid_graphics_Rect_;

		// Token: 0x0400006E RID: 110
		private static Delegate cb_getMeasuredContentRect_Landroid_graphics_Rect_;

		// Token: 0x0400006F RID: 111
		private static Delegate cb_hide;

		// Token: 0x04000070 RID: 112
		private static Delegate cb_hide_Lcom_google_android_material_floatingactionbutton_FloatingActionButton_OnVisibilityChangedListener_;

		// Token: 0x04000071 RID: 113
		private static Delegate cb_removeOnHideAnimationListener_Landroid_animation_Animator_AnimatorListener_;

		// Token: 0x04000072 RID: 114
		private static Delegate cb_removeOnShowAnimationListener_Landroid_animation_Animator_AnimatorListener_;

		// Token: 0x04000073 RID: 115
		private static Delegate cb_removeTransformationCallback_Lcom_google_android_material_animation_TransformationCallback_;

		// Token: 0x04000074 RID: 116
		private static Delegate cb_setCompatElevationResource_I;

		// Token: 0x04000075 RID: 117
		private static Delegate cb_setCompatHoveredFocusedTranslationZResource_I;

		// Token: 0x04000076 RID: 118
		private static Delegate cb_setCompatPressedTranslationZResource_I;

		// Token: 0x04000077 RID: 119
		private static Delegate cb_setEnsureMinTouchTargetSize_Z;

		// Token: 0x04000078 RID: 120
		private static Delegate cb_setExpanded_Z;

		// Token: 0x04000079 RID: 121
		private static Delegate cb_setHideMotionSpecResource_I;

		// Token: 0x0400007A RID: 122
		private static Delegate cb_setMaxImageSize_I;

		// Token: 0x0400007B RID: 123
		private static Delegate cb_setRippleColor_Landroid_content_res_ColorStateList_;

		// Token: 0x0400007C RID: 124
		private static Delegate cb_setShadowPaddingEnabled_Z;

		// Token: 0x0400007D RID: 125
		private static Delegate cb_setShowMotionSpecResource_I;

		// Token: 0x0400007E RID: 126
		private static Delegate cb_shouldEnsureMinTouchTargetSize;

		// Token: 0x0400007F RID: 127
		private static Delegate cb_show;

		// Token: 0x04000080 RID: 128
		private static Delegate cb_show_Lcom_google_android_material_floatingactionbutton_FloatingActionButton_OnVisibilityChangedListener_;

		// Token: 0x02000045 RID: 69
		[Register("com/google/android/material/floatingactionbutton/FloatingActionButton$OnVisibilityChangedListener", DoNotGenerateAcw = true)]
		public abstract class OnVisibilityChangedListener : Java.Lang.Object
		{
			// Token: 0x17000067 RID: 103
			// (get) Token: 0x060002B2 RID: 690 RVA: 0x00007EC8 File Offset: 0x000060C8
			internal static IntPtr class_ref
			{
				get
				{
					return FloatingActionButton.OnVisibilityChangedListener._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000068 RID: 104
			// (get) Token: 0x060002B3 RID: 691 RVA: 0x00007EEC File Offset: 0x000060EC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return FloatingActionButton.OnVisibilityChangedListener._members;
				}
			}

			// Token: 0x17000069 RID: 105
			// (get) Token: 0x060002B4 RID: 692 RVA: 0x00007EF4 File Offset: 0x000060F4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return FloatingActionButton.OnVisibilityChangedListener._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700006A RID: 106
			// (get) Token: 0x060002B5 RID: 693 RVA: 0x00007F18 File Offset: 0x00006118
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return FloatingActionButton.OnVisibilityChangedListener._members.ManagedPeerType;
				}
			}

			// Token: 0x060002B6 RID: 694 RVA: 0x000020DC File Offset: 0x000002DC
			protected OnVisibilityChangedListener(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x060002B7 RID: 695 RVA: 0x00007F24 File Offset: 0x00006124
			[Register(".ctor", "()V", "")]
			public OnVisibilityChangedListener() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(FloatingActionButton.OnVisibilityChangedListener._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				FloatingActionButton.OnVisibilityChangedListener._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x060002B8 RID: 696 RVA: 0x00007F92 File Offset: 0x00006192
			private static Delegate GetOnHidden_Lcom_google_android_material_floatingactionbutton_FloatingActionButton_Handler()
			{
				if (FloatingActionButton.OnVisibilityChangedListener.cb_onHidden_Lcom_google_android_material_floatingactionbutton_FloatingActionButton_ == null)
				{
					FloatingActionButton.OnVisibilityChangedListener.cb_onHidden_Lcom_google_android_material_floatingactionbutton_FloatingActionButton_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(FloatingActionButton.OnVisibilityChangedListener.n_OnHidden_Lcom_google_android_material_floatingactionbutton_FloatingActionButton_));
				}
				return FloatingActionButton.OnVisibilityChangedListener.cb_onHidden_Lcom_google_android_material_floatingactionbutton_FloatingActionButton_;
			}

			// Token: 0x060002B9 RID: 697 RVA: 0x00007FB8 File Offset: 0x000061B8
			private static void n_OnHidden_Lcom_google_android_material_floatingactionbutton_FloatingActionButton_(IntPtr jnienv, IntPtr native__this, IntPtr native_fab)
			{
				FloatingActionButton.OnVisibilityChangedListener @object = Java.Lang.Object.GetObject<FloatingActionButton.OnVisibilityChangedListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				FloatingActionButton object2 = Java.Lang.Object.GetObject<FloatingActionButton>(native_fab, JniHandleOwnership.DoNotTransfer);
				@object.OnHidden(object2);
			}

			// Token: 0x060002BA RID: 698 RVA: 0x00007FDC File Offset: 0x000061DC
			[Register("onHidden", "(Lcom/google/android/material/floatingactionbutton/FloatingActionButton;)V", "GetOnHidden_Lcom_google_android_material_floatingactionbutton_FloatingActionButton_Handler")]
			public unsafe virtual void OnHidden(FloatingActionButton fab)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((fab == null) ? IntPtr.Zero : fab.Handle);
					FloatingActionButton.OnVisibilityChangedListener._members.InstanceMethods.InvokeVirtualVoidMethod("onHidden.(Lcom/google/android/material/floatingactionbutton/FloatingActionButton;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(fab);
				}
			}

			// Token: 0x060002BB RID: 699 RVA: 0x00008040 File Offset: 0x00006240
			private static Delegate GetOnShown_Lcom_google_android_material_floatingactionbutton_FloatingActionButton_Handler()
			{
				if (FloatingActionButton.OnVisibilityChangedListener.cb_onShown_Lcom_google_android_material_floatingactionbutton_FloatingActionButton_ == null)
				{
					FloatingActionButton.OnVisibilityChangedListener.cb_onShown_Lcom_google_android_material_floatingactionbutton_FloatingActionButton_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(FloatingActionButton.OnVisibilityChangedListener.n_OnShown_Lcom_google_android_material_floatingactionbutton_FloatingActionButton_));
				}
				return FloatingActionButton.OnVisibilityChangedListener.cb_onShown_Lcom_google_android_material_floatingactionbutton_FloatingActionButton_;
			}

			// Token: 0x060002BC RID: 700 RVA: 0x00008064 File Offset: 0x00006264
			private static void n_OnShown_Lcom_google_android_material_floatingactionbutton_FloatingActionButton_(IntPtr jnienv, IntPtr native__this, IntPtr native_fab)
			{
				FloatingActionButton.OnVisibilityChangedListener @object = Java.Lang.Object.GetObject<FloatingActionButton.OnVisibilityChangedListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				FloatingActionButton object2 = Java.Lang.Object.GetObject<FloatingActionButton>(native_fab, JniHandleOwnership.DoNotTransfer);
				@object.OnShown(object2);
			}

			// Token: 0x060002BD RID: 701 RVA: 0x00008088 File Offset: 0x00006288
			[Register("onShown", "(Lcom/google/android/material/floatingactionbutton/FloatingActionButton;)V", "GetOnShown_Lcom_google_android_material_floatingactionbutton_FloatingActionButton_Handler")]
			public unsafe virtual void OnShown(FloatingActionButton fab)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((fab == null) ? IntPtr.Zero : fab.Handle);
					FloatingActionButton.OnVisibilityChangedListener._members.InstanceMethods.InvokeVirtualVoidMethod("onShown.(Lcom/google/android/material/floatingactionbutton/FloatingActionButton;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(fab);
				}
			}

			// Token: 0x04000081 RID: 129
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/material/floatingactionbutton/FloatingActionButton$OnVisibilityChangedListener", typeof(FloatingActionButton.OnVisibilityChangedListener));

			// Token: 0x04000082 RID: 130
			private static Delegate cb_onHidden_Lcom_google_android_material_floatingactionbutton_FloatingActionButton_;

			// Token: 0x04000083 RID: 131
			private static Delegate cb_onShown_Lcom_google_android_material_floatingactionbutton_FloatingActionButton_;
		}

		// Token: 0x02000046 RID: 70
		[Register("com/google/android/material/floatingactionbutton/FloatingActionButton$OnVisibilityChangedListener", DoNotGenerateAcw = true)]
		internal class OnVisibilityChangedListenerInvoker : FloatingActionButton.OnVisibilityChangedListener
		{
			// Token: 0x060002BF RID: 703 RVA: 0x00008107 File Offset: 0x00006307
			public OnVisibilityChangedListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
			{
			}

			// Token: 0x1700006B RID: 107
			// (get) Token: 0x060002C0 RID: 704 RVA: 0x00008111 File Offset: 0x00006311
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return FloatingActionButton.OnVisibilityChangedListenerInvoker._members;
				}
			}

			// Token: 0x1700006C RID: 108
			// (get) Token: 0x060002C1 RID: 705 RVA: 0x00008118 File Offset: 0x00006318
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return FloatingActionButton.OnVisibilityChangedListenerInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x04000084 RID: 132
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/material/floatingactionbutton/FloatingActionButton$OnVisibilityChangedListener", typeof(FloatingActionButton.OnVisibilityChangedListenerInvoker));
		}
	}
}
