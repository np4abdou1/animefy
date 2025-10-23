using System;
using System.Collections;
using System.Collections.Generic;
using Java.Lang;

namespace Android.Runtime
{
	// Token: 0x020002CD RID: 717
	[Register("mono/android/runtime/JavaArray", DoNotGenerateAcw = true)]
	public sealed class JavaArray<T> : Java.Lang.Object, IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
	{
		// Token: 0x06001B15 RID: 6933 RVA: 0x000021E0 File Offset: 0x000003E0
		public JavaArray(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x06001B16 RID: 6934 RVA: 0x000469B0 File Offset: 0x00044BB0
		public int Count
		{
			get
			{
				return JNIEnv.GetArrayLength(base.Handle);
			}
		}

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x06001B17 RID: 6935 RVA: 0x00045ABE File Offset: 0x00043CBE
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170005D2 RID: 1490
		public T this[int index]
		{
			get
			{
				if (index < 0 || index >= this.Count)
				{
					throw new ArgumentOutOfRangeException("index");
				}
				return JNIEnv.GetArrayItem<T>(base.Handle, index);
			}
			set
			{
				JNIEnv.SetArrayItem<T>(base.Handle, index, value);
			}
		}

		// Token: 0x06001B1A RID: 6938 RVA: 0x000469F2 File Offset: 0x00044BF2
		public void Add(T item)
		{
			throw new InvalidOperationException();
		}

		// Token: 0x06001B1B RID: 6939 RVA: 0x000469F2 File Offset: 0x00044BF2
		public void Clear()
		{
			throw new InvalidOperationException();
		}

		// Token: 0x06001B1C RID: 6940 RVA: 0x000469F9 File Offset: 0x00044BF9
		public bool Contains(T item)
		{
			return this.IndexOf(item) >= 0;
		}

		// Token: 0x06001B1D RID: 6941 RVA: 0x00046A08 File Offset: 0x00044C08
		public void CopyTo(T[] array, int array_index)
		{
			T[] array2 = JNIEnv.GetArray<T>(base.Handle);
			for (int i = 0; i < this.Count; i++)
			{
				array[array_index + i] = array2[i];
			}
		}

		// Token: 0x06001B1E RID: 6942 RVA: 0x00046A42 File Offset: 0x00044C42
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x06001B1F RID: 6943 RVA: 0x00046A4A File Offset: 0x00044C4A
		public IEnumerator<T> GetEnumerator()
		{
			T[] items = JNIEnv.GetArray<T>(base.Handle);
			int num;
			for (int i = 0; i < items.Length; i = num + 1)
			{
				yield return items[i];
				num = i;
			}
			yield break;
		}

		// Token: 0x06001B20 RID: 6944 RVA: 0x00046A59 File Offset: 0x00044C59
		public int IndexOf(T item)
		{
			return Array.IndexOf<T>(JNIEnv.GetArray<T>(base.Handle), item);
		}

		// Token: 0x06001B21 RID: 6945 RVA: 0x000469F2 File Offset: 0x00044BF2
		public void Insert(int index, T item)
		{
			throw new InvalidOperationException();
		}

		// Token: 0x06001B22 RID: 6946 RVA: 0x000469F2 File Offset: 0x00044BF2
		public bool Remove(T item)
		{
			throw new InvalidOperationException();
		}

		// Token: 0x06001B23 RID: 6947 RVA: 0x000469F2 File Offset: 0x00044BF2
		public void RemoveAt(int index)
		{
			throw new InvalidOperationException();
		}

		// Token: 0x06001B24 RID: 6948 RVA: 0x00046A6C File Offset: 0x00044C6C
		public static JavaArray<T> FromJniHandle(IntPtr handle, JniHandleOwnership transfer)
		{
			if (handle == IntPtr.Zero)
			{
				return null;
			}
			JavaArray<T> javaArray = Java.Lang.Object.PeekObject(handle, null) as JavaArray<T>;
			if (javaArray != null)
			{
				JNIEnv.DeleteRef(handle, transfer);
				return javaArray;
			}
			return new JavaArray<T>(handle, transfer);
		}

		// Token: 0x06001B25 RID: 6949 RVA: 0x00046AA8 File Offset: 0x00044CA8
		public static IntPtr ToLocalJniHandle(IList<T> value)
		{
			if (value == null)
			{
				return IntPtr.Zero;
			}
			JavaArray<T> javaArray = value as JavaArray<T>;
			if (javaArray != null)
			{
				return JNIEnv.ToLocalJniHandle(javaArray);
			}
			T[] array = new T[value.Count];
			value.CopyTo(array, 0);
			return JNIEnv.NewArray(array, typeof(T));
		}
	}
}
