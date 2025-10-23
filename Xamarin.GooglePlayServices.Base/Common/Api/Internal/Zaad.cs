using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Common.Api.Internal
{
	// Token: 0x0200003E RID: 62
	[Register("com/google/android/gms/common/api/internal/zaad", DoNotGenerateAcw = true)]
	public sealed class Zaad : Java.Lang.Object
	{
		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000257 RID: 599 RVA: 0x00007EFC File Offset: 0x000060FC
		internal static IntPtr class_ref
		{
			get
			{
				return Zaad._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000258 RID: 600 RVA: 0x00007F20 File Offset: 0x00006120
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Zaad._members;
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000259 RID: 601 RVA: 0x00007F28 File Offset: 0x00006128
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Zaad._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x0600025A RID: 602 RVA: 0x00007F4C File Offset: 0x0000614C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Zaad._members.ManagedPeerType;
			}
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00003280 File Offset: 0x00001480
		internal Zaad(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00007F58 File Offset: 0x00006158
		[Register(".ctor", "()V", "")]
		public Zaad() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(Zaad._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			Zaad._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x0600025D RID: 605 RVA: 0x00007FC6 File Offset: 0x000061C6
		[Register("zaf", "()V", "")]
		public void Zaf()
		{
			Zaad._members.InstanceMethods.InvokeNonvirtualVoidMethod("zaf.()V", this, null);
		}

		// Token: 0x0400007F RID: 127
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/api/internal/zaad", typeof(Zaad));
	}
}
