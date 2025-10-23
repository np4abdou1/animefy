using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Locations;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Adcolony.Sdk
{
	// Token: 0x0200004A RID: 74
	[Obsolete("This class is obsoleted in this android platform")]
	[Register("com/adcolony/sdk/AdColonyUserMetadata", DoNotGenerateAcw = true)]
	public class AdColonyUserMetadata : Java.Lang.Object
	{
		// Token: 0x17000100 RID: 256
		// (get) Token: 0x0600039E RID: 926 RVA: 0x0000B644 File Offset: 0x00009844
		internal static IntPtr class_ref
		{
			get
			{
				return AdColonyUserMetadata._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x0600039F RID: 927 RVA: 0x0000B668 File Offset: 0x00009868
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AdColonyUserMetadata._members;
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060003A0 RID: 928 RVA: 0x0000B670 File Offset: 0x00009870
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AdColonyUserMetadata._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060003A1 RID: 929 RVA: 0x0000B694 File Offset: 0x00009894
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AdColonyUserMetadata._members.ManagedPeerType;
			}
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x00002128 File Offset: 0x00000328
		protected AdColonyUserMetadata(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x0000B6A0 File Offset: 0x000098A0
		[Register(".ctor", "()V", "")]
		public AdColonyUserMetadata() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(AdColonyUserMetadata._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			AdColonyUserMetadata._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x0000B70E File Offset: 0x0000990E
		private static Delegate GetGetUserAgeHandler()
		{
			if (AdColonyUserMetadata.cb_getUserAge == null)
			{
				AdColonyUserMetadata.cb_getUserAge = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(AdColonyUserMetadata.n_GetUserAge));
			}
			return AdColonyUserMetadata.cb_getUserAge;
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x0000B732 File Offset: 0x00009932
		private static int n_GetUserAge(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AdColonyUserMetadata>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).UserAge;
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060003A6 RID: 934 RVA: 0x0000B741 File Offset: 0x00009941
		public virtual int UserAge
		{
			[Register("getUserAge", "()I", "GetGetUserAgeHandler")]
			get
			{
				return AdColonyUserMetadata._members.InstanceMethods.InvokeVirtualInt32Method("getUserAge.()I", this, null);
			}
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x0000B75A File Offset: 0x0000995A
		private static Delegate GetGetUserAnnualHouseholdIncomeHandler()
		{
			if (AdColonyUserMetadata.cb_getUserAnnualHouseholdIncome == null)
			{
				AdColonyUserMetadata.cb_getUserAnnualHouseholdIncome = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(AdColonyUserMetadata.n_GetUserAnnualHouseholdIncome));
			}
			return AdColonyUserMetadata.cb_getUserAnnualHouseholdIncome;
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x0000B77E File Offset: 0x0000997E
		private static int n_GetUserAnnualHouseholdIncome(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AdColonyUserMetadata>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).UserAnnualHouseholdIncome;
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060003A9 RID: 937 RVA: 0x0000B78D File Offset: 0x0000998D
		public virtual int UserAnnualHouseholdIncome
		{
			[Register("getUserAnnualHouseholdIncome", "()I", "GetGetUserAnnualHouseholdIncomeHandler")]
			get
			{
				return AdColonyUserMetadata._members.InstanceMethods.InvokeVirtualInt32Method("getUserAnnualHouseholdIncome.()I", this, null);
			}
		}

		// Token: 0x060003AA RID: 938 RVA: 0x0000B7A6 File Offset: 0x000099A6
		private static Delegate GetGetUserEducationHandler()
		{
			if (AdColonyUserMetadata.cb_getUserEducation == null)
			{
				AdColonyUserMetadata.cb_getUserEducation = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AdColonyUserMetadata.n_GetUserEducation));
			}
			return AdColonyUserMetadata.cb_getUserEducation;
		}

		// Token: 0x060003AB RID: 939 RVA: 0x0000B7CA File Offset: 0x000099CA
		private static IntPtr n_GetUserEducation(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<AdColonyUserMetadata>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).UserEducation);
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060003AC RID: 940 RVA: 0x0000B7E0 File Offset: 0x000099E0
		public virtual string UserEducation
		{
			[Register("getUserEducation", "()Ljava/lang/String;", "GetGetUserEducationHandler")]
			get
			{
				return JNIEnv.GetString(AdColonyUserMetadata._members.InstanceMethods.InvokeVirtualObjectMethod("getUserEducation.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060003AD RID: 941 RVA: 0x0000B812 File Offset: 0x00009A12
		private static Delegate GetGetUserGenderHandler()
		{
			if (AdColonyUserMetadata.cb_getUserGender == null)
			{
				AdColonyUserMetadata.cb_getUserGender = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AdColonyUserMetadata.n_GetUserGender));
			}
			return AdColonyUserMetadata.cb_getUserGender;
		}

		// Token: 0x060003AE RID: 942 RVA: 0x0000B836 File Offset: 0x00009A36
		private static IntPtr n_GetUserGender(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<AdColonyUserMetadata>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).UserGender);
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060003AF RID: 943 RVA: 0x0000B84C File Offset: 0x00009A4C
		public virtual string UserGender
		{
			[Register("getUserGender", "()Ljava/lang/String;", "GetGetUserGenderHandler")]
			get
			{
				return JNIEnv.GetString(AdColonyUserMetadata._members.InstanceMethods.InvokeVirtualObjectMethod("getUserGender.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x0000B87E File Offset: 0x00009A7E
		private static Delegate GetGetUserLocationHandler()
		{
			if (AdColonyUserMetadata.cb_getUserLocation == null)
			{
				AdColonyUserMetadata.cb_getUserLocation = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AdColonyUserMetadata.n_GetUserLocation));
			}
			return AdColonyUserMetadata.cb_getUserLocation;
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x0000B8A2 File Offset: 0x00009AA2
		private static IntPtr n_GetUserLocation(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AdColonyUserMetadata>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).UserLocation);
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060003B2 RID: 946 RVA: 0x0000B8B8 File Offset: 0x00009AB8
		public virtual Location UserLocation
		{
			[Register("getUserLocation", "()Landroid/location/Location;", "GetGetUserLocationHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Location>(AdColonyUserMetadata._members.InstanceMethods.InvokeVirtualObjectMethod("getUserLocation.()Landroid/location/Location;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x0000B8EA File Offset: 0x00009AEA
		private static Delegate GetGetUserMaritalStatusHandler()
		{
			if (AdColonyUserMetadata.cb_getUserMaritalStatus == null)
			{
				AdColonyUserMetadata.cb_getUserMaritalStatus = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AdColonyUserMetadata.n_GetUserMaritalStatus));
			}
			return AdColonyUserMetadata.cb_getUserMaritalStatus;
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x0000B90E File Offset: 0x00009B0E
		private static IntPtr n_GetUserMaritalStatus(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<AdColonyUserMetadata>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).UserMaritalStatus);
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060003B5 RID: 949 RVA: 0x0000B924 File Offset: 0x00009B24
		public virtual string UserMaritalStatus
		{
			[Register("getUserMaritalStatus", "()Ljava/lang/String;", "GetGetUserMaritalStatusHandler")]
			get
			{
				return JNIEnv.GetString(AdColonyUserMetadata._members.InstanceMethods.InvokeVirtualObjectMethod("getUserMaritalStatus.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x0000B956 File Offset: 0x00009B56
		private static Delegate GetGetUserZipCodeHandler()
		{
			if (AdColonyUserMetadata.cb_getUserZipCode == null)
			{
				AdColonyUserMetadata.cb_getUserZipCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AdColonyUserMetadata.n_GetUserZipCode));
			}
			return AdColonyUserMetadata.cb_getUserZipCode;
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x0000B97A File Offset: 0x00009B7A
		private static IntPtr n_GetUserZipCode(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<AdColonyUserMetadata>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).UserZipCode);
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060003B8 RID: 952 RVA: 0x0000B990 File Offset: 0x00009B90
		public virtual string UserZipCode
		{
			[Register("getUserZipCode", "()Ljava/lang/String;", "GetGetUserZipCodeHandler")]
			get
			{
				return JNIEnv.GetString(AdColonyUserMetadata._members.InstanceMethods.InvokeVirtualObjectMethod("getUserZipCode.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x0000B9C2 File Offset: 0x00009BC2
		private static Delegate GetAddUserInterest_Ljava_lang_String_Handler()
		{
			if (AdColonyUserMetadata.cb_addUserInterest_Ljava_lang_String_ == null)
			{
				AdColonyUserMetadata.cb_addUserInterest_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AdColonyUserMetadata.n_AddUserInterest_Ljava_lang_String_));
			}
			return AdColonyUserMetadata.cb_addUserInterest_Ljava_lang_String_;
		}

		// Token: 0x060003BA RID: 954 RVA: 0x0000B9E8 File Offset: 0x00009BE8
		private static IntPtr n_AddUserInterest_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_interest)
		{
			AdColonyUserMetadata @object = Java.Lang.Object.GetObject<AdColonyUserMetadata>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_interest, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.AddUserInterest(@string));
		}

		// Token: 0x060003BB RID: 955 RVA: 0x0000BA10 File Offset: 0x00009C10
		[Register("addUserInterest", "(Ljava/lang/String;)Lcom/adcolony/sdk/AdColonyUserMetadata;", "GetAddUserInterest_Ljava_lang_String_Handler")]
		public unsafe virtual AdColonyUserMetadata AddUserInterest(string interest)
		{
			IntPtr intPtr = JNIEnv.NewString(interest);
			AdColonyUserMetadata @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<AdColonyUserMetadata>(AdColonyUserMetadata._members.InstanceMethods.InvokeVirtualObjectMethod("addUserInterest.(Ljava/lang/String;)Lcom/adcolony/sdk/AdColonyUserMetadata;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060003BC RID: 956 RVA: 0x0000BA7C File Offset: 0x00009C7C
		private static Delegate GetClearUserInterestsHandler()
		{
			if (AdColonyUserMetadata.cb_clearUserInterests == null)
			{
				AdColonyUserMetadata.cb_clearUserInterests = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AdColonyUserMetadata.n_ClearUserInterests));
			}
			return AdColonyUserMetadata.cb_clearUserInterests;
		}

		// Token: 0x060003BD RID: 957 RVA: 0x0000BAA0 File Offset: 0x00009CA0
		private static IntPtr n_ClearUserInterests(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AdColonyUserMetadata>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ClearUserInterests());
		}

		// Token: 0x060003BE RID: 958 RVA: 0x0000BAB4 File Offset: 0x00009CB4
		[Register("clearUserInterests", "()Lcom/adcolony/sdk/AdColonyUserMetadata;", "GetClearUserInterestsHandler")]
		public virtual AdColonyUserMetadata ClearUserInterests()
		{
			return Java.Lang.Object.GetObject<AdColonyUserMetadata>(AdColonyUserMetadata._members.InstanceMethods.InvokeVirtualObjectMethod("clearUserInterests.()Lcom/adcolony/sdk/AdColonyUserMetadata;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060003BF RID: 959 RVA: 0x0000BAE6 File Offset: 0x00009CE6
		private static Delegate GetGetMetadata_Ljava_lang_String_Handler()
		{
			if (AdColonyUserMetadata.cb_getMetadata_Ljava_lang_String_ == null)
			{
				AdColonyUserMetadata.cb_getMetadata_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AdColonyUserMetadata.n_GetMetadata_Ljava_lang_String_));
			}
			return AdColonyUserMetadata.cb_getMetadata_Ljava_lang_String_;
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x0000BB0C File Offset: 0x00009D0C
		private static IntPtr n_GetMetadata_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			AdColonyUserMetadata @object = Java.Lang.Object.GetObject<AdColonyUserMetadata>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_key, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetMetadata(@string));
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x0000BB34 File Offset: 0x00009D34
		[Register("getMetadata", "(Ljava/lang/String;)Ljava/lang/Object;", "GetGetMetadata_Ljava_lang_String_Handler")]
		public unsafe virtual Java.Lang.Object GetMetadata(string key)
		{
			IntPtr intPtr = JNIEnv.NewString(key);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(AdColonyUserMetadata._members.InstanceMethods.InvokeVirtualObjectMethod("getMetadata.(Ljava/lang/String;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x0000BBA0 File Offset: 0x00009DA0
		private static Delegate GetGetUserInterestsHandler()
		{
			if (AdColonyUserMetadata.cb_getUserInterests == null)
			{
				AdColonyUserMetadata.cb_getUserInterests = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AdColonyUserMetadata.n_GetUserInterests));
			}
			return AdColonyUserMetadata.cb_getUserInterests;
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x0000BBC4 File Offset: 0x00009DC4
		private static IntPtr n_GetUserInterests(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray(Java.Lang.Object.GetObject<AdColonyUserMetadata>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetUserInterests());
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x0000BBD8 File Offset: 0x00009DD8
		[Register("getUserInterests", "()[Ljava/lang/String;", "GetGetUserInterestsHandler")]
		public virtual string[] GetUserInterests()
		{
			return (string[])JNIEnv.GetArray(AdColonyUserMetadata._members.InstanceMethods.InvokeVirtualObjectMethod("getUserInterests.()[Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef, typeof(string));
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x0000BC19 File Offset: 0x00009E19
		private static Delegate GetSetMetadata_Ljava_lang_String_ZHandler()
		{
			if (AdColonyUserMetadata.cb_setMetadata_Ljava_lang_String_Z == null)
			{
				AdColonyUserMetadata.cb_setMetadata_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLZ_L(AdColonyUserMetadata.n_SetMetadata_Ljava_lang_String_Z));
			}
			return AdColonyUserMetadata.cb_setMetadata_Ljava_lang_String_Z;
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x0000BC40 File Offset: 0x00009E40
		private static IntPtr n_SetMetadata_Ljava_lang_String_Z(IntPtr jnienv, IntPtr native__this, IntPtr native_key, bool value)
		{
			AdColonyUserMetadata @object = Java.Lang.Object.GetObject<AdColonyUserMetadata>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_key, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetMetadata(@string, value));
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x0000BC6C File Offset: 0x00009E6C
		[Register("setMetadata", "(Ljava/lang/String;Z)Lcom/adcolony/sdk/AdColonyUserMetadata;", "GetSetMetadata_Ljava_lang_String_ZHandler")]
		public unsafe virtual AdColonyUserMetadata SetMetadata(string key, bool value)
		{
			IntPtr intPtr = JNIEnv.NewString(key);
			AdColonyUserMetadata @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(value);
				@object = Java.Lang.Object.GetObject<AdColonyUserMetadata>(AdColonyUserMetadata._members.InstanceMethods.InvokeVirtualObjectMethod("setMetadata.(Ljava/lang/String;Z)Lcom/adcolony/sdk/AdColonyUserMetadata;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x0000BCEC File Offset: 0x00009EEC
		private static Delegate GetSetMetadata_Ljava_lang_String_DHandler()
		{
			if (AdColonyUserMetadata.cb_setMetadata_Ljava_lang_String_D == null)
			{
				AdColonyUserMetadata.cb_setMetadata_Ljava_lang_String_D = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLD_L(AdColonyUserMetadata.n_SetMetadata_Ljava_lang_String_D));
			}
			return AdColonyUserMetadata.cb_setMetadata_Ljava_lang_String_D;
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x0000BD10 File Offset: 0x00009F10
		private static IntPtr n_SetMetadata_Ljava_lang_String_D(IntPtr jnienv, IntPtr native__this, IntPtr native_key, double value)
		{
			AdColonyUserMetadata @object = Java.Lang.Object.GetObject<AdColonyUserMetadata>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_key, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetMetadata(@string, value));
		}

		// Token: 0x060003CA RID: 970 RVA: 0x0000BD3C File Offset: 0x00009F3C
		[Register("setMetadata", "(Ljava/lang/String;D)Lcom/adcolony/sdk/AdColonyUserMetadata;", "GetSetMetadata_Ljava_lang_String_DHandler")]
		public unsafe virtual AdColonyUserMetadata SetMetadata(string key, double value)
		{
			IntPtr intPtr = JNIEnv.NewString(key);
			AdColonyUserMetadata @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(value);
				@object = Java.Lang.Object.GetObject<AdColonyUserMetadata>(AdColonyUserMetadata._members.InstanceMethods.InvokeVirtualObjectMethod("setMetadata.(Ljava/lang/String;D)Lcom/adcolony/sdk/AdColonyUserMetadata;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060003CB RID: 971 RVA: 0x0000BDBC File Offset: 0x00009FBC
		private static Delegate GetSetMetadata_Ljava_lang_String_Ljava_lang_String_Handler()
		{
			if (AdColonyUserMetadata.cb_setMetadata_Ljava_lang_String_Ljava_lang_String_ == null)
			{
				AdColonyUserMetadata.cb_setMetadata_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(AdColonyUserMetadata.n_SetMetadata_Ljava_lang_String_Ljava_lang_String_));
			}
			return AdColonyUserMetadata.cb_setMetadata_Ljava_lang_String_Ljava_lang_String_;
		}

		// Token: 0x060003CC RID: 972 RVA: 0x0000BDE0 File Offset: 0x00009FE0
		private static IntPtr n_SetMetadata_Ljava_lang_String_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
		{
			AdColonyUserMetadata @object = Java.Lang.Object.GetObject<AdColonyUserMetadata>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_key, JniHandleOwnership.DoNotTransfer);
			string string2 = JNIEnv.GetString(native_value, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetMetadata(@string, string2));
		}

		// Token: 0x060003CD RID: 973 RVA: 0x0000BE14 File Offset: 0x0000A014
		[Register("setMetadata", "(Ljava/lang/String;Ljava/lang/String;)Lcom/adcolony/sdk/AdColonyUserMetadata;", "GetSetMetadata_Ljava_lang_String_Ljava_lang_String_Handler")]
		public unsafe virtual AdColonyUserMetadata SetMetadata(string key, string value)
		{
			IntPtr intPtr = JNIEnv.NewString(key);
			IntPtr intPtr2 = JNIEnv.NewString(value);
			AdColonyUserMetadata @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@object = Java.Lang.Object.GetObject<AdColonyUserMetadata>(AdColonyUserMetadata._members.InstanceMethods.InvokeVirtualObjectMethod("setMetadata.(Ljava/lang/String;Ljava/lang/String;)Lcom/adcolony/sdk/AdColonyUserMetadata;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
			return @object;
		}

		// Token: 0x060003CE RID: 974 RVA: 0x0000BEA4 File Offset: 0x0000A0A4
		private static Delegate GetSetUserAge_IHandler()
		{
			if (AdColonyUserMetadata.cb_setUserAge_I == null)
			{
				AdColonyUserMetadata.cb_setUserAge_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(AdColonyUserMetadata.n_SetUserAge_I));
			}
			return AdColonyUserMetadata.cb_setUserAge_I;
		}

		// Token: 0x060003CF RID: 975 RVA: 0x0000BEC8 File Offset: 0x0000A0C8
		private static IntPtr n_SetUserAge_I(IntPtr jnienv, IntPtr native__this, int age)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AdColonyUserMetadata>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetUserAge(age));
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x0000BEE0 File Offset: 0x0000A0E0
		[Register("setUserAge", "(I)Lcom/adcolony/sdk/AdColonyUserMetadata;", "GetSetUserAge_IHandler")]
		public unsafe virtual AdColonyUserMetadata SetUserAge(int age)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(age);
			return Java.Lang.Object.GetObject<AdColonyUserMetadata>(AdColonyUserMetadata._members.InstanceMethods.InvokeVirtualObjectMethod("setUserAge.(I)Lcom/adcolony/sdk/AdColonyUserMetadata;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x0000BF29 File Offset: 0x0000A129
		private static Delegate GetSetUserAnnualHouseholdIncome_IHandler()
		{
			if (AdColonyUserMetadata.cb_setUserAnnualHouseholdIncome_I == null)
			{
				AdColonyUserMetadata.cb_setUserAnnualHouseholdIncome_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(AdColonyUserMetadata.n_SetUserAnnualHouseholdIncome_I));
			}
			return AdColonyUserMetadata.cb_setUserAnnualHouseholdIncome_I;
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x0000BF4D File Offset: 0x0000A14D
		private static IntPtr n_SetUserAnnualHouseholdIncome_I(IntPtr jnienv, IntPtr native__this, int income)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AdColonyUserMetadata>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetUserAnnualHouseholdIncome(income));
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x0000BF64 File Offset: 0x0000A164
		[Register("setUserAnnualHouseholdIncome", "(I)Lcom/adcolony/sdk/AdColonyUserMetadata;", "GetSetUserAnnualHouseholdIncome_IHandler")]
		public unsafe virtual AdColonyUserMetadata SetUserAnnualHouseholdIncome(int income)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(income);
			return Java.Lang.Object.GetObject<AdColonyUserMetadata>(AdColonyUserMetadata._members.InstanceMethods.InvokeVirtualObjectMethod("setUserAnnualHouseholdIncome.(I)Lcom/adcolony/sdk/AdColonyUserMetadata;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x0000BFAD File Offset: 0x0000A1AD
		private static Delegate GetSetUserEducation_Ljava_lang_String_Handler()
		{
			if (AdColonyUserMetadata.cb_setUserEducation_Ljava_lang_String_ == null)
			{
				AdColonyUserMetadata.cb_setUserEducation_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AdColonyUserMetadata.n_SetUserEducation_Ljava_lang_String_));
			}
			return AdColonyUserMetadata.cb_setUserEducation_Ljava_lang_String_;
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x0000BFD4 File Offset: 0x0000A1D4
		private static IntPtr n_SetUserEducation_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_education)
		{
			AdColonyUserMetadata @object = Java.Lang.Object.GetObject<AdColonyUserMetadata>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_education, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetUserEducation(@string));
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x0000BFFC File Offset: 0x0000A1FC
		[Register("setUserEducation", "(Ljava/lang/String;)Lcom/adcolony/sdk/AdColonyUserMetadata;", "GetSetUserEducation_Ljava_lang_String_Handler")]
		public unsafe virtual AdColonyUserMetadata SetUserEducation(string education)
		{
			IntPtr intPtr = JNIEnv.NewString(education);
			AdColonyUserMetadata @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<AdColonyUserMetadata>(AdColonyUserMetadata._members.InstanceMethods.InvokeVirtualObjectMethod("setUserEducation.(Ljava/lang/String;)Lcom/adcolony/sdk/AdColonyUserMetadata;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x0000C068 File Offset: 0x0000A268
		private static Delegate GetSetUserGender_Ljava_lang_String_Handler()
		{
			if (AdColonyUserMetadata.cb_setUserGender_Ljava_lang_String_ == null)
			{
				AdColonyUserMetadata.cb_setUserGender_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AdColonyUserMetadata.n_SetUserGender_Ljava_lang_String_));
			}
			return AdColonyUserMetadata.cb_setUserGender_Ljava_lang_String_;
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x0000C08C File Offset: 0x0000A28C
		private static IntPtr n_SetUserGender_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_gender)
		{
			AdColonyUserMetadata @object = Java.Lang.Object.GetObject<AdColonyUserMetadata>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_gender, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetUserGender(@string));
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x0000C0B4 File Offset: 0x0000A2B4
		[Register("setUserGender", "(Ljava/lang/String;)Lcom/adcolony/sdk/AdColonyUserMetadata;", "GetSetUserGender_Ljava_lang_String_Handler")]
		public unsafe virtual AdColonyUserMetadata SetUserGender(string gender)
		{
			IntPtr intPtr = JNIEnv.NewString(gender);
			AdColonyUserMetadata @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<AdColonyUserMetadata>(AdColonyUserMetadata._members.InstanceMethods.InvokeVirtualObjectMethod("setUserGender.(Ljava/lang/String;)Lcom/adcolony/sdk/AdColonyUserMetadata;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060003DA RID: 986 RVA: 0x0000C120 File Offset: 0x0000A320
		private static Delegate GetSetUserLocation_Landroid_location_Location_Handler()
		{
			if (AdColonyUserMetadata.cb_setUserLocation_Landroid_location_Location_ == null)
			{
				AdColonyUserMetadata.cb_setUserLocation_Landroid_location_Location_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AdColonyUserMetadata.n_SetUserLocation_Landroid_location_Location_));
			}
			return AdColonyUserMetadata.cb_setUserLocation_Landroid_location_Location_;
		}

		// Token: 0x060003DB RID: 987 RVA: 0x0000C144 File Offset: 0x0000A344
		private static IntPtr n_SetUserLocation_Landroid_location_Location_(IntPtr jnienv, IntPtr native__this, IntPtr native_location)
		{
			AdColonyUserMetadata @object = Java.Lang.Object.GetObject<AdColonyUserMetadata>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Location object2 = Java.Lang.Object.GetObject<Location>(native_location, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetUserLocation(object2));
		}

		// Token: 0x060003DC RID: 988 RVA: 0x0000C16C File Offset: 0x0000A36C
		[Register("setUserLocation", "(Landroid/location/Location;)Lcom/adcolony/sdk/AdColonyUserMetadata;", "GetSetUserLocation_Landroid_location_Location_Handler")]
		public unsafe virtual AdColonyUserMetadata SetUserLocation(Location location)
		{
			AdColonyUserMetadata @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((location == null) ? IntPtr.Zero : location.Handle);
				@object = Java.Lang.Object.GetObject<AdColonyUserMetadata>(AdColonyUserMetadata._members.InstanceMethods.InvokeVirtualObjectMethod("setUserLocation.(Landroid/location/Location;)Lcom/adcolony/sdk/AdColonyUserMetadata;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(location);
			}
			return @object;
		}

		// Token: 0x060003DD RID: 989 RVA: 0x0000C1E0 File Offset: 0x0000A3E0
		private static Delegate GetSetUserMaritalStatus_Ljava_lang_String_Handler()
		{
			if (AdColonyUserMetadata.cb_setUserMaritalStatus_Ljava_lang_String_ == null)
			{
				AdColonyUserMetadata.cb_setUserMaritalStatus_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AdColonyUserMetadata.n_SetUserMaritalStatus_Ljava_lang_String_));
			}
			return AdColonyUserMetadata.cb_setUserMaritalStatus_Ljava_lang_String_;
		}

		// Token: 0x060003DE RID: 990 RVA: 0x0000C204 File Offset: 0x0000A404
		private static IntPtr n_SetUserMaritalStatus_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_status)
		{
			AdColonyUserMetadata @object = Java.Lang.Object.GetObject<AdColonyUserMetadata>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_status, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetUserMaritalStatus(@string));
		}

		// Token: 0x060003DF RID: 991 RVA: 0x0000C22C File Offset: 0x0000A42C
		[Register("setUserMaritalStatus", "(Ljava/lang/String;)Lcom/adcolony/sdk/AdColonyUserMetadata;", "GetSetUserMaritalStatus_Ljava_lang_String_Handler")]
		public unsafe virtual AdColonyUserMetadata SetUserMaritalStatus(string status)
		{
			IntPtr intPtr = JNIEnv.NewString(status);
			AdColonyUserMetadata @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<AdColonyUserMetadata>(AdColonyUserMetadata._members.InstanceMethods.InvokeVirtualObjectMethod("setUserMaritalStatus.(Ljava/lang/String;)Lcom/adcolony/sdk/AdColonyUserMetadata;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x0000C298 File Offset: 0x0000A498
		private static Delegate GetSetUserZipCode_Ljava_lang_String_Handler()
		{
			if (AdColonyUserMetadata.cb_setUserZipCode_Ljava_lang_String_ == null)
			{
				AdColonyUserMetadata.cb_setUserZipCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AdColonyUserMetadata.n_SetUserZipCode_Ljava_lang_String_));
			}
			return AdColonyUserMetadata.cb_setUserZipCode_Ljava_lang_String_;
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x0000C2BC File Offset: 0x0000A4BC
		private static IntPtr n_SetUserZipCode_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_zip)
		{
			AdColonyUserMetadata @object = Java.Lang.Object.GetObject<AdColonyUserMetadata>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_zip, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetUserZipCode(@string));
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x0000C2E4 File Offset: 0x0000A4E4
		[Register("setUserZipCode", "(Ljava/lang/String;)Lcom/adcolony/sdk/AdColonyUserMetadata;", "GetSetUserZipCode_Ljava_lang_String_Handler")]
		public unsafe virtual AdColonyUserMetadata SetUserZipCode(string zip)
		{
			IntPtr intPtr = JNIEnv.NewString(zip);
			AdColonyUserMetadata @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<AdColonyUserMetadata>(AdColonyUserMetadata._members.InstanceMethods.InvokeVirtualObjectMethod("setUserZipCode.(Ljava/lang/String;)Lcom/adcolony/sdk/AdColonyUserMetadata;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x040000F4 RID: 244
		[Register("USER_EDUCATION_ASSOCIATES_DEGREE")]
		public const string UserEducationAssociatesDegree = "associates_degree";

		// Token: 0x040000F5 RID: 245
		[Register("USER_EDUCATION_BACHELORS_DEGREE")]
		public const string UserEducationBachelorsDegree = "bachelors_degree";

		// Token: 0x040000F6 RID: 246
		[Register("USER_EDUCATION_GRADE_SCHOOL")]
		public const string UserEducationGradeSchool = "grade_school";

		// Token: 0x040000F7 RID: 247
		[Register("USER_EDUCATION_GRADUATE_DEGREE")]
		public const string UserEducationGraduateDegree = "graduate_degree";

		// Token: 0x040000F8 RID: 248
		[Register("USER_EDUCATION_HIGH_SCHOOL_DIPLOMA")]
		public const string UserEducationHighSchoolDiploma = "high_school_diploma";

		// Token: 0x040000F9 RID: 249
		[Register("USER_EDUCATION_SOME_COLLEGE")]
		public const string UserEducationSomeCollege = "some_college";

		// Token: 0x040000FA RID: 250
		[Register("USER_EDUCATION_SOME_HIGH_SCHOOL")]
		public const string UserEducationSomeHighSchool = "some_high_school";

		// Token: 0x040000FB RID: 251
		[Register("USER_FEMALE")]
		public const string UserFemale = "female";

		// Token: 0x040000FC RID: 252
		[Register("USER_MALE")]
		public const string UserMale = "male";

		// Token: 0x040000FD RID: 253
		[Register("USER_MARRIED")]
		public const string UserMarried = "married";

		// Token: 0x040000FE RID: 254
		[Register("USER_SINGLE")]
		public const string UserSingle = "single";

		// Token: 0x040000FF RID: 255
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/adcolony/sdk/AdColonyUserMetadata", typeof(AdColonyUserMetadata));

		// Token: 0x04000100 RID: 256
		private static Delegate cb_getUserAge;

		// Token: 0x04000101 RID: 257
		private static Delegate cb_getUserAnnualHouseholdIncome;

		// Token: 0x04000102 RID: 258
		private static Delegate cb_getUserEducation;

		// Token: 0x04000103 RID: 259
		private static Delegate cb_getUserGender;

		// Token: 0x04000104 RID: 260
		private static Delegate cb_getUserLocation;

		// Token: 0x04000105 RID: 261
		private static Delegate cb_getUserMaritalStatus;

		// Token: 0x04000106 RID: 262
		private static Delegate cb_getUserZipCode;

		// Token: 0x04000107 RID: 263
		private static Delegate cb_addUserInterest_Ljava_lang_String_;

		// Token: 0x04000108 RID: 264
		private static Delegate cb_clearUserInterests;

		// Token: 0x04000109 RID: 265
		private static Delegate cb_getMetadata_Ljava_lang_String_;

		// Token: 0x0400010A RID: 266
		private static Delegate cb_getUserInterests;

		// Token: 0x0400010B RID: 267
		private static Delegate cb_setMetadata_Ljava_lang_String_Z;

		// Token: 0x0400010C RID: 268
		private static Delegate cb_setMetadata_Ljava_lang_String_D;

		// Token: 0x0400010D RID: 269
		private static Delegate cb_setMetadata_Ljava_lang_String_Ljava_lang_String_;

		// Token: 0x0400010E RID: 270
		private static Delegate cb_setUserAge_I;

		// Token: 0x0400010F RID: 271
		private static Delegate cb_setUserAnnualHouseholdIncome_I;

		// Token: 0x04000110 RID: 272
		private static Delegate cb_setUserEducation_Ljava_lang_String_;

		// Token: 0x04000111 RID: 273
		private static Delegate cb_setUserGender_Ljava_lang_String_;

		// Token: 0x04000112 RID: 274
		private static Delegate cb_setUserLocation_Landroid_location_Location_;

		// Token: 0x04000113 RID: 275
		private static Delegate cb_setUserMaritalStatus_Ljava_lang_String_;

		// Token: 0x04000114 RID: 276
		private static Delegate cb_setUserZipCode_Ljava_lang_String_;
	}
}
