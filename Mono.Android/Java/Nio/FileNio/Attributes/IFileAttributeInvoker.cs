using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Nio.FileNio.Attributes
{
	// Token: 0x02000394 RID: 916
	[Register("java/nio/file/attribute/FileAttribute", DoNotGenerateAcw = true, ApiSince = 26)]
	internal class IFileAttributeInvoker : Java.Lang.Object, IFileAttribute, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x06002894 RID: 10388 RVA: 0x00072D7C File Offset: 0x00070F7C
		private static IntPtr java_class_ref
		{
			get
			{
				return IFileAttributeInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007C4 RID: 1988
		// (get) Token: 0x06002895 RID: 10389 RVA: 0x00072DA0 File Offset: 0x00070FA0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IFileAttributeInvoker._members;
			}
		}

		// Token: 0x170007C5 RID: 1989
		// (get) Token: 0x06002896 RID: 10390 RVA: 0x00072DA7 File Offset: 0x00070FA7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170007C6 RID: 1990
		// (get) Token: 0x06002897 RID: 10391 RVA: 0x00072DAF File Offset: 0x00070FAF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IFileAttributeInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06002898 RID: 10392 RVA: 0x00072DBB File Offset: 0x00070FBB
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IFileAttributeInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.nio.file.attribute.FileAttribute'.");
			}
			return handle;
		}

		// Token: 0x06002899 RID: 10393 RVA: 0x00072DE6 File Offset: 0x00070FE6
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600289A RID: 10394 RVA: 0x00072E18 File Offset: 0x00071018
		public IFileAttributeInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IFileAttributeInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600289B RID: 10395 RVA: 0x00072E50 File Offset: 0x00071050
		private static Delegate GetNameHandler()
		{
			if (IFileAttributeInvoker.cb_name == null)
			{
				IFileAttributeInvoker.cb_name = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IFileAttributeInvoker.n_Name));
			}
			return IFileAttributeInvoker.cb_name;
		}

		// Token: 0x0600289C RID: 10396 RVA: 0x00072E74 File Offset: 0x00071074
		private static IntPtr n_Name(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IFileAttribute>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Name());
		}

		// Token: 0x0600289D RID: 10397 RVA: 0x00072E88 File Offset: 0x00071088
		public string Name()
		{
			if (this.id_name == IntPtr.Zero)
			{
				this.id_name = JNIEnv.GetMethodID(this.class_ref, "name", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_name), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600289E RID: 10398 RVA: 0x00072ED9 File Offset: 0x000710D9
		private static Delegate GetValueHandler()
		{
			if (IFileAttributeInvoker.cb_value == null)
			{
				IFileAttributeInvoker.cb_value = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IFileAttributeInvoker.n_Value));
			}
			return IFileAttributeInvoker.cb_value;
		}

		// Token: 0x0600289F RID: 10399 RVA: 0x00072EFD File Offset: 0x000710FD
		private static IntPtr n_Value(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IFileAttribute>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Value());
		}

		// Token: 0x060028A0 RID: 10400 RVA: 0x00072F14 File Offset: 0x00071114
		public Java.Lang.Object Value()
		{
			if (this.id_value == IntPtr.Zero)
			{
				this.id_value = JNIEnv.GetMethodID(this.class_ref, "value", "()Ljava/lang/Object;");
			}
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_value), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040010AD RID: 4269
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/nio/file/attribute/FileAttribute", typeof(IFileAttributeInvoker));

		// Token: 0x040010AE RID: 4270
		private IntPtr class_ref;

		// Token: 0x040010AF RID: 4271
		private static Delegate cb_name;

		// Token: 0x040010B0 RID: 4272
		private IntPtr id_name;

		// Token: 0x040010B1 RID: 4273
		private static Delegate cb_value;

		// Token: 0x040010B2 RID: 4274
		private IntPtr id_value;
	}
}
