using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.IO.Encoding
{
	// Token: 0x02000236 RID: 566
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/io/encoding/Base64JVMKt", DoNotGenerateAcw = true)]
	public sealed class Base64JVMKt : Java.Lang.Object
	{
		// Token: 0x17000794 RID: 1940
		// (get) Token: 0x06001A43 RID: 6723 RVA: 0x00058A6C File Offset: 0x00056C6C
		internal static IntPtr class_ref
		{
			get
			{
				return Base64JVMKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x06001A44 RID: 6724 RVA: 0x00058A90 File Offset: 0x00056C90
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Base64JVMKt._members;
			}
		}

		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x06001A45 RID: 6725 RVA: 0x00058A98 File Offset: 0x00056C98
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Base64JVMKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x06001A46 RID: 6726 RVA: 0x00058ABC File Offset: 0x00056CBC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Base64JVMKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06001A47 RID: 6727 RVA: 0x00058AC8 File Offset: 0x00056CC8
		internal Base64JVMKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x040007FC RID: 2044
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/io/encoding/Base64JVMKt", typeof(Base64JVMKt));
	}
}
