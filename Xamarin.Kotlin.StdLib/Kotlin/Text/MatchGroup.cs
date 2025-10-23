using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Ranges;

namespace Kotlin.Text
{
	// Token: 0x020000E8 RID: 232
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/text/MatchGroup", DoNotGenerateAcw = true)]
	public sealed class MatchGroup : Java.Lang.Object
	{
		// Token: 0x1700025A RID: 602
		// (get) Token: 0x060007C4 RID: 1988 RVA: 0x00014248 File Offset: 0x00012448
		internal static IntPtr class_ref
		{
			get
			{
				return MatchGroup._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x060007C5 RID: 1989 RVA: 0x0001426C File Offset: 0x0001246C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MatchGroup._members;
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x060007C6 RID: 1990 RVA: 0x00014274 File Offset: 0x00012474
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MatchGroup._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x060007C7 RID: 1991 RVA: 0x00014298 File Offset: 0x00012498
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MatchGroup._members.ManagedPeerType;
			}
		}

		// Token: 0x060007C8 RID: 1992 RVA: 0x000142A4 File Offset: 0x000124A4
		internal MatchGroup(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x000142B0 File Offset: 0x000124B0
		[Register(".ctor", "(Ljava/lang/String;Lkotlin/ranges/IntRange;)V", "")]
		public unsafe MatchGroup(string value, IntRange range) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(value);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((range == null) ? IntPtr.Zero : range.Handle);
				base.SetHandle(MatchGroup._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;Lkotlin/ranges/IntRange;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				MatchGroup._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;Lkotlin/ranges/IntRange;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(range);
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x060007CA RID: 1994 RVA: 0x0001437C File Offset: 0x0001257C
		public IntRange Range
		{
			[Register("getRange", "()Lkotlin/ranges/IntRange;", "")]
			get
			{
				return Java.Lang.Object.GetObject<IntRange>(MatchGroup._members.InstanceMethods.InvokeNonvirtualObjectMethod("getRange.()Lkotlin/ranges/IntRange;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x060007CB RID: 1995 RVA: 0x000143B0 File Offset: 0x000125B0
		public string Value
		{
			[Register("getValue", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(MatchGroup._members.InstanceMethods.InvokeNonvirtualObjectMethod("getValue.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x000143E4 File Offset: 0x000125E4
		[Register("component1", "()Ljava/lang/String;", "")]
		public string Component1()
		{
			return JNIEnv.GetString(MatchGroup._members.InstanceMethods.InvokeNonvirtualObjectMethod("component1.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x00014418 File Offset: 0x00012618
		[Register("component2", "()Lkotlin/ranges/IntRange;", "")]
		public IntRange Component2()
		{
			return Java.Lang.Object.GetObject<IntRange>(MatchGroup._members.InstanceMethods.InvokeNonvirtualObjectMethod("component2.()Lkotlin/ranges/IntRange;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x0001444C File Offset: 0x0001264C
		[Register("copy", "(Ljava/lang/String;Lkotlin/ranges/IntRange;)Lkotlin/text/MatchGroup;", "")]
		public unsafe MatchGroup Copy(string value, IntRange range)
		{
			IntPtr intPtr = JNIEnv.NewString(value);
			MatchGroup @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((range == null) ? IntPtr.Zero : range.Handle);
				@object = Java.Lang.Object.GetObject<MatchGroup>(MatchGroup._members.InstanceMethods.InvokeNonvirtualObjectMethod("copy.(Ljava/lang/String;Lkotlin/ranges/IntRange;)Lkotlin/text/MatchGroup;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(range);
			}
			return @object;
		}

		// Token: 0x04000227 RID: 551
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/text/MatchGroup", typeof(MatchGroup));
	}
}
