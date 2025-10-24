using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using Android.Runtime;
using Bumptech.Glide.Load.Engine.BitmapRecycle;
using Java.Interop;
using Java.IO;
using Java.Lang;

namespace Bumptech.Glide.Load.Model
{
	// Token: 0x02000145 RID: 325
	[Register("com/bumptech/glide/load/model/StreamEncoder", DoNotGenerateAcw = true)]
	public class StreamEncoder : Java.Lang.Object
	{
		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x06001061 RID: 4193 RVA: 0x00034CF0 File Offset: 0x00032EF0
		internal static IntPtr class_ref
		{
			get
			{
				return StreamEncoder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x06001062 RID: 4194 RVA: 0x00034D14 File Offset: 0x00032F14
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return StreamEncoder._members;
			}
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x06001063 RID: 4195 RVA: 0x00034D1C File Offset: 0x00032F1C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return StreamEncoder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x06001064 RID: 4196 RVA: 0x00034D40 File Offset: 0x00032F40
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return StreamEncoder._members.ManagedPeerType;
			}
		}

		// Token: 0x06001065 RID: 4197 RVA: 0x00034D4C File Offset: 0x00032F4C
		protected StreamEncoder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001066 RID: 4198 RVA: 0x00034D58 File Offset: 0x00032F58
		[Register(".ctor", "(Lcom/bumptech/glide/load/engine/bitmap_recycle/ArrayPool;)V", "")]
		public unsafe StreamEncoder(IArrayPool byteArrayPool) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((byteArrayPool == null) ? IntPtr.Zero : ((Java.Lang.Object)byteArrayPool).Handle);
				base.SetHandle(StreamEncoder._members.InstanceMethods.StartCreateInstance("(Lcom/bumptech/glide/load/engine/bitmap_recycle/ArrayPool;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				StreamEncoder._members.InstanceMethods.FinishCreateInstance("(Lcom/bumptech/glide/load/engine/bitmap_recycle/ArrayPool;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(byteArrayPool);
			}
		}

		// Token: 0x06001067 RID: 4199 RVA: 0x00034E0C File Offset: 0x0003300C
		private static Delegate GetEncode_Ljava_io_InputStream_Ljava_io_File_Lcom_bumptech_glide_load_Options_Handler()
		{
			if (StreamEncoder.cb_encode_Ljava_io_InputStream_Ljava_io_File_Lcom_bumptech_glide_load_Options_ == null)
			{
				StreamEncoder.cb_encode_Ljava_io_InputStream_Ljava_io_File_Lcom_bumptech_glide_load_Options_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_Z(StreamEncoder.n_Encode_Ljava_io_InputStream_Ljava_io_File_Lcom_bumptech_glide_load_Options_));
			}
			return StreamEncoder.cb_encode_Ljava_io_InputStream_Ljava_io_File_Lcom_bumptech_glide_load_Options_;
		}

		// Token: 0x06001068 RID: 4200 RVA: 0x00034E30 File Offset: 0x00033030
		private static bool n_Encode_Ljava_io_InputStream_Ljava_io_File_Lcom_bumptech_glide_load_Options_(IntPtr jnienv, IntPtr native__this, IntPtr native_data, IntPtr native_file, IntPtr native_options)
		{
			StreamEncoder @object = Java.Lang.Object.GetObject<StreamEncoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Stream data = InputStreamInvoker.FromJniHandle(native_data, JniHandleOwnership.DoNotTransfer);
			Java.IO.File object2 = Java.Lang.Object.GetObject<Java.IO.File>(native_file, JniHandleOwnership.DoNotTransfer);
			Options object3 = Java.Lang.Object.GetObject<Options>(native_options, JniHandleOwnership.DoNotTransfer);
			return @object.Encode(data, object2, object3);
		}

		// Token: 0x06001069 RID: 4201 RVA: 0x00034E68 File Offset: 0x00033068
		[Register("encode", "(Ljava/io/InputStream;Ljava/io/File;Lcom/bumptech/glide/load/Options;)Z", "GetEncode_Ljava_io_InputStream_Ljava_io_File_Lcom_bumptech_glide_load_Options_Handler")]
		public unsafe virtual bool Encode(Stream data, Java.IO.File file, Options options)
		{
			IntPtr intPtr = InputStreamAdapter.ToLocalJniHandle(data);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((file == null) ? IntPtr.Zero : file.Handle);
				ptr[2] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				result = StreamEncoder._members.InstanceMethods.InvokeVirtualBooleanMethod("encode.(Ljava/io/InputStream;Ljava/io/File;Lcom/bumptech/glide/load/Options;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(data);
				GC.KeepAlive(file);
				GC.KeepAlive(options);
			}
			return result;
		}

		// Token: 0x040003C8 RID: 968
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/model/StreamEncoder", typeof(StreamEncoder));

		// Token: 0x040003C9 RID: 969
		private static Delegate cb_encode_Ljava_io_InputStream_Ljava_io_File_Lcom_bumptech_glide_load_Options_;
	}
}
