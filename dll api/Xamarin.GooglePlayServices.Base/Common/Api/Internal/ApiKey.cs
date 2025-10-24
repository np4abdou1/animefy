using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Gms.Common.Apis;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Common.Api.Internal
{
	// Token: 0x0200001B RID: 27
	[Register("com/google/android/gms/common/api/internal/ApiKey", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"O extends com.google.android.gms.common.api.Api.ApiOptions"
	})]
	public sealed class ApiKey : Java.Lang.Object
	{
		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x00003CF0 File Offset: 0x00001EF0
		internal static IntPtr class_ref
		{
			get
			{
				return ApiKey._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x00003D14 File Offset: 0x00001F14
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ApiKey._members;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000EA RID: 234 RVA: 0x00003D1C File Offset: 0x00001F1C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ApiKey._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000EB RID: 235 RVA: 0x00003D40 File Offset: 0x00001F40
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ApiKey._members.ManagedPeerType;
			}
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00003280 File Offset: 0x00001480
		internal ApiKey(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00003D4C File Offset: 0x00001F4C
		[Register("equals", "(Ljava/lang/Object;)Z", "")]
		public unsafe sealed override bool Equals(Java.Lang.Object p0)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				result = ApiKey._members.InstanceMethods.InvokeNonvirtualBooleanMethod("equals.(Ljava/lang/Object;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return result;
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00003DB4 File Offset: 0x00001FB4
		[Register("getSharedApiKey", "(Lcom/google/android/gms/common/api/Api;Lcom/google/android/gms/common/api/Api$ApiOptions;Ljava/lang/String;)Lcom/google/android/gms/common/api/internal/ApiKey;", "")]
		[JavaTypeParameters(new string[]
		{
			"O extends com.google.android.gms.common.api.Api.ApiOptions"
		})]
		public unsafe static ApiKey GetSharedApiKey(Api api, Java.Lang.Object apiOptions, string attributionTag)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(apiOptions);
			IntPtr intPtr2 = JNIEnv.NewString(attributionTag);
			ApiKey @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((api == null) ? IntPtr.Zero : api.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue(intPtr2);
				@object = Java.Lang.Object.GetObject<ApiKey>(ApiKey._members.StaticMethods.InvokeObjectMethod("getSharedApiKey.(Lcom/google/android/gms/common/api/Api;Lcom/google/android/gms/common/api/Api$ApiOptions;Ljava/lang/String;)Lcom/google/android/gms/common/api/internal/ApiKey;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(api);
				GC.KeepAlive(apiOptions);
			}
			return @object;
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00003E74 File Offset: 0x00002074
		[Register("hashCode", "()I", "")]
		public sealed override int GetHashCode()
		{
			return ApiKey._members.InstanceMethods.InvokeNonvirtualInt32Method("hashCode.()I", this, null);
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00003E90 File Offset: 0x00002090
		[Register("zaa", "()Ljava/lang/String;", "")]
		public string Zaa()
		{
			return JNIEnv.GetString(ApiKey._members.InstanceMethods.InvokeNonvirtualObjectMethod("zaa.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000028 RID: 40
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/api/internal/ApiKey", typeof(ApiKey));
	}
}
