using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Ads.Metadata
{
	// Token: 0x020002E2 RID: 738
	[Register("com/unity3d/ads/metadata/PlayerMetaData", DoNotGenerateAcw = true)]
	public class PlayerMetaData : MetaData
	{
		// Token: 0x17000F7B RID: 3963
		// (get) Token: 0x060028F8 RID: 10488 RVA: 0x0006A108 File Offset: 0x00068308
		internal new static IntPtr class_ref
		{
			get
			{
				return PlayerMetaData._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000F7C RID: 3964
		// (get) Token: 0x060028F9 RID: 10489 RVA: 0x0006A12C File Offset: 0x0006832C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return PlayerMetaData._members;
			}
		}

		// Token: 0x17000F7D RID: 3965
		// (get) Token: 0x060028FA RID: 10490 RVA: 0x0006A134 File Offset: 0x00068334
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return PlayerMetaData._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000F7E RID: 3966
		// (get) Token: 0x060028FB RID: 10491 RVA: 0x0006A158 File Offset: 0x00068358
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return PlayerMetaData._members.ManagedPeerType;
			}
		}

		// Token: 0x060028FC RID: 10492 RVA: 0x000695CC File Offset: 0x000677CC
		protected PlayerMetaData(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060028FD RID: 10493 RVA: 0x0006A164 File Offset: 0x00068364
		[Register(".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe PlayerMetaData(Context context) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				base.SetHandle(PlayerMetaData._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				PlayerMetaData._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
		}

		// Token: 0x060028FE RID: 10494 RVA: 0x0006A214 File Offset: 0x00068414
		private static Delegate GetSetServerId_Ljava_lang_String_Handler()
		{
			if (PlayerMetaData.cb_setServerId_Ljava_lang_String_ == null)
			{
				PlayerMetaData.cb_setServerId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(PlayerMetaData.n_SetServerId_Ljava_lang_String_));
			}
			return PlayerMetaData.cb_setServerId_Ljava_lang_String_;
		}

		// Token: 0x060028FF RID: 10495 RVA: 0x0006A238 File Offset: 0x00068438
		private static void n_SetServerId_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_serverId)
		{
			PlayerMetaData @object = Java.Lang.Object.GetObject<PlayerMetaData>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_serverId, JniHandleOwnership.DoNotTransfer);
			@object.SetServerId(@string);
		}

		// Token: 0x06002900 RID: 10496 RVA: 0x0006A25C File Offset: 0x0006845C
		[Register("setServerId", "(Ljava/lang/String;)V", "GetSetServerId_Ljava_lang_String_Handler")]
		public unsafe virtual void SetServerId(string serverId)
		{
			IntPtr intPtr = JNIEnv.NewString(serverId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				PlayerMetaData._members.InstanceMethods.InvokeVirtualVoidMethod("setServerId.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x04000860 RID: 2144
		[Register("KEY_SERVER_ID")]
		public const string KeyServerId = "server_id";

		// Token: 0x04000861 RID: 2145
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/ads/metadata/PlayerMetaData", typeof(PlayerMetaData));

		// Token: 0x04000862 RID: 2146
		private static Delegate cb_setServerId_Ljava_lang_String_;
	}
}
