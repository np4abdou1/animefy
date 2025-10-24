using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Xamarin.Google.Android.DataTransport.Runtime.Firebase.Transport;

namespace Xamarin.Google.Android.DataTransport.Runtime
{
	// Token: 0x02000026 RID: 38
	[Register("com/google/android/datatransport/runtime/ProtoEncoderDoNotUse", DoNotGenerateAcw = true)]
	public abstract class ProtoEncoderDoNotUse : Java.Lang.Object
	{
		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600010B RID: 267 RVA: 0x00003E78 File Offset: 0x00002078
		internal static IntPtr class_ref
		{
			get
			{
				return ProtoEncoderDoNotUse._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600010C RID: 268 RVA: 0x00003E9C File Offset: 0x0000209C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ProtoEncoderDoNotUse._members;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x0600010D RID: 269 RVA: 0x00003EA4 File Offset: 0x000020A4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ProtoEncoderDoNotUse._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600010E RID: 270 RVA: 0x00003EC8 File Offset: 0x000020C8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ProtoEncoderDoNotUse._members.ManagedPeerType;
			}
		}

		// Token: 0x0600010F RID: 271 RVA: 0x000026C4 File Offset: 0x000008C4
		protected ProtoEncoderDoNotUse(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00003ED4 File Offset: 0x000020D4
		private static Delegate GetGetClientMetricsHandler()
		{
			if (ProtoEncoderDoNotUse.cb_getClientMetrics == null)
			{
				ProtoEncoderDoNotUse.cb_getClientMetrics = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ProtoEncoderDoNotUse.n_GetClientMetrics));
			}
			return ProtoEncoderDoNotUse.cb_getClientMetrics;
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00003EF8 File Offset: 0x000020F8
		private static IntPtr n_GetClientMetrics(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ProtoEncoderDoNotUse>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ClientMetrics);
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000112 RID: 274
		public abstract ClientMetrics ClientMetrics { [Register("getClientMetrics", "()Lcom/google/android/datatransport/runtime/firebase/transport/ClientMetrics;", "GetGetClientMetricsHandler")] get; }

		// Token: 0x06000113 RID: 275 RVA: 0x00003F0C File Offset: 0x0000210C
		[Register("encode", "(Ljava/lang/Object;)[B", "")]
		public unsafe static byte[] Encode(Java.Lang.Object value)
		{
			byte[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
				result = (byte[])JNIEnv.GetArray(ProtoEncoderDoNotUse._members.StaticMethods.InvokeObjectMethod("encode.(Ljava/lang/Object;)[B", ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(byte));
			}
			finally
			{
				GC.KeepAlive(value);
			}
			return result;
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00003F90 File Offset: 0x00002190
		[Register("encode", "(Ljava/lang/Object;Ljava/io/OutputStream;)V", "")]
		public unsafe static void Encode(Java.Lang.Object value, Stream output)
		{
			IntPtr intPtr = OutputStreamAdapter.ToLocalJniHandle(output);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ProtoEncoderDoNotUse._members.StaticMethods.InvokeVoidMethod("encode.(Ljava/lang/Object;Ljava/io/OutputStream;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(value);
				GC.KeepAlive(output);
			}
		}

		// Token: 0x04000037 RID: 55
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/ProtoEncoderDoNotUse", typeof(ProtoEncoderDoNotUse));

		// Token: 0x04000038 RID: 56
		private static Delegate cb_getClientMetrics;
	}
}
