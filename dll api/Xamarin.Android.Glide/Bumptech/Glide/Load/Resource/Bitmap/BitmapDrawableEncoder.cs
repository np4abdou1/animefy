using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Bumptech.Glide.Load.Engine;
using Bumptech.Glide.Load.Engine.BitmapRecycle;
using Java.Interop;
using Java.IO;
using Java.Lang;

namespace Bumptech.Glide.Load.Resource.Bitmap
{
	// Token: 0x020000F9 RID: 249
	[Register("com/bumptech/glide/load/resource/bitmap/BitmapDrawableEncoder", DoNotGenerateAcw = true)]
	public class BitmapDrawableEncoder : Java.Lang.Object, IResourceEncoder, IEncoder, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000C64 RID: 3172 RVA: 0x00026A68 File Offset: 0x00024C68
		public virtual bool Encode(Java.Lang.Object data, File file, Options options)
		{
			return this.Encode((IResource)data, file, options);
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06000C65 RID: 3173 RVA: 0x00026A78 File Offset: 0x00024C78
		internal static IntPtr class_ref
		{
			get
			{
				return BitmapDrawableEncoder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06000C66 RID: 3174 RVA: 0x00026A9C File Offset: 0x00024C9C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BitmapDrawableEncoder._members;
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000C67 RID: 3175 RVA: 0x00026AA4 File Offset: 0x00024CA4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BitmapDrawableEncoder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000C68 RID: 3176 RVA: 0x00026AC8 File Offset: 0x00024CC8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BitmapDrawableEncoder._members.ManagedPeerType;
			}
		}

		// Token: 0x06000C69 RID: 3177 RVA: 0x00026AD4 File Offset: 0x00024CD4
		protected BitmapDrawableEncoder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000C6A RID: 3178 RVA: 0x00026AE0 File Offset: 0x00024CE0
		[Register(".ctor", "(Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;Lcom/bumptech/glide/load/ResourceEncoder;)V", "")]
		public unsafe BitmapDrawableEncoder(IBitmapPool bitmapPool, IResourceEncoder encoder) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((bitmapPool == null) ? IntPtr.Zero : ((Java.Lang.Object)bitmapPool).Handle);
				ptr[1] = new JniArgumentValue((encoder == null) ? IntPtr.Zero : ((Java.Lang.Object)encoder).Handle);
				base.SetHandle(BitmapDrawableEncoder._members.InstanceMethods.StartCreateInstance("(Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;Lcom/bumptech/glide/load/ResourceEncoder;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				BitmapDrawableEncoder._members.InstanceMethods.FinishCreateInstance("(Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;Lcom/bumptech/glide/load/ResourceEncoder;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(bitmapPool);
				GC.KeepAlive(encoder);
			}
		}

		// Token: 0x06000C6B RID: 3179 RVA: 0x00026BC0 File Offset: 0x00024DC0
		private static Delegate GetEncode_Lcom_bumptech_glide_load_engine_Resource_Ljava_io_File_Lcom_bumptech_glide_load_Options_Handler()
		{
			if (BitmapDrawableEncoder.cb_encode_Lcom_bumptech_glide_load_engine_Resource_Ljava_io_File_Lcom_bumptech_glide_load_Options_ == null)
			{
				BitmapDrawableEncoder.cb_encode_Lcom_bumptech_glide_load_engine_Resource_Ljava_io_File_Lcom_bumptech_glide_load_Options_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_Z(BitmapDrawableEncoder.n_Encode_Lcom_bumptech_glide_load_engine_Resource_Ljava_io_File_Lcom_bumptech_glide_load_Options_));
			}
			return BitmapDrawableEncoder.cb_encode_Lcom_bumptech_glide_load_engine_Resource_Ljava_io_File_Lcom_bumptech_glide_load_Options_;
		}

		// Token: 0x06000C6C RID: 3180 RVA: 0x00026BE4 File Offset: 0x00024DE4
		private static bool n_Encode_Lcom_bumptech_glide_load_engine_Resource_Ljava_io_File_Lcom_bumptech_glide_load_Options_(IntPtr jnienv, IntPtr native__this, IntPtr native_data, IntPtr native_file, IntPtr native_options)
		{
			BitmapDrawableEncoder @object = Java.Lang.Object.GetObject<BitmapDrawableEncoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IResource object2 = Java.Lang.Object.GetObject<IResource>(native_data, JniHandleOwnership.DoNotTransfer);
			File object3 = Java.Lang.Object.GetObject<File>(native_file, JniHandleOwnership.DoNotTransfer);
			Options object4 = Java.Lang.Object.GetObject<Options>(native_options, JniHandleOwnership.DoNotTransfer);
			return @object.Encode(object2, object3, object4);
		}

		// Token: 0x06000C6D RID: 3181 RVA: 0x00026C1C File Offset: 0x00024E1C
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
				result = BitmapDrawableEncoder._members.InstanceMethods.InvokeVirtualBooleanMethod("encode.(Lcom/bumptech/glide/load/engine/Resource;Ljava/io/File;Lcom/bumptech/glide/load/Options;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(data);
				GC.KeepAlive(file);
				GC.KeepAlive(options);
			}
			return result;
		}

		// Token: 0x06000C6E RID: 3182 RVA: 0x00026CDC File Offset: 0x00024EDC
		private static Delegate GetGetEncodeStrategy_Lcom_bumptech_glide_load_Options_Handler()
		{
			if (BitmapDrawableEncoder.cb_getEncodeStrategy_Lcom_bumptech_glide_load_Options_ == null)
			{
				BitmapDrawableEncoder.cb_getEncodeStrategy_Lcom_bumptech_glide_load_Options_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(BitmapDrawableEncoder.n_GetEncodeStrategy_Lcom_bumptech_glide_load_Options_));
			}
			return BitmapDrawableEncoder.cb_getEncodeStrategy_Lcom_bumptech_glide_load_Options_;
		}

		// Token: 0x06000C6F RID: 3183 RVA: 0x00026D00 File Offset: 0x00024F00
		private static IntPtr n_GetEncodeStrategy_Lcom_bumptech_glide_load_Options_(IntPtr jnienv, IntPtr native__this, IntPtr native_options)
		{
			BitmapDrawableEncoder @object = Java.Lang.Object.GetObject<BitmapDrawableEncoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Options object2 = Java.Lang.Object.GetObject<Options>(native_options, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetEncodeStrategy(object2));
		}

		// Token: 0x06000C70 RID: 3184 RVA: 0x00026D28 File Offset: 0x00024F28
		[Register("getEncodeStrategy", "(Lcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/EncodeStrategy;", "GetGetEncodeStrategy_Lcom_bumptech_glide_load_Options_Handler")]
		public unsafe virtual EncodeStrategy GetEncodeStrategy(Options options)
		{
			EncodeStrategy @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				@object = Java.Lang.Object.GetObject<EncodeStrategy>(BitmapDrawableEncoder._members.InstanceMethods.InvokeVirtualObjectMethod("getEncodeStrategy.(Lcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/EncodeStrategy;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(options);
			}
			return @object;
		}

		// Token: 0x040002FD RID: 765
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/resource/bitmap/BitmapDrawableEncoder", typeof(BitmapDrawableEncoder));

		// Token: 0x040002FE RID: 766
		private static Delegate cb_encode_Lcom_bumptech_glide_load_engine_Resource_Ljava_io_File_Lcom_bumptech_glide_load_Options_;

		// Token: 0x040002FF RID: 767
		private static Delegate cb_getEncodeStrategy_Lcom_bumptech_glide_load_Options_;
	}
}
