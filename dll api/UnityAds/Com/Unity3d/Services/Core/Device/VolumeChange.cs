using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Device
{
	// Token: 0x02000127 RID: 295
	[Register("com/unity3d/services/core/device/VolumeChange", DoNotGenerateAcw = true)]
	public class VolumeChange : Java.Lang.Object
	{
		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06000BC4 RID: 3012 RVA: 0x000214F0 File Offset: 0x0001F6F0
		internal static IntPtr class_ref
		{
			get
			{
				return VolumeChange._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06000BC5 RID: 3013 RVA: 0x00021514 File Offset: 0x0001F714
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return VolumeChange._members;
			}
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06000BC6 RID: 3014 RVA: 0x0002151C File Offset: 0x0001F71C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return VolumeChange._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06000BC7 RID: 3015 RVA: 0x00021540 File Offset: 0x0001F740
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return VolumeChange._members.ManagedPeerType;
			}
		}

		// Token: 0x06000BC8 RID: 3016 RVA: 0x000021E8 File Offset: 0x000003E8
		protected VolumeChange(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000BC9 RID: 3017 RVA: 0x0002154C File Offset: 0x0001F74C
		[Register(".ctor", "()V", "")]
		public VolumeChange() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(VolumeChange._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			VolumeChange._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000BCA RID: 3018 RVA: 0x000215BA File Offset: 0x0001F7BA
		[Register("clearAllListeners", "()V", "")]
		public static void ClearAllListeners()
		{
			VolumeChange._members.StaticMethods.InvokeVoidMethod("clearAllListeners.()V", null);
		}

		// Token: 0x06000BCB RID: 3019 RVA: 0x000215D4 File Offset: 0x0001F7D4
		[Register("registerListener", "(Lcom/unity3d/services/core/device/IVolumeChangeListener;)V", "")]
		public unsafe static void RegisterListener(IVolumeChangeListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				VolumeChange._members.StaticMethods.InvokeVoidMethod("registerListener.(Lcom/unity3d/services/core/device/IVolumeChangeListener;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x06000BCC RID: 3020 RVA: 0x0002163C File Offset: 0x0001F83C
		[Register("startObserving", "()V", "")]
		public static void StartObserving()
		{
			VolumeChange._members.StaticMethods.InvokeVoidMethod("startObserving.()V", null);
		}

		// Token: 0x06000BCD RID: 3021 RVA: 0x00021654 File Offset: 0x0001F854
		[Register("stopObservering", "()V", "")]
		public static void StopObservering()
		{
			VolumeChange._members.StaticMethods.InvokeVoidMethod("stopObservering.()V", null);
		}

		// Token: 0x06000BCE RID: 3022 RVA: 0x0002166C File Offset: 0x0001F86C
		[Register("unregisterListener", "(Lcom/unity3d/services/core/device/IVolumeChangeListener;)V", "")]
		public unsafe static void UnregisterListener(IVolumeChangeListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				VolumeChange._members.StaticMethods.InvokeVoidMethod("unregisterListener.(Lcom/unity3d/services/core/device/IVolumeChangeListener;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x040002AC RID: 684
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/device/VolumeChange", typeof(VolumeChange));
	}
}
