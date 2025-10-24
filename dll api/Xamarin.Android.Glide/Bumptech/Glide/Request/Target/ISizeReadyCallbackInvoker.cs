using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Request.Target
{
	// Token: 0x020000BB RID: 187
	[Register("com/bumptech/glide/request/target/SizeReadyCallback", DoNotGenerateAcw = true)]
	internal class ISizeReadyCallbackInvoker : Java.Lang.Object, ISizeReadyCallback, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000225 RID: 549
		// (get) Token: 0x060009CE RID: 2510 RVA: 0x0001E9F0 File Offset: 0x0001CBF0
		private static IntPtr java_class_ref
		{
			get
			{
				return ISizeReadyCallbackInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x060009CF RID: 2511 RVA: 0x0001EA14 File Offset: 0x0001CC14
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ISizeReadyCallbackInvoker._members;
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x060009D0 RID: 2512 RVA: 0x0001EA1B File Offset: 0x0001CC1B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x060009D1 RID: 2513 RVA: 0x0001EA23 File Offset: 0x0001CC23
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ISizeReadyCallbackInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060009D2 RID: 2514 RVA: 0x0001EA2F File Offset: 0x0001CC2F
		public static ISizeReadyCallback GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ISizeReadyCallback>(handle, transfer);
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x0001EA38 File Offset: 0x0001CC38
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ISizeReadyCallbackInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.bumptech.glide.request.target.SizeReadyCallback'.");
			}
			return handle;
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x0001EA63 File Offset: 0x0001CC63
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x0001EA94 File Offset: 0x0001CC94
		public ISizeReadyCallbackInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ISizeReadyCallbackInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x0001EACC File Offset: 0x0001CCCC
		private static Delegate GetOnSizeReady_IIHandler()
		{
			if (ISizeReadyCallbackInvoker.cb_onSizeReady_II == null)
			{
				ISizeReadyCallbackInvoker.cb_onSizeReady_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPII_V(ISizeReadyCallbackInvoker.n_OnSizeReady_II));
			}
			return ISizeReadyCallbackInvoker.cb_onSizeReady_II;
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x0001EAF0 File Offset: 0x0001CCF0
		private static void n_OnSizeReady_II(IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			Java.Lang.Object.GetObject<ISizeReadyCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnSizeReady(p0, p1);
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x0001EB04 File Offset: 0x0001CD04
		public unsafe void OnSizeReady(int p0, int p1)
		{
			if (this.id_onSizeReady_II == IntPtr.Zero)
			{
				this.id_onSizeReady_II = JNIEnv.GetMethodID(this.class_ref, "onSizeReady", "(II)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			ptr[1] = new JValue(p1);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onSizeReady_II, ptr);
		}

		// Token: 0x04000264 RID: 612
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/request/target/SizeReadyCallback", typeof(ISizeReadyCallbackInvoker));

		// Token: 0x04000265 RID: 613
		private IntPtr class_ref;

		// Token: 0x04000266 RID: 614
		private static Delegate cb_onSizeReady_II;

		// Token: 0x04000267 RID: 615
		private IntPtr id_onSizeReady_II;
	}
}
