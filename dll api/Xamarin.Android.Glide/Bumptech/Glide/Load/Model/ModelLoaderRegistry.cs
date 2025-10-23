using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using AndroidX.Core.Util;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Model
{
	// Token: 0x02000142 RID: 322
	[Register("com/bumptech/glide/load/model/ModelLoaderRegistry", DoNotGenerateAcw = true)]
	public class ModelLoaderRegistry : Java.Lang.Object
	{
		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06001031 RID: 4145 RVA: 0x00034054 File Offset: 0x00032254
		internal static IntPtr class_ref
		{
			get
			{
				return ModelLoaderRegistry._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06001032 RID: 4146 RVA: 0x00034078 File Offset: 0x00032278
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ModelLoaderRegistry._members;
			}
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06001033 RID: 4147 RVA: 0x00034080 File Offset: 0x00032280
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ModelLoaderRegistry._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06001034 RID: 4148 RVA: 0x000340A4 File Offset: 0x000322A4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ModelLoaderRegistry._members.ManagedPeerType;
			}
		}

		// Token: 0x06001035 RID: 4149 RVA: 0x000340B0 File Offset: 0x000322B0
		protected ModelLoaderRegistry(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001036 RID: 4150 RVA: 0x000340BC File Offset: 0x000322BC
		[Register(".ctor", "(Landroidx/core/util/Pools$Pool;)V", "")]
		public unsafe ModelLoaderRegistry(Pools.IPool throwableListPool) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((throwableListPool == null) ? IntPtr.Zero : ((Java.Lang.Object)throwableListPool).Handle);
				base.SetHandle(ModelLoaderRegistry._members.InstanceMethods.StartCreateInstance("(Landroidx/core/util/Pools$Pool;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ModelLoaderRegistry._members.InstanceMethods.FinishCreateInstance("(Landroidx/core/util/Pools$Pool;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(throwableListPool);
			}
		}

		// Token: 0x06001037 RID: 4151 RVA: 0x00034170 File Offset: 0x00032370
		private static Delegate GetAppend_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_model_ModelLoaderFactory_Handler()
		{
			if (ModelLoaderRegistry.cb_append_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_model_ModelLoaderFactory_ == null)
			{
				ModelLoaderRegistry.cb_append_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_model_ModelLoaderFactory_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(ModelLoaderRegistry.n_Append_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_model_ModelLoaderFactory_));
			}
			return ModelLoaderRegistry.cb_append_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_model_ModelLoaderFactory_;
		}

		// Token: 0x06001038 RID: 4152 RVA: 0x00034194 File Offset: 0x00032394
		private static void n_Append_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_model_ModelLoaderFactory_(IntPtr jnienv, IntPtr native__this, IntPtr native_modelClass, IntPtr native_dataClass, IntPtr native_factory)
		{
			ModelLoaderRegistry @object = Java.Lang.Object.GetObject<ModelLoaderRegistry>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Java.Lang.Object.GetObject<Class>(native_modelClass, JniHandleOwnership.DoNotTransfer);
			Class object3 = Java.Lang.Object.GetObject<Class>(native_dataClass, JniHandleOwnership.DoNotTransfer);
			IModelLoaderFactory object4 = Java.Lang.Object.GetObject<IModelLoaderFactory>(native_factory, JniHandleOwnership.DoNotTransfer);
			@object.Append(object2, object3, object4);
		}

		// Token: 0x06001039 RID: 4153 RVA: 0x000341CC File Offset: 0x000323CC
		[Register("append", "(Ljava/lang/Class;Ljava/lang/Class;Lcom/bumptech/glide/load/model/ModelLoaderFactory;)V", "GetAppend_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_model_ModelLoaderFactory_Handler")]
		[JavaTypeParameters(new string[]
		{
			"Model",
			"Data"
		})]
		public unsafe virtual void Append(Class modelClass, Class dataClass, IModelLoaderFactory factory)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((modelClass == null) ? IntPtr.Zero : modelClass.Handle);
				ptr[1] = new JniArgumentValue((dataClass == null) ? IntPtr.Zero : dataClass.Handle);
				ptr[2] = new JniArgumentValue((factory == null) ? IntPtr.Zero : ((Java.Lang.Object)factory).Handle);
				ModelLoaderRegistry._members.InstanceMethods.InvokeVirtualVoidMethod("append.(Ljava/lang/Class;Ljava/lang/Class;Lcom/bumptech/glide/load/model/ModelLoaderFactory;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(modelClass);
				GC.KeepAlive(dataClass);
				GC.KeepAlive(factory);
			}
		}

		// Token: 0x0600103A RID: 4154 RVA: 0x00034288 File Offset: 0x00032488
		private static Delegate GetBuild_Ljava_lang_Class_Ljava_lang_Class_Handler()
		{
			if (ModelLoaderRegistry.cb_build_Ljava_lang_Class_Ljava_lang_Class_ == null)
			{
				ModelLoaderRegistry.cb_build_Ljava_lang_Class_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(ModelLoaderRegistry.n_Build_Ljava_lang_Class_Ljava_lang_Class_));
			}
			return ModelLoaderRegistry.cb_build_Ljava_lang_Class_Ljava_lang_Class_;
		}

		// Token: 0x0600103B RID: 4155 RVA: 0x000342AC File Offset: 0x000324AC
		private static IntPtr n_Build_Ljava_lang_Class_Ljava_lang_Class_(IntPtr jnienv, IntPtr native__this, IntPtr native_modelClass, IntPtr native_dataClass)
		{
			ModelLoaderRegistry @object = Java.Lang.Object.GetObject<ModelLoaderRegistry>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Java.Lang.Object.GetObject<Class>(native_modelClass, JniHandleOwnership.DoNotTransfer);
			Class object3 = Java.Lang.Object.GetObject<Class>(native_dataClass, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Build(object2, object3));
		}

		// Token: 0x0600103C RID: 4156 RVA: 0x000342E0 File Offset: 0x000324E0
		[Register("build", "(Ljava/lang/Class;Ljava/lang/Class;)Lcom/bumptech/glide/load/model/ModelLoader;", "GetBuild_Ljava_lang_Class_Ljava_lang_Class_Handler")]
		[JavaTypeParameters(new string[]
		{
			"Model",
			"Data"
		})]
		public unsafe virtual IModelLoader Build(Class modelClass, Class dataClass)
		{
			IModelLoader @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((modelClass == null) ? IntPtr.Zero : modelClass.Handle);
				ptr[1] = new JniArgumentValue((dataClass == null) ? IntPtr.Zero : dataClass.Handle);
				@object = Java.Lang.Object.GetObject<IModelLoader>(ModelLoaderRegistry._members.InstanceMethods.InvokeVirtualObjectMethod("build.(Ljava/lang/Class;Ljava/lang/Class;)Lcom/bumptech/glide/load/model/ModelLoader;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(modelClass);
				GC.KeepAlive(dataClass);
			}
			return @object;
		}

		// Token: 0x0600103D RID: 4157 RVA: 0x0003437C File Offset: 0x0003257C
		private static Delegate GetGetDataClasses_Ljava_lang_Class_Handler()
		{
			if (ModelLoaderRegistry.cb_getDataClasses_Ljava_lang_Class_ == null)
			{
				ModelLoaderRegistry.cb_getDataClasses_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ModelLoaderRegistry.n_GetDataClasses_Ljava_lang_Class_));
			}
			return ModelLoaderRegistry.cb_getDataClasses_Ljava_lang_Class_;
		}

		// Token: 0x0600103E RID: 4158 RVA: 0x000343A0 File Offset: 0x000325A0
		private static IntPtr n_GetDataClasses_Ljava_lang_Class_(IntPtr jnienv, IntPtr native__this, IntPtr native_modelClass)
		{
			ModelLoaderRegistry @object = Java.Lang.Object.GetObject<ModelLoaderRegistry>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Java.Lang.Object.GetObject<Class>(native_modelClass, JniHandleOwnership.DoNotTransfer);
			return JavaList<Class>.ToLocalJniHandle(@object.GetDataClasses(object2));
		}

		// Token: 0x0600103F RID: 4159 RVA: 0x000343C8 File Offset: 0x000325C8
		[Register("getDataClasses", "(Ljava/lang/Class;)Ljava/util/List;", "GetGetDataClasses_Ljava_lang_Class_Handler")]
		public unsafe virtual IList<Class> GetDataClasses(Class modelClass)
		{
			IList<Class> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((modelClass == null) ? IntPtr.Zero : modelClass.Handle);
				result = JavaList<Class>.FromJniHandle(ModelLoaderRegistry._members.InstanceMethods.InvokeVirtualObjectMethod("getDataClasses.(Ljava/lang/Class;)Ljava/util/List;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(modelClass);
			}
			return result;
		}

		// Token: 0x06001040 RID: 4160 RVA: 0x0003443C File Offset: 0x0003263C
		private static Delegate GetGetModelLoaders_Ljava_lang_Object_Handler()
		{
			if (ModelLoaderRegistry.cb_getModelLoaders_Ljava_lang_Object_ == null)
			{
				ModelLoaderRegistry.cb_getModelLoaders_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ModelLoaderRegistry.n_GetModelLoaders_Ljava_lang_Object_));
			}
			return ModelLoaderRegistry.cb_getModelLoaders_Ljava_lang_Object_;
		}

		// Token: 0x06001041 RID: 4161 RVA: 0x00034460 File Offset: 0x00032660
		private static IntPtr n_GetModelLoaders_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_model)
		{
			ModelLoaderRegistry @object = Java.Lang.Object.GetObject<ModelLoaderRegistry>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_model, JniHandleOwnership.DoNotTransfer);
			return JavaList.ToLocalJniHandle(@object.GetModelLoaders(object2));
		}

		// Token: 0x06001042 RID: 4162 RVA: 0x00034488 File Offset: 0x00032688
		[Register("getModelLoaders", "(Ljava/lang/Object;)Ljava/util/List;", "GetGetModelLoaders_Ljava_lang_Object_Handler")]
		[JavaTypeParameters(new string[]
		{
			"A"
		})]
		public unsafe virtual IList GetModelLoaders(Java.Lang.Object model)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(model);
			IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = JavaList.FromJniHandle(ModelLoaderRegistry._members.InstanceMethods.InvokeVirtualObjectMethod("getModelLoaders.(Ljava/lang/Object;)Ljava/util/List;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(model);
			}
			return result;
		}

		// Token: 0x06001043 RID: 4163 RVA: 0x000344FC File Offset: 0x000326FC
		private static Delegate GetPrepend_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_model_ModelLoaderFactory_Handler()
		{
			if (ModelLoaderRegistry.cb_prepend_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_model_ModelLoaderFactory_ == null)
			{
				ModelLoaderRegistry.cb_prepend_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_model_ModelLoaderFactory_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(ModelLoaderRegistry.n_Prepend_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_model_ModelLoaderFactory_));
			}
			return ModelLoaderRegistry.cb_prepend_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_model_ModelLoaderFactory_;
		}

		// Token: 0x06001044 RID: 4164 RVA: 0x00034520 File Offset: 0x00032720
		private static void n_Prepend_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_model_ModelLoaderFactory_(IntPtr jnienv, IntPtr native__this, IntPtr native_modelClass, IntPtr native_dataClass, IntPtr native_factory)
		{
			ModelLoaderRegistry @object = Java.Lang.Object.GetObject<ModelLoaderRegistry>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Java.Lang.Object.GetObject<Class>(native_modelClass, JniHandleOwnership.DoNotTransfer);
			Class object3 = Java.Lang.Object.GetObject<Class>(native_dataClass, JniHandleOwnership.DoNotTransfer);
			IModelLoaderFactory object4 = Java.Lang.Object.GetObject<IModelLoaderFactory>(native_factory, JniHandleOwnership.DoNotTransfer);
			@object.Prepend(object2, object3, object4);
		}

		// Token: 0x06001045 RID: 4165 RVA: 0x00034558 File Offset: 0x00032758
		[Register("prepend", "(Ljava/lang/Class;Ljava/lang/Class;Lcom/bumptech/glide/load/model/ModelLoaderFactory;)V", "GetPrepend_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_model_ModelLoaderFactory_Handler")]
		[JavaTypeParameters(new string[]
		{
			"Model",
			"Data"
		})]
		public unsafe virtual void Prepend(Class modelClass, Class dataClass, IModelLoaderFactory factory)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((modelClass == null) ? IntPtr.Zero : modelClass.Handle);
				ptr[1] = new JniArgumentValue((dataClass == null) ? IntPtr.Zero : dataClass.Handle);
				ptr[2] = new JniArgumentValue((factory == null) ? IntPtr.Zero : ((Java.Lang.Object)factory).Handle);
				ModelLoaderRegistry._members.InstanceMethods.InvokeVirtualVoidMethod("prepend.(Ljava/lang/Class;Ljava/lang/Class;Lcom/bumptech/glide/load/model/ModelLoaderFactory;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(modelClass);
				GC.KeepAlive(dataClass);
				GC.KeepAlive(factory);
			}
		}

		// Token: 0x06001046 RID: 4166 RVA: 0x00034614 File Offset: 0x00032814
		private static Delegate GetRemove_Ljava_lang_Class_Ljava_lang_Class_Handler()
		{
			if (ModelLoaderRegistry.cb_remove_Ljava_lang_Class_Ljava_lang_Class_ == null)
			{
				ModelLoaderRegistry.cb_remove_Ljava_lang_Class_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(ModelLoaderRegistry.n_Remove_Ljava_lang_Class_Ljava_lang_Class_));
			}
			return ModelLoaderRegistry.cb_remove_Ljava_lang_Class_Ljava_lang_Class_;
		}

		// Token: 0x06001047 RID: 4167 RVA: 0x00034638 File Offset: 0x00032838
		private static void n_Remove_Ljava_lang_Class_Ljava_lang_Class_(IntPtr jnienv, IntPtr native__this, IntPtr native_modelClass, IntPtr native_dataClass)
		{
			ModelLoaderRegistry @object = Java.Lang.Object.GetObject<ModelLoaderRegistry>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Java.Lang.Object.GetObject<Class>(native_modelClass, JniHandleOwnership.DoNotTransfer);
			Class object3 = Java.Lang.Object.GetObject<Class>(native_dataClass, JniHandleOwnership.DoNotTransfer);
			@object.Remove(object2, object3);
		}

		// Token: 0x06001048 RID: 4168 RVA: 0x00034664 File Offset: 0x00032864
		[Register("remove", "(Ljava/lang/Class;Ljava/lang/Class;)V", "GetRemove_Ljava_lang_Class_Ljava_lang_Class_Handler")]
		[JavaTypeParameters(new string[]
		{
			"Model",
			"Data"
		})]
		public unsafe virtual void Remove(Class modelClass, Class dataClass)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((modelClass == null) ? IntPtr.Zero : modelClass.Handle);
				ptr[1] = new JniArgumentValue((dataClass == null) ? IntPtr.Zero : dataClass.Handle);
				ModelLoaderRegistry._members.InstanceMethods.InvokeVirtualVoidMethod("remove.(Ljava/lang/Class;Ljava/lang/Class;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(modelClass);
				GC.KeepAlive(dataClass);
			}
		}

		// Token: 0x06001049 RID: 4169 RVA: 0x000346F0 File Offset: 0x000328F0
		private static Delegate GetReplace_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_model_ModelLoaderFactory_Handler()
		{
			if (ModelLoaderRegistry.cb_replace_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_model_ModelLoaderFactory_ == null)
			{
				ModelLoaderRegistry.cb_replace_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_model_ModelLoaderFactory_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(ModelLoaderRegistry.n_Replace_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_model_ModelLoaderFactory_));
			}
			return ModelLoaderRegistry.cb_replace_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_model_ModelLoaderFactory_;
		}

		// Token: 0x0600104A RID: 4170 RVA: 0x00034714 File Offset: 0x00032914
		private static void n_Replace_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_model_ModelLoaderFactory_(IntPtr jnienv, IntPtr native__this, IntPtr native_modelClass, IntPtr native_dataClass, IntPtr native_factory)
		{
			ModelLoaderRegistry @object = Java.Lang.Object.GetObject<ModelLoaderRegistry>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Java.Lang.Object.GetObject<Class>(native_modelClass, JniHandleOwnership.DoNotTransfer);
			Class object3 = Java.Lang.Object.GetObject<Class>(native_dataClass, JniHandleOwnership.DoNotTransfer);
			IModelLoaderFactory object4 = Java.Lang.Object.GetObject<IModelLoaderFactory>(native_factory, JniHandleOwnership.DoNotTransfer);
			@object.Replace(object2, object3, object4);
		}

		// Token: 0x0600104B RID: 4171 RVA: 0x0003474C File Offset: 0x0003294C
		[Register("replace", "(Ljava/lang/Class;Ljava/lang/Class;Lcom/bumptech/glide/load/model/ModelLoaderFactory;)V", "GetReplace_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_model_ModelLoaderFactory_Handler")]
		[JavaTypeParameters(new string[]
		{
			"Model",
			"Data"
		})]
		public unsafe virtual void Replace(Class modelClass, Class dataClass, IModelLoaderFactory factory)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((modelClass == null) ? IntPtr.Zero : modelClass.Handle);
				ptr[1] = new JniArgumentValue((dataClass == null) ? IntPtr.Zero : dataClass.Handle);
				ptr[2] = new JniArgumentValue((factory == null) ? IntPtr.Zero : ((Java.Lang.Object)factory).Handle);
				ModelLoaderRegistry._members.InstanceMethods.InvokeVirtualVoidMethod("replace.(Ljava/lang/Class;Ljava/lang/Class;Lcom/bumptech/glide/load/model/ModelLoaderFactory;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(modelClass);
				GC.KeepAlive(dataClass);
				GC.KeepAlive(factory);
			}
		}

		// Token: 0x040003BD RID: 957
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/model/ModelLoaderRegistry", typeof(ModelLoaderRegistry));

		// Token: 0x040003BE RID: 958
		private static Delegate cb_append_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_model_ModelLoaderFactory_;

		// Token: 0x040003BF RID: 959
		private static Delegate cb_build_Ljava_lang_Class_Ljava_lang_Class_;

		// Token: 0x040003C0 RID: 960
		private static Delegate cb_getDataClasses_Ljava_lang_Class_;

		// Token: 0x040003C1 RID: 961
		private static Delegate cb_getModelLoaders_Ljava_lang_Object_;

		// Token: 0x040003C2 RID: 962
		private static Delegate cb_prepend_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_model_ModelLoaderFactory_;

		// Token: 0x040003C3 RID: 963
		private static Delegate cb_remove_Ljava_lang_Class_Ljava_lang_Class_;

		// Token: 0x040003C4 RID: 964
		private static Delegate cb_replace_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_model_ModelLoaderFactory_;
	}
}
