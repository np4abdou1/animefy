using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Com.Adcolony.Sdk
{
	// Token: 0x02000049 RID: 73
	[Register("com/adcolony/sdk/AdColonySignalsListener", DoNotGenerateAcw = true)]
	internal class AdColonySignalsListenerInvoker : AdColonySignalsListener
	{
		// Token: 0x06000399 RID: 921 RVA: 0x0000B5AE File Offset: 0x000097AE
		public AdColonySignalsListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x0600039A RID: 922 RVA: 0x0000B5B8 File Offset: 0x000097B8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AdColonySignalsListenerInvoker._members;
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x0600039B RID: 923 RVA: 0x0000B5BF File Offset: 0x000097BF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AdColonySignalsListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600039C RID: 924 RVA: 0x0000B5CC File Offset: 0x000097CC
		[Register("onSuccess", "(Ljava/lang/String;)V", "GetOnSuccess_Ljava_lang_String_Handler")]
		public unsafe override void OnSuccess(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				AdColonySignalsListenerInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("onSuccess.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x040000F3 RID: 243
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/adcolony/sdk/AdColonySignalsListener", typeof(AdColonySignalsListenerInvoker));
	}
}
