using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Model
{
	// Token: 0x0200012F RID: 303
	[Register("com/bumptech/glide/load/model/DataUrlLoader", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"Model",
		"Data"
	})]
	public sealed class DataUrlLoader : Java.Lang.Object, IModelLoader, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06000F82 RID: 3970 RVA: 0x00031F58 File Offset: 0x00030158
		internal static IntPtr class_ref
		{
			get
			{
				return DataUrlLoader._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06000F83 RID: 3971 RVA: 0x00031F7C File Offset: 0x0003017C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DataUrlLoader._members;
			}
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06000F84 RID: 3972 RVA: 0x00031F84 File Offset: 0x00030184
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DataUrlLoader._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06000F85 RID: 3973 RVA: 0x00031FA8 File Offset: 0x000301A8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DataUrlLoader._members.ManagedPeerType;
			}
		}

		// Token: 0x06000F86 RID: 3974 RVA: 0x00031FB4 File Offset: 0x000301B4
		internal DataUrlLoader(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000F87 RID: 3975 RVA: 0x00031FC0 File Offset: 0x000301C0
		[Register(".ctor", "(Lcom/bumptech/glide/load/model/DataUrlLoader$DataDecoder;)V", "")]
		public unsafe DataUrlLoader(DataUrlLoader.IDataDecoder dataDecoder) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((dataDecoder == null) ? IntPtr.Zero : ((Java.Lang.Object)dataDecoder).Handle);
				base.SetHandle(DataUrlLoader._members.InstanceMethods.StartCreateInstance("(Lcom/bumptech/glide/load/model/DataUrlLoader$DataDecoder;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				DataUrlLoader._members.InstanceMethods.FinishCreateInstance("(Lcom/bumptech/glide/load/model/DataUrlLoader$DataDecoder;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(dataDecoder);
			}
		}

		// Token: 0x06000F88 RID: 3976 RVA: 0x00032074 File Offset: 0x00030274
		[Register("buildLoadData", "(Ljava/lang/Object;IILcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/model/ModelLoader$LoadData;", "")]
		public unsafe ModelLoaderLoadData BuildLoadData(Java.Lang.Object model, int width, int height, Options options)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(model);
			ModelLoaderLoadData @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(width);
				ptr[2] = new JniArgumentValue(height);
				ptr[3] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				@object = Java.Lang.Object.GetObject<ModelLoaderLoadData>(DataUrlLoader._members.InstanceMethods.InvokeAbstractObjectMethod("buildLoadData.(Ljava/lang/Object;IILcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/model/ModelLoader$LoadData;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(model);
				GC.KeepAlive(options);
			}
			return @object;
		}

		// Token: 0x06000F89 RID: 3977 RVA: 0x0003213C File Offset: 0x0003033C
		[Register("handles", "(Ljava/lang/Object;)Z", "")]
		public unsafe bool Handles(Java.Lang.Object model)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(model);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = DataUrlLoader._members.InstanceMethods.InvokeAbstractBooleanMethod("handles.(Ljava/lang/Object;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(model);
			}
			return result;
		}

		// Token: 0x04000394 RID: 916
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/model/DataUrlLoader", typeof(DataUrlLoader));

		// Token: 0x020001E8 RID: 488
		[Register("com/bumptech/glide/load/model/DataUrlLoader$DataDecoder", "", "Bumptech.Glide.Load.Model.DataUrlLoader/IDataDecoderInvoker")]
		[JavaTypeParameters(new string[]
		{
			"Data"
		})]
		public interface IDataDecoder : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000657 RID: 1623
			// (get) Token: 0x06001748 RID: 5960
			Class DataClass { [Register("getDataClass", "()Ljava/lang/Class;", "GetGetDataClassHandler:Bumptech.Glide.Load.Model.DataUrlLoader/IDataDecoderInvoker, Xamarin.Android.Glide")] get; }

			// Token: 0x06001749 RID: 5961
			[Register("close", "(Ljava/lang/Object;)V", "GetClose_Ljava_lang_Object_Handler:Bumptech.Glide.Load.Model.DataUrlLoader/IDataDecoderInvoker, Xamarin.Android.Glide")]
			void Close(Java.Lang.Object p0);

			// Token: 0x0600174A RID: 5962
			[Register("decode", "(Ljava/lang/String;)Ljava/lang/Object;", "GetDecode_Ljava_lang_String_Handler:Bumptech.Glide.Load.Model.DataUrlLoader/IDataDecoderInvoker, Xamarin.Android.Glide")]
			Java.Lang.Object Decode(string p0);
		}

		// Token: 0x020001E9 RID: 489
		[Register("com/bumptech/glide/load/model/DataUrlLoader$DataDecoder", DoNotGenerateAcw = true)]
		internal class IDataDecoderInvoker : Java.Lang.Object, DataUrlLoader.IDataDecoder, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000658 RID: 1624
			// (get) Token: 0x0600174B RID: 5963 RVA: 0x000483D0 File Offset: 0x000465D0
			private static IntPtr java_class_ref
			{
				get
				{
					return DataUrlLoader.IDataDecoderInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000659 RID: 1625
			// (get) Token: 0x0600174C RID: 5964 RVA: 0x000483F4 File Offset: 0x000465F4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return DataUrlLoader.IDataDecoderInvoker._members;
				}
			}

			// Token: 0x1700065A RID: 1626
			// (get) Token: 0x0600174D RID: 5965 RVA: 0x000483FB File Offset: 0x000465FB
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x1700065B RID: 1627
			// (get) Token: 0x0600174E RID: 5966 RVA: 0x00048403 File Offset: 0x00046603
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return DataUrlLoader.IDataDecoderInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x0600174F RID: 5967 RVA: 0x0004840F File Offset: 0x0004660F
			public static DataUrlLoader.IDataDecoder GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<DataUrlLoader.IDataDecoder>(handle, transfer);
			}

			// Token: 0x06001750 RID: 5968 RVA: 0x00048418 File Offset: 0x00046618
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, DataUrlLoader.IDataDecoderInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.bumptech.glide.load.model.DataUrlLoader.DataDecoder'.");
				}
				return handle;
			}

			// Token: 0x06001751 RID: 5969 RVA: 0x00048443 File Offset: 0x00046643
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06001752 RID: 5970 RVA: 0x00048474 File Offset: 0x00046674
			public IDataDecoderInvoker(IntPtr handle, JniHandleOwnership transfer) : base(DataUrlLoader.IDataDecoderInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x06001753 RID: 5971 RVA: 0x000484AC File Offset: 0x000466AC
			private static Delegate GetGetDataClassHandler()
			{
				if (DataUrlLoader.IDataDecoderInvoker.cb_getDataClass == null)
				{
					DataUrlLoader.IDataDecoderInvoker.cb_getDataClass = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(DataUrlLoader.IDataDecoderInvoker.n_GetDataClass));
				}
				return DataUrlLoader.IDataDecoderInvoker.cb_getDataClass;
			}

			// Token: 0x06001754 RID: 5972 RVA: 0x000484D0 File Offset: 0x000466D0
			private static IntPtr n_GetDataClass(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<DataUrlLoader.IDataDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DataClass);
			}

			// Token: 0x1700065C RID: 1628
			// (get) Token: 0x06001755 RID: 5973 RVA: 0x000484E4 File Offset: 0x000466E4
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

			// Token: 0x06001756 RID: 5974 RVA: 0x00048535 File Offset: 0x00046735
			private static Delegate GetClose_Ljava_lang_Object_Handler()
			{
				if (DataUrlLoader.IDataDecoderInvoker.cb_close_Ljava_lang_Object_ == null)
				{
					DataUrlLoader.IDataDecoderInvoker.cb_close_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(DataUrlLoader.IDataDecoderInvoker.n_Close_Ljava_lang_Object_));
				}
				return DataUrlLoader.IDataDecoderInvoker.cb_close_Ljava_lang_Object_;
			}

			// Token: 0x06001757 RID: 5975 RVA: 0x0004855C File Offset: 0x0004675C
			private static void n_Close_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				DataUrlLoader.IDataDecoder @object = Java.Lang.Object.GetObject<DataUrlLoader.IDataDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
				@object.Close(object2);
			}

			// Token: 0x06001758 RID: 5976 RVA: 0x00048580 File Offset: 0x00046780
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

			// Token: 0x06001759 RID: 5977 RVA: 0x000485F1 File Offset: 0x000467F1
			private static Delegate GetDecode_Ljava_lang_String_Handler()
			{
				if (DataUrlLoader.IDataDecoderInvoker.cb_decode_Ljava_lang_String_ == null)
				{
					DataUrlLoader.IDataDecoderInvoker.cb_decode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(DataUrlLoader.IDataDecoderInvoker.n_Decode_Ljava_lang_String_));
				}
				return DataUrlLoader.IDataDecoderInvoker.cb_decode_Ljava_lang_String_;
			}

			// Token: 0x0600175A RID: 5978 RVA: 0x00048618 File Offset: 0x00046818
			private static IntPtr n_Decode_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				DataUrlLoader.IDataDecoder @object = Java.Lang.Object.GetObject<DataUrlLoader.IDataDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.Decode(@string));
			}

			// Token: 0x0600175B RID: 5979 RVA: 0x00048640 File Offset: 0x00046840
			public unsafe Java.Lang.Object Decode(string p0)
			{
				if (this.id_decode_Ljava_lang_String_ == IntPtr.Zero)
				{
					this.id_decode_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "decode", "(Ljava/lang/String;)Ljava/lang/Object;");
				}
				IntPtr intPtr = JNIEnv.NewString(p0);
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue(intPtr);
				Java.Lang.Object @object = Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_decode_Ljava_lang_String_, ptr), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef(intPtr);
				return @object;
			}

			// Token: 0x04000590 RID: 1424
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/model/DataUrlLoader$DataDecoder", typeof(DataUrlLoader.IDataDecoderInvoker));

			// Token: 0x04000591 RID: 1425
			private IntPtr class_ref;

			// Token: 0x04000592 RID: 1426
			private static Delegate cb_getDataClass;

			// Token: 0x04000593 RID: 1427
			private IntPtr id_getDataClass;

			// Token: 0x04000594 RID: 1428
			private static Delegate cb_close_Ljava_lang_Object_;

			// Token: 0x04000595 RID: 1429
			private IntPtr id_close_Ljava_lang_Object_;

			// Token: 0x04000596 RID: 1430
			private static Delegate cb_decode_Ljava_lang_String_;

			// Token: 0x04000597 RID: 1431
			private IntPtr id_decode_Ljava_lang_String_;
		}

		// Token: 0x020001EA RID: 490
		[Register("com/bumptech/glide/load/model/DataUrlLoader$StreamFactory", DoNotGenerateAcw = true)]
		[JavaTypeParameters(new string[]
		{
			"Model"
		})]
		public sealed class StreamFactory : Java.Lang.Object, IModelLoaderFactory, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x1700065D RID: 1629
			// (get) Token: 0x0600175D RID: 5981 RVA: 0x000486D4 File Offset: 0x000468D4
			internal static IntPtr class_ref
			{
				get
				{
					return DataUrlLoader.StreamFactory._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700065E RID: 1630
			// (get) Token: 0x0600175E RID: 5982 RVA: 0x000486F8 File Offset: 0x000468F8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return DataUrlLoader.StreamFactory._members;
				}
			}

			// Token: 0x1700065F RID: 1631
			// (get) Token: 0x0600175F RID: 5983 RVA: 0x00048700 File Offset: 0x00046900
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return DataUrlLoader.StreamFactory._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000660 RID: 1632
			// (get) Token: 0x06001760 RID: 5984 RVA: 0x00048724 File Offset: 0x00046924
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return DataUrlLoader.StreamFactory._members.ManagedPeerType;
				}
			}

			// Token: 0x06001761 RID: 5985 RVA: 0x00048730 File Offset: 0x00046930
			internal StreamFactory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06001762 RID: 5986 RVA: 0x0004873C File Offset: 0x0004693C
			[Register(".ctor", "()V", "")]
			public StreamFactory() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(DataUrlLoader.StreamFactory._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				DataUrlLoader.StreamFactory._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x06001763 RID: 5987 RVA: 0x000487AC File Offset: 0x000469AC
			[Register("build", "(Lcom/bumptech/glide/load/model/MultiModelLoaderFactory;)Lcom/bumptech/glide/load/model/ModelLoader;", "")]
			public unsafe IModelLoader Build(MultiModelLoaderFactory multiFactory)
			{
				IModelLoader @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((multiFactory == null) ? IntPtr.Zero : multiFactory.Handle);
					@object = Java.Lang.Object.GetObject<IModelLoader>(DataUrlLoader.StreamFactory._members.InstanceMethods.InvokeAbstractObjectMethod("build.(Lcom/bumptech/glide/load/model/MultiModelLoaderFactory;)Lcom/bumptech/glide/load/model/ModelLoader;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(multiFactory);
				}
				return @object;
			}

			// Token: 0x06001764 RID: 5988 RVA: 0x00048820 File Offset: 0x00046A20
			[Register("teardown", "()V", "")]
			public void Teardown()
			{
				DataUrlLoader.StreamFactory._members.InstanceMethods.InvokeAbstractVoidMethod("teardown.()V", this, null);
			}

			// Token: 0x04000598 RID: 1432
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/model/DataUrlLoader$StreamFactory", typeof(DataUrlLoader.StreamFactory));
		}
	}
}
