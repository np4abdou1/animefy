using System;

namespace System.Reflection.Emit
{
	/// <summary>Describes the operand type of Microsoft intermediate language (MSIL) instruction.</summary>
	// Token: 0x020004E7 RID: 1255
	public enum OperandType
	{
		/// <summary>The operand is a 32-bit integer branch target.</summary>
		// Token: 0x0400115E RID: 4446
		InlineBrTarget,
		/// <summary>The operand is a 32-bit metadata token.</summary>
		// Token: 0x0400115F RID: 4447
		InlineField,
		/// <summary>The operand is a 32-bit integer.</summary>
		// Token: 0x04001160 RID: 4448
		InlineI,
		/// <summary>The operand is a 64-bit integer.</summary>
		// Token: 0x04001161 RID: 4449
		InlineI8,
		/// <summary>The operand is a 32-bit metadata token.</summary>
		// Token: 0x04001162 RID: 4450
		InlineMethod,
		/// <summary>No operand.</summary>
		// Token: 0x04001163 RID: 4451
		InlineNone,
		/// <summary>The operand is reserved and should not be used.</summary>
		// Token: 0x04001164 RID: 4452
		InlinePhi,
		/// <summary>The operand is a 64-bit IEEE floating point number.</summary>
		// Token: 0x04001165 RID: 4453
		InlineR,
		/// <summary>The operand is a 32-bit metadata signature token.</summary>
		// Token: 0x04001166 RID: 4454
		InlineSig = 9,
		/// <summary>The operand is a 32-bit metadata string token.</summary>
		// Token: 0x04001167 RID: 4455
		InlineString,
		/// <summary>The operand is the 32-bit integer argument to a switch instruction.</summary>
		// Token: 0x04001168 RID: 4456
		InlineSwitch,
		/// <summary>The operand is a <see langword="FieldRef" />, <see langword="MethodRef" />, or <see langword="TypeRef" /> token.</summary>
		// Token: 0x04001169 RID: 4457
		InlineTok,
		/// <summary>The operand is a 32-bit metadata token.</summary>
		// Token: 0x0400116A RID: 4458
		InlineType,
		/// <summary>The operand is 16-bit integer containing the ordinal of a local variable or an argument.</summary>
		// Token: 0x0400116B RID: 4459
		InlineVar,
		/// <summary>The operand is an 8-bit integer branch target.</summary>
		// Token: 0x0400116C RID: 4460
		ShortInlineBrTarget,
		/// <summary>The operand is an 8-bit integer.</summary>
		// Token: 0x0400116D RID: 4461
		ShortInlineI,
		/// <summary>The operand is a 32-bit IEEE floating point number.</summary>
		// Token: 0x0400116E RID: 4462
		ShortInlineR,
		/// <summary>The operand is an 8-bit integer containing the ordinal of a local variable or an argumenta.</summary>
		// Token: 0x0400116F RID: 4463
		ShortInlineVar
	}
}
