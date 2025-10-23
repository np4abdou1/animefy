using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Enums;
using Kotlin.Jvm.Internal;

namespace Kotlin.Text
{
	// Token: 0x020000D8 RID: 216
	[NullableContext(2)]
	[Nullable(0)]
	[Register("kotlin/text/CharCategory", DoNotGenerateAcw = true)]
	public sealed class CharCategory : Java.Lang.Enum
	{
		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06000685 RID: 1669 RVA: 0x000105E4 File Offset: 0x0000E7E4
		[Register("COMBINING_SPACING_MARK")]
		public static CharCategory CombiningSpacingMark
		{
			get
			{
				return Java.Lang.Object.GetObject<CharCategory>(CharCategory._members.StaticFields.GetObjectValue("COMBINING_SPACING_MARK.Lkotlin/text/CharCategory;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06000686 RID: 1670 RVA: 0x00010614 File Offset: 0x0000E814
		[Nullable(1)]
		[Register("Companion")]
		public static CharCategory.CompanionStatic Companion
		{
			[NullableContext(1)]
			get
			{
				return Java.Lang.Object.GetObject<CharCategory.CompanionStatic>(CharCategory._members.StaticFields.GetObjectValue("Companion.Lkotlin/text/CharCategory$Companion;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x06000687 RID: 1671 RVA: 0x00010644 File Offset: 0x0000E844
		[Register("CONNECTOR_PUNCTUATION")]
		public static CharCategory ConnectorPunctuation
		{
			get
			{
				return Java.Lang.Object.GetObject<CharCategory>(CharCategory._members.StaticFields.GetObjectValue("CONNECTOR_PUNCTUATION.Lkotlin/text/CharCategory;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x06000688 RID: 1672 RVA: 0x00010674 File Offset: 0x0000E874
		[Register("CONTROL")]
		public static CharCategory Control
		{
			get
			{
				return Java.Lang.Object.GetObject<CharCategory>(CharCategory._members.StaticFields.GetObjectValue("CONTROL.Lkotlin/text/CharCategory;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x06000689 RID: 1673 RVA: 0x000106A4 File Offset: 0x0000E8A4
		[Register("CURRENCY_SYMBOL")]
		public static CharCategory CurrencySymbol
		{
			get
			{
				return Java.Lang.Object.GetObject<CharCategory>(CharCategory._members.StaticFields.GetObjectValue("CURRENCY_SYMBOL.Lkotlin/text/CharCategory;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x0600068A RID: 1674 RVA: 0x000106D4 File Offset: 0x0000E8D4
		[Register("DASH_PUNCTUATION")]
		public static CharCategory DashPunctuation
		{
			get
			{
				return Java.Lang.Object.GetObject<CharCategory>(CharCategory._members.StaticFields.GetObjectValue("DASH_PUNCTUATION.Lkotlin/text/CharCategory;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x0600068B RID: 1675 RVA: 0x00010704 File Offset: 0x0000E904
		[Register("DECIMAL_DIGIT_NUMBER")]
		public static CharCategory DecimalDigitNumber
		{
			get
			{
				return Java.Lang.Object.GetObject<CharCategory>(CharCategory._members.StaticFields.GetObjectValue("DECIMAL_DIGIT_NUMBER.Lkotlin/text/CharCategory;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x0600068C RID: 1676 RVA: 0x00010734 File Offset: 0x0000E934
		[Register("ENCLOSING_MARK")]
		public static CharCategory EnclosingMark
		{
			get
			{
				return Java.Lang.Object.GetObject<CharCategory>(CharCategory._members.StaticFields.GetObjectValue("ENCLOSING_MARK.Lkotlin/text/CharCategory;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x0600068D RID: 1677 RVA: 0x00010764 File Offset: 0x0000E964
		[Register("END_PUNCTUATION")]
		public static CharCategory EndPunctuation
		{
			get
			{
				return Java.Lang.Object.GetObject<CharCategory>(CharCategory._members.StaticFields.GetObjectValue("END_PUNCTUATION.Lkotlin/text/CharCategory;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x0600068E RID: 1678 RVA: 0x00010794 File Offset: 0x0000E994
		[Register("FINAL_QUOTE_PUNCTUATION")]
		public static CharCategory FinalQuotePunctuation
		{
			get
			{
				return Java.Lang.Object.GetObject<CharCategory>(CharCategory._members.StaticFields.GetObjectValue("FINAL_QUOTE_PUNCTUATION.Lkotlin/text/CharCategory;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x0600068F RID: 1679 RVA: 0x000107C4 File Offset: 0x0000E9C4
		[Register("FORMAT")]
		public static CharCategory Format
		{
			get
			{
				return Java.Lang.Object.GetObject<CharCategory>(CharCategory._members.StaticFields.GetObjectValue("FORMAT.Lkotlin/text/CharCategory;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06000690 RID: 1680 RVA: 0x000107F4 File Offset: 0x0000E9F4
		[Register("INITIAL_QUOTE_PUNCTUATION")]
		public static CharCategory InitialQuotePunctuation
		{
			get
			{
				return Java.Lang.Object.GetObject<CharCategory>(CharCategory._members.StaticFields.GetObjectValue("INITIAL_QUOTE_PUNCTUATION.Lkotlin/text/CharCategory;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x06000691 RID: 1681 RVA: 0x00010824 File Offset: 0x0000EA24
		[Register("LETTER_NUMBER")]
		public static CharCategory LetterNumber
		{
			get
			{
				return Java.Lang.Object.GetObject<CharCategory>(CharCategory._members.StaticFields.GetObjectValue("LETTER_NUMBER.Lkotlin/text/CharCategory;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x06000692 RID: 1682 RVA: 0x00010854 File Offset: 0x0000EA54
		[Register("LINE_SEPARATOR")]
		public static CharCategory LineSeparator
		{
			get
			{
				return Java.Lang.Object.GetObject<CharCategory>(CharCategory._members.StaticFields.GetObjectValue("LINE_SEPARATOR.Lkotlin/text/CharCategory;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06000693 RID: 1683 RVA: 0x00010884 File Offset: 0x0000EA84
		[Register("LOWERCASE_LETTER")]
		public static CharCategory LowercaseLetter
		{
			get
			{
				return Java.Lang.Object.GetObject<CharCategory>(CharCategory._members.StaticFields.GetObjectValue("LOWERCASE_LETTER.Lkotlin/text/CharCategory;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06000694 RID: 1684 RVA: 0x000108B4 File Offset: 0x0000EAB4
		[Register("MATH_SYMBOL")]
		public static CharCategory MathSymbol
		{
			get
			{
				return Java.Lang.Object.GetObject<CharCategory>(CharCategory._members.StaticFields.GetObjectValue("MATH_SYMBOL.Lkotlin/text/CharCategory;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06000695 RID: 1685 RVA: 0x000108E4 File Offset: 0x0000EAE4
		[Register("MODIFIER_LETTER")]
		public static CharCategory ModifierLetter
		{
			get
			{
				return Java.Lang.Object.GetObject<CharCategory>(CharCategory._members.StaticFields.GetObjectValue("MODIFIER_LETTER.Lkotlin/text/CharCategory;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06000696 RID: 1686 RVA: 0x00010914 File Offset: 0x0000EB14
		[Register("MODIFIER_SYMBOL")]
		public static CharCategory ModifierSymbol
		{
			get
			{
				return Java.Lang.Object.GetObject<CharCategory>(CharCategory._members.StaticFields.GetObjectValue("MODIFIER_SYMBOL.Lkotlin/text/CharCategory;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06000697 RID: 1687 RVA: 0x00010944 File Offset: 0x0000EB44
		[Register("NON_SPACING_MARK")]
		public static CharCategory NonSpacingMark
		{
			get
			{
				return Java.Lang.Object.GetObject<CharCategory>(CharCategory._members.StaticFields.GetObjectValue("NON_SPACING_MARK.Lkotlin/text/CharCategory;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06000698 RID: 1688 RVA: 0x00010974 File Offset: 0x0000EB74
		[Register("OTHER_LETTER")]
		public static CharCategory OtherLetter
		{
			get
			{
				return Java.Lang.Object.GetObject<CharCategory>(CharCategory._members.StaticFields.GetObjectValue("OTHER_LETTER.Lkotlin/text/CharCategory;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x06000699 RID: 1689 RVA: 0x000109A4 File Offset: 0x0000EBA4
		[Register("OTHER_NUMBER")]
		public static CharCategory OtherNumber
		{
			get
			{
				return Java.Lang.Object.GetObject<CharCategory>(CharCategory._members.StaticFields.GetObjectValue("OTHER_NUMBER.Lkotlin/text/CharCategory;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x0600069A RID: 1690 RVA: 0x000109D4 File Offset: 0x0000EBD4
		[Register("OTHER_PUNCTUATION")]
		public static CharCategory OtherPunctuation
		{
			get
			{
				return Java.Lang.Object.GetObject<CharCategory>(CharCategory._members.StaticFields.GetObjectValue("OTHER_PUNCTUATION.Lkotlin/text/CharCategory;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x0600069B RID: 1691 RVA: 0x00010A04 File Offset: 0x0000EC04
		[Register("OTHER_SYMBOL")]
		public static CharCategory OtherSymbol
		{
			get
			{
				return Java.Lang.Object.GetObject<CharCategory>(CharCategory._members.StaticFields.GetObjectValue("OTHER_SYMBOL.Lkotlin/text/CharCategory;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x0600069C RID: 1692 RVA: 0x00010A34 File Offset: 0x0000EC34
		[Register("PARAGRAPH_SEPARATOR")]
		public static CharCategory ParagraphSeparator
		{
			get
			{
				return Java.Lang.Object.GetObject<CharCategory>(CharCategory._members.StaticFields.GetObjectValue("PARAGRAPH_SEPARATOR.Lkotlin/text/CharCategory;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x0600069D RID: 1693 RVA: 0x00010A64 File Offset: 0x0000EC64
		[Register("PRIVATE_USE")]
		public static CharCategory PrivateUse
		{
			get
			{
				return Java.Lang.Object.GetObject<CharCategory>(CharCategory._members.StaticFields.GetObjectValue("PRIVATE_USE.Lkotlin/text/CharCategory;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x0600069E RID: 1694 RVA: 0x00010A94 File Offset: 0x0000EC94
		[Register("SPACE_SEPARATOR")]
		public static CharCategory SpaceSeparator
		{
			get
			{
				return Java.Lang.Object.GetObject<CharCategory>(CharCategory._members.StaticFields.GetObjectValue("SPACE_SEPARATOR.Lkotlin/text/CharCategory;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x0600069F RID: 1695 RVA: 0x00010AC4 File Offset: 0x0000ECC4
		[Register("START_PUNCTUATION")]
		public static CharCategory StartPunctuation
		{
			get
			{
				return Java.Lang.Object.GetObject<CharCategory>(CharCategory._members.StaticFields.GetObjectValue("START_PUNCTUATION.Lkotlin/text/CharCategory;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x060006A0 RID: 1696 RVA: 0x00010AF4 File Offset: 0x0000ECF4
		[Register("SURROGATE")]
		public static CharCategory Surrogate
		{
			get
			{
				return Java.Lang.Object.GetObject<CharCategory>(CharCategory._members.StaticFields.GetObjectValue("SURROGATE.Lkotlin/text/CharCategory;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x060006A1 RID: 1697 RVA: 0x00010B24 File Offset: 0x0000ED24
		[Register("TITLECASE_LETTER")]
		public static CharCategory TitlecaseLetter
		{
			get
			{
				return Java.Lang.Object.GetObject<CharCategory>(CharCategory._members.StaticFields.GetObjectValue("TITLECASE_LETTER.Lkotlin/text/CharCategory;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x060006A2 RID: 1698 RVA: 0x00010B54 File Offset: 0x0000ED54
		[Register("UNASSIGNED")]
		public static CharCategory Unassigned
		{
			get
			{
				return Java.Lang.Object.GetObject<CharCategory>(CharCategory._members.StaticFields.GetObjectValue("UNASSIGNED.Lkotlin/text/CharCategory;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x060006A3 RID: 1699 RVA: 0x00010B84 File Offset: 0x0000ED84
		[Register("UPPERCASE_LETTER")]
		public static CharCategory UppercaseLetter
		{
			get
			{
				return Java.Lang.Object.GetObject<CharCategory>(CharCategory._members.StaticFields.GetObjectValue("UPPERCASE_LETTER.Lkotlin/text/CharCategory;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x060006A4 RID: 1700 RVA: 0x00010BB4 File Offset: 0x0000EDB4
		internal static IntPtr class_ref
		{
			get
			{
				return CharCategory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x060006A5 RID: 1701 RVA: 0x00010BD8 File Offset: 0x0000EDD8
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return CharCategory._members;
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x060006A6 RID: 1702 RVA: 0x00010BE0 File Offset: 0x0000EDE0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CharCategory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x060006A7 RID: 1703 RVA: 0x00010C04 File Offset: 0x0000EE04
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return CharCategory._members.ManagedPeerType;
			}
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x00010C10 File Offset: 0x0000EE10
		internal CharCategory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x060006A9 RID: 1705 RVA: 0x00010C1C File Offset: 0x0000EE1C
		[Nullable(1)]
		public string Code
		{
			[NullableContext(1)]
			[Register("getCode", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(CharCategory._members.InstanceMethods.InvokeNonvirtualObjectMethod("getCode.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x060006AA RID: 1706 RVA: 0x00010C50 File Offset: 0x0000EE50
		[Nullable(1)]
		public static IEnumEntries Entries
		{
			[NullableContext(1)]
			[Register("getEntries", "()Lkotlin/enums/EnumEntries;", "")]
			get
			{
				return Java.Lang.Object.GetObject<IEnumEntries>(CharCategory._members.StaticMethods.InvokeObjectMethod("getEntries.()Lkotlin/enums/EnumEntries;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x060006AB RID: 1707 RVA: 0x00010C81 File Offset: 0x0000EE81
		public int Value
		{
			[Register("getValue", "()I", "")]
			get
			{
				return CharCategory._members.InstanceMethods.InvokeNonvirtualInt32Method("getValue.()I", this, null);
			}
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x00010C9C File Offset: 0x0000EE9C
		[Register("contains", "(C)Z", "")]
		public unsafe bool Contains(char @char)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(@char);
			return CharCategory._members.InstanceMethods.InvokeNonvirtualBooleanMethod("contains.(C)Z", this, ptr);
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x00010CD8 File Offset: 0x0000EED8
		[Register("valueOf", "(Ljava/lang/String;)Lkotlin/text/CharCategory;", "")]
		public unsafe static CharCategory ValueOf(string value)
		{
			IntPtr intPtr = JNIEnv.NewString(value);
			CharCategory @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<CharCategory>(CharCategory._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lkotlin/text/CharCategory;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x00010D44 File Offset: 0x0000EF44
		[Register("values", "()[Lkotlin/text/CharCategory;", "")]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public static CharCategory[] Values()
		{
			return (CharCategory[])JNIEnv.GetArray(CharCategory._members.StaticMethods.InvokeObjectMethod("values.()[Lkotlin/text/CharCategory;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(CharCategory));
		}

		// Token: 0x040001C9 RID: 457
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/text/CharCategory", typeof(CharCategory));

		// Token: 0x020002DF RID: 735
		[NullableContext(1)]
		[Nullable(0)]
		[Register("kotlin/text/CharCategory$Companion", DoNotGenerateAcw = true)]
		public sealed class CompanionStatic : Java.Lang.Object
		{
			// Token: 0x17000A06 RID: 2566
			// (get) Token: 0x0600295E RID: 10590 RVA: 0x000B7E84 File Offset: 0x000B6084
			internal static IntPtr class_ref
			{
				get
				{
					return CharCategory.CompanionStatic._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000A07 RID: 2567
			// (get) Token: 0x0600295F RID: 10591 RVA: 0x000B7EA8 File Offset: 0x000B60A8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return CharCategory.CompanionStatic._members;
				}
			}

			// Token: 0x17000A08 RID: 2568
			// (get) Token: 0x06002960 RID: 10592 RVA: 0x000B7EB0 File Offset: 0x000B60B0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return CharCategory.CompanionStatic._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000A09 RID: 2569
			// (get) Token: 0x06002961 RID: 10593 RVA: 0x000B7ED4 File Offset: 0x000B60D4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return CharCategory.CompanionStatic._members.ManagedPeerType;
				}
			}

			// Token: 0x06002962 RID: 10594 RVA: 0x000B7EE0 File Offset: 0x000B60E0
			internal CompanionStatic(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06002963 RID: 10595 RVA: 0x000B7EEC File Offset: 0x000B60EC
			[NullableContext(2)]
			[Register(".ctor", "(Lkotlin/jvm/internal/DefaultConstructorMarker;)V", "")]
			public unsafe CompanionStatic(DefaultConstructorMarker _constructor_marker) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((_constructor_marker == null) ? IntPtr.Zero : _constructor_marker.Handle);
					base.SetHandle(CharCategory.CompanionStatic._members.InstanceMethods.StartCreateInstance("(Lkotlin/jvm/internal/DefaultConstructorMarker;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					CharCategory.CompanionStatic._members.InstanceMethods.FinishCreateInstance("(Lkotlin/jvm/internal/DefaultConstructorMarker;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(_constructor_marker);
				}
			}

			// Token: 0x06002964 RID: 10596 RVA: 0x000B7F9C File Offset: 0x000B619C
			[Register("valueOf", "(I)Lkotlin/text/CharCategory;", "")]
			public unsafe CharCategory ValueOf(int category)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(category);
				return Java.Lang.Object.GetObject<CharCategory>(CharCategory.CompanionStatic._members.InstanceMethods.InvokeNonvirtualObjectMethod("valueOf.(I)Lkotlin/text/CharCategory;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x040009D6 RID: 2518
			private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/text/CharCategory$Companion", typeof(CharCategory.CompanionStatic));
		}
	}
}
