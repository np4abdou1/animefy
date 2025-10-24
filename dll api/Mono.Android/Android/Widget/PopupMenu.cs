using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Java.Interop;
using Java.Lang;

namespace Android.Widget
{
	// Token: 0x020000DF RID: 223
	[Register("android/widget/PopupMenu", DoNotGenerateAcw = true)]
	public class PopupMenu : Java.Lang.Object
	{
		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000508 RID: 1288 RVA: 0x0000A692 File Offset: 0x00008892
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return PopupMenu._members;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000509 RID: 1289 RVA: 0x0000A69C File Offset: 0x0000889C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return PopupMenu._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x0600050A RID: 1290 RVA: 0x0000A6C0 File Offset: 0x000088C0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return PopupMenu._members.ManagedPeerType;
			}
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x000021E0 File Offset: 0x000003E0
		protected PopupMenu(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x0000A6CC File Offset: 0x000088CC
		public unsafe PopupMenu(Context context, View anchor) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((anchor == null) ? IntPtr.Zero : anchor.Handle);
				base.SetHandle(PopupMenu._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/view/View;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				PopupMenu._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/view/View;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(anchor);
			}
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x0000A7A4 File Offset: 0x000089A4
		private static Delegate GetGetMenuHandler()
		{
			if (PopupMenu.cb_getMenu == null)
			{
				PopupMenu.cb_getMenu = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(PopupMenu.n_GetMenu));
			}
			return PopupMenu.cb_getMenu;
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x0000A7C8 File Offset: 0x000089C8
		private static IntPtr n_GetMenu(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<PopupMenu>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Menu);
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x0600050F RID: 1295 RVA: 0x0000A7DC File Offset: 0x000089DC
		public virtual IMenu Menu
		{
			get
			{
				return Java.Lang.Object.GetObject<IMenu>(PopupMenu._members.InstanceMethods.InvokeVirtualObjectMethod("getMenu.()Landroid/view/Menu;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x0000A80E File Offset: 0x00008A0E
		private static Delegate GetGetMenuInflaterHandler()
		{
			if (PopupMenu.cb_getMenuInflater == null)
			{
				PopupMenu.cb_getMenuInflater = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(PopupMenu.n_GetMenuInflater));
			}
			return PopupMenu.cb_getMenuInflater;
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x0000A832 File Offset: 0x00008A32
		private static IntPtr n_GetMenuInflater(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<PopupMenu>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MenuInflater);
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000512 RID: 1298 RVA: 0x0000A848 File Offset: 0x00008A48
		public virtual MenuInflater MenuInflater
		{
			get
			{
				return Java.Lang.Object.GetObject<MenuInflater>(PopupMenu._members.InstanceMethods.InvokeVirtualObjectMethod("getMenuInflater.()Landroid/view/MenuInflater;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x0000A87A File Offset: 0x00008A7A
		private static Delegate GetDismissHandler()
		{
			if (PopupMenu.cb_dismiss == null)
			{
				PopupMenu.cb_dismiss = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(PopupMenu.n_Dismiss));
			}
			return PopupMenu.cb_dismiss;
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x0000A89E File Offset: 0x00008A9E
		private static void n_Dismiss(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<PopupMenu>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Dismiss();
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x0000A8AD File Offset: 0x00008AAD
		public virtual void Dismiss()
		{
			PopupMenu._members.InstanceMethods.InvokeVirtualVoidMethod("dismiss.()V", this, null);
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x0000A8C6 File Offset: 0x00008AC6
		private static Delegate GetSetOnDismissListener_Landroid_widget_PopupMenu_OnDismissListener_Handler()
		{
			if (PopupMenu.cb_setOnDismissListener_Landroid_widget_PopupMenu_OnDismissListener_ == null)
			{
				PopupMenu.cb_setOnDismissListener_Landroid_widget_PopupMenu_OnDismissListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(PopupMenu.n_SetOnDismissListener_Landroid_widget_PopupMenu_OnDismissListener_));
			}
			return PopupMenu.cb_setOnDismissListener_Landroid_widget_PopupMenu_OnDismissListener_;
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x0000A8EC File Offset: 0x00008AEC
		private static void n_SetOnDismissListener_Landroid_widget_PopupMenu_OnDismissListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			PopupMenu @object = Java.Lang.Object.GetObject<PopupMenu>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			PopupMenu.IOnDismissListener object2 = Java.Lang.Object.GetObject<PopupMenu.IOnDismissListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.SetOnDismissListener(object2);
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x0000A910 File Offset: 0x00008B10
		public unsafe virtual void SetOnDismissListener(PopupMenu.IOnDismissListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				PopupMenu._members.InstanceMethods.InvokeVirtualVoidMethod("setOnDismissListener.(Landroid/widget/PopupMenu$OnDismissListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x0000A978 File Offset: 0x00008B78
		private static Delegate GetSetOnMenuItemClickListener_Landroid_widget_PopupMenu_OnMenuItemClickListener_Handler()
		{
			if (PopupMenu.cb_setOnMenuItemClickListener_Landroid_widget_PopupMenu_OnMenuItemClickListener_ == null)
			{
				PopupMenu.cb_setOnMenuItemClickListener_Landroid_widget_PopupMenu_OnMenuItemClickListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(PopupMenu.n_SetOnMenuItemClickListener_Landroid_widget_PopupMenu_OnMenuItemClickListener_));
			}
			return PopupMenu.cb_setOnMenuItemClickListener_Landroid_widget_PopupMenu_OnMenuItemClickListener_;
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x0000A99C File Offset: 0x00008B9C
		private static void n_SetOnMenuItemClickListener_Landroid_widget_PopupMenu_OnMenuItemClickListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			PopupMenu @object = Java.Lang.Object.GetObject<PopupMenu>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			PopupMenu.IOnMenuItemClickListener object2 = Java.Lang.Object.GetObject<PopupMenu.IOnMenuItemClickListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.SetOnMenuItemClickListener(object2);
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x0000A9C0 File Offset: 0x00008BC0
		public unsafe virtual void SetOnMenuItemClickListener(PopupMenu.IOnMenuItemClickListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				PopupMenu._members.InstanceMethods.InvokeVirtualVoidMethod("setOnMenuItemClickListener.(Landroid/widget/PopupMenu$OnMenuItemClickListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x0000AA28 File Offset: 0x00008C28
		private static Delegate GetShowHandler()
		{
			if (PopupMenu.cb_show == null)
			{
				PopupMenu.cb_show = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(PopupMenu.n_Show));
			}
			return PopupMenu.cb_show;
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x0000AA4C File Offset: 0x00008C4C
		private static void n_Show(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<PopupMenu>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Show();
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x0000AA5B File Offset: 0x00008C5B
		public virtual void Show()
		{
			PopupMenu._members.InstanceMethods.InvokeVirtualVoidMethod("show.()V", this, null);
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x0600051F RID: 1311 RVA: 0x0000AA74 File Offset: 0x00008C74
		// (remove) Token: 0x06000520 RID: 1312 RVA: 0x0000AAC0 File Offset: 0x00008CC0
		public event EventHandler<PopupMenu.DismissEventArgs> DismissEvent
		{
			add
			{
				EventHelper.AddEventHandler<PopupMenu.IOnDismissListener, PopupMenu.IOnDismissListenerImplementor>(ref this.weak_implementor_SetOnDismissListener, new Func<PopupMenu.IOnDismissListenerImplementor>(this.__CreateIOnDismissListenerImplementor), new Action<PopupMenu.IOnDismissListener>(this.SetOnDismissListener), delegate(PopupMenu.IOnDismissListenerImplementor __h)
				{
					__h.Handler = (EventHandler<PopupMenu.DismissEventArgs>)Delegate.Combine(__h.Handler, value);
				});
			}
			remove
			{
				Func<PopupMenu.IOnDismissListenerImplementor, bool> empty;
				if ((empty = PopupMenu.<>O.<0>____IsEmpty) == null)
				{
					empty = (PopupMenu.<>O.<0>____IsEmpty = new Func<PopupMenu.IOnDismissListenerImplementor, bool>(PopupMenu.IOnDismissListenerImplementor.__IsEmpty));
				}
				EventHelper.RemoveEventHandler<PopupMenu.IOnDismissListener, PopupMenu.IOnDismissListenerImplementor>(ref this.weak_implementor_SetOnDismissListener, empty, delegate(PopupMenu.IOnDismissListener __v)
				{
					this.SetOnDismissListener(null);
				}, delegate(PopupMenu.IOnDismissListenerImplementor __h)
				{
					__h.Handler = (EventHandler<PopupMenu.DismissEventArgs>)Delegate.Remove(__h.Handler, value);
				});
			}
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x0000AB1F File Offset: 0x00008D1F
		private PopupMenu.IOnDismissListenerImplementor __CreateIOnDismissListenerImplementor()
		{
			return new PopupMenu.IOnDismissListenerImplementor(this);
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000522 RID: 1314 RVA: 0x0000AB28 File Offset: 0x00008D28
		// (remove) Token: 0x06000523 RID: 1315 RVA: 0x0000AB74 File Offset: 0x00008D74
		public event EventHandler<PopupMenu.MenuItemClickEventArgs> MenuItemClick
		{
			add
			{
				EventHelper.AddEventHandler<PopupMenu.IOnMenuItemClickListener, PopupMenu.IOnMenuItemClickListenerImplementor>(ref this.weak_implementor_SetOnMenuItemClickListener, new Func<PopupMenu.IOnMenuItemClickListenerImplementor>(this.__CreateIOnMenuItemClickListenerImplementor), new Action<PopupMenu.IOnMenuItemClickListener>(this.SetOnMenuItemClickListener), delegate(PopupMenu.IOnMenuItemClickListenerImplementor __h)
				{
					__h.Handler = (EventHandler<PopupMenu.MenuItemClickEventArgs>)Delegate.Combine(__h.Handler, value);
				});
			}
			remove
			{
				Func<PopupMenu.IOnMenuItemClickListenerImplementor, bool> empty;
				if ((empty = PopupMenu.<>O.<1>____IsEmpty) == null)
				{
					empty = (PopupMenu.<>O.<1>____IsEmpty = new Func<PopupMenu.IOnMenuItemClickListenerImplementor, bool>(PopupMenu.IOnMenuItemClickListenerImplementor.__IsEmpty));
				}
				EventHelper.RemoveEventHandler<PopupMenu.IOnMenuItemClickListener, PopupMenu.IOnMenuItemClickListenerImplementor>(ref this.weak_implementor_SetOnMenuItemClickListener, empty, delegate(PopupMenu.IOnMenuItemClickListener __v)
				{
					this.SetOnMenuItemClickListener(null);
				}, delegate(PopupMenu.IOnMenuItemClickListenerImplementor __h)
				{
					__h.Handler = (EventHandler<PopupMenu.MenuItemClickEventArgs>)Delegate.Remove(__h.Handler, value);
				});
			}
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x0000ABD3 File Offset: 0x00008DD3
		private PopupMenu.IOnMenuItemClickListenerImplementor __CreateIOnMenuItemClickListenerImplementor()
		{
			return new PopupMenu.IOnMenuItemClickListenerImplementor(this);
		}

		// Token: 0x04000124 RID: 292
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/widget/PopupMenu", typeof(PopupMenu));

		// Token: 0x04000125 RID: 293
		private static Delegate cb_getMenu;

		// Token: 0x04000126 RID: 294
		private static Delegate cb_getMenuInflater;

		// Token: 0x04000127 RID: 295
		private static Delegate cb_dismiss;

		// Token: 0x04000128 RID: 296
		private static Delegate cb_setOnDismissListener_Landroid_widget_PopupMenu_OnDismissListener_;

		// Token: 0x04000129 RID: 297
		private static Delegate cb_setOnMenuItemClickListener_Landroid_widget_PopupMenu_OnMenuItemClickListener_;

		// Token: 0x0400012A RID: 298
		private static Delegate cb_show;

		// Token: 0x0400012B RID: 299
		private WeakReference weak_implementor_SetOnDismissListener;

		// Token: 0x0400012C RID: 300
		private WeakReference weak_implementor_SetOnMenuItemClickListener;

		// Token: 0x020000E0 RID: 224
		[Register("android/widget/PopupMenu$OnDismissListener", "", "Android.Widget.PopupMenu/IOnDismissListenerInvoker")]
		public interface IOnDismissListener : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06000526 RID: 1318
			[Register("onDismiss", "(Landroid/widget/PopupMenu;)V", "GetOnDismiss_Landroid_widget_PopupMenu_Handler:Android.Widget.PopupMenu/IOnDismissListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			void OnDismiss(PopupMenu menu);
		}

		// Token: 0x020000E1 RID: 225
		[Register("android/widget/PopupMenu$OnDismissListener", DoNotGenerateAcw = true)]
		internal class IOnDismissListenerInvoker : Java.Lang.Object, PopupMenu.IOnDismissListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x170000DC RID: 220
			// (get) Token: 0x06000527 RID: 1319 RVA: 0x0000ABF8 File Offset: 0x00008DF8
			private static IntPtr java_class_ref
			{
				get
				{
					return PopupMenu.IOnDismissListenerInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000DD RID: 221
			// (get) Token: 0x06000528 RID: 1320 RVA: 0x0000AC1C File Offset: 0x00008E1C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return PopupMenu.IOnDismissListenerInvoker._members;
				}
			}

			// Token: 0x170000DE RID: 222
			// (get) Token: 0x06000529 RID: 1321 RVA: 0x0000AC23 File Offset: 0x00008E23
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x170000DF RID: 223
			// (get) Token: 0x0600052A RID: 1322 RVA: 0x0000AC2B File Offset: 0x00008E2B
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return PopupMenu.IOnDismissListenerInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x0600052B RID: 1323 RVA: 0x0000AC37 File Offset: 0x00008E37
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, PopupMenu.IOnDismissListenerInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.widget.PopupMenu.OnDismissListener'.");
				}
				return handle;
			}

			// Token: 0x0600052C RID: 1324 RVA: 0x0000AC62 File Offset: 0x00008E62
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x0600052D RID: 1325 RVA: 0x0000AC94 File Offset: 0x00008E94
			public IOnDismissListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(PopupMenu.IOnDismissListenerInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x0600052E RID: 1326 RVA: 0x0000ACCC File Offset: 0x00008ECC
			private static Delegate GetOnDismiss_Landroid_widget_PopupMenu_Handler()
			{
				if (PopupMenu.IOnDismissListenerInvoker.cb_onDismiss_Landroid_widget_PopupMenu_ == null)
				{
					PopupMenu.IOnDismissListenerInvoker.cb_onDismiss_Landroid_widget_PopupMenu_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(PopupMenu.IOnDismissListenerInvoker.n_OnDismiss_Landroid_widget_PopupMenu_));
				}
				return PopupMenu.IOnDismissListenerInvoker.cb_onDismiss_Landroid_widget_PopupMenu_;
			}

			// Token: 0x0600052F RID: 1327 RVA: 0x0000ACF0 File Offset: 0x00008EF0
			private static void n_OnDismiss_Landroid_widget_PopupMenu_(IntPtr jnienv, IntPtr native__this, IntPtr native_menu)
			{
				PopupMenu.IOnDismissListener @object = Java.Lang.Object.GetObject<PopupMenu.IOnDismissListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				PopupMenu object2 = Java.Lang.Object.GetObject<PopupMenu>(native_menu, JniHandleOwnership.DoNotTransfer);
				@object.OnDismiss(object2);
			}

			// Token: 0x06000530 RID: 1328 RVA: 0x0000AD14 File Offset: 0x00008F14
			public unsafe void OnDismiss(PopupMenu menu)
			{
				if (this.id_onDismiss_Landroid_widget_PopupMenu_ == IntPtr.Zero)
				{
					this.id_onDismiss_Landroid_widget_PopupMenu_ = JNIEnv.GetMethodID(this.class_ref, "onDismiss", "(Landroid/widget/PopupMenu;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((menu == null) ? IntPtr.Zero : menu.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onDismiss_Landroid_widget_PopupMenu_, ptr);
			}

			// Token: 0x0400012D RID: 301
			private static readonly JniPeerMembers _members = new XAPeerMembers("android/widget/PopupMenu$OnDismissListener", typeof(PopupMenu.IOnDismissListenerInvoker));

			// Token: 0x0400012E RID: 302
			private IntPtr class_ref;

			// Token: 0x0400012F RID: 303
			private static Delegate cb_onDismiss_Landroid_widget_PopupMenu_;

			// Token: 0x04000130 RID: 304
			private IntPtr id_onDismiss_Landroid_widget_PopupMenu_;
		}

		// Token: 0x020000E2 RID: 226
		public class DismissEventArgs : EventArgs
		{
			// Token: 0x06000532 RID: 1330 RVA: 0x0000ADA2 File Offset: 0x00008FA2
			public DismissEventArgs(PopupMenu menu)
			{
				this.menu = menu;
			}

			// Token: 0x04000131 RID: 305
			private PopupMenu menu;
		}

		// Token: 0x020000E3 RID: 227
		[Register("mono/android/widget/PopupMenu_OnDismissListenerImplementor")]
		internal sealed class IOnDismissListenerImplementor : Java.Lang.Object, PopupMenu.IOnDismissListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06000533 RID: 1331 RVA: 0x0000ADB1 File Offset: 0x00008FB1
			public IOnDismissListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/android/widget/PopupMenu_OnDismissListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
			{
				JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
				this.sender = sender;
			}

			// Token: 0x06000534 RID: 1332 RVA: 0x0000ADEC File Offset: 0x00008FEC
			public void OnDismiss(PopupMenu menu)
			{
				EventHandler<PopupMenu.DismissEventArgs> handler = this.Handler;
				if (handler != null)
				{
					handler(this.sender, new PopupMenu.DismissEventArgs(menu));
				}
			}

			// Token: 0x06000535 RID: 1333 RVA: 0x0000AE15 File Offset: 0x00009015
			internal static bool __IsEmpty(PopupMenu.IOnDismissListenerImplementor value)
			{
				return value.Handler == null;
			}

			// Token: 0x04000132 RID: 306
			private object sender;

			// Token: 0x04000133 RID: 307
			public EventHandler<PopupMenu.DismissEventArgs> Handler;
		}

		// Token: 0x020000E4 RID: 228
		[Register("android/widget/PopupMenu$OnMenuItemClickListener", "", "Android.Widget.PopupMenu/IOnMenuItemClickListenerInvoker")]
		public interface IOnMenuItemClickListener : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06000536 RID: 1334
			[Register("onMenuItemClick", "(Landroid/view/MenuItem;)Z", "GetOnMenuItemClick_Landroid_view_MenuItem_Handler:Android.Widget.PopupMenu/IOnMenuItemClickListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			bool OnMenuItemClick(IMenuItem item);
		}

		// Token: 0x020000E5 RID: 229
		[Register("android/widget/PopupMenu$OnMenuItemClickListener", DoNotGenerateAcw = true)]
		internal class IOnMenuItemClickListenerInvoker : Java.Lang.Object, PopupMenu.IOnMenuItemClickListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x170000E0 RID: 224
			// (get) Token: 0x06000537 RID: 1335 RVA: 0x0000AE20 File Offset: 0x00009020
			private static IntPtr java_class_ref
			{
				get
				{
					return PopupMenu.IOnMenuItemClickListenerInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000E1 RID: 225
			// (get) Token: 0x06000538 RID: 1336 RVA: 0x0000AE44 File Offset: 0x00009044
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return PopupMenu.IOnMenuItemClickListenerInvoker._members;
				}
			}

			// Token: 0x170000E2 RID: 226
			// (get) Token: 0x06000539 RID: 1337 RVA: 0x0000AE4B File Offset: 0x0000904B
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x170000E3 RID: 227
			// (get) Token: 0x0600053A RID: 1338 RVA: 0x0000AE53 File Offset: 0x00009053
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return PopupMenu.IOnMenuItemClickListenerInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x0600053B RID: 1339 RVA: 0x0000AE5F File Offset: 0x0000905F
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, PopupMenu.IOnMenuItemClickListenerInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.widget.PopupMenu.OnMenuItemClickListener'.");
				}
				return handle;
			}

			// Token: 0x0600053C RID: 1340 RVA: 0x0000AE8A File Offset: 0x0000908A
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x0600053D RID: 1341 RVA: 0x0000AEBC File Offset: 0x000090BC
			public IOnMenuItemClickListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(PopupMenu.IOnMenuItemClickListenerInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x0600053E RID: 1342 RVA: 0x0000AEF4 File Offset: 0x000090F4
			private static Delegate GetOnMenuItemClick_Landroid_view_MenuItem_Handler()
			{
				if (PopupMenu.IOnMenuItemClickListenerInvoker.cb_onMenuItemClick_Landroid_view_MenuItem_ == null)
				{
					PopupMenu.IOnMenuItemClickListenerInvoker.cb_onMenuItemClick_Landroid_view_MenuItem_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(PopupMenu.IOnMenuItemClickListenerInvoker.n_OnMenuItemClick_Landroid_view_MenuItem_));
				}
				return PopupMenu.IOnMenuItemClickListenerInvoker.cb_onMenuItemClick_Landroid_view_MenuItem_;
			}

			// Token: 0x0600053F RID: 1343 RVA: 0x0000AF18 File Offset: 0x00009118
			private static bool n_OnMenuItemClick_Landroid_view_MenuItem_(IntPtr jnienv, IntPtr native__this, IntPtr native_item)
			{
				PopupMenu.IOnMenuItemClickListener @object = Java.Lang.Object.GetObject<PopupMenu.IOnMenuItemClickListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				IMenuItem object2 = Java.Lang.Object.GetObject<IMenuItem>(native_item, JniHandleOwnership.DoNotTransfer);
				return @object.OnMenuItemClick(object2);
			}

			// Token: 0x06000540 RID: 1344 RVA: 0x0000AF3C File Offset: 0x0000913C
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

			// Token: 0x04000134 RID: 308
			private static readonly JniPeerMembers _members = new XAPeerMembers("android/widget/PopupMenu$OnMenuItemClickListener", typeof(PopupMenu.IOnMenuItemClickListenerInvoker));

			// Token: 0x04000135 RID: 309
			private IntPtr class_ref;

			// Token: 0x04000136 RID: 310
			private static Delegate cb_onMenuItemClick_Landroid_view_MenuItem_;

			// Token: 0x04000137 RID: 311
			private IntPtr id_onMenuItemClick_Landroid_view_MenuItem_;
		}

		// Token: 0x020000E6 RID: 230
		public class MenuItemClickEventArgs : EventArgs
		{
			// Token: 0x170000E4 RID: 228
			// (get) Token: 0x06000542 RID: 1346 RVA: 0x0000AFCF File Offset: 0x000091CF
			public bool Handled
			{
				get
				{
					return this.handled;
				}
			}

			// Token: 0x06000543 RID: 1347 RVA: 0x0000AFD7 File Offset: 0x000091D7
			public MenuItemClickEventArgs(bool handled, IMenuItem item)
			{
				this.handled = handled;
				this.item = item;
			}

			// Token: 0x170000E5 RID: 229
			// (get) Token: 0x06000544 RID: 1348 RVA: 0x0000AFED File Offset: 0x000091ED
			public IMenuItem Item
			{
				get
				{
					return this.item;
				}
			}

			// Token: 0x04000138 RID: 312
			private bool handled;

			// Token: 0x04000139 RID: 313
			private IMenuItem item;
		}

		// Token: 0x020000E7 RID: 231
		[Register("mono/android/widget/PopupMenu_OnMenuItemClickListenerImplementor")]
		internal sealed class IOnMenuItemClickListenerImplementor : Java.Lang.Object, PopupMenu.IOnMenuItemClickListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06000545 RID: 1349 RVA: 0x0000AFF5 File Offset: 0x000091F5
			public IOnMenuItemClickListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/android/widget/PopupMenu_OnMenuItemClickListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
			{
				JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
				this.sender = sender;
			}

			// Token: 0x06000546 RID: 1350 RVA: 0x0000B030 File Offset: 0x00009230
			public bool OnMenuItemClick(IMenuItem item)
			{
				EventHandler<PopupMenu.MenuItemClickEventArgs> handler = this.Handler;
				if (handler == null)
				{
					return false;
				}
				PopupMenu.MenuItemClickEventArgs menuItemClickEventArgs = new PopupMenu.MenuItemClickEventArgs(true, item);
				handler(this.sender, menuItemClickEventArgs);
				return menuItemClickEventArgs.Handled;
			}

			// Token: 0x06000547 RID: 1351 RVA: 0x0000B064 File Offset: 0x00009264
			internal static bool __IsEmpty(PopupMenu.IOnMenuItemClickListenerImplementor value)
			{
				return value.Handler == null;
			}

			// Token: 0x0400013A RID: 314
			private object sender;

			// Token: 0x0400013B RID: 315
			public EventHandler<PopupMenu.MenuItemClickEventArgs> Handler;
		}

		// Token: 0x020000E8 RID: 232
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400013C RID: 316
			public static Func<PopupMenu.IOnDismissListenerImplementor, bool> <0>____IsEmpty;

			// Token: 0x0400013D RID: 317
			public static Func<PopupMenu.IOnMenuItemClickListenerImplementor, bool> <1>____IsEmpty;
		}
	}
}
