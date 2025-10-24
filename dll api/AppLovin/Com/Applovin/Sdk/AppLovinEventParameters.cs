using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Sdk
{
	// Token: 0x02000054 RID: 84
	[Register("com/applovin/sdk/AppLovinEventParameters", DoNotGenerateAcw = true)]
	public class AppLovinEventParameters : Java.Lang.Object
	{
		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x0600028F RID: 655 RVA: 0x00006CD8 File Offset: 0x00004ED8
		internal static IntPtr class_ref
		{
			get
			{
				return AppLovinEventParameters._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000290 RID: 656 RVA: 0x00006CFC File Offset: 0x00004EFC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AppLovinEventParameters._members;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000291 RID: 657 RVA: 0x00006D04 File Offset: 0x00004F04
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AppLovinEventParameters._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000292 RID: 658 RVA: 0x00006D28 File Offset: 0x00004F28
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AppLovinEventParameters._members.ManagedPeerType;
			}
		}

		// Token: 0x06000293 RID: 659 RVA: 0x000021F0 File Offset: 0x000003F0
		protected AppLovinEventParameters(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00006D34 File Offset: 0x00004F34
		[Register(".ctor", "()V", "")]
		public AppLovinEventParameters() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(AppLovinEventParameters._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			AppLovinEventParameters._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x04000076 RID: 118
		[Register("CHECKOUT_TRANSACTION_IDENTIFIER")]
		public const string CheckoutTransactionIdentifier = "transaction_id";

		// Token: 0x04000077 RID: 119
		[Register("COMPLETED_ACHIEVEMENT_IDENTIFIER")]
		public const string CompletedAchievementIdentifier = "achievement_id";

		// Token: 0x04000078 RID: 120
		[Register("COMPLETED_LEVEL_IDENTIFIER")]
		public const string CompletedLevelIdentifier = "level_id";

		// Token: 0x04000079 RID: 121
		[Register("CONTENT_IDENTIFIER")]
		public const string ContentIdentifier = "content_id";

		// Token: 0x0400007A RID: 122
		[Register("IN_APP_DATA_SIGNATURE")]
		public const string InAppDataSignature = "receipt_data_signature";

		// Token: 0x0400007B RID: 123
		[Register("IN_APP_PURCHASE_DATA")]
		public const string InAppPurchaseData = "receipt_data";

		// Token: 0x0400007C RID: 124
		[Register("IN_APP_PURCHASE_TRANSACTION_IDENTIFIER")]
		public const string InAppPurchaseTransactionIdentifier = "store_id";

		// Token: 0x0400007D RID: 125
		[Register("PRODUCT_IDENTIFIER")]
		public const string ProductIdentifier = "sku";

		// Token: 0x0400007E RID: 126
		[Register("RESERVATION_END_TIMESTAMP")]
		public const string ReservationEndTimestamp = "end_date";

		// Token: 0x0400007F RID: 127
		[Register("RESERVATION_START_TIMESTAMP")]
		public const string ReservationStartTimestamp = "start_date";

		// Token: 0x04000080 RID: 128
		[Register("REVENUE_AMOUNT")]
		public const string RevenueAmount = "amount";

		// Token: 0x04000081 RID: 129
		[Register("REVENUE_CURRENCY")]
		public const string RevenueCurrency = "currency";

		// Token: 0x04000082 RID: 130
		[Register("SEARCH_QUERY")]
		public const string SearchQuery = "query";

		// Token: 0x04000083 RID: 131
		[Register("USER_ACCOUNT_IDENTIFIER")]
		public const string UserAccountIdentifier = "username";

		// Token: 0x04000084 RID: 132
		[Register("VIRTUAL_CURRENCY_AMOUNT")]
		public const string VirtualCurrencyAmount = "vcamount";

		// Token: 0x04000085 RID: 133
		[Register("VIRTUAL_CURRENCY_NAME")]
		public const string VirtualCurrencyName = "vcname";

		// Token: 0x04000086 RID: 134
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/sdk/AppLovinEventParameters", typeof(AppLovinEventParameters));
	}
}
