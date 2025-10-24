using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Text
{
	// Token: 0x020000F0 RID: 240
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/text/UStringsKt", DoNotGenerateAcw = true)]
	public sealed class UStringsKt : Java.Lang.Object
	{
		// Token: 0x1700028A RID: 650
		// (get) Token: 0x060009CD RID: 2509 RVA: 0x00020EE8 File Offset: 0x0001F0E8
		internal static IntPtr class_ref
		{
			get
			{
				return UStringsKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x060009CE RID: 2510 RVA: 0x00020F0C File Offset: 0x0001F10C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return UStringsKt._members;
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x060009CF RID: 2511 RVA: 0x00020F14 File Offset: 0x0001F114
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return UStringsKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x060009D0 RID: 2512 RVA: 0x00020F38 File Offset: 0x0001F138
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return UStringsKt._members.ManagedPeerType;
			}
		}

		// Token: 0x060009D1 RID: 2513 RVA: 0x00020F44 File Offset: 0x0001F144
		internal UStringsKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060009D2 RID: 2514 RVA: 0x00020F50 File Offset: 0x0001F150
		[Register("toString-JSWoG40", "(JI)Ljava/lang/String;", "")]
		public unsafe static string ToString(long obj, int radix)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(obj);
			ptr[1] = new JniArgumentValue(radix);
			return JNIEnv.GetString(UStringsKt._members.StaticMethods.InvokeObjectMethod("toString-JSWoG40.(JI)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x00020FAC File Offset: 0x0001F1AC
		[Register("toString-LxnNnR4", "(BI)Ljava/lang/String;", "")]
		public unsafe static string ToString(sbyte obj, int radix)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(obj);
			ptr[1] = new JniArgumentValue(radix);
			return JNIEnv.GetString(UStringsKt._members.StaticMethods.InvokeObjectMethod("toString-LxnNnR4.(BI)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x00021008 File Offset: 0x0001F208
		[Register("toString-V7xB4Y4", "(II)Ljava/lang/String;", "")]
		public unsafe static string ToString(int obj, int radix)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(obj);
			ptr[1] = new JniArgumentValue(radix);
			return JNIEnv.GetString(UStringsKt._members.StaticMethods.InvokeObjectMethod("toString-V7xB4Y4.(II)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x00021064 File Offset: 0x0001F264
		[Register("toString-olVBNx4", "(SI)Ljava/lang/String;", "")]
		public unsafe static string ToString(short obj, int radix)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(obj);
			ptr[1] = new JniArgumentValue(radix);
			return JNIEnv.GetString(UStringsKt._members.StaticMethods.InvokeObjectMethod("toString-olVBNx4.(SI)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x000210C0 File Offset: 0x0001F2C0
		[Register("toUByte", "(Ljava/lang/String;)B", "")]
		public unsafe static byte ToUByte(string obj)
		{
			IntPtr intPtr = JNIEnv.NewString(obj);
			byte result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = (byte)UStringsKt._members.StaticMethods.InvokeSByteMethod("toUByte.(Ljava/lang/String;)B", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x00021120 File Offset: 0x0001F320
		[Register("toUByte", "(Ljava/lang/String;I)B", "")]
		public unsafe static byte ToUByte(string obj, int radix)
		{
			IntPtr intPtr = JNIEnv.NewString(obj);
			byte result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(radix);
				result = (byte)UStringsKt._members.StaticMethods.InvokeSByteMethod("toUByte.(Ljava/lang/String;I)B", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x00021190 File Offset: 0x0001F390
		[Register("toUByteOrNull", "(Ljava/lang/String;)Lkotlin/UByte;", "")]
		[return: Nullable(2)]
		public unsafe static UByte ToUByteOrNull(string obj)
		{
			IntPtr intPtr = JNIEnv.NewString(obj);
			UByte @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<UByte>(UStringsKt._members.StaticMethods.InvokeObjectMethod("toUByteOrNull.(Ljava/lang/String;)Lkotlin/UByte;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x000211FC File Offset: 0x0001F3FC
		[Register("toUByteOrNull", "(Ljava/lang/String;I)Lkotlin/UByte;", "")]
		[return: Nullable(2)]
		public unsafe static UByte ToUByteOrNull(string obj, int radix)
		{
			IntPtr intPtr = JNIEnv.NewString(obj);
			UByte @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(radix);
				@object = Java.Lang.Object.GetObject<UByte>(UStringsKt._members.StaticMethods.InvokeObjectMethod("toUByteOrNull.(Ljava/lang/String;I)Lkotlin/UByte;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x0002127C File Offset: 0x0001F47C
		[Register("toUInt", "(Ljava/lang/String;)I", "")]
		public unsafe static uint ToUInt(string obj)
		{
			IntPtr intPtr = JNIEnv.NewString(obj);
			uint result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = (uint)UStringsKt._members.StaticMethods.InvokeInt32Method("toUInt.(Ljava/lang/String;)I", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x000212D8 File Offset: 0x0001F4D8
		[Register("toUInt", "(Ljava/lang/String;I)I", "")]
		public unsafe static uint ToUInt(string obj, int radix)
		{
			IntPtr intPtr = JNIEnv.NewString(obj);
			uint result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(radix);
				result = (uint)UStringsKt._members.StaticMethods.InvokeInt32Method("toUInt.(Ljava/lang/String;I)I", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x00021348 File Offset: 0x0001F548
		[Register("toUIntOrNull", "(Ljava/lang/String;)Lkotlin/UInt;", "")]
		[return: Nullable(2)]
		public unsafe static UInt ToUIntOrNull(string obj)
		{
			IntPtr intPtr = JNIEnv.NewString(obj);
			UInt @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<UInt>(UStringsKt._members.StaticMethods.InvokeObjectMethod("toUIntOrNull.(Ljava/lang/String;)Lkotlin/UInt;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x000213B4 File Offset: 0x0001F5B4
		[Register("toUIntOrNull", "(Ljava/lang/String;I)Lkotlin/UInt;", "")]
		[return: Nullable(2)]
		public unsafe static UInt ToUIntOrNull(string obj, int radix)
		{
			IntPtr intPtr = JNIEnv.NewString(obj);
			UInt @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(radix);
				@object = Java.Lang.Object.GetObject<UInt>(UStringsKt._members.StaticMethods.InvokeObjectMethod("toUIntOrNull.(Ljava/lang/String;I)Lkotlin/UInt;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060009DE RID: 2526 RVA: 0x00021434 File Offset: 0x0001F634
		[Register("toULong", "(Ljava/lang/String;)J", "")]
		public unsafe static ulong ToULong(string obj)
		{
			IntPtr intPtr = JNIEnv.NewString(obj);
			ulong result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = (ulong)UStringsKt._members.StaticMethods.InvokeInt64Method("toULong.(Ljava/lang/String;)J", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x00021490 File Offset: 0x0001F690
		[Register("toULong", "(Ljava/lang/String;I)J", "")]
		public unsafe static ulong ToULong(string obj, int radix)
		{
			IntPtr intPtr = JNIEnv.NewString(obj);
			ulong result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(radix);
				result = (ulong)UStringsKt._members.StaticMethods.InvokeInt64Method("toULong.(Ljava/lang/String;I)J", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x00021500 File Offset: 0x0001F700
		[Register("toULongOrNull", "(Ljava/lang/String;)Lkotlin/ULong;", "")]
		[return: Nullable(2)]
		public unsafe static ULong ToULongOrNull(string obj)
		{
			IntPtr intPtr = JNIEnv.NewString(obj);
			ULong @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<ULong>(UStringsKt._members.StaticMethods.InvokeObjectMethod("toULongOrNull.(Ljava/lang/String;)Lkotlin/ULong;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x0002156C File Offset: 0x0001F76C
		[Register("toULongOrNull", "(Ljava/lang/String;I)Lkotlin/ULong;", "")]
		[return: Nullable(2)]
		public unsafe static ULong ToULongOrNull(string obj, int radix)
		{
			IntPtr intPtr = JNIEnv.NewString(obj);
			ULong @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(radix);
				@object = Java.Lang.Object.GetObject<ULong>(UStringsKt._members.StaticMethods.InvokeObjectMethod("toULongOrNull.(Ljava/lang/String;I)Lkotlin/ULong;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x000215EC File Offset: 0x0001F7EC
		[Register("toUShort", "(Ljava/lang/String;)S", "")]
		public unsafe static ushort ToUShort(string obj)
		{
			IntPtr intPtr = JNIEnv.NewString(obj);
			ushort result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = (ushort)UStringsKt._members.StaticMethods.InvokeInt16Method("toUShort.(Ljava/lang/String;)S", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x0002164C File Offset: 0x0001F84C
		[Register("toUShort", "(Ljava/lang/String;I)S", "")]
		public unsafe static ushort ToUShort(string obj, int radix)
		{
			IntPtr intPtr = JNIEnv.NewString(obj);
			ushort result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(radix);
				result = (ushort)UStringsKt._members.StaticMethods.InvokeInt16Method("toUShort.(Ljava/lang/String;I)S", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x000216BC File Offset: 0x0001F8BC
		[Register("toUShortOrNull", "(Ljava/lang/String;)Lkotlin/UShort;", "")]
		[return: Nullable(2)]
		public unsafe static UShort ToUShortOrNull(string obj)
		{
			IntPtr intPtr = JNIEnv.NewString(obj);
			UShort @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<UShort>(UStringsKt._members.StaticMethods.InvokeObjectMethod("toUShortOrNull.(Ljava/lang/String;)Lkotlin/UShort;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060009E5 RID: 2533 RVA: 0x00021728 File Offset: 0x0001F928
		[Register("toUShortOrNull", "(Ljava/lang/String;I)Lkotlin/UShort;", "")]
		[return: Nullable(2)]
		public unsafe static UShort ToUShortOrNull(string obj, int radix)
		{
			IntPtr intPtr = JNIEnv.NewString(obj);
			UShort @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(radix);
				@object = Java.Lang.Object.GetObject<UShort>(UStringsKt._members.StaticMethods.InvokeObjectMethod("toUShortOrNull.(Ljava/lang/String;I)Lkotlin/UShort;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x04000258 RID: 600
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/text/UStringsKt", typeof(UStringsKt));
	}
}
