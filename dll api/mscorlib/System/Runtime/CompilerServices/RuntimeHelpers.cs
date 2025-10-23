using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Serialization;

namespace System.Runtime.CompilerServices
{
	/// <summary>Provides a set of static methods and properties that provide support for compilers. This class cannot be inherited.</summary>
	// Token: 0x02000479 RID: 1145
	public static class RuntimeHelpers
	{
		// Token: 0x060020A0 RID: 8352
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void InitializeArray(Array array, IntPtr fldHandle);

		/// <summary>Provides a fast way to initialize an array from data that is stored in a module.</summary>
		/// <param name="array">The array to be initialized. </param>
		/// <param name="fldHandle">A field handle that specifies the location of the data used to initialize the array. </param>
		// Token: 0x060020A1 RID: 8353 RVA: 0x000898AB File Offset: 0x00087AAB
		public static void InitializeArray(Array array, RuntimeFieldHandle fldHandle)
		{
			if (array == null || fldHandle.Value == IntPtr.Zero)
			{
				throw new ArgumentNullException();
			}
			RuntimeHelpers.InitializeArray(array, fldHandle.Value);
		}

		/// <summary>Gets the offset, in bytes, to the data in the given string.</summary>
		/// <returns>The byte offset, from the start of the <see cref="T:System.String" /> object to the first character in the string.</returns>
		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x060020A2 RID: 8354
		public static extern int OffsetToStringData { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		/// <summary>Serves as a hash function for a particular object, and is suitable for use in algorithms and data structures that use hash codes, such as a hash table.</summary>
		/// <param name="o">An object to retrieve the hash code for. </param>
		/// <returns>A hash code for the object identified by the <paramref name="o" /> parameter.</returns>
		// Token: 0x060020A3 RID: 8355 RVA: 0x0003F3EF File Offset: 0x0003D5EF
		public static int GetHashCode(object o)
		{
			return object.InternalGetHashCode(o);
		}

		// Token: 0x060020A4 RID: 8356
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void RunClassConstructor(IntPtr type);

		/// <summary>Runs a specified class constructor method.</summary>
		/// <param name="type">A type handle that specifies the class constructor method to run. </param>
		/// <exception cref="T:System.TypeInitializationException">The class initializer throws an exception. </exception>
		// Token: 0x060020A5 RID: 8357 RVA: 0x000898D6 File Offset: 0x00087AD6
		public static void RunClassConstructor(RuntimeTypeHandle type)
		{
			if (type.Value == IntPtr.Zero)
			{
				throw new ArgumentException("Handle is not initialized.", "type");
			}
			RuntimeHelpers.RunClassConstructor(type.Value);
		}

		// Token: 0x060020A6 RID: 8358
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool SufficientExecutionStack();

		// Token: 0x060020A7 RID: 8359 RVA: 0x00089907 File Offset: 0x00087B07
		public static bool TryEnsureSufficientExecutionStack()
		{
			return RuntimeHelpers.SufficientExecutionStack();
		}

		/// <summary>Designates a body of code as a constrained execution region (CER).</summary>
		// Token: 0x060020A8 RID: 8360 RVA: 0x00002A7D File Offset: 0x00000C7D
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		public static void PrepareConstrainedRegions()
		{
		}

		// Token: 0x060020A9 RID: 8361 RVA: 0x0008990E File Offset: 0x00087B0E
		public static bool IsReferenceOrContainsReferences<T>()
		{
			return !typeof(T).IsValueType || RuntimeTypeHandle.HasReferences(typeof(T) as RuntimeType);
		}

		// Token: 0x060020AA RID: 8362 RVA: 0x00089937 File Offset: 0x00087B37
		public static object GetUninitializedObject(Type type)
		{
			return FormatterServices.GetUninitializedObject(type);
		}
	}
}
