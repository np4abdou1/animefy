using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Iab.Omid.Library.Adcolony.Adsession
{
	// Token: 0x0200002D RID: 45
	[Register("com/iab/omid/library/adcolony/adsession/FriendlyObstructionPurpose", DoNotGenerateAcw = true)]
	public sealed class FriendlyObstructionPurpose : Java.Lang.Enum
	{
		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600016B RID: 363 RVA: 0x00004C58 File Offset: 0x00002E58
		[Register("CLOSE_AD")]
		public static FriendlyObstructionPurpose CloseAd
		{
			get
			{
				return Java.Lang.Object.GetObject<FriendlyObstructionPurpose>(FriendlyObstructionPurpose._members.StaticFields.GetObjectValue("CLOSE_AD.Lcom/iab/omid/library/adcolony/adsession/FriendlyObstructionPurpose;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600016C RID: 364 RVA: 0x00004C88 File Offset: 0x00002E88
		[Register("NOT_VISIBLE")]
		public static FriendlyObstructionPurpose NotVisible
		{
			get
			{
				return Java.Lang.Object.GetObject<FriendlyObstructionPurpose>(FriendlyObstructionPurpose._members.StaticFields.GetObjectValue("NOT_VISIBLE.Lcom/iab/omid/library/adcolony/adsession/FriendlyObstructionPurpose;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600016D RID: 365 RVA: 0x00004CB8 File Offset: 0x00002EB8
		[Register("OTHER")]
		public static FriendlyObstructionPurpose Other
		{
			get
			{
				return Java.Lang.Object.GetObject<FriendlyObstructionPurpose>(FriendlyObstructionPurpose._members.StaticFields.GetObjectValue("OTHER.Lcom/iab/omid/library/adcolony/adsession/FriendlyObstructionPurpose;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600016E RID: 366 RVA: 0x00004CE8 File Offset: 0x00002EE8
		[Register("VIDEO_CONTROLS")]
		public static FriendlyObstructionPurpose VideoControls
		{
			get
			{
				return Java.Lang.Object.GetObject<FriendlyObstructionPurpose>(FriendlyObstructionPurpose._members.StaticFields.GetObjectValue("VIDEO_CONTROLS.Lcom/iab/omid/library/adcolony/adsession/FriendlyObstructionPurpose;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600016F RID: 367 RVA: 0x00004D18 File Offset: 0x00002F18
		internal static IntPtr class_ref
		{
			get
			{
				return FriendlyObstructionPurpose._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000170 RID: 368 RVA: 0x00004D3C File Offset: 0x00002F3C
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
		// (get) Token: 0x06000171 RID: 369 RVA: 0x00004D44 File Offset: 0x00002F44
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
		// (get) Token: 0x06000172 RID: 370 RVA: 0x00004D68 File Offset: 0x00002F68
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return FriendlyObstructionPurpose._members.ManagedPeerType;
			}
		}

		// Token: 0x06000173 RID: 371 RVA: 0x000047EC File Offset: 0x000029EC
		internal FriendlyObstructionPurpose(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00004D74 File Offset: 0x00002F74
		[Register("valueOf", "(Ljava/lang/String;)Lcom/iab/omid/library/adcolony/adsession/FriendlyObstructionPurpose;", "")]
		public unsafe static FriendlyObstructionPurpose ValueOf(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			FriendlyObstructionPurpose @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<FriendlyObstructionPurpose>(FriendlyObstructionPurpose._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/iab/omid/library/adcolony/adsession/FriendlyObstructionPurpose;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00004DE0 File Offset: 0x00002FE0
		[Register("values", "()[Lcom/iab/omid/library/adcolony/adsession/FriendlyObstructionPurpose;", "")]
		public static FriendlyObstructionPurpose[] Values()
		{
			return (FriendlyObstructionPurpose[])JNIEnv.GetArray(FriendlyObstructionPurpose._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/iab/omid/library/adcolony/adsession/FriendlyObstructionPurpose;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(FriendlyObstructionPurpose));
		}

		// Token: 0x04000045 RID: 69
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/iab/omid/library/adcolony/adsession/FriendlyObstructionPurpose", typeof(FriendlyObstructionPurpose));
	}
}
