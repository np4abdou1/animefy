using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Model
{
	// Token: 0x02000128 RID: 296
	[Register("com/bumptech/glide/load/model/StringLoader", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"Data"
	})]
	public class StringLoader : Java.Lang.Object, IModelLoader, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000F1D RID: 3869 RVA: 0x00030A3B File Offset: 0x0002EC3B
		public virtual ModelLoaderLoadData BuildLoadData(Java.Lang.Object model, int width, int height, Options options)
		{
			return this.BuildLoadData((model != null) ? model.ToString() : null, width, height, options);
		}

		// Token: 0x06000F1E RID: 3870 RVA: 0x00030A53 File Offset: 0x0002EC53
		public virtual bool Handles(Java.Lang.Object model)
		{
			return this.Handles((model != null) ? model.ToString() : null);
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06000F1F RID: 3871 RVA: 0x00030A68 File Offset: 0x0002EC68
		internal static IntPtr class_ref
		{
			get
			{
				return StringLoader._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06000F20 RID: 3872 RVA: 0x00030A8C File Offset: 0x0002EC8C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return StringLoader._members;
			}
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06000F21 RID: 3873 RVA: 0x00030A94 File Offset: 0x0002EC94
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return StringLoader._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06000F22 RID: 3874 RVA: 0x00030AB8 File Offset: 0x0002ECB8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return StringLoader._members.ManagedPeerType;
			}
		}

		// Token: 0x06000F23 RID: 3875 RVA: 0x00030AC4 File Offset: 0x0002ECC4
		protected StringLoader(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000F24 RID: 3876 RVA: 0x00030AD0 File Offset: 0x0002ECD0
		[Register(".ctor", "(Lcom/bumptech/glide/load/model/ModelLoader;)V", "")]
		public unsafe StringLoader(IModelLoader uriLoader) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((uriLoader == null) ? IntPtr.Zero : ((Java.Lang.Object)uriLoader).Handle);
				base.SetHandle(StringLoader._members.InstanceMethods.StartCreateInstance("(Lcom/bumptech/glide/load/model/ModelLoader;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				StringLoader._members.InstanceMethods.FinishCreateInstance("(Lcom/bumptech/glide/load/model/ModelLoader;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(uriLoader);
			}
		}

		// Token: 0x06000F25 RID: 3877 RVA: 0x00030B84 File Offset: 0x0002ED84
		private static Delegate GetBuildLoadData_Ljava_lang_String_IILcom_bumptech_glide_load_Options_Handler()
		{
			if (StringLoader.cb_buildLoadData_Ljava_lang_String_IILcom_bumptech_glide_load_Options_ == null)
			{
				StringLoader.cb_buildLoadData_Ljava_lang_String_IILcom_bumptech_glide_load_Options_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIIL_L(StringLoader.n_BuildLoadData_Ljava_lang_String_IILcom_bumptech_glide_load_Options_));
			}
			return StringLoader.cb_buildLoadData_Ljava_lang_String_IILcom_bumptech_glide_load_Options_;
		}

		// Token: 0x06000F26 RID: 3878 RVA: 0x00030BA8 File Offset: 0x0002EDA8
		private static IntPtr n_BuildLoadData_Ljava_lang_String_IILcom_bumptech_glide_load_Options_(IntPtr jnienv, IntPtr native__this, IntPtr native_model, int width, int height, IntPtr native_options)
		{
			StringLoader @object = Java.Lang.Object.GetObject<StringLoader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_model, JniHandleOwnership.DoNotTransfer);
			Options object2 = Java.Lang.Object.GetObject<Options>(native_options, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.BuildLoadData(@string, width, height, object2));
		}

		// Token: 0x06000F27 RID: 3879 RVA: 0x00030BE0 File Offset: 0x0002EDE0
		[Register("buildLoadData", "(Ljava/lang/String;IILcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/model/ModelLoader$LoadData;", "GetBuildLoadData_Ljava_lang_String_IILcom_bumptech_glide_load_Options_Handler")]
		public unsafe virtual ModelLoaderLoadData BuildLoadData(string model, int width, int height, Options options)
		{
			IntPtr intPtr = JNIEnv.NewString(model);
			ModelLoaderLoadData @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(width);
				ptr[2] = new JniArgumentValue(height);
				ptr[3] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				@object = Java.Lang.Object.GetObject<ModelLoaderLoadData>(StringLoader._members.InstanceMethods.InvokeVirtualObjectMethod("buildLoadData.(Ljava/lang/String;IILcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/model/ModelLoader$LoadData;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(options);
			}
			return @object;
		}

		// Token: 0x06000F28 RID: 3880 RVA: 0x00030CA4 File Offset: 0x0002EEA4
		private static Delegate GetHandles_Ljava_lang_String_Handler()
		{
			if (StringLoader.cb_handles_Ljava_lang_String_ == null)
			{
				StringLoader.cb_handles_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(StringLoader.n_Handles_Ljava_lang_String_));
			}
			return StringLoader.cb_handles_Ljava_lang_String_;
		}

		// Token: 0x06000F29 RID: 3881 RVA: 0x00030CC8 File Offset: 0x0002EEC8
		private static bool n_Handles_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_model)
		{
			StringLoader @object = Java.Lang.Object.GetObject<StringLoader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_model, JniHandleOwnership.DoNotTransfer);
			return @object.Handles(@string);
		}

		// Token: 0x06000F2A RID: 3882 RVA: 0x00030CEC File Offset: 0x0002EEEC
		[Register("handles", "(Ljava/lang/String;)Z", "GetHandles_Ljava_lang_String_Handler")]
		public unsafe virtual bool Handles(string model)
		{
			IntPtr intPtr = JNIEnv.NewString(model);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = StringLoader._members.InstanceMethods.InvokeVirtualBooleanMethod("handles.(Ljava/lang/String;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x04000380 RID: 896
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/model/StringLoader", typeof(StringLoader));

		// Token: 0x04000381 RID: 897
		private static Delegate cb_buildLoadData_Ljava_lang_String_IILcom_bumptech_glide_load_Options_;

		// Token: 0x04000382 RID: 898
		private static Delegate cb_handles_Ljava_lang_String_;

		// Token: 0x020001D5 RID: 469
		[Register("com/bumptech/glide/load/model/StringLoader$AssetFileDescriptorFactory", DoNotGenerateAcw = true)]
		public sealed class AssetFileDescriptorFactory : Java.Lang.Object, IModelLoaderFactory, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000611 RID: 1553
			// (get) Token: 0x06001669 RID: 5737 RVA: 0x0004604C File Offset: 0x0004424C
			internal static IntPtr class_ref
			{
				get
				{
					return StringLoader.AssetFileDescriptorFactory._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000612 RID: 1554
			// (get) Token: 0x0600166A RID: 5738 RVA: 0x00046070 File Offset: 0x00044270
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return StringLoader.AssetFileDescriptorFactory._members;
				}
			}

			// Token: 0x17000613 RID: 1555
			// (get) Token: 0x0600166B RID: 5739 RVA: 0x00046078 File Offset: 0x00044278
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return StringLoader.AssetFileDescriptorFactory._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000614 RID: 1556
			// (get) Token: 0x0600166C RID: 5740 RVA: 0x0004609C File Offset: 0x0004429C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return StringLoader.AssetFileDescriptorFactory._members.ManagedPeerType;
				}
			}

			// Token: 0x0600166D RID: 5741 RVA: 0x000460A8 File Offset: 0x000442A8
			internal AssetFileDescriptorFactory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x0600166E RID: 5742 RVA: 0x000460B4 File Offset: 0x000442B4
			[Register(".ctor", "()V", "")]
			public AssetFileDescriptorFactory() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(StringLoader.AssetFileDescriptorFactory._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				StringLoader.AssetFileDescriptorFactory._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x0600166F RID: 5743 RVA: 0x00046124 File Offset: 0x00044324
			[Register("build", "(Lcom/bumptech/glide/load/model/MultiModelLoaderFactory;)Lcom/bumptech/glide/load/model/ModelLoader;", "")]
			public unsafe IModelLoader Build(MultiModelLoaderFactory multiFactory)
			{
				IModelLoader @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((multiFactory == null) ? IntPtr.Zero : multiFactory.Handle);
					@object = Java.Lang.Object.GetObject<IModelLoader>(StringLoader.AssetFileDescriptorFactory._members.InstanceMethods.InvokeAbstractObjectMethod("build.(Lcom/bumptech/glide/load/model/MultiModelLoaderFactory;)Lcom/bumptech/glide/load/model/ModelLoader;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(multiFactory);
				}
				return @object;
			}

			// Token: 0x06001670 RID: 5744 RVA: 0x00046198 File Offset: 0x00044398
			[Register("teardown", "()V", "")]
			public void Teardown()
			{
				StringLoader.AssetFileDescriptorFactory._members.InstanceMethods.InvokeAbstractVoidMethod("teardown.()V", this, null);
			}

			// Token: 0x06001671 RID: 5745 RVA: 0x000461B1 File Offset: 0x000443B1
			IModelLoader IModelLoaderFactory.Build(MultiModelLoaderFactory p0)
			{
				return this.Build(p0).JavaCast<IModelLoader>();
			}

			// Token: 0x04000561 RID: 1377
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/model/StringLoader$AssetFileDescriptorFactory", typeof(StringLoader.AssetFileDescriptorFactory));
		}

		// Token: 0x020001D6 RID: 470
		[Register("com/bumptech/glide/load/model/StringLoader$FileDescriptorFactory", DoNotGenerateAcw = true)]
		public class FileDescriptorFactory : Java.Lang.Object, IModelLoaderFactory, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000615 RID: 1557
			// (get) Token: 0x06001673 RID: 5747 RVA: 0x000461DC File Offset: 0x000443DC
			internal static IntPtr class_ref
			{
				get
				{
					return StringLoader.FileDescriptorFactory._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000616 RID: 1558
			// (get) Token: 0x06001674 RID: 5748 RVA: 0x00046200 File Offset: 0x00044400
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return StringLoader.FileDescriptorFactory._members;
				}
			}

			// Token: 0x17000617 RID: 1559
			// (get) Token: 0x06001675 RID: 5749 RVA: 0x00046208 File Offset: 0x00044408
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return StringLoader.FileDescriptorFactory._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000618 RID: 1560
			// (get) Token: 0x06001676 RID: 5750 RVA: 0x0004622C File Offset: 0x0004442C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return StringLoader.FileDescriptorFactory._members.ManagedPeerType;
				}
			}

			// Token: 0x06001677 RID: 5751 RVA: 0x00046238 File Offset: 0x00044438
			protected FileDescriptorFactory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06001678 RID: 5752 RVA: 0x00046244 File Offset: 0x00044444
			[Register(".ctor", "()V", "")]
			public FileDescriptorFactory() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(StringLoader.FileDescriptorFactory._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				StringLoader.FileDescriptorFactory._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x06001679 RID: 5753 RVA: 0x000462B2 File Offset: 0x000444B2
			private static Delegate GetBuild_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_Handler()
			{
				if (StringLoader.FileDescriptorFactory.cb_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_ == null)
				{
					StringLoader.FileDescriptorFactory.cb_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(StringLoader.FileDescriptorFactory.n_Build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_));
				}
				return StringLoader.FileDescriptorFactory.cb_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_;
			}

			// Token: 0x0600167A RID: 5754 RVA: 0x000462D8 File Offset: 0x000444D8
			private static IntPtr n_Build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_(IntPtr jnienv, IntPtr native__this, IntPtr native_multiFactory)
			{
				StringLoader.FileDescriptorFactory @object = Java.Lang.Object.GetObject<StringLoader.FileDescriptorFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				MultiModelLoaderFactory object2 = Java.Lang.Object.GetObject<MultiModelLoaderFactory>(native_multiFactory, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.Build(object2));
			}

			// Token: 0x0600167B RID: 5755 RVA: 0x00046300 File Offset: 0x00044500
			[Register("build", "(Lcom/bumptech/glide/load/model/MultiModelLoaderFactory;)Lcom/bumptech/glide/load/model/ModelLoader;", "GetBuild_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_Handler")]
			public unsafe virtual IModelLoader Build(MultiModelLoaderFactory multiFactory)
			{
				IModelLoader @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((multiFactory == null) ? IntPtr.Zero : multiFactory.Handle);
					@object = Java.Lang.Object.GetObject<IModelLoader>(StringLoader.FileDescriptorFactory._members.InstanceMethods.InvokeVirtualObjectMethod("build.(Lcom/bumptech/glide/load/model/MultiModelLoaderFactory;)Lcom/bumptech/glide/load/model/ModelLoader;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(multiFactory);
				}
				return @object;
			}

			// Token: 0x0600167C RID: 5756 RVA: 0x00046374 File Offset: 0x00044574
			private static Delegate GetTeardownHandler()
			{
				if (StringLoader.FileDescriptorFactory.cb_teardown == null)
				{
					StringLoader.FileDescriptorFactory.cb_teardown = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(StringLoader.FileDescriptorFactory.n_Teardown));
				}
				return StringLoader.FileDescriptorFactory.cb_teardown;
			}

			// Token: 0x0600167D RID: 5757 RVA: 0x00046398 File Offset: 0x00044598
			private static void n_Teardown(IntPtr jnienv, IntPtr native__this)
			{
				Java.Lang.Object.GetObject<StringLoader.FileDescriptorFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Teardown();
			}

			// Token: 0x0600167E RID: 5758 RVA: 0x000463A7 File Offset: 0x000445A7
			[Register("teardown", "()V", "GetTeardownHandler")]
			public virtual void Teardown()
			{
				StringLoader.FileDescriptorFactory._members.InstanceMethods.InvokeVirtualVoidMethod("teardown.()V", this, null);
			}

			// Token: 0x0600167F RID: 5759 RVA: 0x000463C0 File Offset: 0x000445C0
			IModelLoader IModelLoaderFactory.Build(MultiModelLoaderFactory p0)
			{
				return this.Build(p0).JavaCast<IModelLoader>();
			}

			// Token: 0x04000562 RID: 1378
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/model/StringLoader$FileDescriptorFactory", typeof(StringLoader.FileDescriptorFactory));

			// Token: 0x04000563 RID: 1379
			private static Delegate cb_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_;

			// Token: 0x04000564 RID: 1380
			private static Delegate cb_teardown;
		}

		// Token: 0x020001D7 RID: 471
		[Register("com/bumptech/glide/load/model/StringLoader$StreamFactory", DoNotGenerateAcw = true)]
		public class StreamFactory : Java.Lang.Object, IModelLoaderFactory, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000619 RID: 1561
			// (get) Token: 0x06001681 RID: 5761 RVA: 0x000463EC File Offset: 0x000445EC
			internal static IntPtr class_ref
			{
				get
				{
					return StringLoader.StreamFactory._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700061A RID: 1562
			// (get) Token: 0x06001682 RID: 5762 RVA: 0x00046410 File Offset: 0x00044610
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return StringLoader.StreamFactory._members;
				}
			}

			// Token: 0x1700061B RID: 1563
			// (get) Token: 0x06001683 RID: 5763 RVA: 0x00046418 File Offset: 0x00044618
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return StringLoader.StreamFactory._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700061C RID: 1564
			// (get) Token: 0x06001684 RID: 5764 RVA: 0x0004643C File Offset: 0x0004463C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return StringLoader.StreamFactory._members.ManagedPeerType;
				}
			}

			// Token: 0x06001685 RID: 5765 RVA: 0x00046448 File Offset: 0x00044648
			protected StreamFactory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06001686 RID: 5766 RVA: 0x00046454 File Offset: 0x00044654
			[Register(".ctor", "()V", "")]
			public StreamFactory() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(StringLoader.StreamFactory._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				StringLoader.StreamFactory._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x06001687 RID: 5767 RVA: 0x000464C2 File Offset: 0x000446C2
			private static Delegate GetBuild_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_Handler()
			{
				if (StringLoader.StreamFactory.cb_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_ == null)
				{
					StringLoader.StreamFactory.cb_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(StringLoader.StreamFactory.n_Build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_));
				}
				return StringLoader.StreamFactory.cb_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_;
			}

			// Token: 0x06001688 RID: 5768 RVA: 0x000464E8 File Offset: 0x000446E8
			private static IntPtr n_Build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_(IntPtr jnienv, IntPtr native__this, IntPtr native_multiFactory)
			{
				StringLoader.StreamFactory @object = Java.Lang.Object.GetObject<StringLoader.StreamFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				MultiModelLoaderFactory object2 = Java.Lang.Object.GetObject<MultiModelLoaderFactory>(native_multiFactory, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.Build(object2));
			}

			// Token: 0x06001689 RID: 5769 RVA: 0x00046510 File Offset: 0x00044710
			[Register("build", "(Lcom/bumptech/glide/load/model/MultiModelLoaderFactory;)Lcom/bumptech/glide/load/model/ModelLoader;", "GetBuild_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_Handler")]
			public unsafe virtual IModelLoader Build(MultiModelLoaderFactory multiFactory)
			{
				IModelLoader @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((multiFactory == null) ? IntPtr.Zero : multiFactory.Handle);
					@object = Java.Lang.Object.GetObject<IModelLoader>(StringLoader.StreamFactory._members.InstanceMethods.InvokeVirtualObjectMethod("build.(Lcom/bumptech/glide/load/model/MultiModelLoaderFactory;)Lcom/bumptech/glide/load/model/ModelLoader;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(multiFactory);
				}
				return @object;
			}

			// Token: 0x0600168A RID: 5770 RVA: 0x00046584 File Offset: 0x00044784
			private static Delegate GetTeardownHandler()
			{
				if (StringLoader.StreamFactory.cb_teardown == null)
				{
					StringLoader.StreamFactory.cb_teardown = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(StringLoader.StreamFactory.n_Teardown));
				}
				return StringLoader.StreamFactory.cb_teardown;
			}

			// Token: 0x0600168B RID: 5771 RVA: 0x000465A8 File Offset: 0x000447A8
			private static void n_Teardown(IntPtr jnienv, IntPtr native__this)
			{
				Java.Lang.Object.GetObject<StringLoader.StreamFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Teardown();
			}

			// Token: 0x0600168C RID: 5772 RVA: 0x000465B7 File Offset: 0x000447B7
			[Register("teardown", "()V", "GetTeardownHandler")]
			public virtual void Teardown()
			{
				StringLoader.StreamFactory._members.InstanceMethods.InvokeVirtualVoidMethod("teardown.()V", this, null);
			}

			// Token: 0x0600168D RID: 5773 RVA: 0x000465D0 File Offset: 0x000447D0
			IModelLoader IModelLoaderFactory.Build(MultiModelLoaderFactory p0)
			{
				return this.Build(p0).JavaCast<IModelLoader>();
			}

			// Token: 0x04000565 RID: 1381
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/model/StringLoader$StreamFactory", typeof(StringLoader.StreamFactory));

			// Token: 0x04000566 RID: 1382
			private static Delegate cb_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_;

			// Token: 0x04000567 RID: 1383
			private static Delegate cb_teardown;
		}
	}
}
