using System;
using System.Collections;
using System.Linq;
using Java.Interop;
using Java.Lang;
using Java.Util;

namespace Android.Runtime
{
	// Token: 0x020002CF RID: 719
	[Register("java/util/Collection", DoNotGenerateAcw = true)]
	public class JavaCollection : Java.Lang.Object, System.Collections.ICollection, IEnumerable
	{
		// Token: 0x06001B2C RID: 6956 RVA: 0x000021E0 File Offset: 0x000003E0
		public JavaCollection(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x06001B2D RID: 6957 RVA: 0x00046BA8 File Offset: 0x00044DA8
		internal JavaCollection(IEnumerable items) : base(JNIEnv.StartCreateInstance("java/util/ArrayList", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
		{
			JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
			if (items == null)
			{
				base.Dispose();
				throw new ArgumentNullException("items");
			}
			foreach (object item in items)
			{
				this.Add(item);
			}
		}

		// Token: 0x06001B2E RID: 6958 RVA: 0x00046C3C File Offset: 0x00044E3C
		internal void Add(object item)
		{
			if (JavaCollection.id_add == IntPtr.Zero)
			{
				JavaCollection.id_add = JNIEnv.GetMethodID(JavaCollection.collection_class, "add", "(Ljava/lang/Object;)Z");
			}
			JavaConvert.WithLocalJniHandle<IntPtr>(item, delegate(IntPtr lref)
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

		// Token: 0x06001B2F RID: 6959 RVA: 0x00046C7C File Offset: 0x00044E7C
		internal IIterator Iterator()
		{
			if (JavaCollection.id_iterator == IntPtr.Zero)
			{
				JavaCollection.id_iterator = JNIEnv.GetMethodID(JavaCollection.collection_class, "iterator", "()Ljava/util/Iterator;");
			}
			return Java.Lang.Object.GetObject<IIterator>(JNIEnv.CallObjectMethod(base.Handle, JavaCollection.id_iterator), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x06001B30 RID: 6960 RVA: 0x00046CC9 File Offset: 0x00044EC9
		public int Count
		{
			get
			{
				if (JavaCollection.id_size == IntPtr.Zero)
				{
					JavaCollection.id_size = JNIEnv.GetMethodID(JavaCollection.collection_class, "size", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, JavaCollection.id_size);
			}
		}

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x06001B31 RID: 6961 RVA: 0x00045ABE File Offset: 0x00043CBE
		public bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x06001B32 RID: 6962 RVA: 0x00046D05 File Offset: 0x00044F05
		public object SyncRoot
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06001B33 RID: 6963 RVA: 0x00046D08 File Offset: 0x00044F08
		internal Java.Lang.Object[] ToArray()
		{
			if (JavaCollection.id_toArray == IntPtr.Zero)
			{
				JavaCollection.id_toArray = JNIEnv.GetMethodID(JavaCollection.collection_class, "toArray", "()[Ljava/lang/Object;");
			}
			Java.Lang.Object[] result;
			using (Java.Lang.Object @object = new Java.Lang.Object(JNIEnv.CallObjectMethod(base.Handle, JavaCollection.id_toArray), JniHandleOwnership.TransferLocalRef | JniHandleOwnership.DoNotRegister))
			{
				result = (Java.Lang.Object[])@object;
			}
			return result;
		}

		// Token: 0x06001B34 RID: 6964 RVA: 0x00046D7C File Offset: 0x00044F7C
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
			if (JavaCollection.id_toArray == IntPtr.Zero)
			{
				JavaCollection.id_toArray = JNIEnv.GetMethodID(JavaCollection.collection_class, "toArray", "()[Ljava/lang/Object;");
			}
			IntPtr intPtr = JNIEnv.CallObjectMethod(base.Handle, JavaCollection.id_toArray);
			for (int i = 0; i < this.Count; i++)
			{
				array.SetValue(JavaConvert.FromJniHandle(JNIEnv.GetObjectArrayElement(intPtr, i), JniHandleOwnership.TransferLocalRef, array.GetType().GetElementType()), array_index + i);
			}
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x06001B35 RID: 6965 RVA: 0x00046E34 File Offset: 0x00045034
		public IEnumerator GetEnumerator()
		{
			return this.Iterator().ToEnumerator_Dispose();
		}

		// Token: 0x06001B36 RID: 6966 RVA: 0x00046E44 File Offset: 0x00045044
		public static System.Collections.ICollection FromJniHandle(IntPtr handle, JniHandleOwnership transfer)
		{
			if (handle == IntPtr.Zero)
			{
				return null;
			}
			IJavaObject javaObject = (IJavaObject)Java.Lang.Object.PeekObject(handle, null);
			if (javaObject == null)
			{
				javaObject = new JavaCollection(handle, transfer);
			}
			else
			{
				JNIEnv.DeleteRef(handle, transfer);
			}
			return (System.Collections.ICollection)javaObject;
		}

		// Token: 0x06001B37 RID: 6967 RVA: 0x00046E88 File Offset: 0x00045088
		public static IntPtr ToLocalJniHandle(System.Collections.ICollection items)
		{
			if (items == null)
			{
				return IntPtr.Zero;
			}
			JavaCollection javaCollection = items as JavaCollection;
			if (javaCollection != null)
			{
				return JNIEnv.ToLocalJniHandle(javaCollection);
			}
			JavaCollection javaCollection2;
			javaCollection = (javaCollection2 = new JavaCollection(items));
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

		// Token: 0x04000B8F RID: 2959
		internal static IntPtr collection_class = JNIEnv.FindClass("java/util/Collection");

		// Token: 0x04000B90 RID: 2960
		internal static IntPtr id_add;

		// Token: 0x04000B91 RID: 2961
		private static IntPtr id_iterator;

		// Token: 0x04000B92 RID: 2962
		private static IntPtr id_size;

		// Token: 0x04000B93 RID: 2963
		internal static IntPtr id_toArray;
	}
}
