using System;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace System.Threading
{
	/// <summary>Provides atomic operations for variables that are shared by multiple threads. </summary>
	// Token: 0x020001EF RID: 495
	public static class Interlocked
	{
		/// <summary>Compares two 32-bit signed integers for equality and, if they are equal, replaces the first value.</summary>
		/// <param name="location1">The destination, whose value is compared with <paramref name="comparand" /> and possibly replaced. </param>
		/// <param name="value">The value that replaces the destination value if the comparison results in equality. </param>
		/// <param name="comparand">The value that is compared to the value at <paramref name="location1" />. </param>
		/// <returns>The original value in <paramref name="location1" />.</returns>
		/// <exception cref="T:System.NullReferenceException">The address of <paramref name="location1" /> is a null pointer. </exception>
		// Token: 0x060011FF RID: 4607
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int CompareExchange(ref int location1, int value, int comparand);

		// Token: 0x06001200 RID: 4608
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern int CompareExchange(ref int location1, int value, int comparand, ref bool succeeded);

		// Token: 0x06001201 RID: 4609
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void CompareExchange(ref object location1, ref object value, ref object comparand, ref object result);

		/// <summary>Compares two objects for reference equality and, if they are equal, replaces the first object.</summary>
		/// <param name="location1">The destination object that is compared with <paramref name="comparand" /> and possibly replaced. </param>
		/// <param name="value">The object that replaces the destination object if the comparison results in equality. </param>
		/// <param name="comparand">The object that is compared to the object at <paramref name="location1" />. </param>
		/// <returns>The original value in <paramref name="location1" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">The address of <paramref name="location1" /> is a null pointer. </exception>
		// Token: 0x06001202 RID: 4610 RVA: 0x00049300 File Offset: 0x00047500
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static object CompareExchange(ref object location1, object value, object comparand)
		{
			object result = null;
			Interlocked.CompareExchange(ref location1, ref value, ref comparand, ref result);
			return result;
		}

		/// <summary>Compares two single-precision floating point numbers for equality and, if they are equal, replaces the first value.</summary>
		/// <param name="location1">The destination, whose value is compared with <paramref name="comparand" /> and possibly replaced. </param>
		/// <param name="value">The value that replaces the destination value if the comparison results in equality. </param>
		/// <param name="comparand">The value that is compared to the value at <paramref name="location1" />. </param>
		/// <returns>The original value in <paramref name="location1" />.</returns>
		/// <exception cref="T:System.NullReferenceException">The address of <paramref name="location1" /> is a null pointer. </exception>
		// Token: 0x06001203 RID: 4611
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float CompareExchange(ref float location1, float value, float comparand);

		/// <summary>Decrements a specified variable and stores the result, as an atomic operation.</summary>
		/// <param name="location">The variable whose value is to be decremented. </param>
		/// <returns>The decremented value.</returns>
		/// <exception cref="T:System.ArgumentNullException">The address of <paramref name="location" /> is a null pointer. </exception>
		// Token: 0x06001204 RID: 4612
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int Decrement(ref int location);

		/// <summary>Increments a specified variable and stores the result, as an atomic operation.</summary>
		/// <param name="location">The variable whose value is to be incremented. </param>
		/// <returns>The incremented value.</returns>
		/// <exception cref="T:System.NullReferenceException">The address of <paramref name="location" /> is a null pointer. </exception>
		// Token: 0x06001205 RID: 4613
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int Increment(ref int location);

		/// <summary>Increments a specified variable and stores the result, as an atomic operation.</summary>
		/// <param name="location">The variable whose value is to be incremented. </param>
		/// <returns>The incremented value.</returns>
		/// <exception cref="T:System.NullReferenceException">The address of <paramref name="location" /> is a null pointer. </exception>
		// Token: 0x06001206 RID: 4614
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long Increment(ref long location);

		/// <summary>Sets a 32-bit signed integer to a specified value and returns the original value, as an atomic operation.</summary>
		/// <param name="location1">The variable to set to the specified value. </param>
		/// <param name="value">The value to which the <paramref name="location1" /> parameter is set. </param>
		/// <returns>The original value of <paramref name="location1" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">The address of <paramref name="location1" /> is a null pointer. </exception>
		// Token: 0x06001207 RID: 4615
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int Exchange(ref int location1, int value);

		// Token: 0x06001208 RID: 4616
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Exchange(ref object location1, ref object value, ref object result);

		/// <summary>Sets an object to a specified value and returns a reference to the original object, as an atomic operation.</summary>
		/// <param name="location1">The variable to set to the specified value. </param>
		/// <param name="value">The value to which the <paramref name="location1" /> parameter is set. </param>
		/// <returns>The original value of <paramref name="location1" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">The address of <paramref name="location1" /> is a null pointer. </exception>
		// Token: 0x06001209 RID: 4617 RVA: 0x0004931C File Offset: 0x0004751C
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static object Exchange(ref object location1, object value)
		{
			object result = null;
			Interlocked.Exchange(ref location1, ref value, ref result);
			return result;
		}

		/// <summary>Sets a single-precision floating point number to a specified value and returns the original value, as an atomic operation.</summary>
		/// <param name="location1">The variable to set to the specified value. </param>
		/// <param name="value">The value to which the <paramref name="location1" /> parameter is set. </param>
		/// <returns>The original value of <paramref name="location1" />.</returns>
		/// <exception cref="T:System.NullReferenceException">The address of <paramref name="location1" /> is a null pointer. </exception>
		// Token: 0x0600120A RID: 4618
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Exchange(ref float location1, float value);

		/// <summary>Compares two 64-bit signed integers for equality and, if they are equal, replaces the first value.</summary>
		/// <param name="location1">The destination, whose value is compared with <paramref name="comparand" /> and possibly replaced. </param>
		/// <param name="value">The value that replaces the destination value if the comparison results in equality. </param>
		/// <param name="comparand">The value that is compared to the value at <paramref name="location1" />. </param>
		/// <returns>The original value in <paramref name="location1" />.</returns>
		/// <exception cref="T:System.NullReferenceException">The address of <paramref name="location1" /> is a null pointer. </exception>
		// Token: 0x0600120B RID: 4619
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long CompareExchange(ref long location1, long value, long comparand);

		/// <summary>Compares two platform-specific handles or pointers for equality and, if they are equal, replaces the first one.</summary>
		/// <param name="location1">The destination <see cref="T:System.IntPtr" />, whose value is compared with the value of <paramref name="comparand" /> and possibly replaced by <paramref name="value" />. </param>
		/// <param name="value">The <see cref="T:System.IntPtr" /> that replaces the destination value if the comparison results in equality. </param>
		/// <param name="comparand">The <see cref="T:System.IntPtr" /> that is compared to the value at <paramref name="location1" />. </param>
		/// <returns>The original value in <paramref name="location1" />.</returns>
		/// <exception cref="T:System.NullReferenceException">The address of <paramref name="location1" /> is a null pointer. </exception>
		// Token: 0x0600120C RID: 4620
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern IntPtr CompareExchange(ref IntPtr location1, IntPtr value, IntPtr comparand);

		/// <summary>Compares two double-precision floating point numbers for equality and, if they are equal, replaces the first value.</summary>
		/// <param name="location1">The destination, whose value is compared with <paramref name="comparand" /> and possibly replaced. </param>
		/// <param name="value">The value that replaces the destination value if the comparison results in equality. </param>
		/// <param name="comparand">The value that is compared to the value at <paramref name="location1" />. </param>
		/// <returns>The original value in <paramref name="location1" />.</returns>
		/// <exception cref="T:System.NullReferenceException">The address of <paramref name="location1" /> is a null pointer. </exception>
		// Token: 0x0600120D RID: 4621
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double CompareExchange(ref double location1, double value, double comparand);

		/// <summary>Compares two instances of the specified reference type <paramref name="T" /> for equality and, if they are equal, replaces the first one.</summary>
		/// <param name="location1">The destination, whose value is compared with <paramref name="comparand" /> and possibly replaced. This is a reference parameter (<see langword="ref" /> in C#, <see langword="ByRef" /> in Visual Basic). </param>
		/// <param name="value">The value that replaces the destination value if the comparison results in equality. </param>
		/// <param name="comparand">The value that is compared to the value at <paramref name="location1" />. </param>
		/// <typeparam name="T">The type to be used for <paramref name="location1" />, <paramref name="value" />, and <paramref name="comparand" />. This type must be a reference type.</typeparam>
		/// <returns>The original value in <paramref name="location1" />.</returns>
		/// <exception cref="T:System.NullReferenceException">The address of <paramref name="location1" /> is a null pointer. </exception>
		// Token: 0x0600120E RID: 4622 RVA: 0x00049338 File Offset: 0x00047538
		[ComVisible(false)]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[Intrinsic]
		public static T CompareExchange<T>(ref T location1, T value, T comparand) where T : class
		{
			if (Unsafe.AsPointer<T>(ref location1) == null)
			{
				throw new NullReferenceException();
			}
			T result = default(T);
			Interlocked.CompareExchange(Unsafe.As<T, object>(ref location1), Unsafe.As<T, object>(ref value), Unsafe.As<T, object>(ref comparand), Unsafe.As<T, object>(ref result));
			return result;
		}

		/// <summary>Sets a 64-bit signed integer to a specified value and returns the original value, as an atomic operation.</summary>
		/// <param name="location1">The variable to set to the specified value. </param>
		/// <param name="value">The value to which the <paramref name="location1" /> parameter is set. </param>
		/// <returns>The original value of <paramref name="location1" />.</returns>
		/// <exception cref="T:System.NullReferenceException">The address of <paramref name="location1" /> is a null pointer. </exception>
		// Token: 0x0600120F RID: 4623
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long Exchange(ref long location1, long value);

		/// <summary>Sets a platform-specific handle or pointer to a specified value and returns the original value, as an atomic operation.</summary>
		/// <param name="location1">The variable to set to the specified value. </param>
		/// <param name="value">The value to which the <paramref name="location1" /> parameter is set. </param>
		/// <returns>The original value of <paramref name="location1" />.</returns>
		/// <exception cref="T:System.NullReferenceException">The address of <paramref name="location1" /> is a null pointer. </exception>
		// Token: 0x06001210 RID: 4624
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern IntPtr Exchange(ref IntPtr location1, IntPtr value);

		/// <summary>Sets a double-precision floating point number to a specified value and returns the original value, as an atomic operation.</summary>
		/// <param name="location1">The variable to set to the specified value. </param>
		/// <param name="value">The value to which the <paramref name="location1" /> parameter is set. </param>
		/// <returns>The original value of <paramref name="location1" />.</returns>
		/// <exception cref="T:System.NullReferenceException">The address of <paramref name="location1" /> is a null pointer. </exception>
		// Token: 0x06001211 RID: 4625
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double Exchange(ref double location1, double value);

		/// <summary>Sets a variable of the specified type <paramref name="T" /> to a specified value and returns the original value, as an atomic operation.</summary>
		/// <param name="location1">The variable to set to the specified value. This is a reference parameter (<see langword="ref" /> in C#, <see langword="ByRef" /> in Visual Basic). </param>
		/// <param name="value">The value to which the <paramref name="location1" /> parameter is set. </param>
		/// <typeparam name="T">The type to be used for <paramref name="location1" /> and <paramref name="value" />. This type must be a reference type.</typeparam>
		/// <returns>The original value of <paramref name="location1" />.</returns>
		/// <exception cref="T:System.NullReferenceException">The address of <paramref name="location1" /> is a null pointer. </exception>
		// Token: 0x06001212 RID: 4626 RVA: 0x00049380 File Offset: 0x00047580
		[ComVisible(false)]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[Intrinsic]
		public static T Exchange<T>(ref T location1, T value) where T : class
		{
			if (Unsafe.AsPointer<T>(ref location1) == null)
			{
				throw new NullReferenceException();
			}
			T result = default(T);
			Interlocked.Exchange(Unsafe.As<T, object>(ref location1), Unsafe.As<T, object>(ref value), Unsafe.As<T, object>(ref result));
			return result;
		}

		/// <summary>Adds two 32-bit integers and replaces the first integer with the sum, as an atomic operation.</summary>
		/// <param name="location1">A variable containing the first value to be added. The sum of the two values is stored in <paramref name="location1" />.</param>
		/// <param name="value">The value to be added to the integer at <paramref name="location1" />.</param>
		/// <returns>The new value stored at <paramref name="location1" />.</returns>
		/// <exception cref="T:System.NullReferenceException">The address of <paramref name="location1" /> is a null pointer. </exception>
		// Token: 0x06001213 RID: 4627
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int Add(ref int location1, int value);

		/// <summary>
		///     Synchronizes memory access as follows: The processor that executes the current thread cannot reorder instructions in such a way that memory accesses before the call to <see cref="M:System.Threading.Interlocked.MemoryBarrier" /> execute after memory accesses that follow the call to <see cref="M:System.Threading.Interlocked.MemoryBarrier" />.</summary>
		// Token: 0x06001214 RID: 4628 RVA: 0x000493BF File Offset: 0x000475BF
		public static void MemoryBarrier()
		{
			Thread.MemoryBarrier();
		}
	}
}
