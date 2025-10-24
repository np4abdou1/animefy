using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Java.Lang
{
	// Token: 0x020003BF RID: 959
	[Register("java/lang/Byte", DoNotGenerateAcw = true)]
	public sealed class Byte : Number, IComparable, IJavaObject, IDisposable, IJavaPeerable, IConvertible
	{
		// Token: 0x1700083C RID: 2108
		// (get) Token: 0x06002A43 RID: 10819 RVA: 0x0007676A File Offset: 0x0007496A
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Byte._members;
			}
		}

		// Token: 0x1700083D RID: 2109
		// (get) Token: 0x06002A44 RID: 10820 RVA: 0x00076774 File Offset: 0x00074974
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Byte._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700083E RID: 2110
		// (get) Token: 0x06002A45 RID: 10821 RVA: 0x00076798 File Offset: 0x00074998
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Byte._members.ManagedPeerType;
			}
		}

		// Token: 0x06002A46 RID: 10822 RVA: 0x000759E0 File Offset: 0x00073BE0
		internal Byte(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06002A47 RID: 10823 RVA: 0x000767A4 File Offset: 0x000749A4
		public unsafe Byte(sbyte value) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(value);
			base.SetHandle(Byte._members.InstanceMethods.StartCreateInstance("(B)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			Byte._members.InstanceMethods.FinishCreateInstance("(B)V", this, ptr);
		}

		// Token: 0x06002A48 RID: 10824 RVA: 0x00076828 File Offset: 0x00074A28
		public unsafe int CompareTo(Byte anotherByte)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((anotherByte == null) ? IntPtr.Zero : anotherByte.Handle);
				result = Byte._members.InstanceMethods.InvokeAbstractInt32Method("compareTo.(Ljava/lang/Byte;)I", this, ptr);
			}
			finally
			{
				GC.KeepAlive(anotherByte);
			}
			return result;
		}

		// Token: 0x06002A49 RID: 10825 RVA: 0x00076890 File Offset: 0x00074A90
		public override double DoubleValue()
		{
			return Byte._members.InstanceMethods.InvokeAbstractDoubleMethod("doubleValue.()D", this, null);
		}

		// Token: 0x06002A4A RID: 10826 RVA: 0x000768A9 File Offset: 0x00074AA9
		public override float FloatValue()
		{
			return Byte._members.InstanceMethods.InvokeAbstractSingleMethod("floatValue.()F", this, null);
		}

		// Token: 0x06002A4B RID: 10827 RVA: 0x000768C2 File Offset: 0x00074AC2
		public override int IntValue()
		{
			return Byte._members.InstanceMethods.InvokeAbstractInt32Method("intValue.()I", this, null);
		}

		// Token: 0x06002A4C RID: 10828 RVA: 0x000768DB File Offset: 0x00074ADB
		public override long LongValue()
		{
			return Byte._members.InstanceMethods.InvokeAbstractInt64Method("longValue.()J", this, null);
		}

		// Token: 0x06002A4D RID: 10829 RVA: 0x000768F4 File Offset: 0x00074AF4
		int IComparable.CompareTo(Object o)
		{
			return this.CompareTo(o.JavaCast<Byte>());
		}

		// Token: 0x06002A4E RID: 10830 RVA: 0x00076902 File Offset: 0x00074B02
		TypeCode IConvertible.GetTypeCode()
		{
			return TypeCode.SByte;
		}

		// Token: 0x06002A4F RID: 10831 RVA: 0x00076905 File Offset: 0x00074B05
		bool IConvertible.ToBoolean(IFormatProvider provider)
		{
			return Convert.ToBoolean(this.IntValue());
		}

		// Token: 0x06002A50 RID: 10832 RVA: 0x00076912 File Offset: 0x00074B12
		byte IConvertible.ToByte(IFormatProvider provider)
		{
			return Convert.ToByte(this.IntValue());
		}

		// Token: 0x06002A51 RID: 10833 RVA: 0x0007691F File Offset: 0x00074B1F
		char IConvertible.ToChar(IFormatProvider provider)
		{
			return Convert.ToChar(this.IntValue());
		}

		// Token: 0x06002A52 RID: 10834 RVA: 0x0007692C File Offset: 0x00074B2C
		DateTime IConvertible.ToDateTime(IFormatProvider provider)
		{
			return Convert.ToDateTime(this.IntValue());
		}

		// Token: 0x06002A53 RID: 10835 RVA: 0x00076939 File Offset: 0x00074B39
		decimal IConvertible.ToDecimal(IFormatProvider provider)
		{
			return Convert.ToDecimal(this.IntValue());
		}

		// Token: 0x06002A54 RID: 10836 RVA: 0x00076946 File Offset: 0x00074B46
		double IConvertible.ToDouble(IFormatProvider provider)
		{
			return Convert.ToDouble(this.IntValue());
		}

		// Token: 0x06002A55 RID: 10837 RVA: 0x00076953 File Offset: 0x00074B53
		short IConvertible.ToInt16(IFormatProvider provider)
		{
			return Convert.ToInt16(this.IntValue());
		}

		// Token: 0x06002A56 RID: 10838 RVA: 0x00076960 File Offset: 0x00074B60
		int IConvertible.ToInt32(IFormatProvider provider)
		{
			return this.IntValue();
		}

		// Token: 0x06002A57 RID: 10839 RVA: 0x00076968 File Offset: 0x00074B68
		long IConvertible.ToInt64(IFormatProvider provider)
		{
			return Convert.ToInt64(this.IntValue());
		}

		// Token: 0x06002A58 RID: 10840 RVA: 0x00076975 File Offset: 0x00074B75
		sbyte IConvertible.ToSByte(IFormatProvider provider)
		{
			return Convert.ToSByte(this.IntValue());
		}

		// Token: 0x06002A59 RID: 10841 RVA: 0x00076982 File Offset: 0x00074B82
		float IConvertible.ToSingle(IFormatProvider provider)
		{
			return Convert.ToSingle(this.IntValue());
		}

		// Token: 0x06002A5A RID: 10842 RVA: 0x0007698F File Offset: 0x00074B8F
		string IConvertible.ToString(IFormatProvider provider)
		{
			return Convert.ToString(this.IntValue());
		}

		// Token: 0x06002A5B RID: 10843 RVA: 0x0007699C File Offset: 0x00074B9C
		object IConvertible.ToType(Type conversionType, IFormatProvider provider)
		{
			return Convert.ChangeType(this.IntValue(), conversionType, provider);
		}

		// Token: 0x06002A5C RID: 10844 RVA: 0x000769B0 File Offset: 0x00074BB0
		ushort IConvertible.ToUInt16(IFormatProvider provider)
		{
			return Convert.ToUInt16(this.IntValue());
		}

		// Token: 0x06002A5D RID: 10845 RVA: 0x000769BD File Offset: 0x00074BBD
		uint IConvertible.ToUInt32(IFormatProvider provider)
		{
			return Convert.ToUInt32(this.IntValue());
		}

		// Token: 0x06002A5E RID: 10846 RVA: 0x000769CA File Offset: 0x00074BCA
		ulong IConvertible.ToUInt64(IFormatProvider provider)
		{
			return Convert.ToUInt64(this.IntValue());
		}

		// Token: 0x0400112D RID: 4397
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/lang/Byte", typeof(Byte));
	}
}
