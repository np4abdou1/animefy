using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.IO.Encoding
{
	// Token: 0x02000237 RID: 567
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/io/encoding/Base64Kt", DoNotGenerateAcw = true)]
	public sealed class Base64Kt : Java.Lang.Object
	{
		// Token: 0x17000798 RID: 1944
		// (get) Token: 0x06001A49 RID: 6729 RVA: 0x00058AF0 File Offset: 0x00056CF0
		internal static IntPtr class_ref
		{
			get
			{
				return Base64Kt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000799 RID: 1945
		// (get) Token: 0x06001A4A RID: 6730 RVA: 0x00058B14 File Offset: 0x00056D14
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Base64Kt._members;
			}
		}

		// Token: 0x1700079A RID: 1946
		// (get) Token: 0x06001A4B RID: 6731 RVA: 0x00058B1C File Offset: 0x00056D1C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Base64Kt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700079B RID: 1947
		// (get) Token: 0x06001A4C RID: 6732 RVA: 0x00058B40 File Offset: 0x00056D40
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Base64Kt._members.ManagedPeerType;
			}
		}

		// Token: 0x06001A4D RID: 6733 RVA: 0x00058B4C File Offset: 0x00056D4C
		internal Base64Kt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x040007FD RID: 2045
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/io/encoding/Base64Kt", typeof(Base64Kt));
	}
}
