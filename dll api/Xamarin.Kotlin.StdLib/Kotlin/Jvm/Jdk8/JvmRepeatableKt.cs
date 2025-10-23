using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Jvm.Jdk8
{
	// Token: 0x0200018D RID: 397
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/jvm/jdk8/JvmRepeatableKt", DoNotGenerateAcw = true)]
	public sealed class JvmRepeatableKt : Java.Lang.Object
	{
		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x06001373 RID: 4979 RVA: 0x0003F3DC File Offset: 0x0003D5DC
		internal static IntPtr class_ref
		{
			get
			{
				return JvmRepeatableKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x06001374 RID: 4980 RVA: 0x0003F400 File Offset: 0x0003D600
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return JvmRepeatableKt._members;
			}
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x06001375 RID: 4981 RVA: 0x0003F408 File Offset: 0x0003D608
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return JvmRepeatableKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x06001376 RID: 4982 RVA: 0x0003F42C File Offset: 0x0003D62C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return JvmRepeatableKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06001377 RID: 4983 RVA: 0x0003F438 File Offset: 0x0003D638
		internal JvmRepeatableKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000676 RID: 1654
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/jdk8/JvmRepeatableKt", typeof(JvmRepeatableKt));
	}
}
