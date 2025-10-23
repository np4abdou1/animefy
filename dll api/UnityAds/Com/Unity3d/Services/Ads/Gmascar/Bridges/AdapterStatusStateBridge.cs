using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Ads.Gmascar.Bridges
{
	// Token: 0x02000211 RID: 529
	[Register("com/unity3d/services/ads/gmascar/bridges/AdapterStatusStateBridge", DoNotGenerateAcw = true)]
	public class AdapterStatusStateBridge : Java.Lang.Object
	{
		// Token: 0x17000878 RID: 2168
		// (get) Token: 0x060018BF RID: 6335 RVA: 0x000475D4 File Offset: 0x000457D4
		internal static IntPtr class_ref
		{
			get
			{
				return AdapterStatusStateBridge._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000879 RID: 2169
		// (get) Token: 0x060018C0 RID: 6336 RVA: 0x000475F8 File Offset: 0x000457F8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AdapterStatusStateBridge._members;
			}
		}

		// Token: 0x1700087A RID: 2170
		// (get) Token: 0x060018C1 RID: 6337 RVA: 0x00047600 File Offset: 0x00045800
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AdapterStatusStateBridge._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700087B RID: 2171
		// (get) Token: 0x060018C2 RID: 6338 RVA: 0x00047624 File Offset: 0x00045824
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AdapterStatusStateBridge._members.ManagedPeerType;
			}
		}

		// Token: 0x060018C3 RID: 6339 RVA: 0x000021E8 File Offset: 0x000003E8
		protected AdapterStatusStateBridge(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060018C4 RID: 6340 RVA: 0x00047630 File Offset: 0x00045830
		[Register(".ctor", "()V", "")]
		public AdapterStatusStateBridge() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(AdapterStatusStateBridge._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			AdapterStatusStateBridge._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060018C5 RID: 6341 RVA: 0x0004769E File Offset: 0x0004589E
		private static Delegate GetGetClassNameHandler()
		{
			if (AdapterStatusStateBridge.cb_getClassName == null)
			{
				AdapterStatusStateBridge.cb_getClassName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AdapterStatusStateBridge.n_GetClassName));
			}
			return AdapterStatusStateBridge.cb_getClassName;
		}

		// Token: 0x060018C6 RID: 6342 RVA: 0x000476C2 File Offset: 0x000458C2
		private static IntPtr n_GetClassName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<AdapterStatusStateBridge>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ClassName);
		}

		// Token: 0x1700087C RID: 2172
		// (get) Token: 0x060018C7 RID: 6343 RVA: 0x000476D8 File Offset: 0x000458D8
		public virtual string ClassName
		{
			[Register("getClassName", "()Ljava/lang/String;", "GetGetClassNameHandler")]
			get
			{
				return JNIEnv.GetString(AdapterStatusStateBridge._members.InstanceMethods.InvokeVirtualObjectMethod("getClassName.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x04000605 RID: 1541
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/gmascar/bridges/AdapterStatusStateBridge", typeof(AdapterStatusStateBridge));

		// Token: 0x04000606 RID: 1542
		private static Delegate cb_getClassName;
	}
}
