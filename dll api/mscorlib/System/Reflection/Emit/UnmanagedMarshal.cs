using System;
using System.Runtime.InteropServices;

namespace System.Reflection.Emit
{
	/// <summary>Represents the class that describes how to marshal a field from managed to unmanaged code. This class cannot be inherited.</summary>
	// Token: 0x0200051A RID: 1306
	[ComVisible(true)]
	[Serializable]
	[StructLayout(0)]
	public sealed class UnmanagedMarshal
	{
		// Token: 0x0600269D RID: 9885 RVA: 0x0009700C File Offset: 0x0009520C
		private UnmanagedMarshal(UnmanagedType maint, UnmanagedType elemt)
		{
			this.count = 0;
			this.t = maint;
			this.tbase = elemt;
		}

		// Token: 0x0600269E RID: 9886 RVA: 0x0009702C File Offset: 0x0009522C
		internal static UnmanagedMarshal DefineCustom(Type typeref, string cookie, string mtype, Guid id)
		{
			UnmanagedMarshal unmanagedMarshal = new UnmanagedMarshal(UnmanagedType.CustomMarshaler, UnmanagedType.CustomMarshaler);
			unmanagedMarshal.mcookie = cookie;
			unmanagedMarshal.marshaltype = mtype;
			unmanagedMarshal.marshaltyperef = typeref;
			if (id == Guid.Empty)
			{
				unmanagedMarshal.guid = string.Empty;
			}
			else
			{
				unmanagedMarshal.guid = id.ToString();
			}
			return unmanagedMarshal;
		}

		// Token: 0x0600269F RID: 9887 RVA: 0x00097086 File Offset: 0x00095286
		internal static UnmanagedMarshal DefineLPArrayInternal(UnmanagedType elemType, int sizeConst, int sizeParamIndex)
		{
			return new UnmanagedMarshal(UnmanagedType.LPArray, elemType)
			{
				count = sizeConst,
				param_num = sizeParamIndex,
				has_size = true
			};
		}

		// Token: 0x040013D7 RID: 5079
		private int count;

		// Token: 0x040013D8 RID: 5080
		private UnmanagedType t;

		// Token: 0x040013D9 RID: 5081
		private UnmanagedType tbase;

		// Token: 0x040013DA RID: 5082
		private string guid;

		// Token: 0x040013DB RID: 5083
		private string mcookie;

		// Token: 0x040013DC RID: 5084
		private string marshaltype;

		// Token: 0x040013DD RID: 5085
		internal Type marshaltyperef;

		// Token: 0x040013DE RID: 5086
		private int param_num;

		// Token: 0x040013DF RID: 5087
		private bool has_size;
	}
}
