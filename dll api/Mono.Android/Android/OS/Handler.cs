using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.OS
{
	// Token: 0x020001E1 RID: 481
	[Register("android/os/Handler", DoNotGenerateAcw = true)]
	public class Handler : Java.Lang.Object
	{
		// Token: 0x17000380 RID: 896
		// (get) Token: 0x0600118D RID: 4493 RVA: 0x0002E793 File Offset: 0x0002C993
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Handler._members;
			}
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x0600118E RID: 4494 RVA: 0x0002E79C File Offset: 0x0002C99C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Handler._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x0600118F RID: 4495 RVA: 0x0002E7C0 File Offset: 0x0002C9C0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Handler._members.ManagedPeerType;
			}
		}

		// Token: 0x06001190 RID: 4496 RVA: 0x000021E0 File Offset: 0x000003E0
		protected Handler(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001191 RID: 4497 RVA: 0x0002E7CC File Offset: 0x0002C9CC
		public unsafe Handler(Looper looper) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((looper == null) ? IntPtr.Zero : looper.Handle);
				base.SetHandle(Handler._members.InstanceMethods.StartCreateInstance("(Landroid/os/Looper;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				Handler._members.InstanceMethods.FinishCreateInstance("(Landroid/os/Looper;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(looper);
			}
		}

		// Token: 0x06001192 RID: 4498 RVA: 0x0002E87C File Offset: 0x0002CA7C
		public unsafe bool Post(IRunnable r)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((r == null) ? IntPtr.Zero : ((Java.Lang.Object)r).Handle);
				result = Handler._members.InstanceMethods.InvokeNonvirtualBooleanMethod("post.(Ljava/lang/Runnable;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(r);
			}
			return result;
		}

		// Token: 0x06001193 RID: 4499 RVA: 0x0002E8E8 File Offset: 0x0002CAE8
		public unsafe bool PostDelayed(IRunnable r, long delayMillis)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((r == null) ? IntPtr.Zero : ((Java.Lang.Object)r).Handle);
				ptr[1] = new JniArgumentValue(delayMillis);
				result = Handler._members.InstanceMethods.InvokeNonvirtualBooleanMethod("postDelayed.(Ljava/lang/Runnable;J)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(r);
			}
			return result;
		}

		// Token: 0x06001194 RID: 4500 RVA: 0x0002E968 File Offset: 0x0002CB68
		public unsafe void RemoveCallbacks(IRunnable r)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((r == null) ? IntPtr.Zero : ((Java.Lang.Object)r).Handle);
				Handler._members.InstanceMethods.InvokeNonvirtualVoidMethod("removeCallbacks.(Ljava/lang/Runnable;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(r);
			}
		}

		// Token: 0x06001195 RID: 4501 RVA: 0x0002E9D0 File Offset: 0x0002CBD0
		public bool Post(Action action)
		{
			return this.Post(new Thread.RunnableImplementor(action, true));
		}

		// Token: 0x040007D9 RID: 2009
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/os/Handler", typeof(Handler));

		// Token: 0x020001E2 RID: 482
		[Register("android/os/Handler$Callback", "", "Android.OS.Handler/ICallbackInvoker")]
		public interface ICallback : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06001197 RID: 4503
			[Register("handleMessage", "(Landroid/os/Message;)Z", "GetHandleMessage_Landroid_os_Message_Handler:Android.OS.Handler/ICallbackInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			bool HandleMessage(Message msg);
		}

		// Token: 0x020001E3 RID: 483
		[Register("android/os/Handler$Callback", DoNotGenerateAcw = true)]
		internal class ICallbackInvoker : Java.Lang.Object, Handler.ICallback, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000383 RID: 899
			// (get) Token: 0x06001198 RID: 4504 RVA: 0x0002E9FC File Offset: 0x0002CBFC
			private static IntPtr java_class_ref
			{
				get
				{
					return Handler.ICallbackInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000384 RID: 900
			// (get) Token: 0x06001199 RID: 4505 RVA: 0x0002EA20 File Offset: 0x0002CC20
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return Handler.ICallbackInvoker._members;
				}
			}

			// Token: 0x17000385 RID: 901
			// (get) Token: 0x0600119A RID: 4506 RVA: 0x0002EA27 File Offset: 0x0002CC27
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x17000386 RID: 902
			// (get) Token: 0x0600119B RID: 4507 RVA: 0x0002EA2F File Offset: 0x0002CC2F
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return Handler.ICallbackInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x0600119C RID: 4508 RVA: 0x0002EA3B File Offset: 0x0002CC3B
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, Handler.ICallbackInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.os.Handler.Callback'.");
				}
				return handle;
			}

			// Token: 0x0600119D RID: 4509 RVA: 0x0002EA66 File Offset: 0x0002CC66
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x0600119E RID: 4510 RVA: 0x0002EA98 File Offset: 0x0002CC98
			public ICallbackInvoker(IntPtr handle, JniHandleOwnership transfer) : base(Handler.ICallbackInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x0600119F RID: 4511 RVA: 0x0002EAD0 File Offset: 0x0002CCD0
			private static Delegate GetHandleMessage_Landroid_os_Message_Handler()
			{
				if (Handler.ICallbackInvoker.cb_handleMessage_Landroid_os_Message_ == null)
				{
					Handler.ICallbackInvoker.cb_handleMessage_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(Handler.ICallbackInvoker.n_HandleMessage_Landroid_os_Message_));
				}
				return Handler.ICallbackInvoker.cb_handleMessage_Landroid_os_Message_;
			}

			// Token: 0x060011A0 RID: 4512 RVA: 0x0002EAF4 File Offset: 0x0002CCF4
			private static bool n_HandleMessage_Landroid_os_Message_(IntPtr jnienv, IntPtr native__this, IntPtr native_msg)
			{
				Handler.ICallback @object = Java.Lang.Object.GetObject<Handler.ICallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Message object2 = Java.Lang.Object.GetObject<Message>(native_msg, JniHandleOwnership.DoNotTransfer);
				return @object.HandleMessage(object2);
			}

			// Token: 0x060011A1 RID: 4513 RVA: 0x0002EB18 File Offset: 0x0002CD18
			public unsafe bool HandleMessage(Message msg)
			{
				if (this.id_handleMessage_Landroid_os_Message_ == IntPtr.Zero)
				{
					this.id_handleMessage_Landroid_os_Message_ = JNIEnv.GetMethodID(this.class_ref, "handleMessage", "(Landroid/os/Message;)Z");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((msg == null) ? IntPtr.Zero : msg.Handle);
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_handleMessage_Landroid_os_Message_, ptr);
			}

			// Token: 0x040007DA RID: 2010
			private static readonly JniPeerMembers _members = new XAPeerMembers("android/os/Handler$Callback", typeof(Handler.ICallbackInvoker));

			// Token: 0x040007DB RID: 2011
			private IntPtr class_ref;

			// Token: 0x040007DC RID: 2012
			private static Delegate cb_handleMessage_Landroid_os_Message_;

			// Token: 0x040007DD RID: 2013
			private IntPtr id_handleMessage_Landroid_os_Message_;
		}
	}
}
