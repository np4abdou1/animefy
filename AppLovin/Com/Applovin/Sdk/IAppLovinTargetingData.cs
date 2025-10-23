using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Sdk
{
	// Token: 0x02000091 RID: 145
	[Register("com/applovin/sdk/AppLovinTargetingData", "", "Com.Applovin.Sdk.IAppLovinTargetingDataInvoker")]
	public interface IAppLovinTargetingData : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000177 RID: 375
		// (get) Token: 0x060004B5 RID: 1205
		// (set) Token: 0x060004B6 RID: 1206
		string Email { [Register("getEmail", "()Ljava/lang/String;", "GetGetEmailHandler:Com.Applovin.Sdk.IAppLovinTargetingDataInvoker, AppLovin")] get; [Register("setEmail", "(Ljava/lang/String;)V", "GetSetEmail_Ljava_lang_String_Handler:Com.Applovin.Sdk.IAppLovinTargetingDataInvoker, AppLovin")] set; }

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x060004B7 RID: 1207
		// (set) Token: 0x060004B8 RID: 1208
		AppLovinGender Gender { [Register("getGender", "()Lcom/applovin/sdk/AppLovinGender;", "GetGetGenderHandler:Com.Applovin.Sdk.IAppLovinTargetingDataInvoker, AppLovin")] get; [Register("setGender", "(Lcom/applovin/sdk/AppLovinGender;)V", "GetSetGender_Lcom_applovin_sdk_AppLovinGender_Handler:Com.Applovin.Sdk.IAppLovinTargetingDataInvoker, AppLovin")] set; }

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x060004B9 RID: 1209
		// (set) Token: 0x060004BA RID: 1210
		IList<string> Interests { [Register("getInterests", "()Ljava/util/List;", "GetGetInterestsHandler:Com.Applovin.Sdk.IAppLovinTargetingDataInvoker, AppLovin")] get; [Register("setInterests", "(Ljava/util/List;)V", "GetSetInterests_Ljava_util_List_Handler:Com.Applovin.Sdk.IAppLovinTargetingDataInvoker, AppLovin")] set; }

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x060004BB RID: 1211
		// (set) Token: 0x060004BC RID: 1212
		IList<string> Keywords { [Register("getKeywords", "()Ljava/util/List;", "GetGetKeywordsHandler:Com.Applovin.Sdk.IAppLovinTargetingDataInvoker, AppLovin")] get; [Register("setKeywords", "(Ljava/util/List;)V", "GetSetKeywords_Ljava_util_List_Handler:Com.Applovin.Sdk.IAppLovinTargetingDataInvoker, AppLovin")] set; }

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x060004BD RID: 1213
		// (set) Token: 0x060004BE RID: 1214
		AppLovinAdContentRating MaximumAdContentRating { [Register("getMaximumAdContentRating", "()Lcom/applovin/sdk/AppLovinAdContentRating;", "GetGetMaximumAdContentRatingHandler:Com.Applovin.Sdk.IAppLovinTargetingDataInvoker, AppLovin")] get; [Register("setMaximumAdContentRating", "(Lcom/applovin/sdk/AppLovinAdContentRating;)V", "GetSetMaximumAdContentRating_Lcom_applovin_sdk_AppLovinAdContentRating_Handler:Com.Applovin.Sdk.IAppLovinTargetingDataInvoker, AppLovin")] set; }

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x060004BF RID: 1215
		// (set) Token: 0x060004C0 RID: 1216
		string PhoneNumber { [Register("getPhoneNumber", "()Ljava/lang/String;", "GetGetPhoneNumberHandler:Com.Applovin.Sdk.IAppLovinTargetingDataInvoker, AppLovin")] get; [Register("setPhoneNumber", "(Ljava/lang/String;)V", "GetSetPhoneNumber_Ljava_lang_String_Handler:Com.Applovin.Sdk.IAppLovinTargetingDataInvoker, AppLovin")] set; }

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x060004C1 RID: 1217
		// (set) Token: 0x060004C2 RID: 1218
		Integer YearOfBirth { [Register("getYearOfBirth", "()Ljava/lang/Integer;", "GetGetYearOfBirthHandler:Com.Applovin.Sdk.IAppLovinTargetingDataInvoker, AppLovin")] get; [Register("setYearOfBirth", "(Ljava/lang/Integer;)V", "GetSetYearOfBirth_Ljava_lang_Integer_Handler:Com.Applovin.Sdk.IAppLovinTargetingDataInvoker, AppLovin")] set; }

		// Token: 0x060004C3 RID: 1219
		[Register("clearAll", "()V", "GetClearAllHandler:Com.Applovin.Sdk.IAppLovinTargetingDataInvoker, AppLovin")]
		void ClearAll();
	}
}
