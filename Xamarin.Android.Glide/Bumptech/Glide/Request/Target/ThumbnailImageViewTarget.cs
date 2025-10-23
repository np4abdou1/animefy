using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Graphics.Drawables;
using Android.Runtime;
using Android.Widget;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Request.Target
{
	// Token: 0x020000C3 RID: 195
	[Register("com/bumptech/glide/request/target/ThumbnailImageViewTarget", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public abstract class ThumbnailImageViewTarget : ImageViewTarget
	{
		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06000A28 RID: 2600 RVA: 0x0001F960 File Offset: 0x0001DB60
		internal new static IntPtr class_ref
		{
			get
			{
				return ThumbnailImageViewTarget._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06000A29 RID: 2601 RVA: 0x0001F984 File Offset: 0x0001DB84
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ThumbnailImageViewTarget._members;
			}
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06000A2A RID: 2602 RVA: 0x0001F98C File Offset: 0x0001DB8C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ThumbnailImageViewTarget._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06000A2B RID: 2603 RVA: 0x0001F9B0 File Offset: 0x0001DBB0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ThumbnailImageViewTarget._members.ManagedPeerType;
			}
		}

		// Token: 0x06000A2C RID: 2604 RVA: 0x0001F9BC File Offset: 0x0001DBBC
		protected ThumbnailImageViewTarget(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000A2D RID: 2605 RVA: 0x0001F9C8 File Offset: 0x0001DBC8
		[Register(".ctor", "(Landroid/widget/ImageView;)V", "")]
		public unsafe ThumbnailImageViewTarget(ImageView view) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
				base.SetHandle(ThumbnailImageViewTarget._members.InstanceMethods.StartCreateInstance("(Landroid/widget/ImageView;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ThumbnailImageViewTarget._members.InstanceMethods.FinishCreateInstance("(Landroid/widget/ImageView;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(view);
			}
		}

		// Token: 0x06000A2E RID: 2606 RVA: 0x0001FA78 File Offset: 0x0001DC78
		[Register(".ctor", "(Landroid/widget/ImageView;Z)V", "")]
		[Obsolete("deprecated")]
		public unsafe ThumbnailImageViewTarget(ImageView view, bool waitForLayout) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
				ptr[1] = new JniArgumentValue(waitForLayout);
				base.SetHandle(ThumbnailImageViewTarget._members.InstanceMethods.StartCreateInstance("(Landroid/widget/ImageView;Z)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ThumbnailImageViewTarget._members.InstanceMethods.FinishCreateInstance("(Landroid/widget/ImageView;Z)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(view);
			}
		}

		// Token: 0x06000A2F RID: 2607 RVA: 0x0001FB38 File Offset: 0x0001DD38
		private static Delegate GetGetDrawable_Ljava_lang_Object_Handler()
		{
			if (ThumbnailImageViewTarget.cb_getDrawable_Ljava_lang_Object_ == null)
			{
				ThumbnailImageViewTarget.cb_getDrawable_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ThumbnailImageViewTarget.n_GetDrawable_Ljava_lang_Object_));
			}
			return ThumbnailImageViewTarget.cb_getDrawable_Ljava_lang_Object_;
		}

		// Token: 0x06000A30 RID: 2608 RVA: 0x0001FB5C File Offset: 0x0001DD5C
		private static IntPtr n_GetDrawable_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ThumbnailImageViewTarget @object = Java.Lang.Object.GetObject<ThumbnailImageViewTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetDrawable(object2));
		}

		// Token: 0x06000A31 RID: 2609
		[Register("getDrawable", "(Ljava/lang/Object;)Landroid/graphics/drawable/Drawable;", "GetGetDrawable_Ljava_lang_Object_Handler")]
		protected abstract Drawable GetDrawable(Java.Lang.Object p0);

		// Token: 0x06000A32 RID: 2610 RVA: 0x0001FB84 File Offset: 0x0001DD84
		private static Delegate GetSetResource_Ljava_lang_Object_Handler()
		{
			if (ThumbnailImageViewTarget.cb_setResource_Ljava_lang_Object_ == null)
			{
				ThumbnailImageViewTarget.cb_setResource_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ThumbnailImageViewTarget.n_SetResource_Ljava_lang_Object_));
			}
			return ThumbnailImageViewTarget.cb_setResource_Ljava_lang_Object_;
		}

		// Token: 0x06000A33 RID: 2611 RVA: 0x0001FBA8 File Offset: 0x0001DDA8
		private static void n_SetResource_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_resource)
		{
			ImageViewTarget @object = Java.Lang.Object.GetObject<ThumbnailImageViewTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_resource, JniHandleOwnership.DoNotTransfer);
			@object.SetResource(object2);
		}

		// Token: 0x06000A34 RID: 2612 RVA: 0x0001FBCC File Offset: 0x0001DDCC
		[Register("setResource", "(Ljava/lang/Object;)V", "GetSetResource_Ljava_lang_Object_Handler")]
		protected unsafe override void SetResource(Java.Lang.Object resource)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(resource);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ThumbnailImageViewTarget._members.InstanceMethods.InvokeVirtualVoidMethod("setResource.(Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(resource);
			}
		}

		// Token: 0x04000285 RID: 645
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/request/target/ThumbnailImageViewTarget", typeof(ThumbnailImageViewTarget));

		// Token: 0x04000286 RID: 646
		private static Delegate cb_getDrawable_Ljava_lang_Object_;

		// Token: 0x04000287 RID: 647
		private static Delegate cb_setResource_Ljava_lang_Object_;
	}
}
