using System;
using System.Security;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x020003D8 RID: 984
	internal sealed class MemberPrimitiveUnTyped
	{
		// Token: 0x06001DCA RID: 7626 RVA: 0x00003ACD File Offset: 0x00001CCD
		internal MemberPrimitiveUnTyped()
		{
		}

		// Token: 0x06001DCB RID: 7627 RVA: 0x0007E14B File Offset: 0x0007C34B
		internal void Set(InternalPrimitiveTypeE typeInformation, object value)
		{
			this.typeInformation = typeInformation;
			this.value = value;
		}

		// Token: 0x06001DCC RID: 7628 RVA: 0x0007E15B File Offset: 0x0007C35B
		internal void Set(InternalPrimitiveTypeE typeInformation)
		{
			this.typeInformation = typeInformation;
		}

		// Token: 0x06001DCD RID: 7629 RVA: 0x0007E164 File Offset: 0x0007C364
		public void Write(__BinaryWriter sout)
		{
			sout.WriteValue(this.typeInformation, this.value);
		}

		// Token: 0x06001DCE RID: 7630 RVA: 0x0007E178 File Offset: 0x0007C378
		[SecurityCritical]
		public void Read(__BinaryParser input)
		{
			this.value = input.ReadValue(this.typeInformation);
		}

		// Token: 0x06001DCF RID: 7631 RVA: 0x00002A7D File Offset: 0x00000C7D
		public void Dump()
		{
		}

		// Token: 0x04000D18 RID: 3352
		internal InternalPrimitiveTypeE typeInformation;

		// Token: 0x04000D19 RID: 3353
		internal object value;
	}
}
