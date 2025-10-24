using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.IO
{
	// Token: 0x0200021F RID: 543
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/io/ExceptionsKt", DoNotGenerateAcw = true)]
	public sealed class ExceptionsKt : Java.Lang.Object
	{
		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x0600192E RID: 6446 RVA: 0x00053B54 File Offset: 0x00051D54
		internal static IntPtr class_ref
		{
			get
			{
				return ExceptionsKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x0600192F RID: 6447 RVA: 0x00053B78 File Offset: 0x00051D78
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ExceptionsKt._members;
			}
		}

		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x06001930 RID: 6448 RVA: 0x00053B80 File Offset: 0x00051D80
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ExceptionsKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x06001931 RID: 6449 RVA: 0x00053BA4 File Offset: 0x00051DA4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ExceptionsKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06001932 RID: 6450 RVA: 0x00053BB0 File Offset: 0x00051DB0
		internal ExceptionsKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x040007D0 RID: 2000
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/io/ExceptionsKt", typeof(ExceptionsKt));
	}
}
