using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Java.Lang
{
	// Token: 0x020003E1 RID: 993
	[Register("java/lang/Runnable", DoNotGenerateAcw = true)]
	internal class IRunnableInvoker : Object, IRunnable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000890 RID: 2192
		// (get) Token: 0x06002B99 RID: 11161 RVA: 0x0007902C File Offset: 0x0007722C
		private static IntPtr java_class_ref
		{
			get
			{
				return IRunnableInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000891 RID: 2193
		// (get) Token: 0x06002B9A RID: 11162 RVA: 0x00079050 File Offset: 0x00077250
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IRunnableInvoker._members;
			}
		}

		// Token: 0x17000892 RID: 2194
		// (get) Token: 0x06002B9B RID: 11163 RVA: 0x00079057 File Offset: 0x00077257
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000893 RID: 2195
		// (get) Token: 0x06002B9C RID: 11164 RVA: 0x0007905F File Offset: 0x0007725F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IRunnableInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06002B9D RID: 11165 RVA: 0x0007906B File Offset: 0x0007726B
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IRunnableInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.lang.Runnable'.");
			}
			return handle;
		}

		// Token: 0x06002B9E RID: 11166 RVA: 0x00079096 File Offset: 0x00077296
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06002B9F RID: 11167 RVA: 0x000790C8 File Offset: 0x000772C8
		public IRunnableInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IRunnableInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06002BA0 RID: 11168 RVA: 0x00079100 File Offset: 0x00077300
		private static Delegate GetRunHandler()
		{
			if (IRunnableInvoker.cb_run == null)
			{
				IRunnableInvoker.cb_run = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IRunnableInvoker.n_Run));
			}
			return IRunnableInvoker.cb_run;
		}

		// Token: 0x06002BA1 RID: 11169 RVA: 0x00079124 File Offset: 0x00077324
		private static void n_Run(IntPtr jnienv, IntPtr native__this)
		{
			Object.GetObject<IRunnable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Run();
		}

		// Token: 0x06002BA2 RID: 11170 RVA: 0x00079133 File Offset: 0x00077333
		public void Run()
		{
			if (this.id_run == IntPtr.Zero)
			{
				this.id_run = JNIEnv.GetMethodID(this.class_ref, "run", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_run);
		}

		// Token: 0x0400116E RID: 4462
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/lang/Runnable", typeof(IRunnableInvoker));

		// Token: 0x0400116F RID: 4463
		private IntPtr class_ref;

		// Token: 0x04001170 RID: 4464
		private static Delegate cb_run;

		// Token: 0x04001171 RID: 4465
		private IntPtr id_run;
	}
}
