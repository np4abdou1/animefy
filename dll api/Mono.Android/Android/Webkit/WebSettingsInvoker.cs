using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Android.Webkit
{
	// Token: 0x02000109 RID: 265
	[Register("android/webkit/WebSettings", DoNotGenerateAcw = true)]
	internal class WebSettingsInvoker : WebSettings
	{
		// Token: 0x060006A0 RID: 1696 RVA: 0x0000EC73 File Offset: 0x0000CE73
		public WebSettingsInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x060006A1 RID: 1697 RVA: 0x0000EC7D File Offset: 0x0000CE7D
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return WebSettingsInvoker._members;
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060006A2 RID: 1698 RVA: 0x0000EC84 File Offset: 0x0000CE84
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return WebSettingsInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x17000149 RID: 329
		// (set) Token: 0x060006A3 RID: 1699 RVA: 0x0000EC90 File Offset: 0x0000CE90
		public unsafe override CacheModes CacheMode
		{
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((int)value);
				WebSettingsInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("setCacheMode.(I)V", this, ptr);
			}
		}

		// Token: 0x1700014A RID: 330
		// (set) Token: 0x060006A4 RID: 1700 RVA: 0x0000ECCC File Offset: 0x0000CECC
		public unsafe override bool DomStorageEnabled
		{
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				WebSettingsInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("setDomStorageEnabled.(Z)V", this, ptr);
			}
		}

		// Token: 0x1700014B RID: 331
		// (set) Token: 0x060006A5 RID: 1701 RVA: 0x0000ED08 File Offset: 0x0000CF08
		public unsafe override bool JavaScriptEnabled
		{
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				WebSettingsInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("setJavaScriptEnabled.(Z)V", this, ptr);
			}
		}

		// Token: 0x1700014C RID: 332
		// (set) Token: 0x060006A6 RID: 1702 RVA: 0x0000ED44 File Offset: 0x0000CF44
		public unsafe override bool MediaPlaybackRequiresUserGesture
		{
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				WebSettingsInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("setMediaPlaybackRequiresUserGesture.(Z)V", this, ptr);
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x060006A7 RID: 1703 RVA: 0x0000ED80 File Offset: 0x0000CF80
		// (set) Token: 0x060006A8 RID: 1704 RVA: 0x0000EDB4 File Offset: 0x0000CFB4
		public unsafe override string UserAgentString
		{
			get
			{
				return JNIEnv.GetString(WebSettingsInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getUserAgentString.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.NewString(value);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					WebSettingsInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("setUserAgentString.(Ljava/lang/String;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x0000EE10 File Offset: 0x0000D010
		public unsafe override void SetAppCacheEnabled(bool flag)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(flag);
			WebSettingsInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("setAppCacheEnabled.(Z)V", this, ptr);
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x0000EE4C File Offset: 0x0000D04C
		public unsafe override void SetPluginState(WebSettings.PluginState state)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((state == null) ? IntPtr.Zero : state.Handle);
				WebSettingsInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("setPluginState.(Landroid/webkit/WebSettings$PluginState;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(state);
			}
		}

		// Token: 0x040001B0 RID: 432
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/webkit/WebSettings", typeof(WebSettingsInvoker));
	}
}
