using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Runtime.Logging
{
	// Token: 0x02000075 RID: 117
	[Register("com/google/android/datatransport/runtime/logging/Logging", DoNotGenerateAcw = true)]
	public sealed class Logging : Java.Lang.Object
	{
		// Token: 0x17000140 RID: 320
		// (get) Token: 0x0600042D RID: 1069 RVA: 0x0000D22C File Offset: 0x0000B42C
		internal static IntPtr class_ref
		{
			get
			{
				return Logging._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x0600042E RID: 1070 RVA: 0x0000D250 File Offset: 0x0000B450
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Logging._members;
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x0600042F RID: 1071 RVA: 0x0000D258 File Offset: 0x0000B458
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Logging._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000430 RID: 1072 RVA: 0x0000D27C File Offset: 0x0000B47C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Logging._members.ManagedPeerType;
			}
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x000026C4 File Offset: 0x000008C4
		internal Logging(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x0000D288 File Offset: 0x0000B488
		[Register("d", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe static void D(string tag, string message)
		{
			IntPtr intPtr = JNIEnv.NewString(tag);
			IntPtr intPtr2 = JNIEnv.NewString(message);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				Logging._members.StaticMethods.InvokeVoidMethod("d.(Ljava/lang/String;Ljava/lang/String;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x0000D304 File Offset: 0x0000B504
		[Register("d", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)V", "")]
		public unsafe static void D(string tag, string message, Java.Lang.Object arg1)
		{
			IntPtr intPtr = JNIEnv.NewString(tag);
			IntPtr intPtr2 = JNIEnv.NewString(message);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((arg1 == null) ? IntPtr.Zero : arg1.Handle);
				Logging._members.StaticMethods.InvokeVoidMethod("d.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(arg1);
			}
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x0000D3AC File Offset: 0x0000B5AC
		[Register("d", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V", "")]
		public unsafe static void D(string tag, string message, Java.Lang.Object arg1, Java.Lang.Object arg2)
		{
			IntPtr intPtr = JNIEnv.NewString(tag);
			IntPtr intPtr2 = JNIEnv.NewString(message);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((arg1 == null) ? IntPtr.Zero : arg1.Handle);
				ptr[3] = new JniArgumentValue((arg2 == null) ? IntPtr.Zero : arg2.Handle);
				Logging._members.StaticMethods.InvokeVoidMethod("d.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(arg1);
				GC.KeepAlive(arg2);
			}
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x0000D47C File Offset: 0x0000B67C
		[Register("d", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public unsafe static void D(string tag, string message, params Java.Lang.Object[] args)
		{
			IntPtr intPtr = JNIEnv.NewString(tag);
			IntPtr intPtr2 = JNIEnv.NewString(message);
			IntPtr intPtr3 = JNIEnv.NewArray<Java.Lang.Object>(args);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				Logging._members.StaticMethods.InvokeVoidMethod("d.(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				if (args != null)
				{
					JNIEnv.CopyArray<Java.Lang.Object>(intPtr3, args);
					JNIEnv.DeleteLocalRef(intPtr3);
				}
				GC.KeepAlive(args);
			}
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x0000D52C File Offset: 0x0000B72C
		[Register("e", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public unsafe static void E(string tag, string message, Throwable e)
		{
			IntPtr intPtr = JNIEnv.NewString(tag);
			IntPtr intPtr2 = JNIEnv.NewString(message);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((e == null) ? IntPtr.Zero : e.Handle);
				Logging._members.StaticMethods.InvokeVoidMethod("e.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(e);
			}
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x0000D5D4 File Offset: 0x0000B7D4
		[Register("i", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)V", "")]
		public unsafe static void I(string tag, string message, Java.Lang.Object arg1)
		{
			IntPtr intPtr = JNIEnv.NewString(tag);
			IntPtr intPtr2 = JNIEnv.NewString(message);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((arg1 == null) ? IntPtr.Zero : arg1.Handle);
				Logging._members.StaticMethods.InvokeVoidMethod("i.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(arg1);
			}
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x0000D67C File Offset: 0x0000B87C
		[Register("w", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)V", "")]
		public unsafe static void W(string tag, string message, Java.Lang.Object arg1)
		{
			IntPtr intPtr = JNIEnv.NewString(tag);
			IntPtr intPtr2 = JNIEnv.NewString(message);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((arg1 == null) ? IntPtr.Zero : arg1.Handle);
				Logging._members.StaticMethods.InvokeVoidMethod("w.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(arg1);
			}
		}

		// Token: 0x040000F9 RID: 249
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/logging/Logging", typeof(Logging));
	}
}
