using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Mediation.Adapter
{
	// Token: 0x02000103 RID: 259
	[Register("com/applovin/mediation/adapter/MaxInterstitialAdViewAdapter", DoNotGenerateAcw = true)]
	internal class IMaxInterstitialAdViewAdapterInvoker : Java.Lang.Object, IMaxInterstitialAdViewAdapter, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06000AF4 RID: 2804 RVA: 0x0001DCEC File Offset: 0x0001BEEC
		private static IntPtr java_class_ref
		{
			get
			{
				return IMaxInterstitialAdViewAdapterInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06000AF5 RID: 2805 RVA: 0x0001DD10 File Offset: 0x0001BF10
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IMaxInterstitialAdViewAdapterInvoker._members;
			}
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06000AF6 RID: 2806 RVA: 0x0001DD17 File Offset: 0x0001BF17
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06000AF7 RID: 2807 RVA: 0x0001DD1F File Offset: 0x0001BF1F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IMaxInterstitialAdViewAdapterInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000AF8 RID: 2808 RVA: 0x0001DD2B File Offset: 0x0001BF2B
		public static IMaxInterstitialAdViewAdapter GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IMaxInterstitialAdViewAdapter>(handle, transfer);
		}

		// Token: 0x06000AF9 RID: 2809 RVA: 0x0001DD34 File Offset: 0x0001BF34
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IMaxInterstitialAdViewAdapterInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.applovin.mediation.adapter.MaxInterstitialAdViewAdapter'.");
			}
			return handle;
		}

		// Token: 0x06000AFA RID: 2810 RVA: 0x0001DD5F File Offset: 0x0001BF5F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000AFB RID: 2811 RVA: 0x0001DD90 File Offset: 0x0001BF90
		public IMaxInterstitialAdViewAdapterInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IMaxInterstitialAdViewAdapterInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0400039A RID: 922
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/mediation/adapter/MaxInterstitialAdViewAdapter", typeof(IMaxInterstitialAdViewAdapterInvoker));

		// Token: 0x0400039B RID: 923
		private IntPtr class_ref;
	}
}
