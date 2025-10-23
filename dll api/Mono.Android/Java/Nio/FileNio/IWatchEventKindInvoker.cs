using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Nio.FileNio
{
	// Token: 0x02000386 RID: 902
	[Register("java/nio/file/WatchEvent$Kind", DoNotGenerateAcw = true, ApiSince = 26)]
	internal class IWatchEventKindInvoker : Java.Lang.Object, IWatchEventKind, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700079B RID: 1947
		// (get) Token: 0x060027F8 RID: 10232 RVA: 0x00071A60 File Offset: 0x0006FC60
		private static IntPtr java_class_ref
		{
			get
			{
				return IWatchEventKindInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700079C RID: 1948
		// (get) Token: 0x060027F9 RID: 10233 RVA: 0x00071A84 File Offset: 0x0006FC84
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IWatchEventKindInvoker._members;
			}
		}

		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x060027FA RID: 10234 RVA: 0x00071A8B File Offset: 0x0006FC8B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x060027FB RID: 10235 RVA: 0x00071A93 File Offset: 0x0006FC93
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IWatchEventKindInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060027FC RID: 10236 RVA: 0x00071A9F File Offset: 0x0006FC9F
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IWatchEventKindInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.nio.file.WatchEvent.Kind'.");
			}
			return handle;
		}

		// Token: 0x060027FD RID: 10237 RVA: 0x00071ACA File Offset: 0x0006FCCA
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060027FE RID: 10238 RVA: 0x00071AFC File Offset: 0x0006FCFC
		public IWatchEventKindInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IWatchEventKindInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060027FF RID: 10239 RVA: 0x00071B34 File Offset: 0x0006FD34
		private static Delegate GetNameHandler()
		{
			if (IWatchEventKindInvoker.cb_name == null)
			{
				IWatchEventKindInvoker.cb_name = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IWatchEventKindInvoker.n_Name));
			}
			return IWatchEventKindInvoker.cb_name;
		}

		// Token: 0x06002800 RID: 10240 RVA: 0x00071B58 File Offset: 0x0006FD58
		private static IntPtr n_Name(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IWatchEventKind>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Name());
		}

		// Token: 0x06002801 RID: 10241 RVA: 0x00071B6C File Offset: 0x0006FD6C
		public string Name()
		{
			if (this.id_name == IntPtr.Zero)
			{
				this.id_name = JNIEnv.GetMethodID(this.class_ref, "name", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_name), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06002802 RID: 10242 RVA: 0x00071BBD File Offset: 0x0006FDBD
		private static Delegate GetTypeHandler()
		{
			if (IWatchEventKindInvoker.cb_type == null)
			{
				IWatchEventKindInvoker.cb_type = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IWatchEventKindInvoker.n_Type));
			}
			return IWatchEventKindInvoker.cb_type;
		}

		// Token: 0x06002803 RID: 10243 RVA: 0x00071BE1 File Offset: 0x0006FDE1
		private static IntPtr n_Type(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IWatchEventKind>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Type());
		}

		// Token: 0x06002804 RID: 10244 RVA: 0x00071BF8 File Offset: 0x0006FDF8
		public Class Type()
		{
			if (this.id_type == IntPtr.Zero)
			{
				this.id_type = JNIEnv.GetMethodID(this.class_ref, "type", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_type), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400106F RID: 4207
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/nio/file/WatchEvent$Kind", typeof(IWatchEventKindInvoker));

		// Token: 0x04001070 RID: 4208
		private IntPtr class_ref;

		// Token: 0x04001071 RID: 4209
		private static Delegate cb_name;

		// Token: 0x04001072 RID: 4210
		private IntPtr id_name;

		// Token: 0x04001073 RID: 4211
		private static Delegate cb_type;

		// Token: 0x04001074 RID: 4212
		private IntPtr id_type;
	}
}
