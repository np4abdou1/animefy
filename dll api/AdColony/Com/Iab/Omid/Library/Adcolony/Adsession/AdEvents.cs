using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Iab.Omid.Library.Adcolony.Adsession.Media;
using Java.Interop;
using Java.Lang;

namespace Com.Iab.Omid.Library.Adcolony.Adsession
{
	// Token: 0x02000023 RID: 35
	[Register("com/iab/omid/library/adcolony/adsession/AdEvents", DoNotGenerateAcw = true)]
	public sealed class AdEvents : Java.Lang.Object
	{
		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x000035B4 File Offset: 0x000017B4
		internal static IntPtr class_ref
		{
			get
			{
				return AdEvents._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x000035D8 File Offset: 0x000017D8
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
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x000035E0 File Offset: 0x000017E0
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
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x00003604 File Offset: 0x00001804
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AdEvents._members.ManagedPeerType;
			}
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00002128 File Offset: 0x00000328
		internal AdEvents(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00003610 File Offset: 0x00001810
		[Register("createAdEvents", "(Lcom/iab/omid/library/adcolony/adsession/AdSession;)Lcom/iab/omid/library/adcolony/adsession/AdEvents;", "")]
		public unsafe static AdEvents CreateAdEvents(AdSession p0)
		{
			AdEvents @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				@object = Java.Lang.Object.GetObject<AdEvents>(AdEvents._members.StaticMethods.InvokeObjectMethod("createAdEvents.(Lcom/iab/omid/library/adcolony/adsession/AdSession;)Lcom/iab/omid/library/adcolony/adsession/AdEvents;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return @object;
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00003684 File Offset: 0x00001884
		[Register("impressionOccurred", "()V", "")]
		public void ImpressionOccurred()
		{
			AdEvents._members.InstanceMethods.InvokeAbstractVoidMethod("impressionOccurred.()V", this, null);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x0000369D File Offset: 0x0000189D
		[Register("loaded", "()V", "")]
		public void Loaded()
		{
			AdEvents._members.InstanceMethods.InvokeAbstractVoidMethod("loaded.()V", this, null);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x000036B8 File Offset: 0x000018B8
		[Register("loaded", "(Lcom/iab/omid/library/adcolony/adsession/media/VastProperties;)V", "")]
		public unsafe void Loaded(VastProperties p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				AdEvents._members.InstanceMethods.InvokeAbstractVoidMethod("loaded.(Lcom/iab/omid/library/adcolony/adsession/media/VastProperties;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x0400002C RID: 44
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/iab/omid/library/adcolony/adsession/AdEvents", typeof(AdEvents));
	}
}
