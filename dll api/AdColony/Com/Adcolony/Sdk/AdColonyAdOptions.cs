using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Adcolony.Sdk
{
	// Token: 0x0200003C RID: 60
	[Register("com/adcolony/sdk/AdColonyAdOptions", DoNotGenerateAcw = true)]
	public class AdColonyAdOptions : Java.Lang.Object
	{
		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000224 RID: 548 RVA: 0x000072B4 File Offset: 0x000054B4
		internal static IntPtr class_ref
		{
			get
			{
				return AdColonyAdOptions._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000225 RID: 549 RVA: 0x000072D8 File Offset: 0x000054D8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AdColonyAdOptions._members;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000226 RID: 550 RVA: 0x000072E0 File Offset: 0x000054E0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AdColonyAdOptions._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000227 RID: 551 RVA: 0x00007304 File Offset: 0x00005504
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AdColonyAdOptions._members.ManagedPeerType;
			}
		}

		// Token: 0x06000228 RID: 552 RVA: 0x00002128 File Offset: 0x00000328
		protected AdColonyAdOptions(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00007310 File Offset: 0x00005510
		[Register(".ctor", "()V", "")]
		public AdColonyAdOptions() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(AdColonyAdOptions._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			AdColonyAdOptions._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x0600022A RID: 554 RVA: 0x0000737E File Offset: 0x0000557E
		[Obsolete]
		private static Delegate GetGetUserMetadataHandler()
		{
			if (AdColonyAdOptions.cb_getUserMetadata == null)
			{
				AdColonyAdOptions.cb_getUserMetadata = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AdColonyAdOptions.n_GetUserMetadata));
			}
			return AdColonyAdOptions.cb_getUserMetadata;
		}

		// Token: 0x0600022B RID: 555 RVA: 0x000073A2 File Offset: 0x000055A2
		[Obsolete]
		private static IntPtr n_GetUserMetadata(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AdColonyAdOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).UserMetadata);
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x0600022C RID: 556 RVA: 0x000073B8 File Offset: 0x000055B8
		[Obsolete("deprecated")]
		public virtual AdColonyUserMetadata UserMetadata
		{
			[Register("getUserMetadata", "()Lcom/adcolony/sdk/AdColonyUserMetadata;", "GetGetUserMetadataHandler")]
			get
			{
				return Java.Lang.Object.GetObject<AdColonyUserMetadata>(AdColonyAdOptions._members.InstanceMethods.InvokeVirtualObjectMethod("getUserMetadata.()Lcom/adcolony/sdk/AdColonyUserMetadata;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600022D RID: 557 RVA: 0x000073EA File Offset: 0x000055EA
		private static Delegate GetEnableConfirmationDialog_ZHandler()
		{
			if (AdColonyAdOptions.cb_enableConfirmationDialog_Z == null)
			{
				AdColonyAdOptions.cb_enableConfirmationDialog_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_L(AdColonyAdOptions.n_EnableConfirmationDialog_Z));
			}
			return AdColonyAdOptions.cb_enableConfirmationDialog_Z;
		}

		// Token: 0x0600022E RID: 558 RVA: 0x0000740E File Offset: 0x0000560E
		private static IntPtr n_EnableConfirmationDialog_Z(IntPtr jnienv, IntPtr native__this, bool confirmation_enabled)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AdColonyAdOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).EnableConfirmationDialog(confirmation_enabled));
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00007424 File Offset: 0x00005624
		[Register("enableConfirmationDialog", "(Z)Lcom/adcolony/sdk/AdColonyAdOptions;", "GetEnableConfirmationDialog_ZHandler")]
		public unsafe virtual AdColonyAdOptions EnableConfirmationDialog(bool confirmation_enabled)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(confirmation_enabled);
			return Java.Lang.Object.GetObject<AdColonyAdOptions>(AdColonyAdOptions._members.InstanceMethods.InvokeVirtualObjectMethod("enableConfirmationDialog.(Z)Lcom/adcolony/sdk/AdColonyAdOptions;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000230 RID: 560 RVA: 0x0000746D File Offset: 0x0000566D
		private static Delegate GetEnableResultsDialog_ZHandler()
		{
			if (AdColonyAdOptions.cb_enableResultsDialog_Z == null)
			{
				AdColonyAdOptions.cb_enableResultsDialog_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_L(AdColonyAdOptions.n_EnableResultsDialog_Z));
			}
			return AdColonyAdOptions.cb_enableResultsDialog_Z;
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00007491 File Offset: 0x00005691
		private static IntPtr n_EnableResultsDialog_Z(IntPtr jnienv, IntPtr native__this, bool results_enabled)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AdColonyAdOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).EnableResultsDialog(results_enabled));
		}

		// Token: 0x06000232 RID: 562 RVA: 0x000074A8 File Offset: 0x000056A8
		[Register("enableResultsDialog", "(Z)Lcom/adcolony/sdk/AdColonyAdOptions;", "GetEnableResultsDialog_ZHandler")]
		public unsafe virtual AdColonyAdOptions EnableResultsDialog(bool results_enabled)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(results_enabled);
			return Java.Lang.Object.GetObject<AdColonyAdOptions>(AdColonyAdOptions._members.InstanceMethods.InvokeVirtualObjectMethod("enableResultsDialog.(Z)Lcom/adcolony/sdk/AdColonyAdOptions;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000233 RID: 563 RVA: 0x000074F1 File Offset: 0x000056F1
		private static Delegate GetGetOption_Ljava_lang_String_Handler()
		{
			if (AdColonyAdOptions.cb_getOption_Ljava_lang_String_ == null)
			{
				AdColonyAdOptions.cb_getOption_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AdColonyAdOptions.n_GetOption_Ljava_lang_String_));
			}
			return AdColonyAdOptions.cb_getOption_Ljava_lang_String_;
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00007518 File Offset: 0x00005718
		private static IntPtr n_GetOption_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			AdColonyAdOptions @object = Java.Lang.Object.GetObject<AdColonyAdOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_key, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetOption(@string));
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00007540 File Offset: 0x00005740
		[Register("getOption", "(Ljava/lang/String;)Ljava/lang/Object;", "GetGetOption_Ljava_lang_String_Handler")]
		public unsafe virtual Java.Lang.Object GetOption(string key)
		{
			IntPtr intPtr = JNIEnv.NewString(key);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(AdColonyAdOptions._members.InstanceMethods.InvokeVirtualObjectMethod("getOption.(Ljava/lang/String;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06000236 RID: 566 RVA: 0x000075AC File Offset: 0x000057AC
		private static Delegate GetSetOption_Ljava_lang_String_ZHandler()
		{
			if (AdColonyAdOptions.cb_setOption_Ljava_lang_String_Z == null)
			{
				AdColonyAdOptions.cb_setOption_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLZ_L(AdColonyAdOptions.n_SetOption_Ljava_lang_String_Z));
			}
			return AdColonyAdOptions.cb_setOption_Ljava_lang_String_Z;
		}

		// Token: 0x06000237 RID: 567 RVA: 0x000075D0 File Offset: 0x000057D0
		private static IntPtr n_SetOption_Ljava_lang_String_Z(IntPtr jnienv, IntPtr native__this, IntPtr native_key, bool value)
		{
			AdColonyAdOptions @object = Java.Lang.Object.GetObject<AdColonyAdOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_key, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetOption(@string, value));
		}

		// Token: 0x06000238 RID: 568 RVA: 0x000075FC File Offset: 0x000057FC
		[Register("setOption", "(Ljava/lang/String;Z)Lcom/adcolony/sdk/AdColonyAdOptions;", "GetSetOption_Ljava_lang_String_ZHandler")]
		public unsafe virtual AdColonyAdOptions SetOption(string key, bool value)
		{
			IntPtr intPtr = JNIEnv.NewString(key);
			AdColonyAdOptions @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(value);
				@object = Java.Lang.Object.GetObject<AdColonyAdOptions>(AdColonyAdOptions._members.InstanceMethods.InvokeVirtualObjectMethod("setOption.(Ljava/lang/String;Z)Lcom/adcolony/sdk/AdColonyAdOptions;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06000239 RID: 569 RVA: 0x0000767C File Offset: 0x0000587C
		private static Delegate GetSetOption_Ljava_lang_String_DHandler()
		{
			if (AdColonyAdOptions.cb_setOption_Ljava_lang_String_D == null)
			{
				AdColonyAdOptions.cb_setOption_Ljava_lang_String_D = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLD_L(AdColonyAdOptions.n_SetOption_Ljava_lang_String_D));
			}
			return AdColonyAdOptions.cb_setOption_Ljava_lang_String_D;
		}

		// Token: 0x0600023A RID: 570 RVA: 0x000076A0 File Offset: 0x000058A0
		private static IntPtr n_SetOption_Ljava_lang_String_D(IntPtr jnienv, IntPtr native__this, IntPtr native_key, double value)
		{
			AdColonyAdOptions @object = Java.Lang.Object.GetObject<AdColonyAdOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_key, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetOption(@string, value));
		}

		// Token: 0x0600023B RID: 571 RVA: 0x000076CC File Offset: 0x000058CC
		[Register("setOption", "(Ljava/lang/String;D)Lcom/adcolony/sdk/AdColonyAdOptions;", "GetSetOption_Ljava_lang_String_DHandler")]
		public unsafe virtual AdColonyAdOptions SetOption(string key, double value)
		{
			IntPtr intPtr = JNIEnv.NewString(key);
			AdColonyAdOptions @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(value);
				@object = Java.Lang.Object.GetObject<AdColonyAdOptions>(AdColonyAdOptions._members.InstanceMethods.InvokeVirtualObjectMethod("setOption.(Ljava/lang/String;D)Lcom/adcolony/sdk/AdColonyAdOptions;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x0600023C RID: 572 RVA: 0x0000774C File Offset: 0x0000594C
		private static Delegate GetSetOption_Ljava_lang_String_Ljava_lang_String_Handler()
		{
			if (AdColonyAdOptions.cb_setOption_Ljava_lang_String_Ljava_lang_String_ == null)
			{
				AdColonyAdOptions.cb_setOption_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(AdColonyAdOptions.n_SetOption_Ljava_lang_String_Ljava_lang_String_));
			}
			return AdColonyAdOptions.cb_setOption_Ljava_lang_String_Ljava_lang_String_;
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00007770 File Offset: 0x00005970
		private static IntPtr n_SetOption_Ljava_lang_String_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
		{
			AdColonyAdOptions @object = Java.Lang.Object.GetObject<AdColonyAdOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_key, JniHandleOwnership.DoNotTransfer);
			string string2 = JNIEnv.GetString(native_value, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetOption(@string, string2));
		}

		// Token: 0x0600023E RID: 574 RVA: 0x000077A4 File Offset: 0x000059A4
		[Register("setOption", "(Ljava/lang/String;Ljava/lang/String;)Lcom/adcolony/sdk/AdColonyAdOptions;", "GetSetOption_Ljava_lang_String_Ljava_lang_String_Handler")]
		public unsafe virtual AdColonyAdOptions SetOption(string key, string value)
		{
			IntPtr intPtr = JNIEnv.NewString(key);
			IntPtr intPtr2 = JNIEnv.NewString(value);
			AdColonyAdOptions @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@object = Java.Lang.Object.GetObject<AdColonyAdOptions>(AdColonyAdOptions._members.InstanceMethods.InvokeVirtualObjectMethod("setOption.(Ljava/lang/String;Ljava/lang/String;)Lcom/adcolony/sdk/AdColonyAdOptions;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
			return @object;
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00007834 File Offset: 0x00005A34
		[Obsolete]
		private static Delegate GetSetUserMetadata_Lcom_adcolony_sdk_AdColonyUserMetadata_Handler()
		{
			if (AdColonyAdOptions.cb_setUserMetadata_Lcom_adcolony_sdk_AdColonyUserMetadata_ == null)
			{
				AdColonyAdOptions.cb_setUserMetadata_Lcom_adcolony_sdk_AdColonyUserMetadata_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AdColonyAdOptions.n_SetUserMetadata_Lcom_adcolony_sdk_AdColonyUserMetadata_));
			}
			return AdColonyAdOptions.cb_setUserMetadata_Lcom_adcolony_sdk_AdColonyUserMetadata_;
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00007858 File Offset: 0x00005A58
		[Obsolete]
		private static IntPtr n_SetUserMetadata_Lcom_adcolony_sdk_AdColonyUserMetadata_(IntPtr jnienv, IntPtr native__this, IntPtr native_metadata)
		{
			AdColonyAdOptions @object = Java.Lang.Object.GetObject<AdColonyAdOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AdColonyUserMetadata object2 = Java.Lang.Object.GetObject<AdColonyUserMetadata>(native_metadata, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetUserMetadata(object2));
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00007880 File Offset: 0x00005A80
		[Obsolete("deprecated")]
		[Register("setUserMetadata", "(Lcom/adcolony/sdk/AdColonyUserMetadata;)Lcom/adcolony/sdk/AdColonyAdOptions;", "GetSetUserMetadata_Lcom_adcolony_sdk_AdColonyUserMetadata_Handler")]
		public unsafe virtual AdColonyAdOptions SetUserMetadata(AdColonyUserMetadata metadata)
		{
			AdColonyAdOptions @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((metadata == null) ? IntPtr.Zero : metadata.Handle);
				@object = Java.Lang.Object.GetObject<AdColonyAdOptions>(AdColonyAdOptions._members.InstanceMethods.InvokeVirtualObjectMethod("setUserMetadata.(Lcom/adcolony/sdk/AdColonyUserMetadata;)Lcom/adcolony/sdk/AdColonyAdOptions;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(metadata);
			}
			return @object;
		}

		// Token: 0x0400005A RID: 90
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/adcolony/sdk/AdColonyAdOptions", typeof(AdColonyAdOptions));

		// Token: 0x0400005B RID: 91
		private static Delegate cb_getUserMetadata;

		// Token: 0x0400005C RID: 92
		private static Delegate cb_enableConfirmationDialog_Z;

		// Token: 0x0400005D RID: 93
		private static Delegate cb_enableResultsDialog_Z;

		// Token: 0x0400005E RID: 94
		private static Delegate cb_getOption_Ljava_lang_String_;

		// Token: 0x0400005F RID: 95
		private static Delegate cb_setOption_Ljava_lang_String_Z;

		// Token: 0x04000060 RID: 96
		private static Delegate cb_setOption_Ljava_lang_String_D;

		// Token: 0x04000061 RID: 97
		private static Delegate cb_setOption_Ljava_lang_String_Ljava_lang_String_;

		// Token: 0x04000062 RID: 98
		private static Delegate cb_setUserMetadata_Lcom_adcolony_sdk_AdColonyUserMetadata_;
	}
}
