using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Graphics;
using Android.Runtime;
using Bumptech.Glide.Load.Engine;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Resource.Bitmap
{
	// Token: 0x020000FF RID: 255
	[Register("com/bumptech/glide/load/resource/bitmap/BitmapImageDecoderResourceDecoder", DoNotGenerateAcw = true)]
	public sealed class BitmapImageDecoderResourceDecoder : Java.Lang.Object, IResourceDecoder, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06000CBF RID: 3263 RVA: 0x0002802C File Offset: 0x0002622C
		internal static IntPtr class_ref
		{
			get
			{
				return BitmapImageDecoderResourceDecoder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06000CC0 RID: 3264 RVA: 0x00028050 File Offset: 0x00026250
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BitmapImageDecoderResourceDecoder._members;
			}
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06000CC1 RID: 3265 RVA: 0x00028058 File Offset: 0x00026258
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BitmapImageDecoderResourceDecoder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06000CC2 RID: 3266 RVA: 0x0002807C File Offset: 0x0002627C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BitmapImageDecoderResourceDecoder._members.ManagedPeerType;
			}
		}

		// Token: 0x06000CC3 RID: 3267 RVA: 0x00028088 File Offset: 0x00026288
		internal BitmapImageDecoderResourceDecoder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000CC4 RID: 3268 RVA: 0x00028094 File Offset: 0x00026294
		[Register(".ctor", "()V", "")]
		public BitmapImageDecoderResourceDecoder() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(BitmapImageDecoderResourceDecoder._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			BitmapImageDecoderResourceDecoder._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000CC5 RID: 3269 RVA: 0x00028104 File Offset: 0x00026304
		[Register("decode", "(Landroid/graphics/ImageDecoder$Source;IILcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/engine/Resource;", "")]
		public unsafe IResource Decode(ImageDecoder.Source source, int width, int height, Options options)
		{
			IResource @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((source == null) ? IntPtr.Zero : source.Handle);
				ptr[1] = new JniArgumentValue(width);
				ptr[2] = new JniArgumentValue(height);
				ptr[3] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				@object = Java.Lang.Object.GetObject<IResource>(BitmapImageDecoderResourceDecoder._members.InstanceMethods.InvokeAbstractObjectMethod("decode.(Landroid/graphics/ImageDecoder$Source;IILcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/engine/Resource;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(source);
				GC.KeepAlive(options);
			}
			return @object;
		}

		// Token: 0x06000CC6 RID: 3270 RVA: 0x000281D0 File Offset: 0x000263D0
		[Register("handles", "(Landroid/graphics/ImageDecoder$Source;Lcom/bumptech/glide/load/Options;)Z", "")]
		public unsafe bool Handles(ImageDecoder.Source source, Options options)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((source == null) ? IntPtr.Zero : source.Handle);
				ptr[1] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				result = BitmapImageDecoderResourceDecoder._members.InstanceMethods.InvokeAbstractBooleanMethod("handles.(Landroid/graphics/ImageDecoder$Source;Lcom/bumptech/glide/load/Options;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(source);
				GC.KeepAlive(options);
			}
			return result;
		}

		// Token: 0x06000CC7 RID: 3271 RVA: 0x00028260 File Offset: 0x00026460
		IResource IResourceDecoder.Decode(Java.Lang.Object p0, int p1, int p2, Options p3)
		{
			return this.Decode(p0.JavaCast<ImageDecoder.Source>(), p1, p2, p3).JavaCast<IResource>();
		}

		// Token: 0x06000CC8 RID: 3272 RVA: 0x00028277 File Offset: 0x00026477
		bool IResourceDecoder.Handles(Java.Lang.Object p0, Options p1)
		{
			return this.Handles(p0.JavaCast<ImageDecoder.Source>(), p1);
		}

		// Token: 0x04000310 RID: 784
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/resource/bitmap/BitmapImageDecoderResourceDecoder", typeof(BitmapImageDecoderResourceDecoder));
	}
}
