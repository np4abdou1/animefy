using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Text
{
	// Token: 0x020000EA RID: 234
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/text/RegexKt", DoNotGenerateAcw = true)]
	public sealed class RegexKt : Java.Lang.Object
	{
		// Token: 0x17000267 RID: 615
		// (get) Token: 0x060007F5 RID: 2037 RVA: 0x000150A8 File Offset: 0x000132A8
		internal static IntPtr class_ref
		{
			get
			{
				return RegexKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x060007F6 RID: 2038 RVA: 0x000150CC File Offset: 0x000132CC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return RegexKt._members;
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x060007F7 RID: 2039 RVA: 0x000150D4 File Offset: 0x000132D4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return RegexKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x060007F8 RID: 2040 RVA: 0x000150F8 File Offset: 0x000132F8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return RegexKt._members.ManagedPeerType;
			}
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x00015104 File Offset: 0x00013304
		internal RegexKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000229 RID: 553
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/text/RegexKt", typeof(RegexKt));
	}
}
