using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Java.Lang
{
	// Token: 0x020003ED RID: 1005
	[Register("java/lang/Short", DoNotGenerateAcw = true)]
	public sealed class Short : Number, IComparable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170008BB RID: 2235
		// (get) Token: 0x06002C3E RID: 11326 RVA: 0x0007A307 File Offset: 0x00078507
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Short._members;
			}
		}

		// Token: 0x170008BC RID: 2236
		// (get) Token: 0x06002C3F RID: 11327 RVA: 0x0007A310 File Offset: 0x00078510
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Short._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170008BD RID: 2237
		// (get) Token: 0x06002C40 RID: 11328 RVA: 0x0007A334 File Offset: 0x00078534
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Short._members.ManagedPeerType;
			}
		}

		// Token: 0x06002C41 RID: 11329 RVA: 0x000759E0 File Offset: 0x00073BE0
		internal Short(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06002C42 RID: 11330 RVA: 0x0007A340 File Offset: 0x00078540
		public unsafe Short(short value) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(value);
			base.SetHandle(Short._members.InstanceMethods.StartCreateInstance("(S)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			Short._members.InstanceMethods.FinishCreateInstance("(S)V", this, ptr);
		}

		// Token: 0x06002C43 RID: 11331 RVA: 0x0007A3C4 File Offset: 0x000785C4
		public unsafe int CompareTo(Short anotherShort)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((anotherShort == null) ? IntPtr.Zero : anotherShort.Handle);
				result = Short._members.InstanceMethods.InvokeAbstractInt32Method("compareTo.(Ljava/lang/Short;)I", this, ptr);
			}
			finally
			{
				GC.KeepAlive(anotherShort);
			}
			return result;
		}

		// Token: 0x06002C44 RID: 11332 RVA: 0x0007A42C File Offset: 0x0007862C
		public override double DoubleValue()
		{
			return Short._members.InstanceMethods.InvokeAbstractDoubleMethod("doubleValue.()D", this, null);
		}

		// Token: 0x06002C45 RID: 11333 RVA: 0x0007A445 File Offset: 0x00078645
		public override float FloatValue()
		{
			return Short._members.InstanceMethods.InvokeAbstractSingleMethod("floatValue.()F", this, null);
		}

		// Token: 0x06002C46 RID: 11334 RVA: 0x0007A45E File Offset: 0x0007865E
		public override int IntValue()
		{
			return Short._members.InstanceMethods.InvokeAbstractInt32Method("intValue.()I", this, null);
		}

		// Token: 0x06002C47 RID: 11335 RVA: 0x0007A477 File Offset: 0x00078677
		public override long LongValue()
		{
			return Short._members.InstanceMethods.InvokeAbstractInt64Method("longValue.()J", this, null);
		}

		// Token: 0x06002C48 RID: 11336 RVA: 0x0007A490 File Offset: 0x00078690
		int IComparable.CompareTo(Object o)
		{
			return this.CompareTo(o.JavaCast<Short>());
		}

		// Token: 0x0400118D RID: 4493
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/lang/Short", typeof(Short));
	}
}
