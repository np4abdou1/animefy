using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Iab.Omid.Library.Applovin.Adsession
{
	// Token: 0x02000048 RID: 72
	[Register("com/iab/omid/library/applovin/adsession/Owner", DoNotGenerateAcw = true)]
	public sealed class Owner : Java.Lang.Enum
	{
		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060001F1 RID: 497 RVA: 0x00005418 File Offset: 0x00003618
		[Register("JAVASCRIPT")]
		public static Owner Javascript
		{
			get
			{
				return Java.Lang.Object.GetObject<Owner>(Owner._members.StaticFields.GetObjectValue("JAVASCRIPT.Lcom/iab/omid/library/applovin/adsession/Owner;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x00005448 File Offset: 0x00003648
		[Register("NATIVE")]
		public static Owner Native
		{
			get
			{
				return Java.Lang.Object.GetObject<Owner>(Owner._members.StaticFields.GetObjectValue("NATIVE.Lcom/iab/omid/library/applovin/adsession/Owner;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060001F3 RID: 499 RVA: 0x00005478 File Offset: 0x00003678
		[Register("NONE")]
		public static Owner None
		{
			get
			{
				return Java.Lang.Object.GetObject<Owner>(Owner._members.StaticFields.GetObjectValue("NONE.Lcom/iab/omid/library/applovin/adsession/Owner;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060001F4 RID: 500 RVA: 0x000054A8 File Offset: 0x000036A8
		internal static IntPtr class_ref
		{
			get
			{
				return Owner._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x000054CC File Offset: 0x000036CC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Owner._members;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060001F6 RID: 502 RVA: 0x000054D4 File Offset: 0x000036D4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Owner._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x000054F8 File Offset: 0x000036F8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Owner._members.ManagedPeerType;
			}
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x000048B4 File Offset: 0x00002AB4
		internal Owner(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00005504 File Offset: 0x00003704
		[Register("valueOf", "(Ljava/lang/String;)Lcom/iab/omid/library/applovin/adsession/Owner;", "")]
		public unsafe static Owner ValueOf(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			Owner @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Owner>(Owner._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/iab/omid/library/applovin/adsession/Owner;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00005570 File Offset: 0x00003770
		[Register("values", "()[Lcom/iab/omid/library/applovin/adsession/Owner;", "")]
		public static Owner[] Values()
		{
			return (Owner[])JNIEnv.GetArray(Owner._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/iab/omid/library/applovin/adsession/Owner;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(Owner));
		}

		// Token: 0x04000052 RID: 82
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/iab/omid/library/applovin/adsession/Owner", typeof(Owner));
	}
}
