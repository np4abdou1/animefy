using System;
using System.Text;

namespace System.Reflection
{
	// Token: 0x020004BA RID: 1210
	internal sealed class SignatureConstructedGenericType : SignatureType
	{
		// Token: 0x060021C0 RID: 8640 RVA: 0x0008AA0C File Offset: 0x00088C0C
		internal SignatureConstructedGenericType(Type genericTypeDefinition, Type[] typeArguments)
		{
			if (genericTypeDefinition == null)
			{
				throw new ArgumentNullException("genericTypeDefinition");
			}
			if (typeArguments == null)
			{
				throw new ArgumentNullException("typeArguments");
			}
			typeArguments = (Type[])typeArguments.Clone();
			for (int i = 0; i < typeArguments.Length; i++)
			{
				if (typeArguments[i] == null)
				{
					throw new ArgumentNullException("typeArguments");
				}
			}
			this._genericTypeDefinition = genericTypeDefinition;
			this._genericTypeArguments = typeArguments;
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x060021C1 RID: 8641 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		public sealed override bool IsGenericTypeDefinition
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060021C2 RID: 8642 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		protected sealed override bool HasElementTypeImpl()
		{
			return false;
		}

		// Token: 0x060021C3 RID: 8643 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		protected sealed override bool IsArrayImpl()
		{
			return false;
		}

		// Token: 0x060021C4 RID: 8644 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		protected sealed override bool IsByRefImpl()
		{
			return false;
		}

		// Token: 0x060021C5 RID: 8645 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		protected sealed override bool IsPointerImpl()
		{
			return false;
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x060021C6 RID: 8646 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		public sealed override bool IsSZArray
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x060021C7 RID: 8647 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		public sealed override bool IsVariableBoundArray
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x060021C8 RID: 8648 RVA: 0x0000B18D File Offset: 0x0000938D
		public sealed override bool IsConstructedGenericType
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x060021C9 RID: 8649 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		public sealed override bool IsGenericParameter
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x060021CA RID: 8650 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		public sealed override bool IsGenericMethodParameter
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x060021CB RID: 8651 RVA: 0x0008AA80 File Offset: 0x00088C80
		public sealed override bool ContainsGenericParameters
		{
			get
			{
				for (int i = 0; i < this._genericTypeArguments.Length; i++)
				{
					if (this._genericTypeArguments[i].ContainsGenericParameters)
					{
						return true;
					}
				}
				return false;
			}
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x060021CC RID: 8652 RVA: 0x0002AC82 File Offset: 0x00028E82
		internal sealed override SignatureType ElementType
		{
			get
			{
				return null;
			}
		}

		// Token: 0x060021CD RID: 8653 RVA: 0x0008A9F7 File Offset: 0x00088BF7
		public sealed override int GetArrayRank()
		{
			throw new ArgumentException("Must be an array type.");
		}

		// Token: 0x060021CE RID: 8654 RVA: 0x0008AAB2 File Offset: 0x00088CB2
		public sealed override Type GetGenericTypeDefinition()
		{
			return this._genericTypeDefinition;
		}

		// Token: 0x060021CF RID: 8655 RVA: 0x0008AABA File Offset: 0x00088CBA
		public sealed override Type[] GetGenericArguments()
		{
			return this.GenericTypeArguments;
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x060021D0 RID: 8656 RVA: 0x0008AAC2 File Offset: 0x00088CC2
		public sealed override Type[] GenericTypeArguments
		{
			get
			{
				return (Type[])this._genericTypeArguments.Clone();
			}
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x060021D1 RID: 8657 RVA: 0x0002AD06 File Offset: 0x00028F06
		public sealed override int GenericParameterPosition
		{
			get
			{
				throw new InvalidOperationException("Method may only be called on a Type for which Type.IsGenericParameter is true.");
			}
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x060021D2 RID: 8658 RVA: 0x0008AAD4 File Offset: 0x00088CD4
		public sealed override string Name
		{
			get
			{
				return this._genericTypeDefinition.Name;
			}
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x060021D3 RID: 8659 RVA: 0x0008AAE1 File Offset: 0x00088CE1
		public sealed override string Namespace
		{
			get
			{
				return this._genericTypeDefinition.Namespace;
			}
		}

		// Token: 0x060021D4 RID: 8660 RVA: 0x0008AAF0 File Offset: 0x00088CF0
		public sealed override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(this._genericTypeDefinition.ToString());
			stringBuilder.Append('[');
			for (int i = 0; i < this._genericTypeArguments.Length; i++)
			{
				if (i != 0)
				{
					stringBuilder.Append(',');
				}
				stringBuilder.Append(this._genericTypeArguments[i].ToString());
			}
			stringBuilder.Append(']');
			return stringBuilder.ToString();
		}

		// Token: 0x04001063 RID: 4195
		private readonly Type _genericTypeDefinition;

		// Token: 0x04001064 RID: 4196
		private readonly Type[] _genericTypeArguments;
	}
}
