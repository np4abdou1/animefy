using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using AndroidX.Lifecycle.ViewModels;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Lifecycle
{
	// Token: 0x02000010 RID: 16
	[Register("androidx/lifecycle/ViewModelProvider", DoNotGenerateAcw = true)]
	public class ViewModelProvider : Java.Lang.Object
	{
		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000048 RID: 72 RVA: 0x000026E4 File Offset: 0x000008E4
		internal static IntPtr class_ref
		{
			get
			{
				return ViewModelProvider._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000049 RID: 73 RVA: 0x00002708 File Offset: 0x00000908
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ViewModelProvider._members;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600004A RID: 74 RVA: 0x00002710 File Offset: 0x00000910
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ViewModelProvider._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600004B RID: 75 RVA: 0x00002734 File Offset: 0x00000934
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ViewModelProvider._members.ManagedPeerType;
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002464 File Offset: 0x00000664
		protected ViewModelProvider(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002740 File Offset: 0x00000940
		[Register(".ctor", "(Landroidx/lifecycle/ViewModelStore;Landroidx/lifecycle/ViewModelProvider$Factory;)V", "")]
		public unsafe ViewModelProvider(ViewModelStore store, ViewModelProvider.IFactory factory) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((store == null) ? IntPtr.Zero : store.Handle);
				ptr[1] = new JniArgumentValue((factory == null) ? IntPtr.Zero : ((Java.Lang.Object)factory).Handle);
				base.SetHandle(ViewModelProvider._members.InstanceMethods.StartCreateInstance("(Landroidx/lifecycle/ViewModelStore;Landroidx/lifecycle/ViewModelProvider$Factory;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ViewModelProvider._members.InstanceMethods.FinishCreateInstance("(Landroidx/lifecycle/ViewModelStore;Landroidx/lifecycle/ViewModelProvider$Factory;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(store);
				GC.KeepAlive(factory);
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x0000281C File Offset: 0x00000A1C
		[Register(".ctor", "(Landroidx/lifecycle/ViewModelStore;Landroidx/lifecycle/ViewModelProvider$Factory;Landroidx/lifecycle/viewmodel/CreationExtras;)V", "")]
		public unsafe ViewModelProvider(ViewModelStore store, ViewModelProvider.IFactory factory, CreationExtras defaultCreationExtras) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((store == null) ? IntPtr.Zero : store.Handle);
				ptr[1] = new JniArgumentValue((factory == null) ? IntPtr.Zero : ((Java.Lang.Object)factory).Handle);
				ptr[2] = new JniArgumentValue((defaultCreationExtras == null) ? IntPtr.Zero : defaultCreationExtras.Handle);
				base.SetHandle(ViewModelProvider._members.InstanceMethods.StartCreateInstance("(Landroidx/lifecycle/ViewModelStore;Landroidx/lifecycle/ViewModelProvider$Factory;Landroidx/lifecycle/viewmodel/CreationExtras;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ViewModelProvider._members.InstanceMethods.FinishCreateInstance("(Landroidx/lifecycle/ViewModelStore;Landroidx/lifecycle/ViewModelProvider$Factory;Landroidx/lifecycle/viewmodel/CreationExtras;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(store);
				GC.KeepAlive(factory);
				GC.KeepAlive(defaultCreationExtras);
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002924 File Offset: 0x00000B24
		[Register(".ctor", "(Landroidx/lifecycle/ViewModelStoreOwner;)V", "")]
		public unsafe ViewModelProvider(IViewModelStoreOwner owner) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((owner == null) ? IntPtr.Zero : ((Java.Lang.Object)owner).Handle);
				base.SetHandle(ViewModelProvider._members.InstanceMethods.StartCreateInstance("(Landroidx/lifecycle/ViewModelStoreOwner;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ViewModelProvider._members.InstanceMethods.FinishCreateInstance("(Landroidx/lifecycle/ViewModelStoreOwner;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(owner);
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000029D8 File Offset: 0x00000BD8
		[Register(".ctor", "(Landroidx/lifecycle/ViewModelStoreOwner;Landroidx/lifecycle/ViewModelProvider$Factory;)V", "")]
		public unsafe ViewModelProvider(IViewModelStoreOwner owner, ViewModelProvider.IFactory factory) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((owner == null) ? IntPtr.Zero : ((Java.Lang.Object)owner).Handle);
				ptr[1] = new JniArgumentValue((factory == null) ? IntPtr.Zero : ((Java.Lang.Object)factory).Handle);
				base.SetHandle(ViewModelProvider._members.InstanceMethods.StartCreateInstance("(Landroidx/lifecycle/ViewModelStoreOwner;Landroidx/lifecycle/ViewModelProvider$Factory;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ViewModelProvider._members.InstanceMethods.FinishCreateInstance("(Landroidx/lifecycle/ViewModelStoreOwner;Landroidx/lifecycle/ViewModelProvider$Factory;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(owner);
				GC.KeepAlive(factory);
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002AB8 File Offset: 0x00000CB8
		private static Delegate GetGet_Ljava_lang_Class_Handler()
		{
			if (ViewModelProvider.cb_get_Ljava_lang_Class_ == null)
			{
				ViewModelProvider.cb_get_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ViewModelProvider.n_Get_Ljava_lang_Class_));
			}
			return ViewModelProvider.cb_get_Ljava_lang_Class_;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002ADC File Offset: 0x00000CDC
		private static IntPtr n_Get_Ljava_lang_Class_(IntPtr jnienv, IntPtr native__this, IntPtr native_modelClass)
		{
			ViewModelProvider @object = Java.Lang.Object.GetObject<ViewModelProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Java.Lang.Object.GetObject<Class>(native_modelClass, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Get(object2));
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002B04 File Offset: 0x00000D04
		[Register("get", "(Ljava/lang/Class;)Landroidx/lifecycle/ViewModel;", "GetGet_Ljava_lang_Class_Handler")]
		[JavaTypeParameters(new string[]
		{
			"T extends androidx.lifecycle.ViewModel"
		})]
		public unsafe virtual Java.Lang.Object Get(Class modelClass)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((modelClass == null) ? IntPtr.Zero : modelClass.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(ViewModelProvider._members.InstanceMethods.InvokeVirtualObjectMethod("get.(Ljava/lang/Class;)Landroidx/lifecycle/ViewModel;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(modelClass);
			}
			return @object;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002B78 File Offset: 0x00000D78
		private static Delegate GetGet_Ljava_lang_String_Ljava_lang_Class_Handler()
		{
			if (ViewModelProvider.cb_get_Ljava_lang_String_Ljava_lang_Class_ == null)
			{
				ViewModelProvider.cb_get_Ljava_lang_String_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(ViewModelProvider.n_Get_Ljava_lang_String_Ljava_lang_Class_));
			}
			return ViewModelProvider.cb_get_Ljava_lang_String_Ljava_lang_Class_;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002B9C File Offset: 0x00000D9C
		private static IntPtr n_Get_Ljava_lang_String_Ljava_lang_Class_(IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_modelClass)
		{
			ViewModelProvider @object = Java.Lang.Object.GetObject<ViewModelProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_key, JniHandleOwnership.DoNotTransfer);
			Class object2 = Java.Lang.Object.GetObject<Class>(native_modelClass, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Get(@string, object2));
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002BD0 File Offset: 0x00000DD0
		[Register("get", "(Ljava/lang/String;Ljava/lang/Class;)Landroidx/lifecycle/ViewModel;", "GetGet_Ljava_lang_String_Ljava_lang_Class_Handler")]
		[JavaTypeParameters(new string[]
		{
			"T extends androidx.lifecycle.ViewModel"
		})]
		public unsafe virtual Java.Lang.Object Get(string key, Class modelClass)
		{
			IntPtr intPtr = JNIEnv.NewString(key);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((modelClass == null) ? IntPtr.Zero : modelClass.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(ViewModelProvider._members.InstanceMethods.InvokeVirtualObjectMethod("get.(Ljava/lang/String;Ljava/lang/Class;)Landroidx/lifecycle/ViewModel;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(modelClass);
			}
			return @object;
		}

		// Token: 0x04000011 RID: 17
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/lifecycle/ViewModelProvider", typeof(ViewModelProvider));

		// Token: 0x04000012 RID: 18
		private static Delegate cb_get_Ljava_lang_Class_;

		// Token: 0x04000013 RID: 19
		private static Delegate cb_get_Ljava_lang_String_Ljava_lang_Class_;

		// Token: 0x02000011 RID: 17
		[Register("androidx/lifecycle/ViewModelProvider$Factory$Companion", DoNotGenerateAcw = true)]
		public sealed class FactoryCompanion : Java.Lang.Object
		{
			// Token: 0x17000018 RID: 24
			// (get) Token: 0x06000058 RID: 88 RVA: 0x00002C80 File Offset: 0x00000E80
			internal static IntPtr class_ref
			{
				get
				{
					return ViewModelProvider.FactoryCompanion._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000019 RID: 25
			// (get) Token: 0x06000059 RID: 89 RVA: 0x00002CA4 File Offset: 0x00000EA4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ViewModelProvider.FactoryCompanion._members;
				}
			}

			// Token: 0x1700001A RID: 26
			// (get) Token: 0x0600005A RID: 90 RVA: 0x00002CAC File Offset: 0x00000EAC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return ViewModelProvider.FactoryCompanion._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700001B RID: 27
			// (get) Token: 0x0600005B RID: 91 RVA: 0x00002CD0 File Offset: 0x00000ED0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ViewModelProvider.FactoryCompanion._members.ManagedPeerType;
				}
			}

			// Token: 0x0600005C RID: 92 RVA: 0x00002464 File Offset: 0x00000664
			internal FactoryCompanion(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x0600005D RID: 93 RVA: 0x00002CDC File Offset: 0x00000EDC
			[Register("from", "([Landroidx/lifecycle/viewmodel/ViewModelInitializer;)Landroidx/lifecycle/ViewModelProvider$Factory;", "")]
			public unsafe ViewModelProvider.IFactory From(params ViewModelInitializer[] initializers)
			{
				IntPtr intPtr = JNIEnv.NewArray<ViewModelInitializer>(initializers);
				ViewModelProvider.IFactory @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<ViewModelProvider.IFactory>(ViewModelProvider.FactoryCompanion._members.InstanceMethods.InvokeNonvirtualObjectMethod("from.([Landroidx/lifecycle/viewmodel/ViewModelInitializer;)Landroidx/lifecycle/ViewModelProvider$Factory;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					if (initializers != null)
					{
						JNIEnv.CopyArray<ViewModelInitializer>(intPtr, initializers);
						JNIEnv.DeleteLocalRef(intPtr);
					}
					GC.KeepAlive(initializers);
				}
				return @object;
			}

			// Token: 0x04000014 RID: 20
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/lifecycle/ViewModelProvider$Factory$Companion", typeof(ViewModelProvider.FactoryCompanion));
		}

		// Token: 0x02000012 RID: 18
		[Register("androidx/lifecycle/ViewModelProvider$Factory", "", "AndroidX.Lifecycle.ViewModelProvider/IFactoryInvoker")]
		public interface IFactory : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x1700001C RID: 28
			// (get) Token: 0x0600005F RID: 95 RVA: 0x00002D74 File Offset: 0x00000F74
			[Register("Companion")]
			ViewModelProvider.FactoryCompanion Companion
			{
				get
				{
					return Java.Lang.Object.GetObject<ViewModelProvider.FactoryCompanion>(ViewModelProvider.IFactory._members.StaticFields.GetObjectValue("Companion.Landroidx/lifecycle/ViewModelProvider$Factory$Companion;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x06000060 RID: 96 RVA: 0x00002DA3 File Offset: 0x00000FA3
			private static Delegate GetCreate_Ljava_lang_Class_Handler()
			{
				if (ViewModelProvider.IFactory.cb_create_Ljava_lang_Class_ == null)
				{
					ViewModelProvider.IFactory.cb_create_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ViewModelProvider.IFactory.n_Create_Ljava_lang_Class_));
				}
				return ViewModelProvider.IFactory.cb_create_Ljava_lang_Class_;
			}

			// Token: 0x06000061 RID: 97 RVA: 0x00002DC8 File Offset: 0x00000FC8
			private static IntPtr n_Create_Ljava_lang_Class_(IntPtr jnienv, IntPtr native__this, IntPtr native_modelClass)
			{
				ViewModelProvider.IFactory @object = Java.Lang.Object.GetObject<ViewModelProvider.IFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Class object2 = Java.Lang.Object.GetObject<Class>(native_modelClass, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.Create(object2));
			}

			// Token: 0x06000062 RID: 98 RVA: 0x00002DF0 File Offset: 0x00000FF0
			[Register("create", "(Ljava/lang/Class;)Landroidx/lifecycle/ViewModel;", "GetCreate_Ljava_lang_Class_Handler:AndroidX.Lifecycle.ViewModelProvider/IFactory, Xamarin.AndroidX.Lifecycle.ViewModel")]
			[JavaTypeParameters(new string[]
			{
				"T extends androidx.lifecycle.ViewModel"
			})]
			unsafe Java.Lang.Object Create(Class modelClass)
			{
				Java.Lang.Object @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((modelClass == null) ? IntPtr.Zero : modelClass.Handle);
					@object = Java.Lang.Object.GetObject<Java.Lang.Object>(ViewModelProvider.IFactory._members.InstanceMethods.InvokeVirtualObjectMethod("create.(Ljava/lang/Class;)Landroidx/lifecycle/ViewModel;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(modelClass);
				}
				return @object;
			}

			// Token: 0x06000063 RID: 99 RVA: 0x00002E64 File Offset: 0x00001064
			private static Delegate GetCreate_Ljava_lang_Class_Landroidx_lifecycle_viewmodel_CreationExtras_Handler()
			{
				if (ViewModelProvider.IFactory.cb_create_Ljava_lang_Class_Landroidx_lifecycle_viewmodel_CreationExtras_ == null)
				{
					ViewModelProvider.IFactory.cb_create_Ljava_lang_Class_Landroidx_lifecycle_viewmodel_CreationExtras_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(ViewModelProvider.IFactory.n_Create_Ljava_lang_Class_Landroidx_lifecycle_viewmodel_CreationExtras_));
				}
				return ViewModelProvider.IFactory.cb_create_Ljava_lang_Class_Landroidx_lifecycle_viewmodel_CreationExtras_;
			}

			// Token: 0x06000064 RID: 100 RVA: 0x00002E88 File Offset: 0x00001088
			private static IntPtr n_Create_Ljava_lang_Class_Landroidx_lifecycle_viewmodel_CreationExtras_(IntPtr jnienv, IntPtr native__this, IntPtr native_modelClass, IntPtr native_extras)
			{
				ViewModelProvider.IFactory @object = Java.Lang.Object.GetObject<ViewModelProvider.IFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Class object2 = Java.Lang.Object.GetObject<Class>(native_modelClass, JniHandleOwnership.DoNotTransfer);
				CreationExtras object3 = Java.Lang.Object.GetObject<CreationExtras>(native_extras, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.Create(object2, object3));
			}

			// Token: 0x06000065 RID: 101 RVA: 0x00002EBC File Offset: 0x000010BC
			[Register("create", "(Ljava/lang/Class;Landroidx/lifecycle/viewmodel/CreationExtras;)Landroidx/lifecycle/ViewModel;", "GetCreate_Ljava_lang_Class_Landroidx_lifecycle_viewmodel_CreationExtras_Handler:AndroidX.Lifecycle.ViewModelProvider/IFactory, Xamarin.AndroidX.Lifecycle.ViewModel")]
			[JavaTypeParameters(new string[]
			{
				"T extends androidx.lifecycle.ViewModel"
			})]
			unsafe Java.Lang.Object Create(Class modelClass, CreationExtras extras)
			{
				Java.Lang.Object @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((modelClass == null) ? IntPtr.Zero : modelClass.Handle);
					ptr[1] = new JniArgumentValue((extras == null) ? IntPtr.Zero : extras.Handle);
					@object = Java.Lang.Object.GetObject<Java.Lang.Object>(ViewModelProvider.IFactory._members.InstanceMethods.InvokeVirtualObjectMethod("create.(Ljava/lang/Class;Landroidx/lifecycle/viewmodel/CreationExtras;)Landroidx/lifecycle/ViewModel;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(modelClass);
					GC.KeepAlive(extras);
				}
				return @object;
			}

			// Token: 0x06000066 RID: 102 RVA: 0x00002F58 File Offset: 0x00001158
			[Register("from", "([Landroidx/lifecycle/viewmodel/ViewModelInitializer;)Landroidx/lifecycle/ViewModelProvider$Factory;", "")]
			public unsafe static ViewModelProvider.IFactory From(params ViewModelInitializer[] initializers)
			{
				IntPtr intPtr = JNIEnv.NewArray<ViewModelInitializer>(initializers);
				ViewModelProvider.IFactory @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<ViewModelProvider.IFactory>(ViewModelProvider.IFactory._members.StaticMethods.InvokeObjectMethod("from.([Landroidx/lifecycle/viewmodel/ViewModelInitializer;)Landroidx/lifecycle/ViewModelProvider$Factory;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					if (initializers != null)
					{
						JNIEnv.CopyArray<ViewModelInitializer>(intPtr, initializers);
						JNIEnv.DeleteLocalRef(intPtr);
					}
					GC.KeepAlive(initializers);
				}
				return @object;
			}

			// Token: 0x04000015 RID: 21
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/lifecycle/ViewModelProvider$Factory", typeof(ViewModelProvider.IFactory), true);

			// Token: 0x04000016 RID: 22
			private static Delegate cb_create_Ljava_lang_Class_;

			// Token: 0x04000017 RID: 23
			private static Delegate cb_create_Ljava_lang_Class_Landroidx_lifecycle_viewmodel_CreationExtras_;
		}

		// Token: 0x02000013 RID: 19
		[Register("androidx/lifecycle/ViewModelProvider$Factory", DoNotGenerateAcw = true)]
		internal class IFactoryInvoker : Java.Lang.Object, ViewModelProvider.IFactory, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x1700001D RID: 29
			// (get) Token: 0x06000068 RID: 104 RVA: 0x00002FF0 File Offset: 0x000011F0
			private static IntPtr java_class_ref
			{
				get
				{
					return ViewModelProvider.IFactoryInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700001E RID: 30
			// (get) Token: 0x06000069 RID: 105 RVA: 0x00003014 File Offset: 0x00001214
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ViewModelProvider.IFactoryInvoker._members;
				}
			}

			// Token: 0x1700001F RID: 31
			// (get) Token: 0x0600006A RID: 106 RVA: 0x0000301B File Offset: 0x0000121B
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x17000020 RID: 32
			// (get) Token: 0x0600006B RID: 107 RVA: 0x00003023 File Offset: 0x00001223
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ViewModelProvider.IFactoryInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x0600006C RID: 108 RVA: 0x0000302F File Offset: 0x0000122F
			public static ViewModelProvider.IFactory GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<ViewModelProvider.IFactory>(handle, transfer);
			}

			// Token: 0x0600006D RID: 109 RVA: 0x00003038 File Offset: 0x00001238
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, ViewModelProvider.IFactoryInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.lifecycle.ViewModelProvider.Factory'.");
				}
				return handle;
			}

			// Token: 0x0600006E RID: 110 RVA: 0x00003063 File Offset: 0x00001263
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x0600006F RID: 111 RVA: 0x00003094 File Offset: 0x00001294
			public IFactoryInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ViewModelProvider.IFactoryInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x04000018 RID: 24
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/lifecycle/ViewModelProvider$Factory", typeof(ViewModelProvider.IFactoryInvoker));

			// Token: 0x04000019 RID: 25
			private IntPtr class_ref;
		}
	}
}
