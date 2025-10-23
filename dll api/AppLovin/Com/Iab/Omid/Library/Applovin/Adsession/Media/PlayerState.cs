using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Iab.Omid.Library.Applovin.Adsession.Media
{
	// Token: 0x0200004D RID: 77
	[Register("com/iab/omid/library/applovin/adsession/media/PlayerState", DoNotGenerateAcw = true)]
	public sealed class PlayerState : Java.Lang.Enum
	{
		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000232 RID: 562 RVA: 0x00005E90 File Offset: 0x00004090
		[Register("COLLAPSED")]
		public static PlayerState Collapsed
		{
			get
			{
				return Java.Lang.Object.GetObject<PlayerState>(PlayerState._members.StaticFields.GetObjectValue("COLLAPSED.Lcom/iab/omid/library/applovin/adsession/media/PlayerState;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000233 RID: 563 RVA: 0x00005EC0 File Offset: 0x000040C0
		[Register("EXPANDED")]
		public static PlayerState Expanded
		{
			get
			{
				return Java.Lang.Object.GetObject<PlayerState>(PlayerState._members.StaticFields.GetObjectValue("EXPANDED.Lcom/iab/omid/library/applovin/adsession/media/PlayerState;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000234 RID: 564 RVA: 0x00005EF0 File Offset: 0x000040F0
		[Register("FULLSCREEN")]
		public static PlayerState Fullscreen
		{
			get
			{
				return Java.Lang.Object.GetObject<PlayerState>(PlayerState._members.StaticFields.GetObjectValue("FULLSCREEN.Lcom/iab/omid/library/applovin/adsession/media/PlayerState;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000235 RID: 565 RVA: 0x00005F20 File Offset: 0x00004120
		[Register("MINIMIZED")]
		public static PlayerState Minimized
		{
			get
			{
				return Java.Lang.Object.GetObject<PlayerState>(PlayerState._members.StaticFields.GetObjectValue("MINIMIZED.Lcom/iab/omid/library/applovin/adsession/media/PlayerState;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000236 RID: 566 RVA: 0x00005F50 File Offset: 0x00004150
		[Register("NORMAL")]
		public static PlayerState Normal
		{
			get
			{
				return Java.Lang.Object.GetObject<PlayerState>(PlayerState._members.StaticFields.GetObjectValue("NORMAL.Lcom/iab/omid/library/applovin/adsession/media/PlayerState;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000237 RID: 567 RVA: 0x00005F80 File Offset: 0x00004180
		internal static IntPtr class_ref
		{
			get
			{
				return PlayerState._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000238 RID: 568 RVA: 0x00005FA4 File Offset: 0x000041A4
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
		// (get) Token: 0x06000239 RID: 569 RVA: 0x00005FAC File Offset: 0x000041AC
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
		// (get) Token: 0x0600023A RID: 570 RVA: 0x00005FD0 File Offset: 0x000041D0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return PlayerState._members.ManagedPeerType;
			}
		}

		// Token: 0x0600023B RID: 571 RVA: 0x000048B4 File Offset: 0x00002AB4
		internal PlayerState(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00005FDC File Offset: 0x000041DC
		[Register("valueOf", "(Ljava/lang/String;)Lcom/iab/omid/library/applovin/adsession/media/PlayerState;", "")]
		public unsafe static PlayerState ValueOf(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			PlayerState @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<PlayerState>(PlayerState._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/iab/omid/library/applovin/adsession/media/PlayerState;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00006048 File Offset: 0x00004248
		[Register("values", "()[Lcom/iab/omid/library/applovin/adsession/media/PlayerState;", "")]
		public static PlayerState[] Values()
		{
			return (PlayerState[])JNIEnv.GetArray(PlayerState._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/iab/omid/library/applovin/adsession/media/PlayerState;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(PlayerState));
		}

		// Token: 0x04000059 RID: 89
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/iab/omid/library/applovin/adsession/media/PlayerState", typeof(PlayerState));
	}
}
