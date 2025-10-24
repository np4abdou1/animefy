using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Java.Lang
{
	// Token: 0x020003C6 RID: 966
	[Register("java/lang/Double", DoNotGenerateAcw = true)]
	public sealed class Double : Number, IComparable, IJavaObject, IDisposable, IJavaPeerable, IConvertible
	{
		// Token: 0x17000852 RID: 2130
		// (get) Token: 0x06002A9E RID: 10910 RVA: 0x00077267 File Offset: 0x00075467
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Double._members;
			}
		}

		// Token: 0x17000853 RID: 2131
		// (get) Token: 0x06002A9F RID: 10911 RVA: 0x00077270 File Offset: 0x00075470
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Double._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000854 RID: 2132
		// (get) Token: 0x06002AA0 RID: 10912 RVA: 0x00077294 File Offset: 0x00075494
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Double._members.ManagedPeerType;
			}
		}

		// Token: 0x06002AA1 RID: 10913 RVA: 0x000759E0 File Offset: 0x00073BE0
		internal Double(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06002AA2 RID: 10914 RVA: 0x000772A0 File Offset: 0x000754A0
		public unsafe Double(double value) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(value);
			base.SetHandle(Double._members.InstanceMethods.StartCreateInstance("(D)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			Double._members.InstanceMethods.FinishCreateInstance("(D)V", this, ptr);
		}

		// Token: 0x06002AA3 RID: 10915 RVA: 0x00077324 File Offset: 0x00075524
		public unsafe int CompareTo(Double anotherDouble)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((anotherDouble == null) ? IntPtr.Zero : anotherDouble.Handle);
				result = Double._members.InstanceMethods.InvokeAbstractInt32Method("compareTo.(Ljava/lang/Double;)I", this, ptr);
			}
			finally
			{
				GC.KeepAlive(anotherDouble);
			}
			return result;
		}

		// Token: 0x06002AA4 RID: 10916 RVA: 0x0007738C File Offset: 0x0007558C
		public override double DoubleValue()
		{
			return Double._members.InstanceMethods.InvokeAbstractDoubleMethod("doubleValue.()D", this, null);
		}

		// Token: 0x06002AA5 RID: 10917 RVA: 0x000773A5 File Offset: 0x000755A5
		public override float FloatValue()
		{
			return Double._members.InstanceMethods.InvokeAbstractSingleMethod("floatValue.()F", this, null);
		}

		// Token: 0x06002AA6 RID: 10918 RVA: 0x000773BE File Offset: 0x000755BE
		public override int IntValue()
		{
			return Double._members.InstanceMethods.InvokeAbstractInt32Method("intValue.()I", this, null);
		}

		// Token: 0x06002AA7 RID: 10919 RVA: 0x000773D7 File Offset: 0x000755D7
		public override long LongValue()
		{
			return Double._members.InstanceMethods.InvokeAbstractInt64Method("longValue.()J", this, null);
		}

		// Token: 0x06002AA8 RID: 10920 RVA: 0x000773F0 File Offset: 0x000755F0
		int IComparable.CompareTo(Object o)
		{
			return this.CompareTo(o.JavaCast<Double>());
		}

		// Token: 0x06002AA9 RID: 10921 RVA: 0x000773FE File Offset: 0x000755FE
		TypeCode IConvertible.GetTypeCode()
		{
			return TypeCode.Double;
		}

		// Token: 0x06002AAA RID: 10922 RVA: 0x00077402 File Offset: 0x00075602
		bool IConvertible.ToBoolean(IFormatProvider provider)
		{
			return Convert.ToBoolean(this.DoubleValue());
		}

		// Token: 0x06002AAB RID: 10923 RVA: 0x0007740F File Offset: 0x0007560F
		byte IConvertible.ToByte(IFormatProvider provider)
		{
			return Convert.ToByte(this.DoubleValue());
		}

		// Token: 0x06002AAC RID: 10924 RVA: 0x0007741C File Offset: 0x0007561C
		char IConvertible.ToChar(IFormatProvider provider)
		{
			return Convert.ToChar(this.DoubleValue());
		}

		// Token: 0x06002AAD RID: 10925 RVA: 0x00077429 File Offset: 0x00075629
		DateTime IConvertible.ToDateTime(IFormatProvider provider)
		{
			return Convert.ToDateTime(this.DoubleValue());
		}

		// Token: 0x06002AAE RID: 10926 RVA: 0x00077436 File Offset: 0x00075636
		decimal IConvertible.ToDecimal(IFormatProvider provider)
		{
			return Convert.ToDecimal(this.DoubleValue());
		}

		// Token: 0x06002AAF RID: 10927 RVA: 0x00077443 File Offset: 0x00075643
		double IConvertible.ToDouble(IFormatProvider provider)
		{
			return Convert.ToDouble(this.DoubleValue());
		}

		// Token: 0x06002AB0 RID: 10928 RVA: 0x00077450 File Offset: 0x00075650
		short IConvertible.ToInt16(IFormatProvider provider)
		{
			return Convert.ToInt16(this.DoubleValue());
		}

		// Token: 0x06002AB1 RID: 10929 RVA: 0x0007745D File Offset: 0x0007565D
		int IConvertible.ToInt32(IFormatProvider provider)
		{
			return Convert.ToInt32(this.DoubleValue());
		}

		// Token: 0x06002AB2 RID: 10930 RVA: 0x0007746A File Offset: 0x0007566A
		long IConvertible.ToInt64(IFormatProvider provider)
		{
			return Convert.ToInt64(this.DoubleValue());
		}

		// Token: 0x06002AB3 RID: 10931 RVA: 0x00077477 File Offset: 0x00075677
		sbyte IConvertible.ToSByte(IFormatProvider provider)
		{
			return Convert.ToSByte(this.DoubleValue());
		}

		// Token: 0x06002AB4 RID: 10932 RVA: 0x00077484 File Offset: 0x00075684
		float IConvertible.ToSingle(IFormatProvider provider)
		{
			return Convert.ToSingle(this.DoubleValue());
		}

		// Token: 0x06002AB5 RID: 10933 RVA: 0x00077491 File Offset: 0x00075691
		string IConvertible.ToString(IFormatProvider provider)
		{
			return Convert.ToString(this.DoubleValue());
		}

		// Token: 0x06002AB6 RID: 10934 RVA: 0x0007749E File Offset: 0x0007569E
		object IConvertible.ToType(Type conversionType, IFormatProvider provider)
		{
			return Convert.ChangeType(this.DoubleValue(), conversionType, provider);
		}

		// Token: 0x06002AB7 RID: 10935 RVA: 0x000774B2 File Offset: 0x000756B2
		ushort IConvertible.ToUInt16(IFormatProvider provider)
		{
			return Convert.ToUInt16(this.DoubleValue());
		}

		// Token: 0x06002AB8 RID: 10936 RVA: 0x000774BF File Offset: 0x000756BF
		uint IConvertible.ToUInt32(IFormatProvider provider)
		{
			return Convert.ToUInt32(this.DoubleValue());
		}

		// Token: 0x06002AB9 RID: 10937 RVA: 0x000774CC File Offset: 0x000756CC
		ulong IConvertible.ToUInt64(IFormatProvider provider)
		{
			return Convert.ToUInt64(this.DoubleValue());
		}

		// Token: 0x04001138 RID: 4408
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/lang/Double", typeof(Double));
	}
}
