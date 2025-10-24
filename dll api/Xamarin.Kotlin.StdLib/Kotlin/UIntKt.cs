using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin
{
	// Token: 0x020000AD RID: 173
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/UIntKt", DoNotGenerateAcw = true)]
	public sealed class UIntKt : Java.Lang.Object
	{
		// Token: 0x17000130 RID: 304
		// (get) Token: 0x060004DC RID: 1244 RVA: 0x0000BD1C File Offset: 0x00009F1C
		internal static IntPtr class_ref
		{
			get
			{
				return UIntKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x060004DD RID: 1245 RVA: 0x0000BD40 File Offset: 0x00009F40
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return UIntKt._members;
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x060004DE RID: 1246 RVA: 0x0000BD48 File Offset: 0x00009F48
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return UIntKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x060004DF RID: 1247 RVA: 0x0000BD6C File Offset: 0x00009F6C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return UIntKt._members.ManagedPeerType;
			}
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x0000BD78 File Offset: 0x00009F78
		internal UIntKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0400016A RID: 362
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/UIntKt", typeof(UIntKt));
	}
}
