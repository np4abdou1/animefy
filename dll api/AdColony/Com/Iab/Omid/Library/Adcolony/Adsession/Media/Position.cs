using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Iab.Omid.Library.Adcolony.Adsession.Media
{
	// Token: 0x02000039 RID: 57
	[Register("com/iab/omid/library/adcolony/adsession/media/Position", DoNotGenerateAcw = true)]
	public sealed class Position : Java.Lang.Enum
	{
		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060001E8 RID: 488 RVA: 0x00005FDC File Offset: 0x000041DC
		[Register("MIDROLL")]
		public static Position Midroll
		{
			get
			{
				return Java.Lang.Object.GetObject<Position>(Position._members.StaticFields.GetObjectValue("MIDROLL.Lcom/iab/omid/library/adcolony/adsession/media/Position;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x0000600C File Offset: 0x0000420C
		[Register("POSTROLL")]
		public static Position Postroll
		{
			get
			{
				return Java.Lang.Object.GetObject<Position>(Position._members.StaticFields.GetObjectValue("POSTROLL.Lcom/iab/omid/library/adcolony/adsession/media/Position;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060001EA RID: 490 RVA: 0x0000603C File Offset: 0x0000423C
		[Register("PREROLL")]
		public static Position Preroll
		{
			get
			{
				return Java.Lang.Object.GetObject<Position>(Position._members.StaticFields.GetObjectValue("PREROLL.Lcom/iab/omid/library/adcolony/adsession/media/Position;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060001EB RID: 491 RVA: 0x0000606C File Offset: 0x0000426C
		[Register("STANDALONE")]
		public static Position Standalone
		{
			get
			{
				return Java.Lang.Object.GetObject<Position>(Position._members.StaticFields.GetObjectValue("STANDALONE.Lcom/iab/omid/library/adcolony/adsession/media/Position;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060001EC RID: 492 RVA: 0x0000609C File Offset: 0x0000429C
		internal static IntPtr class_ref
		{
			get
			{
				return Position._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060001ED RID: 493 RVA: 0x000060C0 File Offset: 0x000042C0
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
		// (get) Token: 0x060001EE RID: 494 RVA: 0x000060C8 File Offset: 0x000042C8
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
		// (get) Token: 0x060001EF RID: 495 RVA: 0x000060EC File Offset: 0x000042EC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Position._members.ManagedPeerType;
			}
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x000047EC File Offset: 0x000029EC
		internal Position(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x000060F8 File Offset: 0x000042F8
		[Register("valueOf", "(Ljava/lang/String;)Lcom/iab/omid/library/adcolony/adsession/media/Position;", "")]
		public unsafe static Position ValueOf(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			Position @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Position>(Position._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/iab/omid/library/adcolony/adsession/media/Position;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00006164 File Offset: 0x00004364
		[Register("values", "()[Lcom/iab/omid/library/adcolony/adsession/media/Position;", "")]
		public static Position[] Values()
		{
			return (Position[])JNIEnv.GetArray(Position._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/iab/omid/library/adcolony/adsession/media/Position;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(Position));
		}

		// Token: 0x04000057 RID: 87
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/iab/omid/library/adcolony/adsession/media/Position", typeof(Position));
	}
}
