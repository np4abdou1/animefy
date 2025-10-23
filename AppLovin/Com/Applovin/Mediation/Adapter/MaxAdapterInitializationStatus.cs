using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Mediation.Adapter
{
	// Token: 0x020000F7 RID: 247
	[Register("com/applovin/mediation/adapter/MaxAdapter$InitializationStatus", DoNotGenerateAcw = true)]
	public sealed class MaxAdapterInitializationStatus : Java.Lang.Enum
	{
		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06000A97 RID: 2711 RVA: 0x0001CE84 File Offset: 0x0001B084
		[Register("DOES_NOT_APPLY")]
		public static MaxAdapterInitializationStatus DoesNotApply
		{
			get
			{
				return Java.Lang.Object.GetObject<MaxAdapterInitializationStatus>(MaxAdapterInitializationStatus._members.StaticFields.GetObjectValue("DOES_NOT_APPLY.Lcom/applovin/mediation/adapter/MaxAdapter$InitializationStatus;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06000A98 RID: 2712 RVA: 0x0001CEB4 File Offset: 0x0001B0B4
		[Register("INITIALIZED_FAILURE")]
		public static MaxAdapterInitializationStatus InitializedFailure
		{
			get
			{
				return Java.Lang.Object.GetObject<MaxAdapterInitializationStatus>(MaxAdapterInitializationStatus._members.StaticFields.GetObjectValue("INITIALIZED_FAILURE.Lcom/applovin/mediation/adapter/MaxAdapter$InitializationStatus;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06000A99 RID: 2713 RVA: 0x0001CEE4 File Offset: 0x0001B0E4
		[Register("INITIALIZED_SUCCESS")]
		public static MaxAdapterInitializationStatus InitializedSuccess
		{
			get
			{
				return Java.Lang.Object.GetObject<MaxAdapterInitializationStatus>(MaxAdapterInitializationStatus._members.StaticFields.GetObjectValue("INITIALIZED_SUCCESS.Lcom/applovin/mediation/adapter/MaxAdapter$InitializationStatus;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06000A9A RID: 2714 RVA: 0x0001CF14 File Offset: 0x0001B114
		[Register("INITIALIZED_UNKNOWN")]
		public static MaxAdapterInitializationStatus InitializedUnknown
		{
			get
			{
				return Java.Lang.Object.GetObject<MaxAdapterInitializationStatus>(MaxAdapterInitializationStatus._members.StaticFields.GetObjectValue("INITIALIZED_UNKNOWN.Lcom/applovin/mediation/adapter/MaxAdapter$InitializationStatus;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06000A9B RID: 2715 RVA: 0x0001CF44 File Offset: 0x0001B144
		[Register("INITIALIZING")]
		public static MaxAdapterInitializationStatus Initializing
		{
			get
			{
				return Java.Lang.Object.GetObject<MaxAdapterInitializationStatus>(MaxAdapterInitializationStatus._members.StaticFields.GetObjectValue("INITIALIZING.Lcom/applovin/mediation/adapter/MaxAdapter$InitializationStatus;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06000A9C RID: 2716 RVA: 0x0001CF74 File Offset: 0x0001B174
		[Register("NOT_INITIALIZED")]
		public static MaxAdapterInitializationStatus NotInitialized
		{
			get
			{
				return Java.Lang.Object.GetObject<MaxAdapterInitializationStatus>(MaxAdapterInitializationStatus._members.StaticFields.GetObjectValue("NOT_INITIALIZED.Lcom/applovin/mediation/adapter/MaxAdapter$InitializationStatus;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06000A9D RID: 2717 RVA: 0x0001CFA4 File Offset: 0x0001B1A4
		internal static IntPtr class_ref
		{
			get
			{
				return MaxAdapterInitializationStatus._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06000A9E RID: 2718 RVA: 0x0001CFC8 File Offset: 0x0001B1C8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MaxAdapterInitializationStatus._members;
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06000A9F RID: 2719 RVA: 0x0001CFD0 File Offset: 0x0001B1D0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MaxAdapterInitializationStatus._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06000AA0 RID: 2720 RVA: 0x0001CFF4 File Offset: 0x0001B1F4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MaxAdapterInitializationStatus._members.ManagedPeerType;
			}
		}

		// Token: 0x06000AA1 RID: 2721 RVA: 0x000048B4 File Offset: 0x00002AB4
		internal MaxAdapterInitializationStatus(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06000AA2 RID: 2722 RVA: 0x0001D000 File Offset: 0x0001B200
		public int Code
		{
			[Register("getCode", "()I", "")]
			get
			{
				return MaxAdapterInitializationStatus._members.InstanceMethods.InvokeAbstractInt32Method("getCode.()I", this, null);
			}
		}

		// Token: 0x06000AA3 RID: 2723 RVA: 0x0001D01C File Offset: 0x0001B21C
		[Register("valueOf", "(Ljava/lang/String;)Lcom/applovin/mediation/adapter/MaxAdapter$InitializationStatus;", "")]
		public unsafe static MaxAdapterInitializationStatus ValueOf(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			MaxAdapterInitializationStatus @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<MaxAdapterInitializationStatus>(MaxAdapterInitializationStatus._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/applovin/mediation/adapter/MaxAdapter$InitializationStatus;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06000AA4 RID: 2724 RVA: 0x0001D088 File Offset: 0x0001B288
		[Register("values", "()[Lcom/applovin/mediation/adapter/MaxAdapter$InitializationStatus;", "")]
		public static MaxAdapterInitializationStatus[] Values()
		{
			return (MaxAdapterInitializationStatus[])JNIEnv.GetArray(MaxAdapterInitializationStatus._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/applovin/mediation/adapter/MaxAdapter$InitializationStatus;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(MaxAdapterInitializationStatus));
		}

		// Token: 0x0400037B RID: 891
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/mediation/adapter/MaxAdapter$InitializationStatus", typeof(MaxAdapterInitializationStatus));
	}
}
