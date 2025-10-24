using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Bumptech.Glide.Request.Transition;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Request.Target
{
	// Token: 0x020000C2 RID: 194
	[Register("com/bumptech/glide/request/target/SimpleTarget", DoNotGenerateAcw = true)]
	internal class SimpleTargetInvoker : SimpleTarget
	{
		// Token: 0x06000A23 RID: 2595 RVA: 0x0001F897 File Offset: 0x0001DA97
		public SimpleTargetInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06000A24 RID: 2596 RVA: 0x0001F8A1 File Offset: 0x0001DAA1
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SimpleTargetInvoker._members;
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000A25 RID: 2597 RVA: 0x0001F8A8 File Offset: 0x0001DAA8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SimpleTargetInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000A26 RID: 2598 RVA: 0x0001F8B4 File Offset: 0x0001DAB4
		[Register("onResourceReady", "(Ljava/lang/Object;Lcom/bumptech/glide/request/transition/Transition;)V", "GetOnResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_Handler")]
		public unsafe override void OnResourceReady(Java.Lang.Object resource, ITransition transition)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(resource);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((transition == null) ? IntPtr.Zero : ((Java.Lang.Object)transition).Handle);
				SimpleTargetInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("onResourceReady.(Ljava/lang/Object;Lcom/bumptech/glide/request/transition/Transition;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(resource);
				GC.KeepAlive(transition);
			}
		}

		// Token: 0x04000284 RID: 644
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/request/target/SimpleTarget", typeof(SimpleTargetInvoker));
	}
}
