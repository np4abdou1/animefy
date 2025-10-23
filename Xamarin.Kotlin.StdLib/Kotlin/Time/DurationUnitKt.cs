using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util.Concurrent;

namespace Kotlin.Time
{
	// Token: 0x020000C3 RID: 195
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/time/DurationUnitKt", DoNotGenerateAcw = true)]
	public sealed class DurationUnitKt : Java.Lang.Object
	{
		// Token: 0x17000190 RID: 400
		// (get) Token: 0x060005AE RID: 1454 RVA: 0x0000E16C File Offset: 0x0000C36C
		internal static IntPtr class_ref
		{
			get
			{
				return DurationUnitKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x060005AF RID: 1455 RVA: 0x0000E190 File Offset: 0x0000C390
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DurationUnitKt._members;
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x060005B0 RID: 1456 RVA: 0x0000E198 File Offset: 0x0000C398
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DurationUnitKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x060005B1 RID: 1457 RVA: 0x0000E1BC File Offset: 0x0000C3BC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DurationUnitKt._members.ManagedPeerType;
			}
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x0000E1C8 File Offset: 0x0000C3C8
		internal DurationUnitKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x0000E1D4 File Offset: 0x0000C3D4
		[Register("durationUnitByIsoChar", "(CZ)Lkotlin/time/DurationUnit;", "")]
		public unsafe static DurationUnit DurationUnitByIsoChar(char isoChar, bool isTimeComponent)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(isoChar);
			ptr[1] = new JniArgumentValue(isTimeComponent);
			return Java.Lang.Object.GetObject<DurationUnit>(DurationUnitKt._members.StaticMethods.InvokeObjectMethod("durationUnitByIsoChar.(CZ)Lkotlin/time/DurationUnit;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x0000E230 File Offset: 0x0000C430
		[Register("durationUnitByShortName", "(Ljava/lang/String;)Lkotlin/time/DurationUnit;", "")]
		public unsafe static DurationUnit DurationUnitByShortName(string shortName)
		{
			IntPtr intPtr = JNIEnv.NewString(shortName);
			DurationUnit @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<DurationUnit>(DurationUnitKt._members.StaticMethods.InvokeObjectMethod("durationUnitByShortName.(Ljava/lang/String;)Lkotlin/time/DurationUnit;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x0000E29C File Offset: 0x0000C49C
		[Register("shortName", "(Lkotlin/time/DurationUnit;)Ljava/lang/String;", "")]
		public unsafe static string ShortName(DurationUnit _this_shortName)
		{
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_shortName == null) ? IntPtr.Zero : _this_shortName.Handle);
				@string = JNIEnv.GetString(DurationUnitKt._members.StaticMethods.InvokeObjectMethod("shortName.(Lkotlin/time/DurationUnit;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_shortName);
			}
			return @string;
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x0000E310 File Offset: 0x0000C510
		[Register("convertDurationUnit", "(DLkotlin/time/DurationUnit;Lkotlin/time/DurationUnit;)D", "")]
		public unsafe static double ConvertDurationUnit(double value, DurationUnit sourceUnit, DurationUnit targetUnit)
		{
			double result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				ptr[1] = new JniArgumentValue((sourceUnit == null) ? IntPtr.Zero : sourceUnit.Handle);
				ptr[2] = new JniArgumentValue((targetUnit == null) ? IntPtr.Zero : targetUnit.Handle);
				result = DurationUnitKt._members.StaticMethods.InvokeDoubleMethod("convertDurationUnit.(DLkotlin/time/DurationUnit;Lkotlin/time/DurationUnit;)D", ptr);
			}
			finally
			{
				GC.KeepAlive(sourceUnit);
				GC.KeepAlive(targetUnit);
			}
			return result;
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x0000E3B4 File Offset: 0x0000C5B4
		[Register("convertDurationUnit", "(JLkotlin/time/DurationUnit;Lkotlin/time/DurationUnit;)J", "")]
		public unsafe static long ConvertDurationUnit(long value, DurationUnit sourceUnit, DurationUnit targetUnit)
		{
			long result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				ptr[1] = new JniArgumentValue((sourceUnit == null) ? IntPtr.Zero : sourceUnit.Handle);
				ptr[2] = new JniArgumentValue((targetUnit == null) ? IntPtr.Zero : targetUnit.Handle);
				result = DurationUnitKt._members.StaticMethods.InvokeInt64Method("convertDurationUnit.(JLkotlin/time/DurationUnit;Lkotlin/time/DurationUnit;)J", ptr);
			}
			finally
			{
				GC.KeepAlive(sourceUnit);
				GC.KeepAlive(targetUnit);
			}
			return result;
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x0000E458 File Offset: 0x0000C658
		[Register("convertDurationUnitOverflow", "(JLkotlin/time/DurationUnit;Lkotlin/time/DurationUnit;)J", "")]
		public unsafe static long ConvertDurationUnitOverflow(long value, DurationUnit sourceUnit, DurationUnit targetUnit)
		{
			long result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				ptr[1] = new JniArgumentValue((sourceUnit == null) ? IntPtr.Zero : sourceUnit.Handle);
				ptr[2] = new JniArgumentValue((targetUnit == null) ? IntPtr.Zero : targetUnit.Handle);
				result = DurationUnitKt._members.StaticMethods.InvokeInt64Method("convertDurationUnitOverflow.(JLkotlin/time/DurationUnit;Lkotlin/time/DurationUnit;)J", ptr);
			}
			finally
			{
				GC.KeepAlive(sourceUnit);
				GC.KeepAlive(targetUnit);
			}
			return result;
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x0000E4FC File Offset: 0x0000C6FC
		[Register("toDurationUnit", "(Ljava/util/concurrent/TimeUnit;)Lkotlin/time/DurationUnit;", "")]
		public unsafe static DurationUnit ToDurationUnit(TimeUnit _this_toDurationUnit)
		{
			DurationUnit @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_toDurationUnit == null) ? IntPtr.Zero : _this_toDurationUnit.Handle);
				@object = Java.Lang.Object.GetObject<DurationUnit>(DurationUnitKt._members.StaticMethods.InvokeObjectMethod("toDurationUnit.(Ljava/util/concurrent/TimeUnit;)Lkotlin/time/DurationUnit;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_toDurationUnit);
			}
			return @object;
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x0000E570 File Offset: 0x0000C770
		[Register("toTimeUnit", "(Lkotlin/time/DurationUnit;)Ljava/util/concurrent/TimeUnit;", "")]
		public unsafe static TimeUnit ToTimeUnit(DurationUnit _this_toTimeUnit)
		{
			TimeUnit @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_toTimeUnit == null) ? IntPtr.Zero : _this_toTimeUnit.Handle);
				@object = Java.Lang.Object.GetObject<TimeUnit>(DurationUnitKt._members.StaticMethods.InvokeObjectMethod("toTimeUnit.(Lkotlin/time/DurationUnit;)Ljava/util/concurrent/TimeUnit;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_toTimeUnit);
			}
			return @object;
		}

		// Token: 0x0400018B RID: 395
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/time/DurationUnitKt", typeof(DurationUnitKt));
	}
}
