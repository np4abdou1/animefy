using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Jdk7
{
	// Token: 0x02000219 RID: 537
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/jdk7/AutoCloseableKt", DoNotGenerateAcw = true)]
	public sealed class AutoCloseableKt : Java.Lang.Object
	{
		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x06001902 RID: 6402 RVA: 0x00053484 File Offset: 0x00051684
		internal static IntPtr class_ref
		{
			get
			{
				return AutoCloseableKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700071C RID: 1820
		// (get) Token: 0x06001903 RID: 6403 RVA: 0x000534A8 File Offset: 0x000516A8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AutoCloseableKt._members;
			}
		}

		// Token: 0x1700071D RID: 1821
		// (get) Token: 0x06001904 RID: 6404 RVA: 0x000534B0 File Offset: 0x000516B0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AutoCloseableKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700071E RID: 1822
		// (get) Token: 0x06001905 RID: 6405 RVA: 0x000534D4 File Offset: 0x000516D4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AutoCloseableKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06001906 RID: 6406 RVA: 0x000534E0 File Offset: 0x000516E0
		internal AutoCloseableKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x040007C9 RID: 1993
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jdk7/AutoCloseableKt", typeof(AutoCloseableKt));
	}
}
