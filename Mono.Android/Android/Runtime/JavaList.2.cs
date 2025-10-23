using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Java.Interop;
using Java.Lang;

namespace Android.Runtime
{
	// Token: 0x020002DB RID: 731
	[Register("java/util/ArrayList", DoNotGenerateAcw = true)]
	public class JavaList<T> : JavaList, IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
	{
		// Token: 0x06001BC8 RID: 7112 RVA: 0x00049B30 File Offset: 0x00047D30
		public JavaList() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniPeerMembers.JniInstanceMethods instanceMethods = this.JniPeerMembers.InstanceMethods;
			base.SetHandle(instanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			instanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06001BC9 RID: 7113 RVA: 0x00049B96 File Offset: 0x00047D96
		public JavaList(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x06001BCA RID: 7114 RVA: 0x00049BA0 File Offset: 0x00047DA0
		public JavaList(IEnumerable<T> items) : this()
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

		// Token: 0x06001BCB RID: 7115 RVA: 0x00049C04 File Offset: 0x00047E04
		internal unsafe T InternalGet(int location)
		{
			JniObjectReference jniObjectReference;
			try
			{
				IntPtr intPtr = stackalloc byte[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*intPtr = new JniArgumentValue(location);
				JniArgumentValue* parameters = intPtr;
				jniObjectReference = JavaList.list_members.InstanceMethods.InvokeAbstractObjectMethod("get.(I)Ljava/lang/Object;", this, parameters);
			}
			catch (IndexOutOfBoundsException ex) when (JNIEnv.ShouldWrapJavaException(ex, "InternalGet"))
			{
				throw new ArgumentOutOfRangeException(ex.Message, ex);
			}
			return JavaConvert.FromJniHandle<T>(jniObjectReference.Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001BCC RID: 7116 RVA: 0x00049C8C File Offset: 0x00047E8C
		internal unsafe void InternalSet(int location, T value)
		{
			IntPtr intPtr = JavaConvert.ToLocalJniHandle(value);
			try
			{
				IntPtr intPtr2 = stackalloc byte[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*intPtr2 = new JniArgumentValue(location);
				*(intPtr2 + (IntPtr)sizeof(JniArgumentValue)) = new JniArgumentValue(intPtr);
				JniArgumentValue* parameters = intPtr2;
				JniObjectReference jniObjectReference = JavaList.list_members.InstanceMethods.InvokeAbstractObjectMethod("set.(ILjava/lang/Object;)Ljava/lang/Object;", this, parameters);
				JniObjectReference.Dispose(ref jniObjectReference);
			}
			catch (UnsupportedOperationException ex) when (JNIEnv.ShouldWrapJavaException(ex, "InternalSet"))
			{
				throw new NotSupportedException(ex.Message, ex);
			}
			catch (ClassCastException ex2) when (JNIEnv.ShouldWrapJavaException(ex2, "InternalSet"))
			{
				throw new InvalidCastException(ex2.Message, ex2);
			}
			catch (NullPointerException ex3) when (JNIEnv.ShouldWrapJavaException(ex3, "InternalSet"))
			{
				throw new NullReferenceException(ex3.Message, ex3);
			}
			catch (IllegalArgumentException ex4) when (JNIEnv.ShouldWrapJavaException(ex4, "InternalSet"))
			{
				throw new ArgumentException(ex4.Message, ex4);
			}
			catch (IndexOutOfBoundsException ex5) when (JNIEnv.ShouldWrapJavaException(ex5, "InternalSet"))
			{
				throw new ArgumentOutOfRangeException(ex5.Message, ex5);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(value);
			}
		}

		// Token: 0x170005F3 RID: 1523
		public T this[int index]
		{
			get
			{
				if (index < 0 || index >= base.Count)
				{
					throw new ArgumentOutOfRangeException("index");
				}
				return this.InternalGet(index);
			}
			set
			{
				this.InternalSet(index, value);
			}
		}

		// Token: 0x06001BCF RID: 7119 RVA: 0x00049EAC File Offset: 0x000480AC
		public unsafe void Add(T item)
		{
			IntPtr intPtr = JavaConvert.ToLocalJniHandle(item);
			try
			{
				IntPtr intPtr2 = stackalloc byte[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*intPtr2 = new JniArgumentValue(intPtr);
				JniArgumentValue* parameters = intPtr2;
				JavaList.list_members.InstanceMethods.InvokeAbstractBooleanMethod("add.(Ljava/lang/Object;)Z", this, parameters);
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
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(item);
			}
		}

		// Token: 0x06001BD0 RID: 7120 RVA: 0x0004A000 File Offset: 0x00048200
		public unsafe bool Contains(T item)
		{
			IntPtr intPtr = JavaConvert.ToLocalJniHandle(item);
			bool result;
			try
			{
				IntPtr intPtr2 = stackalloc byte[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*intPtr2 = new JniArgumentValue(intPtr);
				JniArgumentValue* parameters = intPtr2;
				result = JavaList.list_members.InstanceMethods.InvokeAbstractBooleanMethod("contains.(Ljava/lang/Object;)Z", this, parameters);
			}
			catch (ClassCastException ex) when (JNIEnv.ShouldWrapJavaException(ex, "Contains"))
			{
				throw new InvalidCastException(ex.Message, ex);
			}
			catch (NullPointerException ex2) when (JNIEnv.ShouldWrapJavaException(ex2, "Contains"))
			{
				throw new NullReferenceException(ex2.Message, ex2);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(item);
			}
			return result;
		}

		// Token: 0x06001BD1 RID: 7121 RVA: 0x0004A0E0 File Offset: 0x000482E0
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
			for (int i = 0; i < base.Count; i++)
			{
				array[array_index + i] = this[i];
			}
		}

		// Token: 0x06001BD2 RID: 7122 RVA: 0x0004A143 File Offset: 0x00048343
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x06001BD3 RID: 7123 RVA: 0x0004A14B File Offset: 0x0004834B
		public new IEnumerator<T> GetEnumerator()
		{
			return this.Iterator().ToEnumerator_Dispose<T>();
		}

		// Token: 0x06001BD4 RID: 7124 RVA: 0x0004A158 File Offset: 0x00048358
		public unsafe int IndexOf(T item)
		{
			IntPtr intPtr = JavaConvert.ToLocalJniHandle(item);
			int result;
			try
			{
				IntPtr intPtr2 = stackalloc byte[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*intPtr2 = new JniArgumentValue(intPtr);
				JniArgumentValue* parameters = intPtr2;
				result = JavaList.list_members.InstanceMethods.InvokeAbstractInt32Method("indexOf.(Ljava/lang/Object;)I", this, parameters);
			}
			catch (ClassCastException ex) when (JNIEnv.ShouldWrapJavaException(ex, "IndexOf"))
			{
				throw new InvalidCastException(ex.Message, ex);
			}
			catch (NullPointerException ex2) when (JNIEnv.ShouldWrapJavaException(ex2, "IndexOf"))
			{
				throw new NullReferenceException(ex2.Message, ex2);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(item);
			}
			return result;
		}

		// Token: 0x06001BD5 RID: 7125 RVA: 0x0004A238 File Offset: 0x00048438
		public unsafe void Insert(int index, T item)
		{
			IntPtr intPtr = JavaConvert.ToLocalJniHandle(item);
			try
			{
				IntPtr intPtr2 = stackalloc byte[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*intPtr2 = new JniArgumentValue(index);
				*(intPtr2 + (IntPtr)sizeof(JniArgumentValue)) = new JniArgumentValue(intPtr);
				JniArgumentValue* parameters = intPtr2;
				JavaList.list_members.InstanceMethods.InvokeAbstractVoidMethod("add.(ILjava/lang/Object;)V", this, parameters);
			}
			catch (UnsupportedOperationException ex) when (JNIEnv.ShouldWrapJavaException(ex, "Insert"))
			{
				throw new NotSupportedException(ex.Message, ex);
			}
			catch (ClassCastException ex2) when (JNIEnv.ShouldWrapJavaException(ex2, "Insert"))
			{
				throw new InvalidCastException(ex2.Message, ex2);
			}
			catch (NullPointerException ex3) when (JNIEnv.ShouldWrapJavaException(ex3, "Insert"))
			{
				throw new NullReferenceException(ex3.Message, ex3);
			}
			catch (IllegalArgumentException ex4) when (JNIEnv.ShouldWrapJavaException(ex4, "Insert"))
			{
				throw new ArgumentException(ex4.Message, ex4);
			}
			catch (IndexOutOfBoundsException ex5) when (JNIEnv.ShouldWrapJavaException(ex5, "Insert"))
			{
				throw new ArgumentOutOfRangeException(ex5.Message, ex5);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(item);
			}
		}

		// Token: 0x06001BD6 RID: 7126 RVA: 0x0004A420 File Offset: 0x00048620
		public bool Remove(T item)
		{
			int num = this.IndexOf(item);
			if (num < 0 && num >= base.Count)
			{
				return false;
			}
			base.RemoveAt(num);
			return true;
		}

		// Token: 0x06001BD7 RID: 7127 RVA: 0x0004A44C File Offset: 0x0004864C
		public new static IList<T> FromJniHandle(IntPtr handle, JniHandleOwnership transfer)
		{
			if (handle == IntPtr.Zero)
			{
				return null;
			}
			IJavaObject javaObject = (IJavaObject)Java.Lang.Object.PeekObject(handle, typeof(IList<T>));
			if (javaObject == null)
			{
				javaObject = new JavaList<T>(handle, transfer);
			}
			else
			{
				JNIEnv.DeleteRef(handle, transfer);
			}
			return (IList<T>)javaObject;
		}

		// Token: 0x06001BD8 RID: 7128 RVA: 0x0004A498 File Offset: 0x00048698
		public static IntPtr ToLocalJniHandle(IList<T> items)
		{
			if (items == null)
			{
				return IntPtr.Zero;
			}
			JavaList<T> javaList = items as JavaList<T>;
			if (javaList != null)
			{
				return JNIEnv.ToLocalJniHandle(javaList);
			}
			JavaList<T> javaList2;
			javaList = (javaList2 = new JavaList<T>(items));
			IntPtr result;
			try
			{
				result = JNIEnv.ToLocalJniHandle(javaList);
			}
			finally
			{
				if (javaList2 != null)
				{
					((IDisposable)javaList2).Dispose();
				}
			}
			return result;
		}
	}
}
