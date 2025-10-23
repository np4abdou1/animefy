using System;

namespace System.Runtime.CompilerServices
{
	/// <summary>Stores the value of a <see cref="T:System.Decimal" /> constant in metadata. This class cannot be inherited.</summary>
	// Token: 0x02000442 RID: 1090
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter, Inherited = false)]
	[Serializable]
	public sealed class DecimalConstantAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.CompilerServices.DecimalConstantAttribute" /> class with the specified unsigned integer values.</summary>
		/// <param name="scale">The power of 10 scaling factor that indicates the number of digits to the right of the decimal point. Valid values are 0 through 28 inclusive. </param>
		/// <param name="sign">A value of 0 indicates a positive value, and a value of 1 indicates a negative value. </param>
		/// <param name="hi">The high 32 bits of the 96-bit <see cref="P:System.Runtime.CompilerServices.DecimalConstantAttribute.Value" />. </param>
		/// <param name="mid">The middle 32 bits of the 96-bit <see cref="P:System.Runtime.CompilerServices.DecimalConstantAttribute.Value" />. </param>
		/// <param name="low">The low 32 bits of the 96-bit <see cref="P:System.Runtime.CompilerServices.DecimalConstantAttribute.Value" />. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="scale" /> &gt; 28. </exception>
		// Token: 0x06002002 RID: 8194 RVA: 0x00087EB8 File Offset: 0x000860B8
		[CLSCompliant(false)]
		public DecimalConstantAttribute(byte scale, byte sign, uint hi, uint mid, uint low)
		{
			this._dec = new decimal((int)low, (int)mid, (int)hi, sign > 0, scale);
		}

		/// <summary>Gets the decimal constant stored in this attribute.</summary>
		/// <returns>The decimal constant stored in this attribute.</returns>
		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06002003 RID: 8195 RVA: 0x00087ED5 File Offset: 0x000860D5
		public decimal Value
		{
			get
			{
				return this._dec;
			}
		}

		// Token: 0x04000F41 RID: 3905
		private decimal _dec;
	}
}
