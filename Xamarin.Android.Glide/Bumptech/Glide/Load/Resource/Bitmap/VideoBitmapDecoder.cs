using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Bumptech.Glide.Load.Engine.BitmapRecycle;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Resource.Bitmap
{
	// Token: 0x0200011B RID: 283
	[Obsolete("This class is obsoleted in this android platform")]
	[Register("com/bumptech/glide/load/resource/bitmap/VideoBitmapDecoder", DoNotGenerateAcw = true)]
	public class VideoBitmapDecoder : VideoDecoder
	{
		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06000E35 RID: 3637 RVA: 0x0002D7E8 File Offset: 0x0002B9E8
		internal new static IntPtr class_ref
		{
			get
			{
				return VideoBitmapDecoder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06000E36 RID: 3638 RVA: 0x0002D80C File Offset: 0x0002BA0C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return VideoBitmapDecoder._members;
			}
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06000E37 RID: 3639 RVA: 0x0002D814 File Offset: 0x0002BA14
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return VideoBitmapDecoder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06000E38 RID: 3640 RVA: 0x0002D838 File Offset: 0x0002BA38
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return VideoBitmapDecoder._members.ManagedPeerType;
			}
		}

		// Token: 0x06000E39 RID: 3641 RVA: 0x0002D844 File Offset: 0x0002BA44
		protected VideoBitmapDecoder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000E3A RID: 3642 RVA: 0x0002D850 File Offset: 0x0002BA50
		[Register(".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe VideoBitmapDecoder(Context context) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				base.SetHandle(VideoBitmapDecoder._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				VideoBitmapDecoder._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
		}

		// Token: 0x06000E3B RID: 3643 RVA: 0x0002D900 File Offset: 0x0002BB00
		[Register(".ctor", "(Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;)V", "")]
		public unsafe VideoBitmapDecoder(IBitmapPool bitmapPool) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((bitmapPool == null) ? IntPtr.Zero : ((Java.Lang.Object)bitmapPool).Handle);
				base.SetHandle(VideoBitmapDecoder._members.InstanceMethods.StartCreateInstance("(Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				VideoBitmapDecoder._members.InstanceMethods.FinishCreateInstance("(Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(bitmapPool);
			}
		}

		// Token: 0x0400034A RID: 842
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/resource/bitmap/VideoBitmapDecoder", typeof(VideoBitmapDecoder));
	}
}
