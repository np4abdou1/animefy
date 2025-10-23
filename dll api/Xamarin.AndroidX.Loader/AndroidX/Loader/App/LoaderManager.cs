using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using AndroidX.Loader.Content;
using Java.Interop;
using Java.IO;
using Java.Lang;

namespace AndroidX.Loader.App
{
	// Token: 0x02000017 RID: 23
	[Register("androidx/loader/app/LoaderManager", DoNotGenerateAcw = true)]
	public abstract class LoaderManager : Java.Lang.Object
	{
		// Token: 0x17000012 RID: 18
		// (get) Token: 0x060000AE RID: 174 RVA: 0x00003164 File Offset: 0x00001364
		internal static IntPtr class_ref
		{
			get
			{
				return LoaderManager._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x060000AF RID: 175 RVA: 0x00003188 File Offset: 0x00001388
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return LoaderManager._members;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x00003190 File Offset: 0x00001390
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return LoaderManager._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x000031B4 File Offset: 0x000013B4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return LoaderManager._members.ManagedPeerType;
			}
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x000020DC File Offset: 0x000002DC
		protected LoaderManager(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x000031C0 File Offset: 0x000013C0
		[Register(".ctor", "()V", "")]
		public LoaderManager() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(LoaderManager._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			LoaderManager._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x0000322E File Offset: 0x0000142E
		private static Delegate GetHasRunningLoadersHandler()
		{
			if (LoaderManager.cb_hasRunningLoaders == null)
			{
				LoaderManager.cb_hasRunningLoaders = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(LoaderManager.n_HasRunningLoaders));
			}
			return LoaderManager.cb_hasRunningLoaders;
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00003252 File Offset: 0x00001452
		private static bool n_HasRunningLoaders(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<LoaderManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HasRunningLoaders;
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x00003261 File Offset: 0x00001461
		public virtual bool HasRunningLoaders
		{
			[Register("hasRunningLoaders", "()Z", "GetHasRunningLoadersHandler")]
			get
			{
				return LoaderManager._members.InstanceMethods.InvokeVirtualBooleanMethod("hasRunningLoaders.()Z", this, null);
			}
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x0000327A File Offset: 0x0000147A
		private static Delegate GetDestroyLoader_IHandler()
		{
			if (LoaderManager.cb_destroyLoader_I == null)
			{
				LoaderManager.cb_destroyLoader_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(LoaderManager.n_DestroyLoader_I));
			}
			return LoaderManager.cb_destroyLoader_I;
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x0000329E File Offset: 0x0000149E
		private static void n_DestroyLoader_I(IntPtr jnienv, IntPtr native__this, int p0)
		{
			Java.Lang.Object.GetObject<LoaderManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DestroyLoader(p0);
		}

		// Token: 0x060000B9 RID: 185
		[Register("destroyLoader", "(I)V", "GetDestroyLoader_IHandler")]
		public abstract void DestroyLoader(int p0);

		// Token: 0x060000BA RID: 186 RVA: 0x000032AE File Offset: 0x000014AE
		private static Delegate GetDump_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_Handler()
		{
			if (LoaderManager.cb_dump_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_ == null)
			{
				LoaderManager.cb_dump_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLL_V(LoaderManager.n_Dump_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_));
			}
			return LoaderManager.cb_dump_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_;
		}

		// Token: 0x060000BB RID: 187 RVA: 0x000032D4 File Offset: 0x000014D4
		private static void n_Dump_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			LoaderManager @object = Java.Lang.Object.GetObject<LoaderManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		// Token: 0x060000BC RID: 188
		[Register("dump", "(Ljava/lang/String;Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/String;)V", "GetDump_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_Handler")]
		public abstract void Dump(string p0, FileDescriptor p1, PrintWriter p2, string[] p3);

		// Token: 0x060000BD RID: 189 RVA: 0x00003330 File Offset: 0x00001530
		[Register("enableDebugLogging", "(Z)V", "")]
		public unsafe static void EnableDebugLogging(bool enabled)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(enabled);
			LoaderManager._members.StaticMethods.InvokeVoidMethod("enableDebugLogging.(Z)V", ptr);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x0000336C File Offset: 0x0000156C
		[Register("getInstance", "(Landroidx/lifecycle/LifecycleOwner;)Landroidx/loader/app/LoaderManager;", "")]
		[JavaTypeParameters(new string[]
		{
			"T extends androidx.lifecycle.LifecycleOwner & androidx.lifecycle.ViewModelStoreOwner"
		})]
		public unsafe static LoaderManager GetInstance(Java.Lang.Object owner)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(owner);
			LoaderManager @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<LoaderManager>(LoaderManager._members.StaticMethods.InvokeObjectMethod("getInstance.(Landroidx/lifecycle/LifecycleOwner;)Landroidx/loader/app/LoaderManager;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(owner);
			}
			return @object;
		}

		// Token: 0x060000BF RID: 191 RVA: 0x000033DC File Offset: 0x000015DC
		private static Delegate GetGetLoader_IHandler()
		{
			if (LoaderManager.cb_getLoader_I == null)
			{
				LoaderManager.cb_getLoader_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(LoaderManager.n_GetLoader_I));
			}
			return LoaderManager.cb_getLoader_I;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00003400 File Offset: 0x00001600
		private static IntPtr n_GetLoader_I(IntPtr jnienv, IntPtr native__this, int p0)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<LoaderManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetLoader(p0));
		}

		// Token: 0x060000C1 RID: 193
		[Register("getLoader", "(I)Landroidx/loader/content/Loader;", "GetGetLoader_IHandler")]
		[JavaTypeParameters(new string[]
		{
			"D"
		})]
		public abstract Loader GetLoader(int p0);

		// Token: 0x060000C2 RID: 194 RVA: 0x00003415 File Offset: 0x00001615
		private static Delegate GetInitLoader_ILandroid_os_Bundle_Landroidx_loader_app_LoaderManager_LoaderCallbacks_Handler()
		{
			if (LoaderManager.cb_initLoader_ILandroid_os_Bundle_Landroidx_loader_app_LoaderManager_LoaderCallbacks_ == null)
			{
				LoaderManager.cb_initLoader_ILandroid_os_Bundle_Landroidx_loader_app_LoaderManager_LoaderCallbacks_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPILL_L(LoaderManager.n_InitLoader_ILandroid_os_Bundle_Landroidx_loader_app_LoaderManager_LoaderCallbacks_));
			}
			return LoaderManager.cb_initLoader_ILandroid_os_Bundle_Landroidx_loader_app_LoaderManager_LoaderCallbacks_;
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x0000343C File Offset: 0x0000163C
		private static IntPtr n_InitLoader_ILandroid_os_Bundle_Landroidx_loader_app_LoaderManager_LoaderCallbacks_(IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			LoaderManager @object = Java.Lang.Object.GetObject<LoaderManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bundle object2 = Java.Lang.Object.GetObject<Bundle>(native_p1, JniHandleOwnership.DoNotTransfer);
			LoaderManager.ILoaderCallbacks object3 = Java.Lang.Object.GetObject<LoaderManager.ILoaderCallbacks>(native_p2, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.InitLoader(p0, object2, object3));
		}

		// Token: 0x060000C4 RID: 196
		[Register("initLoader", "(ILandroid/os/Bundle;Landroidx/loader/app/LoaderManager$LoaderCallbacks;)Landroidx/loader/content/Loader;", "GetInitLoader_ILandroid_os_Bundle_Landroidx_loader_app_LoaderManager_LoaderCallbacks_Handler")]
		[JavaTypeParameters(new string[]
		{
			"D"
		})]
		public abstract Loader InitLoader(int p0, Bundle p1, LoaderManager.ILoaderCallbacks p2);

		// Token: 0x060000C5 RID: 197 RVA: 0x0000346F File Offset: 0x0000166F
		private static Delegate GetMarkForRedeliveryHandler()
		{
			if (LoaderManager.cb_markForRedelivery == null)
			{
				LoaderManager.cb_markForRedelivery = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(LoaderManager.n_MarkForRedelivery));
			}
			return LoaderManager.cb_markForRedelivery;
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00003493 File Offset: 0x00001693
		private static void n_MarkForRedelivery(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<LoaderManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MarkForRedelivery();
		}

		// Token: 0x060000C7 RID: 199
		[Register("markForRedelivery", "()V", "GetMarkForRedeliveryHandler")]
		public abstract void MarkForRedelivery();

		// Token: 0x060000C8 RID: 200 RVA: 0x000034A2 File Offset: 0x000016A2
		private static Delegate GetRestartLoader_ILandroid_os_Bundle_Landroidx_loader_app_LoaderManager_LoaderCallbacks_Handler()
		{
			if (LoaderManager.cb_restartLoader_ILandroid_os_Bundle_Landroidx_loader_app_LoaderManager_LoaderCallbacks_ == null)
			{
				LoaderManager.cb_restartLoader_ILandroid_os_Bundle_Landroidx_loader_app_LoaderManager_LoaderCallbacks_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPILL_L(LoaderManager.n_RestartLoader_ILandroid_os_Bundle_Landroidx_loader_app_LoaderManager_LoaderCallbacks_));
			}
			return LoaderManager.cb_restartLoader_ILandroid_os_Bundle_Landroidx_loader_app_LoaderManager_LoaderCallbacks_;
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x000034C8 File Offset: 0x000016C8
		private static IntPtr n_RestartLoader_ILandroid_os_Bundle_Landroidx_loader_app_LoaderManager_LoaderCallbacks_(IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			LoaderManager @object = Java.Lang.Object.GetObject<LoaderManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bundle object2 = Java.Lang.Object.GetObject<Bundle>(native_p1, JniHandleOwnership.DoNotTransfer);
			LoaderManager.ILoaderCallbacks object3 = Java.Lang.Object.GetObject<LoaderManager.ILoaderCallbacks>(native_p2, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.RestartLoader(p0, object2, object3));
		}

		// Token: 0x060000CA RID: 202
		[Register("restartLoader", "(ILandroid/os/Bundle;Landroidx/loader/app/LoaderManager$LoaderCallbacks;)Landroidx/loader/content/Loader;", "GetRestartLoader_ILandroid_os_Bundle_Landroidx_loader_app_LoaderManager_LoaderCallbacks_Handler")]
		[JavaTypeParameters(new string[]
		{
			"D"
		})]
		public abstract Loader RestartLoader(int p0, Bundle p1, LoaderManager.ILoaderCallbacks p2);

		// Token: 0x04000028 RID: 40
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/loader/app/LoaderManager", typeof(LoaderManager));

		// Token: 0x04000029 RID: 41
		private static Delegate cb_hasRunningLoaders;

		// Token: 0x0400002A RID: 42
		private static Delegate cb_destroyLoader_I;

		// Token: 0x0400002B RID: 43
		private static Delegate cb_dump_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_;

		// Token: 0x0400002C RID: 44
		private static Delegate cb_getLoader_I;

		// Token: 0x0400002D RID: 45
		private static Delegate cb_initLoader_ILandroid_os_Bundle_Landroidx_loader_app_LoaderManager_LoaderCallbacks_;

		// Token: 0x0400002E RID: 46
		private static Delegate cb_markForRedelivery;

		// Token: 0x0400002F RID: 47
		private static Delegate cb_restartLoader_ILandroid_os_Bundle_Landroidx_loader_app_LoaderManager_LoaderCallbacks_;

		// Token: 0x02000018 RID: 24
		[Register("androidx/loader/app/LoaderManager$LoaderCallbacks", "", "AndroidX.Loader.App.LoaderManager/ILoaderCallbacksInvoker")]
		[JavaTypeParameters(new string[]
		{
			"D"
		})]
		public interface ILoaderCallbacks : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x060000CC RID: 204
			[Register("onCreateLoader", "(ILandroid/os/Bundle;)Landroidx/loader/content/Loader;", "GetOnCreateLoader_ILandroid_os_Bundle_Handler:AndroidX.Loader.App.LoaderManager/ILoaderCallbacksInvoker, Xamarin.AndroidX.Loader")]
			Loader OnCreateLoader(int p0, Bundle p1);

			// Token: 0x060000CD RID: 205
			[Register("onLoadFinished", "(Landroidx/loader/content/Loader;Ljava/lang/Object;)V", "GetOnLoadFinished_Landroidx_loader_content_Loader_Ljava_lang_Object_Handler:AndroidX.Loader.App.LoaderManager/ILoaderCallbacksInvoker, Xamarin.AndroidX.Loader")]
			void OnLoadFinished(Loader p0, Java.Lang.Object p1);

			// Token: 0x060000CE RID: 206
			[Register("onLoaderReset", "(Landroidx/loader/content/Loader;)V", "GetOnLoaderReset_Landroidx_loader_content_Loader_Handler:AndroidX.Loader.App.LoaderManager/ILoaderCallbacksInvoker, Xamarin.AndroidX.Loader")]
			void OnLoaderReset(Loader p0);
		}

		// Token: 0x02000019 RID: 25
		[Register("androidx/loader/app/LoaderManager$LoaderCallbacks", DoNotGenerateAcw = true)]
		internal class ILoaderCallbacksInvoker : Java.Lang.Object, LoaderManager.ILoaderCallbacks, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000017 RID: 23
			// (get) Token: 0x060000CF RID: 207 RVA: 0x00003518 File Offset: 0x00001718
			private static IntPtr java_class_ref
			{
				get
				{
					return LoaderManager.ILoaderCallbacksInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000018 RID: 24
			// (get) Token: 0x060000D0 RID: 208 RVA: 0x0000353C File Offset: 0x0000173C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return LoaderManager.ILoaderCallbacksInvoker._members;
				}
			}

			// Token: 0x17000019 RID: 25
			// (get) Token: 0x060000D1 RID: 209 RVA: 0x00003543 File Offset: 0x00001743
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x1700001A RID: 26
			// (get) Token: 0x060000D2 RID: 210 RVA: 0x0000354B File Offset: 0x0000174B
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return LoaderManager.ILoaderCallbacksInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x060000D3 RID: 211 RVA: 0x00003557 File Offset: 0x00001757
			public static LoaderManager.ILoaderCallbacks GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<LoaderManager.ILoaderCallbacks>(handle, transfer);
			}

			// Token: 0x060000D4 RID: 212 RVA: 0x00003560 File Offset: 0x00001760
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, LoaderManager.ILoaderCallbacksInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.loader.app.LoaderManager.LoaderCallbacks'.");
				}
				return handle;
			}

			// Token: 0x060000D5 RID: 213 RVA: 0x0000358B File Offset: 0x0000178B
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x060000D6 RID: 214 RVA: 0x000035BC File Offset: 0x000017BC
			public ILoaderCallbacksInvoker(IntPtr handle, JniHandleOwnership transfer) : base(LoaderManager.ILoaderCallbacksInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x060000D7 RID: 215 RVA: 0x000035F4 File Offset: 0x000017F4
			private static Delegate GetOnCreateLoader_ILandroid_os_Bundle_Handler()
			{
				if (LoaderManager.ILoaderCallbacksInvoker.cb_onCreateLoader_ILandroid_os_Bundle_ == null)
				{
					LoaderManager.ILoaderCallbacksInvoker.cb_onCreateLoader_ILandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_L(LoaderManager.ILoaderCallbacksInvoker.n_OnCreateLoader_ILandroid_os_Bundle_));
				}
				return LoaderManager.ILoaderCallbacksInvoker.cb_onCreateLoader_ILandroid_os_Bundle_;
			}

			// Token: 0x060000D8 RID: 216 RVA: 0x00003618 File Offset: 0x00001818
			private static IntPtr n_OnCreateLoader_ILandroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
			{
				LoaderManager.ILoaderCallbacks @object = Java.Lang.Object.GetObject<LoaderManager.ILoaderCallbacks>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Bundle object2 = Java.Lang.Object.GetObject<Bundle>(native_p1, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.OnCreateLoader(p0, object2));
			}

			// Token: 0x060000D9 RID: 217 RVA: 0x00003644 File Offset: 0x00001844
			public unsafe Loader OnCreateLoader(int p0, Bundle p1)
			{
				if (this.id_onCreateLoader_ILandroid_os_Bundle_ == IntPtr.Zero)
				{
					this.id_onCreateLoader_ILandroid_os_Bundle_ = JNIEnv.GetMethodID(this.class_ref, "onCreateLoader", "(ILandroid/os/Bundle;)Landroidx/loader/content/Loader;");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue(p0);
				ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				return Java.Lang.Object.GetObject<Loader>(JNIEnv.CallObjectMethod(base.Handle, this.id_onCreateLoader_ILandroid_os_Bundle_, ptr), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x060000DA RID: 218 RVA: 0x000036D0 File Offset: 0x000018D0
			private static Delegate GetOnLoadFinished_Landroidx_loader_content_Loader_Ljava_lang_Object_Handler()
			{
				if (LoaderManager.ILoaderCallbacksInvoker.cb_onLoadFinished_Landroidx_loader_content_Loader_Ljava_lang_Object_ == null)
				{
					LoaderManager.ILoaderCallbacksInvoker.cb_onLoadFinished_Landroidx_loader_content_Loader_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(LoaderManager.ILoaderCallbacksInvoker.n_OnLoadFinished_Landroidx_loader_content_Loader_Ljava_lang_Object_));
				}
				return LoaderManager.ILoaderCallbacksInvoker.cb_onLoadFinished_Landroidx_loader_content_Loader_Ljava_lang_Object_;
			}

			// Token: 0x060000DB RID: 219 RVA: 0x000036F4 File Offset: 0x000018F4
			private static void n_OnLoadFinished_Landroidx_loader_content_Loader_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				LoaderManager.ILoaderCallbacks @object = Java.Lang.Object.GetObject<LoaderManager.ILoaderCallbacks>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Loader object2 = Java.Lang.Object.GetObject<Loader>(native_p0, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p1, JniHandleOwnership.DoNotTransfer);
				@object.OnLoadFinished(object2, object3);
			}

			// Token: 0x060000DC RID: 220 RVA: 0x00003720 File Offset: 0x00001920
			public unsafe void OnLoadFinished(Loader p0, Java.Lang.Object p1)
			{
				if (this.id_onLoadFinished_Landroidx_loader_content_Loader_Ljava_lang_Object_ == IntPtr.Zero)
				{
					this.id_onLoadFinished_Landroidx_loader_content_Loader_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "onLoadFinished", "(Landroidx/loader/content/Loader;Ljava/lang/Object;)V");
				}
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(p1);
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JValue(intPtr);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onLoadFinished_Landroidx_loader_content_Loader_Ljava_lang_Object_, ptr);
				JNIEnv.DeleteLocalRef(intPtr);
			}

			// Token: 0x060000DD RID: 221 RVA: 0x000037B3 File Offset: 0x000019B3
			private static Delegate GetOnLoaderReset_Landroidx_loader_content_Loader_Handler()
			{
				if (LoaderManager.ILoaderCallbacksInvoker.cb_onLoaderReset_Landroidx_loader_content_Loader_ == null)
				{
					LoaderManager.ILoaderCallbacksInvoker.cb_onLoaderReset_Landroidx_loader_content_Loader_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(LoaderManager.ILoaderCallbacksInvoker.n_OnLoaderReset_Landroidx_loader_content_Loader_));
				}
				return LoaderManager.ILoaderCallbacksInvoker.cb_onLoaderReset_Landroidx_loader_content_Loader_;
			}

			// Token: 0x060000DE RID: 222 RVA: 0x000037D8 File Offset: 0x000019D8
			private static void n_OnLoaderReset_Landroidx_loader_content_Loader_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				LoaderManager.ILoaderCallbacks @object = Java.Lang.Object.GetObject<LoaderManager.ILoaderCallbacks>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Loader object2 = Java.Lang.Object.GetObject<Loader>(native_p0, JniHandleOwnership.DoNotTransfer);
				@object.OnLoaderReset(object2);
			}

			// Token: 0x060000DF RID: 223 RVA: 0x000037FC File Offset: 0x000019FC
			public unsafe void OnLoaderReset(Loader p0)
			{
				if (this.id_onLoaderReset_Landroidx_loader_content_Loader_ == IntPtr.Zero)
				{
					this.id_onLoaderReset_Landroidx_loader_content_Loader_ = JNIEnv.GetMethodID(this.class_ref, "onLoaderReset", "(Landroidx/loader/content/Loader;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onLoaderReset_Landroidx_loader_content_Loader_, ptr);
			}

			// Token: 0x04000030 RID: 48
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/loader/app/LoaderManager$LoaderCallbacks", typeof(LoaderManager.ILoaderCallbacksInvoker));

			// Token: 0x04000031 RID: 49
			private IntPtr class_ref;

			// Token: 0x04000032 RID: 50
			private static Delegate cb_onCreateLoader_ILandroid_os_Bundle_;

			// Token: 0x04000033 RID: 51
			private IntPtr id_onCreateLoader_ILandroid_os_Bundle_;

			// Token: 0x04000034 RID: 52
			private static Delegate cb_onLoadFinished_Landroidx_loader_content_Loader_Ljava_lang_Object_;

			// Token: 0x04000035 RID: 53
			private IntPtr id_onLoadFinished_Landroidx_loader_content_Loader_Ljava_lang_Object_;

			// Token: 0x04000036 RID: 54
			private static Delegate cb_onLoaderReset_Landroidx_loader_content_Loader_;

			// Token: 0x04000037 RID: 55
			private IntPtr id_onLoaderReset_Landroidx_loader_content_Loader_;
		}
	}
}
