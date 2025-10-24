using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content.Res;
using Android.Net;
using Android.Runtime;
using Bumptech.Glide.Load.Data;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Model
{
	// Token: 0x02000126 RID: 294
	[Register("com/bumptech/glide/load/model/AssetUriLoader", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"Data"
	})]
	public class AssetUriLoader : Java.Lang.Object, IModelLoader, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000EFF RID: 3839 RVA: 0x00030367 File Offset: 0x0002E567
		public virtual ModelLoaderLoadData BuildLoadData(Java.Lang.Object model, int width, int height, Options options)
		{
			return this.BuildLoadData((Android.Net.Uri)model, width, height, options);
		}

		// Token: 0x06000F00 RID: 3840 RVA: 0x00030379 File Offset: 0x0002E579
		public virtual bool Handles(Java.Lang.Object model)
		{
			return this.Handles((Android.Net.Uri)model);
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06000F01 RID: 3841 RVA: 0x00030388 File Offset: 0x0002E588
		internal static IntPtr class_ref
		{
			get
			{
				return AssetUriLoader._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06000F02 RID: 3842 RVA: 0x000303AC File Offset: 0x0002E5AC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AssetUriLoader._members;
			}
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06000F03 RID: 3843 RVA: 0x000303B4 File Offset: 0x0002E5B4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AssetUriLoader._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06000F04 RID: 3844 RVA: 0x000303D8 File Offset: 0x0002E5D8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AssetUriLoader._members.ManagedPeerType;
			}
		}

		// Token: 0x06000F05 RID: 3845 RVA: 0x000303E4 File Offset: 0x0002E5E4
		protected AssetUriLoader(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000F06 RID: 3846 RVA: 0x000303F0 File Offset: 0x0002E5F0
		[Register(".ctor", "(Landroid/content/res/AssetManager;Lcom/bumptech/glide/load/model/AssetUriLoader$AssetFetcherFactory;)V", "")]
		public unsafe AssetUriLoader(AssetManager assetManager, AssetUriLoader.IAssetFetcherFactory factory) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((assetManager == null) ? IntPtr.Zero : assetManager.Handle);
				ptr[1] = new JniArgumentValue((factory == null) ? IntPtr.Zero : ((Java.Lang.Object)factory).Handle);
				base.SetHandle(AssetUriLoader._members.InstanceMethods.StartCreateInstance("(Landroid/content/res/AssetManager;Lcom/bumptech/glide/load/model/AssetUriLoader$AssetFetcherFactory;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				AssetUriLoader._members.InstanceMethods.FinishCreateInstance("(Landroid/content/res/AssetManager;Lcom/bumptech/glide/load/model/AssetUriLoader$AssetFetcherFactory;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(assetManager);
				GC.KeepAlive(factory);
			}
		}

		// Token: 0x06000F07 RID: 3847 RVA: 0x000304CC File Offset: 0x0002E6CC
		private static Delegate GetBuildLoadData_Landroid_net_Uri_IILcom_bumptech_glide_load_Options_Handler()
		{
			if (AssetUriLoader.cb_buildLoadData_Landroid_net_Uri_IILcom_bumptech_glide_load_Options_ == null)
			{
				AssetUriLoader.cb_buildLoadData_Landroid_net_Uri_IILcom_bumptech_glide_load_Options_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIIL_L(AssetUriLoader.n_BuildLoadData_Landroid_net_Uri_IILcom_bumptech_glide_load_Options_));
			}
			return AssetUriLoader.cb_buildLoadData_Landroid_net_Uri_IILcom_bumptech_glide_load_Options_;
		}

		// Token: 0x06000F08 RID: 3848 RVA: 0x000304F0 File Offset: 0x0002E6F0
		private static IntPtr n_BuildLoadData_Landroid_net_Uri_IILcom_bumptech_glide_load_Options_(IntPtr jnienv, IntPtr native__this, IntPtr native_model, int width, int height, IntPtr native_options)
		{
			AssetUriLoader @object = Java.Lang.Object.GetObject<AssetUriLoader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Android.Net.Uri object2 = Java.Lang.Object.GetObject<Android.Net.Uri>(native_model, JniHandleOwnership.DoNotTransfer);
			Options object3 = Java.Lang.Object.GetObject<Options>(native_options, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.BuildLoadData(object2, width, height, object3));
		}

		// Token: 0x06000F09 RID: 3849 RVA: 0x00030528 File Offset: 0x0002E728
		[Register("buildLoadData", "(Landroid/net/Uri;IILcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/model/ModelLoader$LoadData;", "GetBuildLoadData_Landroid_net_Uri_IILcom_bumptech_glide_load_Options_Handler")]
		public unsafe virtual ModelLoaderLoadData BuildLoadData(Android.Net.Uri model, int width, int height, Options options)
		{
			ModelLoaderLoadData @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((model == null) ? IntPtr.Zero : model.Handle);
				ptr[1] = new JniArgumentValue(width);
				ptr[2] = new JniArgumentValue(height);
				ptr[3] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				@object = Java.Lang.Object.GetObject<ModelLoaderLoadData>(AssetUriLoader._members.InstanceMethods.InvokeVirtualObjectMethod("buildLoadData.(Landroid/net/Uri;IILcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/model/ModelLoader$LoadData;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(model);
				GC.KeepAlive(options);
			}
			return @object;
		}

		// Token: 0x06000F0A RID: 3850 RVA: 0x000305F4 File Offset: 0x0002E7F4
		private static Delegate GetHandles_Landroid_net_Uri_Handler()
		{
			if (AssetUriLoader.cb_handles_Landroid_net_Uri_ == null)
			{
				AssetUriLoader.cb_handles_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(AssetUriLoader.n_Handles_Landroid_net_Uri_));
			}
			return AssetUriLoader.cb_handles_Landroid_net_Uri_;
		}

		// Token: 0x06000F0B RID: 3851 RVA: 0x00030618 File Offset: 0x0002E818
		private static bool n_Handles_Landroid_net_Uri_(IntPtr jnienv, IntPtr native__this, IntPtr native_model)
		{
			AssetUriLoader @object = Java.Lang.Object.GetObject<AssetUriLoader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Android.Net.Uri object2 = Java.Lang.Object.GetObject<Android.Net.Uri>(native_model, JniHandleOwnership.DoNotTransfer);
			return @object.Handles(object2);
		}

		// Token: 0x06000F0C RID: 3852 RVA: 0x0003063C File Offset: 0x0002E83C
		[Register("handles", "(Landroid/net/Uri;)Z", "GetHandles_Landroid_net_Uri_Handler")]
		public unsafe virtual bool Handles(Android.Net.Uri model)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((model == null) ? IntPtr.Zero : model.Handle);
				result = AssetUriLoader._members.InstanceMethods.InvokeVirtualBooleanMethod("handles.(Landroid/net/Uri;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(model);
			}
			return result;
		}

		// Token: 0x0400037A RID: 890
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/model/AssetUriLoader", typeof(AssetUriLoader));

		// Token: 0x0400037B RID: 891
		private static Delegate cb_buildLoadData_Landroid_net_Uri_IILcom_bumptech_glide_load_Options_;

		// Token: 0x0400037C RID: 892
		private static Delegate cb_handles_Landroid_net_Uri_;

		// Token: 0x020001CD RID: 461
		[Register("com/bumptech/glide/load/model/AssetUriLoader$AssetFetcherFactory", "", "Bumptech.Glide.Load.Model.AssetUriLoader/IAssetFetcherFactoryInvoker")]
		[JavaTypeParameters(new string[]
		{
			"Data"
		})]
		public interface IAssetFetcherFactory : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x0600160B RID: 5643
			[Register("buildFetcher", "(Landroid/content/res/AssetManager;Ljava/lang/String;)Lcom/bumptech/glide/load/data/DataFetcher;", "GetBuildFetcher_Landroid_content_res_AssetManager_Ljava_lang_String_Handler:Bumptech.Glide.Load.Model.AssetUriLoader/IAssetFetcherFactoryInvoker, Xamarin.Android.Glide")]
			IDataFetcher BuildFetcher(AssetManager p0, string p1);
		}

		// Token: 0x020001CE RID: 462
		[Register("com/bumptech/glide/load/model/AssetUriLoader$AssetFetcherFactory", DoNotGenerateAcw = true)]
		internal class IAssetFetcherFactoryInvoker : Java.Lang.Object, AssetUriLoader.IAssetFetcherFactory, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x170005F7 RID: 1527
			// (get) Token: 0x0600160C RID: 5644 RVA: 0x00045148 File Offset: 0x00043348
			private static IntPtr java_class_ref
			{
				get
				{
					return AssetUriLoader.IAssetFetcherFactoryInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170005F8 RID: 1528
			// (get) Token: 0x0600160D RID: 5645 RVA: 0x0004516C File Offset: 0x0004336C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return AssetUriLoader.IAssetFetcherFactoryInvoker._members;
				}
			}

			// Token: 0x170005F9 RID: 1529
			// (get) Token: 0x0600160E RID: 5646 RVA: 0x00045173 File Offset: 0x00043373
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x170005FA RID: 1530
			// (get) Token: 0x0600160F RID: 5647 RVA: 0x0004517B File Offset: 0x0004337B
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return AssetUriLoader.IAssetFetcherFactoryInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06001610 RID: 5648 RVA: 0x00045187 File Offset: 0x00043387
			public static AssetUriLoader.IAssetFetcherFactory GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<AssetUriLoader.IAssetFetcherFactory>(handle, transfer);
			}

			// Token: 0x06001611 RID: 5649 RVA: 0x00045190 File Offset: 0x00043390
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, AssetUriLoader.IAssetFetcherFactoryInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.bumptech.glide.load.model.AssetUriLoader.AssetFetcherFactory'.");
				}
				return handle;
			}

			// Token: 0x06001612 RID: 5650 RVA: 0x000451BB File Offset: 0x000433BB
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06001613 RID: 5651 RVA: 0x000451EC File Offset: 0x000433EC
			public IAssetFetcherFactoryInvoker(IntPtr handle, JniHandleOwnership transfer) : base(AssetUriLoader.IAssetFetcherFactoryInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x06001614 RID: 5652 RVA: 0x00045224 File Offset: 0x00043424
			private static Delegate GetBuildFetcher_Landroid_content_res_AssetManager_Ljava_lang_String_Handler()
			{
				if (AssetUriLoader.IAssetFetcherFactoryInvoker.cb_buildFetcher_Landroid_content_res_AssetManager_Ljava_lang_String_ == null)
				{
					AssetUriLoader.IAssetFetcherFactoryInvoker.cb_buildFetcher_Landroid_content_res_AssetManager_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(AssetUriLoader.IAssetFetcherFactoryInvoker.n_BuildFetcher_Landroid_content_res_AssetManager_Ljava_lang_String_));
				}
				return AssetUriLoader.IAssetFetcherFactoryInvoker.cb_buildFetcher_Landroid_content_res_AssetManager_Ljava_lang_String_;
			}

			// Token: 0x06001615 RID: 5653 RVA: 0x00045248 File Offset: 0x00043448
			private static IntPtr n_BuildFetcher_Landroid_content_res_AssetManager_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				AssetUriLoader.IAssetFetcherFactory @object = Java.Lang.Object.GetObject<AssetUriLoader.IAssetFetcherFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				AssetManager object2 = Java.Lang.Object.GetObject<AssetManager>(native_p0, JniHandleOwnership.DoNotTransfer);
				string @string = JNIEnv.GetString(native_p1, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.BuildFetcher(object2, @string));
			}

			// Token: 0x06001616 RID: 5654 RVA: 0x0004527C File Offset: 0x0004347C
			public unsafe IDataFetcher BuildFetcher(AssetManager p0, string p1)
			{
				if (this.id_buildFetcher_Landroid_content_res_AssetManager_Ljava_lang_String_ == IntPtr.Zero)
				{
					this.id_buildFetcher_Landroid_content_res_AssetManager_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "buildFetcher", "(Landroid/content/res/AssetManager;Ljava/lang/String;)Lcom/bumptech/glide/load/data/DataFetcher;");
				}
				IntPtr intPtr = JNIEnv.NewString(p1);
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JValue(intPtr);
				IDataFetcher @object = Java.Lang.Object.GetObject<IDataFetcher>(JNIEnv.CallObjectMethod(base.Handle, this.id_buildFetcher_Landroid_content_res_AssetManager_Ljava_lang_String_, ptr), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef(intPtr);
				return @object;
			}

			// Token: 0x04000549 RID: 1353
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/model/AssetUriLoader$AssetFetcherFactory", typeof(AssetUriLoader.IAssetFetcherFactoryInvoker));

			// Token: 0x0400054A RID: 1354
			private IntPtr class_ref;

			// Token: 0x0400054B RID: 1355
			private static Delegate cb_buildFetcher_Landroid_content_res_AssetManager_Ljava_lang_String_;

			// Token: 0x0400054C RID: 1356
			private IntPtr id_buildFetcher_Landroid_content_res_AssetManager_Ljava_lang_String_;
		}

		// Token: 0x020001CF RID: 463
		[Register("com/bumptech/glide/load/model/AssetUriLoader$FileDescriptorFactory", DoNotGenerateAcw = true)]
		public class FileDescriptorFactory : Java.Lang.Object, AssetUriLoader.IAssetFetcherFactory, IJavaObject, IDisposable, IJavaPeerable, IModelLoaderFactory
		{
			// Token: 0x170005FB RID: 1531
			// (get) Token: 0x06001618 RID: 5656 RVA: 0x00045330 File Offset: 0x00043530
			internal static IntPtr class_ref
			{
				get
				{
					return AssetUriLoader.FileDescriptorFactory._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170005FC RID: 1532
			// (get) Token: 0x06001619 RID: 5657 RVA: 0x00045354 File Offset: 0x00043554
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return AssetUriLoader.FileDescriptorFactory._members;
				}
			}

			// Token: 0x170005FD RID: 1533
			// (get) Token: 0x0600161A RID: 5658 RVA: 0x0004535C File Offset: 0x0004355C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return AssetUriLoader.FileDescriptorFactory._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170005FE RID: 1534
			// (get) Token: 0x0600161B RID: 5659 RVA: 0x00045380 File Offset: 0x00043580
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return AssetUriLoader.FileDescriptorFactory._members.ManagedPeerType;
				}
			}

			// Token: 0x0600161C RID: 5660 RVA: 0x0004538C File Offset: 0x0004358C
			protected FileDescriptorFactory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x0600161D RID: 5661 RVA: 0x00045398 File Offset: 0x00043598
			[Register(".ctor", "(Landroid/content/res/AssetManager;)V", "")]
			public unsafe FileDescriptorFactory(AssetManager assetManager) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((assetManager == null) ? IntPtr.Zero : assetManager.Handle);
					base.SetHandle(AssetUriLoader.FileDescriptorFactory._members.InstanceMethods.StartCreateInstance("(Landroid/content/res/AssetManager;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					AssetUriLoader.FileDescriptorFactory._members.InstanceMethods.FinishCreateInstance("(Landroid/content/res/AssetManager;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(assetManager);
				}
			}

			// Token: 0x0600161E RID: 5662 RVA: 0x00045448 File Offset: 0x00043648
			private static Delegate GetBuild_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_Handler()
			{
				if (AssetUriLoader.FileDescriptorFactory.cb_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_ == null)
				{
					AssetUriLoader.FileDescriptorFactory.cb_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AssetUriLoader.FileDescriptorFactory.n_Build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_));
				}
				return AssetUriLoader.FileDescriptorFactory.cb_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_;
			}

			// Token: 0x0600161F RID: 5663 RVA: 0x0004546C File Offset: 0x0004366C
			private static IntPtr n_Build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_(IntPtr jnienv, IntPtr native__this, IntPtr native_multiFactory)
			{
				AssetUriLoader.FileDescriptorFactory @object = Java.Lang.Object.GetObject<AssetUriLoader.FileDescriptorFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				MultiModelLoaderFactory object2 = Java.Lang.Object.GetObject<MultiModelLoaderFactory>(native_multiFactory, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.Build(object2));
			}

			// Token: 0x06001620 RID: 5664 RVA: 0x00045494 File Offset: 0x00043694
			[Register("build", "(Lcom/bumptech/glide/load/model/MultiModelLoaderFactory;)Lcom/bumptech/glide/load/model/ModelLoader;", "GetBuild_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_Handler")]
			public unsafe virtual IModelLoader Build(MultiModelLoaderFactory multiFactory)
			{
				IModelLoader @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((multiFactory == null) ? IntPtr.Zero : multiFactory.Handle);
					@object = Java.Lang.Object.GetObject<IModelLoader>(AssetUriLoader.FileDescriptorFactory._members.InstanceMethods.InvokeVirtualObjectMethod("build.(Lcom/bumptech/glide/load/model/MultiModelLoaderFactory;)Lcom/bumptech/glide/load/model/ModelLoader;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(multiFactory);
				}
				return @object;
			}

			// Token: 0x06001621 RID: 5665 RVA: 0x00045508 File Offset: 0x00043708
			private static Delegate GetBuildFetcher_Landroid_content_res_AssetManager_Ljava_lang_String_Handler()
			{
				if (AssetUriLoader.FileDescriptorFactory.cb_buildFetcher_Landroid_content_res_AssetManager_Ljava_lang_String_ == null)
				{
					AssetUriLoader.FileDescriptorFactory.cb_buildFetcher_Landroid_content_res_AssetManager_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(AssetUriLoader.FileDescriptorFactory.n_BuildFetcher_Landroid_content_res_AssetManager_Ljava_lang_String_));
				}
				return AssetUriLoader.FileDescriptorFactory.cb_buildFetcher_Landroid_content_res_AssetManager_Ljava_lang_String_;
			}

			// Token: 0x06001622 RID: 5666 RVA: 0x0004552C File Offset: 0x0004372C
			private static IntPtr n_BuildFetcher_Landroid_content_res_AssetManager_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_assetManager, IntPtr native_assetPath)
			{
				AssetUriLoader.FileDescriptorFactory @object = Java.Lang.Object.GetObject<AssetUriLoader.FileDescriptorFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				AssetManager object2 = Java.Lang.Object.GetObject<AssetManager>(native_assetManager, JniHandleOwnership.DoNotTransfer);
				string @string = JNIEnv.GetString(native_assetPath, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.BuildFetcher(object2, @string));
			}

			// Token: 0x06001623 RID: 5667 RVA: 0x00045560 File Offset: 0x00043760
			[Register("buildFetcher", "(Landroid/content/res/AssetManager;Ljava/lang/String;)Lcom/bumptech/glide/load/data/DataFetcher;", "GetBuildFetcher_Landroid_content_res_AssetManager_Ljava_lang_String_Handler")]
			public unsafe virtual IDataFetcher BuildFetcher(AssetManager assetManager, string assetPath)
			{
				IntPtr intPtr = JNIEnv.NewString(assetPath);
				IDataFetcher @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((assetManager == null) ? IntPtr.Zero : assetManager.Handle);
					ptr[1] = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<IDataFetcher>(AssetUriLoader.FileDescriptorFactory._members.InstanceMethods.InvokeVirtualObjectMethod("buildFetcher.(Landroid/content/res/AssetManager;Ljava/lang/String;)Lcom/bumptech/glide/load/data/DataFetcher;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(assetManager);
				}
				return @object;
			}

			// Token: 0x06001624 RID: 5668 RVA: 0x000455F4 File Offset: 0x000437F4
			private static Delegate GetTeardownHandler()
			{
				if (AssetUriLoader.FileDescriptorFactory.cb_teardown == null)
				{
					AssetUriLoader.FileDescriptorFactory.cb_teardown = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(AssetUriLoader.FileDescriptorFactory.n_Teardown));
				}
				return AssetUriLoader.FileDescriptorFactory.cb_teardown;
			}

			// Token: 0x06001625 RID: 5669 RVA: 0x00045618 File Offset: 0x00043818
			private static void n_Teardown(IntPtr jnienv, IntPtr native__this)
			{
				Java.Lang.Object.GetObject<AssetUriLoader.FileDescriptorFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Teardown();
			}

			// Token: 0x06001626 RID: 5670 RVA: 0x00045627 File Offset: 0x00043827
			[Register("teardown", "()V", "GetTeardownHandler")]
			public virtual void Teardown()
			{
				AssetUriLoader.FileDescriptorFactory._members.InstanceMethods.InvokeVirtualVoidMethod("teardown.()V", this, null);
			}

			// Token: 0x06001627 RID: 5671 RVA: 0x00045640 File Offset: 0x00043840
			IDataFetcher AssetUriLoader.IAssetFetcherFactory.BuildFetcher(AssetManager p0, string p1)
			{
				return this.BuildFetcher(p0, p1).JavaCast<IDataFetcher>();
			}

			// Token: 0x06001628 RID: 5672 RVA: 0x0004564F File Offset: 0x0004384F
			IModelLoader IModelLoaderFactory.Build(MultiModelLoaderFactory p0)
			{
				return this.Build(p0).JavaCast<IModelLoader>();
			}

			// Token: 0x0400054D RID: 1357
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/model/AssetUriLoader$FileDescriptorFactory", typeof(AssetUriLoader.FileDescriptorFactory));

			// Token: 0x0400054E RID: 1358
			private static Delegate cb_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_;

			// Token: 0x0400054F RID: 1359
			private static Delegate cb_buildFetcher_Landroid_content_res_AssetManager_Ljava_lang_String_;

			// Token: 0x04000550 RID: 1360
			private static Delegate cb_teardown;
		}

		// Token: 0x020001D0 RID: 464
		[Register("com/bumptech/glide/load/model/AssetUriLoader$StreamFactory", DoNotGenerateAcw = true)]
		public class StreamFactory : Java.Lang.Object, AssetUriLoader.IAssetFetcherFactory, IJavaObject, IDisposable, IJavaPeerable, IModelLoaderFactory
		{
			// Token: 0x170005FF RID: 1535
			// (get) Token: 0x0600162A RID: 5674 RVA: 0x00045678 File Offset: 0x00043878
			internal static IntPtr class_ref
			{
				get
				{
					return AssetUriLoader.StreamFactory._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000600 RID: 1536
			// (get) Token: 0x0600162B RID: 5675 RVA: 0x0004569C File Offset: 0x0004389C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return AssetUriLoader.StreamFactory._members;
				}
			}

			// Token: 0x17000601 RID: 1537
			// (get) Token: 0x0600162C RID: 5676 RVA: 0x000456A4 File Offset: 0x000438A4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return AssetUriLoader.StreamFactory._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000602 RID: 1538
			// (get) Token: 0x0600162D RID: 5677 RVA: 0x000456C8 File Offset: 0x000438C8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return AssetUriLoader.StreamFactory._members.ManagedPeerType;
				}
			}

			// Token: 0x0600162E RID: 5678 RVA: 0x000456D4 File Offset: 0x000438D4
			protected StreamFactory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x0600162F RID: 5679 RVA: 0x000456E0 File Offset: 0x000438E0
			[Register(".ctor", "(Landroid/content/res/AssetManager;)V", "")]
			public unsafe StreamFactory(AssetManager assetManager) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((assetManager == null) ? IntPtr.Zero : assetManager.Handle);
					base.SetHandle(AssetUriLoader.StreamFactory._members.InstanceMethods.StartCreateInstance("(Landroid/content/res/AssetManager;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					AssetUriLoader.StreamFactory._members.InstanceMethods.FinishCreateInstance("(Landroid/content/res/AssetManager;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(assetManager);
				}
			}

			// Token: 0x06001630 RID: 5680 RVA: 0x00045790 File Offset: 0x00043990
			private static Delegate GetBuild_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_Handler()
			{
				if (AssetUriLoader.StreamFactory.cb_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_ == null)
				{
					AssetUriLoader.StreamFactory.cb_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AssetUriLoader.StreamFactory.n_Build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_));
				}
				return AssetUriLoader.StreamFactory.cb_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_;
			}

			// Token: 0x06001631 RID: 5681 RVA: 0x000457B4 File Offset: 0x000439B4
			private static IntPtr n_Build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_(IntPtr jnienv, IntPtr native__this, IntPtr native_multiFactory)
			{
				AssetUriLoader.StreamFactory @object = Java.Lang.Object.GetObject<AssetUriLoader.StreamFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				MultiModelLoaderFactory object2 = Java.Lang.Object.GetObject<MultiModelLoaderFactory>(native_multiFactory, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.Build(object2));
			}

			// Token: 0x06001632 RID: 5682 RVA: 0x000457DC File Offset: 0x000439DC
			[Register("build", "(Lcom/bumptech/glide/load/model/MultiModelLoaderFactory;)Lcom/bumptech/glide/load/model/ModelLoader;", "GetBuild_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_Handler")]
			public unsafe virtual IModelLoader Build(MultiModelLoaderFactory multiFactory)
			{
				IModelLoader @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((multiFactory == null) ? IntPtr.Zero : multiFactory.Handle);
					@object = Java.Lang.Object.GetObject<IModelLoader>(AssetUriLoader.StreamFactory._members.InstanceMethods.InvokeVirtualObjectMethod("build.(Lcom/bumptech/glide/load/model/MultiModelLoaderFactory;)Lcom/bumptech/glide/load/model/ModelLoader;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(multiFactory);
				}
				return @object;
			}

			// Token: 0x06001633 RID: 5683 RVA: 0x00045850 File Offset: 0x00043A50
			private static Delegate GetBuildFetcher_Landroid_content_res_AssetManager_Ljava_lang_String_Handler()
			{
				if (AssetUriLoader.StreamFactory.cb_buildFetcher_Landroid_content_res_AssetManager_Ljava_lang_String_ == null)
				{
					AssetUriLoader.StreamFactory.cb_buildFetcher_Landroid_content_res_AssetManager_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(AssetUriLoader.StreamFactory.n_BuildFetcher_Landroid_content_res_AssetManager_Ljava_lang_String_));
				}
				return AssetUriLoader.StreamFactory.cb_buildFetcher_Landroid_content_res_AssetManager_Ljava_lang_String_;
			}

			// Token: 0x06001634 RID: 5684 RVA: 0x00045874 File Offset: 0x00043A74
			private static IntPtr n_BuildFetcher_Landroid_content_res_AssetManager_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_assetManager, IntPtr native_assetPath)
			{
				AssetUriLoader.StreamFactory @object = Java.Lang.Object.GetObject<AssetUriLoader.StreamFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				AssetManager object2 = Java.Lang.Object.GetObject<AssetManager>(native_assetManager, JniHandleOwnership.DoNotTransfer);
				string @string = JNIEnv.GetString(native_assetPath, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.BuildFetcher(object2, @string));
			}

			// Token: 0x06001635 RID: 5685 RVA: 0x000458A8 File Offset: 0x00043AA8
			[Register("buildFetcher", "(Landroid/content/res/AssetManager;Ljava/lang/String;)Lcom/bumptech/glide/load/data/DataFetcher;", "GetBuildFetcher_Landroid_content_res_AssetManager_Ljava_lang_String_Handler")]
			public unsafe virtual IDataFetcher BuildFetcher(AssetManager assetManager, string assetPath)
			{
				IntPtr intPtr = JNIEnv.NewString(assetPath);
				IDataFetcher @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((assetManager == null) ? IntPtr.Zero : assetManager.Handle);
					ptr[1] = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<IDataFetcher>(AssetUriLoader.StreamFactory._members.InstanceMethods.InvokeVirtualObjectMethod("buildFetcher.(Landroid/content/res/AssetManager;Ljava/lang/String;)Lcom/bumptech/glide/load/data/DataFetcher;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(assetManager);
				}
				return @object;
			}

			// Token: 0x06001636 RID: 5686 RVA: 0x0004593C File Offset: 0x00043B3C
			private static Delegate GetTeardownHandler()
			{
				if (AssetUriLoader.StreamFactory.cb_teardown == null)
				{
					AssetUriLoader.StreamFactory.cb_teardown = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(AssetUriLoader.StreamFactory.n_Teardown));
				}
				return AssetUriLoader.StreamFactory.cb_teardown;
			}

			// Token: 0x06001637 RID: 5687 RVA: 0x00045960 File Offset: 0x00043B60
			private static void n_Teardown(IntPtr jnienv, IntPtr native__this)
			{
				Java.Lang.Object.GetObject<AssetUriLoader.StreamFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Teardown();
			}

			// Token: 0x06001638 RID: 5688 RVA: 0x0004596F File Offset: 0x00043B6F
			[Register("teardown", "()V", "GetTeardownHandler")]
			public virtual void Teardown()
			{
				AssetUriLoader.StreamFactory._members.InstanceMethods.InvokeVirtualVoidMethod("teardown.()V", this, null);
			}

			// Token: 0x06001639 RID: 5689 RVA: 0x00045988 File Offset: 0x00043B88
			IDataFetcher AssetUriLoader.IAssetFetcherFactory.BuildFetcher(AssetManager p0, string p1)
			{
				return this.BuildFetcher(p0, p1).JavaCast<IDataFetcher>();
			}

			// Token: 0x0600163A RID: 5690 RVA: 0x00045997 File Offset: 0x00043B97
			IModelLoader IModelLoaderFactory.Build(MultiModelLoaderFactory p0)
			{
				return this.Build(p0).JavaCast<IModelLoader>();
			}

			// Token: 0x04000551 RID: 1361
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/model/AssetUriLoader$StreamFactory", typeof(AssetUriLoader.StreamFactory));

			// Token: 0x04000552 RID: 1362
			private static Delegate cb_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_;

			// Token: 0x04000553 RID: 1363
			private static Delegate cb_buildFetcher_Landroid_content_res_AssetManager_Ljava_lang_String_;

			// Token: 0x04000554 RID: 1364
			private static Delegate cb_teardown;
		}
	}
}
