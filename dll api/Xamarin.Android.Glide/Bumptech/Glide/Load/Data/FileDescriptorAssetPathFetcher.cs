using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content.Res;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Data
{
	// Token: 0x02000187 RID: 391
	[Register("com/bumptech/glide/load/data/FileDescriptorAssetPathFetcher", DoNotGenerateAcw = true)]
	public class FileDescriptorAssetPathFetcher : AssetPathFetcher
	{
		// Token: 0x060013B3 RID: 5043 RVA: 0x0003F237 File Offset: 0x0003D437
		protected override void Close(Java.Lang.Object data)
		{
			this.Close((ParcelFileDescriptor)data);
		}

		// Token: 0x060013B4 RID: 5044 RVA: 0x0003F245 File Offset: 0x0003D445
		protected override Java.Lang.Object LoadResource(AssetManager assetManager, string path)
		{
			return this.LoadResource_T(assetManager, path);
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x060013B5 RID: 5045 RVA: 0x0003F250 File Offset: 0x0003D450
		internal new static IntPtr class_ref
		{
			get
			{
				return FileDescriptorAssetPathFetcher._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x060013B6 RID: 5046 RVA: 0x0003F274 File Offset: 0x0003D474
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return FileDescriptorAssetPathFetcher._members;
			}
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x060013B7 RID: 5047 RVA: 0x0003F27C File Offset: 0x0003D47C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return FileDescriptorAssetPathFetcher._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x060013B8 RID: 5048 RVA: 0x0003F2A0 File Offset: 0x0003D4A0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return FileDescriptorAssetPathFetcher._members.ManagedPeerType;
			}
		}

		// Token: 0x060013B9 RID: 5049 RVA: 0x0003F2AC File Offset: 0x0003D4AC
		protected FileDescriptorAssetPathFetcher(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060013BA RID: 5050 RVA: 0x0003F2B8 File Offset: 0x0003D4B8
		[Register(".ctor", "(Landroid/content/res/AssetManager;Ljava/lang/String;)V", "")]
		public unsafe FileDescriptorAssetPathFetcher(AssetManager assetManager, string assetPath) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(FileDescriptorAssetPathFetcher._members.InstanceMethods.StartCreateInstance("(Landroid/content/res/AssetManager;Ljava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				FileDescriptorAssetPathFetcher._members.InstanceMethods.FinishCreateInstance("(Landroid/content/res/AssetManager;Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(assetManager);
			}
		}

		// Token: 0x060013BB RID: 5051 RVA: 0x0003F384 File Offset: 0x0003D584
		private static Delegate GetGetDataClassHandler()
		{
			if (FileDescriptorAssetPathFetcher.cb_getDataClass == null)
			{
				FileDescriptorAssetPathFetcher.cb_getDataClass = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(FileDescriptorAssetPathFetcher.n_GetDataClass));
			}
			return FileDescriptorAssetPathFetcher.cb_getDataClass;
		}

		// Token: 0x060013BC RID: 5052 RVA: 0x0003F3A8 File Offset: 0x0003D5A8
		private static IntPtr n_GetDataClass(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<FileDescriptorAssetPathFetcher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DataClass);
		}

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x060013BD RID: 5053 RVA: 0x0003F3BC File Offset: 0x0003D5BC
		public override Class DataClass
		{
			[Register("getDataClass", "()Ljava/lang/Class;", "GetGetDataClassHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Class>(FileDescriptorAssetPathFetcher._members.InstanceMethods.InvokeVirtualObjectMethod("getDataClass.()Ljava/lang/Class;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060013BE RID: 5054 RVA: 0x0003F3EE File Offset: 0x0003D5EE
		private static Delegate GetClose_Landroid_content_res_AssetFileDescriptor_Handler()
		{
			if (FileDescriptorAssetPathFetcher.cb_close_Landroid_content_res_AssetFileDescriptor_ == null)
			{
				FileDescriptorAssetPathFetcher.cb_close_Landroid_content_res_AssetFileDescriptor_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(FileDescriptorAssetPathFetcher.n_Close_Landroid_content_res_AssetFileDescriptor_));
			}
			return FileDescriptorAssetPathFetcher.cb_close_Landroid_content_res_AssetFileDescriptor_;
		}

		// Token: 0x060013BF RID: 5055 RVA: 0x0003F414 File Offset: 0x0003D614
		private static void n_Close_Landroid_content_res_AssetFileDescriptor_(IntPtr jnienv, IntPtr native__this, IntPtr native_data)
		{
			FileDescriptorAssetPathFetcher @object = Java.Lang.Object.GetObject<FileDescriptorAssetPathFetcher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AssetFileDescriptor object2 = Java.Lang.Object.GetObject<AssetFileDescriptor>(native_data, JniHandleOwnership.DoNotTransfer);
			@object.Close(object2);
		}

		// Token: 0x060013C0 RID: 5056 RVA: 0x0003F438 File Offset: 0x0003D638
		[Register("close", "(Landroid/content/res/AssetFileDescriptor;)V", "GetClose_Landroid_content_res_AssetFileDescriptor_Handler")]
		protected unsafe virtual void Close(AssetFileDescriptor data)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((data == null) ? IntPtr.Zero : data.Handle);
				FileDescriptorAssetPathFetcher._members.InstanceMethods.InvokeVirtualVoidMethod("close.(Landroid/content/res/AssetFileDescriptor;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(data);
			}
		}

		// Token: 0x060013C1 RID: 5057 RVA: 0x0003F49C File Offset: 0x0003D69C
		private static Delegate GetLoadResource_T_Landroid_content_res_AssetManager_Ljava_lang_String_Handler()
		{
			if (FileDescriptorAssetPathFetcher.cb_loadResource_Landroid_content_res_AssetManager_Ljava_lang_String_ == null)
			{
				FileDescriptorAssetPathFetcher.cb_loadResource_Landroid_content_res_AssetManager_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(FileDescriptorAssetPathFetcher.n_LoadResource_T_Landroid_content_res_AssetManager_Ljava_lang_String_));
			}
			return FileDescriptorAssetPathFetcher.cb_loadResource_Landroid_content_res_AssetManager_Ljava_lang_String_;
		}

		// Token: 0x060013C2 RID: 5058 RVA: 0x0003F4C0 File Offset: 0x0003D6C0
		private static IntPtr n_LoadResource_T_Landroid_content_res_AssetManager_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_assetManager, IntPtr native_path)
		{
			FileDescriptorAssetPathFetcher @object = Java.Lang.Object.GetObject<FileDescriptorAssetPathFetcher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AssetManager object2 = Java.Lang.Object.GetObject<AssetManager>(native_assetManager, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_path, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.LoadResource_T(object2, @string));
		}

		// Token: 0x060013C3 RID: 5059 RVA: 0x0003F4F4 File Offset: 0x0003D6F4
		[Register("loadResource", "(Landroid/content/res/AssetManager;Ljava/lang/String;)Landroid/content/res/AssetFileDescriptor;", "GetLoadResource_T_Landroid_content_res_AssetManager_Ljava_lang_String_Handler")]
		protected unsafe virtual AssetFileDescriptor LoadResource_T(AssetManager assetManager, string path)
		{
			IntPtr intPtr = JNIEnv.NewString(path);
			AssetFileDescriptor @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((assetManager == null) ? IntPtr.Zero : assetManager.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<AssetFileDescriptor>(FileDescriptorAssetPathFetcher._members.InstanceMethods.InvokeVirtualObjectMethod("loadResource.(Landroid/content/res/AssetManager;Ljava/lang/String;)Landroid/content/res/AssetFileDescriptor;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(assetManager);
			}
			return @object;
		}

		// Token: 0x040004A7 RID: 1191
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/data/FileDescriptorAssetPathFetcher", typeof(FileDescriptorAssetPathFetcher));

		// Token: 0x040004A8 RID: 1192
		private static Delegate cb_getDataClass;

		// Token: 0x040004A9 RID: 1193
		private static Delegate cb_close_Landroid_content_res_AssetFileDescriptor_;

		// Token: 0x040004AA RID: 1194
		private static Delegate cb_loadResource_Landroid_content_res_AssetManager_Ljava_lang_String_;
	}
}
