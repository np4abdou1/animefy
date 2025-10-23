using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Webview.Bridge
{
	// Token: 0x0200007B RID: 123
	[Register("com/unity3d/services/core/webview/bridge/IWebViewSharedObject", DoNotGenerateAcw = true)]
	internal class IWebViewSharedObjectInvoker : Java.Lang.Object, IWebViewSharedObject, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000445 RID: 1093 RVA: 0x0000C444 File Offset: 0x0000A644
		private static IntPtr java_class_ref
		{
			get
			{
				return IWebViewSharedObjectInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000446 RID: 1094 RVA: 0x0000C468 File Offset: 0x0000A668
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IWebViewSharedObjectInvoker._members;
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000447 RID: 1095 RVA: 0x0000C46F File Offset: 0x0000A66F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000448 RID: 1096 RVA: 0x0000C477 File Offset: 0x0000A677
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IWebViewSharedObjectInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x0000C483 File Offset: 0x0000A683
		public static IWebViewSharedObject GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IWebViewSharedObject>(handle, transfer);
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x0000C48C File Offset: 0x0000A68C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IWebViewSharedObjectInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.services.core.webview.bridge.IWebViewSharedObject'.");
			}
			return handle;
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x0000C4B7 File Offset: 0x0000A6B7
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x0000C4E8 File Offset: 0x0000A6E8
		public IWebViewSharedObjectInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IWebViewSharedObjectInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x0000C520 File Offset: 0x0000A720
		private static Delegate GetGetIdHandler()
		{
			if (IWebViewSharedObjectInvoker.cb_getId == null)
			{
				IWebViewSharedObjectInvoker.cb_getId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IWebViewSharedObjectInvoker.n_GetId));
			}
			return IWebViewSharedObjectInvoker.cb_getId;
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x0000C544 File Offset: 0x0000A744
		private static IntPtr n_GetId(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IWebViewSharedObject>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Id);
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x0600044F RID: 1103 RVA: 0x0000C558 File Offset: 0x0000A758
		public string Id
		{
			get
			{
				if (this.id_getId == IntPtr.Zero)
				{
					this.id_getId = JNIEnv.GetMethodID(this.class_ref, "getId", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_getId), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x040000E5 RID: 229
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/webview/bridge/IWebViewSharedObject", typeof(IWebViewSharedObjectInvoker));

		// Token: 0x040000E6 RID: 230
		private IntPtr class_ref;

		// Token: 0x040000E7 RID: 231
		private static Delegate cb_getId;

		// Token: 0x040000E8 RID: 232
		private IntPtr id_getId;
	}
}
