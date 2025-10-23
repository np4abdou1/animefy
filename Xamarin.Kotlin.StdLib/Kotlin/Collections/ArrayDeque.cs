using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Collections
{
	// Token: 0x020002BB RID: 699
	[NullableContext(2)]
	[Nullable(0)]
	[Register("kotlin/collections/ArrayDeque", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"E"
	})]
	public sealed class ArrayDeque : AbstractMutableList
	{
		// Token: 0x17000978 RID: 2424
		// (get) Token: 0x06002093 RID: 8339 RVA: 0x0006C43C File Offset: 0x0006A63C
		internal new static IntPtr class_ref
		{
			get
			{
				return ArrayDeque._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000979 RID: 2425
		// (get) Token: 0x06002094 RID: 8340 RVA: 0x0006C460 File Offset: 0x0006A660
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return ArrayDeque._members;
			}
		}

		// Token: 0x1700097A RID: 2426
		// (get) Token: 0x06002095 RID: 8341 RVA: 0x0006C468 File Offset: 0x0006A668
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ArrayDeque._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700097B RID: 2427
		// (get) Token: 0x06002096 RID: 8342 RVA: 0x0006C48C File Offset: 0x0006A68C
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return ArrayDeque._members.ManagedPeerType;
			}
		}

		// Token: 0x06002097 RID: 8343 RVA: 0x0006C498 File Offset: 0x0006A698
		internal ArrayDeque(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06002098 RID: 8344 RVA: 0x0006C4A4 File Offset: 0x0006A6A4
		[Register(".ctor", "()V", "")]
		public ArrayDeque() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(ArrayDeque._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			ArrayDeque._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06002099 RID: 8345 RVA: 0x0006C514 File Offset: 0x0006A714
		[Register(".ctor", "(I)V", "")]
		public unsafe ArrayDeque(int initialCapacity) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(initialCapacity);
			base.SetHandle(ArrayDeque._members.InstanceMethods.StartCreateInstance("(I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			ArrayDeque._members.InstanceMethods.FinishCreateInstance("(I)V", this, ptr);
		}

		// Token: 0x0600209A RID: 8346 RVA: 0x0006C598 File Offset: 0x0006A798
		[NullableContext(1)]
		[Register(".ctor", "(Ljava/util/Collection;)V", "")]
		public unsafe ArrayDeque(ICollection elements) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(elements);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				base.SetHandle(ArrayDeque._members.InstanceMethods.StartCreateInstance("(Ljava/util/Collection;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ArrayDeque._members.InstanceMethods.FinishCreateInstance("(Ljava/util/Collection;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(elements);
			}
		}

		// Token: 0x0600209B RID: 8347 RVA: 0x0006C644 File Offset: 0x0006A844
		[Register("add", "(Ljava/lang/Object;)Z", "")]
		public unsafe override bool Add(Java.Lang.Object element)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(element);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = ArrayDeque._members.InstanceMethods.InvokeAbstractBooleanMethod("add.(Ljava/lang/Object;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(element);
			}
			return result;
		}

		// Token: 0x0600209C RID: 8348 RVA: 0x0006C6A8 File Offset: 0x0006A8A8
		[Register("add", "(ILjava/lang/Object;)V", "")]
		public unsafe override void Add(int index, Java.Lang.Object element)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(element);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(index);
				ptr[1] = new JniArgumentValue(intPtr);
				ArrayDeque._members.InstanceMethods.InvokeAbstractVoidMethod("add.(ILjava/lang/Object;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(element);
			}
		}

		// Token: 0x0600209D RID: 8349 RVA: 0x0006C71C File Offset: 0x0006A91C
		[NullableContext(1)]
		[Register("addAll", "(ILjava/util/Collection;)Z", "")]
		public unsafe override bool AddAll(int index, ICollection elements)
		{
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(elements);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(index);
				ptr[1] = new JniArgumentValue(intPtr);
				result = ArrayDeque._members.InstanceMethods.InvokeAbstractBooleanMethod("addAll.(ILjava/util/Collection;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(elements);
			}
			return result;
		}

		// Token: 0x0600209E RID: 8350 RVA: 0x0006C794 File Offset: 0x0006A994
		[NullableContext(1)]
		[Register("addAll", "(Ljava/util/Collection;)Z", "")]
		public unsafe override bool AddAll(ICollection elements)
		{
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(elements);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = ArrayDeque._members.InstanceMethods.InvokeAbstractBooleanMethod("addAll.(Ljava/util/Collection;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(elements);
			}
			return result;
		}

		// Token: 0x0600209F RID: 8351 RVA: 0x0006C7F8 File Offset: 0x0006A9F8
		[Register("addFirst", "(Ljava/lang/Object;)V", "")]
		public unsafe void AddFirst(Java.Lang.Object element)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(element);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ArrayDeque._members.InstanceMethods.InvokeNonvirtualVoidMethod("addFirst.(Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(element);
			}
		}

		// Token: 0x060020A0 RID: 8352 RVA: 0x0006C85C File Offset: 0x0006AA5C
		[Register("addLast", "(Ljava/lang/Object;)V", "")]
		public unsafe void AddLast(Java.Lang.Object element)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(element);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ArrayDeque._members.InstanceMethods.InvokeNonvirtualVoidMethod("addLast.(Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(element);
			}
		}

		// Token: 0x060020A1 RID: 8353 RVA: 0x0006C8C0 File Offset: 0x0006AAC0
		[Register("first", "()Ljava/lang/Object;", "")]
		public Java.Lang.Object First()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(ArrayDeque._members.InstanceMethods.InvokeNonvirtualObjectMethod("first.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060020A2 RID: 8354 RVA: 0x0006C8F4 File Offset: 0x0006AAF4
		[Register("firstOrNull", "()Ljava/lang/Object;", "")]
		public Java.Lang.Object FirstOrNull()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(ArrayDeque._members.InstanceMethods.InvokeNonvirtualObjectMethod("firstOrNull.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060020A3 RID: 8355 RVA: 0x0006C928 File Offset: 0x0006AB28
		[Register("get", "(I)Ljava/lang/Object;", "")]
		public unsafe override Java.Lang.Object Get(int index)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(index);
			return Java.Lang.Object.GetObject<Java.Lang.Object>(ArrayDeque._members.InstanceMethods.InvokeAbstractObjectMethod("get.(I)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060020A4 RID: 8356 RVA: 0x0006C971 File Offset: 0x0006AB71
		[Register("getSize", "()I", "")]
		public override int GetSize()
		{
			return ArrayDeque._members.InstanceMethods.InvokeAbstractInt32Method("getSize.()I", this, null);
		}

		// Token: 0x060020A5 RID: 8357 RVA: 0x0006C98C File Offset: 0x0006AB8C
		[Register("last", "()Ljava/lang/Object;", "")]
		public Java.Lang.Object Last()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(ArrayDeque._members.InstanceMethods.InvokeNonvirtualObjectMethod("last.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060020A6 RID: 8358 RVA: 0x0006C9C0 File Offset: 0x0006ABC0
		[Register("lastOrNull", "()Ljava/lang/Object;", "")]
		public Java.Lang.Object LastOrNull()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(ArrayDeque._members.InstanceMethods.InvokeNonvirtualObjectMethod("lastOrNull.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060020A7 RID: 8359 RVA: 0x0006C9F4 File Offset: 0x0006ABF4
		[NullableContext(1)]
		[Register("removeAll", "(Ljava/util/Collection;)Z", "")]
		public unsafe bool RemoveAll(ICollection<Java.Lang.Object> elements)
		{
			IntPtr intPtr = JavaCollection<Java.Lang.Object>.ToLocalJniHandle(elements);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = ArrayDeque._members.InstanceMethods.InvokeAbstractBooleanMethod("removeAll.(Ljava/util/Collection;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(elements);
			}
			return result;
		}

		// Token: 0x060020A8 RID: 8360 RVA: 0x0006CA58 File Offset: 0x0006AC58
		[Register("removeAt", "(I)Ljava/lang/Object;", "")]
		public unsafe override Java.Lang.Object RemoveAt(int index)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(index);
			return Java.Lang.Object.GetObject<Java.Lang.Object>(ArrayDeque._members.InstanceMethods.InvokeAbstractObjectMethod("removeAt.(I)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060020A9 RID: 8361 RVA: 0x0006CAA4 File Offset: 0x0006ACA4
		[Register("removeFirst", "()Ljava/lang/Object;", "")]
		public Java.Lang.Object RemoveFirst()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(ArrayDeque._members.InstanceMethods.InvokeNonvirtualObjectMethod("removeFirst.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060020AA RID: 8362 RVA: 0x0006CAD8 File Offset: 0x0006ACD8
		[Register("removeFirstOrNull", "()Ljava/lang/Object;", "")]
		public Java.Lang.Object RemoveFirstOrNull()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(ArrayDeque._members.InstanceMethods.InvokeNonvirtualObjectMethod("removeFirstOrNull.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060020AB RID: 8363 RVA: 0x0006CB0C File Offset: 0x0006AD0C
		[Register("removeLast", "()Ljava/lang/Object;", "")]
		public Java.Lang.Object RemoveLast()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(ArrayDeque._members.InstanceMethods.InvokeNonvirtualObjectMethod("removeLast.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060020AC RID: 8364 RVA: 0x0006CB40 File Offset: 0x0006AD40
		[Register("removeLastOrNull", "()Ljava/lang/Object;", "")]
		public Java.Lang.Object RemoveLastOrNull()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(ArrayDeque._members.InstanceMethods.InvokeNonvirtualObjectMethod("removeLastOrNull.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060020AD RID: 8365 RVA: 0x0006CB74 File Offset: 0x0006AD74
		[NullableContext(1)]
		[Register("retainAll", "(Ljava/util/Collection;)Z", "")]
		public unsafe bool RetainAll(ICollection<Java.Lang.Object> elements)
		{
			IntPtr intPtr = JavaCollection<Java.Lang.Object>.ToLocalJniHandle(elements);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = ArrayDeque._members.InstanceMethods.InvokeAbstractBooleanMethod("retainAll.(Ljava/util/Collection;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(elements);
			}
			return result;
		}

		// Token: 0x060020AE RID: 8366 RVA: 0x0006CBD8 File Offset: 0x0006ADD8
		[Register("set", "(ILjava/lang/Object;)Ljava/lang/Object;", "")]
		public unsafe override Java.Lang.Object Set(int index, Java.Lang.Object element)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(element);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(index);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(ArrayDeque._members.InstanceMethods.InvokeAbstractObjectMethod("set.(ILjava/lang/Object;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(element);
			}
			return @object;
		}

		// Token: 0x060020AF RID: 8367 RVA: 0x0006CC5C File Offset: 0x0006AE5C
		[NullableContext(1)]
		[Register("toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe override Java.Lang.Object[] ToArray(Java.Lang.Object[] array)
		{
			IntPtr intPtr = JNIEnv.NewArray<Java.Lang.Object>(array);
			Java.Lang.Object[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = (Java.Lang.Object[])JNIEnv.GetArray(ArrayDeque._members.InstanceMethods.InvokeAbstractObjectMethod("toArray.([Ljava/lang/Object;)[Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(Java.Lang.Object));
			}
			finally
			{
				if (array != null)
				{
					JNIEnv.CopyArray<Java.Lang.Object>(intPtr, array);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(array);
			}
			return result;
		}

		// Token: 0x0400098D RID: 2445
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/collections/ArrayDeque", typeof(ArrayDeque));
	}
}
