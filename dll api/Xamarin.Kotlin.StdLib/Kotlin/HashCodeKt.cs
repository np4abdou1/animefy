using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin
{
	// Token: 0x02000054 RID: 84
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/HashCodeKt", DoNotGenerateAcw = true)]
	public sealed class HashCodeKt : Java.Lang.Object
	{
		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000158 RID: 344 RVA: 0x000032E4 File Offset: 0x000014E4
		internal static IntPtr class_ref
		{
			get
			{
				return HashCodeKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000159 RID: 345 RVA: 0x00003308 File Offset: 0x00001508
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return HashCodeKt._members;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600015A RID: 346 RVA: 0x00003310 File Offset: 0x00001510
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return HashCodeKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600015B RID: 347 RVA: 0x00003334 File Offset: 0x00001534
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return HashCodeKt._members.ManagedPeerType;
			}
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00003340 File Offset: 0x00001540
		internal HashCodeKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0400001F RID: 31
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/HashCodeKt", typeof(HashCodeKt));
	}
}
