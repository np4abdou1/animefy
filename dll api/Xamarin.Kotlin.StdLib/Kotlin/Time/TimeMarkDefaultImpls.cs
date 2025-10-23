using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Time
{
	// Token: 0x020000CA RID: 202
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/time/TimeMark$DefaultImpls", DoNotGenerateAcw = true)]
	public sealed class TimeMarkDefaultImpls : Java.Lang.Object
	{
		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06000609 RID: 1545 RVA: 0x0000F2CC File Offset: 0x0000D4CC
		internal static IntPtr class_ref
		{
			get
			{
				return TimeMarkDefaultImpls._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x0600060A RID: 1546 RVA: 0x0000F2F0 File Offset: 0x0000D4F0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return TimeMarkDefaultImpls._members;
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x0600060B RID: 1547 RVA: 0x0000F2F8 File Offset: 0x0000D4F8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return TimeMarkDefaultImpls._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x0600060C RID: 1548 RVA: 0x0000F31C File Offset: 0x0000D51C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return TimeMarkDefaultImpls._members.ManagedPeerType;
			}
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x0000F328 File Offset: 0x0000D528
		internal TimeMarkDefaultImpls(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x0000F334 File Offset: 0x0000D534
		[Register("hasNotPassedNow", "(Lkotlin/time/TimeMark;)Z", "")]
		public unsafe static bool HasNotPassedNow(ITimeMark _this)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this == null) ? IntPtr.Zero : ((Java.Lang.Object)_this).Handle);
				result = TimeMarkDefaultImpls._members.StaticMethods.InvokeBooleanMethod("hasNotPassedNow.(Lkotlin/time/TimeMark;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(_this);
			}
			return result;
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x0000F3A0 File Offset: 0x0000D5A0
		[Register("hasPassedNow", "(Lkotlin/time/TimeMark;)Z", "")]
		public unsafe static bool HasPassedNow(ITimeMark _this)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this == null) ? IntPtr.Zero : ((Java.Lang.Object)_this).Handle);
				result = TimeMarkDefaultImpls._members.StaticMethods.InvokeBooleanMethod("hasPassedNow.(Lkotlin/time/TimeMark;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(_this);
			}
			return result;
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x0000F40C File Offset: 0x0000D60C
		[Register("minus-LRDsOJo", "(Lkotlin/time/TimeMark;J)Lkotlin/time/TimeMark;", "")]
		public unsafe static ITimeMark Minus(ITimeMark _this, long duration)
		{
			ITimeMark @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this == null) ? IntPtr.Zero : ((Java.Lang.Object)_this).Handle);
				ptr[1] = new JniArgumentValue(duration);
				@object = Java.Lang.Object.GetObject<ITimeMark>(TimeMarkDefaultImpls._members.StaticMethods.InvokeObjectMethod("minus-LRDsOJo.(Lkotlin/time/TimeMark;J)Lkotlin/time/TimeMark;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this);
			}
			return @object;
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x0000F498 File Offset: 0x0000D698
		[Register("plus-LRDsOJo", "(Lkotlin/time/TimeMark;J)Lkotlin/time/TimeMark;", "")]
		public unsafe static ITimeMark Plus(ITimeMark _this, long duration)
		{
			ITimeMark @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this == null) ? IntPtr.Zero : ((Java.Lang.Object)_this).Handle);
				ptr[1] = new JniArgumentValue(duration);
				@object = Java.Lang.Object.GetObject<ITimeMark>(TimeMarkDefaultImpls._members.StaticMethods.InvokeObjectMethod("plus-LRDsOJo.(Lkotlin/time/TimeMark;J)Lkotlin/time/TimeMark;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this);
			}
			return @object;
		}

		// Token: 0x040001AD RID: 429
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/time/TimeMark$DefaultImpls", typeof(TimeMarkDefaultImpls));
	}
}
