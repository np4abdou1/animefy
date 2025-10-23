using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Coroutines;

namespace Xamarin.KotlinX.Coroutines
{
	// Token: 0x02000056 RID: 86
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/CoroutineScope", DoNotGenerateAcw = true)]
	internal class ICoroutineScopeInvoker : Java.Lang.Object, ICoroutineScope, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000341 RID: 833 RVA: 0x0000B658 File Offset: 0x00009858
		private static IntPtr java_class_ref
		{
			get
			{
				return ICoroutineScopeInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000342 RID: 834 RVA: 0x0000B67C File Offset: 0x0000987C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ICoroutineScopeInvoker._members;
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000343 RID: 835 RVA: 0x0000B683 File Offset: 0x00009883
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000344 RID: 836 RVA: 0x0000B68B File Offset: 0x0000988B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ICoroutineScopeInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000345 RID: 837 RVA: 0x0000B697 File Offset: 0x00009897
		[NullableContext(2)]
		public static ICoroutineScope GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ICoroutineScope>(handle, transfer);
		}

		// Token: 0x06000346 RID: 838 RVA: 0x0000B6A0 File Offset: 0x000098A0
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ICoroutineScopeInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlinx.coroutines.CoroutineScope'.");
			}
			return handle;
		}

		// Token: 0x06000347 RID: 839 RVA: 0x0000B6CB File Offset: 0x000098CB
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000348 RID: 840 RVA: 0x0000B6FC File Offset: 0x000098FC
		public ICoroutineScopeInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ICoroutineScopeInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000349 RID: 841 RVA: 0x0000B734 File Offset: 0x00009934
		private static Delegate GetGetCoroutineContextHandler()
		{
			if (ICoroutineScopeInvoker.cb_getCoroutineContext == null)
			{
				ICoroutineScopeInvoker.cb_getCoroutineContext = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ICoroutineScopeInvoker.n_GetCoroutineContext));
			}
			return ICoroutineScopeInvoker.cb_getCoroutineContext;
		}

		// Token: 0x0600034A RID: 842 RVA: 0x0000B758 File Offset: 0x00009958
		private static IntPtr n_GetCoroutineContext(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ICoroutineScope>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CoroutineContext);
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x0600034B RID: 843 RVA: 0x0000B76C File Offset: 0x0000996C
		public ICoroutineContext CoroutineContext
		{
			get
			{
				if (this.id_getCoroutineContext == IntPtr.Zero)
				{
					this.id_getCoroutineContext = JNIEnv.GetMethodID(this.class_ref, "getCoroutineContext", "()Lkotlin/coroutines/CoroutineContext;");
				}
				return Java.Lang.Object.GetObject<ICoroutineContext>(JNIEnv.CallObjectMethod(base.Handle, this.id_getCoroutineContext), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x04000112 RID: 274
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/CoroutineScope", typeof(ICoroutineScopeInvoker));

		// Token: 0x04000113 RID: 275
		private IntPtr class_ref;

		// Token: 0x04000114 RID: 276
		[Nullable(2)]
		private static Delegate cb_getCoroutineContext;

		// Token: 0x04000115 RID: 277
		private IntPtr id_getCoroutineContext;
	}
}
