using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Dynamic.Utils;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace System.Dynamic
{
	/// <summary>Represents an object whose members can be dynamically added and removed at run time.</summary>
	// Token: 0x02000120 RID: 288
	public sealed class ExpandoObject : IDynamicMetaObjectProvider, IDictionary<string, object>, ICollection<KeyValuePair<string, object>>, IEnumerable<KeyValuePair<string, object>>, IEnumerable, INotifyPropertyChanged
	{
		/// <summary>Initializes a new <see langword="ExpandoObject" /> that does not have members.</summary>
		// Token: 0x06000946 RID: 2374 RVA: 0x000238D8 File Offset: 0x00021AD8
		public ExpandoObject()
		{
			this._data = ExpandoObject.ExpandoData.Empty;
			this.LockObject = new object();
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x000238F8 File Offset: 0x00021AF8
		internal bool TryGetValue(object indexClass, int index, string name, bool ignoreCase, out object value)
		{
			ExpandoObject.ExpandoData data = this._data;
			if (data.Class != indexClass || ignoreCase)
			{
				index = data.Class.GetValueIndex(name, ignoreCase, this);
				if (index == -2)
				{
					throw Error.AmbiguousMatchInExpandoObject(name);
				}
			}
			if (index == -1)
			{
				value = null;
				return false;
			}
			object obj = data[index];
			if (obj == ExpandoObject.Uninitialized)
			{
				value = null;
				return false;
			}
			value = obj;
			return true;
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x00023960 File Offset: 0x00021B60
		internal void TrySetValue(object indexClass, int index, object value, string name, bool ignoreCase, bool add)
		{
			object lockObject = this.LockObject;
			ExpandoObject.ExpandoData expandoData;
			object obj;
			lock (lockObject)
			{
				expandoData = this._data;
				if (expandoData.Class != indexClass || ignoreCase)
				{
					index = expandoData.Class.GetValueIndex(name, ignoreCase, this);
					if (index == -2)
					{
						throw Error.AmbiguousMatchInExpandoObject(name);
					}
					if (index == -1)
					{
						int num = ignoreCase ? expandoData.Class.GetValueIndexCaseSensitive(name) : index;
						if (num != -1)
						{
							index = num;
						}
						else
						{
							ExpandoClass newClass = expandoData.Class.FindNewClass(name);
							expandoData = this.PromoteClassCore(expandoData.Class, newClass);
							index = expandoData.Class.GetValueIndexCaseSensitive(name);
						}
					}
				}
				obj = expandoData[index];
				if (obj == ExpandoObject.Uninitialized)
				{
					this._count++;
				}
				else if (add)
				{
					throw Error.SameKeyExistsInExpando(name);
				}
				expandoData[index] = value;
			}
			PropertyChangedEventHandler propertyChanged = this._propertyChanged;
			if (propertyChanged != null && value != obj)
			{
				propertyChanged(this, new PropertyChangedEventArgs(expandoData.Class.Keys[index]));
			}
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x00023A80 File Offset: 0x00021C80
		internal bool TryDeleteValue(object indexClass, int index, string name, bool ignoreCase, object deleteValue)
		{
			object lockObject = this.LockObject;
			ExpandoObject.ExpandoData data;
			lock (lockObject)
			{
				data = this._data;
				if (data.Class != indexClass || ignoreCase)
				{
					index = data.Class.GetValueIndex(name, ignoreCase, this);
					if (index == -2)
					{
						throw Error.AmbiguousMatchInExpandoObject(name);
					}
				}
				if (index == -1)
				{
					return false;
				}
				object obj = data[index];
				if (obj == ExpandoObject.Uninitialized)
				{
					return false;
				}
				if (deleteValue != ExpandoObject.Uninitialized && !object.Equals(obj, deleteValue))
				{
					return false;
				}
				data[index] = ExpandoObject.Uninitialized;
				this._count--;
			}
			PropertyChangedEventHandler propertyChanged = this._propertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(data.Class.Keys[index]));
			}
			return true;
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x00023B68 File Offset: 0x00021D68
		internal bool IsDeletedMember(int index)
		{
			return index != this._data.Length && this._data[index] == ExpandoObject.Uninitialized;
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x0600094B RID: 2379 RVA: 0x00023B8D File Offset: 0x00021D8D
		internal ExpandoClass Class
		{
			get
			{
				return this._data.Class;
			}
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x00023B9A File Offset: 0x00021D9A
		private ExpandoObject.ExpandoData PromoteClassCore(ExpandoClass oldClass, ExpandoClass newClass)
		{
			if (this._data.Class == oldClass)
			{
				this._data = this._data.UpdateClass(newClass);
			}
			return this._data;
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x00023BC4 File Offset: 0x00021DC4
		internal void PromoteClass(object oldClass, object newClass)
		{
			object lockObject = this.LockObject;
			lock (lockObject)
			{
				this.PromoteClassCore((ExpandoClass)oldClass, (ExpandoClass)newClass);
			}
		}

		/// <summary>The provided MetaObject will dispatch to the dynamic virtual methods. The object can be encapsulated inside another MetaObject to provide custom behavior for individual actions.</summary>
		/// <param name="parameter">The expression that represents the MetaObject to dispatch to the Dynamic virtual methods.</param>
		/// <returns>The object of the <see cref="T:System.Dynamic.DynamicMetaObject" /> type.</returns>
		// Token: 0x0600094E RID: 2382 RVA: 0x00023C14 File Offset: 0x00021E14
		DynamicMetaObject IDynamicMetaObjectProvider.GetMetaObject(Expression parameter)
		{
			return new ExpandoObject.MetaExpando(parameter, this);
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x00023C1D File Offset: 0x00021E1D
		private void TryAddMember(string key, object value)
		{
			ContractUtils.RequiresNotNull(key, "key");
			this.TrySetValue(null, -1, value, key, false, true);
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x00023C36 File Offset: 0x00021E36
		private bool TryGetValueForKey(string key, out object value)
		{
			return this.TryGetValue(null, -1, key, false, out value);
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x00023C43 File Offset: 0x00021E43
		private bool ExpandoContainsKey(string key)
		{
			return this._data.Class.GetValueIndexCaseSensitive(key) >= 0;
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x06000952 RID: 2386 RVA: 0x00023C5C File Offset: 0x00021E5C
		ICollection<string> IDictionary<string, object>.Keys
		{
			get
			{
				return new ExpandoObject.KeyCollection(this);
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x06000953 RID: 2387 RVA: 0x00023C64 File Offset: 0x00021E64
		ICollection<object> IDictionary<string, object>.Values
		{
			get
			{
				return new ExpandoObject.ValueCollection(this);
			}
		}

		// Token: 0x17000198 RID: 408
		object IDictionary<string, object>.this[string key]
		{
			get
			{
				object result;
				if (!this.TryGetValueForKey(key, out result))
				{
					throw Error.KeyDoesNotExistInExpando(key);
				}
				return result;
			}
			set
			{
				ContractUtils.RequiresNotNull(key, "key");
				this.TrySetValue(null, -1, value, key, false, false);
			}
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x00023CA5 File Offset: 0x00021EA5
		void IDictionary<string, object>.Add(string key, object value)
		{
			this.TryAddMember(key, value);
		}

		// Token: 0x06000957 RID: 2391 RVA: 0x00023CB0 File Offset: 0x00021EB0
		bool IDictionary<string, object>.ContainsKey(string key)
		{
			ContractUtils.RequiresNotNull(key, "key");
			ExpandoObject.ExpandoData data = this._data;
			int valueIndexCaseSensitive = data.Class.GetValueIndexCaseSensitive(key);
			return valueIndexCaseSensitive >= 0 && data[valueIndexCaseSensitive] != ExpandoObject.Uninitialized;
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x00023CF3 File Offset: 0x00021EF3
		bool IDictionary<string, object>.Remove(string key)
		{
			ContractUtils.RequiresNotNull(key, "key");
			return this.TryDeleteValue(null, -1, key, false, ExpandoObject.Uninitialized);
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x00023D0F File Offset: 0x00021F0F
		bool IDictionary<string, object>.TryGetValue(string key, out object value)
		{
			return this.TryGetValueForKey(key, out value);
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x0600095A RID: 2394 RVA: 0x00023D19 File Offset: 0x00021F19
		int ICollection<KeyValuePair<string, object>>.Count
		{
			get
			{
				return this._count;
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x0600095B RID: 2395 RVA: 0x00008049 File Offset: 0x00006249
		bool ICollection<KeyValuePair<string, object>>.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x00023D21 File Offset: 0x00021F21
		void ICollection<KeyValuePair<string, object>>.Add(KeyValuePair<string, object> item)
		{
			this.TryAddMember(item.Key, item.Value);
		}

		// Token: 0x0600095D RID: 2397 RVA: 0x00023D38 File Offset: 0x00021F38
		void ICollection<KeyValuePair<string, object>>.Clear()
		{
			object lockObject = this.LockObject;
			ExpandoObject.ExpandoData data;
			lock (lockObject)
			{
				data = this._data;
				this._data = ExpandoObject.ExpandoData.Empty;
				this._count = 0;
			}
			PropertyChangedEventHandler propertyChanged = this._propertyChanged;
			if (propertyChanged != null)
			{
				int i = 0;
				int num = data.Class.Keys.Length;
				while (i < num)
				{
					if (data[i] != ExpandoObject.Uninitialized)
					{
						propertyChanged(this, new PropertyChangedEventArgs(data.Class.Keys[i]));
					}
					i++;
				}
			}
		}

		// Token: 0x0600095E RID: 2398 RVA: 0x00023DE0 File Offset: 0x00021FE0
		bool ICollection<KeyValuePair<string, object>>.Contains(KeyValuePair<string, object> item)
		{
			object objA;
			return this.TryGetValueForKey(item.Key, out objA) && object.Equals(objA, item.Value);
		}

		// Token: 0x0600095F RID: 2399 RVA: 0x00023E10 File Offset: 0x00022010
		void ICollection<KeyValuePair<string, object>>.CopyTo(KeyValuePair<string, object>[] array, int arrayIndex)
		{
			ContractUtils.RequiresNotNull(array, "array");
			object lockObject = this.LockObject;
			lock (lockObject)
			{
				ContractUtils.RequiresArrayRange<KeyValuePair<string, object>>(array, arrayIndex, this._count, "arrayIndex", "Count");
				foreach (KeyValuePair<string, object> keyValuePair in ((IEnumerable<KeyValuePair<string, object>>)this))
				{
					array[arrayIndex++] = keyValuePair;
				}
			}
		}

		// Token: 0x06000960 RID: 2400 RVA: 0x00023EA8 File Offset: 0x000220A8
		bool ICollection<KeyValuePair<string, object>>.Remove(KeyValuePair<string, object> item)
		{
			return this.TryDeleteValue(null, -1, item.Key, false, item.Value);
		}

		// Token: 0x06000961 RID: 2401 RVA: 0x00023EC4 File Offset: 0x000220C4
		IEnumerator<KeyValuePair<string, object>> IEnumerable<KeyValuePair<string, object>>.GetEnumerator()
		{
			ExpandoObject.ExpandoData data = this._data;
			return this.GetExpandoEnumerator(data, data.Version);
		}

		/// <summary>Returns an enumerator that iterates through the collection.</summary>
		/// <returns>An <see cref="T:System.Collections.IEnumerator" /> that can be used to iterate through the collection.</returns>
		// Token: 0x06000962 RID: 2402 RVA: 0x00023EE8 File Offset: 0x000220E8
		IEnumerator IEnumerable.GetEnumerator()
		{
			ExpandoObject.ExpandoData data = this._data;
			return this.GetExpandoEnumerator(data, data.Version);
		}

		// Token: 0x06000963 RID: 2403 RVA: 0x00023F09 File Offset: 0x00022109
		private IEnumerator<KeyValuePair<string, object>> GetExpandoEnumerator(ExpandoObject.ExpandoData data, int version)
		{
			int num;
			for (int i = 0; i < data.Class.Keys.Length; i = num + 1)
			{
				if (this._data.Version != version || data != this._data)
				{
					throw Error.CollectionModifiedWhileEnumerating();
				}
				object obj = data[i];
				if (obj != ExpandoObject.Uninitialized)
				{
					yield return new KeyValuePair<string, object>(data.Class.Keys[i], obj);
				}
				num = i;
			}
			yield break;
		}

		// Token: 0x040002C3 RID: 707
		private static readonly MethodInfo s_expandoTryGetValue = typeof(RuntimeOps).GetMethod("ExpandoTryGetValue");

		// Token: 0x040002C4 RID: 708
		private static readonly MethodInfo s_expandoTrySetValue = typeof(RuntimeOps).GetMethod("ExpandoTrySetValue");

		// Token: 0x040002C5 RID: 709
		private static readonly MethodInfo s_expandoTryDeleteValue = typeof(RuntimeOps).GetMethod("ExpandoTryDeleteValue");

		// Token: 0x040002C6 RID: 710
		private static readonly MethodInfo s_expandoPromoteClass = typeof(RuntimeOps).GetMethod("ExpandoPromoteClass");

		// Token: 0x040002C7 RID: 711
		private static readonly MethodInfo s_expandoCheckVersion = typeof(RuntimeOps).GetMethod("ExpandoCheckVersion");

		// Token: 0x040002C8 RID: 712
		internal readonly object LockObject;

		// Token: 0x040002C9 RID: 713
		private ExpandoObject.ExpandoData _data;

		// Token: 0x040002CA RID: 714
		private int _count;

		// Token: 0x040002CB RID: 715
		internal static readonly object Uninitialized = new object();

		// Token: 0x040002CC RID: 716
		private PropertyChangedEventHandler _propertyChanged;

		// Token: 0x02000121 RID: 289
		private sealed class KeyCollectionDebugView
		{
		}

		// Token: 0x02000122 RID: 290
		[DebuggerTypeProxy(typeof(ExpandoObject.KeyCollectionDebugView))]
		[DebuggerDisplay("Count = {Count}")]
		private class KeyCollection : ICollection<string>, IEnumerable<string>, IEnumerable
		{
			// Token: 0x06000965 RID: 2405 RVA: 0x00023FBC File Offset: 0x000221BC
			internal KeyCollection(ExpandoObject expando)
			{
				object lockObject = expando.LockObject;
				lock (lockObject)
				{
					this._expando = expando;
					this._expandoVersion = expando._data.Version;
					this._expandoCount = expando._count;
					this._expandoData = expando._data;
				}
			}

			// Token: 0x06000966 RID: 2406 RVA: 0x0002402C File Offset: 0x0002222C
			private void CheckVersion()
			{
				if (this._expando._data.Version != this._expandoVersion || this._expandoData != this._expando._data)
				{
					throw Error.CollectionModifiedWhileEnumerating();
				}
			}

			// Token: 0x06000967 RID: 2407 RVA: 0x0002405F File Offset: 0x0002225F
			public void Add(string item)
			{
				throw Error.CollectionReadOnly();
			}

			// Token: 0x06000968 RID: 2408 RVA: 0x0002405F File Offset: 0x0002225F
			public void Clear()
			{
				throw Error.CollectionReadOnly();
			}

			// Token: 0x06000969 RID: 2409 RVA: 0x00024068 File Offset: 0x00022268
			public bool Contains(string item)
			{
				object lockObject = this._expando.LockObject;
				bool result;
				lock (lockObject)
				{
					this.CheckVersion();
					result = this._expando.ExpandoContainsKey(item);
				}
				return result;
			}

			// Token: 0x0600096A RID: 2410 RVA: 0x000240BC File Offset: 0x000222BC
			public void CopyTo(string[] array, int arrayIndex)
			{
				ContractUtils.RequiresNotNull(array, "array");
				ContractUtils.RequiresArrayRange<string>(array, arrayIndex, this._expandoCount, "arrayIndex", "Count");
				object lockObject = this._expando.LockObject;
				lock (lockObject)
				{
					this.CheckVersion();
					ExpandoObject.ExpandoData data = this._expando._data;
					for (int i = 0; i < data.Class.Keys.Length; i++)
					{
						if (data[i] != ExpandoObject.Uninitialized)
						{
							array[arrayIndex++] = data.Class.Keys[i];
						}
					}
				}
			}

			// Token: 0x1700019B RID: 411
			// (get) Token: 0x0600096B RID: 2411 RVA: 0x0002416C File Offset: 0x0002236C
			public int Count
			{
				get
				{
					this.CheckVersion();
					return this._expandoCount;
				}
			}

			// Token: 0x1700019C RID: 412
			// (get) Token: 0x0600096C RID: 2412 RVA: 0x00007357 File Offset: 0x00005557
			public bool IsReadOnly
			{
				get
				{
					return true;
				}
			}

			// Token: 0x0600096D RID: 2413 RVA: 0x0002405F File Offset: 0x0002225F
			public bool Remove(string item)
			{
				throw Error.CollectionReadOnly();
			}

			// Token: 0x0600096E RID: 2414 RVA: 0x0002417A File Offset: 0x0002237A
			public IEnumerator<string> GetEnumerator()
			{
				int i = 0;
				int j = this._expandoData.Class.Keys.Length;
				while (i < j)
				{
					this.CheckVersion();
					if (this._expandoData[i] != ExpandoObject.Uninitialized)
					{
						yield return this._expandoData.Class.Keys[i];
					}
					int num = i;
					i = num + 1;
				}
				yield break;
			}

			// Token: 0x0600096F RID: 2415 RVA: 0x00024189 File Offset: 0x00022389
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.GetEnumerator();
			}

			// Token: 0x040002CD RID: 717
			private readonly ExpandoObject _expando;

			// Token: 0x040002CE RID: 718
			private readonly int _expandoVersion;

			// Token: 0x040002CF RID: 719
			private readonly int _expandoCount;

			// Token: 0x040002D0 RID: 720
			private readonly ExpandoObject.ExpandoData _expandoData;
		}

		// Token: 0x02000124 RID: 292
		private sealed class ValueCollectionDebugView
		{
		}

		// Token: 0x02000125 RID: 293
		[DebuggerTypeProxy(typeof(ExpandoObject.ValueCollectionDebugView))]
		[DebuggerDisplay("Count = {Count}")]
		private class ValueCollection : ICollection<object>, IEnumerable<object>, IEnumerable
		{
			// Token: 0x06000976 RID: 2422 RVA: 0x00024260 File Offset: 0x00022460
			internal ValueCollection(ExpandoObject expando)
			{
				object lockObject = expando.LockObject;
				lock (lockObject)
				{
					this._expando = expando;
					this._expandoVersion = expando._data.Version;
					this._expandoCount = expando._count;
					this._expandoData = expando._data;
				}
			}

			// Token: 0x06000977 RID: 2423 RVA: 0x000242D0 File Offset: 0x000224D0
			private void CheckVersion()
			{
				if (this._expando._data.Version != this._expandoVersion || this._expandoData != this._expando._data)
				{
					throw Error.CollectionModifiedWhileEnumerating();
				}
			}

			// Token: 0x06000978 RID: 2424 RVA: 0x0002405F File Offset: 0x0002225F
			public void Add(object item)
			{
				throw Error.CollectionReadOnly();
			}

			// Token: 0x06000979 RID: 2425 RVA: 0x0002405F File Offset: 0x0002225F
			public void Clear()
			{
				throw Error.CollectionReadOnly();
			}

			// Token: 0x0600097A RID: 2426 RVA: 0x00024304 File Offset: 0x00022504
			public bool Contains(object item)
			{
				object lockObject = this._expando.LockObject;
				bool result;
				lock (lockObject)
				{
					this.CheckVersion();
					ExpandoObject.ExpandoData data = this._expando._data;
					for (int i = 0; i < data.Class.Keys.Length; i++)
					{
						if (object.Equals(data[i], item))
						{
							return true;
						}
					}
					result = false;
				}
				return result;
			}

			// Token: 0x0600097B RID: 2427 RVA: 0x00024388 File Offset: 0x00022588
			public void CopyTo(object[] array, int arrayIndex)
			{
				ContractUtils.RequiresNotNull(array, "array");
				ContractUtils.RequiresArrayRange<object>(array, arrayIndex, this._expandoCount, "arrayIndex", "Count");
				object lockObject = this._expando.LockObject;
				lock (lockObject)
				{
					this.CheckVersion();
					ExpandoObject.ExpandoData data = this._expando._data;
					for (int i = 0; i < data.Class.Keys.Length; i++)
					{
						if (data[i] != ExpandoObject.Uninitialized)
						{
							array[arrayIndex++] = data[i];
						}
					}
				}
			}

			// Token: 0x1700019F RID: 415
			// (get) Token: 0x0600097C RID: 2428 RVA: 0x00024430 File Offset: 0x00022630
			public int Count
			{
				get
				{
					this.CheckVersion();
					return this._expandoCount;
				}
			}

			// Token: 0x170001A0 RID: 416
			// (get) Token: 0x0600097D RID: 2429 RVA: 0x00007357 File Offset: 0x00005557
			public bool IsReadOnly
			{
				get
				{
					return true;
				}
			}

			// Token: 0x0600097E RID: 2430 RVA: 0x0002405F File Offset: 0x0002225F
			public bool Remove(object item)
			{
				throw Error.CollectionReadOnly();
			}

			// Token: 0x0600097F RID: 2431 RVA: 0x0002443E File Offset: 0x0002263E
			public IEnumerator<object> GetEnumerator()
			{
				ExpandoObject.ExpandoData data = this._expando._data;
				int num;
				for (int i = 0; i < data.Class.Keys.Length; i = num + 1)
				{
					this.CheckVersion();
					object obj = data[i];
					if (obj != ExpandoObject.Uninitialized)
					{
						yield return obj;
					}
					num = i;
				}
				yield break;
			}

			// Token: 0x06000980 RID: 2432 RVA: 0x0002444D File Offset: 0x0002264D
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.GetEnumerator();
			}

			// Token: 0x040002D6 RID: 726
			private readonly ExpandoObject _expando;

			// Token: 0x040002D7 RID: 727
			private readonly int _expandoVersion;

			// Token: 0x040002D8 RID: 728
			private readonly int _expandoCount;

			// Token: 0x040002D9 RID: 729
			private readonly ExpandoObject.ExpandoData _expandoData;
		}

		// Token: 0x02000127 RID: 295
		private class MetaExpando : DynamicMetaObject
		{
			// Token: 0x06000987 RID: 2439 RVA: 0x00024513 File Offset: 0x00022713
			public MetaExpando(Expression expression, ExpandoObject value) : base(expression, BindingRestrictions.Empty, value)
			{
			}

			// Token: 0x06000988 RID: 2440 RVA: 0x00024524 File Offset: 0x00022724
			private DynamicMetaObject BindGetOrInvokeMember(DynamicMetaObjectBinder binder, string name, bool ignoreCase, DynamicMetaObject fallback, Func<DynamicMetaObject, DynamicMetaObject> fallbackInvoke)
			{
				ExpandoClass @class = this.Value.Class;
				int valueIndex = @class.GetValueIndex(name, ignoreCase, this.Value);
				ParameterExpression parameterExpression = Expression.Parameter(typeof(object), "value");
				Expression test = Expression.Call(ExpandoObject.s_expandoTryGetValue, new Expression[]
				{
					this.GetLimitedSelf(),
					Expression.Constant(@class, typeof(object)),
					Utils.Constant(valueIndex),
					Expression.Constant(name),
					Utils.Constant(ignoreCase),
					parameterExpression
				});
				DynamicMetaObject dynamicMetaObject = new DynamicMetaObject(parameterExpression, BindingRestrictions.Empty);
				if (fallbackInvoke != null)
				{
					dynamicMetaObject = fallbackInvoke(dynamicMetaObject);
				}
				dynamicMetaObject = new DynamicMetaObject(Expression.Block(new TrueReadOnlyCollection<ParameterExpression>(new ParameterExpression[]
				{
					parameterExpression
				}), new TrueReadOnlyCollection<Expression>(new Expression[]
				{
					Expression.Condition(test, dynamicMetaObject.Expression, fallback.Expression, typeof(object))
				})), dynamicMetaObject.Restrictions.Merge(fallback.Restrictions));
				return this.AddDynamicTestAndDefer(binder, this.Value.Class, null, dynamicMetaObject);
			}

			// Token: 0x06000989 RID: 2441 RVA: 0x00024638 File Offset: 0x00022838
			public override DynamicMetaObject BindGetMember(GetMemberBinder binder)
			{
				ContractUtils.RequiresNotNull(binder, "binder");
				return this.BindGetOrInvokeMember(binder, binder.Name, binder.IgnoreCase, binder.FallbackGetMember(this), null);
			}

			// Token: 0x0600098A RID: 2442 RVA: 0x00024660 File Offset: 0x00022860
			public override DynamicMetaObject BindInvokeMember(InvokeMemberBinder binder, DynamicMetaObject[] args)
			{
				ContractUtils.RequiresNotNull(binder, "binder");
				return this.BindGetOrInvokeMember(binder, binder.Name, binder.IgnoreCase, binder.FallbackInvokeMember(this, args), (DynamicMetaObject value) => binder.FallbackInvoke(value, args, null));
			}

			// Token: 0x0600098B RID: 2443 RVA: 0x000246D4 File Offset: 0x000228D4
			public override DynamicMetaObject BindSetMember(SetMemberBinder binder, DynamicMetaObject value)
			{
				ContractUtils.RequiresNotNull(binder, "binder");
				ContractUtils.RequiresNotNull(value, "value");
				ExpandoClass expandoClass;
				int value2;
				ExpandoClass classEnsureIndex = this.GetClassEnsureIndex(binder.Name, binder.IgnoreCase, this.Value, out expandoClass, out value2);
				return this.AddDynamicTestAndDefer(binder, expandoClass, classEnsureIndex, new DynamicMetaObject(Expression.Call(ExpandoObject.s_expandoTrySetValue, new Expression[]
				{
					this.GetLimitedSelf(),
					Expression.Constant(expandoClass, typeof(object)),
					Utils.Constant(value2),
					Expression.Convert(value.Expression, typeof(object)),
					Expression.Constant(binder.Name),
					Utils.Constant(binder.IgnoreCase)
				}), BindingRestrictions.Empty));
			}

			// Token: 0x0600098C RID: 2444 RVA: 0x00024790 File Offset: 0x00022990
			public override DynamicMetaObject BindDeleteMember(DeleteMemberBinder binder)
			{
				ContractUtils.RequiresNotNull(binder, "binder");
				int valueIndex = this.Value.Class.GetValueIndex(binder.Name, binder.IgnoreCase, this.Value);
				Expression expression = Expression.Call(ExpandoObject.s_expandoTryDeleteValue, this.GetLimitedSelf(), Expression.Constant(this.Value.Class, typeof(object)), Utils.Constant(valueIndex), Expression.Constant(binder.Name), Utils.Constant(binder.IgnoreCase));
				DynamicMetaObject dynamicMetaObject = binder.FallbackDeleteMember(this);
				DynamicMetaObject succeeds = new DynamicMetaObject(Expression.IfThen(Expression.Not(expression), dynamicMetaObject.Expression), dynamicMetaObject.Restrictions);
				return this.AddDynamicTestAndDefer(binder, this.Value.Class, null, succeeds);
			}

			// Token: 0x0600098D RID: 2445 RVA: 0x00024849 File Offset: 0x00022A49
			public override IEnumerable<string> GetDynamicMemberNames()
			{
				ExpandoObject.ExpandoData expandoData = this.Value._data;
				ExpandoClass klass = expandoData.Class;
				int num;
				for (int i = 0; i < klass.Keys.Length; i = num + 1)
				{
					if (expandoData[i] != ExpandoObject.Uninitialized)
					{
						yield return klass.Keys[i];
					}
					num = i;
				}
				yield break;
			}

			// Token: 0x0600098E RID: 2446 RVA: 0x0002485C File Offset: 0x00022A5C
			private DynamicMetaObject AddDynamicTestAndDefer(DynamicMetaObjectBinder binder, ExpandoClass klass, ExpandoClass originalClass, DynamicMetaObject succeeds)
			{
				Expression expression = succeeds.Expression;
				if (originalClass != null)
				{
					expression = Expression.Block(Expression.Call(null, ExpandoObject.s_expandoPromoteClass, this.GetLimitedSelf(), Expression.Constant(originalClass, typeof(object)), Expression.Constant(klass, typeof(object))), succeeds.Expression);
				}
				return new DynamicMetaObject(Expression.Condition(Expression.Call(null, ExpandoObject.s_expandoCheckVersion, this.GetLimitedSelf(), Expression.Constant(originalClass ?? klass, typeof(object))), expression, binder.GetUpdateExpression(expression.Type)), this.GetRestrictions().Merge(succeeds.Restrictions));
			}

			// Token: 0x0600098F RID: 2447 RVA: 0x00024904 File Offset: 0x00022B04
			private ExpandoClass GetClassEnsureIndex(string name, bool caseInsensitive, ExpandoObject obj, out ExpandoClass klass, out int index)
			{
				ExpandoClass @class = this.Value.Class;
				index = @class.GetValueIndex(name, caseInsensitive, obj);
				if (index == -2)
				{
					klass = @class;
					return null;
				}
				if (index == -1)
				{
					ExpandoClass expandoClass = @class.FindNewClass(name);
					klass = expandoClass;
					index = expandoClass.GetValueIndexCaseSensitive(name);
					return @class;
				}
				klass = @class;
				return null;
			}

			// Token: 0x06000990 RID: 2448 RVA: 0x00024959 File Offset: 0x00022B59
			private Expression GetLimitedSelf()
			{
				if (TypeUtils.AreEquivalent(base.Expression.Type, base.LimitType))
				{
					return base.Expression;
				}
				return Expression.Convert(base.Expression, base.LimitType);
			}

			// Token: 0x06000991 RID: 2449 RVA: 0x0002498B File Offset: 0x00022B8B
			private BindingRestrictions GetRestrictions()
			{
				return BindingRestrictions.GetTypeRestriction(this);
			}

			// Token: 0x170001A3 RID: 419
			// (get) Token: 0x06000992 RID: 2450 RVA: 0x00024993 File Offset: 0x00022B93
			public new ExpandoObject Value
			{
				get
				{
					return (ExpandoObject)base.Value;
				}
			}
		}

		// Token: 0x0200012A RID: 298
		private class ExpandoData
		{
			// Token: 0x170001A6 RID: 422
			internal object this[int index]
			{
				get
				{
					return this._dataArray[index];
				}
				set
				{
					this._version++;
					this._dataArray[index] = value;
				}
			}

			// Token: 0x170001A7 RID: 423
			// (get) Token: 0x0600099F RID: 2463 RVA: 0x00024B02 File Offset: 0x00022D02
			internal int Version
			{
				get
				{
					return this._version;
				}
			}

			// Token: 0x170001A8 RID: 424
			// (get) Token: 0x060009A0 RID: 2464 RVA: 0x00024B0A File Offset: 0x00022D0A
			internal int Length
			{
				get
				{
					return this._dataArray.Length;
				}
			}

			// Token: 0x060009A1 RID: 2465 RVA: 0x00024B14 File Offset: 0x00022D14
			private ExpandoData()
			{
				this.Class = ExpandoClass.Empty;
				this._dataArray = Array.Empty<object>();
			}

			// Token: 0x060009A2 RID: 2466 RVA: 0x00024B32 File Offset: 0x00022D32
			internal ExpandoData(ExpandoClass klass, object[] data, int version)
			{
				this.Class = klass;
				this._dataArray = data;
				this._version = version;
			}

			// Token: 0x060009A3 RID: 2467 RVA: 0x00024B50 File Offset: 0x00022D50
			internal ExpandoObject.ExpandoData UpdateClass(ExpandoClass newClass)
			{
				if (this._dataArray.Length >= newClass.Keys.Length)
				{
					this[newClass.Keys.Length - 1] = ExpandoObject.Uninitialized;
					return new ExpandoObject.ExpandoData(newClass, this._dataArray, this._version);
				}
				int index = this._dataArray.Length;
				object[] array = new object[ExpandoObject.ExpandoData.GetAlignedSize(newClass.Keys.Length)];
				Array.Copy(this._dataArray, 0, array, 0, this._dataArray.Length);
				ExpandoObject.ExpandoData expandoData = new ExpandoObject.ExpandoData(newClass, array, this._version);
				expandoData[index] = ExpandoObject.Uninitialized;
				return expandoData;
			}

			// Token: 0x060009A4 RID: 2468 RVA: 0x00024BE2 File Offset: 0x00022DE2
			private static int GetAlignedSize(int len)
			{
				return len + 7 & -8;
			}

			// Token: 0x040002E8 RID: 744
			internal static ExpandoObject.ExpandoData Empty = new ExpandoObject.ExpandoData();

			// Token: 0x040002E9 RID: 745
			internal readonly ExpandoClass Class;

			// Token: 0x040002EA RID: 746
			private readonly object[] _dataArray;

			// Token: 0x040002EB RID: 747
			private int _version;
		}
	}
}
