using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Java.Lang
{
	// Token: 0x020003CB RID: 971
	[Register("java/lang/Float", DoNotGenerateAcw = true)]
	public sealed class Float : Number, IComparable, IJavaObject, IDisposable, IJavaPeerable, IConvertible
	{
		// Token: 0x17000860 RID: 2144
		// (get) Token: 0x06002AD3 RID: 10963 RVA: 0x00077857 File Offset: 0x00075A57
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Float._members;
			}
		}

		// Token: 0x17000861 RID: 2145
		// (get) Token: 0x06002AD4 RID: 10964 RVA: 0x00077860 File Offset: 0x00075A60
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Float._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000862 RID: 2146
		// (get) Token: 0x06002AD5 RID: 10965 RVA: 0x00077884 File Offset: 0x00075A84
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Float._members.ManagedPeerType;
			}
		}

		// Token: 0x06002AD6 RID: 10966 RVA: 0x000759E0 File Offset: 0x00073BE0
		internal Float(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06002AD7 RID: 10967 RVA: 0x00077890 File Offset: 0x00075A90
		public unsafe Float(float value) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(value);
			base.SetHandle(Float._members.InstanceMethods.StartCreateInstance("(F)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			Float._members.InstanceMethods.FinishCreateInstance("(F)V", this, ptr);
		}

		// Token: 0x06002AD8 RID: 10968 RVA: 0x00077914 File Offset: 0x00075B14
		public unsafe int CompareTo(Float anotherFloat)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((anotherFloat == null) ? IntPtr.Zero : anotherFloat.Handle);
				result = Float._members.InstanceMethods.InvokeAbstractInt32Method("compareTo.(Ljava/lang/Float;)I", this, ptr);
			}
			finally
			{
				GC.KeepAlive(anotherFloat);
			}
			return result;
		}

		// Token: 0x06002AD9 RID: 10969 RVA: 0x0007797C File Offset: 0x00075B7C
		public override double DoubleValue()
		{
			return Float._members.InstanceMethods.InvokeAbstractDoubleMethod("doubleValue.()D", this, null);
		}

		// Token: 0x06002ADA RID: 10970 RVA: 0x00077995 File Offset: 0x00075B95
		public override float FloatValue()
		{
			return Float._members.InstanceMethods.InvokeAbstractSingleMethod("floatValue.()F", this, null);
		}

		// Token: 0x06002ADB RID: 10971 RVA: 0x000779AE File Offset: 0x00075BAE
		public override int IntValue()
		{
			return Float._members.InstanceMethods.InvokeAbstractInt32Method("intValue.()I", this, null);
		}

		// Token: 0x06002ADC RID: 10972 RVA: 0x000779C7 File Offset: 0x00075BC7
		public override long LongValue()
		{
			return Float._members.InstanceMethods.InvokeAbstractInt64Method("longValue.()J", this, null);
		}

		// Token: 0x06002ADD RID: 10973 RVA: 0x000779E0 File Offset: 0x00075BE0
		int IComparable.CompareTo(Object o)
		{
			return this.CompareTo(o.JavaCast<Float>());
		}

		// Token: 0x06002ADE RID: 10974 RVA: 0x000779EE File Offset: 0x00075BEE
		TypeCode IConvertible.GetTypeCode()
		{
			return TypeCode.Single;
		}

		// Token: 0x06002ADF RID: 10975 RVA: 0x000779F2 File Offset: 0x00075BF2
		bool IConvertible.ToBoolean(IFormatProvider provider)
		{
			return Convert.ToBoolean(this.FloatValue());
		}

		// Token: 0x06002AE0 RID: 10976 RVA: 0x000779FF File Offset: 0x00075BFF
		byte IConvertible.ToByte(IFormatProvider provider)
		{
			return Convert.ToByte(this.FloatValue());
		}

		// Token: 0x06002AE1 RID: 10977 RVA: 0x00077A0C File Offset: 0x00075C0C
		char IConvertible.ToChar(IFormatProvider provider)
		{
			return Convert.ToChar(this.FloatValue());
		}

		// Token: 0x06002AE2 RID: 10978 RVA: 0x00077A19 File Offset: 0x00075C19
		DateTime IConvertible.ToDateTime(IFormatProvider provider)
		{
			return Convert.ToDateTime(this.FloatValue());
		}

		// Token: 0x06002AE3 RID: 10979 RVA: 0x00077A26 File Offset: 0x00075C26
		decimal IConvertible.ToDecimal(IFormatProvider provider)
		{
			return Convert.ToDecimal(this.FloatValue());
		}

		// Token: 0x06002AE4 RID: 10980 RVA: 0x00077A33 File Offset: 0x00075C33
		double IConvertible.ToDouble(IFormatProvider provider)
		{
			return Convert.ToDouble(this.FloatValue());
		}

		// Token: 0x06002AE5 RID: 10981 RVA: 0x00077A40 File Offset: 0x00075C40
		short IConvertible.ToInt16(IFormatProvider provider)
		{
			return Convert.ToInt16(this.FloatValue());
		}

		// Token: 0x06002AE6 RID: 10982 RVA: 0x00077A4D File Offset: 0x00075C4D
		int IConvertible.ToInt32(IFormatProvider provider)
		{
			return Convert.ToInt32(this.FloatValue());
		}

		// Token: 0x06002AE7 RID: 10983 RVA: 0x00077A5A File Offset: 0x00075C5A
		long IConvertible.ToInt64(IFormatProvider provider)
		{
			return Convert.ToInt64(this.FloatValue());
		}

		// Token: 0x06002AE8 RID: 10984 RVA: 0x00077A67 File Offset: 0x00075C67
		sbyte IConvertible.ToSByte(IFormatProvider provider)
		{
			return Convert.ToSByte(this.FloatValue());
		}

		// Token: 0x06002AE9 RID: 10985 RVA: 0x00077A74 File Offset: 0x00075C74
		float IConvertible.ToSingle(IFormatProvider provider)
		{
			return Convert.ToSingle(this.FloatValue());
		}

		// Token: 0x06002AEA RID: 10986 RVA: 0x00077A81 File Offset: 0x00075C81
		string IConvertible.ToString(IFormatProvider provider)
		{
			return Convert.ToString(this.FloatValue());
		}

		// Token: 0x06002AEB RID: 10987 RVA: 0x00077A8E File Offset: 0x00075C8E
		object IConvertible.ToType(Type conversionType, IFormatProvider provider)
		{
			return Convert.ChangeType(this.FloatValue(), conversionType, provider);
		}

		// Token: 0x06002AEC RID: 10988 RVA: 0x00077AA2 File Offset: 0x00075CA2
		ushort IConvertible.ToUInt16(IFormatProvider provider)
		{
			return Convert.ToUInt16(this.FloatValue());
		}

		// Token: 0x06002AED RID: 10989 RVA: 0x00077AAF File Offset: 0x00075CAF
		uint IConvertible.ToUInt32(IFormatProvider provider)
		{
			return Convert.ToUInt32(this.FloatValue());
		}

		// Token: 0x06002AEE RID: 10990 RVA: 0x00077ABC File Offset: 0x00075CBC
		ulong IConvertible.ToUInt64(IFormatProvider provider)
		{
			return Convert.ToUInt64(this.FloatValue());
		}

		// Token: 0x0400113D RID: 4413
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/lang/Float", typeof(Float));
	}
}
