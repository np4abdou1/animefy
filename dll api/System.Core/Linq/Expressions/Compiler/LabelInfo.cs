using System;
using System.Collections.Generic;
using System.Dynamic.Utils;
using System.Reflection.Emit;

namespace System.Linq.Expressions.Compiler
{
	// Token: 0x020000E3 RID: 227
	internal sealed class LabelInfo
	{
		// Token: 0x1700016B RID: 363
		// (get) Token: 0x0600073C RID: 1852 RVA: 0x000179E9 File Offset: 0x00015BE9
		internal Label Label
		{
			get
			{
				this.EnsureLabelAndValue();
				return this._label;
			}
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x000179F7 File Offset: 0x00015BF7
		internal LabelInfo(ILGenerator il, LabelTarget node, bool canReturn)
		{
			this._ilg = il;
			this._node = node;
			this._canReturn = canReturn;
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x0600073E RID: 1854 RVA: 0x00017A35 File Offset: 0x00015C35
		internal bool CanReturn
		{
			get
			{
				return this._canReturn;
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x0600073F RID: 1855 RVA: 0x00017A3D File Offset: 0x00015C3D
		internal bool CanBranch
		{
			get
			{
				return this._opCode != OpCodes.Leave;
			}
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x00017A4F File Offset: 0x00015C4F
		internal void Reference(LabelScopeInfo block)
		{
			this._references.Add(block);
			if (this._definitions.Count > 0)
			{
				this.ValidateJump(block);
			}
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x00017A74 File Offset: 0x00015C74
		internal void Define(LabelScopeInfo block)
		{
			for (LabelScopeInfo labelScopeInfo = block; labelScopeInfo != null; labelScopeInfo = labelScopeInfo.Parent)
			{
				if (labelScopeInfo.ContainsTarget(this._node))
				{
					throw Error.LabelTargetAlreadyDefined(this._node.Name);
				}
			}
			this._definitions.Add(block);
			block.AddLabelInfo(this._node, this);
			if (this._definitions.Count == 1)
			{
				using (List<LabelScopeInfo>.Enumerator enumerator = this._references.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						LabelScopeInfo reference = enumerator.Current;
						this.ValidateJump(reference);
					}
					return;
				}
			}
			if (this._acrossBlockJump)
			{
				throw Error.AmbiguousJump(this._node.Name);
			}
			this._labelDefined = false;
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x00017B3C File Offset: 0x00015D3C
		private void ValidateJump(LabelScopeInfo reference)
		{
			this._opCode = (this._canReturn ? OpCodes.Ret : OpCodes.Br);
			for (LabelScopeInfo labelScopeInfo = reference; labelScopeInfo != null; labelScopeInfo = labelScopeInfo.Parent)
			{
				if (this._definitions.Contains(labelScopeInfo))
				{
					return;
				}
				if (labelScopeInfo.Kind == LabelScopeKind.Finally || labelScopeInfo.Kind == LabelScopeKind.Filter)
				{
					break;
				}
				if (labelScopeInfo.Kind == LabelScopeKind.Try || labelScopeInfo.Kind == LabelScopeKind.Catch)
				{
					this._opCode = OpCodes.Leave;
				}
			}
			this._acrossBlockJump = true;
			if (this._node != null && this._node.Type != typeof(void))
			{
				throw Error.NonLocalJumpWithValue(this._node.Name);
			}
			if (this._definitions.Count > 1)
			{
				throw Error.AmbiguousJump(this._node.Name);
			}
			LabelScopeInfo labelScopeInfo2 = this._definitions.First<LabelScopeInfo>();
			LabelScopeInfo labelScopeInfo3 = Helpers.CommonNode<LabelScopeInfo>(labelScopeInfo2, reference, (LabelScopeInfo b) => b.Parent);
			this._opCode = (this._canReturn ? OpCodes.Ret : OpCodes.Br);
			for (LabelScopeInfo labelScopeInfo4 = reference; labelScopeInfo4 != labelScopeInfo3; labelScopeInfo4 = labelScopeInfo4.Parent)
			{
				if (labelScopeInfo4.Kind == LabelScopeKind.Finally)
				{
					throw Error.ControlCannotLeaveFinally();
				}
				if (labelScopeInfo4.Kind == LabelScopeKind.Filter)
				{
					throw Error.ControlCannotLeaveFilterTest();
				}
				if (labelScopeInfo4.Kind == LabelScopeKind.Try || labelScopeInfo4.Kind == LabelScopeKind.Catch)
				{
					this._opCode = OpCodes.Leave;
				}
			}
			LabelScopeInfo labelScopeInfo5 = labelScopeInfo2;
			while (labelScopeInfo5 != labelScopeInfo3)
			{
				if (!labelScopeInfo5.CanJumpInto)
				{
					if (labelScopeInfo5.Kind == LabelScopeKind.Expression)
					{
						throw Error.ControlCannotEnterExpression();
					}
					throw Error.ControlCannotEnterTry();
				}
				else
				{
					labelScopeInfo5 = labelScopeInfo5.Parent;
				}
			}
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x00017CD3 File Offset: 0x00015ED3
		internal void ValidateFinish()
		{
			if (this._references.Count > 0 && this._definitions.Count == 0)
			{
				throw Error.LabelTargetUndefined(this._node.Name);
			}
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x00017D04 File Offset: 0x00015F04
		internal void EmitJump()
		{
			if (this._opCode == OpCodes.Ret)
			{
				this._ilg.Emit(OpCodes.Ret);
				return;
			}
			this.StoreValue();
			this._ilg.Emit(this._opCode, this.Label);
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x00017D51 File Offset: 0x00015F51
		private void StoreValue()
		{
			this.EnsureLabelAndValue();
			if (this._value != null)
			{
				this._ilg.Emit(OpCodes.Stloc, this._value);
			}
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x00017D77 File Offset: 0x00015F77
		internal void Mark()
		{
			if (this._canReturn)
			{
				if (!this._labelDefined)
				{
					return;
				}
				this._ilg.Emit(OpCodes.Ret);
			}
			else
			{
				this.StoreValue();
			}
			this.MarkWithEmptyStack();
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x00017DA8 File Offset: 0x00015FA8
		internal void MarkWithEmptyStack()
		{
			this._ilg.MarkLabel(this.Label);
			if (this._value != null)
			{
				this._ilg.Emit(OpCodes.Ldloc, this._value);
			}
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x00017DDC File Offset: 0x00015FDC
		private void EnsureLabelAndValue()
		{
			if (!this._labelDefined)
			{
				this._labelDefined = true;
				this._label = this._ilg.DefineLabel();
				if (this._node != null && this._node.Type != typeof(void))
				{
					this._value = this._ilg.DeclareLocal(this._node.Type);
				}
			}
		}

		// Token: 0x04000218 RID: 536
		private readonly LabelTarget _node;

		// Token: 0x04000219 RID: 537
		private Label _label;

		// Token: 0x0400021A RID: 538
		private bool _labelDefined;

		// Token: 0x0400021B RID: 539
		private LocalBuilder _value;

		// Token: 0x0400021C RID: 540
		private readonly HashSet<LabelScopeInfo> _definitions = new HashSet<LabelScopeInfo>();

		// Token: 0x0400021D RID: 541
		private readonly List<LabelScopeInfo> _references = new List<LabelScopeInfo>();

		// Token: 0x0400021E RID: 542
		private readonly bool _canReturn;

		// Token: 0x0400021F RID: 543
		private bool _acrossBlockJump;

		// Token: 0x04000220 RID: 544
		private OpCode _opCode = OpCodes.Leave;

		// Token: 0x04000221 RID: 545
		private readonly ILGenerator _ilg;
	}
}
