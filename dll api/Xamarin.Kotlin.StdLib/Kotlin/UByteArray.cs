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
	// Token: 0x020000A7 RID: 167
	[NullableContext(2)]
	[Nullable(0)]
	[Register("kotlin/UByteArray", DoNotGenerateAcw = true)]
	public sealed class UByteArray : Java.Lang.Object, IKMappedMarker, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000493 RID: 1171 RVA: 0x0000ADBC File Offset: 0x00008FBC
		internal static IntPtr class_ref
		{
			get
			{
				return UByteArray._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000494 RID: 1172 RVA: 0x0000ADE0 File Offset: 0x00008FE0
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return UByteArray._members;
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000495 RID: 1173 RVA: 0x0000ADE8 File Offset: 0x00008FE8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return UByteArray._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000496 RID: 1174 RVA: 0x0000AE0C File Offset: 0x0000900C
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return UByteArray._members.ManagedPeerType;
			}
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x0000AE18 File Offset: 0x00009018
		internal UByteArray(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000498 RID: 1176 RVA: 0x0000AE22 File Offset: 0x00009022
		public bool IsEmpty
		{
			[Register("isEmpty", "()Z", "")]
			get
			{
				return UByteArray._members.InstanceMethods.InvokeAbstractBooleanMethod("isEmpty.()Z", this, null);
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000499 RID: 1177 RVA: 0x0000AE3B File Offset: 0x0000903B
		public int Size
		{
			[Register("getSize", "()I", "")]
			get
			{
				return UByteArray._members.InstanceMethods.InvokeAbstractInt32Method("getSize.()I", this, null);
			}
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x0000AE54 File Offset: 0x00009054
		[Register("add-7apg3OU", "(B)Z", "")]
		public unsafe bool Add(Java.Lang.Object element)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(element);
				result = UByteArray._members.InstanceMethods.InvokeNonvirtualBooleanMethod("add-7apg3OU.(B)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(element);
			}
			return result;
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x0000AEAC File Offset: 0x000090AC
		[Register("addAll", "(Ljava/util/Collection;)Z", "")]
		public unsafe bool AddAll(System.Collections.ICollection elements)
		{
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(elements);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = UByteArray._members.InstanceMethods.InvokeAbstractBooleanMethod("addAll.(Ljava/util/Collection;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(elements);
			}
			return result;
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x0000AF10 File Offset: 0x00009110
		[Register("clear", "()V", "")]
		public void Clear()
		{
			UByteArray._members.InstanceMethods.InvokeAbstractVoidMethod("clear.()V", this, null);
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x0000AF2C File Offset: 0x0000912C
		[Register("contains", "(Ljava/lang/Object;)Z", "")]
		public unsafe bool Contains(Java.Lang.Object element)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((element == null) ? IntPtr.Zero : element.Handle);
				result = UByteArray._members.InstanceMethods.InvokeNonvirtualBooleanMethod("contains.(Ljava/lang/Object;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(element);
			}
			return result;
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x0000AF94 File Offset: 0x00009194
		[Register("contains-7apg3OU", "([BB)Z", "")]
		public unsafe static bool Contains(byte[] arg0, byte element)
		{
			IntPtr intPtr = JNIEnv.NewArray(arg0);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(element);
				result = UByteArray._members.StaticMethods.InvokeBooleanMethod("contains-7apg3OU.([BB)Z", ptr);
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

		// Token: 0x0600049F RID: 1183 RVA: 0x0000B014 File Offset: 0x00009214
		[Register("contains-7apg3OU", "(B)Z", "")]
		public unsafe bool Contains(byte element)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(element);
			return UByteArray._members.InstanceMethods.InvokeNonvirtualBooleanMethod("contains-7apg3OU.(B)Z", this, ptr);
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x0000B050 File Offset: 0x00009250
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
				result = UByteArray._members.InstanceMethods.InvokeAbstractBooleanMethod("containsAll.(Ljava/util/Collection;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(elements);
			}
			return result;
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x0000B0B4 File Offset: 0x000092B4
		[Register("get-w2LRezQ", "([BI)B", "")]
		public unsafe static byte Get(byte[] arg0, int index)
		{
			IntPtr intPtr = JNIEnv.NewArray(arg0);
			byte result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(index);
				result = (byte)UByteArray._members.StaticMethods.InvokeSByteMethod("get-w2LRezQ.([BI)B", ptr);
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

		// Token: 0x060004A2 RID: 1186 RVA: 0x0000B134 File Offset: 0x00009334
		[NullableContext(1)]
		[Register("iterator", "()Ljava/util/Iterator;", "")]
		public IIterator Iterator()
		{
			return Java.Lang.Object.GetObject<IIterator>(UByteArray._members.InstanceMethods.InvokeAbstractObjectMethod("iterator.()Ljava/util/Iterator;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x0000B168 File Offset: 0x00009368
		[Register("remove", "(Ljava/lang/Object;)Z", "")]
		public unsafe bool Remove(Java.Lang.Object element)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((element == null) ? IntPtr.Zero : element.Handle);
				result = UByteArray._members.InstanceMethods.InvokeAbstractBooleanMethod("remove.(Ljava/lang/Object;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(element);
			}
			return result;
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x0000B1D0 File Offset: 0x000093D0
		[Register("removeAll", "(Ljava/util/Collection;)Z", "")]
		public unsafe bool RemoveAll(System.Collections.ICollection elements)
		{
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(elements);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = UByteArray._members.InstanceMethods.InvokeAbstractBooleanMethod("removeAll.(Ljava/util/Collection;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(elements);
			}
			return result;
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x0000B234 File Offset: 0x00009434
		[Register("retainAll", "(Ljava/util/Collection;)Z", "")]
		public unsafe bool RetainAll(System.Collections.ICollection elements)
		{
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(elements);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = UByteArray._members.InstanceMethods.InvokeAbstractBooleanMethod("retainAll.(Ljava/util/Collection;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(elements);
			}
			return result;
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x0000B298 File Offset: 0x00009498
		[Register("set-VurrAj0", "([BIB)V", "")]
		public unsafe static void Set(byte[] arg0, int index, byte value)
		{
			IntPtr intPtr = JNIEnv.NewArray(arg0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(index);
				ptr[2] = new JniArgumentValue(value);
				UByteArray._members.StaticMethods.InvokeVoidMethod("set-VurrAj0.([BIB)V", ptr);
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

		// Token: 0x060004A7 RID: 1191 RVA: 0x0000B32C File Offset: 0x0000952C
		[Register("toArray", "()[Ljava/lang/Object;", "")]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public Java.Lang.Object[] ToArray()
		{
			return (Java.Lang.Object[])JNIEnv.GetArray(UByteArray._members.InstanceMethods.InvokeAbstractObjectMethod("toArray.()[Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef, typeof(Java.Lang.Object));
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x0000B370 File Offset: 0x00009570
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
				result = (Java.Lang.Object[])JNIEnv.GetArray(UByteArray._members.InstanceMethods.InvokeAbstractObjectMethod("toArray.([Ljava/lang/Object;)[Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(Java.Lang.Object));
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

		// Token: 0x060004A9 RID: 1193 RVA: 0x0000B3FC File Offset: 0x000095FC
		[Register("size", "()I", "")]
		public int InvokeSize()
		{
			return UByteArray._members.InstanceMethods.InvokeNonvirtualInt32Method("size.()I", this, null);
		}

		// Token: 0x04000160 RID: 352
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/UByteArray", typeof(UByteArray));
	}
}
