using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Java.Util
{
	// Token: 0x02000320 RID: 800
	[Register("java/util/LinkedHashMap", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"K",
		"V"
	})]
	public class LinkedHashMap : HashMap, IMap, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x0600221C RID: 8732 RVA: 0x00060608 File Offset: 0x0005E808
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return LinkedHashMap._members;
			}
		}

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x0600221D RID: 8733 RVA: 0x00060610 File Offset: 0x0005E810
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return LinkedHashMap._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x0600221E RID: 8734 RVA: 0x00060634 File Offset: 0x0005E834
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return LinkedHashMap._members.ManagedPeerType;
			}
		}

		// Token: 0x0600221F RID: 8735 RVA: 0x00060640 File Offset: 0x0005E840
		protected LinkedHashMap(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000E17 RID: 3607
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/LinkedHashMap", typeof(LinkedHashMap));
	}
}
