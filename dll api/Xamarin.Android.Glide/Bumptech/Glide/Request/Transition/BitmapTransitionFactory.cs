using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Graphics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Request.Transition
{
	// Token: 0x0200009A RID: 154
	[Register("com/bumptech/glide/request/transition/BitmapTransitionFactory", DoNotGenerateAcw = true)]
	public class BitmapTransitionFactory : BitmapContainerTransitionFactory
	{
		// Token: 0x0600082D RID: 2093 RVA: 0x000196F7 File Offset: 0x000178F7
		protected override Bitmap GetBitmap(Java.Lang.Object current)
		{
			return this.GetBitmap((Bitmap)current);
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x0600082E RID: 2094 RVA: 0x00019708 File Offset: 0x00017908
		internal new static IntPtr class_ref
		{
			get
			{
				return BitmapTransitionFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x0600082F RID: 2095 RVA: 0x0001972C File Offset: 0x0001792C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BitmapTransitionFactory._members;
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06000830 RID: 2096 RVA: 0x00019734 File Offset: 0x00017934
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BitmapTransitionFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000831 RID: 2097 RVA: 0x00019758 File Offset: 0x00017958
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BitmapTransitionFactory._members.ManagedPeerType;
			}
		}

		// Token: 0x06000832 RID: 2098 RVA: 0x00019764 File Offset: 0x00017964
		protected BitmapTransitionFactory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x00019770 File Offset: 0x00017970
		[Register(".ctor", "(Lcom/bumptech/glide/request/transition/TransitionFactory;)V", "")]
		public unsafe BitmapTransitionFactory(ITransitionFactory realFactory) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((realFactory == null) ? IntPtr.Zero : ((Java.Lang.Object)realFactory).Handle);
				base.SetHandle(BitmapTransitionFactory._members.InstanceMethods.StartCreateInstance("(Lcom/bumptech/glide/request/transition/TransitionFactory;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				BitmapTransitionFactory._members.InstanceMethods.FinishCreateInstance("(Lcom/bumptech/glide/request/transition/TransitionFactory;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(realFactory);
			}
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x00019824 File Offset: 0x00017A24
		private static Delegate GetGetBitmap_Landroid_graphics_Bitmap_Handler()
		{
			if (BitmapTransitionFactory.cb_getBitmap_Landroid_graphics_Bitmap_ == null)
			{
				BitmapTransitionFactory.cb_getBitmap_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(BitmapTransitionFactory.n_GetBitmap_Landroid_graphics_Bitmap_));
			}
			return BitmapTransitionFactory.cb_getBitmap_Landroid_graphics_Bitmap_;
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x00019848 File Offset: 0x00017A48
		private static IntPtr n_GetBitmap_Landroid_graphics_Bitmap_(IntPtr jnienv, IntPtr native__this, IntPtr native_current)
		{
			BitmapTransitionFactory @object = Java.Lang.Object.GetObject<BitmapTransitionFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bitmap object2 = Java.Lang.Object.GetObject<Bitmap>(native_current, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetBitmap(object2));
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x00019870 File Offset: 0x00017A70
		[Register("getBitmap", "(Landroid/graphics/Bitmap;)Landroid/graphics/Bitmap;", "GetGetBitmap_Landroid_graphics_Bitmap_Handler")]
		protected unsafe virtual Bitmap GetBitmap(Bitmap current)
		{
			Bitmap @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((current == null) ? IntPtr.Zero : current.Handle);
				@object = Java.Lang.Object.GetObject<Bitmap>(BitmapTransitionFactory._members.InstanceMethods.InvokeVirtualObjectMethod("getBitmap.(Landroid/graphics/Bitmap;)Landroid/graphics/Bitmap;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(current);
			}
			return @object;
		}

		// Token: 0x04000206 RID: 518
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/request/transition/BitmapTransitionFactory", typeof(BitmapTransitionFactory));

		// Token: 0x04000207 RID: 519
		private static Delegate cb_getBitmap_Landroid_graphics_Bitmap_;
	}
}
