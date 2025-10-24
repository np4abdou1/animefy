using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Model.Stream
{
	// Token: 0x02000148 RID: 328
	[Register("com/bumptech/glide/load/model/stream/BaseGlideUrlLoader", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"Model"
	})]
	public abstract class BaseGlideUrlLoader : Java.Lang.Object, IModelLoader, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x06001083 RID: 4227 RVA: 0x0003540C File Offset: 0x0003360C
		internal static IntPtr class_ref
		{
			get
			{
				return BaseGlideUrlLoader._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06001084 RID: 4228 RVA: 0x00035430 File Offset: 0x00033630
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BaseGlideUrlLoader._members;
			}
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06001085 RID: 4229 RVA: 0x00035438 File Offset: 0x00033638
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BaseGlideUrlLoader._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x06001086 RID: 4230 RVA: 0x0003545C File Offset: 0x0003365C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BaseGlideUrlLoader._members.ManagedPeerType;
			}
		}

		// Token: 0x06001087 RID: 4231 RVA: 0x00035468 File Offset: 0x00033668
		protected BaseGlideUrlLoader(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001088 RID: 4232 RVA: 0x00035474 File Offset: 0x00033674
		[Register(".ctor", "(Lcom/bumptech/glide/load/model/ModelLoader;)V", "")]
		protected unsafe BaseGlideUrlLoader(IModelLoader concreteLoader) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((concreteLoader == null) ? IntPtr.Zero : ((Java.Lang.Object)concreteLoader).Handle);
				base.SetHandle(BaseGlideUrlLoader._members.InstanceMethods.StartCreateInstance("(Lcom/bumptech/glide/load/model/ModelLoader;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				BaseGlideUrlLoader._members.InstanceMethods.FinishCreateInstance("(Lcom/bumptech/glide/load/model/ModelLoader;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(concreteLoader);
			}
		}

		// Token: 0x06001089 RID: 4233 RVA: 0x00035528 File Offset: 0x00033728
		[Register(".ctor", "(Lcom/bumptech/glide/load/model/ModelLoader;Lcom/bumptech/glide/load/model/ModelCache;)V", "")]
		protected unsafe BaseGlideUrlLoader(IModelLoader concreteLoader, ModelCache modelCache) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((concreteLoader == null) ? IntPtr.Zero : ((Java.Lang.Object)concreteLoader).Handle);
				ptr[1] = new JniArgumentValue((modelCache == null) ? IntPtr.Zero : modelCache.Handle);
				base.SetHandle(BaseGlideUrlLoader._members.InstanceMethods.StartCreateInstance("(Lcom/bumptech/glide/load/model/ModelLoader;Lcom/bumptech/glide/load/model/ModelCache;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				BaseGlideUrlLoader._members.InstanceMethods.FinishCreateInstance("(Lcom/bumptech/glide/load/model/ModelLoader;Lcom/bumptech/glide/load/model/ModelCache;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(concreteLoader);
				GC.KeepAlive(modelCache);
			}
		}

		// Token: 0x0600108A RID: 4234 RVA: 0x00035604 File Offset: 0x00033804
		private static Delegate GetBuildLoadData_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_Handler()
		{
			if (BaseGlideUrlLoader.cb_buildLoadData_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_ == null)
			{
				BaseGlideUrlLoader.cb_buildLoadData_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIIL_L(BaseGlideUrlLoader.n_BuildLoadData_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_));
			}
			return BaseGlideUrlLoader.cb_buildLoadData_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_;
		}

		// Token: 0x0600108B RID: 4235 RVA: 0x00035628 File Offset: 0x00033828
		private static IntPtr n_BuildLoadData_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_(IntPtr jnienv, IntPtr native__this, IntPtr native_model, int width, int height, IntPtr native_options)
		{
			BaseGlideUrlLoader @object = Java.Lang.Object.GetObject<BaseGlideUrlLoader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_model, JniHandleOwnership.DoNotTransfer);
			Options object3 = Java.Lang.Object.GetObject<Options>(native_options, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.BuildLoadData(object2, width, height, object3));
		}

		// Token: 0x0600108C RID: 4236 RVA: 0x00035660 File Offset: 0x00033860
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
				@object = Java.Lang.Object.GetObject<ModelLoaderLoadData>(BaseGlideUrlLoader._members.InstanceMethods.InvokeVirtualObjectMethod("buildLoadData.(Ljava/lang/Object;IILcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/model/ModelLoader$LoadData;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(model);
				GC.KeepAlive(options);
			}
			return @object;
		}

		// Token: 0x0600108D RID: 4237 RVA: 0x00035728 File Offset: 0x00033928
		private static Delegate GetGetAlternateUrls_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_Handler()
		{
			if (BaseGlideUrlLoader.cb_getAlternateUrls_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_ == null)
			{
				BaseGlideUrlLoader.cb_getAlternateUrls_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIIL_L(BaseGlideUrlLoader.n_GetAlternateUrls_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_));
			}
			return BaseGlideUrlLoader.cb_getAlternateUrls_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_;
		}

		// Token: 0x0600108E RID: 4238 RVA: 0x0003574C File Offset: 0x0003394C
		private static IntPtr n_GetAlternateUrls_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_(IntPtr jnienv, IntPtr native__this, IntPtr native_model, int width, int height, IntPtr native_options)
		{
			BaseGlideUrlLoader @object = Java.Lang.Object.GetObject<BaseGlideUrlLoader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_model, JniHandleOwnership.DoNotTransfer);
			Options object3 = Java.Lang.Object.GetObject<Options>(native_options, JniHandleOwnership.DoNotTransfer);
			return JavaList<string>.ToLocalJniHandle(@object.GetAlternateUrls(object2, width, height, object3));
		}

		// Token: 0x0600108F RID: 4239 RVA: 0x00035784 File Offset: 0x00033984
		[Register("getAlternateUrls", "(Ljava/lang/Object;IILcom/bumptech/glide/load/Options;)Ljava/util/List;", "GetGetAlternateUrls_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_Handler")]
		protected unsafe virtual IList<string> GetAlternateUrls(Java.Lang.Object model, int width, int height, Options options)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(model);
			IList<string> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(width);
				ptr[2] = new JniArgumentValue(height);
				ptr[3] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				result = JavaList<string>.FromJniHandle(BaseGlideUrlLoader._members.InstanceMethods.InvokeVirtualObjectMethod("getAlternateUrls.(Ljava/lang/Object;IILcom/bumptech/glide/load/Options;)Ljava/util/List;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(model);
				GC.KeepAlive(options);
			}
			return result;
		}

		// Token: 0x06001090 RID: 4240 RVA: 0x0003584C File Offset: 0x00033A4C
		private static Delegate GetGetHeaders_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_Handler()
		{
			if (BaseGlideUrlLoader.cb_getHeaders_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_ == null)
			{
				BaseGlideUrlLoader.cb_getHeaders_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIIL_L(BaseGlideUrlLoader.n_GetHeaders_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_));
			}
			return BaseGlideUrlLoader.cb_getHeaders_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_;
		}

		// Token: 0x06001091 RID: 4241 RVA: 0x00035870 File Offset: 0x00033A70
		private static IntPtr n_GetHeaders_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_(IntPtr jnienv, IntPtr native__this, IntPtr native_model, int width, int height, IntPtr native_options)
		{
			BaseGlideUrlLoader @object = Java.Lang.Object.GetObject<BaseGlideUrlLoader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_model, JniHandleOwnership.DoNotTransfer);
			Options object3 = Java.Lang.Object.GetObject<Options>(native_options, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetHeaders(object2, width, height, object3));
		}

		// Token: 0x06001092 RID: 4242 RVA: 0x000358A8 File Offset: 0x00033AA8
		[Register("getHeaders", "(Ljava/lang/Object;IILcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/model/Headers;", "GetGetHeaders_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_Handler")]
		protected unsafe virtual IHeaders GetHeaders(Java.Lang.Object model, int width, int height, Options options)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(model);
			IHeaders @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(width);
				ptr[2] = new JniArgumentValue(height);
				ptr[3] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				@object = Java.Lang.Object.GetObject<IHeaders>(BaseGlideUrlLoader._members.InstanceMethods.InvokeVirtualObjectMethod("getHeaders.(Ljava/lang/Object;IILcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/model/Headers;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(model);
				GC.KeepAlive(options);
			}
			return @object;
		}

		// Token: 0x06001093 RID: 4243 RVA: 0x00035970 File Offset: 0x00033B70
		private static Delegate GetGetUrl_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_Handler()
		{
			if (BaseGlideUrlLoader.cb_getUrl_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_ == null)
			{
				BaseGlideUrlLoader.cb_getUrl_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIIL_L(BaseGlideUrlLoader.n_GetUrl_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_));
			}
			return BaseGlideUrlLoader.cb_getUrl_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_;
		}

		// Token: 0x06001094 RID: 4244 RVA: 0x00035994 File Offset: 0x00033B94
		private static IntPtr n_GetUrl_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, IntPtr native_p3)
		{
			BaseGlideUrlLoader @object = Java.Lang.Object.GetObject<BaseGlideUrlLoader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			Options object3 = Java.Lang.Object.GetObject<Options>(native_p3, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString(@object.GetUrl(object2, p1, p2, object3));
		}

		// Token: 0x06001095 RID: 4245
		[Register("getUrl", "(Ljava/lang/Object;IILcom/bumptech/glide/load/Options;)Ljava/lang/String;", "GetGetUrl_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_Handler")]
		protected abstract string GetUrl(Java.Lang.Object p0, int p1, int p2, Options p3);

		// Token: 0x06001096 RID: 4246 RVA: 0x000359C9 File Offset: 0x00033BC9
		private static Delegate GetHandles_Ljava_lang_Object_Handler()
		{
			if (BaseGlideUrlLoader.cb_handles_Ljava_lang_Object_ == null)
			{
				BaseGlideUrlLoader.cb_handles_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(BaseGlideUrlLoader.n_Handles_Ljava_lang_Object_));
			}
			return BaseGlideUrlLoader.cb_handles_Ljava_lang_Object_;
		}

		// Token: 0x06001097 RID: 4247 RVA: 0x000359F0 File Offset: 0x00033BF0
		private static bool n_Handles_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_model)
		{
			BaseGlideUrlLoader @object = Java.Lang.Object.GetObject<BaseGlideUrlLoader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_model, JniHandleOwnership.DoNotTransfer);
			return @object.Handles(object2);
		}

		// Token: 0x06001098 RID: 4248
		[Register("handles", "(Ljava/lang/Object;)Z", "GetHandles_Ljava_lang_Object_Handler")]
		public abstract bool Handles(Java.Lang.Object model);

		// Token: 0x040003CE RID: 974
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/model/stream/BaseGlideUrlLoader", typeof(BaseGlideUrlLoader));

		// Token: 0x040003CF RID: 975
		private static Delegate cb_buildLoadData_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_;

		// Token: 0x040003D0 RID: 976
		private static Delegate cb_getAlternateUrls_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_;

		// Token: 0x040003D1 RID: 977
		private static Delegate cb_getHeaders_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_;

		// Token: 0x040003D2 RID: 978
		private static Delegate cb_getUrl_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_;

		// Token: 0x040003D3 RID: 979
		private static Delegate cb_handles_Ljava_lang_Object_;
	}
}
