using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Net;

namespace Bumptech.Glide.Load.Model.Stream
{
	// Token: 0x0200014E RID: 334
	[Register("com/bumptech/glide/load/model/stream/UrlLoader", DoNotGenerateAcw = true)]
	public class UrlLoader : Java.Lang.Object, IModelLoader, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x060010D6 RID: 4310 RVA: 0x000366FC File Offset: 0x000348FC
		internal static IntPtr class_ref
		{
			get
			{
				return UrlLoader._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x060010D7 RID: 4311 RVA: 0x00036720 File Offset: 0x00034920
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return UrlLoader._members;
			}
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x060010D8 RID: 4312 RVA: 0x00036728 File Offset: 0x00034928
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return UrlLoader._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x060010D9 RID: 4313 RVA: 0x0003674C File Offset: 0x0003494C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return UrlLoader._members.ManagedPeerType;
			}
		}

		// Token: 0x060010DA RID: 4314 RVA: 0x00036758 File Offset: 0x00034958
		protected UrlLoader(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060010DB RID: 4315 RVA: 0x00036764 File Offset: 0x00034964
		[Register(".ctor", "(Lcom/bumptech/glide/load/model/ModelLoader;)V", "")]
		public unsafe UrlLoader(IModelLoader glideUrlLoader) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((glideUrlLoader == null) ? IntPtr.Zero : ((Java.Lang.Object)glideUrlLoader).Handle);
				base.SetHandle(UrlLoader._members.InstanceMethods.StartCreateInstance("(Lcom/bumptech/glide/load/model/ModelLoader;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				UrlLoader._members.InstanceMethods.FinishCreateInstance("(Lcom/bumptech/glide/load/model/ModelLoader;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(glideUrlLoader);
			}
		}

		// Token: 0x060010DC RID: 4316 RVA: 0x00036818 File Offset: 0x00034A18
		private static Delegate GetBuildLoadData_Ljava_net_URL_IILcom_bumptech_glide_load_Options_Handler()
		{
			if (UrlLoader.cb_buildLoadData_Ljava_net_URL_IILcom_bumptech_glide_load_Options_ == null)
			{
				UrlLoader.cb_buildLoadData_Ljava_net_URL_IILcom_bumptech_glide_load_Options_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIIL_L(UrlLoader.n_BuildLoadData_Ljava_net_URL_IILcom_bumptech_glide_load_Options_));
			}
			return UrlLoader.cb_buildLoadData_Ljava_net_URL_IILcom_bumptech_glide_load_Options_;
		}

		// Token: 0x060010DD RID: 4317 RVA: 0x0003683C File Offset: 0x00034A3C
		private static IntPtr n_BuildLoadData_Ljava_net_URL_IILcom_bumptech_glide_load_Options_(IntPtr jnienv, IntPtr native__this, IntPtr native_model, int width, int height, IntPtr native_options)
		{
			UrlLoader @object = Java.Lang.Object.GetObject<UrlLoader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			URL object2 = Java.Lang.Object.GetObject<URL>(native_model, JniHandleOwnership.DoNotTransfer);
			Options object3 = Java.Lang.Object.GetObject<Options>(native_options, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.BuildLoadData(object2, width, height, object3));
		}

		// Token: 0x060010DE RID: 4318 RVA: 0x00036874 File Offset: 0x00034A74
		[Register("buildLoadData", "(Ljava/net/URL;IILcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/model/ModelLoader$LoadData;", "GetBuildLoadData_Ljava_net_URL_IILcom_bumptech_glide_load_Options_Handler")]
		public unsafe virtual ModelLoaderLoadData BuildLoadData(URL model, int width, int height, Options options)
		{
			ModelLoaderLoadData @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((model == null) ? IntPtr.Zero : model.Handle);
				ptr[1] = new JniArgumentValue(width);
				ptr[2] = new JniArgumentValue(height);
				ptr[3] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				@object = Java.Lang.Object.GetObject<ModelLoaderLoadData>(UrlLoader._members.InstanceMethods.InvokeVirtualObjectMethod("buildLoadData.(Ljava/net/URL;IILcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/model/ModelLoader$LoadData;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(model);
				GC.KeepAlive(options);
			}
			return @object;
		}

		// Token: 0x060010DF RID: 4319 RVA: 0x00036940 File Offset: 0x00034B40
		private static Delegate GetHandles_Ljava_net_URL_Handler()
		{
			if (UrlLoader.cb_handles_Ljava_net_URL_ == null)
			{
				UrlLoader.cb_handles_Ljava_net_URL_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(UrlLoader.n_Handles_Ljava_net_URL_));
			}
			return UrlLoader.cb_handles_Ljava_net_URL_;
		}

		// Token: 0x060010E0 RID: 4320 RVA: 0x00036964 File Offset: 0x00034B64
		private static bool n_Handles_Ljava_net_URL_(IntPtr jnienv, IntPtr native__this, IntPtr native_model)
		{
			UrlLoader @object = Java.Lang.Object.GetObject<UrlLoader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			URL object2 = Java.Lang.Object.GetObject<URL>(native_model, JniHandleOwnership.DoNotTransfer);
			return @object.Handles(object2);
		}

		// Token: 0x060010E1 RID: 4321 RVA: 0x00036988 File Offset: 0x00034B88
		[Register("handles", "(Ljava/net/URL;)Z", "GetHandles_Ljava_net_URL_Handler")]
		public unsafe virtual bool Handles(URL model)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((model == null) ? IntPtr.Zero : model.Handle);
				result = UrlLoader._members.InstanceMethods.InvokeVirtualBooleanMethod("handles.(Ljava/net/URL;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(model);
			}
			return result;
		}

		// Token: 0x060010E2 RID: 4322 RVA: 0x000369F0 File Offset: 0x00034BF0
		ModelLoaderLoadData IModelLoader.BuildLoadData(Java.Lang.Object p0, int p1, int p2, Options p3)
		{
			return this.BuildLoadData(p0.JavaCast<URL>(), p1, p2, p3).JavaCast<ModelLoaderLoadData>();
		}

		// Token: 0x060010E3 RID: 4323 RVA: 0x00036A07 File Offset: 0x00034C07
		bool IModelLoader.Handles(Java.Lang.Object p0)
		{
			return this.Handles(p0.JavaCast<URL>());
		}

		// Token: 0x040003DF RID: 991
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/model/stream/UrlLoader", typeof(UrlLoader));

		// Token: 0x040003E0 RID: 992
		private static Delegate cb_buildLoadData_Ljava_net_URL_IILcom_bumptech_glide_load_Options_;

		// Token: 0x040003E1 RID: 993
		private static Delegate cb_handles_Ljava_net_URL_;

		// Token: 0x020001F4 RID: 500
		[Register("com/bumptech/glide/load/model/stream/UrlLoader$StreamFactory", DoNotGenerateAcw = true)]
		public class StreamFactory : Java.Lang.Object, IModelLoaderFactory, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000681 RID: 1665
			// (get) Token: 0x060017BE RID: 6078 RVA: 0x00049804 File Offset: 0x00047A04
			internal static IntPtr class_ref
			{
				get
				{
					return UrlLoader.StreamFactory._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000682 RID: 1666
			// (get) Token: 0x060017BF RID: 6079 RVA: 0x00049828 File Offset: 0x00047A28
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return UrlLoader.StreamFactory._members;
				}
			}

			// Token: 0x17000683 RID: 1667
			// (get) Token: 0x060017C0 RID: 6080 RVA: 0x00049830 File Offset: 0x00047A30
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return UrlLoader.StreamFactory._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000684 RID: 1668
			// (get) Token: 0x060017C1 RID: 6081 RVA: 0x00049854 File Offset: 0x00047A54
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return UrlLoader.StreamFactory._members.ManagedPeerType;
				}
			}

			// Token: 0x060017C2 RID: 6082 RVA: 0x00049860 File Offset: 0x00047A60
			protected StreamFactory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x060017C3 RID: 6083 RVA: 0x0004986C File Offset: 0x00047A6C
			[Register(".ctor", "()V", "")]
			public StreamFactory() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(UrlLoader.StreamFactory._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				UrlLoader.StreamFactory._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x060017C4 RID: 6084 RVA: 0x000498DA File Offset: 0x00047ADA
			private static Delegate GetBuild_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_Handler()
			{
				if (UrlLoader.StreamFactory.cb_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_ == null)
				{
					UrlLoader.StreamFactory.cb_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(UrlLoader.StreamFactory.n_Build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_));
				}
				return UrlLoader.StreamFactory.cb_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_;
			}

			// Token: 0x060017C5 RID: 6085 RVA: 0x00049900 File Offset: 0x00047B00
			private static IntPtr n_Build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_(IntPtr jnienv, IntPtr native__this, IntPtr native_multiFactory)
			{
				UrlLoader.StreamFactory @object = Java.Lang.Object.GetObject<UrlLoader.StreamFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				MultiModelLoaderFactory object2 = Java.Lang.Object.GetObject<MultiModelLoaderFactory>(native_multiFactory, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.Build(object2));
			}

			// Token: 0x060017C6 RID: 6086 RVA: 0x00049928 File Offset: 0x00047B28
			[Register("build", "(Lcom/bumptech/glide/load/model/MultiModelLoaderFactory;)Lcom/bumptech/glide/load/model/ModelLoader;", "GetBuild_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_Handler")]
			public unsafe virtual IModelLoader Build(MultiModelLoaderFactory multiFactory)
			{
				IModelLoader @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((multiFactory == null) ? IntPtr.Zero : multiFactory.Handle);
					@object = Java.Lang.Object.GetObject<IModelLoader>(UrlLoader.StreamFactory._members.InstanceMethods.InvokeVirtualObjectMethod("build.(Lcom/bumptech/glide/load/model/MultiModelLoaderFactory;)Lcom/bumptech/glide/load/model/ModelLoader;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(multiFactory);
				}
				return @object;
			}

			// Token: 0x060017C7 RID: 6087 RVA: 0x0004999C File Offset: 0x00047B9C
			private static Delegate GetTeardownHandler()
			{
				if (UrlLoader.StreamFactory.cb_teardown == null)
				{
					UrlLoader.StreamFactory.cb_teardown = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(UrlLoader.StreamFactory.n_Teardown));
				}
				return UrlLoader.StreamFactory.cb_teardown;
			}

			// Token: 0x060017C8 RID: 6088 RVA: 0x000499C0 File Offset: 0x00047BC0
			private static void n_Teardown(IntPtr jnienv, IntPtr native__this)
			{
				Java.Lang.Object.GetObject<UrlLoader.StreamFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Teardown();
			}

			// Token: 0x060017C9 RID: 6089 RVA: 0x000499CF File Offset: 0x00047BCF
			[Register("teardown", "()V", "GetTeardownHandler")]
			public virtual void Teardown()
			{
				UrlLoader.StreamFactory._members.InstanceMethods.InvokeVirtualVoidMethod("teardown.()V", this, null);
			}

			// Token: 0x060017CA RID: 6090 RVA: 0x000499E8 File Offset: 0x00047BE8
			IModelLoader IModelLoaderFactory.Build(MultiModelLoaderFactory p0)
			{
				return this.Build(p0).JavaCast<IModelLoader>();
			}

			// Token: 0x040005A9 RID: 1449
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/model/stream/UrlLoader$StreamFactory", typeof(UrlLoader.StreamFactory));

			// Token: 0x040005AA RID: 1450
			private static Delegate cb_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_;

			// Token: 0x040005AB RID: 1451
			private static Delegate cb_teardown;
		}
	}
}
