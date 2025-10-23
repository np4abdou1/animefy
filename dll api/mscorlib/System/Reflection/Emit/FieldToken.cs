using System;
using System.Runtime.InteropServices;

namespace System.Reflection.Emit
{
	/// <summary>The <see langword="FieldToken" /> struct is an object representation of a token that represents a field.</summary>
	// Token: 0x020004FF RID: 1279
	[ComVisible(true)]
	[Serializable]
	public readonly struct FieldToken : IEquatable<FieldToken>
	{
		// Token: 0x06002513 RID: 9491 RVA: 0x000909E2 File Offset: 0x0008EBE2
		internal FieldToken(int val)
		{
			this.tokValue = val;
		}

		/// <summary>Determines if an object is an instance of <see langword="FieldToken" /> and is equal to this instance.</summary>
		/// <param name="obj">The object to compare to this <see langword="FieldToken" />. </param>
		/// <returns>Returns <see langword="true" /> if <paramref name="obj" /> is an instance of <see langword="FieldToken" /> and is equal to this object; otherwise, <see langword="false" />.</returns>
		// Token: 0x06002514 RID: 9492 RVA: 0x000909EC File Offset: 0x0008EBEC
		public override bool Equals(object obj)
		{
			bool flag = obj is FieldToken;
			if (flag)
			{
				FieldToken fieldToken = (FieldToken)obj;
				flag = (this.tokValue == fieldToken.tokValue);
			}
			return flag;
		}

		/// <summary>Indicates whether the current instance is equal to the specified <see cref="T:System.Reflection.Emit.FieldToken" />.</summary>
		/// <param name="obj">The <see cref="T:System.Reflection.Emit.FieldToken" /> to compare to the current instance.</param>
		/// <returns>
		///     <see langword="true" /> if the value of <paramref name="obj" /> is equal to the value of the current instance; otherwise, <see langword="false" />.</returns>
		// Token: 0x06002515 RID: 9493 RVA: 0x00090A1D File Offset: 0x0008EC1D
		public bool Equals(FieldToken obj)
		{
			return this.tokValue == obj.tokValue;
		}

		/// <summary>Generates the hash code for this field.</summary>
		/// <returns>Returns the hash code for this instance.</returns>
		// Token: 0x06002516 RID: 9494 RVA: 0x00090A2D File Offset: 0x0008EC2D
		public override int GetHashCode()
		{
			return this.tokValue;
		}

		/// <summary>Retrieves the metadata token for this field.</summary>
		/// <returns>Read-only. Retrieves the metadata token of this field.</returns>
		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x06002517 RID: 9495 RVA: 0x00090A2D File Offset: 0x0008EC2D
		public int Token
		{
			get
			{
				return this.tokValue;
			}
		}

		// Token: 0x04001226 RID: 4646
		internal readonly int tokValue;
	}
}
