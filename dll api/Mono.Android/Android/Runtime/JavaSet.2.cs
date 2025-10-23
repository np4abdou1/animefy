using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Java.Interop;
using Java.Lang;

namespace Android.Runtime
{
	// Token: 0x020002E0 RID: 736
	[Register("java/util/HashSet", DoNotGenerateAcw = true)]
	public class JavaSet<T> : JavaSet, ICollection<T>, IEnumerable<T>, IEnumerable
	{
		// Token: 0x06001C03 RID: 7171 RVA: 0x0004B09C File Offset: 0x0004929C
		public JavaSet()
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			if (base.GetType() == typeof(JavaSet<T>))
			{
				base.SetHandle(JNIEnv.StartCreateInstance("java/util/HashSet", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef);
			}
			else
			{
				base.SetHandle(JNIEnv.StartCreateInstance(base.GetType(), "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef);
			}
			JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
		}

		// Token: 0x06001C04 RID: 7172 RVA: 0x0004B127 File Offset: 0x00049327
		public JavaSet(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x06001C05 RID: 7173 RVA: 0x0004B134 File Offset: 0x00049334
		public JavaSet(IEnumerable<T> items) : this()
		{
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

		// Token: 0x06001C06 RID: 7174 RVA: 0x0004B198 File Offset: 0x00049398
		public void Add(T item)
		{
			if (JavaSet.id_add == IntPtr.Zero)
			{
				JavaSet.id_add = JNIEnv.GetMethodID(JavaSet.set_class, "add", "(Ljava/lang/Object;)Z");
			}
			JavaConvert.WithLocalJniHandle<T, bool>(item, delegate(IntPtr lref)
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

		// Token: 0x06001C07 RID: 7175 RVA: 0x0004B1D7 File Offset: 0x000493D7
		public bool Contains(T item)
		{
			if (JavaSet.id_contains == IntPtr.Zero)
			{
				JavaSet.id_contains = JNIEnv.GetMethodID(JavaSet.set_class, "contains", "(Ljava/lang/Object;)Z");
			}
			return JavaConvert.WithLocalJniHandle<T, bool>(item, delegate(IntPtr lref)
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

		// Token: 0x06001C08 RID: 7176 RVA: 0x0004B218 File Offset: 0x00049418
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
			int num = 0;
			foreach (T t in this)
			{
				array[array_index + num++] = t;
			}
		}

		// Token: 0x06001C09 RID: 7177 RVA: 0x0004B2A0 File Offset: 0x000494A0
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x06001C0A RID: 7178 RVA: 0x0004B2A8 File Offset: 0x000494A8
		public new IEnumerator<T> GetEnumerator()
		{
			return base.Iterator().ToEnumerator_Dispose<T>();
		}

		// Token: 0x06001C0B RID: 7179 RVA: 0x0004B2B5 File Offset: 0x000494B5
		public bool Remove(T item)
		{
			if (JavaSet.id_remove == IntPtr.Zero)
			{
				JavaSet.id_remove = JNIEnv.GetMethodID(JavaSet.set_class, "remove", "(Ljava/lang/Object;)Z");
			}
			return JavaConvert.WithLocalJniHandle<T, bool>(item, delegate(IntPtr lref)
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

		// Token: 0x06001C0C RID: 7180 RVA: 0x0004B2F4 File Offset: 0x000494F4
		public new static ICollection<T> FromJniHandle(IntPtr handle, JniHandleOwnership transfer)
		{
			if (handle == IntPtr.Zero)
			{
				return null;
			}
			IJavaObject javaObject = (IJavaObject)Java.Lang.Object.PeekObject(handle, null);
			if (javaObject == null)
			{
				javaObject = new JavaSet<T>(handle, transfer);
			}
			else
			{
				JNIEnv.DeleteRef(handle, transfer);
			}
			return (ICollection<T>)javaObject;
		}

		// Token: 0x06001C0D RID: 7181 RVA: 0x0004B338 File Offset: 0x00049538
		public static IntPtr ToLocalJniHandle(ICollection<T> items)
		{
			if (items == null)
			{
				return IntPtr.Zero;
			}
			JavaSet<T> javaSet = items as JavaSet<T>;
			if (javaSet != null)
			{
				return JNIEnv.ToLocalJniHandle(javaSet);
			}
			JavaSet<T> javaSet2;
			javaSet = (javaSet2 = new JavaSet<T>(items));
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
	}
}
