using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Sdk
{
	// Token: 0x02000055 RID: 85
	[Register("com/applovin/sdk/AppLovinEventTypes", DoNotGenerateAcw = true)]
	public class AppLovinEventTypes : Java.Lang.Object
	{
		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000296 RID: 662 RVA: 0x00006DC0 File Offset: 0x00004FC0
		internal static IntPtr class_ref
		{
			get
			{
				return AppLovinEventTypes._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000297 RID: 663 RVA: 0x00006DE4 File Offset: 0x00004FE4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AppLovinEventTypes._members;
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000298 RID: 664 RVA: 0x00006DEC File Offset: 0x00004FEC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AppLovinEventTypes._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000299 RID: 665 RVA: 0x00006E10 File Offset: 0x00005010
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AppLovinEventTypes._members.ManagedPeerType;
			}
		}

		// Token: 0x0600029A RID: 666 RVA: 0x000021F0 File Offset: 0x000003F0
		protected AppLovinEventTypes(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600029B RID: 667 RVA: 0x00006E1C File Offset: 0x0000501C
		[Register(".ctor", "()V", "")]
		public AppLovinEventTypes() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(AppLovinEventTypes._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			AppLovinEventTypes._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x04000087 RID: 135
		[Register("USER_ADDED_ITEM_TO_CART")]
		public const string UserAddedItemToCart = "cart";

		// Token: 0x04000088 RID: 136
		[Register("USER_ADDED_ITEM_TO_WISHLIST")]
		public const string UserAddedItemToWishlist = "wishlist";

		// Token: 0x04000089 RID: 137
		[Register("USER_BEGAN_CHECKOUT")]
		public const string UserBeganCheckout = "checkout_start";

		// Token: 0x0400008A RID: 138
		[Register("USER_COMPLETED_ACHIEVEMENT")]
		public const string UserCompletedAchievement = "achievement";

		// Token: 0x0400008B RID: 139
		[Register("USER_COMPLETED_CHECKOUT")]
		public const string UserCompletedCheckout = "checkout";

		// Token: 0x0400008C RID: 140
		[Register("USER_COMPLETED_IN_APP_PURCHASE")]
		public const string UserCompletedInAppPurchase = "iap";

		// Token: 0x0400008D RID: 141
		[Register("USER_COMPLETED_LEVEL")]
		public const string UserCompletedLevel = "level";

		// Token: 0x0400008E RID: 142
		[Register("USER_COMPLETED_TUTORIAL")]
		public const string UserCompletedTutorial = "tutorial";

		// Token: 0x0400008F RID: 143
		[Register("USER_CREATED_ACCOUNT")]
		public const string UserCreatedAccount = "registration";

		// Token: 0x04000090 RID: 144
		[Register("USER_CREATED_RESERVATION")]
		public const string UserCreatedReservation = "reservation";

		// Token: 0x04000091 RID: 145
		[Register("USER_EXECUTED_SEARCH")]
		public const string UserExecutedSearch = "search";

		// Token: 0x04000092 RID: 146
		[Register("USER_LOGGED_IN")]
		public const string UserLoggedIn = "login";

		// Token: 0x04000093 RID: 147
		[Register("USER_PROVIDED_PAYMENT_INFORMATION")]
		public const string UserProvidedPaymentInformation = "payment_info";

		// Token: 0x04000094 RID: 148
		[Register("USER_SENT_INVITATION")]
		public const string UserSentInvitation = "invite";

		// Token: 0x04000095 RID: 149
		[Register("USER_SHARED_LINK")]
		public const string UserSharedLink = "share";

		// Token: 0x04000096 RID: 150
		[Register("USER_SPENT_VIRTUAL_CURRENCY")]
		public const string UserSpentVirtualCurrency = "vcpurchase";

		// Token: 0x04000097 RID: 151
		[Register("USER_VIEWED_CONTENT")]
		public const string UserViewedContent = "content";

		// Token: 0x04000098 RID: 152
		[Register("USER_VIEWED_PRODUCT")]
		public const string UserViewedProduct = "product";

		// Token: 0x04000099 RID: 153
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/sdk/AppLovinEventTypes", typeof(AppLovinEventTypes));
	}
}
