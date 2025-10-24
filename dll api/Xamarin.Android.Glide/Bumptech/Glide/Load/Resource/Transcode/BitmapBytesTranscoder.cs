using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Graphics;
using Android.Runtime;
using Bumptech.Glide.Load.Engine;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Resource.Transcode
{
	// Token: 0x020000E5 RID: 229
	[Register("com/bumptech/glide/load/resource/transcode/BitmapBytesTranscoder", DoNotGenerateAcw = true)]
	public class BitmapBytesTranscoder : Java.Lang.Object, IResourceTranscoder, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06000B74 RID: 2932 RVA: 0x00023ACC File Offset: 0x00021CCC
		internal static IntPtr class_ref
		{
			get
			{
				return BitmapBytesTranscoder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06000B75 RID: 2933 RVA: 0x00023AF0 File Offset: 0x00021CF0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BitmapBytesTranscoder._members;
			}
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06000B76 RID: 2934 RVA: 0x00023AF8 File Offset: 0x00021CF8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BitmapBytesTranscoder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06000B77 RID: 2935 RVA: 0x00023B1C File Offset: 0x00021D1C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BitmapBytesTranscoder._members.ManagedPeerType;
			}
		}

		// Token: 0x06000B78 RID: 2936 RVA: 0x00023B28 File Offset: 0x00021D28
		protected BitmapBytesTranscoder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000B79 RID: 2937 RVA: 0x00023B34 File Offset: 0x00021D34
		[Register(".ctor", "()V", "")]
		public BitmapBytesTranscoder() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(BitmapBytesTranscoder._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			BitmapBytesTranscoder._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000B7A RID: 2938 RVA: 0x00023BA4 File Offset: 0x00021DA4
		[Register(".ctor", "(Landroid/graphics/Bitmap$CompressFormat;I)V", "")]
		public unsafe BitmapBytesTranscoder(Bitmap.CompressFormat compressFormat, int quality) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((compressFormat == null) ? IntPtr.Zero : compressFormat.Handle);
				ptr[1] = new JniArgumentValue(quality);
				base.SetHandle(BitmapBytesTranscoder._members.InstanceMethods.StartCreateInstance("(Landroid/graphics/Bitmap$CompressFormat;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				BitmapBytesTranscoder._members.InstanceMethods.FinishCreateInstance("(Landroid/graphics/Bitmap$CompressFormat;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(compressFormat);
			}
		}

		// Token: 0x06000B7B RID: 2939 RVA: 0x00023C64 File Offset: 0x00021E64
		private static Delegate GetTranscode_Lcom_bumptech_glide_load_engine_Resource_Lcom_bumptech_glide_load_Options_Handler()
		{
			if (BitmapBytesTranscoder.cb_transcode_Lcom_bumptech_glide_load_engine_Resource_Lcom_bumptech_glide_load_Options_ == null)
			{
				BitmapBytesTranscoder.cb_transcode_Lcom_bumptech_glide_load_engine_Resource_Lcom_bumptech_glide_load_Options_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(BitmapBytesTranscoder.n_Transcode_Lcom_bumptech_glide_load_engine_Resource_Lcom_bumptech_glide_load_Options_));
			}
			return BitmapBytesTranscoder.cb_transcode_Lcom_bumptech_glide_load_engine_Resource_Lcom_bumptech_glide_load_Options_;
		}

		// Token: 0x06000B7C RID: 2940 RVA: 0x00023C88 File Offset: 0x00021E88
		private static IntPtr n_Transcode_Lcom_bumptech_glide_load_engine_Resource_Lcom_bumptech_glide_load_Options_(IntPtr jnienv, IntPtr native__this, IntPtr native_toTranscode, IntPtr native_options)
		{
			BitmapBytesTranscoder @object = Java.Lang.Object.GetObject<BitmapBytesTranscoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IResource object2 = Java.Lang.Object.GetObject<IResource>(native_toTranscode, JniHandleOwnership.DoNotTransfer);
			Options object3 = Java.Lang.Object.GetObject<Options>(native_options, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Transcode(object2, object3));
		}

		// Token: 0x06000B7D RID: 2941 RVA: 0x00023CBC File Offset: 0x00021EBC
		[Register("transcode", "(Lcom/bumptech/glide/load/engine/Resource;Lcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/engine/Resource;", "GetTranscode_Lcom_bumptech_glide_load_engine_Resource_Lcom_bumptech_glide_load_Options_Handler")]
		public unsafe virtual IResource Transcode(IResource toTranscode, Options options)
		{
			IResource @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((toTranscode == null) ? IntPtr.Zero : ((Java.Lang.Object)toTranscode).Handle);
				ptr[1] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				@object = Java.Lang.Object.GetObject<IResource>(BitmapBytesTranscoder._members.InstanceMethods.InvokeVirtualObjectMethod("transcode.(Lcom/bumptech/glide/load/engine/Resource;Lcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/engine/Resource;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(toTranscode);
				GC.KeepAlive(options);
			}
			return @object;
		}

		// Token: 0x06000B7E RID: 2942 RVA: 0x00023D5C File Offset: 0x00021F5C
		IResource IResourceTranscoder.Transcode(IResource p0, Options p1)
		{
			return this.Transcode(p0.JavaCast<IResource>(), p1).JavaCast<IResource>();
		}

		// Token: 0x040002D0 RID: 720
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/resource/transcode/BitmapBytesTranscoder", typeof(BitmapBytesTranscoder));

		// Token: 0x040002D1 RID: 721
		private static Delegate cb_transcode_Lcom_bumptech_glide_load_engine_Resource_Lcom_bumptech_glide_load_Options_;
	}
}
