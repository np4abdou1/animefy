using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Misc
{
	// Token: 0x020000D8 RID: 216
	[Register("com/unity3d/services/core/misc/IEventListener", DoNotGenerateAcw = true)]
	internal class IEventListenerInvoker : Java.Lang.Object, IEventListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x0600087D RID: 2173 RVA: 0x000189A8 File Offset: 0x00016BA8
		private static IntPtr java_class_ref
		{
			get
			{
				return IEventListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x0600087E RID: 2174 RVA: 0x000189CC File Offset: 0x00016BCC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IEventListenerInvoker._members;
			}
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x0600087F RID: 2175 RVA: 0x000189D3 File Offset: 0x00016BD3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06000880 RID: 2176 RVA: 0x000189DB File Offset: 0x00016BDB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IEventListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x000189E7 File Offset: 0x00016BE7
		public static IEventListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IEventListener>(handle, transfer);
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x000189F0 File Offset: 0x00016BF0
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IEventListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.services.core.misc.IEventListener'.");
			}
			return handle;
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x00018A1B File Offset: 0x00016C1B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x00018A4C File Offset: 0x00016C4C
		public IEventListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IEventListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x00018A84 File Offset: 0x00016C84
		private static Delegate GetOnNextEvent_Ljava_lang_Object_Handler()
		{
			if (IEventListenerInvoker.cb_onNextEvent_Ljava_lang_Object_ == null)
			{
				IEventListenerInvoker.cb_onNextEvent_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IEventListenerInvoker.n_OnNextEvent_Ljava_lang_Object_));
			}
			return IEventListenerInvoker.cb_onNextEvent_Ljava_lang_Object_;
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x00018AA8 File Offset: 0x00016CA8
		private static void n_OnNextEvent_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IEventListener @object = Java.Lang.Object.GetObject<IEventListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnNextEvent(object2);
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x00018ACC File Offset: 0x00016CCC
		public unsafe void OnNextEvent(Java.Lang.Object p0)
		{
			if (this.id_onNextEvent_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_onNextEvent_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "onNextEvent", "(Ljava/lang/Object;)V");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onNextEvent_Ljava_lang_Object_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x040001FC RID: 508
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/misc/IEventListener", typeof(IEventListenerInvoker));

		// Token: 0x040001FD RID: 509
		private IntPtr class_ref;

		// Token: 0x040001FE RID: 510
		private static Delegate cb_onNextEvent_Ljava_lang_Object_;

		// Token: 0x040001FF RID: 511
		private IntPtr id_onNextEvent_Ljava_lang_Object_;
	}
}
