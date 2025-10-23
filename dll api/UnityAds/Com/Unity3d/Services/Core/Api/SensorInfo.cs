using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.Webview.Bridge;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Api
{
	// Token: 0x02000194 RID: 404
	[Register("com/unity3d/services/core/api/SensorInfo", DoNotGenerateAcw = true)]
	public class SensorInfo : Java.Lang.Object
	{
		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x06001276 RID: 4726 RVA: 0x00034134 File Offset: 0x00032334
		internal static IntPtr class_ref
		{
			get
			{
				return SensorInfo._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x06001277 RID: 4727 RVA: 0x00034158 File Offset: 0x00032358
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SensorInfo._members;
			}
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x06001278 RID: 4728 RVA: 0x00034160 File Offset: 0x00032360
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SensorInfo._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x06001279 RID: 4729 RVA: 0x00034184 File Offset: 0x00032384
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SensorInfo._members.ManagedPeerType;
			}
		}

		// Token: 0x0600127A RID: 4730 RVA: 0x000021E8 File Offset: 0x000003E8
		protected SensorInfo(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600127B RID: 4731 RVA: 0x00034190 File Offset: 0x00032390
		[Register(".ctor", "()V", "")]
		public SensorInfo() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(SensorInfo._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			SensorInfo._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x0600127C RID: 4732 RVA: 0x00034200 File Offset: 0x00032400
		[Register("getAccelerometerData", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetAccelerometerData(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				SensorInfo._members.StaticMethods.InvokeVoidMethod("getAccelerometerData.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x0600127D RID: 4733 RVA: 0x00034264 File Offset: 0x00032464
		[Register("isAccelerometerActive", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void IsAccelerometerActive(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				SensorInfo._members.StaticMethods.InvokeVoidMethod("isAccelerometerActive.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x0600127E RID: 4734 RVA: 0x000342C8 File Offset: 0x000324C8
		[Register("startAccelerometerUpdates", "(Ljava/lang/Integer;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void StartAccelerometerUpdates(Integer sensorDelay, WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((sensorDelay == null) ? IntPtr.Zero : sensorDelay.Handle);
				ptr[1] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				SensorInfo._members.StaticMethods.InvokeVoidMethod("startAccelerometerUpdates.(Ljava/lang/Integer;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(sensorDelay);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x0600127F RID: 4735 RVA: 0x00034354 File Offset: 0x00032554
		[Register("stopAccelerometerUpdates", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void StopAccelerometerUpdates(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				SensorInfo._members.StaticMethods.InvokeVoidMethod("stopAccelerometerUpdates.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x04000457 RID: 1111
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/api/SensorInfo", typeof(SensorInfo));
	}
}
