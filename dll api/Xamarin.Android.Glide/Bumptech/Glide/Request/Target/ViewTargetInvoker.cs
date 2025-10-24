using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Bumptech.Glide.Request.Transition;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Request.Target
{
	// Token: 0x020000C6 RID: 198
	[Register("com/bumptech/glide/request/target/ViewTarget", DoNotGenerateAcw = true)]
	internal class ViewTargetInvoker : ViewTarget
	{
		// Token: 0x06000A51 RID: 2641 RVA: 0x000201D1 File Offset: 0x0001E3D1
		public ViewTargetInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06000A52 RID: 2642 RVA: 0x000201DB File Offset: 0x0001E3DB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ViewTargetInvoker._members;
			}
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06000A53 RID: 2643 RVA: 0x000201E2 File Offset: 0x0001E3E2
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ViewTargetInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000A54 RID: 2644 RVA: 0x000201F0 File Offset: 0x0001E3F0
		[Register("onResourceReady", "(Ljava/lang/Object;Lcom/bumptech/glide/request/transition/Transition;)V", "GetOnResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_Handler")]
		public unsafe override void OnResourceReady(Java.Lang.Object resource, ITransition transition)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(resource);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((transition == null) ? IntPtr.Zero : ((Java.Lang.Object)transition).Handle);
				ViewTargetInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("onResourceReady.(Ljava/lang/Object;Lcom/bumptech/glide/request/transition/Transition;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(resource);
				GC.KeepAlive(transition);
			}
		}

		// Token: 0x0400028D RID: 653
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/request/target/ViewTarget", typeof(ViewTargetInvoker));
	}
}
