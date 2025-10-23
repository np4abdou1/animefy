using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Coroutines.Jvm.Internal
{
	// Token: 0x02000264 RID: 612
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/coroutines/jvm/internal/Boxing", DoNotGenerateAcw = true)]
	public sealed class Boxing : Java.Lang.Object
	{
		// Token: 0x1700080A RID: 2058
		// (get) Token: 0x06001C04 RID: 7172 RVA: 0x0005DAAC File Offset: 0x0005BCAC
		internal static IntPtr class_ref
		{
			get
			{
				return Boxing._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700080B RID: 2059
		// (get) Token: 0x06001C05 RID: 7173 RVA: 0x0005DAD0 File Offset: 0x0005BCD0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Boxing._members;
			}
		}

		// Token: 0x1700080C RID: 2060
		// (get) Token: 0x06001C06 RID: 7174 RVA: 0x0005DAD8 File Offset: 0x0005BCD8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Boxing._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700080D RID: 2061
		// (get) Token: 0x06001C07 RID: 7175 RVA: 0x0005DAFC File Offset: 0x0005BCFC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Boxing._members.ManagedPeerType;
			}
		}

		// Token: 0x06001C08 RID: 7176 RVA: 0x0005DB08 File Offset: 0x0005BD08
		internal Boxing(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x040008A7 RID: 2215
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/coroutines/jvm/internal/Boxing", typeof(Boxing));
	}
}
