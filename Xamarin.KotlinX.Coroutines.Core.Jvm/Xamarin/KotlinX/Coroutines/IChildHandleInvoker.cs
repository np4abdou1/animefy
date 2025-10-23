using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.KotlinX.Coroutines
{
	// Token: 0x02000040 RID: 64
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/ChildHandle", DoNotGenerateAcw = true)]
	internal class IChildHandleInvoker : Java.Lang.Object, IChildHandle, IDisposableHandle, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060001BB RID: 443 RVA: 0x00006278 File Offset: 0x00004478
		private static IntPtr java_class_ref
		{
			get
			{
				return IChildHandleInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060001BC RID: 444 RVA: 0x0000629C File Offset: 0x0000449C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IChildHandleInvoker._members;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060001BD RID: 445 RVA: 0x000062A3 File Offset: 0x000044A3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060001BE RID: 446 RVA: 0x000062AB File Offset: 0x000044AB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IChildHandleInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060001BF RID: 447 RVA: 0x000062B7 File Offset: 0x000044B7
		[NullableContext(2)]
		public static IChildHandle GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IChildHandle>(handle, transfer);
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x000062C0 File Offset: 0x000044C0
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IChildHandleInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlinx.coroutines.ChildHandle'.");
			}
			return handle;
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x000062EB File Offset: 0x000044EB
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x0000631C File Offset: 0x0000451C
		public IChildHandleInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IChildHandleInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00006354 File Offset: 0x00004554
		private static Delegate GetGetParentHandler()
		{
			if (IChildHandleInvoker.cb_getParent == null)
			{
				IChildHandleInvoker.cb_getParent = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IChildHandleInvoker.n_GetParent));
			}
			return IChildHandleInvoker.cb_getParent;
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00006378 File Offset: 0x00004578
		private static IntPtr n_GetParent(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IChildHandle>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Parent);
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060001C5 RID: 453 RVA: 0x0000638C File Offset: 0x0000458C
		[Nullable(2)]
		public IJob Parent
		{
			[NullableContext(2)]
			get
			{
				if (this.id_getParent == IntPtr.Zero)
				{
					this.id_getParent = JNIEnv.GetMethodID(this.class_ref, "getParent", "()Lkotlinx/coroutines/Job;");
				}
				return Java.Lang.Object.GetObject<IJob>(JNIEnv.CallObjectMethod(base.Handle, this.id_getParent), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x000063DD File Offset: 0x000045DD
		private static Delegate GetChildCancelled_Ljava_lang_Throwable_Handler()
		{
			if (IChildHandleInvoker.cb_childCancelled_Ljava_lang_Throwable_ == null)
			{
				IChildHandleInvoker.cb_childCancelled_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IChildHandleInvoker.n_ChildCancelled_Ljava_lang_Throwable_));
			}
			return IChildHandleInvoker.cb_childCancelled_Ljava_lang_Throwable_;
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00006404 File Offset: 0x00004604
		private static bool n_ChildCancelled_Ljava_lang_Throwable_(IntPtr jnienv, IntPtr native__this, IntPtr native_cause)
		{
			IChildHandle @object = Java.Lang.Object.GetObject<IChildHandle>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Throwable object2 = Java.Lang.Object.GetObject<Throwable>(native_cause, JniHandleOwnership.DoNotTransfer);
			return @object.ChildCancelled(object2);
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00006428 File Offset: 0x00004628
		public unsafe bool ChildCancelled(Throwable cause)
		{
			if (this.id_childCancelled_Ljava_lang_Throwable_ == IntPtr.Zero)
			{
				this.id_childCancelled_Ljava_lang_Throwable_ = JNIEnv.GetMethodID(this.class_ref, "childCancelled", "(Ljava/lang/Throwable;)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((cause == null) ? IntPtr.Zero : cause.Handle);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_childCancelled_Ljava_lang_Throwable_, ptr);
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x0000649B File Offset: 0x0000469B
		private static Delegate GetDisposeHandler()
		{
			if (IChildHandleInvoker.cb_dispose == null)
			{
				IChildHandleInvoker.cb_dispose = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IChildHandleInvoker.n_Dispose));
			}
			return IChildHandleInvoker.cb_dispose;
		}

		// Token: 0x060001CA RID: 458 RVA: 0x000064BF File Offset: 0x000046BF
		private static void n_Dispose(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IChildHandle>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Dispose();
		}

		// Token: 0x060001CB RID: 459 RVA: 0x000064CE File Offset: 0x000046CE
		public new void Dispose()
		{
			if (this.id_dispose == IntPtr.Zero)
			{
				this.id_dispose = JNIEnv.GetMethodID(this.class_ref, "dispose", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_dispose);
		}

		// Token: 0x04000053 RID: 83
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/ChildHandle", typeof(IChildHandleInvoker));

		// Token: 0x04000054 RID: 84
		private IntPtr class_ref;

		// Token: 0x04000055 RID: 85
		[Nullable(2)]
		private static Delegate cb_getParent;

		// Token: 0x04000056 RID: 86
		private IntPtr id_getParent;

		// Token: 0x04000057 RID: 87
		[Nullable(2)]
		private static Delegate cb_childCancelled_Ljava_lang_Throwable_;

		// Token: 0x04000058 RID: 88
		private IntPtr id_childCancelled_Ljava_lang_Throwable_;

		// Token: 0x04000059 RID: 89
		[Nullable(2)]
		private static Delegate cb_dispose;

		// Token: 0x0400005A RID: 90
		private IntPtr id_dispose;
	}
}
