using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.Webview.Bridge;
using Com.Unity3d.Services.Core.Webview.Bridge.Invocation;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Ads.Operation
{
	// Token: 0x020001E6 RID: 486
	[Register("com/unity3d/services/ads/operation/AdOperation", DoNotGenerateAcw = true)]
	public abstract class AdOperation : Java.Lang.Object, IAdOperation, IWebViewSharedObject, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170007C6 RID: 1990
		// (get) Token: 0x06001622 RID: 5666 RVA: 0x0003F7B4 File Offset: 0x0003D9B4
		internal static IntPtr class_ref
		{
			get
			{
				return AdOperation._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007C7 RID: 1991
		// (get) Token: 0x06001623 RID: 5667 RVA: 0x0003F7D8 File Offset: 0x0003D9D8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AdOperation._members;
			}
		}

		// Token: 0x170007C8 RID: 1992
		// (get) Token: 0x06001624 RID: 5668 RVA: 0x0003F7E0 File Offset: 0x0003D9E0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AdOperation._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007C9 RID: 1993
		// (get) Token: 0x06001625 RID: 5669 RVA: 0x0003F804 File Offset: 0x0003DA04
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AdOperation._members.ManagedPeerType;
			}
		}

		// Token: 0x06001626 RID: 5670 RVA: 0x000021E8 File Offset: 0x000003E8
		protected AdOperation(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001627 RID: 5671 RVA: 0x0003F810 File Offset: 0x0003DA10
		[Register(".ctor", "(Lcom/unity3d/services/core/webview/bridge/invocation/IWebViewBridgeInvocation;Ljava/lang/String;)V", "")]
		protected unsafe AdOperation(IWebViewBridgeInvocation webViewBridgeInvocation, string invocationMethodName) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(invocationMethodName);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((webViewBridgeInvocation == null) ? IntPtr.Zero : ((Java.Lang.Object)webViewBridgeInvocation).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				base.SetHandle(AdOperation._members.InstanceMethods.StartCreateInstance("(Lcom/unity3d/services/core/webview/bridge/invocation/IWebViewBridgeInvocation;Ljava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				AdOperation._members.InstanceMethods.FinishCreateInstance("(Lcom/unity3d/services/core/webview/bridge/invocation/IWebViewBridgeInvocation;Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(webViewBridgeInvocation);
			}
		}

		// Token: 0x06001628 RID: 5672 RVA: 0x0003F8E4 File Offset: 0x0003DAE4
		private static Delegate GetInvoke_IarrayLjava_lang_Object_Handler()
		{
			if (AdOperation.cb_invoke_IarrayLjava_lang_Object_ == null)
			{
				AdOperation.cb_invoke_IarrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_V(AdOperation.n_Invoke_IarrayLjava_lang_Object_));
			}
			return AdOperation.cb_invoke_IarrayLjava_lang_Object_;
		}

		// Token: 0x06001629 RID: 5673 RVA: 0x0003F908 File Offset: 0x0003DB08
		private static void n_Invoke_IarrayLjava_lang_Object_(IntPtr jnienv, IntPtr native__this, int timeout, IntPtr native_invocationParameters)
		{
			AdOperation @object = Java.Lang.Object.GetObject<AdOperation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object[] array = (Java.Lang.Object[])JNIEnv.GetArray(native_invocationParameters, JniHandleOwnership.DoNotTransfer, typeof(Java.Lang.Object));
			@object.Invoke(timeout, array);
			if (array != null)
			{
				JNIEnv.CopyArray<Java.Lang.Object>(array, native_invocationParameters);
			}
		}

		// Token: 0x0600162A RID: 5674 RVA: 0x0003F948 File Offset: 0x0003DB48
		[Register("invoke", "(I[Ljava/lang/Object;)V", "GetInvoke_IarrayLjava_lang_Object_Handler")]
		public unsafe virtual void Invoke(int timeout, params Java.Lang.Object[] invocationParameters)
		{
			IntPtr intPtr = JNIEnv.NewArray<Java.Lang.Object>(invocationParameters);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(timeout);
				ptr[1] = new JniArgumentValue(intPtr);
				AdOperation._members.InstanceMethods.InvokeVirtualVoidMethod("invoke.(I[Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				if (invocationParameters != null)
				{
					JNIEnv.CopyArray<Java.Lang.Object>(intPtr, invocationParameters);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(invocationParameters);
			}
		}

		// Token: 0x0600162B RID: 5675 RVA: 0x0003F9C8 File Offset: 0x0003DBC8
		private static Delegate GetGetIdHandler()
		{
			if (AdOperation.cb_getId == null)
			{
				AdOperation.cb_getId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AdOperation.n_GetId));
			}
			return AdOperation.cb_getId;
		}

		// Token: 0x0600162C RID: 5676 RVA: 0x0003F9EC File Offset: 0x0003DBEC
		private static IntPtr n_GetId(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<AdOperation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Id);
		}

		// Token: 0x170007CA RID: 1994
		// (get) Token: 0x0600162D RID: 5677
		public abstract string Id { [Register("getId", "()Ljava/lang/String;", "GetGetIdHandler")] get; }

		// Token: 0x0400053B RID: 1339
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/operation/AdOperation", typeof(AdOperation));

		// Token: 0x0400053C RID: 1340
		private static Delegate cb_invoke_IarrayLjava_lang_Object_;

		// Token: 0x0400053D RID: 1341
		private static Delegate cb_getId;
	}
}
