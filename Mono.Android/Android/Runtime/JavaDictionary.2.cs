using System;
using System.Collections;
using System.Collections.Generic;
using Java.Interop;
using Java.Lang;

namespace Android.Runtime
{
	// Token: 0x020002D6 RID: 726
	[Register("java/util/HashMap", DoNotGenerateAcw = true)]
	public class JavaDictionary<K, V> : JavaDictionary, IDictionary<K, V>, ICollection<KeyValuePair<K, V>>, IEnumerable<KeyValuePair<K, V>>, IEnumerable
	{
		// Token: 0x06001B78 RID: 7032 RVA: 0x00048118 File Offset: 0x00046318
		public JavaDictionary() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			if (base.GetType() == typeof(JavaDictionary<K, V>))
			{
				base.SetHandle(JNIEnv.StartCreateInstance("java/util/HashMap", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef);
			}
			else
			{
				base.SetHandle(JNIEnv.StartCreateInstance(base.GetType(), "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef);
			}
			JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
		}

		// Token: 0x06001B79 RID: 7033 RVA: 0x000481A9 File Offset: 0x000463A9
		public JavaDictionary(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x06001B7A RID: 7034 RVA: 0x000481B4 File Offset: 0x000463B4
		public JavaDictionary(IDictionary<K, V> items) : this()
		{
			if (items == null)
			{
				base.Dispose();
				throw new ArgumentNullException("items");
			}
			foreach (K key in items.Keys)
			{
				this.Add(key, items[key]);
			}
		}

		// Token: 0x06001B7B RID: 7035 RVA: 0x00048224 File Offset: 0x00046424
		internal V Get(K key)
		{
			if (JavaDictionary.id_get == IntPtr.Zero)
			{
				JavaDictionary.id_get = JNIEnv.GetMethodID(JavaDictionary.map_class, "get", "(Ljava/lang/Object;)Ljava/lang/Object;");
			}
			return JavaConvert.FromJniHandle<V>(JavaConvert.WithLocalJniHandle<K, IntPtr>(key, delegate(IntPtr lref)
			{
				IntPtr result;
				try
				{
					result = JNIEnv.CallObjectMethod(base.Handle, JavaDictionary.id_get, new JValue[]
					{
						new JValue(lref)
					});
				}
				catch (ClassCastException ex) when (JNIEnv.ShouldWrapJavaException(ex, "Get"))
				{
					throw new InvalidCastException(ex.Message, ex);
				}
				catch (NullPointerException ex2) when (JNIEnv.ShouldWrapJavaException(ex2, "Get"))
				{
					throw new NullReferenceException(ex2.Message, ex2);
				}
				return result;
			}), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001B7C RID: 7036 RVA: 0x00048274 File Offset: 0x00046474
		internal void Put(K key, V value)
		{
			if (JavaDictionary.id_put == IntPtr.Zero)
			{
				JavaDictionary.id_put = JNIEnv.GetMethodID(JavaDictionary.map_class, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			}
			JNIEnv.DeleteLocalRef(JavaConvert.WithLocalJniHandle<K, IntPtr>(key, (IntPtr lrefKey) => JavaConvert.WithLocalJniHandle<V, IntPtr>(value, delegate(IntPtr lrefValue)
			{
				IntPtr result;
				try
				{
					result = JNIEnv.CallObjectMethod(this.Handle, JavaDictionary.id_put, new JValue[]
					{
						new JValue(lrefKey),
						new JValue(lrefValue)
					});
				}
				catch (UnsupportedOperationException ex) when (JNIEnv.ShouldWrapJavaException(ex, "Put"))
				{
					throw new NotSupportedException(ex.Message, ex);
				}
				catch (ClassCastException ex2) when (JNIEnv.ShouldWrapJavaException(ex2, "Put"))
				{
					throw new InvalidCastException(ex2.Message, ex2);
				}
				catch (NullPointerException ex3) when (JNIEnv.ShouldWrapJavaException(ex3, "Put"))
				{
					throw new NullReferenceException(ex3.Message, ex3);
				}
				catch (IllegalArgumentException ex4) when (JNIEnv.ShouldWrapJavaException(ex4, "Put"))
				{
					throw new ArgumentException(ex4.Message, ex4);
				}
				return result;
			})));
		}

		// Token: 0x170005E7 RID: 1511
		public V this[K key]
		{
			get
			{
				if (!base.Contains(key))
				{
					throw new KeyNotFoundException();
				}
				return this.Get(key);
			}
			set
			{
				this.Put(key, value);
			}
		}

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x06001B7F RID: 7039 RVA: 0x000482FD File Offset: 0x000464FD
		public new ICollection<K> Keys
		{
			get
			{
				return new JavaSet<K>(base.GetKeys(), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x06001B80 RID: 7040 RVA: 0x0004830B File Offset: 0x0004650B
		public new ICollection<V> Values
		{
			get
			{
				return new JavaCollection<V>(base.GetValues(), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06001B81 RID: 7041 RVA: 0x00048319 File Offset: 0x00046519
		public void Add(KeyValuePair<K, V> item)
		{
			this.Add(item.Key, item.Value);
		}

		// Token: 0x06001B82 RID: 7042 RVA: 0x00048330 File Offset: 0x00046530
		public void Add(K key, V value)
		{
			if (this.ContainsKey(key))
			{
				string str = "The key '";
				K k = key;
				throw new ArgumentException(str + ((k != null) ? k.ToString() : null) + "' already exists.", "key");
			}
			this.Put(key, value);
		}

		// Token: 0x06001B83 RID: 7043 RVA: 0x00048382 File Offset: 0x00046582
		public bool Contains(KeyValuePair<K, V> item)
		{
			return this.ContainsKey(item.Key);
		}

		// Token: 0x06001B84 RID: 7044 RVA: 0x00048391 File Offset: 0x00046591
		public bool ContainsKey(K key)
		{
			if (JavaDictionary.id_containsKey == IntPtr.Zero)
			{
				JavaDictionary.id_containsKey = JNIEnv.GetMethodID(JavaDictionary.map_class, "containsKey", "(Ljava/lang/Object;)Z");
			}
			return JavaConvert.WithLocalJniHandle<K, bool>(key, delegate(IntPtr lref)
			{
				bool result;
				try
				{
					result = JNIEnv.CallBooleanMethod(base.Handle, JavaDictionary.id_containsKey, new JValue[]
					{
						new JValue(lref)
					});
				}
				catch (ClassCastException ex) when (JNIEnv.ShouldWrapJavaException(ex, "ContainsKey"))
				{
					throw new InvalidCastException(ex.Message, ex);
				}
				catch (NullPointerException ex2) when (JNIEnv.ShouldWrapJavaException(ex2, "ContainsKey"))
				{
					throw new NullReferenceException(ex2.Message, ex2);
				}
				return result;
			});
		}

		// Token: 0x06001B85 RID: 7045 RVA: 0x000483D0 File Offset: 0x000465D0
		public void CopyTo(KeyValuePair<K, V>[] array, int array_index)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (array_index < 0)
			{
				throw new ArgumentOutOfRangeException("array_index");
			}
			if (array.Length < array_index + base.Count)
			{
				throw new ArgumentException("array");
			}
			int num = 0;
			foreach (KeyValuePair<K, V> keyValuePair in this)
			{
				array[array_index + num++] = keyValuePair;
			}
		}

		// Token: 0x06001B86 RID: 7046 RVA: 0x00048458 File Offset: 0x00046658
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x06001B87 RID: 7047 RVA: 0x00048460 File Offset: 0x00046660
		public new IEnumerator<KeyValuePair<K, V>> GetEnumerator()
		{
			foreach (K key in this.Keys)
			{
				yield return new KeyValuePair<K, V>(key, this[key]);
			}
			IEnumerator<K> enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x06001B88 RID: 7048 RVA: 0x0004846F File Offset: 0x0004666F
		public bool Remove(KeyValuePair<K, V> pair)
		{
			return this.Remove(pair.Key);
		}

		// Token: 0x06001B89 RID: 7049 RVA: 0x00048480 File Offset: 0x00046680
		public bool Remove(K key)
		{
			bool result = this.ContainsKey(key);
			if (JavaDictionary.id_remove == IntPtr.Zero)
			{
				JavaDictionary.id_remove = JNIEnv.GetMethodID(JavaDictionary.map_class, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;");
			}
			JNIEnv.DeleteLocalRef(JavaConvert.WithLocalJniHandle<K, IntPtr>(key, delegate(IntPtr lref)
			{
				IntPtr result2;
				try
				{
					result2 = JNIEnv.CallObjectMethod(base.Handle, JavaDictionary.id_remove, new JValue[]
					{
						new JValue(lref)
					});
				}
				catch (UnsupportedOperationException ex) when (JNIEnv.ShouldWrapJavaException(ex, "Remove"))
				{
					throw new NotSupportedException(ex.Message, ex);
				}
				catch (ClassCastException ex2) when (JNIEnv.ShouldWrapJavaException(ex2, "Remove"))
				{
					throw new InvalidCastException(ex2.Message, ex2);
				}
				catch (NullPointerException ex3) when (JNIEnv.ShouldWrapJavaException(ex3, "Remove"))
				{
					throw new NullReferenceException(ex3.Message, ex3);
				}
				return result2;
			}));
			return result;
		}

		// Token: 0x06001B8A RID: 7050 RVA: 0x000484D5 File Offset: 0x000466D5
		public bool TryGetValue(K key, out V value)
		{
			value = this.Get(key);
			return this.ContainsKey(key);
		}

		// Token: 0x06001B8B RID: 7051 RVA: 0x000484EC File Offset: 0x000466EC
		public new static IDictionary<K, V> FromJniHandle(IntPtr handle, JniHandleOwnership transfer)
		{
			if (handle == IntPtr.Zero)
			{
				return null;
			}
			IJavaObject javaObject = (IJavaObject)Java.Lang.Object.PeekObject(handle, null);
			if (javaObject == null)
			{
				javaObject = new JavaDictionary<K, V>(handle, transfer);
			}
			else
			{
				JNIEnv.DeleteRef(handle, transfer);
			}
			return (IDictionary<K, V>)javaObject;
		}

		// Token: 0x06001B8C RID: 7052 RVA: 0x00048530 File Offset: 0x00046730
		public static IntPtr ToLocalJniHandle(IDictionary<K, V> dictionary)
		{
			if (dictionary == null)
			{
				return IntPtr.Zero;
			}
			JavaDictionary<K, V> javaDictionary = dictionary as JavaDictionary<K, V>;
			if (javaDictionary != null)
			{
				return JNIEnv.ToLocalJniHandle(javaDictionary);
			}
			JavaDictionary<K, V> javaDictionary2;
			javaDictionary = (javaDictionary2 = new JavaDictionary<K, V>(dictionary));
			IntPtr result;
			try
			{
				result = JNIEnv.ToLocalJniHandle(javaDictionary);
			}
			finally
			{
				if (javaDictionary2 != null)
				{
					((IDisposable)javaDictionary2).Dispose();
				}
			}
			return result;
		}
	}
}
