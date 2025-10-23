using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Coroutines.Jvm.Internal
{
	// Token: 0x02000268 RID: 616
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/coroutines/jvm/internal/CoroutineStackFrame", DoNotGenerateAcw = true)]
	internal class ICoroutineStackFrameInvoker : Java.Lang.Object, ICoroutineStackFrame, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000818 RID: 2072
		// (get) Token: 0x06001C18 RID: 7192 RVA: 0x0005DC38 File Offset: 0x0005BE38
		private static IntPtr java_class_ref
		{
			get
			{
				return ICoroutineStackFrameInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000819 RID: 2073
		// (get) Token: 0x06001C19 RID: 7193 RVA: 0x0005DC5C File Offset: 0x0005BE5C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ICoroutineStackFrameInvoker._members;
			}
		}

		// Token: 0x1700081A RID: 2074
		// (get) Token: 0x06001C1A RID: 7194 RVA: 0x0005DC63 File Offset: 0x0005BE63
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700081B RID: 2075
		// (get) Token: 0x06001C1B RID: 7195 RVA: 0x0005DC6B File Offset: 0x0005BE6B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ICoroutineStackFrameInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001C1C RID: 7196 RVA: 0x0005DC77 File Offset: 0x0005BE77
		[NullableContext(2)]
		public static ICoroutineStackFrame GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ICoroutineStackFrame>(handle, transfer);
		}

		// Token: 0x06001C1D RID: 7197 RVA: 0x0005DC80 File Offset: 0x0005BE80
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ICoroutineStackFrameInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.coroutines.jvm.internal.CoroutineStackFrame'.");
			}
			return handle;
		}

		// Token: 0x06001C1E RID: 7198 RVA: 0x0005DCAB File Offset: 0x0005BEAB
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001C1F RID: 7199 RVA: 0x0005DCDC File Offset: 0x0005BEDC
		public ICoroutineStackFrameInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ICoroutineStackFrameInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06001C20 RID: 7200 RVA: 0x0005DD14 File Offset: 0x0005BF14
		private static Delegate GetGetCallerFrameHandler()
		{
			if (ICoroutineStackFrameInvoker.cb_getCallerFrame == null)
			{
				ICoroutineStackFrameInvoker.cb_getCallerFrame = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ICoroutineStackFrameInvoker.n_GetCallerFrame));
			}
			return ICoroutineStackFrameInvoker.cb_getCallerFrame;
		}

		// Token: 0x06001C21 RID: 7201 RVA: 0x0005DD38 File Offset: 0x0005BF38
		private static IntPtr n_GetCallerFrame(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ICoroutineStackFrame>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CallerFrame);
		}

		// Token: 0x1700081C RID: 2076
		// (get) Token: 0x06001C22 RID: 7202 RVA: 0x0005DD4C File Offset: 0x0005BF4C
		[Nullable(2)]
		public ICoroutineStackFrame CallerFrame
		{
			[NullableContext(2)]
			get
			{
				if (this.id_getCallerFrame == IntPtr.Zero)
				{
					this.id_getCallerFrame = JNIEnv.GetMethodID(this.class_ref, "getCallerFrame", "()Lkotlin/coroutines/jvm/internal/CoroutineStackFrame;");
				}
				return Java.Lang.Object.GetObject<ICoroutineStackFrame>(JNIEnv.CallObjectMethod(base.Handle, this.id_getCallerFrame), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06001C23 RID: 7203 RVA: 0x0005DD9D File Offset: 0x0005BF9D
		private static Delegate GetGetStackTraceElementHandler()
		{
			if (ICoroutineStackFrameInvoker.cb_getStackTraceElement == null)
			{
				ICoroutineStackFrameInvoker.cb_getStackTraceElement = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ICoroutineStackFrameInvoker.n_GetStackTraceElement));
			}
			return ICoroutineStackFrameInvoker.cb_getStackTraceElement;
		}

		// Token: 0x06001C24 RID: 7204 RVA: 0x0005DDC1 File Offset: 0x0005BFC1
		private static IntPtr n_GetStackTraceElement(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ICoroutineStackFrame>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).StackTraceElement);
		}

		// Token: 0x1700081D RID: 2077
		// (get) Token: 0x06001C25 RID: 7205 RVA: 0x0005DDD8 File Offset: 0x0005BFD8
		[Nullable(2)]
		public StackTraceElement StackTraceElement
		{
			[NullableContext(2)]
			get
			{
				if (this.id_getStackTraceElement == IntPtr.Zero)
				{
					this.id_getStackTraceElement = JNIEnv.GetMethodID(this.class_ref, "getStackTraceElement", "()Ljava/lang/StackTraceElement;");
				}
				return Java.Lang.Object.GetObject<StackTraceElement>(JNIEnv.CallObjectMethod(base.Handle, this.id_getStackTraceElement), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x040008AA RID: 2218
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/coroutines/jvm/internal/CoroutineStackFrame", typeof(ICoroutineStackFrameInvoker));

		// Token: 0x040008AB RID: 2219
		private IntPtr class_ref;

		// Token: 0x040008AC RID: 2220
		[Nullable(2)]
		private static Delegate cb_getCallerFrame;

		// Token: 0x040008AD RID: 2221
		private IntPtr id_getCallerFrame;

		// Token: 0x040008AE RID: 2222
		[Nullable(2)]
		private static Delegate cb_getStackTraceElement;

		// Token: 0x040008AF RID: 2223
		private IntPtr id_getStackTraceElement;
	}
}
