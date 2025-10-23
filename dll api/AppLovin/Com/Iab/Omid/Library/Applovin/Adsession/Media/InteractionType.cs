using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Iab.Omid.Library.Applovin.Adsession.Media
{
	// Token: 0x0200004B RID: 75
	[Register("com/iab/omid/library/applovin/adsession/media/InteractionType", DoNotGenerateAcw = true)]
	public sealed class InteractionType : Java.Lang.Enum
	{
		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000214 RID: 532 RVA: 0x000059E8 File Offset: 0x00003BE8
		[Register("CLICK")]
		public static InteractionType Click
		{
			get
			{
				return Java.Lang.Object.GetObject<InteractionType>(InteractionType._members.StaticFields.GetObjectValue("CLICK.Lcom/iab/omid/library/applovin/adsession/media/InteractionType;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000215 RID: 533 RVA: 0x00005A18 File Offset: 0x00003C18
		[Register("INVITATION_ACCEPTED")]
		public static InteractionType InvitationAccepted
		{
			get
			{
				return Java.Lang.Object.GetObject<InteractionType>(InteractionType._members.StaticFields.GetObjectValue("INVITATION_ACCEPTED.Lcom/iab/omid/library/applovin/adsession/media/InteractionType;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000216 RID: 534 RVA: 0x00005A48 File Offset: 0x00003C48
		internal static IntPtr class_ref
		{
			get
			{
				return InteractionType._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000217 RID: 535 RVA: 0x00005A6C File Offset: 0x00003C6C
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
		// (get) Token: 0x06000218 RID: 536 RVA: 0x00005A74 File Offset: 0x00003C74
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
		// (get) Token: 0x06000219 RID: 537 RVA: 0x00005A98 File Offset: 0x00003C98
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return InteractionType._members.ManagedPeerType;
			}
		}

		// Token: 0x0600021A RID: 538 RVA: 0x000048B4 File Offset: 0x00002AB4
		internal InteractionType(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00005AA4 File Offset: 0x00003CA4
		[Register("valueOf", "(Ljava/lang/String;)Lcom/iab/omid/library/applovin/adsession/media/InteractionType;", "")]
		public unsafe static InteractionType ValueOf(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			InteractionType @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<InteractionType>(InteractionType._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/iab/omid/library/applovin/adsession/media/InteractionType;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00005B10 File Offset: 0x00003D10
		[Register("values", "()[Lcom/iab/omid/library/applovin/adsession/media/InteractionType;", "")]
		public static InteractionType[] Values()
		{
			return (InteractionType[])JNIEnv.GetArray(InteractionType._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/iab/omid/library/applovin/adsession/media/InteractionType;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(InteractionType));
		}

		// Token: 0x04000057 RID: 87
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/iab/omid/library/applovin/adsession/media/InteractionType", typeof(InteractionType));
	}
}
