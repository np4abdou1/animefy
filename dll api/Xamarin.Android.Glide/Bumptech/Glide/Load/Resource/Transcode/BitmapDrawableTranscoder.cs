using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Content.Res;
using Android.Runtime;
using Bumptech.Glide.Load.Engine;
using Bumptech.Glide.Load.Engine.BitmapRecycle;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Resource.Transcode
{
	// Token: 0x020000E6 RID: 230
	[Register("com/bumptech/glide/load/resource/transcode/BitmapDrawableTranscoder", DoNotGenerateAcw = true)]
	public class BitmapDrawableTranscoder : Java.Lang.Object, IResourceTranscoder, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06000B80 RID: 2944 RVA: 0x00023D8C File Offset: 0x00021F8C
		internal static IntPtr class_ref
		{
			get
			{
				return BitmapDrawableTranscoder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06000B81 RID: 2945 RVA: 0x00023DB0 File Offset: 0x00021FB0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BitmapDrawableTranscoder._members;
			}
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06000B82 RID: 2946 RVA: 0x00023DB8 File Offset: 0x00021FB8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BitmapDrawableTranscoder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06000B83 RID: 2947 RVA: 0x00023DDC File Offset: 0x00021FDC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BitmapDrawableTranscoder._members.ManagedPeerType;
			}
		}

		// Token: 0x06000B84 RID: 2948 RVA: 0x00023DE8 File Offset: 0x00021FE8
		protected BitmapDrawableTranscoder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000B85 RID: 2949 RVA: 0x00023DF4 File Offset: 0x00021FF4
		[Register(".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe BitmapDrawableTranscoder(Context context) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				base.SetHandle(BitmapDrawableTranscoder._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				BitmapDrawableTranscoder._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x00023EA4 File Offset: 0x000220A4
		[Register(".ctor", "(Landroid/content/res/Resources;)V", "")]
		public unsafe BitmapDrawableTranscoder(Resources resources) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((resources == null) ? IntPtr.Zero : resources.Handle);
				base.SetHandle(BitmapDrawableTranscoder._members.InstanceMethods.StartCreateInstance("(Landroid/content/res/Resources;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				BitmapDrawableTranscoder._members.InstanceMethods.FinishCreateInstance("(Landroid/content/res/Resources;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(resources);
			}
		}

		// Token: 0x06000B87 RID: 2951 RVA: 0x00023F54 File Offset: 0x00022154
		[Register(".ctor", "(Landroid/content/res/Resources;Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;)V", "")]
		[Obsolete("deprecated")]
		public unsafe BitmapDrawableTranscoder(Resources resources, IBitmapPool bitmapPool) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((resources == null) ? IntPtr.Zero : resources.Handle);
				ptr[1] = new JniArgumentValue((bitmapPool == null) ? IntPtr.Zero : ((Java.Lang.Object)bitmapPool).Handle);
				base.SetHandle(BitmapDrawableTranscoder._members.InstanceMethods.StartCreateInstance("(Landroid/content/res/Resources;Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				BitmapDrawableTranscoder._members.InstanceMethods.FinishCreateInstance("(Landroid/content/res/Resources;Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(resources);
				GC.KeepAlive(bitmapPool);
			}
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x00024030 File Offset: 0x00022230
		private static Delegate GetTranscode_Lcom_bumptech_glide_load_engine_Resource_Lcom_bumptech_glide_load_Options_Handler()
		{
			if (BitmapDrawableTranscoder.cb_transcode_Lcom_bumptech_glide_load_engine_Resource_Lcom_bumptech_glide_load_Options_ == null)
			{
				BitmapDrawableTranscoder.cb_transcode_Lcom_bumptech_glide_load_engine_Resource_Lcom_bumptech_glide_load_Options_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(BitmapDrawableTranscoder.n_Transcode_Lcom_bumptech_glide_load_engine_Resource_Lcom_bumptech_glide_load_Options_));
			}
			return BitmapDrawableTranscoder.cb_transcode_Lcom_bumptech_glide_load_engine_Resource_Lcom_bumptech_glide_load_Options_;
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x00024054 File Offset: 0x00022254
		private static IntPtr n_Transcode_Lcom_bumptech_glide_load_engine_Resource_Lcom_bumptech_glide_load_Options_(IntPtr jnienv, IntPtr native__this, IntPtr native_toTranscode, IntPtr native_options)
		{
			BitmapDrawableTranscoder @object = Java.Lang.Object.GetObject<BitmapDrawableTranscoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IResource object2 = Java.Lang.Object.GetObject<IResource>(native_toTranscode, JniHandleOwnership.DoNotTransfer);
			Options object3 = Java.Lang.Object.GetObject<Options>(native_options, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Transcode(object2, object3));
		}

		// Token: 0x06000B8A RID: 2954 RVA: 0x00024088 File Offset: 0x00022288
		[Register("transcode", "(Lcom/bumptech/glide/load/engine/Resource;Lcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/engine/Resource;", "GetTranscode_Lcom_bumptech_glide_load_engine_Resource_Lcom_bumptech_glide_load_Options_Handler")]
		public unsafe virtual IResource Transcode(IResource toTranscode, Options options)
		{
			IResource @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((toTranscode == null) ? IntPtr.Zero : ((Java.Lang.Object)toTranscode).Handle);
				ptr[1] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				@object = Java.Lang.Object.GetObject<IResource>(BitmapDrawableTranscoder._members.InstanceMethods.InvokeVirtualObjectMethod("transcode.(Lcom/bumptech/glide/load/engine/Resource;Lcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/engine/Resource;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(toTranscode);
				GC.KeepAlive(options);
			}
			return @object;
		}

		// Token: 0x06000B8B RID: 2955 RVA: 0x00024128 File Offset: 0x00022328
		IResource IResourceTranscoder.Transcode(IResource p0, Options p1)
		{
			return this.Transcode(p0.JavaCast<IResource>(), p1).JavaCast<IResource>();
		}

		// Token: 0x040002D2 RID: 722
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/resource/transcode/BitmapDrawableTranscoder", typeof(BitmapDrawableTranscoder));

		// Token: 0x040002D3 RID: 723
		private static Delegate cb_transcode_Lcom_bumptech_glide_load_engine_Resource_Lcom_bumptech_glide_load_Options_;
	}
}
