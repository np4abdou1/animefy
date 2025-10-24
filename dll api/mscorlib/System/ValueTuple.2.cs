using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System
{
	/// <summary>Represents a value tuple with a single component. </summary>
	/// <typeparam name="T1">The type of the value tuple's only element. </typeparam>
	// Token: 0x0200011A RID: 282
	[Serializable]
	public struct ValueTuple<T1> : IEquatable<ValueTuple<T1>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple<T1>>, IValueTupleInternal, ITuple
	{
		/// <summary>Initializes a new <see cref="T:System.ValueTuple`1" /> instance. </summary>
		/// <param name="item1">The value tuple's first element. </param>
		// Token: 0x06000AD4 RID: 2772 RVA: 0x0002BB35 File Offset: 0x00029D35
		public ValueTuple(T1 item1)
		{
			this.Item1 = item1;
		}

		/// <summary>Returns a value that indicates whether the current <see cref="T:System.ValueTuple`1" /> instance is equal to a specified object.</summary>
		/// <param name="obj">The object to compare with this instance.</param>
		/// <returns>
		///     <see langword="true" /> if the current instance is equal to the specified object; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000AD5 RID: 2773 RVA: 0x0002BB3E File Offset: 0x00029D3E
		public override bool Equals(object obj)
		{
			return obj is ValueTuple<T1> && this.Equals((ValueTuple<T1>)obj);
		}

		/// <summary>Returns a value that indicates whether the current <see cref="T:System.ValueTuple`1" /> instance is equal to a specified <see cref="T:System.ValueTuple`1" /> instance.</summary>
		/// <param name="other">The value tuple to compare with this instance.</param>
		/// <returns>
		///     <see langword="true" /> if the current instance is equal to the specified tuple; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000AD6 RID: 2774 RVA: 0x0002BB56 File Offset: 0x00029D56
		public bool Equals(ValueTuple<T1> other)
		{
			return EqualityComparer<T1>.Default.Equals(this.Item1, other.Item1);
		}

		/// <summary>Returns a value that indicates whether the current <see cref="T:System.ValueTuple`1" /> instance is equal to a specified object based on a specified comparison method. </summary>
		/// <param name="other">The object to compare with this instance. </param>
		/// <param name="comparer">An object that defines the method to use to evaluate whether the two objects are equal. </param>
		/// <returns>
		///     <see langword="true" /> if the current instance is equal to the specified object; otherwise, <see langword="false" />. </returns>
		// Token: 0x06000AD7 RID: 2775 RVA: 0x0002BB70 File Offset: 0x00029D70
		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
		{
			if (other == null || !(other is ValueTuple<T1>))
			{
				return false;
			}
			ValueTuple<T1> valueTuple = (ValueTuple<T1>)other;
			return comparer.Equals(this.Item1, valueTuple.Item1);
		}

		/// <summary>Compares the current <see cref="T:System.ValueTuple`1" /> instance to a specified object by using a specified comparer and returns an integer that indicates whether the current object is before, after, or in the same position as the specified object in the sort order. </summary>
		/// <param name="other">The object to compare with the current instance. </param>
		/// <returns>A signed integer that indicates the relative position of this instance and <paramref name="obj" /> in the sort order, as shown in the following table.ValueDescriptionA negative integerThis instance precedes <paramref name="other" />.ZeroThis instance and <paramref name="other" /> have the same position in the sort order.A positive integerThis instance follows <paramref name="other" />.</returns>
		// Token: 0x06000AD8 RID: 2776 RVA: 0x0002BBB0 File Offset: 0x00029DB0
		int IComparable.CompareTo(object other)
		{
			if (other == null)
			{
				return 1;
			}
			if (!(other is ValueTuple<T1>))
			{
				throw new ArgumentException(SR.Format("Argument must be of type {0}.", base.GetType().ToString()), "other");
			}
			ValueTuple<T1> valueTuple = (ValueTuple<T1>)other;
			return Comparer<T1>.Default.Compare(this.Item1, valueTuple.Item1);
		}

		/// <summary>Compares the current <see cref="T:System.ValueTuple`1" /> instance to a specified <see cref="T:System.ValueTuple`1" /> instance.</summary>
		/// <param name="other">The tuple to compare with this instance.</param>
		/// <returns>A signed integer that indicates the relative position of this instance and 
		///               <paramref name="other" /> in the sort order, as shown in the following able. 
		///           VaueDescriptionA negative integerThis instance precedes 
		///                               <paramref name="other" />. 
		///                           ZeroThis instance and 
		///                               <paramref name="other" /> have the same position in the sort order.
		///                           A positive integerThis instance follows 
		///                               <paramref name="other" />. 
		///                           </returns>
		// Token: 0x06000AD9 RID: 2777 RVA: 0x0002BC11 File Offset: 0x00029E11
		public int CompareTo(ValueTuple<T1> other)
		{
			return Comparer<T1>.Default.Compare(this.Item1, other.Item1);
		}

		/// <summary>Compares the current <see cref="T:System.ValueTuple`1" /> instance to a specified object by using a specified comparer and returns an integer that indicates whether the current object is before, after, or in the same position as the specified object in the sort order. </summary>
		/// <param name="other">The object to compare with the current instance. </param>
		/// <param name="comparer">An object that provides custom rules for comparison. </param>
		/// <returns>A signed integer that indicates the relative position of this instance and <paramref name="other" /> in the sort order, as shown in the following able. VaueDescriptionA negative integerThis instance precedes <paramref name="other" />. ZeroThis instance and <paramref name="other" /> have the same position in the sort order.A positive integerThis instance follows <paramref name="other" />. </returns>
		// Token: 0x06000ADA RID: 2778 RVA: 0x0002BC2C File Offset: 0x00029E2C
		int IStructuralComparable.CompareTo(object other, IComparer comparer)
		{
			if (other == null)
			{
				return 1;
			}
			if (!(other is ValueTuple<T1>))
			{
				throw new ArgumentException(SR.Format("Argument must be of type {0}.", base.GetType().ToString()), "other");
			}
			ValueTuple<T1> valueTuple = (ValueTuple<T1>)other;
			return comparer.Compare(this.Item1, valueTuple.Item1);
		}

		/// <summary>Calculates the hash code for the current <see cref="T:System.ValueTuple`1" /> instance.</summary>
		/// <returns>The hash code for the current <see cref="T:System.ValueTuple`1" /> instance.</returns>
		// Token: 0x06000ADB RID: 2779 RVA: 0x0002BC94 File Offset: 0x00029E94
		public override int GetHashCode()
		{
			ref T1 ptr = ref this.Item1;
			T1 t = default(T1);
			if (t == null)
			{
				t = this.Item1;
				ptr = ref t;
				if (t == null)
				{
					return 0;
				}
			}
			return ptr.GetHashCode();
		}

		/// <summary>Calculates the hash code for the current <see cref="T:System.ValueTuple`1" /> instance by using a specified computation method. </summary>
		/// <param name="comparer">An object whose <see cref="M:System.Collections.IEqualityComparer.GetHashCode(System.Object)" /> method calculates the hash code of the current <see cref="T:System.ValueTuple`1" /> instance. </param>
		/// <returns>A 32-bit signed integer hash code. </returns>
		// Token: 0x06000ADC RID: 2780 RVA: 0x0002BCD5 File Offset: 0x00029ED5
		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
		{
			return comparer.GetHashCode(this.Item1);
		}

		// Token: 0x06000ADD RID: 2781 RVA: 0x0002BCD5 File Offset: 0x00029ED5
		int IValueTupleInternal.GetHashCode(IEqualityComparer comparer)
		{
			return comparer.GetHashCode(this.Item1);
		}

		/// <summary>Returns a string that represents the value of this <see cref="T:System.ValueTuple`1" /> instance. </summary>
		/// <returns>The string representation of this <see cref="T:System.ValueTuple`1" /> instance. </returns>
		// Token: 0x06000ADE RID: 2782 RVA: 0x0002BCE8 File Offset: 0x00029EE8
		public override string ToString()
		{
			string str = "(";
			ref T1 ptr = ref this.Item1;
			T1 t = default(T1);
			string str2;
			if (t == null)
			{
				t = this.Item1;
				ptr = ref t;
				if (t == null)
				{
					str2 = null;
					goto IL_3A;
				}
			}
			str2 = ptr.ToString();
			IL_3A:
			return str + str2 + ")";
		}

		// Token: 0x06000ADF RID: 2783 RVA: 0x0002BD3C File Offset: 0x00029F3C
		string IValueTupleInternal.ToStringEnd()
		{
			ref T1 ptr = ref this.Item1;
			T1 t = default(T1);
			string str;
			if (t == null)
			{
				t = this.Item1;
				ptr = ref t;
				if (t == null)
				{
					str = null;
					goto IL_35;
				}
			}
			str = ptr.ToString();
			IL_35:
			return str + ")";
		}

		/// <summary>Gets the number of elements in the <see langword="ValueTuple" />.</summary>
		/// <returns>1, the number of elements in a <see cref="T:System.ValueTuple`1" /> object. </returns>
		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000AE0 RID: 2784 RVA: 0x0000B18D File Offset: 0x0000938D
		int ITuple.Length
		{
			get
			{
				return 1;
			}
		}

		/// <summary>Gets the value of the current <see cref="T:System.ValueTuple`1" /> instance's first element. </summary>
		/// <returns>The value of the current <see cref="T:System.ValueTuple`1" /> instance's first element. </returns>
		// Token: 0x040003AB RID: 939
		public T1 Item1;
	}
}
