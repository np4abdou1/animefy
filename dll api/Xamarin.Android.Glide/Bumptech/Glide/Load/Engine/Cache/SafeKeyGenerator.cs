using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Engine.Cache
{
	// Token: 0x02000172 RID: 370
	[Register("com/bumptech/glide/load/engine/cache/SafeKeyGenerator", DoNotGenerateAcw = true)]
	public class SafeKeyGenerator : Java.Lang.Object
	{
		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06001274 RID: 4724 RVA: 0x0003B6B4 File Offset: 0x000398B4
		internal static IntPtr class_ref
		{
			get
			{
				return SafeKeyGenerator._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06001275 RID: 4725 RVA: 0x0003B6D8 File Offset: 0x000398D8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SafeKeyGenerator._members;
			}
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06001276 RID: 4726 RVA: 0x0003B6E0 File Offset: 0x000398E0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SafeKeyGenerator._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06001277 RID: 4727 RVA: 0x0003B704 File Offset: 0x00039904
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SafeKeyGenerator._members.ManagedPeerType;
			}
		}

		// Token: 0x06001278 RID: 4728 RVA: 0x0003B710 File Offset: 0x00039910
		protected SafeKeyGenerator(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001279 RID: 4729 RVA: 0x0003B71C File Offset: 0x0003991C
		[Register(".ctor", "()V", "")]
		public SafeKeyGenerator() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(SafeKeyGenerator._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			SafeKeyGenerator._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x0600127A RID: 4730 RVA: 0x0003B78A File Offset: 0x0003998A
		private static Delegate GetGetSafeKey_Lcom_bumptech_glide_load_Key_Handler()
		{
			if (SafeKeyGenerator.cb_getSafeKey_Lcom_bumptech_glide_load_Key_ == null)
			{
				SafeKeyGenerator.cb_getSafeKey_Lcom_bumptech_glide_load_Key_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(SafeKeyGenerator.n_GetSafeKey_Lcom_bumptech_glide_load_Key_));
			}
			return SafeKeyGenerator.cb_getSafeKey_Lcom_bumptech_glide_load_Key_;
		}

		// Token: 0x0600127B RID: 4731 RVA: 0x0003B7B0 File Offset: 0x000399B0
		private static IntPtr n_GetSafeKey_Lcom_bumptech_glide_load_Key_(IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			SafeKeyGenerator @object = Java.Lang.Object.GetObject<SafeKeyGenerator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IKey object2 = Java.Lang.Object.GetObject<IKey>(native_key, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString(@object.GetSafeKey(object2));
		}

		// Token: 0x0600127C RID: 4732 RVA: 0x0003B7D8 File Offset: 0x000399D8
		[Register("getSafeKey", "(Lcom/bumptech/glide/load/Key;)Ljava/lang/String;", "GetGetSafeKey_Lcom_bumptech_glide_load_Key_Handler")]
		public unsafe virtual string GetSafeKey(IKey key)
		{
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((key == null) ? IntPtr.Zero : ((Java.Lang.Object)key).Handle);
				@string = JNIEnv.GetString(SafeKeyGenerator._members.InstanceMethods.InvokeVirtualObjectMethod("getSafeKey.(Lcom/bumptech/glide/load/Key;)Ljava/lang/String;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(key);
			}
			return @string;
		}

		// Token: 0x04000451 RID: 1105
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/engine/cache/SafeKeyGenerator", typeof(SafeKeyGenerator));

		// Token: 0x04000452 RID: 1106
		private static Delegate cb_getSafeKey_Lcom_bumptech_glide_load_Key_;
	}
}
