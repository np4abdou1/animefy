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
	// Token: 0x02000118 RID: 280
	[Register("com/bumptech/glide/load/resource/bitmap/RoundedCorners", DoNotGenerateAcw = true)]
	public sealed class RoundedCorners : BitmapTransformation
	{
		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06000E0E RID: 3598 RVA: 0x0002CA70 File Offset: 0x0002AC70
		internal new static IntPtr class_ref
		{
			get
			{
				return RoundedCorners._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06000E0F RID: 3599 RVA: 0x0002CA94 File Offset: 0x0002AC94
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return RoundedCorners._members;
			}
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06000E10 RID: 3600 RVA: 0x0002CA9C File Offset: 0x0002AC9C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return RoundedCorners._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06000E11 RID: 3601 RVA: 0x0002CAC0 File Offset: 0x0002ACC0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return RoundedCorners._members.ManagedPeerType;
			}
		}

		// Token: 0x06000E12 RID: 3602 RVA: 0x0002CACC File Offset: 0x0002ACCC
		internal RoundedCorners(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000E13 RID: 3603 RVA: 0x0002CAD8 File Offset: 0x0002ACD8
		[Register(".ctor", "(I)V", "")]
		public unsafe RoundedCorners(int roundingRadius) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(roundingRadius);
			base.SetHandle(RoundedCorners._members.InstanceMethods.StartCreateInstance("(I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			RoundedCorners._members.InstanceMethods.FinishCreateInstance("(I)V", this, ptr);
		}

		// Token: 0x06000E14 RID: 3604 RVA: 0x0002CB5C File Offset: 0x0002AD5C
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
				@object = Java.Lang.Object.GetObject<Bitmap>(RoundedCorners._members.InstanceMethods.InvokeAbstractObjectMethod("transform.(Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;Landroid/graphics/Bitmap;II)Landroid/graphics/Bitmap;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(pool);
				GC.KeepAlive(toTransform);
			}
			return @object;
		}

		// Token: 0x06000E15 RID: 3605 RVA: 0x0002CC2C File Offset: 0x0002AE2C
		[Register("updateDiskCacheKey", "(Ljava/security/MessageDigest;)V", "")]
		public unsafe override void UpdateDiskCacheKey(MessageDigest messageDigest)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((messageDigest == null) ? IntPtr.Zero : messageDigest.Handle);
				RoundedCorners._members.InstanceMethods.InvokeAbstractVoidMethod("updateDiskCacheKey.(Ljava/security/MessageDigest;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(messageDigest);
			}
		}

		// Token: 0x04000346 RID: 838
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/resource/bitmap/RoundedCorners", typeof(RoundedCorners));
	}
}
