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
	// Token: 0x020000B3 RID: 179
	[Register("com/bumptech/glide/request/target/CustomTarget", DoNotGenerateAcw = true)]
	internal class CustomTargetInvoker : CustomTarget, ITarget, ILifecycleListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000964 RID: 2404 RVA: 0x0001D64E File Offset: 0x0001B84E
		public CustomTargetInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06000965 RID: 2405 RVA: 0x0001D658 File Offset: 0x0001B858
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CustomTargetInvoker._members;
			}
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x06000966 RID: 2406 RVA: 0x0001D65F File Offset: 0x0001B85F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CustomTargetInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x0001D66C File Offset: 0x0001B86C
		[Register("onResourceReady", "(Ljava/lang/Object;Lcom/bumptech/glide/request/transition/Transition;)V", "GetOnResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_Handler")]
		public unsafe override void OnResourceReady(Java.Lang.Object resource, ITransition transition)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(resource);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((transition == null) ? IntPtr.Zero : ((Java.Lang.Object)transition).Handle);
				CustomTargetInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("onResourceReady.(Ljava/lang/Object;Lcom/bumptech/glide/request/transition/Transition;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(resource);
				GC.KeepAlive(transition);
			}
		}

		// Token: 0x06000968 RID: 2408 RVA: 0x0001D6FC File Offset: 0x0001B8FC
		[Register("onLoadCleared", "(Landroid/graphics/drawable/Drawable;)V", "GetOnLoadCleared_Landroid_graphics_drawable_Drawable_Handler")]
		public unsafe override void OnLoadCleared(Drawable p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				CustomTargetInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("onLoadCleared.(Landroid/graphics/drawable/Drawable;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x0400024D RID: 589
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/request/target/CustomTarget", typeof(CustomTargetInvoker));
	}
}
