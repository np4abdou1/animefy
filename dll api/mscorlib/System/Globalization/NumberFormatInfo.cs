using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Threading;

namespace System.Globalization
{
	/// <summary>Provides culture-specific information for formatting and parsing numeric values. </summary>
	// Token: 0x020005A2 RID: 1442
	[ComVisible(true)]
	[Serializable]
	public sealed class NumberFormatInfo : ICloneable, IFormatProvider
	{
		/// <summary>Initializes a new writable instance of the <see cref="T:System.Globalization.NumberFormatInfo" /> class that is culture-independent (invariant).</summary>
		// Token: 0x06002B31 RID: 11057 RVA: 0x000AEEF3 File Offset: 0x000AD0F3
		public NumberFormatInfo() : this(null)
		{
		}

		// Token: 0x06002B32 RID: 11058 RVA: 0x000AEEFC File Offset: 0x000AD0FC
		[OnSerializing]
		private void OnSerializing(StreamingContext ctx)
		{
			if (this.numberDecimalSeparator != this.numberGroupSeparator)
			{
				this.validForParseAsNumber = true;
			}
			else
			{
				this.validForParseAsNumber = false;
			}
			if (this.numberDecimalSeparator != this.numberGroupSeparator && this.numberDecimalSeparator != this.currencyGroupSeparator && this.currencyDecimalSeparator != this.numberGroupSeparator && this.currencyDecimalSeparator != this.currencyGroupSeparator)
			{
				this.validForParseAsCurrency = true;
				return;
			}
			this.validForParseAsCurrency = false;
		}

		// Token: 0x06002B33 RID: 11059 RVA: 0x00002A7D File Offset: 0x00000C7D
		[OnDeserializing]
		private void OnDeserializing(StreamingContext ctx)
		{
		}

		// Token: 0x06002B34 RID: 11060 RVA: 0x00002A7D File Offset: 0x00000C7D
		[OnDeserialized]
		private void OnDeserialized(StreamingContext ctx)
		{
		}

		// Token: 0x06002B35 RID: 11061 RVA: 0x000AEF88 File Offset: 0x000AD188
		[SecuritySafeCritical]
		internal NumberFormatInfo(CultureData cultureData)
		{
			if (GlobalizationMode.Invariant)
			{
				this.m_isInvariant = true;
				return;
			}
			if (cultureData != null)
			{
				cultureData.GetNFIValues(this);
				if (cultureData.IsInvariantCulture)
				{
					this.m_isInvariant = true;
				}
			}
		}

		// Token: 0x06002B36 RID: 11062 RVA: 0x000AF11C File Offset: 0x000AD31C
		private void VerifyWritable()
		{
			if (this.isReadOnly)
			{
				throw new InvalidOperationException(Environment.GetResourceString("Instance is read-only."));
			}
		}

		/// <summary>Gets a read-only <see cref="T:System.Globalization.NumberFormatInfo" /> object that is culture-independent (invariant).</summary>
		/// <returns>A read-only  object that is culture-independent (invariant).</returns>
		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x06002B37 RID: 11063 RVA: 0x000AF136 File Offset: 0x000AD336
		public static NumberFormatInfo InvariantInfo
		{
			get
			{
				if (NumberFormatInfo.invariantInfo == null)
				{
					NumberFormatInfo.invariantInfo = NumberFormatInfo.ReadOnly(new NumberFormatInfo
					{
						m_isInvariant = true
					});
				}
				return NumberFormatInfo.invariantInfo;
			}
		}

		/// <summary>Gets the <see cref="T:System.Globalization.NumberFormatInfo" /> associated with the specified <see cref="T:System.IFormatProvider" />.</summary>
		/// <param name="formatProvider">The <see cref="T:System.IFormatProvider" /> used to get the <see cref="T:System.Globalization.NumberFormatInfo" />.-or- 
		///       <see langword="null" /> to get <see cref="P:System.Globalization.NumberFormatInfo.CurrentInfo" />. </param>
		/// <returns>The <see cref="T:System.Globalization.NumberFormatInfo" /> associated with the specified <see cref="T:System.IFormatProvider" />.</returns>
		// Token: 0x06002B38 RID: 11064 RVA: 0x000AF160 File Offset: 0x000AD360
		public static NumberFormatInfo GetInstance(IFormatProvider formatProvider)
		{
			CultureInfo cultureInfo = formatProvider as CultureInfo;
			if (cultureInfo != null && !cultureInfo.m_isInherited)
			{
				NumberFormatInfo numberFormatInfo = cultureInfo.numInfo;
				if (numberFormatInfo != null)
				{
					return numberFormatInfo;
				}
				return cultureInfo.NumberFormat;
			}
			else
			{
				NumberFormatInfo numberFormatInfo = formatProvider as NumberFormatInfo;
				if (numberFormatInfo != null)
				{
					return numberFormatInfo;
				}
				if (formatProvider != null)
				{
					numberFormatInfo = (formatProvider.GetFormat(typeof(NumberFormatInfo)) as NumberFormatInfo);
					if (numberFormatInfo != null)
					{
						return numberFormatInfo;
					}
				}
				return NumberFormatInfo.CurrentInfo;
			}
		}

		/// <summary>Creates a shallow copy of the <see cref="T:System.Globalization.NumberFormatInfo" /> object.</summary>
		/// <returns>A new object copied from the original <see cref="T:System.Globalization.NumberFormatInfo" /> object.</returns>
		// Token: 0x06002B39 RID: 11065 RVA: 0x000AF1C3 File Offset: 0x000AD3C3
		public object Clone()
		{
			NumberFormatInfo numberFormatInfo = (NumberFormatInfo)base.MemberwiseClone();
			numberFormatInfo.isReadOnly = false;
			return numberFormatInfo;
		}

		/// <summary>Gets or sets the number of decimal places to use in currency values.</summary>
		/// <returns>The number of decimal places to use in currency values. The default for <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> is 2.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The property is being set to a value that is less than 0 or greater than 99. </exception>
		/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.NumberFormatInfo" /> object is read-only. </exception>
		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x06002B3A RID: 11066 RVA: 0x000AF1D7 File Offset: 0x000AD3D7
		public int CurrencyDecimalDigits
		{
			get
			{
				return this.currencyDecimalDigits;
			}
		}

		/// <summary>Gets or sets the string to use as the decimal separator in currency values.</summary>
		/// <returns>The string to use as the decimal separator in currency values. The default for <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> is ".".</returns>
		/// <exception cref="T:System.ArgumentNullException">The property is being set to <see langword="null" />. </exception>
		/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.NumberFormatInfo" /> object is read-only. </exception>
		/// <exception cref="T:System.ArgumentException">The property is being set to an empty string.</exception>
		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x06002B3B RID: 11067 RVA: 0x000AF1DF File Offset: 0x000AD3DF
		public string CurrencyDecimalSeparator
		{
			get
			{
				return this.currencyDecimalSeparator;
			}
		}

		/// <summary>Gets a value that indicates whether this <see cref="T:System.Globalization.NumberFormatInfo" /> object is read-only.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Globalization.NumberFormatInfo" /> is read-only; otherwise, <see langword="false" />.</returns>
		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x06002B3C RID: 11068 RVA: 0x000AF1E7 File Offset: 0x000AD3E7
		public bool IsReadOnly
		{
			get
			{
				return this.isReadOnly;
			}
		}

		/// <summary>Gets or sets the number of digits in each group to the left of the decimal in currency values.</summary>
		/// <returns>The number of digits in each group to the left of the decimal in currency values. The default for <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> is a one-dimensional array with only one element, which is set to 3.</returns>
		/// <exception cref="T:System.ArgumentNullException">The property is being set to <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">The property is being set and the array contains an entry that is less than 0 or greater than 9.-or- The property is being set and the array contains an entry, other than the last entry, that is set to 0. </exception>
		/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.NumberFormatInfo" /> object is read-only. </exception>
		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x06002B3D RID: 11069 RVA: 0x000AF1EF File Offset: 0x000AD3EF
		public int[] CurrencyGroupSizes
		{
			get
			{
				return (int[])this.currencyGroupSizes.Clone();
			}
		}

		/// <summary>Gets or sets the number of digits in each group to the left of the decimal in numeric values.</summary>
		/// <returns>The number of digits in each group to the left of the decimal in numeric values. The default for <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> is a one-dimensional array with only one element, which is set to 3.</returns>
		/// <exception cref="T:System.ArgumentNullException">The property is being set to <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">The property is being set and the array contains an entry that is less than 0 or greater than 9.-or- The property is being set and the array contains an entry, other than the last entry, that is set to 0. </exception>
		/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.NumberFormatInfo" /> object is read-only. </exception>
		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x06002B3E RID: 11070 RVA: 0x000AF201 File Offset: 0x000AD401
		public int[] NumberGroupSizes
		{
			get
			{
				return (int[])this.numberGroupSizes.Clone();
			}
		}

		/// <summary>Gets or sets the number of digits in each group to the left of the decimal in percent values. </summary>
		/// <returns>The number of digits in each group to the left of the decimal in percent values. The default for <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> is a one-dimensional array with only one element, which is set to 3.</returns>
		/// <exception cref="T:System.ArgumentNullException">The property is being set to <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">The property is being set and the array contains an entry that is less than 0 or greater than 9.-or- The property is being set and the array contains an entry, other than the last entry, that is set to 0. </exception>
		/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.NumberFormatInfo" /> object is read-only. </exception>
		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x06002B3F RID: 11071 RVA: 0x000AF213 File Offset: 0x000AD413
		public int[] PercentGroupSizes
		{
			get
			{
				return (int[])this.percentGroupSizes.Clone();
			}
		}

		/// <summary>Gets or sets the string that separates groups of digits to the left of the decimal in currency values.</summary>
		/// <returns>The string that separates groups of digits to the left of the decimal in currency values. The default for <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> is ",".</returns>
		/// <exception cref="T:System.ArgumentNullException">The property is being set to <see langword="null" />. </exception>
		/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.NumberFormatInfo" /> object is read-only. </exception>
		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x06002B40 RID: 11072 RVA: 0x000AF225 File Offset: 0x000AD425
		public string CurrencyGroupSeparator
		{
			get
			{
				return this.currencyGroupSeparator;
			}
		}

		/// <summary>Gets or sets the string to use as the currency symbol.</summary>
		/// <returns>The string to use as the currency symbol. The default for <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> is "¤". </returns>
		/// <exception cref="T:System.ArgumentNullException">The property is being set to <see langword="null" />. </exception>
		/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.NumberFormatInfo" /> object is read-only. </exception>
		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x06002B41 RID: 11073 RVA: 0x000AF22D File Offset: 0x000AD42D
		public string CurrencySymbol
		{
			get
			{
				return this.currencySymbol;
			}
		}

		/// <summary>Gets a read-only <see cref="T:System.Globalization.NumberFormatInfo" /> that formats values based on the current culture.</summary>
		/// <returns>A read-only <see cref="T:System.Globalization.NumberFormatInfo" /> based on the culture of the current thread.</returns>
		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x06002B42 RID: 11074 RVA: 0x000AF238 File Offset: 0x000AD438
		public static NumberFormatInfo CurrentInfo
		{
			get
			{
				CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture;
				if (!currentCulture.m_isInherited)
				{
					NumberFormatInfo numInfo = currentCulture.numInfo;
					if (numInfo != null)
					{
						return numInfo;
					}
				}
				return (NumberFormatInfo)currentCulture.GetFormat(typeof(NumberFormatInfo));
			}
		}

		/// <summary>Gets or sets the string that represents the IEEE NaN (not a number) value.</summary>
		/// <returns>The string that represents the IEEE NaN (not a number) value. The default for <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> is "NaN".</returns>
		/// <exception cref="T:System.ArgumentNullException">The property is being set to <see langword="null" />. </exception>
		/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.NumberFormatInfo" /> object is read-only. </exception>
		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x06002B43 RID: 11075 RVA: 0x000AF27B File Offset: 0x000AD47B
		// (set) Token: 0x06002B44 RID: 11076 RVA: 0x000AF283 File Offset: 0x000AD483
		public string NaNSymbol
		{
			get
			{
				return this.nanSymbol;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("NaNSymbol", Environment.GetResourceString("String reference not set to an instance of a String."));
				}
				this.VerifyWritable();
				this.nanSymbol = value;
			}
		}

		/// <summary>Gets or sets the format pattern for negative currency values.</summary>
		/// <returns>The format pattern for negative currency values. The default for <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> is 0, which represents "($n)", where "$" is the <see cref="P:System.Globalization.NumberFormatInfo.CurrencySymbol" /> and <paramref name="n" /> is a number.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The property is being set to a value that is less than 0 or greater than 15. </exception>
		/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.NumberFormatInfo" /> object is read-only. </exception>
		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x06002B45 RID: 11077 RVA: 0x000AF2AA File Offset: 0x000AD4AA
		public int CurrencyNegativePattern
		{
			get
			{
				return this.currencyNegativePattern;
			}
		}

		/// <summary>Gets or sets the format pattern for negative numeric values.</summary>
		/// <returns>The format pattern for negative numeric values. </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The property is being set to a value that is less than 0 or greater than 4. </exception>
		/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.NumberFormatInfo" /> object is read-only. </exception>
		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x06002B46 RID: 11078 RVA: 0x000AF2B2 File Offset: 0x000AD4B2
		public int NumberNegativePattern
		{
			get
			{
				return this.numberNegativePattern;
			}
		}

		/// <summary>Gets or sets the format pattern for positive percent values.</summary>
		/// <returns>The format pattern for positive percent values. The default for <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> is 0, which represents "n %", where "%" is the <see cref="P:System.Globalization.NumberFormatInfo.PercentSymbol" /> and <paramref name="n" /> is a number.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The property is being set to a value that is less than 0 or greater than 3. </exception>
		/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.NumberFormatInfo" /> object is read-only. </exception>
		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x06002B47 RID: 11079 RVA: 0x000AF2BA File Offset: 0x000AD4BA
		public int PercentPositivePattern
		{
			get
			{
				return this.percentPositivePattern;
			}
		}

		/// <summary>Gets or sets the format pattern for negative percent values.</summary>
		/// <returns>The format pattern for negative percent values. The default for <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> is 0, which represents "-n %", where "%" is the <see cref="P:System.Globalization.NumberFormatInfo.PercentSymbol" /> and <paramref name="n" /> is a number.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The property is being set to a value that is less than 0 or greater than 11. </exception>
		/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.NumberFormatInfo" /> object is read-only. </exception>
		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x06002B48 RID: 11080 RVA: 0x000AF2C2 File Offset: 0x000AD4C2
		public int PercentNegativePattern
		{
			get
			{
				return this.percentNegativePattern;
			}
		}

		/// <summary>Gets or sets the string that represents negative infinity.</summary>
		/// <returns>The string that represents negative infinity. The default for <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> is "-Infinity".</returns>
		/// <exception cref="T:System.ArgumentNullException">The property is being set to <see langword="null" />. </exception>
		/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.NumberFormatInfo" /> object is read-only. </exception>
		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x06002B49 RID: 11081 RVA: 0x000AF2CA File Offset: 0x000AD4CA
		public string NegativeInfinitySymbol
		{
			get
			{
				return this.negativeInfinitySymbol;
			}
		}

		/// <summary>Gets or sets the string that denotes that the associated number is negative.</summary>
		/// <returns>The string that denotes that the associated number is negative. The default for <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> is "-".</returns>
		/// <exception cref="T:System.ArgumentNullException">The property is being set to <see langword="null" />. </exception>
		/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.NumberFormatInfo" /> object is read-only. </exception>
		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x06002B4A RID: 11082 RVA: 0x000AF2D2 File Offset: 0x000AD4D2
		public string NegativeSign
		{
			get
			{
				return this.negativeSign;
			}
		}

		/// <summary>Gets or sets the number of decimal places to use in numeric values.</summary>
		/// <returns>The number of decimal places to use in numeric values. The default for <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> is 2.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The property is being set to a value that is less than 0 or greater than 99. </exception>
		/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.NumberFormatInfo" /> object is read-only. </exception>
		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x06002B4B RID: 11083 RVA: 0x000AF2DA File Offset: 0x000AD4DA
		public int NumberDecimalDigits
		{
			get
			{
				return this.numberDecimalDigits;
			}
		}

		/// <summary>Gets or sets the string to use as the decimal separator in numeric values.</summary>
		/// <returns>The string to use as the decimal separator in numeric values. The default for <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> is ".".</returns>
		/// <exception cref="T:System.ArgumentNullException">The property is being set to <see langword="null" />. </exception>
		/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.NumberFormatInfo" /> object is read-only. </exception>
		/// <exception cref="T:System.ArgumentException">The property is being set to an empty string.</exception>
		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x06002B4C RID: 11084 RVA: 0x000AF2E2 File Offset: 0x000AD4E2
		public string NumberDecimalSeparator
		{
			get
			{
				return this.numberDecimalSeparator;
			}
		}

		/// <summary>Gets or sets the string that separates groups of digits to the left of the decimal in numeric values.</summary>
		/// <returns>The string that separates groups of digits to the left of the decimal in numeric values. The default for <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> is ",".</returns>
		/// <exception cref="T:System.ArgumentNullException">The property is being set to <see langword="null" />. </exception>
		/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.NumberFormatInfo" /> object is read-only. </exception>
		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x06002B4D RID: 11085 RVA: 0x000AF2EA File Offset: 0x000AD4EA
		public string NumberGroupSeparator
		{
			get
			{
				return this.numberGroupSeparator;
			}
		}

		/// <summary>Gets or sets the format pattern for positive currency values.</summary>
		/// <returns>The format pattern for positive currency values. The default for <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> is 0, which represents "$n", where "$" is the <see cref="P:System.Globalization.NumberFormatInfo.CurrencySymbol" /> and <paramref name="n" /> is a number.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The property is being set to a value that is less than 0 or greater than 3. </exception>
		/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.NumberFormatInfo" /> object is read-only. </exception>
		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x06002B4E RID: 11086 RVA: 0x000AF2F2 File Offset: 0x000AD4F2
		public int CurrencyPositivePattern
		{
			get
			{
				return this.currencyPositivePattern;
			}
		}

		/// <summary>Gets or sets the string that represents positive infinity.</summary>
		/// <returns>The string that represents positive infinity. The default for <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> is "Infinity".</returns>
		/// <exception cref="T:System.ArgumentNullException">The property is being set to <see langword="null" />. </exception>
		/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.NumberFormatInfo" /> object is read-only. </exception>
		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x06002B4F RID: 11087 RVA: 0x000AF2FA File Offset: 0x000AD4FA
		public string PositiveInfinitySymbol
		{
			get
			{
				return this.positiveInfinitySymbol;
			}
		}

		/// <summary>Gets or sets the string that denotes that the associated number is positive.</summary>
		/// <returns>The string that denotes that the associated number is positive. The default for <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> is "+".</returns>
		/// <exception cref="T:System.ArgumentNullException">In a set operation, the value to be assigned is <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.NumberFormatInfo" /> object is read-only. </exception>
		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x06002B50 RID: 11088 RVA: 0x000AF302 File Offset: 0x000AD502
		public string PositiveSign
		{
			get
			{
				return this.positiveSign;
			}
		}

		/// <summary>Gets or sets the number of decimal places to use in percent values. </summary>
		/// <returns>The number of decimal places to use in percent values. The default for <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> is 2.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The property is being set to a value that is less than 0 or greater than 99. </exception>
		/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.NumberFormatInfo" /> object is read-only. </exception>
		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x06002B51 RID: 11089 RVA: 0x000AF30A File Offset: 0x000AD50A
		public int PercentDecimalDigits
		{
			get
			{
				return this.percentDecimalDigits;
			}
		}

		/// <summary>Gets or sets the string to use as the decimal separator in percent values. </summary>
		/// <returns>The string to use as the decimal separator in percent values. The default for <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> is ".".</returns>
		/// <exception cref="T:System.ArgumentNullException">The property is being set to <see langword="null" />. </exception>
		/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.NumberFormatInfo" /> object is read-only. </exception>
		/// <exception cref="T:System.ArgumentException">The property is being set to an empty string.</exception>
		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x06002B52 RID: 11090 RVA: 0x000AF312 File Offset: 0x000AD512
		public string PercentDecimalSeparator
		{
			get
			{
				return this.percentDecimalSeparator;
			}
		}

		/// <summary>Gets or sets the string that separates groups of digits to the left of the decimal in percent values. </summary>
		/// <returns>The string that separates groups of digits to the left of the decimal in percent values. The default for <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> is ",".</returns>
		/// <exception cref="T:System.ArgumentNullException">The property is being set to <see langword="null" />. </exception>
		/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.NumberFormatInfo" /> object is read-only. </exception>
		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x06002B53 RID: 11091 RVA: 0x000AF31A File Offset: 0x000AD51A
		public string PercentGroupSeparator
		{
			get
			{
				return this.percentGroupSeparator;
			}
		}

		/// <summary>Gets or sets the string to use as the percent symbol.</summary>
		/// <returns>The string to use as the percent symbol. The default for <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> is "%".</returns>
		/// <exception cref="T:System.ArgumentNullException">The property is being set to <see langword="null" />. </exception>
		/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.NumberFormatInfo" /> object is read-only. </exception>
		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x06002B54 RID: 11092 RVA: 0x000AF322 File Offset: 0x000AD522
		public string PercentSymbol
		{
			get
			{
				return this.percentSymbol;
			}
		}

		/// <summary>Gets or sets the string to use as the per mille symbol.</summary>
		/// <returns>The string to use as the per mille symbol. The default for <see cref="P:System.Globalization.NumberFormatInfo.InvariantInfo" /> is "‰", which is the Unicode character U+2030.</returns>
		/// <exception cref="T:System.ArgumentNullException">The property is being set to <see langword="null" />. </exception>
		/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.NumberFormatInfo" /> object is read-only. </exception>
		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x06002B55 RID: 11093 RVA: 0x000AF32A File Offset: 0x000AD52A
		public string PerMilleSymbol
		{
			get
			{
				return this.perMilleSymbol;
			}
		}

		/// <summary>Gets an object of the specified type that provides a number formatting service.</summary>
		/// <param name="formatType">The <see cref="T:System.Type" /> of the required formatting service. </param>
		/// <returns>The current <see cref="T:System.Globalization.NumberFormatInfo" />, if <paramref name="formatType" /> is the same as the type of the current <see cref="T:System.Globalization.NumberFormatInfo" />; otherwise, <see langword="null" />.</returns>
		// Token: 0x06002B56 RID: 11094 RVA: 0x000AF332 File Offset: 0x000AD532
		public object GetFormat(Type formatType)
		{
			if (!(formatType == typeof(NumberFormatInfo)))
			{
				return null;
			}
			return this;
		}

		/// <summary>Returns a read-only <see cref="T:System.Globalization.NumberFormatInfo" /> wrapper.</summary>
		/// <param name="nfi">The <see cref="T:System.Globalization.NumberFormatInfo" /> to wrap. </param>
		/// <returns>A read-only <see cref="T:System.Globalization.NumberFormatInfo" /> wrapper around <paramref name="nfi" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="nfi" /> is <see langword="null" />. </exception>
		// Token: 0x06002B57 RID: 11095 RVA: 0x000AF349 File Offset: 0x000AD549
		public static NumberFormatInfo ReadOnly(NumberFormatInfo nfi)
		{
			if (nfi == null)
			{
				throw new ArgumentNullException("nfi");
			}
			if (nfi.IsReadOnly)
			{
				return nfi;
			}
			NumberFormatInfo numberFormatInfo = (NumberFormatInfo)nfi.MemberwiseClone();
			numberFormatInfo.isReadOnly = true;
			return numberFormatInfo;
		}

		// Token: 0x06002B58 RID: 11096 RVA: 0x000AF378 File Offset: 0x000AD578
		internal static void ValidateParseStyleInteger(NumberStyles style)
		{
			if ((style & ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent | NumberStyles.AllowCurrencySymbol | NumberStyles.AllowHexSpecifier)) != NumberStyles.None)
			{
				throw new ArgumentException(Environment.GetResourceString("An undefined NumberStyles value is being used."), "style");
			}
			if ((style & NumberStyles.AllowHexSpecifier) != NumberStyles.None && (style & ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowHexSpecifier)) != NumberStyles.None)
			{
				throw new ArgumentException(Environment.GetResourceString("With the AllowHexSpecifier bit set in the enum bit field, the only other valid bits that can be combined into the enum value must be a subset of those in HexNumber."));
			}
		}

		// Token: 0x06002B59 RID: 11097 RVA: 0x000AF3C5 File Offset: 0x000AD5C5
		internal static void ValidateParseStyleFloatingPoint(NumberStyles style)
		{
			if ((style & ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent | NumberStyles.AllowCurrencySymbol | NumberStyles.AllowHexSpecifier)) != NumberStyles.None)
			{
				throw new ArgumentException(Environment.GetResourceString("An undefined NumberStyles value is being used."), "style");
			}
			if ((style & NumberStyles.AllowHexSpecifier) != NumberStyles.None)
			{
				throw new ArgumentException(Environment.GetResourceString("The number style AllowHexSpecifier is not supported on floating point data types."));
			}
		}

		// Token: 0x04001751 RID: 5969
		private static volatile NumberFormatInfo invariantInfo;

		// Token: 0x04001752 RID: 5970
		internal int[] numberGroupSizes = new int[]
		{
			3
		};

		// Token: 0x04001753 RID: 5971
		internal int[] currencyGroupSizes = new int[]
		{
			3
		};

		// Token: 0x04001754 RID: 5972
		internal int[] percentGroupSizes = new int[]
		{
			3
		};

		// Token: 0x04001755 RID: 5973
		internal string positiveSign = "+";

		// Token: 0x04001756 RID: 5974
		internal string negativeSign = "-";

		// Token: 0x04001757 RID: 5975
		internal string numberDecimalSeparator = ".";

		// Token: 0x04001758 RID: 5976
		internal string numberGroupSeparator = ",";

		// Token: 0x04001759 RID: 5977
		internal string currencyGroupSeparator = ",";

		// Token: 0x0400175A RID: 5978
		internal string currencyDecimalSeparator = ".";

		// Token: 0x0400175B RID: 5979
		internal string currencySymbol = "¤";

		// Token: 0x0400175C RID: 5980
		internal string ansiCurrencySymbol;

		// Token: 0x0400175D RID: 5981
		internal string nanSymbol = "NaN";

		// Token: 0x0400175E RID: 5982
		internal string positiveInfinitySymbol = "Infinity";

		// Token: 0x0400175F RID: 5983
		internal string negativeInfinitySymbol = "-Infinity";

		// Token: 0x04001760 RID: 5984
		internal string percentDecimalSeparator = ".";

		// Token: 0x04001761 RID: 5985
		internal string percentGroupSeparator = ",";

		// Token: 0x04001762 RID: 5986
		internal string percentSymbol = "%";

		// Token: 0x04001763 RID: 5987
		internal string perMilleSymbol = "‰";

		// Token: 0x04001764 RID: 5988
		[OptionalField(VersionAdded = 2)]
		internal string[] nativeDigits = new string[]
		{
			"0",
			"1",
			"2",
			"3",
			"4",
			"5",
			"6",
			"7",
			"8",
			"9"
		};

		// Token: 0x04001765 RID: 5989
		[OptionalField(VersionAdded = 1)]
		internal int m_dataItem;

		// Token: 0x04001766 RID: 5990
		internal int numberDecimalDigits = 2;

		// Token: 0x04001767 RID: 5991
		internal int currencyDecimalDigits = 2;

		// Token: 0x04001768 RID: 5992
		internal int currencyPositivePattern;

		// Token: 0x04001769 RID: 5993
		internal int currencyNegativePattern;

		// Token: 0x0400176A RID: 5994
		internal int numberNegativePattern = 1;

		// Token: 0x0400176B RID: 5995
		internal int percentPositivePattern;

		// Token: 0x0400176C RID: 5996
		internal int percentNegativePattern;

		// Token: 0x0400176D RID: 5997
		internal int percentDecimalDigits = 2;

		// Token: 0x0400176E RID: 5998
		[OptionalField(VersionAdded = 2)]
		internal int digitSubstitution = 1;

		// Token: 0x0400176F RID: 5999
		internal bool isReadOnly;

		// Token: 0x04001770 RID: 6000
		[OptionalField(VersionAdded = 1)]
		internal bool m_useUserOverride;

		// Token: 0x04001771 RID: 6001
		[OptionalField(VersionAdded = 2)]
		internal bool m_isInvariant;

		// Token: 0x04001772 RID: 6002
		[OptionalField(VersionAdded = 1)]
		internal bool validForParseAsNumber = true;

		// Token: 0x04001773 RID: 6003
		[OptionalField(VersionAdded = 1)]
		internal bool validForParseAsCurrency = true;

		// Token: 0x04001774 RID: 6004
		private const NumberStyles InvalidNumberStyles = ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent | NumberStyles.AllowCurrencySymbol | NumberStyles.AllowHexSpecifier);
	}
}
