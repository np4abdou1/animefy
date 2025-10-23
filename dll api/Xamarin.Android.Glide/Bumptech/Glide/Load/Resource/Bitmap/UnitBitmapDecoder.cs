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
	// Token: 0x0200011A RID: 282
	[Register("com/bumptech/glide/load/resource/bitmap/UnitBitmapDecoder", DoNotGenerateAcw = true)]
	public sealed class UnitBitmapDecoder : Java.Lang.Object, IResourceDecoder, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06000E2A RID: 3626 RVA: 0x0002D570 File Offset: 0x0002B770
		internal static IntPtr class_ref
		{
			get
			{
				return UnitBitmapDecoder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06000E2B RID: 3627 RVA: 0x0002D594 File Offset: 0x0002B794
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return UnitBitmapDecoder._members;
			}
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06000E2C RID: 3628 RVA: 0x0002D59C File Offset: 0x0002B79C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return UnitBitmapDecoder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06000E2D RID: 3629 RVA: 0x0002D5C0 File Offset: 0x0002B7C0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return UnitBitmapDecoder._members.ManagedPeerType;
			}
		}

		// Token: 0x06000E2E RID: 3630 RVA: 0x0002D5CC File Offset: 0x0002B7CC
		internal UnitBitmapDecoder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000E2F RID: 3631 RVA: 0x0002D5D8 File Offset: 0x0002B7D8
		[Register(".ctor", "()V", "")]
		public UnitBitmapDecoder() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(UnitBitmapDecoder._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			UnitBitmapDecoder._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000E30 RID: 3632 RVA: 0x0002D648 File Offset: 0x0002B848
		[Register("decode", "(Landroid/graphics/Bitmap;IILcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/engine/Resource;", "")]
		public unsafe IResource Decode(Bitmap source, int width, int height, Options options)
		{
			IResource @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((source == null) ? IntPtr.Zero : source.Handle);
				ptr[1] = new JniArgumentValue(width);
				ptr[2] = new JniArgumentValue(height);
				ptr[3] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				@object = Java.Lang.Object.GetObject<IResource>(UnitBitmapDecoder._members.InstanceMethods.InvokeAbstractObjectMethod("decode.(Landroid/graphics/Bitmap;IILcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/engine/Resource;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(source);
				GC.KeepAlive(options);
			}
			return @object;
		}

		// Token: 0x06000E31 RID: 3633 RVA: 0x0002D714 File Offset: 0x0002B914
		[Register("handles", "(Landroid/graphics/Bitmap;Lcom/bumptech/glide/load/Options;)Z", "")]
		public unsafe bool Handles(Bitmap source, Options options)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((source == null) ? IntPtr.Zero : source.Handle);
				ptr[1] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				result = UnitBitmapDecoder._members.InstanceMethods.InvokeAbstractBooleanMethod("handles.(Landroid/graphics/Bitmap;Lcom/bumptech/glide/load/Options;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(source);
				GC.KeepAlive(options);
			}
			return result;
		}

		// Token: 0x06000E32 RID: 3634 RVA: 0x0002D7A4 File Offset: 0x0002B9A4
		IResource IResourceDecoder.Decode(Java.Lang.Object p0, int p1, int p2, Options p3)
		{
			return this.Decode(p0.JavaCast<Bitmap>(), p1, p2, p3).JavaCast<IResource>();
		}

		// Token: 0x06000E33 RID: 3635 RVA: 0x0002D7BB File Offset: 0x0002B9BB
		bool IResourceDecoder.Handles(Java.Lang.Object p0, Options p1)
		{
			return this.Handles(p0.JavaCast<Bitmap>(), p1);
		}

		// Token: 0x04000349 RID: 841
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/resource/bitmap/UnitBitmapDecoder", typeof(UnitBitmapDecoder));
	}
}
