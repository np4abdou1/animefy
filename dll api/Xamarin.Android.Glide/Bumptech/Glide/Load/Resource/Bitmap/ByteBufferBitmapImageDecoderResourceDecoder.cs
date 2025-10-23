using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Bumptech.Glide.Load.Engine;
using Java.Interop;
using Java.Lang;
using Java.Nio;

namespace Bumptech.Glide.Load.Resource.Bitmap
{
	// Token: 0x02000105 RID: 261
	[Register("com/bumptech/glide/load/resource/bitmap/ByteBufferBitmapImageDecoderResourceDecoder", DoNotGenerateAcw = true)]
	public sealed class ByteBufferBitmapImageDecoderResourceDecoder : Java.Lang.Object, IResourceDecoder, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06000D18 RID: 3352 RVA: 0x000292E4 File Offset: 0x000274E4
		internal static IntPtr class_ref
		{
			get
			{
				return ByteBufferBitmapImageDecoderResourceDecoder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06000D19 RID: 3353 RVA: 0x00029308 File Offset: 0x00027508
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ByteBufferBitmapImageDecoderResourceDecoder._members;
			}
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06000D1A RID: 3354 RVA: 0x00029310 File Offset: 0x00027510
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ByteBufferBitmapImageDecoderResourceDecoder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06000D1B RID: 3355 RVA: 0x00029334 File Offset: 0x00027534
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ByteBufferBitmapImageDecoderResourceDecoder._members.ManagedPeerType;
			}
		}

		// Token: 0x06000D1C RID: 3356 RVA: 0x00029340 File Offset: 0x00027540
		internal ByteBufferBitmapImageDecoderResourceDecoder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000D1D RID: 3357 RVA: 0x0002934C File Offset: 0x0002754C
		[Register(".ctor", "()V", "")]
		public ByteBufferBitmapImageDecoderResourceDecoder() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(ByteBufferBitmapImageDecoderResourceDecoder._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			ByteBufferBitmapImageDecoderResourceDecoder._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000D1E RID: 3358 RVA: 0x000293BC File Offset: 0x000275BC
		[Register("decode", "(Ljava/nio/ByteBuffer;IILcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/engine/Resource;", "")]
		public unsafe IResource Decode(ByteBuffer buffer, int width, int height, Options options)
		{
			IResource @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((buffer == null) ? IntPtr.Zero : buffer.Handle);
				ptr[1] = new JniArgumentValue(width);
				ptr[2] = new JniArgumentValue(height);
				ptr[3] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				@object = Java.Lang.Object.GetObject<IResource>(ByteBufferBitmapImageDecoderResourceDecoder._members.InstanceMethods.InvokeAbstractObjectMethod("decode.(Ljava/nio/ByteBuffer;IILcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/engine/Resource;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(buffer);
				GC.KeepAlive(options);
			}
			return @object;
		}

		// Token: 0x06000D1F RID: 3359 RVA: 0x00029488 File Offset: 0x00027688
		[Register("handles", "(Ljava/nio/ByteBuffer;Lcom/bumptech/glide/load/Options;)Z", "")]
		public unsafe bool Handles(ByteBuffer source, Options options)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((source == null) ? IntPtr.Zero : source.Handle);
				ptr[1] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				result = ByteBufferBitmapImageDecoderResourceDecoder._members.InstanceMethods.InvokeAbstractBooleanMethod("handles.(Ljava/nio/ByteBuffer;Lcom/bumptech/glide/load/Options;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(source);
				GC.KeepAlive(options);
			}
			return result;
		}

		// Token: 0x06000D20 RID: 3360 RVA: 0x00029518 File Offset: 0x00027718
		IResource IResourceDecoder.Decode(Java.Lang.Object p0, int p1, int p2, Options p3)
		{
			return this.Decode(p0.JavaCast<ByteBuffer>(), p1, p2, p3).JavaCast<IResource>();
		}

		// Token: 0x06000D21 RID: 3361 RVA: 0x0002952F File Offset: 0x0002772F
		bool IResourceDecoder.Handles(Java.Lang.Object p0, Options p1)
		{
			return this.Handles(p0.JavaCast<ByteBuffer>(), p1);
		}

		// Token: 0x0400031F RID: 799
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/resource/bitmap/ByteBufferBitmapImageDecoderResourceDecoder", typeof(ByteBufferBitmapImageDecoderResourceDecoder));
	}
}
