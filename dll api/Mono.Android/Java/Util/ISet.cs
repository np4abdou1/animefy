using System;
using System.Collections;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Util
{
	// Token: 0x0200031A RID: 794
	[Register("java/util/Set", "", "Java.Util.ISetInvoker")]
	[JavaTypeParameters(new string[]
	{
		"E"
	})]
	public interface ISet : ICollection, IIterable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x0600216F RID: 8559
		bool IsEmpty { get; }

		// Token: 0x06002170 RID: 8560
		bool Add(Java.Lang.Object e);

		// Token: 0x06002171 RID: 8561
		bool AddAll(ICollection c);

		// Token: 0x06002172 RID: 8562
		void Clear();

		// Token: 0x06002173 RID: 8563
		bool Contains(Java.Lang.Object o);

		// Token: 0x06002174 RID: 8564
		bool ContainsAll(ICollection c);

		// Token: 0x06002175 RID: 8565
		bool Equals(Java.Lang.Object o);

		// Token: 0x06002176 RID: 8566
		int GetHashCode();

		// Token: 0x06002177 RID: 8567
		IIterator Iterator();

		// Token: 0x06002178 RID: 8568
		bool Remove(Java.Lang.Object o);

		// Token: 0x06002179 RID: 8569
		bool RemoveAll(ICollection c);

		// Token: 0x0600217A RID: 8570
		bool RetainAll(ICollection c);

		// Token: 0x0600217B RID: 8571
		int Size();

		// Token: 0x0600217C RID: 8572
		Java.Lang.Object[] ToArray();

		// Token: 0x0600217D RID: 8573
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		Java.Lang.Object[] ToArray(Java.Lang.Object[] a);

		// Token: 0x0600217E RID: 8574 RVA: 0x0005DCC4 File Offset: 0x0005BEC4
		[JavaTypeParameters(new string[]
		{
			"E"
		})]
		public unsafe static ICollection CopyOf(ICollection coll)
		{
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(coll);
			ICollection result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = JavaSet.FromJniHandle(ISet._members.StaticMethods.InvokeObjectMethod("copyOf.(Ljava/util/Collection;)Ljava/util/Set;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(coll);
			}
			return result;
		}

		// Token: 0x0600217F RID: 8575 RVA: 0x0005DD34 File Offset: 0x0005BF34
		[JavaTypeParameters(new string[]
		{
			"E"
		})]
		public static ICollection Of()
		{
			return JavaSet.FromJniHandle(ISet._members.StaticMethods.InvokeObjectMethod("of.()Ljava/util/Set;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06002180 RID: 8576 RVA: 0x0005DD68 File Offset: 0x0005BF68
		[JavaTypeParameters(new string[]
		{
			"E"
		})]
		public unsafe static ICollection Of(Java.Lang.Object e1)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(e1);
			ICollection result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = JavaSet.FromJniHandle(ISet._members.StaticMethods.InvokeObjectMethod("of.(Ljava/lang/Object;)Ljava/util/Set;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(e1);
			}
			return result;
		}

		// Token: 0x06002181 RID: 8577 RVA: 0x0005DDD8 File Offset: 0x0005BFD8
		[JavaTypeParameters(new string[]
		{
			"E"
		})]
		public unsafe static ICollection Of(Java.Lang.Object e1, Java.Lang.Object e2)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(e1);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(e2);
			ICollection result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				result = JavaSet.FromJniHandle(ISet._members.StaticMethods.InvokeObjectMethod("of.(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/Set;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
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

		// Token: 0x06002182 RID: 8578 RVA: 0x0005DE70 File Offset: 0x0005C070
		[JavaTypeParameters(new string[]
		{
			"E"
		})]
		public unsafe static ICollection Of(Java.Lang.Object e1, Java.Lang.Object e2, Java.Lang.Object e3)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(e1);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(e2);
			IntPtr intPtr3 = JNIEnv.ToLocalJniHandle(e3);
			ICollection result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				result = JavaSet.FromJniHandle(ISet._members.StaticMethods.InvokeObjectMethod("of.(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/Set;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
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

		// Token: 0x06002183 RID: 8579 RVA: 0x0005DF34 File Offset: 0x0005C134
		[JavaTypeParameters(new string[]
		{
			"E"
		})]
		public unsafe static ICollection Of(Java.Lang.Object e1, Java.Lang.Object e2, Java.Lang.Object e3, Java.Lang.Object e4)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(e1);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(e2);
			IntPtr intPtr3 = JNIEnv.ToLocalJniHandle(e3);
			IntPtr intPtr4 = JNIEnv.ToLocalJniHandle(e4);
			ICollection result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				ptr[3] = new JniArgumentValue(intPtr4);
				result = JavaSet.FromJniHandle(ISet._members.StaticMethods.InvokeObjectMethod("of.(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/Set;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
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

		// Token: 0x06002184 RID: 8580 RVA: 0x0005E028 File Offset: 0x0005C228
		[JavaTypeParameters(new string[]
		{
			"E"
		})]
		public unsafe static ICollection Of(Java.Lang.Object e1, Java.Lang.Object e2, Java.Lang.Object e3, Java.Lang.Object e4, Java.Lang.Object e5)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(e1);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(e2);
			IntPtr intPtr3 = JNIEnv.ToLocalJniHandle(e3);
			IntPtr intPtr4 = JNIEnv.ToLocalJniHandle(e4);
			IntPtr intPtr5 = JNIEnv.ToLocalJniHandle(e5);
			ICollection result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				ptr[3] = new JniArgumentValue(intPtr4);
				ptr[4] = new JniArgumentValue(intPtr5);
				result = JavaSet.FromJniHandle(ISet._members.StaticMethods.InvokeObjectMethod("of.(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/Set;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
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

		// Token: 0x06002185 RID: 8581 RVA: 0x0005E148 File Offset: 0x0005C348
		[JavaTypeParameters(new string[]
		{
			"E"
		})]
		public unsafe static ICollection Of(Java.Lang.Object e1, Java.Lang.Object e2, Java.Lang.Object e3, Java.Lang.Object e4, Java.Lang.Object e5, Java.Lang.Object e6)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(e1);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(e2);
			IntPtr intPtr3 = JNIEnv.ToLocalJniHandle(e3);
			IntPtr intPtr4 = JNIEnv.ToLocalJniHandle(e4);
			IntPtr intPtr5 = JNIEnv.ToLocalJniHandle(e5);
			IntPtr intPtr6 = JNIEnv.ToLocalJniHandle(e6);
			ICollection result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				ptr[3] = new JniArgumentValue(intPtr4);
				ptr[4] = new JniArgumentValue(intPtr5);
				ptr[5] = new JniArgumentValue(intPtr6);
				result = JavaSet.FromJniHandle(ISet._members.StaticMethods.InvokeObjectMethod("of.(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/Set;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
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

		// Token: 0x06002186 RID: 8582 RVA: 0x0005E298 File Offset: 0x0005C498
		[JavaTypeParameters(new string[]
		{
			"E"
		})]
		public unsafe static ICollection Of(Java.Lang.Object e1, Java.Lang.Object e2, Java.Lang.Object e3, Java.Lang.Object e4, Java.Lang.Object e5, Java.Lang.Object e6, Java.Lang.Object e7)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(e1);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(e2);
			IntPtr intPtr3 = JNIEnv.ToLocalJniHandle(e3);
			IntPtr intPtr4 = JNIEnv.ToLocalJniHandle(e4);
			IntPtr intPtr5 = JNIEnv.ToLocalJniHandle(e5);
			IntPtr intPtr6 = JNIEnv.ToLocalJniHandle(e6);
			IntPtr intPtr7 = JNIEnv.ToLocalJniHandle(e7);
			ICollection result;
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
				result = JavaSet.FromJniHandle(ISet._members.StaticMethods.InvokeObjectMethod("of.(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/Set;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
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

		// Token: 0x06002187 RID: 8583 RVA: 0x0005E418 File Offset: 0x0005C618
		[JavaTypeParameters(new string[]
		{
			"E"
		})]
		public unsafe static ICollection Of(Java.Lang.Object e1, Java.Lang.Object e2, Java.Lang.Object e3, Java.Lang.Object e4, Java.Lang.Object e5, Java.Lang.Object e6, Java.Lang.Object e7, Java.Lang.Object e8)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(e1);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(e2);
			IntPtr intPtr3 = JNIEnv.ToLocalJniHandle(e3);
			IntPtr intPtr4 = JNIEnv.ToLocalJniHandle(e4);
			IntPtr intPtr5 = JNIEnv.ToLocalJniHandle(e5);
			IntPtr intPtr6 = JNIEnv.ToLocalJniHandle(e6);
			IntPtr intPtr7 = JNIEnv.ToLocalJniHandle(e7);
			IntPtr intPtr8 = JNIEnv.ToLocalJniHandle(e8);
			ICollection result;
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
				result = JavaSet.FromJniHandle(ISet._members.StaticMethods.InvokeObjectMethod("of.(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/Set;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
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

		// Token: 0x06002188 RID: 8584 RVA: 0x0005E5C8 File Offset: 0x0005C7C8
		[JavaTypeParameters(new string[]
		{
			"E"
		})]
		public unsafe static ICollection Of(Java.Lang.Object e1, Java.Lang.Object e2, Java.Lang.Object e3, Java.Lang.Object e4, Java.Lang.Object e5, Java.Lang.Object e6, Java.Lang.Object e7, Java.Lang.Object e8, Java.Lang.Object e9)
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
			ICollection result;
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
				result = JavaSet.FromJniHandle(ISet._members.StaticMethods.InvokeObjectMethod("of.(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/Set;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
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

		// Token: 0x06002189 RID: 8585 RVA: 0x0005E7A8 File Offset: 0x0005C9A8
		[JavaTypeParameters(new string[]
		{
			"E"
		})]
		public unsafe static ICollection Of(Java.Lang.Object e1, Java.Lang.Object e2, Java.Lang.Object e3, Java.Lang.Object e4, Java.Lang.Object e5, Java.Lang.Object e6, Java.Lang.Object e7, Java.Lang.Object e8, Java.Lang.Object e9, Java.Lang.Object e10)
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
			ICollection result;
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
				result = JavaSet.FromJniHandle(ISet._members.StaticMethods.InvokeObjectMethod("of.(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/Set;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
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

		// Token: 0x0600218A RID: 8586 RVA: 0x0005E9C4 File Offset: 0x0005CBC4
		[JavaTypeParameters(new string[]
		{
			"E"
		})]
		public unsafe static ICollection Of(params Java.Lang.Object[] elements)
		{
			IntPtr intPtr = JNIEnv.NewArray<Java.Lang.Object>(elements);
			ICollection result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = JavaSet.FromJniHandle(ISet._members.StaticMethods.InvokeObjectMethod("of.([Ljava/lang/Object;)Ljava/util/Set;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
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

		// Token: 0x0600218B RID: 8587 RVA: 0x0005EA40 File Offset: 0x0005CC40
		private static Delegate GetSpliteratorHandler()
		{
			if (ISet.cb_spliterator == null)
			{
				ISet.cb_spliterator = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISet.n_Spliterator));
			}
			return ISet.cb_spliterator;
		}

		// Token: 0x0600218C RID: 8588 RVA: 0x0005EA64 File Offset: 0x0005CC64
		private static IntPtr n_Spliterator(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Spliterator());
		}

		// Token: 0x0600218D RID: 8589 RVA: 0x0005EA78 File Offset: 0x0005CC78
		ISpliterator Spliterator()
		{
			return Java.Lang.Object.GetObject<ISpliterator>(ISet._members.InstanceMethods.InvokeVirtualObjectMethod("spliterator.()Ljava/util/Spliterator;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000DC7 RID: 3527
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/Set", typeof(ISet), true);

		// Token: 0x04000DC8 RID: 3528
		private static Delegate cb_spliterator;
	}
}
