using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Graphics.Drawables;
using Android.Runtime;
using Bumptech.Glide.Manager;
using Bumptech.Glide.Request.Transition;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Request.Target
{
	// Token: 0x020000B5 RID: 181
	[Register("com/bumptech/glide/request/target/CustomViewTarget", DoNotGenerateAcw = true)]
	internal class CustomViewTargetInvoker : CustomViewTarget, ITarget, ILifecycleListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000990 RID: 2448 RVA: 0x0001DE36 File Offset: 0x0001C036
		public CustomViewTargetInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000991 RID: 2449 RVA: 0x0001DE40 File Offset: 0x0001C040
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CustomViewTargetInvoker._members;
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000992 RID: 2450 RVA: 0x0001DE47 File Offset: 0x0001C047
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CustomViewTargetInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000993 RID: 2451 RVA: 0x0001DE54 File Offset: 0x0001C054
		[Register("onResourceCleared", "(Landroid/graphics/drawable/Drawable;)V", "GetOnResourceCleared_Landroid_graphics_drawable_Drawable_Handler")]
		protected unsafe override void OnResourceCleared(Drawable p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				CustomViewTargetInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("onResourceCleared.(Landroid/graphics/drawable/Drawable;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x06000994 RID: 2452 RVA: 0x0001DEB8 File Offset: 0x0001C0B8
		[Register("onResourceReady", "(Ljava/lang/Object;Lcom/bumptech/glide/request/transition/Transition;)V", "GetOnResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_Handler")]
		public unsafe override void OnResourceReady(Java.Lang.Object resource, ITransition transition)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(resource);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((transition == null) ? IntPtr.Zero : ((Java.Lang.Object)transition).Handle);
				CustomViewTargetInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("onResourceReady.(Ljava/lang/Object;Lcom/bumptech/glide/request/transition/Transition;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(resource);
				GC.KeepAlive(transition);
			}
		}

		// Token: 0x06000995 RID: 2453 RVA: 0x0001DF48 File Offset: 0x0001C148
		[Register("onLoadFailed", "(Landroid/graphics/drawable/Drawable;)V", "GetOnLoadFailed_Landroid_graphics_drawable_Drawable_Handler")]
		public unsafe override void OnLoadFailed(Drawable p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				CustomViewTargetInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("onLoadFailed.(Landroid/graphics/drawable/Drawable;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x04000256 RID: 598
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/request/target/CustomViewTarget", typeof(CustomViewTargetInvoker));
	}
}
