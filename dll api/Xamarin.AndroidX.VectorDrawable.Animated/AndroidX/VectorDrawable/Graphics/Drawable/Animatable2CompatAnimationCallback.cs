using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Graphics.Drawables;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace AndroidX.VectorDrawable.Graphics.Drawable
{
	// Token: 0x02000009 RID: 9
	[Register("androidx/vectordrawable/graphics/drawable/Animatable2Compat$AnimationCallback", DoNotGenerateAcw = true)]
	public abstract class Animatable2CompatAnimationCallback : Java.Lang.Object
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000014 RID: 20 RVA: 0x00002080 File Offset: 0x00000280
		internal static IntPtr class_ref
		{
			get
			{
				return Animatable2CompatAnimationCallback._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000015 RID: 21 RVA: 0x000020A4 File Offset: 0x000002A4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Animatable2CompatAnimationCallback._members;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000016 RID: 22 RVA: 0x000020AC File Offset: 0x000002AC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Animatable2CompatAnimationCallback._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000017 RID: 23 RVA: 0x000020D0 File Offset: 0x000002D0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Animatable2CompatAnimationCallback._members.ManagedPeerType;
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000020DC File Offset: 0x000002DC
		protected Animatable2CompatAnimationCallback(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000020E8 File Offset: 0x000002E8
		[Register(".ctor", "()V", "")]
		public Animatable2CompatAnimationCallback() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(Animatable2CompatAnimationCallback._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			Animatable2CompatAnimationCallback._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002156 File Offset: 0x00000356
		private static Delegate GetOnAnimationEnd_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (Animatable2CompatAnimationCallback.cb_onAnimationEnd_Landroid_graphics_drawable_Drawable_ == null)
			{
				Animatable2CompatAnimationCallback.cb_onAnimationEnd_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Animatable2CompatAnimationCallback.n_OnAnimationEnd_Landroid_graphics_drawable_Drawable_));
			}
			return Animatable2CompatAnimationCallback.cb_onAnimationEnd_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x0000217C File Offset: 0x0000037C
		private static void n_OnAnimationEnd_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_drawable)
		{
			Animatable2CompatAnimationCallback @object = Java.Lang.Object.GetObject<Animatable2CompatAnimationCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_drawable, JniHandleOwnership.DoNotTransfer);
			@object.OnAnimationEnd(object2);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000021A0 File Offset: 0x000003A0
		[Register("onAnimationEnd", "(Landroid/graphics/drawable/Drawable;)V", "GetOnAnimationEnd_Landroid_graphics_drawable_Drawable_Handler")]
		public unsafe virtual void OnAnimationEnd(Drawable drawable)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((drawable == null) ? IntPtr.Zero : drawable.Handle);
				Animatable2CompatAnimationCallback._members.InstanceMethods.InvokeVirtualVoidMethod("onAnimationEnd.(Landroid/graphics/drawable/Drawable;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(drawable);
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002204 File Offset: 0x00000404
		private static Delegate GetOnAnimationStart_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (Animatable2CompatAnimationCallback.cb_onAnimationStart_Landroid_graphics_drawable_Drawable_ == null)
			{
				Animatable2CompatAnimationCallback.cb_onAnimationStart_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Animatable2CompatAnimationCallback.n_OnAnimationStart_Landroid_graphics_drawable_Drawable_));
			}
			return Animatable2CompatAnimationCallback.cb_onAnimationStart_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002228 File Offset: 0x00000428
		private static void n_OnAnimationStart_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_drawable)
		{
			Animatable2CompatAnimationCallback @object = Java.Lang.Object.GetObject<Animatable2CompatAnimationCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_drawable, JniHandleOwnership.DoNotTransfer);
			@object.OnAnimationStart(object2);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x0000224C File Offset: 0x0000044C
		[Register("onAnimationStart", "(Landroid/graphics/drawable/Drawable;)V", "GetOnAnimationStart_Landroid_graphics_drawable_Drawable_Handler")]
		public unsafe virtual void OnAnimationStart(Drawable drawable)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((drawable == null) ? IntPtr.Zero : drawable.Handle);
				Animatable2CompatAnimationCallback._members.InstanceMethods.InvokeVirtualVoidMethod("onAnimationStart.(Landroid/graphics/drawable/Drawable;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(drawable);
			}
		}

		// Token: 0x04000003 RID: 3
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/vectordrawable/graphics/drawable/Animatable2Compat$AnimationCallback", typeof(Animatable2CompatAnimationCallback));

		// Token: 0x04000004 RID: 4
		private static Delegate cb_onAnimationEnd_Landroid_graphics_drawable_Drawable_;

		// Token: 0x04000005 RID: 5
		private static Delegate cb_onAnimationStart_Landroid_graphics_drawable_Drawable_;
	}
}
