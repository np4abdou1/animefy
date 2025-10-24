using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util;
using Kotlin.Jvm.Internal.Markers;

namespace Kotlin
{
	// Token: 0x020000AB RID: 171
	[NullableContext(2)]
	[Nullable(0)]
	[Register("kotlin/UIntArray", DoNotGenerateAcw = true)]
	public sealed class UIntArray : Java.Lang.Object, IKMappedMarker, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000126 RID: 294
		// (get) Token: 0x060004BE RID: 1214 RVA: 0x0000B624 File Offset: 0x00009824
		internal static IntPtr class_ref
		{
			get
			{
				return UIntArray._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x060004BF RID: 1215 RVA: 0x0000B648 File Offset: 0x00009848
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return UIntArray._members;
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x060004C0 RID: 1216 RVA: 0x0000B650 File Offset: 0x00009850
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return UIntArray._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x060004C1 RID: 1217 RVA: 0x0000B674 File Offset: 0x00009874
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return UIntArray._members.ManagedPeerType;
			}
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x0000B680 File Offset: 0x00009880
		internal UIntArray(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x060004C3 RID: 1219 RVA: 0x0000B68A File Offset: 0x0000988A
		public bool IsEmpty
		{
			[Register("isEmpty", "()Z", "")]
			get
			{
				return UIntArray._members.InstanceMethods.InvokeAbstractBooleanMethod("isEmpty.()Z", this, null);
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x060004C4 RID: 1220 RVA: 0x0000B6A3 File Offset: 0x000098A3
		public int Size
		{
			[Register("getSize", "()I", "")]
			get
			{
				return UIntArray._members.InstanceMethods.InvokeAbstractInt32Method("getSize.()I", this, null);
			}
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x0000B6BC File Offset: 0x000098BC
		[Register("add-WZ4Q5Ns", "(I)Z", "")]
		public unsafe bool Add(Java.Lang.Object element)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(element);
				result = UIntArray._members.InstanceMethods.InvokeNonvirtualBooleanMethod("add-WZ4Q5Ns.(I)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(element);
			}
			return result;
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x0000B714 File Offset: 0x00009914
		[Register("addAll", "(Ljava/util/Collection;)Z", "")]
		public unsafe bool AddAll(System.Collections.ICollection elements)
		{
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(elements);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = UIntArray._members.InstanceMethods.InvokeAbstractBooleanMethod("addAll.(Ljava/util/Collection;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(elements);
			}
			return result;
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x0000B778 File Offset: 0x00009978
		[Register("clear", "()V", "")]
		public void Clear()
		{
			UIntArray._members.InstanceMethods.InvokeAbstractVoidMethod("clear.()V", this, null);
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x0000B794 File Offset: 0x00009994
		[Register("contains", "(Ljava/lang/Object;)Z", "")]
		public unsafe bool Contains(Java.Lang.Object element)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((element == null) ? IntPtr.Zero : element.Handle);
				result = UIntArray._members.InstanceMethods.InvokeNonvirtualBooleanMethod("contains.(Ljava/lang/Object;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(element);
			}
			return result;
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x0000B7FC File Offset: 0x000099FC
		[Register("contains-WZ4Q5Ns", "([II)Z", "")]
		public unsafe static bool Contains(int[] arg0, uint element)
		{
			IntPtr intPtr = JNIEnv.NewArray(arg0);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(element);
				result = UIntArray._members.StaticMethods.InvokeBooleanMethod("contains-WZ4Q5Ns.([II)Z", ptr);
			}
			finally
			{
				if (arg0 != null)
				{
					JNIEnv.CopyArray(intPtr, arg0);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(arg0);
			}
			return result;
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x0000B87C File Offset: 0x00009A7C
		[Register("contains-WZ4Q5Ns", "(I)Z", "")]
		public unsafe bool Contains(uint element)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(element);
			return UIntArray._members.InstanceMethods.InvokeNonvirtualBooleanMethod("contains-WZ4Q5Ns.(I)Z", this, ptr);
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x0000B8B8 File Offset: 0x00009AB8
		[NullableContext(1)]
		[Register("containsAll", "(Ljava/util/Collection;)Z", "")]
		public unsafe bool ContainsAll(System.Collections.ICollection elements)
		{
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(elements);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = UIntArray._members.InstanceMethods.InvokeAbstractBooleanMethod("containsAll.(Ljava/util/Collection;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(elements);
			}
			return result;
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x0000B91C File Offset: 0x00009B1C
		[Register("get-pVg5ArA", "([II)I", "")]
		public unsafe static uint Get(int[] arg0, int index)
		{
			IntPtr intPtr = JNIEnv.NewArray(arg0);
			uint result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(index);
				result = (uint)UIntArray._members.StaticMethods.InvokeInt32Method("get-pVg5ArA.([II)I", ptr);
			}
			finally
			{
				if (arg0 != null)
				{
					JNIEnv.CopyArray(intPtr, arg0);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(arg0);
			}
			return result;
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x0000B99C File Offset: 0x00009B9C
		[NullableContext(1)]
		[Register("iterator", "()Ljava/util/Iterator;", "")]
		public IIterator Iterator()
		{
			return Java.Lang.Object.GetObject<IIterator>(UIntArray._members.InstanceMethods.InvokeAbstractObjectMethod("iterator.()Ljava/util/Iterator;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x0000B9D0 File Offset: 0x00009BD0
		[Register("remove", "(Ljava/lang/Object;)Z", "")]
		public unsafe bool Remove(Java.Lang.Object element)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((element == null) ? IntPtr.Zero : element.Handle);
				result = UIntArray._members.InstanceMethods.InvokeAbstractBooleanMethod("remove.(Ljava/lang/Object;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(element);
			}
			return result;
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x0000BA38 File Offset: 0x00009C38
		[Register("removeAll", "(Ljava/util/Collection;)Z", "")]
		public unsafe bool RemoveAll(System.Collections.ICollection elements)
		{
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(elements);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = UIntArray._members.InstanceMethods.InvokeAbstractBooleanMethod("removeAll.(Ljava/util/Collection;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(elements);
			}
			return result;
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x0000BA9C File Offset: 0x00009C9C
		[Register("retainAll", "(Ljava/util/Collection;)Z", "")]
		public unsafe bool RetainAll(System.Collections.ICollection elements)
		{
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(elements);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = UIntArray._members.InstanceMethods.InvokeAbstractBooleanMethod("retainAll.(Ljava/util/Collection;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(elements);
			}
			return result;
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x0000BB00 File Offset: 0x00009D00
		[Register("set-VXSXFK8", "([III)V", "")]
		public unsafe static void Set(int[] arg0, int index, uint value)
		{
			IntPtr intPtr = JNIEnv.NewArray(arg0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(index);
				ptr[2] = new JniArgumentValue(value);
				UIntArray._members.StaticMethods.InvokeVoidMethod("set-VXSXFK8.([III)V", ptr);
			}
			finally
			{
				if (arg0 != null)
				{
					JNIEnv.CopyArray(intPtr, arg0);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(arg0);
			}
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x0000BB94 File Offset: 0x00009D94
		[Register("toArray", "()[Ljava/lang/Object;", "")]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public Java.Lang.Object[] ToArray()
		{
			return (Java.Lang.Object[])JNIEnv.GetArray(UIntArray._members.InstanceMethods.InvokeAbstractObjectMethod("toArray.()[Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef, typeof(Java.Lang.Object));
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x0000BBD8 File Offset: 0x00009DD8
		[Register("toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public unsafe Java.Lang.Object[] ToArray([Nullable(new byte[]
		{
			2,
			1
		})] Java.Lang.Object[] array)
		{
			IntPtr intPtr = JNIEnv.NewArray<Java.Lang.Object>(array);
			Java.Lang.Object[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = (Java.Lang.Object[])JNIEnv.GetArray(UIntArray._members.InstanceMethods.InvokeAbstractObjectMethod("toArray.([Ljava/lang/Object;)[Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(Java.Lang.Object));
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

		// Token: 0x060004D4 RID: 1236 RVA: 0x0000BC64 File Offset: 0x00009E64
		[Register("size", "()I", "")]
		public int InvokeSize()
		{
			return UIntArray._members.InstanceMethods.InvokeNonvirtualInt32Method("size.()I", this, null);
		}

		// Token: 0x04000168 RID: 360
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/UIntArray", typeof(UIntArray));
	}
}
