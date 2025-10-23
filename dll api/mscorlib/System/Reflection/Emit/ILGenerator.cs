using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace System.Reflection.Emit
{
	/// <summary>Generates Microsoft intermediate language (MSIL) instructions.</summary>
	// Token: 0x02000505 RID: 1285
	[StructLayout(0)]
	public class ILGenerator
	{
		// Token: 0x06002546 RID: 9542 RVA: 0x00090D16 File Offset: 0x0008EF16
		internal ILGenerator(Module m, TokenGenerator token_gen, int size)
		{
			if (size < 0)
			{
				size = 128;
			}
			this.code = new byte[size];
			this.token_fixups = new ILTokenInfo[8];
			this.module = m;
			this.token_gen = token_gen;
		}

		// Token: 0x06002547 RID: 9543 RVA: 0x00090D50 File Offset: 0x0008EF50
		private void add_token_fixup(MemberInfo mi)
		{
			if (this.num_token_fixups == this.token_fixups.Length)
			{
				ILTokenInfo[] array = new ILTokenInfo[this.num_token_fixups * 2];
				this.token_fixups.CopyTo(array, 0);
				this.token_fixups = array;
			}
			this.token_fixups[this.num_token_fixups].member = mi;
			ILTokenInfo[] array2 = this.token_fixups;
			int num = this.num_token_fixups;
			this.num_token_fixups = num + 1;
			array2[num].code_pos = this.code_len;
		}

		// Token: 0x06002548 RID: 9544 RVA: 0x00090DD0 File Offset: 0x0008EFD0
		private void make_room(int nbytes)
		{
			if (this.code_len + nbytes < this.code.Length)
			{
				return;
			}
			byte[] destinationArray = new byte[(this.code_len + nbytes) * 2 + 128];
			Array.Copy(this.code, 0, destinationArray, 0, this.code.Length);
			this.code = destinationArray;
		}

		// Token: 0x06002549 RID: 9545 RVA: 0x00090E24 File Offset: 0x0008F024
		private void emit_int(int val)
		{
			byte[] array = this.code;
			int num = this.code_len;
			this.code_len = num + 1;
			array[num] = (byte)(val & 255);
			byte[] array2 = this.code;
			num = this.code_len;
			this.code_len = num + 1;
			array2[num] = (byte)(val >> 8 & 255);
			byte[] array3 = this.code;
			num = this.code_len;
			this.code_len = num + 1;
			array3[num] = (byte)(val >> 16 & 255);
			byte[] array4 = this.code;
			num = this.code_len;
			this.code_len = num + 1;
			array4[num] = (byte)(val >> 24 & 255);
		}

		// Token: 0x0600254A RID: 9546 RVA: 0x00090EBC File Offset: 0x0008F0BC
		private void ll_emit(OpCode opcode)
		{
			int num;
			if (opcode.Size == 2)
			{
				byte[] array = this.code;
				num = this.code_len;
				this.code_len = num + 1;
				array[num] = opcode.op1;
			}
			byte[] array2 = this.code;
			num = this.code_len;
			this.code_len = num + 1;
			array2[num] = opcode.op2;
			switch (opcode.StackBehaviourPush)
			{
			case StackBehaviour.Push1:
			case StackBehaviour.Pushi:
			case StackBehaviour.Pushi8:
			case StackBehaviour.Pushr4:
			case StackBehaviour.Pushr8:
			case StackBehaviour.Pushref:
			case StackBehaviour.Varpush:
				this.cur_stack++;
				break;
			case StackBehaviour.Push1_push1:
				this.cur_stack += 2;
				break;
			}
			if (this.max_stack < this.cur_stack)
			{
				this.max_stack = this.cur_stack;
			}
			switch (opcode.StackBehaviourPop)
			{
			case StackBehaviour.Pop1:
			case StackBehaviour.Popi:
			case StackBehaviour.Popref:
				this.cur_stack--;
				return;
			case StackBehaviour.Pop1_pop1:
			case StackBehaviour.Popi_pop1:
			case StackBehaviour.Popi_popi:
			case StackBehaviour.Popi_popi8:
			case StackBehaviour.Popi_popr4:
			case StackBehaviour.Popi_popr8:
			case StackBehaviour.Popref_pop1:
			case StackBehaviour.Popref_popi:
				this.cur_stack -= 2;
				return;
			case StackBehaviour.Popi_popi_popi:
			case StackBehaviour.Popref_popi_popi:
			case StackBehaviour.Popref_popi_popi8:
			case StackBehaviour.Popref_popi_popr4:
			case StackBehaviour.Popref_popi_popr8:
			case StackBehaviour.Popref_popi_popref:
				this.cur_stack -= 3;
				break;
			case StackBehaviour.Push0:
			case StackBehaviour.Push1:
			case StackBehaviour.Push1_push1:
			case StackBehaviour.Pushi:
			case StackBehaviour.Pushi8:
			case StackBehaviour.Pushr4:
			case StackBehaviour.Pushr8:
			case StackBehaviour.Pushref:
			case StackBehaviour.Varpop:
				break;
			default:
				return;
			}
		}

		// Token: 0x0600254B RID: 9547 RVA: 0x00091023 File Offset: 0x0008F223
		private static int target_len(OpCode opcode)
		{
			if (opcode.OperandType == OperandType.InlineBrTarget)
			{
				return 4;
			}
			return 1;
		}

		// Token: 0x0600254C RID: 9548 RVA: 0x00091034 File Offset: 0x0008F234
		private void InternalEndClause()
		{
			switch (this.ex_handlers[this.cur_block].LastClauseType())
			{
			case -1:
			case 0:
			case 1:
				this.Emit(OpCodes.Leave, this.ex_handlers[this.cur_block].end);
				return;
			case 2:
			case 4:
				this.Emit(OpCodes.Endfinally);
				break;
			case 3:
				break;
			default:
				return;
			}
		}

		/// <summary>Begins a catch block.</summary>
		/// <param name="exceptionType">The <see cref="T:System.Type" /> object that represents the exception. </param>
		/// <exception cref="T:System.ArgumentException">The catch block is within a filtered exception. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="exceptionType" /> is <see langword="null" />, and the exception filter block has not returned a value that indicates that finally blocks should be run until this catch block is located. </exception>
		/// <exception cref="T:System.NotSupportedException">The Microsoft intermediate language (MSIL) being generated is not currently in an exception block. </exception>
		// Token: 0x0600254D RID: 9549 RVA: 0x000910A8 File Offset: 0x0008F2A8
		public virtual void BeginCatchBlock(Type exceptionType)
		{
			if (this.open_blocks == null)
			{
				this.open_blocks = new Stack(2);
			}
			if (this.open_blocks.Count <= 0)
			{
				throw new NotSupportedException("Not in an exception block");
			}
			if (exceptionType != null && exceptionType.IsUserType)
			{
				throw new NotSupportedException("User defined subclasses of System.Type are not yet supported.");
			}
			if (this.ex_handlers[this.cur_block].LastClauseType() == -1)
			{
				if (exceptionType != null)
				{
					throw new ArgumentException("Do not supply an exception type for filter clause");
				}
				this.Emit(OpCodes.Endfilter);
				this.ex_handlers[this.cur_block].PatchFilterClause(this.code_len);
			}
			else
			{
				this.InternalEndClause();
				this.ex_handlers[this.cur_block].AddCatch(exceptionType, this.code_len);
			}
			this.cur_stack = 1;
			if (this.max_stack < this.cur_stack)
			{
				this.max_stack = this.cur_stack;
			}
		}

		/// <summary>Begins an exception block for a filtered exception.</summary>
		/// <exception cref="T:System.NotSupportedException">The Microsoft intermediate language (MSIL) being generated is not currently in an exception block. -or-This <see cref="T:System.Reflection.Emit.ILGenerator" /> belongs to a <see cref="T:System.Reflection.Emit.DynamicMethod" />.</exception>
		// Token: 0x0600254E RID: 9550 RVA: 0x00091198 File Offset: 0x0008F398
		public virtual void BeginExceptFilterBlock()
		{
			if (this.open_blocks == null)
			{
				this.open_blocks = new Stack(2);
			}
			if (this.open_blocks.Count <= 0)
			{
				throw new NotSupportedException("Not in an exception block");
			}
			this.InternalEndClause();
			this.ex_handlers[this.cur_block].AddFilter(this.code_len);
		}

		/// <summary>Begins an exception block for a non-filtered exception.</summary>
		/// <returns>The label for the end of the block. This will leave you in the correct place to execute finally blocks or to finish the try.</returns>
		// Token: 0x0600254F RID: 9551 RVA: 0x000911F4 File Offset: 0x0008F3F4
		public virtual Label BeginExceptionBlock()
		{
			if (this.open_blocks == null)
			{
				this.open_blocks = new Stack(2);
			}
			if (this.ex_handlers != null)
			{
				this.cur_block = this.ex_handlers.Length;
				ILExceptionInfo[] destinationArray = new ILExceptionInfo[this.cur_block + 1];
				Array.Copy(this.ex_handlers, destinationArray, this.cur_block);
				this.ex_handlers = destinationArray;
			}
			else
			{
				this.ex_handlers = new ILExceptionInfo[1];
				this.cur_block = 0;
			}
			this.open_blocks.Push(this.cur_block);
			this.ex_handlers[this.cur_block].start = this.code_len;
			return this.ex_handlers[this.cur_block].end = this.DefineLabel();
		}

		/// <summary>Begins an exception fault block in the Microsoft intermediate language (MSIL) stream.</summary>
		/// <exception cref="T:System.NotSupportedException">The MSIL being generated is not currently in an exception block. -or-This <see cref="T:System.Reflection.Emit.ILGenerator" /> belongs to a <see cref="T:System.Reflection.Emit.DynamicMethod" />.</exception>
		// Token: 0x06002550 RID: 9552 RVA: 0x000912B8 File Offset: 0x0008F4B8
		public virtual void BeginFaultBlock()
		{
			if (this.open_blocks == null)
			{
				this.open_blocks = new Stack(2);
			}
			if (this.open_blocks.Count <= 0)
			{
				throw new NotSupportedException("Not in an exception block");
			}
			if (this.ex_handlers[this.cur_block].LastClauseType() == -1)
			{
				this.Emit(OpCodes.Leave, this.ex_handlers[this.cur_block].end);
				this.ex_handlers[this.cur_block].PatchFilterClause(this.code_len);
			}
			this.InternalEndClause();
			this.ex_handlers[this.cur_block].AddFault(this.code_len);
		}

		/// <summary>Begins a finally block in the Microsoft intermediate language (MSIL) instruction stream.</summary>
		/// <exception cref="T:System.NotSupportedException">The MSIL being generated is not currently in an exception block. </exception>
		// Token: 0x06002551 RID: 9553 RVA: 0x0009136C File Offset: 0x0008F56C
		public virtual void BeginFinallyBlock()
		{
			if (this.open_blocks == null)
			{
				this.open_blocks = new Stack(2);
			}
			if (this.open_blocks.Count <= 0)
			{
				throw new NotSupportedException("Not in an exception block");
			}
			this.InternalEndClause();
			if (this.ex_handlers[this.cur_block].LastClauseType() == -1)
			{
				this.Emit(OpCodes.Leave, this.ex_handlers[this.cur_block].end);
				this.ex_handlers[this.cur_block].PatchFilterClause(this.code_len);
			}
			this.ex_handlers[this.cur_block].AddFinally(this.code_len);
		}

		/// <summary>Declares a local variable of the specified type.</summary>
		/// <param name="localType">A <see cref="T:System.Type" /> object that represents the type of the local variable. </param>
		/// <returns>The declared local variable.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="localType" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.InvalidOperationException">The containing type has been created by the <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" /> method. </exception>
		// Token: 0x06002552 RID: 9554 RVA: 0x0009141E File Offset: 0x0008F61E
		public virtual LocalBuilder DeclareLocal(Type localType)
		{
			return this.DeclareLocal(localType, false);
		}

		/// <summary>Declares a local variable of the specified type, optionally pinning the object referred to by the variable.</summary>
		/// <param name="localType">A <see cref="T:System.Type" /> object that represents the type of the local variable.</param>
		/// <param name="pinned">
		///       <see langword="true" /> to pin the object in memory; otherwise, <see langword="false" />.</param>
		/// <returns>A <see cref="T:System.Reflection.Emit.LocalBuilder" /> object that represents the local variable.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="localType" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.InvalidOperationException">The containing type has been created by the <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" /> method.-or-The method body of the enclosing method has been created by the <see cref="M:System.Reflection.Emit.MethodBuilder.CreateMethodBody(System.Byte[],System.Int32)" /> method. </exception>
		/// <exception cref="T:System.NotSupportedException">The method with which this <see cref="T:System.Reflection.Emit.ILGenerator" /> is associated is not represented by a <see cref="T:System.Reflection.Emit.MethodBuilder" />.</exception>
		// Token: 0x06002553 RID: 9555 RVA: 0x00091428 File Offset: 0x0008F628
		public virtual LocalBuilder DeclareLocal(Type localType, bool pinned)
		{
			if (localType == null)
			{
				throw new ArgumentNullException("localType");
			}
			if (localType.IsUserType)
			{
				throw new NotSupportedException("User defined subclasses of System.Type are not yet supported.");
			}
			LocalBuilder localBuilder = new LocalBuilder(localType, this);
			localBuilder.is_pinned = pinned;
			if (this.locals != null)
			{
				LocalBuilder[] array = new LocalBuilder[this.locals.Length + 1];
				Array.Copy(this.locals, array, this.locals.Length);
				array[this.locals.Length] = localBuilder;
				this.locals = array;
			}
			else
			{
				this.locals = new LocalBuilder[1];
				this.locals[0] = localBuilder;
			}
			localBuilder.position = (ushort)(this.locals.Length - 1);
			return localBuilder;
		}

		/// <summary>Declares a new label.</summary>
		/// <returns>Returns a new label that can be used as a token for branching.</returns>
		// Token: 0x06002554 RID: 9556 RVA: 0x000914D4 File Offset: 0x0008F6D4
		public virtual Label DefineLabel()
		{
			if (this.labels == null)
			{
				this.labels = new ILGenerator.LabelData[4];
			}
			else if (this.num_labels >= this.labels.Length)
			{
				ILGenerator.LabelData[] destinationArray = new ILGenerator.LabelData[this.labels.Length * 2];
				Array.Copy(this.labels, destinationArray, this.labels.Length);
				this.labels = destinationArray;
			}
			this.labels[this.num_labels] = new ILGenerator.LabelData(-1, 0);
			int num = this.num_labels;
			this.num_labels = num + 1;
			return new Label(num);
		}

		/// <summary>Puts the specified instruction onto the stream of instructions.</summary>
		/// <param name="opcode">The Microsoft Intermediate Language (MSIL) instruction to be put onto the stream. </param>
		// Token: 0x06002555 RID: 9557 RVA: 0x00091560 File Offset: 0x0008F760
		public virtual void Emit(OpCode opcode)
		{
			this.make_room(2);
			this.ll_emit(opcode);
		}

		/// <summary>Puts the specified instruction and character argument onto the Microsoft intermediate language (MSIL) stream of instructions.</summary>
		/// <param name="opcode">The MSIL instruction to be put onto the stream. </param>
		/// <param name="arg">The character argument pushed onto the stream immediately after the instruction. </param>
		// Token: 0x06002556 RID: 9558 RVA: 0x00091570 File Offset: 0x0008F770
		public virtual void Emit(OpCode opcode, byte arg)
		{
			this.make_room(3);
			this.ll_emit(opcode);
			byte[] array = this.code;
			int num = this.code_len;
			this.code_len = num + 1;
			array[num] = arg;
		}

		/// <summary>Puts the specified instruction and metadata token for the specified constructor onto the Microsoft intermediate language (MSIL) stream of instructions.</summary>
		/// <param name="opcode">The MSIL instruction to be emitted onto the stream. </param>
		/// <param name="con">A <see langword="ConstructorInfo" /> representing a constructor. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="con" /> is <see langword="null" />. This exception is new in the .NET Framework 4.</exception>
		// Token: 0x06002557 RID: 9559 RVA: 0x000915A4 File Offset: 0x0008F7A4
		[ComVisible(true)]
		public virtual void Emit(OpCode opcode, ConstructorInfo con)
		{
			int token = this.token_gen.GetToken(con, true);
			this.make_room(6);
			this.ll_emit(opcode);
			if (con.DeclaringType.Module == this.module || con is ConstructorOnTypeBuilderInst || con is ConstructorBuilder)
			{
				this.add_token_fixup(con);
			}
			this.emit_int(token);
			if (opcode.StackBehaviourPop == StackBehaviour.Varpop)
			{
				this.cur_stack -= con.GetParametersCount();
			}
		}

		/// <summary>Puts the specified instruction and numerical argument onto the Microsoft intermediate language (MSIL) stream of instructions.</summary>
		/// <param name="opcode">The MSIL instruction to be put onto the stream. Defined in the <see langword="OpCodes" /> enumeration. </param>
		/// <param name="arg">The numerical argument pushed onto the stream immediately after the instruction. </param>
		// Token: 0x06002558 RID: 9560 RVA: 0x00091624 File Offset: 0x0008F824
		public virtual void Emit(OpCode opcode, double arg)
		{
			byte[] bytes = BitConverter.GetBytes(arg);
			this.make_room(10);
			this.ll_emit(opcode);
			if (BitConverter.IsLittleEndian)
			{
				Array.Copy(bytes, 0, this.code, this.code_len, 8);
				this.code_len += 8;
				return;
			}
			byte[] array = this.code;
			int num = this.code_len;
			this.code_len = num + 1;
			array[num] = bytes[7];
			byte[] array2 = this.code;
			num = this.code_len;
			this.code_len = num + 1;
			array2[num] = bytes[6];
			byte[] array3 = this.code;
			num = this.code_len;
			this.code_len = num + 1;
			array3[num] = bytes[5];
			byte[] array4 = this.code;
			num = this.code_len;
			this.code_len = num + 1;
			array4[num] = bytes[4];
			byte[] array5 = this.code;
			num = this.code_len;
			this.code_len = num + 1;
			array5[num] = bytes[3];
			byte[] array6 = this.code;
			num = this.code_len;
			this.code_len = num + 1;
			array6[num] = bytes[2];
			byte[] array7 = this.code;
			num = this.code_len;
			this.code_len = num + 1;
			array7[num] = bytes[1];
			byte[] array8 = this.code;
			num = this.code_len;
			this.code_len = num + 1;
			array8[num] = bytes[0];
		}

		/// <summary>Puts the specified instruction and metadata token for the specified field onto the Microsoft intermediate language (MSIL) stream of instructions.</summary>
		/// <param name="opcode">The MSIL instruction to be emitted onto the stream. </param>
		/// <param name="field">A <see langword="FieldInfo" /> representing a field. </param>
		// Token: 0x06002559 RID: 9561 RVA: 0x0009174C File Offset: 0x0008F94C
		public virtual void Emit(OpCode opcode, FieldInfo field)
		{
			int token = this.token_gen.GetToken(field, true);
			this.make_room(6);
			this.ll_emit(opcode);
			if (field.DeclaringType.Module == this.module || field is FieldOnTypeBuilderInst || field is FieldBuilder)
			{
				this.add_token_fixup(field);
			}
			this.emit_int(token);
		}

		/// <summary>Puts the specified instruction and numerical argument onto the Microsoft intermediate language (MSIL) stream of instructions.</summary>
		/// <param name="opcode">The MSIL instruction to be emitted onto the stream. </param>
		/// <param name="arg">The <see langword="Int" /> argument pushed onto the stream immediately after the instruction. </param>
		// Token: 0x0600255A RID: 9562 RVA: 0x000917AC File Offset: 0x0008F9AC
		public virtual void Emit(OpCode opcode, short arg)
		{
			this.make_room(4);
			this.ll_emit(opcode);
			byte[] array = this.code;
			int num = this.code_len;
			this.code_len = num + 1;
			array[num] = (byte)(arg & 255);
			byte[] array2 = this.code;
			num = this.code_len;
			this.code_len = num + 1;
			array2[num] = (byte)(arg >> 8 & 255);
		}

		/// <summary>Puts the specified instruction and numerical argument onto the Microsoft intermediate language (MSIL) stream of instructions.</summary>
		/// <param name="opcode">The MSIL instruction to be put onto the stream. </param>
		/// <param name="arg">The numerical argument pushed onto the stream immediately after the instruction. </param>
		// Token: 0x0600255B RID: 9563 RVA: 0x00091809 File Offset: 0x0008FA09
		public virtual void Emit(OpCode opcode, int arg)
		{
			this.make_room(6);
			this.ll_emit(opcode);
			this.emit_int(arg);
		}

		/// <summary>Puts the specified instruction and numerical argument onto the Microsoft intermediate language (MSIL) stream of instructions.</summary>
		/// <param name="opcode">The MSIL instruction to be put onto the stream. </param>
		/// <param name="arg">The numerical argument pushed onto the stream immediately after the instruction. </param>
		// Token: 0x0600255C RID: 9564 RVA: 0x00091820 File Offset: 0x0008FA20
		public virtual void Emit(OpCode opcode, long arg)
		{
			this.make_room(10);
			this.ll_emit(opcode);
			byte[] array = this.code;
			int num = this.code_len;
			this.code_len = num + 1;
			array[num] = (byte)(arg & 255L);
			byte[] array2 = this.code;
			num = this.code_len;
			this.code_len = num + 1;
			array2[num] = (byte)(arg >> 8 & 255L);
			byte[] array3 = this.code;
			num = this.code_len;
			this.code_len = num + 1;
			array3[num] = (byte)(arg >> 16 & 255L);
			byte[] array4 = this.code;
			num = this.code_len;
			this.code_len = num + 1;
			array4[num] = (byte)(arg >> 24 & 255L);
			byte[] array5 = this.code;
			num = this.code_len;
			this.code_len = num + 1;
			array5[num] = (byte)(arg >> 32 & 255L);
			byte[] array6 = this.code;
			num = this.code_len;
			this.code_len = num + 1;
			array6[num] = (byte)(arg >> 40 & 255L);
			byte[] array7 = this.code;
			num = this.code_len;
			this.code_len = num + 1;
			array7[num] = (byte)(arg >> 48 & 255L);
			byte[] array8 = this.code;
			num = this.code_len;
			this.code_len = num + 1;
			array8[num] = (byte)(arg >> 56 & 255L);
		}

		/// <summary>Puts the specified instruction onto the Microsoft intermediate language (MSIL) stream and leaves space to include a label when fixes are done.</summary>
		/// <param name="opcode">The MSIL instruction to be emitted onto the stream. </param>
		/// <param name="label">The label to which to branch from this location. </param>
		// Token: 0x0600255D RID: 9565 RVA: 0x00091958 File Offset: 0x0008FB58
		public virtual void Emit(OpCode opcode, Label label)
		{
			int num = ILGenerator.target_len(opcode);
			this.make_room(6);
			this.ll_emit(opcode);
			if (this.cur_stack > this.labels[label.label].maxStack)
			{
				this.labels[label.label].maxStack = this.cur_stack;
			}
			if (this.fixups == null)
			{
				this.fixups = new ILGenerator.LabelFixup[4];
			}
			else if (this.num_fixups >= this.fixups.Length)
			{
				ILGenerator.LabelFixup[] destinationArray = new ILGenerator.LabelFixup[this.fixups.Length * 2];
				Array.Copy(this.fixups, destinationArray, this.fixups.Length);
				this.fixups = destinationArray;
			}
			this.fixups[this.num_fixups].offset = num;
			this.fixups[this.num_fixups].pos = this.code_len;
			this.fixups[this.num_fixups].label_idx = label.label;
			this.num_fixups++;
			this.code_len += num;
		}

		/// <summary>Puts the specified instruction onto the Microsoft intermediate language (MSIL) stream and leaves space to include a label when fixes are done.</summary>
		/// <param name="opcode">The MSIL instruction to be emitted onto the stream. </param>
		/// <param name="labels">The array of label objects to which to branch from this location. All of the labels will be used. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="con" /> is <see langword="null" />. This exception is new in the .NET Framework 4.</exception>
		// Token: 0x0600255E RID: 9566 RVA: 0x00091A70 File Offset: 0x0008FC70
		public virtual void Emit(OpCode opcode, Label[] labels)
		{
			if (labels == null)
			{
				throw new ArgumentNullException("labels");
			}
			int num = labels.Length;
			this.make_room(6 + num * 4);
			this.ll_emit(opcode);
			for (int i = 0; i < num; i++)
			{
				if (this.cur_stack > this.labels[labels[i].label].maxStack)
				{
					this.labels[labels[i].label].maxStack = this.cur_stack;
				}
			}
			this.emit_int(num);
			if (this.fixups == null)
			{
				this.fixups = new ILGenerator.LabelFixup[4 + num];
			}
			else if (this.num_fixups + num >= this.fixups.Length)
			{
				ILGenerator.LabelFixup[] destinationArray = new ILGenerator.LabelFixup[num + this.fixups.Length * 2];
				Array.Copy(this.fixups, destinationArray, this.fixups.Length);
				this.fixups = destinationArray;
			}
			int j = 0;
			int num2 = num * 4;
			while (j < num)
			{
				this.fixups[this.num_fixups].offset = num2;
				this.fixups[this.num_fixups].pos = this.code_len;
				this.fixups[this.num_fixups].label_idx = labels[j].label;
				this.num_fixups++;
				this.code_len += 4;
				j++;
				num2 -= 4;
			}
		}

		/// <summary>Puts the specified instruction onto the Microsoft intermediate language (MSIL) stream followed by the index of the given local variable.</summary>
		/// <param name="opcode">The MSIL instruction to be emitted onto the stream. </param>
		/// <param name="local">A local variable. </param>
		/// <exception cref="T:System.ArgumentException">The parent method of the <paramref name="local" /> parameter does not match the method associated with this <see cref="T:System.Reflection.Emit.ILGenerator" />. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="local" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///         <paramref name="opcode" />
		///
		///          is a single-byte instruction, and <paramref name="local" /> represents a local variable with an index greater than <see langword="Byte.MaxValue" />. </exception>
		// Token: 0x0600255F RID: 9567 RVA: 0x00091BDC File Offset: 0x0008FDDC
		public virtual void Emit(OpCode opcode, LocalBuilder local)
		{
			if (local == null)
			{
				throw new ArgumentNullException("local");
			}
			if (local.ilgen != this)
			{
				throw new ArgumentException("Trying to emit a local from a different ILGenerator.");
			}
			uint position = (uint)local.position;
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			this.make_room(6);
			if (opcode.StackBehaviourPop == StackBehaviour.Pop1)
			{
				this.cur_stack--;
				flag2 = true;
			}
			else if (opcode.StackBehaviourPush == StackBehaviour.Push1 || opcode.StackBehaviourPush == StackBehaviour.Pushi)
			{
				this.cur_stack++;
				flag3 = true;
				if (this.cur_stack > this.max_stack)
				{
					this.max_stack = this.cur_stack;
				}
				flag = (opcode.StackBehaviourPush == StackBehaviour.Pushi);
			}
			if (flag)
			{
				int num;
				if (position < 256U)
				{
					byte[] array = this.code;
					num = this.code_len;
					this.code_len = num + 1;
					array[num] = 18;
					byte[] array2 = this.code;
					num = this.code_len;
					this.code_len = num + 1;
					array2[num] = (byte)position;
					return;
				}
				byte[] array3 = this.code;
				num = this.code_len;
				this.code_len = num + 1;
				array3[num] = 254;
				byte[] array4 = this.code;
				num = this.code_len;
				this.code_len = num + 1;
				array4[num] = 13;
				byte[] array5 = this.code;
				num = this.code_len;
				this.code_len = num + 1;
				array5[num] = (byte)(position & 255U);
				byte[] array6 = this.code;
				num = this.code_len;
				this.code_len = num + 1;
				array6[num] = (byte)(position >> 8 & 255U);
				return;
			}
			else if (flag2)
			{
				int num;
				if (position < 4U)
				{
					byte[] array7 = this.code;
					num = this.code_len;
					this.code_len = num + 1;
					array7[num] = (byte)(10U + position);
					return;
				}
				if (position < 256U)
				{
					byte[] array8 = this.code;
					num = this.code_len;
					this.code_len = num + 1;
					array8[num] = 19;
					byte[] array9 = this.code;
					num = this.code_len;
					this.code_len = num + 1;
					array9[num] = (byte)position;
					return;
				}
				byte[] array10 = this.code;
				num = this.code_len;
				this.code_len = num + 1;
				array10[num] = 254;
				byte[] array11 = this.code;
				num = this.code_len;
				this.code_len = num + 1;
				array11[num] = 14;
				byte[] array12 = this.code;
				num = this.code_len;
				this.code_len = num + 1;
				array12[num] = (byte)(position & 255U);
				byte[] array13 = this.code;
				num = this.code_len;
				this.code_len = num + 1;
				array13[num] = (byte)(position >> 8 & 255U);
				return;
			}
			else
			{
				if (!flag3)
				{
					this.ll_emit(opcode);
					return;
				}
				int num;
				if (position < 4U)
				{
					byte[] array14 = this.code;
					num = this.code_len;
					this.code_len = num + 1;
					array14[num] = (byte)(6U + position);
					return;
				}
				if (position < 256U)
				{
					byte[] array15 = this.code;
					num = this.code_len;
					this.code_len = num + 1;
					array15[num] = 17;
					byte[] array16 = this.code;
					num = this.code_len;
					this.code_len = num + 1;
					array16[num] = (byte)position;
					return;
				}
				byte[] array17 = this.code;
				num = this.code_len;
				this.code_len = num + 1;
				array17[num] = 254;
				byte[] array18 = this.code;
				num = this.code_len;
				this.code_len = num + 1;
				array18[num] = 12;
				byte[] array19 = this.code;
				num = this.code_len;
				this.code_len = num + 1;
				array19[num] = (byte)(position & 255U);
				byte[] array20 = this.code;
				num = this.code_len;
				this.code_len = num + 1;
				array20[num] = (byte)(position >> 8 & 255U);
				return;
			}
		}

		/// <summary>Puts the specified instruction onto the Microsoft intermediate language (MSIL) stream followed by the metadata token for the given method.</summary>
		/// <param name="opcode">The MSIL instruction to be emitted onto the stream. </param>
		/// <param name="meth">A <see langword="MethodInfo" /> representing a method. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="meth" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.NotSupportedException">
		///         <paramref name="meth" /> is a generic method for which the <see cref="P:System.Reflection.MethodInfo.IsGenericMethodDefinition" /> property is <see langword="false" />.</exception>
		// Token: 0x06002560 RID: 9568 RVA: 0x00091F44 File Offset: 0x00090144
		public virtual void Emit(OpCode opcode, MethodInfo meth)
		{
			if (meth == null)
			{
				throw new ArgumentNullException("meth");
			}
			if (meth is DynamicMethod && (opcode == OpCodes.Ldftn || opcode == OpCodes.Ldvirtftn || opcode == OpCodes.Ldtoken))
			{
				throw new ArgumentException("Ldtoken, Ldftn and Ldvirtftn OpCodes cannot target DynamicMethods.");
			}
			int token = this.token_gen.GetToken(meth, true);
			this.make_room(6);
			this.ll_emit(opcode);
			Type declaringType = meth.DeclaringType;
			if (declaringType != null && (declaringType.Module == this.module || meth is MethodOnTypeBuilderInst || meth is MethodBuilder))
			{
				this.add_token_fixup(meth);
			}
			this.emit_int(token);
			if (meth.ReturnType != typeof(void))
			{
				this.cur_stack++;
			}
			if (opcode.StackBehaviourPop == StackBehaviour.Varpop)
			{
				this.cur_stack -= meth.GetParametersCount();
			}
		}

		// Token: 0x06002561 RID: 9569 RVA: 0x00092040 File Offset: 0x00090240
		private void Emit(OpCode opcode, MethodInfo method, int token)
		{
			this.make_room(6);
			this.ll_emit(opcode);
			Type declaringType = method.DeclaringType;
			if (declaringType != null && (declaringType.Module == this.module || method is MethodBuilder))
			{
				this.add_token_fixup(method);
			}
			this.emit_int(token);
			if (method.ReturnType != typeof(void))
			{
				this.cur_stack++;
			}
			if (opcode.StackBehaviourPop == StackBehaviour.Varpop)
			{
				this.cur_stack -= method.GetParametersCount();
			}
		}

		/// <summary>Puts the specified instruction and character argument onto the Microsoft intermediate language (MSIL) stream of instructions.</summary>
		/// <param name="opcode">The MSIL instruction to be put onto the stream. </param>
		/// <param name="arg">The character argument pushed onto the stream immediately after the instruction. </param>
		// Token: 0x06002562 RID: 9570 RVA: 0x000920D8 File Offset: 0x000902D8
		[CLSCompliant(false)]
		public void Emit(OpCode opcode, sbyte arg)
		{
			this.make_room(3);
			this.ll_emit(opcode);
			byte[] array = this.code;
			int num = this.code_len;
			this.code_len = num + 1;
			array[num] = (byte)arg;
		}

		/// <summary>Puts the specified instruction and numerical argument onto the Microsoft intermediate language (MSIL) stream of instructions.</summary>
		/// <param name="opcode">The MSIL instruction to be put onto the stream. </param>
		/// <param name="arg">The <see langword="Single" /> argument pushed onto the stream immediately after the instruction. </param>
		// Token: 0x06002563 RID: 9571 RVA: 0x00092110 File Offset: 0x00090310
		public virtual void Emit(OpCode opcode, float arg)
		{
			byte[] bytes = BitConverter.GetBytes(arg);
			this.make_room(6);
			this.ll_emit(opcode);
			if (BitConverter.IsLittleEndian)
			{
				Array.Copy(bytes, 0, this.code, this.code_len, 4);
				this.code_len += 4;
				return;
			}
			byte[] array = this.code;
			int num = this.code_len;
			this.code_len = num + 1;
			array[num] = bytes[3];
			byte[] array2 = this.code;
			num = this.code_len;
			this.code_len = num + 1;
			array2[num] = bytes[2];
			byte[] array3 = this.code;
			num = this.code_len;
			this.code_len = num + 1;
			array3[num] = bytes[1];
			byte[] array4 = this.code;
			num = this.code_len;
			this.code_len = num + 1;
			array4[num] = bytes[0];
		}

		/// <summary>Puts the specified instruction onto the Microsoft intermediate language (MSIL) stream followed by the metadata token for the given string.</summary>
		/// <param name="opcode">The MSIL instruction to be emitted onto the stream. </param>
		/// <param name="str">The <see langword="String" /> to be emitted. </param>
		// Token: 0x06002564 RID: 9572 RVA: 0x000921C8 File Offset: 0x000903C8
		public virtual void Emit(OpCode opcode, string str)
		{
			int token = this.token_gen.GetToken(str);
			this.make_room(6);
			this.ll_emit(opcode);
			this.emit_int(token);
		}

		/// <summary>Puts the specified instruction onto the Microsoft intermediate language (MSIL) stream followed by the metadata token for the given type.</summary>
		/// <param name="opcode">The MSIL instruction to be put onto the stream. </param>
		/// <param name="cls">A <see langword="Type" />. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="cls" /> is <see langword="null" />. </exception>
		// Token: 0x06002565 RID: 9573 RVA: 0x000921F8 File Offset: 0x000903F8
		public virtual void Emit(OpCode opcode, Type cls)
		{
			if (cls != null && cls.IsByRef)
			{
				throw new ArgumentException("Cannot get TypeToken for a ByRef type.");
			}
			this.make_room(6);
			this.ll_emit(opcode);
			int token = this.token_gen.GetToken(cls, opcode != OpCodes.Ldtoken);
			if (cls is TypeBuilderInstantiation || cls is SymbolType || cls is TypeBuilder || cls is GenericTypeParameterBuilder || cls is EnumBuilder)
			{
				this.add_token_fixup(cls);
			}
			this.emit_int(token);
		}

		/// <summary>Puts a <see langword="call" /> or <see langword="callvirt" /> instruction onto the Microsoft intermediate language (MSIL) stream to call a <see langword="varargs" /> method.</summary>
		/// <param name="opcode">The MSIL instruction to be emitted onto the stream. Must be <see cref="F:System.Reflection.Emit.OpCodes.Call" />, <see cref="F:System.Reflection.Emit.OpCodes.Callvirt" />, or <see cref="F:System.Reflection.Emit.OpCodes.Newobj" />.</param>
		/// <param name="methodInfo">The <see langword="varargs" /> method to be called. </param>
		/// <param name="optionalParameterTypes">The types of the optional arguments if the method is a <see langword="varargs" /> method; otherwise, <see langword="null" />. </param>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="opcode" /> does not specify a method call.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="methodInfo" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.InvalidOperationException">The calling convention for the method is not <see langword="varargs" />, but optional parameter types are supplied. This exception is thrown in the .NET Framework versions 1.0 and 1.1, In subsequent versions, no exception is thrown.</exception>
		// Token: 0x06002566 RID: 9574 RVA: 0x00092280 File Offset: 0x00090480
		public virtual void EmitCall(OpCode opcode, MethodInfo methodInfo, Type[] optionalParameterTypes)
		{
			if (methodInfo == null)
			{
				throw new ArgumentNullException("methodInfo");
			}
			short value = opcode.Value;
			if (value != OpCodes.Call.Value && value != OpCodes.Callvirt.Value)
			{
				throw new NotSupportedException("Only Call and CallVirt are allowed");
			}
			if ((methodInfo.CallingConvention & CallingConventions.VarArgs) == (CallingConventions)0)
			{
				optionalParameterTypes = null;
			}
			if (optionalParameterTypes == null)
			{
				this.Emit(opcode, methodInfo);
				return;
			}
			if ((methodInfo.CallingConvention & CallingConventions.VarArgs) == (CallingConventions)0)
			{
				throw new InvalidOperationException("Method is not VarArgs method and optional types were passed");
			}
			int token = this.token_gen.GetToken(methodInfo, optionalParameterTypes);
			this.Emit(opcode, methodInfo, token);
		}

		/// <summary>Ends an exception block.</summary>
		/// <exception cref="T:System.InvalidOperationException">The end exception block occurs in an unexpected place in the code stream. </exception>
		/// <exception cref="T:System.NotSupportedException">The Microsoft intermediate language (MSIL) being generated is not currently in an exception block. </exception>
		// Token: 0x06002567 RID: 9575 RVA: 0x00092314 File Offset: 0x00090514
		public virtual void EndExceptionBlock()
		{
			if (this.open_blocks == null)
			{
				this.open_blocks = new Stack(2);
			}
			if (this.open_blocks.Count <= 0)
			{
				throw new NotSupportedException("Not in an exception block");
			}
			if (this.ex_handlers[this.cur_block].LastClauseType() == -1)
			{
				throw new InvalidOperationException("Incorrect code generation for exception block.");
			}
			this.InternalEndClause();
			this.MarkLabel(this.ex_handlers[this.cur_block].end);
			this.ex_handlers[this.cur_block].End(this.code_len);
			this.ex_handlers[this.cur_block].Debug(this.cur_block);
			this.open_blocks.Pop();
			if (this.open_blocks.Count > 0)
			{
				this.cur_block = (int)this.open_blocks.Peek();
			}
		}

		/// <summary>Marks the Microsoft intermediate language (MSIL) stream's current position with the given label.</summary>
		/// <param name="loc">The label for which to set an index. </param>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="loc" /> represents an invalid index into the label array.-or- An index for <paramref name="loc" /> has already been defined. </exception>
		// Token: 0x06002568 RID: 9576 RVA: 0x000923FC File Offset: 0x000905FC
		public virtual void MarkLabel(Label loc)
		{
			if (loc.label < 0 || loc.label >= this.num_labels)
			{
				throw new ArgumentException("The label is not valid");
			}
			if (this.labels[loc.label].addr >= 0)
			{
				throw new ArgumentException("The label was already defined");
			}
			this.labels[loc.label].addr = this.code_len;
			if (this.labels[loc.label].maxStack > this.cur_stack)
			{
				this.cur_stack = this.labels[loc.label].maxStack;
			}
		}

		// Token: 0x06002569 RID: 9577 RVA: 0x000924A8 File Offset: 0x000906A8
		internal void label_fixup(MethodBase mb)
		{
			for (int i = 0; i < this.num_fixups; i++)
			{
				if (this.labels[this.fixups[i].label_idx].addr < 0)
				{
					throw new ArgumentException(string.Format("Label #{0} is not marked in method `{1}'", this.fixups[i].label_idx + 1, mb.Name));
				}
				int num = this.labels[this.fixups[i].label_idx].addr - (this.fixups[i].pos + this.fixups[i].offset);
				if (this.fixups[i].offset == 1)
				{
					this.code[this.fixups[i].pos] = (byte)((sbyte)num);
				}
				else
				{
					int num2 = this.code_len;
					this.code_len = this.fixups[i].pos;
					this.emit_int(num);
					this.code_len = num2;
				}
			}
		}

		/// <summary>Gets the current offset, in bytes, in the Microsoft intermediate language (MSIL) stream that is being emitted by the <see cref="T:System.Reflection.Emit.ILGenerator" />.</summary>
		/// <returns>The offset in the MSIL stream at which the next instruction will be emitted. </returns>
		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x0600256A RID: 9578 RVA: 0x000925C1 File Offset: 0x000907C1
		public virtual int ILOffset
		{
			get
			{
				return this.code_len;
			}
		}

		// Token: 0x0400123F RID: 4671
		private byte[] code;

		// Token: 0x04001240 RID: 4672
		private int code_len;

		// Token: 0x04001241 RID: 4673
		private int max_stack;

		// Token: 0x04001242 RID: 4674
		private int cur_stack;

		// Token: 0x04001243 RID: 4675
		private LocalBuilder[] locals;

		// Token: 0x04001244 RID: 4676
		private ILExceptionInfo[] ex_handlers;

		// Token: 0x04001245 RID: 4677
		private int num_token_fixups;

		// Token: 0x04001246 RID: 4678
		private ILTokenInfo[] token_fixups;

		// Token: 0x04001247 RID: 4679
		private ILGenerator.LabelData[] labels;

		// Token: 0x04001248 RID: 4680
		private int num_labels;

		// Token: 0x04001249 RID: 4681
		private ILGenerator.LabelFixup[] fixups;

		// Token: 0x0400124A RID: 4682
		private int num_fixups;

		// Token: 0x0400124B RID: 4683
		internal Module module;

		// Token: 0x0400124C RID: 4684
		private int cur_block;

		// Token: 0x0400124D RID: 4685
		private Stack open_blocks;

		// Token: 0x0400124E RID: 4686
		private TokenGenerator token_gen;

		// Token: 0x0400124F RID: 4687
		private const int defaultFixupSize = 4;

		// Token: 0x04001250 RID: 4688
		private const int defaultLabelsSize = 4;

		// Token: 0x04001251 RID: 4689
		private const int defaultExceptionStackSize = 2;

		// Token: 0x04001252 RID: 4690
		private ArrayList sequencePointLists;

		// Token: 0x04001253 RID: 4691
		private SequencePointList currentSequence;

		// Token: 0x02000506 RID: 1286
		private struct LabelFixup
		{
			// Token: 0x04001254 RID: 4692
			public int offset;

			// Token: 0x04001255 RID: 4693
			public int pos;

			// Token: 0x04001256 RID: 4694
			public int label_idx;
		}

		// Token: 0x02000507 RID: 1287
		private struct LabelData
		{
			// Token: 0x0600256B RID: 9579 RVA: 0x000925C9 File Offset: 0x000907C9
			public LabelData(int addr, int maxStack)
			{
				this.addr = addr;
				this.maxStack = maxStack;
			}

			// Token: 0x04001257 RID: 4695
			public int addr;

			// Token: 0x04001258 RID: 4696
			public int maxStack;
		}
	}
}
