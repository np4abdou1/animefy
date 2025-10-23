using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Iab.Omid.Library.Applovin.Adsession.Media;
using Java.Interop;
using Java.Lang;

namespace Com.Iab.Omid.Library.Applovin.Adsession
{
	// Token: 0x02000038 RID: 56
	[Register("com/iab/omid/library/applovin/adsession/AdEvents", DoNotGenerateAcw = true)]
	public sealed class AdEvents : Java.Lang.Object
	{
		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000139 RID: 313 RVA: 0x0000367C File Offset: 0x0000187C
		internal static IntPtr class_ref
		{
			get
			{
				return AdEvents._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600013A RID: 314 RVA: 0x000036A0 File Offset: 0x000018A0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AdEvents._members;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600013B RID: 315 RVA: 0x000036A8 File Offset: 0x000018A8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AdEvents._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600013C RID: 316 RVA: 0x000036CC File Offset: 0x000018CC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AdEvents._members.ManagedPeerType;
			}
		}

		// Token: 0x0600013D RID: 317 RVA: 0x000021F0 File Offset: 0x000003F0
		internal AdEvents(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600013E RID: 318 RVA: 0x000036D8 File Offset: 0x000018D8
		[Register("createAdEvents", "(Lcom/iab/omid/library/applovin/adsession/AdSession;)Lcom/iab/omid/library/applovin/adsession/AdEvents;", "")]
		public unsafe static AdEvents CreateAdEvents(AdSession p0)
		{
			AdEvents @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				@object = Java.Lang.Object.GetObject<AdEvents>(AdEvents._members.StaticMethods.InvokeObjectMethod("createAdEvents.(Lcom/iab/omid/library/applovin/adsession/AdSession;)Lcom/iab/omid/library/applovin/adsession/AdEvents;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return @object;
		}

		// Token: 0x0600013F RID: 319 RVA: 0x0000374C File Offset: 0x0000194C
		[Register("impressionOccurred", "()V", "")]
		public void ImpressionOccurred()
		{
			AdEvents._members.InstanceMethods.InvokeAbstractVoidMethod("impressionOccurred.()V", this, null);
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00003765 File Offset: 0x00001965
		[Register("loaded", "()V", "")]
		public void Loaded()
		{
			AdEvents._members.InstanceMethods.InvokeAbstractVoidMethod("loaded.()V", this, null);
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00003780 File Offset: 0x00001980
		[Register("loaded", "(Lcom/iab/omid/library/applovin/adsession/media/VastProperties;)V", "")]
		public unsafe void Loaded(VastProperties p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				AdEvents._members.InstanceMethods.InvokeAbstractVoidMethod("loaded.(Lcom/iab/omid/library/applovin/adsession/media/VastProperties;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x0400002F RID: 47
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/iab/omid/library/applovin/adsession/AdEvents", typeof(AdEvents));
	}
}
