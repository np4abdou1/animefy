using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Ads.Metadata
{
	// Token: 0x020002E0 RID: 736
	[Register("com/unity3d/ads/metadata/MediationMetaData", DoNotGenerateAcw = true)]
	public class MediationMetaData : MetaData
	{
		// Token: 0x17000F71 RID: 3953
		// (get) Token: 0x060028D0 RID: 10448 RVA: 0x000699E0 File Offset: 0x00067BE0
		internal new static IntPtr class_ref
		{
			get
			{
				return MediationMetaData._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000F72 RID: 3954
		// (get) Token: 0x060028D1 RID: 10449 RVA: 0x00069A04 File Offset: 0x00067C04
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MediationMetaData._members;
			}
		}

		// Token: 0x17000F73 RID: 3955
		// (get) Token: 0x060028D2 RID: 10450 RVA: 0x00069A0C File Offset: 0x00067C0C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MediationMetaData._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000F74 RID: 3956
		// (get) Token: 0x060028D3 RID: 10451 RVA: 0x00069A30 File Offset: 0x00067C30
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MediationMetaData._members.ManagedPeerType;
			}
		}

		// Token: 0x060028D4 RID: 10452 RVA: 0x000695CC File Offset: 0x000677CC
		protected MediationMetaData(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060028D5 RID: 10453 RVA: 0x00069A3C File Offset: 0x00067C3C
		[Register(".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe MediationMetaData(Context context) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				base.SetHandle(MediationMetaData._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				MediationMetaData._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
		}

		// Token: 0x060028D6 RID: 10454 RVA: 0x00069AEC File Offset: 0x00067CEC
		private static Delegate GetSetMissedImpressionOrdinal_IHandler()
		{
			if (MediationMetaData.cb_setMissedImpressionOrdinal_I == null)
			{
				MediationMetaData.cb_setMissedImpressionOrdinal_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(MediationMetaData.n_SetMissedImpressionOrdinal_I));
			}
			return MediationMetaData.cb_setMissedImpressionOrdinal_I;
		}

		// Token: 0x060028D7 RID: 10455 RVA: 0x00069B10 File Offset: 0x00067D10
		private static void n_SetMissedImpressionOrdinal_I(IntPtr jnienv, IntPtr native__this, int ordinal)
		{
			Java.Lang.Object.GetObject<MediationMetaData>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetMissedImpressionOrdinal(ordinal);
		}

		// Token: 0x060028D8 RID: 10456 RVA: 0x00069B20 File Offset: 0x00067D20
		[Register("setMissedImpressionOrdinal", "(I)V", "GetSetMissedImpressionOrdinal_IHandler")]
		public unsafe virtual void SetMissedImpressionOrdinal(int ordinal)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(ordinal);
			MediationMetaData._members.InstanceMethods.InvokeVirtualVoidMethod("setMissedImpressionOrdinal.(I)V", this, ptr);
		}

		// Token: 0x060028D9 RID: 10457 RVA: 0x00069B5B File Offset: 0x00067D5B
		private static Delegate GetSetName_Ljava_lang_String_Handler()
		{
			if (MediationMetaData.cb_setName_Ljava_lang_String_ == null)
			{
				MediationMetaData.cb_setName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MediationMetaData.n_SetName_Ljava_lang_String_));
			}
			return MediationMetaData.cb_setName_Ljava_lang_String_;
		}

		// Token: 0x060028DA RID: 10458 RVA: 0x00069B80 File Offset: 0x00067D80
		private static void n_SetName_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_mediationNetworkName)
		{
			MediationMetaData @object = Java.Lang.Object.GetObject<MediationMetaData>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_mediationNetworkName, JniHandleOwnership.DoNotTransfer);
			@object.SetName(@string);
		}

		// Token: 0x060028DB RID: 10459 RVA: 0x00069BA4 File Offset: 0x00067DA4
		[Register("setName", "(Ljava/lang/String;)V", "GetSetName_Ljava_lang_String_Handler")]
		public unsafe virtual void SetName(string mediationNetworkName)
		{
			IntPtr intPtr = JNIEnv.NewString(mediationNetworkName);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				MediationMetaData._members.InstanceMethods.InvokeVirtualVoidMethod("setName.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x060028DC RID: 10460 RVA: 0x00069C00 File Offset: 0x00067E00
		private static Delegate GetSetOrdinal_IHandler()
		{
			if (MediationMetaData.cb_setOrdinal_I == null)
			{
				MediationMetaData.cb_setOrdinal_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(MediationMetaData.n_SetOrdinal_I));
			}
			return MediationMetaData.cb_setOrdinal_I;
		}

		// Token: 0x060028DD RID: 10461 RVA: 0x00069C24 File Offset: 0x00067E24
		private static void n_SetOrdinal_I(IntPtr jnienv, IntPtr native__this, int ordinal)
		{
			Java.Lang.Object.GetObject<MediationMetaData>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetOrdinal(ordinal);
		}

		// Token: 0x060028DE RID: 10462 RVA: 0x00069C34 File Offset: 0x00067E34
		[Register("setOrdinal", "(I)V", "GetSetOrdinal_IHandler")]
		public unsafe virtual void SetOrdinal(int ordinal)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(ordinal);
			MediationMetaData._members.InstanceMethods.InvokeVirtualVoidMethod("setOrdinal.(I)V", this, ptr);
		}

		// Token: 0x060028DF RID: 10463 RVA: 0x00069C6F File Offset: 0x00067E6F
		private static Delegate GetSetVersion_Ljava_lang_String_Handler()
		{
			if (MediationMetaData.cb_setVersion_Ljava_lang_String_ == null)
			{
				MediationMetaData.cb_setVersion_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MediationMetaData.n_SetVersion_Ljava_lang_String_));
			}
			return MediationMetaData.cb_setVersion_Ljava_lang_String_;
		}

		// Token: 0x060028E0 RID: 10464 RVA: 0x00069C94 File Offset: 0x00067E94
		private static void n_SetVersion_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_mediationSdkVersion)
		{
			MediationMetaData @object = Java.Lang.Object.GetObject<MediationMetaData>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_mediationSdkVersion, JniHandleOwnership.DoNotTransfer);
			@object.SetVersion(@string);
		}

		// Token: 0x060028E1 RID: 10465 RVA: 0x00069CB8 File Offset: 0x00067EB8
		[Register("setVersion", "(Ljava/lang/String;)V", "GetSetVersion_Ljava_lang_String_Handler")]
		public unsafe virtual void SetVersion(string mediationSdkVersion)
		{
			IntPtr intPtr = JNIEnv.NewString(mediationSdkVersion);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				MediationMetaData._members.InstanceMethods.InvokeVirtualVoidMethod("setVersion.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x04000852 RID: 2130
		[Register("KEY_MISSED_IMPRESSION_ORDINAL")]
		public const string KeyMissedImpressionOrdinal = "missedImpressionOrdinal";

		// Token: 0x04000853 RID: 2131
		[Register("KEY_NAME")]
		public const string KeyName = "name";

		// Token: 0x04000854 RID: 2132
		[Register("KEY_ORDINAL")]
		public const string KeyOrdinal = "ordinal";

		// Token: 0x04000855 RID: 2133
		[Register("KEY_VERSION")]
		public const string KeyVersion = "version";

		// Token: 0x04000856 RID: 2134
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/ads/metadata/MediationMetaData", typeof(MediationMetaData));

		// Token: 0x04000857 RID: 2135
		private static Delegate cb_setMissedImpressionOrdinal_I;

		// Token: 0x04000858 RID: 2136
		private static Delegate cb_setName_Ljava_lang_String_;

		// Token: 0x04000859 RID: 2137
		private static Delegate cb_setOrdinal_I;

		// Token: 0x0400085A RID: 2138
		private static Delegate cb_setVersion_Ljava_lang_String_;
	}
}
