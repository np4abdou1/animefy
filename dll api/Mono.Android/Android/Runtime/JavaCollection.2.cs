using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Java.Interop;
using Java.Lang;

namespace Android.Runtime
{
	// Token: 0x020002D0 RID: 720
	[Register("java/util/Collection", DoNotGenerateAcw = true)]
	public sealed class JavaCollection<T> : JavaCollection, ICollection<T>, IEnumerable<T>, IEnumerable
	{
		// Token: 0x06001B3A RID: 6970 RVA: 0x00047048 File Offset: 0x00045248
		public JavaCollection(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x06001B3B RID: 6971 RVA: 0x00047054 File Offset: 0x00045254
		internal JavaCollection(IEnumerable<T> items) : base(JNIEnv.StartCreateInstance("java/util/ArrayList", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
		{
			JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
			if (items == null)
			{
				base.Dispose();
				throw new ArgumentNullException("items");
			}
			foreach (T item in items)
			{
				this.Add(item);
			}
		}

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x06001B3C RID: 6972 RVA: 0x00045ABE File Offset: 0x00043CBE
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06001B3D RID: 6973 RVA: 0x000470E0 File Offset: 0x000452E0
		public void Add(T item)
		{
			if (JavaCollection.id_add == IntPtr.Zero)
			{
				JavaCollection.id_add = JNIEnv.GetMethodID(JavaCollection.collection_class, "add", "(Ljava/lang/Object;)Z");
			}
			JavaConvert.WithLocalJniHandle<T, IntPtr>(item, delegate(IntPtr lref)
			{
				try
				{
					JNIEnv.CallBooleanMethod(base.Handle, JavaCollection.id_add, new JValue[]
					{
						new JValue(lref)
					});
				}
				catch (UnsupportedOperationException ex) when (JNIEnv.ShouldWrapJavaException(ex, "Add"))
				{
					throw new NotSupportedException(ex.Message, ex);
				}
				catch (ClassCastException ex2) when (JNIEnv.ShouldWrapJavaException(ex2, "Add"))
				{
					throw new InvalidCastException(ex2.Message, ex2);
				}
				catch (NullPointerException ex3) when (JNIEnv.ShouldWrapJavaException(ex3, "Add"))
				{
					throw new NullReferenceException(ex3.Message, ex3);
				}
				catch (IllegalArgumentException ex4) when (JNIEnv.ShouldWrapJavaException(ex4, "Add"))
				{
					throw new ArgumentException(ex4.Message, ex4);
				}
				catch (IllegalStateException ex5) when (JNIEnv.ShouldWrapJavaException(ex5, "Add"))
				{
					throw new InvalidOperationException(ex5.Message, ex5);
				}
				return IntPtr.Zero;
			});
		}

		// Token: 0x06001B3E RID: 6974 RVA: 0x00047120 File Offset: 0x00045320
		public void Clear()
		{
			if (JavaCollection<T>.id_clear == IntPtr.Zero)
			{
				JavaCollection<T>.id_clear = JNIEnv.GetMethodID(JavaCollection.collection_class, "clear", "()V");
			}
			try
			{
				JNIEnv.CallVoidMethod(base.Handle, JavaCollection<T>.id_clear);
			}
			catch (UnsupportedOperationException ex) when (JNIEnv.ShouldWrapJavaException(ex, "Clear"))
			{
				throw new NotSupportedException(ex.Message, ex);
			}
		}

		// Token: 0x06001B3F RID: 6975 RVA: 0x000471A8 File Offset: 0x000453A8
		public bool Contains(T item)
		{
			if (JavaCollection<T>.id_contains == IntPtr.Zero)
			{
				JavaCollection<T>.id_contains = JNIEnv.GetMethodID(JavaCollection.collection_class, "contains", "(Ljava/lang/Object;)Z");
			}
			return JavaConvert.WithLocalJniHandle<T, bool>(item, delegate(IntPtr lref)
			{
				bool result;
				try
				{
					result = JNIEnv.CallBooleanMethod(base.Handle, JavaCollection<T>.id_contains, new JValue[]
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

		// Token: 0x06001B40 RID: 6976 RVA: 0x000471E8 File Offset: 0x000453E8
		public void CopyTo(T[] array, int array_index)
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
			if (JavaCollection.id_toArray == IntPtr.Zero)
			{
				JavaCollection.id_toArray = JNIEnv.GetMethodID(JavaCollection.collection_class, "toArray", "()[Ljava/lang/Object;");
			}
			IntPtr intPtr = JNIEnv.CallObjectMethod(base.Handle, JavaCollection.id_toArray);
			for (int i = 0; i < base.Count; i++)
			{
				array[array_index + i] = JavaConvert.FromJniHandle<T>(JNIEnv.GetObjectArrayElement(intPtr, i), JniHandleOwnership.TransferLocalRef);
			}
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x06001B41 RID: 6977 RVA: 0x00047292 File Offset: 0x00045492
		public bool Remove(T item)
		{
			if (JavaCollection<T>.id_remove == IntPtr.Zero)
			{
				JavaCollection<T>.id_remove = JNIEnv.GetMethodID(JavaCollection.collection_class, "remove", "(I)Ljava/lang/Object;");
			}
			return JavaConvert.WithLocalJniHandle<T, bool>(item, delegate(IntPtr lref)
			{
				bool result;
				try
				{
					result = JNIEnv.CallBooleanMethod(base.Handle, JavaCollection<T>.id_remove, new JValue[]
					{
						new JValue(lref)
					});
				}
				catch (ClassCastException ex) when (JNIEnv.ShouldWrapJavaException(ex, "Remove"))
				{
					throw new InvalidCastException(ex.Message, ex);
				}
				catch (NullPointerException ex2) when (JNIEnv.ShouldWrapJavaException(ex2, "Remove"))
				{
					throw new NullReferenceException(ex2.Message, ex2);
				}
				catch (UnsupportedOperationException ex3) when (JNIEnv.ShouldWrapJavaException(ex3, "Remove"))
				{
					throw new NotSupportedException(ex3.Message, ex3);
				}
				return result;
			});
		}

		// Token: 0x06001B42 RID: 6978 RVA: 0x000472D0 File Offset: 0x000454D0
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x06001B43 RID: 6979 RVA: 0x000472D8 File Offset: 0x000454D8
		public new IEnumerator<T> GetEnumerator()
		{
			return base.Iterator().ToEnumerator_Dispose<T>();
		}

		// Token: 0x06001B44 RID: 6980 RVA: 0x000472E8 File Offset: 0x000454E8
		public new static ICollection<T> FromJniHandle(IntPtr handle, JniHandleOwnership transfer)
		{
			if (handle == IntPtr.Zero)
			{
				return null;
			}
			IJavaObject javaObject = (IJavaObject)Java.Lang.Object.PeekObject(handle, null);
			if (javaObject == null)
			{
				javaObject = new JavaCollection<T>(handle, transfer);
			}
			else
			{
				JNIEnv.DeleteRef(handle, transfer);
			}
			return (ICollection<T>)javaObject;
		}

		// Token: 0x06001B45 RID: 6981 RVA: 0x0004732C File Offset: 0x0004552C
		public static IntPtr ToLocalJniHandle(ICollection<T> items)
		{
			if (items == null)
			{
				return IntPtr.Zero;
			}
			JavaCollection<T> javaCollection = items as JavaCollection<T>;
			if (javaCollection != null)
			{
				return JNIEnv.ToLocalJniHandle(javaCollection);
			}
			JavaCollection<T> javaCollection2;
			javaCollection = (javaCollection2 = new JavaCollection<T>(items));
			IntPtr result;
			try
			{
				result = JNIEnv.ToLocalJniHandle(javaCollection);
			}
			finally
			{
				if (javaCollection2 != null)
				{
					((IDisposable)javaCollection2).Dispose();
				}
			}
			return result;
		}

		// Token: 0x04000B94 RID: 2964
		private static IntPtr id_clear;

		// Token: 0x04000B95 RID: 2965
		private static IntPtr id_contains;

		// Token: 0x04000B96 RID: 2966
		private static IntPtr id_remove;
	}
}
