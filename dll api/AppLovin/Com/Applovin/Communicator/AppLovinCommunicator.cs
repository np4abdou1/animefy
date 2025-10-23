using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Communicator
{
	// Token: 0x02000172 RID: 370
	[Register("com/applovin/communicator/AppLovinCommunicator", DoNotGenerateAcw = true)]
	public sealed class AppLovinCommunicator : Java.Lang.Object
	{
		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x060011CE RID: 4558 RVA: 0x00033398 File Offset: 0x00031598
		internal static IntPtr class_ref
		{
			get
			{
				return AppLovinCommunicator._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x060011CF RID: 4559 RVA: 0x000333BC File Offset: 0x000315BC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AppLovinCommunicator._members;
			}
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x060011D0 RID: 4560 RVA: 0x000333C4 File Offset: 0x000315C4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AppLovinCommunicator._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x060011D1 RID: 4561 RVA: 0x000333E8 File Offset: 0x000315E8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AppLovinCommunicator._members.ManagedPeerType;
			}
		}

		// Token: 0x060011D2 RID: 4562 RVA: 0x000021F0 File Offset: 0x000003F0
		internal AppLovinCommunicator(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x060011D3 RID: 4563 RVA: 0x000333F4 File Offset: 0x000315F4
		public IAppLovinCommunicatorMessagingService MessagingService
		{
			[Register("getMessagingService", "()Lcom/applovin/communicator/AppLovinCommunicatorMessagingService;", "")]
			get
			{
				return Java.Lang.Object.GetObject<IAppLovinCommunicatorMessagingService>(AppLovinCommunicator._members.InstanceMethods.InvokeAbstractObjectMethod("getMessagingService.()Lcom/applovin/communicator/AppLovinCommunicatorMessagingService;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060011D4 RID: 4564 RVA: 0x00033428 File Offset: 0x00031628
		[Register("getInstance", "(Landroid/content/Context;)Lcom/applovin/communicator/AppLovinCommunicator;", "")]
		public unsafe static AppLovinCommunicator GetInstance(Context p0)
		{
			AppLovinCommunicator @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				@object = Java.Lang.Object.GetObject<AppLovinCommunicator>(AppLovinCommunicator._members.StaticMethods.InvokeObjectMethod("getInstance.(Landroid/content/Context;)Lcom/applovin/communicator/AppLovinCommunicator;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return @object;
		}

		// Token: 0x060011D5 RID: 4565 RVA: 0x0003349C File Offset: 0x0003169C
		[Register("hasSubscriber", "(Ljava/lang/String;)Z", "")]
		public unsafe bool HasSubscriber(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = AppLovinCommunicator._members.InstanceMethods.InvokeAbstractBooleanMethod("hasSubscriber.(Ljava/lang/String;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x060011D6 RID: 4566 RVA: 0x000334FC File Offset: 0x000316FC
		[Register("respondsToTopic", "(Ljava/lang/String;)Z", "")]
		public unsafe bool RespondsToTopic(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = AppLovinCommunicator._members.InstanceMethods.InvokeAbstractBooleanMethod("respondsToTopic.(Ljava/lang/String;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x060011D7 RID: 4567 RVA: 0x0003355C File Offset: 0x0003175C
		[Register("subscribe", "(Lcom/applovin/communicator/AppLovinCommunicatorSubscriber;Ljava/lang/String;)V", "")]
		public unsafe void Subscribe(IAppLovinCommunicatorSubscriber p0, string p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p1);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				AppLovinCommunicator._members.InstanceMethods.InvokeAbstractVoidMethod("subscribe.(Lcom/applovin/communicator/AppLovinCommunicatorSubscriber;Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x060011D8 RID: 4568 RVA: 0x000335E4 File Offset: 0x000317E4
		[Register("subscribe", "(Lcom/applovin/communicator/AppLovinCommunicatorSubscriber;Ljava/util/List;)V", "")]
		public unsafe void Subscribe(IAppLovinCommunicatorSubscriber p0, IList<string> p1)
		{
			IntPtr intPtr = JavaList<string>.ToLocalJniHandle(p1);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				AppLovinCommunicator._members.InstanceMethods.InvokeAbstractVoidMethod("subscribe.(Lcom/applovin/communicator/AppLovinCommunicatorSubscriber;Ljava/util/List;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x060011D9 RID: 4569 RVA: 0x00033674 File Offset: 0x00031874
		[Register("unsubscribe", "(Lcom/applovin/communicator/AppLovinCommunicatorSubscriber;Ljava/lang/String;)V", "")]
		public unsafe void Unsubscribe(IAppLovinCommunicatorSubscriber p0, string p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p1);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				AppLovinCommunicator._members.InstanceMethods.InvokeAbstractVoidMethod("unsubscribe.(Lcom/applovin/communicator/AppLovinCommunicatorSubscriber;Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x060011DA RID: 4570 RVA: 0x000336FC File Offset: 0x000318FC
		[Register("unsubscribe", "(Lcom/applovin/communicator/AppLovinCommunicatorSubscriber;Ljava/util/List;)V", "")]
		public unsafe void Unsubscribe(IAppLovinCommunicatorSubscriber p0, IList<string> p1)
		{
			IntPtr intPtr = JavaList<string>.ToLocalJniHandle(p1);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				AppLovinCommunicator._members.InstanceMethods.InvokeAbstractVoidMethod("unsubscribe.(Lcom/applovin/communicator/AppLovinCommunicatorSubscriber;Ljava/util/List;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x040005D5 RID: 1493
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/communicator/AppLovinCommunicator", typeof(AppLovinCommunicator));
	}
}
