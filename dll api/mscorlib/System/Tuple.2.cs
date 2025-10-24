using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace System
{
	/// <summary>Represents a 2-tuple, or pair. </summary>
	/// <typeparam name="T1">The type of the tuple's first component.</typeparam>
	/// <typeparam name="T2">The type of the tuple's second component.</typeparam>
	// Token: 0x0200010B RID: 267
	[Serializable]
	public class Tuple<T1, T2> : IStructuralEquatable, IStructuralComparable, IComparable, ITupleInternal, ITuple
	{
		/// <summary>Gets the value of the current <see cref="T:System.Tuple`2" /> object's first component.</summary>
		/// <returns>The value of the current <see cref="T:System.Tuple`2" /> object's first component.</returns>
		// Token: 0x1700009C RID: 156
		// (get) Token: 0x0600098F RID: 2447 RVA: 0x00029D2E File Offset: 0x00027F2E
		public T1 Item1
		{
			get
			{
				return this.m_Item1;
			}
		}

		/// <summary>Gets the value of the current <see cref="T:System.Tuple`2" /> object's second component.</summary>
		/// <returns>The value of the current <see cref="T:System.Tuple`2" /> object's second component.</returns>
		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000990 RID: 2448 RVA: 0x00029D36 File Offset: 0x00027F36
		public T2 Item2
		{
			get
			{
				return this.m_Item2;
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Tuple`2" /> class.</summary>
		/// <param name="item1">The value of the tuple's first component.</param>
		/// <param name="item2">The value of the tuple's second component.</param>
		// Token: 0x06000991 RID: 2449 RVA: 0x00029D3E File Offset: 0x00027F3E
		public Tuple(T1 item1, T2 item2)
		{
			this.m_Item1 = item1;
			this.m_Item2 = item2;
		}

		/// <summary>Returns a value that indicates whether the current <see cref="T:System.Tuple`2" /> object is equal to a specified object.</summary>
		/// <param name="obj">The object to compare with this instance.</param>
		/// <returns>
		///     <see langword="true" /> if the current instance is equal to the specified object; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000992 RID: 2450 RVA: 0x00029D54 File Offset: 0x00027F54
		public override bool Equals(object obj)
		{
			return ((IStructuralEquatable)this).Equals(obj, EqualityComparer<object>.Default);
		}

		/// <summary>Returns a value that indicates whether the current <see cref="T:System.Tuple`2" /> object is equal to a specified object based on a specified comparison method.</summary>
		/// <param name="other">The object to compare with this instance.</param>
		/// <param name="comparer">An object that defines the method to use to evaluate whether the two objects are equal.</param>
		/// <returns>
		///     <see langword="true" /> if the current instance is equal to the specified object; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000993 RID: 2451 RVA: 0x00029D64 File Offset: 0x00027F64
		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
		{
			if (other == null)
			{
				return false;
			}
			Tuple<T1, T2> tuple = other as Tuple<T1, T2>;
			return tuple != null && comparer.Equals(this.m_Item1, tuple.m_Item1) && comparer.Equals(this.m_Item2, tuple.m_Item2);
		}

		/// <summary>Compares the current <see cref="T:System.Tuple`2" /> object to a specified object and returns an integer that indicates whether the current object is before, after, or in the same position as the specified object in the sort order.</summary>
		/// <param name="obj">An object to compare with the current instance.</param>
		/// <returns>A signed integer that indicates the relative position of this instance and <paramref name="obj" /> in the sort order, as shown in the following table.ValueDescriptionA negative integerThis instance precedes <paramref name="obj" />.ZeroThis instance and <paramref name="obj" /> have the same position in the sort order.A positive integerThis instance follows <paramref name="obj" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="obj" /> is not a <see cref="T:System.Tuple`2" /> object.</exception>
		// Token: 0x06000994 RID: 2452 RVA: 0x00029DBE File Offset: 0x00027FBE
		int IComparable.CompareTo(object obj)
		{
			return ((IStructuralComparable)this).CompareTo(obj, Comparer<object>.Default);
		}

		/// <summary>Compares the current <see cref="T:System.Tuple`2" /> object to a specified object by using a specified comparer, and returns an integer that indicates whether the current object is before, after, or in the same position as the specified object in the sort order.</summary>
		/// <param name="other">An object to compare with the current instance.</param>
		/// <param name="comparer">An object that provides custom rules for comparison.</param>
		/// <returns>A signed integer that indicates the relative position of this instance and <paramref name="other" /> in the sort order, as shown in the following table.ValueDescriptionA negative integerThis instance precedes <paramref name="other" />.ZeroThis instance and <paramref name="other" /> have the same position in the sort order.A positive integerThis instance follows <paramref name="other" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="other" /> is not a <see cref="T:System.Tuple`2" /> object.</exception>
		// Token: 0x06000995 RID: 2453 RVA: 0x00029DCC File Offset: 0x00027FCC
		int IStructuralComparable.CompareTo(object other, IComparer comparer)
		{
			if (other == null)
			{
				return 1;
			}
			Tuple<T1, T2> tuple = other as Tuple<T1, T2>;
			if (tuple == null)
			{
				throw new ArgumentException(SR.Format("Argument must be of type {0}.", base.GetType().ToString()), "other");
			}
			int num = comparer.Compare(this.m_Item1, tuple.m_Item1);
			if (num != 0)
			{
				return num;
			}
			return comparer.Compare(this.m_Item2, tuple.m_Item2);
		}

		/// <summary>Returns the hash code for the current <see cref="T:System.Tuple`2" /> object.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		// Token: 0x06000996 RID: 2454 RVA: 0x00029E48 File Offset: 0x00028048
		public override int GetHashCode()
		{
			return ((IStructuralEquatable)this).GetHashCode(EqualityComparer<object>.Default);
		}

		/// <summary>Calculates the hash code for the current <see cref="T:System.Tuple`2" /> object by using a specified computation method.</summary>
		/// <param name="comparer">An object whose <see cref="M:System.Collections.IEqualityComparer.GetHashCode(System.Object)" />  method calculates the hash code of the current <see cref="T:System.Tuple`2" /> object.</param>
		/// <returns>A 32-bit signed integer hash code.</returns>
		// Token: 0x06000997 RID: 2455 RVA: 0x00029E55 File Offset: 0x00028055
		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
		{
			return Tuple.CombineHashCodes(comparer.GetHashCode(this.m_Item1), comparer.GetHashCode(this.m_Item2));
		}

		/// <summary>Returns a string that represents the value of this <see cref="T:System.Tuple`2" /> instance.</summary>
		/// <returns>The string representation of this <see cref="T:System.Tuple`2" /> object.</returns>
		// Token: 0x06000998 RID: 2456 RVA: 0x00029E80 File Offset: 0x00028080
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append('(');
			return ((ITupleInternal)this).ToString(stringBuilder);
		}

		// Token: 0x06000999 RID: 2457 RVA: 0x00029EA4 File Offset: 0x000280A4
		string ITupleInternal.ToString(StringBuilder sb)
		{
			sb.Append(this.m_Item1);
			sb.Append(", ");
			sb.Append(this.m_Item2);
			sb.Append(')');
			return sb.ToString();
		}

		/// <summary>Gets the number of elements in the <see langword="Tuple" />. </summary>
		/// <returns>2, the number of elements in a <see cref="T:System.Tuple`2" /> object. </returns>
		// Token: 0x1700009E RID: 158
		// (get) Token: 0x0600099A RID: 2458 RVA: 0x0000E0F3 File Offset: 0x0000C2F3
		int ITuple.Length
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x04000381 RID: 897
		private readonly T1 m_Item1;

		// Token: 0x04000382 RID: 898
		private readonly T2 m_Item2;
	}
}
