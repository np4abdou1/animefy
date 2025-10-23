using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Model
{
	// Token: 0x02000146 RID: 326
	[Register("com/bumptech/glide/load/model/UnitModelLoader", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"Model"
	})]
	public class UnitModelLoader : Java.Lang.Object, IModelLoader, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x0600106B RID: 4203 RVA: 0x00034F3C File Offset: 0x0003313C
		internal static IntPtr class_ref
		{
			get
			{
				return UnitModelLoader._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x0600106C RID: 4204 RVA: 0x00034F60 File Offset: 0x00033160
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return UnitModelLoader._members;
			}
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x0600106D RID: 4205 RVA: 0x00034F68 File Offset: 0x00033168
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return UnitModelLoader._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x0600106E RID: 4206 RVA: 0x00034F8C File Offset: 0x0003318C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return UnitModelLoader._members.ManagedPeerType;
			}
		}

		// Token: 0x0600106F RID: 4207 RVA: 0x00034F98 File Offset: 0x00033198
		protected UnitModelLoader(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001070 RID: 4208 RVA: 0x00034FA4 File Offset: 0x000331A4
		[Register(".ctor", "()V", "")]
		[Obsolete("deprecated")]
		public UnitModelLoader() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(UnitModelLoader._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			UnitModelLoader._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x06001071 RID: 4209 RVA: 0x00035014 File Offset: 0x00033214
		public static UnitModelLoader Instance
		{
			[JavaTypeParameters(new string[]
			{
				"T"
			})]
			[Register("getInstance", "()Lcom/bumptech/glide/load/model/UnitModelLoader;", "")]
			get
			{
				return Java.Lang.Object.GetObject<UnitModelLoader>(UnitModelLoader._members.StaticMethods.InvokeObjectMethod("getInstance.()Lcom/bumptech/glide/load/model/UnitModelLoader;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06001072 RID: 4210 RVA: 0x00035045 File Offset: 0x00033245
		private static Delegate GetBuildLoadData_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_Handler()
		{
			if (UnitModelLoader.cb_buildLoadData_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_ == null)
			{
				UnitModelLoader.cb_buildLoadData_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIIL_L(UnitModelLoader.n_BuildLoadData_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_));
			}
			return UnitModelLoader.cb_buildLoadData_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_;
		}

		// Token: 0x06001073 RID: 4211 RVA: 0x0003506C File Offset: 0x0003326C
		private static IntPtr n_BuildLoadData_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_(IntPtr jnienv, IntPtr native__this, IntPtr native_model, int width, int height, IntPtr native_options)
		{
			UnitModelLoader @object = Java.Lang.Object.GetObject<UnitModelLoader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_model, JniHandleOwnership.DoNotTransfer);
			Options object3 = Java.Lang.Object.GetObject<Options>(native_options, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.BuildLoadData(object2, width, height, object3));
		}

		// Token: 0x06001074 RID: 4212 RVA: 0x000350A4 File Offset: 0x000332A4
		[Register("buildLoadData", "(Ljava/lang/Object;IILcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/model/ModelLoader$LoadData;", "GetBuildLoadData_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_Handler")]
		public unsafe virtual ModelLoaderLoadData BuildLoadData(Java.Lang.Object model, int width, int height, Options options)
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
				@object = Java.Lang.Object.GetObject<ModelLoaderLoadData>(UnitModelLoader._members.InstanceMethods.InvokeVirtualObjectMethod("buildLoadData.(Ljava/lang/Object;IILcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/model/ModelLoader$LoadData;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(model);
				GC.KeepAlive(options);
			}
			return @object;
		}

		// Token: 0x06001075 RID: 4213 RVA: 0x0003516C File Offset: 0x0003336C
		private static Delegate GetHandles_Ljava_lang_Object_Handler()
		{
			if (UnitModelLoader.cb_handles_Ljava_lang_Object_ == null)
			{
				UnitModelLoader.cb_handles_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(UnitModelLoader.n_Handles_Ljava_lang_Object_));
			}
			return UnitModelLoader.cb_handles_Ljava_lang_Object_;
		}

		// Token: 0x06001076 RID: 4214 RVA: 0x00035190 File Offset: 0x00033390
		private static bool n_Handles_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_model)
		{
			UnitModelLoader @object = Java.Lang.Object.GetObject<UnitModelLoader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_model, JniHandleOwnership.DoNotTransfer);
			return @object.Handles(object2);
		}

		// Token: 0x06001077 RID: 4215 RVA: 0x000351B4 File Offset: 0x000333B4
		[Register("handles", "(Ljava/lang/Object;)Z", "GetHandles_Ljava_lang_Object_Handler")]
		public unsafe virtual bool Handles(Java.Lang.Object model)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(model);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = UnitModelLoader._members.InstanceMethods.InvokeVirtualBooleanMethod("handles.(Ljava/lang/Object;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(model);
			}
			return result;
		}

		// Token: 0x040003CA RID: 970
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/model/UnitModelLoader", typeof(UnitModelLoader));

		// Token: 0x040003CB RID: 971
		private static Delegate cb_buildLoadData_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_;

		// Token: 0x040003CC RID: 972
		private static Delegate cb_handles_Ljava_lang_Object_;

		// Token: 0x020001EF RID: 495
		[Register("com/bumptech/glide/load/model/UnitModelLoader$Factory", DoNotGenerateAcw = true)]
		[JavaTypeParameters(new string[]
		{
			"Model"
		})]
		public class Factory : Java.Lang.Object, IModelLoaderFactory, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x1700066C RID: 1644
			// (get) Token: 0x0600177F RID: 6015 RVA: 0x00048E2C File Offset: 0x0004702C
			internal static IntPtr class_ref
			{
				get
				{
					return UnitModelLoader.Factory._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700066D RID: 1645
			// (get) Token: 0x06001780 RID: 6016 RVA: 0x00048E50 File Offset: 0x00047050
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return UnitModelLoader.Factory._members;
				}
			}

			// Token: 0x1700066E RID: 1646
			// (get) Token: 0x06001781 RID: 6017 RVA: 0x00048E58 File Offset: 0x00047058
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return UnitModelLoader.Factory._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700066F RID: 1647
			// (get) Token: 0x06001782 RID: 6018 RVA: 0x00048E7C File Offset: 0x0004707C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return UnitModelLoader.Factory._members.ManagedPeerType;
				}
			}

			// Token: 0x06001783 RID: 6019 RVA: 0x00048E88 File Offset: 0x00047088
			protected Factory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06001784 RID: 6020 RVA: 0x00048E94 File Offset: 0x00047094
			[Register(".ctor", "()V", "")]
			[Obsolete("deprecated")]
			public Factory() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(UnitModelLoader.Factory._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				UnitModelLoader.Factory._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x17000670 RID: 1648
			// (get) Token: 0x06001785 RID: 6021 RVA: 0x00048F04 File Offset: 0x00047104
			public static UnitModelLoader.Factory Instance
			{
				[JavaTypeParameters(new string[]
				{
					"T"
				})]
				[Register("getInstance", "()Lcom/bumptech/glide/load/model/UnitModelLoader$Factory;", "")]
				get
				{
					return Java.Lang.Object.GetObject<UnitModelLoader.Factory>(UnitModelLoader.Factory._members.StaticMethods.InvokeObjectMethod("getInstance.()Lcom/bumptech/glide/load/model/UnitModelLoader$Factory;", null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x06001786 RID: 6022 RVA: 0x00048F35 File Offset: 0x00047135
			private static Delegate GetBuild_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_Handler()
			{
				if (UnitModelLoader.Factory.cb_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_ == null)
				{
					UnitModelLoader.Factory.cb_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(UnitModelLoader.Factory.n_Build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_));
				}
				return UnitModelLoader.Factory.cb_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_;
			}

			// Token: 0x06001787 RID: 6023 RVA: 0x00048F5C File Offset: 0x0004715C
			private static IntPtr n_Build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_(IntPtr jnienv, IntPtr native__this, IntPtr native_multiFactory)
			{
				UnitModelLoader.Factory @object = Java.Lang.Object.GetObject<UnitModelLoader.Factory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				MultiModelLoaderFactory object2 = Java.Lang.Object.GetObject<MultiModelLoaderFactory>(native_multiFactory, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.Build(object2));
			}

			// Token: 0x06001788 RID: 6024 RVA: 0x00048F84 File Offset: 0x00047184
			[Register("build", "(Lcom/bumptech/glide/load/model/MultiModelLoaderFactory;)Lcom/bumptech/glide/load/model/ModelLoader;", "GetBuild_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_Handler")]
			public unsafe virtual IModelLoader Build(MultiModelLoaderFactory multiFactory)
			{
				IModelLoader @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((multiFactory == null) ? IntPtr.Zero : multiFactory.Handle);
					@object = Java.Lang.Object.GetObject<IModelLoader>(UnitModelLoader.Factory._members.InstanceMethods.InvokeVirtualObjectMethod("build.(Lcom/bumptech/glide/load/model/MultiModelLoaderFactory;)Lcom/bumptech/glide/load/model/ModelLoader;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(multiFactory);
				}
				return @object;
			}

			// Token: 0x06001789 RID: 6025 RVA: 0x00048FF8 File Offset: 0x000471F8
			private static Delegate GetTeardownHandler()
			{
				if (UnitModelLoader.Factory.cb_teardown == null)
				{
					UnitModelLoader.Factory.cb_teardown = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(UnitModelLoader.Factory.n_Teardown));
				}
				return UnitModelLoader.Factory.cb_teardown;
			}

			// Token: 0x0600178A RID: 6026 RVA: 0x0004901C File Offset: 0x0004721C
			private static void n_Teardown(IntPtr jnienv, IntPtr native__this)
			{
				Java.Lang.Object.GetObject<UnitModelLoader.Factory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Teardown();
			}

			// Token: 0x0600178B RID: 6027 RVA: 0x0004902B File Offset: 0x0004722B
			[Register("teardown", "()V", "GetTeardownHandler")]
			public virtual void Teardown()
			{
				UnitModelLoader.Factory._members.InstanceMethods.InvokeVirtualVoidMethod("teardown.()V", this, null);
			}

			// Token: 0x0400059C RID: 1436
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/model/UnitModelLoader$Factory", typeof(UnitModelLoader.Factory));

			// Token: 0x0400059D RID: 1437
			private static Delegate cb_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_;

			// Token: 0x0400059E RID: 1438
			private static Delegate cb_teardown;
		}
	}
}
