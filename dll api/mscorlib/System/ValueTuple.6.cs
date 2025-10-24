﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System
{
	/// <summary>Represents a value tuple with 5 components. </summary>
	/// <typeparam name="T1">The type of the value tuple's first element. </typeparam>
	/// <typeparam name="T2">The type of the value tuple's second element. </typeparam>
	/// <typeparam name="T3">The type of the value tuple's third element. </typeparam>
	/// <typeparam name="T4">The type of the value tuple's fourth element. </typeparam>
	/// <typeparam name="T5">The type of the value tuple's fifth element. </typeparam>
	// Token: 0x0200011E RID: 286
	[Serializable]
	[StructLayout(3)]
	public struct ValueTuple<T1, T2, T3, T4, T5> : IEquatable<ValueTuple<T1, T2, T3, T4, T5>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple<T1, T2, T3, T4, T5>>, IValueTupleInternal, ITuple
	{
		/// <summary>Initializes a new <see cref="T:System.ValueTuple`5" /> instance. </summary>
		/// <param name="item1">The value tuple's first element. </param>
		/// <param name="item2">The value tuple's second element. </param>
		/// <param name="item3">The value tuple's third element. </param>
		/// <param name="item4">The value tuple's fourth element. </param>
		/// <param name="item5">The value tuple's fifth element. </param>
		// Token: 0x06000B0B RID: 2827 RVA: 0x0002CCA0 File Offset: 0x0002AEA0
		public ValueTuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5)
		{
			this.Item1 = item1;
			this.Item2 = item2;
			this.Item3 = item3;
			this.Item4 = item4;
			this.Item5 = item5;
		}

		/// <summary>Returns a value that indicates whether the current <see cref="T:System.ValueTuple`5" /> instance is equal to a specified object.</summary>
		/// <param name="obj">The object to compare with this instance.</param>
		/// <returns>
		///     <see langword="true" /> if the current instance is equal to the specified object; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000B0C RID: 2828 RVA: 0x0002CCC7 File Offset: 0x0002AEC7
		public override bool Equals(object obj)
		{
			return obj is ValueTuple<T1, T2, T3, T4, T5> && this.Equals((ValueTuple<T1, T2, T3, T4, T5>)obj);
		}

		/// <summary>Returns a value that indicates whether the current <see cref="T:System.ValueTuple`5" /> instance is equal to a specified <see cref="T:System.ValueTuple`5" /> instance.</summary>
		/// <param name="other">The value tuple to compare with this instance.</param>
		/// <returns>
		///     <see langword="true" /> if the current instance is equal to the specified tuple; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000B0D RID: 2829 RVA: 0x0002CCE0 File Offset: 0x0002AEE0
		public bool Equals(ValueTuple<T1, T2, T3, T4, T5> other)
		{
			return EqualityComparer<T1>.Default.Equals(this.Item1, other.Item1) && EqualityComparer<T2>.Default.Equals(this.Item2, other.Item2) && EqualityComparer<T3>.Default.Equals(this.Item3, other.Item3) && EqualityComparer<T4>.Default.Equals(this.Item4, other.Item4) && EqualityComparer<T5>.Default.Equals(this.Item5, other.Item5);
		}

		/// <summary>Returns a value that indicates whether the current <see cref="T:System.ValueTuple`5" /> instance is equal to a specified object based on a specified comparison method. </summary>
		/// <param name="other">The object to compare with this instance. </param>
		/// <param name="comparer">An object that defines the method to use to evaluate whether the two objects are equal. </param>
		/// <returns>
		///     <see langword="true" /> if the current instance is equal to the specified objects; otherwise, <see langword="false" />. </returns>
		// Token: 0x06000B0E RID: 2830 RVA: 0x0002CD68 File Offset: 0x0002AF68
		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
		{
			if (other == null || !(other is ValueTuple<T1, T2, T3, T4, T5>))
			{
				return false;
			}
			ValueTuple<T1, T2, T3, T4, T5> valueTuple = (ValueTuple<T1, T2, T3, T4, T5>)other;
			return comparer.Equals(this.Item1, valueTuple.Item1) && comparer.Equals(this.Item2, valueTuple.Item2) && comparer.Equals(this.Item3, valueTuple.Item3) && comparer.Equals(this.Item4, valueTuple.Item4) && comparer.Equals(this.Item5, valueTuple.Item5);
		}

		/// <summary>Compares the current <see cref="T:System.ValueTuple`5" /> instance to a specified object by using a specified comparer and returns an integer that indicates whether the current object is before, after, or in the same position as the specified object in the sort order. </summary>
		/// <param name="other">The object to compare with the current instance. </param>
		/// <returns>A signed integer that indicates the relative position of this instance and <paramref name="obj" /> in the sort order, as shown in the following table.ValueDescriptionA negative integerThis instance precedes <paramref name="other" />.ZeroThis instance and <paramref name="other" /> have the same position in the sort order.A positive integerThis instance follows <paramref name="other" />.</returns>
		// Token: 0x06000B0F RID: 2831 RVA: 0x0002CE20 File Offset: 0x0002B020
		int IComparable.CompareTo(object other)
		{
			if (other == null)
			{
				return 1;
			}
			if (!(other is ValueTuple<T1, T2, T3, T4, T5>))
			{
				throw new ArgumentException(SR.Format("Argument must be of type {0}.", base.GetType().ToString()), "other");
			}
			return this.CompareTo((ValueTuple<T1, T2, T3, T4, T5>)other);
		}

		/// <summary>Compares the current <see cref="T:System.ValueTuple`5" /> instance to a specified <see cref="T:System.ValueTuple`5" /> instance.</summary>
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
		// Token: 0x06000B10 RID: 2832 RVA: 0x0002CE70 File Offset: 0x0002B070
		public int CompareTo(ValueTuple<T1, T2, T3, T4, T5> other)
		{
			int num = Comparer<T1>.Default.Compare(this.Item1, other.Item1);
			if (num != 0)
			{
				return num;
			}
			num = Comparer<T2>.Default.Compare(this.Item2, other.Item2);
			if (num != 0)
			{
				return num;
			}
			num = Comparer<T3>.Default.Compare(this.Item3, other.Item3);
			if (num != 0)
			{
				return num;
			}
			num = Comparer<T4>.Default.Compare(this.Item4, other.Item4);
			if (num != 0)
			{
				return num;
			}
			return Comparer<T5>.Default.Compare(this.Item5, other.Item5);
		}

		/// <summary>Compares the current <see cref="T:System.ValueTuple`5" /> instance to a specified object by using a specified comparer and returns an integer that indicates whether the current object is before, after, or in the same position as the specified object in the sort order. </summary>
		/// <param name="other">The object to compare with the current instance. </param>
		/// <param name="comparer">An object that provides custom rules for comparison. </param>
		/// <returns>A signed integer that indicates the relative position of this instance and <paramref name="other" /> in the sort order, as shown in the following able. VaueDescriptionA negative integerThis instance precedes <paramref name="other" />. ZeroThis instance and <paramref name="other" /> have the same position in the sort order.A positive integerThis instance follows <paramref name="other" />. </returns>
		// Token: 0x06000B11 RID: 2833 RVA: 0x0002CF04 File Offset: 0x0002B104
		int IStructuralComparable.CompareTo(object other, IComparer comparer)
		{
			if (other == null)
			{
				return 1;
			}
			if (!(other is ValueTuple<T1, T2, T3, T4, T5>))
			{
				throw new ArgumentException(SR.Format("Argument must be of type {0}.", base.GetType().ToString()), "other");
			}
			ValueTuple<T1, T2, T3, T4, T5> valueTuple = (ValueTuple<T1, T2, T3, T4, T5>)other;
			int num = comparer.Compare(this.Item1, valueTuple.Item1);
			if (num != 0)
			{
				return num;
			}
			num = comparer.Compare(this.Item2, valueTuple.Item2);
			if (num != 0)
			{
				return num;
			}
			num = comparer.Compare(this.Item3, valueTuple.Item3);
			if (num != 0)
			{
				return num;
			}
			num = comparer.Compare(this.Item4, valueTuple.Item4);
			if (num != 0)
			{
				return num;
			}
			return comparer.Compare(this.Item5, valueTuple.Item5);
		}

		/// <summary>Calculates the hash code for the current <see cref="T:System.ValueTuple`5" /> instance.</summary>
		/// <returns>The hash code for the current <see cref="T:System.ValueTuple`5" /> instance. </returns>
		// Token: 0x06000B12 RID: 2834 RVA: 0x0002CFF4 File Offset: 0x0002B1F4
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
			ref T3 ptr3 = ref this.Item3;
			T3 t3 = default(T3);
			int h3;
			if (t3 == null)
			{
				t3 = this.Item3;
				ptr3 = ref t3;
				if (t3 == null)
				{
					h3 = 0;
					goto IL_9F;
				}
			}
			h3 = ptr3.GetHashCode();
			IL_9F:
			ref T4 ptr4 = ref this.Item4;
			T4 t4 = default(T4);
			int h4;
			if (t4 == null)
			{
				t4 = this.Item4;
				ptr4 = ref t4;
				if (t4 == null)
				{
					h4 = 0;
					goto IL_D4;
				}
			}
			h4 = ptr4.GetHashCode();
			IL_D4:
			ref T5 ptr5 = ref this.Item5;
			T5 t5 = default(T5);
			int h5;
			if (t5 == null)
			{
				t5 = this.Item5;
				ptr5 = ref t5;
				if (t5 == null)
				{
					h5 = 0;
					goto IL_10C;
				}
			}
			h5 = ptr5.GetHashCode();
			IL_10C:
			return ValueTuple.CombineHashCodes(h, h2, h3, h4, h5);
		}

		/// <summary>Calculates the hash code for the current <see cref="T:System.ValueTuple`5" /> instance by using a specified computation method. </summary>
		/// <param name="comparer">An object whose <see cref="M:System.Collections.IEqualityComparer.GetHashCode(System.Object)" /> method calculates the hash code of the current <see cref="T:System.ValueTuple`5" /> instance. </param>
		/// <returns>A 32-bit signed integer hash code. </returns>
		// Token: 0x06000B13 RID: 2835 RVA: 0x0002D112 File Offset: 0x0002B312
		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
		{
			return this.GetHashCodeCore(comparer);
		}

		// Token: 0x06000B14 RID: 2836 RVA: 0x0002D11C File Offset: 0x0002B31C
		private int GetHashCodeCore(IEqualityComparer comparer)
		{
			return ValueTuple.CombineHashCodes(comparer.GetHashCode(this.Item1), comparer.GetHashCode(this.Item2), comparer.GetHashCode(this.Item3), comparer.GetHashCode(this.Item4), comparer.GetHashCode(this.Item5));
		}

		// Token: 0x06000B15 RID: 2837 RVA: 0x0002D112 File Offset: 0x0002B312
		int IValueTupleInternal.GetHashCode(IEqualityComparer comparer)
		{
			return this.GetHashCodeCore(comparer);
		}

		/// <summary>Returns a string that represents the value of this <see cref="T:System.ValueTuple`5" /> instance. </summary>
		/// <returns>The string representation of this <see cref="T:System.ValueTuple`5" /> instance. </returns>
		// Token: 0x06000B16 RID: 2838 RVA: 0x0002D184 File Offset: 0x0002B384
		public override string ToString()
		{
			string[] array = new string[11];
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
					goto IL_46;
				}
			}
			text = ptr.ToString();
			IL_46:
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
					goto IL_86;
				}
			}
			text2 = ptr2.ToString();
			IL_86:
			array[num2] = text2;
			array[4] = ", ";
			int num3 = 5;
			ref T3 ptr3 = ref this.Item3;
			T3 t3 = default(T3);
			string text3;
			if (t3 == null)
			{
				t3 = this.Item3;
				ptr3 = ref t3;
				if (t3 == null)
				{
					text3 = null;
					goto IL_C6;
				}
			}
			text3 = ptr3.ToString();
			IL_C6:
			array[num3] = text3;
			array[6] = ", ";
			int num4 = 7;
			ref T4 ptr4 = ref this.Item4;
			T4 t4 = default(T4);
			string text4;
			if (t4 == null)
			{
				t4 = this.Item4;
				ptr4 = ref t4;
				if (t4 == null)
				{
					text4 = null;
					goto IL_106;
				}
			}
			text4 = ptr4.ToString();
			IL_106:
			array[num4] = text4;
			array[8] = ", ";
			int num5 = 9;
			ref T5 ptr5 = ref this.Item5;
			T5 t5 = default(T5);
			string text5;
			if (t5 == null)
			{
				t5 = this.Item5;
				ptr5 = ref t5;
				if (t5 == null)
				{
					text5 = null;
					goto IL_14A;
				}
			}
			text5 = ptr5.ToString();
			IL_14A:
			array[num5] = text5;
			array[10] = ")";
			return string.Concat(array);
		}

		// Token: 0x06000B17 RID: 2839 RVA: 0x0002D2EC File Offset: 0x0002B4EC
		string IValueTupleInternal.ToStringEnd()
		{
			string[] array = new string[10];
			int num = 0;
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
					goto IL_3E;
				}
			}
			text = ptr.ToString();
			IL_3E:
			array[num] = text;
			array[1] = ", ";
			int num2 = 2;
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
					goto IL_7E;
				}
			}
			text2 = ptr2.ToString();
			IL_7E:
			array[num2] = text2;
			array[3] = ", ";
			int num3 = 4;
			ref T3 ptr3 = ref this.Item3;
			T3 t3 = default(T3);
			string text3;
			if (t3 == null)
			{
				t3 = this.Item3;
				ptr3 = ref t3;
				if (t3 == null)
				{
					text3 = null;
					goto IL_BE;
				}
			}
			text3 = ptr3.ToString();
			IL_BE:
			array[num3] = text3;
			array[5] = ", ";
			int num4 = 6;
			ref T4 ptr4 = ref this.Item4;
			T4 t4 = default(T4);
			string text4;
			if (t4 == null)
			{
				t4 = this.Item4;
				ptr4 = ref t4;
				if (t4 == null)
				{
					text4 = null;
					goto IL_FE;
				}
			}
			text4 = ptr4.ToString();
			IL_FE:
			array[num4] = text4;
			array[7] = ", ";
			int num5 = 8;
			ref T5 ptr5 = ref this.Item5;
			T5 t5 = default(T5);
			string text5;
			if (t5 == null)
			{
				t5 = this.Item5;
				ptr5 = ref t5;
				if (t5 == null)
				{
					text5 = null;
					goto IL_141;
				}
			}
			text5 = ptr5.ToString();
			IL_141:
			array[num5] = text5;
			array[9] = ")";
			return string.Concat(array);
		}

		/// <summary>Gets the number of elements in the <see langword="ValueTuple" />.</summary>
		/// <returns>5, the number of elements in a <see cref="T:System.ValueTuple`5" /> object. </returns>
		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000B18 RID: 2840 RVA: 0x00024234 File Offset: 0x00022434
		int ITuple.Length
		{
			get
			{
				return 5;
			}
		}

		/// <summary>Gets the value of the current <see cref="T:System.ValueTuple`5" /> instance's first element. </summary>
		/// <returns>The value of the current <see cref="T:System.ValueTuple`5" /> instance's first element. </returns>
		// Token: 0x040003B5 RID: 949
		public T1 Item1;

		/// <summary>Gets the value of the current <see cref="T:System.ValueTuple`5" /> instance's second element. </summary>
		/// <returns>The value of the current <see cref="T:System.ValueTuple`5" /> instance's second element. </returns>
		// Token: 0x040003B6 RID: 950
		public T2 Item2;

		/// <summary>Gets the value of the current <see cref="T:System.ValueTuple`5" /> instance's third element. </summary>
		/// <returns>The value of the current <see cref="T:System.ValueTuple`5" /> instance's third element. </returns>
		// Token: 0x040003B7 RID: 951
		public T3 Item3;

		/// <summary>Gets the value of the current <see cref="T:System.ValueTuple`5" /> instance's fourth element. </summary>
		/// <returns>The value of the current <see cref="T:System.ValueTuple`5" /> instance's fourth element. </returns>
		// Token: 0x040003B8 RID: 952
		public T4 Item4;

		/// <summary>Gets the value of the current <see cref="T:System.ValueTuple`5" /> instance's fifth element. </summary>
		/// <returns>The value of the current <see cref="T:System.ValueTuple`5" /> instance's fifth element. </returns>
		// Token: 0x040003B9 RID: 953
		public T5 Item5;
	}
}
