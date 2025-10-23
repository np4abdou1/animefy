using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Graphics;
using Android.Runtime;
using Bumptech.Glide.GifDecoder;
using Bumptech.Glide.Load.Engine.BitmapRecycle;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Resource.Gif
{
	// Token: 0x0200011F RID: 287
	[Register("com/bumptech/glide/load/resource/gif/GifBitmapProvider", DoNotGenerateAcw = true)]
	public sealed class GifBitmapProvider : Java.Lang.Object, IGifDecoderBitmapProvider, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06000E6C RID: 3692 RVA: 0x0002E598 File Offset: 0x0002C798
		internal static IntPtr class_ref
		{
			get
			{
				return GifBitmapProvider._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06000E6D RID: 3693 RVA: 0x0002E5BC File Offset: 0x0002C7BC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return GifBitmapProvider._members;
			}
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06000E6E RID: 3694 RVA: 0x0002E5C4 File Offset: 0x0002C7C4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return GifBitmapProvider._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06000E6F RID: 3695 RVA: 0x0002E5E8 File Offset: 0x0002C7E8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return GifBitmapProvider._members.ManagedPeerType;
			}
		}

		// Token: 0x06000E70 RID: 3696 RVA: 0x0002E5F4 File Offset: 0x0002C7F4
		internal GifBitmapProvider(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000E71 RID: 3697 RVA: 0x0002E600 File Offset: 0x0002C800
		[Register(".ctor", "(Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;)V", "")]
		public unsafe GifBitmapProvider(IBitmapPool bitmapPool) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((bitmapPool == null) ? IntPtr.Zero : ((Java.Lang.Object)bitmapPool).Handle);
				base.SetHandle(GifBitmapProvider._members.InstanceMethods.StartCreateInstance("(Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				GifBitmapProvider._members.InstanceMethods.FinishCreateInstance("(Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(bitmapPool);
			}
		}

		// Token: 0x06000E72 RID: 3698 RVA: 0x0002E6B4 File Offset: 0x0002C8B4
		[Register(".ctor", "(Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;Lcom/bumptech/glide/load/engine/bitmap_recycle/ArrayPool;)V", "")]
		public unsafe GifBitmapProvider(IBitmapPool bitmapPool, IArrayPool arrayPool) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((bitmapPool == null) ? IntPtr.Zero : ((Java.Lang.Object)bitmapPool).Handle);
				ptr[1] = new JniArgumentValue((arrayPool == null) ? IntPtr.Zero : ((Java.Lang.Object)arrayPool).Handle);
				base.SetHandle(GifBitmapProvider._members.InstanceMethods.StartCreateInstance("(Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;Lcom/bumptech/glide/load/engine/bitmap_recycle/ArrayPool;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				GifBitmapProvider._members.InstanceMethods.FinishCreateInstance("(Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;Lcom/bumptech/glide/load/engine/bitmap_recycle/ArrayPool;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(bitmapPool);
				GC.KeepAlive(arrayPool);
			}
		}

		// Token: 0x06000E73 RID: 3699 RVA: 0x0002E794 File Offset: 0x0002C994
		[Register("obtain", "(IILandroid/graphics/Bitmap$Config;)Landroid/graphics/Bitmap;", "")]
		public unsafe Bitmap Obtain(int width, int height, Bitmap.Config config)
		{
			Bitmap @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(width);
				ptr[1] = new JniArgumentValue(height);
				ptr[2] = new JniArgumentValue((config == null) ? IntPtr.Zero : config.Handle);
				@object = Java.Lang.Object.GetObject<Bitmap>(GifBitmapProvider._members.InstanceMethods.InvokeAbstractObjectMethod("obtain.(IILandroid/graphics/Bitmap$Config;)Landroid/graphics/Bitmap;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(config);
			}
			return @object;
		}

		// Token: 0x06000E74 RID: 3700 RVA: 0x0002E830 File Offset: 0x0002CA30
		[Register("obtainByteArray", "(I)[B", "")]
		public unsafe byte[] ObtainByteArray(int size)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(size);
			return (byte[])JNIEnv.GetArray(GifBitmapProvider._members.InstanceMethods.InvokeAbstractObjectMethod("obtainByteArray.(I)[B", this, ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(byte));
		}

		// Token: 0x06000E75 RID: 3701 RVA: 0x0002E888 File Offset: 0x0002CA88
		[Register("obtainIntArray", "(I)[I", "")]
		public unsafe int[] ObtainIntArray(int size)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(size);
			return (int[])JNIEnv.GetArray(GifBitmapProvider._members.InstanceMethods.InvokeAbstractObjectMethod("obtainIntArray.(I)[I", this, ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(int));
		}

		// Token: 0x06000E76 RID: 3702 RVA: 0x0002E8E0 File Offset: 0x0002CAE0
		[Register("release", "(Landroid/graphics/Bitmap;)V", "")]
		public unsafe void Release(Bitmap bitmap)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((bitmap == null) ? IntPtr.Zero : bitmap.Handle);
				GifBitmapProvider._members.InstanceMethods.InvokeAbstractVoidMethod("release.(Landroid/graphics/Bitmap;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(bitmap);
			}
		}

		// Token: 0x06000E77 RID: 3703 RVA: 0x0002E944 File Offset: 0x0002CB44
		[Register("release", "([B)V", "")]
		public unsafe void Release(byte[] bytes)
		{
			IntPtr intPtr = JNIEnv.NewArray(bytes);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				GifBitmapProvider._members.InstanceMethods.InvokeAbstractVoidMethod("release.([B)V", this, ptr);
			}
			finally
			{
				if (bytes != null)
				{
					JNIEnv.CopyArray(intPtr, bytes);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(bytes);
			}
		}

		// Token: 0x06000E78 RID: 3704 RVA: 0x0002E9B0 File Offset: 0x0002CBB0
		[Register("release", "([I)V", "")]
		public unsafe void Release(int[] array)
		{
			IntPtr intPtr = JNIEnv.NewArray(array);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				GifBitmapProvider._members.InstanceMethods.InvokeAbstractVoidMethod("release.([I)V", this, ptr);
			}
			finally
			{
				if (array != null)
				{
					JNIEnv.CopyArray(intPtr, array);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(array);
			}
		}

		// Token: 0x04000355 RID: 853
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/resource/gif/GifBitmapProvider", typeof(GifBitmapProvider));
	}
}
