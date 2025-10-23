using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Jvm.Functions
{
	// Token: 0x020001E7 RID: 487
	[Register("kotlin/jvm/functions/Function0", DoNotGenerateAcw = true)]
	internal class IFunction0Invoker : Java.Lang.Object, IFunction0, IFunction, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x060017B1 RID: 6065 RVA: 0x0004D930 File Offset: 0x0004BB30
		private static IntPtr java_class_ref
		{
			get
			{
				return IFunction0Invoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x060017B2 RID: 6066 RVA: 0x0004D954 File Offset: 0x0004BB54
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return IFunction0Invoker._members;
			}
		}

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x060017B3 RID: 6067 RVA: 0x0004D95B File Offset: 0x0004BB5B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x060017B4 RID: 6068 RVA: 0x0004D963 File Offset: 0x0004BB63
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return IFunction0Invoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060017B5 RID: 6069 RVA: 0x0004D96F File Offset: 0x0004BB6F
		[NullableContext(2)]
		public static IFunction0 GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IFunction0>(handle, transfer);
		}

		// Token: 0x060017B6 RID: 6070 RVA: 0x0004D978 File Offset: 0x0004BB78
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IFunction0Invoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.jvm.functions.Function0'.");
			}
			return handle;
		}

		// Token: 0x060017B7 RID: 6071 RVA: 0x0004D9A3 File Offset: 0x0004BBA3
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060017B8 RID: 6072 RVA: 0x0004D9D4 File Offset: 0x0004BBD4
		public IFunction0Invoker(IntPtr handle, JniHandleOwnership transfer) : base(IFunction0Invoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060017B9 RID: 6073 RVA: 0x0004DA0C File Offset: 0x0004BC0C
		[NullableContext(1)]
		private static Delegate GetInvokeHandler()
		{
			if (IFunction0Invoker.cb_invoke == null)
			{
				IFunction0Invoker.cb_invoke = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IFunction0Invoker.n_Invoke));
			}
			return IFunction0Invoker.cb_invoke;
		}

		// Token: 0x060017BA RID: 6074 RVA: 0x0004DA30 File Offset: 0x0004BC30
		private static IntPtr n_Invoke(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IFunction0>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Invoke());
		}

		// Token: 0x060017BB RID: 6075 RVA: 0x0004DA44 File Offset: 0x0004BC44
		[NullableContext(2)]
		public Java.Lang.Object Invoke()
		{
			if (this.id_invoke == IntPtr.Zero)
			{
				this.id_invoke = JNIEnv.GetMethodID(this.class_ref, "invoke", "()Ljava/lang/Object;");
			}
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_invoke), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400075D RID: 1885
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/functions/Function0", typeof(IFunction0Invoker));

		// Token: 0x0400075E RID: 1886
		private IntPtr class_ref;

		// Token: 0x0400075F RID: 1887
		[Nullable(2)]
		private static Delegate cb_invoke;

		// Token: 0x04000760 RID: 1888
		private IntPtr id_invoke;
	}
}
