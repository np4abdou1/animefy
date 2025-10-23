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
	// Token: 0x0200001A RID: 26
	[Register("androidx/loader/app/LoaderManager", DoNotGenerateAcw = true)]
	internal class LoaderManagerInvoker : LoaderManager
	{
		// Token: 0x060000E1 RID: 225 RVA: 0x0000388A File Offset: 0x00001A8A
		public LoaderManagerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x00003894 File Offset: 0x00001A94
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return LoaderManagerInvoker._members;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x0000389B File Offset: 0x00001A9B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return LoaderManagerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x000038A8 File Offset: 0x00001AA8
		[Register("destroyLoader", "(I)V", "GetDestroyLoader_IHandler")]
		public unsafe override void DestroyLoader(int p0)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(p0);
			LoaderManagerInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("destroyLoader.(I)V", this, ptr);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x000038E4 File Offset: 0x00001AE4
		[Register("dump", "(Ljava/lang/String;Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/String;)V", "GetDump_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_Handler")]
		public unsafe override void Dump(string p0, FileDescriptor p1, PrintWriter p2, string[] p3)
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
				LoaderManagerInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("dump.(Ljava/lang/String;Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/String;)V", this, ptr);
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

		// Token: 0x060000E6 RID: 230 RVA: 0x000039CC File Offset: 0x00001BCC
		[Register("getLoader", "(I)Landroidx/loader/content/Loader;", "GetGetLoader_IHandler")]
		[JavaTypeParameters(new string[]
		{
			"D"
		})]
		public unsafe override Loader GetLoader(int p0)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(p0);
			return Java.Lang.Object.GetObject<Loader>(LoaderManagerInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getLoader.(I)Landroidx/loader/content/Loader;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00003A18 File Offset: 0x00001C18
		[Register("initLoader", "(ILandroid/os/Bundle;Landroidx/loader/app/LoaderManager$LoaderCallbacks;)Landroidx/loader/content/Loader;", "GetInitLoader_ILandroid_os_Bundle_Landroidx_loader_app_LoaderManager_LoaderCallbacks_Handler")]
		[JavaTypeParameters(new string[]
		{
			"D"
		})]
		public unsafe override Loader InitLoader(int p0, Bundle p1, LoaderManager.ILoaderCallbacks p2)
		{
			Loader @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(p0);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : ((Java.Lang.Object)p2).Handle);
				@object = Java.Lang.Object.GetObject<Loader>(LoaderManagerInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("initLoader.(ILandroid/os/Bundle;Landroidx/loader/app/LoaderManager$LoaderCallbacks;)Landroidx/loader/content/Loader;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p1);
				GC.KeepAlive(p2);
			}
			return @object;
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00003AD0 File Offset: 0x00001CD0
		[Register("markForRedelivery", "()V", "GetMarkForRedeliveryHandler")]
		public override void MarkForRedelivery()
		{
			LoaderManagerInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("markForRedelivery.()V", this, null);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00003AEC File Offset: 0x00001CEC
		[Register("restartLoader", "(ILandroid/os/Bundle;Landroidx/loader/app/LoaderManager$LoaderCallbacks;)Landroidx/loader/content/Loader;", "GetRestartLoader_ILandroid_os_Bundle_Landroidx_loader_app_LoaderManager_LoaderCallbacks_Handler")]
		[JavaTypeParameters(new string[]
		{
			"D"
		})]
		public unsafe override Loader RestartLoader(int p0, Bundle p1, LoaderManager.ILoaderCallbacks p2)
		{
			Loader @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(p0);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : ((Java.Lang.Object)p2).Handle);
				@object = Java.Lang.Object.GetObject<Loader>(LoaderManagerInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("restartLoader.(ILandroid/os/Bundle;Landroidx/loader/app/LoaderManager$LoaderCallbacks;)Landroidx/loader/content/Loader;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p1);
				GC.KeepAlive(p2);
			}
			return @object;
		}

		// Token: 0x04000038 RID: 56
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/loader/app/LoaderManager", typeof(LoaderManagerInvoker));
	}
}
