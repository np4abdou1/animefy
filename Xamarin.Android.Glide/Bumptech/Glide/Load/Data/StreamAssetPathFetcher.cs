using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using Android.Content.Res;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;

namespace Bumptech.Glide.Load.Data
{
	// Token: 0x02000189 RID: 393
	[Register("com/bumptech/glide/load/data/StreamAssetPathFetcher", DoNotGenerateAcw = true)]
	public class StreamAssetPathFetcher : AssetPathFetcher
	{
		// Token: 0x060013D7 RID: 5079 RVA: 0x0003F924 File Offset: 0x0003DB24
		protected override void Close(Java.Lang.Object data)
		{
			Stream data2 = InputStreamInvoker.FromJniHandle(((InputStream)data).Handle, JniHandleOwnership.DoNotTransfer);
			this.Close(data2);
		}

		// Token: 0x060013D8 RID: 5080 RVA: 0x0003F94C File Offset: 0x0003DB4C
		protected override Java.Lang.Object LoadResource(AssetManager assetManager, string path)
		{
			IntPtr intPtr = InputStreamAdapter.ToLocalJniHandle(this.LoadResource_T(assetManager, path));
			Java.Lang.Object result;
			try
			{
				result = new Java.Lang.Object(intPtr, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x060013D9 RID: 5081 RVA: 0x0003F98C File Offset: 0x0003DB8C
		internal new static IntPtr class_ref
		{
			get
			{
				return StreamAssetPathFetcher._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x060013DA RID: 5082 RVA: 0x0003F9B0 File Offset: 0x0003DBB0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return StreamAssetPathFetcher._members;
			}
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x060013DB RID: 5083 RVA: 0x0003F9B8 File Offset: 0x0003DBB8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return StreamAssetPathFetcher._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x060013DC RID: 5084 RVA: 0x0003F9DC File Offset: 0x0003DBDC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return StreamAssetPathFetcher._members.ManagedPeerType;
			}
		}

		// Token: 0x060013DD RID: 5085 RVA: 0x0003F9E8 File Offset: 0x0003DBE8
		protected StreamAssetPathFetcher(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060013DE RID: 5086 RVA: 0x0003F9F4 File Offset: 0x0003DBF4
		[Register(".ctor", "(Landroid/content/res/AssetManager;Ljava/lang/String;)V", "")]
		public unsafe StreamAssetPathFetcher(AssetManager assetManager, string assetPath) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(StreamAssetPathFetcher._members.InstanceMethods.StartCreateInstance("(Landroid/content/res/AssetManager;Ljava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				StreamAssetPathFetcher._members.InstanceMethods.FinishCreateInstance("(Landroid/content/res/AssetManager;Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(assetManager);
			}
		}

		// Token: 0x060013DF RID: 5087 RVA: 0x0003FAC0 File Offset: 0x0003DCC0
		private static Delegate GetGetDataClassHandler()
		{
			if (StreamAssetPathFetcher.cb_getDataClass == null)
			{
				StreamAssetPathFetcher.cb_getDataClass = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(StreamAssetPathFetcher.n_GetDataClass));
			}
			return StreamAssetPathFetcher.cb_getDataClass;
		}

		// Token: 0x060013E0 RID: 5088 RVA: 0x0003FAE4 File Offset: 0x0003DCE4
		private static IntPtr n_GetDataClass(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<StreamAssetPathFetcher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DataClass);
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x060013E1 RID: 5089 RVA: 0x0003FAF8 File Offset: 0x0003DCF8
		public override Class DataClass
		{
			[Register("getDataClass", "()Ljava/lang/Class;", "GetGetDataClassHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Class>(StreamAssetPathFetcher._members.InstanceMethods.InvokeVirtualObjectMethod("getDataClass.()Ljava/lang/Class;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060013E2 RID: 5090 RVA: 0x0003FB2A File Offset: 0x0003DD2A
		private static Delegate GetClose_Ljava_io_InputStream_Handler()
		{
			if (StreamAssetPathFetcher.cb_close_Ljava_io_InputStream_ == null)
			{
				StreamAssetPathFetcher.cb_close_Ljava_io_InputStream_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(StreamAssetPathFetcher.n_Close_Ljava_io_InputStream_));
			}
			return StreamAssetPathFetcher.cb_close_Ljava_io_InputStream_;
		}

		// Token: 0x060013E3 RID: 5091 RVA: 0x0003FB50 File Offset: 0x0003DD50
		private static void n_Close_Ljava_io_InputStream_(IntPtr jnienv, IntPtr native__this, IntPtr native_data)
		{
			StreamAssetPathFetcher @object = Java.Lang.Object.GetObject<StreamAssetPathFetcher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Stream data = InputStreamInvoker.FromJniHandle(native_data, JniHandleOwnership.DoNotTransfer);
			@object.Close(data);
		}

		// Token: 0x060013E4 RID: 5092 RVA: 0x0003FB74 File Offset: 0x0003DD74
		[Register("close", "(Ljava/io/InputStream;)V", "GetClose_Ljava_io_InputStream_Handler")]
		protected unsafe virtual void Close(Stream data)
		{
			IntPtr intPtr = InputStreamAdapter.ToLocalJniHandle(data);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				StreamAssetPathFetcher._members.InstanceMethods.InvokeVirtualVoidMethod("close.(Ljava/io/InputStream;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(data);
			}
		}

		// Token: 0x060013E5 RID: 5093 RVA: 0x0003FBD8 File Offset: 0x0003DDD8
		private static Delegate GetLoadResource_T_Landroid_content_res_AssetManager_Ljava_lang_String_Handler()
		{
			if (StreamAssetPathFetcher.cb_loadResource_Landroid_content_res_AssetManager_Ljava_lang_String_ == null)
			{
				StreamAssetPathFetcher.cb_loadResource_Landroid_content_res_AssetManager_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(StreamAssetPathFetcher.n_LoadResource_T_Landroid_content_res_AssetManager_Ljava_lang_String_));
			}
			return StreamAssetPathFetcher.cb_loadResource_Landroid_content_res_AssetManager_Ljava_lang_String_;
		}

		// Token: 0x060013E6 RID: 5094 RVA: 0x0003FBFC File Offset: 0x0003DDFC
		private static IntPtr n_LoadResource_T_Landroid_content_res_AssetManager_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_assetManager, IntPtr native_path)
		{
			StreamAssetPathFetcher @object = Java.Lang.Object.GetObject<StreamAssetPathFetcher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AssetManager object2 = Java.Lang.Object.GetObject<AssetManager>(native_assetManager, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_path, JniHandleOwnership.DoNotTransfer);
			return InputStreamAdapter.ToLocalJniHandle(@object.LoadResource_T(object2, @string));
		}

		// Token: 0x060013E7 RID: 5095 RVA: 0x0003FC30 File Offset: 0x0003DE30
		[Register("loadResource", "(Landroid/content/res/AssetManager;Ljava/lang/String;)Ljava/io/InputStream;", "GetLoadResource_T_Landroid_content_res_AssetManager_Ljava_lang_String_Handler")]
		protected unsafe virtual Stream LoadResource_T(AssetManager assetManager, string path)
		{
			IntPtr intPtr = JNIEnv.NewString(path);
			Stream result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((assetManager == null) ? IntPtr.Zero : assetManager.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				result = InputStreamInvoker.FromJniHandle(StreamAssetPathFetcher._members.InstanceMethods.InvokeVirtualObjectMethod("loadResource.(Landroid/content/res/AssetManager;Ljava/lang/String;)Ljava/io/InputStream;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(assetManager);
			}
			return result;
		}

		// Token: 0x040004AF RID: 1199
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/data/StreamAssetPathFetcher", typeof(StreamAssetPathFetcher));

		// Token: 0x040004B0 RID: 1200
		private static Delegate cb_getDataClass;

		// Token: 0x040004B1 RID: 1201
		private static Delegate cb_close_Ljava_io_InputStream_;

		// Token: 0x040004B2 RID: 1202
		private static Delegate cb_loadResource_Landroid_content_res_AssetManager_Ljava_lang_String_;
	}
}
