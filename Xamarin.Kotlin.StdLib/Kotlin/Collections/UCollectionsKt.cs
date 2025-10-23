using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Collections
{
	// Token: 0x020002D8 RID: 728
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/collections/UCollectionsKt", DoNotGenerateAcw = true)]
	public sealed class UCollectionsKt : Java.Lang.Object
	{
		// Token: 0x170009EA RID: 2538
		// (get) Token: 0x0600285B RID: 10331 RVA: 0x000B0544 File Offset: 0x000AE744
		internal static IntPtr class_ref
		{
			get
			{
				return UCollectionsKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170009EB RID: 2539
		// (get) Token: 0x0600285C RID: 10332 RVA: 0x000B0568 File Offset: 0x000AE768
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return UCollectionsKt._members;
			}
		}

		// Token: 0x170009EC RID: 2540
		// (get) Token: 0x0600285D RID: 10333 RVA: 0x000B0570 File Offset: 0x000AE770
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return UCollectionsKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170009ED RID: 2541
		// (get) Token: 0x0600285E RID: 10334 RVA: 0x000B0594 File Offset: 0x000AE794
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return UCollectionsKt._members.ManagedPeerType;
			}
		}

		// Token: 0x0600285F RID: 10335 RVA: 0x000B05A0 File Offset: 0x000AE7A0
		internal UCollectionsKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06002860 RID: 10336 RVA: 0x000B05AC File Offset: 0x000AE7AC
		[Register("sumOfUByte", "(Ljava/lang/Iterable;)I", "")]
		public unsafe static int SumOfUByte(IIterable _this_sum)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_sum == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_sum).Handle);
				result = UCollectionsKt._members.StaticMethods.InvokeInt32Method("sumOfUByte.(Ljava/lang/Iterable;)I", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_sum);
			}
			return result;
		}

		// Token: 0x06002861 RID: 10337 RVA: 0x000B0618 File Offset: 0x000AE818
		[Register("sumOfUInt", "(Ljava/lang/Iterable;)I", "")]
		public unsafe static int SumOfUInt(IIterable _this_sum)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_sum == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_sum).Handle);
				result = UCollectionsKt._members.StaticMethods.InvokeInt32Method("sumOfUInt.(Ljava/lang/Iterable;)I", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_sum);
			}
			return result;
		}

		// Token: 0x06002862 RID: 10338 RVA: 0x000B0684 File Offset: 0x000AE884
		[Register("sumOfULong", "(Ljava/lang/Iterable;)J", "")]
		public unsafe static long SumOfULong(IIterable _this_sum)
		{
			long result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_sum == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_sum).Handle);
				result = UCollectionsKt._members.StaticMethods.InvokeInt64Method("sumOfULong.(Ljava/lang/Iterable;)J", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_sum);
			}
			return result;
		}

		// Token: 0x06002863 RID: 10339 RVA: 0x000B06F0 File Offset: 0x000AE8F0
		[Register("sumOfUShort", "(Ljava/lang/Iterable;)I", "")]
		public unsafe static int SumOfUShort(IIterable _this_sum)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_sum == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_sum).Handle);
				result = UCollectionsKt._members.StaticMethods.InvokeInt32Method("sumOfUShort.(Ljava/lang/Iterable;)I", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_sum);
			}
			return result;
		}

		// Token: 0x06002864 RID: 10340 RVA: 0x000B075C File Offset: 0x000AE95C
		[Register("toUByteArray", "(Ljava/util/Collection;)[B", "")]
		public unsafe static byte[] ToUByteArray(ICollection<UByte> _this_toUByteArray)
		{
			IntPtr intPtr = JavaCollection<UByte>.ToLocalJniHandle(_this_toUByteArray);
			byte[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = (byte[])JNIEnv.GetArray(UCollectionsKt._members.StaticMethods.InvokeObjectMethod("toUByteArray.(Ljava/util/Collection;)[B", ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(byte));
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_toUByteArray);
			}
			return result;
		}

		// Token: 0x06002865 RID: 10341 RVA: 0x000B07DC File Offset: 0x000AE9DC
		[Register("toUIntArray", "(Ljava/util/Collection;)[I", "")]
		public unsafe static int[] ToUIntArray(ICollection<UInt> _this_toUIntArray)
		{
			IntPtr intPtr = JavaCollection<UInt>.ToLocalJniHandle(_this_toUIntArray);
			int[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = (int[])JNIEnv.GetArray(UCollectionsKt._members.StaticMethods.InvokeObjectMethod("toUIntArray.(Ljava/util/Collection;)[I", ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(int));
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_toUIntArray);
			}
			return result;
		}

		// Token: 0x06002866 RID: 10342 RVA: 0x000B085C File Offset: 0x000AEA5C
		[Register("toULongArray", "(Ljava/util/Collection;)[J", "")]
		public unsafe static long[] ToULongArray(ICollection<ULong> _this_toULongArray)
		{
			IntPtr intPtr = JavaCollection<ULong>.ToLocalJniHandle(_this_toULongArray);
			long[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = (long[])JNIEnv.GetArray(UCollectionsKt._members.StaticMethods.InvokeObjectMethod("toULongArray.(Ljava/util/Collection;)[J", ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(long));
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_toULongArray);
			}
			return result;
		}

		// Token: 0x06002867 RID: 10343 RVA: 0x000B08DC File Offset: 0x000AEADC
		[Register("toUShortArray", "(Ljava/util/Collection;)[S", "")]
		public unsafe static short[] ToUShortArray(ICollection<UShort> _this_toUShortArray)
		{
			IntPtr intPtr = JavaCollection<UShort>.ToLocalJniHandle(_this_toUShortArray);
			short[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = (short[])JNIEnv.GetArray(UCollectionsKt._members.StaticMethods.InvokeObjectMethod("toUShortArray.(Ljava/util/Collection;)[S", ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(short));
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_toUShortArray);
			}
			return result;
		}

		// Token: 0x040009C6 RID: 2502
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/collections/UCollectionsKt", typeof(UCollectionsKt));
	}
}
