using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Nio;

namespace Java.Lang
{
	// Token: 0x020003DF RID: 991
	[Register("java/lang/Readable", DoNotGenerateAcw = true)]
	internal class IReadableInvoker : Object, IReadable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700088C RID: 2188
		// (get) Token: 0x06002B8D RID: 11149 RVA: 0x00078E80 File Offset: 0x00077080
		private static IntPtr java_class_ref
		{
			get
			{
				return IReadableInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700088D RID: 2189
		// (get) Token: 0x06002B8E RID: 11150 RVA: 0x00078EA4 File Offset: 0x000770A4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IReadableInvoker._members;
			}
		}

		// Token: 0x1700088E RID: 2190
		// (get) Token: 0x06002B8F RID: 11151 RVA: 0x00078EAB File Offset: 0x000770AB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700088F RID: 2191
		// (get) Token: 0x06002B90 RID: 11152 RVA: 0x00078EB3 File Offset: 0x000770B3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IReadableInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06002B91 RID: 11153 RVA: 0x00078EBF File Offset: 0x000770BF
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IReadableInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.lang.Readable'.");
			}
			return handle;
		}

		// Token: 0x06002B92 RID: 11154 RVA: 0x00078EEA File Offset: 0x000770EA
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06002B93 RID: 11155 RVA: 0x00078F1C File Offset: 0x0007711C
		public IReadableInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IReadableInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06002B94 RID: 11156 RVA: 0x00078F54 File Offset: 0x00077154
		private static Delegate GetRead_Ljava_nio_CharBuffer_Handler()
		{
			if (IReadableInvoker.cb_read_Ljava_nio_CharBuffer_ == null)
			{
				IReadableInvoker.cb_read_Ljava_nio_CharBuffer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(IReadableInvoker.n_Read_Ljava_nio_CharBuffer_));
			}
			return IReadableInvoker.cb_read_Ljava_nio_CharBuffer_;
		}

		// Token: 0x06002B95 RID: 11157 RVA: 0x00078F78 File Offset: 0x00077178
		private static int n_Read_Ljava_nio_CharBuffer_(IntPtr jnienv, IntPtr native__this, IntPtr native_cb)
		{
			IReadable @object = Object.GetObject<IReadable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			CharBuffer object2 = Object.GetObject<CharBuffer>(native_cb, JniHandleOwnership.DoNotTransfer);
			return @object.Read(object2);
		}

		// Token: 0x06002B96 RID: 11158 RVA: 0x00078F9C File Offset: 0x0007719C
		public unsafe int Read(CharBuffer cb)
		{
			if (this.id_read_Ljava_nio_CharBuffer_ == IntPtr.Zero)
			{
				this.id_read_Ljava_nio_CharBuffer_ = JNIEnv.GetMethodID(this.class_ref, "read", "(Ljava/nio/CharBuffer;)I");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((cb == null) ? IntPtr.Zero : cb.Handle);
			return JNIEnv.CallIntMethod(base.Handle, this.id_read_Ljava_nio_CharBuffer_, ptr);
		}

		// Token: 0x0400116A RID: 4458
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/lang/Readable", typeof(IReadableInvoker));

		// Token: 0x0400116B RID: 4459
		private IntPtr class_ref;

		// Token: 0x0400116C RID: 4460
		private static Delegate cb_read_Ljava_nio_CharBuffer_;

		// Token: 0x0400116D RID: 4461
		private IntPtr id_read_Ljava_nio_CharBuffer_;
	}
}
