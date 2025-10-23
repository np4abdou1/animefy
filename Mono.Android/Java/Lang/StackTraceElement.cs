using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.IO;

namespace Java.Lang
{
	// Token: 0x020003EE RID: 1006
	[Register("java/lang/StackTraceElement", DoNotGenerateAcw = true)]
	public sealed class StackTraceElement : Object, ISerializable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170008BE RID: 2238
		// (get) Token: 0x06002C4A RID: 11338 RVA: 0x0007A4B9 File Offset: 0x000786B9
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return StackTraceElement._members;
			}
		}

		// Token: 0x170008BF RID: 2239
		// (get) Token: 0x06002C4B RID: 11339 RVA: 0x0007A4C0 File Offset: 0x000786C0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return StackTraceElement._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170008C0 RID: 2240
		// (get) Token: 0x06002C4C RID: 11340 RVA: 0x0007A4E4 File Offset: 0x000786E4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return StackTraceElement._members.ManagedPeerType;
			}
		}

		// Token: 0x06002C4D RID: 11341 RVA: 0x000021E0 File Offset: 0x000003E0
		internal StackTraceElement(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0400118E RID: 4494
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/lang/StackTraceElement", typeof(StackTraceElement));
	}
}
