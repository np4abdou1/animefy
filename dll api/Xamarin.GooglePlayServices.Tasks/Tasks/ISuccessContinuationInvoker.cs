using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Tasks
{
	// Token: 0x0200001A RID: 26
	[Register("com/google/android/gms/tasks/SuccessContinuation", DoNotGenerateAcw = true)]
	internal class ISuccessContinuationInvoker : Java.Lang.Object, ISuccessContinuation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x00003FFC File Offset: 0x000021FC
		private static IntPtr java_class_ref
		{
			get
			{
				return ISuccessContinuationInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x00004020 File Offset: 0x00002220
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ISuccessContinuationInvoker._members;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x00004027 File Offset: 0x00002227
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000EA RID: 234 RVA: 0x0000402F File Offset: 0x0000222F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ISuccessContinuationInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060000EB RID: 235 RVA: 0x0000403B File Offset: 0x0000223B
		public static ISuccessContinuation GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ISuccessContinuation>(handle, transfer);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00004044 File Offset: 0x00002244
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ISuccessContinuationInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.gms.tasks.SuccessContinuation'.");
			}
			return handle;
		}

		// Token: 0x060000ED RID: 237 RVA: 0x0000406F File Offset: 0x0000226F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060000EE RID: 238 RVA: 0x000040A0 File Offset: 0x000022A0
		public ISuccessContinuationInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ISuccessContinuationInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x000040D8 File Offset: 0x000022D8
		private static Delegate GetThen_Ljava_lang_Object_Handler()
		{
			if (ISuccessContinuationInvoker.cb_then_Ljava_lang_Object_ == null)
			{
				ISuccessContinuationInvoker.cb_then_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ISuccessContinuationInvoker.n_Then_Ljava_lang_Object_));
			}
			return ISuccessContinuationInvoker.cb_then_Ljava_lang_Object_;
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x000040FC File Offset: 0x000022FC
		private static IntPtr n_Then_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_result)
		{
			ISuccessContinuation @object = Java.Lang.Object.GetObject<ISuccessContinuation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_result, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Then(object2));
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00004124 File Offset: 0x00002324
		public unsafe Task Then(Java.Lang.Object result)
		{
			if (this.id_then_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_then_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "then", "(Ljava/lang/Object;)Lcom/google/android/gms/tasks/Task;");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(result);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			Task @object = Java.Lang.Object.GetObject<Task>(JNIEnv.CallObjectMethod(base.Handle, this.id_then_Ljava_lang_Object_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x0400003C RID: 60
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/tasks/SuccessContinuation", typeof(ISuccessContinuationInvoker));

		// Token: 0x0400003D RID: 61
		private IntPtr class_ref;

		// Token: 0x0400003E RID: 62
		private static Delegate cb_then_Ljava_lang_Object_;

		// Token: 0x0400003F RID: 63
		private IntPtr id_then_Ljava_lang_Object_;
	}
}
