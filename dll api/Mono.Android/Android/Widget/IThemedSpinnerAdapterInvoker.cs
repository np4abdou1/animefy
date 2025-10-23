using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content.Res;
using Android.Database;
using Android.Runtime;
using Android.Views;
using Java.Interop;
using Java.Lang;

namespace Android.Widget
{
	// Token: 0x020000D9 RID: 217
	[Register("android/widget/ThemedSpinnerAdapter", DoNotGenerateAcw = true, ApiSince = 23)]
	internal class IThemedSpinnerAdapterInvoker : Java.Lang.Object, IThemedSpinnerAdapter, ISpinnerAdapter, IAdapter, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x0600049D RID: 1181 RVA: 0x000091C4 File Offset: 0x000073C4
		private static IntPtr java_class_ref
		{
			get
			{
				return IThemedSpinnerAdapterInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x0600049E RID: 1182 RVA: 0x000091E8 File Offset: 0x000073E8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IThemedSpinnerAdapterInvoker._members;
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x0600049F RID: 1183 RVA: 0x000091EF File Offset: 0x000073EF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060004A0 RID: 1184 RVA: 0x000091F7 File Offset: 0x000073F7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IThemedSpinnerAdapterInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x00009203 File Offset: 0x00007403
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IThemedSpinnerAdapterInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.widget.ThemedSpinnerAdapter'.");
			}
			return handle;
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x0000922E File Offset: 0x0000742E
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x00009260 File Offset: 0x00007460
		public IThemedSpinnerAdapterInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IThemedSpinnerAdapterInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x00009298 File Offset: 0x00007498
		private static Delegate GetGetDropDownViewThemeHandler()
		{
			if (IThemedSpinnerAdapterInvoker.cb_getDropDownViewTheme == null)
			{
				IThemedSpinnerAdapterInvoker.cb_getDropDownViewTheme = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IThemedSpinnerAdapterInvoker.n_GetDropDownViewTheme));
			}
			return IThemedSpinnerAdapterInvoker.cb_getDropDownViewTheme;
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x000092BC File Offset: 0x000074BC
		private static IntPtr n_GetDropDownViewTheme(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IThemedSpinnerAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DropDownViewTheme);
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x000092D0 File Offset: 0x000074D0
		private static Delegate GetSetDropDownViewTheme_Landroid_content_res_Resources_Theme_Handler()
		{
			if (IThemedSpinnerAdapterInvoker.cb_setDropDownViewTheme_Landroid_content_res_Resources_Theme_ == null)
			{
				IThemedSpinnerAdapterInvoker.cb_setDropDownViewTheme_Landroid_content_res_Resources_Theme_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IThemedSpinnerAdapterInvoker.n_SetDropDownViewTheme_Landroid_content_res_Resources_Theme_));
			}
			return IThemedSpinnerAdapterInvoker.cb_setDropDownViewTheme_Landroid_content_res_Resources_Theme_;
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x000092F4 File Offset: 0x000074F4
		private static void n_SetDropDownViewTheme_Landroid_content_res_Resources_Theme_(IntPtr jnienv, IntPtr native__this, IntPtr native_theme)
		{
			IThemedSpinnerAdapter @object = Java.Lang.Object.GetObject<IThemedSpinnerAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Resources.Theme object2 = Java.Lang.Object.GetObject<Resources.Theme>(native_theme, JniHandleOwnership.DoNotTransfer);
			@object.DropDownViewTheme = object2;
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060004A8 RID: 1192 RVA: 0x00009318 File Offset: 0x00007518
		// (set) Token: 0x060004A9 RID: 1193 RVA: 0x0000936C File Offset: 0x0000756C
		public unsafe Resources.Theme DropDownViewTheme
		{
			get
			{
				if (this.id_getDropDownViewTheme == IntPtr.Zero)
				{
					this.id_getDropDownViewTheme = JNIEnv.GetMethodID(this.class_ref, "getDropDownViewTheme", "()Landroid/content/res/Resources$Theme;");
				}
				return Java.Lang.Object.GetObject<Resources.Theme>(JNIEnv.CallObjectMethod(base.Handle, this.id_getDropDownViewTheme), JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				if (this.id_setDropDownViewTheme_Landroid_content_res_Resources_Theme_ == IntPtr.Zero)
				{
					this.id_setDropDownViewTheme_Landroid_content_res_Resources_Theme_ = JNIEnv.GetMethodID(this.class_ref, "setDropDownViewTheme", "(Landroid/content/res/Resources$Theme;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((value == null) ? IntPtr.Zero : value.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_setDropDownViewTheme_Landroid_content_res_Resources_Theme_, ptr);
			}
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x000093E0 File Offset: 0x000075E0
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

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060004AB RID: 1195 RVA: 0x00009491 File Offset: 0x00007691
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

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060004AC RID: 1196 RVA: 0x000094D1 File Offset: 0x000076D1
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

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060004AD RID: 1197 RVA: 0x00009511 File Offset: 0x00007711
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

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060004AE RID: 1198 RVA: 0x00009551 File Offset: 0x00007751
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

		// Token: 0x060004AF RID: 1199 RVA: 0x00009594 File Offset: 0x00007794
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

		// Token: 0x060004B0 RID: 1200 RVA: 0x00009600 File Offset: 0x00007800
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

		// Token: 0x060004B1 RID: 1201 RVA: 0x00009664 File Offset: 0x00007864
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

		// Token: 0x060004B2 RID: 1202 RVA: 0x000096C8 File Offset: 0x000078C8
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

		// Token: 0x060004B3 RID: 1203 RVA: 0x0000977C File Offset: 0x0000797C
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

		// Token: 0x060004B4 RID: 1204 RVA: 0x000097F0 File Offset: 0x000079F0
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

		// Token: 0x040000F5 RID: 245
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/widget/ThemedSpinnerAdapter", typeof(IThemedSpinnerAdapterInvoker));

		// Token: 0x040000F6 RID: 246
		private IntPtr class_ref;

		// Token: 0x040000F7 RID: 247
		private static Delegate cb_getDropDownViewTheme;

		// Token: 0x040000F8 RID: 248
		private static Delegate cb_setDropDownViewTheme_Landroid_content_res_Resources_Theme_;

		// Token: 0x040000F9 RID: 249
		private IntPtr id_getDropDownViewTheme;

		// Token: 0x040000FA RID: 250
		private IntPtr id_setDropDownViewTheme_Landroid_content_res_Resources_Theme_;

		// Token: 0x040000FB RID: 251
		private IntPtr id_getDropDownView_ILandroid_view_View_Landroid_view_ViewGroup_;

		// Token: 0x040000FC RID: 252
		private IntPtr id_getCount;

		// Token: 0x040000FD RID: 253
		private IntPtr id_hasStableIds;

		// Token: 0x040000FE RID: 254
		private IntPtr id_isEmpty;

		// Token: 0x040000FF RID: 255
		private IntPtr id_getViewTypeCount;

		// Token: 0x04000100 RID: 256
		private IntPtr id_getItem_I;

		// Token: 0x04000101 RID: 257
		private IntPtr id_getItemId_I;

		// Token: 0x04000102 RID: 258
		private IntPtr id_getItemViewType_I;

		// Token: 0x04000103 RID: 259
		private IntPtr id_getView_ILandroid_view_View_Landroid_view_ViewGroup_;

		// Token: 0x04000104 RID: 260
		private IntPtr id_registerDataSetObserver_Landroid_database_DataSetObserver_;

		// Token: 0x04000105 RID: 261
		private IntPtr id_unregisterDataSetObserver_Landroid_database_DataSetObserver_;
	}
}
