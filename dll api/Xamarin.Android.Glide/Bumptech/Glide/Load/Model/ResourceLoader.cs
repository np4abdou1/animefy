using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content.Res;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Model
{
	// Token: 0x0200012A RID: 298
	[Register("com/bumptech/glide/load/model/ResourceLoader", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"Data"
	})]
	public class ResourceLoader : Java.Lang.Object, IModelLoader, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000F3B RID: 3899 RVA: 0x00031097 File Offset: 0x0002F297
		public virtual ModelLoaderLoadData BuildLoadData(Java.Lang.Object model, int width, int height, Options options)
		{
			return this.BuildLoadData((Integer)model, width, height, options);
		}

		// Token: 0x06000F3C RID: 3900 RVA: 0x000310A9 File Offset: 0x0002F2A9
		public virtual bool Handles(Java.Lang.Object model)
		{
			return this.Handles((Integer)model);
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06000F3D RID: 3901 RVA: 0x000310B8 File Offset: 0x0002F2B8
		internal static IntPtr class_ref
		{
			get
			{
				return ResourceLoader._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06000F3E RID: 3902 RVA: 0x000310DC File Offset: 0x0002F2DC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ResourceLoader._members;
			}
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06000F3F RID: 3903 RVA: 0x000310E4 File Offset: 0x0002F2E4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ResourceLoader._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06000F40 RID: 3904 RVA: 0x00031108 File Offset: 0x0002F308
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ResourceLoader._members.ManagedPeerType;
			}
		}

		// Token: 0x06000F41 RID: 3905 RVA: 0x00031114 File Offset: 0x0002F314
		protected ResourceLoader(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000F42 RID: 3906 RVA: 0x00031120 File Offset: 0x0002F320
		[Register(".ctor", "(Landroid/content/res/Resources;Lcom/bumptech/glide/load/model/ModelLoader;)V", "")]
		public unsafe ResourceLoader(Resources resources, IModelLoader uriLoader) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((resources == null) ? IntPtr.Zero : resources.Handle);
				ptr[1] = new JniArgumentValue((uriLoader == null) ? IntPtr.Zero : ((Java.Lang.Object)uriLoader).Handle);
				base.SetHandle(ResourceLoader._members.InstanceMethods.StartCreateInstance("(Landroid/content/res/Resources;Lcom/bumptech/glide/load/model/ModelLoader;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ResourceLoader._members.InstanceMethods.FinishCreateInstance("(Landroid/content/res/Resources;Lcom/bumptech/glide/load/model/ModelLoader;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(resources);
				GC.KeepAlive(uriLoader);
			}
		}

		// Token: 0x06000F43 RID: 3907 RVA: 0x000311FC File Offset: 0x0002F3FC
		private static Delegate GetBuildLoadData_Ljava_lang_Integer_IILcom_bumptech_glide_load_Options_Handler()
		{
			if (ResourceLoader.cb_buildLoadData_Ljava_lang_Integer_IILcom_bumptech_glide_load_Options_ == null)
			{
				ResourceLoader.cb_buildLoadData_Ljava_lang_Integer_IILcom_bumptech_glide_load_Options_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIIL_L(ResourceLoader.n_BuildLoadData_Ljava_lang_Integer_IILcom_bumptech_glide_load_Options_));
			}
			return ResourceLoader.cb_buildLoadData_Ljava_lang_Integer_IILcom_bumptech_glide_load_Options_;
		}

		// Token: 0x06000F44 RID: 3908 RVA: 0x00031220 File Offset: 0x0002F420
		private static IntPtr n_BuildLoadData_Ljava_lang_Integer_IILcom_bumptech_glide_load_Options_(IntPtr jnienv, IntPtr native__this, IntPtr native_model, int width, int height, IntPtr native_options)
		{
			ResourceLoader @object = Java.Lang.Object.GetObject<ResourceLoader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Integer object2 = Java.Lang.Object.GetObject<Integer>(native_model, JniHandleOwnership.DoNotTransfer);
			Options object3 = Java.Lang.Object.GetObject<Options>(native_options, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.BuildLoadData(object2, width, height, object3));
		}

		// Token: 0x06000F45 RID: 3909 RVA: 0x00031258 File Offset: 0x0002F458
		[Register("buildLoadData", "(Ljava/lang/Integer;IILcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/model/ModelLoader$LoadData;", "GetBuildLoadData_Ljava_lang_Integer_IILcom_bumptech_glide_load_Options_Handler")]
		public unsafe virtual ModelLoaderLoadData BuildLoadData(Integer model, int width, int height, Options options)
		{
			ModelLoaderLoadData @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((model == null) ? IntPtr.Zero : model.Handle);
				ptr[1] = new JniArgumentValue(width);
				ptr[2] = new JniArgumentValue(height);
				ptr[3] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				@object = Java.Lang.Object.GetObject<ModelLoaderLoadData>(ResourceLoader._members.InstanceMethods.InvokeVirtualObjectMethod("buildLoadData.(Ljava/lang/Integer;IILcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/model/ModelLoader$LoadData;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(model);
				GC.KeepAlive(options);
			}
			return @object;
		}

		// Token: 0x06000F46 RID: 3910 RVA: 0x00031324 File Offset: 0x0002F524
		private static Delegate GetHandles_Ljava_lang_Integer_Handler()
		{
			if (ResourceLoader.cb_handles_Ljava_lang_Integer_ == null)
			{
				ResourceLoader.cb_handles_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(ResourceLoader.n_Handles_Ljava_lang_Integer_));
			}
			return ResourceLoader.cb_handles_Ljava_lang_Integer_;
		}

		// Token: 0x06000F47 RID: 3911 RVA: 0x00031348 File Offset: 0x0002F548
		private static bool n_Handles_Ljava_lang_Integer_(IntPtr jnienv, IntPtr native__this, IntPtr native_model)
		{
			ResourceLoader @object = Java.Lang.Object.GetObject<ResourceLoader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Integer object2 = Java.Lang.Object.GetObject<Integer>(native_model, JniHandleOwnership.DoNotTransfer);
			return @object.Handles(object2);
		}

		// Token: 0x06000F48 RID: 3912 RVA: 0x0003136C File Offset: 0x0002F56C
		[Register("handles", "(Ljava/lang/Integer;)Z", "GetHandles_Ljava_lang_Integer_Handler")]
		public unsafe virtual bool Handles(Integer model)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((model == null) ? IntPtr.Zero : model.Handle);
				result = ResourceLoader._members.InstanceMethods.InvokeVirtualBooleanMethod("handles.(Ljava/lang/Integer;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(model);
			}
			return result;
		}

		// Token: 0x04000386 RID: 902
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/model/ResourceLoader", typeof(ResourceLoader));

		// Token: 0x04000387 RID: 903
		private static Delegate cb_buildLoadData_Ljava_lang_Integer_IILcom_bumptech_glide_load_Options_;

		// Token: 0x04000388 RID: 904
		private static Delegate cb_handles_Ljava_lang_Integer_;

		// Token: 0x020001DD RID: 477
		[Register("com/bumptech/glide/load/model/ResourceLoader$AssetFileDescriptorFactory", DoNotGenerateAcw = true)]
		public sealed class AssetFileDescriptorFactory : Java.Lang.Object, IModelLoaderFactory, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x1700062F RID: 1583
			// (get) Token: 0x060016BB RID: 5819 RVA: 0x00046CAC File Offset: 0x00044EAC
			internal static IntPtr class_ref
			{
				get
				{
					return ResourceLoader.AssetFileDescriptorFactory._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000630 RID: 1584
			// (get) Token: 0x060016BC RID: 5820 RVA: 0x00046CD0 File Offset: 0x00044ED0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ResourceLoader.AssetFileDescriptorFactory._members;
				}
			}

			// Token: 0x17000631 RID: 1585
			// (get) Token: 0x060016BD RID: 5821 RVA: 0x00046CD8 File Offset: 0x00044ED8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return ResourceLoader.AssetFileDescriptorFactory._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000632 RID: 1586
			// (get) Token: 0x060016BE RID: 5822 RVA: 0x00046CFC File Offset: 0x00044EFC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ResourceLoader.AssetFileDescriptorFactory._members.ManagedPeerType;
				}
			}

			// Token: 0x060016BF RID: 5823 RVA: 0x00046D08 File Offset: 0x00044F08
			internal AssetFileDescriptorFactory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x060016C0 RID: 5824 RVA: 0x00046D14 File Offset: 0x00044F14
			[Register(".ctor", "(Landroid/content/res/Resources;)V", "")]
			public unsafe AssetFileDescriptorFactory(Resources resources) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((resources == null) ? IntPtr.Zero : resources.Handle);
					base.SetHandle(ResourceLoader.AssetFileDescriptorFactory._members.InstanceMethods.StartCreateInstance("(Landroid/content/res/Resources;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					ResourceLoader.AssetFileDescriptorFactory._members.InstanceMethods.FinishCreateInstance("(Landroid/content/res/Resources;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(resources);
				}
			}

			// Token: 0x060016C1 RID: 5825 RVA: 0x00046DC4 File Offset: 0x00044FC4
			[Register("build", "(Lcom/bumptech/glide/load/model/MultiModelLoaderFactory;)Lcom/bumptech/glide/load/model/ModelLoader;", "")]
			public unsafe IModelLoader Build(MultiModelLoaderFactory multiFactory)
			{
				IModelLoader @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((multiFactory == null) ? IntPtr.Zero : multiFactory.Handle);
					@object = Java.Lang.Object.GetObject<IModelLoader>(ResourceLoader.AssetFileDescriptorFactory._members.InstanceMethods.InvokeAbstractObjectMethod("build.(Lcom/bumptech/glide/load/model/MultiModelLoaderFactory;)Lcom/bumptech/glide/load/model/ModelLoader;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(multiFactory);
				}
				return @object;
			}

			// Token: 0x060016C2 RID: 5826 RVA: 0x00046E38 File Offset: 0x00045038
			[Register("teardown", "()V", "")]
			public void Teardown()
			{
				ResourceLoader.AssetFileDescriptorFactory._members.InstanceMethods.InvokeAbstractVoidMethod("teardown.()V", this, null);
			}

			// Token: 0x060016C3 RID: 5827 RVA: 0x00046E51 File Offset: 0x00045051
			IModelLoader IModelLoaderFactory.Build(MultiModelLoaderFactory p0)
			{
				return this.Build(p0).JavaCast<IModelLoader>();
			}

			// Token: 0x04000573 RID: 1395
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/model/ResourceLoader$AssetFileDescriptorFactory", typeof(ResourceLoader.AssetFileDescriptorFactory));
		}

		// Token: 0x020001DE RID: 478
		[Obsolete("This class is obsoleted in this android platform")]
		[Register("com/bumptech/glide/load/model/ResourceLoader$FileDescriptorFactory", DoNotGenerateAcw = true)]
		public class FileDescriptorFactory : Java.Lang.Object, IModelLoaderFactory, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000633 RID: 1587
			// (get) Token: 0x060016C5 RID: 5829 RVA: 0x00046E7C File Offset: 0x0004507C
			internal static IntPtr class_ref
			{
				get
				{
					return ResourceLoader.FileDescriptorFactory._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000634 RID: 1588
			// (get) Token: 0x060016C6 RID: 5830 RVA: 0x00046EA0 File Offset: 0x000450A0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ResourceLoader.FileDescriptorFactory._members;
				}
			}

			// Token: 0x17000635 RID: 1589
			// (get) Token: 0x060016C7 RID: 5831 RVA: 0x00046EA8 File Offset: 0x000450A8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return ResourceLoader.FileDescriptorFactory._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000636 RID: 1590
			// (get) Token: 0x060016C8 RID: 5832 RVA: 0x00046ECC File Offset: 0x000450CC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ResourceLoader.FileDescriptorFactory._members.ManagedPeerType;
				}
			}

			// Token: 0x060016C9 RID: 5833 RVA: 0x00046ED8 File Offset: 0x000450D8
			protected FileDescriptorFactory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x060016CA RID: 5834 RVA: 0x00046EE4 File Offset: 0x000450E4
			[Register(".ctor", "(Landroid/content/res/Resources;)V", "")]
			public unsafe FileDescriptorFactory(Resources resources) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((resources == null) ? IntPtr.Zero : resources.Handle);
					base.SetHandle(ResourceLoader.FileDescriptorFactory._members.InstanceMethods.StartCreateInstance("(Landroid/content/res/Resources;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					ResourceLoader.FileDescriptorFactory._members.InstanceMethods.FinishCreateInstance("(Landroid/content/res/Resources;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(resources);
				}
			}

			// Token: 0x060016CB RID: 5835 RVA: 0x00046F94 File Offset: 0x00045194
			private static Delegate GetBuild_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_Handler()
			{
				if (ResourceLoader.FileDescriptorFactory.cb_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_ == null)
				{
					ResourceLoader.FileDescriptorFactory.cb_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ResourceLoader.FileDescriptorFactory.n_Build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_));
				}
				return ResourceLoader.FileDescriptorFactory.cb_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_;
			}

			// Token: 0x060016CC RID: 5836 RVA: 0x00046FB8 File Offset: 0x000451B8
			private static IntPtr n_Build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_(IntPtr jnienv, IntPtr native__this, IntPtr native_multiFactory)
			{
				ResourceLoader.FileDescriptorFactory @object = Java.Lang.Object.GetObject<ResourceLoader.FileDescriptorFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				MultiModelLoaderFactory object2 = Java.Lang.Object.GetObject<MultiModelLoaderFactory>(native_multiFactory, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.Build(object2));
			}

			// Token: 0x060016CD RID: 5837 RVA: 0x00046FE0 File Offset: 0x000451E0
			[Register("build", "(Lcom/bumptech/glide/load/model/MultiModelLoaderFactory;)Lcom/bumptech/glide/load/model/ModelLoader;", "GetBuild_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_Handler")]
			public unsafe virtual IModelLoader Build(MultiModelLoaderFactory multiFactory)
			{
				IModelLoader @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((multiFactory == null) ? IntPtr.Zero : multiFactory.Handle);
					@object = Java.Lang.Object.GetObject<IModelLoader>(ResourceLoader.FileDescriptorFactory._members.InstanceMethods.InvokeVirtualObjectMethod("build.(Lcom/bumptech/glide/load/model/MultiModelLoaderFactory;)Lcom/bumptech/glide/load/model/ModelLoader;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(multiFactory);
				}
				return @object;
			}

			// Token: 0x060016CE RID: 5838 RVA: 0x00047054 File Offset: 0x00045254
			private static Delegate GetTeardownHandler()
			{
				if (ResourceLoader.FileDescriptorFactory.cb_teardown == null)
				{
					ResourceLoader.FileDescriptorFactory.cb_teardown = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ResourceLoader.FileDescriptorFactory.n_Teardown));
				}
				return ResourceLoader.FileDescriptorFactory.cb_teardown;
			}

			// Token: 0x060016CF RID: 5839 RVA: 0x00047078 File Offset: 0x00045278
			private static void n_Teardown(IntPtr jnienv, IntPtr native__this)
			{
				Java.Lang.Object.GetObject<ResourceLoader.FileDescriptorFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Teardown();
			}

			// Token: 0x060016D0 RID: 5840 RVA: 0x00047087 File Offset: 0x00045287
			[Register("teardown", "()V", "GetTeardownHandler")]
			public virtual void Teardown()
			{
				ResourceLoader.FileDescriptorFactory._members.InstanceMethods.InvokeVirtualVoidMethod("teardown.()V", this, null);
			}

			// Token: 0x060016D1 RID: 5841 RVA: 0x000470A0 File Offset: 0x000452A0
			IModelLoader IModelLoaderFactory.Build(MultiModelLoaderFactory p0)
			{
				return this.Build(p0).JavaCast<IModelLoader>();
			}

			// Token: 0x04000574 RID: 1396
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/model/ResourceLoader$FileDescriptorFactory", typeof(ResourceLoader.FileDescriptorFactory));

			// Token: 0x04000575 RID: 1397
			private static Delegate cb_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_;

			// Token: 0x04000576 RID: 1398
			private static Delegate cb_teardown;
		}

		// Token: 0x020001DF RID: 479
		[Register("com/bumptech/glide/load/model/ResourceLoader$StreamFactory", DoNotGenerateAcw = true)]
		public class StreamFactory : Java.Lang.Object, IModelLoaderFactory, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000637 RID: 1591
			// (get) Token: 0x060016D3 RID: 5843 RVA: 0x000470CC File Offset: 0x000452CC
			internal static IntPtr class_ref
			{
				get
				{
					return ResourceLoader.StreamFactory._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000638 RID: 1592
			// (get) Token: 0x060016D4 RID: 5844 RVA: 0x000470F0 File Offset: 0x000452F0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ResourceLoader.StreamFactory._members;
				}
			}

			// Token: 0x17000639 RID: 1593
			// (get) Token: 0x060016D5 RID: 5845 RVA: 0x000470F8 File Offset: 0x000452F8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return ResourceLoader.StreamFactory._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700063A RID: 1594
			// (get) Token: 0x060016D6 RID: 5846 RVA: 0x0004711C File Offset: 0x0004531C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ResourceLoader.StreamFactory._members.ManagedPeerType;
				}
			}

			// Token: 0x060016D7 RID: 5847 RVA: 0x00047128 File Offset: 0x00045328
			protected StreamFactory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x060016D8 RID: 5848 RVA: 0x00047134 File Offset: 0x00045334
			[Register(".ctor", "(Landroid/content/res/Resources;)V", "")]
			public unsafe StreamFactory(Resources resources) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((resources == null) ? IntPtr.Zero : resources.Handle);
					base.SetHandle(ResourceLoader.StreamFactory._members.InstanceMethods.StartCreateInstance("(Landroid/content/res/Resources;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					ResourceLoader.StreamFactory._members.InstanceMethods.FinishCreateInstance("(Landroid/content/res/Resources;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(resources);
				}
			}

			// Token: 0x060016D9 RID: 5849 RVA: 0x000471E4 File Offset: 0x000453E4
			private static Delegate GetBuild_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_Handler()
			{
				if (ResourceLoader.StreamFactory.cb_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_ == null)
				{
					ResourceLoader.StreamFactory.cb_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ResourceLoader.StreamFactory.n_Build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_));
				}
				return ResourceLoader.StreamFactory.cb_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_;
			}

			// Token: 0x060016DA RID: 5850 RVA: 0x00047208 File Offset: 0x00045408
			private static IntPtr n_Build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_(IntPtr jnienv, IntPtr native__this, IntPtr native_multiFactory)
			{
				ResourceLoader.StreamFactory @object = Java.Lang.Object.GetObject<ResourceLoader.StreamFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				MultiModelLoaderFactory object2 = Java.Lang.Object.GetObject<MultiModelLoaderFactory>(native_multiFactory, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.Build(object2));
			}

			// Token: 0x060016DB RID: 5851 RVA: 0x00047230 File Offset: 0x00045430
			[Register("build", "(Lcom/bumptech/glide/load/model/MultiModelLoaderFactory;)Lcom/bumptech/glide/load/model/ModelLoader;", "GetBuild_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_Handler")]
			public unsafe virtual IModelLoader Build(MultiModelLoaderFactory multiFactory)
			{
				IModelLoader @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((multiFactory == null) ? IntPtr.Zero : multiFactory.Handle);
					@object = Java.Lang.Object.GetObject<IModelLoader>(ResourceLoader.StreamFactory._members.InstanceMethods.InvokeVirtualObjectMethod("build.(Lcom/bumptech/glide/load/model/MultiModelLoaderFactory;)Lcom/bumptech/glide/load/model/ModelLoader;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(multiFactory);
				}
				return @object;
			}

			// Token: 0x060016DC RID: 5852 RVA: 0x000472A4 File Offset: 0x000454A4
			private static Delegate GetTeardownHandler()
			{
				if (ResourceLoader.StreamFactory.cb_teardown == null)
				{
					ResourceLoader.StreamFactory.cb_teardown = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ResourceLoader.StreamFactory.n_Teardown));
				}
				return ResourceLoader.StreamFactory.cb_teardown;
			}

			// Token: 0x060016DD RID: 5853 RVA: 0x000472C8 File Offset: 0x000454C8
			private static void n_Teardown(IntPtr jnienv, IntPtr native__this)
			{
				Java.Lang.Object.GetObject<ResourceLoader.StreamFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Teardown();
			}

			// Token: 0x060016DE RID: 5854 RVA: 0x000472D7 File Offset: 0x000454D7
			[Register("teardown", "()V", "GetTeardownHandler")]
			public virtual void Teardown()
			{
				ResourceLoader.StreamFactory._members.InstanceMethods.InvokeVirtualVoidMethod("teardown.()V", this, null);
			}

			// Token: 0x060016DF RID: 5855 RVA: 0x000472F0 File Offset: 0x000454F0
			IModelLoader IModelLoaderFactory.Build(MultiModelLoaderFactory p0)
			{
				return this.Build(p0).JavaCast<IModelLoader>();
			}

			// Token: 0x04000577 RID: 1399
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/model/ResourceLoader$StreamFactory", typeof(ResourceLoader.StreamFactory));

			// Token: 0x04000578 RID: 1400
			private static Delegate cb_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_;

			// Token: 0x04000579 RID: 1401
			private static Delegate cb_teardown;
		}

		// Token: 0x020001E0 RID: 480
		[Register("com/bumptech/glide/load/model/ResourceLoader$UriFactory", DoNotGenerateAcw = true)]
		public class UriFactory : Java.Lang.Object, IModelLoaderFactory, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x1700063B RID: 1595
			// (get) Token: 0x060016E1 RID: 5857 RVA: 0x0004731C File Offset: 0x0004551C
			internal static IntPtr class_ref
			{
				get
				{
					return ResourceLoader.UriFactory._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700063C RID: 1596
			// (get) Token: 0x060016E2 RID: 5858 RVA: 0x00047340 File Offset: 0x00045540
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ResourceLoader.UriFactory._members;
				}
			}

			// Token: 0x1700063D RID: 1597
			// (get) Token: 0x060016E3 RID: 5859 RVA: 0x00047348 File Offset: 0x00045548
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return ResourceLoader.UriFactory._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700063E RID: 1598
			// (get) Token: 0x060016E4 RID: 5860 RVA: 0x0004736C File Offset: 0x0004556C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ResourceLoader.UriFactory._members.ManagedPeerType;
				}
			}

			// Token: 0x060016E5 RID: 5861 RVA: 0x00047378 File Offset: 0x00045578
			protected UriFactory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x060016E6 RID: 5862 RVA: 0x00047384 File Offset: 0x00045584
			[Register(".ctor", "(Landroid/content/res/Resources;)V", "")]
			public unsafe UriFactory(Resources resources) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((resources == null) ? IntPtr.Zero : resources.Handle);
					base.SetHandle(ResourceLoader.UriFactory._members.InstanceMethods.StartCreateInstance("(Landroid/content/res/Resources;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					ResourceLoader.UriFactory._members.InstanceMethods.FinishCreateInstance("(Landroid/content/res/Resources;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(resources);
				}
			}

			// Token: 0x060016E7 RID: 5863 RVA: 0x00047434 File Offset: 0x00045634
			private static Delegate GetBuild_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_Handler()
			{
				if (ResourceLoader.UriFactory.cb_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_ == null)
				{
					ResourceLoader.UriFactory.cb_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ResourceLoader.UriFactory.n_Build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_));
				}
				return ResourceLoader.UriFactory.cb_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_;
			}

			// Token: 0x060016E8 RID: 5864 RVA: 0x00047458 File Offset: 0x00045658
			private static IntPtr n_Build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_(IntPtr jnienv, IntPtr native__this, IntPtr native_multiFactory)
			{
				ResourceLoader.UriFactory @object = Java.Lang.Object.GetObject<ResourceLoader.UriFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				MultiModelLoaderFactory object2 = Java.Lang.Object.GetObject<MultiModelLoaderFactory>(native_multiFactory, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.Build(object2));
			}

			// Token: 0x060016E9 RID: 5865 RVA: 0x00047480 File Offset: 0x00045680
			[Register("build", "(Lcom/bumptech/glide/load/model/MultiModelLoaderFactory;)Lcom/bumptech/glide/load/model/ModelLoader;", "GetBuild_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_Handler")]
			public unsafe virtual IModelLoader Build(MultiModelLoaderFactory multiFactory)
			{
				IModelLoader @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((multiFactory == null) ? IntPtr.Zero : multiFactory.Handle);
					@object = Java.Lang.Object.GetObject<IModelLoader>(ResourceLoader.UriFactory._members.InstanceMethods.InvokeVirtualObjectMethod("build.(Lcom/bumptech/glide/load/model/MultiModelLoaderFactory;)Lcom/bumptech/glide/load/model/ModelLoader;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(multiFactory);
				}
				return @object;
			}

			// Token: 0x060016EA RID: 5866 RVA: 0x000474F4 File Offset: 0x000456F4
			private static Delegate GetTeardownHandler()
			{
				if (ResourceLoader.UriFactory.cb_teardown == null)
				{
					ResourceLoader.UriFactory.cb_teardown = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ResourceLoader.UriFactory.n_Teardown));
				}
				return ResourceLoader.UriFactory.cb_teardown;
			}

			// Token: 0x060016EB RID: 5867 RVA: 0x00047518 File Offset: 0x00045718
			private static void n_Teardown(IntPtr jnienv, IntPtr native__this)
			{
				Java.Lang.Object.GetObject<ResourceLoader.UriFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Teardown();
			}

			// Token: 0x060016EC RID: 5868 RVA: 0x00047527 File Offset: 0x00045727
			[Register("teardown", "()V", "GetTeardownHandler")]
			public virtual void Teardown()
			{
				ResourceLoader.UriFactory._members.InstanceMethods.InvokeVirtualVoidMethod("teardown.()V", this, null);
			}

			// Token: 0x060016ED RID: 5869 RVA: 0x00047540 File Offset: 0x00045740
			IModelLoader IModelLoaderFactory.Build(MultiModelLoaderFactory p0)
			{
				return this.Build(p0).JavaCast<IModelLoader>();
			}

			// Token: 0x0400057A RID: 1402
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/model/ResourceLoader$UriFactory", typeof(ResourceLoader.UriFactory));

			// Token: 0x0400057B RID: 1403
			private static Delegate cb_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_;

			// Token: 0x0400057C RID: 1404
			private static Delegate cb_teardown;
		}
	}
}
