using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using AndroidX.Activity.Result.Contract;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Activity.Result
{
	// Token: 0x02000028 RID: 40
	[Register("androidx/activity/result/ActivityResultCaller", DoNotGenerateAcw = true)]
	internal class IActivityResultCallerInvoker : Java.Lang.Object, IActivityResultCaller, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600012C RID: 300 RVA: 0x00004F20 File Offset: 0x00003120
		private static IntPtr java_class_ref
		{
			get
			{
				return IActivityResultCallerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600012D RID: 301 RVA: 0x00004F44 File Offset: 0x00003144
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IActivityResultCallerInvoker._members;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600012E RID: 302 RVA: 0x00004F4B File Offset: 0x0000314B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600012F RID: 303 RVA: 0x00004F53 File Offset: 0x00003153
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IActivityResultCallerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00004F5F File Offset: 0x0000315F
		public static IActivityResultCaller GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IActivityResultCaller>(handle, transfer);
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00004F68 File Offset: 0x00003168
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IActivityResultCallerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.activity.result.ActivityResultCaller'.");
			}
			return handle;
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00004F93 File Offset: 0x00003193
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00004FC4 File Offset: 0x000031C4
		public IActivityResultCallerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IActivityResultCallerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00004FFC File Offset: 0x000031FC
		private static Delegate GetRegisterForActivityResult_Landroidx_activity_result_contract_ActivityResultContract_Landroidx_activity_result_ActivityResultCallback_Handler()
		{
			if (IActivityResultCallerInvoker.cb_registerForActivityResult_Landroidx_activity_result_contract_ActivityResultContract_Landroidx_activity_result_ActivityResultCallback_ == null)
			{
				IActivityResultCallerInvoker.cb_registerForActivityResult_Landroidx_activity_result_contract_ActivityResultContract_Landroidx_activity_result_ActivityResultCallback_ = JNINativeWrapper.CreateDelegate(new global::_JniMarshal_PPLL_L(IActivityResultCallerInvoker.n_RegisterForActivityResult_Landroidx_activity_result_contract_ActivityResultContract_Landroidx_activity_result_ActivityResultCallback_));
			}
			return IActivityResultCallerInvoker.cb_registerForActivityResult_Landroidx_activity_result_contract_ActivityResultContract_Landroidx_activity_result_ActivityResultCallback_;
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00005020 File Offset: 0x00003220
		private static IntPtr n_RegisterForActivityResult_Landroidx_activity_result_contract_ActivityResultContract_Landroidx_activity_result_ActivityResultCallback_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IActivityResultCaller @object = Java.Lang.Object.GetObject<IActivityResultCaller>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ActivityResultContract object2 = Java.Lang.Object.GetObject<ActivityResultContract>(native_p0, JniHandleOwnership.DoNotTransfer);
			IActivityResultCallback object3 = Java.Lang.Object.GetObject<IActivityResultCallback>(native_p1, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.RegisterForActivityResult(object2, object3));
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00005054 File Offset: 0x00003254
		public unsafe ActivityResultLauncher RegisterForActivityResult(ActivityResultContract p0, IActivityResultCallback p1)
		{
			if (this.id_registerForActivityResult_Landroidx_activity_result_contract_ActivityResultContract_Landroidx_activity_result_ActivityResultCallback_ == IntPtr.Zero)
			{
				this.id_registerForActivityResult_Landroidx_activity_result_contract_ActivityResultContract_Landroidx_activity_result_ActivityResultCallback_ = JNIEnv.GetMethodID(this.class_ref, "registerForActivityResult", "(Landroidx/activity/result/contract/ActivityResultContract;Landroidx/activity/result/ActivityResultCallback;)Landroidx/activity/result/ActivityResultLauncher;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
			return Java.Lang.Object.GetObject<ActivityResultLauncher>(JNIEnv.CallObjectMethod(base.Handle, this.id_registerForActivityResult_Landroidx_activity_result_contract_ActivityResultContract_Landroidx_activity_result_ActivityResultCallback_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000137 RID: 311 RVA: 0x000050F4 File Offset: 0x000032F4
		private static Delegate GetRegisterForActivityResult_Landroidx_activity_result_contract_ActivityResultContract_Landroidx_activity_result_ActivityResultRegistry_Landroidx_activity_result_ActivityResultCallback_Handler()
		{
			if (IActivityResultCallerInvoker.cb_registerForActivityResult_Landroidx_activity_result_contract_ActivityResultContract_Landroidx_activity_result_ActivityResultRegistry_Landroidx_activity_result_ActivityResultCallback_ == null)
			{
				IActivityResultCallerInvoker.cb_registerForActivityResult_Landroidx_activity_result_contract_ActivityResultContract_Landroidx_activity_result_ActivityResultRegistry_Landroidx_activity_result_ActivityResultCallback_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_L(IActivityResultCallerInvoker.n_RegisterForActivityResult_Landroidx_activity_result_contract_ActivityResultContract_Landroidx_activity_result_ActivityResultRegistry_Landroidx_activity_result_ActivityResultCallback_));
			}
			return IActivityResultCallerInvoker.cb_registerForActivityResult_Landroidx_activity_result_contract_ActivityResultContract_Landroidx_activity_result_ActivityResultRegistry_Landroidx_activity_result_ActivityResultCallback_;
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00005118 File Offset: 0x00003318
		private static IntPtr n_RegisterForActivityResult_Landroidx_activity_result_contract_ActivityResultContract_Landroidx_activity_result_ActivityResultRegistry_Landroidx_activity_result_ActivityResultCallback_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			IActivityResultCaller @object = Java.Lang.Object.GetObject<IActivityResultCaller>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ActivityResultContract object2 = Java.Lang.Object.GetObject<ActivityResultContract>(native_p0, JniHandleOwnership.DoNotTransfer);
			ActivityResultRegistry object3 = Java.Lang.Object.GetObject<ActivityResultRegistry>(native_p1, JniHandleOwnership.DoNotTransfer);
			IActivityResultCallback object4 = Java.Lang.Object.GetObject<IActivityResultCallback>(native_p2, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.RegisterForActivityResult(object2, object3, object4));
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00005154 File Offset: 0x00003354
		public unsafe ActivityResultLauncher RegisterForActivityResult(ActivityResultContract p0, ActivityResultRegistry p1, IActivityResultCallback p2)
		{
			if (this.id_registerForActivityResult_Landroidx_activity_result_contract_ActivityResultContract_Landroidx_activity_result_ActivityResultRegistry_Landroidx_activity_result_ActivityResultCallback_ == IntPtr.Zero)
			{
				this.id_registerForActivityResult_Landroidx_activity_result_contract_ActivityResultContract_Landroidx_activity_result_ActivityResultRegistry_Landroidx_activity_result_ActivityResultCallback_ = JNIEnv.GetMethodID(this.class_ref, "registerForActivityResult", "(Landroidx/activity/result/contract/ActivityResultContract;Landroidx/activity/result/ActivityResultRegistry;Landroidx/activity/result/ActivityResultCallback;)Landroidx/activity/result/ActivityResultLauncher;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
			ptr[2] = new JValue((p2 == null) ? IntPtr.Zero : ((Java.Lang.Object)p2).Handle);
			return Java.Lang.Object.GetObject<ActivityResultLauncher>(JNIEnv.CallObjectMethod(base.Handle, this.id_registerForActivityResult_Landroidx_activity_result_contract_ActivityResultContract_Landroidx_activity_result_ActivityResultRegistry_Landroidx_activity_result_ActivityResultCallback_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000044 RID: 68
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/activity/result/ActivityResultCaller", typeof(IActivityResultCallerInvoker));

		// Token: 0x04000045 RID: 69
		private IntPtr class_ref;

		// Token: 0x04000046 RID: 70
		private static Delegate cb_registerForActivityResult_Landroidx_activity_result_contract_ActivityResultContract_Landroidx_activity_result_ActivityResultCallback_;

		// Token: 0x04000047 RID: 71
		private IntPtr id_registerForActivityResult_Landroidx_activity_result_contract_ActivityResultContract_Landroidx_activity_result_ActivityResultCallback_;

		// Token: 0x04000048 RID: 72
		private static Delegate cb_registerForActivityResult_Landroidx_activity_result_contract_ActivityResultContract_Landroidx_activity_result_ActivityResultRegistry_Landroidx_activity_result_ActivityResultCallback_;

		// Token: 0x04000049 RID: 73
		private IntPtr id_registerForActivityResult_Landroidx_activity_result_contract_ActivityResultContract_Landroidx_activity_result_ActivityResultRegistry_Landroidx_activity_result_ActivityResultCallback_;
	}
}
