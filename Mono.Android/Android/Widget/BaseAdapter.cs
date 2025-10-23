using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Database;
using Android.Runtime;
using Android.Views;
using Java.Interop;
using Java.Lang;

namespace Android.Widget
{
	// Token: 0x020000B3 RID: 179
	[Register("android/widget/BaseAdapter", DoNotGenerateAcw = true)]
	public abstract class BaseAdapter : Java.Lang.Object, IListAdapter, IAdapter, IJavaObject, IDisposable, IJavaPeerable, ISpinnerAdapter
	{
		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600033C RID: 828 RVA: 0x00005206 File Offset: 0x00003406
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BaseAdapter._members;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600033D RID: 829 RVA: 0x00005210 File Offset: 0x00003410
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BaseAdapter._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600033E RID: 830 RVA: 0x00005234 File Offset: 0x00003434
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BaseAdapter._members.ManagedPeerType;
			}
		}

		// Token: 0x0600033F RID: 831 RVA: 0x000021E0 File Offset: 0x000003E0
		protected BaseAdapter(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000340 RID: 832 RVA: 0x00005240 File Offset: 0x00003440
		private static Delegate GetHasStableIdsHandler()
		{
			if (BaseAdapter.cb_hasStableIds == null)
			{
				BaseAdapter.cb_hasStableIds = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(BaseAdapter.n_HasStableIds));
			}
			return BaseAdapter.cb_hasStableIds;
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00005264 File Offset: 0x00003464
		private static bool n_HasStableIds(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<BaseAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HasStableIds;
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000342 RID: 834 RVA: 0x00005273 File Offset: 0x00003473
		public virtual bool HasStableIds
		{
			get
			{
				return BaseAdapter._members.InstanceMethods.InvokeVirtualBooleanMethod("hasStableIds.()Z", this, null);
			}
		}

		// Token: 0x06000343 RID: 835 RVA: 0x0000528C File Offset: 0x0000348C
		private static Delegate GetIsEmptyHandler()
		{
			if (BaseAdapter.cb_isEmpty == null)
			{
				BaseAdapter.cb_isEmpty = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(BaseAdapter.n_IsEmpty));
			}
			return BaseAdapter.cb_isEmpty;
		}

		// Token: 0x06000344 RID: 836 RVA: 0x000052B0 File Offset: 0x000034B0
		private static bool n_IsEmpty(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<BaseAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsEmpty;
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000345 RID: 837 RVA: 0x000052BF File Offset: 0x000034BF
		public virtual bool IsEmpty
		{
			get
			{
				return BaseAdapter._members.InstanceMethods.InvokeVirtualBooleanMethod("isEmpty.()Z", this, null);
			}
		}

		// Token: 0x06000346 RID: 838 RVA: 0x000052D8 File Offset: 0x000034D8
		private static Delegate GetGetViewTypeCountHandler()
		{
			if (BaseAdapter.cb_getViewTypeCount == null)
			{
				BaseAdapter.cb_getViewTypeCount = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(BaseAdapter.n_GetViewTypeCount));
			}
			return BaseAdapter.cb_getViewTypeCount;
		}

		// Token: 0x06000347 RID: 839 RVA: 0x000052FC File Offset: 0x000034FC
		private static int n_GetViewTypeCount(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<BaseAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ViewTypeCount;
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000348 RID: 840 RVA: 0x0000530B File Offset: 0x0000350B
		public virtual int ViewTypeCount
		{
			get
			{
				return BaseAdapter._members.InstanceMethods.InvokeVirtualInt32Method("getViewTypeCount.()I", this, null);
			}
		}

		// Token: 0x06000349 RID: 841 RVA: 0x00005324 File Offset: 0x00003524
		private static Delegate GetAreAllItemsEnabledHandler()
		{
			if (BaseAdapter.cb_areAllItemsEnabled == null)
			{
				BaseAdapter.cb_areAllItemsEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(BaseAdapter.n_AreAllItemsEnabled));
			}
			return BaseAdapter.cb_areAllItemsEnabled;
		}

		// Token: 0x0600034A RID: 842 RVA: 0x00005348 File Offset: 0x00003548
		private static bool n_AreAllItemsEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<BaseAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AreAllItemsEnabled();
		}

		// Token: 0x0600034B RID: 843 RVA: 0x00005357 File Offset: 0x00003557
		public virtual bool AreAllItemsEnabled()
		{
			return BaseAdapter._members.InstanceMethods.InvokeVirtualBooleanMethod("areAllItemsEnabled.()Z", this, null);
		}

		// Token: 0x0600034C RID: 844 RVA: 0x00005370 File Offset: 0x00003570
		private static Delegate GetGetAutofillOptionsHandler()
		{
			if (BaseAdapter.cb_getAutofillOptions == null)
			{
				BaseAdapter.cb_getAutofillOptions = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(BaseAdapter.n_GetAutofillOptions));
			}
			return BaseAdapter.cb_getAutofillOptions;
		}

		// Token: 0x0600034D RID: 845 RVA: 0x00005394 File Offset: 0x00003594
		private static IntPtr n_GetAutofillOptions(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray<ICharSequence>(Java.Lang.Object.GetObject<BaseAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetAutofillOptionsFormatted());
		}

		// Token: 0x0600034E RID: 846 RVA: 0x000053A8 File Offset: 0x000035A8
		public virtual ICharSequence[] GetAutofillOptionsFormatted()
		{
			return (ICharSequence[])JNIEnv.GetArray(BaseAdapter._members.InstanceMethods.InvokeVirtualObjectMethod("getAutofillOptions.()[Ljava/lang/CharSequence;", this, null).Handle, JniHandleOwnership.TransferLocalRef, typeof(ICharSequence));
		}

		// Token: 0x0600034F RID: 847 RVA: 0x000053E9 File Offset: 0x000035E9
		public string[] GetAutofillOptions()
		{
			return CharSequence.ArrayToStringArray(this.GetAutofillOptionsFormatted());
		}

		// Token: 0x06000350 RID: 848 RVA: 0x000053F6 File Offset: 0x000035F6
		private static Delegate GetGetDropDownView_ILandroid_view_View_Landroid_view_ViewGroup_Handler()
		{
			if (BaseAdapter.cb_getDropDownView_ILandroid_view_View_Landroid_view_ViewGroup_ == null)
			{
				BaseAdapter.cb_getDropDownView_ILandroid_view_View_Landroid_view_ViewGroup_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPILL_L(BaseAdapter.n_GetDropDownView_ILandroid_view_View_Landroid_view_ViewGroup_));
			}
			return BaseAdapter.cb_getDropDownView_ILandroid_view_View_Landroid_view_ViewGroup_;
		}

		// Token: 0x06000351 RID: 849 RVA: 0x0000541C File Offset: 0x0000361C
		private static IntPtr n_GetDropDownView_ILandroid_view_View_Landroid_view_ViewGroup_(IntPtr jnienv, IntPtr native__this, int position, IntPtr native_convertView, IntPtr native_parent)
		{
			BaseAdapter @object = Java.Lang.Object.GetObject<BaseAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_convertView, JniHandleOwnership.DoNotTransfer);
			ViewGroup object3 = Java.Lang.Object.GetObject<ViewGroup>(native_parent, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetDropDownView(position, object2, object3));
		}

		// Token: 0x06000352 RID: 850 RVA: 0x00005450 File Offset: 0x00003650
		public unsafe virtual View GetDropDownView(int position, View convertView, ViewGroup parent)
		{
			View @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(position);
				ptr[1] = new JniArgumentValue((convertView == null) ? IntPtr.Zero : convertView.Handle);
				ptr[2] = new JniArgumentValue((parent == null) ? IntPtr.Zero : parent.Handle);
				@object = Java.Lang.Object.GetObject<View>(BaseAdapter._members.InstanceMethods.InvokeVirtualObjectMethod("getDropDownView.(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(convertView);
				GC.KeepAlive(parent);
			}
			return @object;
		}

		// Token: 0x06000353 RID: 851 RVA: 0x00005504 File Offset: 0x00003704
		private static Delegate GetGetItemViewType_IHandler()
		{
			if (BaseAdapter.cb_getItemViewType_I == null)
			{
				BaseAdapter.cb_getItemViewType_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_I(BaseAdapter.n_GetItemViewType_I));
			}
			return BaseAdapter.cb_getItemViewType_I;
		}

		// Token: 0x06000354 RID: 852 RVA: 0x00005528 File Offset: 0x00003728
		private static int n_GetItemViewType_I(IntPtr jnienv, IntPtr native__this, int position)
		{
			return Java.Lang.Object.GetObject<BaseAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetItemViewType(position);
		}

		// Token: 0x06000355 RID: 853 RVA: 0x00005538 File Offset: 0x00003738
		public unsafe virtual int GetItemViewType(int position)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(position);
			return BaseAdapter._members.InstanceMethods.InvokeVirtualInt32Method("getItemViewType.(I)I", this, ptr);
		}

		// Token: 0x06000356 RID: 854 RVA: 0x00005573 File Offset: 0x00003773
		private static Delegate GetIsEnabled_IHandler()
		{
			if (BaseAdapter.cb_isEnabled_I == null)
			{
				BaseAdapter.cb_isEnabled_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_Z(BaseAdapter.n_IsEnabled_I));
			}
			return BaseAdapter.cb_isEnabled_I;
		}

		// Token: 0x06000357 RID: 855 RVA: 0x00005597 File Offset: 0x00003797
		private static bool n_IsEnabled_I(IntPtr jnienv, IntPtr native__this, int position)
		{
			return Java.Lang.Object.GetObject<BaseAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsEnabled(position);
		}

		// Token: 0x06000358 RID: 856 RVA: 0x000055A8 File Offset: 0x000037A8
		public unsafe virtual bool IsEnabled(int position)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(position);
			return BaseAdapter._members.InstanceMethods.InvokeVirtualBooleanMethod("isEnabled.(I)Z", this, ptr);
		}

		// Token: 0x06000359 RID: 857 RVA: 0x000055E3 File Offset: 0x000037E3
		private static Delegate GetRegisterDataSetObserver_Landroid_database_DataSetObserver_Handler()
		{
			if (BaseAdapter.cb_registerDataSetObserver_Landroid_database_DataSetObserver_ == null)
			{
				BaseAdapter.cb_registerDataSetObserver_Landroid_database_DataSetObserver_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(BaseAdapter.n_RegisterDataSetObserver_Landroid_database_DataSetObserver_));
			}
			return BaseAdapter.cb_registerDataSetObserver_Landroid_database_DataSetObserver_;
		}

		// Token: 0x0600035A RID: 858 RVA: 0x00005608 File Offset: 0x00003808
		private static void n_RegisterDataSetObserver_Landroid_database_DataSetObserver_(IntPtr jnienv, IntPtr native__this, IntPtr native_observer)
		{
			BaseAdapter @object = Java.Lang.Object.GetObject<BaseAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			DataSetObserver object2 = Java.Lang.Object.GetObject<DataSetObserver>(native_observer, JniHandleOwnership.DoNotTransfer);
			@object.RegisterDataSetObserver(object2);
		}

		// Token: 0x0600035B RID: 859 RVA: 0x0000562C File Offset: 0x0000382C
		public unsafe virtual void RegisterDataSetObserver(DataSetObserver observer)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((observer == null) ? IntPtr.Zero : observer.Handle);
				BaseAdapter._members.InstanceMethods.InvokeVirtualVoidMethod("registerDataSetObserver.(Landroid/database/DataSetObserver;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(observer);
			}
		}

		// Token: 0x0600035C RID: 860 RVA: 0x00005690 File Offset: 0x00003890
		private static Delegate GetUnregisterDataSetObserver_Landroid_database_DataSetObserver_Handler()
		{
			if (BaseAdapter.cb_unregisterDataSetObserver_Landroid_database_DataSetObserver_ == null)
			{
				BaseAdapter.cb_unregisterDataSetObserver_Landroid_database_DataSetObserver_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(BaseAdapter.n_UnregisterDataSetObserver_Landroid_database_DataSetObserver_));
			}
			return BaseAdapter.cb_unregisterDataSetObserver_Landroid_database_DataSetObserver_;
		}

		// Token: 0x0600035D RID: 861 RVA: 0x000056B4 File Offset: 0x000038B4
		private static void n_UnregisterDataSetObserver_Landroid_database_DataSetObserver_(IntPtr jnienv, IntPtr native__this, IntPtr native_observer)
		{
			BaseAdapter @object = Java.Lang.Object.GetObject<BaseAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			DataSetObserver object2 = Java.Lang.Object.GetObject<DataSetObserver>(native_observer, JniHandleOwnership.DoNotTransfer);
			@object.UnregisterDataSetObserver(object2);
		}

		// Token: 0x0600035E RID: 862 RVA: 0x000056D8 File Offset: 0x000038D8
		public unsafe virtual void UnregisterDataSetObserver(DataSetObserver observer)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((observer == null) ? IntPtr.Zero : observer.Handle);
				BaseAdapter._members.InstanceMethods.InvokeVirtualVoidMethod("unregisterDataSetObserver.(Landroid/database/DataSetObserver;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(observer);
			}
		}

		// Token: 0x0600035F RID: 863 RVA: 0x0000573C File Offset: 0x0000393C
		private static Delegate GetGetItem_IHandler()
		{
			if (BaseAdapter.cb_getItem_I == null)
			{
				BaseAdapter.cb_getItem_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(BaseAdapter.n_GetItem_I));
			}
			return BaseAdapter.cb_getItem_I;
		}

		// Token: 0x06000360 RID: 864 RVA: 0x00005760 File Offset: 0x00003960
		private static IntPtr n_GetItem_I(IntPtr jnienv, IntPtr native__this, int position)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<BaseAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetItem(position));
		}

		// Token: 0x06000361 RID: 865
		public abstract Java.Lang.Object GetItem(int position);

		// Token: 0x06000362 RID: 866 RVA: 0x00005775 File Offset: 0x00003975
		private static Delegate GetGetItemId_IHandler()
		{
			if (BaseAdapter.cb_getItemId_I == null)
			{
				BaseAdapter.cb_getItemId_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_J(BaseAdapter.n_GetItemId_I));
			}
			return BaseAdapter.cb_getItemId_I;
		}

		// Token: 0x06000363 RID: 867 RVA: 0x00005799 File Offset: 0x00003999
		private static long n_GetItemId_I(IntPtr jnienv, IntPtr native__this, int position)
		{
			return Java.Lang.Object.GetObject<BaseAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetItemId(position);
		}

		// Token: 0x06000364 RID: 868
		public abstract long GetItemId(int position);

		// Token: 0x06000365 RID: 869 RVA: 0x000057A9 File Offset: 0x000039A9
		private static Delegate GetGetView_ILandroid_view_View_Landroid_view_ViewGroup_Handler()
		{
			if (BaseAdapter.cb_getView_ILandroid_view_View_Landroid_view_ViewGroup_ == null)
			{
				BaseAdapter.cb_getView_ILandroid_view_View_Landroid_view_ViewGroup_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPILL_L(BaseAdapter.n_GetView_ILandroid_view_View_Landroid_view_ViewGroup_));
			}
			return BaseAdapter.cb_getView_ILandroid_view_View_Landroid_view_ViewGroup_;
		}

		// Token: 0x06000366 RID: 870 RVA: 0x000057D0 File Offset: 0x000039D0
		private static IntPtr n_GetView_ILandroid_view_View_Landroid_view_ViewGroup_(IntPtr jnienv, IntPtr native__this, int position, IntPtr native_convertView, IntPtr native_parent)
		{
			BaseAdapter @object = Java.Lang.Object.GetObject<BaseAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_convertView, JniHandleOwnership.DoNotTransfer);
			ViewGroup object3 = Java.Lang.Object.GetObject<ViewGroup>(native_parent, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetView(position, object2, object3));
		}

		// Token: 0x06000367 RID: 871
		public abstract View GetView(int position, View convertView, ViewGroup parent);

		// Token: 0x06000368 RID: 872 RVA: 0x00005803 File Offset: 0x00003A03
		private static Delegate GetGetCountHandler()
		{
			if (BaseAdapter.cb_getCount == null)
			{
				BaseAdapter.cb_getCount = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(BaseAdapter.n_GetCount));
			}
			return BaseAdapter.cb_getCount;
		}

		// Token: 0x06000369 RID: 873 RVA: 0x00005827 File Offset: 0x00003A27
		private static int n_GetCount(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<BaseAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Count;
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600036A RID: 874
		public abstract int Count { get; }

		// Token: 0x0400007A RID: 122
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/widget/BaseAdapter", typeof(BaseAdapter));

		// Token: 0x0400007B RID: 123
		private static Delegate cb_hasStableIds;

		// Token: 0x0400007C RID: 124
		private static Delegate cb_isEmpty;

		// Token: 0x0400007D RID: 125
		private static Delegate cb_getViewTypeCount;

		// Token: 0x0400007E RID: 126
		private static Delegate cb_areAllItemsEnabled;

		// Token: 0x0400007F RID: 127
		private static Delegate cb_getAutofillOptions;

		// Token: 0x04000080 RID: 128
		private static Delegate cb_getDropDownView_ILandroid_view_View_Landroid_view_ViewGroup_;

		// Token: 0x04000081 RID: 129
		private static Delegate cb_getItemViewType_I;

		// Token: 0x04000082 RID: 130
		private static Delegate cb_isEnabled_I;

		// Token: 0x04000083 RID: 131
		private static Delegate cb_registerDataSetObserver_Landroid_database_DataSetObserver_;

		// Token: 0x04000084 RID: 132
		private static Delegate cb_unregisterDataSetObserver_Landroid_database_DataSetObserver_;

		// Token: 0x04000085 RID: 133
		private static Delegate cb_getItem_I;

		// Token: 0x04000086 RID: 134
		private static Delegate cb_getItemId_I;

		// Token: 0x04000087 RID: 135
		private static Delegate cb_getView_ILandroid_view_View_Landroid_view_ViewGroup_;

		// Token: 0x04000088 RID: 136
		private static Delegate cb_getCount;
	}
}
