using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;

namespace Android.Gms.Common.Apis.Internal
{
	// Token: 0x02000027 RID: 39
	[Register("com/google/android/gms/common/api/internal/LifecycleCallback", DoNotGenerateAcw = true)]
	public class LifecycleCallback : Java.Lang.Object
	{
		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600012A RID: 298 RVA: 0x00004B50 File Offset: 0x00002D50
		// (set) Token: 0x0600012B RID: 299 RVA: 0x00004B80 File Offset: 0x00002D80
		[Register("mLifecycleFragment")]
		protected ILifecycleFragment MLifecycleFragment
		{
			get
			{
				return Java.Lang.Object.GetObject<ILifecycleFragment>(LifecycleCallback._members.InstanceFields.GetObjectValue("mLifecycleFragment.Lcom/google/android/gms/common/api/internal/LifecycleFragment;", this).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
				try
				{
					LifecycleCallback._members.InstanceFields.SetValue("mLifecycleFragment.Lcom/google/android/gms/common/api/internal/LifecycleFragment;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600012C RID: 300 RVA: 0x00004BCC File Offset: 0x00002DCC
		internal static IntPtr class_ref
		{
			get
			{
				return LifecycleCallback._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x0600012D RID: 301 RVA: 0x00004BF0 File Offset: 0x00002DF0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return LifecycleCallback._members;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x0600012E RID: 302 RVA: 0x00004BF8 File Offset: 0x00002DF8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return LifecycleCallback._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x0600012F RID: 303 RVA: 0x00004C1C File Offset: 0x00002E1C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return LifecycleCallback._members.ManagedPeerType;
			}
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00002EC0 File Offset: 0x000010C0
		protected LifecycleCallback(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00004C28 File Offset: 0x00002E28
		[Register(".ctor", "(Lcom/google/android/gms/common/api/internal/LifecycleFragment;)V", "")]
		protected unsafe LifecycleCallback(ILifecycleFragment fragment) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((fragment == null) ? IntPtr.Zero : ((Java.Lang.Object)fragment).Handle);
				base.SetHandle(LifecycleCallback._members.InstanceMethods.StartCreateInstance("(Lcom/google/android/gms/common/api/internal/LifecycleFragment;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				LifecycleCallback._members.InstanceMethods.FinishCreateInstance("(Lcom/google/android/gms/common/api/internal/LifecycleFragment;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(fragment);
			}
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00004CDC File Offset: 0x00002EDC
		private static Delegate GetGetActivityHandler()
		{
			if (LifecycleCallback.cb_getActivity == null)
			{
				LifecycleCallback.cb_getActivity = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(LifecycleCallback.n_GetActivity));
			}
			return LifecycleCallback.cb_getActivity;
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00004D00 File Offset: 0x00002F00
		private static IntPtr n_GetActivity(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<LifecycleCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Activity);
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000134 RID: 308 RVA: 0x00004D14 File Offset: 0x00002F14
		public virtual Activity Activity
		{
			[Register("getActivity", "()Landroid/app/Activity;", "GetGetActivityHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Activity>(LifecycleCallback._members.InstanceMethods.InvokeVirtualObjectMethod("getActivity.()Landroid/app/Activity;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00004D46 File Offset: 0x00002F46
		private static Delegate GetDump_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_Handler()
		{
			if (LifecycleCallback.cb_dump_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_ == null)
			{
				LifecycleCallback.cb_dump_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLL_V(LifecycleCallback.n_Dump_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_));
			}
			return LifecycleCallback.cb_dump_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_;
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00004D6C File Offset: 0x00002F6C
		private static void n_Dump_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			LifecycleCallback @object = Java.Lang.Object.GetObject<LifecycleCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			FileDescriptor object2 = Java.Lang.Object.GetObject<FileDescriptor>(native_p1, JniHandleOwnership.DoNotTransfer);
			PrintWriter object3 = Java.Lang.Object.GetObject<PrintWriter>(native_p2, JniHandleOwnership.DoNotTransfer);
			string[] array = (string[])JNIEnv.GetArray(native_p3, JniHandleOwnership.DoNotTransfer, typeof(string));
			@object.Dump(@string, object2, object3, array);
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_p3);
			}
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00004DC8 File Offset: 0x00002FC8
		[Register("dump", "(Ljava/lang/String;Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/String;)V", "GetDump_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_Handler")]
		public unsafe virtual void Dump(string p0, FileDescriptor p1, PrintWriter p2, string[] p3)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			IntPtr intPtr2 = JNIEnv.NewArray(p3);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : p2.Handle);
				ptr[3] = new JniArgumentValue(intPtr2);
				LifecycleCallback._members.InstanceMethods.InvokeVirtualVoidMethod("dump.(Ljava/lang/String;Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				if (p3 != null)
				{
					JNIEnv.CopyArray(intPtr2, p3);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(p1);
				GC.KeepAlive(p2);
				GC.KeepAlive(p3);
			}
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00004EB0 File Offset: 0x000030B0
		[Register("getFragment", "(Landroid/app/Activity;)Lcom/google/android/gms/common/api/internal/LifecycleFragment;", "")]
		public unsafe static ILifecycleFragment GetFragment(Activity activity)
		{
			ILifecycleFragment @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				@object = Java.Lang.Object.GetObject<ILifecycleFragment>(LifecycleCallback._members.StaticMethods.InvokeObjectMethod("getFragment.(Landroid/app/Activity;)Lcom/google/android/gms/common/api/internal/LifecycleFragment;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(activity);
			}
			return @object;
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00004F24 File Offset: 0x00003124
		[Register("getFragment", "(Landroid/content/ContextWrapper;)Lcom/google/android/gms/common/api/internal/LifecycleFragment;", "")]
		public unsafe static ILifecycleFragment GetFragment(ContextWrapper p0)
		{
			ILifecycleFragment @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				@object = Java.Lang.Object.GetObject<ILifecycleFragment>(LifecycleCallback._members.StaticMethods.InvokeObjectMethod("getFragment.(Landroid/content/ContextWrapper;)Lcom/google/android/gms/common/api/internal/LifecycleFragment;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return @object;
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00004F98 File Offset: 0x00003198
		[Register("getFragment", "(Lcom/google/android/gms/common/api/internal/LifecycleActivity;)Lcom/google/android/gms/common/api/internal/LifecycleFragment;", "")]
		protected unsafe static ILifecycleFragment GetFragment(LifecycleActivity activity)
		{
			ILifecycleFragment @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				@object = Java.Lang.Object.GetObject<ILifecycleFragment>(LifecycleCallback._members.StaticMethods.InvokeObjectMethod("getFragment.(Lcom/google/android/gms/common/api/internal/LifecycleActivity;)Lcom/google/android/gms/common/api/internal/LifecycleFragment;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(activity);
			}
			return @object;
		}

		// Token: 0x0600013B RID: 315 RVA: 0x0000500C File Offset: 0x0000320C
		private static Delegate GetOnActivityResult_IILandroid_content_Intent_Handler()
		{
			if (LifecycleCallback.cb_onActivityResult_IILandroid_content_Intent_ == null)
			{
				LifecycleCallback.cb_onActivityResult_IILandroid_content_Intent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIIL_V(LifecycleCallback.n_OnActivityResult_IILandroid_content_Intent_));
			}
			return LifecycleCallback.cb_onActivityResult_IILandroid_content_Intent_;
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00005030 File Offset: 0x00003230
		private static void n_OnActivityResult_IILandroid_content_Intent_(IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			LifecycleCallback @object = Java.Lang.Object.GetObject<LifecycleCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Intent object2 = Java.Lang.Object.GetObject<Intent>(native_p2, JniHandleOwnership.DoNotTransfer);
			@object.OnActivityResult(p0, p1, object2);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00005058 File Offset: 0x00003258
		[Register("onActivityResult", "(IILandroid/content/Intent;)V", "GetOnActivityResult_IILandroid_content_Intent_Handler")]
		public unsafe virtual void OnActivityResult(int p0, int p1, Intent p2)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(p0);
				ptr[1] = new JniArgumentValue(p1);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : p2.Handle);
				LifecycleCallback._members.InstanceMethods.InvokeVirtualVoidMethod("onActivityResult.(IILandroid/content/Intent;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p2);
			}
		}

		// Token: 0x0600013E RID: 318 RVA: 0x000050E4 File Offset: 0x000032E4
		private static Delegate GetOnCreate_Landroid_os_Bundle_Handler()
		{
			if (LifecycleCallback.cb_onCreate_Landroid_os_Bundle_ == null)
			{
				LifecycleCallback.cb_onCreate_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(LifecycleCallback.n_OnCreate_Landroid_os_Bundle_));
			}
			return LifecycleCallback.cb_onCreate_Landroid_os_Bundle_;
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00005108 File Offset: 0x00003308
		private static void n_OnCreate_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			LifecycleCallback @object = Java.Lang.Object.GetObject<LifecycleCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bundle object2 = Java.Lang.Object.GetObject<Bundle>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnCreate(object2);
		}

		// Token: 0x06000140 RID: 320 RVA: 0x0000512C File Offset: 0x0000332C
		[Register("onCreate", "(Landroid/os/Bundle;)V", "GetOnCreate_Landroid_os_Bundle_Handler")]
		public unsafe virtual void OnCreate(Bundle p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				LifecycleCallback._members.InstanceMethods.InvokeVirtualVoidMethod("onCreate.(Landroid/os/Bundle;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00005190 File Offset: 0x00003390
		private static Delegate GetOnDestroyHandler()
		{
			if (LifecycleCallback.cb_onDestroy == null)
			{
				LifecycleCallback.cb_onDestroy = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(LifecycleCallback.n_OnDestroy));
			}
			return LifecycleCallback.cb_onDestroy;
		}

		// Token: 0x06000142 RID: 322 RVA: 0x000051B4 File Offset: 0x000033B4
		private static void n_OnDestroy(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<LifecycleCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnDestroy();
		}

		// Token: 0x06000143 RID: 323 RVA: 0x000051C3 File Offset: 0x000033C3
		[Register("onDestroy", "()V", "GetOnDestroyHandler")]
		public virtual void OnDestroy()
		{
			LifecycleCallback._members.InstanceMethods.InvokeVirtualVoidMethod("onDestroy.()V", this, null);
		}

		// Token: 0x06000144 RID: 324 RVA: 0x000051DC File Offset: 0x000033DC
		private static Delegate GetOnResumeHandler()
		{
			if (LifecycleCallback.cb_onResume == null)
			{
				LifecycleCallback.cb_onResume = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(LifecycleCallback.n_OnResume));
			}
			return LifecycleCallback.cb_onResume;
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00005200 File Offset: 0x00003400
		private static void n_OnResume(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<LifecycleCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnResume();
		}

		// Token: 0x06000146 RID: 326 RVA: 0x0000520F File Offset: 0x0000340F
		[Register("onResume", "()V", "GetOnResumeHandler")]
		public virtual void OnResume()
		{
			LifecycleCallback._members.InstanceMethods.InvokeVirtualVoidMethod("onResume.()V", this, null);
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00005228 File Offset: 0x00003428
		private static Delegate GetOnSaveInstanceState_Landroid_os_Bundle_Handler()
		{
			if (LifecycleCallback.cb_onSaveInstanceState_Landroid_os_Bundle_ == null)
			{
				LifecycleCallback.cb_onSaveInstanceState_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(LifecycleCallback.n_OnSaveInstanceState_Landroid_os_Bundle_));
			}
			return LifecycleCallback.cb_onSaveInstanceState_Landroid_os_Bundle_;
		}

		// Token: 0x06000148 RID: 328 RVA: 0x0000524C File Offset: 0x0000344C
		private static void n_OnSaveInstanceState_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			LifecycleCallback @object = Java.Lang.Object.GetObject<LifecycleCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bundle object2 = Java.Lang.Object.GetObject<Bundle>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnSaveInstanceState(object2);
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00005270 File Offset: 0x00003470
		[Register("onSaveInstanceState", "(Landroid/os/Bundle;)V", "GetOnSaveInstanceState_Landroid_os_Bundle_Handler")]
		public unsafe virtual void OnSaveInstanceState(Bundle p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				LifecycleCallback._members.InstanceMethods.InvokeVirtualVoidMethod("onSaveInstanceState.(Landroid/os/Bundle;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x0600014A RID: 330 RVA: 0x000052D4 File Offset: 0x000034D4
		private static Delegate GetOnStartHandler()
		{
			if (LifecycleCallback.cb_onStart == null)
			{
				LifecycleCallback.cb_onStart = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(LifecycleCallback.n_OnStart));
			}
			return LifecycleCallback.cb_onStart;
		}

		// Token: 0x0600014B RID: 331 RVA: 0x000052F8 File Offset: 0x000034F8
		private static void n_OnStart(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<LifecycleCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnStart();
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00005307 File Offset: 0x00003507
		[Register("onStart", "()V", "GetOnStartHandler")]
		public virtual void OnStart()
		{
			LifecycleCallback._members.InstanceMethods.InvokeVirtualVoidMethod("onStart.()V", this, null);
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00005320 File Offset: 0x00003520
		private static Delegate GetOnStopHandler()
		{
			if (LifecycleCallback.cb_onStop == null)
			{
				LifecycleCallback.cb_onStop = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(LifecycleCallback.n_OnStop));
			}
			return LifecycleCallback.cb_onStop;
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00005344 File Offset: 0x00003544
		private static void n_OnStop(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<LifecycleCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnStop();
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00005353 File Offset: 0x00003553
		[Register("onStop", "()V", "GetOnStopHandler")]
		public virtual void OnStop()
		{
			LifecycleCallback._members.InstanceMethods.InvokeVirtualVoidMethod("onStop.()V", this, null);
		}

		// Token: 0x0400003D RID: 61
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/api/internal/LifecycleCallback", typeof(LifecycleCallback));

		// Token: 0x0400003E RID: 62
		private static Delegate cb_getActivity;

		// Token: 0x0400003F RID: 63
		private static Delegate cb_dump_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_;

		// Token: 0x04000040 RID: 64
		private static Delegate cb_onActivityResult_IILandroid_content_Intent_;

		// Token: 0x04000041 RID: 65
		private static Delegate cb_onCreate_Landroid_os_Bundle_;

		// Token: 0x04000042 RID: 66
		private static Delegate cb_onDestroy;

		// Token: 0x04000043 RID: 67
		private static Delegate cb_onResume;

		// Token: 0x04000044 RID: 68
		private static Delegate cb_onSaveInstanceState_Landroid_os_Bundle_;

		// Token: 0x04000045 RID: 69
		private static Delegate cb_onStart;

		// Token: 0x04000046 RID: 70
		private static Delegate cb_onStop;
	}
}
