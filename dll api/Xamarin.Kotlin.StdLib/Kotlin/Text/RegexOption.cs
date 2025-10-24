using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Enums;

namespace Kotlin.Text
{
	// Token: 0x020000EB RID: 235
	[NullableContext(2)]
	[Nullable(0)]
	[Register("kotlin/text/RegexOption", DoNotGenerateAcw = true)]
	public sealed class RegexOption : Java.Lang.Enum
	{
		// Token: 0x1700026B RID: 619
		// (get) Token: 0x060007FB RID: 2043 RVA: 0x0001512C File Offset: 0x0001332C
		[Register("CANON_EQ")]
		public static RegexOption CanonEq
		{
			get
			{
				return Java.Lang.Object.GetObject<RegexOption>(RegexOption._members.StaticFields.GetObjectValue("CANON_EQ.Lkotlin/text/RegexOption;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x060007FC RID: 2044 RVA: 0x0001515C File Offset: 0x0001335C
		[Register("COMMENTS")]
		public static RegexOption Comments
		{
			get
			{
				return Java.Lang.Object.GetObject<RegexOption>(RegexOption._members.StaticFields.GetObjectValue("COMMENTS.Lkotlin/text/RegexOption;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x060007FD RID: 2045 RVA: 0x0001518C File Offset: 0x0001338C
		[Register("DOT_MATCHES_ALL")]
		public static RegexOption DotMatchesAll
		{
			get
			{
				return Java.Lang.Object.GetObject<RegexOption>(RegexOption._members.StaticFields.GetObjectValue("DOT_MATCHES_ALL.Lkotlin/text/RegexOption;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x060007FE RID: 2046 RVA: 0x000151BC File Offset: 0x000133BC
		[Register("IGNORE_CASE")]
		public static RegexOption IgnoreCase
		{
			get
			{
				return Java.Lang.Object.GetObject<RegexOption>(RegexOption._members.StaticFields.GetObjectValue("IGNORE_CASE.Lkotlin/text/RegexOption;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x060007FF RID: 2047 RVA: 0x000151EC File Offset: 0x000133EC
		[Register("LITERAL")]
		public static RegexOption Literal
		{
			get
			{
				return Java.Lang.Object.GetObject<RegexOption>(RegexOption._members.StaticFields.GetObjectValue("LITERAL.Lkotlin/text/RegexOption;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000800 RID: 2048 RVA: 0x0001521C File Offset: 0x0001341C
		[Register("MULTILINE")]
		public static RegexOption Multiline
		{
			get
			{
				return Java.Lang.Object.GetObject<RegexOption>(RegexOption._members.StaticFields.GetObjectValue("MULTILINE.Lkotlin/text/RegexOption;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06000801 RID: 2049 RVA: 0x0001524C File Offset: 0x0001344C
		[Register("UNIX_LINES")]
		public static RegexOption UnixLines
		{
			get
			{
				return Java.Lang.Object.GetObject<RegexOption>(RegexOption._members.StaticFields.GetObjectValue("UNIX_LINES.Lkotlin/text/RegexOption;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06000802 RID: 2050 RVA: 0x0001527C File Offset: 0x0001347C
		internal static IntPtr class_ref
		{
			get
			{
				return RegexOption._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000803 RID: 2051 RVA: 0x000152A0 File Offset: 0x000134A0
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return RegexOption._members;
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000804 RID: 2052 RVA: 0x000152A8 File Offset: 0x000134A8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return RegexOption._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000805 RID: 2053 RVA: 0x000152CC File Offset: 0x000134CC
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return RegexOption._members.ManagedPeerType;
			}
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x000152D8 File Offset: 0x000134D8
		internal RegexOption(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000807 RID: 2055 RVA: 0x000152E4 File Offset: 0x000134E4
		[Nullable(1)]
		public static IEnumEntries Entries
		{
			[NullableContext(1)]
			[Register("getEntries", "()Lkotlin/enums/EnumEntries;", "")]
			get
			{
				return Java.Lang.Object.GetObject<IEnumEntries>(RegexOption._members.StaticMethods.InvokeObjectMethod("getEntries.()Lkotlin/enums/EnumEntries;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000808 RID: 2056 RVA: 0x00015315 File Offset: 0x00013515
		public int Mask
		{
			[Register("getMask", "()I", "")]
			get
			{
				return RegexOption._members.InstanceMethods.InvokeAbstractInt32Method("getMask.()I", this, null);
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000809 RID: 2057 RVA: 0x0001532E File Offset: 0x0001352E
		public int Value
		{
			[Register("getValue", "()I", "")]
			get
			{
				return RegexOption._members.InstanceMethods.InvokeAbstractInt32Method("getValue.()I", this, null);
			}
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x00015348 File Offset: 0x00013548
		[Register("valueOf", "(Ljava/lang/String;)Lkotlin/text/RegexOption;", "")]
		public unsafe static RegexOption ValueOf(string value)
		{
			IntPtr intPtr = JNIEnv.NewString(value);
			RegexOption @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<RegexOption>(RegexOption._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lkotlin/text/RegexOption;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x000153B4 File Offset: 0x000135B4
		[Register("values", "()[Lkotlin/text/RegexOption;", "")]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public static RegexOption[] Values()
		{
			return (RegexOption[])JNIEnv.GetArray(RegexOption._members.StaticMethods.InvokeObjectMethod("values.()[Lkotlin/text/RegexOption;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(RegexOption));
		}

		// Token: 0x0400022A RID: 554
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/text/RegexOption", typeof(RegexOption));
	}
}
