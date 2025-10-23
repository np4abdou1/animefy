using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Iab.Omid.Library.Adcolony.Adsession.Media
{
	// Token: 0x02000036 RID: 54
	[Register("com/iab/omid/library/adcolony/adsession/media/InteractionType", DoNotGenerateAcw = true)]
	public sealed class InteractionType : Java.Lang.Enum
	{
		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060001BD RID: 445 RVA: 0x00005920 File Offset: 0x00003B20
		[Register("CLICK")]
		public static InteractionType Click
		{
			get
			{
				return Java.Lang.Object.GetObject<InteractionType>(InteractionType._members.StaticFields.GetObjectValue("CLICK.Lcom/iab/omid/library/adcolony/adsession/media/InteractionType;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060001BE RID: 446 RVA: 0x00005950 File Offset: 0x00003B50
		[Register("INVITATION_ACCEPTED")]
		public static InteractionType InvitationAccepted
		{
			get
			{
				return Java.Lang.Object.GetObject<InteractionType>(InteractionType._members.StaticFields.GetObjectValue("INVITATION_ACCEPTED.Lcom/iab/omid/library/adcolony/adsession/media/InteractionType;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060001BF RID: 447 RVA: 0x00005980 File Offset: 0x00003B80
		internal static IntPtr class_ref
		{
			get
			{
				return InteractionType._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060001C0 RID: 448 RVA: 0x000059A4 File Offset: 0x00003BA4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return InteractionType._members;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060001C1 RID: 449 RVA: 0x000059AC File Offset: 0x00003BAC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return InteractionType._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x000059D0 File Offset: 0x00003BD0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return InteractionType._members.ManagedPeerType;
			}
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x000047EC File Offset: 0x000029EC
		internal InteractionType(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x000059DC File Offset: 0x00003BDC
		[Register("valueOf", "(Ljava/lang/String;)Lcom/iab/omid/library/adcolony/adsession/media/InteractionType;", "")]
		public unsafe static InteractionType ValueOf(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			InteractionType @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<InteractionType>(InteractionType._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/iab/omid/library/adcolony/adsession/media/InteractionType;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00005A48 File Offset: 0x00003C48
		[Register("values", "()[Lcom/iab/omid/library/adcolony/adsession/media/InteractionType;", "")]
		public static InteractionType[] Values()
		{
			return (InteractionType[])JNIEnv.GetArray(InteractionType._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/iab/omid/library/adcolony/adsession/media/InteractionType;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(InteractionType));
		}

		// Token: 0x04000054 RID: 84
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/iab/omid/library/adcolony/adsession/media/InteractionType", typeof(InteractionType));
	}
}
