using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.KotlinX.Coroutines
{
	// Token: 0x02000060 RID: 96
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/DisposableHandle", DoNotGenerateAcw = true)]
	internal class IDisposableHandleInvoker : Java.Lang.Object, IDisposableHandle, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700011A RID: 282
		// (get) Token: 0x060003DD RID: 989 RVA: 0x0000D518 File Offset: 0x0000B718
		private static IntPtr java_class_ref
		{
			get
			{
				return IDisposableHandleInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x060003DE RID: 990 RVA: 0x0000D53C File Offset: 0x0000B73C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IDisposableHandleInvoker._members;
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x060003DF RID: 991 RVA: 0x0000D543 File Offset: 0x0000B743
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x060003E0 RID: 992 RVA: 0x0000D54B File Offset: 0x0000B74B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IDisposableHandleInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x0000D557 File Offset: 0x0000B757
		[NullableContext(2)]
		public static IDisposableHandle GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IDisposableHandle>(handle, transfer);
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x0000D560 File Offset: 0x0000B760
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IDisposableHandleInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlinx.coroutines.DisposableHandle'.");
			}
			return handle;
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x0000D58B File Offset: 0x0000B78B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x0000D5BC File Offset: 0x0000B7BC
		public IDisposableHandleInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IDisposableHandleInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x0000D5F4 File Offset: 0x0000B7F4
		private static Delegate GetDisposeHandler()
		{
			if (IDisposableHandleInvoker.cb_dispose == null)
			{
				IDisposableHandleInvoker.cb_dispose = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IDisposableHandleInvoker.n_Dispose));
			}
			return IDisposableHandleInvoker.cb_dispose;
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x0000D618 File Offset: 0x0000B818
		private static void n_Dispose(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IDisposableHandle>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Dispose();
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x0000D627 File Offset: 0x0000B827
		public new void Dispose()
		{
			if (this.id_dispose == IntPtr.Zero)
			{
				this.id_dispose = JNIEnv.GetMethodID(this.class_ref, "dispose", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_dispose);
		}

		// Token: 0x0400015A RID: 346
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/DisposableHandle", typeof(IDisposableHandleInvoker));

		// Token: 0x0400015B RID: 347
		private IntPtr class_ref;

		// Token: 0x0400015C RID: 348
		[Nullable(2)]
		private static Delegate cb_dispose;

		// Token: 0x0400015D RID: 349
		private IntPtr id_dispose;
	}
}
