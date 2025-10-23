using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Android.Widget;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Impl.Sdk.NativeAd
{
	// Token: 0x0200013F RID: 319
	[Register("com/applovin/impl/sdk/nativeAd/AppLovinMediaView", DoNotGenerateAcw = true)]
	public class AppLovinMediaView : FrameLayout
	{
		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06000F2E RID: 3886 RVA: 0x0002CCDC File Offset: 0x0002AEDC
		internal static IntPtr class_ref
		{
			get
			{
				return AppLovinMediaView._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06000F2F RID: 3887 RVA: 0x0002CD00 File Offset: 0x0002AF00
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AppLovinMediaView._members;
			}
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06000F30 RID: 3888 RVA: 0x0002CD08 File Offset: 0x0002AF08
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AppLovinMediaView._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06000F31 RID: 3889 RVA: 0x0002CD2C File Offset: 0x0002AF2C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AppLovinMediaView._members.ManagedPeerType;
			}
		}

		// Token: 0x06000F32 RID: 3890 RVA: 0x00013EEC File Offset: 0x000120EC
		protected AppLovinMediaView(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000F33 RID: 3891 RVA: 0x0002CD38 File Offset: 0x0002AF38
		private static Delegate GetGetAspectRatioHandler()
		{
			if (AppLovinMediaView.cb_getAspectRatio == null)
			{
				AppLovinMediaView.cb_getAspectRatio = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_F(AppLovinMediaView.n_GetAspectRatio));
			}
			return AppLovinMediaView.cb_getAspectRatio;
		}

		// Token: 0x06000F34 RID: 3892 RVA: 0x0002CD5C File Offset: 0x0002AF5C
		private static float n_GetAspectRatio(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AppLovinMediaView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AspectRatio;
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06000F35 RID: 3893 RVA: 0x0002CD6B File Offset: 0x0002AF6B
		public virtual float AspectRatio
		{
			[Register("getAspectRatio", "()F", "GetGetAspectRatioHandler")]
			get
			{
				return AppLovinMediaView._members.InstanceMethods.InvokeVirtualSingleMethod("getAspectRatio.()F", this, null);
			}
		}

		// Token: 0x06000F36 RID: 3894 RVA: 0x0002CD84 File Offset: 0x0002AF84
		private static Delegate GetDestroyHandler()
		{
			if (AppLovinMediaView.cb_destroy == null)
			{
				AppLovinMediaView.cb_destroy = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(AppLovinMediaView.n_Destroy));
			}
			return AppLovinMediaView.cb_destroy;
		}

		// Token: 0x06000F37 RID: 3895 RVA: 0x0002CDA8 File Offset: 0x0002AFA8
		private static void n_Destroy(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<AppLovinMediaView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Destroy();
		}

		// Token: 0x06000F38 RID: 3896 RVA: 0x0002CDB7 File Offset: 0x0002AFB7
		[Register("destroy", "()V", "GetDestroyHandler")]
		public virtual void Destroy()
		{
			AppLovinMediaView._members.InstanceMethods.InvokeVirtualVoidMethod("destroy.()V", this, null);
		}

		// Token: 0x040004FF RID: 1279
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/impl/sdk/nativeAd/AppLovinMediaView", typeof(AppLovinMediaView));

		// Token: 0x04000500 RID: 1280
		private static Delegate cb_getAspectRatio;

		// Token: 0x04000501 RID: 1281
		private static Delegate cb_destroy;
	}
}
