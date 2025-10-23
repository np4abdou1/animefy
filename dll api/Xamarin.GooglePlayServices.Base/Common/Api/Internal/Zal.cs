using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using Android.Gms.Tasks;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Common.Api.Internal
{
	// Token: 0x02000043 RID: 67
	[Register("com/google/android/gms/common/api/internal/zal", DoNotGenerateAcw = true)]
	public sealed class Zal : Java.Lang.Object
	{
		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060002A2 RID: 674 RVA: 0x00008C54 File Offset: 0x00006E54
		internal static IntPtr class_ref
		{
			get
			{
				return Zal._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060002A3 RID: 675 RVA: 0x00008C78 File Offset: 0x00006E78
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Zal._members;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060002A4 RID: 676 RVA: 0x00008C80 File Offset: 0x00006E80
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Zal._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060002A5 RID: 677 RVA: 0x00008CA4 File Offset: 0x00006EA4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Zal._members.ManagedPeerType;
			}
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00003280 File Offset: 0x00001480
		internal Zal(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00008CB0 File Offset: 0x00006EB0
		[Register(".ctor", "(Ljava/lang/Iterable;)V", "")]
		public unsafe Zal(IIterable p0) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				base.SetHandle(Zal._members.InstanceMethods.StartCreateInstance("(Ljava/lang/Iterable;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				Zal._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/Iterable;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00008D64 File Offset: 0x00006F64
		[Register("zaa", "()Lcom/google/android/gms/tasks/Task;", "")]
		public Task Zaa()
		{
			return Java.Lang.Object.GetObject<Task>(Zal._members.InstanceMethods.InvokeNonvirtualObjectMethod("zaa.()Lcom/google/android/gms/tasks/Task;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00008D98 File Offset: 0x00006F98
		[Register("zab", "()Ljava/util/Set;", "")]
		public ICollection Zab()
		{
			return JavaSet.FromJniHandle(Zal._members.InstanceMethods.InvokeNonvirtualObjectMethod("zab.()Ljava/util/Set;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060002AA RID: 682 RVA: 0x00008DCC File Offset: 0x00006FCC
		[Register("zac", "(Lcom/google/android/gms/common/api/internal/ApiKey;Lcom/google/android/gms/common/ConnectionResult;Ljava/lang/String;)V", "")]
		public unsafe void Zac(ApiKey p0, ConnectionResult p1, string p2)
		{
			IntPtr intPtr = JNIEnv.NewString(p2);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				ptr[2] = new JniArgumentValue(intPtr);
				Zal._members.InstanceMethods.InvokeNonvirtualVoidMethod("zac.(Lcom/google/android/gms/common/api/internal/ApiKey;Lcom/google/android/gms/common/ConnectionResult;Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x04000088 RID: 136
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/api/internal/zal", typeof(Zal));
	}
}
