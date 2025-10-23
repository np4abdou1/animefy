using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Data
{
	// Token: 0x0200018E RID: 398
	[Register("com/bumptech/glide/load/data/DataRewinderRegistry", DoNotGenerateAcw = true)]
	public class DataRewinderRegistry : Java.Lang.Object
	{
		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x06001426 RID: 5158 RVA: 0x000407B8 File Offset: 0x0003E9B8
		internal static IntPtr class_ref
		{
			get
			{
				return DataRewinderRegistry._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x06001427 RID: 5159 RVA: 0x000407DC File Offset: 0x0003E9DC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DataRewinderRegistry._members;
			}
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x06001428 RID: 5160 RVA: 0x000407E4 File Offset: 0x0003E9E4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DataRewinderRegistry._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06001429 RID: 5161 RVA: 0x00040808 File Offset: 0x0003EA08
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DataRewinderRegistry._members.ManagedPeerType;
			}
		}

		// Token: 0x0600142A RID: 5162 RVA: 0x00040814 File Offset: 0x0003EA14
		protected DataRewinderRegistry(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600142B RID: 5163 RVA: 0x00040820 File Offset: 0x0003EA20
		[Register(".ctor", "()V", "")]
		public DataRewinderRegistry() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(DataRewinderRegistry._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			DataRewinderRegistry._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x0600142C RID: 5164 RVA: 0x0004088E File Offset: 0x0003EA8E
		private static Delegate GetBuild_Ljava_lang_Object_Handler()
		{
			if (DataRewinderRegistry.cb_build_Ljava_lang_Object_ == null)
			{
				DataRewinderRegistry.cb_build_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(DataRewinderRegistry.n_Build_Ljava_lang_Object_));
			}
			return DataRewinderRegistry.cb_build_Ljava_lang_Object_;
		}

		// Token: 0x0600142D RID: 5165 RVA: 0x000408B4 File Offset: 0x0003EAB4
		private static IntPtr n_Build_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_data)
		{
			DataRewinderRegistry @object = Java.Lang.Object.GetObject<DataRewinderRegistry>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_data, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Build(object2));
		}

		// Token: 0x0600142E RID: 5166 RVA: 0x000408DC File Offset: 0x0003EADC
		[Register("build", "(Ljava/lang/Object;)Lcom/bumptech/glide/load/data/DataRewinder;", "GetBuild_Ljava_lang_Object_Handler")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe virtual IDataRewinder Build(Java.Lang.Object data)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(data);
			IDataRewinder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<IDataRewinder>(DataRewinderRegistry._members.InstanceMethods.InvokeVirtualObjectMethod("build.(Ljava/lang/Object;)Lcom/bumptech/glide/load/data/DataRewinder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(data);
			}
			return @object;
		}

		// Token: 0x0600142F RID: 5167 RVA: 0x00040950 File Offset: 0x0003EB50
		private static Delegate GetRegister_Lcom_bumptech_glide_load_data_DataRewinder_Factory_Handler()
		{
			if (DataRewinderRegistry.cb_register_Lcom_bumptech_glide_load_data_DataRewinder_Factory_ == null)
			{
				DataRewinderRegistry.cb_register_Lcom_bumptech_glide_load_data_DataRewinder_Factory_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(DataRewinderRegistry.n_Register_Lcom_bumptech_glide_load_data_DataRewinder_Factory_));
			}
			return DataRewinderRegistry.cb_register_Lcom_bumptech_glide_load_data_DataRewinder_Factory_;
		}

		// Token: 0x06001430 RID: 5168 RVA: 0x00040974 File Offset: 0x0003EB74
		private static void n_Register_Lcom_bumptech_glide_load_data_DataRewinder_Factory_(IntPtr jnienv, IntPtr native__this, IntPtr native_factory)
		{
			DataRewinderRegistry @object = Java.Lang.Object.GetObject<DataRewinderRegistry>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IDataRewinderFactory object2 = Java.Lang.Object.GetObject<IDataRewinderFactory>(native_factory, JniHandleOwnership.DoNotTransfer);
			@object.Register(object2);
		}

		// Token: 0x06001431 RID: 5169 RVA: 0x00040998 File Offset: 0x0003EB98
		[Register("register", "(Lcom/bumptech/glide/load/data/DataRewinder$Factory;)V", "GetRegister_Lcom_bumptech_glide_load_data_DataRewinder_Factory_Handler")]
		public unsafe virtual void Register(IDataRewinderFactory factory)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((factory == null) ? IntPtr.Zero : ((Java.Lang.Object)factory).Handle);
				DataRewinderRegistry._members.InstanceMethods.InvokeVirtualVoidMethod("register.(Lcom/bumptech/glide/load/data/DataRewinder$Factory;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(factory);
			}
		}

		// Token: 0x040004C1 RID: 1217
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/data/DataRewinderRegistry", typeof(DataRewinderRegistry));

		// Token: 0x040004C2 RID: 1218
		private static Delegate cb_build_Ljava_lang_Object_;

		// Token: 0x040004C3 RID: 1219
		private static Delegate cb_register_Lcom_bumptech_glide_load_data_DataRewinder_Factory_;
	}
}
