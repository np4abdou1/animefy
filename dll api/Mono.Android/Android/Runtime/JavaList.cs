using System;
using System.Collections;
using System.Linq;
using Java.Interop;
using Java.Lang;
using Java.Util;

namespace Android.Runtime
{
	// Token: 0x020002DA RID: 730
	[Register("java/util/ArrayList", DoNotGenerateAcw = true)]
	public class JavaList : Java.Lang.Object, System.Collections.IList, System.Collections.ICollection, IEnumerable
	{
		// Token: 0x06001B9B RID: 7067 RVA: 0x00048A50 File Offset: 0x00046C50
		internal unsafe object InternalGet(int location, Type targetType = null)
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
			return JavaConvert.FromJniHandle(jniObjectReference.Handle, JniHandleOwnership.TransferLocalRef, targetType);
		}

		// Token: 0x06001B9C RID: 7068 RVA: 0x00048AD8 File Offset: 0x00046CD8
		public virtual IIterator Iterator()
		{
			return Java.Lang.Object.GetObject<IIterator>(JavaList.list_members.InstanceMethods.InvokeAbstractObjectMethod("iterator.()Ljava/util/Iterator;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001B9D RID: 7069 RVA: 0x00048B0C File Offset: 0x00046D0C
		internal unsafe void InternalSet(int location, object value)
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

		// Token: 0x06001B9E RID: 7070 RVA: 0x00048CF8 File Offset: 0x00046EF8
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

		// Token: 0x06001B9F RID: 7071 RVA: 0x000021E0 File Offset: 0x000003E0
		public JavaList(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x06001BA0 RID: 7072 RVA: 0x00048D60 File Offset: 0x00046F60
		public JavaList(IEnumerable items) : this()
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

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x06001BA1 RID: 7073 RVA: 0x00048DCC File Offset: 0x00046FCC
		public int Count
		{
			get
			{
				return JavaList.list_members.InstanceMethods.InvokeAbstractInt32Method("size.()I", this, null);
			}
		}

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x06001BA2 RID: 7074 RVA: 0x00045ABE File Offset: 0x00043CBE
		public bool IsFixedSize
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x06001BA3 RID: 7075 RVA: 0x00045ABE File Offset: 0x00043CBE
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x06001BA4 RID: 7076 RVA: 0x00045ABE File Offset: 0x00043CBE
		public bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x06001BA5 RID: 7077 RVA: 0x00046D05 File Offset: 0x00044F05
		public object SyncRoot
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170005F1 RID: 1521
		public object this[int index]
		{
			get
			{
				if (index < 0 || index >= this.Count)
				{
					throw new ArgumentOutOfRangeException("index");
				}
				return this.InternalGet(index, null);
			}
			set
			{
				this.InternalSet(index, value);
			}
		}

		// Token: 0x06001BA8 RID: 7080 RVA: 0x00048E14 File Offset: 0x00047014
		public unsafe int Add(object item)
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
			return this.Count - 1;
		}

		// Token: 0x06001BA9 RID: 7081 RVA: 0x00048F68 File Offset: 0x00047168
		public void Clear()
		{
			try
			{
				JavaList.list_members.InstanceMethods.InvokeAbstractVoidMethod("clear.()V", this, null);
			}
			catch (UnsupportedOperationException ex) when (JNIEnv.ShouldWrapJavaException(ex, "Clear"))
			{
				throw new NotSupportedException(ex.Message, ex);
			}
		}

		// Token: 0x06001BAA RID: 7082 RVA: 0x00048FCC File Offset: 0x000471CC
		public unsafe bool Contains(object item)
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

		// Token: 0x06001BAB RID: 7083 RVA: 0x000490A4 File Offset: 0x000472A4
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
			Type elementType = array.GetType().GetElementType();
			int count = this.Count;
			for (int i = 0; i < count; i++)
			{
				array.SetValue(this.InternalGet(i, elementType), array_index + i);
			}
		}

		// Token: 0x06001BAC RID: 7084 RVA: 0x00049119 File Offset: 0x00047319
		public IEnumerator GetEnumerator()
		{
			return this.Iterator().ToEnumerator_Dispose();
		}

		// Token: 0x06001BAD RID: 7085 RVA: 0x00049128 File Offset: 0x00047328
		public unsafe virtual int IndexOf(object item)
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

		// Token: 0x06001BAE RID: 7086 RVA: 0x00049200 File Offset: 0x00047400
		public unsafe virtual int LastIndexOf(object item)
		{
			IntPtr intPtr = JavaConvert.ToLocalJniHandle(item);
			int result;
			try
			{
				IntPtr intPtr2 = stackalloc byte[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*intPtr2 = new JniArgumentValue(intPtr);
				JniArgumentValue* parameters = intPtr2;
				result = JavaList.list_members.InstanceMethods.InvokeAbstractInt32Method("lastIndexOf.(Ljava/lang/Object;)I", this, parameters);
			}
			catch (ClassCastException ex) when (JNIEnv.ShouldWrapJavaException(ex, "LastIndexOf"))
			{
				throw new InvalidCastException(ex.Message, ex);
			}
			catch (NullPointerException ex2) when (JNIEnv.ShouldWrapJavaException(ex2, "LastIndexOf"))
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

		// Token: 0x06001BAF RID: 7087 RVA: 0x000492D8 File Offset: 0x000474D8
		public unsafe void Insert(int index, object item)
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

		// Token: 0x06001BB0 RID: 7088 RVA: 0x000494B8 File Offset: 0x000476B8
		public void Remove(object item)
		{
			int num = this.IndexOf(item);
			if (num < 0 && num >= this.Count)
			{
				return;
			}
			this.RemoveAt(num);
		}

		// Token: 0x06001BB1 RID: 7089 RVA: 0x000494E4 File Offset: 0x000476E4
		public unsafe void RemoveAt(int index)
		{
			try
			{
				IntPtr intPtr = stackalloc byte[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*intPtr = new JniArgumentValue(index);
				JniArgumentValue* parameters = intPtr;
				JniObjectReference jniObjectReference = JavaList.list_members.InstanceMethods.InvokeAbstractObjectMethod("remove.(I)Ljava/lang/Object;", this, parameters);
				JniObjectReference.Dispose(ref jniObjectReference);
			}
			catch (UnsupportedOperationException ex) when (JNIEnv.ShouldWrapJavaException(ex, "RemoveAt"))
			{
				throw new NotSupportedException(ex.Message, ex);
			}
			catch (IndexOutOfBoundsException ex2) when (JNIEnv.ShouldWrapJavaException(ex2, "RemoveAt"))
			{
				throw new ArgumentOutOfRangeException(ex2.Message, ex2);
			}
		}

		// Token: 0x06001BB2 RID: 7090 RVA: 0x0004959C File Offset: 0x0004779C
		public unsafe virtual Java.Lang.Object Set(int location, Java.Lang.Object item)
		{
			JniObjectReference jniObjectReference;
			try
			{
				IntPtr intPtr = stackalloc byte[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*intPtr = new JniArgumentValue(location);
				*(intPtr + (IntPtr)sizeof(JniArgumentValue)) = new JniArgumentValue(item);
				JniArgumentValue* parameters = intPtr;
				jniObjectReference = JavaList.list_members.InstanceMethods.InvokeAbstractObjectMethod("set.(ILjava/lang/Object;)Ljava/lang/Object;", this, parameters);
			}
			catch (UnsupportedOperationException ex) when (JNIEnv.ShouldWrapJavaException(ex, "Set"))
			{
				throw new NotSupportedException(ex.Message, ex);
			}
			catch (ClassCastException ex2) when (JNIEnv.ShouldWrapJavaException(ex2, "Set"))
			{
				throw new InvalidCastException(ex2.Message, ex2);
			}
			catch (NullPointerException ex3) when (JNIEnv.ShouldWrapJavaException(ex3, "Set"))
			{
				throw new NullReferenceException(ex3.Message, ex3);
			}
			catch (IllegalArgumentException ex4) when (JNIEnv.ShouldWrapJavaException(ex4, "Set"))
			{
				throw new ArgumentException(ex4.Message, ex4);
			}
			catch (IndexOutOfBoundsException ex5) when (JNIEnv.ShouldWrapJavaException(ex5, "Set"))
			{
				throw new ArgumentOutOfRangeException(ex5.Message, ex5);
			}
			return Java.Lang.Object.GetObject<Java.Lang.Object>(jniObjectReference.Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001BB3 RID: 7091 RVA: 0x00049720 File Offset: 0x00047920
		public unsafe virtual JavaList SubList(int start, int end)
		{
			JniObjectReference jniObjectReference;
			try
			{
				IntPtr intPtr = stackalloc byte[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*intPtr = new JniArgumentValue(start);
				*(intPtr + (IntPtr)sizeof(JniArgumentValue)) = new JniArgumentValue(end);
				JniArgumentValue* parameters = intPtr;
				jniObjectReference = JavaList.list_members.InstanceMethods.InvokeAbstractObjectMethod("subList.(II)Ljava/util/List;", this, parameters);
			}
			catch (IllegalArgumentException ex) when (JNIEnv.ShouldWrapJavaException(ex, "SubList"))
			{
				throw new ArgumentException(ex.Message, ex);
			}
			catch (IndexOutOfBoundsException ex2) when (JNIEnv.ShouldWrapJavaException(ex2, "SubList"))
			{
				throw new ArgumentOutOfRangeException(ex2.Message, ex2);
			}
			return new JavaList(jniObjectReference.Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001BB4 RID: 7092 RVA: 0x000497F0 File Offset: 0x000479F0
		public static System.Collections.IList FromJniHandle(IntPtr handle, JniHandleOwnership transfer)
		{
			if (handle == IntPtr.Zero)
			{
				return null;
			}
			IJavaObject javaObject = (IJavaObject)Java.Lang.Object.PeekObject(handle, null);
			if (javaObject == null)
			{
				javaObject = new JavaList(handle, transfer);
			}
			else
			{
				JNIEnv.DeleteRef(handle, transfer);
			}
			return (System.Collections.IList)javaObject;
		}

		// Token: 0x06001BB5 RID: 7093 RVA: 0x00049834 File Offset: 0x00047A34
		public static IntPtr ToLocalJniHandle(System.Collections.IList items)
		{
			if (items == null)
			{
				return IntPtr.Zero;
			}
			JavaList javaList = items as JavaList;
			if (javaList != null)
			{
				return JNIEnv.ToLocalJniHandle(javaList);
			}
			JavaList javaList2;
			javaList = (javaList2 = new JavaList(items));
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

		// Token: 0x06001BB6 RID: 7094 RVA: 0x00049888 File Offset: 0x00047A88
		public virtual bool Add(Java.Lang.Object item)
		{
			return this.Add(0, item);
		}

		// Token: 0x06001BB7 RID: 7095 RVA: 0x00049892 File Offset: 0x00047A92
		public virtual bool Add(int index, Java.Lang.Object item)
		{
			if (this.Contains(item))
			{
				return false;
			}
			this.Add(item);
			return true;
		}

		// Token: 0x06001BB8 RID: 7096 RVA: 0x000498A8 File Offset: 0x00047AA8
		public virtual bool Add(JavaList collection)
		{
			return this.AddAll(0, collection);
		}

		// Token: 0x06001BB9 RID: 7097 RVA: 0x000498B4 File Offset: 0x00047AB4
		public virtual bool AddAll(int location, JavaList collection)
		{
			int num = location;
			bool flag = false;
			foreach (object obj in collection)
			{
				Java.Lang.Object item = (Java.Lang.Object)obj;
				flag |= this.Add(num++, item);
			}
			return flag;
		}

		// Token: 0x06001BBA RID: 7098 RVA: 0x00049918 File Offset: 0x00047B18
		public virtual bool Contains(Java.Lang.Object item)
		{
			return this.Contains(item);
		}

		// Token: 0x06001BBB RID: 7099 RVA: 0x00049924 File Offset: 0x00047B24
		public virtual bool ContainsAll(JavaList collection)
		{
			foreach (object obj in collection)
			{
				Java.Lang.Object item = (Java.Lang.Object)obj;
				if (!this.Contains(item))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06001BBC RID: 7100 RVA: 0x00049984 File Offset: 0x00047B84
		public new virtual bool Equals(Java.Lang.Object obj)
		{
			JavaList javaList = obj as JavaList;
			if (javaList == null || this.Count != javaList.Count)
			{
				return false;
			}
			for (int i = 0; i < this.Count; i++)
			{
				object obj2 = this[i];
				if (obj2 == null || !obj2.Equals(javaList[i]))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06001BBD RID: 7101 RVA: 0x000499DB File Offset: 0x00047BDB
		public virtual Java.Lang.Object Get(int location)
		{
			return (Java.Lang.Object)this.InternalGet(location, null);
		}

		// Token: 0x06001BBE RID: 7102 RVA: 0x000499EA File Offset: 0x00047BEA
		public virtual int IndexOf(Java.Lang.Object item)
		{
			return this.IndexOf(item);
		}

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x06001BBF RID: 7103 RVA: 0x000499F3 File Offset: 0x00047BF3
		public virtual bool IsEmpty
		{
			get
			{
				return this.Count == 0;
			}
		}

		// Token: 0x06001BC0 RID: 7104 RVA: 0x000499FE File Offset: 0x00047BFE
		public virtual Java.Lang.Object Remove(int location)
		{
			Java.Lang.Object result = this.Get(location);
			this.RemoveAt(location);
			return result;
		}

		// Token: 0x06001BC1 RID: 7105 RVA: 0x00049A10 File Offset: 0x00047C10
		public virtual bool Remove(Java.Lang.Object item)
		{
			int num = this.IndexOf(item);
			if (num < 0 && num >= this.Count)
			{
				return false;
			}
			this.RemoveAt(num);
			return true;
		}

		// Token: 0x06001BC2 RID: 7106 RVA: 0x00049A3C File Offset: 0x00047C3C
		public virtual bool RemoveAll(JavaList collection)
		{
			bool flag = false;
			foreach (object obj in collection)
			{
				Java.Lang.Object item = (Java.Lang.Object)obj;
				flag |= this.Remove(item);
			}
			return flag;
		}

		// Token: 0x06001BC3 RID: 7107 RVA: 0x00049A98 File Offset: 0x00047C98
		public virtual bool RetainAll(JavaList collection)
		{
			bool result = false;
			for (int i = 0; i < this.Count; i++)
			{
				Java.Lang.Object item = this.Get(i);
				if (!collection.Contains(item))
				{
					this.Remove(item);
					result = true;
					i--;
				}
			}
			return result;
		}

		// Token: 0x06001BC4 RID: 7108 RVA: 0x00049AD8 File Offset: 0x00047CD8
		public virtual int Size()
		{
			return this.Count;
		}

		// Token: 0x06001BC5 RID: 7109 RVA: 0x00049AE0 File Offset: 0x00047CE0
		public virtual Java.Lang.Object[] ToArray(Java.Lang.Object[] array)
		{
			if (array.Length < this.Count)
			{
				array = new Java.Lang.Object[this.Count];
			}
			this.CopyTo(array, 0);
			return array;
		}

		// Token: 0x06001BC6 RID: 7110 RVA: 0x00049B03 File Offset: 0x00047D03
		public virtual Java.Lang.Object[] ToArray()
		{
			return this.ToArray(new Java.Lang.Object[0]);
		}

		// Token: 0x04000BB1 RID: 2993
		internal static readonly JniPeerMembers list_members = new XAPeerMembers("java/util/List", typeof(JavaList), true);
	}
}
