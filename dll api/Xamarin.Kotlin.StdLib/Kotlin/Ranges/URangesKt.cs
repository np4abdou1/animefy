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
	// Token: 0x020002A8 RID: 680
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/ranges/URangesKt", DoNotGenerateAcw = true)]
	public sealed class URangesKt : Java.Lang.Object
	{
		// Token: 0x17000935 RID: 2357
		// (get) Token: 0x06001F37 RID: 7991 RVA: 0x00068380 File Offset: 0x00066580
		internal static IntPtr class_ref
		{
			get
			{
				return URangesKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000936 RID: 2358
		// (get) Token: 0x06001F38 RID: 7992 RVA: 0x000683A4 File Offset: 0x000665A4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return URangesKt._members;
			}
		}

		// Token: 0x17000937 RID: 2359
		// (get) Token: 0x06001F39 RID: 7993 RVA: 0x000683AC File Offset: 0x000665AC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return URangesKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000938 RID: 2360
		// (get) Token: 0x06001F3A RID: 7994 RVA: 0x000683D0 File Offset: 0x000665D0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return URangesKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06001F3B RID: 7995 RVA: 0x000683DC File Offset: 0x000665DC
		internal URangesKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001F3C RID: 7996 RVA: 0x000683E8 File Offset: 0x000665E8
		[Register("coerceAtLeast-5PvTz6A", "(SS)S", "")]
		public unsafe static short CoerceAtLeast(short _this_coerceAtLeast_u2d5PvTz6A, short minimumValue)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_coerceAtLeast_u2d5PvTz6A);
			ptr[1] = new JniArgumentValue(minimumValue);
			return URangesKt._members.StaticMethods.InvokeInt16Method("coerceAtLeast-5PvTz6A.(SS)S", ptr);
		}

		// Token: 0x06001F3D RID: 7997 RVA: 0x00068438 File Offset: 0x00066638
		[Register("coerceAtLeast-J1ME1BU", "(II)I", "")]
		public unsafe static int CoerceAtLeast(int _this_coerceAtLeast_u2dJ1ME1BU, int minimumValue)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_coerceAtLeast_u2dJ1ME1BU);
			ptr[1] = new JniArgumentValue(minimumValue);
			return URangesKt._members.StaticMethods.InvokeInt32Method("coerceAtLeast-J1ME1BU.(II)I", ptr);
		}

		// Token: 0x06001F3E RID: 7998 RVA: 0x00068488 File Offset: 0x00066688
		[Register("coerceAtLeast-Kr8caGY", "(BB)B", "")]
		public unsafe static sbyte CoerceAtLeast(sbyte _this_coerceAtLeast_u2dKr8caGY, sbyte minimumValue)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_coerceAtLeast_u2dKr8caGY);
			ptr[1] = new JniArgumentValue(minimumValue);
			return URangesKt._members.StaticMethods.InvokeSByteMethod("coerceAtLeast-Kr8caGY.(BB)B", ptr);
		}

		// Token: 0x06001F3F RID: 7999 RVA: 0x000684D8 File Offset: 0x000666D8
		[Register("coerceAtLeast-eb3DHEI", "(JJ)J", "")]
		public unsafe static long CoerceAtLeast(long _this_coerceAtLeast_u2deb3DHEI, long minimumValue)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_coerceAtLeast_u2deb3DHEI);
			ptr[1] = new JniArgumentValue(minimumValue);
			return URangesKt._members.StaticMethods.InvokeInt64Method("coerceAtLeast-eb3DHEI.(JJ)J", ptr);
		}

		// Token: 0x06001F40 RID: 8000 RVA: 0x00068528 File Offset: 0x00066728
		[Register("coerceAtMost-5PvTz6A", "(SS)S", "")]
		public unsafe static short CoerceAtMost(short _this_coerceAtMost_u2d5PvTz6A, short maximumValue)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_coerceAtMost_u2d5PvTz6A);
			ptr[1] = new JniArgumentValue(maximumValue);
			return URangesKt._members.StaticMethods.InvokeInt16Method("coerceAtMost-5PvTz6A.(SS)S", ptr);
		}

		// Token: 0x06001F41 RID: 8001 RVA: 0x00068578 File Offset: 0x00066778
		[Register("coerceAtMost-J1ME1BU", "(II)I", "")]
		public unsafe static int CoerceAtMost(int _this_coerceAtMost_u2dJ1ME1BU, int maximumValue)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_coerceAtMost_u2dJ1ME1BU);
			ptr[1] = new JniArgumentValue(maximumValue);
			return URangesKt._members.StaticMethods.InvokeInt32Method("coerceAtMost-J1ME1BU.(II)I", ptr);
		}

		// Token: 0x06001F42 RID: 8002 RVA: 0x000685C8 File Offset: 0x000667C8
		[Register("coerceAtMost-Kr8caGY", "(BB)B", "")]
		public unsafe static sbyte CoerceAtMost(sbyte _this_coerceAtMost_u2dKr8caGY, sbyte maximumValue)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_coerceAtMost_u2dKr8caGY);
			ptr[1] = new JniArgumentValue(maximumValue);
			return URangesKt._members.StaticMethods.InvokeSByteMethod("coerceAtMost-Kr8caGY.(BB)B", ptr);
		}

		// Token: 0x06001F43 RID: 8003 RVA: 0x00068618 File Offset: 0x00066818
		[Register("coerceAtMost-eb3DHEI", "(JJ)J", "")]
		public unsafe static long CoerceAtMost(long _this_coerceAtMost_u2deb3DHEI, long maximumValue)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_coerceAtMost_u2deb3DHEI);
			ptr[1] = new JniArgumentValue(maximumValue);
			return URangesKt._members.StaticMethods.InvokeInt64Method("coerceAtMost-eb3DHEI.(JJ)J", ptr);
		}

		// Token: 0x06001F44 RID: 8004 RVA: 0x00068668 File Offset: 0x00066868
		[Register("coerceIn-JPwROB0", "(JLkotlin/ranges/ClosedRange;)J", "")]
		public unsafe static long CoerceIn(long _this_coerceIn_u2dJPwROB0, IClosedRange range)
		{
			long result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(_this_coerceIn_u2dJPwROB0);
				ptr[1] = new JniArgumentValue((range == null) ? IntPtr.Zero : ((Java.Lang.Object)range).Handle);
				result = URangesKt._members.StaticMethods.InvokeInt64Method("coerceIn-JPwROB0.(JLkotlin/ranges/ClosedRange;)J", ptr);
			}
			finally
			{
				GC.KeepAlive(range);
			}
			return result;
		}

		// Token: 0x06001F45 RID: 8005 RVA: 0x000686E4 File Offset: 0x000668E4
		[Register("coerceIn-VKSA0NQ", "(SSS)S", "")]
		public unsafe static short CoerceIn(short _this_coerceIn_u2dVKSA0NQ, short minimumValue, short maximumValue)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_coerceIn_u2dVKSA0NQ);
			ptr[1] = new JniArgumentValue(minimumValue);
			ptr[2] = new JniArgumentValue(maximumValue);
			return URangesKt._members.StaticMethods.InvokeInt16Method("coerceIn-VKSA0NQ.(SSS)S", ptr);
		}

		// Token: 0x06001F46 RID: 8006 RVA: 0x00068748 File Offset: 0x00066948
		[Register("coerceIn-WZ9TVnA", "(III)I", "")]
		public unsafe static int CoerceIn(int _this_coerceIn_u2dWZ9TVnA, int minimumValue, int maximumValue)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_coerceIn_u2dWZ9TVnA);
			ptr[1] = new JniArgumentValue(minimumValue);
			ptr[2] = new JniArgumentValue(maximumValue);
			return URangesKt._members.StaticMethods.InvokeInt32Method("coerceIn-WZ9TVnA.(III)I", ptr);
		}

		// Token: 0x06001F47 RID: 8007 RVA: 0x000687AC File Offset: 0x000669AC
		[Register("coerceIn-b33U2AM", "(BBB)B", "")]
		public unsafe static sbyte CoerceIn(sbyte _this_coerceIn_u2db33U2AM, sbyte minimumValue, sbyte maximumValue)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_coerceIn_u2db33U2AM);
			ptr[1] = new JniArgumentValue(minimumValue);
			ptr[2] = new JniArgumentValue(maximumValue);
			return URangesKt._members.StaticMethods.InvokeSByteMethod("coerceIn-b33U2AM.(BBB)B", ptr);
		}

		// Token: 0x06001F48 RID: 8008 RVA: 0x00068810 File Offset: 0x00066A10
		[Register("coerceIn-sambcqE", "(JJJ)J", "")]
		public unsafe static long CoerceIn(long _this_coerceIn_u2dsambcqE, long minimumValue, long maximumValue)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_coerceIn_u2dsambcqE);
			ptr[1] = new JniArgumentValue(minimumValue);
			ptr[2] = new JniArgumentValue(maximumValue);
			return URangesKt._members.StaticMethods.InvokeInt64Method("coerceIn-sambcqE.(JJJ)J", ptr);
		}

		// Token: 0x06001F49 RID: 8009 RVA: 0x00068874 File Offset: 0x00066A74
		[Register("coerceIn-wuiCnnA", "(ILkotlin/ranges/ClosedRange;)I", "")]
		public unsafe static int CoerceIn(int _this_coerceIn_u2dwuiCnnA, IClosedRange range)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(_this_coerceIn_u2dwuiCnnA);
				ptr[1] = new JniArgumentValue((range == null) ? IntPtr.Zero : ((Java.Lang.Object)range).Handle);
				result = URangesKt._members.StaticMethods.InvokeInt32Method("coerceIn-wuiCnnA.(ILkotlin/ranges/ClosedRange;)I", ptr);
			}
			finally
			{
				GC.KeepAlive(range);
			}
			return result;
		}

		// Token: 0x06001F4A RID: 8010 RVA: 0x000688F0 File Offset: 0x00066AF0
		[Register("contains-68kG9v0", "(Lkotlin/ranges/UIntRange;B)Z", "")]
		public unsafe static bool Contains(UIntRange _this_contains_u2d68kG9v0, sbyte value)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_contains_u2d68kG9v0 == null) ? IntPtr.Zero : _this_contains_u2d68kG9v0.Handle);
				ptr[1] = new JniArgumentValue(value);
				result = URangesKt._members.StaticMethods.InvokeBooleanMethod("contains-68kG9v0.(Lkotlin/ranges/UIntRange;B)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_contains_u2d68kG9v0);
			}
			return result;
		}

		// Token: 0x06001F4B RID: 8011 RVA: 0x00068968 File Offset: 0x00066B68
		[Register("contains-Gab390E", "(Lkotlin/ranges/ULongRange;I)Z", "")]
		public unsafe static bool Contains(ULongRange _this_contains_u2dGab390E, int value)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_contains_u2dGab390E == null) ? IntPtr.Zero : _this_contains_u2dGab390E.Handle);
				ptr[1] = new JniArgumentValue(value);
				result = URangesKt._members.StaticMethods.InvokeBooleanMethod("contains-Gab390E.(Lkotlin/ranges/ULongRange;I)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_contains_u2dGab390E);
			}
			return result;
		}

		// Token: 0x06001F4C RID: 8012 RVA: 0x000689E0 File Offset: 0x00066BE0
		[Register("contains-ULb-yJY", "(Lkotlin/ranges/ULongRange;B)Z", "")]
		public unsafe static bool Contains(ULongRange _this_contains_u2dULb_u2dyJY, sbyte value)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_contains_u2dULb_u2dyJY == null) ? IntPtr.Zero : _this_contains_u2dULb_u2dyJY.Handle);
				ptr[1] = new JniArgumentValue(value);
				result = URangesKt._members.StaticMethods.InvokeBooleanMethod("contains-ULb-yJY.(Lkotlin/ranges/ULongRange;B)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_contains_u2dULb_u2dyJY);
			}
			return result;
		}

		// Token: 0x06001F4D RID: 8013 RVA: 0x00068A58 File Offset: 0x00066C58
		[Register("contains-ZsK3CEQ", "(Lkotlin/ranges/UIntRange;S)Z", "")]
		public unsafe static bool Contains(UIntRange _this_contains_u2dZsK3CEQ, short value)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_contains_u2dZsK3CEQ == null) ? IntPtr.Zero : _this_contains_u2dZsK3CEQ.Handle);
				ptr[1] = new JniArgumentValue(value);
				result = URangesKt._members.StaticMethods.InvokeBooleanMethod("contains-ZsK3CEQ.(Lkotlin/ranges/UIntRange;S)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_contains_u2dZsK3CEQ);
			}
			return result;
		}

		// Token: 0x06001F4E RID: 8014 RVA: 0x00068AD0 File Offset: 0x00066CD0
		[Register("contains-fz5IDCE", "(Lkotlin/ranges/UIntRange;J)Z", "")]
		public unsafe static bool Contains(UIntRange _this_contains_u2dfz5IDCE, long value)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_contains_u2dfz5IDCE == null) ? IntPtr.Zero : _this_contains_u2dfz5IDCE.Handle);
				ptr[1] = new JniArgumentValue(value);
				result = URangesKt._members.StaticMethods.InvokeBooleanMethod("contains-fz5IDCE.(Lkotlin/ranges/UIntRange;J)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_contains_u2dfz5IDCE);
			}
			return result;
		}

		// Token: 0x06001F4F RID: 8015 RVA: 0x00068B48 File Offset: 0x00066D48
		[Register("contains-uhHAxoY", "(Lkotlin/ranges/ULongRange;S)Z", "")]
		public unsafe static bool Contains(ULongRange _this_contains_u2duhHAxoY, short value)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_contains_u2duhHAxoY == null) ? IntPtr.Zero : _this_contains_u2duhHAxoY.Handle);
				ptr[1] = new JniArgumentValue(value);
				result = URangesKt._members.StaticMethods.InvokeBooleanMethod("contains-uhHAxoY.(Lkotlin/ranges/ULongRange;S)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_contains_u2duhHAxoY);
			}
			return result;
		}

		// Token: 0x06001F50 RID: 8016 RVA: 0x00068BC0 File Offset: 0x00066DC0
		[Register("downTo-5PvTz6A", "(SS)Lkotlin/ranges/UIntProgression;", "")]
		public unsafe static UIntProgression DownTo(short _this_downTo_u2d5PvTz6A, short to)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_downTo_u2d5PvTz6A);
			ptr[1] = new JniArgumentValue(to);
			return Java.Lang.Object.GetObject<UIntProgression>(URangesKt._members.StaticMethods.InvokeObjectMethod("downTo-5PvTz6A.(SS)Lkotlin/ranges/UIntProgression;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001F51 RID: 8017 RVA: 0x00068C1C File Offset: 0x00066E1C
		[Register("downTo-J1ME1BU", "(II)Lkotlin/ranges/UIntProgression;", "")]
		public unsafe static UIntProgression DownTo(int _this_downTo_u2dJ1ME1BU, int to)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_downTo_u2dJ1ME1BU);
			ptr[1] = new JniArgumentValue(to);
			return Java.Lang.Object.GetObject<UIntProgression>(URangesKt._members.StaticMethods.InvokeObjectMethod("downTo-J1ME1BU.(II)Lkotlin/ranges/UIntProgression;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001F52 RID: 8018 RVA: 0x00068C78 File Offset: 0x00066E78
		[Register("downTo-Kr8caGY", "(BB)Lkotlin/ranges/UIntProgression;", "")]
		public unsafe static UIntProgression DownTo(sbyte _this_downTo_u2dKr8caGY, sbyte to)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_downTo_u2dKr8caGY);
			ptr[1] = new JniArgumentValue(to);
			return Java.Lang.Object.GetObject<UIntProgression>(URangesKt._members.StaticMethods.InvokeObjectMethod("downTo-Kr8caGY.(BB)Lkotlin/ranges/UIntProgression;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001F53 RID: 8019 RVA: 0x00068CD4 File Offset: 0x00066ED4
		[Register("downTo-eb3DHEI", "(JJ)Lkotlin/ranges/ULongProgression;", "")]
		public unsafe static ULongProgression DownTo(long _this_downTo_u2deb3DHEI, long to)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_downTo_u2deb3DHEI);
			ptr[1] = new JniArgumentValue(to);
			return Java.Lang.Object.GetObject<ULongProgression>(URangesKt._members.StaticMethods.InvokeObjectMethod("downTo-eb3DHEI.(JJ)Lkotlin/ranges/ULongProgression;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001F54 RID: 8020 RVA: 0x00068D30 File Offset: 0x00066F30
		[Register("first", "(Lkotlin/ranges/UIntProgression;)I", "")]
		public unsafe static int First(UIntProgression _this_first)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_first == null) ? IntPtr.Zero : _this_first.Handle);
				result = URangesKt._members.StaticMethods.InvokeInt32Method("first.(Lkotlin/ranges/UIntProgression;)I", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_first);
			}
			return result;
		}

		// Token: 0x06001F55 RID: 8021 RVA: 0x00068D94 File Offset: 0x00066F94
		[Register("first", "(Lkotlin/ranges/ULongProgression;)J", "")]
		public unsafe static long First(ULongProgression _this_first)
		{
			long result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_first == null) ? IntPtr.Zero : _this_first.Handle);
				result = URangesKt._members.StaticMethods.InvokeInt64Method("first.(Lkotlin/ranges/ULongProgression;)J", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_first);
			}
			return result;
		}

		// Token: 0x06001F56 RID: 8022 RVA: 0x00068DF8 File Offset: 0x00066FF8
		[Register("firstOrNull", "(Lkotlin/ranges/UIntProgression;)Lkotlin/UInt;", "")]
		[return: Nullable(2)]
		public unsafe static UInt FirstOrNull(UIntProgression _this_firstOrNull)
		{
			UInt @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_firstOrNull == null) ? IntPtr.Zero : _this_firstOrNull.Handle);
				@object = Java.Lang.Object.GetObject<UInt>(URangesKt._members.StaticMethods.InvokeObjectMethod("firstOrNull.(Lkotlin/ranges/UIntProgression;)Lkotlin/UInt;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_firstOrNull);
			}
			return @object;
		}

		// Token: 0x06001F57 RID: 8023 RVA: 0x00068E6C File Offset: 0x0006706C
		[Register("firstOrNull", "(Lkotlin/ranges/ULongProgression;)Lkotlin/ULong;", "")]
		[return: Nullable(2)]
		public unsafe static ULong FirstOrNull(ULongProgression _this_firstOrNull)
		{
			ULong @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_firstOrNull == null) ? IntPtr.Zero : _this_firstOrNull.Handle);
				@object = Java.Lang.Object.GetObject<ULong>(URangesKt._members.StaticMethods.InvokeObjectMethod("firstOrNull.(Lkotlin/ranges/ULongProgression;)Lkotlin/ULong;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_firstOrNull);
			}
			return @object;
		}

		// Token: 0x06001F58 RID: 8024 RVA: 0x00068EE0 File Offset: 0x000670E0
		[Register("last", "(Lkotlin/ranges/UIntProgression;)I", "")]
		public unsafe static int Last(UIntProgression _this_last)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_last == null) ? IntPtr.Zero : _this_last.Handle);
				result = URangesKt._members.StaticMethods.InvokeInt32Method("last.(Lkotlin/ranges/UIntProgression;)I", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_last);
			}
			return result;
		}

		// Token: 0x06001F59 RID: 8025 RVA: 0x00068F44 File Offset: 0x00067144
		[Register("last", "(Lkotlin/ranges/ULongProgression;)J", "")]
		public unsafe static long Last(ULongProgression _this_last)
		{
			long result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_last == null) ? IntPtr.Zero : _this_last.Handle);
				result = URangesKt._members.StaticMethods.InvokeInt64Method("last.(Lkotlin/ranges/ULongProgression;)J", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_last);
			}
			return result;
		}

		// Token: 0x06001F5A RID: 8026 RVA: 0x00068FA8 File Offset: 0x000671A8
		[Register("lastOrNull", "(Lkotlin/ranges/UIntProgression;)Lkotlin/UInt;", "")]
		[return: Nullable(2)]
		public unsafe static UInt LastOrNull(UIntProgression _this_lastOrNull)
		{
			UInt @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_lastOrNull == null) ? IntPtr.Zero : _this_lastOrNull.Handle);
				@object = Java.Lang.Object.GetObject<UInt>(URangesKt._members.StaticMethods.InvokeObjectMethod("lastOrNull.(Lkotlin/ranges/UIntProgression;)Lkotlin/UInt;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_lastOrNull);
			}
			return @object;
		}

		// Token: 0x06001F5B RID: 8027 RVA: 0x0006901C File Offset: 0x0006721C
		[Register("lastOrNull", "(Lkotlin/ranges/ULongProgression;)Lkotlin/ULong;", "")]
		[return: Nullable(2)]
		public unsafe static ULong LastOrNull(ULongProgression _this_lastOrNull)
		{
			ULong @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_lastOrNull == null) ? IntPtr.Zero : _this_lastOrNull.Handle);
				@object = Java.Lang.Object.GetObject<ULong>(URangesKt._members.StaticMethods.InvokeObjectMethod("lastOrNull.(Lkotlin/ranges/ULongProgression;)Lkotlin/ULong;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_lastOrNull);
			}
			return @object;
		}

		// Token: 0x06001F5C RID: 8028 RVA: 0x00069090 File Offset: 0x00067290
		[Register("random", "(Lkotlin/ranges/UIntRange;Lkotlin/random/Random;)I", "")]
		public unsafe static int Random(UIntRange _this_random, Kotlin.Random.Random random)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_random == null) ? IntPtr.Zero : _this_random.Handle);
				ptr[1] = new JniArgumentValue((random == null) ? IntPtr.Zero : random.Handle);
				result = URangesKt._members.StaticMethods.InvokeInt32Method("random.(Lkotlin/ranges/UIntRange;Lkotlin/random/Random;)I", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_random);
				GC.KeepAlive(random);
			}
			return result;
		}

		// Token: 0x06001F5D RID: 8029 RVA: 0x0006911C File Offset: 0x0006731C
		[Register("random", "(Lkotlin/ranges/ULongRange;Lkotlin/random/Random;)J", "")]
		public unsafe static long Random(ULongRange _this_random, Kotlin.Random.Random random)
		{
			long result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_random == null) ? IntPtr.Zero : _this_random.Handle);
				ptr[1] = new JniArgumentValue((random == null) ? IntPtr.Zero : random.Handle);
				result = URangesKt._members.StaticMethods.InvokeInt64Method("random.(Lkotlin/ranges/ULongRange;Lkotlin/random/Random;)J", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_random);
				GC.KeepAlive(random);
			}
			return result;
		}

		// Token: 0x06001F5E RID: 8030 RVA: 0x000691A8 File Offset: 0x000673A8
		[Register("randomOrNull", "(Lkotlin/ranges/UIntRange;Lkotlin/random/Random;)Lkotlin/UInt;", "")]
		[return: Nullable(2)]
		public unsafe static UInt RandomOrNull(UIntRange _this_randomOrNull, Kotlin.Random.Random random)
		{
			UInt @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_randomOrNull == null) ? IntPtr.Zero : _this_randomOrNull.Handle);
				ptr[1] = new JniArgumentValue((random == null) ? IntPtr.Zero : random.Handle);
				@object = Java.Lang.Object.GetObject<UInt>(URangesKt._members.StaticMethods.InvokeObjectMethod("randomOrNull.(Lkotlin/ranges/UIntRange;Lkotlin/random/Random;)Lkotlin/UInt;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_randomOrNull);
				GC.KeepAlive(random);
			}
			return @object;
		}

		// Token: 0x06001F5F RID: 8031 RVA: 0x00069244 File Offset: 0x00067444
		[Register("randomOrNull", "(Lkotlin/ranges/ULongRange;Lkotlin/random/Random;)Lkotlin/ULong;", "")]
		[return: Nullable(2)]
		public unsafe static ULong RandomOrNull(ULongRange _this_randomOrNull, Kotlin.Random.Random random)
		{
			ULong @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_randomOrNull == null) ? IntPtr.Zero : _this_randomOrNull.Handle);
				ptr[1] = new JniArgumentValue((random == null) ? IntPtr.Zero : random.Handle);
				@object = Java.Lang.Object.GetObject<ULong>(URangesKt._members.StaticMethods.InvokeObjectMethod("randomOrNull.(Lkotlin/ranges/ULongRange;Lkotlin/random/Random;)Lkotlin/ULong;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_randomOrNull);
				GC.KeepAlive(random);
			}
			return @object;
		}

		// Token: 0x06001F60 RID: 8032 RVA: 0x000692E0 File Offset: 0x000674E0
		[Register("reversed", "(Lkotlin/ranges/UIntProgression;)Lkotlin/ranges/UIntProgression;", "")]
		public unsafe static UIntProgression Reversed(UIntProgression _this_reversed)
		{
			UIntProgression @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_reversed == null) ? IntPtr.Zero : _this_reversed.Handle);
				@object = Java.Lang.Object.GetObject<UIntProgression>(URangesKt._members.StaticMethods.InvokeObjectMethod("reversed.(Lkotlin/ranges/UIntProgression;)Lkotlin/ranges/UIntProgression;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_reversed);
			}
			return @object;
		}

		// Token: 0x06001F61 RID: 8033 RVA: 0x00069354 File Offset: 0x00067554
		[Register("reversed", "(Lkotlin/ranges/ULongProgression;)Lkotlin/ranges/ULongProgression;", "")]
		public unsafe static ULongProgression Reversed(ULongProgression _this_reversed)
		{
			ULongProgression @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_reversed == null) ? IntPtr.Zero : _this_reversed.Handle);
				@object = Java.Lang.Object.GetObject<ULongProgression>(URangesKt._members.StaticMethods.InvokeObjectMethod("reversed.(Lkotlin/ranges/ULongProgression;)Lkotlin/ranges/ULongProgression;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_reversed);
			}
			return @object;
		}

		// Token: 0x06001F62 RID: 8034 RVA: 0x000693C8 File Offset: 0x000675C8
		[Register("step", "(Lkotlin/ranges/UIntProgression;I)Lkotlin/ranges/UIntProgression;", "")]
		public unsafe static UIntProgression Step(UIntProgression _this_step, int step)
		{
			UIntProgression @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_step == null) ? IntPtr.Zero : _this_step.Handle);
				ptr[1] = new JniArgumentValue(step);
				@object = Java.Lang.Object.GetObject<UIntProgression>(URangesKt._members.StaticMethods.InvokeObjectMethod("step.(Lkotlin/ranges/UIntProgression;I)Lkotlin/ranges/UIntProgression;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_step);
			}
			return @object;
		}

		// Token: 0x06001F63 RID: 8035 RVA: 0x00069450 File Offset: 0x00067650
		[Register("step", "(Lkotlin/ranges/ULongProgression;J)Lkotlin/ranges/ULongProgression;", "")]
		public unsafe static ULongProgression Step(ULongProgression _this_step, long step)
		{
			ULongProgression @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_step == null) ? IntPtr.Zero : _this_step.Handle);
				ptr[1] = new JniArgumentValue(step);
				@object = Java.Lang.Object.GetObject<ULongProgression>(URangesKt._members.StaticMethods.InvokeObjectMethod("step.(Lkotlin/ranges/ULongProgression;J)Lkotlin/ranges/ULongProgression;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_step);
			}
			return @object;
		}

		// Token: 0x06001F64 RID: 8036 RVA: 0x000694D8 File Offset: 0x000676D8
		[Register("until-5PvTz6A", "(SS)Lkotlin/ranges/UIntRange;", "")]
		public unsafe static UIntRange Until(short _this_until_u2d5PvTz6A, short to)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_until_u2d5PvTz6A);
			ptr[1] = new JniArgumentValue(to);
			return Java.Lang.Object.GetObject<UIntRange>(URangesKt._members.StaticMethods.InvokeObjectMethod("until-5PvTz6A.(SS)Lkotlin/ranges/UIntRange;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001F65 RID: 8037 RVA: 0x00069534 File Offset: 0x00067734
		[Register("until-J1ME1BU", "(II)Lkotlin/ranges/UIntRange;", "")]
		public unsafe static UIntRange Until(int _this_until_u2dJ1ME1BU, int to)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_until_u2dJ1ME1BU);
			ptr[1] = new JniArgumentValue(to);
			return Java.Lang.Object.GetObject<UIntRange>(URangesKt._members.StaticMethods.InvokeObjectMethod("until-J1ME1BU.(II)Lkotlin/ranges/UIntRange;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001F66 RID: 8038 RVA: 0x00069590 File Offset: 0x00067790
		[Register("until-Kr8caGY", "(BB)Lkotlin/ranges/UIntRange;", "")]
		public unsafe static UIntRange Until(sbyte _this_until_u2dKr8caGY, sbyte to)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_until_u2dKr8caGY);
			ptr[1] = new JniArgumentValue(to);
			return Java.Lang.Object.GetObject<UIntRange>(URangesKt._members.StaticMethods.InvokeObjectMethod("until-Kr8caGY.(BB)Lkotlin/ranges/UIntRange;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001F67 RID: 8039 RVA: 0x000695EC File Offset: 0x000677EC
		[Register("until-eb3DHEI", "(JJ)Lkotlin/ranges/ULongRange;", "")]
		public unsafe static ULongRange Until(long _this_until_u2deb3DHEI, long to)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(_this_until_u2deb3DHEI);
			ptr[1] = new JniArgumentValue(to);
			return Java.Lang.Object.GetObject<ULongRange>(URangesKt._members.StaticMethods.InvokeObjectMethod("until-eb3DHEI.(JJ)Lkotlin/ranges/ULongRange;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000946 RID: 2374
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/ranges/URangesKt", typeof(URangesKt));
	}
}
