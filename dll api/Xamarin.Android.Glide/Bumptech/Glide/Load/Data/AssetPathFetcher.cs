using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content.Res;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Data
{
	// Token: 0x0200018B RID: 395
	[Register("com/bumptech/glide/load/data/AssetPathFetcher", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public abstract class AssetPathFetcher : Java.Lang.Object, IDataFetcher, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x060013FB RID: 5115 RVA: 0x000400B0 File Offset: 0x0003E2B0
		internal static IntPtr class_ref
		{
			get
			{
				return AssetPathFetcher._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x060013FC RID: 5116 RVA: 0x000400D4 File Offset: 0x0003E2D4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AssetPathFetcher._members;
			}
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x060013FD RID: 5117 RVA: 0x000400DC File Offset: 0x0003E2DC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AssetPathFetcher._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x060013FE RID: 5118 RVA: 0x00040100 File Offset: 0x0003E300
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AssetPathFetcher._members.ManagedPeerType;
			}
		}

		// Token: 0x060013FF RID: 5119 RVA: 0x0004010C File Offset: 0x0003E30C
		protected AssetPathFetcher(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001400 RID: 5120 RVA: 0x00040118 File Offset: 0x0003E318
		[Register(".ctor", "(Landroid/content/res/AssetManager;Ljava/lang/String;)V", "")]
		public unsafe AssetPathFetcher(AssetManager assetManager, string assetPath) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(assetPath);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((assetManager == null) ? IntPtr.Zero : assetManager.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				base.SetHandle(AssetPathFetcher._members.InstanceMethods.StartCreateInstance("(Landroid/content/res/AssetManager;Ljava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				AssetPathFetcher._members.InstanceMethods.FinishCreateInstance("(Landroid/content/res/AssetManager;Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(assetManager);
			}
		}

		// Token: 0x06001401 RID: 5121 RVA: 0x000401E4 File Offset: 0x0003E3E4
		private static Delegate GetGetDataSourceHandler()
		{
			if (AssetPathFetcher.cb_getDataSource == null)
			{
				AssetPathFetcher.cb_getDataSource = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AssetPathFetcher.n_GetDataSource));
			}
			return AssetPathFetcher.cb_getDataSource;
		}

		// Token: 0x06001402 RID: 5122 RVA: 0x00040208 File Offset: 0x0003E408
		private static IntPtr n_GetDataSource(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AssetPathFetcher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DataSource);
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x06001403 RID: 5123 RVA: 0x0004021C File Offset: 0x0003E41C
		public virtual DataSource DataSource
		{
			[Register("getDataSource", "()Lcom/bumptech/glide/load/DataSource;", "GetGetDataSourceHandler")]
			get
			{
				return Java.Lang.Object.GetObject<DataSource>(AssetPathFetcher._members.InstanceMethods.InvokeVirtualObjectMethod("getDataSource.()Lcom/bumptech/glide/load/DataSource;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06001404 RID: 5124 RVA: 0x0004024E File Offset: 0x0003E44E
		private static Delegate GetCancelHandler()
		{
			if (AssetPathFetcher.cb_cancel == null)
			{
				AssetPathFetcher.cb_cancel = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(AssetPathFetcher.n_Cancel));
			}
			return AssetPathFetcher.cb_cancel;
		}

		// Token: 0x06001405 RID: 5125 RVA: 0x00040272 File Offset: 0x0003E472
		private static void n_Cancel(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<AssetPathFetcher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Cancel();
		}

		// Token: 0x06001406 RID: 5126 RVA: 0x00040281 File Offset: 0x0003E481
		[Register("cancel", "()V", "GetCancelHandler")]
		public virtual void Cancel()
		{
			AssetPathFetcher._members.InstanceMethods.InvokeVirtualVoidMethod("cancel.()V", this, null);
		}

		// Token: 0x06001407 RID: 5127 RVA: 0x0004029A File Offset: 0x0003E49A
		private static Delegate GetCleanupHandler()
		{
			if (AssetPathFetcher.cb_cleanup == null)
			{
				AssetPathFetcher.cb_cleanup = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(AssetPathFetcher.n_Cleanup));
			}
			return AssetPathFetcher.cb_cleanup;
		}

		// Token: 0x06001408 RID: 5128 RVA: 0x000402BE File Offset: 0x0003E4BE
		private static void n_Cleanup(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<AssetPathFetcher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Cleanup();
		}

		// Token: 0x06001409 RID: 5129 RVA: 0x000402CD File Offset: 0x0003E4CD
		[Register("cleanup", "()V", "GetCleanupHandler")]
		public virtual void Cleanup()
		{
			AssetPathFetcher._members.InstanceMethods.InvokeVirtualVoidMethod("cleanup.()V", this, null);
		}

		// Token: 0x0600140A RID: 5130 RVA: 0x000402E6 File Offset: 0x0003E4E6
		private static Delegate GetClose_Ljava_lang_Object_Handler()
		{
			if (AssetPathFetcher.cb_close_Ljava_lang_Object_ == null)
			{
				AssetPathFetcher.cb_close_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AssetPathFetcher.n_Close_Ljava_lang_Object_));
			}
			return AssetPathFetcher.cb_close_Ljava_lang_Object_;
		}

		// Token: 0x0600140B RID: 5131 RVA: 0x0004030C File Offset: 0x0003E50C
		private static void n_Close_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			AssetPathFetcher @object = Java.Lang.Object.GetObject<AssetPathFetcher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.Close(object2);
		}

		// Token: 0x0600140C RID: 5132
		[Register("close", "(Ljava/lang/Object;)V", "GetClose_Ljava_lang_Object_Handler")]
		protected abstract void Close(Java.Lang.Object p0);

		// Token: 0x0600140D RID: 5133 RVA: 0x0004032F File Offset: 0x0003E52F
		private static Delegate GetLoadData_Lcom_bumptech_glide_Priority_Lcom_bumptech_glide_load_data_DataFetcher_DataCallback_Handler()
		{
			if (AssetPathFetcher.cb_loadData_Lcom_bumptech_glide_Priority_Lcom_bumptech_glide_load_data_DataFetcher_DataCallback_ == null)
			{
				AssetPathFetcher.cb_loadData_Lcom_bumptech_glide_Priority_Lcom_bumptech_glide_load_data_DataFetcher_DataCallback_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(AssetPathFetcher.n_LoadData_Lcom_bumptech_glide_Priority_Lcom_bumptech_glide_load_data_DataFetcher_DataCallback_));
			}
			return AssetPathFetcher.cb_loadData_Lcom_bumptech_glide_Priority_Lcom_bumptech_glide_load_data_DataFetcher_DataCallback_;
		}

		// Token: 0x0600140E RID: 5134 RVA: 0x00040354 File Offset: 0x0003E554
		private static void n_LoadData_Lcom_bumptech_glide_Priority_Lcom_bumptech_glide_load_data_DataFetcher_DataCallback_(IntPtr jnienv, IntPtr native__this, IntPtr native_priority, IntPtr native__callback)
		{
			AssetPathFetcher @object = Java.Lang.Object.GetObject<AssetPathFetcher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Priority object2 = Java.Lang.Object.GetObject<Priority>(native_priority, JniHandleOwnership.DoNotTransfer);
			IDataFetcherDataCallback object3 = Java.Lang.Object.GetObject<IDataFetcherDataCallback>(native__callback, JniHandleOwnership.DoNotTransfer);
			@object.LoadData(object2, object3);
		}

		// Token: 0x0600140F RID: 5135 RVA: 0x00040380 File Offset: 0x0003E580
		[Register("loadData", "(Lcom/bumptech/glide/Priority;Lcom/bumptech/glide/load/data/DataFetcher$DataCallback;)V", "GetLoadData_Lcom_bumptech_glide_Priority_Lcom_bumptech_glide_load_data_DataFetcher_DataCallback_Handler")]
		public unsafe virtual void LoadData(Priority priority, IDataFetcherDataCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((priority == null) ? IntPtr.Zero : priority.Handle);
				ptr[1] = new JniArgumentValue((callback == null) ? IntPtr.Zero : ((Java.Lang.Object)callback).Handle);
				AssetPathFetcher._members.InstanceMethods.InvokeVirtualVoidMethod("loadData.(Lcom/bumptech/glide/Priority;Lcom/bumptech/glide/load/data/DataFetcher$DataCallback;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(priority);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06001410 RID: 5136 RVA: 0x00040410 File Offset: 0x0003E610
		private static Delegate GetLoadResource_Landroid_content_res_AssetManager_Ljava_lang_String_Handler()
		{
			if (AssetPathFetcher.cb_loadResource_Landroid_content_res_AssetManager_Ljava_lang_String_ == null)
			{
				AssetPathFetcher.cb_loadResource_Landroid_content_res_AssetManager_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(AssetPathFetcher.n_LoadResource_Landroid_content_res_AssetManager_Ljava_lang_String_));
			}
			return AssetPathFetcher.cb_loadResource_Landroid_content_res_AssetManager_Ljava_lang_String_;
		}

		// Token: 0x06001411 RID: 5137 RVA: 0x00040434 File Offset: 0x0003E634
		private static IntPtr n_LoadResource_Landroid_content_res_AssetManager_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			AssetPathFetcher @object = Java.Lang.Object.GetObject<AssetPathFetcher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AssetManager object2 = Java.Lang.Object.GetObject<AssetManager>(native_p0, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p1, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.LoadResource(object2, @string));
		}

		// Token: 0x06001412 RID: 5138
		[Register("loadResource", "(Landroid/content/res/AssetManager;Ljava/lang/String;)Ljava/lang/Object;", "GetLoadResource_Landroid_content_res_AssetManager_Ljava_lang_String_Handler")]
		protected abstract Java.Lang.Object LoadResource(AssetManager p0, string p1);

		// Token: 0x06001413 RID: 5139 RVA: 0x00040465 File Offset: 0x0003E665
		private static Delegate GetGetDataClassHandler()
		{
			if (AssetPathFetcher.cb_getDataClass == null)
			{
				AssetPathFetcher.cb_getDataClass = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AssetPathFetcher.n_GetDataClass));
			}
			return AssetPathFetcher.cb_getDataClass;
		}

		// Token: 0x06001414 RID: 5140 RVA: 0x00040489 File Offset: 0x0003E689
		private static IntPtr n_GetDataClass(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AssetPathFetcher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DataClass);
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x06001415 RID: 5141
		public abstract Class DataClass { [Register("getDataClass", "()Ljava/lang/Class;", "GetGetDataClassHandler")] get; }

		// Token: 0x040004B7 RID: 1207
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/data/AssetPathFetcher", typeof(AssetPathFetcher));

		// Token: 0x040004B8 RID: 1208
		private static Delegate cb_getDataSource;

		// Token: 0x040004B9 RID: 1209
		private static Delegate cb_cancel;

		// Token: 0x040004BA RID: 1210
		private static Delegate cb_cleanup;

		// Token: 0x040004BB RID: 1211
		private static Delegate cb_close_Ljava_lang_Object_;

		// Token: 0x040004BC RID: 1212
		private static Delegate cb_loadData_Lcom_bumptech_glide_Priority_Lcom_bumptech_glide_load_data_DataFetcher_DataCallback_;

		// Token: 0x040004BD RID: 1213
		private static Delegate cb_loadResource_Landroid_content_res_AssetManager_Ljava_lang_String_;

		// Token: 0x040004BE RID: 1214
		private static Delegate cb_getDataClass;
	}
}
