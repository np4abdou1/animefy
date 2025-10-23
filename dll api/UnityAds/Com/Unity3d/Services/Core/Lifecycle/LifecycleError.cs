using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Lifecycle
{
	// Token: 0x020000F8 RID: 248
	[Register("com/unity3d/services/core/lifecycle/LifecycleError", DoNotGenerateAcw = true)]
	public sealed class LifecycleError : Java.Lang.Enum
	{
		// Token: 0x1700030E RID: 782
		// (get) Token: 0x060009CB RID: 2507 RVA: 0x0001C824 File Offset: 0x0001AA24
		[Register("APPLICATION_NULL")]
		public static LifecycleError ApplicationNull
		{
			get
			{
				return Java.Lang.Object.GetObject<LifecycleError>(LifecycleError._members.StaticFields.GetObjectValue("APPLICATION_NULL.Lcom/unity3d/services/core/lifecycle/LifecycleError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x060009CC RID: 2508 RVA: 0x0001C854 File Offset: 0x0001AA54
		[Register("JSON_ERROR")]
		public static LifecycleError JsonError
		{
			get
			{
				return Java.Lang.Object.GetObject<LifecycleError>(LifecycleError._members.StaticFields.GetObjectValue("JSON_ERROR.Lcom/unity3d/services/core/lifecycle/LifecycleError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x060009CD RID: 2509 RVA: 0x0001C884 File Offset: 0x0001AA84
		[Register("LISTENER_NOT_NULL")]
		public static LifecycleError ListenerNotNull
		{
			get
			{
				return Java.Lang.Object.GetObject<LifecycleError>(LifecycleError._members.StaticFields.GetObjectValue("LISTENER_NOT_NULL.Lcom/unity3d/services/core/lifecycle/LifecycleError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x060009CE RID: 2510 RVA: 0x0001C8B4 File Offset: 0x0001AAB4
		internal static IntPtr class_ref
		{
			get
			{
				return LifecycleError._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x060009CF RID: 2511 RVA: 0x0001C8D8 File Offset: 0x0001AAD8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return LifecycleError._members;
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x060009D0 RID: 2512 RVA: 0x0001C8E0 File Offset: 0x0001AAE0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return LifecycleError._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x060009D1 RID: 2513 RVA: 0x0001C904 File Offset: 0x0001AB04
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return LifecycleError._members.ManagedPeerType;
			}
		}

		// Token: 0x060009D2 RID: 2514 RVA: 0x0000256C File Offset: 0x0000076C
		internal LifecycleError(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x0001C910 File Offset: 0x0001AB10
		[Register("valueOf", "(Ljava/lang/String;)Lcom/unity3d/services/core/lifecycle/LifecycleError;", "")]
		public unsafe static LifecycleError ValueOf(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			LifecycleError @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<LifecycleError>(LifecycleError._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/unity3d/services/core/lifecycle/LifecycleError;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x0001C97C File Offset: 0x0001AB7C
		[Register("values", "()[Lcom/unity3d/services/core/lifecycle/LifecycleError;", "")]
		public static LifecycleError[] Values()
		{
			return (LifecycleError[])JNIEnv.GetArray(LifecycleError._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/unity3d/services/core/lifecycle/LifecycleError;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(LifecycleError));
		}

		// Token: 0x04000257 RID: 599
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/lifecycle/LifecycleError", typeof(LifecycleError));
	}
}
