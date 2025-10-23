using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Random;

namespace Kotlin.Ranges
{
	// Token: 0x020002A5 RID: 677
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/ranges/RangesKt", DoNotGenerateAcw = true)]
	public sealed class RangesKt : Java.Lang.Object
	{
		// Token: 0x1700091F RID: 2335
		// (get) Token: 0x06001E91 RID: 7825 RVA: 0x000648F8 File Offset: 0x00062AF8
		internal static IntPtr class_ref
		{
			get
			{
				return RangesKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000920 RID: 2336
		// (get) Token: 0x06001E92 RID: 7826 RVA: 0x0006491C File Offset: 0x00062B1C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return RangesKt._members;
			}
		}

		// Token: 0x17000921 RID: 2337
		// (get) Token: 0x06001E93 RID: 7827 RVA: 0x00064924 File Offset: 0x00062B24
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return RangesKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000922 RID: 2338
		// (get) Token: 0x06001E94 RID: 7828 RVA: 0x00064948 File Offset: 0x00062B48
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return RangesKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06001E95 RID: 7829 RVA: 0x00064954 File Offset: 0x00062B54
		internal RangesKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001E96 RID: 7830 RVA: 0x00064960 File Offset: 0x00062B60
		[Register("byteRangeContains", "(Lkotlin/ranges/ClosedRange;I)Z", "")]
		public unsafe static bool ByteRangeContains(IClosedRange _this_contains, int value)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_contains == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_contains).Handle);
				ptr[1] = new JniArgumentValue(value);
				result = RangesKt._members.StaticMethods.InvokeBooleanMethod("byteRangeContains.(Lkotlin/ranges/ClosedRange;I)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_contains);
			}
			return result;
		}

		// Token: 0x06001E97 RID: 7831 RVA: 0x000649DC File Offset: 0x00062BDC
		[Register("byteRangeContains", "(Lkotlin/ranges/ClosedRange;J)Z", "")]
		public unsafe static bool ByteRangeContains(IClosedRange _this_contains, long value)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_contains == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_contains).Handle);
				ptr[1] = new JniArgumentValue(value);
				result = RangesKt._members.StaticMethods.InvokeBooleanMethod("byteRangeContains.(Lkotlin/ranges/ClosedRange;J)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_contains);
			}
			return result;
		}

		// Token: 0x06001E98 RID: 7832 RVA: 0x00064A58 File Offset: 0x00062C58
		[Register("byteRangeContains", "(Lkotlin/ranges/ClosedRange;S)Z", "")]
		public unsafe static bool ByteRangeContains(IClosedRange _this_contains, short value)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_contains == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_contains).Handle);
				ptr[1] = new JniArgumentValue(value);
				result = RangesKt._members.StaticMethods.InvokeBooleanMethod("byteRangeContains.(Lkotlin/ranges/ClosedRange;S)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_contains);
			}
			return result;
		}

		// Token: 0x06001E99 RID: 7833 RVA: 0x00064AD4 File Offset: 0x00062CD4
		[Register("byteRangeContains", "(Lkotlin/ranges/OpenEndRange;I)Z", "")]
		public unsafe static bool ByteRangeContains(IOpenEndRange _this_contains, int value)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_contains == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_contains).Handle);
				ptr[1] = new JniArgumentValue(value);
				result = RangesKt._members.StaticMethods.InvokeBooleanMethod("byteRangeContains.(Lkotlin/ranges/OpenEndRange;I)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_contains);
			}
			return result;
		}

		// Token: 0x06001E9A RID: 7834 RVA: 0x00064B50 File Offset: 0x00062D50
		[Register("byteRangeContains", "(Lkotlin/ranges/OpenEndRange;J)Z", "")]
		public unsafe static bool ByteRangeContains(IOpenEndRange _this_contains, long value)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_contains == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_contains).Handle);
				ptr[1] = new JniArgumentValue(value);
				result = RangesKt._members.StaticMethods.InvokeBooleanMethod("byteRangeContains.(Lkotlin/ranges/OpenEndRange;J)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_contains);
			}
			return result;
		}

		// Token: 0x06001E9B RID: 7835 RVA: 0x00064BCC File Offset: 0x00062DCC
		[Register("byteRangeContains", "(Lkotlin/ranges/OpenEndRange;S)Z", "")]
		public unsafe static bool ByteRangeContains(IOpenEndRange _this_contains, short value)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_contains == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_contains).Handle);
				ptr[1] = new JniArgumentValue(value);
				result = RangesKt._members.StaticMethods.InvokeBooleanMethod("byteRangeContains.(Lkotlin/ranges/OpenEndRange;S)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_contains);
			}
			return result;
		}

		// Token: 0x06001E9C RID: 7836 RVA: 0x00064C48 File Offset: 0x00062E48
		[Register("coerceAtLeast", "(BB)B", "")]
		public unsafe static sbyte CoerceAtLeast(sbyte _this_coerceAtLeast, sbyte minimumValue)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_coerceAtLeast);
			ptr[1] = new JniArgumentValue(minimumValue);
			return RangesKt._members.StaticMethods.InvokeSByteMethod("coerceAtLeast.(BB)B", ptr);
		}

		// Token: 0x06001E9D RID: 7837 RVA: 0x00064C98 File Offset: 0x00062E98
		[Register("coerceAtLeast", "(DD)D", "")]
		public unsafe static double CoerceAtLeast(double _this_coerceAtLeast, double minimumValue)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_coerceAtLeast);
			ptr[1] = new JniArgumentValue(minimumValue);
			return RangesKt._members.StaticMethods.InvokeDoubleMethod("coerceAtLeast.(DD)D", ptr);
		}

		// Token: 0x06001E9E RID: 7838 RVA: 0x00064CE8 File Offset: 0x00062EE8
		[Register("coerceAtLeast", "(FF)F", "")]
		public unsafe static float CoerceAtLeast(float _this_coerceAtLeast, float minimumValue)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_coerceAtLeast);
			ptr[1] = new JniArgumentValue(minimumValue);
			return RangesKt._members.StaticMethods.InvokeSingleMethod("coerceAtLeast.(FF)F", ptr);
		}

		// Token: 0x06001E9F RID: 7839 RVA: 0x00064D38 File Offset: 0x00062F38
		[Register("coerceAtLeast", "(II)I", "")]
		public unsafe static int CoerceAtLeast(int _this_coerceAtLeast, int minimumValue)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_coerceAtLeast);
			ptr[1] = new JniArgumentValue(minimumValue);
			return RangesKt._members.StaticMethods.InvokeInt32Method("coerceAtLeast.(II)I", ptr);
		}

		// Token: 0x06001EA0 RID: 7840 RVA: 0x00064D88 File Offset: 0x00062F88
		[Register("coerceAtLeast", "(JJ)J", "")]
		public unsafe static long CoerceAtLeast(long _this_coerceAtLeast, long minimumValue)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_coerceAtLeast);
			ptr[1] = new JniArgumentValue(minimumValue);
			return RangesKt._members.StaticMethods.InvokeInt64Method("coerceAtLeast.(JJ)J", ptr);
		}

		// Token: 0x06001EA1 RID: 7841 RVA: 0x00064DD8 File Offset: 0x00062FD8
		[Register("coerceAtLeast", "(SS)S", "")]
		public unsafe static short CoerceAtLeast(short _this_coerceAtLeast, short minimumValue)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_coerceAtLeast);
			ptr[1] = new JniArgumentValue(minimumValue);
			return RangesKt._members.StaticMethods.InvokeInt16Method("coerceAtLeast.(SS)S", ptr);
		}

		// Token: 0x06001EA2 RID: 7842 RVA: 0x00064E28 File Offset: 0x00063028
		[Register("coerceAtLeast", "(Ljava/lang/Comparable;Ljava/lang/Comparable;)Ljava/lang/Comparable;", "")]
		[JavaTypeParameters(new string[]
		{
			"T extends java.lang.Comparable<? super T>"
		})]
		public unsafe static Java.Lang.Object CoerceAtLeast(Java.Lang.Object _this_coerceAtLeast, Java.Lang.Object minimumValue)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(_this_coerceAtLeast);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(minimumValue);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(RangesKt._members.StaticMethods.InvokeObjectMethod("coerceAtLeast.(Ljava/lang/Comparable;Ljava/lang/Comparable;)Ljava/lang/Comparable;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_coerceAtLeast);
				GC.KeepAlive(minimumValue);
			}
			return @object;
		}

		// Token: 0x06001EA3 RID: 7843 RVA: 0x00064EC0 File Offset: 0x000630C0
		[Register("coerceAtMost", "(BB)B", "")]
		public unsafe static sbyte CoerceAtMost(sbyte _this_coerceAtMost, sbyte maximumValue)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_coerceAtMost);
			ptr[1] = new JniArgumentValue(maximumValue);
			return RangesKt._members.StaticMethods.InvokeSByteMethod("coerceAtMost.(BB)B", ptr);
		}

		// Token: 0x06001EA4 RID: 7844 RVA: 0x00064F10 File Offset: 0x00063110
		[Register("coerceAtMost", "(DD)D", "")]
		public unsafe static double CoerceAtMost(double _this_coerceAtMost, double maximumValue)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_coerceAtMost);
			ptr[1] = new JniArgumentValue(maximumValue);
			return RangesKt._members.StaticMethods.InvokeDoubleMethod("coerceAtMost.(DD)D", ptr);
		}

		// Token: 0x06001EA5 RID: 7845 RVA: 0x00064F60 File Offset: 0x00063160
		[Register("coerceAtMost", "(FF)F", "")]
		public unsafe static float CoerceAtMost(float _this_coerceAtMost, float maximumValue)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_coerceAtMost);
			ptr[1] = new JniArgumentValue(maximumValue);
			return RangesKt._members.StaticMethods.InvokeSingleMethod("coerceAtMost.(FF)F", ptr);
		}

		// Token: 0x06001EA6 RID: 7846 RVA: 0x00064FB0 File Offset: 0x000631B0
		[Register("coerceAtMost", "(II)I", "")]
		public unsafe static int CoerceAtMost(int _this_coerceAtMost, int maximumValue)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_coerceAtMost);
			ptr[1] = new JniArgumentValue(maximumValue);
			return RangesKt._members.StaticMethods.InvokeInt32Method("coerceAtMost.(II)I", ptr);
		}

		// Token: 0x06001EA7 RID: 7847 RVA: 0x00065000 File Offset: 0x00063200
		[Register("coerceAtMost", "(JJ)J", "")]
		public unsafe static long CoerceAtMost(long _this_coerceAtMost, long maximumValue)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_coerceAtMost);
			ptr[1] = new JniArgumentValue(maximumValue);
			return RangesKt._members.StaticMethods.InvokeInt64Method("coerceAtMost.(JJ)J", ptr);
		}

		// Token: 0x06001EA8 RID: 7848 RVA: 0x00065050 File Offset: 0x00063250
		[Register("coerceAtMost", "(SS)S", "")]
		public unsafe static short CoerceAtMost(short _this_coerceAtMost, short maximumValue)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_coerceAtMost);
			ptr[1] = new JniArgumentValue(maximumValue);
			return RangesKt._members.StaticMethods.InvokeInt16Method("coerceAtMost.(SS)S", ptr);
		}

		// Token: 0x06001EA9 RID: 7849 RVA: 0x000650A0 File Offset: 0x000632A0
		[Register("coerceAtMost", "(Ljava/lang/Comparable;Ljava/lang/Comparable;)Ljava/lang/Comparable;", "")]
		[JavaTypeParameters(new string[]
		{
			"T extends java.lang.Comparable<? super T>"
		})]
		public unsafe static Java.Lang.Object CoerceAtMost(Java.Lang.Object _this_coerceAtMost, Java.Lang.Object maximumValue)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(_this_coerceAtMost);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(maximumValue);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(RangesKt._members.StaticMethods.InvokeObjectMethod("coerceAtMost.(Ljava/lang/Comparable;Ljava/lang/Comparable;)Ljava/lang/Comparable;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_coerceAtMost);
				GC.KeepAlive(maximumValue);
			}
			return @object;
		}

		// Token: 0x06001EAA RID: 7850 RVA: 0x00065138 File Offset: 0x00063338
		[Register("coerceIn", "(BBB)B", "")]
		public unsafe static sbyte CoerceIn(sbyte _this_coerceIn, sbyte minimumValue, sbyte maximumValue)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_coerceIn);
			ptr[1] = new JniArgumentValue(minimumValue);
			ptr[2] = new JniArgumentValue(maximumValue);
			return RangesKt._members.StaticMethods.InvokeSByteMethod("coerceIn.(BBB)B", ptr);
		}

		// Token: 0x06001EAB RID: 7851 RVA: 0x0006519C File Offset: 0x0006339C
		[Register("coerceIn", "(DDD)D", "")]
		public unsafe static double CoerceIn(double _this_coerceIn, double minimumValue, double maximumValue)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_coerceIn);
			ptr[1] = new JniArgumentValue(minimumValue);
			ptr[2] = new JniArgumentValue(maximumValue);
			return RangesKt._members.StaticMethods.InvokeDoubleMethod("coerceIn.(DDD)D", ptr);
		}

		// Token: 0x06001EAC RID: 7852 RVA: 0x00065200 File Offset: 0x00063400
		[Register("coerceIn", "(FFF)F", "")]
		public unsafe static float CoerceIn(float _this_coerceIn, float minimumValue, float maximumValue)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_coerceIn);
			ptr[1] = new JniArgumentValue(minimumValue);
			ptr[2] = new JniArgumentValue(maximumValue);
			return RangesKt._members.StaticMethods.InvokeSingleMethod("coerceIn.(FFF)F", ptr);
		}

		// Token: 0x06001EAD RID: 7853 RVA: 0x00065264 File Offset: 0x00063464
		[Register("coerceIn", "(III)I", "")]
		public unsafe static int CoerceIn(int _this_coerceIn, int minimumValue, int maximumValue)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_coerceIn);
			ptr[1] = new JniArgumentValue(minimumValue);
			ptr[2] = new JniArgumentValue(maximumValue);
			return RangesKt._members.StaticMethods.InvokeInt32Method("coerceIn.(III)I", ptr);
		}

		// Token: 0x06001EAE RID: 7854 RVA: 0x000652C8 File Offset: 0x000634C8
		[Register("coerceIn", "(ILkotlin/ranges/ClosedRange;)I", "")]
		public unsafe static int CoerceIn(int _this_coerceIn, IClosedRange range)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(_this_coerceIn);
				ptr[1] = new JniArgumentValue((range == null) ? IntPtr.Zero : ((Java.Lang.Object)range).Handle);
				result = RangesKt._members.StaticMethods.InvokeInt32Method("coerceIn.(ILkotlin/ranges/ClosedRange;)I", ptr);
			}
			finally
			{
				GC.KeepAlive(range);
			}
			return result;
		}

		// Token: 0x06001EAF RID: 7855 RVA: 0x00065344 File Offset: 0x00063544
		[Register("coerceIn", "(JLkotlin/ranges/ClosedRange;)J", "")]
		public unsafe static long CoerceIn(long _this_coerceIn, IClosedRange range)
		{
			long result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(_this_coerceIn);
				ptr[1] = new JniArgumentValue((range == null) ? IntPtr.Zero : ((Java.Lang.Object)range).Handle);
				result = RangesKt._members.StaticMethods.InvokeInt64Method("coerceIn.(JLkotlin/ranges/ClosedRange;)J", ptr);
			}
			finally
			{
				GC.KeepAlive(range);
			}
			return result;
		}

		// Token: 0x06001EB0 RID: 7856 RVA: 0x000653C0 File Offset: 0x000635C0
		[Register("coerceIn", "(JJJ)J", "")]
		public unsafe static long CoerceIn(long _this_coerceIn, long minimumValue, long maximumValue)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_coerceIn);
			ptr[1] = new JniArgumentValue(minimumValue);
			ptr[2] = new JniArgumentValue(maximumValue);
			return RangesKt._members.StaticMethods.InvokeInt64Method("coerceIn.(JJJ)J", ptr);
		}

		// Token: 0x06001EB1 RID: 7857 RVA: 0x00065424 File Offset: 0x00063624
		[Register("coerceIn", "(SSS)S", "")]
		public unsafe static short CoerceIn(short _this_coerceIn, short minimumValue, short maximumValue)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_coerceIn);
			ptr[1] = new JniArgumentValue(minimumValue);
			ptr[2] = new JniArgumentValue(maximumValue);
			return RangesKt._members.StaticMethods.InvokeInt16Method("coerceIn.(SSS)S", ptr);
		}

		// Token: 0x06001EB2 RID: 7858 RVA: 0x00065488 File Offset: 0x00063688
		[Register("coerceIn", "(Ljava/lang/Comparable;Lkotlin/ranges/ClosedFloatingPointRange;)Ljava/lang/Comparable;", "")]
		[JavaTypeParameters(new string[]
		{
			"T extends java.lang.Comparable<? super T>"
		})]
		public unsafe static Java.Lang.Object CoerceIn(Java.Lang.Object _this_coerceIn, IClosedFloatingPointRange range)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(_this_coerceIn);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((range == null) ? IntPtr.Zero : ((Java.Lang.Object)range).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(RangesKt._members.StaticMethods.InvokeObjectMethod("coerceIn.(Ljava/lang/Comparable;Lkotlin/ranges/ClosedFloatingPointRange;)Ljava/lang/Comparable;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_coerceIn);
				GC.KeepAlive(range);
			}
			return @object;
		}

		// Token: 0x06001EB3 RID: 7859 RVA: 0x00065528 File Offset: 0x00063728
		[Register("coerceIn", "(Ljava/lang/Comparable;Lkotlin/ranges/ClosedRange;)Ljava/lang/Comparable;", "")]
		[JavaTypeParameters(new string[]
		{
			"T extends java.lang.Comparable<? super T>"
		})]
		public unsafe static Java.Lang.Object CoerceIn(Java.Lang.Object _this_coerceIn, IClosedRange range)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(_this_coerceIn);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((range == null) ? IntPtr.Zero : ((Java.Lang.Object)range).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(RangesKt._members.StaticMethods.InvokeObjectMethod("coerceIn.(Ljava/lang/Comparable;Lkotlin/ranges/ClosedRange;)Ljava/lang/Comparable;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_coerceIn);
				GC.KeepAlive(range);
			}
			return @object;
		}

		// Token: 0x06001EB4 RID: 7860 RVA: 0x000655C8 File Offset: 0x000637C8
		[Register("coerceIn", "(Ljava/lang/Comparable;Ljava/lang/Comparable;Ljava/lang/Comparable;)Ljava/lang/Comparable;", "")]
		[JavaTypeParameters(new string[]
		{
			"T extends java.lang.Comparable<? super T>"
		})]
		public unsafe static Java.Lang.Object CoerceIn(Java.Lang.Object _this_coerceIn, [Nullable(2)] Java.Lang.Object minimumValue, [Nullable(2)] Java.Lang.Object maximumValue)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(_this_coerceIn);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(minimumValue);
			IntPtr intPtr3 = JNIEnv.ToLocalJniHandle(maximumValue);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(RangesKt._members.StaticMethods.InvokeObjectMethod("coerceIn.(Ljava/lang/Comparable;Ljava/lang/Comparable;Ljava/lang/Comparable;)Ljava/lang/Comparable;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
				GC.KeepAlive(_this_coerceIn);
				GC.KeepAlive(minimumValue);
				GC.KeepAlive(maximumValue);
			}
			return @object;
		}

		// Token: 0x06001EB5 RID: 7861 RVA: 0x0006568C File Offset: 0x0006388C
		[Register("doubleRangeContains", "(Lkotlin/ranges/ClosedRange;F)Z", "")]
		public unsafe static bool DoubleRangeContains(IClosedRange _this_contains, float value)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_contains == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_contains).Handle);
				ptr[1] = new JniArgumentValue(value);
				result = RangesKt._members.StaticMethods.InvokeBooleanMethod("doubleRangeContains.(Lkotlin/ranges/ClosedRange;F)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_contains);
			}
			return result;
		}

		// Token: 0x06001EB6 RID: 7862 RVA: 0x00065708 File Offset: 0x00063908
		[Register("doubleRangeContains", "(Lkotlin/ranges/OpenEndRange;F)Z", "")]
		public unsafe static bool DoubleRangeContains(IOpenEndRange _this_contains, float value)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_contains == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_contains).Handle);
				ptr[1] = new JniArgumentValue(value);
				result = RangesKt._members.StaticMethods.InvokeBooleanMethod("doubleRangeContains.(Lkotlin/ranges/OpenEndRange;F)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_contains);
			}
			return result;
		}

		// Token: 0x06001EB7 RID: 7863 RVA: 0x00065784 File Offset: 0x00063984
		[Register("downTo", "(BB)Lkotlin/ranges/IntProgression;", "")]
		public unsafe static IntProgression DownTo(sbyte _this_downTo, sbyte to)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_downTo);
			ptr[1] = new JniArgumentValue(to);
			return Java.Lang.Object.GetObject<IntProgression>(RangesKt._members.StaticMethods.InvokeObjectMethod("downTo.(BB)Lkotlin/ranges/IntProgression;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001EB8 RID: 7864 RVA: 0x000657E0 File Offset: 0x000639E0
		[Register("downTo", "(BI)Lkotlin/ranges/IntProgression;", "")]
		public unsafe static IntProgression DownTo(sbyte _this_downTo, int to)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_downTo);
			ptr[1] = new JniArgumentValue(to);
			return Java.Lang.Object.GetObject<IntProgression>(RangesKt._members.StaticMethods.InvokeObjectMethod("downTo.(BI)Lkotlin/ranges/IntProgression;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001EB9 RID: 7865 RVA: 0x0006583C File Offset: 0x00063A3C
		[Register("downTo", "(BJ)Lkotlin/ranges/LongProgression;", "")]
		public unsafe static LongProgression DownTo(sbyte _this_downTo, long to)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_downTo);
			ptr[1] = new JniArgumentValue(to);
			return Java.Lang.Object.GetObject<LongProgression>(RangesKt._members.StaticMethods.InvokeObjectMethod("downTo.(BJ)Lkotlin/ranges/LongProgression;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001EBA RID: 7866 RVA: 0x00065898 File Offset: 0x00063A98
		[Register("downTo", "(BS)Lkotlin/ranges/IntProgression;", "")]
		public unsafe static IntProgression DownTo(sbyte _this_downTo, short to)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_downTo);
			ptr[1] = new JniArgumentValue(to);
			return Java.Lang.Object.GetObject<IntProgression>(RangesKt._members.StaticMethods.InvokeObjectMethod("downTo.(BS)Lkotlin/ranges/IntProgression;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001EBB RID: 7867 RVA: 0x000658F4 File Offset: 0x00063AF4
		[Register("downTo", "(CC)Lkotlin/ranges/CharProgression;", "")]
		public unsafe static CharProgression DownTo(char _this_downTo, char to)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_downTo);
			ptr[1] = new JniArgumentValue(to);
			return Java.Lang.Object.GetObject<CharProgression>(RangesKt._members.StaticMethods.InvokeObjectMethod("downTo.(CC)Lkotlin/ranges/CharProgression;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001EBC RID: 7868 RVA: 0x00065950 File Offset: 0x00063B50
		[Register("downTo", "(IB)Lkotlin/ranges/IntProgression;", "")]
		public unsafe static IntProgression DownTo(int _this_downTo, sbyte to)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_downTo);
			ptr[1] = new JniArgumentValue(to);
			return Java.Lang.Object.GetObject<IntProgression>(RangesKt._members.StaticMethods.InvokeObjectMethod("downTo.(IB)Lkotlin/ranges/IntProgression;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001EBD RID: 7869 RVA: 0x000659AC File Offset: 0x00063BAC
		[Register("downTo", "(II)Lkotlin/ranges/IntProgression;", "")]
		public unsafe static IntProgression DownTo(int _this_downTo, int to)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_downTo);
			ptr[1] = new JniArgumentValue(to);
			return Java.Lang.Object.GetObject<IntProgression>(RangesKt._members.StaticMethods.InvokeObjectMethod("downTo.(II)Lkotlin/ranges/IntProgression;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001EBE RID: 7870 RVA: 0x00065A08 File Offset: 0x00063C08
		[Register("downTo", "(IJ)Lkotlin/ranges/LongProgression;", "")]
		public unsafe static LongProgression DownTo(int _this_downTo, long to)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_downTo);
			ptr[1] = new JniArgumentValue(to);
			return Java.Lang.Object.GetObject<LongProgression>(RangesKt._members.StaticMethods.InvokeObjectMethod("downTo.(IJ)Lkotlin/ranges/LongProgression;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001EBF RID: 7871 RVA: 0x00065A64 File Offset: 0x00063C64
		[Register("downTo", "(IS)Lkotlin/ranges/IntProgression;", "")]
		public unsafe static IntProgression DownTo(int _this_downTo, short to)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_downTo);
			ptr[1] = new JniArgumentValue(to);
			return Java.Lang.Object.GetObject<IntProgression>(RangesKt._members.StaticMethods.InvokeObjectMethod("downTo.(IS)Lkotlin/ranges/IntProgression;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001EC0 RID: 7872 RVA: 0x00065AC0 File Offset: 0x00063CC0
		[Register("downTo", "(JB)Lkotlin/ranges/LongProgression;", "")]
		public unsafe static LongProgression DownTo(long _this_downTo, sbyte to)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_downTo);
			ptr[1] = new JniArgumentValue(to);
			return Java.Lang.Object.GetObject<LongProgression>(RangesKt._members.StaticMethods.InvokeObjectMethod("downTo.(JB)Lkotlin/ranges/LongProgression;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001EC1 RID: 7873 RVA: 0x00065B1C File Offset: 0x00063D1C
		[Register("downTo", "(JI)Lkotlin/ranges/LongProgression;", "")]
		public unsafe static LongProgression DownTo(long _this_downTo, int to)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_downTo);
			ptr[1] = new JniArgumentValue(to);
			return Java.Lang.Object.GetObject<LongProgression>(RangesKt._members.StaticMethods.InvokeObjectMethod("downTo.(JI)Lkotlin/ranges/LongProgression;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001EC2 RID: 7874 RVA: 0x00065B78 File Offset: 0x00063D78
		[Register("downTo", "(JJ)Lkotlin/ranges/LongProgression;", "")]
		public unsafe static LongProgression DownTo(long _this_downTo, long to)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_downTo);
			ptr[1] = new JniArgumentValue(to);
			return Java.Lang.Object.GetObject<LongProgression>(RangesKt._members.StaticMethods.InvokeObjectMethod("downTo.(JJ)Lkotlin/ranges/LongProgression;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001EC3 RID: 7875 RVA: 0x00065BD4 File Offset: 0x00063DD4
		[Register("downTo", "(JS)Lkotlin/ranges/LongProgression;", "")]
		public unsafe static LongProgression DownTo(long _this_downTo, short to)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_downTo);
			ptr[1] = new JniArgumentValue(to);
			return Java.Lang.Object.GetObject<LongProgression>(RangesKt._members.StaticMethods.InvokeObjectMethod("downTo.(JS)Lkotlin/ranges/LongProgression;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001EC4 RID: 7876 RVA: 0x00065C30 File Offset: 0x00063E30
		[Register("downTo", "(SB)Lkotlin/ranges/IntProgression;", "")]
		public unsafe static IntProgression DownTo(short _this_downTo, sbyte to)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_downTo);
			ptr[1] = new JniArgumentValue(to);
			return Java.Lang.Object.GetObject<IntProgression>(RangesKt._members.StaticMethods.InvokeObjectMethod("downTo.(SB)Lkotlin/ranges/IntProgression;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001EC5 RID: 7877 RVA: 0x00065C8C File Offset: 0x00063E8C
		[Register("downTo", "(SI)Lkotlin/ranges/IntProgression;", "")]
		public unsafe static IntProgression DownTo(short _this_downTo, int to)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_downTo);
			ptr[1] = new JniArgumentValue(to);
			return Java.Lang.Object.GetObject<IntProgression>(RangesKt._members.StaticMethods.InvokeObjectMethod("downTo.(SI)Lkotlin/ranges/IntProgression;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001EC6 RID: 7878 RVA: 0x00065CE8 File Offset: 0x00063EE8
		[Register("downTo", "(SJ)Lkotlin/ranges/LongProgression;", "")]
		public unsafe static LongProgression DownTo(short _this_downTo, long to)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_downTo);
			ptr[1] = new JniArgumentValue(to);
			return Java.Lang.Object.GetObject<LongProgression>(RangesKt._members.StaticMethods.InvokeObjectMethod("downTo.(SJ)Lkotlin/ranges/LongProgression;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001EC7 RID: 7879 RVA: 0x00065D44 File Offset: 0x00063F44
		[Register("downTo", "(SS)Lkotlin/ranges/IntProgression;", "")]
		public unsafe static IntProgression DownTo(short _this_downTo, short to)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_downTo);
			ptr[1] = new JniArgumentValue(to);
			return Java.Lang.Object.GetObject<IntProgression>(RangesKt._members.StaticMethods.InvokeObjectMethod("downTo.(SS)Lkotlin/ranges/IntProgression;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001EC8 RID: 7880 RVA: 0x00065DA0 File Offset: 0x00063FA0
		[Register("first", "(Lkotlin/ranges/CharProgression;)C", "")]
		public unsafe static char First(CharProgression _this_first)
		{
			char result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_first == null) ? IntPtr.Zero : _this_first.Handle);
				result = RangesKt._members.StaticMethods.InvokeCharMethod("first.(Lkotlin/ranges/CharProgression;)C", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_first);
			}
			return result;
		}

		// Token: 0x06001EC9 RID: 7881 RVA: 0x00065E04 File Offset: 0x00064004
		[Register("first", "(Lkotlin/ranges/IntProgression;)I", "")]
		public unsafe static int First(IntProgression _this_first)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_first == null) ? IntPtr.Zero : _this_first.Handle);
				result = RangesKt._members.StaticMethods.InvokeInt32Method("first.(Lkotlin/ranges/IntProgression;)I", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_first);
			}
			return result;
		}

		// Token: 0x06001ECA RID: 7882 RVA: 0x00065E68 File Offset: 0x00064068
		[Register("first", "(Lkotlin/ranges/LongProgression;)J", "")]
		public unsafe static long First(LongProgression _this_first)
		{
			long result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_first == null) ? IntPtr.Zero : _this_first.Handle);
				result = RangesKt._members.StaticMethods.InvokeInt64Method("first.(Lkotlin/ranges/LongProgression;)J", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_first);
			}
			return result;
		}

		// Token: 0x06001ECB RID: 7883 RVA: 0x00065ECC File Offset: 0x000640CC
		[Register("firstOrNull", "(Lkotlin/ranges/CharProgression;)Ljava/lang/Character;", "")]
		[return: Nullable(2)]
		public unsafe static Character FirstOrNull(CharProgression _this_firstOrNull)
		{
			Character @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_firstOrNull == null) ? IntPtr.Zero : _this_firstOrNull.Handle);
				@object = Java.Lang.Object.GetObject<Character>(RangesKt._members.StaticMethods.InvokeObjectMethod("firstOrNull.(Lkotlin/ranges/CharProgression;)Ljava/lang/Character;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_firstOrNull);
			}
			return @object;
		}

		// Token: 0x06001ECC RID: 7884 RVA: 0x00065F40 File Offset: 0x00064140
		[Register("firstOrNull", "(Lkotlin/ranges/IntProgression;)Ljava/lang/Integer;", "")]
		[return: Nullable(2)]
		public unsafe static Integer FirstOrNull(IntProgression _this_firstOrNull)
		{
			Integer @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_firstOrNull == null) ? IntPtr.Zero : _this_firstOrNull.Handle);
				@object = Java.Lang.Object.GetObject<Integer>(RangesKt._members.StaticMethods.InvokeObjectMethod("firstOrNull.(Lkotlin/ranges/IntProgression;)Ljava/lang/Integer;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_firstOrNull);
			}
			return @object;
		}

		// Token: 0x06001ECD RID: 7885 RVA: 0x00065FB4 File Offset: 0x000641B4
		[Register("firstOrNull", "(Lkotlin/ranges/LongProgression;)Ljava/lang/Long;", "")]
		[return: Nullable(2)]
		public unsafe static Long FirstOrNull(LongProgression _this_firstOrNull)
		{
			Long @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_firstOrNull == null) ? IntPtr.Zero : _this_firstOrNull.Handle);
				@object = Java.Lang.Object.GetObject<Long>(RangesKt._members.StaticMethods.InvokeObjectMethod("firstOrNull.(Lkotlin/ranges/LongProgression;)Ljava/lang/Long;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_firstOrNull);
			}
			return @object;
		}

		// Token: 0x06001ECE RID: 7886 RVA: 0x00066028 File Offset: 0x00064228
		[Register("floatRangeContains", "(Lkotlin/ranges/ClosedRange;D)Z", "")]
		public unsafe static bool FloatRangeContains(IClosedRange _this_contains, double value)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_contains == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_contains).Handle);
				ptr[1] = new JniArgumentValue(value);
				result = RangesKt._members.StaticMethods.InvokeBooleanMethod("floatRangeContains.(Lkotlin/ranges/ClosedRange;D)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_contains);
			}
			return result;
		}

		// Token: 0x06001ECF RID: 7887 RVA: 0x000660A4 File Offset: 0x000642A4
		[Register("intRangeContains", "(Lkotlin/ranges/ClosedRange;B)Z", "")]
		public unsafe static bool IntRangeContains(IClosedRange _this_contains, sbyte value)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_contains == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_contains).Handle);
				ptr[1] = new JniArgumentValue(value);
				result = RangesKt._members.StaticMethods.InvokeBooleanMethod("intRangeContains.(Lkotlin/ranges/ClosedRange;B)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_contains);
			}
			return result;
		}

		// Token: 0x06001ED0 RID: 7888 RVA: 0x00066120 File Offset: 0x00064320
		[Register("intRangeContains", "(Lkotlin/ranges/ClosedRange;J)Z", "")]
		public unsafe static bool IntRangeContains(IClosedRange _this_contains, long value)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_contains == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_contains).Handle);
				ptr[1] = new JniArgumentValue(value);
				result = RangesKt._members.StaticMethods.InvokeBooleanMethod("intRangeContains.(Lkotlin/ranges/ClosedRange;J)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_contains);
			}
			return result;
		}

		// Token: 0x06001ED1 RID: 7889 RVA: 0x0006619C File Offset: 0x0006439C
		[Register("intRangeContains", "(Lkotlin/ranges/ClosedRange;S)Z", "")]
		public unsafe static bool IntRangeContains(IClosedRange _this_contains, short value)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_contains == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_contains).Handle);
				ptr[1] = new JniArgumentValue(value);
				result = RangesKt._members.StaticMethods.InvokeBooleanMethod("intRangeContains.(Lkotlin/ranges/ClosedRange;S)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_contains);
			}
			return result;
		}

		// Token: 0x06001ED2 RID: 7890 RVA: 0x00066218 File Offset: 0x00064418
		[Register("intRangeContains", "(Lkotlin/ranges/OpenEndRange;B)Z", "")]
		public unsafe static bool IntRangeContains(IOpenEndRange _this_contains, sbyte value)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_contains == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_contains).Handle);
				ptr[1] = new JniArgumentValue(value);
				result = RangesKt._members.StaticMethods.InvokeBooleanMethod("intRangeContains.(Lkotlin/ranges/OpenEndRange;B)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_contains);
			}
			return result;
		}

		// Token: 0x06001ED3 RID: 7891 RVA: 0x00066294 File Offset: 0x00064494
		[Register("intRangeContains", "(Lkotlin/ranges/OpenEndRange;J)Z", "")]
		public unsafe static bool IntRangeContains(IOpenEndRange _this_contains, long value)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_contains == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_contains).Handle);
				ptr[1] = new JniArgumentValue(value);
				result = RangesKt._members.StaticMethods.InvokeBooleanMethod("intRangeContains.(Lkotlin/ranges/OpenEndRange;J)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_contains);
			}
			return result;
		}

		// Token: 0x06001ED4 RID: 7892 RVA: 0x00066310 File Offset: 0x00064510
		[Register("intRangeContains", "(Lkotlin/ranges/OpenEndRange;S)Z", "")]
		public unsafe static bool IntRangeContains(IOpenEndRange _this_contains, short value)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_contains == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_contains).Handle);
				ptr[1] = new JniArgumentValue(value);
				result = RangesKt._members.StaticMethods.InvokeBooleanMethod("intRangeContains.(Lkotlin/ranges/OpenEndRange;S)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_contains);
			}
			return result;
		}

		// Token: 0x06001ED5 RID: 7893 RVA: 0x0006638C File Offset: 0x0006458C
		[Register("last", "(Lkotlin/ranges/CharProgression;)C", "")]
		public unsafe static char Last(CharProgression _this_last)
		{
			char result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_last == null) ? IntPtr.Zero : _this_last.Handle);
				result = RangesKt._members.StaticMethods.InvokeCharMethod("last.(Lkotlin/ranges/CharProgression;)C", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_last);
			}
			return result;
		}

		// Token: 0x06001ED6 RID: 7894 RVA: 0x000663F0 File Offset: 0x000645F0
		[Register("last", "(Lkotlin/ranges/IntProgression;)I", "")]
		public unsafe static int Last(IntProgression _this_last)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_last == null) ? IntPtr.Zero : _this_last.Handle);
				result = RangesKt._members.StaticMethods.InvokeInt32Method("last.(Lkotlin/ranges/IntProgression;)I", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_last);
			}
			return result;
		}

		// Token: 0x06001ED7 RID: 7895 RVA: 0x00066454 File Offset: 0x00064654
		[Register("last", "(Lkotlin/ranges/LongProgression;)J", "")]
		public unsafe static long Last(LongProgression _this_last)
		{
			long result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_last == null) ? IntPtr.Zero : _this_last.Handle);
				result = RangesKt._members.StaticMethods.InvokeInt64Method("last.(Lkotlin/ranges/LongProgression;)J", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_last);
			}
			return result;
		}

		// Token: 0x06001ED8 RID: 7896 RVA: 0x000664B8 File Offset: 0x000646B8
		[Register("lastOrNull", "(Lkotlin/ranges/CharProgression;)Ljava/lang/Character;", "")]
		[return: Nullable(2)]
		public unsafe static Character LastOrNull(CharProgression _this_lastOrNull)
		{
			Character @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_lastOrNull == null) ? IntPtr.Zero : _this_lastOrNull.Handle);
				@object = Java.Lang.Object.GetObject<Character>(RangesKt._members.StaticMethods.InvokeObjectMethod("lastOrNull.(Lkotlin/ranges/CharProgression;)Ljava/lang/Character;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_lastOrNull);
			}
			return @object;
		}

		// Token: 0x06001ED9 RID: 7897 RVA: 0x0006652C File Offset: 0x0006472C
		[Register("lastOrNull", "(Lkotlin/ranges/IntProgression;)Ljava/lang/Integer;", "")]
		[return: Nullable(2)]
		public unsafe static Integer LastOrNull(IntProgression _this_lastOrNull)
		{
			Integer @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_lastOrNull == null) ? IntPtr.Zero : _this_lastOrNull.Handle);
				@object = Java.Lang.Object.GetObject<Integer>(RangesKt._members.StaticMethods.InvokeObjectMethod("lastOrNull.(Lkotlin/ranges/IntProgression;)Ljava/lang/Integer;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_lastOrNull);
			}
			return @object;
		}

		// Token: 0x06001EDA RID: 7898 RVA: 0x000665A0 File Offset: 0x000647A0
		[Register("lastOrNull", "(Lkotlin/ranges/LongProgression;)Ljava/lang/Long;", "")]
		[return: Nullable(2)]
		public unsafe static Long LastOrNull(LongProgression _this_lastOrNull)
		{
			Long @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_lastOrNull == null) ? IntPtr.Zero : _this_lastOrNull.Handle);
				@object = Java.Lang.Object.GetObject<Long>(RangesKt._members.StaticMethods.InvokeObjectMethod("lastOrNull.(Lkotlin/ranges/LongProgression;)Ljava/lang/Long;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_lastOrNull);
			}
			return @object;
		}

		// Token: 0x06001EDB RID: 7899 RVA: 0x00066614 File Offset: 0x00064814
		[Register("longRangeContains", "(Lkotlin/ranges/ClosedRange;B)Z", "")]
		public unsafe static bool LongRangeContains(IClosedRange _this_contains, sbyte value)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_contains == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_contains).Handle);
				ptr[1] = new JniArgumentValue(value);
				result = RangesKt._members.StaticMethods.InvokeBooleanMethod("longRangeContains.(Lkotlin/ranges/ClosedRange;B)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_contains);
			}
			return result;
		}

		// Token: 0x06001EDC RID: 7900 RVA: 0x00066690 File Offset: 0x00064890
		[Register("longRangeContains", "(Lkotlin/ranges/ClosedRange;I)Z", "")]
		public unsafe static bool LongRangeContains(IClosedRange _this_contains, int value)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_contains == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_contains).Handle);
				ptr[1] = new JniArgumentValue(value);
				result = RangesKt._members.StaticMethods.InvokeBooleanMethod("longRangeContains.(Lkotlin/ranges/ClosedRange;I)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_contains);
			}
			return result;
		}

		// Token: 0x06001EDD RID: 7901 RVA: 0x0006670C File Offset: 0x0006490C
		[Register("longRangeContains", "(Lkotlin/ranges/ClosedRange;S)Z", "")]
		public unsafe static bool LongRangeContains(IClosedRange _this_contains, short value)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_contains == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_contains).Handle);
				ptr[1] = new JniArgumentValue(value);
				result = RangesKt._members.StaticMethods.InvokeBooleanMethod("longRangeContains.(Lkotlin/ranges/ClosedRange;S)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_contains);
			}
			return result;
		}

		// Token: 0x06001EDE RID: 7902 RVA: 0x00066788 File Offset: 0x00064988
		[Register("longRangeContains", "(Lkotlin/ranges/OpenEndRange;B)Z", "")]
		public unsafe static bool LongRangeContains(IOpenEndRange _this_contains, sbyte value)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_contains == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_contains).Handle);
				ptr[1] = new JniArgumentValue(value);
				result = RangesKt._members.StaticMethods.InvokeBooleanMethod("longRangeContains.(Lkotlin/ranges/OpenEndRange;B)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_contains);
			}
			return result;
		}

		// Token: 0x06001EDF RID: 7903 RVA: 0x00066804 File Offset: 0x00064A04
		[Register("longRangeContains", "(Lkotlin/ranges/OpenEndRange;I)Z", "")]
		public unsafe static bool LongRangeContains(IOpenEndRange _this_contains, int value)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_contains == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_contains).Handle);
				ptr[1] = new JniArgumentValue(value);
				result = RangesKt._members.StaticMethods.InvokeBooleanMethod("longRangeContains.(Lkotlin/ranges/OpenEndRange;I)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_contains);
			}
			return result;
		}

		// Token: 0x06001EE0 RID: 7904 RVA: 0x00066880 File Offset: 0x00064A80
		[Register("longRangeContains", "(Lkotlin/ranges/OpenEndRange;S)Z", "")]
		public unsafe static bool LongRangeContains(IOpenEndRange _this_contains, short value)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_contains == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_contains).Handle);
				ptr[1] = new JniArgumentValue(value);
				result = RangesKt._members.StaticMethods.InvokeBooleanMethod("longRangeContains.(Lkotlin/ranges/OpenEndRange;S)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_contains);
			}
			return result;
		}

		// Token: 0x06001EE1 RID: 7905 RVA: 0x000668FC File Offset: 0x00064AFC
		[Register("random", "(Lkotlin/ranges/CharRange;Lkotlin/random/Random;)C", "")]
		public unsafe static char Random(CharRange _this_random, Kotlin.Random.Random random)
		{
			char result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_random == null) ? IntPtr.Zero : _this_random.Handle);
				ptr[1] = new JniArgumentValue((random == null) ? IntPtr.Zero : random.Handle);
				result = RangesKt._members.StaticMethods.InvokeCharMethod("random.(Lkotlin/ranges/CharRange;Lkotlin/random/Random;)C", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_random);
				GC.KeepAlive(random);
			}
			return result;
		}

		// Token: 0x06001EE2 RID: 7906 RVA: 0x00066988 File Offset: 0x00064B88
		[Register("random", "(Lkotlin/ranges/IntRange;Lkotlin/random/Random;)I", "")]
		public unsafe static int Random(IntRange _this_random, Kotlin.Random.Random random)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_random == null) ? IntPtr.Zero : _this_random.Handle);
				ptr[1] = new JniArgumentValue((random == null) ? IntPtr.Zero : random.Handle);
				result = RangesKt._members.StaticMethods.InvokeInt32Method("random.(Lkotlin/ranges/IntRange;Lkotlin/random/Random;)I", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_random);
				GC.KeepAlive(random);
			}
			return result;
		}

		// Token: 0x06001EE3 RID: 7907 RVA: 0x00066A14 File Offset: 0x00064C14
		[Register("random", "(Lkotlin/ranges/LongRange;Lkotlin/random/Random;)J", "")]
		public unsafe static long Random(LongRange _this_random, Kotlin.Random.Random random)
		{
			long result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_random == null) ? IntPtr.Zero : _this_random.Handle);
				ptr[1] = new JniArgumentValue((random == null) ? IntPtr.Zero : random.Handle);
				result = RangesKt._members.StaticMethods.InvokeInt64Method("random.(Lkotlin/ranges/LongRange;Lkotlin/random/Random;)J", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_random);
				GC.KeepAlive(random);
			}
			return result;
		}

		// Token: 0x06001EE4 RID: 7908 RVA: 0x00066AA0 File Offset: 0x00064CA0
		[Register("randomOrNull", "(Lkotlin/ranges/CharRange;Lkotlin/random/Random;)Ljava/lang/Character;", "")]
		[return: Nullable(2)]
		public unsafe static Character RandomOrNull(CharRange _this_randomOrNull, Kotlin.Random.Random random)
		{
			Character @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_randomOrNull == null) ? IntPtr.Zero : _this_randomOrNull.Handle);
				ptr[1] = new JniArgumentValue((random == null) ? IntPtr.Zero : random.Handle);
				@object = Java.Lang.Object.GetObject<Character>(RangesKt._members.StaticMethods.InvokeObjectMethod("randomOrNull.(Lkotlin/ranges/CharRange;Lkotlin/random/Random;)Ljava/lang/Character;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_randomOrNull);
				GC.KeepAlive(random);
			}
			return @object;
		}

		// Token: 0x06001EE5 RID: 7909 RVA: 0x00066B3C File Offset: 0x00064D3C
		[Register("randomOrNull", "(Lkotlin/ranges/IntRange;Lkotlin/random/Random;)Ljava/lang/Integer;", "")]
		[return: Nullable(2)]
		public unsafe static Integer RandomOrNull(IntRange _this_randomOrNull, Kotlin.Random.Random random)
		{
			Integer @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_randomOrNull == null) ? IntPtr.Zero : _this_randomOrNull.Handle);
				ptr[1] = new JniArgumentValue((random == null) ? IntPtr.Zero : random.Handle);
				@object = Java.Lang.Object.GetObject<Integer>(RangesKt._members.StaticMethods.InvokeObjectMethod("randomOrNull.(Lkotlin/ranges/IntRange;Lkotlin/random/Random;)Ljava/lang/Integer;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_randomOrNull);
				GC.KeepAlive(random);
			}
			return @object;
		}

		// Token: 0x06001EE6 RID: 7910 RVA: 0x00066BD8 File Offset: 0x00064DD8
		[Register("randomOrNull", "(Lkotlin/ranges/LongRange;Lkotlin/random/Random;)Ljava/lang/Long;", "")]
		[return: Nullable(2)]
		public unsafe static Long RandomOrNull(LongRange _this_randomOrNull, Kotlin.Random.Random random)
		{
			Long @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_randomOrNull == null) ? IntPtr.Zero : _this_randomOrNull.Handle);
				ptr[1] = new JniArgumentValue((random == null) ? IntPtr.Zero : random.Handle);
				@object = Java.Lang.Object.GetObject<Long>(RangesKt._members.StaticMethods.InvokeObjectMethod("randomOrNull.(Lkotlin/ranges/LongRange;Lkotlin/random/Random;)Ljava/lang/Long;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_randomOrNull);
				GC.KeepAlive(random);
			}
			return @object;
		}

		// Token: 0x06001EE7 RID: 7911 RVA: 0x00066C74 File Offset: 0x00064E74
		[Register("reversed", "(Lkotlin/ranges/CharProgression;)Lkotlin/ranges/CharProgression;", "")]
		public unsafe static CharProgression Reversed(CharProgression _this_reversed)
		{
			CharProgression @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_reversed == null) ? IntPtr.Zero : _this_reversed.Handle);
				@object = Java.Lang.Object.GetObject<CharProgression>(RangesKt._members.StaticMethods.InvokeObjectMethod("reversed.(Lkotlin/ranges/CharProgression;)Lkotlin/ranges/CharProgression;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_reversed);
			}
			return @object;
		}

		// Token: 0x06001EE8 RID: 7912 RVA: 0x00066CE8 File Offset: 0x00064EE8
		[Register("reversed", "(Lkotlin/ranges/IntProgression;)Lkotlin/ranges/IntProgression;", "")]
		public unsafe static IntProgression Reversed(IntProgression _this_reversed)
		{
			IntProgression @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_reversed == null) ? IntPtr.Zero : _this_reversed.Handle);
				@object = Java.Lang.Object.GetObject<IntProgression>(RangesKt._members.StaticMethods.InvokeObjectMethod("reversed.(Lkotlin/ranges/IntProgression;)Lkotlin/ranges/IntProgression;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_reversed);
			}
			return @object;
		}

		// Token: 0x06001EE9 RID: 7913 RVA: 0x00066D5C File Offset: 0x00064F5C
		[Register("reversed", "(Lkotlin/ranges/LongProgression;)Lkotlin/ranges/LongProgression;", "")]
		public unsafe static LongProgression Reversed(LongProgression _this_reversed)
		{
			LongProgression @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_reversed == null) ? IntPtr.Zero : _this_reversed.Handle);
				@object = Java.Lang.Object.GetObject<LongProgression>(RangesKt._members.StaticMethods.InvokeObjectMethod("reversed.(Lkotlin/ranges/LongProgression;)Lkotlin/ranges/LongProgression;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_reversed);
			}
			return @object;
		}

		// Token: 0x06001EEA RID: 7914 RVA: 0x00066DD0 File Offset: 0x00064FD0
		[Register("shortRangeContains", "(Lkotlin/ranges/ClosedRange;B)Z", "")]
		public unsafe static bool ShortRangeContains(IClosedRange _this_contains, sbyte value)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_contains == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_contains).Handle);
				ptr[1] = new JniArgumentValue(value);
				result = RangesKt._members.StaticMethods.InvokeBooleanMethod("shortRangeContains.(Lkotlin/ranges/ClosedRange;B)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_contains);
			}
			return result;
		}

		// Token: 0x06001EEB RID: 7915 RVA: 0x00066E4C File Offset: 0x0006504C
		[Register("shortRangeContains", "(Lkotlin/ranges/ClosedRange;I)Z", "")]
		public unsafe static bool ShortRangeContains(IClosedRange _this_contains, int value)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_contains == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_contains).Handle);
				ptr[1] = new JniArgumentValue(value);
				result = RangesKt._members.StaticMethods.InvokeBooleanMethod("shortRangeContains.(Lkotlin/ranges/ClosedRange;I)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_contains);
			}
			return result;
		}

		// Token: 0x06001EEC RID: 7916 RVA: 0x00066EC8 File Offset: 0x000650C8
		[Register("shortRangeContains", "(Lkotlin/ranges/ClosedRange;J)Z", "")]
		public unsafe static bool ShortRangeContains(IClosedRange _this_contains, long value)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_contains == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_contains).Handle);
				ptr[1] = new JniArgumentValue(value);
				result = RangesKt._members.StaticMethods.InvokeBooleanMethod("shortRangeContains.(Lkotlin/ranges/ClosedRange;J)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_contains);
			}
			return result;
		}

		// Token: 0x06001EED RID: 7917 RVA: 0x00066F44 File Offset: 0x00065144
		[Register("shortRangeContains", "(Lkotlin/ranges/OpenEndRange;B)Z", "")]
		public unsafe static bool ShortRangeContains(IOpenEndRange _this_contains, sbyte value)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_contains == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_contains).Handle);
				ptr[1] = new JniArgumentValue(value);
				result = RangesKt._members.StaticMethods.InvokeBooleanMethod("shortRangeContains.(Lkotlin/ranges/OpenEndRange;B)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_contains);
			}
			return result;
		}

		// Token: 0x06001EEE RID: 7918 RVA: 0x00066FC0 File Offset: 0x000651C0
		[Register("shortRangeContains", "(Lkotlin/ranges/OpenEndRange;I)Z", "")]
		public unsafe static bool ShortRangeContains(IOpenEndRange _this_contains, int value)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_contains == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_contains).Handle);
				ptr[1] = new JniArgumentValue(value);
				result = RangesKt._members.StaticMethods.InvokeBooleanMethod("shortRangeContains.(Lkotlin/ranges/OpenEndRange;I)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_contains);
			}
			return result;
		}

		// Token: 0x06001EEF RID: 7919 RVA: 0x0006703C File Offset: 0x0006523C
		[Register("shortRangeContains", "(Lkotlin/ranges/OpenEndRange;J)Z", "")]
		public unsafe static bool ShortRangeContains(IOpenEndRange _this_contains, long value)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_contains == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_contains).Handle);
				ptr[1] = new JniArgumentValue(value);
				result = RangesKt._members.StaticMethods.InvokeBooleanMethod("shortRangeContains.(Lkotlin/ranges/OpenEndRange;J)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_contains);
			}
			return result;
		}

		// Token: 0x06001EF0 RID: 7920 RVA: 0x000670B8 File Offset: 0x000652B8
		[Register("step", "(Lkotlin/ranges/CharProgression;I)Lkotlin/ranges/CharProgression;", "")]
		public unsafe static CharProgression Step(CharProgression _this_step, int step)
		{
			CharProgression @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_step == null) ? IntPtr.Zero : _this_step.Handle);
				ptr[1] = new JniArgumentValue(step);
				@object = Java.Lang.Object.GetObject<CharProgression>(RangesKt._members.StaticMethods.InvokeObjectMethod("step.(Lkotlin/ranges/CharProgression;I)Lkotlin/ranges/CharProgression;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_step);
			}
			return @object;
		}

		// Token: 0x06001EF1 RID: 7921 RVA: 0x00067140 File Offset: 0x00065340
		[Register("step", "(Lkotlin/ranges/IntProgression;I)Lkotlin/ranges/IntProgression;", "")]
		public unsafe static IntProgression Step(IntProgression _this_step, int step)
		{
			IntProgression @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_step == null) ? IntPtr.Zero : _this_step.Handle);
				ptr[1] = new JniArgumentValue(step);
				@object = Java.Lang.Object.GetObject<IntProgression>(RangesKt._members.StaticMethods.InvokeObjectMethod("step.(Lkotlin/ranges/IntProgression;I)Lkotlin/ranges/IntProgression;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_step);
			}
			return @object;
		}

		// Token: 0x06001EF2 RID: 7922 RVA: 0x000671C8 File Offset: 0x000653C8
		[Register("step", "(Lkotlin/ranges/LongProgression;J)Lkotlin/ranges/LongProgression;", "")]
		public unsafe static LongProgression Step(LongProgression _this_step, long step)
		{
			LongProgression @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_step == null) ? IntPtr.Zero : _this_step.Handle);
				ptr[1] = new JniArgumentValue(step);
				@object = Java.Lang.Object.GetObject<LongProgression>(RangesKt._members.StaticMethods.InvokeObjectMethod("step.(Lkotlin/ranges/LongProgression;J)Lkotlin/ranges/LongProgression;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_step);
			}
			return @object;
		}

		// Token: 0x06001EF3 RID: 7923 RVA: 0x00067250 File Offset: 0x00065450
		[NullableContext(2)]
		[Register("toByteExactOrNull", "(D)Ljava/lang/Byte;", "")]
		public unsafe static Java.Lang.Byte ToByteExactOrNull(double _this_toByteExactOrNull)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_toByteExactOrNull);
			return Java.Lang.Object.GetObject<Java.Lang.Byte>(RangesKt._members.StaticMethods.InvokeObjectMethod("toByteExactOrNull.(D)Ljava/lang/Byte;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001EF4 RID: 7924 RVA: 0x00067298 File Offset: 0x00065498
		[NullableContext(2)]
		[Register("toByteExactOrNull", "(F)Ljava/lang/Byte;", "")]
		public unsafe static Java.Lang.Byte ToByteExactOrNull(float _this_toByteExactOrNull)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_toByteExactOrNull);
			return Java.Lang.Object.GetObject<Java.Lang.Byte>(RangesKt._members.StaticMethods.InvokeObjectMethod("toByteExactOrNull.(F)Ljava/lang/Byte;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001EF5 RID: 7925 RVA: 0x000672E0 File Offset: 0x000654E0
		[NullableContext(2)]
		[Register("toByteExactOrNull", "(I)Ljava/lang/Byte;", "")]
		public unsafe static Java.Lang.Byte ToByteExactOrNull(int _this_toByteExactOrNull)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_toByteExactOrNull);
			return Java.Lang.Object.GetObject<Java.Lang.Byte>(RangesKt._members.StaticMethods.InvokeObjectMethod("toByteExactOrNull.(I)Ljava/lang/Byte;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001EF6 RID: 7926 RVA: 0x00067328 File Offset: 0x00065528
		[NullableContext(2)]
		[Register("toByteExactOrNull", "(J)Ljava/lang/Byte;", "")]
		public unsafe static Java.Lang.Byte ToByteExactOrNull(long _this_toByteExactOrNull)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_toByteExactOrNull);
			return Java.Lang.Object.GetObject<Java.Lang.Byte>(RangesKt._members.StaticMethods.InvokeObjectMethod("toByteExactOrNull.(J)Ljava/lang/Byte;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001EF7 RID: 7927 RVA: 0x00067370 File Offset: 0x00065570
		[NullableContext(2)]
		[Register("toByteExactOrNull", "(S)Ljava/lang/Byte;", "")]
		public unsafe static Java.Lang.Byte ToByteExactOrNull(short _this_toByteExactOrNull)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_toByteExactOrNull);
			return Java.Lang.Object.GetObject<Java.Lang.Byte>(RangesKt._members.StaticMethods.InvokeObjectMethod("toByteExactOrNull.(S)Ljava/lang/Byte;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001EF8 RID: 7928 RVA: 0x000673B8 File Offset: 0x000655B8
		[NullableContext(2)]
		[Register("toIntExactOrNull", "(D)Ljava/lang/Integer;", "")]
		public unsafe static Integer ToIntExactOrNull(double _this_toIntExactOrNull)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_toIntExactOrNull);
			return Java.Lang.Object.GetObject<Integer>(RangesKt._members.StaticMethods.InvokeObjectMethod("toIntExactOrNull.(D)Ljava/lang/Integer;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001EF9 RID: 7929 RVA: 0x00067400 File Offset: 0x00065600
		[NullableContext(2)]
		[Register("toIntExactOrNull", "(F)Ljava/lang/Integer;", "")]
		public unsafe static Integer ToIntExactOrNull(float _this_toIntExactOrNull)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_toIntExactOrNull);
			return Java.Lang.Object.GetObject<Integer>(RangesKt._members.StaticMethods.InvokeObjectMethod("toIntExactOrNull.(F)Ljava/lang/Integer;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001EFA RID: 7930 RVA: 0x00067448 File Offset: 0x00065648
		[NullableContext(2)]
		[Register("toIntExactOrNull", "(J)Ljava/lang/Integer;", "")]
		public unsafe static Integer ToIntExactOrNull(long _this_toIntExactOrNull)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_toIntExactOrNull);
			return Java.Lang.Object.GetObject<Integer>(RangesKt._members.StaticMethods.InvokeObjectMethod("toIntExactOrNull.(J)Ljava/lang/Integer;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001EFB RID: 7931 RVA: 0x00067490 File Offset: 0x00065690
		[NullableContext(2)]
		[Register("toLongExactOrNull", "(D)Ljava/lang/Long;", "")]
		public unsafe static Long ToLongExactOrNull(double _this_toLongExactOrNull)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_toLongExactOrNull);
			return Java.Lang.Object.GetObject<Long>(RangesKt._members.StaticMethods.InvokeObjectMethod("toLongExactOrNull.(D)Ljava/lang/Long;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001EFC RID: 7932 RVA: 0x000674D8 File Offset: 0x000656D8
		[NullableContext(2)]
		[Register("toLongExactOrNull", "(F)Ljava/lang/Long;", "")]
		public unsafe static Long ToLongExactOrNull(float _this_toLongExactOrNull)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_toLongExactOrNull);
			return Java.Lang.Object.GetObject<Long>(RangesKt._members.StaticMethods.InvokeObjectMethod("toLongExactOrNull.(F)Ljava/lang/Long;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001EFD RID: 7933 RVA: 0x00067520 File Offset: 0x00065720
		[NullableContext(2)]
		[Register("toShortExactOrNull", "(D)Ljava/lang/Short;", "")]
		public unsafe static Short ToShortExactOrNull(double _this_toShortExactOrNull)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_toShortExactOrNull);
			return Java.Lang.Object.GetObject<Short>(RangesKt._members.StaticMethods.InvokeObjectMethod("toShortExactOrNull.(D)Ljava/lang/Short;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001EFE RID: 7934 RVA: 0x00067568 File Offset: 0x00065768
		[NullableContext(2)]
		[Register("toShortExactOrNull", "(F)Ljava/lang/Short;", "")]
		public unsafe static Short ToShortExactOrNull(float _this_toShortExactOrNull)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_toShortExactOrNull);
			return Java.Lang.Object.GetObject<Short>(RangesKt._members.StaticMethods.InvokeObjectMethod("toShortExactOrNull.(F)Ljava/lang/Short;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001EFF RID: 7935 RVA: 0x000675B0 File Offset: 0x000657B0
		[NullableContext(2)]
		[Register("toShortExactOrNull", "(I)Ljava/lang/Short;", "")]
		public unsafe static Short ToShortExactOrNull(int _this_toShortExactOrNull)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_toShortExactOrNull);
			return Java.Lang.Object.GetObject<Short>(RangesKt._members.StaticMethods.InvokeObjectMethod("toShortExactOrNull.(I)Ljava/lang/Short;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001F00 RID: 7936 RVA: 0x000675F8 File Offset: 0x000657F8
		[NullableContext(2)]
		[Register("toShortExactOrNull", "(J)Ljava/lang/Short;", "")]
		public unsafe static Short ToShortExactOrNull(long _this_toShortExactOrNull)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_toShortExactOrNull);
			return Java.Lang.Object.GetObject<Short>(RangesKt._members.StaticMethods.InvokeObjectMethod("toShortExactOrNull.(J)Ljava/lang/Short;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001F01 RID: 7937 RVA: 0x00067640 File Offset: 0x00065840
		[Register("until", "(BB)Lkotlin/ranges/IntRange;", "")]
		public unsafe static IntRange Until(sbyte _this_until, sbyte to)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_until);
			ptr[1] = new JniArgumentValue(to);
			return Java.Lang.Object.GetObject<IntRange>(RangesKt._members.StaticMethods.InvokeObjectMethod("until.(BB)Lkotlin/ranges/IntRange;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001F02 RID: 7938 RVA: 0x0006769C File Offset: 0x0006589C
		[Register("until", "(BI)Lkotlin/ranges/IntRange;", "")]
		public unsafe static IntRange Until(sbyte _this_until, int to)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_until);
			ptr[1] = new JniArgumentValue(to);
			return Java.Lang.Object.GetObject<IntRange>(RangesKt._members.StaticMethods.InvokeObjectMethod("until.(BI)Lkotlin/ranges/IntRange;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001F03 RID: 7939 RVA: 0x000676F8 File Offset: 0x000658F8
		[Register("until", "(BJ)Lkotlin/ranges/LongRange;", "")]
		public unsafe static LongRange Until(sbyte _this_until, long to)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_until);
			ptr[1] = new JniArgumentValue(to);
			return Java.Lang.Object.GetObject<LongRange>(RangesKt._members.StaticMethods.InvokeObjectMethod("until.(BJ)Lkotlin/ranges/LongRange;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001F04 RID: 7940 RVA: 0x00067754 File Offset: 0x00065954
		[Register("until", "(BS)Lkotlin/ranges/IntRange;", "")]
		public unsafe static IntRange Until(sbyte _this_until, short to)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_until);
			ptr[1] = new JniArgumentValue(to);
			return Java.Lang.Object.GetObject<IntRange>(RangesKt._members.StaticMethods.InvokeObjectMethod("until.(BS)Lkotlin/ranges/IntRange;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001F05 RID: 7941 RVA: 0x000677B0 File Offset: 0x000659B0
		[Register("until", "(CC)Lkotlin/ranges/CharRange;", "")]
		public unsafe static CharRange Until(char _this_until, char to)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_until);
			ptr[1] = new JniArgumentValue(to);
			return Java.Lang.Object.GetObject<CharRange>(RangesKt._members.StaticMethods.InvokeObjectMethod("until.(CC)Lkotlin/ranges/CharRange;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001F06 RID: 7942 RVA: 0x0006780C File Offset: 0x00065A0C
		[Register("until", "(IB)Lkotlin/ranges/IntRange;", "")]
		public unsafe static IntRange Until(int _this_until, sbyte to)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_until);
			ptr[1] = new JniArgumentValue(to);
			return Java.Lang.Object.GetObject<IntRange>(RangesKt._members.StaticMethods.InvokeObjectMethod("until.(IB)Lkotlin/ranges/IntRange;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001F07 RID: 7943 RVA: 0x00067868 File Offset: 0x00065A68
		[Register("until", "(II)Lkotlin/ranges/IntRange;", "")]
		public unsafe static IntRange Until(int _this_until, int to)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_until);
			ptr[1] = new JniArgumentValue(to);
			return Java.Lang.Object.GetObject<IntRange>(RangesKt._members.StaticMethods.InvokeObjectMethod("until.(II)Lkotlin/ranges/IntRange;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001F08 RID: 7944 RVA: 0x000678C4 File Offset: 0x00065AC4
		[Register("until", "(IJ)Lkotlin/ranges/LongRange;", "")]
		public unsafe static LongRange Until(int _this_until, long to)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_until);
			ptr[1] = new JniArgumentValue(to);
			return Java.Lang.Object.GetObject<LongRange>(RangesKt._members.StaticMethods.InvokeObjectMethod("until.(IJ)Lkotlin/ranges/LongRange;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001F09 RID: 7945 RVA: 0x00067920 File Offset: 0x00065B20
		[Register("until", "(IS)Lkotlin/ranges/IntRange;", "")]
		public unsafe static IntRange Until(int _this_until, short to)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_until);
			ptr[1] = new JniArgumentValue(to);
			return Java.Lang.Object.GetObject<IntRange>(RangesKt._members.StaticMethods.InvokeObjectMethod("until.(IS)Lkotlin/ranges/IntRange;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001F0A RID: 7946 RVA: 0x0006797C File Offset: 0x00065B7C
		[Register("until", "(JB)Lkotlin/ranges/LongRange;", "")]
		public unsafe static LongRange Until(long _this_until, sbyte to)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_until);
			ptr[1] = new JniArgumentValue(to);
			return Java.Lang.Object.GetObject<LongRange>(RangesKt._members.StaticMethods.InvokeObjectMethod("until.(JB)Lkotlin/ranges/LongRange;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001F0B RID: 7947 RVA: 0x000679D8 File Offset: 0x00065BD8
		[Register("until", "(JI)Lkotlin/ranges/LongRange;", "")]
		public unsafe static LongRange Until(long _this_until, int to)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_until);
			ptr[1] = new JniArgumentValue(to);
			return Java.Lang.Object.GetObject<LongRange>(RangesKt._members.StaticMethods.InvokeObjectMethod("until.(JI)Lkotlin/ranges/LongRange;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001F0C RID: 7948 RVA: 0x00067A34 File Offset: 0x00065C34
		[Register("until", "(JJ)Lkotlin/ranges/LongRange;", "")]
		public unsafe static LongRange Until(long _this_until, long to)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_until);
			ptr[1] = new JniArgumentValue(to);
			return Java.Lang.Object.GetObject<LongRange>(RangesKt._members.StaticMethods.InvokeObjectMethod("until.(JJ)Lkotlin/ranges/LongRange;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001F0D RID: 7949 RVA: 0x00067A90 File Offset: 0x00065C90
		[Register("until", "(JS)Lkotlin/ranges/LongRange;", "")]
		public unsafe static LongRange Until(long _this_until, short to)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_until);
			ptr[1] = new JniArgumentValue(to);
			return Java.Lang.Object.GetObject<LongRange>(RangesKt._members.StaticMethods.InvokeObjectMethod("until.(JS)Lkotlin/ranges/LongRange;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001F0E RID: 7950 RVA: 0x00067AEC File Offset: 0x00065CEC
		[Register("until", "(SB)Lkotlin/ranges/IntRange;", "")]
		public unsafe static IntRange Until(short _this_until, sbyte to)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_until);
			ptr[1] = new JniArgumentValue(to);
			return Java.Lang.Object.GetObject<IntRange>(RangesKt._members.StaticMethods.InvokeObjectMethod("until.(SB)Lkotlin/ranges/IntRange;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001F0F RID: 7951 RVA: 0x00067B48 File Offset: 0x00065D48
		[Register("until", "(SI)Lkotlin/ranges/IntRange;", "")]
		public unsafe static IntRange Until(short _this_until, int to)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_until);
			ptr[1] = new JniArgumentValue(to);
			return Java.Lang.Object.GetObject<IntRange>(RangesKt._members.StaticMethods.InvokeObjectMethod("until.(SI)Lkotlin/ranges/IntRange;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001F10 RID: 7952 RVA: 0x00067BA4 File Offset: 0x00065DA4
		[Register("until", "(SJ)Lkotlin/ranges/LongRange;", "")]
		public unsafe static LongRange Until(short _this_until, long to)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_until);
			ptr[1] = new JniArgumentValue(to);
			return Java.Lang.Object.GetObject<LongRange>(RangesKt._members.StaticMethods.InvokeObjectMethod("until.(SJ)Lkotlin/ranges/LongRange;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001F11 RID: 7953 RVA: 0x00067C00 File Offset: 0x00065E00
		[Register("until", "(SS)Lkotlin/ranges/IntRange;", "")]
		public unsafe static IntRange Until(short _this_until, short to)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_until);
			ptr[1] = new JniArgumentValue(to);
			return Java.Lang.Object.GetObject<IntRange>(RangesKt._members.StaticMethods.InvokeObjectMethod("until.(SS)Lkotlin/ranges/IntRange;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001F12 RID: 7954 RVA: 0x00067C5C File Offset: 0x00065E5C
		[Register("checkStepIsPositive", "(ZLjava/lang/Number;)V", "")]
		public unsafe static void CheckStepIsPositive(bool isPositive, Number step)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(isPositive);
				ptr[1] = new JniArgumentValue((step == null) ? IntPtr.Zero : step.Handle);
				RangesKt._members.StaticMethods.InvokeVoidMethod("checkStepIsPositive.(ZLjava/lang/Number;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(step);
			}
		}

		// Token: 0x06001F13 RID: 7955 RVA: 0x00067CD4 File Offset: 0x00065ED4
		[Register("rangeTo", "(DD)Lkotlin/ranges/ClosedFloatingPointRange;", "")]
		public unsafe static IClosedFloatingPointRange RangeTo(double _this_rangeTo, double that)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_rangeTo);
			ptr[1] = new JniArgumentValue(that);
			return Java.Lang.Object.GetObject<IClosedFloatingPointRange>(RangesKt._members.StaticMethods.InvokeObjectMethod("rangeTo.(DD)Lkotlin/ranges/ClosedFloatingPointRange;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001F14 RID: 7956 RVA: 0x00067D30 File Offset: 0x00065F30
		[Register("rangeTo", "(FF)Lkotlin/ranges/ClosedFloatingPointRange;", "")]
		public unsafe static IClosedFloatingPointRange RangeTo(float _this_rangeTo, float that)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_rangeTo);
			ptr[1] = new JniArgumentValue(that);
			return Java.Lang.Object.GetObject<IClosedFloatingPointRange>(RangesKt._members.StaticMethods.InvokeObjectMethod("rangeTo.(FF)Lkotlin/ranges/ClosedFloatingPointRange;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001F15 RID: 7957 RVA: 0x00067D8C File Offset: 0x00065F8C
		[Register("rangeTo", "(Ljava/lang/Comparable;Ljava/lang/Comparable;)Lkotlin/ranges/ClosedRange;", "")]
		[JavaTypeParameters(new string[]
		{
			"T extends java.lang.Comparable<? super T>"
		})]
		public unsafe static IClosedRange RangeTo(Java.Lang.Object _this_rangeTo, Java.Lang.Object that)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(_this_rangeTo);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(that);
			IClosedRange @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@object = Java.Lang.Object.GetObject<IClosedRange>(RangesKt._members.StaticMethods.InvokeObjectMethod("rangeTo.(Ljava/lang/Comparable;Ljava/lang/Comparable;)Lkotlin/ranges/ClosedRange;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_rangeTo);
				GC.KeepAlive(that);
			}
			return @object;
		}

		// Token: 0x06001F16 RID: 7958 RVA: 0x00067E24 File Offset: 0x00066024
		[Register("rangeUntil", "(DD)Lkotlin/ranges/OpenEndRange;", "")]
		public unsafe static IOpenEndRange RangeUntil(double _this_rangeUntil, double that)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_rangeUntil);
			ptr[1] = new JniArgumentValue(that);
			return Java.Lang.Object.GetObject<IOpenEndRange>(RangesKt._members.StaticMethods.InvokeObjectMethod("rangeUntil.(DD)Lkotlin/ranges/OpenEndRange;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001F17 RID: 7959 RVA: 0x00067E80 File Offset: 0x00066080
		[Register("rangeUntil", "(FF)Lkotlin/ranges/OpenEndRange;", "")]
		public unsafe static IOpenEndRange RangeUntil(float _this_rangeUntil, float that)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_rangeUntil);
			ptr[1] = new JniArgumentValue(that);
			return Java.Lang.Object.GetObject<IOpenEndRange>(RangesKt._members.StaticMethods.InvokeObjectMethod("rangeUntil.(FF)Lkotlin/ranges/OpenEndRange;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001F18 RID: 7960 RVA: 0x00067EDC File Offset: 0x000660DC
		[Register("rangeUntil", "(Ljava/lang/Comparable;Ljava/lang/Comparable;)Lkotlin/ranges/OpenEndRange;", "")]
		[JavaTypeParameters(new string[]
		{
			"T extends java.lang.Comparable<? super T>"
		})]
		public unsafe static IOpenEndRange RangeUntil(Java.Lang.Object _this_rangeUntil, Java.Lang.Object that)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(_this_rangeUntil);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(that);
			IOpenEndRange @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@object = Java.Lang.Object.GetObject<IOpenEndRange>(RangesKt._members.StaticMethods.InvokeObjectMethod("rangeUntil.(Ljava/lang/Comparable;Ljava/lang/Comparable;)Lkotlin/ranges/OpenEndRange;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(_this_rangeUntil);
				GC.KeepAlive(that);
			}
			return @object;
		}

		// Token: 0x04000941 RID: 2369
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/ranges/RangesKt", typeof(RangesKt));
	}
}
