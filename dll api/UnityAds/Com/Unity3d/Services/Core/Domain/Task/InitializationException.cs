using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.Configuration;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Domain.Task
{
	// Token: 0x02000108 RID: 264
	[Register("com/unity3d/services/core/domain/task/InitializationException", DoNotGenerateAcw = true)]
	public sealed class InitializationException : Java.Lang.Exception
	{
		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06000A50 RID: 2640 RVA: 0x0001DBE0 File Offset: 0x0001BDE0
		internal static IntPtr class_ref
		{
			get
			{
				return InitializationException._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06000A51 RID: 2641 RVA: 0x0001DC04 File Offset: 0x0001BE04
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return InitializationException._members;
			}
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x06000A52 RID: 2642 RVA: 0x0001DC0C File Offset: 0x0001BE0C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return InitializationException._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06000A53 RID: 2643 RVA: 0x0001DC30 File Offset: 0x0001BE30
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return InitializationException._members.ManagedPeerType;
			}
		}

		// Token: 0x06000A54 RID: 2644 RVA: 0x000111D0 File Offset: 0x0000F3D0
		internal InitializationException(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x0001DC3C File Offset: 0x0001BE3C
		[Register(".ctor", "(Lcom/unity3d/services/core/configuration/ErrorState;Ljava/lang/Exception;Lcom/unity3d/services/core/configuration/Configuration;)V", "")]
		public unsafe InitializationException(ErrorState errorState, Java.Lang.Exception originalException, Configuration config) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((errorState == null) ? IntPtr.Zero : errorState.Handle);
				ptr[1] = new JniArgumentValue((originalException == null) ? IntPtr.Zero : originalException.Handle);
				ptr[2] = new JniArgumentValue((config == null) ? IntPtr.Zero : config.Handle);
				base.SetHandle(InitializationException._members.InstanceMethods.StartCreateInstance("(Lcom/unity3d/services/core/configuration/ErrorState;Ljava/lang/Exception;Lcom/unity3d/services/core/configuration/Configuration;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				InitializationException._members.InstanceMethods.FinishCreateInstance("(Lcom/unity3d/services/core/configuration/ErrorState;Ljava/lang/Exception;Lcom/unity3d/services/core/configuration/Configuration;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(errorState);
				GC.KeepAlive(originalException);
				GC.KeepAlive(config);
			}
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06000A56 RID: 2646 RVA: 0x0001DD3C File Offset: 0x0001BF3C
		public Configuration Config
		{
			[Register("getConfig", "()Lcom/unity3d/services/core/configuration/Configuration;", "")]
			get
			{
				return Java.Lang.Object.GetObject<Configuration>(InitializationException._members.InstanceMethods.InvokeNonvirtualObjectMethod("getConfig.()Lcom/unity3d/services/core/configuration/Configuration;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06000A57 RID: 2647 RVA: 0x0001DD70 File Offset: 0x0001BF70
		public ErrorState ErrorState
		{
			[Register("getErrorState", "()Lcom/unity3d/services/core/configuration/ErrorState;", "")]
			get
			{
				return Java.Lang.Object.GetObject<ErrorState>(InitializationException._members.InstanceMethods.InvokeNonvirtualObjectMethod("getErrorState.()Lcom/unity3d/services/core/configuration/ErrorState;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06000A58 RID: 2648 RVA: 0x0001DDA4 File Offset: 0x0001BFA4
		public Java.Lang.Exception OriginalException
		{
			[Register("getOriginalException", "()Ljava/lang/Exception;", "")]
			get
			{
				return Java.Lang.Object.GetObject<Java.Lang.Exception>(InitializationException._members.InstanceMethods.InvokeNonvirtualObjectMethod("getOriginalException.()Ljava/lang/Exception;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000A59 RID: 2649 RVA: 0x0001DDD8 File Offset: 0x0001BFD8
		[Register("component1", "()Lcom/unity3d/services/core/configuration/ErrorState;", "")]
		public ErrorState Component1()
		{
			return Java.Lang.Object.GetObject<ErrorState>(InitializationException._members.InstanceMethods.InvokeNonvirtualObjectMethod("component1.()Lcom/unity3d/services/core/configuration/ErrorState;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x0001DE0C File Offset: 0x0001C00C
		[Register("component2", "()Ljava/lang/Exception;", "")]
		public Java.Lang.Exception Component2()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Exception>(InitializationException._members.InstanceMethods.InvokeNonvirtualObjectMethod("component2.()Ljava/lang/Exception;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000A5B RID: 2651 RVA: 0x0001DE40 File Offset: 0x0001C040
		[Register("component3", "()Lcom/unity3d/services/core/configuration/Configuration;", "")]
		public Configuration Component3()
		{
			return Java.Lang.Object.GetObject<Configuration>(InitializationException._members.InstanceMethods.InvokeNonvirtualObjectMethod("component3.()Lcom/unity3d/services/core/configuration/Configuration;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000A5C RID: 2652 RVA: 0x0001DE74 File Offset: 0x0001C074
		[Register("copy", "(Lcom/unity3d/services/core/configuration/ErrorState;Ljava/lang/Exception;Lcom/unity3d/services/core/configuration/Configuration;)Lcom/unity3d/services/core/domain/task/InitializationException;", "")]
		public unsafe InitializationException Copy(ErrorState errorState, Java.Lang.Exception originalException, Configuration config)
		{
			InitializationException @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((errorState == null) ? IntPtr.Zero : errorState.Handle);
				ptr[1] = new JniArgumentValue((originalException == null) ? IntPtr.Zero : originalException.Handle);
				ptr[2] = new JniArgumentValue((config == null) ? IntPtr.Zero : config.Handle);
				@object = Java.Lang.Object.GetObject<InitializationException>(InitializationException._members.InstanceMethods.InvokeNonvirtualObjectMethod("copy.(Lcom/unity3d/services/core/configuration/ErrorState;Ljava/lang/Exception;Lcom/unity3d/services/core/configuration/Configuration;)Lcom/unity3d/services/core/domain/task/InitializationException;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(errorState);
				GC.KeepAlive(originalException);
				GC.KeepAlive(config);
			}
			return @object;
		}

		// Token: 0x06000A5D RID: 2653 RVA: 0x0001DF3C File Offset: 0x0001C13C
		[Register("equals", "(Ljava/lang/Object;)Z", "")]
		public unsafe bool Equals(Java.Lang.Object other)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((other == null) ? IntPtr.Zero : other.Handle);
				result = InitializationException._members.InstanceMethods.InvokeAbstractBooleanMethod("equals.(Ljava/lang/Object;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(other);
			}
			return result;
		}

		// Token: 0x06000A5E RID: 2654 RVA: 0x0001DFA4 File Offset: 0x0001C1A4
		[Register("hashCode", "()I", "")]
		public override int GetHashCode()
		{
			return InitializationException._members.InstanceMethods.InvokeAbstractInt32Method("hashCode.()I", this, null);
		}

		// Token: 0x06000A5F RID: 2655 RVA: 0x0001DFC0 File Offset: 0x0001C1C0
		[Register("toString", "()Ljava/lang/String;", "")]
		public override string ToString()
		{
			return JNIEnv.GetString(InitializationException._members.InstanceMethods.InvokeAbstractObjectMethod("toString.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000270 RID: 624
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/domain/task/InitializationException", typeof(InitializationException));
	}
}
