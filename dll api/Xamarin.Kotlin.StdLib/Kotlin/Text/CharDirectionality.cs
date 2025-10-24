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
	// Token: 0x020000D9 RID: 217
	[NullableContext(2)]
	[Nullable(0)]
	[Register("kotlin/text/CharDirectionality", DoNotGenerateAcw = true)]
	public sealed class CharDirectionality : Java.Lang.Enum
	{
		// Token: 0x170001FB RID: 507
		// (get) Token: 0x060006B0 RID: 1712 RVA: 0x00010DA0 File Offset: 0x0000EFA0
		[Register("ARABIC_NUMBER")]
		public static CharDirectionality ArabicNumber
		{
			get
			{
				return Java.Lang.Object.GetObject<CharDirectionality>(CharDirectionality._members.StaticFields.GetObjectValue("ARABIC_NUMBER.Lkotlin/text/CharDirectionality;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x060006B1 RID: 1713 RVA: 0x00010DD0 File Offset: 0x0000EFD0
		[Register("BOUNDARY_NEUTRAL")]
		public static CharDirectionality BoundaryNeutral
		{
			get
			{
				return Java.Lang.Object.GetObject<CharDirectionality>(CharDirectionality._members.StaticFields.GetObjectValue("BOUNDARY_NEUTRAL.Lkotlin/text/CharDirectionality;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x060006B2 RID: 1714 RVA: 0x00010E00 File Offset: 0x0000F000
		[Register("COMMON_NUMBER_SEPARATOR")]
		public static CharDirectionality CommonNumberSeparator
		{
			get
			{
				return Java.Lang.Object.GetObject<CharDirectionality>(CharDirectionality._members.StaticFields.GetObjectValue("COMMON_NUMBER_SEPARATOR.Lkotlin/text/CharDirectionality;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x060006B3 RID: 1715 RVA: 0x00010E30 File Offset: 0x0000F030
		[Nullable(1)]
		[Register("Companion")]
		public static CharDirectionality.CompanionStatic Companion
		{
			[NullableContext(1)]
			get
			{
				return Java.Lang.Object.GetObject<CharDirectionality.CompanionStatic>(CharDirectionality._members.StaticFields.GetObjectValue("Companion.Lkotlin/text/CharDirectionality$Companion;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x060006B4 RID: 1716 RVA: 0x00010E60 File Offset: 0x0000F060
		[Register("EUROPEAN_NUMBER")]
		public static CharDirectionality EuropeanNumber
		{
			get
			{
				return Java.Lang.Object.GetObject<CharDirectionality>(CharDirectionality._members.StaticFields.GetObjectValue("EUROPEAN_NUMBER.Lkotlin/text/CharDirectionality;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x060006B5 RID: 1717 RVA: 0x00010E90 File Offset: 0x0000F090
		[Register("EUROPEAN_NUMBER_SEPARATOR")]
		public static CharDirectionality EuropeanNumberSeparator
		{
			get
			{
				return Java.Lang.Object.GetObject<CharDirectionality>(CharDirectionality._members.StaticFields.GetObjectValue("EUROPEAN_NUMBER_SEPARATOR.Lkotlin/text/CharDirectionality;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x060006B6 RID: 1718 RVA: 0x00010EC0 File Offset: 0x0000F0C0
		[Register("EUROPEAN_NUMBER_TERMINATOR")]
		public static CharDirectionality EuropeanNumberTerminator
		{
			get
			{
				return Java.Lang.Object.GetObject<CharDirectionality>(CharDirectionality._members.StaticFields.GetObjectValue("EUROPEAN_NUMBER_TERMINATOR.Lkotlin/text/CharDirectionality;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x060006B7 RID: 1719 RVA: 0x00010EF0 File Offset: 0x0000F0F0
		[Register("LEFT_TO_RIGHT")]
		public static CharDirectionality LeftToRight
		{
			get
			{
				return Java.Lang.Object.GetObject<CharDirectionality>(CharDirectionality._members.StaticFields.GetObjectValue("LEFT_TO_RIGHT.Lkotlin/text/CharDirectionality;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x060006B8 RID: 1720 RVA: 0x00010F20 File Offset: 0x0000F120
		[Register("LEFT_TO_RIGHT_EMBEDDING")]
		public static CharDirectionality LeftToRightEmbedding
		{
			get
			{
				return Java.Lang.Object.GetObject<CharDirectionality>(CharDirectionality._members.StaticFields.GetObjectValue("LEFT_TO_RIGHT_EMBEDDING.Lkotlin/text/CharDirectionality;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x060006B9 RID: 1721 RVA: 0x00010F50 File Offset: 0x0000F150
		[Register("LEFT_TO_RIGHT_OVERRIDE")]
		public static CharDirectionality LeftToRightOverride
		{
			get
			{
				return Java.Lang.Object.GetObject<CharDirectionality>(CharDirectionality._members.StaticFields.GetObjectValue("LEFT_TO_RIGHT_OVERRIDE.Lkotlin/text/CharDirectionality;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x060006BA RID: 1722 RVA: 0x00010F80 File Offset: 0x0000F180
		[Register("NONSPACING_MARK")]
		public static CharDirectionality NonspacingMark
		{
			get
			{
				return Java.Lang.Object.GetObject<CharDirectionality>(CharDirectionality._members.StaticFields.GetObjectValue("NONSPACING_MARK.Lkotlin/text/CharDirectionality;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x060006BB RID: 1723 RVA: 0x00010FB0 File Offset: 0x0000F1B0
		[Register("OTHER_NEUTRALS")]
		public static CharDirectionality OtherNeutrals
		{
			get
			{
				return Java.Lang.Object.GetObject<CharDirectionality>(CharDirectionality._members.StaticFields.GetObjectValue("OTHER_NEUTRALS.Lkotlin/text/CharDirectionality;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x060006BC RID: 1724 RVA: 0x00010FE0 File Offset: 0x0000F1E0
		[Register("PARAGRAPH_SEPARATOR")]
		public static CharDirectionality ParagraphSeparator
		{
			get
			{
				return Java.Lang.Object.GetObject<CharDirectionality>(CharDirectionality._members.StaticFields.GetObjectValue("PARAGRAPH_SEPARATOR.Lkotlin/text/CharDirectionality;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x060006BD RID: 1725 RVA: 0x00011010 File Offset: 0x0000F210
		[Register("POP_DIRECTIONAL_FORMAT")]
		public static CharDirectionality PopDirectionalFormat
		{
			get
			{
				return Java.Lang.Object.GetObject<CharDirectionality>(CharDirectionality._members.StaticFields.GetObjectValue("POP_DIRECTIONAL_FORMAT.Lkotlin/text/CharDirectionality;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x060006BE RID: 1726 RVA: 0x00011040 File Offset: 0x0000F240
		[Register("RIGHT_TO_LEFT")]
		public static CharDirectionality RightToLeft
		{
			get
			{
				return Java.Lang.Object.GetObject<CharDirectionality>(CharDirectionality._members.StaticFields.GetObjectValue("RIGHT_TO_LEFT.Lkotlin/text/CharDirectionality;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x060006BF RID: 1727 RVA: 0x00011070 File Offset: 0x0000F270
		[Register("RIGHT_TO_LEFT_ARABIC")]
		public static CharDirectionality RightToLeftArabic
		{
			get
			{
				return Java.Lang.Object.GetObject<CharDirectionality>(CharDirectionality._members.StaticFields.GetObjectValue("RIGHT_TO_LEFT_ARABIC.Lkotlin/text/CharDirectionality;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x060006C0 RID: 1728 RVA: 0x000110A0 File Offset: 0x0000F2A0
		[Register("RIGHT_TO_LEFT_EMBEDDING")]
		public static CharDirectionality RightToLeftEmbedding
		{
			get
			{
				return Java.Lang.Object.GetObject<CharDirectionality>(CharDirectionality._members.StaticFields.GetObjectValue("RIGHT_TO_LEFT_EMBEDDING.Lkotlin/text/CharDirectionality;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x060006C1 RID: 1729 RVA: 0x000110D0 File Offset: 0x0000F2D0
		[Register("RIGHT_TO_LEFT_OVERRIDE")]
		public static CharDirectionality RightToLeftOverride
		{
			get
			{
				return Java.Lang.Object.GetObject<CharDirectionality>(CharDirectionality._members.StaticFields.GetObjectValue("RIGHT_TO_LEFT_OVERRIDE.Lkotlin/text/CharDirectionality;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x060006C2 RID: 1730 RVA: 0x00011100 File Offset: 0x0000F300
		[Register("SEGMENT_SEPARATOR")]
		public static CharDirectionality SegmentSeparator
		{
			get
			{
				return Java.Lang.Object.GetObject<CharDirectionality>(CharDirectionality._members.StaticFields.GetObjectValue("SEGMENT_SEPARATOR.Lkotlin/text/CharDirectionality;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x060006C3 RID: 1731 RVA: 0x00011130 File Offset: 0x0000F330
		[Register("UNDEFINED")]
		public static CharDirectionality Undefined
		{
			get
			{
				return Java.Lang.Object.GetObject<CharDirectionality>(CharDirectionality._members.StaticFields.GetObjectValue("UNDEFINED.Lkotlin/text/CharDirectionality;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x060006C4 RID: 1732 RVA: 0x00011160 File Offset: 0x0000F360
		[Register("WHITESPACE")]
		public static CharDirectionality Whitespace
		{
			get
			{
				return Java.Lang.Object.GetObject<CharDirectionality>(CharDirectionality._members.StaticFields.GetObjectValue("WHITESPACE.Lkotlin/text/CharDirectionality;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x060006C5 RID: 1733 RVA: 0x00011190 File Offset: 0x0000F390
		internal static IntPtr class_ref
		{
			get
			{
				return CharDirectionality._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x060006C6 RID: 1734 RVA: 0x000111B4 File Offset: 0x0000F3B4
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return CharDirectionality._members;
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x060006C7 RID: 1735 RVA: 0x000111BC File Offset: 0x0000F3BC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CharDirectionality._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x060006C8 RID: 1736 RVA: 0x000111E0 File Offset: 0x0000F3E0
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return CharDirectionality._members.ManagedPeerType;
			}
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x000111EC File Offset: 0x0000F3EC
		internal CharDirectionality(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x060006CA RID: 1738 RVA: 0x000111F8 File Offset: 0x0000F3F8
		[Nullable(1)]
		public static IEnumEntries Entries
		{
			[NullableContext(1)]
			[Register("getEntries", "()Lkotlin/enums/EnumEntries;", "")]
			get
			{
				return Java.Lang.Object.GetObject<IEnumEntries>(CharDirectionality._members.StaticMethods.InvokeObjectMethod("getEntries.()Lkotlin/enums/EnumEntries;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x060006CB RID: 1739 RVA: 0x00011229 File Offset: 0x0000F429
		public int Value
		{
			[Register("getValue", "()I", "")]
			get
			{
				return CharDirectionality._members.InstanceMethods.InvokeNonvirtualInt32Method("getValue.()I", this, null);
			}
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x00011244 File Offset: 0x0000F444
		[Register("valueOf", "(Ljava/lang/String;)Lkotlin/text/CharDirectionality;", "")]
		public unsafe static CharDirectionality ValueOf(string value)
		{
			IntPtr intPtr = JNIEnv.NewString(value);
			CharDirectionality @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<CharDirectionality>(CharDirectionality._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lkotlin/text/CharDirectionality;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x000112B0 File Offset: 0x0000F4B0
		[Register("values", "()[Lkotlin/text/CharDirectionality;", "")]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public static CharDirectionality[] Values()
		{
			return (CharDirectionality[])JNIEnv.GetArray(CharDirectionality._members.StaticMethods.InvokeObjectMethod("values.()[Lkotlin/text/CharDirectionality;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(CharDirectionality));
		}

		// Token: 0x040001CA RID: 458
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/text/CharDirectionality", typeof(CharDirectionality));

		// Token: 0x020002E0 RID: 736
		[NullableContext(1)]
		[Nullable(0)]
		[Register("kotlin/text/CharDirectionality$Companion", DoNotGenerateAcw = true)]
		public sealed class CompanionStatic : Java.Lang.Object
		{
			// Token: 0x17000A0A RID: 2570
			// (get) Token: 0x06002966 RID: 10598 RVA: 0x000B8000 File Offset: 0x000B6200
			internal static IntPtr class_ref
			{
				get
				{
					return CharDirectionality.CompanionStatic._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000A0B RID: 2571
			// (get) Token: 0x06002967 RID: 10599 RVA: 0x000B8024 File Offset: 0x000B6224
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return CharDirectionality.CompanionStatic._members;
				}
			}

			// Token: 0x17000A0C RID: 2572
			// (get) Token: 0x06002968 RID: 10600 RVA: 0x000B802C File Offset: 0x000B622C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return CharDirectionality.CompanionStatic._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000A0D RID: 2573
			// (get) Token: 0x06002969 RID: 10601 RVA: 0x000B8050 File Offset: 0x000B6250
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return CharDirectionality.CompanionStatic._members.ManagedPeerType;
				}
			}

			// Token: 0x0600296A RID: 10602 RVA: 0x000B805C File Offset: 0x000B625C
			internal CompanionStatic(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x0600296B RID: 10603 RVA: 0x000B8068 File Offset: 0x000B6268
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
					base.SetHandle(CharDirectionality.CompanionStatic._members.InstanceMethods.StartCreateInstance("(Lkotlin/jvm/internal/DefaultConstructorMarker;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					CharDirectionality.CompanionStatic._members.InstanceMethods.FinishCreateInstance("(Lkotlin/jvm/internal/DefaultConstructorMarker;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(_constructor_marker);
				}
			}

			// Token: 0x0600296C RID: 10604 RVA: 0x000B8118 File Offset: 0x000B6318
			[Register("valueOf", "(I)Lkotlin/text/CharDirectionality;", "")]
			public unsafe CharDirectionality ValueOf(int directionality)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(directionality);
				return Java.Lang.Object.GetObject<CharDirectionality>(CharDirectionality.CompanionStatic._members.InstanceMethods.InvokeNonvirtualObjectMethod("valueOf.(I)Lkotlin/text/CharDirectionality;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x040009D7 RID: 2519
			private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/text/CharDirectionality$Companion", typeof(CharDirectionality.CompanionStatic));
		}
	}
}
