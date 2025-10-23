using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Java.Interop;

namespace Com.Unity3d.Scar.Adapter.Common.Signals
{
	// Token: 0x020002B8 RID: 696
	[Register("com/unity3d/scar/adapter/common/signals/SignalsCollectorBase", DoNotGenerateAcw = true)]
	internal class SignalsCollectorBaseInvoker : SignalsCollectorBase
	{
		// Token: 0x06002768 RID: 10088 RVA: 0x0005483C File Offset: 0x00052A3C
		public SignalsCollectorBaseInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000EED RID: 3821
		// (get) Token: 0x06002769 RID: 10089 RVA: 0x00065C11 File Offset: 0x00063E11
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SignalsCollectorBaseInvoker._members;
			}
		}

		// Token: 0x17000EEE RID: 3822
		// (get) Token: 0x0600276A RID: 10090 RVA: 0x00065C18 File Offset: 0x00063E18
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SignalsCollectorBaseInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600276B RID: 10091 RVA: 0x00065C24 File Offset: 0x00063E24
		[Register("getSCARSignal", "(Landroid/content/Context;Ljava/lang/String;ZLcom/unity3d/scar/adapter/common/DispatchGroup;Lcom/unity3d/scar/adapter/common/signals/SignalsResult;)V", "GetGetSCARSignal_Landroid_content_Context_Ljava_lang_String_ZLcom_unity3d_scar_adapter_common_DispatchGroup_Lcom_unity3d_scar_adapter_common_signals_SignalsResult_Handler")]
		public unsafe override void GetSCARSignal(Context p0, string p1, bool p2, DispatchGroup p3, SignalsResult p4)
		{
			IntPtr intPtr = JNIEnv.NewString(p1);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue(p2);
				ptr[3] = new JniArgumentValue((p3 == null) ? IntPtr.Zero : p3.Handle);
				ptr[4] = new JniArgumentValue((p4 == null) ? IntPtr.Zero : p4.Handle);
				SignalsCollectorBaseInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("getSCARSignal.(Landroid/content/Context;Ljava/lang/String;ZLcom/unity3d/scar/adapter/common/DispatchGroup;Lcom/unity3d/scar/adapter/common/signals/SignalsResult;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
				GC.KeepAlive(p3);
				GC.KeepAlive(p4);
			}
		}

		// Token: 0x040007E0 RID: 2016
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/common/signals/SignalsCollectorBase", typeof(SignalsCollectorBaseInvoker));
	}
}
