using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Net;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Model
{
	// Token: 0x0200012C RID: 300
	[Register("com/bumptech/glide/load/model/UrlUriLoader", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"Data"
	})]
	public class UrlUriLoader : Java.Lang.Object, IModelLoader, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000F59 RID: 3929 RVA: 0x0003171F File Offset: 0x0002F91F
		public virtual ModelLoaderLoadData BuildLoadData(Java.Lang.Object model, int width, int height, Options options)
		{
			return this.BuildLoadData((Android.Net.Uri)model, width, height, options);
		}

		// Token: 0x06000F5A RID: 3930 RVA: 0x00031731 File Offset: 0x0002F931
		public virtual bool Handles(Java.Lang.Object model)
		{
			return this.Handles((Android.Net.Uri)model);
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06000F5B RID: 3931 RVA: 0x00031740 File Offset: 0x0002F940
		internal static IntPtr class_ref
		{
			get
			{
				return UrlUriLoader._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06000F5C RID: 3932 RVA: 0x00031764 File Offset: 0x0002F964
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return UrlUriLoader._members;
			}
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06000F5D RID: 3933 RVA: 0x0003176C File Offset: 0x0002F96C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return UrlUriLoader._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06000F5E RID: 3934 RVA: 0x00031790 File Offset: 0x0002F990
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return UrlUriLoader._members.ManagedPeerType;
			}
		}

		// Token: 0x06000F5F RID: 3935 RVA: 0x0003179C File Offset: 0x0002F99C
		protected UrlUriLoader(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000F60 RID: 3936 RVA: 0x000317A8 File Offset: 0x0002F9A8
		[Register(".ctor", "(Lcom/bumptech/glide/load/model/ModelLoader;)V", "")]
		public unsafe UrlUriLoader(IModelLoader urlLoader) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((urlLoader == null) ? IntPtr.Zero : ((Java.Lang.Object)urlLoader).Handle);
				base.SetHandle(UrlUriLoader._members.InstanceMethods.StartCreateInstance("(Lcom/bumptech/glide/load/model/ModelLoader;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				UrlUriLoader._members.InstanceMethods.FinishCreateInstance("(Lcom/bumptech/glide/load/model/ModelLoader;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(urlLoader);
			}
		}

		// Token: 0x06000F61 RID: 3937 RVA: 0x0003185C File Offset: 0x0002FA5C
		private static Delegate GetBuildLoadData_Landroid_net_Uri_IILcom_bumptech_glide_load_Options_Handler()
		{
			if (UrlUriLoader.cb_buildLoadData_Landroid_net_Uri_IILcom_bumptech_glide_load_Options_ == null)
			{
				UrlUriLoader.cb_buildLoadData_Landroid_net_Uri_IILcom_bumptech_glide_load_Options_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIIL_L(UrlUriLoader.n_BuildLoadData_Landroid_net_Uri_IILcom_bumptech_glide_load_Options_));
			}
			return UrlUriLoader.cb_buildLoadData_Landroid_net_Uri_IILcom_bumptech_glide_load_Options_;
		}

		// Token: 0x06000F62 RID: 3938 RVA: 0x00031880 File Offset: 0x0002FA80
		private static IntPtr n_BuildLoadData_Landroid_net_Uri_IILcom_bumptech_glide_load_Options_(IntPtr jnienv, IntPtr native__this, IntPtr native_uri, int width, int height, IntPtr native_options)
		{
			UrlUriLoader @object = Java.Lang.Object.GetObject<UrlUriLoader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Android.Net.Uri object2 = Java.Lang.Object.GetObject<Android.Net.Uri>(native_uri, JniHandleOwnership.DoNotTransfer);
			Options object3 = Java.Lang.Object.GetObject<Options>(native_options, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.BuildLoadData(object2, width, height, object3));
		}

		// Token: 0x06000F63 RID: 3939 RVA: 0x000318B8 File Offset: 0x0002FAB8
		[Register("buildLoadData", "(Landroid/net/Uri;IILcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/model/ModelLoader$LoadData;", "GetBuildLoadData_Landroid_net_Uri_IILcom_bumptech_glide_load_Options_Handler")]
		public unsafe virtual ModelLoaderLoadData BuildLoadData(Android.Net.Uri uri, int width, int height, Options options)
		{
			ModelLoaderLoadData @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((uri == null) ? IntPtr.Zero : uri.Handle);
				ptr[1] = new JniArgumentValue(width);
				ptr[2] = new JniArgumentValue(height);
				ptr[3] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				@object = Java.Lang.Object.GetObject<ModelLoaderLoadData>(UrlUriLoader._members.InstanceMethods.InvokeVirtualObjectMethod("buildLoadData.(Landroid/net/Uri;IILcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/model/ModelLoader$LoadData;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(uri);
				GC.KeepAlive(options);
			}
			return @object;
		}

		// Token: 0x06000F64 RID: 3940 RVA: 0x00031984 File Offset: 0x0002FB84
		private static Delegate GetHandles_Landroid_net_Uri_Handler()
		{
			if (UrlUriLoader.cb_handles_Landroid_net_Uri_ == null)
			{
				UrlUriLoader.cb_handles_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(UrlUriLoader.n_Handles_Landroid_net_Uri_));
			}
			return UrlUriLoader.cb_handles_Landroid_net_Uri_;
		}

		// Token: 0x06000F65 RID: 3941 RVA: 0x000319A8 File Offset: 0x0002FBA8
		private static bool n_Handles_Landroid_net_Uri_(IntPtr jnienv, IntPtr native__this, IntPtr native_uri)
		{
			UrlUriLoader @object = Java.Lang.Object.GetObject<UrlUriLoader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Android.Net.Uri object2 = Java.Lang.Object.GetObject<Android.Net.Uri>(native_uri, JniHandleOwnership.DoNotTransfer);
			return @object.Handles(object2);
		}

		// Token: 0x06000F66 RID: 3942 RVA: 0x000319CC File Offset: 0x0002FBCC
		[Register("handles", "(Landroid/net/Uri;)Z", "GetHandles_Landroid_net_Uri_Handler")]
		public unsafe virtual bool Handles(Android.Net.Uri uri)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((uri == null) ? IntPtr.Zero : uri.Handle);
				result = UrlUriLoader._members.InstanceMethods.InvokeVirtualBooleanMethod("handles.(Landroid/net/Uri;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(uri);
			}
			return result;
		}

		// Token: 0x0400038C RID: 908
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/model/UrlUriLoader", typeof(UrlUriLoader));

		// Token: 0x0400038D RID: 909
		private static Delegate cb_buildLoadData_Landroid_net_Uri_IILcom_bumptech_glide_load_Options_;

		// Token: 0x0400038E RID: 910
		private static Delegate cb_handles_Landroid_net_Uri_;

		// Token: 0x020001E6 RID: 486
		[Register("com/bumptech/glide/load/model/UrlUriLoader$StreamFactory", DoNotGenerateAcw = true)]
		public class StreamFactory : Java.Lang.Object, IModelLoaderFactory, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x1700064F RID: 1615
			// (get) Token: 0x0600172C RID: 5932 RVA: 0x00047FB0 File Offset: 0x000461B0
			internal static IntPtr class_ref
			{
				get
				{
					return UrlUriLoader.StreamFactory._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000650 RID: 1616
			// (get) Token: 0x0600172D RID: 5933 RVA: 0x00047FD4 File Offset: 0x000461D4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return UrlUriLoader.StreamFactory._members;
				}
			}

			// Token: 0x17000651 RID: 1617
			// (get) Token: 0x0600172E RID: 5934 RVA: 0x00047FDC File Offset: 0x000461DC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return UrlUriLoader.StreamFactory._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000652 RID: 1618
			// (get) Token: 0x0600172F RID: 5935 RVA: 0x00048000 File Offset: 0x00046200
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return UrlUriLoader.StreamFactory._members.ManagedPeerType;
				}
			}

			// Token: 0x06001730 RID: 5936 RVA: 0x0004800C File Offset: 0x0004620C
			protected StreamFactory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06001731 RID: 5937 RVA: 0x00048018 File Offset: 0x00046218
			[Register(".ctor", "()V", "")]
			public StreamFactory() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(UrlUriLoader.StreamFactory._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				UrlUriLoader.StreamFactory._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x06001732 RID: 5938 RVA: 0x00048086 File Offset: 0x00046286
			private static Delegate GetBuild_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_Handler()
			{
				if (UrlUriLoader.StreamFactory.cb_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_ == null)
				{
					UrlUriLoader.StreamFactory.cb_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(UrlUriLoader.StreamFactory.n_Build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_));
				}
				return UrlUriLoader.StreamFactory.cb_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_;
			}

			// Token: 0x06001733 RID: 5939 RVA: 0x000480AC File Offset: 0x000462AC
			private static IntPtr n_Build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_(IntPtr jnienv, IntPtr native__this, IntPtr native_multiFactory)
			{
				UrlUriLoader.StreamFactory @object = Java.Lang.Object.GetObject<UrlUriLoader.StreamFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				MultiModelLoaderFactory object2 = Java.Lang.Object.GetObject<MultiModelLoaderFactory>(native_multiFactory, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.Build(object2));
			}

			// Token: 0x06001734 RID: 5940 RVA: 0x000480D4 File Offset: 0x000462D4
			[Register("build", "(Lcom/bumptech/glide/load/model/MultiModelLoaderFactory;)Lcom/bumptech/glide/load/model/ModelLoader;", "GetBuild_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_Handler")]
			public unsafe virtual IModelLoader Build(MultiModelLoaderFactory multiFactory)
			{
				IModelLoader @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((multiFactory == null) ? IntPtr.Zero : multiFactory.Handle);
					@object = Java.Lang.Object.GetObject<IModelLoader>(UrlUriLoader.StreamFactory._members.InstanceMethods.InvokeVirtualObjectMethod("build.(Lcom/bumptech/glide/load/model/MultiModelLoaderFactory;)Lcom/bumptech/glide/load/model/ModelLoader;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(multiFactory);
				}
				return @object;
			}

			// Token: 0x06001735 RID: 5941 RVA: 0x00048148 File Offset: 0x00046348
			private static Delegate GetTeardownHandler()
			{
				if (UrlUriLoader.StreamFactory.cb_teardown == null)
				{
					UrlUriLoader.StreamFactory.cb_teardown = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(UrlUriLoader.StreamFactory.n_Teardown));
				}
				return UrlUriLoader.StreamFactory.cb_teardown;
			}

			// Token: 0x06001736 RID: 5942 RVA: 0x0004816C File Offset: 0x0004636C
			private static void n_Teardown(IntPtr jnienv, IntPtr native__this)
			{
				Java.Lang.Object.GetObject<UrlUriLoader.StreamFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Teardown();
			}

			// Token: 0x06001737 RID: 5943 RVA: 0x0004817B File Offset: 0x0004637B
			[Register("teardown", "()V", "GetTeardownHandler")]
			public virtual void Teardown()
			{
				UrlUriLoader.StreamFactory._members.InstanceMethods.InvokeVirtualVoidMethod("teardown.()V", this, null);
			}

			// Token: 0x06001738 RID: 5944 RVA: 0x00048194 File Offset: 0x00046394
			IModelLoader IModelLoaderFactory.Build(MultiModelLoaderFactory p0)
			{
				return this.Build(p0).JavaCast<IModelLoader>();
			}

			// Token: 0x0400058A RID: 1418
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/model/UrlUriLoader$StreamFactory", typeof(UrlUriLoader.StreamFactory));

			// Token: 0x0400058B RID: 1419
			private static Delegate cb_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_;

			// Token: 0x0400058C RID: 1420
			private static Delegate cb_teardown;
		}
	}
}
