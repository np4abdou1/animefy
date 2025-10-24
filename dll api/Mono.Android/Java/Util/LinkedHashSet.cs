using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;

namespace Java.Util
{
	// Token: 0x02000321 RID: 801
	[Register("java/util/LinkedHashSet", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"E"
	})]
	public class LinkedHashSet : HashSet, ISerializable, IJavaObject, IDisposable, IJavaPeerable, Java.Lang.ICloneable, ISet, ICollection, IIterable
	{
		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x06002221 RID: 8737 RVA: 0x00060665 File Offset: 0x0005E865
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return LinkedHashSet._members;
			}
		}

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x06002222 RID: 8738 RVA: 0x0006066C File Offset: 0x0005E86C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return LinkedHashSet._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x06002223 RID: 8739 RVA: 0x00060690 File Offset: 0x0005E890
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return LinkedHashSet._members.ManagedPeerType;
			}
		}

		// Token: 0x06002224 RID: 8740 RVA: 0x0006069C File Offset: 0x0005E89C
		protected LinkedHashSet(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000E18 RID: 3608
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/LinkedHashSet", typeof(LinkedHashSet));
	}
}
