using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Database;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.Interop;
using Java.Lang;

namespace AndroidX.AppCompat.App
{
	// Token: 0x0200003A RID: 58
	[Register("androidx/appcompat/app/AlertDialog", DoNotGenerateAcw = true)]
	public class AlertDialog : AppCompatDialog, IDialogInterface, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000121 RID: 289 RVA: 0x00002B06 File Offset: 0x00000D06
		protected AlertDialog(Context context, bool cancelable, EventHandler cancelHandler) : this(context, cancelable, new AlertDialog.IDialogInterfaceOnCancelListenerImplementor
		{
			Handler = cancelHandler
		})
		{
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00002B1C File Offset: 0x00000D1C
		public void SetButton(int whichButton, ICharSequence text, EventHandler<DialogClickEventArgs> handler)
		{
			this.SetButton(whichButton, text, new AlertDialog.IDialogInterfaceOnClickListenerImplementor
			{
				Handler = handler
			});
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00002B32 File Offset: 0x00000D32
		public void SetButton(int whichButton, string text, EventHandler<DialogClickEventArgs> handler)
		{
			this.SetButton(whichButton, text, new AlertDialog.IDialogInterfaceOnClickListenerImplementor
			{
				Handler = handler
			});
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000124 RID: 292 RVA: 0x00002B48 File Offset: 0x00000D48
		internal new static IntPtr class_ref
		{
			get
			{
				return AlertDialog._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000125 RID: 293 RVA: 0x00002B6C File Offset: 0x00000D6C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AlertDialog._members;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000126 RID: 294 RVA: 0x00002B74 File Offset: 0x00000D74
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AlertDialog._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000127 RID: 295 RVA: 0x00002B98 File Offset: 0x00000D98
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AlertDialog._members.ManagedPeerType;
			}
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00002BA4 File Offset: 0x00000DA4
		protected AlertDialog(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00002BB0 File Offset: 0x00000DB0
		[Register(".ctor", "(Landroid/content/Context;)V", "")]
		protected unsafe AlertDialog(Context context) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				base.SetHandle(AlertDialog._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				AlertDialog._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00002C60 File Offset: 0x00000E60
		[Register(".ctor", "(Landroid/content/Context;ZLandroid/content/DialogInterface$OnCancelListener;)V", "")]
		protected unsafe AlertDialog(Context context, bool cancelable, IDialogInterfaceOnCancelListener cancelListener) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue(cancelable);
				ptr[2] = new JniArgumentValue((cancelListener == null) ? IntPtr.Zero : ((Java.Lang.Object)cancelListener).Handle);
				base.SetHandle(AlertDialog._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;ZLandroid/content/DialogInterface$OnCancelListener;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				AlertDialog._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;ZLandroid/content/DialogInterface$OnCancelListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(cancelListener);
			}
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00002D50 File Offset: 0x00000F50
		[Register(".ctor", "(Landroid/content/Context;I)V", "")]
		protected unsafe AlertDialog(Context context, int themeResId) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue(themeResId);
				base.SetHandle(AlertDialog._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				AlertDialog._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00002E10 File Offset: 0x00001010
		private static Delegate GetGetListViewHandler()
		{
			if (AlertDialog.cb_getListView == null)
			{
				AlertDialog.cb_getListView = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AlertDialog.n_GetListView));
			}
			return AlertDialog.cb_getListView;
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00002E34 File Offset: 0x00001034
		private static IntPtr n_GetListView(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AlertDialog>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ListView);
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600012E RID: 302 RVA: 0x00002E48 File Offset: 0x00001048
		public virtual ListView ListView
		{
			[Register("getListView", "()Landroid/widget/ListView;", "GetGetListViewHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ListView>(AlertDialog._members.InstanceMethods.InvokeVirtualObjectMethod("getListView.()Landroid/widget/ListView;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00002E7A File Offset: 0x0000107A
		private static Delegate GetGetButton_IHandler()
		{
			if (AlertDialog.cb_getButton_I == null)
			{
				AlertDialog.cb_getButton_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(AlertDialog.n_GetButton_I));
			}
			return AlertDialog.cb_getButton_I;
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00002E9E File Offset: 0x0000109E
		private static IntPtr n_GetButton_I(IntPtr jnienv, IntPtr native__this, int whichButton)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AlertDialog>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetButton(whichButton));
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00002EB4 File Offset: 0x000010B4
		[Register("getButton", "(I)Landroid/widget/Button;", "GetGetButton_IHandler")]
		public unsafe virtual Button GetButton(int whichButton)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(whichButton);
			return Java.Lang.Object.GetObject<Button>(AlertDialog._members.InstanceMethods.InvokeVirtualObjectMethod("getButton.(I)Landroid/widget/Button;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00002EFD File Offset: 0x000010FD
		private static Delegate GetSetButton_ILjava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_Handler()
		{
			if (AlertDialog.cb_setButton_ILjava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_ == null)
			{
				AlertDialog.cb_setButton_ILjava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPILL_V(AlertDialog.n_SetButton_ILjava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_));
			}
			return AlertDialog.cb_setButton_ILjava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_;
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00002F24 File Offset: 0x00001124
		private static void n_SetButton_ILjava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_(IntPtr jnienv, IntPtr native__this, int whichButton, IntPtr native_text, IntPtr native_listener)
		{
			AlertDialog @object = Java.Lang.Object.GetObject<AlertDialog>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_text, JniHandleOwnership.DoNotTransfer);
			IDialogInterfaceOnClickListener object3 = Java.Lang.Object.GetObject<IDialogInterfaceOnClickListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.SetButton(whichButton, object2, object3);
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00002F54 File Offset: 0x00001154
		[Register("setButton", "(ILjava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)V", "GetSetButton_ILjava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_Handler")]
		public unsafe virtual void SetButton(int whichButton, ICharSequence text, IDialogInterfaceOnClickListener listener)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(text);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(whichButton);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				AlertDialog._members.InstanceMethods.InvokeVirtualVoidMethod("setButton.(ILjava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(text);
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00002FF8 File Offset: 0x000011F8
		public void SetButton(int whichButton, string text, IDialogInterfaceOnClickListener listener)
		{
			Java.Lang.String @string = (text == null) ? null : new Java.Lang.String(text);
			this.SetButton(whichButton, @string, listener);
			if (@string != null)
			{
				@string.Dispose();
			}
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00003024 File Offset: 0x00001224
		private static Delegate GetSetButton_ILjava_lang_CharSequence_Landroid_graphics_drawable_Drawable_Landroid_content_DialogInterface_OnClickListener_Handler()
		{
			if (AlertDialog.cb_setButton_ILjava_lang_CharSequence_Landroid_graphics_drawable_Drawable_Landroid_content_DialogInterface_OnClickListener_ == null)
			{
				AlertDialog.cb_setButton_ILjava_lang_CharSequence_Landroid_graphics_drawable_Drawable_Landroid_content_DialogInterface_OnClickListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPILLL_V(AlertDialog.n_SetButton_ILjava_lang_CharSequence_Landroid_graphics_drawable_Drawable_Landroid_content_DialogInterface_OnClickListener_));
			}
			return AlertDialog.cb_setButton_ILjava_lang_CharSequence_Landroid_graphics_drawable_Drawable_Landroid_content_DialogInterface_OnClickListener_;
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00003048 File Offset: 0x00001248
		private static void n_SetButton_ILjava_lang_CharSequence_Landroid_graphics_drawable_Drawable_Landroid_content_DialogInterface_OnClickListener_(IntPtr jnienv, IntPtr native__this, int whichButton, IntPtr native_text, IntPtr native_icon, IntPtr native_listener)
		{
			AlertDialog @object = Java.Lang.Object.GetObject<AlertDialog>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_text, JniHandleOwnership.DoNotTransfer);
			Drawable object3 = Java.Lang.Object.GetObject<Drawable>(native_icon, JniHandleOwnership.DoNotTransfer);
			IDialogInterfaceOnClickListener object4 = Java.Lang.Object.GetObject<IDialogInterfaceOnClickListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.SetButton(whichButton, object2, object3, object4);
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00003080 File Offset: 0x00001280
		[Register("setButton", "(ILjava/lang/CharSequence;Landroid/graphics/drawable/Drawable;Landroid/content/DialogInterface$OnClickListener;)V", "GetSetButton_ILjava_lang_CharSequence_Landroid_graphics_drawable_Drawable_Landroid_content_DialogInterface_OnClickListener_Handler")]
		public unsafe virtual void SetButton(int whichButton, ICharSequence text, Drawable icon, IDialogInterfaceOnClickListener listener)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(text);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(whichButton);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((icon == null) ? IntPtr.Zero : icon.Handle);
				ptr[3] = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				AlertDialog._members.InstanceMethods.InvokeVirtualVoidMethod("setButton.(ILjava/lang/CharSequence;Landroid/graphics/drawable/Drawable;Landroid/content/DialogInterface$OnClickListener;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(text);
				GC.KeepAlive(icon);
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00003154 File Offset: 0x00001354
		public void SetButton(int whichButton, string text, Drawable icon, IDialogInterfaceOnClickListener listener)
		{
			Java.Lang.String @string = (text == null) ? null : new Java.Lang.String(text);
			this.SetButton(whichButton, @string, icon, listener);
			if (@string != null)
			{
				@string.Dispose();
			}
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00003182 File Offset: 0x00001382
		private static Delegate GetSetButton_ILjava_lang_CharSequence_Landroid_os_Message_Handler()
		{
			if (AlertDialog.cb_setButton_ILjava_lang_CharSequence_Landroid_os_Message_ == null)
			{
				AlertDialog.cb_setButton_ILjava_lang_CharSequence_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPILL_V(AlertDialog.n_SetButton_ILjava_lang_CharSequence_Landroid_os_Message_));
			}
			return AlertDialog.cb_setButton_ILjava_lang_CharSequence_Landroid_os_Message_;
		}

		// Token: 0x0600013B RID: 315 RVA: 0x000031A8 File Offset: 0x000013A8
		private static void n_SetButton_ILjava_lang_CharSequence_Landroid_os_Message_(IntPtr jnienv, IntPtr native__this, int whichButton, IntPtr native_text, IntPtr native_msg)
		{
			AlertDialog @object = Java.Lang.Object.GetObject<AlertDialog>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_text, JniHandleOwnership.DoNotTransfer);
			Message object3 = Java.Lang.Object.GetObject<Message>(native_msg, JniHandleOwnership.DoNotTransfer);
			@object.SetButton(whichButton, object2, object3);
		}

		// Token: 0x0600013C RID: 316 RVA: 0x000031D8 File Offset: 0x000013D8
		[Register("setButton", "(ILjava/lang/CharSequence;Landroid/os/Message;)V", "GetSetButton_ILjava_lang_CharSequence_Landroid_os_Message_Handler")]
		public unsafe virtual void SetButton(int whichButton, ICharSequence text, Message msg)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(text);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(whichButton);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((msg == null) ? IntPtr.Zero : msg.Handle);
				AlertDialog._members.InstanceMethods.InvokeVirtualVoidMethod("setButton.(ILjava/lang/CharSequence;Landroid/os/Message;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(text);
				GC.KeepAlive(msg);
			}
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00003278 File Offset: 0x00001478
		public void SetButton(int whichButton, string text, Message msg)
		{
			Java.Lang.String @string = (text == null) ? null : new Java.Lang.String(text);
			this.SetButton(whichButton, @string, msg);
			if (@string != null)
			{
				@string.Dispose();
			}
		}

		// Token: 0x0600013E RID: 318 RVA: 0x000032A4 File Offset: 0x000014A4
		private static Delegate GetSetCustomTitle_Landroid_view_View_Handler()
		{
			if (AlertDialog.cb_setCustomTitle_Landroid_view_View_ == null)
			{
				AlertDialog.cb_setCustomTitle_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AlertDialog.n_SetCustomTitle_Landroid_view_View_));
			}
			return AlertDialog.cb_setCustomTitle_Landroid_view_View_;
		}

		// Token: 0x0600013F RID: 319 RVA: 0x000032C8 File Offset: 0x000014C8
		private static void n_SetCustomTitle_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_customTitleView)
		{
			AlertDialog @object = Java.Lang.Object.GetObject<AlertDialog>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_customTitleView, JniHandleOwnership.DoNotTransfer);
			@object.SetCustomTitle(object2);
		}

		// Token: 0x06000140 RID: 320 RVA: 0x000032EC File Offset: 0x000014EC
		[Register("setCustomTitle", "(Landroid/view/View;)V", "GetSetCustomTitle_Landroid_view_View_Handler")]
		public unsafe virtual void SetCustomTitle(View customTitleView)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((customTitleView == null) ? IntPtr.Zero : customTitleView.Handle);
				AlertDialog._members.InstanceMethods.InvokeVirtualVoidMethod("setCustomTitle.(Landroid/view/View;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(customTitleView);
			}
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00003350 File Offset: 0x00001550
		private static Delegate GetSetIcon_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (AlertDialog.cb_setIcon_Landroid_graphics_drawable_Drawable_ == null)
			{
				AlertDialog.cb_setIcon_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AlertDialog.n_SetIcon_Landroid_graphics_drawable_Drawable_));
			}
			return AlertDialog.cb_setIcon_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00003374 File Offset: 0x00001574
		private static void n_SetIcon_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_icon)
		{
			AlertDialog @object = Java.Lang.Object.GetObject<AlertDialog>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_icon, JniHandleOwnership.DoNotTransfer);
			@object.SetIcon(object2);
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00003398 File Offset: 0x00001598
		[Register("setIcon", "(Landroid/graphics/drawable/Drawable;)V", "GetSetIcon_Landroid_graphics_drawable_Drawable_Handler")]
		public unsafe virtual void SetIcon(Drawable icon)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((icon == null) ? IntPtr.Zero : icon.Handle);
				AlertDialog._members.InstanceMethods.InvokeVirtualVoidMethod("setIcon.(Landroid/graphics/drawable/Drawable;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(icon);
			}
		}

		// Token: 0x06000144 RID: 324 RVA: 0x000033FC File Offset: 0x000015FC
		private static Delegate GetSetIcon_IHandler()
		{
			if (AlertDialog.cb_setIcon_I == null)
			{
				AlertDialog.cb_setIcon_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(AlertDialog.n_SetIcon_I));
			}
			return AlertDialog.cb_setIcon_I;
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00003420 File Offset: 0x00001620
		private static void n_SetIcon_I(IntPtr jnienv, IntPtr native__this, int resId)
		{
			Java.Lang.Object.GetObject<AlertDialog>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetIcon(resId);
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00003430 File Offset: 0x00001630
		[Register("setIcon", "(I)V", "GetSetIcon_IHandler")]
		public unsafe virtual void SetIcon(int resId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(resId);
			AlertDialog._members.InstanceMethods.InvokeVirtualVoidMethod("setIcon.(I)V", this, ptr);
		}

		// Token: 0x06000147 RID: 327 RVA: 0x0000346B File Offset: 0x0000166B
		private static Delegate GetSetIconAttribute_IHandler()
		{
			if (AlertDialog.cb_setIconAttribute_I == null)
			{
				AlertDialog.cb_setIconAttribute_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(AlertDialog.n_SetIconAttribute_I));
			}
			return AlertDialog.cb_setIconAttribute_I;
		}

		// Token: 0x06000148 RID: 328 RVA: 0x0000348F File Offset: 0x0000168F
		private static void n_SetIconAttribute_I(IntPtr jnienv, IntPtr native__this, int attrId)
		{
			Java.Lang.Object.GetObject<AlertDialog>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetIconAttribute(attrId);
		}

		// Token: 0x06000149 RID: 329 RVA: 0x000034A0 File Offset: 0x000016A0
		[Register("setIconAttribute", "(I)V", "GetSetIconAttribute_IHandler")]
		public unsafe virtual void SetIconAttribute(int attrId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(attrId);
			AlertDialog._members.InstanceMethods.InvokeVirtualVoidMethod("setIconAttribute.(I)V", this, ptr);
		}

		// Token: 0x0600014A RID: 330 RVA: 0x000034DB File Offset: 0x000016DB
		private static Delegate GetSetMessage_Ljava_lang_CharSequence_Handler()
		{
			if (AlertDialog.cb_setMessage_Ljava_lang_CharSequence_ == null)
			{
				AlertDialog.cb_setMessage_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AlertDialog.n_SetMessage_Ljava_lang_CharSequence_));
			}
			return AlertDialog.cb_setMessage_Ljava_lang_CharSequence_;
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00003500 File Offset: 0x00001700
		private static void n_SetMessage_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_message)
		{
			AlertDialog @object = Java.Lang.Object.GetObject<AlertDialog>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_message, JniHandleOwnership.DoNotTransfer);
			@object.SetMessage(object2);
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00003524 File Offset: 0x00001724
		[Register("setMessage", "(Ljava/lang/CharSequence;)V", "GetSetMessage_Ljava_lang_CharSequence_Handler")]
		public unsafe virtual void SetMessage(ICharSequence message)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(message);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				AlertDialog._members.InstanceMethods.InvokeVirtualVoidMethod("setMessage.(Ljava/lang/CharSequence;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(message);
			}
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00003588 File Offset: 0x00001788
		public void SetMessage(string message)
		{
			Java.Lang.String @string = (message == null) ? null : new Java.Lang.String(message);
			this.SetMessage(@string);
			if (@string != null)
			{
				@string.Dispose();
			}
		}

		// Token: 0x0600014E RID: 334 RVA: 0x000035B2 File Offset: 0x000017B2
		private static Delegate GetSetView_Landroid_view_View_Handler()
		{
			if (AlertDialog.cb_setView_Landroid_view_View_ == null)
			{
				AlertDialog.cb_setView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AlertDialog.n_SetView_Landroid_view_View_));
			}
			return AlertDialog.cb_setView_Landroid_view_View_;
		}

		// Token: 0x0600014F RID: 335 RVA: 0x000035D8 File Offset: 0x000017D8
		private static void n_SetView_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_view)
		{
			AlertDialog @object = Java.Lang.Object.GetObject<AlertDialog>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_view, JniHandleOwnership.DoNotTransfer);
			@object.SetView(object2);
		}

		// Token: 0x06000150 RID: 336 RVA: 0x000035FC File Offset: 0x000017FC
		[Register("setView", "(Landroid/view/View;)V", "GetSetView_Landroid_view_View_Handler")]
		public unsafe virtual void SetView(View view)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
				AlertDialog._members.InstanceMethods.InvokeVirtualVoidMethod("setView.(Landroid/view/View;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(view);
			}
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00003660 File Offset: 0x00001860
		private static Delegate GetSetView_Landroid_view_View_IIIIHandler()
		{
			if (AlertDialog.cb_setView_Landroid_view_View_IIII == null)
			{
				AlertDialog.cb_setView_Landroid_view_View_IIII = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIIII_V(AlertDialog.n_SetView_Landroid_view_View_IIII));
			}
			return AlertDialog.cb_setView_Landroid_view_View_IIII;
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00003684 File Offset: 0x00001884
		private static void n_SetView_Landroid_view_View_IIII(IntPtr jnienv, IntPtr native__this, IntPtr native_view, int viewSpacingLeft, int viewSpacingTop, int viewSpacingRight, int viewSpacingBottom)
		{
			AlertDialog @object = Java.Lang.Object.GetObject<AlertDialog>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_view, JniHandleOwnership.DoNotTransfer);
			@object.SetView(object2, viewSpacingLeft, viewSpacingTop, viewSpacingRight, viewSpacingBottom);
		}

		// Token: 0x06000153 RID: 339 RVA: 0x000036B0 File Offset: 0x000018B0
		[Register("setView", "(Landroid/view/View;IIII)V", "GetSetView_Landroid_view_View_IIIIHandler")]
		public unsafe virtual void SetView(View view, int viewSpacingLeft, int viewSpacingTop, int viewSpacingRight, int viewSpacingBottom)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
				ptr[1] = new JniArgumentValue(viewSpacingLeft);
				ptr[2] = new JniArgumentValue(viewSpacingTop);
				ptr[3] = new JniArgumentValue(viewSpacingRight);
				ptr[4] = new JniArgumentValue(viewSpacingBottom);
				AlertDialog._members.InstanceMethods.InvokeVirtualVoidMethod("setView.(Landroid/view/View;IIII)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(view);
			}
		}

		// Token: 0x0400001B RID: 27
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/appcompat/app/AlertDialog", typeof(AlertDialog));

		// Token: 0x0400001C RID: 28
		private static Delegate cb_getListView;

		// Token: 0x0400001D RID: 29
		private static Delegate cb_getButton_I;

		// Token: 0x0400001E RID: 30
		private static Delegate cb_setButton_ILjava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_;

		// Token: 0x0400001F RID: 31
		private static Delegate cb_setButton_ILjava_lang_CharSequence_Landroid_graphics_drawable_Drawable_Landroid_content_DialogInterface_OnClickListener_;

		// Token: 0x04000020 RID: 32
		private static Delegate cb_setButton_ILjava_lang_CharSequence_Landroid_os_Message_;

		// Token: 0x04000021 RID: 33
		private static Delegate cb_setCustomTitle_Landroid_view_View_;

		// Token: 0x04000022 RID: 34
		private static Delegate cb_setIcon_Landroid_graphics_drawable_Drawable_;

		// Token: 0x04000023 RID: 35
		private static Delegate cb_setIcon_I;

		// Token: 0x04000024 RID: 36
		private static Delegate cb_setIconAttribute_I;

		// Token: 0x04000025 RID: 37
		private static Delegate cb_setMessage_Ljava_lang_CharSequence_;

		// Token: 0x04000026 RID: 38
		private static Delegate cb_setView_Landroid_view_View_;

		// Token: 0x04000027 RID: 39
		private static Delegate cb_setView_Landroid_view_View_IIII;

		// Token: 0x0200003B RID: 59
		[Register("androidx/appcompat/app/AlertDialog$Builder", DoNotGenerateAcw = true)]
		public class Builder : Java.Lang.Object
		{
			// Token: 0x06000155 RID: 341 RVA: 0x00003787 File Offset: 0x00001987
			public AlertDialog.Builder SetAdapter(IListAdapter adapter, EventHandler<DialogClickEventArgs> handler)
			{
				return this.SetAdapter(adapter, new AlertDialog.IDialogInterfaceOnClickListenerImplementor
				{
					Handler = handler
				});
			}

			// Token: 0x06000156 RID: 342 RVA: 0x0000379C File Offset: 0x0000199C
			public AlertDialog.Builder SetCursor(ICursor cursor, EventHandler<DialogClickEventArgs> handler, string labelColumn)
			{
				return this.SetCursor(cursor, new AlertDialog.IDialogInterfaceOnClickListenerImplementor
				{
					Handler = handler
				}, labelColumn);
			}

			// Token: 0x06000157 RID: 343 RVA: 0x000037B2 File Offset: 0x000019B2
			public AlertDialog.Builder SetItems(int itemsId, EventHandler<DialogClickEventArgs> handler)
			{
				return this.SetItems(itemsId, new AlertDialog.IDialogInterfaceOnClickListenerImplementor
				{
					Handler = handler
				});
			}

			// Token: 0x06000158 RID: 344 RVA: 0x000037C7 File Offset: 0x000019C7
			public AlertDialog.Builder SetItems(ICharSequence[] items, EventHandler<DialogClickEventArgs> handler)
			{
				return this.SetItems(items, new AlertDialog.IDialogInterfaceOnClickListenerImplementor
				{
					Handler = handler
				});
			}

			// Token: 0x06000159 RID: 345 RVA: 0x000037DC File Offset: 0x000019DC
			public AlertDialog.Builder SetItems(string[] items, EventHandler<DialogClickEventArgs> handler)
			{
				return this.SetItems(items, new AlertDialog.IDialogInterfaceOnClickListenerImplementor
				{
					Handler = handler
				});
			}

			// Token: 0x0600015A RID: 346 RVA: 0x000037F1 File Offset: 0x000019F1
			public AlertDialog.Builder SetMultiChoiceItems(int itemsId, bool[] checkedItems, EventHandler<DialogMultiChoiceClickEventArgs> handler)
			{
				return this.SetMultiChoiceItems(itemsId, checkedItems, new AlertDialog.IDialogInterfaceOnMultiChoiceClickListenerImplementor
				{
					Handler = handler
				});
			}

			// Token: 0x0600015B RID: 347 RVA: 0x00003807 File Offset: 0x00001A07
			public AlertDialog.Builder SetMultiChoiceItems(ICharSequence[] items, bool[] checkedItems, EventHandler<DialogMultiChoiceClickEventArgs> handler)
			{
				return this.SetMultiChoiceItems(items, checkedItems, new AlertDialog.IDialogInterfaceOnMultiChoiceClickListenerImplementor
				{
					Handler = handler
				});
			}

			// Token: 0x0600015C RID: 348 RVA: 0x0000381D File Offset: 0x00001A1D
			public AlertDialog.Builder SetMultiChoiceItems(string[] items, bool[] checkedItems, EventHandler<DialogMultiChoiceClickEventArgs> handler)
			{
				return this.SetMultiChoiceItems(items, checkedItems, new AlertDialog.IDialogInterfaceOnMultiChoiceClickListenerImplementor
				{
					Handler = handler
				});
			}

			// Token: 0x0600015D RID: 349 RVA: 0x00003833 File Offset: 0x00001A33
			public AlertDialog.Builder SetMultiChoiceItems(ICursor cursor, string isCheckedColumn, string labelColumn, EventHandler<DialogMultiChoiceClickEventArgs> handler)
			{
				return this.SetMultiChoiceItems(cursor, isCheckedColumn, labelColumn, new AlertDialog.IDialogInterfaceOnMultiChoiceClickListenerImplementor
				{
					Handler = handler
				});
			}

			// Token: 0x0600015E RID: 350 RVA: 0x0000384B File Offset: 0x00001A4B
			public AlertDialog.Builder SetNegativeButton(int textId, EventHandler<DialogClickEventArgs> handler)
			{
				return this.SetNegativeButton(textId, new AlertDialog.IDialogInterfaceOnClickListenerImplementor
				{
					Handler = handler
				});
			}

			// Token: 0x0600015F RID: 351 RVA: 0x00003860 File Offset: 0x00001A60
			public AlertDialog.Builder SetNegativeButton(ICharSequence text, EventHandler<DialogClickEventArgs> handler)
			{
				return this.SetNegativeButton(text, new AlertDialog.IDialogInterfaceOnClickListenerImplementor
				{
					Handler = handler
				});
			}

			// Token: 0x06000160 RID: 352 RVA: 0x00003875 File Offset: 0x00001A75
			public AlertDialog.Builder SetNegativeButton(string text, EventHandler<DialogClickEventArgs> handler)
			{
				return this.SetNegativeButton(text, new AlertDialog.IDialogInterfaceOnClickListenerImplementor
				{
					Handler = handler
				});
			}

			// Token: 0x06000161 RID: 353 RVA: 0x0000388A File Offset: 0x00001A8A
			public AlertDialog.Builder SetNeutralButton(int textId, EventHandler<DialogClickEventArgs> handler)
			{
				return this.SetNeutralButton(textId, new AlertDialog.IDialogInterfaceOnClickListenerImplementor
				{
					Handler = handler
				});
			}

			// Token: 0x06000162 RID: 354 RVA: 0x0000389F File Offset: 0x00001A9F
			public AlertDialog.Builder SetNeutralButton(ICharSequence text, EventHandler<DialogClickEventArgs> handler)
			{
				return this.SetNeutralButton(text, new AlertDialog.IDialogInterfaceOnClickListenerImplementor
				{
					Handler = handler
				});
			}

			// Token: 0x06000163 RID: 355 RVA: 0x000038B4 File Offset: 0x00001AB4
			public AlertDialog.Builder SetNeutralButton(string text, EventHandler<DialogClickEventArgs> handler)
			{
				return this.SetNeutralButton(text, new AlertDialog.IDialogInterfaceOnClickListenerImplementor
				{
					Handler = handler
				});
			}

			// Token: 0x06000164 RID: 356 RVA: 0x000038C9 File Offset: 0x00001AC9
			public AlertDialog.Builder SetPositiveButton(int textId, EventHandler<DialogClickEventArgs> handler)
			{
				return this.SetPositiveButton(textId, new AlertDialog.IDialogInterfaceOnClickListenerImplementor
				{
					Handler = handler
				});
			}

			// Token: 0x06000165 RID: 357 RVA: 0x000038DE File Offset: 0x00001ADE
			public AlertDialog.Builder SetPositiveButton(ICharSequence text, EventHandler<DialogClickEventArgs> handler)
			{
				return this.SetPositiveButton(text, new AlertDialog.IDialogInterfaceOnClickListenerImplementor
				{
					Handler = handler
				});
			}

			// Token: 0x06000166 RID: 358 RVA: 0x000038F3 File Offset: 0x00001AF3
			public AlertDialog.Builder SetPositiveButton(string text, EventHandler<DialogClickEventArgs> handler)
			{
				return this.SetPositiveButton(text, new AlertDialog.IDialogInterfaceOnClickListenerImplementor
				{
					Handler = handler
				});
			}

			// Token: 0x06000167 RID: 359 RVA: 0x00003908 File Offset: 0x00001B08
			public AlertDialog.Builder SetSingleChoiceItems(int itemsId, int checkedItem, EventHandler<DialogClickEventArgs> handler)
			{
				return this.SetSingleChoiceItems(itemsId, checkedItem, new AlertDialog.IDialogInterfaceOnClickListenerImplementor
				{
					Handler = handler
				});
			}

			// Token: 0x06000168 RID: 360 RVA: 0x0000391E File Offset: 0x00001B1E
			public AlertDialog.Builder SetSingleChoiceItems(ICursor cursor, int checkedItem, string labelColumn, EventHandler<DialogClickEventArgs> handler)
			{
				return this.SetSingleChoiceItems(cursor, checkedItem, labelColumn, new AlertDialog.IDialogInterfaceOnClickListenerImplementor
				{
					Handler = handler
				});
			}

			// Token: 0x06000169 RID: 361 RVA: 0x00003936 File Offset: 0x00001B36
			public AlertDialog.Builder SetSingleChoiceItems(ICharSequence[] items, int checkedItem, EventHandler<DialogClickEventArgs> handler)
			{
				return this.SetSingleChoiceItems(items, checkedItem, new AlertDialog.IDialogInterfaceOnClickListenerImplementor
				{
					Handler = handler
				});
			}

			// Token: 0x0600016A RID: 362 RVA: 0x0000394C File Offset: 0x00001B4C
			public AlertDialog.Builder SetSingleChoiceItems(string[] items, int checkedItem, EventHandler<DialogClickEventArgs> handler)
			{
				return this.SetSingleChoiceItems(items, checkedItem, new AlertDialog.IDialogInterfaceOnClickListenerImplementor
				{
					Handler = handler
				});
			}

			// Token: 0x0600016B RID: 363 RVA: 0x00003962 File Offset: 0x00001B62
			public AlertDialog.Builder SetSingleChoiceItems(IListAdapter adapter, int checkedItem, EventHandler<DialogClickEventArgs> handler)
			{
				return this.SetSingleChoiceItems(adapter, checkedItem, new AlertDialog.IDialogInterfaceOnClickListenerImplementor
				{
					Handler = handler
				});
			}

			// Token: 0x17000015 RID: 21
			// (get) Token: 0x0600016C RID: 364 RVA: 0x00003978 File Offset: 0x00001B78
			internal static IntPtr class_ref
			{
				get
				{
					return AlertDialog.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000016 RID: 22
			// (get) Token: 0x0600016D RID: 365 RVA: 0x0000399C File Offset: 0x00001B9C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return AlertDialog.Builder._members;
				}
			}

			// Token: 0x17000017 RID: 23
			// (get) Token: 0x0600016E RID: 366 RVA: 0x000039A4 File Offset: 0x00001BA4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return AlertDialog.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000018 RID: 24
			// (get) Token: 0x0600016F RID: 367 RVA: 0x000039C8 File Offset: 0x00001BC8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return AlertDialog.Builder._members.ManagedPeerType;
				}
			}

			// Token: 0x06000170 RID: 368 RVA: 0x000039D4 File Offset: 0x00001BD4
			protected Builder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06000171 RID: 369 RVA: 0x000039E0 File Offset: 0x00001BE0
			[Register(".ctor", "(Landroid/content/Context;)V", "")]
			public unsafe Builder(Context context) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
					base.SetHandle(AlertDialog.Builder._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					AlertDialog.Builder._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(context);
				}
			}

			// Token: 0x06000172 RID: 370 RVA: 0x00003A90 File Offset: 0x00001C90
			[Register(".ctor", "(Landroid/content/Context;I)V", "")]
			public unsafe Builder(Context context, int themeResId) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
					ptr[1] = new JniArgumentValue(themeResId);
					base.SetHandle(AlertDialog.Builder._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					AlertDialog.Builder._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;I)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(context);
				}
			}

			// Token: 0x06000173 RID: 371 RVA: 0x00003B50 File Offset: 0x00001D50
			private static Delegate GetGetContextHandler()
			{
				if (AlertDialog.Builder.cb_getContext == null)
				{
					AlertDialog.Builder.cb_getContext = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AlertDialog.Builder.n_GetContext));
				}
				return AlertDialog.Builder.cb_getContext;
			}

			// Token: 0x06000174 RID: 372 RVA: 0x00003B74 File Offset: 0x00001D74
			private static IntPtr n_GetContext(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AlertDialog.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Context);
			}

			// Token: 0x17000019 RID: 25
			// (get) Token: 0x06000175 RID: 373 RVA: 0x00003B88 File Offset: 0x00001D88
			public virtual Context Context
			{
				[Register("getContext", "()Landroid/content/Context;", "GetGetContextHandler")]
				get
				{
					return Java.Lang.Object.GetObject<Context>(AlertDialog.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("getContext.()Landroid/content/Context;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x06000176 RID: 374 RVA: 0x00003BBA File Offset: 0x00001DBA
			private static Delegate GetCreateHandler()
			{
				if (AlertDialog.Builder.cb_create == null)
				{
					AlertDialog.Builder.cb_create = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AlertDialog.Builder.n_Create));
				}
				return AlertDialog.Builder.cb_create;
			}

			// Token: 0x06000177 RID: 375 RVA: 0x00003BDE File Offset: 0x00001DDE
			private static IntPtr n_Create(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AlertDialog.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Create());
			}

			// Token: 0x06000178 RID: 376 RVA: 0x00003BF4 File Offset: 0x00001DF4
			[Register("create", "()Landroidx/appcompat/app/AlertDialog;", "GetCreateHandler")]
			public virtual AlertDialog Create()
			{
				return Java.Lang.Object.GetObject<AlertDialog>(AlertDialog.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("create.()Landroidx/appcompat/app/AlertDialog;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000179 RID: 377 RVA: 0x00003C26 File Offset: 0x00001E26
			private static Delegate GetSetAdapter_Landroid_widget_ListAdapter_Landroid_content_DialogInterface_OnClickListener_Handler()
			{
				if (AlertDialog.Builder.cb_setAdapter_Landroid_widget_ListAdapter_Landroid_content_DialogInterface_OnClickListener_ == null)
				{
					AlertDialog.Builder.cb_setAdapter_Landroid_widget_ListAdapter_Landroid_content_DialogInterface_OnClickListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(AlertDialog.Builder.n_SetAdapter_Landroid_widget_ListAdapter_Landroid_content_DialogInterface_OnClickListener_));
				}
				return AlertDialog.Builder.cb_setAdapter_Landroid_widget_ListAdapter_Landroid_content_DialogInterface_OnClickListener_;
			}

			// Token: 0x0600017A RID: 378 RVA: 0x00003C4C File Offset: 0x00001E4C
			private static IntPtr n_SetAdapter_Landroid_widget_ListAdapter_Landroid_content_DialogInterface_OnClickListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_adapter, IntPtr native_listener)
			{
				AlertDialog.Builder @object = Java.Lang.Object.GetObject<AlertDialog.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				IListAdapter object2 = Java.Lang.Object.GetObject<IListAdapter>(native_adapter, JniHandleOwnership.DoNotTransfer);
				IDialogInterfaceOnClickListener object3 = Java.Lang.Object.GetObject<IDialogInterfaceOnClickListener>(native_listener, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetAdapter(object2, object3));
			}

			// Token: 0x0600017B RID: 379 RVA: 0x00003C80 File Offset: 0x00001E80
			[Register("setAdapter", "(Landroid/widget/ListAdapter;Landroid/content/DialogInterface$OnClickListener;)Landroidx/appcompat/app/AlertDialog$Builder;", "GetSetAdapter_Landroid_widget_ListAdapter_Landroid_content_DialogInterface_OnClickListener_Handler")]
			public unsafe virtual AlertDialog.Builder SetAdapter(IListAdapter adapter, IDialogInterfaceOnClickListener listener)
			{
				AlertDialog.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((adapter == null) ? IntPtr.Zero : ((Java.Lang.Object)adapter).Handle);
					ptr[1] = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
					@object = Java.Lang.Object.GetObject<AlertDialog.Builder>(AlertDialog.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setAdapter.(Landroid/widget/ListAdapter;Landroid/content/DialogInterface$OnClickListener;)Landroidx/appcompat/app/AlertDialog$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(adapter);
					GC.KeepAlive(listener);
				}
				return @object;
			}

			// Token: 0x0600017C RID: 380 RVA: 0x00003D28 File Offset: 0x00001F28
			private static Delegate GetSetCancelable_ZHandler()
			{
				if (AlertDialog.Builder.cb_setCancelable_Z == null)
				{
					AlertDialog.Builder.cb_setCancelable_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_L(AlertDialog.Builder.n_SetCancelable_Z));
				}
				return AlertDialog.Builder.cb_setCancelable_Z;
			}

			// Token: 0x0600017D RID: 381 RVA: 0x00003D4C File Offset: 0x00001F4C
			private static IntPtr n_SetCancelable_Z(IntPtr jnienv, IntPtr native__this, bool cancelable)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AlertDialog.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetCancelable(cancelable));
			}

			// Token: 0x0600017E RID: 382 RVA: 0x00003D64 File Offset: 0x00001F64
			[Register("setCancelable", "(Z)Landroidx/appcompat/app/AlertDialog$Builder;", "GetSetCancelable_ZHandler")]
			public unsafe virtual AlertDialog.Builder SetCancelable(bool cancelable)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(cancelable);
				return Java.Lang.Object.GetObject<AlertDialog.Builder>(AlertDialog.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setCancelable.(Z)Landroidx/appcompat/app/AlertDialog$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x0600017F RID: 383 RVA: 0x00003DAD File Offset: 0x00001FAD
			private static Delegate GetSetCursor_Landroid_database_Cursor_Landroid_content_DialogInterface_OnClickListener_Ljava_lang_String_Handler()
			{
				if (AlertDialog.Builder.cb_setCursor_Landroid_database_Cursor_Landroid_content_DialogInterface_OnClickListener_Ljava_lang_String_ == null)
				{
					AlertDialog.Builder.cb_setCursor_Landroid_database_Cursor_Landroid_content_DialogInterface_OnClickListener_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_L(AlertDialog.Builder.n_SetCursor_Landroid_database_Cursor_Landroid_content_DialogInterface_OnClickListener_Ljava_lang_String_));
				}
				return AlertDialog.Builder.cb_setCursor_Landroid_database_Cursor_Landroid_content_DialogInterface_OnClickListener_Ljava_lang_String_;
			}

			// Token: 0x06000180 RID: 384 RVA: 0x00003DD4 File Offset: 0x00001FD4
			private static IntPtr n_SetCursor_Landroid_database_Cursor_Landroid_content_DialogInterface_OnClickListener_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_cursor, IntPtr native_listener, IntPtr native_labelColumn)
			{
				AlertDialog.Builder @object = Java.Lang.Object.GetObject<AlertDialog.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				ICursor object2 = Java.Lang.Object.GetObject<ICursor>(native_cursor, JniHandleOwnership.DoNotTransfer);
				IDialogInterfaceOnClickListener object3 = Java.Lang.Object.GetObject<IDialogInterfaceOnClickListener>(native_listener, JniHandleOwnership.DoNotTransfer);
				string @string = JNIEnv.GetString(native_labelColumn, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetCursor(object2, object3, @string));
			}

			// Token: 0x06000181 RID: 385 RVA: 0x00003E10 File Offset: 0x00002010
			[Register("setCursor", "(Landroid/database/Cursor;Landroid/content/DialogInterface$OnClickListener;Ljava/lang/String;)Landroidx/appcompat/app/AlertDialog$Builder;", "GetSetCursor_Landroid_database_Cursor_Landroid_content_DialogInterface_OnClickListener_Ljava_lang_String_Handler")]
			public unsafe virtual AlertDialog.Builder SetCursor(ICursor cursor, IDialogInterfaceOnClickListener listener, string labelColumn)
			{
				IntPtr intPtr = JNIEnv.NewString(labelColumn);
				AlertDialog.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((cursor == null) ? IntPtr.Zero : ((Java.Lang.Object)cursor).Handle);
					ptr[1] = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
					ptr[2] = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<AlertDialog.Builder>(AlertDialog.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setCursor.(Landroid/database/Cursor;Landroid/content/DialogInterface$OnClickListener;Ljava/lang/String;)Landroidx/appcompat/app/AlertDialog$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(cursor);
					GC.KeepAlive(listener);
				}
				return @object;
			}

			// Token: 0x06000182 RID: 386 RVA: 0x00003ED8 File Offset: 0x000020D8
			private static Delegate GetSetCustomTitle_Landroid_view_View_Handler()
			{
				if (AlertDialog.Builder.cb_setCustomTitle_Landroid_view_View_ == null)
				{
					AlertDialog.Builder.cb_setCustomTitle_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AlertDialog.Builder.n_SetCustomTitle_Landroid_view_View_));
				}
				return AlertDialog.Builder.cb_setCustomTitle_Landroid_view_View_;
			}

			// Token: 0x06000183 RID: 387 RVA: 0x00003EFC File Offset: 0x000020FC
			private static IntPtr n_SetCustomTitle_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_customTitleView)
			{
				AlertDialog.Builder @object = Java.Lang.Object.GetObject<AlertDialog.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				View object2 = Java.Lang.Object.GetObject<View>(native_customTitleView, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetCustomTitle(object2));
			}

			// Token: 0x06000184 RID: 388 RVA: 0x00003F24 File Offset: 0x00002124
			[Register("setCustomTitle", "(Landroid/view/View;)Landroidx/appcompat/app/AlertDialog$Builder;", "GetSetCustomTitle_Landroid_view_View_Handler")]
			public unsafe virtual AlertDialog.Builder SetCustomTitle(View customTitleView)
			{
				AlertDialog.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((customTitleView == null) ? IntPtr.Zero : customTitleView.Handle);
					@object = Java.Lang.Object.GetObject<AlertDialog.Builder>(AlertDialog.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setCustomTitle.(Landroid/view/View;)Landroidx/appcompat/app/AlertDialog$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(customTitleView);
				}
				return @object;
			}

			// Token: 0x06000185 RID: 389 RVA: 0x00003F98 File Offset: 0x00002198
			private static Delegate GetSetIcon_Landroid_graphics_drawable_Drawable_Handler()
			{
				if (AlertDialog.Builder.cb_setIcon_Landroid_graphics_drawable_Drawable_ == null)
				{
					AlertDialog.Builder.cb_setIcon_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AlertDialog.Builder.n_SetIcon_Landroid_graphics_drawable_Drawable_));
				}
				return AlertDialog.Builder.cb_setIcon_Landroid_graphics_drawable_Drawable_;
			}

			// Token: 0x06000186 RID: 390 RVA: 0x00003FBC File Offset: 0x000021BC
			private static IntPtr n_SetIcon_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_icon)
			{
				AlertDialog.Builder @object = Java.Lang.Object.GetObject<AlertDialog.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_icon, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetIcon(object2));
			}

			// Token: 0x06000187 RID: 391 RVA: 0x00003FE4 File Offset: 0x000021E4
			[Register("setIcon", "(Landroid/graphics/drawable/Drawable;)Landroidx/appcompat/app/AlertDialog$Builder;", "GetSetIcon_Landroid_graphics_drawable_Drawable_Handler")]
			public unsafe virtual AlertDialog.Builder SetIcon(Drawable icon)
			{
				AlertDialog.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((icon == null) ? IntPtr.Zero : icon.Handle);
					@object = Java.Lang.Object.GetObject<AlertDialog.Builder>(AlertDialog.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setIcon.(Landroid/graphics/drawable/Drawable;)Landroidx/appcompat/app/AlertDialog$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(icon);
				}
				return @object;
			}

			// Token: 0x06000188 RID: 392 RVA: 0x00004058 File Offset: 0x00002258
			private static Delegate GetSetIcon_IHandler()
			{
				if (AlertDialog.Builder.cb_setIcon_I == null)
				{
					AlertDialog.Builder.cb_setIcon_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(AlertDialog.Builder.n_SetIcon_I));
				}
				return AlertDialog.Builder.cb_setIcon_I;
			}

			// Token: 0x06000189 RID: 393 RVA: 0x0000407C File Offset: 0x0000227C
			private static IntPtr n_SetIcon_I(IntPtr jnienv, IntPtr native__this, int iconId)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AlertDialog.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetIcon(iconId));
			}

			// Token: 0x0600018A RID: 394 RVA: 0x00004094 File Offset: 0x00002294
			[Register("setIcon", "(I)Landroidx/appcompat/app/AlertDialog$Builder;", "GetSetIcon_IHandler")]
			public unsafe virtual AlertDialog.Builder SetIcon(int iconId)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(iconId);
				return Java.Lang.Object.GetObject<AlertDialog.Builder>(AlertDialog.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setIcon.(I)Landroidx/appcompat/app/AlertDialog$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x0600018B RID: 395 RVA: 0x000040DD File Offset: 0x000022DD
			private static Delegate GetSetIconAttribute_IHandler()
			{
				if (AlertDialog.Builder.cb_setIconAttribute_I == null)
				{
					AlertDialog.Builder.cb_setIconAttribute_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(AlertDialog.Builder.n_SetIconAttribute_I));
				}
				return AlertDialog.Builder.cb_setIconAttribute_I;
			}

			// Token: 0x0600018C RID: 396 RVA: 0x00004101 File Offset: 0x00002301
			private static IntPtr n_SetIconAttribute_I(IntPtr jnienv, IntPtr native__this, int attrId)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AlertDialog.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetIconAttribute(attrId));
			}

			// Token: 0x0600018D RID: 397 RVA: 0x00004118 File Offset: 0x00002318
			[Register("setIconAttribute", "(I)Landroidx/appcompat/app/AlertDialog$Builder;", "GetSetIconAttribute_IHandler")]
			public unsafe virtual AlertDialog.Builder SetIconAttribute(int attrId)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(attrId);
				return Java.Lang.Object.GetObject<AlertDialog.Builder>(AlertDialog.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setIconAttribute.(I)Landroidx/appcompat/app/AlertDialog$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x0600018E RID: 398 RVA: 0x00004161 File Offset: 0x00002361
			private static Delegate GetSetInverseBackgroundForced_ZHandler()
			{
				if (AlertDialog.Builder.cb_setInverseBackgroundForced_Z == null)
				{
					AlertDialog.Builder.cb_setInverseBackgroundForced_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_L(AlertDialog.Builder.n_SetInverseBackgroundForced_Z));
				}
				return AlertDialog.Builder.cb_setInverseBackgroundForced_Z;
			}

			// Token: 0x0600018F RID: 399 RVA: 0x00004185 File Offset: 0x00002385
			private static IntPtr n_SetInverseBackgroundForced_Z(IntPtr jnienv, IntPtr native__this, bool useInverseBackground)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AlertDialog.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetInverseBackgroundForced(useInverseBackground));
			}

			// Token: 0x06000190 RID: 400 RVA: 0x0000419C File Offset: 0x0000239C
			[Register("setInverseBackgroundForced", "(Z)Landroidx/appcompat/app/AlertDialog$Builder;", "GetSetInverseBackgroundForced_ZHandler")]
			public unsafe virtual AlertDialog.Builder SetInverseBackgroundForced(bool useInverseBackground)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(useInverseBackground);
				return Java.Lang.Object.GetObject<AlertDialog.Builder>(AlertDialog.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setInverseBackgroundForced.(Z)Landroidx/appcompat/app/AlertDialog$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000191 RID: 401 RVA: 0x000041E5 File Offset: 0x000023E5
			private static Delegate GetSetItems_ILandroid_content_DialogInterface_OnClickListener_Handler()
			{
				if (AlertDialog.Builder.cb_setItems_ILandroid_content_DialogInterface_OnClickListener_ == null)
				{
					AlertDialog.Builder.cb_setItems_ILandroid_content_DialogInterface_OnClickListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_L(AlertDialog.Builder.n_SetItems_ILandroid_content_DialogInterface_OnClickListener_));
				}
				return AlertDialog.Builder.cb_setItems_ILandroid_content_DialogInterface_OnClickListener_;
			}

			// Token: 0x06000192 RID: 402 RVA: 0x0000420C File Offset: 0x0000240C
			private static IntPtr n_SetItems_ILandroid_content_DialogInterface_OnClickListener_(IntPtr jnienv, IntPtr native__this, int itemsId, IntPtr native_listener)
			{
				AlertDialog.Builder @object = Java.Lang.Object.GetObject<AlertDialog.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				IDialogInterfaceOnClickListener object2 = Java.Lang.Object.GetObject<IDialogInterfaceOnClickListener>(native_listener, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetItems(itemsId, object2));
			}

			// Token: 0x06000193 RID: 403 RVA: 0x00004238 File Offset: 0x00002438
			[Register("setItems", "(ILandroid/content/DialogInterface$OnClickListener;)Landroidx/appcompat/app/AlertDialog$Builder;", "GetSetItems_ILandroid_content_DialogInterface_OnClickListener_Handler")]
			public unsafe virtual AlertDialog.Builder SetItems(int itemsId, IDialogInterfaceOnClickListener listener)
			{
				AlertDialog.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(itemsId);
					ptr[1] = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
					@object = Java.Lang.Object.GetObject<AlertDialog.Builder>(AlertDialog.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setItems.(ILandroid/content/DialogInterface$OnClickListener;)Landroidx/appcompat/app/AlertDialog$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(listener);
				}
				return @object;
			}

			// Token: 0x06000194 RID: 404 RVA: 0x000042C4 File Offset: 0x000024C4
			private static Delegate GetSetItems_arrayLjava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_Handler()
			{
				if (AlertDialog.Builder.cb_setItems_arrayLjava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_ == null)
				{
					AlertDialog.Builder.cb_setItems_arrayLjava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(AlertDialog.Builder.n_SetItems_arrayLjava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_));
				}
				return AlertDialog.Builder.cb_setItems_arrayLjava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_;
			}

			// Token: 0x06000195 RID: 405 RVA: 0x000042E8 File Offset: 0x000024E8
			private static IntPtr n_SetItems_arrayLjava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_items, IntPtr native_listener)
			{
				AlertDialog.Builder @object = Java.Lang.Object.GetObject<AlertDialog.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				ICharSequence[] array = (ICharSequence[])JNIEnv.GetArray(native_items, JniHandleOwnership.DoNotTransfer, typeof(ICharSequence));
				IDialogInterfaceOnClickListener object2 = Java.Lang.Object.GetObject<IDialogInterfaceOnClickListener>(native_listener, JniHandleOwnership.DoNotTransfer);
				IntPtr result = JNIEnv.ToLocalJniHandle(@object.SetItems(array, object2));
				if (array != null)
				{
					JNIEnv.CopyArray<ICharSequence>(array, native_items);
				}
				return result;
			}

			// Token: 0x06000196 RID: 406 RVA: 0x00004334 File Offset: 0x00002534
			[Register("setItems", "([Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)Landroidx/appcompat/app/AlertDialog$Builder;", "GetSetItems_arrayLjava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_Handler")]
			public unsafe virtual AlertDialog.Builder SetItems(ICharSequence[] items, IDialogInterfaceOnClickListener listener)
			{
				IntPtr intPtr = JNIEnv.NewArray<ICharSequence>(items);
				AlertDialog.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					ptr[1] = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
					@object = Java.Lang.Object.GetObject<AlertDialog.Builder>(AlertDialog.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setItems.([Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)Landroidx/appcompat/app/AlertDialog$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					if (items != null)
					{
						JNIEnv.CopyArray<ICharSequence>(intPtr, items);
						JNIEnv.DeleteLocalRef(intPtr);
					}
					GC.KeepAlive(items);
					GC.KeepAlive(listener);
				}
				return @object;
			}

			// Token: 0x06000197 RID: 407 RVA: 0x000043DC File Offset: 0x000025DC
			public AlertDialog.Builder SetItems(string[] items, IDialogInterfaceOnClickListener listener)
			{
				ICharSequence[] array = CharSequence.ArrayFromStringArray(items);
				AlertDialog.Builder result = this.SetItems(array, listener);
				if (array != null)
				{
					foreach (ICharSequence charSequence in array)
					{
						if (charSequence != null)
						{
							charSequence.Dispose();
						}
					}
				}
				return result;
			}

			// Token: 0x06000198 RID: 408 RVA: 0x0000441B File Offset: 0x0000261B
			private static Delegate GetSetMessage_IHandler()
			{
				if (AlertDialog.Builder.cb_setMessage_I == null)
				{
					AlertDialog.Builder.cb_setMessage_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(AlertDialog.Builder.n_SetMessage_I));
				}
				return AlertDialog.Builder.cb_setMessage_I;
			}

			// Token: 0x06000199 RID: 409 RVA: 0x0000443F File Offset: 0x0000263F
			private static IntPtr n_SetMessage_I(IntPtr jnienv, IntPtr native__this, int messageId)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AlertDialog.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetMessage(messageId));
			}

			// Token: 0x0600019A RID: 410 RVA: 0x00004454 File Offset: 0x00002654
			[Register("setMessage", "(I)Landroidx/appcompat/app/AlertDialog$Builder;", "GetSetMessage_IHandler")]
			public unsafe virtual AlertDialog.Builder SetMessage(int messageId)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(messageId);
				return Java.Lang.Object.GetObject<AlertDialog.Builder>(AlertDialog.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setMessage.(I)Landroidx/appcompat/app/AlertDialog$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x0600019B RID: 411 RVA: 0x0000449D File Offset: 0x0000269D
			private static Delegate GetSetMessage_Ljava_lang_CharSequence_Handler()
			{
				if (AlertDialog.Builder.cb_setMessage_Ljava_lang_CharSequence_ == null)
				{
					AlertDialog.Builder.cb_setMessage_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AlertDialog.Builder.n_SetMessage_Ljava_lang_CharSequence_));
				}
				return AlertDialog.Builder.cb_setMessage_Ljava_lang_CharSequence_;
			}

			// Token: 0x0600019C RID: 412 RVA: 0x000044C4 File Offset: 0x000026C4
			private static IntPtr n_SetMessage_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_message)
			{
				AlertDialog.Builder @object = Java.Lang.Object.GetObject<AlertDialog.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_message, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetMessage(object2));
			}

			// Token: 0x0600019D RID: 413 RVA: 0x000044EC File Offset: 0x000026EC
			[Register("setMessage", "(Ljava/lang/CharSequence;)Landroidx/appcompat/app/AlertDialog$Builder;", "GetSetMessage_Ljava_lang_CharSequence_Handler")]
			public unsafe virtual AlertDialog.Builder SetMessage(ICharSequence message)
			{
				IntPtr intPtr = CharSequence.ToLocalJniHandle(message);
				AlertDialog.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<AlertDialog.Builder>(AlertDialog.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setMessage.(Ljava/lang/CharSequence;)Landroidx/appcompat/app/AlertDialog$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(message);
				}
				return @object;
			}

			// Token: 0x0600019E RID: 414 RVA: 0x00004560 File Offset: 0x00002760
			public AlertDialog.Builder SetMessage(string message)
			{
				Java.Lang.String @string = (message == null) ? null : new Java.Lang.String(message);
				AlertDialog.Builder result = this.SetMessage(@string);
				if (@string != null)
				{
					@string.Dispose();
				}
				return result;
			}

			// Token: 0x0600019F RID: 415 RVA: 0x0000458A File Offset: 0x0000278A
			private static Delegate GetSetMultiChoiceItems_Landroid_database_Cursor_Ljava_lang_String_Ljava_lang_String_Landroid_content_DialogInterface_OnMultiChoiceClickListener_Handler()
			{
				if (AlertDialog.Builder.cb_setMultiChoiceItems_Landroid_database_Cursor_Ljava_lang_String_Ljava_lang_String_Landroid_content_DialogInterface_OnMultiChoiceClickListener_ == null)
				{
					AlertDialog.Builder.cb_setMultiChoiceItems_Landroid_database_Cursor_Ljava_lang_String_Ljava_lang_String_Landroid_content_DialogInterface_OnMultiChoiceClickListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLL_L(AlertDialog.Builder.n_SetMultiChoiceItems_Landroid_database_Cursor_Ljava_lang_String_Ljava_lang_String_Landroid_content_DialogInterface_OnMultiChoiceClickListener_));
				}
				return AlertDialog.Builder.cb_setMultiChoiceItems_Landroid_database_Cursor_Ljava_lang_String_Ljava_lang_String_Landroid_content_DialogInterface_OnMultiChoiceClickListener_;
			}

			// Token: 0x060001A0 RID: 416 RVA: 0x000045B0 File Offset: 0x000027B0
			private static IntPtr n_SetMultiChoiceItems_Landroid_database_Cursor_Ljava_lang_String_Ljava_lang_String_Landroid_content_DialogInterface_OnMultiChoiceClickListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_cursor, IntPtr native_isCheckedColumn, IntPtr native_labelColumn, IntPtr native_listener)
			{
				AlertDialog.Builder @object = Java.Lang.Object.GetObject<AlertDialog.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				ICursor object2 = Java.Lang.Object.GetObject<ICursor>(native_cursor, JniHandleOwnership.DoNotTransfer);
				string @string = JNIEnv.GetString(native_isCheckedColumn, JniHandleOwnership.DoNotTransfer);
				string string2 = JNIEnv.GetString(native_labelColumn, JniHandleOwnership.DoNotTransfer);
				IDialogInterfaceOnMultiChoiceClickListener object3 = Java.Lang.Object.GetObject<IDialogInterfaceOnMultiChoiceClickListener>(native_listener, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetMultiChoiceItems(object2, @string, string2, object3));
			}

			// Token: 0x060001A1 RID: 417 RVA: 0x000045F8 File Offset: 0x000027F8
			[Register("setMultiChoiceItems", "(Landroid/database/Cursor;Ljava/lang/String;Ljava/lang/String;Landroid/content/DialogInterface$OnMultiChoiceClickListener;)Landroidx/appcompat/app/AlertDialog$Builder;", "GetSetMultiChoiceItems_Landroid_database_Cursor_Ljava_lang_String_Ljava_lang_String_Landroid_content_DialogInterface_OnMultiChoiceClickListener_Handler")]
			public unsafe virtual AlertDialog.Builder SetMultiChoiceItems(ICursor cursor, string isCheckedColumn, string labelColumn, IDialogInterfaceOnMultiChoiceClickListener listener)
			{
				IntPtr intPtr = JNIEnv.NewString(isCheckedColumn);
				IntPtr intPtr2 = JNIEnv.NewString(labelColumn);
				AlertDialog.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((cursor == null) ? IntPtr.Zero : ((Java.Lang.Object)cursor).Handle);
					ptr[1] = new JniArgumentValue(intPtr);
					ptr[2] = new JniArgumentValue(intPtr2);
					ptr[3] = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
					@object = Java.Lang.Object.GetObject<AlertDialog.Builder>(AlertDialog.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setMultiChoiceItems.(Landroid/database/Cursor;Ljava/lang/String;Ljava/lang/String;Landroid/content/DialogInterface$OnMultiChoiceClickListener;)Landroidx/appcompat/app/AlertDialog$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					JNIEnv.DeleteLocalRef(intPtr2);
					GC.KeepAlive(cursor);
					GC.KeepAlive(listener);
				}
				return @object;
			}

			// Token: 0x060001A2 RID: 418 RVA: 0x000046E8 File Offset: 0x000028E8
			private static Delegate GetSetMultiChoiceItems_IarrayZLandroid_content_DialogInterface_OnMultiChoiceClickListener_Handler()
			{
				if (AlertDialog.Builder.cb_setMultiChoiceItems_IarrayZLandroid_content_DialogInterface_OnMultiChoiceClickListener_ == null)
				{
					AlertDialog.Builder.cb_setMultiChoiceItems_IarrayZLandroid_content_DialogInterface_OnMultiChoiceClickListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPILL_L(AlertDialog.Builder.n_SetMultiChoiceItems_IarrayZLandroid_content_DialogInterface_OnMultiChoiceClickListener_));
				}
				return AlertDialog.Builder.cb_setMultiChoiceItems_IarrayZLandroid_content_DialogInterface_OnMultiChoiceClickListener_;
			}

			// Token: 0x060001A3 RID: 419 RVA: 0x0000470C File Offset: 0x0000290C
			private static IntPtr n_SetMultiChoiceItems_IarrayZLandroid_content_DialogInterface_OnMultiChoiceClickListener_(IntPtr jnienv, IntPtr native__this, int itemsId, IntPtr native_checkedItems, IntPtr native_listener)
			{
				AlertDialog.Builder @object = Java.Lang.Object.GetObject<AlertDialog.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				bool[] array = (bool[])JNIEnv.GetArray(native_checkedItems, JniHandleOwnership.DoNotTransfer, typeof(bool));
				IDialogInterfaceOnMultiChoiceClickListener object2 = Java.Lang.Object.GetObject<IDialogInterfaceOnMultiChoiceClickListener>(native_listener, JniHandleOwnership.DoNotTransfer);
				IntPtr result = JNIEnv.ToLocalJniHandle(@object.SetMultiChoiceItems(itemsId, array, object2));
				if (array != null)
				{
					JNIEnv.CopyArray(array, native_checkedItems);
				}
				return result;
			}

			// Token: 0x060001A4 RID: 420 RVA: 0x00004758 File Offset: 0x00002958
			[Register("setMultiChoiceItems", "(I[ZLandroid/content/DialogInterface$OnMultiChoiceClickListener;)Landroidx/appcompat/app/AlertDialog$Builder;", "GetSetMultiChoiceItems_IarrayZLandroid_content_DialogInterface_OnMultiChoiceClickListener_Handler")]
			public unsafe virtual AlertDialog.Builder SetMultiChoiceItems(int itemsId, bool[] checkedItems, IDialogInterfaceOnMultiChoiceClickListener listener)
			{
				IntPtr intPtr = JNIEnv.NewArray(checkedItems);
				AlertDialog.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(itemsId);
					ptr[1] = new JniArgumentValue(intPtr);
					ptr[2] = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
					@object = Java.Lang.Object.GetObject<AlertDialog.Builder>(AlertDialog.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setMultiChoiceItems.(I[ZLandroid/content/DialogInterface$OnMultiChoiceClickListener;)Landroidx/appcompat/app/AlertDialog$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					if (checkedItems != null)
					{
						JNIEnv.CopyArray(intPtr, checkedItems);
						JNIEnv.DeleteLocalRef(intPtr);
					}
					GC.KeepAlive(checkedItems);
					GC.KeepAlive(listener);
				}
				return @object;
			}

			// Token: 0x060001A5 RID: 421 RVA: 0x00004818 File Offset: 0x00002A18
			private static Delegate GetSetMultiChoiceItems_arrayLjava_lang_CharSequence_arrayZLandroid_content_DialogInterface_OnMultiChoiceClickListener_Handler()
			{
				if (AlertDialog.Builder.cb_setMultiChoiceItems_arrayLjava_lang_CharSequence_arrayZLandroid_content_DialogInterface_OnMultiChoiceClickListener_ == null)
				{
					AlertDialog.Builder.cb_setMultiChoiceItems_arrayLjava_lang_CharSequence_arrayZLandroid_content_DialogInterface_OnMultiChoiceClickListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_L(AlertDialog.Builder.n_SetMultiChoiceItems_arrayLjava_lang_CharSequence_arrayZLandroid_content_DialogInterface_OnMultiChoiceClickListener_));
				}
				return AlertDialog.Builder.cb_setMultiChoiceItems_arrayLjava_lang_CharSequence_arrayZLandroid_content_DialogInterface_OnMultiChoiceClickListener_;
			}

			// Token: 0x060001A6 RID: 422 RVA: 0x0000483C File Offset: 0x00002A3C
			private static IntPtr n_SetMultiChoiceItems_arrayLjava_lang_CharSequence_arrayZLandroid_content_DialogInterface_OnMultiChoiceClickListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_items, IntPtr native_checkedItems, IntPtr native_listener)
			{
				AlertDialog.Builder @object = Java.Lang.Object.GetObject<AlertDialog.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				ICharSequence[] array = (ICharSequence[])JNIEnv.GetArray(native_items, JniHandleOwnership.DoNotTransfer, typeof(ICharSequence));
				bool[] array2 = (bool[])JNIEnv.GetArray(native_checkedItems, JniHandleOwnership.DoNotTransfer, typeof(bool));
				IDialogInterfaceOnMultiChoiceClickListener object2 = Java.Lang.Object.GetObject<IDialogInterfaceOnMultiChoiceClickListener>(native_listener, JniHandleOwnership.DoNotTransfer);
				IntPtr result = JNIEnv.ToLocalJniHandle(@object.SetMultiChoiceItems(array, array2, object2));
				if (array != null)
				{
					JNIEnv.CopyArray<ICharSequence>(array, native_items);
				}
				if (array2 != null)
				{
					JNIEnv.CopyArray(array2, native_checkedItems);
				}
				return result;
			}

			// Token: 0x060001A7 RID: 423 RVA: 0x000048AC File Offset: 0x00002AAC
			[Register("setMultiChoiceItems", "([Ljava/lang/CharSequence;[ZLandroid/content/DialogInterface$OnMultiChoiceClickListener;)Landroidx/appcompat/app/AlertDialog$Builder;", "GetSetMultiChoiceItems_arrayLjava_lang_CharSequence_arrayZLandroid_content_DialogInterface_OnMultiChoiceClickListener_Handler")]
			public unsafe virtual AlertDialog.Builder SetMultiChoiceItems(ICharSequence[] items, bool[] checkedItems, IDialogInterfaceOnMultiChoiceClickListener listener)
			{
				IntPtr intPtr = JNIEnv.NewArray<ICharSequence>(items);
				IntPtr intPtr2 = JNIEnv.NewArray(checkedItems);
				AlertDialog.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					ptr[1] = new JniArgumentValue(intPtr2);
					ptr[2] = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
					@object = Java.Lang.Object.GetObject<AlertDialog.Builder>(AlertDialog.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setMultiChoiceItems.([Ljava/lang/CharSequence;[ZLandroid/content/DialogInterface$OnMultiChoiceClickListener;)Landroidx/appcompat/app/AlertDialog$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					if (items != null)
					{
						JNIEnv.CopyArray<ICharSequence>(intPtr, items);
						JNIEnv.DeleteLocalRef(intPtr);
					}
					if (checkedItems != null)
					{
						JNIEnv.CopyArray(intPtr2, checkedItems);
						JNIEnv.DeleteLocalRef(intPtr2);
					}
					GC.KeepAlive(items);
					GC.KeepAlive(checkedItems);
					GC.KeepAlive(listener);
				}
				return @object;
			}

			// Token: 0x060001A8 RID: 424 RVA: 0x0000498C File Offset: 0x00002B8C
			public AlertDialog.Builder SetMultiChoiceItems(string[] items, bool[] checkedItems, IDialogInterfaceOnMultiChoiceClickListener listener)
			{
				ICharSequence[] array = CharSequence.ArrayFromStringArray(items);
				AlertDialog.Builder result = this.SetMultiChoiceItems(array, checkedItems, listener);
				if (array != null)
				{
					foreach (ICharSequence charSequence in array)
					{
						if (charSequence != null)
						{
							charSequence.Dispose();
						}
					}
				}
				return result;
			}

			// Token: 0x060001A9 RID: 425 RVA: 0x000049CC File Offset: 0x00002BCC
			private static Delegate GetSetNegativeButton_ILandroid_content_DialogInterface_OnClickListener_Handler()
			{
				if (AlertDialog.Builder.cb_setNegativeButton_ILandroid_content_DialogInterface_OnClickListener_ == null)
				{
					AlertDialog.Builder.cb_setNegativeButton_ILandroid_content_DialogInterface_OnClickListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_L(AlertDialog.Builder.n_SetNegativeButton_ILandroid_content_DialogInterface_OnClickListener_));
				}
				return AlertDialog.Builder.cb_setNegativeButton_ILandroid_content_DialogInterface_OnClickListener_;
			}

			// Token: 0x060001AA RID: 426 RVA: 0x000049F0 File Offset: 0x00002BF0
			private static IntPtr n_SetNegativeButton_ILandroid_content_DialogInterface_OnClickListener_(IntPtr jnienv, IntPtr native__this, int textId, IntPtr native_listener)
			{
				AlertDialog.Builder @object = Java.Lang.Object.GetObject<AlertDialog.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				IDialogInterfaceOnClickListener object2 = Java.Lang.Object.GetObject<IDialogInterfaceOnClickListener>(native_listener, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetNegativeButton(textId, object2));
			}

			// Token: 0x060001AB RID: 427 RVA: 0x00004A1C File Offset: 0x00002C1C
			[Register("setNegativeButton", "(ILandroid/content/DialogInterface$OnClickListener;)Landroidx/appcompat/app/AlertDialog$Builder;", "GetSetNegativeButton_ILandroid_content_DialogInterface_OnClickListener_Handler")]
			public unsafe virtual AlertDialog.Builder SetNegativeButton(int textId, IDialogInterfaceOnClickListener listener)
			{
				AlertDialog.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(textId);
					ptr[1] = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
					@object = Java.Lang.Object.GetObject<AlertDialog.Builder>(AlertDialog.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setNegativeButton.(ILandroid/content/DialogInterface$OnClickListener;)Landroidx/appcompat/app/AlertDialog$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(listener);
				}
				return @object;
			}

			// Token: 0x060001AC RID: 428 RVA: 0x00004AA8 File Offset: 0x00002CA8
			private static Delegate GetSetNegativeButton_Ljava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_Handler()
			{
				if (AlertDialog.Builder.cb_setNegativeButton_Ljava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_ == null)
				{
					AlertDialog.Builder.cb_setNegativeButton_Ljava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(AlertDialog.Builder.n_SetNegativeButton_Ljava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_));
				}
				return AlertDialog.Builder.cb_setNegativeButton_Ljava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_;
			}

			// Token: 0x060001AD RID: 429 RVA: 0x00004ACC File Offset: 0x00002CCC
			private static IntPtr n_SetNegativeButton_Ljava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_text, IntPtr native_listener)
			{
				AlertDialog.Builder @object = Java.Lang.Object.GetObject<AlertDialog.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_text, JniHandleOwnership.DoNotTransfer);
				IDialogInterfaceOnClickListener object3 = Java.Lang.Object.GetObject<IDialogInterfaceOnClickListener>(native_listener, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetNegativeButton(object2, object3));
			}

			// Token: 0x060001AE RID: 430 RVA: 0x00004B00 File Offset: 0x00002D00
			[Register("setNegativeButton", "(Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)Landroidx/appcompat/app/AlertDialog$Builder;", "GetSetNegativeButton_Ljava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_Handler")]
			public unsafe virtual AlertDialog.Builder SetNegativeButton(ICharSequence text, IDialogInterfaceOnClickListener listener)
			{
				IntPtr intPtr = CharSequence.ToLocalJniHandle(text);
				AlertDialog.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					ptr[1] = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
					@object = Java.Lang.Object.GetObject<AlertDialog.Builder>(AlertDialog.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setNegativeButton.(Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)Landroidx/appcompat/app/AlertDialog$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(text);
					GC.KeepAlive(listener);
				}
				return @object;
			}

			// Token: 0x060001AF RID: 431 RVA: 0x00004BA0 File Offset: 0x00002DA0
			public AlertDialog.Builder SetNegativeButton(string text, IDialogInterfaceOnClickListener listener)
			{
				Java.Lang.String @string = (text == null) ? null : new Java.Lang.String(text);
				AlertDialog.Builder result = this.SetNegativeButton(@string, listener);
				if (@string != null)
				{
					@string.Dispose();
				}
				return result;
			}

			// Token: 0x060001B0 RID: 432 RVA: 0x00004BCB File Offset: 0x00002DCB
			private static Delegate GetSetNegativeButtonIcon_Landroid_graphics_drawable_Drawable_Handler()
			{
				if (AlertDialog.Builder.cb_setNegativeButtonIcon_Landroid_graphics_drawable_Drawable_ == null)
				{
					AlertDialog.Builder.cb_setNegativeButtonIcon_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AlertDialog.Builder.n_SetNegativeButtonIcon_Landroid_graphics_drawable_Drawable_));
				}
				return AlertDialog.Builder.cb_setNegativeButtonIcon_Landroid_graphics_drawable_Drawable_;
			}

			// Token: 0x060001B1 RID: 433 RVA: 0x00004BF0 File Offset: 0x00002DF0
			private static IntPtr n_SetNegativeButtonIcon_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_icon)
			{
				AlertDialog.Builder @object = Java.Lang.Object.GetObject<AlertDialog.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_icon, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetNegativeButtonIcon(object2));
			}

			// Token: 0x060001B2 RID: 434 RVA: 0x00004C18 File Offset: 0x00002E18
			[Register("setNegativeButtonIcon", "(Landroid/graphics/drawable/Drawable;)Landroidx/appcompat/app/AlertDialog$Builder;", "GetSetNegativeButtonIcon_Landroid_graphics_drawable_Drawable_Handler")]
			public unsafe virtual AlertDialog.Builder SetNegativeButtonIcon(Drawable icon)
			{
				AlertDialog.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((icon == null) ? IntPtr.Zero : icon.Handle);
					@object = Java.Lang.Object.GetObject<AlertDialog.Builder>(AlertDialog.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setNegativeButtonIcon.(Landroid/graphics/drawable/Drawable;)Landroidx/appcompat/app/AlertDialog$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(icon);
				}
				return @object;
			}

			// Token: 0x060001B3 RID: 435 RVA: 0x00004C8C File Offset: 0x00002E8C
			private static Delegate GetSetNeutralButton_ILandroid_content_DialogInterface_OnClickListener_Handler()
			{
				if (AlertDialog.Builder.cb_setNeutralButton_ILandroid_content_DialogInterface_OnClickListener_ == null)
				{
					AlertDialog.Builder.cb_setNeutralButton_ILandroid_content_DialogInterface_OnClickListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_L(AlertDialog.Builder.n_SetNeutralButton_ILandroid_content_DialogInterface_OnClickListener_));
				}
				return AlertDialog.Builder.cb_setNeutralButton_ILandroid_content_DialogInterface_OnClickListener_;
			}

			// Token: 0x060001B4 RID: 436 RVA: 0x00004CB0 File Offset: 0x00002EB0
			private static IntPtr n_SetNeutralButton_ILandroid_content_DialogInterface_OnClickListener_(IntPtr jnienv, IntPtr native__this, int textId, IntPtr native_listener)
			{
				AlertDialog.Builder @object = Java.Lang.Object.GetObject<AlertDialog.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				IDialogInterfaceOnClickListener object2 = Java.Lang.Object.GetObject<IDialogInterfaceOnClickListener>(native_listener, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetNeutralButton(textId, object2));
			}

			// Token: 0x060001B5 RID: 437 RVA: 0x00004CDC File Offset: 0x00002EDC
			[Register("setNeutralButton", "(ILandroid/content/DialogInterface$OnClickListener;)Landroidx/appcompat/app/AlertDialog$Builder;", "GetSetNeutralButton_ILandroid_content_DialogInterface_OnClickListener_Handler")]
			public unsafe virtual AlertDialog.Builder SetNeutralButton(int textId, IDialogInterfaceOnClickListener listener)
			{
				AlertDialog.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(textId);
					ptr[1] = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
					@object = Java.Lang.Object.GetObject<AlertDialog.Builder>(AlertDialog.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setNeutralButton.(ILandroid/content/DialogInterface$OnClickListener;)Landroidx/appcompat/app/AlertDialog$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(listener);
				}
				return @object;
			}

			// Token: 0x060001B6 RID: 438 RVA: 0x00004D68 File Offset: 0x00002F68
			private static Delegate GetSetNeutralButton_Ljava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_Handler()
			{
				if (AlertDialog.Builder.cb_setNeutralButton_Ljava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_ == null)
				{
					AlertDialog.Builder.cb_setNeutralButton_Ljava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(AlertDialog.Builder.n_SetNeutralButton_Ljava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_));
				}
				return AlertDialog.Builder.cb_setNeutralButton_Ljava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_;
			}

			// Token: 0x060001B7 RID: 439 RVA: 0x00004D8C File Offset: 0x00002F8C
			private static IntPtr n_SetNeutralButton_Ljava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_text, IntPtr native_listener)
			{
				AlertDialog.Builder @object = Java.Lang.Object.GetObject<AlertDialog.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_text, JniHandleOwnership.DoNotTransfer);
				IDialogInterfaceOnClickListener object3 = Java.Lang.Object.GetObject<IDialogInterfaceOnClickListener>(native_listener, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetNeutralButton(object2, object3));
			}

			// Token: 0x060001B8 RID: 440 RVA: 0x00004DC0 File Offset: 0x00002FC0
			[Register("setNeutralButton", "(Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)Landroidx/appcompat/app/AlertDialog$Builder;", "GetSetNeutralButton_Ljava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_Handler")]
			public unsafe virtual AlertDialog.Builder SetNeutralButton(ICharSequence text, IDialogInterfaceOnClickListener listener)
			{
				IntPtr intPtr = CharSequence.ToLocalJniHandle(text);
				AlertDialog.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					ptr[1] = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
					@object = Java.Lang.Object.GetObject<AlertDialog.Builder>(AlertDialog.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setNeutralButton.(Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)Landroidx/appcompat/app/AlertDialog$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(text);
					GC.KeepAlive(listener);
				}
				return @object;
			}

			// Token: 0x060001B9 RID: 441 RVA: 0x00004E60 File Offset: 0x00003060
			public AlertDialog.Builder SetNeutralButton(string text, IDialogInterfaceOnClickListener listener)
			{
				Java.Lang.String @string = (text == null) ? null : new Java.Lang.String(text);
				AlertDialog.Builder result = this.SetNeutralButton(@string, listener);
				if (@string != null)
				{
					@string.Dispose();
				}
				return result;
			}

			// Token: 0x060001BA RID: 442 RVA: 0x00004E8B File Offset: 0x0000308B
			private static Delegate GetSetNeutralButtonIcon_Landroid_graphics_drawable_Drawable_Handler()
			{
				if (AlertDialog.Builder.cb_setNeutralButtonIcon_Landroid_graphics_drawable_Drawable_ == null)
				{
					AlertDialog.Builder.cb_setNeutralButtonIcon_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AlertDialog.Builder.n_SetNeutralButtonIcon_Landroid_graphics_drawable_Drawable_));
				}
				return AlertDialog.Builder.cb_setNeutralButtonIcon_Landroid_graphics_drawable_Drawable_;
			}

			// Token: 0x060001BB RID: 443 RVA: 0x00004EB0 File Offset: 0x000030B0
			private static IntPtr n_SetNeutralButtonIcon_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_icon)
			{
				AlertDialog.Builder @object = Java.Lang.Object.GetObject<AlertDialog.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_icon, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetNeutralButtonIcon(object2));
			}

			// Token: 0x060001BC RID: 444 RVA: 0x00004ED8 File Offset: 0x000030D8
			[Register("setNeutralButtonIcon", "(Landroid/graphics/drawable/Drawable;)Landroidx/appcompat/app/AlertDialog$Builder;", "GetSetNeutralButtonIcon_Landroid_graphics_drawable_Drawable_Handler")]
			public unsafe virtual AlertDialog.Builder SetNeutralButtonIcon(Drawable icon)
			{
				AlertDialog.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((icon == null) ? IntPtr.Zero : icon.Handle);
					@object = Java.Lang.Object.GetObject<AlertDialog.Builder>(AlertDialog.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setNeutralButtonIcon.(Landroid/graphics/drawable/Drawable;)Landroidx/appcompat/app/AlertDialog$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(icon);
				}
				return @object;
			}

			// Token: 0x060001BD RID: 445 RVA: 0x00004F4C File Offset: 0x0000314C
			private static Delegate GetSetOnCancelListener_Landroid_content_DialogInterface_OnCancelListener_Handler()
			{
				if (AlertDialog.Builder.cb_setOnCancelListener_Landroid_content_DialogInterface_OnCancelListener_ == null)
				{
					AlertDialog.Builder.cb_setOnCancelListener_Landroid_content_DialogInterface_OnCancelListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AlertDialog.Builder.n_SetOnCancelListener_Landroid_content_DialogInterface_OnCancelListener_));
				}
				return AlertDialog.Builder.cb_setOnCancelListener_Landroid_content_DialogInterface_OnCancelListener_;
			}

			// Token: 0x060001BE RID: 446 RVA: 0x00004F70 File Offset: 0x00003170
			private static IntPtr n_SetOnCancelListener_Landroid_content_DialogInterface_OnCancelListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_onCancelListener)
			{
				AlertDialog.Builder @object = Java.Lang.Object.GetObject<AlertDialog.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				IDialogInterfaceOnCancelListener object2 = Java.Lang.Object.GetObject<IDialogInterfaceOnCancelListener>(native_onCancelListener, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetOnCancelListener(object2));
			}

			// Token: 0x060001BF RID: 447 RVA: 0x00004F98 File Offset: 0x00003198
			[Register("setOnCancelListener", "(Landroid/content/DialogInterface$OnCancelListener;)Landroidx/appcompat/app/AlertDialog$Builder;", "GetSetOnCancelListener_Landroid_content_DialogInterface_OnCancelListener_Handler")]
			public unsafe virtual AlertDialog.Builder SetOnCancelListener(IDialogInterfaceOnCancelListener onCancelListener)
			{
				AlertDialog.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((onCancelListener == null) ? IntPtr.Zero : ((Java.Lang.Object)onCancelListener).Handle);
					@object = Java.Lang.Object.GetObject<AlertDialog.Builder>(AlertDialog.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setOnCancelListener.(Landroid/content/DialogInterface$OnCancelListener;)Landroidx/appcompat/app/AlertDialog$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(onCancelListener);
				}
				return @object;
			}

			// Token: 0x060001C0 RID: 448 RVA: 0x00005010 File Offset: 0x00003210
			private static Delegate GetSetOnDismissListener_Landroid_content_DialogInterface_OnDismissListener_Handler()
			{
				if (AlertDialog.Builder.cb_setOnDismissListener_Landroid_content_DialogInterface_OnDismissListener_ == null)
				{
					AlertDialog.Builder.cb_setOnDismissListener_Landroid_content_DialogInterface_OnDismissListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AlertDialog.Builder.n_SetOnDismissListener_Landroid_content_DialogInterface_OnDismissListener_));
				}
				return AlertDialog.Builder.cb_setOnDismissListener_Landroid_content_DialogInterface_OnDismissListener_;
			}

			// Token: 0x060001C1 RID: 449 RVA: 0x00005034 File Offset: 0x00003234
			private static IntPtr n_SetOnDismissListener_Landroid_content_DialogInterface_OnDismissListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_onDismissListener)
			{
				AlertDialog.Builder @object = Java.Lang.Object.GetObject<AlertDialog.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				IDialogInterfaceOnDismissListener object2 = Java.Lang.Object.GetObject<IDialogInterfaceOnDismissListener>(native_onDismissListener, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetOnDismissListener(object2));
			}

			// Token: 0x060001C2 RID: 450 RVA: 0x0000505C File Offset: 0x0000325C
			[Register("setOnDismissListener", "(Landroid/content/DialogInterface$OnDismissListener;)Landroidx/appcompat/app/AlertDialog$Builder;", "GetSetOnDismissListener_Landroid_content_DialogInterface_OnDismissListener_Handler")]
			public unsafe virtual AlertDialog.Builder SetOnDismissListener(IDialogInterfaceOnDismissListener onDismissListener)
			{
				AlertDialog.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((onDismissListener == null) ? IntPtr.Zero : ((Java.Lang.Object)onDismissListener).Handle);
					@object = Java.Lang.Object.GetObject<AlertDialog.Builder>(AlertDialog.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setOnDismissListener.(Landroid/content/DialogInterface$OnDismissListener;)Landroidx/appcompat/app/AlertDialog$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(onDismissListener);
				}
				return @object;
			}

			// Token: 0x060001C3 RID: 451 RVA: 0x000050D4 File Offset: 0x000032D4
			private static Delegate GetSetOnItemSelectedListener_Landroid_widget_AdapterView_OnItemSelectedListener_Handler()
			{
				if (AlertDialog.Builder.cb_setOnItemSelectedListener_Landroid_widget_AdapterView_OnItemSelectedListener_ == null)
				{
					AlertDialog.Builder.cb_setOnItemSelectedListener_Landroid_widget_AdapterView_OnItemSelectedListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AlertDialog.Builder.n_SetOnItemSelectedListener_Landroid_widget_AdapterView_OnItemSelectedListener_));
				}
				return AlertDialog.Builder.cb_setOnItemSelectedListener_Landroid_widget_AdapterView_OnItemSelectedListener_;
			}

			// Token: 0x060001C4 RID: 452 RVA: 0x000050F8 File Offset: 0x000032F8
			private static IntPtr n_SetOnItemSelectedListener_Landroid_widget_AdapterView_OnItemSelectedListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
			{
				AlertDialog.Builder @object = Java.Lang.Object.GetObject<AlertDialog.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				AdapterView.IOnItemSelectedListener object2 = Java.Lang.Object.GetObject<AdapterView.IOnItemSelectedListener>(native_listener, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetOnItemSelectedListener(object2));
			}

			// Token: 0x060001C5 RID: 453 RVA: 0x00005120 File Offset: 0x00003320
			[Register("setOnItemSelectedListener", "(Landroid/widget/AdapterView$OnItemSelectedListener;)Landroidx/appcompat/app/AlertDialog$Builder;", "GetSetOnItemSelectedListener_Landroid_widget_AdapterView_OnItemSelectedListener_Handler")]
			public unsafe virtual AlertDialog.Builder SetOnItemSelectedListener(AdapterView.IOnItemSelectedListener listener)
			{
				AlertDialog.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
					@object = Java.Lang.Object.GetObject<AlertDialog.Builder>(AlertDialog.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setOnItemSelectedListener.(Landroid/widget/AdapterView$OnItemSelectedListener;)Landroidx/appcompat/app/AlertDialog$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(listener);
				}
				return @object;
			}

			// Token: 0x060001C6 RID: 454 RVA: 0x00005198 File Offset: 0x00003398
			private static Delegate GetSetOnKeyListener_Landroid_content_DialogInterface_OnKeyListener_Handler()
			{
				if (AlertDialog.Builder.cb_setOnKeyListener_Landroid_content_DialogInterface_OnKeyListener_ == null)
				{
					AlertDialog.Builder.cb_setOnKeyListener_Landroid_content_DialogInterface_OnKeyListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AlertDialog.Builder.n_SetOnKeyListener_Landroid_content_DialogInterface_OnKeyListener_));
				}
				return AlertDialog.Builder.cb_setOnKeyListener_Landroid_content_DialogInterface_OnKeyListener_;
			}

			// Token: 0x060001C7 RID: 455 RVA: 0x000051BC File Offset: 0x000033BC
			private static IntPtr n_SetOnKeyListener_Landroid_content_DialogInterface_OnKeyListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_onKeyListener)
			{
				AlertDialog.Builder @object = Java.Lang.Object.GetObject<AlertDialog.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				IDialogInterfaceOnKeyListener object2 = Java.Lang.Object.GetObject<IDialogInterfaceOnKeyListener>(native_onKeyListener, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetOnKeyListener(object2));
			}

			// Token: 0x060001C8 RID: 456 RVA: 0x000051E4 File Offset: 0x000033E4
			[Register("setOnKeyListener", "(Landroid/content/DialogInterface$OnKeyListener;)Landroidx/appcompat/app/AlertDialog$Builder;", "GetSetOnKeyListener_Landroid_content_DialogInterface_OnKeyListener_Handler")]
			public unsafe virtual AlertDialog.Builder SetOnKeyListener(IDialogInterfaceOnKeyListener onKeyListener)
			{
				AlertDialog.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((onKeyListener == null) ? IntPtr.Zero : ((Java.Lang.Object)onKeyListener).Handle);
					@object = Java.Lang.Object.GetObject<AlertDialog.Builder>(AlertDialog.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setOnKeyListener.(Landroid/content/DialogInterface$OnKeyListener;)Landroidx/appcompat/app/AlertDialog$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(onKeyListener);
				}
				return @object;
			}

			// Token: 0x060001C9 RID: 457 RVA: 0x0000525C File Offset: 0x0000345C
			private static Delegate GetSetPositiveButton_ILandroid_content_DialogInterface_OnClickListener_Handler()
			{
				if (AlertDialog.Builder.cb_setPositiveButton_ILandroid_content_DialogInterface_OnClickListener_ == null)
				{
					AlertDialog.Builder.cb_setPositiveButton_ILandroid_content_DialogInterface_OnClickListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_L(AlertDialog.Builder.n_SetPositiveButton_ILandroid_content_DialogInterface_OnClickListener_));
				}
				return AlertDialog.Builder.cb_setPositiveButton_ILandroid_content_DialogInterface_OnClickListener_;
			}

			// Token: 0x060001CA RID: 458 RVA: 0x00005280 File Offset: 0x00003480
			private static IntPtr n_SetPositiveButton_ILandroid_content_DialogInterface_OnClickListener_(IntPtr jnienv, IntPtr native__this, int textId, IntPtr native_listener)
			{
				AlertDialog.Builder @object = Java.Lang.Object.GetObject<AlertDialog.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				IDialogInterfaceOnClickListener object2 = Java.Lang.Object.GetObject<IDialogInterfaceOnClickListener>(native_listener, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetPositiveButton(textId, object2));
			}

			// Token: 0x060001CB RID: 459 RVA: 0x000052AC File Offset: 0x000034AC
			[Register("setPositiveButton", "(ILandroid/content/DialogInterface$OnClickListener;)Landroidx/appcompat/app/AlertDialog$Builder;", "GetSetPositiveButton_ILandroid_content_DialogInterface_OnClickListener_Handler")]
			public unsafe virtual AlertDialog.Builder SetPositiveButton(int textId, IDialogInterfaceOnClickListener listener)
			{
				AlertDialog.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(textId);
					ptr[1] = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
					@object = Java.Lang.Object.GetObject<AlertDialog.Builder>(AlertDialog.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setPositiveButton.(ILandroid/content/DialogInterface$OnClickListener;)Landroidx/appcompat/app/AlertDialog$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(listener);
				}
				return @object;
			}

			// Token: 0x060001CC RID: 460 RVA: 0x00005338 File Offset: 0x00003538
			private static Delegate GetSetPositiveButton_Ljava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_Handler()
			{
				if (AlertDialog.Builder.cb_setPositiveButton_Ljava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_ == null)
				{
					AlertDialog.Builder.cb_setPositiveButton_Ljava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(AlertDialog.Builder.n_SetPositiveButton_Ljava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_));
				}
				return AlertDialog.Builder.cb_setPositiveButton_Ljava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_;
			}

			// Token: 0x060001CD RID: 461 RVA: 0x0000535C File Offset: 0x0000355C
			private static IntPtr n_SetPositiveButton_Ljava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_text, IntPtr native_listener)
			{
				AlertDialog.Builder @object = Java.Lang.Object.GetObject<AlertDialog.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_text, JniHandleOwnership.DoNotTransfer);
				IDialogInterfaceOnClickListener object3 = Java.Lang.Object.GetObject<IDialogInterfaceOnClickListener>(native_listener, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetPositiveButton(object2, object3));
			}

			// Token: 0x060001CE RID: 462 RVA: 0x00005390 File Offset: 0x00003590
			[Register("setPositiveButton", "(Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)Landroidx/appcompat/app/AlertDialog$Builder;", "GetSetPositiveButton_Ljava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_Handler")]
			public unsafe virtual AlertDialog.Builder SetPositiveButton(ICharSequence text, IDialogInterfaceOnClickListener listener)
			{
				IntPtr intPtr = CharSequence.ToLocalJniHandle(text);
				AlertDialog.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					ptr[1] = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
					@object = Java.Lang.Object.GetObject<AlertDialog.Builder>(AlertDialog.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setPositiveButton.(Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)Landroidx/appcompat/app/AlertDialog$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(text);
					GC.KeepAlive(listener);
				}
				return @object;
			}

			// Token: 0x060001CF RID: 463 RVA: 0x00005430 File Offset: 0x00003630
			public AlertDialog.Builder SetPositiveButton(string text, IDialogInterfaceOnClickListener listener)
			{
				Java.Lang.String @string = (text == null) ? null : new Java.Lang.String(text);
				AlertDialog.Builder result = this.SetPositiveButton(@string, listener);
				if (@string != null)
				{
					@string.Dispose();
				}
				return result;
			}

			// Token: 0x060001D0 RID: 464 RVA: 0x0000545B File Offset: 0x0000365B
			private static Delegate GetSetPositiveButtonIcon_Landroid_graphics_drawable_Drawable_Handler()
			{
				if (AlertDialog.Builder.cb_setPositiveButtonIcon_Landroid_graphics_drawable_Drawable_ == null)
				{
					AlertDialog.Builder.cb_setPositiveButtonIcon_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AlertDialog.Builder.n_SetPositiveButtonIcon_Landroid_graphics_drawable_Drawable_));
				}
				return AlertDialog.Builder.cb_setPositiveButtonIcon_Landroid_graphics_drawable_Drawable_;
			}

			// Token: 0x060001D1 RID: 465 RVA: 0x00005480 File Offset: 0x00003680
			private static IntPtr n_SetPositiveButtonIcon_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_icon)
			{
				AlertDialog.Builder @object = Java.Lang.Object.GetObject<AlertDialog.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_icon, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetPositiveButtonIcon(object2));
			}

			// Token: 0x060001D2 RID: 466 RVA: 0x000054A8 File Offset: 0x000036A8
			[Register("setPositiveButtonIcon", "(Landroid/graphics/drawable/Drawable;)Landroidx/appcompat/app/AlertDialog$Builder;", "GetSetPositiveButtonIcon_Landroid_graphics_drawable_Drawable_Handler")]
			public unsafe virtual AlertDialog.Builder SetPositiveButtonIcon(Drawable icon)
			{
				AlertDialog.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((icon == null) ? IntPtr.Zero : icon.Handle);
					@object = Java.Lang.Object.GetObject<AlertDialog.Builder>(AlertDialog.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setPositiveButtonIcon.(Landroid/graphics/drawable/Drawable;)Landroidx/appcompat/app/AlertDialog$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(icon);
				}
				return @object;
			}

			// Token: 0x060001D3 RID: 467 RVA: 0x0000551C File Offset: 0x0000371C
			private static Delegate GetSetRecycleOnMeasureEnabled_ZHandler()
			{
				if (AlertDialog.Builder.cb_setRecycleOnMeasureEnabled_Z == null)
				{
					AlertDialog.Builder.cb_setRecycleOnMeasureEnabled_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_L(AlertDialog.Builder.n_SetRecycleOnMeasureEnabled_Z));
				}
				return AlertDialog.Builder.cb_setRecycleOnMeasureEnabled_Z;
			}

			// Token: 0x060001D4 RID: 468 RVA: 0x00005540 File Offset: 0x00003740
			private static IntPtr n_SetRecycleOnMeasureEnabled_Z(IntPtr jnienv, IntPtr native__this, bool enabled)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AlertDialog.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetRecycleOnMeasureEnabled(enabled));
			}

			// Token: 0x060001D5 RID: 469 RVA: 0x00005558 File Offset: 0x00003758
			[Register("setRecycleOnMeasureEnabled", "(Z)Landroidx/appcompat/app/AlertDialog$Builder;", "GetSetRecycleOnMeasureEnabled_ZHandler")]
			public unsafe virtual AlertDialog.Builder SetRecycleOnMeasureEnabled(bool enabled)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(enabled);
				return Java.Lang.Object.GetObject<AlertDialog.Builder>(AlertDialog.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setRecycleOnMeasureEnabled.(Z)Landroidx/appcompat/app/AlertDialog$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x060001D6 RID: 470 RVA: 0x000055A1 File Offset: 0x000037A1
			private static Delegate GetSetSingleChoiceItems_Landroid_database_Cursor_ILjava_lang_String_Landroid_content_DialogInterface_OnClickListener_Handler()
			{
				if (AlertDialog.Builder.cb_setSingleChoiceItems_Landroid_database_Cursor_ILjava_lang_String_Landroid_content_DialogInterface_OnClickListener_ == null)
				{
					AlertDialog.Builder.cb_setSingleChoiceItems_Landroid_database_Cursor_ILjava_lang_String_Landroid_content_DialogInterface_OnClickListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLILL_L(AlertDialog.Builder.n_SetSingleChoiceItems_Landroid_database_Cursor_ILjava_lang_String_Landroid_content_DialogInterface_OnClickListener_));
				}
				return AlertDialog.Builder.cb_setSingleChoiceItems_Landroid_database_Cursor_ILjava_lang_String_Landroid_content_DialogInterface_OnClickListener_;
			}

			// Token: 0x060001D7 RID: 471 RVA: 0x000055C8 File Offset: 0x000037C8
			private static IntPtr n_SetSingleChoiceItems_Landroid_database_Cursor_ILjava_lang_String_Landroid_content_DialogInterface_OnClickListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_cursor, int checkedItem, IntPtr native_labelColumn, IntPtr native_listener)
			{
				AlertDialog.Builder @object = Java.Lang.Object.GetObject<AlertDialog.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				ICursor object2 = Java.Lang.Object.GetObject<ICursor>(native_cursor, JniHandleOwnership.DoNotTransfer);
				string @string = JNIEnv.GetString(native_labelColumn, JniHandleOwnership.DoNotTransfer);
				IDialogInterfaceOnClickListener object3 = Java.Lang.Object.GetObject<IDialogInterfaceOnClickListener>(native_listener, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetSingleChoiceItems(object2, checkedItem, @string, object3));
			}

			// Token: 0x060001D8 RID: 472 RVA: 0x00005608 File Offset: 0x00003808
			[Register("setSingleChoiceItems", "(Landroid/database/Cursor;ILjava/lang/String;Landroid/content/DialogInterface$OnClickListener;)Landroidx/appcompat/app/AlertDialog$Builder;", "GetSetSingleChoiceItems_Landroid_database_Cursor_ILjava_lang_String_Landroid_content_DialogInterface_OnClickListener_Handler")]
			public unsafe virtual AlertDialog.Builder SetSingleChoiceItems(ICursor cursor, int checkedItem, string labelColumn, IDialogInterfaceOnClickListener listener)
			{
				IntPtr intPtr = JNIEnv.NewString(labelColumn);
				AlertDialog.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((cursor == null) ? IntPtr.Zero : ((Java.Lang.Object)cursor).Handle);
					ptr[1] = new JniArgumentValue(checkedItem);
					ptr[2] = new JniArgumentValue(intPtr);
					ptr[3] = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
					@object = Java.Lang.Object.GetObject<AlertDialog.Builder>(AlertDialog.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setSingleChoiceItems.(Landroid/database/Cursor;ILjava/lang/String;Landroid/content/DialogInterface$OnClickListener;)Landroidx/appcompat/app/AlertDialog$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(cursor);
					GC.KeepAlive(listener);
				}
				return @object;
			}

			// Token: 0x060001D9 RID: 473 RVA: 0x000056EC File Offset: 0x000038EC
			private static Delegate GetSetSingleChoiceItems_Landroid_widget_ListAdapter_ILandroid_content_DialogInterface_OnClickListener_Handler()
			{
				if (AlertDialog.Builder.cb_setSingleChoiceItems_Landroid_widget_ListAdapter_ILandroid_content_DialogInterface_OnClickListener_ == null)
				{
					AlertDialog.Builder.cb_setSingleChoiceItems_Landroid_widget_ListAdapter_ILandroid_content_DialogInterface_OnClickListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIL_L(AlertDialog.Builder.n_SetSingleChoiceItems_Landroid_widget_ListAdapter_ILandroid_content_DialogInterface_OnClickListener_));
				}
				return AlertDialog.Builder.cb_setSingleChoiceItems_Landroid_widget_ListAdapter_ILandroid_content_DialogInterface_OnClickListener_;
			}

			// Token: 0x060001DA RID: 474 RVA: 0x00005710 File Offset: 0x00003910
			private static IntPtr n_SetSingleChoiceItems_Landroid_widget_ListAdapter_ILandroid_content_DialogInterface_OnClickListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_adapter, int checkedItem, IntPtr native_listener)
			{
				AlertDialog.Builder @object = Java.Lang.Object.GetObject<AlertDialog.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				IListAdapter object2 = Java.Lang.Object.GetObject<IListAdapter>(native_adapter, JniHandleOwnership.DoNotTransfer);
				IDialogInterfaceOnClickListener object3 = Java.Lang.Object.GetObject<IDialogInterfaceOnClickListener>(native_listener, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetSingleChoiceItems(object2, checkedItem, object3));
			}

			// Token: 0x060001DB RID: 475 RVA: 0x00005744 File Offset: 0x00003944
			[Register("setSingleChoiceItems", "(Landroid/widget/ListAdapter;ILandroid/content/DialogInterface$OnClickListener;)Landroidx/appcompat/app/AlertDialog$Builder;", "GetSetSingleChoiceItems_Landroid_widget_ListAdapter_ILandroid_content_DialogInterface_OnClickListener_Handler")]
			public unsafe virtual AlertDialog.Builder SetSingleChoiceItems(IListAdapter adapter, int checkedItem, IDialogInterfaceOnClickListener listener)
			{
				AlertDialog.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((adapter == null) ? IntPtr.Zero : ((Java.Lang.Object)adapter).Handle);
					ptr[1] = new JniArgumentValue(checkedItem);
					ptr[2] = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
					@object = Java.Lang.Object.GetObject<AlertDialog.Builder>(AlertDialog.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setSingleChoiceItems.(Landroid/widget/ListAdapter;ILandroid/content/DialogInterface$OnClickListener;)Landroidx/appcompat/app/AlertDialog$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(adapter);
					GC.KeepAlive(listener);
				}
				return @object;
			}

			// Token: 0x060001DC RID: 476 RVA: 0x00005800 File Offset: 0x00003A00
			private static Delegate GetSetSingleChoiceItems_IILandroid_content_DialogInterface_OnClickListener_Handler()
			{
				if (AlertDialog.Builder.cb_setSingleChoiceItems_IILandroid_content_DialogInterface_OnClickListener_ == null)
				{
					AlertDialog.Builder.cb_setSingleChoiceItems_IILandroid_content_DialogInterface_OnClickListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIIL_L(AlertDialog.Builder.n_SetSingleChoiceItems_IILandroid_content_DialogInterface_OnClickListener_));
				}
				return AlertDialog.Builder.cb_setSingleChoiceItems_IILandroid_content_DialogInterface_OnClickListener_;
			}

			// Token: 0x060001DD RID: 477 RVA: 0x00005824 File Offset: 0x00003A24
			private static IntPtr n_SetSingleChoiceItems_IILandroid_content_DialogInterface_OnClickListener_(IntPtr jnienv, IntPtr native__this, int itemsId, int checkedItem, IntPtr native_listener)
			{
				AlertDialog.Builder @object = Java.Lang.Object.GetObject<AlertDialog.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				IDialogInterfaceOnClickListener object2 = Java.Lang.Object.GetObject<IDialogInterfaceOnClickListener>(native_listener, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetSingleChoiceItems(itemsId, checkedItem, object2));
			}

			// Token: 0x060001DE RID: 478 RVA: 0x00005850 File Offset: 0x00003A50
			[Register("setSingleChoiceItems", "(IILandroid/content/DialogInterface$OnClickListener;)Landroidx/appcompat/app/AlertDialog$Builder;", "GetSetSingleChoiceItems_IILandroid_content_DialogInterface_OnClickListener_Handler")]
			public unsafe virtual AlertDialog.Builder SetSingleChoiceItems(int itemsId, int checkedItem, IDialogInterfaceOnClickListener listener)
			{
				AlertDialog.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(itemsId);
					ptr[1] = new JniArgumentValue(checkedItem);
					ptr[2] = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
					@object = Java.Lang.Object.GetObject<AlertDialog.Builder>(AlertDialog.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setSingleChoiceItems.(IILandroid/content/DialogInterface$OnClickListener;)Landroidx/appcompat/app/AlertDialog$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(listener);
				}
				return @object;
			}

			// Token: 0x060001DF RID: 479 RVA: 0x000058F4 File Offset: 0x00003AF4
			private static Delegate GetSetSingleChoiceItems_arrayLjava_lang_CharSequence_ILandroid_content_DialogInterface_OnClickListener_Handler()
			{
				if (AlertDialog.Builder.cb_setSingleChoiceItems_arrayLjava_lang_CharSequence_ILandroid_content_DialogInterface_OnClickListener_ == null)
				{
					AlertDialog.Builder.cb_setSingleChoiceItems_arrayLjava_lang_CharSequence_ILandroid_content_DialogInterface_OnClickListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIL_L(AlertDialog.Builder.n_SetSingleChoiceItems_arrayLjava_lang_CharSequence_ILandroid_content_DialogInterface_OnClickListener_));
				}
				return AlertDialog.Builder.cb_setSingleChoiceItems_arrayLjava_lang_CharSequence_ILandroid_content_DialogInterface_OnClickListener_;
			}

			// Token: 0x060001E0 RID: 480 RVA: 0x00005918 File Offset: 0x00003B18
			private static IntPtr n_SetSingleChoiceItems_arrayLjava_lang_CharSequence_ILandroid_content_DialogInterface_OnClickListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_items, int checkedItem, IntPtr native_listener)
			{
				AlertDialog.Builder @object = Java.Lang.Object.GetObject<AlertDialog.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				ICharSequence[] array = (ICharSequence[])JNIEnv.GetArray(native_items, JniHandleOwnership.DoNotTransfer, typeof(ICharSequence));
				IDialogInterfaceOnClickListener object2 = Java.Lang.Object.GetObject<IDialogInterfaceOnClickListener>(native_listener, JniHandleOwnership.DoNotTransfer);
				IntPtr result = JNIEnv.ToLocalJniHandle(@object.SetSingleChoiceItems(array, checkedItem, object2));
				if (array != null)
				{
					JNIEnv.CopyArray<ICharSequence>(array, native_items);
				}
				return result;
			}

			// Token: 0x060001E1 RID: 481 RVA: 0x00005964 File Offset: 0x00003B64
			[Register("setSingleChoiceItems", "([Ljava/lang/CharSequence;ILandroid/content/DialogInterface$OnClickListener;)Landroidx/appcompat/app/AlertDialog$Builder;", "GetSetSingleChoiceItems_arrayLjava_lang_CharSequence_ILandroid_content_DialogInterface_OnClickListener_Handler")]
			public unsafe virtual AlertDialog.Builder SetSingleChoiceItems(ICharSequence[] items, int checkedItem, IDialogInterfaceOnClickListener listener)
			{
				IntPtr intPtr = JNIEnv.NewArray<ICharSequence>(items);
				AlertDialog.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					ptr[1] = new JniArgumentValue(checkedItem);
					ptr[2] = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
					@object = Java.Lang.Object.GetObject<AlertDialog.Builder>(AlertDialog.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setSingleChoiceItems.([Ljava/lang/CharSequence;ILandroid/content/DialogInterface$OnClickListener;)Landroidx/appcompat/app/AlertDialog$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					if (items != null)
					{
						JNIEnv.CopyArray<ICharSequence>(intPtr, items);
						JNIEnv.DeleteLocalRef(intPtr);
					}
					GC.KeepAlive(items);
					GC.KeepAlive(listener);
				}
				return @object;
			}

			// Token: 0x060001E2 RID: 482 RVA: 0x00005A24 File Offset: 0x00003C24
			public AlertDialog.Builder SetSingleChoiceItems(string[] items, int checkedItem, IDialogInterfaceOnClickListener listener)
			{
				ICharSequence[] array = CharSequence.ArrayFromStringArray(items);
				AlertDialog.Builder result = this.SetSingleChoiceItems(array, checkedItem, listener);
				if (array != null)
				{
					foreach (ICharSequence charSequence in array)
					{
						if (charSequence != null)
						{
							charSequence.Dispose();
						}
					}
				}
				return result;
			}

			// Token: 0x060001E3 RID: 483 RVA: 0x00005A64 File Offset: 0x00003C64
			private static Delegate GetSetTitle_IHandler()
			{
				if (AlertDialog.Builder.cb_setTitle_I == null)
				{
					AlertDialog.Builder.cb_setTitle_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(AlertDialog.Builder.n_SetTitle_I));
				}
				return AlertDialog.Builder.cb_setTitle_I;
			}

			// Token: 0x060001E4 RID: 484 RVA: 0x00005A88 File Offset: 0x00003C88
			private static IntPtr n_SetTitle_I(IntPtr jnienv, IntPtr native__this, int titleId)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AlertDialog.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetTitle(titleId));
			}

			// Token: 0x060001E5 RID: 485 RVA: 0x00005AA0 File Offset: 0x00003CA0
			[Register("setTitle", "(I)Landroidx/appcompat/app/AlertDialog$Builder;", "GetSetTitle_IHandler")]
			public unsafe virtual AlertDialog.Builder SetTitle(int titleId)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(titleId);
				return Java.Lang.Object.GetObject<AlertDialog.Builder>(AlertDialog.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setTitle.(I)Landroidx/appcompat/app/AlertDialog$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x060001E6 RID: 486 RVA: 0x00005AE9 File Offset: 0x00003CE9
			private static Delegate GetSetTitle_Ljava_lang_CharSequence_Handler()
			{
				if (AlertDialog.Builder.cb_setTitle_Ljava_lang_CharSequence_ == null)
				{
					AlertDialog.Builder.cb_setTitle_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AlertDialog.Builder.n_SetTitle_Ljava_lang_CharSequence_));
				}
				return AlertDialog.Builder.cb_setTitle_Ljava_lang_CharSequence_;
			}

			// Token: 0x060001E7 RID: 487 RVA: 0x00005B10 File Offset: 0x00003D10
			private static IntPtr n_SetTitle_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_title)
			{
				AlertDialog.Builder @object = Java.Lang.Object.GetObject<AlertDialog.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_title, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetTitle(object2));
			}

			// Token: 0x060001E8 RID: 488 RVA: 0x00005B38 File Offset: 0x00003D38
			[Register("setTitle", "(Ljava/lang/CharSequence;)Landroidx/appcompat/app/AlertDialog$Builder;", "GetSetTitle_Ljava_lang_CharSequence_Handler")]
			public unsafe virtual AlertDialog.Builder SetTitle(ICharSequence title)
			{
				IntPtr intPtr = CharSequence.ToLocalJniHandle(title);
				AlertDialog.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<AlertDialog.Builder>(AlertDialog.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setTitle.(Ljava/lang/CharSequence;)Landroidx/appcompat/app/AlertDialog$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(title);
				}
				return @object;
			}

			// Token: 0x060001E9 RID: 489 RVA: 0x00005BAC File Offset: 0x00003DAC
			public AlertDialog.Builder SetTitle(string title)
			{
				Java.Lang.String @string = (title == null) ? null : new Java.Lang.String(title);
				AlertDialog.Builder result = this.SetTitle(@string);
				if (@string != null)
				{
					@string.Dispose();
				}
				return result;
			}

			// Token: 0x060001EA RID: 490 RVA: 0x00005BD6 File Offset: 0x00003DD6
			private static Delegate GetSetView_Landroid_view_View_Handler()
			{
				if (AlertDialog.Builder.cb_setView_Landroid_view_View_ == null)
				{
					AlertDialog.Builder.cb_setView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AlertDialog.Builder.n_SetView_Landroid_view_View_));
				}
				return AlertDialog.Builder.cb_setView_Landroid_view_View_;
			}

			// Token: 0x060001EB RID: 491 RVA: 0x00005BFC File Offset: 0x00003DFC
			private static IntPtr n_SetView_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_view)
			{
				AlertDialog.Builder @object = Java.Lang.Object.GetObject<AlertDialog.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				View object2 = Java.Lang.Object.GetObject<View>(native_view, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetView(object2));
			}

			// Token: 0x060001EC RID: 492 RVA: 0x00005C24 File Offset: 0x00003E24
			[Register("setView", "(Landroid/view/View;)Landroidx/appcompat/app/AlertDialog$Builder;", "GetSetView_Landroid_view_View_Handler")]
			public unsafe virtual AlertDialog.Builder SetView(View view)
			{
				AlertDialog.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
					@object = Java.Lang.Object.GetObject<AlertDialog.Builder>(AlertDialog.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setView.(Landroid/view/View;)Landroidx/appcompat/app/AlertDialog$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(view);
				}
				return @object;
			}

			// Token: 0x060001ED RID: 493 RVA: 0x00005C98 File Offset: 0x00003E98
			private static Delegate GetSetView_Landroid_view_View_IIIIHandler()
			{
				if (AlertDialog.Builder.cb_setView_Landroid_view_View_IIII == null)
				{
					AlertDialog.Builder.cb_setView_Landroid_view_View_IIII = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIIII_L(AlertDialog.Builder.n_SetView_Landroid_view_View_IIII));
				}
				return AlertDialog.Builder.cb_setView_Landroid_view_View_IIII;
			}

			// Token: 0x060001EE RID: 494 RVA: 0x00005CBC File Offset: 0x00003EBC
			private static IntPtr n_SetView_Landroid_view_View_IIII(IntPtr jnienv, IntPtr native__this, IntPtr native_view, int viewSpacingLeft, int viewSpacingTop, int viewSpacingRight, int viewSpacingBottom)
			{
				AlertDialog.Builder @object = Java.Lang.Object.GetObject<AlertDialog.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				View object2 = Java.Lang.Object.GetObject<View>(native_view, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetView(object2, viewSpacingLeft, viewSpacingTop, viewSpacingRight, viewSpacingBottom));
			}

			// Token: 0x060001EF RID: 495 RVA: 0x00005CEC File Offset: 0x00003EEC
			[Register("setView", "(Landroid/view/View;IIII)Landroidx/appcompat/app/AlertDialog$Builder;", "GetSetView_Landroid_view_View_IIIIHandler")]
			public unsafe virtual AlertDialog.Builder SetView(View view, int viewSpacingLeft, int viewSpacingTop, int viewSpacingRight, int viewSpacingBottom)
			{
				AlertDialog.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
					ptr[1] = new JniArgumentValue(viewSpacingLeft);
					ptr[2] = new JniArgumentValue(viewSpacingTop);
					ptr[3] = new JniArgumentValue(viewSpacingRight);
					ptr[4] = new JniArgumentValue(viewSpacingBottom);
					@object = Java.Lang.Object.GetObject<AlertDialog.Builder>(AlertDialog.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setView.(Landroid/view/View;IIII)Landroidx/appcompat/app/AlertDialog$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(view);
				}
				return @object;
			}

			// Token: 0x060001F0 RID: 496 RVA: 0x00005DB8 File Offset: 0x00003FB8
			private static Delegate GetSetView_IHandler()
			{
				if (AlertDialog.Builder.cb_setView_I == null)
				{
					AlertDialog.Builder.cb_setView_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(AlertDialog.Builder.n_SetView_I));
				}
				return AlertDialog.Builder.cb_setView_I;
			}

			// Token: 0x060001F1 RID: 497 RVA: 0x00005DDC File Offset: 0x00003FDC
			private static IntPtr n_SetView_I(IntPtr jnienv, IntPtr native__this, int layoutResId)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AlertDialog.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetView(layoutResId));
			}

			// Token: 0x060001F2 RID: 498 RVA: 0x00005DF4 File Offset: 0x00003FF4
			[Register("setView", "(I)Landroidx/appcompat/app/AlertDialog$Builder;", "GetSetView_IHandler")]
			public unsafe virtual AlertDialog.Builder SetView(int layoutResId)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(layoutResId);
				return Java.Lang.Object.GetObject<AlertDialog.Builder>(AlertDialog.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setView.(I)Landroidx/appcompat/app/AlertDialog$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x060001F3 RID: 499 RVA: 0x00005E3D File Offset: 0x0000403D
			private static Delegate GetShowHandler()
			{
				if (AlertDialog.Builder.cb_show == null)
				{
					AlertDialog.Builder.cb_show = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AlertDialog.Builder.n_Show));
				}
				return AlertDialog.Builder.cb_show;
			}

			// Token: 0x060001F4 RID: 500 RVA: 0x00005E61 File Offset: 0x00004061
			private static IntPtr n_Show(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AlertDialog.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Show());
			}

			// Token: 0x060001F5 RID: 501 RVA: 0x00005E78 File Offset: 0x00004078
			[Register("show", "()Landroidx/appcompat/app/AlertDialog;", "GetShowHandler")]
			public virtual AlertDialog Show()
			{
				return Java.Lang.Object.GetObject<AlertDialog>(AlertDialog.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("show.()Landroidx/appcompat/app/AlertDialog;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x04000028 RID: 40
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/appcompat/app/AlertDialog$Builder", typeof(AlertDialog.Builder));

			// Token: 0x04000029 RID: 41
			private static Delegate cb_getContext;

			// Token: 0x0400002A RID: 42
			private static Delegate cb_create;

			// Token: 0x0400002B RID: 43
			private static Delegate cb_setAdapter_Landroid_widget_ListAdapter_Landroid_content_DialogInterface_OnClickListener_;

			// Token: 0x0400002C RID: 44
			private static Delegate cb_setCancelable_Z;

			// Token: 0x0400002D RID: 45
			private static Delegate cb_setCursor_Landroid_database_Cursor_Landroid_content_DialogInterface_OnClickListener_Ljava_lang_String_;

			// Token: 0x0400002E RID: 46
			private static Delegate cb_setCustomTitle_Landroid_view_View_;

			// Token: 0x0400002F RID: 47
			private static Delegate cb_setIcon_Landroid_graphics_drawable_Drawable_;

			// Token: 0x04000030 RID: 48
			private static Delegate cb_setIcon_I;

			// Token: 0x04000031 RID: 49
			private static Delegate cb_setIconAttribute_I;

			// Token: 0x04000032 RID: 50
			private static Delegate cb_setInverseBackgroundForced_Z;

			// Token: 0x04000033 RID: 51
			private static Delegate cb_setItems_ILandroid_content_DialogInterface_OnClickListener_;

			// Token: 0x04000034 RID: 52
			private static Delegate cb_setItems_arrayLjava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_;

			// Token: 0x04000035 RID: 53
			private static Delegate cb_setMessage_I;

			// Token: 0x04000036 RID: 54
			private static Delegate cb_setMessage_Ljava_lang_CharSequence_;

			// Token: 0x04000037 RID: 55
			private static Delegate cb_setMultiChoiceItems_Landroid_database_Cursor_Ljava_lang_String_Ljava_lang_String_Landroid_content_DialogInterface_OnMultiChoiceClickListener_;

			// Token: 0x04000038 RID: 56
			private static Delegate cb_setMultiChoiceItems_IarrayZLandroid_content_DialogInterface_OnMultiChoiceClickListener_;

			// Token: 0x04000039 RID: 57
			private static Delegate cb_setMultiChoiceItems_arrayLjava_lang_CharSequence_arrayZLandroid_content_DialogInterface_OnMultiChoiceClickListener_;

			// Token: 0x0400003A RID: 58
			private static Delegate cb_setNegativeButton_ILandroid_content_DialogInterface_OnClickListener_;

			// Token: 0x0400003B RID: 59
			private static Delegate cb_setNegativeButton_Ljava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_;

			// Token: 0x0400003C RID: 60
			private static Delegate cb_setNegativeButtonIcon_Landroid_graphics_drawable_Drawable_;

			// Token: 0x0400003D RID: 61
			private static Delegate cb_setNeutralButton_ILandroid_content_DialogInterface_OnClickListener_;

			// Token: 0x0400003E RID: 62
			private static Delegate cb_setNeutralButton_Ljava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_;

			// Token: 0x0400003F RID: 63
			private static Delegate cb_setNeutralButtonIcon_Landroid_graphics_drawable_Drawable_;

			// Token: 0x04000040 RID: 64
			private static Delegate cb_setOnCancelListener_Landroid_content_DialogInterface_OnCancelListener_;

			// Token: 0x04000041 RID: 65
			private static Delegate cb_setOnDismissListener_Landroid_content_DialogInterface_OnDismissListener_;

			// Token: 0x04000042 RID: 66
			private static Delegate cb_setOnItemSelectedListener_Landroid_widget_AdapterView_OnItemSelectedListener_;

			// Token: 0x04000043 RID: 67
			private static Delegate cb_setOnKeyListener_Landroid_content_DialogInterface_OnKeyListener_;

			// Token: 0x04000044 RID: 68
			private static Delegate cb_setPositiveButton_ILandroid_content_DialogInterface_OnClickListener_;

			// Token: 0x04000045 RID: 69
			private static Delegate cb_setPositiveButton_Ljava_lang_CharSequence_Landroid_content_DialogInterface_OnClickListener_;

			// Token: 0x04000046 RID: 70
			private static Delegate cb_setPositiveButtonIcon_Landroid_graphics_drawable_Drawable_;

			// Token: 0x04000047 RID: 71
			private static Delegate cb_setRecycleOnMeasureEnabled_Z;

			// Token: 0x04000048 RID: 72
			private static Delegate cb_setSingleChoiceItems_Landroid_database_Cursor_ILjava_lang_String_Landroid_content_DialogInterface_OnClickListener_;

			// Token: 0x04000049 RID: 73
			private static Delegate cb_setSingleChoiceItems_Landroid_widget_ListAdapter_ILandroid_content_DialogInterface_OnClickListener_;

			// Token: 0x0400004A RID: 74
			private static Delegate cb_setSingleChoiceItems_IILandroid_content_DialogInterface_OnClickListener_;

			// Token: 0x0400004B RID: 75
			private static Delegate cb_setSingleChoiceItems_arrayLjava_lang_CharSequence_ILandroid_content_DialogInterface_OnClickListener_;

			// Token: 0x0400004C RID: 76
			private static Delegate cb_setTitle_I;

			// Token: 0x0400004D RID: 77
			private static Delegate cb_setTitle_Ljava_lang_CharSequence_;

			// Token: 0x0400004E RID: 78
			private static Delegate cb_setView_Landroid_view_View_;

			// Token: 0x0400004F RID: 79
			private static Delegate cb_setView_Landroid_view_View_IIII;

			// Token: 0x04000050 RID: 80
			private static Delegate cb_setView_I;

			// Token: 0x04000051 RID: 81
			private static Delegate cb_show;
		}

		// Token: 0x0200003C RID: 60
		private class IDialogInterfaceOnClickListenerImplementor : Java.Lang.Object, IDialogInterfaceOnClickListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x1700001A RID: 26
			// (get) Token: 0x060001F7 RID: 503 RVA: 0x00005EC5 File Offset: 0x000040C5
			// (set) Token: 0x060001F8 RID: 504 RVA: 0x00005ECD File Offset: 0x000040CD
			public EventHandler<DialogClickEventArgs> Handler { get; set; }

			// Token: 0x060001F9 RID: 505 RVA: 0x00005ED8 File Offset: 0x000040D8
			public void OnClick(IDialogInterface dialog, int which)
			{
				EventHandler<DialogClickEventArgs> handler = this.Handler;
				if (handler != null)
				{
					handler(dialog, new DialogClickEventArgs(which));
				}
			}
		}

		// Token: 0x0200003D RID: 61
		private class IDialogInterfaceOnCancelListenerImplementor : Java.Lang.Object, IDialogInterfaceOnCancelListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x1700001B RID: 27
			// (get) Token: 0x060001FB RID: 507 RVA: 0x00005F04 File Offset: 0x00004104
			// (set) Token: 0x060001FC RID: 508 RVA: 0x00005F0C File Offset: 0x0000410C
			public EventHandler Handler { get; set; }

			// Token: 0x060001FD RID: 509 RVA: 0x00005F18 File Offset: 0x00004118
			public void OnCancel(IDialogInterface dialog)
			{
				EventHandler handler = this.Handler;
				if (handler != null)
				{
					handler(dialog, new EventArgs());
				}
			}
		}

		// Token: 0x0200003E RID: 62
		private class IDialogInterfaceOnMultiChoiceClickListenerImplementor : Java.Lang.Object, IDialogInterfaceOnMultiChoiceClickListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x1700001C RID: 28
			// (get) Token: 0x060001FF RID: 511 RVA: 0x00005F3B File Offset: 0x0000413B
			// (set) Token: 0x06000200 RID: 512 RVA: 0x00005F43 File Offset: 0x00004143
			public EventHandler<DialogMultiChoiceClickEventArgs> Handler { get; set; }

			// Token: 0x06000201 RID: 513 RVA: 0x00005F4C File Offset: 0x0000414C
			public void OnClick(IDialogInterface dialog, int which, bool isChecked)
			{
				EventHandler<DialogMultiChoiceClickEventArgs> handler = this.Handler;
				if (handler != null)
				{
					handler(dialog, new DialogMultiChoiceClickEventArgs(which, isChecked));
				}
			}
		}
	}
}
