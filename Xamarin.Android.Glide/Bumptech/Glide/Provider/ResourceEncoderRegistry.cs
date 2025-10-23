using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Bumptech.Glide.Load;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Provider
{
	// Token: 0x02000064 RID: 100
	[Register("com/bumptech/glide/provider/ResourceEncoderRegistry", DoNotGenerateAcw = true)]
	public class ResourceEncoderRegistry : Java.Lang.Object
	{
		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000489 RID: 1161 RVA: 0x0000F69C File Offset: 0x0000D89C
		internal static IntPtr class_ref
		{
			get
			{
				return ResourceEncoderRegistry._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x0600048A RID: 1162 RVA: 0x0000F6C0 File Offset: 0x0000D8C0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ResourceEncoderRegistry._members;
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x0600048B RID: 1163 RVA: 0x0000F6C8 File Offset: 0x0000D8C8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ResourceEncoderRegistry._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x0600048C RID: 1164 RVA: 0x0000F6EC File Offset: 0x0000D8EC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ResourceEncoderRegistry._members.ManagedPeerType;
			}
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x0000F6F8 File Offset: 0x0000D8F8
		protected ResourceEncoderRegistry(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x0000F704 File Offset: 0x0000D904
		[Register(".ctor", "()V", "")]
		public ResourceEncoderRegistry() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(ResourceEncoderRegistry._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			ResourceEncoderRegistry._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x0000F772 File Offset: 0x0000D972
		private static Delegate GetAppend_Ljava_lang_Class_Lcom_bumptech_glide_load_ResourceEncoder_Handler()
		{
			if (ResourceEncoderRegistry.cb_append_Ljava_lang_Class_Lcom_bumptech_glide_load_ResourceEncoder_ == null)
			{
				ResourceEncoderRegistry.cb_append_Ljava_lang_Class_Lcom_bumptech_glide_load_ResourceEncoder_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(ResourceEncoderRegistry.n_Append_Ljava_lang_Class_Lcom_bumptech_glide_load_ResourceEncoder_));
			}
			return ResourceEncoderRegistry.cb_append_Ljava_lang_Class_Lcom_bumptech_glide_load_ResourceEncoder_;
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x0000F798 File Offset: 0x0000D998
		private static void n_Append_Ljava_lang_Class_Lcom_bumptech_glide_load_ResourceEncoder_(IntPtr jnienv, IntPtr native__this, IntPtr native_resourceClass, IntPtr native_encoder)
		{
			ResourceEncoderRegistry @object = Java.Lang.Object.GetObject<ResourceEncoderRegistry>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Java.Lang.Object.GetObject<Class>(native_resourceClass, JniHandleOwnership.DoNotTransfer);
			IResourceEncoder object3 = Java.Lang.Object.GetObject<IResourceEncoder>(native_encoder, JniHandleOwnership.DoNotTransfer);
			@object.Append(object2, object3);
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x0000F7C4 File Offset: 0x0000D9C4
		[Register("append", "(Ljava/lang/Class;Lcom/bumptech/glide/load/ResourceEncoder;)V", "GetAppend_Ljava_lang_Class_Lcom_bumptech_glide_load_ResourceEncoder_Handler")]
		[JavaTypeParameters(new string[]
		{
			"Z"
		})]
		public unsafe virtual void Append(Class resourceClass, IResourceEncoder encoder)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((resourceClass == null) ? IntPtr.Zero : resourceClass.Handle);
				ptr[1] = new JniArgumentValue((encoder == null) ? IntPtr.Zero : ((Java.Lang.Object)encoder).Handle);
				ResourceEncoderRegistry._members.InstanceMethods.InvokeVirtualVoidMethod("append.(Ljava/lang/Class;Lcom/bumptech/glide/load/ResourceEncoder;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(resourceClass);
				GC.KeepAlive(encoder);
			}
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x0000F854 File Offset: 0x0000DA54
		private static Delegate GetGet_Ljava_lang_Class_Handler()
		{
			if (ResourceEncoderRegistry.cb_get_Ljava_lang_Class_ == null)
			{
				ResourceEncoderRegistry.cb_get_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ResourceEncoderRegistry.n_Get_Ljava_lang_Class_));
			}
			return ResourceEncoderRegistry.cb_get_Ljava_lang_Class_;
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x0000F878 File Offset: 0x0000DA78
		private static IntPtr n_Get_Ljava_lang_Class_(IntPtr jnienv, IntPtr native__this, IntPtr native_resourceClass)
		{
			ResourceEncoderRegistry @object = Java.Lang.Object.GetObject<ResourceEncoderRegistry>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Java.Lang.Object.GetObject<Class>(native_resourceClass, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Get(object2));
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x0000F8A0 File Offset: 0x0000DAA0
		[Register("get", "(Ljava/lang/Class;)Lcom/bumptech/glide/load/ResourceEncoder;", "GetGet_Ljava_lang_Class_Handler")]
		[JavaTypeParameters(new string[]
		{
			"Z"
		})]
		public unsafe virtual IResourceEncoder Get(Class resourceClass)
		{
			IResourceEncoder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((resourceClass == null) ? IntPtr.Zero : resourceClass.Handle);
				@object = Java.Lang.Object.GetObject<IResourceEncoder>(ResourceEncoderRegistry._members.InstanceMethods.InvokeVirtualObjectMethod("get.(Ljava/lang/Class;)Lcom/bumptech/glide/load/ResourceEncoder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(resourceClass);
			}
			return @object;
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x0000F914 File Offset: 0x0000DB14
		private static Delegate GetPrepend_Ljava_lang_Class_Lcom_bumptech_glide_load_ResourceEncoder_Handler()
		{
			if (ResourceEncoderRegistry.cb_prepend_Ljava_lang_Class_Lcom_bumptech_glide_load_ResourceEncoder_ == null)
			{
				ResourceEncoderRegistry.cb_prepend_Ljava_lang_Class_Lcom_bumptech_glide_load_ResourceEncoder_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(ResourceEncoderRegistry.n_Prepend_Ljava_lang_Class_Lcom_bumptech_glide_load_ResourceEncoder_));
			}
			return ResourceEncoderRegistry.cb_prepend_Ljava_lang_Class_Lcom_bumptech_glide_load_ResourceEncoder_;
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x0000F938 File Offset: 0x0000DB38
		private static void n_Prepend_Ljava_lang_Class_Lcom_bumptech_glide_load_ResourceEncoder_(IntPtr jnienv, IntPtr native__this, IntPtr native_resourceClass, IntPtr native_encoder)
		{
			ResourceEncoderRegistry @object = Java.Lang.Object.GetObject<ResourceEncoderRegistry>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Java.Lang.Object.GetObject<Class>(native_resourceClass, JniHandleOwnership.DoNotTransfer);
			IResourceEncoder object3 = Java.Lang.Object.GetObject<IResourceEncoder>(native_encoder, JniHandleOwnership.DoNotTransfer);
			@object.Prepend(object2, object3);
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x0000F964 File Offset: 0x0000DB64
		[Register("prepend", "(Ljava/lang/Class;Lcom/bumptech/glide/load/ResourceEncoder;)V", "GetPrepend_Ljava_lang_Class_Lcom_bumptech_glide_load_ResourceEncoder_Handler")]
		[JavaTypeParameters(new string[]
		{
			"Z"
		})]
		public unsafe virtual void Prepend(Class resourceClass, IResourceEncoder encoder)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((resourceClass == null) ? IntPtr.Zero : resourceClass.Handle);
				ptr[1] = new JniArgumentValue((encoder == null) ? IntPtr.Zero : ((Java.Lang.Object)encoder).Handle);
				ResourceEncoderRegistry._members.InstanceMethods.InvokeVirtualVoidMethod("prepend.(Ljava/lang/Class;Lcom/bumptech/glide/load/ResourceEncoder;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(resourceClass);
				GC.KeepAlive(encoder);
			}
		}

		// Token: 0x040000F0 RID: 240
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/provider/ResourceEncoderRegistry", typeof(ResourceEncoderRegistry));

		// Token: 0x040000F1 RID: 241
		private static Delegate cb_append_Ljava_lang_Class_Lcom_bumptech_glide_load_ResourceEncoder_;

		// Token: 0x040000F2 RID: 242
		private static Delegate cb_get_Ljava_lang_Class_;

		// Token: 0x040000F3 RID: 243
		private static Delegate cb_prepend_Ljava_lang_Class_Lcom_bumptech_glide_load_ResourceEncoder_;
	}
}
