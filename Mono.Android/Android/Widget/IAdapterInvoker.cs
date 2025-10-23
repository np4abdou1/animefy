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
	// Token: 0x020000CA RID: 202
	[Register("android/widget/Adapter", DoNotGenerateAcw = true)]
	internal class IAdapterInvoker : Java.Lang.Object, IAdapter, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000400 RID: 1024 RVA: 0x000073A4 File Offset: 0x000055A4
		private static IntPtr java_class_ref
		{
			get
			{
				return IAdapterInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000401 RID: 1025 RVA: 0x000073C8 File Offset: 0x000055C8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IAdapterInvoker._members;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000402 RID: 1026 RVA: 0x000073CF File Offset: 0x000055CF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000403 RID: 1027 RVA: 0x000073D7 File Offset: 0x000055D7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IAdapterInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x000073E3 File Offset: 0x000055E3
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IAdapterInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.widget.Adapter'.");
			}
			return handle;
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x0000740E File Offset: 0x0000560E
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x00007440 File Offset: 0x00005640
		public IAdapterInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IAdapterInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x00007478 File Offset: 0x00005678
		private static Delegate GetGetCountHandler()
		{
			if (IAdapterInvoker.cb_getCount == null)
			{
				IAdapterInvoker.cb_getCount = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IAdapterInvoker.n_GetCount));
			}
			return IAdapterInvoker.cb_getCount;
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x0000749C File Offset: 0x0000569C
		private static int n_GetCount(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Count;
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000409 RID: 1033 RVA: 0x000074AB File Offset: 0x000056AB
		public int Count
		{
			get
			{
				if (this.id_getCount == IntPtr.Zero)
				{
					this.id_getCount = JNIEnv.GetMethodID(this.class_ref, "getCount", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_getCount);
			}
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x000074EB File Offset: 0x000056EB
		private static Delegate GetHasStableIdsHandler()
		{
			if (IAdapterInvoker.cb_hasStableIds == null)
			{
				IAdapterInvoker.cb_hasStableIds = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IAdapterInvoker.n_HasStableIds));
			}
			return IAdapterInvoker.cb_hasStableIds;
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x0000750F File Offset: 0x0000570F
		private static bool n_HasStableIds(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HasStableIds;
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600040C RID: 1036 RVA: 0x0000751E File Offset: 0x0000571E
		public bool HasStableIds
		{
			get
			{
				if (this.id_hasStableIds == IntPtr.Zero)
				{
					this.id_hasStableIds = JNIEnv.GetMethodID(this.class_ref, "hasStableIds", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_hasStableIds);
			}
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x0000755E File Offset: 0x0000575E
		private static Delegate GetIsEmptyHandler()
		{
			if (IAdapterInvoker.cb_isEmpty == null)
			{
				IAdapterInvoker.cb_isEmpty = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IAdapterInvoker.n_IsEmpty));
			}
			return IAdapterInvoker.cb_isEmpty;
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x00007582 File Offset: 0x00005782
		private static bool n_IsEmpty(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsEmpty;
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600040F RID: 1039 RVA: 0x00007591 File Offset: 0x00005791
		public bool IsEmpty
		{
			get
			{
				if (this.id_isEmpty == IntPtr.Zero)
				{
					this.id_isEmpty = JNIEnv.GetMethodID(this.class_ref, "isEmpty", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isEmpty);
			}
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x000075D1 File Offset: 0x000057D1
		private static Delegate GetGetViewTypeCountHandler()
		{
			if (IAdapterInvoker.cb_getViewTypeCount == null)
			{
				IAdapterInvoker.cb_getViewTypeCount = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IAdapterInvoker.n_GetViewTypeCount));
			}
			return IAdapterInvoker.cb_getViewTypeCount;
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x000075F5 File Offset: 0x000057F5
		private static int n_GetViewTypeCount(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ViewTypeCount;
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000412 RID: 1042 RVA: 0x00007604 File Offset: 0x00005804
		public int ViewTypeCount
		{
			get
			{
				if (this.id_getViewTypeCount == IntPtr.Zero)
				{
					this.id_getViewTypeCount = JNIEnv.GetMethodID(this.class_ref, "getViewTypeCount", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_getViewTypeCount);
			}
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x00007644 File Offset: 0x00005844
		private static Delegate GetGetItem_IHandler()
		{
			if (IAdapterInvoker.cb_getItem_I == null)
			{
				IAdapterInvoker.cb_getItem_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(IAdapterInvoker.n_GetItem_I));
			}
			return IAdapterInvoker.cb_getItem_I;
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x00007668 File Offset: 0x00005868
		private static IntPtr n_GetItem_I(IntPtr jnienv, IntPtr native__this, int position)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetItem(position));
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x00007680 File Offset: 0x00005880
		public unsafe Java.Lang.Object GetItem(int position)
		{
			if (this.id_getItem_I == IntPtr.Zero)
			{
				this.id_getItem_I = JNIEnv.GetMethodID(this.class_ref, "getItem", "(I)Ljava/lang/Object;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(position);
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_getItem_I, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x000076EA File Offset: 0x000058EA
		private static Delegate GetGetItemId_IHandler()
		{
			if (IAdapterInvoker.cb_getItemId_I == null)
			{
				IAdapterInvoker.cb_getItemId_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_J(IAdapterInvoker.n_GetItemId_I));
			}
			return IAdapterInvoker.cb_getItemId_I;
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x0000770E File Offset: 0x0000590E
		private static long n_GetItemId_I(IntPtr jnienv, IntPtr native__this, int position)
		{
			return Java.Lang.Object.GetObject<IAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetItemId(position);
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x00007720 File Offset: 0x00005920
		public unsafe long GetItemId(int position)
		{
			if (this.id_getItemId_I == IntPtr.Zero)
			{
				this.id_getItemId_I = JNIEnv.GetMethodID(this.class_ref, "getItemId", "(I)J");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(position);
			return JNIEnv.CallLongMethod(base.Handle, this.id_getItemId_I, ptr);
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x00007784 File Offset: 0x00005984
		private static Delegate GetGetItemViewType_IHandler()
		{
			if (IAdapterInvoker.cb_getItemViewType_I == null)
			{
				IAdapterInvoker.cb_getItemViewType_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_I(IAdapterInvoker.n_GetItemViewType_I));
			}
			return IAdapterInvoker.cb_getItemViewType_I;
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x000077A8 File Offset: 0x000059A8
		private static int n_GetItemViewType_I(IntPtr jnienv, IntPtr native__this, int position)
		{
			return Java.Lang.Object.GetObject<IAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetItemViewType(position);
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x000077B8 File Offset: 0x000059B8
		public unsafe int GetItemViewType(int position)
		{
			if (this.id_getItemViewType_I == IntPtr.Zero)
			{
				this.id_getItemViewType_I = JNIEnv.GetMethodID(this.class_ref, "getItemViewType", "(I)I");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(position);
			return JNIEnv.CallIntMethod(base.Handle, this.id_getItemViewType_I, ptr);
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x0000781C File Offset: 0x00005A1C
		private static Delegate GetGetView_ILandroid_view_View_Landroid_view_ViewGroup_Handler()
		{
			if (IAdapterInvoker.cb_getView_ILandroid_view_View_Landroid_view_ViewGroup_ == null)
			{
				IAdapterInvoker.cb_getView_ILandroid_view_View_Landroid_view_ViewGroup_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPILL_L(IAdapterInvoker.n_GetView_ILandroid_view_View_Landroid_view_ViewGroup_));
			}
			return IAdapterInvoker.cb_getView_ILandroid_view_View_Landroid_view_ViewGroup_;
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x00007840 File Offset: 0x00005A40
		private static IntPtr n_GetView_ILandroid_view_View_Landroid_view_ViewGroup_(IntPtr jnienv, IntPtr native__this, int position, IntPtr native_convertView, IntPtr native_parent)
		{
			IAdapter @object = Java.Lang.Object.GetObject<IAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_convertView, JniHandleOwnership.DoNotTransfer);
			ViewGroup object3 = Java.Lang.Object.GetObject<ViewGroup>(native_parent, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetView(position, object2, object3));
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x00007874 File Offset: 0x00005A74
		public unsafe View GetView(int position, View convertView, ViewGroup parent)
		{
			if (this.id_getView_ILandroid_view_View_Landroid_view_ViewGroup_ == IntPtr.Zero)
			{
				this.id_getView_ILandroid_view_View_Landroid_view_ViewGroup_ = JNIEnv.GetMethodID(this.class_ref, "getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(position);
			ptr[1] = new JValue((convertView == null) ? IntPtr.Zero : convertView.Handle);
			ptr[2] = new JValue((parent == null) ? IntPtr.Zero : parent.Handle);
			return Java.Lang.Object.GetObject<View>(JNIEnv.CallObjectMethod(base.Handle, this.id_getView_ILandroid_view_View_Landroid_view_ViewGroup_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x00007925 File Offset: 0x00005B25
		private static Delegate GetRegisterDataSetObserver_Landroid_database_DataSetObserver_Handler()
		{
			if (IAdapterInvoker.cb_registerDataSetObserver_Landroid_database_DataSetObserver_ == null)
			{
				IAdapterInvoker.cb_registerDataSetObserver_Landroid_database_DataSetObserver_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IAdapterInvoker.n_RegisterDataSetObserver_Landroid_database_DataSetObserver_));
			}
			return IAdapterInvoker.cb_registerDataSetObserver_Landroid_database_DataSetObserver_;
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x0000794C File Offset: 0x00005B4C
		private static void n_RegisterDataSetObserver_Landroid_database_DataSetObserver_(IntPtr jnienv, IntPtr native__this, IntPtr native_observer)
		{
			IAdapter @object = Java.Lang.Object.GetObject<IAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			DataSetObserver object2 = Java.Lang.Object.GetObject<DataSetObserver>(native_observer, JniHandleOwnership.DoNotTransfer);
			@object.RegisterDataSetObserver(object2);
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x00007970 File Offset: 0x00005B70
		public unsafe void RegisterDataSetObserver(DataSetObserver observer)
		{
			if (this.id_registerDataSetObserver_Landroid_database_DataSetObserver_ == IntPtr.Zero)
			{
				this.id_registerDataSetObserver_Landroid_database_DataSetObserver_ = JNIEnv.GetMethodID(this.class_ref, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((observer == null) ? IntPtr.Zero : observer.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_registerDataSetObserver_Landroid_database_DataSetObserver_, ptr);
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x000079E3 File Offset: 0x00005BE3
		private static Delegate GetUnregisterDataSetObserver_Landroid_database_DataSetObserver_Handler()
		{
			if (IAdapterInvoker.cb_unregisterDataSetObserver_Landroid_database_DataSetObserver_ == null)
			{
				IAdapterInvoker.cb_unregisterDataSetObserver_Landroid_database_DataSetObserver_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IAdapterInvoker.n_UnregisterDataSetObserver_Landroid_database_DataSetObserver_));
			}
			return IAdapterInvoker.cb_unregisterDataSetObserver_Landroid_database_DataSetObserver_;
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x00007A08 File Offset: 0x00005C08
		private static void n_UnregisterDataSetObserver_Landroid_database_DataSetObserver_(IntPtr jnienv, IntPtr native__this, IntPtr native_observer)
		{
			IAdapter @object = Java.Lang.Object.GetObject<IAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			DataSetObserver object2 = Java.Lang.Object.GetObject<DataSetObserver>(native_observer, JniHandleOwnership.DoNotTransfer);
			@object.UnregisterDataSetObserver(object2);
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x00007A2C File Offset: 0x00005C2C
		public unsafe void UnregisterDataSetObserver(DataSetObserver observer)
		{
			if (this.id_unregisterDataSetObserver_Landroid_database_DataSetObserver_ == IntPtr.Zero)
			{
				this.id_unregisterDataSetObserver_Landroid_database_DataSetObserver_ = JNIEnv.GetMethodID(this.class_ref, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((observer == null) ? IntPtr.Zero : observer.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_unregisterDataSetObserver_Landroid_database_DataSetObserver_, ptr);
		}

		// Token: 0x040000AC RID: 172
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/widget/Adapter", typeof(IAdapterInvoker));

		// Token: 0x040000AD RID: 173
		private IntPtr class_ref;

		// Token: 0x040000AE RID: 174
		private static Delegate cb_getCount;

		// Token: 0x040000AF RID: 175
		private IntPtr id_getCount;

		// Token: 0x040000B0 RID: 176
		private static Delegate cb_hasStableIds;

		// Token: 0x040000B1 RID: 177
		private IntPtr id_hasStableIds;

		// Token: 0x040000B2 RID: 178
		private static Delegate cb_isEmpty;

		// Token: 0x040000B3 RID: 179
		private IntPtr id_isEmpty;

		// Token: 0x040000B4 RID: 180
		private static Delegate cb_getViewTypeCount;

		// Token: 0x040000B5 RID: 181
		private IntPtr id_getViewTypeCount;

		// Token: 0x040000B6 RID: 182
		private static Delegate cb_getItem_I;

		// Token: 0x040000B7 RID: 183
		private IntPtr id_getItem_I;

		// Token: 0x040000B8 RID: 184
		private static Delegate cb_getItemId_I;

		// Token: 0x040000B9 RID: 185
		private IntPtr id_getItemId_I;

		// Token: 0x040000BA RID: 186
		private static Delegate cb_getItemViewType_I;

		// Token: 0x040000BB RID: 187
		private IntPtr id_getItemViewType_I;

		// Token: 0x040000BC RID: 188
		private static Delegate cb_getView_ILandroid_view_View_Landroid_view_ViewGroup_;

		// Token: 0x040000BD RID: 189
		private IntPtr id_getView_ILandroid_view_View_Landroid_view_ViewGroup_;

		// Token: 0x040000BE RID: 190
		private static Delegate cb_registerDataSetObserver_Landroid_database_DataSetObserver_;

		// Token: 0x040000BF RID: 191
		private IntPtr id_registerDataSetObserver_Landroid_database_DataSetObserver_;

		// Token: 0x040000C0 RID: 192
		private static Delegate cb_unregisterDataSetObserver_Landroid_database_DataSetObserver_;

		// Token: 0x040000C1 RID: 193
		private IntPtr id_unregisterDataSetObserver_Landroid_database_DataSetObserver_;
	}
}
