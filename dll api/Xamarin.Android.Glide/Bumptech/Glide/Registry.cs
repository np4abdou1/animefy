using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Bumptech.Glide.Load;
using Bumptech.Glide.Load.Data;
using Bumptech.Glide.Load.Engine;
using Bumptech.Glide.Load.Model;
using Bumptech.Glide.Load.Resource.Transcode;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide
{
	// Token: 0x02000040 RID: 64
	[Register("com/bumptech/glide/Registry", DoNotGenerateAcw = true)]
	public class Registry : Java.Lang.Object
	{
		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000228 RID: 552 RVA: 0x000072EC File Offset: 0x000054EC
		internal static IntPtr class_ref
		{
			get
			{
				return Registry._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000229 RID: 553 RVA: 0x00007310 File Offset: 0x00005510
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Registry._members;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600022A RID: 554 RVA: 0x00007318 File Offset: 0x00005518
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Registry._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600022B RID: 555 RVA: 0x0000733C File Offset: 0x0000553C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Registry._members.ManagedPeerType;
			}
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00007348 File Offset: 0x00005548
		protected Registry(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00007354 File Offset: 0x00005554
		[Register(".ctor", "()V", "")]
		public Registry() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(Registry._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			Registry._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x0600022E RID: 558 RVA: 0x000073C2 File Offset: 0x000055C2
		private static Delegate GetGetImageHeaderParsersHandler()
		{
			if (Registry.cb_getImageHeaderParsers == null)
			{
				Registry.cb_getImageHeaderParsers = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Registry.n_GetImageHeaderParsers));
			}
			return Registry.cb_getImageHeaderParsers;
		}

		// Token: 0x0600022F RID: 559 RVA: 0x000073E6 File Offset: 0x000055E6
		private static IntPtr n_GetImageHeaderParsers(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<IImageHeaderParser>.ToLocalJniHandle(Java.Lang.Object.GetObject<Registry>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ImageHeaderParsers);
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000230 RID: 560 RVA: 0x000073FC File Offset: 0x000055FC
		public virtual IList<IImageHeaderParser> ImageHeaderParsers
		{
			[Register("getImageHeaderParsers", "()Ljava/util/List;", "GetGetImageHeaderParsersHandler")]
			get
			{
				return JavaList<IImageHeaderParser>.FromJniHandle(Registry._members.InstanceMethods.InvokeVirtualObjectMethod("getImageHeaderParsers.()Ljava/util/List;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000231 RID: 561 RVA: 0x0000742E File Offset: 0x0000562E
		private static Delegate GetAppend_Ljava_lang_Class_Lcom_bumptech_glide_load_Encoder_Handler()
		{
			if (Registry.cb_append_Ljava_lang_Class_Lcom_bumptech_glide_load_Encoder_ == null)
			{
				Registry.cb_append_Ljava_lang_Class_Lcom_bumptech_glide_load_Encoder_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(Registry.n_Append_Ljava_lang_Class_Lcom_bumptech_glide_load_Encoder_));
			}
			return Registry.cb_append_Ljava_lang_Class_Lcom_bumptech_glide_load_Encoder_;
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00007454 File Offset: 0x00005654
		private static IntPtr n_Append_Ljava_lang_Class_Lcom_bumptech_glide_load_Encoder_(IntPtr jnienv, IntPtr native__this, IntPtr native_dataClass, IntPtr native_encoder)
		{
			Registry @object = Java.Lang.Object.GetObject<Registry>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Java.Lang.Object.GetObject<Class>(native_dataClass, JniHandleOwnership.DoNotTransfer);
			IEncoder object3 = Java.Lang.Object.GetObject<IEncoder>(native_encoder, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Append(object2, object3));
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00007488 File Offset: 0x00005688
		[Register("append", "(Ljava/lang/Class;Lcom/bumptech/glide/load/Encoder;)Lcom/bumptech/glide/Registry;", "GetAppend_Ljava_lang_Class_Lcom_bumptech_glide_load_Encoder_Handler")]
		[JavaTypeParameters(new string[]
		{
			"Data"
		})]
		public unsafe virtual Registry Append(Class dataClass, IEncoder encoder)
		{
			Registry @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((dataClass == null) ? IntPtr.Zero : dataClass.Handle);
				ptr[1] = new JniArgumentValue((encoder == null) ? IntPtr.Zero : ((Java.Lang.Object)encoder).Handle);
				@object = Java.Lang.Object.GetObject<Registry>(Registry._members.InstanceMethods.InvokeVirtualObjectMethod("append.(Ljava/lang/Class;Lcom/bumptech/glide/load/Encoder;)Lcom/bumptech/glide/Registry;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(dataClass);
				GC.KeepAlive(encoder);
			}
			return @object;
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00007528 File Offset: 0x00005728
		private static Delegate GetAppend_Ljava_lang_Class_Lcom_bumptech_glide_load_ResourceEncoder_Handler()
		{
			if (Registry.cb_append_Ljava_lang_Class_Lcom_bumptech_glide_load_ResourceEncoder_ == null)
			{
				Registry.cb_append_Ljava_lang_Class_Lcom_bumptech_glide_load_ResourceEncoder_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(Registry.n_Append_Ljava_lang_Class_Lcom_bumptech_glide_load_ResourceEncoder_));
			}
			return Registry.cb_append_Ljava_lang_Class_Lcom_bumptech_glide_load_ResourceEncoder_;
		}

		// Token: 0x06000235 RID: 565 RVA: 0x0000754C File Offset: 0x0000574C
		private static IntPtr n_Append_Ljava_lang_Class_Lcom_bumptech_glide_load_ResourceEncoder_(IntPtr jnienv, IntPtr native__this, IntPtr native_resourceClass, IntPtr native_encoder)
		{
			Registry @object = Java.Lang.Object.GetObject<Registry>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Java.Lang.Object.GetObject<Class>(native_resourceClass, JniHandleOwnership.DoNotTransfer);
			IResourceEncoder object3 = Java.Lang.Object.GetObject<IResourceEncoder>(native_encoder, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Append(object2, object3));
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00007580 File Offset: 0x00005780
		[Register("append", "(Ljava/lang/Class;Lcom/bumptech/glide/load/ResourceEncoder;)Lcom/bumptech/glide/Registry;", "GetAppend_Ljava_lang_Class_Lcom_bumptech_glide_load_ResourceEncoder_Handler")]
		[JavaTypeParameters(new string[]
		{
			"TResource"
		})]
		public unsafe virtual Registry Append(Class resourceClass, IResourceEncoder encoder)
		{
			Registry @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((resourceClass == null) ? IntPtr.Zero : resourceClass.Handle);
				ptr[1] = new JniArgumentValue((encoder == null) ? IntPtr.Zero : ((Java.Lang.Object)encoder).Handle);
				@object = Java.Lang.Object.GetObject<Registry>(Registry._members.InstanceMethods.InvokeVirtualObjectMethod("append.(Ljava/lang/Class;Lcom/bumptech/glide/load/ResourceEncoder;)Lcom/bumptech/glide/Registry;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(resourceClass);
				GC.KeepAlive(encoder);
			}
			return @object;
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00007620 File Offset: 0x00005820
		private static Delegate GetAppend_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_model_ModelLoaderFactory_Handler()
		{
			if (Registry.cb_append_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_model_ModelLoaderFactory_ == null)
			{
				Registry.cb_append_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_model_ModelLoaderFactory_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_L(Registry.n_Append_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_model_ModelLoaderFactory_));
			}
			return Registry.cb_append_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_model_ModelLoaderFactory_;
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00007644 File Offset: 0x00005844
		private static IntPtr n_Append_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_model_ModelLoaderFactory_(IntPtr jnienv, IntPtr native__this, IntPtr native_modelClass, IntPtr native_dataClass, IntPtr native_factory)
		{
			Registry @object = Java.Lang.Object.GetObject<Registry>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Java.Lang.Object.GetObject<Class>(native_modelClass, JniHandleOwnership.DoNotTransfer);
			Class object3 = Java.Lang.Object.GetObject<Class>(native_dataClass, JniHandleOwnership.DoNotTransfer);
			IModelLoaderFactory object4 = Java.Lang.Object.GetObject<IModelLoaderFactory>(native_factory, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Append(object2, object3, object4));
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00007680 File Offset: 0x00005880
		[Register("append", "(Ljava/lang/Class;Ljava/lang/Class;Lcom/bumptech/glide/load/model/ModelLoaderFactory;)Lcom/bumptech/glide/Registry;", "GetAppend_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_model_ModelLoaderFactory_Handler")]
		[JavaTypeParameters(new string[]
		{
			"Model",
			"Data"
		})]
		public unsafe virtual Registry Append(Class modelClass, Class dataClass, IModelLoaderFactory factory)
		{
			Registry @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((modelClass == null) ? IntPtr.Zero : modelClass.Handle);
				ptr[1] = new JniArgumentValue((dataClass == null) ? IntPtr.Zero : dataClass.Handle);
				ptr[2] = new JniArgumentValue((factory == null) ? IntPtr.Zero : ((Java.Lang.Object)factory).Handle);
				@object = Java.Lang.Object.GetObject<Registry>(Registry._members.InstanceMethods.InvokeVirtualObjectMethod("append.(Ljava/lang/Class;Ljava/lang/Class;Lcom/bumptech/glide/load/model/ModelLoaderFactory;)Lcom/bumptech/glide/Registry;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(modelClass);
				GC.KeepAlive(dataClass);
				GC.KeepAlive(factory);
			}
			return @object;
		}

		// Token: 0x0600023A RID: 570 RVA: 0x0000774C File Offset: 0x0000594C
		private static Delegate GetAppend_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_ResourceDecoder_Handler()
		{
			if (Registry.cb_append_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_ResourceDecoder_ == null)
			{
				Registry.cb_append_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_ResourceDecoder_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_L(Registry.n_Append_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_ResourceDecoder_));
			}
			return Registry.cb_append_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_ResourceDecoder_;
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00007770 File Offset: 0x00005970
		private static IntPtr n_Append_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_ResourceDecoder_(IntPtr jnienv, IntPtr native__this, IntPtr native_dataClass, IntPtr native_resourceClass, IntPtr native_decoder)
		{
			Registry @object = Java.Lang.Object.GetObject<Registry>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Java.Lang.Object.GetObject<Class>(native_dataClass, JniHandleOwnership.DoNotTransfer);
			Class object3 = Java.Lang.Object.GetObject<Class>(native_resourceClass, JniHandleOwnership.DoNotTransfer);
			IResourceDecoder object4 = Java.Lang.Object.GetObject<IResourceDecoder>(native_decoder, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Append(object2, object3, object4));
		}

		// Token: 0x0600023C RID: 572 RVA: 0x000077AC File Offset: 0x000059AC
		[Register("append", "(Ljava/lang/Class;Ljava/lang/Class;Lcom/bumptech/glide/load/ResourceDecoder;)Lcom/bumptech/glide/Registry;", "GetAppend_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_ResourceDecoder_Handler")]
		[JavaTypeParameters(new string[]
		{
			"Data",
			"TResource"
		})]
		public unsafe virtual Registry Append(Class dataClass, Class resourceClass, IResourceDecoder decoder)
		{
			Registry @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((dataClass == null) ? IntPtr.Zero : dataClass.Handle);
				ptr[1] = new JniArgumentValue((resourceClass == null) ? IntPtr.Zero : resourceClass.Handle);
				ptr[2] = new JniArgumentValue((decoder == null) ? IntPtr.Zero : ((Java.Lang.Object)decoder).Handle);
				@object = Java.Lang.Object.GetObject<Registry>(Registry._members.InstanceMethods.InvokeVirtualObjectMethod("append.(Ljava/lang/Class;Ljava/lang/Class;Lcom/bumptech/glide/load/ResourceDecoder;)Lcom/bumptech/glide/Registry;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(dataClass);
				GC.KeepAlive(resourceClass);
				GC.KeepAlive(decoder);
			}
			return @object;
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00007878 File Offset: 0x00005A78
		private static Delegate GetAppend_Ljava_lang_String_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_ResourceDecoder_Handler()
		{
			if (Registry.cb_append_Ljava_lang_String_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_ResourceDecoder_ == null)
			{
				Registry.cb_append_Ljava_lang_String_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_ResourceDecoder_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLL_L(Registry.n_Append_Ljava_lang_String_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_ResourceDecoder_));
			}
			return Registry.cb_append_Ljava_lang_String_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_ResourceDecoder_;
		}

		// Token: 0x0600023E RID: 574 RVA: 0x0000789C File Offset: 0x00005A9C
		private static IntPtr n_Append_Ljava_lang_String_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_ResourceDecoder_(IntPtr jnienv, IntPtr native__this, IntPtr native_bucket, IntPtr native_dataClass, IntPtr native_resourceClass, IntPtr native_decoder)
		{
			Registry @object = Java.Lang.Object.GetObject<Registry>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_bucket, JniHandleOwnership.DoNotTransfer);
			Class object2 = Java.Lang.Object.GetObject<Class>(native_dataClass, JniHandleOwnership.DoNotTransfer);
			Class object3 = Java.Lang.Object.GetObject<Class>(native_resourceClass, JniHandleOwnership.DoNotTransfer);
			IResourceDecoder object4 = Java.Lang.Object.GetObject<IResourceDecoder>(native_decoder, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Append(@string, object2, object3, object4));
		}

		// Token: 0x0600023F RID: 575 RVA: 0x000078E4 File Offset: 0x00005AE4
		[Register("append", "(Ljava/lang/String;Ljava/lang/Class;Ljava/lang/Class;Lcom/bumptech/glide/load/ResourceDecoder;)Lcom/bumptech/glide/Registry;", "GetAppend_Ljava_lang_String_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_ResourceDecoder_Handler")]
		[JavaTypeParameters(new string[]
		{
			"Data",
			"TResource"
		})]
		public unsafe virtual Registry Append(string bucket, Class dataClass, Class resourceClass, IResourceDecoder decoder)
		{
			IntPtr intPtr = JNIEnv.NewString(bucket);
			Registry @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((dataClass == null) ? IntPtr.Zero : dataClass.Handle);
				ptr[2] = new JniArgumentValue((resourceClass == null) ? IntPtr.Zero : resourceClass.Handle);
				ptr[3] = new JniArgumentValue((decoder == null) ? IntPtr.Zero : ((Java.Lang.Object)decoder).Handle);
				@object = Java.Lang.Object.GetObject<Registry>(Registry._members.InstanceMethods.InvokeVirtualObjectMethod("append.(Ljava/lang/String;Ljava/lang/Class;Ljava/lang/Class;Lcom/bumptech/glide/load/ResourceDecoder;)Lcom/bumptech/glide/Registry;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(dataClass);
				GC.KeepAlive(resourceClass);
				GC.KeepAlive(decoder);
			}
			return @object;
		}

		// Token: 0x06000240 RID: 576 RVA: 0x000079D8 File Offset: 0x00005BD8
		private static Delegate GetGetLoadPath_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_Class_Handler()
		{
			if (Registry.cb_getLoadPath_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_Class_ == null)
			{
				Registry.cb_getLoadPath_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_L(Registry.n_GetLoadPath_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_Class_));
			}
			return Registry.cb_getLoadPath_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_Class_;
		}

		// Token: 0x06000241 RID: 577 RVA: 0x000079FC File Offset: 0x00005BFC
		private static IntPtr n_GetLoadPath_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_Class_(IntPtr jnienv, IntPtr native__this, IntPtr native_dataClass, IntPtr native_resourceClass, IntPtr native_transcodeClass)
		{
			Registry @object = Java.Lang.Object.GetObject<Registry>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Java.Lang.Object.GetObject<Class>(native_dataClass, JniHandleOwnership.DoNotTransfer);
			Class object3 = Java.Lang.Object.GetObject<Class>(native_resourceClass, JniHandleOwnership.DoNotTransfer);
			Class object4 = Java.Lang.Object.GetObject<Class>(native_transcodeClass, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetLoadPath(object2, object3, object4));
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00007A38 File Offset: 0x00005C38
		[Register("getLoadPath", "(Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/Class;)Lcom/bumptech/glide/load/engine/LoadPath;", "GetGetLoadPath_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_Class_Handler")]
		[JavaTypeParameters(new string[]
		{
			"Data",
			"TResource",
			"Transcode"
		})]
		public unsafe virtual LoadPath GetLoadPath(Class dataClass, Class resourceClass, Class transcodeClass)
		{
			LoadPath @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((dataClass == null) ? IntPtr.Zero : dataClass.Handle);
				ptr[1] = new JniArgumentValue((resourceClass == null) ? IntPtr.Zero : resourceClass.Handle);
				ptr[2] = new JniArgumentValue((transcodeClass == null) ? IntPtr.Zero : transcodeClass.Handle);
				@object = Java.Lang.Object.GetObject<LoadPath>(Registry._members.InstanceMethods.InvokeVirtualObjectMethod("getLoadPath.(Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/Class;)Lcom/bumptech/glide/load/engine/LoadPath;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(dataClass);
				GC.KeepAlive(resourceClass);
				GC.KeepAlive(transcodeClass);
			}
			return @object;
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00007B00 File Offset: 0x00005D00
		private static Delegate GetGetModelLoaders_Ljava_lang_Object_Handler()
		{
			if (Registry.cb_getModelLoaders_Ljava_lang_Object_ == null)
			{
				Registry.cb_getModelLoaders_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(Registry.n_GetModelLoaders_Ljava_lang_Object_));
			}
			return Registry.cb_getModelLoaders_Ljava_lang_Object_;
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00007B24 File Offset: 0x00005D24
		private static IntPtr n_GetModelLoaders_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_model)
		{
			Registry @object = Java.Lang.Object.GetObject<Registry>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_model, JniHandleOwnership.DoNotTransfer);
			return JavaList.ToLocalJniHandle(@object.GetModelLoaders(object2));
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00007B4C File Offset: 0x00005D4C
		[Register("getModelLoaders", "(Ljava/lang/Object;)Ljava/util/List;", "GetGetModelLoaders_Ljava_lang_Object_Handler")]
		[JavaTypeParameters(new string[]
		{
			"Model"
		})]
		public unsafe virtual IList GetModelLoaders(Java.Lang.Object model)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(model);
			IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = JavaList.FromJniHandle(Registry._members.InstanceMethods.InvokeVirtualObjectMethod("getModelLoaders.(Ljava/lang/Object;)Ljava/util/List;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(model);
			}
			return result;
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00007BC0 File Offset: 0x00005DC0
		private static Delegate GetGetRegisteredResourceClasses_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_Class_Handler()
		{
			if (Registry.cb_getRegisteredResourceClasses_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_Class_ == null)
			{
				Registry.cb_getRegisteredResourceClasses_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_L(Registry.n_GetRegisteredResourceClasses_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_Class_));
			}
			return Registry.cb_getRegisteredResourceClasses_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_Class_;
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00007BE4 File Offset: 0x00005DE4
		private static IntPtr n_GetRegisteredResourceClasses_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_Class_(IntPtr jnienv, IntPtr native__this, IntPtr native_modelClass, IntPtr native_resourceClass, IntPtr native_transcodeClass)
		{
			Registry @object = Java.Lang.Object.GetObject<Registry>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Java.Lang.Object.GetObject<Class>(native_modelClass, JniHandleOwnership.DoNotTransfer);
			Class object3 = Java.Lang.Object.GetObject<Class>(native_resourceClass, JniHandleOwnership.DoNotTransfer);
			Class object4 = Java.Lang.Object.GetObject<Class>(native_transcodeClass, JniHandleOwnership.DoNotTransfer);
			return JavaList<Class>.ToLocalJniHandle(@object.GetRegisteredResourceClasses(object2, object3, object4));
		}

		// Token: 0x06000248 RID: 584 RVA: 0x00007C20 File Offset: 0x00005E20
		[Register("getRegisteredResourceClasses", "(Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/Class;)Ljava/util/List;", "GetGetRegisteredResourceClasses_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_Class_Handler")]
		[JavaTypeParameters(new string[]
		{
			"Model",
			"TResource",
			"Transcode"
		})]
		public unsafe virtual IList<Class> GetRegisteredResourceClasses(Class modelClass, Class resourceClass, Class transcodeClass)
		{
			IList<Class> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((modelClass == null) ? IntPtr.Zero : modelClass.Handle);
				ptr[1] = new JniArgumentValue((resourceClass == null) ? IntPtr.Zero : resourceClass.Handle);
				ptr[2] = new JniArgumentValue((transcodeClass == null) ? IntPtr.Zero : transcodeClass.Handle);
				result = JavaList<Class>.FromJniHandle(Registry._members.InstanceMethods.InvokeVirtualObjectMethod("getRegisteredResourceClasses.(Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/Class;)Ljava/util/List;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(modelClass);
				GC.KeepAlive(resourceClass);
				GC.KeepAlive(transcodeClass);
			}
			return result;
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00007CE8 File Offset: 0x00005EE8
		private static Delegate GetGetResultEncoder_Lcom_bumptech_glide_load_engine_Resource_Handler()
		{
			if (Registry.cb_getResultEncoder_Lcom_bumptech_glide_load_engine_Resource_ == null)
			{
				Registry.cb_getResultEncoder_Lcom_bumptech_glide_load_engine_Resource_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(Registry.n_GetResultEncoder_Lcom_bumptech_glide_load_engine_Resource_));
			}
			return Registry.cb_getResultEncoder_Lcom_bumptech_glide_load_engine_Resource_;
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00007D0C File Offset: 0x00005F0C
		private static IntPtr n_GetResultEncoder_Lcom_bumptech_glide_load_engine_Resource_(IntPtr jnienv, IntPtr native__this, IntPtr native_resource)
		{
			Registry @object = Java.Lang.Object.GetObject<Registry>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IResource object2 = Java.Lang.Object.GetObject<IResource>(native_resource, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetResultEncoder(object2));
		}

		// Token: 0x0600024B RID: 587 RVA: 0x00007D34 File Offset: 0x00005F34
		[Register("getResultEncoder", "(Lcom/bumptech/glide/load/engine/Resource;)Lcom/bumptech/glide/load/ResourceEncoder;", "GetGetResultEncoder_Lcom_bumptech_glide_load_engine_Resource_Handler")]
		[JavaTypeParameters(new string[]
		{
			"X"
		})]
		public unsafe virtual IResourceEncoder GetResultEncoder(IResource resource)
		{
			IResourceEncoder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((resource == null) ? IntPtr.Zero : ((Java.Lang.Object)resource).Handle);
				@object = Java.Lang.Object.GetObject<IResourceEncoder>(Registry._members.InstanceMethods.InvokeVirtualObjectMethod("getResultEncoder.(Lcom/bumptech/glide/load/engine/Resource;)Lcom/bumptech/glide/load/ResourceEncoder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(resource);
			}
			return @object;
		}

		// Token: 0x0600024C RID: 588 RVA: 0x00007DAC File Offset: 0x00005FAC
		private static Delegate GetGetRewinder_Ljava_lang_Object_Handler()
		{
			if (Registry.cb_getRewinder_Ljava_lang_Object_ == null)
			{
				Registry.cb_getRewinder_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(Registry.n_GetRewinder_Ljava_lang_Object_));
			}
			return Registry.cb_getRewinder_Ljava_lang_Object_;
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00007DD0 File Offset: 0x00005FD0
		private static IntPtr n_GetRewinder_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_data)
		{
			Registry @object = Java.Lang.Object.GetObject<Registry>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_data, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetRewinder(object2));
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00007DF8 File Offset: 0x00005FF8
		[Register("getRewinder", "(Ljava/lang/Object;)Lcom/bumptech/glide/load/data/DataRewinder;", "GetGetRewinder_Ljava_lang_Object_Handler")]
		[JavaTypeParameters(new string[]
		{
			"X"
		})]
		public unsafe virtual IDataRewinder GetRewinder(Java.Lang.Object data)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(data);
			IDataRewinder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<IDataRewinder>(Registry._members.InstanceMethods.InvokeVirtualObjectMethod("getRewinder.(Ljava/lang/Object;)Lcom/bumptech/glide/load/data/DataRewinder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(data);
			}
			return @object;
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00007E6C File Offset: 0x0000606C
		private static Delegate GetGetSourceEncoder_Ljava_lang_Object_Handler()
		{
			if (Registry.cb_getSourceEncoder_Ljava_lang_Object_ == null)
			{
				Registry.cb_getSourceEncoder_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(Registry.n_GetSourceEncoder_Ljava_lang_Object_));
			}
			return Registry.cb_getSourceEncoder_Ljava_lang_Object_;
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00007E90 File Offset: 0x00006090
		private static IntPtr n_GetSourceEncoder_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_data)
		{
			Registry @object = Java.Lang.Object.GetObject<Registry>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_data, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetSourceEncoder(object2));
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00007EB8 File Offset: 0x000060B8
		[Register("getSourceEncoder", "(Ljava/lang/Object;)Lcom/bumptech/glide/load/Encoder;", "GetGetSourceEncoder_Ljava_lang_Object_Handler")]
		[JavaTypeParameters(new string[]
		{
			"X"
		})]
		public unsafe virtual IEncoder GetSourceEncoder(Java.Lang.Object data)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(data);
			IEncoder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<IEncoder>(Registry._members.InstanceMethods.InvokeVirtualObjectMethod("getSourceEncoder.(Ljava/lang/Object;)Lcom/bumptech/glide/load/Encoder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(data);
			}
			return @object;
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00007F2C File Offset: 0x0000612C
		private static Delegate GetIsResourceEncoderAvailable_Lcom_bumptech_glide_load_engine_Resource_Handler()
		{
			if (Registry.cb_isResourceEncoderAvailable_Lcom_bumptech_glide_load_engine_Resource_ == null)
			{
				Registry.cb_isResourceEncoderAvailable_Lcom_bumptech_glide_load_engine_Resource_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(Registry.n_IsResourceEncoderAvailable_Lcom_bumptech_glide_load_engine_Resource_));
			}
			return Registry.cb_isResourceEncoderAvailable_Lcom_bumptech_glide_load_engine_Resource_;
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00007F50 File Offset: 0x00006150
		private static bool n_IsResourceEncoderAvailable_Lcom_bumptech_glide_load_engine_Resource_(IntPtr jnienv, IntPtr native__this, IntPtr native_resource)
		{
			Registry @object = Java.Lang.Object.GetObject<Registry>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IResource object2 = Java.Lang.Object.GetObject<IResource>(native_resource, JniHandleOwnership.DoNotTransfer);
			return @object.IsResourceEncoderAvailable(object2);
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00007F74 File Offset: 0x00006174
		[Register("isResourceEncoderAvailable", "(Lcom/bumptech/glide/load/engine/Resource;)Z", "GetIsResourceEncoderAvailable_Lcom_bumptech_glide_load_engine_Resource_Handler")]
		public unsafe virtual bool IsResourceEncoderAvailable(IResource resource)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((resource == null) ? IntPtr.Zero : ((Java.Lang.Object)resource).Handle);
				result = Registry._members.InstanceMethods.InvokeVirtualBooleanMethod("isResourceEncoderAvailable.(Lcom/bumptech/glide/load/engine/Resource;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(resource);
			}
			return result;
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00007FE0 File Offset: 0x000061E0
		private static Delegate GetPrepend_Ljava_lang_Class_Lcom_bumptech_glide_load_Encoder_Handler()
		{
			if (Registry.cb_prepend_Ljava_lang_Class_Lcom_bumptech_glide_load_Encoder_ == null)
			{
				Registry.cb_prepend_Ljava_lang_Class_Lcom_bumptech_glide_load_Encoder_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(Registry.n_Prepend_Ljava_lang_Class_Lcom_bumptech_glide_load_Encoder_));
			}
			return Registry.cb_prepend_Ljava_lang_Class_Lcom_bumptech_glide_load_Encoder_;
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00008004 File Offset: 0x00006204
		private static IntPtr n_Prepend_Ljava_lang_Class_Lcom_bumptech_glide_load_Encoder_(IntPtr jnienv, IntPtr native__this, IntPtr native_dataClass, IntPtr native_encoder)
		{
			Registry @object = Java.Lang.Object.GetObject<Registry>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Java.Lang.Object.GetObject<Class>(native_dataClass, JniHandleOwnership.DoNotTransfer);
			IEncoder object3 = Java.Lang.Object.GetObject<IEncoder>(native_encoder, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Prepend(object2, object3));
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00008038 File Offset: 0x00006238
		[Register("prepend", "(Ljava/lang/Class;Lcom/bumptech/glide/load/Encoder;)Lcom/bumptech/glide/Registry;", "GetPrepend_Ljava_lang_Class_Lcom_bumptech_glide_load_Encoder_Handler")]
		[JavaTypeParameters(new string[]
		{
			"Data"
		})]
		public unsafe virtual Registry Prepend(Class dataClass, IEncoder encoder)
		{
			Registry @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((dataClass == null) ? IntPtr.Zero : dataClass.Handle);
				ptr[1] = new JniArgumentValue((encoder == null) ? IntPtr.Zero : ((Java.Lang.Object)encoder).Handle);
				@object = Java.Lang.Object.GetObject<Registry>(Registry._members.InstanceMethods.InvokeVirtualObjectMethod("prepend.(Ljava/lang/Class;Lcom/bumptech/glide/load/Encoder;)Lcom/bumptech/glide/Registry;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(dataClass);
				GC.KeepAlive(encoder);
			}
			return @object;
		}

		// Token: 0x06000258 RID: 600 RVA: 0x000080D8 File Offset: 0x000062D8
		private static Delegate GetPrepend_Ljava_lang_Class_Lcom_bumptech_glide_load_ResourceEncoder_Handler()
		{
			if (Registry.cb_prepend_Ljava_lang_Class_Lcom_bumptech_glide_load_ResourceEncoder_ == null)
			{
				Registry.cb_prepend_Ljava_lang_Class_Lcom_bumptech_glide_load_ResourceEncoder_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(Registry.n_Prepend_Ljava_lang_Class_Lcom_bumptech_glide_load_ResourceEncoder_));
			}
			return Registry.cb_prepend_Ljava_lang_Class_Lcom_bumptech_glide_load_ResourceEncoder_;
		}

		// Token: 0x06000259 RID: 601 RVA: 0x000080FC File Offset: 0x000062FC
		private static IntPtr n_Prepend_Ljava_lang_Class_Lcom_bumptech_glide_load_ResourceEncoder_(IntPtr jnienv, IntPtr native__this, IntPtr native_resourceClass, IntPtr native_encoder)
		{
			Registry @object = Java.Lang.Object.GetObject<Registry>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Java.Lang.Object.GetObject<Class>(native_resourceClass, JniHandleOwnership.DoNotTransfer);
			IResourceEncoder object3 = Java.Lang.Object.GetObject<IResourceEncoder>(native_encoder, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Prepend(object2, object3));
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00008130 File Offset: 0x00006330
		[Register("prepend", "(Ljava/lang/Class;Lcom/bumptech/glide/load/ResourceEncoder;)Lcom/bumptech/glide/Registry;", "GetPrepend_Ljava_lang_Class_Lcom_bumptech_glide_load_ResourceEncoder_Handler")]
		[JavaTypeParameters(new string[]
		{
			"TResource"
		})]
		public unsafe virtual Registry Prepend(Class resourceClass, IResourceEncoder encoder)
		{
			Registry @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((resourceClass == null) ? IntPtr.Zero : resourceClass.Handle);
				ptr[1] = new JniArgumentValue((encoder == null) ? IntPtr.Zero : ((Java.Lang.Object)encoder).Handle);
				@object = Java.Lang.Object.GetObject<Registry>(Registry._members.InstanceMethods.InvokeVirtualObjectMethod("prepend.(Ljava/lang/Class;Lcom/bumptech/glide/load/ResourceEncoder;)Lcom/bumptech/glide/Registry;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(resourceClass);
				GC.KeepAlive(encoder);
			}
			return @object;
		}

		// Token: 0x0600025B RID: 603 RVA: 0x000081D0 File Offset: 0x000063D0
		private static Delegate GetPrepend_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_model_ModelLoaderFactory_Handler()
		{
			if (Registry.cb_prepend_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_model_ModelLoaderFactory_ == null)
			{
				Registry.cb_prepend_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_model_ModelLoaderFactory_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_L(Registry.n_Prepend_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_model_ModelLoaderFactory_));
			}
			return Registry.cb_prepend_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_model_ModelLoaderFactory_;
		}

		// Token: 0x0600025C RID: 604 RVA: 0x000081F4 File Offset: 0x000063F4
		private static IntPtr n_Prepend_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_model_ModelLoaderFactory_(IntPtr jnienv, IntPtr native__this, IntPtr native_modelClass, IntPtr native_dataClass, IntPtr native_factory)
		{
			Registry @object = Java.Lang.Object.GetObject<Registry>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Java.Lang.Object.GetObject<Class>(native_modelClass, JniHandleOwnership.DoNotTransfer);
			Class object3 = Java.Lang.Object.GetObject<Class>(native_dataClass, JniHandleOwnership.DoNotTransfer);
			IModelLoaderFactory object4 = Java.Lang.Object.GetObject<IModelLoaderFactory>(native_factory, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Prepend(object2, object3, object4));
		}

		// Token: 0x0600025D RID: 605 RVA: 0x00008230 File Offset: 0x00006430
		[Register("prepend", "(Ljava/lang/Class;Ljava/lang/Class;Lcom/bumptech/glide/load/model/ModelLoaderFactory;)Lcom/bumptech/glide/Registry;", "GetPrepend_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_model_ModelLoaderFactory_Handler")]
		[JavaTypeParameters(new string[]
		{
			"Model",
			"Data"
		})]
		public unsafe virtual Registry Prepend(Class modelClass, Class dataClass, IModelLoaderFactory factory)
		{
			Registry @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((modelClass == null) ? IntPtr.Zero : modelClass.Handle);
				ptr[1] = new JniArgumentValue((dataClass == null) ? IntPtr.Zero : dataClass.Handle);
				ptr[2] = new JniArgumentValue((factory == null) ? IntPtr.Zero : ((Java.Lang.Object)factory).Handle);
				@object = Java.Lang.Object.GetObject<Registry>(Registry._members.InstanceMethods.InvokeVirtualObjectMethod("prepend.(Ljava/lang/Class;Ljava/lang/Class;Lcom/bumptech/glide/load/model/ModelLoaderFactory;)Lcom/bumptech/glide/Registry;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(modelClass);
				GC.KeepAlive(dataClass);
				GC.KeepAlive(factory);
			}
			return @object;
		}

		// Token: 0x0600025E RID: 606 RVA: 0x000082FC File Offset: 0x000064FC
		private static Delegate GetPrepend_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_ResourceDecoder_Handler()
		{
			if (Registry.cb_prepend_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_ResourceDecoder_ == null)
			{
				Registry.cb_prepend_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_ResourceDecoder_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_L(Registry.n_Prepend_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_ResourceDecoder_));
			}
			return Registry.cb_prepend_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_ResourceDecoder_;
		}

		// Token: 0x0600025F RID: 607 RVA: 0x00008320 File Offset: 0x00006520
		private static IntPtr n_Prepend_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_ResourceDecoder_(IntPtr jnienv, IntPtr native__this, IntPtr native_dataClass, IntPtr native_resourceClass, IntPtr native_decoder)
		{
			Registry @object = Java.Lang.Object.GetObject<Registry>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Java.Lang.Object.GetObject<Class>(native_dataClass, JniHandleOwnership.DoNotTransfer);
			Class object3 = Java.Lang.Object.GetObject<Class>(native_resourceClass, JniHandleOwnership.DoNotTransfer);
			IResourceDecoder object4 = Java.Lang.Object.GetObject<IResourceDecoder>(native_decoder, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Prepend(object2, object3, object4));
		}

		// Token: 0x06000260 RID: 608 RVA: 0x0000835C File Offset: 0x0000655C
		[Register("prepend", "(Ljava/lang/Class;Ljava/lang/Class;Lcom/bumptech/glide/load/ResourceDecoder;)Lcom/bumptech/glide/Registry;", "GetPrepend_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_ResourceDecoder_Handler")]
		[JavaTypeParameters(new string[]
		{
			"Data",
			"TResource"
		})]
		public unsafe virtual Registry Prepend(Class dataClass, Class resourceClass, IResourceDecoder decoder)
		{
			Registry @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((dataClass == null) ? IntPtr.Zero : dataClass.Handle);
				ptr[1] = new JniArgumentValue((resourceClass == null) ? IntPtr.Zero : resourceClass.Handle);
				ptr[2] = new JniArgumentValue((decoder == null) ? IntPtr.Zero : ((Java.Lang.Object)decoder).Handle);
				@object = Java.Lang.Object.GetObject<Registry>(Registry._members.InstanceMethods.InvokeVirtualObjectMethod("prepend.(Ljava/lang/Class;Ljava/lang/Class;Lcom/bumptech/glide/load/ResourceDecoder;)Lcom/bumptech/glide/Registry;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(dataClass);
				GC.KeepAlive(resourceClass);
				GC.KeepAlive(decoder);
			}
			return @object;
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00008428 File Offset: 0x00006628
		private static Delegate GetPrepend_Ljava_lang_String_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_ResourceDecoder_Handler()
		{
			if (Registry.cb_prepend_Ljava_lang_String_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_ResourceDecoder_ == null)
			{
				Registry.cb_prepend_Ljava_lang_String_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_ResourceDecoder_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLL_L(Registry.n_Prepend_Ljava_lang_String_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_ResourceDecoder_));
			}
			return Registry.cb_prepend_Ljava_lang_String_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_ResourceDecoder_;
		}

		// Token: 0x06000262 RID: 610 RVA: 0x0000844C File Offset: 0x0000664C
		private static IntPtr n_Prepend_Ljava_lang_String_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_ResourceDecoder_(IntPtr jnienv, IntPtr native__this, IntPtr native_bucket, IntPtr native_dataClass, IntPtr native_resourceClass, IntPtr native_decoder)
		{
			Registry @object = Java.Lang.Object.GetObject<Registry>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_bucket, JniHandleOwnership.DoNotTransfer);
			Class object2 = Java.Lang.Object.GetObject<Class>(native_dataClass, JniHandleOwnership.DoNotTransfer);
			Class object3 = Java.Lang.Object.GetObject<Class>(native_resourceClass, JniHandleOwnership.DoNotTransfer);
			IResourceDecoder object4 = Java.Lang.Object.GetObject<IResourceDecoder>(native_decoder, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Prepend(@string, object2, object3, object4));
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00008494 File Offset: 0x00006694
		[Register("prepend", "(Ljava/lang/String;Ljava/lang/Class;Ljava/lang/Class;Lcom/bumptech/glide/load/ResourceDecoder;)Lcom/bumptech/glide/Registry;", "GetPrepend_Ljava_lang_String_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_ResourceDecoder_Handler")]
		[JavaTypeParameters(new string[]
		{
			"Data",
			"TResource"
		})]
		public unsafe virtual Registry Prepend(string bucket, Class dataClass, Class resourceClass, IResourceDecoder decoder)
		{
			IntPtr intPtr = JNIEnv.NewString(bucket);
			Registry @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((dataClass == null) ? IntPtr.Zero : dataClass.Handle);
				ptr[2] = new JniArgumentValue((resourceClass == null) ? IntPtr.Zero : resourceClass.Handle);
				ptr[3] = new JniArgumentValue((decoder == null) ? IntPtr.Zero : ((Java.Lang.Object)decoder).Handle);
				@object = Java.Lang.Object.GetObject<Registry>(Registry._members.InstanceMethods.InvokeVirtualObjectMethod("prepend.(Ljava/lang/String;Ljava/lang/Class;Ljava/lang/Class;Lcom/bumptech/glide/load/ResourceDecoder;)Lcom/bumptech/glide/Registry;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(dataClass);
				GC.KeepAlive(resourceClass);
				GC.KeepAlive(decoder);
			}
			return @object;
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00008588 File Offset: 0x00006788
		private static Delegate GetRegister_Lcom_bumptech_glide_load_data_DataRewinder_Factory_Handler()
		{
			if (Registry.cb_register_Lcom_bumptech_glide_load_data_DataRewinder_Factory_ == null)
			{
				Registry.cb_register_Lcom_bumptech_glide_load_data_DataRewinder_Factory_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(Registry.n_Register_Lcom_bumptech_glide_load_data_DataRewinder_Factory_));
			}
			return Registry.cb_register_Lcom_bumptech_glide_load_data_DataRewinder_Factory_;
		}

		// Token: 0x06000265 RID: 613 RVA: 0x000085AC File Offset: 0x000067AC
		private static IntPtr n_Register_Lcom_bumptech_glide_load_data_DataRewinder_Factory_(IntPtr jnienv, IntPtr native__this, IntPtr native_factory)
		{
			Registry @object = Java.Lang.Object.GetObject<Registry>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IDataRewinderFactory object2 = Java.Lang.Object.GetObject<IDataRewinderFactory>(native_factory, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Register(object2));
		}

		// Token: 0x06000266 RID: 614 RVA: 0x000085D4 File Offset: 0x000067D4
		[Register("register", "(Lcom/bumptech/glide/load/data/DataRewinder$Factory;)Lcom/bumptech/glide/Registry;", "GetRegister_Lcom_bumptech_glide_load_data_DataRewinder_Factory_Handler")]
		public unsafe virtual Registry Register(IDataRewinderFactory factory)
		{
			Registry @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((factory == null) ? IntPtr.Zero : ((Java.Lang.Object)factory).Handle);
				@object = Java.Lang.Object.GetObject<Registry>(Registry._members.InstanceMethods.InvokeVirtualObjectMethod("register.(Lcom/bumptech/glide/load/data/DataRewinder$Factory;)Lcom/bumptech/glide/Registry;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(factory);
			}
			return @object;
		}

		// Token: 0x06000267 RID: 615 RVA: 0x0000864C File Offset: 0x0000684C
		private static Delegate GetRegister_Lcom_bumptech_glide_load_ImageHeaderParser_Handler()
		{
			if (Registry.cb_register_Lcom_bumptech_glide_load_ImageHeaderParser_ == null)
			{
				Registry.cb_register_Lcom_bumptech_glide_load_ImageHeaderParser_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(Registry.n_Register_Lcom_bumptech_glide_load_ImageHeaderParser_));
			}
			return Registry.cb_register_Lcom_bumptech_glide_load_ImageHeaderParser_;
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00008670 File Offset: 0x00006870
		private static IntPtr n_Register_Lcom_bumptech_glide_load_ImageHeaderParser_(IntPtr jnienv, IntPtr native__this, IntPtr native_parser)
		{
			Registry @object = Java.Lang.Object.GetObject<Registry>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IImageHeaderParser object2 = Java.Lang.Object.GetObject<IImageHeaderParser>(native_parser, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Register(object2));
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00008698 File Offset: 0x00006898
		[Register("register", "(Lcom/bumptech/glide/load/ImageHeaderParser;)Lcom/bumptech/glide/Registry;", "GetRegister_Lcom_bumptech_glide_load_ImageHeaderParser_Handler")]
		public unsafe virtual Registry Register(IImageHeaderParser parser)
		{
			Registry @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((parser == null) ? IntPtr.Zero : ((Java.Lang.Object)parser).Handle);
				@object = Java.Lang.Object.GetObject<Registry>(Registry._members.InstanceMethods.InvokeVirtualObjectMethod("register.(Lcom/bumptech/glide/load/ImageHeaderParser;)Lcom/bumptech/glide/Registry;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(parser);
			}
			return @object;
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00008710 File Offset: 0x00006910
		[Obsolete]
		private static Delegate GetRegister_Ljava_lang_Class_Lcom_bumptech_glide_load_Encoder_Handler()
		{
			if (Registry.cb_register_Ljava_lang_Class_Lcom_bumptech_glide_load_Encoder_ == null)
			{
				Registry.cb_register_Ljava_lang_Class_Lcom_bumptech_glide_load_Encoder_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(Registry.n_Register_Ljava_lang_Class_Lcom_bumptech_glide_load_Encoder_));
			}
			return Registry.cb_register_Ljava_lang_Class_Lcom_bumptech_glide_load_Encoder_;
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00008734 File Offset: 0x00006934
		[Obsolete]
		private static IntPtr n_Register_Ljava_lang_Class_Lcom_bumptech_glide_load_Encoder_(IntPtr jnienv, IntPtr native__this, IntPtr native_dataClass, IntPtr native_encoder)
		{
			Registry @object = Java.Lang.Object.GetObject<Registry>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Java.Lang.Object.GetObject<Class>(native_dataClass, JniHandleOwnership.DoNotTransfer);
			IEncoder object3 = Java.Lang.Object.GetObject<IEncoder>(native_encoder, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Register(object2, object3));
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00008768 File Offset: 0x00006968
		[Obsolete("deprecated")]
		[Register("register", "(Ljava/lang/Class;Lcom/bumptech/glide/load/Encoder;)Lcom/bumptech/glide/Registry;", "GetRegister_Ljava_lang_Class_Lcom_bumptech_glide_load_Encoder_Handler")]
		[JavaTypeParameters(new string[]
		{
			"Data"
		})]
		public unsafe virtual Registry Register(Class dataClass, IEncoder encoder)
		{
			Registry @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((dataClass == null) ? IntPtr.Zero : dataClass.Handle);
				ptr[1] = new JniArgumentValue((encoder == null) ? IntPtr.Zero : ((Java.Lang.Object)encoder).Handle);
				@object = Java.Lang.Object.GetObject<Registry>(Registry._members.InstanceMethods.InvokeVirtualObjectMethod("register.(Ljava/lang/Class;Lcom/bumptech/glide/load/Encoder;)Lcom/bumptech/glide/Registry;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(dataClass);
				GC.KeepAlive(encoder);
			}
			return @object;
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00008808 File Offset: 0x00006A08
		[Obsolete]
		private static Delegate GetRegister_Ljava_lang_Class_Lcom_bumptech_glide_load_ResourceEncoder_Handler()
		{
			if (Registry.cb_register_Ljava_lang_Class_Lcom_bumptech_glide_load_ResourceEncoder_ == null)
			{
				Registry.cb_register_Ljava_lang_Class_Lcom_bumptech_glide_load_ResourceEncoder_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(Registry.n_Register_Ljava_lang_Class_Lcom_bumptech_glide_load_ResourceEncoder_));
			}
			return Registry.cb_register_Ljava_lang_Class_Lcom_bumptech_glide_load_ResourceEncoder_;
		}

		// Token: 0x0600026E RID: 622 RVA: 0x0000882C File Offset: 0x00006A2C
		[Obsolete]
		private static IntPtr n_Register_Ljava_lang_Class_Lcom_bumptech_glide_load_ResourceEncoder_(IntPtr jnienv, IntPtr native__this, IntPtr native_resourceClass, IntPtr native_encoder)
		{
			Registry @object = Java.Lang.Object.GetObject<Registry>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Java.Lang.Object.GetObject<Class>(native_resourceClass, JniHandleOwnership.DoNotTransfer);
			IResourceEncoder object3 = Java.Lang.Object.GetObject<IResourceEncoder>(native_encoder, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Register(object2, object3));
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00008860 File Offset: 0x00006A60
		[Obsolete("deprecated")]
		[Register("register", "(Ljava/lang/Class;Lcom/bumptech/glide/load/ResourceEncoder;)Lcom/bumptech/glide/Registry;", "GetRegister_Ljava_lang_Class_Lcom_bumptech_glide_load_ResourceEncoder_Handler")]
		[JavaTypeParameters(new string[]
		{
			"TResource"
		})]
		public unsafe virtual Registry Register(Class resourceClass, IResourceEncoder encoder)
		{
			Registry @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((resourceClass == null) ? IntPtr.Zero : resourceClass.Handle);
				ptr[1] = new JniArgumentValue((encoder == null) ? IntPtr.Zero : ((Java.Lang.Object)encoder).Handle);
				@object = Java.Lang.Object.GetObject<Registry>(Registry._members.InstanceMethods.InvokeVirtualObjectMethod("register.(Ljava/lang/Class;Lcom/bumptech/glide/load/ResourceEncoder;)Lcom/bumptech/glide/Registry;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(resourceClass);
				GC.KeepAlive(encoder);
			}
			return @object;
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00008900 File Offset: 0x00006B00
		private static Delegate GetRegister_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_Handler()
		{
			if (Registry.cb_register_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_ == null)
			{
				Registry.cb_register_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_L(Registry.n_Register_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_));
			}
			return Registry.cb_register_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_;
		}

		// Token: 0x06000271 RID: 625 RVA: 0x00008924 File Offset: 0x00006B24
		private static IntPtr n_Register_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_(IntPtr jnienv, IntPtr native__this, IntPtr native_resourceClass, IntPtr native_transcodeClass, IntPtr native_transcoder)
		{
			Registry @object = Java.Lang.Object.GetObject<Registry>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Java.Lang.Object.GetObject<Class>(native_resourceClass, JniHandleOwnership.DoNotTransfer);
			Class object3 = Java.Lang.Object.GetObject<Class>(native_transcodeClass, JniHandleOwnership.DoNotTransfer);
			IResourceTranscoder object4 = Java.Lang.Object.GetObject<IResourceTranscoder>(native_transcoder, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Register(object2, object3, object4));
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00008960 File Offset: 0x00006B60
		[Register("register", "(Ljava/lang/Class;Ljava/lang/Class;Lcom/bumptech/glide/load/resource/transcode/ResourceTranscoder;)Lcom/bumptech/glide/Registry;", "GetRegister_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_Handler")]
		[JavaTypeParameters(new string[]
		{
			"TResource",
			"Transcode"
		})]
		public unsafe virtual Registry Register(Class resourceClass, Class transcodeClass, IResourceTranscoder transcoder)
		{
			Registry @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((resourceClass == null) ? IntPtr.Zero : resourceClass.Handle);
				ptr[1] = new JniArgumentValue((transcodeClass == null) ? IntPtr.Zero : transcodeClass.Handle);
				ptr[2] = new JniArgumentValue((transcoder == null) ? IntPtr.Zero : ((Java.Lang.Object)transcoder).Handle);
				@object = Java.Lang.Object.GetObject<Registry>(Registry._members.InstanceMethods.InvokeVirtualObjectMethod("register.(Ljava/lang/Class;Ljava/lang/Class;Lcom/bumptech/glide/load/resource/transcode/ResourceTranscoder;)Lcom/bumptech/glide/Registry;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(resourceClass);
				GC.KeepAlive(transcodeClass);
				GC.KeepAlive(transcoder);
			}
			return @object;
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00008A2C File Offset: 0x00006C2C
		private static Delegate GetReplace_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_model_ModelLoaderFactory_Handler()
		{
			if (Registry.cb_replace_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_model_ModelLoaderFactory_ == null)
			{
				Registry.cb_replace_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_model_ModelLoaderFactory_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_L(Registry.n_Replace_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_model_ModelLoaderFactory_));
			}
			return Registry.cb_replace_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_model_ModelLoaderFactory_;
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00008A50 File Offset: 0x00006C50
		private static IntPtr n_Replace_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_model_ModelLoaderFactory_(IntPtr jnienv, IntPtr native__this, IntPtr native_modelClass, IntPtr native_dataClass, IntPtr native_factory)
		{
			Registry @object = Java.Lang.Object.GetObject<Registry>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Java.Lang.Object.GetObject<Class>(native_modelClass, JniHandleOwnership.DoNotTransfer);
			Class object3 = Java.Lang.Object.GetObject<Class>(native_dataClass, JniHandleOwnership.DoNotTransfer);
			IModelLoaderFactory object4 = Java.Lang.Object.GetObject<IModelLoaderFactory>(native_factory, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Replace(object2, object3, object4));
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00008A8C File Offset: 0x00006C8C
		[Register("replace", "(Ljava/lang/Class;Ljava/lang/Class;Lcom/bumptech/glide/load/model/ModelLoaderFactory;)Lcom/bumptech/glide/Registry;", "GetReplace_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_model_ModelLoaderFactory_Handler")]
		[JavaTypeParameters(new string[]
		{
			"Model",
			"Data"
		})]
		public unsafe virtual Registry Replace(Class modelClass, Class dataClass, IModelLoaderFactory factory)
		{
			Registry @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((modelClass == null) ? IntPtr.Zero : modelClass.Handle);
				ptr[1] = new JniArgumentValue((dataClass == null) ? IntPtr.Zero : dataClass.Handle);
				ptr[2] = new JniArgumentValue((factory == null) ? IntPtr.Zero : ((Java.Lang.Object)factory).Handle);
				@object = Java.Lang.Object.GetObject<Registry>(Registry._members.InstanceMethods.InvokeVirtualObjectMethod("replace.(Ljava/lang/Class;Ljava/lang/Class;Lcom/bumptech/glide/load/model/ModelLoaderFactory;)Lcom/bumptech/glide/Registry;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(modelClass);
				GC.KeepAlive(dataClass);
				GC.KeepAlive(factory);
			}
			return @object;
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00008B58 File Offset: 0x00006D58
		[Register("setResourceDecoderBucketPriorityList", "(Ljava/util/List;)Lcom/bumptech/glide/Registry;", "")]
		public unsafe Registry SetResourceDecoderBucketPriorityList(IList<string> buckets)
		{
			IntPtr intPtr = JavaList<string>.ToLocalJniHandle(buckets);
			Registry @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Registry>(Registry._members.InstanceMethods.InvokeNonvirtualObjectMethod("setResourceDecoderBucketPriorityList.(Ljava/util/List;)Lcom/bumptech/glide/Registry;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(buckets);
			}
			return @object;
		}

		// Token: 0x04000060 RID: 96
		[Register("BUCKET_ANIMATION")]
		public const string BucketAnimation = "Animation";

		// Token: 0x04000061 RID: 97
		[Register("BUCKET_BITMAP")]
		public const string BucketBitmap = "Bitmap";

		// Token: 0x04000062 RID: 98
		[Register("BUCKET_BITMAP_DRAWABLE")]
		public const string BucketBitmapDrawable = "BitmapDrawable";

		// Token: 0x04000063 RID: 99
		[Register("BUCKET_GIF")]
		[Obsolete("deprecated")]
		public const string BucketGif = "Animation";

		// Token: 0x04000064 RID: 100
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/Registry", typeof(Registry));

		// Token: 0x04000065 RID: 101
		private static Delegate cb_getImageHeaderParsers;

		// Token: 0x04000066 RID: 102
		private static Delegate cb_append_Ljava_lang_Class_Lcom_bumptech_glide_load_Encoder_;

		// Token: 0x04000067 RID: 103
		private static Delegate cb_append_Ljava_lang_Class_Lcom_bumptech_glide_load_ResourceEncoder_;

		// Token: 0x04000068 RID: 104
		private static Delegate cb_append_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_model_ModelLoaderFactory_;

		// Token: 0x04000069 RID: 105
		private static Delegate cb_append_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_ResourceDecoder_;

		// Token: 0x0400006A RID: 106
		private static Delegate cb_append_Ljava_lang_String_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_ResourceDecoder_;

		// Token: 0x0400006B RID: 107
		private static Delegate cb_getLoadPath_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_Class_;

		// Token: 0x0400006C RID: 108
		private static Delegate cb_getModelLoaders_Ljava_lang_Object_;

		// Token: 0x0400006D RID: 109
		private static Delegate cb_getRegisteredResourceClasses_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_Class_;

		// Token: 0x0400006E RID: 110
		private static Delegate cb_getResultEncoder_Lcom_bumptech_glide_load_engine_Resource_;

		// Token: 0x0400006F RID: 111
		private static Delegate cb_getRewinder_Ljava_lang_Object_;

		// Token: 0x04000070 RID: 112
		private static Delegate cb_getSourceEncoder_Ljava_lang_Object_;

		// Token: 0x04000071 RID: 113
		private static Delegate cb_isResourceEncoderAvailable_Lcom_bumptech_glide_load_engine_Resource_;

		// Token: 0x04000072 RID: 114
		private static Delegate cb_prepend_Ljava_lang_Class_Lcom_bumptech_glide_load_Encoder_;

		// Token: 0x04000073 RID: 115
		private static Delegate cb_prepend_Ljava_lang_Class_Lcom_bumptech_glide_load_ResourceEncoder_;

		// Token: 0x04000074 RID: 116
		private static Delegate cb_prepend_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_model_ModelLoaderFactory_;

		// Token: 0x04000075 RID: 117
		private static Delegate cb_prepend_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_ResourceDecoder_;

		// Token: 0x04000076 RID: 118
		private static Delegate cb_prepend_Ljava_lang_String_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_ResourceDecoder_;

		// Token: 0x04000077 RID: 119
		private static Delegate cb_register_Lcom_bumptech_glide_load_data_DataRewinder_Factory_;

		// Token: 0x04000078 RID: 120
		private static Delegate cb_register_Lcom_bumptech_glide_load_ImageHeaderParser_;

		// Token: 0x04000079 RID: 121
		private static Delegate cb_register_Ljava_lang_Class_Lcom_bumptech_glide_load_Encoder_;

		// Token: 0x0400007A RID: 122
		private static Delegate cb_register_Ljava_lang_Class_Lcom_bumptech_glide_load_ResourceEncoder_;

		// Token: 0x0400007B RID: 123
		private static Delegate cb_register_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_;

		// Token: 0x0400007C RID: 124
		private static Delegate cb_replace_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_model_ModelLoaderFactory_;

		// Token: 0x020001AA RID: 426
		[Register("com/bumptech/glide/Registry$MissingComponentException", DoNotGenerateAcw = true)]
		public class MissingComponentException : RuntimeException
		{
			// Token: 0x170005A9 RID: 1449
			// (get) Token: 0x06001545 RID: 5445 RVA: 0x0004324C File Offset: 0x0004144C
			internal static IntPtr class_ref
			{
				get
				{
					return Registry.MissingComponentException._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170005AA RID: 1450
			// (get) Token: 0x06001546 RID: 5446 RVA: 0x00043270 File Offset: 0x00041470
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return Registry.MissingComponentException._members;
				}
			}

			// Token: 0x170005AB RID: 1451
			// (get) Token: 0x06001547 RID: 5447 RVA: 0x00043278 File Offset: 0x00041478
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return Registry.MissingComponentException._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170005AC RID: 1452
			// (get) Token: 0x06001548 RID: 5448 RVA: 0x0004329C File Offset: 0x0004149C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return Registry.MissingComponentException._members.ManagedPeerType;
				}
			}

			// Token: 0x06001549 RID: 5449 RVA: 0x000432A8 File Offset: 0x000414A8
			protected MissingComponentException(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x0600154A RID: 5450 RVA: 0x000432B4 File Offset: 0x000414B4
			[Register(".ctor", "(Ljava/lang/String;)V", "")]
			public unsafe MissingComponentException(string message) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				IntPtr intPtr = JNIEnv.NewString(message);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					base.SetHandle(Registry.MissingComponentException._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					Registry.MissingComponentException._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}

			// Token: 0x0400050F RID: 1295
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/Registry$MissingComponentException", typeof(Registry.MissingComponentException));
		}

		// Token: 0x020001AB RID: 427
		[Register("com/bumptech/glide/Registry$NoImageHeaderParserException", DoNotGenerateAcw = true)]
		public sealed class NoImageHeaderParserException : Registry.MissingComponentException
		{
			// Token: 0x170005AD RID: 1453
			// (get) Token: 0x0600154C RID: 5452 RVA: 0x00043374 File Offset: 0x00041574
			internal new static IntPtr class_ref
			{
				get
				{
					return Registry.NoImageHeaderParserException._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170005AE RID: 1454
			// (get) Token: 0x0600154D RID: 5453 RVA: 0x00043398 File Offset: 0x00041598
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return Registry.NoImageHeaderParserException._members;
				}
			}

			// Token: 0x170005AF RID: 1455
			// (get) Token: 0x0600154E RID: 5454 RVA: 0x000433A0 File Offset: 0x000415A0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return Registry.NoImageHeaderParserException._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170005B0 RID: 1456
			// (get) Token: 0x0600154F RID: 5455 RVA: 0x000433C4 File Offset: 0x000415C4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return Registry.NoImageHeaderParserException._members.ManagedPeerType;
				}
			}

			// Token: 0x06001550 RID: 5456 RVA: 0x000433D0 File Offset: 0x000415D0
			internal NoImageHeaderParserException(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06001551 RID: 5457 RVA: 0x000433DC File Offset: 0x000415DC
			[Register(".ctor", "()V", "")]
			public NoImageHeaderParserException() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(Registry.NoImageHeaderParserException._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				Registry.NoImageHeaderParserException._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x04000510 RID: 1296
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/Registry$NoImageHeaderParserException", typeof(Registry.NoImageHeaderParserException));
		}

		// Token: 0x020001AC RID: 428
		[Register("com/bumptech/glide/Registry$NoModelLoaderAvailableException", DoNotGenerateAcw = true)]
		public class NoModelLoaderAvailableException : Registry.MissingComponentException
		{
			// Token: 0x170005B1 RID: 1457
			// (get) Token: 0x06001553 RID: 5459 RVA: 0x00043468 File Offset: 0x00041668
			internal new static IntPtr class_ref
			{
				get
				{
					return Registry.NoModelLoaderAvailableException._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170005B2 RID: 1458
			// (get) Token: 0x06001554 RID: 5460 RVA: 0x0004348C File Offset: 0x0004168C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return Registry.NoModelLoaderAvailableException._members;
				}
			}

			// Token: 0x170005B3 RID: 1459
			// (get) Token: 0x06001555 RID: 5461 RVA: 0x00043494 File Offset: 0x00041694
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return Registry.NoModelLoaderAvailableException._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170005B4 RID: 1460
			// (get) Token: 0x06001556 RID: 5462 RVA: 0x000434B8 File Offset: 0x000416B8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return Registry.NoModelLoaderAvailableException._members.ManagedPeerType;
				}
			}

			// Token: 0x06001557 RID: 5463 RVA: 0x000434C4 File Offset: 0x000416C4
			protected NoModelLoaderAvailableException(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06001558 RID: 5464 RVA: 0x000434D0 File Offset: 0x000416D0
			[Register(".ctor", "(Ljava/lang/Class;Ljava/lang/Class;)V", "")]
			public unsafe NoModelLoaderAvailableException(Class modelClass, Class dataClass) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((modelClass == null) ? IntPtr.Zero : modelClass.Handle);
					ptr[1] = new JniArgumentValue((dataClass == null) ? IntPtr.Zero : dataClass.Handle);
					base.SetHandle(Registry.NoModelLoaderAvailableException._members.InstanceMethods.StartCreateInstance("(Ljava/lang/Class;Ljava/lang/Class;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					Registry.NoModelLoaderAvailableException._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/Class;Ljava/lang/Class;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(modelClass);
					GC.KeepAlive(dataClass);
				}
			}

			// Token: 0x06001559 RID: 5465 RVA: 0x000435A8 File Offset: 0x000417A8
			[Register(".ctor", "(Ljava/lang/Object;)V", "")]
			public unsafe NoModelLoaderAvailableException(Java.Lang.Object model) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((model == null) ? IntPtr.Zero : model.Handle);
					base.SetHandle(Registry.NoModelLoaderAvailableException._members.InstanceMethods.StartCreateInstance("(Ljava/lang/Object;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					Registry.NoModelLoaderAvailableException._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/Object;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(model);
				}
			}

			// Token: 0x0600155A RID: 5466 RVA: 0x00043658 File Offset: 0x00041858
			[Register(".ctor", "(Ljava/lang/Object;Ljava/util/List;)V", "")]
			public unsafe NoModelLoaderAvailableException(Java.Lang.Object model, IList matchingButNotHandlingModelLoaders) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(model);
				IntPtr intPtr2 = JavaList.ToLocalJniHandle(matchingButNotHandlingModelLoaders);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					ptr[1] = new JniArgumentValue(intPtr2);
					base.SetHandle(Registry.NoModelLoaderAvailableException._members.InstanceMethods.StartCreateInstance("(Ljava/lang/Object;Ljava/util/List;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					Registry.NoModelLoaderAvailableException._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/Object;Ljava/util/List;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					JNIEnv.DeleteLocalRef(intPtr2);
					GC.KeepAlive(model);
					GC.KeepAlive(matchingButNotHandlingModelLoaders);
				}
			}

			// Token: 0x04000511 RID: 1297
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/Registry$NoModelLoaderAvailableException", typeof(Registry.NoModelLoaderAvailableException));
		}

		// Token: 0x020001AD RID: 429
		[Register("com/bumptech/glide/Registry$NoResultEncoderAvailableException", DoNotGenerateAcw = true)]
		public class NoResultEncoderAvailableException : Registry.MissingComponentException
		{
			// Token: 0x170005B5 RID: 1461
			// (get) Token: 0x0600155C RID: 5468 RVA: 0x00043744 File Offset: 0x00041944
			internal new static IntPtr class_ref
			{
				get
				{
					return Registry.NoResultEncoderAvailableException._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170005B6 RID: 1462
			// (get) Token: 0x0600155D RID: 5469 RVA: 0x00043768 File Offset: 0x00041968
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return Registry.NoResultEncoderAvailableException._members;
				}
			}

			// Token: 0x170005B7 RID: 1463
			// (get) Token: 0x0600155E RID: 5470 RVA: 0x00043770 File Offset: 0x00041970
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return Registry.NoResultEncoderAvailableException._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170005B8 RID: 1464
			// (get) Token: 0x0600155F RID: 5471 RVA: 0x00043794 File Offset: 0x00041994
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return Registry.NoResultEncoderAvailableException._members.ManagedPeerType;
				}
			}

			// Token: 0x06001560 RID: 5472 RVA: 0x000437A0 File Offset: 0x000419A0
			protected NoResultEncoderAvailableException(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06001561 RID: 5473 RVA: 0x000437AC File Offset: 0x000419AC
			[Register(".ctor", "(Ljava/lang/Class;)V", "")]
			public unsafe NoResultEncoderAvailableException(Class resourceClass) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((resourceClass == null) ? IntPtr.Zero : resourceClass.Handle);
					base.SetHandle(Registry.NoResultEncoderAvailableException._members.InstanceMethods.StartCreateInstance("(Ljava/lang/Class;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					Registry.NoResultEncoderAvailableException._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/Class;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(resourceClass);
				}
			}

			// Token: 0x04000512 RID: 1298
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/Registry$NoResultEncoderAvailableException", typeof(Registry.NoResultEncoderAvailableException));
		}

		// Token: 0x020001AE RID: 430
		[Register("com/bumptech/glide/Registry$NoSourceEncoderAvailableException", DoNotGenerateAcw = true)]
		public class NoSourceEncoderAvailableException : Registry.MissingComponentException
		{
			// Token: 0x170005B9 RID: 1465
			// (get) Token: 0x06001563 RID: 5475 RVA: 0x00043878 File Offset: 0x00041A78
			internal new static IntPtr class_ref
			{
				get
				{
					return Registry.NoSourceEncoderAvailableException._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170005BA RID: 1466
			// (get) Token: 0x06001564 RID: 5476 RVA: 0x0004389C File Offset: 0x00041A9C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return Registry.NoSourceEncoderAvailableException._members;
				}
			}

			// Token: 0x170005BB RID: 1467
			// (get) Token: 0x06001565 RID: 5477 RVA: 0x000438A4 File Offset: 0x00041AA4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return Registry.NoSourceEncoderAvailableException._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170005BC RID: 1468
			// (get) Token: 0x06001566 RID: 5478 RVA: 0x000438C8 File Offset: 0x00041AC8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return Registry.NoSourceEncoderAvailableException._members.ManagedPeerType;
				}
			}

			// Token: 0x06001567 RID: 5479 RVA: 0x000438D4 File Offset: 0x00041AD4
			protected NoSourceEncoderAvailableException(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06001568 RID: 5480 RVA: 0x000438E0 File Offset: 0x00041AE0
			[Register(".ctor", "(Ljava/lang/Class;)V", "")]
			public unsafe NoSourceEncoderAvailableException(Class dataClass) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((dataClass == null) ? IntPtr.Zero : dataClass.Handle);
					base.SetHandle(Registry.NoSourceEncoderAvailableException._members.InstanceMethods.StartCreateInstance("(Ljava/lang/Class;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					Registry.NoSourceEncoderAvailableException._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/Class;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(dataClass);
				}
			}

			// Token: 0x04000513 RID: 1299
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/Registry$NoSourceEncoderAvailableException", typeof(Registry.NoSourceEncoderAvailableException));
		}
	}
}
