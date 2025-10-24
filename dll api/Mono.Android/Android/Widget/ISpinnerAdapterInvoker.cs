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
	// Token: 0x020000D7 RID: 215
	[Register("android/widget/SpinnerAdapter", DoNotGenerateAcw = true)]
	internal class ISpinnerAdapterInvoker : Java.Lang.Object, ISpinnerAdapter, IAdapter, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000486 RID: 1158 RVA: 0x00008BF8 File Offset: 0x00006DF8
		private static IntPtr java_class_ref
		{
			get
			{
				return ISpinnerAdapterInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000487 RID: 1159 RVA: 0x00008C1C File Offset: 0x00006E1C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ISpinnerAdapterInvoker._members;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000488 RID: 1160 RVA: 0x00008C23 File Offset: 0x00006E23
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000489 RID: 1161 RVA: 0x00008C2B File Offset: 0x00006E2B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ISpinnerAdapterInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x00008C37 File Offset: 0x00006E37
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ISpinnerAdapterInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.widget.SpinnerAdapter'.");
			}
			return handle;
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x00008C62 File Offset: 0x00006E62
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x00008C94 File Offset: 0x00006E94
		public ISpinnerAdapterInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ISpinnerAdapterInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x00008CCC File Offset: 0x00006ECC
		private static Delegate GetGetDropDownView_ILandroid_view_View_Landroid_view_ViewGroup_Handler()
		{
			if (ISpinnerAdapterInvoker.cb_getDropDownView_ILandroid_view_View_Landroid_view_ViewGroup_ == null)
			{
				ISpinnerAdapterInvoker.cb_getDropDownView_ILandroid_view_View_Landroid_view_ViewGroup_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPILL_L(ISpinnerAdapterInvoker.n_GetDropDownView_ILandroid_view_View_Landroid_view_ViewGroup_));
			}
			return ISpinnerAdapterInvoker.cb_getDropDownView_ILandroid_view_View_Landroid_view_ViewGroup_;
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x00008CF0 File Offset: 0x00006EF0
		private static IntPtr n_GetDropDownView_ILandroid_view_View_Landroid_view_ViewGroup_(IntPtr jnienv, IntPtr native__this, int position, IntPtr native_convertView, IntPtr native_parent)
		{
			ISpinnerAdapter @object = Java.Lang.Object.GetObject<ISpinnerAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_convertView, JniHandleOwnership.DoNotTransfer);
			ViewGroup object3 = Java.Lang.Object.GetObject<ViewGroup>(native_parent, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetDropDownView(position, object2, object3));
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x00008D24 File Offset: 0x00006F24
		public unsafe View GetDropDownView(int position, View convertView, ViewGroup parent)
		{
			if (this.id_getDropDownView_ILandroid_view_View_Landroid_view_ViewGroup_ == IntPtr.Zero)
			{
				this.id_getDropDownView_ILandroid_view_View_Landroid_view_ViewGroup_ = JNIEnv.GetMethodID(this.class_ref, "getDropDownView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(position);
			ptr[1] = new JValue((convertView == null) ? IntPtr.Zero : convertView.Handle);
			ptr[2] = new JValue((parent == null) ? IntPtr.Zero : parent.Handle);
			return Java.Lang.Object.GetObject<View>(JNIEnv.CallObjectMethod(base.Handle, this.id_getDropDownView_ILandroid_view_View_Landroid_view_ViewGroup_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000490 RID: 1168 RVA: 0x00008DD5 File Offset: 0x00006FD5
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

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000491 RID: 1169 RVA: 0x00008E15 File Offset: 0x00007015
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

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000492 RID: 1170 RVA: 0x00008E55 File Offset: 0x00007055
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

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000493 RID: 1171 RVA: 0x00008E95 File Offset: 0x00007095
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

		// Token: 0x06000494 RID: 1172 RVA: 0x00008ED8 File Offset: 0x000070D8
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

		// Token: 0x06000495 RID: 1173 RVA: 0x00008F44 File Offset: 0x00007144
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

		// Token: 0x06000496 RID: 1174 RVA: 0x00008FA8 File Offset: 0x000071A8
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

		// Token: 0x06000497 RID: 1175 RVA: 0x0000900C File Offset: 0x0000720C
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

		// Token: 0x06000498 RID: 1176 RVA: 0x000090C0 File Offset: 0x000072C0
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

		// Token: 0x06000499 RID: 1177 RVA: 0x00009134 File Offset: 0x00007334
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

		// Token: 0x040000E7 RID: 231
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/widget/SpinnerAdapter", typeof(ISpinnerAdapterInvoker));

		// Token: 0x040000E8 RID: 232
		private IntPtr class_ref;

		// Token: 0x040000E9 RID: 233
		private static Delegate cb_getDropDownView_ILandroid_view_View_Landroid_view_ViewGroup_;

		// Token: 0x040000EA RID: 234
		private IntPtr id_getDropDownView_ILandroid_view_View_Landroid_view_ViewGroup_;

		// Token: 0x040000EB RID: 235
		private IntPtr id_getCount;

		// Token: 0x040000EC RID: 236
		private IntPtr id_hasStableIds;

		// Token: 0x040000ED RID: 237
		private IntPtr id_isEmpty;

		// Token: 0x040000EE RID: 238
		private IntPtr id_getViewTypeCount;

		// Token: 0x040000EF RID: 239
		private IntPtr id_getItem_I;

		// Token: 0x040000F0 RID: 240
		private IntPtr id_getItemId_I;

		// Token: 0x040000F1 RID: 241
		private IntPtr id_getItemViewType_I;

		// Token: 0x040000F2 RID: 242
		private IntPtr id_getView_ILandroid_view_View_Landroid_view_ViewGroup_;

		// Token: 0x040000F3 RID: 243
		private IntPtr id_registerDataSetObserver_Landroid_database_DataSetObserver_;

		// Token: 0x040000F4 RID: 244
		private IntPtr id_unregisterDataSetObserver_Landroid_database_DataSetObserver_;
	}
}
