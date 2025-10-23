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
	// Token: 0x020000D2 RID: 210
	[Register("android/widget/ListAdapter", DoNotGenerateAcw = true)]
	internal class IListAdapterInvoker : Java.Lang.Object, IListAdapter, IAdapter, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000454 RID: 1108 RVA: 0x00008058 File Offset: 0x00006258
		private static IntPtr java_class_ref
		{
			get
			{
				return IListAdapterInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000455 RID: 1109 RVA: 0x0000807C File Offset: 0x0000627C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IListAdapterInvoker._members;
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000456 RID: 1110 RVA: 0x00008083 File Offset: 0x00006283
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000457 RID: 1111 RVA: 0x0000808B File Offset: 0x0000628B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IListAdapterInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x00008097 File Offset: 0x00006297
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IListAdapterInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.widget.ListAdapter'.");
			}
			return handle;
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x000080C2 File Offset: 0x000062C2
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x000080F4 File Offset: 0x000062F4
		public IListAdapterInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IListAdapterInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x0000812C File Offset: 0x0000632C
		private static Delegate GetAreAllItemsEnabledHandler()
		{
			if (IListAdapterInvoker.cb_areAllItemsEnabled == null)
			{
				IListAdapterInvoker.cb_areAllItemsEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IListAdapterInvoker.n_AreAllItemsEnabled));
			}
			return IListAdapterInvoker.cb_areAllItemsEnabled;
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x00008150 File Offset: 0x00006350
		private static bool n_AreAllItemsEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IListAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AreAllItemsEnabled();
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x0000815F File Offset: 0x0000635F
		public bool AreAllItemsEnabled()
		{
			if (this.id_areAllItemsEnabled == IntPtr.Zero)
			{
				this.id_areAllItemsEnabled = JNIEnv.GetMethodID(this.class_ref, "areAllItemsEnabled", "()Z");
			}
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_areAllItemsEnabled);
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x0000819F File Offset: 0x0000639F
		private static Delegate GetIsEnabled_IHandler()
		{
			if (IListAdapterInvoker.cb_isEnabled_I == null)
			{
				IListAdapterInvoker.cb_isEnabled_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_Z(IListAdapterInvoker.n_IsEnabled_I));
			}
			return IListAdapterInvoker.cb_isEnabled_I;
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x000081C3 File Offset: 0x000063C3
		private static bool n_IsEnabled_I(IntPtr jnienv, IntPtr native__this, int position)
		{
			return Java.Lang.Object.GetObject<IListAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsEnabled(position);
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x000081D4 File Offset: 0x000063D4
		public unsafe bool IsEnabled(int position)
		{
			if (this.id_isEnabled_I == IntPtr.Zero)
			{
				this.id_isEnabled_I = JNIEnv.GetMethodID(this.class_ref, "isEnabled", "(I)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(position);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_isEnabled_I, ptr);
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000461 RID: 1121 RVA: 0x00008238 File Offset: 0x00006438
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

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000462 RID: 1122 RVA: 0x00008278 File Offset: 0x00006478
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

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000463 RID: 1123 RVA: 0x000082B8 File Offset: 0x000064B8
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

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000464 RID: 1124 RVA: 0x000082F8 File Offset: 0x000064F8
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

		// Token: 0x06000465 RID: 1125 RVA: 0x00008338 File Offset: 0x00006538
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

		// Token: 0x06000466 RID: 1126 RVA: 0x000083A4 File Offset: 0x000065A4
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

		// Token: 0x06000467 RID: 1127 RVA: 0x00008408 File Offset: 0x00006608
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

		// Token: 0x06000468 RID: 1128 RVA: 0x0000846C File Offset: 0x0000666C
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

		// Token: 0x06000469 RID: 1129 RVA: 0x00008520 File Offset: 0x00006720
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

		// Token: 0x0600046A RID: 1130 RVA: 0x00008594 File Offset: 0x00006794
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

		// Token: 0x040000D2 RID: 210
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/widget/ListAdapter", typeof(IListAdapterInvoker));

		// Token: 0x040000D3 RID: 211
		private IntPtr class_ref;

		// Token: 0x040000D4 RID: 212
		private static Delegate cb_areAllItemsEnabled;

		// Token: 0x040000D5 RID: 213
		private IntPtr id_areAllItemsEnabled;

		// Token: 0x040000D6 RID: 214
		private static Delegate cb_isEnabled_I;

		// Token: 0x040000D7 RID: 215
		private IntPtr id_isEnabled_I;

		// Token: 0x040000D8 RID: 216
		private IntPtr id_getCount;

		// Token: 0x040000D9 RID: 217
		private IntPtr id_hasStableIds;

		// Token: 0x040000DA RID: 218
		private IntPtr id_isEmpty;

		// Token: 0x040000DB RID: 219
		private IntPtr id_getViewTypeCount;

		// Token: 0x040000DC RID: 220
		private IntPtr id_getItem_I;

		// Token: 0x040000DD RID: 221
		private IntPtr id_getItemId_I;

		// Token: 0x040000DE RID: 222
		private IntPtr id_getItemViewType_I;

		// Token: 0x040000DF RID: 223
		private IntPtr id_getView_ILandroid_view_View_Landroid_view_ViewGroup_;

		// Token: 0x040000E0 RID: 224
		private IntPtr id_registerDataSetObserver_Landroid_database_DataSetObserver_;

		// Token: 0x040000E1 RID: 225
		private IntPtr id_unregisterDataSetObserver_Landroid_database_DataSetObserver_;
	}
}
