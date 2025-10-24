using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Bumptech.Glide.Load.Engine;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Resource.Transcode
{
	// Token: 0x020000EA RID: 234
	[Register("com/bumptech/glide/load/resource/transcode/ResourceTranscoder", DoNotGenerateAcw = true)]
	internal class IResourceTranscoderInvoker : Java.Lang.Object, IResourceTranscoder, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06000BA2 RID: 2978 RVA: 0x000245A0 File Offset: 0x000227A0
		private static IntPtr java_class_ref
		{
			get
			{
				return IResourceTranscoderInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06000BA3 RID: 2979 RVA: 0x000245C4 File Offset: 0x000227C4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IResourceTranscoderInvoker._members;
			}
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06000BA4 RID: 2980 RVA: 0x000245CB File Offset: 0x000227CB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06000BA5 RID: 2981 RVA: 0x000245D3 File Offset: 0x000227D3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IResourceTranscoderInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000BA6 RID: 2982 RVA: 0x000245DF File Offset: 0x000227DF
		public static IResourceTranscoder GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IResourceTranscoder>(handle, transfer);
		}

		// Token: 0x06000BA7 RID: 2983 RVA: 0x000245E8 File Offset: 0x000227E8
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IResourceTranscoderInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.bumptech.glide.load.resource.transcode.ResourceTranscoder'.");
			}
			return handle;
		}

		// Token: 0x06000BA8 RID: 2984 RVA: 0x00024613 File Offset: 0x00022813
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000BA9 RID: 2985 RVA: 0x00024644 File Offset: 0x00022844
		public IResourceTranscoderInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IResourceTranscoderInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000BAA RID: 2986 RVA: 0x0002467C File Offset: 0x0002287C
		private static Delegate GetTranscode_Lcom_bumptech_glide_load_engine_Resource_Lcom_bumptech_glide_load_Options_Handler()
		{
			if (IResourceTranscoderInvoker.cb_transcode_Lcom_bumptech_glide_load_engine_Resource_Lcom_bumptech_glide_load_Options_ == null)
			{
				IResourceTranscoderInvoker.cb_transcode_Lcom_bumptech_glide_load_engine_Resource_Lcom_bumptech_glide_load_Options_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(IResourceTranscoderInvoker.n_Transcode_Lcom_bumptech_glide_load_engine_Resource_Lcom_bumptech_glide_load_Options_));
			}
			return IResourceTranscoderInvoker.cb_transcode_Lcom_bumptech_glide_load_engine_Resource_Lcom_bumptech_glide_load_Options_;
		}

		// Token: 0x06000BAB RID: 2987 RVA: 0x000246A0 File Offset: 0x000228A0
		private static IntPtr n_Transcode_Lcom_bumptech_glide_load_engine_Resource_Lcom_bumptech_glide_load_Options_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IResourceTranscoder @object = Java.Lang.Object.GetObject<IResourceTranscoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IResource object2 = Java.Lang.Object.GetObject<IResource>(native_p0, JniHandleOwnership.DoNotTransfer);
			Options object3 = Java.Lang.Object.GetObject<Options>(native_p1, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Transcode(object2, object3));
		}

		// Token: 0x06000BAC RID: 2988 RVA: 0x000246D4 File Offset: 0x000228D4
		public unsafe IResource Transcode(IResource p0, Options p1)
		{
			if (this.id_transcode_Lcom_bumptech_glide_load_engine_Resource_Lcom_bumptech_glide_load_Options_ == IntPtr.Zero)
			{
				this.id_transcode_Lcom_bumptech_glide_load_engine_Resource_Lcom_bumptech_glide_load_Options_ = JNIEnv.GetMethodID(this.class_ref, "transcode", "(Lcom/bumptech/glide/load/engine/Resource;Lcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/engine/Resource;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
			return Java.Lang.Object.GetObject<IResource>(JNIEnv.CallObjectMethod(base.Handle, this.id_transcode_Lcom_bumptech_glide_load_engine_Resource_Lcom_bumptech_glide_load_Options_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040002D7 RID: 727
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/resource/transcode/ResourceTranscoder", typeof(IResourceTranscoderInvoker));

		// Token: 0x040002D8 RID: 728
		private IntPtr class_ref;

		// Token: 0x040002D9 RID: 729
		private static Delegate cb_transcode_Lcom_bumptech_glide_load_engine_Resource_Lcom_bumptech_glide_load_Options_;

		// Token: 0x040002DA RID: 730
		private IntPtr id_transcode_Lcom_bumptech_glide_load_engine_Resource_Lcom_bumptech_glide_load_Options_;
	}
}
