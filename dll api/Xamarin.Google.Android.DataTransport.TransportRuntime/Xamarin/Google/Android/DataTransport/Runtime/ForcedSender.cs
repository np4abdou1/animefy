using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Runtime
{
	// Token: 0x02000021 RID: 33
	[Register("com/google/android/datatransport/runtime/ForcedSender", DoNotGenerateAcw = true)]
	public sealed class ForcedSender : Java.Lang.Object
	{
		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x000038AC File Offset: 0x00001AAC
		internal static IntPtr class_ref
		{
			get
			{
				return ForcedSender._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x000038D0 File Offset: 0x00001AD0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ForcedSender._members;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x000038D8 File Offset: 0x00001AD8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ForcedSender._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x000038FC File Offset: 0x00001AFC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ForcedSender._members.ManagedPeerType;
			}
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x000026C4 File Offset: 0x000008C4
		internal ForcedSender(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00003908 File Offset: 0x00001B08
		[Register("sendBlocking", "(Lcom/google/android/datatransport/Transport;Lcom/google/android/datatransport/Priority;)V", "")]
		public unsafe static void SendBlocking(ITransport transport, Priority priority)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((transport == null) ? IntPtr.Zero : ((Java.Lang.Object)transport).Handle);
				ptr[1] = new JniArgumentValue((priority == null) ? IntPtr.Zero : priority.Handle);
				ForcedSender._members.StaticMethods.InvokeVoidMethod("sendBlocking.(Lcom/google/android/datatransport/Transport;Lcom/google/android/datatransport/Priority;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(transport);
				GC.KeepAlive(priority);
			}
		}

		// Token: 0x04000028 RID: 40
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/ForcedSender", typeof(ForcedSender));
	}
}
