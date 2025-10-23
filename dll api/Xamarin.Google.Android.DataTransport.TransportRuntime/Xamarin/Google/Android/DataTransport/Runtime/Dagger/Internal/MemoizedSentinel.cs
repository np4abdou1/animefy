using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Runtime.Dagger.Internal
{
	// Token: 0x020000EF RID: 239
	[Register("com/google/android/datatransport/runtime/dagger/internal/MemoizedSentinel", DoNotGenerateAcw = true)]
	public sealed class MemoizedSentinel : Java.Lang.Object
	{
		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06000874 RID: 2164 RVA: 0x00017688 File Offset: 0x00015888
		internal static IntPtr class_ref
		{
			get
			{
				return MemoizedSentinel._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06000875 RID: 2165 RVA: 0x000176AC File Offset: 0x000158AC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MemoizedSentinel._members;
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06000876 RID: 2166 RVA: 0x000176B4 File Offset: 0x000158B4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MemoizedSentinel._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06000877 RID: 2167 RVA: 0x000176D8 File Offset: 0x000158D8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MemoizedSentinel._members.ManagedPeerType;
			}
		}

		// Token: 0x06000878 RID: 2168 RVA: 0x000026C4 File Offset: 0x000008C4
		internal MemoizedSentinel(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000879 RID: 2169 RVA: 0x000176E4 File Offset: 0x000158E4
		[Register(".ctor", "()V", "")]
		public MemoizedSentinel() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(MemoizedSentinel._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			MemoizedSentinel._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x04000264 RID: 612
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/dagger/internal/MemoizedSentinel", typeof(MemoizedSentinel));
	}
}
