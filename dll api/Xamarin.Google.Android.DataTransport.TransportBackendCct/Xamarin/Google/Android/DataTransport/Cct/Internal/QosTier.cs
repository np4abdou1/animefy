using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Cct.Internal
{
	// Token: 0x02000026 RID: 38
	[Register("com/google/android/datatransport/cct/internal/QosTier", DoNotGenerateAcw = true)]
	public sealed class QosTier : Java.Lang.Enum
	{
		// Token: 0x170000CB RID: 203
		// (get) Token: 0x0600020C RID: 524 RVA: 0x000064E4 File Offset: 0x000046E4
		[Register("DEFAULT")]
		public static QosTier Default
		{
			get
			{
				return Java.Lang.Object.GetObject<QosTier>(QosTier._members.StaticFields.GetObjectValue("DEFAULT.Lcom/google/android/datatransport/cct/internal/QosTier;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x0600020D RID: 525 RVA: 0x00006514 File Offset: 0x00004714
		[Register("FAST_IF_RADIO_AWAKE")]
		public static QosTier FastIfRadioAwake
		{
			get
			{
				return Java.Lang.Object.GetObject<QosTier>(QosTier._members.StaticFields.GetObjectValue("FAST_IF_RADIO_AWAKE.Lcom/google/android/datatransport/cct/internal/QosTier;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x0600020E RID: 526 RVA: 0x00006544 File Offset: 0x00004744
		[Register("NEVER")]
		public static QosTier Never
		{
			get
			{
				return Java.Lang.Object.GetObject<QosTier>(QosTier._members.StaticFields.GetObjectValue("NEVER.Lcom/google/android/datatransport/cct/internal/QosTier;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x0600020F RID: 527 RVA: 0x00006574 File Offset: 0x00004774
		[Register("UNMETERED_ONLY")]
		public static QosTier UnmeteredOnly
		{
			get
			{
				return Java.Lang.Object.GetObject<QosTier>(QosTier._members.StaticFields.GetObjectValue("UNMETERED_ONLY.Lcom/google/android/datatransport/cct/internal/QosTier;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000210 RID: 528 RVA: 0x000065A4 File Offset: 0x000047A4
		[Register("UNMETERED_OR_DAILY")]
		public static QosTier UnmeteredOrDaily
		{
			get
			{
				return Java.Lang.Object.GetObject<QosTier>(QosTier._members.StaticFields.GetObjectValue("UNMETERED_OR_DAILY.Lcom/google/android/datatransport/cct/internal/QosTier;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000211 RID: 529 RVA: 0x000065D4 File Offset: 0x000047D4
		[Register("UNRECOGNIZED")]
		public static QosTier Unrecognized
		{
			get
			{
				return Java.Lang.Object.GetObject<QosTier>(QosTier._members.StaticFields.GetObjectValue("UNRECOGNIZED.Lcom/google/android/datatransport/cct/internal/QosTier;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000212 RID: 530 RVA: 0x00006604 File Offset: 0x00004804
		internal static IntPtr class_ref
		{
			get
			{
				return QosTier._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000213 RID: 531 RVA: 0x00006628 File Offset: 0x00004828
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return QosTier._members;
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000214 RID: 532 RVA: 0x00006630 File Offset: 0x00004830
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return QosTier._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000215 RID: 533 RVA: 0x00006654 File Offset: 0x00004854
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return QosTier._members.ManagedPeerType;
			}
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00003E74 File Offset: 0x00002074
		internal QosTier(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000217 RID: 535 RVA: 0x00006660 File Offset: 0x00004860
		public int Number
		{
			[Register("getNumber", "()I", "")]
			get
			{
				return QosTier._members.InstanceMethods.InvokeNonvirtualInt32Method("getNumber.()I", this, null);
			}
		}

		// Token: 0x06000218 RID: 536 RVA: 0x0000667C File Offset: 0x0000487C
		[Register("forNumber", "(I)Lcom/google/android/datatransport/cct/internal/QosTier;", "")]
		public unsafe static QosTier ForNumber(int value)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(value);
			return Java.Lang.Object.GetObject<QosTier>(QosTier._members.StaticMethods.InvokeObjectMethod("forNumber.(I)Lcom/google/android/datatransport/cct/internal/QosTier;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000219 RID: 537 RVA: 0x000066C4 File Offset: 0x000048C4
		[Register("valueOf", "(Ljava/lang/String;)Lcom/google/android/datatransport/cct/internal/QosTier;", "")]
		public unsafe static QosTier ValueOf(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			QosTier @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<QosTier>(QosTier._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/google/android/datatransport/cct/internal/QosTier;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00006730 File Offset: 0x00004930
		[Register("values", "()[Lcom/google/android/datatransport/cct/internal/QosTier;", "")]
		public static QosTier[] Values()
		{
			return (QosTier[])JNIEnv.GetArray(QosTier._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/google/android/datatransport/cct/internal/QosTier;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(QosTier));
		}

		// Token: 0x04000061 RID: 97
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/cct/internal/QosTier", typeof(QosTier));
	}
}
