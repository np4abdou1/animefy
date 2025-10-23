using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Request.Transition
{
	// Token: 0x020000A9 RID: 169
	[Register("com/bumptech/glide/request/transition/ViewTransition", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"R"
	})]
	public class ViewTransition : Java.Lang.Object, ITransition, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x060008BA RID: 2234 RVA: 0x0001AF94 File Offset: 0x00019194
		internal static IntPtr class_ref
		{
			get
			{
				return ViewTransition._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x060008BB RID: 2235 RVA: 0x0001AFB8 File Offset: 0x000191B8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ViewTransition._members;
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x060008BC RID: 2236 RVA: 0x0001AFC0 File Offset: 0x000191C0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ViewTransition._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x060008BD RID: 2237 RVA: 0x0001AFE4 File Offset: 0x000191E4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ViewTransition._members.ManagedPeerType;
			}
		}

		// Token: 0x060008BE RID: 2238 RVA: 0x0001AFF0 File Offset: 0x000191F0
		protected ViewTransition(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060008BF RID: 2239 RVA: 0x0001AFFA File Offset: 0x000191FA
		private static Delegate GetTransition_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_ViewAdapter_Handler()
		{
			if (ViewTransition.cb_transition_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_ViewAdapter_ == null)
			{
				ViewTransition.cb_transition_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_ViewAdapter_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_Z(ViewTransition.n_Transition_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_ViewAdapter_));
			}
			return ViewTransition.cb_transition_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_ViewAdapter_;
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x0001B020 File Offset: 0x00019220
		private static bool n_Transition_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_ViewAdapter_(IntPtr jnienv, IntPtr native__this, IntPtr native_current, IntPtr native_adapter)
		{
			ViewTransition @object = Java.Lang.Object.GetObject<ViewTransition>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_current, JniHandleOwnership.DoNotTransfer);
			ITransitionViewAdapter object3 = Java.Lang.Object.GetObject<ITransitionViewAdapter>(native_adapter, JniHandleOwnership.DoNotTransfer);
			return @object.Transition(object2, object3);
		}

		// Token: 0x060008C1 RID: 2241 RVA: 0x0001B04C File Offset: 0x0001924C
		[Register("transition", "(Ljava/lang/Object;Lcom/bumptech/glide/request/transition/Transition$ViewAdapter;)Z", "GetTransition_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_ViewAdapter_Handler")]
		public unsafe virtual bool Transition(Java.Lang.Object current, ITransitionViewAdapter adapter)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(current);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((adapter == null) ? IntPtr.Zero : ((Java.Lang.Object)adapter).Handle);
				result = ViewTransition._members.InstanceMethods.InvokeVirtualBooleanMethod("transition.(Ljava/lang/Object;Lcom/bumptech/glide/request/transition/Transition$ViewAdapter;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(current);
				GC.KeepAlive(adapter);
			}
			return result;
		}

		// Token: 0x04000228 RID: 552
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/request/transition/ViewTransition", typeof(ViewTransition));

		// Token: 0x04000229 RID: 553
		private static Delegate cb_transition_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_ViewAdapter_;
	}
}
