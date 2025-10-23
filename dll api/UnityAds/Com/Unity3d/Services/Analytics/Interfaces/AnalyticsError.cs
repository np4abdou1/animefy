using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Analytics.Interfaces
{
	// Token: 0x020001C6 RID: 454
	[Register("com/unity3d/services/analytics/interfaces/AnalyticsError", DoNotGenerateAcw = true)]
	public sealed class AnalyticsError : Java.Lang.Enum
	{
		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x06001449 RID: 5193 RVA: 0x00039FC4 File Offset: 0x000381C4
		[Register("API_NOT_FOUND")]
		public static AnalyticsError ApiNotFound
		{
			get
			{
				return Java.Lang.Object.GetObject<AnalyticsError>(AnalyticsError._members.StaticFields.GetObjectValue("API_NOT_FOUND.Lcom/unity3d/services/analytics/interfaces/AnalyticsError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x0600144A RID: 5194 RVA: 0x00039FF4 File Offset: 0x000381F4
		internal static IntPtr class_ref
		{
			get
			{
				return AnalyticsError._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x0600144B RID: 5195 RVA: 0x0003A018 File Offset: 0x00038218
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AnalyticsError._members;
			}
		}

		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x0600144C RID: 5196 RVA: 0x0003A020 File Offset: 0x00038220
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AnalyticsError._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x0600144D RID: 5197 RVA: 0x0003A044 File Offset: 0x00038244
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AnalyticsError._members.ManagedPeerType;
			}
		}

		// Token: 0x0600144E RID: 5198 RVA: 0x0000256C File Offset: 0x0000076C
		internal AnalyticsError(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600144F RID: 5199 RVA: 0x0003A050 File Offset: 0x00038250
		[Register("valueOf", "(Ljava/lang/String;)Lcom/unity3d/services/analytics/interfaces/AnalyticsError;", "")]
		public unsafe static AnalyticsError ValueOf(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			AnalyticsError @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<AnalyticsError>(AnalyticsError._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/unity3d/services/analytics/interfaces/AnalyticsError;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06001450 RID: 5200 RVA: 0x0003A0BC File Offset: 0x000382BC
		[Register("values", "()[Lcom/unity3d/services/analytics/interfaces/AnalyticsError;", "")]
		public static AnalyticsError[] Values()
		{
			return (AnalyticsError[])JNIEnv.GetArray(AnalyticsError._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/unity3d/services/analytics/interfaces/AnalyticsError;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(AnalyticsError));
		}

		// Token: 0x040004D6 RID: 1238
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/analytics/interfaces/AnalyticsError", typeof(AnalyticsError));
	}
}
