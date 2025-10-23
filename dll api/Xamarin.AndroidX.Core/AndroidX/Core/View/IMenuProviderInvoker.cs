using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Android.Views;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Core.View
{
	// Token: 0x020000A5 RID: 165
	[Register("androidx/core/view/MenuProvider", DoNotGenerateAcw = true)]
	internal class IMenuProviderInvoker : Java.Lang.Object, IMenuProvider, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x060008CA RID: 2250 RVA: 0x0001A730 File Offset: 0x00018930
		private static IntPtr java_class_ref
		{
			get
			{
				return IMenuProviderInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x060008CB RID: 2251 RVA: 0x0001A754 File Offset: 0x00018954
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IMenuProviderInvoker._members;
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x060008CC RID: 2252 RVA: 0x0001A75B File Offset: 0x0001895B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x060008CD RID: 2253 RVA: 0x0001A763 File Offset: 0x00018963
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IMenuProviderInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x0001A76F File Offset: 0x0001896F
		public static IMenuProvider GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IMenuProvider>(handle, transfer);
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x0001A778 File Offset: 0x00018978
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IMenuProviderInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.core.view.MenuProvider'.");
			}
			return handle;
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x0001A7A3 File Offset: 0x000189A3
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x0001A7D4 File Offset: 0x000189D4
		public IMenuProviderInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IMenuProviderInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x0001A80C File Offset: 0x00018A0C
		private static Delegate GetOnCreateMenu_Landroid_view_Menu_Landroid_view_MenuInflater_Handler()
		{
			if (IMenuProviderInvoker.cb_onCreateMenu_Landroid_view_Menu_Landroid_view_MenuInflater_ == null)
			{
				IMenuProviderInvoker.cb_onCreateMenu_Landroid_view_Menu_Landroid_view_MenuInflater_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IMenuProviderInvoker.n_OnCreateMenu_Landroid_view_Menu_Landroid_view_MenuInflater_));
			}
			return IMenuProviderInvoker.cb_onCreateMenu_Landroid_view_Menu_Landroid_view_MenuInflater_;
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x0001A830 File Offset: 0x00018A30
		private static void n_OnCreateMenu_Landroid_view_Menu_Landroid_view_MenuInflater_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IMenuProvider @object = Java.Lang.Object.GetObject<IMenuProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMenu object2 = Java.Lang.Object.GetObject<IMenu>(native_p0, JniHandleOwnership.DoNotTransfer);
			MenuInflater object3 = Java.Lang.Object.GetObject<MenuInflater>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.OnCreateMenu(object2, object3);
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x0001A85C File Offset: 0x00018A5C
		public unsafe void OnCreateMenu(IMenu p0, MenuInflater p1)
		{
			if (this.id_onCreateMenu_Landroid_view_Menu_Landroid_view_MenuInflater_ == IntPtr.Zero)
			{
				this.id_onCreateMenu_Landroid_view_Menu_Landroid_view_MenuInflater_ = JNIEnv.GetMethodID(this.class_ref, "onCreateMenu", "(Landroid/view/Menu;Landroid/view/MenuInflater;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onCreateMenu_Landroid_view_Menu_Landroid_view_MenuInflater_, ptr);
		}

		// Token: 0x060008D5 RID: 2261 RVA: 0x0001A8F6 File Offset: 0x00018AF6
		private static Delegate GetOnMenuItemSelected_Landroid_view_MenuItem_Handler()
		{
			if (IMenuProviderInvoker.cb_onMenuItemSelected_Landroid_view_MenuItem_ == null)
			{
				IMenuProviderInvoker.cb_onMenuItemSelected_Landroid_view_MenuItem_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IMenuProviderInvoker.n_OnMenuItemSelected_Landroid_view_MenuItem_));
			}
			return IMenuProviderInvoker.cb_onMenuItemSelected_Landroid_view_MenuItem_;
		}

		// Token: 0x060008D6 RID: 2262 RVA: 0x0001A91C File Offset: 0x00018B1C
		private static bool n_OnMenuItemSelected_Landroid_view_MenuItem_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMenuProvider @object = Java.Lang.Object.GetObject<IMenuProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMenuItem object2 = Java.Lang.Object.GetObject<IMenuItem>(native_p0, JniHandleOwnership.DoNotTransfer);
			return @object.OnMenuItemSelected(object2);
		}

		// Token: 0x060008D7 RID: 2263 RVA: 0x0001A940 File Offset: 0x00018B40
		public unsafe bool OnMenuItemSelected(IMenuItem p0)
		{
			if (this.id_onMenuItemSelected_Landroid_view_MenuItem_ == IntPtr.Zero)
			{
				this.id_onMenuItemSelected_Landroid_view_MenuItem_ = JNIEnv.GetMethodID(this.class_ref, "onMenuItemSelected", "(Landroid/view/MenuItem;)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_onMenuItemSelected_Landroid_view_MenuItem_, ptr);
		}

		// Token: 0x0400025B RID: 603
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/view/MenuProvider", typeof(IMenuProviderInvoker));

		// Token: 0x0400025C RID: 604
		private IntPtr class_ref;

		// Token: 0x0400025D RID: 605
		private static Delegate cb_onCreateMenu_Landroid_view_Menu_Landroid_view_MenuInflater_;

		// Token: 0x0400025E RID: 606
		private IntPtr id_onCreateMenu_Landroid_view_Menu_Landroid_view_MenuInflater_;

		// Token: 0x0400025F RID: 607
		private static Delegate cb_onMenuItemSelected_Landroid_view_MenuItem_;

		// Token: 0x04000260 RID: 608
		private IntPtr id_onMenuItemSelected_Landroid_view_MenuItem_;
	}
}
