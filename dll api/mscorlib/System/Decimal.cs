using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>Represents a decimal number.</summary>
	// Token: 0x02000199 RID: 409
	[Serializable]
	[StructLayout(2)]
	public readonly struct Decimal : IFormattable, IComparable, IConvertible, IComparable<decimal>, IEquatable<decimal>, IDeserializationCallback, ISpanFormattable
	{
		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000FA5 RID: 4005 RVA: 0x000414E4 File Offset: 0x0003F6E4
		internal uint High
		{
			get
			{
				return (uint)this.hi;
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000FA6 RID: 4006 RVA: 0x000414EC File Offset: 0x0003F6EC
		internal uint Low
		{
			get
			{
				return (uint)this.lo;
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000FA7 RID: 4007 RVA: 0x000414F4 File Offset: 0x0003F6F4
		internal uint Mid
		{
			get
			{
				return (uint)this.mid;
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000FA8 RID: 4008 RVA: 0x000414FC File Offset: 0x0003F6FC
		internal bool IsNegative
		{
			get
			{
				return this.flags < 0;
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000FA9 RID: 4009 RVA: 0x00041507 File Offset: 0x0003F707
		internal int Scale
		{
			get
			{
				return (int)((byte)(this.flags >> 16));
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x06000FAA RID: 4010 RVA: 0x00041513 File Offset: 0x0003F713
		private ulong Low64
		{
			get
			{
				if (!BitConverter.IsLittleEndian)
				{
					return (ulong)this.Mid << 32 | (ulong)this.Low;
				}
				return this.ulomidLE;
			}
		}

		// Token: 0x06000FAB RID: 4011 RVA: 0x00041535 File Offset: 0x0003F735
		private static ref decimal.DecCalc AsMutable(ref decimal d)
		{
			return Unsafe.As<decimal, decimal.DecCalc>(ref d);
		}

		// Token: 0x06000FAC RID: 4012 RVA: 0x0004153D File Offset: 0x0003F73D
		internal static uint DecDivMod1E9(ref decimal value)
		{
			return decimal.DecCalc.DecDivMod1E9(decimal.AsMutable(ref value));
		}

		/// <summary>Initializes a new instance of <see cref="T:System.Decimal" /> to the value of the specified 32-bit signed integer.</summary>
		/// <param name="value">The value to represent as a <see cref="T:System.Decimal" />. </param>
		// Token: 0x06000FAD RID: 4013 RVA: 0x0004154A File Offset: 0x0003F74A
		public Decimal(int value)
		{
			if (value >= 0)
			{
				this.flags = 0;
			}
			else
			{
				this.flags = int.MinValue;
				value = -value;
			}
			this.lo = value;
			this.mid = 0;
			this.hi = 0;
		}

		/// <summary>Initializes a new instance of <see cref="T:System.Decimal" /> to the value of the specified 32-bit unsigned integer.</summary>
		/// <param name="value">The value to represent as a <see cref="T:System.Decimal" />. </param>
		// Token: 0x06000FAE RID: 4014 RVA: 0x0004157D File Offset: 0x0003F77D
		[CLSCompliant(false)]
		public Decimal(uint value)
		{
			this.flags = 0;
			this.lo = (int)value;
			this.mid = 0;
			this.hi = 0;
		}

		/// <summary>Initializes a new instance of <see cref="T:System.Decimal" /> to the value of the specified 64-bit signed integer.</summary>
		/// <param name="value">The value to represent as a <see cref="T:System.Decimal" />. </param>
		// Token: 0x06000FAF RID: 4015 RVA: 0x0004159B File Offset: 0x0003F79B
		public Decimal(long value)
		{
			if (value >= 0L)
			{
				this.flags = 0;
			}
			else
			{
				this.flags = int.MinValue;
				value = -value;
			}
			this.lo = (int)value;
			this.mid = (int)(value >> 32);
			this.hi = 0;
		}

		/// <summary>Initializes a new instance of <see cref="T:System.Decimal" /> to the value of the specified 64-bit unsigned integer.</summary>
		/// <param name="value">The value to represent as a <see cref="T:System.Decimal" />. </param>
		// Token: 0x06000FB0 RID: 4016 RVA: 0x000415D4 File Offset: 0x0003F7D4
		[CLSCompliant(false)]
		public Decimal(ulong value)
		{
			this.flags = 0;
			this.lo = (int)value;
			this.mid = (int)(value >> 32);
			this.hi = 0;
		}

		/// <summary>Initializes a new instance of <see cref="T:System.Decimal" /> to the value of the specified single-precision floating-point number.</summary>
		/// <param name="value">The value to represent as a <see cref="T:System.Decimal" />. </param>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is greater than <see cref="F:System.Decimal.MaxValue" /> or less than <see cref="F:System.Decimal.MinValue" />.-or- 
		///         <paramref name="value" /> is <see cref="F:System.Single.NaN" />, <see cref="F:System.Single.PositiveInfinity" />, or <see cref="F:System.Single.NegativeInfinity" />. </exception>
		// Token: 0x06000FB1 RID: 4017 RVA: 0x000415F7 File Offset: 0x0003F7F7
		public Decimal(float value)
		{
			decimal.DecCalc.VarDecFromR4(value, decimal.AsMutable(ref this));
		}

		/// <summary>Initializes a new instance of <see cref="T:System.Decimal" /> to the value of the specified double-precision floating-point number.</summary>
		/// <param name="value">The value to represent as a <see cref="T:System.Decimal" />. </param>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is greater than <see cref="F:System.Decimal.MaxValue" /> or less than <see cref="F:System.Decimal.MinValue" />.-or- 
		///         <paramref name="value" /> is <see cref="F:System.Double.NaN" />, <see cref="F:System.Double.PositiveInfinity" />, or <see cref="F:System.Double.NegativeInfinity" />. </exception>
		// Token: 0x06000FB2 RID: 4018 RVA: 0x00041605 File Offset: 0x0003F805
		public Decimal(double value)
		{
			decimal.DecCalc.VarDecFromR8(value, decimal.AsMutable(ref this));
		}

		// Token: 0x06000FB3 RID: 4019 RVA: 0x00041613 File Offset: 0x0003F813
		private static bool IsValid(int flags)
		{
			return (flags & 2130771967) == 0 && (flags & 16711680) <= 1835008;
		}

		/// <summary>Initializes a new instance of <see cref="T:System.Decimal" /> to a decimal value represented in binary and contained in a specified array.</summary>
		/// <param name="bits">An array of 32-bit signed integers containing a representation of a decimal value. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="bits" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">The length of the <paramref name="bits" /> is not 4.-or- The representation of the decimal value in <paramref name="bits" /> is not valid. </exception>
		// Token: 0x06000FB4 RID: 4020 RVA: 0x00041634 File Offset: 0x0003F834
		public Decimal(int[] bits)
		{
			if (bits == null)
			{
				throw new ArgumentNullException("bits");
			}
			if (bits.Length == 4)
			{
				int num = bits[3];
				if (decimal.IsValid(num))
				{
					this.lo = bits[0];
					this.mid = bits[1];
					this.hi = bits[2];
					this.flags = num;
					return;
				}
			}
			throw new ArgumentException("Decimal byte array constructor requires an array of length four containing valid decimal bytes.");
		}

		/// <summary>Initializes a new instance of <see cref="T:System.Decimal" /> from parameters specifying the instance's constituent parts.</summary>
		/// <param name="lo">The low 32 bits of a 96-bit integer. </param>
		/// <param name="mid">The middle 32 bits of a 96-bit integer. </param>
		/// <param name="hi">The high 32 bits of a 96-bit integer. </param>
		/// <param name="isNegative">
		///       <see langword="true" /> to indicate a negative number; <see langword="false" /> to indicate a positive number. </param>
		/// <param name="scale">A power of 10 ranging from 0 to 28. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="scale" /> is greater than 28. </exception>
		// Token: 0x06000FB5 RID: 4021 RVA: 0x00041690 File Offset: 0x0003F890
		public Decimal(int lo, int mid, int hi, bool isNegative, byte scale)
		{
			if (scale > 28)
			{
				throw new ArgumentOutOfRangeException("scale", "Decimal's scale value must be between 0 and 28, inclusive.");
			}
			this.lo = lo;
			this.mid = mid;
			this.hi = hi;
			this.flags = (int)scale << 16;
			if (isNegative)
			{
				this.flags |= int.MinValue;
			}
		}

		/// <summary>Runs when the deserialization of an object has been completed.</summary>
		/// <param name="sender">The object that initiated the callback. The functionality for this parameter is not currently implemented.</param>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">The <see cref="T:System.Decimal" /> object contains invalid or corrupted data.</exception>
		// Token: 0x06000FB6 RID: 4022 RVA: 0x000416E9 File Offset: 0x0003F8E9
		void IDeserializationCallback.OnDeserialization(object sender)
		{
			if (!decimal.IsValid(this.flags))
			{
				throw new SerializationException("Value was either too large or too small for a Decimal.");
			}
		}

		// Token: 0x06000FB7 RID: 4023 RVA: 0x00041703 File Offset: 0x0003F903
		private Decimal(int lo, int mid, int hi, int flags)
		{
			if (decimal.IsValid(flags))
			{
				this.lo = lo;
				this.mid = mid;
				this.hi = hi;
				this.flags = flags;
				return;
			}
			throw new ArgumentException("Decimal byte array constructor requires an array of length four containing valid decimal bytes.");
		}

		// Token: 0x06000FB8 RID: 4024 RVA: 0x00041736 File Offset: 0x0003F936
		private Decimal(in decimal d, int flags)
		{
			this = d;
			this.flags = flags;
		}

		// Token: 0x06000FB9 RID: 4025 RVA: 0x0004174B File Offset: 0x0003F94B
		internal static decimal Abs(ref decimal d)
		{
			return new decimal(ref d, d.flags & int.MaxValue);
		}

		/// <summary>Adds two specified <see cref="T:System.Decimal" /> values.</summary>
		/// <param name="d1">The first value to add. </param>
		/// <param name="d2">The second value to add. </param>
		/// <returns>The sum of <paramref name="d1" /> and <paramref name="d2" />.</returns>
		/// <exception cref="T:System.OverflowException">The sum of <paramref name="d1" /> and <paramref name="d2" /> is less than <see cref="F:System.Decimal.MinValue" /> or greater than <see cref="F:System.Decimal.MaxValue" />. </exception>
		// Token: 0x06000FBA RID: 4026 RVA: 0x0004175F File Offset: 0x0003F95F
		public static decimal Add(decimal d1, decimal d2)
		{
			decimal.DecCalc.DecAddSub(decimal.AsMutable(ref d1), decimal.AsMutable(ref d2), false);
			return d1;
		}

		/// <summary>Compares two specified <see cref="T:System.Decimal" /> values.</summary>
		/// <param name="d1">The first value to compare. </param>
		/// <param name="d2">The second value to compare. </param>
		/// <returns>A signed number indicating the relative values of <paramref name="d1" /> and <paramref name="d2" />.Return value Meaning Less than zero 
		///             <paramref name="d1" /> is less than <paramref name="d2" />. Zero 
		///             <paramref name="d1" /> and <paramref name="d2" /> are equal. Greater than zero 
		///             <paramref name="d1" /> is greater than <paramref name="d2" />. </returns>
		// Token: 0x06000FBB RID: 4027 RVA: 0x00041776 File Offset: 0x0003F976
		public static int Compare(decimal d1, decimal d2)
		{
			return decimal.DecCalc.VarDecCmp(d1, d2);
		}

		/// <summary>Compares this instance to a specified object and returns a comparison of their relative values.</summary>
		/// <param name="value">The object to compare with this instance, or <see langword="null" />. </param>
		/// <returns>A signed number indicating the relative values of this instance and <paramref name="value" />.Return value Meaning Less than zero This instance is less than <paramref name="value" />. Zero This instance is equal to <paramref name="value" />. Greater than zero This instance is greater than <paramref name="value" />.-or- 
		///             <paramref name="value" /> is <see langword="null" />. </returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="value" /> is not a <see cref="T:System.Decimal" />. </exception>
		// Token: 0x06000FBC RID: 4028 RVA: 0x00041784 File Offset: 0x0003F984
		public int CompareTo(object value)
		{
			if (value == null)
			{
				return 1;
			}
			if (!(value is decimal))
			{
				throw new ArgumentException("Object must be of type Decimal.");
			}
			decimal num = (decimal)value;
			return decimal.DecCalc.VarDecCmp(this, num);
		}

		/// <summary>Compares this instance to a specified <see cref="T:System.Decimal" /> object and returns a comparison of their relative values.</summary>
		/// <param name="value">The object to compare with this instance.</param>
		/// <returns>A signed number indicating the relative values of this instance and <paramref name="value" />.Return value Meaning Less than zero This instance is less than <paramref name="value" />. Zero This instance is equal to <paramref name="value" />. Greater than zero This instance is greater than <paramref name="value" />. </returns>
		// Token: 0x06000FBD RID: 4029 RVA: 0x000417B8 File Offset: 0x0003F9B8
		public int CompareTo(decimal value)
		{
			return decimal.DecCalc.VarDecCmp(this, value);
		}

		/// <summary>Divides two specified <see cref="T:System.Decimal" /> values.</summary>
		/// <param name="d1">The dividend. </param>
		/// <param name="d2">The divisor. </param>
		/// <returns>The result of dividing <paramref name="d1" /> by <paramref name="d2" />.</returns>
		/// <exception cref="T:System.DivideByZeroException">
		///         <paramref name="d2" /> is zero. </exception>
		/// <exception cref="T:System.OverflowException">The return value (that is, the quotient) is less than <see cref="F:System.Decimal.MinValue" /> or greater than <see cref="F:System.Decimal.MaxValue" />. </exception>
		// Token: 0x06000FBE RID: 4030 RVA: 0x000417C2 File Offset: 0x0003F9C2
		public static decimal Divide(decimal d1, decimal d2)
		{
			decimal.DecCalc.VarDecDiv(decimal.AsMutable(ref d1), decimal.AsMutable(ref d2));
			return d1;
		}

		/// <summary>Returns a value indicating whether this instance and a specified <see cref="T:System.Object" /> represent the same type and value.</summary>
		/// <param name="value">The object to compare with this instance. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="value" /> is a <see cref="T:System.Decimal" /> and equal to this instance; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000FBF RID: 4031 RVA: 0x000417D8 File Offset: 0x0003F9D8
		public override bool Equals(object value)
		{
			if (value is decimal)
			{
				decimal num = (decimal)value;
				return decimal.DecCalc.VarDecCmp(this, num) == 0;
			}
			return false;
		}

		/// <summary>Returns a value indicating whether this instance and a specified <see cref="T:System.Decimal" /> object represent the same value.</summary>
		/// <param name="value">An object to compare to this instance.</param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="value" /> is equal to this instance; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000FC0 RID: 4032 RVA: 0x00041801 File Offset: 0x0003FA01
		public bool Equals(decimal value)
		{
			return decimal.DecCalc.VarDecCmp(this, value) == 0;
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		// Token: 0x06000FC1 RID: 4033 RVA: 0x0004180E File Offset: 0x0003FA0E
		public override int GetHashCode()
		{
			return decimal.DecCalc.GetHashCode(this);
		}

		/// <summary>Converts the numeric value of this instance to its equivalent string representation.</summary>
		/// <returns>A string that represents the value of this instance.</returns>
		// Token: 0x06000FC2 RID: 4034 RVA: 0x00041816 File Offset: 0x0003FA16
		public override string ToString()
		{
			return Number.FormatDecimal(this, null, NumberFormatInfo.CurrentInfo);
		}

		/// <summary>Converts the numeric value of this instance to its equivalent string representation using the specified culture-specific format information.</summary>
		/// <param name="provider">An object that supplies culture-specific formatting information. </param>
		/// <returns>The string representation of the value of this instance as specified by <paramref name="provider" />.</returns>
		// Token: 0x06000FC3 RID: 4035 RVA: 0x0004182E File Offset: 0x0003FA2E
		public string ToString(IFormatProvider provider)
		{
			return Number.FormatDecimal(this, null, NumberFormatInfo.GetInstance(provider));
		}

		/// <summary>Converts the numeric value of this instance to its equivalent string representation using the specified format and culture-specific format information.</summary>
		/// <param name="format">A numeric format string (see Remarks).</param>
		/// <param name="provider">An object that supplies culture-specific formatting information. </param>
		/// <returns>The string representation of the value of this instance as specified by <paramref name="format" /> and <paramref name="provider" />.</returns>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="format" /> is invalid. </exception>
		// Token: 0x06000FC4 RID: 4036 RVA: 0x00041847 File Offset: 0x0003FA47
		public string ToString(string format, IFormatProvider provider)
		{
			return Number.FormatDecimal(this, format, NumberFormatInfo.GetInstance(provider));
		}

		// Token: 0x06000FC5 RID: 4037 RVA: 0x00041860 File Offset: 0x0003FA60
		public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = default(ReadOnlySpan<char>), IFormatProvider provider = null)
		{
			return Number.TryFormatDecimal(this, format, NumberFormatInfo.GetInstance(provider), destination, out charsWritten);
		}

		/// <summary>Converts the string representation of a number to its <see cref="T:System.Decimal" /> equivalent using the specified culture-specific format information.</summary>
		/// <param name="s">The string representation of the number to convert. </param>
		/// <param name="provider">An <see cref="T:System.IFormatProvider" /> that supplies culture-specific parsing information about <paramref name="s" />. </param>
		/// <returns>The <see cref="T:System.Decimal" /> number equivalent to the number contained in <paramref name="s" /> as specified by <paramref name="provider" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="s" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="s" /> is not of the correct format </exception>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="s" /> represents a number less than <see cref="F:System.Decimal.MinValue" /> or greater than <see cref="F:System.Decimal.MaxValue" /></exception>
		// Token: 0x06000FC6 RID: 4038 RVA: 0x00041877 File Offset: 0x0003FA77
		public static decimal Parse(string s, IFormatProvider provider)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return Number.ParseDecimal(s, NumberStyles.Number, NumberFormatInfo.GetInstance(provider));
		}

		/// <summary>Converts the string representation of a number to its <see cref="T:System.Decimal" /> equivalent using the specified style and culture-specific format.</summary>
		/// <param name="s">The string representation of the number to convert. </param>
		/// <param name="style">A bitwise combination of <see cref="T:System.Globalization.NumberStyles" /> values that indicates the style elements that can be present in <paramref name="s" />. A typical value to specify is <see cref="F:System.Globalization.NumberStyles.Number" />.</param>
		/// <param name="provider">An <see cref="T:System.IFormatProvider" /> object that supplies culture-specific information about the format of <paramref name="s" />. </param>
		/// <returns>The <see cref="T:System.Decimal" /> number equivalent to the number contained in <paramref name="s" /> as specified by <paramref name="style" /> and <paramref name="provider" />.</returns>
		/// <exception cref="T:System.FormatException">
		///         <paramref name="s" /> is not in the correct format. </exception>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="s" /> represents a number less than <see cref="F:System.Decimal.MinValue" /> or greater than <see cref="F:System.Decimal.MaxValue" />. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="s" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="style" /> is not a <see cref="T:System.Globalization.NumberStyles" /> value. -or-
		///         <paramref name="style" /> is the <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" /> value.</exception>
		// Token: 0x06000FC7 RID: 4039 RVA: 0x00041896 File Offset: 0x0003FA96
		public static decimal Parse(string s, NumberStyles style, IFormatProvider provider)
		{
			NumberFormatInfo.ValidateParseStyleFloatingPoint(style);
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return Number.ParseDecimal(s, style, NumberFormatInfo.GetInstance(provider));
		}

		/// <summary>Converts the string representation of a number to its <see cref="T:System.Decimal" /> equivalent using the specified style and culture-specific format. A return value indicates whether the conversion succeeded or failed.</summary>
		/// <param name="s">The string representation of the number to convert.</param>
		/// <param name="style">A bitwise combination of enumeration values that indicates the permitted format of <paramref name="s" />. A typical value to specify is <see cref="F:System.Globalization.NumberStyles.Number" />.</param>
		/// <param name="provider">An object that supplies culture-specific parsing information about <paramref name="s" />. </param>
		/// <param name="result">When this method returns, contains the <see cref="T:System.Decimal" /> number that is equivalent to the numeric value contained in <paramref name="s" />, if the conversion succeeded, or is zero if the conversion failed. The conversion fails if the <paramref name="s" /> parameter is <see langword="null" /> or <see cref="F:System.String.Empty" />, is not in a format compliant with <paramref name="style" />, or represents a number less than <see cref="F:System.Decimal.MinValue" /> or greater than <see cref="F:System.Decimal.MaxValue" />. This parameter is passed uninitialized; any value originally supplied in <paramref name="result" /> will be overwritten.  </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="s" /> was converted successfully; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="style" /> is not a <see cref="T:System.Globalization.NumberStyles" /> value. -or-
		///         <paramref name="style" /> is the <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" /> value.</exception>
		// Token: 0x06000FC8 RID: 4040 RVA: 0x000418BA File Offset: 0x0003FABA
		public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out decimal result)
		{
			NumberFormatInfo.ValidateParseStyleFloatingPoint(style);
			if (s == null)
			{
				result = 0m;
				return false;
			}
			return Number.TryParseDecimal(s, style, NumberFormatInfo.GetInstance(provider), out result);
		}

		/// <summary>Converts the value of a specified instance of <see cref="T:System.Decimal" /> to its equivalent binary representation.</summary>
		/// <param name="d">The value to convert. </param>
		/// <returns>A 32-bit signed integer array with four elements that contain the binary representation of <paramref name="d" />.</returns>
		// Token: 0x06000FC9 RID: 4041 RVA: 0x000418E1 File Offset: 0x0003FAE1
		public static int[] GetBits(decimal d)
		{
			return new int[]
			{
				d.lo,
				d.mid,
				d.hi,
				d.flags
			};
		}

		// Token: 0x06000FCA RID: 4042 RVA: 0x0004190D File Offset: 0x0003FB0D
		internal static ref readonly decimal Max(ref decimal d1, ref decimal d2)
		{
			if (decimal.DecCalc.VarDecCmp(d1, d2) < 0)
			{
				return ref d2;
			}
			return ref d1;
		}

		// Token: 0x06000FCB RID: 4043 RVA: 0x0004191C File Offset: 0x0003FB1C
		internal static ref readonly decimal Min(ref decimal d1, ref decimal d2)
		{
			if (decimal.DecCalc.VarDecCmp(d1, d2) >= 0)
			{
				return ref d2;
			}
			return ref d1;
		}

		/// <summary>Multiplies two specified <see cref="T:System.Decimal" /> values.</summary>
		/// <param name="d1">The multiplicand. </param>
		/// <param name="d2">The multiplier. </param>
		/// <returns>The result of multiplying <paramref name="d1" /> and <paramref name="d2" />.</returns>
		/// <exception cref="T:System.OverflowException">The return value is less than <see cref="F:System.Decimal.MinValue" /> or greater than <see cref="F:System.Decimal.MaxValue" />. </exception>
		// Token: 0x06000FCC RID: 4044 RVA: 0x0004192B File Offset: 0x0003FB2B
		public static decimal Multiply(decimal d1, decimal d2)
		{
			decimal.DecCalc.VarDecMul(decimal.AsMutable(ref d1), decimal.AsMutable(ref d2));
			return d1;
		}

		/// <summary>Returns the result of multiplying the specified <see cref="T:System.Decimal" /> value by negative one.</summary>
		/// <param name="d">The value to negate. </param>
		/// <returns>A decimal number with the value of <paramref name="d" />, but the opposite sign.-or- Zero, if <paramref name="d" /> is zero.</returns>
		// Token: 0x06000FCD RID: 4045 RVA: 0x00041941 File Offset: 0x0003FB41
		public static decimal Negate(decimal d)
		{
			return new decimal(ref d, d.flags ^ int.MinValue);
		}

		/// <summary>Rounds a <see cref="T:System.Decimal" /> value to a specified number of decimal places.</summary>
		/// <param name="d">A decimal number to round. </param>
		/// <param name="decimals">A value from 0 to 28 that specifies the number of decimal places to round to. </param>
		/// <returns>The decimal number equivalent to <paramref name="d" /> rounded to <paramref name="decimals" /> number of decimal places.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="decimals" /> is not a value from 0 to 28. </exception>
		// Token: 0x06000FCE RID: 4046 RVA: 0x00041956 File Offset: 0x0003FB56
		public static decimal Round(decimal d, int decimals)
		{
			return decimal.Round(ref d, decimals, MidpointRounding.ToEven);
		}

		// Token: 0x06000FCF RID: 4047 RVA: 0x00041964 File Offset: 0x0003FB64
		private static decimal Round(ref decimal d, int decimals, MidpointRounding mode)
		{
			if (decimals > 28)
			{
				throw new ArgumentOutOfRangeException("decimals", "Decimal can only round to between 0 and 28 digits of precision.");
			}
			if (mode > MidpointRounding.AwayFromZero)
			{
				throw new ArgumentException(SR.Format("The value '{0}' is not valid for this usage of the type {1}.", mode, "MidpointRounding"), "mode");
			}
			int num = d.Scale - decimals;
			if (num > 0)
			{
				decimal.DecCalc.InternalRound(decimal.AsMutable(ref d), (uint)num, (decimal.DecCalc.RoundingMode)mode);
			}
			return d;
		}

		// Token: 0x06000FD0 RID: 4048 RVA: 0x000419CA File Offset: 0x0003FBCA
		internal static int Sign(ref decimal d)
		{
			if ((d.lo | d.mid | d.hi) != 0)
			{
				return d.flags >> 31 | 1;
			}
			return 0;
		}

		/// <summary>Converts the value of the specified <see cref="T:System.Decimal" /> to the equivalent 8-bit unsigned integer.</summary>
		/// <param name="value">The decimal number to convert. </param>
		/// <returns>An 8-bit unsigned integer equivalent to <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is less than <see cref="F:System.Byte.MinValue" /> or greater than <see cref="F:System.Byte.MaxValue" />. </exception>
		// Token: 0x06000FD1 RID: 4049 RVA: 0x000419F0 File Offset: 0x0003FBF0
		public static byte ToByte(decimal value)
		{
			uint num;
			try
			{
				num = decimal.ToUInt32(value);
			}
			catch (OverflowException innerException)
			{
				throw new OverflowException("Value was either too large or too small for an unsigned byte.", innerException);
			}
			if (num != (uint)((byte)num))
			{
				throw new OverflowException("Value was either too large or too small for an unsigned byte.");
			}
			return (byte)num;
		}

		/// <summary>Converts the value of the specified <see cref="T:System.Decimal" /> to the equivalent 8-bit signed integer.</summary>
		/// <param name="value">The decimal number to convert. </param>
		/// <returns>An 8-bit signed integer equivalent to <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is less than <see cref="F:System.SByte.MinValue" /> or greater than <see cref="F:System.SByte.MaxValue" />. </exception>
		// Token: 0x06000FD2 RID: 4050 RVA: 0x00041A38 File Offset: 0x0003FC38
		[CLSCompliant(false)]
		public static sbyte ToSByte(decimal value)
		{
			int num;
			try
			{
				num = decimal.ToInt32(value);
			}
			catch (OverflowException innerException)
			{
				throw new OverflowException("Value was either too large or too small for a signed byte.", innerException);
			}
			if (num != (int)((sbyte)num))
			{
				throw new OverflowException("Value was either too large or too small for a signed byte.");
			}
			return (sbyte)num;
		}

		/// <summary>Converts the value of the specified <see cref="T:System.Decimal" /> to the equivalent 16-bit signed integer.</summary>
		/// <param name="value">The decimal number to convert. </param>
		/// <returns>A 16-bit signed integer equivalent to <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is less than <see cref="F:System.Int16.MinValue" /> or greater than <see cref="F:System.Int16.MaxValue" />. </exception>
		// Token: 0x06000FD3 RID: 4051 RVA: 0x00041A80 File Offset: 0x0003FC80
		public static short ToInt16(decimal value)
		{
			int num;
			try
			{
				num = decimal.ToInt32(value);
			}
			catch (OverflowException innerException)
			{
				throw new OverflowException("Value was either too large or too small for an Int16.", innerException);
			}
			if (num != (int)((short)num))
			{
				throw new OverflowException("Value was either too large or too small for an Int16.");
			}
			return (short)num;
		}

		/// <summary>Converts the value of the specified <see cref="T:System.Decimal" /> to the equivalent double-precision floating-point number.</summary>
		/// <param name="d">The decimal number to convert. </param>
		/// <returns>A double-precision floating-point number equivalent to <paramref name="d" />.</returns>
		// Token: 0x06000FD4 RID: 4052 RVA: 0x00041AC8 File Offset: 0x0003FCC8
		public static double ToDouble(decimal d)
		{
			return decimal.DecCalc.VarR8FromDec(d);
		}

		/// <summary>Converts the value of the specified <see cref="T:System.Decimal" /> to the equivalent 32-bit signed integer.</summary>
		/// <param name="d">The decimal number to convert. </param>
		/// <returns>A 32-bit signed integer equivalent to the value of <paramref name="d" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="d" /> is less than <see cref="F:System.Int32.MinValue" /> or greater than <see cref="F:System.Int32.MaxValue" />. </exception>
		// Token: 0x06000FD5 RID: 4053 RVA: 0x00041AD4 File Offset: 0x0003FCD4
		public static int ToInt32(decimal d)
		{
			decimal.Truncate(ref d);
			if ((d.hi | d.mid) == 0)
			{
				int num = d.lo;
				if (!d.IsNegative)
				{
					if (num >= 0)
					{
						return num;
					}
				}
				else
				{
					num = -num;
					if (num <= 0)
					{
						return num;
					}
				}
			}
			throw new OverflowException("Value was either too large or too small for an Int32.");
		}

		/// <summary>Converts the value of the specified <see cref="T:System.Decimal" /> to the equivalent 64-bit signed integer.</summary>
		/// <param name="d">The decimal number to convert. </param>
		/// <returns>A 64-bit signed integer equivalent to the value of <paramref name="d" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="d" /> is less than <see cref="F:System.Int64.MinValue" /> or greater than <see cref="F:System.Int64.MaxValue" />. </exception>
		// Token: 0x06000FD6 RID: 4054 RVA: 0x00041B20 File Offset: 0x0003FD20
		public static long ToInt64(decimal d)
		{
			decimal.Truncate(ref d);
			if (d.hi == 0)
			{
				long num = (long)d.Low64;
				if (!d.IsNegative)
				{
					if (num >= 0L)
					{
						return num;
					}
				}
				else
				{
					num = -num;
					if (num <= 0L)
					{
						return num;
					}
				}
			}
			throw new OverflowException("Value was either too large or too small for an Int64.");
		}

		/// <summary>Converts the value of the specified <see cref="T:System.Decimal" /> to the equivalent 16-bit unsigned integer.</summary>
		/// <param name="value">The decimal number to convert. </param>
		/// <returns>A 16-bit unsigned integer equivalent to the value of <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is greater than <see cref="F:System.UInt16.MaxValue" /> or less than <see cref="F:System.UInt16.MinValue" />. </exception>
		// Token: 0x06000FD7 RID: 4055 RVA: 0x00041B68 File Offset: 0x0003FD68
		[CLSCompliant(false)]
		public static ushort ToUInt16(decimal value)
		{
			uint num;
			try
			{
				num = decimal.ToUInt32(value);
			}
			catch (OverflowException innerException)
			{
				throw new OverflowException("Value was either too large or too small for a UInt16.", innerException);
			}
			if (num != (uint)((ushort)num))
			{
				throw new OverflowException("Value was either too large or too small for a UInt16.");
			}
			return (ushort)num;
		}

		/// <summary>Converts the value of the specified <see cref="T:System.Decimal" /> to the equivalent 32-bit unsigned integer.</summary>
		/// <param name="d">The decimal number to convert. </param>
		/// <returns>A 32-bit unsigned integer equivalent to the value of <paramref name="d" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="d" /> is negative or greater than <see cref="F:System.UInt32.MaxValue" />. </exception>
		// Token: 0x06000FD8 RID: 4056 RVA: 0x00041BB0 File Offset: 0x0003FDB0
		[CLSCompliant(false)]
		public static uint ToUInt32(decimal d)
		{
			decimal.Truncate(ref d);
			if ((d.hi | d.mid) == 0)
			{
				uint low = d.Low;
				if (!d.IsNegative || low == 0U)
				{
					return low;
				}
			}
			throw new OverflowException("Value was either too large or too small for a UInt32.");
		}

		/// <summary>Converts the value of the specified <see cref="T:System.Decimal" /> to the equivalent 64-bit unsigned integer.</summary>
		/// <param name="d">The decimal number to convert. </param>
		/// <returns>A 64-bit unsigned integer equivalent to the value of <paramref name="d" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="d" /> is negative or greater than <see cref="F:System.UInt64.MaxValue" />. </exception>
		// Token: 0x06000FD9 RID: 4057 RVA: 0x00041BF4 File Offset: 0x0003FDF4
		[CLSCompliant(false)]
		public static ulong ToUInt64(decimal d)
		{
			decimal.Truncate(ref d);
			if (d.hi == 0)
			{
				ulong low = d.Low64;
				if (!d.IsNegative || low == 0UL)
				{
					return low;
				}
			}
			throw new OverflowException("Value was either too large or too small for a UInt64.");
		}

		/// <summary>Converts the value of the specified <see cref="T:System.Decimal" /> to the equivalent single-precision floating-point number.</summary>
		/// <param name="d">The decimal number to convert. </param>
		/// <returns>A single-precision floating-point number equivalent to the value of <paramref name="d" />.</returns>
		// Token: 0x06000FDA RID: 4058 RVA: 0x00041C30 File Offset: 0x0003FE30
		public static float ToSingle(decimal d)
		{
			return decimal.DecCalc.VarR4FromDec(d);
		}

		/// <summary>Returns the integral digits of the specified <see cref="T:System.Decimal" />; any fractional digits are discarded.</summary>
		/// <param name="d">The decimal number to truncate. </param>
		/// <returns>The result of <paramref name="d" /> rounded toward zero, to the nearest whole number.</returns>
		// Token: 0x06000FDB RID: 4059 RVA: 0x00041C39 File Offset: 0x0003FE39
		public static decimal Truncate(decimal d)
		{
			decimal.Truncate(ref d);
			return d;
		}

		// Token: 0x06000FDC RID: 4060 RVA: 0x00041C44 File Offset: 0x0003FE44
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void Truncate(ref decimal d)
		{
			int num = d.flags;
			if ((num & 16711680) != 0)
			{
				decimal.DecCalc.InternalRound(decimal.AsMutable(ref d), (uint)((byte)(num >> 16)), decimal.DecCalc.RoundingMode.Truncate);
			}
		}

		/// <summary>Defines an implicit conversion of an 8-bit unsigned integer to a <see cref="T:System.Decimal" />.</summary>
		/// <param name="value">The 8-bit unsigned integer to convert. </param>
		/// <returns>The converted 8-bit unsigned integer.</returns>
		// Token: 0x06000FDD RID: 4061 RVA: 0x00041C72 File Offset: 0x0003FE72
		public static implicit operator decimal(byte value)
		{
			return new decimal((uint)value);
		}

		/// <summary>Defines an implicit conversion of an 8-bit signed integer to a <see cref="T:System.Decimal" />.</summary>
		/// <param name="value">The 8-bit signed integer to convert. </param>
		/// <returns>The converted 8-bit signed integer.</returns>
		// Token: 0x06000FDE RID: 4062 RVA: 0x00041C7A File Offset: 0x0003FE7A
		[CLSCompliant(false)]
		public static implicit operator decimal(sbyte value)
		{
			return new decimal((int)value);
		}

		/// <summary>Defines an implicit conversion of a 16-bit signed integer to a <see cref="T:System.Decimal" />.</summary>
		/// <param name="value">The16-bit signed integer to convert. </param>
		/// <returns>The converted 16-bit signed integer.</returns>
		// Token: 0x06000FDF RID: 4063 RVA: 0x00041C7A File Offset: 0x0003FE7A
		public static implicit operator decimal(short value)
		{
			return new decimal((int)value);
		}

		/// <summary>Defines an implicit conversion of a 16-bit unsigned integer to a <see cref="T:System.Decimal" />.</summary>
		/// <param name="value">The 16-bit unsigned integer to convert. </param>
		/// <returns>The converted 16-bit unsigned integer.</returns>
		// Token: 0x06000FE0 RID: 4064 RVA: 0x00041C72 File Offset: 0x0003FE72
		[CLSCompliant(false)]
		public static implicit operator decimal(ushort value)
		{
			return new decimal((uint)value);
		}

		/// <summary>Defines an implicit conversion of a Unicode character to a <see cref="T:System.Decimal" />.</summary>
		/// <param name="value">The Unicode character to convert. </param>
		/// <returns>The converted Unicode character.</returns>
		// Token: 0x06000FE1 RID: 4065 RVA: 0x00041C72 File Offset: 0x0003FE72
		public static implicit operator decimal(char value)
		{
			return new decimal((uint)value);
		}

		/// <summary>Defines an implicit conversion of a 32-bit signed integer to a <see cref="T:System.Decimal" />.</summary>
		/// <param name="value">The 32-bit signed integer to convert. </param>
		/// <returns>The converted 32-bit signed integer.</returns>
		// Token: 0x06000FE2 RID: 4066 RVA: 0x00041C7A File Offset: 0x0003FE7A
		public static implicit operator decimal(int value)
		{
			return new decimal(value);
		}

		/// <summary>Defines an implicit conversion of a 32-bit unsigned integer to a <see cref="T:System.Decimal" />.</summary>
		/// <param name="value">The 32-bit unsigned integer to convert. </param>
		/// <returns>The converted 32-bit unsigned integer.</returns>
		// Token: 0x06000FE3 RID: 4067 RVA: 0x00041C72 File Offset: 0x0003FE72
		[CLSCompliant(false)]
		public static implicit operator decimal(uint value)
		{
			return new decimal(value);
		}

		/// <summary>Defines an implicit conversion of a 64-bit signed integer to a <see cref="T:System.Decimal" />.</summary>
		/// <param name="value">The 64-bit signed integer to convert. </param>
		/// <returns>The converted 64-bit signed integer.</returns>
		// Token: 0x06000FE4 RID: 4068 RVA: 0x00041C82 File Offset: 0x0003FE82
		public static implicit operator decimal(long value)
		{
			return new decimal(value);
		}

		/// <summary>Defines an implicit conversion of a 64-bit unsigned integer to a <see cref="T:System.Decimal" />.</summary>
		/// <param name="value">The 64-bit unsigned integer to convert. </param>
		/// <returns>The converted 64-bit unsigned integer.</returns>
		// Token: 0x06000FE5 RID: 4069 RVA: 0x00041C8A File Offset: 0x0003FE8A
		[CLSCompliant(false)]
		public static implicit operator decimal(ulong value)
		{
			return new decimal(value);
		}

		/// <summary>Defines an explicit conversion of a single-precision floating-point number to a <see cref="T:System.Decimal" />.</summary>
		/// <param name="value">The single-precision floating-point number to convert. </param>
		/// <returns>The converted single-precision floating point number.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is less than <see cref="F:System.Decimal.MinValue" /> or greater than <see cref="F:System.Decimal.MaxValue" />.-or- 
		///         <paramref name="value" /> is <see cref="F:System.Single.NaN" />, <see cref="F:System.Single.PositiveInfinity" />, or <see cref="F:System.Single.NegativeInfinity" />. </exception>
		// Token: 0x06000FE6 RID: 4070 RVA: 0x00041C92 File Offset: 0x0003FE92
		public static explicit operator decimal(float value)
		{
			return new decimal(value);
		}

		/// <summary>Defines an explicit conversion of a double-precision floating-point number to a <see cref="T:System.Decimal" />.</summary>
		/// <param name="value">The double-precision floating-point number to convert. </param>
		/// <returns>The converted double-precision floating point number.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is less than <see cref="F:System.Decimal.MinValue" /> or greater than <see cref="F:System.Decimal.MaxValue" />.-or- 
		///         <paramref name="value" /> is <see cref="F:System.Double.NaN" />, <see cref="F:System.Double.PositiveInfinity" />, or <see cref="F:System.Double.NegativeInfinity" />. </exception>
		// Token: 0x06000FE7 RID: 4071 RVA: 0x00041C9A File Offset: 0x0003FE9A
		public static explicit operator decimal(double value)
		{
			return new decimal(value);
		}

		/// <summary>Defines an explicit conversion of a <see cref="T:System.Decimal" /> to a 32-bit signed integer.</summary>
		/// <param name="value">The value to convert. </param>
		/// <returns>A 32-bit signed integer that represents the converted <see cref="T:System.Decimal" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is less than <see cref="F:System.Int32.MinValue" /> or greater than <see cref="F:System.Int32.MaxValue" />. </exception>
		// Token: 0x06000FE8 RID: 4072 RVA: 0x00041CA2 File Offset: 0x0003FEA2
		public static explicit operator int(decimal value)
		{
			return decimal.ToInt32(value);
		}

		/// <summary>Defines an explicit conversion of a <see cref="T:System.Decimal" /> to a 64-bit signed integer.</summary>
		/// <param name="value">The value to convert. </param>
		/// <returns>A 64-bit signed integer that represents the converted <see cref="T:System.Decimal" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is less than <see cref="F:System.Int64.MinValue" /> or greater than <see cref="F:System.Int64.MaxValue" />. </exception>
		// Token: 0x06000FE9 RID: 4073 RVA: 0x00041CAA File Offset: 0x0003FEAA
		public static explicit operator long(decimal value)
		{
			return decimal.ToInt64(value);
		}

		/// <summary>Defines an explicit conversion of a <see cref="T:System.Decimal" /> to a 64-bit unsigned integer.</summary>
		/// <param name="value">The value to convert. </param>
		/// <returns>A 64-bit unsigned integer that represents the converted <see cref="T:System.Decimal" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> is negative or greater than <see cref="F:System.UInt64.MaxValue" />. </exception>
		// Token: 0x06000FEA RID: 4074 RVA: 0x00041CB2 File Offset: 0x0003FEB2
		[CLSCompliant(false)]
		public static explicit operator ulong(decimal value)
		{
			return decimal.ToUInt64(value);
		}

		/// <summary>Defines an explicit conversion of a <see cref="T:System.Decimal" /> to a single-precision floating-point number.</summary>
		/// <param name="value">The value to convert. </param>
		/// <returns>A single-precision floating-point number that represents the converted <see cref="T:System.Decimal" />.</returns>
		// Token: 0x06000FEB RID: 4075 RVA: 0x00041CBA File Offset: 0x0003FEBA
		public static explicit operator float(decimal value)
		{
			return decimal.ToSingle(value);
		}

		/// <summary>Defines an explicit conversion of a <see cref="T:System.Decimal" /> to a double-precision floating-point number.</summary>
		/// <param name="value">The value to convert. </param>
		/// <returns>A double-precision floating-point number that represents the converted <see cref="T:System.Decimal" />.</returns>
		// Token: 0x06000FEC RID: 4076 RVA: 0x00041CC2 File Offset: 0x0003FEC2
		public static explicit operator double(decimal value)
		{
			return decimal.ToDouble(value);
		}

		/// <summary>Negates the value of the specified <see cref="T:System.Decimal" /> operand.</summary>
		/// <param name="d">The value to negate. </param>
		/// <returns>The result of <paramref name="d" /> multiplied by negative one (-1).</returns>
		// Token: 0x06000FED RID: 4077 RVA: 0x00041941 File Offset: 0x0003FB41
		public static decimal operator -(decimal d)
		{
			return new decimal(ref d, d.flags ^ int.MinValue);
		}

		/// <summary>Increments the <see cref="T:System.Decimal" /> operand by 1.</summary>
		/// <param name="d">The value to increment. </param>
		/// <returns>The value of <paramref name="d" /> incremented by 1.</returns>
		/// <exception cref="T:System.OverflowException">The return value is less than <see cref="F:System.Decimal.MinValue" /> or greater than <see cref="F:System.Decimal.MaxValue" />. </exception>
		// Token: 0x06000FEE RID: 4078 RVA: 0x00041CCA File Offset: 0x0003FECA
		public static decimal operator ++(decimal d)
		{
			return decimal.Add(d, 1m);
		}

		/// <summary>Adds two specified <see cref="T:System.Decimal" /> values.</summary>
		/// <param name="d1">The first value to add. </param>
		/// <param name="d2">The second value to add. </param>
		/// <returns>The result of adding <paramref name="d1" /> and <paramref name="d2" />.</returns>
		/// <exception cref="T:System.OverflowException">The return value is less than <see cref="F:System.Decimal.MinValue" /> or greater than <see cref="F:System.Decimal.MaxValue" />. </exception>
		// Token: 0x06000FEF RID: 4079 RVA: 0x0004175F File Offset: 0x0003F95F
		public static decimal operator +(decimal d1, decimal d2)
		{
			decimal.DecCalc.DecAddSub(decimal.AsMutable(ref d1), decimal.AsMutable(ref d2), false);
			return d1;
		}

		/// <summary>Subtracts two specified <see cref="T:System.Decimal" /> values.</summary>
		/// <param name="d1">The minuend. </param>
		/// <param name="d2">The subtrahend. </param>
		/// <returns>The result of subtracting <paramref name="d2" /> from <paramref name="d1" />.</returns>
		/// <exception cref="T:System.OverflowException">The return value is less than <see cref="F:System.Decimal.MinValue" /> or greater than <see cref="F:System.Decimal.MaxValue" />. </exception>
		// Token: 0x06000FF0 RID: 4080 RVA: 0x00041CD7 File Offset: 0x0003FED7
		public static decimal operator -(decimal d1, decimal d2)
		{
			decimal.DecCalc.DecAddSub(decimal.AsMutable(ref d1), decimal.AsMutable(ref d2), true);
			return d1;
		}

		/// <summary>Multiplies two specified <see cref="T:System.Decimal" /> values.</summary>
		/// <param name="d1">The first value to multiply. </param>
		/// <param name="d2">The second value to multiply. </param>
		/// <returns>The result of multiplying <paramref name="d1" /> by <paramref name="d2" />.</returns>
		/// <exception cref="T:System.OverflowException">The return value is less than <see cref="F:System.Decimal.MinValue" /> or greater than <see cref="F:System.Decimal.MaxValue" />. </exception>
		// Token: 0x06000FF1 RID: 4081 RVA: 0x0004192B File Offset: 0x0003FB2B
		public static decimal operator *(decimal d1, decimal d2)
		{
			decimal.DecCalc.VarDecMul(decimal.AsMutable(ref d1), decimal.AsMutable(ref d2));
			return d1;
		}

		/// <summary>Divides two specified <see cref="T:System.Decimal" /> values.</summary>
		/// <param name="d1">The dividend. </param>
		/// <param name="d2">The divisor. </param>
		/// <returns>The result of dividing <paramref name="d1" /> by <paramref name="d2" />.</returns>
		/// <exception cref="T:System.DivideByZeroException">
		///         <paramref name="d2" /> is zero. </exception>
		/// <exception cref="T:System.OverflowException">The return value is less than <see cref="F:System.Decimal.MinValue" /> or greater than <see cref="F:System.Decimal.MaxValue" />. </exception>
		// Token: 0x06000FF2 RID: 4082 RVA: 0x000417C2 File Offset: 0x0003F9C2
		public static decimal operator /(decimal d1, decimal d2)
		{
			decimal.DecCalc.VarDecDiv(decimal.AsMutable(ref d1), decimal.AsMutable(ref d2));
			return d1;
		}

		/// <summary>Returns a value that indicates whether two <see cref="T:System.Decimal" /> values are equal.</summary>
		/// <param name="d1">The first value to compare. </param>
		/// <param name="d2">The second value to compare. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="d1" /> and <paramref name="d2" /> are equal; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000FF3 RID: 4083 RVA: 0x00041CEE File Offset: 0x0003FEEE
		public static bool operator ==(decimal d1, decimal d2)
		{
			return decimal.DecCalc.VarDecCmp(d1, d2) == 0;
		}

		/// <summary>Returns a value that indicates whether two <see cref="T:System.Decimal" /> objects have different values.</summary>
		/// <param name="d1">The first value to compare. </param>
		/// <param name="d2">The second value to compare. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="d1" /> and <paramref name="d2" /> are not equal; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000FF4 RID: 4084 RVA: 0x00041CFC File Offset: 0x0003FEFC
		public static bool operator !=(decimal d1, decimal d2)
		{
			return decimal.DecCalc.VarDecCmp(d1, d2) != 0;
		}

		/// <summary>Returns a value indicating whether a specified <see cref="T:System.Decimal" /> is less than another specified <see cref="T:System.Decimal" />.</summary>
		/// <param name="d1">The first value to compare. </param>
		/// <param name="d2">The second value to compare. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="d1" /> is less than <paramref name="d2" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000FF5 RID: 4085 RVA: 0x00041D0A File Offset: 0x0003FF0A
		public static bool operator <(decimal d1, decimal d2)
		{
			return decimal.DecCalc.VarDecCmp(d1, d2) < 0;
		}

		/// <summary>Returns a value indicating whether a specified <see cref="T:System.Decimal" /> is less than or equal to another specified <see cref="T:System.Decimal" />.</summary>
		/// <param name="d1">The first value to compare. </param>
		/// <param name="d2">The second value to compare. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="d1" /> is less than or equal to <paramref name="d2" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000FF6 RID: 4086 RVA: 0x00041D18 File Offset: 0x0003FF18
		public static bool operator <=(decimal d1, decimal d2)
		{
			return decimal.DecCalc.VarDecCmp(d1, d2) <= 0;
		}

		/// <summary>Returns a value indicating whether a specified <see cref="T:System.Decimal" /> is greater than another specified <see cref="T:System.Decimal" />.</summary>
		/// <param name="d1">The first value to compare. </param>
		/// <param name="d2">The second value to compare. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="d1" /> is greater than <paramref name="d2" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000FF7 RID: 4087 RVA: 0x00041D29 File Offset: 0x0003FF29
		public static bool operator >(decimal d1, decimal d2)
		{
			return decimal.DecCalc.VarDecCmp(d1, d2) > 0;
		}

		/// <summary>Returns a value indicating whether a specified <see cref="T:System.Decimal" /> is greater than or equal to another specified <see cref="T:System.Decimal" />.</summary>
		/// <param name="d1">The first value to compare. </param>
		/// <param name="d2">The second value to compare. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="d1" /> is greater than or equal to <paramref name="d2" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000FF8 RID: 4088 RVA: 0x00041D37 File Offset: 0x0003FF37
		public static bool operator >=(decimal d1, decimal d2)
		{
			return decimal.DecCalc.VarDecCmp(d1, d2) >= 0;
		}

		/// <summary>Returns the <see cref="T:System.TypeCode" /> for value type <see cref="T:System.Decimal" />.</summary>
		/// <returns>The enumerated constant <see cref="F:System.TypeCode.Decimal" />.</returns>
		// Token: 0x06000FF9 RID: 4089 RVA: 0x00041D48 File Offset: 0x0003FF48
		public TypeCode GetTypeCode()
		{
			return TypeCode.Decimal;
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToBoolean(System.IFormatProvider)" />.</summary>
		/// <param name="provider">This parameter is ignored. </param>
		/// <returns>
		///     <see langword="true" /> if the value of the current instance is not zero; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000FFA RID: 4090 RVA: 0x00041D4C File Offset: 0x0003FF4C
		bool IConvertible.ToBoolean(IFormatProvider provider)
		{
			return Convert.ToBoolean(this);
		}

		/// <summary>This conversion is not supported. Attempting to use this method throws an <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>None. This conversion is not supported. </returns>
		/// <exception cref="T:System.InvalidCastException">In all cases. </exception>
		// Token: 0x06000FFB RID: 4091 RVA: 0x00041D59 File Offset: 0x0003FF59
		char IConvertible.ToChar(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format("Invalid cast from '{0}' to '{1}'.", "Decimal", "Char"));
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToSByte(System.IFormatProvider)" />.</summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>The value of the current instance, converted to a <see cref="T:System.SByte" />.</returns>
		/// <exception cref="T:System.OverflowException">The resulting integer value is less than <see cref="F:System.SByte.MinValue" /> or greater than <see cref="F:System.SByte.MaxValue" />. </exception>
		// Token: 0x06000FFC RID: 4092 RVA: 0x00041D74 File Offset: 0x0003FF74
		sbyte IConvertible.ToSByte(IFormatProvider provider)
		{
			return Convert.ToSByte(this);
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToByte(System.IFormatProvider)" />.</summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>The value of the current instance, converted to a <see cref="T:System.Byte" />.</returns>
		/// <exception cref="T:System.OverflowException">The resulting integer value is less than <see cref="F:System.Byte.MinValue" /> or greater than <see cref="F:System.Byte.MaxValue" />. </exception>
		// Token: 0x06000FFD RID: 4093 RVA: 0x00041D81 File Offset: 0x0003FF81
		byte IConvertible.ToByte(IFormatProvider provider)
		{
			return Convert.ToByte(this);
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToInt16(System.IFormatProvider)" />.</summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>The value of the current instance, converted to a <see cref="T:System.Int16" />.</returns>
		/// <exception cref="T:System.OverflowException">The resulting integer value is less than <see cref="F:System.Int16.MinValue" /> or greater than <see cref="F:System.Int16.MaxValue" />.</exception>
		// Token: 0x06000FFE RID: 4094 RVA: 0x00041D8E File Offset: 0x0003FF8E
		short IConvertible.ToInt16(IFormatProvider provider)
		{
			return Convert.ToInt16(this);
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToUInt16(System.IFormatProvider)" />.</summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>The value of the current instance, converted to a <see cref="T:System.UInt16" />.</returns>
		/// <exception cref="T:System.OverflowException">The resulting integer value is less than <see cref="F:System.UInt16.MinValue" /> or greater than <see cref="F:System.UInt16.MaxValue" />.</exception>
		// Token: 0x06000FFF RID: 4095 RVA: 0x00041D9B File Offset: 0x0003FF9B
		ushort IConvertible.ToUInt16(IFormatProvider provider)
		{
			return Convert.ToUInt16(this);
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToInt32(System.IFormatProvider)" />.</summary>
		/// <param name="provider">The parameter is ignored.</param>
		/// <returns>The value of the current instance, converted to a <see cref="T:System.Int32" />.</returns>
		/// <exception cref="T:System.OverflowException">The resulting integer value is less than <see cref="F:System.Int32.MinValue" /> or greater than <see cref="F:System.Int32.MaxValue" />.</exception>
		// Token: 0x06001000 RID: 4096 RVA: 0x00041DA8 File Offset: 0x0003FFA8
		int IConvertible.ToInt32(IFormatProvider provider)
		{
			return Convert.ToInt32(this);
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToInt32(System.IFormatProvider)" />.</summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>The value of the current instance, converted to a <see cref="T:System.UInt32" />.</returns>
		/// <exception cref="T:System.OverflowException">The resulting integer value is less than <see cref="F:System.UInt32.MinValue" /> or greater than <see cref="F:System.UInt32.MaxValue" />.</exception>
		// Token: 0x06001001 RID: 4097 RVA: 0x00041DB5 File Offset: 0x0003FFB5
		uint IConvertible.ToUInt32(IFormatProvider provider)
		{
			return Convert.ToUInt32(this);
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToInt64(System.IFormatProvider)" />.</summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>The value of the current instance, converted to a <see cref="T:System.Int64" />.</returns>
		/// <exception cref="T:System.OverflowException">The resulting integer value is less than <see cref="F:System.Int64.MinValue" /> or greater than <see cref="F:System.Int64.MaxValue" />. </exception>
		// Token: 0x06001002 RID: 4098 RVA: 0x00041DC2 File Offset: 0x0003FFC2
		long IConvertible.ToInt64(IFormatProvider provider)
		{
			return Convert.ToInt64(this);
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToInt64(System.IFormatProvider)" />.</summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>The value of the current instance, converted to a <see cref="T:System.UInt64" />.</returns>
		/// <exception cref="T:System.OverflowException">The resulting integer value is less than <see cref="F:System.UInt64.MinValue" /> or greater than <see cref="F:System.UInt64.MaxValue" />.</exception>
		// Token: 0x06001003 RID: 4099 RVA: 0x00041DCF File Offset: 0x0003FFCF
		ulong IConvertible.ToUInt64(IFormatProvider provider)
		{
			return Convert.ToUInt64(this);
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToSingle(System.IFormatProvider)" />.</summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>The value of the current instance, converted to a <see cref="T:System.Single" />.</returns>
		// Token: 0x06001004 RID: 4100 RVA: 0x00041DDC File Offset: 0x0003FFDC
		float IConvertible.ToSingle(IFormatProvider provider)
		{
			return Convert.ToSingle(this);
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToDouble(System.IFormatProvider)" />.</summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>The value of the current instance, converted to a <see cref="T:System.Double" />.</returns>
		// Token: 0x06001005 RID: 4101 RVA: 0x00041DE9 File Offset: 0x0003FFE9
		double IConvertible.ToDouble(IFormatProvider provider)
		{
			return Convert.ToDouble(this);
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToDecimal(System.IFormatProvider)" />.</summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>The value of the current instance, unchanged.</returns>
		// Token: 0x06001006 RID: 4102 RVA: 0x00041DF6 File Offset: 0x0003FFF6
		decimal IConvertible.ToDecimal(IFormatProvider provider)
		{
			return this;
		}

		/// <summary>This conversion is not supported. Attempting to use this method throws an <see cref="T:System.InvalidCastException" />.</summary>
		/// <param name="provider">This parameter is ignored.</param>
		/// <returns>None. This conversion is not supported. </returns>
		/// <exception cref="T:System.InvalidCastException">In all cases.</exception>
		// Token: 0x06001007 RID: 4103 RVA: 0x00041DFE File Offset: 0x0003FFFE
		DateTime IConvertible.ToDateTime(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format("Invalid cast from '{0}' to '{1}'.", "Decimal", "DateTime"));
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToType(System.Type,System.IFormatProvider)" />.</summary>
		/// <param name="type">The type to which to convert the value of this <see cref="T:System.Decimal" /> instance. </param>
		/// <param name="provider">An <see cref="T:System.IFormatProvider" /> implementation that supplies culture-specific information about the format of the returned value.</param>
		/// <returns>The value of the current instance, converted to a <paramref name="type" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="type" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.InvalidCastException">The requested type conversion is not supported. </exception>
		// Token: 0x06001008 RID: 4104 RVA: 0x00041E19 File Offset: 0x00040019
		object IConvertible.ToType(Type type, IFormatProvider provider)
		{
			return Convert.DefaultToType(this, type, provider);
		}

		/// <summary>Represents the number zero (0).</summary>
		// Token: 0x040005F9 RID: 1529
		public const decimal Zero = 0m;

		/// <summary>Represents the number one (1).</summary>
		// Token: 0x040005FA RID: 1530
		public const decimal One = 1m;

		/// <summary>Represents the number negative one (-1).</summary>
		// Token: 0x040005FB RID: 1531
		public const decimal MinusOne = -1m;

		/// <summary>Represents the largest possible value of <see cref="T:System.Decimal" />. This field is constant and read-only.</summary>
		// Token: 0x040005FC RID: 1532
		public const decimal MaxValue = 79228162514264337593543950335m;

		/// <summary>Represents the smallest possible value of <see cref="T:System.Decimal" />. This field is constant and read-only.</summary>
		// Token: 0x040005FD RID: 1533
		public const decimal MinValue = -79228162514264337593543950335m;

		// Token: 0x040005FE RID: 1534
		[FieldOffset(0)]
		private readonly int flags;

		// Token: 0x040005FF RID: 1535
		[FieldOffset(4)]
		private readonly int hi;

		// Token: 0x04000600 RID: 1536
		[FieldOffset(8)]
		private readonly int lo;

		// Token: 0x04000601 RID: 1537
		[FieldOffset(12)]
		private readonly int mid;

		// Token: 0x04000602 RID: 1538
		[NonSerialized]
		[FieldOffset(8)]
		private readonly ulong ulomidLE;

		// Token: 0x0200019A RID: 410
		[StructLayout(2)]
		private struct DecCalc
		{
			// Token: 0x17000176 RID: 374
			// (get) Token: 0x0600100A RID: 4106 RVA: 0x00041E7C File Offset: 0x0004007C
			// (set) Token: 0x0600100B RID: 4107 RVA: 0x00041E84 File Offset: 0x00040084
			private uint High
			{
				get
				{
					return this.uhi;
				}
				set
				{
					this.uhi = value;
				}
			}

			// Token: 0x17000177 RID: 375
			// (get) Token: 0x0600100C RID: 4108 RVA: 0x00041E8D File Offset: 0x0004008D
			// (set) Token: 0x0600100D RID: 4109 RVA: 0x00041E95 File Offset: 0x00040095
			private uint Low
			{
				get
				{
					return this.ulo;
				}
				set
				{
					this.ulo = value;
				}
			}

			// Token: 0x17000178 RID: 376
			// (get) Token: 0x0600100E RID: 4110 RVA: 0x00041E9E File Offset: 0x0004009E
			// (set) Token: 0x0600100F RID: 4111 RVA: 0x00041EA6 File Offset: 0x000400A6
			private uint Mid
			{
				get
				{
					return this.umid;
				}
				set
				{
					this.umid = value;
				}
			}

			// Token: 0x17000179 RID: 377
			// (get) Token: 0x06001010 RID: 4112 RVA: 0x00041EAF File Offset: 0x000400AF
			private bool IsNegative
			{
				get
				{
					return this.uflags < 0U;
				}
			}

			// Token: 0x1700017A RID: 378
			// (get) Token: 0x06001011 RID: 4113 RVA: 0x00041EBA File Offset: 0x000400BA
			// (set) Token: 0x06001012 RID: 4114 RVA: 0x00041EDC File Offset: 0x000400DC
			private ulong Low64
			{
				get
				{
					if (!BitConverter.IsLittleEndian)
					{
						return (ulong)this.umid << 32 | (ulong)this.ulo;
					}
					return this.ulomidLE;
				}
				set
				{
					if (BitConverter.IsLittleEndian)
					{
						this.ulomidLE = value;
						return;
					}
					this.umid = (uint)(value >> 32);
					this.ulo = (uint)value;
				}
			}

			// Token: 0x06001013 RID: 4115 RVA: 0x00041F00 File Offset: 0x00040100
			private unsafe static uint GetExponent(float f)
			{
				return (uint)((byte)(*(uint*)(&f) >> 23));
			}

			// Token: 0x06001014 RID: 4116 RVA: 0x00041F0A File Offset: 0x0004010A
			private unsafe static uint GetExponent(double d)
			{
				return (uint)((ulong)(*(long*)(&d)) >> 52) & 2047U;
			}

			// Token: 0x06001015 RID: 4117 RVA: 0x00022686 File Offset: 0x00020886
			private static ulong UInt32x32To64(uint a, uint b)
			{
				return (ulong)a * (ulong)b;
			}

			// Token: 0x06001016 RID: 4118 RVA: 0x00041F1C File Offset: 0x0004011C
			private static void UInt64x64To128(ulong a, ulong b, ref decimal.DecCalc result)
			{
				ulong num = decimal.DecCalc.UInt32x32To64((uint)a, (uint)b);
				ulong num2 = decimal.DecCalc.UInt32x32To64((uint)a, (uint)(b >> 32));
				ulong num3 = decimal.DecCalc.UInt32x32To64((uint)(a >> 32), (uint)(b >> 32));
				num3 += num2 >> 32;
				num += (num2 <<= 32);
				if (num < num2)
				{
					num3 += 1UL;
				}
				num2 = decimal.DecCalc.UInt32x32To64((uint)(a >> 32), (uint)b);
				num3 += num2 >> 32;
				num += (num2 <<= 32);
				if (num < num2)
				{
					num3 += 1UL;
				}
				if (num3 > (ulong)-1)
				{
					throw new OverflowException("Value was either too large or too small for a Decimal.");
				}
				result.Low64 = num;
				result.High = (uint)num3;
			}

			// Token: 0x06001017 RID: 4119 RVA: 0x00041FB0 File Offset: 0x000401B0
			private static uint Div96By32(ref decimal.DecCalc.Buf12 bufNum, uint den)
			{
				if (bufNum.U2 != 0U)
				{
					ulong num = bufNum.High64;
					ulong num2 = num / (ulong)den;
					bufNum.High64 = num2;
					num = (num - (ulong)((uint)num2 * den) << 32 | (ulong)bufNum.U0);
					if (num == 0UL)
					{
						return 0U;
					}
					uint num3 = (uint)(num / (ulong)den);
					bufNum.U0 = num3;
					return (uint)num - num3 * den;
				}
				else
				{
					ulong num = bufNum.Low64;
					if (num == 0UL)
					{
						return 0U;
					}
					ulong num2 = num / (ulong)den;
					bufNum.Low64 = num2;
					return (uint)(num - num2 * (ulong)den);
				}
			}

			// Token: 0x06001018 RID: 4120 RVA: 0x00042024 File Offset: 0x00040224
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			private static bool Div96ByConst(ref ulong high64, ref uint low, uint pow)
			{
				ulong num = high64 / (ulong)pow;
				uint num2 = (uint)(((high64 - num * (ulong)pow << 32) + (ulong)low) / (ulong)pow);
				if (low == num2 * pow)
				{
					high64 = num;
					low = num2;
					return true;
				}
				return false;
			}

			// Token: 0x06001019 RID: 4121 RVA: 0x0004205C File Offset: 0x0004025C
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			private static void Unscale(ref uint low, ref ulong high64, ref int scale)
			{
				while ((byte)low == 0 && scale >= 8 && decimal.DecCalc.Div96ByConst(ref high64, ref low, 100000000U))
				{
					scale -= 8;
				}
				if ((low & 15U) == 0U && scale >= 4 && decimal.DecCalc.Div96ByConst(ref high64, ref low, 10000U))
				{
					scale -= 4;
				}
				if ((low & 3U) == 0U && scale >= 2 && decimal.DecCalc.Div96ByConst(ref high64, ref low, 100U))
				{
					scale -= 2;
				}
				if ((low & 1U) == 0U && scale >= 1 && decimal.DecCalc.Div96ByConst(ref high64, ref low, 10U))
				{
					scale--;
				}
			}

			// Token: 0x0600101A RID: 4122 RVA: 0x000420E4 File Offset: 0x000402E4
			private static uint Div96By64(ref decimal.DecCalc.Buf12 bufNum, ulong den)
			{
				uint u = bufNum.U2;
				if (u == 0U)
				{
					ulong num = bufNum.Low64;
					if (num < den)
					{
						return 0U;
					}
					uint num2 = (uint)(num / den);
					num -= (ulong)num2 * den;
					bufNum.Low64 = num;
					return num2;
				}
				else
				{
					uint num3 = (uint)(den >> 32);
					ulong num;
					uint num2;
					if (u >= num3)
					{
						num = bufNum.Low64;
						num -= den << 32;
						num2 = 0U;
						do
						{
							num2 -= 1U;
							num += den;
						}
						while (num >= den);
						bufNum.Low64 = num;
						return num2;
					}
					ulong high = bufNum.High64;
					if (high < (ulong)num3)
					{
						return 0U;
					}
					num2 = (uint)(high / (ulong)num3);
					num = ((ulong)bufNum.U0 | high - (ulong)(num2 * num3) << 32);
					ulong num4 = decimal.DecCalc.UInt32x32To64(num2, (uint)den);
					num -= num4;
					if (num > ~num4)
					{
						do
						{
							num2 -= 1U;
							num += den;
						}
						while (num >= den);
					}
					bufNum.Low64 = num;
					return num2;
				}
			}

			// Token: 0x0600101B RID: 4123 RVA: 0x000421A0 File Offset: 0x000403A0
			private static uint Div128By96(ref decimal.DecCalc.Buf16 bufNum, ref decimal.DecCalc.Buf12 bufDen)
			{
				ulong high = bufNum.High64;
				uint u = bufDen.U2;
				if (high < (ulong)u)
				{
					return 0U;
				}
				uint num = (uint)(high / (ulong)u);
				uint num2 = (uint)high - num * u;
				ulong num3 = decimal.DecCalc.UInt32x32To64(num, bufDen.U0);
				ulong num4 = decimal.DecCalc.UInt32x32To64(num, bufDen.U1);
				num4 += num3 >> 32;
				num3 = ((ulong)((uint)num3) | num4 << 32);
				num4 >>= 32;
				ulong num5 = bufNum.Low64;
				num5 -= num3;
				num2 -= (uint)num4;
				if (num5 > ~num3)
				{
					num2 -= 1U;
					if (num2 < ~(uint)num4)
					{
						goto IL_B4;
					}
				}
				else if (num2 <= ~(uint)num4)
				{
					goto IL_B4;
				}
				num3 = bufDen.Low64;
				do
				{
					num -= 1U;
					num5 += num3;
					num2 += u;
				}
				while ((num5 >= num3 || num2++ >= u) && num2 >= u);
				IL_B4:
				bufNum.Low64 = num5;
				bufNum.U2 = num2;
				return num;
			}

			// Token: 0x0600101C RID: 4124 RVA: 0x00042274 File Offset: 0x00040474
			private static uint IncreaseScale(ref decimal.DecCalc.Buf12 bufNum, uint power)
			{
				ulong num = decimal.DecCalc.UInt32x32To64(bufNum.U0, power);
				bufNum.U0 = (uint)num;
				num >>= 32;
				num += decimal.DecCalc.UInt32x32To64(bufNum.U1, power);
				bufNum.U1 = (uint)num;
				num >>= 32;
				num += decimal.DecCalc.UInt32x32To64(bufNum.U2, power);
				bufNum.U2 = (uint)num;
				return (uint)(num >> 32);
			}

			// Token: 0x0600101D RID: 4125 RVA: 0x000422D4 File Offset: 0x000404D4
			private static void IncreaseScale64(ref decimal.DecCalc.Buf12 bufNum, uint power)
			{
				ulong num = decimal.DecCalc.UInt32x32To64(bufNum.U0, power);
				bufNum.U0 = (uint)num;
				num >>= 32;
				num += decimal.DecCalc.UInt32x32To64(bufNum.U1, power);
				bufNum.High64 = num;
			}

			// Token: 0x0600101E RID: 4126 RVA: 0x00042314 File Offset: 0x00040514
			private unsafe static int ScaleResult(decimal.DecCalc.Buf24* bufRes, uint hiRes, int scale)
			{
				int num = 0;
				if (hiRes > 2U)
				{
					num = (int)(hiRes * 32U - 64U - 1U);
					num -= decimal.DecCalc.LeadingZeroCount(*(uint*)(bufRes + (ulong)hiRes * 4UL / (ulong)sizeof(decimal.DecCalc.Buf24)));
					num = (num * 77 >> 8) + 1;
					if (num > scale)
					{
						goto IL_1CC;
					}
				}
				if (num < scale - 28)
				{
					num = scale - 28;
				}
				if (num != 0)
				{
					scale -= num;
					uint num2 = 0U;
					uint num3 = 0U;
					for (;;)
					{
						num2 |= num3;
						uint num5;
						uint num4;
						switch (num)
						{
						case 1:
							num4 = decimal.DecCalc.DivByConst((uint*)bufRes, hiRes, out num5, out num3, 10U);
							break;
						case 2:
							num4 = decimal.DecCalc.DivByConst((uint*)bufRes, hiRes, out num5, out num3, 100U);
							break;
						case 3:
							num4 = decimal.DecCalc.DivByConst((uint*)bufRes, hiRes, out num5, out num3, 1000U);
							break;
						case 4:
							num4 = decimal.DecCalc.DivByConst((uint*)bufRes, hiRes, out num5, out num3, 10000U);
							break;
						case 5:
							num4 = decimal.DecCalc.DivByConst((uint*)bufRes, hiRes, out num5, out num3, 100000U);
							break;
						case 6:
							num4 = decimal.DecCalc.DivByConst((uint*)bufRes, hiRes, out num5, out num3, 1000000U);
							break;
						case 7:
							num4 = decimal.DecCalc.DivByConst((uint*)bufRes, hiRes, out num5, out num3, 10000000U);
							break;
						case 8:
							num4 = decimal.DecCalc.DivByConst((uint*)bufRes, hiRes, out num5, out num3, 100000000U);
							break;
						default:
							num4 = decimal.DecCalc.DivByConst((uint*)bufRes, hiRes, out num5, out num3, 1000000000U);
							break;
						}
						*(int*)(bufRes + (ulong)hiRes * 4UL / (ulong)sizeof(decimal.DecCalc.Buf24)) = (int)num5;
						if (num5 == 0U && hiRes != 0U)
						{
							hiRes -= 1U;
						}
						num -= 9;
						if (num <= 0)
						{
							if (hiRes > 2U)
							{
								if (scale == 0)
								{
									goto IL_1CC;
								}
								num = 1;
								scale--;
							}
							else
							{
								num4 >>= 1;
								if (num4 > num3 || (num4 >= num3 && ((*(uint*)bufRes & 1U) | num2) == 0U))
								{
									break;
								}
								uint num6 = *(uint*)bufRes + 1U;
								*(int*)bufRes = (int)num6;
								if (num6 != 0U)
								{
									break;
								}
								uint num7 = 0U;
								do
								{
									decimal.DecCalc.Buf24* ptr = bufRes + (ulong)(num7 += 1U) * 4UL / (ulong)sizeof(decimal.DecCalc.Buf24);
									num6 = *(uint*)ptr + 1U;
									*(int*)ptr = (int)num6;
								}
								while (num6 == 0U);
								if (num7 <= 2U)
								{
									break;
								}
								if (scale == 0)
								{
									goto IL_1CC;
								}
								hiRes = num7;
								num2 = 0U;
								num3 = 0U;
								num = 1;
								scale--;
							}
						}
					}
				}
				return scale;
				IL_1CC:
				throw new OverflowException("Value was either too large or too small for a Decimal.");
			}

			// Token: 0x0600101F RID: 4127 RVA: 0x000424F8 File Offset: 0x000406F8
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			private unsafe static uint DivByConst(uint* result, uint hiRes, out uint quotient, out uint remainder, uint power)
			{
				uint num = result[(ulong)hiRes * 4UL / 4UL];
				remainder = num - (quotient = num / power) * power;
				for (uint num2 = hiRes - 1U; num2 >= 0U; num2 -= 1U)
				{
					ulong num3 = (ulong)result[(ulong)num2 * 4UL / 4UL] + ((ulong)remainder << 32);
					remainder = (uint)num3 - (result[(ulong)num2 * 4UL / 4UL] = (uint)(num3 / (ulong)power)) * power;
				}
				return power;
			}

			// Token: 0x06001020 RID: 4128 RVA: 0x0004255C File Offset: 0x0004075C
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			private static int LeadingZeroCount(uint value)
			{
				int num = 1;
				if ((value & 4294901760U) == 0U)
				{
					value <<= 16;
					num += 16;
				}
				if ((value & 4278190080U) == 0U)
				{
					value <<= 8;
					num += 8;
				}
				if ((value & 4026531840U) == 0U)
				{
					value <<= 4;
					num += 4;
				}
				if ((value & 3221225472U) == 0U)
				{
					value <<= 2;
					num += 2;
				}
				return num + ((int)value >> 31);
			}

			// Token: 0x06001021 RID: 4129 RVA: 0x000425BC File Offset: 0x000407BC
			private static int OverflowUnscale(ref decimal.DecCalc.Buf12 bufQuo, int scale, bool sticky)
			{
				if (--scale < 0)
				{
					throw new OverflowException("Value was either too large or too small for a Decimal.");
				}
				bufQuo.U2 = 429496729U;
				ulong num = 25769803776UL + (ulong)bufQuo.U1;
				uint num2 = (uint)(num / 10UL);
				bufQuo.U1 = num2;
				ulong num3 = (num - (ulong)(num2 * 10U) << 32) + (ulong)bufQuo.U0;
				num2 = (uint)(num3 / 10UL);
				bufQuo.U0 = num2;
				uint num4 = (uint)(num3 - (ulong)(num2 * 10U));
				if (num4 > 5U || (num4 == 5U && (sticky || (bufQuo.U0 & 1U) != 0U)))
				{
					decimal.DecCalc.Add32To96(ref bufQuo, 1U);
				}
				return scale;
			}

			// Token: 0x06001022 RID: 4130 RVA: 0x0004264C File Offset: 0x0004084C
			private static int SearchScale(ref decimal.DecCalc.Buf12 bufQuo, int scale)
			{
				uint u = bufQuo.U2;
				ulong low = bufQuo.Low64;
				int num = 0;
				if (u <= 429496729U)
				{
					decimal.DecCalc.PowerOvfl[] powerOvflValues = decimal.DecCalc.PowerOvflValues;
					if (scale > 19)
					{
						num = 28 - scale;
						if (u < powerOvflValues[num - 1].Hi)
						{
							goto IL_D1;
						}
					}
					else if (u < 4U || (u == 4U && low <= 5441186219426131129UL))
					{
						return 9;
					}
					if (u > 42949U)
					{
						if (u > 4294967U)
						{
							num = 2;
							if (u > 42949672U)
							{
								num--;
							}
						}
						else
						{
							num = 4;
							if (u > 429496U)
							{
								num--;
							}
						}
					}
					else if (u > 429U)
					{
						num = 6;
						if (u > 4294U)
						{
							num--;
						}
					}
					else
					{
						num = 8;
						if (u > 42U)
						{
							num--;
						}
					}
					if (u == powerOvflValues[num - 1].Hi && low > powerOvflValues[num - 1].MidLo)
					{
						num--;
					}
				}
				IL_D1:
				if (num + scale < 0)
				{
					throw new OverflowException("Value was either too large or too small for a Decimal.");
				}
				return num;
			}

			// Token: 0x06001023 RID: 4131 RVA: 0x0004273C File Offset: 0x0004093C
			private static bool Add32To96(ref decimal.DecCalc.Buf12 bufNum, uint value)
			{
				if ((bufNum.Low64 += (ulong)value) < (ulong)value)
				{
					uint num = bufNum.U2 + 1U;
					bufNum.U2 = num;
					if (num == 0U)
					{
						return false;
					}
				}
				return true;
			}

			// Token: 0x06001024 RID: 4132 RVA: 0x00042774 File Offset: 0x00040974
			internal unsafe static void DecAddSub(ref decimal.DecCalc d1, ref decimal.DecCalc d2, bool sign)
			{
				ulong num = d1.Low64;
				uint num2 = d1.High;
				uint num3 = d1.uflags;
				uint num4 = d2.uflags;
				uint num5 = num4 ^ num3;
				sign ^= ((num5 & 2147483648U) > 0U);
				if ((num5 & 16711680U) != 0U)
				{
					uint num6 = num3;
					num3 = ((num4 & 16711680U) | (num3 & 2147483648U));
					int i = (int)(num3 - num6) >> 16;
					if (i < 0)
					{
						i = -i;
						num3 = num6;
						if (sign)
						{
							num3 ^= 2147483648U;
						}
						num = d2.Low64;
						num2 = d2.High;
						d2 = d1;
					}
					ulong num9;
					if (num2 == 0U)
					{
						if (num <= (ulong)-1)
						{
							if ((uint)num == 0U)
							{
								uint num7 = num3 & 2147483648U;
								if (sign)
								{
									num7 ^= 2147483648U;
								}
								d1 = d2;
								d1.uflags = ((d2.uflags & 16711680U) | num7);
								return;
							}
							while (i > 9)
							{
								i -= 9;
								num = decimal.DecCalc.UInt32x32To64((uint)num, 1000000000U);
								if (num > (ulong)-1)
								{
									goto IL_106;
								}
							}
							num = decimal.DecCalc.UInt32x32To64((uint)num, decimal.DecCalc.s_powers10[i]);
							goto IL_441;
						}
						do
						{
							IL_106:
							uint b = 1000000000U;
							if (i < 9)
							{
								b = decimal.DecCalc.s_powers10[i];
							}
							ulong num8 = decimal.DecCalc.UInt32x32To64((uint)num, b);
							num9 = decimal.DecCalc.UInt32x32To64((uint)(num >> 32), b) + (num8 >> 32);
							num = (ulong)((uint)num8) + (num9 << 32);
							num2 = (uint)(num9 >> 32);
							if ((i -= 9) <= 0)
							{
								goto IL_441;
							}
						}
						while (num2 == 0U);
					}
					do
					{
						uint b = 1000000000U;
						if (i < 9)
						{
							b = decimal.DecCalc.s_powers10[i];
						}
						ulong num8 = decimal.DecCalc.UInt32x32To64((uint)num, b);
						num9 = decimal.DecCalc.UInt32x32To64((uint)(num >> 32), b) + (num8 >> 32);
						num = (ulong)((uint)num8) + (num9 << 32);
						num9 >>= 32;
						num9 += decimal.DecCalc.UInt32x32To64(num2, b);
						i -= 9;
						if (num9 > (ulong)-1)
						{
							goto IL_1CF;
						}
						num2 = (uint)num9;
					}
					while (i > 0);
					goto IL_441;
					IL_1CF:
					decimal.DecCalc.Buf24 buf;
					buf.Low64 = num;
					buf.Mid64 = num9;
					uint num10 = 3U;
					while (i > 0)
					{
						uint b = 1000000000U;
						if (i < 9)
						{
							b = decimal.DecCalc.s_powers10[i];
						}
						num9 = 0UL;
						uint* ptr = (uint*)(&buf);
						uint num11 = 0U;
						do
						{
							num9 += decimal.DecCalc.UInt32x32To64(ptr[(ulong)num11 * 4UL / 4UL], b);
							ptr[(ulong)num11 * 4UL / 4UL] = (uint)num9;
							num11 += 1U;
							num9 >>= 32;
						}
						while (num11 <= num10);
						if ((uint)num9 != 0U)
						{
							ptr[(IntPtr)((ulong)(num10 += 1U) * 4UL)] = (uint)num9;
						}
						i -= 9;
					}
					num9 = buf.Low64;
					num = d2.Low64;
					uint u = buf.U2;
					num2 = d2.High;
					if (sign)
					{
						num = num9 - num;
						num2 = u - num2;
						if (num > num9)
						{
							num2 -= 1U;
							if (num2 < u)
							{
								goto IL_34C;
							}
						}
						else if (num2 <= u)
						{
							goto IL_34C;
						}
						uint* ptr2 = (uint*)(&buf);
						uint num12 = 3U;
						uint num13;
						do
						{
							uint* ptr3 = ptr2 + (IntPtr)((ulong)num12++ * 4UL);
							num13 = *ptr3;
							*ptr3 = num13 - 1U;
						}
						while (num13 == 0U);
						if (ptr2[(ulong)num10 * 4UL / 4UL] == 0U && (num10 -= 1U) <= 2U)
						{
							goto IL_4AA;
						}
					}
					else
					{
						num += num9;
						num2 += u;
						if (num < num9)
						{
							num2 += 1U;
							if (num2 > u)
							{
								goto IL_34C;
							}
						}
						else if (num2 >= u)
						{
							goto IL_34C;
						}
						uint* ptr4 = (uint*)(&buf);
						uint num14 = 3U;
						do
						{
							uint* ptr5 = ptr4 + (IntPtr)((ulong)num14++ * 4UL);
							uint num13 = *ptr5 + 1U;
							*ptr5 = num13;
							if (num13 != 0U)
							{
								goto IL_34C;
							}
						}
						while (num10 >= num14);
						ptr4[(ulong)num14 * 4UL / 4UL] = 1U;
						num10 = num14;
					}
					IL_34C:
					buf.Low64 = num;
					buf.U2 = num2;
					i = decimal.DecCalc.ScaleResult(&buf, num10, (int)((byte)(num3 >> 16)));
					num3 = ((num3 & 4278255615U) | (uint)((uint)i << 16));
					num = buf.Low64;
					num2 = buf.U2;
					goto IL_4AA;
				}
				IL_441:
				ulong num15 = num;
				uint num16 = num2;
				if (sign)
				{
					num = num15 - d2.Low64;
					num2 = num16 - d2.High;
					if (num > num15)
					{
						num2 -= 1U;
						if (num2 < num16)
						{
							goto IL_4AA;
						}
					}
					else if (num2 <= num16)
					{
						goto IL_4AA;
					}
					num3 ^= 2147483648U;
					num2 = ~num2;
					num = -num;
					if (num == 0UL)
					{
						num2 += 1U;
					}
				}
				else
				{
					num = num15 + d2.Low64;
					num2 = num16 + d2.High;
					if (num < num15)
					{
						num2 += 1U;
						if (num2 > num16)
						{
							goto IL_4AA;
						}
					}
					else if (num2 >= num16)
					{
						goto IL_4AA;
					}
					if ((num3 & 16711680U) == 0U)
					{
						throw new OverflowException("Value was either too large or too small for a Decimal.");
					}
					num3 -= 65536U;
					ulong num17 = (ulong)num2 + 4294967296UL;
					num2 = (uint)(num17 / 10UL);
					ulong num18 = (num17 - (ulong)(num2 * 10U) << 32) + (num >> 32);
					uint num19 = (uint)(num18 / 10UL);
					ulong num20 = (num18 - (ulong)(num19 * 10U) << 32) + (ulong)((uint)num);
					num = (ulong)num19;
					num <<= 32;
					num19 = (uint)(num20 / 10UL);
					num += (ulong)num19;
					num19 = (uint)num20 - num19 * 10U;
					if (num19 >= 5U && (num19 > 5U || (num & 1UL) != 0UL) && (num += 1UL) == 0UL)
					{
						num2 += 1U;
					}
				}
				IL_4AA:
				d1.uflags = num3;
				d1.High = num2;
				d1.Low64 = num;
			}

			// Token: 0x06001025 RID: 4133 RVA: 0x00042C40 File Offset: 0x00040E40
			internal static int VarDecCmp(in decimal d1, in decimal d2)
			{
				if ((d2.Low | d2.Mid | d2.High) == 0U)
				{
					if ((d1.Low | d1.Mid | d1.High) == 0U)
					{
						return 0;
					}
					return d1.flags >> 31 | 1;
				}
				else
				{
					if ((d1.Low | d1.Mid | d1.High) == 0U)
					{
						return -(d2.flags >> 31 | 1);
					}
					int num = (d1.flags >> 31) - (d2.flags >> 31);
					if (num != 0)
					{
						return num;
					}
					return decimal.DecCalc.VarDecCmpSub(d1, d2);
				}
			}

			// Token: 0x06001026 RID: 4134 RVA: 0x00042CCC File Offset: 0x00040ECC
			private static int VarDecCmpSub(in decimal d1, in decimal d2)
			{
				int flags = d2.flags;
				int num = flags >> 31 | 1;
				int num2 = flags - d1.flags;
				ulong num3 = d1.Low64;
				uint num4 = d1.High;
				ulong num5 = d2.Low64;
				uint num6 = d2.High;
				if (num2 != 0)
				{
					num2 >>= 16;
					if (num2 < 0)
					{
						num2 = -num2;
						num = -num;
						ulong num7 = num3;
						num3 = num5;
						num5 = num7;
						uint num8 = num4;
						num4 = num6;
						num6 = num8;
					}
					for (;;)
					{
						uint b = (num2 >= 9) ? 1000000000U : decimal.DecCalc.s_powers10[num2];
						ulong num9 = decimal.DecCalc.UInt32x32To64((uint)num3, b);
						ulong num10 = decimal.DecCalc.UInt32x32To64((uint)(num3 >> 32), b) + (num9 >> 32);
						num3 = (ulong)((uint)num9) + (num10 << 32);
						num10 >>= 32;
						num10 += decimal.DecCalc.UInt32x32To64(num4, b);
						if (num10 > (ulong)-1)
						{
							break;
						}
						num4 = (uint)num10;
						if ((num2 -= 9) <= 0)
						{
							goto IL_BC;
						}
					}
					return num;
				}
				IL_BC:
				uint num11 = num4 - num6;
				if (num11 != 0U)
				{
					if (num11 > num4)
					{
						num = -num;
					}
					return num;
				}
				ulong num12 = num3 - num5;
				if (num12 == 0UL)
				{
					num = 0;
				}
				else if (num12 > num3)
				{
					num = -num;
				}
				return num;
			}

			// Token: 0x06001027 RID: 4135 RVA: 0x00042DC0 File Offset: 0x00040FC0
			internal unsafe static void VarDecMul(ref decimal.DecCalc d1, ref decimal.DecCalc d2)
			{
				int num = (int)((byte)(d1.uflags + d2.uflags >> 16));
				decimal.DecCalc.Buf24 buf;
				uint num6;
				if ((d1.High | d1.Mid) == 0U)
				{
					ulong num4;
					if ((d2.High | d2.Mid) == 0U)
					{
						ulong num2 = decimal.DecCalc.UInt32x32To64(d1.Low, d2.Low);
						if (num > 28)
						{
							if (num > 47)
							{
								goto IL_3CD;
							}
							num -= 29;
							ulong num3 = decimal.DecCalc.s_ulongPowers10[num];
							num4 = num2 / num3;
							ulong num5 = num2 - num4 * num3;
							num2 = num4;
							num3 >>= 1;
							if (num5 >= num3 && (num5 > num3 || ((uint)num2 & 1U) > 0U))
							{
								num2 += 1UL;
							}
							num = 28;
						}
						d1.Low64 = num2;
						d1.uflags = (((d2.uflags ^ d1.uflags) & 2147483648U) | (uint)((uint)num << 16));
						return;
					}
					num4 = decimal.DecCalc.UInt32x32To64(d1.Low, d2.Low);
					buf.U0 = (uint)num4;
					num4 = decimal.DecCalc.UInt32x32To64(d1.Low, d2.Mid) + (num4 >> 32);
					buf.U1 = (uint)num4;
					num4 >>= 32;
					if (d2.High != 0U)
					{
						num4 += decimal.DecCalc.UInt32x32To64(d1.Low, d2.High);
						if (num4 > (ulong)-1)
						{
							buf.Mid64 = num4;
							num6 = 3U;
							goto IL_381;
						}
					}
					if ((uint)num4 != 0U)
					{
						buf.U2 = (uint)num4;
						num6 = 2U;
						goto IL_381;
					}
					num6 = 1U;
				}
				else if ((d2.High | d2.Mid) == 0U)
				{
					ulong num4 = decimal.DecCalc.UInt32x32To64(d2.Low, d1.Low);
					buf.U0 = (uint)num4;
					num4 = decimal.DecCalc.UInt32x32To64(d2.Low, d1.Mid) + (num4 >> 32);
					buf.U1 = (uint)num4;
					num4 >>= 32;
					if (d1.High != 0U)
					{
						num4 += decimal.DecCalc.UInt32x32To64(d2.Low, d1.High);
						if (num4 > (ulong)-1)
						{
							buf.Mid64 = num4;
							num6 = 3U;
							goto IL_381;
						}
					}
					if ((uint)num4 != 0U)
					{
						buf.U2 = (uint)num4;
						num6 = 2U;
						goto IL_381;
					}
					num6 = 1U;
				}
				else
				{
					ulong num4 = decimal.DecCalc.UInt32x32To64(d1.Low, d2.Low);
					buf.U0 = (uint)num4;
					ulong num7 = decimal.DecCalc.UInt32x32To64(d1.Low, d2.Mid) + (num4 >> 32);
					num4 = decimal.DecCalc.UInt32x32To64(d1.Mid, d2.Low);
					num4 += num7;
					buf.U1 = (uint)num4;
					if (num4 < num7)
					{
						num7 = (num4 >> 32 | 4294967296UL);
					}
					else
					{
						num7 = num4 >> 32;
					}
					num4 = decimal.DecCalc.UInt32x32To64(d1.Mid, d2.Mid) + num7;
					if ((d1.High | d2.High) > 0U)
					{
						num7 = decimal.DecCalc.UInt32x32To64(d1.Low, d2.High);
						num4 += num7;
						uint num8 = 0U;
						if (num4 < num7)
						{
							num8 = 1U;
						}
						num7 = decimal.DecCalc.UInt32x32To64(d1.High, d2.Low);
						num4 += num7;
						buf.U2 = (uint)num4;
						if (num4 < num7)
						{
							num8 += 1U;
						}
						num7 = ((ulong)num8 << 32 | num4 >> 32);
						num4 = decimal.DecCalc.UInt32x32To64(d1.Mid, d2.High);
						num4 += num7;
						num8 = 0U;
						if (num4 < num7)
						{
							num8 = 1U;
						}
						num7 = decimal.DecCalc.UInt32x32To64(d1.High, d2.Mid);
						num4 += num7;
						buf.U3 = (uint)num4;
						if (num4 < num7)
						{
							num8 += 1U;
						}
						num4 = ((ulong)num8 << 32 | num4 >> 32);
						buf.High64 = decimal.DecCalc.UInt32x32To64(d1.High, d2.High) + num4;
						num6 = 5U;
					}
					else if (num4 != 0UL)
					{
						buf.Mid64 = num4;
						num6 = 3U;
					}
					else
					{
						num6 = 1U;
					}
				}
				uint* ptr = (uint*)(&buf);
				while (ptr[num6] == 0U)
				{
					if (num6 == 0U)
					{
						goto IL_3CD;
					}
					num6 -= 1U;
				}
				IL_381:
				if (num6 > 2U || num > 28)
				{
					num = decimal.DecCalc.ScaleResult(&buf, num6, num);
				}
				d1.Low64 = buf.Low64;
				d1.High = buf.U2;
				d1.uflags = (((d2.uflags ^ d1.uflags) & 2147483648U) | (uint)((uint)num << 16));
				return;
				IL_3CD:
				d1 = default(decimal.DecCalc);
			}

			// Token: 0x06001028 RID: 4136 RVA: 0x000431A4 File Offset: 0x000413A4
			internal static void VarDecFromR4(float input, out decimal.DecCalc result)
			{
				result = default(decimal.DecCalc);
				int num = (int)(decimal.DecCalc.GetExponent(input) - 126U);
				if (num < -94)
				{
					return;
				}
				if (num > 96)
				{
					throw new OverflowException("Value was either too large or too small for a Decimal.");
				}
				uint num2 = 0U;
				if (input < 0f)
				{
					input = -input;
					num2 = 2147483648U;
				}
				double num3 = (double)input;
				int num4 = 6 - (num * 19728 >> 16);
				if (num4 >= 0)
				{
					if (num4 > 28)
					{
						num4 = 28;
					}
					num3 *= decimal.DecCalc.s_doublePowers10[num4];
				}
				else if (num4 != -1 || num3 >= 10000000.0)
				{
					num3 /= decimal.DecCalc.s_doublePowers10[-num4];
				}
				else
				{
					num4 = 0;
				}
				if (num3 < 1000000.0 && num4 < 28)
				{
					num3 *= 10.0;
					num4++;
				}
				uint num5 = (uint)((int)num3);
				num3 -= (double)num5;
				if (num3 > 0.5 || (num3 == 0.5 && (num5 & 1U) != 0U))
				{
					num5 += 1U;
				}
				if (num5 == 0U)
				{
					return;
				}
				if (num4 < 0)
				{
					num4 = -num4;
					if (num4 < 10)
					{
						result.Low64 = decimal.DecCalc.UInt32x32To64(num5, decimal.DecCalc.s_powers10[num4]);
					}
					else if (num4 > 18)
					{
						decimal.DecCalc.UInt64x64To128(decimal.DecCalc.UInt32x32To64(num5, decimal.DecCalc.s_powers10[num4 - 18]), 1000000000000000000UL, ref result);
					}
					else
					{
						ulong num6 = decimal.DecCalc.UInt32x32To64(num5, decimal.DecCalc.s_powers10[num4 - 9]);
						ulong num7 = decimal.DecCalc.UInt32x32To64(1000000000U, (uint)(num6 >> 32));
						num6 = decimal.DecCalc.UInt32x32To64(1000000000U, (uint)num6);
						result.Low = (uint)num6;
						num7 += num6 >> 32;
						result.Mid = (uint)num7;
						num7 >>= 32;
						result.High = (uint)num7;
					}
				}
				else
				{
					int num8 = num4;
					if (num8 > 6)
					{
						num8 = 6;
					}
					if ((num5 & 15U) == 0U && num8 >= 4)
					{
						uint num9 = num5 / 10000U;
						if (num5 == num9 * 10000U)
						{
							num5 = num9;
							num4 -= 4;
							num8 -= 4;
						}
					}
					if ((num5 & 3U) == 0U && num8 >= 2)
					{
						uint num10 = num5 / 100U;
						if (num5 == num10 * 100U)
						{
							num5 = num10;
							num4 -= 2;
							num8 -= 2;
						}
					}
					if ((num5 & 1U) == 0U && num8 >= 1)
					{
						uint num11 = num5 / 10U;
						if (num5 == num11 * 10U)
						{
							num5 = num11;
							num4--;
						}
					}
					num2 |= (uint)((uint)num4 << 16);
					result.Low = num5;
				}
				result.uflags = num2;
			}

			// Token: 0x06001029 RID: 4137 RVA: 0x000433DC File Offset: 0x000415DC
			internal static void VarDecFromR8(double input, out decimal.DecCalc result)
			{
				result = default(decimal.DecCalc);
				int num = (int)(decimal.DecCalc.GetExponent(input) - 1022U);
				if (num < -94)
				{
					return;
				}
				if (num > 96)
				{
					throw new OverflowException("Value was either too large or too small for a Decimal.");
				}
				uint num2 = 0U;
				if (input < 0.0)
				{
					input = -input;
					num2 = 2147483648U;
				}
				double num3 = input;
				int num4 = 14 - (num * 19728 >> 16);
				if (num4 >= 0)
				{
					if (num4 > 28)
					{
						num4 = 28;
					}
					num3 *= decimal.DecCalc.s_doublePowers10[num4];
				}
				else if (num4 != -1 || num3 >= 1000000000000000.0)
				{
					num3 /= decimal.DecCalc.s_doublePowers10[-num4];
				}
				else
				{
					num4 = 0;
				}
				if (num3 < 100000000000000.0 && num4 < 28)
				{
					num3 *= 10.0;
					num4++;
				}
				ulong num5 = (ulong)((long)num3);
				num3 -= (double)num5;
				if (num3 > 0.5 || (num3 == 0.5 && (num5 & 1UL) != 0UL))
				{
					num5 += 1UL;
				}
				if (num5 == 0UL)
				{
					return;
				}
				if (num4 < 0)
				{
					num4 = -num4;
					if (num4 < 10)
					{
						uint b = decimal.DecCalc.s_powers10[num4];
						ulong num6 = decimal.DecCalc.UInt32x32To64((uint)num5, b);
						ulong num7 = decimal.DecCalc.UInt32x32To64((uint)(num5 >> 32), b);
						result.Low = (uint)num6;
						num7 += num6 >> 32;
						result.Mid = (uint)num7;
						num7 >>= 32;
						result.High = (uint)num7;
					}
					else
					{
						decimal.DecCalc.UInt64x64To128(num5, decimal.DecCalc.s_ulongPowers10[num4 - 1], ref result);
					}
				}
				else
				{
					int num8 = num4;
					if (num8 > 14)
					{
						num8 = 14;
					}
					if ((byte)num5 == 0 && num8 >= 8)
					{
						ulong num9 = num5 / 100000000UL;
						if ((uint)num5 == (uint)(num9 * 100000000UL))
						{
							num5 = num9;
							num4 -= 8;
							num8 -= 8;
						}
					}
					if (((uint)num5 & 15U) == 0U && num8 >= 4)
					{
						ulong num10 = num5 / 10000UL;
						if ((uint)num5 == (uint)(num10 * 10000UL))
						{
							num5 = num10;
							num4 -= 4;
							num8 -= 4;
						}
					}
					if (((uint)num5 & 3U) == 0U && num8 >= 2)
					{
						ulong num11 = num5 / 100UL;
						if ((uint)num5 == (uint)(num11 * 100UL))
						{
							num5 = num11;
							num4 -= 2;
							num8 -= 2;
						}
					}
					if (((uint)num5 & 1U) == 0U && num8 >= 1)
					{
						ulong num12 = num5 / 10UL;
						if ((uint)num5 == (uint)(num12 * 10UL))
						{
							num5 = num12;
							num4--;
						}
					}
					num2 |= (uint)((uint)num4 << 16);
					result.Low64 = num5;
				}
				result.uflags = num2;
			}

			// Token: 0x0600102A RID: 4138 RVA: 0x0004361F File Offset: 0x0004181F
			internal static float VarR4FromDec(in decimal value)
			{
				return (float)decimal.DecCalc.VarR8FromDec(value);
			}

			// Token: 0x0600102B RID: 4139 RVA: 0x00043628 File Offset: 0x00041828
			internal static double VarR8FromDec(in decimal value)
			{
				double num = (value.Low64 + value.High * 1.8446744073709552E+19) / decimal.DecCalc.s_doublePowers10[value.Scale];
				if (value.IsNegative)
				{
					num = -num;
				}
				return num;
			}

			// Token: 0x0600102C RID: 4140 RVA: 0x0004366C File Offset: 0x0004186C
			internal static int GetHashCode(in decimal d)
			{
				if ((d.Low | d.Mid | d.High) == 0U)
				{
					return 0;
				}
				uint num = (uint)d.flags;
				if ((num & 16711680U) == 0U || (d.Low & 1U) != 0U)
				{
					return (int)(num ^ d.High ^ d.Mid ^ d.Low);
				}
				int num2 = (int)((byte)(num >> 16));
				uint low = d.Low;
				ulong num3 = (ulong)d.High << 32 | (ulong)d.Mid;
				decimal.DecCalc.Unscale(ref low, ref num3, ref num2);
				num = ((num & 4278255615U) | (uint)((uint)num2 << 16));
				return (int)(num ^ (uint)(num3 >> 32) ^ (uint)num3 ^ low);
			}

			// Token: 0x0600102D RID: 4141 RVA: 0x00043708 File Offset: 0x00041908
			internal unsafe static void VarDecDiv(ref decimal.DecCalc d1, ref decimal.DecCalc d2)
			{
				int num = (int)((sbyte)(d1.uflags - d2.uflags >> 16));
				bool flag = false;
				decimal.DecCalc.Buf12 buf;
				if ((d2.High | d2.Mid) == 0U)
				{
					uint low = d2.Low;
					if (low == 0U)
					{
						throw new DivideByZeroException();
					}
					buf.Low64 = d1.Low64;
					buf.U2 = d1.High;
					uint num2 = decimal.DecCalc.Div96By32(ref buf, low);
					for (;;)
					{
						int num3;
						if (num2 == 0U)
						{
							if (num >= 0)
							{
								goto IL_3D2;
							}
							num3 = Math.Min(9, -num);
						}
						else
						{
							flag = true;
							if (num == 28 || (num3 = decimal.DecCalc.SearchScale(ref buf, num)) == 0)
							{
								break;
							}
						}
						uint num4 = decimal.DecCalc.s_powers10[num3];
						num += num3;
						if (decimal.DecCalc.IncreaseScale(ref buf, num4) != 0U)
						{
							goto IL_48A;
						}
						ulong num5 = decimal.DecCalc.UInt32x32To64(num2, num4);
						uint num6 = (uint)(num5 / (ulong)low);
						num2 = (uint)num5 - num6 * low;
						if (!decimal.DecCalc.Add32To96(ref buf, num6))
						{
							goto Block_11;
						}
					}
					uint num7 = num2 << 1;
					if (num7 < num2)
					{
						goto IL_449;
					}
					if (num7 < low)
					{
						goto IL_3D2;
					}
					if (num7 > low)
					{
						goto IL_449;
					}
					if ((buf.U0 & 1U) != 0U)
					{
						goto IL_449;
					}
					goto IL_3D2;
					Block_11:
					num = decimal.DecCalc.OverflowUnscale(ref buf, num, num2 > 0U);
				}
				else
				{
					uint num7 = d2.High;
					if (num7 == 0U)
					{
						num7 = d2.Mid;
					}
					int num3 = decimal.DecCalc.LeadingZeroCount(num7);
					decimal.DecCalc.Buf16 buf2;
					buf2.Low64 = d1.Low64 << num3;
					buf2.High64 = (ulong)d1.Mid + ((ulong)d1.High << 32) >> 32 - num3;
					ulong num8 = d2.Low64 << num3;
					if (d2.High == 0U)
					{
						buf.U1 = decimal.DecCalc.Div96By64(ref *(decimal.DecCalc.Buf12*)(&buf2.U1), num8);
						buf.U0 = decimal.DecCalc.Div96By64(ref *(decimal.DecCalc.Buf12*)(&buf2), num8);
						for (;;)
						{
							if (buf2.Low64 == 0UL)
							{
								if (num >= 0)
								{
									goto IL_3D2;
								}
								num3 = Math.Min(9, -num);
							}
							else
							{
								flag = true;
								if (num == 28 || (num3 = decimal.DecCalc.SearchScale(ref buf, num)) == 0)
								{
									break;
								}
							}
							uint num4 = decimal.DecCalc.s_powers10[num3];
							num += num3;
							if (decimal.DecCalc.IncreaseScale(ref buf, num4) != 0U)
							{
								goto IL_48A;
							}
							decimal.DecCalc.IncreaseScale64(ref *(decimal.DecCalc.Buf12*)(&buf2), num4);
							num7 = decimal.DecCalc.Div96By64(ref *(decimal.DecCalc.Buf12*)(&buf2), num8);
							if (!decimal.DecCalc.Add32To96(ref buf, num7))
							{
								goto Block_22;
							}
						}
						ulong num9 = buf2.Low64;
						if (num9 < 0UL || (num9 <<= 1) > num8)
						{
							goto IL_449;
						}
						if (num9 == num8 && (buf.U0 & 1U) != 0U)
						{
							goto IL_449;
						}
						goto IL_3D2;
						Block_22:
						num = decimal.DecCalc.OverflowUnscale(ref buf, num, buf2.Low64 > 0UL);
					}
					else
					{
						decimal.DecCalc.Buf12 buf3;
						buf3.Low64 = num8;
						buf3.U2 = (uint)((ulong)d2.Mid + ((ulong)d2.High << 32) >> 32 - num3);
						buf.Low64 = (ulong)decimal.DecCalc.Div128By96(ref buf2, ref buf3);
						for (;;)
						{
							if ((buf2.Low64 | (ulong)buf2.U2) == 0UL)
							{
								if (num >= 0)
								{
									goto IL_3D2;
								}
								num3 = Math.Min(9, -num);
							}
							else
							{
								flag = true;
								if (num == 28 || (num3 = decimal.DecCalc.SearchScale(ref buf, num)) == 0)
								{
									break;
								}
							}
							uint num4 = decimal.DecCalc.s_powers10[num3];
							num += num3;
							if (decimal.DecCalc.IncreaseScale(ref buf, num4) != 0U)
							{
								goto IL_48A;
							}
							buf2.U3 = decimal.DecCalc.IncreaseScale(ref *(decimal.DecCalc.Buf12*)(&buf2), num4);
							num7 = decimal.DecCalc.Div128By96(ref buf2, ref buf3);
							if (!decimal.DecCalc.Add32To96(ref buf, num7))
							{
								goto Block_33;
							}
						}
						if (buf2.U2 < 0U)
						{
							goto IL_449;
						}
						num7 = buf2.U1 >> 31;
						buf2.Low64 <<= 1;
						buf2.U2 = (buf2.U2 << 1) + num7;
						if (buf2.U2 > buf3.U2)
						{
							goto IL_449;
						}
						if (buf2.U2 != buf3.U2)
						{
							goto IL_3D2;
						}
						if (buf2.Low64 > buf3.Low64)
						{
							goto IL_449;
						}
						if (buf2.Low64 == buf3.Low64 && (buf.U0 & 1U) != 0U)
						{
							goto IL_449;
						}
						goto IL_3D2;
						Block_33:
						num = decimal.DecCalc.OverflowUnscale(ref buf, num, (buf2.Low64 | buf2.High64) > 0UL);
					}
				}
				IL_3D2:
				if (flag)
				{
					uint u = buf.U0;
					ulong high = buf.High64;
					decimal.DecCalc.Unscale(ref u, ref high, ref num);
					d1.Low = u;
					d1.Mid = (uint)high;
					d1.High = (uint)(high >> 32);
				}
				else
				{
					d1.Low64 = buf.Low64;
					d1.High = buf.U2;
				}
				d1.uflags = (((d1.uflags ^ d2.uflags) & 2147483648U) | (uint)((uint)num << 16));
				return;
				IL_449:
				ulong num10 = buf.Low64 + 1UL;
				buf.Low64 = num10;
				if (num10 != 0UL)
				{
					goto IL_3D2;
				}
				uint num11 = buf.U2 + 1U;
				buf.U2 = num11;
				if (num11 == 0U)
				{
					num = decimal.DecCalc.OverflowUnscale(ref buf, num, true);
					goto IL_3D2;
				}
				goto IL_3D2;
				IL_48A:
				throw new OverflowException("Value was either too large or too small for a Decimal.");
			}

			// Token: 0x0600102E RID: 4142 RVA: 0x00043BAC File Offset: 0x00041DAC
			internal static void InternalRound(ref decimal.DecCalc d, uint scale, decimal.DecCalc.RoundingMode mode)
			{
				d.uflags -= scale << 16;
				uint num = 0U;
				uint num5;
				while (scale >= 9U)
				{
					scale -= 9U;
					uint num2 = d.uhi;
					uint num4;
					if (num2 == 0U)
					{
						ulong low = d.Low64;
						ulong num3 = low / 1000000000UL;
						d.Low64 = num3;
						num4 = (uint)(low - num3 * 1000000000UL);
					}
					else
					{
						num4 = num2 - (d.uhi = num2 / 1000000000U) * 1000000000U;
						num2 = d.umid;
						if ((num2 | num4) != 0U)
						{
							num4 = num2 - (d.umid = (uint)(((ulong)num4 << 32 | (ulong)num2) / 1000000000UL)) * 1000000000U;
						}
						num2 = d.ulo;
						if ((num2 | num4) != 0U)
						{
							num4 = num2 - (d.ulo = (uint)(((ulong)num4 << 32 | (ulong)num2) / 1000000000UL)) * 1000000000U;
						}
					}
					num5 = 1000000000U;
					if (scale == 0U)
					{
						IL_194:
						if (mode != decimal.DecCalc.RoundingMode.Truncate)
						{
							if (mode == decimal.DecCalc.RoundingMode.ToEven)
							{
								num4 <<= 1;
								if ((num | (d.ulo & 1U)) != 0U)
								{
									num4 += 1U;
								}
								if (num5 >= num4)
								{
									return;
								}
							}
							else if (mode == decimal.DecCalc.RoundingMode.AwayFromZero)
							{
								num4 <<= 1;
								if (num5 > num4)
								{
									return;
								}
							}
							else if (mode == decimal.DecCalc.RoundingMode.Floor)
							{
								if ((num4 | num) == 0U)
								{
									return;
								}
								if (!d.IsNegative)
								{
									return;
								}
							}
							else if ((num4 | num) == 0U || d.IsNegative)
							{
								return;
							}
							ulong num6 = d.Low64 + 1UL;
							d.Low64 = num6;
							if (num6 == 0UL)
							{
								d.uhi += 1U;
							}
						}
						return;
					}
					num |= num4;
				}
				num5 = decimal.DecCalc.s_powers10[(int)scale];
				uint num7 = d.uhi;
				if (num7 == 0U)
				{
					ulong low2 = d.Low64;
					if (low2 != 0UL)
					{
						ulong num8 = low2 / (ulong)num5;
						d.Low64 = num8;
						uint num4 = (uint)(low2 - num8 * (ulong)num5);
						goto IL_194;
					}
					if (mode > decimal.DecCalc.RoundingMode.Truncate)
					{
						uint num4 = 0U;
						goto IL_194;
					}
					return;
				}
				else
				{
					uint num4 = num7 - (d.uhi = num7 / num5) * num5;
					num7 = d.umid;
					if ((num7 | num4) != 0U)
					{
						num4 = num7 - (d.umid = (uint)(((ulong)num4 << 32 | (ulong)num7) / (ulong)num5)) * num5;
					}
					num7 = d.ulo;
					if ((num7 | num4) != 0U)
					{
						num4 = num7 - (d.ulo = (uint)(((ulong)num4 << 32 | (ulong)num7) / (ulong)num5)) * num5;
						goto IL_194;
					}
					goto IL_194;
				}
			}

			// Token: 0x0600102F RID: 4143 RVA: 0x00043DBC File Offset: 0x00041FBC
			internal static uint DecDivMod1E9(ref decimal.DecCalc value)
			{
				ulong num = ((ulong)value.uhi << 32) + (ulong)value.umid;
				ulong num2 = num / 1000000000UL;
				value.uhi = (uint)(num2 >> 32);
				value.umid = (uint)num2;
				ulong num3 = (num - (ulong)((uint)num2 * 1000000000U) << 32) + (ulong)value.ulo;
				uint num4 = (uint)(num3 / 1000000000UL);
				value.ulo = num4;
				return (uint)num3 - num4 * 1000000000U;
			}

			// Token: 0x04000603 RID: 1539
			[FieldOffset(0)]
			private uint uflags;

			// Token: 0x04000604 RID: 1540
			[FieldOffset(4)]
			private uint uhi;

			// Token: 0x04000605 RID: 1541
			[FieldOffset(8)]
			private uint ulo;

			// Token: 0x04000606 RID: 1542
			[FieldOffset(12)]
			private uint umid;

			// Token: 0x04000607 RID: 1543
			[FieldOffset(8)]
			private ulong ulomidLE;

			// Token: 0x04000608 RID: 1544
			private static readonly uint[] s_powers10 = new uint[]
			{
				1U,
				10U,
				100U,
				1000U,
				10000U,
				100000U,
				1000000U,
				10000000U,
				100000000U,
				1000000000U
			};

			// Token: 0x04000609 RID: 1545
			private static readonly ulong[] s_ulongPowers10 = new ulong[]
			{
				10UL,
				100UL,
				1000UL,
				10000UL,
				100000UL,
				1000000UL,
				10000000UL,
				100000000UL,
				1000000000UL,
				10000000000UL,
				100000000000UL,
				1000000000000UL,
				10000000000000UL,
				100000000000000UL,
				1000000000000000UL,
				10000000000000000UL,
				100000000000000000UL,
				1000000000000000000UL,
				10000000000000000000UL
			};

			// Token: 0x0400060A RID: 1546
			private static readonly double[] s_doublePowers10 = new double[]
			{
				1.0,
				10.0,
				100.0,
				1000.0,
				10000.0,
				100000.0,
				1000000.0,
				10000000.0,
				100000000.0,
				1000000000.0,
				10000000000.0,
				100000000000.0,
				1000000000000.0,
				10000000000000.0,
				100000000000000.0,
				1000000000000000.0,
				10000000000000000.0,
				1E+17,
				1E+18,
				1E+19,
				1E+20,
				1E+21,
				1E+22,
				1E+23,
				1E+24,
				1E+25,
				1E+26,
				1E+27,
				1E+28,
				1E+29,
				1E+30,
				1E+31,
				1E+32,
				1E+33,
				1E+34,
				1E+35,
				1E+36,
				1E+37,
				1E+38,
				1E+39,
				1E+40,
				1E+41,
				1E+42,
				1E+43,
				1E+44,
				1E+45,
				1E+46,
				1E+47,
				1E+48,
				1E+49,
				1E+50,
				1E+51,
				1E+52,
				1E+53,
				1E+54,
				1E+55,
				1E+56,
				1E+57,
				1E+58,
				1E+59,
				1E+60,
				1E+61,
				1E+62,
				1E+63,
				1E+64,
				1E+65,
				1E+66,
				1E+67,
				1E+68,
				1E+69,
				1E+70,
				1E+71,
				1E+72,
				1E+73,
				1E+74,
				1E+75,
				1E+76,
				1E+77,
				1E+78,
				1E+79,
				1E+80
			};

			// Token: 0x0400060B RID: 1547
			private static readonly decimal.DecCalc.PowerOvfl[] PowerOvflValues = new decimal.DecCalc.PowerOvfl[]
			{
				new decimal.DecCalc.PowerOvfl(429496729U, 2576980377U, 2576980377U),
				new decimal.DecCalc.PowerOvfl(42949672U, 4123168604U, 687194767U),
				new decimal.DecCalc.PowerOvfl(4294967U, 1271310319U, 2645699854U),
				new decimal.DecCalc.PowerOvfl(429496U, 3133608139U, 694066715U),
				new decimal.DecCalc.PowerOvfl(42949U, 2890341191U, 2216890319U),
				new decimal.DecCalc.PowerOvfl(4294U, 4154504685U, 2369172679U),
				new decimal.DecCalc.PowerOvfl(429U, 2133437386U, 4102387834U),
				new decimal.DecCalc.PowerOvfl(42U, 4078814305U, 410238783U)
			};

			// Token: 0x0200019B RID: 411
			internal enum RoundingMode
			{
				// Token: 0x0400060D RID: 1549
				ToEven,
				// Token: 0x0400060E RID: 1550
				AwayFromZero,
				// Token: 0x0400060F RID: 1551
				Truncate,
				// Token: 0x04000610 RID: 1552
				Floor,
				// Token: 0x04000611 RID: 1553
				Ceiling
			}

			// Token: 0x0200019C RID: 412
			private struct PowerOvfl
			{
				// Token: 0x06001031 RID: 4145 RVA: 0x00043F5A File Offset: 0x0004215A
				public PowerOvfl(uint hi, uint mid, uint lo)
				{
					this.Hi = hi;
					this.MidLo = ((ulong)mid << 32) + (ulong)lo;
				}

				// Token: 0x04000612 RID: 1554
				public readonly uint Hi;

				// Token: 0x04000613 RID: 1555
				public readonly ulong MidLo;
			}

			// Token: 0x0200019D RID: 413
			[StructLayout(2)]
			private struct Buf12
			{
				// Token: 0x1700017B RID: 379
				// (get) Token: 0x06001032 RID: 4146 RVA: 0x00043F71 File Offset: 0x00042171
				// (set) Token: 0x06001033 RID: 4147 RVA: 0x00043F93 File Offset: 0x00042193
				public ulong Low64
				{
					get
					{
						if (!BitConverter.IsLittleEndian)
						{
							return (ulong)this.U1 << 32 | (ulong)this.U0;
						}
						return this.ulo64LE;
					}
					set
					{
						if (BitConverter.IsLittleEndian)
						{
							this.ulo64LE = value;
							return;
						}
						this.U1 = (uint)(value >> 32);
						this.U0 = (uint)value;
					}
				}

				// Token: 0x1700017C RID: 380
				// (get) Token: 0x06001034 RID: 4148 RVA: 0x00043FB7 File Offset: 0x000421B7
				// (set) Token: 0x06001035 RID: 4149 RVA: 0x00043FD9 File Offset: 0x000421D9
				public ulong High64
				{
					get
					{
						if (!BitConverter.IsLittleEndian)
						{
							return (ulong)this.U2 << 32 | (ulong)this.U1;
						}
						return this.uhigh64LE;
					}
					set
					{
						if (BitConverter.IsLittleEndian)
						{
							this.uhigh64LE = value;
							return;
						}
						this.U2 = (uint)(value >> 32);
						this.U1 = (uint)value;
					}
				}

				// Token: 0x04000614 RID: 1556
				[FieldOffset(0)]
				public uint U0;

				// Token: 0x04000615 RID: 1557
				[FieldOffset(4)]
				public uint U1;

				// Token: 0x04000616 RID: 1558
				[FieldOffset(8)]
				public uint U2;

				// Token: 0x04000617 RID: 1559
				[FieldOffset(0)]
				private ulong ulo64LE;

				// Token: 0x04000618 RID: 1560
				[FieldOffset(4)]
				private ulong uhigh64LE;
			}

			// Token: 0x0200019E RID: 414
			[StructLayout(2)]
			private struct Buf16
			{
				// Token: 0x1700017D RID: 381
				// (get) Token: 0x06001036 RID: 4150 RVA: 0x00043FFD File Offset: 0x000421FD
				// (set) Token: 0x06001037 RID: 4151 RVA: 0x0004401F File Offset: 0x0004221F
				public ulong Low64
				{
					get
					{
						if (!BitConverter.IsLittleEndian)
						{
							return (ulong)this.U1 << 32 | (ulong)this.U0;
						}
						return this.ulo64LE;
					}
					set
					{
						if (BitConverter.IsLittleEndian)
						{
							this.ulo64LE = value;
							return;
						}
						this.U1 = (uint)(value >> 32);
						this.U0 = (uint)value;
					}
				}

				// Token: 0x1700017E RID: 382
				// (get) Token: 0x06001038 RID: 4152 RVA: 0x00044043 File Offset: 0x00042243
				// (set) Token: 0x06001039 RID: 4153 RVA: 0x00044065 File Offset: 0x00042265
				public ulong High64
				{
					get
					{
						if (!BitConverter.IsLittleEndian)
						{
							return (ulong)this.U3 << 32 | (ulong)this.U2;
						}
						return this.uhigh64LE;
					}
					set
					{
						if (BitConverter.IsLittleEndian)
						{
							this.uhigh64LE = value;
							return;
						}
						this.U3 = (uint)(value >> 32);
						this.U2 = (uint)value;
					}
				}

				// Token: 0x04000619 RID: 1561
				[FieldOffset(0)]
				public uint U0;

				// Token: 0x0400061A RID: 1562
				[FieldOffset(4)]
				public uint U1;

				// Token: 0x0400061B RID: 1563
				[FieldOffset(8)]
				public uint U2;

				// Token: 0x0400061C RID: 1564
				[FieldOffset(12)]
				public uint U3;

				// Token: 0x0400061D RID: 1565
				[FieldOffset(0)]
				private ulong ulo64LE;

				// Token: 0x0400061E RID: 1566
				[FieldOffset(8)]
				private ulong uhigh64LE;
			}

			// Token: 0x0200019F RID: 415
			[StructLayout(2)]
			private struct Buf24
			{
				// Token: 0x1700017F RID: 383
				// (get) Token: 0x0600103A RID: 4154 RVA: 0x00044089 File Offset: 0x00042289
				// (set) Token: 0x0600103B RID: 4155 RVA: 0x000440AB File Offset: 0x000422AB
				public ulong Low64
				{
					get
					{
						if (!BitConverter.IsLittleEndian)
						{
							return (ulong)this.U1 << 32 | (ulong)this.U0;
						}
						return this.ulo64LE;
					}
					set
					{
						if (BitConverter.IsLittleEndian)
						{
							this.ulo64LE = value;
							return;
						}
						this.U1 = (uint)(value >> 32);
						this.U0 = (uint)value;
					}
				}

				// Token: 0x17000180 RID: 384
				// (set) Token: 0x0600103C RID: 4156 RVA: 0x000440CF File Offset: 0x000422CF
				public ulong Mid64
				{
					set
					{
						if (BitConverter.IsLittleEndian)
						{
							this.umid64LE = value;
							return;
						}
						this.U3 = (uint)(value >> 32);
						this.U2 = (uint)value;
					}
				}

				// Token: 0x17000181 RID: 385
				// (set) Token: 0x0600103D RID: 4157 RVA: 0x000440F3 File Offset: 0x000422F3
				public ulong High64
				{
					set
					{
						if (BitConverter.IsLittleEndian)
						{
							this.uhigh64LE = value;
							return;
						}
						this.U5 = (uint)(value >> 32);
						this.U4 = (uint)value;
					}
				}

				// Token: 0x0400061F RID: 1567
				[FieldOffset(0)]
				public uint U0;

				// Token: 0x04000620 RID: 1568
				[FieldOffset(4)]
				public uint U1;

				// Token: 0x04000621 RID: 1569
				[FieldOffset(8)]
				public uint U2;

				// Token: 0x04000622 RID: 1570
				[FieldOffset(12)]
				public uint U3;

				// Token: 0x04000623 RID: 1571
				[FieldOffset(16)]
				public uint U4;

				// Token: 0x04000624 RID: 1572
				[FieldOffset(20)]
				public uint U5;

				// Token: 0x04000625 RID: 1573
				[FieldOffset(0)]
				private ulong ulo64LE;

				// Token: 0x04000626 RID: 1574
				[FieldOffset(8)]
				private ulong umid64LE;

				// Token: 0x04000627 RID: 1575
				[FieldOffset(16)]
				private ulong uhigh64LE;
			}
		}
	}
}
