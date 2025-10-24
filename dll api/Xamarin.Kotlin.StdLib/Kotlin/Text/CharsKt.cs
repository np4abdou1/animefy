using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util;

namespace Kotlin.Text
{
	// Token: 0x020000DC RID: 220
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/text/CharsKt", DoNotGenerateAcw = true)]
	public sealed class CharsKt : Java.Lang.Object
	{
		// Token: 0x17000225 RID: 549
		// (get) Token: 0x060006E5 RID: 1765 RVA: 0x00011600 File Offset: 0x0000F800
		internal static IntPtr class_ref
		{
			get
			{
				return CharsKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x060006E6 RID: 1766 RVA: 0x00011624 File Offset: 0x0000F824
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CharsKt._members;
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x060006E7 RID: 1767 RVA: 0x0001162C File Offset: 0x0000F82C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CharsKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x060006E8 RID: 1768 RVA: 0x00011650 File Offset: 0x0000F850
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CharsKt._members.ManagedPeerType;
			}
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x0001165C File Offset: 0x0000F85C
		internal CharsKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x00011668 File Offset: 0x0000F868
		[Register("digitToChar", "(I)C", "")]
		public unsafe static char DigitToChar(int _this_digitToChar)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_digitToChar);
			return CharsKt._members.StaticMethods.InvokeCharMethod("digitToChar.(I)C", ptr);
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x000116A4 File Offset: 0x0000F8A4
		[Register("digitToChar", "(II)C", "")]
		public unsafe static char DigitToChar(int _this_digitToChar, int radix)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_digitToChar);
			ptr[1] = new JniArgumentValue(radix);
			return CharsKt._members.StaticMethods.InvokeCharMethod("digitToChar.(II)C", ptr);
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x000116F4 File Offset: 0x0000F8F4
		[Register("digitToInt", "(C)I", "")]
		public unsafe static int DigitToInt(char _this_digitToInt)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_digitToInt);
			return CharsKt._members.StaticMethods.InvokeInt32Method("digitToInt.(C)I", ptr);
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x00011730 File Offset: 0x0000F930
		[Register("digitToInt", "(CI)I", "")]
		public unsafe static int DigitToInt(char _this_digitToInt, int radix)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_digitToInt);
			ptr[1] = new JniArgumentValue(radix);
			return CharsKt._members.StaticMethods.InvokeInt32Method("digitToInt.(CI)I", ptr);
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x00011780 File Offset: 0x0000F980
		[NullableContext(2)]
		[Register("digitToIntOrNull", "(C)Ljava/lang/Integer;", "")]
		public unsafe static Integer DigitToIntOrNull(char _this_digitToIntOrNull)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_digitToIntOrNull);
			return Java.Lang.Object.GetObject<Integer>(CharsKt._members.StaticMethods.InvokeObjectMethod("digitToIntOrNull.(C)Ljava/lang/Integer;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x000117C8 File Offset: 0x0000F9C8
		[NullableContext(2)]
		[Register("digitToIntOrNull", "(CI)Ljava/lang/Integer;", "")]
		public unsafe static Integer DigitToIntOrNull(char _this_digitToIntOrNull, int radix)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_digitToIntOrNull);
			ptr[1] = new JniArgumentValue(radix);
			return Java.Lang.Object.GetObject<Integer>(CharsKt._members.StaticMethods.InvokeObjectMethod("digitToIntOrNull.(CI)Ljava/lang/Integer;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x00011824 File Offset: 0x0000FA24
		[Register("equals", "(CCZ)Z", "")]
		public unsafe static bool Equals(char _this_equals, char other, bool ignoreCase)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_equals);
			ptr[1] = new JniArgumentValue(other);
			ptr[2] = new JniArgumentValue(ignoreCase);
			return CharsKt._members.StaticMethods.InvokeBooleanMethod("equals.(CCZ)Z", ptr);
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x00011888 File Offset: 0x0000FA88
		[Register("isSurrogate", "(C)Z", "")]
		public unsafe static bool IsSurrogate(char _this_isSurrogate)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_isSurrogate);
			return CharsKt._members.StaticMethods.InvokeBooleanMethod("isSurrogate.(C)Z", ptr);
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x000118C4 File Offset: 0x0000FAC4
		[Register("titlecase", "(C)Ljava/lang/String;", "")]
		public unsafe static string Titlecase(char _this_titlecase)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_titlecase);
			return JNIEnv.GetString(CharsKt._members.StaticMethods.InvokeObjectMethod("titlecase.(C)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x0001190C File Offset: 0x0000FB0C
		[Register("checkRadix", "(I)I", "")]
		public unsafe static int CheckRadix(int radix)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(radix);
			return CharsKt._members.StaticMethods.InvokeInt32Method("checkRadix.(I)I", ptr);
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x00011948 File Offset: 0x0000FB48
		[Register("digitOf", "(CI)I", "")]
		public unsafe static int DigitOf(char @char, int radix)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(@char);
			ptr[1] = new JniArgumentValue(radix);
			return CharsKt._members.StaticMethods.InvokeInt32Method("digitOf.(CI)I", ptr);
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x00011998 File Offset: 0x0000FB98
		[Register("getCategory", "(C)Lkotlin/text/CharCategory;", "")]
		public unsafe static CharCategory GetCategory(char _this_category)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_category);
			return Java.Lang.Object.GetObject<CharCategory>(CharsKt._members.StaticMethods.InvokeObjectMethod("getCategory.(C)Lkotlin/text/CharCategory;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x000119E0 File Offset: 0x0000FBE0
		[Register("getDirectionality", "(C)Lkotlin/text/CharDirectionality;", "")]
		public unsafe static CharDirectionality GetDirectionality(char _this_directionality)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_directionality);
			return Java.Lang.Object.GetObject<CharDirectionality>(CharsKt._members.StaticMethods.InvokeObjectMethod("getDirectionality.(C)Lkotlin/text/CharDirectionality;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x00011A28 File Offset: 0x0000FC28
		[Register("isWhitespace", "(C)Z", "")]
		public unsafe static bool IsWhitespace(char _this_isWhitespace)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_isWhitespace);
			return CharsKt._members.StaticMethods.InvokeBooleanMethod("isWhitespace.(C)Z", ptr);
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x00011A64 File Offset: 0x0000FC64
		[Register("lowercase", "(CLjava/util/Locale;)Ljava/lang/String;", "")]
		public unsafe static string Lowercase(char _this_lowercase, Locale locale)
		{
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(_this_lowercase);
				ptr[1] = new JniArgumentValue((locale == null) ? IntPtr.Zero : locale.Handle);
				@string = JNIEnv.GetString(CharsKt._members.StaticMethods.InvokeObjectMethod("lowercase.(CLjava/util/Locale;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(locale);
			}
			return @string;
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x00011AEC File Offset: 0x0000FCEC
		[Register("titlecase", "(CLjava/util/Locale;)Ljava/lang/String;", "")]
		public unsafe static string Titlecase(char _this_titlecase, Locale locale)
		{
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(_this_titlecase);
				ptr[1] = new JniArgumentValue((locale == null) ? IntPtr.Zero : locale.Handle);
				@string = JNIEnv.GetString(CharsKt._members.StaticMethods.InvokeObjectMethod("titlecase.(CLjava/util/Locale;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(locale);
			}
			return @string;
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x00011B74 File Offset: 0x0000FD74
		[Register("uppercase", "(CLjava/util/Locale;)Ljava/lang/String;", "")]
		public unsafe static string Uppercase(char _this_uppercase, Locale locale)
		{
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(_this_uppercase);
				ptr[1] = new JniArgumentValue((locale == null) ? IntPtr.Zero : locale.Handle);
				@string = JNIEnv.GetString(CharsKt._members.StaticMethods.InvokeObjectMethod("uppercase.(CLjava/util/Locale;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(locale);
			}
			return @string;
		}

		// Token: 0x040001CD RID: 461
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/text/CharsKt", typeof(CharsKt));
	}
}
