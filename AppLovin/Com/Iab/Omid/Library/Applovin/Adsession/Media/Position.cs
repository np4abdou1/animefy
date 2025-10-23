using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Iab.Omid.Library.Applovin.Adsession.Media
{
	// Token: 0x0200004E RID: 78
	[Register("com/iab/omid/library/applovin/adsession/media/Position", DoNotGenerateAcw = true)]
	public sealed class Position : Java.Lang.Enum
	{
		// Token: 0x17000096 RID: 150
		// (get) Token: 0x0600023F RID: 575 RVA: 0x000060A4 File Offset: 0x000042A4
		[Register("MIDROLL")]
		public static Position Midroll
		{
			get
			{
				return Java.Lang.Object.GetObject<Position>(Position._members.StaticFields.GetObjectValue("MIDROLL.Lcom/iab/omid/library/applovin/adsession/media/Position;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000240 RID: 576 RVA: 0x000060D4 File Offset: 0x000042D4
		[Register("POSTROLL")]
		public static Position Postroll
		{
			get
			{
				return Java.Lang.Object.GetObject<Position>(Position._members.StaticFields.GetObjectValue("POSTROLL.Lcom/iab/omid/library/applovin/adsession/media/Position;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000241 RID: 577 RVA: 0x00006104 File Offset: 0x00004304
		[Register("PREROLL")]
		public static Position Preroll
		{
			get
			{
				return Java.Lang.Object.GetObject<Position>(Position._members.StaticFields.GetObjectValue("PREROLL.Lcom/iab/omid/library/applovin/adsession/media/Position;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000242 RID: 578 RVA: 0x00006134 File Offset: 0x00004334
		[Register("STANDALONE")]
		public static Position Standalone
		{
			get
			{
				return Java.Lang.Object.GetObject<Position>(Position._members.StaticFields.GetObjectValue("STANDALONE.Lcom/iab/omid/library/applovin/adsession/media/Position;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000243 RID: 579 RVA: 0x00006164 File Offset: 0x00004364
		internal static IntPtr class_ref
		{
			get
			{
				return Position._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000244 RID: 580 RVA: 0x00006188 File Offset: 0x00004388
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Position._members;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000245 RID: 581 RVA: 0x00006190 File Offset: 0x00004390
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Position._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000246 RID: 582 RVA: 0x000061B4 File Offset: 0x000043B4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Position._members.ManagedPeerType;
			}
		}

		// Token: 0x06000247 RID: 583 RVA: 0x000048B4 File Offset: 0x00002AB4
		internal Position(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000248 RID: 584 RVA: 0x000061C0 File Offset: 0x000043C0
		[Register("valueOf", "(Ljava/lang/String;)Lcom/iab/omid/library/applovin/adsession/media/Position;", "")]
		public unsafe static Position ValueOf(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			Position @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Position>(Position._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/iab/omid/library/applovin/adsession/media/Position;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06000249 RID: 585 RVA: 0x0000622C File Offset: 0x0000442C
		[Register("values", "()[Lcom/iab/omid/library/applovin/adsession/media/Position;", "")]
		public static Position[] Values()
		{
			return (Position[])JNIEnv.GetArray(Position._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/iab/omid/library/applovin/adsession/media/Position;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(Position));
		}

		// Token: 0x0400005A RID: 90
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/iab/omid/library/applovin/adsession/media/Position", typeof(Position));
	}
}
