using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.UserMesssagingPlatform
{
	// Token: 0x0200002E RID: 46
	[Register("com/google/android/ump/UserMessagingPlatform", DoNotGenerateAcw = true)]
	public sealed class UserMessagingPlatform : Java.Lang.Object
	{
		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000111 RID: 273 RVA: 0x00003FF8 File Offset: 0x000021F8
		internal static IntPtr class_ref
		{
			get
			{
				return UserMessagingPlatform._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000112 RID: 274 RVA: 0x0000401C File Offset: 0x0000221C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return UserMessagingPlatform._members;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000113 RID: 275 RVA: 0x00004024 File Offset: 0x00002224
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return UserMessagingPlatform._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000114 RID: 276 RVA: 0x00004048 File Offset: 0x00002248
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return UserMessagingPlatform._members.ManagedPeerType;
			}
		}

		// Token: 0x06000115 RID: 277 RVA: 0x000020B4 File Offset: 0x000002B4
		internal UserMessagingPlatform(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00004054 File Offset: 0x00002254
		[Register("getConsentInformation", "(Landroid/content/Context;)Lcom/google/android/ump/ConsentInformation;", "")]
		public unsafe static IConsentInformation GetConsentInformation(Context context)
		{
			IConsentInformation @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				@object = Java.Lang.Object.GetObject<IConsentInformation>(UserMessagingPlatform._members.StaticMethods.InvokeObjectMethod("getConsentInformation.(Landroid/content/Context;)Lcom/google/android/ump/ConsentInformation;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
			}
			return @object;
		}

		// Token: 0x06000117 RID: 279 RVA: 0x000040C8 File Offset: 0x000022C8
		[Register("loadConsentForm", "(Landroid/content/Context;Lcom/google/android/ump/UserMessagingPlatform$OnConsentFormLoadSuccessListener;Lcom/google/android/ump/UserMessagingPlatform$OnConsentFormLoadFailureListener;)V", "")]
		public unsafe static void LoadConsentForm(Context context, UserMessagingPlatform.IOnConsentFormLoadSuccessListener successListener, UserMessagingPlatform.IOnConsentFormLoadFailureListener failureListener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((successListener == null) ? IntPtr.Zero : ((Java.Lang.Object)successListener).Handle);
				ptr[2] = new JniArgumentValue((failureListener == null) ? IntPtr.Zero : ((Java.Lang.Object)failureListener).Handle);
				UserMessagingPlatform._members.StaticMethods.InvokeVoidMethod("loadConsentForm.(Landroid/content/Context;Lcom/google/android/ump/UserMessagingPlatform$OnConsentFormLoadSuccessListener;Lcom/google/android/ump/UserMessagingPlatform$OnConsentFormLoadFailureListener;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(successListener);
				GC.KeepAlive(failureListener);
			}
		}

		// Token: 0x0400005B RID: 91
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/ump/UserMessagingPlatform", typeof(UserMessagingPlatform));

		// Token: 0x0200002F RID: 47
		[Register("com/google/android/ump/UserMessagingPlatform$OnConsentFormLoadFailureListener", "", "Xamarin.Google.UserMesssagingPlatform.UserMessagingPlatform/IOnConsentFormLoadFailureListenerInvoker")]
		public interface IOnConsentFormLoadFailureListener : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06000119 RID: 281
			[Register("onConsentFormLoadFailure", "(Lcom/google/android/ump/FormError;)V", "GetOnConsentFormLoadFailure_Lcom_google_android_ump_FormError_Handler:Xamarin.Google.UserMesssagingPlatform.UserMessagingPlatform/IOnConsentFormLoadFailureListenerInvoker, Xamarin.Google.UserMessagingPlatform")]
			void OnConsentFormLoadFailure(FormError p0);
		}

		// Token: 0x02000030 RID: 48
		[Register("com/google/android/ump/UserMessagingPlatform$OnConsentFormLoadFailureListener", DoNotGenerateAcw = true)]
		internal class IOnConsentFormLoadFailureListenerInvoker : Java.Lang.Object, UserMessagingPlatform.IOnConsentFormLoadFailureListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000043 RID: 67
			// (get) Token: 0x0600011A RID: 282 RVA: 0x000041A4 File Offset: 0x000023A4
			private static IntPtr java_class_ref
			{
				get
				{
					return UserMessagingPlatform.IOnConsentFormLoadFailureListenerInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000044 RID: 68
			// (get) Token: 0x0600011B RID: 283 RVA: 0x000041C8 File Offset: 0x000023C8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return UserMessagingPlatform.IOnConsentFormLoadFailureListenerInvoker._members;
				}
			}

			// Token: 0x17000045 RID: 69
			// (get) Token: 0x0600011C RID: 284 RVA: 0x000041CF File Offset: 0x000023CF
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x17000046 RID: 70
			// (get) Token: 0x0600011D RID: 285 RVA: 0x000041D7 File Offset: 0x000023D7
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return UserMessagingPlatform.IOnConsentFormLoadFailureListenerInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x0600011E RID: 286 RVA: 0x000041E3 File Offset: 0x000023E3
			public static UserMessagingPlatform.IOnConsentFormLoadFailureListener GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<UserMessagingPlatform.IOnConsentFormLoadFailureListener>(handle, transfer);
			}

			// Token: 0x0600011F RID: 287 RVA: 0x000041EC File Offset: 0x000023EC
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, UserMessagingPlatform.IOnConsentFormLoadFailureListenerInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.ump.UserMessagingPlatform.OnConsentFormLoadFailureListener'.");
				}
				return handle;
			}

			// Token: 0x06000120 RID: 288 RVA: 0x00004217 File Offset: 0x00002417
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06000121 RID: 289 RVA: 0x00004248 File Offset: 0x00002448
			public IOnConsentFormLoadFailureListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(UserMessagingPlatform.IOnConsentFormLoadFailureListenerInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x06000122 RID: 290 RVA: 0x00004280 File Offset: 0x00002480
			private static Delegate GetOnConsentFormLoadFailure_Lcom_google_android_ump_FormError_Handler()
			{
				if (UserMessagingPlatform.IOnConsentFormLoadFailureListenerInvoker.cb_onConsentFormLoadFailure_Lcom_google_android_ump_FormError_ == null)
				{
					UserMessagingPlatform.IOnConsentFormLoadFailureListenerInvoker.cb_onConsentFormLoadFailure_Lcom_google_android_ump_FormError_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(UserMessagingPlatform.IOnConsentFormLoadFailureListenerInvoker.n_OnConsentFormLoadFailure_Lcom_google_android_ump_FormError_));
				}
				return UserMessagingPlatform.IOnConsentFormLoadFailureListenerInvoker.cb_onConsentFormLoadFailure_Lcom_google_android_ump_FormError_;
			}

			// Token: 0x06000123 RID: 291 RVA: 0x000042A4 File Offset: 0x000024A4
			private static void n_OnConsentFormLoadFailure_Lcom_google_android_ump_FormError_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				UserMessagingPlatform.IOnConsentFormLoadFailureListener @object = Java.Lang.Object.GetObject<UserMessagingPlatform.IOnConsentFormLoadFailureListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				FormError object2 = Java.Lang.Object.GetObject<FormError>(native_p0, JniHandleOwnership.DoNotTransfer);
				@object.OnConsentFormLoadFailure(object2);
			}

			// Token: 0x06000124 RID: 292 RVA: 0x000042C8 File Offset: 0x000024C8
			public unsafe void OnConsentFormLoadFailure(FormError p0)
			{
				if (this.id_onConsentFormLoadFailure_Lcom_google_android_ump_FormError_ == IntPtr.Zero)
				{
					this.id_onConsentFormLoadFailure_Lcom_google_android_ump_FormError_ = JNIEnv.GetMethodID(this.class_ref, "onConsentFormLoadFailure", "(Lcom/google/android/ump/FormError;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onConsentFormLoadFailure_Lcom_google_android_ump_FormError_, ptr);
			}

			// Token: 0x0400005C RID: 92
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/ump/UserMessagingPlatform$OnConsentFormLoadFailureListener", typeof(UserMessagingPlatform.IOnConsentFormLoadFailureListenerInvoker));

			// Token: 0x0400005D RID: 93
			private IntPtr class_ref;

			// Token: 0x0400005E RID: 94
			private static Delegate cb_onConsentFormLoadFailure_Lcom_google_android_ump_FormError_;

			// Token: 0x0400005F RID: 95
			private IntPtr id_onConsentFormLoadFailure_Lcom_google_android_ump_FormError_;
		}

		// Token: 0x02000031 RID: 49
		public class ConsentFormLoadFailureEventArgs : EventArgs
		{
			// Token: 0x06000126 RID: 294 RVA: 0x00004356 File Offset: 0x00002556
			public ConsentFormLoadFailureEventArgs(FormError p0)
			{
				this.p0 = p0;
			}

			// Token: 0x17000047 RID: 71
			// (get) Token: 0x06000127 RID: 295 RVA: 0x00004365 File Offset: 0x00002565
			public FormError P0
			{
				get
				{
					return this.p0;
				}
			}

			// Token: 0x04000060 RID: 96
			private FormError p0;
		}

		// Token: 0x02000032 RID: 50
		[Register("mono/com/google/android/ump/UserMessagingPlatform_OnConsentFormLoadFailureListenerImplementor")]
		internal sealed class IOnConsentFormLoadFailureListenerImplementor : Java.Lang.Object, UserMessagingPlatform.IOnConsentFormLoadFailureListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06000128 RID: 296 RVA: 0x0000436D File Offset: 0x0000256D
			public IOnConsentFormLoadFailureListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/com/google/android/ump/UserMessagingPlatform_OnConsentFormLoadFailureListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
			{
				JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
				this.sender = sender;
			}

			// Token: 0x06000129 RID: 297 RVA: 0x000043A8 File Offset: 0x000025A8
			public void OnConsentFormLoadFailure(FormError p0)
			{
				EventHandler<UserMessagingPlatform.ConsentFormLoadFailureEventArgs> handler = this.Handler;
				if (handler != null)
				{
					handler(this.sender, new UserMessagingPlatform.ConsentFormLoadFailureEventArgs(p0));
				}
			}

			// Token: 0x0600012A RID: 298 RVA: 0x000043D1 File Offset: 0x000025D1
			internal static bool __IsEmpty(UserMessagingPlatform.IOnConsentFormLoadFailureListenerImplementor value)
			{
				return value.Handler == null;
			}

			// Token: 0x04000061 RID: 97
			private object sender;

			// Token: 0x04000062 RID: 98
			public EventHandler<UserMessagingPlatform.ConsentFormLoadFailureEventArgs> Handler;
		}

		// Token: 0x02000033 RID: 51
		[Register("com/google/android/ump/UserMessagingPlatform$OnConsentFormLoadSuccessListener", "", "Xamarin.Google.UserMesssagingPlatform.UserMessagingPlatform/IOnConsentFormLoadSuccessListenerInvoker")]
		public interface IOnConsentFormLoadSuccessListener : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x0600012B RID: 299
			[Register("onConsentFormLoadSuccess", "(Lcom/google/android/ump/ConsentForm;)V", "GetOnConsentFormLoadSuccess_Lcom_google_android_ump_ConsentForm_Handler:Xamarin.Google.UserMesssagingPlatform.UserMessagingPlatform/IOnConsentFormLoadSuccessListenerInvoker, Xamarin.Google.UserMessagingPlatform")]
			void OnConsentFormLoadSuccess(IConsentForm p0);
		}

		// Token: 0x02000034 RID: 52
		[Register("com/google/android/ump/UserMessagingPlatform$OnConsentFormLoadSuccessListener", DoNotGenerateAcw = true)]
		internal class IOnConsentFormLoadSuccessListenerInvoker : Java.Lang.Object, UserMessagingPlatform.IOnConsentFormLoadSuccessListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000048 RID: 72
			// (get) Token: 0x0600012C RID: 300 RVA: 0x000043DC File Offset: 0x000025DC
			private static IntPtr java_class_ref
			{
				get
				{
					return UserMessagingPlatform.IOnConsentFormLoadSuccessListenerInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000049 RID: 73
			// (get) Token: 0x0600012D RID: 301 RVA: 0x00004400 File Offset: 0x00002600
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return UserMessagingPlatform.IOnConsentFormLoadSuccessListenerInvoker._members;
				}
			}

			// Token: 0x1700004A RID: 74
			// (get) Token: 0x0600012E RID: 302 RVA: 0x00004407 File Offset: 0x00002607
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x1700004B RID: 75
			// (get) Token: 0x0600012F RID: 303 RVA: 0x0000440F File Offset: 0x0000260F
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return UserMessagingPlatform.IOnConsentFormLoadSuccessListenerInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06000130 RID: 304 RVA: 0x0000441B File Offset: 0x0000261B
			public static UserMessagingPlatform.IOnConsentFormLoadSuccessListener GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<UserMessagingPlatform.IOnConsentFormLoadSuccessListener>(handle, transfer);
			}

			// Token: 0x06000131 RID: 305 RVA: 0x00004424 File Offset: 0x00002624
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, UserMessagingPlatform.IOnConsentFormLoadSuccessListenerInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.ump.UserMessagingPlatform.OnConsentFormLoadSuccessListener'.");
				}
				return handle;
			}

			// Token: 0x06000132 RID: 306 RVA: 0x0000444F File Offset: 0x0000264F
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06000133 RID: 307 RVA: 0x00004480 File Offset: 0x00002680
			public IOnConsentFormLoadSuccessListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(UserMessagingPlatform.IOnConsentFormLoadSuccessListenerInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x06000134 RID: 308 RVA: 0x000044B8 File Offset: 0x000026B8
			private static Delegate GetOnConsentFormLoadSuccess_Lcom_google_android_ump_ConsentForm_Handler()
			{
				if (UserMessagingPlatform.IOnConsentFormLoadSuccessListenerInvoker.cb_onConsentFormLoadSuccess_Lcom_google_android_ump_ConsentForm_ == null)
				{
					UserMessagingPlatform.IOnConsentFormLoadSuccessListenerInvoker.cb_onConsentFormLoadSuccess_Lcom_google_android_ump_ConsentForm_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(UserMessagingPlatform.IOnConsentFormLoadSuccessListenerInvoker.n_OnConsentFormLoadSuccess_Lcom_google_android_ump_ConsentForm_));
				}
				return UserMessagingPlatform.IOnConsentFormLoadSuccessListenerInvoker.cb_onConsentFormLoadSuccess_Lcom_google_android_ump_ConsentForm_;
			}

			// Token: 0x06000135 RID: 309 RVA: 0x000044DC File Offset: 0x000026DC
			private static void n_OnConsentFormLoadSuccess_Lcom_google_android_ump_ConsentForm_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				UserMessagingPlatform.IOnConsentFormLoadSuccessListener @object = Java.Lang.Object.GetObject<UserMessagingPlatform.IOnConsentFormLoadSuccessListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				IConsentForm object2 = Java.Lang.Object.GetObject<IConsentForm>(native_p0, JniHandleOwnership.DoNotTransfer);
				@object.OnConsentFormLoadSuccess(object2);
			}

			// Token: 0x06000136 RID: 310 RVA: 0x00004500 File Offset: 0x00002700
			public unsafe void OnConsentFormLoadSuccess(IConsentForm p0)
			{
				if (this.id_onConsentFormLoadSuccess_Lcom_google_android_ump_ConsentForm_ == IntPtr.Zero)
				{
					this.id_onConsentFormLoadSuccess_Lcom_google_android_ump_ConsentForm_ = JNIEnv.GetMethodID(this.class_ref, "onConsentFormLoadSuccess", "(Lcom/google/android/ump/ConsentForm;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onConsentFormLoadSuccess_Lcom_google_android_ump_ConsentForm_, ptr);
			}

			// Token: 0x04000063 RID: 99
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/ump/UserMessagingPlatform$OnConsentFormLoadSuccessListener", typeof(UserMessagingPlatform.IOnConsentFormLoadSuccessListenerInvoker));

			// Token: 0x04000064 RID: 100
			private IntPtr class_ref;

			// Token: 0x04000065 RID: 101
			private static Delegate cb_onConsentFormLoadSuccess_Lcom_google_android_ump_ConsentForm_;

			// Token: 0x04000066 RID: 102
			private IntPtr id_onConsentFormLoadSuccess_Lcom_google_android_ump_ConsentForm_;
		}

		// Token: 0x02000035 RID: 53
		public class ConsentFormLoadSuccessEventArgs : EventArgs
		{
			// Token: 0x06000138 RID: 312 RVA: 0x00004593 File Offset: 0x00002793
			public ConsentFormLoadSuccessEventArgs(IConsentForm p0)
			{
				this.p0 = p0;
			}

			// Token: 0x1700004C RID: 76
			// (get) Token: 0x06000139 RID: 313 RVA: 0x000045A2 File Offset: 0x000027A2
			public IConsentForm P0
			{
				get
				{
					return this.p0;
				}
			}

			// Token: 0x04000067 RID: 103
			private IConsentForm p0;
		}

		// Token: 0x02000036 RID: 54
		[Register("mono/com/google/android/ump/UserMessagingPlatform_OnConsentFormLoadSuccessListenerImplementor")]
		internal sealed class IOnConsentFormLoadSuccessListenerImplementor : Java.Lang.Object, UserMessagingPlatform.IOnConsentFormLoadSuccessListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x0600013A RID: 314 RVA: 0x000045AA File Offset: 0x000027AA
			public IOnConsentFormLoadSuccessListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/com/google/android/ump/UserMessagingPlatform_OnConsentFormLoadSuccessListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
			{
				JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
				this.sender = sender;
			}

			// Token: 0x0600013B RID: 315 RVA: 0x000045E4 File Offset: 0x000027E4
			public void OnConsentFormLoadSuccess(IConsentForm p0)
			{
				EventHandler<UserMessagingPlatform.ConsentFormLoadSuccessEventArgs> handler = this.Handler;
				if (handler != null)
				{
					handler(this.sender, new UserMessagingPlatform.ConsentFormLoadSuccessEventArgs(p0));
				}
			}

			// Token: 0x0600013C RID: 316 RVA: 0x0000460D File Offset: 0x0000280D
			internal static bool __IsEmpty(UserMessagingPlatform.IOnConsentFormLoadSuccessListenerImplementor value)
			{
				return value.Handler == null;
			}

			// Token: 0x04000068 RID: 104
			private object sender;

			// Token: 0x04000069 RID: 105
			public EventHandler<UserMessagingPlatform.ConsentFormLoadSuccessEventArgs> Handler;
		}
	}
}
