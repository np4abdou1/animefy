using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Util.Functions
{
	// Token: 0x02000336 RID: 822
	[Register("java/util/function/IntFunction", DoNotGenerateAcw = true, ApiSince = 24)]
	internal class IIntFunctionInvoker : Java.Lang.Object, IIntFunction, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x060022FD RID: 8957 RVA: 0x000629F4 File Offset: 0x00060BF4
		private static IntPtr java_class_ref
		{
			get
			{
				return IIntFunctionInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x060022FE RID: 8958 RVA: 0x00062A18 File Offset: 0x00060C18
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IIntFunctionInvoker._members;
			}
		}

		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x060022FF RID: 8959 RVA: 0x00062A1F File Offset: 0x00060C1F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x06002300 RID: 8960 RVA: 0x00062A27 File Offset: 0x00060C27
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IIntFunctionInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06002301 RID: 8961 RVA: 0x00062A33 File Offset: 0x00060C33
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IIntFunctionInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.util.function.IntFunction'.");
			}
			return handle;
		}

		// Token: 0x06002302 RID: 8962 RVA: 0x00062A5E File Offset: 0x00060C5E
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06002303 RID: 8963 RVA: 0x00062A90 File Offset: 0x00060C90
		public IIntFunctionInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IIntFunctionInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06002304 RID: 8964 RVA: 0x00062AC8 File Offset: 0x00060CC8
		private static Delegate GetApply_IHandler()
		{
			if (IIntFunctionInvoker.cb_apply_I == null)
			{
				IIntFunctionInvoker.cb_apply_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(IIntFunctionInvoker.n_Apply_I));
			}
			return IIntFunctionInvoker.cb_apply_I;
		}

		// Token: 0x06002305 RID: 8965 RVA: 0x00062AEC File Offset: 0x00060CEC
		private static IntPtr n_Apply_I(IntPtr jnienv, IntPtr native__this, int value)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IIntFunction>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Apply(value));
		}

		// Token: 0x06002306 RID: 8966 RVA: 0x00062B04 File Offset: 0x00060D04
		public unsafe Java.Lang.Object Apply(int value)
		{
			if (this.id_apply_I == IntPtr.Zero)
			{
				this.id_apply_I = JNIEnv.GetMethodID(this.class_ref, "apply", "(I)Ljava/lang/Object;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(value);
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_apply_I, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000E70 RID: 3696
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/function/IntFunction", typeof(IIntFunctionInvoker));

		// Token: 0x04000E71 RID: 3697
		private IntPtr class_ref;

		// Token: 0x04000E72 RID: 3698
		private static Delegate cb_apply_I;

		// Token: 0x04000E73 RID: 3699
		private IntPtr id_apply_I;
	}
}
