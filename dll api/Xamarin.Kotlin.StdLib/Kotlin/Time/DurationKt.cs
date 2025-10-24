using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Time
{
	// Token: 0x020000C1 RID: 193
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/time/DurationKt", DoNotGenerateAcw = true)]
	public sealed class DurationKt : Java.Lang.Object
	{
		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06000595 RID: 1429 RVA: 0x0000DCCC File Offset: 0x0000BECC
		internal static IntPtr class_ref
		{
			get
			{
				return DurationKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x06000596 RID: 1430 RVA: 0x0000DCF0 File Offset: 0x0000BEF0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DurationKt._members;
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x06000597 RID: 1431 RVA: 0x0000DCF8 File Offset: 0x0000BEF8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DurationKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06000598 RID: 1432 RVA: 0x0000DD1C File Offset: 0x0000BF1C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DurationKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x0000DD28 File Offset: 0x0000BF28
		internal DurationKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x0000DD34 File Offset: 0x0000BF34
		[Register("toDuration", "(DLkotlin/time/DurationUnit;)J", "")]
		public unsafe static long ToDuration(double obj, DurationUnit unit)
		{
			long result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(obj);
				ptr[1] = new JniArgumentValue((unit == null) ? IntPtr.Zero : unit.Handle);
				result = DurationKt._members.StaticMethods.InvokeInt64Method("toDuration.(DLkotlin/time/DurationUnit;)J", ptr);
			}
			finally
			{
				GC.KeepAlive(unit);
			}
			return result;
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x0000DDAC File Offset: 0x0000BFAC
		[Register("toDuration", "(ILkotlin/time/DurationUnit;)J", "")]
		public unsafe static long ToDuration(int obj, DurationUnit unit)
		{
			long result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(obj);
				ptr[1] = new JniArgumentValue((unit == null) ? IntPtr.Zero : unit.Handle);
				result = DurationKt._members.StaticMethods.InvokeInt64Method("toDuration.(ILkotlin/time/DurationUnit;)J", ptr);
			}
			finally
			{
				GC.KeepAlive(unit);
			}
			return result;
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x0000DE24 File Offset: 0x0000C024
		[Register("toDuration", "(JLkotlin/time/DurationUnit;)J", "")]
		public unsafe static long ToDuration(long obj, DurationUnit unit)
		{
			long result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(obj);
				ptr[1] = new JniArgumentValue((unit == null) ? IntPtr.Zero : unit.Handle);
				result = DurationKt._members.StaticMethods.InvokeInt64Method("toDuration.(JLkotlin/time/DurationUnit;)J", ptr);
			}
			finally
			{
				GC.KeepAlive(unit);
			}
			return result;
		}

		// Token: 0x04000189 RID: 393
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/time/DurationKt", typeof(DurationKt));
	}
}
