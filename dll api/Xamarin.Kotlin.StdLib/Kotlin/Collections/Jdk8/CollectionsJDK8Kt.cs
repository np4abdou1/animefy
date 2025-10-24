using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Collections.Jdk8
{
	// Token: 0x020002DA RID: 730
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/collections/jdk8/CollectionsJDK8Kt", DoNotGenerateAcw = true)]
	public sealed class CollectionsJDK8Kt : Java.Lang.Object
	{
		// Token: 0x170009F2 RID: 2546
		// (get) Token: 0x06002933 RID: 10547 RVA: 0x000B761C File Offset: 0x000B581C
		internal static IntPtr class_ref
		{
			get
			{
				return CollectionsJDK8Kt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170009F3 RID: 2547
		// (get) Token: 0x06002934 RID: 10548 RVA: 0x000B7640 File Offset: 0x000B5840
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CollectionsJDK8Kt._members;
			}
		}

		// Token: 0x170009F4 RID: 2548
		// (get) Token: 0x06002935 RID: 10549 RVA: 0x000B7648 File Offset: 0x000B5848
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CollectionsJDK8Kt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170009F5 RID: 2549
		// (get) Token: 0x06002936 RID: 10550 RVA: 0x000B766C File Offset: 0x000B586C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CollectionsJDK8Kt._members.ManagedPeerType;
			}
		}

		// Token: 0x06002937 RID: 10551 RVA: 0x000B7678 File Offset: 0x000B5878
		internal CollectionsJDK8Kt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x040009C8 RID: 2504
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/collections/jdk8/CollectionsJDK8Kt", typeof(CollectionsJDK8Kt));
	}
}
