using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Bumptech.Glide.GifDecoder;
using Bumptech.Glide.Load.Engine;
using Bumptech.Glide.Load.Engine.BitmapRecycle;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Resource.Gif
{
	// Token: 0x02000123 RID: 291
	[Register("com/bumptech/glide/load/resource/gif/GifFrameResourceDecoder", DoNotGenerateAcw = true)]
	public sealed class GifFrameResourceDecoder : Java.Lang.Object, IResourceDecoder, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06000EDF RID: 3807 RVA: 0x0002FC34 File Offset: 0x0002DE34
		internal static IntPtr class_ref
		{
			get
			{
				return GifFrameResourceDecoder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06000EE0 RID: 3808 RVA: 0x0002FC58 File Offset: 0x0002DE58
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return GifFrameResourceDecoder._members;
			}
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06000EE1 RID: 3809 RVA: 0x0002FC60 File Offset: 0x0002DE60
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return GifFrameResourceDecoder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06000EE2 RID: 3810 RVA: 0x0002FC84 File Offset: 0x0002DE84
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return GifFrameResourceDecoder._members.ManagedPeerType;
			}
		}

		// Token: 0x06000EE3 RID: 3811 RVA: 0x0002FC90 File Offset: 0x0002DE90
		internal GifFrameResourceDecoder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000EE4 RID: 3812 RVA: 0x0002FC9C File Offset: 0x0002DE9C
		[Register(".ctor", "(Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;)V", "")]
		public unsafe GifFrameResourceDecoder(IBitmapPool bitmapPool) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((bitmapPool == null) ? IntPtr.Zero : ((Java.Lang.Object)bitmapPool).Handle);
				base.SetHandle(GifFrameResourceDecoder._members.InstanceMethods.StartCreateInstance("(Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				GifFrameResourceDecoder._members.InstanceMethods.FinishCreateInstance("(Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(bitmapPool);
			}
		}

		// Token: 0x06000EE5 RID: 3813 RVA: 0x0002FD50 File Offset: 0x0002DF50
		[Register("decode", "(Lcom/bumptech/glide/gifdecoder/GifDecoder;IILcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/engine/Resource;", "")]
		public unsafe IResource Decode(IGifDecoder source, int width, int height, Options options)
		{
			IResource @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((source == null) ? IntPtr.Zero : ((Java.Lang.Object)source).Handle);
				ptr[1] = new JniArgumentValue(width);
				ptr[2] = new JniArgumentValue(height);
				ptr[3] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				@object = Java.Lang.Object.GetObject<IResource>(GifFrameResourceDecoder._members.InstanceMethods.InvokeAbstractObjectMethod("decode.(Lcom/bumptech/glide/gifdecoder/GifDecoder;IILcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/engine/Resource;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(source);
				GC.KeepAlive(options);
			}
			return @object;
		}

		// Token: 0x06000EE6 RID: 3814 RVA: 0x0002FE20 File Offset: 0x0002E020
		[Register("handles", "(Lcom/bumptech/glide/gifdecoder/GifDecoder;Lcom/bumptech/glide/load/Options;)Z", "")]
		public unsafe bool Handles(IGifDecoder source, Options options)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((source == null) ? IntPtr.Zero : ((Java.Lang.Object)source).Handle);
				ptr[1] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				result = GifFrameResourceDecoder._members.InstanceMethods.InvokeAbstractBooleanMethod("handles.(Lcom/bumptech/glide/gifdecoder/GifDecoder;Lcom/bumptech/glide/load/Options;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(source);
				GC.KeepAlive(options);
			}
			return result;
		}

		// Token: 0x06000EE7 RID: 3815 RVA: 0x0002FEB4 File Offset: 0x0002E0B4
		IResource IResourceDecoder.Decode(Java.Lang.Object p0, int p1, int p2, Options p3)
		{
			return this.Decode(p0.JavaCast<IGifDecoder>(), p1, p2, p3).JavaCast<IResource>();
		}

		// Token: 0x06000EE8 RID: 3816 RVA: 0x0002FECB File Offset: 0x0002E0CB
		bool IResourceDecoder.Handles(Java.Lang.Object p0, Options p1)
		{
			return this.Handles(p0.JavaCast<IGifDecoder>(), p1);
		}

		// Token: 0x04000375 RID: 885
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/resource/gif/GifFrameResourceDecoder", typeof(GifFrameResourceDecoder));
	}
}
