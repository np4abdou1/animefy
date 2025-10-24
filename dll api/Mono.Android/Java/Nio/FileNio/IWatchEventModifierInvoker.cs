using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Nio.FileNio
{
	// Token: 0x02000388 RID: 904
	[Register("java/nio/file/WatchEvent$Modifier", DoNotGenerateAcw = true, ApiSince = 26)]
	internal class IWatchEventModifierInvoker : Java.Lang.Object, IWatchEventModifier, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x06002807 RID: 10247 RVA: 0x00071C64 File Offset: 0x0006FE64
		private static IntPtr java_class_ref
		{
			get
			{
				return IWatchEventModifierInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x06002808 RID: 10248 RVA: 0x00071C88 File Offset: 0x0006FE88
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IWatchEventModifierInvoker._members;
			}
		}

		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x06002809 RID: 10249 RVA: 0x00071C8F File Offset: 0x0006FE8F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x0600280A RID: 10250 RVA: 0x00071C97 File Offset: 0x0006FE97
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IWatchEventModifierInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600280B RID: 10251 RVA: 0x00071CA3 File Offset: 0x0006FEA3
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IWatchEventModifierInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.nio.file.WatchEvent.Modifier'.");
			}
			return handle;
		}

		// Token: 0x0600280C RID: 10252 RVA: 0x00071CCE File Offset: 0x0006FECE
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600280D RID: 10253 RVA: 0x00071D00 File Offset: 0x0006FF00
		public IWatchEventModifierInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IWatchEventModifierInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600280E RID: 10254 RVA: 0x00071D38 File Offset: 0x0006FF38
		private static Delegate GetNameHandler()
		{
			if (IWatchEventModifierInvoker.cb_name == null)
			{
				IWatchEventModifierInvoker.cb_name = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IWatchEventModifierInvoker.n_Name));
			}
			return IWatchEventModifierInvoker.cb_name;
		}

		// Token: 0x0600280F RID: 10255 RVA: 0x00071D5C File Offset: 0x0006FF5C
		private static IntPtr n_Name(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IWatchEventModifier>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Name());
		}

		// Token: 0x06002810 RID: 10256 RVA: 0x00071D70 File Offset: 0x0006FF70
		public string Name()
		{
			if (this.id_name == IntPtr.Zero)
			{
				this.id_name = JNIEnv.GetMethodID(this.class_ref, "name", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_name), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04001075 RID: 4213
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/nio/file/WatchEvent$Modifier", typeof(IWatchEventModifierInvoker));

		// Token: 0x04001076 RID: 4214
		private IntPtr class_ref;

		// Token: 0x04001077 RID: 4215
		private static Delegate cb_name;

		// Token: 0x04001078 RID: 4216
		private IntPtr id_name;
	}
}
