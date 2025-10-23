using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Content.Res;
using Android.Runtime;
using Android.Views;
using Java.Interop;
using Java.Lang;

namespace Android.Widget
{
	// Token: 0x020000B2 RID: 178
	[Register("android/widget/ArrayAdapter", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public class ArrayAdapter : BaseAdapter, IFilterable, IJavaObject, IDisposable, IJavaPeerable, IThemedSpinnerAdapter, ISpinnerAdapter, IAdapter
	{
		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600031A RID: 794 RVA: 0x00004C42 File Offset: 0x00002E42
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ArrayAdapter._members;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600031B RID: 795 RVA: 0x00004C4C File Offset: 0x00002E4C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ArrayAdapter._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600031C RID: 796 RVA: 0x00004C70 File Offset: 0x00002E70
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ArrayAdapter._members.ManagedPeerType;
			}
		}

		// Token: 0x0600031D RID: 797 RVA: 0x00004C7C File Offset: 0x00002E7C
		protected ArrayAdapter(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600031E RID: 798 RVA: 0x00004C86 File Offset: 0x00002E86
		private static Delegate GetGetCountHandler()
		{
			if (ArrayAdapter.cb_getCount == null)
			{
				ArrayAdapter.cb_getCount = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ArrayAdapter.n_GetCount));
			}
			return ArrayAdapter.cb_getCount;
		}

		// Token: 0x0600031F RID: 799 RVA: 0x00004CAA File Offset: 0x00002EAA
		private static int n_GetCount(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ArrayAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Count;
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000320 RID: 800 RVA: 0x00004CB9 File Offset: 0x00002EB9
		public override int Count
		{
			get
			{
				return ArrayAdapter._members.InstanceMethods.InvokeVirtualInt32Method("getCount.()I", this, null);
			}
		}

		// Token: 0x06000321 RID: 801 RVA: 0x00004CD2 File Offset: 0x00002ED2
		private static Delegate GetGetDropDownViewThemeHandler()
		{
			if (ArrayAdapter.cb_getDropDownViewTheme == null)
			{
				ArrayAdapter.cb_getDropDownViewTheme = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ArrayAdapter.n_GetDropDownViewTheme));
			}
			return ArrayAdapter.cb_getDropDownViewTheme;
		}

		// Token: 0x06000322 RID: 802 RVA: 0x00004CF6 File Offset: 0x00002EF6
		private static IntPtr n_GetDropDownViewTheme(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ArrayAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DropDownViewTheme);
		}

		// Token: 0x06000323 RID: 803 RVA: 0x00004D0A File Offset: 0x00002F0A
		private static Delegate GetSetDropDownViewTheme_Landroid_content_res_Resources_Theme_Handler()
		{
			if (ArrayAdapter.cb_setDropDownViewTheme_Landroid_content_res_Resources_Theme_ == null)
			{
				ArrayAdapter.cb_setDropDownViewTheme_Landroid_content_res_Resources_Theme_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ArrayAdapter.n_SetDropDownViewTheme_Landroid_content_res_Resources_Theme_));
			}
			return ArrayAdapter.cb_setDropDownViewTheme_Landroid_content_res_Resources_Theme_;
		}

		// Token: 0x06000324 RID: 804 RVA: 0x00004D30 File Offset: 0x00002F30
		private static void n_SetDropDownViewTheme_Landroid_content_res_Resources_Theme_(IntPtr jnienv, IntPtr native__this, IntPtr native_theme)
		{
			ArrayAdapter @object = Java.Lang.Object.GetObject<ArrayAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Resources.Theme object2 = Java.Lang.Object.GetObject<Resources.Theme>(native_theme, JniHandleOwnership.DoNotTransfer);
			@object.DropDownViewTheme = object2;
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000325 RID: 805 RVA: 0x00004D54 File Offset: 0x00002F54
		// (set) Token: 0x06000326 RID: 806 RVA: 0x00004D88 File Offset: 0x00002F88
		public unsafe virtual Resources.Theme DropDownViewTheme
		{
			get
			{
				return Java.Lang.Object.GetObject<Resources.Theme>(ArrayAdapter._members.InstanceMethods.InvokeVirtualObjectMethod("getDropDownViewTheme.()Landroid/content/res/Resources$Theme;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					ArrayAdapter._members.InstanceMethods.InvokeVirtualVoidMethod("setDropDownViewTheme.(Landroid/content/res/Resources$Theme;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x06000327 RID: 807 RVA: 0x00004DEC File Offset: 0x00002FEC
		private static Delegate GetGetFilterHandler()
		{
			if (ArrayAdapter.cb_getFilter == null)
			{
				ArrayAdapter.cb_getFilter = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ArrayAdapter.n_GetFilter));
			}
			return ArrayAdapter.cb_getFilter;
		}

		// Token: 0x06000328 RID: 808 RVA: 0x00004E10 File Offset: 0x00003010
		private static IntPtr n_GetFilter(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ArrayAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Filter);
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000329 RID: 809 RVA: 0x00004E24 File Offset: 0x00003024
		public virtual Filter Filter
		{
			get
			{
				return Java.Lang.Object.GetObject<Filter>(ArrayAdapter._members.InstanceMethods.InvokeVirtualObjectMethod("getFilter.()Landroid/widget/Filter;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600032A RID: 810 RVA: 0x00004E58 File Offset: 0x00003058
		public unsafe static ArrayAdapter CreateFromResource(Context context, int textArrayResId, int textViewResId)
		{
			ArrayAdapter @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue(textArrayResId);
				ptr[2] = new JniArgumentValue(textViewResId);
				@object = Java.Lang.Object.GetObject<ArrayAdapter>(ArrayAdapter._members.StaticMethods.InvokeObjectMethod("createFromResource.(Landroid/content/Context;II)Landroid/widget/ArrayAdapter;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
			}
			return @object;
		}

		// Token: 0x0600032B RID: 811 RVA: 0x00004EF4 File Offset: 0x000030F4
		private static Delegate GetGetAutofillOptionsHandler()
		{
			if (ArrayAdapter.cb_getAutofillOptions == null)
			{
				ArrayAdapter.cb_getAutofillOptions = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ArrayAdapter.n_GetAutofillOptions));
			}
			return ArrayAdapter.cb_getAutofillOptions;
		}

		// Token: 0x0600032C RID: 812 RVA: 0x00004F18 File Offset: 0x00003118
		private static IntPtr n_GetAutofillOptions(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray<ICharSequence>(Java.Lang.Object.GetObject<ArrayAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetAutofillOptionsFormatted());
		}

		// Token: 0x0600032D RID: 813 RVA: 0x00004F2C File Offset: 0x0000312C
		public new virtual ICharSequence[] GetAutofillOptionsFormatted()
		{
			return (ICharSequence[])JNIEnv.GetArray(ArrayAdapter._members.InstanceMethods.InvokeVirtualObjectMethod("getAutofillOptions.()[Ljava/lang/CharSequence;", this, null).Handle, JniHandleOwnership.TransferLocalRef, typeof(ICharSequence));
		}

		// Token: 0x0600032E RID: 814 RVA: 0x00004F6D File Offset: 0x0000316D
		public new string[] GetAutofillOptions()
		{
			return CharSequence.ArrayToStringArray(this.GetAutofillOptionsFormatted());
		}

		// Token: 0x0600032F RID: 815 RVA: 0x00004F7A File Offset: 0x0000317A
		private static Delegate GetGetItem_IHandler()
		{
			if (ArrayAdapter.cb_getItem_I == null)
			{
				ArrayAdapter.cb_getItem_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(ArrayAdapter.n_GetItem_I));
			}
			return ArrayAdapter.cb_getItem_I;
		}

		// Token: 0x06000330 RID: 816 RVA: 0x00004F9E File Offset: 0x0000319E
		private static IntPtr n_GetItem_I(IntPtr jnienv, IntPtr native__this, int position)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ArrayAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetItem(position));
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00004FB4 File Offset: 0x000031B4
		public unsafe override Java.Lang.Object GetItem(int position)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(position);
			return Java.Lang.Object.GetObject<Java.Lang.Object>(ArrayAdapter._members.InstanceMethods.InvokeVirtualObjectMethod("getItem.(I)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00004FFD File Offset: 0x000031FD
		private static Delegate GetGetItemId_IHandler()
		{
			if (ArrayAdapter.cb_getItemId_I == null)
			{
				ArrayAdapter.cb_getItemId_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_J(ArrayAdapter.n_GetItemId_I));
			}
			return ArrayAdapter.cb_getItemId_I;
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00005021 File Offset: 0x00003221
		private static long n_GetItemId_I(IntPtr jnienv, IntPtr native__this, int position)
		{
			return Java.Lang.Object.GetObject<ArrayAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetItemId(position);
		}

		// Token: 0x06000334 RID: 820 RVA: 0x00005034 File Offset: 0x00003234
		public unsafe override long GetItemId(int position)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(position);
			return ArrayAdapter._members.InstanceMethods.InvokeVirtualInt64Method("getItemId.(I)J", this, ptr);
		}

		// Token: 0x06000335 RID: 821 RVA: 0x0000506F File Offset: 0x0000326F
		private static Delegate GetGetView_ILandroid_view_View_Landroid_view_ViewGroup_Handler()
		{
			if (ArrayAdapter.cb_getView_ILandroid_view_View_Landroid_view_ViewGroup_ == null)
			{
				ArrayAdapter.cb_getView_ILandroid_view_View_Landroid_view_ViewGroup_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPILL_L(ArrayAdapter.n_GetView_ILandroid_view_View_Landroid_view_ViewGroup_));
			}
			return ArrayAdapter.cb_getView_ILandroid_view_View_Landroid_view_ViewGroup_;
		}

		// Token: 0x06000336 RID: 822 RVA: 0x00005094 File Offset: 0x00003294
		private static IntPtr n_GetView_ILandroid_view_View_Landroid_view_ViewGroup_(IntPtr jnienv, IntPtr native__this, int position, IntPtr native_convertView, IntPtr native_parent)
		{
			BaseAdapter @object = Java.Lang.Object.GetObject<ArrayAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_convertView, JniHandleOwnership.DoNotTransfer);
			ViewGroup object3 = Java.Lang.Object.GetObject<ViewGroup>(native_parent, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetView(position, object2, object3));
		}

		// Token: 0x06000337 RID: 823 RVA: 0x000050C8 File Offset: 0x000032C8
		public unsafe override View GetView(int position, View convertView, ViewGroup parent)
		{
			View @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(position);
				ptr[1] = new JniArgumentValue((convertView == null) ? IntPtr.Zero : convertView.Handle);
				ptr[2] = new JniArgumentValue((parent == null) ? IntPtr.Zero : parent.Handle);
				@object = Java.Lang.Object.GetObject<View>(ArrayAdapter._members.InstanceMethods.InvokeVirtualObjectMethod("getView.(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(convertView);
				GC.KeepAlive(parent);
			}
			return @object;
		}

		// Token: 0x06000338 RID: 824 RVA: 0x0000517C File Offset: 0x0000337C
		private static Delegate GetSetDropDownViewResource_IHandler()
		{
			if (ArrayAdapter.cb_setDropDownViewResource_I == null)
			{
				ArrayAdapter.cb_setDropDownViewResource_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(ArrayAdapter.n_SetDropDownViewResource_I));
			}
			return ArrayAdapter.cb_setDropDownViewResource_I;
		}

		// Token: 0x06000339 RID: 825 RVA: 0x000051A0 File Offset: 0x000033A0
		private static void n_SetDropDownViewResource_I(IntPtr jnienv, IntPtr native__this, int resource)
		{
			Java.Lang.Object.GetObject<ArrayAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetDropDownViewResource(resource);
		}

		// Token: 0x0600033A RID: 826 RVA: 0x000051B0 File Offset: 0x000033B0
		public unsafe virtual void SetDropDownViewResource(int resource)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(resource);
			ArrayAdapter._members.InstanceMethods.InvokeVirtualVoidMethod("setDropDownViewResource.(I)V", this, ptr);
		}

		// Token: 0x04000070 RID: 112
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/widget/ArrayAdapter", typeof(ArrayAdapter));

		// Token: 0x04000071 RID: 113
		private static Delegate cb_getCount;

		// Token: 0x04000072 RID: 114
		private static Delegate cb_getDropDownViewTheme;

		// Token: 0x04000073 RID: 115
		private static Delegate cb_setDropDownViewTheme_Landroid_content_res_Resources_Theme_;

		// Token: 0x04000074 RID: 116
		private static Delegate cb_getFilter;

		// Token: 0x04000075 RID: 117
		private static Delegate cb_getAutofillOptions;

		// Token: 0x04000076 RID: 118
		private static Delegate cb_getItem_I;

		// Token: 0x04000077 RID: 119
		private static Delegate cb_getItemId_I;

		// Token: 0x04000078 RID: 120
		private static Delegate cb_getView_ILandroid_view_View_Landroid_view_ViewGroup_;

		// Token: 0x04000079 RID: 121
		private static Delegate cb_setDropDownViewResource_I;
	}
}
