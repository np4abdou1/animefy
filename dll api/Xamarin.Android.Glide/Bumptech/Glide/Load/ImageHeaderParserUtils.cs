using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using Android.Runtime;
using Bumptech.Glide.Load.Data;
using Bumptech.Glide.Load.Engine.BitmapRecycle;
using Java.Interop;
using Java.Lang;
using Java.Nio;

namespace Bumptech.Glide.Load
{
	// Token: 0x020000D6 RID: 214
	[Register("com/bumptech/glide/load/ImageHeaderParserUtils", DoNotGenerateAcw = true)]
	public sealed class ImageHeaderParserUtils : Java.Lang.Object
	{
		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06000ADC RID: 2780 RVA: 0x00021908 File Offset: 0x0001FB08
		internal static IntPtr class_ref
		{
			get
			{
				return ImageHeaderParserUtils._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06000ADD RID: 2781 RVA: 0x0002192C File Offset: 0x0001FB2C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ImageHeaderParserUtils._members;
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06000ADE RID: 2782 RVA: 0x00021934 File Offset: 0x0001FB34
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ImageHeaderParserUtils._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06000ADF RID: 2783 RVA: 0x00021958 File Offset: 0x0001FB58
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ImageHeaderParserUtils._members.ManagedPeerType;
			}
		}

		// Token: 0x06000AE0 RID: 2784 RVA: 0x00021964 File Offset: 0x0001FB64
		internal ImageHeaderParserUtils(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000AE1 RID: 2785 RVA: 0x00021970 File Offset: 0x0001FB70
		[Register("getOrientation", "(Ljava/util/List;Lcom/bumptech/glide/load/data/ParcelFileDescriptorRewinder;Lcom/bumptech/glide/load/engine/bitmap_recycle/ArrayPool;)I", "")]
		public unsafe static int GetOrientation(IList<IImageHeaderParser> parsers, ParcelFileDescriptorRewinder parcelFileDescriptorRewinder, IArrayPool byteArrayPool)
		{
			IntPtr intPtr = JavaList<IImageHeaderParser>.ToLocalJniHandle(parsers);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((parcelFileDescriptorRewinder == null) ? IntPtr.Zero : parcelFileDescriptorRewinder.Handle);
				ptr[2] = new JniArgumentValue((byteArrayPool == null) ? IntPtr.Zero : ((Java.Lang.Object)byteArrayPool).Handle);
				result = ImageHeaderParserUtils._members.StaticMethods.InvokeInt32Method("getOrientation.(Ljava/util/List;Lcom/bumptech/glide/load/data/ParcelFileDescriptorRewinder;Lcom/bumptech/glide/load/engine/bitmap_recycle/ArrayPool;)I", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(parsers);
				GC.KeepAlive(parcelFileDescriptorRewinder);
				GC.KeepAlive(byteArrayPool);
			}
			return result;
		}

		// Token: 0x06000AE2 RID: 2786 RVA: 0x00021A2C File Offset: 0x0001FC2C
		[Register("getOrientation", "(Ljava/util/List;Ljava/io/InputStream;Lcom/bumptech/glide/load/engine/bitmap_recycle/ArrayPool;)I", "")]
		public unsafe static int GetOrientation(IList<IImageHeaderParser> parsers, Stream @is, IArrayPool byteArrayPool)
		{
			IntPtr intPtr = JavaList<IImageHeaderParser>.ToLocalJniHandle(parsers);
			IntPtr intPtr2 = InputStreamAdapter.ToLocalJniHandle(@is);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((byteArrayPool == null) ? IntPtr.Zero : ((Java.Lang.Object)byteArrayPool).Handle);
				result = ImageHeaderParserUtils._members.StaticMethods.InvokeInt32Method("getOrientation.(Ljava/util/List;Ljava/io/InputStream;Lcom/bumptech/glide/load/engine/bitmap_recycle/ArrayPool;)I", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(parsers);
				GC.KeepAlive(@is);
				GC.KeepAlive(byteArrayPool);
			}
			return result;
		}

		// Token: 0x06000AE3 RID: 2787 RVA: 0x00021AE4 File Offset: 0x0001FCE4
		[Register("getOrientation", "(Ljava/util/List;Ljava/nio/ByteBuffer;Lcom/bumptech/glide/load/engine/bitmap_recycle/ArrayPool;)I", "")]
		public unsafe static int GetOrientation(IList<IImageHeaderParser> parsers, ByteBuffer buffer, IArrayPool arrayPool)
		{
			IntPtr intPtr = JavaList<IImageHeaderParser>.ToLocalJniHandle(parsers);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((buffer == null) ? IntPtr.Zero : buffer.Handle);
				ptr[2] = new JniArgumentValue((arrayPool == null) ? IntPtr.Zero : ((Java.Lang.Object)arrayPool).Handle);
				result = ImageHeaderParserUtils._members.StaticMethods.InvokeInt32Method("getOrientation.(Ljava/util/List;Ljava/nio/ByteBuffer;Lcom/bumptech/glide/load/engine/bitmap_recycle/ArrayPool;)I", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(parsers);
				GC.KeepAlive(buffer);
				GC.KeepAlive(arrayPool);
			}
			return result;
		}

		// Token: 0x06000AE4 RID: 2788 RVA: 0x00021BA0 File Offset: 0x0001FDA0
		[Register("getType", "(Ljava/util/List;Lcom/bumptech/glide/load/data/ParcelFileDescriptorRewinder;Lcom/bumptech/glide/load/engine/bitmap_recycle/ArrayPool;)Lcom/bumptech/glide/load/ImageHeaderParser$ImageType;", "")]
		public unsafe static ImageHeaderParserImageType GetType(IList<IImageHeaderParser> parsers, ParcelFileDescriptorRewinder parcelFileDescriptorRewinder, IArrayPool byteArrayPool)
		{
			IntPtr intPtr = JavaList<IImageHeaderParser>.ToLocalJniHandle(parsers);
			ImageHeaderParserImageType @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((parcelFileDescriptorRewinder == null) ? IntPtr.Zero : parcelFileDescriptorRewinder.Handle);
				ptr[2] = new JniArgumentValue((byteArrayPool == null) ? IntPtr.Zero : ((Java.Lang.Object)byteArrayPool).Handle);
				@object = Java.Lang.Object.GetObject<ImageHeaderParserImageType>(ImageHeaderParserUtils._members.StaticMethods.InvokeObjectMethod("getType.(Ljava/util/List;Lcom/bumptech/glide/load/data/ParcelFileDescriptorRewinder;Lcom/bumptech/glide/load/engine/bitmap_recycle/ArrayPool;)Lcom/bumptech/glide/load/ImageHeaderParser$ImageType;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(parsers);
				GC.KeepAlive(parcelFileDescriptorRewinder);
				GC.KeepAlive(byteArrayPool);
			}
			return @object;
		}

		// Token: 0x06000AE5 RID: 2789 RVA: 0x00021C68 File Offset: 0x0001FE68
		[Register("getType", "(Ljava/util/List;Ljava/io/InputStream;Lcom/bumptech/glide/load/engine/bitmap_recycle/ArrayPool;)Lcom/bumptech/glide/load/ImageHeaderParser$ImageType;", "")]
		public unsafe static ImageHeaderParserImageType GetType(IList<IImageHeaderParser> parsers, Stream @is, IArrayPool byteArrayPool)
		{
			IntPtr intPtr = JavaList<IImageHeaderParser>.ToLocalJniHandle(parsers);
			IntPtr intPtr2 = InputStreamAdapter.ToLocalJniHandle(@is);
			ImageHeaderParserImageType @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((byteArrayPool == null) ? IntPtr.Zero : ((Java.Lang.Object)byteArrayPool).Handle);
				@object = Java.Lang.Object.GetObject<ImageHeaderParserImageType>(ImageHeaderParserUtils._members.StaticMethods.InvokeObjectMethod("getType.(Ljava/util/List;Ljava/io/InputStream;Lcom/bumptech/glide/load/engine/bitmap_recycle/ArrayPool;)Lcom/bumptech/glide/load/ImageHeaderParser$ImageType;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(parsers);
				GC.KeepAlive(@is);
				GC.KeepAlive(byteArrayPool);
			}
			return @object;
		}

		// Token: 0x06000AE6 RID: 2790 RVA: 0x00021D30 File Offset: 0x0001FF30
		[Register("getType", "(Ljava/util/List;Ljava/nio/ByteBuffer;)Lcom/bumptech/glide/load/ImageHeaderParser$ImageType;", "")]
		public unsafe static ImageHeaderParserImageType GetType(IList<IImageHeaderParser> parsers, ByteBuffer buffer)
		{
			IntPtr intPtr = JavaList<IImageHeaderParser>.ToLocalJniHandle(parsers);
			ImageHeaderParserImageType @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((buffer == null) ? IntPtr.Zero : buffer.Handle);
				@object = Java.Lang.Object.GetObject<ImageHeaderParserImageType>(ImageHeaderParserUtils._members.StaticMethods.InvokeObjectMethod("getType.(Ljava/util/List;Ljava/nio/ByteBuffer;)Lcom/bumptech/glide/load/ImageHeaderParser$ImageType;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(parsers);
				GC.KeepAlive(buffer);
			}
			return @object;
		}

		// Token: 0x040002AE RID: 686
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/ImageHeaderParserUtils", typeof(ImageHeaderParserUtils));
	}
}
