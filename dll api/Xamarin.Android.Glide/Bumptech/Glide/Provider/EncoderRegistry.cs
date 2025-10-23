using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Bumptech.Glide.Load;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Provider
{
	// Token: 0x0200005F RID: 95
	[Register("com/bumptech/glide/provider/EncoderRegistry", DoNotGenerateAcw = true)]
	public class EncoderRegistry : Java.Lang.Object
	{
		// Token: 0x170000BF RID: 191
		// (get) Token: 0x0600043A RID: 1082 RVA: 0x0000E3BC File Offset: 0x0000C5BC
		internal static IntPtr class_ref
		{
			get
			{
				return EncoderRegistry._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x0600043B RID: 1083 RVA: 0x0000E3E0 File Offset: 0x0000C5E0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return EncoderRegistry._members;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x0600043C RID: 1084 RVA: 0x0000E3E8 File Offset: 0x0000C5E8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return EncoderRegistry._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x0600043D RID: 1085 RVA: 0x0000E40C File Offset: 0x0000C60C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return EncoderRegistry._members.ManagedPeerType;
			}
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x0000E418 File Offset: 0x0000C618
		protected EncoderRegistry(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x0000E424 File Offset: 0x0000C624
		[Register(".ctor", "()V", "")]
		public EncoderRegistry() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(EncoderRegistry._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			EncoderRegistry._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x0000E492 File Offset: 0x0000C692
		private static Delegate GetAppend_Ljava_lang_Class_Lcom_bumptech_glide_load_Encoder_Handler()
		{
			if (EncoderRegistry.cb_append_Ljava_lang_Class_Lcom_bumptech_glide_load_Encoder_ == null)
			{
				EncoderRegistry.cb_append_Ljava_lang_Class_Lcom_bumptech_glide_load_Encoder_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(EncoderRegistry.n_Append_Ljava_lang_Class_Lcom_bumptech_glide_load_Encoder_));
			}
			return EncoderRegistry.cb_append_Ljava_lang_Class_Lcom_bumptech_glide_load_Encoder_;
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x0000E4B8 File Offset: 0x0000C6B8
		private static void n_Append_Ljava_lang_Class_Lcom_bumptech_glide_load_Encoder_(IntPtr jnienv, IntPtr native__this, IntPtr native_dataClass, IntPtr native_encoder)
		{
			EncoderRegistry @object = Java.Lang.Object.GetObject<EncoderRegistry>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Java.Lang.Object.GetObject<Class>(native_dataClass, JniHandleOwnership.DoNotTransfer);
			IEncoder object3 = Java.Lang.Object.GetObject<IEncoder>(native_encoder, JniHandleOwnership.DoNotTransfer);
			@object.Append(object2, object3);
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x0000E4E4 File Offset: 0x0000C6E4
		[Register("append", "(Ljava/lang/Class;Lcom/bumptech/glide/load/Encoder;)V", "GetAppend_Ljava_lang_Class_Lcom_bumptech_glide_load_Encoder_Handler")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe virtual void Append(Class dataClass, IEncoder encoder)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((dataClass == null) ? IntPtr.Zero : dataClass.Handle);
				ptr[1] = new JniArgumentValue((encoder == null) ? IntPtr.Zero : ((Java.Lang.Object)encoder).Handle);
				EncoderRegistry._members.InstanceMethods.InvokeVirtualVoidMethod("append.(Ljava/lang/Class;Lcom/bumptech/glide/load/Encoder;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(dataClass);
				GC.KeepAlive(encoder);
			}
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x0000E574 File Offset: 0x0000C774
		private static Delegate GetGetEncoder_Ljava_lang_Class_Handler()
		{
			if (EncoderRegistry.cb_getEncoder_Ljava_lang_Class_ == null)
			{
				EncoderRegistry.cb_getEncoder_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(EncoderRegistry.n_GetEncoder_Ljava_lang_Class_));
			}
			return EncoderRegistry.cb_getEncoder_Ljava_lang_Class_;
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x0000E598 File Offset: 0x0000C798
		private static IntPtr n_GetEncoder_Ljava_lang_Class_(IntPtr jnienv, IntPtr native__this, IntPtr native_dataClass)
		{
			EncoderRegistry @object = Java.Lang.Object.GetObject<EncoderRegistry>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Java.Lang.Object.GetObject<Class>(native_dataClass, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetEncoder(object2));
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x0000E5C0 File Offset: 0x0000C7C0
		[Register("getEncoder", "(Ljava/lang/Class;)Lcom/bumptech/glide/load/Encoder;", "GetGetEncoder_Ljava_lang_Class_Handler")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe virtual IEncoder GetEncoder(Class dataClass)
		{
			IEncoder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((dataClass == null) ? IntPtr.Zero : dataClass.Handle);
				@object = Java.Lang.Object.GetObject<IEncoder>(EncoderRegistry._members.InstanceMethods.InvokeVirtualObjectMethod("getEncoder.(Ljava/lang/Class;)Lcom/bumptech/glide/load/Encoder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(dataClass);
			}
			return @object;
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x0000E634 File Offset: 0x0000C834
		private static Delegate GetPrepend_Ljava_lang_Class_Lcom_bumptech_glide_load_Encoder_Handler()
		{
			if (EncoderRegistry.cb_prepend_Ljava_lang_Class_Lcom_bumptech_glide_load_Encoder_ == null)
			{
				EncoderRegistry.cb_prepend_Ljava_lang_Class_Lcom_bumptech_glide_load_Encoder_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(EncoderRegistry.n_Prepend_Ljava_lang_Class_Lcom_bumptech_glide_load_Encoder_));
			}
			return EncoderRegistry.cb_prepend_Ljava_lang_Class_Lcom_bumptech_glide_load_Encoder_;
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x0000E658 File Offset: 0x0000C858
		private static void n_Prepend_Ljava_lang_Class_Lcom_bumptech_glide_load_Encoder_(IntPtr jnienv, IntPtr native__this, IntPtr native_dataClass, IntPtr native_encoder)
		{
			EncoderRegistry @object = Java.Lang.Object.GetObject<EncoderRegistry>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Java.Lang.Object.GetObject<Class>(native_dataClass, JniHandleOwnership.DoNotTransfer);
			IEncoder object3 = Java.Lang.Object.GetObject<IEncoder>(native_encoder, JniHandleOwnership.DoNotTransfer);
			@object.Prepend(object2, object3);
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x0000E684 File Offset: 0x0000C884
		[Register("prepend", "(Ljava/lang/Class;Lcom/bumptech/glide/load/Encoder;)V", "GetPrepend_Ljava_lang_Class_Lcom_bumptech_glide_load_Encoder_Handler")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe virtual void Prepend(Class dataClass, IEncoder encoder)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((dataClass == null) ? IntPtr.Zero : dataClass.Handle);
				ptr[1] = new JniArgumentValue((encoder == null) ? IntPtr.Zero : ((Java.Lang.Object)encoder).Handle);
				EncoderRegistry._members.InstanceMethods.InvokeVirtualVoidMethod("prepend.(Ljava/lang/Class;Lcom/bumptech/glide/load/Encoder;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(dataClass);
				GC.KeepAlive(encoder);
			}
		}

		// Token: 0x040000DD RID: 221
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/provider/EncoderRegistry", typeof(EncoderRegistry));

		// Token: 0x040000DE RID: 222
		private static Delegate cb_append_Ljava_lang_Class_Lcom_bumptech_glide_load_Encoder_;

		// Token: 0x040000DF RID: 223
		private static Delegate cb_getEncoder_Ljava_lang_Class_;

		// Token: 0x040000E0 RID: 224
		private static Delegate cb_prepend_Ljava_lang_Class_Lcom_bumptech_glide_load_Encoder_;
	}
}
