using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Graphics.Drawables;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.View.Menu;
using AndroidX.Core.View;
using Java.Interop;
using Java.Lang;

namespace AndroidX.AppCompat.Widget
{
	// Token: 0x02000067 RID: 103
	[Register("androidx/appcompat/widget/DecorToolbar", DoNotGenerateAcw = true)]
	internal class IDecorToolbarInvoker : Java.Lang.Object, IDecorToolbar, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060006CC RID: 1740 RVA: 0x000117A8 File Offset: 0x0000F9A8
		private static IntPtr java_class_ref
		{
			get
			{
				return IDecorToolbarInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060006CD RID: 1741 RVA: 0x000117CC File Offset: 0x0000F9CC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IDecorToolbarInvoker._members;
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060006CE RID: 1742 RVA: 0x000117D3 File Offset: 0x0000F9D3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060006CF RID: 1743 RVA: 0x000117DB File Offset: 0x0000F9DB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IDecorToolbarInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x000117E7 File Offset: 0x0000F9E7
		public static IDecorToolbar GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IDecorToolbar>(handle, transfer);
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x000117F0 File Offset: 0x0000F9F0
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IDecorToolbarInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.appcompat.widget.DecorToolbar'.");
			}
			return handle;
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x0001181B File Offset: 0x0000FA1B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x0001184C File Offset: 0x0000FA4C
		public IDecorToolbarInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IDecorToolbarInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x00011884 File Offset: 0x0000FA84
		private static Delegate GetGetContextHandler()
		{
			if (IDecorToolbarInvoker.cb_getContext == null)
			{
				IDecorToolbarInvoker.cb_getContext = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IDecorToolbarInvoker.n_GetContext));
			}
			return IDecorToolbarInvoker.cb_getContext;
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x000118A8 File Offset: 0x0000FAA8
		private static IntPtr n_GetContext(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IDecorToolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Context);
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060006D6 RID: 1750 RVA: 0x000118BC File Offset: 0x0000FABC
		public Context Context
		{
			get
			{
				if (this.id_getContext == IntPtr.Zero)
				{
					this.id_getContext = JNIEnv.GetMethodID(this.class_ref, "getContext", "()Landroid/content/Context;");
				}
				return Java.Lang.Object.GetObject<Context>(JNIEnv.CallObjectMethod(base.Handle, this.id_getContext), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x0001190D File Offset: 0x0000FB0D
		private static Delegate GetGetCustomViewHandler()
		{
			if (IDecorToolbarInvoker.cb_getCustomView == null)
			{
				IDecorToolbarInvoker.cb_getCustomView = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IDecorToolbarInvoker.n_GetCustomView));
			}
			return IDecorToolbarInvoker.cb_getCustomView;
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x00011931 File Offset: 0x0000FB31
		private static IntPtr n_GetCustomView(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IDecorToolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CustomView);
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x00011945 File Offset: 0x0000FB45
		private static Delegate GetSetCustomView_Landroid_view_View_Handler()
		{
			if (IDecorToolbarInvoker.cb_setCustomView_Landroid_view_View_ == null)
			{
				IDecorToolbarInvoker.cb_setCustomView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IDecorToolbarInvoker.n_SetCustomView_Landroid_view_View_));
			}
			return IDecorToolbarInvoker.cb_setCustomView_Landroid_view_View_;
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x0001196C File Offset: 0x0000FB6C
		private static void n_SetCustomView_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IDecorToolbar @object = Java.Lang.Object.GetObject<IDecorToolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.CustomView = object2;
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060006DB RID: 1755 RVA: 0x00011990 File Offset: 0x0000FB90
		// (set) Token: 0x060006DC RID: 1756 RVA: 0x000119E4 File Offset: 0x0000FBE4
		public unsafe View CustomView
		{
			get
			{
				if (this.id_getCustomView == IntPtr.Zero)
				{
					this.id_getCustomView = JNIEnv.GetMethodID(this.class_ref, "getCustomView", "()Landroid/view/View;");
				}
				return Java.Lang.Object.GetObject<View>(JNIEnv.CallObjectMethod(base.Handle, this.id_getCustomView), JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				if (this.id_setCustomView_Landroid_view_View_ == IntPtr.Zero)
				{
					this.id_setCustomView_Landroid_view_View_ = JNIEnv.GetMethodID(this.class_ref, "setCustomView", "(Landroid/view/View;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((value == null) ? IntPtr.Zero : value.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_setCustomView_Landroid_view_View_, ptr);
			}
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x00011A57 File Offset: 0x0000FC57
		private static Delegate GetGetDisplayOptionsHandler()
		{
			if (IDecorToolbarInvoker.cb_getDisplayOptions == null)
			{
				IDecorToolbarInvoker.cb_getDisplayOptions = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IDecorToolbarInvoker.n_GetDisplayOptions));
			}
			return IDecorToolbarInvoker.cb_getDisplayOptions;
		}

		// Token: 0x060006DE RID: 1758 RVA: 0x00011A7B File Offset: 0x0000FC7B
		private static int n_GetDisplayOptions(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IDecorToolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DisplayOptions;
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x00011A8A File Offset: 0x0000FC8A
		private static Delegate GetSetDisplayOptions_IHandler()
		{
			if (IDecorToolbarInvoker.cb_setDisplayOptions_I == null)
			{
				IDecorToolbarInvoker.cb_setDisplayOptions_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(IDecorToolbarInvoker.n_SetDisplayOptions_I));
			}
			return IDecorToolbarInvoker.cb_setDisplayOptions_I;
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x00011AAE File Offset: 0x0000FCAE
		private static void n_SetDisplayOptions_I(IntPtr jnienv, IntPtr native__this, int p0)
		{
			Java.Lang.Object.GetObject<IDecorToolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DisplayOptions = p0;
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060006E1 RID: 1761 RVA: 0x00011ABE File Offset: 0x0000FCBE
		// (set) Token: 0x060006E2 RID: 1762 RVA: 0x00011B00 File Offset: 0x0000FD00
		public unsafe int DisplayOptions
		{
			get
			{
				if (this.id_getDisplayOptions == IntPtr.Zero)
				{
					this.id_getDisplayOptions = JNIEnv.GetMethodID(this.class_ref, "getDisplayOptions", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_getDisplayOptions);
			}
			set
			{
				if (this.id_setDisplayOptions_I == IntPtr.Zero)
				{
					this.id_setDisplayOptions_I = JNIEnv.GetMethodID(this.class_ref, "setDisplayOptions", "(I)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue(value);
				JNIEnv.CallVoidMethod(base.Handle, this.id_setDisplayOptions_I, ptr);
			}
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x00011B64 File Offset: 0x0000FD64
		private static Delegate GetGetDropdownItemCountHandler()
		{
			if (IDecorToolbarInvoker.cb_getDropdownItemCount == null)
			{
				IDecorToolbarInvoker.cb_getDropdownItemCount = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IDecorToolbarInvoker.n_GetDropdownItemCount));
			}
			return IDecorToolbarInvoker.cb_getDropdownItemCount;
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x00011B88 File Offset: 0x0000FD88
		private static int n_GetDropdownItemCount(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IDecorToolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DropdownItemCount;
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x060006E5 RID: 1765 RVA: 0x00011B97 File Offset: 0x0000FD97
		public int DropdownItemCount
		{
			get
			{
				if (this.id_getDropdownItemCount == IntPtr.Zero)
				{
					this.id_getDropdownItemCount = JNIEnv.GetMethodID(this.class_ref, "getDropdownItemCount", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_getDropdownItemCount);
			}
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x00011BD7 File Offset: 0x0000FDD7
		private static Delegate GetGetDropdownSelectedPositionHandler()
		{
			if (IDecorToolbarInvoker.cb_getDropdownSelectedPosition == null)
			{
				IDecorToolbarInvoker.cb_getDropdownSelectedPosition = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IDecorToolbarInvoker.n_GetDropdownSelectedPosition));
			}
			return IDecorToolbarInvoker.cb_getDropdownSelectedPosition;
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x00011BFB File Offset: 0x0000FDFB
		private static int n_GetDropdownSelectedPosition(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IDecorToolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DropdownSelectedPosition;
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x00011C0A File Offset: 0x0000FE0A
		private static Delegate GetSetDropdownSelectedPosition_IHandler()
		{
			if (IDecorToolbarInvoker.cb_setDropdownSelectedPosition_I == null)
			{
				IDecorToolbarInvoker.cb_setDropdownSelectedPosition_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(IDecorToolbarInvoker.n_SetDropdownSelectedPosition_I));
			}
			return IDecorToolbarInvoker.cb_setDropdownSelectedPosition_I;
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x00011C2E File Offset: 0x0000FE2E
		private static void n_SetDropdownSelectedPosition_I(IntPtr jnienv, IntPtr native__this, int p0)
		{
			Java.Lang.Object.GetObject<IDecorToolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DropdownSelectedPosition = p0;
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060006EA RID: 1770 RVA: 0x00011C3E File Offset: 0x0000FE3E
		// (set) Token: 0x060006EB RID: 1771 RVA: 0x00011C80 File Offset: 0x0000FE80
		public unsafe int DropdownSelectedPosition
		{
			get
			{
				if (this.id_getDropdownSelectedPosition == IntPtr.Zero)
				{
					this.id_getDropdownSelectedPosition = JNIEnv.GetMethodID(this.class_ref, "getDropdownSelectedPosition", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_getDropdownSelectedPosition);
			}
			set
			{
				if (this.id_setDropdownSelectedPosition_I == IntPtr.Zero)
				{
					this.id_setDropdownSelectedPosition_I = JNIEnv.GetMethodID(this.class_ref, "setDropdownSelectedPosition", "(I)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue(value);
				JNIEnv.CallVoidMethod(base.Handle, this.id_setDropdownSelectedPosition_I, ptr);
			}
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x00011CE4 File Offset: 0x0000FEE4
		private static Delegate GetHasEmbeddedTabsHandler()
		{
			if (IDecorToolbarInvoker.cb_hasEmbeddedTabs == null)
			{
				IDecorToolbarInvoker.cb_hasEmbeddedTabs = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IDecorToolbarInvoker.n_HasEmbeddedTabs));
			}
			return IDecorToolbarInvoker.cb_hasEmbeddedTabs;
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x00011D08 File Offset: 0x0000FF08
		private static bool n_HasEmbeddedTabs(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IDecorToolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HasEmbeddedTabs;
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060006EE RID: 1774 RVA: 0x00011D17 File Offset: 0x0000FF17
		public bool HasEmbeddedTabs
		{
			get
			{
				if (this.id_hasEmbeddedTabs == IntPtr.Zero)
				{
					this.id_hasEmbeddedTabs = JNIEnv.GetMethodID(this.class_ref, "hasEmbeddedTabs", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_hasEmbeddedTabs);
			}
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x00011D57 File Offset: 0x0000FF57
		private static Delegate GetHasExpandedActionViewHandler()
		{
			if (IDecorToolbarInvoker.cb_hasExpandedActionView == null)
			{
				IDecorToolbarInvoker.cb_hasExpandedActionView = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IDecorToolbarInvoker.n_HasExpandedActionView));
			}
			return IDecorToolbarInvoker.cb_hasExpandedActionView;
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x00011D7B File Offset: 0x0000FF7B
		private static bool n_HasExpandedActionView(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IDecorToolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HasExpandedActionView;
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060006F1 RID: 1777 RVA: 0x00011D8A File Offset: 0x0000FF8A
		public bool HasExpandedActionView
		{
			get
			{
				if (this.id_hasExpandedActionView == IntPtr.Zero)
				{
					this.id_hasExpandedActionView = JNIEnv.GetMethodID(this.class_ref, "hasExpandedActionView", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_hasExpandedActionView);
			}
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x00011DCA File Offset: 0x0000FFCA
		private static Delegate GetHasIconHandler()
		{
			if (IDecorToolbarInvoker.cb_hasIcon == null)
			{
				IDecorToolbarInvoker.cb_hasIcon = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IDecorToolbarInvoker.n_HasIcon));
			}
			return IDecorToolbarInvoker.cb_hasIcon;
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x00011DEE File Offset: 0x0000FFEE
		private static bool n_HasIcon(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IDecorToolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HasIcon;
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x060006F4 RID: 1780 RVA: 0x00011DFD File Offset: 0x0000FFFD
		public bool HasIcon
		{
			get
			{
				if (this.id_hasIcon == IntPtr.Zero)
				{
					this.id_hasIcon = JNIEnv.GetMethodID(this.class_ref, "hasIcon", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_hasIcon);
			}
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x00011E3D File Offset: 0x0001003D
		private static Delegate GetHasLogoHandler()
		{
			if (IDecorToolbarInvoker.cb_hasLogo == null)
			{
				IDecorToolbarInvoker.cb_hasLogo = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IDecorToolbarInvoker.n_HasLogo));
			}
			return IDecorToolbarInvoker.cb_hasLogo;
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x00011E61 File Offset: 0x00010061
		private static bool n_HasLogo(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IDecorToolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HasLogo;
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x060006F7 RID: 1783 RVA: 0x00011E70 File Offset: 0x00010070
		public bool HasLogo
		{
			get
			{
				if (this.id_hasLogo == IntPtr.Zero)
				{
					this.id_hasLogo = JNIEnv.GetMethodID(this.class_ref, "hasLogo", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_hasLogo);
			}
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x00011EB0 File Offset: 0x000100B0
		private static Delegate GetGetHeightHandler()
		{
			if (IDecorToolbarInvoker.cb_getHeight == null)
			{
				IDecorToolbarInvoker.cb_getHeight = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IDecorToolbarInvoker.n_GetHeight));
			}
			return IDecorToolbarInvoker.cb_getHeight;
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x00011ED4 File Offset: 0x000100D4
		private static int n_GetHeight(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IDecorToolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Height;
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x060006FA RID: 1786 RVA: 0x00011EE3 File Offset: 0x000100E3
		public int Height
		{
			get
			{
				if (this.id_getHeight == IntPtr.Zero)
				{
					this.id_getHeight = JNIEnv.GetMethodID(this.class_ref, "getHeight", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_getHeight);
			}
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x00011F23 File Offset: 0x00010123
		private static Delegate GetIsOverflowMenuShowPendingHandler()
		{
			if (IDecorToolbarInvoker.cb_isOverflowMenuShowPending == null)
			{
				IDecorToolbarInvoker.cb_isOverflowMenuShowPending = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IDecorToolbarInvoker.n_IsOverflowMenuShowPending));
			}
			return IDecorToolbarInvoker.cb_isOverflowMenuShowPending;
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x00011F47 File Offset: 0x00010147
		private static bool n_IsOverflowMenuShowPending(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IDecorToolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsOverflowMenuShowPending;
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060006FD RID: 1789 RVA: 0x00011F56 File Offset: 0x00010156
		public bool IsOverflowMenuShowPending
		{
			get
			{
				if (this.id_isOverflowMenuShowPending == IntPtr.Zero)
				{
					this.id_isOverflowMenuShowPending = JNIEnv.GetMethodID(this.class_ref, "isOverflowMenuShowPending", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isOverflowMenuShowPending);
			}
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x00011F96 File Offset: 0x00010196
		private static Delegate GetIsOverflowMenuShowingHandler()
		{
			if (IDecorToolbarInvoker.cb_isOverflowMenuShowing == null)
			{
				IDecorToolbarInvoker.cb_isOverflowMenuShowing = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IDecorToolbarInvoker.n_IsOverflowMenuShowing));
			}
			return IDecorToolbarInvoker.cb_isOverflowMenuShowing;
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x00011FBA File Offset: 0x000101BA
		private static bool n_IsOverflowMenuShowing(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IDecorToolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsOverflowMenuShowing;
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000700 RID: 1792 RVA: 0x00011FC9 File Offset: 0x000101C9
		public bool IsOverflowMenuShowing
		{
			get
			{
				if (this.id_isOverflowMenuShowing == IntPtr.Zero)
				{
					this.id_isOverflowMenuShowing = JNIEnv.GetMethodID(this.class_ref, "isOverflowMenuShowing", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isOverflowMenuShowing);
			}
		}

		// Token: 0x06000701 RID: 1793 RVA: 0x00012009 File Offset: 0x00010209
		private static Delegate GetIsTitleTruncatedHandler()
		{
			if (IDecorToolbarInvoker.cb_isTitleTruncated == null)
			{
				IDecorToolbarInvoker.cb_isTitleTruncated = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IDecorToolbarInvoker.n_IsTitleTruncated));
			}
			return IDecorToolbarInvoker.cb_isTitleTruncated;
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x0001202D File Offset: 0x0001022D
		private static bool n_IsTitleTruncated(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IDecorToolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsTitleTruncated;
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000703 RID: 1795 RVA: 0x0001203C File Offset: 0x0001023C
		public bool IsTitleTruncated
		{
			get
			{
				if (this.id_isTitleTruncated == IntPtr.Zero)
				{
					this.id_isTitleTruncated = JNIEnv.GetMethodID(this.class_ref, "isTitleTruncated", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isTitleTruncated);
			}
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x0001207C File Offset: 0x0001027C
		private static Delegate GetGetMenuHandler()
		{
			if (IDecorToolbarInvoker.cb_getMenu == null)
			{
				IDecorToolbarInvoker.cb_getMenu = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IDecorToolbarInvoker.n_GetMenu));
			}
			return IDecorToolbarInvoker.cb_getMenu;
		}

		// Token: 0x06000705 RID: 1797 RVA: 0x000120A0 File Offset: 0x000102A0
		private static IntPtr n_GetMenu(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IDecorToolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Menu);
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000706 RID: 1798 RVA: 0x000120B4 File Offset: 0x000102B4
		public IMenu Menu
		{
			get
			{
				if (this.id_getMenu == IntPtr.Zero)
				{
					this.id_getMenu = JNIEnv.GetMethodID(this.class_ref, "getMenu", "()Landroid/view/Menu;");
				}
				return Java.Lang.Object.GetObject<IMenu>(JNIEnv.CallObjectMethod(base.Handle, this.id_getMenu), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000707 RID: 1799 RVA: 0x00012105 File Offset: 0x00010305
		private static Delegate GetGetNavigationModeHandler()
		{
			if (IDecorToolbarInvoker.cb_getNavigationMode == null)
			{
				IDecorToolbarInvoker.cb_getNavigationMode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IDecorToolbarInvoker.n_GetNavigationMode));
			}
			return IDecorToolbarInvoker.cb_getNavigationMode;
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x00012129 File Offset: 0x00010329
		private static int n_GetNavigationMode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IDecorToolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NavigationMode;
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x00012138 File Offset: 0x00010338
		private static Delegate GetSetNavigationMode_IHandler()
		{
			if (IDecorToolbarInvoker.cb_setNavigationMode_I == null)
			{
				IDecorToolbarInvoker.cb_setNavigationMode_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(IDecorToolbarInvoker.n_SetNavigationMode_I));
			}
			return IDecorToolbarInvoker.cb_setNavigationMode_I;
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x0001215C File Offset: 0x0001035C
		private static void n_SetNavigationMode_I(IntPtr jnienv, IntPtr native__this, int p0)
		{
			Java.Lang.Object.GetObject<IDecorToolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NavigationMode = p0;
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x0600070B RID: 1803 RVA: 0x0001216C File Offset: 0x0001036C
		// (set) Token: 0x0600070C RID: 1804 RVA: 0x000121AC File Offset: 0x000103AC
		public unsafe int NavigationMode
		{
			get
			{
				if (this.id_getNavigationMode == IntPtr.Zero)
				{
					this.id_getNavigationMode = JNIEnv.GetMethodID(this.class_ref, "getNavigationMode", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_getNavigationMode);
			}
			set
			{
				if (this.id_setNavigationMode_I == IntPtr.Zero)
				{
					this.id_setNavigationMode_I = JNIEnv.GetMethodID(this.class_ref, "setNavigationMode", "(I)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue(value);
				JNIEnv.CallVoidMethod(base.Handle, this.id_setNavigationMode_I, ptr);
			}
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x00012210 File Offset: 0x00010410
		private static Delegate GetGetSubtitleHandler()
		{
			if (IDecorToolbarInvoker.cb_getSubtitle == null)
			{
				IDecorToolbarInvoker.cb_getSubtitle = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IDecorToolbarInvoker.n_GetSubtitle));
			}
			return IDecorToolbarInvoker.cb_getSubtitle;
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x00012234 File Offset: 0x00010434
		private static IntPtr n_GetSubtitle(IntPtr jnienv, IntPtr native__this)
		{
			return CharSequence.ToLocalJniHandle(Java.Lang.Object.GetObject<IDecorToolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SubtitleFormatted);
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x00012248 File Offset: 0x00010448
		private static Delegate GetSetSubtitle_Ljava_lang_CharSequence_Handler()
		{
			if (IDecorToolbarInvoker.cb_setSubtitle_Ljava_lang_CharSequence_ == null)
			{
				IDecorToolbarInvoker.cb_setSubtitle_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IDecorToolbarInvoker.n_SetSubtitle_Ljava_lang_CharSequence_));
			}
			return IDecorToolbarInvoker.cb_setSubtitle_Ljava_lang_CharSequence_;
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x0001226C File Offset: 0x0001046C
		private static void n_SetSubtitle_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IDecorToolbar @object = Java.Lang.Object.GetObject<IDecorToolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.SubtitleFormatted = object2;
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000711 RID: 1809 RVA: 0x00012290 File Offset: 0x00010490
		// (set) Token: 0x06000712 RID: 1810 RVA: 0x000122E4 File Offset: 0x000104E4
		public unsafe ICharSequence SubtitleFormatted
		{
			get
			{
				if (this.id_getSubtitle == IntPtr.Zero)
				{
					this.id_getSubtitle = JNIEnv.GetMethodID(this.class_ref, "getSubtitle", "()Ljava/lang/CharSequence;");
				}
				return Java.Lang.Object.GetObject<ICharSequence>(JNIEnv.CallObjectMethod(base.Handle, this.id_getSubtitle), JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				if (this.id_setSubtitle_Ljava_lang_CharSequence_ == IntPtr.Zero)
				{
					this.id_setSubtitle_Ljava_lang_CharSequence_ = JNIEnv.GetMethodID(this.class_ref, "setSubtitle", "(Ljava/lang/CharSequence;)V");
				}
				IntPtr intPtr = CharSequence.ToLocalJniHandle(value);
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue(intPtr);
				JNIEnv.CallVoidMethod(base.Handle, this.id_setSubtitle_Ljava_lang_CharSequence_, ptr);
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x00012355 File Offset: 0x00010555
		private static Delegate GetGetTitleHandler()
		{
			if (IDecorToolbarInvoker.cb_getTitle == null)
			{
				IDecorToolbarInvoker.cb_getTitle = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IDecorToolbarInvoker.n_GetTitle));
			}
			return IDecorToolbarInvoker.cb_getTitle;
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x00012379 File Offset: 0x00010579
		private static IntPtr n_GetTitle(IntPtr jnienv, IntPtr native__this)
		{
			return CharSequence.ToLocalJniHandle(Java.Lang.Object.GetObject<IDecorToolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TitleFormatted);
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x0001238D File Offset: 0x0001058D
		private static Delegate GetSetTitle_Ljava_lang_CharSequence_Handler()
		{
			if (IDecorToolbarInvoker.cb_setTitle_Ljava_lang_CharSequence_ == null)
			{
				IDecorToolbarInvoker.cb_setTitle_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IDecorToolbarInvoker.n_SetTitle_Ljava_lang_CharSequence_));
			}
			return IDecorToolbarInvoker.cb_setTitle_Ljava_lang_CharSequence_;
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x000123B4 File Offset: 0x000105B4
		private static void n_SetTitle_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IDecorToolbar @object = Java.Lang.Object.GetObject<IDecorToolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.TitleFormatted = object2;
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000717 RID: 1815 RVA: 0x000123D8 File Offset: 0x000105D8
		// (set) Token: 0x06000718 RID: 1816 RVA: 0x0001242C File Offset: 0x0001062C
		public unsafe ICharSequence TitleFormatted
		{
			get
			{
				if (this.id_getTitle == IntPtr.Zero)
				{
					this.id_getTitle = JNIEnv.GetMethodID(this.class_ref, "getTitle", "()Ljava/lang/CharSequence;");
				}
				return Java.Lang.Object.GetObject<ICharSequence>(JNIEnv.CallObjectMethod(base.Handle, this.id_getTitle), JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				if (this.id_setTitle_Ljava_lang_CharSequence_ == IntPtr.Zero)
				{
					this.id_setTitle_Ljava_lang_CharSequence_ = JNIEnv.GetMethodID(this.class_ref, "setTitle", "(Ljava/lang/CharSequence;)V");
				}
				IntPtr intPtr = CharSequence.ToLocalJniHandle(value);
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue(intPtr);
				JNIEnv.CallVoidMethod(base.Handle, this.id_setTitle_Ljava_lang_CharSequence_, ptr);
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x0001249D File Offset: 0x0001069D
		private static Delegate GetGetViewGroupHandler()
		{
			if (IDecorToolbarInvoker.cb_getViewGroup == null)
			{
				IDecorToolbarInvoker.cb_getViewGroup = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IDecorToolbarInvoker.n_GetViewGroup));
			}
			return IDecorToolbarInvoker.cb_getViewGroup;
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x000124C1 File Offset: 0x000106C1
		private static IntPtr n_GetViewGroup(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IDecorToolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ViewGroup);
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x0600071B RID: 1819 RVA: 0x000124D8 File Offset: 0x000106D8
		public ViewGroup ViewGroup
		{
			get
			{
				if (this.id_getViewGroup == IntPtr.Zero)
				{
					this.id_getViewGroup = JNIEnv.GetMethodID(this.class_ref, "getViewGroup", "()Landroid/view/ViewGroup;");
				}
				return Java.Lang.Object.GetObject<ViewGroup>(JNIEnv.CallObjectMethod(base.Handle, this.id_getViewGroup), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x00012529 File Offset: 0x00010729
		private static Delegate GetGetVisibilityHandler()
		{
			if (IDecorToolbarInvoker.cb_getVisibility == null)
			{
				IDecorToolbarInvoker.cb_getVisibility = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IDecorToolbarInvoker.n_GetVisibility));
			}
			return IDecorToolbarInvoker.cb_getVisibility;
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x0001254D File Offset: 0x0001074D
		private static int n_GetVisibility(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IDecorToolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Visibility;
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x0001255C File Offset: 0x0001075C
		private static Delegate GetSetVisibility_IHandler()
		{
			if (IDecorToolbarInvoker.cb_setVisibility_I == null)
			{
				IDecorToolbarInvoker.cb_setVisibility_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(IDecorToolbarInvoker.n_SetVisibility_I));
			}
			return IDecorToolbarInvoker.cb_setVisibility_I;
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x00012580 File Offset: 0x00010780
		private static void n_SetVisibility_I(IntPtr jnienv, IntPtr native__this, int p0)
		{
			Java.Lang.Object.GetObject<IDecorToolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Visibility = p0;
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000720 RID: 1824 RVA: 0x00012590 File Offset: 0x00010790
		// (set) Token: 0x06000721 RID: 1825 RVA: 0x000125D0 File Offset: 0x000107D0
		public unsafe int Visibility
		{
			get
			{
				if (this.id_getVisibility == IntPtr.Zero)
				{
					this.id_getVisibility = JNIEnv.GetMethodID(this.class_ref, "getVisibility", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_getVisibility);
			}
			set
			{
				if (this.id_setVisibility_I == IntPtr.Zero)
				{
					this.id_setVisibility_I = JNIEnv.GetMethodID(this.class_ref, "setVisibility", "(I)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue(value);
				JNIEnv.CallVoidMethod(base.Handle, this.id_setVisibility_I, ptr);
			}
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x00012634 File Offset: 0x00010834
		private static Delegate GetAnimateToVisibility_IHandler()
		{
			if (IDecorToolbarInvoker.cb_animateToVisibility_I == null)
			{
				IDecorToolbarInvoker.cb_animateToVisibility_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(IDecorToolbarInvoker.n_AnimateToVisibility_I));
			}
			return IDecorToolbarInvoker.cb_animateToVisibility_I;
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x00012658 File Offset: 0x00010858
		private static void n_AnimateToVisibility_I(IntPtr jnienv, IntPtr native__this, int p0)
		{
			Java.Lang.Object.GetObject<IDecorToolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnimateToVisibility(p0);
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x00012668 File Offset: 0x00010868
		public unsafe void AnimateToVisibility(int p0)
		{
			if (this.id_animateToVisibility_I == IntPtr.Zero)
			{
				this.id_animateToVisibility_I = JNIEnv.GetMethodID(this.class_ref, "animateToVisibility", "(I)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			JNIEnv.CallVoidMethod(base.Handle, this.id_animateToVisibility_I, ptr);
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x000126CC File Offset: 0x000108CC
		private static Delegate GetCanShowOverflowMenuHandler()
		{
			if (IDecorToolbarInvoker.cb_canShowOverflowMenu == null)
			{
				IDecorToolbarInvoker.cb_canShowOverflowMenu = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IDecorToolbarInvoker.n_CanShowOverflowMenu));
			}
			return IDecorToolbarInvoker.cb_canShowOverflowMenu;
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x000126F0 File Offset: 0x000108F0
		private static bool n_CanShowOverflowMenu(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IDecorToolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CanShowOverflowMenu();
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x000126FF File Offset: 0x000108FF
		public bool CanShowOverflowMenu()
		{
			if (this.id_canShowOverflowMenu == IntPtr.Zero)
			{
				this.id_canShowOverflowMenu = JNIEnv.GetMethodID(this.class_ref, "canShowOverflowMenu", "()Z");
			}
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_canShowOverflowMenu);
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x0001273F File Offset: 0x0001093F
		private static Delegate GetCollapseActionViewHandler()
		{
			if (IDecorToolbarInvoker.cb_collapseActionView == null)
			{
				IDecorToolbarInvoker.cb_collapseActionView = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IDecorToolbarInvoker.n_CollapseActionView));
			}
			return IDecorToolbarInvoker.cb_collapseActionView;
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x00012763 File Offset: 0x00010963
		private static void n_CollapseActionView(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IDecorToolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CollapseActionView();
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x00012772 File Offset: 0x00010972
		public void CollapseActionView()
		{
			if (this.id_collapseActionView == IntPtr.Zero)
			{
				this.id_collapseActionView = JNIEnv.GetMethodID(this.class_ref, "collapseActionView", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_collapseActionView);
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x000127B2 File Offset: 0x000109B2
		private static Delegate GetDismissPopupMenusHandler()
		{
			if (IDecorToolbarInvoker.cb_dismissPopupMenus == null)
			{
				IDecorToolbarInvoker.cb_dismissPopupMenus = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IDecorToolbarInvoker.n_DismissPopupMenus));
			}
			return IDecorToolbarInvoker.cb_dismissPopupMenus;
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x000127D6 File Offset: 0x000109D6
		private static void n_DismissPopupMenus(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IDecorToolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DismissPopupMenus();
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x000127E5 File Offset: 0x000109E5
		public void DismissPopupMenus()
		{
			if (this.id_dismissPopupMenus == IntPtr.Zero)
			{
				this.id_dismissPopupMenus = JNIEnv.GetMethodID(this.class_ref, "dismissPopupMenus", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_dismissPopupMenus);
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x00012825 File Offset: 0x00010A25
		private static Delegate GetHideOverflowMenuHandler()
		{
			if (IDecorToolbarInvoker.cb_hideOverflowMenu == null)
			{
				IDecorToolbarInvoker.cb_hideOverflowMenu = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IDecorToolbarInvoker.n_HideOverflowMenu));
			}
			return IDecorToolbarInvoker.cb_hideOverflowMenu;
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x00012849 File Offset: 0x00010A49
		private static bool n_HideOverflowMenu(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IDecorToolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HideOverflowMenu();
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x00012858 File Offset: 0x00010A58
		public bool HideOverflowMenu()
		{
			if (this.id_hideOverflowMenu == IntPtr.Zero)
			{
				this.id_hideOverflowMenu = JNIEnv.GetMethodID(this.class_ref, "hideOverflowMenu", "()Z");
			}
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_hideOverflowMenu);
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x00012898 File Offset: 0x00010A98
		private static Delegate GetInitIndeterminateProgressHandler()
		{
			if (IDecorToolbarInvoker.cb_initIndeterminateProgress == null)
			{
				IDecorToolbarInvoker.cb_initIndeterminateProgress = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IDecorToolbarInvoker.n_InitIndeterminateProgress));
			}
			return IDecorToolbarInvoker.cb_initIndeterminateProgress;
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x000128BC File Offset: 0x00010ABC
		private static void n_InitIndeterminateProgress(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IDecorToolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).InitIndeterminateProgress();
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x000128CB File Offset: 0x00010ACB
		public void InitIndeterminateProgress()
		{
			if (this.id_initIndeterminateProgress == IntPtr.Zero)
			{
				this.id_initIndeterminateProgress = JNIEnv.GetMethodID(this.class_ref, "initIndeterminateProgress", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_initIndeterminateProgress);
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x0001290B File Offset: 0x00010B0B
		private static Delegate GetInitProgressHandler()
		{
			if (IDecorToolbarInvoker.cb_initProgress == null)
			{
				IDecorToolbarInvoker.cb_initProgress = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IDecorToolbarInvoker.n_InitProgress));
			}
			return IDecorToolbarInvoker.cb_initProgress;
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x0001292F File Offset: 0x00010B2F
		private static void n_InitProgress(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IDecorToolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).InitProgress();
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x0001293E File Offset: 0x00010B3E
		public void InitProgress()
		{
			if (this.id_initProgress == IntPtr.Zero)
			{
				this.id_initProgress = JNIEnv.GetMethodID(this.class_ref, "initProgress", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_initProgress);
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x0001297E File Offset: 0x00010B7E
		private static Delegate GetRestoreHierarchyState_Landroid_util_SparseArray_Handler()
		{
			if (IDecorToolbarInvoker.cb_restoreHierarchyState_Landroid_util_SparseArray_ == null)
			{
				IDecorToolbarInvoker.cb_restoreHierarchyState_Landroid_util_SparseArray_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IDecorToolbarInvoker.n_RestoreHierarchyState_Landroid_util_SparseArray_));
			}
			return IDecorToolbarInvoker.cb_restoreHierarchyState_Landroid_util_SparseArray_;
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x000129A4 File Offset: 0x00010BA4
		private static void n_RestoreHierarchyState_Landroid_util_SparseArray_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IDecorToolbar @object = Java.Lang.Object.GetObject<IDecorToolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			SparseArray object2 = Java.Lang.Object.GetObject<SparseArray>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.RestoreHierarchyState(object2);
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x000129C8 File Offset: 0x00010BC8
		public unsafe void RestoreHierarchyState(SparseArray p0)
		{
			if (this.id_restoreHierarchyState_Landroid_util_SparseArray_ == IntPtr.Zero)
			{
				this.id_restoreHierarchyState_Landroid_util_SparseArray_ = JNIEnv.GetMethodID(this.class_ref, "restoreHierarchyState", "(Landroid/util/SparseArray;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_restoreHierarchyState_Landroid_util_SparseArray_, ptr);
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x00012A3B File Offset: 0x00010C3B
		private static Delegate GetSaveHierarchyState_Landroid_util_SparseArray_Handler()
		{
			if (IDecorToolbarInvoker.cb_saveHierarchyState_Landroid_util_SparseArray_ == null)
			{
				IDecorToolbarInvoker.cb_saveHierarchyState_Landroid_util_SparseArray_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IDecorToolbarInvoker.n_SaveHierarchyState_Landroid_util_SparseArray_));
			}
			return IDecorToolbarInvoker.cb_saveHierarchyState_Landroid_util_SparseArray_;
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x00012A60 File Offset: 0x00010C60
		private static void n_SaveHierarchyState_Landroid_util_SparseArray_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IDecorToolbar @object = Java.Lang.Object.GetObject<IDecorToolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			SparseArray object2 = Java.Lang.Object.GetObject<SparseArray>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.SaveHierarchyState(object2);
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x00012A84 File Offset: 0x00010C84
		public unsafe void SaveHierarchyState(SparseArray p0)
		{
			if (this.id_saveHierarchyState_Landroid_util_SparseArray_ == IntPtr.Zero)
			{
				this.id_saveHierarchyState_Landroid_util_SparseArray_ = JNIEnv.GetMethodID(this.class_ref, "saveHierarchyState", "(Landroid/util/SparseArray;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_saveHierarchyState_Landroid_util_SparseArray_, ptr);
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x00012AF7 File Offset: 0x00010CF7
		private static Delegate GetSetBackgroundDrawable_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (IDecorToolbarInvoker.cb_setBackgroundDrawable_Landroid_graphics_drawable_Drawable_ == null)
			{
				IDecorToolbarInvoker.cb_setBackgroundDrawable_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IDecorToolbarInvoker.n_SetBackgroundDrawable_Landroid_graphics_drawable_Drawable_));
			}
			return IDecorToolbarInvoker.cb_setBackgroundDrawable_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x00012B1C File Offset: 0x00010D1C
		private static void n_SetBackgroundDrawable_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IDecorToolbar @object = Java.Lang.Object.GetObject<IDecorToolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.SetBackgroundDrawable(object2);
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x00012B40 File Offset: 0x00010D40
		public unsafe void SetBackgroundDrawable(Drawable p0)
		{
			if (this.id_setBackgroundDrawable_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
			{
				this.id_setBackgroundDrawable_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID(this.class_ref, "setBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_setBackgroundDrawable_Landroid_graphics_drawable_Drawable_, ptr);
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x00012BB3 File Offset: 0x00010DB3
		private static Delegate GetSetCollapsible_ZHandler()
		{
			if (IDecorToolbarInvoker.cb_setCollapsible_Z == null)
			{
				IDecorToolbarInvoker.cb_setCollapsible_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(IDecorToolbarInvoker.n_SetCollapsible_Z));
			}
			return IDecorToolbarInvoker.cb_setCollapsible_Z;
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x00012BD7 File Offset: 0x00010DD7
		private static void n_SetCollapsible_Z(IntPtr jnienv, IntPtr native__this, bool p0)
		{
			Java.Lang.Object.GetObject<IDecorToolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetCollapsible(p0);
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x00012BE8 File Offset: 0x00010DE8
		public unsafe void SetCollapsible(bool p0)
		{
			if (this.id_setCollapsible_Z == IntPtr.Zero)
			{
				this.id_setCollapsible_Z = JNIEnv.GetMethodID(this.class_ref, "setCollapsible", "(Z)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			JNIEnv.CallVoidMethod(base.Handle, this.id_setCollapsible_Z, ptr);
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x00012C4C File Offset: 0x00010E4C
		private static Delegate GetSetDefaultNavigationContentDescription_IHandler()
		{
			if (IDecorToolbarInvoker.cb_setDefaultNavigationContentDescription_I == null)
			{
				IDecorToolbarInvoker.cb_setDefaultNavigationContentDescription_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(IDecorToolbarInvoker.n_SetDefaultNavigationContentDescription_I));
			}
			return IDecorToolbarInvoker.cb_setDefaultNavigationContentDescription_I;
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x00012C70 File Offset: 0x00010E70
		private static void n_SetDefaultNavigationContentDescription_I(IntPtr jnienv, IntPtr native__this, int p0)
		{
			Java.Lang.Object.GetObject<IDecorToolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetDefaultNavigationContentDescription(p0);
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x00012C80 File Offset: 0x00010E80
		public unsafe void SetDefaultNavigationContentDescription(int p0)
		{
			if (this.id_setDefaultNavigationContentDescription_I == IntPtr.Zero)
			{
				this.id_setDefaultNavigationContentDescription_I = JNIEnv.GetMethodID(this.class_ref, "setDefaultNavigationContentDescription", "(I)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			JNIEnv.CallVoidMethod(base.Handle, this.id_setDefaultNavigationContentDescription_I, ptr);
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x00012CE4 File Offset: 0x00010EE4
		private static Delegate GetSetDefaultNavigationIcon_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (IDecorToolbarInvoker.cb_setDefaultNavigationIcon_Landroid_graphics_drawable_Drawable_ == null)
			{
				IDecorToolbarInvoker.cb_setDefaultNavigationIcon_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IDecorToolbarInvoker.n_SetDefaultNavigationIcon_Landroid_graphics_drawable_Drawable_));
			}
			return IDecorToolbarInvoker.cb_setDefaultNavigationIcon_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x00012D08 File Offset: 0x00010F08
		private static void n_SetDefaultNavigationIcon_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IDecorToolbar @object = Java.Lang.Object.GetObject<IDecorToolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.SetDefaultNavigationIcon(object2);
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x00012D2C File Offset: 0x00010F2C
		public unsafe void SetDefaultNavigationIcon(Drawable p0)
		{
			if (this.id_setDefaultNavigationIcon_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
			{
				this.id_setDefaultNavigationIcon_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID(this.class_ref, "setDefaultNavigationIcon", "(Landroid/graphics/drawable/Drawable;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_setDefaultNavigationIcon_Landroid_graphics_drawable_Drawable_, ptr);
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x00012D9F File Offset: 0x00010F9F
		private static Delegate GetSetDropdownParams_Landroid_widget_SpinnerAdapter_Landroid_widget_AdapterView_OnItemSelectedListener_Handler()
		{
			if (IDecorToolbarInvoker.cb_setDropdownParams_Landroid_widget_SpinnerAdapter_Landroid_widget_AdapterView_OnItemSelectedListener_ == null)
			{
				IDecorToolbarInvoker.cb_setDropdownParams_Landroid_widget_SpinnerAdapter_Landroid_widget_AdapterView_OnItemSelectedListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IDecorToolbarInvoker.n_SetDropdownParams_Landroid_widget_SpinnerAdapter_Landroid_widget_AdapterView_OnItemSelectedListener_));
			}
			return IDecorToolbarInvoker.cb_setDropdownParams_Landroid_widget_SpinnerAdapter_Landroid_widget_AdapterView_OnItemSelectedListener_;
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x00012DC4 File Offset: 0x00010FC4
		private static void n_SetDropdownParams_Landroid_widget_SpinnerAdapter_Landroid_widget_AdapterView_OnItemSelectedListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IDecorToolbar @object = Java.Lang.Object.GetObject<IDecorToolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ISpinnerAdapter object2 = Java.Lang.Object.GetObject<ISpinnerAdapter>(native_p0, JniHandleOwnership.DoNotTransfer);
			AdapterView.IOnItemSelectedListener object3 = Java.Lang.Object.GetObject<AdapterView.IOnItemSelectedListener>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.SetDropdownParams(object2, object3);
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x00012DF0 File Offset: 0x00010FF0
		public unsafe void SetDropdownParams(ISpinnerAdapter p0, AdapterView.IOnItemSelectedListener p1)
		{
			if (this.id_setDropdownParams_Landroid_widget_SpinnerAdapter_Landroid_widget_AdapterView_OnItemSelectedListener_ == IntPtr.Zero)
			{
				this.id_setDropdownParams_Landroid_widget_SpinnerAdapter_Landroid_widget_AdapterView_OnItemSelectedListener_ = JNIEnv.GetMethodID(this.class_ref, "setDropdownParams", "(Landroid/widget/SpinnerAdapter;Landroid/widget/AdapterView$OnItemSelectedListener;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_setDropdownParams_Landroid_widget_SpinnerAdapter_Landroid_widget_AdapterView_OnItemSelectedListener_, ptr);
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x00012E8F File Offset: 0x0001108F
		private static Delegate GetSetEmbeddedTabView_Landroidx_appcompat_widget_ScrollingTabContainerView_Handler()
		{
			if (IDecorToolbarInvoker.cb_setEmbeddedTabView_Landroidx_appcompat_widget_ScrollingTabContainerView_ == null)
			{
				IDecorToolbarInvoker.cb_setEmbeddedTabView_Landroidx_appcompat_widget_ScrollingTabContainerView_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IDecorToolbarInvoker.n_SetEmbeddedTabView_Landroidx_appcompat_widget_ScrollingTabContainerView_));
			}
			return IDecorToolbarInvoker.cb_setEmbeddedTabView_Landroidx_appcompat_widget_ScrollingTabContainerView_;
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x00012EB4 File Offset: 0x000110B4
		private static void n_SetEmbeddedTabView_Landroidx_appcompat_widget_ScrollingTabContainerView_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IDecorToolbar @object = Java.Lang.Object.GetObject<IDecorToolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ScrollingTabContainerView object2 = Java.Lang.Object.GetObject<ScrollingTabContainerView>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.SetEmbeddedTabView(object2);
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x00012ED8 File Offset: 0x000110D8
		public unsafe void SetEmbeddedTabView(ScrollingTabContainerView p0)
		{
			if (this.id_setEmbeddedTabView_Landroidx_appcompat_widget_ScrollingTabContainerView_ == IntPtr.Zero)
			{
				this.id_setEmbeddedTabView_Landroidx_appcompat_widget_ScrollingTabContainerView_ = JNIEnv.GetMethodID(this.class_ref, "setEmbeddedTabView", "(Landroidx/appcompat/widget/ScrollingTabContainerView;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_setEmbeddedTabView_Landroidx_appcompat_widget_ScrollingTabContainerView_, ptr);
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x00012F4B File Offset: 0x0001114B
		private static Delegate GetSetHomeButtonEnabled_ZHandler()
		{
			if (IDecorToolbarInvoker.cb_setHomeButtonEnabled_Z == null)
			{
				IDecorToolbarInvoker.cb_setHomeButtonEnabled_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(IDecorToolbarInvoker.n_SetHomeButtonEnabled_Z));
			}
			return IDecorToolbarInvoker.cb_setHomeButtonEnabled_Z;
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x00012F6F File Offset: 0x0001116F
		private static void n_SetHomeButtonEnabled_Z(IntPtr jnienv, IntPtr native__this, bool p0)
		{
			Java.Lang.Object.GetObject<IDecorToolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetHomeButtonEnabled(p0);
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x00012F80 File Offset: 0x00011180
		public unsafe void SetHomeButtonEnabled(bool p0)
		{
			if (this.id_setHomeButtonEnabled_Z == IntPtr.Zero)
			{
				this.id_setHomeButtonEnabled_Z = JNIEnv.GetMethodID(this.class_ref, "setHomeButtonEnabled", "(Z)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			JNIEnv.CallVoidMethod(base.Handle, this.id_setHomeButtonEnabled_Z, ptr);
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x00012FE4 File Offset: 0x000111E4
		private static Delegate GetSetIcon_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (IDecorToolbarInvoker.cb_setIcon_Landroid_graphics_drawable_Drawable_ == null)
			{
				IDecorToolbarInvoker.cb_setIcon_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IDecorToolbarInvoker.n_SetIcon_Landroid_graphics_drawable_Drawable_));
			}
			return IDecorToolbarInvoker.cb_setIcon_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x00013008 File Offset: 0x00011208
		private static void n_SetIcon_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IDecorToolbar @object = Java.Lang.Object.GetObject<IDecorToolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.SetIcon(object2);
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x0001302C File Offset: 0x0001122C
		public unsafe void SetIcon(Drawable p0)
		{
			if (this.id_setIcon_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
			{
				this.id_setIcon_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID(this.class_ref, "setIcon", "(Landroid/graphics/drawable/Drawable;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_setIcon_Landroid_graphics_drawable_Drawable_, ptr);
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x0001309F File Offset: 0x0001129F
		private static Delegate GetSetIcon_IHandler()
		{
			if (IDecorToolbarInvoker.cb_setIcon_I == null)
			{
				IDecorToolbarInvoker.cb_setIcon_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(IDecorToolbarInvoker.n_SetIcon_I));
			}
			return IDecorToolbarInvoker.cb_setIcon_I;
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x000130C3 File Offset: 0x000112C3
		private static void n_SetIcon_I(IntPtr jnienv, IntPtr native__this, int p0)
		{
			Java.Lang.Object.GetObject<IDecorToolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetIcon(p0);
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x000130D4 File Offset: 0x000112D4
		public unsafe void SetIcon(int p0)
		{
			if (this.id_setIcon_I == IntPtr.Zero)
			{
				this.id_setIcon_I = JNIEnv.GetMethodID(this.class_ref, "setIcon", "(I)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			JNIEnv.CallVoidMethod(base.Handle, this.id_setIcon_I, ptr);
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x00013138 File Offset: 0x00011338
		private static Delegate GetSetLogo_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (IDecorToolbarInvoker.cb_setLogo_Landroid_graphics_drawable_Drawable_ == null)
			{
				IDecorToolbarInvoker.cb_setLogo_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IDecorToolbarInvoker.n_SetLogo_Landroid_graphics_drawable_Drawable_));
			}
			return IDecorToolbarInvoker.cb_setLogo_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x0001315C File Offset: 0x0001135C
		private static void n_SetLogo_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IDecorToolbar @object = Java.Lang.Object.GetObject<IDecorToolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.SetLogo(object2);
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x00013180 File Offset: 0x00011380
		public unsafe void SetLogo(Drawable p0)
		{
			if (this.id_setLogo_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
			{
				this.id_setLogo_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID(this.class_ref, "setLogo", "(Landroid/graphics/drawable/Drawable;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_setLogo_Landroid_graphics_drawable_Drawable_, ptr);
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x000131F3 File Offset: 0x000113F3
		private static Delegate GetSetLogo_IHandler()
		{
			if (IDecorToolbarInvoker.cb_setLogo_I == null)
			{
				IDecorToolbarInvoker.cb_setLogo_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(IDecorToolbarInvoker.n_SetLogo_I));
			}
			return IDecorToolbarInvoker.cb_setLogo_I;
		}

		// Token: 0x0600075C RID: 1884 RVA: 0x00013217 File Offset: 0x00011417
		private static void n_SetLogo_I(IntPtr jnienv, IntPtr native__this, int p0)
		{
			Java.Lang.Object.GetObject<IDecorToolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetLogo(p0);
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x00013228 File Offset: 0x00011428
		public unsafe void SetLogo(int p0)
		{
			if (this.id_setLogo_I == IntPtr.Zero)
			{
				this.id_setLogo_I = JNIEnv.GetMethodID(this.class_ref, "setLogo", "(I)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			JNIEnv.CallVoidMethod(base.Handle, this.id_setLogo_I, ptr);
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x0001328C File Offset: 0x0001148C
		private static Delegate GetSetMenu_Landroid_view_Menu_Landroidx_appcompat_view_menu_MenuPresenter_Callback_Handler()
		{
			if (IDecorToolbarInvoker.cb_setMenu_Landroid_view_Menu_Landroidx_appcompat_view_menu_MenuPresenter_Callback_ == null)
			{
				IDecorToolbarInvoker.cb_setMenu_Landroid_view_Menu_Landroidx_appcompat_view_menu_MenuPresenter_Callback_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IDecorToolbarInvoker.n_SetMenu_Landroid_view_Menu_Landroidx_appcompat_view_menu_MenuPresenter_Callback_));
			}
			return IDecorToolbarInvoker.cb_setMenu_Landroid_view_Menu_Landroidx_appcompat_view_menu_MenuPresenter_Callback_;
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x000132B0 File Offset: 0x000114B0
		private static void n_SetMenu_Landroid_view_Menu_Landroidx_appcompat_view_menu_MenuPresenter_Callback_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IDecorToolbar @object = Java.Lang.Object.GetObject<IDecorToolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMenu object2 = Java.Lang.Object.GetObject<IMenu>(native_p0, JniHandleOwnership.DoNotTransfer);
			IMenuPresenterCallback object3 = Java.Lang.Object.GetObject<IMenuPresenterCallback>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.SetMenu(object2, object3);
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x000132DC File Offset: 0x000114DC
		public unsafe void SetMenu(IMenu p0, IMenuPresenterCallback p1)
		{
			if (this.id_setMenu_Landroid_view_Menu_Landroidx_appcompat_view_menu_MenuPresenter_Callback_ == IntPtr.Zero)
			{
				this.id_setMenu_Landroid_view_Menu_Landroidx_appcompat_view_menu_MenuPresenter_Callback_ = JNIEnv.GetMethodID(this.class_ref, "setMenu", "(Landroid/view/Menu;Landroidx/appcompat/view/menu/MenuPresenter$Callback;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_setMenu_Landroid_view_Menu_Landroidx_appcompat_view_menu_MenuPresenter_Callback_, ptr);
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x0001337B File Offset: 0x0001157B
		private static Delegate GetSetMenuCallbacks_Landroidx_appcompat_view_menu_MenuPresenter_Callback_Landroidx_appcompat_view_menu_MenuBuilder_Callback_Handler()
		{
			if (IDecorToolbarInvoker.cb_setMenuCallbacks_Landroidx_appcompat_view_menu_MenuPresenter_Callback_Landroidx_appcompat_view_menu_MenuBuilder_Callback_ == null)
			{
				IDecorToolbarInvoker.cb_setMenuCallbacks_Landroidx_appcompat_view_menu_MenuPresenter_Callback_Landroidx_appcompat_view_menu_MenuBuilder_Callback_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IDecorToolbarInvoker.n_SetMenuCallbacks_Landroidx_appcompat_view_menu_MenuPresenter_Callback_Landroidx_appcompat_view_menu_MenuBuilder_Callback_));
			}
			return IDecorToolbarInvoker.cb_setMenuCallbacks_Landroidx_appcompat_view_menu_MenuPresenter_Callback_Landroidx_appcompat_view_menu_MenuBuilder_Callback_;
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x000133A0 File Offset: 0x000115A0
		private static void n_SetMenuCallbacks_Landroidx_appcompat_view_menu_MenuPresenter_Callback_Landroidx_appcompat_view_menu_MenuBuilder_Callback_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IDecorToolbar @object = Java.Lang.Object.GetObject<IDecorToolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMenuPresenterCallback object2 = Java.Lang.Object.GetObject<IMenuPresenterCallback>(native_p0, JniHandleOwnership.DoNotTransfer);
			MenuBuilder.ICallback object3 = Java.Lang.Object.GetObject<MenuBuilder.ICallback>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.SetMenuCallbacks(object2, object3);
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x000133CC File Offset: 0x000115CC
		public unsafe void SetMenuCallbacks(IMenuPresenterCallback p0, MenuBuilder.ICallback p1)
		{
			if (this.id_setMenuCallbacks_Landroidx_appcompat_view_menu_MenuPresenter_Callback_Landroidx_appcompat_view_menu_MenuBuilder_Callback_ == IntPtr.Zero)
			{
				this.id_setMenuCallbacks_Landroidx_appcompat_view_menu_MenuPresenter_Callback_Landroidx_appcompat_view_menu_MenuBuilder_Callback_ = JNIEnv.GetMethodID(this.class_ref, "setMenuCallbacks", "(Landroidx/appcompat/view/menu/MenuPresenter$Callback;Landroidx/appcompat/view/menu/MenuBuilder$Callback;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_setMenuCallbacks_Landroidx_appcompat_view_menu_MenuPresenter_Callback_Landroidx_appcompat_view_menu_MenuBuilder_Callback_, ptr);
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x0001346B File Offset: 0x0001166B
		private static Delegate GetSetMenuPreparedHandler()
		{
			if (IDecorToolbarInvoker.cb_setMenuPrepared == null)
			{
				IDecorToolbarInvoker.cb_setMenuPrepared = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IDecorToolbarInvoker.n_SetMenuPrepared));
			}
			return IDecorToolbarInvoker.cb_setMenuPrepared;
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x0001348F File Offset: 0x0001168F
		private static void n_SetMenuPrepared(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IDecorToolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetMenuPrepared();
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x0001349E File Offset: 0x0001169E
		public void SetMenuPrepared()
		{
			if (this.id_setMenuPrepared == IntPtr.Zero)
			{
				this.id_setMenuPrepared = JNIEnv.GetMethodID(this.class_ref, "setMenuPrepared", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_setMenuPrepared);
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x000134DE File Offset: 0x000116DE
		private static Delegate GetSetNavigationContentDescription_IHandler()
		{
			if (IDecorToolbarInvoker.cb_setNavigationContentDescription_I == null)
			{
				IDecorToolbarInvoker.cb_setNavigationContentDescription_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(IDecorToolbarInvoker.n_SetNavigationContentDescription_I));
			}
			return IDecorToolbarInvoker.cb_setNavigationContentDescription_I;
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x00013502 File Offset: 0x00011702
		private static void n_SetNavigationContentDescription_I(IntPtr jnienv, IntPtr native__this, int p0)
		{
			Java.Lang.Object.GetObject<IDecorToolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetNavigationContentDescription(p0);
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x00013514 File Offset: 0x00011714
		public unsafe void SetNavigationContentDescription(int p0)
		{
			if (this.id_setNavigationContentDescription_I == IntPtr.Zero)
			{
				this.id_setNavigationContentDescription_I = JNIEnv.GetMethodID(this.class_ref, "setNavigationContentDescription", "(I)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			JNIEnv.CallVoidMethod(base.Handle, this.id_setNavigationContentDescription_I, ptr);
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x00013578 File Offset: 0x00011778
		private static Delegate GetSetNavigationContentDescription_Ljava_lang_CharSequence_Handler()
		{
			if (IDecorToolbarInvoker.cb_setNavigationContentDescription_Ljava_lang_CharSequence_ == null)
			{
				IDecorToolbarInvoker.cb_setNavigationContentDescription_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IDecorToolbarInvoker.n_SetNavigationContentDescription_Ljava_lang_CharSequence_));
			}
			return IDecorToolbarInvoker.cb_setNavigationContentDescription_Ljava_lang_CharSequence_;
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x0001359C File Offset: 0x0001179C
		private static void n_SetNavigationContentDescription_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IDecorToolbar @object = Java.Lang.Object.GetObject<IDecorToolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.SetNavigationContentDescription(object2);
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x000135C0 File Offset: 0x000117C0
		public unsafe void SetNavigationContentDescription(ICharSequence p0)
		{
			if (this.id_setNavigationContentDescription_Ljava_lang_CharSequence_ == IntPtr.Zero)
			{
				this.id_setNavigationContentDescription_Ljava_lang_CharSequence_ = JNIEnv.GetMethodID(this.class_ref, "setNavigationContentDescription", "(Ljava/lang/CharSequence;)V");
			}
			IntPtr intPtr = CharSequence.ToLocalJniHandle(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_setNavigationContentDescription_Ljava_lang_CharSequence_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x00013631 File Offset: 0x00011831
		private static Delegate GetSetNavigationIcon_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (IDecorToolbarInvoker.cb_setNavigationIcon_Landroid_graphics_drawable_Drawable_ == null)
			{
				IDecorToolbarInvoker.cb_setNavigationIcon_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IDecorToolbarInvoker.n_SetNavigationIcon_Landroid_graphics_drawable_Drawable_));
			}
			return IDecorToolbarInvoker.cb_setNavigationIcon_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x00013658 File Offset: 0x00011858
		private static void n_SetNavigationIcon_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IDecorToolbar @object = Java.Lang.Object.GetObject<IDecorToolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.SetNavigationIcon(object2);
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x0001367C File Offset: 0x0001187C
		public unsafe void SetNavigationIcon(Drawable p0)
		{
			if (this.id_setNavigationIcon_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
			{
				this.id_setNavigationIcon_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID(this.class_ref, "setNavigationIcon", "(Landroid/graphics/drawable/Drawable;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_setNavigationIcon_Landroid_graphics_drawable_Drawable_, ptr);
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x000136EF File Offset: 0x000118EF
		private static Delegate GetSetNavigationIcon_IHandler()
		{
			if (IDecorToolbarInvoker.cb_setNavigationIcon_I == null)
			{
				IDecorToolbarInvoker.cb_setNavigationIcon_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(IDecorToolbarInvoker.n_SetNavigationIcon_I));
			}
			return IDecorToolbarInvoker.cb_setNavigationIcon_I;
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x00013713 File Offset: 0x00011913
		private static void n_SetNavigationIcon_I(IntPtr jnienv, IntPtr native__this, int p0)
		{
			Java.Lang.Object.GetObject<IDecorToolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetNavigationIcon(p0);
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x00013724 File Offset: 0x00011924
		public unsafe void SetNavigationIcon(int p0)
		{
			if (this.id_setNavigationIcon_I == IntPtr.Zero)
			{
				this.id_setNavigationIcon_I = JNIEnv.GetMethodID(this.class_ref, "setNavigationIcon", "(I)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			JNIEnv.CallVoidMethod(base.Handle, this.id_setNavigationIcon_I, ptr);
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x00013788 File Offset: 0x00011988
		private static Delegate GetSetWindowCallback_Landroid_view_Window_Callback_Handler()
		{
			if (IDecorToolbarInvoker.cb_setWindowCallback_Landroid_view_Window_Callback_ == null)
			{
				IDecorToolbarInvoker.cb_setWindowCallback_Landroid_view_Window_Callback_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IDecorToolbarInvoker.n_SetWindowCallback_Landroid_view_Window_Callback_));
			}
			return IDecorToolbarInvoker.cb_setWindowCallback_Landroid_view_Window_Callback_;
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x000137AC File Offset: 0x000119AC
		private static void n_SetWindowCallback_Landroid_view_Window_Callback_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IDecorToolbar @object = Java.Lang.Object.GetObject<IDecorToolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Window.ICallback object2 = Java.Lang.Object.GetObject<Window.ICallback>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.SetWindowCallback(object2);
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x000137D0 File Offset: 0x000119D0
		public unsafe void SetWindowCallback(Window.ICallback p0)
		{
			if (this.id_setWindowCallback_Landroid_view_Window_Callback_ == IntPtr.Zero)
			{
				this.id_setWindowCallback_Landroid_view_Window_Callback_ = JNIEnv.GetMethodID(this.class_ref, "setWindowCallback", "(Landroid/view/Window$Callback;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_setWindowCallback_Landroid_view_Window_Callback_, ptr);
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x00013848 File Offset: 0x00011A48
		private static Delegate GetSetWindowTitle_Ljava_lang_CharSequence_Handler()
		{
			if (IDecorToolbarInvoker.cb_setWindowTitle_Ljava_lang_CharSequence_ == null)
			{
				IDecorToolbarInvoker.cb_setWindowTitle_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IDecorToolbarInvoker.n_SetWindowTitle_Ljava_lang_CharSequence_));
			}
			return IDecorToolbarInvoker.cb_setWindowTitle_Ljava_lang_CharSequence_;
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x0001386C File Offset: 0x00011A6C
		private static void n_SetWindowTitle_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IDecorToolbar @object = Java.Lang.Object.GetObject<IDecorToolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.SetWindowTitle(object2);
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x00013890 File Offset: 0x00011A90
		public unsafe void SetWindowTitle(ICharSequence p0)
		{
			if (this.id_setWindowTitle_Ljava_lang_CharSequence_ == IntPtr.Zero)
			{
				this.id_setWindowTitle_Ljava_lang_CharSequence_ = JNIEnv.GetMethodID(this.class_ref, "setWindowTitle", "(Ljava/lang/CharSequence;)V");
			}
			IntPtr intPtr = CharSequence.ToLocalJniHandle(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_setWindowTitle_Ljava_lang_CharSequence_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x00013901 File Offset: 0x00011B01
		private static Delegate GetSetupAnimatorToVisibility_IJHandler()
		{
			if (IDecorToolbarInvoker.cb_setupAnimatorToVisibility_IJ == null)
			{
				IDecorToolbarInvoker.cb_setupAnimatorToVisibility_IJ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIJ_L(IDecorToolbarInvoker.n_SetupAnimatorToVisibility_IJ));
			}
			return IDecorToolbarInvoker.cb_setupAnimatorToVisibility_IJ;
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x00013925 File Offset: 0x00011B25
		private static IntPtr n_SetupAnimatorToVisibility_IJ(IntPtr jnienv, IntPtr native__this, int p0, long p1)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IDecorToolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetupAnimatorToVisibility(p0, p1));
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x0001393C File Offset: 0x00011B3C
		public unsafe ViewPropertyAnimatorCompat SetupAnimatorToVisibility(int p0, long p1)
		{
			if (this.id_setupAnimatorToVisibility_IJ == IntPtr.Zero)
			{
				this.id_setupAnimatorToVisibility_IJ = JNIEnv.GetMethodID(this.class_ref, "setupAnimatorToVisibility", "(IJ)Landroidx/core/view/ViewPropertyAnimatorCompat;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			ptr[1] = new JValue(p1);
			return Java.Lang.Object.GetObject<ViewPropertyAnimatorCompat>(JNIEnv.CallObjectMethod(base.Handle, this.id_setupAnimatorToVisibility_IJ, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x000139B9 File Offset: 0x00011BB9
		private static Delegate GetShowOverflowMenuHandler()
		{
			if (IDecorToolbarInvoker.cb_showOverflowMenu == null)
			{
				IDecorToolbarInvoker.cb_showOverflowMenu = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IDecorToolbarInvoker.n_ShowOverflowMenu));
			}
			return IDecorToolbarInvoker.cb_showOverflowMenu;
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x000139DD File Offset: 0x00011BDD
		private static bool n_ShowOverflowMenu(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IDecorToolbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ShowOverflowMenu();
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x000139EC File Offset: 0x00011BEC
		public bool ShowOverflowMenu()
		{
			if (this.id_showOverflowMenu == IntPtr.Zero)
			{
				this.id_showOverflowMenu = JNIEnv.GetMethodID(this.class_ref, "showOverflowMenu", "()Z");
			}
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_showOverflowMenu);
		}

		// Token: 0x040001AB RID: 427
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/appcompat/widget/DecorToolbar", typeof(IDecorToolbarInvoker));

		// Token: 0x040001AC RID: 428
		private IntPtr class_ref;

		// Token: 0x040001AD RID: 429
		private static Delegate cb_getContext;

		// Token: 0x040001AE RID: 430
		private IntPtr id_getContext;

		// Token: 0x040001AF RID: 431
		private static Delegate cb_getCustomView;

		// Token: 0x040001B0 RID: 432
		private static Delegate cb_setCustomView_Landroid_view_View_;

		// Token: 0x040001B1 RID: 433
		private IntPtr id_getCustomView;

		// Token: 0x040001B2 RID: 434
		private IntPtr id_setCustomView_Landroid_view_View_;

		// Token: 0x040001B3 RID: 435
		private static Delegate cb_getDisplayOptions;

		// Token: 0x040001B4 RID: 436
		private static Delegate cb_setDisplayOptions_I;

		// Token: 0x040001B5 RID: 437
		private IntPtr id_getDisplayOptions;

		// Token: 0x040001B6 RID: 438
		private IntPtr id_setDisplayOptions_I;

		// Token: 0x040001B7 RID: 439
		private static Delegate cb_getDropdownItemCount;

		// Token: 0x040001B8 RID: 440
		private IntPtr id_getDropdownItemCount;

		// Token: 0x040001B9 RID: 441
		private static Delegate cb_getDropdownSelectedPosition;

		// Token: 0x040001BA RID: 442
		private static Delegate cb_setDropdownSelectedPosition_I;

		// Token: 0x040001BB RID: 443
		private IntPtr id_getDropdownSelectedPosition;

		// Token: 0x040001BC RID: 444
		private IntPtr id_setDropdownSelectedPosition_I;

		// Token: 0x040001BD RID: 445
		private static Delegate cb_hasEmbeddedTabs;

		// Token: 0x040001BE RID: 446
		private IntPtr id_hasEmbeddedTabs;

		// Token: 0x040001BF RID: 447
		private static Delegate cb_hasExpandedActionView;

		// Token: 0x040001C0 RID: 448
		private IntPtr id_hasExpandedActionView;

		// Token: 0x040001C1 RID: 449
		private static Delegate cb_hasIcon;

		// Token: 0x040001C2 RID: 450
		private IntPtr id_hasIcon;

		// Token: 0x040001C3 RID: 451
		private static Delegate cb_hasLogo;

		// Token: 0x040001C4 RID: 452
		private IntPtr id_hasLogo;

		// Token: 0x040001C5 RID: 453
		private static Delegate cb_getHeight;

		// Token: 0x040001C6 RID: 454
		private IntPtr id_getHeight;

		// Token: 0x040001C7 RID: 455
		private static Delegate cb_isOverflowMenuShowPending;

		// Token: 0x040001C8 RID: 456
		private IntPtr id_isOverflowMenuShowPending;

		// Token: 0x040001C9 RID: 457
		private static Delegate cb_isOverflowMenuShowing;

		// Token: 0x040001CA RID: 458
		private IntPtr id_isOverflowMenuShowing;

		// Token: 0x040001CB RID: 459
		private static Delegate cb_isTitleTruncated;

		// Token: 0x040001CC RID: 460
		private IntPtr id_isTitleTruncated;

		// Token: 0x040001CD RID: 461
		private static Delegate cb_getMenu;

		// Token: 0x040001CE RID: 462
		private IntPtr id_getMenu;

		// Token: 0x040001CF RID: 463
		private static Delegate cb_getNavigationMode;

		// Token: 0x040001D0 RID: 464
		private static Delegate cb_setNavigationMode_I;

		// Token: 0x040001D1 RID: 465
		private IntPtr id_getNavigationMode;

		// Token: 0x040001D2 RID: 466
		private IntPtr id_setNavigationMode_I;

		// Token: 0x040001D3 RID: 467
		private static Delegate cb_getSubtitle;

		// Token: 0x040001D4 RID: 468
		private static Delegate cb_setSubtitle_Ljava_lang_CharSequence_;

		// Token: 0x040001D5 RID: 469
		private IntPtr id_getSubtitle;

		// Token: 0x040001D6 RID: 470
		private IntPtr id_setSubtitle_Ljava_lang_CharSequence_;

		// Token: 0x040001D7 RID: 471
		private static Delegate cb_getTitle;

		// Token: 0x040001D8 RID: 472
		private static Delegate cb_setTitle_Ljava_lang_CharSequence_;

		// Token: 0x040001D9 RID: 473
		private IntPtr id_getTitle;

		// Token: 0x040001DA RID: 474
		private IntPtr id_setTitle_Ljava_lang_CharSequence_;

		// Token: 0x040001DB RID: 475
		private static Delegate cb_getViewGroup;

		// Token: 0x040001DC RID: 476
		private IntPtr id_getViewGroup;

		// Token: 0x040001DD RID: 477
		private static Delegate cb_getVisibility;

		// Token: 0x040001DE RID: 478
		private static Delegate cb_setVisibility_I;

		// Token: 0x040001DF RID: 479
		private IntPtr id_getVisibility;

		// Token: 0x040001E0 RID: 480
		private IntPtr id_setVisibility_I;

		// Token: 0x040001E1 RID: 481
		private static Delegate cb_animateToVisibility_I;

		// Token: 0x040001E2 RID: 482
		private IntPtr id_animateToVisibility_I;

		// Token: 0x040001E3 RID: 483
		private static Delegate cb_canShowOverflowMenu;

		// Token: 0x040001E4 RID: 484
		private IntPtr id_canShowOverflowMenu;

		// Token: 0x040001E5 RID: 485
		private static Delegate cb_collapseActionView;

		// Token: 0x040001E6 RID: 486
		private IntPtr id_collapseActionView;

		// Token: 0x040001E7 RID: 487
		private static Delegate cb_dismissPopupMenus;

		// Token: 0x040001E8 RID: 488
		private IntPtr id_dismissPopupMenus;

		// Token: 0x040001E9 RID: 489
		private static Delegate cb_hideOverflowMenu;

		// Token: 0x040001EA RID: 490
		private IntPtr id_hideOverflowMenu;

		// Token: 0x040001EB RID: 491
		private static Delegate cb_initIndeterminateProgress;

		// Token: 0x040001EC RID: 492
		private IntPtr id_initIndeterminateProgress;

		// Token: 0x040001ED RID: 493
		private static Delegate cb_initProgress;

		// Token: 0x040001EE RID: 494
		private IntPtr id_initProgress;

		// Token: 0x040001EF RID: 495
		private static Delegate cb_restoreHierarchyState_Landroid_util_SparseArray_;

		// Token: 0x040001F0 RID: 496
		private IntPtr id_restoreHierarchyState_Landroid_util_SparseArray_;

		// Token: 0x040001F1 RID: 497
		private static Delegate cb_saveHierarchyState_Landroid_util_SparseArray_;

		// Token: 0x040001F2 RID: 498
		private IntPtr id_saveHierarchyState_Landroid_util_SparseArray_;

		// Token: 0x040001F3 RID: 499
		private static Delegate cb_setBackgroundDrawable_Landroid_graphics_drawable_Drawable_;

		// Token: 0x040001F4 RID: 500
		private IntPtr id_setBackgroundDrawable_Landroid_graphics_drawable_Drawable_;

		// Token: 0x040001F5 RID: 501
		private static Delegate cb_setCollapsible_Z;

		// Token: 0x040001F6 RID: 502
		private IntPtr id_setCollapsible_Z;

		// Token: 0x040001F7 RID: 503
		private static Delegate cb_setDefaultNavigationContentDescription_I;

		// Token: 0x040001F8 RID: 504
		private IntPtr id_setDefaultNavigationContentDescription_I;

		// Token: 0x040001F9 RID: 505
		private static Delegate cb_setDefaultNavigationIcon_Landroid_graphics_drawable_Drawable_;

		// Token: 0x040001FA RID: 506
		private IntPtr id_setDefaultNavigationIcon_Landroid_graphics_drawable_Drawable_;

		// Token: 0x040001FB RID: 507
		private static Delegate cb_setDropdownParams_Landroid_widget_SpinnerAdapter_Landroid_widget_AdapterView_OnItemSelectedListener_;

		// Token: 0x040001FC RID: 508
		private IntPtr id_setDropdownParams_Landroid_widget_SpinnerAdapter_Landroid_widget_AdapterView_OnItemSelectedListener_;

		// Token: 0x040001FD RID: 509
		private static Delegate cb_setEmbeddedTabView_Landroidx_appcompat_widget_ScrollingTabContainerView_;

		// Token: 0x040001FE RID: 510
		private IntPtr id_setEmbeddedTabView_Landroidx_appcompat_widget_ScrollingTabContainerView_;

		// Token: 0x040001FF RID: 511
		private static Delegate cb_setHomeButtonEnabled_Z;

		// Token: 0x04000200 RID: 512
		private IntPtr id_setHomeButtonEnabled_Z;

		// Token: 0x04000201 RID: 513
		private static Delegate cb_setIcon_Landroid_graphics_drawable_Drawable_;

		// Token: 0x04000202 RID: 514
		private IntPtr id_setIcon_Landroid_graphics_drawable_Drawable_;

		// Token: 0x04000203 RID: 515
		private static Delegate cb_setIcon_I;

		// Token: 0x04000204 RID: 516
		private IntPtr id_setIcon_I;

		// Token: 0x04000205 RID: 517
		private static Delegate cb_setLogo_Landroid_graphics_drawable_Drawable_;

		// Token: 0x04000206 RID: 518
		private IntPtr id_setLogo_Landroid_graphics_drawable_Drawable_;

		// Token: 0x04000207 RID: 519
		private static Delegate cb_setLogo_I;

		// Token: 0x04000208 RID: 520
		private IntPtr id_setLogo_I;

		// Token: 0x04000209 RID: 521
		private static Delegate cb_setMenu_Landroid_view_Menu_Landroidx_appcompat_view_menu_MenuPresenter_Callback_;

		// Token: 0x0400020A RID: 522
		private IntPtr id_setMenu_Landroid_view_Menu_Landroidx_appcompat_view_menu_MenuPresenter_Callback_;

		// Token: 0x0400020B RID: 523
		private static Delegate cb_setMenuCallbacks_Landroidx_appcompat_view_menu_MenuPresenter_Callback_Landroidx_appcompat_view_menu_MenuBuilder_Callback_;

		// Token: 0x0400020C RID: 524
		private IntPtr id_setMenuCallbacks_Landroidx_appcompat_view_menu_MenuPresenter_Callback_Landroidx_appcompat_view_menu_MenuBuilder_Callback_;

		// Token: 0x0400020D RID: 525
		private static Delegate cb_setMenuPrepared;

		// Token: 0x0400020E RID: 526
		private IntPtr id_setMenuPrepared;

		// Token: 0x0400020F RID: 527
		private static Delegate cb_setNavigationContentDescription_I;

		// Token: 0x04000210 RID: 528
		private IntPtr id_setNavigationContentDescription_I;

		// Token: 0x04000211 RID: 529
		private static Delegate cb_setNavigationContentDescription_Ljava_lang_CharSequence_;

		// Token: 0x04000212 RID: 530
		private IntPtr id_setNavigationContentDescription_Ljava_lang_CharSequence_;

		// Token: 0x04000213 RID: 531
		private static Delegate cb_setNavigationIcon_Landroid_graphics_drawable_Drawable_;

		// Token: 0x04000214 RID: 532
		private IntPtr id_setNavigationIcon_Landroid_graphics_drawable_Drawable_;

		// Token: 0x04000215 RID: 533
		private static Delegate cb_setNavigationIcon_I;

		// Token: 0x04000216 RID: 534
		private IntPtr id_setNavigationIcon_I;

		// Token: 0x04000217 RID: 535
		private static Delegate cb_setWindowCallback_Landroid_view_Window_Callback_;

		// Token: 0x04000218 RID: 536
		private IntPtr id_setWindowCallback_Landroid_view_Window_Callback_;

		// Token: 0x04000219 RID: 537
		private static Delegate cb_setWindowTitle_Ljava_lang_CharSequence_;

		// Token: 0x0400021A RID: 538
		private IntPtr id_setWindowTitle_Ljava_lang_CharSequence_;

		// Token: 0x0400021B RID: 539
		private static Delegate cb_setupAnimatorToVisibility_IJ;

		// Token: 0x0400021C RID: 540
		private IntPtr id_setupAnimatorToVisibility_IJ;

		// Token: 0x0400021D RID: 541
		private static Delegate cb_showOverflowMenu;

		// Token: 0x0400021E RID: 542
		private IntPtr id_showOverflowMenu;
	}
}
