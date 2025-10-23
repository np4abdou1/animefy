using System;
using System.Runtime.CompilerServices;

namespace System.Threading
{
	/// <summary>Contains methods for performing volatile memory operations.</summary>
	// Token: 0x020001FA RID: 506
	public static class Volatile
	{
		/// <summary>Reads the value of the specified field. On systems that require it, inserts a memory barrier that prevents the processor from reordering memory operations as follows: If a read or write appears after this method in the code, the processor cannot move it before this method.</summary>
		/// <param name="location">The field to read.</param>
		/// <returns>The value that was read. This value is the latest written by any processor in the computer, regardless of the number of processors or the state of processor cache. </returns>
		// Token: 0x0600124D RID: 4685 RVA: 0x0004A09E File Offset: 0x0004829E
		[Intrinsic]
		public static int Read(ref int location)
		{
			return Unsafe.As<int, Volatile.VolatileInt32>(ref location).Value;
		}

		/// <summary>Writes the specified value to the specified field. On systems that require it, inserts a memory barrier that prevents the processor from reordering memory operations as follows: If a read or write appears before this method in the code, the processor cannot move it after this method.</summary>
		/// <param name="location">The field where the value is written.</param>
		/// <param name="value">The value to write. The value is written immediately so that it is visible to all processors in the computer.</param>
		// Token: 0x0600124E RID: 4686 RVA: 0x0004A0AD File Offset: 0x000482AD
		[Intrinsic]
		public static void Write(ref int location, int value)
		{
			Unsafe.As<int, Volatile.VolatileInt32>(ref location).Value = value;
		}

		/// <summary>Reads the object reference from the specified field. On systems that require it, inserts a memory barrier that prevents the processor from reordering memory operations as follows: If a read or write appears after this method in the code, the processor cannot move it before this method.</summary>
		/// <param name="location">The field to read.</param>
		/// <typeparam name="T">The type of field to read. This must be a reference type, not a value type.</typeparam>
		/// <returns>The reference to <paramref name="T" /> that was read. This reference is the latest written by any processor in the computer, regardless of the number of processors or the state of processor cache. </returns>
		// Token: 0x0600124F RID: 4687 RVA: 0x0004A0BD File Offset: 0x000482BD
		[Intrinsic]
		public static T Read<T>(ref T location) where T : class
		{
			return Unsafe.As<T>(Unsafe.As<T, Volatile.VolatileObject>(ref location).Value);
		}

		/// <summary>Writes the specified object reference to the specified field. On systems that require it, inserts a memory barrier that prevents the processor from reordering memory operations as follows: If a read or write appears before this method in the code, the processor cannot move it after this method. </summary>
		/// <param name="location">The field where the object reference is written.</param>
		/// <param name="value">The object reference to write. The reference is written immediately so that it is visible to all processors in the computer.</param>
		/// <typeparam name="T">The type of field to write. This must be a reference type, not a value type. </typeparam>
		// Token: 0x06001250 RID: 4688 RVA: 0x0004A0D1 File Offset: 0x000482D1
		[Intrinsic]
		public static void Write<T>(ref T location, T value) where T : class
		{
			Unsafe.As<T, Volatile.VolatileObject>(ref location).Value = value;
		}

		// Token: 0x020001FB RID: 507
		private struct VolatileInt32
		{
			// Token: 0x04000739 RID: 1849
			public volatile int Value;
		}

		// Token: 0x020001FC RID: 508
		private struct VolatileObject
		{
			// Token: 0x0400073A RID: 1850
			public volatile object Value;
		}
	}
}
