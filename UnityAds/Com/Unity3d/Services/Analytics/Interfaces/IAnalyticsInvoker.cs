using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Analytics.Interfaces
{
	// Token: 0x020001C8 RID: 456
	[Register("com/unity3d/services/analytics/interfaces/IAnalytics", DoNotGenerateAcw = true)]
	internal class IAnalyticsInvoker : Java.Lang.Object, IAnalytics, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x06001453 RID: 5203 RVA: 0x0003A118 File Offset: 0x00038318
		private static IntPtr java_class_ref
		{
			get
			{
				return IAnalyticsInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x06001454 RID: 5204 RVA: 0x0003A13C File Offset: 0x0003833C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IAnalyticsInvoker._members;
			}
		}

		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x06001455 RID: 5205 RVA: 0x0003A143 File Offset: 0x00038343
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x06001456 RID: 5206 RVA: 0x0003A14B File Offset: 0x0003834B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IAnalyticsInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001457 RID: 5207 RVA: 0x0003A157 File Offset: 0x00038357
		public static IAnalytics GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IAnalytics>(handle, transfer);
		}

		// Token: 0x06001458 RID: 5208 RVA: 0x0003A160 File Offset: 0x00038360
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IAnalyticsInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.services.analytics.interfaces.IAnalytics'.");
			}
			return handle;
		}

		// Token: 0x06001459 RID: 5209 RVA: 0x0003A18B File Offset: 0x0003838B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600145A RID: 5210 RVA: 0x0003A1BC File Offset: 0x000383BC
		public IAnalyticsInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IAnalyticsInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600145B RID: 5211 RVA: 0x0003A1F4 File Offset: 0x000383F4
		private static Delegate GetOnAddExtras_Ljava_lang_String_Handler()
		{
			if (IAnalyticsInvoker.cb_onAddExtras_Ljava_lang_String_ == null)
			{
				IAnalyticsInvoker.cb_onAddExtras_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IAnalyticsInvoker.n_OnAddExtras_Ljava_lang_String_));
			}
			return IAnalyticsInvoker.cb_onAddExtras_Ljava_lang_String_;
		}

		// Token: 0x0600145C RID: 5212 RVA: 0x0003A218 File Offset: 0x00038418
		private static void n_OnAddExtras_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IAnalytics @object = Java.Lang.Object.GetObject<IAnalytics>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnAddExtras(@string);
		}

		// Token: 0x0600145D RID: 5213 RVA: 0x0003A23C File Offset: 0x0003843C
		public unsafe void OnAddExtras(string p0)
		{
			if (this.id_onAddExtras_Ljava_lang_String_ == IntPtr.Zero)
			{
				this.id_onAddExtras_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "onAddExtras", "(Ljava/lang/String;)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onAddExtras_Ljava_lang_String_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x040004D7 RID: 1239
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/analytics/interfaces/IAnalytics", typeof(IAnalyticsInvoker));

		// Token: 0x040004D8 RID: 1240
		private IntPtr class_ref;

		// Token: 0x040004D9 RID: 1241
		private static Delegate cb_onAddExtras_Ljava_lang_String_;

		// Token: 0x040004DA RID: 1242
		private IntPtr id_onAddExtras_Ljava_lang_String_;
	}
}
