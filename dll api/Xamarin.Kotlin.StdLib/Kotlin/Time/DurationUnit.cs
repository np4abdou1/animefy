using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Enums;

namespace Kotlin.Time
{
	// Token: 0x020000C2 RID: 194
	[NullableContext(2)]
	[Nullable(0)]
	[Register("kotlin/time/DurationUnit", DoNotGenerateAcw = true)]
	public sealed class DurationUnit : Java.Lang.Enum
	{
		// Token: 0x17000184 RID: 388
		// (get) Token: 0x0600059E RID: 1438 RVA: 0x0000DEB8 File Offset: 0x0000C0B8
		[Register("DAYS")]
		public static DurationUnit Days
		{
			get
			{
				return Java.Lang.Object.GetObject<DurationUnit>(DurationUnit._members.StaticFields.GetObjectValue("DAYS.Lkotlin/time/DurationUnit;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x0600059F RID: 1439 RVA: 0x0000DEE8 File Offset: 0x0000C0E8
		[Register("HOURS")]
		public static DurationUnit Hours
		{
			get
			{
				return Java.Lang.Object.GetObject<DurationUnit>(DurationUnit._members.StaticFields.GetObjectValue("HOURS.Lkotlin/time/DurationUnit;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x060005A0 RID: 1440 RVA: 0x0000DF18 File Offset: 0x0000C118
		[Register("MICROSECONDS")]
		public static DurationUnit Microseconds
		{
			get
			{
				return Java.Lang.Object.GetObject<DurationUnit>(DurationUnit._members.StaticFields.GetObjectValue("MICROSECONDS.Lkotlin/time/DurationUnit;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x060005A1 RID: 1441 RVA: 0x0000DF48 File Offset: 0x0000C148
		[Register("MILLISECONDS")]
		public static DurationUnit Milliseconds
		{
			get
			{
				return Java.Lang.Object.GetObject<DurationUnit>(DurationUnit._members.StaticFields.GetObjectValue("MILLISECONDS.Lkotlin/time/DurationUnit;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x060005A2 RID: 1442 RVA: 0x0000DF78 File Offset: 0x0000C178
		[Register("MINUTES")]
		public static DurationUnit Minutes
		{
			get
			{
				return Java.Lang.Object.GetObject<DurationUnit>(DurationUnit._members.StaticFields.GetObjectValue("MINUTES.Lkotlin/time/DurationUnit;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x060005A3 RID: 1443 RVA: 0x0000DFA8 File Offset: 0x0000C1A8
		[Register("NANOSECONDS")]
		public static DurationUnit Nanoseconds
		{
			get
			{
				return Java.Lang.Object.GetObject<DurationUnit>(DurationUnit._members.StaticFields.GetObjectValue("NANOSECONDS.Lkotlin/time/DurationUnit;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x060005A4 RID: 1444 RVA: 0x0000DFD8 File Offset: 0x0000C1D8
		[Register("SECONDS")]
		public static DurationUnit Seconds
		{
			get
			{
				return Java.Lang.Object.GetObject<DurationUnit>(DurationUnit._members.StaticFields.GetObjectValue("SECONDS.Lkotlin/time/DurationUnit;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x060005A5 RID: 1445 RVA: 0x0000E008 File Offset: 0x0000C208
		internal static IntPtr class_ref
		{
			get
			{
				return DurationUnit._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x060005A6 RID: 1446 RVA: 0x0000E02C File Offset: 0x0000C22C
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return DurationUnit._members;
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x060005A7 RID: 1447 RVA: 0x0000E034 File Offset: 0x0000C234
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DurationUnit._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x060005A8 RID: 1448 RVA: 0x0000E058 File Offset: 0x0000C258
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return DurationUnit._members.ManagedPeerType;
			}
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x0000E064 File Offset: 0x0000C264
		internal DurationUnit(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x060005AA RID: 1450 RVA: 0x0000E070 File Offset: 0x0000C270
		[Nullable(1)]
		public static IEnumEntries Entries
		{
			[NullableContext(1)]
			[Register("getEntries", "()Lkotlin/enums/EnumEntries;", "")]
			get
			{
				return Java.Lang.Object.GetObject<IEnumEntries>(DurationUnit._members.StaticMethods.InvokeObjectMethod("getEntries.()Lkotlin/enums/EnumEntries;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x0000E0A4 File Offset: 0x0000C2A4
		[Register("valueOf", "(Ljava/lang/String;)Lkotlin/time/DurationUnit;", "")]
		public unsafe static DurationUnit ValueOf(string value)
		{
			IntPtr intPtr = JNIEnv.NewString(value);
			DurationUnit @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<DurationUnit>(DurationUnit._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lkotlin/time/DurationUnit;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x0000E110 File Offset: 0x0000C310
		[Register("values", "()[Lkotlin/time/DurationUnit;", "")]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public static DurationUnit[] Values()
		{
			return (DurationUnit[])JNIEnv.GetArray(DurationUnit._members.StaticMethods.InvokeObjectMethod("values.()[Lkotlin/time/DurationUnit;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(DurationUnit));
		}

		// Token: 0x0400018A RID: 394
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/time/DurationUnit", typeof(DurationUnit));
	}
}
