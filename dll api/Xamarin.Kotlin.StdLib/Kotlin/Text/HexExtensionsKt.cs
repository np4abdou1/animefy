using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Text
{
	// Token: 0x020000DD RID: 221
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/text/HexExtensionsKt", DoNotGenerateAcw = true)]
	public sealed class HexExtensionsKt : Java.Lang.Object
	{
		// Token: 0x17000229 RID: 553
		// (get) Token: 0x060006FC RID: 1788 RVA: 0x00011C18 File Offset: 0x0000FE18
		internal static IntPtr class_ref
		{
			get
			{
				return HexExtensionsKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x060006FD RID: 1789 RVA: 0x00011C3C File Offset: 0x0000FE3C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return HexExtensionsKt._members;
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x060006FE RID: 1790 RVA: 0x00011C44 File Offset: 0x0000FE44
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return HexExtensionsKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x060006FF RID: 1791 RVA: 0x00011C68 File Offset: 0x0000FE68
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return HexExtensionsKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x00011C74 File Offset: 0x0000FE74
		internal HexExtensionsKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000701 RID: 1793 RVA: 0x00011C80 File Offset: 0x0000FE80
		[Register("hexToByte", "(Ljava/lang/String;Lkotlin/text/HexFormat;)B", "")]
		public unsafe static sbyte HexToByte(string obj, HexFormat format)
		{
			IntPtr intPtr = JNIEnv.NewString(obj);
			sbyte result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((format == null) ? IntPtr.Zero : format.Handle);
				result = HexExtensionsKt._members.StaticMethods.InvokeSByteMethod("hexToByte.(Ljava/lang/String;Lkotlin/text/HexFormat;)B", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(format);
			}
			return result;
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x00011D04 File Offset: 0x0000FF04
		[Register("hexToByteArray", "(Ljava/lang/String;Lkotlin/text/HexFormat;)[B", "")]
		public unsafe static byte[] HexToByteArray(string obj, HexFormat format)
		{
			IntPtr intPtr = JNIEnv.NewString(obj);
			byte[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((format == null) ? IntPtr.Zero : format.Handle);
				result = (byte[])JNIEnv.GetArray(HexExtensionsKt._members.StaticMethods.InvokeObjectMethod("hexToByteArray.(Ljava/lang/String;Lkotlin/text/HexFormat;)[B", ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(byte));
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(format);
			}
			return result;
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x00011DA8 File Offset: 0x0000FFA8
		[Register("hexToInt", "(Ljava/lang/String;Lkotlin/text/HexFormat;)I", "")]
		public unsafe static int HexToInt(string obj, HexFormat format)
		{
			IntPtr intPtr = JNIEnv.NewString(obj);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((format == null) ? IntPtr.Zero : format.Handle);
				result = HexExtensionsKt._members.StaticMethods.InvokeInt32Method("hexToInt.(Ljava/lang/String;Lkotlin/text/HexFormat;)I", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(format);
			}
			return result;
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x00011E2C File Offset: 0x0001002C
		[Register("hexToLong", "(Ljava/lang/String;Lkotlin/text/HexFormat;)J", "")]
		public unsafe static long HexToLong(string obj, HexFormat format)
		{
			IntPtr intPtr = JNIEnv.NewString(obj);
			long result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((format == null) ? IntPtr.Zero : format.Handle);
				result = HexExtensionsKt._members.StaticMethods.InvokeInt64Method("hexToLong.(Ljava/lang/String;Lkotlin/text/HexFormat;)J", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(format);
			}
			return result;
		}

		// Token: 0x06000705 RID: 1797 RVA: 0x00011EB0 File Offset: 0x000100B0
		[Register("hexToShort", "(Ljava/lang/String;Lkotlin/text/HexFormat;)S", "")]
		public unsafe static short HexToShort(string obj, HexFormat format)
		{
			IntPtr intPtr = JNIEnv.NewString(obj);
			short result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((format == null) ? IntPtr.Zero : format.Handle);
				result = HexExtensionsKt._members.StaticMethods.InvokeInt16Method("hexToShort.(Ljava/lang/String;Lkotlin/text/HexFormat;)S", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(format);
			}
			return result;
		}

		// Token: 0x06000706 RID: 1798 RVA: 0x00011F34 File Offset: 0x00010134
		[Register("toHexString", "(BLkotlin/text/HexFormat;)Ljava/lang/String;", "")]
		public unsafe static string ToHexString(sbyte obj, HexFormat format)
		{
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(obj);
				ptr[1] = new JniArgumentValue((format == null) ? IntPtr.Zero : format.Handle);
				@string = JNIEnv.GetString(HexExtensionsKt._members.StaticMethods.InvokeObjectMethod("toHexString.(BLkotlin/text/HexFormat;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(format);
			}
			return @string;
		}

		// Token: 0x06000707 RID: 1799 RVA: 0x00011FBC File Offset: 0x000101BC
		[Register("toHexString", "([BIILkotlin/text/HexFormat;)Ljava/lang/String;", "")]
		public unsafe static string ToHexString(byte[] obj, int startIndex, int endIndex, HexFormat format)
		{
			IntPtr intPtr = JNIEnv.NewArray(obj);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(startIndex);
				ptr[2] = new JniArgumentValue(endIndex);
				ptr[3] = new JniArgumentValue((format == null) ? IntPtr.Zero : format.Handle);
				@string = JNIEnv.GetString(HexExtensionsKt._members.StaticMethods.InvokeObjectMethod("toHexString.([BIILkotlin/text/HexFormat;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (obj != null)
				{
					JNIEnv.CopyArray(intPtr, obj);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(obj);
				GC.KeepAlive(format);
			}
			return @string;
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x0001208C File Offset: 0x0001028C
		[Register("toHexString", "([BLkotlin/text/HexFormat;)Ljava/lang/String;", "")]
		public unsafe static string ToHexString(byte[] obj, HexFormat format)
		{
			IntPtr intPtr = JNIEnv.NewArray(obj);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((format == null) ? IntPtr.Zero : format.Handle);
				@string = JNIEnv.GetString(HexExtensionsKt._members.StaticMethods.InvokeObjectMethod("toHexString.([BLkotlin/text/HexFormat;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (obj != null)
				{
					JNIEnv.CopyArray(intPtr, obj);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(obj);
				GC.KeepAlive(format);
			}
			return @string;
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x00012130 File Offset: 0x00010330
		[Register("toHexString", "(ILkotlin/text/HexFormat;)Ljava/lang/String;", "")]
		public unsafe static string ToHexString(int obj, HexFormat format)
		{
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(obj);
				ptr[1] = new JniArgumentValue((format == null) ? IntPtr.Zero : format.Handle);
				@string = JNIEnv.GetString(HexExtensionsKt._members.StaticMethods.InvokeObjectMethod("toHexString.(ILkotlin/text/HexFormat;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(format);
			}
			return @string;
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x000121B8 File Offset: 0x000103B8
		[Register("toHexString", "(JLkotlin/text/HexFormat;)Ljava/lang/String;", "")]
		public unsafe static string ToHexString(long obj, HexFormat format)
		{
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(obj);
				ptr[1] = new JniArgumentValue((format == null) ? IntPtr.Zero : format.Handle);
				@string = JNIEnv.GetString(HexExtensionsKt._members.StaticMethods.InvokeObjectMethod("toHexString.(JLkotlin/text/HexFormat;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(format);
			}
			return @string;
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x00012240 File Offset: 0x00010440
		[Register("toHexString", "(SLkotlin/text/HexFormat;)Ljava/lang/String;", "")]
		public unsafe static string ToHexString(short obj, HexFormat format)
		{
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(obj);
				ptr[1] = new JniArgumentValue((format == null) ? IntPtr.Zero : format.Handle);
				@string = JNIEnv.GetString(HexExtensionsKt._members.StaticMethods.InvokeObjectMethod("toHexString.(SLkotlin/text/HexFormat;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(format);
			}
			return @string;
		}

		// Token: 0x040001CE RID: 462
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/text/HexExtensionsKt", typeof(HexExtensionsKt));
	}
}
