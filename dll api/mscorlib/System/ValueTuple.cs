using System;
using System.Collections;
using System.Numerics.Hashing;
using System.Runtime.CompilerServices;

namespace System
{
	/// <summary>Provides static methods for creating value tuples. </summary>
	// Token: 0x02000119 RID: 281
	[Serializable]
	public struct ValueTuple : IEquatable<ValueTuple>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple>, IValueTupleInternal, ITuple
	{
		/// <summary>Returns a value that indicates whether the current <see cref="T:System.ValueTuple" /> instance is equal to a specified object.  </summary>
		/// <param name="obj">The object to compare to the current instance. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="obj" /> is a <see cref="T:System.ValueTuple" /> instance; otherwise, <see langword="false" />. </returns>
		// Token: 0x06000AC1 RID: 2753 RVA: 0x0002BA5C File Offset: 0x00029C5C
		public override bool Equals(object obj)
		{
			return obj is ValueTuple;
		}

		/// <summary>Determines whether two <see cref="T:System.ValueTuple" /> instances are equal. This method always returns <see langword="true" />. </summary>
		/// <param name="other">The value tuple to compare with the current instance.</param>
		/// <returns>This method always returns <see langword="true" />. </returns>
		// Token: 0x06000AC2 RID: 2754 RVA: 0x0000B18D File Offset: 0x0000938D
		public bool Equals(ValueTuple other)
		{
			return true;
		}

		/// <summary>Returns a value that indicates whether the current <see cref="T:System.ValueTuple" /> instance is equal to a specified object based on a specified comparison method.</summary>
		/// <param name="other">The object to compare with this instance.</param>
		/// <param name="comparer">An object that defines the method to use to evaluate whether the two objects are equal.</param>
		/// <returns>
		///     <see langword="true" /> if the current instance is equal to the specified object; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000AC3 RID: 2755 RVA: 0x0002BA5C File Offset: 0x00029C5C
		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
		{
			return other is ValueTuple;
		}

		/// <summary>Compares this <see cref="T:System.ValueTuple" /> instance with a specified object and returns an indication of their relative values. </summary>
		/// <param name="other">The object to compare with the current instance</param>
		/// <returns>0 if <paramref name="other" /> is a <see cref="T:System.ValueTuple" /> instance; otherwise, 1 if <paramref name="other" /> is <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="other" /> is not a <see cref="T:System.ValueTuple" /> instance. </exception>
		// Token: 0x06000AC4 RID: 2756 RVA: 0x0002BA67 File Offset: 0x00029C67
		int IComparable.CompareTo(object other)
		{
			if (other == null)
			{
				return 1;
			}
			if (!(other is ValueTuple))
			{
				throw new ArgumentException(SR.Format("Argument must be of type {0}.", base.GetType().ToString()), "other");
			}
			return 0;
		}

		/// <summary>Compares the current <see cref="T:System.ValueTuple" /> instance with a specified object.</summary>
		/// <param name="other">The object to compare with the current instance. </param>
		/// <returns>Returns 0 if <paramref name=" other" /> is a <see cref="T:System.ValueTuple" /> instance and 1 if <paramref name="other" /> is <see langword="null" />.   </returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="other" /> is not a <see cref="T:System.ValueTuple" /> instance. </exception>
		// Token: 0x06000AC5 RID: 2757 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		public int CompareTo(ValueTuple other)
		{
			return 0;
		}

		/// <summary>Compares the current <see cref="T:System.ValueTuple" /> instance to a specified object.</summary>
		/// <param name="other">The object to compare with the current instance.</param>
		/// <param name="comparer">An object that provides custom rules for comparison. This parameter is ignored. </param>
		/// <returns>Returns 0 if <paramref name=" other" /> is a <see cref="T:System.ValueTuple" /> instance and 1 if <paramref name="other" /> is <see langword="null" />.   </returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="other" /> is not a <see cref="T:System.ValueTuple" /> instance. </exception>
		// Token: 0x06000AC6 RID: 2758 RVA: 0x0002BA67 File Offset: 0x00029C67
		int IStructuralComparable.CompareTo(object other, IComparer comparer)
		{
			if (other == null)
			{
				return 1;
			}
			if (!(other is ValueTuple))
			{
				throw new ArgumentException(SR.Format("Argument must be of type {0}.", base.GetType().ToString()), "other");
			}
			return 0;
		}

		/// <summary>Returns the hash code for the current <see cref="T:System.ValueTuple" /> instance. </summary>
		/// <returns>The hash code for the current <see cref="T:System.ValueTuple" /> instance. </returns>
		// Token: 0x06000AC7 RID: 2759 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		public override int GetHashCode()
		{
			return 0;
		}

		/// <summary>Returns the hash code for this <see cref="T:System.ValueTuple" /> instance.</summary>
		/// <param name="comparer">An object whose <see cref="M:System.Collections.IEqualityComparer.GetHashCode(System.Object)" /> method computes the hash code. This parameter is ignored.</param>
		/// <returns>The hash code for this <see cref="T:System.ValueTuple" /> instance.</returns>
		// Token: 0x06000AC8 RID: 2760 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
		{
			return 0;
		}

		// Token: 0x06000AC9 RID: 2761 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		int IValueTupleInternal.GetHashCode(IEqualityComparer comparer)
		{
			return 0;
		}

		/// <summary>Returns the string representation of this <see cref="T:System.ValueTuple" /> instance.</summary>
		/// <returns>This method always returns "()".</returns>
		// Token: 0x06000ACA RID: 2762 RVA: 0x0002BAA1 File Offset: 0x00029CA1
		public override string ToString()
		{
			return "()";
		}

		// Token: 0x06000ACB RID: 2763 RVA: 0x0002BAA8 File Offset: 0x00029CA8
		string IValueTupleInternal.ToStringEnd()
		{
			return ")";
		}

		/// <summary>Gets the length of this <see langword="ValueTuple" /> instance, which is always 0. There are no elements in a <see langword="ValueTuple" />.</summary>
		/// <returns>0, the number of elements in this <see langword="ValueTuple" /> instance.</returns>
		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000ACC RID: 2764 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		int ITuple.Length
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x06000ACD RID: 2765 RVA: 0x0002BAAF File Offset: 0x00029CAF
		internal static int CombineHashCodes(int h1, int h2)
		{
			return System.Numerics.Hashing.HashHelpers.Combine(System.Numerics.Hashing.HashHelpers.Combine(System.Numerics.Hashing.HashHelpers.RandomSeed, h1), h2);
		}

		// Token: 0x06000ACE RID: 2766 RVA: 0x0002BAC2 File Offset: 0x00029CC2
		internal static int CombineHashCodes(int h1, int h2, int h3)
		{
			return System.Numerics.Hashing.HashHelpers.Combine(ValueTuple.CombineHashCodes(h1, h2), h3);
		}

		// Token: 0x06000ACF RID: 2767 RVA: 0x0002BAD1 File Offset: 0x00029CD1
		internal static int CombineHashCodes(int h1, int h2, int h3, int h4)
		{
			return System.Numerics.Hashing.HashHelpers.Combine(ValueTuple.CombineHashCodes(h1, h2, h3), h4);
		}

		// Token: 0x06000AD0 RID: 2768 RVA: 0x0002BAE1 File Offset: 0x00029CE1
		internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5)
		{
			return System.Numerics.Hashing.HashHelpers.Combine(ValueTuple.CombineHashCodes(h1, h2, h3, h4), h5);
		}

		// Token: 0x06000AD1 RID: 2769 RVA: 0x0002BAF3 File Offset: 0x00029CF3
		internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5, int h6)
		{
			return System.Numerics.Hashing.HashHelpers.Combine(ValueTuple.CombineHashCodes(h1, h2, h3, h4, h5), h6);
		}

		// Token: 0x06000AD2 RID: 2770 RVA: 0x0002BB07 File Offset: 0x00029D07
		internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5, int h6, int h7)
		{
			return System.Numerics.Hashing.HashHelpers.Combine(ValueTuple.CombineHashCodes(h1, h2, h3, h4, h5, h6), h7);
		}

		// Token: 0x06000AD3 RID: 2771 RVA: 0x0002BB1D File Offset: 0x00029D1D
		internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5, int h6, int h7, int h8)
		{
			return System.Numerics.Hashing.HashHelpers.Combine(ValueTuple.CombineHashCodes(h1, h2, h3, h4, h5, h6, h7), h8);
		}
	}
}
