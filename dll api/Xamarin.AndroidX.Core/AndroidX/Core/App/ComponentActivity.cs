using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.App;
using Android.Runtime;
using Android.Views;
using AndroidX.Core.View;
using AndroidX.Lifecycle;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Core.App
{
	// Token: 0x02000066 RID: 102
	[Register("androidx/core/app/ComponentActivity", DoNotGenerateAcw = true)]
	public class ComponentActivity : Activity, KeyEventDispatcher.IComponent, IJavaObject, IDisposable, IJavaPeerable, ILifecycleOwner
	{
		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060003F4 RID: 1012 RVA: 0x0000B950 File Offset: 0x00009B50
		internal static IntPtr class_ref
		{
			get
			{
				return ComponentActivity._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060003F5 RID: 1013 RVA: 0x0000B974 File Offset: 0x00009B74
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ComponentActivity._members;
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060003F6 RID: 1014 RVA: 0x0000B97C File Offset: 0x00009B7C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ComponentActivity._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060003F7 RID: 1015 RVA: 0x0000B9A0 File Offset: 0x00009BA0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ComponentActivity._members.ManagedPeerType;
			}
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x0000B9AC File Offset: 0x00009BAC
		protected ComponentActivity(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x0000B9B8 File Offset: 0x00009BB8
		[Register(".ctor", "()V", "")]
		public ComponentActivity() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(ComponentActivity._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			ComponentActivity._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x0000BA26 File Offset: 0x00009C26
		private static Delegate GetGetLifecycleHandler()
		{
			if (ComponentActivity.cb_getLifecycle == null)
			{
				ComponentActivity.cb_getLifecycle = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ComponentActivity.n_GetLifecycle));
			}
			return ComponentActivity.cb_getLifecycle;
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x0000BA4A File Offset: 0x00009C4A
		private static IntPtr n_GetLifecycle(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ComponentActivity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Lifecycle);
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060003FC RID: 1020 RVA: 0x0000BA60 File Offset: 0x00009C60
		public virtual Lifecycle Lifecycle
		{
			[Register("getLifecycle", "()Landroidx/lifecycle/Lifecycle;", "GetGetLifecycleHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Lifecycle>(ComponentActivity._members.InstanceMethods.InvokeVirtualObjectMethod("getLifecycle.()Landroidx/lifecycle/Lifecycle;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x0000BA92 File Offset: 0x00009C92
		private static Delegate GetGetExtraData_Ljava_lang_Class_Handler()
		{
			if (ComponentActivity.cb_getExtraData_Ljava_lang_Class_ == null)
			{
				ComponentActivity.cb_getExtraData_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ComponentActivity.n_GetExtraData_Ljava_lang_Class_));
			}
			return ComponentActivity.cb_getExtraData_Ljava_lang_Class_;
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x0000BAB8 File Offset: 0x00009CB8
		private static IntPtr n_GetExtraData_Ljava_lang_Class_(IntPtr jnienv, IntPtr native__this, IntPtr native_extraDataClass)
		{
			ComponentActivity @object = Java.Lang.Object.GetObject<ComponentActivity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Java.Lang.Object.GetObject<Class>(native_extraDataClass, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetExtraData(object2));
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x0000BAE0 File Offset: 0x00009CE0
		[Register("getExtraData", "(Ljava/lang/Class;)Landroidx/core/app/ComponentActivity$ExtraData;", "GetGetExtraData_Ljava_lang_Class_Handler")]
		[JavaTypeParameters(new string[]
		{
			"T extends androidx.core.app.ComponentActivity.ExtraData"
		})]
		public unsafe virtual Java.Lang.Object GetExtraData(Class extraDataClass)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((extraDataClass == null) ? IntPtr.Zero : extraDataClass.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(ComponentActivity._members.InstanceMethods.InvokeVirtualObjectMethod("getExtraData.(Ljava/lang/Class;)Landroidx/core/app/ComponentActivity$ExtraData;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(extraDataClass);
			}
			return @object;
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x0000BB54 File Offset: 0x00009D54
		private static Delegate GetPutExtraData_Landroidx_core_app_ComponentActivity_ExtraData_Handler()
		{
			if (ComponentActivity.cb_putExtraData_Landroidx_core_app_ComponentActivity_ExtraData_ == null)
			{
				ComponentActivity.cb_putExtraData_Landroidx_core_app_ComponentActivity_ExtraData_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ComponentActivity.n_PutExtraData_Landroidx_core_app_ComponentActivity_ExtraData_));
			}
			return ComponentActivity.cb_putExtraData_Landroidx_core_app_ComponentActivity_ExtraData_;
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x0000BB78 File Offset: 0x00009D78
		private static void n_PutExtraData_Landroidx_core_app_ComponentActivity_ExtraData_(IntPtr jnienv, IntPtr native__this, IntPtr native_extraData)
		{
			ComponentActivity @object = Java.Lang.Object.GetObject<ComponentActivity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ComponentActivity.ExtraData object2 = Java.Lang.Object.GetObject<ComponentActivity.ExtraData>(native_extraData, JniHandleOwnership.DoNotTransfer);
			@object.PutExtraData(object2);
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x0000BB9C File Offset: 0x00009D9C
		[Register("putExtraData", "(Landroidx/core/app/ComponentActivity$ExtraData;)V", "GetPutExtraData_Landroidx_core_app_ComponentActivity_ExtraData_Handler")]
		public unsafe virtual void PutExtraData(ComponentActivity.ExtraData extraData)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((extraData == null) ? IntPtr.Zero : extraData.Handle);
				ComponentActivity._members.InstanceMethods.InvokeVirtualVoidMethod("putExtraData.(Landroidx/core/app/ComponentActivity$ExtraData;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(extraData);
			}
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x0000BC00 File Offset: 0x00009E00
		[Register("shouldDumpInternalState", "([Ljava/lang/String;)Z", "")]
		protected unsafe bool ShouldDumpInternalState(string[] args)
		{
			IntPtr intPtr = JNIEnv.NewArray(args);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = ComponentActivity._members.InstanceMethods.InvokeNonvirtualBooleanMethod("shouldDumpInternalState.([Ljava/lang/String;)Z", this, ptr);
			}
			finally
			{
				if (args != null)
				{
					JNIEnv.CopyArray(intPtr, args);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(args);
			}
			return result;
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x0000BC70 File Offset: 0x00009E70
		private static Delegate GetSuperDispatchKeyEvent_Landroid_view_KeyEvent_Handler()
		{
			if (ComponentActivity.cb_superDispatchKeyEvent_Landroid_view_KeyEvent_ == null)
			{
				ComponentActivity.cb_superDispatchKeyEvent_Landroid_view_KeyEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(ComponentActivity.n_SuperDispatchKeyEvent_Landroid_view_KeyEvent_));
			}
			return ComponentActivity.cb_superDispatchKeyEvent_Landroid_view_KeyEvent_;
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x0000BC94 File Offset: 0x00009E94
		private static bool n_SuperDispatchKeyEvent_Landroid_view_KeyEvent_(IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			ComponentActivity @object = Java.Lang.Object.GetObject<ComponentActivity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			KeyEvent object2 = Java.Lang.Object.GetObject<KeyEvent>(native_e, JniHandleOwnership.DoNotTransfer);
			return @object.SuperDispatchKeyEvent(object2);
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x0000BCB8 File Offset: 0x00009EB8
		[Register("superDispatchKeyEvent", "(Landroid/view/KeyEvent;)Z", "GetSuperDispatchKeyEvent_Landroid_view_KeyEvent_Handler")]
		public unsafe virtual bool SuperDispatchKeyEvent(KeyEvent e)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((e == null) ? IntPtr.Zero : e.Handle);
				result = ComponentActivity._members.InstanceMethods.InvokeVirtualBooleanMethod("superDispatchKeyEvent.(Landroid/view/KeyEvent;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(e);
			}
			return result;
		}

		// Token: 0x0400010A RID: 266
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/app/ComponentActivity", typeof(ComponentActivity));

		// Token: 0x0400010B RID: 267
		private static Delegate cb_getLifecycle;

		// Token: 0x0400010C RID: 268
		private static Delegate cb_getExtraData_Ljava_lang_Class_;

		// Token: 0x0400010D RID: 269
		private static Delegate cb_putExtraData_Landroidx_core_app_ComponentActivity_ExtraData_;

		// Token: 0x0400010E RID: 270
		private static Delegate cb_superDispatchKeyEvent_Landroid_view_KeyEvent_;

		// Token: 0x02000067 RID: 103
		[Register("androidx/core/app/ComponentActivity$ExtraData", DoNotGenerateAcw = true)]
		public class ExtraData : Java.Lang.Object
		{
			// Token: 0x170000AC RID: 172
			// (get) Token: 0x06000408 RID: 1032 RVA: 0x0000BD3C File Offset: 0x00009F3C
			internal static IntPtr class_ref
			{
				get
				{
					return ComponentActivity.ExtraData._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000AD RID: 173
			// (get) Token: 0x06000409 RID: 1033 RVA: 0x0000BD60 File Offset: 0x00009F60
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ComponentActivity.ExtraData._members;
				}
			}

			// Token: 0x170000AE RID: 174
			// (get) Token: 0x0600040A RID: 1034 RVA: 0x0000BD68 File Offset: 0x00009F68
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return ComponentActivity.ExtraData._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000AF RID: 175
			// (get) Token: 0x0600040B RID: 1035 RVA: 0x0000BD8C File Offset: 0x00009F8C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ComponentActivity.ExtraData._members.ManagedPeerType;
				}
			}

			// Token: 0x0600040C RID: 1036 RVA: 0x00002384 File Offset: 0x00000584
			protected ExtraData(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x0600040D RID: 1037 RVA: 0x0000BD98 File Offset: 0x00009F98
			[Register(".ctor", "()V", "")]
			public ExtraData() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(ComponentActivity.ExtraData._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				ComponentActivity.ExtraData._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x0400010F RID: 271
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/app/ComponentActivity$ExtraData", typeof(ComponentActivity.ExtraData));
		}
	}
}
