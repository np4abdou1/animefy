using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Cct.Internal
{
	// Token: 0x0200000E RID: 14
	[Register("com/google/android/datatransport/cct/internal/AndroidClientInfo", DoNotGenerateAcw = true)]
	internal class AndroidClientInfoInvoker : AndroidClientInfo
	{
		// Token: 0x060000A2 RID: 162 RVA: 0x0000344B File Offset: 0x0000164B
		public AndroidClientInfoInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x00003455 File Offset: 0x00001655
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AndroidClientInfoInvoker._members;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x0000345C File Offset: 0x0000165C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AndroidClientInfoInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x00003468 File Offset: 0x00001668
		public override string ApplicationBuild
		{
			[Register("getApplicationBuild", "()Ljava/lang/String;", "GetGetApplicationBuildHandler")]
			get
			{
				return JNIEnv.GetString(AndroidClientInfoInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getApplicationBuild.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x0000349C File Offset: 0x0000169C
		public override string Country
		{
			[Register("getCountry", "()Ljava/lang/String;", "GetGetCountryHandler")]
			get
			{
				return JNIEnv.GetString(AndroidClientInfoInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getCountry.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x000034D0 File Offset: 0x000016D0
		public override string Device
		{
			[Register("getDevice", "()Ljava/lang/String;", "GetGetDeviceHandler")]
			get
			{
				return JNIEnv.GetString(AndroidClientInfoInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getDevice.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x00003504 File Offset: 0x00001704
		public override string Fingerprint
		{
			[Register("getFingerprint", "()Ljava/lang/String;", "GetGetFingerprintHandler")]
			get
			{
				return JNIEnv.GetString(AndroidClientInfoInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getFingerprint.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x00003538 File Offset: 0x00001738
		public override string Hardware
		{
			[Register("getHardware", "()Ljava/lang/String;", "GetGetHardwareHandler")]
			get
			{
				return JNIEnv.GetString(AndroidClientInfoInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getHardware.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000AA RID: 170 RVA: 0x0000356C File Offset: 0x0000176C
		public override string Locale
		{
			[Register("getLocale", "()Ljava/lang/String;", "GetGetLocaleHandler")]
			get
			{
				return JNIEnv.GetString(AndroidClientInfoInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getLocale.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000AB RID: 171 RVA: 0x000035A0 File Offset: 0x000017A0
		public override string Manufacturer
		{
			[Register("getManufacturer", "()Ljava/lang/String;", "GetGetManufacturerHandler")]
			get
			{
				return JNIEnv.GetString(AndroidClientInfoInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getManufacturer.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000AC RID: 172 RVA: 0x000035D4 File Offset: 0x000017D4
		public override string MccMnc
		{
			[Register("getMccMnc", "()Ljava/lang/String;", "GetGetMccMncHandler")]
			get
			{
				return JNIEnv.GetString(AndroidClientInfoInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getMccMnc.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000AD RID: 173 RVA: 0x00003608 File Offset: 0x00001808
		public override string Model
		{
			[Register("getModel", "()Ljava/lang/String;", "GetGetModelHandler")]
			get
			{
				return JNIEnv.GetString(AndroidClientInfoInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getModel.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000AE RID: 174 RVA: 0x0000363C File Offset: 0x0000183C
		public override string OsBuild
		{
			[Register("getOsBuild", "()Ljava/lang/String;", "GetGetOsBuildHandler")]
			get
			{
				return JNIEnv.GetString(AndroidClientInfoInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getOsBuild.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000AF RID: 175 RVA: 0x00003670 File Offset: 0x00001870
		public override string Product
		{
			[Register("getProduct", "()Ljava/lang/String;", "GetGetProductHandler")]
			get
			{
				return JNIEnv.GetString(AndroidClientInfoInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getProduct.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x000036A4 File Offset: 0x000018A4
		public override Integer SdkVersion
		{
			[Register("getSdkVersion", "()Ljava/lang/Integer;", "GetGetSdkVersionHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Integer>(AndroidClientInfoInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getSdkVersion.()Ljava/lang/Integer;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x04000021 RID: 33
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/cct/internal/AndroidClientInfo", typeof(AndroidClientInfoInvoker));
	}
}
