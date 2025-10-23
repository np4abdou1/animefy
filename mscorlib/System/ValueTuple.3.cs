using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System
{
	/// <summary>Represents a value tuple with 2 components. </summary>
	/// <typeparam name="T1">The type of the value tuple's first element. </typeparam>
	/// <typeparam name="T2">The type of the value tuple's second element. </typeparam>
	// Token: 0x0200011B RID: 283
	[Serializable]
	[StructLayout(3)]
	public struct ValueTuple<T1, T2> : IEquatable<ValueTuple<T1, T2>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple<T1, T2>>, IValueTupleInternal, ITuple
	{
		/// <summary>Initializes a new <see cref="T:System.ValueTuple`2" /> instance. </summary>
		/// <param name="item1">The value tuple's first element. </param>
		/// <param name="item2">The value tuple's second element. </param>
		// Token: 0x06000AE1 RID: 2785 RVA: 0x0002BD88 File Offset: 0x00029F88
		public ValueTuple(T1 item1, T2 item2)
		{
			this.Item1 = item1;
			this.Item2 = item2;
		}

		/// <summary>Returns a value that indicates whether the current <see cref="T:System.ValueTuple`2" /> instance is equal to a specified object.</summary>
		/// <param name="obj">The object to compare with this instance.</param>
		/// <returns>
		///     <see langword="true" /> if the current instance is equal to the specified object; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000AE2 RID: 2786 RVA: 0x0002BD98 File Offset: 0x00029F98
		public override bool Equals(object obj)
		{
			return obj is ValueTuple<T1, T2> && this.Equals((ValueTuple<T1, T2>)obj);
		}

		/// <summary>Returns a value that indicates whether the current <see cref="T:System.ValueTuple`2" /> instance is equal to a specified <see cref="T:System.ValueTuple`2" /> instance.</summary>
		/// <param name="other">The value tuple to compare with this instance.</param>
		/// <returns>
		///     <see langword="true" /> if the current instance is equal to the specified tuple; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000AE3 RID: 2787 RVA: 0x0002BDB0 File Offset: 0x00029FB0
		public bool Equals(ValueTuple<T1, T2> other)
		{
			return EqualityComparer<T1>.Default.Equals(this.Item1, other.Item1) && EqualityComparer<T2>.Default.Equals(this.Item2, other.Item2);
		}

		/// <summary>Returns a value that indicates whether the current <see cref="T:System.ValueTuple`2" /> instance is equal to a specified object based on a specified comparison method. </summary>
		/// <param name="other">The object to compare with this instance. </param>
		/// <param name="comparer">An object that defines the method to use to evaluate whether the two objects are equal. </param>
		/// <returns>
		///     <see langword="true" /> if the current instance is equal to the specified objects; otherwise, <see langword="false" />. </returns>
		// Token: 0x06000AE4 RID: 2788 RVA: 0x0002BDE4 File Offset: 0x00029FE4
		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
		{
			if (other == null || !(other is ValueTuple<T1, T2>))
			{
				return false;
			}
			ValueTuple<T1, T2> valueTuple = (ValueTuple<T1, T2>)other;
			return comparer.Equals(this.Item1, valueTuple.Item1) && comparer.Equals(this.Item2, valueTuple.Item2);
		}

		/// <summary>Compares the current <see cref="T:System.ValueTuple`2" /> instance to a specified object by using a specified comparer and returns an integer that indicates whether the current object is before, after, or in the same position as the specified object in the sort order. </summary>
		/// <param name="other">The object to compare with the current instance. </param>
		/// <returns>A signed integer that indicates the relative position of this instance and <paramref name="obj" /> in the sort order, as shown in the following table.ValueDescriptionA negative integerThis instance precedes <paramref name="other" />.ZeroThis instance and <paramref name="other" /> have the same position in the sort order.A positive integerThis instance follows <paramref name="other" />.</returns>
		// Token: 0x06000AE5 RID: 2789 RVA: 0x0002BE44 File Offset: 0x0002A044
		int IComparable.CompareTo(object other)
		{
			if (other == null)
			{
				return 1;
			}
			if (!(other is ValueTuple<T1, T2>))
			{
				throw new ArgumentException(SR.Format("Argument must be of type {0}.", base.GetType().ToString()), "other");
			}
			return this.CompareTo((ValueTuple<T1, T2>)other);
		}

		/// <summary>Compares the current <see cref="T:System.ValueTuple`2" /> instance to a specified <see cref="T:System.ValueTuple`2" /> instance.</summary>
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
		// Token: 0x06000AE6 RID: 2790 RVA: 0x0002BE94 File Offset: 0x0002A094
		public int CompareTo(ValueTuple<T1, T2> other)
		{
			int num = Comparer<T1>.Default.Compare(this.Item1, other.Item1);
			if (num != 0)
			{
				return num;
			}
			return Comparer<T2>.Default.Compare(this.Item2, other.Item2);
		}

		/// <summary>Compares the current <see cref="T:System.ValueTuple`2" /> instance to a specified object by using a specified comparer and returns an integer that indicates whether the current object is before, after, or in the same position as the specified object in the sort order. </summary>
		/// <param name="other">The object to compare with the current instance. </param>
		/// <param name="comparer">An object that provides custom rules for comparison. </param>
		/// <returns>A signed integer that indicates the relative position of this instance and <paramref name="other" /> in the sort order, as shown in the following able. VaueDescriptionA negative integerThis instance precedes <paramref name="other" />. ZeroThis instance and <paramref name="other" /> have the same position in the sort order.A positive integerThis instance follows <paramref name="other" />. </returns>
		// Token: 0x06000AE7 RID: 2791 RVA: 0x0002BED4 File Offset: 0x0002A0D4
		int IStructuralComparable.CompareTo(object other, IComparer comparer)
		{
			if (other == null)
			{
				return 1;
			}
			if (!(other is ValueTuple<T1, T2>))
			{
				throw new ArgumentException(SR.Format("Argument must be of type {0}.", base.GetType().ToString()), "other");
			}
			ValueTuple<T1, T2> valueTuple = (ValueTuple<T1, T2>)other;
			int num = comparer.Compare(this.Item1, valueTuple.Item1);
			if (num != 0)
			{
				return num;
			}
			return comparer.Compare(this.Item2, valueTuple.Item2);
		}

		/// <summary>Calculates the hash code for the current <see cref="T:System.ValueTuple`2" /> instance.</summary>
		/// <returns>The hash code for the current <see cref="T:System.ValueTuple`2" /> instance. </returns>
		// Token: 0x06000AE8 RID: 2792 RVA: 0x0002BF60 File Offset: 0x0002A160
		public override int GetHashCode()
		{
			ref T1 ptr = ref this.Item1;
			T1 t = default(T1);
			int h;
			if (t == null)
			{
				t = this.Item1;
				ptr = ref t;
				if (t == null)
				{
					h = 0;
					goto IL_35;
				}
			}
			h = ptr.GetHashCode();
			IL_35:
			ref T2 ptr2 = ref this.Item2;
			T2 t2 = default(T2);
			int h2;
			if (t2 == null)
			{
				t2 = this.Item2;
				ptr2 = ref t2;
				if (t2 == null)
				{
					h2 = 0;
					goto IL_6A;
				}
			}
			h2 = ptr2.GetHashCode();
			IL_6A:
			return ValueTuple.CombineHashCodes(h, h2);
		}

		/// <summary>Calculates the hash code for the current <see cref="T:System.ValueTuple`2" /> instance by using a specified computation method. </summary>
		/// <param name="comparer">An object whose <see cref="M:System.Collections.IEqualityComparer.GetHashCode(System.Object)" /> method calculates the hash code of the current <see cref="T:System.ValueTuple`2" /> instance. </param>
		/// <returns>A 32-bit signed integer hash code. </returns>
		// Token: 0x06000AE9 RID: 2793 RVA: 0x0002BFDC File Offset: 0x0002A1DC
		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
		{
			return this.GetHashCodeCore(comparer);
		}

		// Token: 0x06000AEA RID: 2794 RVA: 0x0002BFE5 File Offset: 0x0002A1E5
		private int GetHashCodeCore(IEqualityComparer comparer)
		{
			return ValueTuple.CombineHashCodes(comparer.GetHashCode(this.Item1), comparer.GetHashCode(this.Item2));
		}

		// Token: 0x06000AEB RID: 2795 RVA: 0x0002BFDC File Offset: 0x0002A1DC
		int IValueTupleInternal.GetHashCode(IEqualityComparer comparer)
		{
			return this.GetHashCodeCore(comparer);
		}

		/// <summary>Returns a string that represents the value of this <see cref="T:System.ValueTuple`2" /> instance. </summary>
		/// <returns>The string representation of this <see cref="T:System.ValueTuple`2" /> instance. </returns>
		// Token: 0x06000AEC RID: 2796 RVA: 0x0002C010 File Offset: 0x0002A210
		public override string ToString()
		{
			string[] array = new string[5];
			array[0] = "(";
			int num = 1;
			ref T1 ptr = ref this.Item1;
			T1 t = default(T1);
			string text;
			if (t == null)
			{
				t = this.Item1;
				ptr = ref t;
				if (t == null)
				{
					text = null;
					goto IL_45;
				}
			}
			text = ptr.ToString();
			IL_45:
			array[num] = text;
			array[2] = ", ";
			int num2 = 3;
			ref T2 ptr2 = ref this.Item2;
			T2 t2 = default(T2);
			string text2;
			if (t2 == null)
			{
				t2 = this.Item2;
				ptr2 = ref t2;
				if (t2 == null)
				{
					text2 = null;
					goto IL_85;
				}
			}
			text2 = ptr2.ToString();
			IL_85:
			array[num2] = text2;
			array[4] = ")";
			return string.Concat(array);
		}

		// Token: 0x06000AED RID: 2797 RVA: 0x0002C0B0 File Offset: 0x0002A2B0
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
			string str2 = ", ";
			ref T2 ptr2 = ref this.Item2;
			T2 t2 = default(T2);
			string str3;
			if (t2 == null)
			{
				t2 = this.Item2;
				ptr2 = ref t2;
				if (t2 == null)
				{
					str3 = null;
					goto IL_6F;
				}
			}
			str3 = ptr2.ToString();
			IL_6F:
			return str + str2 + str3 + ")";
		}

		/// <summary>Gets the number of elements in the <see langword="ValueTuple" />.</summary>
		/// <returns>2, the number of elements in a <see cref="T:System.ValueTuple`2" /> object. </returns>
		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000AEE RID: 2798 RVA: 0x0000E0F3 File Offset: 0x0000C2F3
		int ITuple.Length
		{
			get
			{
				return 2;
			}
		}

		/// <summary>Gets the value of the current <see cref="T:System.ValueTuple`2" /> instance's first element. </summary>
		/// <returns>The value of the current <see cref="T:System.ValueTuple`2" /> instance's first element. </returns>
		// Token: 0x040003AC RID: 940
		public T1 Item1;

		/// <summary>Gets the value of the current <see cref="T:System.ValueTuple`2" /> instance's second element. </summary>
		/// <returns>The value of the current <see cref="T:System.ValueTuple`2" /> instance's second element. </returns>
		// Token: 0x040003AD RID: 941
		public T2 Item2;
	}
}
