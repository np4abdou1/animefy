using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Applovin.Sdk;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Impl.Sdk.Network
{
	// Token: 0x0200013E RID: 318
	[Register("com/applovin/impl/sdk/network/PostbackServiceImpl", DoNotGenerateAcw = true)]
	public class PostbackServiceImpl : Java.Lang.Object, IAppLovinPostbackService, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06000F25 RID: 3877 RVA: 0x0002CB8C File Offset: 0x0002AD8C
		internal static IntPtr class_ref
		{
			get
			{
				return PostbackServiceImpl._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06000F26 RID: 3878 RVA: 0x0002CBB0 File Offset: 0x0002ADB0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return PostbackServiceImpl._members;
			}
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06000F27 RID: 3879 RVA: 0x0002CBB8 File Offset: 0x0002ADB8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return PostbackServiceImpl._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06000F28 RID: 3880 RVA: 0x0002CBDC File Offset: 0x0002ADDC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return PostbackServiceImpl._members.ManagedPeerType;
			}
		}

		// Token: 0x06000F29 RID: 3881 RVA: 0x000021F0 File Offset: 0x000003F0
		protected PostbackServiceImpl(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000F2A RID: 3882 RVA: 0x0002CBE8 File Offset: 0x0002ADE8
		private static Delegate GetDispatchPostbackAsync_Ljava_lang_String_Lcom_applovin_sdk_AppLovinPostbackListener_Handler()
		{
			if (PostbackServiceImpl.cb_dispatchPostbackAsync_Ljava_lang_String_Lcom_applovin_sdk_AppLovinPostbackListener_ == null)
			{
				PostbackServiceImpl.cb_dispatchPostbackAsync_Ljava_lang_String_Lcom_applovin_sdk_AppLovinPostbackListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(PostbackServiceImpl.n_DispatchPostbackAsync_Ljava_lang_String_Lcom_applovin_sdk_AppLovinPostbackListener_));
			}
			return PostbackServiceImpl.cb_dispatchPostbackAsync_Ljava_lang_String_Lcom_applovin_sdk_AppLovinPostbackListener_;
		}

		// Token: 0x06000F2B RID: 3883 RVA: 0x0002CC0C File Offset: 0x0002AE0C
		private static void n_DispatchPostbackAsync_Ljava_lang_String_Lcom_applovin_sdk_AppLovinPostbackListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			PostbackServiceImpl @object = Java.Lang.Object.GetObject<PostbackServiceImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			IAppLovinPostbackListener object2 = Java.Lang.Object.GetObject<IAppLovinPostbackListener>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.DispatchPostbackAsync(@string, object2);
		}

		// Token: 0x06000F2C RID: 3884 RVA: 0x0002CC38 File Offset: 0x0002AE38
		[Register("dispatchPostbackAsync", "(Ljava/lang/String;Lcom/applovin/sdk/AppLovinPostbackListener;)V", "GetDispatchPostbackAsync_Ljava_lang_String_Lcom_applovin_sdk_AppLovinPostbackListener_Handler")]
		public unsafe virtual void DispatchPostbackAsync(string p0, IAppLovinPostbackListener p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
				PostbackServiceImpl._members.InstanceMethods.InvokeVirtualVoidMethod("dispatchPostbackAsync.(Ljava/lang/String;Lcom/applovin/sdk/AppLovinPostbackListener;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x040004FD RID: 1277
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/impl/sdk/network/PostbackServiceImpl", typeof(PostbackServiceImpl));

		// Token: 0x040004FE RID: 1278
		private static Delegate cb_dispatchPostbackAsync_Ljava_lang_String_Lcom_applovin_sdk_AppLovinPostbackListener_;
	}
}
