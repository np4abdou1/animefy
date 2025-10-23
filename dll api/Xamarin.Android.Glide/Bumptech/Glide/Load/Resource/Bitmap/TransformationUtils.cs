using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Graphics;
using Android.Runtime;
using Bumptech.Glide.Load.Engine.BitmapRecycle;
using Java.Interop;
using Java.Lang;
using Java.Util.Concurrent.Locks;

namespace Bumptech.Glide.Load.Resource.Bitmap
{
	// Token: 0x02000119 RID: 281
	[Register("com/bumptech/glide/load/resource/bitmap/TransformationUtils", DoNotGenerateAcw = true)]
	public sealed class TransformationUtils : Java.Lang.Object
	{
		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06000E17 RID: 3607 RVA: 0x0002CCAC File Offset: 0x0002AEAC
		internal static IntPtr class_ref
		{
			get
			{
				return TransformationUtils._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06000E18 RID: 3608 RVA: 0x0002CCD0 File Offset: 0x0002AED0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return TransformationUtils._members;
			}
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06000E19 RID: 3609 RVA: 0x0002CCD8 File Offset: 0x0002AED8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return TransformationUtils._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06000E1A RID: 3610 RVA: 0x0002CCFC File Offset: 0x0002AEFC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return TransformationUtils._members.ManagedPeerType;
			}
		}

		// Token: 0x06000E1B RID: 3611 RVA: 0x0002CD08 File Offset: 0x0002AF08
		internal TransformationUtils(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06000E1C RID: 3612 RVA: 0x0002CD14 File Offset: 0x0002AF14
		public static ILock BitmapDrawableLock
		{
			[Register("getBitmapDrawableLock", "()Ljava/util/concurrent/locks/Lock;", "")]
			get
			{
				return Java.Lang.Object.GetObject<ILock>(TransformationUtils._members.StaticMethods.InvokeObjectMethod("getBitmapDrawableLock.()Ljava/util/concurrent/locks/Lock;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000E1D RID: 3613 RVA: 0x0002CD48 File Offset: 0x0002AF48
		[Register("centerCrop", "(Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;Landroid/graphics/Bitmap;II)Landroid/graphics/Bitmap;", "")]
		public unsafe static Bitmap CenterCrop(IBitmapPool pool, Bitmap inBitmap, int width, int height)
		{
			Bitmap @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((pool == null) ? IntPtr.Zero : ((Java.Lang.Object)pool).Handle);
				ptr[1] = new JniArgumentValue((inBitmap == null) ? IntPtr.Zero : inBitmap.Handle);
				ptr[2] = new JniArgumentValue(width);
				ptr[3] = new JniArgumentValue(height);
				@object = Java.Lang.Object.GetObject<Bitmap>(TransformationUtils._members.StaticMethods.InvokeObjectMethod("centerCrop.(Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;Landroid/graphics/Bitmap;II)Landroid/graphics/Bitmap;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(pool);
				GC.KeepAlive(inBitmap);
			}
			return @object;
		}

		// Token: 0x06000E1E RID: 3614 RVA: 0x0002CE14 File Offset: 0x0002B014
		[Register("centerInside", "(Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;Landroid/graphics/Bitmap;II)Landroid/graphics/Bitmap;", "")]
		public unsafe static Bitmap CenterInside(IBitmapPool pool, Bitmap inBitmap, int width, int height)
		{
			Bitmap @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((pool == null) ? IntPtr.Zero : ((Java.Lang.Object)pool).Handle);
				ptr[1] = new JniArgumentValue((inBitmap == null) ? IntPtr.Zero : inBitmap.Handle);
				ptr[2] = new JniArgumentValue(width);
				ptr[3] = new JniArgumentValue(height);
				@object = Java.Lang.Object.GetObject<Bitmap>(TransformationUtils._members.StaticMethods.InvokeObjectMethod("centerInside.(Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;Landroid/graphics/Bitmap;II)Landroid/graphics/Bitmap;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(pool);
				GC.KeepAlive(inBitmap);
			}
			return @object;
		}

		// Token: 0x06000E1F RID: 3615 RVA: 0x0002CEE0 File Offset: 0x0002B0E0
		[Register("circleCrop", "(Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;Landroid/graphics/Bitmap;II)Landroid/graphics/Bitmap;", "")]
		public unsafe static Bitmap CircleCrop(IBitmapPool pool, Bitmap inBitmap, int destWidth, int destHeight)
		{
			Bitmap @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((pool == null) ? IntPtr.Zero : ((Java.Lang.Object)pool).Handle);
				ptr[1] = new JniArgumentValue((inBitmap == null) ? IntPtr.Zero : inBitmap.Handle);
				ptr[2] = new JniArgumentValue(destWidth);
				ptr[3] = new JniArgumentValue(destHeight);
				@object = Java.Lang.Object.GetObject<Bitmap>(TransformationUtils._members.StaticMethods.InvokeObjectMethod("circleCrop.(Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;Landroid/graphics/Bitmap;II)Landroid/graphics/Bitmap;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(pool);
				GC.KeepAlive(inBitmap);
			}
			return @object;
		}

		// Token: 0x06000E20 RID: 3616 RVA: 0x0002CFAC File Offset: 0x0002B1AC
		[Register("fitCenter", "(Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;Landroid/graphics/Bitmap;II)Landroid/graphics/Bitmap;", "")]
		public unsafe static Bitmap FitCenter(IBitmapPool pool, Bitmap inBitmap, int width, int height)
		{
			Bitmap @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((pool == null) ? IntPtr.Zero : ((Java.Lang.Object)pool).Handle);
				ptr[1] = new JniArgumentValue((inBitmap == null) ? IntPtr.Zero : inBitmap.Handle);
				ptr[2] = new JniArgumentValue(width);
				ptr[3] = new JniArgumentValue(height);
				@object = Java.Lang.Object.GetObject<Bitmap>(TransformationUtils._members.StaticMethods.InvokeObjectMethod("fitCenter.(Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;Landroid/graphics/Bitmap;II)Landroid/graphics/Bitmap;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(pool);
				GC.KeepAlive(inBitmap);
			}
			return @object;
		}

		// Token: 0x06000E21 RID: 3617 RVA: 0x0002D078 File Offset: 0x0002B278
		[Register("getExifOrientationDegrees", "(I)I", "")]
		public unsafe static int GetExifOrientationDegrees(int exifOrientation)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(exifOrientation);
			return TransformationUtils._members.StaticMethods.InvokeInt32Method("getExifOrientationDegrees.(I)I", ptr);
		}

		// Token: 0x06000E22 RID: 3618 RVA: 0x0002D0B4 File Offset: 0x0002B2B4
		[Register("isExifOrientationRequired", "(I)Z", "")]
		public unsafe static bool IsExifOrientationRequired(int exifOrientation)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(exifOrientation);
			return TransformationUtils._members.StaticMethods.InvokeBooleanMethod("isExifOrientationRequired.(I)Z", ptr);
		}

		// Token: 0x06000E23 RID: 3619 RVA: 0x0002D0F0 File Offset: 0x0002B2F0
		[Register("rotateImage", "(Landroid/graphics/Bitmap;I)Landroid/graphics/Bitmap;", "")]
		public unsafe static Bitmap RotateImage(Bitmap imageToOrient, int degreesToRotate)
		{
			Bitmap @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((imageToOrient == null) ? IntPtr.Zero : imageToOrient.Handle);
				ptr[1] = new JniArgumentValue(degreesToRotate);
				@object = Java.Lang.Object.GetObject<Bitmap>(TransformationUtils._members.StaticMethods.InvokeObjectMethod("rotateImage.(Landroid/graphics/Bitmap;I)Landroid/graphics/Bitmap;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(imageToOrient);
			}
			return @object;
		}

		// Token: 0x06000E24 RID: 3620 RVA: 0x0002D178 File Offset: 0x0002B378
		[Register("rotateImageExif", "(Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;Landroid/graphics/Bitmap;I)Landroid/graphics/Bitmap;", "")]
		public unsafe static Bitmap RotateImageExif(IBitmapPool pool, Bitmap inBitmap, int exifOrientation)
		{
			Bitmap @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((pool == null) ? IntPtr.Zero : ((Java.Lang.Object)pool).Handle);
				ptr[1] = new JniArgumentValue((inBitmap == null) ? IntPtr.Zero : inBitmap.Handle);
				ptr[2] = new JniArgumentValue(exifOrientation);
				@object = Java.Lang.Object.GetObject<Bitmap>(TransformationUtils._members.StaticMethods.InvokeObjectMethod("rotateImageExif.(Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;Landroid/graphics/Bitmap;I)Landroid/graphics/Bitmap;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(pool);
				GC.KeepAlive(inBitmap);
			}
			return @object;
		}

		// Token: 0x06000E25 RID: 3621 RVA: 0x0002D230 File Offset: 0x0002B430
		[Register("roundedCorners", "(Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;Landroid/graphics/Bitmap;FFFF)Landroid/graphics/Bitmap;", "")]
		public unsafe static Bitmap RoundedCorners(IBitmapPool pool, Bitmap inBitmap, float topLeft, float topRight, float bottomRight, float bottomLeft)
		{
			Bitmap @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((pool == null) ? IntPtr.Zero : ((Java.Lang.Object)pool).Handle);
				ptr[1] = new JniArgumentValue((inBitmap == null) ? IntPtr.Zero : inBitmap.Handle);
				ptr[2] = new JniArgumentValue(topLeft);
				ptr[3] = new JniArgumentValue(topRight);
				ptr[4] = new JniArgumentValue(bottomRight);
				ptr[5] = new JniArgumentValue(bottomLeft);
				@object = Java.Lang.Object.GetObject<Bitmap>(TransformationUtils._members.StaticMethods.InvokeObjectMethod("roundedCorners.(Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;Landroid/graphics/Bitmap;FFFF)Landroid/graphics/Bitmap;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(pool);
				GC.KeepAlive(inBitmap);
			}
			return @object;
		}

		// Token: 0x06000E26 RID: 3622 RVA: 0x0002D32C File Offset: 0x0002B52C
		[Register("roundedCorners", "(Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;Landroid/graphics/Bitmap;I)Landroid/graphics/Bitmap;", "")]
		public unsafe static Bitmap RoundedCorners(IBitmapPool pool, Bitmap inBitmap, int roundingRadius)
		{
			Bitmap @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((pool == null) ? IntPtr.Zero : ((Java.Lang.Object)pool).Handle);
				ptr[1] = new JniArgumentValue((inBitmap == null) ? IntPtr.Zero : inBitmap.Handle);
				ptr[2] = new JniArgumentValue(roundingRadius);
				@object = Java.Lang.Object.GetObject<Bitmap>(TransformationUtils._members.StaticMethods.InvokeObjectMethod("roundedCorners.(Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;Landroid/graphics/Bitmap;I)Landroid/graphics/Bitmap;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(pool);
				GC.KeepAlive(inBitmap);
			}
			return @object;
		}

		// Token: 0x06000E27 RID: 3623 RVA: 0x0002D3E4 File Offset: 0x0002B5E4
		[Obsolete("deprecated")]
		[Register("roundedCorners", "(Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;Landroid/graphics/Bitmap;III)Landroid/graphics/Bitmap;", "")]
		public unsafe static Bitmap RoundedCorners(IBitmapPool pool, Bitmap inBitmap, int width, int height, int roundingRadius)
		{
			Bitmap @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((pool == null) ? IntPtr.Zero : ((Java.Lang.Object)pool).Handle);
				ptr[1] = new JniArgumentValue((inBitmap == null) ? IntPtr.Zero : inBitmap.Handle);
				ptr[2] = new JniArgumentValue(width);
				ptr[3] = new JniArgumentValue(height);
				ptr[4] = new JniArgumentValue(roundingRadius);
				@object = Java.Lang.Object.GetObject<Bitmap>(TransformationUtils._members.StaticMethods.InvokeObjectMethod("roundedCorners.(Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;Landroid/graphics/Bitmap;III)Landroid/graphics/Bitmap;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(pool);
				GC.KeepAlive(inBitmap);
			}
			return @object;
		}

		// Token: 0x06000E28 RID: 3624 RVA: 0x0002D4C8 File Offset: 0x0002B6C8
		[Register("setAlpha", "(Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;)V", "")]
		public unsafe static void SetAlpha(Bitmap inBitmap, Bitmap outBitmap)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((inBitmap == null) ? IntPtr.Zero : inBitmap.Handle);
				ptr[1] = new JniArgumentValue((outBitmap == null) ? IntPtr.Zero : outBitmap.Handle);
				TransformationUtils._members.StaticMethods.InvokeVoidMethod("setAlpha.(Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(inBitmap);
				GC.KeepAlive(outBitmap);
			}
		}

		// Token: 0x04000347 RID: 839
		[Register("PAINT_FLAGS")]
		public const int PaintFlags = 6;

		// Token: 0x04000348 RID: 840
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/resource/bitmap/TransformationUtils", typeof(TransformationUtils));
	}
}
