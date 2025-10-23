using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Request.Target
{
	// Token: 0x020000B8 RID: 184
	[Register("com/bumptech/glide/request/target/ImageViewTarget", DoNotGenerateAcw = true)]
	internal class ImageViewTargetInvoker : ImageViewTarget
	{
		// Token: 0x060009BE RID: 2494 RVA: 0x0001E76A File Offset: 0x0001C96A
		public ImageViewTargetInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x060009BF RID: 2495 RVA: 0x0001E774 File Offset: 0x0001C974
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ImageViewTargetInvoker._members;
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x060009C0 RID: 2496 RVA: 0x0001E77B File Offset: 0x0001C97B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ImageViewTargetInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060009C1 RID: 2497 RVA: 0x0001E788 File Offset: 0x0001C988
		[Register("setResource", "(Ljava/lang/Object;)V", "GetSetResource_Ljava_lang_Object_Handler")]
		protected unsafe override void SetResource(Java.Lang.Object p0)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ImageViewTargetInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("setResource.(Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x04000261 RID: 609
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/request/target/ImageViewTarget", typeof(ImageViewTargetInvoker));
	}
}
