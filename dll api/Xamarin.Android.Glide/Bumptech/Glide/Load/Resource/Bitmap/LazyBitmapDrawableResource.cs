using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Content.Res;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Runtime;
using Bumptech.Glide.Load.Engine;
using Bumptech.Glide.Load.Engine.BitmapRecycle;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Resource.Bitmap
{
	// Token: 0x02000113 RID: 275
	[Register("com/bumptech/glide/load/resource/bitmap/LazyBitmapDrawableResource", DoNotGenerateAcw = true)]
	public sealed class LazyBitmapDrawableResource : Java.Lang.Object, IInitializable, IJavaObject, IDisposable, IJavaPeerable, IResource
	{
		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06000DCB RID: 3531 RVA: 0x0002BC08 File Offset: 0x00029E08
		internal static IntPtr class_ref
		{
			get
			{
				return LazyBitmapDrawableResource._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06000DCC RID: 3532 RVA: 0x0002BC2C File Offset: 0x00029E2C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return LazyBitmapDrawableResource._members;
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06000DCD RID: 3533 RVA: 0x0002BC34 File Offset: 0x00029E34
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return LazyBitmapDrawableResource._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06000DCE RID: 3534 RVA: 0x0002BC58 File Offset: 0x00029E58
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return LazyBitmapDrawableResource._members.ManagedPeerType;
			}
		}

		// Token: 0x06000DCF RID: 3535 RVA: 0x0002BC64 File Offset: 0x00029E64
		internal LazyBitmapDrawableResource(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06000DD0 RID: 3536 RVA: 0x0002BC70 File Offset: 0x00029E70
		public Class ResourceClass
		{
			[Register("getResourceClass", "()Ljava/lang/Class;", "")]
			get
			{
				return Java.Lang.Object.GetObject<Class>(LazyBitmapDrawableResource._members.InstanceMethods.InvokeAbstractObjectMethod("getResourceClass.()Ljava/lang/Class;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06000DD1 RID: 3537 RVA: 0x0002BCA2 File Offset: 0x00029EA2
		public int Size
		{
			[Register("getSize", "()I", "")]
			get
			{
				return LazyBitmapDrawableResource._members.InstanceMethods.InvokeAbstractInt32Method("getSize.()I", this, null);
			}
		}

		// Token: 0x06000DD2 RID: 3538 RVA: 0x0002BCBC File Offset: 0x00029EBC
		[Register("get", "()Landroid/graphics/drawable/BitmapDrawable;", "")]
		public BitmapDrawable Get()
		{
			return Java.Lang.Object.GetObject<BitmapDrawable>(LazyBitmapDrawableResource._members.InstanceMethods.InvokeAbstractObjectMethod("get.()Landroid/graphics/drawable/BitmapDrawable;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000DD3 RID: 3539 RVA: 0x0002BCEE File Offset: 0x00029EEE
		[Register("initialize", "()V", "")]
		public void Initialize()
		{
			LazyBitmapDrawableResource._members.InstanceMethods.InvokeAbstractVoidMethod("initialize.()V", this, null);
		}

		// Token: 0x06000DD4 RID: 3540 RVA: 0x0002BD08 File Offset: 0x00029F08
		[Obsolete("deprecated")]
		[Register("obtain", "(Landroid/content/Context;Landroid/graphics/Bitmap;)Lcom/bumptech/glide/load/resource/bitmap/LazyBitmapDrawableResource;", "")]
		public unsafe static LazyBitmapDrawableResource Obtain(Context context, Bitmap bitmap)
		{
			LazyBitmapDrawableResource @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((bitmap == null) ? IntPtr.Zero : bitmap.Handle);
				@object = Java.Lang.Object.GetObject<LazyBitmapDrawableResource>(LazyBitmapDrawableResource._members.StaticMethods.InvokeObjectMethod("obtain.(Landroid/content/Context;Landroid/graphics/Bitmap;)Lcom/bumptech/glide/load/resource/bitmap/LazyBitmapDrawableResource;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(bitmap);
			}
			return @object;
		}

		// Token: 0x06000DD5 RID: 3541 RVA: 0x0002BDA4 File Offset: 0x00029FA4
		[Obsolete("deprecated")]
		[Register("obtain", "(Landroid/content/res/Resources;Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;Landroid/graphics/Bitmap;)Lcom/bumptech/glide/load/resource/bitmap/LazyBitmapDrawableResource;", "")]
		public unsafe static LazyBitmapDrawableResource Obtain(Resources resources, IBitmapPool bitmapPool, Bitmap bitmap)
		{
			LazyBitmapDrawableResource @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((resources == null) ? IntPtr.Zero : resources.Handle);
				ptr[1] = new JniArgumentValue((bitmapPool == null) ? IntPtr.Zero : ((Java.Lang.Object)bitmapPool).Handle);
				ptr[2] = new JniArgumentValue((bitmap == null) ? IntPtr.Zero : bitmap.Handle);
				@object = Java.Lang.Object.GetObject<LazyBitmapDrawableResource>(LazyBitmapDrawableResource._members.StaticMethods.InvokeObjectMethod("obtain.(Landroid/content/res/Resources;Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;Landroid/graphics/Bitmap;)Lcom/bumptech/glide/load/resource/bitmap/LazyBitmapDrawableResource;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(resources);
				GC.KeepAlive(bitmapPool);
				GC.KeepAlive(bitmap);
			}
			return @object;
		}

		// Token: 0x06000DD6 RID: 3542 RVA: 0x0002BE70 File Offset: 0x0002A070
		[Register("obtain", "(Landroid/content/res/Resources;Lcom/bumptech/glide/load/engine/Resource;)Lcom/bumptech/glide/load/engine/Resource;", "")]
		public unsafe static IResource Obtain(Resources resources, IResource bitmapResource)
		{
			IResource @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((resources == null) ? IntPtr.Zero : resources.Handle);
				ptr[1] = new JniArgumentValue((bitmapResource == null) ? IntPtr.Zero : ((Java.Lang.Object)bitmapResource).Handle);
				@object = Java.Lang.Object.GetObject<IResource>(LazyBitmapDrawableResource._members.StaticMethods.InvokeObjectMethod("obtain.(Landroid/content/res/Resources;Lcom/bumptech/glide/load/engine/Resource;)Lcom/bumptech/glide/load/engine/Resource;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(resources);
				GC.KeepAlive(bitmapResource);
			}
			return @object;
		}

		// Token: 0x06000DD7 RID: 3543 RVA: 0x0002BF10 File Offset: 0x0002A110
		[Register("recycle", "()V", "")]
		public void Recycle()
		{
			LazyBitmapDrawableResource._members.InstanceMethods.InvokeAbstractVoidMethod("recycle.()V", this, null);
		}

		// Token: 0x06000DD8 RID: 3544 RVA: 0x0002BF29 File Offset: 0x0002A129
		Java.Lang.Object IResource.Get()
		{
			return this.Get().JavaCast<Java.Lang.Object>();
		}

		// Token: 0x0400033B RID: 827
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/resource/bitmap/LazyBitmapDrawableResource", typeof(LazyBitmapDrawableResource));
	}
}
