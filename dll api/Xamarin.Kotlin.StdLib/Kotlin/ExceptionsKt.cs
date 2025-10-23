using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin
{
	// Token: 0x0200004E RID: 78
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/ExceptionsKt", DoNotGenerateAcw = true)]
	public sealed class ExceptionsKt : Java.Lang.Object
	{
		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000149 RID: 329 RVA: 0x00003040 File Offset: 0x00001240
		internal static IntPtr class_ref
		{
			get
			{
				return ExceptionsKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600014A RID: 330 RVA: 0x00003064 File Offset: 0x00001264
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ExceptionsKt._members;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600014B RID: 331 RVA: 0x0000306C File Offset: 0x0000126C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ExceptionsKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600014C RID: 332 RVA: 0x00003090 File Offset: 0x00001290
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ExceptionsKt._members.ManagedPeerType;
			}
		}

		// Token: 0x0600014D RID: 333 RVA: 0x0000309C File Offset: 0x0000129C
		internal ExceptionsKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600014E RID: 334 RVA: 0x000030A8 File Offset: 0x000012A8
		[Register("addSuppressed", "(Ljava/lang/Throwable;Ljava/lang/Throwable;)V", "")]
		public unsafe static void AddSuppressed(Throwable _this_addSuppressed, Throwable exception)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_addSuppressed == null) ? IntPtr.Zero : _this_addSuppressed.Handle);
				ptr[1] = new JniArgumentValue((exception == null) ? IntPtr.Zero : exception.Handle);
				ExceptionsKt._members.StaticMethods.InvokeVoidMethod("addSuppressed.(Ljava/lang/Throwable;Ljava/lang/Throwable;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_addSuppressed);
				GC.KeepAlive(exception);
			}
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00003134 File Offset: 0x00001334
		[Register("getStackTrace", "(Ljava/lang/Throwable;)[Ljava/lang/StackTraceElement;", "")]
		public unsafe static StackTraceElement[] GetStackTrace(Throwable _this_stackTrace)
		{
			StackTraceElement[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_stackTrace == null) ? IntPtr.Zero : _this_stackTrace.Handle);
				result = (StackTraceElement[])JNIEnv.GetArray(ExceptionsKt._members.StaticMethods.InvokeObjectMethod("getStackTrace.(Ljava/lang/Throwable;)[Ljava/lang/StackTraceElement;", ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(StackTraceElement));
			}
			finally
			{
				GC.KeepAlive(_this_stackTrace);
			}
			return result;
		}

		// Token: 0x06000150 RID: 336 RVA: 0x000031B8 File Offset: 0x000013B8
		[Register("getSuppressedExceptions", "(Ljava/lang/Throwable;)Ljava/util/List;", "")]
		public unsafe static IList<Throwable> GetSuppressedExceptions(Throwable _this_suppressedExceptions)
		{
			IList<Throwable> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_suppressedExceptions == null) ? IntPtr.Zero : _this_suppressedExceptions.Handle);
				result = JavaList<Throwable>.FromJniHandle(ExceptionsKt._members.StaticMethods.InvokeObjectMethod("getSuppressedExceptions.(Ljava/lang/Throwable;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_suppressedExceptions);
			}
			return result;
		}

		// Token: 0x06000151 RID: 337 RVA: 0x0000322C File Offset: 0x0000142C
		[Register("stackTraceToString", "(Ljava/lang/Throwable;)Ljava/lang/String;", "")]
		public unsafe static string StackTraceToString(Throwable _this_stackTraceToString)
		{
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_stackTraceToString == null) ? IntPtr.Zero : _this_stackTraceToString.Handle);
				@string = JNIEnv.GetString(ExceptionsKt._members.StaticMethods.InvokeObjectMethod("stackTraceToString.(Ljava/lang/Throwable;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_stackTraceToString);
			}
			return @string;
		}

		// Token: 0x0400001E RID: 30
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/ExceptionsKt", typeof(ExceptionsKt));
	}
}
