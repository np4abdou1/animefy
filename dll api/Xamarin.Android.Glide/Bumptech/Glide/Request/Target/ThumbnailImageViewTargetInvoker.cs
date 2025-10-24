using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Graphics.Drawables;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Request.Target
{
	// Token: 0x020000C4 RID: 196
	[Register("com/bumptech/glide/request/target/ThumbnailImageViewTarget", DoNotGenerateAcw = true)]
	internal class ThumbnailImageViewTargetInvoker : ThumbnailImageViewTarget
	{
		// Token: 0x06000A36 RID: 2614 RVA: 0x0001FC4B File Offset: 0x0001DE4B
		public ThumbnailImageViewTargetInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06000A37 RID: 2615 RVA: 0x0001FC55 File Offset: 0x0001DE55
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ThumbnailImageViewTargetInvoker._members;
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000A38 RID: 2616 RVA: 0x0001FC5C File Offset: 0x0001DE5C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ThumbnailImageViewTargetInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x0001FC68 File Offset: 0x0001DE68
		[Register("getDrawable", "(Ljava/lang/Object;)Landroid/graphics/drawable/Drawable;", "GetGetDrawable_Ljava_lang_Object_Handler")]
		protected unsafe override Drawable GetDrawable(Java.Lang.Object p0)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(p0);
			Drawable @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Drawable>(ThumbnailImageViewTargetInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getDrawable.(Ljava/lang/Object;)Landroid/graphics/drawable/Drawable;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
			}
			return @object;
		}

		// Token: 0x04000288 RID: 648
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/request/target/ThumbnailImageViewTarget", typeof(ThumbnailImageViewTargetInvoker));
	}
}
