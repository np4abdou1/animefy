using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

namespace System
{
	/// <summary>Provides constants and static methods for trigonometric, logarithmic, and other common mathematical functions.To browse the .NET Framework source code for this type, see the Reference Source.</summary>
	// Token: 0x020000D0 RID: 208
	public static class Math
	{
		/// <summary>Returns the absolute value of a 32-bit signed integer.</summary>
		/// <param name="value">A number that is greater than <see cref="F:System.Int32.MinValue" />, but less than or equal to <see cref="F:System.Int32.MaxValue" />.</param>
		/// <returns>A 32-bit signed integer, x, such that 0 ≤ x ≤<see cref="F:System.Int32.MaxValue" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> equals <see cref="F:System.Int32.MinValue" />. </exception>
		// Token: 0x060006C9 RID: 1737 RVA: 0x0001D01A File Offset: 0x0001B21A
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int Abs(int value)
		{
			if (value < 0)
			{
				value = -value;
				if (value < 0)
				{
					Math.ThrowAbsOverflow();
				}
			}
			return value;
		}

		/// <summary>Returns the absolute value of a 64-bit signed integer.</summary>
		/// <param name="value">A number that is greater than <see cref="F:System.Int64.MinValue" />, but less than or equal to <see cref="F:System.Int64.MaxValue" />.</param>
		/// <returns>A 64-bit signed integer, x, such that 0 ≤ x ≤<see cref="F:System.Int64.MaxValue" />.</returns>
		/// <exception cref="T:System.OverflowException">
		///         <paramref name="value" /> equals <see cref="F:System.Int64.MinValue" />. </exception>
		// Token: 0x060006CA RID: 1738 RVA: 0x0001D02E File Offset: 0x0001B22E
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static long Abs(long value)
		{
			if (value < 0L)
			{
				value = -value;
				if (value < 0L)
				{
					Math.ThrowAbsOverflow();
				}
			}
			return value;
		}

		/// <summary>Returns the absolute value of a <see cref="T:System.Decimal" /> number.</summary>
		/// <param name="value">A number that is greater than or equal to <see cref="F:System.Decimal.MinValue" />, but less than or equal to <see cref="F:System.Decimal.MaxValue" />. </param>
		/// <returns>A decimal number, x, such that 0 ≤ x ≤<see cref="F:System.Decimal.MaxValue" />.</returns>
		// Token: 0x060006CB RID: 1739 RVA: 0x0001D044 File Offset: 0x0001B244
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static decimal Abs(decimal value)
		{
			return decimal.Abs(ref value);
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x0001D04D File Offset: 0x0001B24D
		[StackTraceHidden]
		private static void ThrowAbsOverflow()
		{
			throw new OverflowException("Negating the minimum value of a twos complement number is invalid.");
		}

		/// <summary>Calculates the quotient of two 32-bit signed integers and also returns the remainder in an output parameter.</summary>
		/// <param name="a">The dividend. </param>
		/// <param name="b">The divisor. </param>
		/// <param name="result">The remainder. </param>
		/// <returns>The quotient of the specified numbers.</returns>
		/// <exception cref="T:System.DivideByZeroException">
		///         <paramref name="b" /> is zero.</exception>
		// Token: 0x060006CD RID: 1741 RVA: 0x0001D05C File Offset: 0x0001B25C
		public static int DivRem(int a, int b, out int result)
		{
			int num = a / b;
			result = a - num * b;
			return num;
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x0001D075 File Offset: 0x0001B275
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int Clamp(int value, int min, int max)
		{
			if (min > max)
			{
				Math.ThrowMinMaxException<int>(min, max);
			}
			if (value < min)
			{
				return min;
			}
			if (value > max)
			{
				return max;
			}
			return value;
		}

		/// <summary>Returns the logarithm of a specified number in a specified base.</summary>
		/// <param name="a">The number whose logarithm is to be found. </param>
		/// <param name="newBase">The base of the logarithm. </param>
		/// <returns>One of the values in the following table. (+Infinity denotes <see cref="F:System.Double.PositiveInfinity" />, -Infinity denotes <see cref="F:System.Double.NegativeInfinity" />, and NaN denotes <see cref="F:System.Double.NaN" />.)
		///             <paramref name="a" />
		///
		///             <paramref name="newBase" />
		///           Return value
		///             <paramref name="a" />
		///             &gt; 0(0 &lt;<paramref name="newBase" />&lt; 1) -or-(<paramref name="newBase" />&gt; 1)lognewBase(a)
		///             <paramref name="a" />
		///             &lt; 0(any value)NaN(any value)
		///             <paramref name="newBase" />
		///             &lt; 0NaN
		///             <paramref name="a" /> != 1
		///             <paramref name="newBase" /> = 0NaN
		///             <paramref name="a" /> != 1
		///             <paramref name="newBase" /> = +InfinityNaN
		///             <paramref name="a" /> = NaN(any value)NaN(any value)
		///             <paramref name="newBase" /> = NaNNaN(any value)
		///             <paramref name="newBase" /> = 1NaN
		///             <paramref name="a" /> = 00 &lt;<paramref name="newBase" />&lt; 1 +Infinity
		///             <paramref name="a" /> = 0
		///             <paramref name="newBase" />
		///             &gt; 1-Infinity
		///             <paramref name="a" /> =  +Infinity0 &lt;<paramref name="newBase" />&lt; 1-Infinity
		///             <paramref name="a" /> =  +Infinity
		///             <paramref name="newBase" />
		///             &gt; 1+Infinity
		///             <paramref name="a" /> = 1
		///             <paramref name="newBase" /> = 00
		///             <paramref name="a" /> = 1
		///             <paramref name="newBase" /> = +Infinity0</returns>
		// Token: 0x060006CF RID: 1743 RVA: 0x0001D090 File Offset: 0x0001B290
		public static double Log(double a, double newBase)
		{
			if (double.IsNaN(a))
			{
				return a;
			}
			if (double.IsNaN(newBase))
			{
				return newBase;
			}
			if (newBase == 1.0)
			{
				return double.NaN;
			}
			if (a != 1.0 && (newBase == 0.0 || double.IsPositiveInfinity(newBase)))
			{
				return double.NaN;
			}
			return Math.Log(a) / Math.Log(newBase);
		}

		/// <summary>Returns the larger of two 8-bit unsigned integers.</summary>
		/// <param name="val1">The first of two 8-bit unsigned integers to compare. </param>
		/// <param name="val2">The second of two 8-bit unsigned integers to compare. </param>
		/// <returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is larger.</returns>
		// Token: 0x060006D0 RID: 1744 RVA: 0x0001D0FE File Offset: 0x0001B2FE
		[NonVersionable]
		public static byte Max(byte val1, byte val2)
		{
			if (val1 < val2)
			{
				return val2;
			}
			return val1;
		}

		/// <summary>Returns the larger of two decimal numbers.</summary>
		/// <param name="val1">The first of two decimal numbers to compare. </param>
		/// <param name="val2">The second of two decimal numbers to compare. </param>
		/// <returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is larger.</returns>
		// Token: 0x060006D1 RID: 1745 RVA: 0x0001D107 File Offset: 0x0001B307
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static decimal Max(decimal val1, decimal val2)
		{
			return *decimal.Max(ref val1, ref val2);
		}

		/// <summary>Returns the larger of two double-precision floating-point numbers.</summary>
		/// <param name="val1">The first of two double-precision floating-point numbers to compare. </param>
		/// <param name="val2">The second of two double-precision floating-point numbers to compare. </param>
		/// <returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is larger. If <paramref name="val1" />, <paramref name="val2" />, or both <paramref name="val1" /> and <paramref name="val2" /> are equal to <see cref="F:System.Double.NaN" />, <see cref="F:System.Double.NaN" /> is returned.</returns>
		// Token: 0x060006D2 RID: 1746 RVA: 0x0001D117 File Offset: 0x0001B317
		public static double Max(double val1, double val2)
		{
			if (val1 > val2)
			{
				return val1;
			}
			if (double.IsNaN(val1))
			{
				return val1;
			}
			return val2;
		}

		/// <summary>Returns the larger of two 16-bit signed integers.</summary>
		/// <param name="val1">The first of two 16-bit signed integers to compare. </param>
		/// <param name="val2">The second of two 16-bit signed integers to compare. </param>
		/// <returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is larger.</returns>
		// Token: 0x060006D3 RID: 1747 RVA: 0x0001D0FE File Offset: 0x0001B2FE
		[NonVersionable]
		public static short Max(short val1, short val2)
		{
			if (val1 < val2)
			{
				return val2;
			}
			return val1;
		}

		/// <summary>Returns the larger of two 32-bit signed integers.</summary>
		/// <param name="val1">The first of two 32-bit signed integers to compare. </param>
		/// <param name="val2">The second of two 32-bit signed integers to compare. </param>
		/// <returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is larger.</returns>
		// Token: 0x060006D4 RID: 1748 RVA: 0x0001D0FE File Offset: 0x0001B2FE
		[NonVersionable]
		public static int Max(int val1, int val2)
		{
			if (val1 < val2)
			{
				return val2;
			}
			return val1;
		}

		/// <summary>Returns the larger of two 64-bit signed integers.</summary>
		/// <param name="val1">The first of two 64-bit signed integers to compare. </param>
		/// <param name="val2">The second of two 64-bit signed integers to compare. </param>
		/// <returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is larger.</returns>
		// Token: 0x060006D5 RID: 1749 RVA: 0x0001D0FE File Offset: 0x0001B2FE
		[NonVersionable]
		public static long Max(long val1, long val2)
		{
			if (val1 < val2)
			{
				return val2;
			}
			return val1;
		}

		/// <summary>Returns the larger of two 8-bit signed integers.</summary>
		/// <param name="val1">The first of two 8-bit signed integers to compare. </param>
		/// <param name="val2">The second of two 8-bit signed integers to compare. </param>
		/// <returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is larger.</returns>
		// Token: 0x060006D6 RID: 1750 RVA: 0x0001D0FE File Offset: 0x0001B2FE
		[CLSCompliant(false)]
		[NonVersionable]
		public static sbyte Max(sbyte val1, sbyte val2)
		{
			if (val1 < val2)
			{
				return val2;
			}
			return val1;
		}

		/// <summary>Returns the larger of two single-precision floating-point numbers.</summary>
		/// <param name="val1">The first of two single-precision floating-point numbers to compare. </param>
		/// <param name="val2">The second of two single-precision floating-point numbers to compare. </param>
		/// <returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is larger. If <paramref name="val1" />, or <paramref name="val2" />, or both <paramref name="val1" /> and <paramref name="val2" /> are equal to <see cref="F:System.Single.NaN" />, <see cref="F:System.Single.NaN" /> is returned.</returns>
		// Token: 0x060006D7 RID: 1751 RVA: 0x0001D12A File Offset: 0x0001B32A
		public static float Max(float val1, float val2)
		{
			if (val1 > val2)
			{
				return val1;
			}
			if (float.IsNaN(val1))
			{
				return val1;
			}
			return val2;
		}

		/// <summary>Returns the larger of two 16-bit unsigned integers.</summary>
		/// <param name="val1">The first of two 16-bit unsigned integers to compare. </param>
		/// <param name="val2">The second of two 16-bit unsigned integers to compare. </param>
		/// <returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is larger.</returns>
		// Token: 0x060006D8 RID: 1752 RVA: 0x0001D0FE File Offset: 0x0001B2FE
		[CLSCompliant(false)]
		[NonVersionable]
		public static ushort Max(ushort val1, ushort val2)
		{
			if (val1 < val2)
			{
				return val2;
			}
			return val1;
		}

		/// <summary>Returns the larger of two 32-bit unsigned integers.</summary>
		/// <param name="val1">The first of two 32-bit unsigned integers to compare. </param>
		/// <param name="val2">The second of two 32-bit unsigned integers to compare. </param>
		/// <returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is larger.</returns>
		// Token: 0x060006D9 RID: 1753 RVA: 0x0001D13D File Offset: 0x0001B33D
		[CLSCompliant(false)]
		[NonVersionable]
		public static uint Max(uint val1, uint val2)
		{
			if (val1 < val2)
			{
				return val2;
			}
			return val1;
		}

		/// <summary>Returns the larger of two 64-bit unsigned integers.</summary>
		/// <param name="val1">The first of two 64-bit unsigned integers to compare. </param>
		/// <param name="val2">The second of two 64-bit unsigned integers to compare. </param>
		/// <returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is larger.</returns>
		// Token: 0x060006DA RID: 1754 RVA: 0x0001D13D File Offset: 0x0001B33D
		[CLSCompliant(false)]
		[NonVersionable]
		public static ulong Max(ulong val1, ulong val2)
		{
			if (val1 < val2)
			{
				return val2;
			}
			return val1;
		}

		/// <summary>Returns the smaller of two 8-bit unsigned integers.</summary>
		/// <param name="val1">The first of two 8-bit unsigned integers to compare. </param>
		/// <param name="val2">The second of two 8-bit unsigned integers to compare. </param>
		/// <returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is smaller.</returns>
		// Token: 0x060006DB RID: 1755 RVA: 0x0001D146 File Offset: 0x0001B346
		[NonVersionable]
		public static byte Min(byte val1, byte val2)
		{
			if (val1 > val2)
			{
				return val2;
			}
			return val1;
		}

		/// <summary>Returns the smaller of two decimal numbers.</summary>
		/// <param name="val1">The first of two decimal numbers to compare. </param>
		/// <param name="val2">The second of two decimal numbers to compare. </param>
		/// <returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is smaller.</returns>
		// Token: 0x060006DC RID: 1756 RVA: 0x0001D14F File Offset: 0x0001B34F
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static decimal Min(decimal val1, decimal val2)
		{
			return *decimal.Min(ref val1, ref val2);
		}

		/// <summary>Returns the smaller of two double-precision floating-point numbers.</summary>
		/// <param name="val1">The first of two double-precision floating-point numbers to compare. </param>
		/// <param name="val2">The second of two double-precision floating-point numbers to compare. </param>
		/// <returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is smaller. If <paramref name="val1" />, <paramref name="val2" />, or both <paramref name="val1" /> and <paramref name="val2" /> are equal to <see cref="F:System.Double.NaN" />, <see cref="F:System.Double.NaN" /> is returned.</returns>
		// Token: 0x060006DD RID: 1757 RVA: 0x0001D15F File Offset: 0x0001B35F
		public static double Min(double val1, double val2)
		{
			if (val1 < val2)
			{
				return val1;
			}
			if (double.IsNaN(val1))
			{
				return val1;
			}
			return val2;
		}

		/// <summary>Returns the smaller of two 16-bit signed integers.</summary>
		/// <param name="val1">The first of two 16-bit signed integers to compare. </param>
		/// <param name="val2">The second of two 16-bit signed integers to compare. </param>
		/// <returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is smaller.</returns>
		// Token: 0x060006DE RID: 1758 RVA: 0x0001D146 File Offset: 0x0001B346
		[NonVersionable]
		public static short Min(short val1, short val2)
		{
			if (val1 > val2)
			{
				return val2;
			}
			return val1;
		}

		/// <summary>Returns the smaller of two 32-bit signed integers.</summary>
		/// <param name="val1">The first of two 32-bit signed integers to compare. </param>
		/// <param name="val2">The second of two 32-bit signed integers to compare. </param>
		/// <returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is smaller.</returns>
		// Token: 0x060006DF RID: 1759 RVA: 0x0001D146 File Offset: 0x0001B346
		[NonVersionable]
		public static int Min(int val1, int val2)
		{
			if (val1 > val2)
			{
				return val2;
			}
			return val1;
		}

		/// <summary>Returns the smaller of two 64-bit signed integers.</summary>
		/// <param name="val1">The first of two 64-bit signed integers to compare. </param>
		/// <param name="val2">The second of two 64-bit signed integers to compare. </param>
		/// <returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is smaller.</returns>
		// Token: 0x060006E0 RID: 1760 RVA: 0x0001D146 File Offset: 0x0001B346
		[NonVersionable]
		public static long Min(long val1, long val2)
		{
			if (val1 > val2)
			{
				return val2;
			}
			return val1;
		}

		/// <summary>Returns the smaller of two 8-bit signed integers.</summary>
		/// <param name="val1">The first of two 8-bit signed integers to compare. </param>
		/// <param name="val2">The second of two 8-bit signed integers to compare. </param>
		/// <returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is smaller.</returns>
		// Token: 0x060006E1 RID: 1761 RVA: 0x0001D146 File Offset: 0x0001B346
		[CLSCompliant(false)]
		[NonVersionable]
		public static sbyte Min(sbyte val1, sbyte val2)
		{
			if (val1 > val2)
			{
				return val2;
			}
			return val1;
		}

		/// <summary>Returns the smaller of two single-precision floating-point numbers.</summary>
		/// <param name="val1">The first of two single-precision floating-point numbers to compare. </param>
		/// <param name="val2">The second of two single-precision floating-point numbers to compare. </param>
		/// <returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is smaller. If <paramref name="val1" />, <paramref name="val2" />, or both <paramref name="val1" /> and <paramref name="val2" /> are equal to <see cref="F:System.Single.NaN" />, <see cref="F:System.Single.NaN" /> is returned.</returns>
		// Token: 0x060006E2 RID: 1762 RVA: 0x0001D172 File Offset: 0x0001B372
		public static float Min(float val1, float val2)
		{
			if (val1 < val2)
			{
				return val1;
			}
			if (float.IsNaN(val1))
			{
				return val1;
			}
			return val2;
		}

		/// <summary>Returns the smaller of two 16-bit unsigned integers.</summary>
		/// <param name="val1">The first of two 16-bit unsigned integers to compare. </param>
		/// <param name="val2">The second of two 16-bit unsigned integers to compare. </param>
		/// <returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is smaller.</returns>
		// Token: 0x060006E3 RID: 1763 RVA: 0x0001D146 File Offset: 0x0001B346
		[CLSCompliant(false)]
		[NonVersionable]
		public static ushort Min(ushort val1, ushort val2)
		{
			if (val1 > val2)
			{
				return val2;
			}
			return val1;
		}

		/// <summary>Returns the smaller of two 32-bit unsigned integers.</summary>
		/// <param name="val1">The first of two 32-bit unsigned integers to compare. </param>
		/// <param name="val2">The second of two 32-bit unsigned integers to compare. </param>
		/// <returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is smaller.</returns>
		// Token: 0x060006E4 RID: 1764 RVA: 0x0001D185 File Offset: 0x0001B385
		[CLSCompliant(false)]
		[NonVersionable]
		public static uint Min(uint val1, uint val2)
		{
			if (val1 > val2)
			{
				return val2;
			}
			return val1;
		}

		/// <summary>Returns the smaller of two 64-bit unsigned integers.</summary>
		/// <param name="val1">The first of two 64-bit unsigned integers to compare. </param>
		/// <param name="val2">The second of two 64-bit unsigned integers to compare. </param>
		/// <returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is smaller.</returns>
		// Token: 0x060006E5 RID: 1765 RVA: 0x0001D185 File Offset: 0x0001B385
		[CLSCompliant(false)]
		[NonVersionable]
		public static ulong Min(ulong val1, ulong val2)
		{
			if (val1 > val2)
			{
				return val2;
			}
			return val1;
		}

		/// <summary>Rounds a decimal value to the nearest integral value.</summary>
		/// <param name="d">A decimal number to be rounded. </param>
		/// <returns>The integer nearest parameter <paramref name="d" />. If the fractional component of <paramref name="d" /> is halfway between two integers, one of which is even and the other odd, the even number is returned. Note that this method returns a <see cref="T:System.Decimal" /> instead of an integral type.</returns>
		/// <exception cref="T:System.OverflowException">The result is outside the range of a <see cref="T:System.Decimal" />.</exception>
		// Token: 0x060006E6 RID: 1766 RVA: 0x0001D18E File Offset: 0x0001B38E
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static decimal Round(decimal d)
		{
			return decimal.Round(d, 0);
		}

		/// <summary>Rounds a double-precision floating-point value to the nearest integral value.</summary>
		/// <param name="a">A double-precision floating-point number to be rounded. </param>
		/// <returns>The integer nearest <paramref name="a" />. If the fractional component of <paramref name="a" /> is halfway between two integers, one of which is even and the other odd, then the even number is returned. Note that this method returns a <see cref="T:System.Double" /> instead of an integral type.</returns>
		// Token: 0x060006E7 RID: 1767
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double Round(double a);

		/// <summary>Rounds a double-precision floating-point value to a specified number of fractional digits.</summary>
		/// <param name="value">A double-precision floating-point number to be rounded. </param>
		/// <param name="digits">The number of fractional digits in the return value. </param>
		/// <returns>The number nearest to <paramref name="value" /> that contains a number of fractional digits equal to <paramref name="digits" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="digits" /> is less than 0 or greater than 15. </exception>
		// Token: 0x060006E8 RID: 1768 RVA: 0x0001D197 File Offset: 0x0001B397
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double Round(double value, int digits)
		{
			return Math.Round(value, digits, MidpointRounding.ToEven);
		}

		/// <summary>Rounds a double-precision floating-point value to a specified number of fractional digits. A parameter specifies how to round the value if it is midway between two numbers.</summary>
		/// <param name="value">A double-precision floating-point number to be rounded. </param>
		/// <param name="digits">The number of fractional digits in the return value. </param>
		/// <param name="mode">Specification for how to round <paramref name="value" /> if it is midway between two other numbers.</param>
		/// <returns>The number nearest to <paramref name="value" /> that has a number of fractional digits equal to <paramref name="digits" />. If <paramref name="value" /> has fewer fractional digits than <paramref name="digits" />, <paramref name="value" /> is returned unchanged.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="digits" /> is less than 0 or greater than 15. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="mode" /> is not a valid value of <see cref="T:System.MidpointRounding" />.</exception>
		// Token: 0x060006E9 RID: 1769 RVA: 0x0001D1A4 File Offset: 0x0001B3A4
		public unsafe static double Round(double value, int digits, MidpointRounding mode)
		{
			if (digits < 0 || digits > 15)
			{
				throw new ArgumentOutOfRangeException("digits", "Rounding digits must be between 0 and 15, inclusive.");
			}
			if (mode < MidpointRounding.ToEven || mode > MidpointRounding.AwayFromZero)
			{
				throw new ArgumentException(SR.Format("The value '{0}' is not valid for this usage of the type {1}.", mode, "MidpointRounding"), "mode");
			}
			if (Math.Abs(value) < Math.doubleRoundLimit)
			{
				double num = Math.roundPower10Double[digits];
				value *= num;
				if (mode == MidpointRounding.AwayFromZero)
				{
					double value2 = Math.ModF(value, &value);
					if (Math.Abs(value2) >= 0.5)
					{
						value += (double)Math.Sign(value2);
					}
				}
				else
				{
					value = Math.Round(value);
				}
				value /= num;
			}
			return value;
		}

		/// <summary>Returns an integer that indicates the sign of a decimal number.</summary>
		/// <param name="value">A signed decimal number. </param>
		/// <returns>A number that indicates the sign of <paramref name="value" />, as shown in the following table.Return value Meaning -1 
		///             <paramref name="value" /> is less than zero. 0 
		///             <paramref name="value" /> is equal to zero. 1 
		///             <paramref name="value" /> is greater than zero. </returns>
		// Token: 0x060006EA RID: 1770 RVA: 0x0001D246 File Offset: 0x0001B446
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int Sign(decimal value)
		{
			return decimal.Sign(ref value);
		}

		/// <summary>Returns an integer that indicates the sign of a double-precision floating-point number.</summary>
		/// <param name="value">A signed number. </param>
		/// <returns>A number that indicates the sign of <paramref name="value" />, as shown in the following table.Return value Meaning -1 
		///             <paramref name="value" /> is less than zero. 0 
		///             <paramref name="value" /> is equal to zero. 1 
		///             <paramref name="value" /> is greater than zero. </returns>
		/// <exception cref="T:System.ArithmeticException">
		///         <paramref name="value" /> is equal to <see cref="F:System.Double.NaN" />. </exception>
		// Token: 0x060006EB RID: 1771 RVA: 0x0001D24F File Offset: 0x0001B44F
		public static int Sign(double value)
		{
			if (value < 0.0)
			{
				return -1;
			}
			if (value > 0.0)
			{
				return 1;
			}
			if (value == 0.0)
			{
				return 0;
			}
			throw new ArithmeticException("Function does not accept floating point Not-a-Number values.");
		}

		/// <summary>Returns an integer that indicates the sign of a 32-bit signed integer.</summary>
		/// <param name="value">A signed number. </param>
		/// <returns>A number that indicates the sign of <paramref name="value" />, as shown in the following table.Return value Meaning -1 
		///             <paramref name="value" /> is less than zero. 0 
		///             <paramref name="value" /> is equal to zero. 1 
		///             <paramref name="value" /> is greater than zero. </returns>
		// Token: 0x060006EC RID: 1772 RVA: 0x0001D285 File Offset: 0x0001B485
		public static int Sign(int value)
		{
			return value >> 31 | (int)((uint)(-(uint)value) >> 31);
		}

		/// <summary>Returns an integer that indicates the sign of a 64-bit signed integer.</summary>
		/// <param name="value">A signed number. </param>
		/// <returns>A number that indicates the sign of <paramref name="value" />, as shown in the following table.Return value Meaning -1 
		///             <paramref name="value" /> is less than zero. 0 
		///             <paramref name="value" /> is equal to zero. 1 
		///             <paramref name="value" /> is greater than zero. </returns>
		// Token: 0x060006ED RID: 1773 RVA: 0x0001D291 File Offset: 0x0001B491
		public static int Sign(long value)
		{
			return (int)(value >> 63 | (long)((ulong)(-(ulong)value) >> 63));
		}

		/// <summary>Calculates the integral part of a specified decimal number. </summary>
		/// <param name="d">A number to truncate.</param>
		/// <returns>The integral part of <paramref name="d" />; that is, the number that remains after any fractional digits have been discarded.</returns>
		// Token: 0x060006EE RID: 1774 RVA: 0x0001D29E File Offset: 0x0001B49E
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static decimal Truncate(decimal d)
		{
			return decimal.Truncate(d);
		}

		/// <summary>Calculates the integral part of a specified double-precision floating-point number. </summary>
		/// <param name="d">A number to truncate.</param>
		/// <returns>The integral part of <paramref name="d" />; that is, the number that remains after any fractional digits have been discarded, or one of the values listed in the following table. 
		///             <paramref name="d" />
		///           Return value
		///             <see cref="F:System.Double.NaN" />
		///
		///             <see cref="F:System.Double.NaN" />
		///
		///             <see cref="F:System.Double.NegativeInfinity" />
		///
		///             <see cref="F:System.Double.NegativeInfinity" />
		///
		///             <see cref="F:System.Double.PositiveInfinity" />
		///
		///             <see cref="F:System.Double.PositiveInfinity" />
		///           </returns>
		// Token: 0x060006EF RID: 1775 RVA: 0x0001D2A6 File Offset: 0x0001B4A6
		public unsafe static double Truncate(double d)
		{
			Math.ModF(d, &d);
			return d;
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x0001D2B3 File Offset: 0x0001B4B3
		private static void ThrowMinMaxException<T>(T min, T max)
		{
			throw new ArgumentException(SR.Format("'{0}' cannot be greater than {1}.", min, max));
		}

		/// <summary>Returns the absolute value of a double-precision floating-point number.</summary>
		/// <param name="value">A number that is greater than or equal to <see cref="F:System.Double.MinValue" />, but less than or equal to <see cref="F:System.Double.MaxValue" />.</param>
		/// <returns>A double-precision floating-point number, x, such that 0 ≤ x ≤<see cref="F:System.Double.MaxValue" />.</returns>
		// Token: 0x060006F1 RID: 1777
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double Abs(double value);

		/// <summary>Returns the largest integer less than or equal to the specified double-precision floating-point number.</summary>
		/// <param name="d">A double-precision floating-point number. </param>
		/// <returns>The largest integer less than or equal to <paramref name="d" />. If <paramref name="d" /> is equal to <see cref="F:System.Double.NaN" />, <see cref="F:System.Double.NegativeInfinity" />, or <see cref="F:System.Double.PositiveInfinity" />, that value is returned.</returns>
		// Token: 0x060006F2 RID: 1778
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double Floor(double d);

		/// <summary>Returns the natural (base <see langword="e" />) logarithm of a specified number.</summary>
		/// <param name="d">The number whose logarithm is to be found. </param>
		/// <returns>One of the values in the following table. 
		///             <paramref name="d" /> parameterReturn value Positive The natural logarithm of <paramref name="d" />; that is, ln <paramref name="d" />, or log e<paramref name="d" />Zero 
		///             <see cref="F:System.Double.NegativeInfinity" />
		///           Negative 
		///             <see cref="F:System.Double.NaN" />
		///           Equal to <see cref="F:System.Double.NaN" />
		///             <see cref="F:System.Double.NaN" />
		///           Equal to <see cref="F:System.Double.PositiveInfinity" />
		///             <see cref="F:System.Double.PositiveInfinity" />
		///           </returns>
		// Token: 0x060006F3 RID: 1779
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double Log(double d);

		/// <summary>Returns a specified number raised to the specified power.</summary>
		/// <param name="x">A double-precision floating-point number to be raised to a power. </param>
		/// <param name="y">A double-precision floating-point number that specifies a power. </param>
		/// <returns>The number <paramref name="x" /> raised to the power <paramref name="y" />.</returns>
		// Token: 0x060006F4 RID: 1780
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double Pow(double x, double y);

		/// <summary>Returns the square root of a specified number.</summary>
		/// <param name="d">The number whose square root is to be found. </param>
		/// <returns>One of the values in the following table. 
		///             <paramref name="d" /> parameter Return value Zero or positive The positive square root of <paramref name="d" />. Negative 
		///             <see cref="F:System.Double.NaN" />
		///           Equals <see cref="F:System.Double.NaN" />
		///             <see cref="F:System.Double.NaN" />
		///           Equals <see cref="F:System.Double.PositiveInfinity" />
		///             <see cref="F:System.Double.PositiveInfinity" />
		///           </returns>
		// Token: 0x060006F5 RID: 1781
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double Sqrt(double d);

		// Token: 0x060006F6 RID: 1782
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern double ModF(double x, double* intptr);

		// Token: 0x0400032B RID: 811
		private static double doubleRoundLimit = 10000000000000000.0;

		// Token: 0x0400032C RID: 812
		private static double[] roundPower10Double = new double[]
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
			1000000000000000.0
		};
	}
}
