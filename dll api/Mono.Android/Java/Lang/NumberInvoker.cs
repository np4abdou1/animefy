using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Java.Lang
{
	// Token: 0x020003E9 RID: 1001
	[Register("java/lang/Number", DoNotGenerateAcw = true)]
	internal class NumberInvoker : Number
	{
		// Token: 0x06002BF6 RID: 11254 RVA: 0x000759E0 File Offset: 0x00073BE0
		public NumberInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x170008A9 RID: 2217
		// (get) Token: 0x06002BF7 RID: 11255 RVA: 0x000799BF File Offset: 0x00077BBF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return NumberInvoker._members;
			}
		}

		// Token: 0x170008AA RID: 2218
		// (get) Token: 0x06002BF8 RID: 11256 RVA: 0x000799C6 File Offset: 0x00077BC6
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return NumberInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06002BF9 RID: 11257 RVA: 0x000799D2 File Offset: 0x00077BD2
		public override double DoubleValue()
		{
			return NumberInvoker._members.InstanceMethods.InvokeAbstractDoubleMethod("doubleValue.()D", this, null);
		}

		// Token: 0x06002BFA RID: 11258 RVA: 0x000799EB File Offset: 0x00077BEB
		public override float FloatValue()
		{
			return NumberInvoker._members.InstanceMethods.InvokeAbstractSingleMethod("floatValue.()F", this, null);
		}

		// Token: 0x06002BFB RID: 11259 RVA: 0x00079A04 File Offset: 0x00077C04
		public override int IntValue()
		{
			return NumberInvoker._members.InstanceMethods.InvokeAbstractInt32Method("intValue.()I", this, null);
		}

		// Token: 0x06002BFC RID: 11260 RVA: 0x00079A1D File Offset: 0x00077C1D
		public override long LongValue()
		{
			return NumberInvoker._members.InstanceMethods.InvokeAbstractInt64Method("longValue.()J", this, null);
		}

		// Token: 0x0400117F RID: 4479
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/lang/Number", typeof(NumberInvoker));
	}
}
