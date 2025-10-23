using System;
using System.Runtime.InteropServices;

namespace System.Reflection.Emit
{
	/// <summary>Describes an intermediate language (IL) instruction.</summary>
	// Token: 0x02000510 RID: 1296
	[ComVisible(true)]
	public readonly struct OpCode : IEquatable<OpCode>
	{
		// Token: 0x060025E6 RID: 9702 RVA: 0x00093864 File Offset: 0x00091A64
		internal OpCode(int p, int q)
		{
			this.op1 = (byte)(p & 255);
			this.op2 = (byte)(p >> 8 & 255);
			this.push = (byte)(p >> 16 & 255);
			this.pop = (byte)(p >> 24 & 255);
			this.size = (byte)(q & 255);
			this.type = (byte)(q >> 8 & 255);
			this.args = (byte)(q >> 16 & 255);
			this.flow = (byte)(q >> 24 & 255);
		}

		/// <summary>Returns the generated hash code for this <see langword="Opcode" />.</summary>
		/// <returns>Returns the hash code for this instance.</returns>
		// Token: 0x060025E7 RID: 9703 RVA: 0x000938F1 File Offset: 0x00091AF1
		public override int GetHashCode()
		{
			return this.Name.GetHashCode();
		}

		/// <summary>Tests whether the given object is equal to this <see langword="Opcode" />.</summary>
		/// <param name="obj">The object to compare to this object. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="obj" /> is an instance of <see langword="Opcode" /> and is equal to this object; otherwise, <see langword="false" />.</returns>
		// Token: 0x060025E8 RID: 9704 RVA: 0x00093900 File Offset: 0x00091B00
		public override bool Equals(object obj)
		{
			if (obj == null || !(obj is OpCode))
			{
				return false;
			}
			OpCode opCode = (OpCode)obj;
			return opCode.op1 == this.op1 && opCode.op2 == this.op2;
		}

		/// <summary>Indicates whether the current instance is equal to the specified <see cref="T:System.Reflection.Emit.OpCode" />.</summary>
		/// <param name="obj">The <see cref="T:System.Reflection.Emit.OpCode" /> to compare to the current instance.</param>
		/// <returns>
		///     <see langword="true" /> if the value of <paramref name="obj" /> is equal to the value of the current instance; otherwise, <see langword="false" />.</returns>
		// Token: 0x060025E9 RID: 9705 RVA: 0x0009393F File Offset: 0x00091B3F
		public bool Equals(OpCode obj)
		{
			return obj.op1 == this.op1 && obj.op2 == this.op2;
		}

		/// <summary>Returns this <see langword="Opcode" /> as a <see cref="T:System.String" />.</summary>
		/// <returns>Returns a <see cref="T:System.String" /> containing the name of this <see langword="Opcode" />.</returns>
		// Token: 0x060025EA RID: 9706 RVA: 0x0009395F File Offset: 0x00091B5F
		public override string ToString()
		{
			return this.Name;
		}

		/// <summary>The name of the intermediate language (IL) instruction.</summary>
		/// <returns>Read-only. The name of the IL instruction.</returns>
		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x060025EB RID: 9707 RVA: 0x00093967 File Offset: 0x00091B67
		public string Name
		{
			get
			{
				if (this.op1 == 255)
				{
					return OpCodeNames.names[(int)this.op2];
				}
				return OpCodeNames.names[256 + (int)this.op2];
			}
		}

		/// <summary>The size of the intermediate language (IL) instruction.</summary>
		/// <returns>Read-only. The size of the IL instruction.</returns>
		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x060025EC RID: 9708 RVA: 0x00093995 File Offset: 0x00091B95
		public int Size
		{
			get
			{
				return (int)this.size;
			}
		}

		/// <summary>The operand type of an intermediate language (IL) instruction.</summary>
		/// <returns>Read-only. The operand type of an IL instruction.</returns>
		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x060025ED RID: 9709 RVA: 0x0009399D File Offset: 0x00091B9D
		public OperandType OperandType
		{
			get
			{
				return (OperandType)this.args;
			}
		}

		/// <summary>How the intermediate language (IL) instruction pops the stack.</summary>
		/// <returns>Read-only. The way the IL instruction pops the stack.</returns>
		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x060025EE RID: 9710 RVA: 0x000939A5 File Offset: 0x00091BA5
		public StackBehaviour StackBehaviourPop
		{
			get
			{
				return (StackBehaviour)this.pop;
			}
		}

		/// <summary>How the intermediate language (IL) instruction pushes operand onto the stack.</summary>
		/// <returns>Read-only. The way the IL instruction pushes operand onto the stack.</returns>
		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x060025EF RID: 9711 RVA: 0x000939AD File Offset: 0x00091BAD
		public StackBehaviour StackBehaviourPush
		{
			get
			{
				return (StackBehaviour)this.push;
			}
		}

		/// <summary>Gets the numeric value of the intermediate language (IL) instruction.</summary>
		/// <returns>Read-only. The numeric value of the IL instruction.</returns>
		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x060025F0 RID: 9712 RVA: 0x000939B5 File Offset: 0x00091BB5
		public short Value
		{
			get
			{
				if (this.size == 1)
				{
					return (short)this.op2;
				}
				return (short)((int)this.op1 << 8 | (int)this.op2);
			}
		}

		/// <summary>Indicates whether two <see cref="T:System.Reflection.Emit.OpCode" /> structures are equal.</summary>
		/// <param name="a">The <see cref="T:System.Reflection.Emit.OpCode" /> to compare to <paramref name="b" />.</param>
		/// <param name="b">The <see cref="T:System.Reflection.Emit.OpCode" /> to compare to <paramref name="a" />.</param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="a" /> is equal to <paramref name="b" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x060025F1 RID: 9713 RVA: 0x000939D7 File Offset: 0x00091BD7
		public static bool operator ==(OpCode a, OpCode b)
		{
			return a.op1 == b.op1 && a.op2 == b.op2;
		}

		/// <summary>Indicates whether two <see cref="T:System.Reflection.Emit.OpCode" /> structures are not equal.</summary>
		/// <param name="a">The <see cref="T:System.Reflection.Emit.OpCode" /> to compare to <paramref name="b" />.</param>
		/// <param name="b">The <see cref="T:System.Reflection.Emit.OpCode" /> to compare to <paramref name="a" />.</param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="a" /> is not equal to <paramref name="b" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x060025F2 RID: 9714 RVA: 0x000939F7 File Offset: 0x00091BF7
		public static bool operator !=(OpCode a, OpCode b)
		{
			return a.op1 != b.op1 || a.op2 != b.op2;
		}

		// Token: 0x040012A3 RID: 4771
		internal readonly byte op1;

		// Token: 0x040012A4 RID: 4772
		internal readonly byte op2;

		// Token: 0x040012A5 RID: 4773
		private readonly byte push;

		// Token: 0x040012A6 RID: 4774
		private readonly byte pop;

		// Token: 0x040012A7 RID: 4775
		private readonly byte size;

		// Token: 0x040012A8 RID: 4776
		private readonly byte type;

		// Token: 0x040012A9 RID: 4777
		private readonly byte args;

		// Token: 0x040012AA RID: 4778
		private readonly byte flow;
	}
}
