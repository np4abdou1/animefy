using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Graphics.Drawables;
using Android.Runtime;
using Bumptech.Glide.Load.Engine;
using Bumptech.Glide.Load.Engine.BitmapRecycle;
using Bumptech.Glide.Load.Resource.Drawable;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Resource.Bitmap
{
	// Token: 0x020000FD RID: 253
	[Register("com/bumptech/glide/load/resource/bitmap/BitmapDrawableResource", DoNotGenerateAcw = true)]
	public class BitmapDrawableResource : DrawableResource, IInitializable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000CA1 RID: 3233 RVA: 0x00027AA0 File Offset: 0x00025CA0
		internal new static IntPtr class_ref
		{
			get
			{
				return BitmapDrawableResource._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000CA2 RID: 3234 RVA: 0x00027AC4 File Offset: 0x00025CC4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BitmapDrawableResource._members;
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06000CA3 RID: 3235 RVA: 0x00027ACC File Offset: 0x00025CCC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BitmapDrawableResource._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06000CA4 RID: 3236 RVA: 0x00027AF0 File Offset: 0x00025CF0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BitmapDrawableResource._members.ManagedPeerType;
			}
		}

		// Token: 0x06000CA5 RID: 3237 RVA: 0x00027AFC File Offset: 0x00025CFC
		protected BitmapDrawableResource(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000CA6 RID: 3238 RVA: 0x00027B08 File Offset: 0x00025D08
		[Register(".ctor", "(Landroid/graphics/drawable/BitmapDrawable;Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;)V", "")]
		public unsafe BitmapDrawableResource(BitmapDrawable drawable, IBitmapPool bitmapPool) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((drawable == null) ? IntPtr.Zero : drawable.Handle);
				ptr[1] = new JniArgumentValue((bitmapPool == null) ? IntPtr.Zero : ((Java.Lang.Object)bitmapPool).Handle);
				base.SetHandle(BitmapDrawableResource._members.InstanceMethods.StartCreateInstance("(Landroid/graphics/drawable/BitmapDrawable;Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				BitmapDrawableResource._members.InstanceMethods.FinishCreateInstance("(Landroid/graphics/drawable/BitmapDrawable;Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(drawable);
				GC.KeepAlive(bitmapPool);
			}
		}

		// Token: 0x06000CA7 RID: 3239 RVA: 0x00027BE4 File Offset: 0x00025DE4
		private static Delegate GetGetResourceClassHandler()
		{
			if (BitmapDrawableResource.cb_getResourceClass == null)
			{
				BitmapDrawableResource.cb_getResourceClass = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(BitmapDrawableResource.n_GetResourceClass));
			}
			return BitmapDrawableResource.cb_getResourceClass;
		}

		// Token: 0x06000CA8 RID: 3240 RVA: 0x00027C08 File Offset: 0x00025E08
		private static IntPtr n_GetResourceClass(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<BitmapDrawableResource>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ResourceClass);
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06000CA9 RID: 3241 RVA: 0x00027C1C File Offset: 0x00025E1C
		public override Class ResourceClass
		{
			[Register("getResourceClass", "()Ljava/lang/Class;", "GetGetResourceClassHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Class>(BitmapDrawableResource._members.InstanceMethods.InvokeVirtualObjectMethod("getResourceClass.()Ljava/lang/Class;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000CAA RID: 3242 RVA: 0x00027C4E File Offset: 0x00025E4E
		private static Delegate GetGetSizeHandler()
		{
			if (BitmapDrawableResource.cb_getSize == null)
			{
				BitmapDrawableResource.cb_getSize = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(BitmapDrawableResource.n_GetSize));
			}
			return BitmapDrawableResource.cb_getSize;
		}

		// Token: 0x06000CAB RID: 3243 RVA: 0x00027C72 File Offset: 0x00025E72
		private static int n_GetSize(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<BitmapDrawableResource>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Size;
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06000CAC RID: 3244 RVA: 0x00027C81 File Offset: 0x00025E81
		public override int Size
		{
			[Register("getSize", "()I", "GetGetSizeHandler")]
			get
			{
				return BitmapDrawableResource._members.InstanceMethods.InvokeVirtualInt32Method("getSize.()I", this, null);
			}
		}

		// Token: 0x06000CAD RID: 3245 RVA: 0x00027C9A File Offset: 0x00025E9A
		private static Delegate GetRecycleHandler()
		{
			if (BitmapDrawableResource.cb_recycle == null)
			{
				BitmapDrawableResource.cb_recycle = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(BitmapDrawableResource.n_Recycle));
			}
			return BitmapDrawableResource.cb_recycle;
		}

		// Token: 0x06000CAE RID: 3246 RVA: 0x00027CBE File Offset: 0x00025EBE
		private static void n_Recycle(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<BitmapDrawableResource>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Recycle();
		}

		// Token: 0x06000CAF RID: 3247 RVA: 0x00027CCD File Offset: 0x00025ECD
		[Register("recycle", "()V", "GetRecycleHandler")]
		public override void Recycle()
		{
			BitmapDrawableResource._members.InstanceMethods.InvokeVirtualVoidMethod("recycle.()V", this, null);
		}

		// Token: 0x04000309 RID: 777
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/resource/bitmap/BitmapDrawableResource", typeof(BitmapDrawableResource));

		// Token: 0x0400030A RID: 778
		private static Delegate cb_getResourceClass;

		// Token: 0x0400030B RID: 779
		private static Delegate cb_getSize;

		// Token: 0x0400030C RID: 780
		private static Delegate cb_recycle;
	}
}
