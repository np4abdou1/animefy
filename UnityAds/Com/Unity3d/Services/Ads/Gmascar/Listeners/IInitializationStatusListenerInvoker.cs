using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Ads.Gmascar.Listeners
{
	// Token: 0x02000203 RID: 515
	[Register("com/unity3d/services/ads/gmascar/listeners/IInitializationStatusListener", DoNotGenerateAcw = true)]
	internal class IInitializationStatusListenerInvoker : Java.Lang.Object, IInitializationStatusListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700083D RID: 2109
		// (get) Token: 0x06001803 RID: 6147 RVA: 0x000457F4 File Offset: 0x000439F4
		private static IntPtr java_class_ref
		{
			get
			{
				return IInitializationStatusListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700083E RID: 2110
		// (get) Token: 0x06001804 RID: 6148 RVA: 0x00045818 File Offset: 0x00043A18
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IInitializationStatusListenerInvoker._members;
			}
		}

		// Token: 0x1700083F RID: 2111
		// (get) Token: 0x06001805 RID: 6149 RVA: 0x0004581F File Offset: 0x00043A1F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000840 RID: 2112
		// (get) Token: 0x06001806 RID: 6150 RVA: 0x00045827 File Offset: 0x00043A27
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IInitializationStatusListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001807 RID: 6151 RVA: 0x00045833 File Offset: 0x00043A33
		public static IInitializationStatusListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IInitializationStatusListener>(handle, transfer);
		}

		// Token: 0x06001808 RID: 6152 RVA: 0x0004583C File Offset: 0x00043A3C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IInitializationStatusListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.services.ads.gmascar.listeners.IInitializationStatusListener'.");
			}
			return handle;
		}

		// Token: 0x06001809 RID: 6153 RVA: 0x00045867 File Offset: 0x00043A67
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600180A RID: 6154 RVA: 0x00045898 File Offset: 0x00043A98
		public IInitializationStatusListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IInitializationStatusListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600180B RID: 6155 RVA: 0x000458D0 File Offset: 0x00043AD0
		private static Delegate GetOnInitializationComplete_Ljava_lang_Object_Handler()
		{
			if (IInitializationStatusListenerInvoker.cb_onInitializationComplete_Ljava_lang_Object_ == null)
			{
				IInitializationStatusListenerInvoker.cb_onInitializationComplete_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IInitializationStatusListenerInvoker.n_OnInitializationComplete_Ljava_lang_Object_));
			}
			return IInitializationStatusListenerInvoker.cb_onInitializationComplete_Ljava_lang_Object_;
		}

		// Token: 0x0600180C RID: 6156 RVA: 0x000458F4 File Offset: 0x00043AF4
		private static void n_OnInitializationComplete_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IInitializationStatusListener @object = Java.Lang.Object.GetObject<IInitializationStatusListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnInitializationComplete(object2);
		}

		// Token: 0x0600180D RID: 6157 RVA: 0x00045918 File Offset: 0x00043B18
		public unsafe void OnInitializationComplete(Java.Lang.Object p0)
		{
			if (this.id_onInitializationComplete_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_onInitializationComplete_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "onInitializationComplete", "(Ljava/lang/Object;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onInitializationComplete_Ljava_lang_Object_, ptr);
		}

		// Token: 0x040005D7 RID: 1495
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/gmascar/listeners/IInitializationStatusListener", typeof(IInitializationStatusListenerInvoker));

		// Token: 0x040005D8 RID: 1496
		private IntPtr class_ref;

		// Token: 0x040005D9 RID: 1497
		private static Delegate cb_onInitializationComplete_Ljava_lang_Object_;

		// Token: 0x040005DA RID: 1498
		private IntPtr id_onInitializationComplete_Ljava_lang_Object_;
	}
}
