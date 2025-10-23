using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Graphics.Drawables;
using Android.Runtime;
using Bumptech.Glide.Request.Transition;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Request.Target
{
	// Token: 0x020000C0 RID: 192
	[Register("com/bumptech/glide/request/target/PreloadTarget", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"Z"
	})]
	public sealed class PreloadTarget : CustomTarget
	{
		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06000A0E RID: 2574 RVA: 0x0001F3E0 File Offset: 0x0001D5E0
		internal new static IntPtr class_ref
		{
			get
			{
				return PreloadTarget._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06000A0F RID: 2575 RVA: 0x0001F404 File Offset: 0x0001D604
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return PreloadTarget._members;
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06000A10 RID: 2576 RVA: 0x0001F40C File Offset: 0x0001D60C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return PreloadTarget._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06000A11 RID: 2577 RVA: 0x0001F430 File Offset: 0x0001D630
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return PreloadTarget._members.ManagedPeerType;
			}
		}

		// Token: 0x06000A12 RID: 2578 RVA: 0x0001F43C File Offset: 0x0001D63C
		internal PreloadTarget(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000A13 RID: 2579 RVA: 0x0001F448 File Offset: 0x0001D648
		[Register("obtain", "(Lcom/bumptech/glide/RequestManager;II)Lcom/bumptech/glide/request/target/PreloadTarget;", "")]
		[JavaTypeParameters(new string[]
		{
			"Z"
		})]
		public unsafe static PreloadTarget Obtain(RequestManager requestManager, int width, int height)
		{
			PreloadTarget @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((requestManager == null) ? IntPtr.Zero : requestManager.Handle);
				ptr[1] = new JniArgumentValue(width);
				ptr[2] = new JniArgumentValue(height);
				@object = Java.Lang.Object.GetObject<PreloadTarget>(PreloadTarget._members.StaticMethods.InvokeObjectMethod("obtain.(Lcom/bumptech/glide/RequestManager;II)Lcom/bumptech/glide/request/target/PreloadTarget;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(requestManager);
			}
			return @object;
		}

		// Token: 0x06000A14 RID: 2580 RVA: 0x0001F4E4 File Offset: 0x0001D6E4
		[Register("onLoadCleared", "(Landroid/graphics/drawable/Drawable;)V", "")]
		public unsafe override void OnLoadCleared(Drawable placeholder)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((placeholder == null) ? IntPtr.Zero : placeholder.Handle);
				PreloadTarget._members.InstanceMethods.InvokeAbstractVoidMethod("onLoadCleared.(Landroid/graphics/drawable/Drawable;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(placeholder);
			}
		}

		// Token: 0x06000A15 RID: 2581 RVA: 0x0001F548 File Offset: 0x0001D748
		[Register("onResourceReady", "(Ljava/lang/Object;Lcom/bumptech/glide/request/transition/Transition;)V", "")]
		public unsafe override void OnResourceReady(Java.Lang.Object resource, ITransition transition)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(resource);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((transition == null) ? IntPtr.Zero : ((Java.Lang.Object)transition).Handle);
				PreloadTarget._members.InstanceMethods.InvokeAbstractVoidMethod("onResourceReady.(Ljava/lang/Object;Lcom/bumptech/glide/request/transition/Transition;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(resource);
				GC.KeepAlive(transition);
			}
		}

		// Token: 0x04000281 RID: 641
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/request/target/PreloadTarget", typeof(PreloadTarget));
	}
}
