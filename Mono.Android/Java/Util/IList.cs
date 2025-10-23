using System;
using System.Collections;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util.Functions;

namespace Java.Util
{
	// Token: 0x0200030E RID: 782
	[Register("java/util/List", "", "Java.Util.IListInvoker")]
	[JavaTypeParameters(new string[]
	{
		"E"
	})]
	public interface IList : ICollection, IIterable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x06001FAC RID: 8108
		bool IsEmpty { get; }

		// Token: 0x06001FAD RID: 8109
		bool Add(Java.Lang.Object e);

		// Token: 0x06001FAE RID: 8110
		void Add(int index, Java.Lang.Object element);

		// Token: 0x06001FAF RID: 8111
		bool AddAll(int index, ICollection c);

		// Token: 0x06001FB0 RID: 8112
		bool AddAll(ICollection c);

		// Token: 0x06001FB1 RID: 8113
		void Clear();

		// Token: 0x06001FB2 RID: 8114
		bool Contains(Java.Lang.Object o);

		// Token: 0x06001FB3 RID: 8115
		bool ContainsAll(ICollection c);

		// Token: 0x06001FB4 RID: 8116
		bool Equals(Java.Lang.Object o);

		// Token: 0x06001FB5 RID: 8117
		Java.Lang.Object Get(int index);

		// Token: 0x06001FB6 RID: 8118
		int GetHashCode();

		// Token: 0x06001FB7 RID: 8119
		int IndexOf(Java.Lang.Object o);

		// Token: 0x06001FB8 RID: 8120
		IIterator Iterator();

		// Token: 0x06001FB9 RID: 8121
		int LastIndexOf(Java.Lang.Object o);

		// Token: 0x06001FBA RID: 8122
		IListIterator ListIterator();

		// Token: 0x06001FBB RID: 8123
		IListIterator ListIterator(int index);

		// Token: 0x06001FBC RID: 8124
		Java.Lang.Object Remove(int index);

		// Token: 0x06001FBD RID: 8125
		bool Remove(Java.Lang.Object o);

		// Token: 0x06001FBE RID: 8126
		bool RemoveAll(ICollection c);

		// Token: 0x06001FBF RID: 8127
		bool RetainAll(ICollection c);

		// Token: 0x06001FC0 RID: 8128
		Java.Lang.Object Set(int index, Java.Lang.Object element);

		// Token: 0x06001FC1 RID: 8129
		int Size();

		// Token: 0x06001FC2 RID: 8130
		IList SubList(int fromIndex, int toIndex);

		// Token: 0x06001FC3 RID: 8131
		Java.Lang.Object[] ToArray();

		// Token: 0x06001FC4 RID: 8132
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		Java.Lang.Object[] ToArray(Java.Lang.Object[] a);

		// Token: 0x06001FC5 RID: 8133 RVA: 0x00056718 File Offset: 0x00054918
		[JavaTypeParameters(new string[]
		{
			"E"
		})]
		public unsafe static IList CopyOf(ICollection coll)
		{
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(coll);
			IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = JavaList.FromJniHandle(IList._members.StaticMethods.InvokeObjectMethod("copyOf.(Ljava/util/Collection;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(coll);
			}
			return result;
		}

		// Token: 0x06001FC6 RID: 8134 RVA: 0x00056788 File Offset: 0x00054988
		[JavaTypeParameters(new string[]
		{
			"E"
		})]
		public static IList Of()
		{
			return JavaList.FromJniHandle(IList._members.StaticMethods.InvokeObjectMethod("of.()Ljava/util/List;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001FC7 RID: 8135 RVA: 0x000567BC File Offset: 0x000549BC
		[JavaTypeParameters(new string[]
		{
			"E"
		})]
		public unsafe static IList Of(Java.Lang.Object e1)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(e1);
			IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = JavaList.FromJniHandle(IList._members.StaticMethods.InvokeObjectMethod("of.(Ljava/lang/Object;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(e1);
			}
			return result;
		}

		// Token: 0x06001FC8 RID: 8136 RVA: 0x0005682C File Offset: 0x00054A2C
		[JavaTypeParameters(new string[]
		{
			"E"
		})]
		public unsafe static IList Of(Java.Lang.Object e1, Java.Lang.Object e2)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(e1);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(e2);
			IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				result = JavaList.FromJniHandle(IList._members.StaticMethods.InvokeObjectMethod("of.(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(e1);
				GC.KeepAlive(e2);
			}
			return result;
		}

		// Token: 0x06001FC9 RID: 8137 RVA: 0x000568C4 File Offset: 0x00054AC4
		[JavaTypeParameters(new string[]
		{
			"E"
		})]
		public unsafe static IList Of(Java.Lang.Object e1, Java.Lang.Object e2, Java.Lang.Object e3)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(e1);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(e2);
			IntPtr intPtr3 = JNIEnv.ToLocalJniHandle(e3);
			IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				result = JavaList.FromJniHandle(IList._members.StaticMethods.InvokeObjectMethod("of.(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
				GC.KeepAlive(e1);
				GC.KeepAlive(e2);
				GC.KeepAlive(e3);
			}
			return result;
		}

		// Token: 0x06001FCA RID: 8138 RVA: 0x00056988 File Offset: 0x00054B88
		[JavaTypeParameters(new string[]
		{
			"E"
		})]
		public unsafe static IList Of(Java.Lang.Object e1, Java.Lang.Object e2, Java.Lang.Object e3, Java.Lang.Object e4)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(e1);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(e2);
			IntPtr intPtr3 = JNIEnv.ToLocalJniHandle(e3);
			IntPtr intPtr4 = JNIEnv.ToLocalJniHandle(e4);
			IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				ptr[3] = new JniArgumentValue(intPtr4);
				result = JavaList.FromJniHandle(IList._members.StaticMethods.InvokeObjectMethod("of.(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
				JNIEnv.DeleteLocalRef(intPtr4);
				GC.KeepAlive(e1);
				GC.KeepAlive(e2);
				GC.KeepAlive(e3);
				GC.KeepAlive(e4);
			}
			return result;
		}

		// Token: 0x06001FCB RID: 8139 RVA: 0x00056A7C File Offset: 0x00054C7C
		[JavaTypeParameters(new string[]
		{
			"E"
		})]
		public unsafe static IList Of(Java.Lang.Object e1, Java.Lang.Object e2, Java.Lang.Object e3, Java.Lang.Object e4, Java.Lang.Object e5)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(e1);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(e2);
			IntPtr intPtr3 = JNIEnv.ToLocalJniHandle(e3);
			IntPtr intPtr4 = JNIEnv.ToLocalJniHandle(e4);
			IntPtr intPtr5 = JNIEnv.ToLocalJniHandle(e5);
			IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				ptr[3] = new JniArgumentValue(intPtr4);
				ptr[4] = new JniArgumentValue(intPtr5);
				result = JavaList.FromJniHandle(IList._members.StaticMethods.InvokeObjectMethod("of.(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
				JNIEnv.DeleteLocalRef(intPtr4);
				JNIEnv.DeleteLocalRef(intPtr5);
				GC.KeepAlive(e1);
				GC.KeepAlive(e2);
				GC.KeepAlive(e3);
				GC.KeepAlive(e4);
				GC.KeepAlive(e5);
			}
			return result;
		}

		// Token: 0x06001FCC RID: 8140 RVA: 0x00056B9C File Offset: 0x00054D9C
		[JavaTypeParameters(new string[]
		{
			"E"
		})]
		public unsafe static IList Of(Java.Lang.Object e1, Java.Lang.Object e2, Java.Lang.Object e3, Java.Lang.Object e4, Java.Lang.Object e5, Java.Lang.Object e6)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(e1);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(e2);
			IntPtr intPtr3 = JNIEnv.ToLocalJniHandle(e3);
			IntPtr intPtr4 = JNIEnv.ToLocalJniHandle(e4);
			IntPtr intPtr5 = JNIEnv.ToLocalJniHandle(e5);
			IntPtr intPtr6 = JNIEnv.ToLocalJniHandle(e6);
			IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				ptr[3] = new JniArgumentValue(intPtr4);
				ptr[4] = new JniArgumentValue(intPtr5);
				ptr[5] = new JniArgumentValue(intPtr6);
				result = JavaList.FromJniHandle(IList._members.StaticMethods.InvokeObjectMethod("of.(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
				JNIEnv.DeleteLocalRef(intPtr4);
				JNIEnv.DeleteLocalRef(intPtr5);
				JNIEnv.DeleteLocalRef(intPtr6);
				GC.KeepAlive(e1);
				GC.KeepAlive(e2);
				GC.KeepAlive(e3);
				GC.KeepAlive(e4);
				GC.KeepAlive(e5);
				GC.KeepAlive(e6);
			}
			return result;
		}

		// Token: 0x06001FCD RID: 8141 RVA: 0x00056CEC File Offset: 0x00054EEC
		[JavaTypeParameters(new string[]
		{
			"E"
		})]
		public unsafe static IList Of(Java.Lang.Object e1, Java.Lang.Object e2, Java.Lang.Object e3, Java.Lang.Object e4, Java.Lang.Object e5, Java.Lang.Object e6, Java.Lang.Object e7)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(e1);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(e2);
			IntPtr intPtr3 = JNIEnv.ToLocalJniHandle(e3);
			IntPtr intPtr4 = JNIEnv.ToLocalJniHandle(e4);
			IntPtr intPtr5 = JNIEnv.ToLocalJniHandle(e5);
			IntPtr intPtr6 = JNIEnv.ToLocalJniHandle(e6);
			IntPtr intPtr7 = JNIEnv.ToLocalJniHandle(e7);
			IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				ptr[3] = new JniArgumentValue(intPtr4);
				ptr[4] = new JniArgumentValue(intPtr5);
				ptr[5] = new JniArgumentValue(intPtr6);
				ptr[6] = new JniArgumentValue(intPtr7);
				result = JavaList.FromJniHandle(IList._members.StaticMethods.InvokeObjectMethod("of.(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
				JNIEnv.DeleteLocalRef(intPtr4);
				JNIEnv.DeleteLocalRef(intPtr5);
				JNIEnv.DeleteLocalRef(intPtr6);
				JNIEnv.DeleteLocalRef(intPtr7);
				GC.KeepAlive(e1);
				GC.KeepAlive(e2);
				GC.KeepAlive(e3);
				GC.KeepAlive(e4);
				GC.KeepAlive(e5);
				GC.KeepAlive(e6);
				GC.KeepAlive(e7);
			}
			return result;
		}

		// Token: 0x06001FCE RID: 8142 RVA: 0x00056E6C File Offset: 0x0005506C
		[JavaTypeParameters(new string[]
		{
			"E"
		})]
		public unsafe static IList Of(Java.Lang.Object e1, Java.Lang.Object e2, Java.Lang.Object e3, Java.Lang.Object e4, Java.Lang.Object e5, Java.Lang.Object e6, Java.Lang.Object e7, Java.Lang.Object e8)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(e1);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(e2);
			IntPtr intPtr3 = JNIEnv.ToLocalJniHandle(e3);
			IntPtr intPtr4 = JNIEnv.ToLocalJniHandle(e4);
			IntPtr intPtr5 = JNIEnv.ToLocalJniHandle(e5);
			IntPtr intPtr6 = JNIEnv.ToLocalJniHandle(e6);
			IntPtr intPtr7 = JNIEnv.ToLocalJniHandle(e7);
			IntPtr intPtr8 = JNIEnv.ToLocalJniHandle(e8);
			IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				ptr[3] = new JniArgumentValue(intPtr4);
				ptr[4] = new JniArgumentValue(intPtr5);
				ptr[5] = new JniArgumentValue(intPtr6);
				ptr[6] = new JniArgumentValue(intPtr7);
				ptr[7] = new JniArgumentValue(intPtr8);
				result = JavaList.FromJniHandle(IList._members.StaticMethods.InvokeObjectMethod("of.(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
				JNIEnv.DeleteLocalRef(intPtr4);
				JNIEnv.DeleteLocalRef(intPtr5);
				JNIEnv.DeleteLocalRef(intPtr6);
				JNIEnv.DeleteLocalRef(intPtr7);
				JNIEnv.DeleteLocalRef(intPtr8);
				GC.KeepAlive(e1);
				GC.KeepAlive(e2);
				GC.KeepAlive(e3);
				GC.KeepAlive(e4);
				GC.KeepAlive(e5);
				GC.KeepAlive(e6);
				GC.KeepAlive(e7);
				GC.KeepAlive(e8);
			}
			return result;
		}

		// Token: 0x06001FCF RID: 8143 RVA: 0x0005701C File Offset: 0x0005521C
		[JavaTypeParameters(new string[]
		{
			"E"
		})]
		public unsafe static IList Of(Java.Lang.Object e1, Java.Lang.Object e2, Java.Lang.Object e3, Java.Lang.Object e4, Java.Lang.Object e5, Java.Lang.Object e6, Java.Lang.Object e7, Java.Lang.Object e8, Java.Lang.Object e9)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(e1);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(e2);
			IntPtr intPtr3 = JNIEnv.ToLocalJniHandle(e3);
			IntPtr intPtr4 = JNIEnv.ToLocalJniHandle(e4);
			IntPtr intPtr5 = JNIEnv.ToLocalJniHandle(e5);
			IntPtr intPtr6 = JNIEnv.ToLocalJniHandle(e6);
			IntPtr intPtr7 = JNIEnv.ToLocalJniHandle(e7);
			IntPtr intPtr8 = JNIEnv.ToLocalJniHandle(e8);
			IntPtr intPtr9 = JNIEnv.ToLocalJniHandle(e9);
			IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				ptr[3] = new JniArgumentValue(intPtr4);
				ptr[4] = new JniArgumentValue(intPtr5);
				ptr[5] = new JniArgumentValue(intPtr6);
				ptr[6] = new JniArgumentValue(intPtr7);
				ptr[7] = new JniArgumentValue(intPtr8);
				ptr[8] = new JniArgumentValue(intPtr9);
				result = JavaList.FromJniHandle(IList._members.StaticMethods.InvokeObjectMethod("of.(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
				JNIEnv.DeleteLocalRef(intPtr4);
				JNIEnv.DeleteLocalRef(intPtr5);
				JNIEnv.DeleteLocalRef(intPtr6);
				JNIEnv.DeleteLocalRef(intPtr7);
				JNIEnv.DeleteLocalRef(intPtr8);
				JNIEnv.DeleteLocalRef(intPtr9);
				GC.KeepAlive(e1);
				GC.KeepAlive(e2);
				GC.KeepAlive(e3);
				GC.KeepAlive(e4);
				GC.KeepAlive(e5);
				GC.KeepAlive(e6);
				GC.KeepAlive(e7);
				GC.KeepAlive(e8);
				GC.KeepAlive(e9);
			}
			return result;
		}

		// Token: 0x06001FD0 RID: 8144 RVA: 0x000571FC File Offset: 0x000553FC
		[JavaTypeParameters(new string[]
		{
			"E"
		})]
		public unsafe static IList Of(Java.Lang.Object e1, Java.Lang.Object e2, Java.Lang.Object e3, Java.Lang.Object e4, Java.Lang.Object e5, Java.Lang.Object e6, Java.Lang.Object e7, Java.Lang.Object e8, Java.Lang.Object e9, Java.Lang.Object e10)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(e1);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(e2);
			IntPtr intPtr3 = JNIEnv.ToLocalJniHandle(e3);
			IntPtr intPtr4 = JNIEnv.ToLocalJniHandle(e4);
			IntPtr intPtr5 = JNIEnv.ToLocalJniHandle(e5);
			IntPtr intPtr6 = JNIEnv.ToLocalJniHandle(e6);
			IntPtr intPtr7 = JNIEnv.ToLocalJniHandle(e7);
			IntPtr intPtr8 = JNIEnv.ToLocalJniHandle(e8);
			IntPtr intPtr9 = JNIEnv.ToLocalJniHandle(e9);
			IntPtr intPtr10 = JNIEnv.ToLocalJniHandle(e10);
			IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				ptr[3] = new JniArgumentValue(intPtr4);
				ptr[4] = new JniArgumentValue(intPtr5);
				ptr[5] = new JniArgumentValue(intPtr6);
				ptr[6] = new JniArgumentValue(intPtr7);
				ptr[7] = new JniArgumentValue(intPtr8);
				ptr[8] = new JniArgumentValue(intPtr9);
				ptr[9] = new JniArgumentValue(intPtr10);
				result = JavaList.FromJniHandle(IList._members.StaticMethods.InvokeObjectMethod("of.(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
				JNIEnv.DeleteLocalRef(intPtr4);
				JNIEnv.DeleteLocalRef(intPtr5);
				JNIEnv.DeleteLocalRef(intPtr6);
				JNIEnv.DeleteLocalRef(intPtr7);
				JNIEnv.DeleteLocalRef(intPtr8);
				JNIEnv.DeleteLocalRef(intPtr9);
				JNIEnv.DeleteLocalRef(intPtr10);
				GC.KeepAlive(e1);
				GC.KeepAlive(e2);
				GC.KeepAlive(e3);
				GC.KeepAlive(e4);
				GC.KeepAlive(e5);
				GC.KeepAlive(e6);
				GC.KeepAlive(e7);
				GC.KeepAlive(e8);
				GC.KeepAlive(e9);
				GC.KeepAlive(e10);
			}
			return result;
		}

		// Token: 0x06001FD1 RID: 8145 RVA: 0x00057418 File Offset: 0x00055618
		[JavaTypeParameters(new string[]
		{
			"E"
		})]
		public unsafe static IList Of(params Java.Lang.Object[] elements)
		{
			IntPtr intPtr = JNIEnv.NewArray<Java.Lang.Object>(elements);
			IList result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = JavaList.FromJniHandle(IList._members.StaticMethods.InvokeObjectMethod("of.([Ljava/lang/Object;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (elements != null)
				{
					JNIEnv.CopyArray<Java.Lang.Object>(intPtr, elements);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(elements);
			}
			return result;
		}

		// Token: 0x06001FD2 RID: 8146 RVA: 0x00057494 File Offset: 0x00055694
		private static Delegate GetReplaceAll_Ljava_util_function_UnaryOperator_Handler()
		{
			if (IList.cb_replaceAll_Ljava_util_function_UnaryOperator_ == null)
			{
				IList.cb_replaceAll_Ljava_util_function_UnaryOperator_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IList.n_ReplaceAll_Ljava_util_function_UnaryOperator_));
			}
			return IList.cb_replaceAll_Ljava_util_function_UnaryOperator_;
		}

		// Token: 0x06001FD3 RID: 8147 RVA: 0x000574B8 File Offset: 0x000556B8
		private static void n_ReplaceAll_Ljava_util_function_UnaryOperator_(IntPtr jnienv, IntPtr native__this, IntPtr native__operator)
		{
			IList @object = Java.Lang.Object.GetObject<IList>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IUnaryOperator object2 = Java.Lang.Object.GetObject<IUnaryOperator>(native__operator, JniHandleOwnership.DoNotTransfer);
			@object.ReplaceAll(object2);
		}

		// Token: 0x06001FD4 RID: 8148 RVA: 0x000574DC File Offset: 0x000556DC
		unsafe void ReplaceAll(IUnaryOperator @operator)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((@operator == null) ? IntPtr.Zero : ((Java.Lang.Object)@operator).Handle);
				IList._members.InstanceMethods.InvokeVirtualVoidMethod("replaceAll.(Ljava/util/function/UnaryOperator;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(@operator);
			}
		}

		// Token: 0x06001FD5 RID: 8149 RVA: 0x00057544 File Offset: 0x00055744
		private static Delegate GetSort_Ljava_util_Comparator_Handler()
		{
			if (IList.cb_sort_Ljava_util_Comparator_ == null)
			{
				IList.cb_sort_Ljava_util_Comparator_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IList.n_Sort_Ljava_util_Comparator_));
			}
			return IList.cb_sort_Ljava_util_Comparator_;
		}

		// Token: 0x06001FD6 RID: 8150 RVA: 0x00057568 File Offset: 0x00055768
		private static void n_Sort_Ljava_util_Comparator_(IntPtr jnienv, IntPtr native__this, IntPtr native_c)
		{
			IList @object = Java.Lang.Object.GetObject<IList>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IComparator object2 = Java.Lang.Object.GetObject<IComparator>(native_c, JniHandleOwnership.DoNotTransfer);
			@object.Sort(object2);
		}

		// Token: 0x06001FD7 RID: 8151 RVA: 0x0005758C File Offset: 0x0005578C
		unsafe void Sort(IComparator c)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((c == null) ? IntPtr.Zero : ((Java.Lang.Object)c).Handle);
				IList._members.InstanceMethods.InvokeVirtualVoidMethod("sort.(Ljava/util/Comparator;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(c);
			}
		}

		// Token: 0x06001FD8 RID: 8152 RVA: 0x000575F4 File Offset: 0x000557F4
		private static Delegate GetSpliteratorHandler()
		{
			if (IList.cb_spliterator == null)
			{
				IList.cb_spliterator = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IList.n_Spliterator));
			}
			return IList.cb_spliterator;
		}

		// Token: 0x06001FD9 RID: 8153 RVA: 0x00057618 File Offset: 0x00055818
		private static IntPtr n_Spliterator(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IList>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Spliterator());
		}

		// Token: 0x06001FDA RID: 8154 RVA: 0x0005762C File Offset: 0x0005582C
		ISpliterator Spliterator()
		{
			return Java.Lang.Object.GetObject<ISpliterator>(IList._members.InstanceMethods.InvokeVirtualObjectMethod("spliterator.()Ljava/util/Spliterator;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000CF7 RID: 3319
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/List", typeof(IList), true);

		// Token: 0x04000CF8 RID: 3320
		private static Delegate cb_replaceAll_Ljava_util_function_UnaryOperator_;

		// Token: 0x04000CF9 RID: 3321
		private static Delegate cb_sort_Ljava_util_Comparator_;

		// Token: 0x04000CFA RID: 3322
		private static Delegate cb_spliterator;
	}
}
