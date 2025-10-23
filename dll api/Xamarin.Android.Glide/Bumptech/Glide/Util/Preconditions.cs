using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Util
{
	// Token: 0x02000052 RID: 82
	[Register("com/bumptech/glide/util/Preconditions", DoNotGenerateAcw = true)]
	public sealed class Preconditions : Java.Lang.Object
	{
		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060003B0 RID: 944 RVA: 0x0000C680 File Offset: 0x0000A880
		internal static IntPtr class_ref
		{
			get
			{
				return Preconditions._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060003B1 RID: 945 RVA: 0x0000C6A4 File Offset: 0x0000A8A4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Preconditions._members;
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060003B2 RID: 946 RVA: 0x0000C6AC File Offset: 0x0000A8AC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Preconditions._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060003B3 RID: 947 RVA: 0x0000C6D0 File Offset: 0x0000A8D0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Preconditions._members.ManagedPeerType;
			}
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x0000C6DC File Offset: 0x0000A8DC
		internal Preconditions(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x0000C6E8 File Offset: 0x0000A8E8
		[Register("checkArgument", "(ZLjava/lang/String;)V", "")]
		public unsafe static void CheckArgument(bool expression, string message)
		{
			IntPtr intPtr = JNIEnv.NewString(message);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(expression);
				ptr[1] = new JniArgumentValue(intPtr);
				Preconditions._members.StaticMethods.InvokeVoidMethod("checkArgument.(ZLjava/lang/String;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x0000C758 File Offset: 0x0000A958
		[Register("checkNotEmpty", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe static string CheckNotEmpty(string @string)
		{
			IntPtr intPtr = JNIEnv.NewString(@string);
			string string2;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				string2 = JNIEnv.GetString(Preconditions._members.StaticMethods.InvokeObjectMethod("checkNotEmpty.(Ljava/lang/String;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return string2;
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x0000C7C4 File Offset: 0x0000A9C4
		[Register("checkNotEmpty", "(Ljava/util/Collection;)Ljava/util/Collection;", "")]
		[JavaTypeParameters(new string[]
		{
			"T extends java.util.Collection<Y>",
			"Y"
		})]
		public unsafe static Java.Lang.Object CheckNotEmpty(Java.Lang.Object collection)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(collection);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(Preconditions._members.StaticMethods.InvokeObjectMethod("checkNotEmpty.(Ljava/util/Collection;)Ljava/util/Collection;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(collection);
			}
			return @object;
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x0000C834 File Offset: 0x0000AA34
		[Register("checkNotNull", "(Ljava/lang/Object;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static Java.Lang.Object CheckNotNull(Java.Lang.Object arg)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(arg);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(Preconditions._members.StaticMethods.InvokeObjectMethod("checkNotNull.(Ljava/lang/Object;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(arg);
			}
			return @object;
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x0000C8A4 File Offset: 0x0000AAA4
		[Register("checkNotNull", "(Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static Java.Lang.Object CheckNotNull(Java.Lang.Object arg, string message)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(arg);
			IntPtr intPtr2 = JNIEnv.NewString(message);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(Preconditions._members.StaticMethods.InvokeObjectMethod("checkNotNull.(Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(arg);
			}
			return @object;
		}

		// Token: 0x040000CC RID: 204
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/util/Preconditions", typeof(Preconditions));
	}
}
