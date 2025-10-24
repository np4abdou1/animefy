using System;
using System.Security;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x020003D4 RID: 980
	internal sealed class MemberPrimitiveTyped
	{
		// Token: 0x06001DB5 RID: 7605 RVA: 0x00003ACD File Offset: 0x00001CCD
		internal MemberPrimitiveTyped()
		{
		}

		// Token: 0x06001DB6 RID: 7606 RVA: 0x0007D960 File Offset: 0x0007BB60
		internal void Set(InternalPrimitiveTypeE primitiveTypeEnum, object value)
		{
			this.primitiveTypeEnum = primitiveTypeEnum;
			this.value = value;
		}

		// Token: 0x06001DB7 RID: 7607 RVA: 0x0007D970 File Offset: 0x0007BB70
		public void Write(__BinaryWriter sout)
		{
			sout.WriteByte(8);
			sout.WriteByte((byte)this.primitiveTypeEnum);
			sout.WriteValue(this.primitiveTypeEnum, this.value);
		}

		// Token: 0x06001DB8 RID: 7608 RVA: 0x0007D998 File Offset: 0x0007BB98
		[SecurityCritical]
		public void Read(__BinaryParser input)
		{
			this.primitiveTypeEnum = (InternalPrimitiveTypeE)input.ReadByte();
			this.value = input.ReadValue(this.primitiveTypeEnum);
		}

		// Token: 0x06001DB9 RID: 7609 RVA: 0x00002A7D File Offset: 0x00000C7D
		public void Dump()
		{
		}

		// Token: 0x04000CFE RID: 3326
		internal InternalPrimitiveTypeE primitiveTypeEnum;

		// Token: 0x04000CFF RID: 3327
		internal object value;
	}
}
