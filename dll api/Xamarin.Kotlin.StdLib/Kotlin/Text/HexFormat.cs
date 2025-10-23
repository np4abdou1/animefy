using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Jvm.Internal;

namespace Kotlin.Text
{
	// Token: 0x020000DE RID: 222
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/text/HexFormat", DoNotGenerateAcw = true)]
	public sealed class HexFormat : Java.Lang.Object
	{
		// Token: 0x1700022D RID: 557
		// (get) Token: 0x0600070D RID: 1805 RVA: 0x000122E4 File Offset: 0x000104E4
		[Register("Companion")]
		public static HexFormat.CompanionStatic Companion
		{
			get
			{
				return Java.Lang.Object.GetObject<HexFormat.CompanionStatic>(HexFormat._members.StaticFields.GetObjectValue("Companion.Lkotlin/text/HexFormat$Companion;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x0600070E RID: 1806 RVA: 0x00012314 File Offset: 0x00010514
		internal static IntPtr class_ref
		{
			get
			{
				return HexFormat._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x0600070F RID: 1807 RVA: 0x00012338 File Offset: 0x00010538
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return HexFormat._members;
			}
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06000710 RID: 1808 RVA: 0x00012340 File Offset: 0x00010540
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return HexFormat._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06000711 RID: 1809 RVA: 0x00012364 File Offset: 0x00010564
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return HexFormat._members.ManagedPeerType;
			}
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x00012370 File Offset: 0x00010570
		internal HexFormat(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06000713 RID: 1811 RVA: 0x0001237C File Offset: 0x0001057C
		public HexFormat.BytesHexFormat Bytes
		{
			[Register("getBytes", "()Lkotlin/text/HexFormat$BytesHexFormat;", "")]
			get
			{
				return Java.Lang.Object.GetObject<HexFormat.BytesHexFormat>(HexFormat._members.InstanceMethods.InvokeNonvirtualObjectMethod("getBytes.()Lkotlin/text/HexFormat$BytesHexFormat;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x06000714 RID: 1812 RVA: 0x000123B0 File Offset: 0x000105B0
		public HexFormat.NumberHexFormat Number
		{
			[Register("getNumber", "()Lkotlin/text/HexFormat$NumberHexFormat;", "")]
			get
			{
				return Java.Lang.Object.GetObject<HexFormat.NumberHexFormat>(HexFormat._members.InstanceMethods.InvokeNonvirtualObjectMethod("getNumber.()Lkotlin/text/HexFormat$NumberHexFormat;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x06000715 RID: 1813 RVA: 0x000123E2 File Offset: 0x000105E2
		public bool UpperCase
		{
			[Register("getUpperCase", "()Z", "")]
			get
			{
				return HexFormat._members.InstanceMethods.InvokeNonvirtualBooleanMethod("getUpperCase.()Z", this, null);
			}
		}

		// Token: 0x040001CF RID: 463
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/text/HexFormat", typeof(HexFormat));

		// Token: 0x020002E1 RID: 737
		[Nullable(0)]
		[Register("kotlin/text/HexFormat$Builder", DoNotGenerateAcw = true)]
		public sealed class Builder : Java.Lang.Object
		{
			// Token: 0x17000A0E RID: 2574
			// (get) Token: 0x0600296E RID: 10606 RVA: 0x000B817C File Offset: 0x000B637C
			internal static IntPtr class_ref
			{
				get
				{
					return HexFormat.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000A0F RID: 2575
			// (get) Token: 0x0600296F RID: 10607 RVA: 0x000B81A0 File Offset: 0x000B63A0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return HexFormat.Builder._members;
				}
			}

			// Token: 0x17000A10 RID: 2576
			// (get) Token: 0x06002970 RID: 10608 RVA: 0x000B81A8 File Offset: 0x000B63A8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return HexFormat.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000A11 RID: 2577
			// (get) Token: 0x06002971 RID: 10609 RVA: 0x000B81CC File Offset: 0x000B63CC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return HexFormat.Builder._members.ManagedPeerType;
				}
			}

			// Token: 0x06002972 RID: 10610 RVA: 0x000B81D8 File Offset: 0x000B63D8
			internal Builder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x17000A12 RID: 2578
			// (get) Token: 0x06002973 RID: 10611 RVA: 0x000B81E4 File Offset: 0x000B63E4
			public HexFormat.BytesHexFormat.Builder Bytes
			{
				[Register("getBytes", "()Lkotlin/text/HexFormat$BytesHexFormat$Builder;", "")]
				get
				{
					return Java.Lang.Object.GetObject<HexFormat.BytesHexFormat.Builder>(HexFormat.Builder._members.InstanceMethods.InvokeNonvirtualObjectMethod("getBytes.()Lkotlin/text/HexFormat$BytesHexFormat$Builder;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000A13 RID: 2579
			// (get) Token: 0x06002974 RID: 10612 RVA: 0x000B8218 File Offset: 0x000B6418
			public HexFormat.NumberHexFormat.Builder Number
			{
				[Register("getNumber", "()Lkotlin/text/HexFormat$NumberHexFormat$Builder;", "")]
				get
				{
					return Java.Lang.Object.GetObject<HexFormat.NumberHexFormat.Builder>(HexFormat.Builder._members.InstanceMethods.InvokeNonvirtualObjectMethod("getNumber.()Lkotlin/text/HexFormat$NumberHexFormat$Builder;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000A14 RID: 2580
			// (get) Token: 0x06002975 RID: 10613 RVA: 0x000B824A File Offset: 0x000B644A
			// (set) Token: 0x06002976 RID: 10614 RVA: 0x000B8264 File Offset: 0x000B6464
			public unsafe bool UpperCase
			{
				[Register("getUpperCase", "()Z", "")]
				get
				{
					return HexFormat.Builder._members.InstanceMethods.InvokeNonvirtualBooleanMethod("getUpperCase.()Z", this, null);
				}
				[Register("setUpperCase", "(Z)V", "")]
				set
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(value);
					HexFormat.Builder._members.InstanceMethods.InvokeNonvirtualVoidMethod("setUpperCase.(Z)V", this, ptr);
				}
			}

			// Token: 0x040009D8 RID: 2520
			private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/text/HexFormat$Builder", typeof(HexFormat.Builder));
		}

		// Token: 0x020002E2 RID: 738
		[Nullable(0)]
		[Register("kotlin/text/HexFormat$BytesHexFormat", DoNotGenerateAcw = true)]
		public sealed class BytesHexFormat : Java.Lang.Object
		{
			// Token: 0x17000A15 RID: 2581
			// (get) Token: 0x06002978 RID: 10616 RVA: 0x000B82BC File Offset: 0x000B64BC
			internal static IntPtr class_ref
			{
				get
				{
					return HexFormat.BytesHexFormat._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000A16 RID: 2582
			// (get) Token: 0x06002979 RID: 10617 RVA: 0x000B82E0 File Offset: 0x000B64E0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return HexFormat.BytesHexFormat._members;
				}
			}

			// Token: 0x17000A17 RID: 2583
			// (get) Token: 0x0600297A RID: 10618 RVA: 0x000B82E8 File Offset: 0x000B64E8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return HexFormat.BytesHexFormat._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000A18 RID: 2584
			// (get) Token: 0x0600297B RID: 10619 RVA: 0x000B830C File Offset: 0x000B650C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return HexFormat.BytesHexFormat._members.ManagedPeerType;
				}
			}

			// Token: 0x0600297C RID: 10620 RVA: 0x000B8318 File Offset: 0x000B6518
			internal BytesHexFormat(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x17000A19 RID: 2585
			// (get) Token: 0x0600297D RID: 10621 RVA: 0x000B8324 File Offset: 0x000B6524
			public string BytePrefix
			{
				[Register("getBytePrefix", "()Ljava/lang/String;", "")]
				get
				{
					return JNIEnv.GetString(HexFormat.BytesHexFormat._members.InstanceMethods.InvokeNonvirtualObjectMethod("getBytePrefix.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000A1A RID: 2586
			// (get) Token: 0x0600297E RID: 10622 RVA: 0x000B8358 File Offset: 0x000B6558
			public string ByteSeparator
			{
				[Register("getByteSeparator", "()Ljava/lang/String;", "")]
				get
				{
					return JNIEnv.GetString(HexFormat.BytesHexFormat._members.InstanceMethods.InvokeNonvirtualObjectMethod("getByteSeparator.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000A1B RID: 2587
			// (get) Token: 0x0600297F RID: 10623 RVA: 0x000B838C File Offset: 0x000B658C
			public string ByteSuffix
			{
				[Register("getByteSuffix", "()Ljava/lang/String;", "")]
				get
				{
					return JNIEnv.GetString(HexFormat.BytesHexFormat._members.InstanceMethods.InvokeNonvirtualObjectMethod("getByteSuffix.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000A1C RID: 2588
			// (get) Token: 0x06002980 RID: 10624 RVA: 0x000B83BE File Offset: 0x000B65BE
			public int BytesPerGroup
			{
				[Register("getBytesPerGroup", "()I", "")]
				get
				{
					return HexFormat.BytesHexFormat._members.InstanceMethods.InvokeNonvirtualInt32Method("getBytesPerGroup.()I", this, null);
				}
			}

			// Token: 0x17000A1D RID: 2589
			// (get) Token: 0x06002981 RID: 10625 RVA: 0x000B83D7 File Offset: 0x000B65D7
			public int BytesPerLine
			{
				[Register("getBytesPerLine", "()I", "")]
				get
				{
					return HexFormat.BytesHexFormat._members.InstanceMethods.InvokeNonvirtualInt32Method("getBytesPerLine.()I", this, null);
				}
			}

			// Token: 0x17000A1E RID: 2590
			// (get) Token: 0x06002982 RID: 10626 RVA: 0x000B83F0 File Offset: 0x000B65F0
			public string GroupSeparator
			{
				[Register("getGroupSeparator", "()Ljava/lang/String;", "")]
				get
				{
					return JNIEnv.GetString(HexFormat.BytesHexFormat._members.InstanceMethods.InvokeNonvirtualObjectMethod("getGroupSeparator.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x040009D9 RID: 2521
			private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/text/HexFormat$BytesHexFormat", typeof(HexFormat.BytesHexFormat));

			// Token: 0x02000303 RID: 771
			[Nullable(0)]
			[Register("kotlin/text/HexFormat$BytesHexFormat$Builder", DoNotGenerateAcw = true)]
			public sealed class Builder : Java.Lang.Object
			{
				// Token: 0x17000AB4 RID: 2740
				// (get) Token: 0x06002A8C RID: 10892 RVA: 0x000BAFAC File Offset: 0x000B91AC
				internal static IntPtr class_ref
				{
					get
					{
						return HexFormat.BytesHexFormat.Builder._members.JniPeerType.PeerReference.Handle;
					}
				}

				// Token: 0x17000AB5 RID: 2741
				// (get) Token: 0x06002A8D RID: 10893 RVA: 0x000BAFD0 File Offset: 0x000B91D0
				[DebuggerBrowsable(DebuggerBrowsableState.Never)]
				[EditorBrowsable(EditorBrowsableState.Never)]
				public override JniPeerMembers JniPeerMembers
				{
					get
					{
						return HexFormat.BytesHexFormat.Builder._members;
					}
				}

				// Token: 0x17000AB6 RID: 2742
				// (get) Token: 0x06002A8E RID: 10894 RVA: 0x000BAFD8 File Offset: 0x000B91D8
				[DebuggerBrowsable(DebuggerBrowsableState.Never)]
				[EditorBrowsable(EditorBrowsableState.Never)]
				protected override IntPtr ThresholdClass
				{
					get
					{
						return HexFormat.BytesHexFormat.Builder._members.JniPeerType.PeerReference.Handle;
					}
				}

				// Token: 0x17000AB7 RID: 2743
				// (get) Token: 0x06002A8F RID: 10895 RVA: 0x000BAFFC File Offset: 0x000B91FC
				[DebuggerBrowsable(DebuggerBrowsableState.Never)]
				[EditorBrowsable(EditorBrowsableState.Never)]
				protected override Type ThresholdType
				{
					get
					{
						return HexFormat.BytesHexFormat.Builder._members.ManagedPeerType;
					}
				}

				// Token: 0x06002A90 RID: 10896 RVA: 0x000BB008 File Offset: 0x000B9208
				internal Builder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
				{
				}

				// Token: 0x17000AB8 RID: 2744
				// (get) Token: 0x06002A91 RID: 10897 RVA: 0x000BB014 File Offset: 0x000B9214
				// (set) Token: 0x06002A92 RID: 10898 RVA: 0x000BB048 File Offset: 0x000B9248
				public unsafe string BytePrefix
				{
					[Register("getBytePrefix", "()Ljava/lang/String;", "")]
					get
					{
						return JNIEnv.GetString(HexFormat.BytesHexFormat.Builder._members.InstanceMethods.InvokeNonvirtualObjectMethod("getBytePrefix.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
					}
					[Register("setBytePrefix", "(Ljava/lang/String;)V", "")]
					set
					{
						IntPtr intPtr = JNIEnv.NewString(value);
						try
						{
							JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
							*ptr = new JniArgumentValue(intPtr);
							HexFormat.BytesHexFormat.Builder._members.InstanceMethods.InvokeNonvirtualVoidMethod("setBytePrefix.(Ljava/lang/String;)V", this, ptr);
						}
						finally
						{
							JNIEnv.DeleteLocalRef(intPtr);
						}
					}
				}

				// Token: 0x17000AB9 RID: 2745
				// (get) Token: 0x06002A93 RID: 10899 RVA: 0x000BB0A4 File Offset: 0x000B92A4
				// (set) Token: 0x06002A94 RID: 10900 RVA: 0x000BB0D8 File Offset: 0x000B92D8
				public unsafe string ByteSeparator
				{
					[Register("getByteSeparator", "()Ljava/lang/String;", "")]
					get
					{
						return JNIEnv.GetString(HexFormat.BytesHexFormat.Builder._members.InstanceMethods.InvokeNonvirtualObjectMethod("getByteSeparator.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
					}
					[Register("setByteSeparator", "(Ljava/lang/String;)V", "")]
					set
					{
						IntPtr intPtr = JNIEnv.NewString(value);
						try
						{
							JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
							*ptr = new JniArgumentValue(intPtr);
							HexFormat.BytesHexFormat.Builder._members.InstanceMethods.InvokeNonvirtualVoidMethod("setByteSeparator.(Ljava/lang/String;)V", this, ptr);
						}
						finally
						{
							JNIEnv.DeleteLocalRef(intPtr);
						}
					}
				}

				// Token: 0x17000ABA RID: 2746
				// (get) Token: 0x06002A95 RID: 10901 RVA: 0x000BB134 File Offset: 0x000B9334
				// (set) Token: 0x06002A96 RID: 10902 RVA: 0x000BB168 File Offset: 0x000B9368
				public unsafe string ByteSuffix
				{
					[Register("getByteSuffix", "()Ljava/lang/String;", "")]
					get
					{
						return JNIEnv.GetString(HexFormat.BytesHexFormat.Builder._members.InstanceMethods.InvokeNonvirtualObjectMethod("getByteSuffix.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
					}
					[Register("setByteSuffix", "(Ljava/lang/String;)V", "")]
					set
					{
						IntPtr intPtr = JNIEnv.NewString(value);
						try
						{
							JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
							*ptr = new JniArgumentValue(intPtr);
							HexFormat.BytesHexFormat.Builder._members.InstanceMethods.InvokeNonvirtualVoidMethod("setByteSuffix.(Ljava/lang/String;)V", this, ptr);
						}
						finally
						{
							JNIEnv.DeleteLocalRef(intPtr);
						}
					}
				}

				// Token: 0x17000ABB RID: 2747
				// (get) Token: 0x06002A97 RID: 10903 RVA: 0x000BB1C4 File Offset: 0x000B93C4
				// (set) Token: 0x06002A98 RID: 10904 RVA: 0x000BB1E0 File Offset: 0x000B93E0
				public unsafe int BytesPerGroup
				{
					[Register("getBytesPerGroup", "()I", "")]
					get
					{
						return HexFormat.BytesHexFormat.Builder._members.InstanceMethods.InvokeNonvirtualInt32Method("getBytesPerGroup.()I", this, null);
					}
					[Register("setBytesPerGroup", "(I)V", "")]
					set
					{
						JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
						*ptr = new JniArgumentValue(value);
						HexFormat.BytesHexFormat.Builder._members.InstanceMethods.InvokeNonvirtualVoidMethod("setBytesPerGroup.(I)V", this, ptr);
					}
				}

				// Token: 0x17000ABC RID: 2748
				// (get) Token: 0x06002A99 RID: 10905 RVA: 0x000BB21B File Offset: 0x000B941B
				// (set) Token: 0x06002A9A RID: 10906 RVA: 0x000BB234 File Offset: 0x000B9434
				public unsafe int BytesPerLine
				{
					[Register("getBytesPerLine", "()I", "")]
					get
					{
						return HexFormat.BytesHexFormat.Builder._members.InstanceMethods.InvokeNonvirtualInt32Method("getBytesPerLine.()I", this, null);
					}
					[Register("setBytesPerLine", "(I)V", "")]
					set
					{
						JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
						*ptr = new JniArgumentValue(value);
						HexFormat.BytesHexFormat.Builder._members.InstanceMethods.InvokeNonvirtualVoidMethod("setBytesPerLine.(I)V", this, ptr);
					}
				}

				// Token: 0x17000ABD RID: 2749
				// (get) Token: 0x06002A9B RID: 10907 RVA: 0x000BB270 File Offset: 0x000B9470
				// (set) Token: 0x06002A9C RID: 10908 RVA: 0x000BB2A4 File Offset: 0x000B94A4
				public unsafe string GroupSeparator
				{
					[Register("getGroupSeparator", "()Ljava/lang/String;", "")]
					get
					{
						return JNIEnv.GetString(HexFormat.BytesHexFormat.Builder._members.InstanceMethods.InvokeNonvirtualObjectMethod("getGroupSeparator.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
					}
					[Register("setGroupSeparator", "(Ljava/lang/String;)V", "")]
					set
					{
						IntPtr intPtr = JNIEnv.NewString(value);
						try
						{
							JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
							*ptr = new JniArgumentValue(intPtr);
							HexFormat.BytesHexFormat.Builder._members.InstanceMethods.InvokeNonvirtualVoidMethod("setGroupSeparator.(Ljava/lang/String;)V", this, ptr);
						}
						finally
						{
							JNIEnv.DeleteLocalRef(intPtr);
						}
					}
				}

				// Token: 0x040009FA RID: 2554
				private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/text/HexFormat$BytesHexFormat$Builder", typeof(HexFormat.BytesHexFormat.Builder));
			}
		}

		// Token: 0x020002E3 RID: 739
		[Nullable(0)]
		[Register("kotlin/text/HexFormat$Companion", DoNotGenerateAcw = true)]
		public sealed class CompanionStatic : Java.Lang.Object
		{
			// Token: 0x17000A1F RID: 2591
			// (get) Token: 0x06002984 RID: 10628 RVA: 0x000B8440 File Offset: 0x000B6640
			internal static IntPtr class_ref
			{
				get
				{
					return HexFormat.CompanionStatic._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000A20 RID: 2592
			// (get) Token: 0x06002985 RID: 10629 RVA: 0x000B8464 File Offset: 0x000B6664
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return HexFormat.CompanionStatic._members;
				}
			}

			// Token: 0x17000A21 RID: 2593
			// (get) Token: 0x06002986 RID: 10630 RVA: 0x000B846C File Offset: 0x000B666C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return HexFormat.CompanionStatic._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000A22 RID: 2594
			// (get) Token: 0x06002987 RID: 10631 RVA: 0x000B8490 File Offset: 0x000B6690
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return HexFormat.CompanionStatic._members.ManagedPeerType;
				}
			}

			// Token: 0x06002988 RID: 10632 RVA: 0x000B849C File Offset: 0x000B669C
			internal CompanionStatic(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06002989 RID: 10633 RVA: 0x000B84A8 File Offset: 0x000B66A8
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
					base.SetHandle(HexFormat.CompanionStatic._members.InstanceMethods.StartCreateInstance("(Lkotlin/jvm/internal/DefaultConstructorMarker;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					HexFormat.CompanionStatic._members.InstanceMethods.FinishCreateInstance("(Lkotlin/jvm/internal/DefaultConstructorMarker;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(_constructor_marker);
				}
			}

			// Token: 0x17000A23 RID: 2595
			// (get) Token: 0x0600298A RID: 10634 RVA: 0x000B8558 File Offset: 0x000B6758
			public HexFormat Default
			{
				[Register("getDefault", "()Lkotlin/text/HexFormat;", "")]
				get
				{
					return Java.Lang.Object.GetObject<HexFormat>(HexFormat.CompanionStatic._members.InstanceMethods.InvokeNonvirtualObjectMethod("getDefault.()Lkotlin/text/HexFormat;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000A24 RID: 2596
			// (get) Token: 0x0600298B RID: 10635 RVA: 0x000B858C File Offset: 0x000B678C
			public HexFormat UpperCase
			{
				[Register("getUpperCase", "()Lkotlin/text/HexFormat;", "")]
				get
				{
					return Java.Lang.Object.GetObject<HexFormat>(HexFormat.CompanionStatic._members.InstanceMethods.InvokeNonvirtualObjectMethod("getUpperCase.()Lkotlin/text/HexFormat;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x040009DA RID: 2522
			private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/text/HexFormat$Companion", typeof(HexFormat.CompanionStatic));
		}

		// Token: 0x020002E4 RID: 740
		[Nullable(0)]
		[Register("kotlin/text/HexFormat$NumberHexFormat", DoNotGenerateAcw = true)]
		public sealed class NumberHexFormat : Java.Lang.Object
		{
			// Token: 0x17000A25 RID: 2597
			// (get) Token: 0x0600298D RID: 10637 RVA: 0x000B85DC File Offset: 0x000B67DC
			internal static IntPtr class_ref
			{
				get
				{
					return HexFormat.NumberHexFormat._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000A26 RID: 2598
			// (get) Token: 0x0600298E RID: 10638 RVA: 0x000B8600 File Offset: 0x000B6800
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return HexFormat.NumberHexFormat._members;
				}
			}

			// Token: 0x17000A27 RID: 2599
			// (get) Token: 0x0600298F RID: 10639 RVA: 0x000B8608 File Offset: 0x000B6808
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return HexFormat.NumberHexFormat._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000A28 RID: 2600
			// (get) Token: 0x06002990 RID: 10640 RVA: 0x000B862C File Offset: 0x000B682C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return HexFormat.NumberHexFormat._members.ManagedPeerType;
				}
			}

			// Token: 0x06002991 RID: 10641 RVA: 0x000B8638 File Offset: 0x000B6838
			internal NumberHexFormat(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x17000A29 RID: 2601
			// (get) Token: 0x06002992 RID: 10642 RVA: 0x000B8644 File Offset: 0x000B6844
			public string Prefix
			{
				[Register("getPrefix", "()Ljava/lang/String;", "")]
				get
				{
					return JNIEnv.GetString(HexFormat.NumberHexFormat._members.InstanceMethods.InvokeNonvirtualObjectMethod("getPrefix.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000A2A RID: 2602
			// (get) Token: 0x06002993 RID: 10643 RVA: 0x000B8676 File Offset: 0x000B6876
			public bool RemoveLeadingZeros
			{
				[Register("getRemoveLeadingZeros", "()Z", "")]
				get
				{
					return HexFormat.NumberHexFormat._members.InstanceMethods.InvokeNonvirtualBooleanMethod("getRemoveLeadingZeros.()Z", this, null);
				}
			}

			// Token: 0x17000A2B RID: 2603
			// (get) Token: 0x06002994 RID: 10644 RVA: 0x000B8690 File Offset: 0x000B6890
			public string Suffix
			{
				[Register("getSuffix", "()Ljava/lang/String;", "")]
				get
				{
					return JNIEnv.GetString(HexFormat.NumberHexFormat._members.InstanceMethods.InvokeNonvirtualObjectMethod("getSuffix.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x040009DB RID: 2523
			private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/text/HexFormat$NumberHexFormat", typeof(HexFormat.NumberHexFormat));

			// Token: 0x02000304 RID: 772
			[Nullable(0)]
			[Register("kotlin/text/HexFormat$NumberHexFormat$Builder", DoNotGenerateAcw = true)]
			public sealed class Builder : Java.Lang.Object
			{
				// Token: 0x17000ABE RID: 2750
				// (get) Token: 0x06002A9E RID: 10910 RVA: 0x000BB31C File Offset: 0x000B951C
				internal static IntPtr class_ref
				{
					get
					{
						return HexFormat.NumberHexFormat.Builder._members.JniPeerType.PeerReference.Handle;
					}
				}

				// Token: 0x17000ABF RID: 2751
				// (get) Token: 0x06002A9F RID: 10911 RVA: 0x000BB340 File Offset: 0x000B9540
				[DebuggerBrowsable(DebuggerBrowsableState.Never)]
				[EditorBrowsable(EditorBrowsableState.Never)]
				public override JniPeerMembers JniPeerMembers
				{
					get
					{
						return HexFormat.NumberHexFormat.Builder._members;
					}
				}

				// Token: 0x17000AC0 RID: 2752
				// (get) Token: 0x06002AA0 RID: 10912 RVA: 0x000BB348 File Offset: 0x000B9548
				[DebuggerBrowsable(DebuggerBrowsableState.Never)]
				[EditorBrowsable(EditorBrowsableState.Never)]
				protected override IntPtr ThresholdClass
				{
					get
					{
						return HexFormat.NumberHexFormat.Builder._members.JniPeerType.PeerReference.Handle;
					}
				}

				// Token: 0x17000AC1 RID: 2753
				// (get) Token: 0x06002AA1 RID: 10913 RVA: 0x000BB36C File Offset: 0x000B956C
				[DebuggerBrowsable(DebuggerBrowsableState.Never)]
				[EditorBrowsable(EditorBrowsableState.Never)]
				protected override Type ThresholdType
				{
					get
					{
						return HexFormat.NumberHexFormat.Builder._members.ManagedPeerType;
					}
				}

				// Token: 0x06002AA2 RID: 10914 RVA: 0x000BB378 File Offset: 0x000B9578
				internal Builder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
				{
				}

				// Token: 0x17000AC2 RID: 2754
				// (get) Token: 0x06002AA3 RID: 10915 RVA: 0x000BB384 File Offset: 0x000B9584
				// (set) Token: 0x06002AA4 RID: 10916 RVA: 0x000BB3B8 File Offset: 0x000B95B8
				public unsafe string Prefix
				{
					[Register("getPrefix", "()Ljava/lang/String;", "")]
					get
					{
						return JNIEnv.GetString(HexFormat.NumberHexFormat.Builder._members.InstanceMethods.InvokeNonvirtualObjectMethod("getPrefix.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
					}
					[Register("setPrefix", "(Ljava/lang/String;)V", "")]
					set
					{
						IntPtr intPtr = JNIEnv.NewString(value);
						try
						{
							JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
							*ptr = new JniArgumentValue(intPtr);
							HexFormat.NumberHexFormat.Builder._members.InstanceMethods.InvokeNonvirtualVoidMethod("setPrefix.(Ljava/lang/String;)V", this, ptr);
						}
						finally
						{
							JNIEnv.DeleteLocalRef(intPtr);
						}
					}
				}

				// Token: 0x17000AC3 RID: 2755
				// (get) Token: 0x06002AA5 RID: 10917 RVA: 0x000BB414 File Offset: 0x000B9614
				// (set) Token: 0x06002AA6 RID: 10918 RVA: 0x000BB430 File Offset: 0x000B9630
				public unsafe bool RemoveLeadingZeros
				{
					[Register("getRemoveLeadingZeros", "()Z", "")]
					get
					{
						return HexFormat.NumberHexFormat.Builder._members.InstanceMethods.InvokeNonvirtualBooleanMethod("getRemoveLeadingZeros.()Z", this, null);
					}
					[Register("setRemoveLeadingZeros", "(Z)V", "")]
					set
					{
						JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
						*ptr = new JniArgumentValue(value);
						HexFormat.NumberHexFormat.Builder._members.InstanceMethods.InvokeNonvirtualVoidMethod("setRemoveLeadingZeros.(Z)V", this, ptr);
					}
				}

				// Token: 0x17000AC4 RID: 2756
				// (get) Token: 0x06002AA7 RID: 10919 RVA: 0x000BB46C File Offset: 0x000B966C
				// (set) Token: 0x06002AA8 RID: 10920 RVA: 0x000BB4A0 File Offset: 0x000B96A0
				public unsafe string Suffix
				{
					[Register("getSuffix", "()Ljava/lang/String;", "")]
					get
					{
						return JNIEnv.GetString(HexFormat.NumberHexFormat.Builder._members.InstanceMethods.InvokeNonvirtualObjectMethod("getSuffix.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
					}
					[Register("setSuffix", "(Ljava/lang/String;)V", "")]
					set
					{
						IntPtr intPtr = JNIEnv.NewString(value);
						try
						{
							JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
							*ptr = new JniArgumentValue(intPtr);
							HexFormat.NumberHexFormat.Builder._members.InstanceMethods.InvokeNonvirtualVoidMethod("setSuffix.(Ljava/lang/String;)V", this, ptr);
						}
						finally
						{
							JNIEnv.DeleteLocalRef(intPtr);
						}
					}
				}

				// Token: 0x040009FB RID: 2555
				private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/text/HexFormat$NumberHexFormat$Builder", typeof(HexFormat.NumberHexFormat.Builder));
			}
		}
	}
}
