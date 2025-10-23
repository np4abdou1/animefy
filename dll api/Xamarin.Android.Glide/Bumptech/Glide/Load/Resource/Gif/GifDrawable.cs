using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Runtime;
using AndroidX.VectorDrawable.Graphics.Drawable;
using Bumptech.Glide.GifDecoder;
using Bumptech.Glide.Load.Engine.BitmapRecycle;
using Java.Interop;
using Java.Lang;
using Java.Nio;

namespace Bumptech.Glide.Load.Resource.Gif
{
	// Token: 0x02000120 RID: 288
	[Register("com/bumptech/glide/load/resource/gif/GifDrawable", DoNotGenerateAcw = true)]
	public class GifDrawable : Drawable, IAnimatable, IJavaObject, IDisposable, IJavaPeerable, IAnimatable2Compat
	{
		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06000E7A RID: 3706 RVA: 0x0002EA38 File Offset: 0x0002CC38
		internal static IntPtr class_ref
		{
			get
			{
				return GifDrawable._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06000E7B RID: 3707 RVA: 0x0002EA5C File Offset: 0x0002CC5C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return GifDrawable._members;
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06000E7C RID: 3708 RVA: 0x0002EA64 File Offset: 0x0002CC64
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return GifDrawable._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06000E7D RID: 3709 RVA: 0x0002EA88 File Offset: 0x0002CC88
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return GifDrawable._members.ManagedPeerType;
			}
		}

		// Token: 0x06000E7E RID: 3710 RVA: 0x0002EA94 File Offset: 0x0002CC94
		protected GifDrawable(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000E7F RID: 3711 RVA: 0x0002EAA0 File Offset: 0x0002CCA0
		[Register(".ctor", "(Landroid/content/Context;Lcom/bumptech/glide/gifdecoder/GifDecoder;Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;Lcom/bumptech/glide/load/Transformation;IILandroid/graphics/Bitmap;)V", "")]
		[Obsolete("deprecated")]
		public unsafe GifDrawable(Context context, IGifDecoder gifDecoder, IBitmapPool bitmapPool, ITransformation frameTransformation, int targetFrameWidth, int targetFrameHeight, Bitmap firstFrame) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((gifDecoder == null) ? IntPtr.Zero : ((Java.Lang.Object)gifDecoder).Handle);
				ptr[2] = new JniArgumentValue((bitmapPool == null) ? IntPtr.Zero : ((Java.Lang.Object)bitmapPool).Handle);
				ptr[3] = new JniArgumentValue((frameTransformation == null) ? IntPtr.Zero : ((Java.Lang.Object)frameTransformation).Handle);
				ptr[4] = new JniArgumentValue(targetFrameWidth);
				ptr[5] = new JniArgumentValue(targetFrameHeight);
				ptr[6] = new JniArgumentValue((firstFrame == null) ? IntPtr.Zero : firstFrame.Handle);
				base.SetHandle(GifDrawable._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Lcom/bumptech/glide/gifdecoder/GifDecoder;Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;Lcom/bumptech/glide/load/Transformation;IILandroid/graphics/Bitmap;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				GifDrawable._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Lcom/bumptech/glide/gifdecoder/GifDecoder;Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;Lcom/bumptech/glide/load/Transformation;IILandroid/graphics/Bitmap;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(gifDecoder);
				GC.KeepAlive(bitmapPool);
				GC.KeepAlive(frameTransformation);
				GC.KeepAlive(firstFrame);
			}
		}

		// Token: 0x06000E80 RID: 3712 RVA: 0x0002EC48 File Offset: 0x0002CE48
		[Register(".ctor", "(Landroid/content/Context;Lcom/bumptech/glide/gifdecoder/GifDecoder;Lcom/bumptech/glide/load/Transformation;IILandroid/graphics/Bitmap;)V", "")]
		public unsafe GifDrawable(Context context, IGifDecoder gifDecoder, ITransformation frameTransformation, int targetFrameWidth, int targetFrameHeight, Bitmap firstFrame) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((gifDecoder == null) ? IntPtr.Zero : ((Java.Lang.Object)gifDecoder).Handle);
				ptr[2] = new JniArgumentValue((frameTransformation == null) ? IntPtr.Zero : ((Java.Lang.Object)frameTransformation).Handle);
				ptr[3] = new JniArgumentValue(targetFrameWidth);
				ptr[4] = new JniArgumentValue(targetFrameHeight);
				ptr[5] = new JniArgumentValue((firstFrame == null) ? IntPtr.Zero : firstFrame.Handle);
				base.SetHandle(GifDrawable._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Lcom/bumptech/glide/gifdecoder/GifDecoder;Lcom/bumptech/glide/load/Transformation;IILandroid/graphics/Bitmap;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				GifDrawable._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Lcom/bumptech/glide/gifdecoder/GifDecoder;Lcom/bumptech/glide/load/Transformation;IILandroid/graphics/Bitmap;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(gifDecoder);
				GC.KeepAlive(frameTransformation);
				GC.KeepAlive(firstFrame);
			}
		}

		// Token: 0x06000E81 RID: 3713 RVA: 0x0002EDBC File Offset: 0x0002CFBC
		private static Delegate GetGetBufferHandler()
		{
			if (GifDrawable.cb_getBuffer == null)
			{
				GifDrawable.cb_getBuffer = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(GifDrawable.n_GetBuffer));
			}
			return GifDrawable.cb_getBuffer;
		}

		// Token: 0x06000E82 RID: 3714 RVA: 0x0002EDE0 File Offset: 0x0002CFE0
		private static IntPtr n_GetBuffer(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<GifDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Buffer);
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06000E83 RID: 3715 RVA: 0x0002EDF4 File Offset: 0x0002CFF4
		public virtual ByteBuffer Buffer
		{
			[Register("getBuffer", "()Ljava/nio/ByteBuffer;", "GetGetBufferHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ByteBuffer>(GifDrawable._members.InstanceMethods.InvokeVirtualObjectMethod("getBuffer.()Ljava/nio/ByteBuffer;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000E84 RID: 3716 RVA: 0x0002EE26 File Offset: 0x0002D026
		private static Delegate GetGetFirstFrameHandler()
		{
			if (GifDrawable.cb_getFirstFrame == null)
			{
				GifDrawable.cb_getFirstFrame = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(GifDrawable.n_GetFirstFrame));
			}
			return GifDrawable.cb_getFirstFrame;
		}

		// Token: 0x06000E85 RID: 3717 RVA: 0x0002EE4A File Offset: 0x0002D04A
		private static IntPtr n_GetFirstFrame(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<GifDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).FirstFrame);
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06000E86 RID: 3718 RVA: 0x0002EE60 File Offset: 0x0002D060
		public virtual Bitmap FirstFrame
		{
			[Register("getFirstFrame", "()Landroid/graphics/Bitmap;", "GetGetFirstFrameHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Bitmap>(GifDrawable._members.InstanceMethods.InvokeVirtualObjectMethod("getFirstFrame.()Landroid/graphics/Bitmap;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000E87 RID: 3719 RVA: 0x0002EE92 File Offset: 0x0002D092
		private static Delegate GetGetFrameCountHandler()
		{
			if (GifDrawable.cb_getFrameCount == null)
			{
				GifDrawable.cb_getFrameCount = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(GifDrawable.n_GetFrameCount));
			}
			return GifDrawable.cb_getFrameCount;
		}

		// Token: 0x06000E88 RID: 3720 RVA: 0x0002EEB6 File Offset: 0x0002D0B6
		private static int n_GetFrameCount(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<GifDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).FrameCount;
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06000E89 RID: 3721 RVA: 0x0002EEC5 File Offset: 0x0002D0C5
		public virtual int FrameCount
		{
			[Register("getFrameCount", "()I", "GetGetFrameCountHandler")]
			get
			{
				return GifDrawable._members.InstanceMethods.InvokeVirtualInt32Method("getFrameCount.()I", this, null);
			}
		}

		// Token: 0x06000E8A RID: 3722 RVA: 0x0002EEDE File Offset: 0x0002D0DE
		private static Delegate GetGetFrameIndexHandler()
		{
			if (GifDrawable.cb_getFrameIndex == null)
			{
				GifDrawable.cb_getFrameIndex = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(GifDrawable.n_GetFrameIndex));
			}
			return GifDrawable.cb_getFrameIndex;
		}

		// Token: 0x06000E8B RID: 3723 RVA: 0x0002EF02 File Offset: 0x0002D102
		private static int n_GetFrameIndex(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<GifDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).FrameIndex;
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06000E8C RID: 3724 RVA: 0x0002EF11 File Offset: 0x0002D111
		public virtual int FrameIndex
		{
			[Register("getFrameIndex", "()I", "GetGetFrameIndexHandler")]
			get
			{
				return GifDrawable._members.InstanceMethods.InvokeVirtualInt32Method("getFrameIndex.()I", this, null);
			}
		}

		// Token: 0x06000E8D RID: 3725 RVA: 0x0002EF2A File Offset: 0x0002D12A
		private static Delegate GetGetFrameTransformationHandler()
		{
			if (GifDrawable.cb_getFrameTransformation == null)
			{
				GifDrawable.cb_getFrameTransformation = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(GifDrawable.n_GetFrameTransformation));
			}
			return GifDrawable.cb_getFrameTransformation;
		}

		// Token: 0x06000E8E RID: 3726 RVA: 0x0002EF4E File Offset: 0x0002D14E
		private static IntPtr n_GetFrameTransformation(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<GifDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).FrameTransformation);
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06000E8F RID: 3727 RVA: 0x0002EF64 File Offset: 0x0002D164
		public virtual ITransformation FrameTransformation
		{
			[Register("getFrameTransformation", "()Lcom/bumptech/glide/load/Transformation;", "GetGetFrameTransformationHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ITransformation>(GifDrawable._members.InstanceMethods.InvokeVirtualObjectMethod("getFrameTransformation.()Lcom/bumptech/glide/load/Transformation;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000E90 RID: 3728 RVA: 0x0002EF96 File Offset: 0x0002D196
		private static Delegate GetIsRunningHandler()
		{
			if (GifDrawable.cb_isRunning == null)
			{
				GifDrawable.cb_isRunning = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(GifDrawable.n_IsRunning));
			}
			return GifDrawable.cb_isRunning;
		}

		// Token: 0x06000E91 RID: 3729 RVA: 0x0002EFBA File Offset: 0x0002D1BA
		private static bool n_IsRunning(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<GifDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsRunning;
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06000E92 RID: 3730 RVA: 0x0002EFC9 File Offset: 0x0002D1C9
		public virtual bool IsRunning
		{
			[Register("isRunning", "()Z", "GetIsRunningHandler")]
			get
			{
				return GifDrawable._members.InstanceMethods.InvokeVirtualBooleanMethod("isRunning.()Z", this, null);
			}
		}

		// Token: 0x06000E93 RID: 3731 RVA: 0x0002EFE2 File Offset: 0x0002D1E2
		private static Delegate GetGetOpacityHandler()
		{
			if (GifDrawable.cb_getOpacity == null)
			{
				GifDrawable.cb_getOpacity = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(GifDrawable.n_GetOpacity));
			}
			return GifDrawable.cb_getOpacity;
		}

		// Token: 0x06000E94 RID: 3732 RVA: 0x0002F006 File Offset: 0x0002D206
		private static int n_GetOpacity(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<GifDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Opacity;
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06000E95 RID: 3733 RVA: 0x0002F015 File Offset: 0x0002D215
		public override int Opacity
		{
			[Register("getOpacity", "()I", "GetGetOpacityHandler")]
			get
			{
				return GifDrawable._members.InstanceMethods.InvokeVirtualInt32Method("getOpacity.()I", this, null);
			}
		}

		// Token: 0x06000E96 RID: 3734 RVA: 0x0002F02E File Offset: 0x0002D22E
		private static Delegate GetGetSizeHandler()
		{
			if (GifDrawable.cb_getSize == null)
			{
				GifDrawable.cb_getSize = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(GifDrawable.n_GetSize));
			}
			return GifDrawable.cb_getSize;
		}

		// Token: 0x06000E97 RID: 3735 RVA: 0x0002F052 File Offset: 0x0002D252
		private static int n_GetSize(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<GifDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Size;
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06000E98 RID: 3736 RVA: 0x0002F061 File Offset: 0x0002D261
		public virtual int Size
		{
			[Register("getSize", "()I", "GetGetSizeHandler")]
			get
			{
				return GifDrawable._members.InstanceMethods.InvokeVirtualInt32Method("getSize.()I", this, null);
			}
		}

		// Token: 0x06000E99 RID: 3737 RVA: 0x0002F07A File Offset: 0x0002D27A
		private static Delegate GetClearAnimationCallbacksHandler()
		{
			if (GifDrawable.cb_clearAnimationCallbacks == null)
			{
				GifDrawable.cb_clearAnimationCallbacks = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(GifDrawable.n_ClearAnimationCallbacks));
			}
			return GifDrawable.cb_clearAnimationCallbacks;
		}

		// Token: 0x06000E9A RID: 3738 RVA: 0x0002F09E File Offset: 0x0002D29E
		private static void n_ClearAnimationCallbacks(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<GifDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ClearAnimationCallbacks();
		}

		// Token: 0x06000E9B RID: 3739 RVA: 0x0002F0AD File Offset: 0x0002D2AD
		[Register("clearAnimationCallbacks", "()V", "GetClearAnimationCallbacksHandler")]
		public virtual void ClearAnimationCallbacks()
		{
			GifDrawable._members.InstanceMethods.InvokeVirtualVoidMethod("clearAnimationCallbacks.()V", this, null);
		}

		// Token: 0x06000E9C RID: 3740 RVA: 0x0002F0C6 File Offset: 0x0002D2C6
		private static Delegate GetDraw_Landroid_graphics_Canvas_Handler()
		{
			if (GifDrawable.cb_draw_Landroid_graphics_Canvas_ == null)
			{
				GifDrawable.cb_draw_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(GifDrawable.n_Draw_Landroid_graphics_Canvas_));
			}
			return GifDrawable.cb_draw_Landroid_graphics_Canvas_;
		}

		// Token: 0x06000E9D RID: 3741 RVA: 0x0002F0EC File Offset: 0x0002D2EC
		private static void n_Draw_Landroid_graphics_Canvas_(IntPtr jnienv, IntPtr native__this, IntPtr native_canvas)
		{
			Drawable @object = Java.Lang.Object.GetObject<GifDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Canvas object2 = Java.Lang.Object.GetObject<Canvas>(native_canvas, JniHandleOwnership.DoNotTransfer);
			@object.Draw(object2);
		}

		// Token: 0x06000E9E RID: 3742 RVA: 0x0002F110 File Offset: 0x0002D310
		[Register("draw", "(Landroid/graphics/Canvas;)V", "GetDraw_Landroid_graphics_Canvas_Handler")]
		public unsafe override void Draw(Canvas canvas)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((canvas == null) ? IntPtr.Zero : canvas.Handle);
				GifDrawable._members.InstanceMethods.InvokeVirtualVoidMethod("draw.(Landroid/graphics/Canvas;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(canvas);
			}
		}

		// Token: 0x06000E9F RID: 3743 RVA: 0x0002F174 File Offset: 0x0002D374
		private static Delegate GetOnFrameReadyHandler()
		{
			if (GifDrawable.cb_onFrameReady == null)
			{
				GifDrawable.cb_onFrameReady = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(GifDrawable.n_OnFrameReady));
			}
			return GifDrawable.cb_onFrameReady;
		}

		// Token: 0x06000EA0 RID: 3744 RVA: 0x0002F198 File Offset: 0x0002D398
		private static void n_OnFrameReady(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<GifDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnFrameReady();
		}

		// Token: 0x06000EA1 RID: 3745 RVA: 0x0002F1A7 File Offset: 0x0002D3A7
		[Register("onFrameReady", "()V", "GetOnFrameReadyHandler")]
		public virtual void OnFrameReady()
		{
			GifDrawable._members.InstanceMethods.InvokeVirtualVoidMethod("onFrameReady.()V", this, null);
		}

		// Token: 0x06000EA2 RID: 3746 RVA: 0x0002F1C0 File Offset: 0x0002D3C0
		private static Delegate GetRecycleHandler()
		{
			if (GifDrawable.cb_recycle == null)
			{
				GifDrawable.cb_recycle = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(GifDrawable.n_Recycle));
			}
			return GifDrawable.cb_recycle;
		}

		// Token: 0x06000EA3 RID: 3747 RVA: 0x0002F1E4 File Offset: 0x0002D3E4
		private static void n_Recycle(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<GifDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Recycle();
		}

		// Token: 0x06000EA4 RID: 3748 RVA: 0x0002F1F3 File Offset: 0x0002D3F3
		[Register("recycle", "()V", "GetRecycleHandler")]
		public virtual void Recycle()
		{
			GifDrawable._members.InstanceMethods.InvokeVirtualVoidMethod("recycle.()V", this, null);
		}

		// Token: 0x06000EA5 RID: 3749 RVA: 0x0002F20C File Offset: 0x0002D40C
		private static Delegate GetRegisterAnimationCallback_Landroidx_vectordrawable_graphics_drawable_Animatable2Compat_AnimationCallback_Handler()
		{
			if (GifDrawable.cb_registerAnimationCallback_Landroidx_vectordrawable_graphics_drawable_Animatable2Compat_AnimationCallback_ == null)
			{
				GifDrawable.cb_registerAnimationCallback_Landroidx_vectordrawable_graphics_drawable_Animatable2Compat_AnimationCallback_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(GifDrawable.n_RegisterAnimationCallback_Landroidx_vectordrawable_graphics_drawable_Animatable2Compat_AnimationCallback_));
			}
			return GifDrawable.cb_registerAnimationCallback_Landroidx_vectordrawable_graphics_drawable_Animatable2Compat_AnimationCallback_;
		}

		// Token: 0x06000EA6 RID: 3750 RVA: 0x0002F230 File Offset: 0x0002D430
		private static void n_RegisterAnimationCallback_Landroidx_vectordrawable_graphics_drawable_Animatable2Compat_AnimationCallback_(IntPtr jnienv, IntPtr native__this, IntPtr native_animationCallback)
		{
			GifDrawable @object = Java.Lang.Object.GetObject<GifDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Animatable2CompatAnimationCallback object2 = Java.Lang.Object.GetObject<Animatable2CompatAnimationCallback>(native_animationCallback, JniHandleOwnership.DoNotTransfer);
			@object.RegisterAnimationCallback(object2);
		}

		// Token: 0x06000EA7 RID: 3751 RVA: 0x0002F254 File Offset: 0x0002D454
		[Register("registerAnimationCallback", "(Landroidx/vectordrawable/graphics/drawable/Animatable2Compat$AnimationCallback;)V", "GetRegisterAnimationCallback_Landroidx_vectordrawable_graphics_drawable_Animatable2Compat_AnimationCallback_Handler")]
		public unsafe virtual void RegisterAnimationCallback(Animatable2CompatAnimationCallback animationCallback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((animationCallback == null) ? IntPtr.Zero : animationCallback.Handle);
				GifDrawable._members.InstanceMethods.InvokeVirtualVoidMethod("registerAnimationCallback.(Landroidx/vectordrawable/graphics/drawable/Animatable2Compat$AnimationCallback;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(animationCallback);
			}
		}

		// Token: 0x06000EA8 RID: 3752 RVA: 0x0002F2B8 File Offset: 0x0002D4B8
		private static Delegate GetSetAlpha_IHandler()
		{
			if (GifDrawable.cb_setAlpha_I == null)
			{
				GifDrawable.cb_setAlpha_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(GifDrawable.n_SetAlpha_I));
			}
			return GifDrawable.cb_setAlpha_I;
		}

		// Token: 0x06000EA9 RID: 3753 RVA: 0x0002F2DC File Offset: 0x0002D4DC
		private static void n_SetAlpha_I(IntPtr jnienv, IntPtr native__this, int i)
		{
			Java.Lang.Object.GetObject<GifDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetAlpha(i);
		}

		// Token: 0x06000EAA RID: 3754 RVA: 0x0002F2EC File Offset: 0x0002D4EC
		[Register("setAlpha", "(I)V", "GetSetAlpha_IHandler")]
		public unsafe override void SetAlpha(int i)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(i);
			GifDrawable._members.InstanceMethods.InvokeVirtualVoidMethod("setAlpha.(I)V", this, ptr);
		}

		// Token: 0x06000EAB RID: 3755 RVA: 0x0002F327 File Offset: 0x0002D527
		private static Delegate GetSetColorFilter_Landroid_graphics_ColorFilter_Handler()
		{
			if (GifDrawable.cb_setColorFilter_Landroid_graphics_ColorFilter_ == null)
			{
				GifDrawable.cb_setColorFilter_Landroid_graphics_ColorFilter_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(GifDrawable.n_SetColorFilter_Landroid_graphics_ColorFilter_));
			}
			return GifDrawable.cb_setColorFilter_Landroid_graphics_ColorFilter_;
		}

		// Token: 0x06000EAC RID: 3756 RVA: 0x0002F34C File Offset: 0x0002D54C
		private static void n_SetColorFilter_Landroid_graphics_ColorFilter_(IntPtr jnienv, IntPtr native__this, IntPtr native_colorFilter)
		{
			Drawable @object = Java.Lang.Object.GetObject<GifDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ColorFilter object2 = Java.Lang.Object.GetObject<ColorFilter>(native_colorFilter, JniHandleOwnership.DoNotTransfer);
			@object.SetColorFilter(object2);
		}

		// Token: 0x06000EAD RID: 3757 RVA: 0x0002F370 File Offset: 0x0002D570
		[Register("setColorFilter", "(Landroid/graphics/ColorFilter;)V", "GetSetColorFilter_Landroid_graphics_ColorFilter_Handler")]
		public unsafe override void SetColorFilter(ColorFilter colorFilter)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((colorFilter == null) ? IntPtr.Zero : colorFilter.Handle);
				GifDrawable._members.InstanceMethods.InvokeVirtualVoidMethod("setColorFilter.(Landroid/graphics/ColorFilter;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(colorFilter);
			}
		}

		// Token: 0x06000EAE RID: 3758 RVA: 0x0002F3D4 File Offset: 0x0002D5D4
		private static Delegate GetSetFrameTransformation_Lcom_bumptech_glide_load_Transformation_Landroid_graphics_Bitmap_Handler()
		{
			if (GifDrawable.cb_setFrameTransformation_Lcom_bumptech_glide_load_Transformation_Landroid_graphics_Bitmap_ == null)
			{
				GifDrawable.cb_setFrameTransformation_Lcom_bumptech_glide_load_Transformation_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(GifDrawable.n_SetFrameTransformation_Lcom_bumptech_glide_load_Transformation_Landroid_graphics_Bitmap_));
			}
			return GifDrawable.cb_setFrameTransformation_Lcom_bumptech_glide_load_Transformation_Landroid_graphics_Bitmap_;
		}

		// Token: 0x06000EAF RID: 3759 RVA: 0x0002F3F8 File Offset: 0x0002D5F8
		private static void n_SetFrameTransformation_Lcom_bumptech_glide_load_Transformation_Landroid_graphics_Bitmap_(IntPtr jnienv, IntPtr native__this, IntPtr native_frameTransformation, IntPtr native_firstFrame)
		{
			GifDrawable @object = Java.Lang.Object.GetObject<GifDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ITransformation object2 = Java.Lang.Object.GetObject<ITransformation>(native_frameTransformation, JniHandleOwnership.DoNotTransfer);
			Bitmap object3 = Java.Lang.Object.GetObject<Bitmap>(native_firstFrame, JniHandleOwnership.DoNotTransfer);
			@object.SetFrameTransformation(object2, object3);
		}

		// Token: 0x06000EB0 RID: 3760 RVA: 0x0002F424 File Offset: 0x0002D624
		[Register("setFrameTransformation", "(Lcom/bumptech/glide/load/Transformation;Landroid/graphics/Bitmap;)V", "GetSetFrameTransformation_Lcom_bumptech_glide_load_Transformation_Landroid_graphics_Bitmap_Handler")]
		public unsafe virtual void SetFrameTransformation(ITransformation frameTransformation, Bitmap firstFrame)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((frameTransformation == null) ? IntPtr.Zero : ((Java.Lang.Object)frameTransformation).Handle);
				ptr[1] = new JniArgumentValue((firstFrame == null) ? IntPtr.Zero : firstFrame.Handle);
				GifDrawable._members.InstanceMethods.InvokeVirtualVoidMethod("setFrameTransformation.(Lcom/bumptech/glide/load/Transformation;Landroid/graphics/Bitmap;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(frameTransformation);
				GC.KeepAlive(firstFrame);
			}
		}

		// Token: 0x06000EB1 RID: 3761 RVA: 0x0002F4B4 File Offset: 0x0002D6B4
		private static Delegate GetSetLoopCount_IHandler()
		{
			if (GifDrawable.cb_setLoopCount_I == null)
			{
				GifDrawable.cb_setLoopCount_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(GifDrawable.n_SetLoopCount_I));
			}
			return GifDrawable.cb_setLoopCount_I;
		}

		// Token: 0x06000EB2 RID: 3762 RVA: 0x0002F4D8 File Offset: 0x0002D6D8
		private static void n_SetLoopCount_I(IntPtr jnienv, IntPtr native__this, int loopCount)
		{
			Java.Lang.Object.GetObject<GifDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetLoopCount(loopCount);
		}

		// Token: 0x06000EB3 RID: 3763 RVA: 0x0002F4E8 File Offset: 0x0002D6E8
		[Register("setLoopCount", "(I)V", "GetSetLoopCount_IHandler")]
		public unsafe virtual void SetLoopCount(int loopCount)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(loopCount);
			GifDrawable._members.InstanceMethods.InvokeVirtualVoidMethod("setLoopCount.(I)V", this, ptr);
		}

		// Token: 0x06000EB4 RID: 3764 RVA: 0x0002F523 File Offset: 0x0002D723
		private static Delegate GetStartHandler()
		{
			if (GifDrawable.cb_start == null)
			{
				GifDrawable.cb_start = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(GifDrawable.n_Start));
			}
			return GifDrawable.cb_start;
		}

		// Token: 0x06000EB5 RID: 3765 RVA: 0x0002F547 File Offset: 0x0002D747
		private static void n_Start(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<GifDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Start();
		}

		// Token: 0x06000EB6 RID: 3766 RVA: 0x0002F556 File Offset: 0x0002D756
		[Register("start", "()V", "GetStartHandler")]
		public virtual void Start()
		{
			GifDrawable._members.InstanceMethods.InvokeVirtualVoidMethod("start.()V", this, null);
		}

		// Token: 0x06000EB7 RID: 3767 RVA: 0x0002F56F File Offset: 0x0002D76F
		private static Delegate GetStartFromFirstFrameHandler()
		{
			if (GifDrawable.cb_startFromFirstFrame == null)
			{
				GifDrawable.cb_startFromFirstFrame = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(GifDrawable.n_StartFromFirstFrame));
			}
			return GifDrawable.cb_startFromFirstFrame;
		}

		// Token: 0x06000EB8 RID: 3768 RVA: 0x0002F593 File Offset: 0x0002D793
		private static void n_StartFromFirstFrame(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<GifDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).StartFromFirstFrame();
		}

		// Token: 0x06000EB9 RID: 3769 RVA: 0x0002F5A2 File Offset: 0x0002D7A2
		[Register("startFromFirstFrame", "()V", "GetStartFromFirstFrameHandler")]
		public virtual void StartFromFirstFrame()
		{
			GifDrawable._members.InstanceMethods.InvokeVirtualVoidMethod("startFromFirstFrame.()V", this, null);
		}

		// Token: 0x06000EBA RID: 3770 RVA: 0x0002F5BB File Offset: 0x0002D7BB
		private static Delegate GetStopHandler()
		{
			if (GifDrawable.cb_stop == null)
			{
				GifDrawable.cb_stop = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(GifDrawable.n_Stop));
			}
			return GifDrawable.cb_stop;
		}

		// Token: 0x06000EBB RID: 3771 RVA: 0x0002F5DF File Offset: 0x0002D7DF
		private static void n_Stop(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<GifDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Stop();
		}

		// Token: 0x06000EBC RID: 3772 RVA: 0x0002F5EE File Offset: 0x0002D7EE
		[Register("stop", "()V", "GetStopHandler")]
		public virtual void Stop()
		{
			GifDrawable._members.InstanceMethods.InvokeVirtualVoidMethod("stop.()V", this, null);
		}

		// Token: 0x06000EBD RID: 3773 RVA: 0x0002F607 File Offset: 0x0002D807
		private static Delegate GetUnregisterAnimationCallback_Landroidx_vectordrawable_graphics_drawable_Animatable2Compat_AnimationCallback_Handler()
		{
			if (GifDrawable.cb_unregisterAnimationCallback_Landroidx_vectordrawable_graphics_drawable_Animatable2Compat_AnimationCallback_ == null)
			{
				GifDrawable.cb_unregisterAnimationCallback_Landroidx_vectordrawable_graphics_drawable_Animatable2Compat_AnimationCallback_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(GifDrawable.n_UnregisterAnimationCallback_Landroidx_vectordrawable_graphics_drawable_Animatable2Compat_AnimationCallback_));
			}
			return GifDrawable.cb_unregisterAnimationCallback_Landroidx_vectordrawable_graphics_drawable_Animatable2Compat_AnimationCallback_;
		}

		// Token: 0x06000EBE RID: 3774 RVA: 0x0002F62C File Offset: 0x0002D82C
		private static bool n_UnregisterAnimationCallback_Landroidx_vectordrawable_graphics_drawable_Animatable2Compat_AnimationCallback_(IntPtr jnienv, IntPtr native__this, IntPtr native_animationCallback)
		{
			GifDrawable @object = Java.Lang.Object.GetObject<GifDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Animatable2CompatAnimationCallback object2 = Java.Lang.Object.GetObject<Animatable2CompatAnimationCallback>(native_animationCallback, JniHandleOwnership.DoNotTransfer);
			return @object.UnregisterAnimationCallback(object2);
		}

		// Token: 0x06000EBF RID: 3775 RVA: 0x0002F650 File Offset: 0x0002D850
		[Register("unregisterAnimationCallback", "(Landroidx/vectordrawable/graphics/drawable/Animatable2Compat$AnimationCallback;)Z", "GetUnregisterAnimationCallback_Landroidx_vectordrawable_graphics_drawable_Animatable2Compat_AnimationCallback_Handler")]
		public unsafe virtual bool UnregisterAnimationCallback(Animatable2CompatAnimationCallback animationCallback)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((animationCallback == null) ? IntPtr.Zero : animationCallback.Handle);
				result = GifDrawable._members.InstanceMethods.InvokeVirtualBooleanMethod("unregisterAnimationCallback.(Landroidx/vectordrawable/graphics/drawable/Animatable2Compat$AnimationCallback;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(animationCallback);
			}
			return result;
		}

		// Token: 0x04000356 RID: 854
		[Register("LOOP_FOREVER")]
		public const int LoopForever = -1;

		// Token: 0x04000357 RID: 855
		[Register("LOOP_INTRINSIC")]
		public const int LoopIntrinsic = 0;

		// Token: 0x04000358 RID: 856
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/resource/gif/GifDrawable", typeof(GifDrawable));

		// Token: 0x04000359 RID: 857
		private static Delegate cb_getBuffer;

		// Token: 0x0400035A RID: 858
		private static Delegate cb_getFirstFrame;

		// Token: 0x0400035B RID: 859
		private static Delegate cb_getFrameCount;

		// Token: 0x0400035C RID: 860
		private static Delegate cb_getFrameIndex;

		// Token: 0x0400035D RID: 861
		private static Delegate cb_getFrameTransformation;

		// Token: 0x0400035E RID: 862
		private static Delegate cb_isRunning;

		// Token: 0x0400035F RID: 863
		private static Delegate cb_getOpacity;

		// Token: 0x04000360 RID: 864
		private static Delegate cb_getSize;

		// Token: 0x04000361 RID: 865
		private static Delegate cb_clearAnimationCallbacks;

		// Token: 0x04000362 RID: 866
		private static Delegate cb_draw_Landroid_graphics_Canvas_;

		// Token: 0x04000363 RID: 867
		private static Delegate cb_onFrameReady;

		// Token: 0x04000364 RID: 868
		private static Delegate cb_recycle;

		// Token: 0x04000365 RID: 869
		private static Delegate cb_registerAnimationCallback_Landroidx_vectordrawable_graphics_drawable_Animatable2Compat_AnimationCallback_;

		// Token: 0x04000366 RID: 870
		private static Delegate cb_setAlpha_I;

		// Token: 0x04000367 RID: 871
		private static Delegate cb_setColorFilter_Landroid_graphics_ColorFilter_;

		// Token: 0x04000368 RID: 872
		private static Delegate cb_setFrameTransformation_Lcom_bumptech_glide_load_Transformation_Landroid_graphics_Bitmap_;

		// Token: 0x04000369 RID: 873
		private static Delegate cb_setLoopCount_I;

		// Token: 0x0400036A RID: 874
		private static Delegate cb_start;

		// Token: 0x0400036B RID: 875
		private static Delegate cb_startFromFirstFrame;

		// Token: 0x0400036C RID: 876
		private static Delegate cb_stop;

		// Token: 0x0400036D RID: 877
		private static Delegate cb_unregisterAnimationCallback_Landroidx_vectordrawable_graphics_drawable_Animatable2Compat_AnimationCallback_;
	}
}
