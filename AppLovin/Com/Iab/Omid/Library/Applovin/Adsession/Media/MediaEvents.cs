using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Iab.Omid.Library.Applovin.Adsession.Media
{
	// Token: 0x0200004C RID: 76
	[Register("com/iab/omid/library/applovin/adsession/media/MediaEvents", DoNotGenerateAcw = true)]
	public sealed class MediaEvents : Java.Lang.Object
	{
		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600021E RID: 542 RVA: 0x00005B6C File Offset: 0x00003D6C
		internal static IntPtr class_ref
		{
			get
			{
				return MediaEvents._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600021F RID: 543 RVA: 0x00005B90 File Offset: 0x00003D90
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MediaEvents._members;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000220 RID: 544 RVA: 0x00005B98 File Offset: 0x00003D98
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MediaEvents._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000221 RID: 545 RVA: 0x00005BBC File Offset: 0x00003DBC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MediaEvents._members.ManagedPeerType;
			}
		}

		// Token: 0x06000222 RID: 546 RVA: 0x000021F0 File Offset: 0x000003F0
		internal MediaEvents(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00005BC8 File Offset: 0x00003DC8
		[Register("adUserInteraction", "(Lcom/iab/omid/library/applovin/adsession/media/InteractionType;)V", "")]
		public unsafe void AdUserInteraction(InteractionType p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				MediaEvents._members.InstanceMethods.InvokeAbstractVoidMethod("adUserInteraction.(Lcom/iab/omid/library/applovin/adsession/media/InteractionType;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00005C2C File Offset: 0x00003E2C
		[Register("bufferFinish", "()V", "")]
		public void BufferFinish()
		{
			MediaEvents._members.InstanceMethods.InvokeAbstractVoidMethod("bufferFinish.()V", this, null);
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00005C45 File Offset: 0x00003E45
		[Register("bufferStart", "()V", "")]
		public void BufferStart()
		{
			MediaEvents._members.InstanceMethods.InvokeAbstractVoidMethod("bufferStart.()V", this, null);
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00005C5E File Offset: 0x00003E5E
		[Register("complete", "()V", "")]
		public void Complete()
		{
			MediaEvents._members.InstanceMethods.InvokeAbstractVoidMethod("complete.()V", this, null);
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00005C78 File Offset: 0x00003E78
		[Register("createMediaEvents", "(Lcom/iab/omid/library/applovin/adsession/AdSession;)Lcom/iab/omid/library/applovin/adsession/media/MediaEvents;", "")]
		public unsafe static MediaEvents CreateMediaEvents(AdSession p0)
		{
			MediaEvents @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				@object = Java.Lang.Object.GetObject<MediaEvents>(MediaEvents._members.StaticMethods.InvokeObjectMethod("createMediaEvents.(Lcom/iab/omid/library/applovin/adsession/AdSession;)Lcom/iab/omid/library/applovin/adsession/media/MediaEvents;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return @object;
		}

		// Token: 0x06000228 RID: 552 RVA: 0x00005CEC File Offset: 0x00003EEC
		[Register("firstQuartile", "()V", "")]
		public void FirstQuartile()
		{
			MediaEvents._members.InstanceMethods.InvokeAbstractVoidMethod("firstQuartile.()V", this, null);
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00005D05 File Offset: 0x00003F05
		[Register("midpoint", "()V", "")]
		public void Midpoint()
		{
			MediaEvents._members.InstanceMethods.InvokeAbstractVoidMethod("midpoint.()V", this, null);
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00005D1E File Offset: 0x00003F1E
		[Register("pause", "()V", "")]
		public void Pause()
		{
			MediaEvents._members.InstanceMethods.InvokeAbstractVoidMethod("pause.()V", this, null);
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00005D38 File Offset: 0x00003F38
		[Register("playerStateChange", "(Lcom/iab/omid/library/applovin/adsession/media/PlayerState;)V", "")]
		public unsafe void PlayerStateChange(PlayerState p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				MediaEvents._members.InstanceMethods.InvokeAbstractVoidMethod("playerStateChange.(Lcom/iab/omid/library/applovin/adsession/media/PlayerState;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00005D9C File Offset: 0x00003F9C
		[Register("resume", "()V", "")]
		public void Resume()
		{
			MediaEvents._members.InstanceMethods.InvokeAbstractVoidMethod("resume.()V", this, null);
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00005DB5 File Offset: 0x00003FB5
		[Register("skipped", "()V", "")]
		public void Skipped()
		{
			MediaEvents._members.InstanceMethods.InvokeAbstractVoidMethod("skipped.()V", this, null);
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00005DD0 File Offset: 0x00003FD0
		[Register("start", "(FF)V", "")]
		public unsafe void Start(float p0, float p1)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(p0);
			ptr[1] = new JniArgumentValue(p1);
			MediaEvents._members.InstanceMethods.InvokeAbstractVoidMethod("start.(FF)V", this, ptr);
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00005E1E File Offset: 0x0000401E
		[Register("thirdQuartile", "()V", "")]
		public void ThirdQuartile()
		{
			MediaEvents._members.InstanceMethods.InvokeAbstractVoidMethod("thirdQuartile.()V", this, null);
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00005E38 File Offset: 0x00004038
		[Register("volumeChange", "(F)V", "")]
		public unsafe void VolumeChange(float p0)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(p0);
			MediaEvents._members.InstanceMethods.InvokeAbstractVoidMethod("volumeChange.(F)V", this, ptr);
		}

		// Token: 0x04000058 RID: 88
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/iab/omid/library/applovin/adsession/media/MediaEvents", typeof(MediaEvents));
	}
}
