using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;

namespace Java.Nio.Channels.Spi
{
	// Token: 0x020003A9 RID: 937
	[Register("java/nio/channels/spi/AbstractInterruptibleChannel", DoNotGenerateAcw = true)]
	public abstract class AbstractInterruptibleChannel : Java.Lang.Object, IChannel, ICloseable, IJavaObject, IDisposable, IJavaPeerable, IInterruptibleChannel
	{
		// Token: 0x170007FA RID: 2042
		// (get) Token: 0x0600296A RID: 10602 RVA: 0x00074E92 File Offset: 0x00073092
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AbstractInterruptibleChannel._members;
			}
		}

		// Token: 0x170007FB RID: 2043
		// (get) Token: 0x0600296B RID: 10603 RVA: 0x00074E9C File Offset: 0x0007309C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AbstractInterruptibleChannel._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007FC RID: 2044
		// (get) Token: 0x0600296C RID: 10604 RVA: 0x00074EC0 File Offset: 0x000730C0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AbstractInterruptibleChannel._members.ManagedPeerType;
			}
		}

		// Token: 0x0600296D RID: 10605 RVA: 0x000021E0 File Offset: 0x000003E0
		protected AbstractInterruptibleChannel(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x170007FD RID: 2045
		// (get) Token: 0x0600296E RID: 10606 RVA: 0x00074ECC File Offset: 0x000730CC
		public bool IsOpen
		{
			get
			{
				return AbstractInterruptibleChannel._members.InstanceMethods.InvokeNonvirtualBooleanMethod("isOpen.()Z", this, null);
			}
		}

		// Token: 0x0600296F RID: 10607 RVA: 0x00074EE5 File Offset: 0x000730E5
		public void Close()
		{
			AbstractInterruptibleChannel._members.InstanceMethods.InvokeNonvirtualVoidMethod("close.()V", this, null);
		}

		// Token: 0x040010FE RID: 4350
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/nio/channels/spi/AbstractInterruptibleChannel", typeof(AbstractInterruptibleChannel));
	}
}
