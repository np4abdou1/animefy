using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Internal.Runtime.Augments;

namespace System.Buffers
{
	// Token: 0x02000655 RID: 1621
	internal sealed class TlsOverPerCoreLockedStacksArrayPool<T> : ArrayPool<T>
	{
		// Token: 0x060030F9 RID: 12537 RVA: 0x000C51A4 File Offset: 0x000C33A4
		public TlsOverPerCoreLockedStacksArrayPool()
		{
			int[] array = new int[17];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = Utilities.GetMaxSizeForBucket(i);
			}
			this._bucketArraySizes = array;
		}

		// Token: 0x060030FA RID: 12538 RVA: 0x000C51EC File Offset: 0x000C33EC
		private TlsOverPerCoreLockedStacksArrayPool<T>.PerCoreLockedStacks CreatePerCoreLockedStacks(int bucketIndex)
		{
			TlsOverPerCoreLockedStacksArrayPool<T>.PerCoreLockedStacks perCoreLockedStacks = new TlsOverPerCoreLockedStacksArrayPool<T>.PerCoreLockedStacks();
			return Interlocked.CompareExchange<TlsOverPerCoreLockedStacksArrayPool<T>.PerCoreLockedStacks>(ref this._buckets[bucketIndex], perCoreLockedStacks, null) ?? perCoreLockedStacks;
		}

		// Token: 0x170007E5 RID: 2021
		// (get) Token: 0x060030FB RID: 12539 RVA: 0x000C4E5D File Offset: 0x000C305D
		private int Id
		{
			get
			{
				return this.GetHashCode();
			}
		}

		// Token: 0x060030FC RID: 12540 RVA: 0x000C5218 File Offset: 0x000C3418
		public override T[] Rent(int minimumLength)
		{
			if (minimumLength < 0)
			{
				throw new ArgumentOutOfRangeException("minimumLength");
			}
			if (minimumLength == 0)
			{
				return Array.Empty<T>();
			}
			ArrayPoolEventSource log = ArrayPoolEventSource.Log;
			int num = Utilities.SelectBucketIndex(minimumLength);
			T[] array2;
			if (num < this._buckets.Length)
			{
				T[][] array = TlsOverPerCoreLockedStacksArrayPool<T>.t_tlsBuckets;
				if (array != null)
				{
					array2 = array[num];
					if (array2 != null)
					{
						array[num] = null;
						if (log.IsEnabled())
						{
							log.BufferRented(array2.GetHashCode(), array2.Length, this.Id, num);
						}
						return array2;
					}
				}
				TlsOverPerCoreLockedStacksArrayPool<T>.PerCoreLockedStacks perCoreLockedStacks = this._buckets[num];
				if (perCoreLockedStacks != null)
				{
					array2 = perCoreLockedStacks.TryPop();
					if (array2 != null)
					{
						if (log.IsEnabled())
						{
							log.BufferRented(array2.GetHashCode(), array2.Length, this.Id, num);
						}
						return array2;
					}
				}
				array2 = new T[this._bucketArraySizes[num]];
			}
			else
			{
				array2 = new T[minimumLength];
			}
			if (log.IsEnabled())
			{
				int hashCode = array2.GetHashCode();
				int bucketId = -1;
				log.BufferRented(hashCode, array2.Length, this.Id, bucketId);
				log.BufferAllocated(hashCode, array2.Length, this.Id, bucketId, (num >= this._buckets.Length) ? ArrayPoolEventSource.BufferAllocatedReason.OverMaximumSize : ArrayPoolEventSource.BufferAllocatedReason.PoolExhausted);
			}
			return array2;
		}

		// Token: 0x060030FD RID: 12541 RVA: 0x000C5324 File Offset: 0x000C3524
		public override void Return(T[] array, bool clearArray = false)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			int num = Utilities.SelectBucketIndex(array.Length);
			if (num < this._buckets.Length)
			{
				if (clearArray)
				{
					Array.Clear(array, 0, array.Length);
				}
				if (array.Length != this._bucketArraySizes[num])
				{
					throw new ArgumentException("The buffer is not associated with this pool and may not be returned to it.", "array");
				}
				T[][] array2 = TlsOverPerCoreLockedStacksArrayPool<T>.t_tlsBuckets;
				if (array2 == null)
				{
					array2 = (TlsOverPerCoreLockedStacksArrayPool<T>.t_tlsBuckets = new T[17][]);
					array2[num] = array;
					if (TlsOverPerCoreLockedStacksArrayPool<T>.s_trimBuffers)
					{
						TlsOverPerCoreLockedStacksArrayPool<T>.s_allTlsBuckets.Add(array2, null);
						if (Interlocked.Exchange(ref this._callbackCreated, 1) != 1)
						{
							Gen2GcCallback.Register(new Func<object, bool>(TlsOverPerCoreLockedStacksArrayPool<T>.Gen2GcCallbackFunc), this);
						}
					}
				}
				else
				{
					T[] array3 = array2[num];
					array2[num] = array;
					if (array3 != null)
					{
						(this._buckets[num] ?? this.CreatePerCoreLockedStacks(num)).TryPush(array3);
					}
				}
			}
			ArrayPoolEventSource log = ArrayPoolEventSource.Log;
			if (log.IsEnabled())
			{
				log.BufferReturned(array.GetHashCode(), array.Length, this.Id);
			}
		}

		// Token: 0x060030FE RID: 12542 RVA: 0x000C5418 File Offset: 0x000C3618
		public bool Trim()
		{
			int tickCount = Environment.TickCount;
			TlsOverPerCoreLockedStacksArrayPool<T>.MemoryPressure memoryPressure = TlsOverPerCoreLockedStacksArrayPool<T>.GetMemoryPressure();
			ArrayPoolEventSource log = ArrayPoolEventSource.Log;
			if (log.IsEnabled())
			{
				log.BufferTrimPoll(tickCount, (int)memoryPressure);
			}
			foreach (TlsOverPerCoreLockedStacksArrayPool<T>.PerCoreLockedStacks perCoreLockedStacks in this._buckets)
			{
				if (perCoreLockedStacks != null)
				{
					perCoreLockedStacks.Trim((uint)tickCount, this.Id, memoryPressure, this._bucketArraySizes);
				}
			}
			if (memoryPressure == TlsOverPerCoreLockedStacksArrayPool<T>.MemoryPressure.High)
			{
				if (log.IsEnabled())
				{
					using (IEnumerator<KeyValuePair<T[][], object>> enumerator = ((IEnumerable<KeyValuePair<T[][], object>>)TlsOverPerCoreLockedStacksArrayPool<T>.s_allTlsBuckets).GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							KeyValuePair<T[][], object> keyValuePair = enumerator.Current;
							T[][] key = keyValuePair.Key;
							for (int j = 0; j < key.Length; j++)
							{
								T[] array = Interlocked.Exchange<T[]>(ref key[j], null);
								if (array != null)
								{
									log.BufferTrimmed(array.GetHashCode(), array.Length, this.Id);
								}
							}
						}
						return true;
					}
				}
				foreach (KeyValuePair<T[][], object> keyValuePair2 in ((IEnumerable<KeyValuePair<T[][], object>>)TlsOverPerCoreLockedStacksArrayPool<T>.s_allTlsBuckets))
				{
					T[][] key2 = keyValuePair2.Key;
					Array.Clear(key2, 0, key2.Length);
				}
			}
			return true;
		}

		// Token: 0x060030FF RID: 12543 RVA: 0x000C5564 File Offset: 0x000C3764
		private static bool Gen2GcCallbackFunc(object target)
		{
			return ((TlsOverPerCoreLockedStacksArrayPool<T>)target).Trim();
		}

		// Token: 0x06003100 RID: 12544 RVA: 0x000C5574 File Offset: 0x000C3774
		private static TlsOverPerCoreLockedStacksArrayPool<T>.MemoryPressure GetMemoryPressure()
		{
			uint num;
			ulong num2;
			uint num3;
			UIntPtr uintPtr;
			UIntPtr uintPtr2;
			GC.GetMemoryInfo(out num, out num2, out num3, out uintPtr, out uintPtr2);
			if (num3 >= num * 0.9)
			{
				return TlsOverPerCoreLockedStacksArrayPool<T>.MemoryPressure.High;
			}
			if (num3 >= num * 0.7)
			{
				return TlsOverPerCoreLockedStacksArrayPool<T>.MemoryPressure.Medium;
			}
			return TlsOverPerCoreLockedStacksArrayPool<T>.MemoryPressure.Low;
		}

		// Token: 0x06003101 RID: 12545 RVA: 0x0000B18D File Offset: 0x0000938D
		private static bool GetTrimBuffers()
		{
			return true;
		}

		// Token: 0x0400195A RID: 6490
		private readonly int[] _bucketArraySizes;

		// Token: 0x0400195B RID: 6491
		private readonly TlsOverPerCoreLockedStacksArrayPool<T>.PerCoreLockedStacks[] _buckets = new TlsOverPerCoreLockedStacksArrayPool<T>.PerCoreLockedStacks[17];

		// Token: 0x0400195C RID: 6492
		[ThreadStatic]
		private static T[][] t_tlsBuckets;

		// Token: 0x0400195D RID: 6493
		private int _callbackCreated;

		// Token: 0x0400195E RID: 6494
		private static readonly bool s_trimBuffers = TlsOverPerCoreLockedStacksArrayPool<T>.GetTrimBuffers();

		// Token: 0x0400195F RID: 6495
		private static readonly ConditionalWeakTable<T[][], object> s_allTlsBuckets = TlsOverPerCoreLockedStacksArrayPool<T>.s_trimBuffers ? new ConditionalWeakTable<T[][], object>() : null;

		// Token: 0x02000656 RID: 1622
		private enum MemoryPressure
		{
			// Token: 0x04001961 RID: 6497
			Low,
			// Token: 0x04001962 RID: 6498
			Medium,
			// Token: 0x04001963 RID: 6499
			High
		}

		// Token: 0x02000657 RID: 1623
		private sealed class PerCoreLockedStacks
		{
			// Token: 0x06003103 RID: 12547 RVA: 0x000C55DC File Offset: 0x000C37DC
			public PerCoreLockedStacks()
			{
				TlsOverPerCoreLockedStacksArrayPool<T>.LockedStack[] array = new TlsOverPerCoreLockedStacksArrayPool<T>.LockedStack[Math.Min(Environment.ProcessorCount, 64)];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = new TlsOverPerCoreLockedStacksArrayPool<T>.LockedStack();
				}
				this._perCoreStacks = array;
			}

			// Token: 0x06003104 RID: 12548 RVA: 0x000C5620 File Offset: 0x000C3820
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public void TryPush(T[] array)
			{
				TlsOverPerCoreLockedStacksArrayPool<T>.LockedStack[] perCoreStacks = this._perCoreStacks;
				int num = RuntimeThread.GetCurrentProcessorId() % perCoreStacks.Length;
				for (int i = 0; i < perCoreStacks.Length; i++)
				{
					if (perCoreStacks[num].TryPush(array))
					{
						return;
					}
					if (++num == perCoreStacks.Length)
					{
						num = 0;
					}
				}
			}

			// Token: 0x06003105 RID: 12549 RVA: 0x000C5664 File Offset: 0x000C3864
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public T[] TryPop()
			{
				TlsOverPerCoreLockedStacksArrayPool<T>.LockedStack[] perCoreStacks = this._perCoreStacks;
				int num = RuntimeThread.GetCurrentProcessorId() % perCoreStacks.Length;
				for (int i = 0; i < perCoreStacks.Length; i++)
				{
					T[] result;
					if ((result = perCoreStacks[num].TryPop()) != null)
					{
						return result;
					}
					if (++num == perCoreStacks.Length)
					{
						num = 0;
					}
				}
				return null;
			}

			// Token: 0x06003106 RID: 12550 RVA: 0x000C56AC File Offset: 0x000C38AC
			public bool Trim(uint tickCount, int id, TlsOverPerCoreLockedStacksArrayPool<T>.MemoryPressure pressure, int[] bucketSizes)
			{
				TlsOverPerCoreLockedStacksArrayPool<T>.LockedStack[] perCoreStacks = this._perCoreStacks;
				for (int i = 0; i < perCoreStacks.Length; i++)
				{
					perCoreStacks[i].Trim(tickCount, id, pressure, bucketSizes[i]);
				}
				return true;
			}

			// Token: 0x04001964 RID: 6500
			private readonly TlsOverPerCoreLockedStacksArrayPool<T>.LockedStack[] _perCoreStacks;
		}

		// Token: 0x02000658 RID: 1624
		private sealed class LockedStack
		{
			// Token: 0x06003107 RID: 12551 RVA: 0x000C56E0 File Offset: 0x000C38E0
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public bool TryPush(T[] array)
			{
				bool result = false;
				Monitor.Enter(this);
				if (this._count < 8)
				{
					if (TlsOverPerCoreLockedStacksArrayPool<T>.s_trimBuffers && this._count == 0)
					{
						this._firstStackItemMS = (uint)Environment.TickCount;
					}
					T[][] arrays = this._arrays;
					int count = this._count;
					this._count = count + 1;
					arrays[count] = array;
					result = true;
				}
				Monitor.Exit(this);
				return result;
			}

			// Token: 0x06003108 RID: 12552 RVA: 0x000C573C File Offset: 0x000C393C
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public T[] TryPop()
			{
				T[] result = null;
				Monitor.Enter(this);
				if (this._count > 0)
				{
					T[][] arrays = this._arrays;
					int num = this._count - 1;
					this._count = num;
					result = arrays[num];
					this._arrays[this._count] = null;
				}
				Monitor.Exit(this);
				return result;
			}

			// Token: 0x06003109 RID: 12553 RVA: 0x000C5788 File Offset: 0x000C3988
			public void Trim(uint tickCount, int id, TlsOverPerCoreLockedStacksArrayPool<T>.MemoryPressure pressure, int bucketSize)
			{
				if (this._count == 0)
				{
					return;
				}
				uint num = (pressure == TlsOverPerCoreLockedStacksArrayPool<T>.MemoryPressure.High) ? 10000U : 60000U;
				lock (this)
				{
					if ((this._count > 0 && this._firstStackItemMS > tickCount) || tickCount - this._firstStackItemMS > num)
					{
						ArrayPoolEventSource log = ArrayPoolEventSource.Log;
						int num2 = 1;
						if (pressure != TlsOverPerCoreLockedStacksArrayPool<T>.MemoryPressure.Medium)
						{
							if (pressure == TlsOverPerCoreLockedStacksArrayPool<T>.MemoryPressure.High)
							{
								num2 = 8;
								if (bucketSize > 16384)
								{
									num2++;
								}
								if (Unsafe.SizeOf<T>() > 16)
								{
									num2++;
								}
								if (Unsafe.SizeOf<T>() > 32)
								{
									num2++;
								}
							}
						}
						else
						{
							num2 = 2;
						}
						while (this._count > 0 && num2-- > 0)
						{
							T[][] arrays = this._arrays;
							int num3 = this._count - 1;
							this._count = num3;
							T[] array = arrays[num3];
							this._arrays[this._count] = null;
							if (log.IsEnabled())
							{
								log.BufferTrimmed(array.GetHashCode(), array.Length, id);
							}
						}
						if (this._count > 0 && this._firstStackItemMS < 4294952295U)
						{
							this._firstStackItemMS += 15000U;
						}
					}
				}
			}

			// Token: 0x04001965 RID: 6501
			private readonly T[][] _arrays = new T[8][];

			// Token: 0x04001966 RID: 6502
			private int _count;

			// Token: 0x04001967 RID: 6503
			private uint _firstStackItemMS;
		}
	}
}
