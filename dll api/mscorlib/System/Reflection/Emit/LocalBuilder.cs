using System;
using System.Runtime.InteropServices;

namespace System.Reflection.Emit
{
	/// <summary>Represents a local variable within a method or constructor.</summary>
	// Token: 0x0200050A RID: 1290
	[StructLayout(0)]
	public sealed class LocalBuilder : LocalVariableInfo
	{
		// Token: 0x06002570 RID: 9584 RVA: 0x00092632 File Offset: 0x00090832
		internal LocalBuilder(Type t, ILGenerator ilgen)
		{
			this.type = t;
			this.ilgen = ilgen;
		}

		/// <summary>Gets the type of the local variable.</summary>
		/// <returns>The <see cref="T:System.Type" /> of the local variable.</returns>
		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x06002571 RID: 9585 RVA: 0x0008CE95 File Offset: 0x0008B095
		public override Type LocalType
		{
			get
			{
				return this.type;
			}
		}

		// Token: 0x0400125A RID: 4698
		private string name;

		// Token: 0x0400125B RID: 4699
		internal ILGenerator ilgen;

		// Token: 0x0400125C RID: 4700
		private int startOffset;

		// Token: 0x0400125D RID: 4701
		private int endOffset;
	}
}
