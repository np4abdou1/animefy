using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Android.Views;
using AndroidX.ViewPager.Widget;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Fragment.App
{
	// Token: 0x02000044 RID: 68
	[Register("androidx/fragment/app/FragmentStatePagerAdapter", DoNotGenerateAcw = true)]
	public abstract class FragmentStatePagerAdapter : PagerAdapter
	{
		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000394 RID: 916 RVA: 0x0000B9BC File Offset: 0x00009BBC
		internal static IntPtr class_ref
		{
			get
			{
				return FragmentStatePagerAdapter._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000395 RID: 917 RVA: 0x0000B9E0 File Offset: 0x00009BE0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return FragmentStatePagerAdapter._members;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000396 RID: 918 RVA: 0x0000B9E8 File Offset: 0x00009BE8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return FragmentStatePagerAdapter._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000397 RID: 919 RVA: 0x0000BA0C File Offset: 0x00009C0C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return FragmentStatePagerAdapter._members.ManagedPeerType;
			}
		}

		// Token: 0x06000398 RID: 920 RVA: 0x0000BA18 File Offset: 0x00009C18
		protected FragmentStatePagerAdapter(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000399 RID: 921 RVA: 0x0000BA24 File Offset: 0x00009C24
		[Register(".ctor", "(Landroidx/fragment/app/FragmentManager;)V", "")]
		public unsafe FragmentStatePagerAdapter(FragmentManager fm) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((fm == null) ? IntPtr.Zero : fm.Handle);
				base.SetHandle(FragmentStatePagerAdapter._members.InstanceMethods.StartCreateInstance("(Landroidx/fragment/app/FragmentManager;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				FragmentStatePagerAdapter._members.InstanceMethods.FinishCreateInstance("(Landroidx/fragment/app/FragmentManager;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(fm);
			}
		}

		// Token: 0x0600039A RID: 922 RVA: 0x0000BAD4 File Offset: 0x00009CD4
		[Register(".ctor", "(Landroidx/fragment/app/FragmentManager;I)V", "")]
		public unsafe FragmentStatePagerAdapter(FragmentManager fm, int behavior) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((fm == null) ? IntPtr.Zero : fm.Handle);
				ptr[1] = new JniArgumentValue(behavior);
				base.SetHandle(FragmentStatePagerAdapter._members.InstanceMethods.StartCreateInstance("(Landroidx/fragment/app/FragmentManager;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				FragmentStatePagerAdapter._members.InstanceMethods.FinishCreateInstance("(Landroidx/fragment/app/FragmentManager;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(fm);
			}
		}

		// Token: 0x0600039B RID: 923 RVA: 0x0000BB94 File Offset: 0x00009D94
		private static Delegate GetGetItem_IHandler()
		{
			if (FragmentStatePagerAdapter.cb_getItem_I == null)
			{
				FragmentStatePagerAdapter.cb_getItem_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(FragmentStatePagerAdapter.n_GetItem_I));
			}
			return FragmentStatePagerAdapter.cb_getItem_I;
		}

		// Token: 0x0600039C RID: 924 RVA: 0x0000BBB8 File Offset: 0x00009DB8
		private static IntPtr n_GetItem_I(IntPtr jnienv, IntPtr native__this, int position)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<FragmentStatePagerAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetItem(position));
		}

		// Token: 0x0600039D RID: 925
		[Register("getItem", "(I)Landroidx/fragment/app/Fragment;", "GetGetItem_IHandler")]
		public abstract Fragment GetItem(int position);

		// Token: 0x0600039E RID: 926 RVA: 0x0000BBCD File Offset: 0x00009DCD
		private static Delegate GetIsViewFromObject_Landroid_view_View_Ljava_lang_Object_Handler()
		{
			if (FragmentStatePagerAdapter.cb_isViewFromObject_Landroid_view_View_Ljava_lang_Object_ == null)
			{
				FragmentStatePagerAdapter.cb_isViewFromObject_Landroid_view_View_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_Z(FragmentStatePagerAdapter.n_IsViewFromObject_Landroid_view_View_Ljava_lang_Object_));
			}
			return FragmentStatePagerAdapter.cb_isViewFromObject_Landroid_view_View_Ljava_lang_Object_;
		}

		// Token: 0x0600039F RID: 927 RVA: 0x0000BBF4 File Offset: 0x00009DF4
		private static bool n_IsViewFromObject_Landroid_view_View_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_view, IntPtr native__object)
		{
			PagerAdapter @object = Java.Lang.Object.GetObject<FragmentStatePagerAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_view, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native__object, JniHandleOwnership.DoNotTransfer);
			return @object.IsViewFromObject(object2, object3);
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x0000BC20 File Offset: 0x00009E20
		[Register("isViewFromObject", "(Landroid/view/View;Ljava/lang/Object;)Z", "GetIsViewFromObject_Landroid_view_View_Ljava_lang_Object_Handler")]
		public unsafe override bool IsViewFromObject(View view, Java.Lang.Object @object)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
				ptr[1] = new JniArgumentValue((@object == null) ? IntPtr.Zero : @object.Handle);
				result = FragmentStatePagerAdapter._members.InstanceMethods.InvokeVirtualBooleanMethod("isViewFromObject.(Landroid/view/View;Ljava/lang/Object;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(view);
				GC.KeepAlive(@object);
			}
			return result;
		}

		// Token: 0x040000F1 RID: 241
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/fragment/app/FragmentStatePagerAdapter", typeof(FragmentStatePagerAdapter));

		// Token: 0x040000F2 RID: 242
		private static Delegate cb_getItem_I;

		// Token: 0x040000F3 RID: 243
		private static Delegate cb_isViewFromObject_Landroid_view_View_Ljava_lang_Object_;
	}
}
