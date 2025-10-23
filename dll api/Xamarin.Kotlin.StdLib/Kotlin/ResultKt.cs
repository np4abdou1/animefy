using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin
{
	// Token: 0x0200009B RID: 155
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/ResultKt", DoNotGenerateAcw = true)]
	public sealed class ResultKt : Java.Lang.Object
	{
		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000446 RID: 1094 RVA: 0x0000A2DC File Offset: 0x000084DC
		internal static IntPtr class_ref
		{
			get
			{
				return ResultKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000447 RID: 1095 RVA: 0x0000A300 File Offset: 0x00008500
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ResultKt._members;
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000448 RID: 1096 RVA: 0x0000A308 File Offset: 0x00008508
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ResultKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000449 RID: 1097 RVA: 0x0000A32C File Offset: 0x0000852C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ResultKt._members.ManagedPeerType;
			}
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x0000A338 File Offset: 0x00008538
		internal ResultKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000150 RID: 336
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/ResultKt", typeof(ResultKt));
	}
}
