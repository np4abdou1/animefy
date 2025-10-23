using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Views
{
	// Token: 0x0200011F RID: 287
	[Register("android/view/MenuItem$OnMenuItemClickListener", DoNotGenerateAcw = true)]
	internal class IMenuItemOnMenuItemClickListenerInvoker : Java.Lang.Object, IMenuItemOnMenuItemClickListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700017F RID: 383
		// (get) Token: 0x060007E0 RID: 2016 RVA: 0x00012BB8 File Offset: 0x00010DB8
		private static IntPtr java_class_ref
		{
			get
			{
				return IMenuItemOnMenuItemClickListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x060007E1 RID: 2017 RVA: 0x00012BDC File Offset: 0x00010DDC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IMenuItemOnMenuItemClickListenerInvoker._members;
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x060007E2 RID: 2018 RVA: 0x00012BE3 File Offset: 0x00010DE3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x060007E3 RID: 2019 RVA: 0x00012BEB File Offset: 0x00010DEB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IMenuItemOnMenuItemClickListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x00012BF7 File Offset: 0x00010DF7
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IMenuItemOnMenuItemClickListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.view.MenuItem.OnMenuItemClickListener'.");
			}
			return handle;
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x00012C22 File Offset: 0x00010E22
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x00012C54 File Offset: 0x00010E54
		public IMenuItemOnMenuItemClickListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IMenuItemOnMenuItemClickListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x00012C8C File Offset: 0x00010E8C
		private static Delegate GetOnMenuItemClick_Landroid_view_MenuItem_Handler()
		{
			if (IMenuItemOnMenuItemClickListenerInvoker.cb_onMenuItemClick_Landroid_view_MenuItem_ == null)
			{
				IMenuItemOnMenuItemClickListenerInvoker.cb_onMenuItemClick_Landroid_view_MenuItem_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IMenuItemOnMenuItemClickListenerInvoker.n_OnMenuItemClick_Landroid_view_MenuItem_));
			}
			return IMenuItemOnMenuItemClickListenerInvoker.cb_onMenuItemClick_Landroid_view_MenuItem_;
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x00012CB0 File Offset: 0x00010EB0
		private static bool n_OnMenuItemClick_Landroid_view_MenuItem_(IntPtr jnienv, IntPtr native__this, IntPtr native_item)
		{
			IMenuItemOnMenuItemClickListener @object = Java.Lang.Object.GetObject<IMenuItemOnMenuItemClickListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMenuItem object2 = Java.Lang.Object.GetObject<IMenuItem>(native_item, JniHandleOwnership.DoNotTransfer);
			return @object.OnMenuItemClick(object2);
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x00012CD4 File Offset: 0x00010ED4
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

		// Token: 0x0400023C RID: 572
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/view/MenuItem$OnMenuItemClickListener", typeof(IMenuItemOnMenuItemClickListenerInvoker));

		// Token: 0x0400023D RID: 573
		private IntPtr class_ref;

		// Token: 0x0400023E RID: 574
		private static Delegate cb_onMenuItemClick_Landroid_view_MenuItem_;

		// Token: 0x0400023F RID: 575
		private IntPtr id_onMenuItemClick_Landroid_view_MenuItem_;
	}
}
