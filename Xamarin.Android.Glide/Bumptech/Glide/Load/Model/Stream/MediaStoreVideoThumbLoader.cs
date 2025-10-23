using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Net;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Model.Stream
{
	// Token: 0x0200014D RID: 333
	[Register("com/bumptech/glide/load/model/stream/MediaStoreVideoThumbLoader", DoNotGenerateAcw = true)]
	public class MediaStoreVideoThumbLoader : Java.Lang.Object, IModelLoader, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x060010C7 RID: 4295 RVA: 0x000363CC File Offset: 0x000345CC
		internal static IntPtr class_ref
		{
			get
			{
				return MediaStoreVideoThumbLoader._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x060010C8 RID: 4296 RVA: 0x000363F0 File Offset: 0x000345F0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MediaStoreVideoThumbLoader._members;
			}
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x060010C9 RID: 4297 RVA: 0x000363F8 File Offset: 0x000345F8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MediaStoreVideoThumbLoader._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x060010CA RID: 4298 RVA: 0x0003641C File Offset: 0x0003461C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MediaStoreVideoThumbLoader._members.ManagedPeerType;
			}
		}

		// Token: 0x060010CB RID: 4299 RVA: 0x00036428 File Offset: 0x00034628
		protected MediaStoreVideoThumbLoader(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060010CC RID: 4300 RVA: 0x00036434 File Offset: 0x00034634
		[Register(".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe MediaStoreVideoThumbLoader(Context context) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				base.SetHandle(MediaStoreVideoThumbLoader._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				MediaStoreVideoThumbLoader._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
		}

		// Token: 0x060010CD RID: 4301 RVA: 0x000364E4 File Offset: 0x000346E4
		private static Delegate GetBuildLoadData_Landroid_net_Uri_IILcom_bumptech_glide_load_Options_Handler()
		{
			if (MediaStoreVideoThumbLoader.cb_buildLoadData_Landroid_net_Uri_IILcom_bumptech_glide_load_Options_ == null)
			{
				MediaStoreVideoThumbLoader.cb_buildLoadData_Landroid_net_Uri_IILcom_bumptech_glide_load_Options_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIIL_L(MediaStoreVideoThumbLoader.n_BuildLoadData_Landroid_net_Uri_IILcom_bumptech_glide_load_Options_));
			}
			return MediaStoreVideoThumbLoader.cb_buildLoadData_Landroid_net_Uri_IILcom_bumptech_glide_load_Options_;
		}

		// Token: 0x060010CE RID: 4302 RVA: 0x00036508 File Offset: 0x00034708
		private static IntPtr n_BuildLoadData_Landroid_net_Uri_IILcom_bumptech_glide_load_Options_(IntPtr jnienv, IntPtr native__this, IntPtr native_model, int width, int height, IntPtr native_options)
		{
			MediaStoreVideoThumbLoader @object = Java.Lang.Object.GetObject<MediaStoreVideoThumbLoader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Android.Net.Uri object2 = Java.Lang.Object.GetObject<Android.Net.Uri>(native_model, JniHandleOwnership.DoNotTransfer);
			Options object3 = Java.Lang.Object.GetObject<Options>(native_options, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.BuildLoadData(object2, width, height, object3));
		}

		// Token: 0x060010CF RID: 4303 RVA: 0x00036540 File Offset: 0x00034740
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
				@object = Java.Lang.Object.GetObject<ModelLoaderLoadData>(MediaStoreVideoThumbLoader._members.InstanceMethods.InvokeVirtualObjectMethod("buildLoadData.(Landroid/net/Uri;IILcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/model/ModelLoader$LoadData;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(model);
				GC.KeepAlive(options);
			}
			return @object;
		}

		// Token: 0x060010D0 RID: 4304 RVA: 0x0003660C File Offset: 0x0003480C
		private static Delegate GetHandles_Landroid_net_Uri_Handler()
		{
			if (MediaStoreVideoThumbLoader.cb_handles_Landroid_net_Uri_ == null)
			{
				MediaStoreVideoThumbLoader.cb_handles_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(MediaStoreVideoThumbLoader.n_Handles_Landroid_net_Uri_));
			}
			return MediaStoreVideoThumbLoader.cb_handles_Landroid_net_Uri_;
		}

		// Token: 0x060010D1 RID: 4305 RVA: 0x00036630 File Offset: 0x00034830
		private static bool n_Handles_Landroid_net_Uri_(IntPtr jnienv, IntPtr native__this, IntPtr native_model)
		{
			MediaStoreVideoThumbLoader @object = Java.Lang.Object.GetObject<MediaStoreVideoThumbLoader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Android.Net.Uri object2 = Java.Lang.Object.GetObject<Android.Net.Uri>(native_model, JniHandleOwnership.DoNotTransfer);
			return @object.Handles(object2);
		}

		// Token: 0x060010D2 RID: 4306 RVA: 0x00036654 File Offset: 0x00034854
		[Register("handles", "(Landroid/net/Uri;)Z", "GetHandles_Landroid_net_Uri_Handler")]
		public unsafe virtual bool Handles(Android.Net.Uri model)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((model == null) ? IntPtr.Zero : model.Handle);
				result = MediaStoreVideoThumbLoader._members.InstanceMethods.InvokeVirtualBooleanMethod("handles.(Landroid/net/Uri;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(model);
			}
			return result;
		}

		// Token: 0x060010D3 RID: 4307 RVA: 0x000366BC File Offset: 0x000348BC
		ModelLoaderLoadData IModelLoader.BuildLoadData(Java.Lang.Object p0, int p1, int p2, Options p3)
		{
			return this.BuildLoadData(p0.JavaCast<Android.Net.Uri>(), p1, p2, p3).JavaCast<ModelLoaderLoadData>();
		}

		// Token: 0x060010D4 RID: 4308 RVA: 0x000366D3 File Offset: 0x000348D3
		bool IModelLoader.Handles(Java.Lang.Object p0)
		{
			return this.Handles(p0.JavaCast<Android.Net.Uri>());
		}

		// Token: 0x040003DC RID: 988
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/model/stream/MediaStoreVideoThumbLoader", typeof(MediaStoreVideoThumbLoader));

		// Token: 0x040003DD RID: 989
		private static Delegate cb_buildLoadData_Landroid_net_Uri_IILcom_bumptech_glide_load_Options_;

		// Token: 0x040003DE RID: 990
		private static Delegate cb_handles_Landroid_net_Uri_;

		// Token: 0x020001F3 RID: 499
		[Register("com/bumptech/glide/load/model/stream/MediaStoreVideoThumbLoader$Factory", DoNotGenerateAcw = true)]
		public class Factory : Java.Lang.Object, IModelLoaderFactory, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x1700067D RID: 1661
			// (get) Token: 0x060017B0 RID: 6064 RVA: 0x000495B4 File Offset: 0x000477B4
			internal static IntPtr class_ref
			{
				get
				{
					return MediaStoreVideoThumbLoader.Factory._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700067E RID: 1662
			// (get) Token: 0x060017B1 RID: 6065 RVA: 0x000495D8 File Offset: 0x000477D8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return MediaStoreVideoThumbLoader.Factory._members;
				}
			}

			// Token: 0x1700067F RID: 1663
			// (get) Token: 0x060017B2 RID: 6066 RVA: 0x000495E0 File Offset: 0x000477E0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return MediaStoreVideoThumbLoader.Factory._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000680 RID: 1664
			// (get) Token: 0x060017B3 RID: 6067 RVA: 0x00049604 File Offset: 0x00047804
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return MediaStoreVideoThumbLoader.Factory._members.ManagedPeerType;
				}
			}

			// Token: 0x060017B4 RID: 6068 RVA: 0x00049610 File Offset: 0x00047810
			protected Factory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x060017B5 RID: 6069 RVA: 0x0004961C File Offset: 0x0004781C
			[Register(".ctor", "(Landroid/content/Context;)V", "")]
			public unsafe Factory(Context context) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
					base.SetHandle(MediaStoreVideoThumbLoader.Factory._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					MediaStoreVideoThumbLoader.Factory._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(context);
				}
			}

			// Token: 0x060017B6 RID: 6070 RVA: 0x000496CC File Offset: 0x000478CC
			private static Delegate GetBuild_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_Handler()
			{
				if (MediaStoreVideoThumbLoader.Factory.cb_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_ == null)
				{
					MediaStoreVideoThumbLoader.Factory.cb_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(MediaStoreVideoThumbLoader.Factory.n_Build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_));
				}
				return MediaStoreVideoThumbLoader.Factory.cb_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_;
			}

			// Token: 0x060017B7 RID: 6071 RVA: 0x000496F0 File Offset: 0x000478F0
			private static IntPtr n_Build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_(IntPtr jnienv, IntPtr native__this, IntPtr native_multiFactory)
			{
				MediaStoreVideoThumbLoader.Factory @object = Java.Lang.Object.GetObject<MediaStoreVideoThumbLoader.Factory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				MultiModelLoaderFactory object2 = Java.Lang.Object.GetObject<MultiModelLoaderFactory>(native_multiFactory, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.Build(object2));
			}

			// Token: 0x060017B8 RID: 6072 RVA: 0x00049718 File Offset: 0x00047918
			[Register("build", "(Lcom/bumptech/glide/load/model/MultiModelLoaderFactory;)Lcom/bumptech/glide/load/model/ModelLoader;", "GetBuild_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_Handler")]
			public unsafe virtual IModelLoader Build(MultiModelLoaderFactory multiFactory)
			{
				IModelLoader @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((multiFactory == null) ? IntPtr.Zero : multiFactory.Handle);
					@object = Java.Lang.Object.GetObject<IModelLoader>(MediaStoreVideoThumbLoader.Factory._members.InstanceMethods.InvokeVirtualObjectMethod("build.(Lcom/bumptech/glide/load/model/MultiModelLoaderFactory;)Lcom/bumptech/glide/load/model/ModelLoader;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(multiFactory);
				}
				return @object;
			}

			// Token: 0x060017B9 RID: 6073 RVA: 0x0004978C File Offset: 0x0004798C
			private static Delegate GetTeardownHandler()
			{
				if (MediaStoreVideoThumbLoader.Factory.cb_teardown == null)
				{
					MediaStoreVideoThumbLoader.Factory.cb_teardown = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(MediaStoreVideoThumbLoader.Factory.n_Teardown));
				}
				return MediaStoreVideoThumbLoader.Factory.cb_teardown;
			}

			// Token: 0x060017BA RID: 6074 RVA: 0x000497B0 File Offset: 0x000479B0
			private static void n_Teardown(IntPtr jnienv, IntPtr native__this)
			{
				Java.Lang.Object.GetObject<MediaStoreVideoThumbLoader.Factory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Teardown();
			}

			// Token: 0x060017BB RID: 6075 RVA: 0x000497BF File Offset: 0x000479BF
			[Register("teardown", "()V", "GetTeardownHandler")]
			public virtual void Teardown()
			{
				MediaStoreVideoThumbLoader.Factory._members.InstanceMethods.InvokeVirtualVoidMethod("teardown.()V", this, null);
			}

			// Token: 0x060017BC RID: 6076 RVA: 0x000497D8 File Offset: 0x000479D8
			IModelLoader IModelLoaderFactory.Build(MultiModelLoaderFactory p0)
			{
				return this.Build(p0).JavaCast<IModelLoader>();
			}

			// Token: 0x040005A6 RID: 1446
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/model/stream/MediaStoreVideoThumbLoader$Factory", typeof(MediaStoreVideoThumbLoader.Factory));

			// Token: 0x040005A7 RID: 1447
			private static Delegate cb_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_;

			// Token: 0x040005A8 RID: 1448
			private static Delegate cb_teardown;
		}
	}
}
