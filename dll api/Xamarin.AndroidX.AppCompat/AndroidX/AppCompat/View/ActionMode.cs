using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Android.Views;
using Java.Interop;
using Java.Lang;

namespace AndroidX.AppCompat.View
{
	// Token: 0x02000088 RID: 136
	[Register("androidx/appcompat/view/ActionMode", DoNotGenerateAcw = true)]
	public abstract class ActionMode : Java.Lang.Object
	{
		// Token: 0x17000160 RID: 352
		// (get) Token: 0x0600096C RID: 2412 RVA: 0x00018918 File Offset: 0x00016B18
		internal static IntPtr class_ref
		{
			get
			{
				return ActionMode._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x0600096D RID: 2413 RVA: 0x0001893C File Offset: 0x00016B3C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ActionMode._members;
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x0600096E RID: 2414 RVA: 0x00018944 File Offset: 0x00016B44
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ActionMode._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x0600096F RID: 2415 RVA: 0x00018968 File Offset: 0x00016B68
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ActionMode._members.ManagedPeerType;
			}
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x000039D4 File Offset: 0x00001BD4
		protected ActionMode(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x00018974 File Offset: 0x00016B74
		[Register(".ctor", "()V", "")]
		public ActionMode() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(ActionMode._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			ActionMode._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000972 RID: 2418 RVA: 0x000189E2 File Offset: 0x00016BE2
		private static Delegate GetGetCustomViewHandler()
		{
			if (ActionMode.cb_getCustomView == null)
			{
				ActionMode.cb_getCustomView = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ActionMode.n_GetCustomView));
			}
			return ActionMode.cb_getCustomView;
		}

		// Token: 0x06000973 RID: 2419 RVA: 0x00018A06 File Offset: 0x00016C06
		private static IntPtr n_GetCustomView(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ActionMode>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CustomView);
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x00018A1A File Offset: 0x00016C1A
		private static Delegate GetSetCustomView_Landroid_view_View_Handler()
		{
			if (ActionMode.cb_setCustomView_Landroid_view_View_ == null)
			{
				ActionMode.cb_setCustomView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ActionMode.n_SetCustomView_Landroid_view_View_));
			}
			return ActionMode.cb_setCustomView_Landroid_view_View_;
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x00018A40 File Offset: 0x00016C40
		private static void n_SetCustomView_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ActionMode @object = Java.Lang.Object.GetObject<ActionMode>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.CustomView = object2;
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000976 RID: 2422
		// (set) Token: 0x06000977 RID: 2423
		public abstract View CustomView { [Register("getCustomView", "()Landroid/view/View;", "GetGetCustomViewHandler")] get; [Register("setCustomView", "(Landroid/view/View;)V", "GetSetCustomView_Landroid_view_View_Handler")] set; }

		// Token: 0x06000978 RID: 2424 RVA: 0x00018A63 File Offset: 0x00016C63
		private static Delegate GetIsTitleOptionalHandler()
		{
			if (ActionMode.cb_isTitleOptional == null)
			{
				ActionMode.cb_isTitleOptional = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ActionMode.n_IsTitleOptional));
			}
			return ActionMode.cb_isTitleOptional;
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x00018A87 File Offset: 0x00016C87
		private static bool n_IsTitleOptional(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ActionMode>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsTitleOptional;
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x0600097A RID: 2426 RVA: 0x00018A96 File Offset: 0x00016C96
		public virtual bool IsTitleOptional
		{
			[Register("isTitleOptional", "()Z", "GetIsTitleOptionalHandler")]
			get
			{
				return ActionMode._members.InstanceMethods.InvokeVirtualBooleanMethod("isTitleOptional.()Z", this, null);
			}
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x00018AAF File Offset: 0x00016CAF
		private static Delegate GetIsUiFocusableHandler()
		{
			if (ActionMode.cb_isUiFocusable == null)
			{
				ActionMode.cb_isUiFocusable = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ActionMode.n_IsUiFocusable));
			}
			return ActionMode.cb_isUiFocusable;
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x00018AD3 File Offset: 0x00016CD3
		private static bool n_IsUiFocusable(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ActionMode>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsUiFocusable;
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x0600097D RID: 2429 RVA: 0x00018AE2 File Offset: 0x00016CE2
		public virtual bool IsUiFocusable
		{
			[Register("isUiFocusable", "()Z", "GetIsUiFocusableHandler")]
			get
			{
				return ActionMode._members.InstanceMethods.InvokeVirtualBooleanMethod("isUiFocusable.()Z", this, null);
			}
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x00018AFB File Offset: 0x00016CFB
		private static Delegate GetGetMenuHandler()
		{
			if (ActionMode.cb_getMenu == null)
			{
				ActionMode.cb_getMenu = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ActionMode.n_GetMenu));
			}
			return ActionMode.cb_getMenu;
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x00018B1F File Offset: 0x00016D1F
		private static IntPtr n_GetMenu(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ActionMode>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Menu);
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000980 RID: 2432
		public abstract IMenu Menu { [Register("getMenu", "()Landroid/view/Menu;", "GetGetMenuHandler")] get; }

		// Token: 0x06000981 RID: 2433 RVA: 0x00018B33 File Offset: 0x00016D33
		private static Delegate GetGetMenuInflaterHandler()
		{
			if (ActionMode.cb_getMenuInflater == null)
			{
				ActionMode.cb_getMenuInflater = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ActionMode.n_GetMenuInflater));
			}
			return ActionMode.cb_getMenuInflater;
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x00018B57 File Offset: 0x00016D57
		private static IntPtr n_GetMenuInflater(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ActionMode>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MenuInflater);
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000983 RID: 2435
		public abstract MenuInflater MenuInflater { [Register("getMenuInflater", "()Landroid/view/MenuInflater;", "GetGetMenuInflaterHandler")] get; }

		// Token: 0x06000984 RID: 2436 RVA: 0x00018B6B File Offset: 0x00016D6B
		private static Delegate GetGetSubtitleHandler()
		{
			if (ActionMode.cb_getSubtitle == null)
			{
				ActionMode.cb_getSubtitle = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ActionMode.n_GetSubtitle));
			}
			return ActionMode.cb_getSubtitle;
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x00018B8F File Offset: 0x00016D8F
		private static IntPtr n_GetSubtitle(IntPtr jnienv, IntPtr native__this)
		{
			return CharSequence.ToLocalJniHandle(Java.Lang.Object.GetObject<ActionMode>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SubtitleFormatted);
		}

		// Token: 0x06000986 RID: 2438 RVA: 0x00018BA3 File Offset: 0x00016DA3
		private static Delegate GetSetSubtitle_Ljava_lang_CharSequence_Handler()
		{
			if (ActionMode.cb_setSubtitle_Ljava_lang_CharSequence_ == null)
			{
				ActionMode.cb_setSubtitle_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ActionMode.n_SetSubtitle_Ljava_lang_CharSequence_));
			}
			return ActionMode.cb_setSubtitle_Ljava_lang_CharSequence_;
		}

		// Token: 0x06000987 RID: 2439 RVA: 0x00018BC8 File Offset: 0x00016DC8
		private static void n_SetSubtitle_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ActionMode @object = Java.Lang.Object.GetObject<ActionMode>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.SubtitleFormatted = object2;
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000988 RID: 2440
		// (set) Token: 0x06000989 RID: 2441
		public abstract ICharSequence SubtitleFormatted { [Register("getSubtitle", "()Ljava/lang/CharSequence;", "GetGetSubtitleHandler")] get; [Register("setSubtitle", "(Ljava/lang/CharSequence;)V", "GetSetSubtitle_Ljava_lang_CharSequence_Handler")] set; }

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x0600098A RID: 2442 RVA: 0x00018BEB File Offset: 0x00016DEB
		// (set) Token: 0x0600098B RID: 2443 RVA: 0x00018C04 File Offset: 0x00016E04
		public string Subtitle
		{
			get
			{
				if (this.SubtitleFormatted != null)
				{
					return this.SubtitleFormatted.ToString();
				}
				return null;
			}
			set
			{
				Java.Lang.String @string = (value == null) ? null : new Java.Lang.String(value);
				this.SubtitleFormatted = @string;
				if (@string != null)
				{
					@string.Dispose();
				}
			}
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x00018C2E File Offset: 0x00016E2E
		private static Delegate GetGetTagHandler()
		{
			if (ActionMode.cb_getTag == null)
			{
				ActionMode.cb_getTag = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ActionMode.n_GetTag));
			}
			return ActionMode.cb_getTag;
		}

		// Token: 0x0600098D RID: 2445 RVA: 0x00018C52 File Offset: 0x00016E52
		private static IntPtr n_GetTag(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ActionMode>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Tag);
		}

		// Token: 0x0600098E RID: 2446 RVA: 0x00018C66 File Offset: 0x00016E66
		private static Delegate GetSetTag_Ljava_lang_Object_Handler()
		{
			if (ActionMode.cb_setTag_Ljava_lang_Object_ == null)
			{
				ActionMode.cb_setTag_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ActionMode.n_SetTag_Ljava_lang_Object_));
			}
			return ActionMode.cb_setTag_Ljava_lang_Object_;
		}

		// Token: 0x0600098F RID: 2447 RVA: 0x00018C8C File Offset: 0x00016E8C
		private static void n_SetTag_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_tag)
		{
			ActionMode @object = Java.Lang.Object.GetObject<ActionMode>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_tag, JniHandleOwnership.DoNotTransfer);
			@object.Tag = object2;
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000990 RID: 2448 RVA: 0x00018CB0 File Offset: 0x00016EB0
		// (set) Token: 0x06000991 RID: 2449 RVA: 0x00018CE4 File Offset: 0x00016EE4
		public unsafe virtual Java.Lang.Object Tag
		{
			[Register("getTag", "()Ljava/lang/Object;", "GetGetTagHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Java.Lang.Object>(ActionMode._members.InstanceMethods.InvokeVirtualObjectMethod("getTag.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setTag", "(Ljava/lang/Object;)V", "GetSetTag_Ljava_lang_Object_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					ActionMode._members.InstanceMethods.InvokeVirtualVoidMethod("setTag.(Ljava/lang/Object;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x00018D48 File Offset: 0x00016F48
		private static Delegate GetGetTitleHandler()
		{
			if (ActionMode.cb_getTitle == null)
			{
				ActionMode.cb_getTitle = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ActionMode.n_GetTitle));
			}
			return ActionMode.cb_getTitle;
		}

		// Token: 0x06000993 RID: 2451 RVA: 0x00018D6C File Offset: 0x00016F6C
		private static IntPtr n_GetTitle(IntPtr jnienv, IntPtr native__this)
		{
			return CharSequence.ToLocalJniHandle(Java.Lang.Object.GetObject<ActionMode>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TitleFormatted);
		}

		// Token: 0x06000994 RID: 2452 RVA: 0x00018D80 File Offset: 0x00016F80
		private static Delegate GetSetTitle_Ljava_lang_CharSequence_Handler()
		{
			if (ActionMode.cb_setTitle_Ljava_lang_CharSequence_ == null)
			{
				ActionMode.cb_setTitle_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ActionMode.n_SetTitle_Ljava_lang_CharSequence_));
			}
			return ActionMode.cb_setTitle_Ljava_lang_CharSequence_;
		}

		// Token: 0x06000995 RID: 2453 RVA: 0x00018DA4 File Offset: 0x00016FA4
		private static void n_SetTitle_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ActionMode @object = Java.Lang.Object.GetObject<ActionMode>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.TitleFormatted = object2;
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000996 RID: 2454
		// (set) Token: 0x06000997 RID: 2455
		public abstract ICharSequence TitleFormatted { [Register("getTitle", "()Ljava/lang/CharSequence;", "GetGetTitleHandler")] get; [Register("setTitle", "(Ljava/lang/CharSequence;)V", "GetSetTitle_Ljava_lang_CharSequence_Handler")] set; }

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000998 RID: 2456 RVA: 0x00018DC7 File Offset: 0x00016FC7
		// (set) Token: 0x06000999 RID: 2457 RVA: 0x00018DE0 File Offset: 0x00016FE0
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

		// Token: 0x0600099A RID: 2458 RVA: 0x00018E0A File Offset: 0x0001700A
		private static Delegate GetGetTitleOptionalHintHandler()
		{
			if (ActionMode.cb_getTitleOptionalHint == null)
			{
				ActionMode.cb_getTitleOptionalHint = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ActionMode.n_GetTitleOptionalHint));
			}
			return ActionMode.cb_getTitleOptionalHint;
		}

		// Token: 0x0600099B RID: 2459 RVA: 0x00018E2E File Offset: 0x0001702E
		private static bool n_GetTitleOptionalHint(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ActionMode>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TitleOptionalHint;
		}

		// Token: 0x0600099C RID: 2460 RVA: 0x00018E3D File Offset: 0x0001703D
		private static Delegate GetSetTitleOptionalHint_ZHandler()
		{
			if (ActionMode.cb_setTitleOptionalHint_Z == null)
			{
				ActionMode.cb_setTitleOptionalHint_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(ActionMode.n_SetTitleOptionalHint_Z));
			}
			return ActionMode.cb_setTitleOptionalHint_Z;
		}

		// Token: 0x0600099D RID: 2461 RVA: 0x00018E61 File Offset: 0x00017061
		private static void n_SetTitleOptionalHint_Z(IntPtr jnienv, IntPtr native__this, bool titleOptional)
		{
			Java.Lang.Object.GetObject<ActionMode>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TitleOptionalHint = titleOptional;
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x0600099E RID: 2462 RVA: 0x00018E71 File Offset: 0x00017071
		// (set) Token: 0x0600099F RID: 2463 RVA: 0x00018E8C File Offset: 0x0001708C
		public unsafe virtual bool TitleOptionalHint
		{
			[Register("getTitleOptionalHint", "()Z", "GetGetTitleOptionalHintHandler")]
			get
			{
				return ActionMode._members.InstanceMethods.InvokeVirtualBooleanMethod("getTitleOptionalHint.()Z", this, null);
			}
			[Register("setTitleOptionalHint", "(Z)V", "GetSetTitleOptionalHint_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				ActionMode._members.InstanceMethods.InvokeVirtualVoidMethod("setTitleOptionalHint.(Z)V", this, ptr);
			}
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x00018EC7 File Offset: 0x000170C7
		private static Delegate GetFinishHandler()
		{
			if (ActionMode.cb_finish == null)
			{
				ActionMode.cb_finish = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ActionMode.n_Finish));
			}
			return ActionMode.cb_finish;
		}

		// Token: 0x060009A1 RID: 2465 RVA: 0x00018EEB File Offset: 0x000170EB
		private static void n_Finish(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<ActionMode>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Finish();
		}

		// Token: 0x060009A2 RID: 2466
		[Register("finish", "()V", "GetFinishHandler")]
		public abstract void Finish();

		// Token: 0x060009A3 RID: 2467 RVA: 0x00018EFA File Offset: 0x000170FA
		private static Delegate GetInvalidateHandler()
		{
			if (ActionMode.cb_invalidate == null)
			{
				ActionMode.cb_invalidate = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ActionMode.n_Invalidate));
			}
			return ActionMode.cb_invalidate;
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x00018F1E File Offset: 0x0001711E
		private static void n_Invalidate(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<ActionMode>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Invalidate();
		}

		// Token: 0x060009A5 RID: 2469
		[Register("invalidate", "()V", "GetInvalidateHandler")]
		public abstract void Invalidate();

		// Token: 0x060009A6 RID: 2470 RVA: 0x00018F2D File Offset: 0x0001712D
		private static Delegate GetSetSubtitle_IHandler()
		{
			if (ActionMode.cb_setSubtitle_I == null)
			{
				ActionMode.cb_setSubtitle_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(ActionMode.n_SetSubtitle_I));
			}
			return ActionMode.cb_setSubtitle_I;
		}

		// Token: 0x060009A7 RID: 2471 RVA: 0x00018F51 File Offset: 0x00017151
		private static void n_SetSubtitle_I(IntPtr jnienv, IntPtr native__this, int resId)
		{
			Java.Lang.Object.GetObject<ActionMode>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetSubtitle(resId);
		}

		// Token: 0x060009A8 RID: 2472
		[Register("setSubtitle", "(I)V", "GetSetSubtitle_IHandler")]
		public abstract void SetSubtitle(int resId);

		// Token: 0x060009A9 RID: 2473 RVA: 0x00018F61 File Offset: 0x00017161
		private static Delegate GetSetTitle_IHandler()
		{
			if (ActionMode.cb_setTitle_I == null)
			{
				ActionMode.cb_setTitle_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(ActionMode.n_SetTitle_I));
			}
			return ActionMode.cb_setTitle_I;
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x00018F85 File Offset: 0x00017185
		private static void n_SetTitle_I(IntPtr jnienv, IntPtr native__this, int resId)
		{
			Java.Lang.Object.GetObject<ActionMode>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetTitle(resId);
		}

		// Token: 0x060009AB RID: 2475
		[Register("setTitle", "(I)V", "GetSetTitle_IHandler")]
		public abstract void SetTitle(int resId);

		// Token: 0x040002C7 RID: 711
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/appcompat/view/ActionMode", typeof(ActionMode));

		// Token: 0x040002C8 RID: 712
		private static Delegate cb_getCustomView;

		// Token: 0x040002C9 RID: 713
		private static Delegate cb_setCustomView_Landroid_view_View_;

		// Token: 0x040002CA RID: 714
		private static Delegate cb_isTitleOptional;

		// Token: 0x040002CB RID: 715
		private static Delegate cb_isUiFocusable;

		// Token: 0x040002CC RID: 716
		private static Delegate cb_getMenu;

		// Token: 0x040002CD RID: 717
		private static Delegate cb_getMenuInflater;

		// Token: 0x040002CE RID: 718
		private static Delegate cb_getSubtitle;

		// Token: 0x040002CF RID: 719
		private static Delegate cb_setSubtitle_Ljava_lang_CharSequence_;

		// Token: 0x040002D0 RID: 720
		private static Delegate cb_getTag;

		// Token: 0x040002D1 RID: 721
		private static Delegate cb_setTag_Ljava_lang_Object_;

		// Token: 0x040002D2 RID: 722
		private static Delegate cb_getTitle;

		// Token: 0x040002D3 RID: 723
		private static Delegate cb_setTitle_Ljava_lang_CharSequence_;

		// Token: 0x040002D4 RID: 724
		private static Delegate cb_getTitleOptionalHint;

		// Token: 0x040002D5 RID: 725
		private static Delegate cb_setTitleOptionalHint_Z;

		// Token: 0x040002D6 RID: 726
		private static Delegate cb_finish;

		// Token: 0x040002D7 RID: 727
		private static Delegate cb_invalidate;

		// Token: 0x040002D8 RID: 728
		private static Delegate cb_setSubtitle_I;

		// Token: 0x040002D9 RID: 729
		private static Delegate cb_setTitle_I;

		// Token: 0x02000089 RID: 137
		[Register("androidx/appcompat/view/ActionMode$Callback", "", "AndroidX.AppCompat.View.ActionMode/ICallbackInvoker")]
		public interface ICallback : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x060009AD RID: 2477
			[Register("onActionItemClicked", "(Landroidx/appcompat/view/ActionMode;Landroid/view/MenuItem;)Z", "GetOnActionItemClicked_Landroidx_appcompat_view_ActionMode_Landroid_view_MenuItem_Handler:AndroidX.AppCompat.View.ActionMode/ICallbackInvoker, Xamarin.AndroidX.AppCompat")]
			bool OnActionItemClicked(ActionMode mode, IMenuItem item);

			// Token: 0x060009AE RID: 2478
			[Register("onCreateActionMode", "(Landroidx/appcompat/view/ActionMode;Landroid/view/Menu;)Z", "GetOnCreateActionMode_Landroidx_appcompat_view_ActionMode_Landroid_view_Menu_Handler:AndroidX.AppCompat.View.ActionMode/ICallbackInvoker, Xamarin.AndroidX.AppCompat")]
			bool OnCreateActionMode(ActionMode mode, IMenu menu);

			// Token: 0x060009AF RID: 2479
			[Register("onDestroyActionMode", "(Landroidx/appcompat/view/ActionMode;)V", "GetOnDestroyActionMode_Landroidx_appcompat_view_ActionMode_Handler:AndroidX.AppCompat.View.ActionMode/ICallbackInvoker, Xamarin.AndroidX.AppCompat")]
			void OnDestroyActionMode(ActionMode mode);

			// Token: 0x060009B0 RID: 2480
			[Register("onPrepareActionMode", "(Landroidx/appcompat/view/ActionMode;Landroid/view/Menu;)Z", "GetOnPrepareActionMode_Landroidx_appcompat_view_ActionMode_Landroid_view_Menu_Handler:AndroidX.AppCompat.View.ActionMode/ICallbackInvoker, Xamarin.AndroidX.AppCompat")]
			bool OnPrepareActionMode(ActionMode mode, IMenu menu);
		}

		// Token: 0x0200008A RID: 138
		[Register("androidx/appcompat/view/ActionMode$Callback", DoNotGenerateAcw = true)]
		internal class ICallbackInvoker : Java.Lang.Object, ActionMode.ICallback, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x1700016F RID: 367
			// (get) Token: 0x060009B1 RID: 2481 RVA: 0x00018FB0 File Offset: 0x000171B0
			private static IntPtr java_class_ref
			{
				get
				{
					return ActionMode.ICallbackInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000170 RID: 368
			// (get) Token: 0x060009B2 RID: 2482 RVA: 0x00018FD4 File Offset: 0x000171D4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ActionMode.ICallbackInvoker._members;
				}
			}

			// Token: 0x17000171 RID: 369
			// (get) Token: 0x060009B3 RID: 2483 RVA: 0x00018FDB File Offset: 0x000171DB
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x17000172 RID: 370
			// (get) Token: 0x060009B4 RID: 2484 RVA: 0x00018FE3 File Offset: 0x000171E3
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ActionMode.ICallbackInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x060009B5 RID: 2485 RVA: 0x00018FEF File Offset: 0x000171EF
			public static ActionMode.ICallback GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<ActionMode.ICallback>(handle, transfer);
			}

			// Token: 0x060009B6 RID: 2486 RVA: 0x00018FF8 File Offset: 0x000171F8
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, ActionMode.ICallbackInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.appcompat.view.ActionMode.Callback'.");
				}
				return handle;
			}

			// Token: 0x060009B7 RID: 2487 RVA: 0x00019023 File Offset: 0x00017223
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x060009B8 RID: 2488 RVA: 0x00019054 File Offset: 0x00017254
			public ICallbackInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ActionMode.ICallbackInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x060009B9 RID: 2489 RVA: 0x0001908C File Offset: 0x0001728C
			private static Delegate GetOnActionItemClicked_Landroidx_appcompat_view_ActionMode_Landroid_view_MenuItem_Handler()
			{
				if (ActionMode.ICallbackInvoker.cb_onActionItemClicked_Landroidx_appcompat_view_ActionMode_Landroid_view_MenuItem_ == null)
				{
					ActionMode.ICallbackInvoker.cb_onActionItemClicked_Landroidx_appcompat_view_ActionMode_Landroid_view_MenuItem_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_Z(ActionMode.ICallbackInvoker.n_OnActionItemClicked_Landroidx_appcompat_view_ActionMode_Landroid_view_MenuItem_));
				}
				return ActionMode.ICallbackInvoker.cb_onActionItemClicked_Landroidx_appcompat_view_ActionMode_Landroid_view_MenuItem_;
			}

			// Token: 0x060009BA RID: 2490 RVA: 0x000190B0 File Offset: 0x000172B0
			private static bool n_OnActionItemClicked_Landroidx_appcompat_view_ActionMode_Landroid_view_MenuItem_(IntPtr jnienv, IntPtr native__this, IntPtr native_mode, IntPtr native_item)
			{
				ActionMode.ICallback @object = Java.Lang.Object.GetObject<ActionMode.ICallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				ActionMode object2 = Java.Lang.Object.GetObject<ActionMode>(native_mode, JniHandleOwnership.DoNotTransfer);
				IMenuItem object3 = Java.Lang.Object.GetObject<IMenuItem>(native_item, JniHandleOwnership.DoNotTransfer);
				return @object.OnActionItemClicked(object2, object3);
			}

			// Token: 0x060009BB RID: 2491 RVA: 0x000190DC File Offset: 0x000172DC
			public unsafe bool OnActionItemClicked(ActionMode mode, IMenuItem item)
			{
				if (this.id_onActionItemClicked_Landroidx_appcompat_view_ActionMode_Landroid_view_MenuItem_ == IntPtr.Zero)
				{
					this.id_onActionItemClicked_Landroidx_appcompat_view_ActionMode_Landroid_view_MenuItem_ = JNIEnv.GetMethodID(this.class_ref, "onActionItemClicked", "(Landroidx/appcompat/view/ActionMode;Landroid/view/MenuItem;)Z");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((mode == null) ? IntPtr.Zero : mode.Handle);
				ptr[1] = new JValue((item == null) ? IntPtr.Zero : ((Java.Lang.Object)item).Handle);
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_onActionItemClicked_Landroidx_appcompat_view_ActionMode_Landroid_view_MenuItem_, ptr);
			}

			// Token: 0x060009BC RID: 2492 RVA: 0x00019176 File Offset: 0x00017376
			private static Delegate GetOnCreateActionMode_Landroidx_appcompat_view_ActionMode_Landroid_view_Menu_Handler()
			{
				if (ActionMode.ICallbackInvoker.cb_onCreateActionMode_Landroidx_appcompat_view_ActionMode_Landroid_view_Menu_ == null)
				{
					ActionMode.ICallbackInvoker.cb_onCreateActionMode_Landroidx_appcompat_view_ActionMode_Landroid_view_Menu_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_Z(ActionMode.ICallbackInvoker.n_OnCreateActionMode_Landroidx_appcompat_view_ActionMode_Landroid_view_Menu_));
				}
				return ActionMode.ICallbackInvoker.cb_onCreateActionMode_Landroidx_appcompat_view_ActionMode_Landroid_view_Menu_;
			}

			// Token: 0x060009BD RID: 2493 RVA: 0x0001919C File Offset: 0x0001739C
			private static bool n_OnCreateActionMode_Landroidx_appcompat_view_ActionMode_Landroid_view_Menu_(IntPtr jnienv, IntPtr native__this, IntPtr native_mode, IntPtr native_menu)
			{
				ActionMode.ICallback @object = Java.Lang.Object.GetObject<ActionMode.ICallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				ActionMode object2 = Java.Lang.Object.GetObject<ActionMode>(native_mode, JniHandleOwnership.DoNotTransfer);
				IMenu object3 = Java.Lang.Object.GetObject<IMenu>(native_menu, JniHandleOwnership.DoNotTransfer);
				return @object.OnCreateActionMode(object2, object3);
			}

			// Token: 0x060009BE RID: 2494 RVA: 0x000191C8 File Offset: 0x000173C8
			public unsafe bool OnCreateActionMode(ActionMode mode, IMenu menu)
			{
				if (this.id_onCreateActionMode_Landroidx_appcompat_view_ActionMode_Landroid_view_Menu_ == IntPtr.Zero)
				{
					this.id_onCreateActionMode_Landroidx_appcompat_view_ActionMode_Landroid_view_Menu_ = JNIEnv.GetMethodID(this.class_ref, "onCreateActionMode", "(Landroidx/appcompat/view/ActionMode;Landroid/view/Menu;)Z");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((mode == null) ? IntPtr.Zero : mode.Handle);
				ptr[1] = new JValue((menu == null) ? IntPtr.Zero : ((Java.Lang.Object)menu).Handle);
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_onCreateActionMode_Landroidx_appcompat_view_ActionMode_Landroid_view_Menu_, ptr);
			}

			// Token: 0x060009BF RID: 2495 RVA: 0x00019262 File Offset: 0x00017462
			private static Delegate GetOnDestroyActionMode_Landroidx_appcompat_view_ActionMode_Handler()
			{
				if (ActionMode.ICallbackInvoker.cb_onDestroyActionMode_Landroidx_appcompat_view_ActionMode_ == null)
				{
					ActionMode.ICallbackInvoker.cb_onDestroyActionMode_Landroidx_appcompat_view_ActionMode_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ActionMode.ICallbackInvoker.n_OnDestroyActionMode_Landroidx_appcompat_view_ActionMode_));
				}
				return ActionMode.ICallbackInvoker.cb_onDestroyActionMode_Landroidx_appcompat_view_ActionMode_;
			}

			// Token: 0x060009C0 RID: 2496 RVA: 0x00019288 File Offset: 0x00017488
			private static void n_OnDestroyActionMode_Landroidx_appcompat_view_ActionMode_(IntPtr jnienv, IntPtr native__this, IntPtr native_mode)
			{
				ActionMode.ICallback @object = Java.Lang.Object.GetObject<ActionMode.ICallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				ActionMode object2 = Java.Lang.Object.GetObject<ActionMode>(native_mode, JniHandleOwnership.DoNotTransfer);
				@object.OnDestroyActionMode(object2);
			}

			// Token: 0x060009C1 RID: 2497 RVA: 0x000192AC File Offset: 0x000174AC
			public unsafe void OnDestroyActionMode(ActionMode mode)
			{
				if (this.id_onDestroyActionMode_Landroidx_appcompat_view_ActionMode_ == IntPtr.Zero)
				{
					this.id_onDestroyActionMode_Landroidx_appcompat_view_ActionMode_ = JNIEnv.GetMethodID(this.class_ref, "onDestroyActionMode", "(Landroidx/appcompat/view/ActionMode;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((mode == null) ? IntPtr.Zero : mode.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onDestroyActionMode_Landroidx_appcompat_view_ActionMode_, ptr);
			}

			// Token: 0x060009C2 RID: 2498 RVA: 0x0001931F File Offset: 0x0001751F
			private static Delegate GetOnPrepareActionMode_Landroidx_appcompat_view_ActionMode_Landroid_view_Menu_Handler()
			{
				if (ActionMode.ICallbackInvoker.cb_onPrepareActionMode_Landroidx_appcompat_view_ActionMode_Landroid_view_Menu_ == null)
				{
					ActionMode.ICallbackInvoker.cb_onPrepareActionMode_Landroidx_appcompat_view_ActionMode_Landroid_view_Menu_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_Z(ActionMode.ICallbackInvoker.n_OnPrepareActionMode_Landroidx_appcompat_view_ActionMode_Landroid_view_Menu_));
				}
				return ActionMode.ICallbackInvoker.cb_onPrepareActionMode_Landroidx_appcompat_view_ActionMode_Landroid_view_Menu_;
			}

			// Token: 0x060009C3 RID: 2499 RVA: 0x00019344 File Offset: 0x00017544
			private static bool n_OnPrepareActionMode_Landroidx_appcompat_view_ActionMode_Landroid_view_Menu_(IntPtr jnienv, IntPtr native__this, IntPtr native_mode, IntPtr native_menu)
			{
				ActionMode.ICallback @object = Java.Lang.Object.GetObject<ActionMode.ICallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				ActionMode object2 = Java.Lang.Object.GetObject<ActionMode>(native_mode, JniHandleOwnership.DoNotTransfer);
				IMenu object3 = Java.Lang.Object.GetObject<IMenu>(native_menu, JniHandleOwnership.DoNotTransfer);
				return @object.OnPrepareActionMode(object2, object3);
			}

			// Token: 0x060009C4 RID: 2500 RVA: 0x00019370 File Offset: 0x00017570
			public unsafe bool OnPrepareActionMode(ActionMode mode, IMenu menu)
			{
				if (this.id_onPrepareActionMode_Landroidx_appcompat_view_ActionMode_Landroid_view_Menu_ == IntPtr.Zero)
				{
					this.id_onPrepareActionMode_Landroidx_appcompat_view_ActionMode_Landroid_view_Menu_ = JNIEnv.GetMethodID(this.class_ref, "onPrepareActionMode", "(Landroidx/appcompat/view/ActionMode;Landroid/view/Menu;)Z");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((mode == null) ? IntPtr.Zero : mode.Handle);
				ptr[1] = new JValue((menu == null) ? IntPtr.Zero : ((Java.Lang.Object)menu).Handle);
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_onPrepareActionMode_Landroidx_appcompat_view_ActionMode_Landroid_view_Menu_, ptr);
			}

			// Token: 0x040002DA RID: 730
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/appcompat/view/ActionMode$Callback", typeof(ActionMode.ICallbackInvoker));

			// Token: 0x040002DB RID: 731
			private IntPtr class_ref;

			// Token: 0x040002DC RID: 732
			private static Delegate cb_onActionItemClicked_Landroidx_appcompat_view_ActionMode_Landroid_view_MenuItem_;

			// Token: 0x040002DD RID: 733
			private IntPtr id_onActionItemClicked_Landroidx_appcompat_view_ActionMode_Landroid_view_MenuItem_;

			// Token: 0x040002DE RID: 734
			private static Delegate cb_onCreateActionMode_Landroidx_appcompat_view_ActionMode_Landroid_view_Menu_;

			// Token: 0x040002DF RID: 735
			private IntPtr id_onCreateActionMode_Landroidx_appcompat_view_ActionMode_Landroid_view_Menu_;

			// Token: 0x040002E0 RID: 736
			private static Delegate cb_onDestroyActionMode_Landroidx_appcompat_view_ActionMode_;

			// Token: 0x040002E1 RID: 737
			private IntPtr id_onDestroyActionMode_Landroidx_appcompat_view_ActionMode_;

			// Token: 0x040002E2 RID: 738
			private static Delegate cb_onPrepareActionMode_Landroidx_appcompat_view_ActionMode_Landroid_view_Menu_;

			// Token: 0x040002E3 RID: 739
			private IntPtr id_onPrepareActionMode_Landroidx_appcompat_view_ActionMode_Landroid_view_Menu_;
		}
	}
}
