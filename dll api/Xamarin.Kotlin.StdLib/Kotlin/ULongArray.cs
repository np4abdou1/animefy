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
	// Token: 0x020000AF RID: 175
	[NullableContext(2)]
	[Nullable(0)]
	[Register("kotlin/ULongArray", DoNotGenerateAcw = true)]
	public sealed class ULongArray : Java.Lang.Object, IKMappedMarker, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000138 RID: 312
		// (get) Token: 0x060004E9 RID: 1257 RVA: 0x0000BE8C File Offset: 0x0000A08C
		internal static IntPtr class_ref
		{
			get
			{
				return ULongArray._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x060004EA RID: 1258 RVA: 0x0000BEB0 File Offset: 0x0000A0B0
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return ULongArray._members;
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x060004EB RID: 1259 RVA: 0x0000BEB8 File Offset: 0x0000A0B8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ULongArray._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x060004EC RID: 1260 RVA: 0x0000BEDC File Offset: 0x0000A0DC
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return ULongArray._members.ManagedPeerType;
			}
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x0000BEE8 File Offset: 0x0000A0E8
		internal ULongArray(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x060004EE RID: 1262 RVA: 0x0000BEF2 File Offset: 0x0000A0F2
		public bool IsEmpty
		{
			[Register("isEmpty", "()Z", "")]
			get
			{
				return ULongArray._members.InstanceMethods.InvokeAbstractBooleanMethod("isEmpty.()Z", this, null);
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x060004EF RID: 1263 RVA: 0x0000BF0B File Offset: 0x0000A10B
		public int Size
		{
			[Register("getSize", "()I", "")]
			get
			{
				return ULongArray._members.InstanceMethods.InvokeAbstractInt32Method("getSize.()I", this, null);
			}
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x0000BF24 File Offset: 0x0000A124
		[Register("add-VKZWuLQ", "(J)Z", "")]
		public unsafe bool Add(Java.Lang.Object element)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(element);
				result = ULongArray._members.InstanceMethods.InvokeNonvirtualBooleanMethod("add-VKZWuLQ.(J)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(element);
			}
			return result;
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x0000BF7C File Offset: 0x0000A17C
		[Register("addAll", "(Ljava/util/Collection;)Z", "")]
		public unsafe bool AddAll(System.Collections.ICollection elements)
		{
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(elements);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = ULongArray._members.InstanceMethods.InvokeAbstractBooleanMethod("addAll.(Ljava/util/Collection;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(elements);
			}
			return result;
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x0000BFE0 File Offset: 0x0000A1E0
		[Register("clear", "()V", "")]
		public void Clear()
		{
			ULongArray._members.InstanceMethods.InvokeAbstractVoidMethod("clear.()V", this, null);
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x0000BFFC File Offset: 0x0000A1FC
		[Register("contains", "(Ljava/lang/Object;)Z", "")]
		public unsafe bool Contains(Java.Lang.Object element)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((element == null) ? IntPtr.Zero : element.Handle);
				result = ULongArray._members.InstanceMethods.InvokeNonvirtualBooleanMethod("contains.(Ljava/lang/Object;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(element);
			}
			return result;
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x0000C064 File Offset: 0x0000A264
		[Register("contains-VKZWuLQ", "([JJ)Z", "")]
		public unsafe static bool Contains(long[] arg0, ulong element)
		{
			IntPtr intPtr = JNIEnv.NewArray(arg0);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(element);
				result = ULongArray._members.StaticMethods.InvokeBooleanMethod("contains-VKZWuLQ.([JJ)Z", ptr);
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

		// Token: 0x060004F5 RID: 1269 RVA: 0x0000C0E4 File Offset: 0x0000A2E4
		[Register("contains-VKZWuLQ", "(J)Z", "")]
		public unsafe bool Contains(ulong element)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(element);
			return ULongArray._members.InstanceMethods.InvokeNonvirtualBooleanMethod("contains-VKZWuLQ.(J)Z", this, ptr);
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x0000C120 File Offset: 0x0000A320
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
				result = ULongArray._members.InstanceMethods.InvokeAbstractBooleanMethod("containsAll.(Ljava/util/Collection;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(elements);
			}
			return result;
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x0000C184 File Offset: 0x0000A384
		[Register("get-s-VKNKU", "([JI)J", "")]
		public unsafe static ulong Get(long[] arg0, int index)
		{
			IntPtr intPtr = JNIEnv.NewArray(arg0);
			ulong result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(index);
				result = (ulong)ULongArray._members.StaticMethods.InvokeInt64Method("get-s-VKNKU.([JI)J", ptr);
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

		// Token: 0x060004F8 RID: 1272 RVA: 0x0000C204 File Offset: 0x0000A404
		[NullableContext(1)]
		[Register("iterator", "()Ljava/util/Iterator;", "")]
		public IIterator Iterator()
		{
			return Java.Lang.Object.GetObject<IIterator>(ULongArray._members.InstanceMethods.InvokeAbstractObjectMethod("iterator.()Ljava/util/Iterator;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x0000C238 File Offset: 0x0000A438
		[Register("remove", "(Ljava/lang/Object;)Z", "")]
		public unsafe bool Remove(Java.Lang.Object element)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((element == null) ? IntPtr.Zero : element.Handle);
				result = ULongArray._members.InstanceMethods.InvokeAbstractBooleanMethod("remove.(Ljava/lang/Object;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(element);
			}
			return result;
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x0000C2A0 File Offset: 0x0000A4A0
		[Register("removeAll", "(Ljava/util/Collection;)Z", "")]
		public unsafe bool RemoveAll(System.Collections.ICollection elements)
		{
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(elements);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = ULongArray._members.InstanceMethods.InvokeAbstractBooleanMethod("removeAll.(Ljava/util/Collection;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(elements);
			}
			return result;
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x0000C304 File Offset: 0x0000A504
		[Register("retainAll", "(Ljava/util/Collection;)Z", "")]
		public unsafe bool RetainAll(System.Collections.ICollection elements)
		{
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(elements);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = ULongArray._members.InstanceMethods.InvokeAbstractBooleanMethod("retainAll.(Ljava/util/Collection;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(elements);
			}
			return result;
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x0000C368 File Offset: 0x0000A568
		[Register("set-k8EXiF4", "([JIJ)V", "")]
		public unsafe static void Set(long[] arg0, int index, ulong value)
		{
			IntPtr intPtr = JNIEnv.NewArray(arg0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(index);
				ptr[2] = new JniArgumentValue(value);
				ULongArray._members.StaticMethods.InvokeVoidMethod("set-k8EXiF4.([JIJ)V", ptr);
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

		// Token: 0x060004FD RID: 1277 RVA: 0x0000C3FC File Offset: 0x0000A5FC
		[Register("toArray", "()[Ljava/lang/Object;", "")]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public Java.Lang.Object[] ToArray()
		{
			return (Java.Lang.Object[])JNIEnv.GetArray(ULongArray._members.InstanceMethods.InvokeAbstractObjectMethod("toArray.()[Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef, typeof(Java.Lang.Object));
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x0000C440 File Offset: 0x0000A640
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
				result = (Java.Lang.Object[])JNIEnv.GetArray(ULongArray._members.InstanceMethods.InvokeAbstractObjectMethod("toArray.([Ljava/lang/Object;)[Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(Java.Lang.Object));
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

		// Token: 0x060004FF RID: 1279 RVA: 0x0000C4CC File Offset: 0x0000A6CC
		[Register("size", "()I", "")]
		public int InvokeSize()
		{
			return ULongArray._members.InstanceMethods.InvokeNonvirtualInt32Method("size.()I", this, null);
		}

		// Token: 0x04000170 RID: 368
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/ULongArray", typeof(ULongArray));
	}
}
