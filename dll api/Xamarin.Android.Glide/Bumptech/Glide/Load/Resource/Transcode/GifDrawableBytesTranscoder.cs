using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Bumptech.Glide.Load.Engine;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Resource.Transcode
{
	// Token: 0x020000E8 RID: 232
	[Register("com/bumptech/glide/load/resource/transcode/GifDrawableBytesTranscoder", DoNotGenerateAcw = true)]
	public class GifDrawableBytesTranscoder : Java.Lang.Object, IResourceTranscoder, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06000B96 RID: 2966 RVA: 0x000243A0 File Offset: 0x000225A0
		internal static IntPtr class_ref
		{
			get
			{
				return GifDrawableBytesTranscoder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x06000B97 RID: 2967 RVA: 0x000243C4 File Offset: 0x000225C4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return GifDrawableBytesTranscoder._members;
			}
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06000B98 RID: 2968 RVA: 0x000243CC File Offset: 0x000225CC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return GifDrawableBytesTranscoder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06000B99 RID: 2969 RVA: 0x000243F0 File Offset: 0x000225F0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return GifDrawableBytesTranscoder._members.ManagedPeerType;
			}
		}

		// Token: 0x06000B9A RID: 2970 RVA: 0x000243FC File Offset: 0x000225FC
		protected GifDrawableBytesTranscoder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000B9B RID: 2971 RVA: 0x00024408 File Offset: 0x00022608
		[Register(".ctor", "()V", "")]
		public GifDrawableBytesTranscoder() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(GifDrawableBytesTranscoder._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			GifDrawableBytesTranscoder._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000B9C RID: 2972 RVA: 0x00024476 File Offset: 0x00022676
		private static Delegate GetTranscode_Lcom_bumptech_glide_load_engine_Resource_Lcom_bumptech_glide_load_Options_Handler()
		{
			if (GifDrawableBytesTranscoder.cb_transcode_Lcom_bumptech_glide_load_engine_Resource_Lcom_bumptech_glide_load_Options_ == null)
			{
				GifDrawableBytesTranscoder.cb_transcode_Lcom_bumptech_glide_load_engine_Resource_Lcom_bumptech_glide_load_Options_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(GifDrawableBytesTranscoder.n_Transcode_Lcom_bumptech_glide_load_engine_Resource_Lcom_bumptech_glide_load_Options_));
			}
			return GifDrawableBytesTranscoder.cb_transcode_Lcom_bumptech_glide_load_engine_Resource_Lcom_bumptech_glide_load_Options_;
		}

		// Token: 0x06000B9D RID: 2973 RVA: 0x0002449C File Offset: 0x0002269C
		private static IntPtr n_Transcode_Lcom_bumptech_glide_load_engine_Resource_Lcom_bumptech_glide_load_Options_(IntPtr jnienv, IntPtr native__this, IntPtr native_toTranscode, IntPtr native_options)
		{
			GifDrawableBytesTranscoder @object = Java.Lang.Object.GetObject<GifDrawableBytesTranscoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IResource object2 = Java.Lang.Object.GetObject<IResource>(native_toTranscode, JniHandleOwnership.DoNotTransfer);
			Options object3 = Java.Lang.Object.GetObject<Options>(native_options, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Transcode(object2, object3));
		}

		// Token: 0x06000B9E RID: 2974 RVA: 0x000244D0 File Offset: 0x000226D0
		[Register("transcode", "(Lcom/bumptech/glide/load/engine/Resource;Lcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/engine/Resource;", "GetTranscode_Lcom_bumptech_glide_load_engine_Resource_Lcom_bumptech_glide_load_Options_Handler")]
		public unsafe virtual IResource Transcode(IResource toTranscode, Options options)
		{
			IResource @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((toTranscode == null) ? IntPtr.Zero : ((Java.Lang.Object)toTranscode).Handle);
				ptr[1] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				@object = Java.Lang.Object.GetObject<IResource>(GifDrawableBytesTranscoder._members.InstanceMethods.InvokeVirtualObjectMethod("transcode.(Lcom/bumptech/glide/load/engine/Resource;Lcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/engine/Resource;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(toTranscode);
				GC.KeepAlive(options);
			}
			return @object;
		}

		// Token: 0x06000B9F RID: 2975 RVA: 0x00024570 File Offset: 0x00022770
		IResource IResourceTranscoder.Transcode(IResource p0, Options p1)
		{
			return this.Transcode(p0.JavaCast<IResource>(), p1).JavaCast<IResource>();
		}

		// Token: 0x040002D5 RID: 725
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/resource/transcode/GifDrawableBytesTranscoder", typeof(GifDrawableBytesTranscoder));

		// Token: 0x040002D6 RID: 726
		private static Delegate cb_transcode_Lcom_bumptech_glide_load_engine_Resource_Lcom_bumptech_glide_load_Options_;
	}
}
