using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Iab.Omid.Library.Adcolony.Adsession.Media
{
	// Token: 0x02000037 RID: 55
	[Register("com/iab/omid/library/adcolony/adsession/media/MediaEvents", DoNotGenerateAcw = true)]
	public sealed class MediaEvents : Java.Lang.Object
	{
		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060001C7 RID: 455 RVA: 0x00005AA4 File Offset: 0x00003CA4
		internal static IntPtr class_ref
		{
			get
			{
				return MediaEvents._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x00005AC8 File Offset: 0x00003CC8
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
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x00005AD0 File Offset: 0x00003CD0
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
		// (get) Token: 0x060001CA RID: 458 RVA: 0x00005AF4 File Offset: 0x00003CF4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MediaEvents._members.ManagedPeerType;
			}
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00002128 File Offset: 0x00000328
		internal MediaEvents(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00005B00 File Offset: 0x00003D00
		[Register("adUserInteraction", "(Lcom/iab/omid/library/adcolony/adsession/media/InteractionType;)V", "")]
		public unsafe void AdUserInteraction(InteractionType p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				MediaEvents._members.InstanceMethods.InvokeAbstractVoidMethod("adUserInteraction.(Lcom/iab/omid/library/adcolony/adsession/media/InteractionType;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00005B64 File Offset: 0x00003D64
		[Register("bufferFinish", "()V", "")]
		public void BufferFinish()
		{
			MediaEvents._members.InstanceMethods.InvokeAbstractVoidMethod("bufferFinish.()V", this, null);
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00005B7D File Offset: 0x00003D7D
		[Register("bufferStart", "()V", "")]
		public void BufferStart()
		{
			MediaEvents._members.InstanceMethods.InvokeAbstractVoidMethod("bufferStart.()V", this, null);
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00005B96 File Offset: 0x00003D96
		[Register("complete", "()V", "")]
		public void Complete()
		{
			MediaEvents._members.InstanceMethods.InvokeAbstractVoidMethod("complete.()V", this, null);
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00005BB0 File Offset: 0x00003DB0
		[Register("createMediaEvents", "(Lcom/iab/omid/library/adcolony/adsession/AdSession;)Lcom/iab/omid/library/adcolony/adsession/media/MediaEvents;", "")]
		public unsafe static MediaEvents CreateMediaEvents(AdSession p0)
		{
			MediaEvents @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				@object = Java.Lang.Object.GetObject<MediaEvents>(MediaEvents._members.StaticMethods.InvokeObjectMethod("createMediaEvents.(Lcom/iab/omid/library/adcolony/adsession/AdSession;)Lcom/iab/omid/library/adcolony/adsession/media/MediaEvents;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return @object;
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00005C24 File Offset: 0x00003E24
		[Register("firstQuartile", "()V", "")]
		public void FirstQuartile()
		{
			MediaEvents._members.InstanceMethods.InvokeAbstractVoidMethod("firstQuartile.()V", this, null);
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00005C3D File Offset: 0x00003E3D
		[Register("midpoint", "()V", "")]
		public void Midpoint()
		{
			MediaEvents._members.InstanceMethods.InvokeAbstractVoidMethod("midpoint.()V", this, null);
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00005C56 File Offset: 0x00003E56
		[Register("pause", "()V", "")]
		public void Pause()
		{
			MediaEvents._members.InstanceMethods.InvokeAbstractVoidMethod("pause.()V", this, null);
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00005C70 File Offset: 0x00003E70
		[Register("playerStateChange", "(Lcom/iab/omid/library/adcolony/adsession/media/PlayerState;)V", "")]
		public unsafe void PlayerStateChange(PlayerState p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				MediaEvents._members.InstanceMethods.InvokeAbstractVoidMethod("playerStateChange.(Lcom/iab/omid/library/adcolony/adsession/media/PlayerState;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00005CD4 File Offset: 0x00003ED4
		[Register("resume", "()V", "")]
		public void Resume()
		{
			MediaEvents._members.InstanceMethods.InvokeAbstractVoidMethod("resume.()V", this, null);
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00005CED File Offset: 0x00003EED
		[Register("skipped", "()V", "")]
		public void Skipped()
		{
			MediaEvents._members.InstanceMethods.InvokeAbstractVoidMethod("skipped.()V", this, null);
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00005D08 File Offset: 0x00003F08
		[Register("start", "(FF)V", "")]
		public unsafe void Start(float p0, float p1)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(p0);
			ptr[1] = new JniArgumentValue(p1);
			MediaEvents._members.InstanceMethods.InvokeAbstractVoidMethod("start.(FF)V", this, ptr);
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00005D56 File Offset: 0x00003F56
		[Register("thirdQuartile", "()V", "")]
		public void ThirdQuartile()
		{
			MediaEvents._members.InstanceMethods.InvokeAbstractVoidMethod("thirdQuartile.()V", this, null);
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00005D70 File Offset: 0x00003F70
		[Register("volumeChange", "(F)V", "")]
		public unsafe void VolumeChange(float p0)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(p0);
			MediaEvents._members.InstanceMethods.InvokeAbstractVoidMethod("volumeChange.(F)V", this, ptr);
		}

		// Token: 0x04000055 RID: 85
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/iab/omid/library/adcolony/adsession/media/MediaEvents", typeof(MediaEvents));
	}
}
