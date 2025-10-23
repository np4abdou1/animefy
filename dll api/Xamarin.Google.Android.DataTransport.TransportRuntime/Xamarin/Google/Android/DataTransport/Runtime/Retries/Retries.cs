using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Runtime.Retries
{
	// Token: 0x02000065 RID: 101
	[Register("com/google/android/datatransport/runtime/retries/Retries", DoNotGenerateAcw = true)]
	public sealed class Retries : Java.Lang.Object
	{
		// Token: 0x17000106 RID: 262
		// (get) Token: 0x0600034F RID: 847 RVA: 0x0000A9E0 File Offset: 0x00008BE0
		internal static IntPtr class_ref
		{
			get
			{
				return Retries._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000350 RID: 848 RVA: 0x0000AA04 File Offset: 0x00008C04
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Retries._members;
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000351 RID: 849 RVA: 0x0000AA0C File Offset: 0x00008C0C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Retries._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000352 RID: 850 RVA: 0x0000AA30 File Offset: 0x00008C30
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Retries._members.ManagedPeerType;
			}
		}

		// Token: 0x06000353 RID: 851 RVA: 0x000026C4 File Offset: 0x000008C4
		internal Retries(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000354 RID: 852 RVA: 0x0000AA3C File Offset: 0x00008C3C
		[Register("retry", "(ILjava/lang/Object;Lcom/google/android/datatransport/runtime/retries/Function;Lcom/google/android/datatransport/runtime/retries/RetryStrategy;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"TInput",
			"TResult",
			"TException extends java.lang.Throwable"
		})]
		public unsafe static Java.Lang.Object Retry(int maxAttempts, Java.Lang.Object input, IFunction function, IRetryStrategy retryStrategy)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(input);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(maxAttempts);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((function == null) ? IntPtr.Zero : ((Java.Lang.Object)function).Handle);
				ptr[3] = new JniArgumentValue((retryStrategy == null) ? IntPtr.Zero : ((Java.Lang.Object)retryStrategy).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(Retries._members.StaticMethods.InvokeObjectMethod("retry.(ILjava/lang/Object;Lcom/google/android/datatransport/runtime/retries/Function;Lcom/google/android/datatransport/runtime/retries/RetryStrategy;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(input);
				GC.KeepAlive(function);
				GC.KeepAlive(retryStrategy);
			}
			return @object;
		}

		// Token: 0x040000BD RID: 189
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/retries/Retries", typeof(Retries));
	}
}
