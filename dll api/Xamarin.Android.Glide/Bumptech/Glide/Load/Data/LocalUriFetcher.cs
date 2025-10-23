using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Net;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Data
{
	// Token: 0x0200019A RID: 410
	[Register("com/bumptech/glide/load/data/LocalUriFetcher", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public abstract class LocalUriFetcher : Java.Lang.Object, IDataFetcher, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x060014AB RID: 5291 RVA: 0x00041B54 File Offset: 0x0003FD54
		internal static IntPtr class_ref
		{
			get
			{
				return LocalUriFetcher._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x060014AC RID: 5292 RVA: 0x00041B78 File Offset: 0x0003FD78
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return LocalUriFetcher._members;
			}
		}

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x060014AD RID: 5293 RVA: 0x00041B80 File Offset: 0x0003FD80
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return LocalUriFetcher._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x060014AE RID: 5294 RVA: 0x00041BA4 File Offset: 0x0003FDA4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return LocalUriFetcher._members.ManagedPeerType;
			}
		}

		// Token: 0x060014AF RID: 5295 RVA: 0x00041BB0 File Offset: 0x0003FDB0
		protected LocalUriFetcher(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060014B0 RID: 5296 RVA: 0x00041BBC File Offset: 0x0003FDBC
		[Register(".ctor", "(Landroid/content/ContentResolver;Landroid/net/Uri;)V", "")]
		public unsafe LocalUriFetcher(ContentResolver contentResolver, Android.Net.Uri uri) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((contentResolver == null) ? IntPtr.Zero : contentResolver.Handle);
				ptr[1] = new JniArgumentValue((uri == null) ? IntPtr.Zero : uri.Handle);
				base.SetHandle(LocalUriFetcher._members.InstanceMethods.StartCreateInstance("(Landroid/content/ContentResolver;Landroid/net/Uri;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				LocalUriFetcher._members.InstanceMethods.FinishCreateInstance("(Landroid/content/ContentResolver;Landroid/net/Uri;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(contentResolver);
				GC.KeepAlive(uri);
			}
		}

		// Token: 0x060014B1 RID: 5297 RVA: 0x00041C94 File Offset: 0x0003FE94
		private static Delegate GetGetDataSourceHandler()
		{
			if (LocalUriFetcher.cb_getDataSource == null)
			{
				LocalUriFetcher.cb_getDataSource = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(LocalUriFetcher.n_GetDataSource));
			}
			return LocalUriFetcher.cb_getDataSource;
		}

		// Token: 0x060014B2 RID: 5298 RVA: 0x00041CB8 File Offset: 0x0003FEB8
		private static IntPtr n_GetDataSource(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<LocalUriFetcher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DataSource);
		}

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x060014B3 RID: 5299 RVA: 0x00041CCC File Offset: 0x0003FECC
		public virtual DataSource DataSource
		{
			[Register("getDataSource", "()Lcom/bumptech/glide/load/DataSource;", "GetGetDataSourceHandler")]
			get
			{
				return Java.Lang.Object.GetObject<DataSource>(LocalUriFetcher._members.InstanceMethods.InvokeVirtualObjectMethod("getDataSource.()Lcom/bumptech/glide/load/DataSource;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060014B4 RID: 5300 RVA: 0x00041CFE File Offset: 0x0003FEFE
		private static Delegate GetCancelHandler()
		{
			if (LocalUriFetcher.cb_cancel == null)
			{
				LocalUriFetcher.cb_cancel = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(LocalUriFetcher.n_Cancel));
			}
			return LocalUriFetcher.cb_cancel;
		}

		// Token: 0x060014B5 RID: 5301 RVA: 0x00041D22 File Offset: 0x0003FF22
		private static void n_Cancel(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<LocalUriFetcher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Cancel();
		}

		// Token: 0x060014B6 RID: 5302 RVA: 0x00041D31 File Offset: 0x0003FF31
		[Register("cancel", "()V", "GetCancelHandler")]
		public virtual void Cancel()
		{
			LocalUriFetcher._members.InstanceMethods.InvokeVirtualVoidMethod("cancel.()V", this, null);
		}

		// Token: 0x060014B7 RID: 5303 RVA: 0x00041D4A File Offset: 0x0003FF4A
		private static Delegate GetCleanupHandler()
		{
			if (LocalUriFetcher.cb_cleanup == null)
			{
				LocalUriFetcher.cb_cleanup = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(LocalUriFetcher.n_Cleanup));
			}
			return LocalUriFetcher.cb_cleanup;
		}

		// Token: 0x060014B8 RID: 5304 RVA: 0x00041D6E File Offset: 0x0003FF6E
		private static void n_Cleanup(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<LocalUriFetcher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Cleanup();
		}

		// Token: 0x060014B9 RID: 5305 RVA: 0x00041D7D File Offset: 0x0003FF7D
		[Register("cleanup", "()V", "GetCleanupHandler")]
		public virtual void Cleanup()
		{
			LocalUriFetcher._members.InstanceMethods.InvokeVirtualVoidMethod("cleanup.()V", this, null);
		}

		// Token: 0x060014BA RID: 5306 RVA: 0x00041D96 File Offset: 0x0003FF96
		private static Delegate GetClose_Ljava_lang_Object_Handler()
		{
			if (LocalUriFetcher.cb_close_Ljava_lang_Object_ == null)
			{
				LocalUriFetcher.cb_close_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(LocalUriFetcher.n_Close_Ljava_lang_Object_));
			}
			return LocalUriFetcher.cb_close_Ljava_lang_Object_;
		}

		// Token: 0x060014BB RID: 5307 RVA: 0x00041DBC File Offset: 0x0003FFBC
		private static void n_Close_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			LocalUriFetcher @object = Java.Lang.Object.GetObject<LocalUriFetcher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.Close(object2);
		}

		// Token: 0x060014BC RID: 5308
		[Register("close", "(Ljava/lang/Object;)V", "GetClose_Ljava_lang_Object_Handler")]
		protected abstract void Close(Java.Lang.Object p0);

		// Token: 0x060014BD RID: 5309 RVA: 0x00041DE0 File Offset: 0x0003FFE0
		[Register("loadData", "(Lcom/bumptech/glide/Priority;Lcom/bumptech/glide/load/data/DataFetcher$DataCallback;)V", "")]
		public unsafe void LoadData(Priority priority, IDataFetcherDataCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((priority == null) ? IntPtr.Zero : priority.Handle);
				ptr[1] = new JniArgumentValue((callback == null) ? IntPtr.Zero : ((Java.Lang.Object)callback).Handle);
				LocalUriFetcher._members.InstanceMethods.InvokeNonvirtualVoidMethod("loadData.(Lcom/bumptech/glide/Priority;Lcom/bumptech/glide/load/data/DataFetcher$DataCallback;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(priority);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060014BE RID: 5310 RVA: 0x00041E70 File Offset: 0x00040070
		private static Delegate GetLoadResource_Landroid_net_Uri_Landroid_content_ContentResolver_Handler()
		{
			if (LocalUriFetcher.cb_loadResource_Landroid_net_Uri_Landroid_content_ContentResolver_ == null)
			{
				LocalUriFetcher.cb_loadResource_Landroid_net_Uri_Landroid_content_ContentResolver_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(LocalUriFetcher.n_LoadResource_Landroid_net_Uri_Landroid_content_ContentResolver_));
			}
			return LocalUriFetcher.cb_loadResource_Landroid_net_Uri_Landroid_content_ContentResolver_;
		}

		// Token: 0x060014BF RID: 5311 RVA: 0x00041E94 File Offset: 0x00040094
		private static IntPtr n_LoadResource_Landroid_net_Uri_Landroid_content_ContentResolver_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			LocalUriFetcher @object = Java.Lang.Object.GetObject<LocalUriFetcher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Android.Net.Uri object2 = Java.Lang.Object.GetObject<Android.Net.Uri>(native_p0, JniHandleOwnership.DoNotTransfer);
			ContentResolver object3 = Java.Lang.Object.GetObject<ContentResolver>(native_p1, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.LoadResource(object2, object3));
		}

		// Token: 0x060014C0 RID: 5312
		[Register("loadResource", "(Landroid/net/Uri;Landroid/content/ContentResolver;)Ljava/lang/Object;", "GetLoadResource_Landroid_net_Uri_Landroid_content_ContentResolver_Handler")]
		protected abstract Java.Lang.Object LoadResource(Android.Net.Uri p0, ContentResolver p1);

		// Token: 0x060014C1 RID: 5313 RVA: 0x00041EC5 File Offset: 0x000400C5
		private static Delegate GetGetDataClassHandler()
		{
			if (LocalUriFetcher.cb_getDataClass == null)
			{
				LocalUriFetcher.cb_getDataClass = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(LocalUriFetcher.n_GetDataClass));
			}
			return LocalUriFetcher.cb_getDataClass;
		}

		// Token: 0x060014C2 RID: 5314 RVA: 0x00041EE9 File Offset: 0x000400E9
		private static IntPtr n_GetDataClass(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<LocalUriFetcher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DataClass);
		}

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x060014C3 RID: 5315
		public abstract Class DataClass { [Register("getDataClass", "()Ljava/lang/Class;", "GetGetDataClassHandler")] get; }

		// Token: 0x040004EA RID: 1258
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/data/LocalUriFetcher", typeof(LocalUriFetcher));

		// Token: 0x040004EB RID: 1259
		private static Delegate cb_getDataSource;

		// Token: 0x040004EC RID: 1260
		private static Delegate cb_cancel;

		// Token: 0x040004ED RID: 1261
		private static Delegate cb_cleanup;

		// Token: 0x040004EE RID: 1262
		private static Delegate cb_close_Ljava_lang_Object_;

		// Token: 0x040004EF RID: 1263
		private static Delegate cb_loadResource_Landroid_net_Uri_Landroid_content_ContentResolver_;

		// Token: 0x040004F0 RID: 1264
		private static Delegate cb_getDataClass;
	}
}
