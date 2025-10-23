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
	// Token: 0x020000B8 RID: 184
	[NullableContext(2)]
	[Nullable(0)]
	[Register("kotlin/UShortArray", DoNotGenerateAcw = true)]
	public sealed class UShortArray : Java.Lang.Object, IKMappedMarker, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000532 RID: 1330 RVA: 0x0000CBCC File Offset: 0x0000ADCC
		internal static IntPtr class_ref
		{
			get
			{
				return UShortArray._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000533 RID: 1331 RVA: 0x0000CBF0 File Offset: 0x0000ADF0
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return UShortArray._members;
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000534 RID: 1332 RVA: 0x0000CBF8 File Offset: 0x0000ADF8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return UShortArray._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000535 RID: 1333 RVA: 0x0000CC1C File Offset: 0x0000AE1C
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return UShortArray._members.ManagedPeerType;
			}
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x0000CC28 File Offset: 0x0000AE28
		internal UShortArray(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000537 RID: 1335 RVA: 0x0000CC32 File Offset: 0x0000AE32
		public bool IsEmpty
		{
			[Register("isEmpty", "()Z", "")]
			get
			{
				return UShortArray._members.InstanceMethods.InvokeAbstractBooleanMethod("isEmpty.()Z", this, null);
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000538 RID: 1336 RVA: 0x0000CC4B File Offset: 0x0000AE4B
		public int Size
		{
			[Register("getSize", "()I", "")]
			get
			{
				return UShortArray._members.InstanceMethods.InvokeAbstractInt32Method("getSize.()I", this, null);
			}
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x0000CC64 File Offset: 0x0000AE64
		[Register("add-xj2QHRw", "(S)Z", "")]
		public unsafe bool Add(Java.Lang.Object element)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(element);
				result = UShortArray._members.InstanceMethods.InvokeNonvirtualBooleanMethod("add-xj2QHRw.(S)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(element);
			}
			return result;
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x0000CCBC File Offset: 0x0000AEBC
		[Register("addAll", "(Ljava/util/Collection;)Z", "")]
		public unsafe bool AddAll(System.Collections.ICollection elements)
		{
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(elements);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = UShortArray._members.InstanceMethods.InvokeAbstractBooleanMethod("addAll.(Ljava/util/Collection;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(elements);
			}
			return result;
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x0000CD20 File Offset: 0x0000AF20
		[Register("clear", "()V", "")]
		public void Clear()
		{
			UShortArray._members.InstanceMethods.InvokeAbstractVoidMethod("clear.()V", this, null);
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x0000CD3C File Offset: 0x0000AF3C
		[Register("contains", "(Ljava/lang/Object;)Z", "")]
		public unsafe bool Contains(Java.Lang.Object element)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((element == null) ? IntPtr.Zero : element.Handle);
				result = UShortArray._members.InstanceMethods.InvokeNonvirtualBooleanMethod("contains.(Ljava/lang/Object;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(element);
			}
			return result;
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x0000CDA4 File Offset: 0x0000AFA4
		[Register("contains-xj2QHRw", "([SS)Z", "")]
		public unsafe static bool Contains(short[] arg0, ushort element)
		{
			IntPtr intPtr = JNIEnv.NewArray(arg0);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(element);
				result = UShortArray._members.StaticMethods.InvokeBooleanMethod("contains-xj2QHRw.([SS)Z", ptr);
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

		// Token: 0x0600053E RID: 1342 RVA: 0x0000CE24 File Offset: 0x0000B024
		[Register("contains-xj2QHRw", "(S)Z", "")]
		public unsafe bool Contains(ushort element)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(element);
			return UShortArray._members.InstanceMethods.InvokeNonvirtualBooleanMethod("contains-xj2QHRw.(S)Z", this, ptr);
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x0000CE60 File Offset: 0x0000B060
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
				result = UShortArray._members.InstanceMethods.InvokeAbstractBooleanMethod("containsAll.(Ljava/util/Collection;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(elements);
			}
			return result;
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x0000CEC4 File Offset: 0x0000B0C4
		[Register("get-Mh2AYeg", "([SI)S", "")]
		public unsafe static ushort Get(short[] arg0, int index)
		{
			IntPtr intPtr = JNIEnv.NewArray(arg0);
			ushort result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(index);
				result = (ushort)UShortArray._members.StaticMethods.InvokeInt16Method("get-Mh2AYeg.([SI)S", ptr);
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

		// Token: 0x06000541 RID: 1345 RVA: 0x0000CF44 File Offset: 0x0000B144
		[NullableContext(1)]
		[Register("iterator", "()Ljava/util/Iterator;", "")]
		public IIterator Iterator()
		{
			return Java.Lang.Object.GetObject<IIterator>(UShortArray._members.InstanceMethods.InvokeAbstractObjectMethod("iterator.()Ljava/util/Iterator;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x0000CF78 File Offset: 0x0000B178
		[Register("remove", "(Ljava/lang/Object;)Z", "")]
		public unsafe bool Remove(Java.Lang.Object element)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((element == null) ? IntPtr.Zero : element.Handle);
				result = UShortArray._members.InstanceMethods.InvokeAbstractBooleanMethod("remove.(Ljava/lang/Object;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(element);
			}
			return result;
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x0000CFE0 File Offset: 0x0000B1E0
		[Register("removeAll", "(Ljava/util/Collection;)Z", "")]
		public unsafe bool RemoveAll(System.Collections.ICollection elements)
		{
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(elements);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = UShortArray._members.InstanceMethods.InvokeAbstractBooleanMethod("removeAll.(Ljava/util/Collection;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(elements);
			}
			return result;
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x0000D044 File Offset: 0x0000B244
		[Register("retainAll", "(Ljava/util/Collection;)Z", "")]
		public unsafe bool RetainAll(System.Collections.ICollection elements)
		{
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(elements);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = UShortArray._members.InstanceMethods.InvokeAbstractBooleanMethod("retainAll.(Ljava/util/Collection;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(elements);
			}
			return result;
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x0000D0A8 File Offset: 0x0000B2A8
		[Register("set-01HTLdE", "([SIS)V", "")]
		public unsafe static void Set(short[] arg0, int index, ushort value)
		{
			IntPtr intPtr = JNIEnv.NewArray(arg0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(index);
				ptr[2] = new JniArgumentValue(value);
				UShortArray._members.StaticMethods.InvokeVoidMethod("set-01HTLdE.([SIS)V", ptr);
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

		// Token: 0x06000546 RID: 1350 RVA: 0x0000D13C File Offset: 0x0000B33C
		[Register("toArray", "()[Ljava/lang/Object;", "")]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public Java.Lang.Object[] ToArray()
		{
			return (Java.Lang.Object[])JNIEnv.GetArray(UShortArray._members.InstanceMethods.InvokeAbstractObjectMethod("toArray.()[Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef, typeof(Java.Lang.Object));
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x0000D180 File Offset: 0x0000B380
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
				result = (Java.Lang.Object[])JNIEnv.GetArray(UShortArray._members.InstanceMethods.InvokeAbstractObjectMethod("toArray.([Ljava/lang/Object;)[Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(Java.Lang.Object));
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

		// Token: 0x06000548 RID: 1352 RVA: 0x0000D20C File Offset: 0x0000B40C
		[Register("size", "()I", "")]
		public int InvokeSize()
		{
			return UShortArray._members.InstanceMethods.InvokeNonvirtualInt32Method("size.()I", this, null);
		}

		// Token: 0x0400017C RID: 380
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/UShortArray", typeof(UShortArray));
	}
}
