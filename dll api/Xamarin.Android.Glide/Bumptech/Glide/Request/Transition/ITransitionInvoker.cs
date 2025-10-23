using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Request.Transition
{
	// Token: 0x020000A2 RID: 162
	[Register("com/bumptech/glide/request/transition/Transition", DoNotGenerateAcw = true)]
	internal class ITransitionInvoker : Java.Lang.Object, ITransition, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06000876 RID: 2166 RVA: 0x0001A2E8 File Offset: 0x000184E8
		private static IntPtr java_class_ref
		{
			get
			{
				return ITransitionInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06000877 RID: 2167 RVA: 0x0001A30C File Offset: 0x0001850C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ITransitionInvoker._members;
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06000878 RID: 2168 RVA: 0x0001A313 File Offset: 0x00018513
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x06000879 RID: 2169 RVA: 0x0001A31B File Offset: 0x0001851B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ITransitionInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x0001A327 File Offset: 0x00018527
		public static ITransition GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ITransition>(handle, transfer);
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x0001A330 File Offset: 0x00018530
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ITransitionInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.bumptech.glide.request.transition.Transition'.");
			}
			return handle;
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x0001A35B File Offset: 0x0001855B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x0001A38C File Offset: 0x0001858C
		public ITransitionInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ITransitionInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x0001A3C4 File Offset: 0x000185C4
		private static Delegate GetTransition_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_ViewAdapter_Handler()
		{
			if (ITransitionInvoker.cb_transition_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_ViewAdapter_ == null)
			{
				ITransitionInvoker.cb_transition_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_ViewAdapter_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_Z(ITransitionInvoker.n_Transition_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_ViewAdapter_));
			}
			return ITransitionInvoker.cb_transition_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_ViewAdapter_;
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x0001A3E8 File Offset: 0x000185E8
		private static bool n_Transition_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_ViewAdapter_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			ITransition @object = Java.Lang.Object.GetObject<ITransition>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			ITransitionViewAdapter object3 = Java.Lang.Object.GetObject<ITransitionViewAdapter>(native_p1, JniHandleOwnership.DoNotTransfer);
			return @object.Transition(object2, object3);
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x0001A414 File Offset: 0x00018614
		public unsafe bool Transition(Java.Lang.Object p0, ITransitionViewAdapter p1)
		{
			if (this.id_transition_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_ViewAdapter_ == IntPtr.Zero)
			{
				this.id_transition_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_ViewAdapter_ = JNIEnv.GetMethodID(this.class_ref, "transition", "(Ljava/lang/Object;Lcom/bumptech/glide/request/transition/Transition$ViewAdapter;)Z");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
			bool result = JNIEnv.CallBooleanMethod(base.Handle, this.id_transition_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_ViewAdapter_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			return result;
		}

		// Token: 0x04000218 RID: 536
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/request/transition/Transition", typeof(ITransitionInvoker));

		// Token: 0x04000219 RID: 537
		private IntPtr class_ref;

		// Token: 0x0400021A RID: 538
		private static Delegate cb_transition_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_ViewAdapter_;

		// Token: 0x0400021B RID: 539
		private IntPtr id_transition_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_ViewAdapter_;
	}
}
