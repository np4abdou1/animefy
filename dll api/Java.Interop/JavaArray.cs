using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace Java.Interop
{
	// Token: 0x02000006 RID: 6
	public abstract class JavaArray<T> : JavaObject, IList, ICollection, IEnumerable, IList<T>, ICollection<T>, IEnumerable<T>
	{
		// Token: 0x06000014 RID: 20 RVA: 0x00002199 File Offset: 0x00000399
		internal JavaArray(ref JniObjectReference handle, JniObjectReferenceOptions transfer) : base(ref handle, transfer)
		{
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000015 RID: 21 RVA: 0x000021A3 File Offset: 0x000003A3
		public int Length
		{
			get
			{
				return JniEnvironment.Arrays.GetArrayLength(base.PeerReference);
			}
		}

		// Token: 0x17000008 RID: 8
		public abstract T this[int index]
		{
			get;
			set;
		}

		// Token: 0x06000018 RID: 24
		public abstract void Clear();

		// Token: 0x06000019 RID: 25
		public abstract void CopyTo(T[] array, int arrayIndex);

		// Token: 0x0600001A RID: 26
		public abstract int IndexOf(T item);

		// Token: 0x0600001B RID: 27 RVA: 0x000021B0 File Offset: 0x000003B0
		public virtual bool Contains(T item)
		{
			return this.IndexOf(item) >= 0;
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600001C RID: 28 RVA: 0x000021BF File Offset: 0x000003BF
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000021C4 File Offset: 0x000003C4
		public T[] ToArray()
		{
			T[] array = new T[this.Length];
			this.CopyTo(array, 0);
			return array;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000021E6 File Offset: 0x000003E6
		public virtual IEnumerator<T> GetEnumerator()
		{
			int len = this.Length;
			int num;
			for (int i = 0; i < len; i = num)
			{
				yield return this[i];
				num = i + 1;
			}
			yield break;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000021F8 File Offset: 0x000003F8
		internal static void CheckArrayCopy(int sourceIndex, int sourceLength, int destinationIndex, int destinationLength, int length)
		{
			if (sourceIndex < 0)
			{
				throw new ArgumentOutOfRangeException("sourceIndex", string.Format("source index must be >= 0; was {0}.", sourceIndex));
			}
			if (sourceIndex != 0 && sourceIndex >= sourceLength)
			{
				throw new ArgumentException("source index is > source length.", "sourceIndex");
			}
			checked
			{
				if (sourceIndex + length > sourceLength)
				{
					throw new ArgumentException("source index + length >= source length", "length");
				}
				if (destinationIndex < 0)
				{
					throw new ArgumentOutOfRangeException("destinationIndex", string.Format("destination index must be >= 0; was {0}.", destinationIndex));
				}
				if (destinationIndex != 0 && destinationIndex >= destinationLength)
				{
					throw new ArgumentException("destination index is > destination length.", "destinationIndex");
				}
				if (destinationIndex + length > destinationLength)
				{
					throw new ArgumentException("destination index + length >= destination length", "length");
				}
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x0000229F File Offset: 0x0000049F
		internal static int CheckLength(int length)
		{
			if (length < 0)
			{
				throw new ArgumentException("'length' cannot be negative.", "length");
			}
			return length;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000022B6 File Offset: 0x000004B6
		internal static int CheckLength(IList<T> value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			return value.Count;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000022CC File Offset: 0x000004CC
		internal IList<T> ToTargetType(Type targetType, bool dispose)
		{
			if (this.TargetTypeIsCurrentType(targetType))
			{
				return this;
			}
			if (targetType == typeof(T[]) || targetType.IsAssignableFrom(typeof(IList<!0>)))
			{
				try
				{
					return this.ToArray();
				}
				finally
				{
					if (dispose)
					{
						base.Dispose();
					}
				}
			}
			throw JavaArray<T>.CreateMarshalNotSupportedException(base.GetType(), targetType);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x0000233C File Offset: 0x0000053C
		internal virtual bool TargetTypeIsCurrentType(Type targetType)
		{
			return targetType == null || targetType == typeof(JavaArray<T>);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002359 File Offset: 0x00000559
		internal static Exception CreateMarshalNotSupportedException(Type sourceType, Type targetType)
		{
			return new NotSupportedException(string.Format("Do not know how to marshal a `{0}`{1}.", sourceType.FullName, (targetType != null) ? (" into a `" + targetType.FullName + "`") : ""));
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002395 File Offset: 0x00000595
		internal static IList<T> CreateValue<TArray>(ref JniObjectReference reference, JniObjectReferenceOptions transfer, Type targetType, JavaArray<T>.ArrayCreator<TArray> creator) where TArray : JavaArray<T>
		{
			return creator(ref reference, transfer).ToTargetType(targetType, true);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000023AC File Offset: 0x000005AC
		internal static JniValueMarshalerState CreateArgumentState<TArray>(IList<T> value, ParameterAttributes synchronize, Func<IList<T>, bool, TArray> creator) where TArray : JavaArray<T>
		{
			if (value == null)
			{
				return default(JniValueMarshalerState);
			}
			TArray tarray = value as TArray;
			if (tarray != null)
			{
				return new JniValueMarshalerState(tarray, null);
			}
			if (value == null)
			{
				throw JavaArray<T>.CreateMarshalNotSupportedException(value.GetType(), typeof(TArray));
			}
			synchronize = JavaArray<T>.GetCopyDirection(synchronize);
			bool arg = (synchronize & ParameterAttributes.In) == ParameterAttributes.In;
			return new JniValueMarshalerState(creator(value, arg), null);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002424 File Offset: 0x00000624
		internal static void DestroyArgumentState<TArray>(IList<T> value, ref JniValueMarshalerState state, ParameterAttributes synchronize) where TArray : JavaArray<T>
		{
			TArray tarray = (TArray)((object)state.PeerableValue);
			if (tarray == null)
			{
				return;
			}
			synchronize = JavaArray<T>.GetCopyDirection(synchronize);
			if ((synchronize & ParameterAttributes.Out) == ParameterAttributes.Out)
			{
				T[] array = value as T[];
				if (array != null)
				{
					tarray.CopyTo(array, 0);
				}
				else if (value != null)
				{
					tarray.CopyToList(value, 0);
				}
			}
			if (tarray.forMarshalCollection)
			{
				tarray.Dispose();
			}
			state = default(JniValueMarshalerState);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000249E File Offset: 0x0000069E
		internal static ParameterAttributes GetCopyDirection(ParameterAttributes value)
		{
			if ((value & (ParameterAttributes.In | ParameterAttributes.Out)) != ParameterAttributes.None)
			{
				return value & (ParameterAttributes.In | ParameterAttributes.Out);
			}
			return ParameterAttributes.In | ParameterAttributes.Out;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000024AC File Offset: 0x000006AC
		internal virtual void CopyToList(IList<T> list, int index)
		{
			int length = this.Length;
			for (int i = 0; i < length; i++)
			{
				list[index + i] = this[i];
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600002A RID: 42 RVA: 0x000021BF File Offset: 0x000003BF
		bool ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600002B RID: 43 RVA: 0x000024DC File Offset: 0x000006DC
		object ICollection.SyncRoot
		{
			get
			{
				return this;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600002C RID: 44 RVA: 0x000024DF File Offset: 0x000006DF
		int ICollection<!0>.Count
		{
			get
			{
				return this.Length;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600002D RID: 45 RVA: 0x000024DF File Offset: 0x000006DF
		int ICollection.Count
		{
			get
			{
				return this.Length;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600002E RID: 46 RVA: 0x000024E7 File Offset: 0x000006E7
		bool IList.IsFixedSize
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700000F RID: 15
		object IList.this[int index]
		{
			get
			{
				return this[index];
			}
			set
			{
				this[index] = (T)((object)value);
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002508 File Offset: 0x00000708
		void ICollection.CopyTo(Array array, int index)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			JavaArray<T>.CheckArrayCopy(0, this.Length, index, array.Length, this.Length);
			int length = this.Length;
			for (int i = 0; i < length; i++)
			{
				array.SetValue(this[i], index + i);
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002564 File Offset: 0x00000764
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x06000033 RID: 51 RVA: 0x0000256C File Offset: 0x0000076C
		void ICollection<!0>.Add(T item)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06000034 RID: 52 RVA: 0x0000256C File Offset: 0x0000076C
		bool ICollection<!0>.Remove(T item)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002573 File Offset: 0x00000773
		bool IList.Contains(object value)
		{
			return value is T && this.Contains((T)((object)value));
		}

		// Token: 0x06000036 RID: 54 RVA: 0x0000258B File Offset: 0x0000078B
		int IList.IndexOf(object value)
		{
			if (value is T)
			{
				return this.IndexOf((T)((object)value));
			}
			return -1;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x0000256C File Offset: 0x0000076C
		int IList.Add(object value)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06000038 RID: 56 RVA: 0x0000256C File Offset: 0x0000076C
		void IList.Insert(int index, object value)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06000039 RID: 57 RVA: 0x0000256C File Offset: 0x0000076C
		void IList.Remove(object value)
		{
			throw new NotSupportedException();
		}

		// Token: 0x0600003A RID: 58 RVA: 0x0000256C File Offset: 0x0000076C
		void IList.RemoveAt(int index)
		{
			throw new NotSupportedException();
		}

		// Token: 0x0600003B RID: 59 RVA: 0x0000256C File Offset: 0x0000076C
		void IList<!0>.Insert(int index, T item)
		{
			throw new NotSupportedException();
		}

		// Token: 0x0600003C RID: 60 RVA: 0x0000256C File Offset: 0x0000076C
		void IList<!0>.RemoveAt(int index)
		{
			throw new NotSupportedException();
		}

		// Token: 0x04000004 RID: 4
		internal bool forMarshalCollection;

		// Token: 0x02000007 RID: 7
		// (Invoke) Token: 0x0600003E RID: 62
		internal delegate TArray ArrayCreator<TArray>(ref JniObjectReference reference, JniObjectReferenceOptions transfer) where TArray : JavaArray<T>;
	}
}
