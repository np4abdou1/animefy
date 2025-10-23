using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Bumptech.Glide.Manager;
using Bumptech.Glide.Request.Transition;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Request.Target
{
	// Token: 0x020000B1 RID: 177
	[Register("com/bumptech/glide/request/target/BaseTarget", DoNotGenerateAcw = true)]
	internal class BaseTargetInvoker : BaseTarget, ITarget, ILifecycleListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600093C RID: 2364 RVA: 0x0001CEEA File Offset: 0x0001B0EA
		public BaseTargetInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x0600093D RID: 2365 RVA: 0x0001CEF4 File Offset: 0x0001B0F4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BaseTargetInvoker._members;
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x0600093E RID: 2366 RVA: 0x0001CEFB File Offset: 0x0001B0FB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BaseTargetInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x0001CF08 File Offset: 0x0001B108
		[Register("onResourceReady", "(Ljava/lang/Object;Lcom/bumptech/glide/request/transition/Transition;)V", "GetOnResourceReady_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_Handler")]
		public unsafe override void OnResourceReady(Java.Lang.Object resource, ITransition transition)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(resource);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((transition == null) ? IntPtr.Zero : ((Java.Lang.Object)transition).Handle);
				BaseTargetInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("onResourceReady.(Ljava/lang/Object;Lcom/bumptech/glide/request/transition/Transition;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(resource);
				GC.KeepAlive(transition);
			}
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x0001CF98 File Offset: 0x0001B198
		[Register("getSize", "(Lcom/bumptech/glide/request/target/SizeReadyCallback;)V", "GetGetSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_Handler")]
		public unsafe override void GetSize(ISizeReadyCallback p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				BaseTargetInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("getSize.(Lcom/bumptech/glide/request/target/SizeReadyCallback;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x0001D000 File Offset: 0x0001B200
		[Register("removeCallback", "(Lcom/bumptech/glide/request/target/SizeReadyCallback;)V", "GetRemoveCallback_Lcom_bumptech_glide_request_target_SizeReadyCallback_Handler")]
		public unsafe override void RemoveCallback(ISizeReadyCallback p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				BaseTargetInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("removeCallback.(Lcom/bumptech/glide/request/target/SizeReadyCallback;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x04000244 RID: 580
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/request/target/BaseTarget", typeof(BaseTargetInvoker));
	}
}
