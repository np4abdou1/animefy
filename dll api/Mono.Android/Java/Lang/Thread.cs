using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Java.Lang
{
	// Token: 0x020003F3 RID: 1011
	[Register("java/lang/Thread", DoNotGenerateAcw = true)]
	public class Thread : Object, IRunnable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170008CB RID: 2251
		// (get) Token: 0x06002C77 RID: 11383 RVA: 0x0007AA9A File Offset: 0x00078C9A
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Thread._members;
			}
		}

		// Token: 0x170008CC RID: 2252
		// (get) Token: 0x06002C78 RID: 11384 RVA: 0x0007AAA4 File Offset: 0x00078CA4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Thread._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170008CD RID: 2253
		// (get) Token: 0x06002C79 RID: 11385 RVA: 0x0007AAC8 File Offset: 0x00078CC8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Thread._members.ManagedPeerType;
			}
		}

		// Token: 0x06002C7A RID: 11386 RVA: 0x000021E0 File Offset: 0x000003E0
		protected Thread(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06002C7B RID: 11387 RVA: 0x0007AAD4 File Offset: 0x00078CD4
		private static Delegate GetRunHandler()
		{
			if (Thread.cb_run == null)
			{
				Thread.cb_run = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(Thread.n_Run));
			}
			return Thread.cb_run;
		}

		// Token: 0x06002C7C RID: 11388 RVA: 0x0007AAF8 File Offset: 0x00078CF8
		private static void n_Run(IntPtr jnienv, IntPtr native__this)
		{
			Object.GetObject<Thread>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Run();
		}

		// Token: 0x06002C7D RID: 11389 RVA: 0x0007AB07 File Offset: 0x00078D07
		public virtual void Run()
		{
			Thread._members.InstanceMethods.InvokeVirtualVoidMethod("run.()V", this, null);
		}

		// Token: 0x04001199 RID: 4505
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/lang/Thread", typeof(Thread));

		// Token: 0x0400119A RID: 4506
		private static Delegate cb_run;

		// Token: 0x020003F4 RID: 1012
		[Register("java/lang/Thread$UncaughtExceptionHandler", "", "Java.Lang.Thread/IUncaughtExceptionHandlerInvoker")]
		public interface IUncaughtExceptionHandler : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06002C7F RID: 11391
			[Register("uncaughtException", "(Ljava/lang/Thread;Ljava/lang/Throwable;)V", "GetUncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_Handler:Java.Lang.Thread/IUncaughtExceptionHandlerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			void UncaughtException(Thread t, Throwable e);
		}

		// Token: 0x020003F5 RID: 1013
		[Register("java/lang/Thread$UncaughtExceptionHandler", DoNotGenerateAcw = true)]
		internal class IUncaughtExceptionHandlerInvoker : Object, Thread.IUncaughtExceptionHandler, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x170008CE RID: 2254
			// (get) Token: 0x06002C80 RID: 11392 RVA: 0x0007AB3C File Offset: 0x00078D3C
			private static IntPtr java_class_ref
			{
				get
				{
					return Thread.IUncaughtExceptionHandlerInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170008CF RID: 2255
			// (get) Token: 0x06002C81 RID: 11393 RVA: 0x0007AB60 File Offset: 0x00078D60
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return Thread.IUncaughtExceptionHandlerInvoker._members;
				}
			}

			// Token: 0x170008D0 RID: 2256
			// (get) Token: 0x06002C82 RID: 11394 RVA: 0x0007AB67 File Offset: 0x00078D67
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x170008D1 RID: 2257
			// (get) Token: 0x06002C83 RID: 11395 RVA: 0x0007AB6F File Offset: 0x00078D6F
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return Thread.IUncaughtExceptionHandlerInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06002C84 RID: 11396 RVA: 0x0007AB7B File Offset: 0x00078D7B
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, Thread.IUncaughtExceptionHandlerInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.lang.Thread.UncaughtExceptionHandler'.");
				}
				return handle;
			}

			// Token: 0x06002C85 RID: 11397 RVA: 0x0007ABA6 File Offset: 0x00078DA6
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06002C86 RID: 11398 RVA: 0x0007ABD8 File Offset: 0x00078DD8
			public IUncaughtExceptionHandlerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(Thread.IUncaughtExceptionHandlerInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x06002C87 RID: 11399 RVA: 0x0007AC10 File Offset: 0x00078E10
			private static Delegate GetUncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_Handler()
			{
				if (Thread.IUncaughtExceptionHandlerInvoker.cb_uncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_ == null)
				{
					Thread.IUncaughtExceptionHandlerInvoker.cb_uncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(Thread.IUncaughtExceptionHandlerInvoker.n_UncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_));
				}
				return Thread.IUncaughtExceptionHandlerInvoker.cb_uncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_;
			}

			// Token: 0x06002C88 RID: 11400 RVA: 0x0007AC34 File Offset: 0x00078E34
			private static void n_UncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_(IntPtr jnienv, IntPtr native__this, IntPtr native_t, IntPtr native_e)
			{
				Thread.IUncaughtExceptionHandler @object = Object.GetObject<Thread.IUncaughtExceptionHandler>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Thread object2 = Object.GetObject<Thread>(native_t, JniHandleOwnership.DoNotTransfer);
				Throwable object3 = Object.GetObject<Throwable>(native_e, JniHandleOwnership.DoNotTransfer);
				@object.UncaughtException(object2, object3);
			}

			// Token: 0x06002C89 RID: 11401 RVA: 0x0007AC60 File Offset: 0x00078E60
			public unsafe void UncaughtException(Thread t, Throwable e)
			{
				if (this.id_uncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_ == IntPtr.Zero)
				{
					this.id_uncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_ = JNIEnv.GetMethodID(this.class_ref, "uncaughtException", "(Ljava/lang/Thread;Ljava/lang/Throwable;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((t == null) ? IntPtr.Zero : t.Handle);
				ptr[1] = new JValue((e == null) ? IntPtr.Zero : e.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_uncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_, ptr);
			}

			// Token: 0x0400119B RID: 4507
			private static readonly JniPeerMembers _members = new XAPeerMembers("java/lang/Thread$UncaughtExceptionHandler", typeof(Thread.IUncaughtExceptionHandlerInvoker));

			// Token: 0x0400119C RID: 4508
			private IntPtr class_ref;

			// Token: 0x0400119D RID: 4509
			private static Delegate cb_uncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_;

			// Token: 0x0400119E RID: 4510
			private IntPtr id_uncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_;
		}

		// Token: 0x020003F6 RID: 1014
		[Register("mono/java/lang/RunnableImplementor")]
		internal sealed class RunnableImplementor : Object, IRunnable, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06002C8B RID: 11403 RVA: 0x0007AD10 File Offset: 0x00078F10
			public RunnableImplementor(Action handler) : this(handler, false)
			{
			}

			// Token: 0x06002C8C RID: 11404 RVA: 0x0007AD1C File Offset: 0x00078F1C
			public RunnableImplementor(Action handler, bool removable) : base(JNIEnv.StartCreateInstance("mono/java/lang/RunnableImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
			{
				JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
				this.Handler = handler;
				this.removable = removable;
				if (removable)
				{
					Dictionary<Action, Thread.RunnableImplementor> obj = Thread.RunnableImplementor.instances;
					lock (obj)
					{
						Thread.RunnableImplementor.instances[handler] = this;
					}
				}
			}

			// Token: 0x06002C8D RID: 11405 RVA: 0x0007ADA4 File Offset: 0x00078FA4
			public void Run()
			{
				if (this.Handler != null)
				{
					this.Handler();
				}
				if (this.removable)
				{
					Dictionary<Action, Thread.RunnableImplementor> obj = Thread.RunnableImplementor.instances;
					lock (obj)
					{
						if (this.Handler != null)
						{
							Thread.RunnableImplementor.instances.Remove(this.Handler);
						}
					}
				}
				base.Dispose();
			}

			// Token: 0x0400119F RID: 4511
			public Action Handler;

			// Token: 0x040011A0 RID: 4512
			private bool removable;

			// Token: 0x040011A1 RID: 4513
			private static Dictionary<Action, Thread.RunnableImplementor> instances = new Dictionary<Action, Thread.RunnableImplementor>();
		}
	}
}
