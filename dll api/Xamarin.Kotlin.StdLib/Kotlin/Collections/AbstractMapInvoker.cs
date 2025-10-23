using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;

namespace Kotlin.Collections
{
	// Token: 0x020002B1 RID: 689
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/collections/AbstractMap", DoNotGenerateAcw = true)]
	internal class AbstractMapInvoker : AbstractMap
	{
		// Token: 0x0600201C RID: 8220 RVA: 0x0006B4E5 File Offset: 0x000696E5
		public AbstractMapInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000956 RID: 2390
		// (get) Token: 0x0600201D RID: 8221 RVA: 0x0006B4EF File Offset: 0x000696EF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AbstractMapInvoker._members;
			}
		}

		// Token: 0x17000957 RID: 2391
		// (get) Token: 0x0600201E RID: 8222 RVA: 0x0006B4F6 File Offset: 0x000696F6
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AbstractMapInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x17000958 RID: 2392
		// (get) Token: 0x0600201F RID: 8223 RVA: 0x0006B504 File Offset: 0x00069704
		[Nullable(2)]
		public override ICollection Entries
		{
			[NullableContext(2)]
			[Register("getEntries", "()Ljava/util/Set;", "GetGetEntriesHandler")]
			get
			{
				return JavaSet.FromJniHandle(AbstractMapInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getEntries.()Ljava/util/Set;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x04000975 RID: 2421
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/collections/AbstractMap", typeof(AbstractMapInvoker));
	}
}
