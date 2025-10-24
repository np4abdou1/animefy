using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace AndroidX.SavedState
{
	// Token: 0x02000008 RID: 8
	[Register("androidx/savedstate/SavedStateRegistry", DoNotGenerateAcw = true)]
	public sealed class SavedStateRegistry : Java.Lang.Object
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000018 RID: 24 RVA: 0x0000228C File Offset: 0x0000048C
		internal static IntPtr class_ref
		{
			get
			{
				return SavedStateRegistry._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000019 RID: 25 RVA: 0x000022B0 File Offset: 0x000004B0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SavedStateRegistry._members;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600001A RID: 26 RVA: 0x000022B8 File Offset: 0x000004B8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SavedStateRegistry._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600001B RID: 27 RVA: 0x000022DC File Offset: 0x000004DC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SavedStateRegistry._members.ManagedPeerType;
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000022E8 File Offset: 0x000004E8
		internal SavedStateRegistry(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600001D RID: 29 RVA: 0x000022F2 File Offset: 0x000004F2
		public bool IsRestored
		{
			[Register("isRestored", "()Z", "")]
			get
			{
				return SavedStateRegistry._members.InstanceMethods.InvokeNonvirtualBooleanMethod("isRestored.()Z", this, null);
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x0000230C File Offset: 0x0000050C
		[Register("consumeRestoredStateForKey", "(Ljava/lang/String;)Landroid/os/Bundle;", "")]
		public unsafe Bundle ConsumeRestoredStateForKey(string key)
		{
			IntPtr intPtr = JNIEnv.NewString(key);
			Bundle @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Bundle>(SavedStateRegistry._members.InstanceMethods.InvokeNonvirtualObjectMethod("consumeRestoredStateForKey.(Ljava/lang/String;)Landroid/os/Bundle;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002378 File Offset: 0x00000578
		[Register("getSavedStateProvider", "(Ljava/lang/String;)Landroidx/savedstate/SavedStateRegistry$SavedStateProvider;", "")]
		public unsafe SavedStateRegistry.ISavedStateProvider GetSavedStateProvider(string key)
		{
			IntPtr intPtr = JNIEnv.NewString(key);
			SavedStateRegistry.ISavedStateProvider @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<SavedStateRegistry.ISavedStateProvider>(SavedStateRegistry._members.InstanceMethods.InvokeNonvirtualObjectMethod("getSavedStateProvider.(Ljava/lang/String;)Landroidx/savedstate/SavedStateRegistry$SavedStateProvider;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000023E4 File Offset: 0x000005E4
		[Register("performSave", "(Landroid/os/Bundle;)V", "")]
		public unsafe void PerformSave(Bundle outBundle)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((outBundle == null) ? IntPtr.Zero : outBundle.Handle);
				SavedStateRegistry._members.InstanceMethods.InvokeNonvirtualVoidMethod("performSave.(Landroid/os/Bundle;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(outBundle);
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002448 File Offset: 0x00000648
		[Register("registerSavedStateProvider", "(Ljava/lang/String;Landroidx/savedstate/SavedStateRegistry$SavedStateProvider;)V", "")]
		public unsafe void RegisterSavedStateProvider(string key, SavedStateRegistry.ISavedStateProvider provider)
		{
			IntPtr intPtr = JNIEnv.NewString(key);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((provider == null) ? IntPtr.Zero : ((Java.Lang.Object)provider).Handle);
				SavedStateRegistry._members.InstanceMethods.InvokeNonvirtualVoidMethod("registerSavedStateProvider.(Ljava/lang/String;Landroidx/savedstate/SavedStateRegistry$SavedStateProvider;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(provider);
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000024D0 File Offset: 0x000006D0
		[Register("runOnNextRecreation", "(Ljava/lang/Class;)V", "")]
		public unsafe void RunOnNextRecreation(Class clazz)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((clazz == null) ? IntPtr.Zero : clazz.Handle);
				SavedStateRegistry._members.InstanceMethods.InvokeNonvirtualVoidMethod("runOnNextRecreation.(Ljava/lang/Class;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(clazz);
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002534 File Offset: 0x00000734
		[Register("unregisterSavedStateProvider", "(Ljava/lang/String;)V", "")]
		public unsafe void UnregisterSavedStateProvider(string key)
		{
			IntPtr intPtr = JNIEnv.NewString(key);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				SavedStateRegistry._members.InstanceMethods.InvokeNonvirtualVoidMethod("unregisterSavedStateProvider.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x04000009 RID: 9
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/savedstate/SavedStateRegistry", typeof(SavedStateRegistry));

		// Token: 0x02000009 RID: 9
		[Register("androidx/savedstate/SavedStateRegistry$SavedStateProvider", "", "AndroidX.SavedState.SavedStateRegistry/ISavedStateProviderInvoker")]
		public interface ISavedStateProvider : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06000025 RID: 37
			[Register("saveState", "()Landroid/os/Bundle;", "GetSaveStateHandler:AndroidX.SavedState.SavedStateRegistry/ISavedStateProviderInvoker, Xamarin.AndroidX.SavedState")]
			Bundle SaveState();
		}

		// Token: 0x0200000A RID: 10
		[Register("androidx/savedstate/SavedStateRegistry$SavedStateProvider", DoNotGenerateAcw = true)]
		internal class ISavedStateProviderInvoker : Java.Lang.Object, SavedStateRegistry.ISavedStateProvider, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x1700000D RID: 13
			// (get) Token: 0x06000026 RID: 38 RVA: 0x000025AC File Offset: 0x000007AC
			private static IntPtr java_class_ref
			{
				get
				{
					return SavedStateRegistry.ISavedStateProviderInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700000E RID: 14
			// (get) Token: 0x06000027 RID: 39 RVA: 0x000025D0 File Offset: 0x000007D0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return SavedStateRegistry.ISavedStateProviderInvoker._members;
				}
			}

			// Token: 0x1700000F RID: 15
			// (get) Token: 0x06000028 RID: 40 RVA: 0x000025D7 File Offset: 0x000007D7
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x17000010 RID: 16
			// (get) Token: 0x06000029 RID: 41 RVA: 0x000025DF File Offset: 0x000007DF
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return SavedStateRegistry.ISavedStateProviderInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x0600002A RID: 42 RVA: 0x000025EB File Offset: 0x000007EB
			public static SavedStateRegistry.ISavedStateProvider GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<SavedStateRegistry.ISavedStateProvider>(handle, transfer);
			}

			// Token: 0x0600002B RID: 43 RVA: 0x000025F4 File Offset: 0x000007F4
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, SavedStateRegistry.ISavedStateProviderInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.savedstate.SavedStateRegistry.SavedStateProvider'.");
				}
				return handle;
			}

			// Token: 0x0600002C RID: 44 RVA: 0x0000261F File Offset: 0x0000081F
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x0600002D RID: 45 RVA: 0x00002650 File Offset: 0x00000850
			public ISavedStateProviderInvoker(IntPtr handle, JniHandleOwnership transfer) : base(SavedStateRegistry.ISavedStateProviderInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x0600002E RID: 46 RVA: 0x00002688 File Offset: 0x00000888
			private static Delegate GetSaveStateHandler()
			{
				if (SavedStateRegistry.ISavedStateProviderInvoker.cb_saveState == null)
				{
					SavedStateRegistry.ISavedStateProviderInvoker.cb_saveState = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(SavedStateRegistry.ISavedStateProviderInvoker.n_SaveState));
				}
				return SavedStateRegistry.ISavedStateProviderInvoker.cb_saveState;
			}

			// Token: 0x0600002F RID: 47 RVA: 0x000026AC File Offset: 0x000008AC
			private static IntPtr n_SaveState(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<SavedStateRegistry.ISavedStateProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SaveState());
			}

			// Token: 0x06000030 RID: 48 RVA: 0x000026C0 File Offset: 0x000008C0
			public Bundle SaveState()
			{
				if (this.id_saveState == IntPtr.Zero)
				{
					this.id_saveState = JNIEnv.GetMethodID(this.class_ref, "saveState", "()Landroid/os/Bundle;");
				}
				return Java.Lang.Object.GetObject<Bundle>(JNIEnv.CallObjectMethod(base.Handle, this.id_saveState), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x0400000A RID: 10
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/savedstate/SavedStateRegistry$SavedStateProvider", typeof(SavedStateRegistry.ISavedStateProviderInvoker));

			// Token: 0x0400000B RID: 11
			private IntPtr class_ref;

			// Token: 0x0400000C RID: 12
			private static Delegate cb_saveState;

			// Token: 0x0400000D RID: 13
			private IntPtr id_saveState;
		}
	}
}
