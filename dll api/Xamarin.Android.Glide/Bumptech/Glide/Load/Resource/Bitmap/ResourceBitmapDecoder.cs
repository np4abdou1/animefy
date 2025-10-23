using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Net;
using Android.Runtime;
using Bumptech.Glide.Load.Engine;
using Bumptech.Glide.Load.Engine.BitmapRecycle;
using Bumptech.Glide.Load.Resource.Drawable;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Resource.Bitmap
{
	// Token: 0x02000116 RID: 278
	[Register("com/bumptech/glide/load/resource/bitmap/ResourceBitmapDecoder", DoNotGenerateAcw = true)]
	public class ResourceBitmapDecoder : Java.Lang.Object, IResourceDecoder, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06000DF2 RID: 3570 RVA: 0x0002C400 File Offset: 0x0002A600
		internal static IntPtr class_ref
		{
			get
			{
				return ResourceBitmapDecoder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06000DF3 RID: 3571 RVA: 0x0002C424 File Offset: 0x0002A624
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ResourceBitmapDecoder._members;
			}
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x06000DF4 RID: 3572 RVA: 0x0002C42C File Offset: 0x0002A62C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ResourceBitmapDecoder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06000DF5 RID: 3573 RVA: 0x0002C450 File Offset: 0x0002A650
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ResourceBitmapDecoder._members.ManagedPeerType;
			}
		}

		// Token: 0x06000DF6 RID: 3574 RVA: 0x0002C45C File Offset: 0x0002A65C
		protected ResourceBitmapDecoder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000DF7 RID: 3575 RVA: 0x0002C468 File Offset: 0x0002A668
		[Register(".ctor", "(Lcom/bumptech/glide/load/resource/drawable/ResourceDrawableDecoder;Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;)V", "")]
		public unsafe ResourceBitmapDecoder(ResourceDrawableDecoder drawableDecoder, IBitmapPool bitmapPool) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((drawableDecoder == null) ? IntPtr.Zero : drawableDecoder.Handle);
				ptr[1] = new JniArgumentValue((bitmapPool == null) ? IntPtr.Zero : ((Java.Lang.Object)bitmapPool).Handle);
				base.SetHandle(ResourceBitmapDecoder._members.InstanceMethods.StartCreateInstance("(Lcom/bumptech/glide/load/resource/drawable/ResourceDrawableDecoder;Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ResourceBitmapDecoder._members.InstanceMethods.FinishCreateInstance("(Lcom/bumptech/glide/load/resource/drawable/ResourceDrawableDecoder;Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(drawableDecoder);
				GC.KeepAlive(bitmapPool);
			}
		}

		// Token: 0x06000DF8 RID: 3576 RVA: 0x0002C544 File Offset: 0x0002A744
		private static Delegate GetDecode_Landroid_net_Uri_IILcom_bumptech_glide_load_Options_Handler()
		{
			if (ResourceBitmapDecoder.cb_decode_Landroid_net_Uri_IILcom_bumptech_glide_load_Options_ == null)
			{
				ResourceBitmapDecoder.cb_decode_Landroid_net_Uri_IILcom_bumptech_glide_load_Options_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIIL_L(ResourceBitmapDecoder.n_Decode_Landroid_net_Uri_IILcom_bumptech_glide_load_Options_));
			}
			return ResourceBitmapDecoder.cb_decode_Landroid_net_Uri_IILcom_bumptech_glide_load_Options_;
		}

		// Token: 0x06000DF9 RID: 3577 RVA: 0x0002C568 File Offset: 0x0002A768
		private static IntPtr n_Decode_Landroid_net_Uri_IILcom_bumptech_glide_load_Options_(IntPtr jnienv, IntPtr native__this, IntPtr native_source, int width, int height, IntPtr native_options)
		{
			ResourceBitmapDecoder @object = Java.Lang.Object.GetObject<ResourceBitmapDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Android.Net.Uri object2 = Java.Lang.Object.GetObject<Android.Net.Uri>(native_source, JniHandleOwnership.DoNotTransfer);
			Options object3 = Java.Lang.Object.GetObject<Options>(native_options, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Decode(object2, width, height, object3));
		}

		// Token: 0x06000DFA RID: 3578 RVA: 0x0002C5A0 File Offset: 0x0002A7A0
		[Register("decode", "(Landroid/net/Uri;IILcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/engine/Resource;", "GetDecode_Landroid_net_Uri_IILcom_bumptech_glide_load_Options_Handler")]
		public unsafe virtual IResource Decode(Android.Net.Uri source, int width, int height, Options options)
		{
			IResource @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((source == null) ? IntPtr.Zero : source.Handle);
				ptr[1] = new JniArgumentValue(width);
				ptr[2] = new JniArgumentValue(height);
				ptr[3] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				@object = Java.Lang.Object.GetObject<IResource>(ResourceBitmapDecoder._members.InstanceMethods.InvokeVirtualObjectMethod("decode.(Landroid/net/Uri;IILcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/engine/Resource;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(source);
				GC.KeepAlive(options);
			}
			return @object;
		}

		// Token: 0x06000DFB RID: 3579 RVA: 0x0002C66C File Offset: 0x0002A86C
		private static Delegate GetHandles_Landroid_net_Uri_Lcom_bumptech_glide_load_Options_Handler()
		{
			if (ResourceBitmapDecoder.cb_handles_Landroid_net_Uri_Lcom_bumptech_glide_load_Options_ == null)
			{
				ResourceBitmapDecoder.cb_handles_Landroid_net_Uri_Lcom_bumptech_glide_load_Options_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_Z(ResourceBitmapDecoder.n_Handles_Landroid_net_Uri_Lcom_bumptech_glide_load_Options_));
			}
			return ResourceBitmapDecoder.cb_handles_Landroid_net_Uri_Lcom_bumptech_glide_load_Options_;
		}

		// Token: 0x06000DFC RID: 3580 RVA: 0x0002C690 File Offset: 0x0002A890
		private static bool n_Handles_Landroid_net_Uri_Lcom_bumptech_glide_load_Options_(IntPtr jnienv, IntPtr native__this, IntPtr native_source, IntPtr native_options)
		{
			ResourceBitmapDecoder @object = Java.Lang.Object.GetObject<ResourceBitmapDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Android.Net.Uri object2 = Java.Lang.Object.GetObject<Android.Net.Uri>(native_source, JniHandleOwnership.DoNotTransfer);
			Options object3 = Java.Lang.Object.GetObject<Options>(native_options, JniHandleOwnership.DoNotTransfer);
			return @object.Handles(object2, object3);
		}

		// Token: 0x06000DFD RID: 3581 RVA: 0x0002C6BC File Offset: 0x0002A8BC
		[Register("handles", "(Landroid/net/Uri;Lcom/bumptech/glide/load/Options;)Z", "GetHandles_Landroid_net_Uri_Lcom_bumptech_glide_load_Options_Handler")]
		public unsafe virtual bool Handles(Android.Net.Uri source, Options options)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((source == null) ? IntPtr.Zero : source.Handle);
				ptr[1] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				result = ResourceBitmapDecoder._members.InstanceMethods.InvokeVirtualBooleanMethod("handles.(Landroid/net/Uri;Lcom/bumptech/glide/load/Options;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(source);
				GC.KeepAlive(options);
			}
			return result;
		}

		// Token: 0x06000DFE RID: 3582 RVA: 0x0002C74C File Offset: 0x0002A94C
		IResource IResourceDecoder.Decode(Java.Lang.Object p0, int p1, int p2, Options p3)
		{
			return this.Decode(p0.JavaCast<Android.Net.Uri>(), p1, p2, p3).JavaCast<IResource>();
		}

		// Token: 0x06000DFF RID: 3583 RVA: 0x0002C763 File Offset: 0x0002A963
		bool IResourceDecoder.Handles(Java.Lang.Object p0, Options p1)
		{
			return this.Handles(p0.JavaCast<Android.Net.Uri>(), p1);
		}

		// Token: 0x04000340 RID: 832
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/resource/bitmap/ResourceBitmapDecoder", typeof(ResourceBitmapDecoder));

		// Token: 0x04000341 RID: 833
		private static Delegate cb_decode_Landroid_net_Uri_IILcom_bumptech_glide_load_Options_;

		// Token: 0x04000342 RID: 834
		private static Delegate cb_handles_Landroid_net_Uri_Lcom_bumptech_glide_load_Options_;
	}
}
