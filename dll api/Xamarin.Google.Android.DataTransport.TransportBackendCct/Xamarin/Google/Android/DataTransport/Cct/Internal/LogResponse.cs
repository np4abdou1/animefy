using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Cct.Internal
{
	// Token: 0x0200001E RID: 30
	[Register("com/google/android/datatransport/cct/internal/LogResponse", DoNotGenerateAcw = true)]
	public abstract class LogResponse : Java.Lang.Object
	{
		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000195 RID: 405 RVA: 0x00005340 File Offset: 0x00003540
		internal static IntPtr class_ref
		{
			get
			{
				return LogResponse._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000196 RID: 406 RVA: 0x00005364 File Offset: 0x00003564
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return LogResponse._members;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000197 RID: 407 RVA: 0x0000536C File Offset: 0x0000356C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return LogResponse._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000198 RID: 408 RVA: 0x00005390 File Offset: 0x00003590
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return LogResponse._members.ManagedPeerType;
			}
		}

		// Token: 0x06000199 RID: 409 RVA: 0x000020B4 File Offset: 0x000002B4
		protected LogResponse(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600019A RID: 410 RVA: 0x0000539C File Offset: 0x0000359C
		[Register(".ctor", "()V", "")]
		public LogResponse() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(LogResponse._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			LogResponse._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0000540A File Offset: 0x0000360A
		private static Delegate GetGetNextRequestWaitMillisHandler()
		{
			if (LogResponse.cb_getNextRequestWaitMillis == null)
			{
				LogResponse.cb_getNextRequestWaitMillis = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(LogResponse.n_GetNextRequestWaitMillis));
			}
			return LogResponse.cb_getNextRequestWaitMillis;
		}

		// Token: 0x0600019C RID: 412 RVA: 0x0000542E File Offset: 0x0000362E
		private static long n_GetNextRequestWaitMillis(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<LogResponse>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NextRequestWaitMillis;
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600019D RID: 413
		public abstract long NextRequestWaitMillis { [Register("getNextRequestWaitMillis", "()J", "GetGetNextRequestWaitMillisHandler")] get; }

		// Token: 0x0600019E RID: 414 RVA: 0x00005440 File Offset: 0x00003640
		[Register("fromJson", "(Ljava/io/Reader;)Lcom/google/android/datatransport/cct/internal/LogResponse;", "")]
		public unsafe static LogResponse FromJson(Reader reader)
		{
			LogResponse @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((reader == null) ? IntPtr.Zero : reader.Handle);
				@object = Java.Lang.Object.GetObject<LogResponse>(LogResponse._members.StaticMethods.InvokeObjectMethod("fromJson.(Ljava/io/Reader;)Lcom/google/android/datatransport/cct/internal/LogResponse;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(reader);
			}
			return @object;
		}

		// Token: 0x04000053 RID: 83
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/cct/internal/LogResponse", typeof(LogResponse));

		// Token: 0x04000054 RID: 84
		private static Delegate cb_getNextRequestWaitMillis;
	}
}
