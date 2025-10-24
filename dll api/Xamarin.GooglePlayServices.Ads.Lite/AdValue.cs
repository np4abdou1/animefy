using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Ads
{
	// Token: 0x02000013 RID: 19
	[Register("com/google/android/gms/ads/AdValue", DoNotGenerateAcw = true)]
	public sealed class AdValue : Java.Lang.Object
	{
		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x000039C0 File Offset: 0x00001BC0
		internal static IntPtr class_ref
		{
			get
			{
				return AdValue._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x000039E4 File Offset: 0x00001BE4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AdValue._members;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x000039EC File Offset: 0x00001BEC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AdValue._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x00003A10 File Offset: 0x00001C10
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AdValue._members.ManagedPeerType;
			}
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x000020AC File Offset: 0x000002AC
		internal AdValue(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x00003A1C File Offset: 0x00001C1C
		public string CurrencyCode
		{
			[Register("getCurrencyCode", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(AdValue._members.InstanceMethods.InvokeAbstractObjectMethod("getCurrencyCode.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x00003A4E File Offset: 0x00001C4E
		public long ValueMicros
		{
			[Register("getValueMicros", "()J", "")]
			get
			{
				return AdValue._members.InstanceMethods.InvokeAbstractInt64Method("getValueMicros.()J", this, null);
			}
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00003A67 File Offset: 0x00001C67
		[Register("getPrecisionType", "()I", "")]
		public int PrecisionTypeData()
		{
			return AdValue._members.InstanceMethods.InvokeAbstractInt32Method("getPrecisionType.()I", this, null);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00003A80 File Offset: 0x00001C80
		[Register("zza", "(ILjava/lang/String;J)Lcom/google/android/gms/ads/AdValue;", "")]
		public unsafe static AdValue Zza(int p0, string p1, long p2)
		{
			IntPtr intPtr = JNIEnv.NewString(p1);
			AdValue @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(p0);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue(p2);
				@object = Java.Lang.Object.GetObject<AdValue>(AdValue._members.StaticMethods.InvokeObjectMethod("zza.(ILjava/lang/String;J)Lcom/google/android/gms/ads/AdValue;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x04000021 RID: 33
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/ads/AdValue", typeof(AdValue));
	}
}
