using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Net;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Data.Mediastore
{
	// Token: 0x020001A0 RID: 416
	[Register("com/bumptech/glide/load/data/mediastore/ThumbFetcher", DoNotGenerateAcw = true)]
	public class ThumbFetcher : Java.Lang.Object, IDataFetcher, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x060014EE RID: 5358 RVA: 0x000425E8 File Offset: 0x000407E8
		internal static IntPtr class_ref
		{
			get
			{
				return ThumbFetcher._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x060014EF RID: 5359 RVA: 0x0004260C File Offset: 0x0004080C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ThumbFetcher._members;
			}
		}

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x060014F0 RID: 5360 RVA: 0x00042614 File Offset: 0x00040814
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ThumbFetcher._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x060014F1 RID: 5361 RVA: 0x00042638 File Offset: 0x00040838
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ThumbFetcher._members.ManagedPeerType;
			}
		}

		// Token: 0x060014F2 RID: 5362 RVA: 0x00042644 File Offset: 0x00040844
		protected ThumbFetcher(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060014F3 RID: 5363 RVA: 0x0004264E File Offset: 0x0004084E
		private static Delegate GetGetDataClassHandler()
		{
			if (ThumbFetcher.cb_getDataClass == null)
			{
				ThumbFetcher.cb_getDataClass = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ThumbFetcher.n_GetDataClass));
			}
			return ThumbFetcher.cb_getDataClass;
		}

		// Token: 0x060014F4 RID: 5364 RVA: 0x00042672 File Offset: 0x00040872
		private static IntPtr n_GetDataClass(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ThumbFetcher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DataClass);
		}

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x060014F5 RID: 5365 RVA: 0x00042688 File Offset: 0x00040888
		public virtual Class DataClass
		{
			[Register("getDataClass", "()Ljava/lang/Class;", "GetGetDataClassHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Class>(ThumbFetcher._members.InstanceMethods.InvokeVirtualObjectMethod("getDataClass.()Ljava/lang/Class;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060014F6 RID: 5366 RVA: 0x000426BA File Offset: 0x000408BA
		private static Delegate GetGetDataSourceHandler()
		{
			if (ThumbFetcher.cb_getDataSource == null)
			{
				ThumbFetcher.cb_getDataSource = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ThumbFetcher.n_GetDataSource));
			}
			return ThumbFetcher.cb_getDataSource;
		}

		// Token: 0x060014F7 RID: 5367 RVA: 0x000426DE File Offset: 0x000408DE
		private static IntPtr n_GetDataSource(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ThumbFetcher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DataSource);
		}

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x060014F8 RID: 5368 RVA: 0x000426F4 File Offset: 0x000408F4
		public virtual DataSource DataSource
		{
			[Register("getDataSource", "()Lcom/bumptech/glide/load/DataSource;", "GetGetDataSourceHandler")]
			get
			{
				return Java.Lang.Object.GetObject<DataSource>(ThumbFetcher._members.InstanceMethods.InvokeVirtualObjectMethod("getDataSource.()Lcom/bumptech/glide/load/DataSource;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060014F9 RID: 5369 RVA: 0x00042728 File Offset: 0x00040928
		[Register("buildImageFetcher", "(Landroid/content/Context;Landroid/net/Uri;)Lcom/bumptech/glide/load/data/mediastore/ThumbFetcher;", "")]
		public unsafe static ThumbFetcher BuildImageFetcher(Context context, Android.Net.Uri uri)
		{
			ThumbFetcher @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((uri == null) ? IntPtr.Zero : uri.Handle);
				@object = Java.Lang.Object.GetObject<ThumbFetcher>(ThumbFetcher._members.StaticMethods.InvokeObjectMethod("buildImageFetcher.(Landroid/content/Context;Landroid/net/Uri;)Lcom/bumptech/glide/load/data/mediastore/ThumbFetcher;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(uri);
			}
			return @object;
		}

		// Token: 0x060014FA RID: 5370 RVA: 0x000427C4 File Offset: 0x000409C4
		[Register("buildVideoFetcher", "(Landroid/content/Context;Landroid/net/Uri;)Lcom/bumptech/glide/load/data/mediastore/ThumbFetcher;", "")]
		public unsafe static ThumbFetcher BuildVideoFetcher(Context context, Android.Net.Uri uri)
		{
			ThumbFetcher @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((uri == null) ? IntPtr.Zero : uri.Handle);
				@object = Java.Lang.Object.GetObject<ThumbFetcher>(ThumbFetcher._members.StaticMethods.InvokeObjectMethod("buildVideoFetcher.(Landroid/content/Context;Landroid/net/Uri;)Lcom/bumptech/glide/load/data/mediastore/ThumbFetcher;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(uri);
			}
			return @object;
		}

		// Token: 0x060014FB RID: 5371 RVA: 0x00042860 File Offset: 0x00040A60
		private static Delegate GetCancelHandler()
		{
			if (ThumbFetcher.cb_cancel == null)
			{
				ThumbFetcher.cb_cancel = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ThumbFetcher.n_Cancel));
			}
			return ThumbFetcher.cb_cancel;
		}

		// Token: 0x060014FC RID: 5372 RVA: 0x00042884 File Offset: 0x00040A84
		private static void n_Cancel(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<ThumbFetcher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Cancel();
		}

		// Token: 0x060014FD RID: 5373 RVA: 0x00042893 File Offset: 0x00040A93
		[Register("cancel", "()V", "GetCancelHandler")]
		public virtual void Cancel()
		{
			ThumbFetcher._members.InstanceMethods.InvokeVirtualVoidMethod("cancel.()V", this, null);
		}

		// Token: 0x060014FE RID: 5374 RVA: 0x000428AC File Offset: 0x00040AAC
		private static Delegate GetCleanupHandler()
		{
			if (ThumbFetcher.cb_cleanup == null)
			{
				ThumbFetcher.cb_cleanup = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ThumbFetcher.n_Cleanup));
			}
			return ThumbFetcher.cb_cleanup;
		}

		// Token: 0x060014FF RID: 5375 RVA: 0x000428D0 File Offset: 0x00040AD0
		private static void n_Cleanup(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<ThumbFetcher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Cleanup();
		}

		// Token: 0x06001500 RID: 5376 RVA: 0x000428DF File Offset: 0x00040ADF
		[Register("cleanup", "()V", "GetCleanupHandler")]
		public virtual void Cleanup()
		{
			ThumbFetcher._members.InstanceMethods.InvokeVirtualVoidMethod("cleanup.()V", this, null);
		}

		// Token: 0x06001501 RID: 5377 RVA: 0x000428F8 File Offset: 0x00040AF8
		private static Delegate GetLoadData_Lcom_bumptech_glide_Priority_Lcom_bumptech_glide_load_data_DataFetcher_DataCallback_Handler()
		{
			if (ThumbFetcher.cb_loadData_Lcom_bumptech_glide_Priority_Lcom_bumptech_glide_load_data_DataFetcher_DataCallback_ == null)
			{
				ThumbFetcher.cb_loadData_Lcom_bumptech_glide_Priority_Lcom_bumptech_glide_load_data_DataFetcher_DataCallback_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(ThumbFetcher.n_LoadData_Lcom_bumptech_glide_Priority_Lcom_bumptech_glide_load_data_DataFetcher_DataCallback_));
			}
			return ThumbFetcher.cb_loadData_Lcom_bumptech_glide_Priority_Lcom_bumptech_glide_load_data_DataFetcher_DataCallback_;
		}

		// Token: 0x06001502 RID: 5378 RVA: 0x0004291C File Offset: 0x00040B1C
		private static void n_LoadData_Lcom_bumptech_glide_Priority_Lcom_bumptech_glide_load_data_DataFetcher_DataCallback_(IntPtr jnienv, IntPtr native__this, IntPtr native_priority, IntPtr native__callback)
		{
			ThumbFetcher @object = Java.Lang.Object.GetObject<ThumbFetcher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Priority object2 = Java.Lang.Object.GetObject<Priority>(native_priority, JniHandleOwnership.DoNotTransfer);
			IDataFetcherDataCallback object3 = Java.Lang.Object.GetObject<IDataFetcherDataCallback>(native__callback, JniHandleOwnership.DoNotTransfer);
			@object.LoadData(object2, object3);
		}

		// Token: 0x06001503 RID: 5379 RVA: 0x00042948 File Offset: 0x00040B48
		[Register("loadData", "(Lcom/bumptech/glide/Priority;Lcom/bumptech/glide/load/data/DataFetcher$DataCallback;)V", "GetLoadData_Lcom_bumptech_glide_Priority_Lcom_bumptech_glide_load_data_DataFetcher_DataCallback_Handler")]
		public unsafe virtual void LoadData(Priority priority, IDataFetcherDataCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((priority == null) ? IntPtr.Zero : priority.Handle);
				ptr[1] = new JniArgumentValue((callback == null) ? IntPtr.Zero : ((Java.Lang.Object)callback).Handle);
				ThumbFetcher._members.InstanceMethods.InvokeVirtualVoidMethod("loadData.(Lcom/bumptech/glide/Priority;Lcom/bumptech/glide/load/data/DataFetcher$DataCallback;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(priority);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06001504 RID: 5380 RVA: 0x000429D8 File Offset: 0x00040BD8
		void IDataFetcher.LoadData(Priority p0, IDataFetcherDataCallback p1)
		{
			this.LoadData(p0, p1.JavaCast<IDataFetcherDataCallback>());
		}

		// Token: 0x040004F8 RID: 1272
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/data/mediastore/ThumbFetcher", typeof(ThumbFetcher));

		// Token: 0x040004F9 RID: 1273
		private static Delegate cb_getDataClass;

		// Token: 0x040004FA RID: 1274
		private static Delegate cb_getDataSource;

		// Token: 0x040004FB RID: 1275
		private static Delegate cb_cancel;

		// Token: 0x040004FC RID: 1276
		private static Delegate cb_cleanup;

		// Token: 0x040004FD RID: 1277
		private static Delegate cb_loadData_Lcom_bumptech_glide_Priority_Lcom_bumptech_glide_load_data_DataFetcher_DataCallback_;
	}
}
