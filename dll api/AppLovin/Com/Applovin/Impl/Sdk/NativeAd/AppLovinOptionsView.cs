using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Impl.Sdk.NativeAd
{
	// Token: 0x02000145 RID: 325
	[Register("com/applovin/impl/sdk/nativeAd/AppLovinOptionsView", DoNotGenerateAcw = true)]
	public class AppLovinOptionsView : FrameLayout, View.IOnClickListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06000FCF RID: 4047 RVA: 0x0002E668 File Offset: 0x0002C868
		internal static IntPtr class_ref
		{
			get
			{
				return AppLovinOptionsView._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06000FD0 RID: 4048 RVA: 0x0002E68C File Offset: 0x0002C88C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AppLovinOptionsView._members;
			}
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06000FD1 RID: 4049 RVA: 0x0002E694 File Offset: 0x0002C894
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AppLovinOptionsView._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06000FD2 RID: 4050 RVA: 0x0002E6B8 File Offset: 0x0002C8B8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AppLovinOptionsView._members.ManagedPeerType;
			}
		}

		// Token: 0x06000FD3 RID: 4051 RVA: 0x00013EEC File Offset: 0x000120EC
		protected AppLovinOptionsView(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000FD4 RID: 4052 RVA: 0x0002E6C4 File Offset: 0x0002C8C4
		private static Delegate GetDestroyHandler()
		{
			if (AppLovinOptionsView.cb_destroy == null)
			{
				AppLovinOptionsView.cb_destroy = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(AppLovinOptionsView.n_Destroy));
			}
			return AppLovinOptionsView.cb_destroy;
		}

		// Token: 0x06000FD5 RID: 4053 RVA: 0x0002E6E8 File Offset: 0x0002C8E8
		private static void n_Destroy(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<AppLovinOptionsView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Destroy();
		}

		// Token: 0x06000FD6 RID: 4054 RVA: 0x0002E6F7 File Offset: 0x0002C8F7
		[Register("destroy", "()V", "GetDestroyHandler")]
		public virtual void Destroy()
		{
			AppLovinOptionsView._members.InstanceMethods.InvokeVirtualVoidMethod("destroy.()V", this, null);
		}

		// Token: 0x06000FD7 RID: 4055 RVA: 0x0002E710 File Offset: 0x0002C910
		private static Delegate GetOnClick_Landroid_view_View_Handler()
		{
			if (AppLovinOptionsView.cb_onClick_Landroid_view_View_ == null)
			{
				AppLovinOptionsView.cb_onClick_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AppLovinOptionsView.n_OnClick_Landroid_view_View_));
			}
			return AppLovinOptionsView.cb_onClick_Landroid_view_View_;
		}

		// Token: 0x06000FD8 RID: 4056 RVA: 0x0002E734 File Offset: 0x0002C934
		private static void n_OnClick_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			AppLovinOptionsView @object = Java.Lang.Object.GetObject<AppLovinOptionsView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnClick(object2);
		}

		// Token: 0x06000FD9 RID: 4057 RVA: 0x0002E758 File Offset: 0x0002C958
		[Register("onClick", "(Landroid/view/View;)V", "GetOnClick_Landroid_view_View_Handler")]
		public unsafe virtual void OnClick(View p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				AppLovinOptionsView._members.InstanceMethods.InvokeVirtualVoidMethod("onClick.(Landroid/view/View;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x04000532 RID: 1330
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/impl/sdk/nativeAd/AppLovinOptionsView", typeof(AppLovinOptionsView));

		// Token: 0x04000533 RID: 1331
		private static Delegate cb_destroy;

		// Token: 0x04000534 RID: 1332
		private static Delegate cb_onClick_Landroid_view_View_;
	}
}
