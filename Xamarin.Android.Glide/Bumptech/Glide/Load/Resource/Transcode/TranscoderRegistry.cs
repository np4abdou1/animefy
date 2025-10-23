using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Resource.Transcode
{
	// Token: 0x020000EB RID: 235
	[Register("com/bumptech/glide/load/resource/transcode/TranscoderRegistry", DoNotGenerateAcw = true)]
	public class TranscoderRegistry : Java.Lang.Object
	{
		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06000BAE RID: 2990 RVA: 0x00024790 File Offset: 0x00022990
		internal static IntPtr class_ref
		{
			get
			{
				return TranscoderRegistry._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06000BAF RID: 2991 RVA: 0x000247B4 File Offset: 0x000229B4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return TranscoderRegistry._members;
			}
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06000BB0 RID: 2992 RVA: 0x000247BC File Offset: 0x000229BC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return TranscoderRegistry._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06000BB1 RID: 2993 RVA: 0x000247E0 File Offset: 0x000229E0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return TranscoderRegistry._members.ManagedPeerType;
			}
		}

		// Token: 0x06000BB2 RID: 2994 RVA: 0x000247EC File Offset: 0x000229EC
		protected TranscoderRegistry(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000BB3 RID: 2995 RVA: 0x000247F8 File Offset: 0x000229F8
		[Register(".ctor", "()V", "")]
		public TranscoderRegistry() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(TranscoderRegistry._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			TranscoderRegistry._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000BB4 RID: 2996 RVA: 0x00024866 File Offset: 0x00022A66
		private static Delegate GetGet_Ljava_lang_Class_Ljava_lang_Class_Handler()
		{
			if (TranscoderRegistry.cb_get_Ljava_lang_Class_Ljava_lang_Class_ == null)
			{
				TranscoderRegistry.cb_get_Ljava_lang_Class_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(TranscoderRegistry.n_Get_Ljava_lang_Class_Ljava_lang_Class_));
			}
			return TranscoderRegistry.cb_get_Ljava_lang_Class_Ljava_lang_Class_;
		}

		// Token: 0x06000BB5 RID: 2997 RVA: 0x0002488C File Offset: 0x00022A8C
		private static IntPtr n_Get_Ljava_lang_Class_Ljava_lang_Class_(IntPtr jnienv, IntPtr native__this, IntPtr native_resourceClass, IntPtr native_transcodedClass)
		{
			TranscoderRegistry @object = Java.Lang.Object.GetObject<TranscoderRegistry>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Java.Lang.Object.GetObject<Class>(native_resourceClass, JniHandleOwnership.DoNotTransfer);
			Class object3 = Java.Lang.Object.GetObject<Class>(native_transcodedClass, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Get(object2, object3));
		}

		// Token: 0x06000BB6 RID: 2998 RVA: 0x000248C0 File Offset: 0x00022AC0
		[Register("get", "(Ljava/lang/Class;Ljava/lang/Class;)Lcom/bumptech/glide/load/resource/transcode/ResourceTranscoder;", "GetGet_Ljava_lang_Class_Ljava_lang_Class_Handler")]
		[JavaTypeParameters(new string[]
		{
			"Z",
			"R"
		})]
		public unsafe virtual IResourceTranscoder Get(Class resourceClass, Class transcodedClass)
		{
			IResourceTranscoder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((resourceClass == null) ? IntPtr.Zero : resourceClass.Handle);
				ptr[1] = new JniArgumentValue((transcodedClass == null) ? IntPtr.Zero : transcodedClass.Handle);
				@object = Java.Lang.Object.GetObject<IResourceTranscoder>(TranscoderRegistry._members.InstanceMethods.InvokeVirtualObjectMethod("get.(Ljava/lang/Class;Ljava/lang/Class;)Lcom/bumptech/glide/load/resource/transcode/ResourceTranscoder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(resourceClass);
				GC.KeepAlive(transcodedClass);
			}
			return @object;
		}

		// Token: 0x06000BB7 RID: 2999 RVA: 0x0002495C File Offset: 0x00022B5C
		private static Delegate GetGetTranscodeClasses_Ljava_lang_Class_Ljava_lang_Class_Handler()
		{
			if (TranscoderRegistry.cb_getTranscodeClasses_Ljava_lang_Class_Ljava_lang_Class_ == null)
			{
				TranscoderRegistry.cb_getTranscodeClasses_Ljava_lang_Class_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(TranscoderRegistry.n_GetTranscodeClasses_Ljava_lang_Class_Ljava_lang_Class_));
			}
			return TranscoderRegistry.cb_getTranscodeClasses_Ljava_lang_Class_Ljava_lang_Class_;
		}

		// Token: 0x06000BB8 RID: 3000 RVA: 0x00024980 File Offset: 0x00022B80
		private static IntPtr n_GetTranscodeClasses_Ljava_lang_Class_Ljava_lang_Class_(IntPtr jnienv, IntPtr native__this, IntPtr native_resourceClass, IntPtr native_transcodeClass)
		{
			TranscoderRegistry @object = Java.Lang.Object.GetObject<TranscoderRegistry>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Java.Lang.Object.GetObject<Class>(native_resourceClass, JniHandleOwnership.DoNotTransfer);
			Class object3 = Java.Lang.Object.GetObject<Class>(native_transcodeClass, JniHandleOwnership.DoNotTransfer);
			return JavaList<Class>.ToLocalJniHandle(@object.GetTranscodeClasses(object2, object3));
		}

		// Token: 0x06000BB9 RID: 3001 RVA: 0x000249B4 File Offset: 0x00022BB4
		[Register("getTranscodeClasses", "(Ljava/lang/Class;Ljava/lang/Class;)Ljava/util/List;", "GetGetTranscodeClasses_Ljava_lang_Class_Ljava_lang_Class_Handler")]
		[JavaTypeParameters(new string[]
		{
			"Z",
			"R"
		})]
		public unsafe virtual IList<Class> GetTranscodeClasses(Class resourceClass, Class transcodeClass)
		{
			IList<Class> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((resourceClass == null) ? IntPtr.Zero : resourceClass.Handle);
				ptr[1] = new JniArgumentValue((transcodeClass == null) ? IntPtr.Zero : transcodeClass.Handle);
				result = JavaList<Class>.FromJniHandle(TranscoderRegistry._members.InstanceMethods.InvokeVirtualObjectMethod("getTranscodeClasses.(Ljava/lang/Class;Ljava/lang/Class;)Ljava/util/List;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(resourceClass);
				GC.KeepAlive(transcodeClass);
			}
			return result;
		}

		// Token: 0x06000BBA RID: 3002 RVA: 0x00024A50 File Offset: 0x00022C50
		private static Delegate GetRegister_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_Handler()
		{
			if (TranscoderRegistry.cb_register_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_ == null)
			{
				TranscoderRegistry.cb_register_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(TranscoderRegistry.n_Register_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_));
			}
			return TranscoderRegistry.cb_register_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_;
		}

		// Token: 0x06000BBB RID: 3003 RVA: 0x00024A74 File Offset: 0x00022C74
		private static void n_Register_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_(IntPtr jnienv, IntPtr native__this, IntPtr native_decodedClass, IntPtr native_transcodedClass, IntPtr native_transcoder)
		{
			TranscoderRegistry @object = Java.Lang.Object.GetObject<TranscoderRegistry>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Java.Lang.Object.GetObject<Class>(native_decodedClass, JniHandleOwnership.DoNotTransfer);
			Class object3 = Java.Lang.Object.GetObject<Class>(native_transcodedClass, JniHandleOwnership.DoNotTransfer);
			IResourceTranscoder object4 = Java.Lang.Object.GetObject<IResourceTranscoder>(native_transcoder, JniHandleOwnership.DoNotTransfer);
			@object.Register(object2, object3, object4);
		}

		// Token: 0x06000BBC RID: 3004 RVA: 0x00024AAC File Offset: 0x00022CAC
		[Register("register", "(Ljava/lang/Class;Ljava/lang/Class;Lcom/bumptech/glide/load/resource/transcode/ResourceTranscoder;)V", "GetRegister_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_Handler")]
		[JavaTypeParameters(new string[]
		{
			"Z",
			"R"
		})]
		public unsafe virtual void Register(Class decodedClass, Class transcodedClass, IResourceTranscoder transcoder)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((decodedClass == null) ? IntPtr.Zero : decodedClass.Handle);
				ptr[1] = new JniArgumentValue((transcodedClass == null) ? IntPtr.Zero : transcodedClass.Handle);
				ptr[2] = new JniArgumentValue((transcoder == null) ? IntPtr.Zero : ((Java.Lang.Object)transcoder).Handle);
				TranscoderRegistry._members.InstanceMethods.InvokeVirtualVoidMethod("register.(Ljava/lang/Class;Ljava/lang/Class;Lcom/bumptech/glide/load/resource/transcode/ResourceTranscoder;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(decodedClass);
				GC.KeepAlive(transcodedClass);
				GC.KeepAlive(transcoder);
			}
		}

		// Token: 0x040002DB RID: 731
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/resource/transcode/TranscoderRegistry", typeof(TranscoderRegistry));

		// Token: 0x040002DC RID: 732
		private static Delegate cb_get_Ljava_lang_Class_Ljava_lang_Class_;

		// Token: 0x040002DD RID: 733
		private static Delegate cb_getTranscodeClasses_Ljava_lang_Class_Ljava_lang_Class_;

		// Token: 0x040002DE RID: 734
		private static Delegate cb_register_Ljava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_load_resource_transcode_ResourceTranscoder_;
	}
}
