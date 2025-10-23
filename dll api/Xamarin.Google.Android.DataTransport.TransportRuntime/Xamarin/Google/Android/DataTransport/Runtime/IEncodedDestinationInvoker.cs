using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Runtime
{
	// Token: 0x02000025 RID: 37
	[Register("com/google/android/datatransport/runtime/EncodedDestination", DoNotGenerateAcw = true)]
	internal class IEncodedDestinationInvoker : Java.Lang.Object, IEncodedDestination, IDestination, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x00003BD0 File Offset: 0x00001DD0
		private static IntPtr java_class_ref
		{
			get
			{
				return IEncodedDestinationInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000FA RID: 250 RVA: 0x00003BF4 File Offset: 0x00001DF4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IEncodedDestinationInvoker._members;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000FB RID: 251 RVA: 0x00003BFB File Offset: 0x00001DFB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000FC RID: 252 RVA: 0x00003C03 File Offset: 0x00001E03
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IEncodedDestinationInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00003C0F File Offset: 0x00001E0F
		public static IEncodedDestination GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IEncodedDestination>(handle, transfer);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00003C18 File Offset: 0x00001E18
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IEncodedDestinationInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.datatransport.runtime.EncodedDestination'.");
			}
			return handle;
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00003C43 File Offset: 0x00001E43
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00003C74 File Offset: 0x00001E74
		public IEncodedDestinationInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IEncodedDestinationInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00003CAC File Offset: 0x00001EAC
		private static Delegate GetGetSupportedEncodingsHandler()
		{
			if (IEncodedDestinationInvoker.cb_getSupportedEncodings == null)
			{
				IEncodedDestinationInvoker.cb_getSupportedEncodings = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IEncodedDestinationInvoker.n_GetSupportedEncodings));
			}
			return IEncodedDestinationInvoker.cb_getSupportedEncodings;
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00003CD0 File Offset: 0x00001ED0
		private static IntPtr n_GetSupportedEncodings(IntPtr jnienv, IntPtr native__this)
		{
			return JavaSet<Encoding>.ToLocalJniHandle(Java.Lang.Object.GetObject<IEncodedDestination>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SupportedEncodings);
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000103 RID: 259 RVA: 0x00003CE4 File Offset: 0x00001EE4
		public ICollection<Encoding> SupportedEncodings
		{
			get
			{
				if (this.id_getSupportedEncodings == IntPtr.Zero)
				{
					this.id_getSupportedEncodings = JNIEnv.GetMethodID(this.class_ref, "getSupportedEncodings", "()Ljava/util/Set;");
				}
				return JavaSet<Encoding>.FromJniHandle(JNIEnv.CallObjectMethod(base.Handle, this.id_getSupportedEncodings), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00003D35 File Offset: 0x00001F35
		private static Delegate GetGetNameHandler()
		{
			if (IEncodedDestinationInvoker.cb_getName == null)
			{
				IEncodedDestinationInvoker.cb_getName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IEncodedDestinationInvoker.n_GetName));
			}
			return IEncodedDestinationInvoker.cb_getName;
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00003D59 File Offset: 0x00001F59
		private static IntPtr n_GetName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IEncodedDestination>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Name);
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000106 RID: 262 RVA: 0x00003D70 File Offset: 0x00001F70
		public string Name
		{
			get
			{
				if (this.id_getName == IntPtr.Zero)
				{
					this.id_getName = JNIEnv.GetMethodID(this.class_ref, "getName", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_getName), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00003DC1 File Offset: 0x00001FC1
		private static Delegate GetGetExtrasHandler()
		{
			if (IEncodedDestinationInvoker.cb_getExtras == null)
			{
				IEncodedDestinationInvoker.cb_getExtras = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IEncodedDestinationInvoker.n_GetExtras));
			}
			return IEncodedDestinationInvoker.cb_getExtras;
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00003DE5 File Offset: 0x00001FE5
		private static IntPtr n_GetExtras(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray(Java.Lang.Object.GetObject<IEncodedDestination>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetExtras());
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00003DFC File Offset: 0x00001FFC
		public byte[] GetExtras()
		{
			if (this.id_getExtras == IntPtr.Zero)
			{
				this.id_getExtras = JNIEnv.GetMethodID(this.class_ref, "getExtras", "()[B");
			}
			return (byte[])JNIEnv.GetArray(JNIEnv.CallObjectMethod(base.Handle, this.id_getExtras), JniHandleOwnership.TransferLocalRef, typeof(byte));
		}

		// Token: 0x0400002F RID: 47
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/EncodedDestination", typeof(IEncodedDestinationInvoker));

		// Token: 0x04000030 RID: 48
		private IntPtr class_ref;

		// Token: 0x04000031 RID: 49
		private static Delegate cb_getSupportedEncodings;

		// Token: 0x04000032 RID: 50
		private IntPtr id_getSupportedEncodings;

		// Token: 0x04000033 RID: 51
		private static Delegate cb_getName;

		// Token: 0x04000034 RID: 52
		private IntPtr id_getName;

		// Token: 0x04000035 RID: 53
		private static Delegate cb_getExtras;

		// Token: 0x04000036 RID: 54
		private IntPtr id_getExtras;
	}
}
