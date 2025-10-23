using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Graphics;
using Android.Runtime;
using Bumptech.Glide.Load.Engine.BitmapRecycle;
using Java.Interop;
using Java.Lang;
using Java.Security;

namespace Bumptech.Glide.Load.Resource.Bitmap
{
	// Token: 0x02000110 RID: 272
	[Register("com/bumptech/glide/load/resource/bitmap/GranularRoundedCorners", DoNotGenerateAcw = true)]
	public sealed class GranularRoundedCorners : BitmapTransformation
	{
		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06000DAC RID: 3500 RVA: 0x0002B59C File Offset: 0x0002979C
		internal new static IntPtr class_ref
		{
			get
			{
				return GranularRoundedCorners._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06000DAD RID: 3501 RVA: 0x0002B5C0 File Offset: 0x000297C0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return GranularRoundedCorners._members;
			}
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06000DAE RID: 3502 RVA: 0x0002B5C8 File Offset: 0x000297C8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return GranularRoundedCorners._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06000DAF RID: 3503 RVA: 0x0002B5EC File Offset: 0x000297EC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return GranularRoundedCorners._members.ManagedPeerType;
			}
		}

		// Token: 0x06000DB0 RID: 3504 RVA: 0x0002B5F8 File Offset: 0x000297F8
		internal GranularRoundedCorners(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000DB1 RID: 3505 RVA: 0x0002B604 File Offset: 0x00029804
		[Register(".ctor", "(FFFF)V", "")]
		public unsafe GranularRoundedCorners(float topLeft, float topRight, float bottomRight, float bottomLeft) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(topLeft);
			ptr[1] = new JniArgumentValue(topRight);
			ptr[2] = new JniArgumentValue(bottomRight);
			ptr[3] = new JniArgumentValue(bottomLeft);
			base.SetHandle(GranularRoundedCorners._members.InstanceMethods.StartCreateInstance("(FFFF)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			GranularRoundedCorners._members.InstanceMethods.FinishCreateInstance("(FFFF)V", this, ptr);
		}

		// Token: 0x06000DB2 RID: 3506 RVA: 0x0002B6C8 File Offset: 0x000298C8
		[Register("transform", "(Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;Landroid/graphics/Bitmap;II)Landroid/graphics/Bitmap;", "")]
		protected unsafe override Bitmap Transform(IBitmapPool pool, Bitmap toTransform, int outWidth, int outHeight)
		{
			Bitmap @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((pool == null) ? IntPtr.Zero : ((Java.Lang.Object)pool).Handle);
				ptr[1] = new JniArgumentValue((toTransform == null) ? IntPtr.Zero : toTransform.Handle);
				ptr[2] = new JniArgumentValue(outWidth);
				ptr[3] = new JniArgumentValue(outHeight);
				@object = Java.Lang.Object.GetObject<Bitmap>(GranularRoundedCorners._members.InstanceMethods.InvokeAbstractObjectMethod("transform.(Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;Landroid/graphics/Bitmap;II)Landroid/graphics/Bitmap;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(pool);
				GC.KeepAlive(toTransform);
			}
			return @object;
		}

		// Token: 0x06000DB3 RID: 3507 RVA: 0x0002B798 File Offset: 0x00029998
		[Register("updateDiskCacheKey", "(Ljava/security/MessageDigest;)V", "")]
		public unsafe override void UpdateDiskCacheKey(MessageDigest messageDigest)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((messageDigest == null) ? IntPtr.Zero : messageDigest.Handle);
				GranularRoundedCorners._members.InstanceMethods.InvokeAbstractVoidMethod("updateDiskCacheKey.(Ljava/security/MessageDigest;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(messageDigest);
			}
		}

		// Token: 0x04000337 RID: 823
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/resource/bitmap/GranularRoundedCorners", typeof(GranularRoundedCorners));
	}
}
