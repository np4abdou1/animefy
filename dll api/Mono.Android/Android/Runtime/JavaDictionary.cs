using System;
using System.Collections;
using Java.Interop;
using Java.Lang;

namespace Android.Runtime
{
	// Token: 0x020002D1 RID: 721
	[Register("java/util/HashMap", DoNotGenerateAcw = true)]
	public class JavaDictionary : Java.Lang.Object, IDictionary, ICollection, IEnumerable
	{
		// Token: 0x06001B49 RID: 6985 RVA: 0x00047660 File Offset: 0x00045860
		internal object Get(object key)
		{
			if (JavaDictionary.id_get == IntPtr.Zero)
			{
				JavaDictionary.id_get = JNIEnv.GetMethodID(JavaDictionary.map_class, "get", "(Ljava/lang/Object;)Ljava/lang/Object;");
			}
			return JavaConvert.FromJniHandle(JavaConvert.WithLocalJniHandle<IntPtr>(key, delegate(IntPtr lref)
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
			}), JniHandleOwnership.TransferLocalRef, null);
		}

		// Token: 0x06001B4A RID: 6986 RVA: 0x000476B0 File Offset: 0x000458B0
		internal IntPtr GetKeys()
		{
			if (JavaDictionary.id_keySet == IntPtr.Zero)
			{
				JavaDictionary.id_keySet = JNIEnv.GetMethodID(JavaDictionary.map_class, "keySet", "()Ljava/util/Set;");
			}
			return JNIEnv.CallObjectMethod(base.Handle, JavaDictionary.id_keySet);
		}

		// Token: 0x06001B4B RID: 6987 RVA: 0x000476EC File Offset: 0x000458EC
		internal IntPtr GetValues()
		{
			if (JavaDictionary.id_values == IntPtr.Zero)
			{
				JavaDictionary.id_values = JNIEnv.GetMethodID(JavaDictionary.map_class, "values", "()Ljava/util/Collection;");
			}
			return JNIEnv.CallObjectMethod(base.Handle, JavaDictionary.id_values);
		}

		// Token: 0x06001B4C RID: 6988 RVA: 0x00047728 File Offset: 0x00045928
		internal void Put(object key, object value)
		{
			if (JavaDictionary.id_put == IntPtr.Zero)
			{
				JavaDictionary.id_put = JNIEnv.GetMethodID(JavaDictionary.map_class, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			}
			JNIEnv.DeleteLocalRef(JavaConvert.WithLocalJniHandle<IntPtr>(key, (IntPtr lrefKey) => JavaConvert.WithLocalJniHandle<IntPtr>(value, delegate(IntPtr lrefValue)
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

		// Token: 0x06001B4D RID: 6989 RVA: 0x0004778C File Offset: 0x0004598C
		public JavaDictionary() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			if (base.GetType() == typeof(JavaDictionary))
			{
				base.SetHandle(JNIEnv.StartCreateInstance("java/util/HashMap", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
				return;
			}
			base.SetHandle(JNIEnv.StartCreateInstance(base.GetType(), "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
		}

		// Token: 0x06001B4E RID: 6990 RVA: 0x000021E0 File Offset: 0x000003E0
		public JavaDictionary(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x06001B4F RID: 6991 RVA: 0x00047834 File Offset: 0x00045A34
		public JavaDictionary(IDictionary items) : this()
		{
			if (items == null)
			{
				base.Dispose();
				throw new ArgumentNullException("items");
			}
			foreach (object obj in items)
			{
				DictionaryEntry dictionaryEntry = (DictionaryEntry)obj;
				this.Add(dictionaryEntry.Key, dictionaryEntry.Value);
			}
		}

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x06001B50 RID: 6992 RVA: 0x000478B0 File Offset: 0x00045AB0
		public int Count
		{
			get
			{
				if (JavaDictionary.id_size == IntPtr.Zero)
				{
					JavaDictionary.id_size = JNIEnv.GetMethodID(JavaDictionary.map_class, "size", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, JavaDictionary.id_size);
			}
		}

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x06001B51 RID: 6993 RVA: 0x00045ABE File Offset: 0x00043CBE
		public bool IsFixedSize
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x06001B52 RID: 6994 RVA: 0x00045ABE File Offset: 0x00043CBE
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x06001B53 RID: 6995 RVA: 0x00045ABE File Offset: 0x00043CBE
		public bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x06001B54 RID: 6996 RVA: 0x000478EC File Offset: 0x00045AEC
		public ICollection Keys
		{
			get
			{
				return new JavaSet(this.GetKeys(), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x06001B55 RID: 6997 RVA: 0x00046D05 File Offset: 0x00044F05
		public object SyncRoot
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x06001B56 RID: 6998 RVA: 0x000478FA File Offset: 0x00045AFA
		public ICollection Values
		{
			get
			{
				return new JavaCollection(this.GetValues(), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170005E0 RID: 1504
		public object this[object key]
		{
			get
			{
				return this.Get(key);
			}
			set
			{
				this.Put(key, value);
			}
		}

		// Token: 0x06001B59 RID: 7001 RVA: 0x0004791B File Offset: 0x00045B1B
		public void Add(object key, object value)
		{
			if (this.Contains(key))
			{
				throw new ArgumentException("The key '" + ((key != null) ? key.ToString() : null) + "' already exists.", "key");
			}
			this.Put(key, value);
		}

		// Token: 0x06001B5A RID: 7002 RVA: 0x00047954 File Offset: 0x00045B54
		public void Clear()
		{
			if (JavaDictionary.id_clear == IntPtr.Zero)
			{
				JavaDictionary.id_clear = JNIEnv.GetMethodID(JavaDictionary.map_class, "clear", "()V");
			}
			try
			{
				JNIEnv.CallVoidMethod(base.Handle, JavaDictionary.id_clear);
			}
			catch (UnsupportedOperationException ex) when (JNIEnv.ShouldWrapJavaException(ex, "Clear"))
			{
				throw new NotSupportedException(ex.Message, ex);
			}
		}

		// Token: 0x06001B5B RID: 7003 RVA: 0x000479DC File Offset: 0x00045BDC
		public bool Contains(object key)
		{
			if (JavaDictionary.id_containsKey == IntPtr.Zero)
			{
				JavaDictionary.id_containsKey = JNIEnv.GetMethodID(JavaDictionary.map_class, "containsKey", "(Ljava/lang/Object;)Z");
			}
			return JavaConvert.WithLocalJniHandle<bool>(key, delegate(IntPtr lref)
			{
				bool result;
				try
				{
					result = JNIEnv.CallBooleanMethod(base.Handle, JavaDictionary.id_containsKey, new JValue[]
					{
						new JValue(lref)
					});
				}
				catch (ClassCastException ex) when (JNIEnv.ShouldWrapJavaException(ex, "Contains"))
				{
					throw new InvalidCastException(ex.Message, ex);
				}
				catch (NullPointerException ex2) when (JNIEnv.ShouldWrapJavaException(ex2, "Contains"))
				{
					throw new NullReferenceException(ex2.Message, ex2);
				}
				return result;
			});
		}

		// Token: 0x06001B5C RID: 7004 RVA: 0x00047A1C File Offset: 0x00045C1C
		public void CopyTo(Array array, int array_index)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (array_index < 0)
			{
				throw new ArgumentOutOfRangeException("array_index");
			}
			if (array.Length < array_index + this.Count)
			{
				throw new ArgumentException("array");
			}
			int num = 0;
			foreach (object value in this)
			{
				array.SetValue(value, array_index + num++);
			}
		}

		// Token: 0x06001B5D RID: 7005 RVA: 0x00047AAC File Offset: 0x00045CAC
		IEnumerator IEnumerable.GetEnumerator()
		{
			foreach (object key in this.Keys)
			{
				yield return new DictionaryEntry(key, this[key]);
			}
			IEnumerator enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x06001B5E RID: 7006 RVA: 0x00047ABB File Offset: 0x00045CBB
		public IDictionaryEnumerator GetEnumerator()
		{
			return new JavaDictionary.DictionaryEnumerator(this);
		}

		// Token: 0x06001B5F RID: 7007 RVA: 0x00047AC4 File Offset: 0x00045CC4
		public void Remove(object key)
		{
			if (JavaDictionary.id_remove == IntPtr.Zero)
			{
				JavaDictionary.id_remove = JNIEnv.GetMethodID(JavaDictionary.map_class, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;");
			}
			JNIEnv.DeleteLocalRef(JavaConvert.WithLocalJniHandle<IntPtr>(key, delegate(IntPtr lref)
			{
				IntPtr result;
				try
				{
					result = JNIEnv.CallObjectMethod(base.Handle, JavaDictionary.id_remove, new JValue[]
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
				return result;
			}));
		}

		// Token: 0x06001B60 RID: 7008 RVA: 0x00047B14 File Offset: 0x00045D14
		public static IDictionary FromJniHandle(IntPtr handle, JniHandleOwnership transfer)
		{
			if (handle == IntPtr.Zero)
			{
				return null;
			}
			IJavaObject javaObject = (IJavaObject)Java.Lang.Object.PeekObject(handle, null);
			if (javaObject == null)
			{
				javaObject = new JavaDictionary(handle, transfer);
			}
			else
			{
				JNIEnv.DeleteRef(handle, transfer);
			}
			return (IDictionary)javaObject;
		}

		// Token: 0x06001B61 RID: 7009 RVA: 0x00047B58 File Offset: 0x00045D58
		public static IntPtr ToLocalJniHandle(IDictionary dictionary)
		{
			if (dictionary == null)
			{
				return IntPtr.Zero;
			}
			JavaDictionary javaDictionary = dictionary as JavaDictionary;
			if (javaDictionary != null)
			{
				return JNIEnv.ToLocalJniHandle(javaDictionary);
			}
			JavaDictionary javaDictionary2;
			javaDictionary = (javaDictionary2 = new JavaDictionary(dictionary));
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

		// Token: 0x04000B97 RID: 2967
		internal static IntPtr map_class = JNIEnv.FindClass("java/util/Map");

		// Token: 0x04000B98 RID: 2968
		private static IntPtr id_clear;

		// Token: 0x04000B99 RID: 2969
		internal static IntPtr id_containsKey;

		// Token: 0x04000B9A RID: 2970
		internal static IntPtr id_get;

		// Token: 0x04000B9B RID: 2971
		private static IntPtr id_keySet;

		// Token: 0x04000B9C RID: 2972
		internal static IntPtr id_put;

		// Token: 0x04000B9D RID: 2973
		internal static IntPtr id_remove;

		// Token: 0x04000B9E RID: 2974
		private static IntPtr id_size;

		// Token: 0x04000B9F RID: 2975
		private static IntPtr id_values;

		// Token: 0x020002D2 RID: 722
		private class DictionaryEnumerator : IDictionaryEnumerator, IEnumerator
		{
			// Token: 0x06001B66 RID: 7014 RVA: 0x00047DF0 File Offset: 0x00045FF0
			public DictionaryEnumerator(JavaDictionary owner)
			{
				this.simple_enumerator = ((IEnumerable)owner).GetEnumerator();
			}

			// Token: 0x170005E1 RID: 1505
			// (get) Token: 0x06001B67 RID: 7015 RVA: 0x00047E04 File Offset: 0x00046004
			public object Current
			{
				get
				{
					return this.simple_enumerator.Current;
				}
			}

			// Token: 0x170005E2 RID: 1506
			// (get) Token: 0x06001B68 RID: 7016 RVA: 0x00047E11 File Offset: 0x00046011
			public DictionaryEntry Entry
			{
				get
				{
					return (DictionaryEntry)this.Current;
				}
			}

			// Token: 0x170005E3 RID: 1507
			// (get) Token: 0x06001B69 RID: 7017 RVA: 0x00047E20 File Offset: 0x00046020
			public object Key
			{
				get
				{
					return this.Entry.Key;
				}
			}

			// Token: 0x170005E4 RID: 1508
			// (get) Token: 0x06001B6A RID: 7018 RVA: 0x00047E3C File Offset: 0x0004603C
			public object Value
			{
				get
				{
					return this.Entry.Value;
				}
			}

			// Token: 0x06001B6B RID: 7019 RVA: 0x00047E57 File Offset: 0x00046057
			public bool MoveNext()
			{
				return this.simple_enumerator.MoveNext();
			}

			// Token: 0x06001B6C RID: 7020 RVA: 0x00047E64 File Offset: 0x00046064
			public void Reset()
			{
				this.simple_enumerator.Reset();
			}

			// Token: 0x04000BA0 RID: 2976
			private IEnumerator simple_enumerator;
		}
	}
}
