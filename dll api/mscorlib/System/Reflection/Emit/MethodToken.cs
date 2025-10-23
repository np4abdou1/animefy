using System;
using System.Runtime.InteropServices;

namespace System.Reflection.Emit
{
	/// <summary>The <see langword="MethodToken" /> struct is an object representation of a token that represents a method.</summary>
	// Token: 0x0200050D RID: 1293
	[ComVisible(true)]
	[Serializable]
	public readonly struct MethodToken : IEquatable<MethodToken>
	{
		// Token: 0x060025BC RID: 9660 RVA: 0x00093032 File Offset: 0x00091232
		internal MethodToken(int val)
		{
			this.tokValue = val;
		}

		/// <summary>Tests whether the given object is equal to this <see langword="MethodToken" /> object.</summary>
		/// <param name="obj">The object to compare to this object. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="obj" /> is an instance of <see langword="MethodToken" /> and is equal to this object; otherwise, <see langword="false" />.</returns>
		// Token: 0x060025BD RID: 9661 RVA: 0x0009303C File Offset: 0x0009123C
		public override bool Equals(object obj)
		{
			bool flag = obj is MethodToken;
			if (flag)
			{
				MethodToken methodToken = (MethodToken)obj;
				flag = (this.tokValue == methodToken.tokValue);
			}
			return flag;
		}

		/// <summary>Indicates whether the current instance is equal to the specified <see cref="T:System.Reflection.Emit.MethodToken" />.</summary>
		/// <param name="obj">The <see cref="T:System.Reflection.Emit.MethodToken" /> to compare to the current instance.</param>
		/// <returns>
		///     <see langword="true" /> if the value of <paramref name="obj" /> is equal to the value of the current instance; otherwise, <see langword="false" />.</returns>
		// Token: 0x060025BE RID: 9662 RVA: 0x0009306D File Offset: 0x0009126D
		public bool Equals(MethodToken obj)
		{
			return this.tokValue == obj.tokValue;
		}

		/// <summary>Returns the generated hash code for this method.</summary>
		/// <returns>Returns the hash code for this instance.</returns>
		// Token: 0x060025BF RID: 9663 RVA: 0x0009307D File Offset: 0x0009127D
		public override int GetHashCode()
		{
			return this.tokValue;
		}

		/// <summary>Returns the metadata token for this method.</summary>
		/// <returns>Read-only. Returns the metadata token for this method.</returns>
		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x060025C0 RID: 9664 RVA: 0x0009307D File Offset: 0x0009127D
		public int Token
		{
			get
			{
				return this.tokValue;
			}
		}

		// Token: 0x0400127D RID: 4733
		internal readonly int tokValue;
	}
}
