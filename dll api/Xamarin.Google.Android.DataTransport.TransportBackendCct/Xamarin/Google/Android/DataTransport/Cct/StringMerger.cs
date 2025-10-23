using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Cct
{
	// Token: 0x0200000A RID: 10
	[Register("com/google/android/datatransport/cct/StringMerger", DoNotGenerateAcw = true)]
	public sealed class StringMerger : Java.Lang.Object
	{
		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000030 RID: 48 RVA: 0x00002578 File Offset: 0x00000778
		internal static IntPtr class_ref
		{
			get
			{
				return StringMerger._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000031 RID: 49 RVA: 0x0000259C File Offset: 0x0000079C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return StringMerger._members;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000032 RID: 50 RVA: 0x000025A4 File Offset: 0x000007A4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return StringMerger._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000033 RID: 51 RVA: 0x000025C8 File Offset: 0x000007C8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return StringMerger._members.ManagedPeerType;
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000020B4 File Offset: 0x000002B4
		internal StringMerger(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000025D4 File Offset: 0x000007D4
		[Register(".ctor", "()V", "")]
		public StringMerger() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(StringMerger._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			StringMerger._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x04000004 RID: 4
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/cct/StringMerger", typeof(StringMerger));
	}
}
