using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Iab.Omid.Library.Adcolony.Adsession.Media
{
	// Token: 0x02000038 RID: 56
	[Register("com/iab/omid/library/adcolony/adsession/media/PlayerState", DoNotGenerateAcw = true)]
	public sealed class PlayerState : Java.Lang.Enum
	{
		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060001DB RID: 475 RVA: 0x00005DC8 File Offset: 0x00003FC8
		[Register("COLLAPSED")]
		public static PlayerState Collapsed
		{
			get
			{
				return Java.Lang.Object.GetObject<PlayerState>(PlayerState._members.StaticFields.GetObjectValue("COLLAPSED.Lcom/iab/omid/library/adcolony/adsession/media/PlayerState;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060001DC RID: 476 RVA: 0x00005DF8 File Offset: 0x00003FF8
		[Register("EXPANDED")]
		public static PlayerState Expanded
		{
			get
			{
				return Java.Lang.Object.GetObject<PlayerState>(PlayerState._members.StaticFields.GetObjectValue("EXPANDED.Lcom/iab/omid/library/adcolony/adsession/media/PlayerState;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060001DD RID: 477 RVA: 0x00005E28 File Offset: 0x00004028
		[Register("FULLSCREEN")]
		public static PlayerState Fullscreen
		{
			get
			{
				return Java.Lang.Object.GetObject<PlayerState>(PlayerState._members.StaticFields.GetObjectValue("FULLSCREEN.Lcom/iab/omid/library/adcolony/adsession/media/PlayerState;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060001DE RID: 478 RVA: 0x00005E58 File Offset: 0x00004058
		[Register("MINIMIZED")]
		public static PlayerState Minimized
		{
			get
			{
				return Java.Lang.Object.GetObject<PlayerState>(PlayerState._members.StaticFields.GetObjectValue("MINIMIZED.Lcom/iab/omid/library/adcolony/adsession/media/PlayerState;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060001DF RID: 479 RVA: 0x00005E88 File Offset: 0x00004088
		[Register("NORMAL")]
		public static PlayerState Normal
		{
			get
			{
				return Java.Lang.Object.GetObject<PlayerState>(PlayerState._members.StaticFields.GetObjectValue("NORMAL.Lcom/iab/omid/library/adcolony/adsession/media/PlayerState;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x00005EB8 File Offset: 0x000040B8
		internal static IntPtr class_ref
		{
			get
			{
				return PlayerState._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060001E1 RID: 481 RVA: 0x00005EDC File Offset: 0x000040DC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return PlayerState._members;
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060001E2 RID: 482 RVA: 0x00005EE4 File Offset: 0x000040E4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return PlayerState._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x00005F08 File Offset: 0x00004108
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return PlayerState._members.ManagedPeerType;
			}
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x000047EC File Offset: 0x000029EC
		internal PlayerState(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00005F14 File Offset: 0x00004114
		[Register("valueOf", "(Ljava/lang/String;)Lcom/iab/omid/library/adcolony/adsession/media/PlayerState;", "")]
		public unsafe static PlayerState ValueOf(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			PlayerState @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<PlayerState>(PlayerState._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/iab/omid/library/adcolony/adsession/media/PlayerState;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00005F80 File Offset: 0x00004180
		[Register("values", "()[Lcom/iab/omid/library/adcolony/adsession/media/PlayerState;", "")]
		public static PlayerState[] Values()
		{
			return (PlayerState[])JNIEnv.GetArray(PlayerState._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/iab/omid/library/adcolony/adsession/media/PlayerState;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(PlayerState));
		}

		// Token: 0x04000056 RID: 86
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/iab/omid/library/adcolony/adsession/media/PlayerState", typeof(PlayerState));
	}
}
