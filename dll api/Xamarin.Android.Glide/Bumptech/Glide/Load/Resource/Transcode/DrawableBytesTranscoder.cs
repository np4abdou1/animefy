using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Bumptech.Glide.Load.Engine;
using Bumptech.Glide.Load.Engine.BitmapRecycle;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Resource.Transcode
{
	// Token: 0x020000E7 RID: 231
	[Register("com/bumptech/glide/load/resource/transcode/DrawableBytesTranscoder", DoNotGenerateAcw = true)]
	public sealed class DrawableBytesTranscoder : Java.Lang.Object, IResourceTranscoder, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06000B8D RID: 2957 RVA: 0x00024158 File Offset: 0x00022358
		internal static IntPtr class_ref
		{
			get
			{
				return DrawableBytesTranscoder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06000B8E RID: 2958 RVA: 0x0002417C File Offset: 0x0002237C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DrawableBytesTranscoder._members;
			}
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06000B8F RID: 2959 RVA: 0x00024184 File Offset: 0x00022384
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DrawableBytesTranscoder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06000B90 RID: 2960 RVA: 0x000241A8 File Offset: 0x000223A8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DrawableBytesTranscoder._members.ManagedPeerType;
			}
		}

		// Token: 0x06000B91 RID: 2961 RVA: 0x000241B4 File Offset: 0x000223B4
		internal DrawableBytesTranscoder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000B92 RID: 2962 RVA: 0x000241C0 File Offset: 0x000223C0
		[Register(".ctor", "(Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;Lcom/bumptech/glide/load/resource/transcode/ResourceTranscoder;Lcom/bumptech/glide/load/resource/transcode/ResourceTranscoder;)V", "")]
		public unsafe DrawableBytesTranscoder(IBitmapPool bitmapPool, IResourceTranscoder bitmapBytesTranscoder, IResourceTranscoder gifDrawableBytesTranscoder) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((bitmapPool == null) ? IntPtr.Zero : ((Java.Lang.Object)bitmapPool).Handle);
				ptr[1] = new JniArgumentValue((bitmapBytesTranscoder == null) ? IntPtr.Zero : ((Java.Lang.Object)bitmapBytesTranscoder).Handle);
				ptr[2] = new JniArgumentValue((gifDrawableBytesTranscoder == null) ? IntPtr.Zero : ((Java.Lang.Object)gifDrawableBytesTranscoder).Handle);
				base.SetHandle(DrawableBytesTranscoder._members.InstanceMethods.StartCreateInstance("(Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;Lcom/bumptech/glide/load/resource/transcode/ResourceTranscoder;Lcom/bumptech/glide/load/resource/transcode/ResourceTranscoder;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				DrawableBytesTranscoder._members.InstanceMethods.FinishCreateInstance("(Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;Lcom/bumptech/glide/load/resource/transcode/ResourceTranscoder;Lcom/bumptech/glide/load/resource/transcode/ResourceTranscoder;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(bitmapPool);
				GC.KeepAlive(bitmapBytesTranscoder);
				GC.KeepAlive(gifDrawableBytesTranscoder);
			}
		}

		// Token: 0x06000B93 RID: 2963 RVA: 0x000242D0 File Offset: 0x000224D0
		[Register("transcode", "(Lcom/bumptech/glide/load/engine/Resource;Lcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/engine/Resource;", "")]
		public unsafe IResource Transcode(IResource toTranscode, Options options)
		{
			IResource @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((toTranscode == null) ? IntPtr.Zero : ((Java.Lang.Object)toTranscode).Handle);
				ptr[1] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				@object = Java.Lang.Object.GetObject<IResource>(DrawableBytesTranscoder._members.InstanceMethods.InvokeAbstractObjectMethod("transcode.(Lcom/bumptech/glide/load/engine/Resource;Lcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/engine/Resource;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(toTranscode);
				GC.KeepAlive(options);
			}
			return @object;
		}

		// Token: 0x06000B94 RID: 2964 RVA: 0x00024370 File Offset: 0x00022570
		IResource IResourceTranscoder.Transcode(IResource p0, Options p1)
		{
			return this.Transcode(p0.JavaCast<IResource>(), p1).JavaCast<IResource>();
		}

		// Token: 0x040002D4 RID: 724
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/resource/transcode/DrawableBytesTranscoder", typeof(DrawableBytesTranscoder));
	}
}
