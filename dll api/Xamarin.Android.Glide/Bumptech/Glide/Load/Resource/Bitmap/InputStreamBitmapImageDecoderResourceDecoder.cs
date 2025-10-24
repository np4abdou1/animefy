using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using Android.Runtime;
using Bumptech.Glide.Load.Engine;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Resource.Bitmap
{
	// Token: 0x02000112 RID: 274
	[Register("com/bumptech/glide/load/resource/bitmap/InputStreamBitmapImageDecoderResourceDecoder", DoNotGenerateAcw = true)]
	public sealed class InputStreamBitmapImageDecoderResourceDecoder : Java.Lang.Object
	{
		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06000DC2 RID: 3522 RVA: 0x0002B9C0 File Offset: 0x00029BC0
		internal static IntPtr class_ref
		{
			get
			{
				return InputStreamBitmapImageDecoderResourceDecoder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06000DC3 RID: 3523 RVA: 0x0002B9E4 File Offset: 0x00029BE4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return InputStreamBitmapImageDecoderResourceDecoder._members;
			}
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06000DC4 RID: 3524 RVA: 0x0002B9EC File Offset: 0x00029BEC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return InputStreamBitmapImageDecoderResourceDecoder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06000DC5 RID: 3525 RVA: 0x0002BA10 File Offset: 0x00029C10
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return InputStreamBitmapImageDecoderResourceDecoder._members.ManagedPeerType;
			}
		}

		// Token: 0x06000DC6 RID: 3526 RVA: 0x0002BA1C File Offset: 0x00029C1C
		internal InputStreamBitmapImageDecoderResourceDecoder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000DC7 RID: 3527 RVA: 0x0002BA28 File Offset: 0x00029C28
		[Register(".ctor", "()V", "")]
		public InputStreamBitmapImageDecoderResourceDecoder() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(InputStreamBitmapImageDecoderResourceDecoder._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			InputStreamBitmapImageDecoderResourceDecoder._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000DC8 RID: 3528 RVA: 0x0002BA98 File Offset: 0x00029C98
		[Register("decode", "(Ljava/io/InputStream;IILcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/engine/Resource;", "")]
		public unsafe IResource Decode(Stream stream, int width, int height, Options options)
		{
			IntPtr intPtr = InputStreamAdapter.ToLocalJniHandle(stream);
			IResource @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(width);
				ptr[2] = new JniArgumentValue(height);
				ptr[3] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				@object = Java.Lang.Object.GetObject<IResource>(InputStreamBitmapImageDecoderResourceDecoder._members.InstanceMethods.InvokeAbstractObjectMethod("decode.(Ljava/io/InputStream;IILcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/engine/Resource;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(stream);
				GC.KeepAlive(options);
			}
			return @object;
		}

		// Token: 0x06000DC9 RID: 3529 RVA: 0x0002BB60 File Offset: 0x00029D60
		[Register("handles", "(Ljava/io/InputStream;Lcom/bumptech/glide/load/Options;)Z", "")]
		public unsafe bool Handles(Stream source, Options options)
		{
			IntPtr intPtr = InputStreamAdapter.ToLocalJniHandle(source);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				result = InputStreamBitmapImageDecoderResourceDecoder._members.InstanceMethods.InvokeAbstractBooleanMethod("handles.(Ljava/io/InputStream;Lcom/bumptech/glide/load/Options;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(source);
				GC.KeepAlive(options);
			}
			return result;
		}

		// Token: 0x0400033A RID: 826
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/resource/bitmap/InputStreamBitmapImageDecoderResourceDecoder", typeof(InputStreamBitmapImageDecoderResourceDecoder));
	}
}
