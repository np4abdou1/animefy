using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Android.Widget;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Request.Target
{
	// Token: 0x020000B9 RID: 185
	[Register("com/bumptech/glide/request/target/ImageViewTargetFactory", DoNotGenerateAcw = true)]
	public class ImageViewTargetFactory : Java.Lang.Object
	{
		// Token: 0x17000221 RID: 545
		// (get) Token: 0x060009C3 RID: 2499 RVA: 0x0001E808 File Offset: 0x0001CA08
		internal static IntPtr class_ref
		{
			get
			{
				return ImageViewTargetFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x060009C4 RID: 2500 RVA: 0x0001E82C File Offset: 0x0001CA2C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ImageViewTargetFactory._members;
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x060009C5 RID: 2501 RVA: 0x0001E834 File Offset: 0x0001CA34
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ImageViewTargetFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x060009C6 RID: 2502 RVA: 0x0001E858 File Offset: 0x0001CA58
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ImageViewTargetFactory._members.ManagedPeerType;
			}
		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x0001E864 File Offset: 0x0001CA64
		protected ImageViewTargetFactory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060009C8 RID: 2504 RVA: 0x0001E870 File Offset: 0x0001CA70
		[Register(".ctor", "()V", "")]
		public ImageViewTargetFactory() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(ImageViewTargetFactory._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			ImageViewTargetFactory._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060009C9 RID: 2505 RVA: 0x0001E8DE File Offset: 0x0001CADE
		private static Delegate GetBuildTarget_Landroid_widget_ImageView_Ljava_lang_Class_Handler()
		{
			if (ImageViewTargetFactory.cb_buildTarget_Landroid_widget_ImageView_Ljava_lang_Class_ == null)
			{
				ImageViewTargetFactory.cb_buildTarget_Landroid_widget_ImageView_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(ImageViewTargetFactory.n_BuildTarget_Landroid_widget_ImageView_Ljava_lang_Class_));
			}
			return ImageViewTargetFactory.cb_buildTarget_Landroid_widget_ImageView_Ljava_lang_Class_;
		}

		// Token: 0x060009CA RID: 2506 RVA: 0x0001E904 File Offset: 0x0001CB04
		private static IntPtr n_BuildTarget_Landroid_widget_ImageView_Ljava_lang_Class_(IntPtr jnienv, IntPtr native__this, IntPtr native_view, IntPtr native_clazz)
		{
			ImageViewTargetFactory @object = Java.Lang.Object.GetObject<ImageViewTargetFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ImageView object2 = Java.Lang.Object.GetObject<ImageView>(native_view, JniHandleOwnership.DoNotTransfer);
			Class object3 = Java.Lang.Object.GetObject<Class>(native_clazz, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.BuildTarget(object2, object3));
		}

		// Token: 0x060009CB RID: 2507 RVA: 0x0001E938 File Offset: 0x0001CB38
		[Register("buildTarget", "(Landroid/widget/ImageView;Ljava/lang/Class;)Lcom/bumptech/glide/request/target/ViewTarget;", "GetBuildTarget_Landroid_widget_ImageView_Ljava_lang_Class_Handler")]
		[JavaTypeParameters(new string[]
		{
			"Z"
		})]
		public unsafe virtual ViewTarget BuildTarget(ImageView view, Class clazz)
		{
			ViewTarget @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
				ptr[1] = new JniArgumentValue((clazz == null) ? IntPtr.Zero : clazz.Handle);
				@object = Java.Lang.Object.GetObject<ViewTarget>(ImageViewTargetFactory._members.InstanceMethods.InvokeVirtualObjectMethod("buildTarget.(Landroid/widget/ImageView;Ljava/lang/Class;)Lcom/bumptech/glide/request/target/ViewTarget;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(view);
				GC.KeepAlive(clazz);
			}
			return @object;
		}

		// Token: 0x04000262 RID: 610
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/request/target/ImageViewTargetFactory", typeof(ImageViewTargetFactory));

		// Token: 0x04000263 RID: 611
		private static Delegate cb_buildTarget_Landroid_widget_ImageView_Ljava_lang_Class_;
	}
}
