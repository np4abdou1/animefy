using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;

namespace Java.Util
{
	// Token: 0x02000325 RID: 805
	[Register("java/util/Random", DoNotGenerateAcw = true)]
	public class Random : Java.Lang.Object, ISerializable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x06002239 RID: 8761 RVA: 0x000609A3 File Offset: 0x0005EBA3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Random._members;
			}
		}

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x0600223A RID: 8762 RVA: 0x000609AC File Offset: 0x0005EBAC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Random._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x0600223B RID: 8763 RVA: 0x000609D0 File Offset: 0x0005EBD0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Random._members.ManagedPeerType;
			}
		}

		// Token: 0x0600223C RID: 8764 RVA: 0x000021E0 File Offset: 0x000003E0
		protected Random(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000E1C RID: 3612
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/Random", typeof(Random));
	}
}
