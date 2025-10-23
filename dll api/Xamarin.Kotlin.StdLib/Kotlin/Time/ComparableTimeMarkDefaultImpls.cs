using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Time
{
	// Token: 0x020000C5 RID: 197
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/time/ComparableTimeMark$DefaultImpls", DoNotGenerateAcw = true)]
	public sealed class ComparableTimeMarkDefaultImpls : Java.Lang.Object
	{
		// Token: 0x17000194 RID: 404
		// (get) Token: 0x060005BD RID: 1469 RVA: 0x0000E608 File Offset: 0x0000C808
		internal static IntPtr class_ref
		{
			get
			{
				return ComparableTimeMarkDefaultImpls._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x060005BE RID: 1470 RVA: 0x0000E62C File Offset: 0x0000C82C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ComparableTimeMarkDefaultImpls._members;
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x060005BF RID: 1471 RVA: 0x0000E634 File Offset: 0x0000C834
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ComparableTimeMarkDefaultImpls._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x060005C0 RID: 1472 RVA: 0x0000E658 File Offset: 0x0000C858
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ComparableTimeMarkDefaultImpls._members.ManagedPeerType;
			}
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x0000E664 File Offset: 0x0000C864
		internal ComparableTimeMarkDefaultImpls(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x0000E670 File Offset: 0x0000C870
		[Register("compareTo", "(Lkotlin/time/ComparableTimeMark;Lkotlin/time/ComparableTimeMark;)I", "")]
		public unsafe static int CompareTo(IComparableTimeMark _this, IComparableTimeMark other)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this == null) ? IntPtr.Zero : ((Java.Lang.Object)_this).Handle);
				ptr[1] = new JniArgumentValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
				result = ComparableTimeMarkDefaultImpls._members.StaticMethods.InvokeInt32Method("compareTo.(Lkotlin/time/ComparableTimeMark;Lkotlin/time/ComparableTimeMark;)I", ptr);
			}
			finally
			{
				GC.KeepAlive(_this);
				GC.KeepAlive(other);
			}
			return result;
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x0000E708 File Offset: 0x0000C908
		[Register("hasNotPassedNow", "(Lkotlin/time/ComparableTimeMark;)Z", "")]
		public unsafe static bool HasNotPassedNow(IComparableTimeMark _this)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this == null) ? IntPtr.Zero : ((Java.Lang.Object)_this).Handle);
				result = ComparableTimeMarkDefaultImpls._members.StaticMethods.InvokeBooleanMethod("hasNotPassedNow.(Lkotlin/time/ComparableTimeMark;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(_this);
			}
			return result;
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x0000E774 File Offset: 0x0000C974
		[Register("hasPassedNow", "(Lkotlin/time/ComparableTimeMark;)Z", "")]
		public unsafe static bool HasPassedNow(IComparableTimeMark _this)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this == null) ? IntPtr.Zero : ((Java.Lang.Object)_this).Handle);
				result = ComparableTimeMarkDefaultImpls._members.StaticMethods.InvokeBooleanMethod("hasPassedNow.(Lkotlin/time/ComparableTimeMark;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(_this);
			}
			return result;
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x0000E7E0 File Offset: 0x0000C9E0
		[Register("minus-LRDsOJo", "(Lkotlin/time/ComparableTimeMark;J)Lkotlin/time/ComparableTimeMark;", "")]
		public unsafe static IComparableTimeMark Minus_LRDsOJo(IComparableTimeMark _this, long duration)
		{
			IComparableTimeMark @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this == null) ? IntPtr.Zero : ((Java.Lang.Object)_this).Handle);
				ptr[1] = new JniArgumentValue(duration);
				@object = Java.Lang.Object.GetObject<IComparableTimeMark>(ComparableTimeMarkDefaultImpls._members.StaticMethods.InvokeObjectMethod("minus-LRDsOJo.(Lkotlin/time/ComparableTimeMark;J)Lkotlin/time/ComparableTimeMark;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this);
			}
			return @object;
		}

		// Token: 0x0400018C RID: 396
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/time/ComparableTimeMark$DefaultImpls", typeof(ComparableTimeMarkDefaultImpls));
	}
}
