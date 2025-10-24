using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Ads.Initialization
{
	// Token: 0x02000038 RID: 56
	[Register("com/google/android/gms/ads/initialization/AdapterStatus$State", DoNotGenerateAcw = true)]
	public sealed class AdapterStatusState : Java.Lang.Enum
	{
		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000237 RID: 567 RVA: 0x00007074 File Offset: 0x00005274
		[Register("NOT_READY")]
		public static AdapterStatusState NotReady
		{
			get
			{
				return Java.Lang.Object.GetObject<AdapterStatusState>(AdapterStatusState._members.StaticFields.GetObjectValue("NOT_READY.Lcom/google/android/gms/ads/initialization/AdapterStatus$State;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000238 RID: 568 RVA: 0x000070A4 File Offset: 0x000052A4
		[Register("READY")]
		public static AdapterStatusState Ready
		{
			get
			{
				return Java.Lang.Object.GetObject<AdapterStatusState>(AdapterStatusState._members.StaticFields.GetObjectValue("READY.Lcom/google/android/gms/ads/initialization/AdapterStatus$State;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000239 RID: 569 RVA: 0x000070D4 File Offset: 0x000052D4
		internal static IntPtr class_ref
		{
			get
			{
				return AdapterStatusState._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x0600023A RID: 570 RVA: 0x000070F8 File Offset: 0x000052F8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AdapterStatusState._members;
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x0600023B RID: 571 RVA: 0x00007100 File Offset: 0x00005300
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AdapterStatusState._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x0600023C RID: 572 RVA: 0x00007124 File Offset: 0x00005324
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AdapterStatusState._members.ManagedPeerType;
			}
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00007130 File Offset: 0x00005330
		internal AdapterStatusState(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600023E RID: 574 RVA: 0x0000713C File Offset: 0x0000533C
		[Register("valueOf", "(Ljava/lang/String;)Lcom/google/android/gms/ads/initialization/AdapterStatus$State;", "")]
		public unsafe static AdapterStatusState ValueOf(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			AdapterStatusState @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<AdapterStatusState>(AdapterStatusState._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/google/android/gms/ads/initialization/AdapterStatus$State;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x0600023F RID: 575 RVA: 0x000071A8 File Offset: 0x000053A8
		[Register("values", "()[Lcom/google/android/gms/ads/initialization/AdapterStatus$State;", "")]
		public static AdapterStatusState[] Values()
		{
			return (AdapterStatusState[])JNIEnv.GetArray(AdapterStatusState._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/google/android/gms/ads/initialization/AdapterStatus$State;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(AdapterStatusState));
		}

		// Token: 0x04000087 RID: 135
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/ads/initialization/AdapterStatus$State", typeof(AdapterStatusState));
	}
}
