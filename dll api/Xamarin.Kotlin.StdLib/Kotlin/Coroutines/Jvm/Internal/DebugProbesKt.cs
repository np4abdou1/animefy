using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Coroutines.Jvm.Internal
{
	// Token: 0x02000266 RID: 614
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/coroutines/jvm/internal/DebugProbesKt", DoNotGenerateAcw = true)]
	public sealed class DebugProbesKt : Java.Lang.Object
	{
		// Token: 0x17000812 RID: 2066
		// (get) Token: 0x06001C10 RID: 7184 RVA: 0x0005DBB4 File Offset: 0x0005BDB4
		internal static IntPtr class_ref
		{
			get
			{
				return DebugProbesKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000813 RID: 2067
		// (get) Token: 0x06001C11 RID: 7185 RVA: 0x0005DBD8 File Offset: 0x0005BDD8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DebugProbesKt._members;
			}
		}

		// Token: 0x17000814 RID: 2068
		// (get) Token: 0x06001C12 RID: 7186 RVA: 0x0005DBE0 File Offset: 0x0005BDE0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DebugProbesKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000815 RID: 2069
		// (get) Token: 0x06001C13 RID: 7187 RVA: 0x0005DC04 File Offset: 0x0005BE04
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DebugProbesKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06001C14 RID: 7188 RVA: 0x0005DC10 File Offset: 0x0005BE10
		internal DebugProbesKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x040008A9 RID: 2217
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/coroutines/jvm/internal/DebugProbesKt", typeof(DebugProbesKt));
	}
}
