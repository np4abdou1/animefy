using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Common.Api.Internal
{
	// Token: 0x02000031 RID: 49
	[Register("com/google/android/gms/common/api/internal/ListenerHolder", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"L"
	})]
	public sealed class ListenerHolder : Java.Lang.Object
	{
		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060001AE RID: 430 RVA: 0x00006280 File Offset: 0x00004480
		internal static IntPtr class_ref
		{
			get
			{
				return ListenerHolder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060001AF RID: 431 RVA: 0x000062A4 File Offset: 0x000044A4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ListenerHolder._members;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060001B0 RID: 432 RVA: 0x000062AC File Offset: 0x000044AC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ListenerHolder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060001B1 RID: 433 RVA: 0x000062D0 File Offset: 0x000044D0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ListenerHolder._members.ManagedPeerType;
			}
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00003280 File Offset: 0x00001480
		internal ListenerHolder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x000062DC File Offset: 0x000044DC
		public bool HasListener
		{
			[Register("hasListener", "()Z", "")]
			get
			{
				return ListenerHolder._members.InstanceMethods.InvokeAbstractBooleanMethod("hasListener.()Z", this, null);
			}
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x000062F5 File Offset: 0x000044F5
		[Register("clear", "()V", "")]
		public void Clear()
		{
			ListenerHolder._members.InstanceMethods.InvokeAbstractVoidMethod("clear.()V", this, null);
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00006310 File Offset: 0x00004510
		[Register("getListenerKey", "()Lcom/google/android/gms/common/api/internal/ListenerHolder$ListenerKey;", "")]
		public ListenerHolder.ListenerKey GetListenerKey()
		{
			return Java.Lang.Object.GetObject<ListenerHolder.ListenerKey>(ListenerHolder._members.InstanceMethods.InvokeAbstractObjectMethod("getListenerKey.()Lcom/google/android/gms/common/api/internal/ListenerHolder$ListenerKey;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00006344 File Offset: 0x00004544
		[Register("notifyListener", "(Lcom/google/android/gms/common/api/internal/ListenerHolder$Notifier;)V", "")]
		public unsafe void NotifyListener(ListenerHolder.INotifier notifier)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((notifier == null) ? IntPtr.Zero : ((Java.Lang.Object)notifier).Handle);
				ListenerHolder._members.InstanceMethods.InvokeAbstractVoidMethod("notifyListener.(Lcom/google/android/gms/common/api/internal/ListenerHolder$Notifier;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(notifier);
			}
		}

		// Token: 0x04000058 RID: 88
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/api/internal/ListenerHolder", typeof(ListenerHolder));

		// Token: 0x02000032 RID: 50
		[Register("com/google/android/gms/common/api/internal/ListenerHolder$ListenerKey", DoNotGenerateAcw = true)]
		[JavaTypeParameters(new string[]
		{
			"L"
		})]
		public sealed class ListenerKey : Java.Lang.Object
		{
			// Token: 0x17000072 RID: 114
			// (get) Token: 0x060001B8 RID: 440 RVA: 0x000063C8 File Offset: 0x000045C8
			internal static IntPtr class_ref
			{
				get
				{
					return ListenerHolder.ListenerKey._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000073 RID: 115
			// (get) Token: 0x060001B9 RID: 441 RVA: 0x000063EC File Offset: 0x000045EC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ListenerHolder.ListenerKey._members;
				}
			}

			// Token: 0x17000074 RID: 116
			// (get) Token: 0x060001BA RID: 442 RVA: 0x000063F4 File Offset: 0x000045F4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return ListenerHolder.ListenerKey._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000075 RID: 117
			// (get) Token: 0x060001BB RID: 443 RVA: 0x00006418 File Offset: 0x00004618
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ListenerHolder.ListenerKey._members.ManagedPeerType;
				}
			}

			// Token: 0x060001BC RID: 444 RVA: 0x00003280 File Offset: 0x00001480
			internal ListenerKey(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x060001BD RID: 445 RVA: 0x00006424 File Offset: 0x00004624
			[Register("toIdString", "()Ljava/lang/String;", "")]
			public string ToIdString()
			{
				return JNIEnv.GetString(ListenerHolder.ListenerKey._members.InstanceMethods.InvokeAbstractObjectMethod("toIdString.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x04000059 RID: 89
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/api/internal/ListenerHolder$ListenerKey", typeof(ListenerHolder.ListenerKey));
		}

		// Token: 0x02000033 RID: 51
		[Register("com/google/android/gms/common/api/internal/ListenerHolder$Notifier", "", "Android.Gms.Common.Api.Internal.ListenerHolder/INotifierInvoker")]
		[JavaTypeParameters(new string[]
		{
			"L"
		})]
		public interface INotifier : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x060001BF RID: 447
			[Register("notifyListener", "(Ljava/lang/Object;)V", "GetNotifyListener_Ljava_lang_Object_Handler:Android.Gms.Common.Api.Internal.ListenerHolder/INotifierInvoker, Xamarin.GooglePlayServices.Base")]
			void NotifyListener(Java.Lang.Object p0);

			// Token: 0x060001C0 RID: 448
			[Register("onNotifyListenerFailed", "()V", "GetOnNotifyListenerFailedHandler:Android.Gms.Common.Api.Internal.ListenerHolder/INotifierInvoker, Xamarin.GooglePlayServices.Base")]
			void OnNotifyListenerFailed();
		}

		// Token: 0x02000034 RID: 52
		[Register("com/google/android/gms/common/api/internal/ListenerHolder$Notifier", DoNotGenerateAcw = true)]
		internal class INotifierInvoker : Java.Lang.Object, ListenerHolder.INotifier, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000076 RID: 118
			// (get) Token: 0x060001C1 RID: 449 RVA: 0x00006474 File Offset: 0x00004674
			private static IntPtr java_class_ref
			{
				get
				{
					return ListenerHolder.INotifierInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000077 RID: 119
			// (get) Token: 0x060001C2 RID: 450 RVA: 0x00006498 File Offset: 0x00004698
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ListenerHolder.INotifierInvoker._members;
				}
			}

			// Token: 0x17000078 RID: 120
			// (get) Token: 0x060001C3 RID: 451 RVA: 0x0000649F File Offset: 0x0000469F
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x17000079 RID: 121
			// (get) Token: 0x060001C4 RID: 452 RVA: 0x000064A7 File Offset: 0x000046A7
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ListenerHolder.INotifierInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x060001C5 RID: 453 RVA: 0x000064B3 File Offset: 0x000046B3
			public static ListenerHolder.INotifier GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<ListenerHolder.INotifier>(handle, transfer);
			}

			// Token: 0x060001C6 RID: 454 RVA: 0x000064BC File Offset: 0x000046BC
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, ListenerHolder.INotifierInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.gms.common.api.internal.ListenerHolder.Notifier'.");
				}
				return handle;
			}

			// Token: 0x060001C7 RID: 455 RVA: 0x000064E7 File Offset: 0x000046E7
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x060001C8 RID: 456 RVA: 0x00006518 File Offset: 0x00004718
			public INotifierInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ListenerHolder.INotifierInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x060001C9 RID: 457 RVA: 0x00006550 File Offset: 0x00004750
			private static Delegate GetNotifyListener_Ljava_lang_Object_Handler()
			{
				if (ListenerHolder.INotifierInvoker.cb_notifyListener_Ljava_lang_Object_ == null)
				{
					ListenerHolder.INotifierInvoker.cb_notifyListener_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ListenerHolder.INotifierInvoker.n_NotifyListener_Ljava_lang_Object_));
				}
				return ListenerHolder.INotifierInvoker.cb_notifyListener_Ljava_lang_Object_;
			}

			// Token: 0x060001CA RID: 458 RVA: 0x00006574 File Offset: 0x00004774
			private static void n_NotifyListener_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				ListenerHolder.INotifier @object = Java.Lang.Object.GetObject<ListenerHolder.INotifier>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
				@object.NotifyListener(object2);
			}

			// Token: 0x060001CB RID: 459 RVA: 0x00006598 File Offset: 0x00004798
			public unsafe void NotifyListener(Java.Lang.Object p0)
			{
				if (this.id_notifyListener_Ljava_lang_Object_ == IntPtr.Zero)
				{
					this.id_notifyListener_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "notifyListener", "(Ljava/lang/Object;)V");
				}
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(p0);
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue(intPtr);
				JNIEnv.CallVoidMethod(base.Handle, this.id_notifyListener_Ljava_lang_Object_, ptr);
				JNIEnv.DeleteLocalRef(intPtr);
			}

			// Token: 0x060001CC RID: 460 RVA: 0x00006609 File Offset: 0x00004809
			private static Delegate GetOnNotifyListenerFailedHandler()
			{
				if (ListenerHolder.INotifierInvoker.cb_onNotifyListenerFailed == null)
				{
					ListenerHolder.INotifierInvoker.cb_onNotifyListenerFailed = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ListenerHolder.INotifierInvoker.n_OnNotifyListenerFailed));
				}
				return ListenerHolder.INotifierInvoker.cb_onNotifyListenerFailed;
			}

			// Token: 0x060001CD RID: 461 RVA: 0x0000662D File Offset: 0x0000482D
			private static void n_OnNotifyListenerFailed(IntPtr jnienv, IntPtr native__this)
			{
				Java.Lang.Object.GetObject<ListenerHolder.INotifier>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnNotifyListenerFailed();
			}

			// Token: 0x060001CE RID: 462 RVA: 0x0000663C File Offset: 0x0000483C
			public void OnNotifyListenerFailed()
			{
				if (this.id_onNotifyListenerFailed == IntPtr.Zero)
				{
					this.id_onNotifyListenerFailed = JNIEnv.GetMethodID(this.class_ref, "onNotifyListenerFailed", "()V");
				}
				JNIEnv.CallVoidMethod(base.Handle, this.id_onNotifyListenerFailed);
			}

			// Token: 0x0400005A RID: 90
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/api/internal/ListenerHolder$Notifier", typeof(ListenerHolder.INotifierInvoker));

			// Token: 0x0400005B RID: 91
			private IntPtr class_ref;

			// Token: 0x0400005C RID: 92
			private static Delegate cb_notifyListener_Ljava_lang_Object_;

			// Token: 0x0400005D RID: 93
			private IntPtr id_notifyListener_Ljava_lang_Object_;

			// Token: 0x0400005E RID: 94
			private static Delegate cb_onNotifyListenerFailed;

			// Token: 0x0400005F RID: 95
			private IntPtr id_onNotifyListenerFailed;
		}
	}
}
