using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util.Concurrent;

namespace Xamarin.KotlinX.Coroutines
{
	// Token: 0x02000034 RID: 52
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/ExceptionsKt", DoNotGenerateAcw = true)]
	public sealed class ExceptionsKt : Java.Lang.Object
	{
		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600013C RID: 316 RVA: 0x00004F20 File Offset: 0x00003120
		internal static IntPtr class_ref
		{
			get
			{
				return ExceptionsKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600013D RID: 317 RVA: 0x00004F44 File Offset: 0x00003144
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ExceptionsKt._members;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x0600013E RID: 318 RVA: 0x00004F4C File Offset: 0x0000314C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ExceptionsKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x0600013F RID: 319 RVA: 0x00004F70 File Offset: 0x00003170
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ExceptionsKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00004F7C File Offset: 0x0000317C
		internal ExceptionsKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00004F88 File Offset: 0x00003188
		[NullableContext(2)]
		[Register("CancellationException", "(Ljava/lang/String;Ljava/lang/Throwable;)Ljava/util/concurrent/CancellationException;", "")]
		[return: Nullable(1)]
		public unsafe static CancellationException CancellationException(string message, Throwable cause)
		{
			IntPtr intPtr = JNIEnv.NewString(message);
			CancellationException @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((cause == null) ? IntPtr.Zero : cause.Handle);
				@object = Java.Lang.Object.GetObject<CancellationException>(ExceptionsKt._members.StaticMethods.InvokeObjectMethod("CancellationException.(Ljava/lang/String;Ljava/lang/Throwable;)Ljava/util/concurrent/CancellationException;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(cause);
			}
			return @object;
		}

		// Token: 0x0400002A RID: 42
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/ExceptionsKt", typeof(ExceptionsKt));
	}
}
