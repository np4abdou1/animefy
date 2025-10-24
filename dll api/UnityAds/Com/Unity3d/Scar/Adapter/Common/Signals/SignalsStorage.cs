using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Scar.Adapter.Common.Signals
{
	// Token: 0x020002BA RID: 698
	[Register("com/unity3d/scar/adapter/common/signals/SignalsStorage", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public class SignalsStorage : Java.Lang.Object
	{
		// Token: 0x17000EF5 RID: 3829
		// (get) Token: 0x06002780 RID: 10112 RVA: 0x00066068 File Offset: 0x00064268
		internal static IntPtr class_ref
		{
			get
			{
				return SignalsStorage._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000EF6 RID: 3830
		// (get) Token: 0x06002781 RID: 10113 RVA: 0x0006608C File Offset: 0x0006428C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SignalsStorage._members;
			}
		}

		// Token: 0x17000EF7 RID: 3831
		// (get) Token: 0x06002782 RID: 10114 RVA: 0x00066094 File Offset: 0x00064294
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SignalsStorage._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000EF8 RID: 3832
		// (get) Token: 0x06002783 RID: 10115 RVA: 0x000660B8 File Offset: 0x000642B8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SignalsStorage._members.ManagedPeerType;
			}
		}

		// Token: 0x06002784 RID: 10116 RVA: 0x000021E8 File Offset: 0x000003E8
		protected SignalsStorage(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06002785 RID: 10117 RVA: 0x000660C4 File Offset: 0x000642C4
		[Register(".ctor", "()V", "")]
		public SignalsStorage() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(SignalsStorage._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			SignalsStorage._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06002786 RID: 10118 RVA: 0x00066132 File Offset: 0x00064332
		private static Delegate GetGetQueryInfo_Ljava_lang_String_Handler()
		{
			if (SignalsStorage.cb_getQueryInfo_Ljava_lang_String_ == null)
			{
				SignalsStorage.cb_getQueryInfo_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(SignalsStorage.n_GetQueryInfo_Ljava_lang_String_));
			}
			return SignalsStorage.cb_getQueryInfo_Ljava_lang_String_;
		}

		// Token: 0x06002787 RID: 10119 RVA: 0x00066158 File Offset: 0x00064358
		private static IntPtr n_GetQueryInfo_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_placementId)
		{
			SignalsStorage @object = Java.Lang.Object.GetObject<SignalsStorage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_placementId, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetQueryInfo(@string));
		}

		// Token: 0x06002788 RID: 10120 RVA: 0x00066180 File Offset: 0x00064380
		[Register("getQueryInfo", "(Ljava/lang/String;)Ljava/lang/Object;", "GetGetQueryInfo_Ljava_lang_String_Handler")]
		public unsafe virtual Java.Lang.Object GetQueryInfo(string placementId)
		{
			IntPtr intPtr = JNIEnv.NewString(placementId);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(SignalsStorage._members.InstanceMethods.InvokeVirtualObjectMethod("getQueryInfo.(Ljava/lang/String;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06002789 RID: 10121 RVA: 0x000661EC File Offset: 0x000643EC
		private static Delegate GetPut_Ljava_lang_String_Ljava_lang_Object_Handler()
		{
			if (SignalsStorage.cb_put_Ljava_lang_String_Ljava_lang_Object_ == null)
			{
				SignalsStorage.cb_put_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(SignalsStorage.n_Put_Ljava_lang_String_Ljava_lang_Object_));
			}
			return SignalsStorage.cb_put_Ljava_lang_String_Ljava_lang_Object_;
		}

		// Token: 0x0600278A RID: 10122 RVA: 0x00066210 File Offset: 0x00064410
		private static void n_Put_Ljava_lang_String_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
		{
			SignalsStorage @object = Java.Lang.Object.GetObject<SignalsStorage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_key, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_value, JniHandleOwnership.DoNotTransfer);
			@object.Put(@string, object2);
		}

		// Token: 0x0600278B RID: 10123 RVA: 0x0006623C File Offset: 0x0006443C
		[Register("put", "(Ljava/lang/String;Ljava/lang/Object;)V", "GetPut_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public unsafe virtual void Put(string key, Java.Lang.Object value)
		{
			IntPtr intPtr = JNIEnv.NewString(key);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(value);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				SignalsStorage._members.InstanceMethods.InvokeVirtualVoidMethod("put.(Ljava/lang/String;Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(value);
			}
		}

		// Token: 0x040007E6 RID: 2022
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/common/signals/SignalsStorage", typeof(SignalsStorage));

		// Token: 0x040007E7 RID: 2023
		private static Delegate cb_getQueryInfo_Ljava_lang_String_;

		// Token: 0x040007E8 RID: 2024
		private static Delegate cb_put_Ljava_lang_String_Ljava_lang_Object_;
	}
}
