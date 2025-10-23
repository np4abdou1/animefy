using System;
using System.Diagnostics;
using System.Threading;

namespace System.Buffers
{
	// Token: 0x02000650 RID: 1616
	internal sealed class ConfigurableArrayPool<T> : ArrayPool<T>
	{
		// Token: 0x060030E9 RID: 12521 RVA: 0x000C4DC8 File Offset: 0x000C2FC8
		internal ConfigurableArrayPool() : this(1048576, 50)
		{
		}

		// Token: 0x060030EA RID: 12522 RVA: 0x000C4DD8 File Offset: 0x000C2FD8
		internal ConfigurableArrayPool(int maxArrayLength, int maxArraysPerBucket)
		{
			if (maxArrayLength <= 0)
			{
				throw new ArgumentOutOfRangeException("maxArrayLength");
			}
			if (maxArraysPerBucket <= 0)
			{
				throw new ArgumentOutOfRangeException("maxArraysPerBucket");
			}
			if (maxArrayLength > 1073741824)
			{
				maxArrayLength = 1073741824;
			}
			else if (maxArrayLength < 16)
			{
				maxArrayLength = 16;
			}
			int id = this.Id;
			ConfigurableArrayPool<T>.Bucket[] array = new ConfigurableArrayPool<T>.Bucket[Utilities.SelectBucketIndex(maxArrayLength) + 1];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = new ConfigurableArrayPool<T>.Bucket(Utilities.GetMaxSizeForBucket(i), maxArraysPerBucket, id);
			}
			this._buckets = array;
		}

		// Token: 0x170007E2 RID: 2018
		// (get) Token: 0x060030EB RID: 12523 RVA: 0x000C4E5D File Offset: 0x000C305D
		private int Id
		{
			get
			{
				return this.GetHashCode();
			}
		}

		// Token: 0x060030EC RID: 12524 RVA: 0x000C4E68 File Offset: 0x000C3068
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
			T[] array;
			if (num < this._buckets.Length)
			{
				int num2 = num;
				for (;;)
				{
					array = this._buckets[num2].Rent();
					if (array != null)
					{
						break;
					}
					if (++num2 >= this._buckets.Length || num2 == num + 2)
					{
						goto IL_86;
					}
				}
				if (log.IsEnabled())
				{
					log.BufferRented(array.GetHashCode(), array.Length, this.Id, this._buckets[num2].Id);
				}
				return array;
				IL_86:
				array = new T[this._buckets[num]._bufferLength];
			}
			else
			{
				array = new T[minimumLength];
			}
			if (log.IsEnabled())
			{
				int hashCode = array.GetHashCode();
				int bucketId = -1;
				log.BufferRented(hashCode, array.Length, this.Id, bucketId);
				log.BufferAllocated(hashCode, array.Length, this.Id, bucketId, (num >= this._buckets.Length) ? ArrayPoolEventSource.BufferAllocatedReason.OverMaximumSize : ArrayPoolEventSource.BufferAllocatedReason.PoolExhausted);
			}
			return array;
		}

		// Token: 0x060030ED RID: 12525 RVA: 0x000C4F60 File Offset: 0x000C3160
		public override void Return(T[] array, bool clearArray = false)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (array.Length == 0)
			{
				return;
			}
			int num = Utilities.SelectBucketIndex(array.Length);
			if (num < this._buckets.Length)
			{
				if (clearArray)
				{
					Array.Clear(array, 0, array.Length);
				}
				this._buckets[num].Return(array);
			}
			ArrayPoolEventSource log = ArrayPoolEventSource.Log;
			if (log.IsEnabled())
			{
				log.BufferReturned(array.GetHashCode(), array.Length, this.Id);
			}
		}

		// Token: 0x04001951 RID: 6481
		private readonly ConfigurableArrayPool<T>.Bucket[] _buckets;

		// Token: 0x02000651 RID: 1617
		private sealed class Bucket
		{
			// Token: 0x060030EE RID: 12526 RVA: 0x000C4FD2 File Offset: 0x000C31D2
			internal Bucket(int bufferLength, int numberOfBuffers, int poolId)
			{
				this._lock = new SpinLock(Debugger.IsAttached);
				this._buffers = new T[numberOfBuffers][];
				this._bufferLength = bufferLength;
				this._poolId = poolId;
			}

			// Token: 0x170007E3 RID: 2019
			// (get) Token: 0x060030EF RID: 12527 RVA: 0x000C4E5D File Offset: 0x000C305D
			internal int Id
			{
				get
				{
					return this.GetHashCode();
				}
			}

			// Token: 0x060030F0 RID: 12528 RVA: 0x000C5004 File Offset: 0x000C3204
			internal T[] Rent()
			{
				T[][] buffers = this._buffers;
				T[] array = null;
				bool flag = false;
				bool flag2 = false;
				try
				{
					this._lock.Enter(ref flag);
					if (this._index < buffers.Length)
					{
						array = buffers[this._index];
						T[][] array2 = buffers;
						int index = this._index;
						this._index = index + 1;
						array2[index] = null;
						flag2 = (array == null);
					}
				}
				finally
				{
					if (flag)
					{
						this._lock.Exit(false);
					}
				}
				if (flag2)
				{
					array = new T[this._bufferLength];
					ArrayPoolEventSource log = ArrayPoolEventSource.Log;
					if (log.IsEnabled())
					{
						log.BufferAllocated(array.GetHashCode(), this._bufferLength, this._poolId, this.Id, ArrayPoolEventSource.BufferAllocatedReason.Pooled);
					}
				}
				return array;
			}

			// Token: 0x060030F1 RID: 12529 RVA: 0x000C50C0 File Offset: 0x000C32C0
			internal void Return(T[] array)
			{
				if (array.Length != this._bufferLength)
				{
					throw new ArgumentException("The buffer is not associated with this pool and may not be returned to it.", "array");
				}
				bool flag = false;
				try
				{
					this._lock.Enter(ref flag);
					if (this._index != 0)
					{
						T[][] buffers = this._buffers;
						int num = this._index - 1;
						this._index = num;
						buffers[num] = array;
					}
				}
				finally
				{
					if (flag)
					{
						this._lock.Exit(false);
					}
				}
			}

			// Token: 0x04001952 RID: 6482
			internal readonly int _bufferLength;

			// Token: 0x04001953 RID: 6483
			private readonly T[][] _buffers;

			// Token: 0x04001954 RID: 6484
			private readonly int _poolId;

			// Token: 0x04001955 RID: 6485
			private SpinLock _lock;

			// Token: 0x04001956 RID: 6486
			private int _index;
		}
	}
}
