using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Runtime.Dagger.Internal
{
	// Token: 0x020000F0 RID: 240
	[Register("com/google/android/datatransport/runtime/dagger/internal/Preconditions", DoNotGenerateAcw = true)]
	public sealed class Preconditions : Java.Lang.Object
	{
		// Token: 0x1700028B RID: 651
		// (get) Token: 0x0600087B RID: 2171 RVA: 0x00017770 File Offset: 0x00015970
		internal static IntPtr class_ref
		{
			get
			{
				return Preconditions._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x0600087C RID: 2172 RVA: 0x00017794 File Offset: 0x00015994
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Preconditions._members;
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x0600087D RID: 2173 RVA: 0x0001779C File Offset: 0x0001599C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Preconditions._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x0600087E RID: 2174 RVA: 0x000177C0 File Offset: 0x000159C0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Preconditions._members.ManagedPeerType;
			}
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x000026C4 File Offset: 0x000008C4
		internal Preconditions(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x000177CC File Offset: 0x000159CC
		[Register("checkBuilderRequirement", "(Ljava/lang/Object;Ljava/lang/Class;)V", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static void CheckBuilderRequirement(Java.Lang.Object requirement, Class clazz)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(requirement);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((clazz == null) ? IntPtr.Zero : clazz.Handle);
				Preconditions._members.StaticMethods.InvokeVoidMethod("checkBuilderRequirement.(Ljava/lang/Object;Ljava/lang/Class;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(requirement);
				GC.KeepAlive(clazz);
			}
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x00017854 File Offset: 0x00015A54
		[Register("checkNotNull", "(Ljava/lang/Object;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static Java.Lang.Object CheckNotNull(Java.Lang.Object reference)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(reference);
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
				GC.KeepAlive(reference);
			}
			return @object;
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x000178C4 File Offset: 0x00015AC4
		[Register("checkNotNull", "(Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static Java.Lang.Object CheckNotNull(Java.Lang.Object reference, string errorMessage)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(reference);
			IntPtr intPtr2 = JNIEnv.NewString(errorMessage);
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
				GC.KeepAlive(reference);
			}
			return @object;
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x00017958 File Offset: 0x00015B58
		[Register("checkNotNull", "(Ljava/lang/Object;Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static Java.Lang.Object CheckNotNull(Java.Lang.Object reference, string errorMessageTemplate, Java.Lang.Object errorMessageArg)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(reference);
			IntPtr intPtr2 = JNIEnv.NewString(errorMessageTemplate);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((errorMessageArg == null) ? IntPtr.Zero : errorMessageArg.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(Preconditions._members.StaticMethods.InvokeObjectMethod("checkNotNull.(Ljava/lang/Object;Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(reference);
				GC.KeepAlive(errorMessageArg);
			}
			return @object;
		}

		// Token: 0x04000265 RID: 613
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/dagger/internal/Preconditions", typeof(Preconditions));
	}
}
