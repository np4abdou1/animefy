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
	// Token: 0x020000FA RID: 250
	[Register("com/bumptech/glide/load/resource/bitmap/BitmapEncoder", DoNotGenerateAcw = true)]
	public class BitmapEncoder : Java.Lang.Object, IResourceEncoder, IEncoder, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000C72 RID: 3186 RVA: 0x00026DB7 File Offset: 0x00024FB7
		public virtual bool Encode(Java.Lang.Object data, File file, Options options)
		{
			return this.Encode((IResource)data, file, options);
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000C73 RID: 3187 RVA: 0x00026DC8 File Offset: 0x00024FC8
		[Register("COMPRESSION_FORMAT")]
		public static Option CompressionFormat
		{
			get
			{
				return Java.Lang.Object.GetObject<Option>(BitmapEncoder._members.StaticFields.GetObjectValue("COMPRESSION_FORMAT.Lcom/bumptech/glide/load/Option;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000C74 RID: 3188 RVA: 0x00026DF8 File Offset: 0x00024FF8
		[Register("COMPRESSION_QUALITY")]
		public static Option CompressionQuality
		{
			get
			{
				return Java.Lang.Object.GetObject<Option>(BitmapEncoder._members.StaticFields.GetObjectValue("COMPRESSION_QUALITY.Lcom/bumptech/glide/load/Option;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000C75 RID: 3189 RVA: 0x00026E28 File Offset: 0x00025028
		internal static IntPtr class_ref
		{
			get
			{
				return BitmapEncoder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000C76 RID: 3190 RVA: 0x00026E4C File Offset: 0x0002504C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BitmapEncoder._members;
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06000C77 RID: 3191 RVA: 0x00026E54 File Offset: 0x00025054
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BitmapEncoder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000C78 RID: 3192 RVA: 0x00026E78 File Offset: 0x00025078
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BitmapEncoder._members.ManagedPeerType;
			}
		}

		// Token: 0x06000C79 RID: 3193 RVA: 0x00026E84 File Offset: 0x00025084
		protected BitmapEncoder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000C7A RID: 3194 RVA: 0x00026E90 File Offset: 0x00025090
		[Register(".ctor", "()V", "")]
		[Obsolete("deprecated")]
		public BitmapEncoder() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(BitmapEncoder._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			BitmapEncoder._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000C7B RID: 3195 RVA: 0x00026F00 File Offset: 0x00025100
		[Register(".ctor", "(Lcom/bumptech/glide/load/engine/bitmap_recycle/ArrayPool;)V", "")]
		public unsafe BitmapEncoder(IArrayPool arrayPool) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((arrayPool == null) ? IntPtr.Zero : ((Java.Lang.Object)arrayPool).Handle);
				base.SetHandle(BitmapEncoder._members.InstanceMethods.StartCreateInstance("(Lcom/bumptech/glide/load/engine/bitmap_recycle/ArrayPool;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				BitmapEncoder._members.InstanceMethods.FinishCreateInstance("(Lcom/bumptech/glide/load/engine/bitmap_recycle/ArrayPool;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(arrayPool);
			}
		}

		// Token: 0x06000C7C RID: 3196 RVA: 0x00026FB4 File Offset: 0x000251B4
		private static Delegate GetEncode_Lcom_bumptech_glide_load_engine_Resource_Ljava_io_File_Lcom_bumptech_glide_load_Options_Handler()
		{
			if (BitmapEncoder.cb_encode_Lcom_bumptech_glide_load_engine_Resource_Ljava_io_File_Lcom_bumptech_glide_load_Options_ == null)
			{
				BitmapEncoder.cb_encode_Lcom_bumptech_glide_load_engine_Resource_Ljava_io_File_Lcom_bumptech_glide_load_Options_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_Z(BitmapEncoder.n_Encode_Lcom_bumptech_glide_load_engine_Resource_Ljava_io_File_Lcom_bumptech_glide_load_Options_));
			}
			return BitmapEncoder.cb_encode_Lcom_bumptech_glide_load_engine_Resource_Ljava_io_File_Lcom_bumptech_glide_load_Options_;
		}

		// Token: 0x06000C7D RID: 3197 RVA: 0x00026FD8 File Offset: 0x000251D8
		private static bool n_Encode_Lcom_bumptech_glide_load_engine_Resource_Ljava_io_File_Lcom_bumptech_glide_load_Options_(IntPtr jnienv, IntPtr native__this, IntPtr native_resource, IntPtr native_file, IntPtr native_options)
		{
			BitmapEncoder @object = Java.Lang.Object.GetObject<BitmapEncoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IResource object2 = Java.Lang.Object.GetObject<IResource>(native_resource, JniHandleOwnership.DoNotTransfer);
			File object3 = Java.Lang.Object.GetObject<File>(native_file, JniHandleOwnership.DoNotTransfer);
			Options object4 = Java.Lang.Object.GetObject<Options>(native_options, JniHandleOwnership.DoNotTransfer);
			return @object.Encode(object2, object3, object4);
		}

		// Token: 0x06000C7E RID: 3198 RVA: 0x00027010 File Offset: 0x00025210
		[Register("encode", "(Lcom/bumptech/glide/load/engine/Resource;Ljava/io/File;Lcom/bumptech/glide/load/Options;)Z", "GetEncode_Lcom_bumptech_glide_load_engine_Resource_Ljava_io_File_Lcom_bumptech_glide_load_Options_Handler")]
		public unsafe virtual bool Encode(IResource resource, File file, Options options)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((resource == null) ? IntPtr.Zero : ((Java.Lang.Object)resource).Handle);
				ptr[1] = new JniArgumentValue((file == null) ? IntPtr.Zero : file.Handle);
				ptr[2] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				result = BitmapEncoder._members.InstanceMethods.InvokeVirtualBooleanMethod("encode.(Lcom/bumptech/glide/load/engine/Resource;Ljava/io/File;Lcom/bumptech/glide/load/Options;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(resource);
				GC.KeepAlive(file);
				GC.KeepAlive(options);
			}
			return result;
		}

		// Token: 0x06000C7F RID: 3199 RVA: 0x000270D0 File Offset: 0x000252D0
		private static Delegate GetGetEncodeStrategy_Lcom_bumptech_glide_load_Options_Handler()
		{
			if (BitmapEncoder.cb_getEncodeStrategy_Lcom_bumptech_glide_load_Options_ == null)
			{
				BitmapEncoder.cb_getEncodeStrategy_Lcom_bumptech_glide_load_Options_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(BitmapEncoder.n_GetEncodeStrategy_Lcom_bumptech_glide_load_Options_));
			}
			return BitmapEncoder.cb_getEncodeStrategy_Lcom_bumptech_glide_load_Options_;
		}

		// Token: 0x06000C80 RID: 3200 RVA: 0x000270F4 File Offset: 0x000252F4
		private static IntPtr n_GetEncodeStrategy_Lcom_bumptech_glide_load_Options_(IntPtr jnienv, IntPtr native__this, IntPtr native_options)
		{
			BitmapEncoder @object = Java.Lang.Object.GetObject<BitmapEncoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Options object2 = Java.Lang.Object.GetObject<Options>(native_options, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetEncodeStrategy(object2));
		}

		// Token: 0x06000C81 RID: 3201 RVA: 0x0002711C File Offset: 0x0002531C
		[Register("getEncodeStrategy", "(Lcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/EncodeStrategy;", "GetGetEncodeStrategy_Lcom_bumptech_glide_load_Options_Handler")]
		public unsafe virtual EncodeStrategy GetEncodeStrategy(Options options)
		{
			EncodeStrategy @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				@object = Java.Lang.Object.GetObject<EncodeStrategy>(BitmapEncoder._members.InstanceMethods.InvokeVirtualObjectMethod("getEncodeStrategy.(Lcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/EncodeStrategy;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(options);
			}
			return @object;
		}

		// Token: 0x04000300 RID: 768
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/resource/bitmap/BitmapEncoder", typeof(BitmapEncoder));

		// Token: 0x04000301 RID: 769
		private static Delegate cb_encode_Lcom_bumptech_glide_load_engine_Resource_Ljava_io_File_Lcom_bumptech_glide_load_Options_;

		// Token: 0x04000302 RID: 770
		private static Delegate cb_getEncodeStrategy_Lcom_bumptech_glide_load_Options_;
	}
}
