using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Java.Lang
{
	// Token: 0x020003DD RID: 989
	[Register("java/lang/Integer", DoNotGenerateAcw = true)]
	public sealed class Integer : Number, IComparable, IJavaObject, IDisposable, IJavaPeerable, IConvertible
	{
		// Token: 0x17000889 RID: 2185
		// (get) Token: 0x06002B6F RID: 11119 RVA: 0x00078CBB File Offset: 0x00076EBB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Integer._members;
			}
		}

		// Token: 0x1700088A RID: 2186
		// (get) Token: 0x06002B70 RID: 11120 RVA: 0x00078CC4 File Offset: 0x00076EC4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Integer._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700088B RID: 2187
		// (get) Token: 0x06002B71 RID: 11121 RVA: 0x00078CE8 File Offset: 0x00076EE8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Integer._members.ManagedPeerType;
			}
		}

		// Token: 0x06002B72 RID: 11122 RVA: 0x000759E0 File Offset: 0x00073BE0
		internal Integer(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06002B73 RID: 11123 RVA: 0x00078CF4 File Offset: 0x00076EF4
		public unsafe Integer(int value) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(value);
			base.SetHandle(Integer._members.InstanceMethods.StartCreateInstance("(I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			Integer._members.InstanceMethods.FinishCreateInstance("(I)V", this, ptr);
		}

		// Token: 0x06002B74 RID: 11124 RVA: 0x00078D78 File Offset: 0x00076F78
		public unsafe int CompareTo(Integer anotherInteger)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((anotherInteger == null) ? IntPtr.Zero : anotherInteger.Handle);
				result = Integer._members.InstanceMethods.InvokeAbstractInt32Method("compareTo.(Ljava/lang/Integer;)I", this, ptr);
			}
			finally
			{
				GC.KeepAlive(anotherInteger);
			}
			return result;
		}

		// Token: 0x06002B75 RID: 11125 RVA: 0x00078DE0 File Offset: 0x00076FE0
		public override double DoubleValue()
		{
			return Integer._members.InstanceMethods.InvokeAbstractDoubleMethod("doubleValue.()D", this, null);
		}

		// Token: 0x06002B76 RID: 11126 RVA: 0x00078DF9 File Offset: 0x00076FF9
		public override float FloatValue()
		{
			return Integer._members.InstanceMethods.InvokeAbstractSingleMethod("floatValue.()F", this, null);
		}

		// Token: 0x06002B77 RID: 11127 RVA: 0x00078E12 File Offset: 0x00077012
		public override int IntValue()
		{
			return Integer._members.InstanceMethods.InvokeAbstractInt32Method("intValue.()I", this, null);
		}

		// Token: 0x06002B78 RID: 11128 RVA: 0x00078E2B File Offset: 0x0007702B
		public override long LongValue()
		{
			return Integer._members.InstanceMethods.InvokeAbstractInt64Method("longValue.()J", this, null);
		}

		// Token: 0x06002B79 RID: 11129 RVA: 0x00078E44 File Offset: 0x00077044
		int IComparable.CompareTo(Object o)
		{
			return this.CompareTo(o.JavaCast<Integer>());
		}

		// Token: 0x06002B7A RID: 11130 RVA: 0x00078E52 File Offset: 0x00077052
		TypeCode IConvertible.GetTypeCode()
		{
			return TypeCode.Int32;
		}

		// Token: 0x06002B7B RID: 11131 RVA: 0x00076905 File Offset: 0x00074B05
		bool IConvertible.ToBoolean(IFormatProvider provider)
		{
			return Convert.ToBoolean(this.IntValue());
		}

		// Token: 0x06002B7C RID: 11132 RVA: 0x00076912 File Offset: 0x00074B12
		byte IConvertible.ToByte(IFormatProvider provider)
		{
			return Convert.ToByte(this.IntValue());
		}

		// Token: 0x06002B7D RID: 11133 RVA: 0x0007691F File Offset: 0x00074B1F
		char IConvertible.ToChar(IFormatProvider provider)
		{
			return Convert.ToChar(this.IntValue());
		}

		// Token: 0x06002B7E RID: 11134 RVA: 0x0007692C File Offset: 0x00074B2C
		DateTime IConvertible.ToDateTime(IFormatProvider provider)
		{
			return Convert.ToDateTime(this.IntValue());
		}

		// Token: 0x06002B7F RID: 11135 RVA: 0x00076939 File Offset: 0x00074B39
		decimal IConvertible.ToDecimal(IFormatProvider provider)
		{
			return Convert.ToDecimal(this.IntValue());
		}

		// Token: 0x06002B80 RID: 11136 RVA: 0x00076946 File Offset: 0x00074B46
		double IConvertible.ToDouble(IFormatProvider provider)
		{
			return Convert.ToDouble(this.IntValue());
		}

		// Token: 0x06002B81 RID: 11137 RVA: 0x00076953 File Offset: 0x00074B53
		short IConvertible.ToInt16(IFormatProvider provider)
		{
			return Convert.ToInt16(this.IntValue());
		}

		// Token: 0x06002B82 RID: 11138 RVA: 0x00078E56 File Offset: 0x00077056
		int IConvertible.ToInt32(IFormatProvider provider)
		{
			return Convert.ToInt32(this.IntValue());
		}

		// Token: 0x06002B83 RID: 11139 RVA: 0x00076968 File Offset: 0x00074B68
		long IConvertible.ToInt64(IFormatProvider provider)
		{
			return Convert.ToInt64(this.IntValue());
		}

		// Token: 0x06002B84 RID: 11140 RVA: 0x00076975 File Offset: 0x00074B75
		sbyte IConvertible.ToSByte(IFormatProvider provider)
		{
			return Convert.ToSByte(this.IntValue());
		}

		// Token: 0x06002B85 RID: 11141 RVA: 0x00076982 File Offset: 0x00074B82
		float IConvertible.ToSingle(IFormatProvider provider)
		{
			return Convert.ToSingle(this.IntValue());
		}

		// Token: 0x06002B86 RID: 11142 RVA: 0x0007698F File Offset: 0x00074B8F
		string IConvertible.ToString(IFormatProvider provider)
		{
			return Convert.ToString(this.IntValue());
		}

		// Token: 0x06002B87 RID: 11143 RVA: 0x0007699C File Offset: 0x00074B9C
		object IConvertible.ToType(Type conversionType, IFormatProvider provider)
		{
			return Convert.ChangeType(this.IntValue(), conversionType, provider);
		}

		// Token: 0x06002B88 RID: 11144 RVA: 0x000769B0 File Offset: 0x00074BB0
		ushort IConvertible.ToUInt16(IFormatProvider provider)
		{
			return Convert.ToUInt16(this.IntValue());
		}

		// Token: 0x06002B89 RID: 11145 RVA: 0x000769BD File Offset: 0x00074BBD
		uint IConvertible.ToUInt32(IFormatProvider provider)
		{
			return Convert.ToUInt32(this.IntValue());
		}

		// Token: 0x06002B8A RID: 11146 RVA: 0x000769CA File Offset: 0x00074BCA
		ulong IConvertible.ToUInt64(IFormatProvider provider)
		{
			return Convert.ToUInt64(this.IntValue());
		}

		// Token: 0x04001169 RID: 4457
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/lang/Integer", typeof(Integer));
	}
}
