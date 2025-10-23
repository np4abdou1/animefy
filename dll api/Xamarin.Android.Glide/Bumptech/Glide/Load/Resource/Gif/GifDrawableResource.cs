using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Bumptech.Glide.Load.Engine;
using Bumptech.Glide.Load.Resource.Drawable;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Resource.Gif
{
	// Token: 0x02000121 RID: 289
	[Register("com/bumptech/glide/load/resource/gif/GifDrawableResource", DoNotGenerateAcw = true)]
	public class GifDrawableResource : DrawableResource, IInitializable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06000EC1 RID: 3777 RVA: 0x0002F6D4 File Offset: 0x0002D8D4
		internal new static IntPtr class_ref
		{
			get
			{
				return GifDrawableResource._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06000EC2 RID: 3778 RVA: 0x0002F6F8 File Offset: 0x0002D8F8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return GifDrawableResource._members;
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06000EC3 RID: 3779 RVA: 0x0002F700 File Offset: 0x0002D900
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return GifDrawableResource._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06000EC4 RID: 3780 RVA: 0x0002F724 File Offset: 0x0002D924
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return GifDrawableResource._members.ManagedPeerType;
			}
		}

		// Token: 0x06000EC5 RID: 3781 RVA: 0x0002F730 File Offset: 0x0002D930
		protected GifDrawableResource(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000EC6 RID: 3782 RVA: 0x0002F73C File Offset: 0x0002D93C
		[Register(".ctor", "(Lcom/bumptech/glide/load/resource/gif/GifDrawable;)V", "")]
		public unsafe GifDrawableResource(GifDrawable drawable) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((drawable == null) ? IntPtr.Zero : drawable.Handle);
				base.SetHandle(GifDrawableResource._members.InstanceMethods.StartCreateInstance("(Lcom/bumptech/glide/load/resource/gif/GifDrawable;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				GifDrawableResource._members.InstanceMethods.FinishCreateInstance("(Lcom/bumptech/glide/load/resource/gif/GifDrawable;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(drawable);
			}
		}

		// Token: 0x06000EC7 RID: 3783 RVA: 0x0002F7EC File Offset: 0x0002D9EC
		private static Delegate GetGetResourceClassHandler()
		{
			if (GifDrawableResource.cb_getResourceClass == null)
			{
				GifDrawableResource.cb_getResourceClass = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(GifDrawableResource.n_GetResourceClass));
			}
			return GifDrawableResource.cb_getResourceClass;
		}

		// Token: 0x06000EC8 RID: 3784 RVA: 0x0002F810 File Offset: 0x0002DA10
		private static IntPtr n_GetResourceClass(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<GifDrawableResource>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ResourceClass);
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06000EC9 RID: 3785 RVA: 0x0002F824 File Offset: 0x0002DA24
		public override Class ResourceClass
		{
			[Register("getResourceClass", "()Ljava/lang/Class;", "GetGetResourceClassHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Class>(GifDrawableResource._members.InstanceMethods.InvokeVirtualObjectMethod("getResourceClass.()Ljava/lang/Class;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000ECA RID: 3786 RVA: 0x0002F856 File Offset: 0x0002DA56
		private static Delegate GetGetSizeHandler()
		{
			if (GifDrawableResource.cb_getSize == null)
			{
				GifDrawableResource.cb_getSize = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(GifDrawableResource.n_GetSize));
			}
			return GifDrawableResource.cb_getSize;
		}

		// Token: 0x06000ECB RID: 3787 RVA: 0x0002F87A File Offset: 0x0002DA7A
		private static int n_GetSize(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<GifDrawableResource>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Size;
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06000ECC RID: 3788 RVA: 0x0002F889 File Offset: 0x0002DA89
		public override int Size
		{
			[Register("getSize", "()I", "GetGetSizeHandler")]
			get
			{
				return GifDrawableResource._members.InstanceMethods.InvokeVirtualInt32Method("getSize.()I", this, null);
			}
		}

		// Token: 0x06000ECD RID: 3789 RVA: 0x0002F8A2 File Offset: 0x0002DAA2
		private static Delegate GetRecycleHandler()
		{
			if (GifDrawableResource.cb_recycle == null)
			{
				GifDrawableResource.cb_recycle = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(GifDrawableResource.n_Recycle));
			}
			return GifDrawableResource.cb_recycle;
		}

		// Token: 0x06000ECE RID: 3790 RVA: 0x0002F8C6 File Offset: 0x0002DAC6
		private static void n_Recycle(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<GifDrawableResource>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Recycle();
		}

		// Token: 0x06000ECF RID: 3791 RVA: 0x0002F8D5 File Offset: 0x0002DAD5
		[Register("recycle", "()V", "GetRecycleHandler")]
		public override void Recycle()
		{
			GifDrawableResource._members.InstanceMethods.InvokeVirtualVoidMethod("recycle.()V", this, null);
		}

		// Token: 0x0400036E RID: 878
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/resource/gif/GifDrawableResource", typeof(GifDrawableResource));

		// Token: 0x0400036F RID: 879
		private static Delegate cb_getResourceClass;

		// Token: 0x04000370 RID: 880
		private static Delegate cb_getSize;

		// Token: 0x04000371 RID: 881
		private static Delegate cb_recycle;
	}
}
