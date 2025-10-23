using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Model.Stream
{
	// Token: 0x0200014A RID: 330
	[Register("com/bumptech/glide/load/model/stream/HttpGlideUrlLoader", DoNotGenerateAcw = true)]
	public class HttpGlideUrlLoader : Java.Lang.Object, IModelLoader, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x060010A0 RID: 4256 RVA: 0x00035B94 File Offset: 0x00033D94
		[Register("TIMEOUT")]
		public static Option Timeout
		{
			get
			{
				return Java.Lang.Object.GetObject<Option>(HttpGlideUrlLoader._members.StaticFields.GetObjectValue("TIMEOUT.Lcom/bumptech/glide/load/Option;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x060010A1 RID: 4257 RVA: 0x00035BC4 File Offset: 0x00033DC4
		internal static IntPtr class_ref
		{
			get
			{
				return HttpGlideUrlLoader._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x060010A2 RID: 4258 RVA: 0x00035BE8 File Offset: 0x00033DE8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return HttpGlideUrlLoader._members;
			}
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x060010A3 RID: 4259 RVA: 0x00035BF0 File Offset: 0x00033DF0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return HttpGlideUrlLoader._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x060010A4 RID: 4260 RVA: 0x00035C14 File Offset: 0x00033E14
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return HttpGlideUrlLoader._members.ManagedPeerType;
			}
		}

		// Token: 0x060010A5 RID: 4261 RVA: 0x00035C20 File Offset: 0x00033E20
		protected HttpGlideUrlLoader(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060010A6 RID: 4262 RVA: 0x00035C2C File Offset: 0x00033E2C
		[Register(".ctor", "()V", "")]
		public HttpGlideUrlLoader() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(HttpGlideUrlLoader._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			HttpGlideUrlLoader._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060010A7 RID: 4263 RVA: 0x00035C9C File Offset: 0x00033E9C
		[Register(".ctor", "(Lcom/bumptech/glide/load/model/ModelCache;)V", "")]
		public unsafe HttpGlideUrlLoader(ModelCache modelCache) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((modelCache == null) ? IntPtr.Zero : modelCache.Handle);
				base.SetHandle(HttpGlideUrlLoader._members.InstanceMethods.StartCreateInstance("(Lcom/bumptech/glide/load/model/ModelCache;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				HttpGlideUrlLoader._members.InstanceMethods.FinishCreateInstance("(Lcom/bumptech/glide/load/model/ModelCache;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(modelCache);
			}
		}

		// Token: 0x060010A8 RID: 4264 RVA: 0x00035D4C File Offset: 0x00033F4C
		private static Delegate GetBuildLoadData_Lcom_bumptech_glide_load_model_GlideUrl_IILcom_bumptech_glide_load_Options_Handler()
		{
			if (HttpGlideUrlLoader.cb_buildLoadData_Lcom_bumptech_glide_load_model_GlideUrl_IILcom_bumptech_glide_load_Options_ == null)
			{
				HttpGlideUrlLoader.cb_buildLoadData_Lcom_bumptech_glide_load_model_GlideUrl_IILcom_bumptech_glide_load_Options_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIIL_L(HttpGlideUrlLoader.n_BuildLoadData_Lcom_bumptech_glide_load_model_GlideUrl_IILcom_bumptech_glide_load_Options_));
			}
			return HttpGlideUrlLoader.cb_buildLoadData_Lcom_bumptech_glide_load_model_GlideUrl_IILcom_bumptech_glide_load_Options_;
		}

		// Token: 0x060010A9 RID: 4265 RVA: 0x00035D70 File Offset: 0x00033F70
		private static IntPtr n_BuildLoadData_Lcom_bumptech_glide_load_model_GlideUrl_IILcom_bumptech_glide_load_Options_(IntPtr jnienv, IntPtr native__this, IntPtr native_model, int width, int height, IntPtr native_options)
		{
			HttpGlideUrlLoader @object = Java.Lang.Object.GetObject<HttpGlideUrlLoader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			GlideUrl object2 = Java.Lang.Object.GetObject<GlideUrl>(native_model, JniHandleOwnership.DoNotTransfer);
			Options object3 = Java.Lang.Object.GetObject<Options>(native_options, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.BuildLoadData(object2, width, height, object3));
		}

		// Token: 0x060010AA RID: 4266 RVA: 0x00035DA8 File Offset: 0x00033FA8
		[Register("buildLoadData", "(Lcom/bumptech/glide/load/model/GlideUrl;IILcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/model/ModelLoader$LoadData;", "GetBuildLoadData_Lcom_bumptech_glide_load_model_GlideUrl_IILcom_bumptech_glide_load_Options_Handler")]
		public unsafe virtual ModelLoaderLoadData BuildLoadData(GlideUrl model, int width, int height, Options options)
		{
			ModelLoaderLoadData @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((model == null) ? IntPtr.Zero : model.Handle);
				ptr[1] = new JniArgumentValue(width);
				ptr[2] = new JniArgumentValue(height);
				ptr[3] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				@object = Java.Lang.Object.GetObject<ModelLoaderLoadData>(HttpGlideUrlLoader._members.InstanceMethods.InvokeVirtualObjectMethod("buildLoadData.(Lcom/bumptech/glide/load/model/GlideUrl;IILcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/model/ModelLoader$LoadData;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(model);
				GC.KeepAlive(options);
			}
			return @object;
		}

		// Token: 0x060010AB RID: 4267 RVA: 0x00035E74 File Offset: 0x00034074
		private static Delegate GetHandles_Lcom_bumptech_glide_load_model_GlideUrl_Handler()
		{
			if (HttpGlideUrlLoader.cb_handles_Lcom_bumptech_glide_load_model_GlideUrl_ == null)
			{
				HttpGlideUrlLoader.cb_handles_Lcom_bumptech_glide_load_model_GlideUrl_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(HttpGlideUrlLoader.n_Handles_Lcom_bumptech_glide_load_model_GlideUrl_));
			}
			return HttpGlideUrlLoader.cb_handles_Lcom_bumptech_glide_load_model_GlideUrl_;
		}

		// Token: 0x060010AC RID: 4268 RVA: 0x00035E98 File Offset: 0x00034098
		private static bool n_Handles_Lcom_bumptech_glide_load_model_GlideUrl_(IntPtr jnienv, IntPtr native__this, IntPtr native_model)
		{
			HttpGlideUrlLoader @object = Java.Lang.Object.GetObject<HttpGlideUrlLoader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			GlideUrl object2 = Java.Lang.Object.GetObject<GlideUrl>(native_model, JniHandleOwnership.DoNotTransfer);
			return @object.Handles(object2);
		}

		// Token: 0x060010AD RID: 4269 RVA: 0x00035EBC File Offset: 0x000340BC
		[Register("handles", "(Lcom/bumptech/glide/load/model/GlideUrl;)Z", "GetHandles_Lcom_bumptech_glide_load_model_GlideUrl_Handler")]
		public unsafe virtual bool Handles(GlideUrl model)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((model == null) ? IntPtr.Zero : model.Handle);
				result = HttpGlideUrlLoader._members.InstanceMethods.InvokeVirtualBooleanMethod("handles.(Lcom/bumptech/glide/load/model/GlideUrl;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(model);
			}
			return result;
		}

		// Token: 0x060010AE RID: 4270 RVA: 0x00035F24 File Offset: 0x00034124
		ModelLoaderLoadData IModelLoader.BuildLoadData(Java.Lang.Object p0, int p1, int p2, Options p3)
		{
			return this.BuildLoadData(p0.JavaCast<GlideUrl>(), p1, p2, p3).JavaCast<ModelLoaderLoadData>();
		}

		// Token: 0x060010AF RID: 4271 RVA: 0x00035F3B File Offset: 0x0003413B
		bool IModelLoader.Handles(Java.Lang.Object p0)
		{
			return this.Handles(p0.JavaCast<GlideUrl>());
		}

		// Token: 0x040003D5 RID: 981
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/model/stream/HttpGlideUrlLoader", typeof(HttpGlideUrlLoader));

		// Token: 0x040003D6 RID: 982
		private static Delegate cb_buildLoadData_Lcom_bumptech_glide_load_model_GlideUrl_IILcom_bumptech_glide_load_Options_;

		// Token: 0x040003D7 RID: 983
		private static Delegate cb_handles_Lcom_bumptech_glide_load_model_GlideUrl_;

		// Token: 0x020001F0 RID: 496
		[Register("com/bumptech/glide/load/model/stream/HttpGlideUrlLoader$Factory", DoNotGenerateAcw = true)]
		public class Factory : Java.Lang.Object, IModelLoaderFactory, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000671 RID: 1649
			// (get) Token: 0x0600178D RID: 6029 RVA: 0x00049060 File Offset: 0x00047260
			internal static IntPtr class_ref
			{
				get
				{
					return HttpGlideUrlLoader.Factory._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000672 RID: 1650
			// (get) Token: 0x0600178E RID: 6030 RVA: 0x00049084 File Offset: 0x00047284
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return HttpGlideUrlLoader.Factory._members;
				}
			}

			// Token: 0x17000673 RID: 1651
			// (get) Token: 0x0600178F RID: 6031 RVA: 0x0004908C File Offset: 0x0004728C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return HttpGlideUrlLoader.Factory._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000674 RID: 1652
			// (get) Token: 0x06001790 RID: 6032 RVA: 0x000490B0 File Offset: 0x000472B0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return HttpGlideUrlLoader.Factory._members.ManagedPeerType;
				}
			}

			// Token: 0x06001791 RID: 6033 RVA: 0x000490BC File Offset: 0x000472BC
			protected Factory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06001792 RID: 6034 RVA: 0x000490C8 File Offset: 0x000472C8
			[Register(".ctor", "()V", "")]
			public Factory() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(HttpGlideUrlLoader.Factory._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				HttpGlideUrlLoader.Factory._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x06001793 RID: 6035 RVA: 0x00049136 File Offset: 0x00047336
			private static Delegate GetBuild_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_Handler()
			{
				if (HttpGlideUrlLoader.Factory.cb_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_ == null)
				{
					HttpGlideUrlLoader.Factory.cb_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(HttpGlideUrlLoader.Factory.n_Build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_));
				}
				return HttpGlideUrlLoader.Factory.cb_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_;
			}

			// Token: 0x06001794 RID: 6036 RVA: 0x0004915C File Offset: 0x0004735C
			private static IntPtr n_Build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_(IntPtr jnienv, IntPtr native__this, IntPtr native_multiFactory)
			{
				HttpGlideUrlLoader.Factory @object = Java.Lang.Object.GetObject<HttpGlideUrlLoader.Factory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				MultiModelLoaderFactory object2 = Java.Lang.Object.GetObject<MultiModelLoaderFactory>(native_multiFactory, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.Build(object2));
			}

			// Token: 0x06001795 RID: 6037 RVA: 0x00049184 File Offset: 0x00047384
			[Register("build", "(Lcom/bumptech/glide/load/model/MultiModelLoaderFactory;)Lcom/bumptech/glide/load/model/ModelLoader;", "GetBuild_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_Handler")]
			public unsafe virtual IModelLoader Build(MultiModelLoaderFactory multiFactory)
			{
				IModelLoader @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((multiFactory == null) ? IntPtr.Zero : multiFactory.Handle);
					@object = Java.Lang.Object.GetObject<IModelLoader>(HttpGlideUrlLoader.Factory._members.InstanceMethods.InvokeVirtualObjectMethod("build.(Lcom/bumptech/glide/load/model/MultiModelLoaderFactory;)Lcom/bumptech/glide/load/model/ModelLoader;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(multiFactory);
				}
				return @object;
			}

			// Token: 0x06001796 RID: 6038 RVA: 0x000491F8 File Offset: 0x000473F8
			private static Delegate GetTeardownHandler()
			{
				if (HttpGlideUrlLoader.Factory.cb_teardown == null)
				{
					HttpGlideUrlLoader.Factory.cb_teardown = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(HttpGlideUrlLoader.Factory.n_Teardown));
				}
				return HttpGlideUrlLoader.Factory.cb_teardown;
			}

			// Token: 0x06001797 RID: 6039 RVA: 0x0004921C File Offset: 0x0004741C
			private static void n_Teardown(IntPtr jnienv, IntPtr native__this)
			{
				Java.Lang.Object.GetObject<HttpGlideUrlLoader.Factory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Teardown();
			}

			// Token: 0x06001798 RID: 6040 RVA: 0x0004922B File Offset: 0x0004742B
			[Register("teardown", "()V", "GetTeardownHandler")]
			public virtual void Teardown()
			{
				HttpGlideUrlLoader.Factory._members.InstanceMethods.InvokeVirtualVoidMethod("teardown.()V", this, null);
			}

			// Token: 0x06001799 RID: 6041 RVA: 0x00049244 File Offset: 0x00047444
			IModelLoader IModelLoaderFactory.Build(MultiModelLoaderFactory p0)
			{
				return this.Build(p0).JavaCast<IModelLoader>();
			}

			// Token: 0x0400059F RID: 1439
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/model/stream/HttpGlideUrlLoader$Factory", typeof(HttpGlideUrlLoader.Factory));

			// Token: 0x040005A0 RID: 1440
			private static Delegate cb_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_;

			// Token: 0x040005A1 RID: 1441
			private static Delegate cb_teardown;
		}
	}
}
