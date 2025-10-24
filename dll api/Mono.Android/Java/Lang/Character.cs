using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.IO;

namespace Java.Lang
{
	// Token: 0x020003C0 RID: 960
	[Register("java/lang/Character", DoNotGenerateAcw = true)]
	public sealed class Character : Object, ISerializable, IJavaObject, IDisposable, IJavaPeerable, IComparable, IConvertible
	{
		// Token: 0x1700083F RID: 2111
		// (get) Token: 0x06002A60 RID: 10848 RVA: 0x000769F2 File Offset: 0x00074BF2
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Character._members;
			}
		}

		// Token: 0x17000840 RID: 2112
		// (get) Token: 0x06002A61 RID: 10849 RVA: 0x000769FC File Offset: 0x00074BFC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Character._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000841 RID: 2113
		// (get) Token: 0x06002A62 RID: 10850 RVA: 0x00076A20 File Offset: 0x00074C20
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Character._members.ManagedPeerType;
			}
		}

		// Token: 0x06002A63 RID: 10851 RVA: 0x000021E0 File Offset: 0x000003E0
		internal Character(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06002A64 RID: 10852 RVA: 0x00076A2C File Offset: 0x00074C2C
		public unsafe Character(char value) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(value);
			base.SetHandle(Character._members.InstanceMethods.StartCreateInstance("(C)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			Character._members.InstanceMethods.FinishCreateInstance("(C)V", this, ptr);
		}

		// Token: 0x06002A65 RID: 10853 RVA: 0x00076AB0 File Offset: 0x00074CB0
		public char CharValue()
		{
			return Character._members.InstanceMethods.InvokeAbstractCharMethod("charValue.()C", this, null);
		}

		// Token: 0x06002A66 RID: 10854 RVA: 0x00076ACC File Offset: 0x00074CCC
		public unsafe int CompareTo(Character anotherCharacter)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((anotherCharacter == null) ? IntPtr.Zero : anotherCharacter.Handle);
				result = Character._members.InstanceMethods.InvokeAbstractInt32Method("compareTo.(Ljava/lang/Character;)I", this, ptr);
			}
			finally
			{
				GC.KeepAlive(anotherCharacter);
			}
			return result;
		}

		// Token: 0x06002A67 RID: 10855 RVA: 0x00076B34 File Offset: 0x00074D34
		int IComparable.CompareTo(Object o)
		{
			return this.CompareTo(o.JavaCast<Character>());
		}

		// Token: 0x06002A68 RID: 10856 RVA: 0x00076B42 File Offset: 0x00074D42
		TypeCode IConvertible.GetTypeCode()
		{
			return TypeCode.Char;
		}

		// Token: 0x06002A69 RID: 10857 RVA: 0x00076B45 File Offset: 0x00074D45
		bool IConvertible.ToBoolean(IFormatProvider provider)
		{
			return Convert.ToBoolean(this.CharValue());
		}

		// Token: 0x06002A6A RID: 10858 RVA: 0x00076B52 File Offset: 0x00074D52
		byte IConvertible.ToByte(IFormatProvider provider)
		{
			return Convert.ToByte(this.CharValue());
		}

		// Token: 0x06002A6B RID: 10859 RVA: 0x00076B5F File Offset: 0x00074D5F
		char IConvertible.ToChar(IFormatProvider provider)
		{
			return Convert.ToChar(this.CharValue());
		}

		// Token: 0x06002A6C RID: 10860 RVA: 0x00076B6C File Offset: 0x00074D6C
		DateTime IConvertible.ToDateTime(IFormatProvider provider)
		{
			return Convert.ToDateTime(this.CharValue());
		}

		// Token: 0x06002A6D RID: 10861 RVA: 0x00076B79 File Offset: 0x00074D79
		decimal IConvertible.ToDecimal(IFormatProvider provider)
		{
			return Convert.ToDecimal(this.CharValue());
		}

		// Token: 0x06002A6E RID: 10862 RVA: 0x00076B86 File Offset: 0x00074D86
		double IConvertible.ToDouble(IFormatProvider provider)
		{
			return Convert.ToDouble(this.CharValue());
		}

		// Token: 0x06002A6F RID: 10863 RVA: 0x00076B93 File Offset: 0x00074D93
		short IConvertible.ToInt16(IFormatProvider provider)
		{
			return Convert.ToInt16(this.CharValue());
		}

		// Token: 0x06002A70 RID: 10864 RVA: 0x00076BA0 File Offset: 0x00074DA0
		int IConvertible.ToInt32(IFormatProvider provider)
		{
			return Convert.ToInt32(this.CharValue());
		}

		// Token: 0x06002A71 RID: 10865 RVA: 0x00076BAD File Offset: 0x00074DAD
		long IConvertible.ToInt64(IFormatProvider provider)
		{
			return Convert.ToInt64(this.CharValue());
		}

		// Token: 0x06002A72 RID: 10866 RVA: 0x00076BBA File Offset: 0x00074DBA
		sbyte IConvertible.ToSByte(IFormatProvider provider)
		{
			return Convert.ToSByte(this.CharValue());
		}

		// Token: 0x06002A73 RID: 10867 RVA: 0x00076BC7 File Offset: 0x00074DC7
		float IConvertible.ToSingle(IFormatProvider provider)
		{
			return Convert.ToSingle(this.CharValue());
		}

		// Token: 0x06002A74 RID: 10868 RVA: 0x00076BD4 File Offset: 0x00074DD4
		string IConvertible.ToString(IFormatProvider provider)
		{
			return Convert.ToString(this.CharValue());
		}

		// Token: 0x06002A75 RID: 10869 RVA: 0x00076BE1 File Offset: 0x00074DE1
		object IConvertible.ToType(Type conversionType, IFormatProvider provider)
		{
			return Convert.ChangeType(this.CharValue(), conversionType, provider);
		}

		// Token: 0x06002A76 RID: 10870 RVA: 0x00076BF5 File Offset: 0x00074DF5
		ushort IConvertible.ToUInt16(IFormatProvider provider)
		{
			return Convert.ToUInt16(this.CharValue());
		}

		// Token: 0x06002A77 RID: 10871 RVA: 0x00076C02 File Offset: 0x00074E02
		uint IConvertible.ToUInt32(IFormatProvider provider)
		{
			return Convert.ToUInt32(this.CharValue());
		}

		// Token: 0x06002A78 RID: 10872 RVA: 0x00076C0F File Offset: 0x00074E0F
		ulong IConvertible.ToUInt64(IFormatProvider provider)
		{
			return Convert.ToUInt64(this.CharValue());
		}

		// Token: 0x0400112E RID: 4398
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/lang/Character", typeof(Character));
	}
}
