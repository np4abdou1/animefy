using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Sdk
{
	// Token: 0x02000094 RID: 148
	[Register("com/applovin/sdk/AppLovinUserSegment", DoNotGenerateAcw = true)]
	internal class IAppLovinUserSegmentInvoker : Java.Lang.Object, IAppLovinUserSegment, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700018A RID: 394
		// (get) Token: 0x060004FC RID: 1276 RVA: 0x0000D2F4 File Offset: 0x0000B4F4
		private static IntPtr java_class_ref
		{
			get
			{
				return IAppLovinUserSegmentInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x060004FD RID: 1277 RVA: 0x0000D318 File Offset: 0x0000B518
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IAppLovinUserSegmentInvoker._members;
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x060004FE RID: 1278 RVA: 0x0000D31F File Offset: 0x0000B51F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x060004FF RID: 1279 RVA: 0x0000D327 File Offset: 0x0000B527
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IAppLovinUserSegmentInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x0000D333 File Offset: 0x0000B533
		public static IAppLovinUserSegment GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IAppLovinUserSegment>(handle, transfer);
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x0000D33C File Offset: 0x0000B53C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IAppLovinUserSegmentInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.applovin.sdk.AppLovinUserSegment'.");
			}
			return handle;
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x0000D367 File Offset: 0x0000B567
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x0000D398 File Offset: 0x0000B598
		public IAppLovinUserSegmentInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IAppLovinUserSegmentInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x0000D3D0 File Offset: 0x0000B5D0
		private static Delegate GetGetNameHandler()
		{
			if (IAppLovinUserSegmentInvoker.cb_getName == null)
			{
				IAppLovinUserSegmentInvoker.cb_getName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IAppLovinUserSegmentInvoker.n_GetName));
			}
			return IAppLovinUserSegmentInvoker.cb_getName;
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x0000D3F4 File Offset: 0x0000B5F4
		private static IntPtr n_GetName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IAppLovinUserSegment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Name);
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x0000D408 File Offset: 0x0000B608
		private static Delegate GetSetName_Ljava_lang_String_Handler()
		{
			if (IAppLovinUserSegmentInvoker.cb_setName_Ljava_lang_String_ == null)
			{
				IAppLovinUserSegmentInvoker.cb_setName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IAppLovinUserSegmentInvoker.n_SetName_Ljava_lang_String_));
			}
			return IAppLovinUserSegmentInvoker.cb_setName_Ljava_lang_String_;
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x0000D42C File Offset: 0x0000B62C
		private static void n_SetName_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IAppLovinUserSegment @object = Java.Lang.Object.GetObject<IAppLovinUserSegment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.Name = @string;
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06000508 RID: 1288 RVA: 0x0000D450 File Offset: 0x0000B650
		// (set) Token: 0x06000509 RID: 1289 RVA: 0x0000D4A4 File Offset: 0x0000B6A4
		public unsafe string Name
		{
			get
			{
				if (this.id_getName == IntPtr.Zero)
				{
					this.id_getName = JNIEnv.GetMethodID(this.class_ref, "getName", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_getName), JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				if (this.id_setName_Ljava_lang_String_ == IntPtr.Zero)
				{
					this.id_setName_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "setName", "(Ljava/lang/String;)V");
				}
				IntPtr intPtr = JNIEnv.NewString(value);
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue(intPtr);
				JNIEnv.CallVoidMethod(base.Handle, this.id_setName_Ljava_lang_String_, ptr);
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x0400017B RID: 379
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/sdk/AppLovinUserSegment", typeof(IAppLovinUserSegmentInvoker));

		// Token: 0x0400017C RID: 380
		private IntPtr class_ref;

		// Token: 0x0400017D RID: 381
		private static Delegate cb_getName;

		// Token: 0x0400017E RID: 382
		private static Delegate cb_setName_Ljava_lang_String_;

		// Token: 0x0400017F RID: 383
		private IntPtr id_getName;

		// Token: 0x04000180 RID: 384
		private IntPtr id_setName_Ljava_lang_String_;
	}
}
