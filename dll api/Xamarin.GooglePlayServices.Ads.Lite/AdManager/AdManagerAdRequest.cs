using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Android.Gms.Ads.AdManager
{
	// Token: 0x0200003F RID: 63
	[Register("com/google/android/gms/ads/admanager/AdManagerAdRequest", DoNotGenerateAcw = true)]
	public sealed class AdManagerAdRequest : AdRequest
	{
		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000270 RID: 624 RVA: 0x000077BC File Offset: 0x000059BC
		internal new static IntPtr class_ref
		{
			get
			{
				return AdManagerAdRequest._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000271 RID: 625 RVA: 0x000077E0 File Offset: 0x000059E0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AdManagerAdRequest._members;
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000272 RID: 626 RVA: 0x000077E8 File Offset: 0x000059E8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AdManagerAdRequest._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000273 RID: 627 RVA: 0x0000780C File Offset: 0x00005A0C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AdManagerAdRequest._members.ManagedPeerType;
			}
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00007818 File Offset: 0x00005A18
		internal AdManagerAdRequest(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000275 RID: 629 RVA: 0x00007824 File Offset: 0x00005A24
		public string PublisherProvidedId
		{
			[Register("getPublisherProvidedId", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(AdManagerAdRequest._members.InstanceMethods.InvokeAbstractObjectMethod("getPublisherProvidedId.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x04000098 RID: 152
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/ads/admanager/AdManagerAdRequest", typeof(AdManagerAdRequest));
	}
}
