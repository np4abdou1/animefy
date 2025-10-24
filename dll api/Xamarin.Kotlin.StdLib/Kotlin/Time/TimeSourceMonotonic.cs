using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Time
{
	// Token: 0x020000CD RID: 205
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/time/TimeSource$Monotonic", DoNotGenerateAcw = true)]
	public sealed class TimeSourceMonotonic : Java.Lang.Object
	{
		// Token: 0x170001AE RID: 430
		// (get) Token: 0x06000630 RID: 1584 RVA: 0x0000F8DC File Offset: 0x0000DADC
		[Register("INSTANCE")]
		public static TimeSourceMonotonic Instance
		{
			get
			{
				return Java.Lang.Object.GetObject<TimeSourceMonotonic>(TimeSourceMonotonic._members.StaticFields.GetObjectValue("INSTANCE.Lkotlin/time/TimeSource$Monotonic;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x06000631 RID: 1585 RVA: 0x0000F90C File Offset: 0x0000DB0C
		internal static IntPtr class_ref
		{
			get
			{
				return TimeSourceMonotonic._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x06000632 RID: 1586 RVA: 0x0000F930 File Offset: 0x0000DB30
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return TimeSourceMonotonic._members;
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x06000633 RID: 1587 RVA: 0x0000F938 File Offset: 0x0000DB38
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return TimeSourceMonotonic._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06000634 RID: 1588 RVA: 0x0000F95C File Offset: 0x0000DB5C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return TimeSourceMonotonic._members.ManagedPeerType;
			}
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x0000F968 File Offset: 0x0000DB68
		internal TimeSourceMonotonic(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x0000F972 File Offset: 0x0000DB72
		[Register("markNow-z9LOYto", "()J", "")]
		public long MarkNow()
		{
			return TimeSourceMonotonic._members.InstanceMethods.InvokeAbstractInt64Method("markNow-z9LOYto.()J", this, null);
		}

		// Token: 0x040001BA RID: 442
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/time/TimeSource$Monotonic", typeof(TimeSourceMonotonic));

		// Token: 0x020002DE RID: 734
		[Nullable(0)]
		[Register("kotlin/time/TimeSource$Monotonic$ValueTimeMark", DoNotGenerateAcw = true)]
		public sealed class ValueTimeMark : Java.Lang.Object
		{
			// Token: 0x17000A00 RID: 2560
			// (get) Token: 0x0600294D RID: 10573 RVA: 0x000B7AC8 File Offset: 0x000B5CC8
			internal static IntPtr class_ref
			{
				get
				{
					return TimeSourceMonotonic.ValueTimeMark._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000A01 RID: 2561
			// (get) Token: 0x0600294E RID: 10574 RVA: 0x000B7AEC File Offset: 0x000B5CEC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return TimeSourceMonotonic.ValueTimeMark._members;
				}
			}

			// Token: 0x17000A02 RID: 2562
			// (get) Token: 0x0600294F RID: 10575 RVA: 0x000B7AF4 File Offset: 0x000B5CF4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return TimeSourceMonotonic.ValueTimeMark._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000A03 RID: 2563
			// (get) Token: 0x06002950 RID: 10576 RVA: 0x000B7B18 File Offset: 0x000B5D18
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return TimeSourceMonotonic.ValueTimeMark._members.ManagedPeerType;
				}
			}

			// Token: 0x06002951 RID: 10577 RVA: 0x000B7B24 File Offset: 0x000B5D24
			internal ValueTimeMark(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x17000A04 RID: 2564
			// (get) Token: 0x06002952 RID: 10578 RVA: 0x000B7B2E File Offset: 0x000B5D2E
			public bool HasNotPassedNow
			{
				[Register("hasNotPassedNow", "()Z", "")]
				get
				{
					return TimeSourceMonotonic.ValueTimeMark._members.InstanceMethods.InvokeAbstractBooleanMethod("hasNotPassedNow.()Z", this, null);
				}
			}

			// Token: 0x17000A05 RID: 2565
			// (get) Token: 0x06002953 RID: 10579 RVA: 0x000B7B47 File Offset: 0x000B5D47
			public bool HasPassedNow
			{
				[Register("hasPassedNow", "()Z", "")]
				get
				{
					return TimeSourceMonotonic.ValueTimeMark._members.InstanceMethods.InvokeAbstractBooleanMethod("hasPassedNow.()Z", this, null);
				}
			}

			// Token: 0x06002954 RID: 10580 RVA: 0x000B7B60 File Offset: 0x000B5D60
			[Register("compareTo", "(Lkotlin/time/ComparableTimeMark;)I", "")]
			public unsafe int CompareTo(IComparableTimeMark other)
			{
				int result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
					result = TimeSourceMonotonic.ValueTimeMark._members.InstanceMethods.InvokeAbstractInt32Method("compareTo.(Lkotlin/time/ComparableTimeMark;)I", this, ptr);
				}
				finally
				{
					GC.KeepAlive(other);
				}
				return result;
			}

			// Token: 0x06002955 RID: 10581 RVA: 0x000B7BCC File Offset: 0x000B5DCC
			[Register("compareTo-6eNON_k", "(JJ)I", "")]
			public unsafe static int CompareTo_6eNON_k(long arg0, long other)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(arg0);
				ptr[1] = new JniArgumentValue(other);
				return TimeSourceMonotonic.ValueTimeMark._members.StaticMethods.InvokeInt32Method("compareTo-6eNON_k.(JJ)I", ptr);
			}

			// Token: 0x06002956 RID: 10582 RVA: 0x000B7C1C File Offset: 0x000B5E1C
			[Register("minus-6eNON_k", "(JJ)J", "")]
			public unsafe static long Minus_6eNON_k(long arg0, long other)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(arg0);
				ptr[1] = new JniArgumentValue(other);
				return TimeSourceMonotonic.ValueTimeMark._members.StaticMethods.InvokeInt64Method("minus-6eNON_k.(JJ)J", ptr);
			}

			// Token: 0x06002957 RID: 10583 RVA: 0x000B7C6C File Offset: 0x000B5E6C
			[Register("minus-LRDsOJo", "(J)J", "")]
			public unsafe long Minus(long duration)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(duration);
				return TimeSourceMonotonic.ValueTimeMark._members.InstanceMethods.InvokeAbstractInt64Method("minus-LRDsOJo.(J)J", this, ptr);
			}

			// Token: 0x06002958 RID: 10584 RVA: 0x000B7CA8 File Offset: 0x000B5EA8
			[Register("minus-LRDsOJo", "(JJ)J", "")]
			public unsafe static long Minus(long arg0, long duration)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(arg0);
				ptr[1] = new JniArgumentValue(duration);
				return TimeSourceMonotonic.ValueTimeMark._members.StaticMethods.InvokeInt64Method("minus-LRDsOJo.(JJ)J", ptr);
			}

			// Token: 0x06002959 RID: 10585 RVA: 0x000B7CF8 File Offset: 0x000B5EF8
			[Register("minus-UwyO8pc", "(Lkotlin/time/ComparableTimeMark;)J", "")]
			public unsafe long Minus_UwyO8pc(IComparableTimeMark other)
			{
				long result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
					result = TimeSourceMonotonic.ValueTimeMark._members.InstanceMethods.InvokeAbstractInt64Method("minus-UwyO8pc.(Lkotlin/time/ComparableTimeMark;)J", this, ptr);
				}
				finally
				{
					GC.KeepAlive(other);
				}
				return result;
			}

			// Token: 0x0600295A RID: 10586 RVA: 0x000B7D64 File Offset: 0x000B5F64
			[Register("minus-UwyO8pc", "(JLkotlin/time/ComparableTimeMark;)J", "")]
			public unsafe static long Minus_UwyO8pc(long arg0, IComparableTimeMark other)
			{
				long result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(arg0);
					ptr[1] = new JniArgumentValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
					result = TimeSourceMonotonic.ValueTimeMark._members.StaticMethods.InvokeInt64Method("minus-UwyO8pc.(JLkotlin/time/ComparableTimeMark;)J", ptr);
				}
				finally
				{
					GC.KeepAlive(other);
				}
				return result;
			}

			// Token: 0x0600295B RID: 10587 RVA: 0x000B7DE0 File Offset: 0x000B5FE0
			[Register("plus-LRDsOJo", "(J)J", "")]
			public unsafe long Plus(long duration)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(duration);
				return TimeSourceMonotonic.ValueTimeMark._members.InstanceMethods.InvokeAbstractInt64Method("plus-LRDsOJo.(J)J", this, ptr);
			}

			// Token: 0x0600295C RID: 10588 RVA: 0x000B7E1C File Offset: 0x000B601C
			[Register("plus-LRDsOJo", "(JJ)J", "")]
			public unsafe static long Plus(long arg0, long duration)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(arg0);
				ptr[1] = new JniArgumentValue(duration);
				return TimeSourceMonotonic.ValueTimeMark._members.StaticMethods.InvokeInt64Method("plus-LRDsOJo.(JJ)J", ptr);
			}

			// Token: 0x040009D5 RID: 2517
			private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/time/TimeSource$Monotonic$ValueTimeMark", typeof(TimeSourceMonotonic.ValueTimeMark));
		}
	}
}
