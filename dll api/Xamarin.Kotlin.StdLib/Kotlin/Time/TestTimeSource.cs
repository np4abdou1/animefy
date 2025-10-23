using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;

namespace Kotlin.Time
{
	// Token: 0x020000D5 RID: 213
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/time/TestTimeSource", DoNotGenerateAcw = true)]
	public sealed class TestTimeSource : AbstractLongTimeSource
	{
		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x0600066A RID: 1642 RVA: 0x00010188 File Offset: 0x0000E388
		internal new static IntPtr class_ref
		{
			get
			{
				return TestTimeSource._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x0600066B RID: 1643 RVA: 0x000101AC File Offset: 0x0000E3AC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return TestTimeSource._members;
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x0600066C RID: 1644 RVA: 0x000101B4 File Offset: 0x0000E3B4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return TestTimeSource._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x0600066D RID: 1645 RVA: 0x000101D8 File Offset: 0x0000E3D8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return TestTimeSource._members.ManagedPeerType;
			}
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x000101E4 File Offset: 0x0000E3E4
		internal TestTimeSource(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x000101F0 File Offset: 0x0000E3F0
		[Register(".ctor", "()V", "")]
		public TestTimeSource() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(TestTimeSource._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			TestTimeSource._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x00010260 File Offset: 0x0000E460
		[Register("plusAssign-LRDsOJo", "(J)V", "")]
		public unsafe void PlusAssign(long duration)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(duration);
			TestTimeSource._members.InstanceMethods.InvokeNonvirtualVoidMethod("plusAssign-LRDsOJo.(J)V", this, ptr);
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x0001029B File Offset: 0x0000E49B
		[Register("read", "()J", "")]
		protected override long Read()
		{
			return TestTimeSource._members.InstanceMethods.InvokeAbstractInt64Method("read.()J", this, null);
		}

		// Token: 0x040001C6 RID: 454
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/time/TestTimeSource", typeof(TestTimeSource));
	}
}
