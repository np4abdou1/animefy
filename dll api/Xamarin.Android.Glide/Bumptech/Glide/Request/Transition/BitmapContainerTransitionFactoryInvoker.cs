using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Graphics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Request.Transition
{
	// Token: 0x0200009C RID: 156
	[Register("com/bumptech/glide/request/transition/BitmapContainerTransitionFactory", DoNotGenerateAcw = true)]
	internal class BitmapContainerTransitionFactoryInvoker : BitmapContainerTransitionFactory, ITransitionFactory, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000845 RID: 2117 RVA: 0x00019B5B File Offset: 0x00017D5B
		public BitmapContainerTransitionFactoryInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000846 RID: 2118 RVA: 0x00019B65 File Offset: 0x00017D65
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BitmapContainerTransitionFactoryInvoker._members;
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06000847 RID: 2119 RVA: 0x00019B6C File Offset: 0x00017D6C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BitmapContainerTransitionFactoryInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x00019B78 File Offset: 0x00017D78
		[Register("getBitmap", "(Ljava/lang/Object;)Landroid/graphics/Bitmap;", "GetGetBitmap_Ljava_lang_Object_Handler")]
		protected unsafe override Bitmap GetBitmap(Java.Lang.Object p0)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(p0);
			Bitmap @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Bitmap>(BitmapContainerTransitionFactoryInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getBitmap.(Ljava/lang/Object;)Landroid/graphics/Bitmap;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
			}
			return @object;
		}

		// Token: 0x0400020B RID: 523
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/request/transition/BitmapContainerTransitionFactory", typeof(BitmapContainerTransitionFactoryInvoker));
	}
}
