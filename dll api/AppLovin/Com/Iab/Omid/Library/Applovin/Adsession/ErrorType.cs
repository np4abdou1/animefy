using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Iab.Omid.Library.Applovin.Adsession
{
	// Token: 0x02000041 RID: 65
	[Register("com/iab/omid/library/applovin/adsession/ErrorType", DoNotGenerateAcw = true)]
	public sealed class ErrorType : Java.Lang.Enum
	{
		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x00004B9C File Offset: 0x00002D9C
		[Register("GENERIC")]
		public static ErrorType Generic
		{
			get
			{
				return Java.Lang.Object.GetObject<ErrorType>(ErrorType._members.StaticFields.GetObjectValue("GENERIC.Lcom/iab/omid/library/applovin/adsession/ErrorType;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060001B9 RID: 441 RVA: 0x00004BCC File Offset: 0x00002DCC
		[Register("VIDEO")]
		public static ErrorType Video
		{
			get
			{
				return Java.Lang.Object.GetObject<ErrorType>(ErrorType._members.StaticFields.GetObjectValue("VIDEO.Lcom/iab/omid/library/applovin/adsession/ErrorType;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060001BA RID: 442 RVA: 0x00004BFC File Offset: 0x00002DFC
		internal static IntPtr class_ref
		{
			get
			{
				return ErrorType._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060001BB RID: 443 RVA: 0x00004C20 File Offset: 0x00002E20
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ErrorType._members;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060001BC RID: 444 RVA: 0x00004C28 File Offset: 0x00002E28
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ErrorType._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060001BD RID: 445 RVA: 0x00004C4C File Offset: 0x00002E4C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ErrorType._members.ManagedPeerType;
			}
		}

		// Token: 0x060001BE RID: 446 RVA: 0x000048B4 File Offset: 0x00002AB4
		internal ErrorType(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00004C58 File Offset: 0x00002E58
		[Register("valueOf", "(Ljava/lang/String;)Lcom/iab/omid/library/applovin/adsession/ErrorType;", "")]
		public unsafe static ErrorType ValueOf(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			ErrorType @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<ErrorType>(ErrorType._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/iab/omid/library/applovin/adsession/ErrorType;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00004CC4 File Offset: 0x00002EC4
		[Register("values", "()[Lcom/iab/omid/library/applovin/adsession/ErrorType;", "")]
		public static ErrorType[] Values()
		{
			return (ErrorType[])JNIEnv.GetArray(ErrorType._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/iab/omid/library/applovin/adsession/ErrorType;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(ErrorType));
		}

		// Token: 0x04000047 RID: 71
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/iab/omid/library/applovin/adsession/ErrorType", typeof(ErrorType));
	}
}
