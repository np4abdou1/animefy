using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Data
{
	// Token: 0x02000194 RID: 404
	[Register("com/bumptech/glide/load/data/DataFetcher", DoNotGenerateAcw = true)]
	internal class IDataFetcherInvoker : Java.Lang.Object, IDataFetcher, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x06001467 RID: 5223 RVA: 0x00041174 File Offset: 0x0003F374
		private static IntPtr java_class_ref
		{
			get
			{
				return IDataFetcherInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x06001468 RID: 5224 RVA: 0x00041198 File Offset: 0x0003F398
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IDataFetcherInvoker._members;
			}
		}

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x06001469 RID: 5225 RVA: 0x0004119F File Offset: 0x0003F39F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x0600146A RID: 5226 RVA: 0x000411A7 File Offset: 0x0003F3A7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IDataFetcherInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600146B RID: 5227 RVA: 0x000411B3 File Offset: 0x0003F3B3
		public static IDataFetcher GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IDataFetcher>(handle, transfer);
		}

		// Token: 0x0600146C RID: 5228 RVA: 0x000411BC File Offset: 0x0003F3BC
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IDataFetcherInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.bumptech.glide.load.data.DataFetcher'.");
			}
			return handle;
		}

		// Token: 0x0600146D RID: 5229 RVA: 0x000411E7 File Offset: 0x0003F3E7
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600146E RID: 5230 RVA: 0x00041218 File Offset: 0x0003F418
		public IDataFetcherInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IDataFetcherInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600146F RID: 5231 RVA: 0x00041250 File Offset: 0x0003F450
		private static Delegate GetGetDataClassHandler()
		{
			if (IDataFetcherInvoker.cb_getDataClass == null)
			{
				IDataFetcherInvoker.cb_getDataClass = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IDataFetcherInvoker.n_GetDataClass));
			}
			return IDataFetcherInvoker.cb_getDataClass;
		}

		// Token: 0x06001470 RID: 5232 RVA: 0x00041274 File Offset: 0x0003F474
		private static IntPtr n_GetDataClass(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IDataFetcher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DataClass);
		}

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x06001471 RID: 5233 RVA: 0x00041288 File Offset: 0x0003F488
		public Class DataClass
		{
			get
			{
				if (this.id_getDataClass == IntPtr.Zero)
				{
					this.id_getDataClass = JNIEnv.GetMethodID(this.class_ref, "getDataClass", "()Ljava/lang/Class;");
				}
				return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_getDataClass), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06001472 RID: 5234 RVA: 0x000412D9 File Offset: 0x0003F4D9
		private static Delegate GetGetDataSourceHandler()
		{
			if (IDataFetcherInvoker.cb_getDataSource == null)
			{
				IDataFetcherInvoker.cb_getDataSource = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IDataFetcherInvoker.n_GetDataSource));
			}
			return IDataFetcherInvoker.cb_getDataSource;
		}

		// Token: 0x06001473 RID: 5235 RVA: 0x000412FD File Offset: 0x0003F4FD
		private static IntPtr n_GetDataSource(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IDataFetcher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DataSource);
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x06001474 RID: 5236 RVA: 0x00041314 File Offset: 0x0003F514
		public DataSource DataSource
		{
			get
			{
				if (this.id_getDataSource == IntPtr.Zero)
				{
					this.id_getDataSource = JNIEnv.GetMethodID(this.class_ref, "getDataSource", "()Lcom/bumptech/glide/load/DataSource;");
				}
				return Java.Lang.Object.GetObject<DataSource>(JNIEnv.CallObjectMethod(base.Handle, this.id_getDataSource), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06001475 RID: 5237 RVA: 0x00041365 File Offset: 0x0003F565
		private static Delegate GetCancelHandler()
		{
			if (IDataFetcherInvoker.cb_cancel == null)
			{
				IDataFetcherInvoker.cb_cancel = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IDataFetcherInvoker.n_Cancel));
			}
			return IDataFetcherInvoker.cb_cancel;
		}

		// Token: 0x06001476 RID: 5238 RVA: 0x00041389 File Offset: 0x0003F589
		private static void n_Cancel(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IDataFetcher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Cancel();
		}

		// Token: 0x06001477 RID: 5239 RVA: 0x00041398 File Offset: 0x0003F598
		public void Cancel()
		{
			if (this.id_cancel == IntPtr.Zero)
			{
				this.id_cancel = JNIEnv.GetMethodID(this.class_ref, "cancel", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_cancel);
		}

		// Token: 0x06001478 RID: 5240 RVA: 0x000413D8 File Offset: 0x0003F5D8
		private static Delegate GetCleanupHandler()
		{
			if (IDataFetcherInvoker.cb_cleanup == null)
			{
				IDataFetcherInvoker.cb_cleanup = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IDataFetcherInvoker.n_Cleanup));
			}
			return IDataFetcherInvoker.cb_cleanup;
		}

		// Token: 0x06001479 RID: 5241 RVA: 0x000413FC File Offset: 0x0003F5FC
		private static void n_Cleanup(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IDataFetcher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Cleanup();
		}

		// Token: 0x0600147A RID: 5242 RVA: 0x0004140B File Offset: 0x0003F60B
		public void Cleanup()
		{
			if (this.id_cleanup == IntPtr.Zero)
			{
				this.id_cleanup = JNIEnv.GetMethodID(this.class_ref, "cleanup", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_cleanup);
		}

		// Token: 0x0600147B RID: 5243 RVA: 0x0004144B File Offset: 0x0003F64B
		private static Delegate GetLoadData_Lcom_bumptech_glide_Priority_Lcom_bumptech_glide_load_data_DataFetcher_DataCallback_Handler()
		{
			if (IDataFetcherInvoker.cb_loadData_Lcom_bumptech_glide_Priority_Lcom_bumptech_glide_load_data_DataFetcher_DataCallback_ == null)
			{
				IDataFetcherInvoker.cb_loadData_Lcom_bumptech_glide_Priority_Lcom_bumptech_glide_load_data_DataFetcher_DataCallback_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IDataFetcherInvoker.n_LoadData_Lcom_bumptech_glide_Priority_Lcom_bumptech_glide_load_data_DataFetcher_DataCallback_));
			}
			return IDataFetcherInvoker.cb_loadData_Lcom_bumptech_glide_Priority_Lcom_bumptech_glide_load_data_DataFetcher_DataCallback_;
		}

		// Token: 0x0600147C RID: 5244 RVA: 0x00041470 File Offset: 0x0003F670
		private static void n_LoadData_Lcom_bumptech_glide_Priority_Lcom_bumptech_glide_load_data_DataFetcher_DataCallback_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IDataFetcher @object = Java.Lang.Object.GetObject<IDataFetcher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Priority object2 = Java.Lang.Object.GetObject<Priority>(native_p0, JniHandleOwnership.DoNotTransfer);
			IDataFetcherDataCallback object3 = Java.Lang.Object.GetObject<IDataFetcherDataCallback>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.LoadData(object2, object3);
		}

		// Token: 0x0600147D RID: 5245 RVA: 0x0004149C File Offset: 0x0003F69C
		public unsafe void LoadData(Priority p0, IDataFetcherDataCallback p1)
		{
			if (this.id_loadData_Lcom_bumptech_glide_Priority_Lcom_bumptech_glide_load_data_DataFetcher_DataCallback_ == IntPtr.Zero)
			{
				this.id_loadData_Lcom_bumptech_glide_Priority_Lcom_bumptech_glide_load_data_DataFetcher_DataCallback_ = JNIEnv.GetMethodID(this.class_ref, "loadData", "(Lcom/bumptech/glide/Priority;Lcom/bumptech/glide/load/data/DataFetcher$DataCallback;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_loadData_Lcom_bumptech_glide_Priority_Lcom_bumptech_glide_load_data_DataFetcher_DataCallback_, ptr);
		}

		// Token: 0x040004D1 RID: 1233
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/data/DataFetcher", typeof(IDataFetcherInvoker));

		// Token: 0x040004D2 RID: 1234
		private IntPtr class_ref;

		// Token: 0x040004D3 RID: 1235
		private static Delegate cb_getDataClass;

		// Token: 0x040004D4 RID: 1236
		private IntPtr id_getDataClass;

		// Token: 0x040004D5 RID: 1237
		private static Delegate cb_getDataSource;

		// Token: 0x040004D6 RID: 1238
		private IntPtr id_getDataSource;

		// Token: 0x040004D7 RID: 1239
		private static Delegate cb_cancel;

		// Token: 0x040004D8 RID: 1240
		private IntPtr id_cancel;

		// Token: 0x040004D9 RID: 1241
		private static Delegate cb_cleanup;

		// Token: 0x040004DA RID: 1242
		private IntPtr id_cleanup;

		// Token: 0x040004DB RID: 1243
		private static Delegate cb_loadData_Lcom_bumptech_glide_Priority_Lcom_bumptech_glide_load_data_DataFetcher_DataCallback_;

		// Token: 0x040004DC RID: 1244
		private IntPtr id_loadData_Lcom_bumptech_glide_Priority_Lcom_bumptech_glide_load_data_DataFetcher_DataCallback_;
	}
}
