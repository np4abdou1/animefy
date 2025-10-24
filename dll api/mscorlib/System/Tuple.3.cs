using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace System
{
	/// <summary>Represents a 3-tuple, or triple. </summary>
	/// <typeparam name="T1">The type of the tuple's first component.</typeparam>
	/// <typeparam name="T2">The type of the tuple's second component.</typeparam>
	/// <typeparam name="T3">The type of the tuple's third component.</typeparam>
	// Token: 0x0200010C RID: 268
	[Serializable]
	public class Tuple<T1, T2, T3> : IStructuralEquatable, IStructuralComparable, IComparable, ITupleInternal, ITuple
	{
		/// <summary>Gets the value of the current <see cref="T:System.Tuple`3" /> object's first component.</summary>
		/// <returns>The value of the current <see cref="T:System.Tuple`3" /> object's first component.</returns>
		// Token: 0x1700009F RID: 159
		// (get) Token: 0x0600099B RID: 2459 RVA: 0x00029EF0 File Offset: 0x000280F0
		public T1 Item1
		{
			get
			{
				return this.m_Item1;
			}
		}

		/// <summary>Gets the value of the current <see cref="T:System.Tuple`3" /> object's second component.</summary>
		/// <returns>The value of the current <see cref="T:System.Tuple`3" /> object's second component.</returns>
		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x0600099C RID: 2460 RVA: 0x00029EF8 File Offset: 0x000280F8
		public T2 Item2
		{
			get
			{
				return this.m_Item2;
			}
		}

		/// <summary>Gets the value of the current <see cref="T:System.Tuple`3" /> object's third component.</summary>
		/// <returns>The value of the current <see cref="T:System.Tuple`3" /> object's third component.</returns>
		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600099D RID: 2461 RVA: 0x00029F00 File Offset: 0x00028100
		public T3 Item3
		{
			get
			{
				return this.m_Item3;
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Tuple`3" /> class.</summary>
		/// <param name="item1">The value of the tuple's first component.</param>
		/// <param name="item2">The value of the tuple's second component.</param>
		/// <param name="item3">The value of the tuple's third component.</param>
		// Token: 0x0600099E RID: 2462 RVA: 0x00029F08 File Offset: 0x00028108
		public Tuple(T1 item1, T2 item2, T3 item3)
		{
			this.m_Item1 = item1;
			this.m_Item2 = item2;
			this.m_Item3 = item3;
		}

		/// <summary>Returns a value that indicates whether the current <see cref="T:System.Tuple`3" /> object is equal to a specified object.</summary>
		/// <param name="obj">The object to compare with this instance.</param>
		/// <returns>
		///     <see langword="true" /> if the current instance is equal to the specified object; otherwise, <see langword="false" />.</returns>
		// Token: 0x0600099F RID: 2463 RVA: 0x00029D54 File Offset: 0x00027F54
		public override bool Equals(object obj)
		{
			return ((IStructuralEquatable)this).Equals(obj, EqualityComparer<object>.Default);
		}

		/// <summary>Returns a value that indicates whether the current <see cref="T:System.Tuple`3" /> object is equal to a specified object based on a specified comparison method.</summary>
		/// <param name="other">The object to compare with this instance.</param>
		/// <param name="comparer">An object that defines the method to use to evaluate whether the two objects are equal.</param>
		/// <returns>
		///     <see langword="true" /> if the current instance is equal to the specified object; otherwise, <see langword="false" />.</returns>
		// Token: 0x060009A0 RID: 2464 RVA: 0x00029F28 File Offset: 0x00028128
		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
		{
			if (other == null)
			{
				return false;
			}
			Tuple<T1, T2, T3> tuple = other as Tuple<T1, T2, T3>;
			return tuple != null && (comparer.Equals(this.m_Item1, tuple.m_Item1) && comparer.Equals(this.m_Item2, tuple.m_Item2)) && comparer.Equals(this.m_Item3, tuple.m_Item3);
		}

		/// <summary>Compares the current <see cref="T:System.Tuple`3" /> object to a specified object and returns an integer that indicates whether the current object is before, after, or in the same position as the specified object in the sort order.</summary>
		/// <param name="obj">An object to compare with the current instance.</param>
		/// <returns>A signed integer that indicates the relative position of this instance and <paramref name="obj" /> in the sort order, as shown in the following table.ValueDescriptionA negative integerThis instance precedes <paramref name="obj" />.ZeroThis instance and <paramref name="obj" /> have the same position in the sort order.A positive integerThis instance follows <paramref name="obj" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="obj" /> is not a <see cref="T:System.Tuple`3" /> object.</exception>
		// Token: 0x060009A1 RID: 2465 RVA: 0x00029DBE File Offset: 0x00027FBE
		int IComparable.CompareTo(object obj)
		{
			return ((IStructuralComparable)this).CompareTo(obj, Comparer<object>.Default);
		}

		/// <summary>Compares the current <see cref="T:System.Tuple`3" /> object to a specified object by using a specified comparer, and returns an integer that indicates whether the current object is before, after, or in the same position as the specified object in the sort order.</summary>
		/// <param name="other">An object to compare with the current instance.</param>
		/// <param name="comparer">An object that provides custom rules for comparison.</param>
		/// <returns>A signed integer that indicates the relative position of this instance and <paramref name="other" /> in the sort order, as shown in the following table.ValueDescriptionA negative integerThis instance precedes <paramref name="other" />.ZeroThis instance and <paramref name="other" /> have the same position in the sort order.A positive integerThis instance follows <paramref name="other" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="other" /> is not a <see cref="T:System.Tuple`3" /> object.</exception>
		// Token: 0x060009A2 RID: 2466 RVA: 0x00029FA0 File Offset: 0x000281A0
		int IStructuralComparable.CompareTo(object other, IComparer comparer)
		{
			if (other == null)
			{
				return 1;
			}
			Tuple<T1, T2, T3> tuple = other as Tuple<T1, T2, T3>;
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
			return comparer.Compare(this.m_Item3, tuple.m_Item3);
		}

		/// <summary>Returns the hash code for the current <see cref="T:System.Tuple`3" /> object.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		// Token: 0x060009A3 RID: 2467 RVA: 0x00029E48 File Offset: 0x00028048
		public override int GetHashCode()
		{
			return ((IStructuralEquatable)this).GetHashCode(EqualityComparer<object>.Default);
		}

		/// <summary>Calculates the hash code for the current <see cref="T:System.Tuple`3" /> object by using a specified computation method.</summary>
		/// <param name="comparer">An object whose <see cref="M:System.Collections.IEqualityComparer.GetHashCode(System.Object)" />  method calculates the hash code of the current <see cref="T:System.Tuple`3" /> object.</param>
		/// <returns>A 32-bit signed integer hash code.</returns>
		// Token: 0x060009A4 RID: 2468 RVA: 0x0002A03E File Offset: 0x0002823E
		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
		{
			return Tuple.CombineHashCodes(comparer.GetHashCode(this.m_Item1), comparer.GetHashCode(this.m_Item2), comparer.GetHashCode(this.m_Item3));
		}

		/// <summary>Returns a string that represents the value of this <see cref="T:System.Tuple`3" /> instance.</summary>
		/// <returns>The string representation of this <see cref="T:System.Tuple`3" /> object.</returns>
		// Token: 0x060009A5 RID: 2469 RVA: 0x0002A078 File Offset: 0x00028278
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append('(');
			return ((ITupleInternal)this).ToString(stringBuilder);
		}

		// Token: 0x060009A6 RID: 2470 RVA: 0x0002A09C File Offset: 0x0002829C
		string ITupleInternal.ToString(StringBuilder sb)
		{
			sb.Append(this.m_Item1);
			sb.Append(", ");
			sb.Append(this.m_Item2);
			sb.Append(", ");
			sb.Append(this.m_Item3);
			sb.Append(')');
			return sb.ToString();
		}

		/// <summary>Gets the number of elements in the <see langword="Tuple" />. </summary>
		/// <returns>3, the number of elements in a <see cref="T:System.Tuple`3" /> object. </returns>
		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060009A7 RID: 2471 RVA: 0x0000F43A File Offset: 0x0000D63A
		int ITuple.Length
		{
			get
			{
				return 3;
			}
		}

		// Token: 0x04000383 RID: 899
		private readonly T1 m_Item1;

		// Token: 0x04000384 RID: 900
		private readonly T2 m_Item2;

		// Token: 0x04000385 RID: 901
		private readonly T3 m_Item3;
	}
}
