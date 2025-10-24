using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Model
{
	// Token: 0x02000135 RID: 309
	[Register("com/bumptech/glide/load/model/Headers", DoNotGenerateAcw = true)]
	internal class IHeadersInvoker : Java.Lang.Object, IHeaders, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06000FB8 RID: 4024 RVA: 0x00032BBC File Offset: 0x00030DBC
		private static IntPtr java_class_ref
		{
			get
			{
				return IHeadersInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06000FB9 RID: 4025 RVA: 0x00032BE0 File Offset: 0x00030DE0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IHeadersInvoker._members;
			}
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06000FBA RID: 4026 RVA: 0x00032BE7 File Offset: 0x00030DE7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06000FBB RID: 4027 RVA: 0x00032BEF File Offset: 0x00030DEF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IHeadersInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000FBC RID: 4028 RVA: 0x00032BFB File Offset: 0x00030DFB
		public static IHeaders GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IHeaders>(handle, transfer);
		}

		// Token: 0x06000FBD RID: 4029 RVA: 0x00032C04 File Offset: 0x00030E04
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IHeadersInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.bumptech.glide.load.model.Headers'.");
			}
			return handle;
		}

		// Token: 0x06000FBE RID: 4030 RVA: 0x00032C2F File Offset: 0x00030E2F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000FBF RID: 4031 RVA: 0x00032C60 File Offset: 0x00030E60
		public IHeadersInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IHeadersInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000FC0 RID: 4032 RVA: 0x00032C98 File Offset: 0x00030E98
		private static Delegate GetGetHeadersHandler()
		{
			if (IHeadersInvoker.cb_getHeaders == null)
			{
				IHeadersInvoker.cb_getHeaders = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IHeadersInvoker.n_GetHeaders));
			}
			return IHeadersInvoker.cb_getHeaders;
		}

		// Token: 0x06000FC1 RID: 4033 RVA: 0x00032CBC File Offset: 0x00030EBC
		private static IntPtr n_GetHeaders(IntPtr jnienv, IntPtr native__this)
		{
			return JavaDictionary<string, string>.ToLocalJniHandle(Java.Lang.Object.GetObject<IHeaders>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Headers);
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06000FC2 RID: 4034 RVA: 0x00032CD0 File Offset: 0x00030ED0
		public IDictionary<string, string> Headers
		{
			get
			{
				if (this.id_getHeaders == IntPtr.Zero)
				{
					this.id_getHeaders = JNIEnv.GetMethodID(this.class_ref, "getHeaders", "()Ljava/util/Map;");
				}
				return JavaDictionary<string, string>.FromJniHandle(JNIEnv.CallObjectMethod(base.Handle, this.id_getHeaders), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0400039E RID: 926
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/model/Headers", typeof(IHeadersInvoker));

		// Token: 0x0400039F RID: 927
		private IntPtr class_ref;

		// Token: 0x040003A0 RID: 928
		private static Delegate cb_getHeaders;

		// Token: 0x040003A1 RID: 929
		private IntPtr id_getHeaders;
	}
}
