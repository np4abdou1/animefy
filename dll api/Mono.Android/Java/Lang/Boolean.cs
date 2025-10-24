using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.IO;

namespace Java.Lang
{
	// Token: 0x020003BE RID: 958
	[Register("java/lang/Boolean", DoNotGenerateAcw = true)]
	public sealed class Boolean : Object, ISerializable, IJavaObject, IDisposable, IJavaPeerable, IComparable, IConvertible
	{
		// Token: 0x17000839 RID: 2105
		// (get) Token: 0x06002A29 RID: 10793 RVA: 0x0007652D File Offset: 0x0007472D
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Boolean._members;
			}
		}

		// Token: 0x1700083A RID: 2106
		// (get) Token: 0x06002A2A RID: 10794 RVA: 0x00076534 File Offset: 0x00074734
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Boolean._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700083B RID: 2107
		// (get) Token: 0x06002A2B RID: 10795 RVA: 0x00076558 File Offset: 0x00074758
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Boolean._members.ManagedPeerType;
			}
		}

		// Token: 0x06002A2C RID: 10796 RVA: 0x000021E0 File Offset: 0x000003E0
		internal Boolean(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06002A2D RID: 10797 RVA: 0x00076564 File Offset: 0x00074764
		public unsafe Boolean(bool value) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(value);
			base.SetHandle(Boolean._members.InstanceMethods.StartCreateInstance("(Z)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			Boolean._members.InstanceMethods.FinishCreateInstance("(Z)V", this, ptr);
		}

		// Token: 0x06002A2E RID: 10798 RVA: 0x000765E8 File Offset: 0x000747E8
		public bool BooleanValue()
		{
			return Boolean._members.InstanceMethods.InvokeAbstractBooleanMethod("booleanValue.()Z", this, null);
		}

		// Token: 0x06002A2F RID: 10799 RVA: 0x00076604 File Offset: 0x00074804
		public unsafe int CompareTo(Boolean b)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((b == null) ? IntPtr.Zero : b.Handle);
				result = Boolean._members.InstanceMethods.InvokeAbstractInt32Method("compareTo.(Ljava/lang/Boolean;)I", this, ptr);
			}
			finally
			{
				GC.KeepAlive(b);
			}
			return result;
		}

		// Token: 0x06002A30 RID: 10800 RVA: 0x0007666C File Offset: 0x0007486C
		int IComparable.CompareTo(Object o)
		{
			return this.CompareTo(o.JavaCast<Boolean>());
		}

		// Token: 0x06002A31 RID: 10801 RVA: 0x0007667A File Offset: 0x0007487A
		TypeCode IConvertible.GetTypeCode()
		{
			return TypeCode.Boolean;
		}

		// Token: 0x06002A32 RID: 10802 RVA: 0x0007667D File Offset: 0x0007487D
		bool IConvertible.ToBoolean(IFormatProvider provider)
		{
			return this.BooleanValue();
		}

		// Token: 0x06002A33 RID: 10803 RVA: 0x00076685 File Offset: 0x00074885
		byte IConvertible.ToByte(IFormatProvider provider)
		{
			return Convert.ToByte(this.BooleanValue());
		}

		// Token: 0x06002A34 RID: 10804 RVA: 0x00076692 File Offset: 0x00074892
		char IConvertible.ToChar(IFormatProvider provider)
		{
			return Convert.ToChar(this.BooleanValue());
		}

		// Token: 0x06002A35 RID: 10805 RVA: 0x0007669F File Offset: 0x0007489F
		DateTime IConvertible.ToDateTime(IFormatProvider provider)
		{
			return Convert.ToDateTime(this.BooleanValue());
		}

		// Token: 0x06002A36 RID: 10806 RVA: 0x000766AC File Offset: 0x000748AC
		decimal IConvertible.ToDecimal(IFormatProvider provider)
		{
			return Convert.ToDecimal(this.BooleanValue());
		}

		// Token: 0x06002A37 RID: 10807 RVA: 0x000766B9 File Offset: 0x000748B9
		double IConvertible.ToDouble(IFormatProvider provider)
		{
			return Convert.ToDouble(this.BooleanValue());
		}

		// Token: 0x06002A38 RID: 10808 RVA: 0x000766C6 File Offset: 0x000748C6
		short IConvertible.ToInt16(IFormatProvider provider)
		{
			return Convert.ToInt16(this.BooleanValue());
		}

		// Token: 0x06002A39 RID: 10809 RVA: 0x000766D3 File Offset: 0x000748D3
		int IConvertible.ToInt32(IFormatProvider provider)
		{
			return Convert.ToInt32(this.BooleanValue());
		}

		// Token: 0x06002A3A RID: 10810 RVA: 0x000766E0 File Offset: 0x000748E0
		long IConvertible.ToInt64(IFormatProvider provider)
		{
			return Convert.ToInt64(this.BooleanValue());
		}

		// Token: 0x06002A3B RID: 10811 RVA: 0x000766ED File Offset: 0x000748ED
		sbyte IConvertible.ToSByte(IFormatProvider provider)
		{
			return Convert.ToSByte(this.BooleanValue());
		}

		// Token: 0x06002A3C RID: 10812 RVA: 0x000766FA File Offset: 0x000748FA
		float IConvertible.ToSingle(IFormatProvider provider)
		{
			return Convert.ToSingle(this.BooleanValue());
		}

		// Token: 0x06002A3D RID: 10813 RVA: 0x00076707 File Offset: 0x00074907
		string IConvertible.ToString(IFormatProvider provider)
		{
			return Convert.ToString(this.BooleanValue());
		}

		// Token: 0x06002A3E RID: 10814 RVA: 0x00076714 File Offset: 0x00074914
		object IConvertible.ToType(Type conversionType, IFormatProvider provider)
		{
			return Convert.ChangeType(this.BooleanValue(), conversionType, provider);
		}

		// Token: 0x06002A3F RID: 10815 RVA: 0x00076728 File Offset: 0x00074928
		ushort IConvertible.ToUInt16(IFormatProvider provider)
		{
			return Convert.ToUInt16(this.BooleanValue());
		}

		// Token: 0x06002A40 RID: 10816 RVA: 0x00076735 File Offset: 0x00074935
		uint IConvertible.ToUInt32(IFormatProvider provider)
		{
			return Convert.ToUInt32(this.BooleanValue());
		}

		// Token: 0x06002A41 RID: 10817 RVA: 0x00076742 File Offset: 0x00074942
		ulong IConvertible.ToUInt64(IFormatProvider provider)
		{
			return Convert.ToUInt64(this.BooleanValue());
		}

		// Token: 0x0400112C RID: 4396
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/lang/Boolean", typeof(Boolean));
	}
}
