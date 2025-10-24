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
	// Token: 0x02000109 RID: 265
	[Register("com/bumptech/glide/load/resource/bitmap/DefaultImageHeaderParser", DoNotGenerateAcw = true)]
	public sealed class DefaultImageHeaderParser : Java.Lang.Object, IImageHeaderParser, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06000D4A RID: 3402 RVA: 0x00029DC0 File Offset: 0x00027FC0
		internal static IntPtr class_ref
		{
			get
			{
				return DefaultImageHeaderParser._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06000D4B RID: 3403 RVA: 0x00029DE4 File Offset: 0x00027FE4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DefaultImageHeaderParser._members;
			}
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06000D4C RID: 3404 RVA: 0x00029DEC File Offset: 0x00027FEC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DefaultImageHeaderParser._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06000D4D RID: 3405 RVA: 0x00029E10 File Offset: 0x00028010
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DefaultImageHeaderParser._members.ManagedPeerType;
			}
		}

		// Token: 0x06000D4E RID: 3406 RVA: 0x00029E1C File Offset: 0x0002801C
		internal DefaultImageHeaderParser(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000D4F RID: 3407 RVA: 0x00029E28 File Offset: 0x00028028
		[Register(".ctor", "()V", "")]
		public DefaultImageHeaderParser() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(DefaultImageHeaderParser._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			DefaultImageHeaderParser._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000D50 RID: 3408 RVA: 0x00029E98 File Offset: 0x00028098
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
				result = DefaultImageHeaderParser._members.InstanceMethods.InvokeAbstractInt32Method("getOrientation.(Ljava/io/InputStream;Lcom/bumptech/glide/load/engine/bitmap_recycle/ArrayPool;)I", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(@is);
				GC.KeepAlive(byteArrayPool);
			}
			return result;
		}

		// Token: 0x06000D51 RID: 3409 RVA: 0x00029F28 File Offset: 0x00028128
		[Register("getOrientation", "(Ljava/nio/ByteBuffer;Lcom/bumptech/glide/load/engine/bitmap_recycle/ArrayPool;)I", "")]
		public unsafe int GetOrientation(ByteBuffer byteBuffer, IArrayPool byteArrayPool)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((byteBuffer == null) ? IntPtr.Zero : byteBuffer.Handle);
				ptr[1] = new JniArgumentValue((byteArrayPool == null) ? IntPtr.Zero : ((Java.Lang.Object)byteArrayPool).Handle);
				result = DefaultImageHeaderParser._members.InstanceMethods.InvokeAbstractInt32Method("getOrientation.(Ljava/nio/ByteBuffer;Lcom/bumptech/glide/load/engine/bitmap_recycle/ArrayPool;)I", this, ptr);
			}
			finally
			{
				GC.KeepAlive(byteBuffer);
				GC.KeepAlive(byteArrayPool);
			}
			return result;
		}

		// Token: 0x06000D52 RID: 3410 RVA: 0x00029FBC File Offset: 0x000281BC
		[Register("getType", "(Ljava/io/InputStream;)Lcom/bumptech/glide/load/ImageHeaderParser$ImageType;", "")]
		public unsafe ImageHeaderParserImageType GetType(Stream @is)
		{
			IntPtr intPtr = InputStreamAdapter.ToLocalJniHandle(@is);
			ImageHeaderParserImageType @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<ImageHeaderParserImageType>(DefaultImageHeaderParser._members.InstanceMethods.InvokeAbstractObjectMethod("getType.(Ljava/io/InputStream;)Lcom/bumptech/glide/load/ImageHeaderParser$ImageType;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(@is);
			}
			return @object;
		}

		// Token: 0x06000D53 RID: 3411 RVA: 0x0002A030 File Offset: 0x00028230
		[Register("getType", "(Ljava/nio/ByteBuffer;)Lcom/bumptech/glide/load/ImageHeaderParser$ImageType;", "")]
		public unsafe ImageHeaderParserImageType GetType(ByteBuffer byteBuffer)
		{
			ImageHeaderParserImageType @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((byteBuffer == null) ? IntPtr.Zero : byteBuffer.Handle);
				@object = Java.Lang.Object.GetObject<ImageHeaderParserImageType>(DefaultImageHeaderParser._members.InstanceMethods.InvokeAbstractObjectMethod("getType.(Ljava/nio/ByteBuffer;)Lcom/bumptech/glide/load/ImageHeaderParser$ImageType;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(byteBuffer);
			}
			return @object;
		}

		// Token: 0x04000329 RID: 809
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/resource/bitmap/DefaultImageHeaderParser", typeof(DefaultImageHeaderParser));

		// Token: 0x020001C8 RID: 456
		public static class InterfaceConsts
		{
			// Token: 0x04000540 RID: 1344
			[Register("UNKNOWN_ORIENTATION")]
			public const int UnknownOrientation = -1;
		}
	}
}
