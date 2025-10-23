using System;

namespace System.Buffers
{
	// Token: 0x0200064D RID: 1613
	public abstract class ArrayPool<T>
	{
		// Token: 0x170007E1 RID: 2017
		// (get) Token: 0x060030DB RID: 12507 RVA: 0x000C4B30 File Offset: 0x000C2D30
		public static ArrayPool<T> Shared { get; } = new TlsOverPerCoreLockedStacksArrayPool<T>();

		// Token: 0x060030DC RID: 12508 RVA: 0x000C4B37 File Offset: 0x000C2D37
		public static ArrayPool<T> Create()
		{
			return new ConfigurableArrayPool<T>();
		}

		// Token: 0x060030DD RID: 12509 RVA: 0x000C4B3E File Offset: 0x000C2D3E
		public static ArrayPool<T> Create(int maxArrayLength, int maxArraysPerBucket)
		{
			return new ConfigurableArrayPool<T>(maxArrayLength, maxArraysPerBucket);
		}

		// Token: 0x060030DE RID: 12510
		public abstract T[] Rent(int minimumLength);

		// Token: 0x060030DF RID: 12511
		public abstract void Return(T[] array, bool clearArray = false);
	}
}
