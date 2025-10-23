using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Net;
using Android.Runtime;
using Bumptech.Glide.Load.Data;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Model
{
	// Token: 0x0200012B RID: 299
	[Register("com/bumptech/glide/load/model/UriLoader", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"Data"
	})]
	public class UriLoader : Java.Lang.Object, IModelLoader, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000F4A RID: 3914 RVA: 0x000313EF File Offset: 0x0002F5EF
		public virtual ModelLoaderLoadData BuildLoadData(Java.Lang.Object model, int width, int height, Options options)
		{
			return this.BuildLoadData((Android.Net.Uri)model, width, height, options);
		}

		// Token: 0x06000F4B RID: 3915 RVA: 0x00031401 File Offset: 0x0002F601
		public virtual bool Handles(Java.Lang.Object model)
		{
			return this.Handles((Android.Net.Uri)model);
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06000F4C RID: 3916 RVA: 0x00031410 File Offset: 0x0002F610
		internal static IntPtr class_ref
		{
			get
			{
				return UriLoader._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06000F4D RID: 3917 RVA: 0x00031434 File Offset: 0x0002F634
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return UriLoader._members;
			}
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06000F4E RID: 3918 RVA: 0x0003143C File Offset: 0x0002F63C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return UriLoader._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06000F4F RID: 3919 RVA: 0x00031460 File Offset: 0x0002F660
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return UriLoader._members.ManagedPeerType;
			}
		}

		// Token: 0x06000F50 RID: 3920 RVA: 0x0003146C File Offset: 0x0002F66C
		protected UriLoader(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000F51 RID: 3921 RVA: 0x00031478 File Offset: 0x0002F678
		[Register(".ctor", "(Lcom/bumptech/glide/load/model/UriLoader$LocalUriFetcherFactory;)V", "")]
		public unsafe UriLoader(UriLoader.ILocalUriFetcherFactory factory) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((factory == null) ? IntPtr.Zero : ((Java.Lang.Object)factory).Handle);
				base.SetHandle(UriLoader._members.InstanceMethods.StartCreateInstance("(Lcom/bumptech/glide/load/model/UriLoader$LocalUriFetcherFactory;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				UriLoader._members.InstanceMethods.FinishCreateInstance("(Lcom/bumptech/glide/load/model/UriLoader$LocalUriFetcherFactory;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(factory);
			}
		}

		// Token: 0x06000F52 RID: 3922 RVA: 0x0003152C File Offset: 0x0002F72C
		private static Delegate GetBuildLoadData_Landroid_net_Uri_IILcom_bumptech_glide_load_Options_Handler()
		{
			if (UriLoader.cb_buildLoadData_Landroid_net_Uri_IILcom_bumptech_glide_load_Options_ == null)
			{
				UriLoader.cb_buildLoadData_Landroid_net_Uri_IILcom_bumptech_glide_load_Options_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIIL_L(UriLoader.n_BuildLoadData_Landroid_net_Uri_IILcom_bumptech_glide_load_Options_));
			}
			return UriLoader.cb_buildLoadData_Landroid_net_Uri_IILcom_bumptech_glide_load_Options_;
		}

		// Token: 0x06000F53 RID: 3923 RVA: 0x00031550 File Offset: 0x0002F750
		private static IntPtr n_BuildLoadData_Landroid_net_Uri_IILcom_bumptech_glide_load_Options_(IntPtr jnienv, IntPtr native__this, IntPtr native_model, int width, int height, IntPtr native_options)
		{
			UriLoader @object = Java.Lang.Object.GetObject<UriLoader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Android.Net.Uri object2 = Java.Lang.Object.GetObject<Android.Net.Uri>(native_model, JniHandleOwnership.DoNotTransfer);
			Options object3 = Java.Lang.Object.GetObject<Options>(native_options, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.BuildLoadData(object2, width, height, object3));
		}

		// Token: 0x06000F54 RID: 3924 RVA: 0x00031588 File Offset: 0x0002F788
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
				@object = Java.Lang.Object.GetObject<ModelLoaderLoadData>(UriLoader._members.InstanceMethods.InvokeVirtualObjectMethod("buildLoadData.(Landroid/net/Uri;IILcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/model/ModelLoader$LoadData;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(model);
				GC.KeepAlive(options);
			}
			return @object;
		}

		// Token: 0x06000F55 RID: 3925 RVA: 0x00031654 File Offset: 0x0002F854
		private static Delegate GetHandles_Landroid_net_Uri_Handler()
		{
			if (UriLoader.cb_handles_Landroid_net_Uri_ == null)
			{
				UriLoader.cb_handles_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(UriLoader.n_Handles_Landroid_net_Uri_));
			}
			return UriLoader.cb_handles_Landroid_net_Uri_;
		}

		// Token: 0x06000F56 RID: 3926 RVA: 0x00031678 File Offset: 0x0002F878
		private static bool n_Handles_Landroid_net_Uri_(IntPtr jnienv, IntPtr native__this, IntPtr native_model)
		{
			UriLoader @object = Java.Lang.Object.GetObject<UriLoader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Android.Net.Uri object2 = Java.Lang.Object.GetObject<Android.Net.Uri>(native_model, JniHandleOwnership.DoNotTransfer);
			return @object.Handles(object2);
		}

		// Token: 0x06000F57 RID: 3927 RVA: 0x0003169C File Offset: 0x0002F89C
		[Register("handles", "(Landroid/net/Uri;)Z", "GetHandles_Landroid_net_Uri_Handler")]
		public unsafe virtual bool Handles(Android.Net.Uri model)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((model == null) ? IntPtr.Zero : model.Handle);
				result = UriLoader._members.InstanceMethods.InvokeVirtualBooleanMethod("handles.(Landroid/net/Uri;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(model);
			}
			return result;
		}

		// Token: 0x04000389 RID: 905
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/model/UriLoader", typeof(UriLoader));

		// Token: 0x0400038A RID: 906
		private static Delegate cb_buildLoadData_Landroid_net_Uri_IILcom_bumptech_glide_load_Options_;

		// Token: 0x0400038B RID: 907
		private static Delegate cb_handles_Landroid_net_Uri_;

		// Token: 0x020001E1 RID: 481
		[Register("com/bumptech/glide/load/model/UriLoader$AssetFileDescriptorFactory", DoNotGenerateAcw = true)]
		public sealed class AssetFileDescriptorFactory : Java.Lang.Object, IModelLoaderFactory, IJavaObject, IDisposable, IJavaPeerable, UriLoader.ILocalUriFetcherFactory
		{
			// Token: 0x1700063F RID: 1599
			// (get) Token: 0x060016EF RID: 5871 RVA: 0x0004756C File Offset: 0x0004576C
			internal static IntPtr class_ref
			{
				get
				{
					return UriLoader.AssetFileDescriptorFactory._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000640 RID: 1600
			// (get) Token: 0x060016F0 RID: 5872 RVA: 0x00047590 File Offset: 0x00045790
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return UriLoader.AssetFileDescriptorFactory._members;
				}
			}

			// Token: 0x17000641 RID: 1601
			// (get) Token: 0x060016F1 RID: 5873 RVA: 0x00047598 File Offset: 0x00045798
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return UriLoader.AssetFileDescriptorFactory._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000642 RID: 1602
			// (get) Token: 0x060016F2 RID: 5874 RVA: 0x000475BC File Offset: 0x000457BC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return UriLoader.AssetFileDescriptorFactory._members.ManagedPeerType;
				}
			}

			// Token: 0x060016F3 RID: 5875 RVA: 0x000475C8 File Offset: 0x000457C8
			internal AssetFileDescriptorFactory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x060016F4 RID: 5876 RVA: 0x000475D4 File Offset: 0x000457D4
			[Register(".ctor", "(Landroid/content/ContentResolver;)V", "")]
			public unsafe AssetFileDescriptorFactory(ContentResolver contentResolver) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((contentResolver == null) ? IntPtr.Zero : contentResolver.Handle);
					base.SetHandle(UriLoader.AssetFileDescriptorFactory._members.InstanceMethods.StartCreateInstance("(Landroid/content/ContentResolver;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					UriLoader.AssetFileDescriptorFactory._members.InstanceMethods.FinishCreateInstance("(Landroid/content/ContentResolver;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(contentResolver);
				}
			}

			// Token: 0x060016F5 RID: 5877 RVA: 0x00047684 File Offset: 0x00045884
			[Register("build", "(Landroid/net/Uri;)Lcom/bumptech/glide/load/data/DataFetcher;", "")]
			public unsafe IDataFetcher Build(Android.Net.Uri uri)
			{
				IDataFetcher @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((uri == null) ? IntPtr.Zero : uri.Handle);
					@object = Java.Lang.Object.GetObject<IDataFetcher>(UriLoader.AssetFileDescriptorFactory._members.InstanceMethods.InvokeAbstractObjectMethod("build.(Landroid/net/Uri;)Lcom/bumptech/glide/load/data/DataFetcher;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(uri);
				}
				return @object;
			}

			// Token: 0x060016F6 RID: 5878 RVA: 0x000476F8 File Offset: 0x000458F8
			[Register("build", "(Lcom/bumptech/glide/load/model/MultiModelLoaderFactory;)Lcom/bumptech/glide/load/model/ModelLoader;", "")]
			public unsafe IModelLoader Build(MultiModelLoaderFactory multiFactory)
			{
				IModelLoader @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((multiFactory == null) ? IntPtr.Zero : multiFactory.Handle);
					@object = Java.Lang.Object.GetObject<IModelLoader>(UriLoader.AssetFileDescriptorFactory._members.InstanceMethods.InvokeAbstractObjectMethod("build.(Lcom/bumptech/glide/load/model/MultiModelLoaderFactory;)Lcom/bumptech/glide/load/model/ModelLoader;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(multiFactory);
				}
				return @object;
			}

			// Token: 0x060016F7 RID: 5879 RVA: 0x0004776C File Offset: 0x0004596C
			[Register("teardown", "()V", "")]
			public void Teardown()
			{
				UriLoader.AssetFileDescriptorFactory._members.InstanceMethods.InvokeAbstractVoidMethod("teardown.()V", this, null);
			}

			// Token: 0x060016F8 RID: 5880 RVA: 0x00047785 File Offset: 0x00045985
			IModelLoader IModelLoaderFactory.Build(MultiModelLoaderFactory p0)
			{
				return this.Build(p0).JavaCast<IModelLoader>();
			}

			// Token: 0x060016F9 RID: 5881 RVA: 0x00047793 File Offset: 0x00045993
			IDataFetcher UriLoader.ILocalUriFetcherFactory.Build(Android.Net.Uri p0)
			{
				return this.Build(p0).JavaCast<IDataFetcher>();
			}

			// Token: 0x0400057D RID: 1405
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/model/UriLoader$AssetFileDescriptorFactory", typeof(UriLoader.AssetFileDescriptorFactory));
		}

		// Token: 0x020001E2 RID: 482
		[Register("com/bumptech/glide/load/model/UriLoader$FileDescriptorFactory", DoNotGenerateAcw = true)]
		public class FileDescriptorFactory : Java.Lang.Object, IModelLoaderFactory, IJavaObject, IDisposable, IJavaPeerable, UriLoader.ILocalUriFetcherFactory
		{
			// Token: 0x17000643 RID: 1603
			// (get) Token: 0x060016FB RID: 5883 RVA: 0x000477BC File Offset: 0x000459BC
			internal static IntPtr class_ref
			{
				get
				{
					return UriLoader.FileDescriptorFactory._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000644 RID: 1604
			// (get) Token: 0x060016FC RID: 5884 RVA: 0x000477E0 File Offset: 0x000459E0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return UriLoader.FileDescriptorFactory._members;
				}
			}

			// Token: 0x17000645 RID: 1605
			// (get) Token: 0x060016FD RID: 5885 RVA: 0x000477E8 File Offset: 0x000459E8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return UriLoader.FileDescriptorFactory._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000646 RID: 1606
			// (get) Token: 0x060016FE RID: 5886 RVA: 0x0004780C File Offset: 0x00045A0C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return UriLoader.FileDescriptorFactory._members.ManagedPeerType;
				}
			}

			// Token: 0x060016FF RID: 5887 RVA: 0x00047818 File Offset: 0x00045A18
			protected FileDescriptorFactory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06001700 RID: 5888 RVA: 0x00047824 File Offset: 0x00045A24
			[Register(".ctor", "(Landroid/content/ContentResolver;)V", "")]
			public unsafe FileDescriptorFactory(ContentResolver contentResolver) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((contentResolver == null) ? IntPtr.Zero : contentResolver.Handle);
					base.SetHandle(UriLoader.FileDescriptorFactory._members.InstanceMethods.StartCreateInstance("(Landroid/content/ContentResolver;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					UriLoader.FileDescriptorFactory._members.InstanceMethods.FinishCreateInstance("(Landroid/content/ContentResolver;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(contentResolver);
				}
			}

			// Token: 0x06001701 RID: 5889 RVA: 0x000478D4 File Offset: 0x00045AD4
			private static Delegate GetBuild_Landroid_net_Uri_Handler()
			{
				if (UriLoader.FileDescriptorFactory.cb_build_Landroid_net_Uri_ == null)
				{
					UriLoader.FileDescriptorFactory.cb_build_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(UriLoader.FileDescriptorFactory.n_Build_Landroid_net_Uri_));
				}
				return UriLoader.FileDescriptorFactory.cb_build_Landroid_net_Uri_;
			}

			// Token: 0x06001702 RID: 5890 RVA: 0x000478F8 File Offset: 0x00045AF8
			private static IntPtr n_Build_Landroid_net_Uri_(IntPtr jnienv, IntPtr native__this, IntPtr native_uri)
			{
				UriLoader.FileDescriptorFactory @object = Java.Lang.Object.GetObject<UriLoader.FileDescriptorFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Android.Net.Uri object2 = Java.Lang.Object.GetObject<Android.Net.Uri>(native_uri, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.Build(object2));
			}

			// Token: 0x06001703 RID: 5891 RVA: 0x00047920 File Offset: 0x00045B20
			[Register("build", "(Landroid/net/Uri;)Lcom/bumptech/glide/load/data/DataFetcher;", "GetBuild_Landroid_net_Uri_Handler")]
			public unsafe virtual IDataFetcher Build(Android.Net.Uri uri)
			{
				IDataFetcher @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((uri == null) ? IntPtr.Zero : uri.Handle);
					@object = Java.Lang.Object.GetObject<IDataFetcher>(UriLoader.FileDescriptorFactory._members.InstanceMethods.InvokeVirtualObjectMethod("build.(Landroid/net/Uri;)Lcom/bumptech/glide/load/data/DataFetcher;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(uri);
				}
				return @object;
			}

			// Token: 0x06001704 RID: 5892 RVA: 0x00047994 File Offset: 0x00045B94
			private static Delegate GetBuild_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_Handler()
			{
				if (UriLoader.FileDescriptorFactory.cb_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_ == null)
				{
					UriLoader.FileDescriptorFactory.cb_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(UriLoader.FileDescriptorFactory.n_Build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_));
				}
				return UriLoader.FileDescriptorFactory.cb_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_;
			}

			// Token: 0x06001705 RID: 5893 RVA: 0x000479B8 File Offset: 0x00045BB8
			private static IntPtr n_Build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_(IntPtr jnienv, IntPtr native__this, IntPtr native_multiFactory)
			{
				UriLoader.FileDescriptorFactory @object = Java.Lang.Object.GetObject<UriLoader.FileDescriptorFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				MultiModelLoaderFactory object2 = Java.Lang.Object.GetObject<MultiModelLoaderFactory>(native_multiFactory, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.Build(object2));
			}

			// Token: 0x06001706 RID: 5894 RVA: 0x000479E0 File Offset: 0x00045BE0
			[Register("build", "(Lcom/bumptech/glide/load/model/MultiModelLoaderFactory;)Lcom/bumptech/glide/load/model/ModelLoader;", "GetBuild_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_Handler")]
			public unsafe virtual IModelLoader Build(MultiModelLoaderFactory multiFactory)
			{
				IModelLoader @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((multiFactory == null) ? IntPtr.Zero : multiFactory.Handle);
					@object = Java.Lang.Object.GetObject<IModelLoader>(UriLoader.FileDescriptorFactory._members.InstanceMethods.InvokeVirtualObjectMethod("build.(Lcom/bumptech/glide/load/model/MultiModelLoaderFactory;)Lcom/bumptech/glide/load/model/ModelLoader;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(multiFactory);
				}
				return @object;
			}

			// Token: 0x06001707 RID: 5895 RVA: 0x00047A54 File Offset: 0x00045C54
			private static Delegate GetTeardownHandler()
			{
				if (UriLoader.FileDescriptorFactory.cb_teardown == null)
				{
					UriLoader.FileDescriptorFactory.cb_teardown = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(UriLoader.FileDescriptorFactory.n_Teardown));
				}
				return UriLoader.FileDescriptorFactory.cb_teardown;
			}

			// Token: 0x06001708 RID: 5896 RVA: 0x00047A78 File Offset: 0x00045C78
			private static void n_Teardown(IntPtr jnienv, IntPtr native__this)
			{
				Java.Lang.Object.GetObject<UriLoader.FileDescriptorFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Teardown();
			}

			// Token: 0x06001709 RID: 5897 RVA: 0x00047A87 File Offset: 0x00045C87
			[Register("teardown", "()V", "GetTeardownHandler")]
			public virtual void Teardown()
			{
				UriLoader.FileDescriptorFactory._members.InstanceMethods.InvokeVirtualVoidMethod("teardown.()V", this, null);
			}

			// Token: 0x0600170A RID: 5898 RVA: 0x00047AA0 File Offset: 0x00045CA0
			IModelLoader IModelLoaderFactory.Build(MultiModelLoaderFactory p0)
			{
				return this.Build(p0).JavaCast<IModelLoader>();
			}

			// Token: 0x0600170B RID: 5899 RVA: 0x00047AAE File Offset: 0x00045CAE
			IDataFetcher UriLoader.ILocalUriFetcherFactory.Build(Android.Net.Uri p0)
			{
				return this.Build(p0).JavaCast<IDataFetcher>();
			}

			// Token: 0x0400057E RID: 1406
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/model/UriLoader$FileDescriptorFactory", typeof(UriLoader.FileDescriptorFactory));

			// Token: 0x0400057F RID: 1407
			private static Delegate cb_build_Landroid_net_Uri_;

			// Token: 0x04000580 RID: 1408
			private static Delegate cb_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_;

			// Token: 0x04000581 RID: 1409
			private static Delegate cb_teardown;
		}

		// Token: 0x020001E3 RID: 483
		[Register("com/bumptech/glide/load/model/UriLoader$LocalUriFetcherFactory", "", "Bumptech.Glide.Load.Model.UriLoader/ILocalUriFetcherFactoryInvoker")]
		[JavaTypeParameters(new string[]
		{
			"Data"
		})]
		public interface ILocalUriFetcherFactory : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x0600170D RID: 5901
			[Register("build", "(Landroid/net/Uri;)Lcom/bumptech/glide/load/data/DataFetcher;", "GetBuild_Landroid_net_Uri_Handler:Bumptech.Glide.Load.Model.UriLoader/ILocalUriFetcherFactoryInvoker, Xamarin.Android.Glide")]
			IDataFetcher Build(Android.Net.Uri p0);
		}

		// Token: 0x020001E4 RID: 484
		[Register("com/bumptech/glide/load/model/UriLoader$LocalUriFetcherFactory", DoNotGenerateAcw = true)]
		internal class ILocalUriFetcherFactoryInvoker : Java.Lang.Object, UriLoader.ILocalUriFetcherFactory, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000647 RID: 1607
			// (get) Token: 0x0600170E RID: 5902 RVA: 0x00047AD8 File Offset: 0x00045CD8
			private static IntPtr java_class_ref
			{
				get
				{
					return UriLoader.ILocalUriFetcherFactoryInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000648 RID: 1608
			// (get) Token: 0x0600170F RID: 5903 RVA: 0x00047AFC File Offset: 0x00045CFC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return UriLoader.ILocalUriFetcherFactoryInvoker._members;
				}
			}

			// Token: 0x17000649 RID: 1609
			// (get) Token: 0x06001710 RID: 5904 RVA: 0x00047B03 File Offset: 0x00045D03
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x1700064A RID: 1610
			// (get) Token: 0x06001711 RID: 5905 RVA: 0x00047B0B File Offset: 0x00045D0B
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return UriLoader.ILocalUriFetcherFactoryInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06001712 RID: 5906 RVA: 0x00047B17 File Offset: 0x00045D17
			public static UriLoader.ILocalUriFetcherFactory GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<UriLoader.ILocalUriFetcherFactory>(handle, transfer);
			}

			// Token: 0x06001713 RID: 5907 RVA: 0x00047B20 File Offset: 0x00045D20
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, UriLoader.ILocalUriFetcherFactoryInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.bumptech.glide.load.model.UriLoader.LocalUriFetcherFactory'.");
				}
				return handle;
			}

			// Token: 0x06001714 RID: 5908 RVA: 0x00047B4B File Offset: 0x00045D4B
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06001715 RID: 5909 RVA: 0x00047B7C File Offset: 0x00045D7C
			public ILocalUriFetcherFactoryInvoker(IntPtr handle, JniHandleOwnership transfer) : base(UriLoader.ILocalUriFetcherFactoryInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x06001716 RID: 5910 RVA: 0x00047BB4 File Offset: 0x00045DB4
			private static Delegate GetBuild_Landroid_net_Uri_Handler()
			{
				if (UriLoader.ILocalUriFetcherFactoryInvoker.cb_build_Landroid_net_Uri_ == null)
				{
					UriLoader.ILocalUriFetcherFactoryInvoker.cb_build_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(UriLoader.ILocalUriFetcherFactoryInvoker.n_Build_Landroid_net_Uri_));
				}
				return UriLoader.ILocalUriFetcherFactoryInvoker.cb_build_Landroid_net_Uri_;
			}

			// Token: 0x06001717 RID: 5911 RVA: 0x00047BD8 File Offset: 0x00045DD8
			private static IntPtr n_Build_Landroid_net_Uri_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				UriLoader.ILocalUriFetcherFactory @object = Java.Lang.Object.GetObject<UriLoader.ILocalUriFetcherFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Android.Net.Uri object2 = Java.Lang.Object.GetObject<Android.Net.Uri>(native_p0, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.Build(object2));
			}

			// Token: 0x06001718 RID: 5912 RVA: 0x00047C00 File Offset: 0x00045E00
			public unsafe IDataFetcher Build(Android.Net.Uri p0)
			{
				if (this.id_build_Landroid_net_Uri_ == IntPtr.Zero)
				{
					this.id_build_Landroid_net_Uri_ = JNIEnv.GetMethodID(this.class_ref, "build", "(Landroid/net/Uri;)Lcom/bumptech/glide/load/data/DataFetcher;");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				return Java.Lang.Object.GetObject<IDataFetcher>(JNIEnv.CallObjectMethod(base.Handle, this.id_build_Landroid_net_Uri_, ptr), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x04000582 RID: 1410
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/model/UriLoader$LocalUriFetcherFactory", typeof(UriLoader.ILocalUriFetcherFactoryInvoker));

			// Token: 0x04000583 RID: 1411
			private IntPtr class_ref;

			// Token: 0x04000584 RID: 1412
			private static Delegate cb_build_Landroid_net_Uri_;

			// Token: 0x04000585 RID: 1413
			private IntPtr id_build_Landroid_net_Uri_;
		}

		// Token: 0x020001E5 RID: 485
		[Register("com/bumptech/glide/load/model/UriLoader$StreamFactory", DoNotGenerateAcw = true)]
		public class StreamFactory : Java.Lang.Object, IModelLoaderFactory, IJavaObject, IDisposable, IJavaPeerable, UriLoader.ILocalUriFetcherFactory
		{
			// Token: 0x1700064B RID: 1611
			// (get) Token: 0x0600171A RID: 5914 RVA: 0x00047C94 File Offset: 0x00045E94
			internal static IntPtr class_ref
			{
				get
				{
					return UriLoader.StreamFactory._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700064C RID: 1612
			// (get) Token: 0x0600171B RID: 5915 RVA: 0x00047CB8 File Offset: 0x00045EB8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return UriLoader.StreamFactory._members;
				}
			}

			// Token: 0x1700064D RID: 1613
			// (get) Token: 0x0600171C RID: 5916 RVA: 0x00047CC0 File Offset: 0x00045EC0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return UriLoader.StreamFactory._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700064E RID: 1614
			// (get) Token: 0x0600171D RID: 5917 RVA: 0x00047CE4 File Offset: 0x00045EE4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return UriLoader.StreamFactory._members.ManagedPeerType;
				}
			}

			// Token: 0x0600171E RID: 5918 RVA: 0x00047CF0 File Offset: 0x00045EF0
			protected StreamFactory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x0600171F RID: 5919 RVA: 0x00047CFC File Offset: 0x00045EFC
			[Register(".ctor", "(Landroid/content/ContentResolver;)V", "")]
			public unsafe StreamFactory(ContentResolver contentResolver) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((contentResolver == null) ? IntPtr.Zero : contentResolver.Handle);
					base.SetHandle(UriLoader.StreamFactory._members.InstanceMethods.StartCreateInstance("(Landroid/content/ContentResolver;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					UriLoader.StreamFactory._members.InstanceMethods.FinishCreateInstance("(Landroid/content/ContentResolver;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(contentResolver);
				}
			}

			// Token: 0x06001720 RID: 5920 RVA: 0x00047DAC File Offset: 0x00045FAC
			private static Delegate GetBuild_Landroid_net_Uri_Handler()
			{
				if (UriLoader.StreamFactory.cb_build_Landroid_net_Uri_ == null)
				{
					UriLoader.StreamFactory.cb_build_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(UriLoader.StreamFactory.n_Build_Landroid_net_Uri_));
				}
				return UriLoader.StreamFactory.cb_build_Landroid_net_Uri_;
			}

			// Token: 0x06001721 RID: 5921 RVA: 0x00047DD0 File Offset: 0x00045FD0
			private static IntPtr n_Build_Landroid_net_Uri_(IntPtr jnienv, IntPtr native__this, IntPtr native_uri)
			{
				UriLoader.StreamFactory @object = Java.Lang.Object.GetObject<UriLoader.StreamFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Android.Net.Uri object2 = Java.Lang.Object.GetObject<Android.Net.Uri>(native_uri, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.Build(object2));
			}

			// Token: 0x06001722 RID: 5922 RVA: 0x00047DF8 File Offset: 0x00045FF8
			[Register("build", "(Landroid/net/Uri;)Lcom/bumptech/glide/load/data/DataFetcher;", "GetBuild_Landroid_net_Uri_Handler")]
			public unsafe virtual IDataFetcher Build(Android.Net.Uri uri)
			{
				IDataFetcher @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((uri == null) ? IntPtr.Zero : uri.Handle);
					@object = Java.Lang.Object.GetObject<IDataFetcher>(UriLoader.StreamFactory._members.InstanceMethods.InvokeVirtualObjectMethod("build.(Landroid/net/Uri;)Lcom/bumptech/glide/load/data/DataFetcher;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(uri);
				}
				return @object;
			}

			// Token: 0x06001723 RID: 5923 RVA: 0x00047E6C File Offset: 0x0004606C
			private static Delegate GetBuild_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_Handler()
			{
				if (UriLoader.StreamFactory.cb_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_ == null)
				{
					UriLoader.StreamFactory.cb_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(UriLoader.StreamFactory.n_Build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_));
				}
				return UriLoader.StreamFactory.cb_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_;
			}

			// Token: 0x06001724 RID: 5924 RVA: 0x00047E90 File Offset: 0x00046090
			private static IntPtr n_Build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_(IntPtr jnienv, IntPtr native__this, IntPtr native_multiFactory)
			{
				UriLoader.StreamFactory @object = Java.Lang.Object.GetObject<UriLoader.StreamFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				MultiModelLoaderFactory object2 = Java.Lang.Object.GetObject<MultiModelLoaderFactory>(native_multiFactory, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.Build(object2));
			}

			// Token: 0x06001725 RID: 5925 RVA: 0x00047EB8 File Offset: 0x000460B8
			[Register("build", "(Lcom/bumptech/glide/load/model/MultiModelLoaderFactory;)Lcom/bumptech/glide/load/model/ModelLoader;", "GetBuild_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_Handler")]
			public unsafe virtual IModelLoader Build(MultiModelLoaderFactory multiFactory)
			{
				IModelLoader @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((multiFactory == null) ? IntPtr.Zero : multiFactory.Handle);
					@object = Java.Lang.Object.GetObject<IModelLoader>(UriLoader.StreamFactory._members.InstanceMethods.InvokeVirtualObjectMethod("build.(Lcom/bumptech/glide/load/model/MultiModelLoaderFactory;)Lcom/bumptech/glide/load/model/ModelLoader;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(multiFactory);
				}
				return @object;
			}

			// Token: 0x06001726 RID: 5926 RVA: 0x00047F2C File Offset: 0x0004612C
			private static Delegate GetTeardownHandler()
			{
				if (UriLoader.StreamFactory.cb_teardown == null)
				{
					UriLoader.StreamFactory.cb_teardown = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(UriLoader.StreamFactory.n_Teardown));
				}
				return UriLoader.StreamFactory.cb_teardown;
			}

			// Token: 0x06001727 RID: 5927 RVA: 0x00047F50 File Offset: 0x00046150
			private static void n_Teardown(IntPtr jnienv, IntPtr native__this)
			{
				Java.Lang.Object.GetObject<UriLoader.StreamFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Teardown();
			}

			// Token: 0x06001728 RID: 5928 RVA: 0x00047F5F File Offset: 0x0004615F
			[Register("teardown", "()V", "GetTeardownHandler")]
			public virtual void Teardown()
			{
				UriLoader.StreamFactory._members.InstanceMethods.InvokeVirtualVoidMethod("teardown.()V", this, null);
			}

			// Token: 0x06001729 RID: 5929 RVA: 0x00047F78 File Offset: 0x00046178
			IModelLoader IModelLoaderFactory.Build(MultiModelLoaderFactory p0)
			{
				return this.Build(p0).JavaCast<IModelLoader>();
			}

			// Token: 0x0600172A RID: 5930 RVA: 0x00047F86 File Offset: 0x00046186
			IDataFetcher UriLoader.ILocalUriFetcherFactory.Build(Android.Net.Uri p0)
			{
				return this.Build(p0).JavaCast<IDataFetcher>();
			}

			// Token: 0x04000586 RID: 1414
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/model/UriLoader$StreamFactory", typeof(UriLoader.StreamFactory));

			// Token: 0x04000587 RID: 1415
			private static Delegate cb_build_Landroid_net_Uri_;

			// Token: 0x04000588 RID: 1416
			private static Delegate cb_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_;

			// Token: 0x04000589 RID: 1417
			private static Delegate cb_teardown;
		}
	}
}
