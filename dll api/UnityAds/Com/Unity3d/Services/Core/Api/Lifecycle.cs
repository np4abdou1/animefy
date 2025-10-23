using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.Lifecycle;
using Com.Unity3d.Services.Core.Webview.Bridge;
using Java.Interop;
using Java.Lang;
using Org.Json;

namespace Com.Unity3d.Services.Core.Api
{
	// Token: 0x0200018E RID: 398
	[Register("com/unity3d/services/core/api/Lifecycle", DoNotGenerateAcw = true)]
	public class Lifecycle : Java.Lang.Object
	{
		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x06001224 RID: 4644 RVA: 0x0003237C File Offset: 0x0003057C
		internal static IntPtr class_ref
		{
			get
			{
				return Lifecycle._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x06001225 RID: 4645 RVA: 0x000323A0 File Offset: 0x000305A0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Lifecycle._members;
			}
		}

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x06001226 RID: 4646 RVA: 0x000323A8 File Offset: 0x000305A8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Lifecycle._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x06001227 RID: 4647 RVA: 0x000323CC File Offset: 0x000305CC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Lifecycle._members.ManagedPeerType;
			}
		}

		// Token: 0x06001228 RID: 4648 RVA: 0x000021E8 File Offset: 0x000003E8
		protected Lifecycle(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001229 RID: 4649 RVA: 0x000323D8 File Offset: 0x000305D8
		[Register(".ctor", "()V", "")]
		public Lifecycle() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(Lifecycle._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			Lifecycle._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x0600122A RID: 4650 RVA: 0x00032448 File Offset: 0x00030648
		// (set) Token: 0x0600122B RID: 4651 RVA: 0x0003247C File Offset: 0x0003067C
		public unsafe static LifecycleListener LifecycleListener
		{
			[Register("getLifecycleListener", "()Lcom/unity3d/services/core/lifecycle/LifecycleListener;", "")]
			get
			{
				return Java.Lang.Object.GetObject<LifecycleListener>(Lifecycle._members.StaticMethods.InvokeObjectMethod("getLifecycleListener.()Lcom/unity3d/services/core/lifecycle/LifecycleListener;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setLifecycleListener", "(Lcom/unity3d/services/core/lifecycle/LifecycleListener;)V", "")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					Lifecycle._members.StaticMethods.InvokeVoidMethod("setLifecycleListener.(Lcom/unity3d/services/core/lifecycle/LifecycleListener;)V", ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x0600122C RID: 4652 RVA: 0x000324E0 File Offset: 0x000306E0
		[Register("register", "(Lorg/json/JSONArray;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void Register(JSONArray events, WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((events == null) ? IntPtr.Zero : events.Handle);
				ptr[1] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Lifecycle._members.StaticMethods.InvokeVoidMethod("register.(Lorg/json/JSONArray;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(events);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x0600122D RID: 4653 RVA: 0x0003256C File Offset: 0x0003076C
		[Register("unregister", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void Unregister(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Lifecycle._members.StaticMethods.InvokeVoidMethod("unregister.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x04000451 RID: 1105
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/api/Lifecycle", typeof(Lifecycle));
	}
}
