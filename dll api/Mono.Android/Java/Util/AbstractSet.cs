using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Util
{
	// Token: 0x02000301 RID: 769
	[Register("java/util/AbstractSet", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"E"
	})]
	public abstract class AbstractSet : AbstractCollection, ISet, ICollection, IIterable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x06001EB8 RID: 7864 RVA: 0x00053A8A File Offset: 0x00051C8A
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AbstractSet._members;
			}
		}

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x06001EB9 RID: 7865 RVA: 0x00053A94 File Offset: 0x00051C94
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AbstractSet._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x06001EBA RID: 7866 RVA: 0x00053AB8 File Offset: 0x00051CB8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AbstractSet._members.ManagedPeerType;
			}
		}

		// Token: 0x06001EBB RID: 7867 RVA: 0x0005284F File Offset: 0x00050A4F
		protected AbstractSet(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000C9E RID: 3230
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/AbstractSet", typeof(AbstractSet));
	}
}
