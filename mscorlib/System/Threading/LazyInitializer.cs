using System;

namespace System.Threading
{
	/// <summary>Provides lazy initialization routines.</summary>
	// Token: 0x020001A6 RID: 422
	public static class LazyInitializer
	{
		/// <summary>Initializes a target reference type with the type's default constructor if it hasn't already been initialized.</summary>
		/// <param name="target">A reference of type <paramref name="T" /> to initialize if it has not already been initialized.</param>
		/// <typeparam name="T">The type of the reference to be initialized.</typeparam>
		/// <returns>The initialized reference of type <paramref name="T" />.</returns>
		/// <exception cref="T:System.MemberAccessException">Permissions to access the constructor of type <paramref name="T" /> were missing.</exception>
		/// <exception cref="T:System.MissingMemberException">Type <paramref name="T" /> does not have a default constructor.</exception>
		// Token: 0x06001044 RID: 4164 RVA: 0x00044190 File Offset: 0x00042390
		public static T EnsureInitialized<T>(ref T target) where T : class
		{
			T result;
			if ((result = Volatile.Read<T>(ref target)) == null)
			{
				result = LazyInitializer.EnsureInitializedCore<T>(ref target);
			}
			return result;
		}

		// Token: 0x06001045 RID: 4165 RVA: 0x000441A8 File Offset: 0x000423A8
		private static T EnsureInitializedCore<T>(ref T target) where T : class
		{
			try
			{
				Interlocked.CompareExchange<T>(ref target, Activator.CreateInstance<T>(), default(T));
			}
			catch (MissingMethodException)
			{
				throw new MissingMemberException("The lazily-initialized type does not have a public, parameterless constructor.");
			}
			return target;
		}

		/// <summary>Initializes a target reference type by using a specified function if it hasn't already been initialized.</summary>
		/// <param name="target">The reference of type <paramref name="T" /> to initialize if it hasn't already been initialized.</param>
		/// <param name="valueFactory">The function that is called to initialize the reference.</param>
		/// <typeparam name="T">The reference type of the reference to be initialized.</typeparam>
		/// <returns>The initialized value of type <paramref name="T" />.</returns>
		/// <exception cref="T:System.MissingMemberException">Type <paramref name="T" /> does not have a default constructor.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///         <paramref name="valueFactory" /> returned null (Nothing in Visual Basic).</exception>
		// Token: 0x06001046 RID: 4166 RVA: 0x000441F0 File Offset: 0x000423F0
		public static T EnsureInitialized<T>(ref T target, Func<T> valueFactory) where T : class
		{
			T result;
			if ((result = Volatile.Read<T>(ref target)) == null)
			{
				result = LazyInitializer.EnsureInitializedCore<T>(ref target, valueFactory);
			}
			return result;
		}

		// Token: 0x06001047 RID: 4167 RVA: 0x00044208 File Offset: 0x00042408
		private static T EnsureInitializedCore<T>(ref T target, Func<T> valueFactory) where T : class
		{
			T t = valueFactory();
			if (t == null)
			{
				throw new InvalidOperationException("ValueFactory returned null.");
			}
			Interlocked.CompareExchange<T>(ref target, t, default(T));
			return target;
		}

		// Token: 0x06001048 RID: 4168 RVA: 0x00044246 File Offset: 0x00042446
		public static T EnsureInitialized<T>(ref T target, ref object syncLock, Func<T> valueFactory) where T : class
		{
			T result;
			if ((result = Volatile.Read<T>(ref target)) == null)
			{
				result = LazyInitializer.EnsureInitializedCore<T>(ref target, ref syncLock, valueFactory);
			}
			return result;
		}

		// Token: 0x06001049 RID: 4169 RVA: 0x00044260 File Offset: 0x00042460
		private static T EnsureInitializedCore<T>(ref T target, ref object syncLock, Func<T> valueFactory) where T : class
		{
			object obj = LazyInitializer.EnsureLockInitialized(ref syncLock);
			lock (obj)
			{
				if (Volatile.Read<T>(ref target) == null)
				{
					Volatile.Write<T>(ref target, valueFactory());
					if (target == null)
					{
						throw new InvalidOperationException("ValueFactory returned null.");
					}
				}
			}
			return target;
		}

		// Token: 0x0600104A RID: 4170 RVA: 0x000442D4 File Offset: 0x000424D4
		private static object EnsureLockInitialized(ref object syncLock)
		{
			object result;
			if ((result = syncLock) == null)
			{
				result = (Interlocked.CompareExchange(ref syncLock, new object(), null) ?? syncLock);
			}
			return result;
		}
	}
}
