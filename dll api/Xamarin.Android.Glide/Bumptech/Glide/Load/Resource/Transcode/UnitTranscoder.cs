using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Bumptech.Glide.Load.Engine;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Resource.Transcode
{
	// Token: 0x020000EC RID: 236
	[Register("com/bumptech/glide/load/resource/transcode/UnitTranscoder", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"Z"
	})]
	public class UnitTranscoder : Java.Lang.Object, IResourceTranscoder, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06000BBE RID: 3006 RVA: 0x00024B84 File Offset: 0x00022D84
		internal static IntPtr class_ref
		{
			get
			{
				return UnitTranscoder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06000BBF RID: 3007 RVA: 0x00024BA8 File Offset: 0x00022DA8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return UnitTranscoder._members;
			}
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06000BC0 RID: 3008 RVA: 0x00024BB0 File Offset: 0x00022DB0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return UnitTranscoder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06000BC1 RID: 3009 RVA: 0x00024BD4 File Offset: 0x00022DD4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return UnitTranscoder._members.ManagedPeerType;
			}
		}

		// Token: 0x06000BC2 RID: 3010 RVA: 0x00024BE0 File Offset: 0x00022DE0
		protected UnitTranscoder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000BC3 RID: 3011 RVA: 0x00024BEC File Offset: 0x00022DEC
		[Register(".ctor", "()V", "")]
		public UnitTranscoder() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(UnitTranscoder._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			UnitTranscoder._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000BC4 RID: 3012 RVA: 0x00024C5C File Offset: 0x00022E5C
		[Register("get", "()Lcom/bumptech/glide/load/resource/transcode/ResourceTranscoder;", "")]
		[JavaTypeParameters(new string[]
		{
			"Z"
		})]
		public static IResourceTranscoder Get()
		{
			return Java.Lang.Object.GetObject<IResourceTranscoder>(UnitTranscoder._members.StaticMethods.InvokeObjectMethod("get.()Lcom/bumptech/glide/load/resource/transcode/ResourceTranscoder;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000BC5 RID: 3013 RVA: 0x00024C8D File Offset: 0x00022E8D
		private static Delegate GetTranscode_Lcom_bumptech_glide_load_engine_Resource_Lcom_bumptech_glide_load_Options_Handler()
		{
			if (UnitTranscoder.cb_transcode_Lcom_bumptech_glide_load_engine_Resource_Lcom_bumptech_glide_load_Options_ == null)
			{
				UnitTranscoder.cb_transcode_Lcom_bumptech_glide_load_engine_Resource_Lcom_bumptech_glide_load_Options_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(UnitTranscoder.n_Transcode_Lcom_bumptech_glide_load_engine_Resource_Lcom_bumptech_glide_load_Options_));
			}
			return UnitTranscoder.cb_transcode_Lcom_bumptech_glide_load_engine_Resource_Lcom_bumptech_glide_load_Options_;
		}

		// Token: 0x06000BC6 RID: 3014 RVA: 0x00024CB4 File Offset: 0x00022EB4
		private static IntPtr n_Transcode_Lcom_bumptech_glide_load_engine_Resource_Lcom_bumptech_glide_load_Options_(IntPtr jnienv, IntPtr native__this, IntPtr native_toTranscode, IntPtr native_options)
		{
			UnitTranscoder @object = Java.Lang.Object.GetObject<UnitTranscoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IResource object2 = Java.Lang.Object.GetObject<IResource>(native_toTranscode, JniHandleOwnership.DoNotTransfer);
			Options object3 = Java.Lang.Object.GetObject<Options>(native_options, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Transcode(object2, object3));
		}

		// Token: 0x06000BC7 RID: 3015 RVA: 0x00024CE8 File Offset: 0x00022EE8
		[Register("transcode", "(Lcom/bumptech/glide/load/engine/Resource;Lcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/engine/Resource;", "GetTranscode_Lcom_bumptech_glide_load_engine_Resource_Lcom_bumptech_glide_load_Options_Handler")]
		public unsafe virtual IResource Transcode(IResource toTranscode, Options options)
		{
			IResource @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((toTranscode == null) ? IntPtr.Zero : ((Java.Lang.Object)toTranscode).Handle);
				ptr[1] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				@object = Java.Lang.Object.GetObject<IResource>(UnitTranscoder._members.InstanceMethods.InvokeVirtualObjectMethod("transcode.(Lcom/bumptech/glide/load/engine/Resource;Lcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/engine/Resource;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(toTranscode);
				GC.KeepAlive(options);
			}
			return @object;
		}

		// Token: 0x040002DF RID: 735
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/resource/transcode/UnitTranscoder", typeof(UnitTranscoder));

		// Token: 0x040002E0 RID: 736
		private static Delegate cb_transcode_Lcom_bumptech_glide_load_engine_Resource_Lcom_bumptech_glide_load_Options_;
	}
}
