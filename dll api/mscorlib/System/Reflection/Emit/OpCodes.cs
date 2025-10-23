﻿using System;
using System.Runtime.InteropServices;

namespace System.Reflection.Emit
{
	/// <summary>Provides field representations of the Microsoft Intermediate Language (MSIL) instructions for emission by the <see cref="T:System.Reflection.Emit.ILGenerator" /> class members (such as <see cref="M:System.Reflection.Emit.ILGenerator.Emit(System.Reflection.Emit.OpCode)" />).</summary>
	// Token: 0x02000512 RID: 1298
	[ComVisible(true)]
	public class OpCodes
	{
		/// <summary>Fills space if opcodes are patched. No meaningful operation is performed although a processing cycle can be consumed.</summary>
		// Token: 0x040012AC RID: 4780
		public static readonly OpCode Nop = new OpCode(1179903, 84215041);

		/// <summary>Signals the Common Language Infrastructure (CLI) to inform the debugger that a break point has been tripped.</summary>
		// Token: 0x040012AD RID: 4781
		public static readonly OpCode Break = new OpCode(1180159, 17106177);

		/// <summary>Loads the argument at index 0 onto the evaluation stack.</summary>
		// Token: 0x040012AE RID: 4782
		public static readonly OpCode Ldarg_0 = new OpCode(1245951, 84214017);

		/// <summary>Loads the argument at index 1 onto the evaluation stack.</summary>
		// Token: 0x040012AF RID: 4783
		public static readonly OpCode Ldarg_1 = new OpCode(1246207, 84214017);

		/// <summary>Loads the argument at index 2 onto the evaluation stack.</summary>
		// Token: 0x040012B0 RID: 4784
		public static readonly OpCode Ldarg_2 = new OpCode(1246463, 84214017);

		/// <summary>Loads the argument at index 3 onto the evaluation stack.</summary>
		// Token: 0x040012B1 RID: 4785
		public static readonly OpCode Ldarg_3 = new OpCode(1246719, 84214017);

		/// <summary>Loads the local variable at index 0 onto the evaluation stack.</summary>
		// Token: 0x040012B2 RID: 4786
		public static readonly OpCode Ldloc_0 = new OpCode(1246975, 84214017);

		/// <summary>Loads the local variable at index 1 onto the evaluation stack.</summary>
		// Token: 0x040012B3 RID: 4787
		public static readonly OpCode Ldloc_1 = new OpCode(1247231, 84214017);

		/// <summary>Loads the local variable at index 2 onto the evaluation stack.</summary>
		// Token: 0x040012B4 RID: 4788
		public static readonly OpCode Ldloc_2 = new OpCode(1247487, 84214017);

		/// <summary>Loads the local variable at index 3 onto the evaluation stack.</summary>
		// Token: 0x040012B5 RID: 4789
		public static readonly OpCode Ldloc_3 = new OpCode(1247743, 84214017);

		/// <summary>Pops the current value from the top of the evaluation stack and stores it in a the local variable list at index 0.</summary>
		// Token: 0x040012B6 RID: 4790
		public static readonly OpCode Stloc_0 = new OpCode(17959679, 84214017);

		/// <summary>Pops the current value from the top of the evaluation stack and stores it in a the local variable list at index 1.</summary>
		// Token: 0x040012B7 RID: 4791
		public static readonly OpCode Stloc_1 = new OpCode(17959935, 84214017);

		/// <summary>Pops the current value from the top of the evaluation stack and stores it in a the local variable list at index 2.</summary>
		// Token: 0x040012B8 RID: 4792
		public static readonly OpCode Stloc_2 = new OpCode(17960191, 84214017);

		/// <summary>Pops the current value from the top of the evaluation stack and stores it in a the local variable list at index 3.</summary>
		// Token: 0x040012B9 RID: 4793
		public static readonly OpCode Stloc_3 = new OpCode(17960447, 84214017);

		/// <summary>Loads the argument (referenced by a specified short form index) onto the evaluation stack.</summary>
		// Token: 0x040012BA RID: 4794
		public static readonly OpCode Ldarg_S = new OpCode(1249023, 85065985);

		/// <summary>Load an argument address, in short form, onto the evaluation stack.</summary>
		// Token: 0x040012BB RID: 4795
		public static readonly OpCode Ldarga_S = new OpCode(1380351, 85065985);

		/// <summary>Stores the value on top of the evaluation stack in the argument slot at a specified index, short form.</summary>
		// Token: 0x040012BC RID: 4796
		public static readonly OpCode Starg_S = new OpCode(17961215, 85065985);

		/// <summary>Loads the local variable at a specific index onto the evaluation stack, short form.</summary>
		// Token: 0x040012BD RID: 4797
		public static readonly OpCode Ldloc_S = new OpCode(1249791, 85065985);

		/// <summary>Loads the address of the local variable at a specific index onto the evaluation stack, short form.</summary>
		// Token: 0x040012BE RID: 4798
		public static readonly OpCode Ldloca_S = new OpCode(1381119, 85065985);

		/// <summary>Pops the current value from the top of the evaluation stack and stores it in a the local variable list at <paramref name="index" /> (short form).</summary>
		// Token: 0x040012BF RID: 4799
		public static readonly OpCode Stloc_S = new OpCode(17961983, 85065985);

		/// <summary>Pushes a null reference (type <see langword="O" />) onto the evaluation stack.</summary>
		// Token: 0x040012C0 RID: 4800
		public static readonly OpCode Ldnull = new OpCode(1643775, 84215041);

		/// <summary>Pushes the integer value of -1 onto the evaluation stack as an <see langword="int32" />.</summary>
		// Token: 0x040012C1 RID: 4801
		public static readonly OpCode Ldc_I4_M1 = new OpCode(1381887, 84214017);

		/// <summary>Pushes the integer value of 0 onto the evaluation stack as an <see langword="int32" />.</summary>
		// Token: 0x040012C2 RID: 4802
		public static readonly OpCode Ldc_I4_0 = new OpCode(1382143, 84214017);

		/// <summary>Pushes the integer value of 1 onto the evaluation stack as an <see langword="int32" />.</summary>
		// Token: 0x040012C3 RID: 4803
		public static readonly OpCode Ldc_I4_1 = new OpCode(1382399, 84214017);

		/// <summary>Pushes the integer value of 2 onto the evaluation stack as an <see langword="int32" />.</summary>
		// Token: 0x040012C4 RID: 4804
		public static readonly OpCode Ldc_I4_2 = new OpCode(1382655, 84214017);

		/// <summary>Pushes the integer value of 3 onto the evaluation stack as an <see langword="int32" />.</summary>
		// Token: 0x040012C5 RID: 4805
		public static readonly OpCode Ldc_I4_3 = new OpCode(1382911, 84214017);

		/// <summary>Pushes the integer value of 4 onto the evaluation stack as an <see langword="int32" />.</summary>
		// Token: 0x040012C6 RID: 4806
		public static readonly OpCode Ldc_I4_4 = new OpCode(1383167, 84214017);

		/// <summary>Pushes the integer value of 5 onto the evaluation stack as an <see langword="int32" />.</summary>
		// Token: 0x040012C7 RID: 4807
		public static readonly OpCode Ldc_I4_5 = new OpCode(1383423, 84214017);

		/// <summary>Pushes the integer value of 6 onto the evaluation stack as an <see langword="int32" />.</summary>
		// Token: 0x040012C8 RID: 4808
		public static readonly OpCode Ldc_I4_6 = new OpCode(1383679, 84214017);

		/// <summary>Pushes the integer value of 7 onto the evaluation stack as an <see langword="int32" />.</summary>
		// Token: 0x040012C9 RID: 4809
		public static readonly OpCode Ldc_I4_7 = new OpCode(1383935, 84214017);

		/// <summary>Pushes the integer value of 8 onto the evaluation stack as an <see langword="int32" />.</summary>
		// Token: 0x040012CA RID: 4810
		public static readonly OpCode Ldc_I4_8 = new OpCode(1384191, 84214017);

		/// <summary>Pushes the supplied <see langword="int8" /> value onto the evaluation stack as an <see langword="int32" />, short form.</summary>
		// Token: 0x040012CB RID: 4811
		public static readonly OpCode Ldc_I4_S = new OpCode(1384447, 84934913);

		/// <summary>Pushes a supplied value of type <see langword="int32" /> onto the evaluation stack as an <see langword="int32" />.</summary>
		// Token: 0x040012CC RID: 4812
		public static readonly OpCode Ldc_I4 = new OpCode(1384703, 84018433);

		/// <summary>Pushes a supplied value of type <see langword="int64" /> onto the evaluation stack as an <see langword="int64" />.</summary>
		// Token: 0x040012CD RID: 4813
		public static readonly OpCode Ldc_I8 = new OpCode(1450495, 84083969);

		/// <summary>Pushes a supplied value of type <see langword="float32" /> onto the evaluation stack as type <see langword="F" /> (float).</summary>
		// Token: 0x040012CE RID: 4814
		public static readonly OpCode Ldc_R4 = new OpCode(1516287, 85001473);

		/// <summary>Pushes a supplied value of type <see langword="float64" /> onto the evaluation stack as type <see langword="F" /> (float).</summary>
		// Token: 0x040012CF RID: 4815
		public static readonly OpCode Ldc_R8 = new OpCode(1582079, 84346113);

		/// <summary>Copies the current topmost value on the evaluation stack, and then pushes the copy onto the evaluation stack.</summary>
		// Token: 0x040012D0 RID: 4816
		public static readonly OpCode Dup = new OpCode(18097663, 84215041);

		/// <summary>Removes the value currently on top of the evaluation stack.</summary>
		// Token: 0x040012D1 RID: 4817
		public static readonly OpCode Pop = new OpCode(17966847, 84215041);

		/// <summary>Exits current method and jumps to specified method.</summary>
		// Token: 0x040012D2 RID: 4818
		public static readonly OpCode Jmp = new OpCode(1189887, 33817857);

		/// <summary>Calls the method indicated by the passed method descriptor.</summary>
		// Token: 0x040012D3 RID: 4819
		public static readonly OpCode Call = new OpCode(437987583, 33817857);

		/// <summary>Calls the method indicated on the evaluation stack (as a pointer to an entry point) with arguments described by a calling convention.</summary>
		// Token: 0x040012D4 RID: 4820
		public static readonly OpCode Calli = new OpCode(437987839, 34145537);

		/// <summary>Returns from the current method, pushing a return value (if present) from the callee's evaluation stack onto the caller's evaluation stack.</summary>
		// Token: 0x040012D5 RID: 4821
		public static readonly OpCode Ret = new OpCode(437398271, 117769473);

		/// <summary>Unconditionally transfers control to a target instruction (short form).</summary>
		// Token: 0x040012D6 RID: 4822
		public static readonly OpCode Br_S = new OpCode(1190911, 983297);

		/// <summary>Transfers control to a target instruction if <paramref name="value" /> is <see langword="false" />, a null reference, or zero.</summary>
		// Token: 0x040012D7 RID: 4823
		public static readonly OpCode Brfalse_S = new OpCode(51522815, 51314945);

		/// <summary>Transfers control to a target instruction (short form) if <paramref name="value" /> is <see langword="true" />, not null, or non-zero.</summary>
		// Token: 0x040012D8 RID: 4824
		public static readonly OpCode Brtrue_S = new OpCode(51523071, 51314945);

		/// <summary>Transfers control to a target instruction (short form) if two values are equal.</summary>
		// Token: 0x040012D9 RID: 4825
		public static readonly OpCode Beq_S = new OpCode(34746111, 51314945);

		/// <summary>Transfers control to a target instruction (short form) if the first value is greater than or equal to the second value.</summary>
		// Token: 0x040012DA RID: 4826
		public static readonly OpCode Bge_S = new OpCode(34746367, 51314945);

		/// <summary>Transfers control to a target instruction (short form) if the first value is greater than the second value.</summary>
		// Token: 0x040012DB RID: 4827
		public static readonly OpCode Bgt_S = new OpCode(34746623, 51314945);

		/// <summary>Transfers control to a target instruction (short form) if the first value is less than or equal to the second value.</summary>
		// Token: 0x040012DC RID: 4828
		public static readonly OpCode Ble_S = new OpCode(34746879, 51314945);

		/// <summary>Transfers control to a target instruction (short form) if the first value is less than the second value.</summary>
		// Token: 0x040012DD RID: 4829
		public static readonly OpCode Blt_S = new OpCode(34747135, 51314945);

		/// <summary>Transfers control to a target instruction (short form) when two unsigned integer values or unordered float values are not equal.</summary>
		// Token: 0x040012DE RID: 4830
		public static readonly OpCode Bne_Un_S = new OpCode(34747391, 51314945);

		/// <summary>Transfers control to a target instruction (short form) if the first value is greater than the second value, when comparing unsigned integer values or unordered float values.</summary>
		// Token: 0x040012DF RID: 4831
		public static readonly OpCode Bge_Un_S = new OpCode(34747647, 51314945);

		/// <summary>Transfers control to a target instruction (short form) if the first value is greater than the second value, when comparing unsigned integer values or unordered float values.</summary>
		// Token: 0x040012E0 RID: 4832
		public static readonly OpCode Bgt_Un_S = new OpCode(34747903, 51314945);

		/// <summary>Transfers control to a target instruction (short form) if the first value is less than or equal to the second value, when comparing unsigned integer values or unordered float values.</summary>
		// Token: 0x040012E1 RID: 4833
		public static readonly OpCode Ble_Un_S = new OpCode(34748159, 51314945);

		/// <summary>Transfers control to a target instruction (short form) if the first value is less than the second value, when comparing unsigned integer values or unordered float values.</summary>
		// Token: 0x040012E2 RID: 4834
		public static readonly OpCode Blt_Un_S = new OpCode(34748415, 51314945);

		/// <summary>Unconditionally transfers control to a target instruction.</summary>
		// Token: 0x040012E3 RID: 4835
		public static readonly OpCode Br = new OpCode(1194239, 1281);

		/// <summary>Transfers control to a target instruction if <paramref name="value" /> is <see langword="false" />, a null reference (<see langword="Nothing" /> in Visual Basic), or zero.</summary>
		// Token: 0x040012E4 RID: 4836
		public static readonly OpCode Brfalse = new OpCode(51526143, 50332929);

		/// <summary>Transfers control to a target instruction if <paramref name="value" /> is <see langword="true" />, not null, or non-zero.</summary>
		// Token: 0x040012E5 RID: 4837
		public static readonly OpCode Brtrue = new OpCode(51526399, 50332929);

		/// <summary>Transfers control to a target instruction if two values are equal.</summary>
		// Token: 0x040012E6 RID: 4838
		public static readonly OpCode Beq = new OpCode(34749439, 50331905);

		/// <summary>Transfers control to a target instruction if the first value is greater than or equal to the second value.</summary>
		// Token: 0x040012E7 RID: 4839
		public static readonly OpCode Bge = new OpCode(34749695, 50331905);

		/// <summary>Transfers control to a target instruction if the first value is greater than the second value.</summary>
		// Token: 0x040012E8 RID: 4840
		public static readonly OpCode Bgt = new OpCode(34749951, 50331905);

		/// <summary>Transfers control to a target instruction if the first value is less than or equal to the second value.</summary>
		// Token: 0x040012E9 RID: 4841
		public static readonly OpCode Ble = new OpCode(34750207, 50331905);

		/// <summary>Transfers control to a target instruction if the first value is less than the second value.</summary>
		// Token: 0x040012EA RID: 4842
		public static readonly OpCode Blt = new OpCode(34750463, 50331905);

		/// <summary>Transfers control to a target instruction when two unsigned integer values or unordered float values are not equal.</summary>
		// Token: 0x040012EB RID: 4843
		public static readonly OpCode Bne_Un = new OpCode(34750719, 50331905);

		/// <summary>Transfers control to a target instruction if the first value is greater than the second value, when comparing unsigned integer values or unordered float values.</summary>
		// Token: 0x040012EC RID: 4844
		public static readonly OpCode Bge_Un = new OpCode(34750975, 50331905);

		/// <summary>Transfers control to a target instruction if the first value is greater than the second value, when comparing unsigned integer values or unordered float values.</summary>
		// Token: 0x040012ED RID: 4845
		public static readonly OpCode Bgt_Un = new OpCode(34751231, 50331905);

		/// <summary>Transfers control to a target instruction if the first value is less than or equal to the second value, when comparing unsigned integer values or unordered float values.</summary>
		// Token: 0x040012EE RID: 4846
		public static readonly OpCode Ble_Un = new OpCode(34751487, 50331905);

		/// <summary>Transfers control to a target instruction if the first value is less than the second value, when comparing unsigned integer values or unordered float values.</summary>
		// Token: 0x040012EF RID: 4847
		public static readonly OpCode Blt_Un = new OpCode(34751743, 50331905);

		/// <summary>Implements a jump table.</summary>
		// Token: 0x040012F0 RID: 4848
		public static readonly OpCode Switch = new OpCode(51529215, 51053825);

		/// <summary>Loads a value of type <see langword="int8" /> as an <see langword="int32" /> onto the evaluation stack indirectly.</summary>
		// Token: 0x040012F1 RID: 4849
		public static readonly OpCode Ldind_I1 = new OpCode(51726079, 84215041);

		/// <summary>Loads a value of type <see langword="unsigned int8" /> as an <see langword="int32" /> onto the evaluation stack indirectly.</summary>
		// Token: 0x040012F2 RID: 4850
		public static readonly OpCode Ldind_U1 = new OpCode(51726335, 84215041);

		/// <summary>Loads a value of type <see langword="int16" /> as an <see langword="int32" /> onto the evaluation stack indirectly.</summary>
		// Token: 0x040012F3 RID: 4851
		public static readonly OpCode Ldind_I2 = new OpCode(51726591, 84215041);

		/// <summary>Loads a value of type <see langword="unsigned int16" /> as an <see langword="int32" /> onto the evaluation stack indirectly.</summary>
		// Token: 0x040012F4 RID: 4852
		public static readonly OpCode Ldind_U2 = new OpCode(51726847, 84215041);

		/// <summary>Loads a value of type <see langword="int32" /> as an <see langword="int32" /> onto the evaluation stack indirectly.</summary>
		// Token: 0x040012F5 RID: 4853
		public static readonly OpCode Ldind_I4 = new OpCode(51727103, 84215041);

		/// <summary>Loads a value of type <see langword="unsigned int32" /> as an <see langword="int32" /> onto the evaluation stack indirectly.</summary>
		// Token: 0x040012F6 RID: 4854
		public static readonly OpCode Ldind_U4 = new OpCode(51727359, 84215041);

		/// <summary>Loads a value of type <see langword="int64" /> as an <see langword="int64" /> onto the evaluation stack indirectly.</summary>
		// Token: 0x040012F7 RID: 4855
		public static readonly OpCode Ldind_I8 = new OpCode(51793151, 84215041);

		/// <summary>Loads a value of type <see langword="native int" /> as a <see langword="native int" /> onto the evaluation stack indirectly.</summary>
		// Token: 0x040012F8 RID: 4856
		public static readonly OpCode Ldind_I = new OpCode(51727871, 84215041);

		/// <summary>Loads a value of type <see langword="float32" /> as a type <see langword="F" /> (float) onto the evaluation stack indirectly.</summary>
		// Token: 0x040012F9 RID: 4857
		public static readonly OpCode Ldind_R4 = new OpCode(51859199, 84215041);

		/// <summary>Loads a value of type <see langword="float64" /> as a type <see langword="F" /> (float) onto the evaluation stack indirectly.</summary>
		// Token: 0x040012FA RID: 4858
		public static readonly OpCode Ldind_R8 = new OpCode(51924991, 84215041);

		/// <summary>Loads an object reference as a type <see langword="O" /> (object reference) onto the evaluation stack indirectly.</summary>
		// Token: 0x040012FB RID: 4859
		public static readonly OpCode Ldind_Ref = new OpCode(51990783, 84215041);

		/// <summary>Stores a object reference value at a supplied address.</summary>
		// Token: 0x040012FC RID: 4860
		public static readonly OpCode Stind_Ref = new OpCode(85086719, 84215041);

		/// <summary>Stores a value of type <see langword="int8" /> at a supplied address.</summary>
		// Token: 0x040012FD RID: 4861
		public static readonly OpCode Stind_I1 = new OpCode(85086975, 84215041);

		/// <summary>Stores a value of type <see langword="int16" /> at a supplied address.</summary>
		// Token: 0x040012FE RID: 4862
		public static readonly OpCode Stind_I2 = new OpCode(85087231, 84215041);

		/// <summary>Stores a value of type <see langword="int32" /> at a supplied address.</summary>
		// Token: 0x040012FF RID: 4863
		public static readonly OpCode Stind_I4 = new OpCode(85087487, 84215041);

		/// <summary>Stores a value of type <see langword="int64" /> at a supplied address.</summary>
		// Token: 0x04001300 RID: 4864
		public static readonly OpCode Stind_I8 = new OpCode(101864959, 84215041);

		/// <summary>Stores a value of type <see langword="float32" /> at a supplied address.</summary>
		// Token: 0x04001301 RID: 4865
		public static readonly OpCode Stind_R4 = new OpCode(135419647, 84215041);

		/// <summary>Stores a value of type <see langword="float64" /> at a supplied address.</summary>
		// Token: 0x04001302 RID: 4866
		public static readonly OpCode Stind_R8 = new OpCode(152197119, 84215041);

		/// <summary>Adds two values and pushes the result onto the evaluation stack.</summary>
		// Token: 0x04001303 RID: 4867
		public static readonly OpCode Add = new OpCode(34822399, 84215041);

		/// <summary>Subtracts one value from another and pushes the result onto the evaluation stack.</summary>
		// Token: 0x04001304 RID: 4868
		public static readonly OpCode Sub = new OpCode(34822655, 84215041);

		/// <summary>Multiplies two values and pushes the result on the evaluation stack.</summary>
		// Token: 0x04001305 RID: 4869
		public static readonly OpCode Mul = new OpCode(34822911, 84215041);

		/// <summary>Divides two values and pushes the result as a floating-point (type <see langword="F" />) or quotient (type <see langword="int32" />) onto the evaluation stack.</summary>
		// Token: 0x04001306 RID: 4870
		public static readonly OpCode Div = new OpCode(34823167, 84215041);

		/// <summary>Divides two unsigned integer values and pushes the result (<see langword="int32" />) onto the evaluation stack.</summary>
		// Token: 0x04001307 RID: 4871
		public static readonly OpCode Div_Un = new OpCode(34823423, 84215041);

		/// <summary>Divides two values and pushes the remainder onto the evaluation stack.</summary>
		// Token: 0x04001308 RID: 4872
		public static readonly OpCode Rem = new OpCode(34823679, 84215041);

		/// <summary>Divides two unsigned values and pushes the remainder onto the evaluation stack.</summary>
		// Token: 0x04001309 RID: 4873
		public static readonly OpCode Rem_Un = new OpCode(34823935, 84215041);

		/// <summary>Computes the bitwise AND of two values and pushes the result onto the evaluation stack.</summary>
		// Token: 0x0400130A RID: 4874
		public static readonly OpCode And = new OpCode(34824191, 84215041);

		/// <summary>Compute the bitwise complement of the two integer values on top of the stack and pushes the result onto the evaluation stack.</summary>
		// Token: 0x0400130B RID: 4875
		public static readonly OpCode Or = new OpCode(34824447, 84215041);

		/// <summary>Computes the bitwise XOR of the top two values on the evaluation stack, pushing the result onto the evaluation stack.</summary>
		// Token: 0x0400130C RID: 4876
		public static readonly OpCode Xor = new OpCode(34824703, 84215041);

		/// <summary>Shifts an integer value to the left (in zeroes) by a specified number of bits, pushing the result onto the evaluation stack.</summary>
		// Token: 0x0400130D RID: 4877
		public static readonly OpCode Shl = new OpCode(34824959, 84215041);

		/// <summary>Shifts an integer value (in sign) to the right by a specified number of bits, pushing the result onto the evaluation stack.</summary>
		// Token: 0x0400130E RID: 4878
		public static readonly OpCode Shr = new OpCode(34825215, 84215041);

		/// <summary>Shifts an unsigned integer value (in zeroes) to the right by a specified number of bits, pushing the result onto the evaluation stack.</summary>
		// Token: 0x0400130F RID: 4879
		public static readonly OpCode Shr_Un = new OpCode(34825471, 84215041);

		/// <summary>Negates a value and pushes the result onto the evaluation stack.</summary>
		// Token: 0x04001310 RID: 4880
		public static readonly OpCode Neg = new OpCode(18048511, 84215041);

		/// <summary>Computes the bitwise complement of the integer value on top of the stack and pushes the result onto the evaluation stack as the same type.</summary>
		// Token: 0x04001311 RID: 4881
		public static readonly OpCode Not = new OpCode(18048767, 84215041);

		/// <summary>Converts the value on top of the evaluation stack to <see langword="int8" />, then extends (pads) it to <see langword="int32" />.</summary>
		// Token: 0x04001312 RID: 4882
		public static readonly OpCode Conv_I1 = new OpCode(18180095, 84215041);

		/// <summary>Converts the value on top of the evaluation stack to <see langword="int16" />, then extends (pads) it to <see langword="int32" />.</summary>
		// Token: 0x04001313 RID: 4883
		public static readonly OpCode Conv_I2 = new OpCode(18180351, 84215041);

		/// <summary>Converts the value on top of the evaluation stack to <see langword="int32" />.</summary>
		// Token: 0x04001314 RID: 4884
		public static readonly OpCode Conv_I4 = new OpCode(18180607, 84215041);

		/// <summary>Converts the value on top of the evaluation stack to <see langword="int64" />.</summary>
		// Token: 0x04001315 RID: 4885
		public static readonly OpCode Conv_I8 = new OpCode(18246399, 84215041);

		/// <summary>Converts the value on top of the evaluation stack to <see langword="float32" />.</summary>
		// Token: 0x04001316 RID: 4886
		public static readonly OpCode Conv_R4 = new OpCode(18312191, 84215041);

		/// <summary>Converts the value on top of the evaluation stack to <see langword="float64" />.</summary>
		// Token: 0x04001317 RID: 4887
		public static readonly OpCode Conv_R8 = new OpCode(18377983, 84215041);

		/// <summary>Converts the value on top of the evaluation stack to <see langword="unsigned int32" />, and extends it to <see langword="int32" />.</summary>
		// Token: 0x04001318 RID: 4888
		public static readonly OpCode Conv_U4 = new OpCode(18181631, 84215041);

		/// <summary>Converts the value on top of the evaluation stack to <see langword="unsigned int64" />, and extends it to <see langword="int64" />.</summary>
		// Token: 0x04001319 RID: 4889
		public static readonly OpCode Conv_U8 = new OpCode(18247423, 84215041);

		/// <summary>Calls a late-bound method on an object, pushing the return value onto the evaluation stack.</summary>
		// Token: 0x0400131A RID: 4890
		public static readonly OpCode Callvirt = new OpCode(438005759, 33817345);

		/// <summary>Copies the value type located at the address of an object (type <see langword="&amp;" />, <see langword="*" /> or <see langword="native int" />) to the address of the destination object (type <see langword="&amp;" />, <see langword="*" /> or <see langword="native int" />).</summary>
		// Token: 0x0400131B RID: 4891
		public static readonly OpCode Cpobj = new OpCode(85094655, 84738817);

		/// <summary>Copies the value type object pointed to by an address to the top of the evaluation stack.</summary>
		// Token: 0x0400131C RID: 4892
		public static readonly OpCode Ldobj = new OpCode(51606015, 84738817);

		/// <summary>Pushes a new object reference to a string literal stored in the metadata.</summary>
		// Token: 0x0400131D RID: 4893
		public static readonly OpCode Ldstr = new OpCode(1667839, 84542209);

		/// <summary>Creates a new object or a new instance of a value type, pushing an object reference (type <see langword="O" />) onto the evaluation stack.</summary>
		// Token: 0x0400131E RID: 4894
		public static readonly OpCode Newobj = new OpCode(437875711, 33817345);

		/// <summary>Attempts to cast an object passed by reference to the specified class.</summary>
		// Token: 0x0400131F RID: 4895
		[ComVisible(true)]
		public static readonly OpCode Castclass = new OpCode(169440511, 84738817);

		/// <summary>Tests whether an object reference (type <see langword="O" />) is an instance of a particular class.</summary>
		// Token: 0x04001320 RID: 4896
		public static readonly OpCode Isinst = new OpCode(169178623, 84738817);

		/// <summary>Converts the unsigned integer value on top of the evaluation stack to <see langword="float32" />.</summary>
		// Token: 0x04001321 RID: 4897
		public static readonly OpCode Conv_R_Un = new OpCode(18380543, 84215041);

		/// <summary>Converts the boxed representation of a value type to its unboxed form.</summary>
		// Token: 0x04001322 RID: 4898
		public static readonly OpCode Unbox = new OpCode(169179647, 84739329);

		/// <summary>Throws the exception object currently on the evaluation stack.</summary>
		// Token: 0x04001323 RID: 4899
		public static readonly OpCode Throw = new OpCode(168983295, 134546177);

		/// <summary>Finds the value of a field in the object whose reference is currently on the evaluation stack.</summary>
		// Token: 0x04001324 RID: 4900
		public static readonly OpCode Ldfld = new OpCode(169049087, 83952385);

		/// <summary>Finds the address of a field in the object whose reference is currently on the evaluation stack.</summary>
		// Token: 0x04001325 RID: 4901
		public static readonly OpCode Ldflda = new OpCode(169180415, 83952385);

		/// <summary>Replaces the value stored in the field of an object reference or pointer with a new value.</summary>
		// Token: 0x04001326 RID: 4902
		public static readonly OpCode Stfld = new OpCode(185761279, 83952385);

		/// <summary>Pushes the value of a static field onto the evaluation stack.</summary>
		// Token: 0x04001327 RID: 4903
		public static readonly OpCode Ldsfld = new OpCode(1277695, 83952385);

		/// <summary>Pushes the address of a static field onto the evaluation stack.</summary>
		// Token: 0x04001328 RID: 4904
		public static readonly OpCode Ldsflda = new OpCode(1409023, 83952385);

		/// <summary>Replaces the value of a static field with a value from the evaluation stack.</summary>
		// Token: 0x04001329 RID: 4905
		public static readonly OpCode Stsfld = new OpCode(17989887, 83952385);

		/// <summary>Copies a value of a specified type from the evaluation stack into a supplied memory address.</summary>
		// Token: 0x0400132A RID: 4906
		public static readonly OpCode Stobj = new OpCode(68321791, 84739329);

		/// <summary>Converts the unsigned value on top of the evaluation stack to signed <see langword="int8" /> and extends it to <see langword="int32" />, throwing <see cref="T:System.OverflowException" /> on overflow.</summary>
		// Token: 0x0400132B RID: 4907
		public static readonly OpCode Conv_Ovf_I1_Un = new OpCode(18187007, 84215041);

		/// <summary>Converts the unsigned value on top of the evaluation stack to signed <see langword="int16" /> and extends it to <see langword="int32" />, throwing <see cref="T:System.OverflowException" /> on overflow.</summary>
		// Token: 0x0400132C RID: 4908
		public static readonly OpCode Conv_Ovf_I2_Un = new OpCode(18187263, 84215041);

		/// <summary>Converts the unsigned value on top of the evaluation stack to signed <see langword="int32" />, throwing <see cref="T:System.OverflowException" /> on overflow.</summary>
		// Token: 0x0400132D RID: 4909
		public static readonly OpCode Conv_Ovf_I4_Un = new OpCode(18187519, 84215041);

		/// <summary>Converts the unsigned value on top of the evaluation stack to signed <see langword="int64" />, throwing <see cref="T:System.OverflowException" /> on overflow.</summary>
		// Token: 0x0400132E RID: 4910
		public static readonly OpCode Conv_Ovf_I8_Un = new OpCode(18253311, 84215041);

		/// <summary>Converts the unsigned value on top of the evaluation stack to <see langword="unsigned int8" /> and extends it to <see langword="int32" />, throwing <see cref="T:System.OverflowException" /> on overflow.</summary>
		// Token: 0x0400132F RID: 4911
		public static readonly OpCode Conv_Ovf_U1_Un = new OpCode(18188031, 84215041);

		/// <summary>Converts the unsigned value on top of the evaluation stack to <see langword="unsigned int16" /> and extends it to <see langword="int32" />, throwing <see cref="T:System.OverflowException" /> on overflow.</summary>
		// Token: 0x04001330 RID: 4912
		public static readonly OpCode Conv_Ovf_U2_Un = new OpCode(18188287, 84215041);

		/// <summary>Converts the unsigned value on top of the evaluation stack to <see langword="unsigned int32" />, throwing <see cref="T:System.OverflowException" /> on overflow.</summary>
		// Token: 0x04001331 RID: 4913
		public static readonly OpCode Conv_Ovf_U4_Un = new OpCode(18188543, 84215041);

		/// <summary>Converts the unsigned value on top of the evaluation stack to <see langword="unsigned int64" />, throwing <see cref="T:System.OverflowException" /> on overflow.</summary>
		// Token: 0x04001332 RID: 4914
		public static readonly OpCode Conv_Ovf_U8_Un = new OpCode(18254335, 84215041);

		/// <summary>Converts the unsigned value on top of the evaluation stack to signed <see langword="native int" />, throwing <see cref="T:System.OverflowException" /> on overflow.</summary>
		// Token: 0x04001333 RID: 4915
		public static readonly OpCode Conv_Ovf_I_Un = new OpCode(18189055, 84215041);

		/// <summary>Converts the unsigned value on top of the evaluation stack to <see langword="unsigned native int" />, throwing <see cref="T:System.OverflowException" /> on overflow.</summary>
		// Token: 0x04001334 RID: 4916
		public static readonly OpCode Conv_Ovf_U_Un = new OpCode(18189311, 84215041);

		/// <summary>Converts a value type to an object reference (type <see langword="O" />).</summary>
		// Token: 0x04001335 RID: 4917
		public static readonly OpCode Box = new OpCode(18451711, 84739329);

		/// <summary>Pushes an object reference to a new zero-based, one-dimensional array whose elements are of a specific type onto the evaluation stack.</summary>
		// Token: 0x04001336 RID: 4918
		public static readonly OpCode Newarr = new OpCode(52006399, 84738817);

		/// <summary>Pushes the number of elements of a zero-based, one-dimensional array onto the evaluation stack.</summary>
		// Token: 0x04001337 RID: 4919
		public static readonly OpCode Ldlen = new OpCode(169185023, 84214529);

		/// <summary>Loads the address of the array element at a specified array index onto the top of the evaluation stack as type <see langword="&amp;" /> (managed pointer).</summary>
		// Token: 0x04001338 RID: 4920
		public static readonly OpCode Ldelema = new OpCode(202739711, 84738817);

		/// <summary>Loads the element with type <see langword="int8" /> at a specified array index onto the top of the evaluation stack as an <see langword="int32" />.</summary>
		// Token: 0x04001339 RID: 4921
		public static readonly OpCode Ldelem_I1 = new OpCode(202739967, 84214529);

		/// <summary>Loads the element with type <see langword="unsigned int8" /> at a specified array index onto the top of the evaluation stack as an <see langword="int32" />.</summary>
		// Token: 0x0400133A RID: 4922
		public static readonly OpCode Ldelem_U1 = new OpCode(202740223, 84214529);

		/// <summary>Loads the element with type <see langword="int16" /> at a specified array index onto the top of the evaluation stack as an <see langword="int32" />.</summary>
		// Token: 0x0400133B RID: 4923
		public static readonly OpCode Ldelem_I2 = new OpCode(202740479, 84214529);

		/// <summary>Loads the element with type <see langword="unsigned int16" /> at a specified array index onto the top of the evaluation stack as an <see langword="int32" />.</summary>
		// Token: 0x0400133C RID: 4924
		public static readonly OpCode Ldelem_U2 = new OpCode(202740735, 84214529);

		/// <summary>Loads the element with type <see langword="int32" /> at a specified array index onto the top of the evaluation stack as an <see langword="int32" />.</summary>
		// Token: 0x0400133D RID: 4925
		public static readonly OpCode Ldelem_I4 = new OpCode(202740991, 84214529);

		/// <summary>Loads the element with type <see langword="unsigned int32" /> at a specified array index onto the top of the evaluation stack as an <see langword="int32" />.</summary>
		// Token: 0x0400133E RID: 4926
		public static readonly OpCode Ldelem_U4 = new OpCode(202741247, 84214529);

		/// <summary>Loads the element with type <see langword="int64" /> at a specified array index onto the top of the evaluation stack as an <see langword="int64" />.</summary>
		// Token: 0x0400133F RID: 4927
		public static readonly OpCode Ldelem_I8 = new OpCode(202807039, 84214529);

		/// <summary>Loads the element with type <see langword="native int" /> at a specified array index onto the top of the evaluation stack as a <see langword="native int" />.</summary>
		// Token: 0x04001340 RID: 4928
		public static readonly OpCode Ldelem_I = new OpCode(202741759, 84214529);

		/// <summary>Loads the element with type <see langword="float32" /> at a specified array index onto the top of the evaluation stack as type <see langword="F" /> (float).</summary>
		// Token: 0x04001341 RID: 4929
		public static readonly OpCode Ldelem_R4 = new OpCode(202873087, 84214529);

		/// <summary>Loads the element with type <see langword="float64" /> at a specified array index onto the top of the evaluation stack as type <see langword="F" /> (float).</summary>
		// Token: 0x04001342 RID: 4930
		public static readonly OpCode Ldelem_R8 = new OpCode(202938879, 84214529);

		/// <summary>Loads the element containing an object reference at a specified array index onto the top of the evaluation stack as type <see langword="O" /> (object reference).</summary>
		// Token: 0x04001343 RID: 4931
		public static readonly OpCode Ldelem_Ref = new OpCode(203004671, 84214529);

		/// <summary>Replaces the array element at a given index with the <see langword="native int" /> value on the evaluation stack.</summary>
		// Token: 0x04001344 RID: 4932
		public static readonly OpCode Stelem_I = new OpCode(219323391, 84214529);

		/// <summary>Replaces the array element at a given index with the <see langword="int8" /> value on the evaluation stack.</summary>
		// Token: 0x04001345 RID: 4933
		public static readonly OpCode Stelem_I1 = new OpCode(219323647, 84214529);

		/// <summary>Replaces the array element at a given index with the <see langword="int16" /> value on the evaluation stack.</summary>
		// Token: 0x04001346 RID: 4934
		public static readonly OpCode Stelem_I2 = new OpCode(219323903, 84214529);

		/// <summary>Replaces the array element at a given index with the <see langword="int32" /> value on the evaluation stack.</summary>
		// Token: 0x04001347 RID: 4935
		public static readonly OpCode Stelem_I4 = new OpCode(219324159, 84214529);

		/// <summary>Replaces the array element at a given index with the <see langword="int64" /> value on the evaluation stack.</summary>
		// Token: 0x04001348 RID: 4936
		public static readonly OpCode Stelem_I8 = new OpCode(236101631, 84214529);

		/// <summary>Replaces the array element at a given index with the <see langword="float32" /> value on the evaluation stack.</summary>
		// Token: 0x04001349 RID: 4937
		public static readonly OpCode Stelem_R4 = new OpCode(252879103, 84214529);

		/// <summary>Replaces the array element at a given index with the <see langword="float64" /> value on the evaluation stack.</summary>
		// Token: 0x0400134A RID: 4938
		public static readonly OpCode Stelem_R8 = new OpCode(269656575, 84214529);

		/// <summary>Replaces the array element at a given index with the object ref value (type <see langword="O" />) on the evaluation stack.</summary>
		// Token: 0x0400134B RID: 4939
		public static readonly OpCode Stelem_Ref = new OpCode(286434047, 84214529);

		/// <summary>Loads the element at a specified array index onto the top of the evaluation stack as the type specified in the instruction. </summary>
		// Token: 0x0400134C RID: 4940
		public static readonly OpCode Ldelem = new OpCode(202613759, 84738817);

		/// <summary>Replaces the array element at a given index with the value on the evaluation stack, whose type is specified in the instruction.</summary>
		// Token: 0x0400134D RID: 4941
		public static readonly OpCode Stelem = new OpCode(470983935, 84738817);

		/// <summary>Converts the boxed representation of a type specified in the instruction to its unboxed form. </summary>
		// Token: 0x0400134E RID: 4942
		public static readonly OpCode Unbox_Any = new OpCode(169059839, 84738817);

		/// <summary>Converts the signed value on top of the evaluation stack to signed <see langword="int8" /> and extends it to <see langword="int32" />, throwing <see cref="T:System.OverflowException" /> on overflow.</summary>
		// Token: 0x0400134F RID: 4943
		public static readonly OpCode Conv_Ovf_I1 = new OpCode(18199551, 84215041);

		/// <summary>Converts the signed value on top of the evaluation stack to <see langword="unsigned int8" /> and extends it to <see langword="int32" />, throwing <see cref="T:System.OverflowException" /> on overflow.</summary>
		// Token: 0x04001350 RID: 4944
		public static readonly OpCode Conv_Ovf_U1 = new OpCode(18199807, 84215041);

		/// <summary>Converts the signed value on top of the evaluation stack to signed <see langword="int16" /> and extending it to <see langword="int32" />, throwing <see cref="T:System.OverflowException" /> on overflow.</summary>
		// Token: 0x04001351 RID: 4945
		public static readonly OpCode Conv_Ovf_I2 = new OpCode(18200063, 84215041);

		/// <summary>Converts the signed value on top of the evaluation stack to <see langword="unsigned int16" /> and extends it to <see langword="int32" />, throwing <see cref="T:System.OverflowException" /> on overflow.</summary>
		// Token: 0x04001352 RID: 4946
		public static readonly OpCode Conv_Ovf_U2 = new OpCode(18200319, 84215041);

		/// <summary>Converts the signed value on top of the evaluation stack to signed <see langword="int32" />, throwing <see cref="T:System.OverflowException" /> on overflow.</summary>
		// Token: 0x04001353 RID: 4947
		public static readonly OpCode Conv_Ovf_I4 = new OpCode(18200575, 84215041);

		/// <summary>Converts the signed value on top of the evaluation stack to <see langword="unsigned int32" />, throwing <see cref="T:System.OverflowException" /> on overflow.</summary>
		// Token: 0x04001354 RID: 4948
		public static readonly OpCode Conv_Ovf_U4 = new OpCode(18200831, 84215041);

		/// <summary>Converts the signed value on top of the evaluation stack to signed <see langword="int64" />, throwing <see cref="T:System.OverflowException" /> on overflow.</summary>
		// Token: 0x04001355 RID: 4949
		public static readonly OpCode Conv_Ovf_I8 = new OpCode(18266623, 84215041);

		/// <summary>Converts the signed value on top of the evaluation stack to <see langword="unsigned int64" />, throwing <see cref="T:System.OverflowException" /> on overflow.</summary>
		// Token: 0x04001356 RID: 4950
		public static readonly OpCode Conv_Ovf_U8 = new OpCode(18266879, 84215041);

		/// <summary>Retrieves the address (type <see langword="&amp;" />) embedded in a typed reference.</summary>
		// Token: 0x04001357 RID: 4951
		public static readonly OpCode Refanyval = new OpCode(18203391, 84739329);

		/// <summary>Throws <see cref="T:System.ArithmeticException" /> if value is not a finite number.</summary>
		// Token: 0x04001358 RID: 4952
		public static readonly OpCode Ckfinite = new OpCode(18400255, 84215041);

		/// <summary>Pushes a typed reference to an instance of a specific type onto the evaluation stack.</summary>
		// Token: 0x04001359 RID: 4953
		public static readonly OpCode Mkrefany = new OpCode(51627775, 84739329);

		/// <summary>Converts a metadata token to its runtime representation, pushing it onto the evaluation stack.</summary>
		// Token: 0x0400135A RID: 4954
		public static readonly OpCode Ldtoken = new OpCode(1429759, 84673793);

		/// <summary>Converts the value on top of the evaluation stack to <see langword="unsigned int16" />, and extends it to <see langword="int32" />.</summary>
		// Token: 0x0400135B RID: 4955
		public static readonly OpCode Conv_U2 = new OpCode(18207231, 84215041);

		/// <summary>Converts the value on top of the evaluation stack to <see langword="unsigned int8" />, and extends it to <see langword="int32" />.</summary>
		// Token: 0x0400135C RID: 4956
		public static readonly OpCode Conv_U1 = new OpCode(18207487, 84215041);

		/// <summary>Converts the value on top of the evaluation stack to <see langword="native int" />.</summary>
		// Token: 0x0400135D RID: 4957
		public static readonly OpCode Conv_I = new OpCode(18207743, 84215041);

		/// <summary>Converts the signed value on top of the evaluation stack to signed <see langword="native int" />, throwing <see cref="T:System.OverflowException" /> on overflow.</summary>
		// Token: 0x0400135E RID: 4958
		public static readonly OpCode Conv_Ovf_I = new OpCode(18207999, 84215041);

		/// <summary>Converts the signed value on top of the evaluation stack to <see langword="unsigned native int" />, throwing <see cref="T:System.OverflowException" /> on overflow.</summary>
		// Token: 0x0400135F RID: 4959
		public static readonly OpCode Conv_Ovf_U = new OpCode(18208255, 84215041);

		/// <summary>Adds two integers, performs an overflow check, and pushes the result onto the evaluation stack.</summary>
		// Token: 0x04001360 RID: 4960
		public static readonly OpCode Add_Ovf = new OpCode(34854655, 84215041);

		/// <summary>Adds two unsigned integer values, performs an overflow check, and pushes the result onto the evaluation stack.</summary>
		// Token: 0x04001361 RID: 4961
		public static readonly OpCode Add_Ovf_Un = new OpCode(34854911, 84215041);

		/// <summary>Multiplies two integer values, performs an overflow check, and pushes the result onto the evaluation stack.</summary>
		// Token: 0x04001362 RID: 4962
		public static readonly OpCode Mul_Ovf = new OpCode(34855167, 84215041);

		/// <summary>Multiplies two unsigned integer values, performs an overflow check, and pushes the result onto the evaluation stack.</summary>
		// Token: 0x04001363 RID: 4963
		public static readonly OpCode Mul_Ovf_Un = new OpCode(34855423, 84215041);

		/// <summary>Subtracts one integer value from another, performs an overflow check, and pushes the result onto the evaluation stack.</summary>
		// Token: 0x04001364 RID: 4964
		public static readonly OpCode Sub_Ovf = new OpCode(34855679, 84215041);

		/// <summary>Subtracts one unsigned integer value from another, performs an overflow check, and pushes the result onto the evaluation stack.</summary>
		// Token: 0x04001365 RID: 4965
		public static readonly OpCode Sub_Ovf_Un = new OpCode(34855935, 84215041);

		/// <summary>Transfers control from the <see langword="fault" /> or <see langword="finally" /> clause of an exception block back to the Common Language Infrastructure (CLI) exception handler.</summary>
		// Token: 0x04001366 RID: 4966
		public static readonly OpCode Endfinally = new OpCode(1236223, 117769473);

		/// <summary>Exits a protected region of code, unconditionally transferring control to a specific target instruction.</summary>
		// Token: 0x04001367 RID: 4967
		public static readonly OpCode Leave = new OpCode(1236479, 1281);

		/// <summary>Exits a protected region of code, unconditionally transferring control to a target instruction (short form).</summary>
		// Token: 0x04001368 RID: 4968
		public static readonly OpCode Leave_S = new OpCode(1236735, 984321);

		/// <summary>Stores a value of type <see langword="native int" /> at a supplied address.</summary>
		// Token: 0x04001369 RID: 4969
		public static readonly OpCode Stind_I = new OpCode(85123071, 84215041);

		/// <summary>Converts the value on top of the evaluation stack to <see langword="unsigned native int" />, and extends it to <see langword="native int" />.</summary>
		// Token: 0x0400136A RID: 4970
		public static readonly OpCode Conv_U = new OpCode(18211071, 84215041);

		/// <summary>This is a reserved instruction.</summary>
		// Token: 0x0400136B RID: 4971
		public static readonly OpCode Prefix7 = new OpCode(1243391, 67437057);

		/// <summary>This is a reserved instruction.</summary>
		// Token: 0x0400136C RID: 4972
		public static readonly OpCode Prefix6 = new OpCode(1243647, 67437057);

		/// <summary>This is a reserved instruction.</summary>
		// Token: 0x0400136D RID: 4973
		public static readonly OpCode Prefix5 = new OpCode(1243903, 67437057);

		/// <summary>This is a reserved instruction.</summary>
		// Token: 0x0400136E RID: 4974
		public static readonly OpCode Prefix4 = new OpCode(1244159, 67437057);

		/// <summary>This is a reserved instruction.</summary>
		// Token: 0x0400136F RID: 4975
		public static readonly OpCode Prefix3 = new OpCode(1244415, 67437057);

		/// <summary>This is a reserved instruction.</summary>
		// Token: 0x04001370 RID: 4976
		public static readonly OpCode Prefix2 = new OpCode(1244671, 67437057);

		/// <summary>This is a reserved instruction.</summary>
		// Token: 0x04001371 RID: 4977
		public static readonly OpCode Prefix1 = new OpCode(1244927, 67437057);

		/// <summary>This is a reserved instruction.</summary>
		// Token: 0x04001372 RID: 4978
		public static readonly OpCode Prefixref = new OpCode(1245183, 67437057);

		/// <summary>Returns an unmanaged pointer to the argument list of the current method.</summary>
		// Token: 0x04001373 RID: 4979
		public static readonly OpCode Arglist = new OpCode(1376510, 84215042);

		/// <summary>Compares two values. If they are equal, the integer value 1 <see langword="(int32" />) is pushed onto the evaluation stack; otherwise 0 (<see langword="int32" />) is pushed onto the evaluation stack.</summary>
		// Token: 0x04001374 RID: 4980
		public static readonly OpCode Ceq = new OpCode(34931198, 84215042);

		/// <summary>Compares two values. If the first value is greater than the second, the integer value 1 <see langword="(int32" />) is pushed onto the evaluation stack; otherwise 0 (<see langword="int32" />) is pushed onto the evaluation stack.</summary>
		// Token: 0x04001375 RID: 4981
		public static readonly OpCode Cgt = new OpCode(34931454, 84215042);

		/// <summary>Compares two unsigned or unordered values. If the first value is greater than the second, the integer value 1 <see langword="(int32" />) is pushed onto the evaluation stack; otherwise 0 (<see langword="int32" />) is pushed onto the evaluation stack.</summary>
		// Token: 0x04001376 RID: 4982
		public static readonly OpCode Cgt_Un = new OpCode(34931710, 84215042);

		/// <summary>Compares two values. If the first value is less than the second, the integer value 1 <see langword="(int32" />) is pushed onto the evaluation stack; otherwise 0 (<see langword="int32" />) is pushed onto the evaluation stack.</summary>
		// Token: 0x04001377 RID: 4983
		public static readonly OpCode Clt = new OpCode(34931966, 84215042);

		/// <summary>Compares the unsigned or unordered values <paramref name="value1" /> and <paramref name="value2" />. If <paramref name="value1" /> is less than <paramref name="value2" />, then the integer value 1 <see langword="(int32" />) is pushed onto the evaluation stack; otherwise 0 (<see langword="int32" />) is pushed onto the evaluation stack.</summary>
		// Token: 0x04001378 RID: 4984
		public static readonly OpCode Clt_Un = new OpCode(34932222, 84215042);

		/// <summary>Pushes an unmanaged pointer (type <see langword="native int" />) to the native code implementing a specific method onto the evaluation stack.</summary>
		// Token: 0x04001379 RID: 4985
		public static readonly OpCode Ldftn = new OpCode(1378046, 84149506);

		/// <summary>Pushes an unmanaged pointer (type <see langword="native int" />) to the native code implementing a particular virtual method associated with a specified object onto the evaluation stack.</summary>
		// Token: 0x0400137A RID: 4986
		public static readonly OpCode Ldvirtftn = new OpCode(169150462, 84149506);

		/// <summary>Loads an argument (referenced by a specified index value) onto the stack.</summary>
		// Token: 0x0400137B RID: 4987
		public static readonly OpCode Ldarg = new OpCode(1247742, 84804866);

		/// <summary>Load an argument address onto the evaluation stack.</summary>
		// Token: 0x0400137C RID: 4988
		public static readonly OpCode Ldarga = new OpCode(1379070, 84804866);

		/// <summary>Stores the value on top of the evaluation stack in the argument slot at a specified index.</summary>
		// Token: 0x0400137D RID: 4989
		public static readonly OpCode Starg = new OpCode(17959934, 84804866);

		/// <summary>Loads the local variable at a specific index onto the evaluation stack.</summary>
		// Token: 0x0400137E RID: 4990
		public static readonly OpCode Ldloc = new OpCode(1248510, 84804866);

		/// <summary>Loads the address of the local variable at a specific index onto the evaluation stack.</summary>
		// Token: 0x0400137F RID: 4991
		public static readonly OpCode Ldloca = new OpCode(1379838, 84804866);

		/// <summary>Pops the current value from the top of the evaluation stack and stores it in a the local variable list at a specified index.</summary>
		// Token: 0x04001380 RID: 4992
		public static readonly OpCode Stloc = new OpCode(17960702, 84804866);

		/// <summary>Allocates a certain number of bytes from the local dynamic memory pool and pushes the address (a transient pointer, type <see langword="*" />) of the first allocated byte onto the evaluation stack.</summary>
		// Token: 0x04001381 RID: 4993
		public static readonly OpCode Localloc = new OpCode(51711998, 84215042);

		/// <summary>Transfers control from the <see langword="filter" /> clause of an exception back to the Common Language Infrastructure (CLI) exception handler.</summary>
		// Token: 0x04001382 RID: 4994
		public static readonly OpCode Endfilter = new OpCode(51515902, 117769474);

		/// <summary>Indicates that an address currently atop the evaluation stack might not be aligned to the natural size of the immediately following <see langword="ldind" />, <see langword="stind" />, <see langword="ldfld" />, <see langword="stfld" />, <see langword="ldobj" />, <see langword="stobj" />, <see langword="initblk" />, or <see langword="cpblk" /> instruction.</summary>
		// Token: 0x04001383 RID: 4995
		public static readonly OpCode Unaligned = new OpCode(1184510, 68158466);

		/// <summary>Specifies that an address currently atop the evaluation stack might be volatile, and the results of reading that location cannot be cached or that multiple stores to that location cannot be suppressed.</summary>
		// Token: 0x04001384 RID: 4996
		public static readonly OpCode Volatile = new OpCode(1184766, 67437570);

		/// <summary>Performs a postfixed method call instruction such that the current method's stack frame is removed before the actual call instruction is executed.</summary>
		// Token: 0x04001385 RID: 4997
		public static readonly OpCode Tailcall = new OpCode(1185022, 67437570);

		/// <summary>Initializes each field of the value type at a specified address to a null reference or a 0 of the appropriate primitive type.</summary>
		// Token: 0x04001386 RID: 4998
		public static readonly OpCode Initobj = new OpCode(51516926, 84738818);

		/// <summary>Constrains the type on which a virtual method call is made.</summary>
		// Token: 0x04001387 RID: 4999
		public static readonly OpCode Constrained = new OpCode(1185534, 67961858);

		/// <summary>Copies a specified number bytes from a source address to a destination address.</summary>
		// Token: 0x04001388 RID: 5000
		public static readonly OpCode Cpblk = new OpCode(118626302, 84215042);

		/// <summary>Initializes a specified block of memory at a specific address to a given size and initial value.</summary>
		// Token: 0x04001389 RID: 5001
		public static readonly OpCode Initblk = new OpCode(118626558, 84215042);

		/// <summary>Rethrows the current exception.</summary>
		// Token: 0x0400138A RID: 5002
		public static readonly OpCode Rethrow = new OpCode(1186558, 134546178);

		/// <summary>Pushes the size, in bytes, of a supplied value type onto the evaluation stack.</summary>
		// Token: 0x0400138B RID: 5003
		public static readonly OpCode Sizeof = new OpCode(1383678, 84739330);

		/// <summary>Retrieves the type token embedded in a typed reference.</summary>
		// Token: 0x0400138C RID: 5004
		public static readonly OpCode Refanytype = new OpCode(18161150, 84215042);

		/// <summary>Specifies that the subsequent array address operation performs no type check at run time, and that it returns a managed pointer whose mutability is restricted.</summary>
		// Token: 0x0400138D RID: 5005
		public static readonly OpCode Readonly = new OpCode(1187582, 67437570);
	}
}
