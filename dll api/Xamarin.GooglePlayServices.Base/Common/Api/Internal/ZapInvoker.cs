using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Android.Gms.Common.Api.Internal
{
	// Token: 0x02000045 RID: 69
	[Register("com/google/android/gms/common/api/internal/zap", DoNotGenerateAcw = true)]
	internal class ZapInvoker : Zap
	{
		// Token: 0x060002BF RID: 703 RVA: 0x00008058 File Offset: 0x00006258
		public ZapInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060002C0 RID: 704 RVA: 0x000091FB File Offset: 0x000073FB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ZapInvoker._members;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060002C1 RID: 705 RVA: 0x00009202 File Offset: 0x00007402
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ZapInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00009210 File Offset: 0x00007410
		[Register("zab", "(Lcom/google/android/gms/common/ConnectionResult;I)V", "GetZab_Lcom_google_android_gms_common_ConnectionResult_IHandler")]
		protected unsafe override void Zab(ConnectionResult p0, int p1)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue(p1);
				ZapInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("zab.(Lcom/google/android/gms/common/ConnectionResult;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x00009288 File Offset: 0x00007488
		[Register("zac", "()V", "GetZacHandler")]
		protected override void Zac()
		{
			ZapInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("zac.()V", this, null);
		}

		// Token: 0x0400008C RID: 140
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/api/internal/zap", typeof(ZapInvoker));
	}
}
