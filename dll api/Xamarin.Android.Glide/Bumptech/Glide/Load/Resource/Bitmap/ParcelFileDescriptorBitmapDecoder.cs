using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Bumptech.Glide.Load.Engine;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Resource.Bitmap
{
	// Token: 0x02000114 RID: 276
	[Register("com/bumptech/glide/load/resource/bitmap/ParcelFileDescriptorBitmapDecoder", DoNotGenerateAcw = true)]
	public sealed class ParcelFileDescriptorBitmapDecoder : Java.Lang.Object, IResourceDecoder, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06000DDA RID: 3546 RVA: 0x0002BF54 File Offset: 0x0002A154
		internal static IntPtr class_ref
		{
			get
			{
				return ParcelFileDescriptorBitmapDecoder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06000DDB RID: 3547 RVA: 0x0002BF78 File Offset: 0x0002A178
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ParcelFileDescriptorBitmapDecoder._members;
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06000DDC RID: 3548 RVA: 0x0002BF80 File Offset: 0x0002A180
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ParcelFileDescriptorBitmapDecoder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06000DDD RID: 3549 RVA: 0x0002BFA4 File Offset: 0x0002A1A4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ParcelFileDescriptorBitmapDecoder._members.ManagedPeerType;
			}
		}

		// Token: 0x06000DDE RID: 3550 RVA: 0x0002BFB0 File Offset: 0x0002A1B0
		internal ParcelFileDescriptorBitmapDecoder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000DDF RID: 3551 RVA: 0x0002BFBC File Offset: 0x0002A1BC
		[Register(".ctor", "(Lcom/bumptech/glide/load/resource/bitmap/Downsampler;)V", "")]
		public unsafe ParcelFileDescriptorBitmapDecoder(Downsampler downsampler) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((downsampler == null) ? IntPtr.Zero : downsampler.Handle);
				base.SetHandle(ParcelFileDescriptorBitmapDecoder._members.InstanceMethods.StartCreateInstance("(Lcom/bumptech/glide/load/resource/bitmap/Downsampler;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ParcelFileDescriptorBitmapDecoder._members.InstanceMethods.FinishCreateInstance("(Lcom/bumptech/glide/load/resource/bitmap/Downsampler;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(downsampler);
			}
		}

		// Token: 0x06000DE0 RID: 3552 RVA: 0x0002C06C File Offset: 0x0002A26C
		[Register("decode", "(Landroid/os/ParcelFileDescriptor;IILcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/engine/Resource;", "")]
		public unsafe IResource Decode(ParcelFileDescriptor source, int width, int height, Options options)
		{
			IResource @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((source == null) ? IntPtr.Zero : source.Handle);
				ptr[1] = new JniArgumentValue(width);
				ptr[2] = new JniArgumentValue(height);
				ptr[3] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				@object = Java.Lang.Object.GetObject<IResource>(ParcelFileDescriptorBitmapDecoder._members.InstanceMethods.InvokeAbstractObjectMethod("decode.(Landroid/os/ParcelFileDescriptor;IILcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/engine/Resource;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(source);
				GC.KeepAlive(options);
			}
			return @object;
		}

		// Token: 0x06000DE1 RID: 3553 RVA: 0x0002C138 File Offset: 0x0002A338
		[Register("handles", "(Landroid/os/ParcelFileDescriptor;Lcom/bumptech/glide/load/Options;)Z", "")]
		public unsafe bool Handles(ParcelFileDescriptor source, Options options)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((source == null) ? IntPtr.Zero : source.Handle);
				ptr[1] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				result = ParcelFileDescriptorBitmapDecoder._members.InstanceMethods.InvokeAbstractBooleanMethod("handles.(Landroid/os/ParcelFileDescriptor;Lcom/bumptech/glide/load/Options;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(source);
				GC.KeepAlive(options);
			}
			return result;
		}

		// Token: 0x06000DE2 RID: 3554 RVA: 0x0002C1C8 File Offset: 0x0002A3C8
		IResource IResourceDecoder.Decode(Java.Lang.Object p0, int p1, int p2, Options p3)
		{
			return this.Decode(p0.JavaCast<ParcelFileDescriptor>(), p1, p2, p3).JavaCast<IResource>();
		}

		// Token: 0x06000DE3 RID: 3555 RVA: 0x0002C1DF File Offset: 0x0002A3DF
		bool IResourceDecoder.Handles(Java.Lang.Object p0, Options p1)
		{
			return this.Handles(p0.JavaCast<ParcelFileDescriptor>(), p1);
		}

		// Token: 0x0400033C RID: 828
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/resource/bitmap/ParcelFileDescriptorBitmapDecoder", typeof(ParcelFileDescriptorBitmapDecoder));
	}
}
