using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Common.Apis
{
	// Token: 0x02000070 RID: 112
	[Register("com/google/android/gms/common/api/TransformedResult", DoNotGenerateAcw = true)]
	internal class TransformedResultInvoker : TransformedResult
	{
		// Token: 0x060004CA RID: 1226 RVA: 0x0000E5C3 File Offset: 0x0000C7C3
		public TransformedResultInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x060004CB RID: 1227 RVA: 0x0000E5CD File Offset: 0x0000C7CD
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return TransformedResultInvoker._members;
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x060004CC RID: 1228 RVA: 0x0000E5D4 File Offset: 0x0000C7D4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return TransformedResultInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x0000E5E0 File Offset: 0x0000C7E0
		[Register("andFinally", "(Lcom/google/android/gms/common/api/ResultCallbacks;)V", "GetAndFinally_Lcom_google_android_gms_common_api_ResultCallbacks_Handler")]
		public unsafe override void AndFinally(ResultCallbacks p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				TransformedResultInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("andFinally.(Lcom/google/android/gms/common/api/ResultCallbacks;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x0000E644 File Offset: 0x0000C844
		[Register("then", "(Lcom/google/android/gms/common/api/ResultTransform;)Lcom/google/android/gms/common/api/TransformedResult;", "GetThen_Lcom_google_android_gms_common_api_ResultTransform_Handler")]
		[JavaTypeParameters(new string[]
		{
			"S extends com.google.android.gms.common.api.Result"
		})]
		public unsafe override TransformedResult Then(ResultTransform p0)
		{
			TransformedResult @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				@object = Java.Lang.Object.GetObject<TransformedResult>(TransformedResultInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("then.(Lcom/google/android/gms/common/api/ResultTransform;)Lcom/google/android/gms/common/api/TransformedResult;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return @object;
		}

		// Token: 0x04000124 RID: 292
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/api/TransformedResult", typeof(TransformedResultInvoker));
	}
}
