using System;

namespace System.Reflection.Emit
{
	/// <summary>Describes how values are pushed onto a stack or popped off a stack.</summary>
	// Token: 0x020004E9 RID: 1257
	public enum StackBehaviour
	{
		/// <summary>No values are popped off the stack.</summary>
		// Token: 0x0400117B RID: 4475
		Pop0,
		/// <summary>Pops one value off the stack.</summary>
		// Token: 0x0400117C RID: 4476
		Pop1,
		/// <summary>Pops 1 value off the stack for the first operand, and 1 value of the stack for the second operand.</summary>
		// Token: 0x0400117D RID: 4477
		Pop1_pop1,
		/// <summary>Pops a 32-bit integer off the stack.</summary>
		// Token: 0x0400117E RID: 4478
		Popi,
		/// <summary>Pops a 32-bit integer off the stack for the first operand, and a value off the stack for the second operand.</summary>
		// Token: 0x0400117F RID: 4479
		Popi_pop1,
		/// <summary>Pops a 32-bit integer off the stack for the first operand, and a 32-bit integer off the stack for the second operand.</summary>
		// Token: 0x04001180 RID: 4480
		Popi_popi,
		/// <summary>Pops a 32-bit integer off the stack for the first operand, and a 64-bit integer off the stack for the second operand.</summary>
		// Token: 0x04001181 RID: 4481
		Popi_popi8,
		/// <summary>Pops a 32-bit integer off the stack for the first operand, a 32-bit integer off the stack for the second operand, and a 32-bit integer off the stack for the third operand.</summary>
		// Token: 0x04001182 RID: 4482
		Popi_popi_popi,
		/// <summary>Pops a 32-bit integer off the stack for the first operand, and a 32-bit floating point number off the stack for the second operand.</summary>
		// Token: 0x04001183 RID: 4483
		Popi_popr4,
		/// <summary>Pops a 32-bit integer off the stack for the first operand, and a 64-bit floating point number off the stack for the second operand.</summary>
		// Token: 0x04001184 RID: 4484
		Popi_popr8,
		/// <summary>Pops a reference off the stack.</summary>
		// Token: 0x04001185 RID: 4485
		Popref,
		/// <summary>Pops a reference off the stack for the first operand, and a value off the stack for the second operand.</summary>
		// Token: 0x04001186 RID: 4486
		Popref_pop1,
		/// <summary>Pops a reference off the stack for the first operand, and a 32-bit integer off the stack for the second operand.</summary>
		// Token: 0x04001187 RID: 4487
		Popref_popi,
		/// <summary>Pops a reference off the stack for the first operand, a value off the stack for the second operand, and a value off the stack for the third operand.</summary>
		// Token: 0x04001188 RID: 4488
		Popref_popi_popi,
		/// <summary>Pops a reference off the stack for the first operand, a value off the stack for the second operand, and a 64-bit integer off the stack for the third operand.</summary>
		// Token: 0x04001189 RID: 4489
		Popref_popi_popi8,
		/// <summary>Pops a reference off the stack for the first operand, a value off the stack for the second operand, and a 32-bit integer off the stack for the third operand.</summary>
		// Token: 0x0400118A RID: 4490
		Popref_popi_popr4,
		/// <summary>Pops a reference off the stack for the first operand, a value off the stack for the second operand, and a 64-bit floating point number off the stack for the third operand.</summary>
		// Token: 0x0400118B RID: 4491
		Popref_popi_popr8,
		/// <summary>Pops a reference off the stack for the first operand, a value off the stack for the second operand, and a reference off the stack for the third operand.</summary>
		// Token: 0x0400118C RID: 4492
		Popref_popi_popref,
		/// <summary>No values are pushed onto the stack.</summary>
		// Token: 0x0400118D RID: 4493
		Push0,
		/// <summary>Pushes one value onto the stack.</summary>
		// Token: 0x0400118E RID: 4494
		Push1,
		/// <summary>Pushes 1 value onto the stack for the first operand, and 1 value onto the stack for the second operand.</summary>
		// Token: 0x0400118F RID: 4495
		Push1_push1,
		/// <summary>Pushes a 32-bit integer onto the stack.</summary>
		// Token: 0x04001190 RID: 4496
		Pushi,
		/// <summary>Pushes a 64-bit integer onto the stack.</summary>
		// Token: 0x04001191 RID: 4497
		Pushi8,
		/// <summary>Pushes a 32-bit floating point number onto the stack.</summary>
		// Token: 0x04001192 RID: 4498
		Pushr4,
		/// <summary>Pushes a 64-bit floating point number onto the stack.</summary>
		// Token: 0x04001193 RID: 4499
		Pushr8,
		/// <summary>Pushes a reference onto the stack.</summary>
		// Token: 0x04001194 RID: 4500
		Pushref,
		/// <summary>Pops a variable off the stack.</summary>
		// Token: 0x04001195 RID: 4501
		Varpop,
		/// <summary>Pushes a variable onto the stack.</summary>
		// Token: 0x04001196 RID: 4502
		Varpush,
		/// <summary>Pops a reference off the stack for the first operand, a value off the stack for the second operand, and a 32-bit integer off the stack for the third operand.</summary>
		// Token: 0x04001197 RID: 4503
		Popref_popi_pop1
	}
}
