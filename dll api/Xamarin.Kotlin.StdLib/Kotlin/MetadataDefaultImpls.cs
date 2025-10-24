using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin
{
	// Token: 0x0200006D RID: 109
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/Metadata$DefaultImpls", DoNotGenerateAcw = true)]
	public sealed class MetadataDefaultImpls : Java.Lang.Object
	{
		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000266 RID: 614 RVA: 0x00005A68 File Offset: 0x00003C68
		internal static IntPtr class_ref
		{
			get
			{
				return MetadataDefaultImpls._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000267 RID: 615 RVA: 0x00005A8C File Offset: 0x00003C8C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MetadataDefaultImpls._members;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000268 RID: 616 RVA: 0x00005A94 File Offset: 0x00003C94
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MetadataDefaultImpls._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000269 RID: 617 RVA: 0x00005AB8 File Offset: 0x00003CB8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MetadataDefaultImpls._members.ManagedPeerType;
			}
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00005AC4 File Offset: 0x00003CC4
		internal MetadataDefaultImpls(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0400009A RID: 154
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/Metadata$DefaultImpls", typeof(MetadataDefaultImpls));
	}
}
