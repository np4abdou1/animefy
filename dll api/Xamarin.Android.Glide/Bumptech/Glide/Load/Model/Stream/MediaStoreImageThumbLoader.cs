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
	// Token: 0x0200014C RID: 332
	[Register("com/bumptech/glide/load/model/stream/MediaStoreImageThumbLoader", DoNotGenerateAcw = true)]
	public class MediaStoreImageThumbLoader : Java.Lang.Object, IModelLoader, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x060010B8 RID: 4280 RVA: 0x0003609C File Offset: 0x0003429C
		internal static IntPtr class_ref
		{
			get
			{
				return MediaStoreImageThumbLoader._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x060010B9 RID: 4281 RVA: 0x000360C0 File Offset: 0x000342C0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MediaStoreImageThumbLoader._members;
			}
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x060010BA RID: 4282 RVA: 0x000360C8 File Offset: 0x000342C8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MediaStoreImageThumbLoader._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x060010BB RID: 4283 RVA: 0x000360EC File Offset: 0x000342EC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MediaStoreImageThumbLoader._members.ManagedPeerType;
			}
		}

		// Token: 0x060010BC RID: 4284 RVA: 0x000360F8 File Offset: 0x000342F8
		protected MediaStoreImageThumbLoader(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060010BD RID: 4285 RVA: 0x00036104 File Offset: 0x00034304
		[Register(".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe MediaStoreImageThumbLoader(Context context) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				base.SetHandle(MediaStoreImageThumbLoader._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				MediaStoreImageThumbLoader._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
		}

		// Token: 0x060010BE RID: 4286 RVA: 0x000361B4 File Offset: 0x000343B4
		private static Delegate GetBuildLoadData_Landroid_net_Uri_IILcom_bumptech_glide_load_Options_Handler()
		{
			if (MediaStoreImageThumbLoader.cb_buildLoadData_Landroid_net_Uri_IILcom_bumptech_glide_load_Options_ == null)
			{
				MediaStoreImageThumbLoader.cb_buildLoadData_Landroid_net_Uri_IILcom_bumptech_glide_load_Options_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIIL_L(MediaStoreImageThumbLoader.n_BuildLoadData_Landroid_net_Uri_IILcom_bumptech_glide_load_Options_));
			}
			return MediaStoreImageThumbLoader.cb_buildLoadData_Landroid_net_Uri_IILcom_bumptech_glide_load_Options_;
		}

		// Token: 0x060010BF RID: 4287 RVA: 0x000361D8 File Offset: 0x000343D8
		private static IntPtr n_BuildLoadData_Landroid_net_Uri_IILcom_bumptech_glide_load_Options_(IntPtr jnienv, IntPtr native__this, IntPtr native_model, int width, int height, IntPtr native_options)
		{
			MediaStoreImageThumbLoader @object = Java.Lang.Object.GetObject<MediaStoreImageThumbLoader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Android.Net.Uri object2 = Java.Lang.Object.GetObject<Android.Net.Uri>(native_model, JniHandleOwnership.DoNotTransfer);
			Options object3 = Java.Lang.Object.GetObject<Options>(native_options, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.BuildLoadData(object2, width, height, object3));
		}

		// Token: 0x060010C0 RID: 4288 RVA: 0x00036210 File Offset: 0x00034410
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
				@object = Java.Lang.Object.GetObject<ModelLoaderLoadData>(MediaStoreImageThumbLoader._members.InstanceMethods.InvokeVirtualObjectMethod("buildLoadData.(Landroid/net/Uri;IILcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/model/ModelLoader$LoadData;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(model);
				GC.KeepAlive(options);
			}
			return @object;
		}

		// Token: 0x060010C1 RID: 4289 RVA: 0x000362DC File Offset: 0x000344DC
		private static Delegate GetHandles_Landroid_net_Uri_Handler()
		{
			if (MediaStoreImageThumbLoader.cb_handles_Landroid_net_Uri_ == null)
			{
				MediaStoreImageThumbLoader.cb_handles_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(MediaStoreImageThumbLoader.n_Handles_Landroid_net_Uri_));
			}
			return MediaStoreImageThumbLoader.cb_handles_Landroid_net_Uri_;
		}

		// Token: 0x060010C2 RID: 4290 RVA: 0x00036300 File Offset: 0x00034500
		private static bool n_Handles_Landroid_net_Uri_(IntPtr jnienv, IntPtr native__this, IntPtr native_model)
		{
			MediaStoreImageThumbLoader @object = Java.Lang.Object.GetObject<MediaStoreImageThumbLoader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Android.Net.Uri object2 = Java.Lang.Object.GetObject<Android.Net.Uri>(native_model, JniHandleOwnership.DoNotTransfer);
			return @object.Handles(object2);
		}

		// Token: 0x060010C3 RID: 4291 RVA: 0x00036324 File Offset: 0x00034524
		[Register("handles", "(Landroid/net/Uri;)Z", "GetHandles_Landroid_net_Uri_Handler")]
		public unsafe virtual bool Handles(Android.Net.Uri model)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((model == null) ? IntPtr.Zero : model.Handle);
				result = MediaStoreImageThumbLoader._members.InstanceMethods.InvokeVirtualBooleanMethod("handles.(Landroid/net/Uri;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(model);
			}
			return result;
		}

		// Token: 0x060010C4 RID: 4292 RVA: 0x0003638C File Offset: 0x0003458C
		ModelLoaderLoadData IModelLoader.BuildLoadData(Java.Lang.Object p0, int p1, int p2, Options p3)
		{
			return this.BuildLoadData(p0.JavaCast<Android.Net.Uri>(), p1, p2, p3).JavaCast<ModelLoaderLoadData>();
		}

		// Token: 0x060010C5 RID: 4293 RVA: 0x000363A3 File Offset: 0x000345A3
		bool IModelLoader.Handles(Java.Lang.Object p0)
		{
			return this.Handles(p0.JavaCast<Android.Net.Uri>());
		}

		// Token: 0x040003D9 RID: 985
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/model/stream/MediaStoreImageThumbLoader", typeof(MediaStoreImageThumbLoader));

		// Token: 0x040003DA RID: 986
		private static Delegate cb_buildLoadData_Landroid_net_Uri_IILcom_bumptech_glide_load_Options_;

		// Token: 0x040003DB RID: 987
		private static Delegate cb_handles_Landroid_net_Uri_;

		// Token: 0x020001F2 RID: 498
		[Register("com/bumptech/glide/load/model/stream/MediaStoreImageThumbLoader$Factory", DoNotGenerateAcw = true)]
		public class Factory : Java.Lang.Object, IModelLoaderFactory, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000679 RID: 1657
			// (get) Token: 0x060017A2 RID: 6050 RVA: 0x00049364 File Offset: 0x00047564
			internal static IntPtr class_ref
			{
				get
				{
					return MediaStoreImageThumbLoader.Factory._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700067A RID: 1658
			// (get) Token: 0x060017A3 RID: 6051 RVA: 0x00049388 File Offset: 0x00047588
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return MediaStoreImageThumbLoader.Factory._members;
				}
			}

			// Token: 0x1700067B RID: 1659
			// (get) Token: 0x060017A4 RID: 6052 RVA: 0x00049390 File Offset: 0x00047590
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return MediaStoreImageThumbLoader.Factory._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700067C RID: 1660
			// (get) Token: 0x060017A5 RID: 6053 RVA: 0x000493B4 File Offset: 0x000475B4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return MediaStoreImageThumbLoader.Factory._members.ManagedPeerType;
				}
			}

			// Token: 0x060017A6 RID: 6054 RVA: 0x000493C0 File Offset: 0x000475C0
			protected Factory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x060017A7 RID: 6055 RVA: 0x000493CC File Offset: 0x000475CC
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
					base.SetHandle(MediaStoreImageThumbLoader.Factory._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					MediaStoreImageThumbLoader.Factory._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(context);
				}
			}

			// Token: 0x060017A8 RID: 6056 RVA: 0x0004947C File Offset: 0x0004767C
			private static Delegate GetBuild_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_Handler()
			{
				if (MediaStoreImageThumbLoader.Factory.cb_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_ == null)
				{
					MediaStoreImageThumbLoader.Factory.cb_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(MediaStoreImageThumbLoader.Factory.n_Build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_));
				}
				return MediaStoreImageThumbLoader.Factory.cb_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_;
			}

			// Token: 0x060017A9 RID: 6057 RVA: 0x000494A0 File Offset: 0x000476A0
			private static IntPtr n_Build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_(IntPtr jnienv, IntPtr native__this, IntPtr native_multiFactory)
			{
				MediaStoreImageThumbLoader.Factory @object = Java.Lang.Object.GetObject<MediaStoreImageThumbLoader.Factory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				MultiModelLoaderFactory object2 = Java.Lang.Object.GetObject<MultiModelLoaderFactory>(native_multiFactory, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.Build(object2));
			}

			// Token: 0x060017AA RID: 6058 RVA: 0x000494C8 File Offset: 0x000476C8
			[Register("build", "(Lcom/bumptech/glide/load/model/MultiModelLoaderFactory;)Lcom/bumptech/glide/load/model/ModelLoader;", "GetBuild_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_Handler")]
			public unsafe virtual IModelLoader Build(MultiModelLoaderFactory multiFactory)
			{
				IModelLoader @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((multiFactory == null) ? IntPtr.Zero : multiFactory.Handle);
					@object = Java.Lang.Object.GetObject<IModelLoader>(MediaStoreImageThumbLoader.Factory._members.InstanceMethods.InvokeVirtualObjectMethod("build.(Lcom/bumptech/glide/load/model/MultiModelLoaderFactory;)Lcom/bumptech/glide/load/model/ModelLoader;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(multiFactory);
				}
				return @object;
			}

			// Token: 0x060017AB RID: 6059 RVA: 0x0004953C File Offset: 0x0004773C
			private static Delegate GetTeardownHandler()
			{
				if (MediaStoreImageThumbLoader.Factory.cb_teardown == null)
				{
					MediaStoreImageThumbLoader.Factory.cb_teardown = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(MediaStoreImageThumbLoader.Factory.n_Teardown));
				}
				return MediaStoreImageThumbLoader.Factory.cb_teardown;
			}

			// Token: 0x060017AC RID: 6060 RVA: 0x00049560 File Offset: 0x00047760
			private static void n_Teardown(IntPtr jnienv, IntPtr native__this)
			{
				Java.Lang.Object.GetObject<MediaStoreImageThumbLoader.Factory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Teardown();
			}

			// Token: 0x060017AD RID: 6061 RVA: 0x0004956F File Offset: 0x0004776F
			[Register("teardown", "()V", "GetTeardownHandler")]
			public virtual void Teardown()
			{
				MediaStoreImageThumbLoader.Factory._members.InstanceMethods.InvokeVirtualVoidMethod("teardown.()V", this, null);
			}

			// Token: 0x060017AE RID: 6062 RVA: 0x00049588 File Offset: 0x00047788
			IModelLoader IModelLoaderFactory.Build(MultiModelLoaderFactory p0)
			{
				return this.Build(p0).JavaCast<IModelLoader>();
			}

			// Token: 0x040005A3 RID: 1443
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/model/stream/MediaStoreImageThumbLoader$Factory", typeof(MediaStoreImageThumbLoader.Factory));

			// Token: 0x040005A4 RID: 1444
			private static Delegate cb_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_;

			// Token: 0x040005A5 RID: 1445
			private static Delegate cb_teardown;
		}
	}
}
