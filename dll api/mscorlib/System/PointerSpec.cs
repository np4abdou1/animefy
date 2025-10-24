using System;
using System.Text;

namespace System
{
	// Token: 0x0200018F RID: 399
	internal class PointerSpec : ModifierSpec
	{
		// Token: 0x06000F58 RID: 3928 RVA: 0x000401D4 File Offset: 0x0003E3D4
		internal PointerSpec(int pointer_level)
		{
			this.pointer_level = pointer_level;
		}

		// Token: 0x06000F59 RID: 3929 RVA: 0x000401E4 File Offset: 0x0003E3E4
		public Type Resolve(Type type)
		{
			for (int i = 0; i < this.pointer_level; i++)
			{
				type = type.MakePointerType();
			}
			return type;
		}

		// Token: 0x06000F5A RID: 3930 RVA: 0x0004020B File Offset: 0x0003E40B
		public StringBuilder Append(StringBuilder sb)
		{
			return sb.Append('*', this.pointer_level);
		}

		// Token: 0x06000F5B RID: 3931 RVA: 0x0004021B File Offset: 0x0003E41B
		public override string ToString()
		{
			return this.Append(new StringBuilder()).ToString();
		}

		// Token: 0x040005CD RID: 1485
		private int pointer_level;
	}
}
