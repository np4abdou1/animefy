using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000099 RID: 153
	[NullableContext(1)]
	[Nullable(0)]
	internal class CollectionWrapper<[Nullable(2)] T> : ICollection<T>, IEnumerable<!0>, IEnumerable, IWrappedCollection, IList, ICollection
	{
		// Token: 0x0600050A RID: 1290 RVA: 0x0001B58C File Offset: 0x0001978C
		public CollectionWrapper(IList list)
		{
			ValidationUtils.ArgumentNotNull(list, "list");
			ICollection<T> collection = list as ICollection<T>;
			if (collection != null)
			{
				this._genericCollection = collection;
				return;
			}
			this._list = list;
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x0001B5C3 File Offset: 0x000197C3
		public CollectionWrapper(ICollection<T> list)
		{
			ValidationUtils.ArgumentNotNull(list, "list");
			this._genericCollection = list;
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x0001B5DD File Offset: 0x000197DD
		public virtual void Add(T item)
		{
			if (this._genericCollection != null)
			{
				this._genericCollection.Add(item);
				return;
			}
			this._list.Add(item);
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x0001B606 File Offset: 0x00019806
		public virtual void Clear()
		{
			if (this._genericCollection != null)
			{
				this._genericCollection.Clear();
				return;
			}
			this._list.Clear();
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x0001B627 File Offset: 0x00019827
		public virtual bool Contains(T item)
		{
			if (this._genericCollection != null)
			{
				return this._genericCollection.Contains(item);
			}
			return this._list.Contains(item);
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x0001B64F File Offset: 0x0001984F
		public virtual void CopyTo(T[] array, int arrayIndex)
		{
			if (this._genericCollection != null)
			{
				this._genericCollection.CopyTo(array, arrayIndex);
				return;
			}
			this._list.CopyTo(array, arrayIndex);
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000510 RID: 1296 RVA: 0x0001B674 File Offset: 0x00019874
		public virtual int Count
		{
			get
			{
				if (this._genericCollection != null)
				{
					return this._genericCollection.Count;
				}
				return this._list.Count;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000511 RID: 1297 RVA: 0x0001B695 File Offset: 0x00019895
		public virtual bool IsReadOnly
		{
			get
			{
				if (this._genericCollection != null)
				{
					return this._genericCollection.IsReadOnly;
				}
				return this._list.IsReadOnly;
			}
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x0001B6B6 File Offset: 0x000198B6
		public virtual bool Remove(T item)
		{
			if (this._genericCollection != null)
			{
				return this._genericCollection.Remove(item);
			}
			bool flag = this._list.Contains(item);
			if (flag)
			{
				this._list.Remove(item);
			}
			return flag;
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x0001B6F4 File Offset: 0x000198F4
		public virtual IEnumerator<T> GetEnumerator()
		{
			IEnumerable<T> genericCollection = this._genericCollection;
			return (genericCollection ?? this._list.Cast<T>()).GetEnumerator();
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x0001B720 File Offset: 0x00019920
		IEnumerator IEnumerable.GetEnumerator()
		{
			IEnumerable genericCollection = this._genericCollection;
			return (genericCollection ?? this._list).GetEnumerator();
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x0001B744 File Offset: 0x00019944
		[NullableContext(2)]
		int IList.Add(object value)
		{
			CollectionWrapper<T>.VerifyValueType(value);
			this.Add((T)((object)value));
			return this.Count - 1;
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x0001B760 File Offset: 0x00019960
		[NullableContext(2)]
		bool IList.Contains(object value)
		{
			return CollectionWrapper<T>.IsCompatibleObject(value) && this.Contains((T)((object)value));
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x0001B778 File Offset: 0x00019978
		[NullableContext(2)]
		int IList.IndexOf(object value)
		{
			if (this._genericCollection != null)
			{
				throw new InvalidOperationException("Wrapped ICollection<T> does not support IndexOf.");
			}
			if (CollectionWrapper<T>.IsCompatibleObject(value))
			{
				return this._list.IndexOf((T)((object)value));
			}
			return -1;
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x0001B7AD File Offset: 0x000199AD
		void IList.RemoveAt(int index)
		{
			if (this._genericCollection != null)
			{
				throw new InvalidOperationException("Wrapped ICollection<T> does not support RemoveAt.");
			}
			this._list.RemoveAt(index);
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x0001B7CE File Offset: 0x000199CE
		[NullableContext(2)]
		void IList.Insert(int index, object value)
		{
			if (this._genericCollection != null)
			{
				throw new InvalidOperationException("Wrapped ICollection<T> does not support Insert.");
			}
			CollectionWrapper<T>.VerifyValueType(value);
			this._list.Insert(index, (T)((object)value));
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x0600051A RID: 1306 RVA: 0x0001B800 File Offset: 0x00019A00
		bool IList.IsFixedSize
		{
			get
			{
				if (this._genericCollection != null)
				{
					return this._genericCollection.IsReadOnly;
				}
				return this._list.IsFixedSize;
			}
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x0001B821 File Offset: 0x00019A21
		[NullableContext(2)]
		void IList.Remove(object value)
		{
			if (CollectionWrapper<T>.IsCompatibleObject(value))
			{
				this.Remove((T)((object)value));
			}
		}

		// Token: 0x170000B0 RID: 176
		[Nullable(2)]
		object IList.this[int index]
		{
			[NullableContext(2)]
			get
			{
				if (this._genericCollection != null)
				{
					throw new InvalidOperationException("Wrapped ICollection<T> does not support indexer.");
				}
				return this._list[index];
			}
			[NullableContext(2)]
			set
			{
				if (this._genericCollection != null)
				{
					throw new InvalidOperationException("Wrapped ICollection<T> does not support indexer.");
				}
				CollectionWrapper<T>.VerifyValueType(value);
				this._list[index] = (T)((object)value);
			}
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x0001B88B File Offset: 0x00019A8B
		void ICollection.CopyTo(Array array, int arrayIndex)
		{
			this.CopyTo((T[])array, arrayIndex);
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x0600051F RID: 1311 RVA: 0x00016B42 File Offset: 0x00014D42
		bool ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000520 RID: 1312 RVA: 0x0001B89A File Offset: 0x00019A9A
		object ICollection.SyncRoot
		{
			get
			{
				if (this._syncRoot == null)
				{
					Interlocked.CompareExchange(ref this._syncRoot, new object(), null);
				}
				return this._syncRoot;
			}
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x0001B8BC File Offset: 0x00019ABC
		[NullableContext(2)]
		private static void VerifyValueType(object value)
		{
			if (!CollectionWrapper<T>.IsCompatibleObject(value))
			{
				throw new ArgumentException("The value '{0}' is not of type '{1}' and cannot be used in this generic collection.".FormatWith(CultureInfo.InvariantCulture, value, typeof(T)), "value");
			}
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x0001B8EB File Offset: 0x00019AEB
		[NullableContext(2)]
		private static bool IsCompatibleObject(object value)
		{
			return value is T || (value == null && (!typeof(T).IsValueType() || ReflectionUtils.IsNullableType(typeof(T))));
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000523 RID: 1315 RVA: 0x0001B91D File Offset: 0x00019B1D
		public object UnderlyingCollection
		{
			get
			{
				return this._genericCollection ?? this._list;
			}
		}

		// Token: 0x04000397 RID: 919
		[Nullable(2)]
		private readonly IList _list;

		// Token: 0x04000398 RID: 920
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private readonly ICollection<T> _genericCollection;

		// Token: 0x04000399 RID: 921
		[Nullable(2)]
		private object _syncRoot;
	}
}
