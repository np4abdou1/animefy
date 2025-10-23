using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Bumptech.Glide.Load.Model;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Data
{
	// Token: 0x02000190 RID: 400
	[Register("com/bumptech/glide/load/data/HttpUrlFetcher", DoNotGenerateAcw = true)]
	public class HttpUrlFetcher : Java.Lang.Object, IDataFetcher, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x0600143A RID: 5178 RVA: 0x00040B60 File Offset: 0x0003ED60
		internal static IntPtr class_ref
		{
			get
			{
				return HttpUrlFetcher._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x0600143B RID: 5179 RVA: 0x00040B84 File Offset: 0x0003ED84
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return HttpUrlFetcher._members;
			}
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x0600143C RID: 5180 RVA: 0x00040B8C File Offset: 0x0003ED8C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return HttpUrlFetcher._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x0600143D RID: 5181 RVA: 0x00040BB0 File Offset: 0x0003EDB0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return HttpUrlFetcher._members.ManagedPeerType;
			}
		}

		// Token: 0x0600143E RID: 5182 RVA: 0x00040BBC File Offset: 0x0003EDBC
		protected HttpUrlFetcher(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600143F RID: 5183 RVA: 0x00040BC8 File Offset: 0x0003EDC8
		[Register(".ctor", "(Lcom/bumptech/glide/load/model/GlideUrl;I)V", "")]
		public unsafe HttpUrlFetcher(GlideUrl glideUrl, int timeout) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((glideUrl == null) ? IntPtr.Zero : glideUrl.Handle);
				ptr[1] = new JniArgumentValue(timeout);
				base.SetHandle(HttpUrlFetcher._members.InstanceMethods.StartCreateInstance("(Lcom/bumptech/glide/load/model/GlideUrl;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				HttpUrlFetcher._members.InstanceMethods.FinishCreateInstance("(Lcom/bumptech/glide/load/model/GlideUrl;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(glideUrl);
			}
		}

		// Token: 0x06001440 RID: 5184 RVA: 0x00040C88 File Offset: 0x0003EE88
		private static Delegate GetGetDataClassHandler()
		{
			if (HttpUrlFetcher.cb_getDataClass == null)
			{
				HttpUrlFetcher.cb_getDataClass = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(HttpUrlFetcher.n_GetDataClass));
			}
			return HttpUrlFetcher.cb_getDataClass;
		}

		// Token: 0x06001441 RID: 5185 RVA: 0x00040CAC File Offset: 0x0003EEAC
		private static IntPtr n_GetDataClass(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<HttpUrlFetcher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DataClass);
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x06001442 RID: 5186 RVA: 0x00040CC0 File Offset: 0x0003EEC0
		public virtual Class DataClass
		{
			[Register("getDataClass", "()Ljava/lang/Class;", "GetGetDataClassHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Class>(HttpUrlFetcher._members.InstanceMethods.InvokeVirtualObjectMethod("getDataClass.()Ljava/lang/Class;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06001443 RID: 5187 RVA: 0x00040CF2 File Offset: 0x0003EEF2
		private static Delegate GetGetDataSourceHandler()
		{
			if (HttpUrlFetcher.cb_getDataSource == null)
			{
				HttpUrlFetcher.cb_getDataSource = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(HttpUrlFetcher.n_GetDataSource));
			}
			return HttpUrlFetcher.cb_getDataSource;
		}

		// Token: 0x06001444 RID: 5188 RVA: 0x00040D16 File Offset: 0x0003EF16
		private static IntPtr n_GetDataSource(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<HttpUrlFetcher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DataSource);
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x06001445 RID: 5189 RVA: 0x00040D2C File Offset: 0x0003EF2C
		public virtual DataSource DataSource
		{
			[Register("getDataSource", "()Lcom/bumptech/glide/load/DataSource;", "GetGetDataSourceHandler")]
			get
			{
				return Java.Lang.Object.GetObject<DataSource>(HttpUrlFetcher._members.InstanceMethods.InvokeVirtualObjectMethod("getDataSource.()Lcom/bumptech/glide/load/DataSource;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06001446 RID: 5190 RVA: 0x00040D5E File Offset: 0x0003EF5E
		private static Delegate GetCancelHandler()
		{
			if (HttpUrlFetcher.cb_cancel == null)
			{
				HttpUrlFetcher.cb_cancel = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(HttpUrlFetcher.n_Cancel));
			}
			return HttpUrlFetcher.cb_cancel;
		}

		// Token: 0x06001447 RID: 5191 RVA: 0x00040D82 File Offset: 0x0003EF82
		private static void n_Cancel(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<HttpUrlFetcher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Cancel();
		}

		// Token: 0x06001448 RID: 5192 RVA: 0x00040D91 File Offset: 0x0003EF91
		[Register("cancel", "()V", "GetCancelHandler")]
		public virtual void Cancel()
		{
			HttpUrlFetcher._members.InstanceMethods.InvokeVirtualVoidMethod("cancel.()V", this, null);
		}

		// Token: 0x06001449 RID: 5193 RVA: 0x00040DAA File Offset: 0x0003EFAA
		private static Delegate GetCleanupHandler()
		{
			if (HttpUrlFetcher.cb_cleanup == null)
			{
				HttpUrlFetcher.cb_cleanup = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(HttpUrlFetcher.n_Cleanup));
			}
			return HttpUrlFetcher.cb_cleanup;
		}

		// Token: 0x0600144A RID: 5194 RVA: 0x00040DCE File Offset: 0x0003EFCE
		private static void n_Cleanup(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<HttpUrlFetcher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Cleanup();
		}

		// Token: 0x0600144B RID: 5195 RVA: 0x00040DDD File Offset: 0x0003EFDD
		[Register("cleanup", "()V", "GetCleanupHandler")]
		public virtual void Cleanup()
		{
			HttpUrlFetcher._members.InstanceMethods.InvokeVirtualVoidMethod("cleanup.()V", this, null);
		}

		// Token: 0x0600144C RID: 5196 RVA: 0x00040DF6 File Offset: 0x0003EFF6
		private static Delegate GetLoadData_Lcom_bumptech_glide_Priority_Lcom_bumptech_glide_load_data_DataFetcher_DataCallback_Handler()
		{
			if (HttpUrlFetcher.cb_loadData_Lcom_bumptech_glide_Priority_Lcom_bumptech_glide_load_data_DataFetcher_DataCallback_ == null)
			{
				HttpUrlFetcher.cb_loadData_Lcom_bumptech_glide_Priority_Lcom_bumptech_glide_load_data_DataFetcher_DataCallback_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(HttpUrlFetcher.n_LoadData_Lcom_bumptech_glide_Priority_Lcom_bumptech_glide_load_data_DataFetcher_DataCallback_));
			}
			return HttpUrlFetcher.cb_loadData_Lcom_bumptech_glide_Priority_Lcom_bumptech_glide_load_data_DataFetcher_DataCallback_;
		}

		// Token: 0x0600144D RID: 5197 RVA: 0x00040E1C File Offset: 0x0003F01C
		private static void n_LoadData_Lcom_bumptech_glide_Priority_Lcom_bumptech_glide_load_data_DataFetcher_DataCallback_(IntPtr jnienv, IntPtr native__this, IntPtr native_priority, IntPtr native__callback)
		{
			HttpUrlFetcher @object = Java.Lang.Object.GetObject<HttpUrlFetcher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Priority object2 = Java.Lang.Object.GetObject<Priority>(native_priority, JniHandleOwnership.DoNotTransfer);
			IDataFetcherDataCallback object3 = Java.Lang.Object.GetObject<IDataFetcherDataCallback>(native__callback, JniHandleOwnership.DoNotTransfer);
			@object.LoadData(object2, object3);
		}

		// Token: 0x0600144E RID: 5198 RVA: 0x00040E48 File Offset: 0x0003F048
		[Register("loadData", "(Lcom/bumptech/glide/Priority;Lcom/bumptech/glide/load/data/DataFetcher$DataCallback;)V", "GetLoadData_Lcom_bumptech_glide_Priority_Lcom_bumptech_glide_load_data_DataFetcher_DataCallback_Handler")]
		public unsafe virtual void LoadData(Priority priority, IDataFetcherDataCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((priority == null) ? IntPtr.Zero : priority.Handle);
				ptr[1] = new JniArgumentValue((callback == null) ? IntPtr.Zero : ((Java.Lang.Object)callback).Handle);
				HttpUrlFetcher._members.InstanceMethods.InvokeVirtualVoidMethod("loadData.(Lcom/bumptech/glide/Priority;Lcom/bumptech/glide/load/data/DataFetcher$DataCallback;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(priority);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x0600144F RID: 5199 RVA: 0x00040ED8 File Offset: 0x0003F0D8
		void IDataFetcher.LoadData(Priority p0, IDataFetcherDataCallback p1)
		{
			this.LoadData(p0, p1.JavaCast<IDataFetcherDataCallback>());
		}

		// Token: 0x040004C5 RID: 1221
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/data/HttpUrlFetcher", typeof(HttpUrlFetcher));

		// Token: 0x040004C6 RID: 1222
		private static Delegate cb_getDataClass;

		// Token: 0x040004C7 RID: 1223
		private static Delegate cb_getDataSource;

		// Token: 0x040004C8 RID: 1224
		private static Delegate cb_cancel;

		// Token: 0x040004C9 RID: 1225
		private static Delegate cb_cleanup;

		// Token: 0x040004CA RID: 1226
		private static Delegate cb_loadData_Lcom_bumptech_glide_Priority_Lcom_bumptech_glide_load_data_DataFetcher_DataCallback_;
	}
}
