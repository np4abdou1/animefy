using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Views
{
	// Token: 0x0200010D RID: 269
	[Register("android/view/ActionMode", DoNotGenerateAcw = true)]
	public abstract class ActionMode : Java.Lang.Object
	{
		// Token: 0x17000155 RID: 341
		// (get) Token: 0x060006E1 RID: 1761 RVA: 0x0000FB63 File Offset: 0x0000DD63
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ActionMode._members;
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x060006E2 RID: 1762 RVA: 0x0000FB6C File Offset: 0x0000DD6C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ActionMode._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x060006E3 RID: 1763 RVA: 0x0000FB90 File Offset: 0x0000DD90
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ActionMode._members.ManagedPeerType;
			}
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x000021E0 File Offset: 0x000003E0
		protected ActionMode(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x040001C6 RID: 454
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/view/ActionMode", typeof(ActionMode));

		// Token: 0x0200010E RID: 270
		[Register("android/view/ActionMode$Callback", "", "Android.Views.ActionMode/ICallbackInvoker")]
		public interface ICallback : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x060006E6 RID: 1766
			[Register("onActionItemClicked", "(Landroid/view/ActionMode;Landroid/view/MenuItem;)Z", "GetOnActionItemClicked_Landroid_view_ActionMode_Landroid_view_MenuItem_Handler:Android.Views.ActionMode/ICallbackInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			bool OnActionItemClicked(ActionMode mode, IMenuItem item);

			// Token: 0x060006E7 RID: 1767
			[Register("onCreateActionMode", "(Landroid/view/ActionMode;Landroid/view/Menu;)Z", "GetOnCreateActionMode_Landroid_view_ActionMode_Landroid_view_Menu_Handler:Android.Views.ActionMode/ICallbackInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			bool OnCreateActionMode(ActionMode mode, IMenu menu);

			// Token: 0x060006E8 RID: 1768
			[Register("onDestroyActionMode", "(Landroid/view/ActionMode;)V", "GetOnDestroyActionMode_Landroid_view_ActionMode_Handler:Android.Views.ActionMode/ICallbackInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			void OnDestroyActionMode(ActionMode mode);

			// Token: 0x060006E9 RID: 1769
			[Register("onPrepareActionMode", "(Landroid/view/ActionMode;Landroid/view/Menu;)Z", "GetOnPrepareActionMode_Landroid_view_ActionMode_Landroid_view_Menu_Handler:Android.Views.ActionMode/ICallbackInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			bool OnPrepareActionMode(ActionMode mode, IMenu menu);
		}

		// Token: 0x0200010F RID: 271
		[Register("android/view/ActionMode$Callback", DoNotGenerateAcw = true)]
		internal class ICallbackInvoker : Java.Lang.Object, ActionMode.ICallback, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000158 RID: 344
			// (get) Token: 0x060006EA RID: 1770 RVA: 0x0000FBB8 File Offset: 0x0000DDB8
			private static IntPtr java_class_ref
			{
				get
				{
					return ActionMode.ICallbackInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000159 RID: 345
			// (get) Token: 0x060006EB RID: 1771 RVA: 0x0000FBDC File Offset: 0x0000DDDC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ActionMode.ICallbackInvoker._members;
				}
			}

			// Token: 0x1700015A RID: 346
			// (get) Token: 0x060006EC RID: 1772 RVA: 0x0000FBE3 File Offset: 0x0000DDE3
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x1700015B RID: 347
			// (get) Token: 0x060006ED RID: 1773 RVA: 0x0000FBEB File Offset: 0x0000DDEB
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ActionMode.ICallbackInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x060006EE RID: 1774 RVA: 0x0000FBF7 File Offset: 0x0000DDF7
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, ActionMode.ICallbackInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.view.ActionMode.Callback'.");
				}
				return handle;
			}

			// Token: 0x060006EF RID: 1775 RVA: 0x0000FC22 File Offset: 0x0000DE22
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x060006F0 RID: 1776 RVA: 0x0000FC54 File Offset: 0x0000DE54
			public ICallbackInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ActionMode.ICallbackInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x060006F1 RID: 1777 RVA: 0x0000FC8C File Offset: 0x0000DE8C
			private static Delegate GetOnActionItemClicked_Landroid_view_ActionMode_Landroid_view_MenuItem_Handler()
			{
				if (ActionMode.ICallbackInvoker.cb_onActionItemClicked_Landroid_view_ActionMode_Landroid_view_MenuItem_ == null)
				{
					ActionMode.ICallbackInvoker.cb_onActionItemClicked_Landroid_view_ActionMode_Landroid_view_MenuItem_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_Z(ActionMode.ICallbackInvoker.n_OnActionItemClicked_Landroid_view_ActionMode_Landroid_view_MenuItem_));
				}
				return ActionMode.ICallbackInvoker.cb_onActionItemClicked_Landroid_view_ActionMode_Landroid_view_MenuItem_;
			}

			// Token: 0x060006F2 RID: 1778 RVA: 0x0000FCB0 File Offset: 0x0000DEB0
			private static bool n_OnActionItemClicked_Landroid_view_ActionMode_Landroid_view_MenuItem_(IntPtr jnienv, IntPtr native__this, IntPtr native_mode, IntPtr native_item)
			{
				ActionMode.ICallback @object = Java.Lang.Object.GetObject<ActionMode.ICallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				ActionMode object2 = Java.Lang.Object.GetObject<ActionMode>(native_mode, JniHandleOwnership.DoNotTransfer);
				IMenuItem object3 = Java.Lang.Object.GetObject<IMenuItem>(native_item, JniHandleOwnership.DoNotTransfer);
				return @object.OnActionItemClicked(object2, object3);
			}

			// Token: 0x060006F3 RID: 1779 RVA: 0x0000FCDC File Offset: 0x0000DEDC
			public unsafe bool OnActionItemClicked(ActionMode mode, IMenuItem item)
			{
				if (this.id_onActionItemClicked_Landroid_view_ActionMode_Landroid_view_MenuItem_ == IntPtr.Zero)
				{
					this.id_onActionItemClicked_Landroid_view_ActionMode_Landroid_view_MenuItem_ = JNIEnv.GetMethodID(this.class_ref, "onActionItemClicked", "(Landroid/view/ActionMode;Landroid/view/MenuItem;)Z");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((mode == null) ? IntPtr.Zero : mode.Handle);
				ptr[1] = new JValue((item == null) ? IntPtr.Zero : ((Java.Lang.Object)item).Handle);
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_onActionItemClicked_Landroid_view_ActionMode_Landroid_view_MenuItem_, ptr);
			}

			// Token: 0x060006F4 RID: 1780 RVA: 0x0000FD76 File Offset: 0x0000DF76
			private static Delegate GetOnCreateActionMode_Landroid_view_ActionMode_Landroid_view_Menu_Handler()
			{
				if (ActionMode.ICallbackInvoker.cb_onCreateActionMode_Landroid_view_ActionMode_Landroid_view_Menu_ == null)
				{
					ActionMode.ICallbackInvoker.cb_onCreateActionMode_Landroid_view_ActionMode_Landroid_view_Menu_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_Z(ActionMode.ICallbackInvoker.n_OnCreateActionMode_Landroid_view_ActionMode_Landroid_view_Menu_));
				}
				return ActionMode.ICallbackInvoker.cb_onCreateActionMode_Landroid_view_ActionMode_Landroid_view_Menu_;
			}

			// Token: 0x060006F5 RID: 1781 RVA: 0x0000FD9C File Offset: 0x0000DF9C
			private static bool n_OnCreateActionMode_Landroid_view_ActionMode_Landroid_view_Menu_(IntPtr jnienv, IntPtr native__this, IntPtr native_mode, IntPtr native_menu)
			{
				ActionMode.ICallback @object = Java.Lang.Object.GetObject<ActionMode.ICallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				ActionMode object2 = Java.Lang.Object.GetObject<ActionMode>(native_mode, JniHandleOwnership.DoNotTransfer);
				IMenu object3 = Java.Lang.Object.GetObject<IMenu>(native_menu, JniHandleOwnership.DoNotTransfer);
				return @object.OnCreateActionMode(object2, object3);
			}

			// Token: 0x060006F6 RID: 1782 RVA: 0x0000FDC8 File Offset: 0x0000DFC8
			public unsafe bool OnCreateActionMode(ActionMode mode, IMenu menu)
			{
				if (this.id_onCreateActionMode_Landroid_view_ActionMode_Landroid_view_Menu_ == IntPtr.Zero)
				{
					this.id_onCreateActionMode_Landroid_view_ActionMode_Landroid_view_Menu_ = JNIEnv.GetMethodID(this.class_ref, "onCreateActionMode", "(Landroid/view/ActionMode;Landroid/view/Menu;)Z");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((mode == null) ? IntPtr.Zero : mode.Handle);
				ptr[1] = new JValue((menu == null) ? IntPtr.Zero : ((Java.Lang.Object)menu).Handle);
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_onCreateActionMode_Landroid_view_ActionMode_Landroid_view_Menu_, ptr);
			}

			// Token: 0x060006F7 RID: 1783 RVA: 0x0000FE62 File Offset: 0x0000E062
			private static Delegate GetOnDestroyActionMode_Landroid_view_ActionMode_Handler()
			{
				if (ActionMode.ICallbackInvoker.cb_onDestroyActionMode_Landroid_view_ActionMode_ == null)
				{
					ActionMode.ICallbackInvoker.cb_onDestroyActionMode_Landroid_view_ActionMode_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ActionMode.ICallbackInvoker.n_OnDestroyActionMode_Landroid_view_ActionMode_));
				}
				return ActionMode.ICallbackInvoker.cb_onDestroyActionMode_Landroid_view_ActionMode_;
			}

			// Token: 0x060006F8 RID: 1784 RVA: 0x0000FE88 File Offset: 0x0000E088
			private static void n_OnDestroyActionMode_Landroid_view_ActionMode_(IntPtr jnienv, IntPtr native__this, IntPtr native_mode)
			{
				ActionMode.ICallback @object = Java.Lang.Object.GetObject<ActionMode.ICallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				ActionMode object2 = Java.Lang.Object.GetObject<ActionMode>(native_mode, JniHandleOwnership.DoNotTransfer);
				@object.OnDestroyActionMode(object2);
			}

			// Token: 0x060006F9 RID: 1785 RVA: 0x0000FEAC File Offset: 0x0000E0AC
			public unsafe void OnDestroyActionMode(ActionMode mode)
			{
				if (this.id_onDestroyActionMode_Landroid_view_ActionMode_ == IntPtr.Zero)
				{
					this.id_onDestroyActionMode_Landroid_view_ActionMode_ = JNIEnv.GetMethodID(this.class_ref, "onDestroyActionMode", "(Landroid/view/ActionMode;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((mode == null) ? IntPtr.Zero : mode.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onDestroyActionMode_Landroid_view_ActionMode_, ptr);
			}

			// Token: 0x060006FA RID: 1786 RVA: 0x0000FF1F File Offset: 0x0000E11F
			private static Delegate GetOnPrepareActionMode_Landroid_view_ActionMode_Landroid_view_Menu_Handler()
			{
				if (ActionMode.ICallbackInvoker.cb_onPrepareActionMode_Landroid_view_ActionMode_Landroid_view_Menu_ == null)
				{
					ActionMode.ICallbackInvoker.cb_onPrepareActionMode_Landroid_view_ActionMode_Landroid_view_Menu_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_Z(ActionMode.ICallbackInvoker.n_OnPrepareActionMode_Landroid_view_ActionMode_Landroid_view_Menu_));
				}
				return ActionMode.ICallbackInvoker.cb_onPrepareActionMode_Landroid_view_ActionMode_Landroid_view_Menu_;
			}

			// Token: 0x060006FB RID: 1787 RVA: 0x0000FF44 File Offset: 0x0000E144
			private static bool n_OnPrepareActionMode_Landroid_view_ActionMode_Landroid_view_Menu_(IntPtr jnienv, IntPtr native__this, IntPtr native_mode, IntPtr native_menu)
			{
				ActionMode.ICallback @object = Java.Lang.Object.GetObject<ActionMode.ICallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				ActionMode object2 = Java.Lang.Object.GetObject<ActionMode>(native_mode, JniHandleOwnership.DoNotTransfer);
				IMenu object3 = Java.Lang.Object.GetObject<IMenu>(native_menu, JniHandleOwnership.DoNotTransfer);
				return @object.OnPrepareActionMode(object2, object3);
			}

			// Token: 0x060006FC RID: 1788 RVA: 0x0000FF70 File Offset: 0x0000E170
			public unsafe bool OnPrepareActionMode(ActionMode mode, IMenu menu)
			{
				if (this.id_onPrepareActionMode_Landroid_view_ActionMode_Landroid_view_Menu_ == IntPtr.Zero)
				{
					this.id_onPrepareActionMode_Landroid_view_ActionMode_Landroid_view_Menu_ = JNIEnv.GetMethodID(this.class_ref, "onPrepareActionMode", "(Landroid/view/ActionMode;Landroid/view/Menu;)Z");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((mode == null) ? IntPtr.Zero : mode.Handle);
				ptr[1] = new JValue((menu == null) ? IntPtr.Zero : ((Java.Lang.Object)menu).Handle);
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_onPrepareActionMode_Landroid_view_ActionMode_Landroid_view_Menu_, ptr);
			}

			// Token: 0x040001C7 RID: 455
			private static readonly JniPeerMembers _members = new XAPeerMembers("android/view/ActionMode$Callback", typeof(ActionMode.ICallbackInvoker));

			// Token: 0x040001C8 RID: 456
			private IntPtr class_ref;

			// Token: 0x040001C9 RID: 457
			private static Delegate cb_onActionItemClicked_Landroid_view_ActionMode_Landroid_view_MenuItem_;

			// Token: 0x040001CA RID: 458
			private IntPtr id_onActionItemClicked_Landroid_view_ActionMode_Landroid_view_MenuItem_;

			// Token: 0x040001CB RID: 459
			private static Delegate cb_onCreateActionMode_Landroid_view_ActionMode_Landroid_view_Menu_;

			// Token: 0x040001CC RID: 460
			private IntPtr id_onCreateActionMode_Landroid_view_ActionMode_Landroid_view_Menu_;

			// Token: 0x040001CD RID: 461
			private static Delegate cb_onDestroyActionMode_Landroid_view_ActionMode_;

			// Token: 0x040001CE RID: 462
			private IntPtr id_onDestroyActionMode_Landroid_view_ActionMode_;

			// Token: 0x040001CF RID: 463
			private static Delegate cb_onPrepareActionMode_Landroid_view_ActionMode_Landroid_view_Menu_;

			// Token: 0x040001D0 RID: 464
			private IntPtr id_onPrepareActionMode_Landroid_view_ActionMode_Landroid_view_Menu_;
		}
	}
}
