using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Java.Lang
{
	// Token: 0x020003E4 RID: 996
	[Register("java/lang/Long", DoNotGenerateAcw = true)]
	public sealed class Long : Number, IComparable, IJavaObject, IDisposable, IJavaPeerable, IConvertible
	{
		// Token: 0x1700089A RID: 2202
		// (get) Token: 0x06002BB0 RID: 11184 RVA: 0x000792FF File Offset: 0x000774FF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Long._members;
			}
		}

		// Token: 0x1700089B RID: 2203
		// (get) Token: 0x06002BB1 RID: 11185 RVA: 0x00079308 File Offset: 0x00077508
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Long._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700089C RID: 2204
		// (get) Token: 0x06002BB2 RID: 11186 RVA: 0x0007932C File Offset: 0x0007752C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Long._members.ManagedPeerType;
			}
		}

		// Token: 0x06002BB3 RID: 11187 RVA: 0x000759E0 File Offset: 0x00073BE0
		internal Long(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06002BB4 RID: 11188 RVA: 0x00079338 File Offset: 0x00077538
		public unsafe Long(long value) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(value);
			base.SetHandle(Long._members.InstanceMethods.StartCreateInstance("(J)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			Long._members.InstanceMethods.FinishCreateInstance("(J)V", this, ptr);
		}

		// Token: 0x06002BB5 RID: 11189 RVA: 0x000793BC File Offset: 0x000775BC
		public unsafe int CompareTo(Long anotherLong)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((anotherLong == null) ? IntPtr.Zero : anotherLong.Handle);
				result = Long._members.InstanceMethods.InvokeAbstractInt32Method("compareTo.(Ljava/lang/Long;)I", this, ptr);
			}
			finally
			{
				GC.KeepAlive(anotherLong);
			}
			return result;
		}

		// Token: 0x06002BB6 RID: 11190 RVA: 0x00079424 File Offset: 0x00077624
		public override double DoubleValue()
		{
			return Long._members.InstanceMethods.InvokeAbstractDoubleMethod("doubleValue.()D", this, null);
		}

		// Token: 0x06002BB7 RID: 11191 RVA: 0x0007943D File Offset: 0x0007763D
		public override float FloatValue()
		{
			return Long._members.InstanceMethods.InvokeAbstractSingleMethod("floatValue.()F", this, null);
		}

		// Token: 0x06002BB8 RID: 11192 RVA: 0x00079456 File Offset: 0x00077656
		public override int IntValue()
		{
			return Long._members.InstanceMethods.InvokeAbstractInt32Method("intValue.()I", this, null);
		}

		// Token: 0x06002BB9 RID: 11193 RVA: 0x0007946F File Offset: 0x0007766F
		public override long LongValue()
		{
			return Long._members.InstanceMethods.InvokeAbstractInt64Method("longValue.()J", this, null);
		}

		// Token: 0x06002BBA RID: 11194 RVA: 0x00079488 File Offset: 0x00077688
		int IComparable.CompareTo(Object o)
		{
			return this.CompareTo(o.JavaCast<Long>());
		}

		// Token: 0x06002BBB RID: 11195 RVA: 0x00079496 File Offset: 0x00077696
		TypeCode IConvertible.GetTypeCode()
		{
			return TypeCode.Int64;
		}

		// Token: 0x06002BBC RID: 11196 RVA: 0x0007949A File Offset: 0x0007769A
		bool IConvertible.ToBoolean(IFormatProvider provider)
		{
			return Convert.ToBoolean(this.LongValue());
		}

		// Token: 0x06002BBD RID: 11197 RVA: 0x000794A7 File Offset: 0x000776A7
		byte IConvertible.ToByte(IFormatProvider provider)
		{
			return Convert.ToByte(this.LongValue());
		}

		// Token: 0x06002BBE RID: 11198 RVA: 0x000794B4 File Offset: 0x000776B4
		char IConvertible.ToChar(IFormatProvider provider)
		{
			return Convert.ToChar(this.LongValue());
		}

		// Token: 0x06002BBF RID: 11199 RVA: 0x000794C1 File Offset: 0x000776C1
		DateTime IConvertible.ToDateTime(IFormatProvider provider)
		{
			return Convert.ToDateTime(this.LongValue());
		}

		// Token: 0x06002BC0 RID: 11200 RVA: 0x000794CE File Offset: 0x000776CE
		decimal IConvertible.ToDecimal(IFormatProvider provider)
		{
			return Convert.ToDecimal(this.LongValue());
		}

		// Token: 0x06002BC1 RID: 11201 RVA: 0x000794DB File Offset: 0x000776DB
		double IConvertible.ToDouble(IFormatProvider provider)
		{
			return Convert.ToDouble(this.LongValue());
		}

		// Token: 0x06002BC2 RID: 11202 RVA: 0x000794E8 File Offset: 0x000776E8
		short IConvertible.ToInt16(IFormatProvider provider)
		{
			return Convert.ToInt16(this.LongValue());
		}

		// Token: 0x06002BC3 RID: 11203 RVA: 0x000794F5 File Offset: 0x000776F5
		int IConvertible.ToInt32(IFormatProvider provider)
		{
			return Convert.ToInt32(this.LongValue());
		}

		// Token: 0x06002BC4 RID: 11204 RVA: 0x00079502 File Offset: 0x00077702
		long IConvertible.ToInt64(IFormatProvider provider)
		{
			return Convert.ToInt64(this.LongValue());
		}

		// Token: 0x06002BC5 RID: 11205 RVA: 0x0007950F File Offset: 0x0007770F
		sbyte IConvertible.ToSByte(IFormatProvider provider)
		{
			return Convert.ToSByte(this.LongValue());
		}

		// Token: 0x06002BC6 RID: 11206 RVA: 0x0007951C File Offset: 0x0007771C
		float IConvertible.ToSingle(IFormatProvider provider)
		{
			return Convert.ToSingle(this.LongValue());
		}

		// Token: 0x06002BC7 RID: 11207 RVA: 0x00079529 File Offset: 0x00077729
		string IConvertible.ToString(IFormatProvider provider)
		{
			return Convert.ToString(this.LongValue());
		}

		// Token: 0x06002BC8 RID: 11208 RVA: 0x00079536 File Offset: 0x00077736
		object IConvertible.ToType(Type conversionType, IFormatProvider provider)
		{
			return Convert.ChangeType(this.LongValue(), conversionType, provider);
		}

		// Token: 0x06002BC9 RID: 11209 RVA: 0x0007954A File Offset: 0x0007774A
		ushort IConvertible.ToUInt16(IFormatProvider provider)
		{
			return Convert.ToUInt16(this.LongValue());
		}

		// Token: 0x06002BCA RID: 11210 RVA: 0x00079557 File Offset: 0x00077757
		uint IConvertible.ToUInt32(IFormatProvider provider)
		{
			return Convert.ToUInt32(this.LongValue());
		}

		// Token: 0x06002BCB RID: 11211 RVA: 0x00079564 File Offset: 0x00077764
		ulong IConvertible.ToUInt64(IFormatProvider provider)
		{
			return Convert.ToUInt64(this.LongValue());
		}

		// Token: 0x04001174 RID: 4468
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/lang/Long", typeof(Long));
	}
}
