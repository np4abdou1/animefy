using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Java.Lang
{
	// Token: 0x020003C3 RID: 963
	[Register("java/lang/ClassLoader", DoNotGenerateAcw = true)]
	public abstract class ClassLoader : Object
	{
		// Token: 0x1700084A RID: 2122
		// (get) Token: 0x06002A8F RID: 10895 RVA: 0x000770D7 File Offset: 0x000752D7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ClassLoader._members;
			}
		}

		// Token: 0x1700084B RID: 2123
		// (get) Token: 0x06002A90 RID: 10896 RVA: 0x000770E0 File Offset: 0x000752E0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ClassLoader._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700084C RID: 2124
		// (get) Token: 0x06002A91 RID: 10897 RVA: 0x00077104 File Offset: 0x00075304
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ClassLoader._members.ManagedPeerType;
			}
		}

		// Token: 0x06002A92 RID: 10898 RVA: 0x000021E0 File Offset: 0x000003E0
		protected ClassLoader(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04001135 RID: 4405
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/lang/ClassLoader", typeof(ClassLoader));
	}
}
