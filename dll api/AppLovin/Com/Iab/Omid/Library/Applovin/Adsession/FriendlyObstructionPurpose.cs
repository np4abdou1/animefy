using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Iab.Omid.Library.Applovin.Adsession
{
	// Token: 0x02000042 RID: 66
	[Register("com/iab/omid/library/applovin/adsession/FriendlyObstructionPurpose", DoNotGenerateAcw = true)]
	public sealed class FriendlyObstructionPurpose : Java.Lang.Enum
	{
		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x00004D20 File Offset: 0x00002F20
		[Register("CLOSE_AD")]
		public static FriendlyObstructionPurpose CloseAd
		{
			get
			{
				return Java.Lang.Object.GetObject<FriendlyObstructionPurpose>(FriendlyObstructionPurpose._members.StaticFields.GetObjectValue("CLOSE_AD.Lcom/iab/omid/library/applovin/adsession/FriendlyObstructionPurpose;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060001C3 RID: 451 RVA: 0x00004D50 File Offset: 0x00002F50
		[Register("NOT_VISIBLE")]
		public static FriendlyObstructionPurpose NotVisible
		{
			get
			{
				return Java.Lang.Object.GetObject<FriendlyObstructionPurpose>(FriendlyObstructionPurpose._members.StaticFields.GetObjectValue("NOT_VISIBLE.Lcom/iab/omid/library/applovin/adsession/FriendlyObstructionPurpose;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060001C4 RID: 452 RVA: 0x00004D80 File Offset: 0x00002F80
		[Register("OTHER")]
		public static FriendlyObstructionPurpose Other
		{
			get
			{
				return Java.Lang.Object.GetObject<FriendlyObstructionPurpose>(FriendlyObstructionPurpose._members.StaticFields.GetObjectValue("OTHER.Lcom/iab/omid/library/applovin/adsession/FriendlyObstructionPurpose;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060001C5 RID: 453 RVA: 0x00004DB0 File Offset: 0x00002FB0
		[Register("VIDEO_CONTROLS")]
		public static FriendlyObstructionPurpose VideoControls
		{
			get
			{
				return Java.Lang.Object.GetObject<FriendlyObstructionPurpose>(FriendlyObstructionPurpose._members.StaticFields.GetObjectValue("VIDEO_CONTROLS.Lcom/iab/omid/library/applovin/adsession/FriendlyObstructionPurpose;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x00004DE0 File Offset: 0x00002FE0
		internal static IntPtr class_ref
		{
			get
			{
				return FriendlyObstructionPurpose._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060001C7 RID: 455 RVA: 0x00004E04 File Offset: 0x00003004
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return FriendlyObstructionPurpose._members;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x00004E0C File Offset: 0x0000300C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return FriendlyObstructionPurpose._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x00004E30 File Offset: 0x00003030
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return FriendlyObstructionPurpose._members.ManagedPeerType;
			}
		}

		// Token: 0x060001CA RID: 458 RVA: 0x000048B4 File Offset: 0x00002AB4
		internal FriendlyObstructionPurpose(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00004E3C File Offset: 0x0000303C
		[Register("valueOf", "(Ljava/lang/String;)Lcom/iab/omid/library/applovin/adsession/FriendlyObstructionPurpose;", "")]
		public unsafe static FriendlyObstructionPurpose ValueOf(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			FriendlyObstructionPurpose @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<FriendlyObstructionPurpose>(FriendlyObstructionPurpose._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/iab/omid/library/applovin/adsession/FriendlyObstructionPurpose;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00004EA8 File Offset: 0x000030A8
		[Register("values", "()[Lcom/iab/omid/library/applovin/adsession/FriendlyObstructionPurpose;", "")]
		public static FriendlyObstructionPurpose[] Values()
		{
			return (FriendlyObstructionPurpose[])JNIEnv.GetArray(FriendlyObstructionPurpose._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/iab/omid/library/applovin/adsession/FriendlyObstructionPurpose;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(FriendlyObstructionPurpose));
		}

		// Token: 0x04000048 RID: 72
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/iab/omid/library/applovin/adsession/FriendlyObstructionPurpose", typeof(FriendlyObstructionPurpose));
	}
}
