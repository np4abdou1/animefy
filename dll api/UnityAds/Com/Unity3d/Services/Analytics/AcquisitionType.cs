using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Analytics
{
	// Token: 0x020001C3 RID: 451
	[Register("com/unity3d/services/analytics/AcquisitionType", DoNotGenerateAcw = true)]
	public sealed class AcquisitionType : Java.Lang.Enum
	{
		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x06001427 RID: 5159 RVA: 0x000395D0 File Offset: 0x000377D0
		[Register("PREMIUM")]
		public static AcquisitionType Premium
		{
			get
			{
				return Java.Lang.Object.GetObject<AcquisitionType>(AcquisitionType._members.StaticFields.GetObjectValue("PREMIUM.Lcom/unity3d/services/analytics/AcquisitionType;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x06001428 RID: 5160 RVA: 0x00039600 File Offset: 0x00037800
		[Register("SOFT")]
		public static AcquisitionType Soft
		{
			get
			{
				return Java.Lang.Object.GetObject<AcquisitionType>(AcquisitionType._members.StaticFields.GetObjectValue("SOFT.Lcom/unity3d/services/analytics/AcquisitionType;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x06001429 RID: 5161 RVA: 0x00039630 File Offset: 0x00037830
		internal static IntPtr class_ref
		{
			get
			{
				return AcquisitionType._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x0600142A RID: 5162 RVA: 0x00039654 File Offset: 0x00037854
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AcquisitionType._members;
			}
		}

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x0600142B RID: 5163 RVA: 0x0003965C File Offset: 0x0003785C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AcquisitionType._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x0600142C RID: 5164 RVA: 0x00039680 File Offset: 0x00037880
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AcquisitionType._members.ManagedPeerType;
			}
		}

		// Token: 0x0600142D RID: 5165 RVA: 0x0000256C File Offset: 0x0000076C
		internal AcquisitionType(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600142E RID: 5166 RVA: 0x0003968C File Offset: 0x0003788C
		[Register("valueOf", "(Ljava/lang/String;)Lcom/unity3d/services/analytics/AcquisitionType;", "")]
		public unsafe static AcquisitionType ValueOf(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			AcquisitionType @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<AcquisitionType>(AcquisitionType._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/unity3d/services/analytics/AcquisitionType;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x0600142F RID: 5167 RVA: 0x000396F8 File Offset: 0x000378F8
		[Register("values", "()[Lcom/unity3d/services/analytics/AcquisitionType;", "")]
		public static AcquisitionType[] Values()
		{
			return (AcquisitionType[])JNIEnv.GetArray(AcquisitionType._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/unity3d/services/analytics/AcquisitionType;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(AcquisitionType));
		}

		// Token: 0x040004D3 RID: 1235
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/analytics/AcquisitionType", typeof(AcquisitionType));
	}
}
