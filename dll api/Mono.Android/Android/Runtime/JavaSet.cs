using System;
using System.Collections;
using System.Linq;
using Java.Interop;
using Java.Lang;
using Java.Util;

namespace Android.Runtime
{
	// Token: 0x020002DF RID: 735
	[Register("java/util/HashSet", DoNotGenerateAcw = true)]
	public class JavaSet : Java.Lang.Object, System.Collections.ICollection, IEnumerable
	{
		// Token: 0x06001BEE RID: 7150 RVA: 0x0004A9DC File Offset: 0x00048BDC
		internal IIterator Iterator()
		{
			if (JavaSet.id_iterator == IntPtr.Zero)
			{
				JavaSet.id_iterator = JNIEnv.GetMethodID(JavaSet.set_class, "iterator", "()Ljava/util/Iterator;");
			}
			return Java.Lang.Object.GetObject<IIterator>(JNIEnv.CallObjectMethod(base.Handle, JavaSet.id_iterator), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001BEF RID: 7151 RVA: 0x0004AA2C File Offset: 0x00048C2C
		public JavaSet() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			if (base.GetType() == typeof(JavaSet))
			{
				base.SetHandle(JNIEnv.StartCreateInstance("java/util/HashSet", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef);
			}
			else
			{
				base.SetHandle(JNIEnv.StartCreateInstance(base.GetType(), "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef);
			}
			JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
		}

		// Token: 0x06001BF0 RID: 7152 RVA: 0x000021E0 File Offset: 0x000003E0
		public JavaSet(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x06001BF1 RID: 7153 RVA: 0x0004AAC0 File Offset: 0x00048CC0
		public JavaSet(IEnumerable items) : this()
		{
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

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x06001BF2 RID: 7154 RVA: 0x0004AB2C File Offset: 0x00048D2C
		public int Count
		{
			get
			{
				if (JavaSet.id_size == IntPtr.Zero)
				{
					JavaSet.id_size = JNIEnv.GetMethodID(JavaSet.set_class, "size", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, JavaSet.id_size);
			}
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x06001BF3 RID: 7155 RVA: 0x00045ABE File Offset: 0x00043CBE
		public bool IsFixedSize
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x06001BF4 RID: 7156 RVA: 0x00045ABE File Offset: 0x00043CBE
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x06001BF5 RID: 7157 RVA: 0x00045ABE File Offset: 0x00043CBE
		public bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x06001BF6 RID: 7158 RVA: 0x00046D05 File Offset: 0x00044F05
		public object SyncRoot
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06001BF7 RID: 7159 RVA: 0x0004AB68 File Offset: 0x00048D68
		public void Add(object item)
		{
			if (JavaSet.id_add == IntPtr.Zero)
			{
				JavaSet.id_add = JNIEnv.GetMethodID(JavaSet.set_class, "add", "(Ljava/lang/Object;)Z");
			}
			JavaConvert.WithLocalJniHandle<bool>(item, delegate(IntPtr lref)
			{
				bool result;
				try
				{
					result = JNIEnv.CallBooleanMethod(base.Handle, JavaSet.id_add, new JValue[]
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
				return result;
			});
		}

		// Token: 0x06001BF8 RID: 7160 RVA: 0x0004ABA8 File Offset: 0x00048DA8
		public void Clear()
		{
			if (JavaSet.id_clear == IntPtr.Zero)
			{
				JavaSet.id_clear = JNIEnv.GetMethodID(JavaSet.set_class, "clear", "()V");
			}
			try
			{
				JNIEnv.CallVoidMethod(base.Handle, JavaSet.id_clear);
			}
			catch (UnsupportedOperationException ex) when (JNIEnv.ShouldWrapJavaException(ex, "Clear"))
			{
				throw new NotSupportedException(ex.Message, ex);
			}
		}

		// Token: 0x06001BF9 RID: 7161 RVA: 0x0004AC30 File Offset: 0x00048E30
		public bool Contains(object item)
		{
			if (JavaSet.id_contains == IntPtr.Zero)
			{
				JavaSet.id_contains = JNIEnv.GetMethodID(JavaSet.set_class, "contains", "(Ljava/lang/Object;)Z");
			}
			return JavaConvert.WithLocalJniHandle<bool>(item, delegate(IntPtr lref)
			{
				bool result;
				try
				{
					result = JNIEnv.CallBooleanMethod(base.Handle, JavaSet.id_contains, new JValue[]
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

		// Token: 0x06001BFA RID: 7162 RVA: 0x0004AC70 File Offset: 0x00048E70
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

		// Token: 0x06001BFB RID: 7163 RVA: 0x0004AD00 File Offset: 0x00048F00
		public IEnumerator GetEnumerator()
		{
			return this.Iterator().ToEnumerator_Dispose();
		}

		// Token: 0x06001BFC RID: 7164 RVA: 0x0004AD0D File Offset: 0x00048F0D
		public void Remove(object item)
		{
			if (JavaSet.id_remove == IntPtr.Zero)
			{
				JavaSet.id_remove = JNIEnv.GetMethodID(JavaSet.set_class, "remove", "(Ljava/lang/Object;)Z");
			}
			JavaConvert.WithLocalJniHandle<bool>(item, delegate(IntPtr lref)
			{
				bool result;
				try
				{
					result = JNIEnv.CallBooleanMethod(base.Handle, JavaSet.id_remove, new JValue[]
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
			});
		}

		// Token: 0x06001BFD RID: 7165 RVA: 0x0004AD4C File Offset: 0x00048F4C
		public static System.Collections.ICollection FromJniHandle(IntPtr handle, JniHandleOwnership transfer)
		{
			if (handle == IntPtr.Zero)
			{
				return null;
			}
			IJavaObject javaObject = (IJavaObject)Java.Lang.Object.PeekObject(handle, null);
			if (javaObject == null)
			{
				javaObject = new JavaSet(handle, transfer);
			}
			else
			{
				JNIEnv.DeleteRef(handle, transfer);
			}
			return (System.Collections.ICollection)javaObject;
		}

		// Token: 0x06001BFE RID: 7166 RVA: 0x0004AD90 File Offset: 0x00048F90
		public static IntPtr ToLocalJniHandle(System.Collections.ICollection items)
		{
			if (items == null)
			{
				return IntPtr.Zero;
			}
			JavaSet javaSet = items as JavaSet;
			if (javaSet != null)
			{
				return JNIEnv.ToLocalJniHandle(javaSet);
			}
			JavaSet javaSet2;
			javaSet = (javaSet2 = new JavaSet(items));
			IntPtr result;
			try
			{
				result = JNIEnv.ToLocalJniHandle(javaSet);
			}
			finally
			{
				if (javaSet2 != null)
				{
					((IDisposable)javaSet2).Dispose();
				}
			}
			return result;
		}

		// Token: 0x04000BBE RID: 3006
		internal static IntPtr set_class = JNIEnv.FindClass("java/util/Set");

		// Token: 0x04000BBF RID: 3007
		internal static IntPtr id_add;

		// Token: 0x04000BC0 RID: 3008
		internal static IntPtr id_contains;

		// Token: 0x04000BC1 RID: 3009
		internal static IntPtr id_remove;

		// Token: 0x04000BC2 RID: 3010
		private static IntPtr id_iterator;

		// Token: 0x04000BC3 RID: 3011
		internal static IntPtr id_ctor;

		// Token: 0x04000BC4 RID: 3012
		private static IntPtr id_size;

		// Token: 0x04000BC5 RID: 3013
		private static IntPtr id_clear;
	}
}
