using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Views
{
	// Token: 0x0200011D RID: 285
	[Register("android/view/MenuItem$OnActionExpandListener", DoNotGenerateAcw = true)]
	internal class IMenuItemOnActionExpandListenerInvoker : Java.Lang.Object, IMenuItemOnActionExpandListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700017B RID: 379
		// (get) Token: 0x060007D1 RID: 2001 RVA: 0x00012948 File Offset: 0x00010B48
		private static IntPtr java_class_ref
		{
			get
			{
				return IMenuItemOnActionExpandListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x060007D2 RID: 2002 RVA: 0x0001296C File Offset: 0x00010B6C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IMenuItemOnActionExpandListenerInvoker._members;
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x060007D3 RID: 2003 RVA: 0x00012973 File Offset: 0x00010B73
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x060007D4 RID: 2004 RVA: 0x0001297B File Offset: 0x00010B7B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IMenuItemOnActionExpandListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x00012987 File Offset: 0x00010B87
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IMenuItemOnActionExpandListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.view.MenuItem.OnActionExpandListener'.");
			}
			return handle;
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x000129B2 File Offset: 0x00010BB2
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x000129E4 File Offset: 0x00010BE4
		public IMenuItemOnActionExpandListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IMenuItemOnActionExpandListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x00012A1C File Offset: 0x00010C1C
		private static Delegate GetOnMenuItemActionCollapse_Landroid_view_MenuItem_Handler()
		{
			if (IMenuItemOnActionExpandListenerInvoker.cb_onMenuItemActionCollapse_Landroid_view_MenuItem_ == null)
			{
				IMenuItemOnActionExpandListenerInvoker.cb_onMenuItemActionCollapse_Landroid_view_MenuItem_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IMenuItemOnActionExpandListenerInvoker.n_OnMenuItemActionCollapse_Landroid_view_MenuItem_));
			}
			return IMenuItemOnActionExpandListenerInvoker.cb_onMenuItemActionCollapse_Landroid_view_MenuItem_;
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x00012A40 File Offset: 0x00010C40
		private static bool n_OnMenuItemActionCollapse_Landroid_view_MenuItem_(IntPtr jnienv, IntPtr native__this, IntPtr native_item)
		{
			IMenuItemOnActionExpandListener @object = Java.Lang.Object.GetObject<IMenuItemOnActionExpandListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMenuItem object2 = Java.Lang.Object.GetObject<IMenuItem>(native_item, JniHandleOwnership.DoNotTransfer);
			return @object.OnMenuItemActionCollapse(object2);
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x00012A64 File Offset: 0x00010C64
		public unsafe bool OnMenuItemActionCollapse(IMenuItem item)
		{
			if (this.id_onMenuItemActionCollapse_Landroid_view_MenuItem_ == IntPtr.Zero)
			{
				this.id_onMenuItemActionCollapse_Landroid_view_MenuItem_ = JNIEnv.GetMethodID(this.class_ref, "onMenuItemActionCollapse", "(Landroid/view/MenuItem;)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((item == null) ? IntPtr.Zero : ((Java.Lang.Object)item).Handle);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_onMenuItemActionCollapse_Landroid_view_MenuItem_, ptr);
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x00012ADC File Offset: 0x00010CDC
		private static Delegate GetOnMenuItemActionExpand_Landroid_view_MenuItem_Handler()
		{
			if (IMenuItemOnActionExpandListenerInvoker.cb_onMenuItemActionExpand_Landroid_view_MenuItem_ == null)
			{
				IMenuItemOnActionExpandListenerInvoker.cb_onMenuItemActionExpand_Landroid_view_MenuItem_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IMenuItemOnActionExpandListenerInvoker.n_OnMenuItemActionExpand_Landroid_view_MenuItem_));
			}
			return IMenuItemOnActionExpandListenerInvoker.cb_onMenuItemActionExpand_Landroid_view_MenuItem_;
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x00012B00 File Offset: 0x00010D00
		private static bool n_OnMenuItemActionExpand_Landroid_view_MenuItem_(IntPtr jnienv, IntPtr native__this, IntPtr native_item)
		{
			IMenuItemOnActionExpandListener @object = Java.Lang.Object.GetObject<IMenuItemOnActionExpandListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMenuItem object2 = Java.Lang.Object.GetObject<IMenuItem>(native_item, JniHandleOwnership.DoNotTransfer);
			return @object.OnMenuItemActionExpand(object2);
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x00012B24 File Offset: 0x00010D24
		public unsafe bool OnMenuItemActionExpand(IMenuItem item)
		{
			if (this.id_onMenuItemActionExpand_Landroid_view_MenuItem_ == IntPtr.Zero)
			{
				this.id_onMenuItemActionExpand_Landroid_view_MenuItem_ = JNIEnv.GetMethodID(this.class_ref, "onMenuItemActionExpand", "(Landroid/view/MenuItem;)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((item == null) ? IntPtr.Zero : ((Java.Lang.Object)item).Handle);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_onMenuItemActionExpand_Landroid_view_MenuItem_, ptr);
		}

		// Token: 0x04000236 RID: 566
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/view/MenuItem$OnActionExpandListener", typeof(IMenuItemOnActionExpandListenerInvoker));

		// Token: 0x04000237 RID: 567
		private IntPtr class_ref;

		// Token: 0x04000238 RID: 568
		private static Delegate cb_onMenuItemActionCollapse_Landroid_view_MenuItem_;

		// Token: 0x04000239 RID: 569
		private IntPtr id_onMenuItemActionCollapse_Landroid_view_MenuItem_;

		// Token: 0x0400023A RID: 570
		private static Delegate cb_onMenuItemActionExpand_Landroid_view_MenuItem_;

		// Token: 0x0400023B RID: 571
		private IntPtr id_onMenuItemActionExpand_Landroid_view_MenuItem_;
	}
}
