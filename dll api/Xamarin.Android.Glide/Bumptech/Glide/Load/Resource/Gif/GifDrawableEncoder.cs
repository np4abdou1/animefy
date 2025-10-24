using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Bumptech.Glide.Load.Engine;
using Java.Interop;
using Java.IO;
using Java.Lang;

namespace Bumptech.Glide.Load.Resource.Gif
{
	// Token: 0x0200011D RID: 285
	[Register("com/bumptech/glide/load/resource/gif/GifDrawableEncoder", DoNotGenerateAcw = true)]
	public class GifDrawableEncoder : Java.Lang.Object, IResourceEncoder, IEncoder, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000E4E RID: 3662 RVA: 0x0002DE1B File Offset: 0x0002C01B
		public virtual bool Encode(Java.Lang.Object data, File file, Options options)
		{
			return this.Encode((IResource)data, file, options);
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06000E4F RID: 3663 RVA: 0x0002DE2C File Offset: 0x0002C02C
		internal static IntPtr class_ref
		{
			get
			{
				return GifDrawableEncoder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06000E50 RID: 3664 RVA: 0x0002DE50 File Offset: 0x0002C050
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return GifDrawableEncoder._members;
			}
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06000E51 RID: 3665 RVA: 0x0002DE58 File Offset: 0x0002C058
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return GifDrawableEncoder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06000E52 RID: 3666 RVA: 0x0002DE7C File Offset: 0x0002C07C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return GifDrawableEncoder._members.ManagedPeerType;
			}
		}

		// Token: 0x06000E53 RID: 3667 RVA: 0x0002DE88 File Offset: 0x0002C088
		protected GifDrawableEncoder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000E54 RID: 3668 RVA: 0x0002DE94 File Offset: 0x0002C094
		[Register(".ctor", "()V", "")]
		public GifDrawableEncoder() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(GifDrawableEncoder._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			GifDrawableEncoder._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000E55 RID: 3669 RVA: 0x0002DF02 File Offset: 0x0002C102
		private static Delegate GetEncode_Lcom_bumptech_glide_load_engine_Resource_Ljava_io_File_Lcom_bumptech_glide_load_Options_Handler()
		{
			if (GifDrawableEncoder.cb_encode_Lcom_bumptech_glide_load_engine_Resource_Ljava_io_File_Lcom_bumptech_glide_load_Options_ == null)
			{
				GifDrawableEncoder.cb_encode_Lcom_bumptech_glide_load_engine_Resource_Ljava_io_File_Lcom_bumptech_glide_load_Options_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_Z(GifDrawableEncoder.n_Encode_Lcom_bumptech_glide_load_engine_Resource_Ljava_io_File_Lcom_bumptech_glide_load_Options_));
			}
			return GifDrawableEncoder.cb_encode_Lcom_bumptech_glide_load_engine_Resource_Ljava_io_File_Lcom_bumptech_glide_load_Options_;
		}

		// Token: 0x06000E56 RID: 3670 RVA: 0x0002DF28 File Offset: 0x0002C128
		private static bool n_Encode_Lcom_bumptech_glide_load_engine_Resource_Ljava_io_File_Lcom_bumptech_glide_load_Options_(IntPtr jnienv, IntPtr native__this, IntPtr native_data, IntPtr native_file, IntPtr native_options)
		{
			GifDrawableEncoder @object = Java.Lang.Object.GetObject<GifDrawableEncoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IResource object2 = Java.Lang.Object.GetObject<IResource>(native_data, JniHandleOwnership.DoNotTransfer);
			File object3 = Java.Lang.Object.GetObject<File>(native_file, JniHandleOwnership.DoNotTransfer);
			Options object4 = Java.Lang.Object.GetObject<Options>(native_options, JniHandleOwnership.DoNotTransfer);
			return @object.Encode(object2, object3, object4);
		}

		// Token: 0x06000E57 RID: 3671 RVA: 0x0002DF60 File Offset: 0x0002C160
		[Register("encode", "(Lcom/bumptech/glide/load/engine/Resource;Ljava/io/File;Lcom/bumptech/glide/load/Options;)Z", "GetEncode_Lcom_bumptech_glide_load_engine_Resource_Ljava_io_File_Lcom_bumptech_glide_load_Options_Handler")]
		public unsafe virtual bool Encode(IResource data, File file, Options options)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((data == null) ? IntPtr.Zero : ((Java.Lang.Object)data).Handle);
				ptr[1] = new JniArgumentValue((file == null) ? IntPtr.Zero : file.Handle);
				ptr[2] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				result = GifDrawableEncoder._members.InstanceMethods.InvokeVirtualBooleanMethod("encode.(Lcom/bumptech/glide/load/engine/Resource;Ljava/io/File;Lcom/bumptech/glide/load/Options;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(data);
				GC.KeepAlive(file);
				GC.KeepAlive(options);
			}
			return result;
		}

		// Token: 0x06000E58 RID: 3672 RVA: 0x0002E020 File Offset: 0x0002C220
		private static Delegate GetGetEncodeStrategy_Lcom_bumptech_glide_load_Options_Handler()
		{
			if (GifDrawableEncoder.cb_getEncodeStrategy_Lcom_bumptech_glide_load_Options_ == null)
			{
				GifDrawableEncoder.cb_getEncodeStrategy_Lcom_bumptech_glide_load_Options_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(GifDrawableEncoder.n_GetEncodeStrategy_Lcom_bumptech_glide_load_Options_));
			}
			return GifDrawableEncoder.cb_getEncodeStrategy_Lcom_bumptech_glide_load_Options_;
		}

		// Token: 0x06000E59 RID: 3673 RVA: 0x0002E044 File Offset: 0x0002C244
		private static IntPtr n_GetEncodeStrategy_Lcom_bumptech_glide_load_Options_(IntPtr jnienv, IntPtr native__this, IntPtr native_options)
		{
			GifDrawableEncoder @object = Java.Lang.Object.GetObject<GifDrawableEncoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Options object2 = Java.Lang.Object.GetObject<Options>(native_options, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetEncodeStrategy(object2));
		}

		// Token: 0x06000E5A RID: 3674 RVA: 0x0002E06C File Offset: 0x0002C26C
		[Register("getEncodeStrategy", "(Lcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/EncodeStrategy;", "GetGetEncodeStrategy_Lcom_bumptech_glide_load_Options_Handler")]
		public unsafe virtual EncodeStrategy GetEncodeStrategy(Options options)
		{
			EncodeStrategy @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				@object = Java.Lang.Object.GetObject<EncodeStrategy>(GifDrawableEncoder._members.InstanceMethods.InvokeVirtualObjectMethod("getEncodeStrategy.(Lcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/EncodeStrategy;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(options);
			}
			return @object;
		}

		// Token: 0x0400034F RID: 847
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/resource/gif/GifDrawableEncoder", typeof(GifDrawableEncoder));

		// Token: 0x04000350 RID: 848
		private static Delegate cb_encode_Lcom_bumptech_glide_load_engine_Resource_Ljava_io_File_Lcom_bumptech_glide_load_Options_;

		// Token: 0x04000351 RID: 849
		private static Delegate cb_getEncodeStrategy_Lcom_bumptech_glide_load_Options_;
	}
}
