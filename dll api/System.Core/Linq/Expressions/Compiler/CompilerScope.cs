using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Dynamic.Utils;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

namespace System.Linq.Expressions.Compiler
{
	// Token: 0x020000D4 RID: 212
	internal sealed class CompilerScope
	{
		// Token: 0x060006BA RID: 1722 RVA: 0x00015120 File Offset: 0x00013320
		internal CompilerScope(object node, bool isMethod)
		{
			this.Node = node;
			this.IsMethod = isMethod;
			IReadOnlyList<ParameterExpression> variables = CompilerScope.GetVariables(node);
			this.Definitions = new Dictionary<ParameterExpression, VariableStorageKind>(variables.Count);
			foreach (ParameterExpression key in variables)
			{
				this.Definitions.Add(key, VariableStorageKind.Local);
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x060006BB RID: 1723 RVA: 0x000151B0 File Offset: 0x000133B0
		internal HoistedLocals NearestHoistedLocals
		{
			get
			{
				return this._hoistedLocals ?? this._closureHoistedLocals;
			}
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x000151C4 File Offset: 0x000133C4
		internal CompilerScope Enter(LambdaCompiler lc, CompilerScope parent)
		{
			this.SetParent(lc, parent);
			this.AllocateLocals(lc);
			if (this.IsMethod && this._closureHoistedLocals != null)
			{
				this.EmitClosureAccess(lc, this._closureHoistedLocals);
			}
			this.EmitNewHoistedLocals(lc);
			if (this.IsMethod)
			{
				this.EmitCachedVariables();
			}
			return this;
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x00015214 File Offset: 0x00013414
		internal CompilerScope Exit()
		{
			if (!this.IsMethod)
			{
				foreach (CompilerScope.Storage storage in this._locals.Values)
				{
					storage.FreeLocal();
				}
			}
			CompilerScope parent = this._parent;
			this._parent = null;
			this._hoistedLocals = null;
			this._closureHoistedLocals = null;
			this._locals.Clear();
			return parent;
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x00015298 File Offset: 0x00013498
		internal void EmitVariableAccess(LambdaCompiler lc, ReadOnlyCollection<ParameterExpression> vars)
		{
			if (this.NearestHoistedLocals != null && vars.Count > 0)
			{
				ArrayBuilder<long> arrayBuilder = new ArrayBuilder<long>(vars.Count);
				foreach (ParameterExpression key in vars)
				{
					ulong num = 0UL;
					HoistedLocals hoistedLocals = this.NearestHoistedLocals;
					while (!hoistedLocals.Indexes.ContainsKey(key))
					{
						num += 1UL;
						hoistedLocals = hoistedLocals.Parent;
					}
					ulong item = num << 32 | (ulong)hoistedLocals.Indexes[key];
					arrayBuilder.UncheckedAdd((long)item);
				}
				this.EmitGet(this.NearestHoistedLocals.SelfVariable);
				lc.EmitConstantArray<long>(arrayBuilder.ToArray());
				lc.IL.Emit(OpCodes.Call, CachedReflectionInfo.RuntimeOps_CreateRuntimeVariables_ObjectArray_Int64Array);
				return;
			}
			lc.IL.Emit(OpCodes.Call, CachedReflectionInfo.RuntimeOps_CreateRuntimeVariables);
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x00015390 File Offset: 0x00013590
		internal void AddLocal(LambdaCompiler gen, ParameterExpression variable)
		{
			this._locals.Add(variable, new CompilerScope.LocalStorage(gen, variable));
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x000153A5 File Offset: 0x000135A5
		internal void EmitGet(ParameterExpression variable)
		{
			this.ResolveVariable(variable).EmitLoad();
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x000153B3 File Offset: 0x000135B3
		internal void EmitSet(ParameterExpression variable)
		{
			this.ResolveVariable(variable).EmitStore();
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x000153C1 File Offset: 0x000135C1
		internal void EmitAddressOf(ParameterExpression variable)
		{
			this.ResolveVariable(variable).EmitAddress();
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x000153CF File Offset: 0x000135CF
		private CompilerScope.Storage ResolveVariable(ParameterExpression variable)
		{
			return this.ResolveVariable(variable, this.NearestHoistedLocals);
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x000153E0 File Offset: 0x000135E0
		private CompilerScope.Storage ResolveVariable(ParameterExpression variable, HoistedLocals hoistedLocals)
		{
			for (CompilerScope compilerScope = this; compilerScope != null; compilerScope = compilerScope._parent)
			{
				CompilerScope.Storage result;
				if (compilerScope._locals.TryGetValue(variable, out result))
				{
					return result;
				}
				if (compilerScope.IsMethod)
				{
					break;
				}
			}
			for (HoistedLocals hoistedLocals2 = hoistedLocals; hoistedLocals2 != null; hoistedLocals2 = hoistedLocals2.Parent)
			{
				int index;
				if (hoistedLocals2.Indexes.TryGetValue(variable, out index))
				{
					return new CompilerScope.ElementBoxStorage(this.ResolveVariable(hoistedLocals2.SelfVariable, hoistedLocals), index, variable);
				}
			}
			throw Error.UndefinedVariable(variable.Name, variable.Type, this.CurrentLambdaName);
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x00015460 File Offset: 0x00013660
		private void SetParent(LambdaCompiler lc, CompilerScope parent)
		{
			this._parent = parent;
			if (this.NeedsClosure && this._parent != null)
			{
				this._closureHoistedLocals = this._parent.NearestHoistedLocals;
			}
			ReadOnlyCollection<ParameterExpression> readOnlyCollection = (from p in this.GetVariables()
			where this.Definitions[p] == VariableStorageKind.Hoisted
			select p).ToReadOnly<ParameterExpression>();
			if (readOnlyCollection.Count > 0)
			{
				this._hoistedLocals = new HoistedLocals(this._closureHoistedLocals, readOnlyCollection);
				this.AddLocal(lc, this._hoistedLocals.SelfVariable);
			}
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x000154E0 File Offset: 0x000136E0
		private void EmitNewHoistedLocals(LambdaCompiler lc)
		{
			if (this._hoistedLocals == null)
			{
				return;
			}
			lc.IL.EmitPrimitive(this._hoistedLocals.Variables.Count);
			lc.IL.Emit(OpCodes.Newarr, typeof(object));
			int num = 0;
			foreach (ParameterExpression parameterExpression in this._hoistedLocals.Variables)
			{
				lc.IL.Emit(OpCodes.Dup);
				lc.IL.EmitPrimitive(num++);
				Type type = typeof(StrongBox<>).MakeGenericType(new Type[]
				{
					parameterExpression.Type
				});
				int index;
				if (this.IsMethod && (index = lc.Parameters.IndexOf(parameterExpression)) >= 0)
				{
					lc.EmitLambdaArgument(index);
					lc.IL.Emit(OpCodes.Newobj, type.GetConstructor(new Type[]
					{
						parameterExpression.Type
					}));
				}
				else if (parameterExpression == this._hoistedLocals.ParentVariable)
				{
					this.ResolveVariable(parameterExpression, this._closureHoistedLocals).EmitLoad();
					lc.IL.Emit(OpCodes.Newobj, type.GetConstructor(new Type[]
					{
						parameterExpression.Type
					}));
				}
				else
				{
					lc.IL.Emit(OpCodes.Newobj, type.GetConstructor(Type.EmptyTypes));
				}
				if (this.ShouldCache(parameterExpression))
				{
					lc.IL.Emit(OpCodes.Dup);
					this.CacheBoxToLocal(lc, parameterExpression);
				}
				lc.IL.Emit(OpCodes.Stelem_Ref);
			}
			this.EmitSet(this._hoistedLocals.SelfVariable);
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x000156AC File Offset: 0x000138AC
		private void EmitCachedVariables()
		{
			if (this.ReferenceCount == null)
			{
				return;
			}
			foreach (KeyValuePair<ParameterExpression, int> keyValuePair in this.ReferenceCount)
			{
				if (this.ShouldCache(keyValuePair.Key, keyValuePair.Value))
				{
					CompilerScope.ElementBoxStorage elementBoxStorage = this.ResolveVariable(keyValuePair.Key) as CompilerScope.ElementBoxStorage;
					if (elementBoxStorage != null)
					{
						elementBoxStorage.EmitLoadBox();
						this.CacheBoxToLocal(elementBoxStorage.Compiler, keyValuePair.Key);
					}
				}
			}
		}

		// Token: 0x060006C8 RID: 1736 RVA: 0x00015748 File Offset: 0x00013948
		private bool ShouldCache(ParameterExpression v, int refCount)
		{
			return refCount > 2 && !this._locals.ContainsKey(v);
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x00015760 File Offset: 0x00013960
		private bool ShouldCache(ParameterExpression v)
		{
			int refCount;
			return this.ReferenceCount != null && this.ReferenceCount.TryGetValue(v, out refCount) && this.ShouldCache(v, refCount);
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x00015794 File Offset: 0x00013994
		private void CacheBoxToLocal(LambdaCompiler lc, ParameterExpression v)
		{
			CompilerScope.LocalBoxStorage localBoxStorage = new CompilerScope.LocalBoxStorage(lc, v);
			localBoxStorage.EmitStoreBox();
			this._locals.Add(v, localBoxStorage);
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x000157BC File Offset: 0x000139BC
		private void EmitClosureAccess(LambdaCompiler lc, HoistedLocals locals)
		{
			if (locals == null)
			{
				return;
			}
			this.EmitClosureToVariable(lc, locals);
			while ((locals = locals.Parent) != null)
			{
				ParameterExpression selfVariable = locals.SelfVariable;
				CompilerScope.LocalStorage localStorage = new CompilerScope.LocalStorage(lc, selfVariable);
				localStorage.EmitStore(this.ResolveVariable(selfVariable));
				this._locals.Add(selfVariable, localStorage);
			}
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x0001580B File Offset: 0x00013A0B
		private void EmitClosureToVariable(LambdaCompiler lc, HoistedLocals locals)
		{
			lc.EmitClosureArgument();
			lc.IL.Emit(OpCodes.Ldfld, CachedReflectionInfo.Closure_Locals);
			this.AddLocal(lc, locals.SelfVariable);
			this.EmitSet(locals.SelfVariable);
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x00015844 File Offset: 0x00013A44
		private void AllocateLocals(LambdaCompiler lc)
		{
			foreach (ParameterExpression parameterExpression in this.GetVariables())
			{
				if (this.Definitions[parameterExpression] == VariableStorageKind.Local)
				{
					CompilerScope.Storage value;
					if (this.IsMethod && lc.Parameters.Contains(parameterExpression))
					{
						value = new CompilerScope.ArgumentStorage(lc, parameterExpression);
					}
					else
					{
						value = new CompilerScope.LocalStorage(lc, parameterExpression);
					}
					this._locals.Add(parameterExpression, value);
				}
			}
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x000158D0 File Offset: 0x00013AD0
		private IEnumerable<ParameterExpression> GetVariables()
		{
			if (this.MergedScopes != null)
			{
				return this.GetVariablesIncludingMerged();
			}
			return CompilerScope.GetVariables(this.Node);
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x000158F9 File Offset: 0x00013AF9
		private IEnumerable<ParameterExpression> GetVariablesIncludingMerged()
		{
			foreach (ParameterExpression parameterExpression in CompilerScope.GetVariables(this.Node))
			{
				yield return parameterExpression;
			}
			IEnumerator<ParameterExpression> enumerator = null;
			foreach (BlockExpression blockExpression in this.MergedScopes)
			{
				foreach (ParameterExpression parameterExpression2 in blockExpression.Variables)
				{
					yield return parameterExpression2;
				}
				enumerator = null;
			}
			HashSet<BlockExpression>.Enumerator enumerator2 = default(HashSet<BlockExpression>.Enumerator);
			yield break;
			yield break;
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x0001590C File Offset: 0x00013B0C
		private static IReadOnlyList<ParameterExpression> GetVariables(object scope)
		{
			LambdaExpression lambdaExpression = scope as LambdaExpression;
			if (lambdaExpression != null)
			{
				return new ParameterList(lambdaExpression);
			}
			BlockExpression blockExpression = scope as BlockExpression;
			if (blockExpression != null)
			{
				return blockExpression.Variables;
			}
			return new ParameterExpression[]
			{
				((CatchBlock)scope).Variable
			};
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x060006D1 RID: 1745 RVA: 0x00015950 File Offset: 0x00013B50
		private string CurrentLambdaName
		{
			get
			{
				for (CompilerScope compilerScope = this; compilerScope != null; compilerScope = compilerScope._parent)
				{
					LambdaExpression lambdaExpression = compilerScope.Node as LambdaExpression;
					if (lambdaExpression != null)
					{
						return lambdaExpression.Name;
					}
				}
				throw ContractUtils.Unreachable;
			}
		}

		// Token: 0x040001F0 RID: 496
		private CompilerScope _parent;

		// Token: 0x040001F1 RID: 497
		internal readonly object Node;

		// Token: 0x040001F2 RID: 498
		internal readonly bool IsMethod;

		// Token: 0x040001F3 RID: 499
		internal bool NeedsClosure;

		// Token: 0x040001F4 RID: 500
		internal readonly Dictionary<ParameterExpression, VariableStorageKind> Definitions = new Dictionary<ParameterExpression, VariableStorageKind>();

		// Token: 0x040001F5 RID: 501
		internal Dictionary<ParameterExpression, int> ReferenceCount;

		// Token: 0x040001F6 RID: 502
		internal HashSet<BlockExpression> MergedScopes;

		// Token: 0x040001F7 RID: 503
		private HoistedLocals _hoistedLocals;

		// Token: 0x040001F8 RID: 504
		private HoistedLocals _closureHoistedLocals;

		// Token: 0x040001F9 RID: 505
		private readonly Dictionary<ParameterExpression, CompilerScope.Storage> _locals = new Dictionary<ParameterExpression, CompilerScope.Storage>();

		// Token: 0x020000D5 RID: 213
		private abstract class Storage
		{
			// Token: 0x060006D3 RID: 1747 RVA: 0x00015997 File Offset: 0x00013B97
			internal Storage(LambdaCompiler compiler, ParameterExpression variable)
			{
				this.Compiler = compiler;
				this.Variable = variable;
			}

			// Token: 0x060006D4 RID: 1748
			internal abstract void EmitLoad();

			// Token: 0x060006D5 RID: 1749
			internal abstract void EmitAddress();

			// Token: 0x060006D6 RID: 1750
			internal abstract void EmitStore();

			// Token: 0x060006D7 RID: 1751 RVA: 0x000159AD File Offset: 0x00013BAD
			internal virtual void EmitStore(CompilerScope.Storage value)
			{
				value.EmitLoad();
				this.EmitStore();
			}

			// Token: 0x060006D8 RID: 1752 RVA: 0x000073D5 File Offset: 0x000055D5
			internal virtual void FreeLocal()
			{
			}

			// Token: 0x040001FA RID: 506
			internal readonly LambdaCompiler Compiler;

			// Token: 0x040001FB RID: 507
			internal readonly ParameterExpression Variable;
		}

		// Token: 0x020000D6 RID: 214
		private sealed class LocalStorage : CompilerScope.Storage
		{
			// Token: 0x060006D9 RID: 1753 RVA: 0x000159BB File Offset: 0x00013BBB
			internal LocalStorage(LambdaCompiler compiler, ParameterExpression variable) : base(compiler, variable)
			{
				this._local = compiler.GetLocal(variable.IsByRef ? variable.Type.MakeByRefType() : variable.Type);
			}

			// Token: 0x060006DA RID: 1754 RVA: 0x000159EC File Offset: 0x00013BEC
			internal override void EmitLoad()
			{
				this.Compiler.IL.Emit(OpCodes.Ldloc, this._local);
			}

			// Token: 0x060006DB RID: 1755 RVA: 0x00015A09 File Offset: 0x00013C09
			internal override void EmitStore()
			{
				this.Compiler.IL.Emit(OpCodes.Stloc, this._local);
			}

			// Token: 0x060006DC RID: 1756 RVA: 0x00015A26 File Offset: 0x00013C26
			internal override void EmitAddress()
			{
				this.Compiler.IL.Emit(OpCodes.Ldloca, this._local);
			}

			// Token: 0x060006DD RID: 1757 RVA: 0x00015A43 File Offset: 0x00013C43
			internal override void FreeLocal()
			{
				this.Compiler.FreeLocal(this._local);
			}

			// Token: 0x040001FC RID: 508
			private readonly LocalBuilder _local;
		}

		// Token: 0x020000D7 RID: 215
		private sealed class ArgumentStorage : CompilerScope.Storage
		{
			// Token: 0x060006DE RID: 1758 RVA: 0x00015A56 File Offset: 0x00013C56
			internal ArgumentStorage(LambdaCompiler compiler, ParameterExpression p) : base(compiler, p)
			{
				this._argument = compiler.GetLambdaArgument(compiler.Parameters.IndexOf(p));
			}

			// Token: 0x060006DF RID: 1759 RVA: 0x00015A78 File Offset: 0x00013C78
			internal override void EmitLoad()
			{
				this.Compiler.IL.EmitLoadArg(this._argument);
			}

			// Token: 0x060006E0 RID: 1760 RVA: 0x00015A90 File Offset: 0x00013C90
			internal override void EmitStore()
			{
				this.Compiler.IL.EmitStoreArg(this._argument);
			}

			// Token: 0x060006E1 RID: 1761 RVA: 0x00015AA8 File Offset: 0x00013CA8
			internal override void EmitAddress()
			{
				this.Compiler.IL.EmitLoadArgAddress(this._argument);
			}

			// Token: 0x040001FD RID: 509
			private readonly int _argument;
		}

		// Token: 0x020000D8 RID: 216
		private sealed class ElementBoxStorage : CompilerScope.Storage
		{
			// Token: 0x060006E2 RID: 1762 RVA: 0x00015AC0 File Offset: 0x00013CC0
			internal ElementBoxStorage(CompilerScope.Storage array, int index, ParameterExpression variable) : base(array.Compiler, variable)
			{
				this._array = array;
				this._index = index;
				this._boxType = typeof(StrongBox<>).MakeGenericType(new Type[]
				{
					variable.Type
				});
				this._boxValueField = this._boxType.GetField("Value");
			}

			// Token: 0x060006E3 RID: 1763 RVA: 0x00015B22 File Offset: 0x00013D22
			internal override void EmitLoad()
			{
				this.EmitLoadBox();
				this.Compiler.IL.Emit(OpCodes.Ldfld, this._boxValueField);
			}

			// Token: 0x060006E4 RID: 1764 RVA: 0x00015B48 File Offset: 0x00013D48
			internal override void EmitStore()
			{
				LocalBuilder local = this.Compiler.GetLocal(this.Variable.Type);
				this.Compiler.IL.Emit(OpCodes.Stloc, local);
				this.EmitLoadBox();
				this.Compiler.IL.Emit(OpCodes.Ldloc, local);
				this.Compiler.FreeLocal(local);
				this.Compiler.IL.Emit(OpCodes.Stfld, this._boxValueField);
			}

			// Token: 0x060006E5 RID: 1765 RVA: 0x00015BC5 File Offset: 0x00013DC5
			internal override void EmitStore(CompilerScope.Storage value)
			{
				this.EmitLoadBox();
				value.EmitLoad();
				this.Compiler.IL.Emit(OpCodes.Stfld, this._boxValueField);
			}

			// Token: 0x060006E6 RID: 1766 RVA: 0x00015BEE File Offset: 0x00013DEE
			internal override void EmitAddress()
			{
				this.EmitLoadBox();
				this.Compiler.IL.Emit(OpCodes.Ldflda, this._boxValueField);
			}

			// Token: 0x060006E7 RID: 1767 RVA: 0x00015C14 File Offset: 0x00013E14
			internal void EmitLoadBox()
			{
				this._array.EmitLoad();
				this.Compiler.IL.EmitPrimitive(this._index);
				this.Compiler.IL.Emit(OpCodes.Ldelem_Ref);
				this.Compiler.IL.Emit(OpCodes.Castclass, this._boxType);
			}

			// Token: 0x040001FE RID: 510
			private readonly int _index;

			// Token: 0x040001FF RID: 511
			private readonly CompilerScope.Storage _array;

			// Token: 0x04000200 RID: 512
			private readonly Type _boxType;

			// Token: 0x04000201 RID: 513
			private readonly FieldInfo _boxValueField;
		}

		// Token: 0x020000D9 RID: 217
		private sealed class LocalBoxStorage : CompilerScope.Storage
		{
			// Token: 0x060006E8 RID: 1768 RVA: 0x00015C74 File Offset: 0x00013E74
			internal LocalBoxStorage(LambdaCompiler compiler, ParameterExpression variable) : base(compiler, variable)
			{
				Type type = typeof(StrongBox<>).MakeGenericType(new Type[]
				{
					variable.Type
				});
				this._boxValueField = type.GetField("Value");
				this._boxLocal = compiler.GetLocal(type);
			}

			// Token: 0x060006E9 RID: 1769 RVA: 0x00015CC6 File Offset: 0x00013EC6
			internal override void EmitLoad()
			{
				this.Compiler.IL.Emit(OpCodes.Ldloc, this._boxLocal);
				this.Compiler.IL.Emit(OpCodes.Ldfld, this._boxValueField);
			}

			// Token: 0x060006EA RID: 1770 RVA: 0x00015CFE File Offset: 0x00013EFE
			internal override void EmitAddress()
			{
				this.Compiler.IL.Emit(OpCodes.Ldloc, this._boxLocal);
				this.Compiler.IL.Emit(OpCodes.Ldflda, this._boxValueField);
			}

			// Token: 0x060006EB RID: 1771 RVA: 0x00015D38 File Offset: 0x00013F38
			internal override void EmitStore()
			{
				LocalBuilder local = this.Compiler.GetLocal(this.Variable.Type);
				this.Compiler.IL.Emit(OpCodes.Stloc, local);
				this.Compiler.IL.Emit(OpCodes.Ldloc, this._boxLocal);
				this.Compiler.IL.Emit(OpCodes.Ldloc, local);
				this.Compiler.FreeLocal(local);
				this.Compiler.IL.Emit(OpCodes.Stfld, this._boxValueField);
			}

			// Token: 0x060006EC RID: 1772 RVA: 0x00015DCA File Offset: 0x00013FCA
			internal override void EmitStore(CompilerScope.Storage value)
			{
				this.Compiler.IL.Emit(OpCodes.Ldloc, this._boxLocal);
				value.EmitLoad();
				this.Compiler.IL.Emit(OpCodes.Stfld, this._boxValueField);
			}

			// Token: 0x060006ED RID: 1773 RVA: 0x00015E08 File Offset: 0x00014008
			internal void EmitStoreBox()
			{
				this.Compiler.IL.Emit(OpCodes.Stloc, this._boxLocal);
			}

			// Token: 0x060006EE RID: 1774 RVA: 0x00015E25 File Offset: 0x00014025
			internal override void FreeLocal()
			{
				this.Compiler.FreeLocal(this._boxLocal);
			}

			// Token: 0x04000202 RID: 514
			private readonly LocalBuilder _boxLocal;

			// Token: 0x04000203 RID: 515
			private readonly FieldInfo _boxValueField;
		}
	}
}
