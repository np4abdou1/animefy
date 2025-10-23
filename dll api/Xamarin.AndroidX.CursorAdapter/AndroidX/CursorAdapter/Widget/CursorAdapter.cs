using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Database;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.Interop;
using Java.Lang;

namespace AndroidX.CursorAdapter.Widget
{
	// Token: 0x02000010 RID: 16
	[Register("androidx/cursoradapter/widget/CursorAdapter", DoNotGenerateAcw = true)]
	public abstract class CursorAdapter : BaseAdapter, IFilterable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000030 RID: 48 RVA: 0x0000207F File Offset: 0x0000027F
		// (set) Token: 0x06000031 RID: 49 RVA: 0x00002096 File Offset: 0x00000296
		[Register("mAutoRequery")]
		protected bool MAutoRequery
		{
			get
			{
				return CursorAdapter._members.InstanceFields.GetBooleanValue("mAutoRequery.Z", this);
			}
			set
			{
				CursorAdapter._members.InstanceFields.SetValue("mAutoRequery.Z", this, value);
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000032 RID: 50 RVA: 0x000020B0 File Offset: 0x000002B0
		// (set) Token: 0x06000033 RID: 51 RVA: 0x000020E0 File Offset: 0x000002E0
		[Register("mContext")]
		protected Context MContext
		{
			get
			{
				return Java.Lang.Object.GetObject<Context>(CursorAdapter._members.InstanceFields.GetObjectValue("mContext.Landroid/content/Context;", this).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
				try
				{
					CursorAdapter._members.InstanceFields.SetValue("mContext.Landroid/content/Context;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000034 RID: 52 RVA: 0x0000212C File Offset: 0x0000032C
		// (set) Token: 0x06000035 RID: 53 RVA: 0x0000215C File Offset: 0x0000035C
		[Register("mCursor")]
		protected ICursor MCursor
		{
			get
			{
				return Java.Lang.Object.GetObject<ICursor>(CursorAdapter._members.InstanceFields.GetObjectValue("mCursor.Landroid/database/Cursor;", this).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
				try
				{
					CursorAdapter._members.InstanceFields.SetValue("mCursor.Landroid/database/Cursor;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000036 RID: 54 RVA: 0x000021A8 File Offset: 0x000003A8
		// (set) Token: 0x06000037 RID: 55 RVA: 0x000021D8 File Offset: 0x000003D8
		[Register("mDataSetObserver")]
		protected DataSetObserver MDataSetObserver
		{
			get
			{
				return Java.Lang.Object.GetObject<DataSetObserver>(CursorAdapter._members.InstanceFields.GetObjectValue("mDataSetObserver.Landroid/database/DataSetObserver;", this).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
				try
				{
					CursorAdapter._members.InstanceFields.SetValue("mDataSetObserver.Landroid/database/DataSetObserver;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000038 RID: 56 RVA: 0x00002224 File Offset: 0x00000424
		// (set) Token: 0x06000039 RID: 57 RVA: 0x0000223B File Offset: 0x0000043B
		[Register("mDataValid")]
		protected bool MDataValid
		{
			get
			{
				return CursorAdapter._members.InstanceFields.GetBooleanValue("mDataValid.Z", this);
			}
			set
			{
				CursorAdapter._members.InstanceFields.SetValue("mDataValid.Z", this, value);
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600003A RID: 58 RVA: 0x00002254 File Offset: 0x00000454
		// (set) Token: 0x0600003B RID: 59 RVA: 0x00002284 File Offset: 0x00000484
		[Register("mFilterQueryProvider")]
		protected IFilterQueryProvider MFilterQueryProvider
		{
			get
			{
				return Java.Lang.Object.GetObject<IFilterQueryProvider>(CursorAdapter._members.InstanceFields.GetObjectValue("mFilterQueryProvider.Landroid/widget/FilterQueryProvider;", this).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
				try
				{
					CursorAdapter._members.InstanceFields.SetValue("mFilterQueryProvider.Landroid/widget/FilterQueryProvider;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600003C RID: 60 RVA: 0x000022D0 File Offset: 0x000004D0
		// (set) Token: 0x0600003D RID: 61 RVA: 0x000022E7 File Offset: 0x000004E7
		[Register("mRowIDColumn")]
		protected int MRowIDColumn
		{
			get
			{
				return CursorAdapter._members.InstanceFields.GetInt32Value("mRowIDColumn.I", this);
			}
			set
			{
				CursorAdapter._members.InstanceFields.SetValue("mRowIDColumn.I", this, value);
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600003E RID: 62 RVA: 0x00002300 File Offset: 0x00000500
		internal static IntPtr class_ref
		{
			get
			{
				return CursorAdapter._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600003F RID: 63 RVA: 0x00002324 File Offset: 0x00000524
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CursorAdapter._members;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000040 RID: 64 RVA: 0x0000232C File Offset: 0x0000052C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CursorAdapter._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000041 RID: 65 RVA: 0x00002350 File Offset: 0x00000550
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CursorAdapter._members.ManagedPeerType;
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x0000235C File Offset: 0x0000055C
		protected CursorAdapter(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002368 File Offset: 0x00000568
		[Register(".ctor", "(Landroid/content/Context;Landroid/database/Cursor;)V", "")]
		public unsafe CursorAdapter(Context context, ICursor c) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((c == null) ? IntPtr.Zero : ((Java.Lang.Object)c).Handle);
				base.SetHandle(CursorAdapter._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/database/Cursor;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				CursorAdapter._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/database/Cursor;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(c);
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002444 File Offset: 0x00000644
		[Register(".ctor", "(Landroid/content/Context;Landroid/database/Cursor;Z)V", "")]
		public unsafe CursorAdapter(Context context, ICursor c, bool autoRequery) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((c == null) ? IntPtr.Zero : ((Java.Lang.Object)c).Handle);
				ptr[2] = new JniArgumentValue(autoRequery);
				base.SetHandle(CursorAdapter._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/database/Cursor;Z)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				CursorAdapter._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/database/Cursor;Z)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(c);
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002534 File Offset: 0x00000734
		[Register(".ctor", "(Landroid/content/Context;Landroid/database/Cursor;I)V", "")]
		public unsafe CursorAdapter(Context context, ICursor c, int flags) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((c == null) ? IntPtr.Zero : ((Java.Lang.Object)c).Handle);
				ptr[2] = new JniArgumentValue(flags);
				base.SetHandle(CursorAdapter._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/database/Cursor;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				CursorAdapter._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/database/Cursor;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(c);
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002624 File Offset: 0x00000824
		private static Delegate GetGetCountHandler()
		{
			if (CursorAdapter.cb_getCount == null)
			{
				CursorAdapter.cb_getCount = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(CursorAdapter.n_GetCount));
			}
			return CursorAdapter.cb_getCount;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002648 File Offset: 0x00000848
		private static int n_GetCount(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<CursorAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Count;
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000048 RID: 72 RVA: 0x00002657 File Offset: 0x00000857
		public override int Count
		{
			[Register("getCount", "()I", "GetGetCountHandler")]
			get
			{
				return CursorAdapter._members.InstanceMethods.InvokeVirtualInt32Method("getCount.()I", this, null);
			}
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002670 File Offset: 0x00000870
		private static Delegate GetGetCursorHandler()
		{
			if (CursorAdapter.cb_getCursor == null)
			{
				CursorAdapter.cb_getCursor = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(CursorAdapter.n_GetCursor));
			}
			return CursorAdapter.cb_getCursor;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002694 File Offset: 0x00000894
		private static IntPtr n_GetCursor(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<CursorAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Cursor);
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600004B RID: 75 RVA: 0x000026A8 File Offset: 0x000008A8
		public virtual ICursor Cursor
		{
			[Register("getCursor", "()Landroid/database/Cursor;", "GetGetCursorHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ICursor>(CursorAdapter._members.InstanceMethods.InvokeVirtualObjectMethod("getCursor.()Landroid/database/Cursor;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000026DA File Offset: 0x000008DA
		private static Delegate GetGetFilterHandler()
		{
			if (CursorAdapter.cb_getFilter == null)
			{
				CursorAdapter.cb_getFilter = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(CursorAdapter.n_GetFilter));
			}
			return CursorAdapter.cb_getFilter;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000026FE File Offset: 0x000008FE
		private static IntPtr n_GetFilter(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<CursorAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Filter);
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600004E RID: 78 RVA: 0x00002714 File Offset: 0x00000914
		public virtual Filter Filter
		{
			[Register("getFilter", "()Landroid/widget/Filter;", "GetGetFilterHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Filter>(CursorAdapter._members.InstanceMethods.InvokeVirtualObjectMethod("getFilter.()Landroid/widget/Filter;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002746 File Offset: 0x00000946
		private static Delegate GetGetFilterQueryProviderHandler()
		{
			if (CursorAdapter.cb_getFilterQueryProvider == null)
			{
				CursorAdapter.cb_getFilterQueryProvider = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(CursorAdapter.n_GetFilterQueryProvider));
			}
			return CursorAdapter.cb_getFilterQueryProvider;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x0000276A File Offset: 0x0000096A
		private static IntPtr n_GetFilterQueryProvider(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<CursorAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).FilterQueryProvider);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x0000277E File Offset: 0x0000097E
		private static Delegate GetSetFilterQueryProvider_Landroid_widget_FilterQueryProvider_Handler()
		{
			if (CursorAdapter.cb_setFilterQueryProvider_Landroid_widget_FilterQueryProvider_ == null)
			{
				CursorAdapter.cb_setFilterQueryProvider_Landroid_widget_FilterQueryProvider_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(CursorAdapter.n_SetFilterQueryProvider_Landroid_widget_FilterQueryProvider_));
			}
			return CursorAdapter.cb_setFilterQueryProvider_Landroid_widget_FilterQueryProvider_;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000027A4 File Offset: 0x000009A4
		private static void n_SetFilterQueryProvider_Landroid_widget_FilterQueryProvider_(IntPtr jnienv, IntPtr native__this, IntPtr native_filterQueryProvider)
		{
			CursorAdapter @object = Java.Lang.Object.GetObject<CursorAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IFilterQueryProvider object2 = Java.Lang.Object.GetObject<IFilterQueryProvider>(native_filterQueryProvider, JniHandleOwnership.DoNotTransfer);
			@object.FilterQueryProvider = object2;
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000053 RID: 83 RVA: 0x000027C8 File Offset: 0x000009C8
		// (set) Token: 0x06000054 RID: 84 RVA: 0x000027FC File Offset: 0x000009FC
		public unsafe virtual IFilterQueryProvider FilterQueryProvider
		{
			[Register("getFilterQueryProvider", "()Landroid/widget/FilterQueryProvider;", "GetGetFilterQueryProviderHandler")]
			get
			{
				return Java.Lang.Object.GetObject<IFilterQueryProvider>(CursorAdapter._members.InstanceMethods.InvokeVirtualObjectMethod("getFilterQueryProvider.()Landroid/widget/FilterQueryProvider;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setFilterQueryProvider", "(Landroid/widget/FilterQueryProvider;)V", "GetSetFilterQueryProvider_Landroid_widget_FilterQueryProvider_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : ((Java.Lang.Object)value).Handle);
					CursorAdapter._members.InstanceMethods.InvokeVirtualVoidMethod("setFilterQueryProvider.(Landroid/widget/FilterQueryProvider;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002864 File Offset: 0x00000A64
		private static Delegate GetBindView_Landroid_view_View_Landroid_content_Context_Landroid_database_Cursor_Handler()
		{
			if (CursorAdapter.cb_bindView_Landroid_view_View_Landroid_content_Context_Landroid_database_Cursor_ == null)
			{
				CursorAdapter.cb_bindView_Landroid_view_View_Landroid_content_Context_Landroid_database_Cursor_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(CursorAdapter.n_BindView_Landroid_view_View_Landroid_content_Context_Landroid_database_Cursor_));
			}
			return CursorAdapter.cb_bindView_Landroid_view_View_Landroid_content_Context_Landroid_database_Cursor_;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002888 File Offset: 0x00000A88
		private static void n_BindView_Landroid_view_View_Landroid_content_Context_Landroid_database_Cursor_(IntPtr jnienv, IntPtr native__this, IntPtr native_view, IntPtr native_context, IntPtr native_cursor)
		{
			CursorAdapter @object = Java.Lang.Object.GetObject<CursorAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_view, JniHandleOwnership.DoNotTransfer);
			Context object3 = Java.Lang.Object.GetObject<Context>(native_context, JniHandleOwnership.DoNotTransfer);
			ICursor object4 = Java.Lang.Object.GetObject<ICursor>(native_cursor, JniHandleOwnership.DoNotTransfer);
			@object.BindView(object2, object3, object4);
		}

		// Token: 0x06000057 RID: 87
		[Register("bindView", "(Landroid/view/View;Landroid/content/Context;Landroid/database/Cursor;)V", "GetBindView_Landroid_view_View_Landroid_content_Context_Landroid_database_Cursor_Handler")]
		public abstract void BindView(View view, Context context, ICursor cursor);

		// Token: 0x06000058 RID: 88 RVA: 0x000028BE File Offset: 0x00000ABE
		private static Delegate GetChangeCursor_Landroid_database_Cursor_Handler()
		{
			if (CursorAdapter.cb_changeCursor_Landroid_database_Cursor_ == null)
			{
				CursorAdapter.cb_changeCursor_Landroid_database_Cursor_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(CursorAdapter.n_ChangeCursor_Landroid_database_Cursor_));
			}
			return CursorAdapter.cb_changeCursor_Landroid_database_Cursor_;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000028E4 File Offset: 0x00000AE4
		private static void n_ChangeCursor_Landroid_database_Cursor_(IntPtr jnienv, IntPtr native__this, IntPtr native_cursor)
		{
			CursorAdapter @object = Java.Lang.Object.GetObject<CursorAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICursor object2 = Java.Lang.Object.GetObject<ICursor>(native_cursor, JniHandleOwnership.DoNotTransfer);
			@object.ChangeCursor(object2);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002908 File Offset: 0x00000B08
		[Register("changeCursor", "(Landroid/database/Cursor;)V", "GetChangeCursor_Landroid_database_Cursor_Handler")]
		public unsafe virtual void ChangeCursor(ICursor cursor)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((cursor == null) ? IntPtr.Zero : ((Java.Lang.Object)cursor).Handle);
				CursorAdapter._members.InstanceMethods.InvokeVirtualVoidMethod("changeCursor.(Landroid/database/Cursor;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(cursor);
			}
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002970 File Offset: 0x00000B70
		private static Delegate GetConvertToString_Landroid_database_Cursor_Handler()
		{
			if (CursorAdapter.cb_convertToString_Landroid_database_Cursor_ == null)
			{
				CursorAdapter.cb_convertToString_Landroid_database_Cursor_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(CursorAdapter.n_ConvertToString_Landroid_database_Cursor_));
			}
			return CursorAdapter.cb_convertToString_Landroid_database_Cursor_;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002994 File Offset: 0x00000B94
		private static IntPtr n_ConvertToString_Landroid_database_Cursor_(IntPtr jnienv, IntPtr native__this, IntPtr native_cursor)
		{
			CursorAdapter @object = Java.Lang.Object.GetObject<CursorAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICursor object2 = Java.Lang.Object.GetObject<ICursor>(native_cursor, JniHandleOwnership.DoNotTransfer);
			return CharSequence.ToLocalJniHandle(@object.ConvertToStringFormatted(object2));
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000029BC File Offset: 0x00000BBC
		[Register("convertToString", "(Landroid/database/Cursor;)Ljava/lang/CharSequence;", "GetConvertToString_Landroid_database_Cursor_Handler")]
		public unsafe virtual ICharSequence ConvertToStringFormatted(ICursor cursor)
		{
			ICharSequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((cursor == null) ? IntPtr.Zero : ((Java.Lang.Object)cursor).Handle);
				@object = Java.Lang.Object.GetObject<ICharSequence>(CursorAdapter._members.InstanceMethods.InvokeVirtualObjectMethod("convertToString.(Landroid/database/Cursor;)Ljava/lang/CharSequence;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(cursor);
			}
			return @object;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002A34 File Offset: 0x00000C34
		public string ConvertToString(ICursor cursor)
		{
			ICharSequence charSequence = this.ConvertToStringFormatted(cursor);
			if (charSequence == null)
			{
				return null;
			}
			return charSequence.ToString();
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002A48 File Offset: 0x00000C48
		private static Delegate GetGetItem_IHandler()
		{
			if (CursorAdapter.cb_getItem_I == null)
			{
				CursorAdapter.cb_getItem_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(CursorAdapter.n_GetItem_I));
			}
			return CursorAdapter.cb_getItem_I;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002A6C File Offset: 0x00000C6C
		private static IntPtr n_GetItem_I(IntPtr jnienv, IntPtr native__this, int position)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<CursorAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetItem(position));
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002A84 File Offset: 0x00000C84
		[Register("getItem", "(I)Ljava/lang/Object;", "GetGetItem_IHandler")]
		public unsafe override Java.Lang.Object GetItem(int position)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(position);
			return Java.Lang.Object.GetObject<Java.Lang.Object>(CursorAdapter._members.InstanceMethods.InvokeVirtualObjectMethod("getItem.(I)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002ACD File Offset: 0x00000CCD
		private static Delegate GetGetItemId_IHandler()
		{
			if (CursorAdapter.cb_getItemId_I == null)
			{
				CursorAdapter.cb_getItemId_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_J(CursorAdapter.n_GetItemId_I));
			}
			return CursorAdapter.cb_getItemId_I;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002AF1 File Offset: 0x00000CF1
		private static long n_GetItemId_I(IntPtr jnienv, IntPtr native__this, int position)
		{
			return Java.Lang.Object.GetObject<CursorAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetItemId(position);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002B04 File Offset: 0x00000D04
		[Register("getItemId", "(I)J", "GetGetItemId_IHandler")]
		public unsafe override long GetItemId(int position)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(position);
			return CursorAdapter._members.InstanceMethods.InvokeVirtualInt64Method("getItemId.(I)J", this, ptr);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002B3F File Offset: 0x00000D3F
		private static Delegate GetGetView_ILandroid_view_View_Landroid_view_ViewGroup_Handler()
		{
			if (CursorAdapter.cb_getView_ILandroid_view_View_Landroid_view_ViewGroup_ == null)
			{
				CursorAdapter.cb_getView_ILandroid_view_View_Landroid_view_ViewGroup_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPILL_L(CursorAdapter.n_GetView_ILandroid_view_View_Landroid_view_ViewGroup_));
			}
			return CursorAdapter.cb_getView_ILandroid_view_View_Landroid_view_ViewGroup_;
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002B64 File Offset: 0x00000D64
		private static IntPtr n_GetView_ILandroid_view_View_Landroid_view_ViewGroup_(IntPtr jnienv, IntPtr native__this, int position, IntPtr native_convertView, IntPtr native_parent)
		{
			BaseAdapter @object = Java.Lang.Object.GetObject<CursorAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_convertView, JniHandleOwnership.DoNotTransfer);
			ViewGroup object3 = Java.Lang.Object.GetObject<ViewGroup>(native_parent, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetView(position, object2, object3));
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002B98 File Offset: 0x00000D98
		[Register("getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", "GetGetView_ILandroid_view_View_Landroid_view_ViewGroup_Handler")]
		public unsafe override View GetView(int position, View convertView, ViewGroup parent)
		{
			View @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(position);
				ptr[1] = new JniArgumentValue((convertView == null) ? IntPtr.Zero : convertView.Handle);
				ptr[2] = new JniArgumentValue((parent == null) ? IntPtr.Zero : parent.Handle);
				@object = Java.Lang.Object.GetObject<View>(CursorAdapter._members.InstanceMethods.InvokeVirtualObjectMethod("getView.(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(convertView);
				GC.KeepAlive(parent);
			}
			return @object;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002C4C File Offset: 0x00000E4C
		private static Delegate GetInit_Landroid_content_Context_Landroid_database_Cursor_ZHandler()
		{
			if (CursorAdapter.cb_init_Landroid_content_Context_Landroid_database_Cursor_Z == null)
			{
				CursorAdapter.cb_init_Landroid_content_Context_Landroid_database_Cursor_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLZ_V(CursorAdapter.n_Init_Landroid_content_Context_Landroid_database_Cursor_Z));
			}
			return CursorAdapter.cb_init_Landroid_content_Context_Landroid_database_Cursor_Z;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002C70 File Offset: 0x00000E70
		private static void n_Init_Landroid_content_Context_Landroid_database_Cursor_Z(IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_c, bool autoRequery)
		{
			CursorAdapter @object = Java.Lang.Object.GetObject<CursorAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_context, JniHandleOwnership.DoNotTransfer);
			ICursor object3 = Java.Lang.Object.GetObject<ICursor>(native_c, JniHandleOwnership.DoNotTransfer);
			@object.Init(object2, object3, autoRequery);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002CA0 File Offset: 0x00000EA0
		[Register("init", "(Landroid/content/Context;Landroid/database/Cursor;Z)V", "GetInit_Landroid_content_Context_Landroid_database_Cursor_ZHandler")]
		protected unsafe virtual void Init(Context context, ICursor c, bool autoRequery)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((c == null) ? IntPtr.Zero : ((Java.Lang.Object)c).Handle);
				ptr[2] = new JniArgumentValue(autoRequery);
				CursorAdapter._members.InstanceMethods.InvokeVirtualVoidMethod("init.(Landroid/content/Context;Landroid/database/Cursor;Z)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(c);
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002D48 File Offset: 0x00000F48
		private static Delegate GetNewDropDownView_Landroid_content_Context_Landroid_database_Cursor_Landroid_view_ViewGroup_Handler()
		{
			if (CursorAdapter.cb_newDropDownView_Landroid_content_Context_Landroid_database_Cursor_Landroid_view_ViewGroup_ == null)
			{
				CursorAdapter.cb_newDropDownView_Landroid_content_Context_Landroid_database_Cursor_Landroid_view_ViewGroup_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_L(CursorAdapter.n_NewDropDownView_Landroid_content_Context_Landroid_database_Cursor_Landroid_view_ViewGroup_));
			}
			return CursorAdapter.cb_newDropDownView_Landroid_content_Context_Landroid_database_Cursor_Landroid_view_ViewGroup_;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00002D6C File Offset: 0x00000F6C
		private static IntPtr n_NewDropDownView_Landroid_content_Context_Landroid_database_Cursor_Landroid_view_ViewGroup_(IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_cursor, IntPtr native_parent)
		{
			CursorAdapter @object = Java.Lang.Object.GetObject<CursorAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_context, JniHandleOwnership.DoNotTransfer);
			ICursor object3 = Java.Lang.Object.GetObject<ICursor>(native_cursor, JniHandleOwnership.DoNotTransfer);
			ViewGroup object4 = Java.Lang.Object.GetObject<ViewGroup>(native_parent, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.NewDropDownView(object2, object3, object4));
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002DA8 File Offset: 0x00000FA8
		[Register("newDropDownView", "(Landroid/content/Context;Landroid/database/Cursor;Landroid/view/ViewGroup;)Landroid/view/View;", "GetNewDropDownView_Landroid_content_Context_Landroid_database_Cursor_Landroid_view_ViewGroup_Handler")]
		public unsafe virtual View NewDropDownView(Context context, ICursor cursor, ViewGroup parent)
		{
			View @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((cursor == null) ? IntPtr.Zero : ((Java.Lang.Object)cursor).Handle);
				ptr[2] = new JniArgumentValue((parent == null) ? IntPtr.Zero : parent.Handle);
				@object = Java.Lang.Object.GetObject<View>(CursorAdapter._members.InstanceMethods.InvokeVirtualObjectMethod("newDropDownView.(Landroid/content/Context;Landroid/database/Cursor;Landroid/view/ViewGroup;)Landroid/view/View;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(cursor);
				GC.KeepAlive(parent);
			}
			return @object;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00002E74 File Offset: 0x00001074
		private static Delegate GetNewView_Landroid_content_Context_Landroid_database_Cursor_Landroid_view_ViewGroup_Handler()
		{
			if (CursorAdapter.cb_newView_Landroid_content_Context_Landroid_database_Cursor_Landroid_view_ViewGroup_ == null)
			{
				CursorAdapter.cb_newView_Landroid_content_Context_Landroid_database_Cursor_Landroid_view_ViewGroup_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_L(CursorAdapter.n_NewView_Landroid_content_Context_Landroid_database_Cursor_Landroid_view_ViewGroup_));
			}
			return CursorAdapter.cb_newView_Landroid_content_Context_Landroid_database_Cursor_Landroid_view_ViewGroup_;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002E98 File Offset: 0x00001098
		private static IntPtr n_NewView_Landroid_content_Context_Landroid_database_Cursor_Landroid_view_ViewGroup_(IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_cursor, IntPtr native_parent)
		{
			CursorAdapter @object = Java.Lang.Object.GetObject<CursorAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_context, JniHandleOwnership.DoNotTransfer);
			ICursor object3 = Java.Lang.Object.GetObject<ICursor>(native_cursor, JniHandleOwnership.DoNotTransfer);
			ViewGroup object4 = Java.Lang.Object.GetObject<ViewGroup>(native_parent, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.NewView(object2, object3, object4));
		}

		// Token: 0x06000070 RID: 112
		[Register("newView", "(Landroid/content/Context;Landroid/database/Cursor;Landroid/view/ViewGroup;)Landroid/view/View;", "GetNewView_Landroid_content_Context_Landroid_database_Cursor_Landroid_view_ViewGroup_Handler")]
		public abstract View NewView(Context context, ICursor cursor, ViewGroup parent);

		// Token: 0x06000071 RID: 113 RVA: 0x00002ED3 File Offset: 0x000010D3
		private static Delegate GetOnContentChangedHandler()
		{
			if (CursorAdapter.cb_onContentChanged == null)
			{
				CursorAdapter.cb_onContentChanged = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(CursorAdapter.n_OnContentChanged));
			}
			return CursorAdapter.cb_onContentChanged;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00002EF7 File Offset: 0x000010F7
		private static void n_OnContentChanged(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<CursorAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnContentChanged();
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00002F06 File Offset: 0x00001106
		[Register("onContentChanged", "()V", "GetOnContentChangedHandler")]
		protected virtual void OnContentChanged()
		{
			CursorAdapter._members.InstanceMethods.InvokeVirtualVoidMethod("onContentChanged.()V", this, null);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00002F1F File Offset: 0x0000111F
		private static Delegate GetRunQueryOnBackgroundThread_Ljava_lang_CharSequence_Handler()
		{
			if (CursorAdapter.cb_runQueryOnBackgroundThread_Ljava_lang_CharSequence_ == null)
			{
				CursorAdapter.cb_runQueryOnBackgroundThread_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(CursorAdapter.n_RunQueryOnBackgroundThread_Ljava_lang_CharSequence_));
			}
			return CursorAdapter.cb_runQueryOnBackgroundThread_Ljava_lang_CharSequence_;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00002F44 File Offset: 0x00001144
		private static IntPtr n_RunQueryOnBackgroundThread_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_constraint)
		{
			CursorAdapter @object = Java.Lang.Object.GetObject<CursorAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_constraint, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.RunQueryOnBackgroundThread(object2));
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00002F6C File Offset: 0x0000116C
		[Register("runQueryOnBackgroundThread", "(Ljava/lang/CharSequence;)Landroid/database/Cursor;", "GetRunQueryOnBackgroundThread_Ljava_lang_CharSequence_Handler")]
		public unsafe virtual ICursor RunQueryOnBackgroundThread(ICharSequence constraint)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(constraint);
			ICursor @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<ICursor>(CursorAdapter._members.InstanceMethods.InvokeVirtualObjectMethod("runQueryOnBackgroundThread.(Ljava/lang/CharSequence;)Landroid/database/Cursor;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(constraint);
			}
			return @object;
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00002FE0 File Offset: 0x000011E0
		public ICursor RunQueryOnBackgroundThread(string constraint)
		{
			Java.Lang.String @string = (constraint == null) ? null : new Java.Lang.String(constraint);
			ICursor result = this.RunQueryOnBackgroundThread(@string);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000300A File Offset: 0x0000120A
		private static Delegate GetSwapCursor_Landroid_database_Cursor_Handler()
		{
			if (CursorAdapter.cb_swapCursor_Landroid_database_Cursor_ == null)
			{
				CursorAdapter.cb_swapCursor_Landroid_database_Cursor_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(CursorAdapter.n_SwapCursor_Landroid_database_Cursor_));
			}
			return CursorAdapter.cb_swapCursor_Landroid_database_Cursor_;
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00003030 File Offset: 0x00001230
		private static IntPtr n_SwapCursor_Landroid_database_Cursor_(IntPtr jnienv, IntPtr native__this, IntPtr native_newCursor)
		{
			CursorAdapter @object = Java.Lang.Object.GetObject<CursorAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICursor object2 = Java.Lang.Object.GetObject<ICursor>(native_newCursor, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SwapCursor(object2));
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00003058 File Offset: 0x00001258
		[Register("swapCursor", "(Landroid/database/Cursor;)Landroid/database/Cursor;", "GetSwapCursor_Landroid_database_Cursor_Handler")]
		public unsafe virtual ICursor SwapCursor(ICursor newCursor)
		{
			ICursor @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((newCursor == null) ? IntPtr.Zero : ((Java.Lang.Object)newCursor).Handle);
				@object = Java.Lang.Object.GetObject<ICursor>(CursorAdapter._members.InstanceMethods.InvokeVirtualObjectMethod("swapCursor.(Landroid/database/Cursor;)Landroid/database/Cursor;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(newCursor);
			}
			return @object;
		}

		// Token: 0x04000003 RID: 3
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/cursoradapter/widget/CursorAdapter", typeof(CursorAdapter));

		// Token: 0x04000004 RID: 4
		private static Delegate cb_getCount;

		// Token: 0x04000005 RID: 5
		private static Delegate cb_getCursor;

		// Token: 0x04000006 RID: 6
		private static Delegate cb_getFilter;

		// Token: 0x04000007 RID: 7
		private static Delegate cb_getFilterQueryProvider;

		// Token: 0x04000008 RID: 8
		private static Delegate cb_setFilterQueryProvider_Landroid_widget_FilterQueryProvider_;

		// Token: 0x04000009 RID: 9
		private static Delegate cb_bindView_Landroid_view_View_Landroid_content_Context_Landroid_database_Cursor_;

		// Token: 0x0400000A RID: 10
		private static Delegate cb_changeCursor_Landroid_database_Cursor_;

		// Token: 0x0400000B RID: 11
		private static Delegate cb_convertToString_Landroid_database_Cursor_;

		// Token: 0x0400000C RID: 12
		private static Delegate cb_getItem_I;

		// Token: 0x0400000D RID: 13
		private static Delegate cb_getItemId_I;

		// Token: 0x0400000E RID: 14
		private static Delegate cb_getView_ILandroid_view_View_Landroid_view_ViewGroup_;

		// Token: 0x0400000F RID: 15
		private static Delegate cb_init_Landroid_content_Context_Landroid_database_Cursor_Z;

		// Token: 0x04000010 RID: 16
		private static Delegate cb_newDropDownView_Landroid_content_Context_Landroid_database_Cursor_Landroid_view_ViewGroup_;

		// Token: 0x04000011 RID: 17
		private static Delegate cb_newView_Landroid_content_Context_Landroid_database_Cursor_Landroid_view_ViewGroup_;

		// Token: 0x04000012 RID: 18
		private static Delegate cb_onContentChanged;

		// Token: 0x04000013 RID: 19
		private static Delegate cb_runQueryOnBackgroundThread_Ljava_lang_CharSequence_;

		// Token: 0x04000014 RID: 20
		private static Delegate cb_swapCursor_Landroid_database_Cursor_;
	}
}
