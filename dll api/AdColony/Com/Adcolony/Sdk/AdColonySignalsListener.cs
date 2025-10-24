using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Adcolony.Sdk
{
	// Token: 0x02000048 RID: 72
	[Register("com/adcolony/sdk/AdColonySignalsListener", DoNotGenerateAcw = true)]
	public abstract class AdColonySignalsListener : Java.Lang.Object
	{
		// Token: 0x170000FA RID: 250
		// (get) Token: 0x0600038C RID: 908 RVA: 0x0000B434 File Offset: 0x00009634
		internal static IntPtr class_ref
		{
			get
			{
				return AdColonySignalsListener._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x0600038D RID: 909 RVA: 0x0000B458 File Offset: 0x00009658
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AdColonySignalsListener._members;
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x0600038E RID: 910 RVA: 0x0000B460 File Offset: 0x00009660
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AdColonySignalsListener._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x0600038F RID: 911 RVA: 0x0000B484 File Offset: 0x00009684
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AdColonySignalsListener._members.ManagedPeerType;
			}
		}

		// Token: 0x06000390 RID: 912 RVA: 0x00002128 File Offset: 0x00000328
		protected AdColonySignalsListener(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000391 RID: 913 RVA: 0x0000B490 File Offset: 0x00009690
		[Register(".ctor", "()V", "")]
		public AdColonySignalsListener() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(AdColonySignalsListener._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			AdColonySignalsListener._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000392 RID: 914 RVA: 0x0000B4FE File Offset: 0x000096FE
		private static Delegate GetOnFailureHandler()
		{
			if (AdColonySignalsListener.cb_onFailure == null)
			{
				AdColonySignalsListener.cb_onFailure = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(AdColonySignalsListener.n_OnFailure));
			}
			return AdColonySignalsListener.cb_onFailure;
		}

		// Token: 0x06000393 RID: 915 RVA: 0x0000B522 File Offset: 0x00009722
		private static void n_OnFailure(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<AdColonySignalsListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnFailure();
		}

		// Token: 0x06000394 RID: 916 RVA: 0x0000B531 File Offset: 0x00009731
		[Register("onFailure", "()V", "GetOnFailureHandler")]
		public virtual void OnFailure()
		{
			AdColonySignalsListener._members.InstanceMethods.InvokeVirtualVoidMethod("onFailure.()V", this, null);
		}

		// Token: 0x06000395 RID: 917 RVA: 0x0000B54A File Offset: 0x0000974A
		private static Delegate GetOnSuccess_Ljava_lang_String_Handler()
		{
			if (AdColonySignalsListener.cb_onSuccess_Ljava_lang_String_ == null)
			{
				AdColonySignalsListener.cb_onSuccess_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AdColonySignalsListener.n_OnSuccess_Ljava_lang_String_));
			}
			return AdColonySignalsListener.cb_onSuccess_Ljava_lang_String_;
		}

		// Token: 0x06000396 RID: 918 RVA: 0x0000B570 File Offset: 0x00009770
		private static void n_OnSuccess_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			AdColonySignalsListener @object = Java.Lang.Object.GetObject<AdColonySignalsListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnSuccess(@string);
		}

		// Token: 0x06000397 RID: 919
		[Register("onSuccess", "(Ljava/lang/String;)V", "GetOnSuccess_Ljava_lang_String_Handler")]
		public abstract void OnSuccess(string p0);

		// Token: 0x040000F0 RID: 240
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/adcolony/sdk/AdColonySignalsListener", typeof(AdColonySignalsListener));

		// Token: 0x040000F1 RID: 241
		private static Delegate cb_onFailure;

		// Token: 0x040000F2 RID: 242
		private static Delegate cb_onSuccess_Ljava_lang_String_;
	}
}
