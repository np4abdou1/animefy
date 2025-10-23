using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Bumptech.Glide.Load.Engine;
using Java.Interop;
using Java.IO;
using Java.Lang;

namespace Bumptech.Glide.Load.Resource.File
{
	// Token: 0x020000ED RID: 237
	[Register("com/bumptech/glide/load/resource/file/FileDecoder", DoNotGenerateAcw = true)]
	public class FileDecoder : Java.Lang.Object, IResourceDecoder, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06000BC9 RID: 3017 RVA: 0x00024DA4 File Offset: 0x00022FA4
		internal static IntPtr class_ref
		{
			get
			{
				return FileDecoder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06000BCA RID: 3018 RVA: 0x00024DC8 File Offset: 0x00022FC8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return FileDecoder._members;
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06000BCB RID: 3019 RVA: 0x00024DD0 File Offset: 0x00022FD0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return FileDecoder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06000BCC RID: 3020 RVA: 0x00024DF4 File Offset: 0x00022FF4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return FileDecoder._members.ManagedPeerType;
			}
		}

		// Token: 0x06000BCD RID: 3021 RVA: 0x00024E00 File Offset: 0x00023000
		protected FileDecoder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000BCE RID: 3022 RVA: 0x00024E0C File Offset: 0x0002300C
		[Register(".ctor", "()V", "")]
		public FileDecoder() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(FileDecoder._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			FileDecoder._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000BCF RID: 3023 RVA: 0x00024E7A File Offset: 0x0002307A
		private static Delegate GetDecode_Ljava_io_File_IILcom_bumptech_glide_load_Options_Handler()
		{
			if (FileDecoder.cb_decode_Ljava_io_File_IILcom_bumptech_glide_load_Options_ == null)
			{
				FileDecoder.cb_decode_Ljava_io_File_IILcom_bumptech_glide_load_Options_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIIL_L(FileDecoder.n_Decode_Ljava_io_File_IILcom_bumptech_glide_load_Options_));
			}
			return FileDecoder.cb_decode_Ljava_io_File_IILcom_bumptech_glide_load_Options_;
		}

		// Token: 0x06000BD0 RID: 3024 RVA: 0x00024EA0 File Offset: 0x000230A0
		private static IntPtr n_Decode_Ljava_io_File_IILcom_bumptech_glide_load_Options_(IntPtr jnienv, IntPtr native__this, IntPtr native_source, int width, int height, IntPtr native_options)
		{
			FileDecoder @object = Java.Lang.Object.GetObject<FileDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			File object2 = Java.Lang.Object.GetObject<File>(native_source, JniHandleOwnership.DoNotTransfer);
			Options object3 = Java.Lang.Object.GetObject<Options>(native_options, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Decode(object2, width, height, object3));
		}

		// Token: 0x06000BD1 RID: 3025 RVA: 0x00024ED8 File Offset: 0x000230D8
		[Register("decode", "(Ljava/io/File;IILcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/engine/Resource;", "GetDecode_Ljava_io_File_IILcom_bumptech_glide_load_Options_Handler")]
		public unsafe virtual IResource Decode(File source, int width, int height, Options options)
		{
			IResource @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((source == null) ? IntPtr.Zero : source.Handle);
				ptr[1] = new JniArgumentValue(width);
				ptr[2] = new JniArgumentValue(height);
				ptr[3] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				@object = Java.Lang.Object.GetObject<IResource>(FileDecoder._members.InstanceMethods.InvokeVirtualObjectMethod("decode.(Ljava/io/File;IILcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/engine/Resource;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(source);
				GC.KeepAlive(options);
			}
			return @object;
		}

		// Token: 0x06000BD2 RID: 3026 RVA: 0x00024FA4 File Offset: 0x000231A4
		private static Delegate GetHandles_Ljava_io_File_Lcom_bumptech_glide_load_Options_Handler()
		{
			if (FileDecoder.cb_handles_Ljava_io_File_Lcom_bumptech_glide_load_Options_ == null)
			{
				FileDecoder.cb_handles_Ljava_io_File_Lcom_bumptech_glide_load_Options_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_Z(FileDecoder.n_Handles_Ljava_io_File_Lcom_bumptech_glide_load_Options_));
			}
			return FileDecoder.cb_handles_Ljava_io_File_Lcom_bumptech_glide_load_Options_;
		}

		// Token: 0x06000BD3 RID: 3027 RVA: 0x00024FC8 File Offset: 0x000231C8
		private static bool n_Handles_Ljava_io_File_Lcom_bumptech_glide_load_Options_(IntPtr jnienv, IntPtr native__this, IntPtr native_source, IntPtr native_options)
		{
			FileDecoder @object = Java.Lang.Object.GetObject<FileDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			File object2 = Java.Lang.Object.GetObject<File>(native_source, JniHandleOwnership.DoNotTransfer);
			Options object3 = Java.Lang.Object.GetObject<Options>(native_options, JniHandleOwnership.DoNotTransfer);
			return @object.Handles(object2, object3);
		}

		// Token: 0x06000BD4 RID: 3028 RVA: 0x00024FF4 File Offset: 0x000231F4
		[Register("handles", "(Ljava/io/File;Lcom/bumptech/glide/load/Options;)Z", "GetHandles_Ljava_io_File_Lcom_bumptech_glide_load_Options_Handler")]
		public unsafe virtual bool Handles(File source, Options options)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((source == null) ? IntPtr.Zero : source.Handle);
				ptr[1] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				result = FileDecoder._members.InstanceMethods.InvokeVirtualBooleanMethod("handles.(Ljava/io/File;Lcom/bumptech/glide/load/Options;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(source);
				GC.KeepAlive(options);
			}
			return result;
		}

		// Token: 0x06000BD5 RID: 3029 RVA: 0x00025084 File Offset: 0x00023284
		IResource IResourceDecoder.Decode(Java.Lang.Object p0, int p1, int p2, Options p3)
		{
			return this.Decode(p0.JavaCast<File>(), p1, p2, p3).JavaCast<IResource>();
		}

		// Token: 0x06000BD6 RID: 3030 RVA: 0x0002509B File Offset: 0x0002329B
		bool IResourceDecoder.Handles(Java.Lang.Object p0, Options p1)
		{
			return this.Handles(p0.JavaCast<File>(), p1);
		}

		// Token: 0x040002E1 RID: 737
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/resource/file/FileDecoder", typeof(FileDecoder));

		// Token: 0x040002E2 RID: 738
		private static Delegate cb_decode_Ljava_io_File_IILcom_bumptech_glide_load_Options_;

		// Token: 0x040002E3 RID: 739
		private static Delegate cb_handles_Ljava_io_File_Lcom_bumptech_glide_load_Options_;
	}
}
