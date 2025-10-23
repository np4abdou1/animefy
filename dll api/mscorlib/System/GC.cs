using System;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Security;

namespace System
{
	/// <summary>Controls the system garbage collector, a service that automatically reclaims unused memory.</summary>
	// Token: 0x0200014C RID: 332
	public static class GC
	{
		// Token: 0x06000CD9 RID: 3289
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int GetCollectionCount(int generation);

		// Token: 0x06000CDA RID: 3290
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int GetMaxGeneration();

		// Token: 0x06000CDB RID: 3291
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void InternalCollect(int generation);

		// Token: 0x06000CDC RID: 3292
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void register_ephemeron_array(Ephemeron[] array);

		// Token: 0x06000CDD RID: 3293
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern object get_ephemeron_tombstone();

		// Token: 0x06000CDE RID: 3294 RVA: 0x00035C6A File Offset: 0x00033E6A
		internal static void GetMemoryInfo(out uint highMemLoadThreshold, out ulong totalPhysicalMem, out uint lastRecordedMemLoad, out UIntPtr lastRecordedHeapSize, out UIntPtr lastRecordedFragmentation)
		{
			highMemLoadThreshold = 0U;
			totalPhysicalMem = ulong.MaxValue;
			lastRecordedMemLoad = 0U;
			lastRecordedHeapSize = UIntPtr.Zero;
			lastRecordedFragmentation = UIntPtr.Zero;
		}

		/// <summary>Forces an immediate garbage collection of all generations. </summary>
		// Token: 0x06000CDF RID: 3295 RVA: 0x00035C85 File Offset: 0x00033E85
		[SecuritySafeCritical]
		public static void Collect()
		{
			GC.InternalCollect(GC.MaxGeneration);
		}

		/// <summary>Returns the number of times garbage collection has occurred for the specified generation of objects.</summary>
		/// <param name="generation">The generation of objects for which the garbage collection count is to be determined. </param>
		/// <returns>The number of times garbage collection has occurred for the specified generation since the process was started.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="generation" /> is less than 0. </exception>
		// Token: 0x06000CE0 RID: 3296 RVA: 0x00035C91 File Offset: 0x00033E91
		[SecuritySafeCritical]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static int CollectionCount(int generation)
		{
			if (generation < 0)
			{
				throw new ArgumentOutOfRangeException("generation", Environment.GetResourceString("Value must be positive."));
			}
			return GC.GetCollectionCount(generation);
		}

		/// <summary>References the specified object, which makes it ineligible for garbage collection from the start of the current routine to the point where this method is called.</summary>
		/// <param name="obj">The object to reference. </param>
		// Token: 0x06000CE1 RID: 3297 RVA: 0x00002A7D File Offset: 0x00000C7D
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void KeepAlive(object obj)
		{
		}

		/// <summary>Gets the maximum number of generations that the system currently supports.</summary>
		/// <returns>A value that ranges from zero to the maximum number of supported generations.</returns>
		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000CE2 RID: 3298 RVA: 0x00035CB2 File Offset: 0x00033EB2
		public static int MaxGeneration
		{
			[SecuritySafeCritical]
			get
			{
				return GC.GetMaxGeneration();
			}
		}

		// Token: 0x06000CE3 RID: 3299
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void _SuppressFinalize(object o);

		/// <summary>Requests that the common language runtime not call the finalizer for the specified object. </summary>
		/// <param name="obj">The object whose finalizer must not be executed. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="obj" /> is <see langword="null" />. </exception>
		// Token: 0x06000CE4 RID: 3300 RVA: 0x00035CB9 File Offset: 0x00033EB9
		[SecuritySafeCritical]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static void SuppressFinalize(object obj)
		{
			if (obj == null)
			{
				throw new ArgumentNullException("obj");
			}
			GC._SuppressFinalize(obj);
		}

		// Token: 0x06000CE5 RID: 3301
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void _ReRegisterForFinalize(object o);

		/// <summary>Requests that the system call the finalizer for the specified object for which <see cref="M:System.GC.SuppressFinalize(System.Object)" /> has previously been called.</summary>
		/// <param name="obj">The object that a finalizer must be called for. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="obj" /> is <see langword="null" />. </exception>
		// Token: 0x06000CE6 RID: 3302 RVA: 0x00035CCF File Offset: 0x00033ECF
		[SecuritySafeCritical]
		public static void ReRegisterForFinalize(object obj)
		{
			if (obj == null)
			{
				throw new ArgumentNullException("obj");
			}
			GC._ReRegisterForFinalize(obj);
		}

		// Token: 0x0400043A RID: 1082
		internal static readonly object EPHEMERON_TOMBSTONE = GC.get_ephemeron_tombstone();
	}
}
