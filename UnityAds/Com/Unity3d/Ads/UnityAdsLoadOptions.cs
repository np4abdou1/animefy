using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Ads
{
	// Token: 0x020002DD RID: 733
	[Register("com/unity3d/ads/UnityAdsLoadOptions", DoNotGenerateAcw = true)]
	public class UnityAdsLoadOptions : UnityAdsBaseOptions
	{
		// Token: 0x17000F65 RID: 3941
		// (get) Token: 0x060028A9 RID: 10409 RVA: 0x000692F0 File Offset: 0x000674F0
		internal new static IntPtr class_ref
		{
			get
			{
				return UnityAdsLoadOptions._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000F66 RID: 3942
		// (get) Token: 0x060028AA RID: 10410 RVA: 0x00069314 File Offset: 0x00067514
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return UnityAdsLoadOptions._members;
			}
		}

		// Token: 0x17000F67 RID: 3943
		// (get) Token: 0x060028AB RID: 10411 RVA: 0x0006931C File Offset: 0x0006751C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return UnityAdsLoadOptions._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000F68 RID: 3944
		// (get) Token: 0x060028AC RID: 10412 RVA: 0x00069340 File Offset: 0x00067540
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return UnityAdsLoadOptions._members.ManagedPeerType;
			}
		}

		// Token: 0x060028AD RID: 10413 RVA: 0x0006934C File Offset: 0x0006754C
		protected UnityAdsLoadOptions(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060028AE RID: 10414 RVA: 0x00069358 File Offset: 0x00067558
		[Register(".ctor", "()V", "")]
		public UnityAdsLoadOptions() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(UnityAdsLoadOptions._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			UnityAdsLoadOptions._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060028AF RID: 10415 RVA: 0x000693C6 File Offset: 0x000675C6
		private static Delegate GetSetAdMarkup_Ljava_lang_String_Handler()
		{
			if (UnityAdsLoadOptions.cb_setAdMarkup_Ljava_lang_String_ == null)
			{
				UnityAdsLoadOptions.cb_setAdMarkup_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(UnityAdsLoadOptions.n_SetAdMarkup_Ljava_lang_String_));
			}
			return UnityAdsLoadOptions.cb_setAdMarkup_Ljava_lang_String_;
		}

		// Token: 0x060028B0 RID: 10416 RVA: 0x000693EC File Offset: 0x000675EC
		private static void n_SetAdMarkup_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_adMarkup)
		{
			UnityAdsLoadOptions @object = Java.Lang.Object.GetObject<UnityAdsLoadOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_adMarkup, JniHandleOwnership.DoNotTransfer);
			@object.SetAdMarkup(@string);
		}

		// Token: 0x060028B1 RID: 10417 RVA: 0x00069410 File Offset: 0x00067610
		[Register("setAdMarkup", "(Ljava/lang/String;)V", "GetSetAdMarkup_Ljava_lang_String_Handler")]
		public unsafe virtual void SetAdMarkup(string adMarkup)
		{
			IntPtr intPtr = JNIEnv.NewString(adMarkup);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				UnityAdsLoadOptions._members.InstanceMethods.InvokeVirtualVoidMethod("setAdMarkup.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x04000843 RID: 2115
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/ads/UnityAdsLoadOptions", typeof(UnityAdsLoadOptions));

		// Token: 0x04000844 RID: 2116
		private static Delegate cb_setAdMarkup_Ljava_lang_String_;
	}
}
