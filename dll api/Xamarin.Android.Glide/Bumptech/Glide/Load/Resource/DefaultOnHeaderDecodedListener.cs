using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Graphics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Resource
{
	// Token: 0x020000E2 RID: 226
	[Register("com/bumptech/glide/load/resource/DefaultOnHeaderDecodedListener", DoNotGenerateAcw = true)]
	public sealed class DefaultOnHeaderDecodedListener : Java.Lang.Object, ImageDecoder.IOnHeaderDecodedListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06000B52 RID: 2898 RVA: 0x0002341C File Offset: 0x0002161C
		internal static IntPtr class_ref
		{
			get
			{
				return DefaultOnHeaderDecodedListener._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06000B53 RID: 2899 RVA: 0x00023440 File Offset: 0x00021640
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DefaultOnHeaderDecodedListener._members;
			}
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06000B54 RID: 2900 RVA: 0x00023448 File Offset: 0x00021648
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DefaultOnHeaderDecodedListener._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06000B55 RID: 2901 RVA: 0x0002346C File Offset: 0x0002166C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DefaultOnHeaderDecodedListener._members.ManagedPeerType;
			}
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x00023478 File Offset: 0x00021678
		internal DefaultOnHeaderDecodedListener(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000B57 RID: 2903 RVA: 0x00023484 File Offset: 0x00021684
		[Register(".ctor", "(IILcom/bumptech/glide/load/Options;)V", "")]
		public unsafe DefaultOnHeaderDecodedListener(int requestedWidth, int requestedHeight, Options options) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(requestedWidth);
				ptr[1] = new JniArgumentValue(requestedHeight);
				ptr[2] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				base.SetHandle(DefaultOnHeaderDecodedListener._members.InstanceMethods.StartCreateInstance("(IILcom/bumptech/glide/load/Options;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				DefaultOnHeaderDecodedListener._members.InstanceMethods.FinishCreateInstance("(IILcom/bumptech/glide/load/Options;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(options);
			}
		}

		// Token: 0x06000B58 RID: 2904 RVA: 0x0002355C File Offset: 0x0002175C
		[Register("onHeaderDecoded", "(Landroid/graphics/ImageDecoder;Landroid/graphics/ImageDecoder$ImageInfo;Landroid/graphics/ImageDecoder$Source;)V", "")]
		public unsafe void OnHeaderDecoded(ImageDecoder decoder, ImageDecoder.ImageInfo info, ImageDecoder.Source source)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((decoder == null) ? IntPtr.Zero : decoder.Handle);
				ptr[1] = new JniArgumentValue((info == null) ? IntPtr.Zero : info.Handle);
				ptr[2] = new JniArgumentValue((source == null) ? IntPtr.Zero : source.Handle);
				DefaultOnHeaderDecodedListener._members.InstanceMethods.InvokeAbstractVoidMethod("onHeaderDecoded.(Landroid/graphics/ImageDecoder;Landroid/graphics/ImageDecoder$ImageInfo;Landroid/graphics/ImageDecoder$Source;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(decoder);
				GC.KeepAlive(info);
				GC.KeepAlive(source);
			}
		}

		// Token: 0x040002CB RID: 715
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/resource/DefaultOnHeaderDecodedListener", typeof(DefaultOnHeaderDecodedListener));
	}
}
