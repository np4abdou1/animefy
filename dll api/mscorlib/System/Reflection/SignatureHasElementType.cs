using System;

namespace System.Reflection
{
	// Token: 0x020004BB RID: 1211
	internal abstract class SignatureHasElementType : SignatureType
	{
		// Token: 0x060021D5 RID: 8661 RVA: 0x0008AB60 File Offset: 0x00088D60
		protected SignatureHasElementType(SignatureType elementType)
		{
			this._elementType = elementType;
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x060021D6 RID: 8662 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		public sealed override bool IsGenericTypeDefinition
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060021D7 RID: 8663 RVA: 0x0000B18D File Offset: 0x0000938D
		protected sealed override bool HasElementTypeImpl()
		{
			return true;
		}

		// Token: 0x060021D8 RID: 8664
		protected abstract override bool IsArrayImpl();

		// Token: 0x060021D9 RID: 8665
		protected abstract override bool IsByRefImpl();

		// Token: 0x060021DA RID: 8666
		protected abstract override bool IsPointerImpl();

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x060021DB RID: 8667
		public abstract override bool IsSZArray { get; }

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x060021DC RID: 8668
		public abstract override bool IsVariableBoundArray { get; }

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x060021DD RID: 8669 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		public sealed override bool IsConstructedGenericType
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x060021DE RID: 8670 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		public sealed override bool IsGenericParameter
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x060021DF RID: 8671 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		public sealed override bool IsGenericMethodParameter
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x060021E0 RID: 8672 RVA: 0x0008AB6F File Offset: 0x00088D6F
		public sealed override bool ContainsGenericParameters
		{
			get
			{
				return this._elementType.ContainsGenericParameters;
			}
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x060021E1 RID: 8673 RVA: 0x0008AB7C File Offset: 0x00088D7C
		internal sealed override SignatureType ElementType
		{
			get
			{
				return this._elementType;
			}
		}

		// Token: 0x060021E2 RID: 8674
		public abstract override int GetArrayRank();

		// Token: 0x060021E3 RID: 8675 RVA: 0x0008AB84 File Offset: 0x00088D84
		public sealed override Type GetGenericTypeDefinition()
		{
			throw new InvalidOperationException("This operation is only valid on generic types.");
		}

		// Token: 0x060021E4 RID: 8676 RVA: 0x0008AB90 File Offset: 0x00088D90
		public sealed override Type[] GetGenericArguments()
		{
			return Array.Empty<Type>();
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x060021E5 RID: 8677 RVA: 0x0008AB90 File Offset: 0x00088D90
		public sealed override Type[] GenericTypeArguments
		{
			get
			{
				return Array.Empty<Type>();
			}
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x060021E6 RID: 8678 RVA: 0x0002AD06 File Offset: 0x00028F06
		public sealed override int GenericParameterPosition
		{
			get
			{
				throw new InvalidOperationException("Method may only be called on a Type for which Type.IsGenericParameter is true.");
			}
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x060021E7 RID: 8679 RVA: 0x0008AB97 File Offset: 0x00088D97
		public sealed override string Name
		{
			get
			{
				return this._elementType.Name + this.Suffix;
			}
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x060021E8 RID: 8680 RVA: 0x0008ABAF File Offset: 0x00088DAF
		public sealed override string Namespace
		{
			get
			{
				return this._elementType.Namespace;
			}
		}

		// Token: 0x060021E9 RID: 8681 RVA: 0x0008ABBC File Offset: 0x00088DBC
		public sealed override string ToString()
		{
			return this._elementType.ToString() + this.Suffix;
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x060021EA RID: 8682
		protected abstract string Suffix { get; }

		// Token: 0x04001065 RID: 4197
		private readonly SignatureType _elementType;
	}
}
