using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Graphics;
using Android.Runtime;
using Bumptech.Glide.Load.Engine;
using Bumptech.Glide.Load.Engine.BitmapRecycle;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Resource.Bitmap
{
	// Token: 0x02000100 RID: 256
	[Register("com/bumptech/glide/load/resource/bitmap/BitmapResource", DoNotGenerateAcw = true)]
	public class BitmapResource : Java.Lang.Object, IInitializable, IJavaObject, IDisposable, IJavaPeerable, IResource
	{
		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06000CCA RID: 3274 RVA: 0x000282A4 File Offset: 0x000264A4
		internal static IntPtr class_ref
		{
			get
			{
				return BitmapResource._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06000CCB RID: 3275 RVA: 0x000282C8 File Offset: 0x000264C8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BitmapResource._members;
			}
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06000CCC RID: 3276 RVA: 0x000282D0 File Offset: 0x000264D0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BitmapResource._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06000CCD RID: 3277 RVA: 0x000282F4 File Offset: 0x000264F4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BitmapResource._members.ManagedPeerType;
			}
		}

		// Token: 0x06000CCE RID: 3278 RVA: 0x00028300 File Offset: 0x00026500
		protected BitmapResource(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000CCF RID: 3279 RVA: 0x0002830C File Offset: 0x0002650C
		[Register(".ctor", "(Landroid/graphics/Bitmap;Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;)V", "")]
		public unsafe BitmapResource(Bitmap bitmap, IBitmapPool bitmapPool) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((bitmap == null) ? IntPtr.Zero : bitmap.Handle);
				ptr[1] = new JniArgumentValue((bitmapPool == null) ? IntPtr.Zero : ((Java.Lang.Object)bitmapPool).Handle);
				base.SetHandle(BitmapResource._members.InstanceMethods.StartCreateInstance("(Landroid/graphics/Bitmap;Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				BitmapResource._members.InstanceMethods.FinishCreateInstance("(Landroid/graphics/Bitmap;Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(bitmap);
				GC.KeepAlive(bitmapPool);
			}
		}

		// Token: 0x06000CD0 RID: 3280 RVA: 0x000283E8 File Offset: 0x000265E8
		private static Delegate GetGetResourceClassHandler()
		{
			if (BitmapResource.cb_getResourceClass == null)
			{
				BitmapResource.cb_getResourceClass = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(BitmapResource.n_GetResourceClass));
			}
			return BitmapResource.cb_getResourceClass;
		}

		// Token: 0x06000CD1 RID: 3281 RVA: 0x0002840C File Offset: 0x0002660C
		private static IntPtr n_GetResourceClass(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<BitmapResource>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ResourceClass);
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06000CD2 RID: 3282 RVA: 0x00028420 File Offset: 0x00026620
		public virtual Class ResourceClass
		{
			[Register("getResourceClass", "()Ljava/lang/Class;", "GetGetResourceClassHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Class>(BitmapResource._members.InstanceMethods.InvokeVirtualObjectMethod("getResourceClass.()Ljava/lang/Class;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000CD3 RID: 3283 RVA: 0x00028452 File Offset: 0x00026652
		private static Delegate GetGetSizeHandler()
		{
			if (BitmapResource.cb_getSize == null)
			{
				BitmapResource.cb_getSize = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(BitmapResource.n_GetSize));
			}
			return BitmapResource.cb_getSize;
		}

		// Token: 0x06000CD4 RID: 3284 RVA: 0x00028476 File Offset: 0x00026676
		private static int n_GetSize(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<BitmapResource>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Size;
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06000CD5 RID: 3285 RVA: 0x00028485 File Offset: 0x00026685
		public virtual int Size
		{
			[Register("getSize", "()I", "GetGetSizeHandler")]
			get
			{
				return BitmapResource._members.InstanceMethods.InvokeVirtualInt32Method("getSize.()I", this, null);
			}
		}

		// Token: 0x06000CD6 RID: 3286 RVA: 0x0002849E File Offset: 0x0002669E
		private static Delegate GetGetHandler()
		{
			if (BitmapResource.cb_get == null)
			{
				BitmapResource.cb_get = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(BitmapResource.n_Get));
			}
			return BitmapResource.cb_get;
		}

		// Token: 0x06000CD7 RID: 3287 RVA: 0x000284C2 File Offset: 0x000266C2
		private static IntPtr n_Get(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<BitmapResource>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Get());
		}

		// Token: 0x06000CD8 RID: 3288 RVA: 0x000284D8 File Offset: 0x000266D8
		[Register("get", "()Landroid/graphics/Bitmap;", "GetGetHandler")]
		public virtual Bitmap Get()
		{
			return Java.Lang.Object.GetObject<Bitmap>(BitmapResource._members.InstanceMethods.InvokeVirtualObjectMethod("get.()Landroid/graphics/Bitmap;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000CD9 RID: 3289 RVA: 0x0002850A File Offset: 0x0002670A
		private static Delegate GetInitializeHandler()
		{
			if (BitmapResource.cb_initialize == null)
			{
				BitmapResource.cb_initialize = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(BitmapResource.n_Initialize));
			}
			return BitmapResource.cb_initialize;
		}

		// Token: 0x06000CDA RID: 3290 RVA: 0x0002852E File Offset: 0x0002672E
		private static void n_Initialize(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<BitmapResource>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Initialize();
		}

		// Token: 0x06000CDB RID: 3291 RVA: 0x0002853D File Offset: 0x0002673D
		[Register("initialize", "()V", "GetInitializeHandler")]
		public virtual void Initialize()
		{
			BitmapResource._members.InstanceMethods.InvokeVirtualVoidMethod("initialize.()V", this, null);
		}

		// Token: 0x06000CDC RID: 3292 RVA: 0x00028558 File Offset: 0x00026758
		[Register("obtain", "(Landroid/graphics/Bitmap;Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;)Lcom/bumptech/glide/load/resource/bitmap/BitmapResource;", "")]
		public unsafe static BitmapResource Obtain(Bitmap bitmap, IBitmapPool bitmapPool)
		{
			BitmapResource @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((bitmap == null) ? IntPtr.Zero : bitmap.Handle);
				ptr[1] = new JniArgumentValue((bitmapPool == null) ? IntPtr.Zero : ((Java.Lang.Object)bitmapPool).Handle);
				@object = Java.Lang.Object.GetObject<BitmapResource>(BitmapResource._members.StaticMethods.InvokeObjectMethod("obtain.(Landroid/graphics/Bitmap;Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;)Lcom/bumptech/glide/load/resource/bitmap/BitmapResource;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(bitmap);
				GC.KeepAlive(bitmapPool);
			}
			return @object;
		}

		// Token: 0x06000CDD RID: 3293 RVA: 0x000285F8 File Offset: 0x000267F8
		private static Delegate GetRecycleHandler()
		{
			if (BitmapResource.cb_recycle == null)
			{
				BitmapResource.cb_recycle = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(BitmapResource.n_Recycle));
			}
			return BitmapResource.cb_recycle;
		}

		// Token: 0x06000CDE RID: 3294 RVA: 0x0002861C File Offset: 0x0002681C
		private static void n_Recycle(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<BitmapResource>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Recycle();
		}

		// Token: 0x06000CDF RID: 3295 RVA: 0x0002862B File Offset: 0x0002682B
		[Register("recycle", "()V", "GetRecycleHandler")]
		public virtual void Recycle()
		{
			BitmapResource._members.InstanceMethods.InvokeVirtualVoidMethod("recycle.()V", this, null);
		}

		// Token: 0x06000CE0 RID: 3296 RVA: 0x00028644 File Offset: 0x00026844
		Java.Lang.Object IResource.Get()
		{
			return this.Get().JavaCast<Java.Lang.Object>();
		}

		// Token: 0x04000311 RID: 785
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/resource/bitmap/BitmapResource", typeof(BitmapResource));

		// Token: 0x04000312 RID: 786
		private static Delegate cb_getResourceClass;

		// Token: 0x04000313 RID: 787
		private static Delegate cb_getSize;

		// Token: 0x04000314 RID: 788
		private static Delegate cb_get;

		// Token: 0x04000315 RID: 789
		private static Delegate cb_initialize;

		// Token: 0x04000316 RID: 790
		private static Delegate cb_recycle;
	}
}
