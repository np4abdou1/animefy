using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Bumptech.Glide.Load.Engine;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load
{
	// Token: 0x020000D8 RID: 216
	[Register("com/bumptech/glide/load/ResourceDecoder", DoNotGenerateAcw = true)]
	internal class IResourceDecoderInvoker : Java.Lang.Object, IResourceDecoder, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06000AEA RID: 2794 RVA: 0x00021DE4 File Offset: 0x0001FFE4
		private static IntPtr java_class_ref
		{
			get
			{
				return IResourceDecoderInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06000AEB RID: 2795 RVA: 0x00021E08 File Offset: 0x00020008
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IResourceDecoderInvoker._members;
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06000AEC RID: 2796 RVA: 0x00021E0F File Offset: 0x0002000F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06000AED RID: 2797 RVA: 0x00021E17 File Offset: 0x00020017
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IResourceDecoderInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000AEE RID: 2798 RVA: 0x00021E23 File Offset: 0x00020023
		public static IResourceDecoder GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IResourceDecoder>(handle, transfer);
		}

		// Token: 0x06000AEF RID: 2799 RVA: 0x00021E2C File Offset: 0x0002002C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IResourceDecoderInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.bumptech.glide.load.ResourceDecoder'.");
			}
			return handle;
		}

		// Token: 0x06000AF0 RID: 2800 RVA: 0x00021E57 File Offset: 0x00020057
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000AF1 RID: 2801 RVA: 0x00021E88 File Offset: 0x00020088
		public IResourceDecoderInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IResourceDecoderInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000AF2 RID: 2802 RVA: 0x00021EC0 File Offset: 0x000200C0
		private static Delegate GetDecode_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_Handler()
		{
			if (IResourceDecoderInvoker.cb_decode_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_ == null)
			{
				IResourceDecoderInvoker.cb_decode_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIIL_L(IResourceDecoderInvoker.n_Decode_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_));
			}
			return IResourceDecoderInvoker.cb_decode_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_;
		}

		// Token: 0x06000AF3 RID: 2803 RVA: 0x00021EE4 File Offset: 0x000200E4
		private static IntPtr n_Decode_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, IntPtr native_p3)
		{
			IResourceDecoder @object = Java.Lang.Object.GetObject<IResourceDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			Options object3 = Java.Lang.Object.GetObject<Options>(native_p3, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Decode(object2, p1, p2, object3));
		}

		// Token: 0x06000AF4 RID: 2804 RVA: 0x00021F1C File Offset: 0x0002011C
		public unsafe IResource Decode(Java.Lang.Object p0, int p1, int p2, Options p3)
		{
			if (this.id_decode_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_ == IntPtr.Zero)
			{
				this.id_decode_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_ = JNIEnv.GetMethodID(this.class_ref, "decode", "(Ljava/lang/Object;IILcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/engine/Resource;");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(p1);
			ptr[2] = new JValue(p2);
			ptr[3] = new JValue((p3 == null) ? IntPtr.Zero : p3.Handle);
			IResource @object = Java.Lang.Object.GetObject<IResource>(JNIEnv.CallObjectMethod(base.Handle, this.id_decode_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x06000AF5 RID: 2805 RVA: 0x00021FE3 File Offset: 0x000201E3
		private static Delegate GetHandles_Ljava_lang_Object_Lcom_bumptech_glide_load_Options_Handler()
		{
			if (IResourceDecoderInvoker.cb_handles_Ljava_lang_Object_Lcom_bumptech_glide_load_Options_ == null)
			{
				IResourceDecoderInvoker.cb_handles_Ljava_lang_Object_Lcom_bumptech_glide_load_Options_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_Z(IResourceDecoderInvoker.n_Handles_Ljava_lang_Object_Lcom_bumptech_glide_load_Options_));
			}
			return IResourceDecoderInvoker.cb_handles_Ljava_lang_Object_Lcom_bumptech_glide_load_Options_;
		}

		// Token: 0x06000AF6 RID: 2806 RVA: 0x00022008 File Offset: 0x00020208
		private static bool n_Handles_Ljava_lang_Object_Lcom_bumptech_glide_load_Options_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IResourceDecoder @object = Java.Lang.Object.GetObject<IResourceDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			Options object3 = Java.Lang.Object.GetObject<Options>(native_p1, JniHandleOwnership.DoNotTransfer);
			return @object.Handles(object2, object3);
		}

		// Token: 0x06000AF7 RID: 2807 RVA: 0x00022034 File Offset: 0x00020234
		public unsafe bool Handles(Java.Lang.Object p0, Options p1)
		{
			if (this.id_handles_Ljava_lang_Object_Lcom_bumptech_glide_load_Options_ == IntPtr.Zero)
			{
				this.id_handles_Ljava_lang_Object_Lcom_bumptech_glide_load_Options_ = JNIEnv.GetMethodID(this.class_ref, "handles", "(Ljava/lang/Object;Lcom/bumptech/glide/load/Options;)Z");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
			bool result = JNIEnv.CallBooleanMethod(base.Handle, this.id_handles_Ljava_lang_Object_Lcom_bumptech_glide_load_Options_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			return result;
		}

		// Token: 0x040002AF RID: 687
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/ResourceDecoder", typeof(IResourceDecoderInvoker));

		// Token: 0x040002B0 RID: 688
		private IntPtr class_ref;

		// Token: 0x040002B1 RID: 689
		private static Delegate cb_decode_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_;

		// Token: 0x040002B2 RID: 690
		private IntPtr id_decode_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_;

		// Token: 0x040002B3 RID: 691
		private static Delegate cb_handles_Ljava_lang_Object_Lcom_bumptech_glide_load_Options_;

		// Token: 0x040002B4 RID: 692
		private IntPtr id_handles_Ljava_lang_Object_Lcom_bumptech_glide_load_Options_;
	}
}
