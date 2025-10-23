using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.System
{
	// Token: 0x020000F3 RID: 243
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/system/ProcessKt", DoNotGenerateAcw = true)]
	public sealed class ProcessKt : Java.Lang.Object
	{
		// Token: 0x17000296 RID: 662
		// (get) Token: 0x060009F4 RID: 2548 RVA: 0x00021964 File Offset: 0x0001FB64
		internal static IntPtr class_ref
		{
			get
			{
				return ProcessKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x060009F5 RID: 2549 RVA: 0x00021988 File Offset: 0x0001FB88
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ProcessKt._members;
			}
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x060009F6 RID: 2550 RVA: 0x00021990 File Offset: 0x0001FB90
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ProcessKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x060009F7 RID: 2551 RVA: 0x000219B4 File Offset: 0x0001FBB4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ProcessKt._members.ManagedPeerType;
			}
		}

		// Token: 0x060009F8 RID: 2552 RVA: 0x000219C0 File Offset: 0x0001FBC0
		internal ProcessKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0400025B RID: 603
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/system/ProcessKt", typeof(ProcessKt));
	}
}
