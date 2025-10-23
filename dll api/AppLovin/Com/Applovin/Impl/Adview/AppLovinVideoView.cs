using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Android.Widget;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Impl.Adview
{
	// Token: 0x02000170 RID: 368
	[Register("com/applovin/impl/adview/AppLovinVideoView", DoNotGenerateAcw = true)]
	public class AppLovinVideoView : VideoView
	{
		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x060011BA RID: 4538 RVA: 0x00033034 File Offset: 0x00031234
		internal static IntPtr class_ref
		{
			get
			{
				return AppLovinVideoView._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x060011BB RID: 4539 RVA: 0x00033058 File Offset: 0x00031258
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AppLovinVideoView._members;
			}
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x060011BC RID: 4540 RVA: 0x00033060 File Offset: 0x00031260
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AppLovinVideoView._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x060011BD RID: 4541 RVA: 0x00033084 File Offset: 0x00031284
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AppLovinVideoView._members.ManagedPeerType;
			}
		}

		// Token: 0x060011BE RID: 4542 RVA: 0x00033090 File Offset: 0x00031290
		protected AppLovinVideoView(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060011BF RID: 4543 RVA: 0x0003309C File Offset: 0x0003129C
		[Register(".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe AppLovinVideoView(Context p0) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				base.SetHandle(AppLovinVideoView._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				AppLovinVideoView._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x060011C0 RID: 4544 RVA: 0x0003314C File Offset: 0x0003134C
		private static Delegate GetSetVideoSize_IIHandler()
		{
			if (AppLovinVideoView.cb_setVideoSize_II == null)
			{
				AppLovinVideoView.cb_setVideoSize_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPII_V(AppLovinVideoView.n_SetVideoSize_II));
			}
			return AppLovinVideoView.cb_setVideoSize_II;
		}

		// Token: 0x060011C1 RID: 4545 RVA: 0x00033170 File Offset: 0x00031370
		private static void n_SetVideoSize_II(IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			Java.Lang.Object.GetObject<AppLovinVideoView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetVideoSize(p0, p1);
		}

		// Token: 0x060011C2 RID: 4546 RVA: 0x00033184 File Offset: 0x00031384
		[Register("setVideoSize", "(II)V", "GetSetVideoSize_IIHandler")]
		public unsafe virtual void SetVideoSize(int p0, int p1)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(p0);
			ptr[1] = new JniArgumentValue(p1);
			AppLovinVideoView._members.InstanceMethods.InvokeVirtualVoidMethod("setVideoSize.(II)V", this, ptr);
		}

		// Token: 0x040005CF RID: 1487
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/impl/adview/AppLovinVideoView", typeof(AppLovinVideoView));

		// Token: 0x040005D0 RID: 1488
		private static Delegate cb_setVideoSize_II;
	}
}
