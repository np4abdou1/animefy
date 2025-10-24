using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Iab.Omid.Library.Adcolony.Adsession
{
	// Token: 0x0200002C RID: 44
	[Register("com/iab/omid/library/adcolony/adsession/ErrorType", DoNotGenerateAcw = true)]
	public sealed class ErrorType : Java.Lang.Enum
	{
		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000161 RID: 353 RVA: 0x00004AD4 File Offset: 0x00002CD4
		[Register("GENERIC")]
		public static ErrorType Generic
		{
			get
			{
				return Java.Lang.Object.GetObject<ErrorType>(ErrorType._members.StaticFields.GetObjectValue("GENERIC.Lcom/iab/omid/library/adcolony/adsession/ErrorType;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000162 RID: 354 RVA: 0x00004B04 File Offset: 0x00002D04
		[Register("VIDEO")]
		public static ErrorType Video
		{
			get
			{
				return Java.Lang.Object.GetObject<ErrorType>(ErrorType._members.StaticFields.GetObjectValue("VIDEO.Lcom/iab/omid/library/adcolony/adsession/ErrorType;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000163 RID: 355 RVA: 0x00004B34 File Offset: 0x00002D34
		internal static IntPtr class_ref
		{
			get
			{
				return ErrorType._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000164 RID: 356 RVA: 0x00004B58 File Offset: 0x00002D58
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
		// (get) Token: 0x06000165 RID: 357 RVA: 0x00004B60 File Offset: 0x00002D60
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
		// (get) Token: 0x06000166 RID: 358 RVA: 0x00004B84 File Offset: 0x00002D84
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ErrorType._members.ManagedPeerType;
			}
		}

		// Token: 0x06000167 RID: 359 RVA: 0x000047EC File Offset: 0x000029EC
		internal ErrorType(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00004B90 File Offset: 0x00002D90
		[Register("valueOf", "(Ljava/lang/String;)Lcom/iab/omid/library/adcolony/adsession/ErrorType;", "")]
		public unsafe static ErrorType ValueOf(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			ErrorType @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<ErrorType>(ErrorType._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/iab/omid/library/adcolony/adsession/ErrorType;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00004BFC File Offset: 0x00002DFC
		[Register("values", "()[Lcom/iab/omid/library/adcolony/adsession/ErrorType;", "")]
		public static ErrorType[] Values()
		{
			return (ErrorType[])JNIEnv.GetArray(ErrorType._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/iab/omid/library/adcolony/adsession/ErrorType;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(ErrorType));
		}

		// Token: 0x04000044 RID: 68
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/iab/omid/library/adcolony/adsession/ErrorType", typeof(ErrorType));
	}
}
