using System;
using System.Text;

namespace System
{
	// Token: 0x0200018E RID: 398
	internal class ArraySpec : ModifierSpec
	{
		// Token: 0x06000F54 RID: 3924 RVA: 0x0004014A File Offset: 0x0003E34A
		internal ArraySpec(int dimensions, bool bound)
		{
			this.dimensions = dimensions;
			this.bound = bound;
		}

		// Token: 0x06000F55 RID: 3925 RVA: 0x00040160 File Offset: 0x0003E360
		public Type Resolve(Type type)
		{
			if (this.bound)
			{
				return type.MakeArrayType(1);
			}
			if (this.dimensions == 1)
			{
				return type.MakeArrayType();
			}
			return type.MakeArrayType(this.dimensions);
		}

		// Token: 0x06000F56 RID: 3926 RVA: 0x0004018E File Offset: 0x0003E38E
		public StringBuilder Append(StringBuilder sb)
		{
			if (this.bound)
			{
				return sb.Append("[*]");
			}
			return sb.Append('[').Append(',', this.dimensions - 1).Append(']');
		}

		// Token: 0x06000F57 RID: 3927 RVA: 0x000401C2 File Offset: 0x0003E3C2
		public override string ToString()
		{
			return this.Append(new StringBuilder()).ToString();
		}

		// Token: 0x040005CB RID: 1483
		private int dimensions;

		// Token: 0x040005CC RID: 1484
		private bool bound;
	}
}
