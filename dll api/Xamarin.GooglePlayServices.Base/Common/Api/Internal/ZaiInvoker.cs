using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Gms.Common.Apis;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Common.Api.Internal
{
	// Token: 0x02000042 RID: 66
	[Register("com/google/android/gms/common/api/internal/zai", DoNotGenerateAcw = true)]
	internal class ZaiInvoker : Zai
	{
		// Token: 0x0600029A RID: 666 RVA: 0x00008A77 File Offset: 0x00006C77
		public ZaiInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x0600029B RID: 667 RVA: 0x00008A81 File Offset: 0x00006C81
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ZaiInvoker._members;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x0600029C RID: 668 RVA: 0x00008A88 File Offset: 0x00006C88
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ZaiInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600029D RID: 669 RVA: 0x00008A94 File Offset: 0x00006C94
		[Register("zad", "(Lcom/google/android/gms/common/api/Status;)V", "GetZad_Lcom_google_android_gms_common_api_Status_Handler")]
		public unsafe override void Zad(Statuses p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ZaiInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("zad.(Lcom/google/android/gms/common/api/Status;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00008AF8 File Offset: 0x00006CF8
		[Register("zae", "(Ljava/lang/Exception;)V", "GetZae_Ljava_lang_Exception_Handler")]
		public unsafe override void Zae(Java.Lang.Exception p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ZaiInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("zae.(Ljava/lang/Exception;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x0600029F RID: 671 RVA: 0x00008B5C File Offset: 0x00006D5C
		[Register("zaf", "(Lcom/google/android/gms/common/api/internal/zabq;)V", "GetZaf_Lcom_google_android_gms_common_api_internal_zabq_Handler")]
		public unsafe override void Zaf(Zabq p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ZaiInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("zaf.(Lcom/google/android/gms/common/api/internal/zabq;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x00008BC0 File Offset: 0x00006DC0
		[Register("zag", "(Lcom/google/android/gms/common/api/internal/zaad;Z)V", "GetZag_Lcom_google_android_gms_common_api_internal_zaad_ZHandler")]
		public unsafe override void Zag(Zaad p0, bool p1)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue(p1);
				ZaiInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("zag.(Lcom/google/android/gms/common/api/internal/zaad;Z)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x04000087 RID: 135
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/api/internal/zai", typeof(ZaiInvoker));
	}
}
