using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Content.Res;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Runtime;
using Android.Views;
using AndroidX.Core.View;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Core.Internal.View
{
	// Token: 0x02000054 RID: 84
	[Register("androidx/core/internal/view/SupportMenuItem", DoNotGenerateAcw = true)]
	internal class ISupportMenuItemInvoker : Java.Lang.Object, ISupportMenuItem, IMenuItem, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060001CB RID: 459 RVA: 0x000040E4 File Offset: 0x000022E4
		private static IntPtr java_class_ref
		{
			get
			{
				return ISupportMenuItemInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060001CC RID: 460 RVA: 0x00004108 File Offset: 0x00002308
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ISupportMenuItemInvoker._members;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060001CD RID: 461 RVA: 0x0000410F File Offset: 0x0000230F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060001CE RID: 462 RVA: 0x00004117 File Offset: 0x00002317
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ISupportMenuItemInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00004123 File Offset: 0x00002323
		public static ISupportMenuItem GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ISupportMenuItem>(handle, transfer);
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x0000412C File Offset: 0x0000232C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ISupportMenuItemInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.core.internal.view.SupportMenuItem'.");
			}
			return handle;
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00004157 File Offset: 0x00002357
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00004188 File Offset: 0x00002388
		public ISupportMenuItemInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ISupportMenuItemInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x000041C0 File Offset: 0x000023C0
		private static Delegate GetGetActionViewHandler()
		{
			if (ISupportMenuItemInvoker.cb_getActionView == null)
			{
				ISupportMenuItemInvoker.cb_getActionView = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISupportMenuItemInvoker.n_GetActionView));
			}
			return ISupportMenuItemInvoker.cb_getActionView;
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x000041E4 File Offset: 0x000023E4
		private static IntPtr n_GetActionView(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISupportMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ActionView);
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x000041F8 File Offset: 0x000023F8
		public View ActionView
		{
			get
			{
				if (this.id_getActionView == IntPtr.Zero)
				{
					this.id_getActionView = JNIEnv.GetMethodID(this.class_ref, "getActionView", "()Landroid/view/View;");
				}
				return Java.Lang.Object.GetObject<View>(JNIEnv.CallObjectMethod(base.Handle, this.id_getActionView), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00004249 File Offset: 0x00002449
		private static Delegate GetGetAlphabeticModifiersHandler()
		{
			if (ISupportMenuItemInvoker.cb_getAlphabeticModifiers == null)
			{
				ISupportMenuItemInvoker.cb_getAlphabeticModifiers = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ISupportMenuItemInvoker.n_GetAlphabeticModifiers));
			}
			return ISupportMenuItemInvoker.cb_getAlphabeticModifiers;
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x0000426D File Offset: 0x0000246D
		private static int n_GetAlphabeticModifiers(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ISupportMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AlphabeticModifiers;
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x0000427C File Offset: 0x0000247C
		public int AlphabeticModifiers
		{
			get
			{
				if (this.id_getAlphabeticModifiers == IntPtr.Zero)
				{
					this.id_getAlphabeticModifiers = JNIEnv.GetMethodID(this.class_ref, "getAlphabeticModifiers", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_getAlphabeticModifiers);
			}
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x000042BC File Offset: 0x000024BC
		private static Delegate GetGetContentDescriptionHandler()
		{
			if (ISupportMenuItemInvoker.cb_getContentDescription == null)
			{
				ISupportMenuItemInvoker.cb_getContentDescription = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISupportMenuItemInvoker.n_GetContentDescription));
			}
			return ISupportMenuItemInvoker.cb_getContentDescription;
		}

		// Token: 0x060001DA RID: 474 RVA: 0x000042E0 File Offset: 0x000024E0
		private static IntPtr n_GetContentDescription(IntPtr jnienv, IntPtr native__this)
		{
			return CharSequence.ToLocalJniHandle(Java.Lang.Object.GetObject<ISupportMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ContentDescriptionFormatted);
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060001DB RID: 475 RVA: 0x000042F4 File Offset: 0x000024F4
		public ICharSequence ContentDescriptionFormatted
		{
			get
			{
				if (this.id_getContentDescription == IntPtr.Zero)
				{
					this.id_getContentDescription = JNIEnv.GetMethodID(this.class_ref, "getContentDescription", "()Ljava/lang/CharSequence;");
				}
				return Java.Lang.Object.GetObject<ICharSequence>(JNIEnv.CallObjectMethod(base.Handle, this.id_getContentDescription), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00004345 File Offset: 0x00002545
		private static Delegate GetGetIconTintListHandler()
		{
			if (ISupportMenuItemInvoker.cb_getIconTintList == null)
			{
				ISupportMenuItemInvoker.cb_getIconTintList = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISupportMenuItemInvoker.n_GetIconTintList));
			}
			return ISupportMenuItemInvoker.cb_getIconTintList;
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00004369 File Offset: 0x00002569
		private static IntPtr n_GetIconTintList(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISupportMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IconTintList);
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060001DE RID: 478 RVA: 0x00004380 File Offset: 0x00002580
		public ColorStateList IconTintList
		{
			get
			{
				if (this.id_getIconTintList == IntPtr.Zero)
				{
					this.id_getIconTintList = JNIEnv.GetMethodID(this.class_ref, "getIconTintList", "()Landroid/content/res/ColorStateList;");
				}
				return Java.Lang.Object.GetObject<ColorStateList>(JNIEnv.CallObjectMethod(base.Handle, this.id_getIconTintList), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060001DF RID: 479 RVA: 0x000043D1 File Offset: 0x000025D1
		private static Delegate GetGetIconTintModeHandler()
		{
			if (ISupportMenuItemInvoker.cb_getIconTintMode == null)
			{
				ISupportMenuItemInvoker.cb_getIconTintMode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISupportMenuItemInvoker.n_GetIconTintMode));
			}
			return ISupportMenuItemInvoker.cb_getIconTintMode;
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x000043F5 File Offset: 0x000025F5
		private static IntPtr n_GetIconTintMode(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISupportMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IconTintMode);
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060001E1 RID: 481 RVA: 0x0000440C File Offset: 0x0000260C
		public PorterDuff.Mode IconTintMode
		{
			get
			{
				if (this.id_getIconTintMode == IntPtr.Zero)
				{
					this.id_getIconTintMode = JNIEnv.GetMethodID(this.class_ref, "getIconTintMode", "()Landroid/graphics/PorterDuff$Mode;");
				}
				return Java.Lang.Object.GetObject<PorterDuff.Mode>(JNIEnv.CallObjectMethod(base.Handle, this.id_getIconTintMode), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x0000445D File Offset: 0x0000265D
		private static Delegate GetIsActionViewExpandedHandler()
		{
			if (ISupportMenuItemInvoker.cb_isActionViewExpanded == null)
			{
				ISupportMenuItemInvoker.cb_isActionViewExpanded = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ISupportMenuItemInvoker.n_IsActionViewExpanded));
			}
			return ISupportMenuItemInvoker.cb_isActionViewExpanded;
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00004481 File Offset: 0x00002681
		private static bool n_IsActionViewExpanded(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ISupportMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsActionViewExpanded;
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x00004490 File Offset: 0x00002690
		public bool IsActionViewExpanded
		{
			get
			{
				if (this.id_isActionViewExpanded == IntPtr.Zero)
				{
					this.id_isActionViewExpanded = JNIEnv.GetMethodID(this.class_ref, "isActionViewExpanded", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isActionViewExpanded);
			}
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x000044D0 File Offset: 0x000026D0
		private static Delegate GetGetNumericModifiersHandler()
		{
			if (ISupportMenuItemInvoker.cb_getNumericModifiers == null)
			{
				ISupportMenuItemInvoker.cb_getNumericModifiers = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ISupportMenuItemInvoker.n_GetNumericModifiers));
			}
			return ISupportMenuItemInvoker.cb_getNumericModifiers;
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x000044F4 File Offset: 0x000026F4
		private static int n_GetNumericModifiers(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ISupportMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NumericModifiers;
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060001E7 RID: 487 RVA: 0x00004503 File Offset: 0x00002703
		public int NumericModifiers
		{
			get
			{
				if (this.id_getNumericModifiers == IntPtr.Zero)
				{
					this.id_getNumericModifiers = JNIEnv.GetMethodID(this.class_ref, "getNumericModifiers", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_getNumericModifiers);
			}
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00004543 File Offset: 0x00002743
		private static Delegate GetGetSupportActionProviderHandler()
		{
			if (ISupportMenuItemInvoker.cb_getSupportActionProvider == null)
			{
				ISupportMenuItemInvoker.cb_getSupportActionProvider = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISupportMenuItemInvoker.n_GetSupportActionProvider));
			}
			return ISupportMenuItemInvoker.cb_getSupportActionProvider;
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00004567 File Offset: 0x00002767
		private static IntPtr n_GetSupportActionProvider(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISupportMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SupportActionProvider);
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060001EA RID: 490 RVA: 0x0000457C File Offset: 0x0000277C
		public AndroidX.Core.View.ActionProvider SupportActionProvider
		{
			get
			{
				if (this.id_getSupportActionProvider == IntPtr.Zero)
				{
					this.id_getSupportActionProvider = JNIEnv.GetMethodID(this.class_ref, "getSupportActionProvider", "()Landroidx/core/view/ActionProvider;");
				}
				return Java.Lang.Object.GetObject<AndroidX.Core.View.ActionProvider>(JNIEnv.CallObjectMethod(base.Handle, this.id_getSupportActionProvider), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060001EB RID: 491 RVA: 0x000045CD File Offset: 0x000027CD
		private static Delegate GetGetTooltipTextHandler()
		{
			if (ISupportMenuItemInvoker.cb_getTooltipText == null)
			{
				ISupportMenuItemInvoker.cb_getTooltipText = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISupportMenuItemInvoker.n_GetTooltipText));
			}
			return ISupportMenuItemInvoker.cb_getTooltipText;
		}

		// Token: 0x060001EC RID: 492 RVA: 0x000045F1 File Offset: 0x000027F1
		private static IntPtr n_GetTooltipText(IntPtr jnienv, IntPtr native__this)
		{
			return CharSequence.ToLocalJniHandle(Java.Lang.Object.GetObject<ISupportMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TooltipTextFormatted);
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060001ED RID: 493 RVA: 0x00004608 File Offset: 0x00002808
		public ICharSequence TooltipTextFormatted
		{
			get
			{
				if (this.id_getTooltipText == IntPtr.Zero)
				{
					this.id_getTooltipText = JNIEnv.GetMethodID(this.class_ref, "getTooltipText", "()Ljava/lang/CharSequence;");
				}
				return Java.Lang.Object.GetObject<ICharSequence>(JNIEnv.CallObjectMethod(base.Handle, this.id_getTooltipText), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00004659 File Offset: 0x00002859
		private static Delegate GetCollapseActionViewHandler()
		{
			if (ISupportMenuItemInvoker.cb_collapseActionView == null)
			{
				ISupportMenuItemInvoker.cb_collapseActionView = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ISupportMenuItemInvoker.n_CollapseActionView));
			}
			return ISupportMenuItemInvoker.cb_collapseActionView;
		}

		// Token: 0x060001EF RID: 495 RVA: 0x0000467D File Offset: 0x0000287D
		private static bool n_CollapseActionView(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ISupportMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CollapseActionView();
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x0000468C File Offset: 0x0000288C
		public bool CollapseActionView()
		{
			if (this.id_collapseActionView == IntPtr.Zero)
			{
				this.id_collapseActionView = JNIEnv.GetMethodID(this.class_ref, "collapseActionView", "()Z");
			}
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_collapseActionView);
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x000046CC File Offset: 0x000028CC
		private static Delegate GetExpandActionViewHandler()
		{
			if (ISupportMenuItemInvoker.cb_expandActionView == null)
			{
				ISupportMenuItemInvoker.cb_expandActionView = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ISupportMenuItemInvoker.n_ExpandActionView));
			}
			return ISupportMenuItemInvoker.cb_expandActionView;
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x000046F0 File Offset: 0x000028F0
		private static bool n_ExpandActionView(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ISupportMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ExpandActionView();
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x000046FF File Offset: 0x000028FF
		public bool ExpandActionView()
		{
			if (this.id_expandActionView == IntPtr.Zero)
			{
				this.id_expandActionView = JNIEnv.GetMethodID(this.class_ref, "expandActionView", "()Z");
			}
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_expandActionView);
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x0000473F File Offset: 0x0000293F
		private static Delegate GetRequiresActionButtonHandler()
		{
			if (ISupportMenuItemInvoker.cb_requiresActionButton == null)
			{
				ISupportMenuItemInvoker.cb_requiresActionButton = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ISupportMenuItemInvoker.n_RequiresActionButton));
			}
			return ISupportMenuItemInvoker.cb_requiresActionButton;
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00004763 File Offset: 0x00002963
		private static bool n_RequiresActionButton(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ISupportMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RequiresActionButton();
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00004772 File Offset: 0x00002972
		public bool RequiresActionButton()
		{
			if (this.id_requiresActionButton == IntPtr.Zero)
			{
				this.id_requiresActionButton = JNIEnv.GetMethodID(this.class_ref, "requiresActionButton", "()Z");
			}
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_requiresActionButton);
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x000047B2 File Offset: 0x000029B2
		private static Delegate GetRequiresOverflowHandler()
		{
			if (ISupportMenuItemInvoker.cb_requiresOverflow == null)
			{
				ISupportMenuItemInvoker.cb_requiresOverflow = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ISupportMenuItemInvoker.n_RequiresOverflow));
			}
			return ISupportMenuItemInvoker.cb_requiresOverflow;
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x000047D6 File Offset: 0x000029D6
		private static bool n_RequiresOverflow(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ISupportMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RequiresOverflow();
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x000047E5 File Offset: 0x000029E5
		public bool RequiresOverflow()
		{
			if (this.id_requiresOverflow == IntPtr.Zero)
			{
				this.id_requiresOverflow = JNIEnv.GetMethodID(this.class_ref, "requiresOverflow", "()Z");
			}
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_requiresOverflow);
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00004825 File Offset: 0x00002A25
		private static Delegate GetSetActionView_Landroid_view_View_Handler()
		{
			if (ISupportMenuItemInvoker.cb_setActionView_Landroid_view_View_ == null)
			{
				ISupportMenuItemInvoker.cb_setActionView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ISupportMenuItemInvoker.n_SetActionView_Landroid_view_View_));
			}
			return ISupportMenuItemInvoker.cb_setActionView_Landroid_view_View_;
		}

		// Token: 0x060001FB RID: 507 RVA: 0x0000484C File Offset: 0x00002A4C
		private static IntPtr n_SetActionView_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_view)
		{
			ISupportMenuItem @object = Java.Lang.Object.GetObject<ISupportMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_view, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetActionView(object2));
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00004874 File Offset: 0x00002A74
		public unsafe IMenuItem SetActionView(View view)
		{
			if (this.id_setActionView_Landroid_view_View_ == IntPtr.Zero)
			{
				this.id_setActionView_Landroid_view_View_ = JNIEnv.GetMethodID(this.class_ref, "setActionView", "(Landroid/view/View;)Landroid/view/MenuItem;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((view == null) ? IntPtr.Zero : view.Handle);
			return Java.Lang.Object.GetObject<IMenuItem>(JNIEnv.CallObjectMethod(base.Handle, this.id_setActionView_Landroid_view_View_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060001FD RID: 509 RVA: 0x000048ED File Offset: 0x00002AED
		private static Delegate GetSetActionView_IHandler()
		{
			if (ISupportMenuItemInvoker.cb_setActionView_I == null)
			{
				ISupportMenuItemInvoker.cb_setActionView_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(ISupportMenuItemInvoker.n_SetActionView_I));
			}
			return ISupportMenuItemInvoker.cb_setActionView_I;
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00004911 File Offset: 0x00002B11
		private static IntPtr n_SetActionView_I(IntPtr jnienv, IntPtr native__this, int resId)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISupportMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetActionView(resId));
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00004928 File Offset: 0x00002B28
		public unsafe IMenuItem SetActionView(int resId)
		{
			if (this.id_setActionView_I == IntPtr.Zero)
			{
				this.id_setActionView_I = JNIEnv.GetMethodID(this.class_ref, "setActionView", "(I)Landroid/view/MenuItem;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(resId);
			return Java.Lang.Object.GetObject<IMenuItem>(JNIEnv.CallObjectMethod(base.Handle, this.id_setActionView_I, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00004992 File Offset: 0x00002B92
		private static Delegate GetSetAlphabeticShortcut_CIHandler()
		{
			if (ISupportMenuItemInvoker.cb_setAlphabeticShortcut_CI == null)
			{
				ISupportMenuItemInvoker.cb_setAlphabeticShortcut_CI = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPCI_L(ISupportMenuItemInvoker.n_SetAlphabeticShortcut_CI));
			}
			return ISupportMenuItemInvoker.cb_setAlphabeticShortcut_CI;
		}

		// Token: 0x06000201 RID: 513 RVA: 0x000049B6 File Offset: 0x00002BB6
		private static IntPtr n_SetAlphabeticShortcut_CI(IntPtr jnienv, IntPtr native__this, char alphaChar, int alphaModifiers)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISupportMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetAlphabeticShortcut(alphaChar, alphaModifiers));
		}

		// Token: 0x06000202 RID: 514 RVA: 0x000049CC File Offset: 0x00002BCC
		public unsafe IMenuItem SetAlphabeticShortcut(char alphaChar, int alphaModifiers)
		{
			if (this.id_setAlphabeticShortcut_CI == IntPtr.Zero)
			{
				this.id_setAlphabeticShortcut_CI = JNIEnv.GetMethodID(this.class_ref, "setAlphabeticShortcut", "(CI)Landroid/view/MenuItem;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(alphaChar);
			ptr[1] = new JValue(alphaModifiers);
			return Java.Lang.Object.GetObject<IMenuItem>(JNIEnv.CallObjectMethod(base.Handle, this.id_setAlphabeticShortcut_CI, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00004A49 File Offset: 0x00002C49
		private static Delegate GetSetContentDescription_Ljava_lang_CharSequence_Handler()
		{
			if (ISupportMenuItemInvoker.cb_setContentDescription_Ljava_lang_CharSequence_ == null)
			{
				ISupportMenuItemInvoker.cb_setContentDescription_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ISupportMenuItemInvoker.n_SetContentDescription_Ljava_lang_CharSequence_));
			}
			return ISupportMenuItemInvoker.cb_setContentDescription_Ljava_lang_CharSequence_;
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00004A70 File Offset: 0x00002C70
		private static IntPtr n_SetContentDescription_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_contentDescription)
		{
			ISupportMenuItem @object = Java.Lang.Object.GetObject<ISupportMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_contentDescription, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetContentDescription(object2));
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00004A98 File Offset: 0x00002C98
		public unsafe ISupportMenuItem SetContentDescription(ICharSequence contentDescription)
		{
			if (this.id_setContentDescription_Ljava_lang_CharSequence_ == IntPtr.Zero)
			{
				this.id_setContentDescription_Ljava_lang_CharSequence_ = JNIEnv.GetMethodID(this.class_ref, "setContentDescription", "(Ljava/lang/CharSequence;)Landroidx/core/internal/view/SupportMenuItem;");
			}
			IntPtr intPtr = CharSequence.ToLocalJniHandle(contentDescription);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ISupportMenuItem @object = Java.Lang.Object.GetObject<ISupportMenuItem>(JNIEnv.CallObjectMethod(base.Handle, this.id_setContentDescription_Ljava_lang_CharSequence_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00004B0F File Offset: 0x00002D0F
		private static Delegate GetSetIconTintList_Landroid_content_res_ColorStateList_Handler()
		{
			if (ISupportMenuItemInvoker.cb_setIconTintList_Landroid_content_res_ColorStateList_ == null)
			{
				ISupportMenuItemInvoker.cb_setIconTintList_Landroid_content_res_ColorStateList_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ISupportMenuItemInvoker.n_SetIconTintList_Landroid_content_res_ColorStateList_));
			}
			return ISupportMenuItemInvoker.cb_setIconTintList_Landroid_content_res_ColorStateList_;
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00004B34 File Offset: 0x00002D34
		private static IntPtr n_SetIconTintList_Landroid_content_res_ColorStateList_(IntPtr jnienv, IntPtr native__this, IntPtr native_tint)
		{
			ISupportMenuItem @object = Java.Lang.Object.GetObject<ISupportMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ColorStateList object2 = Java.Lang.Object.GetObject<ColorStateList>(native_tint, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetIconTintList(object2));
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00004B5C File Offset: 0x00002D5C
		public unsafe IMenuItem SetIconTintList(ColorStateList tint)
		{
			if (this.id_setIconTintList_Landroid_content_res_ColorStateList_ == IntPtr.Zero)
			{
				this.id_setIconTintList_Landroid_content_res_ColorStateList_ = JNIEnv.GetMethodID(this.class_ref, "setIconTintList", "(Landroid/content/res/ColorStateList;)Landroid/view/MenuItem;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((tint == null) ? IntPtr.Zero : tint.Handle);
			return Java.Lang.Object.GetObject<IMenuItem>(JNIEnv.CallObjectMethod(base.Handle, this.id_setIconTintList_Landroid_content_res_ColorStateList_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00004BD5 File Offset: 0x00002DD5
		private static Delegate GetSetIconTintMode_Landroid_graphics_PorterDuff_Mode_Handler()
		{
			if (ISupportMenuItemInvoker.cb_setIconTintMode_Landroid_graphics_PorterDuff_Mode_ == null)
			{
				ISupportMenuItemInvoker.cb_setIconTintMode_Landroid_graphics_PorterDuff_Mode_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ISupportMenuItemInvoker.n_SetIconTintMode_Landroid_graphics_PorterDuff_Mode_));
			}
			return ISupportMenuItemInvoker.cb_setIconTintMode_Landroid_graphics_PorterDuff_Mode_;
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00004BFC File Offset: 0x00002DFC
		private static IntPtr n_SetIconTintMode_Landroid_graphics_PorterDuff_Mode_(IntPtr jnienv, IntPtr native__this, IntPtr native_tintMode)
		{
			ISupportMenuItem @object = Java.Lang.Object.GetObject<ISupportMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			PorterDuff.Mode object2 = Java.Lang.Object.GetObject<PorterDuff.Mode>(native_tintMode, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetIconTintMode(object2));
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00004C24 File Offset: 0x00002E24
		public unsafe IMenuItem SetIconTintMode(PorterDuff.Mode tintMode)
		{
			if (this.id_setIconTintMode_Landroid_graphics_PorterDuff_Mode_ == IntPtr.Zero)
			{
				this.id_setIconTintMode_Landroid_graphics_PorterDuff_Mode_ = JNIEnv.GetMethodID(this.class_ref, "setIconTintMode", "(Landroid/graphics/PorterDuff$Mode;)Landroid/view/MenuItem;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((tintMode == null) ? IntPtr.Zero : tintMode.Handle);
			return Java.Lang.Object.GetObject<IMenuItem>(JNIEnv.CallObjectMethod(base.Handle, this.id_setIconTintMode_Landroid_graphics_PorterDuff_Mode_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00004C9D File Offset: 0x00002E9D
		private static Delegate GetSetNumericShortcut_CIHandler()
		{
			if (ISupportMenuItemInvoker.cb_setNumericShortcut_CI == null)
			{
				ISupportMenuItemInvoker.cb_setNumericShortcut_CI = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPCI_L(ISupportMenuItemInvoker.n_SetNumericShortcut_CI));
			}
			return ISupportMenuItemInvoker.cb_setNumericShortcut_CI;
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00004CC1 File Offset: 0x00002EC1
		private static IntPtr n_SetNumericShortcut_CI(IntPtr jnienv, IntPtr native__this, char numericChar, int numericModifiers)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISupportMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetNumericShortcut(numericChar, numericModifiers));
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00004CD8 File Offset: 0x00002ED8
		public unsafe IMenuItem SetNumericShortcut(char numericChar, int numericModifiers)
		{
			if (this.id_setNumericShortcut_CI == IntPtr.Zero)
			{
				this.id_setNumericShortcut_CI = JNIEnv.GetMethodID(this.class_ref, "setNumericShortcut", "(CI)Landroid/view/MenuItem;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(numericChar);
			ptr[1] = new JValue(numericModifiers);
			return Java.Lang.Object.GetObject<IMenuItem>(JNIEnv.CallObjectMethod(base.Handle, this.id_setNumericShortcut_CI, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00004D55 File Offset: 0x00002F55
		private static Delegate GetSetShortcut_CCIIHandler()
		{
			if (ISupportMenuItemInvoker.cb_setShortcut_CCII == null)
			{
				ISupportMenuItemInvoker.cb_setShortcut_CCII = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPCCII_L(ISupportMenuItemInvoker.n_SetShortcut_CCII));
			}
			return ISupportMenuItemInvoker.cb_setShortcut_CCII;
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00004D79 File Offset: 0x00002F79
		private static IntPtr n_SetShortcut_CCII(IntPtr jnienv, IntPtr native__this, char numericChar, char alphaChar, int numericModifiers, int alphaModifiers)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISupportMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetShortcut(numericChar, alphaChar, numericModifiers, alphaModifiers));
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00004D94 File Offset: 0x00002F94
		public unsafe IMenuItem SetShortcut(char numericChar, char alphaChar, int numericModifiers, int alphaModifiers)
		{
			if (this.id_setShortcut_CCII == IntPtr.Zero)
			{
				this.id_setShortcut_CCII = JNIEnv.GetMethodID(this.class_ref, "setShortcut", "(CCII)Landroid/view/MenuItem;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(numericChar);
			ptr[1] = new JValue(alphaChar);
			ptr[2] = new JValue(numericModifiers);
			ptr[3] = new JValue(alphaModifiers);
			return Java.Lang.Object.GetObject<IMenuItem>(JNIEnv.CallObjectMethod(base.Handle, this.id_setShortcut_CCII, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00004E3E File Offset: 0x0000303E
		private static Delegate GetSetShowAsAction_IHandler()
		{
			if (ISupportMenuItemInvoker.cb_setShowAsAction_I == null)
			{
				ISupportMenuItemInvoker.cb_setShowAsAction_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(ISupportMenuItemInvoker.n_SetShowAsAction_I));
			}
			return ISupportMenuItemInvoker.cb_setShowAsAction_I;
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00004E64 File Offset: 0x00003064
		private static void n_SetShowAsAction_I(IntPtr jnienv, IntPtr native__this, int native_actionEnum)
		{
			Java.Lang.Object.GetObject<ISupportMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetShowAsAction((ShowAsAction)native_actionEnum);
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00004E84 File Offset: 0x00003084
		public unsafe void SetShowAsAction([GeneratedEnum] ShowAsAction actionEnum)
		{
			if (this.id_setShowAsAction_I == IntPtr.Zero)
			{
				this.id_setShowAsAction_I = JNIEnv.GetMethodID(this.class_ref, "setShowAsAction", "(I)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((int)actionEnum);
			JNIEnv.CallVoidMethod(base.Handle, this.id_setShowAsAction_I, ptr);
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00004EE8 File Offset: 0x000030E8
		private static Delegate GetSetShowAsActionFlags_IHandler()
		{
			if (ISupportMenuItemInvoker.cb_setShowAsActionFlags_I == null)
			{
				ISupportMenuItemInvoker.cb_setShowAsActionFlags_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(ISupportMenuItemInvoker.n_SetShowAsActionFlags_I));
			}
			return ISupportMenuItemInvoker.cb_setShowAsActionFlags_I;
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00004F0C File Offset: 0x0000310C
		private static IntPtr n_SetShowAsActionFlags_I(IntPtr jnienv, IntPtr native__this, int native_actionEnum)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISupportMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetShowAsActionFlags((ShowAsAction)native_actionEnum));
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00004F30 File Offset: 0x00003130
		public unsafe IMenuItem SetShowAsActionFlags([GeneratedEnum] ShowAsAction actionEnum)
		{
			if (this.id_setShowAsActionFlags_I == IntPtr.Zero)
			{
				this.id_setShowAsActionFlags_I = JNIEnv.GetMethodID(this.class_ref, "setShowAsActionFlags", "(I)Landroid/view/MenuItem;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((int)actionEnum);
			return Java.Lang.Object.GetObject<IMenuItem>(JNIEnv.CallObjectMethod(base.Handle, this.id_setShowAsActionFlags_I, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00004F9A File Offset: 0x0000319A
		private static Delegate GetSetSupportActionProvider_Landroidx_core_view_ActionProvider_Handler()
		{
			if (ISupportMenuItemInvoker.cb_setSupportActionProvider_Landroidx_core_view_ActionProvider_ == null)
			{
				ISupportMenuItemInvoker.cb_setSupportActionProvider_Landroidx_core_view_ActionProvider_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ISupportMenuItemInvoker.n_SetSupportActionProvider_Landroidx_core_view_ActionProvider_));
			}
			return ISupportMenuItemInvoker.cb_setSupportActionProvider_Landroidx_core_view_ActionProvider_;
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00004FC0 File Offset: 0x000031C0
		private static IntPtr n_SetSupportActionProvider_Landroidx_core_view_ActionProvider_(IntPtr jnienv, IntPtr native__this, IntPtr native_actionProvider)
		{
			ISupportMenuItem @object = Java.Lang.Object.GetObject<ISupportMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AndroidX.Core.View.ActionProvider object2 = Java.Lang.Object.GetObject<AndroidX.Core.View.ActionProvider>(native_actionProvider, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetSupportActionProvider(object2));
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00004FE8 File Offset: 0x000031E8
		public unsafe ISupportMenuItem SetSupportActionProvider(AndroidX.Core.View.ActionProvider actionProvider)
		{
			if (this.id_setSupportActionProvider_Landroidx_core_view_ActionProvider_ == IntPtr.Zero)
			{
				this.id_setSupportActionProvider_Landroidx_core_view_ActionProvider_ = JNIEnv.GetMethodID(this.class_ref, "setSupportActionProvider", "(Landroidx/core/view/ActionProvider;)Landroidx/core/internal/view/SupportMenuItem;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((actionProvider == null) ? IntPtr.Zero : actionProvider.Handle);
			return Java.Lang.Object.GetObject<ISupportMenuItem>(JNIEnv.CallObjectMethod(base.Handle, this.id_setSupportActionProvider_Landroidx_core_view_ActionProvider_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00005061 File Offset: 0x00003261
		private static Delegate GetSetTooltipText_Ljava_lang_CharSequence_Handler()
		{
			if (ISupportMenuItemInvoker.cb_setTooltipText_Ljava_lang_CharSequence_ == null)
			{
				ISupportMenuItemInvoker.cb_setTooltipText_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ISupportMenuItemInvoker.n_SetTooltipText_Ljava_lang_CharSequence_));
			}
			return ISupportMenuItemInvoker.cb_setTooltipText_Ljava_lang_CharSequence_;
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00005088 File Offset: 0x00003288
		private static IntPtr n_SetTooltipText_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_tooltipText)
		{
			ISupportMenuItem @object = Java.Lang.Object.GetObject<ISupportMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_tooltipText, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetTooltipText(object2));
		}

		// Token: 0x0600021D RID: 541 RVA: 0x000050B0 File Offset: 0x000032B0
		public unsafe ISupportMenuItem SetTooltipText(ICharSequence tooltipText)
		{
			if (this.id_setTooltipText_Ljava_lang_CharSequence_ == IntPtr.Zero)
			{
				this.id_setTooltipText_Ljava_lang_CharSequence_ = JNIEnv.GetMethodID(this.class_ref, "setTooltipText", "(Ljava/lang/CharSequence;)Landroidx/core/internal/view/SupportMenuItem;");
			}
			IntPtr intPtr = CharSequence.ToLocalJniHandle(tooltipText);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ISupportMenuItem @object = Java.Lang.Object.GetObject<ISupportMenuItem>(JNIEnv.CallObjectMethod(base.Handle, this.id_setTooltipText_Ljava_lang_CharSequence_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00005127 File Offset: 0x00003327
		private static Delegate GetGetActionProviderHandler()
		{
			if (ISupportMenuItemInvoker.cb_getActionProvider == null)
			{
				ISupportMenuItemInvoker.cb_getActionProvider = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISupportMenuItemInvoker.n_GetActionProvider));
			}
			return ISupportMenuItemInvoker.cb_getActionProvider;
		}

		// Token: 0x0600021F RID: 543 RVA: 0x0000514B File Offset: 0x0000334B
		private static IntPtr n_GetActionProvider(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISupportMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ActionProvider);
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000220 RID: 544 RVA: 0x00005160 File Offset: 0x00003360
		public Android.Views.ActionProvider ActionProvider
		{
			get
			{
				if (this.id_getActionProvider == IntPtr.Zero)
				{
					this.id_getActionProvider = JNIEnv.GetMethodID(this.class_ref, "getActionProvider", "()Landroid/view/ActionProvider;");
				}
				return Java.Lang.Object.GetObject<Android.Views.ActionProvider>(JNIEnv.CallObjectMethod(base.Handle, this.id_getActionProvider), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000221 RID: 545 RVA: 0x000051B1 File Offset: 0x000033B1
		private static Delegate GetGetAlphabeticShortcutHandler()
		{
			if (ISupportMenuItemInvoker.cb_getAlphabeticShortcut == null)
			{
				ISupportMenuItemInvoker.cb_getAlphabeticShortcut = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_C(ISupportMenuItemInvoker.n_GetAlphabeticShortcut));
			}
			return ISupportMenuItemInvoker.cb_getAlphabeticShortcut;
		}

		// Token: 0x06000222 RID: 546 RVA: 0x000051D5 File Offset: 0x000033D5
		private static char n_GetAlphabeticShortcut(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ISupportMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AlphabeticShortcut;
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000223 RID: 547 RVA: 0x000051E4 File Offset: 0x000033E4
		public char AlphabeticShortcut
		{
			get
			{
				if (this.id_getAlphabeticShortcut == IntPtr.Zero)
				{
					this.id_getAlphabeticShortcut = JNIEnv.GetMethodID(this.class_ref, "getAlphabeticShortcut", "()C");
				}
				return JNIEnv.CallCharMethod(base.Handle, this.id_getAlphabeticShortcut);
			}
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00005224 File Offset: 0x00003424
		private static Delegate GetGetGroupIdHandler()
		{
			if (ISupportMenuItemInvoker.cb_getGroupId == null)
			{
				ISupportMenuItemInvoker.cb_getGroupId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ISupportMenuItemInvoker.n_GetGroupId));
			}
			return ISupportMenuItemInvoker.cb_getGroupId;
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00005248 File Offset: 0x00003448
		private static int n_GetGroupId(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ISupportMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GroupId;
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000226 RID: 550 RVA: 0x00005257 File Offset: 0x00003457
		public int GroupId
		{
			get
			{
				if (this.id_getGroupId == IntPtr.Zero)
				{
					this.id_getGroupId = JNIEnv.GetMethodID(this.class_ref, "getGroupId", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_getGroupId);
			}
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00005297 File Offset: 0x00003497
		private static Delegate GetGetHasSubMenuHandler()
		{
			if (ISupportMenuItemInvoker.cb_hasSubMenu == null)
			{
				ISupportMenuItemInvoker.cb_hasSubMenu = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ISupportMenuItemInvoker.n_GetHasSubMenu));
			}
			return ISupportMenuItemInvoker.cb_hasSubMenu;
		}

		// Token: 0x06000228 RID: 552 RVA: 0x000052BB File Offset: 0x000034BB
		private static bool n_GetHasSubMenu(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ISupportMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HasSubMenu;
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000229 RID: 553 RVA: 0x000052CA File Offset: 0x000034CA
		public bool HasSubMenu
		{
			get
			{
				if (this.id_hasSubMenu == IntPtr.Zero)
				{
					this.id_hasSubMenu = JNIEnv.GetMethodID(this.class_ref, "hasSubMenu", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_hasSubMenu);
			}
		}

		// Token: 0x0600022A RID: 554 RVA: 0x0000530A File Offset: 0x0000350A
		private static Delegate GetGetIconHandler()
		{
			if (ISupportMenuItemInvoker.cb_getIcon == null)
			{
				ISupportMenuItemInvoker.cb_getIcon = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISupportMenuItemInvoker.n_GetIcon));
			}
			return ISupportMenuItemInvoker.cb_getIcon;
		}

		// Token: 0x0600022B RID: 555 RVA: 0x0000532E File Offset: 0x0000352E
		private static IntPtr n_GetIcon(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISupportMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Icon);
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600022C RID: 556 RVA: 0x00005344 File Offset: 0x00003544
		public Drawable Icon
		{
			get
			{
				if (this.id_getIcon == IntPtr.Zero)
				{
					this.id_getIcon = JNIEnv.GetMethodID(this.class_ref, "getIcon", "()Landroid/graphics/drawable/Drawable;");
				}
				return Java.Lang.Object.GetObject<Drawable>(JNIEnv.CallObjectMethod(base.Handle, this.id_getIcon), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00005395 File Offset: 0x00003595
		private static Delegate GetGetIntentHandler()
		{
			if (ISupportMenuItemInvoker.cb_getIntent == null)
			{
				ISupportMenuItemInvoker.cb_getIntent = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISupportMenuItemInvoker.n_GetIntent));
			}
			return ISupportMenuItemInvoker.cb_getIntent;
		}

		// Token: 0x0600022E RID: 558 RVA: 0x000053B9 File Offset: 0x000035B9
		private static IntPtr n_GetIntent(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISupportMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Intent);
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600022F RID: 559 RVA: 0x000053D0 File Offset: 0x000035D0
		public Intent Intent
		{
			get
			{
				if (this.id_getIntent == IntPtr.Zero)
				{
					this.id_getIntent = JNIEnv.GetMethodID(this.class_ref, "getIntent", "()Landroid/content/Intent;");
				}
				return Java.Lang.Object.GetObject<Intent>(JNIEnv.CallObjectMethod(base.Handle, this.id_getIntent), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00005421 File Offset: 0x00003621
		private static Delegate GetIsCheckableHandler()
		{
			if (ISupportMenuItemInvoker.cb_isCheckable == null)
			{
				ISupportMenuItemInvoker.cb_isCheckable = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ISupportMenuItemInvoker.n_IsCheckable));
			}
			return ISupportMenuItemInvoker.cb_isCheckable;
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00005445 File Offset: 0x00003645
		private static bool n_IsCheckable(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ISupportMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsCheckable;
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000232 RID: 562 RVA: 0x00005454 File Offset: 0x00003654
		public bool IsCheckable
		{
			get
			{
				if (this.id_isCheckable == IntPtr.Zero)
				{
					this.id_isCheckable = JNIEnv.GetMethodID(this.class_ref, "isCheckable", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isCheckable);
			}
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00005494 File Offset: 0x00003694
		private static Delegate GetIsCheckedHandler()
		{
			if (ISupportMenuItemInvoker.cb_isChecked == null)
			{
				ISupportMenuItemInvoker.cb_isChecked = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ISupportMenuItemInvoker.n_IsChecked));
			}
			return ISupportMenuItemInvoker.cb_isChecked;
		}

		// Token: 0x06000234 RID: 564 RVA: 0x000054B8 File Offset: 0x000036B8
		private static bool n_IsChecked(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ISupportMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsChecked;
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000235 RID: 565 RVA: 0x000054C7 File Offset: 0x000036C7
		public bool IsChecked
		{
			get
			{
				if (this.id_isChecked == IntPtr.Zero)
				{
					this.id_isChecked = JNIEnv.GetMethodID(this.class_ref, "isChecked", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isChecked);
			}
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00005507 File Offset: 0x00003707
		private static Delegate GetIsEnabledHandler()
		{
			if (ISupportMenuItemInvoker.cb_isEnabled == null)
			{
				ISupportMenuItemInvoker.cb_isEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ISupportMenuItemInvoker.n_IsEnabled));
			}
			return ISupportMenuItemInvoker.cb_isEnabled;
		}

		// Token: 0x06000237 RID: 567 RVA: 0x0000552B File Offset: 0x0000372B
		private static bool n_IsEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ISupportMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsEnabled;
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000238 RID: 568 RVA: 0x0000553A File Offset: 0x0000373A
		public bool IsEnabled
		{
			get
			{
				if (this.id_isEnabled == IntPtr.Zero)
				{
					this.id_isEnabled = JNIEnv.GetMethodID(this.class_ref, "isEnabled", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isEnabled);
			}
		}

		// Token: 0x06000239 RID: 569 RVA: 0x0000557A File Offset: 0x0000377A
		private static Delegate GetIsVisibleHandler()
		{
			if (ISupportMenuItemInvoker.cb_isVisible == null)
			{
				ISupportMenuItemInvoker.cb_isVisible = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ISupportMenuItemInvoker.n_IsVisible));
			}
			return ISupportMenuItemInvoker.cb_isVisible;
		}

		// Token: 0x0600023A RID: 570 RVA: 0x0000559E File Offset: 0x0000379E
		private static bool n_IsVisible(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ISupportMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsVisible;
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600023B RID: 571 RVA: 0x000055AD File Offset: 0x000037AD
		public bool IsVisible
		{
			get
			{
				if (this.id_isVisible == IntPtr.Zero)
				{
					this.id_isVisible = JNIEnv.GetMethodID(this.class_ref, "isVisible", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isVisible);
			}
		}

		// Token: 0x0600023C RID: 572 RVA: 0x000055ED File Offset: 0x000037ED
		private static Delegate GetGetItemIdHandler()
		{
			if (ISupportMenuItemInvoker.cb_getItemId == null)
			{
				ISupportMenuItemInvoker.cb_getItemId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ISupportMenuItemInvoker.n_GetItemId));
			}
			return ISupportMenuItemInvoker.cb_getItemId;
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00005611 File Offset: 0x00003811
		private static int n_GetItemId(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ISupportMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ItemId;
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600023E RID: 574 RVA: 0x00005620 File Offset: 0x00003820
		public int ItemId
		{
			get
			{
				if (this.id_getItemId == IntPtr.Zero)
				{
					this.id_getItemId = JNIEnv.GetMethodID(this.class_ref, "getItemId", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_getItemId);
			}
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00005660 File Offset: 0x00003860
		private static Delegate GetGetMenuInfoHandler()
		{
			if (ISupportMenuItemInvoker.cb_getMenuInfo == null)
			{
				ISupportMenuItemInvoker.cb_getMenuInfo = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISupportMenuItemInvoker.n_GetMenuInfo));
			}
			return ISupportMenuItemInvoker.cb_getMenuInfo;
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00005684 File Offset: 0x00003884
		private static IntPtr n_GetMenuInfo(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISupportMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MenuInfo);
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000241 RID: 577 RVA: 0x00005698 File Offset: 0x00003898
		public IContextMenuContextMenuInfo MenuInfo
		{
			get
			{
				if (this.id_getMenuInfo == IntPtr.Zero)
				{
					this.id_getMenuInfo = JNIEnv.GetMethodID(this.class_ref, "getMenuInfo", "()Landroid/view/ContextMenu$ContextMenuInfo;");
				}
				return Java.Lang.Object.GetObject<IContextMenuContextMenuInfo>(JNIEnv.CallObjectMethod(base.Handle, this.id_getMenuInfo), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000242 RID: 578 RVA: 0x000056E9 File Offset: 0x000038E9
		private static Delegate GetGetNumericShortcutHandler()
		{
			if (ISupportMenuItemInvoker.cb_getNumericShortcut == null)
			{
				ISupportMenuItemInvoker.cb_getNumericShortcut = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_C(ISupportMenuItemInvoker.n_GetNumericShortcut));
			}
			return ISupportMenuItemInvoker.cb_getNumericShortcut;
		}

		// Token: 0x06000243 RID: 579 RVA: 0x0000570D File Offset: 0x0000390D
		private static char n_GetNumericShortcut(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ISupportMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NumericShortcut;
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000244 RID: 580 RVA: 0x0000571C File Offset: 0x0000391C
		public char NumericShortcut
		{
			get
			{
				if (this.id_getNumericShortcut == IntPtr.Zero)
				{
					this.id_getNumericShortcut = JNIEnv.GetMethodID(this.class_ref, "getNumericShortcut", "()C");
				}
				return JNIEnv.CallCharMethod(base.Handle, this.id_getNumericShortcut);
			}
		}

		// Token: 0x06000245 RID: 581 RVA: 0x0000575C File Offset: 0x0000395C
		private static Delegate GetGetOrderHandler()
		{
			if (ISupportMenuItemInvoker.cb_getOrder == null)
			{
				ISupportMenuItemInvoker.cb_getOrder = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ISupportMenuItemInvoker.n_GetOrder));
			}
			return ISupportMenuItemInvoker.cb_getOrder;
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00005780 File Offset: 0x00003980
		private static int n_GetOrder(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ISupportMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Order;
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000247 RID: 583 RVA: 0x0000578F File Offset: 0x0000398F
		public int Order
		{
			get
			{
				if (this.id_getOrder == IntPtr.Zero)
				{
					this.id_getOrder = JNIEnv.GetMethodID(this.class_ref, "getOrder", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_getOrder);
			}
		}

		// Token: 0x06000248 RID: 584 RVA: 0x000057CF File Offset: 0x000039CF
		private static Delegate GetGetSubMenuHandler()
		{
			if (ISupportMenuItemInvoker.cb_getSubMenu == null)
			{
				ISupportMenuItemInvoker.cb_getSubMenu = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISupportMenuItemInvoker.n_GetSubMenu));
			}
			return ISupportMenuItemInvoker.cb_getSubMenu;
		}

		// Token: 0x06000249 RID: 585 RVA: 0x000057F3 File Offset: 0x000039F3
		private static IntPtr n_GetSubMenu(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISupportMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SubMenu);
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600024A RID: 586 RVA: 0x00005808 File Offset: 0x00003A08
		public ISubMenu SubMenu
		{
			get
			{
				if (this.id_getSubMenu == IntPtr.Zero)
				{
					this.id_getSubMenu = JNIEnv.GetMethodID(this.class_ref, "getSubMenu", "()Landroid/view/SubMenu;");
				}
				return Java.Lang.Object.GetObject<ISubMenu>(JNIEnv.CallObjectMethod(base.Handle, this.id_getSubMenu), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600024B RID: 587 RVA: 0x00005859 File Offset: 0x00003A59
		private static Delegate GetGetTitleHandler()
		{
			if (ISupportMenuItemInvoker.cb_getTitle == null)
			{
				ISupportMenuItemInvoker.cb_getTitle = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISupportMenuItemInvoker.n_GetTitle));
			}
			return ISupportMenuItemInvoker.cb_getTitle;
		}

		// Token: 0x0600024C RID: 588 RVA: 0x0000587D File Offset: 0x00003A7D
		private static IntPtr n_GetTitle(IntPtr jnienv, IntPtr native__this)
		{
			return CharSequence.ToLocalJniHandle(Java.Lang.Object.GetObject<ISupportMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TitleFormatted);
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600024D RID: 589 RVA: 0x00005894 File Offset: 0x00003A94
		public ICharSequence TitleFormatted
		{
			get
			{
				if (this.id_getTitle == IntPtr.Zero)
				{
					this.id_getTitle = JNIEnv.GetMethodID(this.class_ref, "getTitle", "()Ljava/lang/CharSequence;");
				}
				return Java.Lang.Object.GetObject<ICharSequence>(JNIEnv.CallObjectMethod(base.Handle, this.id_getTitle), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600024E RID: 590 RVA: 0x000058E5 File Offset: 0x00003AE5
		private static Delegate GetGetTitleCondensedHandler()
		{
			if (ISupportMenuItemInvoker.cb_getTitleCondensed == null)
			{
				ISupportMenuItemInvoker.cb_getTitleCondensed = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISupportMenuItemInvoker.n_GetTitleCondensed));
			}
			return ISupportMenuItemInvoker.cb_getTitleCondensed;
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00005909 File Offset: 0x00003B09
		private static IntPtr n_GetTitleCondensed(IntPtr jnienv, IntPtr native__this)
		{
			return CharSequence.ToLocalJniHandle(Java.Lang.Object.GetObject<ISupportMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TitleCondensedFormatted);
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000250 RID: 592 RVA: 0x00005920 File Offset: 0x00003B20
		public ICharSequence TitleCondensedFormatted
		{
			get
			{
				if (this.id_getTitleCondensed == IntPtr.Zero)
				{
					this.id_getTitleCondensed = JNIEnv.GetMethodID(this.class_ref, "getTitleCondensed", "()Ljava/lang/CharSequence;");
				}
				return Java.Lang.Object.GetObject<ICharSequence>(JNIEnv.CallObjectMethod(base.Handle, this.id_getTitleCondensed), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00005971 File Offset: 0x00003B71
		private static Delegate GetSetActionProvider_Landroid_view_ActionProvider_Handler()
		{
			if (ISupportMenuItemInvoker.cb_setActionProvider_Landroid_view_ActionProvider_ == null)
			{
				ISupportMenuItemInvoker.cb_setActionProvider_Landroid_view_ActionProvider_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ISupportMenuItemInvoker.n_SetActionProvider_Landroid_view_ActionProvider_));
			}
			return ISupportMenuItemInvoker.cb_setActionProvider_Landroid_view_ActionProvider_;
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00005998 File Offset: 0x00003B98
		private static IntPtr n_SetActionProvider_Landroid_view_ActionProvider_(IntPtr jnienv, IntPtr native__this, IntPtr native_actionProvider)
		{
			IMenuItem @object = Java.Lang.Object.GetObject<ISupportMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Android.Views.ActionProvider object2 = Java.Lang.Object.GetObject<Android.Views.ActionProvider>(native_actionProvider, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetActionProvider(object2));
		}

		// Token: 0x06000253 RID: 595 RVA: 0x000059C0 File Offset: 0x00003BC0
		public unsafe IMenuItem SetActionProvider(Android.Views.ActionProvider actionProvider)
		{
			if (this.id_setActionProvider_Landroid_view_ActionProvider_ == IntPtr.Zero)
			{
				this.id_setActionProvider_Landroid_view_ActionProvider_ = JNIEnv.GetMethodID(this.class_ref, "setActionProvider", "(Landroid/view/ActionProvider;)Landroid/view/MenuItem;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((actionProvider == null) ? IntPtr.Zero : actionProvider.Handle);
			return Java.Lang.Object.GetObject<IMenuItem>(JNIEnv.CallObjectMethod(base.Handle, this.id_setActionProvider_Landroid_view_ActionProvider_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00005A39 File Offset: 0x00003C39
		private static Delegate GetSetAlphabeticShortcut_CHandler()
		{
			if (ISupportMenuItemInvoker.cb_setAlphabeticShortcut_C == null)
			{
				ISupportMenuItemInvoker.cb_setAlphabeticShortcut_C = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPC_L(ISupportMenuItemInvoker.n_SetAlphabeticShortcut_C));
			}
			return ISupportMenuItemInvoker.cb_setAlphabeticShortcut_C;
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00005A5D File Offset: 0x00003C5D
		private static IntPtr n_SetAlphabeticShortcut_C(IntPtr jnienv, IntPtr native__this, char alphaChar)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISupportMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetAlphabeticShortcut(alphaChar));
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00005A74 File Offset: 0x00003C74
		public unsafe IMenuItem SetAlphabeticShortcut(char alphaChar)
		{
			if (this.id_setAlphabeticShortcut_C == IntPtr.Zero)
			{
				this.id_setAlphabeticShortcut_C = JNIEnv.GetMethodID(this.class_ref, "setAlphabeticShortcut", "(C)Landroid/view/MenuItem;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(alphaChar);
			return Java.Lang.Object.GetObject<IMenuItem>(JNIEnv.CallObjectMethod(base.Handle, this.id_setAlphabeticShortcut_C, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00005ADE File Offset: 0x00003CDE
		private static Delegate GetSetCheckable_ZHandler()
		{
			if (ISupportMenuItemInvoker.cb_setCheckable_Z == null)
			{
				ISupportMenuItemInvoker.cb_setCheckable_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_L(ISupportMenuItemInvoker.n_SetCheckable_Z));
			}
			return ISupportMenuItemInvoker.cb_setCheckable_Z;
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00005B02 File Offset: 0x00003D02
		private static IntPtr n_SetCheckable_Z(IntPtr jnienv, IntPtr native__this, bool checkable)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISupportMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetCheckable(checkable));
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00005B18 File Offset: 0x00003D18
		public unsafe IMenuItem SetCheckable(bool checkable)
		{
			if (this.id_setCheckable_Z == IntPtr.Zero)
			{
				this.id_setCheckable_Z = JNIEnv.GetMethodID(this.class_ref, "setCheckable", "(Z)Landroid/view/MenuItem;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(checkable);
			return Java.Lang.Object.GetObject<IMenuItem>(JNIEnv.CallObjectMethod(base.Handle, this.id_setCheckable_Z, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00005B82 File Offset: 0x00003D82
		private static Delegate GetSetChecked_ZHandler()
		{
			if (ISupportMenuItemInvoker.cb_setChecked_Z == null)
			{
				ISupportMenuItemInvoker.cb_setChecked_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_L(ISupportMenuItemInvoker.n_SetChecked_Z));
			}
			return ISupportMenuItemInvoker.cb_setChecked_Z;
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00005BA6 File Offset: 0x00003DA6
		private static IntPtr n_SetChecked_Z(IntPtr jnienv, IntPtr native__this, bool @checked)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISupportMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetChecked(@checked));
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00005BBC File Offset: 0x00003DBC
		public unsafe IMenuItem SetChecked(bool @checked)
		{
			if (this.id_setChecked_Z == IntPtr.Zero)
			{
				this.id_setChecked_Z = JNIEnv.GetMethodID(this.class_ref, "setChecked", "(Z)Landroid/view/MenuItem;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(@checked);
			return Java.Lang.Object.GetObject<IMenuItem>(JNIEnv.CallObjectMethod(base.Handle, this.id_setChecked_Z, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600025D RID: 605 RVA: 0x00005C26 File Offset: 0x00003E26
		private static Delegate GetSetEnabled_ZHandler()
		{
			if (ISupportMenuItemInvoker.cb_setEnabled_Z == null)
			{
				ISupportMenuItemInvoker.cb_setEnabled_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_L(ISupportMenuItemInvoker.n_SetEnabled_Z));
			}
			return ISupportMenuItemInvoker.cb_setEnabled_Z;
		}

		// Token: 0x0600025E RID: 606 RVA: 0x00005C4A File Offset: 0x00003E4A
		private static IntPtr n_SetEnabled_Z(IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISupportMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetEnabled(enabled));
		}

		// Token: 0x0600025F RID: 607 RVA: 0x00005C60 File Offset: 0x00003E60
		public unsafe IMenuItem SetEnabled(bool enabled)
		{
			if (this.id_setEnabled_Z == IntPtr.Zero)
			{
				this.id_setEnabled_Z = JNIEnv.GetMethodID(this.class_ref, "setEnabled", "(Z)Landroid/view/MenuItem;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(enabled);
			return Java.Lang.Object.GetObject<IMenuItem>(JNIEnv.CallObjectMethod(base.Handle, this.id_setEnabled_Z, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00005CCA File Offset: 0x00003ECA
		private static Delegate GetSetIcon_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (ISupportMenuItemInvoker.cb_setIcon_Landroid_graphics_drawable_Drawable_ == null)
			{
				ISupportMenuItemInvoker.cb_setIcon_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ISupportMenuItemInvoker.n_SetIcon_Landroid_graphics_drawable_Drawable_));
			}
			return ISupportMenuItemInvoker.cb_setIcon_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00005CF0 File Offset: 0x00003EF0
		private static IntPtr n_SetIcon_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_icon)
		{
			IMenuItem @object = Java.Lang.Object.GetObject<ISupportMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_icon, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetIcon(object2));
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00005D18 File Offset: 0x00003F18
		public unsafe IMenuItem SetIcon(Drawable icon)
		{
			if (this.id_setIcon_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
			{
				this.id_setIcon_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID(this.class_ref, "setIcon", "(Landroid/graphics/drawable/Drawable;)Landroid/view/MenuItem;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((icon == null) ? IntPtr.Zero : icon.Handle);
			return Java.Lang.Object.GetObject<IMenuItem>(JNIEnv.CallObjectMethod(base.Handle, this.id_setIcon_Landroid_graphics_drawable_Drawable_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00005D91 File Offset: 0x00003F91
		private static Delegate GetSetIcon_IHandler()
		{
			if (ISupportMenuItemInvoker.cb_setIcon_I == null)
			{
				ISupportMenuItemInvoker.cb_setIcon_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(ISupportMenuItemInvoker.n_SetIcon_I));
			}
			return ISupportMenuItemInvoker.cb_setIcon_I;
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00005DB5 File Offset: 0x00003FB5
		private static IntPtr n_SetIcon_I(IntPtr jnienv, IntPtr native__this, int iconRes)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISupportMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetIcon(iconRes));
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00005DCC File Offset: 0x00003FCC
		public unsafe IMenuItem SetIcon(int iconRes)
		{
			if (this.id_setIcon_I == IntPtr.Zero)
			{
				this.id_setIcon_I = JNIEnv.GetMethodID(this.class_ref, "setIcon", "(I)Landroid/view/MenuItem;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(iconRes);
			return Java.Lang.Object.GetObject<IMenuItem>(JNIEnv.CallObjectMethod(base.Handle, this.id_setIcon_I, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00005E36 File Offset: 0x00004036
		private static Delegate GetSetIntent_Landroid_content_Intent_Handler()
		{
			if (ISupportMenuItemInvoker.cb_setIntent_Landroid_content_Intent_ == null)
			{
				ISupportMenuItemInvoker.cb_setIntent_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ISupportMenuItemInvoker.n_SetIntent_Landroid_content_Intent_));
			}
			return ISupportMenuItemInvoker.cb_setIntent_Landroid_content_Intent_;
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00005E5C File Offset: 0x0000405C
		private static IntPtr n_SetIntent_Landroid_content_Intent_(IntPtr jnienv, IntPtr native__this, IntPtr native_intent)
		{
			IMenuItem @object = Java.Lang.Object.GetObject<ISupportMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Intent object2 = Java.Lang.Object.GetObject<Intent>(native_intent, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetIntent(object2));
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00005E84 File Offset: 0x00004084
		public unsafe IMenuItem SetIntent(Intent intent)
		{
			if (this.id_setIntent_Landroid_content_Intent_ == IntPtr.Zero)
			{
				this.id_setIntent_Landroid_content_Intent_ = JNIEnv.GetMethodID(this.class_ref, "setIntent", "(Landroid/content/Intent;)Landroid/view/MenuItem;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((intent == null) ? IntPtr.Zero : intent.Handle);
			return Java.Lang.Object.GetObject<IMenuItem>(JNIEnv.CallObjectMethod(base.Handle, this.id_setIntent_Landroid_content_Intent_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00005EFD File Offset: 0x000040FD
		private static Delegate GetSetNumericShortcut_CHandler()
		{
			if (ISupportMenuItemInvoker.cb_setNumericShortcut_C == null)
			{
				ISupportMenuItemInvoker.cb_setNumericShortcut_C = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPC_L(ISupportMenuItemInvoker.n_SetNumericShortcut_C));
			}
			return ISupportMenuItemInvoker.cb_setNumericShortcut_C;
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00005F21 File Offset: 0x00004121
		private static IntPtr n_SetNumericShortcut_C(IntPtr jnienv, IntPtr native__this, char numericChar)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISupportMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetNumericShortcut(numericChar));
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00005F38 File Offset: 0x00004138
		public unsafe IMenuItem SetNumericShortcut(char numericChar)
		{
			if (this.id_setNumericShortcut_C == IntPtr.Zero)
			{
				this.id_setNumericShortcut_C = JNIEnv.GetMethodID(this.class_ref, "setNumericShortcut", "(C)Landroid/view/MenuItem;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(numericChar);
			return Java.Lang.Object.GetObject<IMenuItem>(JNIEnv.CallObjectMethod(base.Handle, this.id_setNumericShortcut_C, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00005FA2 File Offset: 0x000041A2
		private static Delegate GetSetOnActionExpandListener_Landroid_view_MenuItem_OnActionExpandListener_Handler()
		{
			if (ISupportMenuItemInvoker.cb_setOnActionExpandListener_Landroid_view_MenuItem_OnActionExpandListener_ == null)
			{
				ISupportMenuItemInvoker.cb_setOnActionExpandListener_Landroid_view_MenuItem_OnActionExpandListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ISupportMenuItemInvoker.n_SetOnActionExpandListener_Landroid_view_MenuItem_OnActionExpandListener_));
			}
			return ISupportMenuItemInvoker.cb_setOnActionExpandListener_Landroid_view_MenuItem_OnActionExpandListener_;
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00005FC8 File Offset: 0x000041C8
		private static IntPtr n_SetOnActionExpandListener_Landroid_view_MenuItem_OnActionExpandListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			IMenuItem @object = Java.Lang.Object.GetObject<ISupportMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMenuItemOnActionExpandListener object2 = Java.Lang.Object.GetObject<IMenuItemOnActionExpandListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetOnActionExpandListener(object2));
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00005FF0 File Offset: 0x000041F0
		public unsafe IMenuItem SetOnActionExpandListener(IMenuItemOnActionExpandListener listener)
		{
			if (this.id_setOnActionExpandListener_Landroid_view_MenuItem_OnActionExpandListener_ == IntPtr.Zero)
			{
				this.id_setOnActionExpandListener_Landroid_view_MenuItem_OnActionExpandListener_ = JNIEnv.GetMethodID(this.class_ref, "setOnActionExpandListener", "(Landroid/view/MenuItem$OnActionExpandListener;)Landroid/view/MenuItem;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
			return Java.Lang.Object.GetObject<IMenuItem>(JNIEnv.CallObjectMethod(base.Handle, this.id_setOnActionExpandListener_Landroid_view_MenuItem_OnActionExpandListener_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600026F RID: 623 RVA: 0x0000606E File Offset: 0x0000426E
		private static Delegate GetSetOnMenuItemClickListener_Landroid_view_MenuItem_OnMenuItemClickListener_Handler()
		{
			if (ISupportMenuItemInvoker.cb_setOnMenuItemClickListener_Landroid_view_MenuItem_OnMenuItemClickListener_ == null)
			{
				ISupportMenuItemInvoker.cb_setOnMenuItemClickListener_Landroid_view_MenuItem_OnMenuItemClickListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ISupportMenuItemInvoker.n_SetOnMenuItemClickListener_Landroid_view_MenuItem_OnMenuItemClickListener_));
			}
			return ISupportMenuItemInvoker.cb_setOnMenuItemClickListener_Landroid_view_MenuItem_OnMenuItemClickListener_;
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00006094 File Offset: 0x00004294
		private static IntPtr n_SetOnMenuItemClickListener_Landroid_view_MenuItem_OnMenuItemClickListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_menuItemClickListener)
		{
			IMenuItem @object = Java.Lang.Object.GetObject<ISupportMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMenuItemOnMenuItemClickListener object2 = Java.Lang.Object.GetObject<IMenuItemOnMenuItemClickListener>(native_menuItemClickListener, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetOnMenuItemClickListener(object2));
		}

		// Token: 0x06000271 RID: 625 RVA: 0x000060BC File Offset: 0x000042BC
		public unsafe IMenuItem SetOnMenuItemClickListener(IMenuItemOnMenuItemClickListener menuItemClickListener)
		{
			if (this.id_setOnMenuItemClickListener_Landroid_view_MenuItem_OnMenuItemClickListener_ == IntPtr.Zero)
			{
				this.id_setOnMenuItemClickListener_Landroid_view_MenuItem_OnMenuItemClickListener_ = JNIEnv.GetMethodID(this.class_ref, "setOnMenuItemClickListener", "(Landroid/view/MenuItem$OnMenuItemClickListener;)Landroid/view/MenuItem;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((menuItemClickListener == null) ? IntPtr.Zero : ((Java.Lang.Object)menuItemClickListener).Handle);
			return Java.Lang.Object.GetObject<IMenuItem>(JNIEnv.CallObjectMethod(base.Handle, this.id_setOnMenuItemClickListener_Landroid_view_MenuItem_OnMenuItemClickListener_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000272 RID: 626 RVA: 0x0000613A File Offset: 0x0000433A
		private static Delegate GetSetShortcut_CCHandler()
		{
			if (ISupportMenuItemInvoker.cb_setShortcut_CC == null)
			{
				ISupportMenuItemInvoker.cb_setShortcut_CC = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPCC_L(ISupportMenuItemInvoker.n_SetShortcut_CC));
			}
			return ISupportMenuItemInvoker.cb_setShortcut_CC;
		}

		// Token: 0x06000273 RID: 627 RVA: 0x0000615E File Offset: 0x0000435E
		private static IntPtr n_SetShortcut_CC(IntPtr jnienv, IntPtr native__this, char numericChar, char alphaChar)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISupportMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetShortcut(numericChar, alphaChar));
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00006174 File Offset: 0x00004374
		public unsafe IMenuItem SetShortcut(char numericChar, char alphaChar)
		{
			if (this.id_setShortcut_CC == IntPtr.Zero)
			{
				this.id_setShortcut_CC = JNIEnv.GetMethodID(this.class_ref, "setShortcut", "(CC)Landroid/view/MenuItem;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(numericChar);
			ptr[1] = new JValue(alphaChar);
			return Java.Lang.Object.GetObject<IMenuItem>(JNIEnv.CallObjectMethod(base.Handle, this.id_setShortcut_CC, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000275 RID: 629 RVA: 0x000061F1 File Offset: 0x000043F1
		private static Delegate GetSetTitle_IHandler()
		{
			if (ISupportMenuItemInvoker.cb_setTitle_I == null)
			{
				ISupportMenuItemInvoker.cb_setTitle_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(ISupportMenuItemInvoker.n_SetTitle_I));
			}
			return ISupportMenuItemInvoker.cb_setTitle_I;
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00006215 File Offset: 0x00004415
		private static IntPtr n_SetTitle_I(IntPtr jnienv, IntPtr native__this, int title)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISupportMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetTitle(title));
		}

		// Token: 0x06000277 RID: 631 RVA: 0x0000622C File Offset: 0x0000442C
		public unsafe IMenuItem SetTitle(int title)
		{
			if (this.id_setTitle_I == IntPtr.Zero)
			{
				this.id_setTitle_I = JNIEnv.GetMethodID(this.class_ref, "setTitle", "(I)Landroid/view/MenuItem;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(title);
			return Java.Lang.Object.GetObject<IMenuItem>(JNIEnv.CallObjectMethod(base.Handle, this.id_setTitle_I, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00006296 File Offset: 0x00004496
		private static Delegate GetSetTitle_Ljava_lang_CharSequence_Handler()
		{
			if (ISupportMenuItemInvoker.cb_setTitle_Ljava_lang_CharSequence_ == null)
			{
				ISupportMenuItemInvoker.cb_setTitle_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ISupportMenuItemInvoker.n_SetTitle_Ljava_lang_CharSequence_));
			}
			return ISupportMenuItemInvoker.cb_setTitle_Ljava_lang_CharSequence_;
		}

		// Token: 0x06000279 RID: 633 RVA: 0x000062BC File Offset: 0x000044BC
		private static IntPtr n_SetTitle_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_title)
		{
			IMenuItem @object = Java.Lang.Object.GetObject<ISupportMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_title, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetTitle(object2));
		}

		// Token: 0x0600027A RID: 634 RVA: 0x000062E4 File Offset: 0x000044E4
		public unsafe IMenuItem SetTitle(ICharSequence title)
		{
			if (this.id_setTitle_Ljava_lang_CharSequence_ == IntPtr.Zero)
			{
				this.id_setTitle_Ljava_lang_CharSequence_ = JNIEnv.GetMethodID(this.class_ref, "setTitle", "(Ljava/lang/CharSequence;)Landroid/view/MenuItem;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((title == null) ? IntPtr.Zero : ((Java.Lang.Object)title).Handle);
			return Java.Lang.Object.GetObject<IMenuItem>(JNIEnv.CallObjectMethod(base.Handle, this.id_setTitle_Ljava_lang_CharSequence_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00006362 File Offset: 0x00004562
		private static Delegate GetSetTitleCondensed_Ljava_lang_CharSequence_Handler()
		{
			if (ISupportMenuItemInvoker.cb_setTitleCondensed_Ljava_lang_CharSequence_ == null)
			{
				ISupportMenuItemInvoker.cb_setTitleCondensed_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ISupportMenuItemInvoker.n_SetTitleCondensed_Ljava_lang_CharSequence_));
			}
			return ISupportMenuItemInvoker.cb_setTitleCondensed_Ljava_lang_CharSequence_;
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00006388 File Offset: 0x00004588
		private static IntPtr n_SetTitleCondensed_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_title)
		{
			IMenuItem @object = Java.Lang.Object.GetObject<ISupportMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_title, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetTitleCondensed(object2));
		}

		// Token: 0x0600027D RID: 637 RVA: 0x000063B0 File Offset: 0x000045B0
		public unsafe IMenuItem SetTitleCondensed(ICharSequence title)
		{
			if (this.id_setTitleCondensed_Ljava_lang_CharSequence_ == IntPtr.Zero)
			{
				this.id_setTitleCondensed_Ljava_lang_CharSequence_ = JNIEnv.GetMethodID(this.class_ref, "setTitleCondensed", "(Ljava/lang/CharSequence;)Landroid/view/MenuItem;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((title == null) ? IntPtr.Zero : ((Java.Lang.Object)title).Handle);
			return Java.Lang.Object.GetObject<IMenuItem>(JNIEnv.CallObjectMethod(base.Handle, this.id_setTitleCondensed_Ljava_lang_CharSequence_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600027E RID: 638 RVA: 0x0000642E File Offset: 0x0000462E
		private static Delegate GetSetVisible_ZHandler()
		{
			if (ISupportMenuItemInvoker.cb_setVisible_Z == null)
			{
				ISupportMenuItemInvoker.cb_setVisible_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_L(ISupportMenuItemInvoker.n_SetVisible_Z));
			}
			return ISupportMenuItemInvoker.cb_setVisible_Z;
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00006452 File Offset: 0x00004652
		private static IntPtr n_SetVisible_Z(IntPtr jnienv, IntPtr native__this, bool visible)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISupportMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetVisible(visible));
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00006468 File Offset: 0x00004668
		public unsafe IMenuItem SetVisible(bool visible)
		{
			if (this.id_setVisible_Z == IntPtr.Zero)
			{
				this.id_setVisible_Z = JNIEnv.GetMethodID(this.class_ref, "setVisible", "(Z)Landroid/view/MenuItem;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(visible);
			return Java.Lang.Object.GetObject<IMenuItem>(JNIEnv.CallObjectMethod(base.Handle, this.id_setVisible_Z, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000044 RID: 68
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/internal/view/SupportMenuItem", typeof(ISupportMenuItemInvoker));

		// Token: 0x04000045 RID: 69
		private IntPtr class_ref;

		// Token: 0x04000046 RID: 70
		private static Delegate cb_getActionView;

		// Token: 0x04000047 RID: 71
		private IntPtr id_getActionView;

		// Token: 0x04000048 RID: 72
		private static Delegate cb_getAlphabeticModifiers;

		// Token: 0x04000049 RID: 73
		private IntPtr id_getAlphabeticModifiers;

		// Token: 0x0400004A RID: 74
		private static Delegate cb_getContentDescription;

		// Token: 0x0400004B RID: 75
		private IntPtr id_getContentDescription;

		// Token: 0x0400004C RID: 76
		private static Delegate cb_getIconTintList;

		// Token: 0x0400004D RID: 77
		private IntPtr id_getIconTintList;

		// Token: 0x0400004E RID: 78
		private static Delegate cb_getIconTintMode;

		// Token: 0x0400004F RID: 79
		private IntPtr id_getIconTintMode;

		// Token: 0x04000050 RID: 80
		private static Delegate cb_isActionViewExpanded;

		// Token: 0x04000051 RID: 81
		private IntPtr id_isActionViewExpanded;

		// Token: 0x04000052 RID: 82
		private static Delegate cb_getNumericModifiers;

		// Token: 0x04000053 RID: 83
		private IntPtr id_getNumericModifiers;

		// Token: 0x04000054 RID: 84
		private static Delegate cb_getSupportActionProvider;

		// Token: 0x04000055 RID: 85
		private IntPtr id_getSupportActionProvider;

		// Token: 0x04000056 RID: 86
		private static Delegate cb_getTooltipText;

		// Token: 0x04000057 RID: 87
		private IntPtr id_getTooltipText;

		// Token: 0x04000058 RID: 88
		private static Delegate cb_collapseActionView;

		// Token: 0x04000059 RID: 89
		private IntPtr id_collapseActionView;

		// Token: 0x0400005A RID: 90
		private static Delegate cb_expandActionView;

		// Token: 0x0400005B RID: 91
		private IntPtr id_expandActionView;

		// Token: 0x0400005C RID: 92
		private static Delegate cb_requiresActionButton;

		// Token: 0x0400005D RID: 93
		private IntPtr id_requiresActionButton;

		// Token: 0x0400005E RID: 94
		private static Delegate cb_requiresOverflow;

		// Token: 0x0400005F RID: 95
		private IntPtr id_requiresOverflow;

		// Token: 0x04000060 RID: 96
		private static Delegate cb_setActionView_Landroid_view_View_;

		// Token: 0x04000061 RID: 97
		private IntPtr id_setActionView_Landroid_view_View_;

		// Token: 0x04000062 RID: 98
		private static Delegate cb_setActionView_I;

		// Token: 0x04000063 RID: 99
		private IntPtr id_setActionView_I;

		// Token: 0x04000064 RID: 100
		private static Delegate cb_setAlphabeticShortcut_CI;

		// Token: 0x04000065 RID: 101
		private IntPtr id_setAlphabeticShortcut_CI;

		// Token: 0x04000066 RID: 102
		private static Delegate cb_setContentDescription_Ljava_lang_CharSequence_;

		// Token: 0x04000067 RID: 103
		private IntPtr id_setContentDescription_Ljava_lang_CharSequence_;

		// Token: 0x04000068 RID: 104
		private static Delegate cb_setIconTintList_Landroid_content_res_ColorStateList_;

		// Token: 0x04000069 RID: 105
		private IntPtr id_setIconTintList_Landroid_content_res_ColorStateList_;

		// Token: 0x0400006A RID: 106
		private static Delegate cb_setIconTintMode_Landroid_graphics_PorterDuff_Mode_;

		// Token: 0x0400006B RID: 107
		private IntPtr id_setIconTintMode_Landroid_graphics_PorterDuff_Mode_;

		// Token: 0x0400006C RID: 108
		private static Delegate cb_setNumericShortcut_CI;

		// Token: 0x0400006D RID: 109
		private IntPtr id_setNumericShortcut_CI;

		// Token: 0x0400006E RID: 110
		private static Delegate cb_setShortcut_CCII;

		// Token: 0x0400006F RID: 111
		private IntPtr id_setShortcut_CCII;

		// Token: 0x04000070 RID: 112
		private static Delegate cb_setShowAsAction_I;

		// Token: 0x04000071 RID: 113
		private IntPtr id_setShowAsAction_I;

		// Token: 0x04000072 RID: 114
		private static Delegate cb_setShowAsActionFlags_I;

		// Token: 0x04000073 RID: 115
		private IntPtr id_setShowAsActionFlags_I;

		// Token: 0x04000074 RID: 116
		private static Delegate cb_setSupportActionProvider_Landroidx_core_view_ActionProvider_;

		// Token: 0x04000075 RID: 117
		private IntPtr id_setSupportActionProvider_Landroidx_core_view_ActionProvider_;

		// Token: 0x04000076 RID: 118
		private static Delegate cb_setTooltipText_Ljava_lang_CharSequence_;

		// Token: 0x04000077 RID: 119
		private IntPtr id_setTooltipText_Ljava_lang_CharSequence_;

		// Token: 0x04000078 RID: 120
		private static Delegate cb_getActionProvider;

		// Token: 0x04000079 RID: 121
		private IntPtr id_getActionProvider;

		// Token: 0x0400007A RID: 122
		private static Delegate cb_getAlphabeticShortcut;

		// Token: 0x0400007B RID: 123
		private IntPtr id_getAlphabeticShortcut;

		// Token: 0x0400007C RID: 124
		private static Delegate cb_getGroupId;

		// Token: 0x0400007D RID: 125
		private IntPtr id_getGroupId;

		// Token: 0x0400007E RID: 126
		private static Delegate cb_hasSubMenu;

		// Token: 0x0400007F RID: 127
		private IntPtr id_hasSubMenu;

		// Token: 0x04000080 RID: 128
		private static Delegate cb_getIcon;

		// Token: 0x04000081 RID: 129
		private IntPtr id_getIcon;

		// Token: 0x04000082 RID: 130
		private static Delegate cb_getIntent;

		// Token: 0x04000083 RID: 131
		private IntPtr id_getIntent;

		// Token: 0x04000084 RID: 132
		private static Delegate cb_isCheckable;

		// Token: 0x04000085 RID: 133
		private IntPtr id_isCheckable;

		// Token: 0x04000086 RID: 134
		private static Delegate cb_isChecked;

		// Token: 0x04000087 RID: 135
		private IntPtr id_isChecked;

		// Token: 0x04000088 RID: 136
		private static Delegate cb_isEnabled;

		// Token: 0x04000089 RID: 137
		private IntPtr id_isEnabled;

		// Token: 0x0400008A RID: 138
		private static Delegate cb_isVisible;

		// Token: 0x0400008B RID: 139
		private IntPtr id_isVisible;

		// Token: 0x0400008C RID: 140
		private static Delegate cb_getItemId;

		// Token: 0x0400008D RID: 141
		private IntPtr id_getItemId;

		// Token: 0x0400008E RID: 142
		private static Delegate cb_getMenuInfo;

		// Token: 0x0400008F RID: 143
		private IntPtr id_getMenuInfo;

		// Token: 0x04000090 RID: 144
		private static Delegate cb_getNumericShortcut;

		// Token: 0x04000091 RID: 145
		private IntPtr id_getNumericShortcut;

		// Token: 0x04000092 RID: 146
		private static Delegate cb_getOrder;

		// Token: 0x04000093 RID: 147
		private IntPtr id_getOrder;

		// Token: 0x04000094 RID: 148
		private static Delegate cb_getSubMenu;

		// Token: 0x04000095 RID: 149
		private IntPtr id_getSubMenu;

		// Token: 0x04000096 RID: 150
		private static Delegate cb_getTitle;

		// Token: 0x04000097 RID: 151
		private IntPtr id_getTitle;

		// Token: 0x04000098 RID: 152
		private static Delegate cb_getTitleCondensed;

		// Token: 0x04000099 RID: 153
		private IntPtr id_getTitleCondensed;

		// Token: 0x0400009A RID: 154
		private static Delegate cb_setActionProvider_Landroid_view_ActionProvider_;

		// Token: 0x0400009B RID: 155
		private IntPtr id_setActionProvider_Landroid_view_ActionProvider_;

		// Token: 0x0400009C RID: 156
		private static Delegate cb_setAlphabeticShortcut_C;

		// Token: 0x0400009D RID: 157
		private IntPtr id_setAlphabeticShortcut_C;

		// Token: 0x0400009E RID: 158
		private static Delegate cb_setCheckable_Z;

		// Token: 0x0400009F RID: 159
		private IntPtr id_setCheckable_Z;

		// Token: 0x040000A0 RID: 160
		private static Delegate cb_setChecked_Z;

		// Token: 0x040000A1 RID: 161
		private IntPtr id_setChecked_Z;

		// Token: 0x040000A2 RID: 162
		private static Delegate cb_setEnabled_Z;

		// Token: 0x040000A3 RID: 163
		private IntPtr id_setEnabled_Z;

		// Token: 0x040000A4 RID: 164
		private static Delegate cb_setIcon_Landroid_graphics_drawable_Drawable_;

		// Token: 0x040000A5 RID: 165
		private IntPtr id_setIcon_Landroid_graphics_drawable_Drawable_;

		// Token: 0x040000A6 RID: 166
		private static Delegate cb_setIcon_I;

		// Token: 0x040000A7 RID: 167
		private IntPtr id_setIcon_I;

		// Token: 0x040000A8 RID: 168
		private static Delegate cb_setIntent_Landroid_content_Intent_;

		// Token: 0x040000A9 RID: 169
		private IntPtr id_setIntent_Landroid_content_Intent_;

		// Token: 0x040000AA RID: 170
		private static Delegate cb_setNumericShortcut_C;

		// Token: 0x040000AB RID: 171
		private IntPtr id_setNumericShortcut_C;

		// Token: 0x040000AC RID: 172
		private static Delegate cb_setOnActionExpandListener_Landroid_view_MenuItem_OnActionExpandListener_;

		// Token: 0x040000AD RID: 173
		private IntPtr id_setOnActionExpandListener_Landroid_view_MenuItem_OnActionExpandListener_;

		// Token: 0x040000AE RID: 174
		private static Delegate cb_setOnMenuItemClickListener_Landroid_view_MenuItem_OnMenuItemClickListener_;

		// Token: 0x040000AF RID: 175
		private IntPtr id_setOnMenuItemClickListener_Landroid_view_MenuItem_OnMenuItemClickListener_;

		// Token: 0x040000B0 RID: 176
		private static Delegate cb_setShortcut_CC;

		// Token: 0x040000B1 RID: 177
		private IntPtr id_setShortcut_CC;

		// Token: 0x040000B2 RID: 178
		private static Delegate cb_setTitle_I;

		// Token: 0x040000B3 RID: 179
		private IntPtr id_setTitle_I;

		// Token: 0x040000B4 RID: 180
		private static Delegate cb_setTitle_Ljava_lang_CharSequence_;

		// Token: 0x040000B5 RID: 181
		private IntPtr id_setTitle_Ljava_lang_CharSequence_;

		// Token: 0x040000B6 RID: 182
		private static Delegate cb_setTitleCondensed_Ljava_lang_CharSequence_;

		// Token: 0x040000B7 RID: 183
		private IntPtr id_setTitleCondensed_Ljava_lang_CharSequence_;

		// Token: 0x040000B8 RID: 184
		private static Delegate cb_setVisible_Z;

		// Token: 0x040000B9 RID: 185
		private IntPtr id_setVisible_Z;
	}
}
