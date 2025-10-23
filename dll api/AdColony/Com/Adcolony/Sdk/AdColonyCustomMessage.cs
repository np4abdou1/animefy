using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Adcolony.Sdk
{
	// Token: 0x02000042 RID: 66
	[Register("com/adcolony/sdk/AdColonyCustomMessage", DoNotGenerateAcw = true)]
	public class AdColonyCustomMessage : Java.Lang.Object
	{
		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060002FE RID: 766 RVA: 0x000099D8 File Offset: 0x00007BD8
		internal static IntPtr class_ref
		{
			get
			{
				return AdColonyCustomMessage._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060002FF RID: 767 RVA: 0x000099FC File Offset: 0x00007BFC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AdColonyCustomMessage._members;
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000300 RID: 768 RVA: 0x00009A04 File Offset: 0x00007C04
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AdColonyCustomMessage._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000301 RID: 769 RVA: 0x00009A28 File Offset: 0x00007C28
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AdColonyCustomMessage._members.ManagedPeerType;
			}
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00002128 File Offset: 0x00000328
		protected AdColonyCustomMessage(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000303 RID: 771 RVA: 0x00009A34 File Offset: 0x00007C34
		[Register(".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe AdColonyCustomMessage(string type, string message) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(type);
			IntPtr intPtr2 = JNIEnv.NewString(message);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				base.SetHandle(AdColonyCustomMessage._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;Ljava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				AdColonyCustomMessage._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
		}

		// Token: 0x06000304 RID: 772 RVA: 0x00009AF8 File Offset: 0x00007CF8
		private static Delegate GetGetMessageHandler()
		{
			if (AdColonyCustomMessage.cb_getMessage == null)
			{
				AdColonyCustomMessage.cb_getMessage = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AdColonyCustomMessage.n_GetMessage));
			}
			return AdColonyCustomMessage.cb_getMessage;
		}

		// Token: 0x06000305 RID: 773 RVA: 0x00009B1C File Offset: 0x00007D1C
		private static IntPtr n_GetMessage(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<AdColonyCustomMessage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Message);
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000306 RID: 774 RVA: 0x00009B30 File Offset: 0x00007D30
		public virtual string Message
		{
			[Register("getMessage", "()Ljava/lang/String;", "GetGetMessageHandler")]
			get
			{
				return JNIEnv.GetString(AdColonyCustomMessage._members.InstanceMethods.InvokeVirtualObjectMethod("getMessage.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000307 RID: 775 RVA: 0x00009B62 File Offset: 0x00007D62
		private static Delegate GetGetTypeHandler()
		{
			if (AdColonyCustomMessage.cb_getType == null)
			{
				AdColonyCustomMessage.cb_getType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AdColonyCustomMessage.n_GetType));
			}
			return AdColonyCustomMessage.cb_getType;
		}

		// Token: 0x06000308 RID: 776 RVA: 0x00009B86 File Offset: 0x00007D86
		private static IntPtr n_GetType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<AdColonyCustomMessage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Type);
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000309 RID: 777 RVA: 0x00009B9C File Offset: 0x00007D9C
		public virtual string Type
		{
			[Register("getType", "()Ljava/lang/String;", "GetGetTypeHandler")]
			get
			{
				return JNIEnv.GetString(AdColonyCustomMessage._members.InstanceMethods.InvokeVirtualObjectMethod("getType.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600030A RID: 778 RVA: 0x00009BCE File Offset: 0x00007DCE
		private static Delegate GetSendHandler()
		{
			if (AdColonyCustomMessage.cb_send == null)
			{
				AdColonyCustomMessage.cb_send = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(AdColonyCustomMessage.n_Send));
			}
			return AdColonyCustomMessage.cb_send;
		}

		// Token: 0x0600030B RID: 779 RVA: 0x00009BF2 File Offset: 0x00007DF2
		private static void n_Send(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<AdColonyCustomMessage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Send();
		}

		// Token: 0x0600030C RID: 780 RVA: 0x00009C01 File Offset: 0x00007E01
		[Register("send", "()V", "GetSendHandler")]
		public virtual void Send()
		{
			AdColonyCustomMessage._members.InstanceMethods.InvokeVirtualVoidMethod("send.()V", this, null);
		}

		// Token: 0x0600030D RID: 781 RVA: 0x00009C1A File Offset: 0x00007E1A
		private static Delegate GetSet_Ljava_lang_String_Ljava_lang_String_Handler()
		{
			if (AdColonyCustomMessage.cb_set_Ljava_lang_String_Ljava_lang_String_ == null)
			{
				AdColonyCustomMessage.cb_set_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(AdColonyCustomMessage.n_Set_Ljava_lang_String_Ljava_lang_String_));
			}
			return AdColonyCustomMessage.cb_set_Ljava_lang_String_Ljava_lang_String_;
		}

		// Token: 0x0600030E RID: 782 RVA: 0x00009C40 File Offset: 0x00007E40
		private static IntPtr n_Set_Ljava_lang_String_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_type, IntPtr native_message)
		{
			AdColonyCustomMessage @object = Java.Lang.Object.GetObject<AdColonyCustomMessage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_type, JniHandleOwnership.DoNotTransfer);
			string string2 = JNIEnv.GetString(native_message, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Set(@string, string2));
		}

		// Token: 0x0600030F RID: 783 RVA: 0x00009C74 File Offset: 0x00007E74
		[Register("set", "(Ljava/lang/String;Ljava/lang/String;)Lcom/adcolony/sdk/AdColonyCustomMessage;", "GetSet_Ljava_lang_String_Ljava_lang_String_Handler")]
		public unsafe virtual AdColonyCustomMessage Set(string type, string message)
		{
			IntPtr intPtr = JNIEnv.NewString(type);
			IntPtr intPtr2 = JNIEnv.NewString(message);
			AdColonyCustomMessage @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@object = Java.Lang.Object.GetObject<AdColonyCustomMessage>(AdColonyCustomMessage._members.InstanceMethods.InvokeVirtualObjectMethod("set.(Ljava/lang/String;Ljava/lang/String;)Lcom/adcolony/sdk/AdColonyCustomMessage;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
			return @object;
		}

		// Token: 0x040000AD RID: 173
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/adcolony/sdk/AdColonyCustomMessage", typeof(AdColonyCustomMessage));

		// Token: 0x040000AE RID: 174
		private static Delegate cb_getMessage;

		// Token: 0x040000AF RID: 175
		private static Delegate cb_getType;

		// Token: 0x040000B0 RID: 176
		private static Delegate cb_send;

		// Token: 0x040000B1 RID: 177
		private static Delegate cb_set_Ljava_lang_String_Ljava_lang_String_;
	}
}
