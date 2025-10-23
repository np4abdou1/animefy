using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;

namespace Bumptech.Glide.Load.Model
{
	// Token: 0x02000129 RID: 297
	[Register("com/bumptech/glide/load/model/FileLoader", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"Data"
	})]
	public class FileLoader : Java.Lang.Object, IModelLoader, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000F2C RID: 3884 RVA: 0x00030D67 File Offset: 0x0002EF67
		public virtual ModelLoaderLoadData BuildLoadData(Java.Lang.Object model, int width, int height, Options options)
		{
			return this.BuildLoadData((File)model, width, height, options);
		}

		// Token: 0x06000F2D RID: 3885 RVA: 0x00030D79 File Offset: 0x0002EF79
		public virtual bool Handles(Java.Lang.Object model)
		{
			return this.Handles((File)model);
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06000F2E RID: 3886 RVA: 0x00030D88 File Offset: 0x0002EF88
		internal static IntPtr class_ref
		{
			get
			{
				return FileLoader._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06000F2F RID: 3887 RVA: 0x00030DAC File Offset: 0x0002EFAC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return FileLoader._members;
			}
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06000F30 RID: 3888 RVA: 0x00030DB4 File Offset: 0x0002EFB4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return FileLoader._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06000F31 RID: 3889 RVA: 0x00030DD8 File Offset: 0x0002EFD8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return FileLoader._members.ManagedPeerType;
			}
		}

		// Token: 0x06000F32 RID: 3890 RVA: 0x00030DE4 File Offset: 0x0002EFE4
		protected FileLoader(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000F33 RID: 3891 RVA: 0x00030DF0 File Offset: 0x0002EFF0
		[Register(".ctor", "(Lcom/bumptech/glide/load/model/FileLoader$FileOpener;)V", "")]
		public unsafe FileLoader(FileLoader.IFileOpener fileOpener) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((fileOpener == null) ? IntPtr.Zero : ((Java.Lang.Object)fileOpener).Handle);
				base.SetHandle(FileLoader._members.InstanceMethods.StartCreateInstance("(Lcom/bumptech/glide/load/model/FileLoader$FileOpener;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				FileLoader._members.InstanceMethods.FinishCreateInstance("(Lcom/bumptech/glide/load/model/FileLoader$FileOpener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(fileOpener);
			}
		}

		// Token: 0x06000F34 RID: 3892 RVA: 0x00030EA4 File Offset: 0x0002F0A4
		private static Delegate GetBuildLoadData_Ljava_io_File_IILcom_bumptech_glide_load_Options_Handler()
		{
			if (FileLoader.cb_buildLoadData_Ljava_io_File_IILcom_bumptech_glide_load_Options_ == null)
			{
				FileLoader.cb_buildLoadData_Ljava_io_File_IILcom_bumptech_glide_load_Options_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIIL_L(FileLoader.n_BuildLoadData_Ljava_io_File_IILcom_bumptech_glide_load_Options_));
			}
			return FileLoader.cb_buildLoadData_Ljava_io_File_IILcom_bumptech_glide_load_Options_;
		}

		// Token: 0x06000F35 RID: 3893 RVA: 0x00030EC8 File Offset: 0x0002F0C8
		private static IntPtr n_BuildLoadData_Ljava_io_File_IILcom_bumptech_glide_load_Options_(IntPtr jnienv, IntPtr native__this, IntPtr native_model, int width, int height, IntPtr native_options)
		{
			FileLoader @object = Java.Lang.Object.GetObject<FileLoader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			File object2 = Java.Lang.Object.GetObject<File>(native_model, JniHandleOwnership.DoNotTransfer);
			Options object3 = Java.Lang.Object.GetObject<Options>(native_options, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.BuildLoadData(object2, width, height, object3));
		}

		// Token: 0x06000F36 RID: 3894 RVA: 0x00030F00 File Offset: 0x0002F100
		[Register("buildLoadData", "(Ljava/io/File;IILcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/model/ModelLoader$LoadData;", "GetBuildLoadData_Ljava_io_File_IILcom_bumptech_glide_load_Options_Handler")]
		public unsafe virtual ModelLoaderLoadData BuildLoadData(File model, int width, int height, Options options)
		{
			ModelLoaderLoadData @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((model == null) ? IntPtr.Zero : model.Handle);
				ptr[1] = new JniArgumentValue(width);
				ptr[2] = new JniArgumentValue(height);
				ptr[3] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				@object = Java.Lang.Object.GetObject<ModelLoaderLoadData>(FileLoader._members.InstanceMethods.InvokeVirtualObjectMethod("buildLoadData.(Ljava/io/File;IILcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/model/ModelLoader$LoadData;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(model);
				GC.KeepAlive(options);
			}
			return @object;
		}

		// Token: 0x06000F37 RID: 3895 RVA: 0x00030FCC File Offset: 0x0002F1CC
		private static Delegate GetHandles_Ljava_io_File_Handler()
		{
			if (FileLoader.cb_handles_Ljava_io_File_ == null)
			{
				FileLoader.cb_handles_Ljava_io_File_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(FileLoader.n_Handles_Ljava_io_File_));
			}
			return FileLoader.cb_handles_Ljava_io_File_;
		}

		// Token: 0x06000F38 RID: 3896 RVA: 0x00030FF0 File Offset: 0x0002F1F0
		private static bool n_Handles_Ljava_io_File_(IntPtr jnienv, IntPtr native__this, IntPtr native_model)
		{
			FileLoader @object = Java.Lang.Object.GetObject<FileLoader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			File object2 = Java.Lang.Object.GetObject<File>(native_model, JniHandleOwnership.DoNotTransfer);
			return @object.Handles(object2);
		}

		// Token: 0x06000F39 RID: 3897 RVA: 0x00031014 File Offset: 0x0002F214
		[Register("handles", "(Ljava/io/File;)Z", "GetHandles_Ljava_io_File_Handler")]
		public unsafe virtual bool Handles(File model)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((model == null) ? IntPtr.Zero : model.Handle);
				result = FileLoader._members.InstanceMethods.InvokeVirtualBooleanMethod("handles.(Ljava/io/File;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(model);
			}
			return result;
		}

		// Token: 0x04000383 RID: 899
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/model/FileLoader", typeof(FileLoader));

		// Token: 0x04000384 RID: 900
		private static Delegate cb_buildLoadData_Ljava_io_File_IILcom_bumptech_glide_load_Options_;

		// Token: 0x04000385 RID: 901
		private static Delegate cb_handles_Ljava_io_File_;

		// Token: 0x020001D8 RID: 472
		[Register("com/bumptech/glide/load/model/FileLoader$Factory", DoNotGenerateAcw = true)]
		[JavaTypeParameters(new string[]
		{
			"Data"
		})]
		public class Factory : Java.Lang.Object, IModelLoaderFactory, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x1700061D RID: 1565
			// (get) Token: 0x0600168F RID: 5775 RVA: 0x000465FC File Offset: 0x000447FC
			internal static IntPtr class_ref
			{
				get
				{
					return FileLoader.Factory._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700061E RID: 1566
			// (get) Token: 0x06001690 RID: 5776 RVA: 0x00046620 File Offset: 0x00044820
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return FileLoader.Factory._members;
				}
			}

			// Token: 0x1700061F RID: 1567
			// (get) Token: 0x06001691 RID: 5777 RVA: 0x00046628 File Offset: 0x00044828
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return FileLoader.Factory._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000620 RID: 1568
			// (get) Token: 0x06001692 RID: 5778 RVA: 0x0004664C File Offset: 0x0004484C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return FileLoader.Factory._members.ManagedPeerType;
				}
			}

			// Token: 0x06001693 RID: 5779 RVA: 0x00046658 File Offset: 0x00044858
			protected Factory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06001694 RID: 5780 RVA: 0x00046664 File Offset: 0x00044864
			[Register(".ctor", "(Lcom/bumptech/glide/load/model/FileLoader$FileOpener;)V", "")]
			public unsafe Factory(FileLoader.IFileOpener opener) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((opener == null) ? IntPtr.Zero : ((Java.Lang.Object)opener).Handle);
					base.SetHandle(FileLoader.Factory._members.InstanceMethods.StartCreateInstance("(Lcom/bumptech/glide/load/model/FileLoader$FileOpener;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					FileLoader.Factory._members.InstanceMethods.FinishCreateInstance("(Lcom/bumptech/glide/load/model/FileLoader$FileOpener;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(opener);
				}
			}

			// Token: 0x06001695 RID: 5781 RVA: 0x00046718 File Offset: 0x00044918
			[Register("build", "(Lcom/bumptech/glide/load/model/MultiModelLoaderFactory;)Lcom/bumptech/glide/load/model/ModelLoader;", "")]
			public unsafe IModelLoader Build(MultiModelLoaderFactory multiFactory)
			{
				IModelLoader @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((multiFactory == null) ? IntPtr.Zero : multiFactory.Handle);
					@object = Java.Lang.Object.GetObject<IModelLoader>(FileLoader.Factory._members.InstanceMethods.InvokeNonvirtualObjectMethod("build.(Lcom/bumptech/glide/load/model/MultiModelLoaderFactory;)Lcom/bumptech/glide/load/model/ModelLoader;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(multiFactory);
				}
				return @object;
			}

			// Token: 0x06001696 RID: 5782 RVA: 0x0004678C File Offset: 0x0004498C
			[Register("teardown", "()V", "")]
			public void Teardown()
			{
				FileLoader.Factory._members.InstanceMethods.InvokeNonvirtualVoidMethod("teardown.()V", this, null);
			}

			// Token: 0x04000568 RID: 1384
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/model/FileLoader$Factory", typeof(FileLoader.Factory));
		}

		// Token: 0x020001D9 RID: 473
		[Register("com/bumptech/glide/load/model/FileLoader$FileDescriptorFactory", DoNotGenerateAcw = true)]
		public class FileDescriptorFactory : FileLoader.Factory
		{
			// Token: 0x17000621 RID: 1569
			// (get) Token: 0x06001698 RID: 5784 RVA: 0x000467C0 File Offset: 0x000449C0
			internal new static IntPtr class_ref
			{
				get
				{
					return FileLoader.FileDescriptorFactory._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000622 RID: 1570
			// (get) Token: 0x06001699 RID: 5785 RVA: 0x000467E4 File Offset: 0x000449E4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return FileLoader.FileDescriptorFactory._members;
				}
			}

			// Token: 0x17000623 RID: 1571
			// (get) Token: 0x0600169A RID: 5786 RVA: 0x000467EC File Offset: 0x000449EC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return FileLoader.FileDescriptorFactory._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000624 RID: 1572
			// (get) Token: 0x0600169B RID: 5787 RVA: 0x00046810 File Offset: 0x00044A10
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return FileLoader.FileDescriptorFactory._members.ManagedPeerType;
				}
			}

			// Token: 0x0600169C RID: 5788 RVA: 0x0004681C File Offset: 0x00044A1C
			protected FileDescriptorFactory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x0600169D RID: 5789 RVA: 0x00046828 File Offset: 0x00044A28
			[Register(".ctor", "()V", "")]
			public FileDescriptorFactory() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(FileLoader.FileDescriptorFactory._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				FileLoader.FileDescriptorFactory._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x04000569 RID: 1385
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/model/FileLoader$FileDescriptorFactory", typeof(FileLoader.FileDescriptorFactory));
		}

		// Token: 0x020001DA RID: 474
		[Register("com/bumptech/glide/load/model/FileLoader$FileOpener", "", "Bumptech.Glide.Load.Model.FileLoader/IFileOpenerInvoker")]
		[JavaTypeParameters(new string[]
		{
			"Data"
		})]
		public interface IFileOpener : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000625 RID: 1573
			// (get) Token: 0x0600169F RID: 5791
			Class DataClass { [Register("getDataClass", "()Ljava/lang/Class;", "GetGetDataClassHandler:Bumptech.Glide.Load.Model.FileLoader/IFileOpenerInvoker, Xamarin.Android.Glide")] get; }

			// Token: 0x060016A0 RID: 5792
			[Register("close", "(Ljava/lang/Object;)V", "GetClose_Ljava_lang_Object_Handler:Bumptech.Glide.Load.Model.FileLoader/IFileOpenerInvoker, Xamarin.Android.Glide")]
			void Close(Java.Lang.Object p0);

			// Token: 0x060016A1 RID: 5793
			[Register("open", "(Ljava/io/File;)Ljava/lang/Object;", "GetOpen_Ljava_io_File_Handler:Bumptech.Glide.Load.Model.FileLoader/IFileOpenerInvoker, Xamarin.Android.Glide")]
			Java.Lang.Object Open(File p0);
		}

		// Token: 0x020001DB RID: 475
		[Register("com/bumptech/glide/load/model/FileLoader$FileOpener", DoNotGenerateAcw = true)]
		internal class IFileOpenerInvoker : Java.Lang.Object, FileLoader.IFileOpener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000626 RID: 1574
			// (get) Token: 0x060016A2 RID: 5794 RVA: 0x000468B4 File Offset: 0x00044AB4
			private static IntPtr java_class_ref
			{
				get
				{
					return FileLoader.IFileOpenerInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000627 RID: 1575
			// (get) Token: 0x060016A3 RID: 5795 RVA: 0x000468D8 File Offset: 0x00044AD8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return FileLoader.IFileOpenerInvoker._members;
				}
			}

			// Token: 0x17000628 RID: 1576
			// (get) Token: 0x060016A4 RID: 5796 RVA: 0x000468DF File Offset: 0x00044ADF
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x17000629 RID: 1577
			// (get) Token: 0x060016A5 RID: 5797 RVA: 0x000468E7 File Offset: 0x00044AE7
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return FileLoader.IFileOpenerInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x060016A6 RID: 5798 RVA: 0x000468F3 File Offset: 0x00044AF3
			public static FileLoader.IFileOpener GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<FileLoader.IFileOpener>(handle, transfer);
			}

			// Token: 0x060016A7 RID: 5799 RVA: 0x000468FC File Offset: 0x00044AFC
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, FileLoader.IFileOpenerInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.bumptech.glide.load.model.FileLoader.FileOpener'.");
				}
				return handle;
			}

			// Token: 0x060016A8 RID: 5800 RVA: 0x00046927 File Offset: 0x00044B27
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x060016A9 RID: 5801 RVA: 0x00046958 File Offset: 0x00044B58
			public IFileOpenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(FileLoader.IFileOpenerInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x060016AA RID: 5802 RVA: 0x00046990 File Offset: 0x00044B90
			private static Delegate GetGetDataClassHandler()
			{
				if (FileLoader.IFileOpenerInvoker.cb_getDataClass == null)
				{
					FileLoader.IFileOpenerInvoker.cb_getDataClass = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(FileLoader.IFileOpenerInvoker.n_GetDataClass));
				}
				return FileLoader.IFileOpenerInvoker.cb_getDataClass;
			}

			// Token: 0x060016AB RID: 5803 RVA: 0x000469B4 File Offset: 0x00044BB4
			private static IntPtr n_GetDataClass(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<FileLoader.IFileOpener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DataClass);
			}

			// Token: 0x1700062A RID: 1578
			// (get) Token: 0x060016AC RID: 5804 RVA: 0x000469C8 File Offset: 0x00044BC8
			public Class DataClass
			{
				get
				{
					if (this.id_getDataClass == IntPtr.Zero)
					{
						this.id_getDataClass = JNIEnv.GetMethodID(this.class_ref, "getDataClass", "()Ljava/lang/Class;");
					}
					return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_getDataClass), JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x060016AD RID: 5805 RVA: 0x00046A19 File Offset: 0x00044C19
			private static Delegate GetClose_Ljava_lang_Object_Handler()
			{
				if (FileLoader.IFileOpenerInvoker.cb_close_Ljava_lang_Object_ == null)
				{
					FileLoader.IFileOpenerInvoker.cb_close_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(FileLoader.IFileOpenerInvoker.n_Close_Ljava_lang_Object_));
				}
				return FileLoader.IFileOpenerInvoker.cb_close_Ljava_lang_Object_;
			}

			// Token: 0x060016AE RID: 5806 RVA: 0x00046A40 File Offset: 0x00044C40
			private static void n_Close_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				FileLoader.IFileOpener @object = Java.Lang.Object.GetObject<FileLoader.IFileOpener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
				@object.Close(object2);
			}

			// Token: 0x060016AF RID: 5807 RVA: 0x00046A64 File Offset: 0x00044C64
			public unsafe void Close(Java.Lang.Object p0)
			{
				if (this.id_close_Ljava_lang_Object_ == IntPtr.Zero)
				{
					this.id_close_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "close", "(Ljava/lang/Object;)V");
				}
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(p0);
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue(intPtr);
				JNIEnv.CallVoidMethod(base.Handle, this.id_close_Ljava_lang_Object_, ptr);
				JNIEnv.DeleteLocalRef(intPtr);
			}

			// Token: 0x060016B0 RID: 5808 RVA: 0x00046AD5 File Offset: 0x00044CD5
			private static Delegate GetOpen_Ljava_io_File_Handler()
			{
				if (FileLoader.IFileOpenerInvoker.cb_open_Ljava_io_File_ == null)
				{
					FileLoader.IFileOpenerInvoker.cb_open_Ljava_io_File_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(FileLoader.IFileOpenerInvoker.n_Open_Ljava_io_File_));
				}
				return FileLoader.IFileOpenerInvoker.cb_open_Ljava_io_File_;
			}

			// Token: 0x060016B1 RID: 5809 RVA: 0x00046AFC File Offset: 0x00044CFC
			private static IntPtr n_Open_Ljava_io_File_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				FileLoader.IFileOpener @object = Java.Lang.Object.GetObject<FileLoader.IFileOpener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				File object2 = Java.Lang.Object.GetObject<File>(native_p0, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.Open(object2));
			}

			// Token: 0x060016B2 RID: 5810 RVA: 0x00046B24 File Offset: 0x00044D24
			public unsafe Java.Lang.Object Open(File p0)
			{
				if (this.id_open_Ljava_io_File_ == IntPtr.Zero)
				{
					this.id_open_Ljava_io_File_ = JNIEnv.GetMethodID(this.class_ref, "open", "(Ljava/io/File;)Ljava/lang/Object;");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_open_Ljava_io_File_, ptr), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x0400056A RID: 1386
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/model/FileLoader$FileOpener", typeof(FileLoader.IFileOpenerInvoker));

			// Token: 0x0400056B RID: 1387
			private IntPtr class_ref;

			// Token: 0x0400056C RID: 1388
			private static Delegate cb_getDataClass;

			// Token: 0x0400056D RID: 1389
			private IntPtr id_getDataClass;

			// Token: 0x0400056E RID: 1390
			private static Delegate cb_close_Ljava_lang_Object_;

			// Token: 0x0400056F RID: 1391
			private IntPtr id_close_Ljava_lang_Object_;

			// Token: 0x04000570 RID: 1392
			private static Delegate cb_open_Ljava_io_File_;

			// Token: 0x04000571 RID: 1393
			private IntPtr id_open_Ljava_io_File_;
		}

		// Token: 0x020001DC RID: 476
		[Register("com/bumptech/glide/load/model/FileLoader$StreamFactory", DoNotGenerateAcw = true)]
		public class StreamFactory : FileLoader.Factory
		{
			// Token: 0x1700062B RID: 1579
			// (get) Token: 0x060016B4 RID: 5812 RVA: 0x00046BB8 File Offset: 0x00044DB8
			internal new static IntPtr class_ref
			{
				get
				{
					return FileLoader.StreamFactory._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700062C RID: 1580
			// (get) Token: 0x060016B5 RID: 5813 RVA: 0x00046BDC File Offset: 0x00044DDC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return FileLoader.StreamFactory._members;
				}
			}

			// Token: 0x1700062D RID: 1581
			// (get) Token: 0x060016B6 RID: 5814 RVA: 0x00046BE4 File Offset: 0x00044DE4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return FileLoader.StreamFactory._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700062E RID: 1582
			// (get) Token: 0x060016B7 RID: 5815 RVA: 0x00046C08 File Offset: 0x00044E08
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return FileLoader.StreamFactory._members.ManagedPeerType;
				}
			}

			// Token: 0x060016B8 RID: 5816 RVA: 0x00046C14 File Offset: 0x00044E14
			protected StreamFactory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x060016B9 RID: 5817 RVA: 0x00046C20 File Offset: 0x00044E20
			[Register(".ctor", "()V", "")]
			public StreamFactory() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(FileLoader.StreamFactory._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				FileLoader.StreamFactory._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x04000572 RID: 1394
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/model/FileLoader$StreamFactory", typeof(FileLoader.StreamFactory));
		}
	}
}
