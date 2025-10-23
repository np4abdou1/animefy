using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using Android.Runtime;
using Bumptech.Glide.Load.Engine.BitmapRecycle;
using Java.Interop;
using Java.Lang;
using Java.Nio;

namespace Bumptech.Glide.Load.Resource.Bitmap
{
	// Token: 0x0200010E RID: 270
	[Register("com/bumptech/glide/load/resource/bitmap/ExifInterfaceImageHeaderParser", DoNotGenerateAcw = true)]
	public sealed class ExifInterfaceImageHeaderParser : Java.Lang.Object, IImageHeaderParser, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06000D94 RID: 3476 RVA: 0x0002AFD0 File Offset: 0x000291D0
		internal static IntPtr class_ref
		{
			get
			{
				return ExifInterfaceImageHeaderParser._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06000D95 RID: 3477 RVA: 0x0002AFF4 File Offset: 0x000291F4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ExifInterfaceImageHeaderParser._members;
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06000D96 RID: 3478 RVA: 0x0002AFFC File Offset: 0x000291FC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ExifInterfaceImageHeaderParser._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06000D97 RID: 3479 RVA: 0x0002B020 File Offset: 0x00029220
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ExifInterfaceImageHeaderParser._members.ManagedPeerType;
			}
		}

		// Token: 0x06000D98 RID: 3480 RVA: 0x0002B02C File Offset: 0x0002922C
		internal ExifInterfaceImageHeaderParser(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000D99 RID: 3481 RVA: 0x0002B038 File Offset: 0x00029238
		[Register(".ctor", "()V", "")]
		public ExifInterfaceImageHeaderParser() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(ExifInterfaceImageHeaderParser._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			ExifInterfaceImageHeaderParser._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000D9A RID: 3482 RVA: 0x0002B0A8 File Offset: 0x000292A8
		[Register("getOrientation", "(Ljava/io/InputStream;Lcom/bumptech/glide/load/engine/bitmap_recycle/ArrayPool;)I", "")]
		public unsafe int GetOrientation(Stream @is, IArrayPool byteArrayPool)
		{
			IntPtr intPtr = InputStreamAdapter.ToLocalJniHandle(@is);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((byteArrayPool == null) ? IntPtr.Zero : ((Java.Lang.Object)byteArrayPool).Handle);
				result = ExifInterfaceImageHeaderParser._members.InstanceMethods.InvokeAbstractInt32Method("getOrientation.(Ljava/io/InputStream;Lcom/bumptech/glide/load/engine/bitmap_recycle/ArrayPool;)I", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(@is);
				GC.KeepAlive(byteArrayPool);
			}
			return result;
		}

		// Token: 0x06000D9B RID: 3483 RVA: 0x0002B138 File Offset: 0x00029338
		[Register("getOrientation", "(Ljava/nio/ByteBuffer;Lcom/bumptech/glide/load/engine/bitmap_recycle/ArrayPool;)I", "")]
		public unsafe int GetOrientation(ByteBuffer byteBuffer, IArrayPool byteArrayPool)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((byteBuffer == null) ? IntPtr.Zero : byteBuffer.Handle);
				ptr[1] = new JniArgumentValue((byteArrayPool == null) ? IntPtr.Zero : ((Java.Lang.Object)byteArrayPool).Handle);
				result = ExifInterfaceImageHeaderParser._members.InstanceMethods.InvokeAbstractInt32Method("getOrientation.(Ljava/nio/ByteBuffer;Lcom/bumptech/glide/load/engine/bitmap_recycle/ArrayPool;)I", this, ptr);
			}
			finally
			{
				GC.KeepAlive(byteBuffer);
				GC.KeepAlive(byteArrayPool);
			}
			return result;
		}

		// Token: 0x06000D9C RID: 3484 RVA: 0x0002B1CC File Offset: 0x000293CC
		[Register("getType", "(Ljava/io/InputStream;)Lcom/bumptech/glide/load/ImageHeaderParser$ImageType;", "")]
		public unsafe ImageHeaderParserImageType GetType(Stream @is)
		{
			IntPtr intPtr = InputStreamAdapter.ToLocalJniHandle(@is);
			ImageHeaderParserImageType @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<ImageHeaderParserImageType>(ExifInterfaceImageHeaderParser._members.InstanceMethods.InvokeAbstractObjectMethod("getType.(Ljava/io/InputStream;)Lcom/bumptech/glide/load/ImageHeaderParser$ImageType;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(@is);
			}
			return @object;
		}

		// Token: 0x06000D9D RID: 3485 RVA: 0x0002B240 File Offset: 0x00029440
		[Register("getType", "(Ljava/nio/ByteBuffer;)Lcom/bumptech/glide/load/ImageHeaderParser$ImageType;", "")]
		public unsafe ImageHeaderParserImageType GetType(ByteBuffer byteBuffer)
		{
			ImageHeaderParserImageType @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((byteBuffer == null) ? IntPtr.Zero : byteBuffer.Handle);
				@object = Java.Lang.Object.GetObject<ImageHeaderParserImageType>(ExifInterfaceImageHeaderParser._members.InstanceMethods.InvokeAbstractObjectMethod("getType.(Ljava/nio/ByteBuffer;)Lcom/bumptech/glide/load/ImageHeaderParser$ImageType;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(byteBuffer);
			}
			return @object;
		}

		// Token: 0x04000333 RID: 819
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/resource/bitmap/ExifInterfaceImageHeaderParser", typeof(ExifInterfaceImageHeaderParser));

		// Token: 0x020001CC RID: 460
		public static class InterfaceConsts
		{
			// Token: 0x04000548 RID: 1352
			[Register("UNKNOWN_ORIENTATION")]
			public const int UnknownOrientation = -1;
		}
	}
}
