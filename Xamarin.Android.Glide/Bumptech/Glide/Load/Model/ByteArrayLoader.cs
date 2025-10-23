using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Model
{
	// Token: 0x02000127 RID: 295
	[Register("com/bumptech/glide/load/model/ByteArrayLoader", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"Data"
	})]
	public class ByteArrayLoader : Java.Lang.Object, IModelLoader, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000F0E RID: 3854 RVA: 0x000306BF File Offset: 0x0002E8BF
		public virtual ModelLoaderLoadData BuildLoadData(Java.Lang.Object model, int width, int height, Options options)
		{
			return this.BuildLoadData((model != null) ? model.ToArray<byte>() : null, width, height, options);
		}

		// Token: 0x06000F0F RID: 3855 RVA: 0x000306D7 File Offset: 0x0002E8D7
		public virtual bool Handles(Java.Lang.Object model)
		{
			return this.Handles((model != null) ? model.ToArray<byte>() : null);
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06000F10 RID: 3856 RVA: 0x000306EC File Offset: 0x0002E8EC
		internal static IntPtr class_ref
		{
			get
			{
				return ByteArrayLoader._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06000F11 RID: 3857 RVA: 0x00030710 File Offset: 0x0002E910
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ByteArrayLoader._members;
			}
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06000F12 RID: 3858 RVA: 0x00030718 File Offset: 0x0002E918
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ByteArrayLoader._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06000F13 RID: 3859 RVA: 0x0003073C File Offset: 0x0002E93C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ByteArrayLoader._members.ManagedPeerType;
			}
		}

		// Token: 0x06000F14 RID: 3860 RVA: 0x00030748 File Offset: 0x0002E948
		protected ByteArrayLoader(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000F15 RID: 3861 RVA: 0x00030754 File Offset: 0x0002E954
		[Register(".ctor", "(Lcom/bumptech/glide/load/model/ByteArrayLoader$Converter;)V", "")]
		public unsafe ByteArrayLoader(ByteArrayLoader.IConverter converter) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((converter == null) ? IntPtr.Zero : ((Java.Lang.Object)converter).Handle);
				base.SetHandle(ByteArrayLoader._members.InstanceMethods.StartCreateInstance("(Lcom/bumptech/glide/load/model/ByteArrayLoader$Converter;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ByteArrayLoader._members.InstanceMethods.FinishCreateInstance("(Lcom/bumptech/glide/load/model/ByteArrayLoader$Converter;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(converter);
			}
		}

		// Token: 0x06000F16 RID: 3862 RVA: 0x00030808 File Offset: 0x0002EA08
		private static Delegate GetBuildLoadData_arrayBIILcom_bumptech_glide_load_Options_Handler()
		{
			if (ByteArrayLoader.cb_buildLoadData_arrayBIILcom_bumptech_glide_load_Options_ == null)
			{
				ByteArrayLoader.cb_buildLoadData_arrayBIILcom_bumptech_glide_load_Options_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIIL_L(ByteArrayLoader.n_BuildLoadData_arrayBIILcom_bumptech_glide_load_Options_));
			}
			return ByteArrayLoader.cb_buildLoadData_arrayBIILcom_bumptech_glide_load_Options_;
		}

		// Token: 0x06000F17 RID: 3863 RVA: 0x0003082C File Offset: 0x0002EA2C
		private static IntPtr n_BuildLoadData_arrayBIILcom_bumptech_glide_load_Options_(IntPtr jnienv, IntPtr native__this, IntPtr native_model, int width, int height, IntPtr native_options)
		{
			ByteArrayLoader @object = Java.Lang.Object.GetObject<ByteArrayLoader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] array = (byte[])JNIEnv.GetArray(native_model, JniHandleOwnership.DoNotTransfer, typeof(byte));
			Options object2 = Java.Lang.Object.GetObject<Options>(native_options, JniHandleOwnership.DoNotTransfer);
			IntPtr result = JNIEnv.ToLocalJniHandle(@object.BuildLoadData(array, width, height, object2));
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_model);
			}
			return result;
		}

		// Token: 0x06000F18 RID: 3864 RVA: 0x0003087C File Offset: 0x0002EA7C
		[Register("buildLoadData", "([BIILcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/model/ModelLoader$LoadData;", "GetBuildLoadData_arrayBIILcom_bumptech_glide_load_Options_Handler")]
		public unsafe virtual ModelLoaderLoadData BuildLoadData(byte[] model, int width, int height, Options options)
		{
			IntPtr intPtr = JNIEnv.NewArray(model);
			ModelLoaderLoadData @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(width);
				ptr[2] = new JniArgumentValue(height);
				ptr[3] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				@object = Java.Lang.Object.GetObject<ModelLoaderLoadData>(ByteArrayLoader._members.InstanceMethods.InvokeVirtualObjectMethod("buildLoadData.([BIILcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/model/ModelLoader$LoadData;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (model != null)
				{
					JNIEnv.CopyArray(intPtr, model);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(model);
				GC.KeepAlive(options);
			}
			return @object;
		}

		// Token: 0x06000F19 RID: 3865 RVA: 0x00030950 File Offset: 0x0002EB50
		private static Delegate GetHandles_arrayBHandler()
		{
			if (ByteArrayLoader.cb_handles_arrayB == null)
			{
				ByteArrayLoader.cb_handles_arrayB = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(ByteArrayLoader.n_Handles_arrayB));
			}
			return ByteArrayLoader.cb_handles_arrayB;
		}

		// Token: 0x06000F1A RID: 3866 RVA: 0x00030974 File Offset: 0x0002EB74
		private static bool n_Handles_arrayB(IntPtr jnienv, IntPtr native__this, IntPtr native_model)
		{
			ByteArrayLoader @object = Java.Lang.Object.GetObject<ByteArrayLoader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] array = (byte[])JNIEnv.GetArray(native_model, JniHandleOwnership.DoNotTransfer, typeof(byte));
			bool result = @object.Handles(array);
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_model);
			}
			return result;
		}

		// Token: 0x06000F1B RID: 3867 RVA: 0x000309B0 File Offset: 0x0002EBB0
		[Register("handles", "([B)Z", "GetHandles_arrayBHandler")]
		public unsafe virtual bool Handles(byte[] model)
		{
			IntPtr intPtr = JNIEnv.NewArray(model);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = ByteArrayLoader._members.InstanceMethods.InvokeVirtualBooleanMethod("handles.([B)Z", this, ptr);
			}
			finally
			{
				if (model != null)
				{
					JNIEnv.CopyArray(intPtr, model);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(model);
			}
			return result;
		}

		// Token: 0x0400037D RID: 893
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/model/ByteArrayLoader", typeof(ByteArrayLoader));

		// Token: 0x0400037E RID: 894
		private static Delegate cb_buildLoadData_arrayBIILcom_bumptech_glide_load_Options_;

		// Token: 0x0400037F RID: 895
		private static Delegate cb_handles_arrayB;

		// Token: 0x020001D1 RID: 465
		[Register("com/bumptech/glide/load/model/ByteArrayLoader$ByteBufferFactory", DoNotGenerateAcw = true)]
		public class ByteBufferFactory : Java.Lang.Object, IModelLoaderFactory, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000603 RID: 1539
			// (get) Token: 0x0600163C RID: 5692 RVA: 0x000459C0 File Offset: 0x00043BC0
			internal static IntPtr class_ref
			{
				get
				{
					return ByteArrayLoader.ByteBufferFactory._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000604 RID: 1540
			// (get) Token: 0x0600163D RID: 5693 RVA: 0x000459E4 File Offset: 0x00043BE4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ByteArrayLoader.ByteBufferFactory._members;
				}
			}

			// Token: 0x17000605 RID: 1541
			// (get) Token: 0x0600163E RID: 5694 RVA: 0x000459EC File Offset: 0x00043BEC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return ByteArrayLoader.ByteBufferFactory._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000606 RID: 1542
			// (get) Token: 0x0600163F RID: 5695 RVA: 0x00045A10 File Offset: 0x00043C10
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ByteArrayLoader.ByteBufferFactory._members.ManagedPeerType;
				}
			}

			// Token: 0x06001640 RID: 5696 RVA: 0x00045A1C File Offset: 0x00043C1C
			protected ByteBufferFactory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06001641 RID: 5697 RVA: 0x00045A28 File Offset: 0x00043C28
			[Register(".ctor", "()V", "")]
			public ByteBufferFactory() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(ByteArrayLoader.ByteBufferFactory._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				ByteArrayLoader.ByteBufferFactory._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x06001642 RID: 5698 RVA: 0x00045A96 File Offset: 0x00043C96
			private static Delegate GetBuild_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_Handler()
			{
				if (ByteArrayLoader.ByteBufferFactory.cb_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_ == null)
				{
					ByteArrayLoader.ByteBufferFactory.cb_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ByteArrayLoader.ByteBufferFactory.n_Build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_));
				}
				return ByteArrayLoader.ByteBufferFactory.cb_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_;
			}

			// Token: 0x06001643 RID: 5699 RVA: 0x00045ABC File Offset: 0x00043CBC
			private static IntPtr n_Build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_(IntPtr jnienv, IntPtr native__this, IntPtr native_multiFactory)
			{
				ByteArrayLoader.ByteBufferFactory @object = Java.Lang.Object.GetObject<ByteArrayLoader.ByteBufferFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				MultiModelLoaderFactory object2 = Java.Lang.Object.GetObject<MultiModelLoaderFactory>(native_multiFactory, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.Build(object2));
			}

			// Token: 0x06001644 RID: 5700 RVA: 0x00045AE4 File Offset: 0x00043CE4
			[Register("build", "(Lcom/bumptech/glide/load/model/MultiModelLoaderFactory;)Lcom/bumptech/glide/load/model/ModelLoader;", "GetBuild_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_Handler")]
			public unsafe virtual IModelLoader Build(MultiModelLoaderFactory multiFactory)
			{
				IModelLoader @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((multiFactory == null) ? IntPtr.Zero : multiFactory.Handle);
					@object = Java.Lang.Object.GetObject<IModelLoader>(ByteArrayLoader.ByteBufferFactory._members.InstanceMethods.InvokeVirtualObjectMethod("build.(Lcom/bumptech/glide/load/model/MultiModelLoaderFactory;)Lcom/bumptech/glide/load/model/ModelLoader;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(multiFactory);
				}
				return @object;
			}

			// Token: 0x06001645 RID: 5701 RVA: 0x00045B58 File Offset: 0x00043D58
			private static Delegate GetTeardownHandler()
			{
				if (ByteArrayLoader.ByteBufferFactory.cb_teardown == null)
				{
					ByteArrayLoader.ByteBufferFactory.cb_teardown = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ByteArrayLoader.ByteBufferFactory.n_Teardown));
				}
				return ByteArrayLoader.ByteBufferFactory.cb_teardown;
			}

			// Token: 0x06001646 RID: 5702 RVA: 0x00045B7C File Offset: 0x00043D7C
			private static void n_Teardown(IntPtr jnienv, IntPtr native__this)
			{
				Java.Lang.Object.GetObject<ByteArrayLoader.ByteBufferFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Teardown();
			}

			// Token: 0x06001647 RID: 5703 RVA: 0x00045B8B File Offset: 0x00043D8B
			[Register("teardown", "()V", "GetTeardownHandler")]
			public virtual void Teardown()
			{
				ByteArrayLoader.ByteBufferFactory._members.InstanceMethods.InvokeVirtualVoidMethod("teardown.()V", this, null);
			}

			// Token: 0x06001648 RID: 5704 RVA: 0x00045BA4 File Offset: 0x00043DA4
			IModelLoader IModelLoaderFactory.Build(MultiModelLoaderFactory p0)
			{
				return this.Build(p0).JavaCast<IModelLoader>();
			}

			// Token: 0x04000555 RID: 1365
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/model/ByteArrayLoader$ByteBufferFactory", typeof(ByteArrayLoader.ByteBufferFactory));

			// Token: 0x04000556 RID: 1366
			private static Delegate cb_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_;

			// Token: 0x04000557 RID: 1367
			private static Delegate cb_teardown;
		}

		// Token: 0x020001D2 RID: 466
		[Register("com/bumptech/glide/load/model/ByteArrayLoader$Converter", "", "Bumptech.Glide.Load.Model.ByteArrayLoader/IConverterInvoker")]
		[JavaTypeParameters(new string[]
		{
			"Data"
		})]
		public interface IConverter : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000607 RID: 1543
			// (get) Token: 0x0600164A RID: 5706
			Class DataClass { [Register("getDataClass", "()Ljava/lang/Class;", "GetGetDataClassHandler:Bumptech.Glide.Load.Model.ByteArrayLoader/IConverterInvoker, Xamarin.Android.Glide")] get; }

			// Token: 0x0600164B RID: 5707
			[Register("convert", "([B)Ljava/lang/Object;", "GetConvert_arrayBHandler:Bumptech.Glide.Load.Model.ByteArrayLoader/IConverterInvoker, Xamarin.Android.Glide")]
			Java.Lang.Object Convert(byte[] p0);
		}

		// Token: 0x020001D3 RID: 467
		[Register("com/bumptech/glide/load/model/ByteArrayLoader$Converter", DoNotGenerateAcw = true)]
		internal class IConverterInvoker : Java.Lang.Object, ByteArrayLoader.IConverter, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000608 RID: 1544
			// (get) Token: 0x0600164C RID: 5708 RVA: 0x00045BD0 File Offset: 0x00043DD0
			private static IntPtr java_class_ref
			{
				get
				{
					return ByteArrayLoader.IConverterInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000609 RID: 1545
			// (get) Token: 0x0600164D RID: 5709 RVA: 0x00045BF4 File Offset: 0x00043DF4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ByteArrayLoader.IConverterInvoker._members;
				}
			}

			// Token: 0x1700060A RID: 1546
			// (get) Token: 0x0600164E RID: 5710 RVA: 0x00045BFB File Offset: 0x00043DFB
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x1700060B RID: 1547
			// (get) Token: 0x0600164F RID: 5711 RVA: 0x00045C03 File Offset: 0x00043E03
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ByteArrayLoader.IConverterInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06001650 RID: 5712 RVA: 0x00045C0F File Offset: 0x00043E0F
			public static ByteArrayLoader.IConverter GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<ByteArrayLoader.IConverter>(handle, transfer);
			}

			// Token: 0x06001651 RID: 5713 RVA: 0x00045C18 File Offset: 0x00043E18
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, ByteArrayLoader.IConverterInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.bumptech.glide.load.model.ByteArrayLoader.Converter'.");
				}
				return handle;
			}

			// Token: 0x06001652 RID: 5714 RVA: 0x00045C43 File Offset: 0x00043E43
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06001653 RID: 5715 RVA: 0x00045C74 File Offset: 0x00043E74
			public IConverterInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ByteArrayLoader.IConverterInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x06001654 RID: 5716 RVA: 0x00045CAC File Offset: 0x00043EAC
			private static Delegate GetGetDataClassHandler()
			{
				if (ByteArrayLoader.IConverterInvoker.cb_getDataClass == null)
				{
					ByteArrayLoader.IConverterInvoker.cb_getDataClass = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ByteArrayLoader.IConverterInvoker.n_GetDataClass));
				}
				return ByteArrayLoader.IConverterInvoker.cb_getDataClass;
			}

			// Token: 0x06001655 RID: 5717 RVA: 0x00045CD0 File Offset: 0x00043ED0
			private static IntPtr n_GetDataClass(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ByteArrayLoader.IConverter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DataClass);
			}

			// Token: 0x1700060C RID: 1548
			// (get) Token: 0x06001656 RID: 5718 RVA: 0x00045CE4 File Offset: 0x00043EE4
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

			// Token: 0x06001657 RID: 5719 RVA: 0x00045D35 File Offset: 0x00043F35
			private static Delegate GetConvert_arrayBHandler()
			{
				if (ByteArrayLoader.IConverterInvoker.cb_convert_arrayB == null)
				{
					ByteArrayLoader.IConverterInvoker.cb_convert_arrayB = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ByteArrayLoader.IConverterInvoker.n_Convert_arrayB));
				}
				return ByteArrayLoader.IConverterInvoker.cb_convert_arrayB;
			}

			// Token: 0x06001658 RID: 5720 RVA: 0x00045D5C File Offset: 0x00043F5C
			private static IntPtr n_Convert_arrayB(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				ByteArrayLoader.IConverter @object = Java.Lang.Object.GetObject<ByteArrayLoader.IConverter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				byte[] array = (byte[])JNIEnv.GetArray(native_p0, JniHandleOwnership.DoNotTransfer, typeof(byte));
				IntPtr result = JNIEnv.ToLocalJniHandle(@object.Convert(array));
				if (array != null)
				{
					JNIEnv.CopyArray(array, native_p0);
				}
				return result;
			}

			// Token: 0x06001659 RID: 5721 RVA: 0x00045DA0 File Offset: 0x00043FA0
			public unsafe Java.Lang.Object Convert(byte[] p0)
			{
				if (this.id_convert_arrayB == IntPtr.Zero)
				{
					this.id_convert_arrayB = JNIEnv.GetMethodID(this.class_ref, "convert", "([B)Ljava/lang/Object;");
				}
				IntPtr intPtr = JNIEnv.NewArray(p0);
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue(intPtr);
				Java.Lang.Object @object = Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_convert_arrayB, ptr), JniHandleOwnership.TransferLocalRef);
				if (p0 != null)
				{
					JNIEnv.CopyArray(intPtr, p0);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x04000558 RID: 1368
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/model/ByteArrayLoader$Converter", typeof(ByteArrayLoader.IConverterInvoker));

			// Token: 0x04000559 RID: 1369
			private IntPtr class_ref;

			// Token: 0x0400055A RID: 1370
			private static Delegate cb_getDataClass;

			// Token: 0x0400055B RID: 1371
			private IntPtr id_getDataClass;

			// Token: 0x0400055C RID: 1372
			private static Delegate cb_convert_arrayB;

			// Token: 0x0400055D RID: 1373
			private IntPtr id_convert_arrayB;
		}

		// Token: 0x020001D4 RID: 468
		[Register("com/bumptech/glide/load/model/ByteArrayLoader$StreamFactory", DoNotGenerateAcw = true)]
		public class StreamFactory : Java.Lang.Object, IModelLoaderFactory, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x1700060D RID: 1549
			// (get) Token: 0x0600165B RID: 5723 RVA: 0x00045E3C File Offset: 0x0004403C
			internal static IntPtr class_ref
			{
				get
				{
					return ByteArrayLoader.StreamFactory._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700060E RID: 1550
			// (get) Token: 0x0600165C RID: 5724 RVA: 0x00045E60 File Offset: 0x00044060
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ByteArrayLoader.StreamFactory._members;
				}
			}

			// Token: 0x1700060F RID: 1551
			// (get) Token: 0x0600165D RID: 5725 RVA: 0x00045E68 File Offset: 0x00044068
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return ByteArrayLoader.StreamFactory._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000610 RID: 1552
			// (get) Token: 0x0600165E RID: 5726 RVA: 0x00045E8C File Offset: 0x0004408C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ByteArrayLoader.StreamFactory._members.ManagedPeerType;
				}
			}

			// Token: 0x0600165F RID: 5727 RVA: 0x00045E98 File Offset: 0x00044098
			protected StreamFactory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06001660 RID: 5728 RVA: 0x00045EA4 File Offset: 0x000440A4
			[Register(".ctor", "()V", "")]
			public StreamFactory() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(ByteArrayLoader.StreamFactory._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				ByteArrayLoader.StreamFactory._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x06001661 RID: 5729 RVA: 0x00045F12 File Offset: 0x00044112
			private static Delegate GetBuild_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_Handler()
			{
				if (ByteArrayLoader.StreamFactory.cb_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_ == null)
				{
					ByteArrayLoader.StreamFactory.cb_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ByteArrayLoader.StreamFactory.n_Build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_));
				}
				return ByteArrayLoader.StreamFactory.cb_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_;
			}

			// Token: 0x06001662 RID: 5730 RVA: 0x00045F38 File Offset: 0x00044138
			private static IntPtr n_Build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_(IntPtr jnienv, IntPtr native__this, IntPtr native_multiFactory)
			{
				ByteArrayLoader.StreamFactory @object = Java.Lang.Object.GetObject<ByteArrayLoader.StreamFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				MultiModelLoaderFactory object2 = Java.Lang.Object.GetObject<MultiModelLoaderFactory>(native_multiFactory, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.Build(object2));
			}

			// Token: 0x06001663 RID: 5731 RVA: 0x00045F60 File Offset: 0x00044160
			[Register("build", "(Lcom/bumptech/glide/load/model/MultiModelLoaderFactory;)Lcom/bumptech/glide/load/model/ModelLoader;", "GetBuild_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_Handler")]
			public unsafe virtual IModelLoader Build(MultiModelLoaderFactory multiFactory)
			{
				IModelLoader @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((multiFactory == null) ? IntPtr.Zero : multiFactory.Handle);
					@object = Java.Lang.Object.GetObject<IModelLoader>(ByteArrayLoader.StreamFactory._members.InstanceMethods.InvokeVirtualObjectMethod("build.(Lcom/bumptech/glide/load/model/MultiModelLoaderFactory;)Lcom/bumptech/glide/load/model/ModelLoader;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(multiFactory);
				}
				return @object;
			}

			// Token: 0x06001664 RID: 5732 RVA: 0x00045FD4 File Offset: 0x000441D4
			private static Delegate GetTeardownHandler()
			{
				if (ByteArrayLoader.StreamFactory.cb_teardown == null)
				{
					ByteArrayLoader.StreamFactory.cb_teardown = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ByteArrayLoader.StreamFactory.n_Teardown));
				}
				return ByteArrayLoader.StreamFactory.cb_teardown;
			}

			// Token: 0x06001665 RID: 5733 RVA: 0x00045FF8 File Offset: 0x000441F8
			private static void n_Teardown(IntPtr jnienv, IntPtr native__this)
			{
				Java.Lang.Object.GetObject<ByteArrayLoader.StreamFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Teardown();
			}

			// Token: 0x06001666 RID: 5734 RVA: 0x00046007 File Offset: 0x00044207
			[Register("teardown", "()V", "GetTeardownHandler")]
			public virtual void Teardown()
			{
				ByteArrayLoader.StreamFactory._members.InstanceMethods.InvokeVirtualVoidMethod("teardown.()V", this, null);
			}

			// Token: 0x06001667 RID: 5735 RVA: 0x00046020 File Offset: 0x00044220
			IModelLoader IModelLoaderFactory.Build(MultiModelLoaderFactory p0)
			{
				return this.Build(p0).JavaCast<IModelLoader>();
			}

			// Token: 0x0400055E RID: 1374
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/model/ByteArrayLoader$StreamFactory", typeof(ByteArrayLoader.StreamFactory));

			// Token: 0x0400055F RID: 1375
			private static Delegate cb_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_;

			// Token: 0x04000560 RID: 1376
			private static Delegate cb_teardown;
		}
	}
}
