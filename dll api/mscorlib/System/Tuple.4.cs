using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace System
{
	/// <summary>Represents a 4-tuple, or quadruple. </summary>
	/// <typeparam name="T1">The type of the tuple's first component.</typeparam>
	/// <typeparam name="T2">The type of the tuple's second component.</typeparam>
	/// <typeparam name="T3">The type of the tuple's third component.</typeparam>
	/// <typeparam name="T4">The type of the tuple's fourth component.</typeparam>
	// Token: 0x0200010D RID: 269
	[Serializable]
	public class Tuple<T1, T2, T3, T4> : IStructuralEquatable, IStructuralComparable, IComparable, ITupleInternal, ITuple
	{
		/// <summary>Gets the value of the current <see cref="T:System.Tuple`4" /> object's first component.</summary>
		/// <returns>The value of the current <see cref="T:System.Tuple`4" /> object's first component.</returns>
		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060009A8 RID: 2472 RVA: 0x0002A106 File Offset: 0x00028306
		public T1 Item1
		{
			get
			{
				return this.m_Item1;
			}
		}

		/// <summary>Gets the value of the current <see cref="T:System.Tuple`4" /> object's second component.</summary>
		/// <returns>The value of the current <see cref="T:System.Tuple`4" /> object's second component.</returns>
		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060009A9 RID: 2473 RVA: 0x0002A10E File Offset: 0x0002830E
		public T2 Item2
		{
			get
			{
				return this.m_Item2;
			}
		}

		/// <summary>Gets the value of the current <see cref="T:System.Tuple`4" /> object's third component.</summary>
		/// <returns>The value of the current <see cref="T:System.Tuple`4" /> object's third component.</returns>
		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060009AA RID: 2474 RVA: 0x0002A116 File Offset: 0x00028316
		public T3 Item3
		{
			get
			{
				return this.m_Item3;
			}
		}

		/// <summary>Gets the value of the current <see cref="T:System.Tuple`4" /> object's fourth component.</summary>
		/// <returns>The value of the current <see cref="T:System.Tuple`4" /> object's fourth component.</returns>
		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060009AB RID: 2475 RVA: 0x0002A11E File Offset: 0x0002831E
		public T4 Item4
		{
			get
			{
				return this.m_Item4;
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Tuple`4" /> class.</summary>
		/// <param name="item1">The value of the tuple's first component.</param>
		/// <param name="item2">The value of the tuple's second component.</param>
		/// <param name="item3">The value of the tuple's third component.</param>
		/// <param name="item4">The value of the tuple's fourth component</param>
		// Token: 0x060009AC RID: 2476 RVA: 0x0002A126 File Offset: 0x00028326
		public Tuple(T1 item1, T2 item2, T3 item3, T4 item4)
		{
			this.m_Item1 = item1;
			this.m_Item2 = item2;
			this.m_Item3 = item3;
			this.m_Item4 = item4;
		}

		/// <summary>Returns a value that indicates whether the current <see cref="T:System.Tuple`4" /> object is equal to a specified object.</summary>
		/// <param name="obj">The object to compare with this instance.</param>
		/// <returns>
		///     <see langword="true" /> if the current instance is equal to the specified object; otherwise, <see langword="false" />.</returns>
		// Token: 0x060009AD RID: 2477 RVA: 0x00029D54 File Offset: 0x00027F54
		public override bool Equals(object obj)
		{
			return ((IStructuralEquatable)this).Equals(obj, EqualityComparer<object>.Default);
		}

		/// <summary>Returns a value that indicates whether the current <see cref="T:System.Tuple`4" /> object is equal to a specified object based on a specified comparison method.</summary>
		/// <param name="other">The object to compare with this instance.</param>
		/// <param name="comparer">An object that defines the method to use to evaluate whether the two objects are equal.</param>
		/// <returns>
		///     <see langword="true" /> if the current instance is equal to the specified object; otherwise, <see langword="false" />. </returns>
		// Token: 0x060009AE RID: 2478 RVA: 0x0002A14C File Offset: 0x0002834C
		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
		{
			if (other == null)
			{
				return false;
			}
			Tuple<T1, T2, T3, T4> tuple = other as Tuple<T1, T2, T3, T4>;
			return tuple != null && (comparer.Equals(this.m_Item1, tuple.m_Item1) && comparer.Equals(this.m_Item2, tuple.m_Item2) && comparer.Equals(this.m_Item3, tuple.m_Item3)) && comparer.Equals(this.m_Item4, tuple.m_Item4);
		}

		/// <summary>Compares the current <see cref="T:System.Tuple`4" /> object to a specified object and returns an integer that indicates whether the current object is before, after, or in the same position as the specified object in the sort order.</summary>
		/// <param name="obj">An object to compare with the current instance.</param>
		/// <returns>A signed integer that indicates the relative position of this instance and <paramref name="obj" /> in the sort order, as shown in the following table.ValueDescriptionA negative integerThis instance precedes <paramref name="obj" />.ZeroThis instance and <paramref name="obj" /> have the same position in the sort order.A positive integerThis instance follows <paramref name="obj" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="obj" /> is not a <see cref="T:System.Tuple`4" /> object.</exception>
		// Token: 0x060009AF RID: 2479 RVA: 0x00029DBE File Offset: 0x00027FBE
		int IComparable.CompareTo(object obj)
		{
			return ((IStructuralComparable)this).CompareTo(obj, Comparer<object>.Default);
		}

		/// <summary>Compares the current <see cref="T:System.Tuple`4" /> object to a specified object by using a specified comparer and returns an integer that indicates whether the current object is before, after, or in the same position as the specified object in the sort order.</summary>
		/// <param name="other">An object to compare with the current instance.</param>
		/// <param name="comparer">An object that provides custom rules for comparison.</param>
		/// <returns>A signed integer that indicates the relative position of this instance and <paramref name="other" /> in the sort order, as shown in the following table.ValueDescriptionA negative integerThis instance precedes <paramref name="other" />.ZeroThis instance and <paramref name="other" /> have the same position in the sort order.A positive integerThis instance follows <paramref name="other" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="other" /> is not a <see cref="T:System.Tuple`4" /> object.</exception>
		// Token: 0x060009B0 RID: 2480 RVA: 0x0002A1E4 File Offset: 0x000283E4
		int IStructuralComparable.CompareTo(object other, IComparer comparer)
		{
			if (other == null)
			{
				return 1;
			}
			Tuple<T1, T2, T3, T4> tuple = other as Tuple<T1, T2, T3, T4>;
			if (tuple == null)
			{
				throw new ArgumentException(SR.Format("Argument must be of type {0}.", base.GetType().ToString()), "other");
			}
			int num = comparer.Compare(this.m_Item1, tuple.m_Item1);
			if (num != 0)
			{
				return num;
			}
			num = comparer.Compare(this.m_Item2, tuple.m_Item2);
			if (num != 0)
			{
				return num;
			}
			num = comparer.Compare(this.m_Item3, tuple.m_Item3);
			if (num != 0)
			{
				return num;
			}
			return comparer.Compare(this.m_Item4, tuple.m_Item4);
		}

		/// <summary>Returns the hash code for the current <see cref="T:System.Tuple`4" /> object.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		// Token: 0x060009B1 RID: 2481 RVA: 0x00029E48 File Offset: 0x00028048
		public override int GetHashCode()
		{
			return ((IStructuralEquatable)this).GetHashCode(EqualityComparer<object>.Default);
		}

		/// <summary>Calculates the hash code for the current <see cref="T:System.Tuple`4" /> object by using a specified computation method.</summary>
		/// <param name="comparer">An object whose <see cref="M:System.Collections.IEqualityComparer.GetHashCode(System.Object)" />  method calculates the hash code of the current <see cref="T:System.Tuple`4" /> object.</param>
		/// <returns>A 32-bit signed integer hash code.</returns>
		// Token: 0x060009B2 RID: 2482 RVA: 0x0002A2A4 File Offset: 0x000284A4
		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
		{
			return Tuple.CombineHashCodes(comparer.GetHashCode(this.m_Item1), comparer.GetHashCode(this.m_Item2), comparer.GetHashCode(this.m_Item3), comparer.GetHashCode(this.m_Item4));
		}

		/// <summary>Returns a string that represents the value of this <see cref="T:System.Tuple`4" /> instance.</summary>
		/// <returns>The string representation of this <see cref="T:System.Tuple`4" /> object.</returns>
		// Token: 0x060009B3 RID: 2483 RVA: 0x0002A2FC File Offset: 0x000284FC
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append('(');
			return ((ITupleInternal)this).ToString(stringBuilder);
		}

		// Token: 0x060009B4 RID: 2484 RVA: 0x0002A320 File Offset: 0x00028520
		string ITupleInternal.ToString(StringBuilder sb)
		{
			sb.Append(this.m_Item1);
			sb.Append(", ");
			sb.Append(this.m_Item2);
			sb.Append(", ");
			sb.Append(this.m_Item3);
			sb.Append(", ");
			sb.Append(this.m_Item4);
			sb.Append(')');
			return sb.ToString();
		}

		/// <summary>Gets the number of elements in the <see langword="Tuple" />. </summary>
		/// <returns>4, the number of elements in a <see cref="T:System.Tuple`4" /> object. </returns>
		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060009B5 RID: 2485 RVA: 0x0000F994 File Offset: 0x0000DB94
		int ITuple.Length
		{
			get
			{
				return 4;
			}
		}

		// Token: 0x04000386 RID: 902
		private readonly T1 m_Item1;

		// Token: 0x04000387 RID: 903
		private readonly T2 m_Item2;

		// Token: 0x04000388 RID: 904
		private readonly T3 m_Item3;

		// Token: 0x04000389 RID: 905
		private readonly T4 m_Item4;
	}
}
