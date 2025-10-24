using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Collections;

namespace Kotlin.Jvm.Internal
{
	// Token: 0x02000190 RID: 400
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/jvm/internal/ArrayIteratorsKt", DoNotGenerateAcw = true)]
	public sealed class ArrayIteratorsKt : Java.Lang.Object
	{
		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x06001390 RID: 5008 RVA: 0x0003F984 File Offset: 0x0003DB84
		internal static IntPtr class_ref
		{
			get
			{
				return ArrayIteratorsKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x06001391 RID: 5009 RVA: 0x0003F9A8 File Offset: 0x0003DBA8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ArrayIteratorsKt._members;
			}
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x06001392 RID: 5010 RVA: 0x0003F9B0 File Offset: 0x0003DBB0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ArrayIteratorsKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x06001393 RID: 5011 RVA: 0x0003F9D4 File Offset: 0x0003DBD4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ArrayIteratorsKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06001394 RID: 5012 RVA: 0x0003F9E0 File Offset: 0x0003DBE0
		internal ArrayIteratorsKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001395 RID: 5013 RVA: 0x0003F9EC File Offset: 0x0003DBEC
		[Register("iterator", "([Z)Lkotlin/collections/BooleanIterator;", "")]
		public unsafe static BooleanIterator Iterator(bool[] array)
		{
			IntPtr intPtr = JNIEnv.NewArray(array);
			BooleanIterator @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<BooleanIterator>(ArrayIteratorsKt._members.StaticMethods.InvokeObjectMethod("iterator.([Z)Lkotlin/collections/BooleanIterator;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (array != null)
				{
					JNIEnv.CopyArray(intPtr, array);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(array);
			}
			return @object;
		}

		// Token: 0x06001396 RID: 5014 RVA: 0x0003FA68 File Offset: 0x0003DC68
		[Register("iterator", "([B)Lkotlin/collections/ByteIterator;", "")]
		public unsafe static ByteIterator Iterator(byte[] array)
		{
			IntPtr intPtr = JNIEnv.NewArray(array);
			ByteIterator @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<ByteIterator>(ArrayIteratorsKt._members.StaticMethods.InvokeObjectMethod("iterator.([B)Lkotlin/collections/ByteIterator;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (array != null)
				{
					JNIEnv.CopyArray(intPtr, array);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(array);
			}
			return @object;
		}

		// Token: 0x06001397 RID: 5015 RVA: 0x0003FAE4 File Offset: 0x0003DCE4
		[Register("iterator", "([C)Lkotlin/collections/CharIterator;", "")]
		public unsafe static CharIterator Iterator(char[] array)
		{
			IntPtr intPtr = JNIEnv.NewArray(array);
			CharIterator @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<CharIterator>(ArrayIteratorsKt._members.StaticMethods.InvokeObjectMethod("iterator.([C)Lkotlin/collections/CharIterator;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (array != null)
				{
					JNIEnv.CopyArray(intPtr, array);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(array);
			}
			return @object;
		}

		// Token: 0x06001398 RID: 5016 RVA: 0x0003FB60 File Offset: 0x0003DD60
		[Register("iterator", "([D)Lkotlin/collections/DoubleIterator;", "")]
		public unsafe static DoubleIterator Iterator(double[] array)
		{
			IntPtr intPtr = JNIEnv.NewArray(array);
			DoubleIterator @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<DoubleIterator>(ArrayIteratorsKt._members.StaticMethods.InvokeObjectMethod("iterator.([D)Lkotlin/collections/DoubleIterator;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (array != null)
				{
					JNIEnv.CopyArray(intPtr, array);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(array);
			}
			return @object;
		}

		// Token: 0x06001399 RID: 5017 RVA: 0x0003FBDC File Offset: 0x0003DDDC
		[Register("iterator", "([F)Lkotlin/collections/FloatIterator;", "")]
		public unsafe static FloatIterator Iterator(float[] array)
		{
			IntPtr intPtr = JNIEnv.NewArray(array);
			FloatIterator @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<FloatIterator>(ArrayIteratorsKt._members.StaticMethods.InvokeObjectMethod("iterator.([F)Lkotlin/collections/FloatIterator;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (array != null)
				{
					JNIEnv.CopyArray(intPtr, array);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(array);
			}
			return @object;
		}

		// Token: 0x0600139A RID: 5018 RVA: 0x0003FC58 File Offset: 0x0003DE58
		[Register("iterator", "([I)Lkotlin/collections/IntIterator;", "")]
		public unsafe static IntIterator Iterator(int[] array)
		{
			IntPtr intPtr = JNIEnv.NewArray(array);
			IntIterator @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<IntIterator>(ArrayIteratorsKt._members.StaticMethods.InvokeObjectMethod("iterator.([I)Lkotlin/collections/IntIterator;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (array != null)
				{
					JNIEnv.CopyArray(intPtr, array);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(array);
			}
			return @object;
		}

		// Token: 0x0600139B RID: 5019 RVA: 0x0003FCD4 File Offset: 0x0003DED4
		[Register("iterator", "([J)Lkotlin/collections/LongIterator;", "")]
		public unsafe static LongIterator Iterator(long[] array)
		{
			IntPtr intPtr = JNIEnv.NewArray(array);
			LongIterator @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<LongIterator>(ArrayIteratorsKt._members.StaticMethods.InvokeObjectMethod("iterator.([J)Lkotlin/collections/LongIterator;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (array != null)
				{
					JNIEnv.CopyArray(intPtr, array);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(array);
			}
			return @object;
		}

		// Token: 0x0600139C RID: 5020 RVA: 0x0003FD50 File Offset: 0x0003DF50
		[Register("iterator", "([S)Lkotlin/collections/ShortIterator;", "")]
		public unsafe static ShortIterator Iterator(short[] array)
		{
			IntPtr intPtr = JNIEnv.NewArray(array);
			ShortIterator @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<ShortIterator>(ArrayIteratorsKt._members.StaticMethods.InvokeObjectMethod("iterator.([S)Lkotlin/collections/ShortIterator;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (array != null)
				{
					JNIEnv.CopyArray(intPtr, array);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(array);
			}
			return @object;
		}

		// Token: 0x0400067B RID: 1659
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/ArrayIteratorsKt", typeof(ArrayIteratorsKt));
	}
}
