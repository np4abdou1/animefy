using System;
using System.Collections.Generic;
using System.Dynamic.Utils;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

namespace System.Linq.Expressions.Compiler
{
	// Token: 0x020000D2 RID: 210
	internal sealed class BoundConstants
	{
		// Token: 0x17000161 RID: 353
		// (get) Token: 0x060006AD RID: 1709 RVA: 0x00014DCC File Offset: 0x00012FCC
		internal int Count
		{
			get
			{
				return this._values.Count;
			}
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x00014DD9 File Offset: 0x00012FD9
		internal object[] ToArray()
		{
			return this._values.ToArray();
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x00014DE6 File Offset: 0x00012FE6
		internal void AddReference(object value, Type type)
		{
			if (this._indexes.TryAdd(value, this._values.Count))
			{
				this._values.Add(value);
			}
			Helpers.IncrementCount<BoundConstants.TypedConstant>(new BoundConstants.TypedConstant(value, type), this._references);
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x00014E20 File Offset: 0x00013020
		internal void EmitConstant(LambdaCompiler lc, object value, Type type)
		{
			if (!lc.CanEmitBoundConstants)
			{
				throw Error.CannotCompileConstant(value);
			}
			LocalBuilder local;
			if (this._cache.TryGetValue(new BoundConstants.TypedConstant(value, type), out local))
			{
				lc.IL.Emit(OpCodes.Ldloc, local);
				return;
			}
			BoundConstants.EmitConstantsArray(lc);
			this.EmitConstantFromArray(lc, value, type);
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x00014E74 File Offset: 0x00013074
		internal void EmitCacheConstants(LambdaCompiler lc)
		{
			int num = 0;
			foreach (KeyValuePair<BoundConstants.TypedConstant, int> keyValuePair in this._references)
			{
				if (!lc.CanEmitBoundConstants)
				{
					throw Error.CannotCompileConstant(keyValuePair.Key.Value);
				}
				if (BoundConstants.ShouldCache(keyValuePair.Value))
				{
					num++;
				}
			}
			if (num == 0)
			{
				return;
			}
			BoundConstants.EmitConstantsArray(lc);
			this._cache.Clear();
			foreach (KeyValuePair<BoundConstants.TypedConstant, int> keyValuePair2 in this._references)
			{
				if (BoundConstants.ShouldCache(keyValuePair2.Value))
				{
					if (--num > 0)
					{
						lc.IL.Emit(OpCodes.Dup);
					}
					LocalBuilder localBuilder = lc.IL.DeclareLocal(keyValuePair2.Key.Type);
					this.EmitConstantFromArray(lc, keyValuePair2.Key.Value, localBuilder.LocalType);
					lc.IL.Emit(OpCodes.Stloc, localBuilder);
					this._cache.Add(keyValuePair2.Key, localBuilder);
				}
			}
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x00014FC4 File Offset: 0x000131C4
		private static bool ShouldCache(int refCount)
		{
			return refCount > 2;
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x00014FCA File Offset: 0x000131CA
		private static void EmitConstantsArray(LambdaCompiler lc)
		{
			lc.EmitClosureArgument();
			lc.IL.Emit(OpCodes.Ldfld, CachedReflectionInfo.Closure_Constants);
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x00014FE8 File Offset: 0x000131E8
		private void EmitConstantFromArray(LambdaCompiler lc, object value, Type type)
		{
			int count;
			if (!this._indexes.TryGetValue(value, out count))
			{
				this._indexes.Add(value, count = this._values.Count);
				this._values.Add(value);
			}
			lc.IL.EmitPrimitive(count);
			lc.IL.Emit(OpCodes.Ldelem_Ref);
			if (type.IsValueType)
			{
				lc.IL.Emit(OpCodes.Unbox_Any, type);
				return;
			}
			if (type != typeof(object))
			{
				lc.IL.Emit(OpCodes.Castclass, type);
			}
		}

		// Token: 0x040001EA RID: 490
		private readonly List<object> _values = new List<object>();

		// Token: 0x040001EB RID: 491
		private readonly Dictionary<object, int> _indexes = new Dictionary<object, int>(ReferenceEqualityComparer<object>.Instance);

		// Token: 0x040001EC RID: 492
		private readonly Dictionary<BoundConstants.TypedConstant, int> _references = new Dictionary<BoundConstants.TypedConstant, int>();

		// Token: 0x040001ED RID: 493
		private readonly Dictionary<BoundConstants.TypedConstant, LocalBuilder> _cache = new Dictionary<BoundConstants.TypedConstant, LocalBuilder>();

		// Token: 0x020000D3 RID: 211
		private readonly struct TypedConstant : IEquatable<BoundConstants.TypedConstant>
		{
			// Token: 0x060006B6 RID: 1718 RVA: 0x000150BC File Offset: 0x000132BC
			internal TypedConstant(object value, Type type)
			{
				this.Value = value;
				this.Type = type;
			}

			// Token: 0x060006B7 RID: 1719 RVA: 0x000150CC File Offset: 0x000132CC
			public override int GetHashCode()
			{
				return RuntimeHelpers.GetHashCode(this.Value) ^ this.Type.GetHashCode();
			}

			// Token: 0x060006B8 RID: 1720 RVA: 0x000150E5 File Offset: 0x000132E5
			public bool Equals(BoundConstants.TypedConstant other)
			{
				return this.Value == other.Value && this.Type.Equals(other.Type);
			}

			// Token: 0x060006B9 RID: 1721 RVA: 0x00015108 File Offset: 0x00013308
			public override bool Equals(object obj)
			{
				return obj is BoundConstants.TypedConstant && this.Equals((BoundConstants.TypedConstant)obj);
			}

			// Token: 0x040001EE RID: 494
			internal readonly object Value;

			// Token: 0x040001EF RID: 495
			internal readonly Type Type;
		}
	}
}
