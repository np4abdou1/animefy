using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin
{
	// Token: 0x02000044 RID: 68
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/CompareToKt", DoNotGenerateAcw = true)]
	public sealed class CompareToKt : Java.Lang.Object
	{
		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000107 RID: 263 RVA: 0x000026D4 File Offset: 0x000008D4
		internal static IntPtr class_ref
		{
			get
			{
				return CompareToKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000108 RID: 264 RVA: 0x000026F8 File Offset: 0x000008F8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CompareToKt._members;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000109 RID: 265 RVA: 0x00002700 File Offset: 0x00000900
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CompareToKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600010A RID: 266 RVA: 0x00002724 File Offset: 0x00000924
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CompareToKt._members.ManagedPeerType;
			}
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00002730 File Offset: 0x00000930
		internal CompareToKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000011 RID: 17
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/CompareToKt", typeof(CompareToKt));
	}
}
