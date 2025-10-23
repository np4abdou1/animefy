﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System
{
	/// <summary>Represents a value tuple with 4 components. </summary>
	/// <typeparam name="T1">The type of the value tuple's first element. </typeparam>
	/// <typeparam name="T2">The type of the value tuple's second element. </typeparam>
	/// <typeparam name="T3">The type of the value tuple's third element. </typeparam>
	/// <typeparam name="T4">The type of the value tuple's fourth element. </typeparam>
	// Token: 0x0200011D RID: 285
	[Serializable]
	[StructLayout(3)]
	public struct ValueTuple<T1, T2, T3, T4> : IEquatable<ValueTuple<T1, T2, T3, T4>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple<T1, T2, T3, T4>>, IValueTupleInternal, ITuple
	{
		/// <summary>Initializes a new <see cref="T:System.ValueTuple`4" /> instance. </summary>
		/// <param name="item1">The value tuple's first element. </param>
		/// <param name="item2">The value tuple's second element. </param>
		/// <param name="item3">The value tuple's third element. </param>
		/// <param name="item4">The value tuple's fourth element. </param>
		// Token: 0x06000AFD RID: 2813 RVA: 0x0002C640 File Offset: 0x0002A840
		public ValueTuple(T1 item1, T2 item2, T3 item3, T4 item4)
		{
			this.Item1 = item1;
			this.Item2 = item2;
			this.Item3 = item3;
			this.Item4 = item4;
		}

		/// <summary>Returns a value that indicates whether the current <see cref="T:System.ValueTuple`4" /> instance is equal to a specified object.</summary>
		/// <param name="obj">The object to compare with this instance.</param>
		/// <returns>
		///     <see langword="true" /> if the current instance is equal to the specified object; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000AFE RID: 2814 RVA: 0x0002C65F File Offset: 0x0002A85F
		public override bool Equals(object obj)
		{
			return obj is ValueTuple<T1, T2, T3, T4> && this.Equals((ValueTuple<T1, T2, T3, T4>)obj);
		}

		/// <summary>Returns a value that indicates whether the current <see cref="T:System.ValueTuple`4" /> instance is equal to a specified <see cref="T:System.ValueTuple`4" /> instance.</summary>
		/// <param name="other">The value tuple to compare with this instance.</param>
		/// <returns>
		///     <see langword="true" /> if the current instance is equal to the specified tuple; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000AFF RID: 2815 RVA: 0x0002C678 File Offset: 0x0002A878
		public bool Equals(ValueTuple<T1, T2, T3, T4> other)
		{
			return EqualityComparer<T1>.Default.Equals(this.Item1, other.Item1) && EqualityComparer<T2>.Default.Equals(this.Item2, other.Item2) && EqualityComparer<T3>.Default.Equals(this.Item3, other.Item3) && EqualityComparer<T4>.Default.Equals(this.Item4, other.Item4);
		}

		/// <summary>Returns a value that indicates whether the current <see cref="T:System.ValueTuple`4" /> instance is equal to a specified object based on a specified comparison method. </summary>
		/// <param name="other">The object to compare with this instance. </param>
		/// <param name="comparer">An object that defines the method to use to evaluate whether the two objects are equal. </param>
		/// <returns>
		///     <see langword="true" /> if the current instance is equal to the specified objects; otherwise, <see langword="false" />. </returns>
		// Token: 0x06000B00 RID: 2816 RVA: 0x0002C6E8 File Offset: 0x0002A8E8
		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
		{
			if (other == null || !(other is ValueTuple<T1, T2, T3, T4>))
			{
				return false;
			}
			ValueTuple<T1, T2, T3, T4> valueTuple = (ValueTuple<T1, T2, T3, T4>)other;
			return comparer.Equals(this.Item1, valueTuple.Item1) && comparer.Equals(this.Item2, valueTuple.Item2) && comparer.Equals(this.Item3, valueTuple.Item3) && comparer.Equals(this.Item4, valueTuple.Item4);
		}

		/// <summary>Compares the current <see cref="T:System.ValueTuple`4" /> instance to a specified object by using a specified comparer and returns an integer that indicates whether the current object is before, after, or in the same position as the specified object in the sort order. </summary>
		/// <param name="other">The object to compare with the current instance. </param>
		/// <returns>A signed integer that indicates the relative position of this instance and <paramref name="obj" /> in the sort order, as shown in the following table.ValueDescriptionA negative integerThis instance precedes <paramref name="other" />.ZeroThis instance and <paramref name="other" /> have the same position in the sort order.A positive integerThis instance follows <paramref name="other" />.</returns>
		// Token: 0x06000B01 RID: 2817 RVA: 0x0002C784 File Offset: 0x0002A984
		int IComparable.CompareTo(object other)
		{
			if (other == null)
			{
				return 1;
			}
			if (!(other is ValueTuple<T1, T2, T3, T4>))
			{
				throw new ArgumentException(SR.Format("Argument must be of type {0}.", base.GetType().ToString()), "other");
			}
			return this.CompareTo((ValueTuple<T1, T2, T3, T4>)other);
		}

		/// <summary>
		/// Compares the current <see cref="T:System.ValueTuple`4" /> instance to a specified <see cref="T:System.ValueTuple`4" /> instance.</summary>
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
		// Token: 0x06000B02 RID: 2818 RVA: 0x0002C7D4 File Offset: 0x0002A9D4
		public int CompareTo(ValueTuple<T1, T2, T3, T4> other)
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
			return Comparer<T4>.Default.Compare(this.Item4, other.Item4);
		}

		/// <summary>Compares the current <see cref="T:System.ValueTuple`4" /> instance to a specified object by using a specified comparer and returns an integer that indicates whether the current object is before, after, or in the same position as the specified object in the sort order. </summary>
		/// <param name="other">The object to compare with the current instance. </param>
		/// <param name="comparer">An object that provides custom rules for comparison. </param>
		/// <returns>A signed integer that indicates the relative position of this instance and <paramref name="other" /> in the sort order, as shown in the following able. VaueDescriptionA negative integerThis instance precedes <paramref name="other" />. ZeroThis instance and <paramref name="other" /> have the same position in the sort order.A positive integerThis instance follows <paramref name="other" />. </returns>
		// Token: 0x06000B03 RID: 2819 RVA: 0x0002C84C File Offset: 0x0002AA4C
		int IStructuralComparable.CompareTo(object other, IComparer comparer)
		{
			if (other == null)
			{
				return 1;
			}
			if (!(other is ValueTuple<T1, T2, T3, T4>))
			{
				throw new ArgumentException(SR.Format("Argument must be of type {0}.", base.GetType().ToString()), "other");
			}
			ValueTuple<T1, T2, T3, T4> valueTuple = (ValueTuple<T1, T2, T3, T4>)other;
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
			return comparer.Compare(this.Item4, valueTuple.Item4);
		}

		/// <summary>Calculates the hash code for the current <see cref="T:System.ValueTuple`4" /> instance.</summary>
		/// <returns>The hash code for the current <see cref="T:System.ValueTuple`4" /> instance. </returns>
		// Token: 0x06000B04 RID: 2820 RVA: 0x0002C91C File Offset: 0x0002AB1C
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
			return ValueTuple.CombineHashCodes(h, h2, h3, h4);
		}

		/// <summary>Calculates the hash code for the current <see cref="T:System.ValueTuple`4" /> instance by using a specified computation method. </summary>
		/// <param name="comparer">An object whose <see cref="M:System.Collections.IEqualityComparer.GetHashCode(System.Object)" /> method calculates the hash code of the current <see cref="T:System.ValueTuple`4" /> instance. </param>
		/// <returns>A 32-bit signed integer hash code. </returns>
		// Token: 0x06000B05 RID: 2821 RVA: 0x0002CA02 File Offset: 0x0002AC02
		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
		{
			return this.GetHashCodeCore(comparer);
		}

		// Token: 0x06000B06 RID: 2822 RVA: 0x0002CA0C File Offset: 0x0002AC0C
		private int GetHashCodeCore(IEqualityComparer comparer)
		{
			return ValueTuple.CombineHashCodes(comparer.GetHashCode(this.Item1), comparer.GetHashCode(this.Item2), comparer.GetHashCode(this.Item3), comparer.GetHashCode(this.Item4));
		}

		// Token: 0x06000B07 RID: 2823 RVA: 0x0002CA02 File Offset: 0x0002AC02
		int IValueTupleInternal.GetHashCode(IEqualityComparer comparer)
		{
			return this.GetHashCodeCore(comparer);
		}

		/// <summary>Returns a string that represents the value of this <see cref="T:System.ValueTuple`4" /> instance. </summary>
		/// <returns>The string representation of this <see cref="T:System.ValueTuple`4" /> instance. </returns>
		// Token: 0x06000B08 RID: 2824 RVA: 0x0002CA64 File Offset: 0x0002AC64
		public override string ToString()
		{
			string[] array = new string[9];
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
			array[8] = ")";
			return string.Concat(array);
		}

		// Token: 0x06000B09 RID: 2825 RVA: 0x0002CB88 File Offset: 0x0002AD88
		string IValueTupleInternal.ToStringEnd()
		{
			string[] array = new string[8];
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
					goto IL_3D;
				}
			}
			text = ptr.ToString();
			IL_3D:
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
					goto IL_7D;
				}
			}
			text2 = ptr2.ToString();
			IL_7D:
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
					goto IL_BD;
				}
			}
			text3 = ptr3.ToString();
			IL_BD:
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
					goto IL_FD;
				}
			}
			text4 = ptr4.ToString();
			IL_FD:
			array[num4] = text4;
			array[7] = ")";
			return string.Concat(array);
		}

		/// <summary>Gets the number of elements in the <see langword="ValueTuple" />.</summary>
		/// <returns>4, the number of elements in a <see cref="T:System.ValueTuple`4" /> object. </returns>
		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000B0A RID: 2826 RVA: 0x0000F994 File Offset: 0x0000DB94
		int ITuple.Length
		{
			get
			{
				return 4;
			}
		}

		/// <summary>Gets the value of the current <see cref="T:System.ValueTuple`4" /> instance's first element. </summary>
		/// <returns>The value of the current <see cref="T:System.ValueTuple`4" /> instance's first element. </returns>
		// Token: 0x040003B1 RID: 945
		public T1 Item1;

		/// <summary>Gets the value of the current <see cref="T:System.ValueTuple`4" /> instance's second element. </summary>
		/// <returns>The value of the current <see cref="T:System.ValueTuple`4" /> instance's second element. </returns>
		// Token: 0x040003B2 RID: 946
		public T2 Item2;

		/// <summary>Gets the value of the current <see cref="T:System.ValueTuple`4" /> instance's third element. </summary>
		/// <returns>The value of the current <see cref="T:System.ValueTuple`4" /> instance's third element. </returns>
		// Token: 0x040003B3 RID: 947
		public T3 Item3;

		/// <summary>Gets the value of the current <see cref="T:System.ValueTuple`4" /> instance's fourth element. </summary>
		/// <returns>The value of the current <see cref="T:System.ValueTuple`4" /> instance's fourth element. </returns>
		// Token: 0x040003B4 RID: 948
		public T4 Item4;
	}
}
