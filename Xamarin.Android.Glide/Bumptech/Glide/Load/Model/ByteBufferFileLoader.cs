using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;

namespace Bumptech.Glide.Load.Model
{
	// Token: 0x0200012E RID: 302
	[Register("com/bumptech/glide/load/model/ByteBufferFileLoader", DoNotGenerateAcw = true)]
	public class ByteBufferFileLoader : Java.Lang.Object, IModelLoader, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06000F73 RID: 3955 RVA: 0x00031C68 File Offset: 0x0002FE68
		internal static IntPtr class_ref
		{
			get
			{
				return ByteBufferFileLoader._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06000F74 RID: 3956 RVA: 0x00031C8C File Offset: 0x0002FE8C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ByteBufferFileLoader._members;
			}
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06000F75 RID: 3957 RVA: 0x00031C94 File Offset: 0x0002FE94
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ByteBufferFileLoader._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06000F76 RID: 3958 RVA: 0x00031CB8 File Offset: 0x0002FEB8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ByteBufferFileLoader._members.ManagedPeerType;
			}
		}

		// Token: 0x06000F77 RID: 3959 RVA: 0x00031CC4 File Offset: 0x0002FEC4
		protected ByteBufferFileLoader(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000F78 RID: 3960 RVA: 0x00031CD0 File Offset: 0x0002FED0
		[Register(".ctor", "()V", "")]
		public ByteBufferFileLoader() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(ByteBufferFileLoader._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			ByteBufferFileLoader._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000F79 RID: 3961 RVA: 0x00031D3E File Offset: 0x0002FF3E
		private static Delegate GetBuildLoadData_Ljava_io_File_IILcom_bumptech_glide_load_Options_Handler()
		{
			if (ByteBufferFileLoader.cb_buildLoadData_Ljava_io_File_IILcom_bumptech_glide_load_Options_ == null)
			{
				ByteBufferFileLoader.cb_buildLoadData_Ljava_io_File_IILcom_bumptech_glide_load_Options_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIIL_L(ByteBufferFileLoader.n_BuildLoadData_Ljava_io_File_IILcom_bumptech_glide_load_Options_));
			}
			return ByteBufferFileLoader.cb_buildLoadData_Ljava_io_File_IILcom_bumptech_glide_load_Options_;
		}

		// Token: 0x06000F7A RID: 3962 RVA: 0x00031D64 File Offset: 0x0002FF64
		private static IntPtr n_BuildLoadData_Ljava_io_File_IILcom_bumptech_glide_load_Options_(IntPtr jnienv, IntPtr native__this, IntPtr native_file, int width, int height, IntPtr native_options)
		{
			ByteBufferFileLoader @object = Java.Lang.Object.GetObject<ByteBufferFileLoader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			File object2 = Java.Lang.Object.GetObject<File>(native_file, JniHandleOwnership.DoNotTransfer);
			Options object3 = Java.Lang.Object.GetObject<Options>(native_options, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.BuildLoadData(object2, width, height, object3));
		}

		// Token: 0x06000F7B RID: 3963 RVA: 0x00031D9C File Offset: 0x0002FF9C
		[Register("buildLoadData", "(Ljava/io/File;IILcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/model/ModelLoader$LoadData;", "GetBuildLoadData_Ljava_io_File_IILcom_bumptech_glide_load_Options_Handler")]
		public unsafe virtual ModelLoaderLoadData BuildLoadData(File file, int width, int height, Options options)
		{
			ModelLoaderLoadData @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((file == null) ? IntPtr.Zero : file.Handle);
				ptr[1] = new JniArgumentValue(width);
				ptr[2] = new JniArgumentValue(height);
				ptr[3] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				@object = Java.Lang.Object.GetObject<ModelLoaderLoadData>(ByteBufferFileLoader._members.InstanceMethods.InvokeVirtualObjectMethod("buildLoadData.(Ljava/io/File;IILcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/model/ModelLoader$LoadData;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(file);
				GC.KeepAlive(options);
			}
			return @object;
		}

		// Token: 0x06000F7C RID: 3964 RVA: 0x00031E68 File Offset: 0x00030068
		private static Delegate GetHandles_Ljava_io_File_Handler()
		{
			if (ByteBufferFileLoader.cb_handles_Ljava_io_File_ == null)
			{
				ByteBufferFileLoader.cb_handles_Ljava_io_File_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(ByteBufferFileLoader.n_Handles_Ljava_io_File_));
			}
			return ByteBufferFileLoader.cb_handles_Ljava_io_File_;
		}

		// Token: 0x06000F7D RID: 3965 RVA: 0x00031E8C File Offset: 0x0003008C
		private static bool n_Handles_Ljava_io_File_(IntPtr jnienv, IntPtr native__this, IntPtr native_file)
		{
			ByteBufferFileLoader @object = Java.Lang.Object.GetObject<ByteBufferFileLoader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			File object2 = Java.Lang.Object.GetObject<File>(native_file, JniHandleOwnership.DoNotTransfer);
			return @object.Handles(object2);
		}

		// Token: 0x06000F7E RID: 3966 RVA: 0x00031EB0 File Offset: 0x000300B0
		[Register("handles", "(Ljava/io/File;)Z", "GetHandles_Ljava_io_File_Handler")]
		public unsafe virtual bool Handles(File file)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((file == null) ? IntPtr.Zero : file.Handle);
				result = ByteBufferFileLoader._members.InstanceMethods.InvokeVirtualBooleanMethod("handles.(Ljava/io/File;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(file);
			}
			return result;
		}

		// Token: 0x06000F7F RID: 3967 RVA: 0x00031F18 File Offset: 0x00030118
		ModelLoaderLoadData IModelLoader.BuildLoadData(Java.Lang.Object p0, int p1, int p2, Options p3)
		{
			return this.BuildLoadData(p0.JavaCast<File>(), p1, p2, p3).JavaCast<ModelLoaderLoadData>();
		}

		// Token: 0x06000F80 RID: 3968 RVA: 0x00031F2F File Offset: 0x0003012F
		bool IModelLoader.Handles(Java.Lang.Object p0)
		{
			return this.Handles(p0.JavaCast<File>());
		}

		// Token: 0x04000391 RID: 913
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/model/ByteBufferFileLoader", typeof(ByteBufferFileLoader));

		// Token: 0x04000392 RID: 914
		private static Delegate cb_buildLoadData_Ljava_io_File_IILcom_bumptech_glide_load_Options_;

		// Token: 0x04000393 RID: 915
		private static Delegate cb_handles_Ljava_io_File_;

		// Token: 0x020001E7 RID: 487
		[Register("com/bumptech/glide/load/model/ByteBufferFileLoader$Factory", DoNotGenerateAcw = true)]
		public class Factory : Java.Lang.Object, IModelLoaderFactory, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000653 RID: 1619
			// (get) Token: 0x0600173A RID: 5946 RVA: 0x000481C0 File Offset: 0x000463C0
			internal static IntPtr class_ref
			{
				get
				{
					return ByteBufferFileLoader.Factory._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000654 RID: 1620
			// (get) Token: 0x0600173B RID: 5947 RVA: 0x000481E4 File Offset: 0x000463E4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ByteBufferFileLoader.Factory._members;
				}
			}

			// Token: 0x17000655 RID: 1621
			// (get) Token: 0x0600173C RID: 5948 RVA: 0x000481EC File Offset: 0x000463EC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return ByteBufferFileLoader.Factory._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000656 RID: 1622
			// (get) Token: 0x0600173D RID: 5949 RVA: 0x00048210 File Offset: 0x00046410
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ByteBufferFileLoader.Factory._members.ManagedPeerType;
				}
			}

			// Token: 0x0600173E RID: 5950 RVA: 0x0004821C File Offset: 0x0004641C
			protected Factory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x0600173F RID: 5951 RVA: 0x00048228 File Offset: 0x00046428
			[Register(".ctor", "()V", "")]
			public Factory() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(ByteBufferFileLoader.Factory._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				ByteBufferFileLoader.Factory._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x06001740 RID: 5952 RVA: 0x00048296 File Offset: 0x00046496
			private static Delegate GetBuild_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_Handler()
			{
				if (ByteBufferFileLoader.Factory.cb_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_ == null)
				{
					ByteBufferFileLoader.Factory.cb_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ByteBufferFileLoader.Factory.n_Build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_));
				}
				return ByteBufferFileLoader.Factory.cb_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_;
			}

			// Token: 0x06001741 RID: 5953 RVA: 0x000482BC File Offset: 0x000464BC
			private static IntPtr n_Build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_(IntPtr jnienv, IntPtr native__this, IntPtr native_multiFactory)
			{
				ByteBufferFileLoader.Factory @object = Java.Lang.Object.GetObject<ByteBufferFileLoader.Factory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				MultiModelLoaderFactory object2 = Java.Lang.Object.GetObject<MultiModelLoaderFactory>(native_multiFactory, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.Build(object2));
			}

			// Token: 0x06001742 RID: 5954 RVA: 0x000482E4 File Offset: 0x000464E4
			[Register("build", "(Lcom/bumptech/glide/load/model/MultiModelLoaderFactory;)Lcom/bumptech/glide/load/model/ModelLoader;", "GetBuild_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_Handler")]
			public unsafe virtual IModelLoader Build(MultiModelLoaderFactory multiFactory)
			{
				IModelLoader @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((multiFactory == null) ? IntPtr.Zero : multiFactory.Handle);
					@object = Java.Lang.Object.GetObject<IModelLoader>(ByteBufferFileLoader.Factory._members.InstanceMethods.InvokeVirtualObjectMethod("build.(Lcom/bumptech/glide/load/model/MultiModelLoaderFactory;)Lcom/bumptech/glide/load/model/ModelLoader;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(multiFactory);
				}
				return @object;
			}

			// Token: 0x06001743 RID: 5955 RVA: 0x00048358 File Offset: 0x00046558
			private static Delegate GetTeardownHandler()
			{
				if (ByteBufferFileLoader.Factory.cb_teardown == null)
				{
					ByteBufferFileLoader.Factory.cb_teardown = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ByteBufferFileLoader.Factory.n_Teardown));
				}
				return ByteBufferFileLoader.Factory.cb_teardown;
			}

			// Token: 0x06001744 RID: 5956 RVA: 0x0004837C File Offset: 0x0004657C
			private static void n_Teardown(IntPtr jnienv, IntPtr native__this)
			{
				Java.Lang.Object.GetObject<ByteBufferFileLoader.Factory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Teardown();
			}

			// Token: 0x06001745 RID: 5957 RVA: 0x0004838B File Offset: 0x0004658B
			[Register("teardown", "()V", "GetTeardownHandler")]
			public virtual void Teardown()
			{
				ByteBufferFileLoader.Factory._members.InstanceMethods.InvokeVirtualVoidMethod("teardown.()V", this, null);
			}

			// Token: 0x06001746 RID: 5958 RVA: 0x000483A4 File Offset: 0x000465A4
			IModelLoader IModelLoaderFactory.Build(MultiModelLoaderFactory p0)
			{
				return this.Build(p0).JavaCast<IModelLoader>();
			}

			// Token: 0x0400058D RID: 1421
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/model/ByteBufferFileLoader$Factory", typeof(ByteBufferFileLoader.Factory));

			// Token: 0x0400058E RID: 1422
			private static Delegate cb_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_;

			// Token: 0x0400058F RID: 1423
			private static Delegate cb_teardown;
		}
	}
}
