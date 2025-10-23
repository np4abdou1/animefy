using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Iab.Omid.Library.Adcolony.Adsession
{
	// Token: 0x02000033 RID: 51
	[Register("com/iab/omid/library/adcolony/adsession/Owner", DoNotGenerateAcw = true)]
	public sealed class Owner : Java.Lang.Enum
	{
		// Token: 0x1700006F RID: 111
		// (get) Token: 0x0600019A RID: 410 RVA: 0x00005350 File Offset: 0x00003550
		[Register("JAVASCRIPT")]
		public static Owner Javascript
		{
			get
			{
				return Java.Lang.Object.GetObject<Owner>(Owner._members.StaticFields.GetObjectValue("JAVASCRIPT.Lcom/iab/omid/library/adcolony/adsession/Owner;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600019B RID: 411 RVA: 0x00005380 File Offset: 0x00003580
		[Register("NATIVE")]
		public static Owner Native
		{
			get
			{
				return Java.Lang.Object.GetObject<Owner>(Owner._members.StaticFields.GetObjectValue("NATIVE.Lcom/iab/omid/library/adcolony/adsession/Owner;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600019C RID: 412 RVA: 0x000053B0 File Offset: 0x000035B0
		[Register("NONE")]
		public static Owner None
		{
			get
			{
				return Java.Lang.Object.GetObject<Owner>(Owner._members.StaticFields.GetObjectValue("NONE.Lcom/iab/omid/library/adcolony/adsession/Owner;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600019D RID: 413 RVA: 0x000053E0 File Offset: 0x000035E0
		internal static IntPtr class_ref
		{
			get
			{
				return Owner._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600019E RID: 414 RVA: 0x00005404 File Offset: 0x00003604
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
		// (get) Token: 0x0600019F RID: 415 RVA: 0x0000540C File Offset: 0x0000360C
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
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x00005430 File Offset: 0x00003630
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Owner._members.ManagedPeerType;
			}
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x000047EC File Offset: 0x000029EC
		internal Owner(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x0000543C File Offset: 0x0000363C
		[Register("valueOf", "(Ljava/lang/String;)Lcom/iab/omid/library/adcolony/adsession/Owner;", "")]
		public unsafe static Owner ValueOf(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			Owner @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Owner>(Owner._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/iab/omid/library/adcolony/adsession/Owner;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x000054A8 File Offset: 0x000036A8
		[Register("values", "()[Lcom/iab/omid/library/adcolony/adsession/Owner;", "")]
		public static Owner[] Values()
		{
			return (Owner[])JNIEnv.GetArray(Owner._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/iab/omid/library/adcolony/adsession/Owner;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(Owner));
		}

		// Token: 0x0400004F RID: 79
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/iab/omid/library/adcolony/adsession/Owner", typeof(Owner));
	}
}
