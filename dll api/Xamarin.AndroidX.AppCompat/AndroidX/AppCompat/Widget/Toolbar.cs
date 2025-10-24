using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Content;
using Android.Content.Res;
using Android.Graphics.Drawables;
using Android.Runtime;
using Android.Util;
using Android.Views;
using AndroidX.AppCompat.View.Menu;
using AndroidX.Core.View;
using AndroidX.Lifecycle;
using Java.Interop;
using Java.Lang;

namespace AndroidX.AppCompat.Widget
{
	// Token: 0x0200005B RID: 91
	[Register("androidx/appcompat/widget/Toolbar", DoNotGenerateAcw = true)]
	public class Toolbar : ViewGroup, IMenuHost, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000539 RID: 1337 RVA: 0x0000DEA8 File Offset: 0x0000C0A8
		internal Toolbar.NavigationOnClickEventDispatcher NavigationOnClickDispatcher
		{
			get
			{
				if (this.weakNavigationOnClickDispatcher == null || !this.weakNavigationOnClickDispatcher.IsAlive)
				{
					Toolbar.NavigationOnClickEventDispatcher navigationOnClickEventDispatcher = new Toolbar.NavigationOnClickEventDispatcher(this);
					this.SetNavigationOnClickListener(navigationOnClickEventDispatcher);
					this.weakNavigationOnClickDispatcher = new WeakReference(navigationOnClickEventDispatcher);
				}
				return (Toolbar.NavigationOnClickEventDispatcher)this.weakNavigationOnClickDispatcher.Target;
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x0600053A RID: 1338 RVA: 0x0000DEF4 File Offset: 0x0000C0F4
		// (remove) Token: 0x0600053B RID: 1339 RVA: 0x0000DF12 File Offset: 0x0000C112
		public event EventHandler<Toolbar.NavigationClickEventArgs> NavigationClick
		{
			add
			{
				Toolbar.NavigationOnClickEventDispatcher navigationOnClickDispatcher = this.NavigationOnClickDispatcher;
				navigationOnClickDispatcher.NavigationClick = (EventHandler<Toolbar.NavigationClickEventArgs>)Delegate.Combine(navigationOnClickDispatcher.NavigationClick, value);
			}
			remove
			{
				Toolbar.NavigationOnClickEventDispatcher navigationOnClickDispatcher = this.NavigationOnClickDispatcher;
				navigationOnClickDispatcher.NavigationClick = (EventHandler<Toolbar.NavigationClickEventArgs>)Delegate.Remove(navigationOnClickDispatcher.NavigationClick, value);
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x0600053C RID: 1340 RVA: 0x0000DF30 File Offset: 0x0000C130
		internal static IntPtr class_ref
		{
			get
			{
				return Toolbar._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x0600053D RID: 1341 RVA: 0x0000DF54 File Offset: 0x0000C154
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Toolbar._members;
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x0600053E RID: 1342 RVA: 0x0000DF5C File Offset: 0x0000C15C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Toolbar._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x0600053F RID: 1343 RVA: 0x0000DF80 File Offset: 0x0000C180
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Toolbar._members.ManagedPeerType;
			}
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x0000DF8C File Offset: 0x0000C18C
		protected Toolbar(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x0000DF98 File Offset: 0x0000C198
		[Register(".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe Toolbar(Context context) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				base.SetHandle(Toolbar._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				Toolbar._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x0000E048 File Offset: 0x0000C248
		[Register(".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe Toolbar(Context context, IAttributeSet attrs) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(Toolbar._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				Toolbar._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x0000E124 File Offset: 0x0000C324
		[Register(".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe Toolbar(Context context, IAttributeSet attrs, int defStyleAttr) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(Toolbar._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				Toolbar._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x0000E214 File Offset: 0x0000C414
		private static Delegate GetIsBackInvokedCallbackEnabledHandler()
		{
			if (Toolbar.cb_isBackInvokedCallbackEnabled == null)
			{
				Toolbar.cb_isBackInvokedCallbackEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(Toolbar.n_IsBackInvokedCallbackEnabled));
			}
			return Toolbar.cb_isBackInvokedCallbackEnabled;
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x0000E238 File Offset: 0x0000C438
		private static bool n_IsBackInvokedCallbackEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).BackInvokedCallbackEnabled;
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x0000E247 File Offset: 0x0000C447
		private static Delegate GetSetBackInvokedCallbackEnabled_ZHandler()
		{
			if (Toolbar.cb_setBackInvokedCallbackEnabled_Z == null)
			{
				Toolbar.cb_setBackInvokedCallbackEnabled_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(Toolbar.n_SetBackInvokedCallbackEnabled_Z));
			}
			return Toolbar.cb_setBackInvokedCallbackEnabled_Z;
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x0000E26B File Offset: 0x0000C46B
		private static void n_SetBackInvokedCallbackEnabled_Z(IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).BackInvokedCallbackEnabled = enabled;
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000548 RID: 1352 RVA: 0x0000E27B File Offset: 0x0000C47B
		// (set) Token: 0x06000549 RID: 1353 RVA: 0x0000E294 File Offset: 0x0000C494
		public unsafe virtual bool BackInvokedCallbackEnabled
		{
			[Register("isBackInvokedCallbackEnabled", "()Z", "GetIsBackInvokedCallbackEnabledHandler")]
			get
			{
				return Toolbar._members.InstanceMethods.InvokeVirtualBooleanMethod("isBackInvokedCallbackEnabled.()Z", this, null);
			}
			[Register("setBackInvokedCallbackEnabled", "(Z)V", "GetSetBackInvokedCallbackEnabled_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				Toolbar._members.InstanceMethods.InvokeVirtualVoidMethod("setBackInvokedCallbackEnabled.(Z)V", this, ptr);
			}
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x0000E2CF File Offset: 0x0000C4CF
		private static Delegate GetGetCollapseContentDescriptionHandler()
		{
			if (Toolbar.cb_getCollapseContentDescription == null)
			{
				Toolbar.cb_getCollapseContentDescription = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Toolbar.n_GetCollapseContentDescription));
			}
			return Toolbar.cb_getCollapseContentDescription;
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x0000E2F3 File Offset: 0x0000C4F3
		private static IntPtr n_GetCollapseContentDescription(IntPtr jnienv, IntPtr native__this)
		{
			return CharSequence.ToLocalJniHandle(Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CollapseContentDescriptionFormatted);
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x0000E307 File Offset: 0x0000C507
		private static Delegate GetSetCollapseContentDescription_Ljava_lang_CharSequence_Handler()
		{
			if (Toolbar.cb_setCollapseContentDescription_Ljava_lang_CharSequence_ == null)
			{
				Toolbar.cb_setCollapseContentDescription_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Toolbar.n_SetCollapseContentDescription_Ljava_lang_CharSequence_));
			}
			return Toolbar.cb_setCollapseContentDescription_Ljava_lang_CharSequence_;
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x0000E32C File Offset: 0x0000C52C
		private static void n_SetCollapseContentDescription_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_description)
		{
			Toolbar @object = Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_description, JniHandleOwnership.DoNotTransfer);
			@object.CollapseContentDescriptionFormatted = object2;
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x0600054E RID: 1358 RVA: 0x0000E350 File Offset: 0x0000C550
		// (set) Token: 0x0600054F RID: 1359 RVA: 0x0000E384 File Offset: 0x0000C584
		public unsafe virtual ICharSequence CollapseContentDescriptionFormatted
		{
			[Register("getCollapseContentDescription", "()Ljava/lang/CharSequence;", "GetGetCollapseContentDescriptionHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ICharSequence>(Toolbar._members.InstanceMethods.InvokeVirtualObjectMethod("getCollapseContentDescription.()Ljava/lang/CharSequence;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setCollapseContentDescription", "(Ljava/lang/CharSequence;)V", "GetSetCollapseContentDescription_Ljava_lang_CharSequence_Handler")]
			set
			{
				IntPtr intPtr = CharSequence.ToLocalJniHandle(value);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					Toolbar._members.InstanceMethods.InvokeVirtualVoidMethod("setCollapseContentDescription.(Ljava/lang/CharSequence;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000550 RID: 1360 RVA: 0x0000E3E8 File Offset: 0x0000C5E8
		// (set) Token: 0x06000551 RID: 1361 RVA: 0x0000E400 File Offset: 0x0000C600
		public string CollapseContentDescription
		{
			get
			{
				if (this.CollapseContentDescriptionFormatted != null)
				{
					return this.CollapseContentDescriptionFormatted.ToString();
				}
				return null;
			}
			set
			{
				Java.Lang.String @string = (value == null) ? null : new Java.Lang.String(value);
				this.CollapseContentDescriptionFormatted = @string;
				if (@string != null)
				{
					@string.Dispose();
				}
			}
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x0000E42A File Offset: 0x0000C62A
		private static Delegate GetGetCollapseIconHandler()
		{
			if (Toolbar.cb_getCollapseIcon == null)
			{
				Toolbar.cb_getCollapseIcon = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Toolbar.n_GetCollapseIcon));
			}
			return Toolbar.cb_getCollapseIcon;
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x0000E44E File Offset: 0x0000C64E
		private static IntPtr n_GetCollapseIcon(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CollapseIcon);
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x0000E462 File Offset: 0x0000C662
		private static Delegate GetSetCollapseIcon_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (Toolbar.cb_setCollapseIcon_Landroid_graphics_drawable_Drawable_ == null)
			{
				Toolbar.cb_setCollapseIcon_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Toolbar.n_SetCollapseIcon_Landroid_graphics_drawable_Drawable_));
			}
			return Toolbar.cb_setCollapseIcon_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x0000E488 File Offset: 0x0000C688
		private static void n_SetCollapseIcon_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_icon)
		{
			Toolbar @object = Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_icon, JniHandleOwnership.DoNotTransfer);
			@object.CollapseIcon = object2;
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000556 RID: 1366 RVA: 0x0000E4AC File Offset: 0x0000C6AC
		// (set) Token: 0x06000557 RID: 1367 RVA: 0x0000E4E0 File Offset: 0x0000C6E0
		public unsafe virtual Drawable CollapseIcon
		{
			[Register("getCollapseIcon", "()Landroid/graphics/drawable/Drawable;", "GetGetCollapseIconHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Drawable>(Toolbar._members.InstanceMethods.InvokeVirtualObjectMethod("getCollapseIcon.()Landroid/graphics/drawable/Drawable;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setCollapseIcon", "(Landroid/graphics/drawable/Drawable;)V", "GetSetCollapseIcon_Landroid_graphics_drawable_Drawable_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					Toolbar._members.InstanceMethods.InvokeVirtualVoidMethod("setCollapseIcon.(Landroid/graphics/drawable/Drawable;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x0000E544 File Offset: 0x0000C744
		private static Delegate GetGetContentInsetEndHandler()
		{
			if (Toolbar.cb_getContentInsetEnd == null)
			{
				Toolbar.cb_getContentInsetEnd = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(Toolbar.n_GetContentInsetEnd));
			}
			return Toolbar.cb_getContentInsetEnd;
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x0000E568 File Offset: 0x0000C768
		private static int n_GetContentInsetEnd(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ContentInsetEnd;
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x0600055A RID: 1370 RVA: 0x0000E577 File Offset: 0x0000C777
		public virtual int ContentInsetEnd
		{
			[Register("getContentInsetEnd", "()I", "GetGetContentInsetEndHandler")]
			get
			{
				return Toolbar._members.InstanceMethods.InvokeVirtualInt32Method("getContentInsetEnd.()I", this, null);
			}
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x0000E590 File Offset: 0x0000C790
		private static Delegate GetGetContentInsetEndWithActionsHandler()
		{
			if (Toolbar.cb_getContentInsetEndWithActions == null)
			{
				Toolbar.cb_getContentInsetEndWithActions = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(Toolbar.n_GetContentInsetEndWithActions));
			}
			return Toolbar.cb_getContentInsetEndWithActions;
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x0000E5B4 File Offset: 0x0000C7B4
		private static int n_GetContentInsetEndWithActions(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ContentInsetEndWithActions;
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x0000E5C3 File Offset: 0x0000C7C3
		private static Delegate GetSetContentInsetEndWithActions_IHandler()
		{
			if (Toolbar.cb_setContentInsetEndWithActions_I == null)
			{
				Toolbar.cb_setContentInsetEndWithActions_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(Toolbar.n_SetContentInsetEndWithActions_I));
			}
			return Toolbar.cb_setContentInsetEndWithActions_I;
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x0000E5E7 File Offset: 0x0000C7E7
		private static void n_SetContentInsetEndWithActions_I(IntPtr jnienv, IntPtr native__this, int insetEndWithActions)
		{
			Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ContentInsetEndWithActions = insetEndWithActions;
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x0600055F RID: 1375 RVA: 0x0000E5F7 File Offset: 0x0000C7F7
		// (set) Token: 0x06000560 RID: 1376 RVA: 0x0000E610 File Offset: 0x0000C810
		public unsafe virtual int ContentInsetEndWithActions
		{
			[Register("getContentInsetEndWithActions", "()I", "GetGetContentInsetEndWithActionsHandler")]
			get
			{
				return Toolbar._members.InstanceMethods.InvokeVirtualInt32Method("getContentInsetEndWithActions.()I", this, null);
			}
			[Register("setContentInsetEndWithActions", "(I)V", "GetSetContentInsetEndWithActions_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				Toolbar._members.InstanceMethods.InvokeVirtualVoidMethod("setContentInsetEndWithActions.(I)V", this, ptr);
			}
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x0000E64B File Offset: 0x0000C84B
		private static Delegate GetGetContentInsetLeftHandler()
		{
			if (Toolbar.cb_getContentInsetLeft == null)
			{
				Toolbar.cb_getContentInsetLeft = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(Toolbar.n_GetContentInsetLeft));
			}
			return Toolbar.cb_getContentInsetLeft;
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x0000E66F File Offset: 0x0000C86F
		private static int n_GetContentInsetLeft(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ContentInsetLeft;
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000563 RID: 1379 RVA: 0x0000E67E File Offset: 0x0000C87E
		public virtual int ContentInsetLeft
		{
			[Register("getContentInsetLeft", "()I", "GetGetContentInsetLeftHandler")]
			get
			{
				return Toolbar._members.InstanceMethods.InvokeVirtualInt32Method("getContentInsetLeft.()I", this, null);
			}
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x0000E697 File Offset: 0x0000C897
		private static Delegate GetGetContentInsetRightHandler()
		{
			if (Toolbar.cb_getContentInsetRight == null)
			{
				Toolbar.cb_getContentInsetRight = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(Toolbar.n_GetContentInsetRight));
			}
			return Toolbar.cb_getContentInsetRight;
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x0000E6BB File Offset: 0x0000C8BB
		private static int n_GetContentInsetRight(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ContentInsetRight;
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000566 RID: 1382 RVA: 0x0000E6CA File Offset: 0x0000C8CA
		public virtual int ContentInsetRight
		{
			[Register("getContentInsetRight", "()I", "GetGetContentInsetRightHandler")]
			get
			{
				return Toolbar._members.InstanceMethods.InvokeVirtualInt32Method("getContentInsetRight.()I", this, null);
			}
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x0000E6E3 File Offset: 0x0000C8E3
		private static Delegate GetGetContentInsetStartHandler()
		{
			if (Toolbar.cb_getContentInsetStart == null)
			{
				Toolbar.cb_getContentInsetStart = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(Toolbar.n_GetContentInsetStart));
			}
			return Toolbar.cb_getContentInsetStart;
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x0000E707 File Offset: 0x0000C907
		private static int n_GetContentInsetStart(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ContentInsetStart;
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000569 RID: 1385 RVA: 0x0000E716 File Offset: 0x0000C916
		public virtual int ContentInsetStart
		{
			[Register("getContentInsetStart", "()I", "GetGetContentInsetStartHandler")]
			get
			{
				return Toolbar._members.InstanceMethods.InvokeVirtualInt32Method("getContentInsetStart.()I", this, null);
			}
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x0000E72F File Offset: 0x0000C92F
		private static Delegate GetGetContentInsetStartWithNavigationHandler()
		{
			if (Toolbar.cb_getContentInsetStartWithNavigation == null)
			{
				Toolbar.cb_getContentInsetStartWithNavigation = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(Toolbar.n_GetContentInsetStartWithNavigation));
			}
			return Toolbar.cb_getContentInsetStartWithNavigation;
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x0000E753 File Offset: 0x0000C953
		private static int n_GetContentInsetStartWithNavigation(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ContentInsetStartWithNavigation;
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x0000E762 File Offset: 0x0000C962
		private static Delegate GetSetContentInsetStartWithNavigation_IHandler()
		{
			if (Toolbar.cb_setContentInsetStartWithNavigation_I == null)
			{
				Toolbar.cb_setContentInsetStartWithNavigation_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(Toolbar.n_SetContentInsetStartWithNavigation_I));
			}
			return Toolbar.cb_setContentInsetStartWithNavigation_I;
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x0000E786 File Offset: 0x0000C986
		private static void n_SetContentInsetStartWithNavigation_I(IntPtr jnienv, IntPtr native__this, int insetStartWithNavigation)
		{
			Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ContentInsetStartWithNavigation = insetStartWithNavigation;
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x0600056E RID: 1390 RVA: 0x0000E796 File Offset: 0x0000C996
		// (set) Token: 0x0600056F RID: 1391 RVA: 0x0000E7B0 File Offset: 0x0000C9B0
		public unsafe virtual int ContentInsetStartWithNavigation
		{
			[Register("getContentInsetStartWithNavigation", "()I", "GetGetContentInsetStartWithNavigationHandler")]
			get
			{
				return Toolbar._members.InstanceMethods.InvokeVirtualInt32Method("getContentInsetStartWithNavigation.()I", this, null);
			}
			[Register("setContentInsetStartWithNavigation", "(I)V", "GetSetContentInsetStartWithNavigation_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				Toolbar._members.InstanceMethods.InvokeVirtualVoidMethod("setContentInsetStartWithNavigation.(I)V", this, ptr);
			}
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x0000E7EB File Offset: 0x0000C9EB
		private static Delegate GetGetCurrentContentInsetEndHandler()
		{
			if (Toolbar.cb_getCurrentContentInsetEnd == null)
			{
				Toolbar.cb_getCurrentContentInsetEnd = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(Toolbar.n_GetCurrentContentInsetEnd));
			}
			return Toolbar.cb_getCurrentContentInsetEnd;
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x0000E80F File Offset: 0x0000CA0F
		private static int n_GetCurrentContentInsetEnd(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CurrentContentInsetEnd;
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000572 RID: 1394 RVA: 0x0000E81E File Offset: 0x0000CA1E
		public virtual int CurrentContentInsetEnd
		{
			[Register("getCurrentContentInsetEnd", "()I", "GetGetCurrentContentInsetEndHandler")]
			get
			{
				return Toolbar._members.InstanceMethods.InvokeVirtualInt32Method("getCurrentContentInsetEnd.()I", this, null);
			}
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x0000E837 File Offset: 0x0000CA37
		private static Delegate GetGetCurrentContentInsetLeftHandler()
		{
			if (Toolbar.cb_getCurrentContentInsetLeft == null)
			{
				Toolbar.cb_getCurrentContentInsetLeft = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(Toolbar.n_GetCurrentContentInsetLeft));
			}
			return Toolbar.cb_getCurrentContentInsetLeft;
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x0000E85B File Offset: 0x0000CA5B
		private static int n_GetCurrentContentInsetLeft(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CurrentContentInsetLeft;
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000575 RID: 1397 RVA: 0x0000E86A File Offset: 0x0000CA6A
		public virtual int CurrentContentInsetLeft
		{
			[Register("getCurrentContentInsetLeft", "()I", "GetGetCurrentContentInsetLeftHandler")]
			get
			{
				return Toolbar._members.InstanceMethods.InvokeVirtualInt32Method("getCurrentContentInsetLeft.()I", this, null);
			}
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x0000E883 File Offset: 0x0000CA83
		private static Delegate GetGetCurrentContentInsetRightHandler()
		{
			if (Toolbar.cb_getCurrentContentInsetRight == null)
			{
				Toolbar.cb_getCurrentContentInsetRight = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(Toolbar.n_GetCurrentContentInsetRight));
			}
			return Toolbar.cb_getCurrentContentInsetRight;
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x0000E8A7 File Offset: 0x0000CAA7
		private static int n_GetCurrentContentInsetRight(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CurrentContentInsetRight;
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000578 RID: 1400 RVA: 0x0000E8B6 File Offset: 0x0000CAB6
		public virtual int CurrentContentInsetRight
		{
			[Register("getCurrentContentInsetRight", "()I", "GetGetCurrentContentInsetRightHandler")]
			get
			{
				return Toolbar._members.InstanceMethods.InvokeVirtualInt32Method("getCurrentContentInsetRight.()I", this, null);
			}
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x0000E8CF File Offset: 0x0000CACF
		private static Delegate GetGetCurrentContentInsetStartHandler()
		{
			if (Toolbar.cb_getCurrentContentInsetStart == null)
			{
				Toolbar.cb_getCurrentContentInsetStart = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(Toolbar.n_GetCurrentContentInsetStart));
			}
			return Toolbar.cb_getCurrentContentInsetStart;
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x0000E8F3 File Offset: 0x0000CAF3
		private static int n_GetCurrentContentInsetStart(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CurrentContentInsetStart;
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x0600057B RID: 1403 RVA: 0x0000E902 File Offset: 0x0000CB02
		public virtual int CurrentContentInsetStart
		{
			[Register("getCurrentContentInsetStart", "()I", "GetGetCurrentContentInsetStartHandler")]
			get
			{
				return Toolbar._members.InstanceMethods.InvokeVirtualInt32Method("getCurrentContentInsetStart.()I", this, null);
			}
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x0000E91B File Offset: 0x0000CB1B
		private static Delegate GetHasExpandedActionViewHandler()
		{
			if (Toolbar.cb_hasExpandedActionView == null)
			{
				Toolbar.cb_hasExpandedActionView = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(Toolbar.n_HasExpandedActionView));
			}
			return Toolbar.cb_hasExpandedActionView;
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x0000E93F File Offset: 0x0000CB3F
		private static bool n_HasExpandedActionView(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HasExpandedActionView;
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x0600057E RID: 1406 RVA: 0x0000E94E File Offset: 0x0000CB4E
		public virtual bool HasExpandedActionView
		{
			[Register("hasExpandedActionView", "()Z", "GetHasExpandedActionViewHandler")]
			get
			{
				return Toolbar._members.InstanceMethods.InvokeVirtualBooleanMethod("hasExpandedActionView.()Z", this, null);
			}
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x0000E967 File Offset: 0x0000CB67
		private static Delegate GetIsOverflowMenuShowPendingHandler()
		{
			if (Toolbar.cb_isOverflowMenuShowPending == null)
			{
				Toolbar.cb_isOverflowMenuShowPending = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(Toolbar.n_IsOverflowMenuShowPending));
			}
			return Toolbar.cb_isOverflowMenuShowPending;
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x0000E98B File Offset: 0x0000CB8B
		private static bool n_IsOverflowMenuShowPending(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsOverflowMenuShowPending;
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000581 RID: 1409 RVA: 0x0000E99A File Offset: 0x0000CB9A
		public virtual bool IsOverflowMenuShowPending
		{
			[Register("isOverflowMenuShowPending", "()Z", "GetIsOverflowMenuShowPendingHandler")]
			get
			{
				return Toolbar._members.InstanceMethods.InvokeVirtualBooleanMethod("isOverflowMenuShowPending.()Z", this, null);
			}
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x0000E9B3 File Offset: 0x0000CBB3
		private static Delegate GetIsOverflowMenuShowingHandler()
		{
			if (Toolbar.cb_isOverflowMenuShowing == null)
			{
				Toolbar.cb_isOverflowMenuShowing = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(Toolbar.n_IsOverflowMenuShowing));
			}
			return Toolbar.cb_isOverflowMenuShowing;
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x0000E9D7 File Offset: 0x0000CBD7
		private static bool n_IsOverflowMenuShowing(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsOverflowMenuShowing;
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000584 RID: 1412 RVA: 0x0000E9E6 File Offset: 0x0000CBE6
		public virtual bool IsOverflowMenuShowing
		{
			[Register("isOverflowMenuShowing", "()Z", "GetIsOverflowMenuShowingHandler")]
			get
			{
				return Toolbar._members.InstanceMethods.InvokeVirtualBooleanMethod("isOverflowMenuShowing.()Z", this, null);
			}
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x0000E9FF File Offset: 0x0000CBFF
		private static Delegate GetIsTitleTruncatedHandler()
		{
			if (Toolbar.cb_isTitleTruncated == null)
			{
				Toolbar.cb_isTitleTruncated = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(Toolbar.n_IsTitleTruncated));
			}
			return Toolbar.cb_isTitleTruncated;
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x0000EA23 File Offset: 0x0000CC23
		private static bool n_IsTitleTruncated(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsTitleTruncated;
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000587 RID: 1415 RVA: 0x0000EA32 File Offset: 0x0000CC32
		public virtual bool IsTitleTruncated
		{
			[Register("isTitleTruncated", "()Z", "GetIsTitleTruncatedHandler")]
			get
			{
				return Toolbar._members.InstanceMethods.InvokeVirtualBooleanMethod("isTitleTruncated.()Z", this, null);
			}
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x0000EA4B File Offset: 0x0000CC4B
		private static Delegate GetGetLogoHandler()
		{
			if (Toolbar.cb_getLogo == null)
			{
				Toolbar.cb_getLogo = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Toolbar.n_GetLogo));
			}
			return Toolbar.cb_getLogo;
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x0000EA6F File Offset: 0x0000CC6F
		private static IntPtr n_GetLogo(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Logo);
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x0000EA83 File Offset: 0x0000CC83
		private static Delegate GetSetLogo_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (Toolbar.cb_setLogo_Landroid_graphics_drawable_Drawable_ == null)
			{
				Toolbar.cb_setLogo_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Toolbar.n_SetLogo_Landroid_graphics_drawable_Drawable_));
			}
			return Toolbar.cb_setLogo_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x0000EAA8 File Offset: 0x0000CCA8
		private static void n_SetLogo_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_drawable)
		{
			Toolbar @object = Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_drawable, JniHandleOwnership.DoNotTransfer);
			@object.Logo = object2;
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x0600058C RID: 1420 RVA: 0x0000EACC File Offset: 0x0000CCCC
		// (set) Token: 0x0600058D RID: 1421 RVA: 0x0000EB00 File Offset: 0x0000CD00
		public unsafe virtual Drawable Logo
		{
			[Register("getLogo", "()Landroid/graphics/drawable/Drawable;", "GetGetLogoHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Drawable>(Toolbar._members.InstanceMethods.InvokeVirtualObjectMethod("getLogo.()Landroid/graphics/drawable/Drawable;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setLogo", "(Landroid/graphics/drawable/Drawable;)V", "GetSetLogo_Landroid_graphics_drawable_Drawable_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					Toolbar._members.InstanceMethods.InvokeVirtualVoidMethod("setLogo.(Landroid/graphics/drawable/Drawable;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x0000EB64 File Offset: 0x0000CD64
		private static Delegate GetGetLogoDescriptionHandler()
		{
			if (Toolbar.cb_getLogoDescription == null)
			{
				Toolbar.cb_getLogoDescription = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Toolbar.n_GetLogoDescription));
			}
			return Toolbar.cb_getLogoDescription;
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x0000EB88 File Offset: 0x0000CD88
		private static IntPtr n_GetLogoDescription(IntPtr jnienv, IntPtr native__this)
		{
			return CharSequence.ToLocalJniHandle(Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LogoDescriptionFormatted);
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x0000EB9C File Offset: 0x0000CD9C
		private static Delegate GetSetLogoDescription_Ljava_lang_CharSequence_Handler()
		{
			if (Toolbar.cb_setLogoDescription_Ljava_lang_CharSequence_ == null)
			{
				Toolbar.cb_setLogoDescription_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Toolbar.n_SetLogoDescription_Ljava_lang_CharSequence_));
			}
			return Toolbar.cb_setLogoDescription_Ljava_lang_CharSequence_;
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x0000EBC0 File Offset: 0x0000CDC0
		private static void n_SetLogoDescription_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_description)
		{
			Toolbar @object = Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_description, JniHandleOwnership.DoNotTransfer);
			@object.LogoDescriptionFormatted = object2;
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000592 RID: 1426 RVA: 0x0000EBE4 File Offset: 0x0000CDE4
		// (set) Token: 0x06000593 RID: 1427 RVA: 0x0000EC18 File Offset: 0x0000CE18
		public unsafe virtual ICharSequence LogoDescriptionFormatted
		{
			[Register("getLogoDescription", "()Ljava/lang/CharSequence;", "GetGetLogoDescriptionHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ICharSequence>(Toolbar._members.InstanceMethods.InvokeVirtualObjectMethod("getLogoDescription.()Ljava/lang/CharSequence;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setLogoDescription", "(Ljava/lang/CharSequence;)V", "GetSetLogoDescription_Ljava_lang_CharSequence_Handler")]
			set
			{
				IntPtr intPtr = CharSequence.ToLocalJniHandle(value);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					Toolbar._members.InstanceMethods.InvokeVirtualVoidMethod("setLogoDescription.(Ljava/lang/CharSequence;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000594 RID: 1428 RVA: 0x0000EC7C File Offset: 0x0000CE7C
		// (set) Token: 0x06000595 RID: 1429 RVA: 0x0000EC94 File Offset: 0x0000CE94
		public string LogoDescription
		{
			get
			{
				if (this.LogoDescriptionFormatted != null)
				{
					return this.LogoDescriptionFormatted.ToString();
				}
				return null;
			}
			set
			{
				Java.Lang.String @string = (value == null) ? null : new Java.Lang.String(value);
				this.LogoDescriptionFormatted = @string;
				if (@string != null)
				{
					@string.Dispose();
				}
			}
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x0000ECBE File Offset: 0x0000CEBE
		private static Delegate GetGetMenuHandler()
		{
			if (Toolbar.cb_getMenu == null)
			{
				Toolbar.cb_getMenu = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Toolbar.n_GetMenu));
			}
			return Toolbar.cb_getMenu;
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x0000ECE2 File Offset: 0x0000CEE2
		private static IntPtr n_GetMenu(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Menu);
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000598 RID: 1432 RVA: 0x0000ECF8 File Offset: 0x0000CEF8
		public virtual IMenu Menu
		{
			[Register("getMenu", "()Landroid/view/Menu;", "GetGetMenuHandler")]
			get
			{
				return Java.Lang.Object.GetObject<IMenu>(Toolbar._members.InstanceMethods.InvokeVirtualObjectMethod("getMenu.()Landroid/view/Menu;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x0000ED2A File Offset: 0x0000CF2A
		private static Delegate GetGetNavigationContentDescriptionHandler()
		{
			if (Toolbar.cb_getNavigationContentDescription == null)
			{
				Toolbar.cb_getNavigationContentDescription = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Toolbar.n_GetNavigationContentDescription));
			}
			return Toolbar.cb_getNavigationContentDescription;
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x0000ED4E File Offset: 0x0000CF4E
		private static IntPtr n_GetNavigationContentDescription(IntPtr jnienv, IntPtr native__this)
		{
			return CharSequence.ToLocalJniHandle(Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NavigationContentDescriptionFormatted);
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x0000ED62 File Offset: 0x0000CF62
		private static Delegate GetSetNavigationContentDescription_Ljava_lang_CharSequence_Handler()
		{
			if (Toolbar.cb_setNavigationContentDescription_Ljava_lang_CharSequence_ == null)
			{
				Toolbar.cb_setNavigationContentDescription_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Toolbar.n_SetNavigationContentDescription_Ljava_lang_CharSequence_));
			}
			return Toolbar.cb_setNavigationContentDescription_Ljava_lang_CharSequence_;
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x0000ED88 File Offset: 0x0000CF88
		private static void n_SetNavigationContentDescription_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_description)
		{
			Toolbar @object = Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_description, JniHandleOwnership.DoNotTransfer);
			@object.NavigationContentDescriptionFormatted = object2;
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x0600059D RID: 1437 RVA: 0x0000EDAC File Offset: 0x0000CFAC
		// (set) Token: 0x0600059E RID: 1438 RVA: 0x0000EDE0 File Offset: 0x0000CFE0
		public unsafe virtual ICharSequence NavigationContentDescriptionFormatted
		{
			[Register("getNavigationContentDescription", "()Ljava/lang/CharSequence;", "GetGetNavigationContentDescriptionHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ICharSequence>(Toolbar._members.InstanceMethods.InvokeVirtualObjectMethod("getNavigationContentDescription.()Ljava/lang/CharSequence;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setNavigationContentDescription", "(Ljava/lang/CharSequence;)V", "GetSetNavigationContentDescription_Ljava_lang_CharSequence_Handler")]
			set
			{
				IntPtr intPtr = CharSequence.ToLocalJniHandle(value);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					Toolbar._members.InstanceMethods.InvokeVirtualVoidMethod("setNavigationContentDescription.(Ljava/lang/CharSequence;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x0600059F RID: 1439 RVA: 0x0000EE44 File Offset: 0x0000D044
		// (set) Token: 0x060005A0 RID: 1440 RVA: 0x0000EE5C File Offset: 0x0000D05C
		public string NavigationContentDescription
		{
			get
			{
				if (this.NavigationContentDescriptionFormatted != null)
				{
					return this.NavigationContentDescriptionFormatted.ToString();
				}
				return null;
			}
			set
			{
				Java.Lang.String @string = (value == null) ? null : new Java.Lang.String(value);
				this.NavigationContentDescriptionFormatted = @string;
				if (@string != null)
				{
					@string.Dispose();
				}
			}
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x0000EE86 File Offset: 0x0000D086
		private static Delegate GetGetNavigationIconHandler()
		{
			if (Toolbar.cb_getNavigationIcon == null)
			{
				Toolbar.cb_getNavigationIcon = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Toolbar.n_GetNavigationIcon));
			}
			return Toolbar.cb_getNavigationIcon;
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x0000EEAA File Offset: 0x0000D0AA
		private static IntPtr n_GetNavigationIcon(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NavigationIcon);
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x0000EEBE File Offset: 0x0000D0BE
		private static Delegate GetSetNavigationIcon_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (Toolbar.cb_setNavigationIcon_Landroid_graphics_drawable_Drawable_ == null)
			{
				Toolbar.cb_setNavigationIcon_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Toolbar.n_SetNavigationIcon_Landroid_graphics_drawable_Drawable_));
			}
			return Toolbar.cb_setNavigationIcon_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x0000EEE4 File Offset: 0x0000D0E4
		private static void n_SetNavigationIcon_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_icon)
		{
			Toolbar @object = Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_icon, JniHandleOwnership.DoNotTransfer);
			@object.NavigationIcon = object2;
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060005A5 RID: 1445 RVA: 0x0000EF08 File Offset: 0x0000D108
		// (set) Token: 0x060005A6 RID: 1446 RVA: 0x0000EF3C File Offset: 0x0000D13C
		public unsafe virtual Drawable NavigationIcon
		{
			[Register("getNavigationIcon", "()Landroid/graphics/drawable/Drawable;", "GetGetNavigationIconHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Drawable>(Toolbar._members.InstanceMethods.InvokeVirtualObjectMethod("getNavigationIcon.()Landroid/graphics/drawable/Drawable;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setNavigationIcon", "(Landroid/graphics/drawable/Drawable;)V", "GetSetNavigationIcon_Landroid_graphics_drawable_Drawable_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					Toolbar._members.InstanceMethods.InvokeVirtualVoidMethod("setNavigationIcon.(Landroid/graphics/drawable/Drawable;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x0000EFA0 File Offset: 0x0000D1A0
		private static Delegate GetGetOverflowIconHandler()
		{
			if (Toolbar.cb_getOverflowIcon == null)
			{
				Toolbar.cb_getOverflowIcon = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Toolbar.n_GetOverflowIcon));
			}
			return Toolbar.cb_getOverflowIcon;
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x0000EFC4 File Offset: 0x0000D1C4
		private static IntPtr n_GetOverflowIcon(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OverflowIcon);
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x0000EFD8 File Offset: 0x0000D1D8
		private static Delegate GetSetOverflowIcon_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (Toolbar.cb_setOverflowIcon_Landroid_graphics_drawable_Drawable_ == null)
			{
				Toolbar.cb_setOverflowIcon_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Toolbar.n_SetOverflowIcon_Landroid_graphics_drawable_Drawable_));
			}
			return Toolbar.cb_setOverflowIcon_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x0000EFFC File Offset: 0x0000D1FC
		private static void n_SetOverflowIcon_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_icon)
		{
			Toolbar @object = Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_icon, JniHandleOwnership.DoNotTransfer);
			@object.OverflowIcon = object2;
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060005AB RID: 1451 RVA: 0x0000F020 File Offset: 0x0000D220
		// (set) Token: 0x060005AC RID: 1452 RVA: 0x0000F054 File Offset: 0x0000D254
		public unsafe virtual Drawable OverflowIcon
		{
			[Register("getOverflowIcon", "()Landroid/graphics/drawable/Drawable;", "GetGetOverflowIconHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Drawable>(Toolbar._members.InstanceMethods.InvokeVirtualObjectMethod("getOverflowIcon.()Landroid/graphics/drawable/Drawable;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setOverflowIcon", "(Landroid/graphics/drawable/Drawable;)V", "GetSetOverflowIcon_Landroid_graphics_drawable_Drawable_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					Toolbar._members.InstanceMethods.InvokeVirtualVoidMethod("setOverflowIcon.(Landroid/graphics/drawable/Drawable;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x0000F0B8 File Offset: 0x0000D2B8
		private static Delegate GetGetPopupThemeHandler()
		{
			if (Toolbar.cb_getPopupTheme == null)
			{
				Toolbar.cb_getPopupTheme = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(Toolbar.n_GetPopupTheme));
			}
			return Toolbar.cb_getPopupTheme;
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x0000F0DC File Offset: 0x0000D2DC
		private static int n_GetPopupTheme(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PopupTheme;
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x0000F0EB File Offset: 0x0000D2EB
		private static Delegate GetSetPopupTheme_IHandler()
		{
			if (Toolbar.cb_setPopupTheme_I == null)
			{
				Toolbar.cb_setPopupTheme_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(Toolbar.n_SetPopupTheme_I));
			}
			return Toolbar.cb_setPopupTheme_I;
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x0000F10F File Offset: 0x0000D30F
		private static void n_SetPopupTheme_I(IntPtr jnienv, IntPtr native__this, int resId)
		{
			Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PopupTheme = resId;
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060005B1 RID: 1457 RVA: 0x0000F11F File Offset: 0x0000D31F
		// (set) Token: 0x060005B2 RID: 1458 RVA: 0x0000F138 File Offset: 0x0000D338
		public unsafe virtual int PopupTheme
		{
			[Register("getPopupTheme", "()I", "GetGetPopupThemeHandler")]
			get
			{
				return Toolbar._members.InstanceMethods.InvokeVirtualInt32Method("getPopupTheme.()I", this, null);
			}
			[Register("setPopupTheme", "(I)V", "GetSetPopupTheme_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				Toolbar._members.InstanceMethods.InvokeVirtualVoidMethod("setPopupTheme.(I)V", this, ptr);
			}
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x0000F173 File Offset: 0x0000D373
		private static Delegate GetGetSubtitleHandler()
		{
			if (Toolbar.cb_getSubtitle == null)
			{
				Toolbar.cb_getSubtitle = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Toolbar.n_GetSubtitle));
			}
			return Toolbar.cb_getSubtitle;
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x0000F197 File Offset: 0x0000D397
		private static IntPtr n_GetSubtitle(IntPtr jnienv, IntPtr native__this)
		{
			return CharSequence.ToLocalJniHandle(Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SubtitleFormatted);
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x0000F1AB File Offset: 0x0000D3AB
		private static Delegate GetSetSubtitle_Ljava_lang_CharSequence_Handler()
		{
			if (Toolbar.cb_setSubtitle_Ljava_lang_CharSequence_ == null)
			{
				Toolbar.cb_setSubtitle_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Toolbar.n_SetSubtitle_Ljava_lang_CharSequence_));
			}
			return Toolbar.cb_setSubtitle_Ljava_lang_CharSequence_;
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x0000F1D0 File Offset: 0x0000D3D0
		private static void n_SetSubtitle_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_subtitle)
		{
			Toolbar @object = Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_subtitle, JniHandleOwnership.DoNotTransfer);
			@object.SubtitleFormatted = object2;
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060005B7 RID: 1463 RVA: 0x0000F1F4 File Offset: 0x0000D3F4
		// (set) Token: 0x060005B8 RID: 1464 RVA: 0x0000F228 File Offset: 0x0000D428
		public unsafe virtual ICharSequence SubtitleFormatted
		{
			[Register("getSubtitle", "()Ljava/lang/CharSequence;", "GetGetSubtitleHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ICharSequence>(Toolbar._members.InstanceMethods.InvokeVirtualObjectMethod("getSubtitle.()Ljava/lang/CharSequence;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setSubtitle", "(Ljava/lang/CharSequence;)V", "GetSetSubtitle_Ljava_lang_CharSequence_Handler")]
			set
			{
				IntPtr intPtr = CharSequence.ToLocalJniHandle(value);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					Toolbar._members.InstanceMethods.InvokeVirtualVoidMethod("setSubtitle.(Ljava/lang/CharSequence;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060005B9 RID: 1465 RVA: 0x0000F28C File Offset: 0x0000D48C
		// (set) Token: 0x060005BA RID: 1466 RVA: 0x0000F2A4 File Offset: 0x0000D4A4
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

		// Token: 0x060005BB RID: 1467 RVA: 0x0000F2CE File Offset: 0x0000D4CE
		private static Delegate GetGetTitleHandler()
		{
			if (Toolbar.cb_getTitle == null)
			{
				Toolbar.cb_getTitle = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Toolbar.n_GetTitle));
			}
			return Toolbar.cb_getTitle;
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x0000F2F2 File Offset: 0x0000D4F2
		private static IntPtr n_GetTitle(IntPtr jnienv, IntPtr native__this)
		{
			return CharSequence.ToLocalJniHandle(Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TitleFormatted);
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x0000F306 File Offset: 0x0000D506
		private static Delegate GetSetTitle_Ljava_lang_CharSequence_Handler()
		{
			if (Toolbar.cb_setTitle_Ljava_lang_CharSequence_ == null)
			{
				Toolbar.cb_setTitle_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Toolbar.n_SetTitle_Ljava_lang_CharSequence_));
			}
			return Toolbar.cb_setTitle_Ljava_lang_CharSequence_;
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x0000F32C File Offset: 0x0000D52C
		private static void n_SetTitle_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_title)
		{
			Toolbar @object = Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_title, JniHandleOwnership.DoNotTransfer);
			@object.TitleFormatted = object2;
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060005BF RID: 1471 RVA: 0x0000F350 File Offset: 0x0000D550
		// (set) Token: 0x060005C0 RID: 1472 RVA: 0x0000F384 File Offset: 0x0000D584
		public unsafe virtual ICharSequence TitleFormatted
		{
			[Register("getTitle", "()Ljava/lang/CharSequence;", "GetGetTitleHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ICharSequence>(Toolbar._members.InstanceMethods.InvokeVirtualObjectMethod("getTitle.()Ljava/lang/CharSequence;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setTitle", "(Ljava/lang/CharSequence;)V", "GetSetTitle_Ljava_lang_CharSequence_Handler")]
			set
			{
				IntPtr intPtr = CharSequence.ToLocalJniHandle(value);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					Toolbar._members.InstanceMethods.InvokeVirtualVoidMethod("setTitle.(Ljava/lang/CharSequence;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060005C1 RID: 1473 RVA: 0x0000F3E8 File Offset: 0x0000D5E8
		// (set) Token: 0x060005C2 RID: 1474 RVA: 0x0000F400 File Offset: 0x0000D600
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

		// Token: 0x060005C3 RID: 1475 RVA: 0x0000F42A File Offset: 0x0000D62A
		private static Delegate GetGetTitleMarginBottomHandler()
		{
			if (Toolbar.cb_getTitleMarginBottom == null)
			{
				Toolbar.cb_getTitleMarginBottom = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(Toolbar.n_GetTitleMarginBottom));
			}
			return Toolbar.cb_getTitleMarginBottom;
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x0000F44E File Offset: 0x0000D64E
		private static int n_GetTitleMarginBottom(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TitleMarginBottom;
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x0000F45D File Offset: 0x0000D65D
		private static Delegate GetSetTitleMarginBottom_IHandler()
		{
			if (Toolbar.cb_setTitleMarginBottom_I == null)
			{
				Toolbar.cb_setTitleMarginBottom_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(Toolbar.n_SetTitleMarginBottom_I));
			}
			return Toolbar.cb_setTitleMarginBottom_I;
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x0000F481 File Offset: 0x0000D681
		private static void n_SetTitleMarginBottom_I(IntPtr jnienv, IntPtr native__this, int margin)
		{
			Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TitleMarginBottom = margin;
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060005C7 RID: 1479 RVA: 0x0000F491 File Offset: 0x0000D691
		// (set) Token: 0x060005C8 RID: 1480 RVA: 0x0000F4AC File Offset: 0x0000D6AC
		public unsafe virtual int TitleMarginBottom
		{
			[Register("getTitleMarginBottom", "()I", "GetGetTitleMarginBottomHandler")]
			get
			{
				return Toolbar._members.InstanceMethods.InvokeVirtualInt32Method("getTitleMarginBottom.()I", this, null);
			}
			[Register("setTitleMarginBottom", "(I)V", "GetSetTitleMarginBottom_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				Toolbar._members.InstanceMethods.InvokeVirtualVoidMethod("setTitleMarginBottom.(I)V", this, ptr);
			}
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x0000F4E7 File Offset: 0x0000D6E7
		private static Delegate GetGetTitleMarginEndHandler()
		{
			if (Toolbar.cb_getTitleMarginEnd == null)
			{
				Toolbar.cb_getTitleMarginEnd = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(Toolbar.n_GetTitleMarginEnd));
			}
			return Toolbar.cb_getTitleMarginEnd;
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x0000F50B File Offset: 0x0000D70B
		private static int n_GetTitleMarginEnd(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TitleMarginEnd;
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x0000F51A File Offset: 0x0000D71A
		private static Delegate GetSetTitleMarginEnd_IHandler()
		{
			if (Toolbar.cb_setTitleMarginEnd_I == null)
			{
				Toolbar.cb_setTitleMarginEnd_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(Toolbar.n_SetTitleMarginEnd_I));
			}
			return Toolbar.cb_setTitleMarginEnd_I;
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x0000F53E File Offset: 0x0000D73E
		private static void n_SetTitleMarginEnd_I(IntPtr jnienv, IntPtr native__this, int margin)
		{
			Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TitleMarginEnd = margin;
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060005CD RID: 1485 RVA: 0x0000F54E File Offset: 0x0000D74E
		// (set) Token: 0x060005CE RID: 1486 RVA: 0x0000F568 File Offset: 0x0000D768
		public unsafe virtual int TitleMarginEnd
		{
			[Register("getTitleMarginEnd", "()I", "GetGetTitleMarginEndHandler")]
			get
			{
				return Toolbar._members.InstanceMethods.InvokeVirtualInt32Method("getTitleMarginEnd.()I", this, null);
			}
			[Register("setTitleMarginEnd", "(I)V", "GetSetTitleMarginEnd_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				Toolbar._members.InstanceMethods.InvokeVirtualVoidMethod("setTitleMarginEnd.(I)V", this, ptr);
			}
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x0000F5A3 File Offset: 0x0000D7A3
		private static Delegate GetGetTitleMarginStartHandler()
		{
			if (Toolbar.cb_getTitleMarginStart == null)
			{
				Toolbar.cb_getTitleMarginStart = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(Toolbar.n_GetTitleMarginStart));
			}
			return Toolbar.cb_getTitleMarginStart;
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x0000F5C7 File Offset: 0x0000D7C7
		private static int n_GetTitleMarginStart(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TitleMarginStart;
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x0000F5D6 File Offset: 0x0000D7D6
		private static Delegate GetSetTitleMarginStart_IHandler()
		{
			if (Toolbar.cb_setTitleMarginStart_I == null)
			{
				Toolbar.cb_setTitleMarginStart_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(Toolbar.n_SetTitleMarginStart_I));
			}
			return Toolbar.cb_setTitleMarginStart_I;
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x0000F5FA File Offset: 0x0000D7FA
		private static void n_SetTitleMarginStart_I(IntPtr jnienv, IntPtr native__this, int margin)
		{
			Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TitleMarginStart = margin;
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060005D3 RID: 1491 RVA: 0x0000F60A File Offset: 0x0000D80A
		// (set) Token: 0x060005D4 RID: 1492 RVA: 0x0000F624 File Offset: 0x0000D824
		public unsafe virtual int TitleMarginStart
		{
			[Register("getTitleMarginStart", "()I", "GetGetTitleMarginStartHandler")]
			get
			{
				return Toolbar._members.InstanceMethods.InvokeVirtualInt32Method("getTitleMarginStart.()I", this, null);
			}
			[Register("setTitleMarginStart", "(I)V", "GetSetTitleMarginStart_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				Toolbar._members.InstanceMethods.InvokeVirtualVoidMethod("setTitleMarginStart.(I)V", this, ptr);
			}
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x0000F65F File Offset: 0x0000D85F
		private static Delegate GetGetTitleMarginTopHandler()
		{
			if (Toolbar.cb_getTitleMarginTop == null)
			{
				Toolbar.cb_getTitleMarginTop = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(Toolbar.n_GetTitleMarginTop));
			}
			return Toolbar.cb_getTitleMarginTop;
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x0000F683 File Offset: 0x0000D883
		private static int n_GetTitleMarginTop(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TitleMarginTop;
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x0000F692 File Offset: 0x0000D892
		private static Delegate GetSetTitleMarginTop_IHandler()
		{
			if (Toolbar.cb_setTitleMarginTop_I == null)
			{
				Toolbar.cb_setTitleMarginTop_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(Toolbar.n_SetTitleMarginTop_I));
			}
			return Toolbar.cb_setTitleMarginTop_I;
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x0000F6B6 File Offset: 0x0000D8B6
		private static void n_SetTitleMarginTop_I(IntPtr jnienv, IntPtr native__this, int margin)
		{
			Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TitleMarginTop = margin;
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060005D9 RID: 1497 RVA: 0x0000F6C6 File Offset: 0x0000D8C6
		// (set) Token: 0x060005DA RID: 1498 RVA: 0x0000F6E0 File Offset: 0x0000D8E0
		public unsafe virtual int TitleMarginTop
		{
			[Register("getTitleMarginTop", "()I", "GetGetTitleMarginTopHandler")]
			get
			{
				return Toolbar._members.InstanceMethods.InvokeVirtualInt32Method("getTitleMarginTop.()I", this, null);
			}
			[Register("setTitleMarginTop", "(I)V", "GetSetTitleMarginTop_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				Toolbar._members.InstanceMethods.InvokeVirtualVoidMethod("setTitleMarginTop.(I)V", this, ptr);
			}
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x0000F71B File Offset: 0x0000D91B
		private static Delegate GetGetWrapperHandler()
		{
			if (Toolbar.cb_getWrapper == null)
			{
				Toolbar.cb_getWrapper = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Toolbar.n_GetWrapper));
			}
			return Toolbar.cb_getWrapper;
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x0000F73F File Offset: 0x0000D93F
		private static IntPtr n_GetWrapper(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Wrapper);
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060005DD RID: 1501 RVA: 0x0000F754 File Offset: 0x0000D954
		public virtual IDecorToolbar Wrapper
		{
			[Register("getWrapper", "()Landroidx/appcompat/widget/DecorToolbar;", "GetGetWrapperHandler")]
			get
			{
				return Java.Lang.Object.GetObject<IDecorToolbar>(Toolbar._members.InstanceMethods.InvokeVirtualObjectMethod("getWrapper.()Landroidx/appcompat/widget/DecorToolbar;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x0000F786 File Offset: 0x0000D986
		private static Delegate GetAddMenuProvider_Landroidx_core_view_MenuProvider_Handler()
		{
			if (Toolbar.cb_addMenuProvider_Landroidx_core_view_MenuProvider_ == null)
			{
				Toolbar.cb_addMenuProvider_Landroidx_core_view_MenuProvider_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Toolbar.n_AddMenuProvider_Landroidx_core_view_MenuProvider_));
			}
			return Toolbar.cb_addMenuProvider_Landroidx_core_view_MenuProvider_;
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x0000F7AC File Offset: 0x0000D9AC
		private static void n_AddMenuProvider_Landroidx_core_view_MenuProvider_(IntPtr jnienv, IntPtr native__this, IntPtr native_provider)
		{
			Toolbar @object = Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMenuProvider object2 = Java.Lang.Object.GetObject<IMenuProvider>(native_provider, JniHandleOwnership.DoNotTransfer);
			@object.AddMenuProvider(object2);
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x0000F7D0 File Offset: 0x0000D9D0
		[Register("addMenuProvider", "(Landroidx/core/view/MenuProvider;)V", "GetAddMenuProvider_Landroidx_core_view_MenuProvider_Handler")]
		public unsafe virtual void AddMenuProvider(IMenuProvider provider)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((provider == null) ? IntPtr.Zero : ((Java.Lang.Object)provider).Handle);
				Toolbar._members.InstanceMethods.InvokeVirtualVoidMethod("addMenuProvider.(Landroidx/core/view/MenuProvider;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(provider);
			}
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x0000F838 File Offset: 0x0000DA38
		private static Delegate GetAddMenuProvider_Landroidx_core_view_MenuProvider_Landroidx_lifecycle_LifecycleOwner_Handler()
		{
			if (Toolbar.cb_addMenuProvider_Landroidx_core_view_MenuProvider_Landroidx_lifecycle_LifecycleOwner_ == null)
			{
				Toolbar.cb_addMenuProvider_Landroidx_core_view_MenuProvider_Landroidx_lifecycle_LifecycleOwner_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(Toolbar.n_AddMenuProvider_Landroidx_core_view_MenuProvider_Landroidx_lifecycle_LifecycleOwner_));
			}
			return Toolbar.cb_addMenuProvider_Landroidx_core_view_MenuProvider_Landroidx_lifecycle_LifecycleOwner_;
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x0000F85C File Offset: 0x0000DA5C
		private static void n_AddMenuProvider_Landroidx_core_view_MenuProvider_Landroidx_lifecycle_LifecycleOwner_(IntPtr jnienv, IntPtr native__this, IntPtr native_provider, IntPtr native_owner)
		{
			Toolbar @object = Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMenuProvider object2 = Java.Lang.Object.GetObject<IMenuProvider>(native_provider, JniHandleOwnership.DoNotTransfer);
			ILifecycleOwner object3 = Java.Lang.Object.GetObject<ILifecycleOwner>(native_owner, JniHandleOwnership.DoNotTransfer);
			@object.AddMenuProvider(object2, object3);
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x0000F888 File Offset: 0x0000DA88
		[Register("addMenuProvider", "(Landroidx/core/view/MenuProvider;Landroidx/lifecycle/LifecycleOwner;)V", "GetAddMenuProvider_Landroidx_core_view_MenuProvider_Landroidx_lifecycle_LifecycleOwner_Handler")]
		public unsafe virtual void AddMenuProvider(IMenuProvider provider, ILifecycleOwner owner)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((provider == null) ? IntPtr.Zero : ((Java.Lang.Object)provider).Handle);
				ptr[1] = new JniArgumentValue((owner == null) ? IntPtr.Zero : ((Java.Lang.Object)owner).Handle);
				Toolbar._members.InstanceMethods.InvokeVirtualVoidMethod("addMenuProvider.(Landroidx/core/view/MenuProvider;Landroidx/lifecycle/LifecycleOwner;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(provider);
				GC.KeepAlive(owner);
			}
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x0000F920 File Offset: 0x0000DB20
		private static Delegate GetAddMenuProvider_Landroidx_core_view_MenuProvider_Landroidx_lifecycle_LifecycleOwner_Landroidx_lifecycle_Lifecycle_State_Handler()
		{
			if (Toolbar.cb_addMenuProvider_Landroidx_core_view_MenuProvider_Landroidx_lifecycle_LifecycleOwner_Landroidx_lifecycle_Lifecycle_State_ == null)
			{
				Toolbar.cb_addMenuProvider_Landroidx_core_view_MenuProvider_Landroidx_lifecycle_LifecycleOwner_Landroidx_lifecycle_Lifecycle_State_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(Toolbar.n_AddMenuProvider_Landroidx_core_view_MenuProvider_Landroidx_lifecycle_LifecycleOwner_Landroidx_lifecycle_Lifecycle_State_));
			}
			return Toolbar.cb_addMenuProvider_Landroidx_core_view_MenuProvider_Landroidx_lifecycle_LifecycleOwner_Landroidx_lifecycle_Lifecycle_State_;
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x0000F944 File Offset: 0x0000DB44
		private static void n_AddMenuProvider_Landroidx_core_view_MenuProvider_Landroidx_lifecycle_LifecycleOwner_Landroidx_lifecycle_Lifecycle_State_(IntPtr jnienv, IntPtr native__this, IntPtr native_provider, IntPtr native_owner, IntPtr native_state)
		{
			Toolbar @object = Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMenuProvider object2 = Java.Lang.Object.GetObject<IMenuProvider>(native_provider, JniHandleOwnership.DoNotTransfer);
			ILifecycleOwner object3 = Java.Lang.Object.GetObject<ILifecycleOwner>(native_owner, JniHandleOwnership.DoNotTransfer);
			Lifecycle.State object4 = Java.Lang.Object.GetObject<Lifecycle.State>(native_state, JniHandleOwnership.DoNotTransfer);
			@object.AddMenuProvider(object2, object3, object4);
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x0000F97C File Offset: 0x0000DB7C
		[Register("addMenuProvider", "(Landroidx/core/view/MenuProvider;Landroidx/lifecycle/LifecycleOwner;Landroidx/lifecycle/Lifecycle$State;)V", "GetAddMenuProvider_Landroidx_core_view_MenuProvider_Landroidx_lifecycle_LifecycleOwner_Landroidx_lifecycle_Lifecycle_State_Handler")]
		public unsafe virtual void AddMenuProvider(IMenuProvider provider, ILifecycleOwner owner, Lifecycle.State state)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((provider == null) ? IntPtr.Zero : ((Java.Lang.Object)provider).Handle);
				ptr[1] = new JniArgumentValue((owner == null) ? IntPtr.Zero : ((Java.Lang.Object)owner).Handle);
				ptr[2] = new JniArgumentValue((state == null) ? IntPtr.Zero : state.Handle);
				Toolbar._members.InstanceMethods.InvokeVirtualVoidMethod("addMenuProvider.(Landroidx/core/view/MenuProvider;Landroidx/lifecycle/LifecycleOwner;Landroidx/lifecycle/Lifecycle$State;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(provider);
				GC.KeepAlive(owner);
				GC.KeepAlive(state);
			}
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x0000FA3C File Offset: 0x0000DC3C
		private static Delegate GetCanShowOverflowMenuHandler()
		{
			if (Toolbar.cb_canShowOverflowMenu == null)
			{
				Toolbar.cb_canShowOverflowMenu = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(Toolbar.n_CanShowOverflowMenu));
			}
			return Toolbar.cb_canShowOverflowMenu;
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x0000FA60 File Offset: 0x0000DC60
		private static bool n_CanShowOverflowMenu(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CanShowOverflowMenu();
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x0000FA6F File Offset: 0x0000DC6F
		[Register("canShowOverflowMenu", "()Z", "GetCanShowOverflowMenuHandler")]
		public virtual bool CanShowOverflowMenu()
		{
			return Toolbar._members.InstanceMethods.InvokeVirtualBooleanMethod("canShowOverflowMenu.()Z", this, null);
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x0000FA88 File Offset: 0x0000DC88
		private static Delegate GetCollapseActionViewHandler()
		{
			if (Toolbar.cb_collapseActionView == null)
			{
				Toolbar.cb_collapseActionView = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(Toolbar.n_CollapseActionView));
			}
			return Toolbar.cb_collapseActionView;
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x0000FAAC File Offset: 0x0000DCAC
		private static void n_CollapseActionView(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CollapseActionView();
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x0000FABB File Offset: 0x0000DCBB
		[Register("collapseActionView", "()V", "GetCollapseActionViewHandler")]
		public virtual void CollapseActionView()
		{
			Toolbar._members.InstanceMethods.InvokeVirtualVoidMethod("collapseActionView.()V", this, null);
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x0000FAD4 File Offset: 0x0000DCD4
		private static Delegate GetDismissPopupMenusHandler()
		{
			if (Toolbar.cb_dismissPopupMenus == null)
			{
				Toolbar.cb_dismissPopupMenus = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(Toolbar.n_DismissPopupMenus));
			}
			return Toolbar.cb_dismissPopupMenus;
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x0000FAF8 File Offset: 0x0000DCF8
		private static void n_DismissPopupMenus(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DismissPopupMenus();
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x0000FB07 File Offset: 0x0000DD07
		[Register("dismissPopupMenus", "()V", "GetDismissPopupMenusHandler")]
		public virtual void DismissPopupMenus()
		{
			Toolbar._members.InstanceMethods.InvokeVirtualVoidMethod("dismissPopupMenus.()V", this, null);
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x0000FB20 File Offset: 0x0000DD20
		private static Delegate GetHideOverflowMenuHandler()
		{
			if (Toolbar.cb_hideOverflowMenu == null)
			{
				Toolbar.cb_hideOverflowMenu = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(Toolbar.n_HideOverflowMenu));
			}
			return Toolbar.cb_hideOverflowMenu;
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x0000FB44 File Offset: 0x0000DD44
		private static bool n_HideOverflowMenu(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HideOverflowMenu();
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x0000FB53 File Offset: 0x0000DD53
		[Register("hideOverflowMenu", "()Z", "GetHideOverflowMenuHandler")]
		public virtual bool HideOverflowMenu()
		{
			return Toolbar._members.InstanceMethods.InvokeVirtualBooleanMethod("hideOverflowMenu.()Z", this, null);
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x0000FB6C File Offset: 0x0000DD6C
		private static Delegate GetInflateMenu_IHandler()
		{
			if (Toolbar.cb_inflateMenu_I == null)
			{
				Toolbar.cb_inflateMenu_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(Toolbar.n_InflateMenu_I));
			}
			return Toolbar.cb_inflateMenu_I;
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x0000FB90 File Offset: 0x0000DD90
		private static void n_InflateMenu_I(IntPtr jnienv, IntPtr native__this, int resId)
		{
			Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).InflateMenu(resId);
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x0000FBA0 File Offset: 0x0000DDA0
		[Register("inflateMenu", "(I)V", "GetInflateMenu_IHandler")]
		public unsafe virtual void InflateMenu(int resId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(resId);
			Toolbar._members.InstanceMethods.InvokeVirtualVoidMethod("inflateMenu.(I)V", this, ptr);
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x0000FBDB File Offset: 0x0000DDDB
		private static Delegate GetInvalidateMenuHandler()
		{
			if (Toolbar.cb_invalidateMenu == null)
			{
				Toolbar.cb_invalidateMenu = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(Toolbar.n_InvalidateMenu));
			}
			return Toolbar.cb_invalidateMenu;
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x0000FBFF File Offset: 0x0000DDFF
		private static void n_InvalidateMenu(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).InvalidateMenu();
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x0000FC0E File Offset: 0x0000DE0E
		[Register("invalidateMenu", "()V", "GetInvalidateMenuHandler")]
		public virtual void InvalidateMenu()
		{
			Toolbar._members.InstanceMethods.InvokeVirtualVoidMethod("invalidateMenu.()V", this, null);
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x0000FC27 File Offset: 0x0000DE27
		private static Delegate GetOnLayout_ZIIIIHandler()
		{
			if (Toolbar.cb_onLayout_ZIIII == null)
			{
				Toolbar.cb_onLayout_ZIIII = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZIIII_V(Toolbar.n_OnLayout_ZIIII));
			}
			return Toolbar.cb_onLayout_ZIIII;
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x0000FC4B File Offset: 0x0000DE4B
		private static void n_OnLayout_ZIIII(IntPtr jnienv, IntPtr native__this, bool changed, int l, int t, int r, int b)
		{
			Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnLayout(changed, l, t, r, b);
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x0000FC64 File Offset: 0x0000DE64
		[Register("onLayout", "(ZIIII)V", "GetOnLayout_ZIIIIHandler")]
		protected unsafe override void OnLayout(bool changed, int l, int t, int r, int b)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(changed);
			ptr[1] = new JniArgumentValue(l);
			ptr[2] = new JniArgumentValue(t);
			ptr[3] = new JniArgumentValue(r);
			ptr[4] = new JniArgumentValue(b);
			Toolbar._members.InstanceMethods.InvokeVirtualVoidMethod("onLayout.(ZIIII)V", this, ptr);
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x0000FCF6 File Offset: 0x0000DEF6
		private static Delegate GetRemoveMenuProvider_Landroidx_core_view_MenuProvider_Handler()
		{
			if (Toolbar.cb_removeMenuProvider_Landroidx_core_view_MenuProvider_ == null)
			{
				Toolbar.cb_removeMenuProvider_Landroidx_core_view_MenuProvider_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Toolbar.n_RemoveMenuProvider_Landroidx_core_view_MenuProvider_));
			}
			return Toolbar.cb_removeMenuProvider_Landroidx_core_view_MenuProvider_;
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x0000FD1C File Offset: 0x0000DF1C
		private static void n_RemoveMenuProvider_Landroidx_core_view_MenuProvider_(IntPtr jnienv, IntPtr native__this, IntPtr native_provider)
		{
			Toolbar @object = Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMenuProvider object2 = Java.Lang.Object.GetObject<IMenuProvider>(native_provider, JniHandleOwnership.DoNotTransfer);
			@object.RemoveMenuProvider(object2);
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x0000FD40 File Offset: 0x0000DF40
		[Register("removeMenuProvider", "(Landroidx/core/view/MenuProvider;)V", "GetRemoveMenuProvider_Landroidx_core_view_MenuProvider_Handler")]
		public unsafe virtual void RemoveMenuProvider(IMenuProvider provider)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((provider == null) ? IntPtr.Zero : ((Java.Lang.Object)provider).Handle);
				Toolbar._members.InstanceMethods.InvokeVirtualVoidMethod("removeMenuProvider.(Landroidx/core/view/MenuProvider;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(provider);
			}
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x0000FDA8 File Offset: 0x0000DFA8
		private static Delegate GetSetCollapseContentDescription_IHandler()
		{
			if (Toolbar.cb_setCollapseContentDescription_I == null)
			{
				Toolbar.cb_setCollapseContentDescription_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(Toolbar.n_SetCollapseContentDescription_I));
			}
			return Toolbar.cb_setCollapseContentDescription_I;
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x0000FDCC File Offset: 0x0000DFCC
		private static void n_SetCollapseContentDescription_I(IntPtr jnienv, IntPtr native__this, int resId)
		{
			Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetCollapseContentDescription(resId);
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x0000FDDC File Offset: 0x0000DFDC
		[Register("setCollapseContentDescription", "(I)V", "GetSetCollapseContentDescription_IHandler")]
		public unsafe virtual void SetCollapseContentDescription(int resId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(resId);
			Toolbar._members.InstanceMethods.InvokeVirtualVoidMethod("setCollapseContentDescription.(I)V", this, ptr);
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x0000FE17 File Offset: 0x0000E017
		private static Delegate GetSetCollapseIcon_IHandler()
		{
			if (Toolbar.cb_setCollapseIcon_I == null)
			{
				Toolbar.cb_setCollapseIcon_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(Toolbar.n_SetCollapseIcon_I));
			}
			return Toolbar.cb_setCollapseIcon_I;
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x0000FE3B File Offset: 0x0000E03B
		private static void n_SetCollapseIcon_I(IntPtr jnienv, IntPtr native__this, int resId)
		{
			Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetCollapseIcon(resId);
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x0000FE4C File Offset: 0x0000E04C
		[Register("setCollapseIcon", "(I)V", "GetSetCollapseIcon_IHandler")]
		public unsafe virtual void SetCollapseIcon(int resId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(resId);
			Toolbar._members.InstanceMethods.InvokeVirtualVoidMethod("setCollapseIcon.(I)V", this, ptr);
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x0000FE87 File Offset: 0x0000E087
		private static Delegate GetSetCollapsible_ZHandler()
		{
			if (Toolbar.cb_setCollapsible_Z == null)
			{
				Toolbar.cb_setCollapsible_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(Toolbar.n_SetCollapsible_Z));
			}
			return Toolbar.cb_setCollapsible_Z;
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x0000FEAB File Offset: 0x0000E0AB
		private static void n_SetCollapsible_Z(IntPtr jnienv, IntPtr native__this, bool collapsible)
		{
			Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetCollapsible(collapsible);
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x0000FEBC File Offset: 0x0000E0BC
		[Register("setCollapsible", "(Z)V", "GetSetCollapsible_ZHandler")]
		public unsafe virtual void SetCollapsible(bool collapsible)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(collapsible);
			Toolbar._members.InstanceMethods.InvokeVirtualVoidMethod("setCollapsible.(Z)V", this, ptr);
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x0000FEF7 File Offset: 0x0000E0F7
		private static Delegate GetSetContentInsetsAbsolute_IIHandler()
		{
			if (Toolbar.cb_setContentInsetsAbsolute_II == null)
			{
				Toolbar.cb_setContentInsetsAbsolute_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPII_V(Toolbar.n_SetContentInsetsAbsolute_II));
			}
			return Toolbar.cb_setContentInsetsAbsolute_II;
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x0000FF1B File Offset: 0x0000E11B
		private static void n_SetContentInsetsAbsolute_II(IntPtr jnienv, IntPtr native__this, int contentInsetLeft, int contentInsetRight)
		{
			Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetContentInsetsAbsolute(contentInsetLeft, contentInsetRight);
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x0000FF2C File Offset: 0x0000E12C
		[Register("setContentInsetsAbsolute", "(II)V", "GetSetContentInsetsAbsolute_IIHandler")]
		public unsafe virtual void SetContentInsetsAbsolute(int contentInsetLeft, int contentInsetRight)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(contentInsetLeft);
			ptr[1] = new JniArgumentValue(contentInsetRight);
			Toolbar._members.InstanceMethods.InvokeVirtualVoidMethod("setContentInsetsAbsolute.(II)V", this, ptr);
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x0000FF7A File Offset: 0x0000E17A
		private static Delegate GetSetContentInsetsRelative_IIHandler()
		{
			if (Toolbar.cb_setContentInsetsRelative_II == null)
			{
				Toolbar.cb_setContentInsetsRelative_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPII_V(Toolbar.n_SetContentInsetsRelative_II));
			}
			return Toolbar.cb_setContentInsetsRelative_II;
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x0000FF9E File Offset: 0x0000E19E
		private static void n_SetContentInsetsRelative_II(IntPtr jnienv, IntPtr native__this, int contentInsetStart, int contentInsetEnd)
		{
			Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetContentInsetsRelative(contentInsetStart, contentInsetEnd);
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x0000FFB0 File Offset: 0x0000E1B0
		[Register("setContentInsetsRelative", "(II)V", "GetSetContentInsetsRelative_IIHandler")]
		public unsafe virtual void SetContentInsetsRelative(int contentInsetStart, int contentInsetEnd)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(contentInsetStart);
			ptr[1] = new JniArgumentValue(contentInsetEnd);
			Toolbar._members.InstanceMethods.InvokeVirtualVoidMethod("setContentInsetsRelative.(II)V", this, ptr);
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x0000FFFE File Offset: 0x0000E1FE
		private static Delegate GetSetLogo_IHandler()
		{
			if (Toolbar.cb_setLogo_I == null)
			{
				Toolbar.cb_setLogo_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(Toolbar.n_SetLogo_I));
			}
			return Toolbar.cb_setLogo_I;
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x00010022 File Offset: 0x0000E222
		private static void n_SetLogo_I(IntPtr jnienv, IntPtr native__this, int resId)
		{
			Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetLogo(resId);
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x00010034 File Offset: 0x0000E234
		[Register("setLogo", "(I)V", "GetSetLogo_IHandler")]
		public unsafe virtual void SetLogo(int resId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(resId);
			Toolbar._members.InstanceMethods.InvokeVirtualVoidMethod("setLogo.(I)V", this, ptr);
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x0001006F File Offset: 0x0000E26F
		private static Delegate GetSetLogoDescription_IHandler()
		{
			if (Toolbar.cb_setLogoDescription_I == null)
			{
				Toolbar.cb_setLogoDescription_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(Toolbar.n_SetLogoDescription_I));
			}
			return Toolbar.cb_setLogoDescription_I;
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x00010093 File Offset: 0x0000E293
		private static void n_SetLogoDescription_I(IntPtr jnienv, IntPtr native__this, int resId)
		{
			Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetLogoDescription(resId);
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x000100A4 File Offset: 0x0000E2A4
		[Register("setLogoDescription", "(I)V", "GetSetLogoDescription_IHandler")]
		public unsafe virtual void SetLogoDescription(int resId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(resId);
			Toolbar._members.InstanceMethods.InvokeVirtualVoidMethod("setLogoDescription.(I)V", this, ptr);
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x000100DF File Offset: 0x0000E2DF
		private static Delegate GetSetMenuCallbacks_Landroidx_appcompat_view_menu_MenuPresenter_Callback_Landroidx_appcompat_view_menu_MenuBuilder_Callback_Handler()
		{
			if (Toolbar.cb_setMenuCallbacks_Landroidx_appcompat_view_menu_MenuPresenter_Callback_Landroidx_appcompat_view_menu_MenuBuilder_Callback_ == null)
			{
				Toolbar.cb_setMenuCallbacks_Landroidx_appcompat_view_menu_MenuPresenter_Callback_Landroidx_appcompat_view_menu_MenuBuilder_Callback_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(Toolbar.n_SetMenuCallbacks_Landroidx_appcompat_view_menu_MenuPresenter_Callback_Landroidx_appcompat_view_menu_MenuBuilder_Callback_));
			}
			return Toolbar.cb_setMenuCallbacks_Landroidx_appcompat_view_menu_MenuPresenter_Callback_Landroidx_appcompat_view_menu_MenuBuilder_Callback_;
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x00010104 File Offset: 0x0000E304
		private static void n_SetMenuCallbacks_Landroidx_appcompat_view_menu_MenuPresenter_Callback_Landroidx_appcompat_view_menu_MenuBuilder_Callback_(IntPtr jnienv, IntPtr native__this, IntPtr native_pcb, IntPtr native_mcb)
		{
			Toolbar @object = Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMenuPresenterCallback object2 = Java.Lang.Object.GetObject<IMenuPresenterCallback>(native_pcb, JniHandleOwnership.DoNotTransfer);
			MenuBuilder.ICallback object3 = Java.Lang.Object.GetObject<MenuBuilder.ICallback>(native_mcb, JniHandleOwnership.DoNotTransfer);
			@object.SetMenuCallbacks(object2, object3);
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x00010130 File Offset: 0x0000E330
		[Register("setMenuCallbacks", "(Landroidx/appcompat/view/menu/MenuPresenter$Callback;Landroidx/appcompat/view/menu/MenuBuilder$Callback;)V", "GetSetMenuCallbacks_Landroidx_appcompat_view_menu_MenuPresenter_Callback_Landroidx_appcompat_view_menu_MenuBuilder_Callback_Handler")]
		public unsafe virtual void SetMenuCallbacks(IMenuPresenterCallback pcb, MenuBuilder.ICallback mcb)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((pcb == null) ? IntPtr.Zero : ((Java.Lang.Object)pcb).Handle);
				ptr[1] = new JniArgumentValue((mcb == null) ? IntPtr.Zero : ((Java.Lang.Object)mcb).Handle);
				Toolbar._members.InstanceMethods.InvokeVirtualVoidMethod("setMenuCallbacks.(Landroidx/appcompat/view/menu/MenuPresenter$Callback;Landroidx/appcompat/view/menu/MenuBuilder$Callback;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(pcb);
				GC.KeepAlive(mcb);
			}
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x000101C8 File Offset: 0x0000E3C8
		private static Delegate GetSetNavigationContentDescription_IHandler()
		{
			if (Toolbar.cb_setNavigationContentDescription_I == null)
			{
				Toolbar.cb_setNavigationContentDescription_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(Toolbar.n_SetNavigationContentDescription_I));
			}
			return Toolbar.cb_setNavigationContentDescription_I;
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x000101EC File Offset: 0x0000E3EC
		private static void n_SetNavigationContentDescription_I(IntPtr jnienv, IntPtr native__this, int resId)
		{
			Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetNavigationContentDescription(resId);
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x000101FC File Offset: 0x0000E3FC
		[Register("setNavigationContentDescription", "(I)V", "GetSetNavigationContentDescription_IHandler")]
		public unsafe virtual void SetNavigationContentDescription(int resId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(resId);
			Toolbar._members.InstanceMethods.InvokeVirtualVoidMethod("setNavigationContentDescription.(I)V", this, ptr);
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x00010237 File Offset: 0x0000E437
		private static Delegate GetSetNavigationIcon_IHandler()
		{
			if (Toolbar.cb_setNavigationIcon_I == null)
			{
				Toolbar.cb_setNavigationIcon_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(Toolbar.n_SetNavigationIcon_I));
			}
			return Toolbar.cb_setNavigationIcon_I;
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x0001025B File Offset: 0x0000E45B
		private static void n_SetNavigationIcon_I(IntPtr jnienv, IntPtr native__this, int resId)
		{
			Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetNavigationIcon(resId);
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x0001026C File Offset: 0x0000E46C
		[Register("setNavigationIcon", "(I)V", "GetSetNavigationIcon_IHandler")]
		public unsafe virtual void SetNavigationIcon(int resId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(resId);
			Toolbar._members.InstanceMethods.InvokeVirtualVoidMethod("setNavigationIcon.(I)V", this, ptr);
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x000102A7 File Offset: 0x0000E4A7
		private static Delegate GetSetNavigationOnClickListener_Landroid_view_View_OnClickListener_Handler()
		{
			if (Toolbar.cb_setNavigationOnClickListener_Landroid_view_View_OnClickListener_ == null)
			{
				Toolbar.cb_setNavigationOnClickListener_Landroid_view_View_OnClickListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Toolbar.n_SetNavigationOnClickListener_Landroid_view_View_OnClickListener_));
			}
			return Toolbar.cb_setNavigationOnClickListener_Landroid_view_View_OnClickListener_;
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x000102CC File Offset: 0x0000E4CC
		private static void n_SetNavigationOnClickListener_Landroid_view_View_OnClickListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			Toolbar @object = Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View.IOnClickListener object2 = Java.Lang.Object.GetObject<View.IOnClickListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.SetNavigationOnClickListener(object2);
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x000102F0 File Offset: 0x0000E4F0
		[Register("setNavigationOnClickListener", "(Landroid/view/View$OnClickListener;)V", "GetSetNavigationOnClickListener_Landroid_view_View_OnClickListener_Handler")]
		public unsafe virtual void SetNavigationOnClickListener(View.IOnClickListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				Toolbar._members.InstanceMethods.InvokeVirtualVoidMethod("setNavigationOnClickListener.(Landroid/view/View$OnClickListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x00010358 File Offset: 0x0000E558
		private static Delegate GetSetOnMenuItemClickListener_Landroidx_appcompat_widget_Toolbar_OnMenuItemClickListener_Handler()
		{
			if (Toolbar.cb_setOnMenuItemClickListener_Landroidx_appcompat_widget_Toolbar_OnMenuItemClickListener_ == null)
			{
				Toolbar.cb_setOnMenuItemClickListener_Landroidx_appcompat_widget_Toolbar_OnMenuItemClickListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Toolbar.n_SetOnMenuItemClickListener_Landroidx_appcompat_widget_Toolbar_OnMenuItemClickListener_));
			}
			return Toolbar.cb_setOnMenuItemClickListener_Landroidx_appcompat_widget_Toolbar_OnMenuItemClickListener_;
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x0001037C File Offset: 0x0000E57C
		private static void n_SetOnMenuItemClickListener_Landroidx_appcompat_widget_Toolbar_OnMenuItemClickListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			Toolbar @object = Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Toolbar.IOnMenuItemClickListener object2 = Java.Lang.Object.GetObject<Toolbar.IOnMenuItemClickListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.SetOnMenuItemClickListener(object2);
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x000103A0 File Offset: 0x0000E5A0
		[Register("setOnMenuItemClickListener", "(Landroidx/appcompat/widget/Toolbar$OnMenuItemClickListener;)V", "GetSetOnMenuItemClickListener_Landroidx_appcompat_widget_Toolbar_OnMenuItemClickListener_Handler")]
		public unsafe virtual void SetOnMenuItemClickListener(Toolbar.IOnMenuItemClickListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				Toolbar._members.InstanceMethods.InvokeVirtualVoidMethod("setOnMenuItemClickListener.(Landroidx/appcompat/widget/Toolbar$OnMenuItemClickListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x00010408 File Offset: 0x0000E608
		private static Delegate GetSetSubtitle_IHandler()
		{
			if (Toolbar.cb_setSubtitle_I == null)
			{
				Toolbar.cb_setSubtitle_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(Toolbar.n_SetSubtitle_I));
			}
			return Toolbar.cb_setSubtitle_I;
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x0001042C File Offset: 0x0000E62C
		private static void n_SetSubtitle_I(IntPtr jnienv, IntPtr native__this, int resId)
		{
			Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetSubtitle(resId);
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x0001043C File Offset: 0x0000E63C
		[Register("setSubtitle", "(I)V", "GetSetSubtitle_IHandler")]
		public unsafe virtual void SetSubtitle(int resId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(resId);
			Toolbar._members.InstanceMethods.InvokeVirtualVoidMethod("setSubtitle.(I)V", this, ptr);
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x00010477 File Offset: 0x0000E677
		private static Delegate GetSetSubtitleTextAppearance_Landroid_content_Context_IHandler()
		{
			if (Toolbar.cb_setSubtitleTextAppearance_Landroid_content_Context_I == null)
			{
				Toolbar.cb_setSubtitleTextAppearance_Landroid_content_Context_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(Toolbar.n_SetSubtitleTextAppearance_Landroid_content_Context_I));
			}
			return Toolbar.cb_setSubtitleTextAppearance_Landroid_content_Context_I;
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x0001049C File Offset: 0x0000E69C
		private static void n_SetSubtitleTextAppearance_Landroid_content_Context_I(IntPtr jnienv, IntPtr native__this, IntPtr native_context, int resId)
		{
			Toolbar @object = Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_context, JniHandleOwnership.DoNotTransfer);
			@object.SetSubtitleTextAppearance(object2, resId);
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x000104C0 File Offset: 0x0000E6C0
		[Register("setSubtitleTextAppearance", "(Landroid/content/Context;I)V", "GetSetSubtitleTextAppearance_Landroid_content_Context_IHandler")]
		public unsafe virtual void SetSubtitleTextAppearance(Context context, int resId)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue(resId);
				Toolbar._members.InstanceMethods.InvokeVirtualVoidMethod("setSubtitleTextAppearance.(Landroid/content/Context;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x00010538 File Offset: 0x0000E738
		private static Delegate GetSetSubtitleTextColor_Landroid_content_res_ColorStateList_Handler()
		{
			if (Toolbar.cb_setSubtitleTextColor_Landroid_content_res_ColorStateList_ == null)
			{
				Toolbar.cb_setSubtitleTextColor_Landroid_content_res_ColorStateList_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Toolbar.n_SetSubtitleTextColor_Landroid_content_res_ColorStateList_));
			}
			return Toolbar.cb_setSubtitleTextColor_Landroid_content_res_ColorStateList_;
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x0001055C File Offset: 0x0000E75C
		private static void n_SetSubtitleTextColor_Landroid_content_res_ColorStateList_(IntPtr jnienv, IntPtr native__this, IntPtr native_color)
		{
			Toolbar @object = Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ColorStateList object2 = Java.Lang.Object.GetObject<ColorStateList>(native_color, JniHandleOwnership.DoNotTransfer);
			@object.SetSubtitleTextColor(object2);
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x00010580 File Offset: 0x0000E780
		[Register("setSubtitleTextColor", "(Landroid/content/res/ColorStateList;)V", "GetSetSubtitleTextColor_Landroid_content_res_ColorStateList_Handler")]
		public unsafe virtual void SetSubtitleTextColor(ColorStateList color)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((color == null) ? IntPtr.Zero : color.Handle);
				Toolbar._members.InstanceMethods.InvokeVirtualVoidMethod("setSubtitleTextColor.(Landroid/content/res/ColorStateList;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(color);
			}
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x000105E4 File Offset: 0x0000E7E4
		private static Delegate GetSetSubtitleTextColor_IHandler()
		{
			if (Toolbar.cb_setSubtitleTextColor_I == null)
			{
				Toolbar.cb_setSubtitleTextColor_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(Toolbar.n_SetSubtitleTextColor_I));
			}
			return Toolbar.cb_setSubtitleTextColor_I;
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x00010608 File Offset: 0x0000E808
		private static void n_SetSubtitleTextColor_I(IntPtr jnienv, IntPtr native__this, int color)
		{
			Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetSubtitleTextColor(color);
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x00010618 File Offset: 0x0000E818
		[Register("setSubtitleTextColor", "(I)V", "GetSetSubtitleTextColor_IHandler")]
		public unsafe virtual void SetSubtitleTextColor(int color)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(color);
			Toolbar._members.InstanceMethods.InvokeVirtualVoidMethod("setSubtitleTextColor.(I)V", this, ptr);
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x00010653 File Offset: 0x0000E853
		private static Delegate GetSetTitle_IHandler()
		{
			if (Toolbar.cb_setTitle_I == null)
			{
				Toolbar.cb_setTitle_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(Toolbar.n_SetTitle_I));
			}
			return Toolbar.cb_setTitle_I;
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x00010677 File Offset: 0x0000E877
		private static void n_SetTitle_I(IntPtr jnienv, IntPtr native__this, int resId)
		{
			Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetTitle(resId);
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x00010688 File Offset: 0x0000E888
		[Register("setTitle", "(I)V", "GetSetTitle_IHandler")]
		public unsafe virtual void SetTitle(int resId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(resId);
			Toolbar._members.InstanceMethods.InvokeVirtualVoidMethod("setTitle.(I)V", this, ptr);
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x000106C3 File Offset: 0x0000E8C3
		private static Delegate GetSetTitleMargin_IIIIHandler()
		{
			if (Toolbar.cb_setTitleMargin_IIII == null)
			{
				Toolbar.cb_setTitleMargin_IIII = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIIII_V(Toolbar.n_SetTitleMargin_IIII));
			}
			return Toolbar.cb_setTitleMargin_IIII;
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x000106E7 File Offset: 0x0000E8E7
		private static void n_SetTitleMargin_IIII(IntPtr jnienv, IntPtr native__this, int start, int top, int end, int bottom)
		{
			Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetTitleMargin(start, top, end, bottom);
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x000106FC File Offset: 0x0000E8FC
		[Register("setTitleMargin", "(IIII)V", "GetSetTitleMargin_IIIIHandler")]
		public unsafe virtual void SetTitleMargin(int start, int top, int end, int bottom)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(start);
			ptr[1] = new JniArgumentValue(top);
			ptr[2] = new JniArgumentValue(end);
			ptr[3] = new JniArgumentValue(bottom);
			Toolbar._members.InstanceMethods.InvokeVirtualVoidMethod("setTitleMargin.(IIII)V", this, ptr);
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x00010777 File Offset: 0x0000E977
		private static Delegate GetSetTitleTextAppearance_Landroid_content_Context_IHandler()
		{
			if (Toolbar.cb_setTitleTextAppearance_Landroid_content_Context_I == null)
			{
				Toolbar.cb_setTitleTextAppearance_Landroid_content_Context_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(Toolbar.n_SetTitleTextAppearance_Landroid_content_Context_I));
			}
			return Toolbar.cb_setTitleTextAppearance_Landroid_content_Context_I;
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x0001079C File Offset: 0x0000E99C
		private static void n_SetTitleTextAppearance_Landroid_content_Context_I(IntPtr jnienv, IntPtr native__this, IntPtr native_context, int resId)
		{
			Toolbar @object = Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_context, JniHandleOwnership.DoNotTransfer);
			@object.SetTitleTextAppearance(object2, resId);
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x000107C0 File Offset: 0x0000E9C0
		[Register("setTitleTextAppearance", "(Landroid/content/Context;I)V", "GetSetTitleTextAppearance_Landroid_content_Context_IHandler")]
		public unsafe virtual void SetTitleTextAppearance(Context context, int resId)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue(resId);
				Toolbar._members.InstanceMethods.InvokeVirtualVoidMethod("setTitleTextAppearance.(Landroid/content/Context;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x00010838 File Offset: 0x0000EA38
		private static Delegate GetSetTitleTextColor_Landroid_content_res_ColorStateList_Handler()
		{
			if (Toolbar.cb_setTitleTextColor_Landroid_content_res_ColorStateList_ == null)
			{
				Toolbar.cb_setTitleTextColor_Landroid_content_res_ColorStateList_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Toolbar.n_SetTitleTextColor_Landroid_content_res_ColorStateList_));
			}
			return Toolbar.cb_setTitleTextColor_Landroid_content_res_ColorStateList_;
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x0001085C File Offset: 0x0000EA5C
		private static void n_SetTitleTextColor_Landroid_content_res_ColorStateList_(IntPtr jnienv, IntPtr native__this, IntPtr native_color)
		{
			Toolbar @object = Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ColorStateList object2 = Java.Lang.Object.GetObject<ColorStateList>(native_color, JniHandleOwnership.DoNotTransfer);
			@object.SetTitleTextColor(object2);
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x00010880 File Offset: 0x0000EA80
		[Register("setTitleTextColor", "(Landroid/content/res/ColorStateList;)V", "GetSetTitleTextColor_Landroid_content_res_ColorStateList_Handler")]
		public unsafe virtual void SetTitleTextColor(ColorStateList color)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((color == null) ? IntPtr.Zero : color.Handle);
				Toolbar._members.InstanceMethods.InvokeVirtualVoidMethod("setTitleTextColor.(Landroid/content/res/ColorStateList;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(color);
			}
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x000108E4 File Offset: 0x0000EAE4
		private static Delegate GetSetTitleTextColor_IHandler()
		{
			if (Toolbar.cb_setTitleTextColor_I == null)
			{
				Toolbar.cb_setTitleTextColor_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(Toolbar.n_SetTitleTextColor_I));
			}
			return Toolbar.cb_setTitleTextColor_I;
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x00010908 File Offset: 0x0000EB08
		private static void n_SetTitleTextColor_I(IntPtr jnienv, IntPtr native__this, int color)
		{
			Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetTitleTextColor(color);
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x00010918 File Offset: 0x0000EB18
		[Register("setTitleTextColor", "(I)V", "GetSetTitleTextColor_IHandler")]
		public unsafe virtual void SetTitleTextColor(int color)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(color);
			Toolbar._members.InstanceMethods.InvokeVirtualVoidMethod("setTitleTextColor.(I)V", this, ptr);
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x00010953 File Offset: 0x0000EB53
		private static Delegate GetShowOverflowMenuHandler()
		{
			if (Toolbar.cb_showOverflowMenu == null)
			{
				Toolbar.cb_showOverflowMenu = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(Toolbar.n_ShowOverflowMenu));
			}
			return Toolbar.cb_showOverflowMenu;
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x00010977 File Offset: 0x0000EB77
		private static bool n_ShowOverflowMenu(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Toolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ShowOverflowMenu();
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x00010986 File Offset: 0x0000EB86
		[Register("showOverflowMenu", "()Z", "GetShowOverflowMenuHandler")]
		public virtual bool ShowOverflowMenu()
		{
			return Toolbar._members.InstanceMethods.InvokeVirtualBooleanMethod("showOverflowMenu.()Z", this, null);
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000641 RID: 1601 RVA: 0x000109A0 File Offset: 0x0000EBA0
		// (remove) Token: 0x06000642 RID: 1602 RVA: 0x000109EC File Offset: 0x0000EBEC
		public event EventHandler<Toolbar.MenuItemClickEventArgs> MenuItemClick
		{
			add
			{
				EventHelper.AddEventHandler<Toolbar.IOnMenuItemClickListener, Toolbar.IOnMenuItemClickListenerImplementor>(ref this.weak_implementor_SetOnMenuItemClickListener, new Func<Toolbar.IOnMenuItemClickListenerImplementor>(this.__CreateIOnMenuItemClickListenerImplementor), new Action<Toolbar.IOnMenuItemClickListener>(this.SetOnMenuItemClickListener), delegate(Toolbar.IOnMenuItemClickListenerImplementor __h)
				{
					__h.Handler = (EventHandler<Toolbar.MenuItemClickEventArgs>)Delegate.Combine(__h.Handler, value);
				});
			}
			remove
			{
				Func<Toolbar.IOnMenuItemClickListenerImplementor, bool> empty;
				if ((empty = Toolbar.<>O.<0>____IsEmpty) == null)
				{
					empty = (Toolbar.<>O.<0>____IsEmpty = new Func<Toolbar.IOnMenuItemClickListenerImplementor, bool>(Toolbar.IOnMenuItemClickListenerImplementor.__IsEmpty));
				}
				EventHelper.RemoveEventHandler<Toolbar.IOnMenuItemClickListener, Toolbar.IOnMenuItemClickListenerImplementor>(ref this.weak_implementor_SetOnMenuItemClickListener, empty, delegate(Toolbar.IOnMenuItemClickListener __v)
				{
					this.SetOnMenuItemClickListener(null);
				}, delegate(Toolbar.IOnMenuItemClickListenerImplementor __h)
				{
					__h.Handler = (EventHandler<Toolbar.MenuItemClickEventArgs>)Delegate.Remove(__h.Handler, value);
				});
			}
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x00010A4B File Offset: 0x0000EC4B
		private Toolbar.IOnMenuItemClickListenerImplementor __CreateIOnMenuItemClickListenerImplementor()
		{
			return new Toolbar.IOnMenuItemClickListenerImplementor(this);
		}

		// Token: 0x04000139 RID: 313
		internal WeakReference weakNavigationOnClickDispatcher;

		// Token: 0x0400013A RID: 314
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/appcompat/widget/Toolbar", typeof(Toolbar));

		// Token: 0x0400013B RID: 315
		private static Delegate cb_isBackInvokedCallbackEnabled;

		// Token: 0x0400013C RID: 316
		private static Delegate cb_setBackInvokedCallbackEnabled_Z;

		// Token: 0x0400013D RID: 317
		private static Delegate cb_getCollapseContentDescription;

		// Token: 0x0400013E RID: 318
		private static Delegate cb_setCollapseContentDescription_Ljava_lang_CharSequence_;

		// Token: 0x0400013F RID: 319
		private static Delegate cb_getCollapseIcon;

		// Token: 0x04000140 RID: 320
		private static Delegate cb_setCollapseIcon_Landroid_graphics_drawable_Drawable_;

		// Token: 0x04000141 RID: 321
		private static Delegate cb_getContentInsetEnd;

		// Token: 0x04000142 RID: 322
		private static Delegate cb_getContentInsetEndWithActions;

		// Token: 0x04000143 RID: 323
		private static Delegate cb_setContentInsetEndWithActions_I;

		// Token: 0x04000144 RID: 324
		private static Delegate cb_getContentInsetLeft;

		// Token: 0x04000145 RID: 325
		private static Delegate cb_getContentInsetRight;

		// Token: 0x04000146 RID: 326
		private static Delegate cb_getContentInsetStart;

		// Token: 0x04000147 RID: 327
		private static Delegate cb_getContentInsetStartWithNavigation;

		// Token: 0x04000148 RID: 328
		private static Delegate cb_setContentInsetStartWithNavigation_I;

		// Token: 0x04000149 RID: 329
		private static Delegate cb_getCurrentContentInsetEnd;

		// Token: 0x0400014A RID: 330
		private static Delegate cb_getCurrentContentInsetLeft;

		// Token: 0x0400014B RID: 331
		private static Delegate cb_getCurrentContentInsetRight;

		// Token: 0x0400014C RID: 332
		private static Delegate cb_getCurrentContentInsetStart;

		// Token: 0x0400014D RID: 333
		private static Delegate cb_hasExpandedActionView;

		// Token: 0x0400014E RID: 334
		private static Delegate cb_isOverflowMenuShowPending;

		// Token: 0x0400014F RID: 335
		private static Delegate cb_isOverflowMenuShowing;

		// Token: 0x04000150 RID: 336
		private static Delegate cb_isTitleTruncated;

		// Token: 0x04000151 RID: 337
		private static Delegate cb_getLogo;

		// Token: 0x04000152 RID: 338
		private static Delegate cb_setLogo_Landroid_graphics_drawable_Drawable_;

		// Token: 0x04000153 RID: 339
		private static Delegate cb_getLogoDescription;

		// Token: 0x04000154 RID: 340
		private static Delegate cb_setLogoDescription_Ljava_lang_CharSequence_;

		// Token: 0x04000155 RID: 341
		private static Delegate cb_getMenu;

		// Token: 0x04000156 RID: 342
		private static Delegate cb_getNavigationContentDescription;

		// Token: 0x04000157 RID: 343
		private static Delegate cb_setNavigationContentDescription_Ljava_lang_CharSequence_;

		// Token: 0x04000158 RID: 344
		private static Delegate cb_getNavigationIcon;

		// Token: 0x04000159 RID: 345
		private static Delegate cb_setNavigationIcon_Landroid_graphics_drawable_Drawable_;

		// Token: 0x0400015A RID: 346
		private static Delegate cb_getOverflowIcon;

		// Token: 0x0400015B RID: 347
		private static Delegate cb_setOverflowIcon_Landroid_graphics_drawable_Drawable_;

		// Token: 0x0400015C RID: 348
		private static Delegate cb_getPopupTheme;

		// Token: 0x0400015D RID: 349
		private static Delegate cb_setPopupTheme_I;

		// Token: 0x0400015E RID: 350
		private static Delegate cb_getSubtitle;

		// Token: 0x0400015F RID: 351
		private static Delegate cb_setSubtitle_Ljava_lang_CharSequence_;

		// Token: 0x04000160 RID: 352
		private static Delegate cb_getTitle;

		// Token: 0x04000161 RID: 353
		private static Delegate cb_setTitle_Ljava_lang_CharSequence_;

		// Token: 0x04000162 RID: 354
		private static Delegate cb_getTitleMarginBottom;

		// Token: 0x04000163 RID: 355
		private static Delegate cb_setTitleMarginBottom_I;

		// Token: 0x04000164 RID: 356
		private static Delegate cb_getTitleMarginEnd;

		// Token: 0x04000165 RID: 357
		private static Delegate cb_setTitleMarginEnd_I;

		// Token: 0x04000166 RID: 358
		private static Delegate cb_getTitleMarginStart;

		// Token: 0x04000167 RID: 359
		private static Delegate cb_setTitleMarginStart_I;

		// Token: 0x04000168 RID: 360
		private static Delegate cb_getTitleMarginTop;

		// Token: 0x04000169 RID: 361
		private static Delegate cb_setTitleMarginTop_I;

		// Token: 0x0400016A RID: 362
		private static Delegate cb_getWrapper;

		// Token: 0x0400016B RID: 363
		private static Delegate cb_addMenuProvider_Landroidx_core_view_MenuProvider_;

		// Token: 0x0400016C RID: 364
		private static Delegate cb_addMenuProvider_Landroidx_core_view_MenuProvider_Landroidx_lifecycle_LifecycleOwner_;

		// Token: 0x0400016D RID: 365
		private static Delegate cb_addMenuProvider_Landroidx_core_view_MenuProvider_Landroidx_lifecycle_LifecycleOwner_Landroidx_lifecycle_Lifecycle_State_;

		// Token: 0x0400016E RID: 366
		private static Delegate cb_canShowOverflowMenu;

		// Token: 0x0400016F RID: 367
		private static Delegate cb_collapseActionView;

		// Token: 0x04000170 RID: 368
		private static Delegate cb_dismissPopupMenus;

		// Token: 0x04000171 RID: 369
		private static Delegate cb_hideOverflowMenu;

		// Token: 0x04000172 RID: 370
		private static Delegate cb_inflateMenu_I;

		// Token: 0x04000173 RID: 371
		private static Delegate cb_invalidateMenu;

		// Token: 0x04000174 RID: 372
		private static Delegate cb_onLayout_ZIIII;

		// Token: 0x04000175 RID: 373
		private static Delegate cb_removeMenuProvider_Landroidx_core_view_MenuProvider_;

		// Token: 0x04000176 RID: 374
		private static Delegate cb_setCollapseContentDescription_I;

		// Token: 0x04000177 RID: 375
		private static Delegate cb_setCollapseIcon_I;

		// Token: 0x04000178 RID: 376
		private static Delegate cb_setCollapsible_Z;

		// Token: 0x04000179 RID: 377
		private static Delegate cb_setContentInsetsAbsolute_II;

		// Token: 0x0400017A RID: 378
		private static Delegate cb_setContentInsetsRelative_II;

		// Token: 0x0400017B RID: 379
		private static Delegate cb_setLogo_I;

		// Token: 0x0400017C RID: 380
		private static Delegate cb_setLogoDescription_I;

		// Token: 0x0400017D RID: 381
		private static Delegate cb_setMenuCallbacks_Landroidx_appcompat_view_menu_MenuPresenter_Callback_Landroidx_appcompat_view_menu_MenuBuilder_Callback_;

		// Token: 0x0400017E RID: 382
		private static Delegate cb_setNavigationContentDescription_I;

		// Token: 0x0400017F RID: 383
		private static Delegate cb_setNavigationIcon_I;

		// Token: 0x04000180 RID: 384
		private static Delegate cb_setNavigationOnClickListener_Landroid_view_View_OnClickListener_;

		// Token: 0x04000181 RID: 385
		private static Delegate cb_setOnMenuItemClickListener_Landroidx_appcompat_widget_Toolbar_OnMenuItemClickListener_;

		// Token: 0x04000182 RID: 386
		private static Delegate cb_setSubtitle_I;

		// Token: 0x04000183 RID: 387
		private static Delegate cb_setSubtitleTextAppearance_Landroid_content_Context_I;

		// Token: 0x04000184 RID: 388
		private static Delegate cb_setSubtitleTextColor_Landroid_content_res_ColorStateList_;

		// Token: 0x04000185 RID: 389
		private static Delegate cb_setSubtitleTextColor_I;

		// Token: 0x04000186 RID: 390
		private static Delegate cb_setTitle_I;

		// Token: 0x04000187 RID: 391
		private static Delegate cb_setTitleMargin_IIII;

		// Token: 0x04000188 RID: 392
		private static Delegate cb_setTitleTextAppearance_Landroid_content_Context_I;

		// Token: 0x04000189 RID: 393
		private static Delegate cb_setTitleTextColor_Landroid_content_res_ColorStateList_;

		// Token: 0x0400018A RID: 394
		private static Delegate cb_setTitleTextColor_I;

		// Token: 0x0400018B RID: 395
		private static Delegate cb_showOverflowMenu;

		// Token: 0x0400018C RID: 396
		private WeakReference weak_implementor_SetOnMenuItemClickListener;

		// Token: 0x0200005C RID: 92
		internal class NavigationOnClickEventDispatcher : Java.Lang.Object, View.IOnClickListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06000645 RID: 1605 RVA: 0x00010A6E File Offset: 0x0000EC6E
			public NavigationOnClickEventDispatcher(Toolbar sender)
			{
				this.sender = sender;
			}

			// Token: 0x06000646 RID: 1606 RVA: 0x00010A80 File Offset: 0x0000EC80
			public void OnClick(View v)
			{
				EventHandler<Toolbar.NavigationClickEventArgs> navigationClick = this.NavigationClick;
				if (navigationClick != null)
				{
					navigationClick(this.sender, new Toolbar.NavigationClickEventArgs
					{
						View = v
					});
				}
			}

			// Token: 0x0400018D RID: 397
			private Toolbar sender;

			// Token: 0x0400018E RID: 398
			internal EventHandler<Toolbar.NavigationClickEventArgs> NavigationClick;
		}

		// Token: 0x0200005D RID: 93
		public class NavigationClickEventArgs : EventArgs
		{
			// Token: 0x170000CF RID: 207
			// (set) Token: 0x06000647 RID: 1607 RVA: 0x00010AAF File Offset: 0x0000ECAF
			internal View View
			{
				[CompilerGenerated]
				set
				{
					this.<View>k__BackingField = value;
				}
			}
		}

		// Token: 0x0200005E RID: 94
		[Register("androidx/appcompat/widget/Toolbar$OnMenuItemClickListener", "", "AndroidX.AppCompat.Widget.Toolbar/IOnMenuItemClickListenerInvoker")]
		public interface IOnMenuItemClickListener : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06000649 RID: 1609
			[Register("onMenuItemClick", "(Landroid/view/MenuItem;)Z", "GetOnMenuItemClick_Landroid_view_MenuItem_Handler:AndroidX.AppCompat.Widget.Toolbar/IOnMenuItemClickListenerInvoker, Xamarin.AndroidX.AppCompat")]
			bool OnMenuItemClick(IMenuItem item);
		}

		// Token: 0x0200005F RID: 95
		[Register("androidx/appcompat/widget/Toolbar$OnMenuItemClickListener", DoNotGenerateAcw = true)]
		internal class IOnMenuItemClickListenerInvoker : Java.Lang.Object, Toolbar.IOnMenuItemClickListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x170000D0 RID: 208
			// (get) Token: 0x0600064A RID: 1610 RVA: 0x00010AC0 File Offset: 0x0000ECC0
			private static IntPtr java_class_ref
			{
				get
				{
					return Toolbar.IOnMenuItemClickListenerInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000D1 RID: 209
			// (get) Token: 0x0600064B RID: 1611 RVA: 0x00010AE4 File Offset: 0x0000ECE4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return Toolbar.IOnMenuItemClickListenerInvoker._members;
				}
			}

			// Token: 0x170000D2 RID: 210
			// (get) Token: 0x0600064C RID: 1612 RVA: 0x00010AEB File Offset: 0x0000ECEB
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x170000D3 RID: 211
			// (get) Token: 0x0600064D RID: 1613 RVA: 0x00010AF3 File Offset: 0x0000ECF3
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return Toolbar.IOnMenuItemClickListenerInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x0600064E RID: 1614 RVA: 0x00010AFF File Offset: 0x0000ECFF
			public static Toolbar.IOnMenuItemClickListener GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<Toolbar.IOnMenuItemClickListener>(handle, transfer);
			}

			// Token: 0x0600064F RID: 1615 RVA: 0x00010B08 File Offset: 0x0000ED08
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, Toolbar.IOnMenuItemClickListenerInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.appcompat.widget.Toolbar.OnMenuItemClickListener'.");
				}
				return handle;
			}

			// Token: 0x06000650 RID: 1616 RVA: 0x00010B33 File Offset: 0x0000ED33
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06000651 RID: 1617 RVA: 0x00010B64 File Offset: 0x0000ED64
			public IOnMenuItemClickListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(Toolbar.IOnMenuItemClickListenerInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x06000652 RID: 1618 RVA: 0x00010B9C File Offset: 0x0000ED9C
			private static Delegate GetOnMenuItemClick_Landroid_view_MenuItem_Handler()
			{
				if (Toolbar.IOnMenuItemClickListenerInvoker.cb_onMenuItemClick_Landroid_view_MenuItem_ == null)
				{
					Toolbar.IOnMenuItemClickListenerInvoker.cb_onMenuItemClick_Landroid_view_MenuItem_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(Toolbar.IOnMenuItemClickListenerInvoker.n_OnMenuItemClick_Landroid_view_MenuItem_));
				}
				return Toolbar.IOnMenuItemClickListenerInvoker.cb_onMenuItemClick_Landroid_view_MenuItem_;
			}

			// Token: 0x06000653 RID: 1619 RVA: 0x00010BC0 File Offset: 0x0000EDC0
			private static bool n_OnMenuItemClick_Landroid_view_MenuItem_(IntPtr jnienv, IntPtr native__this, IntPtr native_item)
			{
				Toolbar.IOnMenuItemClickListener @object = Java.Lang.Object.GetObject<Toolbar.IOnMenuItemClickListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				IMenuItem object2 = Java.Lang.Object.GetObject<IMenuItem>(native_item, JniHandleOwnership.DoNotTransfer);
				return @object.OnMenuItemClick(object2);
			}

			// Token: 0x06000654 RID: 1620 RVA: 0x00010BE4 File Offset: 0x0000EDE4
			public unsafe bool OnMenuItemClick(IMenuItem item)
			{
				if (this.id_onMenuItemClick_Landroid_view_MenuItem_ == IntPtr.Zero)
				{
					this.id_onMenuItemClick_Landroid_view_MenuItem_ = JNIEnv.GetMethodID(this.class_ref, "onMenuItemClick", "(Landroid/view/MenuItem;)Z");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((item == null) ? IntPtr.Zero : ((Java.Lang.Object)item).Handle);
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_onMenuItemClick_Landroid_view_MenuItem_, ptr);
			}

			// Token: 0x04000190 RID: 400
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/appcompat/widget/Toolbar$OnMenuItemClickListener", typeof(Toolbar.IOnMenuItemClickListenerInvoker));

			// Token: 0x04000191 RID: 401
			private IntPtr class_ref;

			// Token: 0x04000192 RID: 402
			private static Delegate cb_onMenuItemClick_Landroid_view_MenuItem_;

			// Token: 0x04000193 RID: 403
			private IntPtr id_onMenuItemClick_Landroid_view_MenuItem_;
		}

		// Token: 0x02000060 RID: 96
		public class MenuItemClickEventArgs : EventArgs
		{
			// Token: 0x170000D4 RID: 212
			// (get) Token: 0x06000656 RID: 1622 RVA: 0x00010C77 File Offset: 0x0000EE77
			public bool Handled
			{
				get
				{
					return this.handled;
				}
			}

			// Token: 0x06000657 RID: 1623 RVA: 0x00010C7F File Offset: 0x0000EE7F
			public MenuItemClickEventArgs(bool handled, IMenuItem item)
			{
				this.handled = handled;
				this.item = item;
			}

			// Token: 0x04000194 RID: 404
			private bool handled;

			// Token: 0x04000195 RID: 405
			private IMenuItem item;
		}

		// Token: 0x02000061 RID: 97
		[Register("mono/androidx/appcompat/widget/Toolbar_OnMenuItemClickListenerImplementor")]
		internal sealed class IOnMenuItemClickListenerImplementor : Java.Lang.Object, Toolbar.IOnMenuItemClickListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06000658 RID: 1624 RVA: 0x00010C95 File Offset: 0x0000EE95
			public IOnMenuItemClickListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/androidx/appcompat/widget/Toolbar_OnMenuItemClickListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
			{
				JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
				this.sender = sender;
			}

			// Token: 0x06000659 RID: 1625 RVA: 0x00010CD0 File Offset: 0x0000EED0
			public bool OnMenuItemClick(IMenuItem item)
			{
				EventHandler<Toolbar.MenuItemClickEventArgs> handler = this.Handler;
				if (handler == null)
				{
					return false;
				}
				Toolbar.MenuItemClickEventArgs menuItemClickEventArgs = new Toolbar.MenuItemClickEventArgs(true, item);
				handler(this.sender, menuItemClickEventArgs);
				return menuItemClickEventArgs.Handled;
			}

			// Token: 0x0600065A RID: 1626 RVA: 0x00010D04 File Offset: 0x0000EF04
			internal static bool __IsEmpty(Toolbar.IOnMenuItemClickListenerImplementor value)
			{
				return value.Handler == null;
			}

			// Token: 0x04000196 RID: 406
			private object sender;

			// Token: 0x04000197 RID: 407
			public EventHandler<Toolbar.MenuItemClickEventArgs> Handler;
		}

		// Token: 0x02000062 RID: 98
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04000198 RID: 408
			public static Func<Toolbar.IOnMenuItemClickListenerImplementor, bool> <0>____IsEmpty;
		}
	}
}
